using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Patterns_ {
    class DemoPrototype {
        static void Main(string[] args) {
            Santa santa = Santa.CallSanta();
            santa.CreatePack(
                new Sweet("SuperSweet", "Roshen", Sweet.SweetType.Chocolate),
                new Sweet("KitKat", "Sweets", Sweet.SweetType.Chocolate),
                new Sweet("Jelly", "Svitoch", Sweet.SweetType.Jelly),
                new Toy("Car", "Igroteko", "blue"),
                new Toy("TeddyBear", "ToyUp", "brown")
                );

            int edition = 10;
            for(int i = 0; i < edition; i++) {
                Console.WriteLine(santa.SendPack().ToString());
            }
        }
    }
}
