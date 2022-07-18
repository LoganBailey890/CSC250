using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class TenMinuteWalk
    {
        public static bool IsValidWalk(string[] walk)
        {
            bool isValid = false;
            Dictionary<string, int> testWalk = new Dictionary<string, int> { { "n", 1 }, { "s", -1 }, { "e", 2 }, { "w", -2 }};

            int point = walk.Sum(s => testWalk[s]);

            if(point == 0 && walk.Length == 10)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
