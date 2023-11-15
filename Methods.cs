namespace ToolboxH1
{
    public class Methods
    {
        public Methods()
        {
            Console.WriteLine("This is a constructor");
        }
        //public Methods(int parameter1, string parameter2)
        //{
        //    Console.WriteLine("This is a parameterized constructor");
        //}


        private static void StaticVoidMethod()
        {
            string SVMtext = "This is a text";
            Console.WriteLine(SVMtext);
        }

        public static string StaticReturnMethod()
        {
            string RText = "This is another text";
            return RText;
        }

    }

}
