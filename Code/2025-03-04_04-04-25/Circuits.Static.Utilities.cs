using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class GHKACFPOLKA<TData> : MPAEBDCEOBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string MADHOOEDLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData FENODPMPHEB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
	public override string BBCHEHFFEBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4556E70", Offset = "0x4555470", VA = "0x184556E70")]
	internal GHKACFPOLKA(string MIALAMIFNLM, [In] TData GIDGOODJFLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IFDMFGAKDIL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x25FAE60", Offset = "0x25F9460", VA = "0x1825FAE60")]
	public static GHKACFPOLKA<IDMEFNAINAN> FEOBEKOIKMG(string MIALAMIFNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x31891A0", Offset = "0x31877A0", VA = "0x1831891A0")]
	public static GHKACFPOLKA<TData> FEOBEKOIKMG<TData>(string MIALAMIFNLM, [In] TData GIDGOODJFLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AFEDFLBADHK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B721F0", Offset = "0x3B707F0", VA = "0x183B721F0")]
	public static JOFBNNGKBOO<TOk, PPAGHPBHFJD> NKEPLPCOAHJ<TOk>([In] this JOFBNNGKBOO<TOk, PPAGHPBHFJD> JDCFMPOHCEA, string MIALAMIFNLM)
	{
		return default(JOFBNNGKBOO<TOk, PPAGHPBHFJD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class MPAEBDCEOBD : PGAGFEIEKID, PPAGHPBHFJD, EAPODONBJNH
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25B8580", Offset = "0x25B6B80", VA = "0x1825B8580")]
	protected MPAEBDCEOBD()
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
