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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x84BBA00", Offset = "0x84BAA00", VA = "0x1884BBA00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NGJIPCEJOIB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DFNAEDFOBIJ(KEEOBDBOKHK HPLMFDGMJFE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KEEOBDBOKHK AKDPGDCBDMI(string HPLMFDGMJFE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct KEEOBDBOKHK : IEquatable<KEEOBDBOKHK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly PJDNIEDEHFC ILJCGCMLCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly DHMNCODBNBK FLBKJBKDDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid BJLCIJDDMDD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GAGCPCMGOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84BB280", Offset = "0x84BA280", VA = "0x1884BB280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PONPGAFPOAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84BB310", Offset = "0x84BA310", VA = "0x1884BB310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84BB680", Offset = "0x84BA680", VA = "0x1884BB680")]
	public KEEOBDBOKHK(KEEOBDBOKHK AIAHEOFLOBI, [Optional] Guid DGPIPOJOJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5C165F0", Offset = "0x5C155F0", VA = "0x185C165F0")]
	public KEEOBDBOKHK(PJDNIEDEHFC MONOBEAOLBH, DHMNCODBNBK HEDIODLPCOO, [Optional] Guid DGPIPOJOJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84BB130", Offset = "0x84BA130", VA = "0x1884BB130", Slot = "4")]
	public bool Equals(KEEOBDBOKHK MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84BB080", Offset = "0x84BA080", VA = "0x1884BB080", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x84BB1F0", Offset = "0x84BA1F0", VA = "0x1884BB1F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x84BB340", Offset = "0x84BA340", VA = "0x1884BB340")]
	public static bool MMJMCICIDNJ(KEEOBDBOKHK JOOBCOFNIAM, KEEOBDBOKHK MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x84BB370", Offset = "0x84BA370", VA = "0x1884BB370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PJDNIEDEHFC : IEquatable<PJDNIEDEHFC>, IComparable<PJDNIEDEHFC>, AKFPMLPANDI
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly PJDNIEDEHFC KKKNNENCOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid DGNNPFFMIEE;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x12010B0", Offset = "0x12000B0", VA = "0x1812010B0")]
	public PJDNIEDEHFC(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF1F0", Offset = "0x4BFE1F0", VA = "0x184BFF1F0", Slot = "4")]
	public bool Equals(PJDNIEDEHFC MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEFC0", Offset = "0x4BFDFC0", VA = "0x184BFEFC0", Slot = "5")]
	public int CompareTo(PJDNIEDEHFC MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84BBCC0", Offset = "0x84BACC0", VA = "0x1884BBCC0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF270", Offset = "0x4BFE270", VA = "0x184BFF270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF1F0", Offset = "0x4BFE1F0", VA = "0x184BFF1F0")]
	public static bool MMJMCICIDNJ(PJDNIEDEHFC JOOBCOFNIAM, PJDNIEDEHFC MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84BA3D0", Offset = "0x84B93D0", VA = "0x1884BA3D0")]
	public static bool DIKHMNDIIDO(PJDNIEDEHFC JOOBCOFNIAM, PJDNIEDEHFC MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84BBD70", Offset = "0x84BAD70", VA = "0x1884BBD70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NBBDHCNOOIC : IEquatable<NBBDHCNOOIC>, IComparable<NBBDHCNOOIC>, AKFPMLPANDI
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly NBBDHCNOOIC KKKNNENCOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid DGNNPFFMIEE;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x12010B0", Offset = "0x12000B0", VA = "0x1812010B0")]
	public NBBDHCNOOIC(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF1F0", Offset = "0x4BFE1F0", VA = "0x184BFF1F0", Slot = "4")]
	public bool Equals(NBBDHCNOOIC MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEFC0", Offset = "0x4BFDFC0", VA = "0x184BFEFC0", Slot = "5")]
	public int CompareTo(NBBDHCNOOIC MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84BB8E0", Offset = "0x84BA8E0", VA = "0x1884BB8E0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF270", Offset = "0x4BFE270", VA = "0x184BFF270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF1F0", Offset = "0x4BFE1F0", VA = "0x184BFF1F0")]
	public static bool MMJMCICIDNJ(NBBDHCNOOIC JOOBCOFNIAM, NBBDHCNOOIC MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84BA3D0", Offset = "0x84B93D0", VA = "0x1884BA3D0")]
	public static bool DIKHMNDIIDO(NBBDHCNOOIC JOOBCOFNIAM, NBBDHCNOOIC MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84BB990", Offset = "0x84BA990", VA = "0x1884BB990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct ODFBDNOADGM : IEquatable<ODFBDNOADGM>, IComparable<ODFBDNOADGM>, AKFPMLPANDI
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly ODFBDNOADGM KKKNNENCOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid DGNNPFFMIEE;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x12010B0", Offset = "0x12000B0", VA = "0x1812010B0")]
	public ODFBDNOADGM(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF1F0", Offset = "0x4BFE1F0", VA = "0x184BFF1F0", Slot = "4")]
	public bool Equals(ODFBDNOADGM MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEFC0", Offset = "0x4BFDFC0", VA = "0x184BFEFC0", Slot = "5")]
	public int CompareTo(ODFBDNOADGM MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84BBA80", Offset = "0x84BAA80", VA = "0x1884BBA80", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF270", Offset = "0x4BFE270", VA = "0x184BFF270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF1F0", Offset = "0x4BFE1F0", VA = "0x184BFF1F0")]
	public static bool MMJMCICIDNJ(ODFBDNOADGM JOOBCOFNIAM, ODFBDNOADGM MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84BA3D0", Offset = "0x84B93D0", VA = "0x1884BA3D0")]
	public static bool DIKHMNDIIDO(ODFBDNOADGM JOOBCOFNIAM, ODFBDNOADGM MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84BBB30", Offset = "0x84BAB30", VA = "0x1884BBB30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct DHMNCODBNBK : IEquatable<DHMNCODBNBK>, IComparable<DHMNCODBNBK>, AKFPMLPANDI
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly DHMNCODBNBK KKKNNENCOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid DGNNPFFMIEE;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x12010B0", Offset = "0x12000B0", VA = "0x1812010B0")]
	public DHMNCODBNBK(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x84BA550", Offset = "0x84B9550", VA = "0x1884BA550", Slot = "4")]
	public bool Equals(DHMNCODBNBK MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84BA580", Offset = "0x84B9580", VA = "0x1884BA580", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF270", Offset = "0x4BFE270", VA = "0x184BFF270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84BA550", Offset = "0x84B9550", VA = "0x1884BA550")]
	public static bool MMJMCICIDNJ(DHMNCODBNBK JOOBCOFNIAM, DHMNCODBNBK MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84BA520", Offset = "0x84B9520", VA = "0x1884BA520")]
	public static bool DIKHMNDIIDO(DHMNCODBNBK JOOBCOFNIAM, DHMNCODBNBK MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEFC0", Offset = "0x4BFDFC0", VA = "0x184BFEFC0", Slot = "5")]
	public int CompareTo(DHMNCODBNBK MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x84BA630", Offset = "0x84B9630", VA = "0x1884BA630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x12010B0", Offset = "0x12000B0", VA = "0x1812010B0")]
	public DHMNCODBNBK(PGCIDDDFGOL FCJDJNJLCGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct JCHDCCIJPPE : IEquatable<JCHDCCIJPPE>, IComparable<JCHDCCIJPPE>, AKFPMLPANDI
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly JCHDCCIJPPE KKKNNENCOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid DGNNPFFMIEE;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x12010B0", Offset = "0x12000B0", VA = "0x1812010B0")]
	public JCHDCCIJPPE(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF1F0", Offset = "0x4BFE1F0", VA = "0x184BFF1F0", Slot = "4")]
	public bool Equals(JCHDCCIJPPE MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEFC0", Offset = "0x4BFDFC0", VA = "0x184BFEFC0", Slot = "5")]
	public int CompareTo(JCHDCCIJPPE MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x84BAF60", Offset = "0x84B9F60", VA = "0x1884BAF60", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF270", Offset = "0x4BFE270", VA = "0x184BFF270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF1F0", Offset = "0x4BFE1F0", VA = "0x184BFF1F0")]
	public static bool MMJMCICIDNJ(JCHDCCIJPPE JOOBCOFNIAM, JCHDCCIJPPE MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x84BA3D0", Offset = "0x84B93D0", VA = "0x1884BA3D0")]
	public static bool DIKHMNDIIDO(JCHDCCIJPPE JOOBCOFNIAM, JCHDCCIJPPE MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84BB010", Offset = "0x84BA010", VA = "0x1884BB010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct MCAONEJPGJL : IEquatable<MCAONEJPGJL>, IComparable<MCAONEJPGJL>, AKFPMLPANDI
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly MCAONEJPGJL KKKNNENCOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid DGNNPFFMIEE;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x12010B0", Offset = "0x12000B0", VA = "0x1812010B0")]
	public MCAONEJPGJL(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF1F0", Offset = "0x4BFE1F0", VA = "0x184BFF1F0", Slot = "4")]
	public bool Equals(MCAONEJPGJL MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEFC0", Offset = "0x4BFDFC0", VA = "0x184BFEFC0", Slot = "5")]
	public int CompareTo(MCAONEJPGJL MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x84BB6A0", Offset = "0x84BA6A0", VA = "0x1884BB6A0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF270", Offset = "0x4BFE270", VA = "0x184BFF270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF1F0", Offset = "0x4BFE1F0", VA = "0x184BFF1F0")]
	public static bool MMJMCICIDNJ(MCAONEJPGJL JOOBCOFNIAM, MCAONEJPGJL MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x84BA3D0", Offset = "0x84B93D0", VA = "0x1884BA3D0")]
	public static bool DIKHMNDIIDO(MCAONEJPGJL JOOBCOFNIAM, MCAONEJPGJL MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84BB750", Offset = "0x84BA750", VA = "0x1884BB750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct CMKLJFNAGCE : IEquatable<CMKLJFNAGCE>, IComparable<CMKLJFNAGCE>, AKFPMLPANDI
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly CMKLJFNAGCE KKKNNENCOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid DGNNPFFMIEE;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x12010B0", Offset = "0x12000B0", VA = "0x1812010B0")]
	public CMKLJFNAGCE(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF1F0", Offset = "0x4BFE1F0", VA = "0x184BFF1F0", Slot = "4")]
	public bool Equals(CMKLJFNAGCE MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEFC0", Offset = "0x4BFDFC0", VA = "0x184BFEFC0", Slot = "5")]
	public int CompareTo(CMKLJFNAGCE MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x84BA400", Offset = "0x84B9400", VA = "0x1884BA400", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF270", Offset = "0x4BFE270", VA = "0x184BFF270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF1F0", Offset = "0x4BFE1F0", VA = "0x184BFF1F0")]
	public static bool MMJMCICIDNJ(CMKLJFNAGCE JOOBCOFNIAM, CMKLJFNAGCE MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x84BA3D0", Offset = "0x84B93D0", VA = "0x1884BA3D0")]
	public static bool DIKHMNDIIDO(CMKLJFNAGCE JOOBCOFNIAM, CMKLJFNAGCE MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x84BA4B0", Offset = "0x84B94B0", VA = "0x1884BA4B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct MMHDKHFCIBF : IEquatable<MMHDKHFCIBF>, IComparable<MMHDKHFCIBF>, AKFPMLPANDI
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly MMHDKHFCIBF KKKNNENCOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid DGNNPFFMIEE;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x12010B0", Offset = "0x12000B0", VA = "0x1812010B0")]
	public MMHDKHFCIBF(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF1F0", Offset = "0x4BFE1F0", VA = "0x184BFF1F0", Slot = "4")]
	public bool Equals(MMHDKHFCIBF MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEFC0", Offset = "0x4BFDFC0", VA = "0x184BFEFC0", Slot = "5")]
	public int CompareTo(MMHDKHFCIBF MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x84BB7C0", Offset = "0x84BA7C0", VA = "0x1884BB7C0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF270", Offset = "0x4BFE270", VA = "0x184BFF270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF1F0", Offset = "0x4BFE1F0", VA = "0x184BFF1F0")]
	public static bool MMJMCICIDNJ(MMHDKHFCIBF JOOBCOFNIAM, MMHDKHFCIBF MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x84BA3D0", Offset = "0x84B93D0", VA = "0x1884BA3D0")]
	public static bool DIKHMNDIIDO(MMHDKHFCIBF JOOBCOFNIAM, MMHDKHFCIBF MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x84BB870", Offset = "0x84BA870", VA = "0x1884BB870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct HDKFBPEELCJ : IEquatable<HDKFBPEELCJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? LEFGBOIFLKJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NOJJAOAIMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x84BACE0", Offset = "0x84B9CE0", VA = "0x1884BACE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int NGLKLHPOAED
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x51CA130", Offset = "0x51C9130", VA = "0x1851CA130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x84BAE10", Offset = "0x84B9E10", VA = "0x1884BAE10")]
	public HDKFBPEELCJ(string? DGGGAMPMIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84BAD90", Offset = "0x84B9D90", VA = "0x1884BAD90")]
	public HDKFBPEELCJ(string?[] HIIHIMPLCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84BA810", Offset = "0x84B9810", VA = "0x1884BA810")]
	private static string?[]? EBDDACMOIGN(string?[]? HIIHIMPLCJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x84BAC80", Offset = "0x84B9C80", VA = "0x1884BAC80")]
	public string MFABOCDKDIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84BAAD0", Offset = "0x84B9AD0", VA = "0x1884BAAD0", Slot = "4")]
	public bool Equals(HDKFBPEELCJ MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x84BAA40", Offset = "0x84B9A40", VA = "0x1884BAA40", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84BABA0", Offset = "0x84B9BA0", VA = "0x1884BABA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84BAD00", Offset = "0x84B9D00", VA = "0x1884BAD00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct PGCIDDDFGOL : IEquatable<PGCIDDDFGOL>, IComparable<PGCIDDDFGOL>, AKFPMLPANDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid DGNNPFFMIEE;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x12010B0", Offset = "0x12000B0", VA = "0x1812010B0")]
	public PGCIDDDFGOL(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF1F0", Offset = "0x4BFE1F0", VA = "0x184BFF1F0", Slot = "4")]
	public bool Equals(PGCIDDDFGOL MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEFC0", Offset = "0x4BFDFC0", VA = "0x184BFEFC0", Slot = "5")]
	public int CompareTo(PGCIDDDFGOL MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x84BBBA0", Offset = "0x84BABA0", VA = "0x1884BBBA0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF270", Offset = "0x4BFE270", VA = "0x184BFF270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x84BBC50", Offset = "0x84BAC50", VA = "0x1884BBC50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JNCCJLHKFDA<TModern> : FMFMCJMIEMN<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BIJHCFBJPFJ(TModern BGLOIEKEICN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AKFPMLPANDI
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid ALEBNNAILDG();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FMFMCJMIEMN<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern PNCGAEDBIID(string BGLOIEKEICN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface POAKPCMKJOA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	JNCCJLHKFDA<PJDNIEDEHFC> BCGHJGNPIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JNCCJLHKFDA<JCHDCCIJPPE> PDHBJOPPDED
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	JNCCJLHKFDA<MMHDKHFCIBF> NALOJAANKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JNCCJLHKFDA<DHMNCODBNBK> OJLBHIPICPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JNCCJLHKFDA<ODFBDNOADGM> LHACGMAPIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JNCCJLHKFDA<CMKLJFNAGCE> LGJALIOBDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JNCCJLHKFDA<NBBDHCNOOIC> DKPHLCHFEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JNCCJLHKFDA<MCAONEJPGJL> DCCBJCBGANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GBOJIHJJLKN
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] JBMHANAEOPF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x84BA6D0", Offset = "0x84B96D0", VA = "0x1884BA6D0")]
	public static string[] KLEHFDFKDPN(string? DGGGAMPMIAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84BA6A0", Offset = "0x84B96A0", VA = "0x1884BA6A0")]
	public static string? IDMCOADIPMF(string? MONOBEAOLBH)
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
