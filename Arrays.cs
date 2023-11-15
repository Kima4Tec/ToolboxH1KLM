namespace ToolboxH1
{
    internal class Arrays
    {
        //Different arrays
        //Arrays is written with camelcase. Arrayet has a certain amount of values. Arrays contains index starting at 0.
        //Arrays can contain different datatypes.
        public static int[] array1 = { 1, 2, 3, 4, 5, 6, };
        public static string[] array2 = { "a", "b", "c", "d", };
        public static int[] array3 = new int[6];

        public static void myCarArray() { 
        
                        string[] car = { "Audi", "BMW", "Volvo", "Seat","Ford" };

            Array.Sort(car); //static method sorting text in alphabetic order

            //for (int i = 0; i < car.Length; i++)
            //{
            //    Console.WriteLine(car[i]);
            //}

            //writes out all the values in the array
            foreach (string s in car)
            {
                Console.WriteLine(s);
            }
        }

    }
}
