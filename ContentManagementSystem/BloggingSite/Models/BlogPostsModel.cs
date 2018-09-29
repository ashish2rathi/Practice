using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingSite.Models
{
    public class BlogPostsModel
    {
        public int ID { get; set; }

        public string TopicID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime PublishedDate { get; set; }
    }
}
