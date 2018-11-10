using System;
using System.Collections.Generic;
using System.Text;

namespace abstractfactory
{
    public abstract class HostingPlanAbstractFactory
    {
        public static String WINDOWS = "Windows";
        public static String LINUX = "Linux";

        public static HostingPlanAbstractFactory getHostingFactory(String type)
        {
            if (type.Equals(HostingPlanAbstractFactory.WINDOWS))
            {
                return new WindowsHostingPlanFactory();
            }
            if (type.Equals(HostingPlanAbstractFactory.LINUX))
            {
                return new LinuxHostingPlanFactory();
            }
            return new LinuxHostingPlanFactory();
        }

        public abstract EconomyHostingPlan createEconomyHosting();

        public abstract DeluxeHostingPlan createDeluxeHosting();

        public abstract UltimateHostingPlan createUltimateHosting();
    }
}
