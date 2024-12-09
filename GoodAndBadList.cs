using System.Text.Json;
public class GoodAndBadList

{
    public List<string> GoodList { get; set; }
    public List<string> BadList { get; set; }

}
public class Person
{
   public string? Id { get; set; }
   public string? Name { get; set; }
   public bool? ToiletPaperOutward { get; set; }
   public bool? DonatesToCharity { get; set; }
   public bool? WashesHands { get; set; }
   public List<string>? MusicGenres { get; set; }
   public string? HomeAdress { get; set; }
   public string? CarModel { get; set; }




    public static List<Person> LoadJson()
    {
        var json = File.ReadAllText("randomPeople.json");
        return JsonSerializer.Deserialize<List<Person>>(json);
    }
}
