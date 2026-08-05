using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62C83C0", Offset = "0x62C6BC0", VA = "0x1862C83C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78D440", Offset = "0x78BC40", VA = "0x18078D440")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78D480", Offset = "0x78BC80", VA = "0x18078D480")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AINGILOONID
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BBOAPHOFBBK(CFPBEPPKCAC EIGOIPKAPOI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CFPBEPPKCAC PFKIHJFLILM(string EIGOIPKAPOI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct CFPBEPPKCAC : IEquatable<CFPBEPPKCAC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly KCCBIEDEHAE OBJLLBKBLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly GDKFIEIKKHJ CFLGKAKILAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid IBKPKCECHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? IPOFICADPBN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LOAFACAIDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x62C6560", Offset = "0x62C4D60", VA = "0x1862C6560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JDAINNNNCAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62C6970", Offset = "0x62C5170", VA = "0x1862C6970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x62C6E20", Offset = "0x62C5620", VA = "0x1862C6E20")]
	public CFPBEPPKCAC(CFPBEPPKCAC GIKCAMPINEG, [Optional] Guid MIOONMGGCLN, [Optional] RRColor? MOJKBHCPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x62C6EB0", Offset = "0x62C56B0", VA = "0x1862C6EB0")]
	public CFPBEPPKCAC(KCCBIEDEHAE PLGEBDELIBL, GDKFIEIKKHJ IKEIHJBNBJO, [Optional] Guid MIOONMGGCLN, [Optional] RRColor? MOJKBHCPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x62C6780", Offset = "0x62C4F80", VA = "0x1862C6780", Slot = "4")]
	public bool Equals(CFPBEPPKCAC IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x62C6690", Offset = "0x62C4E90", VA = "0x1862C6690", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x62C6880", Offset = "0x62C5080", VA = "0x1862C6880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x62C6620", Offset = "0x62C4E20", VA = "0x1862C6620")]
	public static bool BIBGNMIHGGC(CFPBEPPKCAC PEEDIPGMMHL, CFPBEPPKCAC PEFIBHOJLKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x62C69B0", Offset = "0x62C51B0", VA = "0x1862C69B0")]
	public static bool LBEMCIDNPGP(CFPBEPPKCAC PEEDIPGMMHL, CFPBEPPKCAC PEFIBHOJLKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x62C6A20", Offset = "0x62C5220", VA = "0x1862C6A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct KCCBIEDEHAE : IEquatable<KCCBIEDEHAE>, IComparable<KCCBIEDEHAE>, GKCEKBLLBNK
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly KCCBIEDEHAE AACEAOMGOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid OJPOLEONBAO;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1C2E960", Offset = "0x1C2D160", VA = "0x181C2E960")]
	public KCCBIEDEHAE(Guid OJPOLEONBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50", Slot = "6")]
	public Guid EDNMEGAKOAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730", Slot = "4")]
	public bool Equals(KCCBIEDEHAE IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB760", Offset = "0x3CE9F60", VA = "0x183CEB760", Slot = "5")]
	public int CompareTo(KCCBIEDEHAE IFHFGCDLDEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62C7E70", Offset = "0x62C6670", VA = "0x1862C7E70", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB810", Offset = "0x3CEA010", VA = "0x183CEB810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730")]
	public static bool BIBGNMIHGGC(KCCBIEDEHAE PEEDIPGMMHL, KCCBIEDEHAE PEFIBHOJLKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x62C70F0", Offset = "0x62C58F0", VA = "0x1862C70F0")]
	public static bool LBEMCIDNPGP(KCCBIEDEHAE PEEDIPGMMHL, KCCBIEDEHAE PEFIBHOJLKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x62C7F10", Offset = "0x62C6710", VA = "0x1862C7F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct LKCHMMBKAAD : IEquatable<LKCHMMBKAAD>, IComparable<LKCHMMBKAAD>, GKCEKBLLBNK
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly LKCHMMBKAAD AACEAOMGOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid OJPOLEONBAO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1C2E960", Offset = "0x1C2D160", VA = "0x181C2E960")]
	public LKCHMMBKAAD(Guid OJPOLEONBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50", Slot = "6")]
	public Guid EDNMEGAKOAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730", Slot = "4")]
	public bool Equals(LKCHMMBKAAD IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB760", Offset = "0x3CE9F60", VA = "0x183CEB760", Slot = "5")]
	public int CompareTo(LKCHMMBKAAD IFHFGCDLDEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x62C8090", Offset = "0x62C6890", VA = "0x1862C8090", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB810", Offset = "0x3CEA010", VA = "0x183CEB810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730")]
	public static bool BIBGNMIHGGC(LKCHMMBKAAD PEEDIPGMMHL, LKCHMMBKAAD PEFIBHOJLKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x62C70F0", Offset = "0x62C58F0", VA = "0x1862C70F0")]
	public static bool LBEMCIDNPGP(LKCHMMBKAAD PEEDIPGMMHL, LKCHMMBKAAD PEFIBHOJLKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x62C8130", Offset = "0x62C6930", VA = "0x1862C8130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct FHPKPIBGCPD : IEquatable<FHPKPIBGCPD>, IComparable<FHPKPIBGCPD>, GKCEKBLLBNK
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly FHPKPIBGCPD AACEAOMGOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid OJPOLEONBAO;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1C2E960", Offset = "0x1C2D160", VA = "0x181C2E960")]
	public FHPKPIBGCPD(Guid OJPOLEONBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50", Slot = "6")]
	public Guid EDNMEGAKOAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730", Slot = "4")]
	public bool Equals(FHPKPIBGCPD IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB760", Offset = "0x3CE9F60", VA = "0x183CEB760", Slot = "5")]
	public int CompareTo(FHPKPIBGCPD IFHFGCDLDEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62C7050", Offset = "0x62C5850", VA = "0x1862C7050", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB810", Offset = "0x3CEA010", VA = "0x183CEB810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730")]
	public static bool BIBGNMIHGGC(FHPKPIBGCPD PEEDIPGMMHL, FHPKPIBGCPD PEFIBHOJLKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x62C70F0", Offset = "0x62C58F0", VA = "0x1862C70F0")]
	public static bool LBEMCIDNPGP(FHPKPIBGCPD PEEDIPGMMHL, FHPKPIBGCPD PEFIBHOJLKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x62C7120", Offset = "0x62C5920", VA = "0x1862C7120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct GDKFIEIKKHJ : IEquatable<GDKFIEIKKHJ>, IComparable<GDKFIEIKKHJ>, GKCEKBLLBNK
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly GDKFIEIKKHJ AACEAOMGOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid OJPOLEONBAO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NMAEDLGEGIF ILIFMGBJCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40")]
		[CompilerGenerated]
		get
		{
			return default(NMAEDLGEGIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NMAEDLGEGIF FPGEMNJMBFC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xD48CA0", Offset = "0xD474A0", VA = "0x180D48CA0")]
		[CompilerGenerated]
		get
		{
			return default(NMAEDLGEGIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NMAEDLGEGIF BGNPMOBJMFL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5DC60", VA = "0x180D5F460")]
		[CompilerGenerated]
		get
		{
			return default(NMAEDLGEGIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50", Slot = "6")]
	public Guid EDNMEGAKOAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x62C7600", Offset = "0x62C5E00", VA = "0x1862C7600")]
	public GDKFIEIKKHJ(Guid OJPOLEONBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x62C75B0", Offset = "0x62C5DB0", VA = "0x1862C75B0")]
	public GDKFIEIKKHJ(NMAEDLGEGIF HODNKACCAMN, NMAEDLGEGIF AOAMIABMGPD, NMAEDLGEGIF HANLLJBAKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x62C7320", Offset = "0x62C5B20", VA = "0x1862C7320")]
	private Guid DGLLHHKDPEF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5D90420", Offset = "0x5D8EC20", VA = "0x185D90420", Slot = "4")]
	public bool Equals(GDKFIEIKKHJ IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x62C7450", Offset = "0x62C5C50", VA = "0x1862C7450", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB810", Offset = "0x3CEA010", VA = "0x183CEB810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x62C72A0", Offset = "0x62C5AA0", VA = "0x1862C72A0")]
	public static bool BIBGNMIHGGC(GDKFIEIKKHJ PEEDIPGMMHL, GDKFIEIKKHJ PEFIBHOJLKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x62C7500", Offset = "0x62C5D00", VA = "0x1862C7500")]
	public static bool LBEMCIDNPGP(GDKFIEIKKHJ PEEDIPGMMHL, GDKFIEIKKHJ PEFIBHOJLKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x62C72E0", Offset = "0x62C5AE0", VA = "0x1862C72E0", Slot = "5")]
	public int CompareTo(GDKFIEIKKHJ IFHFGCDLDEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x62C7540", Offset = "0x62C5D40", VA = "0x1862C7540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LGPONKIMBFD : IEquatable<LGPONKIMBFD>, IComparable<LGPONKIMBFD>, GKCEKBLLBNK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly LGPONKIMBFD AACEAOMGOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid OJPOLEONBAO;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1C2E960", Offset = "0x1C2D160", VA = "0x181C2E960")]
	public LGPONKIMBFD(Guid OJPOLEONBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50", Slot = "6")]
	public Guid EDNMEGAKOAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730", Slot = "4")]
	public bool Equals(LGPONKIMBFD IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB760", Offset = "0x3CE9F60", VA = "0x183CEB760", Slot = "5")]
	public int CompareTo(LGPONKIMBFD IFHFGCDLDEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x62C7F80", Offset = "0x62C6780", VA = "0x1862C7F80", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB810", Offset = "0x3CEA010", VA = "0x183CEB810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730")]
	public static bool BIBGNMIHGGC(LGPONKIMBFD PEEDIPGMMHL, LGPONKIMBFD PEFIBHOJLKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x62C70F0", Offset = "0x62C58F0", VA = "0x1862C70F0")]
	public static bool LBEMCIDNPGP(LGPONKIMBFD PEEDIPGMMHL, LGPONKIMBFD PEFIBHOJLKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x62C8020", Offset = "0x62C6820", VA = "0x1862C8020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct EDCHCDBGJBI : IEquatable<EDCHCDBGJBI>, IComparable<EDCHCDBGJBI>, GKCEKBLLBNK
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly EDCHCDBGJBI AACEAOMGOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid OJPOLEONBAO;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1C2E960", Offset = "0x1C2D160", VA = "0x181C2E960")]
	public EDCHCDBGJBI(Guid OJPOLEONBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50", Slot = "6")]
	public Guid EDNMEGAKOAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730", Slot = "4")]
	public bool Equals(EDCHCDBGJBI IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB760", Offset = "0x3CE9F60", VA = "0x183CEB760", Slot = "5")]
	public int CompareTo(EDCHCDBGJBI IFHFGCDLDEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x62C6F40", Offset = "0x62C5740", VA = "0x1862C6F40", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB810", Offset = "0x3CEA010", VA = "0x183CEB810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730")]
	public static bool BIBGNMIHGGC(EDCHCDBGJBI PEEDIPGMMHL, EDCHCDBGJBI PEFIBHOJLKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x62C6FE0", Offset = "0x62C57E0", VA = "0x1862C6FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct FMLMECGDFMD : IEquatable<FMLMECGDFMD>, IComparable<FMLMECGDFMD>, GKCEKBLLBNK
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly FMLMECGDFMD AACEAOMGOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid OJPOLEONBAO;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1C2E960", Offset = "0x1C2D160", VA = "0x181C2E960")]
	public FMLMECGDFMD(Guid OJPOLEONBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50", Slot = "6")]
	public Guid EDNMEGAKOAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730", Slot = "4")]
	public bool Equals(FMLMECGDFMD IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB760", Offset = "0x3CE9F60", VA = "0x183CEB760", Slot = "5")]
	public int CompareTo(FMLMECGDFMD IFHFGCDLDEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x62C7190", Offset = "0x62C5990", VA = "0x1862C7190", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB810", Offset = "0x3CEA010", VA = "0x183CEB810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730")]
	public static bool BIBGNMIHGGC(FMLMECGDFMD PEEDIPGMMHL, FMLMECGDFMD PEFIBHOJLKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x62C70F0", Offset = "0x62C58F0", VA = "0x1862C70F0")]
	public static bool LBEMCIDNPGP(FMLMECGDFMD PEEDIPGMMHL, FMLMECGDFMD PEFIBHOJLKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x62C7230", Offset = "0x62C5A30", VA = "0x1862C7230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct MOBMKCBOGGK : IEquatable<MOBMKCBOGGK>, IComparable<MOBMKCBOGGK>, GKCEKBLLBNK
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly MOBMKCBOGGK AACEAOMGOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid OJPOLEONBAO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1C2E960", Offset = "0x1C2D160", VA = "0x181C2E960")]
	public MOBMKCBOGGK(Guid OJPOLEONBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50", Slot = "6")]
	public Guid EDNMEGAKOAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730", Slot = "4")]
	public bool Equals(MOBMKCBOGGK IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB760", Offset = "0x3CE9F60", VA = "0x183CEB760", Slot = "5")]
	public int CompareTo(MOBMKCBOGGK IFHFGCDLDEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x62C81A0", Offset = "0x62C69A0", VA = "0x1862C81A0", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB810", Offset = "0x3CEA010", VA = "0x183CEB810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730")]
	public static bool BIBGNMIHGGC(MOBMKCBOGGK PEEDIPGMMHL, MOBMKCBOGGK PEFIBHOJLKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x62C70F0", Offset = "0x62C58F0", VA = "0x1862C70F0")]
	public static bool LBEMCIDNPGP(MOBMKCBOGGK PEEDIPGMMHL, MOBMKCBOGGK PEFIBHOJLKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x62C8240", Offset = "0x62C6A40", VA = "0x1862C8240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct IACPBEFKIHO : IEquatable<IACPBEFKIHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? MEAFFPIAGAI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NJJJJBFIMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x62C7800", Offset = "0x62C6000", VA = "0x1862C7800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int FAMCOICKFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x38CD730", Offset = "0x38CBF30", VA = "0x1838CD730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x62C7BC0", Offset = "0x62C63C0", VA = "0x1862C7BC0")]
	public IACPBEFKIHO(string? ILMGMNIPIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x62C7D00", Offset = "0x62C6500", VA = "0x1862C7D00")]
	public IACPBEFKIHO(string?[] BAOGJECFPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x62C7900", Offset = "0x62C6100", VA = "0x1862C7900")]
	private static string?[]? MGLNAJHNOFG(string?[]? BAOGJECFPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x62C7640", Offset = "0x62C5E40", VA = "0x1862C7640")]
	public string DOHMDNLGGJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x62C7730", Offset = "0x62C5F30", VA = "0x1862C7730", Slot = "4")]
	public bool Equals(IACPBEFKIHO IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x62C76A0", Offset = "0x62C5EA0", VA = "0x1862C76A0", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x62C7820", Offset = "0x62C6020", VA = "0x1862C7820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x62C7B30", Offset = "0x62C6330", VA = "0x1862C7B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct NMAEDLGEGIF : IEquatable<NMAEDLGEGIF>, IComparable<NMAEDLGEGIF>, GKCEKBLLBNK
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly NMAEDLGEGIF AACEAOMGOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid OJPOLEONBAO;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1C2E960", Offset = "0x1C2D160", VA = "0x181C2E960")]
	public NMAEDLGEGIF(Guid OJPOLEONBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50", Slot = "6")]
	public Guid EDNMEGAKOAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730", Slot = "4")]
	public bool Equals(NMAEDLGEGIF IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB760", Offset = "0x3CE9F60", VA = "0x183CEB760", Slot = "5")]
	public int CompareTo(NMAEDLGEGIF IFHFGCDLDEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x62C82B0", Offset = "0x62C6AB0", VA = "0x1862C82B0", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB810", Offset = "0x3CEA010", VA = "0x183CEB810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB730", Offset = "0x3CE9F30", VA = "0x183CEB730")]
	public static bool BIBGNMIHGGC(NMAEDLGEGIF PEEDIPGMMHL, NMAEDLGEGIF PEFIBHOJLKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x62C8350", Offset = "0x62C6B50", VA = "0x1862C8350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MMKEFNNLEAK<TModern> : CEGAOGKGCEO<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PLNENDLEGNG(TModern LHJOEKFNPPA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GKCEKBLLBNK
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid EDNMEGAKOAM();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CEGAOGKGCEO<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern DKEOIEJLCKF(string LHJOEKFNPPA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LLHGNNNFGII
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	MMKEFNNLEAK<KCCBIEDEHAE> CNOLKOGGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	MMKEFNNLEAK<LGPONKIMBFD> NFGJIPMNLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	MMKEFNNLEAK<MOBMKCBOGGK> NBMDFPOALGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MMKEFNNLEAK<GDKFIEIKKHJ> ANBPNNLMICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	MMKEFNNLEAK<FHPKPIBGCPD> KLDGDNAOAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	MMKEFNNLEAK<FMLMECGDFMD> FMCGDOFHDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	MMKEFNNLEAK<LKCHMMBKAAD> MJKOHDIHJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	MMKEFNNLEAK<EDCHCDBGJBI> BMPFFNDFCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IHBAPKOMHMM
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x62C7D80", Offset = "0x62C6580", VA = "0x1862C7D80")]
	public static string[] HBFOKFEAHCL(string? ILMGMNIPIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x62C7E40", Offset = "0x62C6640", VA = "0x1862C7E40")]
	public static string? KJAFMGKDFDI(string? PLGEBDELIBL)
	{
		return null;
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
