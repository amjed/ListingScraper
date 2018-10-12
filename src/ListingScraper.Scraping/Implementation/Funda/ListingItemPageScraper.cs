using System;
using System.Linq;
using System.Text.RegularExpressions;
using ListingScraper.Entities;
using Newtonsoft.Json;
using Supremes;
using Supremes.Nodes;

namespace ListingScraper.Scraping.Implementation.Funda
{
    public class ListingItemPageScraper:IListingItemPageScraper
    {
        private readonly Document _document;

        public ListingItemPageScraper(string pageHtml)
        {
            _document = Dcsoup.Parse(pageHtml);
        }

        public Property GetProperty()
        {
            return new Property
            {
                Price = GetPrice(),
                Rooms = GetRooms(),
                Address = GetAddress(),
                AreaInSquareMeters = GetAreaInSquareMeters(),
                CreatedDate = DateTime.Now,
            };
        }

        private int GetPrice()
        {
            int price = 0;
            var priceString = _document.Select(".object-header__price").Text;
            var digitsMatch = Regex.Replace(priceString, "[^\\d+]","");
            int.TryParse(digitsMatch, out price);
            return price;
        }

        private int GetRooms()
        {
            int rooms = 0;
            var roomsString = _document.Select("#content > div > div.object-primary > section.kenmerken-highlighted > ul > li:nth-child(3) > span.kenmerken-highlighted__details").Text;
            var digitsMatch = Regex.Match(roomsString, "\\d+", RegexOptions.CultureInvariant);
            if (digitsMatch.Success)
            {
                int.TryParse(digitsMatch.Value, out rooms);
            }
            return rooms;
        }

        private int GetAreaInSquareMeters()
        {
            int area = 0;
            var roomsString = _document.Select("#content > div > div.object-primary > section.kenmerken-highlighted > ul > li:nth-child(2) > span.kenmerken-highlighted__details").Text;
            var digitsMatch = Regex.Match(roomsString, "\\d+", RegexOptions.CultureInvariant);
            if (digitsMatch.Success)
            {
                int.TryParse(digitsMatch.Value, out area);
            }
            return area;
        }
        private Address GetAddress()
        {
            var coord = GetCoordinates();
            var fullAddess = GetFullAddress();
            if (coord == null && fullAddess == null)
                return null;

            return new Address
            {
                FullAddress = fullAddess,
                Latitude = coord.Latitude,
                Longitude = coord.Longitude

            };
        }

        private string GetFullAddress()
        {
            var addressString = _document.GetElementsByAttributeValue("name", "description").First(e=>e.Tag.Name == "meta");
            if (addressString == null)
                return null;
            var colIndex = addressString.Attr("content").IndexOf(':');
            if (colIndex > -1)
            {
                return addressString.Attr("content").Substring(colIndex + 1).Trim();
            }

            return null;
        }

        private Coordinate GetCoordinates()
        {
            var jsonElement = _document.GetElementsByTag("script").First(e => e.HasAttr("data-object-map-config"));
            if (jsonElement != null)
            {
                var obj = (dynamic)JsonConvert.DeserializeObject(jsonElement.Data);
                if (obj != null)
                {
                    return new Coordinate
                    {
                        Latitude = obj.lat,
                        Longitude = obj.lng
                    };
                };
            }
            return null;
        }
    }
}
