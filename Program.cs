using System;
using System.Collections.Generic;

namespace collections_practice {
    class Program {
        static void Main (string[] args) {

            int[] arrayOfInts = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine (arrayOfInts[0]);
            Console.WriteLine (arrayOfInts[1]);
            Console.WriteLine (arrayOfInts[2]);
            Console.WriteLine (arrayOfInts[3]);
            Console.WriteLine (arrayOfInts[4]);
            Console.WriteLine (arrayOfInts[5]);
            Console.WriteLine (arrayOfInts[6]);
            Console.WriteLine (arrayOfInts[7]);
            Console.WriteLine (arrayOfInts[8]);

            Console.WriteLine ("Next Problem");

            string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara" };

            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine ($"{names[i]}");
            }

            Console.WriteLine ("Next Problem");

            bool[] array = new bool[10];
            array[0] = true; // <-- Not needed
            array[1] = false;
            array[2] = true; // <-- Not needed
            array[3] = false;
            array[4] = true;
            array[5] = false;
            array[6] = true;
            array[7] = false;
            array[8] = true;
            array[9] = false;
            foreach (bool res in array) {
                Console.WriteLine (res);
            }

            Console.WriteLine ("Next Problem");

            List<string> iceCream = new List<string> ();

            iceCream.Add ("Chocolate");
            iceCream.Add ("Rocky Road");
            iceCream.Add ("Mint");
            iceCream.Add ("Chocolate-Chip");
            iceCream.Add ("Vanilla");

            Console.WriteLine ($"I really love all {iceCream.Count} Ice Cream Flavors!");

            for (var i = 0; i < iceCream.Count; i++) {
                Console.WriteLine ("-" + iceCream[i]);
            }
            iceCream.RemoveAt (3);

            Console.WriteLine ("I changed my mind, now I like these:");
            foreach (string flavor in iceCream) {
                Console.WriteLine ("-" + flavor);
            }

            Console.WriteLine ("Next Problem");

            Dictionary<string, string> profile = new Dictionary<string, string> ();

            profile.Add ("Language", "C#");

            Console.WriteLine ("Coding Dojo");
            Console.WriteLine ("Favorite Language - " + profile["Language"]);

        }
    }
}