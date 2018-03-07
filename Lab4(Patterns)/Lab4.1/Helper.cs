using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Patterns_ {
    public class Helper {
        private TipState tipState;
        public Helper(TipState tipState) {
            TipState = tipState;
        }

        public TipState TipState {
            set {
                if (value != null) tipState = value;
                else throw new ArgumentNullException("Tip State cannot be NULL!");
            }
            get => tipState;
        }
        public void ShowTips() {
            tipState.ShowTodayMedicine();
        }
        public void ChangeDay() {
            tipState.NextDay(this);
        }
    }
}
