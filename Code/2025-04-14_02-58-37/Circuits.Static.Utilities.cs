using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class KAGJFNAGCHH<TData> : HELNIKNELLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string JKDKJBPPNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData LPLAAGCJFBO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
	public override string CENGCFKJIFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4DDD470", Offset = "0x4DDBE70", VA = "0x184DDD470")]
	internal KAGJFNAGCHH(string FLPDJFEEMLN, [In] TData DFPGGEDGGGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BKBDGNEOEEP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x270DE70", Offset = "0x270C870", VA = "0x18270DE70")]
	public static KAGJFNAGCHH<HGCBNLHKPOI> DDDHPONDPCL(string FLPDJFEEMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x33B88C0", Offset = "0x33B72C0", VA = "0x1833B88C0")]
	public static KAGJFNAGCHH<TData> DDDHPONDPCL<TData>(string FLPDJFEEMLN, [In] TData DFPGGEDGGGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BFALEIBEEIF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x33B02B0", Offset = "0x33AECB0", VA = "0x1833B02B0")]
	public static CEGCKGHHPPP<TOk, LLCKKJAFJEM> NEMAEOCBCDC<TOk>([In] this CEGCKGHHPPP<TOk, LLCKKJAFJEM> IJPDNJELPLO, string FLPDJFEEMLN)
	{
		return default(CEGCKGHHPPP<TOk, LLCKKJAFJEM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HELNIKNELLA : MJKMNFLLIGE, LLCKKJAFJEM, ACEELKDBFDK
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x26CCB40", Offset = "0x26CB540", VA = "0x1826CCB40")]
	protected HELNIKNELLA()
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
