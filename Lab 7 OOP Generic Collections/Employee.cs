using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP_Generic_Collections
{
    public class Employee
    {
        // egenskaper för att se employee ID, namn, kön och lön
        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        // Konstruktor för att skapa en ny Employee
        public Employee(string ID, string Name, string Gender, int Salary)
        {
            this.ID = ID;      // Tilldelar ID
            this.Name = Name;  // Tilldelar namn
            this.Gender = Gender;  // Tilldelar kön
            this.Salary = Salary;  // Tilldelar lön
        }

        // Metod för att skriva ut anställdas information
        public void PrintValues()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary}");
        }
    }
}

