class Customer  // class name //
{

    // these are the class fields //
    
    public static string discount = "10%";
    public int customerId;                        
    public string firstName;                       
    public string lastName;                        
    public string contactNumber;                   
    public string emailId;
    

    // class methods
    public void CustomerDetails()
    {
        Console.WriteLine($"Applicable Discount = {discount}\nCustomer Id = {customerId}\nFirst Name = {firstName}\nLast Name = {lastName}\n" +
            $"Contact Number = {contactNumber}\nEmail Id = {emailId}\n");
    
    }
}
