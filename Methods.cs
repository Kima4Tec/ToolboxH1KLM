using System.Reflection.Metadata.Ecma335;

namespace ToolboxH1
{
    public class Methods
    {

        //Access modifier (public, internal, protected or protected) i denne rækkefølge
        //Static(ligger på klassen) or non-static (ligger på objektet)
        //Returntype (void or a type. Type can have many forms, ie. string, int and so on)
        //Methodname (Pascal case, only letters, only use BIG I for interface)
        //Parameter (parenthesis indicates a method. Any number of arguments can be sent.
        //Dette <> indikerer en type
        //Body (where the fun starts, and logic recides)


        //Method signature is the Name and Parameters, and have to be unique
        //Follow example is NOT unique.
        void Test() 
        {
            int age = 26;
            bool LeoDecap = true;
            if (LeoDecap && age > 25) return;
                else
                {
                    bool LetsParty = true;
                }

            return; //This is there implicitly and is not neccesary 
        }

        //all paths have to return the type of returntype, so this is not working:
        //bool Test2()
        //{
        //    int age = 26;
        //    bool LeoDecap = true;
        //    if if (LeoDecap && age > 25) return false;
        //        else
        //        {
        //            bool LetsParty = true;
        //        }

        //    return "Nice"; //This is there implicitly and is not neccesary 
        //}

        // With object you can have two different types. It goes further up, to find a common ground. With this you
        //can return all kinds of types.
        object Test3()
        {
            int age = 26;
            bool LeoDecap = true;
            if (LeoDecap && age > 25) return false;
                else
                {
                    bool LetsParty = true;
                }

            return "Nice"; //This is there implicitly and is not neccesary 
        }
        internal void TestTest3()
        {
            object v = Test3();
            Console.WriteLine(v.GetType());
        }

        //string Test() { return "Hello"; } Cannot be done.
        //Two mothods with the same name, but different parameters are called "Overloading"
        void SameSameButDifferent() { }
        void SameSameButDifferent(string diff) { }



        public Methods()
        {
            Console.WriteLine("This is a constructor");
        }
        //public Methods(int parameter1, string parameter2)
        //{
        //    Console.WriteLine("This is a parameterized constructor");
        //}

        //Generic type - NOT H1 material. 
        void callingGenericMethod()
        {
            GenericMethod<string>("how deep");
            GenericMethod< int > (12);
        }

        T GenericMethod <T> (T t) { 
            
            Console.WriteLine(t.GetType());
            if (t.GetType() == typeof(string)) 
            {
                return (T)(object)"15";
                    };
            return t;
        }

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
