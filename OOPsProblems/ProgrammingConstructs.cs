using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblems
{
    internal class ProgrammingConstructs
    {
        public void EqualOrNot(int x, int y)
        {
            Console.WriteLine("\n<----------------- Programming Constructs ------------>");
            //Que 1
            if (x == y)
            {
                Console.WriteLine("Both numbers are equal");
            }
            else
            {
                Console.WriteLine("Both numbers are not equal");
            }
        }
        public void IsValidVoterOrNot(int x)
        {
            if (x >= 18)
            {
                Console.WriteLine("Voter is Eligible candidate.");
            }
            else
            {
                Console.WriteLine("Voter is not Eligible candidate.");
            }
        }
        public void IsLargestNumber(int x, int y, int z)
        {
            if (x > y && x > z)
            {
                Console.WriteLine($"{x} is the Largest Number.");
            }
            else if (y > z && y > z)
            {
                Console.WriteLine($"{y} is the Largest Number .");
            }
            else
            {
                Console.WriteLine($"{z} is the Largest Number.");
            }

        }
        public void AdmissionCriteria(int math,int physics,int chemistry)
        {
            int sum = Addition(math, physics, chemistry);
            int mp = Addition(math, physics);
            int mc = Addition(math, chemistry);
            bool isTrue = (math >= 65 && physics >= 55 && chemistry >= 50 && sum >= 180) || ((mc >= 140 || mp >= 140) && (math >= 65 && physics >= 55 && chemistry >= 50));
            if (isTrue)
            {
                Console.WriteLine("Candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("Candidate is not eligible for admission.");
            }
        }
        public int Addition(int math,int physics,int chemistry)
        {
            return math + physics + chemistry;
        }
        public int Addition(int math, int physics)
        {
            return math + physics ;
        }
    }
}
