using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Test
{
    public class GenericProductClass
    {
        public string productTitle { get; set; }
        public string productCode { get; set; }
        public string productLink { get; set; }
        public string productDescription { get; set; }

        public GenericProductClass(string title, string link)
        {
        }
    }
}
