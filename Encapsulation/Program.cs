using VehicleLibs;

Car car = new(400);
// bảo vệ thuộc tính speed, dùng thuộc tính Speed không cho phép speed vượt quá tốc độ
Console.WriteLine("The car's speed is {0} km/h", car.Speed);

Console.ReadKey();
