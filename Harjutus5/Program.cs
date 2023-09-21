Console.WriteLine("Enter C to convert Celsius, enter F to convert Fahrenheit):");
string userChoice = Console.ReadLine().ToUpper();


Console.WriteLine("Enter degrees you would like to convert:");
int UserInput = Int32.Parse(Console.ReadLine());

int b = 5;
int c = 32;
int d = 9;

switch (userChoice)
{
    case "C":
        ConvertToCelsius(UserInput, b, c, d);
        break;
    case "F":
        ConvertToFahrenheit(UserInput, b, c, d);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}
static void ConvertToCelsius(int a, int b, int c, int d)
{
    Console.WriteLine($"Fahrenheit {a} degrees is in Celsius {(a-c)*b/d} degrees");
}
static void ConvertToFahrenheit(int a, int b, int c, int d)
{
    Console.WriteLine($" Celsius{a} degrees is in Fahrenheit {(a*d)/b+c} degrees");
}
