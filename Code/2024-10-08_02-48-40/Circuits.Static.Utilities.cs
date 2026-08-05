using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class IHFBEOFDFGB<TData> : GDNNKDPAIAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string PGKAKDMACJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData OMAPODLEEDD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
	public override string PBDEAEJPOGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4173F30", Offset = "0x4173130", VA = "0x184173F30")]
	internal IHFBEOFDFGB(string ADNFLGLLNKI, [In] TData LJIEGDEDOHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HIMFOCOIFAK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2264E40", Offset = "0x2264040", VA = "0x182264E40")]
	public static IHFBEOFDFGB<EPFCCNCFAEJ> MIFIOLMMIDE(string ADNFLGLLNKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2C25C10", Offset = "0x2C24E10", VA = "0x182C25C10")]
	public static IHFBEOFDFGB<TData> MIFIOLMMIDE<TData>(string ADNFLGLLNKI, [In] TData LJIEGDEDOHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EECOKIGOHGG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C935F0", Offset = "0x2C927F0", VA = "0x182C935F0")]
	public static KJEOKHCIBGM<TOk, IJNOPJPLCIM> PGECEAANPOM<TOk>([In] this KJEOKHCIBGM<TOk, IJNOPJPLCIM> AEFKHDNCNFD, string ADNFLGLLNKI)
	{
		return default(KJEOKHCIBGM<TOk, IJNOPJPLCIM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class GDNNKDPAIAP : KKIKBNLICGH, IJNOPJPLCIM, NDNNGNKGHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2226AD0", Offset = "0x2225CD0", VA = "0x182226AD0")]
	protected GDNNKDPAIAP()
	{
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
