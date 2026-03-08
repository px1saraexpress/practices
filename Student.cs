using System.Diagnostics;
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

    public static void Print()
    {
        Console.WriteLine("static Print method called");
    }


}

//////********************/////

public static class India
{
    public static string Capital = " Delhi";
}

public class circle
{
    public int Radius;
    public static float Pi = 3.14f;

    public void Area()
    {
        Console.WriteLine($"Area of circle is = {Radius * Radius * Pi } cm");
    }
}



