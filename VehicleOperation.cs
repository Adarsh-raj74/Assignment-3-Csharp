using System;

public partial class Vehicle
{
    public void DisplayVehicleInfo()
    {
        Console.WriteLine("Vehicle Brand: " + Brand);
        Console.WriteLine("Vehicle Model: " + Model);
        Console.WriteLine("Vehicle Year: " + Year);
    }

    public void StartVehicle()
    {
        Console.WriteLine("Vehicle started successfully.");
    }

    public void StopVehicle()
    {
        Console.WriteLine("Vehicle stopped.");
    }
}