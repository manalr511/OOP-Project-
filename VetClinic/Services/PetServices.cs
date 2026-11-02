using System;
using System.Collections.Generic;
using System.Text;
using VetClinic.Models;
using VetClinic.Repositories;

namespace VetClinic.Services
{
    public class PetServices
    {
        private PetRepository repo;
        public PetServices()
        {
            repo = new PetRepository();   //better approach acc to sir laeeq, in this way every every petservice makes its own repo when created
        }
        //functions
        //addpet
        public void AddPet(Pet pet)
        {
            repo.SaveinFile(pet);
        }
        //view all pets(mean sari list ayegi pets ki)
        public List<Pet> ViewAllPets()
        {
            return repo.LoadAll();
        }
        //search by name
        public Pet SearchByName(string name)
        {
            List<Pet> item = repo.LoadAll();
            foreach(Pet p in item)
            {
                if (p.GetName() == name)
                {
                    return p;
                }
    
            }
            return null;
        }
        //update pet record
        public bool UpdatePet(string oldname,string newname,int age,string breed,string ownername,string disease)
        {
            List<Pet> all = repo.LoadAll();
            foreach(Pet p in all)
            {
                if (p.GetName() == oldname)
                {
                    p.SetName(newname);
                    p.SetAge(age);
                    p.SetBreed(breed);
                    p.SetOwnerName(ownername);
                    p.SetDisease(disease);
                    repo.SaveAll(all);
                    return true;
                }
            }
            return false;
        }
        public bool DeletePet(string name)
        {
            List<Pet> all = repo.LoadAll();
            foreach(Pet p in all)
            {
                if (p.GetName() == name)
                {
                    all.Remove(p);
                    repo.SaveAll(all);
                    return true;
                }
            }
            return false;
        }
        public bool BookAppointment(string name,string date)
        {
            List<Pet> all = repo.LoadAll();
            foreach (Pet p in all)
            {
                if (p.GetName() == name)
                {
                    p.SetAppointmentDate(date);
                    repo.SaveAll(all);
                    return true;
                }
            }
            return false;
        }
        public List<Pet> ViewAppointment()
        {
            List<Pet> all = repo.LoadAll();
            List<Pet> result = new List<Pet>();
            foreach(Pet p in all)
            {
                if (p.GetAppointmentDate() != "")
                {
                    result.Add(p);
                }
            }
            return result;
        }

        public bool AddTreatment(string name,string treatment)
        {
            List<Pet> all = repo.LoadAll();
            foreach(Pet p in all)
            {
                if (p.GetName() == name)
                {
                    p.SetTreatment(treatment);
                    repo.SaveAll(all);
                    return true;
                }
            }
            return false;
        }

        public List<Pet> ViewTreatments()
        {
            List<Pet> all = repo.LoadAll();
            List<Pet> viewvet = new List<Pet>();
            foreach (Pet p in all)
            {
                if (p.GetTreatment() != "")
                {
                    viewvet.Add(p);
                }

            }
            return viewvet;
        }

        public bool AssignVet(string name,string vet)
        {
            List<Pet> all = repo.LoadAll();
            foreach (Pet p in all)
            {
                if (p.GetName() == name)
                {
                    p.SetAssignedVet(vet);
                    repo.SaveAll(all);
                    return true;
                }
            }
            return false;
        }

        public bool CalculateBill(string name,float cfee,float medfee,float treatmentfee)
        {
            List<Pet> all = repo.LoadAll();
            foreach(Pet p in all)
            {
                if (p.GetName() == name)
                {
                    p.SetTotalBill(cfee+medfee+treatmentfee);
                    p.SetVisitCount(p.GetVisitCount()+1);
                    repo.SaveAll(all);
                    return true;

                }
            }
            return false;
        }
        public List<Pet> ViewBillingRecords()
        {
            List<Pet> all = repo.LoadAll();
            List<Pet> result = new List<Pet>();
            foreach (Pet p in all)
            {
                if (p.GetTotalBill() > 0)
                {
                    result.Add(p);
                }
            }
            return result;
        }
        public List<Pet> ViewAssignedVets()
        {
            List<Pet> all = repo.LoadAll();
            List<Pet> viewvet = new List<Pet>();
            foreach(Pet p in all)
            {
                if (p.GetAssignedVet() != "")
                {
                    viewvet.Add(p);
                }
   
            }
            return viewvet;
        }
        public List<Pet> ViewPetByOwner(string name)
        {
            List<Pet> all = repo.LoadAll();
            List<Pet> owner = new List<Pet>();
            foreach(Pet p in all)
            {
                if (p.GetOwnerName()== name)
                {
                    owner.Add(p);
          
                }
            }
            return owner;
            
        }
        public List<Pet> SortByAge()
        {
            List<Pet> all = repo.LoadAll();
            for(int i = 0; i < all.Count-1; i++)  //i goes from start to end of pet list so end is all.count-1
            {
                for (int j = i+1; j <all.Count; j++)  //j should start at the pet after i so its i + 1; j ends at the end of list
                {
                    if (all[i].GetAge() > all[j].GetAge())
                    {
                        Pet pet = all[i];
                        all[i] = all[j];
                        all[j]=pet;

                    }
                }
            }
            return all;
        }

        //min and max range 
        public List<Pet> MinAndMax(int min, int max)
        {
            List<Pet> all = repo.LoadAll();
            List<Pet> minandmax = new List<Pet>();
            foreach(Pet p in all)
            {
                if(p.GetAge()>min && p.GetAge() < max)
                {
                    minandmax.Add(p);
                    p.GetAge();
                }
            }
            return minandmax;
        }


        //partial search
        public List<Pet> SearchByNameP(string nname)
        {
            List<Pet> all = repo.LoadAll();
            List<Pet> namereturn = new List<Pet>();
            foreach (Pet p in all)
            {
                if (p.GetName() == nname )
                {
                    namereturn.Add(p);
                   
          
                }

            }
            return null;

        }

      
   

        

    }
}
