
using MonthlyProject_FactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyProject_FactoryPattern.Factories
{
    public class CreditCardFactory : ICardFacory
    {
        public ICreditCard Create(CardType type)
        {

            {
                switch (type)
                {
                    case CardType.Silver:
                        // return new SilverCard();
                        return Activator.CreateInstance<SilverCard>();
                    case CardType.Gold:
                        return Activator.CreateInstance<GoldCard>();
                    case CardType.Platinum:
                        return Activator.CreateInstance<PlatinumCard>();
                    default:
                        throw new ArgumentException("Invalid type", "type");


                }
            }
        }

    }
}
