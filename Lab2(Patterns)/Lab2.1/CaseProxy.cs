using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Patterns_ {
    class CaseProxy : ICase {
        private static TimeSpan minArrestTerm = new TimeSpan(2, 0, 0, 0);

        Case @case = new Case();
        public void AddToDB(Criminal criminal) {
            if(criminal.ArrestTerm.TotalHours > minArrestTerm.TotalHours) {
                @case.AddToDB(criminal);
            } else {
                Console.WriteLine("There is no need of adding new Case!");
                Console.WriteLine(
                    $"Term of arrest: {criminal.ArrestTerm.TotalHours} hours" +
                    $"(minimal term: {minArrestTerm.TotalHours} hours)"
                );
            } 
        }
    }
}
