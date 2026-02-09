using System.Diagnostics.CodeAnalysis;
using Coordinate = (int x, int y);
var c = new Coordinate(20, 30);

var multiply = (int x = 0) => x * 2;
var divide = (int i = 1) => i / 2;
var result = multiply(5);

var person = new PersonOldStyle("Roland", "Guijt");
var p = new Person("Roland", "Guijt");

p.DoWork();

[Experimental("PersonFeature")]
public class PersonOldStyle
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [Experimental("PersonFeature")]
    public PersonOldStyle(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

public class Person(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;

    public void DoWork()
    {
        Console.WriteLine(FirstName);
        FirstName = "John";
        Console.WriteLine(FirstName);
    }
}

public class Employee(string firstName, string lastName, int salary)
    : Person(firstName, lastName)
{
    public int Salary { get; } = salary;

    public void GoToWork()
    {
        Console.WriteLine(FirstName);
    }
}

public struct Space(int x, int y)
{
    public int Area => x * y;
}

public record PersonRecord(string FirstName, string LastName)
{

}

