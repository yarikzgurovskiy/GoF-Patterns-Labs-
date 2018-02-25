using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2 {
    class PayAdapter : Passenger, IPay {
        public PayAdapter(IPassengerPay pass) : base(pass) { }

        public byte IsPayed() {
            if (PayForTransit()) return 1;
            else return 0;
        }
    }
}
