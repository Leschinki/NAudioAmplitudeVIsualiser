using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmplitudeVisualizer
{
    public partial class Form1 : Form
    {
        private float volumeLeft = 0;
        private float volumeRight = 0;
        public Form1()
        {
            InitializeComponent();
            setup();
            _TickTimer.Enabled = true;
        }

        private void setup()
        {
            MMDeviceEnumerator deviceEnumerator = new MMDeviceEnumerator();
            var devices = deviceEnumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            _cbDevices.Items.AddRange(devices.ToArray());
            if(_cbDevices.Items.Count > 0)
                _cbDevices.SelectedIndex = 0;
        }
        private void UpdatePeakVolume()
        {
            MMDevice device = (MMDevice)_cbDevices.SelectedItem;
            volumeLeft = device.AudioMeterInformation.PeakValues[0];
            volumeRight = device.AudioMeterInformation.PeakValues[1];
        }

        private void onLeftPanelPaint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Rectangle rect = new Rectangle();
            rect.Height = (int)(_leftPanel.Height * volumeLeft * _trbMultiplicator.Value);
            rect.Width = _leftPanel.Width;
            rect.X = 0;
            rect.Y = _leftPanel.Height - rect.Height;
            gr.FillRectangle(Brushes.Green, rect);
        }
        private void onRightPanelPaint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Rectangle rect = new Rectangle();
            rect.Height = (int)(_leftPanel.Height * volumeRight *_trbMultiplicator.Value);
            rect.Width = _leftPanel.Width;
            rect.X = 0;
            rect.Y = _leftPanel.Height - rect.Height;
            gr.FillRectangle(Brushes.Green, rect);
        }

        private void OnTimerTIck(object sender, EventArgs e)
        {
            UpdatePeakVolume();
            _leftPanel.Invalidate();
            _rightPanel.Invalidate();
        }

        private void OnFormResize(object sender, EventArgs e)
        {
            _leftPanel.Width = (this.Width / 2) - 10;
            _rightPanel.Width = (this.Width / 2) - 10;
            _rightPanel.Left = _leftPanel.Width + 10;
        }
    }
}
