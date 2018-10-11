using System;
using ListingScraper.Entities.Enums;

namespace ListingScraper.Messages
{
    public class ScrapeListingPage
    {
        public Guid RequestId { get; set; }
        public Guid PageId { get; set; }
        public Source Source { get; set; }
    }
}