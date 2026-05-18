// Snippet A
try
{
    int[] arr = new int[3];
    arr[10] = 5;
}
catch(IndexOutOfRangeException)
{
    Console.WriteLine("cannot edit element that doesn't exist");
}

// Snippet B
try
{
    string s = null!;
    Console.WriteLine(s.Length);
}
catch (NullReferenceException e)
{
    Console.WriteLine(e.Message);
}

// Snippet C
try
{
    int x = int.MaxValue;
    checked { x = x + 1; }   // checked enforces overflow detection
}
catch (OverflowException e)
{
    Console.WriteLine(e.Message);
}
