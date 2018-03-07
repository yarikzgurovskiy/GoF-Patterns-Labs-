using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1 {
    public class VendorWaterReservoir : WaterReservoir {
        public VendorWaterReservoir(string name, int waterAmount) : base(name, waterAmount) { }
        public override bool GetWater(int neededWater) {
            if (neededWater < 1) throw new ArgumentException("You must need positive amount of water!");
            if (waterAmount - neededWater >= 0) {
                waterAmount -= neededWater;
                Console.WriteLine($"Getting {neededWater}ml water from {this.name} reservoir(Amount: {waterAmount})");
                return true;
            } else if(nextReservoir != null) {
                return nextReservoir.GetWater(neededWater);
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please, fill all reservoirs with water!");
                Console.ResetColor();
                return false;
            }
        }
    }
}
