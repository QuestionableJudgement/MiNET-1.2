using System;
using MiNET;
using Newtonsoft.Json.Linq;
using MiNET.UI.Elements;
using System.Collections.Generic;

namespace MiNET.UI.Forms
{
	public class ModalForm : IForm
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public List<Button> Buttons { get; set; }

		public ModalForm(string title, string content = "")
		{
			Title = title;
			Buttons = new List<Button>(2);
		}


		public string GetData()
		{
			var j = new JObject
			{
				{ "type", "form" },
				{ "title", Title },
				{ "content", Content },
				{ "buttons", GetButtons() }
			};
			return j.ToString(Newtonsoft.Json.Formatting.None);
		}

		public JArray GetButtons()
		{
			var j = new JArray();
			foreach (var button in Buttons)
			{
				j.Add(button);
			}
			return j;
		}

		public void Process(Player player, JArray response)
		{

		}
	}
}
