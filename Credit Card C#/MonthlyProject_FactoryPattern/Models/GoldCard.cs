using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyProject_FactoryPattern.Models
{
    public class GoldCard : ICreditCard
    {
        public GoldCard()
        {
            this.Type = CardType.Gold;
        }
        public string CardNumber
        {
            get; set;
        }
        public CardType Type
        {
            get; set;
        }
        public string CardHolderName
        {
            get; set;
        }
        public decimal Limit
        {
            get;
        } = 100000.00M;
        public DateTime ExpiryDate
        {
            get; set;
        }
        public string GetDetails()
        {
            return $"{CardNumber.PadRight(20, ' ')} {CardHolderName.PadRight(25, ' ')} {Limit.ToString("0.00").PadRight(10, ' ')} {ExpiryDate.ToString("MMM, yyyy")}";
        }
    }
}
