﻿#pragma checksum "..\..\ViewRecipe.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B9FB615D3F8931D9124CCA63BB4F679ADD844E767F46F706F1226AB84AA84892"
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
using WpfApp_SmartCookbook.Classes;


namespace WpfApp_SmartCookbook {
    
    
    /// <summary>
    /// ViewRecipe
    /// </summary>
    public partial class ViewRecipe : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\ViewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Edit;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ViewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Delete;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ViewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tbk_recipeId;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ViewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tbk_recipeName;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ViewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tbk_isFavorite;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\ViewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tbk_Description;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\ViewRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl Ic_ingredientList;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp_SmartCookbook;component/viewrecipe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ViewRecipe.xaml"
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
            
            #line 8 "..\..\ViewRecipe.xaml"
            ((WpfApp_SmartCookbook.ViewRecipe)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Window_IsVisibleChanged);
            
            #line default
            #line hidden
            
            #line 9 "..\..\ViewRecipe.xaml"
            ((WpfApp_SmartCookbook.ViewRecipe)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 10 "..\..\ViewRecipe.xaml"
            ((WpfApp_SmartCookbook.ViewRecipe)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Btn_Edit = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\ViewRecipe.xaml"
            this.Btn_Edit.Click += new System.Windows.RoutedEventHandler(this.Btn_EditClic);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Btn_Delete = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\ViewRecipe.xaml"
            this.Btn_Delete.Click += new System.Windows.RoutedEventHandler(this.Btn_Delete_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Tbk_recipeId = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Tbk_recipeName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Tbk_isFavorite = ((System.Windows.Controls.TextBlock)(target));
            
            #line 37 "..\..\ViewRecipe.xaml"
            this.Tbk_isFavorite.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.StarImage_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Tbk_Description = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Ic_ingredientList = ((System.Windows.Controls.ItemsControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

