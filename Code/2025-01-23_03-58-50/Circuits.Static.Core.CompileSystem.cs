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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2337990", Offset = "0x2336190", VA = "0x182337990")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct ILNIJBJKIOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> EGBOPDMMFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int AEOBBNBHJFH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x95D280", Offset = "0x95BA80", VA = "0x18095D280")]
	public ILNIJBJKIOJ(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> AELPFAFKICJ, int MHPJBPKHONI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct APCPAIOKILN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class LCEEKPDNAEH : GNDDHFDOAAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct BIPAFHEKKOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly KMIPOEIGPEN<byte> KLIGPFMOHMN;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x22E30B0", Offset = "0x22E18B0", VA = "0x1822E30B0")]
		public BIPAFHEKKOH(KMIPOEIGPEN<byte> LMGNHIJGDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x232D270", Offset = "0x232BA70", VA = "0x18232D270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class BFGDOOFDOGB : GNDDHFDOAAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct ADJFDDNKHIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> BALJEKHNOEC;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690")]
		public ADJFDDNKHIN(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> PMIICILOMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum BAFKDGKFAHO
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
	public sealed class EBBBJHHGFDB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class GNDDHFDOAAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct MNHBFKOMAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly BAFKDGKFAHO COJDFBLAMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly MFKBDIPIOIA<GNDDHFDOAAP> BIIKDDJEJAG;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x95D280", Offset = "0x95BA80", VA = "0x18095D280")]
		public MNHBFKOMAKE(BAFKDGKFAHO NBKJLJKCNBN, MFKBDIPIOIA<GNDDHFDOAAP> BJMJJANHLNF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class MODFGAMEIPO : GNDDHFDOAAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct NNCLBGMNNLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> OLGFLFIBPCB;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690")]
		public NNCLBGMNNLK(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> FKOIODJLAKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class KJJFMMIMCGF : GNDDHFDOAAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct NALODNOCMKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly CGDEJEKEJDL GCMHEDIALLI;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690")]
		public NALODNOCMKA(CGDEJEKEJDL OKHCCKJKKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2337500", Offset = "0x2335D00", VA = "0x182337500", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal FEGNOBMAFGE<EBBBJHHGFDB, MNHBFKOMAKE> AENLLDLLBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal FEGNOBMAFGE<LCEEKPDNAEH, BIPAFHEKKOH> LKCJPFOFGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal FEGNOBMAFGE<BFGDOOFDOGB, ADJFDDNKHIN> HBPEGIPHEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal FEGNOBMAFGE<MODFGAMEIPO, NNCLBGMNNLK> ONGGGNGFENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal FEGNOBMAFGE<KJJFMMIMCGF, NALODNOCMKA> ONNICILJKDE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x232D1E0", Offset = "0x232B9E0", VA = "0x18232D1E0")]
	private APCPAIOKILN([In] FEGNOBMAFGE<EBBBJHHGFDB, MNHBFKOMAKE> FLJKOENEEKD, [In] FEGNOBMAFGE<LCEEKPDNAEH, BIPAFHEKKOH> LGFANFAHGIL, [In] FEGNOBMAFGE<BFGDOOFDOGB, ADJFDDNKHIN> JBEGCBDDEAC, [In] FEGNOBMAFGE<MODFGAMEIPO, NNCLBGMNNLK> GCLHMJDMGEC, [In] FEGNOBMAFGE<KJJFMMIMCGF, NALODNOCMKA> JINDLBKLCKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x232D0A0", Offset = "0x232B8A0", VA = "0x18232D0A0")]
	public static APCPAIOKILN DFLBOLBHLFN()
	{
		return default(APCPAIOKILN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OJKCJIPKPLA
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2337D10", Offset = "0x2336510", VA = "0x182337D10")]
	public static void ANFLKJPBFFP(this APCPAIOKILN EGGDEECAALI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum OLOHINCMFBM
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
public struct OGIPGLMKBDK
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class CMMDPCAAMML : AIDKCNCEMCM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct NGLGBPMBIEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> MBKFOOHFMGO;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690")]
		public NGLGBPMBIEM(MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> OIOBLMOILDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum BNILKCELPIA
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
	public sealed class OHIKFGDMIEJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class AIDKCNCEMCM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct HFOJGBAOKLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly BNILKCELPIA COJDFBLAMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly MFKBDIPIOIA<AIDKCNCEMCM> BIIKDDJEJAG;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x95D280", Offset = "0x95BA80", VA = "0x18095D280")]
		public HFOJGBAOKLL(BNILKCELPIA NBKJLJKCNBN, MFKBDIPIOIA<AIDKCNCEMCM> BJMJJANHLNF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal FEGNOBMAFGE<OHIKFGDMIEJ, HFOJGBAOKLL> AENLLDLLBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal FEGNOBMAFGE<CMMDPCAAMML, NGLGBPMBIEM> PGJKJOGLFAJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x232F9E0", Offset = "0x232E1E0", VA = "0x18232F9E0")]
	private OGIPGLMKBDK([In] FEGNOBMAFGE<OHIKFGDMIEJ, HFOJGBAOKLL> FLJKOENEEKD, [In] FEGNOBMAFGE<CMMDPCAAMML, NGLGBPMBIEM> HLCPPDHBLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2337C80", Offset = "0x2336480", VA = "0x182337C80")]
	public static OGIPGLMKBDK DFLBOLBHLFN()
	{
		return default(OGIPGLMKBDK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GLMBCJEEJOK
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2330340", Offset = "0x232EB40", VA = "0x182330340")]
	public static void ANFLKJPBFFP(this OGIPGLMKBDK EGGDEECAALI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct IEJJLMGDMMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public BKFEAGFNBCE<int> BNNNPNADHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public BKFEAGFNBCE<int> FGAPCAIEHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int NOAIJDJLKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int KAFACMGNJJE;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2336400", Offset = "0x2334C00", VA = "0x182336400")]
	private IEJJLMGDMMM([In] BKFEAGFNBCE<int> KDHCJANIHHA, [In] BKFEAGFNBCE<int> CLAGCACIOHB, int HEFIEGLBEGP, int PEOAGPBEFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2336360", Offset = "0x2334B60", VA = "0x182336360")]
	public static IEJJLMGDMMM DFLBOLBHLFN()
	{
		return default(IEJJLMGDMMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class OAAAPBOHPIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2337A10", Offset = "0x2336210", VA = "0x182337A10")]
	public static void ANFLKJPBFFP(this IEJJLMGDMMM EGGDEECAALI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct INBJCKAHEJL
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum KLIOFNONECC
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class JBGPNODENOF : HBJADEOOHKH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct NOCBAMMFFFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly MFKBDIPIOIA<GIFCHBOBMFN> GEDPOOFACLC;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690")]
		public NOCBAMMFFFJ(MFKBDIPIOIA<GIFCHBOBMFN> IEACNDPCEOG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class FBEFKOPAOKF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class HBJADEOOHKH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct NEPNLDLCGEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly KLIOFNONECC COJDFBLAMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly MFKBDIPIOIA<HBJADEOOHKH> BIIKDDJEJAG;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x95D280", Offset = "0x95BA80", VA = "0x18095D280")]
		private NEPNLDLCGEG(KLIOFNONECC NBKJLJKCNBN, MFKBDIPIOIA<HBJADEOOHKH> BJMJJANHLNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2337530", Offset = "0x2335D30", VA = "0x182337530")]
		public static NEPNLDLCGEG DFLBOLBHLFN(KLIOFNONECC NBKJLJKCNBN, MFKBDIPIOIA<HBJADEOOHKH> BJMJJANHLNF)
		{
			return default(NEPNLDLCGEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class LDAKPHACFFJ : HBJADEOOHKH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct FHHPENDINFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly MFKBDIPIOIA<GIFCHBOBMFN> GEDPOOFACLC;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690")]
		public FHHPENDINFE(MFKBDIPIOIA<GIFCHBOBMFN> IEACNDPCEOG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class GIFCHBOBMFN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct CGNHOCENLIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public BKFEAGFNBCE<MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>> CKBNJEMHMJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public BKFEAGFNBCE<MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>> JKPKHNFEFOO;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x232F9E0", Offset = "0x232E1E0", VA = "0x18232F9E0")]
		private CGNHOCENLIA([In] BKFEAGFNBCE<MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>> HMHCPBFEMAJ, [In] BKFEAGFNBCE<MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>> HJGBKGCAOMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x232F960", Offset = "0x232E160", VA = "0x18232F960")]
		public static CGNHOCENLIA DFLBOLBHLFN()
		{
			return default(CGNHOCENLIA);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal FEGNOBMAFGE<FBEFKOPAOKF, NEPNLDLCGEG> AENLLDLLBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal FEGNOBMAFGE<LDAKPHACFFJ, FHHPENDINFE> DBOOHJOHMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal FEGNOBMAFGE<JBGPNODENOF, NOCBAMMFFFJ> BDCAMKFCLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal BKFEAGFNBCE<(MFKBDIPIOIA<FBEFKOPAOKF> CallId, MFKBDIPIOIA<GIFCHBOBMFN> IOId)> GPMDFOPAKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal FEGNOBMAFGE<GIFCHBOBMFN, CGNHOCENLIA> OAGOPABLAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal JPBBBEKNEPH<GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>> BJAPCIGMGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal JPBBBEKNEPH<GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>>> ODDOCOAFDFL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x23366F0", Offset = "0x2334EF0", VA = "0x1823366F0")]
	private INBJCKAHEJL([In] FEGNOBMAFGE<FBEFKOPAOKF, NEPNLDLCGEG> FLJKOENEEKD, [In] FEGNOBMAFGE<LDAKPHACFFJ, FHHPENDINFE> NOOCELBGMLA, [In] FEGNOBMAFGE<JBGPNODENOF, NOCBAMMFFFJ> OMIPKPGFDMC, [In] BKFEAGFNBCE<(MFKBDIPIOIA<FBEFKOPAOKF> CallId, MFKBDIPIOIA<GIFCHBOBMFN> IOId)> DMEFOGEJFNO, [In] FEGNOBMAFGE<GIFCHBOBMFN, CGNHOCENLIA> KCGLEPMAMEI, [In] JPBBBEKNEPH<GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>> IFGINANKKMP, [In] JPBBBEKNEPH<GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>>> JMOHOOMDOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2336550", Offset = "0x2334D50", VA = "0x182336550")]
	public static INBJCKAHEJL DFLBOLBHLFN()
	{
		return default(INBJCKAHEJL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class LPLIKBCLIAN
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2337070", Offset = "0x2335870", VA = "0x182337070")]
	private static void ANFLKJPBFFP(this INBJCKAHEJL.CGNHOCENLIA EGGDEECAALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2336E60", Offset = "0x2335660", VA = "0x182336E60")]
	public static void ANFLKJPBFFP(this INBJCKAHEJL EGGDEECAALI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct HCDFNGMMBJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public BKFEAGFNBCE<byte> CGMPCPELHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal INBJCKAHEJL HEJBAMMKJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal NHNFOLHNIOL BFEGABDPEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>> KKHGKAOBJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal APCPAIOKILN CGOGBKEAJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal OGIPGLMKBDK KJLAIEHNJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal JPBBBEKNEPH<LICJAHLPDHN, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>?> LICGALGLFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal BKFEAGFNBCE<MFKBDIPIOIA<LICJAHLPDHN>> EFGNFOHBDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal JPBBBEKNEPH<EGENAIBALPJ, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>?> GECIFIGCEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal BKFEAGFNBCE<(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> VariableId, MFKBDIPIOIA<LJPMKJJEGFC<HENLHNNLGLJ<LNCIJMKJPCJ>>> ByteCodeWriteLocation)> OKOOGADIBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> JHOKIGDAHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal LPPOFCGDIDN LMFCOFLMDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal ENAHCALHFJK APHHMFCIAFN;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2330D50", Offset = "0x232F550", VA = "0x182330D50")]
	private HCDFNGMMBJI([In] BKFEAGFNBCE<byte> PAJJGGNCNPE, [In] INBJCKAHEJL FHHOJGIBNEF, [In] NHNFOLHNIOL ACGECGPKGKG, [In] APCPAIOKILN LFBNANFNPJE, [In] OGIPGLMKBDK DJJJBHLNNGI, [In] JPBBBEKNEPH<LICJAHLPDHN, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>?> PNPBPKIEBJP, [In] BKFEAGFNBCE<MFKBDIPIOIA<LICJAHLPDHN>> DMKMOMCOCEI, [In] JPBBBEKNEPH<EGENAIBALPJ, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>?> HGDFBILNJKI, [In] BKFEAGFNBCE<(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> VariableId, MFKBDIPIOIA<LJPMKJJEGFC<HENLHNNLGLJ<LNCIJMKJPCJ>>> ByteCodeWriteLocation)> LBLIMKPNDMF, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> IEGPJGHMFGF, [In] LPPOFCGDIDN BEHHAPJEKHC, [In] ENAHCALHFJK MFFLKKELGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x23303A0", Offset = "0x232EBA0", VA = "0x1823303A0")]
	public static HCDFNGMMBJI DFLBOLBHLFN()
	{
		return default(HCDFNGMMBJI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BJEOJBOBKMJ
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct IIHDGLJINOJ : EHKICPBOJMA<MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>, JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2336460", Offset = "0x2334C60", VA = "0x182336460")]
		public MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FMHFBPIEKJD(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> ECDOOAABOPD, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2336520", Offset = "0x2334D20", VA = "0x182336520", Slot = "4")]
		public MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> OMKMCDEHOHK(int ECDOOAABOPD)
		{
			return default(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0")]
		public bool CCMPOGCBKLF(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> ECDOOAABOPD, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>> MCAFGDLBCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "5")]
		private bool AEBGNBBGGIB(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> ECDOOAABOPD, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>> MCAFGDLBCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2336510", Offset = "0x2334D10", VA = "0x182336510", Slot = "6")]
		private MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> OIFEJGAEAPK(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> ECDOOAABOPD, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct KPEGNPJCFNN : LPIMFCHKGDH<MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>, JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2336C70", Offset = "0x2335470", VA = "0x182336C70")]
		public BKFEAGFNBCE<MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>> JLBIMCPDHLL(int MEIKGPEMKHJ, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>> MCAFGDLBCDD)
		{
			return default(BKFEAGFNBCE<MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2336CF0", Offset = "0x23354F0", VA = "0x182336CF0")]
		public MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FMHFBPIEKJD(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> ECDOOAABOPD, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2336DA0", Offset = "0x23355A0", VA = "0x182336DA0", Slot = "6")]
		public void GNDCHNCHNGI(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> ECDOOAABOPD, JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>> MCAFGDLBCDD, MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2336C70", Offset = "0x2335470", VA = "0x182336C70", Slot = "4")]
		private BKFEAGFNBCE<MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>> FHCBKLGOOPP(int MEIKGPEMKHJ, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>> MCAFGDLBCDD)
		{
			return default(BKFEAGFNBCE<MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2336CE0", Offset = "0x23354E0", VA = "0x182336CE0", Slot = "5")]
		private MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FIDOADEFDKA(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> ECDOOAABOPD, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct MNLOBBBAHDP : EHKICPBOJMA<MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>, JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2337410", Offset = "0x2335C10", VA = "0x182337410")]
		public MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FMHFBPIEKJD(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> ECDOOAABOPD, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>>> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x23374D0", Offset = "0x2335CD0", VA = "0x1823374D0", Slot = "4")]
		public MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> OMKMCDEHOHK(int ECDOOAABOPD)
		{
			return default(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0")]
		public bool CCMPOGCBKLF(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> ECDOOAABOPD, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>>> MCAFGDLBCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "5")]
		private bool EKGKIMMAGFC(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> ECDOOAABOPD, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>>> MCAFGDLBCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x23374C0", Offset = "0x2335CC0", VA = "0x1823374C0", Slot = "6")]
		private MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> LCBDJLMDCNP(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> ECDOOAABOPD, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>>> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct JAFIPNEGLDO : LPIMFCHKGDH<MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>, JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2336860", Offset = "0x2335060", VA = "0x182336860")]
		public BKFEAGFNBCE<MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>> JLBIMCPDHLL(int MEIKGPEMKHJ, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>>> MCAFGDLBCDD)
		{
			return default(BKFEAGFNBCE<MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x23367B0", Offset = "0x2334FB0", VA = "0x1823367B0")]
		public MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FMHFBPIEKJD(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> ECDOOAABOPD, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>>> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x23368D0", Offset = "0x23350D0", VA = "0x1823368D0", Slot = "6")]
		public void GNDCHNCHNGI(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> ECDOOAABOPD, JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>>> MCAFGDLBCDD, MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2336860", Offset = "0x2335060", VA = "0x182336860", Slot = "4")]
		private BKFEAGFNBCE<MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>> FPAEFAJHGMI(int MEIKGPEMKHJ, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>>> MCAFGDLBCDD)
		{
			return default(BKFEAGFNBCE<MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2336990", Offset = "0x2335190", VA = "0x182336990", Slot = "5")]
		private MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> PACJEMPMNEK(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> ECDOOAABOPD, [In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>>> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct KCAOANELKKH : EHKICPBOJMA<MFKBDIPIOIA<EGENAIBALPJ>, JPBBBEKNEPH<EGENAIBALPJ, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2336A30", Offset = "0x2335230", VA = "0x182336A30")]
		public MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FMHFBPIEKJD(MFKBDIPIOIA<EGENAIBALPJ> ECDOOAABOPD, [In] JPBBBEKNEPH<EGENAIBALPJ, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>?> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2336B00", Offset = "0x2335300", VA = "0x182336B00", Slot = "4")]
		public MFKBDIPIOIA<EGENAIBALPJ> OMKMCDEHOHK(int ECDOOAABOPD)
		{
			return default(MFKBDIPIOIA<EGENAIBALPJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x23369A0", Offset = "0x23351A0", VA = "0x1823369A0")]
		public bool CCMPOGCBKLF(MFKBDIPIOIA<EGENAIBALPJ> ECDOOAABOPD, [In] JPBBBEKNEPH<EGENAIBALPJ, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>?> MCAFGDLBCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x23369A0", Offset = "0x23351A0", VA = "0x1823369A0", Slot = "5")]
		private bool KONPKKPEHNO(MFKBDIPIOIA<EGENAIBALPJ> ECDOOAABOPD, [In] JPBBBEKNEPH<EGENAIBALPJ, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>?> MCAFGDLBCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2336A20", Offset = "0x2335220", VA = "0x182336A20", Slot = "6")]
		private MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> EBNECJMNCLA(MFKBDIPIOIA<EGENAIBALPJ> ECDOOAABOPD, [In] JPBBBEKNEPH<EGENAIBALPJ, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>?> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct OJNHKEGIEHC : LPIMFCHKGDH<MFKBDIPIOIA<EGENAIBALPJ>, JPBBBEKNEPH<EGENAIBALPJ, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2337DC0", Offset = "0x23365C0", VA = "0x182337DC0")]
		public BKFEAGFNBCE<MFKBDIPIOIA<EGENAIBALPJ>> JLBIMCPDHLL(int MEIKGPEMKHJ, [In] JPBBBEKNEPH<EGENAIBALPJ, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>?> MCAFGDLBCDD)
		{
			return default(BKFEAGFNBCE<MFKBDIPIOIA<EGENAIBALPJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2337E30", Offset = "0x2336630", VA = "0x182337E30")]
		public MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FMHFBPIEKJD(MFKBDIPIOIA<EGENAIBALPJ> ECDOOAABOPD, [In] JPBBBEKNEPH<EGENAIBALPJ, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>?> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2337F10", Offset = "0x2336710", VA = "0x182337F10", Slot = "6")]
		public void GNDCHNCHNGI(MFKBDIPIOIA<EGENAIBALPJ> ECDOOAABOPD, JPBBBEKNEPH<EGENAIBALPJ, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>?> MCAFGDLBCDD, MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2337DC0", Offset = "0x23365C0", VA = "0x182337DC0", Slot = "4")]
		private BKFEAGFNBCE<MFKBDIPIOIA<EGENAIBALPJ>> DGNANOBFMMC(int MEIKGPEMKHJ, [In] JPBBBEKNEPH<EGENAIBALPJ, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>?> MCAFGDLBCDD)
		{
			return default(BKFEAGFNBCE<MFKBDIPIOIA<EGENAIBALPJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2337F00", Offset = "0x2336700", VA = "0x182337F00", Slot = "5")]
		private MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> GECGBMPHFKE(MFKBDIPIOIA<EGENAIBALPJ> ECDOOAABOPD, [In] JPBBBEKNEPH<EGENAIBALPJ, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>?> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct NPCIBPMAFOO : EHKICPBOJMA<int, BKFEAGFNBCE<(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>, MFKBDIPIOIA<LJPMKJJEGFC<HENLHNNLGLJ<LNCIJMKJPCJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x23378E0", Offset = "0x23360E0", VA = "0x1823378E0")]
		public MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FMHFBPIEKJD(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> VariableId, MFKBDIPIOIA<LJPMKJJEGFC<HENLHNNLGLJ<LNCIJMKJPCJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9CB800", Offset = "0x9CA000", VA = "0x1809CB800", Slot = "4")]
		public int OMKMCDEHOHK(int ECDOOAABOPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0")]
		public bool CCMPOGCBKLF(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> VariableId, MFKBDIPIOIA<LJPMKJJEGFC<HENLHNNLGLJ<LNCIJMKJPCJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "5")]
		private bool AIHJGCJNKIJ(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> VariableId, MFKBDIPIOIA<LJPMKJJEGFC<HENLHNNLGLJ<LNCIJMKJPCJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2337980", Offset = "0x2336180", VA = "0x182337980", Slot = "6")]
		private MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FOKJKHKNMNJ(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> VariableId, MFKBDIPIOIA<LJPMKJJEGFC<HENLHNNLGLJ<LNCIJMKJPCJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct ODDFBDLIABC : LPIMFCHKGDH<int, BKFEAGFNBCE<(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>, MFKBDIPIOIA<LJPMKJJEGFC<HENLHNNLGLJ<LNCIJMKJPCJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2337A60", Offset = "0x2336260", VA = "0x182337A60")]
		public BKFEAGFNBCE<int> JLBIMCPDHLL(int MEIKGPEMKHJ, [In] BKFEAGFNBCE<(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> VariableId, MFKBDIPIOIA<LJPMKJJEGFC<HENLHNNLGLJ<LNCIJMKJPCJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(BKFEAGFNBCE<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2337AE0", Offset = "0x23362E0", VA = "0x182337AE0")]
		public MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FMHFBPIEKJD(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> VariableId, MFKBDIPIOIA<LJPMKJJEGFC<HENLHNNLGLJ<LNCIJMKJPCJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2337B80", Offset = "0x2336380", VA = "0x182337B80", Slot = "6")]
		public void GNDCHNCHNGI(int ECDOOAABOPD, BKFEAGFNBCE<(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> VariableId, MFKBDIPIOIA<LJPMKJJEGFC<HENLHNNLGLJ<LNCIJMKJPCJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD, MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2337A60", Offset = "0x2336260", VA = "0x182337A60", Slot = "4")]
		private BKFEAGFNBCE<int> CMCFNLGNADI(int MEIKGPEMKHJ, [In] BKFEAGFNBCE<(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> VariableId, MFKBDIPIOIA<LJPMKJJEGFC<HENLHNNLGLJ<LNCIJMKJPCJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(BKFEAGFNBCE<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2337AD0", Offset = "0x23362D0", VA = "0x182337AD0", Slot = "5")]
		private MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> EADCNIOOPDN(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> VariableId, MFKBDIPIOIA<LJPMKJJEGFC<HENLHNNLGLJ<LNCIJMKJPCJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct CMNIPNKFAHI : EHKICPBOJMA<int, BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x232FA20", Offset = "0x232E220", VA = "0x18232FA20")]
		public MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FMHFBPIEKJD(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9CB800", Offset = "0x9CA000", VA = "0x1809CB800", Slot = "4")]
		public int OMKMCDEHOHK(int ECDOOAABOPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0")]
		public bool CCMPOGCBKLF(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "5")]
		private bool FDACEIEEKJA(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x232FAC0", Offset = "0x232E2C0", VA = "0x18232FAC0", Slot = "6")]
		private MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> NLNMNEJDBCE(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct EINJKAHGCFM : LPIMFCHKGDH<int, BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x232FC30", Offset = "0x232E430", VA = "0x18232FC30")]
		public BKFEAGFNBCE<int> JLBIMCPDHLL(int MEIKGPEMKHJ, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(BKFEAGFNBCE<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x232FCB0", Offset = "0x232E4B0", VA = "0x18232FCB0")]
		public MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FMHFBPIEKJD(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x232FD50", Offset = "0x232E550", VA = "0x18232FD50", Slot = "6")]
		public void GNDCHNCHNGI(int ECDOOAABOPD, BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD, MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x232FC30", Offset = "0x232E430", VA = "0x18232FC30", Slot = "4")]
		private BKFEAGFNBCE<int> BACABELEKCE(int MEIKGPEMKHJ, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(BKFEAGFNBCE<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x232FCA0", Offset = "0x232E4A0", VA = "0x18232FCA0", Slot = "5")]
		private MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FEKFGLCBLIH(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct EMBOFCKNDIE : EHKICPBOJMA<int, BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x232FE40", Offset = "0x232E640", VA = "0x18232FE40")]
		public MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FMHFBPIEKJD(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9CB800", Offset = "0x9CA000", VA = "0x1809CB800", Slot = "4")]
		public int OMKMCDEHOHK(int ECDOOAABOPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0")]
		public bool CCMPOGCBKLF(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "5")]
		private bool FDACEIEEKJA(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x232FEE0", Offset = "0x232E6E0", VA = "0x18232FEE0", Slot = "6")]
		private MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> NLNMNEJDBCE(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct GHNKPNAPIJM : LPIMFCHKGDH<int, BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x23300E0", Offset = "0x232E8E0", VA = "0x1823300E0")]
		public BKFEAGFNBCE<int> JLBIMCPDHLL(int MEIKGPEMKHJ, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(BKFEAGFNBCE<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2330160", Offset = "0x232E960", VA = "0x182330160")]
		public MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FMHFBPIEKJD(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2330200", Offset = "0x232EA00", VA = "0x182330200", Slot = "6")]
		public void GNDCHNCHNGI(int ECDOOAABOPD, BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD, MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x23300E0", Offset = "0x232E8E0", VA = "0x1823300E0", Slot = "4")]
		private BKFEAGFNBCE<int> BACABELEKCE(int MEIKGPEMKHJ, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(BKFEAGFNBCE<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2330150", Offset = "0x232E950", VA = "0x182330150", Slot = "5")]
		private MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FEKFGLCBLIH(int ECDOOAABOPD, [In] BKFEAGFNBCE<(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> Target, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> ByteCodeWriteLocation)> MCAFGDLBCDD)
		{
			return default(MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct NEBKGNHMNJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> DBDIBCGOIMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool MHBPKCNNHEC;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x181D9E0", Offset = "0x181C1E0", VA = "0x18181D9E0")]
		public NEBKGNHMNJG(MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> AMGMIEKCCLJ, bool BEBDPIFKFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2337520", Offset = "0x2335D20", VA = "0x182337520")]
		public void CCFBGGDGJEK([Out] MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> AMGMIEKCCLJ, [Out] bool BEBDPIFKFDP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct GJHCMDOPNIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly MFKBDIPIOIA<EGENAIBALPJ> FMGEPJBGJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> DBDIBCGOIMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool MHBPKCNNHEC;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2330330", Offset = "0x232EB30", VA = "0x182330330")]
		public GJHCMDOPNIM(MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> AMGMIEKCCLJ, bool BEBDPIFKFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2330320", Offset = "0x232EB20", VA = "0x182330320")]
		public void CCFBGGDGJEK([Out] MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> AMGMIEKCCLJ, [Out] bool BEBDPIFKFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2330300", Offset = "0x232EB00", VA = "0x182330300")]
		public void CCFBGGDGJEK([Out] MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> AMGMIEKCCLJ, [Out] MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF, [Out] bool BEBDPIFKFDP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct PGPBDMNHNKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly MFKBDIPIOIA<EGENAIBALPJ> FMGEPJBGJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> DBDIBCGOIMD;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x95D280", Offset = "0x95BA80", VA = "0x18095D280")]
		public PGPBDMNHNKD(MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> AMGMIEKCCLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2337FF0", Offset = "0x23367F0", VA = "0x182337FF0")]
		public void CCFBGGDGJEK([Out] MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> AMGMIEKCCLJ, [Out] MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x232D2E0", Offset = "0x232BAE0", VA = "0x18232D2E0")]
	public static void ANFLKJPBFFP(this HCDFNGMMBJI EGGDEECAALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x232F490", Offset = "0x232DC90", VA = "0x18232F490")]
	public static void OPGGNLLMNNP(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<LICJAHLPDHN> FDJOEDBJICL, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> MPJEMONBAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x232DD10", Offset = "0x232C510", VA = "0x18232DD10")]
	public static void ELMCKPPICCH(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<LICJAHLPDHN> FDJOEDBJICL, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> MPJEMONBAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x232F8A0", Offset = "0x232E0A0", VA = "0x18232F8A0")]
	public static MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>? PKFIOILIEKJ([In] this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<LICJAHLPDHN> FDJOEDBJICL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x232E190", Offset = "0x232C990", VA = "0x18232E190")]
	public static MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> IBCCCIHPBMI([In] this HCDFNGMMBJI EGGDEECAALI)
	{
		return default(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x232D5B0", Offset = "0x232BDB0", VA = "0x18232D5B0")]
	private static void BEDNGGBPADN(this HCDFNGMMBJI EGGDEECAALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x232EBC0", Offset = "0x232D3C0", VA = "0x18232EBC0")]
	private static MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>? LJLGLGKNGLN([In] this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x232DBA0", Offset = "0x232C3A0", VA = "0x18232DBA0")]
	public static void DJEAFDINBOL(this HCDFNGMMBJI EGGDEECAALI, [In] BKFEAGFNBCE<ILNIJBJKIOJ> BKJBECOLFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x232E090", Offset = "0x232C890", VA = "0x18232E090")]
	public static APCPAIOKILN.BAFKDGKFAHO HEPAKNKGAOJ([In] this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> AMGMIEKCCLJ)
	{
		return default(APCPAIOKILN.BAFKDGKFAHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x232D8E0", Offset = "0x232C0E0", VA = "0x18232D8E0")]
	public static KMIPOEIGPEN<byte> CCHKNBGHGBE([In] this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> AMGMIEKCCLJ)
	{
		return default(KMIPOEIGPEN<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x232E400", Offset = "0x232CC00", VA = "0x18232E400")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> INMEEDCHMGD([In] this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> AMGMIEKCCLJ)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x232DFA0", Offset = "0x232C7A0", VA = "0x18232DFA0")]
	public static CGDEJEKEJDL HBIGPIAJCDC([In] this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> AMGMIEKCCLJ)
	{
		return default(CGDEJEKEJDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7300", Offset = "0x2DE5B00", VA = "0x182DE7300")]
	private static MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> CGCPOOIDJBI<TMJoin>(this HCDFNGMMBJI EGGDEECAALI, APCPAIOKILN.BAFKDGKFAHO NBKJLJKCNBN, MFKBDIPIOIA<TMJoin> BJMJJANHLNF) where TMJoin : APCPAIOKILN.GNDDHFDOAAP
	{
		return default(MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x232E330", Offset = "0x232CB30", VA = "0x18232E330")]
	public static MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> IKGMAOBIOLD(this HCDFNGMMBJI EGGDEECAALI, bool DPBKJNPJAEF)
	{
		return default(MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x232E4F0", Offset = "0x232CCF0", VA = "0x18232E4F0")]
	public static MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> JFFOIEHGKIM(this HCDFNGMMBJI EGGDEECAALI, KMIPOEIGPEN<byte> LMGNHIJGDNP)
	{
		return default(MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x232DB20", Offset = "0x232C320", VA = "0x18232DB20")]
	public static MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> CNOLAFNMBKJ(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> PMIICILOMOP)
	{
		return default(MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x232F2E0", Offset = "0x232DAE0", VA = "0x18232F2E0")]
	public static MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> OJHEEILCNJA(this HCDFNGMMBJI EGGDEECAALI, int BPMKGNODPMO)
	{
		return default(MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x232D720", Offset = "0x232BF20", VA = "0x18232D720")]
	public static MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> BLMENLHAJHJ(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> FKOIODJLAKG)
	{
		return default(MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8CD0", Offset = "0x2DE74D0", VA = "0x182DE8CD0")]
	private static MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ> KAACIMIJKIA<TMJoin>(this HCDFNGMMBJI EGGDEECAALI, OGIPGLMKBDK.BNILKCELPIA NBKJLJKCNBN, MFKBDIPIOIA<TMJoin> BJMJJANHLNF) where TMJoin : OGIPGLMKBDK.AIDKCNCEMCM
	{
		return default(MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x232F250", Offset = "0x232DA50", VA = "0x18232F250")]
	public static MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ> OCBOIKOFPEA(this HCDFNGMMBJI EGGDEECAALI)
	{
		return default(MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x232F290", Offset = "0x232DA90", VA = "0x18232F290")]
	public static MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ> OHKLPLMJMPG(this HCDFNGMMBJI EGGDEECAALI)
	{
		return default(MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x232F1D0", Offset = "0x232D9D0", VA = "0x18232F1D0")]
	public static MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ> OADFMGNMGLC(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> OIOBLMOILDG)
	{
		return default(MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x232F760", Offset = "0x232DF60", VA = "0x18232F760")]
	public static MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ> PHMIKDNCGKI(this HCDFNGMMBJI EGGDEECAALI)
	{
		return default(MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x232E3B0", Offset = "0x232CBB0", VA = "0x18232E3B0")]
	public static MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ> ILPJJAFKGPB(this HCDFNGMMBJI EGGDEECAALI)
	{
		return default(MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x232F6E0", Offset = "0x232DEE0", VA = "0x18232F6E0")]
	public static INBJCKAHEJL.KLIOFNONECC PCILFFKPJLO([In] this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF> IJHOOCFLCJF)
	{
		return default(INBJCKAHEJL.KLIOFNONECC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x232DED0", Offset = "0x232C6D0", VA = "0x18232DED0")]
	public static DBCHGPAHFGN<MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>, LEECIPCLNDP<INBJCKAHEJL.GIFCHBOBMFN>> GHAPKFJEMBO([In] this HCDFNGMMBJI EGGDEECAALI)
	{
		return default(DBCHGPAHFGN<MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>, LEECIPCLNDP<INBJCKAHEJL.GIFCHBOBMFN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x232E950", Offset = "0x232D150", VA = "0x18232E950")]
	public static MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> LEAEMLLCOBL([In] this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF> IJHOOCFLCJF)
	{
		return default(MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x232E110", Offset = "0x232C910", VA = "0x18232E110")]
	public static INBJCKAHEJL.CGNHOCENLIA HKJKEKANDCI([In] this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> IEACNDPCEOG)
	{
		return default(INBJCKAHEJL.CGNHOCENLIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x232D9D0", Offset = "0x232C1D0", VA = "0x18232D9D0")]
	public static INBJCKAHEJL.CGNHOCENLIA CFIFPFINKID(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> IEACNDPCEOG)
	{
		return default(INBJCKAHEJL.CGNHOCENLIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8D80", Offset = "0x2DE7580", VA = "0x182DE8D80")]
	private static MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF> MCKKIONGDNJ<TMJoin>(this HCDFNGMMBJI EGGDEECAALI, INBJCKAHEJL.KLIOFNONECC NBKJLJKCNBN, MFKBDIPIOIA<TMJoin> BJMJJANHLNF) where TMJoin : INBJCKAHEJL.HBJADEOOHKH
	{
		return default(MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x232E6B0", Offset = "0x232CEB0", VA = "0x18232E6B0")]
	public static (MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF>, MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>) KCKLBFFEDLH(this HCDFNGMMBJI EGGDEECAALI)
	{
		return default((MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF>, MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x232EC80", Offset = "0x232D480", VA = "0x18232EC80")]
	public static (MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF>, MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>) LLPNAPFNKCA(this HCDFNGMMBJI EGGDEECAALI)
	{
		return default((MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF>, MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x232E2E0", Offset = "0x232CAE0", VA = "0x18232E2E0")]
	public static MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF> IJEHMNMMKGO(this HCDFNGMMBJI EGGDEECAALI)
	{
		return default(MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x232EB30", Offset = "0x232D330", VA = "0x18232EB30")]
	public static void LEJIBDAFCMF(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN> IEACNDPCEOG, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> FDLLGEAAFPD, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>> FNBPIJCDJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7970", Offset = "0x2DE6170", VA = "0x182DE7970")]
	public static NEBKGNHMNJG DOGNPOGCOFN<TDeps, TStateSys>(this HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF) where TDeps : CLLLJIAFLNB<TStateSys>
	{
		return default(NEBKGNHMNJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8E20", Offset = "0x2DE7620", VA = "0x182DE8E20")]
	public static GJHCMDOPNIM NJECMAHMEPM<TDeps, TStateSys>(this HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<BAFEGHIGBOE> FJIFOJCFNEO, int MBDHFCHAHDG) where TDeps : CLLLJIAFLNB<TStateSys>
	{
		return default(GJHCMDOPNIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8890", Offset = "0x2DE7090", VA = "0x182DE8890")]
	public static MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>? JFMDDAOEGCE<TDeps, TStateSys>(this HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<BAFEGHIGBOE> FJIFOJCFNEO, [In] ReadOnlySpan<int> DNAPJNAOIJB, [In] Span<PGPBDMNHNKD> DAEFDOMHMFE) where TDeps : CLLLJIAFLNB<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2DE73B0", Offset = "0x2DE5BB0", VA = "0x182DE73B0")]
	public static MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ> DHIPACMDNHJ<TDeps, TStateSys>(this HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<LICJAHLPDHN> FDJOEDBJICL) where TDeps : CLLLJIAFLNB<TStateSys>
	{
		return default(MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x232F7B0", Offset = "0x232DFB0", VA = "0x18232F7B0")]
	public static NHNFOLHNIOL.ICFMHNHMLLH PJIIEABGBOO([In] this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DOBPKLNCBDO)
	{
		return default(NHNFOLHNIOL.ICFMHNHMLLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x232DDE0", Offset = "0x232C5E0", VA = "0x18232DDE0")]
	public static NHNFOLHNIOL.DJLOIEBMMOM GGHMCPPOHHH([In] this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DOBPKLNCBDO)
	{
		return default(NHNFOLHNIOL.DJLOIEBMMOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x232E860", Offset = "0x232D060", VA = "0x18232E860")]
	public static NHNFOLHNIOL.ACELNIOOEGM LBALONLPDLG([In] this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DOBPKLNCBDO)
	{
		return default(NHNFOLHNIOL.ACELNIOOEGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x232EE30", Offset = "0x232D630", VA = "0x18232EE30")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> LOGNNBHFFIB(this HCDFNGMMBJI EGGDEECAALI, int? FLDEIPDLDDG, string IKMKCMDHFDC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x232E1F0", Offset = "0x232C9F0", VA = "0x18232E1F0")]
	public static NHNFOLHNIOL.MJLOAOKLOIL IGBMBLIABBD([In] this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DOBPKLNCBDO)
	{
		return default(NHNFOLHNIOL.MJLOAOKLOIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x232F520", Offset = "0x232DD20", VA = "0x18232F520")]
	public static NHNFOLHNIOL.PLKCGINFHEA OPHAIKHJPHC([In] this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DOBPKLNCBDO)
	{
		return default(NHNFOLHNIOL.PLKCGINFHEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x232F0D0", Offset = "0x232D8D0", VA = "0x18232F0D0")]
	public static int? MNIEAGMIACL([In] this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DOBPKLNCBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8790", Offset = "0x2DE6F90", VA = "0x182DE8790")]
	private static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> FNDECMIKBOF<TMJoin>(this HCDFNGMMBJI EGGDEECAALI, int? FLDEIPDLDDG, NHNFOLHNIOL.PLKCGINFHEA NBKJLJKCNBN, MFKBDIPIOIA<TMJoin> BJMJJANHLNF) where TMJoin : NHNFOLHNIOL.NMOOJNAKNMJ
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x232EFC0", Offset = "0x232D7C0", VA = "0x18232EFC0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> LOKPNJFPLNI(this HCDFNGMMBJI EGGDEECAALI, int? FLDEIPDLDDG, MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF> IJHOOCFLCJF, int ECDOOAABOPD)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x232E580", Offset = "0x232CD80", VA = "0x18232E580")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> JIICOPCEODJ(this HCDFNGMMBJI EGGDEECAALI, int? FLDEIPDLDDG)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x232F590", Offset = "0x232DD90", VA = "0x18232F590")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PBMCGFHOAGF(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>? DGPEKJOONMO, int? FLDEIPDLDDG)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x232DF10", Offset = "0x232C710", VA = "0x18232DF10")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> GIDNNLJOHGL(this HCDFNGMMBJI EGGDEECAALI, int? FLDEIPDLDDG, int ECDOOAABOPD)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x232F070", Offset = "0x232D870", VA = "0x18232F070")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MFIBHFOBOPI(this HCDFNGMMBJI EGGDEECAALI, int? FLDEIPDLDDG)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x232D7A0", Offset = "0x232BFA0", VA = "0x18232D7A0")]
	public static void BNBLCKKPJKC(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> FKOIODJLAKG, MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF> IJHOOCFLCJF, int ECDOOAABOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x232F360", Offset = "0x232DB60", VA = "0x18232F360")]
	public static void ONBMGKAIMCI(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> FKOIODJLAKG, int ECDOOAABOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x232DA50", Offset = "0x232C250", VA = "0x18232DA50")]
	public static void CHANMLIGMAN(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> FKOIODJLAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x232F140", Offset = "0x232D940", VA = "0x18232F140")]
	public static void NKIENGOEGCD(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> BIINCLMPDMO, MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> GKKADFLFIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x232E5E0", Offset = "0x232CDE0", VA = "0x18232E5E0")]
	public static void JJMAKAFFDCO(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> FKOIODJLAKG, MFKBDIPIOIA<LJPMKJJEGFC<PDDCLNMPLFN>> EIGCBJNPABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7230", Offset = "0x2DE5A30", VA = "0x182DE7230")]
	public static void BMOMHINFBEO<M>(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> FKOIODJLAKG, MFKBDIPIOIA<LJPMKJJEGFC<HENLHNNLGLJ<M>>> EIGCBJNPABE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface CLLLJIAFLNB<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MFKBDIPIOIA<PIOEAILIPCP> ADNDHHAEDKG(TStateSys GCFIOFGBHJJ);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MFKBDIPIOIA<PIOEAILIPCP> KIAIOALEBOP(TStateSys GCFIOFGBHJJ);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MFKBDIPIOIA<PIOEAILIPCP> CDEMNAMIDNH(TStateSys GCFIOFGBHJJ);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MFKBDIPIOIA<PIOEAILIPCP> DGLOIFANKCN(TStateSys GCFIOFGBHJJ);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ> EMDMBHNEGJI(TStateSys GCFIOFGBHJJ, HCDFNGMMBJI FELDNLNHADD, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> EBKIKOJOFGC(TStateSys GCFIOFGBHJJ, HCDFNGMMBJI FELDNLNHADD, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<LICJAHLPDHN> FDJOEDBJICL);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int CLDPGNDPOMA(TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MFKBDIPIOIA<LICJAHLPDHN> IPJAJJFBBHH(TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF, int HFNEAMCNOBC);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OLOHINCMFBM NFNJIEHLDAH(TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ILKMJCFKCJG(TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int BIJKNFMGPGF(TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KMIPOEIGPEN<byte> CAOMJKPFPEB(TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(KMIPOEIGPEN<byte>, MFKBDIPIOIA<PIOEAILIPCP>) CEBNFNJHOMF(TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int MHMOCEPOKJP(TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<LICJAHLPDHN> FDJOEDBJICL);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MFKBDIPIOIA<EGENAIBALPJ> OPHNJBPKALA(TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<LICJAHLPDHN> FDJOEDBJICL, int MBDHFCHAHDG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MFKBDIPIOIA<EGENAIBALPJ> DBHFCDKPMBK(TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<BAFEGHIGBOE> FJIFOJCFNEO, int MBDHFCHAHDG);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int POMCJLINHPG(TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? PDPBLLPKNAM(TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, int ECDOOAABOPD);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int MGPJEFHPMAL(TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? GAOCNILDANO(TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, int ECDOOAABOPD);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HJHKPLNGHPE
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x30896C0", Offset = "0x3087EC0", VA = "0x1830896C0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE?> IKPDEGBLIBL<T, TOpInput, TOpOutput>(this HCDFNGMMBJI EGGDEECAALI, T GJAJAHIEACP, T MCEIDNFODED, int IIIIMOLKPMA, IntPtr NEEFBCKJALG)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3089320", Offset = "0x3087B20", VA = "0x183089320")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE?> HFCKCKMAOOD<T, TOpInput, TOpOutput>(this HCDFNGMMBJI EGGDEECAALI, T GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED, int IIIIMOLKPMA, IntPtr NEEFBCKJALG)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3088D00", Offset = "0x3087500", VA = "0x183088D00")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE?> GFOCDAJMJJM<TOpInput, TOpOutput>(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED, int IIIIMOLKPMA, IntPtr NEEFBCKJALG)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2332550", Offset = "0x2330D50", VA = "0x182332550")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> EJIGHEDBFOI(this HCDFNGMMBJI EGGDEECAALI, float MJJFEOILBKP, float PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2334830", Offset = "0x2333030", VA = "0x182334830")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> LDGDFAFNFBM(this HCDFNGMMBJI EGGDEECAALI, float MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x23317B0", Offset = "0x232FFB0", VA = "0x1823317B0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> BFOHPJCGIKK(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2332650", Offset = "0x2330E50", VA = "0x182332650")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> FBHNOKONPHJ(this HCDFNGMMBJI EGGDEECAALI, int MJJFEOILBKP, int PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2334B70", Offset = "0x2333370", VA = "0x182334B70")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MHMPHCPPPFC(this HCDFNGMMBJI EGGDEECAALI, int MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2334F80", Offset = "0x2333780", VA = "0x182334F80")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> OFJJIAGCKGL(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2333CC0", Offset = "0x23324C0", VA = "0x182333CC0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> KBIAFGDDPMM(this HCDFNGMMBJI EGGDEECAALI, int MJJFEOILBKP, int PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x23310B0", Offset = "0x232F8B0", VA = "0x1823310B0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> ACMKLEAOHBI(this HCDFNGMMBJI EGGDEECAALI, int MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2332A10", Offset = "0x2331210", VA = "0x182332A10")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> GJLHOJPGLOL(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2335C30", Offset = "0x2334430", VA = "0x182335C30")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PJGJJDKOMNN(this HCDFNGMMBJI EGGDEECAALI, int GJAJAHIEACP, int MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2335A20", Offset = "0x2334220", VA = "0x182335A20")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PAPNCDHMOJL(this HCDFNGMMBJI EGGDEECAALI, int GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x23342D0", Offset = "0x2332AD0", VA = "0x1823342D0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> KPBHHJIHJDI(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2332E10", Offset = "0x2331610", VA = "0x182332E10")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> HIALGDAMNIM(this HCDFNGMMBJI EGGDEECAALI, float GJAJAHIEACP, float MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x23334F0", Offset = "0x2331CF0", VA = "0x1823334F0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> IMBFECIFHAH(this HCDFNGMMBJI EGGDEECAALI, float GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2331CA0", Offset = "0x23304A0", VA = "0x182331CA0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DCLENNNAMEJ(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2332750", Offset = "0x2330F50", VA = "0x182332750")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> FKHDJNACEDM(this HCDFNGMMBJI EGGDEECAALI, int GJAJAHIEACP, int MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2332160", Offset = "0x2330960", VA = "0x182332160")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> EADOCLCDBGA(this HCDFNGMMBJI EGGDEECAALI, int GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2335D30", Offset = "0x2334530", VA = "0x182335D30")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PJMAPNFEOPJ(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2334490", Offset = "0x2332C90", VA = "0x182334490")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> LAFBFBDPDGH(this HCDFNGMMBJI EGGDEECAALI, float GJAJAHIEACP, float MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2335320", Offset = "0x2333B20", VA = "0x182335320")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> OJFABLKPHAB(this HCDFNGMMBJI EGGDEECAALI, float GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2331730", Offset = "0x232FF30", VA = "0x182331730")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> BEAIDLMLAIC(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x23311D0", Offset = "0x232F9D0", VA = "0x1823311D0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> AGCIIANKHLF(this HCDFNGMMBJI EGGDEECAALI, int GJAJAHIEACP, int MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2332C50", Offset = "0x2331450", VA = "0x182332C50")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> HBGNDFONHHC(this HCDFNGMMBJI EGGDEECAALI, int GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2331DE0", Offset = "0x23305E0", VA = "0x182331DE0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DDLFLLAPHEJ(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x23362E0", Offset = "0x2334AE0", VA = "0x1823362E0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PPEHDMOCADO(this HCDFNGMMBJI EGGDEECAALI, float GJAJAHIEACP, float MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2336260", Offset = "0x2334A60", VA = "0x182336260")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PPDGDHCJEBL(this HCDFNGMMBJI EGGDEECAALI, float GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2334410", Offset = "0x2332C10", VA = "0x182334410")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> LACLDOJFILN(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2333B10", Offset = "0x2332310", VA = "0x182333B10")]
	public static MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> JPGIHJDJJBF(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> AMGMIEKCCLJ)
	{
		return default(MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2333DC0", Offset = "0x23325C0", VA = "0x182333DC0")]
	public static MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> KCJMJCBNLME(this HCDFNGMMBJI EGGDEECAALI, int INDENPJBLHO)
	{
		return default(MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2331250", Offset = "0x232FA50", VA = "0x182331250")]
	public static MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> AIIEEGFMBJH(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> INDENPJBLHO)
	{
		return default(MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2333740", Offset = "0x2331F40", VA = "0x182333740")]
	public static MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> IODADHANALD(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> AMGMIEKCCLJ)
	{
		return default(MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2333270", Offset = "0x2331A70", VA = "0x182333270")]
	public static MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> IFLOIHGDGKC(this HCDFNGMMBJI EGGDEECAALI, int INDENPJBLHO)
	{
		return default(MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2331E60", Offset = "0x2330660", VA = "0x182331E60")]
	public static MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> DEGJPNLGKEN(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> INDENPJBLHO)
	{
		return default(MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x23312F0", Offset = "0x232FAF0", VA = "0x1823312F0")]
	public static (MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF>, MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>) BDOHCHFKPBA(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<DJJPJBENBNJ> FJAJMHOLHFF, [In] ReadOnlySpan<MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>> HMHCPBFEMAJ, [In] ReadOnlySpan<int?> COHCMNNFEAF, [In] Span<MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>> DEOPIOKCFMG)
	{
		return default((MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF>, MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x23353A0", Offset = "0x2333BA0", VA = "0x1823353A0")]
	public static (MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF>, MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>) OKPBCCOJJPC(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<FOJBJPEMMFH> AJKAOLMPNNC, [In] ReadOnlySpan<MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>> HMHCPBFEMAJ, [In] ReadOnlySpan<int?> COHCMNNFEAF, [In] Span<MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>> DEOPIOKCFMG)
	{
		return default((MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF>, MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3088E70", Offset = "0x3087670", VA = "0x183088E70")]
	public static (MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>, MFKBDIPIOIA<LJPMKJJEGFC<PIOEAILIPCP>>, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>>, MFKBDIPIOIA<LJPMKJJEGFC<TMarker>>, MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF>) GOLKAJAEHEJ<TMarker>(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<PIOEAILIPCP> FDNLAFHKMMJ, [In] ReadOnlySpan<byte> EBNFOODJNOB)
	{
		return default((MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>, MFKBDIPIOIA<LJPMKJJEGFC<PIOEAILIPCP>>, MFKBDIPIOIA<LJPMKJJEGFC<KFKNANNGHKM>>, MFKBDIPIOIA<LJPMKJJEGFC<TMarker>>, MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x23332F0", Offset = "0x2331AF0", VA = "0x1823332F0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> IIFGPCBMIBO(this HCDFNGMMBJI EGGDEECAALI, int DEIGANFGLCI, [Optional] MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>? MLDMOMHJIHG)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2335B40", Offset = "0x2334340", VA = "0x182335B40")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PIKKFICHFOK(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DEIGANFGLCI, [Optional] MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>? MLDMOMHJIHG)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2334C90", Offset = "0x2333490", VA = "0x182334C90")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MKOAIFNJCFN(this HCDFNGMMBJI EGGDEECAALI, [In] ReadOnlySpan<byte> DEIGANFGLCI, [Optional] MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>? MLDMOMHJIHG)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2334950", Offset = "0x2333150", VA = "0x182334950")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> LDHFIAPCGPH(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DEIGANFGLCI, int BOOADEANLJB, [Optional] MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>? MLDMOMHJIHG)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x23327D0", Offset = "0x2330FD0", VA = "0x1823327D0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> GCOIFFLKIFA(this HCDFNGMMBJI EGGDEECAALI, float MJJFEOILBKP, float PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2333620", Offset = "0x2331E20", VA = "0x182333620")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> INDJGGLIELA(this HCDFNGMMBJI EGGDEECAALI, float MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2333130", Offset = "0x2331930", VA = "0x182333130")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> IAKFMKBLNLB(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2332F10", Offset = "0x2331710", VA = "0x182332F10")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> HKBAPKFJEKN(this HCDFNGMMBJI EGGDEECAALI, int MJJFEOILBKP, int PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2331F00", Offset = "0x2330700", VA = "0x182331F00")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DLLABAKPALA(this HCDFNGMMBJI EGGDEECAALI, int MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x23350C0", Offset = "0x23338C0", VA = "0x1823350C0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> OHBPEFCJHKJ(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2334150", Offset = "0x2332950", VA = "0x182334150")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> KOFIOMOKDGC(this HCDFNGMMBJI EGGDEECAALI, int GJAJAHIEACP, int MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2333E40", Offset = "0x2332640", VA = "0x182333E40")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> KDIAODDIKOA(this HCDFNGMMBJI EGGDEECAALI, int GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2333EC0", Offset = "0x23326C0", VA = "0x182333EC0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> KEIKDJLOKHO(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> GJAJAHIEACP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MCEIDNFODED)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2333F40", Offset = "0x2332740", VA = "0x182333F40")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> KIPEALIKCKM(this HCDFNGMMBJI EGGDEECAALI, float MJJFEOILBKP, float PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2332300", Offset = "0x2330B00", VA = "0x182332300")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> EHBLPMKJCHE(this HCDFNGMMBJI EGGDEECAALI, float MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x23328D0", Offset = "0x23310D0", VA = "0x1823328D0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> GGNAHGJGKIK(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2332B50", Offset = "0x2331350", VA = "0x182332B50")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> GOCHEOBJONB(this HCDFNGMMBJI EGGDEECAALI, int MJJFEOILBKP, int PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2331A30", Offset = "0x2330230", VA = "0x182331A30")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> CEKCLNMHMGG(this HCDFNGMMBJI EGGDEECAALI, int MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x23358E0", Offset = "0x23340E0", VA = "0x1823358E0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> OPFNFGJAIJO(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2334510", Offset = "0x2332D10", VA = "0x182334510")]
	public static MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>> LBEJBBCIFKK(this HCDFNGMMBJI EGGDEECAALI)
	{
		return default(MFKBDIPIOIA<LJPMKJJEGFC<LJPMKJJEGFC<NCLCOCGMICJ>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x23357E0", Offset = "0x2333FE0", VA = "0x1823357E0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> ONJGGOEKKFK(this HCDFNGMMBJI EGGDEECAALI, float MJJFEOILBKP, float PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2335200", Offset = "0x2333A00", VA = "0x182335200")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> OHOCHCKABKJ(this HCDFNGMMBJI EGGDEECAALI, float MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x23318F0", Offset = "0x23300F0", VA = "0x1823318F0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> BPOPBDHBDNI(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2333A10", Offset = "0x2332210", VA = "0x182333A10")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> JCKEHNIJJPP(this HCDFNGMMBJI EGGDEECAALI, int MJJFEOILBKP, int PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x23321E0", Offset = "0x23309E0", VA = "0x1823321E0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> EBENGHHBOCD(this HCDFNGMMBJI EGGDEECAALI, int MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2332020", Offset = "0x2330820", VA = "0x182332020")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DMIJACDOBDL(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x23341D0", Offset = "0x23329D0", VA = "0x1823341D0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> KPANDFKHKLA(this HCDFNGMMBJI EGGDEECAALI, int INDENPJBLHO)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2334040", Offset = "0x2332840", VA = "0x182334040")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> KMJPIKOFFPO(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> INDENPJBLHO)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2331B50", Offset = "0x2330350", VA = "0x182331B50")]
	public static void CMLNEAMDFOE(this HCDFNGMMBJI EGGDEECAALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2334A70", Offset = "0x2333270", VA = "0x182334A70")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MGPJEPCEAHL(this HCDFNGMMBJI EGGDEECAALI, float MJJFEOILBKP, float PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2332430", Offset = "0x2330C30", VA = "0x182332430")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> EHOHJCGJIHG(this HCDFNGMMBJI EGGDEECAALI, float MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2332CD0", Offset = "0x23314D0", VA = "0x182332CD0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> HCIPONEDDOF(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2334E80", Offset = "0x2333680", VA = "0x182334E80")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> NKGNFONKDDP(this HCDFNGMMBJI EGGDEECAALI, int MJJFEOILBKP, int PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2333010", Offset = "0x2331810", VA = "0x182333010")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> HKFPPHONHNI(this HCDFNGMMBJI EGGDEECAALI, int MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x23333B0", Offset = "0x2331BB0", VA = "0x1823333B0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> IJOHMINKGBP(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2335DB0", Offset = "0x23345B0", VA = "0x182335DB0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PMOKCNMLPJC(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> EPJMGCMDCNG, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> LGCMDCOGCFJ)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2334D80", Offset = "0x2333580", VA = "0x182334D80")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> NDFHJMAEJKB(this HCDFNGMMBJI EGGDEECAALI, int MJJFEOILBKP, int PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x23338F0", Offset = "0x23320F0", VA = "0x1823338F0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> JAIBOKBIOOP(this HCDFNGMMBJI EGGDEECAALI, int MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2331B60", Offset = "0x2330360", VA = "0x182331B60")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DACFGELMAOG(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MJJFEOILBKP, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> PEFEKOMBFHC)
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3089DB0", Offset = "0x30885B0", VA = "0x183089DB0")]
	public static void NGLFMMFINPK<TDeps, TState>(this HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TState LCFHGACCKAF, MFKBDIPIOIA<DJJPJBENBNJ> FJAJMHOLHFF, [In] ReadOnlySpan<MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>> HDLEEHJOBMG, [In] ReadOnlySpan<int?> COHCMNNFEAF, [In] Span<MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>> DEOPIOKCFMG, [In] Span<MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>> ADFAOHOCKOP, [In] ReadOnlySpan<MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>?> BFAGIOJKPEO) where TDeps : notnull, CLLLJIAFLNB<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3087680", Offset = "0x3085E80", VA = "0x183087680")]
	public static void BHKJIPFBDCF<TDeps, TState>(this HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TState LCFHGACCKAF, MFKBDIPIOIA<FOJBJPEMMFH> GOODBCHHJFH, [In] ReadOnlySpan<MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>> EMBBBOHADCA, [In] ReadOnlySpan<int?> COHCMNNFEAF, [In] Span<MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>> DEOPIOKCFMG, [In] Span<MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>> ADFAOHOCKOP, [In] ReadOnlySpan<MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>?> BFAGIOJKPEO) where TDeps : notnull, CLLLJIAFLNB<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3089BD0", Offset = "0x30883D0", VA = "0x183089BD0")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> MBFKIAGGIJL<TDeps, TState>(this HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TState LCFHGACCKAF, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DGPEKJOONMO, [Optional] MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>? MLDMOMHJIHG) where TDeps : notnull, CLLLJIAFLNB<TState> where TState : notnull
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3087C20", Offset = "0x3086420", VA = "0x183087C20")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> EILGBAGLHGB<TDeps, TState>(this HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TState LCFHGACCKAF, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> OIOBLMOILDG, [Optional] MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>? MLDMOMHJIHG) where TDeps : notnull, CLLLJIAFLNB<TState> where TState : notnull
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3088AD0", Offset = "0x30872D0", VA = "0x183088AD0")]
	public static MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> FIBLPGLPMPG<TDeps, TStateSys>(this HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TStateSys GCFIOFGBHJJ) where TDeps : notnull, CLLLJIAFLNB<TStateSys> where TStateSys : notnull
	{
		return default(MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x30899C0", Offset = "0x30881C0", VA = "0x1830899C0")]
	public static MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ> JICEBCJNLPN<TDeps, TStateSys>(this HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TStateSys GCFIOFGBHJJ) where TDeps : notnull, CLLLJIAFLNB<TStateSys> where TStateSys : notnull
	{
		return default(MFKBDIPIOIA<OGIPGLMKBDK.OHIKFGDMIEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2336130", Offset = "0x2334930", VA = "0x182336130")]
	public static MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> POOOJBHOEJO(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> GJEJMAHDBMO, IntPtr IAIPPPAOFPN, IntPtr GMAJGAPGLAJ)
	{
		return default(MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2334530", Offset = "0x2332D30", VA = "0x182334530")]
	public static MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> LCIEFNFDCJG(this HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> GDIBIOPPFCE, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> CEBDNMIOOLP, IntPtr NKCFNIDMEJN, IntPtr GALNMPFBHHE, IntPtr KLOGAHJABCC, bool IEGOAANNAKL)
	{
		return default(MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x30883A0", Offset = "0x3086BA0", VA = "0x1830883A0")]
	public static MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> FEBKMJJGPMM<TDeps, TState>(this HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TState LCFHGACCKAF, MFKBDIPIOIA<DJJPJBENBNJ> FHHOHIMFNDH, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> GDIBIOPPFCE, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> CEBDNMIOOLP, int? HEHGAJAJFNO, [Optional] IntPtr CCKBJJIPFBM) where TDeps : notnull, CLLLJIAFLNB<TState> where TState : notnull
	{
		return default(MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3088080", Offset = "0x3086880", VA = "0x183088080")]
	private static MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> FEBKMJJGPMM<TDeps, TState>(this HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TState LCFHGACCKAF, MFKBDIPIOIA<DJJPJBENBNJ> FHHOHIMFNDH, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> GDIBIOPPFCE, MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB> CEBDNMIOOLP, int? HEHGAJAJFNO) where TDeps : notnull, CLLLJIAFLNB<TState> where TState : notnull
	{
		return default(MFKBDIPIOIA<APCPAIOKILN.EBBBJHHGFDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3088F70", Offset = "0x3087770", VA = "0x183088F70")]
	public static MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> HEDCJLCEDPM<TDeps, TState>(this HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TState LCFHGACCKAF, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DEIGANFGLCI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>? MLDMOMHJIHG) where TDeps : notnull, CLLLJIAFLNB<TState> where TState : notnull
	{
		return default(MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x30873F0", Offset = "0x3085BF0", VA = "0x1830873F0")]
	public static void BCDALAKCCGK<TDeps, TState>(this HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TState LCFHGACCKAF, int CPOFGLLJMNK) where TDeps : notnull, CLLLJIAFLNB<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct KKFJIPHHOHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> AMOIKKPLMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> CEOENICOFDG;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x95D280", Offset = "0x95BA80", VA = "0x18095D280")]
	public KKFJIPHHOHJ(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> BOFILIKDNEO, MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> AOEPFEAJEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2336B30", Offset = "0x2335330", VA = "0x182336B30")]
	public static KKFJIPHHOHJ DFLBOLBHLFN(MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>> BOFILIKDNEO)
	{
		return default(KKFJIPHHOHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct NHNFOLHNIOL
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class AENAHOAPBNC : NMOOJNAKNMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct ICFMHNHMLLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF> GHODDJHOJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int MBLPHBBBBKP;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x95D280", Offset = "0x95BA80", VA = "0x18095D280")]
		public ICFMHNHMLLH(MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF> IJHOOCFLCJF, int ECDOOAABOPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class JEDMCPJFCIL : NMOOJNAKNMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct DJLOIEBMMOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int MBLPHBBBBKP;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690")]
		public DJLOIEBMMOM(int ECDOOAABOPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class PBIHIPOCABH : NMOOJNAKNMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct ACELNIOOEGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF> GHODDJHOJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int MBLPHBBBBKP;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x95D280", Offset = "0x95BA80", VA = "0x18095D280")]
		public ACELNIOOEGM(MFKBDIPIOIA<INBJCKAHEJL.FBEFKOPAOKF> IJHOOCFLCJF, int ECDOOAABOPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum PLKCGINFHEA
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
	public sealed class MELCENHIBIE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class NMOOJNAKNMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct PJAFMGHGMEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? CGCJOPMAIHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public KKFJIPHHOHJ MLBNAFNMFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public PLKCGINFHEA COJDFBLAMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public MFKBDIPIOIA<NMOOJNAKNMJ> BIIKDDJEJAG;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2338000", Offset = "0x2336800", VA = "0x182338000")]
		public PJAFMGHGMEG(int? FLDEIPDLDDG, [In] KKFJIPHHOHJ OIIJPCGALBK, PLKCGINFHEA NBKJLJKCNBN, MFKBDIPIOIA<NMOOJNAKNMJ> BJMJJANHLNF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class NPBKBCCHELG : NMOOJNAKNMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct MJLOAOKLOIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int MBLPHBBBBKP;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690")]
		public MJLOAOKLOIL(int ECDOOAABOPD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal JIGFCFLNADF<MELCENHIBIE, PJAFMGHGMEG> AENLLDLLBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal JIGFCFLNADF<AENAHOAPBNC, ICFMHNHMLLH> NOLLFPBCCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal JIGFCFLNADF<PBIHIPOCABH, ACELNIOOEGM> FNMIDBLAPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal JIGFCFLNADF<NPBKBCCHELG, MJLOAOKLOIL> GNONLOLMKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal JIGFCFLNADF<JEDMCPJFCIL, DJLOIEBMMOM> JEJLPCHOBOI;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2337730", Offset = "0x2335F30", VA = "0x182337730")]
	private NHNFOLHNIOL([In] JIGFCFLNADF<MELCENHIBIE, PJAFMGHGMEG> FLJKOENEEKD, [In] JIGFCFLNADF<AENAHOAPBNC, ICFMHNHMLLH> IBGFMJDDPJP, [In] JIGFCFLNADF<PBIHIPOCABH, ACELNIOOEGM> DPJPDIDMDHC, [In] JIGFCFLNADF<NPBKBCCHELG, MJLOAOKLOIL> LFHPGJKLDCK, [In] JIGFCFLNADF<JEDMCPJFCIL, DJLOIEBMMOM> ADCDJFHCPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2337540", Offset = "0x2335D40", VA = "0x182337540")]
	public static NHNFOLHNIOL DFLBOLBHLFN()
	{
		return default(NHNFOLHNIOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class FJLCOEAIEDM
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2330030", Offset = "0x232E830", VA = "0x182330030")]
	public static void ANFLKJPBFFP(this NHNFOLHNIOL EGGDEECAALI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class DAJPGEEBFMO
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x232FAD0", Offset = "0x232E2D0", VA = "0x18232FAD0")]
	public static void BDBMLJNBAHE(HCDFNGMMBJI EGGDEECAALI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct LPPOFCGDIDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, IEJJLMGDMMM> JGCDBCDKOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int BBFDNNLPIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int LGNPJABDNJD;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2337320", Offset = "0x2335B20", VA = "0x182337320")]
	private LPPOFCGDIDN([In] JPBBBEKNEPH<INBJCKAHEJL.GIFCHBOBMFN, IEJJLMGDMMM> BBKAIFKBCHC, int OKEIFPKOADD, int MJCGMBHLIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x23372B0", Offset = "0x2335AB0", VA = "0x1823372B0")]
	public static LPPOFCGDIDN DFLBOLBHLFN()
	{
		return default(LPPOFCGDIDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x23370C0", Offset = "0x23358C0", VA = "0x1823370C0")]
	public void ANFLKJPBFFP([In] HCDFNGMMBJI IEOHBKBLMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x311A090", Offset = "0x3118890", VA = "0x18311A090")]
	public static void BDBMLJNBAHE<TDeps, TStateSys>(HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TStateSys GCFIOFGBHJJ, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK) where TDeps : notnull, CLLLJIAFLNB<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class PPFHPMHOIFM
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2338020", Offset = "0x2336820", VA = "0x182338020")]
	public static void BDBMLJNBAHE(HCDFNGMMBJI EGGDEECAALI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct ENAHCALHFJK
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface MICDCMCCJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ANEOICMBEFC(BKFEAGFNBCE<byte> PAJJGGNCNPE, int NMIJPGNGEBC);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct KMKGGFAMDGF : MICDCMCCJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2336BF0", Offset = "0x23353F0", VA = "0x182336BF0", Slot = "4")]
		public void ANEOICMBEFC(BKFEAGFNBCE<byte> PAJJGGNCNPE, int NMIJPGNGEBC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct KMIAKHDGCCH : MICDCMCCJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2336B40", Offset = "0x2335340", VA = "0x182336B40", Slot = "4")]
		public void ANEOICMBEFC(BKFEAGFNBCE<byte> PAJJGGNCNPE, int NMIJPGNGEBC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct NLOPCDAPHDB : MICDCMCCJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2337860", Offset = "0x2336060", VA = "0x182337860", Slot = "4")]
		public void ANEOICMBEFC(BKFEAGFNBCE<byte> PAJJGGNCNPE, int NMIJPGNGEBC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct MBHKIMNPHGG : MICDCMCCJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2337360", Offset = "0x2335B60", VA = "0x182337360", Slot = "4")]
		public void ANEOICMBEFC(BKFEAGFNBCE<byte> PAJJGGNCNPE, int NMIJPGNGEBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class HBEFGHBGJIK<TCallProcessorDeps> where TCallProcessorDeps : struct, MICDCMCCJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps NNDMPDFKOOK;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x313F8D0", Offset = "0x313E0D0", VA = "0x18313F8D0")]
		public static int BDBMLJNBAHE<TDeps, TStateSys>(TDeps HNBDHJIILED, TStateSys LCFHGACCKAF, HCDFNGMMBJI IEOHBKBLMAA, [In] BKFEAGFNBCE<byte> ADHGBBNEAFD, int EMLJNNNJHLC) where TDeps : CLLLJIAFLNB<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private BKFEAGFNBCE<ILNIJBJKIOJ> KMDANJPOCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>, MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>> GDOCOOFFPFC;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x232FFF0", Offset = "0x232E7F0", VA = "0x18232FFF0")]
	private ENAHCALHFJK([In] BKFEAGFNBCE<ILNIJBJKIOJ> BKJBECOLFDH, Dictionary<MFKBDIPIOIA<LJPMKJJEGFC<NCLCOCGMICJ>>, MFKBDIPIOIA<INBJCKAHEJL.GIFCHBOBMFN>> FMBFEGBAEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x232FF30", Offset = "0x232E730", VA = "0x18232FF30")]
	public static ENAHCALHFJK DFLBOLBHLFN()
	{
		return default(ENAHCALHFJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x232FEF0", Offset = "0x232E6F0", VA = "0x18232FEF0")]
	public void ANFLKJPBFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2ED1590", Offset = "0x2ECFD90", VA = "0x182ED1590")]
	public static void BDBMLJNBAHE<TDeps, TStateSys>(HCDFNGMMBJI EGGDEECAALI, TDeps HNBDHJIILED, TStateSys GCFIOFGBHJJ) where TDeps : CLLLJIAFLNB<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class AKOGKIEAEGC
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct NIBGOKBGHCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> NBCBDJODLBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int NABJECDFCFP;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int OCODDKLLHMB;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int OGKJGBCMAOJ;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x232C590", Offset = "0x232AD90", VA = "0x18232C590")]
	public static void BDBMLJNBAHE(HCDFNGMMBJI EGGDEECAALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x232CEC0", Offset = "0x232B6C0", VA = "0x18232CEC0")]
	private static void LJHKMLPGKFC([In] HCDFNGMMBJI EGGDEECAALI, MFKBDIPIOIA<NHNFOLHNIOL.MELCENHIBIE> DOBPKLNCBDO, BKFEAGFNBCE<byte> CPIOLEGBLCO, List<NIBGOKBGHCH> LFKONLOPNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x232CD80", Offset = "0x232B580", VA = "0x18232CD80")]
	private static void LJHKMLPGKFC(BKFEAGFNBCE<byte> CPIOLEGBLCO, int BOOADEANLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x232CC50", Offset = "0x232B450", VA = "0x18232CC50")]
	private static void IMOPHGGMHFE(HCDFNGMMBJI EGGDEECAALI, List<NIBGOKBGHCH> LFKONLOPNGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class LOJIPKJMPLP<TDeps, TIndex, TValues> where TDeps : struct, LPIMFCHKGDH<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps NNDMPDFKOOK;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x475E110", Offset = "0x475C910", VA = "0x18475E110")]
	public static void BDBMLJNBAHE([In] BKFEAGFNBCE<ILNIJBJKIOJ> BKJBECOLFDH, int MEIKGPEMKHJ, TValues MCAFGDLBCDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface LPIMFCHKGDH<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BKFEAGFNBCE<TIndex> JLBIMCPDHLL(int MEIKGPEMKHJ, [In] TValues MCAFGDLBCDD);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FMHFBPIEKJD(TIndex ECDOOAABOPD, [In] TValues MCAFGDLBCDD);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNDCHNCHNGI(TIndex ECDOOAABOPD, TValues MCAFGDLBCDD, MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> INDENPJBLHO);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface EHKICPBOJMA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex OMKMCDEHOHK(int ECDOOAABOPD);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CCMPOGCBKLF(TIndex ECDOOAABOPD, [In] TValues MCAFGDLBCDD);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MFKBDIPIOIA<LJPMKJJEGFC<LNCIJMKJPCJ>> FMHFBPIEKJD(TIndex ECDOOAABOPD, [In] TValues MCAFGDLBCDD);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class OGIHENKBCEM<TDeps, TIndex, TValues> where TDeps : struct, EHKICPBOJMA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps NNDMPDFKOOK;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4B53330", Offset = "0x4B51B30", VA = "0x184B53330")]
	public static BKFEAGFNBCE<TIndex> BDBMLJNBAHE(int MEIKGPEMKHJ, [In] TValues MCAFGDLBCDD)
	{
		return default(BKFEAGFNBCE<TIndex>);
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
