// Askasleikir spesialisering fot Elektronikk, ansvar for kjøpe online
// Pottasleikir spesialisering for keramikk, ansvar for at gavenne ser bra ut med sloife
// Bankerinie spesialisering for søm, ansvar at skjærebrett julegaver
// Sledda, spesialisering for trearbeid, ansvar at sleden virker bra
// Smieknuser spesialisering for smie, ansvar for reinsdyrene

using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
/// Alvene class
/// </summary>
public class Alvene
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }


    [JsonPropertyName("spesialisering")]
    public string? Spesialisering { get; set; }

    [JsonPropertyName("ansvar")]
    public string? Ansvar { get; set; }

  
    /// <summary>
    /// LoadJson method that takes randomPeople.json and deserializes it into a list of Alvene objects.
    /// </summary>
    /// <returns>List of Alvene</returns>
    /// <exception cref="Exception"></exception>
    public static List<Alvene> LoadJson()
    {
        var json = File.ReadAllText("C:\\Users\.json");

        var people = JsonSerializer.Deserialize<List<Alvene>>(json);
        if (people == null)
        {
            throw new Exception("Fail");
        }
        return people;
    }
}
