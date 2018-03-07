using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Patterns_ {
    class DemoState {
        static void Main(string[] args) {
            Helper h = new Helper(new WednesdayTip());
            
            for(int i = 0; i < 8; i++) {
                h.ShowTips();
                h.ChangeDay();
            }
        }
    }
}
