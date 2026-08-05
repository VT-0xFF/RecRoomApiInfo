using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NBADDPHEKEC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72C58A0", Offset = "0x72C46A0", VA = "0x1872C58A0")]
	public static KeepsakeTheme KOIDJFACLGA(this KGJJNCGCPGF HLDNIAJEGKP, Guid MJDLHFNFBNN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72C57F0", Offset = "0x72C45F0", VA = "0x1872C57F0")]
	public static KeepsakeTheme KOIDJFACLGA(this KGJJNCGCPGF HLDNIAJEGKP, MJGAMLALHAD ANMGANHBFJC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72C5680", Offset = "0x72C4480", VA = "0x1872C5680")]
	public static List<KeepsakeTheme> IDANEAINICL(this KGJJNCGCPGF HLDNIAJEGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72C5750", Offset = "0x72C4550", VA = "0x1872C5750")]
	public static MJGAMLALHAD INGBNEOIKMC(this KGJJNCGCPGF HLDNIAJEGKP, Guid MJDLHFNFBNN)
	{
		return default(MJGAMLALHAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72C55F0", Offset = "0x72C43F0", VA = "0x1872C55F0")]
	public static int GCKCKFGLGOP(this KGJJNCGCPGF HLDNIAJEGKP, MJGAMLALHAD NJKEIHDFKML)
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
