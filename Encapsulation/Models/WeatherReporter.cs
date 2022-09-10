namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private readonly string Location;
        public double Temperature { get; private set; }
        private const double FahrenheitFraction = 9.0 / 5.0;
        private const int FahrenheitConstant = 32;
        private const int MinTemp = 10;
        private const int MaxTemp = 30;

        public WeatherReporter(string location, double temperature)
        {
            Location = location;
            Temperature = temperature;
        }

        public string PrintSummary()
        {
            double newTemp = FahrenheitFraction * Temperature + FahrenheitConstant;
            return $"I am in {Location} and it is {CheckLocationWeather()}. {CheckTemperatureScale()}. The temperature in Fahrenheit is {newTemp}.";
        }

        public string CheckLocationWeather()
        {
            if (Location == "London")
            {

                 // return "🌦";
                  return "raining";

            }
            else if (Location == "California")
            {

                //return "🌅";
                return "stormy";

            }
            else if (Location == "Cape Town")
            {

                //return "🌤";
                return "cloudy";

            }
            //return "🔆";
            return "sunny";
        }

        public string CheckTemperatureScale()
        {
            if (Temperature > MaxTemp)
            {

               // return "It's too hot 🥵!";
                return "It's too hot!";

            }
            else if (Temperature < MinTemp)
            {

                //return "It's too cold 🥶!";
                return "It's too cold!";

            }
            //return "Ahhh...it's just right 😊!";
            return "Ahhh...it's just right!";
        }

    }
}

