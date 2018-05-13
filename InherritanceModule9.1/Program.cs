using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceModule9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator gen = new Generator();
            gen.GenerateBook();
            gen.GenerateArticle();
            gen.GenerateWeb();

            gen.PrintAll();

            gen.FindAuthor("Au3");
        

            




        }
    }
}
