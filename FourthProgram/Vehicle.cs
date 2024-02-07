using System;

public abstract class Vehicle
{
	public int WheelCount { get; set; }

	public Vehicle(int wheels)
	{
		this.WheelCount = wheels;
	}

	public void Accelerate()
	{
		Console.WriteLine("Accelerate");
	}

	public void Brake()
	{
		Console.WriteLine("Brake");
	}
}
