using System.Globalization;

class Student // Class 
{
    public int RollNumber; // class field
    public string Name;    // class field
    public string Gender;  // class field
    public string email;   // class field
    public int contact;
    public static string TrainerName = "vikul";

    public void Details()  // Method
    {
        Console.WriteLine
            (
            $"RollNumber : {RollNumber}\n" + 
            $"Name : {Name} \n" + 
            $"Gender: {Gender} \n" + 
            $"email : {email}\n" + 
            $"contact : {contact}\n"+
            $"TrainerName : {TrainerName}\n"
            );
    }

}
