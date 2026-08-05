using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NGAPOCJJMKE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x704FD60", Offset = "0x704E360", VA = "0x18704FD60")]
	public static DKNEJNNPJGM PEGIGFCKLEH([In] this Color HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x704FD30", Offset = "0x704E330", VA = "0x18704FD30")]
	public static Color OJPHNAHFOOE(this DKNEJNNPJGM HLIDMKMINHN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x704FCB0", Offset = "0x704E2B0", VA = "0x18704FCB0")]
	public static Color? BMBHAKFLFEP(this DKNEJNNPJGM HLIDMKMINHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LMHAMDJEDJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x704F9F0", Offset = "0x704DFF0", VA = "0x18704F9F0")]
	public static Quaternion LLBPLCLLMAD(CMMJAGENINM MMDLBEBNCGC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x704F900", Offset = "0x704DF00", VA = "0x18704F900")]
	public static AJLJAMJBKND HCFODNDJFIN(Quaternion DKBPHIAJPLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x704FC10", Offset = "0x704E210", VA = "0x18704FC10")]
	public static Quaternion MKHHHCOOHGI(AJLJAMJBKND MMDLBEBNCGC)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FDLKDAAAOFN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x704F880", Offset = "0x704DE80", VA = "0x18704F880")]
	public static PHEPNNMDHID PEGIGFCKLEH([In] this Quaternion HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x704F810", Offset = "0x704DE10", VA = "0x18704F810")]
	public static Quaternion OJPHNAHFOOE(this PHEPNNMDHID HLIDMKMINHN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x704F770", Offset = "0x704DD70", VA = "0x18704F770")]
	public static Quaternion? BMBHAKFLFEP(this PHEPNNMDHID HLIDMKMINHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DCBCIGNMPOG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x704F590", Offset = "0x704DB90", VA = "0x18704F590")]
	public static GGKLJCKENNM PEGIGFCKLEH([In] this Vector2 HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x704F530", Offset = "0x704DB30", VA = "0x18704F530")]
	public static Vector2 OJPHNAHFOOE(this GGKLJCKENNM HLIDMKMINHN)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DHLEAIDLGCG
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x704F700", Offset = "0x704DD00", VA = "0x18704F700")]
	public static AJLJAMJBKND PEGIGFCKLEH([In] this Vector3 HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x704F690", Offset = "0x704DC90", VA = "0x18704F690")]
	public static Vector3 OJPHNAHFOOE(this AJLJAMJBKND HLIDMKMINHN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x704F600", Offset = "0x704DC00", VA = "0x18704F600")]
	public static Vector3? BMBHAKFLFEP(this AJLJAMJBKND HLIDMKMINHN)
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
