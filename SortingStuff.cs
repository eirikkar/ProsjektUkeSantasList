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
            var people = Person.LoadJson();
            int peoplePoints = 0;


            foreach (var person in people)
            {
                peoplePoints = 0;

                // toilet paper
                if (person.ToiletPaperOutward == true)
                {
                    peoplePoints += 10;
                }
                else
                {
                    peoplePoints -= 10;
                }

                person.Points = peoplePoints;
                Console.WriteLine($"{person.Name}: {person.Points}");
            }

            foreach (var person in people)
            {
                if (person.Points <= 10)
                {
                    Console.WriteLine($"\n{BadList}:\n{person.Name}: {person.Points}");
                }
                else
                {
                    Console.WriteLine($"\n{GoodList}:\n{person.Name}: {person.Points}");

                }

                Console.WriteLine($"{BadList}");
                Console.WriteLine($"{GoodList}");
            }


        }
    }
}
