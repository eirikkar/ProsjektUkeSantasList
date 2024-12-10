public class Gryla
{
    public void EatPerson(List<Person> badpeople)
    {
        badpeople = Person.LoadJson();
        int percent = (badpeople.Count * 10) / 100;
        Random random = new Random();
        for (int i = 0; i < percent; i++)
        {
            int index = random.Next(badpeople.Count);
            Console.WriteLine($"Gryla spiste {badpeople[index].Name}");
            badpeople.RemoveAt(index);
        }
    }
}
