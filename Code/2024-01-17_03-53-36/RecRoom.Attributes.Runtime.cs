using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CDFJIKLHNNN : DAHJBBELEBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string MFHBINIAOGP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9C90", Offset = "0x5EA8A90", VA = "0x185EA9C90")]
	public CDFJIKLHNNN(string FODBHKPAGOP, string MFHBINIAOGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class APKEBFKIANG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string OEKGOGMEIPB;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x79DD80", Offset = "0x79CB80", VA = "0x18079DD80")]
	public APKEBFKIANG(string OEKGOGMEIPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LNILAIILNJP
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
public class OBGJPAKDKLL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9C40", Offset = "0x5EA8A40", VA = "0x185EA9C40")]
	public OBGJPAKDKLL(LNILAIILNJP HJCFEPLFGPG = LNILAIILNJP.Self, bool NFEMNLOGADM = false, bool ALPHMFDNDNJ = false, bool IACJCLLADHE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BBEBPPGHOBA : OBGJPAKDKLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type JPDIJNKKMDK;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9BD0", Offset = "0x5EA89D0", VA = "0x185EA9BD0")]
	public BBEBPPGHOBA(Type OBDKOMDFLNO, LNILAIILNJP HJCFEPLFGPG = LNILAIILNJP.Self, bool NFEMNLOGADM = false, bool ALPHMFDNDNJ = false, bool IACJCLLADHE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BIOJMLLEHME : OBGJPAKDKLL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9C40", Offset = "0x5EA8A40", VA = "0x185EA9C40")]
	public BIOJMLLEHME(LNILAIILNJP HJCFEPLFGPG = LNILAIILNJP.Self, bool NFEMNLOGADM = false, bool ALPHMFDNDNJ = false, bool IACJCLLADHE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class GIOKCJLGHKH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum IDBKPBIJLJC
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
	public readonly string LHIFOIHPJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly IDBKPBIJLJC HJCFEPLFGPG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9FF0", Offset = "0x5EA8DF0", VA = "0x185EA9FF0")]
	public GIOKCJLGHKH(string LHIFOIHPJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA030", Offset = "0x5EA8E30", VA = "0x185EAA030")]
	public GIOKCJLGHKH(string LHIFOIHPJNC, IDBKPBIJLJC HJCFEPLFGPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DAHJBBELEBC : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string FODBHKPAGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool CKJAAIJMECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] EAPDNDHPLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool ICFIKFCMJML;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9DB0", Offset = "0x5EA8BB0", VA = "0x185EA9DB0")]
	public DAHJBBELEBC(string FODBHKPAGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9F10", Offset = "0x5EA8D10", VA = "0x185EA9F10")]
	public DAHJBBELEBC(string FODBHKPAGOP, object BFKMBKHFHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9EB0", Offset = "0x5EA8CB0", VA = "0x185EA9EB0")]
	public DAHJBBELEBC(string FODBHKPAGOP, params object[] EAPDNDHPLKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IDBJALKIPOE : DAHJBBELEBC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9F10", Offset = "0x5EA8D10", VA = "0x185EA9F10")]
	public IDBJALKIPOE(string FODBHKPAGOP, object BFKMBKHFHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9EB0", Offset = "0x5EA8CB0", VA = "0x185EA9EB0")]
	public IDBJALKIPOE(string FODBHKPAGOP, params object[] EAPDNDHPLKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JLFENHCCKGH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool KGFJDJLHMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string CBKMNGMBPKJ;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA080", Offset = "0x5EA8E80", VA = "0x185EAA080")]
	public JLFENHCCKGH(string IJBPDPLFBHL, bool ENJGKGABJEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FINEDHANMAC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x79E100", Offset = "0x79CF00", VA = "0x18079E100")]
	public FINEDHANMAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HLPLBKGLOCB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x79E100", Offset = "0x79CF00", VA = "0x18079E100")]
	public HLPLBKGLOCB()
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
