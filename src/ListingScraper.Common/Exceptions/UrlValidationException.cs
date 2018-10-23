using System;

namespace ListingScraper.Common.Exceptions
{
    public class UrlValidationException: Exception
    {
        public UrlValidationException(string message): 
            base(message)
        {
        }
    }
}
