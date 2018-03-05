using System;

namespace Lab3_Patterns_ {
    public abstract class Gift : ICloneable {
        protected string name;
        protected DateTime creationDate;
        protected string manufacturer;

        protected Gift(string name, string manufacturer) {
            this.name = name;
            this.manufacturer = manufacturer;
            this.creationDate = DateTime.Now;
        }

        public object Clone() {
            object clone = null;
            try {
                clone = this.MemberwiseClone();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return clone;
        }

        public override string ToString() {
            return $"{name}, { manufacturer} (Creation: {creationDate.ToString()})\r\n";
        }
    }
}
