using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MHCBFAODHLN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64AFA50", Offset = "0x64AE450", VA = "0x1864AFA50")]
	public static FGGJNPKPFLG JHPOCMCIPNJ(this in Color DCIIOIKIJFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64AF9F0", Offset = "0x64AE3F0", VA = "0x1864AF9F0")]
	public static Color AJGJBLGJHIK(this FGGJNPKPFLG DCIIOIKIJFP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64AFAD0", Offset = "0x64AE4D0", VA = "0x1864AFAD0")]
	public static Color? MOBAFLOCHEE(this FGGJNPKPFLG DCIIOIKIJFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BBOMPNBPJNO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x64AF600", Offset = "0x64AE000", VA = "0x1864AF600")]
	public static Quaternion ANOCEMCFNAE(FAHBINGAEAL NIPBPKPBPPP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64AF800", Offset = "0x64AE200", VA = "0x1864AF800")]
	public static EHHOPHBLIMK OCGMCMOEHFB(Quaternion BEKJCCNMIMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x64AF790", Offset = "0x64AE190", VA = "0x1864AF790")]
	public static Quaternion FGDCMNKAHJF(EHHOPHBLIMK NIPBPKPBPPP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AKMGFILAPLK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x64AF4C0", Offset = "0x64ADEC0", VA = "0x1864AF4C0")]
	public static FIPBPINLCAH JHPOCMCIPNJ(this in Quaternion DCIIOIKIJFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64AF460", Offset = "0x64ADE60", VA = "0x1864AF460")]
	public static Quaternion AJGJBLGJHIK(this FIPBPINLCAH DCIIOIKIJFP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x64AF540", Offset = "0x64ADF40", VA = "0x1864AF540")]
	public static Quaternion? MOBAFLOCHEE(this FIPBPINLCAH DCIIOIKIJFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DBBHIOKBGGO
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x64AF8F0", Offset = "0x64AE2F0", VA = "0x1864AF8F0")]
	public static EHHOPHBLIMK JHPOCMCIPNJ(this in Vector3 DCIIOIKIJFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64AF8A0", Offset = "0x64AE2A0", VA = "0x1864AF8A0")]
	public static Vector3 AJGJBLGJHIK(this EHHOPHBLIMK DCIIOIKIJFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x64AF960", Offset = "0x64AE360", VA = "0x1864AF960")]
	public static Vector3? MOBAFLOCHEE(this EHHOPHBLIMK DCIIOIKIJFP)
	{
		return null;
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
