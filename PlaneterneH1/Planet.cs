using System;
using System.Collections.Generic;
using System.Text;

namespace PlaneterneH1
{
    class Planet
    {
        //Erklærer variabler (privat så man kan styre på hvilken måde man må få adgang til dem)
        private string name;
        private double mass;
        private int diameter;
        private int density;
        private double gravity;
        private double rotationPeriod;
        private double lengthOfDay;
        private double distanceFromSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private int meanTemp;
        private int numberOfMoons;
        private string ringSystem;

        //Bruger get&set properties til at definerer at man må kunne udskrive/se og sætte værdien
        #region getset
        public string Name { get { return name; } set { name = value; } }
        public double Mass { get { return mass; } set { mass = value; } }
        public int Diameter { get { return diameter; } set { diameter = value; } }
        public int Density { get { return density; } set { density = value; } }
        public double Gravity { get { return gravity; } set { gravity = value; } }
        public double RotationPeriod { get { return rotationPeriod; } set { rotationPeriod = value; } }
        public double LengthOfDay { get { return lengthOfDay; } set { lengthOfDay = value; } }
        public double DistanceFromSun { get { return distanceFromSun; } set { distanceFromSun = value; } }
        public double OrbitalPeriod { get { return orbitalPeriod; } set { orbitalPeriod = value; } }
        public double OrbitalVelocity { get { return orbitalVelocity; } set { orbitalVelocity = value; } }
        public int MeanTemp { get { return meanTemp; } set { meanTemp = value; } }
        public int NumberOfMoons { get { return numberOfMoons; } set { numberOfMoons = value; } }
        public string RingSystem { get { return ringSystem; } set { ringSystem = value; } }
        #endregion

        //Opretter konstruktøren med de egenskaber planeterne skal have
        public Planet(string name, double mass, int diameter, int density, double gravity, double rotationPeriod, double lengthOfDay, double distanceFromSun, double orbitalPeriod,
            double orbitalVelocity, int meanTemp, int numberOfMoons, string ringSystem)
        {
            this.name = name; //Definerer at name i klassen skal være = name fra konstruktøren
            this.mass = mass;
            this.diameter = diameter;
            this.density = density;
            this.gravity = gravity;
            this.rotationPeriod = rotationPeriod;
            this.lengthOfDay = lengthOfDay;
            this.distanceFromSun = distanceFromSun;
            this.orbitalPeriod = orbitalPeriod;
            this.orbitalVelocity = orbitalVelocity;
            this.meanTemp = meanTemp;
            this.numberOfMoons = numberOfMoons;
            this.ringSystem = ringSystem;

        }

    }


}