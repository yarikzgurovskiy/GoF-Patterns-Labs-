using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab3_Patterns_ {
    public class GiftManager {
        private Dictionary<string, Gift> gifts = new Dictionary<string, Gift>();
        private static GiftManager instance;

        private GiftManager() {
            gifts.Add("S1", new Sweet("SuperSweet", "Roshen", Sweet.SweetType.Chocolate));
            gifts.Add("S2", new Sweet("KitKat", "Sweets", Sweet.SweetType.Chocolate));
            gifts.Add("S3", new Sweet("Jelly", "Svitoch", Sweet.SweetType.Jelly));
            gifts.Add("T1", new Toy("Car", "Igroteko", "blue"));
            gifts.Add("T2", new Toy("TeddyBear", "ToyUp", "brown"));
        }

        public static GiftManager Manager() {
            if (instance == null) instance = new GiftManager();
            return instance;
        }

        public Gift GetItem(string key) {
            if (gifts.ContainsKey(key)) return (Gift)gifts[key].Clone();
            else throw new Exception("No such key in GiftManager!");
        }

        public GiftPack FullPackCopy() {
            List<Gift> allGifts = new List<Gift>();
            foreach (Gift g in this.gifts.Values) allGifts.Add(g.Clone() as Gift); 
            return new GiftPack(allGifts.ToArray());
        }
    }
}
