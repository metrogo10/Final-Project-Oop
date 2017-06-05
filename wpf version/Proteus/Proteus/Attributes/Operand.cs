using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proteus.Attributes
{
	[Serializable]
    public enum Operand
    {
        Equals,
        GreaterThan,
        LessThan,
        GreaterOrEqualTo,
        LessOrEqualTo,
        ProductOf,
        SumOf,
        DifferenceOf,
        QuotiantOf
    }
}