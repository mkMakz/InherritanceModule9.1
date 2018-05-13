using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceModule9._1
{
    public abstract class Publishing
    {

        public string SourceName { get; set; }
        public string AuthorName { get; set; }
     
        public abstract void PrintInfo();

    }
}
