using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2 {
    public class ObserverCentre {
        private ICommand observeCommand;
        private Observatory observatory;

        public ObserverCentre(ICommand command) {
            observeCommand = command;
        }
        public Observatory Observatory {
            get => observatory;
            set {
                if (value != null) {
                    observatory = value;
                    observeCommand = new ObserveCommand(this.observatory);
                } else throw new ArgumentException("Observatory cannot be NULL!");
            }
        }

        public void StartWatching() {
            observeCommand.Execute();
        }
    }
}
