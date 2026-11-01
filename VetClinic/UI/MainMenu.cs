using System;
using System.Collections.Generic;
using System.Text;
using VetClinic.Models;
using VetClinic.Services;

namespace VetClinic.UI
{
    public class MainMenu
    {
        private PetServices service;
        private StaffServices services;
        
        public MainMenu()
        {
            service = new PetServices();
            services = new StaffServices();
        }

        public void start()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("========= MNL VETERINARY CLINIC ========");
                Console.WriteLine();
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Staff");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.Write("Choose Option No: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    Console.Write("Enter Admin Username: ");
                    string adminUser = Console.ReadLine();
                    Console.Write("Enter Admin Password: ");
                    string adminPass = Console.ReadLine();
                    if (adminUser == "admin" && adminPass == "admin123")
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome to Admin Menu");
                        AdminMenu am= new AdminMenu();
                        am.show();


                    }
                    else
                    {
                        Console.WriteLine("Wrong login details");
                    }
                    Console.ReadKey();
   

                }
                else if (choice == "2")
                {
                    Console.Clear();
                    Console.Write("Enter Staff Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter Staff Password: ");
                    string password = Console.ReadLine();
                    bool loggedIn = services.StaffLogin(username,password);
                    if (loggedIn)
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome To Staff Menu");
                        StaffMenu sm = new StaffMenu();
                        sm.show();

                    }
                    else
                    {
                        Console.WriteLine("Wrong login details");
                    }
                    Console.ReadKey();
             
                }
                else if (choice == "3")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Invalid Option,Try Again");
                }

            }
        }
    }
}
