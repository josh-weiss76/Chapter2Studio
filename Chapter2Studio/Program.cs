using System;

namespace Chapter2Studio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of a circle in miles: ");
            //float radiusInput = float.Parse(Console.ReadLine());
            string userInput = Console.ReadLine();
            float radiusInput;
            while (!float.TryParse(userInput, out radiusInput) || (radiusInput <= 0))
            {
                Console.WriteLine("Invalid entry, the radius should be a positive numeric character. Please enter the radius of a circle in miles: ");
                userInput = Console.ReadLine();
            } 

            //while (radiusInput <= 0)
            //{
            //    Console.WriteLine("Invalid entry, the radius should be a positive numeric character.  Please enter the radius of a circle in miles: ");
            //    radiusInput = float.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("The radius you entered is: " + radiusInput);
            //Console.WriteLine(radiusInput.GetType());
            Console.WriteLine("The area of a circle with a radius of " + radiusInput + " is " + CircleMeasurements.CircleArea(radiusInput));
            Console.WriteLine("The circumference of the circle is " + CircleMeasurements.CircleCircumference(radiusInput));
            Console.WriteLine("The diameter of the circle is " + CircleMeasurements.CircleDiameter(radiusInput));
            Console.WriteLine("Please enter the miles per gallon (MPG) of your vehicle: ");
            string userMPG = Console.ReadLine();
            float mpgInput;
            while (!float.TryParse(userMPG, out mpgInput) || (mpgInput <= 0))
            {
                Console.WriteLine("Invalid entry, the MPG should be a positive numeric character. Please your vehicle MPG: ");
                userMPG = Console.ReadLine();
            }

            Console.WriteLine("With a mpg of " + mpgInput + " your vehicle will use " + Roadtrip.GallonsPerTrip(CircleMeasurements.CircleCircumference(radiusInput), mpgInput) + " gallons of gasoline to travel the circumference of the circle");
        }
    }
}
