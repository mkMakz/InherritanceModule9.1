using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceModule9._1.Classes
{
    public class Article : Publishing
    {
        public string MagazineName { get; set; }
        public int MagNumber { get; set; }
        public DateTime PublishDate { get; set; }


        public override void PrintInfo()
        {
            Console.WriteLine($"Source {SourceName} \n Author {AuthorName} \n" +
                $"Magazine name {MagazineName} \n Magazine number {MagNumber} \n" +
                $"Publish date {PublishDate} \n");
        }




    }
}
