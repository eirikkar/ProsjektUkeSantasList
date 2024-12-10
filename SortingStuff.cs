using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProsjektUkeSantasList
{
    public class SortingStuff
    {
        Person person = new Person();
        public GoodAndBadList goodAndBadList =
            new() { BadList = new List<Person>(), GoodList = new List<Person>() };

        //adding points to people.
        public void AddingPoints()
        {
            //varible to call the readjson function from model class
            var people = Person.LoadJson();

            //loops through each person object in the json file
            //and assigns them points based on their variables
            foreach (var person in people.ToList())
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
                if (person.MusicGenres.Contains("J-pop") || person.MusicGenres.Contains("Folk") || person.MusicGenres.Contains("Blues"))
                {
                    peoplePoints += 50;
                }
                else
                {
                    peoplePoints -= 50;
                }

                //homeadress 
                if (person.HomeAdress.Contains("A") || person.HomeAdress.Contains("74") || person.HomeAdress.Contains("B"))
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
                        peoplePoints += 20;
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
                // Console.WriteLine($"{person.Name}: {person.Points}");
            }

            //decides if the people in the json file should go on the good list
            //or bad list based on their points
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

            Console.WriteLine("\nBadlist:");
            //prints ever child in the bad list
            foreach (var i in goodAndBadList.BadList)
            {
                Console.WriteLine($"{i.Name}: {i.Points}");
            }

            Console.WriteLine("\n\nGoodList:");
            //prints every child in the good list
            foreach (var b in goodAndBadList.GoodList)
            {
                Console.WriteLine($"{b.Name}: {b.Points}");
            }
        }
    }
}
