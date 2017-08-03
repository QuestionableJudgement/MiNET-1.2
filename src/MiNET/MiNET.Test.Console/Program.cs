using MiNET.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiNET.Test.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			//MinetAnvilTest test = new MinetAnvilTest();
			//test.LoadFullAnvilRegionLoadTest();

			/*MinetServerTest tests = new MinetServerTest();
			tests.HighPrecTimerSignalingLoadTest();
			System.Console.WriteLine("Running ...");

			System.Console.WriteLine("<Enter> to ABORT");
			System.Console.ReadLine();
			tests.cancel.Cancel();

			tests.PrintResults();

			System.Console.WriteLine("<Enter> to exit");
			System.Console.ReadLine();*/
			var hex = "7ce74296b1120000330000001e0200000000803f0000803fa8ce84b97ce74296";
			var bytes = Enumerable.Range(0, hex.Length)
					 .Where(x => x % 2 == 0)
					 .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
					 .ToArray();
			var t = (McpePlaySound)PackageFactory.CreatePackage(0x56, bytes, "mcpe");

			System.Console.WriteLine(t.coordinates + ", " + t.name + ", " + t.pitch);
			System.Console.ReadLine();
		}
	}
}
