using MiNET;
using Newtonsoft.Json.Linq;

namespace MiNET.UI.Elements
{
	public class Input : IElement
	{
		public string Text { get; set; }
		public string Placeholder { get; set; }
		public string Default { get; set; }

		public Input(string text = "", string placeholder = "", string defaultText = "")
		{
			Text = text;
			Placeholder = placeholder;
			Default = defaultText;
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

		public virtual void Process(Player player, object value)
		{
		}
	}
}
