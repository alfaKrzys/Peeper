using System;
using System.Net;
using System.Windows.Forms;
using MSR.LST.Net.Rtp;

namespace ServerPeeper
{
    class Streaming
    {
        private RtpSender rtpSender;
        private int port;
        private Capture capture;
        private IPAddress ip;

        public Streaming(Capture capture)
        {
            // TODO: Complete member initialization
            this.capture = capture;
        }

        internal void Stream(string ip, decimal port)
        {
            this.ip = IPAddress.Parse(ip);
            this.port = Int32.Parse(port.ToString());
            SetRTPSession();
            SetTimer();
        }

        private void SetTimer()
        {
            Timer send = new Timer();
            send.Interval = 500;
            send.Tick += send_Tick;
            send.Start();
        }

        void send_Tick(object sender, EventArgs e)
        {
            rtpSender.Send(capture.Grab().GetBuffer());
        }

        private void SetRTPSession()
        {
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
            rtpSession = new RtpSession(ep, new RtpParticipant(Dns.GetHostName(), Dns.GetHostName()), true, true);
            rtpSender = rtpSession.CreateRtpSenderFec(Dns.GetHostName(), PayloadType.Chat, null, 0, 200);
        }
    }
}
