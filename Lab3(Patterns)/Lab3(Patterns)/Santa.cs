using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Patterns_ {
    public class Santa {
        private static Santa instance;
        private GiftPack giftPack;
        private Santa() { }

        public static Santa CallSanta() {
            if (instance == null) instance = new Santa();
            return instance;
        }

        public void CreatePack(params Gift[] gifts) {
            giftPack = new GiftPack(gifts);
        }

        public GiftPack SendPack() {
            return giftPack.GetCopy();
        }
    }
}
