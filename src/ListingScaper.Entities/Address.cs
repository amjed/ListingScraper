﻿namespace ListingScraper.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public Country Country { get; set; }
        public State State { get; set; }
        public City City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public Coordinate Coordinate { get; set; }
    }
}