public class GoldCustomer : Customer
{
    //int TicketAmount = 500;

    //int hallNumber;


    public GoldCustomer()   //Constructor

    {
        TicketAmount = 500;
        hallNumber = 3;
    }

    //public void ShowTiming()  //Method
    //{

    //    Console.WriteLine("*** We are showing Today ***");

    //}

    //public bool IsTicketAvailable()
    //{
    //    // Logic ** check availability of seats and then reutn true or false ** //
    //    return true;
    //}

    //public int GetTicketAmount()
    //{
    //    return TicketAmount;
    //}

    public void PrintTicket()
    {
        Console.WriteLine("Gold Ticket Printed\n");
    }

}
