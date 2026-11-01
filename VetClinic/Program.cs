using System.ComponentModel.Design;
using System.Globalization;
using VetClinic.Models;
using VetClinic.Repositories;
using VetClinic.Services;
using VetClinic.UI;
MainMenu mm = new MainMenu();
mm.start();
AdminMenu am = new AdminMenu();
am.show();
StaffMenu sm = new StaffMenu();
sm.show();


















// FUNCTION TESTING
//Staff s = new Staff();
//StaffServices ss = new StaffServices();
//PetServices ps = new PetServices(); //iske thru we can access anything from service layer
//Pet p = new Pet();
//Console.WriteLine("enter pet name ");          //line 7-14 adds the pet
//p.SetName(Console.ReadLine());
//Console.WriteLine("enter pet age ");
//p.SetAge(int.Parse(Console.ReadLine()));
//Console.WriteLine("enter pet breed ");
//p.SetBreed(Console.ReadLine());
//ps.AddPet(p);
//Console.WriteLine("enter oldname of pet");/
//string oldname = Console.ReadLine();
//List<Pet> all = ps.ViewAllPets(); //returns all pets in a list;
//foreach(Pet item in all)   //item is variable name to access
//{
//   Console.WriteLine(item.ToString());
//}
//Console.WriteLine("enter pet newname ");          //line 7-14 adds the pet
//string newname=Console.ReadLine();
//Console.WriteLine("enter pet age ");
//int age=int.Parse(Console.ReadLine());
//Console.WriteLine("enter pet breed ");
//string breed=Console.ReadLine();
//Console.WriteLine("enter pet ownername");
//string ownername=Console.ReadLine();
//Console.WriteLine("enter pet disease ");
//string disease=Console.ReadLine();
//bool updated = ps.UpdatePet(oldname, newname, age, breed, ownername, disease);
//if (updated)
//{
//   Console.WriteLine("updated");
//}
//else
//{
//   Console.WriteLine("Pet not found");
//}
//DELETE CHECK
//List<Pet> all = ps.ViewAllPets();
//Console.WriteLine("enter pet to delete: ");
//string name = Console.ReadLine();
//foreach(Pet item in all)
//{
//   Console.WriteLine(item.ToString());
//}
//bool delete = ps.DeletePet(name);
//if (delete)
//{
//  Console.WriteLine("deleted");
//} else {
//  Console.WriteLine("pet not found"); 
//    }


//book appointment
//List<Pet> all = ps.ViewAllPets();
//Console.WriteLine("enter name for appointment");
//string name = Console.ReadLine();
//Console.WriteLine("enter date for appointment (mm-dd-yy)");
//string date = Console.ReadLine();
//bool appointment = ps.BookAppointment(name, date);
//if (appointment)
//{
//    Console.WriteLine("Booked");
//}
//else
//{
//  Console.WriteLine("pet not found");
//}

//view appintment
//List<Pet> all = ps.ViewAppointment();
//foreach(Pet item in all)
//{
//  Console.WriteLine(item.ToString());
//}

//Add treatmet;

//Console.WriteLine("enter pet name to add treatment for");
//string name = Console.ReadLine();
//Pet searchbyname = ps.SearchByName(name);
//if (searchbyname!=null)
//{
//  Console.WriteLine("Enter treatment");
//string treatment = Console.ReadLine();
//bool addtreatment = ps.AddTreatment(name, treatment);
//Console.WriteLine("Treatment added: "+ addtreatment);
//}
//else
//{
//  Console.WriteLine("Pet not found");
//}
//List<Pet> item = ps.ViewAllPets();
//foreach(Pet pp in item)
//{
//  Console.WriteLine(pp.ToString());
//}
//Console.WriteLine("Enter pet name to add vet for: ");
//string name = Console.ReadLine();
//Pet seachbyname = ps.SearchByName(name);
//if (seachbyname != null)
//{
//Console.WriteLine("enter vet name: ");
//string vet = Console.ReadLine();
//bool assignvet = ps.AssignVet(name, vet);
//Console.WriteLine("Vet added");
//}
//else
//{
// Console.WriteLine("Pet not found");
//}
//Console.WriteLine("enter name of pet to generate bill : ");
//string name = Console.ReadLine();
//Pet searchbyname = ps.SearchByName(name);
//if (searchbyname != null)
//{
// Console.WriteLine("Enter Consultation Fee: ");
//  float cfee = float.Parse(Console.ReadLine());
//  Console.WriteLine("Enter medicine Fee: ");
//  float medfee = float.Parse(Console.ReadLine());
// Console.WriteLine("Enter treatment Fee: ");
// float treatmentfee = float.Parse(Console.ReadLine());
// bool bill = ps.CalculateBill(name, cfee, medfee, treatmentfee);
// Console.WriteLine("Bill Calculated: " + (cfee+medfee+treatmentfee));

