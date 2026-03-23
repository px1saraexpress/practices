using System.Threading.Channels;

public class SilverCustomer : Customer   /// Class

{
    //int TicketAmount;   //class fields

    //int hallNumber;     //class fields

    public SilverCustomer()   //Constructor

    {
        TicketAmount = 200;
        hallNumber = 3;
    }
    
    
    
    //public void ShowTiming()  //Method
    //{

       
    //    Console.WriteLine("*** We are showing Today ***");

    //}

    //public bool IsTicketAvailable()
    //{ 
    //    // Logic ** check availability of seats and then reutn true or false ** //
    //return true;
    //}

    //public int GetTicketAmount()
    //{ 
    // return TicketAmount;
    //}

    public void PrintTicket()
    {
        Console.WriteLine("Silver Ticket Printed\n");
    }



}

