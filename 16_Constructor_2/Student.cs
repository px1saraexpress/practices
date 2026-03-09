public class Student
{
    public Student()
    {
        Console.WriteLine("public student() constructor called");
    }

    public static string CourseName = "DotNet";
    static Student()
    {
        Console.WriteLine("static student() constructor called");
    }

}