using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class FoldAnArray
    {
        public static int[] FoldArray(int[] array, int runs)
        {
            int half = (int)Math.Ceiling(array.Length / 2d);
            int[] folded = new int[half];
            Array.Copy(array, folded, half);

            for (int i = 0; i < array.Length / 2; i++)
            {
                folded[i] += array[array.Length - 1 - i];
            }

            return folded.Length == 1 | runs == 1 ? folded : FoldArray(folded, --runs);
        }
    }
}
