using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class IGKDLFBCJHM<TData> : BCMJKIOOIBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string FINCLBNLBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData ODKGCMKKMAA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
	public override string CPMOFLNCDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4A5A300", Offset = "0x4A59700", VA = "0x184A5A300")]
	internal IGKDLFBCJHM(string FGEBHLNNMNH, [In] TData AOFGGGKINCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EJBBDDJKKNB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2771FF0", Offset = "0x27713F0", VA = "0x182771FF0")]
	public static IGKDLFBCJHM<FGGPIMEAIEJ> FABCCGGAHMJ(string FGEBHLNNMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x34FC3B0", Offset = "0x34FB7B0", VA = "0x1834FC3B0")]
	public static IGKDLFBCJHM<TData> FABCCGGAHMJ<TData>(string FGEBHLNNMNH, [In] TData AOFGGGKINCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PIPLGIFLKEC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x38C1410", Offset = "0x38C0810", VA = "0x1838C1410")]
	public static BECHBBIPIFM<TOk, FFKOEKDBPON> KOAGKDPFGFK<TOk>([In] this BECHBBIPIFM<TOk, FFKOEKDBPON> KBBJDOAJMAF, string FGEBHLNNMNH)
	{
		return default(BECHBBIPIFM<TOk, FFKOEKDBPON>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class BCMJKIOOIBO : IDMJKCLDJLO, FFKOEKDBPON, HAPFLJDLPEC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x272E960", Offset = "0x272DD60", VA = "0x18272E960")]
	protected BCMJKIOOIBO()
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
