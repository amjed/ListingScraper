using System;
using ListingScraper.Entities.Enums;

namespace ListingScraper.Messages
{
    public class ScrapeSite
    {
        public Guid RequestId { get; set; }
        public Source Source { get; set; }
        public int PageCount { get; set; }
    }
}