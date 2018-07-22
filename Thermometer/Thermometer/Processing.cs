using System;
using System.Collections.Generic;
using System.Text;

namespace Thermometer
{
    public static class Processing
    {
        public static IEnumerable<Notification> iterate(this IEnumerable<decimal> source)
        {
            foreach (var item in source)
            {
                yield return new Notification{Message = item.ToString(),CreatedDateTime = DateTime.Now};
            }
        }
    }
}
