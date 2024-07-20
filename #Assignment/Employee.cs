using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _Assignment
{
    public enum Gender 
    {
        M , F 
    }
    [Flags]
    public enum Privilege:byte 
    {
       guest = 1 , developer = 2 ,secrtary = 4 , DBA = 8  
    }
    public class Employee
    {
        private int _id { set; get; }
        private string _name { set; get; } 
        private string _securityLevel { set; get; } 
        private decimal _salary;
        private int _day;
        private int _month;
        private int _year;
        private Gender _gender;
        private Privilege _privilage;
        #region properties
        public decimal _Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public Gender _Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        #endregion
        #region contructor
        public Employee(int id, string name, string securityLevel, decimal salary, Gender gender, Privilege privilege)
        {
            _id = id;
            _name = name;
            _securityLevel = securityLevel;
            _salary = salary;
            _gender = gender;
            _privilage = privilege;
        }

        #endregion

        #region Methods
        public void setDate(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        } 
        public string getDate()
        {
            return $"{_day}/{_month}/{_year}";

        }
        public override string ToString()
        {
            return $"the employee salary is {_Salary:c}";
        }

        #endregion


    }

}
