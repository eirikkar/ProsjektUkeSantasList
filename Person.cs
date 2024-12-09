using System.Text.Json;
using System.Text.Json.Serialization;

public class Person
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("toiletPaperOutward")]
    public bool? ToiletPaperOutward { get; set; }

    [JsonPropertyName("donatesToCharity")]
    public bool? DonatesToCharity { get; set; }

    [JsonPropertyName("washesHands")]
    public bool? WashesHands { get; set; }

    [JsonPropertyName("musicGenres")]
    public List<string>? MusicGenres { get; set; }

    [JsonPropertyName("homeAdress")]
    public string? HomeAdress { get; set; }

    [JsonPropertyName("carModel")]
    public string? CarModel { get; set; }

    public static List<Person> LoadJson()
    {
        var json = File.ReadAllText("randomPeople.json");

        var people = JsonSerializer.Deserialize<List<Person>>(json);
        if (people == null)
        {
            throw new Exception("Fail");
        }
        Console.WriteLine(people.Count);
        return people;
    }
}
