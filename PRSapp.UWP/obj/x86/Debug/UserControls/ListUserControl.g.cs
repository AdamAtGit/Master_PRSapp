﻿#pragma checksum "C:\Users\Flazz\source\repos\FebOn\00MarchRepo\PRSapp\PRSapp.UWP\UserControls\ListUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B31AF2AEDAFF05E85B75AE761A56BA17"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRSapp.UWP.UserControls
{
    partial class ListUserControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // UserControls\ListUserControl.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                    ((global::Windows.UI.Xaml.Controls.UserControl)element1).Loaded += this.UserControl_Loaded;
                }
                break;
            case 2: // UserControls\ListUserControl.xaml line 15
                {
                    this.PanelTitleListView = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // UserControls\ListUserControl.xaml line 41
                {
                    this.PanelBottomCommandBar = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // UserControls\ListUserControl.xaml line 47
                {
                    this.btnSetSelectionModeToMulitple = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnSetSelectionModeToMulitple).Click += this.BtnSetSelectionModeToMulitple_Click;
                }
                break;
            case 5: // UserControls\ListUserControl.xaml line 53
                {
                    this.btnDeleteSelection = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 6: // UserControls\ListUserControl.xaml line 58
                {
                    this.btnConfirmAddTitleToTimeLineItem = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 7: // UserControls\ListUserControl.xaml line 19
                {
                    this.ShowTitlesListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ShowTitlesListView).KeyUp += this.ShowTitlesListView_KeyUp;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ShowTitlesListView).SelectionChanged += this.ShowTitlesListView_OnSelectionChanged;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

