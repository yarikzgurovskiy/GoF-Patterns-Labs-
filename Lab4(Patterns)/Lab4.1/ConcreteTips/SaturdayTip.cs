using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Patterns_ {
    public class SaturdayTip : TipState {
        public override void ShowTodayMedicine() {
            Console.WriteLine("-------Saturday-------");
            base.ShowTodayMedicine();
        }
        public override void NextDay(Helper helper) {
            helper.TipState = new SundayTip();
        }

        protected override string MorningMedicine() => "№3";
    }
}
