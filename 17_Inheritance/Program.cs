
Console.WriteLine("WelCome to the Cineplex\n");

#region SilverCustomer
Console.WriteLine("Welcome to The Silver Class Ticket\n");
SilverCustomer sc1 = new SilverCustomer();
sc1.ShowTiming();

bool status = sc1.IsTicketAvailable();

Console.WriteLine($"Is Ticket Available : {status}");

int amount = sc1.GetTicketAmount();
Console.WriteLine($"Ticket Amount : {amount}");

sc1.PrintTicket();

#endregion SilverCustomer

#region GoldCustomer
Console.WriteLine("Welcome to The Gold Class Ticket\n");
GoldCustomer gc1 = new GoldCustomer();
gc1.ShowTiming();

status = gc1.IsTicketAvailable();

Console.WriteLine($"Is Ticket Available : {status}");

amount = gc1.GetTicketAmount();
Console.WriteLine($"Ticket Amount : {amount}");

gc1.PrintTicket();

#endregion GoldCustomer

#region Platinum
Console.WriteLine("Welcome to The Platinum Class Ticket\n");
PlatinumCustomer pc1 = new PlatinumCustomer();

pc1.ShowTiming();

status = pc1.IsTicketAvailable();

Console.WriteLine($"Is Ticket Available : {status}");

amount = pc1.GetTicketAmount();
Console.WriteLine($"Ticket Amount : {amount}");

pc1.PrintTicket();

#endregion Platinum


Console.ReadLine();