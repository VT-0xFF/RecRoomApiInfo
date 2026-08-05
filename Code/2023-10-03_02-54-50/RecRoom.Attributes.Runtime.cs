using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KNKNJILBOON : KLGPADANODO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LLJGEOAGMPC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5BD70F0", Offset = "0x5BD58F0", VA = "0x185BD70F0")]
	public KNKNJILBOON(string DFFNHBKPJJB, string LLJGEOAGMPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class GCILOMEIFLD : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Type KCDOCKFHJJB;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x598D6C0", Offset = "0x598BEC0", VA = "0x18598D6C0")]
	public GCILOMEIFLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x78C320", Offset = "0x78AB20", VA = "0x18078C320")]
	public GCILOMEIFLD(Type PKPHAOOJLBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class IMDLDJFJMOB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
	public IMDLDJFJMOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class FKBEGANHHNB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string IMDBCLKIFAD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x770D80", Offset = "0x76F580", VA = "0x180770D80")]
	public FKBEGANHHNB(string IMDBCLKIFAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum NFNIPNJABGH
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
public class BAKIIHHMALJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5BD6D60", Offset = "0x5BD5560", VA = "0x185BD6D60")]
	public BAKIIHHMALJ(NFNIPNJABGH BJKOKHNAAID = NFNIPNJABGH.Self, bool HPOPDOFJFKF = false, bool GOHBCCCLIPI = false, bool NDCIGKPNFON = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GIOGLGBLEJD : BAKIIHHMALJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly Type ODBJLNKGBGO;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5BD6E40", Offset = "0x5BD5640", VA = "0x185BD6E40")]
	public GIOGLGBLEJD(Type HKAKCLDHBFL, NFNIPNJABGH BJKOKHNAAID = NFNIPNJABGH.Self, bool HPOPDOFJFKF = false, bool GOHBCCCLIPI = false, bool NDCIGKPNFON = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NLMPCPNNEIM : BAKIIHHMALJ
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5BD6D60", Offset = "0x5BD5560", VA = "0x185BD6D60")]
	public NLMPCPNNEIM(NFNIPNJABGH BJKOKHNAAID = NFNIPNJABGH.Self, bool HPOPDOFJFKF = false, bool GOHBCCCLIPI = false, bool NDCIGKPNFON = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class EEKAIMHEPKM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum LFNHECIIFJD
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Error
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly string NJBOHDOKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly LFNHECIIFJD BJKOKHNAAID;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5BD6DB0", Offset = "0x5BD55B0", VA = "0x185BD6DB0")]
	public EEKAIMHEPKM(string NJBOHDOKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5BD6DF0", Offset = "0x5BD55F0", VA = "0x185BD6DF0")]
	public EEKAIMHEPKM(string NJBOHDOKHID, LFNHECIIFJD BJKOKHNAAID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KLGPADANODO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly string DFFNHBKPJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly bool OAJAOBLDEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly object[] PBPABPHAIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public bool EDELCLEJLOH;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5BD6EB0", Offset = "0x5BD56B0", VA = "0x185BD6EB0")]
	public KLGPADANODO(string DFFNHBKPJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5BD6FB0", Offset = "0x5BD57B0", VA = "0x185BD6FB0")]
	public KLGPADANODO(string DFFNHBKPJJB, object FGBCLJNDGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5BD7090", Offset = "0x5BD5890", VA = "0x185BD7090")]
	public KLGPADANODO(string DFFNHBKPJJB, params object[] PBPABPHAIDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MJBDBJHFKBF : KLGPADANODO
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5BD6FB0", Offset = "0x5BD57B0", VA = "0x185BD6FB0")]
	public MJBDBJHFKBF(string DFFNHBKPJJB, object FGBCLJNDGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5BD7090", Offset = "0x5BD5890", VA = "0x185BD7090")]
	public MJBDBJHFKBF(string DFFNHBKPJJB, params object[] PBPABPHAIDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MGJEIIEFIAG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool GFLHIDMNIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly string CGCMGKDCMEJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5BD7210", Offset = "0x5BD5A10", VA = "0x185BD7210")]
	public MGJEIIEFIAG(string PLJBNHEFJKJ, bool JLNGMNLHNEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MEDGMCOPPHP : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x771100", Offset = "0x76F900", VA = "0x180771100")]
	public MEDGMCOPPHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CJNOLJIOLAL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x771100", Offset = "0x76F900", VA = "0x180771100")]
	public CJNOLJIOLAL()
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
