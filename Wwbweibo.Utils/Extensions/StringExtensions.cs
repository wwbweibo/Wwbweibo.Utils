using System;
using System.Text;

namespace Wwbweibo.Utils.Extensions
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

        public static int ToInt(this string str, int value = 0, bool throwException = false)
        {
            if (int.TryParse(str, out var num))
                return num;
            else if (throwException)
                throw new FormatException("the input value is not valid");
            return value;
        }

        public static float ToFloat(this string str, float value = 0, bool throwException = false)
        {
            if (float.TryParse(str, out var num))
                return num;
            else if (throwException)
                throw new FormatException("the input value is not valid");
            return value;
        }

        public static double ToDouble(this string str, double value = 0, bool throwException = false)
        {
            if (double.TryParse(str, out var num))
                return num;
            else if (throwException)
                throw new FormatException("the input value is not valid");
            return value;
        }

        public static string Base64Encode(this string str, string encoding = "UTF-8")
        {
            var bytes = Encoding.GetEncoding(encoding).GetBytes(str);
            return Convert.ToBase64String(bytes);
        }

        public static string Base64Decode(this string str, string encoding = "UTF-8")
        {
            var data = Convert.FromBase64String(str);
            return Encoding.GetEncoding(encoding).GetString(data);
        }
    }
}