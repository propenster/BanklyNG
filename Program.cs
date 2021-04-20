using System;

namespace BanklyNG
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string WordSentence = "the cat ate the cat's food the cat ate the cat's food the cat ate the cat's food the cat ate the cat's food the cat ate the cat's food the cat ate the cat's food";

            //the cat ate the cat's food the cat ate the cat's food the cat ate the cat's food the cat ate the cat's food the cat ate the cat's food the cat ate the cat's food

            string[] words = WordSentence.Split(" ");
            int length = words.length;
            Console.WriteLine("Please eenter a string");
            string wordToBeSearched = Console.ReadLine();
            string[] wordArray = wordToBeSearched.Split(" ");
            int i = 0;
            int count = 0;
            foreach (var item in wordArray)
            {
                //int pos = words.Where(x => x.Equals(words[i])).Count();
                while ((i = wordToBeSearched.IndexOf(item, i)) != -1)
                {

                    i += item.Length;
                    count++;

                }

                Console.WriteLine("The most occuring word is {0} occuring {1}", item, count);

            }
            
            Console.WriteLine(pos);
            //int numThe = 0;
            //int cat = 0;
            //int ate = 0;  
            //int cats = 0;
            //int food = 0;

            //for (int i = 0; i < words.length; i++)
            //{
            //    if (words[i]) ;
            //}

            ////find which occurs most...

            //foreach (var item in words)
            //{
            //    if (item.Equals("the"))
            //    {
            //        numThe += 1;
            //    }else if (item.Equals("cat"))
            //    {
            //        cat += 1;
            //    }
            //    else if (item.Equals("ate"))
            //    {
            //        ate += 1;
            //    }
            //    else if (item.Equals("cat's"))
            //    {

            //        cats += 1;
            //    }
            //    else
            //    {
            //        food += 1;
            //    }
            //}

            //int[] array = new int[] { numThe, cat, ate, cats, food};

            //Dictionary<string, int> dict = new Dictionary<string, int>()
            //{
            //    { }
            //};

            //Console.WriteLine("The most occuring word is {} occuring {1}", words, Array.Max(array));
            //string WordSentence = "The Cat ate the Cat's food";
            //string WordSentence = "The Cat ate the Cat's food";
            //string WordSentence = "The Cat ate the Cat's food";
            //string WordSentence = "The Cat ate the Cat's food";
            //find most occurring andd how many times.




        }
    }
}
