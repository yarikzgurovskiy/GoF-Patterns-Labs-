using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2 {
    class ChildStrategy : IDocumentStrategy {
        public string RequiredDocuments(string name) {
            return $"{name}, please, bring your \"Сhild travel document\"";
        }
    }

    class EmployeeStrategy : IDocumentStrategy {
        public string RequiredDocuments(string name) {
            return $"Dear {name}, you need a certificate from the employer and payment letters";
        }
    }

    class EntrepreneurStrategy : IDocumentStrategy {
        public string RequiredDocuments(string name) {
            return $"Dear {name}, you need a copy of the income statement for the past 2 months";
        }
    }
}
