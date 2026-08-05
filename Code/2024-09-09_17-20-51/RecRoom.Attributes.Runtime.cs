using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ONOENCNLAGP : CKLIEFGDNGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string JIANJIGMNHO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A14830", Offset = "0x6A13230", VA = "0x186A14830")]
	public ONOENCNLAGP(string PCNHHCCEPJE, string JIANJIGMNHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class MHINBGEBGNK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string JIINGFJHCAJ;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A14780", Offset = "0x6A13180", VA = "0x186A14780")]
	public MHINBGEBGNK(string JIINGFJHCAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NEFCELJHDOC
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
public class CCFGIEGBFJM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A145A0", Offset = "0x6A12FA0", VA = "0x186A145A0")]
	public CCFGIEGBFJM(NEFCELJHDOC AOGCIMANLIJ = NEFCELJHDOC.Self, bool MMEFEGMGLDE = false, bool COBELECGJGP = false, bool BMCCDGAJLMD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OAMJMMDMOPC : CCFGIEGBFJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type LKFPFAPGJKJ;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A147C0", Offset = "0x6A131C0", VA = "0x186A147C0")]
	public OAMJMMDMOPC(Type FDNBIMEMPII, NEFCELJHDOC AOGCIMANLIJ = NEFCELJHDOC.Self, bool MMEFEGMGLDE = false, bool COBELECGJGP = false, bool BMCCDGAJLMD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IBDNIDADCCI : CCFGIEGBFJM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A145A0", Offset = "0x6A12FA0", VA = "0x186A145A0")]
	public IBDNIDADCCI(NEFCELJHDOC AOGCIMANLIJ = NEFCELJHDOC.Self, bool MMEFEGMGLDE = false, bool COBELECGJGP = false, bool BMCCDGAJLMD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class MGLMNFGHEGL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum OFPOEEHJPMM
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
	public readonly string CMLOOAOLBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly OFPOEEHJPMM AOGCIMANLIJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A14740", Offset = "0x6A13140", VA = "0x186A14740")]
	public MGLMNFGHEGL(string CMLOOAOLBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5F98700", Offset = "0x5F97100", VA = "0x185F98700")]
	public MGLMNFGHEGL(string CMLOOAOLBLI, OFPOEEHJPMM AOGCIMANLIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CKLIEFGDNGH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string PCNHHCCEPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool GAMKEFLCMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] NGINCEPKJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool DJDPGOCAAOF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A145F0", Offset = "0x6A12FF0", VA = "0x186A145F0")]
	public CKLIEFGDNGH(string PCNHHCCEPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A14460", Offset = "0x6A12E60", VA = "0x186A14460")]
	public CKLIEFGDNGH(string PCNHHCCEPJE, object HFJOCNKPLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A14540", Offset = "0x6A12F40", VA = "0x186A14540")]
	public CKLIEFGDNGH(string PCNHHCCEPJE, params object[] NGINCEPKJDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ACBCCMBCOBL : CKLIEFGDNGH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A14460", Offset = "0x6A12E60", VA = "0x186A14460")]
	public ACBCCMBCOBL(string PCNHHCCEPJE, object HFJOCNKPLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A14540", Offset = "0x6A12F40", VA = "0x186A14540")]
	public ACBCCMBCOBL(string PCNHHCCEPJE, params object[] NGINCEPKJDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ELMBMHFPMHO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool HOIPMLNLPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string LBBPLHHLMBG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A146F0", Offset = "0x6A130F0", VA = "0x186A146F0")]
	public ELMBMHFPMHO(string LIMLILMILJB, bool BIANKPKCHJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KBIDGLDEDLD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x183C420", Offset = "0x183AE20", VA = "0x18183C420")]
	public KBIDGLDEDLD()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x183C420", Offset = "0x183AE20", VA = "0x18183C420")]
		public ReadOnlyFieldAttribute()
		{
		}
	}
}
namespace Cpp2IlInjected
{
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
}
