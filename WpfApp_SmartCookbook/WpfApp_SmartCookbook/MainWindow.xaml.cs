using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp_SmartCookbook.models;

namespace WpfApp_SmartCookbook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetRecipes();
            //CreateXMLData();
        }

        private List<Recipe> GetRecipes()
        {
            var ingredient1 = "";
            var ingredient2 = "";
            var ingredient3 = "";
            for (int i = 0; i < (Sp_filterIngredients as StackPanel).Children.Count; i++)
            {
                var button = (Sp_filterIngredients as StackPanel).Children[i] as Button;

                if (i == 0)
                    ingredient1 = GetButtonContent(button);
                else if (i == 1)
                    ingredient2 = GetButtonContent(button);
                else
                    ingredient3 = GetButtonContent(button);
            }
            var listInput = MyStorage.ReadXml<List<Recipe>>("InputData.xml");
            var recipes = new List<Recipe>();

            //initial load
            var recipeList = (from n in listInput where
                              n.isDelete==false
                              select n).Take(20).ToList();

            //filter by ingredients
            if (ingredient1 != "")
            {
                var recipeListFilter1 = (from n in listInput
                                         where
                                            n.isDelete == false & n.ingredients.Count > 0
                                         from m in n.ingredients
                                         where m.ingredientName.ToLower().Contains(ingredient1.ToLower())
                                         select n).ToList();
                if (ingredient3 == "" && ingredient2 == "")
                    recipes = recipeListFilter1;
                else
                {
                    var recipeListFilter2 = (from n in recipeListFilter1
                                             from m in n.ingredients
                                             where m.ingredientName.ToLower().Contains(ingredient2.ToLower())
                                             select n).ToList();
                    if (ingredient3 == "")
                        recipes = recipeListFilter2;
                    else
                    {
                        var recipeListFilter3 = (from n in recipeListFilter2
                                                 from m in n.ingredients
                                                 where m.ingredientName.ToLower().Contains(ingredient3.ToLower())
                                                 select n).ToList();
                        recipes = recipeListFilter3;
                    }
                }
            }
            else
                recipes = recipeList;
            recipes = Cbx_getFavorites.IsChecked == true ? recipes.Where(r => r.isFavorite == true).ToList() : recipes;
            recipes = Cbx_getMyRecipes.IsChecked == true ? recipes.Where(r => r.isMyRecipe == true).ToList() : recipes;
            if (Tbx_filterName.Text.Length >= 1)
            {
                recipes = recipes.Where(r => r.name.ToLower().Contains(Tbx_filterName.Text.ToLower())).ToList();
            }
            if (recipes.Count > 0)
            {
                recipes = recipes.OrderBy(r => r.name).ToList();
                Lbx_Items_Recipes.Visibility = Visibility.Visible;
                Lbx_Items_Recipes.ItemsSource = recipes;
                Tbk_RecipeListEmpty.Visibility = Visibility.Collapsed;
                Tbk_recipeListTitle.Visibility = Visibility.Visible;
            }
            else
            {
                Lbx_Items_Recipes.Visibility = Visibility.Collapsed;
                Lbx_Items_Recipes.ItemsSource = null;
                Tbk_RecipeListEmpty.Visibility = Visibility.Visible;
                Tbk_recipeListTitle.Visibility = Visibility.Collapsed;
            }
            var list = new List<Recipe>();

            return list;
        }

        private void Lbx_Items_Recipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Lbx_Items_Recipes.SelectedItem != null)
            {
                var recipe = (Recipe)Lbx_Items_Recipes.SelectedItem;
                var viewWindow = new ViewRecipe(recipe);
                viewWindow.Owner = this;
                viewWindow.Show();
                Visibility = Visibility.Hidden;
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //var recipeId = (((sender as Image).Parent as StackPanel).Children[0] as TextBlock).Text;
        }

        private void StarImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var recipeId = ((((sender as TextBlock).Parent as StackPanel).Parent as StackPanel).Children[0] as TextBlock).Text;
            var listInput = MyStorage.ReadXml<List<Recipe>>("InputData.xml");
            var recipe = (from n in listInput
                          where n.id == Convert.ToInt32(recipeId)
                          select n).FirstOrDefault();
            recipe.isFavorite = recipe.isFavorite == true ? false : true;
            MyStorage.WriteXml<List<Recipe>>(listInput, "InputData.xml");
            GetRecipes();
        }

        private void Tbx_ingredient_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Tbx_ingredient.Text.Length >= 2)
            {
                Lbx_ingredient.Visibility = Visibility.Visible;
                GetIngredients(Tbx_ingredient.Text);
            }
            else
            {
                Lbx_ingredient.Visibility = Visibility.Collapsed;
            }
        }

        private void GetIngredients(string text)
        {
            var listIngredients = MyStorage.ReadXml<List<Ingredient>>("IngredientData.xml");
            var ingredients = new List<Ingredient>();

            //initial load
            var ingredientListBegin = (from n in listIngredients
                                       where n.name.ToLower().StartsWith(text.ToLower())
                                       select n.name).ToList();
            var ingredientListContain = (from n in listIngredients
                                         where n.name.ToLower().Contains(text.ToLower())
                                         select n.name).ToList();
            ingredientListBegin.Sort();
            ingredientListContain.Sort();
            ingredientListBegin.AddRange(ingredientListContain);
            var ingredientList = ingredientListBegin.Distinct().ToList();
            foreach (var button in (Sp_filterIngredients as StackPanel).Children)
            {
                var buttonTxt = GetButtonContent(button);
                if (ingredientList.Contains(buttonTxt))
                    ingredientList.Remove(buttonTxt);
            }

            if (ingredientList.Count() > 0)
            {
                //ingredientList.Sort();
                Lbx_ingredient.ItemsSource = ingredientList.Take(5);
                //Tbx_ingredient.BorderBrush = Brushes.Black;
            }
            else
            {
                Lbx_ingredient.Visibility = Visibility.Collapsed;
                Lbx_ingredient.ItemsSource = null;
                //Tbx_ingredient.BorderBrush = Brushes.Red;

            }
        }

        private String GetButtonContent(object button)
        {
            return (button as Button).Content.ToString().Replace("  x  ", "").Trim();
        }

        private void Tbx_ingredient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Lbx_ingredient.Items.Count > 0)
                    Lbx_ingredient.SelectedIndex = 0;
                if (Lbx_ingredient.ItemsSource == null && Tbx_ingredient.Text.Length >= 4)
                {
                    //Tbk_messageInvalid.Visibility = Visibility.Visible;
                    MessageBox.Show("Please enter a valid ingredient!", ":|", MessageBoxButton.OK, MessageBoxImage.Error);
                    Tbx_ingredient.Text = "";
                }
            }
        }

        private void Lbx_ingredient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Lbx_ingredient.SelectedItem != null)
            {
                var ingredient = Lbx_ingredient.SelectedItem.ToString();
                System.Windows.Controls.Button newBtn = new Button();
                newBtn.Content = " " + ingredient + "  x  ";
                newBtn.Name = "Btn_" + ingredient.Replace(" ", "");
                newBtn.Click += new RoutedEventHandler(Btn_Ingredient_Click);
                newBtn.HorizontalAlignment = HorizontalAlignment.Left;
                newBtn.VerticalContentAlignment = VerticalAlignment.Center;
                newBtn.Margin = new Thickness(1);
                newBtn.Margin = new Thickness(1);
                newBtn.ToolTip = "Click to remove the ingredient";
                Sp_filterIngredients.Children.Add(newBtn);
                GetRecipes();
                if (Sp_filterIngredients.Children.Count == 3)
                    Tbx_ingredient.IsEnabled = false;
                Tbk_findRecipesWith.Visibility = Visibility.Visible;
            }
            Lbx_ingredient.Visibility = Visibility.Collapsed;
            Lbx_ingredient.ItemsSource = null;
            Tbx_ingredient.Text = "";
        }

        void Btn_Ingredient_Click(object sender, RoutedEventArgs e)
        {
            Button clicked = (Button)sender;
            Sp_filterIngredients.Children.Remove(clicked);
            if (Sp_filterIngredients.Children.Count < 1)
                Tbk_findRecipesWith.Visibility = Visibility.Collapsed;
            else
            {
                if (Sp_filterIngredients.Children.Count < 3)
                    Tbx_ingredient.IsEnabled = true;
            }

            GetRecipes();
        }

        private void Cbx_getFavorites_Checked(object sender, RoutedEventArgs e)
        {
            GetRecipes();
        }

        private void Cbx_getMyRecipes_Checked(object sender, RoutedEventArgs e)
        {
            GetRecipes();
        }

        private void Tbx_filterName_TextChanged(object sender, TextChangedEventArgs e)
        {
            GetRecipes();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible)
                GetRecipes();
        }

        #region CreateXMLData
        private void CreateXMLData()
        {
            var listInput = MyStorage.ReadXml<List<Recipe>>("InputData.xml");
            var recipes = new List<Recipe>();

            //initial load
            var recipeList = (from n in listInput
                              where n.ingredients.Count > 0
                              select n).Take(20).ToList();
        }
        #endregion CreateXMLData

        private void Tbx_ingredient_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                //Lbx_ingredient.Focus();
                //var dfdfg=Lbx_ingredient.Items;
                //Lbx_ingredient. = 0;
                //var listBoxItem = (ListBoxItem)Lbx_ingredient.ItemContainerGenerator.ContainerFromItem(Lbx_ingredient.SelectedItem);
                //listBoxItem.Focus();
                ////(Lbx_ingredient.Items[0] as ListBoxItem).Focus();
                //var KeyDow = e.Key;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddEditRecipe();
            addWindow.Owner = this;
            addWindow.Show();
            Visibility = Visibility.Hidden;
        }
    }
}