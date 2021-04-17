using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimalBinarySearchTree
{
    using System;

    public class DynamicAlgorithm
    {
        public static int FindOptimalSearchTreeValue(int[] nodeValues, int[] frequences)
        {
            // Store sub problems in matrix
            int[,] cost = new int[nodeValues.Length + 1, nodeValues.Length + 1];

            // cost is equal to frequency of the key
            for (int i = 0; i < nodeValues.Length; i++)
                cost[i, i] = frequences[i];

            // L is chain length. 
            for (int L = 2; L <= nodeValues.Length; L++)
            {
                // i is row number in cost[][] 
                for (int i = 0; i <= nodeValues.Length - L + 1; i++)
                {
                    // Get column number j from row number i and chain lenght L
                    int j = i + L - 1;
                    cost[i, j] = int.MaxValue;

                    // Make all keys in interval keys[i..j] as root 
                    for (int r = i; r <= j; r++)
                    {
                        // c = cost when keys[r] is the root of subtree
                        int c = ((r > i) ? cost[i, r - 1] : 0)
                                + ((r < j) ? cost[r + 1, j] : 0) + sum(frequences, i, j);
                        if (c < cost[i, j])
                            cost[i, j] = c;
                    }
                }
            }
            return cost[0, nodeValues.Length - 1];
        }

        // A utility function to get sum of array elements  
        public static int sum(int[] frequencies, int i, int j)
        {
            int sum = 0;
            for (int k = i; k <= j; k++)
            {
                if (k >= frequencies.Length)
                    continue;
                sum += frequencies[k];
            }
            return sum;
        }
    }
}
