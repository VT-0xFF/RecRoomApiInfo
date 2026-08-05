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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84A13A0", Offset = "0x849F9A0", VA = "0x1884A13A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
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
		[Cpp2IlInjected.Address(RVA = "0x84A0C60", Offset = "0x849F260", VA = "0x1884A0C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PONPGAFPOAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84A0CF0", Offset = "0x849F2F0", VA = "0x1884A0CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84A1050", Offset = "0x849F650", VA = "0x1884A1050")]
	public KEEOBDBOKHK(KEEOBDBOKHK AIAHEOFLOBI, [Optional] Guid DGPIPOJOJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5C1D860", Offset = "0x5C1BE60", VA = "0x185C1D860")]
	public KEEOBDBOKHK(PJDNIEDEHFC MONOBEAOLBH, DHMNCODBNBK HEDIODLPCOO, [Optional] Guid DGPIPOJOJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84A0B10", Offset = "0x849F110", VA = "0x1884A0B10", Slot = "4")]
	public bool Equals(KEEOBDBOKHK MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84A0A60", Offset = "0x849F060", VA = "0x1884A0A60", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x84A0BD0", Offset = "0x849F1D0", VA = "0x1884A0BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x84A0D20", Offset = "0x849F320", VA = "0x1884A0D20")]
	public static bool MMJMCICIDNJ(KEEOBDBOKHK JOOBCOFNIAM, KEEOBDBOKHK MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x84A0D50", Offset = "0x849F350", VA = "0x1884A0D50", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1215810", Offset = "0x1213E10", VA = "0x181215810")]
	public PJDNIEDEHFC(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4C349D0", Offset = "0x4C32FD0", VA = "0x184C349D0", Slot = "4")]
	public bool Equals(PJDNIEDEHFC MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4C34790", Offset = "0x4C32D90", VA = "0x184C34790", Slot = "5")]
	public int CompareTo(PJDNIEDEHFC MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84A1640", Offset = "0x849FC40", VA = "0x1884A1640", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4C34A50", Offset = "0x4C33050", VA = "0x184C34A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4C349D0", Offset = "0x4C32FD0", VA = "0x184C349D0")]
	public static bool MMJMCICIDNJ(PJDNIEDEHFC JOOBCOFNIAM, PJDNIEDEHFC MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x849FDF0", Offset = "0x849E3F0", VA = "0x18849FDF0")]
	public static bool DIKHMNDIIDO(PJDNIEDEHFC JOOBCOFNIAM, PJDNIEDEHFC MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84A16E0", Offset = "0x849FCE0", VA = "0x1884A16E0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1215810", Offset = "0x1213E10", VA = "0x181215810")]
	public NBBDHCNOOIC(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4C349D0", Offset = "0x4C32FD0", VA = "0x184C349D0", Slot = "4")]
	public bool Equals(NBBDHCNOOIC MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4C34790", Offset = "0x4C32D90", VA = "0x184C34790", Slot = "5")]
	public int CompareTo(NBBDHCNOOIC MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84A1290", Offset = "0x849F890", VA = "0x1884A1290", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4C34A50", Offset = "0x4C33050", VA = "0x184C34A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4C349D0", Offset = "0x4C32FD0", VA = "0x184C349D0")]
	public static bool MMJMCICIDNJ(NBBDHCNOOIC JOOBCOFNIAM, NBBDHCNOOIC MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x849FDF0", Offset = "0x849E3F0", VA = "0x18849FDF0")]
	public static bool DIKHMNDIIDO(NBBDHCNOOIC JOOBCOFNIAM, NBBDHCNOOIC MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84A1330", Offset = "0x849F930", VA = "0x1884A1330", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1215810", Offset = "0x1213E10", VA = "0x181215810")]
	public ODFBDNOADGM(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4C349D0", Offset = "0x4C32FD0", VA = "0x184C349D0", Slot = "4")]
	public bool Equals(ODFBDNOADGM MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4C34790", Offset = "0x4C32D90", VA = "0x184C34790", Slot = "5")]
	public int CompareTo(ODFBDNOADGM MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84A1420", Offset = "0x849FA20", VA = "0x1884A1420", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4C34A50", Offset = "0x4C33050", VA = "0x184C34A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4C349D0", Offset = "0x4C32FD0", VA = "0x184C349D0")]
	public static bool MMJMCICIDNJ(ODFBDNOADGM JOOBCOFNIAM, ODFBDNOADGM MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x849FDF0", Offset = "0x849E3F0", VA = "0x18849FDF0")]
	public static bool DIKHMNDIIDO(ODFBDNOADGM JOOBCOFNIAM, ODFBDNOADGM MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84A14C0", Offset = "0x849FAC0", VA = "0x1884A14C0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1215810", Offset = "0x1213E10", VA = "0x181215810")]
	public DHMNCODBNBK(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x849FF60", Offset = "0x849E560", VA = "0x18849FF60", Slot = "4")]
	public bool Equals(DHMNCODBNBK MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x849FF90", Offset = "0x849E590", VA = "0x18849FF90", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4C34A50", Offset = "0x4C33050", VA = "0x184C34A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x849FF60", Offset = "0x849E560", VA = "0x18849FF60")]
	public static bool MMJMCICIDNJ(DHMNCODBNBK JOOBCOFNIAM, DHMNCODBNBK MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x849FF30", Offset = "0x849E530", VA = "0x18849FF30")]
	public static bool DIKHMNDIIDO(DHMNCODBNBK JOOBCOFNIAM, DHMNCODBNBK MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4C34790", Offset = "0x4C32D90", VA = "0x184C34790", Slot = "5")]
	public int CompareTo(DHMNCODBNBK MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x84A0030", Offset = "0x849E630", VA = "0x1884A0030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1215810", Offset = "0x1213E10", VA = "0x181215810")]
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
	[Cpp2IlInjected.Address(RVA = "0x1215810", Offset = "0x1213E10", VA = "0x181215810")]
	public JCHDCCIJPPE(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4C349D0", Offset = "0x4C32FD0", VA = "0x184C349D0", Slot = "4")]
	public bool Equals(JCHDCCIJPPE MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4C34790", Offset = "0x4C32D90", VA = "0x184C34790", Slot = "5")]
	public int CompareTo(JCHDCCIJPPE MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x84A0950", Offset = "0x849EF50", VA = "0x1884A0950", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4C34A50", Offset = "0x4C33050", VA = "0x184C34A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4C349D0", Offset = "0x4C32FD0", VA = "0x184C349D0")]
	public static bool MMJMCICIDNJ(JCHDCCIJPPE JOOBCOFNIAM, JCHDCCIJPPE MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x849FDF0", Offset = "0x849E3F0", VA = "0x18849FDF0")]
	public static bool DIKHMNDIIDO(JCHDCCIJPPE JOOBCOFNIAM, JCHDCCIJPPE MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84A09F0", Offset = "0x849EFF0", VA = "0x1884A09F0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1215810", Offset = "0x1213E10", VA = "0x181215810")]
	public MCAONEJPGJL(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4C349D0", Offset = "0x4C32FD0", VA = "0x184C349D0", Slot = "4")]
	public bool Equals(MCAONEJPGJL MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4C34790", Offset = "0x4C32D90", VA = "0x184C34790", Slot = "5")]
	public int CompareTo(MCAONEJPGJL MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x84A1070", Offset = "0x849F670", VA = "0x1884A1070", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4C34A50", Offset = "0x4C33050", VA = "0x184C34A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4C349D0", Offset = "0x4C32FD0", VA = "0x184C349D0")]
	public static bool MMJMCICIDNJ(MCAONEJPGJL JOOBCOFNIAM, MCAONEJPGJL MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x849FDF0", Offset = "0x849E3F0", VA = "0x18849FDF0")]
	public static bool DIKHMNDIIDO(MCAONEJPGJL JOOBCOFNIAM, MCAONEJPGJL MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84A1110", Offset = "0x849F710", VA = "0x1884A1110", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1215810", Offset = "0x1213E10", VA = "0x181215810")]
	public CMKLJFNAGCE(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4C349D0", Offset = "0x4C32FD0", VA = "0x184C349D0", Slot = "4")]
	public bool Equals(CMKLJFNAGCE MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4C34790", Offset = "0x4C32D90", VA = "0x184C34790", Slot = "5")]
	public int CompareTo(CMKLJFNAGCE MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x849FE20", Offset = "0x849E420", VA = "0x18849FE20", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4C34A50", Offset = "0x4C33050", VA = "0x184C34A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4C349D0", Offset = "0x4C32FD0", VA = "0x184C349D0")]
	public static bool MMJMCICIDNJ(CMKLJFNAGCE JOOBCOFNIAM, CMKLJFNAGCE MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x849FDF0", Offset = "0x849E3F0", VA = "0x18849FDF0")]
	public static bool DIKHMNDIIDO(CMKLJFNAGCE JOOBCOFNIAM, CMKLJFNAGCE MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x849FEC0", Offset = "0x849E4C0", VA = "0x18849FEC0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1215810", Offset = "0x1213E10", VA = "0x181215810")]
	public MMHDKHFCIBF(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4C349D0", Offset = "0x4C32FD0", VA = "0x184C349D0", Slot = "4")]
	public bool Equals(MMHDKHFCIBF MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4C34790", Offset = "0x4C32D90", VA = "0x184C34790", Slot = "5")]
	public int CompareTo(MMHDKHFCIBF MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x84A1180", Offset = "0x849F780", VA = "0x1884A1180", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4C34A50", Offset = "0x4C33050", VA = "0x184C34A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4C349D0", Offset = "0x4C32FD0", VA = "0x184C349D0")]
	public static bool MMJMCICIDNJ(MMHDKHFCIBF JOOBCOFNIAM, MMHDKHFCIBF MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x849FDF0", Offset = "0x849E3F0", VA = "0x18849FDF0")]
	public static bool DIKHMNDIIDO(MMHDKHFCIBF JOOBCOFNIAM, MMHDKHFCIBF MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x84A1220", Offset = "0x849F820", VA = "0x1884A1220", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x84A06D0", Offset = "0x849ECD0", VA = "0x1884A06D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int NGLKLHPOAED
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x51E8730", Offset = "0x51E6D30", VA = "0x1851E8730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x84A0800", Offset = "0x849EE00", VA = "0x1884A0800")]
	public HDKFBPEELCJ(string? DGGGAMPMIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84A0780", Offset = "0x849ED80", VA = "0x1884A0780")]
	public HDKFBPEELCJ(string?[] HIIHIMPLCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84A0200", Offset = "0x849E800", VA = "0x1884A0200")]
	private static string?[]? EBDDACMOIGN(string?[]? HIIHIMPLCJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x84A0670", Offset = "0x849EC70", VA = "0x1884A0670")]
	public string MFABOCDKDIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84A04C0", Offset = "0x849EAC0", VA = "0x1884A04C0", Slot = "4")]
	public bool Equals(HDKFBPEELCJ MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x84A0430", Offset = "0x849EA30", VA = "0x1884A0430", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84A0590", Offset = "0x849EB90", VA = "0x1884A0590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84A06F0", Offset = "0x849ECF0", VA = "0x1884A06F0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1215810", Offset = "0x1213E10", VA = "0x181215810")]
	public PGCIDDDFGOL(Guid DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
	public Guid ALEBNNAILDG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4C349D0", Offset = "0x4C32FD0", VA = "0x184C349D0", Slot = "4")]
	public bool Equals(PGCIDDDFGOL MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4C34790", Offset = "0x4C32D90", VA = "0x184C34790", Slot = "5")]
	public int CompareTo(PGCIDDDFGOL MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x84A1530", Offset = "0x849FB30", VA = "0x1884A1530", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4C34A50", Offset = "0x4C33050", VA = "0x184C34A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x84A15D0", Offset = "0x849FBD0", VA = "0x1884A15D0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x84A00D0", Offset = "0x849E6D0", VA = "0x1884A00D0")]
	public static string[] KLEHFDFKDPN(string? DGGGAMPMIAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84A00A0", Offset = "0x849E6A0", VA = "0x1884A00A0")]
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
