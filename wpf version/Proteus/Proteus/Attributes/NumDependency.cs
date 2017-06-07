using Proteus.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proteus.Attributes
{
    //This is our Number Dependancy class, of which all NumAttributes will be constructed. This class stores up to two fields which can be either a reference to another NumAttribute, or a regular number.
    //This class has one method, which takes in a decimal, and performs math on it based on the Operand.
	[Serializable]
    public class NumDependency : IComparable<NumDependency>
    {
		private static int count;
		public static int Count{get { return count; }}
		private readonly int id;
		public int ID{get { return id; }}
		//This is telling us what operation we're performing.
		public Operand type;
        //The priority designates the order of operations. This is used to run dependancy checks in the correct order.
        private int priority;
        //Since we're allowing for the user to set dependancies based on numbers, or based on other fields, we need to verify which of those two options they're doing for each value.
        public bool v1IsRef { get; set; }
        public bool v2IsRef { get; set; }
        //Only two of these four will matter, depending on reference vs direct number.
        public decimal v1NonRef { get; set; }
        public decimal v2NonRef { get; set; }
        public string v1Ref { get; set; }
        public string v2Ref { get; set; }
        //Smart-properties for values 1 & 2, which returns the correct value based on the above bools.
        public decimal Value1
        {
            get
            {
				if (v1IsRef)
					return CharacterEngine.GetValue(v1Ref, ID);
				else
					return v1NonRef;
            }
        }
        public decimal Value2
        {
            get
            {
				if (v2IsRef)
					return CharacterEngine.GetValue(v2Ref, ID);
				else
					return v2NonRef;
            }
        }
        public Operand Type
        {
            get { return type; }
            set
            {
                type = value;
                UpdatePriority();
            }
        }
        private void UpdatePriority()
        {
            switch (type)
            {
                case Operand.DifferenceOf:
                    priority = 6;
                    break;
                case Operand.Equals:
                    priority = 1;
                    break;
                case Operand.ProductOf:
                    priority = 3;
                    break;
                case Operand.QuotiantOf:
                    priority = 4;
                    break;
                case Operand.SumOf:
                    priority = 5;
                    break;
                case Operand.GreaterOrEqualTo:
                case Operand.GreaterThan:
                case Operand.LessOrEqualTo:
                case Operand.LessThan:
                    priority = 7;
                    break;
            }
        }
        //The constructor takes in objects, bools, and a type. The type is stored directly. The objects are cast based on the bools, ensuring that our casts are always safe.
        //Because we're using objects which represent both possabilties of each value, we make our constructor more dynamic.
        public NumDependency(Operand type, bool v1IsRef, bool v2IsRef, object v1, object v2)
        {
			this.v1IsRef = v1IsRef;
			this.v2IsRef = v2IsRef;
			this.type = type;
			id = count++;
            //By using object we can cut down on data input, as long as our bools line up we can always cast safely.
            if (v1IsRef)
            {
                v1Ref = v1.ToString();
            }
            else
            {
                v1NonRef = decimal.Parse(v1.ToString());
            }
            if (v2IsRef)
            {
                v2Ref = v2.ToString();
            }
            else
            {
                v2NonRef = decimal.Parse(v2.ToString());
            }
        }
        //This is the method which will be run on a value to make sure it conforms to all required dependancies.
        public decimal CheckDependancy(decimal value)
        {
            switch (type)
            {
                case Operand.DifferenceOf:
                    value = Value1 - Value2;
                    break;
                case Operand.Equals:
                    value = Value1;
                    break;
                case Operand.GreaterOrEqualTo:
                    if (value < Value1)
                        value = Value1;
                    break;
                case Operand.GreaterThan:
                    if (value <= Value1)
                        value = Value1 + 1;
                    break;
                case Operand.LessOrEqualTo:
                    if (value > Value1)
                        value = Value1;
                    break;
                case Operand.LessThan:
                    if (value >= Value1)
                        value = Value1 - 1;
                    break;
                case Operand.ProductOf:
                    value = Value1 * Value2;
                    break;
                case Operand.QuotiantOf:
                    value = Value1 / Value2;
                    break;
                case Operand.SumOf:
                    value = Value1 + Value2;
                    break;
            }
            return value;
        }
        //This will be used to sort by order of operations when the dependancies are put into a list.
        public int CompareTo(NumDependency other)
        {
            throw new NotImplementedException();
        }
		public string Save()
		{
			return (Type + " :: " + priority + " :: " + v1IsRef + " :: " + (v1IsRef ? v1Ref : v1NonRef.ToString()) + " :: " + v2IsRef + " :: " + (v2IsRef ? v2Ref : v2NonRef.ToString()) + " :: ");
		}
        public override string ToString()
        {
            return  v1Ref.ToString()+" "+Type+" "+v2Ref;
        }
    }
}