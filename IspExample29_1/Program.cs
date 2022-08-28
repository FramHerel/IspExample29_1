// See https://aka.ms/new-console-template for more information
Driver driver = new Driver(new HeavyTank());
driver.Drive();

class Driver
{
    private IVehicle _Vehicle;
    public Driver(IVehicle vehicle)
    {
        _Vehicle = vehicle;
    }
    public void Drive()
    {
        _Vehicle.Run();
    }
}

interface IVehicle
{
    void Run();
}

class Car : IVehicle
{
    public void Run()
    {
        Console.WriteLine("Car is running ...");
    }
}

class Truck : IVehicle
{
    public void Run()
    {
        Console.WriteLine("Truck is running ...");
    }
}

interface IWeapon
{
    void Fire();
}
interface ITank:IVehicle, IWeapon
{

}

class LightTank : IVehicle
{
    public void Fire()
    {
        Console.WriteLine("Boom!");
    }

    public void Run()
    {
        Console.WriteLine("Ka Ka Ka");
    }
}

class MediumTank : IVehicle
{
    public void Fire()
    {
        Console.WriteLine("Boom!!");
    }

    public void Run()
    {
        Console.WriteLine("Ka! Ka! Ka!");
    }
}

class HeavyTank : ITank
{
    public void Fire()
    {
        Console.WriteLine("Boom!!!");
    }

    public void Run()
    {
        Console.WriteLine("Ka!! Ka!! Ka!!");
    }
}