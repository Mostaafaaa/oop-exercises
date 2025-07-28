using OOP;
using System;
using System.Security.Cryptography.X509Certificates;



class Program
{
    static void Main()
    {
        Console.Write("Ex1. ");
        CarClass car1 = new CarClass();
        car1.brand = "Cadillac";
        car1.model = "Escalade";
        car1.year = 2023;
        car1.start();
        car1.stop();
        Console.WriteLine("-------");
        CarClass car2 = new CarClass();
        car2.brand = "Audi";
        car2.model = "A6";
        car2.year = 2022;
        car2.start();
        car2.stop();
        Console.WriteLine("-------");
        CarClass car3 = new CarClass();
        car3.brand = "BMW";
        car3.model = "X5";
        car3.year = 2021;
        car3.start();
        car3.stop();
        Console.WriteLine("+++++++++++++++++++++++++++=");
        Console.Write("Ex2. ");
        StudentClass student1 = new StudentClass();
        student1.Name = "Aween";
        student1.Age = 23;
        student1.Grade = 87.5;
        student1.introduce();
        Console.WriteLine("+++++++++++++++++++++++++++=");
        Console.WriteLine("Ex3. ");
        RectangleClass rectangle = new RectangleClass();
        rectangle.width = 5;
        rectangle.height = 10;
        Console.WriteLine($"The rectangle area is:  {rectangle.area()}");
        Console.WriteLine($"Perimeter is:  {rectangle.perimeter()}");
        Console.WriteLine("+++++++++++++++++++++++++++=");
        Console.WriteLine("Ex4. ");
        BankAccountClass account = new BankAccountClass();
        account.account_number = "ACC12345";
        account.balance = 500.0;

        account.check_balance();

        account.deposit(200.0);
        account.check_balance();

        account.withdraw(100.0);
        account.check_balance();
        Console.WriteLine("+++++++++++++++++++++++++++=");
        Console.Write("Ex20. ");
        ContactBook contactBook = new ContactBook();
        Contact contact1 = new Contact();
        contact1.Name = "Aween Ezzat";
        contact1.Email = "aweenezzat@gmail.com";
        contact1.PhoneNumber = 123456789;
        contactBook.AddContact();
        contactBook.list_contacts();
        Console.WriteLine("+++++++++++++++++++++++++++=");


    }
}


