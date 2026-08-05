using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HLNOBDNJIKE : JHKJJNMIAJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string MENJLABBCPN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B37B20", Offset = "0x6B36920", VA = "0x186B37B20")]
	public HLNOBDNJIKE(string IKGBCMJKEDD, string MENJLABBCPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class ENCKAHBPLKG : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Type PIIOHKCEBKN;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5C31250", Offset = "0x5C30050", VA = "0x185C31250")]
	public ENCKAHBPLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x75C880", Offset = "0x75B680", VA = "0x18075C880")]
	public ENCKAHBPLKG(Type BENAJOLPOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class LDDOJPACHEO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
	public LDDOJPACHEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class FBAJHNHIDHA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string JIBJOBGFBHE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4B0F3B0", Offset = "0x4B0E1B0", VA = "0x184B0F3B0")]
	public FBAJHNHIDHA(string JIBJOBGFBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DIBFHMICKPK
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
public class LJGEGNIDGLA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B37DE0", Offset = "0x6B36BE0", VA = "0x186B37DE0")]
	public LJGEGNIDGLA(DIBFHMICKPK LEDIIMFEFLP = DIBFHMICKPK.Self, bool DMIAIFFLHOB = false, bool ECBCPKHEBKG = false, bool NCHDDMKOLCE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JHPLKCJIMPH : LJGEGNIDGLA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B37DE0", Offset = "0x6B36BE0", VA = "0x186B37DE0")]
	public JHPLKCJIMPH(DIBFHMICKPK LEDIIMFEFLP = DIBFHMICKPK.Self, bool DMIAIFFLHOB = false, bool ECBCPKHEBKG = false, bool NCHDDMKOLCE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field)]
public class JGBMNGBJCNF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum GCBAFFIOCBP
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
	public readonly string FNGOIPCGDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly GCBAFFIOCBP LEDIIMFEFLP;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B37C40", Offset = "0x6B36A40", VA = "0x186B37C40")]
	public JGBMNGBJCNF(string FNGOIPCGDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B37C80", Offset = "0x6B36A80", VA = "0x186B37C80")]
	public JGBMNGBJCNF(string FNGOIPCGDCK, GCBAFFIOCBP LEDIIMFEFLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JHKJJNMIAJO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string IKGBCMJKEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool DAMPBAPJBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] CDEAJJJKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool PFPDMKIEEOO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B37CD0", Offset = "0x6B36AD0", VA = "0x186B37CD0")]
	public JHKJJNMIAJO(string IKGBCMJKEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B379E0", Offset = "0x6B367E0", VA = "0x186B379E0")]
	public JHKJJNMIAJO(string IKGBCMJKEDD, object NINJCJGCPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B37AC0", Offset = "0x6B368C0", VA = "0x186B37AC0")]
	public JHKJJNMIAJO(string IKGBCMJKEDD, params object[] CDEAJJJKIPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class EDDGAPHNDCD : JHKJJNMIAJO
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6B379E0", Offset = "0x6B367E0", VA = "0x186B379E0")]
	public EDDGAPHNDCD(string IKGBCMJKEDD, object NINJCJGCPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6B37AC0", Offset = "0x6B368C0", VA = "0x186B37AC0")]
	public EDDGAPHNDCD(string IKGBCMJKEDD, params object[] CDEAJJJKIPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KGALABHBDAI : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool BPIPEAIBPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string DGEAMMFMLGO;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6B37E30", Offset = "0x6B36C30", VA = "0x186B37E30")]
	public KGALABHBDAI(string LOCOCLMPIDE, bool CKECMGFNFMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HJJMHMCKNIN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0")]
	public HJJMHMCKNIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KAELEBJJOOD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0")]
	public KAELEBJJOOD()
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
