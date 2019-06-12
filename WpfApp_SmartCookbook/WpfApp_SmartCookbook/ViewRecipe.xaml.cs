using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<Recipe> listInput;
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
            listInput = MyStorage.ReadXml<ObservableCollection<Recipe>>("InputData.xml");
            SetRecipeDetail();
        }

        private void SetRecipeDetail()
        {
            if (selectedRecipe != null)
            {
                selectedRecipe.instruction = selectedRecipe.instruction.Replace("\\n", "\n");
                DataContext = null;
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
            MakeUpdateToRecipe();
            Owner.Visibility = Visibility.Visible;
        }

        private void MakeUpdateToRecipe()
        {
            var recipe = (from n in listInput
                          where n.id == Convert.ToInt32(selectedRecipe.id)
                          select n).FirstOrDefault();
            listInput.Remove(recipe);
            listInput.Add(selectedRecipe);
            MyStorage.WriteXml<ObservableCollection<Recipe>>(listInput, "InputData.xml");
        }

        private void StarImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var favoriteValue = !selectedRecipe.isFavorite;
            Tbk_isFavorite.Text = favoriteValue == true ? Properties.Settings.Default.FilledHeart : Properties.Settings.Default.EmptyHeart;
            Tbk_isFavorite.ToolTip = favoriteValue == true ? Properties.Settings.Default.Markedfavorite : Properties.Settings.Default.Markfavorite;
            selectedRecipe.isFavorite = favoriteValue;
        }

        private void Btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("The recipe will no longer be available in the cookbook. Are you sure you want to delete?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                selectedRecipe.isDelete = true;
                MakeUpdateToRecipe();
                Owner.Visibility = Visibility.Visible;
                this.Visibility = Visibility.Hidden;
            }
        }

        private void Btn_EditClic(object sender, RoutedEventArgs e)
        {
            MakeUpdateToRecipe();
            var editWindow = new AddEditRecipe(selectedRecipe);
            editWindow.Owner = this;
            editWindow.Show();
            Visibility = Visibility.Hidden;
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible)
            {
                SetRecipeDetail();
                var favoriteValue = selectedRecipe.isFavorite;
                Tbk_isFavorite.Text = favoriteValue == true ? Properties.Settings.Default.FilledHeart : Properties.Settings.Default.EmptyHeart;
                Tbk_isFavorite.ToolTip = favoriteValue == true ? Properties.Settings.Default.Markedfavorite : Properties.Settings.Default.Markfavorite;
            }
        }
    }
}
