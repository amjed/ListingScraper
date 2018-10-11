using System;
using ListingScraper.Entities;
using ListingScraper.Entities.Enums;

namespace ListingScraper.Messages
{
    public class GetRouteToDestination
    {
        public Guid RequestId { get; set; }
        public Address Source { get; set; }
        public Address Destination { get; set; }
        public DateTime DepartAt { get; set; }
        public TransportType TransportType { get; set; }
    }
}