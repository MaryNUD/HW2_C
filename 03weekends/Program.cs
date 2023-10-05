Console.Write("Insert a number of the day: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 1 && n <= 7)
{
    if (n == 6 || n == 7)
        Console.WriteLine("Today is a weekend!!!");
    else 
        Console.WriteLine("Sorry, you have to go and work");
}
else 
Console.WriteLine("There is no such day of the week");