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
		[Cpp2IlInjected.Address(RVA = "0x75210B0", Offset = "0x75202B0", VA = "0x1875210B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HOHILFLCNNI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OLFCJBMAKDB(string OKHEDFBAINB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KBDOPJNGPLB(string OKHEDFBAINB);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HJIOBCDIMBO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class KKLHIFPIELH : HOHILFLCNNI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> BLIJADFKFMD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] PDNLGGIAAHA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] BHCBFKOEBLO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] OHBCLGIIFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7520C10", Offset = "0x751FE10", VA = "0x187520C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] HOEFNKOMNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7520DC0", Offset = "0x751FFC0", VA = "0x187520DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7520C20", Offset = "0x751FE20", VA = "0x187520C20")]
	[LDKBBAENJDF.JPBGCAANJAC]
	internal static void JHDFHEGIBHJ(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7520AF0", Offset = "0x751FCF0", VA = "0x187520AF0")]
	internal static string[] AOMHDHELDEK(string[] FMMDIIKGCFB, string[] HNEAGIHOIPB, List<string> LMJPOJNOJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7520A40", Offset = "0x751FC40", VA = "0x187520A40", Slot = "4")]
	private string ACBBHLHHJEE(string OKHEDFBAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7521000", Offset = "0x7520200", VA = "0x187521000")]
	public static string OLFCJBMAKDB(string OKHEDFBAINB, [Optional] string OGPHJJMKHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7520F60", Offset = "0x7520160", VA = "0x187520F60", Slot = "5")]
	private bool LHKIEADOCOM(string OKHEDFBAINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7520D20", Offset = "0x751FF20", VA = "0x187520D20")]
	public static bool KBDOPJNGPLB(string OKHEDFBAINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public KKLHIFPIELH()
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
