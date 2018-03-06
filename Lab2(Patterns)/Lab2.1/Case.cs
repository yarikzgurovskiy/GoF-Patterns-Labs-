using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Patterns_ {
    class Case : ICase {
        public void AddToDB(Criminal criminal) {
            Console.WriteLine("Adding new criminal case to database...");
            Console.WriteLine(criminal.ToString());
        }
    }
}
