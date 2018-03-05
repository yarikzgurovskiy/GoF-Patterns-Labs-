using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2 {
    public class JapanTelevision : Device,  ITelevision {
        public JapanTelevision(string name) : base(name) { }


        public void ShowChannels() {
            Console.WriteLine($"Show channels on Japan TV {name}!");
        }
    }
}
