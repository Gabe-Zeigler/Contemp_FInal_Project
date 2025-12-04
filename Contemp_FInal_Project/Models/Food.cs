namespace Contemp_FInal_Project.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string IsVegetarian { get; set; }
        public int Calories { get; set; }
        public string Cuisine { get; set; }
        public string DrinkPairing { get; set; }

        public Food() { }

        public Food (int foodid, string foodname, string isvegetarian, int calories, string cuisine, 
            string drinkpairing)
        {
            FoodId = foodid;
            FoodName = foodname;
            IsVegetarian = isvegetarian;
            Calories = calories;
            Cuisine = cuisine;
            DrinkPairing = drinkpairing;
        }


    }
}
