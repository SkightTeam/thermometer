using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace Thermometer.Specs
{
    public class ThermometerSpecs
    {
        private It simple_iterator_should_send_notification_on_each = () =>
        {
            var notifications =Enumerable.Range(1, 10).Select(x=>(decimal)x).iterate().ToList();
            notifications.Count().ShouldEqual(10);
        };

        private It freezing_iterator_should_send_notification_on_0 = () =>
        {
            var notifications = new decimal[]{2,1,0,-1,-2,1,0,-3}.Select(x => (decimal)x).check_freezing().ToList();
            notifications.Count().ShouldEqual(2);
            notifications[0].Message.ShouldEqual("Freezing");
            notifications[1].Message.ShouldEqual("Freezing");
        };

       
    }
}
