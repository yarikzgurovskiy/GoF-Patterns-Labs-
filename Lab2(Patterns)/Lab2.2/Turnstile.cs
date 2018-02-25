using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2 {
    class Turnstile {
        public void Verify(IPay pay) {
            if (pay.IsPayed() == 1) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Allowed");
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Forbidden");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
