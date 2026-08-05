using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HLCOCNCBAMA : OAOGAAAELOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string KLLAHBJAJIB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xE54DB0", Offset = "0xE53DB0", VA = "0x180E54DB0")]
	public HLCOCNCBAMA(string NFHBGMAGCDN, string KLLAHBJAJIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class PNEMNJLACAG : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Type KDGBNDMJDEJ;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xE55110", Offset = "0xE54110", VA = "0x180E55110")]
	public PNEMNJLACAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x726AD0", Offset = "0x725AD0", VA = "0x180726AD0")]
	public PNEMNJLACAG(Type BFEFDHILNLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class KCDNGBJFAHM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480")]
	public KCDNGBJFAHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class GOFALKMDFGP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string JHNLGMOMJBH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xE54CF0", Offset = "0xE53CF0", VA = "0x180E54CF0")]
	public GOFALKMDFGP(string JHNLGMOMJBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum AACKNMMIFMG
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Self,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Parent,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Children,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	SelfAndParent,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	SelfAndChildren,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	NestedParent
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DMMPNBPEKOM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xE54CA0", Offset = "0xE53CA0", VA = "0x180E54CA0")]
	public DMMPNBPEKOM(AACKNMMIFMG GLKKDGLKBMK = AACKNMMIFMG.Self, bool BNLLPLFFAHE = false, bool AOOIEEGDFOE = false, bool HNEIPNOLLPP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NEKBIDGGIBA : DMMPNBPEKOM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xE54CA0", Offset = "0xE53CA0", VA = "0x180E54CA0")]
	public NEKBIDGGIBA(AACKNMMIFMG GLKKDGLKBMK = AACKNMMIFMG.Self, bool BNLLPLFFAHE = false, bool AOOIEEGDFOE = false, bool HNEIPNOLLPP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field)]
public class HFKGCPHDBDO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum AAKLKEEDPOF
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Error
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly string KOHCPOIIAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly AAKLKEEDPOF GLKKDGLKBMK;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xE54D70", Offset = "0xE53D70", VA = "0x180E54D70")]
	public HFKGCPHDBDO(string KOHCPOIIAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xE54D20", Offset = "0xE53D20", VA = "0x180E54D20")]
	public HFKGCPHDBDO(string KOHCPOIIAHP, AAKLKEEDPOF GLKKDGLKBMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OAOGAAAELOM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string NFHBGMAGCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool DPCPAMFMOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] FDBLMFELFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool EOPFCDLLLMF;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xE55010", Offset = "0xE54010", VA = "0x180E55010")]
	public OAOGAAAELOM(string NFHBGMAGCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xE54F30", Offset = "0xE53F30", VA = "0x180E54F30")]
	public OAOGAAAELOM(string NFHBGMAGCDN, object LECCJNAEJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xE54ED0", Offset = "0xE53ED0", VA = "0x180E54ED0")]
	public OAOGAAAELOM(string NFHBGMAGCDN, params object[] FDBLMFELFBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HLPKODDOMDE : OAOGAAAELOM
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xE54F30", Offset = "0xE53F30", VA = "0x180E54F30")]
	public HLPKODDOMDE(string NFHBGMAGCDN, object LECCJNAEJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xE54ED0", Offset = "0xE53ED0", VA = "0x180E54ED0")]
	public HLPKODDOMDE(string NFHBGMAGCDN, params object[] FDBLMFELFBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BDBBKDABMFC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0")]
	public BDBBKDABMFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BALLDLNPIHC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0")]
	public BALLDLNPIHC()
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
