using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BDEMICOOGKK
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class CMGFFJDPOFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public HMDPMDHAOOB logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CMGFFJDPOFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29EF840", Offset = "0x29EEC40", VA = "0x1829EF840")]
		internal bool PLHNGJFCNDP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29EF580", Offset = "0x29EE980", VA = "0x1829EF580")]
		internal void IAAIFGEPAGK(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29EF630", Offset = "0x29EEA30", VA = "0x1829EF630")]
		internal bool KGEKOPBOKLD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x29EF4D0", Offset = "0x29EE8D0", VA = "0x1829EF4D0")]
		internal void HDMEENANIEA(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x29EF6E0", Offset = "0x29EEAE0", VA = "0x1829EF6E0")]
		internal bool NIIKDPJLHNL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x29EF790", Offset = "0x29EEB90", VA = "0x1829EF790")]
		internal void OEEGBOBCIAD(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CCEPFBMKDDG NKAKNKMIPPI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x29EF040", Offset = "0x29EE440", VA = "0x1829EF040")]
	private static FKBHHMKLPBN LKKEJEJKCAH(HMDPMDHAOOB KNHCLOHOEPC)
	{
		return default(FKBHHMKLPBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x29EE740", Offset = "0x29EDB40", VA = "0x1829EE740")]
	private static CCEPFBMKDDG FOKNECEOCHP()
	{
		return default(CCEPFBMKDDG);
	}
}
namespace Cpp2IlInjected;

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
