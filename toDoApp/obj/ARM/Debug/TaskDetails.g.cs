﻿#pragma checksum "D:\STUDIA\WPA\WinPhone_toDoList\toDoApp\toDoApp\DeviceFamily-Mobile\TaskDetails.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "63EAF92C1EAC3D185D0CE0C5831D81BA"
#pragma checksum "D:\STUDIA\WPA\WinPhone_toDoList\toDoApp\toDoApp\TaskDetails.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0A6EDF6DF2D1AEA7D26A2A2A431BA33A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace toDoApp
{
    partial class TaskDetails : 
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
                    this.titleTextBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.textTextBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.Edit = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 33 "..\..\..\DeviceFamily-Mobile\TaskDetails.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Edit).Click += this.EditClick;
                    #line default
                }
                break;
            case 4:
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 34 "..\..\..\DeviceFamily-Mobile\TaskDetails.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Back).Click += this.CancelClick;
                    #line default
                }
                break;
            case 5:
                {
                    this.titleTextBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.textTextBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.Edit = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 33 "..\..\..\TaskDetails.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Edit).Click += this.EditClick;
                    #line default
                }
                break;
            case 8:
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 34 "..\..\..\TaskDetails.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Back).Click += this.CancelClick;
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

