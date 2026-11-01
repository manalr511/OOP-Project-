using System;
using System.Collections.Generic;
using System.Text;

namespace VetClinic.Models
{
   public class Staff
    {
        private string StaffName { get;set; }
        private string StaffRole { get; set; }
        private string StaffUsername { get; set; }
        private string StaffPassword { get; set; }
        //default
        public Staff()
        {

        }
        //parametrized
        public Staff(string sname,string srole,string susername, string spassword)
        {

            StaffName = sname;
            StaffRole = srole;
            StaffUsername = susername;
            StaffPassword = spassword;
        }

        public void SetStaffName(string staffname) {
            StaffName = staffname;
        }
        public string GetStaffName()
        {
            return StaffName;
        }
        public void SetStaffRole(string staffrole)
        {
            StaffRole = staffrole;
        }
        public string GetStaffRole()
        {
            return StaffRole;
        }
        public void SetStaffUsername(string susername)
        {
            StaffUsername = susername;
        }
        public string GetStaffUsername()
        {
            return StaffUsername;
        }
        public void SetStaffPassword(string spassword)
        {
            StaffPassword = spassword;
        }
        public string GetStaffPassword()
        {
            return StaffPassword;
        }
        public override string ToString()
        {
            return $"{StaffName},{StaffRole},{StaffUsername},{StaffPassword}";
        }

    }
}
