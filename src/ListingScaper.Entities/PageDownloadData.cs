using System;
using ListingScraper.Entities.Enums;

namespace ListingScraper.Entities
{
    public class PageDownloadData:EntityBase
    {
        public Source Source { get; set; }
        public string Url { get; set; }
        public PageDownloadStatus PageDownloadStatus { get; set; }
    }
}