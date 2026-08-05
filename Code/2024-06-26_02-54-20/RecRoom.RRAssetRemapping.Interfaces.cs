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
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7044F10", Offset = "0x7043510", VA = "0x187044F10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88D740", Offset = "0x88BD40", VA = "0x18088D740")]
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
		[Cpp2IlInjected.Address(RVA = "0x88D780", Offset = "0x88BD80", VA = "0x18088D780")]
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
		[Cpp2IlInjected.Address(RVA = "0x70448A0", Offset = "0x7042EA0", VA = "0x1870448A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AJMMFCMNHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7044860", Offset = "0x7042E60", VA = "0x187044860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7044DF0", Offset = "0x70433F0", VA = "0x187044DF0")]
	public MMILDBOFIKL(MMILDBOFIKL HDDFPCGIJPP, [Optional] Guid HOMBKAMBMCA, [Optional] RRColor? MKAJENPGJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7044E80", Offset = "0x7043480", VA = "0x187044E80")]
	public MMILDBOFIKL(AJKMIEONCMG DILOBOGMJEO, ENHFLJGMKFD PEEFEELGDNF, [Optional] Guid HOMBKAMBMCA, [Optional] RRColor? MKAJENPGJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7044680", Offset = "0x7042C80", VA = "0x187044680", Slot = "4")]
	public bool Equals(MMILDBOFIKL LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7044730", Offset = "0x7042D30", VA = "0x187044730", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7044960", Offset = "0x7042F60", VA = "0x187044960", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7044680", Offset = "0x7042C80", VA = "0x187044680")]
	public static bool JEKPEIKHIPM(MMILDBOFIKL KKEPMPAJLEA, MMILDBOFIKL HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x70449F0", Offset = "0x7042FF0", VA = "0x1870449F0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FBD500", Offset = "0x1FBBB00", VA = "0x181FBD500")]
	public AJKMIEONCMG(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0", Slot = "4")]
	public bool Equals(AJKMIEONCMG LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x57CB090", Offset = "0x57C9690", VA = "0x1857CB090", Slot = "5")]
	public int CompareTo(AJKMIEONCMG LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7043420", Offset = "0x7041A20", VA = "0x187043420", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x57CB290", Offset = "0x57C9890", VA = "0x1857CB290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0")]
	public static bool JEKPEIKHIPM(AJKMIEONCMG KKEPMPAJLEA, AJKMIEONCMG HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7043380", Offset = "0x7041980", VA = "0x187043380")]
	public static bool GJBEBFKCOKB(AJKMIEONCMG KKEPMPAJLEA, AJKMIEONCMG HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x70434C0", Offset = "0x7041AC0", VA = "0x1870434C0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FBD500", Offset = "0x1FBBB00", VA = "0x181FBD500")]
	public AFILLJLDDLH(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0", Slot = "4")]
	public bool Equals(AFILLJLDDLH LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x57CB090", Offset = "0x57C9690", VA = "0x1857CB090", Slot = "5")]
	public int CompareTo(AFILLJLDDLH LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x70432E0", Offset = "0x70418E0", VA = "0x1870432E0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x57CB290", Offset = "0x57C9890", VA = "0x1857CB290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0")]
	public static bool JEKPEIKHIPM(AFILLJLDDLH KKEPMPAJLEA, AFILLJLDDLH HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7043380", Offset = "0x7041980", VA = "0x187043380")]
	public static bool GJBEBFKCOKB(AFILLJLDDLH KKEPMPAJLEA, AFILLJLDDLH HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x70433B0", Offset = "0x70419B0", VA = "0x1870433B0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FBD500", Offset = "0x1FBBB00", VA = "0x181FBD500")]
	public CICICDBLCFP(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0", Slot = "4")]
	public bool Equals(CICICDBLCFP LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x57CB090", Offset = "0x57C9690", VA = "0x1857CB090", Slot = "5")]
	public int CompareTo(CICICDBLCFP LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7043D80", Offset = "0x7042380", VA = "0x187043D80", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x57CB290", Offset = "0x57C9890", VA = "0x1857CB290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0")]
	public static bool JEKPEIKHIPM(CICICDBLCFP KKEPMPAJLEA, CICICDBLCFP HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7043380", Offset = "0x7041980", VA = "0x187043380")]
	public static bool GJBEBFKCOKB(CICICDBLCFP KKEPMPAJLEA, CICICDBLCFP HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7043E20", Offset = "0x7042420", VA = "0x187043E20", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4790", Offset = "0x8D2D90", VA = "0x1808D4790")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D47A0", Offset = "0x8D2DA0", VA = "0x1808D47A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E8B80", Offset = "0x8E7180", VA = "0x1808E8B80")]
		[CompilerGenerated]
		get
		{
			return default(GMFEDAGMJBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x70443D0", Offset = "0x70429D0", VA = "0x1870443D0")]
	public ENHFLJGMKFD(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7044410", Offset = "0x7042A10", VA = "0x187044410")]
	public ENHFLJGMKFD(GMFEDAGMJBK ACAIEMCDFOJ, GMFEDAGMJBK BCPKELCEELP, GMFEDAGMJBK DJJKCHAFPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7044090", Offset = "0x7042690", VA = "0x187044090")]
	private Guid CJLENEKJHFJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70442B0", Offset = "0x70428B0", VA = "0x1870442B0", Slot = "4")]
	public bool Equals(ENHFLJGMKFD LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7044200", Offset = "0x7042800", VA = "0x187044200", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x57CB290", Offset = "0x57C9890", VA = "0x1857CB290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7044320", Offset = "0x7042920", VA = "0x187044320")]
	public static bool JEKPEIKHIPM(ENHFLJGMKFD KKEPMPAJLEA, ENHFLJGMKFD HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x70442E0", Offset = "0x70428E0", VA = "0x1870442E0")]
	public static bool GJBEBFKCOKB(ENHFLJGMKFD KKEPMPAJLEA, ENHFLJGMKFD HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x70441C0", Offset = "0x70427C0", VA = "0x1870441C0", Slot = "5")]
	public int CompareTo(ENHFLJGMKFD LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7044360", Offset = "0x7042960", VA = "0x187044360", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FBD500", Offset = "0x1FBBB00", VA = "0x181FBD500")]
	public ODHNKDBIOEC(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0", Slot = "4")]
	public bool Equals(ODHNKDBIOEC LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x57CB090", Offset = "0x57C9690", VA = "0x1857CB090", Slot = "5")]
	public int CompareTo(ODHNKDBIOEC LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7044F90", Offset = "0x7043590", VA = "0x187044F90", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x57CB290", Offset = "0x57C9890", VA = "0x1857CB290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0")]
	public static bool JEKPEIKHIPM(ODHNKDBIOEC KKEPMPAJLEA, ODHNKDBIOEC HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7043380", Offset = "0x7041980", VA = "0x187043380")]
	public static bool GJBEBFKCOKB(ODHNKDBIOEC KKEPMPAJLEA, ODHNKDBIOEC HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7045030", Offset = "0x7043630", VA = "0x187045030", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FBD500", Offset = "0x1FBBB00", VA = "0x181FBD500")]
	public DONNKKJBKEB(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0", Slot = "4")]
	public bool Equals(DONNKKJBKEB LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x57CB090", Offset = "0x57C9690", VA = "0x1857CB090", Slot = "5")]
	public int CompareTo(DONNKKJBKEB LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7043F80", Offset = "0x7042580", VA = "0x187043F80", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x57CB290", Offset = "0x57C9890", VA = "0x1857CB290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0")]
	public static bool JEKPEIKHIPM(DONNKKJBKEB KKEPMPAJLEA, DONNKKJBKEB HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7043380", Offset = "0x7041980", VA = "0x187043380")]
	public static bool GJBEBFKCOKB(DONNKKJBKEB KKEPMPAJLEA, DONNKKJBKEB HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7044020", Offset = "0x7042620", VA = "0x187044020", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FBD500", Offset = "0x1FBBB00", VA = "0x181FBD500")]
	public FJODIMOLBCE(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0", Slot = "4")]
	public bool Equals(FJODIMOLBCE LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x57CB090", Offset = "0x57C9690", VA = "0x1857CB090", Slot = "5")]
	public int CompareTo(FJODIMOLBCE LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7044460", Offset = "0x7042A60", VA = "0x187044460", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x57CB290", Offset = "0x57C9890", VA = "0x1857CB290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0")]
	public static bool JEKPEIKHIPM(FJODIMOLBCE KKEPMPAJLEA, FJODIMOLBCE HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7043380", Offset = "0x7041980", VA = "0x187043380")]
	public static bool GJBEBFKCOKB(FJODIMOLBCE KKEPMPAJLEA, FJODIMOLBCE HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7044500", Offset = "0x7042B00", VA = "0x187044500", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FBD500", Offset = "0x1FBBB00", VA = "0x181FBD500")]
	public CFBACMJFMHA(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0", Slot = "4")]
	public bool Equals(CFBACMJFMHA LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x57CB090", Offset = "0x57C9690", VA = "0x1857CB090", Slot = "5")]
	public int CompareTo(CFBACMJFMHA LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7043C70", Offset = "0x7042270", VA = "0x187043C70", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x57CB290", Offset = "0x57C9890", VA = "0x1857CB290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0")]
	public static bool JEKPEIKHIPM(CFBACMJFMHA KKEPMPAJLEA, CFBACMJFMHA HIEMMBKCCDL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7043380", Offset = "0x7041980", VA = "0x187043380")]
	public static bool GJBEBFKCOKB(CFBACMJFMHA KKEPMPAJLEA, CFBACMJFMHA HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7043D10", Offset = "0x7042310", VA = "0x187043D10", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x7043590", Offset = "0x7041B90", VA = "0x187043590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int MPNDIAOBIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x42292F0", Offset = "0x42278F0", VA = "0x1842292F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7043B30", Offset = "0x7042130", VA = "0x187043B30")]
	public BHFPKMDNKBO(string? GHBIHOKEAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7043AB0", Offset = "0x70420B0", VA = "0x187043AB0")]
	public BHFPKMDNKBO(string?[] LAFAGNIFEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7043710", Offset = "0x7041D10", VA = "0x187043710")]
	private static string?[]? FFGNOOPAOMD(string?[]? LAFAGNIFEDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7043530", Offset = "0x7041B30", VA = "0x187043530")]
	public string BBJDDJHHEKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x70435B0", Offset = "0x7041BB0", VA = "0x1870435B0", Slot = "4")]
	public bool Equals(BHFPKMDNKBO LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7043680", Offset = "0x7041C80", VA = "0x187043680", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7043940", Offset = "0x7041F40", VA = "0x187043940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7043A20", Offset = "0x7042020", VA = "0x187043A20", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FBD500", Offset = "0x1FBBB00", VA = "0x181FBD500")]
	public GMFEDAGMJBK(Guid NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
	public Guid HBLPKCCEHAN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0", Slot = "4")]
	public bool Equals(GMFEDAGMJBK LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x57CB090", Offset = "0x57C9690", VA = "0x1857CB090", Slot = "5")]
	public int CompareTo(GMFEDAGMJBK LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7044570", Offset = "0x7042B70", VA = "0x187044570", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x57CB290", Offset = "0x57C9890", VA = "0x1857CB290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x57CB2B0", Offset = "0x57C98B0", VA = "0x1857CB2B0")]
	public static bool JEKPEIKHIPM(GMFEDAGMJBK KKEPMPAJLEA, GMFEDAGMJBK HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7044610", Offset = "0x7042C10", VA = "0x187044610", Slot = "3")]
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
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7043EC0", Offset = "0x70424C0", VA = "0x187043EC0")]
	public static string[] PJEPGBOIBCO(string? GHBIHOKEAIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7043E90", Offset = "0x7042490", VA = "0x187043E90")]
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
