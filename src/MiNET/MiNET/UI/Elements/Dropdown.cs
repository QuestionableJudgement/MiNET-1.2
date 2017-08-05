using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace MiNET.UI.Elements
{
	public abstract class Dropdown : IElement
	{
		public string Text { get; set; }
		public List<string> Options { get; set; }
		public int Default { get; set; }

		public Dropdown(string text)
		{
			Text = text;
			Options = new List<string>();
		}
		public JObject GetData()
		{
			var j = new JObject
			{
				{ "type", "dropdown" },
				{ "text", Text },
				{ "options", GetOptions() },
				{ "default", Default }
			};
			return j;
		}

		public JToken GetOptions()
		{
			var j = new JArray();
			foreach(var o in Options)
			{
				j.Add(o);
			}
			return j;
		}

		public abstract void Process(Player player, object value);
	}
}
