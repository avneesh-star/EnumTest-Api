using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnumTest.DTO
{
    public class EmpDto
    {
        public string Name { get; set; }
        public GenderEnum Gender { get; set; }
        public CityEnum City { get; set; }
    }
}
