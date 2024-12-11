class AssignElf
{
    public void AssignElfs(List<Person> goodList, List<Alvene> elfList)
    {
        Random random = new Random();
        Console.WriteLine("\n\nGoodList:");
        //prints every person in the good list
        foreach (var b in goodList)
        {
            int elf = random.Next(1, 6);
            if (elf == 1)
            {
                Console.WriteLine(
                    $"{b.Name}: you got {b.Points}: here is your gift: {elfList[0].Gift}"
                );
            }
            if (elf == 2)
            {
                Console.WriteLine(
                    $"{b.Name}: you got {b.Points}: here is your gift: {elfList[1].Gift}"
                );
            }
            if (elf == 3)
            {
                Console.WriteLine(
                    $"{b.Name}: you got {b.Points}: here is your gift: {elfList[2].Gift}"
                );
            }
            if (elf == 4)
            {
                Console.WriteLine(
                    $"{b.Name}: you got {b.Points}: here is your gift: {elfList[3].Gift}"
                );
            }
            if (elf == 5)
            {
                Console.WriteLine(
                    $"{b.Name}: you got {b.Points} here is your gift: {elfList[4].Gift}"
                );
            }
        }
    }
}
