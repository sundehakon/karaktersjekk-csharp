Console.Write("Skriv inn din poengsum: ");
string? userInput = (Console.ReadLine());

try
{
    int karakter = int.Parse(userInput);

    switch (karakter)
    {
        case int n when(n >= 0 && n <= 20):
            Console.WriteLine("Du får karakter 1.");
            break;
    
        case int n when(n >= 21 && n <= 40):
            Console.WriteLine("Du får karakter 2.");
            break;
    
        case int n when(n >= 41 && n <= 60):
            Console.WriteLine("Du får karakter 3.");
            break;

        case int n when(n >= 61 && n <= 80):
            Console.WriteLine("Du får karakter 4.");
            break;

        case int n when(n >= 81 && n <= 95):
            Console.WriteLine("Du får karakter 5.");
            break;

        case int n when(n >= 96 && n <= 100):
            Console.WriteLine("Du får karakter 6.");
            break;
    
        default: 
            Console.WriteLine("Ugyldig inndata. Skriv inn et tall mellom 0-100.");
            break;
    }
}
catch (FormatException)
{
    Console.WriteLine("Ugyldig inndata. Skriv inn et tall mellom 0-100.");
}