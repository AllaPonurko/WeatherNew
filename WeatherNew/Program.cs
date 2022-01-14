using System;
using WeatherNew.DataCollection;
using WeatherNew.Entities;
using static System.Console;
namespace WeatherNew
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Weather weather1 = new Weather();
            weather1.SetDateTime(); 
            weather1.SetTemperature(-6.3);
            weather1.SetPressure(754);
            weather1.SetWindSpeed(6);
            Weather weather2 = new Weather();
            weather2.SetDateTime();
            weather2.SetTemperature(0);
            weather2.SetPressure(760);
            weather2.SetWindSpeed(4);
            Weather weather3 = new Weather();
            weather3.SetDateTime();
            weather3.SetTemperature(2.1);
            weather3.SetPressure(756);
            weather3.SetWindSpeed(2);
            Weather weather4 = new Weather();
            weather4.SetDateTime();
            weather4.SetTemperature(-12.8);
            weather4.SetPressure(763);
            weather4.SetWindSpeed(12);
            WriteLine(weather1.GetDateTime()+"\n"+weather1.Print());
            XmlSerializerWeather xml = new XmlSerializerWeather();
            xml.AddDictionary(weather1);
            xml.AddDictionary(weather2);
            xml.AddDictionary(weather3);
            xml.AddDictionary(weather4);
            foreach (var item in xml.dictionary)
                WriteLine(item.ToString());
            

        }
    }
}
