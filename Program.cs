using System;

namespace AltitiudeChange
{
    /// <summary>
    /// Altitude Change
    /// </summary>
    class Program
    {
        /// <summary>
        /// Prompt for and getting altitude.
        /// Calculate and display the altitude change
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Enter first altitude: ");
            int firstAltitude = int.Parse(Console.ReadLine());
            Console.Write("Enter second altitude: ");
            int secondAltitude = int.Parse(Console.ReadLine());
            Console.Write("Change in altitudes: " + (secondAltitude - firstAltitude));
        }
    }
}
