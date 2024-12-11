public class Gryla
{
    /// <summary>
    /// Gryla spise, nam nam nam nam
    /// </summary>
    /// <param name="badpeople"></param>
    public void Consequence(List<Person> badpeople)
    {
        Console.WriteLine("\nBadlist:");

        //prints every person in the bad list
        foreach (var i in badpeople)
        {
            Console.WriteLine($"{i.Name}: You got a total of {i.Points} points so you get coal");
        }

        Console.WriteLine("\nGryla needs her yearly sacrefice so she ate:");
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
        Console.WriteLine("from the bad list");
    }
}
