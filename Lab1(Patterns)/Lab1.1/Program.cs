using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Patterns_{
    class Program {
        static void Main(string[] args) {
            IMessageText message1 = new MessageText("Hello, Petro!", "John");
            IMessageText message2 = new MessageText("Hello, John! How are you?", "Petro");
            IMessageText message3 = new MessageText("I'm fine! Thanks)", "John");

            

            //decorate message1 example
            message1 = new FontColorDecorator(message1, ConsoleColor.DarkGreen);
            message1 = new TimeDecorator(message1);

            //decorate message2 example
            message2 = new FontSizeDecorator(message2, 23);
            message2 = new FontDecorator(message2, "Arial");

            //decorate message3 example
            message3 = new FontColorDecorator(message3, ConsoleColor.DarkCyan);
            message3 = new FontDecorator(message3, "Comic Sans");
            message3 = new FontSizeDecorator(message3, 50);
            message3 = new TimeDecorator(message3);

            //print messages
            message1.Print();
            message2.Print();
            message3.Print();
        }
    }
}
