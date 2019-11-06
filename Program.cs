using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BonusLab_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = new Item();
            //var b = new Item();
            //a.Name = "Bob";
            //b.Name = "Carly";
            //Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            //a.Name = "Carly";
            //b.Name = "Carly";
            //Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            //a.Name = "Edward";
            //b.Name = "Carly";
            //Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));

            //Implement the Solution to the challenge
            Console.WriteLine("VALUE	                                 MEANING");
            Console.WriteLine("Less than zero   	    a precedes b in the sort order or a is null and b is not null.");
            Console.WriteLine("Zero	                    a is equal to b or a and b are both null.");
            Console.WriteLine("Greater than zero	    a follows b in the sort order or b is null and a is not null.\n");
            
            //Test CompareByName 
            Comparison comp = new Comparison();
            int result = comp.CompareByName("remus", "iftimie");
            Console.WriteLine(result);

            //Test CompareByLength
            Console.Write("Please enter the first string: ");
            string word1 = Console.ReadLine();
            Console.Write("Please enter the second string: ");
            string word2 = Console.ReadLine();

            comp.CompareByLength(word1, word2);
            Console.ReadKey();

        }
    }
    public class Item : IComparable
    {
        public string Name;

        public int CompareTo(object o)
        {
            Item that = o as Item;
            return this.Name.CompareTo(that.Name);
        }
    }
}
