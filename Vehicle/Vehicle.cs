
using System.Linq.Expressions;

public class Car
{
  private String name { get; set; }
  private double velocity { get; set; }
  private double maxVelocity { get; set; }
  private int numberOfPassengers { get; set; }
  private double load { get; set; }
  private double maxLoad { get; set; }
  private int numberOfAxles { get; set; }

  public Car(String name, double maxVelocity, double maxLoad)
  {
    Console.WriteLine(name + ": creating a new car");
    this.name = name;
    this.maxVelocity = maxVelocity;
    this.maxLoad = maxLoad;
  }
  public void Drive()
  {
    Console.WriteLine(name + ": driving car");
    velocity = maxVelocity;
  }

  public void Stop()
  {
    Console.WriteLine(name + ": stopping car");
    velocity = 0;
  }

  public void Load(double load)
  {
    Console.WriteLine(name + ": loading " + load + "kg of cargo");
    if (this.load + load > maxLoad)
      throw new Exception(name + ": Overload by " + (this.load - maxLoad));
    this.load += load;
  }

  public void Unload(double load)
  {
    Console.WriteLine(this.name + ": unloading " + load + " kg of cargo");
    if (this.load < load)
      throw new Exception(this.name + ": Not enough load. Only has " + this.load);
    if(this.velocity>0)
      throw new Exception(this.name + ": Cannot unload. Car is driving " + this.velocity);
    this.load -= load;
  }
  public int sum(int a, int b) {
    return a + b;
  }

  public void honk(){
    Console.WriteLine(name + ": honk");
  }
}

