using System;
using System.Collections.Generic;
using System.Text;

namespace abstractfactory
{
    class WindowsDeluxeHostingPlan : DeluxeHostingPlan
    {
        public string GetFeatures()
        {
            return "Windows Deluxe Hosting";
        }
    }
}
