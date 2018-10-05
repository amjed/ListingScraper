using System;

namespace ListingScraper.Entities
{
    public class Property
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Rooms { get; set; }
        public int AreaInSquareMeters { get; set; }
        public Address Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
