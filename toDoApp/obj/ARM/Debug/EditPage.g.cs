﻿#pragma checksum "D:\STUDIA\WPA\WinPhone_toDoList\toDoApp\toDoApp\DeviceFamily-Mobile\EditPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "73A9822F99806FDC742702F3C7A0DB7B"
#pragma checksum "D:\STUDIA\WPA\WinPhone_toDoList\toDoApp\toDoApp\EditPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EE4EE020DAC98E155BBD264B5619CB8B"
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
    partial class EditPage : 
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
                    this.EditTitleTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.titleTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.EditDescriptionTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.textTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 34 "..\..\..\DeviceFamily-Mobile\EditPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Back).Click += this.CancelClick;
                    #line default
                }
                break;
            case 6:
                {
                    this.Accept = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 35 "..\..\..\DeviceFamily-Mobile\EditPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Accept).Click += this.AcceptClick;
                    #line default
                }
                break;
            case 7:
                {
                    this.Delete = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 36 "..\..\..\DeviceFamily-Mobile\EditPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Delete).Click += this.DeleteClick;
                    #line default
                }
                break;
            case 8:
                {
                    this.EditTitleTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.titleTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10:
                {
                    this.EditDescriptionTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.textTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12:
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 34 "..\..\..\EditPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Back).Click += this.CancelClick;
                    #line default
                }
                break;
            case 13:
                {
                    this.Accept = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 35 "..\..\..\EditPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Accept).Click += this.AcceptClick;
                    #line default
                }
                break;
            case 14:
                {
                    this.Delete = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 36 "..\..\..\EditPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Delete).Click += this.DeleteClick;
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

