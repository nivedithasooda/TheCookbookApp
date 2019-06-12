using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
    /// Interaction logic for AddEditRecipe.xaml
    /// </summary>
    public partial class AddEditRecipe : Window
    {
        private bool storeData = false;
        private bool isEdit = false;
        ObservableCollection<Recipe> recipes;
        ObservableCollection<RecipeIngredient> recipeIngredients;
        Recipe selectedRecipe;
        public AddEditRecipe()
        {
            InitializeComponent();
            Tbx_EditTitle.Visibility = Visibility.Collapsed;
            Cbx_servingsEdit.Visibility = Visibility.Collapsed;
            Sp_button.Visibility = Visibility.Collapsed;
            Cbx_minutesEdit.Visibility = Visibility.Collapsed;
            Cbx_hoursEdit.Visibility = Visibility.Collapsed;
            Cbx_servings.Visibility = Visibility.Visible;
            Cbx_minutes.Visibility = Visibility.Visible;
            Tbx_AddTitle.Visibility = Visibility.Visible;
            SaveButton.Visibility = Visibility.Visible;
            Cbx_hours.Visibility = Visibility.Visible;
            Cbx_servings.ItemsSource = GetComboboxOptions("servings");
            Cbx_servings.SelectedIndex = 0;
            Cbx_minutes.ItemsSource = GetComboboxOptions("minutes");
            Cbx_minutes.SelectedIndex = 0;
            Cbx_hours.ItemsSource = GetComboboxOptions("hours");
            Cbx_hours.SelectedIndex = 0;
        }

        public AddEditRecipe(Recipe _selectedRecipe)
        {
            InitializeComponent();
            selectedRecipe = _selectedRecipe;
            Cbx_servingsEdit.ItemsSource = GetComboboxOptions("servings");
            Cbx_minutesEdit.ItemsSource = GetComboboxOptions("minutes");
            Cbx_hoursEdit.ItemsSource = GetComboboxOptions("hours");
            isEdit = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            recipes = MyStorage.ReadXml<ObservableCollection<Recipe>>("InputData.xml");
            recipeIngredients = new ObservableCollection<RecipeIngredient>();
            if (selectedRecipe != null)
            {
                selectedRecipe.instruction = selectedRecipe.instruction.Replace("\\n", "\n");
                DataContext = selectedRecipe;
                if (selectedRecipe.ingredients.Count > 0)
                {
                    recipeIngredients = new ObservableCollection<RecipeIngredient>(selectedRecipe.ingredients);
                    Sp_Lbx_ingredients.Visibility = Visibility.Visible;
                    Lbx_ingredients.ItemsSource = recipeIngredients;
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var windowClose = SaveRecipe(false);
            if (windowClose == 1)
            {
                Owner.Visibility = Visibility.Visible;
                this.Visibility = Visibility.Hidden;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private List<string> GetComboboxOptions(string forcomboBox)
        {
            List<string> options = new List<string>();

            int maxValue = 0;
            int minValue = 0;
            switch (forcomboBox)
            {
                case "servings":
                    minValue = 1;
                    maxValue = 50;
                    break;
                case "minutes":
                    maxValue = 59;
                    break;
                case "hours":
                    maxValue = 24;
                    break;
            }

            for (int i = minValue; i <= maxValue; i++)
                options.Add(i.ToString());
            return options;
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.DefaultExt = @".jpg";
            open.Filter = @"Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            Nullable<bool> result = open.ShowDialog();
            if (result == true)
            {
                Tbx_image.Text = open.FileName;
            }
        }

        private void Tbx_ingredient_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Tbx_ingredientName.Text.Length >= 2)
            {
                Lbx_ingredient.Visibility = Visibility.Visible;
                GetIngredients(Tbx_ingredientName.Text);
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
            foreach (var ingAdded in recipeIngredients)
            {
                if (ingredientList.Contains(ingAdded.ingredientName))
                    ingredientList.Remove(ingAdded.ingredientName);
            }
            if (ingredientList.Count() > 0)
            {
                Lbx_ingredient.ItemsSource = ingredientList.Take(5);
            }
            else
            {
                Lbx_ingredient.Visibility = Visibility.Collapsed;
                Lbx_ingredient.ItemsSource = null;

            }
        }

        private void Tbx_ingredient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Lbx_ingredient.Items.Count > 0)
                {
                    Lbx_ingredient.SelectedIndex = 0;
                    Lbx_ingredient.Visibility = Visibility.Collapsed;
                    Tbx_quantity.Focus();
                }
                else if (Lbx_ingredient.ItemsSource == null && Tbx_ingredientName.Text.Length >= 4)
                {
                    MessageBox.Show("Please enter a valid ingredient!", ":|", MessageBoxButton.OK, MessageBoxImage.Error);
                    Tbx_ingredientName.Text = "";
                }
            }
        }

        private void Tbx_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                AddIngredientToList();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddIngredientToList();
        }

        private void AddIngredientToList()
        {
            storeData = true;
            var quantity = Tbx_quantity.Text;
            var ingredientName = Tbx_ingredientName.Text;
            if (quantity != "" || ingredientName != "")
            {
                if (quantity == "")
                {
                    MessageBox.Show("Please enter a quantity", ":|", MessageBoxButton.OK, MessageBoxImage.Error);
                    Tbx_quantity.Focus();
                    return;
                }
                else if (ingredientName == "")
                {
                    MessageBox.Show("Please enter an ingredient!", ":|", MessageBoxButton.OK, MessageBoxImage.Error);
                    Tbx_ingredientName.Focus();
                    return;
                }
                var ing = GetIngDetail(ingredientName, false);
                if (ing != null)
                {
                    if (ing.name == "")
                    {
                        MessageBox.Show("Please enter a valid ingredient!", ":|", MessageBoxButton.OK, MessageBoxImage.Error);
                        Tbx_ingredientName.Text = "";
                    }
                    else
                    {
                        Regex regEx = new Regex(@"^\d+\.?\d*$");
                        if (!regEx.IsMatch(quantity) || Convert.ToInt32(quantity) <= 0)//newly added
                        {
                            MessageBox.Show("Please enter a valid quantity", ":|", MessageBoxButton.OK, MessageBoxImage.Error);
                            Tbx_quantity.Focus();
                        }
                        else
                        {
                            var measure = Cbx_measure.SelectedValue == null ? "" : Cbx_measure.SelectedValue.ToString();
                            if (measure == Measurement.gram || measure == Measurement.ml)
                            {
                                var converted = ConvertToKilos(quantity, measure);
                                quantity = converted[1];
                                measure = converted[0];
                            }
                            else if (measure == Measurement.kg || measure == Measurement.liter)
                            {
                                //newly added
                                if (Convert.ToInt32(quantity) > 50)
                                {
                                    MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("That is a huge quantity! Are you sure you want to proceed?", "Add Ingredient Confirmation", System.Windows.MessageBoxButton.YesNo);
                                    if (messageBoxResult == MessageBoxResult.No || messageBoxResult == MessageBoxResult.Cancel || messageBoxResult == MessageBoxResult.None)
                                    {
                                        Tbx_quantity.Focus();
                                        Tbx_quantityEdit.Focus();
                                        return;
                                    }
                                }

                                var converted = ConvertTomillis(quantity, measure);
                                quantity = converted[1];
                                measure = converted[0];
                            }
                            var ingredient = new RecipeIngredient
                            {
                                ingredientName = ingredientName,
                                quantity = quantity,
                                measure = measure,
                                ingredientType = ing.type
                            };
                            recipeIngredients.Add(ingredient);
                            Sp_Lbx_ingredients.Visibility = Visibility.Visible;
                            Lbx_ingredients.ItemsSource = recipeIngredients;
                            Lbx_ingredients.SelectedItem = ingredient;
                            Lbx_ingredients.ScrollIntoView(ingredient);
                            Tbx_quantity.Text = "";
                            Tbx_ingredientName.Focus();
                            Tbx_ingredientName.Text = "";
                            Cbx_measure.ItemsSource = null;
                            Cbx_measure.Visibility = Visibility.Collapsed;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid ingredient!", ":|", MessageBoxButton.OK, MessageBoxImage.Error);
                    Tbx_ingredientName.Focus();
                    return;
                }
            }
        }

        private List<string> ConvertTomillis(string quantity, string measure)
        {
            List<string> measurement = new List<string>();
            var quan = Convert.ToDouble(quantity);
            if (quan < 1)
            {
                quan = (Convert.ToDouble(quantity) * 1000);
                quantity = quan.ToString();
                measure = measure == Measurement.kg ? Measurement.gram : Measurement.ml;
            }

            measurement.Add(measure);
            measurement.Add(quantity);
            return measurement;
        }

        private List<string> ConvertToKilos(string quantity, string measure)
        {
            List<string> measurement = new List<string>();

            var quan = (Convert.ToDouble(quantity) / 1000);
            if (quan >= 1)
            {
                quantity = quan.ToString();
                measure = measure == Measurement.gram ? Measurement.kg : Measurement.liter;
            }
            measurement.Add(measure);
            measurement.Add(quantity);
            return measurement;
        }

        private void Lbx_ingredient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Lbx_ingredient.SelectedItem != null)
            {
                var ingredient = Lbx_ingredient.SelectedItem.ToString();
                Lbx_ingredient.Visibility = Visibility.Collapsed;
                Lbx_ingredient.ItemsSource = null;
                Tbx_ingredientName.Text = ingredient;
                Tbx_quantity.Focus();
                PopulateMeasures(ingredient, "");
            }
        }

        private void PopulateMeasures(string ingredient, string selectValue)
        {
            var ing = GetIngDetail(ingredient, true);
            if (ing != null)
            {
                if (ing.type != null)
                {
                    TypeMeasurement measure = new TypeMeasurement(ing.type);
                    if (selectValue == "")
                    {
                        Cbx_measure.Visibility = Visibility.Visible;
                        Cbx_measure.ItemsSource = measure.measures;
                        Cbx_measure.SelectedIndex = 0;
                    }
                    else
                    {
                        Cbx_measureEdit.ItemsSource = measure.measures;
                        Cbx_measureEdit.SelectedValue = selectValue;
                        Cbx_measureEdit.Visibility = Visibility.Visible;
                    }
                }
                else
                {
                    Cbx_measure.Visibility = Visibility.Collapsed;
                    Cbx_measureEdit.Visibility = Visibility.Collapsed;
                }
            }
        }

        private Ingredient GetIngDetail(string ingredient, bool getType)
        {
            var listIngredients = MyStorage.ReadXml<List<Ingredient>>("IngredientData.xml");
            return (from l in listIngredients where l.name.ToLower().Equals(ingredient.ToLower()) select l).FirstOrDefault();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

            if (Lbx_ingredients.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to be deleted!");
                return;
            }

            Sp_Add.Visibility = Visibility.Visible;
            Sp_forEdit.Visibility = Visibility.Collapsed;
            recipeIngredients.Remove(Lbx_ingredients.SelectedItem as RecipeIngredient);
            if (Lbx_ingredients.Items.Count <= 0)
            {
                Sp_Lbx_ingredients.Visibility = Visibility.Collapsed;
                storeData = false;
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Sp_Add.Visibility = Visibility.Visible;
            Sp_forEdit.Visibility = Visibility.Collapsed;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var windowClose = SaveRecipe(true);
            if (windowClose == 1)
            {
                Owner.Visibility = Visibility.Visible;
                this.Visibility = Visibility.Hidden;
            }
        }

        private void UpdateRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            var windowClose = SaveRecipe(true);
            if (windowClose == 1)
            {
                Owner.Visibility = Visibility.Visible;
                this.Visibility = Visibility.Hidden;
            }
        }

        private int SaveRecipe(bool fromSave)
        {
            if (Tbx_recipeName.Text != "" || Tbx_recipeDescription.Text.Trim() != "" || Tbx_instructions.Text.Trim() != "" || Tbx_image.Text != "" || Lbx_ingredients.Items.Count > 0)
                storeData = true;
            else
                storeData = false;

            if (storeData)
            {
                if (Tbx_recipeName.Text != "")
                {
                    string imagePath = Tbx_image.Text;
                    string destPath = imagePath;
                    if (imagePath != "")
                    {
                        string[] parts = imagePath.Split('\\');
                        if (parts[0] != "")
                        {
                            string imageName = parts[parts.Length - 1];

                            destPath = @"\Images\" + imageName;
                            string currentDirectory = System.Environment.CurrentDirectory;
                            if (currentDirectory.EndsWith("\\bin\\Debug"))
                            {
                                int index = currentDirectory.IndexOf("\\bin\\Debug");
                                currentDirectory = currentDirectory.Substring(0, index);
                            }
                            File.Copy(imagePath, currentDirectory + destPath, true);
                        }
                        else
                        {
                            destPath = imagePath;
                        }
                    }
                    if (!isEdit)
                    {
                        var id = recipes.Max(m => m.id);
                        recipes.Add(new Recipe
                        {
                            isMyRecipe = true,
                            name = Tbx_recipeName.Text,
                            description = Tbx_recipeDescription.Text,
                            id = id + 1,
                            timeRequiredHours = Cbx_hours.SelectedValue.ToString(),
                            timeRequiredMinutes = Cbx_minutes.SelectedValue.ToString(),
                            servings = Cbx_servings.SelectedValue.ToString(),
                            instruction = Tbx_instructions.Text,
                            ingredients = recipeIngredients.ToList(),
                            isFavorite = Cbx_markFavorite.IsChecked.GetValueOrDefault(),
                            image = imagePath == "" ? @"\Images\noimage.jpg" : destPath
                        });
                        var recipeList = recipes.ToList();
                        MyStorage.WriteXml<List<Recipe>>(recipeList, "InputData.xml");
                        MessageBox.Show("Your recipe has been added to the cookbook.");
                    }
                    else
                    {
                        var listInput = MyStorage.ReadXml<List<Recipe>>("InputData.xml");
                        var recipe = (from n in listInput
                                      where n.id == Convert.ToInt32(selectedRecipe.id)
                                      select n).FirstOrDefault();
                        selectedRecipe.ingredients = recipeIngredients.ToList();
                        selectedRecipe.image = destPath;
                        listInput.Remove(recipe);
                        listInput.Add(selectedRecipe);
                        MyStorage.WriteXml<List<Recipe>>(listInput, "InputData.xml");
                    }
                    return 1;
                }
                else
                {
                    if (!fromSave)
                    {
                        MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Please enter a recipe name to save the recipe. Click yes to enter the name.", "Save recipe Confirmation", System.Windows.MessageBoxButton.YesNo);
                        if (messageBoxResult == MessageBoxResult.No || messageBoxResult == MessageBoxResult.Cancel || messageBoxResult == MessageBoxResult.None)
                        {
                            return 1;
                        }
                        else if (messageBoxResult == MessageBoxResult.Yes)
                        {
                            Tbx_recipeName.Focus();
                            return 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a recipe name to save the recipe.", ":|", MessageBoxButton.OK, MessageBoxImage.Error);
                        Tbx_recipeName.Focus();
                        return 0;
                    }
                }
            }
            return 1;
        }

        private void Cbx_measureEdit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ConvertValues(true);

        }
        private void DeleteRecipeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ConvertValues(bool fromSelect)
        {
            if (Cbx_measureEdit.SelectedItem != null)
            {
                var measure = Cbx_measureEdit.SelectedItem.ToString();
                var quantity = Tbx_quantityEdit.Text;
                if (quantity != "")
                {
                    Regex regEx = new Regex(@"^\d+\.?\d*$");
                    if (!regEx.IsMatch(quantity))
                    {
                        MessageBox.Show("Please enter a valid quantity", ":|", MessageBoxButton.OK, MessageBoxImage.Error);
                        Tbx_quantityEdit.Focus();
                    }
                    if (Cbx_measureEdit.SelectedItem.ToString() == Measurement.gram || Cbx_measureEdit.SelectedItem.ToString() == Measurement.ml)
                    {
                        var converted = ConvertToKilos(quantity, measure);
                        quantity = converted[1];
                        //var som = (Convert.ToDecimal(converted[1]));
                        //Decimal.Round(som, 2);
                        measure = converted[0];
                    }
                    else if (Cbx_measureEdit.SelectedItem.ToString() == Measurement.kg || Cbx_measureEdit.SelectedItem.ToString() == Measurement.liter)
                    {
                        if (!fromSelect)
                        {
                            if (Convert.ToInt32(quantity) > 50)
                            {
                                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("That is a huge quantity! Are you sure you want to proceed?", "Add Ingredient Confirmation", System.Windows.MessageBoxButton.YesNo);
                                if (messageBoxResult == MessageBoxResult.No || messageBoxResult == MessageBoxResult.Cancel || messageBoxResult == MessageBoxResult.None)
                                {
                                    Tbx_quantity.Focus();
                                    Tbx_quantityEdit.Focus();
                                    return;
                                }
                            }
                        }
                        var converted = ConvertTomillis(quantity, measure);
                        quantity = converted[1];
                        measure = converted[0];
                    }
            (Lbx_ingredients.SelectedItem as RecipeIngredient).quantity = quantity;
                    (Lbx_ingredients.SelectedItem as RecipeIngredient).measure = measure;
                }
            }
        }

        private void Lbx_ingredients_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Sp_Add.Visibility = Visibility.Collapsed;
            Sp_forEdit.Visibility = Visibility.Visible;
            PopulateMeasures(Tbx_ingredientNameEdit.Text, ((sender as ListBox).SelectedItem as RecipeIngredient).measure);
        }

        private void Tbx_quantityEdit_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertValues(false);
        }
    }
}
