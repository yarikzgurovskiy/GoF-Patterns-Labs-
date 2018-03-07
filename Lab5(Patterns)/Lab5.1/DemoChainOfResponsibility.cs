using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1 {
    class DemoChainOfResponsibility {
        static void Main(string[] args) {
            Vendor vendor;
            do {
                Console.WriteLine("How many water do you want to pour into reservoirs?");
                try {
                    vendor = new Vendor(ReadWaterAmount());
                    break;
                } catch (ArgumentException ex) {
                    Console.WriteLine(ex.Message);
                }
            } while (true);


            do {
                Console.WriteLine("How many water do you need for coffee/tea?");
                try {
                    if (!vendor.GetWater(ReadWaterAmount())) {
                        Console.WriteLine("How many water you want to pour to reservoirs...");
                        vendor.Fill(ReadWaterAmount());
                    }
                } catch (ArgumentException ex) {
                    Console.WriteLine(ex.Message);
                }
            } while (true);
        }

        static int ReadWaterAmount() {
            if (Int32.TryParse(Console.ReadLine(), out int waterAmount)) {
                return waterAmount;
            } else {
                throw new ArgumentException("You must input number!");
            }
        }
    }
}
