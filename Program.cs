using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string numString;
            Console.WriteLine("Enter Input String");
            numString=Console.ReadLine();
             int length = numString.Length;
            

             char[] letters = new String(numString.Where(Char.IsNumber).ToArray()).ToCharArray();
             
             char[] nArray={};
             string outp="";
             int count=0;
             for (int i = 0; i < (letters.Length); i++)
            {
                if ((letters.Length) % 3 == 1)
                {
                    
                    if ((i+1) < (length - 4))
                    {
                        if (count == 3)
                        {
                            outp += "-" + letters[i];
                            count = 1;
                        }
                        else {
                            outp += letters[i];
                            count++;
                        }
                    }
                    else {
                        if (count == 2)
                        {
                            outp += "-" + letters[i];
                            count = 1;
                        }
                        else {
                            outp += letters[i];
                            count++;
                        }                 
                        
                    }

                }
                else
                {
                    if (count == 3)
                    {
                        outp += "-" + letters[i];
                        count = 1;
                    }
                    else
                    {
                        outp += letters[i];
                        count++;
                    }

                }
            }
             Console.WriteLine("OutPut:");
            Console.WriteLine(outp);
            Console.ReadKey(); 
        }
    }
}
