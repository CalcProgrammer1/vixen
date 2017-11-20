using System;
using Vixen.Module.Controller;

namespace VixenModules.Output.KeyboardVisualizer
{
	public class Descriptor : ControllerModuleDescriptorBase
	{
		private Guid _typeId = new Guid("{d5e66c2d-dd13-4fed-81ea-a12b67305c6d}");

		public override string Author
		{
			get { return "Adam Honse (CalcProgrammer1)"; }
		}

		public override string Description
		{
			get { return "Keyboard Visualizer hardware module"; }
		}

		public override Type ModuleClass
		{
			get { return typeof (Module); }
		}

		public override Type ModuleDataClass
		{
			get { return typeof (Data); }
		}

		public override Guid TypeId
		{
			get { return _typeId; }
		}

		public override string TypeName
		{
			get { return "Keyboard Visualizer"; }
		}

		public override string Version
		{
			get { return "1.0"; }
		}
	}
}