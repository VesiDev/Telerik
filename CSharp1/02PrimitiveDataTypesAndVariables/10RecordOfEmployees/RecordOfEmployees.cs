using System;

namespace _10RecordOfEmployees
{
    class RecordOfEmployees
    {
        static void Main()
        {
            string firstName;
            string familyName;
            byte age;
            char gender;
            long id;
            int employeeNumber;

            firstName = "Alex";
            familyName = "Petrov";
            age = 23;
            gender = 'm';
            id = 9009086551;
            employeeNumber = 27569999;

            Console.WriteLine("Employee {0} {1},\nage {2}, gender {3}, ID {4}\nemployee number {5}", firstName, familyName, age, gender, id, employeeNumber);

        }
    }
}
