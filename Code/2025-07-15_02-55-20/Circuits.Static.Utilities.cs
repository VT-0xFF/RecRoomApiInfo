using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class GMPLBENODLG<TData> : HIMPFMKCELK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string GDBNPINLGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData OHABHFNOKHJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
	public override string BAMDPIFKGNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4F16040", Offset = "0x4F14C40", VA = "0x184F16040")]
	internal GMPLBENODLG(string HLMEMBFCHLD, [In] TData CBCNBAPLLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OAECFADNHJD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A89930", Offset = "0x2A88530", VA = "0x182A89930")]
	public static GMPLBENODLG<DIKEICNGGBM> MJMNOIPJNFN(string HLMEMBFCHLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3187C80", Offset = "0x3186880", VA = "0x183187C80")]
	public static GMPLBENODLG<TData> MJMNOIPJNFN<TData>(string HLMEMBFCHLD, [In] TData CBCNBAPLLJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NGCJPNIPCPG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5A00", Offset = "0x3DC4600", VA = "0x183DC5A00")]
	public static IADHIMOENNN<TOk, KHGGKMBDLJL> CIPOFGLLFIJ<TOk>([In] this IADHIMOENNN<TOk, KHGGKMBDLJL> JBDFDFABHKD, string HLMEMBFCHLD)
	{
		return default(IADHIMOENNN<TOk, KHGGKMBDLJL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HIMPFMKCELK : CLKLDHBJINM, KHGGKMBDLJL, KLHHEJIOGEP
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A41B70", Offset = "0x2A40770", VA = "0x182A41B70")]
	protected HIMPFMKCELK()
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
