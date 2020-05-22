using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace Animal
{
    public class Animal
    {
        public Animal(string name,string favoritFood)
        {
            Name = name;
            FavoritFood = favoritFood;
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string favoritFood;

        public string FavoritFood 
        {
            get { return favoritFood; }
            set { favoritFood = value; }
        }
        public virtual string Explainself() { return $"I am {this.name } and my favorite food is {this.favoritFood}"; }

    }
}
