using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BHBOINMBPLN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61173F0", Offset = "0x61161F0", VA = "0x1861173F0")]
	public static KeepsakeTheme KHDMEEBNFEI(this JMOFPCENPDH LIDMLHOMNDK, Guid IDGPLJCMDKB)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61174E0", Offset = "0x61162E0", VA = "0x1861174E0")]
	public static KeepsakeTheme KHDMEEBNFEI(this JMOFPCENPDH LIDMLHOMNDK, JOIHFCCLJHG BPNHKJANNJA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6117590", Offset = "0x6116390", VA = "0x186117590")]
	public static List<KeepsakeTheme> LIKMBJCGPPC(this JMOFPCENPDH LIDMLHOMNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6117360", Offset = "0x6116160", VA = "0x186117360")]
	public static JOIHFCCLJHG JMLGIIDAEJM(this JMOFPCENPDH LIDMLHOMNDK, Guid IDGPLJCMDKB)
	{
		return default(JOIHFCCLJHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6117650", Offset = "0x6116450", VA = "0x186117650")]
	public static int PIPMBDCKBMN(this JMOFPCENPDH LIDMLHOMNDK, JOIHFCCLJHG ADMHPKBIMLN)
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
