using System;
using BuildingClass;
using CityClass;

namespace Planner
{
    class Program
    {
        // Main method
        static void Main(string[] args)
        {
        // Instantiating three buildings
        var building1 = new Building("512 8th Avenue") {
            Width = 50,
            Depth = 80,
            Stories = 7
        };

        var building2 = new Building("1939 Street Avenue")  {
            Width = 140,
            Depth = 90,
            Stories = 10
        };
        var building3 = new Building("265 Park Blvd.")  {
            Width = 36,
            Depth = 59,
            Stories = 5
        };
        // log construction date time
        building1.Construct();
        building2.Construct();
        building3.Construct();
        // assign an owner
        building1.Purchase("Emily Loggins");
        building2.Purchase("Caroline Mohler");
        building3.Purchase("Kendal Miller");
        
        // Create a new City instance
        City city1 = new City("Nashville", "David Briley", 1776);

        // Add building to City
        city1.AddBuilding(building1);
        city1.AddBuilding(building2);
        city1.AddBuilding(building3);

        foreach (Building building in city1.buildingsInCity) {
            Console.WriteLine(building.Volume);
        }
    }
    }
}
