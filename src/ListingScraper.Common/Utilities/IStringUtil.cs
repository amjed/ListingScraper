namespace ListingScraper.Common.Utilities
{
    public interface IStringUtil
    {
        byte[] Zip(string content);
        string Unzip(byte[] byteArray);
    }
}
