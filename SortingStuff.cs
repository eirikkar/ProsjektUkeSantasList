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
        GoodAndBadList goodAndBadList = new()
        {
            GoodList = new List<string> { "good kids" },
            BadList = new List<string> { "bad kids" }

        };
        //adding points to people.
        public void AddingPoints()
        {
            //found the path to the json then reads the json file
            string filePath = "randomPeople.json";
            string data = File.ReadAllText(filePath);

            //converts string to object
            List<Person> people = JsonSerializer.Deserialize<List<Person>>(data);
            int peoplePoints = 0;

            foreach (var person in people)
            {

                // toilet paper
                if (person.ToiletPaperOutward == true)
                {
                    peoplePoints += 10;
                }
                else
                {
                    peoplePoints -= 10;
                }

                // //donation
                // if (donation == true)
                // {
                //     peoplePoints += 30;
                // }
                // else
                // {
                //     peoplePoints -= 30;
                // }

                // //washes hands
                // if (washingHands == true)
                // {
                //     peoplePoints += 50;
                // }
                // else
                // {
                //     peoplePoints -= 50;
                // }

                // music genres
                // if (musicGenre.Contains("J-Pop")
                //     || musicGenre.Contains("Country")
                //     || musicGenre.Contains("Electric")
                // )
                // {
                //     peoplePoints += 20;
                // }
                // else
                // {
                //     peoplePoints -= 20;
                // }

                //homeadress
                // if (home.Contains("A")
                // || home.Contains("B"))
                // {
                //     peoplePoints += 20;
                // }
                // else
                // {
                //     peoplePoints -= 20;
                // }

                // if (car.Contains("Nissan") || car.Contains("Toyota") || car.Contains("Volvo"))
                // {
                //     peoplePoints += 30;
                // }
                // else
                // {
                //     peoplePoints -= 30;
                // }

                // person.Points = peoplePoints;
                // Console.WriteLine($"{person.Name}: {person.Points}");

                if (peoplePoints >= 10)
                {
                    goodAndBadList.BadList.Add(person.Name);
                }
                else
                {
                    goodAndBadList.GoodList.Add(person.Name);
                }

                Console.WriteLine("Good List: " + string.Join(", ", goodAndBadList.GoodList));
                Console.WriteLine("\n\nBad List: " + string.Join(", ", goodAndBadList.BadList));
            }

        }
    }
}
