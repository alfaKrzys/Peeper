using System;
using System.Windows.Forms;

namespace ServerPeeper
{
    public partial class Form1 : Form
    {
        //utworzenie instancji klasy Capture
        private Capture capture = new Capture();
        //utworzenie instancji klasy Streaming
        private Streaming stream;

        public Form1()
        {
            InitializeComponent();
            try
            {
                //utworzenie listy dostępnych urządzeń i ust. pierwszego jako domyślnego urządzenia
                lb_devices.Items.AddRange(capture.GetDevices());
                lb_devices.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        //reakcja na zdarzenie wyboru urządzenia, uruchomienie podglądu
        private void cb_preview_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_preview.Checked == true)
            {
                if (lb_devices.SelectedIndex == -1)
                {
                    MessageBox.Show("No devices checked");
                    cb_preview.Checked = false;
                }
                else
                    capture.Play(lb_devices.SelectedItem.ToString(), pb_preview);
            }
        }

        //zatrzymanie podgladu z urządzenia
        private void cb_stop_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb_stop = (CheckBox)sender;

            if (cb_stop.Checked == true)
            {
                cb_preview.Checked = false;
                capture.Stop();
                cb_stop.Checked = false;
            }

        }
        
        //rozpoczęcie streamingu video
        private void b_stream_Click(object sender, EventArgs e)
        {
            if (cb_preview.Checked == false)
            {
                cb_preview.Checked = true;
            }
            //utworzenie klasy streaming
            stream = new Streaming(capture);
            //rozpoczęcie streamingu na określonym porcie i adresie ip
            stream.Stream(tb_ip.Text, nud_port.Value);
        }
    }
}
