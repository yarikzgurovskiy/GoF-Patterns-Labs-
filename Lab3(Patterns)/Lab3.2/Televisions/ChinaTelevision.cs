using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2 {
    public class ChinaTelevision : Device, ITelevision {

        public ChinaTelevision(string name) : base(name) { }

        public void ShowChannels() {
            Console.WriteLine($"Show channels on Chinese TV {name}!");
        }
    }
}
