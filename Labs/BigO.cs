using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    
    class BigO
    {
        public static Random rand = new Random();
        public static int[] array1 = new int[5000];
        public static int[] array2 = new int[5000];
        public static ArrayList matchingWords = new ArrayList();


        public static void Go()
        {
            var watch = new System.Diagnostics.Stopwatch();
            /*
                        for (int i = 0; i < array1.Length; i++)
                        {
                            array1[i] = rand.Next();
                        }

                        for (int i = 0; i < array2.Length; i++)
                        {
                            array2[i] = rand.Next();
                        }

                        watch.Start();
                        compairTwoArrays(array1,array2);
                        watch.Stop();
                        for (int i = 0; i < matchingWords.Count; i++)
                        {
                            Console.WriteLine(matchingWords[i]);
                        }
                        var elapsedMs = watch.ElapsedMilliseconds;
                        Console.WriteLine("Time: " + elapsedMs);
                        Console.WriteLine("Time: " + elapsedMs/60000.0f);*/



            /*string testWord = "madam";
            
            if(IsTheWordAPalindrome(testWord) == true)
            {
                Console.WriteLine("The word is a Palindrome");
            }
            else
            {
                Console.WriteLine("That word is not a Palindrome");
            }*/

            



        }


        public static void compairTwoArrays(int[] first, int[] second)
        {
            for (int i = 0; i < first.Length; i++)
            {
                for (int x = 0; x < second.Length; x++)
                {
                    if(first[i] == second[x])
                    {
                        matchingWords.Add(second[x]);
                        break;
                    }
                    
                }
            }
        }

        public static bool IsTheWordAPalindrome(string word)
        {
            bool isAPalindrome = false;

            var wordToCharArray1 = word.ToCharArray();
            var wordToCharArray2 = word.ToCharArray();
            for (int i = 0 , j = word.Length -1 ; i < word.Length; i++, j--)
            {
                if(wordToCharArray1[i] != wordToCharArray2[j])
                {
                    isAPalindrome = false;
                    break;
                }
                else
                {
                    isAPalindrome = true;
                }

            }

            return isAPalindrome;
        }

        public static int algorithm(int[] a)
        {
            int x = a.Length -1;
            int y = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] > y)
                {
                    y = a[i];
                }
            }
            return y;
        }

    }


}
