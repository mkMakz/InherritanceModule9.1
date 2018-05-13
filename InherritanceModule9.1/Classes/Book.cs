using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceModule9._1
{


    public class Book : Publishing
    {
        private string _publishment;

        public DateTime PublishDate { get; set; }
        public string Publishment { get => _publishment; set => _publishment = value; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Source {SourceName} \n Author {AuthorName} \n" +
                $"Publish date {PublishDate} \n Publishment {Publishment} \n");

        }


    }
}
