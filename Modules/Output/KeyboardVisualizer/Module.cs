using System;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Vixen.Commands;
using Vixen.Module;
using Vixen.Module.Controller;

namespace VixenModules.Output.KeyboardVisualizer
{
	public class Module : ControllerModuleInstanceBase
	{
		private Data _data;
		private SerialPort _serialPort;
        private UdpClient _udpClient;
		private readonly CommandHandler _commandHandler;
		private byte[] _packet;
		private readonly System.Timers.Timer _retryTimer;
		private int _retryCounter;
		private static readonly NLog.Logger Logging = NLog.LogManager.GetCurrentClassLogger();

		public Module()
		{
			_commandHandler = new CommandHandler();
			DataPolicyFactory = new DataPolicyFactory();

			//set 2 minute timer before retrying to access com port
			_retryTimer = new System.Timers.Timer(120000);
			_retryTimer.Elapsed += new ElapsedEventHandler(RetryTimer_Elapsed);
			_retryCounter = 0;
		}

		public override void UpdateState(int chainIndex, ICommand[] outputStates)
		{
            if (!_data.UseUDP)
            {
                if (SerialPortIsValid && _serialPort.IsOpen)
                {
                    if (_data.XmasMode)
                    {
                        _packet = new byte[5 * 25];

                        for(int i = 0; i < 25; i++)
                        {
                            int color = 0;
                            ICommand red = outputStates[3 * i + 0];
                            ICommand grn = outputStates[3 * i + 1];
                            ICommand blu = outputStates[3 * i + 2];
                            if(red != null)
                            {
                                red.Dispatch(_commandHandler);
                            }
                            color |= (_commandHandler.Value / 16);
                            if(grn != null)
                            {
                                grn.Dispatch(_commandHandler);
                            }
                            color |= (_commandHandler.Value / 16) << 4;
                            if(blu != null)
                            {
                                blu.Dispatch(_commandHandler);
                            }
                            color |= (_commandHandler.Value / 16) << 8;

                            _packet[i * 5 + 0] = 0x00;
                            _packet[i * 5 + 1] = Convert.ToByte(i + 1);
                            _packet[i * 5 + 2] = Convert.ToByte(color >> 8);
                            _packet[i * 5 + 3] = Convert.ToByte(color & 0xFF);
                            _packet[i * 5 + 4] = 0xFE;

                            if(i == 24)
                            {
                                _packet[i * 5 + 4] = 0xFF;
                            }
                        }

                        try
                        {
                            _serialPort.Write(_packet, 0, 5*25);
                        }
                        catch (Exception ex)
                        {
                            Logging.Error(ex, "An error occured writing to the serial port.");
                        }
                    }
                    else
                    {
                        _packet = new byte[outputStates.Length + 3];

                        var packetLen = _packet.Length;

                        _packet[0] = 0xAA;

                        for (int i = 0; i < outputStates.Length && IsRunning; i++)
                        {
                            _commandHandler.Reset();
                            ICommand command = outputStates[i];
                            if (command != null)
                            {
                                command.Dispatch(_commandHandler);
                            }
                            _packet[i + 1] = _commandHandler.Value;
                        }

                        ushort sum = 0;

                        for (int i = 0; i < outputStates.Length + 1; i++)
                        {
                            sum += _packet[i];
                        }

                        _packet[outputStates.Length + 1] = (byte)(sum >> 8);
                        _packet[outputStates.Length + 2] = (byte)(sum & 0x00FF);

                        if (packetLen > 0)
                        {
                            try
                            {
                                _serialPort.Write(_packet, 0, packetLen);
                            }
                            catch (Exception ex)
                            {
                                Logging.Error(ex, "An error occured writing to the serial port.");
                            }
                        }
                    }
                }
            }
            else
            {
                {
                    _packet = new byte[outputStates.Length + 3];

                    var packetLen = _packet.Length;

                    _packet[0] = 0xAA;

                    for (int i = 0; i < outputStates.Length && IsRunning; i++)
                    {
                        _commandHandler.Reset();
                        ICommand command = outputStates[i];
                        if (command != null)
                        {
                            command.Dispatch(_commandHandler);
                        }
                        _packet[i + 1] = _commandHandler.Value;
                    }

                    ushort sum = 0;

                    for (int i = 0; i < outputStates.Length + 1; i++)
                    {
                        sum += _packet[i];
                    }

                    _packet[outputStates.Length + 1] = (byte)(sum >> 8);
                    _packet[outputStates.Length + 2] = (byte)(sum & 0x00FF);

                    if (packetLen > 0)
                    {
                        try
                        {
                            _udpClient.Send(_packet, packetLen);
                        }
                        catch (Exception ex)
                        {
                            Logging.Error(ex, "An error occured writing to the UDP port.");
                        }
                    }
                }
            }
		}

