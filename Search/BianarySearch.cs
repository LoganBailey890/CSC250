using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public static class BianarySearch
    {
        public static int SearchBianary(int[] items, int targets, int min, int max)
        {
            if(min == max)
            {
                return items[min] == targets ? min : -1;
            }
            else
            {
                var indexToSearch = (min + max) / 2;

                if(items[indexToSearch] == targets)
                {
                    return indexToSearch;
                }
                else if(items[indexToSearch]<targets)
                {
                    return SearchBianary(items, targets, indexToSearch + 1, max);
                }
                else
                {
                    return SearchBianary(items, targets, min, indexToSearch - 1);
                }
            }

            


        }
    }
}
