using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    /*
     2114. Maximum Number of Words Found in Sentences
    A sentence is a list of words that are separated by a single space with no leading or trailing spaces.
    You are given an array of strings sentences, where each sentences[i] represents a single sentence.
    Return the maximum number of words that appear in a single sentence.
     */
    public class MaxNumWords
    {
        public int MostWordsFoundLinear(string[] sentences)
        {
            int max = 0;

            foreach (var s in sentences)
            {
                int words = s.Split(' ').Length;

                if (max < words)
                {
                    max = words;
                }
            }

            return max;
        }

        public int MostWordsFoundLINQ(string[] sentences)
        {
            int max = 0;

            foreach (var s in sentences)
            {
                int words = s.Count(f => f == ' ') + 1;

                if (max < words)
                {
                    max = words;
                }
            }

            return max;
        }
    }
}
