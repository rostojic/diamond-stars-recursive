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
            try
            {
                int lenght = int.Parse(args[0]);
                diamond(lenght, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Use: diamond-stars-recursive diamond-lenght");
            }
            
        }
        /// <summary>
        /// Helper function for drawing a row of 'dim' chars
        /// </summary>
        static void print_chars(int dim, char character)
        {
            for (int i = 0; i < dim; i++)
            {
                Console.Write(character);
            }
            if(character != ' ')
            {
                Console.WriteLine();
            }
            
        }
        /// <summary>
        /// Core recursive function 
        /// </summary>
        /// <param name="max_dim"></param>
        /// Diamond lenght in "stars"
        /// <param name="dim"></param>
        /// Helper parameter to speed up the recursion
        static void diamond(int max_dim, int dim)
        {
            if (max_dim <= dim)
            {
                print_chars(2 * dim - 1, '*');
            }
            else
            {
                print_chars(max_dim - dim, ' ');
                print_chars(2 * dim - 1, '*');

                diamond(max_dim, dim + 1);

                print_chars(max_dim - dim, ' ');
                print_chars(2 * dim - 1, '*');
            }
        }
    }
}
