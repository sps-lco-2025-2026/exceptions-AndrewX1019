
using System.Dynamic;

try
{
    double London = double.Parse(Console.ReadLine()!);
    if(London < 273.15)
    {
        throw new LowTemperatureException(London);
    }
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}
catch (LowTemperatureException e) 
{
    Console.WriteLine(e.Message);
}
class TemperatureException : Exception
{
    public TemperatureException(string message) : base(message){}
    public TemperatureException(string message, Exception e) : base(message, e){}
}

class LowTemperatureException : TemperatureException
{
    double Temp {get;}
    public LowTemperatureException(double d)
        :base($"cannot have temperature {d} which is below -273.15", LowTemperatureException)
    {
        Temp = d;
    }

}