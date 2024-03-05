using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CS_Using_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Section 2
            /* Console.WriteLine("Using HashSet");
             //1. Defining String Array (Note that the string "mahesh" is repeated) 
             string[] names = new string[] {
                 "mahesh",
                 "vikram",
                 "mahesh",
                 "mayur",
                 "suprotim",
                 "saket",
                 "manish"
             };
             //2. Length of Array and Printing array
             Console.WriteLine("Length of Array " + names.Length);
             Console.WriteLine();
             Console.WriteLine("The Data in Array");
             foreach (var n in names)
             {
                 Console.WriteLine(n);
             }

             Console.WriteLine();
             //3. Defining HashSet by passing an Array of string to it
             HashSet<string> hSet = new HashSet<string>(names);
             //4. Count of Elements in HashSet
             Console.WriteLine("Count of Data in HashSet " + hSet.Count);
             Console.WriteLine();
             //5. Printing Data in HashSet, this will eliminate duplication of "mahesh" 
             Console.WriteLine("Data in HashSet");
             foreach (var n in hSet)
             {
                 Console.WriteLine(n);
             }
             Console.ReadLine();*/

            // Section 3
            string[] names1 = new string[] {
                "mahesh","sabnis","manish","sharma","saket","karnik"
             };
            
            string[] names2 = new string[] {
                "suprotim","agarwal","vikram","pendse","mahesh","mitkari"
             };
            //2.

            HashSet<string> hSetN1 = new HashSet<string>(names1);
            Console.WriteLine("Data in First HashSet");
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_______________________________________________________________");
            HashSet<string> hSetN2 = new HashSet<string>(names2);
            Console.WriteLine("Data in Second HashSet");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("________________________________________________________________");
            //3.
            Console.WriteLine("Data After Union");
            hSetN1.UnionWith(hSetN2);
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }
            
            // section 4
            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Data in HashSet before using Except With");
            Console.WriteLine("_________________________________");
            //storing data of hSetN3 in temporary HashSet
            HashSet<string> hSetN3 = new HashSet<string>(names1);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using Except With");
            Console.WriteLine("_________________________________");
            hSetN3.ExceptWith(hSetN2);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }
            // section 5
            HashSet<string> hSetN4 = new HashSet<string>(names1);
            Console.WriteLine("_________________________________");
            Console.WriteLine("Elements in HashSet before using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            Console.WriteLine("HashSet 1");
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("HashSet 2");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            hSetN4.SymmetricExceptWith(hSetN2);
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
            Get_Add_Performance_HashSet_vs_List();
            Get_Contains_Performance_HashSet_vs_List();
            Get_Remove_Performance_HashSet_vs_List();
        }
        // section 6


        static string[] names = new string[] {
                "Liam", "Olivia", "Noah", "Emma", "Oliver", "Ava", "William", "Sophia", "Elijah", "Isabella",
    "James", "Mia", "Benjamin", "Charlotte", "Lucas", "Amelia", "Henry", "Harper", "Alexander", "Evelyn",
    "Michael", "Abigail", "Daniel", "Emily", "Matthew", "Elizabeth", "Aiden", "Sofia", "Joseph", "Ella",
    "Jackson", "Madison", "Samuel", "Scarlett", "Sebastian", "Victoria", "David", "Avery", "Carter", "Grace",
    "Wyatt", "Chloe", "Jayden", "Lily", "John", "Riley", "Owen", "Aria", "Dylan", "Zoey",
    "Luke", "Nora", "Gabriel", "Leah", "Anthony", "Hannah", "Isaac", "Lillian", "Grayson", "Addison",
    "Christopher", "Eleanor", "Joshua", "Natalie", "Andrew", "Luna", "Lincoln", "Penelope", "Mateo", "Brooklyn",
    "Ryan", "Layla", "Jaxon", "Audrey", "Nathan", "Mila", "Aaron", "Claire", "Isaiah", "Skylar",
    "Thomas", "Bella", "Charles", "Aurora", "Caleb", "Lucy", "Josiah", "Anna", "Christian", "Samantha",
    "Hunter", "Caroline", "Eli", "Genesis", "Jonathan", "Aaliyah", "Connor", "Kennedy", "Levi", "Kinsley",
    "Elizabeth", "Allison", "Cameron", "Maya", "Hunter", "Sarah", "Adrian", "Isabelle", "Theodore", "Alice",
    "Jeremiah", "Madelyn", "Hudson", "Lyla", "Robert", "Adeline", "Easton", "Alexa", "Nolan", "Gabriella",
    "Nicholas", "Josephine", "Ezra", "Gianna", "Colton", "Isla", "Angel", "Elena", "Brayden", "Mya",
    "Jordan", "Aubrey", "Dominic", "Ariana", "Austin", "Violet", "Ian", "Hazel", "Adam", "Lillian",
    "Elias", "Summer", "Jaxson", "Julia", "Greyson", "Valentina", "Jose", "Nova", "Evan", "Clara",
    "Maverick", "Sophie", "Bryson", "Delilah", "Jace", "Sadie", "Jason", "Naomi", "Colin", "Eva",
    "Miles", "Nevaeh", "Kayden", "Adalynn", "Santiago", "Piper", "Axel", "Lydia", "Chase", "Alexandra",
    "Cooper", "Maria", "Carlos", "Taylor", "Brody", "Madeline", "Nathaniel", "Rylee", "Kai", "Brielle",
    "Blake", "Jade", "Carson", "Jocelyn", "Leo", "Ashley", "Jeremiah", "Everly", "Micah", "Khloe",
    "Xavier", "Fiona", "Cole", "Willow", "Hayden", "Londyn", "Diego", "Isabel", "Kevin", "Ellie",
    "Zachary", "Savannah", "Parker", "Paige", "Tyler", "Nora", "Ayden", "Ruby", "Gavin", "Serenity",
    "Bentley", "Peyton", "Jason", "Penelope", "Adam", "Victoria", "Antonio", "Paisley", "Elias", "Annabelle",
    "Leo", "Haley", "Luca", "Mariah", "Bennett", "Nicole", "Greyson", "Harmony", "Ryker", "Emery",
    "Ian", "Eden", "Kingston", "Eliza", "Jordan", "Adalyn", "Giovanni", "Laila", "Eric", "Myra",
    "Malachi", "Catherine", "Jude", "Holly", "Gael", "Katherine", "Rhett", "Vivian", "Landon", "Amaya",
    "Wesley", "Alexis", "Emmett", "Maci", "Timothy", "Athena", "Finn", "Leilani", "Ezekiel", "Mackenzie",
    "Ryder", "Miranda", "Richard", "Jasmine", "Marcus", "Adriana", "Theo", "Giselle", "Maxwell", "Daniela",
    "Harrison", "Kiara", "Lorenzo", "Ivy", "Tristan", "Liliana", "Beau", "Stephanie", "Max", "Angela",
    "Jax", "Danielle", "Xander", "Kylee", "Fabian", "Hope", "Karter", "Jayla", "Calvin", "Melanie",
    "Rylan", "Margaret", "Israel", "Rebecca", "Ezra", "Alana", "Emmanuel", "Jazmin", "Knox", "Iris",
    "Waylon", "Valerie", "Jameson", "Cora", "Abel", "Norah", "Amir", "Emerson", "Zayden", "Felicity",
    "Mark", "Cecilia", "August", "Brynn", "Elliott", "Diana", "Tucker", "Alaina", "Edward", "Joy",
    "Kaden", "Alina", "Leon", "Lucia", "Amos", "Bianca", "Archer", "Eloise", "Andre", "Ariel",
    "Chance", "Adeline", "Grant", "Juliana", "Hugo", "Miriam", "Oscar", "Rose", "Felix", "Lena",
    "Dante", "Laura", "Louis", "Malia", "Brett", "Sarah", "Walker", "Ruth", "Zander", "Daisy",
    "Albert", "Lana", "Arthur", "Alexandria", "Larry", "Amara", "Corbin", "Selena", "Brady", "Esther",
    "Kameron", "Leila", "Zion", "Ayla", "Ali", "Elise", "Muhammad", "Ana", "Jay", "Callie",
    "Curtis", "Harley", "Orion", "Karen"};
        static void Get_Add_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while Adding Item");
            Console.WriteLine();
            Console.WriteLine("There are " + names.Length + " names in the list");
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Add(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while Adding Item");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Add(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();

        } // the performance of adding items to the list is better than adding items to the hashset
        // that is because the hashset cannot have duplicate items and therefore it has to check if the item is already in the hashset

        static void Get_Contains_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while checking Contains operation");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Contains(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while checking Contains operation");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Contains(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();

        } // the performance of checking if an item is in the list should typically be slower than with a
        // hashset because the list need to check each item in the list to see if it contains the item. The hashset can 
        // use the hashcode to find the item in the hashset which is faster with larger datasets.

        static void Get_Remove_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while performing Remove item operation");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Remove(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while performing Remove item operation");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Remove(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();

        } // the performance of removing items from the hashset is generally better than removing items from the
          // list. That is because the hashset can use the hashcode to find the item in the hashset which is faster with larger datasets.
    }
    
}