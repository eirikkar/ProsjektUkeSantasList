namespace ProsjektUkeSantasList;

class Program
{
    static void Main(string[] args)
    {
        //Instantiating classes
        Person person = new();
        Gryla gryla = new();
        //Calling LoadJson method as people
        var people = Person.LoadJson();
        //Calling EatPerson method with people as parameter
        gryla.EatPerson(people);
    }
}
