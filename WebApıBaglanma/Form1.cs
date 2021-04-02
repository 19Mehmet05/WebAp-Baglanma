using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using RestEase;
using System.Threading.Tasks;

namespace WebApıBaglanma
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        [Header("User-Agent", "RestEase")]
        public interface IGitHubApi
        {
            // The [Get] attribute marks this method as a GET request
            // The "users" is a relative path the a base URL, which we'll provide later
            // "{userId}" is a placeholder in the URL: the value from the "userId" method parameter is used
            //[Get("users/{userId}")]
            //Task<User> GetUserAsync([Path] string userId);

            [Get("/{JsonModel}")]
            Task<List<Item>> GetPhotosAsync([Path] string JsonModel);
        }


        // We receive a JSON response, so define a class to deserialize the json into



        private void button3_Click(object sender, EventArgs e)
            {
            Network network = new Network();
            Stopwatch watch = new Stopwatch();
            for (int i = 0; i <= 10; i++)
            {
                watch.Start();
                
                string J = network.FetchRestEase();
                DTO dTO = new DTO();
                
                listBox3.Items.Add(watch.Elapsed.Milliseconds); 
                watch.Stop();
            }
            int toplam = 0, ortalama = 0;
            for (int i = 0; i <= 10; i++)
            {
                toplam = toplam + Convert.ToInt32(listBox3.Items[i]);
            }
            ortalama = toplam / listBox3.Items.Count;
            MessageBox.Show(ortalama.ToString());
        }

          
                
            
        


        private async void button1_Click(object sender, EventArgs e)
        {

            Network network = new Network();
            Stopwatch watch = new Stopwatch();
            for (int i = 0; i <=10; i++)
            {
                watch.Start();
                //Task<string>J= network.Fetch();
                //DTO dTO = new DTO();
                //List<PhotoItem> photoItems = dTO.ToModelList(J.ToString());
                string J= network.Fetch();
                DTO dTO = new DTO();
                List<PhotoItem> photoItems = dTO.ToModelList(J);
                listBox1.Items.Add(watch.Elapsed.Milliseconds); //  Bağlantı süresini ekrana yazdırıyoruz.
                watch.Stop();
            }
            int toplam = 0, ortalama = 0;
            for (int i = 0; i <=10; i++)
            {
                toplam = toplam + Convert.ToInt32(listBox1.Items[i]);
            }
            ortalama = toplam / listBox1.Items.Count;
            MessageBox.Show(ortalama.ToString());
         
            //List<PhotoItem> items = JsonConvert.DeserializeObject<List<PhotoItem>>(result);
            //Item ıtem = new Item();
            //ıtem.Insert(ıtem.name);
            //foreach (var item in items)
            //{
            //    listBox1.Items.Add(item);
            //}
          

        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            Network network = new Network();
            Stopwatch watch = new Stopwatch();
            for (int i = 0; i <= 10; i++)
            {
                watch.Start();
             
                //  Bağlantı süresini ekrana yazdırıyoruz.
                string J = network.FetchRestSharp();
                DTO dTO = new DTO();
                List<PhotoItem> photoItems= dTO.ToModelList(J);
                listBox2.Items.Add(watch.Elapsed.Milliseconds);
                watch.Stop();
            }
            int toplam = 0, ortalama = 0;
            for (int i = 0; i <= 10; i++)
            {
                toplam = toplam + Convert.ToInt32(listBox2.Items[i]);
            }
            ortalama = toplam / listBox2.Items.Count;
            MessageBox.Show(ortalama.ToString());


        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        
    }
}
