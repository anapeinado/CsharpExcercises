using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    public class Planet : CelestialBody
    {
        public decimal radius;
        public List<Moon> moons;
        public string solarSystem;
        public int periodRotation;
        public int periodTranslation;
        public double distanceFromStar;
        

    }
}
