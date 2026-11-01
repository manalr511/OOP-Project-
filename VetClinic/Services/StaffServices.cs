using System;
using System.Collections.Generic;
using System.Text;
using VetClinic.Models;
using VetClinic.Repositories;

namespace VetClinic.Services
{
    public class StaffServices
    {
        private StaffRepository repo;
        public StaffServices()
        {
            repo = new StaffRepository();
        }
        //Add Staff
        public void AddStaff(Staff staff)
        {
            repo.SaveInFile(staff);
        }
         //view all staff
        public List<Staff> ViewAllStaff()
        {
            return repo.sLoadAll();
        }

        //delete staff
        public bool DeleteStaff(string sname)
        {
            List<Staff> all = repo.sLoadAll();
            foreach (Staff s in all)
            {
                if (s.GetStaffName() == sname)
                {
                    all.Remove(s);
                    repo.SaveAll(all);
                    return true;
                }
            }
            return false;
        }

        // Staff login
        public bool StaffLogin(string username,string password)
        {
            List<Staff> all = repo.sLoadAll();
            foreach(Staff s in all)
            {
                if(s.GetStaffUsername()==username && s.GetStaffPassword() == password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
