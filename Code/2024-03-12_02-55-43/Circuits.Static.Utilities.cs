using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class IPPECJJFLEP<TData> : DLKKNPCBHBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string FANNLPKLMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData DOMOOIMCODE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "7")]
	public override string OKCJCMAJCGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x38E4F60", Offset = "0x38E4160", VA = "0x1838E4F60")]
	internal IPPECJJFLEP(string LFMFEFFGFLH, [In] TData GKNJGNIHLDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DMIFBHOGIGH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E16FD0", Offset = "0x1E161D0", VA = "0x181E16FD0")]
	public static IPPECJJFLEP<PGENBOHGKNI> GOMGEEBODDD(string LFMFEFFGFLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2614FA0", Offset = "0x26141A0", VA = "0x182614FA0")]
	public static IPPECJJFLEP<TData> GOMGEEBODDD<TData>(string LFMFEFFGFLH, [In] TData GKNJGNIHLDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JLLGKKNGJLB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27F0D80", Offset = "0x27EFF80", VA = "0x1827F0D80")]
	public static BLNBDNPDEEM<TOk, NGDCAOKOLMO> BNELAMCJCJI<TOk>([In] this BLNBDNPDEEM<TOk, NGDCAOKOLMO> KPBGCHDNDLM, string LFMFEFFGFLH)
	{
		return default(BLNBDNPDEEM<TOk, NGDCAOKOLMO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class DLKKNPCBHBE : EICMLFAAIEJ, NGDCAOKOLMO, CHOGLKODFOC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD460", Offset = "0x1DDC660", VA = "0x181DDD460")]
	protected DLKKNPCBHBE()
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
