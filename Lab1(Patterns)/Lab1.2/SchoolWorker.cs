using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2 {
    public enum SchoolWorkerType { Teacher, HeadTeacher, Director }
    public class SchoolWorker : Collector {
        private List<Collector> subordinates;
        private SchoolWorkerType type;
        private int grade;
        private char letter;

        public SchoolWorker(string surname, SchoolWorkerType type) : base(surname) {
            subordinates = new List<Collector>();
            this.type = type;
        }

        public SchoolWorker(string surname, SchoolWorkerType type, int grade, char letter) : this(surname, type) {
            this.grade = grade;
            this.letter = letter;
        }

        public override void Add(Collector collector) {
            subordinates.Add(collector);
        }

        public override void Remove(Collector collector) {
            subordinates.Remove(collector);
        }

        public override void RaiseMoney(int money) {
            subordinates.ForEach(s => {
                double percent = Convert.ToDouble(s.ParentsStat) / Convert.ToDouble(ParentsStat);
                int moneyToCollect = (int)Math.Ceiling(Convert.ToDouble(money) * percent);
                s.RaiseMoney(moneyToCollect);
            });
        }

        public override int ParentsStat {
            get {
                int parents = 0;
                subordinates.ForEach(s => parents += s.ParentsStat);
                return parents;
            }
        }

        public override int GetMoneyInfo() {
            collectedMoney = 0;
            subordinates.ForEach(s => collectedMoney += s.GetMoneyInfo());
            return collectedMoney;
        }


        public override void Display(int indents) {
            Console.WriteLine($"{new String('-', indents)} Position: {type.ToString()} Surname: {surname} Collected: {collectedMoney}$");

            foreach (Collector subordinate in subordinates) subordinate.Display(indents + 4);
        }
    }
}
