﻿

#pragma checksum "C:\Work\WP\Test\Tasky\Tasky.Win8\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "57E7AA5284FDFAD51AFA14975D7B518F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskyWin8
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 127 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Save_Tap;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 132 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Delete_Tap;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 54 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Add_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 57 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Task_Tap;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

