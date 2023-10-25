using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace WinForm_Anket
{
    public partial class Form1 : Form
    {

        private List<Anket> ankets = new List<Anket>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string email = textBox3.Text;
            string telefon = textBox4.Text;
            string dogumtarixi = textBox5.Text; 

            Anket newAnket = new Anket(ad,soyad,email,telefon,dogumtarixi);
            ankets.Add(newAnket);


            ListBox listBox = new ListBox(newAnket);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(ankets, Formatting.Indented);

           using (StreamWriter file = File.CreateText("ankets.json"))
            {
                file.Write(json);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("ankets.json"))
            {
                string json = File.ReadAllText("ankets.json");
                ankets = JsonConvert.DeserializeObject<List<Anket>>(json);


                foreach (Anket anket in ankets) 
                {
                    Anket.ReferenceEquals(anket, this);

                }
                MessageBox.Show("Jon filina elave edildi");

            }

            else
            {
                MessageBox.Show("JSon elde edilmedi");

            }
        }
    }
}