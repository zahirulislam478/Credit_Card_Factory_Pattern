using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyProject_FactoryPattern.Models
{
    public interface ICreditCard
    {
        string CardNumber
        {
            get; set;
        }
        CardType Type
        {
            get; set;
        }
        string CardHolderName
        {
            get; set;
        }
        decimal Limit
        {
            get;
        }
        DateTime ExpiryDate
        {
            get; set;
        }
        string GetDetails();
    }
}
