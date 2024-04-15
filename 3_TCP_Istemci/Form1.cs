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

namespace _3_TCP_Istemci
{
    public partial class Form1 : Form
    {
        TcpClient istemci;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_baglan_Click(object sender, EventArgs e)
        {
            int port =Convert.ToInt32(txt_port.Text);
            istemci = new TcpClient();
            istemci.Connect(txt_ip.Text, port);
            NetworkStream istemciStream = istemci.GetStream();

            byte[] data = new byte[1024];
            int okunanByteSayisi = istemciStream.Read(data, 0, data.Length);
            MessageBox.Show("Sunucu" + okunanByteSayisi + "byte gonderi");

            txt_gelenmesajlar.Text += Encoding.UTF8.GetString(data, 0, okunanByteSayisi);
        }
    }
}
