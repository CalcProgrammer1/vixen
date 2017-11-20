using System;
using System.IO.Ports;
using System.Windows.Forms;
using Common.Controls;
using Common.Controls.Theme;
using Common.Resources.Properties;

namespace VixenModules.Output.KeyboardVisualizer
{
	public partial class SetupDialog : BaseForm
	{
		private Data _data;
		private SerialPort _serialPort = null;

		public SetupDialog(Data data)
		{
			InitializeComponent();
			ForeColor = ThemeColorTable.ForeColor;
			BackColor = ThemeColorTable.BackgroundColor;
			ThemeUpdateControls.UpdateControls(this);

			_data = data;

            checkBox1.Checked = _data.UseUDP;
            checkBox2.Checked = _data.XmasMode;

            if (_data.UseUDP)
            {    
                textBox1.Text = _data.UdpAddr;
                textBox2.Text = _data.UdpPort;
                btnOkay.Enabled = true;
            }

			if (!string.IsNullOrEmpty(data.PortName)) {
				Port = new SerialPort(data.PortName, data.BaudRate, data.Parity, data.DataBits, data.StopBits);
				updateSettingLabel();
				btnOkay.Enabled = true;
			}
			else {
				lblSettings.Text = "Not Set";
				btnOkay.Enabled = false;
			}
		}

		private void btnPortSetup_Click(object sender, EventArgs e)
		{
			using (Common.Controls.SerialPortConfig serialPortConfig = new Common.Controls.SerialPortConfig(Port)) {
				if (serialPortConfig.ShowDialog() == DialogResult.OK) {
					Port = serialPortConfig.SelectedPort;
					btnOkay.Enabled = true;
					updateSettingLabel();
				}
			}
		}

		private void btnOkay_Click(object sender, EventArgs e)
		{
            _data.UseUDP = checkBox1.Checked;
            if (checkBox1.Checked)
            {
                _data.UdpAddr = textBox1.Text;
                _data.UdpPort = textBox2.Text;
            }
            else
            {
                _data.BaudRate = _serialPort.BaudRate;
                _data.DataBits = _serialPort.DataBits;
                _data.Parity = _serialPort.Parity;
                _data.PortName = _serialPort.PortName;
                _data.StopBits = _serialPort.StopBits;
                _data.XmasMode = checkBox2.Checked;
            }
        }

		private void updateSettingLabel()
		{
			lblSettings.Text = string.Format(
				"{0}: {1}, {2}, {3}, {4}",
				_serialPort.PortName,
				_serialPort.BaudRate,
				_serialPort.Parity,
				_serialPort.DataBits,
				_serialPort.StopBits);
		}

		public SerialPort Port
		{
			set { _serialPort = value; }
			get { return _serialPort; }
		}

		private void buttonBackground_MouseHover(object sender, EventArgs e)
		{
			var btn = (Button)sender;
			btn.BackgroundImage = Resources.ButtonBackgroundImageHover;
		}

		private void buttonBackground_MouseLeave(object sender, EventArgs e)
		{
			var btn = (Button)sender;
			btn.BackgroundImage = Resources.ButtonBackgroundImage;

		}

		private void groupBoxes_Paint(object sender, PaintEventArgs e)
		{
			ThemeGroupBoxRenderer.GroupBoxesDrawBorder(sender, e, Font);
		}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                btnOkay.Enabled = true;
            }
        }
    }
}