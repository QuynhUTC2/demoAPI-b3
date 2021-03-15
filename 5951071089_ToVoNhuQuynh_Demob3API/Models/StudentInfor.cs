using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _5951071089_ToVoNhuQuynh_Demob3API.Models
{
    [DataContract]
    public class StudentInfor
    {
        [DataMember(Name = "fullname")]
        public string Fullname { get; set; }
        [DataMember(Name = "Birth")]
        public string birth { get; set; }
        [DataMember(Name = "Phone number")]
        
        public int PhoneNumber { get; set; }
        [DataMember(Name = "Class")]

        public string Class { get; set; }
        [DataMember(Name = "Daycheck")]

        public DateTime dateTime { get; set; }

    }
}