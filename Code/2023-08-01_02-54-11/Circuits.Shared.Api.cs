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
		[Cpp2IlInjected.Address(RVA = "0x8484E0", Offset = "0x8474E0", VA = "0x1808484E0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72B5810", Offset = "0x72B4810", VA = "0x1872B5810")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB36FF0", Offset = "0xB35FF0", VA = "0x180B36FF0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x183B060", Offset = "0x183A060", VA = "0x18183B060")]
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
public readonly struct MHIKIGNCHDF<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly T[] BHLCLBOBGCB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x741C30", Offset = "0x741030")]
	public CLCGDJMPMIK<M> BJFHGMFDOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29E3E20", Offset = "0x29E2E20", VA = "0x1829E3E20")]
		get
		{
			return default(CLCGDJMPMIK<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int MGNEPOBDAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29E3FB0", Offset = "0x29E2FB0", VA = "0x1829E3FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x221DCA0", Offset = "0x221CCA0", VA = "0x18221DCA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA9F760", Offset = "0xA9E760", VA = "0x180A9F760")]
	internal MHIKIGNCHDF(T[] OGEGDDKCPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29E3F20", Offset = "0x29E2F20", VA = "0x1829E3F20")]
	public static MHIKIGNCHDF<M, T> CECGBIGMPDN(int GAKMECKICIG)
	{
		return default(MHIKIGNCHDF<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
	public IEnumerable<T> MBDGGMIJIDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29E3EB0", Offset = "0x29E2EB0", VA = "0x1829E3EB0")]
	public OHMJFFAJLCJ<M, T> BNKLIAMHOHF()
	{
		return default(OHMJFFAJLCJ<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x29E3FD0", Offset = "0x29E2FD0", VA = "0x1829E3FD0")]
	public IEnumerator<T> DHFGGODEIOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x29E4050", Offset = "0x29E3050", VA = "0x1829E4050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class EBMCPPFPEKL<M>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x20B4F40", Offset = "0x20B3F40", VA = "0x1820B4F40")]
	public static MHIKIGNCHDF<M, T> JHBAOBHGELC<T>(params T[] OGEGDDKCPPH) where T : notnull
	{
		return default(MHIKIGNCHDF<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DCPGMIBOIAP
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x221DCA0", Offset = "0x221CCA0", VA = "0x18221DCA0")]
	public static T? ODCBFOFHMOF<T, M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x741CD0", Offset = "0x7410D0")] this ref MHIKIGNCHDF<M?, T?> DPHICODLGJD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x741D30", Offset = "0x741130")] CLCGDJMPMIK<M?> MBMAEEFDADD)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x221DC50", Offset = "0x221CC50", VA = "0x18221DC50")]
	public static void FNPACIDIMCD<M, T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x741D90", Offset = "0x741190")] this ref MHIKIGNCHDF<M?, T?> DPHICODLGJD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x741DF0", Offset = "0x7411F0")] CLCGDJMPMIK<M?> MBMAEEFDADD, in T CKMKMNKGMMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NBBCACJAGKK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NAPAPDLLDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct BJLJCDLDEJF : IEquatable<BJLJCDLDEJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float HLNILLJOJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float DLOJJDDHCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly float IDCJDDGHGAG;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly BJLJCDLDEJF ILNGMJNEPCK;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly BJLJCDLDEJF JIKKDHECCLP;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly BJLJCDLDEJF GJAEABFOBBD;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly BJLJCDLDEJF EMEDBOAJDEC;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly BJLJCDLDEJF MDLINHJPFBE;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly BJLJCDLDEJF OIBAHPFMMFL;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly BJLJCDLDEJF GMHIFEJAKAG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly BJLJCDLDEJF EFAHONIIHBG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly BJLJCDLDEJF DBGJBAEJAIH;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly BJLJCDLDEJF OOPCKKHMLNO;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly BJLJCDLDEJF FBMFJIKGIED;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly BJLJCDLDEJF EGFHECKBLFA;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly BJLJCDLDEJF NLCBIPOPKNO;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly BJLJCDLDEJF PFBNCDDECOL;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly BJLJCDLDEJF EAJGOGJKDMK;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly BJLJCDLDEJF IJJIINPPFCJ;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly BJLJCDLDEJF OFMBFLBELPB;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x480CE00", Offset = "0x480BE00", VA = "0x18480CE00")]
	public BJLJCDLDEJF(float LMFGBCIIJHA, float FPHLKKGCLDG, float ODPADMFEDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x72B44D0", Offset = "0x72B34D0", VA = "0x1872B44D0")]
	public static BJLJCDLDEJF CECGBIGMPDN(float LMFGBCIIJHA, float FPHLKKGCLDG, float ODPADMFEDEO)
	{
		return default(BJLJCDLDEJF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x72B46D0", Offset = "0x72B36D0", VA = "0x1872B46D0")]
	public static bool JFBEPFHBCDN(in BJLJCDLDEJF BEHCKOODGGG, in BJLJCDLDEJF IOJJDIDNFKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x72B4700", Offset = "0x72B3700", VA = "0x1872B4700")]
	public static bool NLNNLODOBLO(in BJLJCDLDEJF BEHCKOODGGG, in BJLJCDLDEJF IOJJDIDNFKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72B4660", Offset = "0x72B3660", VA = "0x1872B4660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72B44F0", Offset = "0x72B34F0", VA = "0x1872B44F0", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72B4790", Offset = "0x72B3790", VA = "0x1872B4790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72B45D0", Offset = "0x72B35D0", VA = "0x1872B45D0", Slot = "4")]
	public bool Equals(BJLJCDLDEJF JONIFABKCAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Obsolete]
[DefaultMember("Item")]
public ref struct MHOEDPKHAGI<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x741F10", Offset = "0x741310")]
	private readonly ReadOnlySpan<T> PPHJNBPFPJM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly T IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x29E4300", Offset = "0x29E3300", VA = "0x1829E4300")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1859EC0", Offset = "0x1858EC0", VA = "0x181859EC0")]
	internal MHOEDPKHAGI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x741FD0", Offset = "0x7413D0")] in ReadOnlySpan<T> HDJPENBGDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x29E4350", Offset = "0x29E3350", VA = "0x1829E4350", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FJKEGCFDHAN<M>
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1D8BF20", Offset = "0x1D8AF20", VA = "0x181D8BF20")]
	public static MHOEDPKHAGI<M?, T?> MLGGNBPEAPA<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742080", Offset = "0x741480")] in ReadOnlySpan<T?> HDJPENBGDDB)
	{
		return default(MHOEDPKHAGI<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct OLGEJIGHDPG : IEquatable<OLGEJIGHDPG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly KDNLPHCBBHA MFMJNPLDFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly BJLJCDLDEJF HCILKJHLOLC;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly OLGEJIGHDPG GHFDCDCFFNC;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x72B5CD0", Offset = "0x72B4CD0", VA = "0x1872B5CD0")]
	public OLGEJIGHDPG(in KDNLPHCBBHA DEANJFCCEBG, in BJLJCDLDEJF EDEGPGKBEGA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x72B5A70", Offset = "0x72B4A70", VA = "0x1872B5A70")]
	public static bool JFBEPFHBCDN(in OLGEJIGHDPG BEHCKOODGGG, in OLGEJIGHDPG IOJJDIDNFKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72B59E0", Offset = "0x72B49E0", VA = "0x1872B59E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72B58A0", Offset = "0x72B48A0", VA = "0x1872B58A0", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x72B5B60", Offset = "0x72B4B60", VA = "0x1872B5B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x72B5970", Offset = "0x72B4970", VA = "0x1872B5970", Slot = "4")]
	public bool Equals(OLGEJIGHDPG JONIFABKCAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct BIDDMNFMBMF<M, T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742130", Offset = "0x741530")]
	private readonly ReadOnlyMemory<T?> PMKCNIKMDLE;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	internal BIDDMNFMBMF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742190", Offset = "0x741590")] in ReadOnlyMemory<T?> IEOKKFIMIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0470", Offset = "0x3F9F470", VA = "0x183FA0470")]
	public MHOEDPKHAGI<M?, T?> FHMCIPJEBIG()
	{
		return default(MHOEDPKHAGI<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0550", Offset = "0x3F9F550", VA = "0x183FA0550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FFJIIGNHGGD<M>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1166490", Offset = "0x1165490", VA = "0x181166490")]
	public static BIDDMNFMBMF<M?, T?> JGDHGALKCDI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742200", Offset = "0x741600")] in ReadOnlyMemory<T?> IEOKKFIMIED)
	{
		return default(BIDDMNFMBMF<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct CLCGDJMPMIK<TMarker> : IEquatable<CLCGDJMPMIK<TMarker>>, GIBCDHLKDOL<CLCGDJMPMIK<TMarker>>, IComparable<CLCGDJMPMIK<TMarker>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly int KFOPGALFMNJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742590", Offset = "0x741990")]
	public CLCGDJMPMIK<TMarker> GMDBILMCIGN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1F35140", Offset = "0x1F34140", VA = "0x181F35140")]
		get
		{
			return default(CLCGDJMPMIK<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7425F0", Offset = "0x7419F0")]
	public CLCGDJMPMIK<TMarker> PFPCACKFHGA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1F35220", Offset = "0x1F34220", VA = "0x181F35220")]
		get
		{
			return default(CLCGDJMPMIK<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xA79570", Offset = "0xA78570", VA = "0x180A79570")]
	public CLCGDJMPMIK(int CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x29BD450", Offset = "0x29BC450", VA = "0x1829BD450")]
	public CLCGDJMPMIK<TOther> JHOFFMJGOLE<TOther>() where TOther : TMarker
	{
		return default(CLCGDJMPMIK<TOther>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1F35200", Offset = "0x1F34200", VA = "0x181F35200")]
	public bool NMMJDBFMDAE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742270", Offset = "0x741670")] in CLCGDJMPMIK<TMarker> JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1F35090", Offset = "0x1F34090", VA = "0x181F35090", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7422E0", Offset = "0x7416E0")] CLCGDJMPMIK<TMarker> JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1F35010", Offset = "0x1F34010", VA = "0x181F35010", Slot = "0")]
	public override bool Equals(object JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1F34FA0", Offset = "0x1F33FA0", VA = "0x181F34FA0", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742340", Offset = "0x741740")] CLCGDJMPMIK<TMarker> JONIFABKCAI)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1F35100", Offset = "0x1F34100", VA = "0x181F35100")]
	public static bool JFBEPFHBCDN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7423A0", Offset = "0x7417A0")] CLCGDJMPMIK<TMarker> KOMAFEKIKMM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742400", Offset = "0x741800")] CLCGDJMPMIK<TMarker> MKGHCBPGAGB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1F351B0", Offset = "0x1F341B0", VA = "0x181F351B0")]
	public static bool NLNNLODOBLO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742460", Offset = "0x741860")] CLCGDJMPMIK<TMarker> KOMAFEKIKMM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7424C0", Offset = "0x7418C0")] CLCGDJMPMIK<TMarker> MKGHCBPGAGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1F350E0", Offset = "0x1F340E0", VA = "0x181F350E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1F35290", Offset = "0x1F34290", VA = "0x181F35290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1F34FC0", Offset = "0x1F33FC0", VA = "0x181F34FC0", Slot = "5")]
	private bool EPFCJAFCMCE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742520", Offset = "0x741920")] in CLCGDJMPMIK<TMarker> JONIFABKCAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PKFBHLBHICC
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2ED84C0", Offset = "0x2ED74C0", VA = "0x182ED84C0")]
	public static CLCGDJMPMIK<TMarker?> EKCFIMHGNIH<TMarker>(this int DPHICODLGJD)
	{
		return default(CLCGDJMPMIK<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2ED84C0", Offset = "0x2ED74C0", VA = "0x182ED84C0")]
	public static CLCGDJMPMIK<TMarker?> AFNOPFIGAML<TMarker>(this int DPHICODLGJD)
	{
		return default(CLCGDJMPMIK<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A30C40", Offset = "0x2A2FC40", VA = "0x182A30C40")]
	public static IDFOHKDIBEA<CLCGDJMPMIK<TMarker?>, CKPJHCCCFKH<TMarker?>> LJGNBBAIOCL<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742690", Offset = "0x741A90")] CLCGDJMPMIK<TMarker?> JHBFCNNFCIA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7426F0", Offset = "0x741AF0")] CLCGDJMPMIK<TMarker?> DOBJJILGFIG)
	{
		return default(IDFOHKDIBEA<CLCGDJMPMIK<TMarker>, CKPJHCCCFKH<TMarker>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2ED84F0", Offset = "0x2ED74F0", VA = "0x182ED84F0")]
	public static IDFOHKDIBEA<CLCGDJMPMIK<TMarker?>, CKPJHCCCFKH<TMarker?>> DDNEDAIJOCK<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742750", Offset = "0x741B50")] CLCGDJMPMIK<TMarker?> DOBJJILGFIG)
	{
		return default(IDFOHKDIBEA<CLCGDJMPMIK<TMarker>, CKPJHCCCFKH<TMarker>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KAOOJAPMFLJ<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x21EF1E0", Offset = "0x21EE1E0", VA = "0x1821EF1E0")]
	public static CLCGDJMPMIK<TOther> JLKHGCGFDIO<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7427B0", Offset = "0x741BB0")] CLCGDJMPMIK<TMarker> DPHICODLGJD) where TMarker : TOther
	{
		return default(CLCGDJMPMIK<TOther>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CCLKNNCMAEK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	NBBCACJAGKK JBILJIGFAFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ACIGOFEMIHJ
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2A216B0", Offset = "0x2A206B0", VA = "0x182A216B0")]
	public static bool BCMICPLCIKB<TSelf>(this TSelf DPHICODLGJD) where TSelf : notnull, CCLKNNCMAEK
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CKPJHCCCFKH<M> : IEnumerator<CLCGDJMPMIK<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly int DJFCGCOIMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly int LDGEFJGMHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int OCDKPAOKKIF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742810", Offset = "0x741C10")]
	public readonly CLCGDJMPMIK<M> DALPLHLAAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x21844D0", Offset = "0x21834D0", VA = "0x1821844D0", Slot = "4")]
		get
		{
			return default(CLCGDJMPMIK<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x21843F0", Offset = "0x21833F0", VA = "0x1821843F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x12816C0", Offset = "0x12806C0", VA = "0x1812816C0")]
	internal CKPJHCCCFKH(int PJBGAMGINIK, int DOBJJILGFIG, int DEAEACGJEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
	public readonly void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x21843D0", Offset = "0x21833D0", VA = "0x1821843D0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x21843E0", Offset = "0x21833E0", VA = "0x1821843E0", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GOBHFEHHIKC
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2965B40", Offset = "0x2964B40", VA = "0x182965B40")]
	public static CKPJHCCCFKH<M?> CECGBIGMPDN<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742890", Offset = "0x741C90")] CLCGDJMPMIK<M?> JHBFCNNFCIA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7428F0", Offset = "0x741CF0")] CLCGDJMPMIK<M?> DOBJJILGFIG)
	{
		return default(CKPJHCCCFKH<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2965B80", Offset = "0x2964B80", VA = "0x182965B80")]
	public static IDFOHKDIBEA<CLCGDJMPMIK<M?>, CKPJHCCCFKH<M?>> PLGJHEIGONO<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742950", Offset = "0x741D50")] CLCGDJMPMIK<M?> JHBFCNNFCIA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7429B0", Offset = "0x741DB0")] CLCGDJMPMIK<M?> DOBJJILGFIG)
	{
		return default(IDFOHKDIBEA<CLCGDJMPMIK<M>, CKPJHCCCFKH<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DHJDAKCCMOJ<M> : IEnumerator<CLCGDJMPMIK<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly int NFPPECIGIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int OCDKPAOKKIF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742A10", Offset = "0x741E10")]
	public readonly CLCGDJMPMIK<M> DALPLHLAAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x37C6340", Offset = "0x37C5340", VA = "0x1837C6340", Slot = "4")]
		get
		{
			return default(CLCGDJMPMIK<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x37C62B0", Offset = "0x37C52B0", VA = "0x1837C62B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xAEEDE0", Offset = "0xAEDDE0", VA = "0x180AEEDE0")]
	private DHJDAKCCMOJ(int PFDGPOIGHFM, int DEAEACGJEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x37C6260", Offset = "0x37C5260", VA = "0x1837C6260")]
	public static DHJDAKCCMOJ<M> COGKHEPINPK(int PFDGPOIGHFM)
	{
		return default(DHJDAKCCMOJ<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x37C6290", Offset = "0x37C5290", VA = "0x1837C6290", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x37C62A0", Offset = "0x37C52A0", VA = "0x1837C62A0", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class CNOODMINCHN
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x72B4AD0", Offset = "0x72B3AD0", VA = "0x1872B4AD0")]
	public static NGEGGIHCMDD BCEEACLIKPE(this in BJLJCDLDEJF DPHICODLGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x72B4B60", Offset = "0x72B3B60", VA = "0x1872B4B60")]
	public static BJLJCDLDEJF BPADPDDPOEA(this NGEGGIHCMDD DPHICODLGJD)
	{
		return default(BJLJCDLDEJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72B4C20", Offset = "0x72B3C20", VA = "0x1872B4C20")]
	public static NGEGGIHCMDD? DJJGNBAIPEA(this in BJLJCDLDEJF? DPHICODLGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x72B4D00", Offset = "0x72B3D00", VA = "0x1872B4D00")]
	public static BJLJCDLDEJF? FPBPKFANCJJ(this NGEGGIHCMDD? DPHICODLGJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct EBHOOONAADD<TMarker> : IEquatable<EBHOOONAADD<TMarker>>, GIBCDHLKDOL<EBHOOONAADD<TMarker>>, IComparable<EBHOOONAADD<TMarker>> where TMarker : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Guid ALOADMKKEFG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742E50", Offset = "0x742250")]
	public static EBHOOONAADD<TMarker> PELFLFHGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x27C1720", Offset = "0x27C0720", VA = "0x1827C1720")]
		get
		{
			return default(EBHOOONAADD<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742EC0", Offset = "0x7422C0")]
	public static EBHOOONAADD<TMarker>? NLKBFLKLEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x27C14F0", Offset = "0x27C04F0", VA = "0x1827C14F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x15EA3E0", Offset = "0x15E93E0", VA = "0x1815EA3E0")]
	public EBHOOONAADD(in Guid CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x27C13B0", Offset = "0x27C03B0", VA = "0x1827C13B0")]
	public HJAIDBMDPEF? BCEEACLIKPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27C16F0", Offset = "0x27C06F0", VA = "0x1827C16F0")]
	public bool NMMJDBFMDAE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742AF0", Offset = "0x741EF0")] in EBHOOONAADD<TMarker> JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x27C1620", Offset = "0x27C0620", VA = "0x1827C1620", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742B60", Offset = "0x741F60")] EBHOOONAADD<TMarker> JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1F35010", Offset = "0x1F34010", VA = "0x181F35010", Slot = "0")]
	public override bool Equals(object JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x27C15F0", Offset = "0x27C05F0", VA = "0x1827C15F0", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742BC0", Offset = "0x741FC0")] EBHOOONAADD<TMarker> JONIFABKCAI)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x27C1620", Offset = "0x27C0620", VA = "0x1827C1620")]
	public static bool JFBEPFHBCDN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742C20", Offset = "0x742020")] in EBHOOONAADD<TMarker> KOMAFEKIKMM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742C90", Offset = "0x742090")] in EBHOOONAADD<TMarker> MKGHCBPGAGB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27C1690", Offset = "0x27C0690", VA = "0x1827C1690")]
	public static bool NLNNLODOBLO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742D00", Offset = "0x742100")] in EBHOOONAADD<TMarker> KOMAFEKIKMM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742D70", Offset = "0x742170")] in EBHOOONAADD<TMarker> MKGHCBPGAGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27C1670", Offset = "0x27C0670", VA = "0x1827C1670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27C1820", Offset = "0x27C0820", VA = "0x1827C1820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x27C1620", Offset = "0x27C0620", VA = "0x1827C1620", Slot = "5")]
	private bool OEBLHIFNJLG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742DE0", Offset = "0x7421E0")] in EBHOOONAADD<TMarker> JONIFABKCAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class LENGJMIIBDE
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2353F60", Offset = "0x2352F60", VA = "0x182353F60")]
	public static EBHOOONAADD<TMarker?> BPADPDDPOEA<TMarker>(this HJAIDBMDPEF? DPHICODLGJD)
	{
		return default(EBHOOONAADD<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2354040", Offset = "0x2353040", VA = "0x182354040")]
	public static EBHOOONAADD<TMarker?> EKCFIMHGNIH<TMarker>(this in Guid DPHICODLGJD)
	{
		return default(EBHOOONAADD<TMarker>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class BMEOMBPFJFH<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742F70", Offset = "0x742370")]
	internal static readonly EBHOOONAADD<TOther> PELFLFHGHGI;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742FD0", Offset = "0x7423D0")]
	internal static readonly EBHOOONAADD<TOther>? NLKBFLKLEHJ;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public readonly struct OHMJFFAJLCJ<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7430A0", Offset = "0x7424A0")]
	private readonly HMEGOOAMLBB<T> BHLCLBOBGCB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7431C0", Offset = "0x7425C0")]
	public CLCGDJMPMIK<M> BJFHGMFDOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x25D6720", Offset = "0x25D5720", VA = "0x1825D6720")]
		get
		{
			return default(CLCGDJMPMIK<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int MGNEPOBDAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x25D68D0", Offset = "0x25D58D0", VA = "0x1825D68D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public T IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x25D6880", Offset = "0x25D5880", VA = "0x1825D6880")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x21C5F00", Offset = "0x21C4F00", VA = "0x1821C5F00")]
	internal OHMJFFAJLCJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x743160", Offset = "0x742560")] HMEGOOAMLBB<T> OGEGDDKCPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1859DC0", Offset = "0x1858DC0", VA = "0x181859DC0")]
	public IEnumerable<T> MBDGGMIJIDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x25D6910", Offset = "0x25D5910", VA = "0x1825D6910")]
	public IEnumerator<T> DHFGGODEIOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x25D6950", Offset = "0x25D5950", VA = "0x1825D6950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KLHHPFLADEF<M>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x21EF230", Offset = "0x21EE230", VA = "0x1821EF230")]
	public static OHMJFFAJLCJ<M, T> JHBAOBHGELC<T>(params T[] OGEGDDKCPPH) where T : notnull
	{
		return default(OHMJFFAJLCJ<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class FPJILMDDOAB
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x72B4E00", Offset = "0x72B3E00", VA = "0x1872B4E00")]
	public static JAEMJKGOKOG BCEEACLIKPE(this in KDNLPHCBBHA DPHICODLGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x72B4EA0", Offset = "0x72B3EA0", VA = "0x1872B4EA0")]
	public static KDNLPHCBBHA BPADPDDPOEA(this JAEMJKGOKOG DPHICODLGJD)
	{
		return default(KDNLPHCBBHA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x72B4F90", Offset = "0x72B3F90", VA = "0x1872B4F90")]
	public static JAEMJKGOKOG? DJJGNBAIPEA(this in KDNLPHCBBHA? DPHICODLGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x72B5080", Offset = "0x72B4080", VA = "0x1872B5080")]
	public static KDNLPHCBBHA? FPBPKFANCJJ(this JAEMJKGOKOG? DPHICODLGJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct KDNLPHCBBHA : IEquatable<KDNLPHCBBHA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly float HLNILLJOJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly float DLOJJDDHCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly float IDCJDDGHGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly float OBKOLFLMFCF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly KDNLPHCBBHA GHFDCDCFFNC;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly KDNLPHCBBHA GJAEABFOBBD;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly KDNLPHCBBHA EMEDBOAJDEC;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly KDNLPHCBBHA MDLINHJPFBE;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly KDNLPHCBBHA OIBAHPFMMFL;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x216EC80", Offset = "0x216DC80", VA = "0x18216EC80")]
	public KDNLPHCBBHA(float LMFGBCIIJHA, float FPHLKKGCLDG, float ODPADMFEDEO, float GMBJDLPGFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x72B51D0", Offset = "0x72B41D0", VA = "0x1872B51D0")]
	public static KDNLPHCBBHA CECGBIGMPDN(float LMFGBCIIJHA, float FPHLKKGCLDG, float ODPADMFEDEO, float GMBJDLPGFAF)
	{
		return default(KDNLPHCBBHA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5160", Offset = "0x5DB4160", VA = "0x185DB5160")]
	public static bool JFBEPFHBCDN(in KDNLPHCBBHA BEHCKOODGGG, in KDNLPHCBBHA IOJJDIDNFKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x72B5410", Offset = "0x72B4410", VA = "0x1872B5410")]
	public static bool NLNNLODOBLO(in KDNLPHCBBHA BEHCKOODGGG, in KDNLPHCBBHA IOJJDIDNFKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x72B5370", Offset = "0x72B4370", VA = "0x1872B5370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x72B5290", Offset = "0x72B4290", VA = "0x1872B5290", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x72B54B0", Offset = "0x72B44B0", VA = "0x1872B54B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x72B51F0", Offset = "0x72B41F0", VA = "0x1872B51F0", Slot = "4")]
	public bool Equals(KDNLPHCBBHA JONIFABKCAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct LCCMIAKOJEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly float LIDLNFHGBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly float FFEAEBBALEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly float MIMMGFLNPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly float FOFHNOCCOPE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly LCCMIAKOJEL PDFAILEEKNJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly LCCMIAKOJEL HKAONAIOEKJ;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x216EC80", Offset = "0x216DC80", VA = "0x18216EC80")]
	public LCCMIAKOJEL(float LGPLIEDGINL, float MCJACLOIOGD, float ANCILJKDKHM, float CDICEDNOPPN)
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
