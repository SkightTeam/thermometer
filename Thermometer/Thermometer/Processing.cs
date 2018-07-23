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

        public static IEnumerable<Notification> check_freezing(this IEnumerable<decimal> source)
        {
            foreach (var item in source)
            {
                if (item == 0)
                {
                    yield return new Notification { Message = "Freezing", CreatedDateTime = DateTime.Now };
                }
            }
        }
        public static IEnumerable<Trend> generate_trends(this IEnumerable<decimal> source)
        {
            decimal? previous;
            decimal? current=null;
            Trend? previousTrend = null;
            foreach (var item in source)
            {
                previous = current;
                current = item;
                if (previous.HasValue && current.HasValue)
                {
                    if (current > previous)
                    {
                        previousTrend = Trend.Up;
                        yield return Trend.Up;
                    }
                    else if(current < previous)
                    {
                        previousTrend = Trend.Down;
                        yield return Trend.Down;
                    }else
                    {
                        yield return previousTrend.Value;
                    }
                }
                else
                {
                    previousTrend = Trend.None;
                    yield return Trend.None;
                }
            }
        }

    }

    public enum Trend
    {
        None,
        Up,
        Down
    }
}
