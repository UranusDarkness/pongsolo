﻿#pragma checksum "..\..\gameOverWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "05DC9844EBA9F58B0ECE59DFFBC8FD8C8B57F146487AEF35C37C7E90C09DA5C5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using PongSolo;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using XamlAnimatedGif;


namespace PongSolo {
    
    
    /// <summary>
    /// gameOverWindow
    /// </summary>
    public partial class gameOverWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\gameOverWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PongSolo.gameOverWindow GOverWindow;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\gameOverWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label scoreLabel;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\gameOverWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox namePlayer;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\gameOverWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem saveLabel;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\gameOverWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem mainMenuLabel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PongSolo;component/gameoverwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\gameOverWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.GOverWindow = ((PongSolo.gameOverWindow)(target));
            
            #line 9 "..\..\gameOverWindow.xaml"
            this.GOverWindow.Closing += new System.ComponentModel.CancelEventHandler(this.gameOverWindow_Closing);
            
            #line default
            #line hidden
            
            #line 9 "..\..\gameOverWindow.xaml"
            this.GOverWindow.Loaded += new System.Windows.RoutedEventHandler(this.GOverWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.scoreLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.namePlayer = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\gameOverWindow.xaml"
            this.namePlayer.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.namePlayer_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.saveLabel = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 81 "..\..\gameOverWindow.xaml"
            this.saveLabel.KeyUp += new System.Windows.Input.KeyEventHandler(this.saveLabel_KeyUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mainMenuLabel = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 82 "..\..\gameOverWindow.xaml"
            this.mainMenuLabel.KeyUp += new System.Windows.Input.KeyEventHandler(this.mainMenuLabel_KeyUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
