using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of strings ");
            int numOfStrings = (int)Convert.ToInt32(Console.ReadLine());
            string [] str=new string[numOfStrings];
            int maxPeriod;
           


            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("Enter the string ");
                str[i] = Console.ReadLine();
               
            }

            Console.WriteLine("Enter the Max period ");
            maxPeriod = (int)Convert.ToInt32(Console.ReadLine());

            Program p = new Program();
            int ans = p.MinChanges(maxPeriod, str);
            Console.WriteLine("Number of replacement {0}",ans);
      }


        public int MinChanges(int maxPeriod, string[] arr)
        {
            string str = "";
            int result = 0;
            int period = maxPeriod;
            int[] array = new int[maxPeriod];


            for (int i = 0; i < str.Length; i++)
            {
                
                str = str + str[i];
               
            }

            while (period != 0)
            {
                
                for (int j = 0; j < maxPeriod; j++)
                {
                    for (int i = j; i < str.Length - period; i = i + period)
                    {
                        if (str[j] != str[i + period])
                        {
                            result++;
                        }
                    }
                    
                }
                
                period--;
                array[period] = result;
                result = 0;

              
            }
            Array.Sort(arr);
                return array[0];

        }
            

                
   }
}

