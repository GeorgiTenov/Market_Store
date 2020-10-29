using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Store
{
    public interface ICard
    {
        CardType Type { get; set; }

        Owner Owner { get; set; }

        decimal TurnOver { get; set; }

        decimal DiscountRate { get;}
    }
}
