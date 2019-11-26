using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class SecretarialStaff : Employee
    {
        public SecretarialStaff(string firstname, double salary)
            : base(firstname, salary)
        {

        }

        public SecretarialStaff(string firstName, string lastName, DateTime dateofBirth, string address, string password, int id, double salary)
            : base(firstName, lastName, dateofBirth, address, salary, password) { }

        
        public override double CommuteDistance()
        {
            //throw new NotImplementedException();
            //this code needs to be find
            //e.g. calculate distance base on address and then return 
            return 25;
        }

        public double Divide(double dividend, double divisor)
        {
            if (dividend == 0)
            {
                throw new DivideByZeroException();
            }
            return dividend / divisor;
        }
        public string TwitterAccount(string account)
        {
            if (!account.Contains("@"))
            {
                throw new Exception();
            }
            return account;
        }

    }  
}
