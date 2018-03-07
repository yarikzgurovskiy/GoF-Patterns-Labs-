using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Patterns_ {
    public class MondayTip : TipState {
        public override void ShowTodayMedicine() {
            Console.WriteLine("-------Monday-------");
            base.ShowTodayMedicine();
        }
        public override void NextDay(Helper helper) {
            helper.TipState = new TuesdayTip();
        }

        protected override string MorningMedicine() => "№1";
    }
}
