using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotalListPage
{
    class Program
    {
        static void Main(string[] args)
        {
            string st;
            do
            {
                Console.WriteLine("1 for Chicken Briyani\n2 for Kothuparotta\n3 for Mutton Briyani\n\n");
                Console.Write("Press the options and get the food details and hotel details: ");
            
                int a = Convert.ToInt32(Console.ReadLine());
                var item = new NonVeg().display(a);
                foreach (var itemValues in item)
                    Console.WriteLine(itemValues);

                Console.WriteLine("If you want to gather any details press Yes otherwise press No)");
                st = Console.ReadLine();
               
            }
            while (st!="No");
            Console.ReadKey();




        }
    }
}
