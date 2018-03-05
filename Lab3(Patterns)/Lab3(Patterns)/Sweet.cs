using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Patterns_ {
    public class Sweet : Gift {
        public enum SweetType { Chocolate, Jelly, Mint, Sour };

        private SweetType sweetType;
        public Sweet(string name, string manufacturer, SweetType sweetType) : base(name, manufacturer) {
            this.sweetType = sweetType;
        }

        public override string ToString() {
            StringBuilder @string = new StringBuilder("Sweet: ");
            @string.Append(base.ToString());
            @string.Append($"Sweettype: {sweetType.ToString()}\r\n");
            return @string.ToString();
        }
    }
}
