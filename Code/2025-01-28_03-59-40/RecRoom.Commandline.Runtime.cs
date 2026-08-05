using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Commandline_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x714CA30", Offset = "0x714BC30", VA = "0x18714CA30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JMOPHKIMIHA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LBJCOFFCCJJ(string DHKGEFAKBIG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MCGHLHFENND(string DHKGEFAKBIG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum PDPDLDOEFAI
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class NNGEKHCMFAI : JMOPHKIMIHA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> FLBLBCNJMKI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] MFPDOIPNIOK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] CHGBFCBMEOM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] ICLHEGAOBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x714C860", Offset = "0x714BA60", VA = "0x18714C860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] JBKKFECKELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x714C3C0", Offset = "0x714B5C0", VA = "0x18714C3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x714C620", Offset = "0x714B820", VA = "0x18714C620")]
	[NAOGKPPNIGE.PBOHCEMILCE]
	internal static void EMFHCKBHCPB(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x714C870", Offset = "0x714BA70", VA = "0x18714C870")]
	internal static string[] OBLCOOLFLMK(string[] GFLLJLFIKHA, string[] HCEGBKGJILO, List<string> MGPCFKNFMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x714C570", Offset = "0x714B770", VA = "0x18714C570", Slot = "4")]
	private string EEAMGGJHBEF(string DHKGEFAKBIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x714C710", Offset = "0x714B910", VA = "0x18714C710")]
	public static string LBJCOFFCCJJ(string DHKGEFAKBIG, [Optional] string JEBHMGJFPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x714C990", Offset = "0x714BB90", VA = "0x18714C990", Slot = "5")]
	private bool PPDAMHDEOHO(string DHKGEFAKBIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x714C7C0", Offset = "0x714B9C0", VA = "0x18714C7C0")]
	public static bool MCGHLHFENND(string DHKGEFAKBIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public NNGEKHCMFAI()
	{
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
