using System.Text.Json.Serialization;

namespace HomeFlow.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RentSale
    {
        Rent = 1,
        Sale = 2,

    }
}
