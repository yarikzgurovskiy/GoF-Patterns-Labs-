using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Patterns_ {
    class DemoProxy {
        static void Main(string[] args) {
            //create criminals
            Criminal c1 = new Criminal("Oleg Ivanenko", 24, CriminalType.Murder, DateTime.Now, new TimeSpan(4, 0, 0, 0));
            Criminal c2 = new Criminal("Stepan Onyshchenko", 20, CriminalType.Hooliganism, DateTime.Now, new TimeSpan(16, 0 ,0));

            //create proxy
            ICase @case = new CaseProxy();

            //trying add new criminals
            @case.AddToDB(c1);
            @case.AddToDB(c2);
        }
    }
}
