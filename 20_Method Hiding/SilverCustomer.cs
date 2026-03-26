public class SilverCustomer : Customer
{ 


    public new void ShowsTiming()
    {

        Console.WriteLine("** Shows for Silver Class Customer **\n");
    }
       

}

public class GoldCustomer : Customer
{

    public new void ShowsTiming()
    {

        Console.WriteLine("** Shows for Gold Class Customer **\n");
    }


}

public class PlatinumCustomer : Customer
{

    public new void ShowsTiming()
    {

        Console.WriteLine("** Shows for Platinum Class Customer **\n");
    }


}
