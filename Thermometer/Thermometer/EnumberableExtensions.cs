using System;
using System.Collections.Generic;
using System.Text;

namespace Thermometer
{
    public static class EnumberableExtensions
    {
        public static void each<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action(item);
            }
        }
    }
}
