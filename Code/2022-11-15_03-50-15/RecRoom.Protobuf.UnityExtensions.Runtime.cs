using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NFMDBJIOIFL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6066110", Offset = "0x6064B10", VA = "0x186066110")]
	public static KIFOFPKKHNL NJDODOCIOLN(this in Color NMDJDCEFNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60660B0", Offset = "0x6064AB0", VA = "0x1860660B0")]
	public static Color GKBAFEAOLLC(this KIFOFPKKHNL NMDJDCEFNDM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6065FF0", Offset = "0x60649F0", VA = "0x186065FF0")]
	public static Color? AAEMALHIEAD(this KIFOFPKKHNL NMDJDCEFNDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AGHOPJDJCJA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6065C00", Offset = "0x6064600", VA = "0x186065C00")]
	public static Quaternion NOBOBDKEHNL(DDHPHJKDDLG PJIINDGLAPJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6065AF0", Offset = "0x60644F0", VA = "0x186065AF0")]
	public static ELFKDPLKGEC ANEPIPENOOL(Quaternion HPCIGKMAHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6065B90", Offset = "0x6064590", VA = "0x186065B90")]
	public static Quaternion DFGIPHIACBL(ELFKDPLKGEC PJIINDGLAPJ)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IHAMMEGJPJI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6065F70", Offset = "0x6064970", VA = "0x186065F70")]
	public static AOJECHMMBAO NJDODOCIOLN(this in Quaternion NMDJDCEFNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6065EB0", Offset = "0x60648B0", VA = "0x186065EB0")]
	public static AOJECHMMBAO HJIAECKLODF(this in Quaternion? NMDJDCEFNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6065E50", Offset = "0x6064850", VA = "0x186065E50")]
	public static Quaternion GKBAFEAOLLC(this AOJECHMMBAO NMDJDCEFNDM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6065D90", Offset = "0x6064790", VA = "0x186065D90")]
	public static Quaternion? AAEMALHIEAD(this AOJECHMMBAO NMDJDCEFNDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OCPCBNFLKMH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6066330", Offset = "0x6064D30", VA = "0x186066330")]
	public static ELFKDPLKGEC NJDODOCIOLN(this in Vector3 NMDJDCEFNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6066270", Offset = "0x6064C70", VA = "0x186066270")]
	public static ELFKDPLKGEC HJIAECKLODF(this in Vector3? NMDJDCEFNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6066220", Offset = "0x6064C20", VA = "0x186066220")]
	public static Vector3 GKBAFEAOLLC(this ELFKDPLKGEC NMDJDCEFNDM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6066190", Offset = "0x6064B90", VA = "0x186066190")]
	public static Vector3? AAEMALHIEAD(this ELFKDPLKGEC NMDJDCEFNDM)
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
