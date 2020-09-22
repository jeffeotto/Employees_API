using System;
namespace Employees_API.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
       
    }
}
