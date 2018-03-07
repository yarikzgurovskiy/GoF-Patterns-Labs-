using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Patterns_ {
    public class SundayTip : TipState {
        public override void NextDay(Helper helper) {
            helper.TipState = new MondayTip();
        }

        public override void ShowTodayMedicine() {
            Console.WriteLine("-------Sunday-------");
            Console.WriteLine("Today is a break in taking medication");
        }
        protected override string MorningMedicine() => "";
    }
}
