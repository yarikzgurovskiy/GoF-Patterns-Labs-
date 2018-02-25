using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Patterns_ {
    public enum CriminalType {
        Murder, Robbery, Brigandage, Hooliganism, Theft
    }
    public class Criminal {
        private string fullName;
        private int age;
        private CriminalType criminalType;
        private DateTime arrestDate;
        private TimeSpan arrestTerm;

        public Criminal(string fullName, int age, CriminalType criminalType, DateTime arrestDate, TimeSpan arrestTerm) {
            this.fullName = fullName;
            this.age = age;
            this.criminalType = criminalType;
            this.arrestDate = arrestDate;
            this.arrestTerm = arrestTerm;
        }

        public string FullName {
            get => fullName;
            set {
                if (!String.IsNullOrEmpty(value)) this.fullName = value;
            }
        }

        public int Age {
            get => age;
            set {
                if (value > 14) this.age = value;
            }
        }

        public CriminalType CriminalType { get; set; }

        public DateTime ArrestDate { get; set; }

        public TimeSpan ArrestTerm { get => arrestTerm; set { arrestTerm = value; } }

        public override string ToString() {
            StringBuilder criminalString = new StringBuilder("------------Criminal info:----------\n");
            criminalString.Append($"Fullname: {fullName}\n");
            criminalString.Append($"Age: {age}\n");
            criminalString.Append($"Criminal type: {criminalType.ToString()}\n");
            criminalString.Append($"Date of Arrest: {arrestDate.ToString()}\n");
            criminalString.Append($"Term of Arrest: {arrestTerm.TotalHours} hours\n");
            return criminalString.ToString();
        }
    }
}
