using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace CodeWars
{
    public class BagPack
    {
        /* public static int NumberOfRectangles(int m, int n)
         {

             int num = m * n;
             num *= (n + 1);
             num *= (m + 1);
             num /= 4;
             return num;
         }*/

        public static int PackBagpack(int[] scores, int[] weights, int capacity)
        {
            int capacityCount = capacity;
            int bagScore = 0;
            List<float> valueScore = new List<float>();

            for (int i = 0; i < scores.Length; i++)
            {

                float toatlValue = scores[i] / weights[i];
                valueScore.Add(toatlValue);

            }


            int biggestIndex = 0;
            List<int> usedIndexs = new List<int>();
            float prevBig = 0;
            while (capacityCount >= 1)
            {
                for (int i = 0; i < valueScore.Count; i++)
                {
                    if (usedIndexs.Contains(i))
                    {
                        continue;
                    }
                    else if (weights[i] > capacityCount)
                    {
                        continue;
                    }
                    else if (valueScore[i] > prevBig)
                    {
                        prevBig = valueScore[i];
                        biggestIndex = i;
                        continue;
                    }

                }

                int endingCapacity = capacityCount - weights[biggestIndex];

                if(endingCapacity < 0)
                {
                    usedIndexs = new List<int>();
                    
                }
                else
                {
                    bagScore += scores[biggestIndex];
                    capacityCount = endingCapacity;
                    usedIndexs.Add(biggestIndex);
                    prevBig = 0;
                    biggestIndex = 0;
                }
 
            }

            return bagScore;




        }
    }
}
