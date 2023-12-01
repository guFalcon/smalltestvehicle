
public class Car
{
  public double velocity { get; set; }
  public double maxVelocity { get; set; }
  public int numberOfPassengers { get; set; }
  public double load { get; set; }
  public double maxLoad { get; set; }
  public int numberOfAxles { get; set; }

  public Car(double maxVelocity, double maxLoad)
  {
    this.maxVelocity = maxVelocity;
    this.maxLoad = maxLoad;
  }
  public void Drive()
  {
    velocity = maxVelocity;
  }

  public void Stop()
  {
    velocity = 0;
  }

  public void Load(double load)
  {
    if (this.load + load > maxLoad)
      throw new Exception("Overload by " + (this.load - maxLoad));
    this.load += load;
  }

  public void Unload(double load)
  {
    if (this.load < load)
      throw new Exception("Not enough load. Only has " + this.load);
    this.load -= load;
  }
}
