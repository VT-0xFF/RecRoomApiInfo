using System;
using System.Collections.Generic;
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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AE8BB0", Offset = "0x2AE79B0", VA = "0x182AE8BB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct LKALJGIPFPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> ICDGLOEIMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int CFPFFIDODCG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xEABD50", Offset = "0xEAAB50", VA = "0x180EABD50")]
	public LKALJGIPFPG(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> HFACKDKFNFO, int IBOFMHFOKKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct ALBLCFELFHL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class INHADOMGABD : MKOHIFOBACH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct EOEEDBIPIGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly GJPAHHJEFHG<byte> MCNNDONHLEP;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2A81460", Offset = "0x2A80260", VA = "0x182A81460")]
		public EOEEDBIPIGH(GJPAHHJEFHG<byte> JICDOIHAMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE6C0", Offset = "0x2ADD4C0", VA = "0x182ADE6C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class OOKLADEJGPJ : MKOHIFOBACH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct LNCKKIABDDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> MGHJBJAMLAE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0")]
		public LNCKKIABDDC(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> POIENBLDLLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DFLCOIEECIM
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		BytesImmediate,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		X32Immediate
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class GPFIOGMCCAN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class MKOHIFOBACH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct OPJDDOHONEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly DFLCOIEECIM GADMADJMFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly PFJMKELOBBL<MKOHIFOBACH> MEFKPCGJDKB;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEABD50", Offset = "0xEAAB50", VA = "0x180EABD50")]
		public OPJDDOHONEI(DFLCOIEECIM LKDMCKBGOML, PFJMKELOBBL<MKOHIFOBACH> AKHHOHOJOJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class JPLGPHKIDNI : MKOHIFOBACH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct FJGENOKNIDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> HFKOBHINDMB;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0")]
		public FJGENOKNIDF(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> PHAFBFKNEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class PBAMLAIIJCP : MKOHIFOBACH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct LCNIHMFJIAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly FHLAGALJACB IMKNIPHKHND;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0")]
		public LCNIHMFJIAC(FHLAGALJACB OACCJBNMHCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7A30", Offset = "0x2AE6830", VA = "0x182AE7A30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal JKNDGKAANNB<GPFIOGMCCAN, OPJDDOHONEI> MOECNAEPNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal JKNDGKAANNB<INHADOMGABD, EOEEDBIPIGH> KEPGJAJPLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal JKNDGKAANNB<OOKLADEJGPJ, LNCKKIABDDC> NNBEDEHIKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal JKNDGKAANNB<JPLGPHKIDNI, FJGENOKNIDF> DMMONCCNAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal JKNDGKAANNB<PBAMLAIIJCP, LCNIHMFJIAC> BOOOCHIJBDI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2ADDC10", Offset = "0x2ADCA10", VA = "0x182ADDC10")]
	private ALBLCFELFHL([In] JKNDGKAANNB<GPFIOGMCCAN, OPJDDOHONEI> FJCEIGNGHBI, [In] JKNDGKAANNB<INHADOMGABD, EOEEDBIPIGH> IGONDGDKKOA, [In] JKNDGKAANNB<OOKLADEJGPJ, LNCKKIABDDC> CBNIOHEIIDN, [In] JKNDGKAANNB<JPLGPHKIDNI, FJGENOKNIDF> FIBOLLBADND, [In] JKNDGKAANNB<PBAMLAIIJCP, LCNIHMFJIAC> FEGNPNIMNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2ADDAD0", Offset = "0x2ADC8D0", VA = "0x182ADDAD0")]
	public static ALBLCFELFHL ELDPFIHNJDG()
	{
		return default(ALBLCFELFHL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MOAOHAJBIDD
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8A50", Offset = "0x2AE7850", VA = "0x182AE8A50")]
	public static void MFDBANBONAB(this ALBLCFELFHL DBBEADIHLKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum OBKHCBMBPEF
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Bytes,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Class
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct EFJGPOMGHIA
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class FADFDHDMFFA : MBLMIOEBNFP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct AAOBHOFJAED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> KDFLKODICDN;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0")]
		public AAOBHOFJAED(PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> LNDMPPLDBNJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum AJAIGAEGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Branch,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		DeadEndData,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		NodeAlreadyVisited,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		NodeCantVisit,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		OutNode
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class BIHJKPIFONH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class MBLMIOEBNFP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct LEJLPBPKIBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly AJAIGAEGNAM GADMADJMFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly PFJMKELOBBL<MBLMIOEBNFP> MEFKPCGJDKB;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xEABD50", Offset = "0xEAAB50", VA = "0x180EABD50")]
		public LEJLPBPKIBI(AJAIGAEGNAM LKDMCKBGOML, PFJMKELOBBL<MBLMIOEBNFP> AKHHOHOJOJI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal JKNDGKAANNB<BIHJKPIFONH, LEJLPBPKIBI> MOECNAEPNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal JKNDGKAANNB<FADFDHDMFFA, AAOBHOFJAED> LPKCGHNPBGG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE3F0", Offset = "0x2ADD1F0", VA = "0x182ADE3F0")]
	private EFJGPOMGHIA([In] JKNDGKAANNB<BIHJKPIFONH, LEJLPBPKIBI> FJCEIGNGHBI, [In] JKNDGKAANNB<FADFDHDMFFA, AAOBHOFJAED> HJDOOCNICPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE360", Offset = "0x2ADD160", VA = "0x182ADE360")]
	public static EFJGPOMGHIA ELDPFIHNJDG()
	{
		return default(EFJGPOMGHIA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HAIOIPJGGKC
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3DE0", Offset = "0x2AE2BE0", VA = "0x182AE3DE0")]
	public static void MFDBANBONAB(this EFJGPOMGHIA DBBEADIHLKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HJFMAKHAHJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public MHNDIBEMFIN<int> IGFJKGDCJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public MHNDIBEMFIN<int> PMENEGIJMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int JGJLEAIKHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int AGJMNHEPCBP;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3F60", Offset = "0x2AE2D60", VA = "0x182AE3F60")]
	private HJFMAKHAHJE([In] MHNDIBEMFIN<int> GEBHBPKKBJI, [In] MHNDIBEMFIN<int> HEBAACGMFBJ, int JOIOFJFJANM, int GBPJGFPDLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3EC0", Offset = "0x2AE2CC0", VA = "0x182AE3EC0")]
	public static HJFMAKHAHJE ELDPFIHNJDG()
	{
		return default(HJFMAKHAHJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class BALAPIMGKCO
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2ADDD60", Offset = "0x2ADCB60", VA = "0x182ADDD60")]
	public static void MFDBANBONAB(this HJFMAKHAHJE DBBEADIHLKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct KCNADLCKFJC
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum MBCJCLLMKKF
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class MLFJLNOOBLI : HMAFCHMPGMM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct ACOLCKBILFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly PFJMKELOBBL<KPLOHEGIHDL> FLEBPFMEPCC;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0")]
		public ACOLCKBILFJ(PFJMKELOBBL<KPLOHEGIHDL> NOBJEAANMKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class BHGEFLOOADB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class HMAFCHMPGMM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct DHLKBBBJCCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly MBCJCLLMKKF GADMADJMFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly PFJMKELOBBL<HMAFCHMPGMM> MEFKPCGJDKB;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xEABD50", Offset = "0xEAAB50", VA = "0x180EABD50")]
		private DHLKBBBJCCC(MBCJCLLMKKF LKDMCKBGOML, PFJMKELOBBL<HMAFCHMPGMM> AKHHOHOJOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE240", Offset = "0x2ADD040", VA = "0x182ADE240")]
		public static DHLKBBBJCCC ELDPFIHNJDG(MBCJCLLMKKF LKDMCKBGOML, PFJMKELOBBL<HMAFCHMPGMM> AKHHOHOJOJI)
		{
			return default(DHLKBBBJCCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class HLKLCFKJLKK : HMAFCHMPGMM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct CKOAPJDDCIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly PFJMKELOBBL<KPLOHEGIHDL> FLEBPFMEPCC;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0")]
		public CKOAPJDDCIH(PFJMKELOBBL<KPLOHEGIHDL> NOBJEAANMKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class KPLOHEGIHDL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct IKEILOJFGPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public MHNDIBEMFIN<PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>> HEOKEOPCLLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public MHNDIBEMFIN<PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>> JADMGNFILNK;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE3F0", Offset = "0x2ADD1F0", VA = "0x182ADE3F0")]
		private IKEILOJFGPK([In] MHNDIBEMFIN<PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>> BNOPOAPPFBM, [In] MHNDIBEMFIN<PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>> PMEADJABHAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4CD0", Offset = "0x2AE3AD0", VA = "0x182AE4CD0")]
		public static IKEILOJFGPK ELDPFIHNJDG()
		{
			return default(IKEILOJFGPK);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal JKNDGKAANNB<BHGEFLOOADB, DHLKBBBJCCC> MOECNAEPNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal JKNDGKAANNB<HLKLCFKJLKK, CKOAPJDDCIH> GNBIOAOLDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal JKNDGKAANNB<MLFJLNOOBLI, ACOLCKBILFJ> DLJCHEOCLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal MHNDIBEMFIN<(PFJMKELOBBL<BHGEFLOOADB> CallId, PFJMKELOBBL<KPLOHEGIHDL> IOId)> JBIPLIGOAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal JKNDGKAANNB<KPLOHEGIHDL, IKEILOJFGPK> DJBHLHIGPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal DMCDLOLKCAK<KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>> PKDAMBPLFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal DMCDLOLKCAK<KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>> PIFKJKBPIKN;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5190", Offset = "0x2AE3F90", VA = "0x182AE5190")]
	private KCNADLCKFJC([In] JKNDGKAANNB<BHGEFLOOADB, DHLKBBBJCCC> FJCEIGNGHBI, [In] JKNDGKAANNB<HLKLCFKJLKK, CKOAPJDDCIH> PGJOCMPIPBK, [In] JKNDGKAANNB<MLFJLNOOBLI, ACOLCKBILFJ> HEAIOJDMKNF, [In] MHNDIBEMFIN<(PFJMKELOBBL<BHGEFLOOADB> CallId, PFJMKELOBBL<KPLOHEGIHDL> IOId)> EKBIFEKDBBI, [In] JKNDGKAANNB<KPLOHEGIHDL, IKEILOJFGPK> GFJHOFAPOPF, [In] DMCDLOLKCAK<KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>> KKAKNIOKKBF, [In] DMCDLOLKCAK<KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>> DMKMCOHPKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4FF0", Offset = "0x2AE3DF0", VA = "0x182AE4FF0")]
	public static KCNADLCKFJC ELDPFIHNJDG()
	{
		return default(KCNADLCKFJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class MHHPMKAPCKA
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8A00", Offset = "0x2AE7800", VA = "0x182AE8A00")]
	private static void MFDBANBONAB(this KCNADLCKFJC.IKEILOJFGPK DBBEADIHLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2AE87F0", Offset = "0x2AE75F0", VA = "0x182AE87F0")]
	public static void MFDBANBONAB(this KCNADLCKFJC DBBEADIHLKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct HMOPEEKMPBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public MHNDIBEMFIN<byte> EBIINBAJIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal KCNADLCKFJC LCAKJAJMECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal OBDMNEHPBKE EFOPJBHEPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>> AFGJNJFJEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal ALBLCFELFHL IKMDKCGGLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal EFJGPOMGHIA IDEMFGGGEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal DMCDLOLKCAK<ONHJNBAOPLN, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>?> IOBKPMCAOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal MHNDIBEMFIN<PFJMKELOBBL<ONHJNBAOPLN>> EONOFGFJDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal DMCDLOLKCAK<JNPLKINCBGM, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>?> DIFEPHDDOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal MHNDIBEMFIN<(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> VariableId, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<BFKJLNKNPDF>>> ByteCodeWriteLocation)> JBAMLNGMBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> CNCLIKFEHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal LAJNPNMMOMC BJCDENNAJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal MBOPIPCFNGB BBIPIPLKIBN;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4970", Offset = "0x2AE3770", VA = "0x182AE4970")]
	private HMOPEEKMPBE([In] MHNDIBEMFIN<byte> HNOIHKILNDG, [In] KCNADLCKFJC HBILDFGBCLH, [In] OBDMNEHPBKE FGPAOLJIJNC, [In] ALBLCFELFHL PNKNHCMEDML, [In] EFJGPOMGHIA BHDGNBOJOKG, [In] DMCDLOLKCAK<ONHJNBAOPLN, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>?> NEMCCAOKGHK, [In] MHNDIBEMFIN<PFJMKELOBBL<ONHJNBAOPLN>> IMJIPGNCPAI, [In] DMCDLOLKCAK<JNPLKINCBGM, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>?> LGJIFCNLMLC, [In] MHNDIBEMFIN<(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> VariableId, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<BFKJLNKNPDF>>> ByteCodeWriteLocation)> JCNOAJJLONK, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> PFMDLLEEINF, [In] LAJNPNMMOMC JNKEJNEPEHO, [In] MBOPIPCFNGB CJLGKFKJAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3FC0", Offset = "0x2AE2DC0", VA = "0x182AE3FC0")]
	public static HMOPEEKMPBE ELDPFIHNJDG()
	{
		return default(HMOPEEKMPBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KKJKKMAONCF
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct AMBHGMOCFKM : NJNNCEPDGMG<PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>, DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDCA0", Offset = "0x2ADCAA0", VA = "0x182ADDCA0")]
		public PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> BDGPBPOMKHO(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> JJJJBEGKNIN, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDD20", Offset = "0x2ADCB20", VA = "0x182ADDD20", Slot = "4")]
		public PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> HIIMEPIEFJN(int JJJJBEGKNIN)
		{
			return default(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660")]
		public bool ODANLAELGLD(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> JJJJBEGKNIN, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>> OOFDDMCKJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "5")]
		private bool FKPLCIKLENP(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> JJJJBEGKNIN, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>> OOFDDMCKJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDCA0", Offset = "0x2ADCAA0", VA = "0x182ADDCA0", Slot = "6")]
		private PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> NGANPMCDCIA(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> JJJJBEGKNIN, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct LIAAHONPAED : PHJMANJJEGP<PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>, DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8530", Offset = "0x2AE7330", VA = "0x182AE8530")]
		public MHNDIBEMFIN<PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>> BNOEGLDMEFG(int FCPPFPJENLA, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>> OOFDDMCKJPA)
		{
			return default(MHNDIBEMFIN<PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2AE85A0", Offset = "0x2AE73A0", VA = "0x182AE85A0")]
		public PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> BDGPBPOMKHO(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> JJJJBEGKNIN, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8620", Offset = "0x2AE7420", VA = "0x182AE8620", Slot = "6")]
		public void KNLNMHDHCKG(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> JJJJBEGKNIN, DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>> OOFDDMCKJPA, PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> HGMAIPELJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8530", Offset = "0x2AE7330", VA = "0x182AE8530", Slot = "4")]
		private MHNDIBEMFIN<PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>> AALCCIDHPOE(int FCPPFPJENLA, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>> OOFDDMCKJPA)
		{
			return default(MHNDIBEMFIN<PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2AE85A0", Offset = "0x2AE73A0", VA = "0x182AE85A0", Slot = "5")]
		private PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> KLNGCHDIJPA(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> JJJJBEGKNIN, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct NJOIFOEJIFP : NJNNCEPDGMG<PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>, DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8B00", Offset = "0x2AE7900", VA = "0x182AE8B00")]
		public PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> BDGPBPOMKHO(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> JJJJBEGKNIN, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8B80", Offset = "0x2AE7980", VA = "0x182AE8B80", Slot = "4")]
		public PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> HIIMEPIEFJN(int JJJJBEGKNIN)
		{
			return default(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660")]
		public bool ODANLAELGLD(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> JJJJBEGKNIN, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>> OOFDDMCKJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "5")]
		private bool EPJFHNOIBKG(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> JJJJBEGKNIN, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>> OOFDDMCKJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8B00", Offset = "0x2AE7900", VA = "0x182AE8B00", Slot = "6")]
		private PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> PODINODBMEG(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> JJJJBEGKNIN, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct FPGLFKAJJKN : PHJMANJJEGP<PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>, DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE880", Offset = "0x2ADD680", VA = "0x182ADE880")]
		public MHNDIBEMFIN<PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>> BNOEGLDMEFG(int FCPPFPJENLA, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>> OOFDDMCKJPA)
		{
			return default(MHNDIBEMFIN<PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE800", Offset = "0x2ADD600", VA = "0x182ADE800")]
		public PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> BDGPBPOMKHO(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> JJJJBEGKNIN, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE8F0", Offset = "0x2ADD6F0", VA = "0x182ADE8F0", Slot = "6")]
		public void KNLNMHDHCKG(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> JJJJBEGKNIN, DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>> OOFDDMCKJPA, PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> HGMAIPELJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE880", Offset = "0x2ADD680", VA = "0x182ADE880", Slot = "4")]
		private MHNDIBEMFIN<PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>> GCHOJJINFLE(int FCPPFPJENLA, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>> OOFDDMCKJPA)
		{
			return default(MHNDIBEMFIN<PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE800", Offset = "0x2ADD600", VA = "0x182ADE800", Slot = "5")]
		private PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> FGDLFJHCNKK(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> JJJJBEGKNIN, [In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct JCCGJBLIJGB : NJNNCEPDGMG<PFJMKELOBBL<JNPLKINCBGM>, DMCDLOLKCAK<JNPLKINCBGM, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4D50", Offset = "0x2AE3B50", VA = "0x182AE4D50")]
		public PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> BDGPBPOMKHO(PFJMKELOBBL<JNPLKINCBGM> JJJJBEGKNIN, [In] DMCDLOLKCAK<JNPLKINCBGM, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>?> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4DF0", Offset = "0x2AE3BF0", VA = "0x182AE4DF0", Slot = "4")]
		public PFJMKELOBBL<JNPLKINCBGM> HIIMEPIEFJN(int JJJJBEGKNIN)
		{
			return default(PFJMKELOBBL<JNPLKINCBGM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4E20", Offset = "0x2AE3C20", VA = "0x182AE4E20")]
		public bool ODANLAELGLD(PFJMKELOBBL<JNPLKINCBGM> JJJJBEGKNIN, [In] DMCDLOLKCAK<JNPLKINCBGM, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>?> OOFDDMCKJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4E20", Offset = "0x2AE3C20", VA = "0x182AE4E20", Slot = "5")]
		private bool OGAANMMDOJF(PFJMKELOBBL<JNPLKINCBGM> JJJJBEGKNIN, [In] DMCDLOLKCAK<JNPLKINCBGM, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>?> OOFDDMCKJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2AE4E80", Offset = "0x2AE3C80", VA = "0x182AE4E80", Slot = "6")]
		private PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> OPJCBJNEDMM(PFJMKELOBBL<JNPLKINCBGM> JJJJBEGKNIN, [In] DMCDLOLKCAK<JNPLKINCBGM, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>?> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct BOAMIKFLKAB : PHJMANJJEGP<PFJMKELOBBL<JNPLKINCBGM>, DMCDLOLKCAK<JNPLKINCBGM, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE040", Offset = "0x2ADCE40", VA = "0x182ADE040")]
		public MHNDIBEMFIN<PFJMKELOBBL<JNPLKINCBGM>> BNOEGLDMEFG(int FCPPFPJENLA, [In] DMCDLOLKCAK<JNPLKINCBGM, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>?> OOFDDMCKJPA)
		{
			return default(MHNDIBEMFIN<PFJMKELOBBL<JNPLKINCBGM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDFA0", Offset = "0x2ADCDA0", VA = "0x182ADDFA0")]
		public PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> BDGPBPOMKHO(PFJMKELOBBL<JNPLKINCBGM> JJJJBEGKNIN, [In] DMCDLOLKCAK<JNPLKINCBGM, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>?> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE0C0", Offset = "0x2ADCEC0", VA = "0x182ADE0C0", Slot = "6")]
		public void KNLNMHDHCKG(PFJMKELOBBL<JNPLKINCBGM> JJJJBEGKNIN, DMCDLOLKCAK<JNPLKINCBGM, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>?> OOFDDMCKJPA, PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> HGMAIPELJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE040", Offset = "0x2ADCE40", VA = "0x182ADE040", Slot = "4")]
		private MHNDIBEMFIN<PFJMKELOBBL<JNPLKINCBGM>> DFGOGCDLHBM(int FCPPFPJENLA, [In] DMCDLOLKCAK<JNPLKINCBGM, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>?> OOFDDMCKJPA)
		{
			return default(MHNDIBEMFIN<PFJMKELOBBL<JNPLKINCBGM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE0B0", Offset = "0x2ADCEB0", VA = "0x182ADE0B0", Slot = "5")]
		private PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> EHLBOOJIEIB(PFJMKELOBBL<JNPLKINCBGM> JJJJBEGKNIN, [In] DMCDLOLKCAK<JNPLKINCBGM, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>?> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct EAKGLEPEGNI : NJNNCEPDGMG<int, MHNDIBEMFIN<(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<BFKJLNKNPDF>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE250", Offset = "0x2ADD050", VA = "0x182ADE250")]
		public PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> BDGPBPOMKHO(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> VariableId, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<BFKJLNKNPDF>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xBA7A50", Offset = "0xBA6850", VA = "0x180BA7A50", Slot = "4")]
		public int HIIMEPIEFJN(int JJJJBEGKNIN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660")]
		public bool ODANLAELGLD(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> VariableId, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<BFKJLNKNPDF>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "5")]
		private bool JBAJABHJDLD(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> VariableId, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<BFKJLNKNPDF>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE2D0", Offset = "0x2ADD0D0", VA = "0x182ADE2D0", Slot = "6")]
		private PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> ELEFHPHMLEE(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> VariableId, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<BFKJLNKNPDF>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct BEIDAAKKFJK : PHJMANJJEGP<int, MHNDIBEMFIN<(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<BFKJLNKNPDF>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDE30", Offset = "0x2ADCC30", VA = "0x182ADDE30")]
		public MHNDIBEMFIN<int> BNOEGLDMEFG(int FCPPFPJENLA, [In] MHNDIBEMFIN<(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> VariableId, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<BFKJLNKNPDF>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(MHNDIBEMFIN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDDB0", Offset = "0x2ADCBB0", VA = "0x182ADDDB0")]
		public PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> BDGPBPOMKHO(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> VariableId, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<BFKJLNKNPDF>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDEB0", Offset = "0x2ADCCB0", VA = "0x182ADDEB0", Slot = "6")]
		public void KNLNMHDHCKG(int JJJJBEGKNIN, MHNDIBEMFIN<(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> VariableId, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<BFKJLNKNPDF>>> ByteCodeWriteLocation)> OOFDDMCKJPA, PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> HGMAIPELJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDE30", Offset = "0x2ADCC30", VA = "0x182ADDE30", Slot = "4")]
		private MHNDIBEMFIN<int> LEGIHNKLEAL(int FCPPFPJENLA, [In] MHNDIBEMFIN<(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> VariableId, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<BFKJLNKNPDF>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(MHNDIBEMFIN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDEA0", Offset = "0x2ADCCA0", VA = "0x182ADDEA0", Slot = "5")]
		private PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> IPJPJFPKLOB(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> VariableId, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<BFKJLNKNPDF>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct HCDHONPNNLO : NJNNCEPDGMG<int, MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3E40", Offset = "0x2AE2C40", VA = "0x182AE3E40")]
		public PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> BDGPBPOMKHO(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xBA7A50", Offset = "0xBA6850", VA = "0x180BA7A50", Slot = "4")]
		public int HIIMEPIEFJN(int JJJJBEGKNIN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660")]
		public bool ODANLAELGLD(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "5")]
		private bool ELAGJFEAPJA(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3E40", Offset = "0x2AE2C40", VA = "0x182AE3E40", Slot = "6")]
		private PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> JENKADGDANE(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct LAFGICFBAGA : PHJMANJJEGP<int, MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7660", Offset = "0x2AE6460", VA = "0x182AE7660")]
		public MHNDIBEMFIN<int> BNOEGLDMEFG(int FCPPFPJENLA, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(MHNDIBEMFIN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2AE75E0", Offset = "0x2AE63E0", VA = "0x182AE75E0")]
		public PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> BDGPBPOMKHO(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2AE76D0", Offset = "0x2AE64D0", VA = "0x182AE76D0", Slot = "6")]
		public void KNLNMHDHCKG(int JJJJBEGKNIN, MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA, PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> HGMAIPELJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7660", Offset = "0x2AE6460", VA = "0x182AE7660", Slot = "4")]
		private MHNDIBEMFIN<int> HBJFGBOHPMP(int FCPPFPJENLA, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(MHNDIBEMFIN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2AE75E0", Offset = "0x2AE63E0", VA = "0x182AE75E0", Slot = "5")]
		private PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> HNNLNGFLDEF(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct FDBAFEIEBND : NJNNCEPDGMG<int, MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE730", Offset = "0x2ADD530", VA = "0x182ADE730")]
		public PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> BDGPBPOMKHO(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xBA7A50", Offset = "0xBA6850", VA = "0x180BA7A50", Slot = "4")]
		public int HIIMEPIEFJN(int JJJJBEGKNIN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660")]
		public bool ODANLAELGLD(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "5")]
		private bool ELAGJFEAPJA(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE7B0", Offset = "0x2ADD5B0", VA = "0x182ADE7B0", Slot = "6")]
		private PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> JENKADGDANE(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct EIIMFJANLPK : PHJMANJJEGP<int, MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE550", Offset = "0x2ADD350", VA = "0x182ADE550")]
		public MHNDIBEMFIN<int> BNOEGLDMEFG(int FCPPFPJENLA, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(MHNDIBEMFIN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE4D0", Offset = "0x2ADD2D0", VA = "0x182ADE4D0")]
		public PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> BDGPBPOMKHO(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE5D0", Offset = "0x2ADD3D0", VA = "0x182ADE5D0", Slot = "6")]
		public void KNLNMHDHCKG(int JJJJBEGKNIN, MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA, PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> HGMAIPELJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE550", Offset = "0x2ADD350", VA = "0x182ADE550", Slot = "4")]
		private MHNDIBEMFIN<int> HBJFGBOHPMP(int FCPPFPJENLA, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(MHNDIBEMFIN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE5C0", Offset = "0x2ADD3C0", VA = "0x182ADE5C0", Slot = "5")]
		private PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> HNNLNGFLDEF(int JJJJBEGKNIN, [In] MHNDIBEMFIN<(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> Target, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ByteCodeWriteLocation)> OOFDDMCKJPA)
		{
			return default(PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct KGJMIJHOJLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> OOOPIHCPDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool NCBLMPCPBNE;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2169090", Offset = "0x2167E90", VA = "0x182169090")]
		public KGJMIJHOJLG(PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> GPIDDMLNFEO, bool JCLGMAAHJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2AE5250", Offset = "0x2AE4050", VA = "0x182AE5250")]
		public void MLOAOPFMIPK([Out] PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> GPIDDMLNFEO, [Out] bool JCLGMAAHJKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct FJGLMENFJNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly PFJMKELOBBL<JNPLKINCBGM> CEEAKCCKDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> OOOPIHCPDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool NCBLMPCPBNE;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE7F0", Offset = "0x2ADD5F0", VA = "0x182ADE7F0")]
		public FJGLMENFJNL(PFJMKELOBBL<JNPLKINCBGM> MIJKDJMLDME, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> GPIDDMLNFEO, bool JCLGMAAHJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE7E0", Offset = "0x2ADD5E0", VA = "0x182ADE7E0")]
		public void MLOAOPFMIPK([Out] PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> GPIDDMLNFEO, [Out] bool JCLGMAAHJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE7C0", Offset = "0x2ADD5C0", VA = "0x182ADE7C0")]
		public void MLOAOPFMIPK([Out] PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> GPIDDMLNFEO, [Out] PFJMKELOBBL<JNPLKINCBGM> MIJKDJMLDME, [Out] bool JCLGMAAHJKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct AMMCFNKIONC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly PFJMKELOBBL<JNPLKINCBGM> CEEAKCCKDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> OOOPIHCPDBC;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xEABD50", Offset = "0xEAAB50", VA = "0x180EABD50")]
		public AMMCFNKIONC(PFJMKELOBBL<JNPLKINCBGM> MIJKDJMLDME, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> GPIDDMLNFEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDD50", Offset = "0x2ADCB50", VA = "0x182ADDD50")]
		public void MLOAOPFMIPK([Out] PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> GPIDDMLNFEO, [Out] PFJMKELOBBL<JNPLKINCBGM> MIJKDJMLDME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6840", Offset = "0x2AE5640", VA = "0x182AE6840")]
	public static void MFDBANBONAB(this HMOPEEKMPBE DBBEADIHLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6430", Offset = "0x2AE5230", VA = "0x182AE6430")]
	public static void KBEPJLNLFCM(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<ONHJNBAOPLN> NKEMHBDJJGG, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> PCDJJDOJEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6B10", Offset = "0x2AE5910", VA = "0x182AE6B10")]
	public static void MGFKLHIKHGM(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<ONHJNBAOPLN> NKEMHBDJJGG, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> PCDJJDOJEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2AE54E0", Offset = "0x2AE42E0", VA = "0x182AE54E0")]
	public static PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>? BAEHPIGJKEN([In] this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<ONHJNBAOPLN> NKEMHBDJJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5CB0", Offset = "0x2AE4AB0", VA = "0x182AE5CB0")]
	public static PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> GIAOKELPAHG([In] this HMOPEEKMPBE DBBEADIHLKO)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2AE55C0", Offset = "0x2AE43C0", VA = "0x182AE55C0")]
	private static void BKJOAEBFFDJ(this HMOPEEKMPBE DBBEADIHLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7120", Offset = "0x2AE5F20", VA = "0x182AE7120")]
	private static PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>? OFHOGAPNPHJ([In] this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<JNPLKINCBGM> MIJKDJMLDME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE52C0", Offset = "0x2AE40C0", VA = "0x182AE52C0")]
	public static void AELCFBHNGMA(this HMOPEEKMPBE DBBEADIHLKO, [In] MHNDIBEMFIN<LKALJGIPFPG> ILIHHOHAEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6080", Offset = "0x2AE4E80", VA = "0x182AE6080")]
	public static ALBLCFELFHL.DFLCOIEECIM IJOLMAEPCJJ([In] this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> GPIDDMLNFEO)
	{
		return default(ALBLCFELFHL.DFLCOIEECIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6380", Offset = "0x2AE5180", VA = "0x182AE6380")]
	public static GJPAHHJEFHG<byte> JPHAEIGIECB([In] this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> GPIDDMLNFEO)
	{
		return default(GJPAHHJEFHG<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5C00", Offset = "0x2AE4A00", VA = "0x182AE5C00")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> GHKMEAOBDJN([In] this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> GPIDDMLNFEO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE61A0", Offset = "0x2AE4FA0", VA = "0x182AE61A0")]
	public static FHLAGALJACB JAEINEGAOKO([In] this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> GPIDDMLNFEO)
	{
		return default(FHLAGALJACB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3DB3A20", Offset = "0x3DB2820", VA = "0x183DB3A20")]
	private static PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> ECFMBJPCOEA<TMJoin>(this HMOPEEKMPBE DBBEADIHLKO, ALBLCFELFHL.DFLCOIEECIM LKDMCKBGOML, PFJMKELOBBL<TMJoin> AKHHOHOJOJI) where TMJoin : ALBLCFELFHL.MKOHIFOBACH
	{
		return default(PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7560", Offset = "0x2AE6360", VA = "0x182AE7560")]
	public static PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> POEDFNLMECF(this HMOPEEKMPBE DBBEADIHLKO, bool IOCGGJPDOAL)
	{
		return default(PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6BE0", Offset = "0x2AE59E0", VA = "0x182AE6BE0")]
	public static PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> MIDFLNOPHMG(this HMOPEEKMPBE DBBEADIHLKO, GJPAHHJEFHG<byte> JICDOIHAMGB)
	{
		return default(PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6E90", Offset = "0x2AE5C90", VA = "0x182AE6E90")]
	public static PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> NHPONHBGGGM(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> POIENBLDLLG)
	{
		return default(PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2AE57D0", Offset = "0x2AE45D0", VA = "0x182AE57D0")]
	public static PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> DINPNJOGIJI(this HMOPEEKMPBE DBBEADIHLKO, int PHJFCOKPIBC)
	{
		return default(PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5B20", Offset = "0x2AE4920", VA = "0x182AE5B20")]
	public static PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> FGPMIOLKDGA(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> PHAFBFKNEGG)
	{
		return default(PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3DB5190", Offset = "0x3DB3F90", VA = "0x183DB5190")]
	private static PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH> MAMLCHFMOPM<TMJoin>(this HMOPEEKMPBE DBBEADIHLKO, EFJGPOMGHIA.AJAIGAEGNAM LKDMCKBGOML, PFJMKELOBBL<TMJoin> AKHHOHOJOJI) where TMJoin : EFJGPOMGHIA.MBLMIOEBNFP
	{
		return default(PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7210", Offset = "0x2AE6010", VA = "0x182AE7210")]
	public static PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH> OPKHPPHBPEN(this HMOPEEKMPBE DBBEADIHLKO)
	{
		return default(PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5850", Offset = "0x2AE4650", VA = "0x182AE5850")]
	public static PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH> DKJIJPJBKCE(this HMOPEEKMPBE DBBEADIHLKO)
	{
		return default(PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6300", Offset = "0x2AE5100", VA = "0x182AE6300")]
	public static PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH> JKGAOCNFELJ(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> LNDMPPLDBNJ)
	{
		return default(PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5570", Offset = "0x2AE4370", VA = "0x182AE5570")]
	public static PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH> BHNJJNLFHLL(this HMOPEEKMPBE DBBEADIHLKO)
	{
		return default(PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5720", Offset = "0x2AE4520", VA = "0x182AE5720")]
	public static PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH> CFKFJBHHHFG(this HMOPEEKMPBE DBBEADIHLKO)
	{
		return default(PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5770", Offset = "0x2AE4570", VA = "0x182AE5770")]
	public static KCNADLCKFJC.MBCJCLLMKKF CFMAJJMNFIO([In] this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB> DKIGBECPNLH)
	{
		return default(KCNADLCKFJC.MBCJCLLMKKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE58A0", Offset = "0x2AE46A0", VA = "0x182AE58A0")]
	public static POOMGNPCHMB<PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>, MDNDGBENGGH<KCNADLCKFJC.KPLOHEGIHDL>> EJMFGINJCMN([In] this HMOPEEKMPBE DBBEADIHLKO)
	{
		return default(POOMGNPCHMB<PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>, MDNDGBENGGH<KCNADLCKFJC.KPLOHEGIHDL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5F00", Offset = "0x2AE4D00", VA = "0x182AE5F00")]
	public static PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> IDBKDBLAEKC([In] this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB> DKIGBECPNLH)
	{
		return default(PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5BA0", Offset = "0x2AE49A0", VA = "0x182AE5BA0")]
	public static KCNADLCKFJC.IKEILOJFGPK FIALDILNKNO([In] this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> NOBJEAANMKB)
	{
		return default(KCNADLCKFJC.IKEILOJFGPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7250", Offset = "0x2AE6050", VA = "0x182AE7250")]
	public static KCNADLCKFJC.IKEILOJFGPK PCLHEEBCEGH(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> NOBJEAANMKB)
	{
		return default(KCNADLCKFJC.IKEILOJFGPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3DB3570", Offset = "0x3DB2370", VA = "0x183DB3570")]
	private static PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB> BKEFHDCCHPG<TMJoin>(this HMOPEEKMPBE DBBEADIHLKO, KCNADLCKFJC.MBCJCLLMKKF LKDMCKBGOML, PFJMKELOBBL<TMJoin> AKHHOHOJOJI) where TMJoin : KCNADLCKFJC.HMAFCHMPGMM
	{
		return default(PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2AE73B0", Offset = "0x2AE61B0", VA = "0x182AE73B0")]
	public static (PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB>, PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>) PNPOJALEBHP(this HMOPEEKMPBE DBBEADIHLKO)
	{
		return default((PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB>, PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2AE64C0", Offset = "0x2AE52C0", VA = "0x182AE64C0")]
	public static (PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB>, PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>) LAKGGOJGBMB(this HMOPEEKMPBE DBBEADIHLKO)
	{
		return default((PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB>, PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2AE72B0", Offset = "0x2AE60B0", VA = "0x182AE72B0")]
	public static PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB> PLOKPCLEGFF(this HMOPEEKMPBE DBBEADIHLKO)
	{
		return default(PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6700", Offset = "0x2AE5500", VA = "0x182AE6700")]
	public static void MEIHCEPBPKA(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL> NOBJEAANMKB, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> DPIBNHGDNHP, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>> DEBPCOFNJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4130", Offset = "0x3DB2F30", VA = "0x183DB4130")]
	public static KGJMIJHOJLG IGFGJHHKIHC<TDeps, TStateSys>(this HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<JNPLKINCBGM> MIJKDJMLDME) where TDeps : ELHKPINJBMM<TStateSys>
	{
		return default(KGJMIJHOJLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4F10", Offset = "0x3DB3D10", VA = "0x183DB4F10")]
	public static FJGLMENFJNL KCOJJFGFADN<TDeps, TStateSys>(this HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<OAPHEJLBOJB> NKENCNIEFON, int NBHDNNMNGAA) where TDeps : ELHKPINJBMM<TStateSys>
	{
		return default(FJGLMENFJNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DB3600", Offset = "0x3DB2400", VA = "0x183DB3600")]
	public static PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>? DECJLCLLAPF<TDeps, TStateSys>(this HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<OAPHEJLBOJB> NKENCNIEFON, [In] ReadOnlySpan<int> IINMLIMGKEF, [In] Span<AMMCFNKIONC> DDDOKLLMHNC) where TDeps : ELHKPINJBMM<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3DB3B90", Offset = "0x3DB2990", VA = "0x183DB3B90")]
	public static PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH> GNAKONLOGOK<TDeps, TStateSys>(this HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<ONHJNBAOPLN> NKEMHBDJJGG) where TDeps : ELHKPINJBMM<TStateSys>
	{
		return default(PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7300", Offset = "0x2AE6100", VA = "0x182AE7300")]
	public static OBDMNEHPBKE.DCOOMOGDNHA PNCMJCEBMMC([In] this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FMFDAFLDAAK)
	{
		return default(OBDMNEHPBKE.DCOOMOGDNHA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6790", Offset = "0x2AE5590", VA = "0x182AE6790")]
	public static OBDMNEHPBKE.AIJEDIDJMBA MEINJANCDMP([In] this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FMFDAFLDAAK)
	{
		return default(OBDMNEHPBKE.AIJEDIDJMBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6250", Offset = "0x2AE5050", VA = "0x182AE6250")]
	public static OBDMNEHPBKE.ILFDHMFKJKG JDFDLODKBDA([In] this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FMFDAFLDAAK)
	{
		return default(OBDMNEHPBKE.ILFDHMFKJKG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6CD0", Offset = "0x2AE5AD0", VA = "0x182AE6CD0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> NEJOPKGONOJ(this HMOPEEKMPBE DBBEADIHLKO, int? PKLGEAMCPML, string PFLDDMDPCBI)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5430", Offset = "0x2AE4230", VA = "0x182AE5430")]
	public static OBDMNEHPBKE.KBOFKLLLOGI AMEJFHENNPN([In] this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FMFDAFLDAAK)
	{
		return default(OBDMNEHPBKE.KBOFKLLLOGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE71B0", Offset = "0x2AE5FB0", VA = "0x182AE71B0")]
	public static OBDMNEHPBKE.MILFMHOOLMB OMHLHJFDOID([In] this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FMFDAFLDAAK)
	{
		return default(OBDMNEHPBKE.MILFMHOOLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6C70", Offset = "0x2AE5A70", VA = "0x182AE6C70")]
	public static int? NEDGNIPELJP([In] this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FMFDAFLDAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3DB3AB0", Offset = "0x3DB28B0", VA = "0x183DB3AB0")]
	private static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FPLMAAPAIMJ<TMJoin>(this HMOPEEKMPBE DBBEADIHLKO, int? PKLGEAMCPML, OBDMNEHPBKE.MILFMHOOLMB LKDMCKBGOML, PFJMKELOBBL<TMJoin> AKHHOHOJOJI) where TMJoin : OBDMNEHPBKE.HAKKNMICMAG
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5A70", Offset = "0x2AE4870", VA = "0x182AE5A70")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FCKKGPMIGMG(this HMOPEEKMPBE DBBEADIHLKO, int? PKLGEAMCPML, PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB> DKIGBECPNLH, int JJJJBEGKNIN)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5260", Offset = "0x2AE4060", VA = "0x182AE5260")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> ADKEJAMDOFF(this HMOPEEKMPBE DBBEADIHLKO, int? PKLGEAMCPML)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2AE58E0", Offset = "0x2AE46E0", VA = "0x182AE58E0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FAPLIMKLEJN(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>? MIHMAPKKALC, int? PKLGEAMCPML)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6670", Offset = "0x2AE5470", VA = "0x182AE6670")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> LIPAPCFNKJC(this HMOPEEKMPBE DBBEADIHLKO, int? PKLGEAMCPML, int JJJJBEGKNIN)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2AE70C0", Offset = "0x2AE5EC0", VA = "0x182AE70C0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> NPPPENMALGE(this HMOPEEKMPBE DBBEADIHLKO, int? PKLGEAMCPML)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5DD0", Offset = "0x2AE4BD0", VA = "0x182AE5DD0")]
	public static void HAJJPHDODKL(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> PHAFBFKNEGG, PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB> DKIGBECPNLH, int JJJJBEGKNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6FA0", Offset = "0x2AE5DA0", VA = "0x182AE6FA0")]
	public static void NOKCIKLAEMF(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> PHAFBFKNEGG, int JJJJBEGKNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5D10", Offset = "0x2AE4B10", VA = "0x182AE5D10")]
	public static void GNIAMIKOIDF(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> PHAFBFKNEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6F10", Offset = "0x2AE5D10", VA = "0x182AE6F10")]
	public static void NLINKHACLHA(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> BNIHAACOHPG, PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> GMMEOOJIAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE60E0", Offset = "0x2AE4EE0", VA = "0x182AE60E0")]
	public static void IOLJHFLCEOB(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> PHAFBFKNEGG, PFJMKELOBBL<NJLCIAHJLMB<HCAHHHBHBPD>> FIHDMPFFGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3DB5220", Offset = "0x3DB4020", VA = "0x183DB5220")]
	public static void OAEFPMFAFBK<M>(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> PHAFBFKNEGG, PFJMKELOBBL<NJLCIAHJLMB<CGDJGEPODDI<M>>> FIHDMPFFGIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface ELHKPINJBMM<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PFJMKELOBBL<OCONFHNBCBE> ONNAPDNNAKM(TStateSys HHMIDCOGHHK);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PFJMKELOBBL<OCONFHNBCBE> IBMCGDIMAHE(TStateSys HHMIDCOGHHK);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PFJMKELOBBL<OCONFHNBCBE> LFJHNJJCIHB(TStateSys HHMIDCOGHHK);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PFJMKELOBBL<OCONFHNBCBE> DHPKJGMAHHD(TStateSys HHMIDCOGHHK);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH> DIIJDKEMPEH(TStateSys HHMIDCOGHHK, HMOPEEKMPBE IIPMCOPEFHG, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<JNPLKINCBGM> MIJKDJMLDME);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> DJCLPDCHKCM(TStateSys HHMIDCOGHHK, HMOPEEKMPBE IIPMCOPEFHG, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<ONHJNBAOPLN> NKEMHBDJJGG);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int CPHGJKGKCJC(TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<JNPLKINCBGM> MIJKDJMLDME);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PFJMKELOBBL<ONHJNBAOPLN> CFLBOLJPFBB(TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<JNPLKINCBGM> MIJKDJMLDME, int FCFIABAOOGF);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OBKHCBMBPEF AKFLCOGHNFD(TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<JNPLKINCBGM> MIJKDJMLDME);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KPELHPBODCO(TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<JNPLKINCBGM> MIJKDJMLDME);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int NFMILFBGKJP(TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<JNPLKINCBGM> MIJKDJMLDME);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GJPAHHJEFHG<byte> MAKCOGGFJFD(TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<JNPLKINCBGM> MIJKDJMLDME);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(GJPAHHJEFHG<byte>, PFJMKELOBBL<OCONFHNBCBE>) HKEJMCKNDMP(TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<JNPLKINCBGM> MIJKDJMLDME);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int MECLIELNBJK(TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<ONHJNBAOPLN> NKEMHBDJJGG);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PFJMKELOBBL<JNPLKINCBGM> EDEKIHMDGCK(TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<ONHJNBAOPLN> NKEMHBDJJGG, int NBHDNNMNGAA);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PFJMKELOBBL<JNPLKINCBGM> ADAJMMGMHNJ(TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<OAPHEJLBOJB> NKENCNIEFON, int NBHDNNMNGAA);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int HEDLNGHHCPE(TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? MGHLLMNFFPN(TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, int JJJJBEGKNIN);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int FMBDJLOOFBE(TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? EGDFCBKEAMB(TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, int JJJJBEGKNIN);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GLABKJPBDAM
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3CFBE70", Offset = "0x3CFAC70", VA = "0x183CFBE70")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL?> BJOJAEAGMIM<T, TOpInput, TOpOutput>(this HMOPEEKMPBE DBBEADIHLKO, T CHAEOFDBIAH, T EBEGEKLHGJL, int JKLHMDOFFAJ, IntPtr LADFHENPJPN)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3CFBB90", Offset = "0x3CFA990", VA = "0x183CFBB90")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL?> AEGFMEMBPDL<T, TOpInput, TOpOutput>(this HMOPEEKMPBE DBBEADIHLKO, T CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL, int JKLHMDOFFAJ, IntPtr LADFHENPJPN)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3CFD810", Offset = "0x3CFC610", VA = "0x183CFD810")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL?> IDKNDBMEIDO<TOpInput, TOpOutput>(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL, int JKLHMDOFFAJ, IntPtr LADFHENPJPN)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3570", Offset = "0x2AE2370", VA = "0x182AE3570")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> OGJJPNALALO(this HMOPEEKMPBE DBBEADIHLKO, float FDBNKNKPGEM, float FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0E10", Offset = "0x2ADFC10", VA = "0x182AE0E10")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FICGFONNJFD(this HMOPEEKMPBE DBBEADIHLKO, float FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1A60", Offset = "0x2AE0860", VA = "0x182AE1A60")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> JNCMDHKNNJN(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2ADFD70", Offset = "0x2ADEB70", VA = "0x182ADFD70")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> DOIGEBGKCCF(this HMOPEEKMPBE DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0350", Offset = "0x2ADF150", VA = "0x182AE0350")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> ECMCNJGPAGG(this HMOPEEKMPBE DBBEADIHLKO, int FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3C00", Offset = "0x2AE2A00", VA = "0x182AE3C00")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> POMHHDIDPKM(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2ADFC70", Offset = "0x2ADEA70", VA = "0x182ADFC70")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> DLAJFILFPAJ(this HMOPEEKMPBE DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2090", Offset = "0x2AE0E90", VA = "0x182AE2090")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> KOPNENCLPBB(this HMOPEEKMPBE DBBEADIHLKO, int FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF420", Offset = "0x2ADE220", VA = "0x182ADF420")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> CKPOPNLKCHB(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2AE12D0", Offset = "0x2AE00D0", VA = "0x182AE12D0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> GPJGNBEDMHK(this HMOPEEKMPBE DBBEADIHLKO, int CHAEOFDBIAH, int EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1DE0", Offset = "0x2AE0BE0", VA = "0x182AE1DE0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> KEBGKNHAGKF(this HMOPEEKMPBE DBBEADIHLKO, int CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2ADFFB0", Offset = "0x2ADEDB0", VA = "0x182ADFFB0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> ECEGIMCABPL(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1830", Offset = "0x2AE0630", VA = "0x182AE1830")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> JFOLDGDACOE(this HMOPEEKMPBE DBBEADIHLKO, float CHAEOFDBIAH, float EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3950", Offset = "0x2AE2750", VA = "0x182AE3950")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> PIACINOEFHO(this HMOPEEKMPBE DBBEADIHLKO, float CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF2E0", Offset = "0x2ADE0E0", VA = "0x182ADF2E0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> CBLECPJMLJN(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF560", Offset = "0x2ADE360", VA = "0x182ADF560")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> CLLPMFEBKDN(this HMOPEEKMPBE DBBEADIHLKO, int CHAEOFDBIAH, int EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2AE31D0", Offset = "0x2AE1FD0", VA = "0x182AE31D0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> OALJJHMCDEP(this HMOPEEKMPBE DBBEADIHLKO, int CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2AE25F0", Offset = "0x2AE13F0", VA = "0x182AE25F0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> LLENKCNDEIK(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2AE38D0", Offset = "0x2AE26D0", VA = "0x182AE38D0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> PHEOAPHLNLP(this HMOPEEKMPBE DBBEADIHLKO, float CHAEOFDBIAH, float EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1250", Offset = "0x2AE0050", VA = "0x182AE1250")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> GOLELHDFCIG(this HMOPEEKMPBE DBBEADIHLKO, float CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF260", Offset = "0x2ADE060", VA = "0x182ADF260")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> BLOMGPNEMFL(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0920", Offset = "0x2ADF720", VA = "0x182AE0920")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FHFDCLHDJKE(this HMOPEEKMPBE DBBEADIHLKO, int CHAEOFDBIAH, int EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2AE10B0", Offset = "0x2ADFEB0", VA = "0x182AE10B0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> GADNJDJKIED(this HMOPEEKMPBE DBBEADIHLKO, int CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3B80", Offset = "0x2AE2980", VA = "0x182AE3B80")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> PMLCFLIKFEA(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF1E0", Offset = "0x2ADDFE0", VA = "0x182ADF1E0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> BLCOJOBOPNP(this HMOPEEKMPBE DBBEADIHLKO, float CHAEOFDBIAH, float EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1BA0", Offset = "0x2AE09A0", VA = "0x182AE1BA0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> JOJBMDMJPAI(this HMOPEEKMPBE DBBEADIHLKO, float CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2AE33F0", Offset = "0x2AE21F0", VA = "0x182AE33F0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> OFECFBGANKH(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2AE22D0", Offset = "0x2AE10D0", VA = "0x182AE22D0")]
	public static PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> LCPDMLPIDEP(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> GPIDDMLNFEO)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEBE0", Offset = "0x2ADD9E0", VA = "0x182ADEBE0")]
	public static PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> AIHDLGCCCLH(this HMOPEEKMPBE DBBEADIHLKO, int HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3350", Offset = "0x2AE2150", VA = "0x182AE3350")]
	public static PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> OEPJHBNNIPM(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1650", Offset = "0x2AE0450", VA = "0x182AE1650")]
	public static PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> JDCGEDNOCEE(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> GPIDDMLNFEO)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1030", Offset = "0x2ADFE30", VA = "0x182AE1030")]
	public static PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> FOOHGKAKOEG(this HMOPEEKMPBE DBBEADIHLKO, int HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1FF0", Offset = "0x2AE0DF0", VA = "0x182AE1FF0")]
	public static PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> KIGBDHFJIEN(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2AE09A0", Offset = "0x2ADF7A0", VA = "0x182AE09A0")]
	public static (PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB>, PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>) FHLNEHBMODA(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<FHAMANOFCLM> GKLFFONJGDI, [In] ReadOnlySpan<PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>> BNOPOAPPFBM, [In] ReadOnlySpan<int?> DFMAJIHIIBL, [In] Span<PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>> MIGEALCHJDB)
	{
		return default((PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB>, PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF5E0", Offset = "0x2ADE3E0", VA = "0x182ADF5E0")]
	public static (PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB>, PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>) CNBGMIDPNBG(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<HIJLELAFBEP> KMBFOCACCEN, [In] ReadOnlySpan<PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>> BNOPOAPPFBM, [In] ReadOnlySpan<int?> DFMAJIHIIBL, [In] Span<PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>> MIGEALCHJDB)
	{
		return default((PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB>, PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3CFCE50", Offset = "0x3CFBC50", VA = "0x183CFCE50")]
	public static (PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<OCONFHNBCBE>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<TMarker>>, PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB>) FDICOCJBPOI<TMarker>(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OCONFHNBCBE> LFCAGEJMHBB, [In] ReadOnlySpan<byte> KANAIIDGHCH)
	{
		return default((PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<NJLCIAHJLMB<OCONFHNBCBE>>, PFJMKELOBBL<NJLCIAHJLMB<KHMMNKGODGP>>, PFJMKELOBBL<NJLCIAHJLMB<TMarker>>, PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1D20", Offset = "0x2AE0B20", VA = "0x182AE1D20")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> KBGPBNAJJAM(this HMOPEEKMPBE DBBEADIHLKO, int ODAFCJJIICF, [Optional] PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>? AMOBAKBDGHA)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1F00", Offset = "0x2AE0D00", VA = "0x182AE1F00")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> KFNBFMKOEOM(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> ODAFCJJIICF, [Optional] PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>? AMOBAKBDGHA)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2AE30E0", Offset = "0x2AE1EE0", VA = "0x182AE30E0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> NOJGEOBJLMM(this HMOPEEKMPBE DBBEADIHLKO, [In] ReadOnlySpan<byte> ODAFCJJIICF, [Optional] PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>? AMOBAKBDGHA)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2AE21B0", Offset = "0x2AE0FB0", VA = "0x182AE21B0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> LADNKGPKJIC(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> ODAFCJJIICF, int BCMFMCHGEKF, [Optional] PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>? AMOBAKBDGHA)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1C20", Offset = "0x2AE0A20", VA = "0x182AE1C20")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> KAHFPCPEMJP(this HMOPEEKMPBE DBBEADIHLKO, float FDBNKNKPGEM, float FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2CD0", Offset = "0x2AE1AD0", VA = "0x182AE2CD0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> NGDAANCKNKF(this HMOPEEKMPBE DBBEADIHLKO, float FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2AE24B0", Offset = "0x2AE12B0", VA = "0x182AE24B0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> LHDJJDGDHOL(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2ADFA50", Offset = "0x2ADE850", VA = "0x182ADFA50")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> CODGIFKMEGB(this HMOPEEKMPBE DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2FC0", Offset = "0x2AE1DC0", VA = "0x182AE2FC0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> NMADPNLBHIA(this HMOPEEKMPBE DBBEADIHLKO, int FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2ADFE70", Offset = "0x2ADEC70", VA = "0x182ADFE70")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> DOJAMNFJMDL(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2AE14D0", Offset = "0x2AE02D0", VA = "0x182AE14D0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> INKMAGCMFLE(this HMOPEEKMPBE DBBEADIHLKO, int CHAEOFDBIAH, int EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2F40", Offset = "0x2AE1D40", VA = "0x182AE2F40")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> NKBCLOCAMAP(this HMOPEEKMPBE DBBEADIHLKO, int CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2770", Offset = "0x2AE1570", VA = "0x182AE2770")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> MEPMPLJFJKO(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> CHAEOFDBIAH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EBEGEKLHGJL)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3470", Offset = "0x2AE2270", VA = "0x182AE3470")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> OGEBABPOLFC(this HMOPEEKMPBE DBBEADIHLKO, float FDBNKNKPGEM, float FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1930", Offset = "0x2AE0730", VA = "0x182AE1930")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> JIIJHIKJLPK(this HMOPEEKMPBE DBBEADIHLKO, float FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE980", Offset = "0x2ADD780", VA = "0x182ADE980")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> ACKDDLIMDHA(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEAE0", Offset = "0x2ADD8E0", VA = "0x182ADEAE0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> ADPCCJJICLD(this HMOPEEKMPBE DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2AE05B0", Offset = "0x2ADF3B0", VA = "0x182AE05B0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBDCDGJNKOO(this HMOPEEKMPBE DBBEADIHLKO, int FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEC60", Offset = "0x2ADDA60", VA = "0x182ADEC60")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> AJNLLKJALIL(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEAC0", Offset = "0x2ADD8C0", VA = "0x182ADEAC0")]
	public static PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>> ADFNEGJCDEB(this HMOPEEKMPBE DBBEADIHLKO)
	{
		return default(PFJMKELOBBL<NJLCIAHJLMB<NJLCIAHJLMB<BCFGFIPPBHM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0F30", Offset = "0x2ADFD30", VA = "0x182AE0F30")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FNONADAILLL(this HMOPEEKMPBE DBBEADIHLKO, float FDBNKNKPGEM, float FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2ADFB50", Offset = "0x2ADE950", VA = "0x182ADFB50")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> DGBFLMFEHCP(this HMOPEEKMPBE DBBEADIHLKO, float FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2E00", Offset = "0x2AE1C00", VA = "0x182AE2E00")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> NIOAJGPDJEN(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2AE13D0", Offset = "0x2AE01D0", VA = "0x182AE13D0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> ICBOBHBGFFI(this HMOPEEKMPBE DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1130", Offset = "0x2ADFF30", VA = "0x182AE1130")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> GFICOIPHGOC(this HMOPEEKMPBE DBBEADIHLKO, int FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEDA0", Offset = "0x2ADDBA0", VA = "0x182ADEDA0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> BAHGBBNJPCE(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3250", Offset = "0x2AE2050", VA = "0x182AE3250")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> ODKAJIAJCJK(this HMOPEEKMPBE DBBEADIHLKO, int HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2AE06D0", Offset = "0x2ADF4D0", VA = "0x182AE06D0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FDLMFAJIDOC(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2DF0", Offset = "0x2AE1BF0", VA = "0x182AE2DF0")]
	public static void NHKMIPFFCOL(this HMOPEEKMPBE DBBEADIHLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2670", Offset = "0x2AE1470", VA = "0x182AE2670")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> LPPEPOOOFPN(this HMOPEEKMPBE DBBEADIHLKO, float FDBNKNKPGEM, float FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0230", Offset = "0x2ADF030", VA = "0x182AE0230")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> ECLKOFGDPCB(this HMOPEEKMPBE DBBEADIHLKO, float FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2AE07E0", Offset = "0x2ADF5E0", VA = "0x182AE07E0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FHAJFAFFOGM(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3A80", Offset = "0x2AE2880", VA = "0x182AE3A80")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> PKKGDHDDBGH(this HMOPEEKMPBE DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2AE37B0", Offset = "0x2AE25B0", VA = "0x182AE37B0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> PBJHBIMJHAD(this HMOPEEKMPBE DBBEADIHLKO, int FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0470", Offset = "0x2ADF270", VA = "0x182AE0470")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> EELMNCHPPAO(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2910", Offset = "0x2AE1710", VA = "0x182AE2910")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> NAOFJEONNEM(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> JNJHPEMIEOE, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> GKHHDGCAHGJ)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1550", Offset = "0x2AE0350", VA = "0x182AE1550")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> IPCPDNHBEHK(this HMOPEEKMPBE DBBEADIHLKO, int FDBNKNKPGEM, int FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2AE27F0", Offset = "0x2AE15F0", VA = "0x182AE27F0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> MOLFGKFCBMB(this HMOPEEKMPBE DBBEADIHLKO, int FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2AE00F0", Offset = "0x2ADEEF0", VA = "0x182AE00F0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> ECJODEDKCCP(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FDBNKNKPGEM, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FBKHPANKMDO)
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE2C0", Offset = "0x3CFD0C0", VA = "0x183CFE2C0")]
	public static void MBCCLEEEBBL<TDeps, TState>(this HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TState GKGDEKNIOCH, PFJMKELOBBL<FHAMANOFCLM> GKLFFONJGDI, [In] ReadOnlySpan<PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>> OJADDNLADPA, [In] ReadOnlySpan<int?> DFMAJIHIIBL, [In] Span<PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>> MIGEALCHJDB, [In] Span<PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>> EKFAENLEKPP, [In] ReadOnlySpan<PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>?> CHOAKKBNOJD) where TDeps : notnull, ELHKPINJBMM<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3CFCF40", Offset = "0x3CFBD40", VA = "0x183CFCF40")]
	public static void FEIGGNEFANN<TDeps, TState>(this HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TState GKGDEKNIOCH, PFJMKELOBBL<HIJLELAFBEP> OHHICGADAKK, [In] ReadOnlySpan<PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>> GIIALAPJCLM, [In] ReadOnlySpan<int?> DFMAJIHIIBL, [In] Span<PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>> MIGEALCHJDB, [In] Span<PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>> EKFAENLEKPP, [In] ReadOnlySpan<PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>?> CHOAKKBNOJD) where TDeps : notnull, ELHKPINJBMM<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3CFD930", Offset = "0x3CFC730", VA = "0x183CFD930")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> IGJAKCCAHAK<TDeps, TState>(this HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TState GKGDEKNIOCH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> MIHMAPKKALC, [Optional] PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>? AMOBAKBDGHA) where TDeps : notnull, ELHKPINJBMM<TState> where TState : notnull
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE7D0", Offset = "0x3CFD5D0", VA = "0x183CFE7D0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> PDNIFJKDHMH<TDeps, TState>(this HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TState GKGDEKNIOCH, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> LNDMPPLDBNJ, [Optional] PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>? AMOBAKBDGHA) where TDeps : notnull, ELHKPINJBMM<TState> where TState : notnull
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3CFCAE0", Offset = "0x3CFB8E0", VA = "0x183CFCAE0")]
	public static PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> DPFEKCNIKNG<TDeps, TStateSys>(this HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TStateSys HHMIDCOGHHK) where TDeps : notnull, ELHKPINJBMM<TStateSys> where TStateSys : notnull
	{
		return default(PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3CFDF70", Offset = "0x3CFCD70", VA = "0x183CFDF70")]
	public static PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH> LEPGOGGNIIE<TDeps, TStateSys>(this HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TStateSys HHMIDCOGHHK) where TDeps : notnull, ELHKPINJBMM<TStateSys> where TStateSys : notnull
	{
		return default(PFJMKELOBBL<EFJGPOMGHIA.BIHJKPIFONH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3670", Offset = "0x2AE2470", VA = "0x182AE3670")]
	public static PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> OHNOCOGBAPK(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> ABJMPEHHMHN, IntPtr OCFKHHCGKFO, IntPtr HDOJFMAAELJ)
	{
		return default(PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEEE0", Offset = "0x2ADDCE0", VA = "0x182ADEEE0")]
	public static PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> BILJFKCFAAM(this HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> LBOEHMNNNNI, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> LNCHICFDMPH, IntPtr MEHHKGBPOBH, IntPtr EIFNCBGCKGI, IntPtr IPGOEOLEEFC, bool ALEFDKBCFOJ)
	{
		return default(PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC430", Offset = "0x3CFB230", VA = "0x183CFC430")]
	public static PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> CPDNGPGJHEO<TDeps, TState>(this HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TState GKGDEKNIOCH, PFJMKELOBBL<FHAMANOFCLM> BAAFGFGFLEB, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> LBOEHMNNNNI, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> LNCHICFDMPH, int? ECOIPMJMGJK, [Optional] IntPtr HEIFCMDDMPL) where TDeps : notnull, ELHKPINJBMM<TState> where TState : notnull
	{
		return default(PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC120", Offset = "0x3CFAF20", VA = "0x183CFC120")]
	private static PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> CPDNGPGJHEO<TDeps, TState>(this HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TState GKGDEKNIOCH, PFJMKELOBBL<FHAMANOFCLM> BAAFGFGFLEB, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> LBOEHMNNNNI, PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN> LNCHICFDMPH, int? ECOIPMJMGJK) where TDeps : notnull, ELHKPINJBMM<TState> where TState : notnull
	{
		return default(PFJMKELOBBL<ALBLCFELFHL.GPFIOGMCCAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3CFDAF0", Offset = "0x3CFC8F0", VA = "0x183CFDAF0")]
	public static PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> JDHACEMHGLN<TDeps, TState>(this HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TState GKGDEKNIOCH, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> ODAFCJJIICF, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>? AMOBAKBDGHA) where TDeps : notnull, ELHKPINJBMM<TState> where TState : notnull
	{
		return default(PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3CFD450", Offset = "0x3CFC250", VA = "0x183CFD450")]
	public static void GIPEEGOMHII<TDeps, TState>(this HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TState GKGDEKNIOCH, int FHCAJEEAJCE) where TDeps : notnull, ELHKPINJBMM<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct LFLJAMOEPPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> JDLLHPKKACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> NCELCOCFCBG;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xEABD50", Offset = "0xEAAB50", VA = "0x180EABD50")]
	public LFLJAMOEPPL(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> AKDPDBPEHIL, PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> NEOMIICDAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7AD0", Offset = "0x2AE68D0", VA = "0x182AE7AD0")]
	public static LFLJAMOEPPL ELDPFIHNJDG(PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>> AKDPDBPEHIL)
	{
		return default(LFLJAMOEPPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct OBDMNEHPBKE
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class DANAKFOAKGB : HAKKNMICMAG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct DCOOMOGDNHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB> HJAGHGKMMNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int NELPMDCEMJE;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xEABD50", Offset = "0xEAAB50", VA = "0x180EABD50")]
		public DCOOMOGDNHA(PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB> DKIGBECPNLH, int JJJJBEGKNIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class GABHOICNHBK : HAKKNMICMAG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct AIJEDIDJMBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int NELPMDCEMJE;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0")]
		public AIJEDIDJMBA(int JJJJBEGKNIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class IEBACFAGBPF : HAKKNMICMAG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct ILFDHMFKJKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB> HJAGHGKMMNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int NELPMDCEMJE;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xEABD50", Offset = "0xEAAB50", VA = "0x180EABD50")]
		public ILFDHMFKJKG(PFJMKELOBBL<KCNADLCKFJC.BHGEFLOOADB> DKIGBECPNLH, int JJJJBEGKNIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum MILFMHOOLMB
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Temporary,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Named,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Argument,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		CallerReturnValue,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Parameter,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		CalleeReturnValue
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class BCCLHGNAACL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class HAKKNMICMAG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct CDFDEMPBDKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? JFDICLLCMPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public LFLJAMOEPPL NHLFODGBMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public MILFMHOOLMB GADMADJMFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public PFJMKELOBBL<HAKKNMICMAG> MEFKPCGJDKB;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE170", Offset = "0x2ADCF70", VA = "0x182ADE170")]
		public CDFDEMPBDKN(int? PKLGEAMCPML, [In] LFLJAMOEPPL GNPGJKEGINN, MILFMHOOLMB LKDMCKBGOML, PFJMKELOBBL<HAKKNMICMAG> AKHHOHOJOJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class HHGLHCECHLB : HAKKNMICMAG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct KBOFKLLLOGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int NELPMDCEMJE;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0")]
		public KBOFKLLLOGI(int JJJJBEGKNIN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal OKGGBOJNOJE<BCCLHGNAACL, CDFDEMPBDKN> MOECNAEPNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal OKGGBOJNOJE<DANAKFOAKGB, DCOOMOGDNHA> LPGNJBONOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal OKGGBOJNOJE<IEBACFAGBPF, ILFDHMFKJKG> OIKGLHLMKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal OKGGBOJNOJE<HHGLHCECHLB, KBOFKLLLOGI> HHNOJIJDGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal OKGGBOJNOJE<GABHOICNHBK, AIJEDIDJMBA> HPOKPHKAMGJ;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8E20", Offset = "0x2AE7C20", VA = "0x182AE8E20")]
	private OBDMNEHPBKE([In] OKGGBOJNOJE<BCCLHGNAACL, CDFDEMPBDKN> FJCEIGNGHBI, [In] OKGGBOJNOJE<DANAKFOAKGB, DCOOMOGDNHA> GNANKAAKMAK, [In] OKGGBOJNOJE<IEBACFAGBPF, ILFDHMFKJKG> GGOFMOFFOPC, [In] OKGGBOJNOJE<HHGLHCECHLB, KBOFKLLLOGI> CJNICEBPMOP, [In] OKGGBOJNOJE<GABHOICNHBK, AIJEDIDJMBA> DPKMBPLMBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8C30", Offset = "0x2AE7A30", VA = "0x182AE8C30")]
	public static OBDMNEHPBKE ELDPFIHNJDG()
	{
		return default(OBDMNEHPBKE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class CKLCAFOGLBG
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE190", Offset = "0x2ADCF90", VA = "0x182ADE190")]
	public static void MFDBANBONAB(this OBDMNEHPBKE DBBEADIHLKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class JHNAKOKHHBF
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4E90", Offset = "0x2AE3C90", VA = "0x182AE4E90")]
	public static void PLBGJCCDHGP(HMOPEEKMPBE DBBEADIHLKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct LAJNPNMMOMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, HJFMAKHAHJE> MCBMOLNFLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int FJFLHOMIPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int KGHFICFOCPF;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2AE79F0", Offset = "0x2AE67F0", VA = "0x182AE79F0")]
	private LAJNPNMMOMC([In] DMCDLOLKCAK<KCNADLCKFJC.KPLOHEGIHDL, HJFMAKHAHJE> OHAPDJLACBN, int KDDJDAKLPAC, int ANFKCAEPNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE77B0", Offset = "0x2AE65B0", VA = "0x182AE77B0")]
	public static LAJNPNMMOMC ELDPFIHNJDG()
	{
		return default(LAJNPNMMOMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7820", Offset = "0x2AE6620", VA = "0x182AE7820")]
	public void MFDBANBONAB([In] HMOPEEKMPBE HLKBHABLPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3DBB400", Offset = "0x3DBA200", VA = "0x183DBB400")]
	public static void PLBGJCCDHGP<TDeps, TStateSys>(HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TStateSys HHMIDCOGHHK, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP) where TDeps : notnull, ELHKPINJBMM<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class ABJGOGHHIKF
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD920", Offset = "0x2ADC720", VA = "0x182ADD920")]
	public static void PLBGJCCDHGP(HMOPEEKMPBE DBBEADIHLKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct MBOPIPCFNGB
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface LPCIEMNEKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FBONGLEJOBG(MHNDIBEMFIN<byte> HNOIHKILNDG, int HKDCNPAMGKJ);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct LDBGJEGGALM : LPCIEMNEKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7A50", Offset = "0x2AE6850", VA = "0x182AE7A50", Slot = "4")]
		public void FBONGLEJOBG(MHNDIBEMFIN<byte> HNOIHKILNDG, int HKDCNPAMGKJ)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct EHDCFMIDNIP : LPCIEMNEKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE430", Offset = "0x2ADD230", VA = "0x182ADE430", Slot = "4")]
		public void FBONGLEJOBG(MHNDIBEMFIN<byte> HNOIHKILNDG, int HKDCNPAMGKJ)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct EFICBFGLANJ : LPCIEMNEKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE2E0", Offset = "0x2ADD0E0", VA = "0x182ADE2E0", Slot = "4")]
		public void FBONGLEJOBG(MHNDIBEMFIN<byte> HNOIHKILNDG, int HKDCNPAMGKJ)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct GOPEDFBDJJG : LPCIEMNEKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3D40", Offset = "0x2AE2B40", VA = "0x182AE3D40", Slot = "4")]
		public void FBONGLEJOBG(MHNDIBEMFIN<byte> HNOIHKILNDG, int HKDCNPAMGKJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class MMEEOEEIMMH<TCallProcessorDeps> where TCallProcessorDeps : struct, LPCIEMNEKLK
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps BFCDJMDIFNA;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4499CF0", Offset = "0x4498AF0", VA = "0x184499CF0")]
		public static int PLBGJCCDHGP<TDeps, TStateSys>(TDeps OPJFEEDOIEH, TStateSys GKGDEKNIOCH, HMOPEEKMPBE HLKBHABLPJJ, [In] MHNDIBEMFIN<byte> NMHDPOJBJFC, int HPPOJIEMODI) where TDeps : ELHKPINJBMM<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private MHNDIBEMFIN<LKALJGIPFPG> AINAMGABGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>> HDHMBDFKLPB;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE87B0", Offset = "0x2AE75B0", VA = "0x182AE87B0")]
	private MBOPIPCFNGB([In] MHNDIBEMFIN<LKALJGIPFPG> ILIHHOHAEOK, Dictionary<PFJMKELOBBL<NJLCIAHJLMB<BCFGFIPPBHM>>, PFJMKELOBBL<KCNADLCKFJC.KPLOHEGIHDL>> OKPBCJCCCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE86B0", Offset = "0x2AE74B0", VA = "0x182AE86B0")]
	public static MBOPIPCFNGB ELDPFIHNJDG()
	{
		return default(MBOPIPCFNGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8770", Offset = "0x2AE7570", VA = "0x182AE8770")]
	public void MFDBANBONAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6700", Offset = "0x3DF5500", VA = "0x183DF6700")]
	public static void PLBGJCCDHGP<TDeps, TStateSys>(HMOPEEKMPBE DBBEADIHLKO, TDeps OPJFEEDOIEH, TStateSys HHMIDCOGHHK) where TDeps : ELHKPINJBMM<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class LGHENCOCPPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct NOEOGHJHLBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> GBAABGJCBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int LONANHCNCPG;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int HFPFEAIIHPO;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int HLFBBGOJAPA;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7F70", Offset = "0x2AE6D70", VA = "0x182AE7F70")]
	public static void PLBGJCCDHGP(HMOPEEKMPBE DBBEADIHLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7C10", Offset = "0x2AE6A10", VA = "0x182AE7C10")]
	private static void PAJKFMPIDGA([In] HMOPEEKMPBE DBBEADIHLKO, PFJMKELOBBL<OBDMNEHPBKE.BCCLHGNAACL> FMFDAFLDAAK, MHNDIBEMFIN<byte> LCDPDFNOGAH, List<NOEOGHJHLBM> BLLLJHENOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7E30", Offset = "0x2AE6C30", VA = "0x182AE7E30")]
	private static void PAJKFMPIDGA(MHNDIBEMFIN<byte> LCDPDFNOGAH, int BCMFMCHGEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7AE0", Offset = "0x2AE68E0", VA = "0x182AE7AE0")]
	private static void BPNMOKGAHGL(HMOPEEKMPBE DBBEADIHLKO, List<NOEOGHJHLBM> BLLLJHENOIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class LCOJKOAIOFJ<TDeps, TIndex, TValues> where TDeps : struct, PHJMANJJEGP<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps BFCDJMDIFNA;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x567B230", Offset = "0x567A030", VA = "0x18567B230")]
	public static void PLBGJCCDHGP([In] MHNDIBEMFIN<LKALJGIPFPG> ILIHHOHAEOK, int FCPPFPJENLA, TValues OOFDDMCKJPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface PHJMANJJEGP<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MHNDIBEMFIN<TIndex> BNOEGLDMEFG(int FCPPFPJENLA, [In] TValues OOFDDMCKJPA);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> BDGPBPOMKHO(TIndex JJJJBEGKNIN, [In] TValues OOFDDMCKJPA);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KNLNMHDHCKG(TIndex JJJJBEGKNIN, TValues OOFDDMCKJPA, PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> HGMAIPELJHM);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface NJNNCEPDGMG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex HIIMEPIEFJN(int JJJJBEGKNIN);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ODANLAELGLD(TIndex JJJJBEGKNIN, [In] TValues OOFDDMCKJPA);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PFJMKELOBBL<NJLCIAHJLMB<BFKJLNKNPDF>> BDGPBPOMKHO(TIndex JJJJBEGKNIN, [In] TValues OOFDDMCKJPA);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class BAPMBHFKANJ<TDeps, TIndex, TValues> where TDeps : struct, NJNNCEPDGMG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps BFCDJMDIFNA;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x65FBA80", Offset = "0x65FA880", VA = "0x1865FBA80")]
	public static MHNDIBEMFIN<TIndex> PLBGJCCDHGP(int FCPPFPJENLA, [In] TValues OOFDDMCKJPA)
	{
		return default(MHNDIBEMFIN<TIndex>);
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
