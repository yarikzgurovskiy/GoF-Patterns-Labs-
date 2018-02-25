using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Patterns_ {
    class FontColorDecorator : Decorator {
        private ConsoleColor fontColor = ConsoleColor.White;
        public FontColorDecorator(IMessageText messageText, ConsoleColor fontColor) : base(messageText) {
            this.fontColor = fontColor;
        }

        public override void Print() {
            Console.ForegroundColor = fontColor;
            base.Print();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    class FontSizeDecorator : Decorator {
        private int fontSize;
        
        public FontSizeDecorator(IMessageText messageText, int fontSize) : base(messageText) {
            if (fontSize <= 0) return;
            this.fontSize = fontSize;
        }

        public override void Print() {
            Console.Write($"[Font size: {fontSize}]");
            base.Print();
        }
    }

    class FontDecorator : Decorator {
        private string fontFamily;
        public FontDecorator(IMessageText messageText, string fontFamily): base(messageText) {
            this.fontFamily = fontFamily;
        }

        public override void Print() {
            Console.Write($"[Font family: {fontFamily}]");
            base.Print();
        }
    }

    class TimeDecorator : Decorator {
        public TimeDecorator(IMessageText messageText) : base(messageText) { }

        public override void Print() {
            Console.Write($"{DateTime.Now.ToLongTimeString()} : ");
            base.Print();
        }
    }
}
