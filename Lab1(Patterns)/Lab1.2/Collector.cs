using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2 {
    public abstract class Collector {
        protected string surname;
        protected int collectedMoney;

        protected Collector(string surname) {
            this.surname = surname;
        }

        public abstract void RaiseMoney(int money);
        public abstract int GetMoneyInfo();

        public abstract int ParentsStat {
            get;
        }

        public abstract void Add(Collector collector);
        public abstract void Remove(Collector collector);
        public abstract void Display(int indents);
    }
}
