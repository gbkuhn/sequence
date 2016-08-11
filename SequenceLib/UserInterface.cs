using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceLib
{
    public class UserInterface
    {

        List<Int32> sequence_list = new List<Int32>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        List<Int32> duplicate_list = new List<Int32>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        int op_value;
        private int choice;
        private static bool _check1 = false;
        private static bool _check2 = false;
        private static int attempts = 0;

        public void main_loop()
        {
            while (attempts <= 3)
            {

                Console.WriteLine("\nEnter attempt #" + attempts);

                guess(Convert.ToInt32(Console.ReadLine()));

                if (check1())
                {
                    Console.WriteLine("CORRECT");
                    print_partial_list();

                    print_partial_list(8);

                    if (_check2)
                    {

                        print_partial_list(9);
                    }
                    else
                    {
                        Console.Write(" _ ");
                    }

                    _check1 = true;
                }

                if (check2())
                {
                    Console.WriteLine("CORRECT");
                    print_partial_list();

                    if (_check1)
                    {
                        print_partial_list(8);
                    }
                    else
                    {
                        Console.Write("_ ");
                    }

                   print_partial_list(9);

                    _check2 = true;
                }

                if (!check1() && !check2())
                {
                    attempts++;//increment counter
                    Console.WriteLine("Try again");

                }

                if (_check1 && _check2)
                {
                    Console.WriteLine("You win!");
                    Console.ReadLine();
                    System.Environment.Exit(1);
                }
            }
        }

        public void generate_sequence()
        {
            Random random = new Random();

           // Console.WriteLine("RANDOM TEST "+random.Next(3));

            switch (2) //random.Next(1,4)
            {
                case 1:
                    Console.WriteLine("CASE 1");
                    fibonacci_fill_list();
                    break;
                case 2:
                    Console.WriteLine("CASE 2");

                    prime_fill_list();
                    break;
                case 3:
                    Console.WriteLine("CASE 3");

                    perfect_fill_list();
                    break;
                case 4:
                    Console.WriteLine("5");
                    op_value = 5;
                    break;
                case 5:
                    Console.WriteLine("6");
                    op_value = 6;
                    break;
                case 6:
                    Console.WriteLine("7");
                    op_value = 7;
                    break;
                case 7:
                    Console.WriteLine("8");
                    op_value = 8;
                    break;
                case 8:
                    Console.WriteLine("9");
                    op_value = 9;
                    break;
                case 9:
                    Console.WriteLine("10");
                    op_value = 10;
                    break;
                case 10:
                    Console.WriteLine("11");
                    op_value = 11;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

        }

        public void fibonacci_fill_list()
        {                
                int a = 0, b = 1, c = 0;

                for (int i = 2; i < 10; i++)
                {
                    c = a + b;

                    //Console.Write(" {0}", c);
                    sequence_list[i] = c;
                    a = b;
                    b = c;
                }
        }

        public void prime_fill_list()
        {
            List<int> fib_list = new List<int>() {2, 3, 5, 7, 11, 13, 17, 19, 23, 29};

            for (int i = 0; i < 10; i++)
            {
                sequence_list[i] = fib_list[i];
            }
        }

        private void perfect_fill_list()
        {
            List<int> perfect_list = new List<int>() { 2, 3, 5, 7, 13, 17, 19, 31, 61, 89};

            for (int i = 0; i < 10; i++)
            {
                sequence_list[i] = perfect_list[i];
            }
        }

        public void print_partial_list()
        {
            for (int i = 0; i < 8; i++)
            {
                    Console.Write(sequence_list[i] + " ");
            }
            
        }

        public void print_partial_list(int index)
        {
                Console.Write(sequence_list[index] + " ");
        }

        public void print_full_list()
        {
            Console.Write("\n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(sequence_list[i] + " ");
            }
        }

        public void guess(int choice)
        {
            this.choice = choice;
        }

        public bool check1()
        {
            if (sequence_list[8].Equals(choice))
            {
                return true;
            }
            return false;
        }

        public bool check2()
        {
            if (sequence_list[9].Equals(choice))
            {
               return true;
            }
            return false;
            }
        }

    }

