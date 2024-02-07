public class SpaceCraft
{
	// Constants
	private const double MoonGravity = -1.625;
	private const double RocketThrust = 2.5;
	private const double MaxLandingSpeed = -10;

	// Public properties
	public double Height { get; private set; }
	public double Velocity { get; private set; }

	// Constructor
	public SpaceCraft(double initialHeight)
	{
		this.Height = initialHeight;
		this.Velocity = 0;
	}

	// Simulate
	public void Simulate(bool thrust)
	{
		double acceleration = MoonGravity;

		if (thrust)
			acceleration += RocketThrust;

		this.Height = this.Height + (0.5f * acceleration * 1 * 1) + (this.Velocity * 1);
		this.Velocity = this.Velocity + (acceleration * 1);

		this.Height = this.Height < 0 ? 0 : this.Height;
	}

	// Check if crashed
	public bool CrashCheck()
	{
		if (this.Velocity <= MaxLandingSpeed)
			return true; // Crashed

		return false; // Landed
	}
}
