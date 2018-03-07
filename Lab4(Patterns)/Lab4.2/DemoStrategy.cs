using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2 {
    class DemoStrategy {
        static void Main(string[] args) {
            Person pers = new Person("Yaroslav");

            IDocumentStrategy emplStr = new EmployeeStrategy();
            IDocumentStrategy childStr = new ChildStrategy();
            IDocumentStrategy enterStr = new EntrepreneurStrategy();

            Console.WriteLine("Children ...");
            pers.DocStrategy = childStr;
            pers.ApplyVisa();
            Console.WriteLine();

            Console.WriteLine("Employee ...");
            pers.DocStrategy = emplStr;
            pers.ApplyVisa();
            Console.WriteLine();

            Console.WriteLine("Enterpreneur ...");
            pers.DocStrategy = enterStr;
            pers.ApplyVisa();
            Console.WriteLine();
        }   
    }
}
