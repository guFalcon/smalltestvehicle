var car1 = new Car("Opel", 130, 500);
car1.Load(49);
car1.Drive();
car1.Stop();
car1.Unload(49);

Console.WriteLine("");

var car2 = new Car("Toyota", 90, 200);
car2.Stop();
car2.Load(40);
car2.Drive();
car2.honk();
car2.Stop();
car2.Unload(40);

Console.WriteLine("done");
