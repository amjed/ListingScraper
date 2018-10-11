using System;

namespace ListingScraper.Messages
{
    public class DownloadPage
    {
        public Guid RequestId { get; set; }
        public string Url { get; set; }
    }
}