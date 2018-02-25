using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2 {
    class Passenger {
        IPassengerPay passenger;

        public Passenger(IPassengerPay pass) {
            passenger = pass;
        }

        public bool PayForTransit() {
            return passenger.PayForTransit();
        }
    }
    
    class TokenPassenger : IPassengerPay {
        private List<int> tokens;
        public TokenPassenger(List<int> tokens) {
            this.tokens = tokens;
        }
        public bool PayForTransit() {
            if(tokens.Count > 0) {
                tokens.RemoveAt(0);
                return true;
            }
            return false;
        }
    }

    class CardPassenger : IPassengerPay {
        private int tripCount;

        public CardPassenger(int tripCount) {
            this.tripCount = tripCount;
        }

        public bool PayForTransit() {
            if (tripCount > 0) {
                tripCount--;
                return true;
            }
            return false;
        }
    }

}
