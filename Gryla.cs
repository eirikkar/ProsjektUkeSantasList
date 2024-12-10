public class Gryla
{
    /// <summary>
    /// Gryla spise, nam nam nam nam
    /// </summary>
    /// <param name="badpeople"></param>
    public void EatPerson(List<Person> badpeople)
    {
        Console.WriteLine("\nGryla ate:");
        // Create a new random object
        Random random = new Random();
        // Loop over the badlist and delete a random person if the number is 10
        for (int i = 0; i < badpeople.Count; i++)
        {
            int eat = random.Next(1, 11);
            if (eat == 10)
            {
                Console.WriteLine($"{badpeople[i].Name}");
                badpeople.RemoveAt(i);
            }
        }
    }
}
