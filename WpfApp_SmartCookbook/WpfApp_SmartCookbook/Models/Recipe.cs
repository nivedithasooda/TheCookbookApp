using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_SmartCookbook.models
{
    public class Recipe : INotifyPropertyChanged
    {
        public int id { get; set; }
        //public string name { get; set; }
        //public string description { get; set; }
        public string timeRequired { get; set; }
        //public string timeRequiredHours { get; set; }
        //public string timeRequiredMinutes { get; set; }
        //public string servings { get; set; }
        //public bool isFavorite { get; set; }
        //public bool isDelete { get; set; }
        public bool isMyRecipe { get; set; }
        //public string image { get; set; }
        //public string instruction { get; set; }
        //public List<RecipeIngredient> ingredients { get; set;}
        public string notes { get; set; }

        private string name_;
        public string name
        {
            get { return name_; }
            set
            {
                name_ = value;
                OnPropertyChanged("quantity");
            }
        }

        private string description_;
        public string description
        {
            get { return description_; }
            set
            {
                description_ = value;
                OnPropertyChanged("quantity");
            }
        }

        private string timeRequiredHours_;
        public string timeRequiredHours
        {
            get { return timeRequiredHours_; }
            set
            {
                timeRequiredHours_ = value;
                OnPropertyChanged("quantity");
            }
        }

        private string timeRequiredMinutes_;
        public string timeRequiredMinutes
        {
            get { return timeRequiredMinutes_; }
            set
            {
                timeRequiredMinutes_ = value;
                OnPropertyChanged("quantity");
            }
        }

        private string servings_;
        public string servings
        {
            get { return servings_; }
            set
            {
                servings_ = value;
                OnPropertyChanged("quantity");
            }
        }

        private bool isFavorite_;
        public bool isFavorite
        {
            get { return isFavorite_; }
            set
            {
                isFavorite_ = value;
                OnPropertyChanged("quantity");
            }
        }

        private bool isDelete_;
        public bool isDelete
        {
            get { return isDelete_; }
            set
            {
                isDelete_ = value;
                OnPropertyChanged("quantity");
            }
        }

        private string image_;
        public string image
        {
            get { return image_; }
            set
            {
                image_ = value;
                OnPropertyChanged("quantity");
            }
        }

        private List<RecipeIngredient> ingredients_;
        public List<RecipeIngredient> ingredients
        {
            get { return ingredients_; }
            set
            {
                ingredients_ = value;
                OnPropertyChanged("quantity");
            }
        }

        private string instruction_;
        public string instruction
        {
            get { return instruction_; }
            set
            {
                instruction_ = value;
                OnPropertyChanged("quantity");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
