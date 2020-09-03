using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
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
        public void UpdateAmount(int amount)
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
        }
        #endregion
        int IComparable<BaseArea>.CompareTo(BaseArea other)
        {
            return BaseAreaNumber.CompareTo(other.BaseAreaNumber);
        }
    }
}
