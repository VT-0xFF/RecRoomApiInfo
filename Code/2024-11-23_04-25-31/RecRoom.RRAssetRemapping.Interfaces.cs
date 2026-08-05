using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7551440", Offset = "0x754FE40", VA = "0x187551440")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D78D0", Offset = "0x8D62D0", VA = "0x1808D78D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HNJBJMEDIHE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HLGBFIEHJDG(KPJKPOMJGHE CPOLINJHFNA);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KPJKPOMJGHE DLDAMIHNNNK(string CPOLINJHFNA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct KPJKPOMJGHE : IEquatable<KPJKPOMJGHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly FDADCHGPADP MHMENHGFODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly LEPAIFLHDDH BEGMLBAIEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid HHNGPFCJMGG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FJLPJADOLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7550E10", Offset = "0x754F810", VA = "0x187550E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AIGIJLFIMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7550DE0", Offset = "0x754F7E0", VA = "0x187550DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75511A0", Offset = "0x754FBA0", VA = "0x1875511A0")]
	public KPJKPOMJGHE(KPJKPOMJGHE JDNOHOIHOKG, [Optional] Guid EMOKKAAEAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x50A8C90", Offset = "0x50A7690", VA = "0x1850A8C90")]
	public KPJKPOMJGHE(FDADCHGPADP CDALCEGIBHB, LEPAIFLHDDH GOJEAAACHJL, [Optional] Guid EMOKKAAEAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7550BE0", Offset = "0x754F5E0", VA = "0x187550BE0", Slot = "4")]
	public bool Equals(KPJKPOMJGHE GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7550CA0", Offset = "0x754F6A0", VA = "0x187550CA0", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7550D50", Offset = "0x754F750", VA = "0x187550D50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7550BB0", Offset = "0x754F5B0", VA = "0x187550BB0")]
	public static bool EKIKFCPHGPG(KPJKPOMJGHE FCKNABCAAPB, KPJKPOMJGHE JGIIKLPFBFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7550B70", Offset = "0x754F570", VA = "0x187550B70")]
	public static bool DKPEAJCEKME(KPJKPOMJGHE FCKNABCAAPB, KPJKPOMJGHE JGIIKLPFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7550EA0", Offset = "0x754F8A0", VA = "0x187550EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct FDADCHGPADP : IEquatable<FDADCHGPADP>, IComparable<FDADCHGPADP>, CHMODCOCIAL
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly FDADCHGPADP BDDJBNJILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid MMGMNLELLKG;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
	public FDADCHGPADP(Guid MMGMNLELLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
	public Guid FICIGFHCHPG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4681680", Offset = "0x4680080", VA = "0x184681680", Slot = "4")]
	public bool Equals(FDADCHGPADP GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4681040", Offset = "0x467FA40", VA = "0x184681040", Slot = "5")]
	public int CompareTo(FDADCHGPADP GDOGPMPJPOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x75505D0", Offset = "0x754EFD0", VA = "0x1875505D0", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x46812F0", Offset = "0x467FCF0", VA = "0x1846812F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4681680", Offset = "0x4680080", VA = "0x184681680")]
	public static bool EKIKFCPHGPG(FDADCHGPADP FCKNABCAAPB, FDADCHGPADP JGIIKLPFBFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7550380", Offset = "0x754ED80", VA = "0x187550380")]
	public static bool DKPEAJCEKME(FDADCHGPADP FCKNABCAAPB, FDADCHGPADP JGIIKLPFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7550670", Offset = "0x754F070", VA = "0x187550670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct IKEMKMCCCBO : IEquatable<IKEMKMCCCBO>, IComparable<IKEMKMCCCBO>, CHMODCOCIAL
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly IKEMKMCCCBO BDDJBNJILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid MMGMNLELLKG;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
	public IKEMKMCCCBO(Guid MMGMNLELLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
	public Guid FICIGFHCHPG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4681680", Offset = "0x4680080", VA = "0x184681680", Slot = "4")]
	public bool Equals(IKEMKMCCCBO GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4681040", Offset = "0x467FA40", VA = "0x184681040", Slot = "5")]
	public int CompareTo(IKEMKMCCCBO GDOGPMPJPOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x75507F0", Offset = "0x754F1F0", VA = "0x1875507F0", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x46812F0", Offset = "0x467FCF0", VA = "0x1846812F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4681680", Offset = "0x4680080", VA = "0x184681680")]
	public static bool EKIKFCPHGPG(IKEMKMCCCBO FCKNABCAAPB, IKEMKMCCCBO JGIIKLPFBFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7550380", Offset = "0x754ED80", VA = "0x187550380")]
	public static bool DKPEAJCEKME(IKEMKMCCCBO FCKNABCAAPB, IKEMKMCCCBO JGIIKLPFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7550890", Offset = "0x754F290", VA = "0x187550890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct JLNNJCEGLJL : IEquatable<JLNNJCEGLJL>, IComparable<JLNNJCEGLJL>, CHMODCOCIAL
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly JLNNJCEGLJL BDDJBNJILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid MMGMNLELLKG;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
	public JLNNJCEGLJL(Guid MMGMNLELLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
	public Guid FICIGFHCHPG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4681680", Offset = "0x4680080", VA = "0x184681680", Slot = "4")]
	public bool Equals(JLNNJCEGLJL GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4681040", Offset = "0x467FA40", VA = "0x184681040", Slot = "5")]
	public int CompareTo(JLNNJCEGLJL GDOGPMPJPOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7550A60", Offset = "0x754F460", VA = "0x187550A60", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x46812F0", Offset = "0x467FCF0", VA = "0x1846812F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4681680", Offset = "0x4680080", VA = "0x184681680")]
	public static bool EKIKFCPHGPG(JLNNJCEGLJL FCKNABCAAPB, JLNNJCEGLJL JGIIKLPFBFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7550380", Offset = "0x754ED80", VA = "0x187550380")]
	public static bool DKPEAJCEKME(JLNNJCEGLJL FCKNABCAAPB, JLNNJCEGLJL JGIIKLPFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7550B00", Offset = "0x754F500", VA = "0x187550B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct LEPAIFLHDDH : IEquatable<LEPAIFLHDDH>, IComparable<LEPAIFLHDDH>, CHMODCOCIAL
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly LEPAIFLHDDH BDDJBNJILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid MMGMNLELLKG;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
	public LEPAIFLHDDH(Guid MMGMNLELLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
	public Guid FICIGFHCHPG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x75511F0", Offset = "0x754FBF0", VA = "0x1875511F0", Slot = "4")]
	public bool Equals(LEPAIFLHDDH GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7551220", Offset = "0x754FC20", VA = "0x187551220", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x46812F0", Offset = "0x467FCF0", VA = "0x1846812F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x75511F0", Offset = "0x754FBF0", VA = "0x1875511F0")]
	public static bool EKIKFCPHGPG(LEPAIFLHDDH FCKNABCAAPB, LEPAIFLHDDH JGIIKLPFBFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x75511C0", Offset = "0x754FBC0", VA = "0x1875511C0")]
	public static bool DKPEAJCEKME(LEPAIFLHDDH FCKNABCAAPB, LEPAIFLHDDH JGIIKLPFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4681040", Offset = "0x467FA40", VA = "0x184681040", Slot = "5")]
	public int CompareTo(LEPAIFLHDDH GDOGPMPJPOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x75512C0", Offset = "0x754FCC0", VA = "0x1875512C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
	public LEPAIFLHDDH(OGEBMIEBBJO LLACAMHLMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LOIONMFEKKG : IEquatable<LOIONMFEKKG>, IComparable<LOIONMFEKKG>, CHMODCOCIAL
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly LOIONMFEKKG BDDJBNJILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid MMGMNLELLKG;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
	public LOIONMFEKKG(Guid MMGMNLELLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
	public Guid FICIGFHCHPG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4681680", Offset = "0x4680080", VA = "0x184681680", Slot = "4")]
	public bool Equals(LOIONMFEKKG GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4681040", Offset = "0x467FA40", VA = "0x184681040", Slot = "5")]
	public int CompareTo(LOIONMFEKKG GDOGPMPJPOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7551330", Offset = "0x754FD30", VA = "0x187551330", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x46812F0", Offset = "0x467FCF0", VA = "0x1846812F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4681680", Offset = "0x4680080", VA = "0x184681680")]
	public static bool EKIKFCPHGPG(LOIONMFEKKG FCKNABCAAPB, LOIONMFEKKG JGIIKLPFBFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7550380", Offset = "0x754ED80", VA = "0x187550380")]
	public static bool DKPEAJCEKME(LOIONMFEKKG FCKNABCAAPB, LOIONMFEKKG JGIIKLPFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x75513D0", Offset = "0x754FDD0", VA = "0x1875513D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct FNFEKAHOFPA : IEquatable<FNFEKAHOFPA>, IComparable<FNFEKAHOFPA>, CHMODCOCIAL
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly FNFEKAHOFPA BDDJBNJILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid MMGMNLELLKG;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
	public FNFEKAHOFPA(Guid MMGMNLELLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
	public Guid FICIGFHCHPG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4681680", Offset = "0x4680080", VA = "0x184681680", Slot = "4")]
	public bool Equals(FNFEKAHOFPA GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4681040", Offset = "0x467FA40", VA = "0x184681040", Slot = "5")]
	public int CompareTo(FNFEKAHOFPA GDOGPMPJPOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x75506E0", Offset = "0x754F0E0", VA = "0x1875506E0", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x46812F0", Offset = "0x467FCF0", VA = "0x1846812F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4681680", Offset = "0x4680080", VA = "0x184681680")]
	public static bool EKIKFCPHGPG(FNFEKAHOFPA FCKNABCAAPB, FNFEKAHOFPA JGIIKLPFBFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7550380", Offset = "0x754ED80", VA = "0x187550380")]
	public static bool DKPEAJCEKME(FNFEKAHOFPA FCKNABCAAPB, FNFEKAHOFPA JGIIKLPFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7550780", Offset = "0x754F180", VA = "0x187550780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct CCCHHPPCONE : IEquatable<CCCHHPPCONE>, IComparable<CCCHHPPCONE>, CHMODCOCIAL
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly CCCHHPPCONE BDDJBNJILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid MMGMNLELLKG;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
	public CCCHHPPCONE(Guid MMGMNLELLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
	public Guid FICIGFHCHPG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4681680", Offset = "0x4680080", VA = "0x184681680", Slot = "4")]
	public bool Equals(CCCHHPPCONE GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4681040", Offset = "0x467FA40", VA = "0x184681040", Slot = "5")]
	public int CompareTo(CCCHHPPCONE GDOGPMPJPOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x75504C0", Offset = "0x754EEC0", VA = "0x1875504C0", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x46812F0", Offset = "0x467FCF0", VA = "0x1846812F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4681680", Offset = "0x4680080", VA = "0x184681680")]
	public static bool EKIKFCPHGPG(CCCHHPPCONE FCKNABCAAPB, CCCHHPPCONE JGIIKLPFBFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7550380", Offset = "0x754ED80", VA = "0x187550380")]
	public static bool DKPEAJCEKME(CCCHHPPCONE FCKNABCAAPB, CCCHHPPCONE JGIIKLPFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7550560", Offset = "0x754EF60", VA = "0x187550560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct AFIMDNDGDAB : IEquatable<AFIMDNDGDAB>, IComparable<AFIMDNDGDAB>, CHMODCOCIAL
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly AFIMDNDGDAB BDDJBNJILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid MMGMNLELLKG;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
	public AFIMDNDGDAB(Guid MMGMNLELLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
	public Guid FICIGFHCHPG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4681680", Offset = "0x4680080", VA = "0x184681680", Slot = "4")]
	public bool Equals(AFIMDNDGDAB GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4681040", Offset = "0x467FA40", VA = "0x184681040", Slot = "5")]
	public int CompareTo(AFIMDNDGDAB GDOGPMPJPOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x75503B0", Offset = "0x754EDB0", VA = "0x1875503B0", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x46812F0", Offset = "0x467FCF0", VA = "0x1846812F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4681680", Offset = "0x4680080", VA = "0x184681680")]
	public static bool EKIKFCPHGPG(AFIMDNDGDAB FCKNABCAAPB, AFIMDNDGDAB JGIIKLPFBFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7550380", Offset = "0x754ED80", VA = "0x187550380")]
	public static bool DKPEAJCEKME(AFIMDNDGDAB FCKNABCAAPB, AFIMDNDGDAB JGIIKLPFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7550450", Offset = "0x754EE50", VA = "0x187550450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct OHLBACBECAH : IEquatable<OHLBACBECAH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? EGMJDLICGDK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EFLKLBKLPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x75515D0", Offset = "0x754FFD0", VA = "0x1875515D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int ALBMOPGJAGB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4537490", Offset = "0x4535E90", VA = "0x184537490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7551BD0", Offset = "0x75505D0", VA = "0x187551BD0")]
	public OHLBACBECAH(string? BEPKJBCMDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7551B50", Offset = "0x7550550", VA = "0x187551B50")]
	public OHLBACBECAH(string?[] CNAKDOABPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7551890", Offset = "0x7550290", VA = "0x187551890")]
	private static string?[]? INAPMNABCMC(string?[]? CNAKDOABPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x75515F0", Offset = "0x754FFF0", VA = "0x1875515F0")]
	public string EKCJODLGLFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7551650", Offset = "0x7550050", VA = "0x187551650", Slot = "4")]
	public bool Equals(OHLBACBECAH GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7551720", Offset = "0x7550120", VA = "0x187551720", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x75517B0", Offset = "0x75501B0", VA = "0x1875517B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7551AC0", Offset = "0x75504C0", VA = "0x187551AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct OGEBMIEBBJO : IEquatable<OGEBMIEBBJO>, IComparable<OGEBMIEBBJO>, CHMODCOCIAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid MMGMNLELLKG;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
	public OGEBMIEBBJO(Guid MMGMNLELLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
	public Guid FICIGFHCHPG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4681680", Offset = "0x4680080", VA = "0x184681680", Slot = "4")]
	public bool Equals(OGEBMIEBBJO GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4681040", Offset = "0x467FA40", VA = "0x184681040", Slot = "5")]
	public int CompareTo(OGEBMIEBBJO GDOGPMPJPOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x75514C0", Offset = "0x754FEC0", VA = "0x1875514C0", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x46812F0", Offset = "0x467FCF0", VA = "0x1846812F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7551560", Offset = "0x754FF60", VA = "0x187551560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OHCBNEMNKEA<TModern> : JKPEHELCBKF<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HMLOPFJFCLF(TModern CAPCIPBNAGM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CHMODCOCIAL
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid FICIGFHCHPG();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JKPEHELCBKF<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern JLHNOJGGFGH(string CAPCIPBNAGM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HELFAHKGAEL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OHCBNEMNKEA<FDADCHGPADP> BKHAJKBABBG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	OHCBNEMNKEA<LOIONMFEKKG> NJFIGNFLNNF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	OHCBNEMNKEA<AFIMDNDGDAB> DPLAMHBFAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	OHCBNEMNKEA<LEPAIFLHDDH> HHFFGIMBKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	OHCBNEMNKEA<JLNNJCEGLJL> EFCLLHHOEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OHCBNEMNKEA<CCCHHPPCONE> NDCNPOMGDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OHCBNEMNKEA<IKEMKMCCCBO> JEPLJGLMANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	OHCBNEMNKEA<FNFEKAHOFPA> MLCMJHLLDJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JJKEHOIEEAO
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] PIADGOAMLNG;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7550930", Offset = "0x754F330", VA = "0x187550930")]
	public static string[] IDGNBJMAHDC(string? BEPKJBCMDAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7550900", Offset = "0x754F300", VA = "0x187550900")]
	public static string? DDHIOGFDIJP(string? CDALCEGIBHB)
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
