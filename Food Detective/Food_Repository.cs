using System.Collections.Generic;
using Npgsql;
using System;

namespace Harmful_Ingredients_Search
{
    public class Food_Repository
    {
        public HashSet<string> GetFoods(string input)
        {
            var foodItems = new HashSet<string>();

            if (input == string.Empty)
            {
                throw new ArgumentException("Input cannot be empty");
            }

            input = input.ToUpper();

            NpgsqlConnection conn = new NpgsqlConnection("Server=branded-ingredients-dev.cjk80otetrwy.us-east-1.rds.amazonaws.com;User Id=my_ro_user; " +
            "Password=YouAreReadingMyTestDBOnly; Database=branded_food;");

            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand($"SELECT * FROM title_ingredients WHERE description LIKE '%' || @input || '%';", conn);

            command.Parameters.AddWithValue("@input", input);

            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                if (!string.IsNullOrWhiteSpace(dr[1].ToString()))
                {
                    foodItems.Add(dr[1].ToString());
                }
            }

            if (foodItems.Count == 0)
            {
                foodItems.Clear();
                foodItems.Add("Sorry. Unknown food item. Please try again.");
            }

            conn.Close();

            return foodItems;
        }

        public List<string> GetAll_Ingredients(string selectedFood)
        {
            var allIngredients = new List<string>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=branded-ingredients-dev.cjk80otetrwy.us-east-1.rds.amazonaws.com;User Id=my_ro_user; " +
            "Password=YouAreReadingMyTestDBOnly; Database=branded_food;");

            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand($"SELECT ingredients FROM title_ingredients WHERE description = @selectedFood;", conn);

            command.Parameters.AddWithValue("@selectedFood", selectedFood);

            NpgsqlDataReader dr = command.ExecuteReader();

            while(dr.Read())
            {
                allIngredients.Add(dr[0].ToString());
            }

            conn.Close();

            return allIngredients;
        }
        
        public List<string> GetBad_Ingredients(List<string> allingredientsList)
        {
            var badingredientsList = new List<string>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=branded-ingredients-dev.cjk80otetrwy.us-east-1.rds.amazonaws.com;" +
                "User Id=my_ro_user; " + "Password=YouAreReadingMyTestDBOnly; Database=branded_food;");

            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand("SELECT full_name, abbreviation FROM bad_ingredients", conn);

            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                badingredientsList.Add(dr[0].ToString());
                if (dr[1].ToString() != "")
                    badingredientsList.Add(dr[1].ToString());
            }

            var result = new List<string>();

            foreach (var element in badingredientsList)
            {
                foreach (var ingredient in allingredientsList)
                {
                    if (ingredient.Contains(element) && result.Contains(element) == false)
                        result.Add(element);
                }
            }

            conn.Close();

            return result;
        }
    }
}