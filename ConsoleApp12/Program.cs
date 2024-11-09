using System;
using System.Collections.Generic;

namespace AdvancedAccounts
{
    /*  1. Register account numbers.
        2. Sort account numbers smallest to largest.
        3. Search account numbers.
        4. Update account numbers.
        5. Delete account numbers.
        6. View foramted Account numbers.
        0. Exit.
    */
    enum Menu
    {
        Register = 1,
        Sort,
        Search,
        Update,
        Delete,
        View,
        Exit = 0
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] AccountNumbers = new string[5];
            bool exit = false;
            while (exit == false)
            {
                bool found = false;
                Console.Clear();
                Console.WriteLine("1. Register account numbers.");
                Console.WriteLine("2. Sort account numbers.");
                Console.WriteLine("3. Search.");
                Console.WriteLine("4. Update.");
                Console.WriteLine("5. Delete.");
                Console.WriteLine("6. View account numbers.");
                Console.WriteLine("0. Exit.");
                int option = int.Parse(Console.ReadLine());
                Console.Clear();

                Menu menu = (Menu)option;
                switch (menu)
                {
                    case Menu.Register: // Enter all account numbers.
                        for (int i = 0; i < AccountNumbers.Length; i++)
                        {
                            Console.Clear();
                            Console.WriteLine("{0}. Add account number:", i + 1);
                            AccountNumbers[i] = Console.ReadLine();
                        }
                        break;
                    case Menu.Sort: // Sort account numbers from smallest to largest.
                        for (int i = 0; i < AccountNumbers.Length; i++)
                        {
                            for (int k = i + 1; k < AccountNumbers.Length; k++)
                            {
                                if (AccountNumbers[i] != null & AccountNumbers[k] != null)
                                {
                                    if (int.Parse(AccountNumbers[i]) > int.Parse(AccountNumbers[k]))
                                    {
                                        int temp = int.Parse(AccountNumbers[i]);
                                        AccountNumbers[i] = AccountNumbers[k];
                                        AccountNumbers[k] = temp.ToString();
                                    }
                                }
                            }
                        }
                        break;
                    case Menu.Search: // Check to see if account number exists, and display it.
                        Console.WriteLine("Enter account number to search for.");
                        string search = Console.ReadLine();
                        for (int i = 0; i < AccountNumbers.Length; i++)
                        {
                            if (AccountNumbers[i] == search)
                            {
                                found = true;
                            }
                        }
                        if (found == false)
                        {
                            Console.WriteLine("Account number {0} could not be found.", search);
                        }
                        else if (found == true)
                        {
                            Console.WriteLine("Account number {0} found.", search);
                        }
                        Console.ReadKey();
                        break;
                    case Menu.Update: // Update one of the account numbers.
                        Console.WriteLine("Select which one to update:");
                        for (int i = 0; i < AccountNumbers.Length; i++)
                        {
                            Console.WriteLine("{0}. {1}", i + 1, AccountNumbers[i]);
                        }
                        int updateChoice = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Enter updated account number.");
                        string updatedAccount = Console.ReadLine();
                        AccountNumbers[updateChoice - 1] = updatedAccount;
                        break;
                    case Menu.Delete: // Delete an account number.
                        Console.WriteLine("Select which one to delete:");
                        for (int i = 0; i < AccountNumbers.Length; i++)
                        {
                            Console.WriteLine("{0}. {1}", i + 1, AccountNumbers[i]);
                        }
                        int deleteChoice = int.Parse(Console.ReadLine());
                        if (deleteChoice <= 5 & deleteChoice >= 1)
                        {
                            AccountNumbers[deleteChoice - 1] = null;
                        }
                        break;
                    case Menu.View: // View all account numbers.
                        ViewAccountNumbers(AccountNumbers);
                        break;
                    case Menu.Exit:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }

        private static void ViewAccountNumbers(string[] AccountNumbers) //Array gets passed to method.
        {
            for (int i = 0; i < AccountNumbers.Length; i++)
            {
                if (AccountNumbers[i] != null) // If index is empty it won't display. No open spaces.
                {
                    Console.WriteLine(AccountNumbers[i]);
                }
            }
            Console.ReadKey();
        }
    }
}