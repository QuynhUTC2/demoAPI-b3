using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _5951071089_ToVoNhuQuynh_Demob3API.Models
{


    [DataContract]
    public class WeatherInfor
    {
        [DataMember(Name = "location")]
        public string Location { get; set; }
        [DataMember(Name = "degree")]

        public int Degree { get; set; }
        [DataMember(Name = "dateTime")]

        public DateTime DateTime { get; set; }

    }
}