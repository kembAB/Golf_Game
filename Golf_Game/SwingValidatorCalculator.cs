//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Golf_Game
//{
//    class SwingValidatorCalculator
//    {
//        //property for the whole journey until lose or win 

//       // public SwingTriesTowinOrLose SwingLength { get; set; }

//        // constant gravity variable
//        public const double GRAVITY = 9.8;
//        public double angle { get; set; }
//        public double velocity { get; set; }
//        public double AngleInRadians
//        {
//            get
//            {
//                return (Math.PI / 180) * this.angle;
//            }
//        }
//        public double Distance
//        {
//            get
//            {
//                return Math.Pow(this.velocity, 2) / GRAVITY *
//                    Math.Sin(2 * this.AngleInRadians);
//            }
//        }
//        public SwingValidatorCalculator(double angle, double velocity)
//        {


//            if (velocity <= 0)
//            {
//                this.velocity = 0;
//            }
//            else
//            {
//                this.velocity = velocity;
//            }

         
//            this.angle = angle;
//            //this.SwingLength = SwingLength;
//        }
//        //public SwingValidatorCalculator(double angle, double velocity, SwingTriesTowinOrLose SwingLength)
//        //{

//        //}
//    }
//}
