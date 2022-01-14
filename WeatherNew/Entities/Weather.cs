using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherNew.Entities
{
   public class Weather
    {/// <summary>
    /// уникальный идентификатор
    /// </summary>
        private Guid id;

        public Guid GetId()
        {
            return id;
        }

        public void SetId()
        {
            id = new Guid();
        }
/// <summary>
/// время снятия данных
/// </summary>
        public DateTime dateTime;

        public DateTime GetDateTime()
        {
            return dateTime;
        }

        public void SetDateTime()
        {
            dateTime = DateTime.Now;
        }
/// <summary>
/// температура
/// </summary>
        private double temperature;

        public double GetTemperature()
        {
            return temperature;
        }

        public void SetTemperature(double value)
        {
            temperature = value;
        }
/// <summary>
/// скорость ветра
/// </summary>
        private int windSpeed;

        public int GetWindSpeed()
        {
            return windSpeed;
        }

        public void SetWindSpeed(int value)
        {
            windSpeed = value;
        }
        /// <summary>
        /// атмосферное давление 
        /// </summary>
        private int pressure;

        public int GetPressure()
        {
            return pressure;
        }

        public void SetPressure(int value)
        {
            pressure = value;
        }
        public string Print()
        {
            return $"{temperature} C\n"+$"{pressure} units of mercury column\n" +$"{windSpeed}  m/c";
        }
    }
}
