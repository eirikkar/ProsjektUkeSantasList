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
        //impliments other classes needed to make the logic work
        Person person = new Person();
        Random random = new Random();
        Alvene alvene = new Alvene();

        public GoodAndBadList goodAndBadList =
            new() { BadList = new List<Person>(), GoodList = new List<Person>() };

        public AleveneList aleveneLista =
        new() { alvenes = new List<Alvene>() };

        public void elfList()
        {
            aleveneLista.alvenes.Add(new Alvene { Name = "Askasleikir", Spesialisering = "elektronik", Ansvar = "kjøpe online", Gift = "Flashbackinator" });
            aleveneLista.alvenes.Add(new Alvene { Name = "Pottasleikir", Spesialisering = "keramikk", Ansvar = "at gavenne ser bra ut med sloife", Gift = "Aincent greek pot" });
            aleveneLista.alvenes.Add(new Alvene { Name = "Bankerinie", Spesialisering = "søm", Ansvar = "at skjærebrett julegaver", Gift = "dragon leather robe" });
            aleveneLista.alvenes.Add(new Alvene { Name = "Sledda", Spesialisering = "trearbeid", Ansvar = "at sleden virker bra", Gift = "vikingskip" });
            aleveneLista.alvenes.Add(new Alvene { Name = "Smieknusser", Spesialisering = "smie", Ansvar = "for reinsdyrene", Gift = "neckalce that tells you the weather" });

        }


        //adding points to people.
        public void AddingPoints()
        {
            //varible to call the read json function from model class
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
                if (person.MusicGenres == null)
                {
                    throw new Exception("Error music genre is null");
                }
                if (person.MusicGenres.Contains("J-pop") || person.MusicGenres.Contains("Folk") || person.MusicGenres.Contains("Blues"))
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

            //decides if a person in the json file should go on the good list
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

            //assigns an elf randomly to a child.

            Console.WriteLine("\nBadlist:");

            //prints every person in the bad list
            foreach (var i in goodAndBadList.BadList)
            {
                Console.WriteLine($"{i.Name}: You got a total of {i.Points} points so you get coal");
            }

            Console.WriteLine("\n\nGoodList:");


            //prints every person in the good list
            foreach (var b in goodAndBadList.GoodList)
            {
                int elf = random.Next(0, 6);
                if (elf == 1)
                {
                    alvene.Name = "Askasleikir";
                    alvene.Spesialisering = "Elektronikk";
                    alvene.Gift = "Flashbackinatior";
                    Console.WriteLine($"{b.Name}: you got {b.Points}: here is your gift: {alvene.Gift}");
                }
                if (elf == 2)
                {
                    alvene.Name = "Pottasleikir";
                    alvene.Spesialisering = "keramikk";
                    alvene.Gift = "Aincent greek pot";
                    Console.WriteLine($"{b.Name}: you got {b.Points}: here is your gift: {alvene.Gift}");
                }
                if (elf == 3)
                {
                    alvene.Name = "Bankerinie";
                    alvene.Spesialisering = "søm";
                    alvene.Gift = "dragon leather robe";
                    Console.WriteLine($"{b.Name}: you got {b.Points}: here is your gift: {alvene.Gift}");
                }
                if (elf == 4)
                {
                    alvene.Name = "Sledda";
                    alvene.Spesialisering = "Trearbeid";
                    alvene.Gift = "TheXtremeSled200";
                    Console.WriteLine($"{b.Name}: you got {b.Points}: here is your gift: {alvene.Gift}");
                }
                if (elf == 5)
                {
                    alvene.Name = "Smieknuser";
                    alvene.Spesialisering = "smie";
                    alvene.Gift = "Necklace that tells the weather";
                    Console.WriteLine($"{b.Name}: you got {b.Points} here is your gift: {alvene.Gift}");
                }
            }
        }
    }
}
