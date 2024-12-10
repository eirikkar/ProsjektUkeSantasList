public class Gryla
{
    private readonly Person _person;

    public Gryla(Person person)
    {
        _person = person;
    }

    public string EatPerson()
    {
        var people = Person.LoadJson();
        int percent = (people.Count * 10) / 100;
        Random random = new Random();
        for (int i = 0; i < percent; i++)
        {
            int index = random.Next(i);
            people.RemoveAt(index);
            return $"Gryla spiste {people[index].Name}";
        }
        return "Gryla spiste ingen";
    }
}
