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
            //assuming the user will use a serie of values separated by comma as first argument, example 2,17,6,1,30,25
            //assuming the user will use one integer value as second argument, example 40
            //the output will be 36
            try
            {
                var Data = args[0].Split(',');
                List<int> mydata = new List<int>();
                for (int i=0; i < Data.Length; i++)
                {
                    mydata.Add(Int32.Parse(Data[i]));
                }
                var A = mydata.ToArray();
                int setpoint = Int32.Parse(args[1]);
                
            List<int> mycollection = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (j > i)
                    {
                        mycollection.Add(A[i] + A[j]);
                    }
                }
            }
            //remove duplicate for performance only
            RemoveDuplicate(mycollection,setpoint);
            }
            catch
            {
                Console.WriteLine("there might be an issue on your setpoint value (only integer with the following format please 3,1,2,7,25)");
            }
        }
        static void RemoveDuplicate(List<int> input, int setpoint)
        {   
            int length = input.Count();
            for (int i = 0; i < length; i++)
            {
                for (int j = (i + 1); j < length;)
                {
                    if (input[i] == input[j])
                    {
                        for (int k = j; k < length - 1; k++)
                            input[k] = input[k + 1];
                        length--;
                    }
                    else
                        j++;
                }
            }
            SortMyArray(input.ToArray(), setpoint);
        }
        static void SortMyArray (int[] input, int setpoint)
        { 
            //ascending sort
        var itemMoved = false;
            do
            {
                itemMoved = false;
                for (int i = 0; i < input.Count() - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        var lowerValue = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = lowerValue;
                        itemMoved = true;
                    }
                }
            } while (itemMoved);
            
            FindMaxValue(input, setpoint);
        }
        static void FindMaxValue(int[] input, int setpoint)
        {
            //find the maximum value that is less than K
            var K = setpoint;
            for (int i = 0; i < input.Length; i++)
            {
                if (Int32.Parse(input[i].ToString()) >= K && i == 0)
                {
                    Console.WriteLine("There is no maximum combination values that is less than the current K value of: {0} because all the combination is Greater or equal than this K value", K);
                    return;
                }
                if (Int32.Parse(input[i].ToString()) >= K)
                {
                    Console.WriteLine("The maximum combination values that is less than the current K value of: {0} is: {1}", K, input[i - 1].ToString());
                    return;
                }
                else
                {
                    if (i == input.Length - 1)
                    {
                        Console.WriteLine("There is no maximum combination values that is less than the current K value of: {0} because all the combination is Less than this K value", K);
                        return;
                    }
                }
            }
        }
    }
}
