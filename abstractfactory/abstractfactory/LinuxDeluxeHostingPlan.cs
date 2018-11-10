using System;
using System.Collections.Generic;
using System.Text;

namespace abstractfactory
{
    class LinuxDeluxeHostingPlan : DeluxeHostingPlan
    {
        public string GetFeatures()
        {
            return "Linux Deluxe Hosting";
        }
    }
}
