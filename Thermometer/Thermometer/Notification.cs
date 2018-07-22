using System;
using System.Collections.Generic;
using System.Text;

namespace Thermometer
{
    public class Notification
    {
        public string Message { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public override string ToString()
        {
            return $"{DateTime.Now}: <{Message}> Created On {CreatedDateTime}";
        }
    }
}
