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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F68C00", Offset = "0x6F67E00", VA = "0x186F68C00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
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
		[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
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
public readonly struct NJCGNMPMJKC<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly T[] PNAKAFIEMIK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4B20", Offset = "0x6F3F20")]
	public HOGMOCHAFIO<M> IBBPKBDNAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D8B0", Offset = "0x2C9CAB0", VA = "0x182C9D8B0")]
		get
		{
			return default(HOGMOCHAFIO<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CKAIEHNDOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x25A1940", Offset = "0x25A0B40", VA = "0x1825A1940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1CCDED0", Offset = "0x1CCD0D0", VA = "0x181CCDED0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8BADB0", Offset = "0x8B9FB0", VA = "0x1808BADB0")]
	internal NJCGNMPMJKC(T[] LMFDNLBGHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D820", Offset = "0x2C9CA20", VA = "0x182C9D820")]
	public static NJCGNMPMJKC<M, T> HBHNAKPOBBF(int AAALINBAMFJ)
	{
		return default(NJCGNMPMJKC<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0")]
	public IEnumerable<T> NJBHDBHLAKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D7B0", Offset = "0x2C9C9B0", VA = "0x182C9D7B0")]
	public KHCMLBEHALN<M, T> ENJGGCGCBLN()
	{
		return default(KHCMLBEHALN<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D730", Offset = "0x2C9C930", VA = "0x182C9D730")]
	public IEnumerator<T> EEOIHAEEMHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D940", Offset = "0x2C9CB40", VA = "0x182C9D940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HGJOJMBNEMG<M>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E209C0", Offset = "0x1E1FBC0", VA = "0x181E209C0")]
	public static NJCGNMPMJKC<M, T> LIKFLKLFOKA<T>(params T[] LMFDNLBGHBA) where T : notnull
	{
		return default(NJCGNMPMJKC<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KDGOOGPFLAN
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1CCDED0", Offset = "0x1CCD0D0", VA = "0x181CCDED0")]
	public static T? MBAEFAJFFMJ<T, M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4BC0", Offset = "0x6F3FC0")] this ref NJCGNMPMJKC<M?, T?> KPIHKJNPOFH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4C20", Offset = "0x6F4020")] HOGMOCHAFIO<M?> LHPGLCOPMKK)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1CCDE80", Offset = "0x1CCD080", VA = "0x181CCDE80")]
	public static void BNDJKAKDCIM<M, T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4C80", Offset = "0x6F4080")] this ref NJCGNMPMJKC<M?, T?> KPIHKJNPOFH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4CE0", Offset = "0x6F40E0")] HOGMOCHAFIO<M?> LHPGLCOPMKK, in T NABCGCEIEGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NPJIJDMGBJO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PPCKCOGLCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct DDAEIDDGCJK : IEquatable<DDAEIDDGCJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float CADEIOCAGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float MHJALIMNEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly float ILCJMLJOOLP;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly DDAEIDDGCJK GPFDJOAPDHC;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly DDAEIDDGCJK KAOBJBKLIEP;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly DDAEIDDGCJK INALKMMPBEH;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly DDAEIDDGCJK JMBBEIHEPCJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly DDAEIDDGCJK BALNLNOPKII;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly DDAEIDDGCJK JHDJLNMMBDP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly DDAEIDDGCJK GECMCOCBBHF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly DDAEIDDGCJK JDCJOBEECBA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly DDAEIDDGCJK MGJGAGCPBGD;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly DDAEIDDGCJK JOLGJKIIJHI;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly DDAEIDDGCJK LINICEIGOLK;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly DDAEIDDGCJK GBEAMPMOGEG;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly DDAEIDDGCJK KOMBJDGJGEG;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly DDAEIDDGCJK IIOMLNOMNDK;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly DDAEIDDGCJK LPIKPONCDAC;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly DDAEIDDGCJK NFLENFCMJNH;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly DDAEIDDGCJK KHHBLDLMOPC;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4438C30", Offset = "0x4437E30", VA = "0x184438C30")]
	public DDAEIDDGCJK(float JPBGAMDOIJA, float IIJHAMIHIMK, float BKHNPAHKPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F67980", Offset = "0x6F66B80", VA = "0x186F67980")]
	public static DDAEIDDGCJK HBHNAKPOBBF(float JPBGAMDOIJA, float IIJHAMIHIMK, float BKHNPAHKPOJ)
	{
		return default(DDAEIDDGCJK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F679A0", Offset = "0x6F66BA0", VA = "0x186F679A0")]
	public static bool IJMFMDJGAHN(in DDAEIDDGCJK MHFLHKLCNGM, in DDAEIDDGCJK NKPGENLIMOI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F679D0", Offset = "0x6F66BD0", VA = "0x186F679D0")]
	public static bool PFFDPAELFMB(in DDAEIDDGCJK MHFLHKLCNGM, in DDAEIDDGCJK NKPGENLIMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F67910", Offset = "0x6F66B10", VA = "0x186F67910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F677A0", Offset = "0x6F669A0", VA = "0x186F677A0", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F67A60", Offset = "0x6F66C60", VA = "0x186F67A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F67880", Offset = "0x6F66A80", VA = "0x186F67880", Slot = "4")]
	public bool Equals(DDAEIDDGCJK JMNBIHILIIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct JMAAGPMELEJ : IEquatable<JMAAGPMELEJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly HBNLMECNNNL IIKKJHMHDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly DDAEIDDGCJK AHMAIAGANPN;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly JMAAGPMELEJ LAFLOOCDPHH;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F68BE0", Offset = "0x6F67DE0", VA = "0x186F68BE0")]
	public JMAAGPMELEJ(in HBNLMECNNNL ELGEECMLAMI, in DDAEIDDGCJK BOEKENJNLKP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F68980", Offset = "0x6F67B80", VA = "0x186F68980")]
	public static bool IJMFMDJGAHN(in JMAAGPMELEJ MHFLHKLCNGM, in JMAAGPMELEJ NKPGENLIMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F688F0", Offset = "0x6F67AF0", VA = "0x186F688F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6F68820", Offset = "0x6F67A20", VA = "0x186F68820", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F68A70", Offset = "0x6F67C70", VA = "0x186F68A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F687B0", Offset = "0x6F679B0", VA = "0x186F687B0", Slot = "4")]
	public bool Equals(JMAAGPMELEJ JMNBIHILIIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct HOGMOCHAFIO<TMarker> : IEquatable<HOGMOCHAFIO<TMarker>>, JGMIOPFGKLF<HOGMOCHAFIO<TMarker>>, IComparable<HOGMOCHAFIO<TMarker>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly int DGACKDKOCLH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5090", Offset = "0x6F4490")]
	public HOGMOCHAFIO<TMarker> BPFOLHNLIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x259C580", Offset = "0x259B780", VA = "0x18259C580")]
		get
		{
			return default(HOGMOCHAFIO<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F50F0", Offset = "0x6F44F0")]
	public HOGMOCHAFIO<TMarker> FIDICMKHAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x259C4B0", Offset = "0x259B6B0", VA = "0x18259C4B0")]
		get
		{
			return default(HOGMOCHAFIO<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940")]
	public HOGMOCHAFIO(int NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x21035D0", Offset = "0x21027D0", VA = "0x1821035D0")]
	public HOGMOCHAFIO<TOther> HMAGMPEKFCB<TOther>() where TOther : TMarker
	{
		return default(HOGMOCHAFIO<TOther>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0")]
	public int IOAMGHHAJNN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x259C3A0", Offset = "0x259B5A0", VA = "0x18259C3A0")]
	public bool AGDAPBIFCOO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4D70", Offset = "0x6F4170")] in HOGMOCHAFIO<TMarker> JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x259C3E0", Offset = "0x259B5E0", VA = "0x18259C3E0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4DE0", Offset = "0x6F41E0")] HOGMOCHAFIO<TMarker> JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x259C430", Offset = "0x259B630", VA = "0x18259C430", Slot = "0")]
	public override bool Equals(object JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x259C3C0", Offset = "0x259B5C0", VA = "0x18259C3C0", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4E40", Offset = "0x6F4240")] HOGMOCHAFIO<TMarker> JMNBIHILIIC)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x259C540", Offset = "0x259B740", VA = "0x18259C540")]
	public static bool IJMFMDJGAHN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4EA0", Offset = "0x6F42A0")] HOGMOCHAFIO<TMarker> NPCLKEGHIKP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4F00", Offset = "0x6F4300")] HOGMOCHAFIO<TMarker> NCHMBLEIGHE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x259C5F0", Offset = "0x259B7F0", VA = "0x18259C5F0")]
	public static bool PFFDPAELFMB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4F60", Offset = "0x6F4360")] HOGMOCHAFIO<TMarker> NPCLKEGHIKP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4FC0", Offset = "0x6F43C0")] HOGMOCHAFIO<TMarker> NCHMBLEIGHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x259C520", Offset = "0x259B720", VA = "0x18259C520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x259C640", Offset = "0x259B840", VA = "0x18259C640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x259C350", Offset = "0x259B550", VA = "0x18259C350", Slot = "5")]
	private bool AAMGOAEAMGJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5020", Offset = "0x6F4420")] in HOGMOCHAFIO<TMarker> JMNBIHILIIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JHIBFGOEIDI
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1B33740", Offset = "0x1B32940", VA = "0x181B33740")]
	public static HOGMOCHAFIO<TMarker?> CDEDBHKFAGP<TMarker>(this int KPIHKJNPOFH)
	{
		return default(HOGMOCHAFIO<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1B33740", Offset = "0x1B32940", VA = "0x181B33740")]
	public static HOGMOCHAFIO<TMarker?> IHAKEGGGJEN<TMarker>(this int KPIHKJNPOFH)
	{
		return default(HOGMOCHAFIO<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1B33770", Offset = "0x1B32970", VA = "0x181B33770")]
	public static EAKPIODIEFB<HOGMOCHAFIO<TMarker?>, KBBKEBHLFJL<TMarker?>> JOLJGLCLNAF<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5190", Offset = "0x6F4590")] HOGMOCHAFIO<TMarker?> KEDOIIDKEHL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F51F0", Offset = "0x6F45F0")] HOGMOCHAFIO<TMarker?> MHEEIBGCGEK)
	{
		return default(EAKPIODIEFB<HOGMOCHAFIO<TMarker>, KBBKEBHLFJL<TMarker>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1B337B0", Offset = "0x1B329B0", VA = "0x181B337B0")]
	public static EAKPIODIEFB<HOGMOCHAFIO<TMarker?>, KBBKEBHLFJL<TMarker?>> PCBNIJANKHO<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5250", Offset = "0x6F4650")] HOGMOCHAFIO<TMarker?> MHEEIBGCGEK)
	{
		return default(EAKPIODIEFB<HOGMOCHAFIO<TMarker>, KBBKEBHLFJL<TMarker>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class ICNLLKLFGID<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2103A00", Offset = "0x2102C00", VA = "0x182103A00")]
	public static HOGMOCHAFIO<TOther> BDBDLEPDHLC<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F52B0", Offset = "0x6F46B0")] HOGMOCHAFIO<TMarker> KPIHKJNPOFH) where TMarker : TOther
	{
		return default(HOGMOCHAFIO<TOther>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PIDKNOALEAM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	NPJIJDMGBJO FJJDCLLBCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KBDGMGDGEPA
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x23E5850", Offset = "0x23E4A50", VA = "0x1823E5850")]
	public static bool IHFHDKJMHFG<TSelf>(this TSelf KPIHKJNPOFH) where TSelf : notnull, PIDKNOALEAM
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KBBKEBHLFJL<M> : IEnumerator<HOGMOCHAFIO<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly int KGHGLPDMOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly int EFMBOAHKMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int DJLGBDPOJNB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5310", Offset = "0x6F4710")]
	public readonly HOGMOCHAFIO<M> JLCKGMHIDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x22CDE60", Offset = "0x22CD060", VA = "0x1822CDE60", Slot = "4")]
		get
		{
			return default(HOGMOCHAFIO<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x22CDD80", Offset = "0x22CCF80", VA = "0x1822CDD80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1843600", Offset = "0x1842800", VA = "0x181843600")]
	internal KBBKEBHLFJL(int LKBPLHPECGK, int MHEEIBGCGEK, int MIAMOCAHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
	public readonly void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x22CDD60", Offset = "0x22CCF60", VA = "0x1822CDD60", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x22CDD70", Offset = "0x22CCF70", VA = "0x1822CDD70", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class GMHJLJKGJPE
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B9F0", Offset = "0x1E2ABF0", VA = "0x181E2B9F0")]
	public static KBBKEBHLFJL<M?> HBHNAKPOBBF<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F53D0", Offset = "0x6F47D0")] HOGMOCHAFIO<M?> KEDOIIDKEHL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5430", Offset = "0x6F4830")] HOGMOCHAFIO<M?> MHEEIBGCGEK)
	{
		return default(KBBKEBHLFJL<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BA30", Offset = "0x1E2AC30", VA = "0x181E2BA30")]
	public static EAKPIODIEFB<HOGMOCHAFIO<M?>, KBBKEBHLFJL<M?>> HPPNCGBFFLH<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5490", Offset = "0x6F4890")] HOGMOCHAFIO<M?> KEDOIIDKEHL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F54F0", Offset = "0x6F48F0")] HOGMOCHAFIO<M?> MHEEIBGCGEK)
	{
		return default(EAKPIODIEFB<HOGMOCHAFIO<M>, KBBKEBHLFJL<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct CDPONBOPPFM<M> : IEnumerator<HOGMOCHAFIO<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly int CKMPKBGJILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int DJLGBDPOJNB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5550", Offset = "0x6F4950")]
	public readonly HOGMOCHAFIO<M> JLCKGMHIDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1E50700", Offset = "0x1E4F900", VA = "0x181E50700", Slot = "4")]
		get
		{
			return default(HOGMOCHAFIO<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1E50670", Offset = "0x1E4F870", VA = "0x181E50670", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A50", Offset = "0x8B5C50", VA = "0x1808B6A50")]
	private CDPONBOPPFM(int BKHJHJOLNNF, int MIAMOCAHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1E50620", Offset = "0x1E4F820", VA = "0x181E50620")]
	public static CDPONBOPPFM<M> CMPIDBBFCHB(int BKHJHJOLNNF)
	{
		return default(CDPONBOPPFM<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1E50650", Offset = "0x1E4F850", VA = "0x181E50650", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1E50660", Offset = "0x1E4F860", VA = "0x181E50660", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class AMJMCCAEGFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F67550", Offset = "0x6F66750", VA = "0x186F67550")]
	public static ODALILEPPCC IOAMGHHAJNN(this in DDAEIDDGCJK KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F675E0", Offset = "0x6F667E0", VA = "0x186F675E0")]
	public static DDAEIDDGCJK JHIOLOAEPHF(this ODALILEPPCC KPIHKJNPOFH)
	{
		return default(DDAEIDDGCJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F67470", Offset = "0x6F66670", VA = "0x186F67470")]
	public static ODALILEPPCC? CBADCGAGOLH(this in DDAEIDDGCJK? KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F676A0", Offset = "0x6F668A0", VA = "0x186F676A0")]
	public static DDAEIDDGCJK? MLBCGDMFGJD(this ODALILEPPCC? KPIHKJNPOFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct NNDHFAJHACK<TMarker> : IEquatable<NNDHFAJHACK<TMarker>>, JGMIOPFGKLF<NNDHFAJHACK<TMarker>>, IComparable<NNDHFAJHACK<TMarker>> where TMarker : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Guid HEIKMODINOK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5990", Offset = "0x6F4D90")]
	public static NNDHFAJHACK<TMarker> LKJHINFHCEL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2D709B0", Offset = "0x2D6FBB0", VA = "0x182D709B0")]
		get
		{
			return default(NNDHFAJHACK<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5A00", Offset = "0x6F4E00")]
	public static NNDHFAJHACK<TMarker>? AHLBMOKDHKH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2D70770", Offset = "0x2D6F970", VA = "0x182D70770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x208D210", Offset = "0x208C410", VA = "0x18208D210")]
	public NNDHFAJHACK(in Guid NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2D70870", Offset = "0x2D6FA70", VA = "0x182D70870")]
	public GGIKFALBCEL? IOAMGHHAJNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2D706A0", Offset = "0x2D6F8A0", VA = "0x182D706A0")]
	public bool AGDAPBIFCOO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5630", Offset = "0x6F4A30")] in NNDHFAJHACK<TMarker> JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2D70700", Offset = "0x2D6F900", VA = "0x182D70700", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F56A0", Offset = "0x6F4AA0")] NNDHFAJHACK<TMarker> JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x259C430", Offset = "0x259B630", VA = "0x18259C430", Slot = "0")]
	public override bool Equals(object JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2D706D0", Offset = "0x2D6F8D0", VA = "0x182D706D0", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5700", Offset = "0x6F4B00")] NNDHFAJHACK<TMarker> JMNBIHILIIC)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2D70700", Offset = "0x2D6F900", VA = "0x182D70700")]
	public static bool IJMFMDJGAHN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5760", Offset = "0x6F4B60")] in NNDHFAJHACK<TMarker> NPCLKEGHIKP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F57D0", Offset = "0x6F4BD0")] in NNDHFAJHACK<TMarker> NCHMBLEIGHE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2D70AB0", Offset = "0x2D6FCB0", VA = "0x182D70AB0")]
	public static bool PFFDPAELFMB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5840", Offset = "0x6F4C40")] in NNDHFAJHACK<TMarker> NPCLKEGHIKP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F58B0", Offset = "0x6F4CB0")] in NNDHFAJHACK<TMarker> NCHMBLEIGHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2D70750", Offset = "0x2D6F950", VA = "0x182D70750", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2D70B10", Offset = "0x2D6FD10", VA = "0x182D70B10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2D70700", Offset = "0x2D6F900", VA = "0x182D70700", Slot = "5")]
	private bool DPJAADMLBLM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5920", Offset = "0x6F4D20")] in NNDHFAJHACK<TMarker> JMNBIHILIIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OCCIFEMODMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3225800", Offset = "0x3224A00", VA = "0x183225800")]
	public static NNDHFAJHACK<TMarker?> JHIOLOAEPHF<TMarker>(this GGIKFALBCEL? KPIHKJNPOFH)
	{
		return default(NNDHFAJHACK<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x32257D0", Offset = "0x32249D0", VA = "0x1832257D0")]
	public static NNDHFAJHACK<TMarker?> CDEDBHKFAGP<TMarker>(this in Guid KPIHKJNPOFH)
	{
		return default(NNDHFAJHACK<TMarker>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class HDJLOLMDGHM<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5AB0", Offset = "0x6F4EB0")]
	internal static readonly NNDHFAJHACK<TOther> LKJHINFHCEL;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5B10", Offset = "0x6F4F10")]
	internal static readonly NNDHFAJHACK<TOther>? AHLBMOKDHKH;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public readonly struct KHCMLBEHALN<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5BE0", Offset = "0x6F4FE0")]
	private readonly HPADLKOPCDF<T> PNAKAFIEMIK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5D00", Offset = "0x6F5100")]
	public HOGMOCHAFIO<M> IBBPKBDNAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2299940", Offset = "0x2298B40", VA = "0x182299940")]
		get
		{
			return default(HOGMOCHAFIO<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int CKAIEHNDOML
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2299790", Offset = "0x2298990", VA = "0x182299790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2299820", Offset = "0x2298A20", VA = "0x182299820")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x210C890", Offset = "0x210BA90", VA = "0x18210C890")]
	internal KHCMLBEHALN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5CA0", Offset = "0x6F50A0")] HPADLKOPCDF<T> LMFDNLBGHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2299910", Offset = "0x2298B10", VA = "0x182299910")]
	public IEnumerable<T> NJBHDBHLAKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2299750", Offset = "0x2298950", VA = "0x182299750")]
	public IEnumerator<T> EEOIHAEEMHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2299A00", Offset = "0x2298C00", VA = "0x182299A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HHHBNPEAPNC<M>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x20FFF50", Offset = "0x20FF150", VA = "0x1820FFF50")]
	public static KHCMLBEHALN<M, T> LIKFLKLFOKA<T>(params T[] LMFDNLBGHBA) where T : notnull
	{
		return default(KHCMLBEHALN<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class JLCMDNKGFJD
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6F684D0", Offset = "0x6F676D0", VA = "0x186F684D0")]
	public static PEBKLLAMGGO IOAMGHHAJNN(this in HBNLMECNNNL KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F68570", Offset = "0x6F67770", VA = "0x186F68570")]
	public static HBNLMECNNNL JHIOLOAEPHF(this PEBKLLAMGGO KPIHKJNPOFH)
	{
		return default(HBNLMECNNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F683E0", Offset = "0x6F675E0", VA = "0x186F683E0")]
	public static PEBKLLAMGGO? CBADCGAGOLH(this in HBNLMECNNNL? KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F68660", Offset = "0x6F67860", VA = "0x186F68660")]
	public static HBNLMECNNNL? MLBCGDMFGJD(this PEBKLLAMGGO? KPIHKJNPOFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct HBNLMECNNNL : IEquatable<HBNLMECNNNL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly float CADEIOCAGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly float MHJALIMNEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly float ILCJMLJOOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly float EIFDBDHEMCM;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly HBNLMECNNNL LAFLOOCDPHH;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly HBNLMECNNNL INALKMMPBEH;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly HBNLMECNNNL JMBBEIHEPCJ;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly HBNLMECNNNL BALNLNOPKII;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly HBNLMECNNNL JHDJLNMMBDP;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2092550", Offset = "0x2091750", VA = "0x182092550")]
	public HBNLMECNNNL(float JPBGAMDOIJA, float IIJHAMIHIMK, float BKHNPAHKPOJ, float PAOCKMKCBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F68020", Offset = "0x6F67220", VA = "0x186F68020")]
	public static HBNLMECNNNL HBHNAKPOBBF(float JPBGAMDOIJA, float IIJHAMIHIMK, float BKHNPAHKPOJ, float PAOCKMKCBDM)
	{
		return default(HBNLMECNNNL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F6C0", Offset = "0x5E4E8C0", VA = "0x185E4F6C0")]
	public static bool IJMFMDJGAHN(in HBNLMECNNNL MHFLHKLCNGM, in HBNLMECNNNL NKPGENLIMOI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F68040", Offset = "0x6F67240", VA = "0x186F68040")]
	public static bool PFFDPAELFMB(in HBNLMECNNNL MHFLHKLCNGM, in HBNLMECNNNL NKPGENLIMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F67F80", Offset = "0x6F67180", VA = "0x186F67F80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F67E00", Offset = "0x6F67000", VA = "0x186F67E00", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F680E0", Offset = "0x6F672E0", VA = "0x186F680E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F67EE0", Offset = "0x6F670E0", VA = "0x186F67EE0", Slot = "4")]
	public bool Equals(HBNLMECNNNL JMNBIHILIIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct FJIEOAJLKJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly float LBINEJDBEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly float NBINJCDLHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly float LPGDLCBGPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly float OEODBKDAFEE;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly FJIEOAJLKJN KBBPDAPPOIP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly FJIEOAJLKJN PDDKNIFGCDK;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2092550", Offset = "0x2091750", VA = "0x182092550")]
	public FJIEOAJLKJN(float CINIEBHLBCG, float PPEAACBOMIK, float PIINDHALINJ, float GGFLAOCNMAP)
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
