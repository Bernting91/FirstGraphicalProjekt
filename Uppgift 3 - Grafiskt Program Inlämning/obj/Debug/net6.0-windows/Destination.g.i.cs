﻿#pragma checksum "..\..\..\Destination.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "443CDA14F4F72126F881A7251D83548120066B51"
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
    /// Destination
    /// </summary>
    public partial class Destination : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Destination.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock chooseDestinationText;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Destination.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label notReadyLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/Uppgift 3 - Grafiskt Program Inlämning;component/destination.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Destination.xaml"
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
            
            #line 8 "..\..\..\Destination.xaml"
            ((Uppgift_3___Grafiskt_Program_Inlämning.Destination)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.destination_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.chooseDestinationText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            
            #line 28 "..\..\..\Destination.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.textBlockLake_click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 29 "..\..\..\Destination.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.textBlockCave_click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 30 "..\..\..\Destination.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.textBlockArmory_click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 31 "..\..\..\Destination.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.textBlockGoHome_click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 32 "..\..\..\Destination.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.textBlockFaceDemon_click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 35 "..\..\..\Destination.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goBackCharacterScreenButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 36 "..\..\..\Destination.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.showInventory_click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.notReadyLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

