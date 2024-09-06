namespace Ex3_SimplePerson;

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        this.Name = name;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hi, I am {Name}");
    }
}