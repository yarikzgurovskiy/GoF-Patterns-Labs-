using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2 {
    /// <summary>
    /// receiver class
    /// </summary>
    public class Observatory {
        private readonly string name;

        public Observatory(string name) {
            this.name = name;
        }

        public void WatchStar() {
            Console.WriteLine($"Observatory {name} watches the star");
        }
    }
}
