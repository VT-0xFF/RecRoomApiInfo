using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class CPGHOKNIIGK<TData> : BPHLMNENOKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string IFJJAPFHAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData PICICNMEMLG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "7")]
	public override string BLGDHPMKGMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E453A0", Offset = "0x4E43DA0", VA = "0x184E453A0")]
	internal CPGHOKNIIGK(string CPPFNMDMGHI, [In] TData ABDLEBPKDKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GBFJIILJHKL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1090", Offset = "0x1ECFA90", VA = "0x181ED1090")]
	public static CPGHOKNIIGK<PHKKIFFGKBG> OLCPJHCMOKI(string CPPFNMDMGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2716500", Offset = "0x2714F00", VA = "0x182716500")]
	public static CPGHOKNIIGK<TData> OLCPJHCMOKI<TData>(string CPPFNMDMGHI, [In] TData ABDLEBPKDKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FKNEHAEKLPO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x293C0A0", Offset = "0x293AAA0", VA = "0x18293C0A0")]
	public static LGGHGMLBJFM<TOk, DGFMPJAMJNO> ODKGHCFCCII<TOk>([In] this LGGHGMLBJFM<TOk, DGFMPJAMJNO> CMJEIEIDHIK, string CPPFNMDMGHI)
	{
		return default(LGGHGMLBJFM<TOk, DGFMPJAMJNO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class BPHLMNENOKN : LJNADPDGEHJ, DGFMPJAMJNO, CEAFENKMCFB
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E97220", Offset = "0x1E95C20", VA = "0x181E97220")]
	protected BPHLMNENOKN()
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
