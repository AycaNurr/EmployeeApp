using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public static class EmployeeModel
    {
        public static List<Employee> EmployeesList { get; set; } = new List<Employee>
        {
          
            new Teacher("user1" , "hansen" ,new DateTime(1990,1,1),"Copenhagen", true , 4000,"123"),
            new Teacher("user2" , "Jackson" ,new DateTime(1995,7,5),"Roskilde", true , 4000,"123"),
            
        };
        /// <summary>
        /// This method tries to find an employee by name in the EmployeeList
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>

        public static Employee GetEmployee(string name)
            {
                var employee = EmployeesList.FirstOrDefault(list=>list.Firstname==name);
                return employee;
            }
        /*
        public static Employee GetEmployee(int index)
        {
        
            var employee = EmployeesList[index];
            return employee;
            Tek satırda yazmak istersek:
            return EmployeesList[index];
        }
           */
        public static Employee GetEmployee(int index) => EmployeesList[index];


    }

}
