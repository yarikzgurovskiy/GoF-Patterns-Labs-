using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2 {
    public enum CompleteSetType { Basic, VIP };
    public abstract class TechnologyFactory {
        protected int compPrice;
        protected int tvPrice;
        protected int detailsCount;
        protected CompleteSetType completeSet;
        public TechnologyFactory(
            int compPrice, 
            int tvPrice, 
            int detailsCount, 
            CompleteSetType completeSet
        ) {
            this.completeSet = completeSet;
            this.compPrice = compPrice;
            this.tvPrice = tvPrice;
            this.detailsCount = detailsCount;
        }
        public abstract ITelevision CreateTelevision(string name);
        public abstract IComputer CreateComputer(string name);
        public int ComputerPrice { get => compPrice; }
        public int TVPrice { get => tvPrice; }
        public int DetailsCount { get => detailsCount; }
        public CompleteSetType CompleteSet { get => completeSet; }
    }
}
