using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1 {
    public class Vendor {
        private WaterReservoir firstReservoir;
        private WaterReservoir secondReservoir;
        private WaterReservoir thirdReservoir;

        public Vendor(int waterInOneReservoir) {
            firstReservoir = new VendorWaterReservoir("First", waterInOneReservoir);
            secondReservoir = new VendorWaterReservoir("Second", waterInOneReservoir);
            thirdReservoir = new VendorWaterReservoir("Third", waterInOneReservoir);

            firstReservoir.NextReservoir = secondReservoir;
            secondReservoir.NextReservoir = thirdReservoir;
        }

        public bool GetWater(int neededWater) {
            return firstReservoir.GetWater(neededWater);
        }
        public void Fill(int waterAmount) {
            Console.WriteLine("Filling all reservoirs...");
            firstReservoir.FillByWater(waterAmount);
            secondReservoir.FillByWater(waterAmount);
            thirdReservoir.FillByWater(waterAmount);
        }
    }
}
