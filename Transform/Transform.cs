using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static List<int> Map(this int[] NumberArray, Func<int,int> perform)
        {
            //throw new NotImplementedException();
            /*Some Useful Links :
             * https://www.codeproject.com/Tips/771746/Uses-of-Func-in-Csharp
             * https://msdn.microsoft.com/en-us/library/bb534966(v=vs.110).aspx
             * https://codeblog.jonskeet.uk/2011/01/05/reimplementing-linq-to-objects-part-26b-orderby-descending-thenby-descending/
             */
            List<int> Numbers = new List<int>();
            foreach(int num in NumberArray)
            {
                Numbers.Add(perform(num));
            }
            return Numbers;
        }
    }
}
