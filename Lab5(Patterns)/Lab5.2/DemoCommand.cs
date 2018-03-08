using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2 {
    class DemoCommand {
        static void Main(string[] args) {
            //receivers
            Observatory observatory = new Observatory("Kyiv");
            Observatory observatory2 = new Observatory("London");
            Observatory observatory3 = new Observatory("Munich");
            //command
            ICommand command = new ObserveCommand(observatory);
            //invoker
            ObserverCentre centre = new ObserverCentre(command);
            
            centre.StartWatching();
            //change executor
            Console.WriteLine("Changing executor...");
            centre.Observatory = observatory2;
            centre.StartWatching();

            Console.WriteLine("Changing executor once again...");
            centre.Observatory = observatory3;
            centre.StartWatching();
        }
    }
}
