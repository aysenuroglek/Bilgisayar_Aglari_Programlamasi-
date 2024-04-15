using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventYapisi
{
    public partial class Form2 : Form
    {
        public delegate void _IslemYapildi();
        public delegate void FonksiyonBaslıgı2(string mesaj);

        public event _IslemYapildi IslemYapıldı;
        public event _IslemYapildi Islem2Yapıldı;
        public event FonksiyonBaslıgı2 Islem3Yapıldı;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IslemYapıldı?.Invoke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Islem2Yapıldı?.Invoke();
        }//hata vermemesi için ınvoke ekledik null geçebilmek için direkt yazınca null olduğu için hata verdi(invok işlemi gerçekleştir demek ) ? null geçilebilir

        private void button3_Click(object sender, EventArgs e)
        {
            Islem3Yapıldı?.Invoke(textBox1.Text);
        }
    }
}
