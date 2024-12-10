namespace ProsjektUkeSantasList;

class Program
{
    static void Main(string[] args)
    {
        Person person = new();
        var people = Person.LoadJson();
        Gryla gryla = new(person);
        gryla.EatPerson();

        SortingStuff sortingStuff = new();

        sortingStuff.AddingPoints();



    }
}
