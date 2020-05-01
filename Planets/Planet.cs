using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    public class Planet : CelestialBody
    {
        public double radius;
        public List<Moon> moons;
        public string solarSystem;
        public double periodRotation;
        public double periodTranslation;
        public double distanceFromStar;
        

    }
}
