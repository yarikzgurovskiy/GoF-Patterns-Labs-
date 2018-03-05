using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2 {
    class DemoAbstractFactory {
        static void Main(string[] args) {
            Console.WriteLine("Determining cheapest factory...");
            Console.WriteLine();
            TechnologyFactory cheapestFactory = ChooseCheapestFactory(
                new JapanFactory(2300, 1200, 13, CompleteSetType.VIP), 
                new ChinaFactory(2000, 1400, 15, CompleteSetType.Basic)
                );

            ITelevision tv = cheapestFactory.CreateTelevision("Sony");
            IComputer comp = cheapestFactory.CreateComputer("Lenovo");
            tv.ShowChannels();
            comp.StoreInformation();
        }

        static TechnologyFactory ChooseCheapestFactory(params TechnologyFactory[] factories) {
            TechnologyFactory cheapest = factories[0];
            foreach(TechnologyFactory f in factories) {
                if (f.ComputerPrice + f.TVPrice < cheapest.ComputerPrice + cheapest.TVPrice) cheapest = f;
            }
            return cheapest;
        }
    }
}
