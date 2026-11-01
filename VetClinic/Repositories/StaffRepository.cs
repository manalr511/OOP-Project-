using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using VetClinic.Models;

namespace VetClinic.Repositories
{
    public class StaffRepository
    {
        private readonly string file = "staff.txt";
        //default constrcutor
        public StaffRepository()
        {

        }
        //saving data
        public void SaveInFile(Staff staff)
        {
            using (StreamWriter stream = new StreamWriter(file, true))
            {
                stream.WriteLine(staff.ToString());
            }
        }
        //for updation
        public void SaveAll(List<Staff> staff)
        {
            using (StreamWriter stream = new StreamWriter(file))
            {
                foreach (Staff s in staff)
                {
                    stream.WriteLine(s.ToString());
                }
            }
        }
        //loading data
        public List<Staff> sLoadAll()
        {
            List<Staff> sstaff = new List<Staff>();
            if (!File.Exists(file))
            {
                return sstaff;
            }
            string line;
            using(StreamReader stream = new StreamReader(file)){
                while ((line = stream.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string staffname = parts[0];
                    string staffrole = parts[1];
                    string susername = parts[2];
                    string spassword = parts[3];
                    Staff s = new Staff(staffname,staffrole,susername,spassword);
                    sstaff.Add(s);
                }
            }
            return sstaff;
        }
    }

}
