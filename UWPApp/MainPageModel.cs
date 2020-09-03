using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using LogicStandart;
using Windows.UI.Xaml.Controls;

namespace UWPApp
{
    public enum requstStutus
    {
        add,
        delet,
        show
    }
    class MainPageModel
    {
        public void reseatList(ListView theListView)
        {
            theListView.ItemsSource = BoxM.ItemList;
        }
        public string EnterFunc(Button theBTN, requstStutus theStatus, double h, double b, int Q)
        {
            
            switch (theStatus)
            {
                case requstStutus.show:
                    return $"כמות במלאי {BoxM.GetQunt(new Box(h, b))}";
                case requstStutus.add:
                    BoxM.AddBox(new Box(h, b),Q);
                    return "התווסף בהצלחה";
                case requstStutus.delet:
                    BoxM.SellBox(new Box(h, b), Q);
                    return "נמכר בהצלחה";
            }
            return default;
        }
        
    }
}
