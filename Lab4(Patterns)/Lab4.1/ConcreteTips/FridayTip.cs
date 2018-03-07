using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Patterns_ {
    public class FridayTip : TipState {
        public override void ShowTodayMedicine() {
            Console.WriteLine("------Friday-----");
            base.ShowTodayMedicine();
        }
        public override void NextDay(Helper helper) {
            helper.TipState = new SaturdayTip();
        }

        protected override string MorningMedicine() => "№2";
    }
}
