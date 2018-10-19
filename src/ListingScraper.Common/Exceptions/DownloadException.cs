using System;

namespace ListingScraper.Common.Exceptions
{
    public class DownloadException: Exception
    {
        public DownloadException(string message): 
            base(message)
        {
        }
    }
}
