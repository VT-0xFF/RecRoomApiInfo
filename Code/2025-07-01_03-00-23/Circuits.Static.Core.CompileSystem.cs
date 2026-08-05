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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x299CD80", Offset = "0x299B380", VA = "0x18299CD80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct LGFCDCGFEOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> JIEIDNKDIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int FKCGNHACNBO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xDF17C0", Offset = "0xDEFDC0", VA = "0x180DF17C0")]
	public LGFCDCGFEOM(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> EOBFMLKCLJL, int MOBKDJHFHDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GLLAINDDAJG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class EPOIHDMOKGG : GBFLGBMGIKH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct JAAOIDKDOPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly EKFIFFNHCIJ<byte> CJCOMMBGCCA;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x292D4C0", Offset = "0x292BAC0", VA = "0x18292D4C0")]
		public JAAOIDKDOPM(EKFIFFNHCIJ<byte> IHNKIKDOAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x299BBC0", Offset = "0x299A1C0", VA = "0x18299BBC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class IPAIJHIHEMF : GBFLGBMGIKH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct NIHAALBGOLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> LDAKFMCKODN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0")]
		public NIHAALBGOLG(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> LCIBFPHPLLJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum OHICKGFOLEE
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
	public sealed class OLOCEEDIFBO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class GBFLGBMGIKH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct HILJBLBLPLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly OHICKGFOLEE GBNPFJMLGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly LLDGDOINCKI<GBFLGBMGIKH> LMIKGBEHPFJ;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDF17C0", Offset = "0xDEFDC0", VA = "0x180DF17C0")]
		public HILJBLBLPLL(OHICKGFOLEE AFAFNGGHEPI, LLDGDOINCKI<GBFLGBMGIKH> PFOANGGOFFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class AAMIGHEBPDO : GBFLGBMGIKH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct GNCDBHHADFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> DEADPIHDOGO;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0")]
		public GNCDBHHADFI(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> GFJJOALOGFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class LJBGBPPEMPM : GBFLGBMGIKH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct ODGMEEAOLMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly EBGDFHFKLDP LBPMGAAACKJ;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0")]
		public ODGMEEAOLMO(EBGDFHFKLDP ONICHHHKABH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x299CE40", Offset = "0x299B440", VA = "0x18299CE40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal GDKKCNKIDNF<OLOCEEDIFBO, HILJBLBLPLL> NFCHEDOICKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal GDKKCNKIDNF<EPOIHDMOKGG, JAAOIDKDOPM> KNIMFFEIGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal GDKKCNKIDNF<IPAIJHIHEMF, NIHAALBGOLG> KBJLKMFNLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal GDKKCNKIDNF<AAMIGHEBPDO, GNCDBHHADFI> KIOOEGOKIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal GDKKCNKIDNF<LJBGBPPEMPM, ODGMEEAOLMO> IHEJMAFHADG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2998670", Offset = "0x2996C70", VA = "0x182998670")]
	private GLLAINDDAJG([In] GDKKCNKIDNF<OLOCEEDIFBO, HILJBLBLPLL> HCJLKANGAGJ, [In] GDKKCNKIDNF<EPOIHDMOKGG, JAAOIDKDOPM> MJOOGPDCHEH, [In] GDKKCNKIDNF<IPAIJHIHEMF, NIHAALBGOLG> DFIPKLHALHB, [In] GDKKCNKIDNF<AAMIGHEBPDO, GNCDBHHADFI> LHDNKNIJFAN, [In] GDKKCNKIDNF<LJBGBPPEMPM, ODGMEEAOLMO> IAEJODMJFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2998530", Offset = "0x2996B30", VA = "0x182998530")]
	public static GLLAINDDAJG BFOPDLPDKBM()
	{
		return default(GLLAINDDAJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EGOHCPIDOCD
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2997720", Offset = "0x2995D20", VA = "0x182997720")]
	public static void BNBAOKNGOBL(this GLLAINDDAJG PIKMBNLEPPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum FAGNDGPNKIK
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
public struct LJDGNFKNFFC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class CKCGHONKMIF : ABANDJGBOGM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct BDDECKLKDEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> GFCDCDENCBL;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0")]
		public BDDECKLKDEM(LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> HEEKIOMLFBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum BGPGJBJODLF
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
	public sealed class ACMADCMCMHF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class ABANDJGBOGM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct KGOPOPAKKIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly BGPGJBJODLF GBNPFJMLGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly LLDGDOINCKI<ABANDJGBOGM> LMIKGBEHPFJ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDF17C0", Offset = "0xDEFDC0", VA = "0x180DF17C0")]
		public KGOPOPAKKIB(BGPGJBJODLF AFAFNGGHEPI, LLDGDOINCKI<ABANDJGBOGM> PFOANGGOFFG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal GDKKCNKIDNF<ACMADCMCMHF, KGOPOPAKKIB> NFCHEDOICKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal GDKKCNKIDNF<CKCGHONKMIF, BDDECKLKDEM> ODDHKCNHIFI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x299B9B0", Offset = "0x2999FB0", VA = "0x18299B9B0")]
	private LJDGNFKNFFC([In] GDKKCNKIDNF<ACMADCMCMHF, KGOPOPAKKIB> HCJLKANGAGJ, [In] GDKKCNKIDNF<CKCGHONKMIF, BDDECKLKDEM> CCOJKCDOGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x299C290", Offset = "0x299A890", VA = "0x18299C290")]
	public static LJDGNFKNFFC BFOPDLPDKBM()
	{
		return default(LJDGNFKNFFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LDFLNDKHONK
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x299C230", Offset = "0x299A830", VA = "0x18299C230")]
	public static void BNBAOKNGOBL(this LJDGNFKNFFC PIKMBNLEPPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct AEDCEMOPNGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public OCPMFOPNDFK<int> DEDINJEPBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public OCPMFOPNDFK<int> OJCIDPNCOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int DILNNFDHMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int DODKJGNBHEO;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2991C80", Offset = "0x2990280", VA = "0x182991C80")]
	private AEDCEMOPNGF([In] OCPMFOPNDFK<int> DJCPJOMHCIA, [In] OCPMFOPNDFK<int> PHMPFKAMDLD, int LNCHDHHPIND, int KHOKHCPNJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2991BE0", Offset = "0x29901E0", VA = "0x182991BE0")]
	public static AEDCEMOPNGF BFOPDLPDKBM()
	{
		return default(AEDCEMOPNGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class EJLFLNDOPPB
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x29984E0", Offset = "0x2996AE0", VA = "0x1829984E0")]
	public static void BNBAOKNGOBL(this AEDCEMOPNGF PIKMBNLEPPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct PBGOFMAFOLL
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum BIHNONANBHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class KLKIFDAPBIG : DIAODGAAIEI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct BNOANFDNODN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly LLDGDOINCKI<INDMDEFHBBO> GIKCKPMPNFE;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0")]
		public BNOANFDNODN(LLDGDOINCKI<INDMDEFHBBO> LOMFGPMLHKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class AICJIILPPGK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class DIAODGAAIEI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct BKHNOCOPELD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly BIHNONANBHE GBNPFJMLGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly LLDGDOINCKI<DIAODGAAIEI> LMIKGBEHPFJ;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xDF17C0", Offset = "0xDEFDC0", VA = "0x180DF17C0")]
		private BKHNOCOPELD(BIHNONANBHE AFAFNGGHEPI, LLDGDOINCKI<DIAODGAAIEI> PFOANGGOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2997260", Offset = "0x2995860", VA = "0x182997260")]
		public static BKHNOCOPELD BFOPDLPDKBM(BIHNONANBHE AFAFNGGHEPI, LLDGDOINCKI<DIAODGAAIEI> PFOANGGOFFG)
		{
			return default(BKHNOCOPELD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class IIKKHKMENCJ : DIAODGAAIEI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct CLNJJIJMJJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly LLDGDOINCKI<INDMDEFHBBO> GIKCKPMPNFE;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0")]
		public CLNJJIJMJJH(LLDGDOINCKI<INDMDEFHBBO> LOMFGPMLHKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class INDMDEFHBBO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct HPKJCNKHABH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public OCPMFOPNDFK<LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>> OBLEDDMIDCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public OCPMFOPNDFK<LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>> CPGHOILDALL;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x299B9B0", Offset = "0x2999FB0", VA = "0x18299B9B0")]
		private HPKJCNKHABH([In] OCPMFOPNDFK<LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>> PAABDOHHHNL, [In] OCPMFOPNDFK<LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>> DOFODFDPJKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x299B930", Offset = "0x2999F30", VA = "0x18299B930")]
		public static HPKJCNKHABH BFOPDLPDKBM()
		{
			return default(HPKJCNKHABH);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal GDKKCNKIDNF<AICJIILPPGK, BKHNOCOPELD> NFCHEDOICKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal GDKKCNKIDNF<IIKKHKMENCJ, CLNJJIJMJJH> AHBGAHJFCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal GDKKCNKIDNF<KLKIFDAPBIG, BNOANFDNODN> LDENLBIOMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal OCPMFOPNDFK<(LLDGDOINCKI<AICJIILPPGK> CallId, LLDGDOINCKI<INDMDEFHBBO> IOId)> OJBCNDJGPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal GDKKCNKIDNF<INDMDEFHBBO, HPKJCNKHABH> JEFNICILBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal NKNEHBBBKOO<INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>> OIJKNBAJFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal NKNEHBBBKOO<INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>>> LJOKKKMBNGD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x299D000", Offset = "0x299B600", VA = "0x18299D000")]
	private PBGOFMAFOLL([In] GDKKCNKIDNF<AICJIILPPGK, BKHNOCOPELD> HCJLKANGAGJ, [In] GDKKCNKIDNF<IIKKHKMENCJ, CLNJJIJMJJH> FHEKGOANBIM, [In] GDKKCNKIDNF<KLKIFDAPBIG, BNOANFDNODN> CIHMLNALHFE, [In] OCPMFOPNDFK<(LLDGDOINCKI<AICJIILPPGK> CallId, LLDGDOINCKI<INDMDEFHBBO> IOId)> HGFOFGHDHPG, [In] GDKKCNKIDNF<INDMDEFHBBO, HPKJCNKHABH> EDANGDDCALI, [In] NKNEHBBBKOO<INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>> LILLIEOEKAF, [In] NKNEHBBBKOO<INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>>> DEKJIMKDMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x299CE60", Offset = "0x299B460", VA = "0x18299CE60")]
	public static PBGOFMAFOLL BFOPDLPDKBM()
	{
		return default(PBGOFMAFOLL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class MEHBENFCALI
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x299C830", Offset = "0x299AE30", VA = "0x18299C830")]
	private static void BNBAOKNGOBL(this PBGOFMAFOLL.HPKJCNKHABH PIKMBNLEPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x299C880", Offset = "0x299AE80", VA = "0x18299C880")]
	public static void BNBAOKNGOBL(this PBGOFMAFOLL PIKMBNLEPPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct EGONJENNMKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public OCPMFOPNDFK<byte> LHCFIJKAEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal PBGOFMAFOLL IBGKOBOCHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal LPGBKPBMOGL JKIJEODHJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>> CBIKGMGECIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal GLLAINDDAJG INIMFHJICIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal LJDGNFKNFFC FNDDGBIPCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal NKNEHBBBKOO<PMIFBODKNMJ, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>?> LJFPJFKAJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal OCPMFOPNDFK<LLDGDOINCKI<PMIFBODKNMJ>> INBJANGJGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal NKNEHBBBKOO<KHPCHGHJGBM, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>?> ECEBOKNIEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal OCPMFOPNDFK<(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> VariableId, LLDGDOINCKI<KBPOILHCFGO<HDIBLNDCIIF<JALCCLPNJLE>>> ByteCodeWriteLocation)> AIBDGGOMJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> GLGFDGGEHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal CFFNNLHHCHP HCCBJLFOKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal PDAJBIEPFJL AGFBPBGGMAJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2998180", Offset = "0x2996780", VA = "0x182998180")]
	private EGONJENNMKO([In] OCPMFOPNDFK<byte> JCJAJMBCIPD, [In] PBGOFMAFOLL PDFDFDKBNMO, [In] LPGBKPBMOGL EJICEKLNDOE, [In] GLLAINDDAJG JKLMHCJMALL, [In] LJDGNFKNFFC OJDOHJCBEOP, [In] NKNEHBBBKOO<PMIFBODKNMJ, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>?> NECMJCDNPHL, [In] OCPMFOPNDFK<LLDGDOINCKI<PMIFBODKNMJ>> GCHIEIONFMH, [In] NKNEHBBBKOO<KHPCHGHJGBM, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>?> AHPGCPMJODK, [In] OCPMFOPNDFK<(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> VariableId, LLDGDOINCKI<KBPOILHCFGO<HDIBLNDCIIF<JALCCLPNJLE>>> ByteCodeWriteLocation)> HCGNEPJMGEB, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> EMIOMGNMILM, [In] CFFNNLHHCHP PHILEMEMIKC, [In] PDAJBIEPFJL BDBHBJGMOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29977D0", Offset = "0x2995DD0", VA = "0x1829977D0")]
	public static EGONJENNMKO BFOPDLPDKBM()
	{
		return default(EGONJENNMKO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class GONLBLIPDEF
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct JICOODHKLGN : NEJHKLGFECI<LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>, NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x299BCC0", Offset = "0x299A2C0", VA = "0x18299BCC0")]
		public LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> MIOAOFOCBIK(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> KHMHPNKMLMD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x299BD40", Offset = "0x299A340", VA = "0x18299BD40", Slot = "4")]
		public LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> OKIFKAJMGBM(int KHMHPNKMLMD)
		{
			return default(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0")]
		public bool GAGFCACOMON(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> KHMHPNKMLMD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>> NIJLHKNCLKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "5")]
		private bool FDLJANLGACN(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> KHMHPNKMLMD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>> NIJLHKNCLKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x299BCC0", Offset = "0x299A2C0", VA = "0x18299BCC0", Slot = "6")]
		private LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> IFPEACECBPK(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> KHMHPNKMLMD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct CBOELLHPNGA : LCIJGIFCJIJ<LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>, NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2997390", Offset = "0x2995990", VA = "0x182997390")]
		public OCPMFOPNDFK<LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>> LKEHOJEIBEK(int ONBCCEEOHCD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>> NIJLHKNCLKB)
		{
			return default(OCPMFOPNDFK<LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2997400", Offset = "0x2995A00", VA = "0x182997400")]
		public LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> MIOAOFOCBIK(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> KHMHPNKMLMD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2997300", Offset = "0x2995900", VA = "0x182997300", Slot = "6")]
		public void DIOMIEDNOGJ(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> KHMHPNKMLMD, NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>> NIJLHKNCLKB, LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2997390", Offset = "0x2995990", VA = "0x182997390", Slot = "4")]
		private OCPMFOPNDFK<LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>> KKKAFHOFILJ(int ONBCCEEOHCD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>> NIJLHKNCLKB)
		{
			return default(OCPMFOPNDFK<LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2997400", Offset = "0x2995A00", VA = "0x182997400", Slot = "5")]
		private LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> NNJNCJNAIGH(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> KHMHPNKMLMD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct LKIGLMKDOAG : NEJHKLGFECI<LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>, NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x299C320", Offset = "0x299A920", VA = "0x18299C320")]
		public LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> MIOAOFOCBIK(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> KHMHPNKMLMD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>>> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x299C3A0", Offset = "0x299A9A0", VA = "0x18299C3A0", Slot = "4")]
		public LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> OKIFKAJMGBM(int KHMHPNKMLMD)
		{
			return default(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0")]
		public bool GAGFCACOMON(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> KHMHPNKMLMD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>>> NIJLHKNCLKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "5")]
		private bool DOEPHOJMOAK(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> KHMHPNKMLMD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>>> NIJLHKNCLKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x299C320", Offset = "0x299A920", VA = "0x18299C320", Slot = "6")]
		private LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> CMLAGLEKGBF(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> KHMHPNKMLMD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>>> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct LBGCDKKJAPH : LCIJGIFCJIJ<LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>, NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x299C0B0", Offset = "0x299A6B0", VA = "0x18299C0B0")]
		public OCPMFOPNDFK<LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>> LKEHOJEIBEK(int ONBCCEEOHCD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>>> NIJLHKNCLKB)
		{
			return default(OCPMFOPNDFK<LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x299C1B0", Offset = "0x299A7B0", VA = "0x18299C1B0")]
		public LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> MIOAOFOCBIK(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> KHMHPNKMLMD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>>> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x299C120", Offset = "0x299A720", VA = "0x18299C120", Slot = "6")]
		public void DIOMIEDNOGJ(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> KHMHPNKMLMD, NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>>> NIJLHKNCLKB, LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x299C0B0", Offset = "0x299A6B0", VA = "0x18299C0B0", Slot = "4")]
		private OCPMFOPNDFK<LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>> AFNFCOKFLDN(int ONBCCEEOHCD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>>> NIJLHKNCLKB)
		{
			return default(OCPMFOPNDFK<LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x299C1B0", Offset = "0x299A7B0", VA = "0x18299C1B0", Slot = "5")]
		private LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> GPIGDIPDIML(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> KHMHPNKMLMD, [In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>>> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct MANLKOMIBPH : NEJHKLGFECI<LLDGDOINCKI<KHPCHGHJGBM>, NKNEHBBBKOO<KHPCHGHJGBM, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x299C760", Offset = "0x299AD60", VA = "0x18299C760")]
		public LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> MIOAOFOCBIK(LLDGDOINCKI<KHPCHGHJGBM> KHMHPNKMLMD, [In] NKNEHBBBKOO<KHPCHGHJGBM, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>?> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x299C800", Offset = "0x299AE00", VA = "0x18299C800", Slot = "4")]
		public LLDGDOINCKI<KHPCHGHJGBM> OKIFKAJMGBM(int KHMHPNKMLMD)
		{
			return default(LLDGDOINCKI<KHPCHGHJGBM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x299C700", Offset = "0x299AD00", VA = "0x18299C700")]
		public bool GAGFCACOMON(LLDGDOINCKI<KHPCHGHJGBM> KHMHPNKMLMD, [In] NKNEHBBBKOO<KHPCHGHJGBM, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>?> NIJLHKNCLKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x299C700", Offset = "0x299AD00", VA = "0x18299C700", Slot = "5")]
		private bool FPMFMLFLOLF(LLDGDOINCKI<KHPCHGHJGBM> KHMHPNKMLMD, [In] NKNEHBBBKOO<KHPCHGHJGBM, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>?> NIJLHKNCLKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x299C6F0", Offset = "0x299ACF0", VA = "0x18299C6F0", Slot = "6")]
		private LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> APNFPBFPJAP(LLDGDOINCKI<KHPCHGHJGBM> KHMHPNKMLMD, [In] NKNEHBBBKOO<KHPCHGHJGBM, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>?> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct MOHDBNKEPKE : LCIJGIFCJIJ<LLDGDOINCKI<KHPCHGHJGBM>, NKNEHBBBKOO<KHPCHGHJGBM, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x299CC70", Offset = "0x299B270", VA = "0x18299CC70")]
		public OCPMFOPNDFK<LLDGDOINCKI<KHPCHGHJGBM>> LKEHOJEIBEK(int ONBCCEEOHCD, [In] NKNEHBBBKOO<KHPCHGHJGBM, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>?> NIJLHKNCLKB)
		{
			return default(OCPMFOPNDFK<LLDGDOINCKI<KHPCHGHJGBM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x299CCE0", Offset = "0x299B2E0", VA = "0x18299CCE0")]
		public LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> MIOAOFOCBIK(LLDGDOINCKI<KHPCHGHJGBM> KHMHPNKMLMD, [In] NKNEHBBBKOO<KHPCHGHJGBM, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>?> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x299CBB0", Offset = "0x299B1B0", VA = "0x18299CBB0", Slot = "6")]
		public void DIOMIEDNOGJ(LLDGDOINCKI<KHPCHGHJGBM> KHMHPNKMLMD, NKNEHBBBKOO<KHPCHGHJGBM, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>?> NIJLHKNCLKB, LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x299CC70", Offset = "0x299B270", VA = "0x18299CC70", Slot = "4")]
		private OCPMFOPNDFK<LLDGDOINCKI<KHPCHGHJGBM>> OACAOMHCKGN(int ONBCCEEOHCD, [In] NKNEHBBBKOO<KHPCHGHJGBM, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>?> NIJLHKNCLKB)
		{
			return default(OCPMFOPNDFK<LLDGDOINCKI<KHPCHGHJGBM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x299CC60", Offset = "0x299B260", VA = "0x18299CC60", Slot = "5")]
		private LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> KCDCNEANDGL(LLDGDOINCKI<KHPCHGHJGBM> KHMHPNKMLMD, [In] NKNEHBBBKOO<KHPCHGHJGBM, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>?> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct JABHIDMLDAE : NEJHKLGFECI<int, OCPMFOPNDFK<(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>, LLDGDOINCKI<KBPOILHCFGO<HDIBLNDCIIF<JALCCLPNJLE>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x299BC40", Offset = "0x299A240", VA = "0x18299BC40")]
		public LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> MIOAOFOCBIK(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> VariableId, LLDGDOINCKI<KBPOILHCFGO<HDIBLNDCIIF<JALCCLPNJLE>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB148F0", Offset = "0xB12EF0", VA = "0x180B148F0", Slot = "4")]
		public int OKIFKAJMGBM(int KHMHPNKMLMD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0")]
		public bool GAGFCACOMON(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> VariableId, LLDGDOINCKI<KBPOILHCFGO<HDIBLNDCIIF<JALCCLPNJLE>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "5")]
		private bool KGEJMMMIKPC(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> VariableId, LLDGDOINCKI<KBPOILHCFGO<HDIBLNDCIIF<JALCCLPNJLE>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x299BC30", Offset = "0x299A230", VA = "0x18299BC30", Slot = "6")]
		private LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> FFENACONKBP(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> VariableId, LLDGDOINCKI<KBPOILHCFGO<HDIBLNDCIIF<JALCCLPNJLE>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct JLOKPDPIHDG : LCIJGIFCJIJ<int, OCPMFOPNDFK<(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>, LLDGDOINCKI<KBPOILHCFGO<HDIBLNDCIIF<JALCCLPNJLE>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x299BE60", Offset = "0x299A460", VA = "0x18299BE60")]
		public OCPMFOPNDFK<int> LKEHOJEIBEK(int ONBCCEEOHCD, [In] OCPMFOPNDFK<(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> VariableId, LLDGDOINCKI<KBPOILHCFGO<HDIBLNDCIIF<JALCCLPNJLE>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(OCPMFOPNDFK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x299BEE0", Offset = "0x299A4E0", VA = "0x18299BEE0")]
		public LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> MIOAOFOCBIK(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> VariableId, LLDGDOINCKI<KBPOILHCFGO<HDIBLNDCIIF<JALCCLPNJLE>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x299BD70", Offset = "0x299A370", VA = "0x18299BD70", Slot = "6")]
		public void DIOMIEDNOGJ(int KHMHPNKMLMD, OCPMFOPNDFK<(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> VariableId, LLDGDOINCKI<KBPOILHCFGO<HDIBLNDCIIF<JALCCLPNJLE>>> ByteCodeWriteLocation)> NIJLHKNCLKB, LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x299BE60", Offset = "0x299A460", VA = "0x18299BE60", Slot = "4")]
		private OCPMFOPNDFK<int> HNKJECKJMIL(int ONBCCEEOHCD, [In] OCPMFOPNDFK<(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> VariableId, LLDGDOINCKI<KBPOILHCFGO<HDIBLNDCIIF<JALCCLPNJLE>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(OCPMFOPNDFK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x299BED0", Offset = "0x299A4D0", VA = "0x18299BED0", Slot = "5")]
		private LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> KCCENCMFAFK(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> VariableId, LLDGDOINCKI<KBPOILHCFGO<HDIBLNDCIIF<JALCCLPNJLE>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct GNJFHHABOOM : NEJHKLGFECI<int, OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2998700", Offset = "0x2996D00", VA = "0x182998700")]
		public LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> MIOAOFOCBIK(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xB148F0", Offset = "0xB12EF0", VA = "0x180B148F0", Slot = "4")]
		public int OKIFKAJMGBM(int KHMHPNKMLMD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0")]
		public bool GAGFCACOMON(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "5")]
		private bool ICLJOJABBFB(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2998700", Offset = "0x2996D00", VA = "0x182998700", Slot = "6")]
		private LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> KDBDBLMDDLH(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct IFFEFFGIPDH : LCIJGIFCJIJ<int, OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x299BB50", Offset = "0x299A150", VA = "0x18299BB50")]
		public OCPMFOPNDFK<int> LKEHOJEIBEK(int ONBCCEEOHCD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(OCPMFOPNDFK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x299BAD0", Offset = "0x299A0D0", VA = "0x18299BAD0")]
		public LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> MIOAOFOCBIK(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x299B9F0", Offset = "0x2999FF0", VA = "0x18299B9F0", Slot = "6")]
		public void DIOMIEDNOGJ(int KHMHPNKMLMD, OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB, LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x299BB50", Offset = "0x299A150", VA = "0x18299BB50", Slot = "4")]
		private OCPMFOPNDFK<int> OHDIHHDCIMB(int ONBCCEEOHCD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(OCPMFOPNDFK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x299BAD0", Offset = "0x299A0D0", VA = "0x18299BAD0", Slot = "5")]
		private LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> JIDGKJBLDDJ(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct BLLLNIIKAHH : NEJHKLGFECI<int, OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2997280", Offset = "0x2995880", VA = "0x182997280")]
		public LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> MIOAOFOCBIK(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB148F0", Offset = "0xB12EF0", VA = "0x180B148F0", Slot = "4")]
		public int OKIFKAJMGBM(int KHMHPNKMLMD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0")]
		public bool GAGFCACOMON(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "5")]
		private bool ICLJOJABBFB(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2997270", Offset = "0x2995870", VA = "0x182997270", Slot = "6")]
		private LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> KDBDBLMDDLH(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct GPEFHJPOIDO : LCIJGIFCJIJ<int, OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x299AC00", Offset = "0x2999200", VA = "0x18299AC00")]
		public OCPMFOPNDFK<int> LKEHOJEIBEK(int ONBCCEEOHCD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(OCPMFOPNDFK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x299AC70", Offset = "0x2999270", VA = "0x18299AC70")]
		public LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> MIOAOFOCBIK(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x299AB00", Offset = "0x2999100", VA = "0x18299AB00", Slot = "6")]
		public void DIOMIEDNOGJ(int KHMHPNKMLMD, OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB, LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x299AC00", Offset = "0x2999200", VA = "0x18299AC00", Slot = "4")]
		private OCPMFOPNDFK<int> OHDIHHDCIMB(int ONBCCEEOHCD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(OCPMFOPNDFK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x299ABF0", Offset = "0x29991F0", VA = "0x18299ABF0", Slot = "5")]
		private LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> JIDGKJBLDDJ(int KHMHPNKMLMD, [In] OCPMFOPNDFK<(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> Target, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ByteCodeWriteLocation)> NIJLHKNCLKB)
		{
			return default(LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct EGHNNMAKPJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> ODFEPPOCFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool IBOHDDKDNFI;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2030800", Offset = "0x202EE00", VA = "0x182030800")]
		public EGHNNMAKPJF(LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EEGGNJLBKPD, bool AENFOBIANGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2997710", Offset = "0x2995D10", VA = "0x182997710")]
		public void GMJJAGOJIKC([Out] LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EEGGNJLBKPD, [Out] bool AENFOBIANGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct OCPEHEBGEEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly LLDGDOINCKI<KHPCHGHJGBM> MIPILOPBOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> ODFEPPOCFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool IBOHDDKDNFI;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x299CE30", Offset = "0x299B430", VA = "0x18299CE30")]
		public OCPEHEBGEEP(LLDGDOINCKI<KHPCHGHJGBM> FCFJPLIPPOF, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EEGGNJLBKPD, bool AENFOBIANGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x299CE00", Offset = "0x299B400", VA = "0x18299CE00")]
		public void GMJJAGOJIKC([Out] LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EEGGNJLBKPD, [Out] bool AENFOBIANGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x299CE10", Offset = "0x299B410", VA = "0x18299CE10")]
		public void GMJJAGOJIKC([Out] LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EEGGNJLBKPD, [Out] LLDGDOINCKI<KHPCHGHJGBM> FCFJPLIPPOF, [Out] bool AENFOBIANGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct CKINCLEHCLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly LLDGDOINCKI<KHPCHGHJGBM> MIPILOPBOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> ODFEPPOCFFC;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xDF17C0", Offset = "0xDEFDC0", VA = "0x180DF17C0")]
		public CKINCLEHCLK(LLDGDOINCKI<KHPCHGHJGBM> FCFJPLIPPOF, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EEGGNJLBKPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2997700", Offset = "0x2995D00", VA = "0x182997700")]
		public void GMJJAGOJIKC([Out] LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EEGGNJLBKPD, [Out] LLDGDOINCKI<KHPCHGHJGBM> FCFJPLIPPOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2998B50", Offset = "0x2997150", VA = "0x182998B50")]
	public static void BNBAOKNGOBL(this EGONJENNMKO PIKMBNLEPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2999080", Offset = "0x2997680", VA = "0x182999080")]
	public static void CIEPBJJIBIC(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<PMIFBODKNMJ> GLAEMIMGEOB, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> HAOHCBPHMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2998810", Offset = "0x2996E10", VA = "0x182998810")]
	public static void AKDHPOGEINA(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<PMIFBODKNMJ> GLAEMIMGEOB, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> HAOHCBPHMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2999470", Offset = "0x2997A70", VA = "0x182999470")]
	public static LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>? DMEDKMJBFIC([In] this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<PMIFBODKNMJ> GLAEMIMGEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2999EE0", Offset = "0x29984E0", VA = "0x182999EE0")]
	public static LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> KKHEBCJMKAH([In] this EGONJENNMKO PIKMBNLEPPK)
	{
		return default(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2999AB0", Offset = "0x29980B0", VA = "0x182999AB0")]
	private static void IKAJFLIACBM(this EGONJENNMKO PIKMBNLEPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x299A6B0", Offset = "0x2998CB0", VA = "0x18299A6B0")]
	private static LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>? OPBGLMEFPNB([In] this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<KHPCHGHJGBM> FCFJPLIPPOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2998F10", Offset = "0x2997510", VA = "0x182998F10")]
	public static void CEFPDBNCDPL(this EGONJENNMKO PIKMBNLEPPK, [In] OCPMFOPNDFK<LGFCDCGFEOM> EMHAGMGONAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x299A4E0", Offset = "0x2998AE0", VA = "0x18299A4E0")]
	public static GLLAINDDAJG.OHICKGFOLEE NLABJNGGANB([In] this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EEGGNJLBKPD)
	{
		return default(GLLAINDDAJG.OHICKGFOLEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x299A100", Offset = "0x2998700", VA = "0x18299A100")]
	public static EKFIFFNHCIJ<byte> LIFPJOEKJAH([In] this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EEGGNJLBKPD)
	{
		return default(EKFIFFNHCIJ<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x29999A0", Offset = "0x2997FA0", VA = "0x1829999A0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IDBNHDBCFPA([In] this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EEGGNJLBKPD)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2999C60", Offset = "0x2998260", VA = "0x182999C60")]
	public static EBGDFHFKLDP JKCEGKEDNOL([In] this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EEGGNJLBKPD)
	{
		return default(EBGDFHFKLDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B1F0", Offset = "0x3B597F0", VA = "0x183B5B1F0")]
	private static LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> MDKMOONBFPH<TMJoin>(this EGONJENNMKO PIKMBNLEPPK, GLLAINDDAJG.OHICKGFOLEE AFAFNGGHEPI, LLDGDOINCKI<TMJoin> PFOANGGOFFG) where TMJoin : GLLAINDDAJG.GBFLGBMGIKH
	{
		return default(LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x299A460", Offset = "0x2998A60", VA = "0x18299A460")]
	public static LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> NJFJLJPGCHE(this EGONJENNMKO PIKMBNLEPPK, bool MHNPKFGJHOF)
	{
		return default(LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2998E80", Offset = "0x2997480", VA = "0x182998E80")]
	public static LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> CANNGFGPBOA(this EGONJENNMKO PIKMBNLEPPK, EKFIFFNHCIJ<byte> IHNKIKDOAOB)
	{
		return default(LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x299AA80", Offset = "0x2999080", VA = "0x18299AA80")]
	public static LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> PNHCMDCEOGM(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> LCIBFPHPLLJ)
	{
		return default(LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2998940", Offset = "0x2996F40", VA = "0x182998940")]
	public static LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> BDDNOBOKPFI(this EGONJENNMKO PIKMBNLEPPK, int JGOOJMKGFKA)
	{
		return default(LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x299A3E0", Offset = "0x29989E0", VA = "0x18299A3E0")]
	public static LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> MLAJAJPJIJA(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> GFJJOALOGFG)
	{
		return default(LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B310", Offset = "0x3B59910", VA = "0x183B5B310")]
	private static LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF> PPMFBGILNHM<TMJoin>(this EGONJENNMKO PIKMBNLEPPK, LJDGNFKNFFC.BGPGJBJODLF AFAFNGGHEPI, LLDGDOINCKI<TMJoin> PFOANGGOFFG) where TMJoin : LJDGNFKNFFC.ABANDJGBOGM
	{
		return default(LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2999960", Offset = "0x2997F60", VA = "0x182999960")]
	public static LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF> HNHPDLEPKDN(this EGONJENNMKO PIKMBNLEPPK)
	{
		return default(LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x29992E0", Offset = "0x29978E0", VA = "0x1829992E0")]
	public static LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF> COFIBPDDMGM(this EGONJENNMKO PIKMBNLEPPK)
	{
		return default(LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2999330", Offset = "0x2997930", VA = "0x182999330")]
	public static LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF> DFAKGGIFBHH(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> HEEKIOMLFBP)
	{
		return default(LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x29996B0", Offset = "0x2997CB0", VA = "0x1829996B0")]
	public static LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF> FEJJHKKBNBG(this EGONJENNMKO PIKMBNLEPPK)
	{
		return default(LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2999C10", Offset = "0x2998210", VA = "0x182999C10")]
	public static LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF> JGKHMEEAAOK(this EGONJENNMKO PIKMBNLEPPK)
	{
		return default(LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x299A540", Offset = "0x2998B40", VA = "0x18299A540")]
	public static PBGOFMAFOLL.BIHNONANBHE ODNLBMHNCJJ([In] this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK> GALBMDOJPAP)
	{
		return default(PBGOFMAFOLL.BIHNONANBHE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x299A870", Offset = "0x2998E70", VA = "0x18299A870")]
	public static NKPFKKODLKE<LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>, LFMLGLDJGJE<PBGOFMAFOLL.INDMDEFHBBO>> PHCOAEOOCGK([In] this EGONJENNMKO PIKMBNLEPPK)
	{
		return default(NKPFKKODLKE<LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>, LFMLGLDJGJE<PBGOFMAFOLL.INDMDEFHBBO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x299A8B0", Offset = "0x2998EB0", VA = "0x18299A8B0")]
	public static LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> PKGCKGCGMME([In] this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK> GALBMDOJPAP)
	{
		return default(LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x299A5A0", Offset = "0x2998BA0", VA = "0x18299A5A0")]
	public static PBGOFMAFOLL.HPKJCNKHABH OHKMNLMLIEO([In] this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> LOMFGPMLHKI)
	{
		return default(PBGOFMAFOLL.HPKJCNKHABH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x29988E0", Offset = "0x2996EE0", VA = "0x1829988E0")]
	public static PBGOFMAFOLL.HPKJCNKHABH ALKHCMJDMEJ(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> LOMFGPMLHKI)
	{
		return default(PBGOFMAFOLL.HPKJCNKHABH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B280", Offset = "0x3B59880", VA = "0x183B5B280")]
	private static LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK> MMNOONHMCLE<TMJoin>(this EGONJENNMKO PIKMBNLEPPK, PBGOFMAFOLL.BIHNONANBHE AFAFNGGHEPI, LLDGDOINCKI<TMJoin> PFOANGGOFFG) where TMJoin : PBGOFMAFOLL.DIAODGAAIEI
	{
		return default(LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2999500", Offset = "0x2997B00", VA = "0x182999500")]
	public static (LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK>, LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>) FBOAOOHPANB(this EGONJENNMKO PIKMBNLEPPK)
	{
		return default((LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK>, LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2999700", Offset = "0x2997D00", VA = "0x182999700")]
	public static (LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK>, LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>) FPBONPPJBNK(this EGONJENNMKO PIKMBNLEPPK)
	{
		return default((LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK>, LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x299AA30", Offset = "0x2999030", VA = "0x18299AA30")]
	public static LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK> PNAIGBLEPHE(this EGONJENNMKO PIKMBNLEPPK)
	{
		return default(LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2998780", Offset = "0x2996D80", VA = "0x182998780")]
	public static void AAGOACDLLGI(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO> LOMFGPMLHKI, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> PKIAJNDLADE, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>> KGFHBNMICEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B59BD0", Offset = "0x3B581D0", VA = "0x183B59BD0")]
	public static EGHNNMAKPJF BKKLNDFCBKI<TDeps, TStateSys>(this EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<KHPCHGHJGBM> FCFJPLIPPOF) where TDeps : JPKMNALMDLD<TStateSys>
	{
		return default(EGHNNMAKPJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B5ADD0", Offset = "0x3B593D0", VA = "0x183B5ADD0")]
	public static OCPEHEBGEEP DLCPIHOFCHH<TDeps, TStateSys>(this EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<FELJLHNDBFC> OEEANCBNNKB, int MNIJEPPBPIG) where TDeps : JPKMNALMDLD<TStateSys>
	{
		return default(OCPEHEBGEEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B5A9B0", Offset = "0x3B58FB0", VA = "0x183B5A9B0")]
	public static LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>? CNMBFILMBPD<TDeps, TStateSys>(this EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<FELJLHNDBFC> OEEANCBNNKB, [In] ReadOnlySpan<int> CFAMIEIJIAO, [In] Span<CKINCLEHCLK> LFCBJHEEBME) where TDeps : JPKMNALMDLD<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B59640", Offset = "0x3B57C40", VA = "0x183B59640")]
	public static LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF> ABLJKGBCMGC<TDeps, TStateSys>(this EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<PMIFBODKNMJ> GLAEMIMGEOB) where TDeps : JPKMNALMDLD<TStateSys>
	{
		return default(LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2999E30", Offset = "0x2998430", VA = "0x182999E30")]
	public static LPGBKPBMOGL.HCOHJHBBIGE JNKPPJEFNLA([In] this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> HLIPPIOIAJK)
	{
		return default(LPGBKPBMOGL.HCOHJHBBIGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x29998B0", Offset = "0x2997EB0", VA = "0x1829998B0")]
	public static LPGBKPBMOGL.PJGLHLELBNL HHFGELGAGFP([In] this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> HLIPPIOIAJK)
	{
		return default(LPGBKPBMOGL.PJGLHLELBNL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x299A2D0", Offset = "0x29988D0", VA = "0x18299A2D0")]
	public static LPGBKPBMOGL.OKNJCAAOKFP MJKNHNDAKOO([In] this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> HLIPPIOIAJK)
	{
		return default(LPGBKPBMOGL.OKNJCAAOKFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2999F40", Offset = "0x2998540", VA = "0x182999F40")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> LDBFKIOALFP(this EGONJENNMKO PIKMBNLEPPK, int? FLLOAGAOBDP, string IEDAJGLJHNI)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2999110", Offset = "0x2997710", VA = "0x182999110")]
	public static LPGBKPBMOGL.IBKGLONFDKF CJKIKGPDBCF([In] this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> HLIPPIOIAJK)
	{
		return default(LPGBKPBMOGL.IBKGLONFDKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x299A380", Offset = "0x2998980", VA = "0x18299A380")]
	public static LPGBKPBMOGL.IOCFGAPCCMO MKMMOBCJKDO([In] this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> HLIPPIOIAJK)
	{
		return default(LPGBKPBMOGL.IOCFGAPCCMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2999A50", Offset = "0x2998050", VA = "0x182999A50")]
	public static int? IGGCLPMFAAB([In] this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> HLIPPIOIAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B110", Offset = "0x3B59710", VA = "0x183B5B110")]
	private static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> LNIAHNKHMII<TMJoin>(this EGONJENNMKO PIKMBNLEPPK, int? FLLOAGAOBDP, LPGBKPBMOGL.IOCFGAPCCMO AFAFNGGHEPI, LLDGDOINCKI<TMJoin> PFOANGGOFFG) where TMJoin : LPGBKPBMOGL.MLHFNBMPLNC
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x299A600", Offset = "0x2998C00", VA = "0x18299A600")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> OJFJMDLKMBN(this EGONJENNMKO PIKMBNLEPPK, int? FLLOAGAOBDP, LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK> GALBMDOJPAP, int KHMHPNKMLMD)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x299A1B0", Offset = "0x29987B0", VA = "0x18299A1B0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> LOCNABDHJFJ(this EGONJENNMKO PIKMBNLEPPK, int? FLLOAGAOBDP)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x29989C0", Offset = "0x2996FC0", VA = "0x1829989C0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> BMHECCKEOPF(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>? DADIPCAJNEK, int? FLLOAGAOBDP)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2999250", Offset = "0x2997850", VA = "0x182999250")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> COADIMKALMF(this EGONJENNMKO PIKMBNLEPPK, int? FLLOAGAOBDP, int KHMHPNKMLMD)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2998E20", Offset = "0x2997420", VA = "0x182998E20")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> BPICFKNDIGN(this EGONJENNMKO PIKMBNLEPPK, int? FLLOAGAOBDP)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x299A740", Offset = "0x2998D40", VA = "0x18299A740")]
	public static void PECEABIFAPP(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> GFJJOALOGFG, LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK> GALBMDOJPAP, int KHMHPNKMLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2999D10", Offset = "0x2998310", VA = "0x182999D10")]
	public static void JKNFKMPCNFA(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> GFJJOALOGFG, int KHMHPNKMLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x29993B0", Offset = "0x29979B0", VA = "0x1829993B0")]
	public static void DHNBFHKOOLM(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> GFJJOALOGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x29991C0", Offset = "0x29977C0", VA = "0x1829991C0")]
	public static void CMIGAMBJIHL(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> OKOGHNMMGGB, LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> BMAOOGCKDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x299A210", Offset = "0x2998810", VA = "0x18299A210")]
	public static void LOHOJOPJDCF(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> GFJJOALOGFG, LLDGDOINCKI<KBPOILHCFGO<MOJGFAJIJJP>> LNMNBLGLJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B050", Offset = "0x3B59650", VA = "0x183B5B050")]
	public static void DMDKNGJOLNF<M>(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> GFJJOALOGFG, LLDGDOINCKI<KBPOILHCFGO<HDIBLNDCIIF<M>>> LNMNBLGLJLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JPKMNALMDLD<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LLDGDOINCKI<HFNFAHKMEBK> OJJKFCMNONA(TStateSys CNHLLFKNHKH);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LLDGDOINCKI<HFNFAHKMEBK> NFLCEEIKLCC(TStateSys CNHLLFKNHKH);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LLDGDOINCKI<HFNFAHKMEBK> PAECCNKGKMJ(TStateSys CNHLLFKNHKH);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LLDGDOINCKI<HFNFAHKMEBK> IODCJOAKFHJ(TStateSys CNHLLFKNHKH);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF> APNHBODNNOO(TStateSys CNHLLFKNHKH, EGONJENNMKO MKJLPJNEJAC, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<KHPCHGHJGBM> FCFJPLIPPOF);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> BLEMLOBDMHE(TStateSys CNHLLFKNHKH, EGONJENNMKO MKJLPJNEJAC, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<PMIFBODKNMJ> GLAEMIMGEOB);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int LDJCOEAGPCI(TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<KHPCHGHJGBM> FCFJPLIPPOF);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LLDGDOINCKI<PMIFBODKNMJ> KMBHJNJCLJM(TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<KHPCHGHJGBM> FCFJPLIPPOF, int LGNMPABJPAJ);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FAGNDGPNKIK EAOAGAMFGJO(TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<KHPCHGHJGBM> FCFJPLIPPOF);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GPLBDEONGIK(TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<KHPCHGHJGBM> FCFJPLIPPOF);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int PPCBDPGNMGM(TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<KHPCHGHJGBM> FCFJPLIPPOF);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EKFIFFNHCIJ<byte> CJAEKMFNEJN(TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<KHPCHGHJGBM> FCFJPLIPPOF);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(EKFIFFNHCIJ<byte>, LLDGDOINCKI<HFNFAHKMEBK>) OHBLMFAIENC(TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<KHPCHGHJGBM> FCFJPLIPPOF);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int MCDMOBEEGOD(TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<PMIFBODKNMJ> GLAEMIMGEOB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LLDGDOINCKI<KHPCHGHJGBM> LHNDNHBEMDL(TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<PMIFBODKNMJ> GLAEMIMGEOB, int MNIJEPPBPIG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	LLDGDOINCKI<KHPCHGHJGBM> OHEDBPLKIGC(TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<FELJLHNDBFC> OEEANCBNNKB, int MNIJEPPBPIG);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int MICDPDBHIAM(TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? PDIALPBGHBG(TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, int KHMHPNKMLMD);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int PGJLINOFFFE(TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? MJFJEJIBMEG(TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, int KHMHPNKMLMD);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class AEJMPBAGEHO
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x30B0840", Offset = "0x30AEE40", VA = "0x1830B0840")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG?> EILEOOFHGEL<T, TOpInput, TOpOutput>(this EGONJENNMKO PIKMBNLEPPK, T IAPIHBICBOE, T FJDIHEBKFED, int MGFHDCMNGGC, IntPtr FEOGEOCFLBH)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x30B1CA0", Offset = "0x30B02A0", VA = "0x1830B1CA0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG?> IMNAENPHPNG<T, TOpInput, TOpOutput>(this EGONJENNMKO PIKMBNLEPPK, T IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED, int MGFHDCMNGGC, IntPtr FEOGEOCFLBH)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x30B19C0", Offset = "0x30AFFC0", VA = "0x1830B19C0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG?> HFADMKANFJO<TOpInput, TOpOutput>(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED, int MGFHDCMNGGC, IntPtr FEOGEOCFLBH)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2994DE0", Offset = "0x29933E0", VA = "0x182994DE0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> JFNKNICHNJD(this EGONJENNMKO PIKMBNLEPPK, float FPGNOHIDCHA, float IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2992E80", Offset = "0x2991480", VA = "0x182992E80")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> DHDMIEHLAIJ(this EGONJENNMKO PIKMBNLEPPK, float FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2992C40", Offset = "0x2991240", VA = "0x182992C40")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> DALBDGPELKK(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2996CD0", Offset = "0x29952D0", VA = "0x182996CD0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> OPPIMOPPDEJ(this EGONJENNMKO PIKMBNLEPPK, int FPGNOHIDCHA, int IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x29954D0", Offset = "0x2993AD0", VA = "0x1829954D0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> JNFMIAOKFNH(this EGONJENNMKO PIKMBNLEPPK, int FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x29938E0", Offset = "0x2991EE0", VA = "0x1829938E0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> GEGIKJOMEOH(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x29956F0", Offset = "0x2993CF0", VA = "0x1829956F0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> JOBDCINKDOK(this EGONJENNMKO PIKMBNLEPPK, int FPGNOHIDCHA, int IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x29937C0", Offset = "0x2991DC0", VA = "0x1829937C0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> GDFLHIMGAIJ(this EGONJENNMKO PIKMBNLEPPK, int FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2993300", Offset = "0x2991900", VA = "0x182993300")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FINHEOEKOOO(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2996530", Offset = "0x2994B30", VA = "0x182996530")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> NOKGMKJACAK(this EGONJENNMKO PIKMBNLEPPK, int IAPIHBICBOE, int FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2996F80", Offset = "0x2995580", VA = "0x182996F80")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> PJDMEFDHPPG(this EGONJENNMKO PIKMBNLEPPK, int IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2995BC0", Offset = "0x29941C0", VA = "0x182995BC0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> LGGPLGPPKFG(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x29960A0", Offset = "0x29946A0", VA = "0x1829960A0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> MNKPPJAEBIO(this EGONJENNMKO PIKMBNLEPPK, float IAPIHBICBOE, float FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2992300", Offset = "0x2990900", VA = "0x182992300")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> BIFOHGJNLEO(this EGONJENNMKO PIKMBNLEPPK, float IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x29966D0", Offset = "0x2994CD0", VA = "0x1829966D0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> ODJOBHDMPHM(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2993580", Offset = "0x2991B80", VA = "0x182993580")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FPCCEKNCCIB(this EGONJENNMKO PIKMBNLEPPK, int IAPIHBICBOE, int FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2992140", Offset = "0x2990740", VA = "0x182992140")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> BDNEMEIEHBH(this EGONJENNMKO PIKMBNLEPPK, int IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x29930E0", Offset = "0x29916E0", VA = "0x1829930E0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> DILAMKGBEFI(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2993160", Offset = "0x2991760", VA = "0x182993160")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> DMDGMCNCPJN(this EGONJENNMKO PIKMBNLEPPK, float IAPIHBICBOE, float FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x29927B0", Offset = "0x2990DB0", VA = "0x1829927B0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> BKPFJKJOIOL(this EGONJENNMKO PIKMBNLEPPK, float IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2996F00", Offset = "0x2995500", VA = "0x182996F00")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> PELMPDHBPOE(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2992040", Offset = "0x2990640", VA = "0x182992040")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> AOEAHJCFGEA(this EGONJENNMKO PIKMBNLEPPK, int IAPIHBICBOE, int FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x29948F0", Offset = "0x2992EF0", VA = "0x1829948F0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> JCENFGJPGPL(this EGONJENNMKO PIKMBNLEPPK, int IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2994EE0", Offset = "0x29934E0", VA = "0x182994EE0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> JHKIOGPEIOH(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2992430", Offset = "0x2990A30", VA = "0x182992430")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> BIJICIIOLAL(this EGONJENNMKO PIKMBNLEPPK, float IAPIHBICBOE, float FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x29962B0", Offset = "0x29948B0", VA = "0x1829962B0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> NDFEPCIEEMM(this EGONJENNMKO PIKMBNLEPPK, float IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2993740", Offset = "0x2991D40", VA = "0x182993740")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> GDACLKELOON(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2996950", Offset = "0x2994F50", VA = "0x182996950")]
	public static LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> OGNOFEBDKOO(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EEGGNJLBKPD)
	{
		return default(LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x29920C0", Offset = "0x29906C0", VA = "0x1829920C0")]
	public static LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> AONLJIHDHCN(this EGONJENNMKO PIKMBNLEPPK, int KKGBKLFKCPO)
	{
		return default(LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2996630", Offset = "0x2994C30", VA = "0x182996630")]
	public static LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> OBIGOHJHADJ(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> KKGBKLFKCPO)
	{
		return default(LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x29925D0", Offset = "0x2990BD0", VA = "0x1829925D0")]
	public static LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> BKIMGAMCJIP(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EEGGNJLBKPD)
	{
		return default(LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2991CE0", Offset = "0x29902E0", VA = "0x182991CE0")]
	public static LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> AHDNLABKDLD(this EGONJENNMKO PIKMBNLEPPK, int KKGBKLFKCPO)
	{
		return default(LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2991FA0", Offset = "0x29905A0", VA = "0x182991FA0")]
	public static LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> ANFFCCHDJGE(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> KKGBKLFKCPO)
	{
		return default(LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2994F60", Offset = "0x2993560", VA = "0x182994F60")]
	public static (LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK>, LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>) JKMGGJKCKKO(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<ILMPGDLOIGM> BKMALLBCAED, [In] ReadOnlySpan<LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>> PAABDOHHHNL, [In] ReadOnlySpan<int?> LIPFDHMPOJP, [In] Span<LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>> FGCCAJOGHCG)
	{
		return default((LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK>, LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2994970", Offset = "0x2992F70", VA = "0x182994970")]
	public static (LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK>, LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>) JEMOIENBNCI(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<DBIOEMHPNJO> JEELKPIPCHJ, [In] ReadOnlySpan<LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>> PAABDOHHHNL, [In] ReadOnlySpan<int?> LIPFDHMPOJP, [In] Span<LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>> FGCCAJOGHCG)
	{
		return default((LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK>, LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x30B03E0", Offset = "0x30AE9E0", VA = "0x1830B03E0")]
	public static (LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>, LLDGDOINCKI<KBPOILHCFGO<HFNFAHKMEBK>>, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>>, LLDGDOINCKI<KBPOILHCFGO<TMarker>>, LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK>) COBFCBPOEPC<TMarker>(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<HFNFAHKMEBK> LOPFBHACAIO, [In] ReadOnlySpan<byte> ACJFHCNBBBO)
	{
		return default((LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>, LLDGDOINCKI<KBPOILHCFGO<HFNFAHKMEBK>>, LLDGDOINCKI<KBPOILHCFGO<EPHGKGHNOEO>>, LLDGDOINCKI<KBPOILHCFGO<TMarker>>, LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2992B80", Offset = "0x2991180", VA = "0x182992B80")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> DAEMFEGFLPM(this EGONJENNMKO PIKMBNLEPPK, int DBJCFMPPIGG, [Optional] LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>? LBDLCBINGPA)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2992970", Offset = "0x2990F70", VA = "0x182992970")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> CNCGMGGPKFE(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> DBJCFMPPIGG, [Optional] LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>? LBDLCBINGPA)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2993E40", Offset = "0x2992440", VA = "0x182993E40")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> HBJPOHAIAOM(this EGONJENNMKO PIKMBNLEPPK, [In] ReadOnlySpan<byte> DBJCFMPPIGG, [Optional] LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>? LBDLCBINGPA)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2995E40", Offset = "0x2994440", VA = "0x182995E40")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> MJLNPFJBGOC(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> DBJCFMPPIGG, int GPNBMIDFKMK, [Optional] LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>? LBDLCBINGPA)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2994410", Offset = "0x2992A10", VA = "0x182994410")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IANGHBJDGMK(this EGONJENNMKO PIKMBNLEPPK, float FPGNOHIDCHA, float IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2993D20", Offset = "0x2992320", VA = "0x182993D20")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> GNCEKLPLBLN(this EGONJENNMKO PIKMBNLEPPK, float FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x29957F0", Offset = "0x2993DF0", VA = "0x1829957F0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> JONLEILLDOP(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2995AC0", Offset = "0x29940C0", VA = "0x182995AC0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> LAPDLEAGIOB(this EGONJENNMKO PIKMBNLEPPK, int FPGNOHIDCHA, int IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2992A60", Offset = "0x2991060", VA = "0x182992A60")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> COJBLFDFIDF(this EGONJENNMKO PIKMBNLEPPK, int FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2996810", Offset = "0x2994E10", VA = "0x182996810")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> OEPNEKOGPEK(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2995930", Offset = "0x2993F30", VA = "0x182995930")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> KIGEMNLDKAD(this EGONJENNMKO PIKMBNLEPPK, int IAPIHBICBOE, int FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2994870", Offset = "0x2992E70", VA = "0x182994870")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IOGEDNFPBFM(this EGONJENNMKO PIKMBNLEPPK, int IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2996B30", Offset = "0x2995130", VA = "0x182996B30")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> OLJKLHKEGAN(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IAPIHBICBOE, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FJDIHEBKFED)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x29959B0", Offset = "0x2993FB0", VA = "0x1829959B0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> KKCBFLBIKGM(this EGONJENNMKO PIKMBNLEPPK, float FPGNOHIDCHA, float IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2996DD0", Offset = "0x29953D0", VA = "0x182996DD0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> PADJNCLBKGN(this EGONJENNMKO PIKMBNLEPPK, float FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2995D00", Offset = "0x2994300", VA = "0x182995D00")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> MDIDIHKADLD(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x29953D0", Offset = "0x29939D0", VA = "0x1829953D0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> JMLIOKMEJBH(this EGONJENNMKO PIKMBNLEPPK, int FPGNOHIDCHA, int IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2993F30", Offset = "0x2992530", VA = "0x182993F30")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> HEGCNLECHLJ(this EGONJENNMKO PIKMBNLEPPK, int FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2993440", Offset = "0x2991A40", VA = "0x182993440")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FKEMKAPHBHD(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2994710", Offset = "0x2992D10", VA = "0x182994710")]
	public static LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>> IGFILNANILA(this EGONJENNMKO PIKMBNLEPPK)
	{
		return default(LLDGDOINCKI<KBPOILHCFGO<KBPOILHCFGO<BJKPLKCOHGB>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2994610", Offset = "0x2992C10", VA = "0x182994610")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> ICFAHDDPOPN(this EGONJENNMKO PIKMBNLEPPK, float FPGNOHIDCHA, float IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2996BB0", Offset = "0x29951B0", VA = "0x182996BB0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> OOIFJKBBFKL(this EGONJENNMKO PIKMBNLEPPK, float FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2992830", Offset = "0x2990E30", VA = "0x182992830")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> CHEMBBJLKKJ(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2994510", Offset = "0x2992B10", VA = "0x182994510")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IBAINJIHHHM(this EGONJENNMKO PIKMBNLEPPK, int FPGNOHIDCHA, int IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2991E80", Offset = "0x2990480", VA = "0x182991E80")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> AKFJPLCOLJA(this EGONJENNMKO PIKMBNLEPPK, int FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2994730", Offset = "0x2992D30", VA = "0x182994730")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IIEEDHJJJPK(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2992D80", Offset = "0x2991380", VA = "0x182992D80")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> DFCADPEHIPL(this EGONJENNMKO PIKMBNLEPPK, int KKGBKLFKCPO)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x29961A0", Offset = "0x29947A0", VA = "0x1829961A0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> MOPPJJMDELF(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> KKGBKLFKCPO)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2995AB0", Offset = "0x29940B0", VA = "0x182995AB0")]
	public static void KMPJCHEAIPP(this EGONJENNMKO PIKMBNLEPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2996430", Offset = "0x2994A30", VA = "0x182996430")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> NOBLFNGHLGK(this EGONJENNMKO PIKMBNLEPPK, float FPGNOHIDCHA, float IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x29924B0", Offset = "0x2990AB0", VA = "0x1829924B0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> BJJFKBOBFPN(this EGONJENNMKO PIKMBNLEPPK, float FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2995F60", Offset = "0x2994560", VA = "0x182995F60")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> MKBLMDIBMGL(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x29955F0", Offset = "0x2993BF0", VA = "0x1829955F0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> JNIIGKJOBJG(this EGONJENNMKO PIKMBNLEPPK, int FPGNOHIDCHA, int IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2991D60", Offset = "0x2990360", VA = "0x182991D60")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> AIABPNIBAPI(this EGONJENNMKO PIKMBNLEPPK, int FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x29921C0", Offset = "0x29907C0", VA = "0x1829921C0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> BEIBEMBFEGJ(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2994050", Offset = "0x2992650", VA = "0x182994050")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> HGIKICOHACA(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EIHBLCMACCC, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> NPJFPNGKMHC)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2996330", Offset = "0x2994930", VA = "0x182996330")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> NHMPIKDEOMN(this EGONJENNMKO PIKMBNLEPPK, int FPGNOHIDCHA, int IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x29931E0", Offset = "0x29917E0", VA = "0x1829931E0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> EOKCPBJHNJI(this EGONJENNMKO PIKMBNLEPPK, int FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2992FA0", Offset = "0x29915A0", VA = "0x182992FA0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> DIFCHCBGEPN(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> FPGNOHIDCHA, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> IGNHCMPFMCL)
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x30B0AF0", Offset = "0x30AF0F0", VA = "0x1830B0AF0")]
	public static void FEOEBNEMEDN<TDeps, TState>(this EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TState DCPJOMEJHIO, LLDGDOINCKI<ILMPGDLOIGM> BKMALLBCAED, [In] ReadOnlySpan<LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>> DNIHNFLKADM, [In] ReadOnlySpan<int?> LIPFDHMPOJP, [In] Span<LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>> FGCCAJOGHCG, [In] Span<LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>> GLGJKKNAKAH, [In] ReadOnlySpan<LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>?> DMAKPNHNEIO) where TDeps : notnull, JPKMNALMDLD<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x30AFED0", Offset = "0x30AE4D0", VA = "0x1830AFED0")]
	public static void BNNJFNDGAAO<TDeps, TState>(this EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TState DCPJOMEJHIO, LLDGDOINCKI<DBIOEMHPNJO> OEPFDIIJHGI, [In] ReadOnlySpan<LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>> OHJFOLNHEEN, [In] ReadOnlySpan<int?> LIPFDHMPOJP, [In] Span<LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>> FGCCAJOGHCG, [In] Span<LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>> GLGJKKNAKAH, [In] ReadOnlySpan<LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>?> DMAKPNHNEIO) where TDeps : notnull, JPKMNALMDLD<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x30B1AE0", Offset = "0x30B00E0", VA = "0x1830B1AE0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> HNKBFNBLFEL<TDeps, TState>(this EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TState DCPJOMEJHIO, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> DADIPCAJNEK, [Optional] LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>? LBDLCBINGPA) where TDeps : notnull, JPKMNALMDLD<TState> where TState : notnull
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x30B1F80", Offset = "0x30B0580", VA = "0x1830B1F80")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> JJIKMOPCLBC<TDeps, TState>(this EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TState DCPJOMEJHIO, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> HEEKIOMLFBP, [Optional] LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>? LBDLCBINGPA) where TDeps : notnull, JPKMNALMDLD<TState> where TState : notnull
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x30B04D0", Offset = "0x30AEAD0", VA = "0x1830B04D0")]
	public static LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> DIPLGAKMGGA<TDeps, TStateSys>(this EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TStateSys CNHLLFKNHKH) where TDeps : notnull, JPKMNALMDLD<TStateSys> where TStateSys : notnull
	{
		return default(LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x30B2BF0", Offset = "0x30B11F0", VA = "0x1830B2BF0")]
	public static LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF> OHPMHAOJPEC<TDeps, TStateSys>(this EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TStateSys CNHLLFKNHKH) where TDeps : notnull, JPKMNALMDLD<TStateSys> where TStateSys : notnull
	{
		return default(LLDGDOINCKI<LJDGNFKNFFC.ACMADCMCMHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2993600", Offset = "0x2991C00", VA = "0x182993600")]
	public static LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> GAFDICAJAFF(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> HOBGKPLCHPH, IntPtr CFAIECPHHPL, IntPtr MOGDGBIMPPG)
	{
		return default(LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2993A20", Offset = "0x2992020", VA = "0x182993A20")]
	public static LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> GKHABEGOCHH(this EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EJHNNMKINDP, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> PIIFDCEIFAB, IntPtr ODELGIIAEGP, IntPtr DCGDCFIFBAG, IntPtr JCKEAIMBJCJ, bool APNOMAAANNI)
	{
		return default(LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x30B1310", Offset = "0x30AF910", VA = "0x1830B1310")]
	public static LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> FMOMDGOGKBP<TDeps, TState>(this EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TState DCPJOMEJHIO, LLDGDOINCKI<ILMPGDLOIGM> CBOKOEGINOH, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EJHNNMKINDP, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> PIIFDCEIFAB, int? FKLPKHNEBOK, [Optional] IntPtr AFHGLJGMIOO) where TDeps : notnull, JPKMNALMDLD<TState> where TState : notnull
	{
		return default(LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x30B1000", Offset = "0x30AF600", VA = "0x1830B1000")]
	private static LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> FMOMDGOGKBP<TDeps, TState>(this EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TState DCPJOMEJHIO, LLDGDOINCKI<ILMPGDLOIGM> CBOKOEGINOH, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> EJHNNMKINDP, LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO> PIIFDCEIFAB, int? FKLPKHNEBOK) where TDeps : notnull, JPKMNALMDLD<TState> where TState : notnull
	{
		return default(LLDGDOINCKI<GLLAINDDAJG.OLOCEEDIFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x30B23B0", Offset = "0x30B09B0", VA = "0x1830B23B0")]
	public static LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> LLADLOADCIK<TDeps, TState>(this EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TState DCPJOMEJHIO, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> DBJCFMPPIGG, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>? LBDLCBINGPA) where TDeps : notnull, JPKMNALMDLD<TState> where TState : notnull
	{
		return default(LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x30B2830", Offset = "0x30B0E30", VA = "0x1830B2830")]
	public static void MDKCCPEDHGF<TDeps, TState>(this EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TState DCPJOMEJHIO, int MBKHDBLAGNF) where TDeps : notnull, JPKMNALMDLD<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct AJLGFMELGCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> JLHAMDAHGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> EFJBMDKAOBF;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xDF17C0", Offset = "0xDEFDC0", VA = "0x180DF17C0")]
	public AJLGFMELGCB(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> GMBDJNLDBIK, LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> BGJJLMLBBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x29970A0", Offset = "0x29956A0", VA = "0x1829970A0")]
	public static AJLGFMELGCB BFOPDLPDKBM(LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>> GMBDJNLDBIK)
	{
		return default(AJLGFMELGCB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct LPGBKPBMOGL
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class LLAKAHEFOMA : MLHFNBMPLNC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct HCOHJHBBIGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK> EIDDGNLNONN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int BPENJJIEFOH;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xDF17C0", Offset = "0xDEFDC0", VA = "0x180DF17C0")]
		public HCOHJHBBIGE(LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK> GALBMDOJPAP, int KHMHPNKMLMD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class HKDMNLBMMFM : MLHFNBMPLNC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct PJGLHLELBNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int BPENJJIEFOH;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0")]
		public PJGLHLELBNL(int KHMHPNKMLMD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class FEBAAKPLFNG : MLHFNBMPLNC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct OKNJCAAOKFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK> EIDDGNLNONN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int BPENJJIEFOH;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xDF17C0", Offset = "0xDEFDC0", VA = "0x180DF17C0")]
		public OKNJCAAOKFP(LLDGDOINCKI<PBGOFMAFOLL.AICJIILPPGK> GALBMDOJPAP, int KHMHPNKMLMD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum IOCFGAPCCMO
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
	public sealed class KMOPJFLHDMG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class MLHFNBMPLNC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct PJDEODDEOEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? MAGCGENCKAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AJLGFMELGCB HDIAFPCACDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public IOCFGAPCCMO GBNPFJMLGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public LLDGDOINCKI<MLHFNBMPLNC> LMIKGBEHPFJ;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x299D200", Offset = "0x299B800", VA = "0x18299D200")]
		public PJDEODDEOEI(int? FLLOAGAOBDP, [In] AJLGFMELGCB GLHFINGBJOB, IOCFGAPCCMO AFAFNGGHEPI, LLDGDOINCKI<MLHFNBMPLNC> PFOANGGOFFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class JHOBIHGHKPF : MLHFNBMPLNC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct IBKGLONFDKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int BPENJJIEFOH;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0")]
		public IBKGLONFDKF(int KHMHPNKMLMD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal DJCFFNPBMKI<KMOPJFLHDMG, PJDEODDEOEI> NFCHEDOICKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal DJCFFNPBMKI<LLAKAHEFOMA, HCOHJHBBIGE> PHBDNHHGPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal DJCFFNPBMKI<FEBAAKPLFNG, OKNJCAAOKFP> GDNPONKHPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal DJCFFNPBMKI<JHOBIHGHKPF, IBKGLONFDKF> MJKBCEAAJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal DJCFFNPBMKI<HKDMNLBMMFM, PJGLHLELBNL> ACFJKKFNDAI;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x299C5C0", Offset = "0x299ABC0", VA = "0x18299C5C0")]
	private LPGBKPBMOGL([In] DJCFFNPBMKI<KMOPJFLHDMG, PJDEODDEOEI> HCJLKANGAGJ, [In] DJCFFNPBMKI<LLAKAHEFOMA, HCOHJHBBIGE> PNLGJHKANOI, [In] DJCFFNPBMKI<FEBAAKPLFNG, OKNJCAAOKFP> GLLCGDDJAHC, [In] DJCFFNPBMKI<JHOBIHGHKPF, IBKGLONFDKF> EJFGHMKBJED, [In] DJCFFNPBMKI<HKDMNLBMMFM, PJGLHLELBNL> AJOGLLKJIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x299C3D0", Offset = "0x299A9D0", VA = "0x18299C3D0")]
	public static LPGBKPBMOGL BFOPDLPDKBM()
	{
		return default(LPGBKPBMOGL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class KCMIJJJCLGO
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x299BF60", Offset = "0x299A560", VA = "0x18299BF60")]
	public static void BNBAOKNGOBL(this LPGBKPBMOGL PIKMBNLEPPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class GPIOBBLFFAL
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x299ACF0", Offset = "0x29992F0", VA = "0x18299ACF0")]
	public static void JNJJALJCEOA(EGONJENNMKO PIKMBNLEPPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct CFFNNLHHCHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, AEDCEMOPNGF> OAKEJPEJAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int AFEAKIMEIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int HOIMMDCDMOB;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x29976C0", Offset = "0x2995CC0", VA = "0x1829976C0")]
	private CFFNNLHHCHP([In] NKNEHBBBKOO<PBGOFMAFOLL.INDMDEFHBBO, AEDCEMOPNGF> KLPEKKLDAAG, int FABNFBLHEEK, int CNBNHPMKEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2997480", Offset = "0x2995A80", VA = "0x182997480")]
	public static CFFNNLHHCHP BFOPDLPDKBM()
	{
		return default(CFFNNLHHCHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x29974F0", Offset = "0x2995AF0", VA = "0x1829974F0")]
	public void BNBAOKNGOBL([In] EGONJENNMKO JCJKCHCIAGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x392CE40", Offset = "0x392B440", VA = "0x18392CE40")]
	public static void JNJJALJCEOA<TDeps, TStateSys>(EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TStateSys CNHLLFKNHKH, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF) where TDeps : notnull, JPKMNALMDLD<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class AMIOFIHNLJP
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x29970B0", Offset = "0x29956B0", VA = "0x1829970B0")]
	public static void JNJJALJCEOA(EGONJENNMKO PIKMBNLEPPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct PDAJBIEPFJL
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface FOICMBOLALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DNLPHIAODEJ(OCPMFOPNDFK<byte> JCJAJMBCIPD, int EMLGPBMJKIN);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct HKLPHCPCJFK : FOICMBOLALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x299B8B0", Offset = "0x2999EB0", VA = "0x18299B8B0", Slot = "4")]
		public void DNLPHIAODEJ(OCPMFOPNDFK<byte> JCJAJMBCIPD, int EMLGPBMJKIN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct KJPHIHNGFMK : FOICMBOLALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x299C010", Offset = "0x299A610", VA = "0x18299C010", Slot = "4")]
		public void DNLPHIAODEJ(OCPMFOPNDFK<byte> JCJAJMBCIPD, int EMLGPBMJKIN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct MIIOJCALNKJ : FOICMBOLALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x299CA90", Offset = "0x299B090", VA = "0x18299CA90", Slot = "4")]
		public void DNLPHIAODEJ(OCPMFOPNDFK<byte> JCJAJMBCIPD, int EMLGPBMJKIN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct MKHKCILGJAJ : FOICMBOLALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x299CB10", Offset = "0x299B110", VA = "0x18299CB10", Slot = "4")]
		public void DNLPHIAODEJ(OCPMFOPNDFK<byte> JCJAJMBCIPD, int EMLGPBMJKIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class BODHOFENDGM<TCallProcessorDeps> where TCallProcessorDeps : struct, FOICMBOLALP
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps ODPIHOLNHGM;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3C917F0", Offset = "0x3C8FDF0", VA = "0x183C917F0")]
		public static int JNJJALJCEOA<TDeps, TStateSys>(TDeps GMIGKAKBDIM, TStateSys DCPJOMEJHIO, EGONJENNMKO JCJKCHCIAGM, [In] OCPMFOPNDFK<byte> GNFPKMJPFLE, int INJIIGPGHAA) where TDeps : JPKMNALMDLD<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private OCPMFOPNDFK<LGFCDCGFEOM> FHOGMBEFJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>, LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>> PICELIGDMJE;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x299D1C0", Offset = "0x299B7C0", VA = "0x18299D1C0")]
	private PDAJBIEPFJL([In] OCPMFOPNDFK<LGFCDCGFEOM> EMHAGMGONAL, Dictionary<LLDGDOINCKI<KBPOILHCFGO<BJKPLKCOHGB>>, LLDGDOINCKI<PBGOFMAFOLL.INDMDEFHBBO>> HGAOFHFAOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x299D0C0", Offset = "0x299B6C0", VA = "0x18299D0C0")]
	public static PDAJBIEPFJL BFOPDLPDKBM()
	{
		return default(PDAJBIEPFJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x299D180", Offset = "0x299B780", VA = "0x18299D180")]
	public void BNBAOKNGOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3CF61D0", Offset = "0x3CF47D0", VA = "0x183CF61D0")]
	public static void JNJJALJCEOA<TDeps, TStateSys>(EGONJENNMKO PIKMBNLEPPK, TDeps GMIGKAKBDIM, TStateSys CNHLLFKNHKH) where TDeps : JPKMNALMDLD<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class HBCCLFLFIIF
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct CFOJJBCJHHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> HDLHMLLPKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int ONLKDOIMNBA;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int KMMIHLKEFML;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int IEHJIJKAACF;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x299AF80", Offset = "0x2999580", VA = "0x18299AF80")]
	public static void JNJJALJCEOA(EGONJENNMKO PIKMBNLEPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x299B630", Offset = "0x2999C30", VA = "0x18299B630")]
	private static void LPCPKELDPCI([In] EGONJENNMKO PIKMBNLEPPK, LLDGDOINCKI<LPGBKPBMOGL.KMOPJFLHDMG> HLIPPIOIAJK, OCPMFOPNDFK<byte> LIDAMIFCMCC, List<CFOJJBCJHHM> HLPOJPOABOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x299B4F0", Offset = "0x2999AF0", VA = "0x18299B4F0")]
	private static void LPCPKELDPCI(OCPMFOPNDFK<byte> LIDAMIFCMCC, int GPNBMIDFKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x299AE50", Offset = "0x2999450", VA = "0x18299AE50")]
	private static void HDFBCPBPBCM(EGONJENNMKO PIKMBNLEPPK, List<CFOJJBCJHHM> HLPOJPOABOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class ONACCDGPFBH<TDeps, TIndex, TValues> where TDeps : struct, LCIJGIFCJIJ<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps ODPIHOLNHGM;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x57E1EF0", Offset = "0x57E04F0", VA = "0x1857E1EF0")]
	public static void JNJJALJCEOA([In] OCPMFOPNDFK<LGFCDCGFEOM> EMHAGMGONAL, int ONBCCEEOHCD, TValues NIJLHKNCLKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface LCIJGIFCJIJ<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OCPMFOPNDFK<TIndex> LKEHOJEIBEK(int ONBCCEEOHCD, [In] TValues NIJLHKNCLKB);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> MIOAOFOCBIK(TIndex KHMHPNKMLMD, [In] TValues NIJLHKNCLKB);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DIOMIEDNOGJ(TIndex KHMHPNKMLMD, TValues NIJLHKNCLKB, LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> KKGBKLFKCPO);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface NEJHKLGFECI<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex OKIFKAJMGBM(int KHMHPNKMLMD);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GAGFCACOMON(TIndex KHMHPNKMLMD, [In] TValues NIJLHKNCLKB);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LLDGDOINCKI<KBPOILHCFGO<JALCCLPNJLE>> MIOAOFOCBIK(TIndex KHMHPNKMLMD, [In] TValues NIJLHKNCLKB);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class OLCOJJDCJOP<TDeps, TIndex, TValues> where TDeps : struct, NEJHKLGFECI<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps ODPIHOLNHGM;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x57D9B50", Offset = "0x57D8150", VA = "0x1857D9B50")]
	public static OCPMFOPNDFK<TIndex> JNJJALJCEOA(int ONBCCEEOHCD, [In] TValues NIJLHKNCLKB)
	{
		return default(OCPMFOPNDFK<TIndex>);
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
