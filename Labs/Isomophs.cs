using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Collections;

namespace Labs
{
    public class Isomophs
    {

        public static void Go()
        {
            ArrayList NonIso = new ArrayList();
            Dictionary<string, ArrayList> eIsomprph = new Dictionary<string, ArrayList>();
            Dictionary<string, ArrayList> lIsomprph = new Dictionary<string, ArrayList>();
            //string text = File.ReadAllText("C:\\Users/lbailey/source/repos/CSC250/TextDocuments/IsomorphInput1.txt");
            string text = File.ReadAllText("C:\\Users/lbailey/source/repos/CSC250/TextDocuments/IsomorphInput2.txt");


            while (text != "")
            {
                string wordToPass = text.Contains("\r\n") ? text.Substring(0,text.IndexOf("\r\n")) : text.Substring(0,text.Length);

                //Console.WriteLine(patterne + " " + wordToPass);


                string patterne = EIsomorph(wordToPass);
                if (eIsomprph.ContainsKey(patterne))
                {
                    eIsomprph[patterne].Add(wordToPass);
                }
                else
                {
                    ArrayList tempList = new ArrayList();
                    tempList.Add(wordToPass);
                    eIsomprph.Add(patterne,tempList);
                }
                string lPatterne = LIsomorph(wordToPass);
                if (lIsomprph.ContainsKey(lPatterne))
                {
                    lIsomprph[lPatterne].Add(wordToPass);
                }
                else
                {
                    ArrayList tempList = new ArrayList();
                    tempList.Add(wordToPass);
                    lIsomprph.Add(lPatterne, tempList) ;
                }

                text = text.Remove(0,wordToPass.Length);
                if(text.Contains("\r\n"))
                {
                   text = text.Remove(0, 2);
                }
            }

            foreach(var index in eIsomprph)
            {
                if(index.Value.Count == 1)
                {
                    NonIso.Add(index.Value[0]);
                    eIsomprph.Remove(index.Key);
                }
            }
            foreach(var index in lIsomprph)
            {
                if(index.Value.Count == 1)
                {
                    if(NonIso.Contains(index.Value[0]))
                    {
                        lIsomprph.Remove(index.Key);
                    }
                    else
                    {
                        NonIso.Add(index.Value[0]);
                        lIsomprph.Remove(index.Key);
                    }

                }
            }


            string eDisplay = "Exact: \n ";
            foreach (var index in eIsomprph)
            {
                eDisplay += (index.Key + ": ");
                for (int i = 0; i < index.Value.Count; i++)
                {
                    if(i+1 == index.Value.Count)
                    {
                        eDisplay += (index.Value[i] + "\n");
                    }
                    else
                    {
                        eDisplay += (index.Value[i] + " ");
                    }
                }
            }

            Console.WriteLine(eDisplay);

            string lDisplay = "Lose:\n ";
            foreach (var index in lIsomprph)
            {
                lDisplay += (index.Key + ": ");
                for (int i = 0; i < index.Value.Count; i++)
                {
                    if(i + 1 == index.Value.Count)
                    {
                        lDisplay += (index.Value[i] + "\n");
                    }
                    else
                    {
                        lDisplay += (index.Value[i] + " ");
                    }
                }
            }
            Console.WriteLine(lDisplay);


            string nonIso = "NonIso: \n";
            for (int i = 0; i < NonIso.Count; i++)
            {
                nonIso += (NonIso[i] + " ");
            }
            Console.WriteLine(nonIso);

            string finalOutPut = eDisplay + "\n" + lDisplay + "\n" + nonIso;
            //File.WriteAllText("C:\\Users/lbailey/source/repos/CSC250/TextDocuments/Isomorphoutput1.txt", finalOutPut);
            File.WriteAllText("C:\\Users/lbailey/source/repos/CSC250/TextDocuments/Isomorohoutput2.txt", finalOutPut);

        }
        

        public static string EIsomorph(string testWord)
        {
            string wordPatteren = "";
            ArrayList alreadySeen = new ArrayList();

            foreach(char letter in testWord)
            {
                if (alreadySeen.Contains(letter)) wordPatteren += alreadySeen.IndexOf(letter).ToString();
                else
                {
                    alreadySeen.Add(letter);
                    wordPatteren += alreadySeen.IndexOf(letter);
                }
            }

            return wordPatteren;

        }

        public static string LIsomorph(string testWord)
        {
            string wordPatteren = "";

            ArrayList nonSortedPattern = new ArrayList();
            ArrayList alreadySeen = new ArrayList();

            foreach (char letter in testWord)
            {
                if (!alreadySeen.Contains(letter))
                {
                    alreadySeen.Add(letter);
                    int howManyTimes = testWord.Count(c => (c == letter));
                    nonSortedPattern.Add(howManyTimes);
                }
            }

            nonSortedPattern.Sort();
            for (int i = 0; i < nonSortedPattern.Count; i++)
            {
                wordPatteren += nonSortedPattern[i];
            }

            return wordPatteren;

        }

    }
}
