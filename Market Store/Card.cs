using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Market_Store
{
    public class Card : ICard
    {
        public CardType Type { get; set; }

        public Owner Owner { get; set; }

        public decimal TurnOver { get; set; }

        private decimal _discountRate;

        public decimal DiscountRate
        {
            get { return _discountRate; }
        }

        public Card() { }

        public Card(CardType type,Owner owner,decimal turnover)
        {
            this.Type = type;

            this.Owner = owner;

            this.TurnOver = turnover;
        }

        public decimal CalculateDsicount(decimal valueOfPurchase)
        {
            switch (Type)
            {
                //Bronze card
                case CardType.Bronze:
                    {
                        if(TurnOver < 100)
                        {
                            _discountRate = 0;
                        }else if (TurnOver > 100 && TurnOver < 300)
                        {
                            _discountRate = 0.01m;
                        }
                        else
                        {
                            _discountRate = 2.5m / 100;
                        }
                        //Print info
                        PrintInfo(valueOfPurchase);
                        break;
                    }

                    //Silver Card
                case CardType.Silver:
                    {
                        if(TurnOver <= 300)
                        {
                            _discountRate = 2 / 100;
                        }
                        else
                        {
                            _discountRate = 3.5m / 100;
                        }
                        //Print info
                        PrintInfo(valueOfPurchase);
                        break;
                    }

                //Gold Card
                case CardType.Gold:
                    {
                        _discountRate = 2 / 100;

                        if(_discountRate <= 10)
                        {
                            if (TurnOver % 100 == 0)
                            {
                                _discountRate += 0.1m;
                            }
                        }
                        
                        //Print info
                        PrintInfo(valueOfPurchase);
                        break;
                    }
            }

            return DiscountRate;
        }

        private void PrintInfo(decimal purchaseValue)
        {
            decimal total = purchaseValue - DiscountRate * purchaseValue;

            Console.WriteLine("Card Type: "+Type + "\n");

            Console.WriteLine("Turnover: $" + TurnOver + " " +"," 
                + "purchase value: $"+purchaseValue +"\n");

            Console.WriteLine("Discount rate: "+DiscountRate +"%"+"\n");

            Console.WriteLine("Discount: $"+DiscountRate * purchaseValue +"\n");

            Console.WriteLine("Total: $"+ total +"\n");
        }
    }
}
