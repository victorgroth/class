class Program
{
    private static void Main(string[] args)
    {
        Person person1 = new();
        person1.age = 56;
        person1.name = "Gunnar";

        Person person2 = new() { age = 20, name = "Simon"};


        List<Person> people = [person1, person2];
        people.Add();

        foreach (var person in people)
        {
            Console.WriteLine(person.name + " is " + person.age);
        }

    }
}

class Person
{
    public string name;    
    public int age;
}