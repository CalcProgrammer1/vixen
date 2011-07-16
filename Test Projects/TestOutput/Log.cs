﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Vixen.Common;
using Vixen.Module;
using Vixen.Module.Output;

namespace TestOutput {
	public class Log : OutputModuleInstanceBase {
		private bool _running = false;
		private string _filePath = @"C:\Users\Development\Desktop\Log.txt";
		private StreamWriter _file;

		override public void SetOutputCount(int outputCount) { }

		override public void UpdateState(CommandData[] outputStates) {
			CommandData data;
			for(int i = 0; i < outputStates.Length; i++) {
				data = outputStates[i];
				if(!data.IsEmpty) {
					_file.WriteLine("[" + i + "] " + data.StartTime + " - " + data.EndTime + " " + data.CommandIdentifier + " ~ " + string.Join(" ", data.ParameterValues.Select(x => x.ToString()).ToArray()));
				}
			}
		}

		override public bool IsRunning {
			get { return _running; }
		}

		override public bool Setup() {
			return false;
		}

		override public void Start() {
			_file = new StreamWriter(_filePath);
			_running = true;
		}

		override public void Stop() {
			_running = false;
			_file.Flush();
			_file.Dispose();
		}
	}
}
