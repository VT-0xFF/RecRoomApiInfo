using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LJKDNDLIEIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60A7B70", Offset = "0x60A6F70", VA = "0x1860A7B70")]
	public static HGFOODEADKA FBLBIDAIACI(this in Color LKINCHDLDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60A7BF0", Offset = "0x60A6FF0", VA = "0x1860A7BF0")]
	public static Color LOHKEOMODAB(this HGFOODEADKA LKINCHDLDIG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60A7C50", Offset = "0x60A7050", VA = "0x1860A7C50")]
	public static Color? MMNKPIGNNKM(this HGFOODEADKA LKINCHDLDIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FIJKFLGILEG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60A76E0", Offset = "0x60A6AE0", VA = "0x1860A76E0")]
	public static Quaternion JPKLNAIBIAL(HPOGFCAKLHN PNMIIEJFOON)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60A7870", Offset = "0x60A6C70", VA = "0x1860A7870")]
	public static HIGFILJNPGO OHJBIDIGPHC(Quaternion IIGDEGFOLMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60A7670", Offset = "0x60A6A70", VA = "0x1860A7670")]
	public static Quaternion CJPFLNOIHAK(HIGFILJNPGO PNMIIEJFOON)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GCCCBBAKIPI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60A79D0", Offset = "0x60A6DD0", VA = "0x1860A79D0")]
	public static KEGEOAMBJND FBLBIDAIACI(this in Quaternion LKINCHDLDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60A7910", Offset = "0x60A6D10", VA = "0x1860A7910")]
	public static KEGEOAMBJND CDACKAKPFGD(this in Quaternion? LKINCHDLDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60A7A50", Offset = "0x60A6E50", VA = "0x1860A7A50")]
	public static Quaternion LOHKEOMODAB(this KEGEOAMBJND LKINCHDLDIG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60A7AB0", Offset = "0x60A6EB0", VA = "0x1860A7AB0")]
	public static Quaternion? MMNKPIGNNKM(this KEGEOAMBJND LKINCHDLDIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NAJADHCAALM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60A7DD0", Offset = "0x60A71D0", VA = "0x1860A7DD0")]
	public static HIGFILJNPGO FBLBIDAIACI(this in Vector3 LKINCHDLDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60A7D10", Offset = "0x60A7110", VA = "0x1860A7D10")]
	public static HIGFILJNPGO CDACKAKPFGD(this in Vector3? LKINCHDLDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60A7E40", Offset = "0x60A7240", VA = "0x1860A7E40")]
	public static Vector3 LOHKEOMODAB(this HIGFILJNPGO LKINCHDLDIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60A7E90", Offset = "0x60A7290", VA = "0x1860A7E90")]
	public static Vector3? MMNKPIGNNKM(this HIGFILJNPGO LKINCHDLDIG)
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
