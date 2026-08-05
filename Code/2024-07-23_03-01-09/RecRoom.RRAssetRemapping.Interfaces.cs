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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7007B70", Offset = "0x7006D70", VA = "0x187007B70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D8D0", Offset = "0x87CAD0", VA = "0x18087D8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87D910", Offset = "0x87CB10", VA = "0x18087D910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LBMGCBCDEKO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OPCGAJMHMBL(IMGBFBEHHOP PMPNIONIFNI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IMGBFBEHHOP DGBBAPGEGII(string PMPNIONIFNI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct IMGBFBEHHOP : IEquatable<IMGBFBEHHOP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly GKBBJJAJIMK GLNAFPKHPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly NPONJLDPMAN EOBJCCBDIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid HCPJAAJLFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? CBMFPIONHDJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DOOIFCMECHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7007030", Offset = "0x7006230", VA = "0x187007030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LBAKMLFNDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7006D80", Offset = "0x7005F80", VA = "0x187006D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7007510", Offset = "0x7006710", VA = "0x187007510")]
	public IMGBFBEHHOP(IMGBFBEHHOP BFAGGECCCND, [Optional] Guid JCBCJDNHNJP, [Optional] RRColor? KIJNHGNFMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x70075A0", Offset = "0x70067A0", VA = "0x1870075A0")]
	public IMGBFBEHHOP(GKBBJJAJIMK GNJIEGBEBMO, NPONJLDPMAN LKKKMCBAECE, [Optional] Guid JCBCJDNHNJP, [Optional] RRColor? KIJNHGNFMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7006EF0", Offset = "0x70060F0", VA = "0x187006EF0", Slot = "4")]
	public bool Equals(IMGBFBEHHOP OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7006DC0", Offset = "0x7005FC0", VA = "0x187006DC0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7006FA0", Offset = "0x70061A0", VA = "0x187006FA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7006EF0", Offset = "0x70060F0", VA = "0x187006EF0")]
	public static bool KBKLEFBHIDJ(IMGBFBEHHOP IIILBPDHGHN, IMGBFBEHHOP CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x70070F0", Offset = "0x70062F0", VA = "0x1870070F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct GKBBJJAJIMK : IEquatable<GKBBJJAJIMK>, IComparable<GKBBJJAJIMK>, BJPMGPHHKII
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly GKBBJJAJIMK ENKECPBOOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid BMIGIGGJPJD;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB2B0", Offset = "0x1FCA4B0", VA = "0x181FCB2B0")]
	public GKBBJJAJIMK(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9C7800", Offset = "0x9C6A00", VA = "0x1809C7800", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40", Slot = "4")]
	public bool Equals(GKBBJJAJIMK OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4190F70", Offset = "0x4190170", VA = "0x184190F70", Slot = "5")]
	public int CompareTo(GKBBJJAJIMK OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7006510", Offset = "0x7005710", VA = "0x187006510", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4191080", Offset = "0x4190280", VA = "0x184191080", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40")]
	public static bool KBKLEFBHIDJ(GKBBJJAJIMK IIILBPDHGHN, GKBBJJAJIMK CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7005DB0", Offset = "0x7004FB0", VA = "0x187005DB0")]
	public static bool HFGDCBGDPAJ(GKBBJJAJIMK IIILBPDHGHN, GKBBJJAJIMK CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x70065C0", Offset = "0x70057C0", VA = "0x1870065C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct DBPBPDCICIF : IEquatable<DBPBPDCICIF>, IComparable<DBPBPDCICIF>, BJPMGPHHKII
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly DBPBPDCICIF ENKECPBOOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid BMIGIGGJPJD;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB2B0", Offset = "0x1FCA4B0", VA = "0x181FCB2B0")]
	public DBPBPDCICIF(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9C7800", Offset = "0x9C6A00", VA = "0x1809C7800", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40", Slot = "4")]
	public bool Equals(DBPBPDCICIF OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4190F70", Offset = "0x4190170", VA = "0x184190F70", Slot = "5")]
	public int CompareTo(DBPBPDCICIF OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x70062D0", Offset = "0x70054D0", VA = "0x1870062D0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4191080", Offset = "0x4190280", VA = "0x184191080", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40")]
	public static bool KBKLEFBHIDJ(DBPBPDCICIF IIILBPDHGHN, DBPBPDCICIF CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7005DB0", Offset = "0x7004FB0", VA = "0x187005DB0")]
	public static bool HFGDCBGDPAJ(DBPBPDCICIF IIILBPDHGHN, DBPBPDCICIF CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7006380", Offset = "0x7005580", VA = "0x187006380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct DCDLGKFIGAG : IEquatable<DCDLGKFIGAG>, IComparable<DCDLGKFIGAG>, BJPMGPHHKII
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly DCDLGKFIGAG ENKECPBOOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid BMIGIGGJPJD;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB2B0", Offset = "0x1FCA4B0", VA = "0x181FCB2B0")]
	public DCDLGKFIGAG(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9C7800", Offset = "0x9C6A00", VA = "0x1809C7800", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40", Slot = "4")]
	public bool Equals(DCDLGKFIGAG OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4190F70", Offset = "0x4190170", VA = "0x184190F70", Slot = "5")]
	public int CompareTo(DCDLGKFIGAG OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x70063F0", Offset = "0x70055F0", VA = "0x1870063F0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4191080", Offset = "0x4190280", VA = "0x184191080", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40")]
	public static bool KBKLEFBHIDJ(DCDLGKFIGAG IIILBPDHGHN, DCDLGKFIGAG CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7005DB0", Offset = "0x7004FB0", VA = "0x187005DB0")]
	public static bool HFGDCBGDPAJ(DCDLGKFIGAG IIILBPDHGHN, DCDLGKFIGAG CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x70064A0", Offset = "0x70056A0", VA = "0x1870064A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct NPONJLDPMAN : IEquatable<NPONJLDPMAN>, IComparable<NPONJLDPMAN>, BJPMGPHHKII
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly NPONJLDPMAN ENKECPBOOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid BMIGIGGJPJD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BHKKDKDFMNI NOEFAGNGLBE
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8C9BF0", Offset = "0x8C8DF0", VA = "0x1808C9BF0")]
		[CompilerGenerated]
		get
		{
			return default(BHKKDKDFMNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public BHKKDKDFMNI DHFKEPGKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8C9C00", Offset = "0x8C8E00", VA = "0x1808C9C00")]
		[CompilerGenerated]
		get
		{
			return default(BHKKDKDFMNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BHKKDKDFMNI BBKAEDKLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D8DF0", Offset = "0x8D7FF0", VA = "0x1808D8DF0")]
		[CompilerGenerated]
		get
		{
			return default(BHKKDKDFMNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9C7800", Offset = "0x9C6A00", VA = "0x1809C7800", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7007AE0", Offset = "0x7006CE0", VA = "0x187007AE0")]
	public NPONJLDPMAN(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7007B20", Offset = "0x7006D20", VA = "0x187007B20")]
	public NPONJLDPMAN(BHKKDKDFMNI EPMJIGNMFFA, BHKKDKDFMNI IIIJKMMEADG, BHKKDKDFMNI JLGMGFEIPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x70078C0", Offset = "0x7006AC0", VA = "0x1870078C0")]
	private Guid GGDKFEAJKGC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70077E0", Offset = "0x70069E0", VA = "0x1870077E0", Slot = "4")]
	public bool Equals(NPONJLDPMAN OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7007810", Offset = "0x7006A10", VA = "0x187007810", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4191080", Offset = "0x4190280", VA = "0x184191080", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7007A30", Offset = "0x7006C30", VA = "0x187007A30")]
	public static bool KBKLEFBHIDJ(NPONJLDPMAN IIILBPDHGHN, NPONJLDPMAN CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x70079F0", Offset = "0x7006BF0", VA = "0x1870079F0")]
	public static bool HFGDCBGDPAJ(NPONJLDPMAN IIILBPDHGHN, NPONJLDPMAN CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x70077A0", Offset = "0x70069A0", VA = "0x1870077A0", Slot = "5")]
	public int CompareTo(NPONJLDPMAN OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7007A70", Offset = "0x7006C70", VA = "0x187007A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct CEJFBAGMAJN : IEquatable<CEJFBAGMAJN>, IComparable<CEJFBAGMAJN>, BJPMGPHHKII
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly CEJFBAGMAJN ENKECPBOOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid BMIGIGGJPJD;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB2B0", Offset = "0x1FCA4B0", VA = "0x181FCB2B0")]
	public CEJFBAGMAJN(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x9C7800", Offset = "0x9C6A00", VA = "0x1809C7800", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40", Slot = "4")]
	public bool Equals(CEJFBAGMAJN OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4190F70", Offset = "0x4190170", VA = "0x184190F70", Slot = "5")]
	public int CompareTo(CEJFBAGMAJN OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7006090", Offset = "0x7005290", VA = "0x187006090", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4191080", Offset = "0x4190280", VA = "0x184191080", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40")]
	public static bool KBKLEFBHIDJ(CEJFBAGMAJN IIILBPDHGHN, CEJFBAGMAJN CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7005DB0", Offset = "0x7004FB0", VA = "0x187005DB0")]
	public static bool HFGDCBGDPAJ(CEJFBAGMAJN IIILBPDHGHN, CEJFBAGMAJN CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7006140", Offset = "0x7005340", VA = "0x187006140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct CIJBFEOBFPG : IEquatable<CIJBFEOBFPG>, IComparable<CIJBFEOBFPG>, BJPMGPHHKII
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly CIJBFEOBFPG ENKECPBOOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid BMIGIGGJPJD;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB2B0", Offset = "0x1FCA4B0", VA = "0x181FCB2B0")]
	public CIJBFEOBFPG(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9C7800", Offset = "0x9C6A00", VA = "0x1809C7800", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40", Slot = "4")]
	public bool Equals(CIJBFEOBFPG OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4190F70", Offset = "0x4190170", VA = "0x184190F70", Slot = "5")]
	public int CompareTo(CIJBFEOBFPG OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x70061B0", Offset = "0x70053B0", VA = "0x1870061B0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4191080", Offset = "0x4190280", VA = "0x184191080", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40")]
	public static bool KBKLEFBHIDJ(CIJBFEOBFPG IIILBPDHGHN, CIJBFEOBFPG CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7005DB0", Offset = "0x7004FB0", VA = "0x187005DB0")]
	public static bool HFGDCBGDPAJ(CIJBFEOBFPG IIILBPDHGHN, CIJBFEOBFPG CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7006260", Offset = "0x7005460", VA = "0x187006260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct ALAHOFBJMPD : IEquatable<ALAHOFBJMPD>, IComparable<ALAHOFBJMPD>, BJPMGPHHKII
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly ALAHOFBJMPD ENKECPBOOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid BMIGIGGJPJD;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB2B0", Offset = "0x1FCA4B0", VA = "0x181FCB2B0")]
	public ALAHOFBJMPD(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9C7800", Offset = "0x9C6A00", VA = "0x1809C7800", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40", Slot = "4")]
	public bool Equals(ALAHOFBJMPD OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4190F70", Offset = "0x4190170", VA = "0x184190F70", Slot = "5")]
	public int CompareTo(ALAHOFBJMPD OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7005E50", Offset = "0x7005050", VA = "0x187005E50", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4191080", Offset = "0x4190280", VA = "0x184191080", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40")]
	public static bool KBKLEFBHIDJ(ALAHOFBJMPD IIILBPDHGHN, ALAHOFBJMPD CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7005DB0", Offset = "0x7004FB0", VA = "0x187005DB0")]
	public static bool HFGDCBGDPAJ(ALAHOFBJMPD IIILBPDHGHN, ALAHOFBJMPD CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7005F00", Offset = "0x7005100", VA = "0x187005F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct AEIBCMBNBKO : IEquatable<AEIBCMBNBKO>, IComparable<AEIBCMBNBKO>, BJPMGPHHKII
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly AEIBCMBNBKO ENKECPBOOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid BMIGIGGJPJD;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB2B0", Offset = "0x1FCA4B0", VA = "0x181FCB2B0")]
	public AEIBCMBNBKO(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9C7800", Offset = "0x9C6A00", VA = "0x1809C7800", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40", Slot = "4")]
	public bool Equals(AEIBCMBNBKO OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4190F70", Offset = "0x4190170", VA = "0x184190F70", Slot = "5")]
	public int CompareTo(AEIBCMBNBKO OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7005D00", Offset = "0x7004F00", VA = "0x187005D00", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4191080", Offset = "0x4190280", VA = "0x184191080", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40")]
	public static bool KBKLEFBHIDJ(AEIBCMBNBKO IIILBPDHGHN, AEIBCMBNBKO CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7005DB0", Offset = "0x7004FB0", VA = "0x187005DB0")]
	public static bool HFGDCBGDPAJ(AEIBCMBNBKO IIILBPDHGHN, AEIBCMBNBKO CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7005DE0", Offset = "0x7004FE0", VA = "0x187005DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct IKDKKLKECDH : IEquatable<IKDKKLKECDH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? GMKFEPAFPDL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CFHDDGLKNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x70068C0", Offset = "0x7005AC0", VA = "0x1870068C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int BPMCHNGAGMA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4033700", Offset = "0x4032900", VA = "0x184033700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7006C30", Offset = "0x7005E30", VA = "0x187006C30")]
	public IKDKKLKECDH(string? KBDOPECCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7006BB0", Offset = "0x7005DB0", VA = "0x187006BB0")]
	public IKDKKLKECDH(string?[] PLPGKJGOCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7006630", Offset = "0x7005830", VA = "0x187006630")]
	private static string?[]? BDOHJGOIAML(string?[]? PLPGKJGOCNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7006860", Offset = "0x7005A60", VA = "0x187006860")]
	public string BPLFIHAKAIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7006970", Offset = "0x7005B70", VA = "0x187006970", Slot = "4")]
	public bool Equals(IKDKKLKECDH OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x70068E0", Offset = "0x7005AE0", VA = "0x1870068E0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7006A40", Offset = "0x7005C40", VA = "0x187006A40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7006B20", Offset = "0x7005D20", VA = "0x187006B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct BHKKDKDFMNI : IEquatable<BHKKDKDFMNI>, IComparable<BHKKDKDFMNI>, BJPMGPHHKII
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly BHKKDKDFMNI ENKECPBOOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid BMIGIGGJPJD;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB2B0", Offset = "0x1FCA4B0", VA = "0x181FCB2B0")]
	public BHKKDKDFMNI(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9C7800", Offset = "0x9C6A00", VA = "0x1809C7800", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40", Slot = "4")]
	public bool Equals(BHKKDKDFMNI OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4190F70", Offset = "0x4190170", VA = "0x184190F70", Slot = "5")]
	public int CompareTo(BHKKDKDFMNI OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7005F70", Offset = "0x7005170", VA = "0x187005F70", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4191080", Offset = "0x4190280", VA = "0x184191080", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190140", VA = "0x184190F40")]
	public static bool KBKLEFBHIDJ(BHKKDKDFMNI IIILBPDHGHN, BHKKDKDFMNI CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7006020", Offset = "0x7005220", VA = "0x187006020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CPGGOMBPPFO<TModern> : LHKMKPLLJMO<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AEAPHNGIIDE(TModern KEHDGPEAKOM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BJPMGPHHKII
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid LILEECPKJLL();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LHKMKPLLJMO<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern NFEMNANDEJN(string KEHDGPEAKOM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CJIPKNKAEMB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	CPGGOMBPPFO<GKBBJJAJIMK> FEIANBKAJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	CPGGOMBPPFO<CEJFBAGMAJN> KIBMFKIJINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	CPGGOMBPPFO<AEIBCMBNBKO> INNPKHNGKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	CPGGOMBPPFO<NPONJLDPMAN> DKBACOBHIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CPGGOMBPPFO<DCDLGKFIGAG> DCKOOCNEPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	CPGGOMBPPFO<ALAHOFBJMPD> LPJNPIIBNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	CPGGOMBPPFO<DBPBPDCICIF> BEFGMFBLJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	CPGGOMBPPFO<CIJBFEOBFPG> ACCJDKKIKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NEHIDOGIMDO
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly char[] GGLMABMLPJL;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7007630", Offset = "0x7006830", VA = "0x187007630")]
	public static string[] FNOPLLMIECM(string? KBDOPECCEJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x70076D0", Offset = "0x70068D0", VA = "0x1870076D0")]
	public static string? JEBHLLGBPIO(string? GNJIEGBEBMO)
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
