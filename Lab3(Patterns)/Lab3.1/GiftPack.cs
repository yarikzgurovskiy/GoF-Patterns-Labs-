using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Patterns_ {
    public class GiftPack {
        private List<Gift> gifts;

        public GiftPack(params Gift[] gifts) {
            this.gifts = new List<Gift>();
            foreach (Gift gift in gifts) this.gifts.Add(gift);
        }

        public GiftPack GetCopy() {
            List<Gift> giftsCopy = new List<Gift>();
            foreach (Gift g in this.gifts) giftsCopy.Add(g.Clone() as Gift);
            return new GiftPack(giftsCopy.ToArray());
        }

        public override string ToString() {
            StringBuilder @string = new StringBuilder("----------Start Pack--------\r\n");
            foreach (Gift g in gifts) @string.Append($"{g.ToString()}\r\n");
            @string.Append("-----------End Pack-----------\r\n");
            return @string.ToString();
        }
    }
}
