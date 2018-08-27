using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodes
{
    public class A638ShoppingOffers
    {
        public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs)
        {
            return ShoppingOffers(price, special, needs, 0);
        }

        public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs, int curPay)
        {
            foreach (var productNeed in needs)
            {
                if (productNeed < 0)
                {
                    return Int32.MaxValue;
                }
            }
            
            int totalPrice = curPay + GetPrice(price, needs);
            foreach (var offer in special)
            {
                if(curPay + offer.Last() >= totalPrice)
                    continue;

                for (int i = 0; i < needs.Count; i++)
                {
                    needs[i] -= offer[i];
                }

                totalPrice = Math.Min(totalPrice, ShoppingOffers(price, special, needs, curPay + offer.Last()));
                
                for (int i = 0; i < needs.Count; i++)
                {
                    needs[i] += offer[i];
                }
            }

            return totalPrice;
        }

        public int GetPrice(IList<int> price, IList<int> needs)
        {
            int totalPrice = 0;
            for (int i = 0; i < needs.Count; i++)
            {
                totalPrice += (needs[i] * price[i]);
            }

            return totalPrice;
        }
    }
}