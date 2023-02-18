namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Unitialized
            string[] stringArray0 = new string[3];
            // Initialized
            string[] stringArray1 = { "This ", "is ", "SPARTA . . . er, an array, I mean!\n" };

            // Unitialized list
            List<string> stringList = new List<string>();

            stringList.Add("This ");
            stringList.Add("is a ");
            stringList.Add("LISTA!\n");

            // Array header
            Console.WriteLine("----- Array -----");
            for (int i = 0; i < stringArray1.Length; i++)
            {
                Console.Write(stringArray1[i]);
            }

            Console.WriteLine();

            // List header
            Console.WriteLine("----- List -----");
            foreach (string str in stringList)
            {
                Console.Write(str);
            }

            Console.WriteLine();

            /* --------------------------- */

            stringList.Insert(1, "container ");

            foreach (string str in stringList)
            {
                Console.Write(str);
            }

            Console.WriteLine();

            /* --------------------------- */

            // Array of arrays header
            Console.WriteLine("----- Array of Arrays (Matrix) -----");
            int[,] table = new int[10, 10];

            Console.WriteLine("Multiplication table 1 -10:");
            Console.WriteLine("--------------------------------");
            // Iterate over each element in the first array dimension
            for (int i = 1; i <= table.GetLength(0); ++i)
            {
                for (int j = 1; j <= table.GetLength(1); ++j)
                {
                    table[i - 1, j - 1] = i * j;
                    Console.Write(table[i - 1, j - 1]+ " | ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // Dictionary header
            Console.WriteLine("----- Dictionary -----");
            Dictionary<string, string> contacts = new Dictionary<string, string>();

            contacts.Add("T' Pol", "867-5309");
            contacts.Add("Six (the Cylon very non-toastery", "666-6666");
            contacts.Add("Seven of Nine", "777-7777");

            if (contacts.ContainsKey("T' Pol"))
            {
                contacts.Remove("T' Pol");
            }

            Console.WriteLine(contacts["Seven of Nine"]);

            string output;

            if (contacts.ContainsKey("Seven of Nine"))
            {
                contacts.TryGetValue("Seven of Nine", out output);
                if (output != null)
                {
                    Console.WriteLine($"Seven of Nine's phone number is: {output}");
                }
            }

            Console.WriteLine("\n");

            foreach (string value in contacts.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}