using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    public class Refrigerator
    {
        private double maximumWeight;
        private double item;
        private double itemWeight;

        public double MaxiMumWeight
        {
            set { this.maximumWeight = value; }
            get { return this.maximumWeight; }
            
        }
        public double Items
        {
            set { this.item = value; }
            get { return this.item; }
        }

        public double ItemWeight
        {
            set { this.itemWeight = value; }
            get { return this.itemWeight; }
        }
        public double GetItemList()
        {
            
            List<double> items = new List<double>();
            items.Add(this.item);
            double getItem = 0;
            for (var i = 0; i<items.Count; i++)
            {
                  getItem = items[i];
                
            }
            return getItem;
        }
        public double GetItemWeightList()
        {
            List<double> itemWeights = new List<double>();
            itemWeights.Add(this.itemWeight);
            double getWeight = 0;
            for(var i =0; i < itemWeights.Count; i++)
            {
                getWeight = itemWeights[i];
            }
            return getWeight;
        }

        public double GetCurrentWeight()
        {
            double currentWeight = this.item * this.itemWeight;
            return currentWeight;
            
        }
        public double GetRemainingWeight()
        {
            this.maximumWeight = this.maximumWeight - this.GetCurrentWeight();
            return this.maximumWeight;
        }


    }
}
