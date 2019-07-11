using System;
using System.Collections.Generic;
using BuildingClass;

namespace CityClass {
    class City {
        // Creating City properties
        public string name { get; set; }
        public string mayor { get; set; }
        public int establishedYear { get; set; }
        public List<Building> buildingsInCity { get; set; }

        // Setting City constructor method
        public City(string name, string mayor, int establishedYear, List<Building> buildings) {
                var nameOfCity = name;
                var mayorOfCity = mayor;
                var establishedYearOfCity = establishedYear;
                var buildingsInCity = new List<Building>();
        }

}
}