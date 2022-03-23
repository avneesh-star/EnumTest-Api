using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EnumTest.DTO
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CityEnum
    {
        Meerut,
        Nodia,
        Delhi,
        Lucknow,
        Kanpur
    }
}
