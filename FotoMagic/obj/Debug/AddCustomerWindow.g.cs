﻿#pragma checksum "..\..\AddCustomerWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AD0DA7F1C6A496708AAFED34FC167FE310091C866C906595F2334BCD9F66EFD3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FotoMagic;
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


namespace FotoMagic {
    
    
    /// <summary>
    /// AddCustomerWindow
    /// </summary>
    public partial class AddCustomerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblError;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rctFirstName;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rctLastName;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConfirm;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLastName;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFirstName;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\AddCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
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
            System.Uri resourceLocater = new System.Uri("/FotoMagic;component/addcustomerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddCustomerWindow.xaml"
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
            this.lblError = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.rctFirstName = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.rctLastName = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.btnConfirm = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\AddCustomerWindow.xaml"
            this.btnConfirm.Click += new System.Windows.RoutedEventHandler(this.BtnConfirm_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtLastName = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\AddCustomerWindow.xaml"
            this.txtLastName.GotFocus += new System.Windows.RoutedEventHandler(this.TxtLastName_GotFocus);
            
            #line default
            #line hidden
            
            #line 76 "..\..\AddCustomerWindow.xaml"
            this.txtLastName.LostFocus += new System.Windows.RoutedEventHandler(this.TxtLastName_LostFocus);
            
            #line default
            #line hidden
            
            #line 76 "..\..\AddCustomerWindow.xaml"
            this.txtLastName.KeyDown += new System.Windows.Input.KeyEventHandler(this.TxtLastName_KeyDown);
            
            #line default
            #line hidden
            
            #line 76 "..\..\AddCustomerWindow.xaml"
            this.txtLastName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtLastName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtFirstName = ((System.Windows.Controls.TextBox)(target));
            
            #line 77 "..\..\AddCustomerWindow.xaml"
            this.txtFirstName.GotFocus += new System.Windows.RoutedEventHandler(this.TxtFirstName_GotFocus);
            
            #line default
            #line hidden
            
            #line 77 "..\..\AddCustomerWindow.xaml"
            this.txtFirstName.LostFocus += new System.Windows.RoutedEventHandler(this.TxtFirstName_LostFocus);
            
            #line default
            #line hidden
            
            #line 77 "..\..\AddCustomerWindow.xaml"
            this.txtFirstName.KeyDown += new System.Windows.Input.KeyEventHandler(this.TxtFirstName_KeyDown);
            
            #line default
            #line hidden
            
            #line 77 "..\..\AddCustomerWindow.xaml"
            this.txtFirstName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtFirstName_TextChanged);
            
            #line default
            #line hidden
            
            #line 77 "..\..\AddCustomerWindow.xaml"
            this.txtFirstName.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TxtFirstName_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\AddCustomerWindow.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.BtnExit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

