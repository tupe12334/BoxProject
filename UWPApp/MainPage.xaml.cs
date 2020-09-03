using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using LogicStandart;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MainPageModel VM;
        requstStutus theStatus;
        public MainPage()
        {
            this.InitializeComponent();
            VM = new MainPageModel();
            theStatus = new requstStutus();
            VM.reseatList(ItemListViewXML);
        }
        private void BTNEnter_Click(object sender, RoutedEventArgs e)
        {
            if (RBAdd.IsChecked.Value) theStatus = requstStutus.add;
            else if (RBLow.IsChecked.Value) theStatus = requstStutus.delet;
            else if (RBShowBoxDetail.IsChecked.Value) theStatus = requstStutus.show;
            Button theBtn = (Button)sender;
            int Q;
            int.TryParse(TBoxQ.Text, out Q);
            var i = VM.EnterFunc(theBtn, theStatus,double.Parse(TBoxH.Text), double.Parse(TBoxB.Text), Q);
            TBpopUp.Text = i.ToString();
        }
        private void BtnFindNearst_Click(object sender, RoutedEventArgs e)
        {
           var x =  BoxM.tst.FindNearest(new Height(35));
        }
    }
}
