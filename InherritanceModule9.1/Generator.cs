using InherritanceModule9._1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceModule9._1
{
    public enum Books { book1, book2, book3, book4, book5 }
    public enum Publish {Pub1, Pub2, Pub3, Pub4, Pub5 }
    public enum Authors { Au1, Au2, Au3, Au4, Au5}
    public enum Mag { Mag1, Mag2, Mag3, Mag4, Mag5 }
    public enum Links { Link1, Link2, Link3, Link4, Link5 }


    public class Generator
    {

        private Random rnd = new Random();
        public List<Publishing> pub;

        public Generator()
        {
            pub = new List<Publishing>();
        }

        public void GenerateBook()
        {
            Book b = new Book();
            b.SourceName = ((Books)rnd.Next(0, 5)).ToString();
            b.AuthorName = ((Authors)rnd.Next(0, 5)).ToString();
            b.PublishDate = DateTime.Now.AddMonths(-rnd.Next(1, 24));
            b.Publishment = ((Publish)rnd.Next(0, 5)).ToString();

            pub.Add(b);

        }

        public void GenerateArticle()
        {
            Article a = new Article();
            a.SourceName = ((Books)rnd.Next(0, 5)).ToString();
            a.AuthorName = ((Authors)rnd.Next(0, 5)).ToString();
            a.MagazineName = ((Mag)rnd.Next(0, 5)).ToString();
            a.MagNumber = rnd.Next(0, 300);
            a.PublishDate = DateTime.Now.AddMonths(-rnd.Next(1, 24));

            pub.Add(a);
        }

        public void GenerateWeb()
        {
            WebSite w = new WebSite();
            w.SourceName = ((Books)rnd.Next(0, 5)).ToString();
            w.AuthorName = ((Authors)rnd.Next(0, 5)).ToString();
            w.Link = ((Links)rnd.Next(0, 5)).ToString();
            w.Annotation = "Not available";

            pub.Add(w);
            
        }

        public void PrintAll()
        {
            foreach (Publishing item in pub)
            {
                item.PrintInfo();

            }



        }

        public void FindAuthor(string aut)
        {

            foreach (Publishing item in pub)
            {
                if(item.AuthorName == aut)
                    Console.WriteLine($" Author was found {item.AuthorName}");
                else
                    Console.WriteLine("Invalid author name");

            }


        }



    }
}
