using LeetCode.Algorithms;

namespace LeetCodeTests
{
    public class MaxNumWordsTests
    {
        MaxNumWords mnw = new MaxNumWords();

        [Fact]
        public void Linear()
        {
            string[] sentences = 
                { 
                "alice and bob love leetcode", // 5
                "i think so too", // 4
                "this is great thanks very much" // 6 
            };

            Assert.Equal(6, mnw.MostWordsFoundLinear(sentences));
        }

        [Fact]
        public void Linq()
        {
            string[] sentences =
                {
                "alice and bob love leetcode", // 5
                "i think so too", // 4
                "this is great thanks very much" // 6 
            };

            Assert.Equal(6, mnw.MostWordsFoundLINQ(sentences));
        }
    }
}