using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSolution
{
    public class HorizontalVerticalCombination
    {
        public List<string> DisplayVerticalCombination(string alpha)
        {
            //string alpha = "abcdef";
            List<string> result = new List<string>();
            for (int i = 0; i < alpha.Length; i++)
            {
                result.Add(alpha.Substring(i, 1));
            }
            for (int y = 2; y < alpha.Length; y++)
            {
                int z = (alpha.Length / y);
                int index = 0;
                while (z > 0)
                {
                    result.Add(alpha.Substring(index, y));
                    index += y;
                    z--;
                }

            }
            return result;
        }

        //public List<string> DisplayVerticalCombination(string a)
        //{
        //    char[] alpha = new char[] { 'a', 'b', 'c', 'd', 'e', 'f' };
        //    List<string> result = new List<string>();
        //    for (int i = 0; i < alpha.Count(); i++)
        //    {
        //        result.Add(alpha.ToString());
        //    }
        //    for (int y = 2; y < alpha.Count(); y++)
        //    {
        //        string str = new string(alpha);
        //    }
        //    return result;
        //}
    }
}


