using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FKPBCBEJBLE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x42118C0", Offset = "0x42100C0", VA = "0x1842118C0")]
	public static ADFOJBMGHDI BAGHAKDDGPK(this in Color KBMECNBEFEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4211940", Offset = "0x4210140", VA = "0x184211940")]
	public static Color JDKEMADGCJE(this ADFOJBMGHDI KBMECNBEFEN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x42119B0", Offset = "0x42101B0", VA = "0x1842119B0")]
	public static Color? NBNNIPDOAEL(this ADFOJBMGHDI KBMECNBEFEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HMMEJHGGENM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4211C20", Offset = "0x4210420", VA = "0x184211C20")]
	public static Quaternion LIOIAPCJAAL(IFEODHBBFDH DMDONNOOOJK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4211A80", Offset = "0x4210280", VA = "0x184211A80")]
	public static ADNLNHOEKEH GIIAHFAJDJJ(Quaternion CHFIDHNPLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4211B20", Offset = "0x4210320", VA = "0x184211B20")]
	public static Quaternion GPDKKJIIIIB(ADNLNHOEKEH DMDONNOOOJK)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NBGPENGFGIE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4211E90", Offset = "0x4210690", VA = "0x184211E90")]
	public static NHNCLKBPOFE BAGHAKDDGPK(this in Quaternion KBMECNBEFEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x42120A0", Offset = "0x42108A0", VA = "0x1842120A0")]
	public static NHNCLKBPOFE OOEPGDPHFCG(this in Quaternion? KBMECNBEFEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4211F10", Offset = "0x4210710", VA = "0x184211F10")]
	public static Quaternion JDKEMADGCJE(this NHNCLKBPOFE KBMECNBEFEN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4211FD0", Offset = "0x42107D0", VA = "0x184211FD0")]
	public static Quaternion? NBNNIPDOAEL(this NHNCLKBPOFE KBMECNBEFEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ONFMGFEMPFK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4212150", Offset = "0x4210950", VA = "0x184212150")]
	public static ADNLNHOEKEH BAGHAKDDGPK(this in Vector3 KBMECNBEFEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4212330", Offset = "0x4210B30", VA = "0x184212330")]
	public static ADNLNHOEKEH OOEPGDPHFCG(this in Vector3? KBMECNBEFEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x42121C0", Offset = "0x42109C0", VA = "0x1842121C0")]
	public static Vector3 JDKEMADGCJE(this ADNLNHOEKEH KBMECNBEFEN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4212270", Offset = "0x4210A70", VA = "0x184212270")]
	public static Vector3? NBNNIPDOAEL(this ADNLNHOEKEH KBMECNBEFEN)
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
