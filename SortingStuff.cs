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

        //adding points to people.
        public void AddingPoints()
        {

            //variables
            int peoplePoints = 0;
            string BadList = "badList";
            string GoodList = "goodList";

            //found the path to the json then reads the json file
            string filePath = "randomPeople.json";
            string data = File.ReadAllText(filePath);

            //converts string to object
            List<Person> people = JsonSerializer.Deserialize<List<Person>>(data);

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

                person.Points = peoplePoints;
            }


            {

            }
            if (person.Points >= 10)
            {
                Console.WriteLine($"{BadList}:\n{person.Name}: {person.Points}");
            }
            else
            {
                Console.WriteLine($"\n{GoodList}:\n{person.Name}: {person.Points}");

            }
        }
    }
}
