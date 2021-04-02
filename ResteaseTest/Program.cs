


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestEase;

namespace ResteaseTest
{
  
    public class User
    {
        public string Name { get; set; }
        public string Blog { get; set; }

        
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
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
   
    [Header("User-Agent", "RestEase")]
    public interface IGitHubApi
    {
       


        [Get("/{JsonModel}")]
        Task<List<Item>> GetPhotoAsync([Path] string JsonModel);
    }

    public class Program
    {
        public static void Main(string[] args)
        {

            
            decimal sayi = 522.222222m;
            var d = Convert.ToDecimal(sayi, new CultureInfo("en-US"));
            Console.WriteLine(d.ToString());
            Console.ReadKey();
        }
    }
}