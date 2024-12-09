namespace ProsjektUkeSantasList;

class Program
{
    static void Main(string[] args)
    {
        Person person = new();
        List<Person> people = Person.LoadJson();

        foreach (var p in people)
        {
            Console.WriteLine(p.Name);
        }  

    }
}
