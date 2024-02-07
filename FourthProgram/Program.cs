class Program
{
    static void Main()
    {
        // FBGame.Prog();
        // Lander.Prog();
        Inheritance.Prog();
    }
}

class FBGame
{
    public static void Prog()
    {
        int numTurns = getUserInt("What would you like to count to? ");
        bool userTurn = getUserPrefPlayer();

        FizzBuzz game = new FizzBuzz(numTurns: numTurns, playerMove: userTurn);

        game.start();
    }

    static int getUserInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);

            if (int.TryParse(Console.ReadLine().Trim(), out int userInputInt))
            {
                return userInputInt;
            }

            Console.WriteLine("Please enter a valid integer!");
        }
    }

    static bool getUserPrefPlayer()
    {
        int userInputInt;

        do
        {
            userInputInt = getUserInt("Please select an option: (1) Your turn first, or (2) AI turn first: ");

            if (userInputInt < 1 || userInputInt > 2)
            {
                Console.WriteLine("Please enter a valid option!");
            }
        } while (userInputInt < 1 || userInputInt > 2);

        return userInputInt == 1;
    }
}

class Lander
{
    public static void Prog()
    {
        SpaceCraft craft = new SpaceCraft(1000);

        do
        {
            Console.WriteLine($"Current height: {craft.Height}m\nCurrent velocity: {craft.Velocity}m/s^2");
            Console.Write("Use thrust [y/n]? ");
            string userInput = Console.ReadLine().Trim();
            bool useThrust = false;
            if (userInput.ToLower() == "y")
                useThrust = true;

            craft.Simulate(useThrust);
        } while (craft.Height > 0);

        Console.WriteLine($"Current height: {craft.Height}m\nCurrent velocity: {craft.Velocity}m/s^2");

        if (craft.CrashCheck())
        {
            Console.WriteLine("The craft crashed!");
        } else
        {
            Console.WriteLine("You successfully landed the craft!");
        }
    }
}

class Inheritance
{
    public static void Prog()
    {
        Car myCar = new Car(4, 5);
        Console.WriteLine("{0} wheels & {1} seats", myCar.WheelCount, myCar.SeatCount);
    }
}