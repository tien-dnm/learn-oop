// Có nhiều hình thức (Đa hình)
using VehicleLibs;
/**
polymorphism = Greek word that means to "have many forms"
 Objects can be identified by more than one type
*/
Car car = new();
Bicycle bicycle = new();
Boat boat = new();
Vehicle[] vehicles = { car, bicycle, boat };

foreach (Vehicle vehicle in vehicles)
{
    vehicle.Go();
}

Console.ReadKey();

