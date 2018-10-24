namespace ListingScraper.Messages
{
    public class PageDownloadSucceeded : PageDownloadStatus
    {
        public byte[] Content { get; set; }
    }
}