using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Xml.Linq;
using VetClinic.Models;
using VetClinic.Services;

namespace VetClinic.UI
{
    public class AdminMenu
    {
        private PetServices service;
        private StaffServices services;

        public AdminMenu()
        {
            service = new PetServices();
            services = new StaffServices();
        }

        public void show()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Admin Menu");
                Console.WriteLine();
                Console.WriteLine("1. View All Pets");
                Console.WriteLine("2. Search Pet");
                Console.WriteLine("3. Update Pet Record");
                Console.WriteLine("4. Delete Pet Record");
                Console.WriteLine("5. View Appointments");
                Console.WriteLine("6. View Treatment Records");
                Console.WriteLine("7. View Billing Records");
                Console.WriteLine("8. View Assigned Vets");
                Console.WriteLine("9. View History Logs");
                Console.WriteLine("10. Manage Staff");
                Console.WriteLine("11. namesearch,age range, vet search");
                Console.WriteLine("12. Logout");
                string choice = Console.ReadLine();
                if (choice == "1")
                {  //view all pets
                    Console.Clear();
                    List<Pet> all = service.ViewAllPets();
                    if (all.Count == 0)
                    {
                        Console.WriteLine("No pets found");
                    }
                    else
                    {
                        foreach (Pet item in all)
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                    Console.ReadKey();
                }
                else if (choice == "2")
                { // search pet by name
                    Console.Clear();
                    Console.Write("Enter pet name: ");
                    string name = Console.ReadLine();
                    Pet found = service.SearchByName(name);
                    if (found == null)
                    {
                        Console.WriteLine("Pet not found");
                    }
                    else
                    {
                        Console.WriteLine(found.ToString());
                    }
                    Console.ReadKey();
                }
                else if (choice == "3")
                {   //update pet
                    Console.Clear();
                    Console.Write("Enter name of pet to update: ");
                    string oldName = Console.ReadLine();
                    Pet old = service.SearchByName(oldName);
                    if (old == null)
                    {
                        Console.WriteLine("Pet not found");
                    }
                    else
                    {
                        Console.WriteLine("Old record: " + old.ToString());
                        Console.Write("New name: ");
                        string newName = Console.ReadLine();
                        Console.Write("New age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("New breed: ");
                        string breed = Console.ReadLine();
                        Console.Write("New owner name: ");
                        string ownerName = Console.ReadLine();
                        Console.Write("New disease: ");
                        string disease = Console.ReadLine();
                        bool updated = service.UpdatePet(oldName, newName, age, breed, ownerName, disease);
                        if (updated)
                        {
                            Console.WriteLine("Pet updated");
                        }
                        else
                        {
                            Console.WriteLine("Update failed");
                        }
                    }
                    Console.ReadKey();
                }
                else if (choice == "4")
                {   //delete pet
                    Console.Clear();
                    Console.Write("Enter name of pet to delete: ");
                    string name = Console.ReadLine();
                    bool deleted = service.DeletePet(name);
                    if (deleted)
                    {
                        Console.WriteLine("Pet deleted");
                    }
                    else
                    {
                        Console.WriteLine("Pet not found");
                    }
                    Console.ReadKey();
                }
                else if (choice == "5")
                {   //view appointment
                    Console.Clear();
                    List<Pet> list = service.ViewAppointment();
                    if (list.Count == 0)
                    {
                        Console.WriteLine("No appointments found");
                    }
                    else
                    {
                        foreach (Pet p in list)
                        {
                            Console.WriteLine(p.GetName() + " | " + p.GetOwnerName() + " | " + p.GetAppointmentDate());
                        }
                    }
                    Console.ReadKey();
                }
                else if (choice == "6")
                {  //view treatment
                    Console.Clear();
                    List<Pet> list = service.ViewTreatments();
                    if (list.Count == 0)
                    {
                        Console.WriteLine("No treatment records found");
                    }
                    else
                    {
                        foreach (Pet p in list)
                        {
                            Console.WriteLine(p.GetName() + " | " + p.GetTreatment());
                        }
                    }
                    Console.ReadKey();
                }
                else if (choice == "7")
                {
                    //view billing
                    Console.Clear();
                    List<Pet> list = service.ViewBillingRecords();
                    if (list.Count == 0)
                    {
                        Console.WriteLine("No billing records found");
                    }
                    else
                    {
                        foreach (Pet p in list)
                        {
                            Console.WriteLine(p.GetName() + " | " + p.GetOwnerName() + " | Bill: " + p.GetTotalBill() + " | Visits: " + p.GetVisitCount());
                        }
                    }
                    Console.ReadKey();
                }
                else if (choice == "8")
                {
                    // View assign vet
                    Console.Clear();
                    List<Pet> list = service.ViewAssignedVets();
                    if (list.Count == 0)
                    {
                        Console.WriteLine("No pets assigned to a vet");
                    }
                    else
                    {
                        foreach (Pet p in list)
                        {
                            Console.WriteLine(p.GetName() + " | " + p.GetAssignedVet());
                        }
                    }
                    Console.ReadKey();
                }
                else if (choice == "9")
                {
                    //history
                    Console.Clear();
                    List<Pet> list = service.ViewAllPets();
                    if (list.Count == 0)
                    {
                        Console.WriteLine("No history records found");
                    }
                    else
                    {
                        foreach (Pet p in list)
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("Pet Name     : " + p.GetName());
                            Console.WriteLine("Owner Name   : " + p.GetOwnerName());
                            Console.WriteLine("Breed        : " + p.GetBreed());
                            Console.WriteLine("Disease      : " + p.GetDisease());
                            Console.WriteLine("Assigned Vet : " + p.GetAssignedVet());
                            Console.WriteLine("Treatment    : " + p.GetTreatment());
                            Console.WriteLine("Appointment  : " + p.GetAppointmentDate());
                            Console.WriteLine("Total Bill   : " + p.GetTotalBill());
                            Console.WriteLine("Visit Count  : " + p.GetVisitCount());
                        }
                    }
                    Console.ReadKey();
                }
                else if (choice == "10")
                {
                    Console.Clear();
                    bool staffRunning = true;
                    while (staffRunning)
                    {
                        Console.Clear();
                        Console.WriteLine("Manage Staff");
                        Console.WriteLine("1. Add Staff");
                        Console.WriteLine("2. View All Staff");
                        Console.WriteLine("3. Delete Staff");
                        Console.WriteLine("4. Back");
                        Console.Write("Choose Option No: ");
                        string staffChoice = Console.ReadLine();

                        if (staffChoice == "1")
                        {
                            Console.Clear();
                            Staff s = new Staff();
                            Console.Write("Name: ");
                            s.SetStaffName(Console.ReadLine());
                            Console.Write("Role: ");
                            s.SetStaffRole(Console.ReadLine());
                            Console.Write("Username: ");
                            s.SetStaffUsername(Console.ReadLine());
                            Console.Write("Password: ");
                            s.SetStaffPassword(Console.ReadLine());
                            services.AddStaff(s);
                            Console.WriteLine("Staff added");
                            Console.ReadKey();
                        }
                        else if (staffChoice == "2")
                        {
                            Console.Clear();
                            List<Staff> staffList = services.ViewAllStaff();
                            if (staffList.Count == 0)
                            {
                                Console.WriteLine("No staff found");
                            }
                            else
                            {
                                foreach (Staff st in staffList)
                                {
                                    Console.WriteLine(st.ToString());
                                }
                            }
                            Console.ReadKey();
                        }
                        else if (staffChoice == "3")
                        {
                            Console.Clear();
                            Console.Write("Enter username to delete: ");
                            string user = Console.ReadLine();
                            bool removed = services.DeleteStaff(user);
                            if (removed)
                            {
                                Console.WriteLine("Staff deleted");
                            }
                            else
                            {
                                Console.WriteLine("Staff not found");
                            }
                            Console.ReadKey();
                        }
                        else if (staffChoice == "4")
                        {
                            staffRunning = false;
                        }
                        else
                        {
                            Console.WriteLine("Wrong option");
                            Console.ReadKey();
                        }
                    }
                }else if (choice=="11")
                {
                    Console.Clear();

                    Console.WriteLine("enter name to search: ");
                    string nname = Console.ReadLine();

                    Console.WriteLine("Enter lowest value: ");
                    int min = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter max value: ");
                    int max = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter vet name");
                    string vname = Console.ReadLine();

                    //partial search 
                    List<Pet> pp = service.SearchByNameP(nname);
                    Pet found = service.SearchByName(nname);
                    if (found == null)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine(found.ToString());
                    }



                    List<Pet> list = service.ViewAssignedVets();
                    //minmax
                    List<Pet> all = service.MinAndMax(min, max);
                    if (list.Count == 0)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        foreach (Pet item in all)
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                   
                    //exactmatch
                    List<Pet> llist = service.ViewAssignedVets();
                    if (list.Count == 0)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        foreach (Pet p in list)
                        {
                            Console.WriteLine(p.GetName() + " | " + p.GetAssignedVet());
                        }
                    }
                    Console.ReadKey();

                }
                else if (choice == "12")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Wrong option");
                    Console.ReadKey();
                }
                Console.ReadKey();
            }
        }
    }
}
