using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car BMW = new Car("Cadillac", "Escalade", "2025");
            BMW.Start();
            BMW.Stop();
            Car Audi = new Car("BMW", "Z5 Black", "2024");
            Audi.Start();
            Audi.Stop();
            Car Cadillac = new Car("Cadillac", "De Ville Convertible", "1966");
            Cadillac.Start();
            Cadillac.Stop();

            Console.WriteLine();

            Student Zetta = new Student("Zahraa", 22, "A+");
            Zetta.Introduce();

            Console.WriteLine();

            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 10;
            Console.WriteLine($"Area of the rectangle: {rectangle.Area()}");
            Console.WriteLine($"Perimeter of the rectangle: {rectangle.Perimeter()}");

            Circle circle = new Circle(3.5);
            Console.WriteLine($"Area of the circle: {circle.Area()}");
            Square square = new Square(4);
            Console.WriteLine($"Area of the square: {square.Area()}");

            Console.WriteLine();
            Library library = new Library();    
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 10.99);
            Book book2 = new Book("1984", "George Orwell", 8.99);
            Book book3 = new Book("The Picture of Dorian Gray", "Oscar Wilde", 10.00);
            Book book4 = new Book("The Way to Paradise", "Mario Vargas Llosa", 9.99);
            library.add_book(book1);
            library.add_book(book2);
            library.add_book(book3);
            library.add_book(book4);
            library.show_books();
            library.remove_book("1984");
            Console.WriteLine("After removing '1984':");
            library.show_books();

            Console.WriteLine();

            Movie movie1 = new Movie("The Matrix", "Lana Wachowski, Lilly Wachowski", 1999);
            Movie movie2 = new Movie("Scent of a Woman", "Martin Brest", 1992);
            Movie movie3 = new Movie("The Shawshank Redemption", "Frank Darabont", 1994);
            Movie movie4 = new Movie("The Godfather", "Francis Ford Coppola", 1972);
            movie1.ShowDetails();
            movie2.ShowDetails();
            movie3.ShowDetails();
            movie4.ShowDetails();

            Console.WriteLine();

            School school = new School();
            Student student1 = new Student("Zetta", 22, "B+");
            Student student2 = new Student("Noor", 21, "A");
            Student student3 = new Student("Rabab", 20, "A+");

            school.AddStudent(student1);
            school.AddStudent(student2);
            school.AddStudent(student3);

            Console.WriteLine("All students in the school:");
            school.ShowAllStudents();

            Console.WriteLine();

            Bank bank1 = new Bank();
            BankAccount account1 = new BankAccount("123456", 1000);
            BankAccount account2 = new BankAccount("789012", 2000);
            bank1.CreateAccount(account1);
            bank1.CreateAccount(account2);
            bank1.ShowAllAccounts();

            Product p1 = new Product("Laptop", 1500.00);
            Product p2 = new Product("Smartphone", 800.00);
            Product p3 = new Product("Tablet", 600.00);
            Inventory inventory = new Inventory();
            inventory.AddProduct(p1);
            inventory.AddProduct(p2);
            inventory.AddProduct(p3);
            Console.WriteLine("Products in inventory:");
            inventory.ListProducts();
        }
    }
}