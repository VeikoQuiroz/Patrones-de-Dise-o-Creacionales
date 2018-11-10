using System;
using System.Collections.Generic;
using System.Text;

namespace abstractfactory
{
    class LinuxHostingPlanFactory : HostingPlanAbstractFactory
    {
        public override DeluxeHostingPlan createDeluxeHosting()
        {
            return new LinuxDeluxeHostingPlan();
        }

        public override EconomyHostingPlan createEconomyHosting()
        {
            return new LinuxEconomyHostingPlan();
        }

        public override UltimateHostingPlan createUltimateHosting()
        {
            return new LinuxUltimateHostingPlan();
        }
    }
}
