namespace ProsjektUkeSantasList;

class Program
{
    static void Main(string[] args)
    {
        Person person = new();
        var people = Person.LoadJson();

        foreach (var persons in people)
        {
            Console.WriteLine(persons.Name);
        }
    }
}
