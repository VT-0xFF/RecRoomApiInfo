using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BDKCCANNHBO : OBHHMAKEOMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string FLMBAILPCIE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68188B0", Offset = "0x6817AB0", VA = "0x1868188B0")]
	public BDKCCANNHBO(string ODLMGIBLFNG, string FLMBAILPCIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class OFENKFBEDDN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Type HAGNOENAPMD;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x37D15C0", Offset = "0x37D07C0", VA = "0x1837D15C0")]
	public OFENKFBEDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7018E0", Offset = "0x700AE0", VA = "0x1807018E0")]
	public OFENKFBEDDN(Type KENLLOEIOGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class JFLPBNOOLKD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
	public JFLPBNOOLKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class NJCEEEDPPML : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string LILJJIELHBD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x44AF3C0", Offset = "0x44AE5C0", VA = "0x1844AF3C0")]
	public NJCEEEDPPML(string LILJJIELHBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum MFGBMPAPHGB
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
public class ELEHEHIOAGB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6818B10", Offset = "0x6817D10", VA = "0x186818B10")]
	public ELEHEHIOAGB(MFGBMPAPHGB NIFOGEBEDNG = MFGBMPAPHGB.Self, bool PLLPOLOCGML = false, bool JAHMJLBGMFC = false, bool EDDHJGHOFGA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MKPBLGADCLO : ELEHEHIOAGB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6818B10", Offset = "0x6817D10", VA = "0x186818B10")]
	public MKPBLGADCLO(MFGBMPAPHGB NIFOGEBEDNG = MFGBMPAPHGB.Self, bool PLLPOLOCGML = false, bool JAHMJLBGMFC = false, bool EDDHJGHOFGA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field)]
public class BCLPDJMEMPD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum MFHDAGMCCFL
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
	public readonly string HLIGBKANEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly MFHDAGMCCFL NIFOGEBEDNG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6818870", Offset = "0x6817A70", VA = "0x186818870")]
	public BCLPDJMEMPD(string HLIGBKANEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6818820", Offset = "0x6817A20", VA = "0x186818820")]
	public BCLPDJMEMPD(string HLIGBKANEEA, MFHDAGMCCFL NIFOGEBEDNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OBHHMAKEOMB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string ODLMGIBLFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool BIKCHAIMHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] DBPNIPOIPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool OHAPEDEFGOB;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6818BB0", Offset = "0x6817DB0", VA = "0x186818BB0")]
	public OBHHMAKEOMB(string ODLMGIBLFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6818A30", Offset = "0x6817C30", VA = "0x186818A30")]
	public OBHHMAKEOMB(string ODLMGIBLFNG, object NNDJJNEPIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x68189D0", Offset = "0x6817BD0", VA = "0x1868189D0")]
	public OBHHMAKEOMB(string ODLMGIBLFNG, params object[] DBPNIPOIPNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CIGHLCFABOK : OBHHMAKEOMB
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6818A30", Offset = "0x6817C30", VA = "0x186818A30")]
	public CIGHLCFABOK(string ODLMGIBLFNG, object NNDJJNEPIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x68189D0", Offset = "0x6817BD0", VA = "0x1868189D0")]
	public CIGHLCFABOK(string ODLMGIBLFNG, params object[] DBPNIPOIPNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GLIINBADHAP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool PHEHPIPLADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string MGBJMINEMFA;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6818B60", Offset = "0x6817D60", VA = "0x186818B60")]
	public GLIINBADHAP(string DIGDEKLMCOJ, bool OEIMLHLCICK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ICGBEFCGILO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0")]
	public ICGBEFCGILO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class EFEFIKFHIDK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0")]
	public EFEFIKFHIDK()
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
