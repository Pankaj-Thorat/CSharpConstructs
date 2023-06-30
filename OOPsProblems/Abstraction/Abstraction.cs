using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblems.Abstraction
{
    abstract class Abstraction
    {
        public string name;
        public int empId;
        public int netSalary;
        public double grossPay;
        public const double taxation = 0.1;

        public abstract void CalculateSalary();
    }

    class Child : Abstraction
    {
        public Child(string Name, int EmpId, int Salary)
        {
            this.name = Name;
            this.empId = EmpId;
            this.netSalary = Salary;
        }
        public override void CalculateSalary()
        {
            if (netSalary > 25000)
            {
                grossPay = netSalary - (netSalary * taxation);
                Console.WriteLine("Your salary is : " + grossPay);
            }
            else
            {
                Console.WriteLine("Your salary is : " + netSalary);
            }
        }
    }
}
