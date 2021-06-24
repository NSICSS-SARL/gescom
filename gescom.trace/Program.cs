using gescom.data.Models;
using System;

namespace gescom.trace
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var arts = ArticleHelpers.GetList();
            for (int i = 0; i < 9015; i++)
            {
                var item = ArticleHelpers.Get(i);
                if (item == null)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}