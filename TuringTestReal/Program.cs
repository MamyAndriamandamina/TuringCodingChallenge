using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringTestReal
{
    class Program
    {
        static void Main(string[] args)
        {
            //assuming the array is the first argument as comma separated string value 
            string input = args[0].ToString();
            string[] Ar = input.Split(',');

            //assuming the target is the second argument
            int target = Int32.Parse(args[1].ToString());
            

            List<int> mylist = new List<int>();
            for(int i = 0; i < Ar.Length; i++)
            {
                for(int j =0; j< Ar.Length; j++)
                {
                    if (j > i)
                    {
                        mylist.Add(Int32.Parse(Ar[i].ToString()) + Int32.Parse(Ar[j].ToString()));
                    }
                }
            }
            int[] final = new int[mylist.Count];
            final = mylist.ToArray();
            Array.Sort(final);

            int themax = final.Max();
            int themin = final.Min();
            

            if (target >= themin && target <= themax)
            {
                for(int k = 0; k < final.Length; k++)
                {
                    if(final[k]==target)
                    {
                        Console.WriteLine(final[k]);
                        break;
                    }
                    else
                    {
                        if(final[k]>target)
                        {
                            Console.WriteLine(final[k-1]);
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
