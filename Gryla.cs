public class Gryla
{
    private readonly Person _person;

    public Gryla(Person person)
    {
        _person = person;
    }

    public Person EatPerson()
    {
        var people = Person.LoadJson();
        int percent = (people.Count * 10) / 100;
        Random random = new Random();
        for (int i = 0; i < percent; i++) { }
        int index = random.Next(people.Count);
        var person = people[index];
        return person;
    }
}
