using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Patterns_ {
    public class WednesdayTip : TipState {
        public override void ShowTodayMedicine() {
            Console.WriteLine("-------Wednesday-------");
            base.ShowTodayMedicine();
        }
        public override void NextDay(Helper helper) {
            helper.TipState = new ThursdayTip();
        }

        protected override string MorningMedicine() => "№3";
    }
}
