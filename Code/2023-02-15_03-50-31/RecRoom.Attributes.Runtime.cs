using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FHMDMENCPNP : JLJIECADMGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string OBCNFHGEKJA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64A5310", Offset = "0x64A4710", VA = "0x1864A5310")]
	public FHMDMENCPNP(string BBMCAMCKHNC, string OBCNFHGEKJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class JKHIONIFKDD : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Type FNLDBHJHFAG;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4340460", Offset = "0x433F860", VA = "0x184340460")]
	public JKHIONIFKDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72ABD0", Offset = "0x729FD0", VA = "0x18072ABD0")]
	public JKHIONIFKDD(Type OHBLDNBAOAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class HPGMEBPEFHN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
	public HPGMEBPEFHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class NKNJAIMLBKK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string CKJEPAOOFKL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1061420", Offset = "0x1060820", VA = "0x181061420")]
	public NKNJAIMLBKK(string CKJEPAOOFKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BCMNNOMINIG
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
public class PLDPAHFKOHO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x64A5710", Offset = "0x64A4B10", VA = "0x1864A5710")]
	public PLDPAHFKOHO(BCMNNOMINIG DDJDPMGLPAE = BCMNNOMINIG.Self, bool NFLCILMNJKE = false, bool HIAFCPMJDHA = false, bool CGDHPDCFBLE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LNFKCGBKKAE : PLDPAHFKOHO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x64A5710", Offset = "0x64A4B10", VA = "0x1864A5710")]
	public LNFKCGBKKAE(BCMNNOMINIG DDJDPMGLPAE = BCMNNOMINIG.Self, bool NFLCILMNJKE = false, bool HIAFCPMJDHA = false, bool CGDHPDCFBLE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field)]
public class JMJGMKPPDEK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum EOEFNPJJFHA
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
	public readonly string KKNAIGLCEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly EOEFNPJJFHA DDJDPMGLPAE;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64A5680", Offset = "0x64A4A80", VA = "0x1864A5680")]
	public JMJGMKPPDEK(string KKNAIGLCEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x64A56C0", Offset = "0x64A4AC0", VA = "0x1864A56C0")]
	public JMJGMKPPDEK(string KKNAIGLCEND, EOEFNPJJFHA DDJDPMGLPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JLJIECADMGK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string BBMCAMCKHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool MKPGIDHGIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] LBPPOMLECFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool CIHAJCFGKFL;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x64A5570", Offset = "0x64A4970", VA = "0x1864A5570")]
	public JLJIECADMGK(string BBMCAMCKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64A5490", Offset = "0x64A4890", VA = "0x1864A5490")]
	public JLJIECADMGK(string BBMCAMCKHNC, object HMMNPKAHEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x64A5430", Offset = "0x64A4830", VA = "0x1864A5430")]
	public JLJIECADMGK(string BBMCAMCKHNC, params object[] LBPPOMLECFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class OPOHELAENON : JLJIECADMGK
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x64A5490", Offset = "0x64A4890", VA = "0x1864A5490")]
	public OPOHELAENON(string BBMCAMCKHNC, object HMMNPKAHEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x64A5430", Offset = "0x64A4830", VA = "0x1864A5430")]
	public OPOHELAENON(string BBMCAMCKHNC, params object[] LBPPOMLECFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NLCLOHKMNJF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool LBHNPJBGLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string EGEMLGADJOK;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x64A5760", Offset = "0x64A4B60", VA = "0x1864A5760")]
	public NLCLOHKMNJF(string HNDHBGNPODK, bool NDJPJHEAKCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EKKBFEGNKCG : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0")]
	public EKKBFEGNKCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DJGGFMCNHBJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0")]
	public DJGGFMCNHBJ()
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
