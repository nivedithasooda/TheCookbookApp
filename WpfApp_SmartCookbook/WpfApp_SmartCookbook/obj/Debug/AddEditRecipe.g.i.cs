﻿#pragma checksum "..\..\AddEditRecipe.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8DA97B91029B3B02F28D7308B0B6FB33DAB88BD1C7E1A3AA11C0EAF705FC7B01"
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
    /// AddEditRecipe
    /// </summary>
    public partial class AddEditRecipe : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tbx_EditTitle;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tbx_AddTitle;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_recipeName;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cbx_servings;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cbx_servingsEdit;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cbx_hours;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cbx_hoursEdit;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cbx_minutes;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cbx_minutesEdit;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Cbx_markFavorite;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_recipeDescription;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_image;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BrowseButton;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Sp_Add;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_ingredientName;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Lbx_ingredient;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_quantity;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cbx_measure;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_add;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Sp_forEdit;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_ingredientNameEdit;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Lbx_ingredientEdit;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_quantityEdit;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cbx_measureEdit;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_update;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_deleteEdit;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Sp_Lbx_ingredients;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Lbx_ingredients;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_instructions;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Sp_button;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\AddEditRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateRecipeButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp_SmartCookbook;component/addeditrecipe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEditRecipe.xaml"
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
            
            #line 7 "..\..\AddEditRecipe.xaml"
            ((WpfApp_SmartCookbook.AddEditRecipe)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\AddEditRecipe.xaml"
            ((WpfApp_SmartCookbook.AddEditRecipe)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Tbx_EditTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Tbx_AddTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Tbx_recipeName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Cbx_servings = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.Cbx_servingsEdit = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.Cbx_hours = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.Cbx_hoursEdit = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.Cbx_minutes = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.Cbx_minutesEdit = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.Cbx_markFavorite = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 12:
            this.Tbx_recipeDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.Tbx_image = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.BrowseButton = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\AddEditRecipe.xaml"
            this.BrowseButton.Click += new System.Windows.RoutedEventHandler(this.BrowseButton_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.Sp_Add = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 16:
            this.Tbx_ingredientName = ((System.Windows.Controls.TextBox)(target));
            
            #line 87 "..\..\AddEditRecipe.xaml"
            this.Tbx_ingredientName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tbx_ingredient_TextChanged);
            
            #line default
            #line hidden
            
            #line 87 "..\..\AddEditRecipe.xaml"
            this.Tbx_ingredientName.KeyDown += new System.Windows.Input.KeyEventHandler(this.Tbx_ingredient_KeyDown);
            
            #line default
            #line hidden
            return;
            case 17:
            this.Lbx_ingredient = ((System.Windows.Controls.ListBox)(target));
            
            #line 88 "..\..\AddEditRecipe.xaml"
            this.Lbx_ingredient.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Lbx_ingredient_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 18:
            this.Tbx_quantity = ((System.Windows.Controls.TextBox)(target));
            
            #line 93 "..\..\AddEditRecipe.xaml"
            this.Tbx_quantity.KeyDown += new System.Windows.Input.KeyEventHandler(this.Tbx_quantity_KeyDown);
            
            #line default
            #line hidden
            return;
            case 19:
            this.Cbx_measure = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 20:
            this.Btn_add = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\AddEditRecipe.xaml"
            this.Btn_add.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.Sp_forEdit = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 22:
            this.Tbx_ingredientNameEdit = ((System.Windows.Controls.TextBox)(target));
            
            #line 118 "..\..\AddEditRecipe.xaml"
            this.Tbx_ingredientNameEdit.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tbx_ingredient_TextChanged);
            
            #line default
            #line hidden
            
            #line 118 "..\..\AddEditRecipe.xaml"
            this.Tbx_ingredientNameEdit.KeyDown += new System.Windows.Input.KeyEventHandler(this.Tbx_ingredient_KeyDown);
            
            #line default
            #line hidden
            return;
            case 23:
            this.Lbx_ingredientEdit = ((System.Windows.Controls.ListBox)(target));
            
            #line 119 "..\..\AddEditRecipe.xaml"
            this.Lbx_ingredientEdit.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Lbx_ingredient_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 24:
            this.Tbx_quantityEdit = ((System.Windows.Controls.TextBox)(target));
            
            #line 124 "..\..\AddEditRecipe.xaml"
            this.Tbx_quantityEdit.KeyUp += new System.Windows.Input.KeyEventHandler(this.Tbx_quantityEdit_KeyUp);
            
            #line default
            #line hidden
            return;
            case 25:
            this.Cbx_measureEdit = ((System.Windows.Controls.ComboBox)(target));
            
            #line 125 "..\..\AddEditRecipe.xaml"
            this.Cbx_measureEdit.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Cbx_measureEdit_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 26:
            this.Btn_update = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\AddEditRecipe.xaml"
            this.Btn_update.Click += new System.Windows.RoutedEventHandler(this.UpdateButton_Click);
            
            #line default
            #line hidden
            return;
            case 27:
            this.Btn_deleteEdit = ((System.Windows.Controls.Button)(target));
            
            #line 137 "..\..\AddEditRecipe.xaml"
            this.Btn_deleteEdit.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 28:
            this.Sp_Lbx_ingredients = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 29:
            this.Lbx_ingredients = ((System.Windows.Controls.ListBox)(target));
            
            #line 143 "..\..\AddEditRecipe.xaml"
            this.Lbx_ingredients.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Lbx_ingredients_MouseUp);
            
            #line default
            #line hidden
            return;
            case 30:
            this.Tbx_instructions = ((System.Windows.Controls.TextBox)(target));
            return;
            case 31:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 165 "..\..\AddEditRecipe.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 32:
            this.Sp_button = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 33:
            this.UpdateRecipeButton = ((System.Windows.Controls.Button)(target));
            
            #line 168 "..\..\AddEditRecipe.xaml"
            this.UpdateRecipeButton.Click += new System.Windows.RoutedEventHandler(this.UpdateRecipeButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

