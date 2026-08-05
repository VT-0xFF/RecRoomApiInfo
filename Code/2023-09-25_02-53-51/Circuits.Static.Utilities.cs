using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class PAPLICCHCDP<TData> : PEPMMDADFIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string ALLNCMAEEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData GJGGJKOHCEI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
	public override string EAPOOJKPODL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3DA24F0", Offset = "0x3DA18F0", VA = "0x183DA24F0")]
	internal PAPLICCHCDP(string LMJAPBNMKLG, [In] TData OOIBMCBCEPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BDMMIEPPGIF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1C684A0", Offset = "0x1C678A0", VA = "0x181C684A0")]
	public static PAPLICCHCDP<EOKBOBHHEEM> CLFIPFKIGEN(string LMJAPBNMKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2195370", Offset = "0x2194770", VA = "0x182195370")]
	public static PAPLICCHCDP<TData> CLFIPFKIGEN<TData>(string LMJAPBNMKLG, [In] TData OOIBMCBCEPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ACJNCIFFPNP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29E6610", Offset = "0x29E5A10", VA = "0x1829E6610")]
	public static MEEAMGFNJIM<TOk, DBNOAAMPCCP> GNNECDNJNNA<TOk>([In] this MEEAMGFNJIM<TOk, DBNOAAMPCCP> CLFMFOEGLFG, string LMJAPBNMKLG)
	{
		return default(MEEAMGFNJIM<TOk, DBNOAAMPCCP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class PEPMMDADFIO : PGBNOEKHDBP, DBNOAAMPCCP, IEAOACDDPEG
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1C360A0", Offset = "0x1C354A0", VA = "0x181C360A0")]
	protected PEPMMDADFIO()
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
