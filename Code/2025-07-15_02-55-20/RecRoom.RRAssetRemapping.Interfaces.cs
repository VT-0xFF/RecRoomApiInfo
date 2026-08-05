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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A096F0", Offset = "0x8A082F0", VA = "0x188A096F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
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
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JMHIIDMNIMF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PBHGMJKEMBG(KJEPDDGGDOL HOKNBAKODNG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KJEPDDGGDOL GLDNKJDIMCO(string HOKNBAKODNG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct KJEPDDGGDOL : IEquatable<KJEPDDGGDOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly IBGOJPCJDBO HFNMDJDALHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly GFJCEPIDMBH KGNKNIDPGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid MKBGABGDBKJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LENKLAKLCGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A09030", Offset = "0x8A07C30", VA = "0x188A09030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OBELIPEMIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A09150", Offset = "0x8A07D50", VA = "0x188A09150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8A09490", Offset = "0x8A08090", VA = "0x188A09490")]
	public KJEPDDGGDOL(KJEPDDGGDOL OAKDAKLMFPO, [Optional] Guid COGDOHLDAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x600AF10", Offset = "0x6009B10", VA = "0x18600AF10")]
	public KJEPDDGGDOL(IBGOJPCJDBO BBGEAICPIAD, GFJCEPIDMBH IAJPDGIFGKB, [Optional] Guid COGDOHLDAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8A08F70", Offset = "0x8A07B70", VA = "0x188A08F70", Slot = "4")]
	public bool Equals(KJEPDDGGDOL IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8A08EC0", Offset = "0x8A07AC0", VA = "0x188A08EC0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8A090C0", Offset = "0x8A07CC0", VA = "0x188A090C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8A08E90", Offset = "0x8A07A90", VA = "0x188A08E90")]
	public static bool CDGFDPOPEPC(KJEPDDGGDOL ODBANBBPCIA, KJEPDDGGDOL FMNHBACBGIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8A09180", Offset = "0x8A07D80", VA = "0x188A09180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct IBGOJPCJDBO : IEquatable<IBGOJPCJDBO>, IComparable<IBGOJPCJDBO>, CIMNPCOKFON
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly IBGOJPCJDBO LNCBONNLALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid FHNOHJCOOKK;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x14354C0", Offset = "0x14340C0", VA = "0x1814354C0")]
	public IBGOJPCJDBO(Guid FHNOHJCOOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
	public Guid OECFNIJJKJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D5E0", Offset = "0x4E9C1E0", VA = "0x184E9D5E0", Slot = "4")]
	public bool Equals(IBGOJPCJDBO IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CF70", Offset = "0x4E9BB70", VA = "0x184E9CF70", Slot = "5")]
	public int CompareTo(IBGOJPCJDBO IIOGPDPGOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8A08D70", Offset = "0x8A07970", VA = "0x188A08D70", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D1E0", Offset = "0x4E9BDE0", VA = "0x184E9D1E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D5E0", Offset = "0x4E9C1E0", VA = "0x184E9D5E0")]
	public static bool CDGFDPOPEPC(IBGOJPCJDBO ODBANBBPCIA, IBGOJPCJDBO FMNHBACBGIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8A08CD0", Offset = "0x8A078D0", VA = "0x188A08CD0")]
	public static bool IECKAGJENEB(IBGOJPCJDBO ODBANBBPCIA, IBGOJPCJDBO FMNHBACBGIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8A08E20", Offset = "0x8A07A20", VA = "0x188A08E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct ODODAOJKFLP : IEquatable<ODODAOJKFLP>, IComparable<ODODAOJKFLP>, CIMNPCOKFON
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly ODODAOJKFLP LNCBONNLALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid FHNOHJCOOKK;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x14354C0", Offset = "0x14340C0", VA = "0x1814354C0")]
	public ODODAOJKFLP(Guid FHNOHJCOOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
	public Guid OECFNIJJKJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D5E0", Offset = "0x4E9C1E0", VA = "0x184E9D5E0", Slot = "4")]
	public bool Equals(ODODAOJKFLP IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CF70", Offset = "0x4E9BB70", VA = "0x184E9CF70", Slot = "5")]
	public int CompareTo(ODODAOJKFLP IIOGPDPGOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8A09770", Offset = "0x8A08370", VA = "0x188A09770", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D1E0", Offset = "0x4E9BDE0", VA = "0x184E9D1E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D5E0", Offset = "0x4E9C1E0", VA = "0x184E9D5E0")]
	public static bool CDGFDPOPEPC(ODODAOJKFLP ODBANBBPCIA, ODODAOJKFLP FMNHBACBGIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8A08CD0", Offset = "0x8A078D0", VA = "0x188A08CD0")]
	public static bool IECKAGJENEB(ODODAOJKFLP ODBANBBPCIA, ODODAOJKFLP FMNHBACBGIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8A09820", Offset = "0x8A08420", VA = "0x188A09820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct HKOGKMHLCPM : IEquatable<HKOGKMHLCPM>, IComparable<HKOGKMHLCPM>, CIMNPCOKFON
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly HKOGKMHLCPM LNCBONNLALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid FHNOHJCOOKK;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x14354C0", Offset = "0x14340C0", VA = "0x1814354C0")]
	public HKOGKMHLCPM(Guid FHNOHJCOOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
	public Guid OECFNIJJKJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D5E0", Offset = "0x4E9C1E0", VA = "0x184E9D5E0", Slot = "4")]
	public bool Equals(HKOGKMHLCPM IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CF70", Offset = "0x4E9BB70", VA = "0x184E9CF70", Slot = "5")]
	public int CompareTo(HKOGKMHLCPM IIOGPDPGOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8A08C20", Offset = "0x8A07820", VA = "0x188A08C20", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D1E0", Offset = "0x4E9BDE0", VA = "0x184E9D1E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D5E0", Offset = "0x4E9C1E0", VA = "0x184E9D5E0")]
	public static bool CDGFDPOPEPC(HKOGKMHLCPM ODBANBBPCIA, HKOGKMHLCPM FMNHBACBGIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8A08CD0", Offset = "0x8A078D0", VA = "0x188A08CD0")]
	public static bool IECKAGJENEB(HKOGKMHLCPM ODBANBBPCIA, HKOGKMHLCPM FMNHBACBGIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8A08D00", Offset = "0x8A07900", VA = "0x188A08D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct GFJCEPIDMBH : IEquatable<GFJCEPIDMBH>, IComparable<GFJCEPIDMBH>, CIMNPCOKFON
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly GFJCEPIDMBH LNCBONNLALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid FHNOHJCOOKK;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x14354C0", Offset = "0x14340C0", VA = "0x1814354C0")]
	public GFJCEPIDMBH(Guid FHNOHJCOOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
	public Guid OECFNIJJKJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8A08350", Offset = "0x8A06F50", VA = "0x188A08350", Slot = "4")]
	public bool Equals(GFJCEPIDMBH IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8A08380", Offset = "0x8A06F80", VA = "0x188A08380", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D1E0", Offset = "0x4E9BDE0", VA = "0x184E9D1E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8A08350", Offset = "0x8A06F50", VA = "0x188A08350")]
	public static bool CDGFDPOPEPC(GFJCEPIDMBH ODBANBBPCIA, GFJCEPIDMBH FMNHBACBGIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8A08430", Offset = "0x8A07030", VA = "0x188A08430")]
	public static bool IECKAGJENEB(GFJCEPIDMBH ODBANBBPCIA, GFJCEPIDMBH FMNHBACBGIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CF70", Offset = "0x4E9BB70", VA = "0x184E9CF70", Slot = "5")]
	public int CompareTo(GFJCEPIDMBH IIOGPDPGOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8A08460", Offset = "0x8A07060", VA = "0x188A08460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x14354C0", Offset = "0x14340C0", VA = "0x1814354C0")]
	public GFJCEPIDMBH(AEMNJGHKJNB PGGKCHFCEHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LBIEPCDDEBD : IEquatable<LBIEPCDDEBD>, IComparable<LBIEPCDDEBD>, CIMNPCOKFON
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly LBIEPCDDEBD LNCBONNLALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid FHNOHJCOOKK;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x14354C0", Offset = "0x14340C0", VA = "0x1814354C0")]
	public LBIEPCDDEBD(Guid FHNOHJCOOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
	public Guid OECFNIJJKJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D5E0", Offset = "0x4E9C1E0", VA = "0x184E9D5E0", Slot = "4")]
	public bool Equals(LBIEPCDDEBD IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CF70", Offset = "0x4E9BB70", VA = "0x184E9CF70", Slot = "5")]
	public int CompareTo(LBIEPCDDEBD IIOGPDPGOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8A095D0", Offset = "0x8A081D0", VA = "0x188A095D0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D1E0", Offset = "0x4E9BDE0", VA = "0x184E9D1E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D5E0", Offset = "0x4E9C1E0", VA = "0x184E9D5E0")]
	public static bool CDGFDPOPEPC(LBIEPCDDEBD ODBANBBPCIA, LBIEPCDDEBD FMNHBACBGIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8A08CD0", Offset = "0x8A078D0", VA = "0x188A08CD0")]
	public static bool IECKAGJENEB(LBIEPCDDEBD ODBANBBPCIA, LBIEPCDDEBD FMNHBACBGIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8A09680", Offset = "0x8A08280", VA = "0x188A09680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct PFINHFPAAHI : IEquatable<PFINHFPAAHI>, IComparable<PFINHFPAAHI>, CIMNPCOKFON
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly PFINHFPAAHI LNCBONNLALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid FHNOHJCOOKK;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x14354C0", Offset = "0x14340C0", VA = "0x1814354C0")]
	public PFINHFPAAHI(Guid FHNOHJCOOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
	public Guid OECFNIJJKJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D5E0", Offset = "0x4E9C1E0", VA = "0x184E9D5E0", Slot = "4")]
	public bool Equals(PFINHFPAAHI IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CF70", Offset = "0x4E9BB70", VA = "0x184E9CF70", Slot = "5")]
	public int CompareTo(PFINHFPAAHI IIOGPDPGOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8A099B0", Offset = "0x8A085B0", VA = "0x188A099B0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D1E0", Offset = "0x4E9BDE0", VA = "0x184E9D1E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D5E0", Offset = "0x4E9C1E0", VA = "0x184E9D5E0")]
	public static bool CDGFDPOPEPC(PFINHFPAAHI ODBANBBPCIA, PFINHFPAAHI FMNHBACBGIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8A08CD0", Offset = "0x8A078D0", VA = "0x188A08CD0")]
	public static bool IECKAGJENEB(PFINHFPAAHI ODBANBBPCIA, PFINHFPAAHI FMNHBACBGIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8A09A60", Offset = "0x8A08660", VA = "0x188A09A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct OLCDFLLEBBM : IEquatable<OLCDFLLEBBM>, IComparable<OLCDFLLEBBM>, CIMNPCOKFON
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly OLCDFLLEBBM LNCBONNLALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid FHNOHJCOOKK;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x14354C0", Offset = "0x14340C0", VA = "0x1814354C0")]
	public OLCDFLLEBBM(Guid FHNOHJCOOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
	public Guid OECFNIJJKJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D5E0", Offset = "0x4E9C1E0", VA = "0x184E9D5E0", Slot = "4")]
	public bool Equals(OLCDFLLEBBM IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CF70", Offset = "0x4E9BB70", VA = "0x184E9CF70", Slot = "5")]
	public int CompareTo(OLCDFLLEBBM IIOGPDPGOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8A09890", Offset = "0x8A08490", VA = "0x188A09890", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D1E0", Offset = "0x4E9BDE0", VA = "0x184E9D1E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D5E0", Offset = "0x4E9C1E0", VA = "0x184E9D5E0")]
	public static bool CDGFDPOPEPC(OLCDFLLEBBM ODBANBBPCIA, OLCDFLLEBBM FMNHBACBGIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8A08CD0", Offset = "0x8A078D0", VA = "0x188A08CD0")]
	public static bool IECKAGJENEB(OLCDFLLEBBM ODBANBBPCIA, OLCDFLLEBBM FMNHBACBGIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8A09940", Offset = "0x8A08540", VA = "0x188A09940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct KLCDEDJLAJO : IEquatable<KLCDEDJLAJO>, IComparable<KLCDEDJLAJO>, CIMNPCOKFON
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly KLCDEDJLAJO LNCBONNLALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid FHNOHJCOOKK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x14354C0", Offset = "0x14340C0", VA = "0x1814354C0")]
	public KLCDEDJLAJO(Guid FHNOHJCOOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
	public Guid OECFNIJJKJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D5E0", Offset = "0x4E9C1E0", VA = "0x184E9D5E0", Slot = "4")]
	public bool Equals(KLCDEDJLAJO IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CF70", Offset = "0x4E9BB70", VA = "0x184E9CF70", Slot = "5")]
	public int CompareTo(KLCDEDJLAJO IIOGPDPGOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8A094B0", Offset = "0x8A080B0", VA = "0x188A094B0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D1E0", Offset = "0x4E9BDE0", VA = "0x184E9D1E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D5E0", Offset = "0x4E9C1E0", VA = "0x184E9D5E0")]
	public static bool CDGFDPOPEPC(KLCDEDJLAJO ODBANBBPCIA, KLCDEDJLAJO FMNHBACBGIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8A08CD0", Offset = "0x8A078D0", VA = "0x188A08CD0")]
	public static bool IECKAGJENEB(KLCDEDJLAJO ODBANBBPCIA, KLCDEDJLAJO FMNHBACBGIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8A09560", Offset = "0x8A08160", VA = "0x188A09560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct HJHOPKKPBNA : IEquatable<HJHOPKKPBNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? APGCKHNBKCJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NNPPJEMMDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8A084D0", Offset = "0x8A070D0", VA = "0x188A084D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int PMBJDEEKMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x54DF310", Offset = "0x54DDF10", VA = "0x1854DF310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8A08A50", Offset = "0x8A07650", VA = "0x188A08A50")]
	public HJHOPKKPBNA(string? DFHBKFEOGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8A08BA0", Offset = "0x8A077A0", VA = "0x188A08BA0")]
	public HJHOPKKPBNA(string?[] BHBMBFBOLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8A084F0", Offset = "0x8A070F0", VA = "0x188A084F0")]
	private static string?[]? DNCPIOJFOCH(string?[]? BHBMBFBOLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8A08960", Offset = "0x8A07560", VA = "0x188A08960")]
	public string IOJBAEEEONL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8A087B0", Offset = "0x8A073B0", VA = "0x188A087B0", Slot = "4")]
	public bool Equals(HJHOPKKPBNA IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8A08720", Offset = "0x8A07320", VA = "0x188A08720", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8A08880", Offset = "0x8A07480", VA = "0x188A08880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8A089C0", Offset = "0x8A075C0", VA = "0x188A089C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct AEMNJGHKJNB : IEquatable<AEMNJGHKJNB>, IComparable<AEMNJGHKJNB>, CIMNPCOKFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid FHNOHJCOOKK;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x14354C0", Offset = "0x14340C0", VA = "0x1814354C0")]
	public AEMNJGHKJNB(Guid FHNOHJCOOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
	public Guid OECFNIJJKJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D5E0", Offset = "0x4E9C1E0", VA = "0x184E9D5E0", Slot = "4")]
	public bool Equals(AEMNJGHKJNB IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CF70", Offset = "0x4E9BB70", VA = "0x184E9CF70", Slot = "5")]
	public int CompareTo(AEMNJGHKJNB IIOGPDPGOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8A080C0", Offset = "0x8A06CC0", VA = "0x188A080C0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D1E0", Offset = "0x4E9BDE0", VA = "0x184E9D1E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8A08170", Offset = "0x8A06D70", VA = "0x188A08170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KAOCIBDKDIB<TModern> : BCJAMDAFOOB<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OBFCIFLJIIH(TModern BPFHFOCIAPN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CIMNPCOKFON
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid OECFNIJJKJD();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BCJAMDAFOOB<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern NLPCDIELCCG(string BPFHFOCIAPN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NJGPDEOPNKH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KAOCIBDKDIB<IBGOJPCJDBO> FAKKDNLCMED
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	KAOCIBDKDIB<LBIEPCDDEBD> MAEBHIEACHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	KAOCIBDKDIB<KLCDEDJLAJO> CNLIHEMAECL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	KAOCIBDKDIB<GFJCEPIDMBH> EJIAJJMAHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	KAOCIBDKDIB<HKOGKMHLCPM> KAGNLCMFNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	KAOCIBDKDIB<OLCDFLLEBBM> HEEGHCGLLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KAOCIBDKDIB<ODODAOJKFLP> DCAMJBJGMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KAOCIBDKDIB<PFINHFPAAHI> BLLIFACCAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CJJEBPBNJDE
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] BGBCANBJAAC;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8A08210", Offset = "0x8A06E10", VA = "0x188A08210")]
	public static string[] JKEHHHNJNPK(string? DFHBKFEOGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8A081E0", Offset = "0x8A06DE0", VA = "0x188A081E0")]
	public static string? EICAFNNKGNF(string? BBGEAICPIAD)
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
