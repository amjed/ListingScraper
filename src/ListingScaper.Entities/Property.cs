namespace ListingScraper.Entities
{
    public class Property: EntityBase
    {
        public int Price { get; set; }
        public int Rooms { get; set; }
        public int AreaInSquareMeters { get; set; }
        public Address Address { get; set; }
    }
}
