using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows;

namespace AppControlService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AppControlService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AppControlService.svc or AppControlService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class AppControlService : IAppControlService
    {
        private MainWindow hostApp;

        public AppControlService(MainW)

        public void DoWork()
        {
        }
    }
}
