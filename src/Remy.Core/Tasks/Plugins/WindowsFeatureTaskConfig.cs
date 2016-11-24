using System.Collections.Generic;
using Remy.Core.Config;

namespace Remy.Core.Tasks.Plugins
{
	public class WindowsFeatureTaskConfig : ITaskConfig
	{
		public string Description { get; set; }
		public string Runner { get; set; }
		public Dictionary<string, object> Config { get; set; }
	    public List<string> Features { get; set; }

		public bool IncludeAllSubFeatures { get; set; }
	}
}