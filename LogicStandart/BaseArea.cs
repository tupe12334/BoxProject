using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicStandart
{
    public class BaseArea : IComparable<BaseArea>
    {
        public int _qunt { get; set; }
        public double BaseAreaNumber { get; set; }
        public BaseArea(double baseArea)
        {
            BaseAreaNumber = baseArea;
        }
        #region func
        public void UpdateAmount(int amount, double h, double b)
        {
            _qunt += amount;

            if (_qunt > UserSettings.maxBoxFromSize)
            {
                _qunt = UserSettings.maxBoxFromSize;
                //TODO invoce
            }
            else if (_qunt <= UserSettings.minBoxToAlert)
            {
                //TODO invoc 
                if (_qunt < 0)
                {
                    _qunt = 0;
                }
            }
            if (BoxM.ExpaireList != null)
            {
                BoxM.ExpaireList.ExpaireLinkedList.RemoveItem(new LinkedNode<Box>(new Box(h, b)));
                if (_qunt > 0)
                {
                    BoxM.ExpaireList.ExpaireLinkedList.AddFirst(new LinkedNode<Box>(new Box(h, b)));
                }
            }
            

        }
        #endregion
        int IComparable<BaseArea>.CompareTo(BaseArea other)
        {
            return BaseAreaNumber.CompareTo(other.BaseAreaNumber);
        }
        public override string ToString()
        {
            return BaseAreaNumber.ToString();
        }
    }
}
