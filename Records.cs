using System;

public class Records
{
    public static void Run()
    {
        // Instantiating records
        var person = new Person("Alice", 30);
        var employee = new Employee("Bob", 35) { Department = "Finance" };
        var manager = new Manager("Carol", 40, "HR");

        // 5. Deconstructing records
        var (name, age) = person;
        Console.WriteLine($"Name: {name}, Age: {age}");

        // 6. With-expressions
        var updatedPerson = person with { Age = 31 };
        Console.WriteLine(updatedPerson);

        // Record struct usage
        var point = new Point(5, 10);
        Console.WriteLine(point);
    }

    // 1. Simple record
    public record Person(string Name, int Age);

    // 2. Record with parameterized constructor and init properties
    public record Employee(string Name, int Age)
    {
        public string Department { get; init; }
    }

    // 3. Inheritance in records
    public record Manager(string Name, int Age, string Department) : Employee(Name, Age);

    // 4. Record struct (C# 10.0)
    public record struct Point(int X, int Y);
}