using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Fractions;

namespace New
{
    public class Meme
    {
        static void Main(string[] args)
        {
            int lCount = int.Parse(Console.ReadLine());
            string[] newsInfo = Console.ReadLine().Split(", ");
            New news = new New(newsInfo[0], newsInfo[1], newsInfo[2]);

            for (int i = 0; i < lCount; i++)
            {
                string[] input = Console.ReadLine().Split(": ");

                if (input[0] == "Rename")
                {
                    news.Rename(input[1]);
                }
                else if (input[0] == "Edit")
                {
                    news.Edit(input[1]);
                }
                else if (input[0] == "ChangeWriter")
                {
                    news.ChangeWriter(input[1]);
                }
            }
            Console.WriteLine(news);
        }
    }
}
