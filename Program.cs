
Student s1 = new Student();
s1.PrintFullName(); // Method call

Student s2 = new Student();
s2.firstName = "Amol";
s2.lastName = "Wagh";
s2.PrintFullName();

Student s3 = new Student()
{ firstName = "Amol",
  lastName = "Ningale"
};
s3.PrintFullName();

Console.ReadLine();