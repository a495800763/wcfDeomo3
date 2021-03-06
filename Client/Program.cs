using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFDemo3;
using System.ServiceModel;
using static System.Console;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Press enter to begin.");
            ReadLine();
            IAppControlService client = ChannelFactory<IAppControlService>.CreateChannel(
                new NetTcpBinding(),
                new EndpointAddress("net.tcp://localhost:8081/AppControlService"));
            WriteLine("Creating sun.");
            client.SetRadius(100, "yellow", 3);
            WriteLine("Press enter to begin.");
            ReadLine();
            WriteLine("Growing sun to red giant");
            client.SetRadius(200, "red", 5);
            WriteLine("Press enter to begin.");
            ReadLine();
            WriteLine("Collapsing sun to neutron star.");
            client.SetRadius(50, "AliceBlue", 2);
            WriteLine("Finished. Press enter to exit.");
            ReadLine();
        }
    }
}
