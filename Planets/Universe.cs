using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.IO;
using Universe;
using static Universe.PlanetsProvider;

namespace Planets
{
    public class Universe
    {
        public static void Main(string[] args)
        {

            SolarSystem solarSystem = createSolarSystem();


            SolarSystem solarSystemFromJson = solarSystemFromFile();


            string output = JsonConvert.SerializeObject(solarSystem);


            Console.WriteLine(output);

        }

        public static SolarSystem solarSystemFromFile()
        {
            SolarSystem solarSysX = new SolarSystem();

            string filePlanets = readFile("Planets.json");


            PlanetsProvider planetsProvider = JsonConvert.DeserializeObject<PlanetsProvider>(filePlanets);



            string fileSatelites = readFile("Satelites.json");

            return solarSysX;



        }

        public static string readFile(string file)
        {
            string informationRead = string.Empty;

            using (StreamReader r = new StreamReader("C:\\Users\\peina\\source\\repos\\anapeinado\\CsharpExcercises\\Planets\\" + file))
            {
                informationRead = r.ReadToEnd();
            }


            return informationRead;

        }

        public static SolarSystem createSolarSystem()
        {

            SolarSystem solarSysX = new SolarSystem();

            solarSysX.name = "The Solar System";
            solarSysX.starName = "The Sun";
            solarSysX.starAge = 4603000000000;
            solarSysX.planets = new List<Planet>();

            solarSysX.planets.Add(createPlanet());



            return solarSysX;


        }

        private static Planet createPlanet()
        {
            Planet PlanetX = new Planet();
            PlanetX.name = "The Earth";
            PlanetX.periodRotation = 1;
            PlanetX.periodTranslation = 365;
            PlanetX.mass = 5.972 * 10e-24;
            PlanetX.radius = 6371;
            PlanetX.distanceFromStar = 149597870;
            PlanetX.surface = 510072000;
            PlanetX.solarSystem = "The Solar System";
            PlanetX.moons = new List<Moon>();
            PlanetX.moons.Add(createMoon());
            return PlanetX;
        }

        private static Moon createMoon()
        {
            Moon moonX = new Moon();
            moonX.name = "The Moon";
            //moonX.surface = ‎37930000;
            moonX.radius = 1737;
            moonX.mass = 5.972 * 10e-22;

            return moonX;

        }
    }


}
