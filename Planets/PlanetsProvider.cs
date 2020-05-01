using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Universe
{

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

        public int id { get; set; }
        public string name { get; set; }
        public double mass { get; set; }
        public double diameter { get; set; }
        public double density { get; set; }
        public double gravity { get; set; }
        public double escapeVelocity { get; set; }
        public double rotationPeriod { get; set; }
        public double lengthOfDay { get; set; }
        public double distanceFromSun { get; set; }
        public double perihelion { get; set; }
        public double aphelion { get; set; }
        public double orbitalPeriod { get; set; }
        public double orbitalVelocity { get; set; }
        public double orbitalInclination { get; set; }
        public double orbitalEccentricity { get; set; }
        public double obliquityToOrbit { get; set; }
        public double meanTemperature { get; set; }
        public double? surfacePressure { get; set; }
        public int numberOfMoons { get; set; }
        public bool hasRingSystem { get; set; }
        public bool hasGlobalMagneticField { get; set; }
    }




}
