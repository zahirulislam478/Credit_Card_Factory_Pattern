using MonthlyProject_FactoryPattern.Factories;
using MonthlyProject_FactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyProject_FactoryPattern.Tests
{
    public class TestClass
    {
        ICardFacory cardFacory;
        public TestClass(ICardFacory cardFacory)
        {
            this.cardFacory = cardFacory;
        }
        public void Run()
        {
            Console.WriteLine("Factory Pattern");
            CreditCardFactory factory = new CreditCardFactory();
            List<ICreditCard> cards = new List<ICreditCard>();
            ICreditCard c1 = factory.Create(CardType.Gold);
            c1.CardNumber = "1212121212121212";
            c1.CardHolderName = "Harun-Or-Rashid";
            c1.ExpiryDate = new DateTime(2023, 12, 31);
            cards.Add(c1);
            ICreditCard c2 = factory.Create(CardType.Silver);
            c2.CardNumber = "1212121212121212";
            c2.CardHolderName = "Azmat Mahim";
            c2.ExpiryDate = new DateTime(2023, 12, 31);
            cards.Add(c2);
            Console.WriteLine($"{"Card No".PadRight(20, ' ')} {"Holder Name".PadRight(25, ' ')} {"Limit".PadRight(10, ' ')} Ex. Date");
            foreach (var c in cards)
            {
                Console.WriteLine(c.GetDetails());
            }
        }
    }
}
