Console.Write("Skriv inn din poengsum: ");
string? userInput = Console.ReadLine();
try 
{
    if (int.TryParse(userInput, out int poengSum))
    {
        if (poengSum >= 0 && poengSum <= 20)
        {
            Console.WriteLine("Du får karakteren 1.");
        }
        else if (poengSum >= 21 && poengSum <= 40)
        {
            Console.WriteLine("Du får karakteren 2."); 
        } 
        else if (poengSum >= 41 && poengSum <= 60)
        {
            Console.WriteLine("Du får karakteren 3.");
        } 
        else if (poengSum >= 61 && poengSum <= 80)
        {
            Console.WriteLine("Du får karakteren 4.");
        } 
        else if (poengSum >= 81 && poengSum <= 95)
        {
            Console.WriteLine("Du får karakteren 5.");
        } 
        else if (poengSum >= 96 && poengSum <= 100)
        {
            Console.WriteLine("Du får karakteren 6.");
        } 
        else 
        {
            Console.WriteLine("Ugyldig inndata. Skriv et tall mellom 0-100.");
        }
    }
    else 
    {
        Console.WriteLine("Ugyldig inndata. Skriv et tall mellom 0-100.");   
    }
} 
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

