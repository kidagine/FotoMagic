﻿#pragma checksum "..\..\..\Views\ProductsScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "518B6789B686E21F9DAB57695A43DFBA61914DB748E095E7262C3030FC449116"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Fotomagic;
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


namespace Fotomagic {
    
    
    /// <summary>
    /// ProductsScreen
    /// </summary>
    public partial class ProductsScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Views\ProductsScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Effects.DropShadowEffect dseMain;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\ProductsScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdMain;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Views\ProductsScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\ProductsScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstCustomers;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Views\ProductsScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemove;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Views\ProductsScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rctDarken;
        
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
            System.Uri resourceLocater = new System.Uri("/Fotomagic;component/views/productsscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ProductsScreen.xaml"
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
            this.dseMain = ((System.Windows.Media.Effects.DropShadowEffect)(target));
            return;
            case 2:
            this.grdMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 33 "..\..\..\Views\ProductsScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\Views\ProductsScreen.xaml"
            this.txtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\Views\ProductsScreen.xaml"
            this.txtSearch.GotFocus += new System.Windows.RoutedEventHandler(this.TxtSearch_GotFocus);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\Views\ProductsScreen.xaml"
            this.txtSearch.LostFocus += new System.Windows.RoutedEventHandler(this.TxtSearch_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lstCustomers = ((System.Windows.Controls.ListView)(target));
            
            #line 38 "..\..\..\Views\ProductsScreen.xaml"
            this.lstCustomers.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LstCustomers_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRemove = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\Views\ProductsScreen.xaml"
            this.btnRemove.Click += new System.Windows.RoutedEventHandler(this.BtnRemove_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.rctDarken = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 108 "..\..\..\Views\ProductsScreen.xaml"
            this.rctDarken.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.RctDarken_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

