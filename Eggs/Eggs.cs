using System;

namespace Eggs
{
    class Eggs
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the ammount of eggs");
            int numberOfEggs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The ammount of eggs are:" + numberOfEggs);

            int dozen = numberOfEggs / 12;
            int dozenLeft = numberOfEggs % 12;
            Console.WriteLine(numberOfEggs + " eggs are equal to " + dozen + " dozen eggs and " + dozenLeft + " extra eggs left.");
        }
        
    }
}
