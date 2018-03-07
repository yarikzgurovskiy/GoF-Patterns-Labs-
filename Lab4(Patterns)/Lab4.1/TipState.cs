using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Patterns_ {
    public abstract class TipState {
        public virtual void ShowTodayMedicine() {
            Console.WriteLine($"Morning medicine: {MorningMedicine()}");
            Console.WriteLine($"Evening medicine: {EveningMedicine()}");
        }
        protected abstract String MorningMedicine();
        protected virtual String EveningMedicine() {
            return "№4";
        }
        public abstract void NextDay(Helper helper);
    }
}
