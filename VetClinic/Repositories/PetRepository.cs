using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Linq;
using VetClinic.Models;

namespace VetClinic.Repositories
{
    public class PetRepository
    {
       private readonly string file = "pet.txt";
        //default
        public PetRepository()
        {

        }
        //save data in file i passed class=Pet and object=pet it will add each pet into file
            public void SaveinFile(Pet pet)
        {
            using(StreamWriter stream =new StreamWriter(file,true))
            {
                stream.WriteLine(pet.ToString());
            }
        }
        //this function is used for updation by update and delete function etc it removes previous data
        public void SaveAll(List<Pet> pets)
        {
            using (StreamWriter stream=new StreamWriter(file)) //opens file in overwrite form prev data is erased
            {
                foreach(Pet p in pets)
                {
                    stream.WriteLine(p.ToString());
                }
            }
        }
        //loading data into list then into object
        public List<Pet> LoadAll()
        {
            List<Pet> pets = new List<Pet>();
            if (!File.Exists(file))
            {
                return pets;
            }
            string line;
            using(StreamReader stream = new StreamReader(file))
            {
                while((line=stream.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string breed = parts[2];
                    string ownername = parts[3];
                    string disease = parts[4];
                    string appointmentdate = parts[5];
                    string treatment = parts[6];
                    float totalbill = float.Parse(parts[7]);
                    int visitcount = int.Parse(parts[8]);
                    string assignedvet = parts[9];
                    Pet p = new Pet(name, age, breed, ownername, disease, appointmentdate, treatment, totalbill, visitcount, assignedvet);
                    pets.Add(p);
                }

            }
            return pets;
        }
    }
}
