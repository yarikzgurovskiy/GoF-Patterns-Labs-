using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2 {
    class Person {
        private IDocumentStrategy docStrategy;
        private string name;

        public Person(string name) {
            this.name = name;
        }
        public IDocumentStrategy DocStrategy {
            set {
                if (value != null) docStrategy = value;
                else throw new ArgumentNullException("Document strategy cannot be NULL!");
            }
        }

        public void ApplyVisa() {
            Console.WriteLine(docStrategy.RequiredDocuments(name));
        }
    }
}
