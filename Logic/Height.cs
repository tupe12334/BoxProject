using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Height : IComparable<Height>
    {
        #region props
        public double HeightNumber { get; set; }
        public Bst<BaseArea> BaseAreaTree{ get; set; }
        #endregion
        #region ctor
        public Height(double thrHeight)
        {
            BaseAreaTree = new Bst<BaseArea>();
            HeightNumber = thrHeight;
        }
        #endregion
        public void AddBaseArea(double baseArea, int amount)
        {
            BaseArea tmp = new BaseArea(baseArea); // creates tmp with that height

            BaseAreaTree.Insert(tmp); // if it is does not exist will add new, if it exists wont do anything
            tmp = BaseAreaTree.GetNode(tmp);// now change tmp to node of the tree so changes on it will effect the tree as well

            tmp.UpdateAmount(amount); // updates amount
        }
        int IComparable<Height>.CompareTo(Height other)
        {
            return HeightNumber.CompareTo(other.HeightNumber);
        }
    }
}
