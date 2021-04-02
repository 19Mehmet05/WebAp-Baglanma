using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApıBaglanma
{
     public class DTO
    {
        public List<PhotoItem> ToModelList(string Json)
        {
   
            List<PhotoItem> items = JsonConvert.DeserializeObject<List<PhotoItem>>(Json);
            return items;
        }
       
    }
}
