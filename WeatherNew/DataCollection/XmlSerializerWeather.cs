using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WeatherNew.Entities;

namespace WeatherNew.DataCollection
{
    public class XmlSerializerWeather:XmlDictionary
    {
        public XmlDictionary<DateTime,Weather> dictionary;
        public void AddDictionary(Weather weather)
        {
            if (dictionary == null)
                dictionary = new XmlDictionary<DateTime, Weather>();
            dictionary.Add(weather.GetDateTime(), weather);
        }
        public override string ToString()
        {
            return $"{dictionary.Keys}\n"+$"{dictionary.Values}";
        }
    }
}
