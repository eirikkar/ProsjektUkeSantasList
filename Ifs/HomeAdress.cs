namespace ProsjektUkeSantasList.Ifs
{
    public class HomeAdress
    {
        public void StalkingUwU(Person person)
        {
            if (person.HomeAdress == null)
            {
                throw new Exception("Error Home adress is null");
            }
            if (
                person.HomeAdress.Contains("A")
                || person.HomeAdress.Contains("74")
                || person.HomeAdress.Contains("B")
            )
            {
                person.Points += 15;
            }
            else
            {
                person.Points -= 15;
            }
        }
    }
}
