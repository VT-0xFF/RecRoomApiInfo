using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class IOAKHNIABKK : PPLPIHAJNHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string OCNHPDNIHON;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5C084D0", Offset = "0x5C078D0", VA = "0x185C084D0")]
	public IOAKHNIABKK(string FBHKABGDKPA, string OCNHPDNIHON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class JHEKPPONFFA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Type CKGBPECHOBH;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x59C12E0", Offset = "0x59C06E0", VA = "0x1859C12E0")]
	public JHEKPPONFFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x18078E300")]
	public JHEKPPONFFA(Type HEGKPDMIGJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class HNPJOHDPMGK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
	public HNPJOHDPMGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class HBPOOHLCCMI : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string OCBDGIOGBAA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x772D80", Offset = "0x772180", VA = "0x180772D80")]
	public HBPOOHLCCMI(string OCBDGIOGBAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum OECFEFOEJFL
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
public class BEGIBHGLGBK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5C083F0", Offset = "0x5C077F0", VA = "0x185C083F0")]
	public BEGIBHGLGBK(OECFEFOEJFL DJMKKNDNCBM = OECFEFOEJFL.Self, bool ACKLDHCFGGG = false, bool LCCHOCBEPJH = false, bool BGKAKHEHNKP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ODICLPNINDE : BEGIBHGLGBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly Type ECPJHFEBCIC;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5C08780", Offset = "0x5C07B80", VA = "0x185C08780")]
	public ODICLPNINDE(Type OEJLKMBMBIC, OECFEFOEJFL DJMKKNDNCBM = OECFEFOEJFL.Self, bool ACKLDHCFGGG = false, bool LCCHOCBEPJH = false, bool BGKAKHEHNKP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NPINIMCHPKM : BEGIBHGLGBK
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5C083F0", Offset = "0x5C077F0", VA = "0x185C083F0")]
	public NPINIMCHPKM(OECFEFOEJFL DJMKKNDNCBM = OECFEFOEJFL.Self, bool ACKLDHCFGGG = false, bool LCCHOCBEPJH = false, bool BGKAKHEHNKP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class HMFCIJOBPKH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum FIMDLBHNHOH
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
	public readonly string DBPAHEMAAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly FIMDLBHNHOH DJMKKNDNCBM;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5C08440", Offset = "0x5C07840", VA = "0x185C08440")]
	public HMFCIJOBPKH(string DBPAHEMAAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5C08480", Offset = "0x5C07880", VA = "0x185C08480")]
	public HMFCIJOBPKH(string DBPAHEMAAMI, FIMDLBHNHOH DJMKKNDNCBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PPLPIHAJNHD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly string FBHKABGDKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly bool FMDOAGCJGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly object[] LHIKNLHGCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public bool BNNAIKGDNJF;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5C087F0", Offset = "0x5C07BF0", VA = "0x185C087F0")]
	public PPLPIHAJNHD(string FBHKABGDKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C08640", Offset = "0x5C07A40", VA = "0x185C08640")]
	public PPLPIHAJNHD(string FBHKABGDKPA, object GMFKLABHGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5C08720", Offset = "0x5C07B20", VA = "0x185C08720")]
	public PPLPIHAJNHD(string FBHKABGDKPA, params object[] LHIKNLHGCDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NCJCPOFOOLJ : PPLPIHAJNHD
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5C08640", Offset = "0x5C07A40", VA = "0x185C08640")]
	public NCJCPOFOOLJ(string FBHKABGDKPA, object GMFKLABHGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5C08720", Offset = "0x5C07B20", VA = "0x185C08720")]
	public NCJCPOFOOLJ(string FBHKABGDKPA, params object[] LHIKNLHGCDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MGDGFNBPFBE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool OHFOFMPMKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly string NCMBNLHIAOA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5C085F0", Offset = "0x5C079F0", VA = "0x185C085F0")]
	public MGDGFNBPFBE(string EJAOOJGACGN, bool KDNIGIFPNOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CBNKBLNHDMH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x773100", Offset = "0x772500", VA = "0x180773100")]
	public CBNKBLNHDMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OOBMKMHBHAE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x773100", Offset = "0x772500", VA = "0x180773100")]
	public OOBMKMHBHAE()
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
