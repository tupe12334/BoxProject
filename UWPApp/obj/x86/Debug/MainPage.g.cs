﻿#pragma checksum "C:\Users\Ofek\source\repos\WpfBoxPro\UWPApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E113F7FEC9328C33F7A70FDE0F551A72"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWPApp
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 37
                {
                    this.BTNEnter = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BTNEnter).Click += this.BTNEnter_Click;
                }
                break;
            case 3: // MainPage.xaml line 26
                {
                    this.RBAdd = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 4: // MainPage.xaml line 27
                {
                    this.RBLow = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 5: // MainPage.xaml line 28
                {
                    this.RBShowBoxDetail = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
