using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class LOKBFKBJGOL<TData> : MBFBMDOADGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string MHEEAEBIAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData NCANEPOJAJP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
	public override string KHCKPFAHKDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3BE43E0", Offset = "0x3BE37E0", VA = "0x183BE43E0")]
	internal LOKBFKBJGOL(string CAIOIMEOMNJ, [In] TData ALPLHOOHPEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LAFFJDPGLIG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1D94720", Offset = "0x1D93B20", VA = "0x181D94720")]
	public static LOKBFKBJGOL<MKHCJDDCMIA> CPLKLKACALP(string CAIOIMEOMNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2455E00", Offset = "0x2455200", VA = "0x182455E00")]
	public static LOKBFKBJGOL<TData> CPLKLKACALP<TData>(string CAIOIMEOMNJ, [In] TData ALPLHOOHPEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PMDAEJMLEAM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2828D80", Offset = "0x2828180", VA = "0x182828D80")]
	public static IAPKJCHKLLD<TOk, HDKPGPNEBBO> AEKIONEOCNB<TOk>([In] this IAPKJCHKLLD<TOk, HDKPGPNEBBO> LOMPFKEACIP, string CAIOIMEOMNJ)
	{
		return default(IAPKJCHKLLD<TOk, HDKPGPNEBBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class MBFBMDOADGG : PKAEFJIJPHG, HDKPGPNEBBO, LKFFGCCEJDH
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1D5BB30", Offset = "0x1D5AF30", VA = "0x181D5BB30")]
	protected MBFBMDOADGG()
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
