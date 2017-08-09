using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using log4net;
using Button = MiNET.UI.Elements.Button;

namespace MiNET.UI.Forms
{
	public class ButtonsForm : IForm
	{
		protected static readonly ILog Log = LogManager.GetLogger(typeof (ButtonsForm));
		public string Title { get; set; }
		public string Content { get; set; }
		public List<Button> Buttons { get; set; }

		public ButtonsForm(string title, string content = "")
		{
			Title = title;
			Content = content;
			Buttons = new List<Button>();
		}

		public string GetData()
		{
			var buttons = GetButtons();
			var j = new JObject
			{
				{ "type", "form" },
				{ "title", Title },
				{ "content", Content },
				{ "buttons", buttons }
			};
			return j.ToString(Newtonsoft.Json.Formatting.None);
		}

		public void AddButton(Button button)
		{
			Buttons.Add(button);
		}
		
		public JArray GetButtons()
		{
			var j = new JArray();
			foreach(var button in Buttons)
			{
				j.Add(button.GetData());
			}
			return j;
		}

		public virtual void Process(Player player, string response)
		{
			try
			{
				Buttons[int.Parse(response)].Process(player, response);
			}
			catch(Exception e)
			{
				Log.Error(e);
			}
		}
	}
}
