using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class Teacher:Employee 
    {
        //private double _bonus = 2000;
        //private double _netsalary;

       

        public Teacher(string FName, string Lname, DateTime dateofBirth, string address, bool isAlive, double salary,string password)
            : base(FName, Lname, dateofBirth, address, salary,password)
        { 
            

        }

        //public Teacher() : base(null);
        
            /*
            public bool IsAlive { get; internal set; }
    
            public override double NetSalary()
            {
                return Salary + _bonus;
            }
            */

    }
}
