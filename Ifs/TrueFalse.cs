namespace ProsjektUkeSantasList.Ifs
{
    public class TrueFalse
    {
        public void ToiletPaper(Person person)
        {
            if (person.ToiletPaperOutward == true)
            {
                person.Points += 10;
            }
            else
            {
                person.Points -= 10;
            }
        }

        public void Donating(Person person)
        {
            if (person.DonatesToCharity == true)
            {
                person.Points += 50;
            }
            else
            {
                person.Points -= 50;
            }
        }

        public void Washing(Person person)
        {
            if (person.WashesHands == true)
            {
                person.Points += 20;
            }
            else
            {
                person.Points -= 20;
            }
        }
    }
}
