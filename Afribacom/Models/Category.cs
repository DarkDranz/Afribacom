using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Afribacom.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string category_Name { get; set; }
        public string category_Thumbnail { get; set; }

        public List<Articles> Articles { get; set; }
    }

    public class Articles
    {
        public int Id { get; set; }
        public string article_name { get; set; }
        public string article_quantity { get; set; }

        public int article_price { get; set; }
        public int category_Id { get; set; }
    }
}
