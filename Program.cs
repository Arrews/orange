Random r = new Random();

int winNum = r.Next(0, 100);

bool win = false;

do
{
    Console.Write("Guess a number. Between 0-100:");
    string s = Console.ReadLine();

    int i = Convert.ToInt32(s);

    if (i>winNum)
    {
        Console.WriteLine("Too high!");
    }
    else if (i<winNum)
    {
        Console.WriteLine("Too low!");
    }
    else if (i==winNum)
    {
        Console.WriteLine("That's the right number. Congratulations!");
        win = true;
    }

    Console.WriteLine();

} while (win == false);

Console.WriteLine("Thank you for playing! Press any key to finish.");
Console.ReadKey(true);
