using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace husain_haider_OOP_Excercise.Qestion08
{
    /*
        Exercise 8: Create an Animal class with a method make_sound(). Create subclasses Dog, Cat, and Cow that override make_sound().
        */
    internal class Animal
    {
        public virtual String make_sound()
        {
            //  returning no sound bc no anime was spicified
            return ".......";
        }
    }
}
