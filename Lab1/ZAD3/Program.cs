
/*Napisati program za bankare koji ima deklariran pobrojani tip podataka u kojem se
nalaze vrste računa (Štednja , Tekući račun, Žiro račun). Unutar programa deklarirati
strukturu BankAccount koja će sadržavati tri varijable, broj računa, iznos na računu i
vrstu računa.
Program treba deklarirati polje struktura BankAccount od 5 elemenata, te napraviti
izbornik koji će imati opcije, upisa novog računa, i ispis svih računa. Za ispis svih
računa koristiti “foreach” iteraciju. */
using System;
using System.Collections.Generic;

namespace zad3
{
    public enum AccountType
    {
        Štednja=1,
        Tekući_račun=2,
        Žiro_račun=3
    }
    public struct BankAccount
    {
        public int accountNumber;
        public int balance;
        public AccountType accountType;
        public BankAccount(int numberOfTheAccount,int state ,AccountType typeOfTheAccount)
        {
            accountNumber = numberOfTheAccount;
            balance = state;
            accountType = typeOfTheAccount;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            List<BankAccount> listOfBankAccount = new List<BankAccount>();
            listOfBankAccount.Add(new BankAccount(73626, 643,AccountType.Štednja));
            listOfBankAccount.Add(new BankAccount(626, 6, AccountType.Štednja));
            listOfBankAccount.Add(new BankAccount(79, 43, AccountType.Štednja));
            listOfBankAccount.Add(new BankAccount(32, 2, AccountType.Štednja));
            listOfBankAccount.Add(new BankAccount(595, 1, AccountType.Štednja));

            Console.WriteLine("Choose what you want to do:\n 1:input another bank account \n 2:print all accounts \n 3:break the operation \nplease enter the wanted number");
            string input = Console.ReadLine();
            
            while (input != "1" && input !="2" && input !="3")
            {
                Console.WriteLine("please input the correct number");
                input = Console.ReadLine();

            }
            while (input != "3")
            { 
                
                if (input == "1")
                {
                    Console.WriteLine("Please input the account number");
                    string accountNumber = Console.ReadLine();
                    Console.WriteLine("Please input the account balance");
                    string accountBalance = Console.ReadLine();
                    Console.WriteLine("Please input the account type\n0:Štednja \n1:Tekući_račun \n2:Žiro_račun \nplease input the wanted number");
                    int accountType = Convert.ToInt32(Console.ReadLine());
                    if (Enum.IsDefined(typeof(AccountType),accountType))
                        listOfBankAccount.Add(new BankAccount(Convert.ToInt32(accountNumber), Convert.ToInt32(accountBalance), (AccountType)accountType));
                }
                else if(input == "2")
                {
                    foreach (BankAccount accounts in listOfBankAccount)
                    {
                        
                        Console.WriteLine($"Account number is: {accounts.accountNumber.ToString()}, balance: {accounts.balance.ToString()} " +
                        $" ,type: {accounts.accountType }");
                        
                    }
                }
                Console.WriteLine("Choose what you want to do:\n 1:input another bank account \n 2:print all accounts \n 3:break the operation \nplease enter the wanted number");
                input = Console.ReadLine();
                
            }
        }
    }
}
