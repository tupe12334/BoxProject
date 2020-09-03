using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class BoxM
    {

        public Bst<Height> tst { get; set; }
        #region ctor
        public BoxM()
        {
            tst = new Bst<Height>();
            Box testBox = new Box(530.4, 351);
            AddBox(testBox, 5);
            AddBox(new Box(45, 351), 6);
            AddBox(new Box(452, 351), 1);
            AddBox(new Box(7525, 351), 5);
            AddBox(new Box(7865, 351), 9);
            AddBox(new Box(7865, 5424), 7);
            AddBox(new Box(7865, 12), 3);
            AddBox(new Box(7865, 7546), 56);
            AddBox(new Box(7865, 4567), 5);

            AddBox(new Box(7865, 4567), -8);

            BuyBox(new Box(7865, 351), 2);
        }
        #endregion
        #region func
        public void AddBox(Box theBox, int qun)
        {
            tst.Insert(new Height(theBox.Height));
            var x = tst.GetNode(new Height(theBox.Height));
            x.AddBaseArea(theBox.BaseArea,qun);
            theBox.SelfBaseArea = x.BaseAreaTree.GetNode(new BaseArea(theBox.BaseArea));
        }
        public void BuyBox(Box theBox, int qun)
        {
            var x = tst.GetNode(new Height(theBox.Height));
            x.BaseAreaTree.GetNode(new BaseArea(theBox.BaseArea)).UpdateAmount(-qun);
        }
        #endregion
    }
}
