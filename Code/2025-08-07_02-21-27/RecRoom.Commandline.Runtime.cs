using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.NoEngine.Common;
using UJect;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Commandline_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8900710", Offset = "0x88FF310", VA = "0x188900710", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface XKGFAQFEAAW
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string OZKFWVQIHRE(string a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RZVDWEYXAFU(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum UnityLauncher
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		MobileHome
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.NoEngine.Common.Preserve]
	public class CommandLineManager : XKGFAQFEAAW
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<string> ODHRAPBFWZT;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static string[] PGPOOCPLJMK;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static string[] ZICIESKALLS;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static string[] OVVHIJGNJLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x88FFF30", Offset = "0x88FEB30", VA = "0x1888FFF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static string[] BGCZQEPDFYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x89004C0", Offset = "0x88FF0C0", VA = "0x1889004C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8900070", Offset = "0x88FEC70", VA = "0x188900070")]
		[IFIZWETSKCB.Root]
		internal static void KQEBINAABYI(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89003B0", Offset = "0x88FEFB0", VA = "0x1889003B0")]
		internal static string[] TMDXPHZKQNU(string[] a, string[] b, List<string> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8900660", Offset = "0x88FF260", VA = "0x188900660", Slot = "4")]
		private string ZUOTRAURYNJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89001C0", Offset = "0x88FEDC0", VA = "0x1889001C0")]
		public static string OZKFWVQIHRE(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8900270", Offset = "0x88FEE70", VA = "0x188900270", Slot = "5")]
		private bool PRSSDQBGVXN(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8900310", Offset = "0x88FEF10", VA = "0x188900310")]
		public static bool RZVDWEYXAFU(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88FFF40", Offset = "0x88FEB40", VA = "0x1888FFF40")]
		public static void GSDIDVXQLCC(IEnumerable<string> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8900160", Offset = "0x88FED60", VA = "0x188900160")]
		private static void KRQXWTAYWWS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public CommandLineManager()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
