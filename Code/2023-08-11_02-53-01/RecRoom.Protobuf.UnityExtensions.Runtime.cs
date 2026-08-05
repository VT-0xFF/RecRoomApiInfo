using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IGNJFOLGNGD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F29C00", Offset = "0x6F28400", VA = "0x186F29C00")]
	public static NOHDGCOPDIJ CLIBMONIMNB(this in Color PECDBPPMOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F29CA0", Offset = "0x6F284A0", VA = "0x186F29CA0")]
	public static Color KLHPMPNNHAA(this NOHDGCOPDIJ PECDBPPMOJP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F29D70", Offset = "0x6F28570", VA = "0x186F29D70")]
	public static Color? NBGEJGGEDAO(this NOHDGCOPDIJ PECDBPPMOJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DMLCGGPDKFP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F29970", Offset = "0x6F28170", VA = "0x186F29970")]
	public static PNAKJJBIGEI CLIBMONIMNB(this in Quaternion PECDBPPMOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F29A10", Offset = "0x6F28210", VA = "0x186F29A10")]
	public static Quaternion KLHPMPNNHAA(this PNAKJJBIGEI PECDBPPMOJP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F29AE0", Offset = "0x6F282E0", VA = "0x186F29AE0")]
	public static Quaternion? NBGEJGGEDAO(this PNAKJJBIGEI PECDBPPMOJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DHAIPOGEHNC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F296B0", Offset = "0x6F27EB0", VA = "0x186F296B0")]
	public static Quaternion EOJDCFKIADN(GJLKJAMOFOA NFBDMLCENEN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F298C0", Offset = "0x6F280C0", VA = "0x186F298C0")]
	public static MKACFLDCHJF LNLPNGLNFED(Quaternion BPPLJPGAGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F29610", Offset = "0x6F27E10", VA = "0x186F29610")]
	public static Quaternion CEALNLGCGLL(MKACFLDCHJF NFBDMLCENEN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NJDBDDPDLPO
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F29E90", Offset = "0x6F28690", VA = "0x186F29E90")]
	public static MKACFLDCHJF CLIBMONIMNB(this in Vector3 PECDBPPMOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F29F20", Offset = "0x6F28720", VA = "0x186F29F20")]
	public static Vector3 KLHPMPNNHAA(this MKACFLDCHJF PECDBPPMOJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F29FC0", Offset = "0x6F287C0", VA = "0x186F29FC0")]
	public static Vector3? NBGEJGGEDAO(this MKACFLDCHJF PECDBPPMOJP)
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
