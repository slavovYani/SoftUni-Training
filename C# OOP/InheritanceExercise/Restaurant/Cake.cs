﻿
namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double GRAMS = 250;
        private const double CALORIES = 1000;
        private const decimal CAKE_PRICE = 5m;
        public Cake(string name) : base(name, CAKE_PRICE, GRAMS, CALORIES)
        {
            //Price = CAKE_PRICE;
            //Grams = GRAMS;
            //Calories = CALORIES;
        }
    }
}