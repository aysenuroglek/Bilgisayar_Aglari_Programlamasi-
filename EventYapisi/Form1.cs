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
    public partial class Form1 : Form
    {
        Form2 yeniForm = new Form2();
        public Form1()
        {

            InitializeComponent();
        }

        private void btn_Yeni_Click(object sender, EventArgs e)
        {

            yeniForm.IslemYapıldı += YeniForm_IslemYapıldı;
            yeniForm.Islem2Yapıldı += YeniForm_Islem2Yapıldı;
            yeniForm.Islem2Yapıldı += Dogrula;
            yeniForm.Islem3Yapıldı += YeniForm_Islem3Yapıldı;

            yeniForm.Show();

        }
        private void YeniForm_Islem3Yapıldı(string mesaj)
        {
            txt_Yazı.Text += mesaj + Environment.NewLine;
        } 

        public void Dogrula()
        {
            MessageBox.Show("işlem 2 Doğrulandı");
        }

        private void YeniForm_Islem2Yapıldı()
        {
            txt_Yazı.Text += "İşlem 2 Gerçekleşti" + DateTime.Now + "\n";
           //MessageBox.Show("İşlem 2 Gerçekleşti.");
        }
        private void YeniForm_IslemYapıldı()
        {
            //throw new NotImplementedException();
            txt_Yazı.Text += "İşlem 1 Gerçekleşti" + DateTime.Now + "\n";
            MessageBox.Show("İşlem 1 Gerçekleşti.");
            yeniForm.IslemYapıldı -= YeniForm_IslemYapıldı;
        }
    }
}
