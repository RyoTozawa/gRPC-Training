using System;

namespace WeatherApi.Infrastructure.Persistence.Model.DB
{
    public class User
    {

        public String Id { get; set; }
        public String CityName { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public String AccessToken { get; set; }
    }
}