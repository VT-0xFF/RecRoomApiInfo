using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DFAMJLMMEEN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x85546D0", Offset = "0x8552CD0", VA = "0x1885546D0")]
	public static KeepsakeTheme FEONCHDNDAF(this DEPLECABLCP IHEHADIIJNO, Guid KFMICCKACKP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8554610", Offset = "0x8552C10", VA = "0x188554610")]
	public static KeepsakeTheme FEONCHDNDAF(this DEPLECABLCP IHEHADIIJNO, BALHDFAAENP PBBCDOBKLGB)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x85547D0", Offset = "0x8552DD0", VA = "0x1885547D0")]
	public static List<KeepsakeTheme> MAEFGCCGMCM(this DEPLECABLCP IHEHADIIJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x85544E0", Offset = "0x8552AE0", VA = "0x1885544E0")]
	public static BALHDFAAENP DBELOMAEDEJ(this DEPLECABLCP IHEHADIIJNO, Guid KFMICCKACKP)
	{
		return default(BALHDFAAENP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8554580", Offset = "0x8552B80", VA = "0x188554580")]
	public static int EAJMHJPIFKA(this DEPLECABLCP IHEHADIIJNO, BALHDFAAENP JIGKEGKFKMO)
	{
		return default(int);
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
