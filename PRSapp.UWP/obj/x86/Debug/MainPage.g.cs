﻿#pragma checksum "C:\Users\Flazz\source\repos\FebOn\00MarchRepo\PRSapp\PRSapp.UWP\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B0D9F819DD920ABDC70C648FB9EBA47F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRSapp.UWP
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
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
            case 1: // MainPage.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                }
                break;
            case 2: // MainPage.xaml line 32
                {
                    this.MainPageGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // MainPage.xaml line 73
                {
                    this.CreateLoginPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // MainPage.xaml line 85
                {
                    this.SignInPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5: // MainPage.xaml line 98
                {
                    this.DefaultHomePagePanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6: // MainPage.xaml line 124
                {
                    this.ShowTitlesPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7: // MainPage.xaml line 190
                {
                    this.AddTitlesPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 8: // MainPage.xaml line 229
                {
                    this.EditWrapperPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 9: // MainPage.xaml line 547
                {
                    this.TweakPlaySettinsPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 10: // MainPage.xaml line 585
                {
                    this.ArrangePanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 11: // MainPage.xaml line 596
                {
                    this.PlayTimesListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 12: // MainPage.xaml line 614
                {
                    global::Windows.UI.Xaml.Controls.Button element12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element12).Click += this.ArrangeTitlesAsync_Click;
                }
                break;
            case 14: // MainPage.xaml line 552
                {
                    this.PlaySpeedTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15: // MainPage.xaml line 553
                {
                    this.VoiceGenderTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 16: // MainPage.xaml line 565
                {
                    this.TitlePlaySettingListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 18: // MainPage.xaml line 556
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element18 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element18).Click += this.BtnTestPlayAsync_Click;
                }
                break;
            case 19: // MainPage.xaml line 560
                {
                    global::Windows.UI.Xaml.Controls.Button element19 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element19).Click += this.ModifyTitleSettings_Click;
                }
                break;
            case 20: // MainPage.xaml line 237
                {
                    this.TitleDetailsPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 21: // MainPage.xaml line 323
                {
                    this.WatchAndPlayTitlesPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 22: // MainPage.xaml line 338
                {
                    this.UpdateTitlesPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 23: // MainPage.xaml line 367
                {
                    this.DeleteTitlesPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 24: // MainPage.xaml line 372
                {
                    this.DeleteTitlesListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 25: // MainPage.xaml line 396
                {
                    this.btnDeleteData = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnDeleteData).Click += this.DeleteData_Click;
                }
                break;
            case 27: // MainPage.xaml line 343
                {
                    this.boxUpdateTitleName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 28: // MainPage.xaml line 344
                {
                    this.boxUpdateTitleTtsRaw = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 29: // MainPage.xaml line 348
                {
                    this.btnEditUpDate = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnEditUpDate).Click += this.UpDateChangesAsync_Click;
                }
                break;
            case 30: // MainPage.xaml line 356
                {
                    this.btnUndoChanges = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnUndoChanges).Click += this.UndoChangesAsync_Click;
                }
                break;
            case 31: // MainPage.xaml line 327
                {
                    this.boxWatchAndPlayTtsRaw = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 32: // MainPage.xaml line 261
                {
                    this.TitleDetailsListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.TitleDetailsListView).SelectionChanged += this.TitleDetailsListView_OnSelectionChanged;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.TitleDetailsListView).ItemClick += this.TitleDetailsListView_ItemClick;
                }
                break;
            case 33: // MainPage.xaml line 298
                {
                    this.btnNavHome = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnNavHome).Click += this.BtnTestPlayAsync_Click;
                }
                break;
            case 34: // MainPage.xaml line 302
                {
                    this.btnShowUpDatePanel = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnShowUpDatePanel).Click += this.BtnShowUpDatePanel_Click;
                }
                break;
            case 35: // MainPage.xaml line 307
                {
                    this.btnShowDeletePanel = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnShowDeletePanel).Click += this.BtnShowDeletePanel_Click;
                }
                break;
            case 36: // MainPage.xaml line 315
                {
                    this.settingTitles = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 38: // MainPage.xaml line 244
                {
                    this.btnDetailsPlay = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnDetailsPlay).Click += this.PlayAsync_Click;
                }
                break;
            case 39: // MainPage.xaml line 195
                {
                    this.boxAddTitleName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 40: // MainPage.xaml line 198
                {
                    this.boxAddTitleTtsRaw = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 41: // MainPage.xaml line 202
                {
                    this.btnAddTitleLittleAsync = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 42: // MainPage.xaml line 206
                {
                    this.btnAddTestPlay = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnAddTestPlay).Click += this.TestPlayAsync_Click;
                }
                break;
            case 43: // MainPage.xaml line 211
                {
                    this.uiMediaElement = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 44: // MainPage.xaml line 219
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element44 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element44).Click += this.ClearAddBoxes_Click;
                }
                break;
            case 45: // MainPage.xaml line 138
                {
                    this.ShowTitlesListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ShowTitlesListView).KeyUp += this.ShowTitlesListView_KeyUp;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ShowTitlesListView).SelectionChanged += this.ShowTitlesListView_OnSelectionChanged;
                }
                break;
            case 46: // MainPage.xaml line 165
                {
                    this.BtnSetSelectionModeToMulitple = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.BtnSetSelectionModeToMulitple).Click += this.BtnSetSelectionModeToMulitple_Click;
                }
                break;
            case 47: // MainPage.xaml line 174
                {
                    this.btnDeleteSelection = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnDeleteSelection).Click += this.DeleteSelectionAsync_Click;
                }
                break;
            case 48: // MainPage.xaml line 182
                {
                    this.setting = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 50: // MainPage.xaml line 111
                {
                    this.UsersDefaulHomePageListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.UsersDefaulHomePageListView).SelectionChanged += this.UsersDefaulHomePageListView_OnSelectionChanged;
                }
                break;
            case 52: // MainPage.xaml line 102
                {
                    this.tbUserId = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 53: // MainPage.xaml line 106
                {
                    this.tbLoggedInUser = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 54: // MainPage.xaml line 90
                {
                    this.SignInUserLogin = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 55: // MainPage.xaml line 91
                {
                    this.SignInUserPwd = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 56: // MainPage.xaml line 92
                {
                    this.SignInButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SignInButton).Click += this.SignIn_Click;
                }
                break;
            case 57: // MainPage.xaml line 78
                {
                    this.NewUserUserLogin = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 58: // MainPage.xaml line 79
                {
                    this.NewUserUserPwd = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 59: // MainPage.xaml line 80
                {
                    this.NewUserUserPwdRetyped = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 60: // MainPage.xaml line 81
                {
                    global::Windows.UI.Xaml.Controls.Button element60 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element60).Click += this.CreateLogin_Click;
                }
                break;
            case 61: // MainPage.xaml line 82
                {
                    this.JustCreatedUserTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 62: // MainPage.xaml line 48
                {
                    this.NavToDayPage = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.NavToDayPage).Click += this.NavToDayPage_Click;
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

