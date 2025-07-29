
using husain_haider_OOP_Excercise.Qestion1;
using husain_haider_OOP_Excercise.Qestion13;
using husain_haider_OOP_Excercise.Qestion2;
using husain_haider_OOP_Excercise.Qestion20;
using husain_haider_OOP_Excercise.Question14;

namespace husain_haider_OOP_Excercise
{
    internal class main
    {
        static void Main(string[] args)
        {
            /*
             * Exercise 1: Create a Car class with attributes brand, model, and year. 
             * Add methods start() and stop(). Create 3 car objects and call their methods.
            */

            Console.WriteLine("First Qstion: ");
            Console.WriteLine("------------");


            //brand = Toyota;
            //model = Supra;
            //year = 2023;
            Car car1 = new Car("Toyota", "Supra", 2023);

            //brand = Ford;
            //model = Mustang;
            //year = 2021;
            Car car2 = new Car("Ford", "Mustang", 2021);

            //brand = Porsche;
            //model = 911;
            //year = 2022;
            Car car3 = new Car("Porsche", "911", 2022);


            Console.WriteLine();


            /*Exercise 2: Create a Student class with attributes name, age, and grade. 
             * Add a method introduce() that prints the student details.

*/
            Console.WriteLine("2nd Qstion: ");
            Console.WriteLine("------------");

            Student student1 = new Student("Ali", "18", "A");
            Student student2 = new Student("Sara", "19", "B");

            student1.introduce();




            Console.WriteLine("\n\n");



            /*
            Exercise 3: Create a Rectangle class with attributes width and height. 
            Add methods area() and perimeter() to calculate and return the values.
            */



            Console.WriteLine("3rd Qstion: ");
            Console.WriteLine("------------");

            Rectangle rectangle = new Rectangle(10, 10);

            Console.WriteLine($"created rectangle object that is: {rectangle.height} x {rectangle.width}");
            Console.WriteLine($"Rectangle area is: {rectangle.area()}");
            Console.WriteLine($"Rectangle perimeter is: {rectangle.perimeter()}");

            Console.WriteLine("\n\n");


            /*
            Exercise 4: Create a BankAccount class with attributes account_number and balance. 
            Add methods deposit(amount), withdraw(amount), and check_balance().
            */
            Console.WriteLine("4th Qstion: ");
            Console.WriteLine("------------");


            BankAccount accont = new BankAccount(12345,2000);

            accont.deposit();
            accont.withdraw();
            accont.checheck_balanceck();





            Console.WriteLine("\n\n");



            /*
             * Exercise 20: Create a Contact class with attributes name, phone, and
             * email. Create a ContactBook class that manages contacts with 
             * add_contact() and list_contacts().
             */


            Console.WriteLine("20th Qstion: ");
            Console.WriteLine("------------");

            ContactBook contactBook= new ContactBook();
            contactBook.add_contact(new Contact("ali","alialkutubi@gmail.com","07844256241"));
            contactBook.add_contact(new Contact("ali","alialkutubi@gmail.com","07844256241"));
            contactBook.add_contact(new Contact("husain", "husainalkutubi@gmail", "07864252321"));
            contactBook.list_contacts();



            Console.WriteLine("\n\n");
            





        }
    }
}
