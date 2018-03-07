using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Patterns_ {
    public class TuesdayTip : TipState {
        public override void ShowTodayMedicine() {
            Console.WriteLine("------Tuesday-----");
            base.ShowTodayMedicine();
        }
        public override void NextDay(Helper helper) {
            helper.TipState = new WednesdayTip();
        }

        protected override string MorningMedicine() => "№2";
    }
}
