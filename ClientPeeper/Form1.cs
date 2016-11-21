using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientPeeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            //Tworzenie klasy do odbioru klatek z serwera
            Receiving receiving = new Receiving(tb_ip.Text, Int32.Parse(nud_port.Value.ToString()));
            //uruchomienie odbierania klatek do wskazanej kontrolki
            receiving.receive(pb_picture);
        }
    }
}
