public class Student 
{
    public string firstName;
    public string lastName;

    // Constructor //
    public Student()
    {
        Console.WriteLine("Student () constructor called.");
    }

    public void PrintFullName()
    {
        Console.WriteLine($"Full Name = {firstName} {lastName}\a");
    }

}
