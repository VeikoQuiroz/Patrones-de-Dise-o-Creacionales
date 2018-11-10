using System;
using System.Collections.Generic;
using System.Text;

namespace abstractfactory
{
    class WindowsHostingPlanFactory : HostingPlanAbstractFactory
    {
        public override DeluxeHostingPlan createDeluxeHosting()
        {
            return new WindowsDeluxeHostingPlan();
        }

        public override EconomyHostingPlan createEconomyHosting()
        {
            return new WindowsEconomyHostingPlan();
        }

        public override UltimateHostingPlan createUltimateHosting()
        {
            return new WindowsUltimateHostingPlan();
        }
    }
}
