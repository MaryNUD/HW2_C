Console.Write("Insert a number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 100 && n <= 999)
{
    int n3 = n % 10;
    Console.WriteLine("The third figure is " + n3);
}
else 
Console.WriteLine("There is no third figure or the number is too big "); 
// I don't get how to make it work for longer numbers. I'm sorry!