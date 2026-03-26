Customer c1 = new Customer();
c1.ShowsTiming();  // Customer class

SilverCustomer Sc1 = new SilverCustomer();
Sc1.ShowsTiming();  // Silver Class Customer 

Customer c2 = new SilverCustomer();
c2.ShowsTiming();


GoldCustomer c3 = new GoldCustomer();
c3.ShowsTiming(); // Gold Class Customer


PlatinumCustomer c4 = new PlatinumCustomer();
c4.ShowsTiming(); // Platinum Class Customer


//Method hiding

//Writing same method with different implementation again in derived class which is already getting inherited from base class
//Derived class method hides base class method
//In method hiding, base class reference pointing derived class object will always call base class method




Console.ReadLine();