namespace ProsjektUkeSantasList;

class Program
{
    static void Main(string[] args)
    {
        //Instantiating classes
        Person person = new();
        Gryla gryla = new();
        AssignElf assignElf = new();
        ElfList elfList = new();
        SortingStuff sortingStuff = new();
        var goodAndBadList = new GoodAndBadList
        {
            BadList = new List<Person>(),
            GoodList = new List<Person>(),
        };

        //Calling LoadJson method as people
        var people = Person.LoadJson();

        //Main logic
        people = sortingStuff.AddingPoints(people);
        sortingStuff.SortPeople(people, goodAndBadList);
        assignElf.AssignElfs(goodAndBadList.GoodList, elfList.elfList);
        gryla.Consequence(goodAndBadList.BadList);
    }
}
