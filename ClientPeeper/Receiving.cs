using MSR.LST.Net.Rtp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientPeeper
{
    class Receiving
    {
        private int port;
        private IPAddress ip;
        private PictureBox pb_picture;

        //konstruktor klasy
        public Receiving(string p1, int p2)
        {
            // TODO: Complete member initialization
            this.ip = IPAddress.Parse(p1);
            this.port = p2;
        }


        //metoda odbierająca klatki
        internal void receive(PictureBox pb_picture)
        {
            this.pb_picture = pb_picture;
            RtpSession rtpSession;
            IPEndPoint ep;
            try
            {
                ep = new IPEndPoint(ip, port);
            }
            catch
            {
                MessageBox.Show("Błędny adres grupy multicastowej");
                return;
            }
            //utworzenie zdarzenia nawiązania połączenia
            RtpEvents.RtpStreamAdded += new RtpEvents.RtpStreamAddedEventHandler(RtpStreamAdded);
            //RtpEvents.RtpStreamRemoved += new RtpEvents.RtpStreamRemovedEventHandler(RtpStreamRemoved);
            //parametryzajca rtpSession
            rtpSession = new RtpSession(ep, new RtpParticipant(Dns.GetHostName(), Dns.GetHostName()), true, true);
            //tworzenie rtpSender
            RtpSender rtpSender = rtpSession.CreateRtpSenderFec(Dns.GetHostName(), PayloadType.Chat, null, 0, 200);
        }

        private void RtpStreamAdded(object sender, RtpEvents.RtpStreamEventArgs ea)
        {
            //dodanie zdarzenia obsługującego odbiór ramki
            ea.RtpStream.FrameReceived += new RtpStream.FrameReceivedEventHandler(Odbior);
        }

        private void Odbior(object sender, RtpStream.FrameReceivedEventArgs ea)
        {
            //zapis klatki do pamięci
            MemoryStream ms = new MemoryStream(ea.Frame.Buffer);
            //załadowanie klatki filmu do controlki
            pb_picture.Image = Image.FromStream(ms);
            
        }
    }
}
