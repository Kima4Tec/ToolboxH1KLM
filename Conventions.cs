using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolboxH1
{
    internal class Conventions
    {
        //fields -> camelCase
        public static string myCar = "Seat Toledo";

        //Properties -> PascalCase
        public static string MyDreamCar { get; set; }

        private int _price = 0;

        public int Price
        {
            //read
            get { return _price; }
            //write
            set
            {
                if (value == 192000)
                    _price = value;
                else
                    throw new ArgumentException("My car cost 192000 Dkr.");
            }

        }
    }
}

