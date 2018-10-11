using System;
using ListingScraper.Entities.Enums;

namespace ListingScraper.Messages
{
    public class PageDownloadData
    {
        public Guid DownloadPageRequestId { get; set; }
        public Source Source { get; set; }
        public string Url { get; set; }
    }
}