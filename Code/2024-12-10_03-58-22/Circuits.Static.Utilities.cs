using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class KIEAKAALDCA<TData> : LJHFFGOEJCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LDONEJPFOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData HCNDAPMGMCI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
	public override string GCHBDOEJPND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x42BB1D0", Offset = "0x42B9DD0", VA = "0x1842BB1D0")]
	internal KIEAKAALDCA(string LFKIGNHCOID, [In] TData BFLLAIFBMAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MBLAKPMPJJM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x21CF9D0", Offset = "0x21CE5D0", VA = "0x1821CF9D0")]
	public static KIEAKAALDCA<FKMCALNFICP> LMDPPDEOAIA(string LFKIGNHCOID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B240", Offset = "0x2B89E40", VA = "0x182B8B240")]
	public static KIEAKAALDCA<TData> LMDPPDEOAIA<TData>(string LFKIGNHCOID, [In] TData BFLLAIFBMAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LMBOJNEKKPC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2EDF720", Offset = "0x2EDE320", VA = "0x182EDF720")]
	public static OAMIPODNNBO<TOk, BDMFJEIOIAD> MNIMPEFLDMH<TOk>([In] this OAMIPODNNBO<TOk, BDMFJEIOIAD> GMNCELIMKIF, string LFKIGNHCOID)
	{
		return default(OAMIPODNNBO<TOk, BDMFJEIOIAD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class LJHFFGOEJCA : BGGNEHOKNAC, BDMFJEIOIAD, OILOBAEJEDE
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2190970", Offset = "0x218F570", VA = "0x182190970")]
	protected LJHFFGOEJCA()
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
