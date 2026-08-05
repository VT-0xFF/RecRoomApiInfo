using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class LCJBJKDDJII<TData> : NPDJLDEDKNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData COGAKILOFHK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
	public override string KMIKCFPGPHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4A602C0", Offset = "0x4A5F0C0", VA = "0x184A602C0")]
	internal LCJBJKDDJII(string KKBJAPCBOHH, [In] TData JOAPLPPIFPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CGJFCONMDDI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x25A62D0", Offset = "0x25A50D0", VA = "0x1825A62D0")]
	public static LCJBJKDDJII<ENLEGHEGALI> MKHEJJEDOII(string KKBJAPCBOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3100440", Offset = "0x30FF240", VA = "0x183100440")]
	public static LCJBJKDDJII<TData> MKHEJJEDOII<TData>(string KKBJAPCBOHH, [In] TData JOAPLPPIFPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ELEJHJOJCOC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x316CDC0", Offset = "0x316BBC0", VA = "0x18316CDC0")]
	public static PGOLMGNGGBM<TOk, HJBBDBHAMJJ> GBDDPGJLDEN<TOk>([In] this PGOLMGNGGBM<TOk, HJBBDBHAMJJ> DJAJDIFOIHP, string KKBJAPCBOHH)
	{
		return default(PGOLMGNGGBM<TOk, HJBBDBHAMJJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class NPDJLDEDKNL : MFMDDJMMGHP, HJBBDBHAMJJ, EOABGNINGBC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2564420", Offset = "0x2563220", VA = "0x182564420")]
	protected NPDJLDEDKNL()
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
