using System.IO.Ports;
using System.Runtime.Serialization;
using Vixen.Module;

namespace VixenModules.Output.KeyboardVisualizer
{
	[DataContract]
	public class Data : ModuleDataModelBase
	{
		[DataMember]
		public string PortName { get; set; }

		[DataMember]
		public int BaudRate { get; set; }

		[DataMember]
		public Parity Parity { get; set; }

		[DataMember]
		public int DataBits { get; set; }

		[DataMember]
		public StopBits StopBits { get; set; }

        [DataMember]
        public bool XmasMode { get; set; }

        [DataMember]
        public bool UseUDP { get; set; }

		[DataMember]
        public string UdpAddr { get; set; }

        [DataMember]
        public string UdpPort { get; set; }

		public override IModuleDataModel Clone()
		{
			return this.MemberwiseClone() as IModuleDataModel;
		}

		public bool IsValid
		{
			get
			{
                if(UseUDP)
                {
                    return
                        UdpAddr != null &&
                        UdpPort != null;
                }
                else
                {
                    return
                        PortName != null &&
                        BaudRate != 0 &&
                        DataBits != 0 &&
                        StopBits != 0;
                }
			}
		}
	}
}