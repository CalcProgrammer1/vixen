﻿using Vixen.Sys;

namespace Vixen.Commands {
	public class SignedShortValueCommand : Dispatchable<SignedShortValueCommand>, ICommand<short> {
		public SignedShortValueCommand(short value) {
			CommandValue = value;
		}

		public short CommandValue { get; set; }

		object ICommand.CommandValue {
			get { return CommandValue; }
			set { CommandValue = (short)value; }
		}

		//public void Dispatch(CommandDispatch commandDispatch) {
		//    // Must be done in the classes being dispatched.
		//    if(commandDispatch != null)
		//        commandDispatch.DispatchCommand(this);
		//}
	}
}