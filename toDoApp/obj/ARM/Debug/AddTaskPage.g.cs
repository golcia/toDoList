﻿#pragma checksum "D:\STUDIA\WPA\WinPhone_toDoList\toDoApp\toDoApp\AddTaskPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3C71CEE20C63EE0F833AF598C52167BB"
#pragma checksum "D:\STUDIA\WPA\WinPhone_toDoList\toDoApp\toDoApp\DeviceFamily-Mobile\AddTaskPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4F49E71FC6530ECCB8867F02EFFB35B9"
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
    partial class AddTaskPage : 
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
                    this.appBarAddTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.titleAddTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.titleTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.addDescriptionTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.textTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 36 "..\..\..\AddTaskPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Back).Click += this.CancelClick;
                    #line default
                }
                break;
            case 7:
                {
                    this.Accept = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 37 "..\..\..\AddTaskPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Accept).Click += this.AcceptClick;
                    #line default
                }
                break;
            case 8:
                {
                    this.appBarAddTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.titleAddTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.titleTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11:
                {
                    this.addDescriptionTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.textTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13:
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 36 "..\..\..\DeviceFamily-Mobile\AddTaskPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Back).Click += this.CancelClick;
                    #line default
                }
                break;
            case 14:
                {
                    this.Accept = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 37 "..\..\..\DeviceFamily-Mobile\AddTaskPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Accept).Click += this.AcceptClick;
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

