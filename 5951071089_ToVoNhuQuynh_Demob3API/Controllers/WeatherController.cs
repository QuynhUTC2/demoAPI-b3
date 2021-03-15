using _5951071089_ToVoNhuQuynh_Demob3API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5951071089_ToVoNhuQuynh_Demob3API.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: api/Weather
        public IEnumerable<WeatherInfor> Get()
        {
            var weatherInfList = new List<WeatherInfor>();
            for (int i = 0; i < 10; i++)
            {
                var InforWeather = new WeatherInfor
                {
                    Location = $"Location {i}",
                    Degree = $"{i + 36 - i * 0.2} độ C Tô Võ Như Quỳnh",
                    DateTime = DateTime.Now.ToUniversalTime()
                };
                weatherInfList.Add(InforWeather);
            }
            return weatherInfList;
        }

        // GET: api/Weather/5
        public WeatherInfor Get(int id)
        {
            return new WeatherInfor
            {
                Location = $"Location{id}",
                Degree = $"{id + 36 - id * 0.2} độ C Tô Võ Như Quỳnh",
                DateTime = DateTime.Now.ToUniversalTime()
            }; ;
        }
    }
}
