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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x68A0610", Offset = "0x689F410", VA = "0x1868A0610")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KNCKFLPEPKI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JPFDICAGNEF(ELPAHKDOMIL PGOKJJEIBMC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ELPAHKDOMIL FPNHMAJLCHC(string PGOKJJEIBMC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct ELPAHKDOMIL : IEquatable<ELPAHKDOMIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly HLJOPPFGADF GCMGEANOEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly AJAHBIADNDL JBMDBKBJGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid AKAIAFDBOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? OGLMGKPGNED;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HLEDPCMMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x689F830", Offset = "0x689E630", VA = "0x18689F830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FOPGPNIHIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x689F580", Offset = "0x689E380", VA = "0x18689F580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x689FDA0", Offset = "0x689EBA0", VA = "0x18689FDA0")]
	public ELPAHKDOMIL(ELPAHKDOMIL PJBEENGBFEK, [Optional] Guid OPNAICKJDMP, [Optional] RRColor? BGJPICBMDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x689FD10", Offset = "0x689EB10", VA = "0x18689FD10")]
	public ELPAHKDOMIL(HLJOPPFGADF FHFLGNJFLFL, AJAHBIADNDL EJMKOEMIEPG, [Optional] Guid OPNAICKJDMP, [Optional] RRColor? BGJPICBMDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x689F6F0", Offset = "0x689E4F0", VA = "0x18689F6F0", Slot = "4")]
	public bool Equals(ELPAHKDOMIL GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x689F5C0", Offset = "0x689E3C0", VA = "0x18689F5C0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x689F7A0", Offset = "0x689E5A0", VA = "0x18689F7A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x689F6F0", Offset = "0x689E4F0", VA = "0x18689F6F0")]
	public static bool OFKPFEHPLBH(ELPAHKDOMIL DCJCHFKPCOP, ELPAHKDOMIL IKGIOHGPKCP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x689F4D0", Offset = "0x689E2D0", VA = "0x18689F4D0")]
	public static bool CAAJBKCJNPA(ELPAHKDOMIL DCJCHFKPCOP, ELPAHKDOMIL IKGIOHGPKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x689F8F0", Offset = "0x689E6F0", VA = "0x18689F8F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct HLJOPPFGADF : IEquatable<HLJOPPFGADF>, IComparable<HLJOPPFGADF>, HICMJIEOLDP
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly HLJOPPFGADF CNCELEPFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid IIGMMHCLOGB;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E350A0", Offset = "0x1E33EA0", VA = "0x181E350A0")]
	public HLJOPPFGADF(Guid IIGMMHCLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420", Slot = "6")]
	public Guid DDNIMHOEEID()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20", Slot = "4")]
	public bool Equals(HLJOPPFGADF GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3FF29F0", Offset = "0x3FF17F0", VA = "0x183FF29F0", Slot = "5")]
	public int CompareTo(HLJOPPFGADF GGINNHLAMLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68A0070", Offset = "0x689EE70", VA = "0x1868A0070", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B00", Offset = "0x3FF1900", VA = "0x183FF2B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20")]
	public static bool OFKPFEHPLBH(HLJOPPFGADF DCJCHFKPCOP, HLJOPPFGADF IKGIOHGPKCP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x689F260", Offset = "0x689E060", VA = "0x18689F260")]
	public static bool CAAJBKCJNPA(HLJOPPFGADF DCJCHFKPCOP, HLJOPPFGADF IKGIOHGPKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68A0120", Offset = "0x689EF20", VA = "0x1868A0120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct JDOGLLHFBNN : IEquatable<JDOGLLHFBNN>, IComparable<JDOGLLHFBNN>, HICMJIEOLDP
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly JDOGLLHFBNN CNCELEPFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid IIGMMHCLOGB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E350A0", Offset = "0x1E33EA0", VA = "0x181E350A0")]
	public JDOGLLHFBNN(Guid IIGMMHCLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420", Slot = "6")]
	public Guid DDNIMHOEEID()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20", Slot = "4")]
	public bool Equals(JDOGLLHFBNN GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3FF29F0", Offset = "0x3FF17F0", VA = "0x183FF29F0", Slot = "5")]
	public int CompareTo(JDOGLLHFBNN GGINNHLAMLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68A02B0", Offset = "0x689F0B0", VA = "0x1868A02B0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B00", Offset = "0x3FF1900", VA = "0x183FF2B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20")]
	public static bool OFKPFEHPLBH(JDOGLLHFBNN DCJCHFKPCOP, JDOGLLHFBNN IKGIOHGPKCP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x689F260", Offset = "0x689E060", VA = "0x18689F260")]
	public static bool CAAJBKCJNPA(JDOGLLHFBNN DCJCHFKPCOP, JDOGLLHFBNN IKGIOHGPKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x68A0360", Offset = "0x689F160", VA = "0x1868A0360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct CKKKBFEOKEM : IEquatable<CKKKBFEOKEM>, IComparable<CKKKBFEOKEM>, HICMJIEOLDP
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly CKKKBFEOKEM CNCELEPFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid IIGMMHCLOGB;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1E350A0", Offset = "0x1E33EA0", VA = "0x181E350A0")]
	public CKKKBFEOKEM(Guid IIGMMHCLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420", Slot = "6")]
	public Guid DDNIMHOEEID()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20", Slot = "4")]
	public bool Equals(CKKKBFEOKEM GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3FF29F0", Offset = "0x3FF17F0", VA = "0x183FF29F0", Slot = "5")]
	public int CompareTo(CKKKBFEOKEM GGINNHLAMLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x689F3B0", Offset = "0x689E1B0", VA = "0x18689F3B0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B00", Offset = "0x3FF1900", VA = "0x183FF2B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20")]
	public static bool OFKPFEHPLBH(CKKKBFEOKEM DCJCHFKPCOP, CKKKBFEOKEM IKGIOHGPKCP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x689F260", Offset = "0x689E060", VA = "0x18689F260")]
	public static bool CAAJBKCJNPA(CKKKBFEOKEM DCJCHFKPCOP, CKKKBFEOKEM IKGIOHGPKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x689F460", Offset = "0x689E260", VA = "0x18689F460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct AJAHBIADNDL : IEquatable<AJAHBIADNDL>, IComparable<AJAHBIADNDL>, HICMJIEOLDP
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly AJAHBIADNDL CNCELEPFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid IIGMMHCLOGB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JBKDBJHFFJG BJKPIGFHDDO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83F660", Offset = "0x83E460", VA = "0x18083F660")]
		[CompilerGenerated]
		get
		{
			return default(JBKDBJHFFJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JBKDBJHFFJG JPDBLICCIAM
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x104D2F0", Offset = "0x104C0F0", VA = "0x18104D2F0")]
		[CompilerGenerated]
		get
		{
			return default(JBKDBJHFFJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JBKDBJHFFJG LBBCEIDINHI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF0FD30", Offset = "0xF0EB30", VA = "0x180F0FD30")]
		[CompilerGenerated]
		get
		{
			return default(JBKDBJHFFJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420", Slot = "6")]
	public Guid DDNIMHOEEID()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x689F1D0", Offset = "0x689DFD0", VA = "0x18689F1D0")]
	public AJAHBIADNDL(Guid IIGMMHCLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x689F210", Offset = "0x689E010", VA = "0x18689F210")]
	public AJAHBIADNDL(JBKDBJHFFJG OIPLLJGDNLD, JBKDBJHFFJG AECMDECJOOL, JBKDBJHFFJG KHIFOCDKFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x689EFF0", Offset = "0x689DDF0", VA = "0x18689EFF0")]
	private Guid FCFOEDKNODE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x689EF10", Offset = "0x689DD10", VA = "0x18689EF10", Slot = "4")]
	public bool Equals(AJAHBIADNDL GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x689EF40", Offset = "0x689DD40", VA = "0x18689EF40", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B00", Offset = "0x3FF1900", VA = "0x183FF2B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x689F120", Offset = "0x689DF20", VA = "0x18689F120")]
	public static bool OFKPFEHPLBH(AJAHBIADNDL DCJCHFKPCOP, AJAHBIADNDL IKGIOHGPKCP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x689EE90", Offset = "0x689DC90", VA = "0x18689EE90")]
	public static bool CAAJBKCJNPA(AJAHBIADNDL DCJCHFKPCOP, AJAHBIADNDL IKGIOHGPKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x689EED0", Offset = "0x689DCD0", VA = "0x18689EED0", Slot = "5")]
	public int CompareTo(AJAHBIADNDL GGINNHLAMLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x689F160", Offset = "0x689DF60", VA = "0x18689F160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct HAMJFEGHLCG : IEquatable<HAMJFEGHLCG>, IComparable<HAMJFEGHLCG>, HICMJIEOLDP
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly HAMJFEGHLCG CNCELEPFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid IIGMMHCLOGB;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1E350A0", Offset = "0x1E33EA0", VA = "0x181E350A0")]
	public HAMJFEGHLCG(Guid IIGMMHCLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420", Slot = "6")]
	public Guid DDNIMHOEEID()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20", Slot = "4")]
	public bool Equals(HAMJFEGHLCG GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3FF29F0", Offset = "0x3FF17F0", VA = "0x183FF29F0", Slot = "5")]
	public int CompareTo(HAMJFEGHLCG GGINNHLAMLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x689FF50", Offset = "0x689ED50", VA = "0x18689FF50", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B00", Offset = "0x3FF1900", VA = "0x183FF2B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20")]
	public static bool OFKPFEHPLBH(HAMJFEGHLCG DCJCHFKPCOP, HAMJFEGHLCG IKGIOHGPKCP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x689F260", Offset = "0x689E060", VA = "0x18689F260")]
	public static bool CAAJBKCJNPA(HAMJFEGHLCG DCJCHFKPCOP, HAMJFEGHLCG IKGIOHGPKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x68A0000", Offset = "0x689EE00", VA = "0x1868A0000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct BEPKGBHJAIF : IEquatable<BEPKGBHJAIF>, IComparable<BEPKGBHJAIF>, HICMJIEOLDP
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly BEPKGBHJAIF CNCELEPFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid IIGMMHCLOGB;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1E350A0", Offset = "0x1E33EA0", VA = "0x181E350A0")]
	public BEPKGBHJAIF(Guid IIGMMHCLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420", Slot = "6")]
	public Guid DDNIMHOEEID()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20", Slot = "4")]
	public bool Equals(BEPKGBHJAIF GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3FF29F0", Offset = "0x3FF17F0", VA = "0x183FF29F0", Slot = "5")]
	public int CompareTo(BEPKGBHJAIF GGINNHLAMLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x689F290", Offset = "0x689E090", VA = "0x18689F290", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B00", Offset = "0x3FF1900", VA = "0x183FF2B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20")]
	public static bool OFKPFEHPLBH(BEPKGBHJAIF DCJCHFKPCOP, BEPKGBHJAIF IKGIOHGPKCP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x689F260", Offset = "0x689E060", VA = "0x18689F260")]
	public static bool CAAJBKCJNPA(BEPKGBHJAIF DCJCHFKPCOP, BEPKGBHJAIF IKGIOHGPKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x689F340", Offset = "0x689E140", VA = "0x18689F340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct LJOCEFIPDEA : IEquatable<LJOCEFIPDEA>, IComparable<LJOCEFIPDEA>, HICMJIEOLDP
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly LJOCEFIPDEA CNCELEPFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid IIGMMHCLOGB;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1E350A0", Offset = "0x1E33EA0", VA = "0x181E350A0")]
	public LJOCEFIPDEA(Guid IIGMMHCLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420", Slot = "6")]
	public Guid DDNIMHOEEID()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20", Slot = "4")]
	public bool Equals(LJOCEFIPDEA GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3FF29F0", Offset = "0x3FF17F0", VA = "0x183FF29F0", Slot = "5")]
	public int CompareTo(LJOCEFIPDEA GGINNHLAMLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x68A04F0", Offset = "0x689F2F0", VA = "0x1868A04F0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B00", Offset = "0x3FF1900", VA = "0x183FF2B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20")]
	public static bool OFKPFEHPLBH(LJOCEFIPDEA DCJCHFKPCOP, LJOCEFIPDEA IKGIOHGPKCP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x689F260", Offset = "0x689E060", VA = "0x18689F260")]
	public static bool CAAJBKCJNPA(LJOCEFIPDEA DCJCHFKPCOP, LJOCEFIPDEA IKGIOHGPKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x68A05A0", Offset = "0x689F3A0", VA = "0x1868A05A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct KMLPMOPGMKE : IEquatable<KMLPMOPGMKE>, IComparable<KMLPMOPGMKE>, HICMJIEOLDP
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly KMLPMOPGMKE CNCELEPFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid IIGMMHCLOGB;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E350A0", Offset = "0x1E33EA0", VA = "0x181E350A0")]
	public KMLPMOPGMKE(Guid IIGMMHCLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420", Slot = "6")]
	public Guid DDNIMHOEEID()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20", Slot = "4")]
	public bool Equals(KMLPMOPGMKE GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3FF29F0", Offset = "0x3FF17F0", VA = "0x183FF29F0", Slot = "5")]
	public int CompareTo(KMLPMOPGMKE GGINNHLAMLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x68A03D0", Offset = "0x689F1D0", VA = "0x1868A03D0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B00", Offset = "0x3FF1900", VA = "0x183FF2B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20")]
	public static bool OFKPFEHPLBH(KMLPMOPGMKE DCJCHFKPCOP, KMLPMOPGMKE IKGIOHGPKCP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x689F260", Offset = "0x689E060", VA = "0x18689F260")]
	public static bool CAAJBKCJNPA(KMLPMOPGMKE DCJCHFKPCOP, KMLPMOPGMKE IKGIOHGPKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68A0480", Offset = "0x689F280", VA = "0x1868A0480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct PMFBJDCPFFJ : IEquatable<PMFBJDCPFFJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? NMOCJECFLAA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool JODNNLIOIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x68A0780", Offset = "0x689F580", VA = "0x1868A0780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int AFACDBAACOK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA710", Offset = "0x3CB9510", VA = "0x183CBA710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x68A0D80", Offset = "0x689FB80", VA = "0x1868A0D80")]
	public PMFBJDCPFFJ(string? IIBPNFAGAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x68A0D00", Offset = "0x689FB00", VA = "0x1868A0D00")]
	public PMFBJDCPFFJ(string?[] PLIMBPDHOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x68A09E0", Offset = "0x689F7E0", VA = "0x1868A09E0")]
	private static string?[]? JMDINCEAJBJ(string?[]? PLIMBPDHOBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x68A0C10", Offset = "0x689FA10", VA = "0x1868A0C10")]
	public string KHJBHFGICGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68A0830", Offset = "0x689F630", VA = "0x1868A0830", Slot = "4")]
	public bool Equals(PMFBJDCPFFJ GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x68A07A0", Offset = "0x689F5A0", VA = "0x1868A07A0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68A0900", Offset = "0x689F700", VA = "0x1868A0900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x68A0C70", Offset = "0x689FA70", VA = "0x1868A0C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct JBKDBJHFFJG : IEquatable<JBKDBJHFFJG>, IComparable<JBKDBJHFFJG>, HICMJIEOLDP
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly JBKDBJHFFJG CNCELEPFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid IIGMMHCLOGB;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1E350A0", Offset = "0x1E33EA0", VA = "0x181E350A0")]
	public JBKDBJHFFJG(Guid IIGMMHCLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420", Slot = "6")]
	public Guid DDNIMHOEEID()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20", Slot = "4")]
	public bool Equals(JBKDBJHFFJG GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3FF29F0", Offset = "0x3FF17F0", VA = "0x183FF29F0", Slot = "5")]
	public int CompareTo(JBKDBJHFFJG GGINNHLAMLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x68A0190", Offset = "0x689EF90", VA = "0x1868A0190", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B00", Offset = "0x3FF1900", VA = "0x183FF2B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20")]
	public static bool OFKPFEHPLBH(JBKDBJHFFJG DCJCHFKPCOP, JBKDBJHFFJG IKGIOHGPKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x68A0240", Offset = "0x689F040", VA = "0x1868A0240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct FOBOJCDAFNH : IEquatable<FOBOJCDAFNH>, IComparable<FOBOJCDAFNH>, HICMJIEOLDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Guid IIGMMHCLOGB;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1E350A0", Offset = "0x1E33EA0", VA = "0x181E350A0")]
	public FOBOJCDAFNH(Guid IIGMMHCLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420", Slot = "6")]
	public Guid DDNIMHOEEID()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B20", Offset = "0x3FF1920", VA = "0x183FF2B20", Slot = "4")]
	public bool Equals(FOBOJCDAFNH GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3FF29F0", Offset = "0x3FF17F0", VA = "0x183FF29F0", Slot = "5")]
	public int CompareTo(FOBOJCDAFNH GGINNHLAMLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x689FE30", Offset = "0x689EC30", VA = "0x18689FE30", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B00", Offset = "0x3FF1900", VA = "0x183FF2B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x689FEE0", Offset = "0x689ECE0", VA = "0x18689FEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GFONPMAKHCK<TModern> : EBIPLMIELDF<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EGMINIOIIJJ(TModern KIANKECMEKI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HICMJIEOLDP
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid DDNIMHOEEID();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EBIPLMIELDF<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern OFGCMFNDEFH(string KIANKECMEKI);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PGECINMALEK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GFONPMAKHCK<HLJOPPFGADF> PCOMGMAHBGG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GFONPMAKHCK<HAMJFEGHLCG> OBKNPKBCOJP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GFONPMAKHCK<KMLPMOPGMKE> ELCCOJHFCNF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GFONPMAKHCK<AJAHBIADNDL> KKGGBNJIAML
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GFONPMAKHCK<CKKKBFEOKEM> NFDEONEFHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	GFONPMAKHCK<LJOCEFIPDEA> EPLBKGLOBEG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GFONPMAKHCK<JDOGLLHFBNN> AKFPFMAEGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	GFONPMAKHCK<BEPKGBHJAIF> IACHNLLAEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OLJDNKGFKAB
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x68A0690", Offset = "0x689F490", VA = "0x1868A0690")]
	public static string[] GFIOHLNBJFJ(string? IIBPNFAGAAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x68A0750", Offset = "0x689F550", VA = "0x1868A0750")]
	public static string? LANIJMALFEJ(string? FHFLGNJFLFL)
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
