using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BatuÖdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] sayilar = new int[25];

        private void Form1_Load(object sender, EventArgs e)// form load da diğer butonlarda kullanılması için 0-100 arasında 25 dizeli sayı oluşturulur.
        {
            Random rnd = new Random();
            for (int i = 0; i < 25; i++)
            {
                sayilar[i] = rnd.Next(0, 100);// sayilar değişkeni "i" dizesine random atılır
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //box tamizlenir

            for (int i = 0; i < 25; i++)
            {
                listBox1.Items.Add(sayilar[i]); // listbox a sayilar yazdırılır

                int adet = listBox1.Items.Count; // list box daki satır sayısı sayılır
                label1.Text = "Eleman Boyutu : " + adet; // label a satır sayısı yazılır
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //box tamizlenir

            foreach (var item in sayilar) // döngü ile sayilar değişkeninin 50 den küçük değerleri bulunur istediğim yineleme değerini girmeye ihtiyacım olmadığından foreach kullandım
            {
                if (item < 50)
                {
                    listBox1.Items.Add(item);
                }

            }

            int adet = listBox1.Items.Count;
            label1.Text = "Eleman Boyutu : " + adet; // list box daki satır sayısı sayılır label a satır sayısı yazılır
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//box tamizlenir

            listBox1.Items.Add(sayilar.Average()); // box items dan ortalama bulma işlemi yapılıp listboxa yazılır
        }


        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //box tamizlenir

            for (int sayi = 2; sayi <= 100; sayi++)
            {
                int kontrol = 0;

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        kontrol = 1;
                        break;  // döngü her seferinde kırılıp tekrar başlar sayının asal olup olmadığı sonucun 1 yada 0 dönmesi ile anlaşılır istenilirse asal olmayan sayılar da yazdırılabilir.
                    }
                }
                if (kontrol == 0)
                {
                    listBox1.Items.Add(sayi);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int buyuk;
            buyuk = Convert.ToInt32(listBox1.Items[0]);

            int sayi;
            for (int i = 0; i < listBox1.Items.Count; i++)

            {
                sayi = Convert.ToInt32(listBox1.Items[i]);

                if (buyuk < sayi)
                {
                    buyuk = sayi;
                }
            }
            listBox1.Items.Clear(); //box tamizlenir
            listBox1.Items.Add(buyuk);

            int adet = listBox1.Items.Count;
            label1.Text = "Eleman Boyutu : " + adet;  // list box daki satır sayısı sayılır label a satır sayısı yazılır
        }
    }
}

