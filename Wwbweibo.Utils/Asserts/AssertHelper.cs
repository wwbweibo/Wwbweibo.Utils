using System;
using System.Collections;
using System.Linq;

namespace Wwbweibo.Utils.Asserts
{
    public class AssertHelper
    {
        public static void AssertNull(object value, string message = "The value is null or empty")
        {
            if (value == null)
                throw new ArgumentException(message);
        }

        public static void AssertNullOrEmpty(IEnumerable seq, string message = "The value is null or empty")
        {
            if (seq == null || !seq.GetEnumerator().MoveNext())
                throw new ArgumentException(message);
        }

        public static void AssertNullOrEmpty(IQueryable seq, string message = "The value is null or empty")
        {
            if (seq == null || !seq.GetEnumerator().MoveNext())
                throw new ArgumentException(message);
        }
    }
}