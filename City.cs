using System;
using System.Collections.Generic;

namespace Planner 
{
    class City
    {
        // Now you need to create a type to represent your city.Here are the requirements for the class. You determine if/when to use fields, properties, a constructor, and methods.

        // 1. Name of the city.
        // 2. The mayor of the city.
        // 3. Year the city was established.
        // 4. A collection of all of the buildings in the city.
        // 5. A method to add a building to the city.
        // Remember, each class should be in its own file.Create a City.cs file and define the City class in there.Make sure it's in the same namespace as your other classes.

        public string cityName;
        private string _mayor;
        private int _yearCityEstablished;
        public City(string name, int yearEstablished) {
            cityName = name;
            _yearCityEstablished = yearEstablished;
            buildingsOfCity = new List<Building>();
        }
        public List<Building> buildingsOfCity {get; set;}

        public void Mayor(string mayorName) {
            _mayor = mayorName;
        }

        public void newBuilding(Building building) {
            buildingsOfCity.Add(building);
        }
        
    }
}
