namespace ListingScraper.Entities
{
    public class Address:EntityBase
    {
        public string FullAddress { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
