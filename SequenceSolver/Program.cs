using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SequenceLib;

namespace SequenceSolver
{
    class Program
    {
       
        static void Main(string[] args)
        {
            UserInterface user_int_obj = new UserInterface();
           
            user_int_obj.generate_sequence();
            user_int_obj.print_partial_list();
            user_int_obj.main_loop();

            Console.WriteLine("\nGame Over");
            Console.ReadLine();
        }
    }
}
