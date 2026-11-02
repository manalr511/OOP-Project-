using System;
using System.Collections.Generic;
using System.Text;

namespace VetClinic.Models
{
    public class Pet
    {   //attributes for pet class
        private string Name { get; set; }
        private int Age { get; set; }
        private string Breed { get; set; }
        private string OwnerName { get; set; }
        private string Disease { get; set; }
        private string AppointmentDate { get; set; }
        private string Treatment { get; set; }
        private float TotalBill { get; set; }
        private int VisitCount { get; set; }
        private string AssignedVet { get; set; }

        //default constructor
        public Pet()
        {

        }
        //parametrized
        public Pet(string name,int age,string breed,string ownername,string disease,string appointmentdate,string treatment,float totalbill,int visitcount,string assignedvet)
        {
            Name = name;
            Age = age;
            Breed = breed;
            OwnerName = ownername;
            Disease = disease;
            AppointmentDate = appointmentdate;
            Treatment = treatment;
            TotalBill = totalbill;
            VisitCount = visitcount;
            AssignedVet = assignedvet;
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetAge(int age)
        {
            Age = age;
        }
        public int GetAge()
        {
            return Age;
        }
        public void SetBreed(string breed)
        {
            Breed=breed;
        }
        public string GetBreed()
        {
            return Breed;
        }
        public void SetOwnerName(string ownername)
        {
            OwnerName = ownername;
        }
        public string GetOwnerName()
        {
            return OwnerName;
        }
        public void SetDisease(string disease)
        {
            Disease=disease;
        }
        public string GetDisease()
        {
            return Disease;
        }

        public void SetAppointmentDate(string appointmentdate)
        {
            AppointmentDate = appointmentdate;
        }
        public string GetAppointmentDate()
        {
            return AppointmentDate;
        }
        public void SetTreatment(string treatment)
        {
            Treatment = treatment;
        }
        public string GetTreatment()
        {
            return Treatment;
        }
        public void SetTotalBill(float totalbill)
        {
            TotalBill = totalbill;
        }
        public float GetTotalBill()
        {
            return TotalBill;
        }

        public void SetVisitCount(int visitcount)
        {
            VisitCount = visitcount;
        }
        public int GetVisitCount()
        {
            return VisitCount;
        }

        public void SetAssignedVet(string assignedvet)
        {
            AssignedVet = assignedvet;
        }
        public string GetAssignedVet()
        {
            return AssignedVet;
        }

        public override string ToString()
        {
            return $"{Name},{Age},{Breed},{OwnerName},{Disease},{AppointmentDate},{Treatment},{TotalBill},{VisitCount},{AssignedVet}";
        }

        // i can use this incase to print only age same goes from partial search and and category one rn not needed as i have to print whole record
        //public string tostring()
        //{
        //    return $"{Age}";
        //}



    }
}
