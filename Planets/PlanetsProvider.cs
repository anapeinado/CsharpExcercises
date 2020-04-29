using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Universe
{



    public class PlanetsProvider
    {

        public List<PlanetProvider> planetProviders { get; set; }

    }

    public class PlanetProvider
    {


        //Mass(10^24kg)
        //Diameter(km)
        //Density(kg/m3)
        //Gravity(m/s2)
        //Escape Velocity(km/s)
        //Rotation Period(hours)
        //Length of Day(hours)
        //Distance from Sun(106 km)
        //Perihelion(106 km)
        //Aphelion(106 km)
        //Orbital Period(days)
        //Orbital Velocity(km/s)
        //Orbital Inclination(degrees)
        //Orbital Eccentricity
        //Obliquity to Orbit(degrees)
        //Mean Temperature(C)
        //Surface Pressure(bars)
        //Number of Moons(number)
        //Ring System? (Yes/No)
        //Global Magnetic Field? (Yes/No)

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("mass")]
        public double mass { get; set; }

        [JsonProperty("diameter")]
        public double diameter { get; set; }

        [JsonProperty("density")]
        public double density { get; set; }

        [JsonProperty("gravity")]
        public double gravity { get; set; }

        [JsonProperty("escapeVelocity")]
        public double escapeVelocity { get; set; }

        [JsonProperty("rotationPeriod")]
        public double rotationPeriod { get; set; }

        [JsonProperty("lengthOfDay")]
        public double lengthOfDay { get; set; }

        [JsonProperty("distanceFromSun")]
        public double distanceFromSun { get; set; }

        [JsonProperty("perihelion")]
        public double perihelion { get; set; }

        [JsonProperty("aphelion")]
        public double aphelion { get; set; }

        [JsonProperty("orbitalPeriod")]
        public double orbitalPeriod { get; set; }

        [JsonProperty("orbitalVelocity")]
        public double orbitalVelocity { get; set; }

        [JsonProperty("orbitalInclination")]
        public double orbitalInclination { get; set; }

        [JsonProperty("orbitalEccentricity")]
        public double orbitalEccentricity { get; set; }

        [JsonProperty("obliquityToOrbit")]
        public double obliquityToOrbit { get; set; }

        [JsonProperty("meanTemperature")]
        public double meanTemperature { get; set; }

        [JsonProperty("surfacePressure")]
        public double? surfacePressure { get; set; }

        [JsonProperty("numberOfMoons")]
        public int numberOfMoons { get; set; }

        [JsonProperty("hasRingSystem")]
        public bool hasRingSystem { get; set; }

        [JsonProperty("hasGlobalMagneticField")]
        public bool hasGlobalMagneticField { get; set; }
    }




}
