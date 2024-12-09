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
            BadList = new List<string>(),
            GoodList = new List<string>()

        };

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


            foreach (var person in person.Name)
            {
                if (person.Points <= 10)
                {
                    goodAndBadList.BadList.Add(person.Name);
                }
                else
                {
                    goodAndBadList.GoodList.Add(person.Name);

                }

            }
            foreach (var i in goodAndBadList.BadList)
            {
                Console.WriteLine($"\nBadList: {i}");
            }

            foreach (var b in goodAndBadList.GoodList)
            {
                Console.WriteLine($"\nGoodList {b}");
            }
            // Console.WriteLine($"\n{goodAndBadList.BadList}");
            // Console.WriteLine($"\n{goodAndBadList.GoodList}");


        }
    }
}
