using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
         static void Main(string[] args) {
             Building FiveOneTwoEighth = new Building("512 8th Avenue"){
                 Stories = 24,
                 Width = 30,
                 Depth = 20
             };

             FiveOneTwoEighth.Construct();
             FiveOneTwoEighth.Purchase("Steve Jobs");
             
             Building PinnacleTower = new Building("123 4th Ave South"){
                 Stories = 36,
                 Width = 40,
                 Depth = 40
             };

             PinnacleTower.Construct();
             PinnacleTower.Purchase("Donald Trump");

             Building BridgstoneTower = new Building("322 8th Ave South"){
                 Stories = 46,
                 Width = 60,
                 Depth = 60
             };

             BridgstoneTower.Construct();
             BridgstoneTower.Purchase("John Bridgestone");

             //Create list of buldings in city
             List<Building> buildings = new List<Building>() {
                 FiveOneTwoEighth, PinnacleTower, BridgstoneTower
             };

             //Create city

             City Brianville = new City("Brianville", 2019);
             Brianville.Mayor("Bill Boner");

             Brianville.newBuilding(FiveOneTwoEighth);
             Brianville.newBuilding(PinnacleTower);
             Brianville.newBuilding(BridgstoneTower);

             //After all of the buildings have been purchased, display the following information to the console for each building.

             foreach(Building building in Brianville.buildingsOfCity){
                Console.WriteLine();
                Console.WriteLine($"Here are the buildings of {Brianville.cityName}:");
                Console.WriteLine();
                Console.WriteLine(building.GetAddress());
                Console.WriteLine("-------------------");
                Console.WriteLine($"Designed by {building.GetDesigner()}.");
                Console.WriteLine($"Constructed on {building.GetDateConstructed()}.");
                Console.WriteLine($"Owned by {building.GetOwner()}");
                Console.WriteLine($"{building.Volume} cubic meters of space.");
                Console.WriteLine();
             }

         }
    }
}
