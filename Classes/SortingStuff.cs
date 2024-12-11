namespace ProsjektUkeSantasList
{
    public class SortingStuff
    {
        //impliments other classes needed to make the logic work

        //adding points to people.
        public List<Person> AddingPoints(List<Person> people)
        {
            //loops through each person object in the json file
            //and assigns them points based on their variables
            foreach (var person in people)
            {
                int peoplePoints = 0;

                // toilet paper
                if (person.ToiletPaperOutward == true)
                {
                    peoplePoints += 10;
                }
                else
                {
                    peoplePoints -= 10;
                }

                //Donating to charity
                if (person.DonatesToCharity == true)
                {
                    peoplePoints += 50;
                }
                else
                {
                    peoplePoints -= 50;
                }

                //washes hands
                if (person.WashesHands == true)
                {
                    peoplePoints += 20;
                }
                else
                {
                    peoplePoints -= 20;
                }

                //music genres
                if (person.MusicGenres == null)
                {
                    throw new Exception("Error music genre is null");
                }
                if (
                    person.MusicGenres.Contains("J-pop")
                    || person.MusicGenres.Contains("Folk")
                    || person.MusicGenres.Contains("Blues")
                )
                {
                    peoplePoints += 50;
                }
                else
                {
                    peoplePoints -= 50;
                }

                //homeadress
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
                    peoplePoints += 15;
                }
                else
                {
                    peoplePoints -= 15;
                }

                //car model
                switch (person.CarModel)
                {
                    case "Toyota":
                        peoplePoints += 25;
                        break;

                    //sosse bil
                    case "BMW":
                        peoplePoints -= -50;
                        break;

                    case "Tesla":
                        peoplePoints -= 50;
                        break;

                    default:
                        peoplePoints += 20;
                        break;
                }
                person.Points = peoplePoints;
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
