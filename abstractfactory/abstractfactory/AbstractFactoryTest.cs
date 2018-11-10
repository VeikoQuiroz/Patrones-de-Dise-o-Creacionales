using System;

namespace abstractfactory
{
    class AbstractFactoryTest
    {
        static void Main(string[] args)
        {
            String hostingPlan = hosting.Default.HostingOS;
            HostingPlanAbstractFactory hostingFactory = HostingPlanAbstractFactory.getHostingFactory(hostingPlan);

            EconomyHostingPlan economyHostingPlan = hostingFactory.createEconomyHosting();
            Console.WriteLine(economyHostingPlan.getFeatures());

            DeluxeHostingPlan deluxeHostingPlan = hostingFactory.createDeluxeHosting();
            Console.WriteLine(deluxeHostingPlan.GetFeatures());

            UltimateHostingPlan ultimateHostingPlan = hostingFactory.createUltimateHosting();
            Console.WriteLine(ultimateHostingPlan.getFeatures());
            Console.ReadKey();
        }
    }
}
