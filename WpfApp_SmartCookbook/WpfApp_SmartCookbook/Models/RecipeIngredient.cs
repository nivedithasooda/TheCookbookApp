using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_SmartCookbook.models
{
    public class RecipeIngredient: INotifyPropertyChanged
    {
        public int recipeId { get; set; }
        public int ingredientId { get; set; }
        public string quantity {
            get { return quantity_; }
            set
            {
                quantity_ = value;
                OnPropertyChanged("quantity");
            }
        }

        private string quantity_;
        public string measure {
            get { return measure_; }
            set
            {
                measure_ = value;
                OnPropertyChanged("measure");
            }
        }
        private string measure_;
        //added
        public string ingredientName { get; set; }
        public string ingredientType { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
