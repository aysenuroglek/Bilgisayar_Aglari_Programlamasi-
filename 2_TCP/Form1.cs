using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_TCP
{
    public partial class Form1 : Form
    {
        TcpListener sunucu;
        TcpClient baglananIstemci;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_baslat_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(txt_Port.Text);
            sunucu = new TcpListener(System.Net.IPAddress.Any, port);
            sunucu.Start();
            txt_GelenMesajlar.Text += "Sunucu başladı";
            baglananIstemci=sunucu.AcceptTcpClient();

            NetworkStream kullaniciStreami = baglananIstemci.GetStream();
            byte[] gonderilecekVeriler = Encoding.UTF8.GetBytes("Merhaba");
            kullaniciStreami.Write(gonderilecekVeriler,0,gonderilecekVeriler.Length);
            //kullaniciStreami.Read();
        }
    }
}
