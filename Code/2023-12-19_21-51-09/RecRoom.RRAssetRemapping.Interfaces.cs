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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6459310", Offset = "0x6457F10", VA = "0x186459310")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79BDE0", Offset = "0x79A9E0", VA = "0x18079BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79BE20", Offset = "0x79AA20", VA = "0x18079BE20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IBOHLOCDDOI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OIIEHDKDHEB(LNOEEDOPAMJ MAIMNHFMIBD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LNOEEDOPAMJ JFKFFNFOIMD(string MAIMNHFMIBD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct LNOEEDOPAMJ : IEquatable<LNOEEDOPAMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly PNEIPKAFINP PHDDJCHCEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly BBFEOJBPFGI HPJENDINIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid DAEGIJIJMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? DDCMCJKAPHO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NFDHLPEDEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6458840", Offset = "0x6457440", VA = "0x186458840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LJKAKOGFLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6458CC0", Offset = "0x64578C0", VA = "0x186458CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6459190", Offset = "0x6457D90", VA = "0x186459190")]
	public LNOEEDOPAMJ(LNOEEDOPAMJ AJKANCGHOGJ, [Optional] Guid CGBJAIOMPCN, [Optional] RRColor? EFLLOODPMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6459100", Offset = "0x6457D00", VA = "0x186459100")]
	public LNOEEDOPAMJ(PNEIPKAFINP ECBKOKILNBP, BBFEOJBPFGI NLGBENKGENL, [Optional] Guid CGBJAIOMPCN, [Optional] RRColor? EFLLOODPMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64589F0", Offset = "0x64575F0", VA = "0x1864589F0", Slot = "4")]
	public bool Equals(LNOEEDOPAMJ LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6458900", Offset = "0x6457500", VA = "0x186458900", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6458AF0", Offset = "0x64576F0", VA = "0x186458AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6458C50", Offset = "0x6457850", VA = "0x186458C50")]
	public static bool JONBIHPGCCI(LNOEEDOPAMJ CNJMMNBENNL, LNOEEDOPAMJ PLPCDFMLHIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6458BE0", Offset = "0x64577E0", VA = "0x186458BE0")]
	public static bool JBDELPGDOBO(LNOEEDOPAMJ CNJMMNBENNL, LNOEEDOPAMJ PLPCDFMLHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6458D00", Offset = "0x6457900", VA = "0x186458D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PNEIPKAFINP : IEquatable<PNEIPKAFINP>, IComparable<PNEIPKAFINP>, PNPPOCLONMF
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly PNEIPKAFINP MANJPJPLOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid OGCEPACDHOE;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA810", Offset = "0x1CC9410", VA = "0x181CCA810")]
	public PNEIPKAFINP(Guid OGCEPACDHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
	public Guid NDEPEHOLMNI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100", Slot = "4")]
	public bool Equals(PNEIPKAFINP LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3170FB0", Offset = "0x316FBB0", VA = "0x183170FB0", Slot = "5")]
	public int CompareTo(PNEIPKAFINP LLMHBOEDHFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x64595B0", Offset = "0x64581B0", VA = "0x1864595B0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3171290", Offset = "0x316FE90", VA = "0x183171290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100")]
	public static bool JONBIHPGCCI(PNEIPKAFINP CNJMMNBENNL, PNEIPKAFINP PLPCDFMLHIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6457D30", Offset = "0x6456930", VA = "0x186457D30")]
	public static bool JBDELPGDOBO(PNEIPKAFINP CNJMMNBENNL, PNEIPKAFINP PLPCDFMLHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6459650", Offset = "0x6458250", VA = "0x186459650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct JLAOOLAEMEJ : IEquatable<JLAOOLAEMEJ>, IComparable<JLAOOLAEMEJ>, PNPPOCLONMF
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly JLAOOLAEMEJ MANJPJPLOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid OGCEPACDHOE;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA810", Offset = "0x1CC9410", VA = "0x181CCA810")]
	public JLAOOLAEMEJ(Guid OGCEPACDHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
	public Guid NDEPEHOLMNI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100", Slot = "4")]
	public bool Equals(JLAOOLAEMEJ LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3170FB0", Offset = "0x316FBB0", VA = "0x183170FB0", Slot = "5")]
	public int CompareTo(JLAOOLAEMEJ LLMHBOEDHFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6458730", Offset = "0x6457330", VA = "0x186458730", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3171290", Offset = "0x316FE90", VA = "0x183171290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100")]
	public static bool JONBIHPGCCI(JLAOOLAEMEJ CNJMMNBENNL, JLAOOLAEMEJ PLPCDFMLHIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6457D30", Offset = "0x6456930", VA = "0x186457D30")]
	public static bool JBDELPGDOBO(JLAOOLAEMEJ CNJMMNBENNL, JLAOOLAEMEJ PLPCDFMLHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x64587D0", Offset = "0x64573D0", VA = "0x1864587D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct ECCOKMBHIBA : IEquatable<ECCOKMBHIBA>, IComparable<ECCOKMBHIBA>, PNPPOCLONMF
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly ECCOKMBHIBA MANJPJPLOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid OGCEPACDHOE;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA810", Offset = "0x1CC9410", VA = "0x181CCA810")]
	public ECCOKMBHIBA(Guid OGCEPACDHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
	public Guid NDEPEHOLMNI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100", Slot = "4")]
	public bool Equals(ECCOKMBHIBA LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3170FB0", Offset = "0x316FBB0", VA = "0x183170FB0", Slot = "5")]
	public int CompareTo(ECCOKMBHIBA LLMHBOEDHFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6457C90", Offset = "0x6456890", VA = "0x186457C90", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3171290", Offset = "0x316FE90", VA = "0x183171290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100")]
	public static bool JONBIHPGCCI(ECCOKMBHIBA CNJMMNBENNL, ECCOKMBHIBA PLPCDFMLHIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6457D30", Offset = "0x6456930", VA = "0x186457D30")]
	public static bool JBDELPGDOBO(ECCOKMBHIBA CNJMMNBENNL, ECCOKMBHIBA PLPCDFMLHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6457D60", Offset = "0x6456960", VA = "0x186457D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct BBFEOJBPFGI : IEquatable<BBFEOJBPFGI>, IComparable<BBFEOJBPFGI>, PNPPOCLONMF
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly BBFEOJBPFGI MANJPJPLOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid OGCEPACDHOE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BAECFEEMCDB CNALHAHMGFD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB2A490", Offset = "0xB29090", VA = "0x180B2A490")]
		[CompilerGenerated]
		get
		{
			return default(BAECFEEMCDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public BAECFEEMCDB APDIHLPPBBD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xEE1590", Offset = "0xEE0190", VA = "0x180EE1590")]
		[CompilerGenerated]
		get
		{
			return default(BAECFEEMCDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BAECFEEMCDB JHMPCDJABJG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDFA030", Offset = "0xDF8C30", VA = "0x180DFA030")]
		[CompilerGenerated]
		get
		{
			return default(BAECFEEMCDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
	public Guid NDEPEHOLMNI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6457C00", Offset = "0x6456800", VA = "0x186457C00")]
	public BBFEOJBPFGI(Guid OGCEPACDHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6457C40", Offset = "0x6456840", VA = "0x186457C40")]
	public BBFEOJBPFGI(BAECFEEMCDB BCKKONDMMJJ, BAECFEEMCDB GJCCDOHMHEI, BAECFEEMCDB KBJOOGLPODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x64578F0", Offset = "0x64564F0", VA = "0x1864578F0")]
	private Guid CGELMBCDAEB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5ED10C0", Offset = "0x5ECFCC0", VA = "0x185ED10C0", Slot = "4")]
	public bool Equals(BBFEOJBPFGI LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6457A60", Offset = "0x6456660", VA = "0x186457A60", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3171290", Offset = "0x316FE90", VA = "0x183171290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6457B50", Offset = "0x6456750", VA = "0x186457B50")]
	public static bool JONBIHPGCCI(BBFEOJBPFGI CNJMMNBENNL, BBFEOJBPFGI PLPCDFMLHIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6457B10", Offset = "0x6456710", VA = "0x186457B10")]
	public static bool JBDELPGDOBO(BBFEOJBPFGI CNJMMNBENNL, BBFEOJBPFGI PLPCDFMLHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6457A20", Offset = "0x6456620", VA = "0x186457A20", Slot = "5")]
	public int CompareTo(BBFEOJBPFGI LLMHBOEDHFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6457B90", Offset = "0x6456790", VA = "0x186457B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct HOLGPLBNGNG : IEquatable<HOLGPLBNGNG>, IComparable<HOLGPLBNGNG>, PNPPOCLONMF
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly HOLGPLBNGNG MANJPJPLOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid OGCEPACDHOE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA810", Offset = "0x1CC9410", VA = "0x181CCA810")]
	public HOLGPLBNGNG(Guid OGCEPACDHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
	public Guid NDEPEHOLMNI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100", Slot = "4")]
	public bool Equals(HOLGPLBNGNG LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3170FB0", Offset = "0x316FBB0", VA = "0x183170FB0", Slot = "5")]
	public int CompareTo(HOLGPLBNGNG LLMHBOEDHFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6458620", Offset = "0x6457220", VA = "0x186458620", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3171290", Offset = "0x316FE90", VA = "0x183171290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100")]
	public static bool JONBIHPGCCI(HOLGPLBNGNG CNJMMNBENNL, HOLGPLBNGNG PLPCDFMLHIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6457D30", Offset = "0x6456930", VA = "0x186457D30")]
	public static bool JBDELPGDOBO(HOLGPLBNGNG CNJMMNBENNL, HOLGPLBNGNG PLPCDFMLHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x64586C0", Offset = "0x64572C0", VA = "0x1864586C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct OAEAOJLAGNN : IEquatable<OAEAOJLAGNN>, IComparable<OAEAOJLAGNN>, PNPPOCLONMF
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly OAEAOJLAGNN MANJPJPLOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid OGCEPACDHOE;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA810", Offset = "0x1CC9410", VA = "0x181CCA810")]
	public OAEAOJLAGNN(Guid OGCEPACDHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
	public Guid NDEPEHOLMNI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100", Slot = "4")]
	public bool Equals(OAEAOJLAGNN LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3170FB0", Offset = "0x316FBB0", VA = "0x183170FB0", Slot = "5")]
	public int CompareTo(OAEAOJLAGNN LLMHBOEDHFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6459390", Offset = "0x6457F90", VA = "0x186459390", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3171290", Offset = "0x316FE90", VA = "0x183171290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100")]
	public static bool JONBIHPGCCI(OAEAOJLAGNN CNJMMNBENNL, OAEAOJLAGNN PLPCDFMLHIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6457D30", Offset = "0x6456930", VA = "0x186457D30")]
	public static bool JBDELPGDOBO(OAEAOJLAGNN CNJMMNBENNL, OAEAOJLAGNN PLPCDFMLHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6459430", Offset = "0x6458030", VA = "0x186459430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct PFAAKBKFIOL : IEquatable<PFAAKBKFIOL>, IComparable<PFAAKBKFIOL>, PNPPOCLONMF
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly PFAAKBKFIOL MANJPJPLOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid OGCEPACDHOE;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA810", Offset = "0x1CC9410", VA = "0x181CCA810")]
	public PFAAKBKFIOL(Guid OGCEPACDHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
	public Guid NDEPEHOLMNI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100", Slot = "4")]
	public bool Equals(PFAAKBKFIOL LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3170FB0", Offset = "0x316FBB0", VA = "0x183170FB0", Slot = "5")]
	public int CompareTo(PFAAKBKFIOL LLMHBOEDHFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x64594A0", Offset = "0x64580A0", VA = "0x1864594A0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3171290", Offset = "0x316FE90", VA = "0x183171290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100")]
	public static bool JONBIHPGCCI(PFAAKBKFIOL CNJMMNBENNL, PFAAKBKFIOL PLPCDFMLHIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6457D30", Offset = "0x6456930", VA = "0x186457D30")]
	public static bool JBDELPGDOBO(PFAAKBKFIOL CNJMMNBENNL, PFAAKBKFIOL PLPCDFMLHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6459540", Offset = "0x6458140", VA = "0x186459540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct FNLFLIELHBO : IEquatable<FNLFLIELHBO>, IComparable<FNLFLIELHBO>, PNPPOCLONMF
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly FNLFLIELHBO MANJPJPLOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid OGCEPACDHOE;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA810", Offset = "0x1CC9410", VA = "0x181CCA810")]
	public FNLFLIELHBO(Guid OGCEPACDHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
	public Guid NDEPEHOLMNI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100", Slot = "4")]
	public bool Equals(FNLFLIELHBO LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3170FB0", Offset = "0x316FBB0", VA = "0x183170FB0", Slot = "5")]
	public int CompareTo(FNLFLIELHBO LLMHBOEDHFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6457DD0", Offset = "0x64569D0", VA = "0x186457DD0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3171290", Offset = "0x316FE90", VA = "0x183171290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100")]
	public static bool JONBIHPGCCI(FNLFLIELHBO CNJMMNBENNL, FNLFLIELHBO PLPCDFMLHIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6457D30", Offset = "0x6456930", VA = "0x186457D30")]
	public static bool JBDELPGDOBO(FNLFLIELHBO CNJMMNBENNL, FNLFLIELHBO PLPCDFMLHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6457E70", Offset = "0x6456A70", VA = "0x186457E70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct GNEFELCLIGB : IEquatable<GNEFELCLIGB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? BDLFNGMDFIP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PJGJGCEHBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6458350", Offset = "0x6456F50", VA = "0x186458350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int CHHFEKAGPOK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3B017C0", Offset = "0x3B003C0", VA = "0x183B017C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x64584E0", Offset = "0x64570E0", VA = "0x1864584E0")]
	public GNEFELCLIGB(string? EOEJFADIAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6458460", Offset = "0x6457060", VA = "0x186458460")]
	public GNEFELCLIGB(string?[] IJHDMBKEECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6457EE0", Offset = "0x6456AE0", VA = "0x186457EE0")]
	private static string?[]? AKBGAKNJMBC(string?[]? IJHDMBKEECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6458370", Offset = "0x6456F70", VA = "0x186458370")]
	public string OIMLOFDMBDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6458110", Offset = "0x6456D10", VA = "0x186458110", Slot = "4")]
	public bool Equals(GNEFELCLIGB LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x64581E0", Offset = "0x6456DE0", VA = "0x1864581E0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6458270", Offset = "0x6456E70", VA = "0x186458270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x64583D0", Offset = "0x6456FD0", VA = "0x1864583D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct BAECFEEMCDB : IEquatable<BAECFEEMCDB>, IComparable<BAECFEEMCDB>, PNPPOCLONMF
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly BAECFEEMCDB MANJPJPLOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid OGCEPACDHOE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA810", Offset = "0x1CC9410", VA = "0x181CCA810")]
	public BAECFEEMCDB(Guid OGCEPACDHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
	public Guid NDEPEHOLMNI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100", Slot = "4")]
	public bool Equals(BAECFEEMCDB LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3170FB0", Offset = "0x316FBB0", VA = "0x183170FB0", Slot = "5")]
	public int CompareTo(BAECFEEMCDB LLMHBOEDHFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x64577E0", Offset = "0x64563E0", VA = "0x1864577E0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3171290", Offset = "0x316FE90", VA = "0x183171290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3171100", Offset = "0x316FD00", VA = "0x183171100")]
	public static bool JONBIHPGCCI(BAECFEEMCDB CNJMMNBENNL, BAECFEEMCDB PLPCDFMLHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6457880", Offset = "0x6456480", VA = "0x186457880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JBLNIBCFFOH<TModern> : FDPPONKIIIL<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MOHCPDAHFDF(TModern CGIFEAKDCAE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PNPPOCLONMF
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid NDEPEHOLMNI();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FDPPONKIIIL<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern JLCCKCCOLML(string CGIFEAKDCAE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KIGLANGNNBE
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JBLNIBCFFOH<PNEIPKAFINP> HDNBAPPJJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JBLNIBCFFOH<HOLGPLBNGNG> GKGBNKFGEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JBLNIBCFFOH<FNLFLIELHBO> BNDPDCKHKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JBLNIBCFFOH<BBFEOJBPFGI> MEBIBLLIJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JBLNIBCFFOH<ECCOKMBHIBA> MGFALLKBAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	JBLNIBCFFOH<PFAAKBKFIOL> OKKDKBBFHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	JBLNIBCFFOH<JLAOOLAEMEJ> EEOLFHHHECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	JBLNIBCFFOH<OAEAOJLAGNN> NOEIOMKCABN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NKLDALEKLJK
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6459220", Offset = "0x6457E20", VA = "0x186459220")]
	public static string[] ICLAHMBMDGG(string? EOEJFADIAEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x64592E0", Offset = "0x6457EE0", VA = "0x1864592E0")]
	public static string? KCPCELNFFEI(string? ECBKOKILNBP)
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
