using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject
{
    class NumAttribute
    {
        private decimal Value;
        private Dictionary<string, decimal> dependancies;
        public decimal GetValue() { return Value; }
        public void SetValue(decimal Value) { this.Value = Value; }
    }
}