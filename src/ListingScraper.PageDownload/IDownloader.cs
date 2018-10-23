using System;
using System.Threading.Tasks;

namespace ListingScraper.PageDownload
{
    public interface IDownloader: IDisposable
    {
        Task<string> Download(string url);
    }
}
