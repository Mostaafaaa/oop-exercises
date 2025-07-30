using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    // Exercise 8: Create an Animal class with a method make_sound().
    // Create subclasses Dog, Cat, and Cow that override make_sound().
    internal class Animal
    {
        public virtual void MakeSound() // virtual method to allow overriding in subclasses
        {
            Console.WriteLine("Some generic animal sound");
        }
    }
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("HAWHAWWWW!!");
        }
    }
    internal class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow Mao~");
        }
    }
    internal class Cow : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("MOOOOOOOOOOOO");
        }
    }

}
