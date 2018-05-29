using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSolution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Occurances of a character
            string re = "abcdaf";
            int count1 = re.Split('a').Length - 1;
            int count = re.ToArray().Count(x => x == 'a');
            Console.WriteLine(count);
            #endregion

            #region Horizntal vertical combination
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();
            //HorizontalVerticalCombination hvc = new HorizontalVerticalCombination();
            //List<string> result = hvc.DisplayVerticalCombination(input);
            //foreach (var item in result)
            //{
            //  Console.WriteLine(item);
            //}
            #endregion

            #region Prime or not
            Console.WriteLine("enter the number");
            string number = Console.ReadLine();
            Methods methods = new Methods();
            Console.WriteLine(methods.PrimeOrNot(number));
            #endregion
        }

    }

    public class Methods
    {
        public string PrimeOrNot(string number)
        {
            string result = string.Empty;
            int no = Convert.ToInt32(number);
            int k = 0;
            for (int i = 2; i < no / 2; i++)
            {
                if (no % i == 0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                result = "prime number";
            }
            else
                result = "not prime number";
            return result;

        }
    }
}
