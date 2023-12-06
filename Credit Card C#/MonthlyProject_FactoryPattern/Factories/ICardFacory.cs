
using MonthlyProject_FactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyProject_FactoryPattern.Factories
{
    public interface ICardFacory
    {
        ICreditCard Create(CardType type);
    }
}
