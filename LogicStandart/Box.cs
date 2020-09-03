using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicStandart
{
    public class Box
    {
        #region props
        public double Height { get; set; }
        public double BaseArea { get; set; }
        public BaseArea SelfBaseArea { get; set; }
        #endregion
        #region ctor
        public Box(double h, double b)
        {
            Height = h;
            BaseArea = b;
        }
        #endregion
    }
}
