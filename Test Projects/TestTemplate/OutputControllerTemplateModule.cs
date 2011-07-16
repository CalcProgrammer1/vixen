﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vixen.Common;
using Vixen.Sys;
using Vixen.Module.FileTemplate;

namespace TestTemplate {
	public class OutputControllerTemplateModule : FileTemplateModuleDescriptorBase {
		private Guid _typeId = new Guid("{D7C0DF55-C3E2-416e-AC23-BF3BCEFDCAEE}");

		override public string FileType {
			get { return ".out"; }
		}

		override public Guid TypeId {
			get { return _typeId; }
		}

		override public Type ModuleClass {
			get { return typeof(OutputControllerTemplate); }
		}

		override public Type ModuleDataClass {
			get { return typeof(OutputControllerTemplateData); }
		}

		override public string Author {
			get { throw new NotImplementedException(); }
		}

		override public string TypeName {
			get { return "Output controller template"; }
		}

		override public string Description {
			get { throw new NotImplementedException(); }
		}

		override public string Version {
			get { throw new NotImplementedException(); }
		}
	}
}
