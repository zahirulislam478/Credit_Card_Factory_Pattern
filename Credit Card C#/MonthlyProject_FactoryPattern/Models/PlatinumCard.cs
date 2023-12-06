using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyProject_FactoryPattern.Models
{
    public class PlatinumCard : ICreditCard
    {
        public PlatinumCard()
        {
            this.Type = CardType.Platinum;
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
        } = 150000.00M;
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
