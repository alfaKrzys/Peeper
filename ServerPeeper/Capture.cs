using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.Live;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ServerPeeper
{
    class Capture
    {
        private List<string> capDevices = new List<string>();
        private LiveJob _job;
        private LiveDeviceSource _deviceSource;
        private int selectDeviceIndex;
        private Collection<EncoderDevice> AudioDevices;
        private PictureBox p_preview;

        public Capture()
        {
            //wyszukiwanie urządzń audio i video podłączonych do komputera
            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                capDevices.Add(edv.Name);
            }
            AudioDevices = EncoderDevices.FindDevices(EncoderDeviceType.Audio);
        }

        //metoda zwracająca urządzenia podłączone do komputera
        internal object[] GetDevices()
        {
            if (capDevices.Count == 0)
            {
                throw new Exception("No video capture devices found! Program exit.");
            }
            else
            {
                string[] capDeviceStr = new string[capDevices.Count];
                for (int i = 0; i < capDevices.Count; i++)
                    capDeviceStr.SetValue(capDevices[i], i);
                return capDeviceStr;
            }
        }

        // metoda włączająca podgląd obrazu z urządzenia
        internal void Play(string deviceName, PictureBox p_preview)
        {
            this.p_preview = p_preview;
            for (int i = 0; i < capDevices.Count; i++)
            {
                if (capDevices[i].Equals(deviceName))
                {
                    selectDeviceIndex = i;
                }
            }

            // Starts new job for preview window
            _job = new LiveJob();

            // Create a new device source. We use the first audio and video devices on the system
            _deviceSource = _job.AddDeviceSource(GetVideoDevice(deviceName), AudioDevices[0]);

            // Sets preview window to winform panel hosted by xaml window
            _deviceSource.PreviewWindow = new PreviewWindow(new HandleRef(p_preview, p_preview.Handle));

            // Make this source the active one
            _job.ActivateSource(_deviceSource);
        }

        //metoda zamieniająca nazwę urządzenia na postać EncoderDevice
        private EncoderDevice GetVideoDevice(string deviceName)
        {
            EncoderDevice video = null;
            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                if (String.Compare(edv.Name, deviceName) == 0)
                {
                    video = edv;
                    break;
                }
            }
            return video;
        }
        //zatrzymanie podgląu
        internal void Stop()
        {
            // Has the Job already been created ?
            if (_job != null)
            {
                _job.StopEncoding();

                _job.RemoveDeviceSource(_deviceSource);

                _deviceSource.PreviewWindow = null;
                _deviceSource = null;
            }
        }

        //przechwycenie do pamięci pojedynczej klatki filmu
        internal MemoryStream Grab()
        {
            //utworzenie intasncji klasy MemorySteram
            MemoryStream ms = new MemoryStream();
            //utowrzenie klasy bitmap o zadanych wymiarach
            Bitmap bitmap = new Bitmap(p_preview.Width, p_preview.Height);
            //utworzenie instancji klasy GRapihics na podstawie klasy bitmap
            Graphics g = Graphics.FromImage(bitmap);
            //utworzenie instncji klasy kwadratu no podstawie wymiarów okna podglądu
            Rectangle rectanglePanelVideoPreview = p_preview.Bounds;
            // odnalezienie punktu na ekranie z oknem podglądu
            Point sourcePoints = p_preview.PointToScreen(new Point(p_preview.ClientRectangle.X, p_preview.ClientRectangle.Y));
            //kopiowanie fragmentu obrazu z ekranu
            g.CopyFromScreen(sourcePoints, Point.Empty, rectanglePanelVideoPreview.Size); 
            //zapis tego obrazu do ms
            bitmap.Save(ms,ImageFormat.Jpeg);
            return ms;
        }
    }
}