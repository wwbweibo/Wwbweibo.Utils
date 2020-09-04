using System.Globalization;
using System.Text;

namespace Core.Extensions.Utils
{
    public static class StringExtensions
    {
        public static byte[] ToBytes(this string str, string encoding = "UTF-8")
        {
            return Encoding.GetEncoding(encoding).GetBytes(str);
        }

        public static string GetString(this byte[] data, string encoding = "UTF-8")
        {
            return Encoding.GetEncoding(encoding).GetString(data);
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}