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
		[Cpp2IlInjected.Address(RVA = "0x8392F50", Offset = "0x8391D50", VA = "0x188392F50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2993B20", Offset = "0x2992920", VA = "0x182993B20")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface ZJUPIDBSBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string EIWKHZVEBPC(string a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MJMZBNBCMBG(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.NoEngine.Common.Preserve]
	public class CommandLineManager : ZJUPIDBSBPO
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static List<string> PPTYWLZMGSX;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static string[] DPTPLNUNRZC;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static string[] DMGNADCRBVM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static string[] VOISQSSATGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8392D80", Offset = "0x8391B80", VA = "0x188392D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static string[] WCUIRCHRNET
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8392900", Offset = "0x8391700", VA = "0x188392900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8392AA0", Offset = "0x83918A0", VA = "0x188392AA0")]
		[XNELNNYDNRZ.Root]
		internal static void AMOQIHAHUJI(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8392D90", Offset = "0x8391B90", VA = "0x188392D90")]
		internal static string[] SKJRAVMFFLC(string[] a, string[] b, List<string> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8392EA0", Offset = "0x8391CA0", VA = "0x188392EA0", Slot = "4")]
		private string ZDHFISUJPSR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8392C30", Offset = "0x8391A30", VA = "0x188392C30")]
		public static string EIWKHZVEBPC(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8392B90", Offset = "0x8391990", VA = "0x188392B90", Slot = "5")]
		private bool CYXVQXOTQFL(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8392CE0", Offset = "0x8391AE0", VA = "0x188392CE0")]
		public static bool MJMZBNBCMBG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
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
