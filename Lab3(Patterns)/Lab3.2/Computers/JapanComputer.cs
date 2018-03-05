using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2 {
    public class JapanComputer : Device, IComputer {
        public JapanComputer(string name) : base(name) { }

        public void StoreInformation() {
            Console.WriteLine($"Storing info on Japan Computer {name}!");
        }
    }
}
