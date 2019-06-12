﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7466C36916997BE61DD658B01711A0280EF1CD8BC03050D2F33D6BA721AEDFA9"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_ingredient;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tbk_messageInvalid;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Lbx_ingredient;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tbk_findRecipesWith;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Sp_filterIngredients;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Cbx_getFavorites;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Cbx_getMyRecipes;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_filterName;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tbk_recipeListTitle;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tbk_RecipeListEmpty;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Lbx_Items_Recipes;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp_SmartCookbook;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 7 "..\..\MainWindow.xaml"
            ((WpfApp_SmartCookbook.MainWindow)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Window_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 23 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Tbx_ingredient = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\MainWindow.xaml"
            this.Tbx_ingredient.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tbx_ingredient_TextChanged);
            
            #line default
            #line hidden
            
            #line 36 "..\..\MainWindow.xaml"
            this.Tbx_ingredient.KeyDown += new System.Windows.Input.KeyEventHandler(this.Tbx_ingredient_KeyDown);
            
            #line default
            #line hidden
            
            #line 36 "..\..\MainWindow.xaml"
            this.Tbx_ingredient.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Tbx_ingredient_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Tbk_messageInvalid = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Lbx_ingredient = ((System.Windows.Controls.ListBox)(target));
            
            #line 38 "..\..\MainWindow.xaml"
            this.Lbx_ingredient.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Lbx_ingredient_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Tbk_findRecipesWith = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.Sp_filterIngredients = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.Cbx_getFavorites = ((System.Windows.Controls.CheckBox)(target));
            
            #line 52 "..\..\MainWindow.xaml"
            this.Cbx_getFavorites.Click += new System.Windows.RoutedEventHandler(this.Cbx_getFavorites_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Cbx_getMyRecipes = ((System.Windows.Controls.CheckBox)(target));
            
            #line 53 "..\..\MainWindow.xaml"
            this.Cbx_getMyRecipes.Click += new System.Windows.RoutedEventHandler(this.Cbx_getMyRecipes_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Tbx_filterName = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\MainWindow.xaml"
            this.Tbx_filterName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tbx_filterName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Tbk_recipeListTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.Tbk_RecipeListEmpty = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.Lbx_Items_Recipes = ((System.Windows.Controls.ListBox)(target));
            
            #line 70 "..\..\MainWindow.xaml"
            this.Lbx_Items_Recipes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Lbx_Items_Recipes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 14:
            
            #line 86 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.StarImage_MouseDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

