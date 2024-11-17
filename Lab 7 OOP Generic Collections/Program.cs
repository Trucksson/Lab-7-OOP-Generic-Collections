using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar Employee med olika ID, namn, kön och lön.
            Employee Lisa = new Employee("E101", "Lisa", "Female", 40000);
            Employee Erik = new Employee("E102", "Erik", "Male", 28000);
            Employee Karl = new Employee("E103", "Karl", "Male", 30000);
            Employee Johan = new Employee("E104", "Johan", "Male", 33000);
            Employee Sara = new Employee("E105", "Sara", "Female", 50000);

            // Skapar en stack 
            Stack<Employee> stack = new Stack<Employee>();

            // Lägger till anställda i stacken
            stack.Push(Lisa);
            stack.Push(Erik);
            stack.Push(Karl);
            stack.Push(Johan);
            stack.Push(Sara);

            // Skapar en lista 
            List<Employee> poppedEmployeesList = new List<Employee>();

            // Itererar genom stacken och skriver ut information om varje anställd
            foreach (var item in stack)
            {
                item.PrintValues();  
                Console.WriteLine($"Items left in stack: {stack.Count}");  // Skriv ut antal objekt kvar i stacken
            }

            Console.WriteLine("");  // Tom rad

            // Meddelande för att indikera att vi nu hämtar element via POP
            Console.WriteLine("Retrieving Using POP Method");

            // Använder while-loop för att poppa (ta bort) objekt från stacken tills den är tom
            while (stack.Count > 0)
            {
                
                Employee poppedEmployee = stack.Pop();
                poppedEmployee.PrintValues();  

                // Skriv ut antalet objekt som är kvar i stacken
                Console.WriteLine($"Number of items left: {stack.Count}");

                // Lägger till en lista
                poppedEmployeesList.Add(poppedEmployee);
            }

            Console.WriteLine("\nAdding all items back to the stack with Push:");  // Meddelande för återinmatning i stacken

            //for each loop för att pusha employee
            foreach (Employee employee in poppedEmployeesList)
            {
                stack.Push(employee); 
            }

            Console.WriteLine("\nDisplaying items in the stack:");  

        
            foreach (var item in stack)
            {
                item.PrintValues();  
                Console.WriteLine($"Number of items left: {stack.Count}");  // Skriv ut antalet objekt kvar i stacken
            }

           
            Console.WriteLine("Retrieve using Peek");

            // Använder Peek 
            Employee firstPeeked = stack.Peek();
            firstPeeked.PrintValues();  // Visar information
            Console.WriteLine($"Items left in stack = {stack.Count}");  

            // Ta bort den översta anställda från stacken
            firstPeeked = stack.Pop();

            // Använd Peek igen
            Employee secondPeeked = stack.Peek();
            secondPeeked.PrintValues();  
            Console.WriteLine($"Items left in stack = {stack.Count}");  

            // Väntar på användarens inmatning 
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();  // Väntar på ett tangent tryck
        }
    }
}
