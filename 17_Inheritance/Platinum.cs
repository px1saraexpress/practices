public class PlatinumCustomer : Customer
{
    public PlatinumCustomer()   //Constructor

    {
        TicketAmount = 800;
        hallNumber = 3;
    }

    public void PrintTicket()
    {
        Console.WriteLine("Platinum Ticket Printed");
    }

}
