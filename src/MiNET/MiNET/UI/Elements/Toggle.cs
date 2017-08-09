using MiNET;
using Newtonsoft.Json.Linq;

namespace MiNET.UI.Elements
{
	public class Toggle : IElement
	{
		public string Text { get; set; }
		public bool Default { get; set; }

		public Toggle(string text = "", bool defaultValue = false)
		{
			Text = text;
			Default = defaultValue;
		}
		public JObject GetData()
		{
			var j = new JObject
			{
				{ "type", "toggle" },
				{ "text", Text },
				{ "default", Default }
			};
			return j;
		}

		public virtual void Process(Player player, object value)
		{
		}
	}
}
