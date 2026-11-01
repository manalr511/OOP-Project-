using System;
using System.Collections.Generic;
using VetClinic.Models;
using VetClinic.Services;

namespace VetClinic.UI
{
    public class StaffMenu
    {
        private PetServices service;

        public StaffMenu()
        {
            service = new PetServices();
        }

        public void show()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Staff Menu");
                Console.WriteLine();
                Console.WriteLine("1. Add Pet Record");
                Console.WriteLine("2. View All Pets");
                Console.WriteLine("3. Search Pet");
                Console.WriteLine("4. Update Pet Record");
                Console.WriteLine("5. Book Appointment");
                Console.WriteLine("6. Add Treatment Record");
                Console.WriteLine("7. Generate Bill");
                Console.WriteLine("8. Assign Patient To Vet");
                Console.WriteLine("9. View Pets By Owner Name");
                Console.WriteLine("10. View Pets According To Age");
                Console.WriteLine("11. Logout");
                Console.WriteLine();
                Console.Write("Choose Option No: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    Console.Write("Enter pet name: ");
                    string name = Console.ReadLine();
                    Pet exists = service.SearchByName(name);
                    if (exists != null)
                    {
                        Console.WriteLine("A pet with this name already exists");
                    }
                    else
                    {
                        Pet p = new Pet();
                        p.SetName(name);
                        Console.Write("Enter age: ");
                        p.SetAge(int.Parse(Console.ReadLine()));
                        Console.Write("Enter breed: ");
                        p.SetBreed(Console.ReadLine());
                        Console.Write("Enter owner name: ");
                        p.SetOwnerName(Console.ReadLine());
                        Console.Write("Enter disease: ");
                        p.SetDisease(Console.ReadLine());
                        service.AddPet(p);
                        Console.WriteLine("Pet added");
                    }
                    Console.ReadKey();
                }
                else if (choice == "2")
                {
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
                else if (choice == "3")
                {
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
                else if (choice == "4")
                {
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
                else if (choice == "5")
                {
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
                        Console.Write("Enter appointment date: ");
                        string date = Console.ReadLine();
                        service.BookAppointment(name, date);
                        Console.WriteLine("Appointment booked");
                    }
                    Console.ReadKey();
                }
                else if (choice == "6")
                {
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
                        Console.Write("Enter treatment: ");
                        string treatment = Console.ReadLine();
                        service.AddTreatment(name, treatment);
                        Console.WriteLine("Treatment added");
                    }
                    Console.ReadKey();
                }
                else if (choice == "7")
                {
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
                        Console.Write("Enter consultation fee: ");
                        float cfee = float.Parse(Console.ReadLine());
                        Console.Write("Enter medicine fee: ");
                        float medfee = float.Parse(Console.ReadLine());
                        Console.Write("Enter treatment fee: ");
                        float treatmentfee = float.Parse(Console.ReadLine());
                        bool billed = service.CalculateBill(name, cfee, medfee, treatmentfee);
                        if (billed)
                        {
                            Console.WriteLine("---------- MNL VETERINARY CLINIC ----------");
                            Console.WriteLine("Name of Pet: " + name);
                            Console.WriteLine("1. Consultation Fee: " + cfee);
                            Console.WriteLine("2. Medication Charges: " + medfee);
                            Console.WriteLine("3. Treatment Charges: " + treatmentfee);
                            Console.WriteLine("-------------------------------------------");
                            Console.WriteLine("Total Bill: " + (cfee + medfee + treatmentfee));
                            Console.WriteLine("-------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("Bill not saved");
                        }
                    }
                    Console.ReadKey();
                }
                else if (choice == "8")
                {
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
                        Console.Write("Enter vet name: ");
                        string vet = Console.ReadLine();
                        service.AssignVet(name, vet);
                        Console.WriteLine("Vet assigned");
                    }
                    Console.ReadKey();
                }
                else if (choice == "9")
                {
                    Console.Clear();
                    Console.Write("Enter owner name: ");
                    string owner = Console.ReadLine();
                    List<Pet> list = service.ViewPetByOwner(owner);
                    if (list.Count == 0)
                    {
                        Console.WriteLine("No pet found for this owner");
                    }
                    else
                    {
                        foreach (Pet p in list)
                        {
                            Console.WriteLine(p.GetName() + " (Age: " + p.GetAge() + ", Breed: " + p.GetBreed() + ", Disease: " + p.GetDisease() + ")");
                        }
                    }
                    Console.ReadKey();
                }
                else if (choice == "10")
                {
                    Console.Clear();
                    List<Pet> list = service.SortByAge();
                    if (list.Count == 0)
                    {
                        Console.WriteLine("No pets found");
                    }
                    else
                    {
                        Console.WriteLine("Pets sorted by age:");
                        foreach (Pet p in list)
                        {
                            Console.WriteLine(p.GetName() + " | Age: " + p.GetAge());
                        }
                    }
                    Console.ReadKey();
                }
                else if (choice == "11")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Wrong option");
                    Console.ReadKey();
                }
            }
        }
    }
}
