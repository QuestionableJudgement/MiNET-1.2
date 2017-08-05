using System;
using MiNET;
using Newtonsoft.Json.Linq;

namespace MiNET.UI.Elements
{
	abstract public class Button : IElement
	{
		public string Text { get; set; }
		public string Image { get; set; }

		public Button(string text = "", string image = null)
		{
			Text = text;
			Image = image;
		}
		public JObject GetData()
		{
			var j = new JObject
			{
				{ "text", Text }
			};
			if (Image != null) j.Add("image", new JObject
			{
				{ "type", "url" },
				{ "data", Image }
			});
			return j;
		}

		public abstract void Process(Player player, object value);
	}
}
