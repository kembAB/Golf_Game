using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// editing from forking repo
namespace Golf_Game
{

    class program
    {
        /*
          Algrotitms
          • Angle In Radians: (Math.PI / 180) * angle
          • Distance: Math.Pow(velocity, 2) / GRAVITY* Math.Sin(2 * angleInRadians)
          • Gravity is equal to 9.8
           • Example: At 45 Degrees and 56 m/s, the ball should travel 320 meters. 
        
         */


        static void Main(string[] args)
        {

            Random rnd = new Random();
            // course size 
            double randomlength = rnd.Next(200, 800);
            int maxAllowedSwings = (int)(randomlength / 100) + 1;
         

            //distances
            double courselength = randomlength;
            double distanceTohole = courselength;

            //the maxmimu length allowed to be away from the cup before prononced too far < courselength*1.5
            double toofar = courselength * 1.5;

            //swings counter 
            int NumberOfSwingsincrementer = 0;

           
            double angle = 0;
            double velocity = 0;

            //swing tracker list 
            List<int> lstswings = new List<int>();


            // mid to end game reporting list 
            List<string> lstGameReport = new List<string>();

           

            Console.WriteLine("The course is " + distanceTohole + " meters long.");
            Console.WriteLine("The max amount of swing tries   " + maxAllowedSwings);
            Console.WriteLine();

            bool Golfisplayed = true;
            while (Golfisplayed)
            {
                bool invalid = false;
                while (!invalid)
                {
                    Console.WriteLine("pleae submit  angle");
                    angle = Convert.ToDouble(Console.ReadLine());
                    if (angle >= 90 || angle <= 0)
                    {

                        Console.WriteLine("invalid, keep the angle between 0 and 90 degrees");
                    }
                    else
                    {
                        //if the right angle is entered break out of the loop 
                        invalid = true;
                    }


                }


                Console.WriteLine("Input velocity");
                velocity = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("angle: " + angle);
                Console.WriteLine("velocity: " + velocity);
              
                SwingValidatorCalculator svc = new SwingValidatorCalculator(angle: angle, velocity: velocity);

                
               //calculate the angle 
                double angleInRadians = svc.AngleInRadians;
                // calculate the swing distance 
                double distanceofswing = svc.Distance;
                
                //distanceofswing :distance so far 
                Console.WriteLine("Distance so far : " + distanceofswing);

              //  landings.Add(distanceofswing);
                NumberOfSwingsincrementer++;
                
                lstGameReport.Add("Swing number: " + NumberOfSwingsincrementer + " Distance Traveled " + distanceofswing);
                
                lstswings.Add(NumberOfSwingsincrementer);
               
                //updating the distance to the cup after swing 
                distanceTohole = distanceTohole - distanceofswing;
                
                //if sucess at the first try 
                if (distanceTohole == 0)
                {
                    if (NumberOfSwingsincrementer == 1)
                    {
                        Console.WriteLine("Success ! the ball is in the cup at the first  try! congrats !!");
                        // exit the loop 
                        Golfisplayed = false;
                    }
                    else
                    {
                        Console.WriteLine("sucess finally!");

                        Console.WriteLine("it took " + lstswings.Last() + " swings for sucess");
                        //exit from the loop 
                        Golfisplayed = false;

                    }
                }
                // you swung the ball beyond the allowed distance from the hole 
                else if (distanceTohole < 0)
                {
                    distanceTohole = Math.Abs(distanceTohole);
                    if (distanceTohole >= toofar)
                    {
                        Console.WriteLine("You've hit the ball too far. GAME OVER");
                        Golfisplayed = false;
                    }
                    

                }
                else if (distanceTohole > 0)
                {


                    // exceeds the number of allowed swings ? but did not near the hole 
                    if (NumberOfSwingsincrementer >= maxAllowedSwings && distanceTohole > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("you are away fromt the allowed valid distance , GAME OVER.");

                        //game over = exit loop and go to reporting 
                        Golfisplayed = false;
                    }
                    Console.WriteLine("keep up the good work , not yet achieved your goal");

                    distanceTohole = Math.Abs(distanceTohole);

                    Console.WriteLine("Distance left to the hole: " + distanceTohole);
                    Console.WriteLine();
                    Console.WriteLine("amount of Swings: " + NumberOfSwingsincrementer);
                    Console.WriteLine();
                    Console.WriteLine("Distance for each swing");
                    //mid game report 
                    foreach (string s in lstGameReport)
                    {
                        Console.WriteLine(s);
                    }

                }
               
               

            }// end of the loop 




            //Last game report for the whole course after ending the game 
            Console.WriteLine("================================");
            Console.WriteLine("amount of Swings: " + NumberOfSwingsincrementer);
            Console.WriteLine();
            Console.WriteLine("Distance for each swing");

            //final report 
            foreach (string s in lstGameReport)
            {
               
                Console.WriteLine(s);
            }


            Console.ReadKey();

        }


        //public class AngleInvalidExeption : Exception
        //{
        //    public AngleInvalidExeption()
        //        : base("The angle is invalid - try again")
        //    {
        //    }
        //}
        class SwingValidatorCalculator
        {
            //property for the whole journey until lose or win 



            // constant gravity variable
            public const double GRAVITY = 9.8;
            public double angle { get; set; }
            public double velocity { get; set; }
            public double AngleInRadians
            {
                get
                {
                    return (Math.PI / 180) * this.angle;
                }
            }
            public double Distance
            {
                get
                {
                    return Math.Pow(this.velocity, 2) / GRAVITY *
                        Math.Sin(2 * this.AngleInRadians);
                }
            }

            public SwingValidatorCalculator(double angle, double velocity)
            {


                if (velocity <= 0)
                {
                    this.velocity = 0;
                }
                else
                {
                    this.velocity = velocity;
                }


                this.angle = angle;

            }
        }
    }

 }

   
