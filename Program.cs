using System.Text.RegularExpressions;

string input = "0";

while(input != "99")
{
    Console.WriteLine("1. Add a shape.");
    Console.WriteLine("2. Remove a shape.");
    Console.WriteLine("3. Store a shape.");
    Console.WriteLine("4. Edit a shape.");
    Console.WriteLine("5. Show all stored shapes.");
    while (true)
    {
        input = Console.ReadLine();
        input = input.Trim();
        if (input == "0")
            return;

        if(Regex.Match(input, "^(99)|([0-9])$").Success)
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid number, please try again.");
        }
    }

    switch (input)
    {
        case "1":
            {
                Console.Clear();
                Console.WriteLine("1. Add a shape");
                //TODO Create a function
                break;
            }
        case "2":
            {
                Console.Clear();
                Console.WriteLine("2. Remove a shape");
                //TODO Create a function
                break;
            }
        case "3":
            {
                Console.Clear();
                Console.WriteLine("3. Store a shape.");
                //TODO Create a function
                break;
            }
        case "4":
            {
                Console.Clear();
                Console.WriteLine("4. Edit a shape.");
                //TODO Create a function
                break;
            }
        case "5":
            {
                Console.Clear();
                Console.WriteLine("5. Show all stored shapes.");
                //TODO Create a function
                break;
            }
        default:
            return;
    }
}