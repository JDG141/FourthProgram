using System;
using System.Text;

public class FizzBuzz
{
    private int _numTurns;
    private bool _playerMove;

    public FizzBuzz (int numTurns = 30, bool playerMove = true)
    {
        this._numTurns = numTurns;
        this._playerMove = playerMove;
    }

    public void start()
    {
        Console.WriteLine($"Let's count FizzBuzz to {this._numTurns}!");

        if (this._playerMove)
            Console.WriteLine("You start!\n");

        for (int i = 1; i <= this._numTurns; i++)
        {
            if (this._playerMove)
            {
                playerTurn(i);
            }
            else
            {
                aiTurn(i);
            }

            this._playerMove = !this._playerMove;
        }

        Console.WriteLine($"Congrats! You counted FizzBuzz to {this._numTurns}");
    }

    private void playerTurn(int turn)
    {
        string correctAnswer = FizzBuzzer(turn);
        string userInput;

        do
        {
            Console.Write("You: ");
            userInput = Console.ReadLine().Trim();

            if (!userInput.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("That doesn't look right to me!");
        } while (!userInput.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase));
    }

    private void aiTurn(int turn)
    {
        Console.WriteLine("AI:  " + FizzBuzzer(turn));
    }

    private string FizzBuzzer(int num)
    {
        StringBuilder message = new StringBuilder();

        if (num % 3 == 0)
            message.Append("Fizz");

        if (num % 5 == 0)
            message.Append("Buzz");

        return message.Length == 0 ? num.ToString() : message.ToString();
    }
}