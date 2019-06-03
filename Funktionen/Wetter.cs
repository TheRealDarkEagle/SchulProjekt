using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using OpenWeatherMap;
using SimonSpeechEngine;
using System.Windows.Forms;

namespace Simon.Klassen
{
    //Läd aus der API die Daten für das Wetter
    public static class Wetter
    {
        public static int temperatur = 0;
        public static int clouds = 0;

        private static readonly string weathercode = "d912e2792e6814cb36463f2b39ee4f66";

        //Ließt die Temperatur aus der API aus
        public static async void LoadTemp(string cityname)
        {
            try
            {
                OpenWeatherMapClient client = new OpenWeatherMapClient(weathercode);
                var currentWeather = await client.CurrentWeather.GetByName(cityname);
                temperatur = Convert.ToInt32(currentWeather.Temperature.Value - 273.15);
            }
            finally
            {
                Simon.WriteInLog("Temperatur geladen");
            }
        }

        //Ließt die Wolkendaten aus der API aus
        public static async void LoadClouds(string cityname)
        {
            try
            {
                OpenWeatherMapClient client = new OpenWeatherMapClient(weathercode);
                var currentWeather = await client.CurrentWeather.GetByName(cityname);
                clouds = currentWeather.Clouds.Value;
            }
            finally
            {
                Simon.WriteInLog("Wolcken geladen");
            }
        }
    }
}
