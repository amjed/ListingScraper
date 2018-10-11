using System;

namespace ListingScraper.Messages
{
    public class PageDownloaded
    {
        public Guid RequestId { get; set; }
        public Guid PageId { get; set; }
    }
}