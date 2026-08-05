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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
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
		[Cpp2IlInjected.Address(RVA = "0x6457900", Offset = "0x6456100", VA = "0x186457900")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79CCC0", Offset = "0x79B4C0", VA = "0x18079CCC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79CD00", Offset = "0x79B500", VA = "0x18079CD00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CPDAIDAEFBL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JMOOMJHDBEG(APEKKKOONDF LLJFBBILFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	APEKKKOONDF AEDPLFCAHJC(string LLJFBBILFIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct APEKKKOONDF : IEquatable<APEKKKOONDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly GPGBPBMJAEC JNGBLKGHABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly EJKPOEEPIFD KFJDJHNPCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid JEICIBDKNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? DLGPAIGDFCB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GIPELKAEPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6456200", Offset = "0x6454A00", VA = "0x186456200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KNHBCIELJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64561C0", Offset = "0x64549C0", VA = "0x1864561C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x64566C0", Offset = "0x6454EC0", VA = "0x1864566C0")]
	public APEKKKOONDF(APEKKKOONDF HOMPBFLIDFB, [Optional] Guid MCEJPFELIBJ, [Optional] RRColor? NGHDCCDAAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6456750", Offset = "0x6454F50", VA = "0x186456750")]
	public APEKKKOONDF(GPGBPBMJAEC IPICHBOOHNM, EJKPOEEPIFD GKCPNOIBIGC, [Optional] Guid MCEJPFELIBJ, [Optional] RRColor? NGHDCCDAAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6455F60", Offset = "0x6454760", VA = "0x186455F60", Slot = "4")]
	public bool Equals(APEKKKOONDF FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6455E70", Offset = "0x6454670", VA = "0x186455E70", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x64560D0", Offset = "0x64548D0", VA = "0x1864560D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6456060", Offset = "0x6454860", VA = "0x186456060")]
	public static bool FMFPLPMCDAE(APEKKKOONDF PCIGCGBJFLC, APEKKKOONDF FLACNDCEKPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6455E00", Offset = "0x6454600", VA = "0x186455E00")]
	public static bool EODFGAKKOLK(APEKKKOONDF PCIGCGBJFLC, APEKKKOONDF FLACNDCEKPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x64562C0", Offset = "0x6454AC0", VA = "0x1864562C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct GPGBPBMJAEC : IEquatable<GPGBPBMJAEC>, IComparable<GPGBPBMJAEC>, BJBFBJPAEGE
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly GPGBPBMJAEC NJCGGNOBEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid CLGOKAHLILM;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB780", Offset = "0x1CC9F80", VA = "0x181CCB780")]
	public GPGBPBMJAEC(Guid CLGOKAHLILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
	public Guid LOBKGEDECOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0", Slot = "4")]
	public bool Equals(GPGBPBMJAEC FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x38EC4E0", Offset = "0x38EACE0", VA = "0x1838EC4E0", Slot = "5")]
	public int CompareTo(GPGBPBMJAEC FPJCFKAMJHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6456FA0", Offset = "0x64557A0", VA = "0x186456FA0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x38EC800", Offset = "0x38EB000", VA = "0x1838EC800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0")]
	public static bool FMFPLPMCDAE(GPGBPBMJAEC PCIGCGBJFLC, GPGBPBMJAEC FLACNDCEKPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6455CC0", Offset = "0x64544C0", VA = "0x186455CC0")]
	public static bool EODFGAKKOLK(GPGBPBMJAEC PCIGCGBJFLC, GPGBPBMJAEC FLACNDCEKPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6457040", Offset = "0x6455840", VA = "0x186457040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct FHCEDGBBBEB : IEquatable<FHCEDGBBBEB>, IComparable<FHCEDGBBBEB>, BJBFBJPAEGE
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly FHCEDGBBBEB NJCGGNOBEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid CLGOKAHLILM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB780", Offset = "0x1CC9F80", VA = "0x181CCB780")]
	public FHCEDGBBBEB(Guid CLGOKAHLILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
	public Guid LOBKGEDECOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0", Slot = "4")]
	public bool Equals(FHCEDGBBBEB FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x38EC4E0", Offset = "0x38EACE0", VA = "0x1838EC4E0", Slot = "5")]
	public int CompareTo(FHCEDGBBBEB FPJCFKAMJHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6456DA0", Offset = "0x64555A0", VA = "0x186456DA0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x38EC800", Offset = "0x38EB000", VA = "0x1838EC800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0")]
	public static bool FMFPLPMCDAE(FHCEDGBBBEB PCIGCGBJFLC, FHCEDGBBBEB FLACNDCEKPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6455CC0", Offset = "0x64544C0", VA = "0x186455CC0")]
	public static bool EODFGAKKOLK(FHCEDGBBBEB PCIGCGBJFLC, FHCEDGBBBEB FLACNDCEKPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6456E40", Offset = "0x6455640", VA = "0x186456E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct ANBBBJKNFMM : IEquatable<ANBBBJKNFMM>, IComparable<ANBBBJKNFMM>, BJBFBJPAEGE
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly ANBBBJKNFMM NJCGGNOBEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid CLGOKAHLILM;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB780", Offset = "0x1CC9F80", VA = "0x181CCB780")]
	public ANBBBJKNFMM(Guid CLGOKAHLILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
	public Guid LOBKGEDECOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0", Slot = "4")]
	public bool Equals(ANBBBJKNFMM FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x38EC4E0", Offset = "0x38EACE0", VA = "0x1838EC4E0", Slot = "5")]
	public int CompareTo(ANBBBJKNFMM FPJCFKAMJHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6455CF0", Offset = "0x64544F0", VA = "0x186455CF0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38EC800", Offset = "0x38EB000", VA = "0x1838EC800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0")]
	public static bool FMFPLPMCDAE(ANBBBJKNFMM PCIGCGBJFLC, ANBBBJKNFMM FLACNDCEKPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6455CC0", Offset = "0x64544C0", VA = "0x186455CC0")]
	public static bool EODFGAKKOLK(ANBBBJKNFMM PCIGCGBJFLC, ANBBBJKNFMM FLACNDCEKPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6455D90", Offset = "0x6454590", VA = "0x186455D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct EJKPOEEPIFD : IEquatable<EJKPOEEPIFD>, IComparable<EJKPOEEPIFD>, BJBFBJPAEGE
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly EJKPOEEPIFD NJCGGNOBEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid CLGOKAHLILM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ECBDFHAMFJH CGJGOBAFGCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB2AA00", Offset = "0xB29200", VA = "0x180B2AA00")]
		[CompilerGenerated]
		get
		{
			return default(ECBDFHAMFJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ECBDFHAMFJH CHCIOEFIADP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xEE20B0", Offset = "0xEE08B0", VA = "0x180EE20B0")]
		[CompilerGenerated]
		get
		{
			return default(ECBDFHAMFJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ECBDFHAMFJH HOPDMEMDGDF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDFAB50", Offset = "0xDF9350", VA = "0x180DFAB50")]
		[CompilerGenerated]
		get
		{
			return default(ECBDFHAMFJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
	public Guid LOBKGEDECOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6456D60", Offset = "0x6455560", VA = "0x186456D60")]
	public EJKPOEEPIFD(Guid CLGOKAHLILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6456D10", Offset = "0x6455510", VA = "0x186456D10")]
	public EJKPOEEPIFD(ECBDFHAMFJH DOINFDJABLN, ECBDFHAMFJH MELFKPNLKNP, ECBDFHAMFJH DFNAOFMNOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6456B70", Offset = "0x6455370", VA = "0x186456B70")]
	private Guid JEMEEHEGGPE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF630", Offset = "0x5ECDE30", VA = "0x185ECF630", Slot = "4")]
	public bool Equals(EJKPOEEPIFD FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6456A80", Offset = "0x6455280", VA = "0x186456A80", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x38EC800", Offset = "0x38EB000", VA = "0x1838EC800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6456B30", Offset = "0x6455330", VA = "0x186456B30")]
	public static bool FMFPLPMCDAE(EJKPOEEPIFD PCIGCGBJFLC, EJKPOEEPIFD FLACNDCEKPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6456A40", Offset = "0x6455240", VA = "0x186456A40")]
	public static bool EODFGAKKOLK(EJKPOEEPIFD PCIGCGBJFLC, EJKPOEEPIFD FLACNDCEKPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6456A00", Offset = "0x6455200", VA = "0x186456A00", Slot = "5")]
	public int CompareTo(EJKPOEEPIFD FPJCFKAMJHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6456CA0", Offset = "0x64554A0", VA = "0x186456CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct MPKHIBIDIGE : IEquatable<MPKHIBIDIGE>, IComparable<MPKHIBIDIGE>, BJBFBJPAEGE
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly MPKHIBIDIGE NJCGGNOBEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid CLGOKAHLILM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB780", Offset = "0x1CC9F80", VA = "0x181CCB780")]
	public MPKHIBIDIGE(Guid CLGOKAHLILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
	public Guid LOBKGEDECOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0", Slot = "4")]
	public bool Equals(MPKHIBIDIGE FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x38EC4E0", Offset = "0x38EACE0", VA = "0x1838EC4E0", Slot = "5")]
	public int CompareTo(MPKHIBIDIGE FPJCFKAMJHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x64577F0", Offset = "0x6455FF0", VA = "0x1864577F0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x38EC800", Offset = "0x38EB000", VA = "0x1838EC800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0")]
	public static bool FMFPLPMCDAE(MPKHIBIDIGE PCIGCGBJFLC, MPKHIBIDIGE FLACNDCEKPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6455CC0", Offset = "0x64544C0", VA = "0x186455CC0")]
	public static bool EODFGAKKOLK(MPKHIBIDIGE PCIGCGBJFLC, MPKHIBIDIGE FLACNDCEKPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6457890", Offset = "0x6456090", VA = "0x186457890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct CEPJMPEDIKN : IEquatable<CEPJMPEDIKN>, IComparable<CEPJMPEDIKN>, BJBFBJPAEGE
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly CEPJMPEDIKN NJCGGNOBEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid CLGOKAHLILM;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB780", Offset = "0x1CC9F80", VA = "0x181CCB780")]
	public CEPJMPEDIKN(Guid CLGOKAHLILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
	public Guid LOBKGEDECOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0", Slot = "4")]
	public bool Equals(CEPJMPEDIKN FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x38EC4E0", Offset = "0x38EACE0", VA = "0x1838EC4E0", Slot = "5")]
	public int CompareTo(CEPJMPEDIKN FPJCFKAMJHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x64567E0", Offset = "0x6454FE0", VA = "0x1864567E0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x38EC800", Offset = "0x38EB000", VA = "0x1838EC800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0")]
	public static bool FMFPLPMCDAE(CEPJMPEDIKN PCIGCGBJFLC, CEPJMPEDIKN FLACNDCEKPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6455CC0", Offset = "0x64544C0", VA = "0x186455CC0")]
	public static bool EODFGAKKOLK(CEPJMPEDIKN PCIGCGBJFLC, CEPJMPEDIKN FLACNDCEKPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6456880", Offset = "0x6455080", VA = "0x186456880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct PFBEHLAOOKJ : IEquatable<PFBEHLAOOKJ>, IComparable<PFBEHLAOOKJ>, BJBFBJPAEGE
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly PFBEHLAOOKJ NJCGGNOBEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid CLGOKAHLILM;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB780", Offset = "0x1CC9F80", VA = "0x181CCB780")]
	public PFBEHLAOOKJ(Guid CLGOKAHLILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
	public Guid LOBKGEDECOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0", Slot = "4")]
	public bool Equals(PFBEHLAOOKJ FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x38EC4E0", Offset = "0x38EACE0", VA = "0x1838EC4E0", Slot = "5")]
	public int CompareTo(PFBEHLAOOKJ FPJCFKAMJHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6457A90", Offset = "0x6456290", VA = "0x186457A90", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x38EC800", Offset = "0x38EB000", VA = "0x1838EC800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0")]
	public static bool FMFPLPMCDAE(PFBEHLAOOKJ PCIGCGBJFLC, PFBEHLAOOKJ FLACNDCEKPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6455CC0", Offset = "0x64544C0", VA = "0x186455CC0")]
	public static bool EODFGAKKOLK(PFBEHLAOOKJ PCIGCGBJFLC, PFBEHLAOOKJ FLACNDCEKPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6457B30", Offset = "0x6456330", VA = "0x186457B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct OEOFFPNLGIM : IEquatable<OEOFFPNLGIM>, IComparable<OEOFFPNLGIM>, BJBFBJPAEGE
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly OEOFFPNLGIM NJCGGNOBEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid CLGOKAHLILM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB780", Offset = "0x1CC9F80", VA = "0x181CCB780")]
	public OEOFFPNLGIM(Guid CLGOKAHLILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
	public Guid LOBKGEDECOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0", Slot = "4")]
	public bool Equals(OEOFFPNLGIM FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x38EC4E0", Offset = "0x38EACE0", VA = "0x1838EC4E0", Slot = "5")]
	public int CompareTo(OEOFFPNLGIM FPJCFKAMJHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6457980", Offset = "0x6456180", VA = "0x186457980", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x38EC800", Offset = "0x38EB000", VA = "0x1838EC800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0")]
	public static bool FMFPLPMCDAE(OEOFFPNLGIM PCIGCGBJFLC, OEOFFPNLGIM FLACNDCEKPB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6455CC0", Offset = "0x64544C0", VA = "0x186455CC0")]
	public static bool EODFGAKKOLK(OEOFFPNLGIM PCIGCGBJFLC, OEOFFPNLGIM FLACNDCEKPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6457A20", Offset = "0x6456220", VA = "0x186457A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct LKFKHDAJLCP : IEquatable<LKFKHDAJLCP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? MEKBBDNPGCL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KODPMDJOGAN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x64570B0", Offset = "0x64558B0", VA = "0x1864570B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int OPFHIMAEFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE780", Offset = "0x3ABCF80", VA = "0x183ABE780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x64576B0", Offset = "0x6455EB0", VA = "0x1864576B0")]
	public LKFKHDAJLCP(string? GECKBHBLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6457630", Offset = "0x6455E30", VA = "0x186457630")]
	public LKFKHDAJLCP(string?[] JGPHOPPKCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6457370", Offset = "0x6455B70", VA = "0x186457370")]
	private static string?[]? NFOJAHALNGG(string?[]? JGPHOPPKCCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x64570D0", Offset = "0x64558D0", VA = "0x1864570D0")]
	public string DDCMBFICIOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6457130", Offset = "0x6455930", VA = "0x186457130", Slot = "4")]
	public bool Equals(LKFKHDAJLCP FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6457200", Offset = "0x6455A00", VA = "0x186457200", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6457290", Offset = "0x6455A90", VA = "0x186457290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x64575A0", Offset = "0x6455DA0", VA = "0x1864575A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct ECBDFHAMFJH : IEquatable<ECBDFHAMFJH>, IComparable<ECBDFHAMFJH>, BJBFBJPAEGE
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly ECBDFHAMFJH NJCGGNOBEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid CLGOKAHLILM;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB780", Offset = "0x1CC9F80", VA = "0x181CCB780")]
	public ECBDFHAMFJH(Guid CLGOKAHLILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
	public Guid LOBKGEDECOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0", Slot = "4")]
	public bool Equals(ECBDFHAMFJH FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x38EC4E0", Offset = "0x38EACE0", VA = "0x1838EC4E0", Slot = "5")]
	public int CompareTo(ECBDFHAMFJH FPJCFKAMJHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x64568F0", Offset = "0x64550F0", VA = "0x1864568F0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x38EC800", Offset = "0x38EB000", VA = "0x1838EC800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9B0", Offset = "0x38EB1B0", VA = "0x1838EC9B0")]
	public static bool FMFPLPMCDAE(ECBDFHAMFJH PCIGCGBJFLC, ECBDFHAMFJH FLACNDCEKPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6456990", Offset = "0x6455190", VA = "0x186456990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EKNKLLIPBDM<TModern> : IAILMIGDJLD<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CDEBJONCHBJ(TModern HGALEAKJCPA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BJBFBJPAEGE
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid LOBKGEDECOM();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IAILMIGDJLD<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern PECFGPJGKNM(string HGALEAKJCPA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NMFFAPBEOHA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	EKNKLLIPBDM<GPGBPBMJAEC> JBPDGIMBHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	EKNKLLIPBDM<MPKHIBIDIGE> BCEGLGIMEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EKNKLLIPBDM<OEOFFPNLGIM> KINHEMLPBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EKNKLLIPBDM<EJKPOEEPIFD> ILFCIMMEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EKNKLLIPBDM<ANBBBJKNFMM> BGHPHDOLAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	EKNKLLIPBDM<PFBEHLAOOKJ> CLODADGGMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	EKNKLLIPBDM<FHCEDGBBBEB> MDCLKAEPPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	EKNKLLIPBDM<CEPJMPEDIKN> BDPBCJNNLFK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FJIBMGMOFOI
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6456EB0", Offset = "0x64556B0", VA = "0x186456EB0")]
	public static string[] AAELJJNACNH(string? GECKBHBLPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6456F70", Offset = "0x6455770", VA = "0x186456F70")]
	public static string? KHNOHMAPDFK(string? IPICHBOOHNM)
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
