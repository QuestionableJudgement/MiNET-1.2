using MiNET;
using Newtonsoft.Json.Linq;

namespace MiNET.UI.Elements
{
	public abstract class Input : IElement
	{
		public string Text { get; set; }
		public string Placeholder { get; set; }
		public string Default { get; set; }

		public Input(string placeholder = "", string defaultText = "", string text = "")
		{
			Text = text;
			Default = defaultText;
			Placeholder = placeholder;
		}
		public JObject GetData()
		{
			var j = new JObject
			{
				{ "type", "input" },
				{ "text", Text },
				{ "placeholder", Placeholder },
				{ "default", Default }
			};
			return j;
		}

		public abstract void Process(Player player, object value);
	}
}
