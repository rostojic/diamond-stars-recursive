using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond_stars_recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            diamond(20,0);
        }

        static void print_stars(int dim)
        {
            for (int i = 0; i < dim; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
  
        static void diamond(int max_dim, int dim)
        {
            if (max_dim <= dim)
            {
                print_stars(2*dim-1);
            }
            else
            {
                for (int i = 0; i < max_dim - dim; i++)
                {
                    Console.Write(" ");
                }
                print_stars(2 * dim - 1);

                diamond(max_dim, dim + 1);

                for (int i = 0; i < max_dim - dim; i++)
                {
                    Console.Write(" ");
                }
                print_stars(2 * dim - 1);
            }
        }
    }
}
