#region General 
//int customerId = 1001;
//string customerName = "Akash";
//string customerPhone = "9787475869";

//Console.WriteLine($"Customer id = {customerId}\nCustomer Name = {customerName}\nCustomer contact number = {customerPhone}\a");
#endregion General
# region objects of class

using System.Security.Cryptography;

Customer c1 = new Customer();   // this is an object of customer class //
c1.customerId = 1001;
c1.firstName = "Akash";
c1.lastName = "Kale";
c1.contactNumber = "9798945741";
c1.emailId = "akash.kale@hotmail.com";

c1.CustomerDetails(); // Data & Function binding together // 


//Console.WriteLine($"Customer Id = {c1.customerId}\nFirst Name = {c1.firstName}\nLast Name = {c1.lastName}\nContact Number = {c1.contactNumber}\nEmail Id = {c1.emailId}\n");

Customer c2 = new Customer();   // this is an object of customer class //
c2.customerId = 1002;
c2.firstName = "Vikas";
c2.lastName = "More";
c2.contactNumber = "9798945451";
c2.emailId = "Vikas.More@hotmail.com";

c2.CustomerDetails(); // Data & Function binding together // 


//Console.WriteLine($"Customer Id = {c2.customerId}\nFirst Name = {c2.firstName}\nLast Name = {c2.lastName}\nContact Number = {c2.contactNumber}\nEmail Id = {c2.emailId}");


#endregion Objects of class 

//*** Object initializer syntax more easy ***//

Customer c3 = new Customer()
{
    customerId = 1003,
    firstName = "Amit",
    lastName = "Gore",
    contactNumber = "9798945447",
    emailId = "amit.gore@hotmail.com",
};
c3.CustomerDetails();

Console.ReadLine();