// Console.WriteLine("------------------MNL VETERINARY CLINIC--------------------");
//  Console.WriteLine("-----------------------------------------------------------");
//  Console.WriteLine("------------------TOTAL BILLING DETAILS--------------------");
//  Console.WriteLine("Name of Pet: "+ name);
//  Console.WriteLine("1. Consultation Fee Charges: "+ cfee);
//    Console.WriteLine("2. Medication Charges: "+ medfee);
// Console.WriteLine("3. Treatment Charges: "+ treatmentfee );
//   Console.WriteLine("-----------------------------------------------------------");
//Console.WriteLine("ToTal Bill for "+name+":" + (cfee + medfee + treatmentfee));
//Console.WriteLine("-----------------------------------------------------------");
//  Console.WriteLine("---------Thankyou For Visting MNL Veterinary Clinic--------");


//}
//else
//{
//    Console.WriteLine("No pet found in record");
//}
//Console.WriteLine("Enter pet name to view Billing Record: ");
//string nname = Console.ReadLine();
//Pet searchbynname = ps.SearchByName(name);
//if (searchbyname != null)
//{
//    List<Pet> viewbillrec= ps.ViewBill(name);

//     if (viewbillrec.Count == 0)
//    {
//        Console.WriteLine("no billing record found");
//    }
//    else
//    {
//        foreach (Pet bill in viewbillrec)
//        {
//            Console.WriteLine(bill.ToString());
//        }
//    }
//}
//else
//{
//    Console.WriteLine("Pet not found");
//}

//List<Pet> all = ps.ViewAssignedVets();
//if (all.Count == 0)
//{
//    Console.WriteLine("no pet found");
//}
//else
//{
//    foreach (Pet item in all)
//    {
//        Console.WriteLine(item.ToString());
//    }
//}

//pet by owner
//Console.WriteLine("enter owner name: ");
//string name = Console.ReadLine();
//List<Pet> petbyowner = ps.ViewPetByOwner(name);
//if (petbyowner.Count==0)
//{
//    Console.WriteLine("no pet found");
//}
//else
//{
//    foreach (Pet item in petbyowner)
//    {
//        Console.WriteLine(item.ToString());
//    }
//}

//List<Pet> all = ps.SortByAge();
//if (all.Count == 0)
//{
//    Console.WriteLine("no pet found");
//}
//else
//{
//    foreach(Pet item in all)
//    {
//        Console.WriteLine(item.ToString());
//    }
//}

//STAFFFFFFFFFFFFFFFFFF
//Console.WriteLine("enter staff name: ");          //line 7-14 adds the pet
//s.SetStaffName(Console.ReadLine());
//Console.WriteLine("enter staff role ");
//s.SetStaffRole(Console.ReadLine());
//Console.WriteLine("enter staff username: ");
//s.SetStaffUsername(Console.ReadLine());
//Console.WriteLine("enter staff password: ");
//s.SetStaffPassword(Console.ReadLine());
//ss.AddStaff(s);
//Console.WriteLine("staff added");

//view staff
//List<Staff> all = ss.ViewAllStaff(); //returns all staff in a list;
//foreach (Staff member in all)   //item is variable name to access
//{
//    Console.WriteLine(member.ToString());
//}


//delete staff
//Console.WriteLine("enter staff to delete: ");
//string sname = Console.ReadLine();
//bool delete = ss.DeleteStaff(sname);
//if (delete)
//{
//    Console.WriteLine("staff deleted");
//}
//else
//{
//    Console.WriteLine("staff not found");
//}

//

//login staff
//Console.WriteLine("enter staff username: ");
//string username = Console.ReadLine();
//Console.WriteLine("enter staff password: ");
//string password = Console.ReadLine();
//bool login = ss.StaffLogin(username, password);
//if (login)
//{
//    Console.WriteLine("congratulation,you are logged in");
//}
//else
//{
//    Console.WriteLine("wrong username/password");
//}
