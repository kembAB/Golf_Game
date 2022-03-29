//using System;
//using System.Collections.Generic;
//namespace Golf_Game
//{
//    public class SwingTriesTowinOrLose
//    {

//        //used to keep track of the number of swings doen 
//        private int NumberOfSwingsincrementer;
//        // is the game over or aborted true or false
//        bool isthegameover { get; set; }
//        // has the player lost game 
//        bool failure { get; set; }
//        //has the player succeded finding the hole
//        bool success { get; set; }
//        // maximum allowe tries before game over 
//        public int maxAllowedSwings { get; set; }
//        //swings taken so far 
//        private List<SwingValidatorCalculator> Swings { get; set; }
//        //remaining allowed valid distance left 
//        public double DistanceLeft { get; set; }
//        // the distance between the initial point to the hole 
//        public double CourseLength { get; set; }
//        // public List<SwingValidatorCalculator> Swingtries { get; set; }

//        //too far so game over 
//        public bool Toofar { get; set; }
//        public int NumberOfSwingsIncrementer
//        {
//            get { return NumberOfSwingsincrementer; }
//            set
//            {
//                if (value >= this.maxAllowedSwings)

//                {
//                    isthegameover = true;
//                    failure = true;
//                }

//                NumberOfSwingsincrementer = value;
//            }


//        }
//        public double maxlegaldistancefromhole { get; set; }


//        // covered distance sofar 
//        public double DistanceSoFar
//        {
//            //SwingValidatorCalculator=swing and SwingTriesTowinOrLose=course 
//            get
//            {
//                double totalDistance = 0;
//                foreach (SwingValidatorCalculator swing in Swings)
//                {
//                    totalDistance += swing.Distance;
//                }
//                return totalDistance;
//            }
//        }
//        // distance from the hole 

//        public double DistanceFromHole
//        {
//            get
//            {
//                double distanceFromHole = CourseLength;
//                foreach (SwingValidatorCalculator swing in Swings)
//                {
//                    distanceFromHole = Math.Abs(distanceFromHole - swing.Distance);
//                }
//                return distanceFromHole;
//            }
//        }

//        //constructors
//        public SwingTriesTowinOrLose()
//        {
//            this.Swings = new List<SwingValidatorCalculator>();
//        }

//        public SwingTriesTowinOrLose(int maxAllowedSwings) : this()
//        {
//            this.maxAllowedSwings = maxAllowedSwings;
//        }

//        public SwingTriesTowinOrLose(int maxAllowedSwings = 10, double CourseLength = 900) : this(maxAllowedSwings)
//        {
//            this.maxAllowedSwings = maxAllowedSwings;
//            this.CourseLength = CourseLength;
//            //this.mininumlegaldistance = mininumlegaldistance;
//        }
//        public SwingTriesTowinOrLose(double CourseLength, int maxAllowedSwings = 10, double maxlegaldistancefromhole = 900 ) : this(maxAllowedSwings, maxlegaldistancefromhole)
//        {
//            //this.maxAllowedSwings = maxAllowedSwings;
//            this.CourseLength = CourseLength;
//            this.maxlegaldistancefromhole = maxlegaldistancefromhole;
//        }

//        // ---------------------

//        public void SwingValidatorCalculator(double angle, double velocity)
//        {
//            SwingValidatorCalculator vc = new SwingValidatorCalculator(angle, velocity);
//            Swings.Add(vc);
//            NumberOfSwingsincrementer++;
//            if (this.DistanceFromHole == vc.Distance)
//            {
//                if (NumberOfSwingsincrementer == 1)
//                    isthegameover = true;
//                success = true;
//            }
//            else if
//                   (this.DistanceFromHole < 0)
//            {
//                // get{ DistanceFromHole = Math.Abs(DistanceFromHole); }

//                this.Toofar = true;
//                this.isthegameover = true;
//                this.failure = true;
//            }
//            else if (this.DistanceFromHole > 0)
//            {
//                DistanceLeft = DistanceFromHole;


//            }
//            if (NumberOfSwingsincrementer >= maxAllowedSwings)
//                this.isthegameover = true;
//        }
//    }
//}