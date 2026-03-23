public class Student
{
    public string FirstName;
    public string LastName;

    public Student(string FirstName,string LastName)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
    }

    public void  PrintFullName()
    {
        Console.WriteLine($"Your Full Name is : {FirstName} {LastName}");
    }
}
