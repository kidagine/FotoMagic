﻿#pragma checksum "..\..\..\Views\ProductAddScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3F618E647A240FCF896B43D40074F3F53FD2AF6DCAE2A25CC92A9C02CA019B96"
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


namespace Fotomagic.Views {
    
    
    /// <summary>
    /// ProductAddScreen
    /// </summary>
    public partial class ProductAddScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\ProductAddScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MyImg;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Views\ProductAddScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblError;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Views\ProductAddScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rctFirstName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\ProductAddScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rctLastName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\ProductAddScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\ProductAddScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConfirm;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\ProductAddScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLastName;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Views\ProductAddScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFirstName;
        
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
            System.Uri resourceLocater = new System.Uri("/Fotomagic;component/views/productaddscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ProductAddScreen.xaml"
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
            this.MyImg = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.lblError = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.rctFirstName = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.rctLastName = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Views\ProductAddScreen.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.BtnExit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnConfirm = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Views\ProductAddScreen.xaml"
            this.btnConfirm.Click += new System.Windows.RoutedEventHandler(this.BtnConfirm_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtLastName = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\Views\ProductAddScreen.xaml"
            this.txtLastName.GotFocus += new System.Windows.RoutedEventHandler(this.TxtLastName_GotFocus);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\Views\ProductAddScreen.xaml"
            this.txtLastName.LostFocus += new System.Windows.RoutedEventHandler(this.TxtLastName_LostFocus);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\Views\ProductAddScreen.xaml"
            this.txtLastName.KeyDown += new System.Windows.Input.KeyEventHandler(this.TxtLastName_KeyDown);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\Views\ProductAddScreen.xaml"
            this.txtLastName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtLastName_TextChanged);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\Views\ProductAddScreen.xaml"
            this.txtLastName.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TxtLastName_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtFirstName = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\Views\ProductAddScreen.xaml"
            this.txtFirstName.GotFocus += new System.Windows.RoutedEventHandler(this.TxtFirstName_GotFocus);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\Views\ProductAddScreen.xaml"
            this.txtFirstName.LostFocus += new System.Windows.RoutedEventHandler(this.TxtFirstName_LostFocus);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\Views\ProductAddScreen.xaml"
            this.txtFirstName.KeyDown += new System.Windows.Input.KeyEventHandler(this.TxtFirstName_KeyDown);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\Views\ProductAddScreen.xaml"
            this.txtFirstName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtFirstName_TextChanged);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\Views\ProductAddScreen.xaml"
            this.txtFirstName.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TxtFirstName_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

