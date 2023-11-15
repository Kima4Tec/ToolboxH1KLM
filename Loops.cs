namespace ToolboxH1
{
    internal class Loops
    {
        public static void ForMethodWithModulus()
        {
            for (int i = 0; i < 1000; i+=10)
            {
                Console.WriteLine(i % 360);
            }
        }

    }
}
