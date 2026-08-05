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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FE8310", Offset = "0x6FE6B10", VA = "0x186FE8310")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C1C0", VA = "0x18087D9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C200", VA = "0x18087DA00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FE77D0", Offset = "0x6FE5FD0", VA = "0x186FE77D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LBAKMLFNDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7520", Offset = "0x6FE5D20", VA = "0x186FE7520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7CB0", Offset = "0x6FE64B0", VA = "0x186FE7CB0")]
	public IMGBFBEHHOP(IMGBFBEHHOP BFAGGECCCND, [Optional] Guid JCBCJDNHNJP, [Optional] RRColor? KIJNHGNFMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7D40", Offset = "0x6FE6540", VA = "0x186FE7D40")]
	public IMGBFBEHHOP(GKBBJJAJIMK GNJIEGBEBMO, NPONJLDPMAN LKKKMCBAECE, [Optional] Guid JCBCJDNHNJP, [Optional] RRColor? KIJNHGNFMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7690", Offset = "0x6FE5E90", VA = "0x186FE7690", Slot = "4")]
	public bool Equals(IMGBFBEHHOP OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7560", Offset = "0x6FE5D60", VA = "0x186FE7560", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7740", Offset = "0x6FE5F40", VA = "0x186FE7740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7690", Offset = "0x6FE5E90", VA = "0x186FE7690")]
	public static bool KBKLEFBHIDJ(IMGBFBEHHOP IIILBPDHGHN, IMGBFBEHHOP CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7890", Offset = "0x6FE6090", VA = "0x186FE7890", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBEAF0", VA = "0x181FC02F0")]
	public GKBBJJAJIMK(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5250", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660", Slot = "4")]
	public bool Equals(GKBBJJAJIMK OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x417B690", Offset = "0x4179E90", VA = "0x18417B690", Slot = "5")]
	public int CompareTo(GKBBJJAJIMK OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6CB0", Offset = "0x6FE54B0", VA = "0x186FE6CB0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x417B7A0", Offset = "0x4179FA0", VA = "0x18417B7A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660")]
	public static bool KBKLEFBHIDJ(GKBBJJAJIMK IIILBPDHGHN, GKBBJJAJIMK CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6550", Offset = "0x6FE4D50", VA = "0x186FE6550")]
	public static bool HFGDCBGDPAJ(GKBBJJAJIMK IIILBPDHGHN, GKBBJJAJIMK CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6D60", Offset = "0x6FE5560", VA = "0x186FE6D60", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBEAF0", VA = "0x181FC02F0")]
	public DBPBPDCICIF(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5250", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660", Slot = "4")]
	public bool Equals(DBPBPDCICIF OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x417B690", Offset = "0x4179E90", VA = "0x18417B690", Slot = "5")]
	public int CompareTo(DBPBPDCICIF OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6A70", Offset = "0x6FE5270", VA = "0x186FE6A70", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x417B7A0", Offset = "0x4179FA0", VA = "0x18417B7A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660")]
	public static bool KBKLEFBHIDJ(DBPBPDCICIF IIILBPDHGHN, DBPBPDCICIF CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6550", Offset = "0x6FE4D50", VA = "0x186FE6550")]
	public static bool HFGDCBGDPAJ(DBPBPDCICIF IIILBPDHGHN, DBPBPDCICIF CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6B20", Offset = "0x6FE5320", VA = "0x186FE6B20", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBEAF0", VA = "0x181FC02F0")]
	public DCDLGKFIGAG(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5250", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660", Slot = "4")]
	public bool Equals(DCDLGKFIGAG OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x417B690", Offset = "0x4179E90", VA = "0x18417B690", Slot = "5")]
	public int CompareTo(DCDLGKFIGAG OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6B90", Offset = "0x6FE5390", VA = "0x186FE6B90", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x417B7A0", Offset = "0x4179FA0", VA = "0x18417B7A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660")]
	public static bool KBKLEFBHIDJ(DCDLGKFIGAG IIILBPDHGHN, DCDLGKFIGAG CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6550", Offset = "0x6FE4D50", VA = "0x186FE6550")]
	public static bool HFGDCBGDPAJ(DCDLGKFIGAG IIILBPDHGHN, DCDLGKFIGAG CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6C40", Offset = "0x6FE5440", VA = "0x186FE6C40", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C9DB0", Offset = "0x8C85B0", VA = "0x1808C9DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C9DC0", Offset = "0x8C85C0", VA = "0x1808C9DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D8AA0", Offset = "0x8D72A0", VA = "0x1808D8AA0")]
		[CompilerGenerated]
		get
		{
			return default(BHKKDKDFMNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5250", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8280", Offset = "0x6FE6A80", VA = "0x186FE8280")]
	public NPONJLDPMAN(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6FE82C0", Offset = "0x6FE6AC0", VA = "0x186FE82C0")]
	public NPONJLDPMAN(BHKKDKDFMNI EPMJIGNMFFA, BHKKDKDFMNI IIIJKMMEADG, BHKKDKDFMNI JLGMGFEIPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8060", Offset = "0x6FE6860", VA = "0x186FE8060")]
	private Guid GGDKFEAJKGC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7F80", Offset = "0x6FE6780", VA = "0x186FE7F80", Slot = "4")]
	public bool Equals(NPONJLDPMAN OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7FB0", Offset = "0x6FE67B0", VA = "0x186FE7FB0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x417B7A0", Offset = "0x4179FA0", VA = "0x18417B7A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6FE81D0", Offset = "0x6FE69D0", VA = "0x186FE81D0")]
	public static bool KBKLEFBHIDJ(NPONJLDPMAN IIILBPDHGHN, NPONJLDPMAN CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8190", Offset = "0x6FE6990", VA = "0x186FE8190")]
	public static bool HFGDCBGDPAJ(NPONJLDPMAN IIILBPDHGHN, NPONJLDPMAN CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7F40", Offset = "0x6FE6740", VA = "0x186FE7F40", Slot = "5")]
	public int CompareTo(NPONJLDPMAN OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8210", Offset = "0x6FE6A10", VA = "0x186FE8210", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBEAF0", VA = "0x181FC02F0")]
	public CEJFBAGMAJN(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5250", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660", Slot = "4")]
	public bool Equals(CEJFBAGMAJN OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x417B690", Offset = "0x4179E90", VA = "0x18417B690", Slot = "5")]
	public int CompareTo(CEJFBAGMAJN OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6830", Offset = "0x6FE5030", VA = "0x186FE6830", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x417B7A0", Offset = "0x4179FA0", VA = "0x18417B7A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660")]
	public static bool KBKLEFBHIDJ(CEJFBAGMAJN IIILBPDHGHN, CEJFBAGMAJN CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6550", Offset = "0x6FE4D50", VA = "0x186FE6550")]
	public static bool HFGDCBGDPAJ(CEJFBAGMAJN IIILBPDHGHN, CEJFBAGMAJN CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FE68E0", Offset = "0x6FE50E0", VA = "0x186FE68E0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBEAF0", VA = "0x181FC02F0")]
	public CIJBFEOBFPG(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5250", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660", Slot = "4")]
	public bool Equals(CIJBFEOBFPG OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x417B690", Offset = "0x4179E90", VA = "0x18417B690", Slot = "5")]
	public int CompareTo(CIJBFEOBFPG OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6950", Offset = "0x6FE5150", VA = "0x186FE6950", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x417B7A0", Offset = "0x4179FA0", VA = "0x18417B7A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660")]
	public static bool KBKLEFBHIDJ(CIJBFEOBFPG IIILBPDHGHN, CIJBFEOBFPG CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6550", Offset = "0x6FE4D50", VA = "0x186FE6550")]
	public static bool HFGDCBGDPAJ(CIJBFEOBFPG IIILBPDHGHN, CIJBFEOBFPG CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6A00", Offset = "0x6FE5200", VA = "0x186FE6A00", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBEAF0", VA = "0x181FC02F0")]
	public ALAHOFBJMPD(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5250", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660", Slot = "4")]
	public bool Equals(ALAHOFBJMPD OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x417B690", Offset = "0x4179E90", VA = "0x18417B690", Slot = "5")]
	public int CompareTo(ALAHOFBJMPD OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE65F0", Offset = "0x6FE4DF0", VA = "0x186FE65F0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x417B7A0", Offset = "0x4179FA0", VA = "0x18417B7A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660")]
	public static bool KBKLEFBHIDJ(ALAHOFBJMPD IIILBPDHGHN, ALAHOFBJMPD CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6550", Offset = "0x6FE4D50", VA = "0x186FE6550")]
	public static bool HFGDCBGDPAJ(ALAHOFBJMPD IIILBPDHGHN, ALAHOFBJMPD CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6FE66A0", Offset = "0x6FE4EA0", VA = "0x186FE66A0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBEAF0", VA = "0x181FC02F0")]
	public AEIBCMBNBKO(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5250", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660", Slot = "4")]
	public bool Equals(AEIBCMBNBKO OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x417B690", Offset = "0x4179E90", VA = "0x18417B690", Slot = "5")]
	public int CompareTo(AEIBCMBNBKO OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6FE64A0", Offset = "0x6FE4CA0", VA = "0x186FE64A0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x417B7A0", Offset = "0x4179FA0", VA = "0x18417B7A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660")]
	public static bool KBKLEFBHIDJ(AEIBCMBNBKO IIILBPDHGHN, AEIBCMBNBKO CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6550", Offset = "0x6FE4D50", VA = "0x186FE6550")]
	public static bool HFGDCBGDPAJ(AEIBCMBNBKO IIILBPDHGHN, AEIBCMBNBKO CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6580", Offset = "0x6FE4D80", VA = "0x186FE6580", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FE7060", Offset = "0x6FE5860", VA = "0x186FE7060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int BPMCHNGAGMA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4026430", Offset = "0x4024C30", VA = "0x184026430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE73D0", Offset = "0x6FE5BD0", VA = "0x186FE73D0")]
	public IKDKKLKECDH(string? KBDOPECCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7350", Offset = "0x6FE5B50", VA = "0x186FE7350")]
	public IKDKKLKECDH(string?[] PLPGKJGOCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6DD0", Offset = "0x6FE55D0", VA = "0x186FE6DD0")]
	private static string?[]? BDOHJGOIAML(string?[]? PLPGKJGOCNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7000", Offset = "0x6FE5800", VA = "0x186FE7000")]
	public string BPLFIHAKAIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7110", Offset = "0x6FE5910", VA = "0x186FE7110", Slot = "4")]
	public bool Equals(IKDKKLKECDH OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7080", Offset = "0x6FE5880", VA = "0x186FE7080", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6FE71E0", Offset = "0x6FE59E0", VA = "0x186FE71E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6FE72C0", Offset = "0x6FE5AC0", VA = "0x186FE72C0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBEAF0", VA = "0x181FC02F0")]
	public BHKKDKDFMNI(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5250", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660", Slot = "4")]
	public bool Equals(BHKKDKDFMNI OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x417B690", Offset = "0x4179E90", VA = "0x18417B690", Slot = "5")]
	public int CompareTo(BHKKDKDFMNI OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6710", Offset = "0x6FE4F10", VA = "0x186FE6710", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x417B7A0", Offset = "0x4179FA0", VA = "0x18417B7A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x417B660", Offset = "0x4179E60", VA = "0x18417B660")]
	public static bool KBKLEFBHIDJ(BHKKDKDFMNI IIILBPDHGHN, BHKKDKDFMNI CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE67C0", Offset = "0x6FE4FC0", VA = "0x186FE67C0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x6FE7DD0", Offset = "0x6FE65D0", VA = "0x186FE7DD0")]
	public static string[] FNOPLLMIECM(string? KBDOPECCEJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7E70", Offset = "0x6FE6670", VA = "0x186FE7E70")]
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
