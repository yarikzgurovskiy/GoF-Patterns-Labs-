using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2 {
    public class ObserveCommand : ICommand {
        /// <summary>
        /// executor of command
        /// </summary>
        private Observatory observatory;
        public ObserveCommand(Observatory observatory) {
            Observatory = observatory;
        }

        public void Execute() {
            Observatory.WatchStar();
        }
            
        private Observatory Observatory {
            get => observatory;
            set {
                if (value != null) observatory = value;
                else throw new ArgumentNullException("Observatory cannot be NULL!");
            }
        }
    }
}
