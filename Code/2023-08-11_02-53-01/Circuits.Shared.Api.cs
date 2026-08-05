using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F16BF0", Offset = "0x6F153F0", VA = "0x186F16BF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EEC40", Offset = "0x7ED440", VA = "0x1807EEC40")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA14660", Offset = "0xA12E60", VA = "0x180A14660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum IOKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Input,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Output
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public readonly struct MMFKEOMPKBP<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly T[] AAOCPBGNLKE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F0E90", Offset = "0x6F0290")]
	public JIGIFEGHNPP<M> HOBKBMKCCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x23ADFF0", Offset = "0x23AC7F0", VA = "0x1823ADFF0")]
		get
		{
			return default(JIGIFEGHNPP<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int EGAMNLBINDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x23ADF60", Offset = "0x23AC760", VA = "0x1823ADF60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1CA1530", Offset = "0x1C9FD30", VA = "0x181CA1530")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x9E4D50", Offset = "0x9E3550", VA = "0x1809E4D50")]
	internal MMFKEOMPKBP(T[] DLLMPOAIBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x23AE080", Offset = "0x23AC880", VA = "0x1823AE080")]
	public static MMFKEOMPKBP<M, T> NKAIHPJAMOL(int AKLMFDJHPFM)
	{
		return default(MMFKEOMPKBP<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
	public IEnumerable<T> NPKOLIGLOEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x23ADF80", Offset = "0x23AC780", VA = "0x1823ADF80")]
	public BHOOABHAPCP<M, T> JECEKLAOPAG()
	{
		return default(BHOOABHAPCP<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x23ADEE0", Offset = "0x23AC6E0", VA = "0x1823ADEE0")]
	public IEnumerator<T> GAACJCPNEFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x23AE110", Offset = "0x23AC910", VA = "0x1823AE110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NPLPLBPFAPD<M>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x12A5330", Offset = "0x12A3B30", VA = "0x1812A5330")]
	public static MMFKEOMPKBP<M, T> POJNDFFPKOB<T>(params T[] DLLMPOAIBGN) where T : notnull
	{
		return default(MMFKEOMPKBP<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IBLGKGBAEEE
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x23ADE60", Offset = "0x23AC660", VA = "0x1823ADE60")]
	public static T? MOOHLFEKHJG<T, M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F0F30", Offset = "0x6F0330")] this ref MMFKEOMPKBP<M?, T?> PECDBPPMOJP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F0F90", Offset = "0x6F0390")] JIGIFEGHNPP<M?> NLNOELCPLOI)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1CA5AE0", Offset = "0x1CA42E0", VA = "0x181CA5AE0")]
	public static void OLFLGMGEIBD<M, T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F0FF0", Offset = "0x6F03F0")] this ref MMFKEOMPKBP<M?, T?> PECDBPPMOJP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1050", Offset = "0x6F0450")] JIGIFEGHNPP<M?> NLNOELCPLOI, in T MENBIMCLIOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IPFCHCAJIKF
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FBEBNCKOPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct JOHDMLNNNLC : IEquatable<JOHDMLNNNLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float EODCFKPILEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float DPLPODBGMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly float MMBJGEJFFJN;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly JOHDMLNNNLC BGDGDJGCJKJ;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly JOHDMLNNNLC FEMEKBLLDGK;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly JOHDMLNNNLC OMLPMEAKFGF;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly JOHDMLNNNLC GMPHPPEBJPP;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly JOHDMLNNNLC GEPFNBLCDKL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly JOHDMLNNNLC MPKHHKNMALM;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly JOHDMLNNNLC PIOCDDBNNJO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly JOHDMLNNNLC CMIMFKALPED;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly JOHDMLNNNLC EIEMPIDMAOP;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly JOHDMLNNNLC HKGNGAOFDJK;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly JOHDMLNNNLC LOCBDNHDKDH;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly JOHDMLNNNLC ELFGMLGMMPH;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly JOHDMLNNNLC HLLGKKLGNPH;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly JOHDMLNNNLC JBLCPIEEGBA;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly JOHDMLNNNLC LKJCENHCNBJ;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly JOHDMLNNNLC EJDKBCIOCMG;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly JOHDMLNNNLC OACBCEKDDMO;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x45BF620", Offset = "0x45BDE20", VA = "0x1845BF620")]
	public JOHDMLNNNLC(float FBGKLELIKCG, float LFJEFFKGLOE, float BIMMIEECIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F16110", Offset = "0x6F14910", VA = "0x186F16110")]
	public static JOHDMLNNNLC NKAIHPJAMOL(float FBGKLELIKCG, float LFJEFFKGLOE, float BIMMIEECIFM)
	{
		return default(JOHDMLNNNLC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F160E0", Offset = "0x6F148E0", VA = "0x186F160E0")]
	public static bool MJNLEMCBPOF(in JOHDMLNNNLC BENALFHNIOG, in JOHDMLNNNLC EMAOEIAIOHA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F15E70", Offset = "0x6F14670", VA = "0x186F15E70")]
	public static bool ACJEIIDJLOL(in JOHDMLNNNLC BENALFHNIOG, in JOHDMLNNNLC EMAOEIAIOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F16070", Offset = "0x6F14870", VA = "0x186F16070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F15F90", Offset = "0x6F14790", VA = "0x186F15F90", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F16130", Offset = "0x6F14930", VA = "0x186F16130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F15F00", Offset = "0x6F14700", VA = "0x186F15F00", Slot = "4")]
	public bool Equals(JOHDMLNNNLC OALEAAIPGBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct NBGMGGOIOJB : IEquatable<NBGMGGOIOJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IOEJAOKEBMJ FFPDIIGFDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly JOHDMLNNNLC GPDFMICFPDN;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly NBGMGGOIOJB LEJAENOLDPH;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F16BD0", Offset = "0x6F153D0", VA = "0x186F16BD0")]
	public NBGMGGOIOJB(in IOEJAOKEBMJ APAHFEOKBOD, in JOHDMLNNNLC PAOMABBDKAH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F16970", Offset = "0x6F15170", VA = "0x186F16970")]
	public static bool MJNLEMCBPOF(in NBGMGGOIOJB BENALFHNIOG, in NBGMGGOIOJB EMAOEIAIOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F168E0", Offset = "0x6F150E0", VA = "0x186F168E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6F167A0", Offset = "0x6F14FA0", VA = "0x186F167A0", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F16A60", Offset = "0x6F15260", VA = "0x186F16A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F16870", Offset = "0x6F15070", VA = "0x186F16870", Slot = "4")]
	public bool Equals(NBGMGGOIOJB OALEAAIPGBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct JIGIFEGHNPP<TMarker> : IEquatable<JIGIFEGHNPP<TMarker>>, PKABNOGAKFM<JIGIFEGHNPP<TMarker>>, IComparable<JIGIFEGHNPP<TMarker>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly int BONGNCOBHFB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1400", Offset = "0x6F0800")]
	public JIGIFEGHNPP<TMarker> HKNPIAMEEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2C53E10", Offset = "0x2C52610", VA = "0x182C53E10")]
		get
		{
			return default(JIGIFEGHNPP<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1460", Offset = "0x6F0860")]
	public JIGIFEGHNPP<TMarker> EFHOAGAIAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2C53EA0", Offset = "0x2C526A0", VA = "0x182C53EA0")]
		get
		{
			return default(JIGIFEGHNPP<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xB1A5C0", Offset = "0xB18DC0", VA = "0x180B1A5C0")]
	public JIGIFEGHNPP(int MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2D60020", Offset = "0x2D5E820", VA = "0x182D60020")]
	public JIGIFEGHNPP<TOther> KODCOOMOBPF<TOther>() where TOther : TMarker
	{
		return default(JIGIFEGHNPP<TOther>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xB1A680", Offset = "0xB18E80", VA = "0x180B1A680")]
	public int CLIBMONIMNB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2C53F50", Offset = "0x2C52750", VA = "0x182C53F50")]
	public bool OCGDGBEGKOE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F10E0", Offset = "0x6F04E0")] in JIGIFEGHNPP<TMarker> OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2C53DC0", Offset = "0x2C525C0", VA = "0x182C53DC0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1150", Offset = "0x6F0550")] JIGIFEGHNPP<TMarker> OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x20898E0", Offset = "0x20880E0", VA = "0x1820898E0", Slot = "0")]
	public override bool Equals(object OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2C53DA0", Offset = "0x2C525A0", VA = "0x182C53DA0", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F11B0", Offset = "0x6F05B0")] JIGIFEGHNPP<TMarker> OALEAAIPGBP)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2C53F10", Offset = "0x2C52710", VA = "0x182C53F10")]
	public static bool MJNLEMCBPOF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1210", Offset = "0x6F0610")] JIGIFEGHNPP<TMarker> KJDIMBCAJIJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1270", Offset = "0x6F0670")] JIGIFEGHNPP<TMarker> EAIBHFHJJFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2C53D00", Offset = "0x2C52500", VA = "0x182C53D00")]
	public static bool ACJEIIDJLOL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F12D0", Offset = "0x6F06D0")] JIGIFEGHNPP<TMarker> KJDIMBCAJIJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1330", Offset = "0x6F0730")] JIGIFEGHNPP<TMarker> EAIBHFHJJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2C53E80", Offset = "0x2C52680", VA = "0x182C53E80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2C53F70", Offset = "0x2C52770", VA = "0x182C53F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2C53D50", Offset = "0x2C52550", VA = "0x182C53D50", Slot = "5")]
	private bool BKIFGEHMIAP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1390", Offset = "0x6F0790")] in JIGIFEGHNPP<TMarker> OALEAAIPGBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HECNADAMMPA
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1CB1700", Offset = "0x1CAFF00", VA = "0x181CB1700")]
	public static JIGIFEGHNPP<TMarker?> PEEBBFJFCLB<TMarker>(this int PECDBPPMOJP)
	{
		return default(JIGIFEGHNPP<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1CB1700", Offset = "0x1CAFF00", VA = "0x181CB1700")]
	public static JIGIFEGHNPP<TMarker?> GJBNDIELPNJ<TMarker>(this int PECDBPPMOJP)
	{
		return default(JIGIFEGHNPP<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1CB16C0", Offset = "0x1CAFEC0", VA = "0x181CB16C0")]
	public static EBGAKOKEMCO<JIGIFEGHNPP<TMarker?>, PLOEPLMJHFE<TMarker?>> FONJHHLNBIF<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1500", Offset = "0x6F0900")] JIGIFEGHNPP<TMarker?> EMJMAOLEMCO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1560", Offset = "0x6F0960")] JIGIFEGHNPP<TMarker?> IKBIKALHOOO)
	{
		return default(EBGAKOKEMCO<JIGIFEGHNPP<TMarker>, PLOEPLMJHFE<TMarker>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1CB1730", Offset = "0x1CAFF30", VA = "0x181CB1730")]
	public static EBGAKOKEMCO<JIGIFEGHNPP<TMarker?>, PLOEPLMJHFE<TMarker?>> MKEOAHDFHCA<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F15C0", Offset = "0x6F09C0")] JIGIFEGHNPP<TMarker?> IKBIKALHOOO)
	{
		return default(EBGAKOKEMCO<JIGIFEGHNPP<TMarker>, PLOEPLMJHFE<TMarker>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class EBGEBJIOKJK<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1F61640", Offset = "0x1F5FE40", VA = "0x181F61640")]
	public static JIGIFEGHNPP<TOther> DKLMOCPHAHP<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1620", Offset = "0x6F0A20")] JIGIFEGHNPP<TMarker> PECDBPPMOJP) where TMarker : TOther
	{
		return default(JIGIFEGHNPP<TOther>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BHNPGCBKCIC
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IPFCHCAJIKF CCEIAKBKAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HLLHAHJADCA
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2A1E770", Offset = "0x2A1CF70", VA = "0x182A1E770")]
	public static bool IBEHCNLLCJM<TSelf>(this TSelf PECDBPPMOJP) where TSelf : notnull, BHNPGCBKCIC
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PLOEPLMJHFE<M> : IEnumerator<JIGIFEGHNPP<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly int LLDDHDPKGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly int NEIIHFBKAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int KBKCHAFCPLJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1680", Offset = "0x6F0A80")]
	public readonly JIGIFEGHNPP<M> PDEEINOIIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2852420", Offset = "0x2850C20", VA = "0x182852420", Slot = "4")]
		get
		{
			return default(JIGIFEGHNPP<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2852340", Offset = "0x2850B40", VA = "0x182852340", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xD99510", Offset = "0xD97D10", VA = "0x180D99510")]
	internal PLOEPLMJHFE(int NDJHOCHOCAL, int IKBIKALHOOO, int CKBMPMDFJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
	public readonly void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2852320", Offset = "0x2850B20", VA = "0x182852320", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2852330", Offset = "0x2850B30", VA = "0x182852330", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LCEOPNGGCEC
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1DA28E0", Offset = "0x1DA10E0", VA = "0x181DA28E0")]
	public static PLOEPLMJHFE<M?> NKAIHPJAMOL<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1740", Offset = "0x6F0B40")] JIGIFEGHNPP<M?> EMJMAOLEMCO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F17A0", Offset = "0x6F0BA0")] JIGIFEGHNPP<M?> IKBIKALHOOO)
	{
		return default(PLOEPLMJHFE<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1DA2860", Offset = "0x1DA1060", VA = "0x181DA2860")]
	public static EBGAKOKEMCO<JIGIFEGHNPP<M?>, PLOEPLMJHFE<M?>> JMEMKPFHGGL<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1800", Offset = "0x6F0C00")] JIGIFEGHNPP<M?> EMJMAOLEMCO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1860", Offset = "0x6F0C60")] JIGIFEGHNPP<M?> IKBIKALHOOO)
	{
		return default(EBGAKOKEMCO<JIGIFEGHNPP<M>, PLOEPLMJHFE<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct HGFOLPAOJKD<M> : IEnumerator<JIGIFEGHNPP<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly int LAHBBMDGKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int KBKCHAFCPLJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F18C0", Offset = "0x6F0CC0")]
	public readonly JIGIFEGHNPP<M> PDEEINOIIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x29A14C0", Offset = "0x299FCC0", VA = "0x1829A14C0", Slot = "4")]
		get
		{
			return default(JIGIFEGHNPP<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x29A1430", Offset = "0x299FC30", VA = "0x1829A1430", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xAB38B0", Offset = "0xAB20B0", VA = "0x180AB38B0")]
	private HGFOLPAOJKD(int JMKNAPEFDDB, int CKBMPMDFJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x29A13E0", Offset = "0x299FBE0", VA = "0x1829A13E0")]
	public static HGFOLPAOJKD<M> KAEBGOFGGAD(int JMKNAPEFDDB)
	{
		return default(HGFOLPAOJKD<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x29A1410", Offset = "0x299FC10", VA = "0x1829A1410", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x29A1420", Offset = "0x299FC20", VA = "0x1829A1420", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LGPNFJFNMJP
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F16470", Offset = "0x6F14C70", VA = "0x186F16470")]
	public static BFLEABKDAJC CLIBMONIMNB(this in JOHDMLNNNLC PECDBPPMOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F165E0", Offset = "0x6F14DE0", VA = "0x186F165E0")]
	public static JOHDMLNNNLC KLHPMPNNHAA(this BFLEABKDAJC PECDBPPMOJP)
	{
		return default(JOHDMLNNNLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F16500", Offset = "0x6F14D00", VA = "0x186F16500")]
	public static BFLEABKDAJC? EJCACIJGFNN(this in JOHDMLNNNLC? PECDBPPMOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F166A0", Offset = "0x6F14EA0", VA = "0x186F166A0")]
	public static JOHDMLNNNLC? NBGEJGGEDAO(this BFLEABKDAJC? PECDBPPMOJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct GKDFBGMIKKM<TMarker> : IEquatable<GKDFBGMIKKM<TMarker>>, PKABNOGAKFM<GKDFBGMIKKM<TMarker>>, IComparable<GKDFBGMIKKM<TMarker>> where TMarker : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Guid JMIPHCGDMAI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1D00", Offset = "0x6F1100")]
	public static GKDFBGMIKKM<TMarker> GMPFDGPOJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x20897E0", Offset = "0x2087FE0", VA = "0x1820897E0")]
		get
		{
			return default(GKDFBGMIKKM<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1D70", Offset = "0x6F1170")]
	public static GKDFBGMIKKM<TMarker>? BLGELENGKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2089980", Offset = "0x2088180", VA = "0x182089980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2089BA0", Offset = "0x20883A0", VA = "0x182089BA0")]
	public GKDFBGMIKKM(in Guid MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2089620", Offset = "0x2087E20", VA = "0x182089620")]
	public FLDHODHNOEG? CLIBMONIMNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2089A80", Offset = "0x2088280", VA = "0x182089A80")]
	public bool OCGDGBEGKOE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F19A0", Offset = "0x6F0DA0")] in GKDFBGMIKKM<TMarker> OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2089760", Offset = "0x2087F60", VA = "0x182089760", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1A10", Offset = "0x6F0E10")] GKDFBGMIKKM<TMarker> OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x20898E0", Offset = "0x20880E0", VA = "0x1820898E0", Slot = "0")]
	public override bool Equals(object OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x20897B0", Offset = "0x2087FB0", VA = "0x1820897B0", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1A70", Offset = "0x6F0E70")] GKDFBGMIKKM<TMarker> OALEAAIPGBP)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2089760", Offset = "0x2087F60", VA = "0x182089760")]
	public static bool MJNLEMCBPOF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1AD0", Offset = "0x6F0ED0")] in GKDFBGMIKKM<TMarker> KJDIMBCAJIJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1B40", Offset = "0x6F0F40")] in GKDFBGMIKKM<TMarker> EAIBHFHJJFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x20895C0", Offset = "0x2087DC0", VA = "0x1820895C0")]
	public static bool ACJEIIDJLOL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1BB0", Offset = "0x6F0FB0")] in GKDFBGMIKKM<TMarker> KJDIMBCAJIJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1C20", Offset = "0x6F1020")] in GKDFBGMIKKM<TMarker> EAIBHFHJJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2089960", Offset = "0x2088160", VA = "0x182089960", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2089AB0", Offset = "0x20882B0", VA = "0x182089AB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2089760", Offset = "0x2087F60", VA = "0x182089760", Slot = "5")]
	private bool CPPBPOCJBLM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1C90", Offset = "0x6F1090")] in GKDFBGMIKKM<TMarker> OALEAAIPGBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KPOFKEEOHJP
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1D9C800", Offset = "0x1D9B000", VA = "0x181D9C800")]
	public static GKDFBGMIKKM<TMarker?> KLHPMPNNHAA<TMarker>(this FLDHODHNOEG? PECDBPPMOJP)
	{
		return default(GKDFBGMIKKM<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1D9C8E0", Offset = "0x1D9B0E0", VA = "0x181D9C8E0")]
	public static GKDFBGMIKKM<TMarker?> PEEBBFJFCLB<TMarker>(this in Guid PECDBPPMOJP)
	{
		return default(GKDFBGMIKKM<TMarker>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class LNFNCFOIDBB<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1E20", Offset = "0x6F1220")]
	internal static readonly GKDFBGMIKKM<TOther> GMPFDGPOJIJ;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1E80", Offset = "0x6F1280")]
	internal static readonly GKDFBGMIKKM<TOther>? BLGELENGKLM;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public readonly struct BHOOABHAPCP<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F1F50", Offset = "0x6F1350")]
	private readonly GBHIAEEONNH<T> AAOCPBGNLKE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F2070", Offset = "0x6F1470")]
	public JIGIFEGHNPP<M> HOBKBMKCCBO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2199FF0", Offset = "0x21987F0", VA = "0x182199FF0")]
		get
		{
			return default(JIGIFEGHNPP<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int EGAMNLBINDF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2199FB0", Offset = "0x21987B0", VA = "0x182199FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2199F20", Offset = "0x2198720", VA = "0x182199F20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2030410", Offset = "0x202EC10", VA = "0x182030410")]
	internal BHOOABHAPCP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F2010", Offset = "0x6F1410")] GBHIAEEONNH<T> DLLMPOAIBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2110010", Offset = "0x210E810", VA = "0x182110010")]
	public IEnumerable<T> NPKOLIGLOEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2199F70", Offset = "0x2198770", VA = "0x182199F70")]
	public IEnumerator<T> GAACJCPNEFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x219A0B0", Offset = "0x21988B0", VA = "0x18219A0B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class KNCEPFLPDHM<M>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2D62EA0", Offset = "0x2D616A0", VA = "0x182D62EA0")]
	public static BHOOABHAPCP<M, T> POJNDFFPKOB<T>(params T[] DLLMPOAIBGN) where T : notnull
	{
		return default(BHOOABHAPCP<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class FHFODFHAMHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6F154C0", Offset = "0x6F13CC0", VA = "0x186F154C0")]
	public static JGHAOCNOPDO CLIBMONIMNB(this in IOEJAOKEBMJ PECDBPPMOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F15650", Offset = "0x6F13E50", VA = "0x186F15650")]
	public static IOEJAOKEBMJ KLHPMPNNHAA(this JGHAOCNOPDO PECDBPPMOJP)
	{
		return default(IOEJAOKEBMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F15560", Offset = "0x6F13D60", VA = "0x186F15560")]
	public static JGHAOCNOPDO? EJCACIJGFNN(this in IOEJAOKEBMJ? PECDBPPMOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F15740", Offset = "0x6F13F40", VA = "0x186F15740")]
	public static IOEJAOKEBMJ? NBGEJGGEDAO(this JGHAOCNOPDO? PECDBPPMOJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct IOEJAOKEBMJ : IEquatable<IOEJAOKEBMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly float EODCFKPILEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly float DPLPODBGMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly float MMBJGEJFFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly float GLBEEKGPPPK;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly IOEJAOKEBMJ LEJAENOLDPH;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly IOEJAOKEBMJ OMLPMEAKFGF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IOEJAOKEBMJ GMPHPPEBJPP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly IOEJAOKEBMJ GEPFNBLCDKL;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly IOEJAOKEBMJ MPKHHKNMALM;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x20DA850", Offset = "0x20D9050", VA = "0x1820DA850")]
	public IOEJAOKEBMJ(float FBGKLELIKCG, float LFJEFFKGLOE, float BIMMIEECIFM, float BBDFFBIEBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F15B50", Offset = "0x6F14350", VA = "0x186F15B50")]
	public static IOEJAOKEBMJ NKAIHPJAMOL(float FBGKLELIKCG, float LFJEFFKGLOE, float BIMMIEECIFM, float BBDFFBIEBJH)
	{
		return default(IOEJAOKEBMJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0B50", Offset = "0x5DCF350", VA = "0x185DD0B50")]
	public static bool MJNLEMCBPOF(in IOEJAOKEBMJ BENALFHNIOG, in IOEJAOKEBMJ EMAOEIAIOHA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F15890", Offset = "0x6F14090", VA = "0x186F15890")]
	public static bool ACJEIIDJLOL(in IOEJAOKEBMJ BENALFHNIOG, in IOEJAOKEBMJ EMAOEIAIOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F15AB0", Offset = "0x6F142B0", VA = "0x186F15AB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F15930", Offset = "0x6F14130", VA = "0x186F15930", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F15B70", Offset = "0x6F14370", VA = "0x186F15B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F15A10", Offset = "0x6F14210", VA = "0x186F15A10", Slot = "4")]
	public bool Equals(IOEJAOKEBMJ OALEAAIPGBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct APPACPHBIIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly float LFONLHGFOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly float IJPBFDPDMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly float OHALAINPNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly float INBECDBOBLL;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly APPACPHBIIO DPJHKEIEOBK;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly APPACPHBIIO EDCCBAGLBPA;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x20DA850", Offset = "0x20D9050", VA = "0x1820DA850")]
	public APPACPHBIIO(float LIOFIIHFDDK, float NJFNGGFAOMN, float NBEGIGNBOIE, float MBLAPCMEEGI)
	{
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
