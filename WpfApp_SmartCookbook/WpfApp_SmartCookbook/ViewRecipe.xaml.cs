using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp_SmartCookbook.models;

namespace WpfApp_SmartCookbook
{
    /// <summary>
    /// Interaction logic for ViewRecipe.xaml
    /// </summary>
    public partial class ViewRecipe : Window
    {
        Recipe selectedRecipe;
        public ViewRecipe()
        {
            InitializeComponent();
        }

        public ViewRecipe(Recipe _selectedRecipe)
        {
            InitializeComponent();
            selectedRecipe = _selectedRecipe;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetRecipeDetail();
        }

        private void SetRecipeDetail()
        {
            if (selectedRecipe != null)
            {
                selectedRecipe.instruction = selectedRecipe.instruction.Replace("\\n", "\n");
                DataContext = selectedRecipe;
                if (selectedRecipe.isMyRecipe)
                {
                    Btn_Delete.Visibility = Visibility.Visible;
                    Btn_Edit.Visibility = Visibility.Visible;
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Visibility = Visibility.Visible;
        }

        public void cmbServings_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //int recipeId = 1;//Hard coded for now. which shuold come from the recipe selection mainwindow
            //GetRecipe(recipeId);
        }

        private void StarImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var recipeId = Tbk_recipeId.Text;
            var listInput = MyStorage.ReadXml<List<Recipe>>("InputData.xml");
            var recipe = (from n in listInput
                          where n.id == Convert.ToInt32(recipeId)
                          select n).FirstOrDefault();
            var favoriteValue = recipe.isFavorite == true ? false : true;
            Tbk_isFavorite.Text = favoriteValue == true ? Properties.Settings.Default.FilledHeart : Properties.Settings.Default.EmptyHeart;
            Tbk_isFavorite.ToolTip = favoriteValue == true ? Properties.Settings.Default.Markedfavorite : Properties.Settings.Default.Markfavorite;
            recipe.isFavorite = favoriteValue;
            MyStorage.WriteXml<List<Recipe>>(listInput, "InputData.xml");
        }

        private void GetRecipe(int recipeId)
        {
            //ComboBoxItem cbi = (ComboBoxItem)cmbServings.SelectedItem;
            //cmbServings.SelectionChanged += new SelectionChangedEventHandler(cmbServings_SelectionChanged);
            //int servings = Convert.ToInt32(cbi.Content.ToString());
            //var recipeList = MyStorage.ReadXml<List<Recipe>>("InputData.xml");
            //var selectedRecipe = (from n in recipeList
            //                      where n.id == recipeId
            //                      select n).FirstOrDefault();
            //Tbx_RecipeName.Text = selectedRecipe.name;
            //Tbx_Description.Text = selectedRecipe.description;
            //Tbx_MyRecipe.Text = selectedRecipe.isMyRecipe == true ? "MyRecipe" : "";
            //Tbx_TimeRequired.Text = selectedRecipe.timeRequired;
            //Tbx_Ingredients.Text = String.Empty;
            //Tbx_Instructions.Text = selectedRecipe.instruction;
            //GetIngredientsForReciepe(selectedRecipe, servings);
        }

        private void GetIngredientsForReciepe(Recipe recipe, int servings)
        {
            //var measureList = MyStorage.ReadXml<List<TypeMeasure>>("TypeMeasure.xml");

            //foreach (var ingredient in recipe.ingredients)
            //{
            //    //var ingredientMeasure = (from n in measureList
            //    //                      where n.type == ingredient.ingredientType
            //    //                      select n.measure).FirstOrDefault();

            //    double quntity = ((servings * Convert.ToInt32(ingredient.quantity)) / Convert.ToDouble(recipe.servings));
            //    string measure = ingredient.measure;

            //    if (!ingredient.measure.Equals(Measurement.teaspoon) && !ingredient.measure.Equals(Measurement.tablespoon))
            //    {
            //        if (quntity > 1000)
            //        {
            //            quntity = quntity / 1000;
            //            measure = ingredient.measure.Equals(Measurement.gram) ? Measurement.kg : Measurement.liter;
            //        }
            //    }
            //    Tbx_Ingredients.Text += ingredient.ingredientId + ". " + ingredient.ingredientName + " - " + quntity + " " + measure + "\n";
            //}
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            Owner.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }

        private void Btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("The recipe will no longer be available in the cookbook. Are you sure you want to delete?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
            var recipeId = Tbk_recipeId.Text;
            var listInput = MyStorage.ReadXml<List<Recipe>>("InputData.xml");
                var recipe = (from n in listInput
                              where n.id == Convert.ToInt32(recipeId)
                              select n).FirstOrDefault();
                recipe.isDelete = true;
                var favoriteValue = recipe.isFavorite == true ? false : true;
                MyStorage.WriteXml<List<Recipe>>(listInput, "InputData.xml");
                Owner.Visibility = Visibility.Visible;
                this.Visibility = Visibility.Hidden;
            }
        }

        private void Btn_EditClic(object sender, RoutedEventArgs e)
        {
            var editWindow = new AddEditRecipe(selectedRecipe);
            editWindow.Owner = this;
            editWindow.Show();
            Visibility = Visibility.Hidden;
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible)
                SetRecipeDetail();
        }
    }
}
