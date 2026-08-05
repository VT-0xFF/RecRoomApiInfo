using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class EIBCKLLPLLJ : HKPCFEIAMKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string HPOAKLNOAPH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7660", Offset = "0x5EE6A60", VA = "0x185EE7660")]
	public EIBCKLLPLLJ(string FJACHNPBHBH, string HPOAKLNOAPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class HAIFJNIDMDM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string CHOEFIMFOEK;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x79FD80", Offset = "0x79F180", VA = "0x18079FD80")]
	public HAIFJNIDMDM(string CHOEFIMFOEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum ELJJCPAPFEG
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
public class CEJHJKODPLN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EE75A0", Offset = "0x5EE69A0", VA = "0x185EE75A0")]
	public CEJHJKODPLN(ELJJCPAPFEG KHENBEDBKDI = ELJJCPAPFEG.Self, bool IKPFIGOFJLF = false, bool PGFMKJPFNBK = false, bool JBPBHIFIIJK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EDBOFAEOHMI : CEJHJKODPLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type FJMNPKNJGPB;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EE75F0", Offset = "0x5EE69F0", VA = "0x185EE75F0")]
	public EDBOFAEOHMI(Type GHIFCFGALKF, ELJJCPAPFEG KHENBEDBKDI = ELJJCPAPFEG.Self, bool IKPFIGOFJLF = false, bool PGFMKJPFNBK = false, bool JBPBHIFIIJK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OLOHNBHGOEL : CEJHJKODPLN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EE75A0", Offset = "0x5EE69A0", VA = "0x185EE75A0")]
	public OLOHNBHGOEL(ELJJCPAPFEG KHENBEDBKDI = ELJJCPAPFEG.Self, bool IKPFIGOFJLF = false, bool PGFMKJPFNBK = false, bool JBPBHIFIIJK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class GMPMOIOEDKF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum JFPFPMDGOLM
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
	public readonly string ICHMPNFGJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly JFPFPMDGOLM KHENBEDBKDI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5EE77D0", Offset = "0x5EE6BD0", VA = "0x185EE77D0")]
	public GMPMOIOEDKF(string ICHMPNFGJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7780", Offset = "0x5EE6B80", VA = "0x185EE7780")]
	public GMPMOIOEDKF(string ICHMPNFGJFP, JFPFPMDGOLM KHENBEDBKDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HKPCFEIAMKE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string FJACHNPBHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool NFELNFAALLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] MECMAMGNJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool NGPNHHNFLPG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7950", Offset = "0x5EE6D50", VA = "0x185EE7950")]
	public HKPCFEIAMKE(string FJACHNPBHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7870", Offset = "0x5EE6C70", VA = "0x185EE7870")]
	public HKPCFEIAMKE(string FJACHNPBHBH, object FFLAHPCJDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7810", Offset = "0x5EE6C10", VA = "0x185EE7810")]
	public HKPCFEIAMKE(string FJACHNPBHBH, params object[] MECMAMGNJMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KKGPANMILCM : HKPCFEIAMKE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7870", Offset = "0x5EE6C70", VA = "0x185EE7870")]
	public KKGPANMILCM(string FJACHNPBHBH, object FFLAHPCJDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7810", Offset = "0x5EE6C10", VA = "0x185EE7810")]
	public KKGPANMILCM(string FJACHNPBHBH, params object[] MECMAMGNJMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LEEKACMHNFE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool NHNDAIINFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string NHBECPGCMMF;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7A50", Offset = "0x5EE6E50", VA = "0x185EE7A50")]
	public LEEKACMHNFE(string DHJMPLAMJPO, bool PDBAFGAAMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IEFHCNAKMJC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7A0100", Offset = "0x79F500", VA = "0x1807A0100")]
	public IEFHCNAKMJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class COKEKFPGOHF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7A0100", Offset = "0x79F500", VA = "0x1807A0100")]
	public COKEKFPGOHF()
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
