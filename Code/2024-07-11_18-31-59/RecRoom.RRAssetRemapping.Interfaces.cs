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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FE8D20", Offset = "0x6FE7720", VA = "0x186FE8D20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C3C0", VA = "0x18087D9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C400", VA = "0x18087DA00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FE81E0", Offset = "0x6FE6BE0", VA = "0x186FE81E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LBAKMLFNDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7F30", Offset = "0x6FE6930", VA = "0x186FE7F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FE86C0", Offset = "0x6FE70C0", VA = "0x186FE86C0")]
	public IMGBFBEHHOP(IMGBFBEHHOP BFAGGECCCND, [Optional] Guid JCBCJDNHNJP, [Optional] RRColor? KIJNHGNFMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8750", Offset = "0x6FE7150", VA = "0x186FE8750")]
	public IMGBFBEHHOP(GKBBJJAJIMK GNJIEGBEBMO, NPONJLDPMAN LKKKMCBAECE, [Optional] Guid JCBCJDNHNJP, [Optional] RRColor? KIJNHGNFMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE80A0", Offset = "0x6FE6AA0", VA = "0x186FE80A0", Slot = "4")]
	public bool Equals(IMGBFBEHHOP OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7F70", Offset = "0x6FE6970", VA = "0x186FE7F70", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8150", Offset = "0x6FE6B50", VA = "0x186FE8150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE80A0", Offset = "0x6FE6AA0", VA = "0x186FE80A0")]
	public static bool KBKLEFBHIDJ(IMGBFBEHHOP IIILBPDHGHN, IMGBFBEHHOP CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE82A0", Offset = "0x6FE6CA0", VA = "0x186FE82A0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBECF0", VA = "0x181FC02F0")]
	public GKBBJJAJIMK(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760", Slot = "4")]
	public bool Equals(GKBBJJAJIMK OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x417B790", Offset = "0x417A190", VA = "0x18417B790", Slot = "5")]
	public int CompareTo(GKBBJJAJIMK OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6FE76C0", Offset = "0x6FE60C0", VA = "0x186FE76C0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x417B8A0", Offset = "0x417A2A0", VA = "0x18417B8A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760")]
	public static bool KBKLEFBHIDJ(GKBBJJAJIMK IIILBPDHGHN, GKBBJJAJIMK CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6F60", Offset = "0x6FE5960", VA = "0x186FE6F60")]
	public static bool HFGDCBGDPAJ(GKBBJJAJIMK IIILBPDHGHN, GKBBJJAJIMK CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7770", Offset = "0x6FE6170", VA = "0x186FE7770", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBECF0", VA = "0x181FC02F0")]
	public DBPBPDCICIF(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760", Slot = "4")]
	public bool Equals(DBPBPDCICIF OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x417B790", Offset = "0x417A190", VA = "0x18417B790", Slot = "5")]
	public int CompareTo(DBPBPDCICIF OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7480", Offset = "0x6FE5E80", VA = "0x186FE7480", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x417B8A0", Offset = "0x417A2A0", VA = "0x18417B8A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760")]
	public static bool KBKLEFBHIDJ(DBPBPDCICIF IIILBPDHGHN, DBPBPDCICIF CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6F60", Offset = "0x6FE5960", VA = "0x186FE6F60")]
	public static bool HFGDCBGDPAJ(DBPBPDCICIF IIILBPDHGHN, DBPBPDCICIF CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7530", Offset = "0x6FE5F30", VA = "0x186FE7530", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBECF0", VA = "0x181FC02F0")]
	public DCDLGKFIGAG(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760", Slot = "4")]
	public bool Equals(DCDLGKFIGAG OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x417B790", Offset = "0x417A190", VA = "0x18417B790", Slot = "5")]
	public int CompareTo(DCDLGKFIGAG OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6FE75A0", Offset = "0x6FE5FA0", VA = "0x186FE75A0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x417B8A0", Offset = "0x417A2A0", VA = "0x18417B8A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760")]
	public static bool KBKLEFBHIDJ(DCDLGKFIGAG IIILBPDHGHN, DCDLGKFIGAG CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6F60", Offset = "0x6FE5960", VA = "0x186FE6F60")]
	public static bool HFGDCBGDPAJ(DCDLGKFIGAG IIILBPDHGHN, DCDLGKFIGAG CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7650", Offset = "0x6FE6050", VA = "0x186FE7650", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C9DB0", Offset = "0x8C87B0", VA = "0x1808C9DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C9DC0", Offset = "0x8C87C0", VA = "0x1808C9DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D8AA0", Offset = "0x8D74A0", VA = "0x1808D8AA0")]
		[CompilerGenerated]
		get
		{
			return default(BHKKDKDFMNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8C90", Offset = "0x6FE7690", VA = "0x186FE8C90")]
	public NPONJLDPMAN(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8CD0", Offset = "0x6FE76D0", VA = "0x186FE8CD0")]
	public NPONJLDPMAN(BHKKDKDFMNI EPMJIGNMFFA, BHKKDKDFMNI IIIJKMMEADG, BHKKDKDFMNI JLGMGFEIPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8A70", Offset = "0x6FE7470", VA = "0x186FE8A70")]
	private Guid GGDKFEAJKGC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8990", Offset = "0x6FE7390", VA = "0x186FE8990", Slot = "4")]
	public bool Equals(NPONJLDPMAN OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6FE89C0", Offset = "0x6FE73C0", VA = "0x186FE89C0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x417B8A0", Offset = "0x417A2A0", VA = "0x18417B8A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8BE0", Offset = "0x6FE75E0", VA = "0x186FE8BE0")]
	public static bool KBKLEFBHIDJ(NPONJLDPMAN IIILBPDHGHN, NPONJLDPMAN CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8BA0", Offset = "0x6FE75A0", VA = "0x186FE8BA0")]
	public static bool HFGDCBGDPAJ(NPONJLDPMAN IIILBPDHGHN, NPONJLDPMAN CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8950", Offset = "0x6FE7350", VA = "0x186FE8950", Slot = "5")]
	public int CompareTo(NPONJLDPMAN OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8C20", Offset = "0x6FE7620", VA = "0x186FE8C20", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBECF0", VA = "0x181FC02F0")]
	public CEJFBAGMAJN(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760", Slot = "4")]
	public bool Equals(CEJFBAGMAJN OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x417B790", Offset = "0x417A190", VA = "0x18417B790", Slot = "5")]
	public int CompareTo(CEJFBAGMAJN OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7240", Offset = "0x6FE5C40", VA = "0x186FE7240", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x417B8A0", Offset = "0x417A2A0", VA = "0x18417B8A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760")]
	public static bool KBKLEFBHIDJ(CEJFBAGMAJN IIILBPDHGHN, CEJFBAGMAJN CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6F60", Offset = "0x6FE5960", VA = "0x186FE6F60")]
	public static bool HFGDCBGDPAJ(CEJFBAGMAJN IIILBPDHGHN, CEJFBAGMAJN CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FE72F0", Offset = "0x6FE5CF0", VA = "0x186FE72F0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBECF0", VA = "0x181FC02F0")]
	public CIJBFEOBFPG(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760", Slot = "4")]
	public bool Equals(CIJBFEOBFPG OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x417B790", Offset = "0x417A190", VA = "0x18417B790", Slot = "5")]
	public int CompareTo(CIJBFEOBFPG OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7360", Offset = "0x6FE5D60", VA = "0x186FE7360", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x417B8A0", Offset = "0x417A2A0", VA = "0x18417B8A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760")]
	public static bool KBKLEFBHIDJ(CIJBFEOBFPG IIILBPDHGHN, CIJBFEOBFPG CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6F60", Offset = "0x6FE5960", VA = "0x186FE6F60")]
	public static bool HFGDCBGDPAJ(CIJBFEOBFPG IIILBPDHGHN, CIJBFEOBFPG CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7410", Offset = "0x6FE5E10", VA = "0x186FE7410", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBECF0", VA = "0x181FC02F0")]
	public ALAHOFBJMPD(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760", Slot = "4")]
	public bool Equals(ALAHOFBJMPD OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x417B790", Offset = "0x417A190", VA = "0x18417B790", Slot = "5")]
	public int CompareTo(ALAHOFBJMPD OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7000", Offset = "0x6FE5A00", VA = "0x186FE7000", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x417B8A0", Offset = "0x417A2A0", VA = "0x18417B8A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760")]
	public static bool KBKLEFBHIDJ(ALAHOFBJMPD IIILBPDHGHN, ALAHOFBJMPD CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6F60", Offset = "0x6FE5960", VA = "0x186FE6F60")]
	public static bool HFGDCBGDPAJ(ALAHOFBJMPD IIILBPDHGHN, ALAHOFBJMPD CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6FE70B0", Offset = "0x6FE5AB0", VA = "0x186FE70B0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBECF0", VA = "0x181FC02F0")]
	public AEIBCMBNBKO(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760", Slot = "4")]
	public bool Equals(AEIBCMBNBKO OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x417B790", Offset = "0x417A190", VA = "0x18417B790", Slot = "5")]
	public int CompareTo(AEIBCMBNBKO OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6EB0", Offset = "0x6FE58B0", VA = "0x186FE6EB0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x417B8A0", Offset = "0x417A2A0", VA = "0x18417B8A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760")]
	public static bool KBKLEFBHIDJ(AEIBCMBNBKO IIILBPDHGHN, AEIBCMBNBKO CLEBPGFBBGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6F60", Offset = "0x6FE5960", VA = "0x186FE6F60")]
	public static bool HFGDCBGDPAJ(AEIBCMBNBKO IIILBPDHGHN, AEIBCMBNBKO CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6F90", Offset = "0x6FE5990", VA = "0x186FE6F90", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FE7A70", Offset = "0x6FE6470", VA = "0x186FE7A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int BPMCHNGAGMA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4026530", Offset = "0x4024F30", VA = "0x184026530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7DE0", Offset = "0x6FE67E0", VA = "0x186FE7DE0")]
	public IKDKKLKECDH(string? KBDOPECCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7D60", Offset = "0x6FE6760", VA = "0x186FE7D60")]
	public IKDKKLKECDH(string?[] PLPGKJGOCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6FE77E0", Offset = "0x6FE61E0", VA = "0x186FE77E0")]
	private static string?[]? BDOHJGOIAML(string?[]? PLPGKJGOCNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7A10", Offset = "0x6FE6410", VA = "0x186FE7A10")]
	public string BPLFIHAKAIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7B20", Offset = "0x6FE6520", VA = "0x186FE7B20", Slot = "4")]
	public bool Equals(IKDKKLKECDH OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7A90", Offset = "0x6FE6490", VA = "0x186FE7A90", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7BF0", Offset = "0x6FE65F0", VA = "0x186FE7BF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7CD0", Offset = "0x6FE66D0", VA = "0x186FE7CD0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBECF0", VA = "0x181FC02F0")]
	public BHKKDKDFMNI(Guid BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
	public Guid LILEECPKJLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760", Slot = "4")]
	public bool Equals(BHKKDKDFMNI OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x417B790", Offset = "0x417A190", VA = "0x18417B790", Slot = "5")]
	public int CompareTo(BHKKDKDFMNI OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7120", Offset = "0x6FE5B20", VA = "0x186FE7120", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x417B8A0", Offset = "0x417A2A0", VA = "0x18417B8A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x417B760", Offset = "0x417A160", VA = "0x18417B760")]
	public static bool KBKLEFBHIDJ(BHKKDKDFMNI IIILBPDHGHN, BHKKDKDFMNI CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE71D0", Offset = "0x6FE5BD0", VA = "0x186FE71D0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x6FE87E0", Offset = "0x6FE71E0", VA = "0x186FE87E0")]
	public static string[] FNOPLLMIECM(string? KBDOPECCEJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8880", Offset = "0x6FE7280", VA = "0x186FE8880")]
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