		public override bool HasSetup
		{
			get { return true; }
		}

		public override bool Setup()
		{
			using (SetupDialog setup = new SetupDialog(_data))
			{
				if (setup.ShowDialog() == DialogResult.OK)
				{
					SerialPort port = setup.Port;
					if (port != null)
					{
						InitModule();
						return _data.IsValid;
					}
				}
			}

			return false;
		}

		public override IModuleDataModel ModuleData
		{
			get { return _data; }
			set
			{
				_data = (Data) value;
				InitModule();
			}
		}

		public override void Start()
		{
			base.Start();
            if (!_data.UseUDP)
            {
                if (SerialPortIsValid && !_serialPort.IsOpen)
                {
                    OpenComPort();
                }
            }
		}

		public override void Stop()
		{
            if (!_data.UseUDP)
            {
                if (SerialPortIsValid && _serialPort.IsOpen)
                {
                    _serialPort.Close();
                }
            }
			base.Stop();
		}

		private void InitModule()
		{
			DropExistingSerialPort();
			CreateSerialPortFromData();
		}

		private void DropExistingSerialPort()
		{
			if (_serialPort != null)
			{
				_serialPort.Dispose();
				_serialPort = null;
			}
		}

		private void CreateSerialPortFromData()
		{
			if (_data.IsValid)
			{
                if (!_data.UseUDP)
                {
                    _serialPort = new SerialPort(
                        _data.PortName,
                        _data.BaudRate,
                        _data.Parity,
                        _data.DataBits,
                        _data.StopBits);

                    _serialPort.Handshake = Handshake.None;
                    _serialPort.Encoding = Encoding.UTF8;

                    if (IsRunning)
                    {
                        OpenComPort();
                    }
                }
                else
                {
                    _udpClient = new UdpClient();
                    IPEndPoint ep = new IPEndPoint(IPAddress.Parse(_data.UdpAddr), Int32.Parse(_data.UdpPort));

                    //if(IsRunning)
                    {
                        _udpClient.Connect(ep);
                    }
                }
			}
			else
			{
				_serialPort = null;
			}
		}

		private bool SerialPortIsValid
		{
			get { return _serialPort != null; }
		}

		//use this to always open the port so it is in one place and we can 
		//check if we have an access violation
		private void OpenComPort()
		{
			try
			{
				_serialPort.Open();

				//if successfull 
				//stop the retry counter and log that we got this going
				//start the controller back up

				if (_serialPort.IsOpen && _retryTimer.Enabled)
				{
					_retryCounter = 0;
					_retryTimer.Stop();

					Logging.Info("Serial Port conflict has been corrected, starting controller type {0} on port {1}.",
						_data.ModuleTypeId, _serialPort.PortName);
				}
			}
			catch (Exception ex)
			{
				if (ex is UnauthorizedAccessException ||
				    ex is InvalidOperationException ||
				    ex is IOException)
				{
					Logging.Error("{0} could not be opened because {1}.  Starting controller retry timer for controller type {2}",
						_serialPort.PortName, ex.Message, _data.ModuleTypeId);
					Stop();
					//lets set our retry timer
					if (_retryCounter < 3)
					{
						_retryCounter++;
						_retryTimer.Start();
						Logging.Info("Starting retry counter for com port access. Retry count is {0}", _retryCounter);
					}
					else
					{
						Logging.Info(
							"Retry counter for com port access has exceeded max tries.  Controller has been stopped.");
						_retryTimer.Stop();
						_retryCounter = 0;
					}
				}
				else
				{
					Logging.Error(ex, "{0} could not be opened.", _serialPort.PortName);
				}
			}
		}

		private void RetryTimer_Elapsed(object source, ElapsedEventArgs e)
		{
			Logging.Info("Attempting to start serial controller.");
			Start();
		}
	}
}