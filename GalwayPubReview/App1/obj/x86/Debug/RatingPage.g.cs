﻿#pragma checksum "C:\Users\gerar\Desktop\4th_year_uwp_project\GalwayPubReview\App1\RatingPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "169096228295B06C080A4EB4CCE87541"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class RatingPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Bev = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 41 "..\..\..\RatingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Bev).ValueChanged += this.Bev_ValueChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.Atmos = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 52 "..\..\..\RatingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Atmos).ValueChanged += this.Atmos_ValueChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.Craic = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 63 "..\..\..\RatingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Craic).ValueChanged += this.Craic_ValueChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.Step2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 70 "..\..\..\RatingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Step2).Click += this.Step2_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

