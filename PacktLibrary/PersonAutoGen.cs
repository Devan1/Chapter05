using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared
{
    public partial class Person
    {
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }
        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;
        public string Greeting => $"{Name} says 'Hello'";
        public string FavoriteIceCream { get; set; }
        private string favoritePrimaryColor;
        public string FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException(
                            $"{value} is not a primary color. " + "Choose from: re, green, blue.");
                }
            }
        }
        //indexers
        public Person this[int index]
        {
            get { return Children[index]; }
            set { Children[index] = value; }            
        }
    }
}
