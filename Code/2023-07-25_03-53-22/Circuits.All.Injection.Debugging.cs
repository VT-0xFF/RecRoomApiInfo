using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CKHPPKLMAGL
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class GEAAKLGDALF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public HEHEJCDOEDL logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GEAAKLGDALF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72DC200", Offset = "0x72DB200", VA = "0x1872DC200")]
		internal bool DDGGOLHAKGP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72DC3E0", Offset = "0x72DB3E0", VA = "0x1872DC3E0")]
		internal void PFNIIHJOHPB(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72DC490", Offset = "0x72DB490", VA = "0x1872DC490")]
		internal bool POFPGCNDPKJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72DC560", Offset = "0x72DB560", VA = "0x1872DC560")]
		internal void PPKPKIOECEC(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72DC260", Offset = "0x72DB260", VA = "0x1872DC260")]
		internal bool GCJLHBIGHJK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72DC330", Offset = "0x72DB330", VA = "0x1872DC330")]
		internal void NJACJCGJMCA(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly ODHFFBPKHBB HIEJPGCOIBA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72DBD90", Offset = "0x72DAD90", VA = "0x1872DBD90")]
	private static KIKBMOCMKHB KJLKFMCNDJE(HEHEJCDOEDL HGLKINMLAIG)
	{
		return default(KIKBMOCMKHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72DB4E0", Offset = "0x72DA4E0", VA = "0x1872DB4E0")]
	private static ODHFFBPKHBB GICBFKBAANP()
	{
		return default(ODHFFBPKHBB);
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
