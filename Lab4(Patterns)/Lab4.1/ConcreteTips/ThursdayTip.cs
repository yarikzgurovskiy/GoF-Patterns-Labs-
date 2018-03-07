using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Patterns_ {
    public class ThursdayTip : TipState {
        public override void ShowTodayMedicine() {
            Console.WriteLine("-------Thursday-------");
            base.ShowTodayMedicine();
        }
        public override void NextDay(Helper helper) {
            helper.TipState = new FridayTip();
        }

        protected override string MorningMedicine() => "№1";
    }
}
