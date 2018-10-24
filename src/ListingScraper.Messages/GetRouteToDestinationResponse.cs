using System;

namespace ListingScraper.Messages
{
    public class GetRouteToDestinationResponse
    {
        public Guid OriginalRequestId { get; set; }
        public int DurationInMinutes { get; set; }
        public string RawJson { get; set; }
    }
}
