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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7079F20", Offset = "0x7078F20", VA = "0x187079F20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890740", Offset = "0x88F740", VA = "0x180890740")]
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
		[Cpp2IlInjected.Address(RVA = "0x890780", Offset = "0x88F780", VA = "0x180890780")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LLAJMKIJMMD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KLDBPIDHOEH(MMILDBOFIKL CPEKGDIIDKL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MMILDBOFIKL JGNOLJBBCJA(string CPEKGDIIDKL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct MMILDBOFIKL : IEquatable<MMILDBOFIKL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly AJKMIEONCMG AFLGPPEOGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly ENHFLJGMKFD BLCHPKMJBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid IJKDGBIPFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? LCKLNEIOCAL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DMPCBAPNIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x70798B0", Offset = "0x70788B0", VA = "0x1870798B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AJMMFCMNHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7079870", Offset = "0x7078870", VA = "0x187079870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7079E00", Offset = "0x7078E00", VA = "0x187079E00")]
	public MMILDBOFIKL(MMILDBOFIKL HDDFPCGIJPP, [Optional] Guid HOMBKAMBMCA, [Optional] RRColor? MKAJENPGJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7079E90", Offset = "0x7078E90", VA = "0x187079E90")]
	public MMILDBOFIKL(AJKMIEONCMG DILOBOGMJEO, ENHFLJGMKFD PEEFEELGDNF, [Optional] Guid HOMBKAMBMCA, [Optional] RRColor? MKAJENPGJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7079690", Offset = "0x7078690", VA = "0x187079690", Slot = "4")]
	public bool Equals(MMILDBOFIKL LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7079740", Offset = "0x7078740", VA = "0x187079740", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7079970", Offset = "0x7078970", VA = "0x187079970", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7079690", Offset = "0x7078690", VA = "0x187079690")]
	public static bool JEKPEIKHIPM(MMILDBOFIKL KKEPMPAJLEA, MMILDBOFIKL HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7079A00", Offset = "0x7078A00", VA = "0x187079A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct AJKMIEONCMG : IEquatable<AJKMIEONCMG>, IComparable<AJKMIEONCMG>, FOOBKOEHCJF
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly AJKMIEONCMG BHJAMJDAEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid NNFEKLKANBO;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAEE0", Offset = "0x1FC9EE0", VA = "0x181FCAEE0")]
	public AJKMIEONCMG(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60", Slot = "4")]
	public bool Equals(AJKMIEONCMG LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x57F4940", Offset = "0x57F3940", VA = "0x1857F4940", Slot = "5")]
	public int CompareTo(AJKMIEONCMG LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x70783A0", Offset = "0x70773A0", VA = "0x1870783A0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B40", Offset = "0x57F3B40", VA = "0x1857F4B40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60")]
	public static bool JEKPEIKHIPM(AJKMIEONCMG KKEPMPAJLEA, AJKMIEONCMG HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7078300", Offset = "0x7077300", VA = "0x187078300")]
	public static bool GJBEBFKCOKB(AJKMIEONCMG KKEPMPAJLEA, AJKMIEONCMG HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7078440", Offset = "0x7077440", VA = "0x187078440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct AFILLJLDDLH : IEquatable<AFILLJLDDLH>, IComparable<AFILLJLDDLH>, FOOBKOEHCJF
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly AFILLJLDDLH BHJAMJDAEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid NNFEKLKANBO;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAEE0", Offset = "0x1FC9EE0", VA = "0x181FCAEE0")]
	public AFILLJLDDLH(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60", Slot = "4")]
	public bool Equals(AFILLJLDDLH LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x57F4940", Offset = "0x57F3940", VA = "0x1857F4940", Slot = "5")]
	public int CompareTo(AFILLJLDDLH LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7078260", Offset = "0x7077260", VA = "0x187078260", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B40", Offset = "0x57F3B40", VA = "0x1857F4B40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60")]
	public static bool JEKPEIKHIPM(AFILLJLDDLH KKEPMPAJLEA, AFILLJLDDLH HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7078300", Offset = "0x7077300", VA = "0x187078300")]
	public static bool GJBEBFKCOKB(AFILLJLDDLH KKEPMPAJLEA, AFILLJLDDLH HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7078330", Offset = "0x7077330", VA = "0x187078330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct CICICDBLCFP : IEquatable<CICICDBLCFP>, IComparable<CICICDBLCFP>, FOOBKOEHCJF
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly CICICDBLCFP BHJAMJDAEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid NNFEKLKANBO;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAEE0", Offset = "0x1FC9EE0", VA = "0x181FCAEE0")]
	public CICICDBLCFP(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60", Slot = "4")]
	public bool Equals(CICICDBLCFP LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x57F4940", Offset = "0x57F3940", VA = "0x1857F4940", Slot = "5")]
	public int CompareTo(CICICDBLCFP LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7078D10", Offset = "0x7077D10", VA = "0x187078D10", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B40", Offset = "0x57F3B40", VA = "0x1857F4B40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60")]
	public static bool JEKPEIKHIPM(CICICDBLCFP KKEPMPAJLEA, CICICDBLCFP HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7078300", Offset = "0x7077300", VA = "0x187078300")]
	public static bool GJBEBFKCOKB(CICICDBLCFP KKEPMPAJLEA, CICICDBLCFP HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7078DB0", Offset = "0x7077DB0", VA = "0x187078DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct ENHFLJGMKFD : IEquatable<ENHFLJGMKFD>, IComparable<ENHFLJGMKFD>, FOOBKOEHCJF
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly ENHFLJGMKFD BHJAMJDAEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid NNFEKLKANBO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GMFEDAGMJBK GPKAHCNDAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8D74E0", Offset = "0x8D64E0", VA = "0x1808D74E0")]
		[CompilerGenerated]
		get
		{
			return default(GMFEDAGMJBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GMFEDAGMJBK GAJJMMIIKCP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D74F0", Offset = "0x8D64F0", VA = "0x1808D74F0")]
		[CompilerGenerated]
		get
		{
			return default(GMFEDAGMJBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GMFEDAGMJBK DAOOPIJNJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8EB9A0", Offset = "0x8EA9A0", VA = "0x1808EB9A0")]
		[CompilerGenerated]
		get
		{
			return default(GMFEDAGMJBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x70793E0", Offset = "0x70783E0", VA = "0x1870793E0")]
	public ENHFLJGMKFD(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7079420", Offset = "0x7078420", VA = "0x187079420")]
	public ENHFLJGMKFD(GMFEDAGMJBK ACAIEMCDFOJ, GMFEDAGMJBK BCPKELCEELP, GMFEDAGMJBK DJJKCHAFPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x70790A0", Offset = "0x70780A0", VA = "0x1870790A0")]
	private Guid CJLENEKJHFJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70792C0", Offset = "0x70782C0", VA = "0x1870792C0", Slot = "4")]
	public bool Equals(ENHFLJGMKFD LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7079210", Offset = "0x7078210", VA = "0x187079210", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B40", Offset = "0x57F3B40", VA = "0x1857F4B40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7079330", Offset = "0x7078330", VA = "0x187079330")]
	public static bool JEKPEIKHIPM(ENHFLJGMKFD KKEPMPAJLEA, ENHFLJGMKFD HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x70792F0", Offset = "0x70782F0", VA = "0x1870792F0")]
	public static bool GJBEBFKCOKB(ENHFLJGMKFD KKEPMPAJLEA, ENHFLJGMKFD HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x70791D0", Offset = "0x70781D0", VA = "0x1870791D0", Slot = "5")]
	public int CompareTo(ENHFLJGMKFD LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7079370", Offset = "0x7078370", VA = "0x187079370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct ODHNKDBIOEC : IEquatable<ODHNKDBIOEC>, IComparable<ODHNKDBIOEC>, FOOBKOEHCJF
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly ODHNKDBIOEC BHJAMJDAEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid NNFEKLKANBO;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAEE0", Offset = "0x1FC9EE0", VA = "0x181FCAEE0")]
	public ODHNKDBIOEC(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60", Slot = "4")]
	public bool Equals(ODHNKDBIOEC LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x57F4940", Offset = "0x57F3940", VA = "0x1857F4940", Slot = "5")]
	public int CompareTo(ODHNKDBIOEC LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7079FA0", Offset = "0x7078FA0", VA = "0x187079FA0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B40", Offset = "0x57F3B40", VA = "0x1857F4B40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60")]
	public static bool JEKPEIKHIPM(ODHNKDBIOEC KKEPMPAJLEA, ODHNKDBIOEC HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7078300", Offset = "0x7077300", VA = "0x187078300")]
	public static bool GJBEBFKCOKB(ODHNKDBIOEC KKEPMPAJLEA, ODHNKDBIOEC HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x707A040", Offset = "0x7079040", VA = "0x18707A040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct DONNKKJBKEB : IEquatable<DONNKKJBKEB>, IComparable<DONNKKJBKEB>, FOOBKOEHCJF
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly DONNKKJBKEB BHJAMJDAEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid NNFEKLKANBO;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAEE0", Offset = "0x1FC9EE0", VA = "0x181FCAEE0")]
	public DONNKKJBKEB(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60", Slot = "4")]
	public bool Equals(DONNKKJBKEB LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x57F4940", Offset = "0x57F3940", VA = "0x1857F4940", Slot = "5")]
	public int CompareTo(DONNKKJBKEB LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7078F90", Offset = "0x7077F90", VA = "0x187078F90", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B40", Offset = "0x57F3B40", VA = "0x1857F4B40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60")]
	public static bool JEKPEIKHIPM(DONNKKJBKEB KKEPMPAJLEA, DONNKKJBKEB HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7078300", Offset = "0x7077300", VA = "0x187078300")]
	public static bool GJBEBFKCOKB(DONNKKJBKEB KKEPMPAJLEA, DONNKKJBKEB HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7079030", Offset = "0x7078030", VA = "0x187079030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct FJODIMOLBCE : IEquatable<FJODIMOLBCE>, IComparable<FJODIMOLBCE>, FOOBKOEHCJF
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly FJODIMOLBCE BHJAMJDAEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid NNFEKLKANBO;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAEE0", Offset = "0x1FC9EE0", VA = "0x181FCAEE0")]
	public FJODIMOLBCE(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60", Slot = "4")]
	public bool Equals(FJODIMOLBCE LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x57F4940", Offset = "0x57F3940", VA = "0x1857F4940", Slot = "5")]
	public int CompareTo(FJODIMOLBCE LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7079470", Offset = "0x7078470", VA = "0x187079470", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B40", Offset = "0x57F3B40", VA = "0x1857F4B40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60")]
	public static bool JEKPEIKHIPM(FJODIMOLBCE KKEPMPAJLEA, FJODIMOLBCE HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7078300", Offset = "0x7077300", VA = "0x187078300")]
	public static bool GJBEBFKCOKB(FJODIMOLBCE KKEPMPAJLEA, FJODIMOLBCE HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7079510", Offset = "0x7078510", VA = "0x187079510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct CFBACMJFMHA : IEquatable<CFBACMJFMHA>, IComparable<CFBACMJFMHA>, FOOBKOEHCJF
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly CFBACMJFMHA BHJAMJDAEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid NNFEKLKANBO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAEE0", Offset = "0x1FC9EE0", VA = "0x181FCAEE0")]
	public CFBACMJFMHA(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60", Slot = "4")]
	public bool Equals(CFBACMJFMHA LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x57F4940", Offset = "0x57F3940", VA = "0x1857F4940", Slot = "5")]
	public int CompareTo(CFBACMJFMHA LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7078C00", Offset = "0x7077C00", VA = "0x187078C00", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B40", Offset = "0x57F3B40", VA = "0x1857F4B40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60")]
	public static bool JEKPEIKHIPM(CFBACMJFMHA KKEPMPAJLEA, CFBACMJFMHA HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7078300", Offset = "0x7077300", VA = "0x187078300")]
	public static bool GJBEBFKCOKB(CFBACMJFMHA KKEPMPAJLEA, CFBACMJFMHA HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7078CA0", Offset = "0x7077CA0", VA = "0x187078CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct BHFPKMDNKBO : IEquatable<BHFPKMDNKBO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? KJNHCNMNBIH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DFLAHLKBLGO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7078510", Offset = "0x7077510", VA = "0x187078510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int MPNDIAOBIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4242420", Offset = "0x4241420", VA = "0x184242420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7078AB0", Offset = "0x7077AB0", VA = "0x187078AB0")]
	public BHFPKMDNKBO(string? GHBIHOKEAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7078A30", Offset = "0x7077A30", VA = "0x187078A30")]
	public BHFPKMDNKBO(string?[] LAFAGNIFEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7078690", Offset = "0x7077690", VA = "0x187078690")]
	private static string?[]? FFGNOOPAOMD(string?[]? LAFAGNIFEDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x70784B0", Offset = "0x70774B0", VA = "0x1870784B0")]
	public string BBJDDJHHEKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7078530", Offset = "0x7077530", VA = "0x187078530", Slot = "4")]
	public bool Equals(BHFPKMDNKBO LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7078600", Offset = "0x7077600", VA = "0x187078600", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x70788C0", Offset = "0x70778C0", VA = "0x1870788C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x70789A0", Offset = "0x70779A0", VA = "0x1870789A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct GMFEDAGMJBK : IEquatable<GMFEDAGMJBK>, IComparable<GMFEDAGMJBK>, FOOBKOEHCJF
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly GMFEDAGMJBK BHJAMJDAEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid NNFEKLKANBO;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAEE0", Offset = "0x1FC9EE0", VA = "0x181FCAEE0")]
	public GMFEDAGMJBK(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60", Slot = "4")]
	public bool Equals(GMFEDAGMJBK LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x57F4940", Offset = "0x57F3940", VA = "0x1857F4940", Slot = "5")]
	public int CompareTo(GMFEDAGMJBK LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7079580", Offset = "0x7078580", VA = "0x187079580", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B40", Offset = "0x57F3B40", VA = "0x1857F4B40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x57F4B60", Offset = "0x57F3B60", VA = "0x1857F4B60")]
	public static bool JEKPEIKHIPM(GMFEDAGMJBK KKEPMPAJLEA, GMFEDAGMJBK HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7079620", Offset = "0x7078620", VA = "0x187079620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FMGJFHCBAGJ<TModern> : CFFCIBFLELN<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GFEMGFNDKPE(TModern IKHNEOGBOCK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FOOBKOEHCJF
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid HBLPKCCEHAN();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CFFCIBFLELN<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern BNEGMKHHGGG(string IKHNEOGBOCK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LAAMNMEBFLF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	FMGJFHCBAGJ<AJKMIEONCMG> BLKNCAOAGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FMGJFHCBAGJ<ODHNKDBIOEC> NPNDJIFJHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FMGJFHCBAGJ<CFBACMJFMHA> NPJGHALFFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FMGJFHCBAGJ<ENHFLJGMKFD> JHKNBKLNIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FMGJFHCBAGJ<CICICDBLCFP> MLFIKKHFPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	FMGJFHCBAGJ<FJODIMOLBCE> PIDEBJBFLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FMGJFHCBAGJ<AFILLJLDDLH> FDFNNGLOAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	FMGJFHCBAGJ<DONNKKJBKEB> BLMKIKGJKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CNDLGAHJKCC
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly char[] PBLBMEDIKCM;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7078E50", Offset = "0x7077E50", VA = "0x187078E50")]
	public static string[] PJEPGBOIBCO(string? GHBIHOKEAIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7078E20", Offset = "0x7077E20", VA = "0x187078E20")]
	public static string? MIKJDIKNDLC(string? DILOBOGMJEO)
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
