namespace Lab1.exceptions;

public class BadPowerValueException : Exception
{
    public BadPowerValueException()
    {
    }

    public BadPowerValueException(string message) : base(message)
    {
        Console.WriteLine($"Bad power value, reason:\n{message}");
    }
}