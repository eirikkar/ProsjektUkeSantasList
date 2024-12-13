using ProsjektUkeSantasList.Ifs;

namespace ProsjektUkeSantasList
{
    public class SortingStuff
    {
        //calling the different classes from the ifs folder
        TrueFalse trueFalse = new();
        MusicGenres musicGenres = new();
        HomeAdress homeAdress = new();
        Cars cars = new();

        //adding points to people.
        public List<Person> AddingPoints(List<Person> people)
        {
            //loops through each person object in the json file
            //and assigns them points based on their variables
            foreach (var person in people)
            {

                // toilet paper
                trueFalse.ToiletPaper(person);

                //Donating to charity
                trueFalse.Donating(person);

                //washes hands
                trueFalse.Washing(person);

                //music genres
                musicGenres.judgingMusic(person);

                //homeadress
                homeAdress.StalkingUwU(person);

                //car model
                cars.shittyOrCoolCar(person);
            }
            return people;
        }

        //decides if a person in the json file should go on the good list
        //or bad list based on their points
        public void SortPeople(List<Person> people, GoodAndBadList goodAndBadList)
        {
            foreach (var person in people)
            {
                if (person.Points < 0)
                {
                    goodAndBadList.BadList.Add(person);
                }
                else
                {
                    goodAndBadList.GoodList.Add(person);
                }
            }
        }

        //assigns an elf randomly to a child.
    }
}
