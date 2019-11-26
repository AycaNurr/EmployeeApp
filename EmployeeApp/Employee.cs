using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public abstract class Employee
    {

        
        public Employee(string firstName, string lastName, DateTime dateofBirth, string address, double salary, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            DateofBirth = dateofBirth;
            Address = address;
            Password = password;
            //IsAlive = isAlive;
            //Salary = salary;


        }

   
        public Employee(string firstName, double salary)
        {
         FirstName=Firstname;
         Salary = salary;

        }
        protected Employee() { }
        public string LasttName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Address { get; set; }
        //public bool isAlive { get; set; }
        //public double Salary { get; set; }
        public string Password { get; set; }
        //public double Salary { get; set; }
        public string FullName
            {
            get { return $"{FirstName} {LastName}"; }
            }
        public string Age
        {
            get
            {

                TimeSpan ts = DateTime.Now.Subtract(DateofBirth);
                int age = ts.Days / 365;
                return $"(Age)";

            }
        }
             public virtual double NetSalary()
        {
            return Salary;
        }
        
        public double Salary { get; }
        public string Firstname { get; }
        public virtual double CommuteDistance()
        {
            return 5;
        }

    }
    

}
