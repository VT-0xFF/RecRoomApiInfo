using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class FODEPEOENBA<TData> : HIMCMICGGGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string IDHPNAJLNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData IDDGLNBEBBG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
	public override string DGMFKNHADKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3430890", Offset = "0x342F090", VA = "0x183430890")]
	internal FODEPEOENBA(string BKGEBGGPBLH, [In] TData AELCABDCBDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AMKLGPOMNKK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1C722A0", Offset = "0x1C70AA0", VA = "0x181C722A0")]
	public static FODEPEOENBA<JGIANJFFIJK> KKMBICLNKPK(string BKGEBGGPBLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x22229A0", Offset = "0x22211A0", VA = "0x1822229A0")]
	public static FODEPEOENBA<TData> KKMBICLNKPK<TData>(string BKGEBGGPBLH, [In] TData AELCABDCBDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IOBDFMIHGNH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x239ADB0", Offset = "0x23995B0", VA = "0x18239ADB0")]
	public static EOPMGLNDIOA<TOk, NHKNMEADEEO> GNBOKPHLCFC<TOk>([In] this EOPMGLNDIOA<TOk, NHKNMEADEEO> AFFJMIFONEM, string BKGEBGGPBLH)
	{
		return default(EOPMGLNDIOA<TOk, NHKNMEADEEO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HIMCMICGGGI : BJFJCNKKJDP, NHKNMEADEEO, HNHFFBALMII
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1C3E3A0", Offset = "0x1C3CBA0", VA = "0x181C3E3A0")]
	protected HIMCMICGGGI()
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
