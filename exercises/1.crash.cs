string[] names = { "Alice", "Bob", "Charlie" };
Console.Write("Enter an index: ");
try
{
    int i = int.Parse(Console.ReadLine()!);
    Console.WriteLine(names[i]);
}
catch(FormatException e)
{
    Console.WriteLine("invalid index", e.Message);
}
catch(IndexOutOfRangeException)
{
    Console.WriteLine("index too big or less then 0");
}
finally
{
    Console.WriteLine("name array available");
}