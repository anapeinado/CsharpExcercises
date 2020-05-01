using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.IO;
using System.Numerics;
using Universe;


namespace Planets
{
    public class Universe
    {
        public static void Main(string[] args)
        {

            SolarSystem solarSystem = createSolarSystem();


            SolarSystem solarSystemFromJson = solarSystemFromFile();


            string output = JsonConvert.SerializeObject(solarSystemFromJson);


            Console.WriteLine(output);

        }

        public static SolarSystem solarSystemFromFile()
        {
            SolarSystem solarSysX = new SolarSystem();

            string filePlanets = readFile("Planets.json");


            List<PlanetProvider> planetsProvider = JsonConvert.DeserializeObject<List<PlanetProvider>>(filePlanets);



            string fileSatelites = readFile("Satelites.json");

            List<SatelitesProvider> satelitesProvider = JsonConvert.DeserializeObject<List<SatelitesProvider>>(fileSatelites);



            solarSysX = convertProviderToSolarSys(planetsProvider, satelitesProvider);




            return solarSysX;



        }

        private static SolarSystem convertProviderToSolarSys(List<PlanetProvider> planetsProvider, List<SatelitesProvider> satelitesProvider)
        {

            SolarSystem solarSystem = new SolarSystem();
            solarSystem.planets = new List<Planet>();
            Dictionary<int, Planet> planetDic = new Dictionary<int, Planet>();

            foreach (var planetProvider in planetsProvider)
            {
                Planet PlanetX = new Planet();
                PlanetX.name = planetProvider.name;
                PlanetX.periodRotation = planetProvider.rotationPeriod;
                PlanetX.periodTranslation = planetProvider.orbitalPeriod;
                PlanetX.mass = planetProvider.mass;
                PlanetX.radius = planetProvider.diameter / 2;
                PlanetX.distanceFromStar = planetProvider.distanceFromSun;
                PlanetX.surface = 4 * Math.PI * Math.Pow(planetProvider.diameter / 2, 2);
                PlanetX.solarSystem = "The Solar System";
                PlanetX.moons = new List<Moon>();

                planetDic.Add(planetProvider.id, PlanetX);
            }



            foreach (var satelite in satelitesProvider)
            {
                if (planetDic.ContainsKey(satelite.planetId))
                {
                    Moon sateliteX = new Moon();
                    sateliteX.name = satelite.name;
                    sateliteX.radius = satelite.radius;
                    sateliteX.surface = 4 * Math.PI * Math.Pow(satelite.radius, 2);

                    planetDic[satelite.planetId].moons.Add(sateliteX);
                }


            }

            foreach (var planet in planetDic)
            {
                solarSystem.planets.Add(planet.Value);
            }

            return solarSystem;
        }

        public static string readFile(string file)
        {
            string informationRead = string.Empty;

            using (StreamReader r = new StreamReader(Directory.GetCurrentDirectory() + "..\\..\\..\\..\\" + file))
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
