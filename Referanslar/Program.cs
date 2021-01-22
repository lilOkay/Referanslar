using System;

namespace Referanslar
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "okay";
            person2 = person1;
            person2.FirstName = "lucky";
            Console.WriteLine(person1.FirstName);
            Customer customer = new Customer();
            customer.CreditCardNumber = 1234567890;
            Employee employee = new Employee();
            employee.FirstName = "ali";


            //burada yaptığımız hareket sayesinde personmanager a employee yi gönderebildik
            Person person3 = customer;
            customer.CreditCardNumber=0987654321;



            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personmanager = new PersonManager();

            personmanager.Add(employee);
            //siz yukarıya customer employee ve person 3 yazabilirsiniz
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public int CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
                            //burada customer göderseniz sadece customer çalışırsınız employe gönderseniz sadece employe çalıpşırsınız ama person gönderirseniz hepsiyle çalışabilirsiniz:)
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
