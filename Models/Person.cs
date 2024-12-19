using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
/// Person class
/// </summary>
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

    public int Points { get; set; }

    /// <summary>
    /// LoadJson method that takes randomPeople.json and deserializes it into a list of Person objects.
    /// </summary>
    /// <returns>List of persons</returns>
    /// <exception cref="Exception"></exception>
    public List<Person> LoadJson()
    {
        var json = File.ReadAllText("randomPeople.json");

        var people = JsonSerializer.Deserialize<List<Person>>(json);
        if (people == null)
        {
            throw new Exception("Fail");
        }
        return people;
    }
}
