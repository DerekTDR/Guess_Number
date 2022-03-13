// Guess Random Number
// Start
Random a = new Random();

// Random Number
int number = a.Next(1, 10);
int x = 0;

// Text Made By OS
Console.WriteLine("I drew a number from 1 to 10!");


while (true)
{

    // Read Whole Line
    string variable = Console.ReadLine();


    // Change The String "variable" To The Value "x"
    if (!Int32.TryParse(variable, out x))
    {
        Console.WriteLine("Guess the drawn number!");
        continue;
    }
    // Value "if"
    if (x == number)
    {
        Console.WriteLine("Congratulations! You guessed the number!");
        break;
    }
    else if (x > number)
    {
        Console.WriteLine("The number drawn is smaller");
        continue;
    }
    else if (x < number)
    {
        Console.WriteLine("The number drawn is bigger");
        continue;
    }
}