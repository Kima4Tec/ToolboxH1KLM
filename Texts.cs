using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ToolboxH1
{
    internal class Texts
    {
        public static void Text(string parameterText)
        {
            //change color on text
            Console.ForegroundColor = ConsoleColor.Yellow;
            string localText = "local text";
            Console.ResetColor();
            //print out the text from the parameter
            Console.WriteLine(parameterText);
            Console.Write (parameterText);
            //print out the local string variable
            Console.WriteLine(localText);

            //Using += to add a text to a variable
            string textcollection;
            textcollection = ("\nFirst text\n");
            textcollection += ("Second text");
            Console.WriteLine(textcollection);

            //string array
            string[] words = { "This", "is", "a", "sentence" };
            //invoke the Join method.
            // ... Print the resulting string.
            Console.WriteLine(string.Join(" ", words));
        }
        public static void TextFun()
        {
            //replace all the danish letters to letters that can be typed on an English keyboard
            string dkText = "Sild på rugbrød med ægte dansk årgangssnaps.";
            string result = "";
            for (int i = 0; i < dkText.Length; i++)
            {
                if (dkText[i] == 'ø')
                {
                    result += "oe";
                }
                else if (dkText[i] == 'å')
                {
                    result += "aa";
                }
                else if (dkText[i] == 'æ')
                {
                    result += "ae";
                }
                else
                {
                    result += dkText[i];
                }
            }
            Console.WriteLine(result);
        }


        public static void Reverse(string text)
        {
            //ToCharArray copies the characters to a unicode character array
            char[] cArray = text.ToCharArray();

            //string reverse is defined and empty not null
            string reverse = String.Empty;

            //i is defined as the last index number, loop runs while i is greater than -1 (meaning zero). Reverse gets first the last character in the array and then counting down.
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            positioningText(55, 10, reverse);
            Console.SetCursorPosition(30, 20);
        }
        public static void positioningText(int x, int y, string pText)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(pText);
        }

    }
}
