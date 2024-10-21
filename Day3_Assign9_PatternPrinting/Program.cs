using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assign9_PatternPrinting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 8; i++)
            {
                
                if (1 <= i && i <= 3)
                {
                    for (int h = 1; h <= 10; h++)
                    {
                        if (5 <= h && h <= 6)
                        {
                            continue;
                        }
                        System.Console.Write(h + " ");

                    }
                    System.Console.WriteLine();
                }
                

                else if ( i == 4 || i == 5 || i == 7)             //(4 <= i && i < 6 && 6 < i && i <= 7 )
                {
                    for (int k = 10; k >= 1; k--)
                    {
                        System.Console.Write(k + " ");

                    }
                    System.Console.WriteLine();
                }
                

               else if (i == 6)
                {
                    for (int l = 10; l >= 0; l--)
                    {
                        if (l==2)
                        {
                            break;
                        }
                        System.Console.Write(l + " ");

                    }
                    System.Console.WriteLine();
                }
                

                else
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        if (j == 8)
                        {
                            continue;
                        }
                        System.Console.Write(j + " ");
                       
                    }
                    System.Console.WriteLine();
                }
                
            }
            

            System.Console.ReadKey();

            /*
for (int j = 1; j <= 10; j++)
{
    if (!(j == 5 || j == 6))
    {
        System.Console.Write(j + " ");
    }
}
*/
            
        }
    }
}
