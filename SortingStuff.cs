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
                person.Points = peoplePoints;
                Console.WriteLine($"{person.Name}: {person.Points}");
            }


            //decides if the people in the json file should go on the good list
            //or bad list based on their points
            foreach (var person in people)
            {
                if (person.Points < 10)
                {
                    goodAndBadList.BadList.Add(person.Name);
                }
                else
                {
                    goodAndBadList.GoodList.Add(person.Name);

                }

            }

            //prints ever child in the bad list
            foreach (var i in goodAndBadList.BadList)
            {
                Console.WriteLine($"\nBadList: {i}");
            }


            //prints every child in the good list
            foreach (var b in goodAndBadList.GoodList)
            {
                Console.WriteLine($"\nGoodList {b}");
            }


        }
    }
}
