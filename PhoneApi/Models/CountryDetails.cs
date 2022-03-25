using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PhoneApi.Models
{
    public class CountryDetails
    {
        [JsonIgnore]
        public long Id { get; set; }

        [JsonIgnore]
        public long CountryId { get; set; }

        public string Operator { get; set; }
        public string OperatorCode { get; set; }
        public Country Country { get; set; }


    }
}
