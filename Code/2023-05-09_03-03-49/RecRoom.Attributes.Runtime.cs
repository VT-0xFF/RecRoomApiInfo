using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CCPHONJNBLF : EAIPBFEGLOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string KAAOAONEEFL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9890", Offset = "0x6AC8290", VA = "0x186AC9890")]
	public CCPHONJNBLF(string LHLOCECPLBJ, string KAAOAONEEFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class HGHNALMAJGN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Type FAOLPHLIJOA;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xC4BC40", Offset = "0xC4A640", VA = "0x180C4BC40")]
	public HGHNALMAJGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x847190", Offset = "0x845B90", VA = "0x180847190")]
	public HGHNALMAJGN(Type ENGENMPHNEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class ONPKLKMGICH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
	public ONPKLKMGICH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class MBKHFNCMCIL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string LGMDDECCKHG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1E6C090", Offset = "0x1E6AA90", VA = "0x181E6C090")]
	public MBKHFNCMCIL(string LGMDDECCKHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum MAMLNCPNJJC
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
public class ADNNDKFKEGG : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6AC96B0", Offset = "0x6AC80B0", VA = "0x186AC96B0")]
	public ADNNDKFKEGG(MAMLNCPNJJC EMKINACMDLO = MAMLNCPNJJC.Self, bool FOMLNDPEJIK = false, bool BPAPJCPGEAP = false, bool EHNKCMPLIIK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CCLDAICIAJB : ADNNDKFKEGG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6AC96B0", Offset = "0x6AC80B0", VA = "0x186AC96B0")]
	public CCLDAICIAJB(MAMLNCPNJJC EMKINACMDLO = MAMLNCPNJJC.Self, bool FOMLNDPEJIK = false, bool BPAPJCPGEAP = false, bool EHNKCMPLIIK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field)]
public class DJODDMIMLCO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum HCPIBGACIDK
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
	public readonly string MHOCGHKABIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly HCPIBGACIDK EMKINACMDLO;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9A00", Offset = "0x6AC8400", VA = "0x186AC9A00")]
	public DJODDMIMLCO(string MHOCGHKABIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6AC99B0", Offset = "0x6AC83B0", VA = "0x186AC99B0")]
	public DJODDMIMLCO(string MHOCGHKABIN, HCPIBGACIDK EMKINACMDLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EAIPBFEGLOF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string LHLOCECPLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool JKDGFOLBIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] GENIMIEJDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool HLBHALBAJPC;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9A40", Offset = "0x6AC8440", VA = "0x186AC9A40")]
	public EAIPBFEGLOF(string LHLOCECPLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9750", Offset = "0x6AC8150", VA = "0x186AC9750")]
	public EAIPBFEGLOF(string LHLOCECPLBJ, object HPONLKEBJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9830", Offset = "0x6AC8230", VA = "0x186AC9830")]
	public EAIPBFEGLOF(string LHLOCECPLBJ, params object[] GENIMIEJDMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BNIAJDPPONL : EAIPBFEGLOF
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9750", Offset = "0x6AC8150", VA = "0x186AC9750")]
	public BNIAJDPPONL(string LHLOCECPLBJ, object HPONLKEBJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9830", Offset = "0x6AC8230", VA = "0x186AC9830")]
	public BNIAJDPPONL(string LHLOCECPLBJ, params object[] GENIMIEJDMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AJFKNJPCCAM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool GNLIMGIBNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string LABOLJEIGDA;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9700", Offset = "0x6AC8100", VA = "0x186AC9700")]
	public AJFKNJPCCAM(string IHJBNCEPEJP, bool OEBJDFJNMIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HBJACELMJDD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0")]
	public HBJACELMJDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PLGBBEBNKCO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0")]
	public PLGBBEBNKCO()
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
