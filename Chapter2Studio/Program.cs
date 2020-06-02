using System;

namespace Chapter2Studio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of a circle in miles: ");
            float radiusInput = float.Parse(Console.ReadLine());
            
            while (radiusInput <= 0)
            {
                Console.WriteLine("Please enter a positive value for the radius: ");
                radiusInput = float.Parse(Console.ReadLine());
            }
            //Console.WriteLine("The radius you entered is: " + radiusInput);
            //Console.WriteLine(radiusInput.GetType());
            Console.WriteLine("The area of a circle with a radius of " + radiusInput + " is " + CircleMeasurements.CircleArea(radiusInput));
            Console.WriteLine("The circumference of the circle is " + CircleMeasurements.CircleCircumference(radiusInput));
            Console.WriteLine("The diameter of the circle is " + CircleMeasurements.CircleDiameter(radiusInput));
            Console.WriteLine("Please enter the miles per gallon (mpg) of your vehicle: ");
            float mpgInput = float.Parse(Console.ReadLine());
            Console.WriteLine("With a mpg of " + mpgInput + " your vehicle will use " + Roadtrip.GallonsPerTrip(CircleMeasurements.CircleCircumference(radiusInput), mpgInput) + " gallons of gasoline to travel the circumference of the circle");
        }
    }
}
