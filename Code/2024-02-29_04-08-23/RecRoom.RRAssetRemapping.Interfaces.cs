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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6617E40", Offset = "0x6616C40", VA = "0x186617E40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OCOMIAFPJFK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FILLENIGNNA(GCJCFMDAODD ECKJJAACLOE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GCJCFMDAODD CINNELLPCMC(string ECKJJAACLOE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct GCJCFMDAODD : IEquatable<GCJCFMDAODD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LBHGABEKMEC ICJLGMMOBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly DFPMJDLGDHO AJGOFABBHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid NHADJIOMCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? NLFHCDDMMGI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HOIACFFFAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66172A0", Offset = "0x66160A0", VA = "0x1866172A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KKIJPLNDKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6617260", Offset = "0x6616060", VA = "0x186617260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6617860", Offset = "0x6616660", VA = "0x186617860")]
	public GCJCFMDAODD(GCJCFMDAODD EMMLLJGDOPN, [Optional] Guid HHBFJCKANGE, [Optional] RRColor? OLDELFAHHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x66177D0", Offset = "0x66165D0", VA = "0x1866177D0")]
	public GCJCFMDAODD(LBHGABEKMEC KDJDBOGEALE, DFPMJDLGDHO DCMPKOAIIEC, [Optional] Guid HHBFJCKANGE, [Optional] RRColor? OLDELFAHHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6617000", Offset = "0x6615E00", VA = "0x186617000", Slot = "4")]
	public bool Equals(GCJCFMDAODD FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6616F10", Offset = "0x6615D10", VA = "0x186616F10", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6617100", Offset = "0x6615F00", VA = "0x186617100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x66171F0", Offset = "0x6615FF0", VA = "0x1866171F0")]
	public static bool JACCNGOPODK(GCJCFMDAODD DPMPIPDPNFG, GCJCFMDAODD DJCBILALFKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6617360", Offset = "0x6616160", VA = "0x186617360")]
	public static bool PONNJIKFNKJ(GCJCFMDAODD DPMPIPDPNFG, GCJCFMDAODD DJCBILALFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x66173D0", Offset = "0x66161D0", VA = "0x1866173D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LBHGABEKMEC : IEquatable<LBHGABEKMEC>, IComparable<LBHGABEKMEC>, LDDGGJBEKGP
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly LBHGABEKMEC NJBMLHJLPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid FANIDECOFDM;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
	public LBHGABEKMEC(Guid FANIDECOFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
	public Guid IPCGJKBGOKI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0", Slot = "4")]
	public bool Equals(LBHGABEKMEC FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x37386A0", Offset = "0x37374A0", VA = "0x1837386A0", Slot = "5")]
	public int CompareTo(LBHGABEKMEC FPEEGIOMOFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6617A00", Offset = "0x6616800", VA = "0x186617A00", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x37388A0", Offset = "0x37376A0", VA = "0x1837388A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0")]
	public static bool JACCNGOPODK(LBHGABEKMEC DPMPIPDPNFG, LBHGABEKMEC DJCBILALFKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6616030", Offset = "0x6614E30", VA = "0x186616030")]
	public static bool PONNJIKFNKJ(LBHGABEKMEC DPMPIPDPNFG, LBHGABEKMEC DJCBILALFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6617AA0", Offset = "0x66168A0", VA = "0x186617AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct EOJCBICDBHE : IEquatable<EOJCBICDBHE>, IComparable<EOJCBICDBHE>, LDDGGJBEKGP
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly EOJCBICDBHE NJBMLHJLPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid FANIDECOFDM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
	public EOJCBICDBHE(Guid FANIDECOFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
	public Guid IPCGJKBGOKI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0", Slot = "4")]
	public bool Equals(EOJCBICDBHE FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x37386A0", Offset = "0x37374A0", VA = "0x1837386A0", Slot = "5")]
	public int CompareTo(EOJCBICDBHE FPEEGIOMOFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x66165B0", Offset = "0x66153B0", VA = "0x1866165B0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x37388A0", Offset = "0x37376A0", VA = "0x1837388A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0")]
	public static bool JACCNGOPODK(EOJCBICDBHE DPMPIPDPNFG, EOJCBICDBHE DJCBILALFKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6616030", Offset = "0x6614E30", VA = "0x186616030")]
	public static bool PONNJIKFNKJ(EOJCBICDBHE DPMPIPDPNFG, EOJCBICDBHE DJCBILALFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6616650", Offset = "0x6615450", VA = "0x186616650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct BENNFIBOECP : IEquatable<BENNFIBOECP>, IComparable<BENNFIBOECP>, LDDGGJBEKGP
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly BENNFIBOECP NJBMLHJLPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid FANIDECOFDM;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
	public BENNFIBOECP(Guid FANIDECOFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
	public Guid IPCGJKBGOKI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0", Slot = "4")]
	public bool Equals(BENNFIBOECP FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x37386A0", Offset = "0x37374A0", VA = "0x1837386A0", Slot = "5")]
	public int CompareTo(BENNFIBOECP FPEEGIOMOFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6615F90", Offset = "0x6614D90", VA = "0x186615F90", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x37388A0", Offset = "0x37376A0", VA = "0x1837388A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0")]
	public static bool JACCNGOPODK(BENNFIBOECP DPMPIPDPNFG, BENNFIBOECP DJCBILALFKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6616030", Offset = "0x6614E30", VA = "0x186616030")]
	public static bool PONNJIKFNKJ(BENNFIBOECP DPMPIPDPNFG, BENNFIBOECP DJCBILALFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6616060", Offset = "0x6614E60", VA = "0x186616060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct DFPMJDLGDHO : IEquatable<DFPMJDLGDHO>, IComparable<DFPMJDLGDHO>, LDDGGJBEKGP
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly DFPMJDLGDHO NJBMLHJLPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid FANIDECOFDM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NFNDKHDEMKE DMGDNKGEABP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB6E440", Offset = "0xB6D240", VA = "0x180B6E440")]
		[CompilerGenerated]
		get
		{
			return default(NFNDKHDEMKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NFNDKHDEMKE CIECPCJEHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xEFE710", Offset = "0xEFD510", VA = "0x180EFE710")]
		[CompilerGenerated]
		get
		{
			return default(NFNDKHDEMKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NFNDKHDEMKE COGOBCOMNPE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE63CE0", Offset = "0xE62AE0", VA = "0x180E63CE0")]
		[CompilerGenerated]
		get
		{
			return default(NFNDKHDEMKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
	public Guid IPCGJKBGOKI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6616570", Offset = "0x6615370", VA = "0x186616570")]
	public DFPMJDLGDHO(Guid FANIDECOFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6616520", Offset = "0x6615320", VA = "0x186616520")]
	public DFPMJDLGDHO(NFNDKHDEMKE PMABMANJHEL, NFNDKHDEMKE GMILENCFGLK, NFNDKHDEMKE DBDOLOCBHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6616340", Offset = "0x6615140", VA = "0x186616340")]
	private Guid NJDAKOFDOFG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x66162D0", Offset = "0x66150D0", VA = "0x1866162D0", Slot = "4")]
	public bool Equals(DFPMJDLGDHO FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6616220", Offset = "0x6615020", VA = "0x186616220", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x37388A0", Offset = "0x37376A0", VA = "0x1837388A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6616300", Offset = "0x6615100", VA = "0x186616300")]
	public static bool JACCNGOPODK(DFPMJDLGDHO DPMPIPDPNFG, DFPMJDLGDHO DJCBILALFKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6616470", Offset = "0x6615270", VA = "0x186616470")]
	public static bool PONNJIKFNKJ(DFPMJDLGDHO DPMPIPDPNFG, DFPMJDLGDHO DJCBILALFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x66161E0", Offset = "0x6614FE0", VA = "0x1866161E0", Slot = "5")]
	public int CompareTo(DFPMJDLGDHO FPEEGIOMOFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x66164B0", Offset = "0x66152B0", VA = "0x1866164B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct NKLHELMOINE : IEquatable<NKLHELMOINE>, IComparable<NKLHELMOINE>, LDDGGJBEKGP
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly NKLHELMOINE NJBMLHJLPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid FANIDECOFDM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
	public NKLHELMOINE(Guid FANIDECOFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
	public Guid IPCGJKBGOKI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0", Slot = "4")]
	public bool Equals(NKLHELMOINE FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x37386A0", Offset = "0x37374A0", VA = "0x1837386A0", Slot = "5")]
	public int CompareTo(NKLHELMOINE FPEEGIOMOFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6617D30", Offset = "0x6616B30", VA = "0x186617D30", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x37388A0", Offset = "0x37376A0", VA = "0x1837388A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0")]
	public static bool JACCNGOPODK(NKLHELMOINE DPMPIPDPNFG, NKLHELMOINE DJCBILALFKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6616030", Offset = "0x6614E30", VA = "0x186616030")]
	public static bool PONNJIKFNKJ(NKLHELMOINE DPMPIPDPNFG, NKLHELMOINE DJCBILALFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6617DD0", Offset = "0x6616BD0", VA = "0x186617DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct JGMMLLLGHOB : IEquatable<JGMMLLLGHOB>, IComparable<JGMMLLLGHOB>, LDDGGJBEKGP
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly JGMMLLLGHOB NJBMLHJLPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid FANIDECOFDM;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
	public JGMMLLLGHOB(Guid FANIDECOFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
	public Guid IPCGJKBGOKI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0", Slot = "4")]
	public bool Equals(JGMMLLLGHOB FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x37386A0", Offset = "0x37374A0", VA = "0x1837386A0", Slot = "5")]
	public int CompareTo(JGMMLLLGHOB FPEEGIOMOFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x66178F0", Offset = "0x66166F0", VA = "0x1866178F0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x37388A0", Offset = "0x37376A0", VA = "0x1837388A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0")]
	public static bool JACCNGOPODK(JGMMLLLGHOB DPMPIPDPNFG, JGMMLLLGHOB DJCBILALFKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6616030", Offset = "0x6614E30", VA = "0x186616030")]
	public static bool PONNJIKFNKJ(JGMMLLLGHOB DPMPIPDPNFG, JGMMLLLGHOB DJCBILALFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6617990", Offset = "0x6616790", VA = "0x186617990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct NEEKCOKFGOD : IEquatable<NEEKCOKFGOD>, IComparable<NEEKCOKFGOD>, LDDGGJBEKGP
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly NEEKCOKFGOD NJBMLHJLPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid FANIDECOFDM;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
	public NEEKCOKFGOD(Guid FANIDECOFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
	public Guid IPCGJKBGOKI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0", Slot = "4")]
	public bool Equals(NEEKCOKFGOD FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x37386A0", Offset = "0x37374A0", VA = "0x1837386A0", Slot = "5")]
	public int CompareTo(NEEKCOKFGOD FPEEGIOMOFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6617B10", Offset = "0x6616910", VA = "0x186617B10", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x37388A0", Offset = "0x37376A0", VA = "0x1837388A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0")]
	public static bool JACCNGOPODK(NEEKCOKFGOD DPMPIPDPNFG, NEEKCOKFGOD DJCBILALFKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6616030", Offset = "0x6614E30", VA = "0x186616030")]
	public static bool PONNJIKFNKJ(NEEKCOKFGOD DPMPIPDPNFG, NEEKCOKFGOD DJCBILALFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6617BB0", Offset = "0x66169B0", VA = "0x186617BB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct FFGDPHHADEF : IEquatable<FFGDPHHADEF>, IComparable<FFGDPHHADEF>, LDDGGJBEKGP
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly FFGDPHHADEF NJBMLHJLPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid FANIDECOFDM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
	public FFGDPHHADEF(Guid FANIDECOFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
	public Guid IPCGJKBGOKI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0", Slot = "4")]
	public bool Equals(FFGDPHHADEF FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x37386A0", Offset = "0x37374A0", VA = "0x1837386A0", Slot = "5")]
	public int CompareTo(FFGDPHHADEF FPEEGIOMOFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x66166C0", Offset = "0x66154C0", VA = "0x1866166C0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x37388A0", Offset = "0x37376A0", VA = "0x1837388A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0")]
	public static bool JACCNGOPODK(FFGDPHHADEF DPMPIPDPNFG, FFGDPHHADEF DJCBILALFKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6616030", Offset = "0x6614E30", VA = "0x186616030")]
	public static bool PONNJIKFNKJ(FFGDPHHADEF DPMPIPDPNFG, FFGDPHHADEF DJCBILALFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6616760", Offset = "0x6615560", VA = "0x186616760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FOPINDNEENL : IEquatable<FOPINDNEENL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? CJCIDCDNAII;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CHDBPBGLOPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6616CA0", Offset = "0x6615AA0", VA = "0x186616CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int FFCLFOOGMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3B38F20", Offset = "0x3B37D20", VA = "0x183B38F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6616D50", Offset = "0x6615B50", VA = "0x186616D50")]
	public FOPINDNEENL(string? AHKKHKHBPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6616E90", Offset = "0x6615C90", VA = "0x186616E90")]
	public FOPINDNEENL(string?[] AAHNMFBDDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6616990", Offset = "0x6615790", VA = "0x186616990")]
	private static string?[]? GDFIBMEKHDD(string?[]? AAHNMFBDDBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6616930", Offset = "0x6615730", VA = "0x186616930")]
	public string FNAOLENENKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6616860", Offset = "0x6615660", VA = "0x186616860", Slot = "4")]
	public bool Equals(FOPINDNEENL FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x66167D0", Offset = "0x66155D0", VA = "0x1866167D0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6616BC0", Offset = "0x66159C0", VA = "0x186616BC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6616CC0", Offset = "0x6615AC0", VA = "0x186616CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct NFNDKHDEMKE : IEquatable<NFNDKHDEMKE>, IComparable<NFNDKHDEMKE>, LDDGGJBEKGP
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly NFNDKHDEMKE NJBMLHJLPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid FANIDECOFDM;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
	public NFNDKHDEMKE(Guid FANIDECOFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
	public Guid IPCGJKBGOKI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0", Slot = "4")]
	public bool Equals(NFNDKHDEMKE FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x37386A0", Offset = "0x37374A0", VA = "0x1837386A0", Slot = "5")]
	public int CompareTo(NFNDKHDEMKE FPEEGIOMOFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6617C20", Offset = "0x6616A20", VA = "0x186617C20", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x37388A0", Offset = "0x37376A0", VA = "0x1837388A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0")]
	public static bool JACCNGOPODK(NFNDKHDEMKE DPMPIPDPNFG, NFNDKHDEMKE DJCBILALFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6617CC0", Offset = "0x6616AC0", VA = "0x186617CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct CINKLJPDNLK : IEquatable<CINKLJPDNLK>, IComparable<CINKLJPDNLK>, LDDGGJBEKGP
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly CINKLJPDNLK NJBMLHJLPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Guid FANIDECOFDM;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
	public CINKLJPDNLK(Guid FANIDECOFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
	public Guid IPCGJKBGOKI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x37388C0", Offset = "0x37376C0", VA = "0x1837388C0", Slot = "4")]
	public bool Equals(CINKLJPDNLK FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x37386A0", Offset = "0x37374A0", VA = "0x1837386A0", Slot = "5")]
	public int CompareTo(CINKLJPDNLK FPEEGIOMOFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x66160D0", Offset = "0x6614ED0", VA = "0x1866160D0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x37388A0", Offset = "0x37376A0", VA = "0x1837388A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6616030", Offset = "0x6614E30", VA = "0x186616030")]
	public static bool PONNJIKFNKJ(CINKLJPDNLK DPMPIPDPNFG, CINKLJPDNLK DJCBILALFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6616170", Offset = "0x6614F70", VA = "0x186616170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MAJGOBKEGDC<TModern> : AGGINCCPFOJ<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MGIKHBODJPF(TModern CACIEBJGGBG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LDDGGJBEKGP
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid IPCGJKBGOKI();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AGGINCCPFOJ<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern EDKJAABKNGJ(string CACIEBJGGBG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ADOBOFDDOHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	MAJGOBKEGDC<LBHGABEKMEC> MANDNJODMJB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	MAJGOBKEGDC<NKLHELMOINE> LMOHHCNDLOL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	MAJGOBKEGDC<FFGDPHHADEF> MDDEMAILADM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MAJGOBKEGDC<DFPMJDLGDHO> PFACLDJMLLG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	MAJGOBKEGDC<BENNFIBOECP> KBJECIKJIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	MAJGOBKEGDC<NEEKCOKFGOD> HAGKLOCAGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	MAJGOBKEGDC<EOJCBICDBHE> KDNELOAFOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	MAJGOBKEGDC<JGMMLLLGHOB> OEEPMAPANNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PEEELMFAGPA
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6617EC0", Offset = "0x6616CC0", VA = "0x186617EC0")]
	public static string[] GGIAAEDEKDL(string? AHKKHKHBPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6617F80", Offset = "0x6616D80", VA = "0x186617F80")]
	public static string? IOHAGOCOGNI(string? KDJDBOGEALE)
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
