try
{
    int Divide(int a, int b)
    {
        return a / b;
    }
    int ReadAndDivide()
    {
        Console.Write("Numerator: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Denominator: ");
        int b = int.Parse(Console.ReadLine()!);
        return Divide(a, b);
    }

    Console.WriteLine(ReadAndDivide());    
}
catch(FormatException e)
{
    Console.WriteLine(e.Message);
}
catch(IndexOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch(DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("devision completed");
}