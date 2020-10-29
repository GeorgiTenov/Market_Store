using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner("Georgi","Tenov",23,"9612341412");
            //Bronze
            Card bronzeCard = new Card(CardType.Bronze,owner,0);
            bronzeCard.CalculateDsicount(150);

            Console.WriteLine("-----------------------------------"+"\n");

            //Silver
            Card silverCard = new Card(CardType.Silver, owner, 600);
            silverCard.CalculateDsicount(850);

            Console.WriteLine("-----------------------------------" + "\n");

            //Gold
            Card goldCard = new Card(CardType.Gold, owner, 1500);
            goldCard.CalculateDsicount(1300);
            
            Console.ReadKey();
        }
    }
}
