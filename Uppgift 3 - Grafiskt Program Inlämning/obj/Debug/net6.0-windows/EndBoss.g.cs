﻿#pragma checksum "..\..\..\EndBoss.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92DD96EE55FD8F46A76C096D7E8CABF564E7875E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using Uppgift_3___Grafiskt_Program_Inlämning;


namespace Uppgift_3___Grafiskt_Program_Inlämning {
    
    
    /// <summary>
    /// EndBoss
    /// </summary>
    public partial class EndBoss : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\EndBoss.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button helpButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\EndBoss.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button watchButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\EndBoss.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock helpTextBlock;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\EndBoss.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock watchTextBlock;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\EndBoss.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Uppgift 3 - Grafiskt Program Inlämning;component/endboss.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EndBoss.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.helpButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\EndBoss.xaml"
            this.helpButton.Click += new System.Windows.RoutedEventHandler(this.helpButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.watchButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\EndBoss.xaml"
            this.watchButton.Click += new System.Windows.RoutedEventHandler(this.watchButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.helpTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.watchTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.exitButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\EndBoss.xaml"
            this.exitButton.Click += new System.Windows.RoutedEventHandler(this.exitButton_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

