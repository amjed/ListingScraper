using System;

namespace ListingScraper.Messages
{
    public abstract class PageDownloadStatus
    {
        public Guid OriginalRequestId { get; set; }
    }
}