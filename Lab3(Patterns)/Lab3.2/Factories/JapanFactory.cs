using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2 {
    public class JapanFactory : TechnologyFactory {
        public JapanFactory(int compPrice, int tvPrice, int detailsCount, CompleteSetType completeSet) :
            base(compPrice, tvPrice, detailsCount, completeSet) { }
        public override ITelevision CreateTelevision(string name) {
            return new JapanTelevision(name);
        }

        public override IComputer CreateComputer(string name) {
            return new JapanComputer(name);
        }
    }
}
