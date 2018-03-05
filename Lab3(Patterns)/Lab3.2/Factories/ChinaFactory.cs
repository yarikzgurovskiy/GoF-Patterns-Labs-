using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2 {
    public class ChinaFactory : TechnologyFactory {
        public ChinaFactory(int compPrice, int tvPrice, int detailsCount, CompleteSetType completeSet) :
            base(compPrice, tvPrice, detailsCount, completeSet) { }
        public override ITelevision CreateTelevision(string name) {
            return new ChinaTelevision(name);
        }

        public override IComputer CreateComputer(string name) {
            return new ChinaComputer(name);
        }
    }
}
