//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints them on the console.


using System;

namespace _03ReadAndPrintInfoForCompanyAndManager
{
    class ReadAndPrintInfoForCompanyAndManager
    {
        static void Main()
        {
            string name;
            string address;
            string phonenumber;//string allows different phone formats
            string fax; 
            string website; 
            string managerFirstName; 
            string managerLastName;
            byte   age;
            string managerPhoneNumber;

            Console.WriteLine("Enter company name");
            name = Console.ReadLine();
            Console.WriteLine("Enter company address");
            address = Console.ReadLine();
            Console.WriteLine("Enter company phone number");
            phonenumber = Console.ReadLine();
            Console.WriteLine("Enter company fax");
            fax = Console.ReadLine();
            Console.WriteLine("Enter company website");
            website = Console.ReadLine();
            Console.WriteLine("Enter manager's first name");
            managerFirstName = Console.ReadLine();
            Console.WriteLine("Enter manager's last name");
            managerLastName = Console.ReadLine();
            Console.WriteLine("Enter manager's age");
            age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter manager's phone number");
            managerPhoneNumber = Console.ReadLine();

            Console.WriteLine("Company {0} with addres {1}, phone number {2}, fax {3}, website {4} is managed by {5} {6} who is {7} years old. You can contact him at {8}",
            name, address, phonenumber, fax, website, managerFirstName, managerLastName, age, managerPhoneNumber);           
        }
    }
}
