namespace ProsjektUkeSantasList.Ifs
{
    public class Cars
    {
        public void shittyOrCoolCar(Person person)
        {
            if (person.CarModel == null)
            {
                throw new Exception("error matee");
            }
            else
            {
                if (
                    person.CarModel.Contains("Toyota")
                    || person.CarModel.Contains("Jaguar")
                    || person.CarModel.Contains("Volkswagen")
                )
                {
                    person.Points += 45;
                }
                if (person.CarModel.Contains("BMW") || person.CarModel.Contains("Tesla"))
                {
                    person.Points -= 50;
                }
                else
                {
                    person.Points += 40;
                }
            }
        }
    }
}
