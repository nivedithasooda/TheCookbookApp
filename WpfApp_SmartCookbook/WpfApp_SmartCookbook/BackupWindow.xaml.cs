using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using WpfApp_SmartCookbook.models;

namespace WpfApp_SmartCookbook
{
    /// <summary>
    /// Interaction logic for BackupWindow.xaml
    /// </summary>
    public partial class BackupWindow : Window
    {
        public BackupWindow()
        {
            InitializeComponent();
        }
        private void CreateXMLData()
        {
            #region recipes
            List<Recipe> recipes = new List<Recipe>();
            recipes = new List<Recipe> {
            new Recipe
            {
                id = 1,
                name = "Potato Curry",
                description = "A simple and easy-to-make potato curry.",
                servings="4",
                timeRequired="00:30",
                instruction=@"1.	Add the coconut oil to large skillet on medium heat. Add minced garlic.
                            2.	Once garlic is fragrant, add diced onion and cook until starting to turn translucent, about 5 minutes.
                            3.	Add coconut milk, diced tomatoes, ginger, maple syrup, and spices. Stir to combine.
                            4.	Bring to a low simmer and add potatoes.
                            5.	Cover and let simmer on low/medium until potatoes are softened, 10 - 15 minutes.
                            6.	Add frozen peas, stir, and let sit for 5 minutes.
                            7.	Stir again and serve.
                            ",
                ingredients= new List<RecipeIngredient>
                {
                    new RecipeIngredient{
                        ingredientId =1,
                        ingredientName ="Potato",
                        ingredientType ="solid",
                        quantity ="250",
                        measure ="gram(s)",
                        recipeId =0},
                    new RecipeIngredient{
                        ingredientId =2,
                        ingredientName ="Coconut oil",
                        ingredientType ="cream",
                        quantity ="1",
                        measure ="tablespoon(s)"},
                    new RecipeIngredient{
                        ingredientId =3,
                        ingredientName ="Onion(s)",
                        ingredientType ="solid",
                        quantity ="200",
                        measure ="gram(s)"},
                    new RecipeIngredient{
                        ingredientId =4,
                        ingredientName ="Tomato(s)",
                        ingredientType ="solid",
                        quantity ="200",
                        measure ="gram(s)"},
                    new RecipeIngredient{
                        ingredientId =5,
                        ingredientName ="Coconut milk",
                        ingredientType ="solid",
                        quantity ="200",
                        measure ="ml"},
                    new RecipeIngredient{
                        ingredientId =6,
                        ingredientName ="Curry powder",
                        ingredientType ="spice",
                        quantity ="200",
                        measure ="ml"},
                    new RecipeIngredient{
                        ingredientId =7,
                        ingredientName ="Turmeric",
                        ingredientType ="spice",
                        quantity ="200",
                        measure ="ml"},
                    new RecipeIngredient{
                        ingredientId =8,
                        ingredientName ="Salt",
                        ingredientType ="spice",
                        quantity ="1",
                        measure ="teaspoon(s)"},
                    new RecipeIngredient{
                        ingredientId =9,
                        ingredientName ="Chilli powder",
                        ingredientType ="spice",
                        quantity ="1",
                        measure ="teaspoon(s)"},
                    new RecipeIngredient{
                        ingredientId =10,
                        ingredientName ="Curry powder",
                        ingredientType ="spice",
                        quantity ="1",
                        measure ="teaspoon(s)"},
                    new RecipeIngredient{
                        ingredientId =11,
                        ingredientName ="Garlic powder",
                        ingredientType ="spice",
                        quantity ="1",
                        measure ="teaspoon(s)"},
                    new RecipeIngredient{
                        ingredientId =12,
                        ingredientName ="Ginger powder",
                        ingredientType ="spice",
                        quantity ="1",
                        measure ="teaspoon(s)"}
                },
                isMyRecipe = false,
                isFavorite = false,
                image = @"Images\easy-potato-curry-1.jpg",
            },
        new Recipe
            {
                id = 2,
                name = "Oven-Roasted Potatoes",
                description = "A side dish that goes along with roasted chicken, lamb chops and almost anything!",
                servings="4",
                timeRequired="00:30",
                instruction=@"1.    Heat oven to 425°F. In an ungreased 15x10x1-inch pan, mix all ingredients; spread evenly.
                            2.  Roast uncovered 25 to 35 minutes, stirring occasionally, until potatoes are tender and browned.",
                ingredients= new List<RecipeIngredient>
                {
                    new RecipeIngredient{
                        ingredientId =1,
                        ingredientName ="Potato",
                        ingredientType ="solid",
                        quantity ="250",
                        measure ="gram(s)",
                        recipeId =0},
                    new RecipeIngredient{
                        ingredientId =2,
                        ingredientName ="Vegetable or olive oil",
                        ingredientType ="cream",
                        quantity ="2",
                        measure ="tablespoon(s)"},
                    new RecipeIngredient{
                        ingredientId =3,
                        ingredientName ="Rosemary leaves",
                        ingredientType ="spice",
                        quantity ="1",
                        measure ="teaspoon(s)" },
                    new RecipeIngredient{
                        ingredientId =4,
                        ingredientName ="Salt",
                        ingredientType ="spice",
                        quantity ="0.5",
                        measure ="teaspoon(s)"},
                    new RecipeIngredient{
                        ingredientId =5,
                        ingredientName ="Pepper powder",
                        ingredientType ="spice",
                        quantity ="0.5",
                        measure ="teaspoon(s)"}
                },
                isMyRecipe = false,
                isFavorite = false,
                image = @"",
            }};
            MyStorage.WriteXml<List<Recipe>>(recipes, "RecipeData.xml");
            #endregion recipes

            #region ingredient

            List<Ingredient> ingredient = new List<Ingredient>();
            ingredient = new List<Ingredient> {
            new Ingredient
            {
                id = 1,
                name = "Potato",
                type = "solid" },
            new Ingredient
            {
                id = 2,
                name = "Coconut oil",
                type = "creamy" },
            new Ingredient
            {
                id = 3,
                name = "Onion",
                type = "solid" },
            new Ingredient
            {
                id = 4,
                name = "Tomato",
                type = "solid" },
            new Ingredient
            {
                id = 5,
                name = "Rosemary leaves",
                type = "spice" },
            new Ingredient
            {
                id = 6,
                name = "Salt",
                type = "spice" },
            new Ingredient
            {
                id = 7,
                name = "Pepper powder",
                type = "spice" },
            new Ingredient
            {
                id = 8,
                name = "Coconut milk",
                type = "creamy" },
            new Ingredient
            {
                id = 9,
                name = "Curry powder",
                type = "spice" },
            new Ingredient
            {
                id = 10,
                name = "Turmeric",
                type = "spice" },
            new Ingredient
            {
                id = 11,
                name = "Chilli powder",
                type = "spice" },
            new Ingredient
            {
                id = 12,
                name = "Garlic powder",
                type = "spice" },
            new Ingredient
            {
                id = 13,
                name = "Ginger powder",
                type = "spice"
            },
            new Ingredient
            {
                id = 14,
                name = "Olive oil",
                type = "creamy"
            },
            new Ingredient
                {
                    id = 15,
                    name = "Vegetable oil",
                    type = "creamy"
                },
            new Ingredient
                {
                    id = 16,
                    name = "Sugar",
                    type = "creamy"
                },
            new Ingredient
                {
                    id = 17,
                    name = "Chicken",
                    type = "solid"
                }
            };
            MyStorage.WriteXml<List<Ingredient>>(ingredient, "IngredientData.xml");
            #endregion ingredient
        }
    }
}
