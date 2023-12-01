// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("creating a new car");
var car = new Car(130, 500);
Console.WriteLine("loading 50kg of cargo");
car.Load(50);
Console.WriteLine("driving car");
car.Drive();
Console.WriteLine("stoppping car");
car.Stop();
Console.WriteLine("unloading 50kg of cargo");
car.Unload(50);
Console.WriteLine("done");
