using System;


namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company myCompany = new Company
            {
                Name = "Target"
            };
            // Create three employees
            Employee Katie = new Employee
            {
                FirstName = "Katie",
                LastName = "Johns",
                Title = "employee",
                StartDate = new DateTime(2021, 03, 04)
            };
            // Assign the employees to the company
            myCompany.Employees.Add(Katie);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            myCompany.ListEmployees();
            ;
        }
    }
}