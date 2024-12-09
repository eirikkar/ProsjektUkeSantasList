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
        People people = new People();
        public void readJson()
        {
            //I want to create a point system to decide if they go to good or bad.
            //added people class
            // trying to read json file
            string filePath = "randomPeople.json";
            string readStuff = File.ReadAllText(filePath);
            Console.WriteLine(readStuff);

        }



        //adding points to people.
        public void AddingPoints()
        {
            //declaring varibles 
            var peoplePoints = 0;

            var toiletpaper = people.ToiletPaperOutward;
            var donation = people.DonatesToCharity;
            var washingHands = people.WashesHands;
            var musicGenre = people.MusicGenres;
            var home = people.HomeAdress;
            var car = people.CarModel;
            var name = people.Name;

            //toilet paper
            if (toiletpaper == true)
            {
                peoplePoints += 10;
            }
            else
            {
                peoplePoints -= 10;
            }

            //donation
            if (donation == true)
            {
                peoplePoints += 30;
            }
            else
            {
                peoplePoints -= 30;
            }

            //washes hands
            if (washingHands == true)
            {
                peoplePoints += 50;
            }
            else
            {
                peoplePoints -= 50;
            }

            // music genres
            if (musicGenre.Contains("Jpop") || musicGenre.Contains("Country") || musicGenre.Contains("Electric"))
            {
                peoplePoints += 20;
            }
            else
            {
                peoplePoints -= 20;
            }


            //homeadress 
            if (home.Contains("A") || home.Contains("B"))
            {
                peoplePoints += 20;
            }
            else
            {
                peoplePoints -= 20;
            }

            if (car.Contains("Nissan") || car.Contains("Toyota") || car.Contains("Volvo"))
            {
                peoplePoints += 30;
            }
            else
            {
                peoplePoints -= 30;
            }
        }

    }

}