using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class FKIOHHKNCAP<TData> : IPEMGGHMFOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string NNEKJCMAIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData OJPNFDCEOJE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
	public override string AGPNECGLHAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x384ADF0", Offset = "0x3849BF0", VA = "0x18384ADF0")]
	internal FKIOHHKNCAP(string HPJAAILCALJ, [In] TData LHODDAGAJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FLGGEEIEEPL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E862E0", Offset = "0x1E850E0", VA = "0x181E862E0")]
	public static FKIOHHKNCAP<CDPLPCBKJFN> KHDJPNLCMFA(string HPJAAILCALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x26AC750", Offset = "0x26AB550", VA = "0x1826AC750")]
	public static FKIOHHKNCAP<TData> KHDJPNLCMFA<TData>(string HPJAAILCALJ, [In] TData LHODDAGAJKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MJJFIBBIEOE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x298CE30", Offset = "0x298BC30", VA = "0x18298CE30")]
	public static PJPNKGNAEHO<TOk, IIPPAHIAEHC> EAHMHAIJAPB<TOk>([In] this PJPNKGNAEHO<TOk, IIPPAHIAEHC> ILACEKALGJH, string HPJAAILCALJ)
	{
		return default(PJPNKGNAEHO<TOk, IIPPAHIAEHC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class IPEMGGHMFOC : PCJEOFJNKHC, IIPPAHIAEHC, KFOBAHPPIAN
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DDB0", Offset = "0x1E4CBB0", VA = "0x181E4DDB0")]
	protected IPEMGGHMFOC()
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
