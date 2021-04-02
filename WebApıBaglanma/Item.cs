using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApıBaglanma
{
   public class Item
    {
        public int postId;
        public int id;
        public string name;
        public string email;
        public string body;
        public override string ToString()
        {
            return " " + postId + " " + id + " " + name + " " + email;
        }
    }
   public class PhotoItem
    {
        public int albumId;
        public int id;
        public string title;
        public string url;
        public string thumbnailUrl;
        public override string ToString()
        {
            return " " + albumId + " " + id + " " + title + " " + url+ " " +thumbnailUrl ;
        }
    }
}
