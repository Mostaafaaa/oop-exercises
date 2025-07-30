using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace husain_haider_OOP_Excercise.Qestion08
{
    internal class Cat:Animal
    {
        public override String make_sound()
        {
            String CatSound = "Meow Meow";
            return CatSound;
        }
    }
}
