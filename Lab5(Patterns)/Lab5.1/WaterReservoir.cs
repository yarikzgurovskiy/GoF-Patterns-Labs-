using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1 {
    public abstract class WaterReservoir {
        protected WaterReservoir nextReservoir;
        protected string name;
        protected int waterAmount;

        public WaterReservoir(string name, int startWaterAmount) {
            this.name = name;
            WaterAmount = startWaterAmount;
        }

        public int WaterAmount {
            private get => waterAmount;
            set {
                if (value <= 0) throw new ArgumentException("Water amount must be a positive number");
                else this.waterAmount = value;
            }
        }
        public void FillByWater(int waterAmount) {
            if (waterAmount <= 0) throw new ArgumentException("Water amount must be a positive number");
            else this.waterAmount += waterAmount;
        }
        public abstract bool GetWater(int neededWater);
        public WaterReservoir NextReservoir {
            private get => nextReservoir;
            set {
                if (value != null) nextReservoir = value;
            }
        }
    }
}
