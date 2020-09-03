using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicStandart
{
    public static class BoxM
    {
        public static ExpaireList ExpaireList = new ExpaireList();
        public static List<string> ItemList { get; set; }
        public static Bst<Height> tst { get; set; }
        #region ctor
        static BoxM()
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

            SellBox(new Box(7865, 351), 2);
            RunAll();
        }
        #endregion
        #region func
        public static void AddBox(Box theBox, int qun)
        {
            tst.Insert(new Height(theBox.Height));
            var x = tst.GetNode(new Height(theBox.Height));
            x.AddBaseArea(theBox.BaseArea,qun);
            theBox.SelfBaseArea = x.BaseAreaTree.GetNode(new BaseArea(theBox.BaseArea));
        }
        public static void SellBox(Box theBox, int qun)
        {
            Height x = tst.GetNode(new Height(theBox.Height));
            if (x==null)
            {
                return;
            }
            x.BaseAreaTree.GetNode(new BaseArea(theBox.BaseArea)).UpdateAmount(-qun, theBox.Height, theBox.BaseArea);
        }
        public static int GetQunt(Box theDietails)
        {
            var x = tst.GetNode(new Height(theDietails.Height));
            return x.BaseAreaTree.GetNode(new BaseArea(theDietails.BaseArea))._qunt;
        }
        public static void RunAll()
        {
            tst.RunLeftToRight();
            ItemList = tst.ItemList;
        }
      
        #endregion
    }
}
