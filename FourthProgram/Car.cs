using System;

public class Car : Vehicle
{
	public int SeatCount { get; set; }

	public Car(int wheels, int seats) : base(wheels)
	{
		this.SeatCount = seats;
	}
}
