using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weaponTest
{
    class Dog
    {



        private static int num;

        public static int Num
        {
            get { return num; }
        }

        public Dog()
        {
            num++;
        }

        ~Dog() { num--;  }

        public static string voice = "먼먼";
        public static string Vox() => voice;

        

       
    }
}
