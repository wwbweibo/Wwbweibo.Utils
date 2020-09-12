using System;
using System.Collections.Generic;
using System.Text;

namespace Wwbweibo.Utils.Extensions
{
    public static class  StringValueParser
    {
        public static short ToShort(this string str, short value = 0, bool throwException = false)
        {
            if (short.TryParse(str, out var num))
                return num;
            else if (throwException)
                throw new FormatException("the input value is not valid");
            return value;
        }

        public static int ToInt(this string str, int value = 0, bool throwException = false)
        {
            if (int.TryParse(str, out var num))
                return num;
            else if (throwException)
                throw new FormatException("the input value is not valid");
            return value;
        }

        public static long ToLong(this string str, long value = 0, bool throwException = false)
        {
            if (long.TryParse(str, out var num))
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
    }
}
