using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton
{
    //Have only one instance of a class to use on all the project 
    class Singleton
    {
        public static Singleton ins;

        public static Singleton GetIns()
        {
            if (ins == null) ins = new Singleton();

            return ins;
        }
    }

    
}
