using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Employee teacher = EmployeeModel.EmployeesList[1];
            string firstname = teacher.FirstName;
            */
            Employee teacher = EmployeeModel.GetEmployee("user1");
            string result = teacher.Address;
            Console.WriteLine(result);
            Employee employee2 = EmployeeModel.GetEmployee(1);
            string result2= employee2.FullName;
            Console.WriteLine(result2);

            Console.ReadKey();




            /*

             //Console.WriteLine(new Employee(firstName: "ALLEN")); 

             Teacher employee = new Teacher(FName: "ALLEN", Lname: "Hansen", new DateTime(year: 1990, month: 7, day: 1), address: "Roskilde", isAlive: true, salary:3000.0,password:"abcd");

             //Teacher teacher = new Teacher(FName: "ALLEN", Lname: "Hansen", new DateTime(year: 1990, month: 7, day: 1), address: "Roskilde", isAlive: true, salary: 3000.0, password: "abcd");
             SecretarialStaff secretary = new SecretarialStaff("Jetta", 3000);

             //setting firstName property
             //Employee.LasttName = "Müller";
             // employee.FullName = "";

             //get FirstName property
             //string Firstname = employee.FirstName;
             //Console.WriteLine($"First Name:{Employee.FirstName} Last Name;{Employee.LastName }is alive:{Employee.isAlive})
             //Console.WriteLine($"Full Name:{employee.FullName }Last Name;{employee.LastName }is alive:{employee.isAlive} Age:(employee.Age))

             Console.WriteLine($"Full name:{teacher.FullName} Is Alive: {teacher.IsAlive} Age:{teacher.Age} Salary: {teacher.Salary}");
             Console.WriteLine("Teacher's salary raised by5000");
             Console.WriteLine($"{ teacher.FullName} salary is now{teacher.Salary}");
             Console.WriteLine($"{ secretary.FullName} net salary is now{secretary.NetSalary()}");
             Console.WriteLine($"{ secretary.FullName} net salary is now{teacher.NetSalary()}");


             try
             {
                double distance = secretary.CommuteDistance(); 
             }
             catch (NotImplementedException e) e:
             {
                 Console.WriteLine("I was drunk I did not implement this method.");
                 //throw;
             }

             double distance = secretary.CommuteDistance();
             Console.WriteLine($"distance{distance}");
             try
             {
              double result = secretary.Divide(500, 0);
                 Console.WriteLine(result);
             }
             catch (DivideByZeroException)
             {
                 Console.WriteLine("The divisor must be greater than 0");
             }

             //------------------------------------------------------------------

             try
             {
                 Console.WriteLine(secretary.TwitterAccount(account: "@sec"));
             }
             catch(Exception e)
             {
                 Console.WriteLine("Twitter account must contain @");
             }
             var employee2 = EmployeeModel.EmployeesList.FirstOrDefault(data => data.Firstname == "users" && data.Password == "pass");

             if (employee2 == null)
                 Console.WriteLine("The user does not exist");
             else
             {
                 Console.WriteLine("welcome your are logged in");
             }
             Console.ReadKey();
             */
            /*
           var teacher = EmployeeModel.EmployeesList[2];

           string age = teacher.Age;
           Console.WriteLine($"{teacher.FullName }+ {teacher.Age } + {teacher.Salary}");// $"İs Alive:{teacher.IsAlive }" 
            */








        }
    }
}


/*
         --create list instance then use "add" method of list 
         List<string> fruits1 = new List<string> ();

         fruits1.Add("orange");
         fruits1.Add("banana");

         --using array...Buradaki iki arrayın boyutunu belirtiyor.
         string[] fruits = new string[2];
         --adding elements to the fruits array
         fruits[0] = "Banana";
         fruits[1] = "Orange";


         List<string> fruits2 = new List<string>
         {
             "orange",
             "banana",
             "kiwi"

         };

         --Buradaki 1 ise 1 numaralı  elemanı yazdır diyor.
         Console.WriteLine(fruits[1]);
         Console.ReadKey();
         */
