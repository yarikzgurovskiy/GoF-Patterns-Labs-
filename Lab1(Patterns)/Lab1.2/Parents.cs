using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2 {
    public class Parents : Collector {
        private static Random rnd = new Random();
        private const int minBudget = 1000;
        private const int maxBudget = 10000;
        private int budget;

        public Parents(string surname) : base(surname) {
            this.budget = rnd.Next(minBudget, maxBudget);
        }
        public override void Add(Collector c) { /* Implementation unnecessary */ }
        public override void Remove(Collector collector) { /* Implementation unnecessary */}

        public override void RaiseMoney(int money) {
            if (IsCanPay(money)) {
                this.collectedMoney = money;
                budget -= money;
            } else {
                collectedMoney = budget;
                budget = 0;
            }
        }

        public override void Display(int indents) {
            if (this.budget > 0) {
                Console.WriteLine($"{new String('-', indents)} {surname} Payed money: {collectedMoney}$ Current budget: {budget}$");
            } else {
                Console.WriteLine($"{new String('-', indents)} {surname} Sorry, but we can't pay all sum, we pay: {collectedMoney} Current budget: {budget}$");
            }
        }
        public override int GetMoneyInfo() {
            return collectedMoney;
        }

        public override int ParentsStat {
            get { return 1; }
        }

        private bool IsCanPay(int money) {
            return (budget - money) > 0;
        }
    }
}
