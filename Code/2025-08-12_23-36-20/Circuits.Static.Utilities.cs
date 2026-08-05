using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class MOBNDCDEAKM<TData> : FCKCACEJLLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string KFFFDCFEBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData CFOLCKLFPKO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
	public override string PGDOAEFAHEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x59022C0", Offset = "0x59010C0", VA = "0x1859022C0")]
	internal MOBNDCDEAKM(string JDFCBBCKOGJ, [In] TData KANAIIDGHCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MNJJGJBMGCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2B45760", Offset = "0x2B44560", VA = "0x182B45760")]
	public static MOBNDCDEAKM<GFJAPJIFDGB> ELDPFIHNJDG(string JDFCBBCKOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B53E10", Offset = "0x3B52C10", VA = "0x183B53E10")]
	public static MOBNDCDEAKM<TData> ELDPFIHNJDG<TData>(string JDFCBBCKOGJ, [In] TData KANAIIDGHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HCCOGNJHKIG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D0AD30", Offset = "0x3D09B30", VA = "0x183D0AD30")]
	public static GECIHKBMECG<TOk, HFPJGMECLBA> BMKEFILNCHC<TOk>([In] this GECIHKBMECG<TOk, HFPJGMECLBA> DBBEADIHLKO, string JDFCBBCKOGJ)
	{
		return default(GECIHKBMECG<TOk, HFPJGMECLBA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class FCKCACEJLLC : NILBFGOPNAM, HFPJGMECLBA, FHNKPFADLOA
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2AFF800", Offset = "0x2AFE600", VA = "0x182AFF800")]
	protected FCKCACEJLLC()
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
