using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    public class AscendingFillers
    {
        public static void Main()
        {
            int pn = 0, filler = 0, sum = 0;

            while (true)
            {
                Console.WriteLine("Enter non negative integers");
                filler = 0;
                string cnn = Console.ReadLine();
                int cn = Convert.ToInt32(cnn);
                if ((cn < 0) | (cnn == null))
                {
                    break;
                }

                else if (cn <= pn && cn != 0)
                {
                    filler = (pn + 1) - cn;
                    cn = pn + 1;
                }

                pn = cn;
                sum += filler;
                //Console.WriteLine(sum);
                //Console.WriteLine(filler);

            }
            Console.WriteLine(sum);

        }
    }
}