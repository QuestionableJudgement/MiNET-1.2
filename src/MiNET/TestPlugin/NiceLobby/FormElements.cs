using MiNET.UI.Elements;
using MiNET;

namespace TestPlugin.NiceLobby
{
	public class MyToggle : Toggle
	{
		public MyToggle(string text = "", bool defaultValue = false) : base(text, defaultValue)
		{
		}

		public override void Process(Player player, object value)
		{
			var boolean = (bool)value;
			if(boolean)
			{
				player.SendMessage("Griefing enabled!!!! undrfined is coming to grief you!!!!");
			} else
			{
				player.SendMessage("Griefing disabled");
			}
		}
	}
}
