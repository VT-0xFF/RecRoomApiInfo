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
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FE2790", Offset = "0x6FE0D90", VA = "0x186FE2790")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x986BA0", Offset = "0x9851A0", VA = "0x180986BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x11F2200", Offset = "0x11F0800", VA = "0x1811F2200")]
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
public readonly struct LLGEOEEHMEJ<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly T[] FHFDNILHCJD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FCB00", Offset = "0x6FBF00")]
	public LFFHALFGHGE<M> JFHEJCIOGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28D0EC0", Offset = "0x28CF4C0", VA = "0x1828D0EC0")]
		get
		{
			return default(LFFHALFGHGE<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ALHMBJNHGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x179AB70", Offset = "0x1799170", VA = "0x18179AB70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x179AD10", Offset = "0x1799310", VA = "0x18179AD10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x9C1FF0", Offset = "0x9C05F0", VA = "0x1809C1FF0")]
	internal LLGEOEEHMEJ(T[] IACDCADJJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x28D0FD0", Offset = "0x28CF5D0", VA = "0x1828D0FD0")]
	public static LLGEOEEHMEJ<M, T> OGNDBCBGIDA(int BFDDLCIBNMB)
	{
		return default(LLGEOEEHMEJ<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000")]
	public IEnumerable<T> ILPCFMACGJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x28D1060", Offset = "0x28CF660", VA = "0x1828D1060")]
	public BNJEIPJOCHH<M, T> POBOICFMIPP()
	{
		return default(BNJEIPJOCHH<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x28D0F50", Offset = "0x28CF550", VA = "0x1828D0F50")]
	public IEnumerator<T> FGHGHABHEPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x28D10D0", Offset = "0x28CF6D0", VA = "0x1828D10D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KOCHGDFHEGN<M>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x19F4EC0", Offset = "0x19F34C0", VA = "0x1819F4EC0")]
	public static LLGEOEEHMEJ<M, T> DIOJELLCEHC<T>(params T[] IACDCADJJAN) where T : notnull
	{
		return default(LLGEOEEHMEJ<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class POECFGNABFD
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x179AD10", Offset = "0x1799310", VA = "0x18179AD10")]
	public static T? BJALLOEIMBB<T, M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FCBA0", Offset = "0x6FBFA0")] this ref LLGEOEEHMEJ<M?, T?> CDBMADFDGCE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FCC00", Offset = "0x6FC000")] LFFHALFGHGE<M?> GPAKLECDLDD)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2312B10", Offset = "0x2311110", VA = "0x182312B10")]
	public static void FGMAFKALEHD<M, T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FCC60", Offset = "0x6FC060")] this ref LLGEOEEHMEJ<M?, T?> CDBMADFDGCE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FCCC0", Offset = "0x6FC0C0")] LFFHALFGHGE<M?> GPAKLECDLDD, in T MOLEJFDINLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IFJCOEAPEFE
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MJOAAEMFFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct JLPKIKAFHCH : IEquatable<JLPKIKAFHCH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float LKOKDECNICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float GCCGPGCHMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly float OPGCHHHBDFG;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly JLPKIKAFHCH DKCFBGABLIK;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly JLPKIKAFHCH CFNFCGCINCE;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly JLPKIKAFHCH KLALHPOLMAD;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly JLPKIKAFHCH DLNHABMOIAH;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly JLPKIKAFHCH JCJBHJDEPFJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly JLPKIKAFHCH EHKJJHLEDMM;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly JLPKIKAFHCH CHJHPMJKNBH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly JLPKIKAFHCH NDBBBANJFPH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly JLPKIKAFHCH BBOIAHAFICM;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly JLPKIKAFHCH EGLMDJIPICE;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly JLPKIKAFHCH GGKLBGPEINO;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly JLPKIKAFHCH DAPKIFPFCNH;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly JLPKIKAFHCH OAOCMAHMBOJ;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly JLPKIKAFHCH NNEADEAGLPM;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly JLPKIKAFHCH OKPEBEMNNNI;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly JLPKIKAFHCH OMBDPFIFLLF;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly JLPKIKAFHCH GJCGOKHGJGF;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4632670", Offset = "0x4630C70", VA = "0x184632670")]
	public JLPKIKAFHCH(float HEICJNINGBE, float DNLDNFFNIEF, float EGEKNHJPNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1F80", Offset = "0x6FE0580", VA = "0x186FE1F80")]
	public static JLPKIKAFHCH OGNDBCBGIDA(float HEICJNINGBE, float DNLDNFFNIEF, float EGEKNHJPNPL)
	{
		return default(JLPKIKAFHCH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1CE0", Offset = "0x6FE02E0", VA = "0x186FE1CE0")]
	public static bool BDIEMMGDBNG(in JLPKIKAFHCH MBOGNALMNPH, in JLPKIKAFHCH NDCLMFPKHPF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1EF0", Offset = "0x6FE04F0", VA = "0x186FE1EF0")]
	public static bool HGHCMFFFPIK(in JLPKIKAFHCH MBOGNALMNPH, in JLPKIKAFHCH NDCLMFPKHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1E80", Offset = "0x6FE0480", VA = "0x186FE1E80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1DA0", Offset = "0x6FE03A0", VA = "0x186FE1DA0", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1FA0", Offset = "0x6FE05A0", VA = "0x186FE1FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1D10", Offset = "0x6FE0310", VA = "0x186FE1D10", Slot = "4")]
	public bool Equals(JLPKIKAFHCH FKJGPCABBJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct KCGJJJGDPIJ : IEquatable<KCGJJJGDPIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly ANPHIDGEMNH MDHIEOKKOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly JLPKIKAFHCH COAPMMCMFID;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly KCGJJJGDPIJ LKKJNALFBLK;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2710", Offset = "0x6FE0D10", VA = "0x186FE2710")]
	public KCGJJJGDPIJ(in ANPHIDGEMNH MEHKCJCIOOL, in JLPKIKAFHCH POOFJFBIOJJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE22E0", Offset = "0x6FE08E0", VA = "0x186FE22E0")]
	public static bool BDIEMMGDBNG(in KCGJJJGDPIJ MBOGNALMNPH, in KCGJJJGDPIJ NDCLMFPKHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2510", Offset = "0x6FE0B10", VA = "0x186FE2510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2440", Offset = "0x6FE0A40", VA = "0x186FE2440", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE25A0", Offset = "0x6FE0BA0", VA = "0x186FE25A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6FE23D0", Offset = "0x6FE09D0", VA = "0x186FE23D0", Slot = "4")]
	public bool Equals(KCGJJJGDPIJ FKJGPCABBJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct LFFHALFGHGE<TMarker> : IEquatable<LFFHALFGHGE<TMarker>>, BIMCIIHFHMF<LFFHALFGHGE<TMarker>>, IComparable<LFFHALFGHGE<TMarker>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly int AEPFKILGMHM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD070", Offset = "0x6FC470")]
	public LFFHALFGHGE<TMarker> LEMPBCPLEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2634CD0", Offset = "0x26332D0", VA = "0x182634CD0")]
		get
		{
			return default(LFFHALFGHGE<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD0D0", Offset = "0x6FC4D0")]
	public LFFHALFGHGE<TMarker> FNAOGAAODNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2634BA0", Offset = "0x26331A0", VA = "0x182634BA0")]
		get
		{
			return default(LFFHALFGHGE<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x953140", Offset = "0x951740", VA = "0x180953140")]
	public LFFHALFGHGE(int MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6DA0", Offset = "0x1CB53A0", VA = "0x181CB6DA0")]
	public LFFHALFGHGE<TOther> CBELNHKHKDK<TOther>() where TOther : TMarker
	{
		return default(LFFHALFGHGE<TOther>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x9530D0", Offset = "0x9516D0", VA = "0x1809530D0")]
	public int HLDMGFBCHDH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2634D90", Offset = "0x2633390", VA = "0x182634D90")]
	public bool OFNDPJHADPI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FCD50", Offset = "0x6FC150")] in LFFHALFGHGE<TMarker> FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2634C10", Offset = "0x2633210", VA = "0x182634C10", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FCDC0", Offset = "0x6FC1C0")] LFFHALFGHGE<TMarker> FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2081060", Offset = "0x207F660", VA = "0x182081060", Slot = "0")]
	public override bool Equals(object FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2634B80", Offset = "0x2633180", VA = "0x182634B80", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FCE20", Offset = "0x6FC220")] LFFHALFGHGE<TMarker> FKJGPCABBJN)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2634B40", Offset = "0x2633140", VA = "0x182634B40")]
	public static bool BDIEMMGDBNG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FCE80", Offset = "0x6FC280")] LFFHALFGHGE<TMarker> CBNLLBDNGLG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FCEE0", Offset = "0x6FC2E0")] LFFHALFGHGE<TMarker> FDIDEGFPCIP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2634C80", Offset = "0x2633280", VA = "0x182634C80")]
	public static bool HGHCMFFFPIK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FCF40", Offset = "0x6FC340")] LFFHALFGHGE<TMarker> CBNLLBDNGLG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FCFA0", Offset = "0x6FC3A0")] LFFHALFGHGE<TMarker> FDIDEGFPCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2634C60", Offset = "0x2633260", VA = "0x182634C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2634DB0", Offset = "0x26333B0", VA = "0x182634DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2634D40", Offset = "0x2633340", VA = "0x182634D40", Slot = "5")]
	private bool KAABEIJJHCH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD000", Offset = "0x6FC400")] in LFFHALFGHGE<TMarker> FKJGPCABBJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NMMFOGAGILB
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC540", Offset = "0x2FBAB40", VA = "0x182FBC540")]
	public static LFFHALFGHGE<TMarker?> DJPHIBFFEMC<TMarker>(this int CDBMADFDGCE)
	{
		return default(LFFHALFGHGE<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC540", Offset = "0x2FBAB40", VA = "0x182FBC540")]
	public static LFFHALFGHGE<TMarker?> HAECKKDAKDP<TMarker>(this int CDBMADFDGCE)
	{
		return default(LFFHALFGHGE<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2B40A10", Offset = "0x2B3F010", VA = "0x182B40A10")]
	public static DMBFAPIDLDO<LFFHALFGHGE<TMarker?>, MOMIEOKJPPG<TMarker?>> IEKCODBLFLH<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD170", Offset = "0x6FC570")] LFFHALFGHGE<TMarker?> HBLLFOBBOPM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD1D0", Offset = "0x6FC5D0")] LFFHALFGHGE<TMarker?> DPFINKKLLCL)
	{
		return default(DMBFAPIDLDO<LFFHALFGHGE<TMarker>, MOMIEOKJPPG<TMarker>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC570", Offset = "0x2FBAB70", VA = "0x182FBC570")]
	public static DMBFAPIDLDO<LFFHALFGHGE<TMarker?>, MOMIEOKJPPG<TMarker?>> GMIDBKEFOLJ<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD230", Offset = "0x6FC630")] LFFHALFGHGE<TMarker?> DPFINKKLLCL)
	{
		return default(DMBFAPIDLDO<LFFHALFGHGE<TMarker>, MOMIEOKJPPG<TMarker>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FAMKAHHKNEN<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2475B00", Offset = "0x2474100", VA = "0x182475B00")]
	public static LFFHALFGHGE<TOther> BKLMFCNKKJM<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD290", Offset = "0x6FC690")] LFFHALFGHGE<TMarker> CDBMADFDGCE) where TMarker : TOther
	{
		return default(LFFHALFGHGE<TOther>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KCMAOKILPGE
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IFJCOEAPEFE AIGLDFNFIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CGGPKAEABLI
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1918AB0", Offset = "0x19170B0", VA = "0x181918AB0")]
	public static bool FOMNELHLGEM<TSelf>(this TSelf CDBMADFDGCE) where TSelf : notnull, KCMAOKILPGE
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MOMIEOKJPPG<M> : IEnumerator<LFFHALFGHGE<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly int EHGECPMNNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly int KEFFMHPFNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int GANIEAKBCFM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD2F0", Offset = "0x6FC6F0")]
	public readonly LFFHALFGHGE<M> PLBILPKBCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2415660", Offset = "0x2413C60", VA = "0x182415660", Slot = "4")]
		get
		{
			return default(LFFHALFGHGE<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2415580", Offset = "0x2413B80", VA = "0x182415580", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xA7B770", Offset = "0xA79D70", VA = "0x180A7B770")]
	internal MOMIEOKJPPG(int BKOLKEDGPAG, int DPFINKKLLCL, int IHPGJHIDEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
	public readonly void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2415560", Offset = "0x2413B60", VA = "0x182415560", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2415570", Offset = "0x2413B70", VA = "0x182415570", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class INILKCPJEML
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x11E1300", Offset = "0x11DF900", VA = "0x1811E1300")]
	public static MOMIEOKJPPG<M?> OGNDBCBGIDA<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD3B0", Offset = "0x6FC7B0")] LFFHALFGHGE<M?> HBLLFOBBOPM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD410", Offset = "0x6FC810")] LFFHALFGHGE<M?> DPFINKKLLCL)
	{
		return default(MOMIEOKJPPG<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x11E1280", Offset = "0x11DF880", VA = "0x1811E1280")]
	public static DMBFAPIDLDO<LFFHALFGHGE<M?>, MOMIEOKJPPG<M?>> FKKOBPFNGCO<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD470", Offset = "0x6FC870")] LFFHALFGHGE<M?> HBLLFOBBOPM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD4D0", Offset = "0x6FC8D0")] LFFHALFGHGE<M?> DPFINKKLLCL)
	{
		return default(DMBFAPIDLDO<LFFHALFGHGE<M>, MOMIEOKJPPG<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KPGEPIFPGEE<M> : IEnumerator<LFFHALFGHGE<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly int OIPDGPDBJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int GANIEAKBCFM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD530", Offset = "0x6FC930")]
	public readonly LFFHALFGHGE<M> PLBILPKBCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x35438A0", Offset = "0x3541EA0", VA = "0x1835438A0", Slot = "4")]
		get
		{
			return default(LFFHALFGHGE<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3543810", Offset = "0x3541E10", VA = "0x183543810", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xA54600", Offset = "0xA52C00", VA = "0x180A54600")]
	private KPGEPIFPGEE(int FJLPCOJGEJP, int IHPGJHIDEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x35437C0", Offset = "0x3541DC0", VA = "0x1835437C0")]
	public static KPGEPIFPGEE<M> DEEGLMKMGCO(int FJLPCOJGEJP)
	{
		return default(KPGEPIFPGEE<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x35437F0", Offset = "0x3541DF0", VA = "0x1835437F0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3543800", Offset = "0x3541E00", VA = "0x183543800", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EABOMKPFMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6FE16C0", Offset = "0x6FDFCC0", VA = "0x186FE16C0")]
	public static DBJPEEHGAKP HLDMGFBCHDH(this in JLPKIKAFHCH CDBMADFDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1850", Offset = "0x6FDFE50", VA = "0x186FE1850")]
	public static JLPKIKAFHCH LKBINHHANLF(this DBJPEEHGAKP CDBMADFDGCE)
	{
		return default(JLPKIKAFHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6FE15E0", Offset = "0x6FDFBE0", VA = "0x186FE15E0")]
	public static DBJPEEHGAKP? HHBHGDCCHJH(this in JLPKIKAFHCH? CDBMADFDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1750", Offset = "0x6FDFD50", VA = "0x186FE1750")]
	public static JLPKIKAFHCH? LEEMJMJBDBJ(this DBJPEEHGAKP? CDBMADFDGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct AMHGAJFIDOK<TMarker> : IEquatable<AMHGAJFIDOK<TMarker>>, BIMCIIHFHMF<AMHGAJFIDOK<TMarker>>, IComparable<AMHGAJFIDOK<TMarker>> where TMarker : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Guid DAPCIOPNLKB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD970", Offset = "0x6FCD70")]
	public static AMHGAJFIDOK<TMarker> OPDGLPPADOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2080EE0", Offset = "0x207F4E0", VA = "0x182080EE0")]
		get
		{
			return default(AMHGAJFIDOK<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD9E0", Offset = "0x6FCDE0")]
	public static AMHGAJFIDOK<TMarker>? KKACGAHHFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x20812A0", Offset = "0x207F8A0", VA = "0x1820812A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xAE2E80", Offset = "0xAE1480", VA = "0x180AE2E80")]
	public AMHGAJFIDOK(in Guid MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2081160", Offset = "0x207F760", VA = "0x182081160")]
	public MNEJEHHAENN? HLDMGFBCHDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x20813A0", Offset = "0x207F9A0", VA = "0x1820813A0")]
	public bool OFNDPJHADPI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD610", Offset = "0x6FCA10")] in AMHGAJFIDOK<TMarker> FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2080FE0", Offset = "0x207F5E0", VA = "0x182080FE0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD680", Offset = "0x6FCA80")] AMHGAJFIDOK<TMarker> FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2081060", Offset = "0x207F660", VA = "0x182081060", Slot = "0")]
	public override bool Equals(object FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2081030", Offset = "0x207F630", VA = "0x182081030", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD6E0", Offset = "0x6FCAE0")] AMHGAJFIDOK<TMarker> FKJGPCABBJN)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2080FE0", Offset = "0x207F5E0", VA = "0x182080FE0")]
	public static bool BDIEMMGDBNG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD740", Offset = "0x6FCB40")] in AMHGAJFIDOK<TMarker> CBNLLBDNGLG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD7B0", Offset = "0x6FCBB0")] in AMHGAJFIDOK<TMarker> FDIDEGFPCIP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2081100", Offset = "0x207F700", VA = "0x182081100")]
	public static bool HGHCMFFFPIK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD820", Offset = "0x6FCC20")] in AMHGAJFIDOK<TMarker> CBNLLBDNGLG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD890", Offset = "0x6FCC90")] in AMHGAJFIDOK<TMarker> FDIDEGFPCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x20810E0", Offset = "0x207F6E0", VA = "0x1820810E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x20813D0", Offset = "0x207F9D0", VA = "0x1820813D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2080FE0", Offset = "0x207F5E0", VA = "0x182080FE0", Slot = "5")]
	private bool BAJLBDGPGOB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FD900", Offset = "0x6FCD00")] in AMHGAJFIDOK<TMarker> FKJGPCABBJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class IGMPMCMHGJG
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x11D5AF0", Offset = "0x11D40F0", VA = "0x1811D5AF0")]
	public static AMHGAJFIDOK<TMarker?> LKBINHHANLF<TMarker>(this MNEJEHHAENN? CDBMADFDGCE)
	{
		return default(AMHGAJFIDOK<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x11D5AC0", Offset = "0x11D40C0", VA = "0x1811D5AC0")]
	public static AMHGAJFIDOK<TMarker?> DJPHIBFFEMC<TMarker>(this in Guid CDBMADFDGCE)
	{
		return default(AMHGAJFIDOK<TMarker>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class NMHGIGCDCBL<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FDA90", Offset = "0x6FCE90")]
	internal static readonly AMHGAJFIDOK<TOther> OPDGLPPADOA;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FDAF0", Offset = "0x6FCEF0")]
	internal static readonly AMHGAJFIDOK<TOther>? KKACGAHHFMA;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public readonly struct BNJEIPJOCHH<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FDBC0", Offset = "0x6FCFC0")]
	private readonly IGDHAFFDNCH<T> FHFDNILHCJD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FDCE0", Offset = "0x6FD0E0")]
	public LFFHALFGHGE<M> JFHEJCIOGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1E69920", Offset = "0x1E67F20", VA = "0x181E69920")]
		get
		{
			return default(LFFHALFGHGE<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int ALHMBJNHGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1E698E0", Offset = "0x1E67EE0", VA = "0x181E698E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1E69A20", Offset = "0x1E68020", VA = "0x181E69A20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1E69BF0", Offset = "0x1E681F0", VA = "0x181E69BF0")]
	internal BNJEIPJOCHH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FDC80", Offset = "0x6FD080")] IGDHAFFDNCH<T> IACDCADJJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1E69B60", Offset = "0x1E68160", VA = "0x181E69B60")]
	public IEnumerable<T> ILPCFMACGJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E699E0", Offset = "0x1E67FE0", VA = "0x181E699E0")]
	public IEnumerator<T> FGHGHABHEPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1E69B90", Offset = "0x1E68190", VA = "0x181E69B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class NBKCAHCAOPA<M>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2591A00", Offset = "0x2590000", VA = "0x182591A00")]
	public static BNJEIPJOCHH<M, T> DIOJELLCEHC<T>(params T[] IACDCADJJAN) where T : notnull
	{
		return default(BNJEIPJOCHH<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class GMLNGCGIJDO
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1A00", Offset = "0x6FE0000", VA = "0x186FE1A00")]
	public static EIFFPNAKAGE HLDMGFBCHDH(this in ANPHIDGEMNH CDBMADFDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1BF0", Offset = "0x6FE01F0", VA = "0x186FE1BF0")]
	public static ANPHIDGEMNH LKBINHHANLF(this EIFFPNAKAGE CDBMADFDGCE)
	{
		return default(ANPHIDGEMNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1910", Offset = "0x6FDFF10", VA = "0x186FE1910")]
	public static EIFFPNAKAGE? HHBHGDCCHJH(this in ANPHIDGEMNH? CDBMADFDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1AA0", Offset = "0x6FE00A0", VA = "0x186FE1AA0")]
	public static ANPHIDGEMNH? LEEMJMJBDBJ(this EIFFPNAKAGE? CDBMADFDGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct ANPHIDGEMNH : IEquatable<ANPHIDGEMNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly float LKOKDECNICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly float GCCGPGCHMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly float OPGCHHHBDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly float JPGBFGKICLF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly ANPHIDGEMNH LKKJNALFBLK;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly ANPHIDGEMNH KLALHPOLMAD;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly ANPHIDGEMNH DLNHABMOIAH;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly ANPHIDGEMNH JCJBHJDEPFJ;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly ANPHIDGEMNH EHKJJHLEDMM;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2048E90", Offset = "0x2047490", VA = "0x182048E90")]
	public ANPHIDGEMNH(float HEICJNINGBE, float DNLDNFFNIEF, float EGEKNHJPNPL, float JNNIOKBNJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6FE12C0", Offset = "0x6FDF8C0", VA = "0x186FE12C0")]
	public static ANPHIDGEMNH OGNDBCBGIDA(float HEICJNINGBE, float DNLDNFFNIEF, float EGEKNHJPNPL, float JNNIOKBNJHE)
	{
		return default(ANPHIDGEMNH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5F0FB00", Offset = "0x5F0E100", VA = "0x185F0FB00")]
	public static bool BDIEMMGDBNG(in ANPHIDGEMNH MBOGNALMNPH, in ANPHIDGEMNH NDCLMFPKHPF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1220", Offset = "0x6FDF820", VA = "0x186FE1220")]
	public static bool HGHCMFFFPIK(in ANPHIDGEMNH MBOGNALMNPH, in ANPHIDGEMNH NDCLMFPKHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1180", Offset = "0x6FDF780", VA = "0x186FE1180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE10A0", Offset = "0x6FDF6A0", VA = "0x186FE10A0", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE12E0", Offset = "0x6FDF8E0", VA = "0x186FE12E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1000", Offset = "0x6FDF600", VA = "0x186FE1000", Slot = "4")]
	public bool Equals(ANPHIDGEMNH FKJGPCABBJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct NDMAHCEMKBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly float OOAIBEFNNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly float JDNHEMIGEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly float LKHNFIKKIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly float CPHFPMODFPH;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly NDMAHCEMKBI JOMNFIMNMOJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly NDMAHCEMKBI OAJBLEKENPH;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2048E90", Offset = "0x2047490", VA = "0x182048E90")]
	public NDMAHCEMKBI(float EMOGFKKIBPO, float CPPICKHPIPK, float HEPECHBEGLE, float GNJGFBLEGKK)
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
