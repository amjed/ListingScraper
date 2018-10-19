using System.IO;
using System.IO.Compression;
using System.Text;

namespace ListingScraper.Common.Utilities
{
    public class StringUtil: IStringUtil
    {
        public byte[] Zip(string content)
        {
            var bytes = Encoding.UTF8.GetBytes(content);

            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream()) {
                using (var gs = new GZipStream(mso, CompressionMode.Compress)) {
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }

        public string Unzip(byte[] byteArray)
        {
            using (var msi = new MemoryStream(byteArray))
            using (var mso = new MemoryStream()) {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress)) {
                    CopyTo(gs, mso);
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }

        private static void CopyTo(Stream source, Stream destination) {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = source.Read(bytes, 0, bytes.Length)) != 0) {
                destination.Write(bytes, 0, cnt);
            }
        }
    }
}
