using _5951071089_ToVoNhuQuynh_Demob3API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5951071089_ToVoNhuQuynh_Demob3API.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Weather
        public IEnumerable<StudentInfor> Get()
        {
            var weatherInfList = new List<StudentInfor>();
            for (int i = 0; i < 10; i++)
            {
                var StudentInfor = new StudentInfor
                {
                    Fullname = $"To Vo Nhu Quynh {i}",
                    birth = $"02/10/2000",
                    PhoneNumber = i+10,
                    Class = $"CQ.59.CNTT",
                    dateTime = DateTime.Now.ToUniversalTime()
                };
                weatherInfList.Add(StudentInfor);
            }
            return weatherInfList;
        }

        // GET: api/Weather/5
        public StudentInfor Get(int id)
        {
            return new StudentInfor
            {
                Fullname = $"To Vo Nhu Quynh {id}",
                birth = $"02/10/2000",
                PhoneNumber = id + 10,
                Class = $"CQ.59.CNTT",
                dateTime = DateTime.Now.ToUniversalTime()
            }; ;
        }
    }

   
}
