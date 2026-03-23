public class Customer

{
    public int TicketAmount;   //class fields

    public int hallNumber;     //class fields


    public void ShowTiming()  //Method
    {


        Console.WriteLine("*** We are showing Today ***");

    }

    public bool IsTicketAvailable()
    {
        // Logic ** check availability of seats and then reutn true or false ** //
        return true;
    }

    public int GetTicketAmount()
    {
        return TicketAmount;
    }

}
