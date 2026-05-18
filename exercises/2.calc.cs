using System.ComponentModel.DataAnnotations;

Console.Write("Enter a number: ");
try
{
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine(100/n);
}
catch(FormatException e)
{
    Console.WriteLine("invalid number", e.Message);
}
catch(OverflowException)
{
    Console.WriteLine("number too big or too small");
}
catch (DivideByZeroException)
{
    Console.WriteLine("you can't devide by 0");
}
finally
{
    Console.WriteLine("devision done");
}
