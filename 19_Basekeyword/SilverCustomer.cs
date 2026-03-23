public class SilverCustomer :Customer
{
    public string Name = "Vikas";


    public void PrintName()
    {
        Console.WriteLine($"Silver class customer name = {Name}");
    }
}

