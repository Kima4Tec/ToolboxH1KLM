using System.Linq.Expressions;
using System.Threading.Channels;

namespace ToolboxH1
{
    //CONTAINS
    //SwitchCase
    //SwitchCase2
    //IfElseCondition
    //TryCatch
    internal class Conditions
    {
        public static void SwitchCase()
        {
            var key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.Spacebar:
                    break;
                case ConsoleKey.D1:
                    Console.WriteLine("You pressed the number 1");
                    break;
            }
        }

            public static void SwitchCase2()
            {
                int i = 45;

                switch (i)
                {
                    case < 30:
                        //RED: LOW HEALTH
                        break;
                    case < 60:
                        //YELLOW; MEDIUM HEALTH
                        break;
                    case < 100:
                        //GREEN; GOOD HEALTH
                        break;
                    default:
                        //GREAT HEALTH
                        break;
                }
            }

        public static void IfElseConditions()
        {
            double temp = 37.0;
            if (temp < 37.5)
            {
                Console.WriteLine("You are well. No fever."); 
            }
            else if (temp < 38.5)
            {
                Console.WriteLine("You are ill. Stay home.");
            }
            else
            {
                Console.WriteLine("You are seriously ill. Call the doctor");
            }
        }
        public static void TryCatch()
        {
            string text = null;
            try 
            {
                Console.WriteLine(text.Length);
            }
            catch (NullReferenceException ex) 
            {
                Console.WriteLine($"NullReferenceException caught: {ex.Message}"); 
            }
            finally 
            {
                Console.Write("You cannot get the length of a string, that is null. Try writing your name instead: ");
                text = Console.ReadLine();
                Console.WriteLine("Length of your name: "+ text.Length);
            }
        }

        }
}
