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
    public string? Name { get; set; }

    public string? Spesialisering { get; set; }

    public string? Ansvar { get; set; }
}
