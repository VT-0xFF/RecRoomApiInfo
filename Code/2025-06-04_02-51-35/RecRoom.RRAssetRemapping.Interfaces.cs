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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x885FC00", Offset = "0x885E400", VA = "0x18885FC00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PEDPMAPKDEC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GJCNJFECIPF(OOLKLJDECHH FNFJALHKEGF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OOLKLJDECHH OLFGCACBCKJ(string FNFJALHKEGF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct OOLKLJDECHH : IEquatable<OOLKLJDECHH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly HEHJIIEIGHG ONCPEFHFHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly HPJMJPAALJE NDCKIGBKGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid OLOFPEPFBNO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool PPJMNKIKHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x885FD90", Offset = "0x885E590", VA = "0x18885FD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LNHBKPPELFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8860020", Offset = "0x885E820", VA = "0x188860020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8860380", Offset = "0x885EB80", VA = "0x188860380")]
	public OOLKLJDECHH(OOLKLJDECHH HJBADDNKCIO, [Optional] Guid FLLEHMEKPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC5A0", Offset = "0x5EBADA0", VA = "0x185EBC5A0")]
	public OOLKLJDECHH(HEHJIIEIGHG NBHDLEDEAJP, HPJMJPAALJE OFJKGDGOHGE, [Optional] Guid FLLEHMEKPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x885FE20", Offset = "0x885E620", VA = "0x18885FE20", Slot = "4")]
	public bool Equals(OOLKLJDECHH KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x885FEE0", Offset = "0x885E6E0", VA = "0x18885FEE0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x885FF90", Offset = "0x885E790", VA = "0x18885FF90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8860050", Offset = "0x885E850", VA = "0x188860050")]
	public static bool NALNDDPCEFD(OOLKLJDECHH HGBNKPCDEON, OOLKLJDECHH DPOCHOAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8860080", Offset = "0x885E880", VA = "0x188860080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct HEHJIIEIGHG : IEquatable<HEHJIIEIGHG>, IComparable<HEHJIIEIGHG>, ODFIDMKBKKG
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HEHJIIEIGHG EBKBGKJDDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid JMHOEKKPCPG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x12F1FF0", Offset = "0x12F07F0", VA = "0x1812F1FF0")]
	public HEHJIIEIGHG(Guid JMHOEKKPCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530", Slot = "6")]
	public Guid BHIOJGJBPAC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0A000", VA = "0x186D0B800", Slot = "4")]
	public bool Equals(HEHJIIEIGHG KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B340", Offset = "0x6D09B40", VA = "0x186D0B340", Slot = "5")]
	public int CompareTo(HEHJIIEIGHG KEKEFPAJGHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x885F4F0", Offset = "0x885DCF0", VA = "0x18885F4F0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B7E0", Offset = "0x6D09FE0", VA = "0x186D0B7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0A000", VA = "0x186D0B800")]
	public static bool NALNDDPCEFD(HEHJIIEIGHG HGBNKPCDEON, HEHJIIEIGHG DPOCHOAKFKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x885F2A0", Offset = "0x885DAA0", VA = "0x18885F2A0")]
	public static bool BLLMPNNLKNM(HEHJIIEIGHG HGBNKPCDEON, HEHJIIEIGHG DPOCHOAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x885F590", Offset = "0x885DD90", VA = "0x18885F590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct ELCOPAOPGEO : IEquatable<ELCOPAOPGEO>, IComparable<ELCOPAOPGEO>, ODFIDMKBKKG
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly ELCOPAOPGEO EBKBGKJDDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid JMHOEKKPCPG;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x12F1FF0", Offset = "0x12F07F0", VA = "0x1812F1FF0")]
	public ELCOPAOPGEO(Guid JMHOEKKPCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530", Slot = "6")]
	public Guid BHIOJGJBPAC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0A000", VA = "0x186D0B800", Slot = "4")]
	public bool Equals(ELCOPAOPGEO KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B340", Offset = "0x6D09B40", VA = "0x186D0B340", Slot = "5")]
	public int CompareTo(ELCOPAOPGEO KEKEFPAJGHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x885F3E0", Offset = "0x885DBE0", VA = "0x18885F3E0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B7E0", Offset = "0x6D09FE0", VA = "0x186D0B7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0A000", VA = "0x186D0B800")]
	public static bool NALNDDPCEFD(ELCOPAOPGEO HGBNKPCDEON, ELCOPAOPGEO DPOCHOAKFKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x885F2A0", Offset = "0x885DAA0", VA = "0x18885F2A0")]
	public static bool BLLMPNNLKNM(ELCOPAOPGEO HGBNKPCDEON, ELCOPAOPGEO DPOCHOAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x885F480", Offset = "0x885DC80", VA = "0x18885F480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct JEDHAPKMNJI : IEquatable<JEDHAPKMNJI>, IComparable<JEDHAPKMNJI>, ODFIDMKBKKG
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly JEDHAPKMNJI EBKBGKJDDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid JMHOEKKPCPG;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x12F1FF0", Offset = "0x12F07F0", VA = "0x1812F1FF0")]
	public JEDHAPKMNJI(Guid JMHOEKKPCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530", Slot = "6")]
	public Guid BHIOJGJBPAC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0A000", VA = "0x186D0B800", Slot = "4")]
	public bool Equals(JEDHAPKMNJI KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B340", Offset = "0x6D09B40", VA = "0x186D0B340", Slot = "5")]
	public int CompareTo(JEDHAPKMNJI KEKEFPAJGHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x885F770", Offset = "0x885DF70", VA = "0x18885F770", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B7E0", Offset = "0x6D09FE0", VA = "0x186D0B7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0A000", VA = "0x186D0B800")]
	public static bool NALNDDPCEFD(JEDHAPKMNJI HGBNKPCDEON, JEDHAPKMNJI DPOCHOAKFKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x885F2A0", Offset = "0x885DAA0", VA = "0x18885F2A0")]
	public static bool BLLMPNNLKNM(JEDHAPKMNJI HGBNKPCDEON, JEDHAPKMNJI DPOCHOAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x885F810", Offset = "0x885E010", VA = "0x18885F810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct HPJMJPAALJE : IEquatable<HPJMJPAALJE>, IComparable<HPJMJPAALJE>, ODFIDMKBKKG
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly HPJMJPAALJE EBKBGKJDDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid JMHOEKKPCPG;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x12F1FF0", Offset = "0x12F07F0", VA = "0x1812F1FF0")]
	public HPJMJPAALJE(Guid JMHOEKKPCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530", Slot = "6")]
	public Guid BHIOJGJBPAC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x885F6D0", Offset = "0x885DED0", VA = "0x18885F6D0", Slot = "4")]
	public bool Equals(HPJMJPAALJE KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x885F630", Offset = "0x885DE30", VA = "0x18885F630", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B7E0", Offset = "0x6D09FE0", VA = "0x186D0B7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x885F6D0", Offset = "0x885DED0", VA = "0x18885F6D0")]
	public static bool NALNDDPCEFD(HPJMJPAALJE HGBNKPCDEON, HPJMJPAALJE DPOCHOAKFKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x885F600", Offset = "0x885DE00", VA = "0x18885F600")]
	public static bool BLLMPNNLKNM(HPJMJPAALJE HGBNKPCDEON, HPJMJPAALJE DPOCHOAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B340", Offset = "0x6D09B40", VA = "0x186D0B340", Slot = "5")]
	public int CompareTo(HPJMJPAALJE KEKEFPAJGHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x885F700", Offset = "0x885DF00", VA = "0x18885F700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x12F1FF0", Offset = "0x12F07F0", VA = "0x1812F1FF0")]
	public HPJMJPAALJE(PLIEFDEKNOM DJIOHHBLNJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct OCDLBHBCPMH : IEquatable<OCDLBHBCPMH>, IComparable<OCDLBHBCPMH>, ODFIDMKBKKG
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly OCDLBHBCPMH EBKBGKJDDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid JMHOEKKPCPG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x12F1FF0", Offset = "0x12F07F0", VA = "0x1812F1FF0")]
	public OCDLBHBCPMH(Guid JMHOEKKPCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530", Slot = "6")]
	public Guid BHIOJGJBPAC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0A000", VA = "0x186D0B800", Slot = "4")]
	public bool Equals(OCDLBHBCPMH KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B340", Offset = "0x6D09B40", VA = "0x186D0B340", Slot = "5")]
	public int CompareTo(OCDLBHBCPMH KEKEFPAJGHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x885FC80", Offset = "0x885E480", VA = "0x18885FC80", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B7E0", Offset = "0x6D09FE0", VA = "0x186D0B7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0A000", VA = "0x186D0B800")]
	public static bool NALNDDPCEFD(OCDLBHBCPMH HGBNKPCDEON, OCDLBHBCPMH DPOCHOAKFKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x885F2A0", Offset = "0x885DAA0", VA = "0x18885F2A0")]
	public static bool BLLMPNNLKNM(OCDLBHBCPMH HGBNKPCDEON, OCDLBHBCPMH DPOCHOAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x885FD20", Offset = "0x885E520", VA = "0x18885FD20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct JKBFIDNMNPD : IEquatable<JKBFIDNMNPD>, IComparable<JKBFIDNMNPD>, ODFIDMKBKKG
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly JKBFIDNMNPD EBKBGKJDDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid JMHOEKKPCPG;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x12F1FF0", Offset = "0x12F07F0", VA = "0x1812F1FF0")]
	public JKBFIDNMNPD(Guid JMHOEKKPCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530", Slot = "6")]
	public Guid BHIOJGJBPAC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0A000", VA = "0x186D0B800", Slot = "4")]
	public bool Equals(JKBFIDNMNPD KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B340", Offset = "0x6D09B40", VA = "0x186D0B340", Slot = "5")]
	public int CompareTo(JKBFIDNMNPD KEKEFPAJGHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x885F880", Offset = "0x885E080", VA = "0x18885F880", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B7E0", Offset = "0x6D09FE0", VA = "0x186D0B7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0A000", VA = "0x186D0B800")]
	public static bool NALNDDPCEFD(JKBFIDNMNPD HGBNKPCDEON, JKBFIDNMNPD DPOCHOAKFKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x885F2A0", Offset = "0x885DAA0", VA = "0x18885F2A0")]
	public static bool BLLMPNNLKNM(JKBFIDNMNPD HGBNKPCDEON, JKBFIDNMNPD DPOCHOAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x885F920", Offset = "0x885E120", VA = "0x18885F920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct DOHLNGAKGFD : IEquatable<DOHLNGAKGFD>, IComparable<DOHLNGAKGFD>, ODFIDMKBKKG
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly DOHLNGAKGFD EBKBGKJDDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid JMHOEKKPCPG;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x12F1FF0", Offset = "0x12F07F0", VA = "0x1812F1FF0")]
	public DOHLNGAKGFD(Guid JMHOEKKPCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530", Slot = "6")]
	public Guid BHIOJGJBPAC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0A000", VA = "0x186D0B800", Slot = "4")]
	public bool Equals(DOHLNGAKGFD KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B340", Offset = "0x6D09B40", VA = "0x186D0B340", Slot = "5")]
	public int CompareTo(DOHLNGAKGFD KEKEFPAJGHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x885F2D0", Offset = "0x885DAD0", VA = "0x18885F2D0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B7E0", Offset = "0x6D09FE0", VA = "0x186D0B7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0A000", VA = "0x186D0B800")]
	public static bool NALNDDPCEFD(DOHLNGAKGFD HGBNKPCDEON, DOHLNGAKGFD DPOCHOAKFKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x885F2A0", Offset = "0x885DAA0", VA = "0x18885F2A0")]
	public static bool BLLMPNNLKNM(DOHLNGAKGFD HGBNKPCDEON, DOHLNGAKGFD DPOCHOAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x885F370", Offset = "0x885DB70", VA = "0x18885F370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct MCDPEDAICEL : IEquatable<MCDPEDAICEL>, IComparable<MCDPEDAICEL>, ODFIDMKBKKG
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly MCDPEDAICEL EBKBGKJDDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid JMHOEKKPCPG;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x12F1FF0", Offset = "0x12F07F0", VA = "0x1812F1FF0")]
	public MCDPEDAICEL(Guid JMHOEKKPCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530", Slot = "6")]
	public Guid BHIOJGJBPAC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0A000", VA = "0x186D0B800", Slot = "4")]
	public bool Equals(MCDPEDAICEL KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B340", Offset = "0x6D09B40", VA = "0x186D0B340", Slot = "5")]
	public int CompareTo(MCDPEDAICEL KEKEFPAJGHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x885FAF0", Offset = "0x885E2F0", VA = "0x18885FAF0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B7E0", Offset = "0x6D09FE0", VA = "0x186D0B7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0A000", VA = "0x186D0B800")]
	public static bool NALNDDPCEFD(MCDPEDAICEL HGBNKPCDEON, MCDPEDAICEL DPOCHOAKFKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x885F2A0", Offset = "0x885DAA0", VA = "0x18885F2A0")]
	public static bool BLLMPNNLKNM(MCDPEDAICEL HGBNKPCDEON, MCDPEDAICEL DPOCHOAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x885FB90", Offset = "0x885E390", VA = "0x18885FB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct BODDLEFMJJJ : IEquatable<BODDLEFMJJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? EDENGDIJOIM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KBMDKILMFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x885EFC0", Offset = "0x885D7C0", VA = "0x18885EFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int AKDNKMMLDBG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x528C230", Offset = "0x528AA30", VA = "0x18528C230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x885F0D0", Offset = "0x885D8D0", VA = "0x18885F0D0")]
	public BODDLEFMJJJ(string? NOOAALABCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x885F220", Offset = "0x885DA20", VA = "0x18885F220")]
	public BODDLEFMJJJ(string?[] NIGBHBDGPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x885EB50", Offset = "0x885D350", VA = "0x18885EB50")]
	private static string?[]? CLFBDLJJJFF(string?[]? NIGBHBDGPJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x885EFE0", Offset = "0x885D7E0", VA = "0x18885EFE0")]
	public string MOGCODECBMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x885ED80", Offset = "0x885D580", VA = "0x18885ED80", Slot = "4")]
	public bool Equals(BODDLEFMJJJ KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x885EE50", Offset = "0x885D650", VA = "0x18885EE50", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x885EEE0", Offset = "0x885D6E0", VA = "0x18885EEE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x885F040", Offset = "0x885D840", VA = "0x18885F040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct PLIEFDEKNOM : IEquatable<PLIEFDEKNOM>, IComparable<PLIEFDEKNOM>, ODFIDMKBKKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid JMHOEKKPCPG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x12F1FF0", Offset = "0x12F07F0", VA = "0x1812F1FF0")]
	public PLIEFDEKNOM(Guid JMHOEKKPCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530", Slot = "6")]
	public Guid BHIOJGJBPAC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0A000", VA = "0x186D0B800", Slot = "4")]
	public bool Equals(PLIEFDEKNOM KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B340", Offset = "0x6D09B40", VA = "0x186D0B340", Slot = "5")]
	public int CompareTo(PLIEFDEKNOM KEKEFPAJGHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x88603A0", Offset = "0x885EBA0", VA = "0x1888603A0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B7E0", Offset = "0x6D09FE0", VA = "0x186D0B7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8860440", Offset = "0x885EC40", VA = "0x188860440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PLLILOMKMAL<TModern> : ADEOFBMAHDG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NELNPACLAIC(TModern BPLIGBCPOCK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ODFIDMKBKKG
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid BHIOJGJBPAC();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ADEOFBMAHDG<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern JLGDJGKFJHE(string BPLIGBCPOCK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EHFMOIGBMGN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	PLLILOMKMAL<HEHJIIEIGHG> OKFCPMIHCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	PLLILOMKMAL<OCDLBHBCPMH> PLKEOIPJMCD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PLLILOMKMAL<MCDPEDAICEL> IBJNBHKBBMP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	PLLILOMKMAL<HPJMJPAALJE> NKGDMFAAGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	PLLILOMKMAL<JEDHAPKMNJI> ILEHHCHDKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PLLILOMKMAL<DOHLNGAKGFD> MMLGPKLAIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PLLILOMKMAL<ELCOPAOPGEO> OMNNHMLJCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	PLLILOMKMAL<JKBFIDNMNPD> AGGEADCBLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class KJIGAEDNFPO
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] GDFKAKEEDLG;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x885F9C0", Offset = "0x885E1C0", VA = "0x18885F9C0")]
	public static string[] GEFCPHPICPM(string? NOOAALABCFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x885F990", Offset = "0x885E190", VA = "0x18885F990")]
	public static string? CGIMNMPGJBJ(string? NBHDLEDEAJP)
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
