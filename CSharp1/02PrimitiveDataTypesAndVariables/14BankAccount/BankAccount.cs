using System;

namespace _14BankAccount
{
    class BankAccount
    {
        static void Main()
        {
            string firstName;
            string middleName;
            string lastName;
            decimal balance;
            string bankName;
            string iban;
            string bicCode;
            long creditCard1;
            long creditCard2;
            long creditCard3;

            firstName = "Hrisito";
            middleName = "Dimitrov";
            lastName = "Yordanov";
            balance = 10000;
            bankName = "First Investment Bank";
            iban = "BG49FINV915010EUR0A1AW";
            bicCode = "FINVBGSF";
            creditCard1 = 1111111111111111;
            creditCard2 = 2222222222222222;
            creditCard3 = 3333333333333333;
           
            Console.WriteLine("{0} ", bankName);
            Console.WriteLine("Holder name: {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Iban: {0},  BICCODE: {1} has balance of {2:C2}", iban, bicCode, balance);
            Console.WriteLine("The client has 3 credit cards with Iban {0}: \n1. {1} \n2. {2}\n3. {3}", iban, creditCard1, creditCard2, creditCard3);
        }
    }
}
