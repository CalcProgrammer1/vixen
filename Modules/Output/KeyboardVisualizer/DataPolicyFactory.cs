using Vixen.Sys;

namespace VixenModules.Output.KeyboardVisualizer
{
	internal class DataPolicyFactory : IDataPolicyFactory
	{
		public IDataPolicy CreateDataPolicy()
		{
			return new DataPolicy();
		}
	}
}