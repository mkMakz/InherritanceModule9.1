using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceModule9._1.Classes
{
    public class WebSite : Publishing
    {
        public string Link { get; set; }
        public string Annotation { get; set; }



        public override void PrintInfo()
        {
            Console.WriteLine($"Source {SourceName} \n Author {AuthorName} \n" +
                $"Link {Link} \n Annotation {Annotation} \n");
        }
    }
}
