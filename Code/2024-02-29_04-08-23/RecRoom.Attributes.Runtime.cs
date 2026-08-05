using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JAAEFAKDAGE : FKPNDKNBFKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LFDNOGLKHAC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EB09C0", Offset = "0x5EAF7C0", VA = "0x185EB09C0")]
	public JAAEFAKDAGE(string PDHHGGHLMGF, string LFDNOGLKHAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class NMJECBGOFDO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string JDCHAKPAACH;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D80", Offset = "0x7B7B80", VA = "0x1807B8D80")]
	public NMJECBGOFDO(string JDCHAKPAACH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum ONGLIIBHLOO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Self,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Parent,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Children,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	SelfAndParent,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	SelfAndChildren,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NestedParent
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AHOEPOHPCNC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0730", Offset = "0x5EAF530", VA = "0x185EB0730")]
	public AHOEPOHPCNC(ONGLIIBHLOO HFFNCGFKMBJ = ONGLIIBHLOO.Self, bool MPFNGAMCGOE = false, bool BLJFOLCPFNN = false, bool DKHJGDMJBKC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NNCBKGNBLHG : AHOEPOHPCNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type GPOCEPJGCOE;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0B30", Offset = "0x5EAF930", VA = "0x185EB0B30")]
	public NNCBKGNBLHG(Type ANINIODINKD, ONGLIIBHLOO HFFNCGFKMBJ = ONGLIIBHLOO.Self, bool MPFNGAMCGOE = false, bool BLJFOLCPFNN = false, bool DKHJGDMJBKC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KNLLPIHNEKK : AHOEPOHPCNC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0730", Offset = "0x5EAF530", VA = "0x185EB0730")]
	public KNLLPIHNEKK(ONGLIIBHLOO HFFNCGFKMBJ = ONGLIIBHLOO.Self, bool MPFNGAMCGOE = false, bool BLJFOLCPFNN = false, bool DKHJGDMJBKC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class ABEJICINKPE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum NBCCFBGLOKB
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
	public readonly string BMCCPOKBDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly NBCCFBGLOKB HFFNCGFKMBJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5EB06F0", Offset = "0x5EAF4F0", VA = "0x185EB06F0")]
	public ABEJICINKPE(string BMCCPOKBDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5480860", Offset = "0x547F660", VA = "0x185480860")]
	public ABEJICINKPE(string BMCCPOKBDIF, NBCCFBGLOKB HFFNCGFKMBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FKPNDKNBFKM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string PDHHGGHLMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool PFFGLFPPIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] NBAILHEHEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool OGECLOFJMGH;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EB08C0", Offset = "0x5EAF6C0", VA = "0x185EB08C0")]
	public FKPNDKNBFKM(string PDHHGGHLMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0780", Offset = "0x5EAF580", VA = "0x185EB0780")]
	public FKPNDKNBFKM(string PDHHGGHLMGF, object LFKAMMGHADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0860", Offset = "0x5EAF660", VA = "0x185EB0860")]
	public FKPNDKNBFKM(string PDHHGGHLMGF, params object[] NBAILHEHEAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class COFKIDCDNPI : FKPNDKNBFKM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0780", Offset = "0x5EAF580", VA = "0x185EB0780")]
	public COFKIDCDNPI(string PDHHGGHLMGF, object LFKAMMGHADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0860", Offset = "0x5EAF660", VA = "0x185EB0860")]
	public COFKIDCDNPI(string PDHHGGHLMGF, params object[] NBAILHEHEAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MMDMGGOKGDH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool KFLDPCPBMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string DCKMKOFBDPB;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0AE0", Offset = "0x5EAF8E0", VA = "0x185EB0AE0")]
	public MMDMGGOKGDH(string INKNIPHMOGM, bool KBLACJCCDCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FLMEJANMAKI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7B9100", Offset = "0x7B7F00", VA = "0x1807B9100")]
	public FLMEJANMAKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EJKEHKNDGLC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7B9100", Offset = "0x7B7F00", VA = "0x1807B9100")]
	public EJKEHKNDGLC()
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
