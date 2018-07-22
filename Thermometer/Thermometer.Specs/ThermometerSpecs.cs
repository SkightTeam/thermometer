﻿using System;
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
    }
}