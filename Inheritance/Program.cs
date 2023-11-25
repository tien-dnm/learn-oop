// inheritance = 1 or more child classes receiving fields, methods, etc. from a common parent
using VehicleLibs;

Car car = new(200);
Bicycle bicycle = new(10);
Boat boat = new(5);
// các lớp con nhận những trường, phương thức từ lớp cha.
Console.WriteLine("The car's speed is {0} km/h", car.Speed);
Console.WriteLine("The car has {0} wheels", car.wheels);
car.Go();

Console.WriteLine("The bicycle's speed is {0} km/h", bicycle.Speed);
Console.WriteLine("The bicycle has {0} wheels", bicycle.wheels);
bicycle.Go();

Console.WriteLine("The boat's speed is {0} km/h", boat.Speed);
Console.WriteLine("The boat has {0} wheels", boat.wheels);
boat.Go();

Console.ReadKey();
