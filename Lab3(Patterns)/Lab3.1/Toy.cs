using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Patterns_ {
    public class Toy : Gift {
        private string color;

        public Toy(string name, string manufacturer, string color) : base(name, manufacturer) {
            this.color = color;
        }

        public override string ToString() {
            StringBuilder @string = new StringBuilder("Toy: ");
            @string.Append(base.ToString());
            @string.Append($"Color: {color}\r\n");
            return @string.ToString();
        }
    }
}
