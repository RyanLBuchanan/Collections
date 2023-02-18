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

            for (int i = 0; i < stringArray1.Length; i++)
            {
                Console.Write(stringArray1[i]);
            }

            Console.WriteLine();

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


        }
    }
}