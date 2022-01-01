using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToptalTests.Hackerrank
{
    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */
    public class CompareTripletsTask
    {
        public List<int> CompareTriplets(List<int> a, List<int> b)
        {
            var aPoint = 0;
            var bPoint = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    aPoint += 1;
                else if (a[i] < b[i])
                    bPoint += 1;
            }

            return new List<int> { aPoint, bPoint };
        }
    }
}
