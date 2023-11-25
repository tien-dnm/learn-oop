// Abstract classes = modifier that indicates missing components or incomplete implementation
// Lớp trừu tượng = cho biết các thành phần bị thiếu hoặc việc triển khai chưa đầy đủ
using VehicleLibs;

Car car = new();
Bicycle bicycle = new();
Boat boat = new();
//Vehicle vehicle = new Vehicle();
Console.ForegroundColor = ConsoleColor.Green;
Console.Error.WriteLine("It is not possible to create an object of the Vehicle class");
Console.ForegroundColor = ConsoleColor.Red;
Console.Error.WriteLine("Vehicle vehicle = new Vehicle();");
Console.ResetColor();

Console.ReadKey();
