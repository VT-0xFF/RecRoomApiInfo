using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Mono.Math;
using Newtonsoft.Json;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal sealed class MCGFPBNIDAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Action FFFCHDHKAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private BMFDONNFDEH MJELEANMKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KANMFJJLEDD JFHFKIMKDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private BMFDONNFDEH CEMOFMJGJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool PDKBIPCBPEC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BMFDONNFDEH PKJHNLMDLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xDE4FC0", Offset = "0xDE3DC0", VA = "0x180DE4FC0")]
		get
		{
			return default(BMFDONNFDEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public BMFDONNFDEH FLALIOEAEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x59CD1B0", Offset = "0x59CBFB0", VA = "0x1859CD1B0")]
		get
		{
			return default(BMFDONNFDEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BMFDONNFDEH NKBJFBDOLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x59CCEB0", Offset = "0x59CBCB0", VA = "0x1859CCEB0")]
		get
		{
			return default(BMFDONNFDEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool OBEMKGGEFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F7020", Offset = "0x6F5E20", VA = "0x1806F7020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x59CD1D0", Offset = "0x59CBFD0", VA = "0x1859CD1D0")]
	public MCGFPBNIDAB(Action HHIMBJPJMKF, in BMFDONNFDEH DPGGAFFENIL, in BMFDONNFDEH OELDMGGEBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x59CCEC0", Offset = "0x59CBCC0", VA = "0x1859CCEC0")]
	public void DGEAIMOBBCG(in BMFDONNFDEH DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x59CCFB0", Offset = "0x59CBDB0", VA = "0x1859CCFB0")]
	public void MBBCLEBDJGG(in BMFDONNFDEH? MEIECDCGPPM, in BMFDONNFDEH? OMGOLDJPFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x59CCFA0", Offset = "0x59CBDA0", VA = "0x1859CCFA0")]
	public void IALPOKGCMAC(bool DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x59CCEE0", Offset = "0x59CBCE0", VA = "0x1859CCEE0")]
	private void GFPNOBONLLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OLCEJOIBGNM
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate object BGHHFOBJMFK();

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate object PMJGACAJAKN<T>(T NHMGHNFFDAC);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate object KGHKHOGOIKM<T>(in T NHMGHNFFDAC);

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface BGOEFNLBGEG
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		BMFDONNFDEH KKNOJHOEIPK
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GICKCNCALPG(object IACFBMPPCKF);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GICKCNCALPG(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct BALINNAOLMG : BGOEFNLBGEG
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public BMFDONNFDEH KKNOJHOEIPK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x59BD1D0", Offset = "0x59BBFD0", VA = "0x1859BD1D0", Slot = "4")]
			get
			{
				return default(BMFDONNFDEH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x59BD230", Offset = "0x59BC030", VA = "0x1859BD230", Slot = "5")]
		public void GICKCNCALPG(object IACFBMPPCKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x59BD290", Offset = "0x59BC090", VA = "0x1859BD290", Slot = "6")]
		public void GICKCNCALPG(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private readonly struct LBLILDKCNGH : BGOEFNLBGEG
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public BMFDONNFDEH KKNOJHOEIPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x59CCD80", Offset = "0x59CBB80", VA = "0x1859CCD80", Slot = "4")]
			get
			{
				return default(BMFDONNFDEH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x59CCE50", Offset = "0x59CBC50", VA = "0x1859CCE50", Slot = "5")]
		public void GICKCNCALPG(object IACFBMPPCKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x59CCDE0", Offset = "0x59CBBE0", VA = "0x1859CCDE0", Slot = "6")]
		public void GICKCNCALPG(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private readonly struct JABONHLABNM : BGOEFNLBGEG
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public BMFDONNFDEH KKNOJHOEIPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x59CAEC0", Offset = "0x59C9CC0", VA = "0x1859CAEC0", Slot = "4")]
			get
			{
				return default(BMFDONNFDEH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x59CAF90", Offset = "0x59C9D90", VA = "0x1859CAF90", Slot = "5")]
		public void GICKCNCALPG(object IACFBMPPCKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x59CAF20", Offset = "0x59C9D20", VA = "0x1859CAF20", Slot = "6")]
		public void GICKCNCALPG(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private static class KBLBGPFLLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4C72050", Offset = "0x4C70E50", VA = "0x184C72050")]
		public static void GICKCNCALPG<T>(in T BIKHFKCJEPO, object IACFBMPPCKF, in BMFDONNFDEH POLNGKBPPLK) where T : BGOEFNLBGEG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4C720F0", Offset = "0x4C70EF0", VA = "0x184C720F0")]
		public static void GICKCNCALPG<T>(in T BIKHFKCJEPO, object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, in BMFDONNFDEH POLNGKBPPLK) where T : BGOEFNLBGEG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x4C721B0", Offset = "0x4C70FB0", VA = "0x184C721B0")]
		public static void GICKCNCALPG<T>(in T BIKHFKCJEPO, BGHHFOBJMFK IACFBMPPCKF, in BMFDONNFDEH POLNGKBPPLK) where T : BGOEFNLBGEG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4C72270", Offset = "0x4C71070", VA = "0x184C72270")]
		public static void GICKCNCALPG<T>(in T BIKHFKCJEPO, BGHHFOBJMFK IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, in BMFDONNFDEH POLNGKBPPLK) where T : BGOEFNLBGEG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4C71DC0", Offset = "0x4C70BC0", VA = "0x184C71DC0")]
		public static void GICKCNCALPG<T, U>(in T BIKHFKCJEPO, PMJGACAJAKN<U> IACFBMPPCKF, in U NHMGHNFFDAC, in BMFDONNFDEH POLNGKBPPLK) where T : BGOEFNLBGEG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4C71F70", Offset = "0x4C70D70", VA = "0x184C71F70")]
		public static void GICKCNCALPG<T, U>(in T BIKHFKCJEPO, PMJGACAJAKN<U> IACFBMPPCKF, in U NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, in BMFDONNFDEH POLNGKBPPLK) where T : BGOEFNLBGEG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4C71CF0", Offset = "0x4C70AF0", VA = "0x184C71CF0")]
		public static void GICKCNCALPG<T, U>(in T BIKHFKCJEPO, KGHKHOGOIKM<U> IACFBMPPCKF, in U NHMGHNFFDAC, in BMFDONNFDEH POLNGKBPPLK) where T : BGOEFNLBGEG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4C71E90", Offset = "0x4C70C90", VA = "0x184C71E90")]
		public static void GICKCNCALPG<T, U>(in T BIKHFKCJEPO, KGHKHOGOIKM<U> IACFBMPPCKF, in U NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, in BMFDONNFDEH POLNGKBPPLK) where T : BGOEFNLBGEG
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private interface ILJHBBJFFEB<TConditionArg>
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KJHAHNAAJMI();

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool GONHNDACPAB(in TConditionArg NHMGHNFFDAC);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ONNNEDGHNNM(in TConditionArg NHMGHNFFDAC, bool ACJHJCKNJHD);
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private readonly struct BLBJNMOHPBL : ILJHBBJFFEB<((string, int), object)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Dictionary<(string File, int Line), object> LMODBOGHMPB;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x963B70", Offset = "0x962970", VA = "0x180963B70")]
		private BLBJNMOHPBL(Dictionary<(string File, int Line), object> LGODAIIBOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x59BD550", Offset = "0x59BC350", VA = "0x1859BD550")]
		public static BLBJNMOHPBL PKGIDMHJGMJ()
		{
			return default(BLBJNMOHPBL);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x59BD4F0", Offset = "0x59BC2F0", VA = "0x1859BD4F0", Slot = "4")]
		public void KJHAHNAAJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x59BD410", Offset = "0x59BC210", VA = "0x1859BD410")]
		public bool GONHNDACPAB(in ((string File, int Line) Location, object Value) NHMGHNFFDAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3279B20", Offset = "0x3278920", VA = "0x183279B20")]
		public bool ONNNEDGHNNM(in ((string File, int Line) Location, object Value) KNNMPBLOADI, bool ACJHJCKNJHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x59BD540", Offset = "0x59BC340", VA = "0x1859BD540", Slot = "5")]
		private bool OBJJCLMHABA(in ((string File, int Line) Location, object Value) NHMGHNFFDAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3279B20", Offset = "0x3278920", VA = "0x183279B20", Slot = "6")]
		private bool NJLBKJMMDMG(in ((string File, int Line) Location, object Value) NHMGHNFFDAC, bool ACJHJCKNJHD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private readonly struct KPMKPMPJGIF : ILJHBBJFFEB<(string, int)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly HashSet<(string File, int Line)> JECEEBLHCOK;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x963B70", Offset = "0x962970", VA = "0x180963B70")]
		private KPMKPMPJGIF(HashSet<(string File, int Line)> AEEBBAMGDBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x59CCD10", Offset = "0x59CBB10", VA = "0x1859CCD10")]
		public static KPMKPMPJGIF PKGIDMHJGMJ()
		{
			return default(KPMKPMPJGIF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x59CCCC0", Offset = "0x59CBAC0", VA = "0x1859CCCC0", Slot = "4")]
		public void KJHAHNAAJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x59CCC10", Offset = "0x59CBA10", VA = "0x1859CCC10")]
		public bool GONHNDACPAB(in (string File, int Line) NHMGHNFFDAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3279B20", Offset = "0x3278920", VA = "0x183279B20")]
		public bool ONNNEDGHNNM(in (string File, int Line) KNNMPBLOADI, bool ACJHJCKNJHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x59CCCB0", Offset = "0x59CBAB0", VA = "0x1859CCCB0", Slot = "5")]
		private bool KEEKPKEMGLI(in (string File, int Line) NHMGHNFFDAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3279B20", Offset = "0x3278920", VA = "0x183279B20", Slot = "6")]
		private bool LCPDMBGKFEJ(in (string File, int Line) NHMGHNFFDAC, bool ACJHJCKNJHD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private readonly struct BMHMOIMCCNB : ILJHBBJFFEB<((string, int), long)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<(string File, int Line), long> PLDEMLFICOJ;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x59C1830", Offset = "0x59C0630", VA = "0x1859C1830", Slot = "4")]
		public void KJHAHNAAJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x963B70", Offset = "0x962970", VA = "0x180963B70")]
		private BMHMOIMCCNB(Dictionary<(string File, int Line), long> GENHAEBJLOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x59C1890", Offset = "0x59C0690", VA = "0x1859C1890")]
		public static BMHMOIMCCNB PKGIDMHJGMJ()
		{
			return default(BMHMOIMCCNB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x59C16A0", Offset = "0x59C04A0", VA = "0x1859C16A0")]
		public bool GONHNDACPAB(in ((string File, int Line) Location, long ThrottleMs) NHMGHNFFDAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3279B20", Offset = "0x3278920", VA = "0x183279B20")]
		public bool ONNNEDGHNNM(in ((string File, int Line) Location, long ThrottleMs) NHMGHNFFDAC, bool ACJHJCKNJHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x59C1880", Offset = "0x59C0680", VA = "0x1859C1880", Slot = "5")]
		private bool OJAPIOMBBBM(in ((string File, int Line) Location, long ThrottleMs) NHMGHNFFDAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3279B20", Offset = "0x3278920", VA = "0x183279B20", Slot = "6")]
		private bool FPOEDOHADAK(in ((string File, int Line) Location, long ThrottleMs) NHMGHNFFDAC, bool ACJHJCKNJHD)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private readonly struct FJNOHMAAHMJ : ILJHBBJFFEB<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "4")]
		public void KJHAHNAAJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x59C39A0", Offset = "0x59C27A0", VA = "0x1859C39A0")]
		public bool GONHNDACPAB(in bool NHMGHNFFDAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x59C39B0", Offset = "0x59C27B0", VA = "0x1859C39B0")]
		public bool ONNNEDGHNNM(in bool NHMGHNFFDAC, bool KNNMPBLOADI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x59C39A0", Offset = "0x59C27A0", VA = "0x1859C39A0", Slot = "5")]
		private bool KDDJGPCPMPD(in bool NHMGHNFFDAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x59C39B0", Offset = "0x59C27B0", VA = "0x1859C39B0", Slot = "6")]
		private bool KONCOADGMJH(in bool NHMGHNFFDAC, bool ACJHJCKNJHD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private readonly struct ABKEFFFFKJL : ILJHBBJFFEB<((string, int), bool)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly FJNOHMAAHMJ BHDNPGKJLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly KPMKPMPJGIF PCIEIFFMJAJ;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x38ED620", Offset = "0x38EC420", VA = "0x1838ED620")]
		private ABKEFFFFKJL(in KPMKPMPJGIF CDBDOPAGFJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x59BCDE0", Offset = "0x59BBBE0", VA = "0x1859BCDE0")]
		public static ABKEFFFFKJL PKGIDMHJGMJ()
		{
			return default(ABKEFFFFKJL);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x59BCD90", Offset = "0x59BBB90", VA = "0x1859BCD90", Slot = "4")]
		public void KJHAHNAAJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x59BCD70", Offset = "0x59BBB70", VA = "0x1859BCD70")]
		public bool GONHNDACPAB(in ((string File, int Line) Location, bool Condition) NHMGHNFFDAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2FAC6E0", Offset = "0x2FAB4E0", VA = "0x182FAC6E0")]
		public bool ONNNEDGHNNM(in ((string File, int Line) Location, bool Condition) NHMGHNFFDAC, bool KNNMPBLOADI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x59BCD70", Offset = "0x59BBB70", VA = "0x1859BCD70", Slot = "5")]
		private bool IJCABLCLNBN(in ((string File, int Line) Location, bool Condition) NHMGHNFFDAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2FAC6E0", Offset = "0x2FAB4E0", VA = "0x182FAC6E0", Slot = "6")]
		private bool MNCIAAAEICE(in ((string File, int Line) Location, bool Condition) NHMGHNFFDAC, bool ACJHJCKNJHD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private readonly struct JJJGKFPMBMA<TDeps> where TDeps : BGOEFNLBGEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly TDeps PDHCOEFNNFH;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3B03A10", Offset = "0x3B02810", VA = "0x183B03A10")]
		private bool FMGNPHEOIAH(in BMFDONNFDEH? POLNGKBPPLK, out BMFDONNFDEH MFIFCKBPACG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3B04AA0", Offset = "0x3B038A0", VA = "0x183B04AA0")]
		public void GICKCNCALPG(object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3B05000", Offset = "0x3B03E00", VA = "0x183B05000")]
		[Conditional("LOGGING_ENABLED")]
		[Conditional("UNITY_EDITOR")]
		public void LKNHLHDGEJN(object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3B05000", Offset = "0x3B03E00", VA = "0x183B05000")]
		public void MJPMAEGABHH(object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3B04430", Offset = "0x3B03230", VA = "0x183B04430")]
		public void GICKCNCALPG(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3B052A0", Offset = "0x3B040A0", VA = "0x183B052A0")]
		[Conditional("LOGGING_ENABLED")]
		[Conditional("UNITY_EDITOR")]
		public void LKNHLHDGEJN(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3B052A0", Offset = "0x3B040A0", VA = "0x183B052A0")]
		public void MJPMAEGABHH(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3B04010", Offset = "0x3B02E10", VA = "0x183B04010")]
		public void GICKCNCALPG(BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3B05240", Offset = "0x3B04040", VA = "0x183B05240")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void LKNHLHDGEJN(BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3B05240", Offset = "0x3B04040", VA = "0x183B05240")]
		public void MJPMAEGABHH(BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3B04350", Offset = "0x3B03150", VA = "0x183B04350")]
		public void GICKCNCALPG(BGHHFOBJMFK IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3B05440", Offset = "0x3B04240", VA = "0x183B05440")]
		[Conditional("LOGGING_ENABLED")]
		[Conditional("UNITY_EDITOR")]
		public void LKNHLHDGEJN(BGHHFOBJMFK IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3B05440", Offset = "0x3B04240", VA = "0x183B05440")]
		public void MJPMAEGABHH(BGHHFOBJMFK IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E1C0", Offset = "0x2F0CFC0", VA = "0x182F0E1C0")]
		public void GICKCNCALPG<TMessageArg>(PMJGACAJAKN<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E4A0", Offset = "0x2F0D2A0", VA = "0x182F0E4A0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void LKNHLHDGEJN<TMessageArg>(PMJGACAJAKN<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E4A0", Offset = "0x2F0D2A0", VA = "0x182F0E4A0")]
		public void MJPMAEGABHH<TMessageArg>(PMJGACAJAKN<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E320", Offset = "0x2F0D120", VA = "0x182F0E320")]
		public void GICKCNCALPG<TMessageArg>(PMJGACAJAKN<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E480", Offset = "0x2F0D280", VA = "0x182F0E480")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void LKNHLHDGEJN<TMessageArg>(PMJGACAJAKN<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E480", Offset = "0x2F0D280", VA = "0x182F0E480")]
		public void MJPMAEGABHH<TMessageArg>(PMJGACAJAKN<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E1C0", Offset = "0x2F0CFC0", VA = "0x182F0E1C0")]
		public void GICKCNCALPG<TMessageArg>(KGHKHOGOIKM<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E4A0", Offset = "0x2F0D2A0", VA = "0x182F0E4A0")]
		[Conditional("LOGGING_ENABLED")]
		[Conditional("UNITY_EDITOR")]
		public void LKNHLHDGEJN<TMessageArg>(KGHKHOGOIKM<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E4A0", Offset = "0x2F0D2A0", VA = "0x182F0E4A0")]
		public void MJPMAEGABHH<TMessageArg>(KGHKHOGOIKM<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E320", Offset = "0x2F0D120", VA = "0x182F0E320")]
		public void GICKCNCALPG<TMessageArg>(KGHKHOGOIKM<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E480", Offset = "0x2F0D280", VA = "0x182F0E480")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void LKNHLHDGEJN<TMessageArg>(KGHKHOGOIKM<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E480", Offset = "0x2F0D280", VA = "0x182F0E480")]
		public void MJPMAEGABHH<TMessageArg>(KGHKHOGOIKM<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private readonly struct LAKNEEMDEFN<TDeps, TConditionDeps, TConditionArg> where TDeps : BGOEFNLBGEG where TConditionDeps : ILJHBBJFFEB<TConditionArg>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly TDeps PDHCOEFNNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly TConditionDeps OBFBLFBAFLL;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x38ED600", Offset = "0x38EC400", VA = "0x1838ED600")]
		public LAKNEEMDEFN(in TConditionDeps JDIFMMILHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x38ED330", Offset = "0x38EC130", VA = "0x1838ED330")]
		public void KJHAHNAAJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x38EB2B0", Offset = "0x38EA0B0", VA = "0x1838EB2B0")]
		private bool CJEMNCHHFCJ(in BMFDONNFDEH? POLNGKBPPLK, in TConditionArg IDFFICGGMDC, out BMFDONNFDEH MFIFCKBPACG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x38EBC40", Offset = "0x38EAA40", VA = "0x1838EBC40")]
		public bool GICKCNCALPG(object IACFBMPPCKF, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x38ED470", Offset = "0x38EC270", VA = "0x1838ED470")]
		public bool LKNHLHDGEJN(object IACFBMPPCKF, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x38ECB80", Offset = "0x38EB980", VA = "0x1838ECB80")]
		public bool GICKCNCALPG(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x38ED550", Offset = "0x38EC350", VA = "0x1838ED550")]
		public bool LKNHLHDGEJN(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x38EC520", Offset = "0x38EB320", VA = "0x1838EC520")]
		public bool GICKCNCALPG(BGHHFOBJMFK IACFBMPPCKF, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x38ED470", Offset = "0x38EC270", VA = "0x1838ED470")]
		public bool LKNHLHDGEJN(BGHHFOBJMFK IACFBMPPCKF, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x38EC020", Offset = "0x38EAE20", VA = "0x1838EC020")]
		public bool GICKCNCALPG(BGHHFOBJMFK IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x38ED550", Offset = "0x38EC350", VA = "0x1838ED550")]
		public bool LKNHLHDGEJN(BGHHFOBJMFK IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3DABE60", Offset = "0x3DAAC60", VA = "0x183DABE60")]
		public bool GICKCNCALPG<TMessageArg>(PMJGACAJAKN<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x38ED550", Offset = "0x38EC350", VA = "0x1838ED550")]
		public bool LKNHLHDGEJN<TMessageArg>(PMJGACAJAKN<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3DABFC0", Offset = "0x3DAADC0", VA = "0x183DABFC0")]
		public bool GICKCNCALPG<TMessageArg>(PMJGACAJAKN<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3DAC3D0", Offset = "0x3DAB1D0", VA = "0x183DAC3D0")]
		public bool LKNHLHDGEJN<TMessageArg>(PMJGACAJAKN<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3DABE60", Offset = "0x3DAAC60", VA = "0x183DABE60")]
		public bool GICKCNCALPG<TMessageArg>(KGHKHOGOIKM<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x38ED550", Offset = "0x38EC350", VA = "0x1838ED550")]
		public bool LKNHLHDGEJN<TMessageArg>(KGHKHOGOIKM<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3DABFC0", Offset = "0x3DAADC0", VA = "0x183DABFC0")]
		public bool GICKCNCALPG<TMessageArg>(KGHKHOGOIKM<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3DAC3D0", Offset = "0x3DAB1D0", VA = "0x183DAC3D0")]
		public bool LKNHLHDGEJN<TMessageArg>(KGHKHOGOIKM<TMessageArg> IACFBMPPCKF, in TMessageArg NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, in TConditionArg IDFFICGGMDC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct OAGKFBPEPEP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly object IACFBMPPCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly BMFDONNFDEH? PGGAFCKMPPI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private bool GONHNDACPAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x59CECE0", Offset = "0x59CDAE0", VA = "0x1859CECE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x59CEDA0", Offset = "0x59CDBA0", VA = "0x1859CEDA0")]
		public OAGKFBPEPEP(object IACFBMPPCKF, in BMFDONNFDEH? PGGAFCKMPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x59CEC30", Offset = "0x59CDA30", VA = "0x1859CEC30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct CCJCAAOOCIO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		public CCJCAAOOCIO(object IACFBMPPCKF, in BMFDONNFDEH? PGGAFCKMPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum LENBAIDGBOE
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Method = 1,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Params = 2,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Link = 4,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		MiniLink = 8,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Default = 7
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FGLMCFKBCKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public BGHHFOBJMFK message;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public FGLMCFKBCKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x59C3880", Offset = "0x59C2680", VA = "0x1859C3880")]
		internal object <LogExceptionErrorString>b__0(Exception e)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly JJJGKFPMBMA<BALINNAOLMG> EBKHCOEEHHN;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly LAKNEEMDEFN<BALINNAOLMG, BLBJNMOHPBL, ((string File, int Line) Location, object Value)> PGLLJIFBMNO;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly JJJGKFPMBMA<JABONHLABNM> CMFLEJEKJOO;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly LAKNEEMDEFN<JABONHLABNM, KPMKPMPJGIF, (string File, int Line)> NOAHLLGPIAH;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public const string AONFHBDNLPM = "START: ";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const string AEPCJDBKLFD = "END: ";

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static readonly LAKNEEMDEFN<BALINNAOLMG, BMHMOIMCCNB, ((string File, int Line) Location, long ThrottleMs)> HHKLPBPJDNB;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static readonly JJJGKFPMBMA<LBLILDKCNGH> JBMIEKAOMLE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly LAKNEEMDEFN<JABONHLABNM, FJNOHMAAHMJ, bool> BBLHMCBOBIK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly LAKNEEMDEFN<JABONHLABNM, ABKEFFFFKJL, ((string File, int Line) Location, bool Condition)> HHJKKBHGAAD;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly Regex DDHKGCCANCH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly Regex EJEBALPHFEC;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x59D0350", Offset = "0x59CF150", VA = "0x1859D0350")]
	public static void GICKCNCALPG(object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x59D03D0", Offset = "0x59CF1D0", VA = "0x1859D03D0")]
	public static void GICKCNCALPG(BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3689910", Offset = "0x3688710", VA = "0x183689910")]
	public static void GICKCNCALPG<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3689C50", Offset = "0x3688A50", VA = "0x183689C50")]
	public static void GICKCNCALPG<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x59D0450", Offset = "0x59CF250", VA = "0x1859D0450")]
	public static void GICKCNCALPG(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x59D02B0", Offset = "0x59CF0B0", VA = "0x1859D02B0")]
	public static void GICKCNCALPG(BGHHFOBJMFK IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x368A010", Offset = "0x3688E10", VA = "0x18368A010")]
	public static void GICKCNCALPG<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3689B00", Offset = "0x3688900", VA = "0x183689B00")]
	public static void GICKCNCALPG<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void LKNHLHDGEJN(object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void LKNHLHDGEJN(BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void LKNHLHDGEJN<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void LKNHLHDGEJN<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void LKNHLHDGEJN(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void LKNHLHDGEJN(BGHHFOBJMFK IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void LKNHLHDGEJN<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void LKNHLHDGEJN<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x59D12E0", Offset = "0x59D00E0", VA = "0x1859D12E0")]
	public static void MJPMAEGABHH(object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x59D1360", Offset = "0x59D0160", VA = "0x1859D1360")]
	public static void MJPMAEGABHH(BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x368B360", Offset = "0x368A160", VA = "0x18368B360")]
	public static void MJPMAEGABHH<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x368B2C0", Offset = "0x368A0C0", VA = "0x18368B2C0")]
	public static void MJPMAEGABHH<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x59D1480", Offset = "0x59D0280", VA = "0x1859D1480")]
	public static void MJPMAEGABHH(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x59D13E0", Offset = "0x59D01E0", VA = "0x1859D13E0")]
	public static void MJPMAEGABHH(BGHHFOBJMFK IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x368B400", Offset = "0x368A200", VA = "0x18368B400")]
	public static void MJPMAEGABHH<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x368B210", Offset = "0x368A010", VA = "0x18368B210")]
	public static void MJPMAEGABHH<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3689050", Offset = "0x3687E50", VA = "0x183689050")]
	public static void BKBPBBKJNMB<T>(object IACFBMPPCKF, in T LOPIEGGIDMF, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3688F10", Offset = "0x3687D10", VA = "0x183688F10")]
	public static void BKBPBBKJNMB<T>(BGHHFOBJMFK IACFBMPPCKF, in T LOPIEGGIDMF, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3688C90", Offset = "0x3687A90", VA = "0x183688C90")]
	public static void BKBPBBKJNMB<U, T>(PMJGACAJAKN<U> IACFBMPPCKF, in U NHMGHNFFDAC, in T LOPIEGGIDMF, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3688DD0", Offset = "0x3687BD0", VA = "0x183688DD0")]
	public static void BKBPBBKJNMB<U, T>(KGHKHOGOIKM<U> IACFBMPPCKF, in U NHMGHNFFDAC, in T LOPIEGGIDMF, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x368A980", Offset = "0x3689780", VA = "0x18368A980")]
	public static void HPDMFBFHHKO<T>(object IACFBMPPCKF, in T LOPIEGGIDMF, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x368AAC0", Offset = "0x36898C0", VA = "0x18368AAC0")]
	public static void HPDMFBFHHKO<T>(BGHHFOBJMFK IACFBMPPCKF, in T LOPIEGGIDMF, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x368A840", Offset = "0x3689640", VA = "0x18368A840")]
	public static void HPDMFBFHHKO<U, T>(PMJGACAJAKN<U> IACFBMPPCKF, in U NHMGHNFFDAC, in T LOPIEGGIDMF, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x368A700", Offset = "0x3689500", VA = "0x18368A700")]
	public static void HPDMFBFHHKO<U, T>(KGHKHOGOIKM<U> IACFBMPPCKF, in U NHMGHNFFDAC, in T LOPIEGGIDMF, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x59D0770", Offset = "0x59CF570", VA = "0x1859D0770")]
	public static void IEFBBADHFBO(object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x59D0940", Offset = "0x59CF740", VA = "0x1859D0940")]
	public static void IEFBBADHFBO(BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x368AD60", Offset = "0x3689B60", VA = "0x18368AD60")]
	public static void IEFBBADHFBO<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x368AE00", Offset = "0x3689C00", VA = "0x18368AE00")]
	public static void IEFBBADHFBO<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x59D0800", Offset = "0x59CF600", VA = "0x1859D0800")]
	public static void IEFBBADHFBO(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x59D08A0", Offset = "0x59CF6A0", VA = "0x1859D08A0")]
	public static void IEFBBADHFBO(BGHHFOBJMFK IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x368AC00", Offset = "0x3689A00", VA = "0x18368AC00")]
	public static void IEFBBADHFBO<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x368ACB0", Offset = "0x3689AB0", VA = "0x18368ACB0")]
	public static void IEFBBADHFBO<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void MIGBAFAHCGI(object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void MIGBAFAHCGI(BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void MIGBAFAHCGI<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void MIGBAFAHCGI<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void MIGBAFAHCGI(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void MIGBAFAHCGI(BGHHFOBJMFK IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void MIGBAFAHCGI<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void MIGBAFAHCGI<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x59CFB40", Offset = "0x59CE940", VA = "0x1859CFB40")]
	public static void FGMKICMLOGA(Exception IHBJIAPIGNJ, [Optional] BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x59CFA00", Offset = "0x59CE800", VA = "0x1859CFA00")]
	public static void FGMKICMLOGA(Exception IHBJIAPIGNJ, [Optional] BGHHFOBJMFK IACFBMPPCKF, [Optional] UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x59D0F10", Offset = "0x59CFD10", VA = "0x1859D0F10")]
	private static void LMMHJDDEMEB(Exception IHBJIAPIGNJ, StringBuilder EDKGIOKKKAJ, int BEGFELCMNHC = 0, int PJEBJJEBDHK = 5)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x59CEFE0", Offset = "0x59CDDE0", VA = "0x1859CEFE0")]
	public static void ANEGLPDHPFH(object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x59CEE60", Offset = "0x59CDC60", VA = "0x1859CEE60")]
	public static void AFFOFDEEGIJ(object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x59CF450", Offset = "0x59CE250", VA = "0x1859CF450")]
	public static OAGKFBPEPEP EADBFNIJGLF(object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(OAGKFBPEPEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x59CF580", Offset = "0x59CE380", VA = "0x1859CF580")]
	public static OAGKFBPEPEP EADBFNIJGLF(BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(OAGKFBPEPEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3689550", Offset = "0x3688350", VA = "0x183689550")]
	public static OAGKFBPEPEP EADBFNIJGLF<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(OAGKFBPEPEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3689410", Offset = "0x3688210", VA = "0x183689410")]
	public static OAGKFBPEPEP EADBFNIJGLF<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(OAGKFBPEPEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x59D1600", Offset = "0x59D0400", VA = "0x1859D1600")]
	public static CCJCAAOOCIO OAFHOECDHLO(object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(CCJCAAOOCIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x59D16B0", Offset = "0x59D04B0", VA = "0x1859D16B0")]
	public static CCJCAAOOCIO OAFHOECDHLO(BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(CCJCAAOOCIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x368B4B0", Offset = "0x368A2B0", VA = "0x18368B4B0")]
	public static CCJCAAOOCIO OAFHOECDHLO<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(CCJCAAOOCIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x368B5D0", Offset = "0x368A3D0", VA = "0x18368B5D0")]
	public static CCJCAAOOCIO OAFHOECDHLO<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(CCJCAAOOCIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x59D2410", Offset = "0x59D1210", VA = "0x1859D2410")]
	public static void PLACGKBCHAH(object IACFBMPPCKF, long AJPLFOCDELA, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x59D2550", Offset = "0x59D1350", VA = "0x1859D2550")]
	public static void PLACGKBCHAH(BGHHFOBJMFK IACFBMPPCKF, long AJPLFOCDELA, [Optional] BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x368B990", Offset = "0x368A790", VA = "0x18368B990")]
	public static void PLACGKBCHAH<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, long AJPLFOCDELA, [Optional] BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x368BAD0", Offset = "0x368A8D0", VA = "0x18368BAD0")]
	public static void PLACGKBCHAH<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, long AJPLFOCDELA, [Optional] BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x59CF0C0", Offset = "0x59CDEC0", VA = "0x1859CF0C0")]
	public static void CJOFKDNLFHK(object IACFBMPPCKF, long AJPLFOCDELA, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x59CF200", Offset = "0x59CE000", VA = "0x1859CF200")]
	public static void CJOFKDNLFHK(BGHHFOBJMFK IACFBMPPCKF, long AJPLFOCDELA, [Optional] BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x36892D0", Offset = "0x36880D0", VA = "0x1836892D0")]
	public static void CJOFKDNLFHK<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, long AJPLFOCDELA, [Optional] BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3689190", Offset = "0x3687F90", VA = "0x183689190")]
	public static void CJOFKDNLFHK<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, long AJPLFOCDELA, [Optional] BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x59D1830", Offset = "0x59D0630", VA = "0x1859D1830")]
	public static void OLBPMFKMEEG(object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x59D1960", Offset = "0x59D0760", VA = "0x1859D1960")]
	public static void OLBPMFKMEEG(BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x368B6F0", Offset = "0x368A4F0", VA = "0x18368B6F0")]
	public static void OLBPMFKMEEG<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x368B790", Offset = "0x368A590", VA = "0x18368B790")]
	public static void OLBPMFKMEEG<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x59D1790", Offset = "0x59D0590", VA = "0x1859D1790")]
	public static void OLBPMFKMEEG(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x59D18C0", Offset = "0x59D06C0", VA = "0x1859D18C0")]
	public static void OLBPMFKMEEG(BGHHFOBJMFK IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x368B8E0", Offset = "0x368A6E0", VA = "0x18368B8E0")]
	public static void OLBPMFKMEEG<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x368B830", Offset = "0x368A630", VA = "0x18368B830")]
	public static void OLBPMFKMEEG<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void KMANIENLMJO(object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void KMANIENLMJO(BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void KMANIENLMJO<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void KMANIENLMJO<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void KMANIENLMJO(object IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void KMANIENLMJO(BGHHFOBJMFK IACFBMPPCKF, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void KMANIENLMJO<T>(PMJGACAJAKN<T> IACFBMPPCKF, in T NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void KMANIENLMJO<T>(KGHKHOGOIKM<T> IACFBMPPCKF, in T NHMGHNFFDAC, UnityEngine.Object IEGGGFEMEIG, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x59CF980", Offset = "0x59CE780", VA = "0x1859CF980")]
	[Obsolete]
	public static AMKKOENBEDF EOABNGLFNCM()
	{
		return default(AMKKOENBEDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x59CF950", Offset = "0x59CE750", VA = "0x1859CF950")]
	[Obsolete]
	public static AMKKOENBEDF EJJGJBCHHFF(in BMFDONNFDEH DPJGMDFEIDL)
	{
		return default(AMKKOENBEDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x59D0740", Offset = "0x59CF540", VA = "0x1859D0740")]
	public static AMKKOENBEDF HOKFNOFCEAH(in BMFDONNFDEH DPJGMDFEIDL)
	{
		return default(AMKKOENBEDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x59D19F0", Offset = "0x59D07F0", VA = "0x1859D19F0")]
	[Obsolete]
	public static KBGHMMPIIPB PDHIBFCGDKL()
	{
		return default(KBGHMMPIIPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x59D0C50", Offset = "0x59CFA50", VA = "0x1859D0C50")]
	public static global::PJALLNDLFLG<bool> JNLNCPCOPPG(bool DPJGMDFEIDL)
	{
		return default(global::PJALLNDLFLG<bool>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x59CFCB0", Offset = "0x59CEAB0", VA = "0x1859CFCB0")]
	[Obsolete]
	public static KBGHMMPIIPB FJBACGBLFNL(in BMFDONNFDEH DPJGMDFEIDL)
	{
		return default(KBGHMMPIIPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x59D15D0", Offset = "0x59D03D0", VA = "0x1859D15D0")]
	public static KBGHMMPIIPB NAPBCONEJHE(in BMFDONNFDEH DPJGMDFEIDL)
	{
		return default(KBGHMMPIIPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x59CF370", Offset = "0x59CE170", VA = "0x1859CF370")]
	[Obsolete]
	public static HHPKELHBDPF CPMAACIHPLJ()
	{
		return default(HHPKELHBDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x59CF340", Offset = "0x59CE140", VA = "0x1859CF340")]
	[Obsolete]
	public static HHPKELHBDPF CPDCCBLGCGP(in BMFDONNFDEH? DPJGMDFEIDL, [Optional] int? OKHAEPNMGMN)
	{
		return default(HHPKELHBDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x59D1520", Offset = "0x59D0320", VA = "0x1859D1520")]
	public static HHPKELHBDPF MMFIJJGMBOD(in BMFDONNFDEH DPJGMDFEIDL, [Optional] int? OKHAEPNMGMN)
	{
		return default(HHPKELHBDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x59D0B10", Offset = "0x59CF910", VA = "0x1859D0B10")]
	public static bool JAECKHMJJGM(bool IDFFICGGMDC, object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x59D0BB0", Offset = "0x59CF9B0", VA = "0x1859D0BB0")]
	public static bool JAECKHMJJGM(bool IDFFICGGMDC, BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x368B000", Offset = "0x3689E00", VA = "0x18368B000")]
	public static bool JAECKHMJJGM<TMessageArgs>(bool IDFFICGGMDC, PMJGACAJAKN<TMessageArgs> IACFBMPPCKF, in TMessageArgs NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x368B160", Offset = "0x3689F60", VA = "0x18368B160")]
	public static bool JAECKHMJJGM<TMessageArgs>(bool IDFFICGGMDC, KGHKHOGOIKM<TMessageArgs> IACFBMPPCKF, in TMessageArgs NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x59D09D0", Offset = "0x59CF7D0", VA = "0x1859D09D0")]
	public static bool INEHEKNKHGK(bool IDFFICGGMDC, object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x59D0A70", Offset = "0x59CF870", VA = "0x1859D0A70")]
	public static bool INEHEKNKHGK(bool IDFFICGGMDC, BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x368AF50", Offset = "0x3689D50", VA = "0x18368AF50")]
	public static bool INEHEKNKHGK<TMessageArgs>(bool IDFFICGGMDC, PMJGACAJAKN<TMessageArgs> IACFBMPPCKF, in TMessageArgs NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x368AEA0", Offset = "0x3689CA0", VA = "0x18368AEA0")]
	public static bool INEHEKNKHGK<TMessageArgs>(bool IDFFICGGMDC, KGHKHOGOIKM<TMessageArgs> IACFBMPPCKF, in TMessageArgs NHMGHNFFDAC, [Optional] in BMFDONNFDEH? POLNGKBPPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x59CF6D0", Offset = "0x59CE4D0", VA = "0x1859CF6D0")]
	public static bool EFBPENNFAPK(bool IDFFICGGMDC, object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x59CF810", Offset = "0x59CE610", VA = "0x1859CF810")]
	public static bool EFBPENNFAPK(bool IDFFICGGMDC, BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x59D0030", Offset = "0x59CEE30", VA = "0x1859D0030")]
	public static bool GAJHIELAPHH(bool IDFFICGGMDC, object IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x59D0170", Offset = "0x59CEF70", VA = "0x1859D0170")]
	public static bool GAJHIELAPHH(bool IDFFICGGMDC, BGHHFOBJMFK IACFBMPPCKF, [Optional] in BMFDONNFDEH? POLNGKBPPLK, [CallerFilePath] string OMONKEHCPCK = "", [CallerLineNumber] int GEBPMFDPLKP = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x59D04F0", Offset = "0x59CF2F0", VA = "0x1859D04F0")]
	public static bool HCIEHGCLAGN(in BMFDONNFDEH POLNGKBPPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x59CFCE0", Offset = "0x59CEAE0", VA = "0x1859CFCE0")]
	private static bool FMGNPHEOIAH(in BMFDONNFDEH? POLNGKBPPLK, in BMFDONNFDEH MLHMDCDINDH, out BMFDONNFDEH MFIFCKBPACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x59D22A0", Offset = "0x59D10A0", VA = "0x1859D22A0")]
	private static object PIKMOJPIGFK(object IACFBMPPCKF, in BMFDONNFDEH POLNGKBPPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x59D0E20", Offset = "0x59CFC20", VA = "0x1859D0E20")]
	public static void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x59D06E0", Offset = "0x59CF4E0", VA = "0x1859D06E0")]
	public static void HIDCPPFEOHB(Exception IHBJIAPIGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x59D1A70", Offset = "0x59D0870", VA = "0x1859D1A70")]
	public static string PGFGBCFOMDM(string EMKINAHLLBJ, LENBAIDGBOE POLNGKBPPLK = LENBAIDGBOE.All)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x743E70", Offset = "0x742C70", VA = "0x180743E70")]
	public static string AKNDMHLHJCI(string CABKGFENIDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x59CEF40", Offset = "0x59CDD40", VA = "0x1859CEF40")]
	public static string AKNDMHLHJCI(string CABKGFENIDE, [Optional] int? CFKBLBNLDAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class IAPHPBIGANM
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal static readonly MCGFPBNIDAB CIILHKEMLHI;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal static readonly MCGFPBNIDAB LCKJPNBOCMO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal static readonly MCGFPBNIDAB NBMMLNJBJFK;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static BMFDONNFDEH DBAHNPOFJGD;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly HAKLCMLKMMD NICJNCLHOFJ;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal static bool IHKMNKLPEAG;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal static bool GENKPIIBGDK;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static int AHJIDDGILDB;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static CBALCJKADEL HMNMMMMNDBH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static JENHNLNHNLH FDDKNNOEAFB;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static bool FDOENEACCNB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static JsonConverter[] JGAEPAHIMMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x59C9FF0", Offset = "0x59C8DF0", VA = "0x1859C9FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x59C9E20", Offset = "0x59C8C20", VA = "0x1859C9E20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static BMFDONNFDEH LLKHKEANFGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x59CA380", Offset = "0x59C9180", VA = "0x1859CA380")]
		get
		{
			return default(BMFDONNFDEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static BMFDONNFDEH BNHEEFIALPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x59C8B40", Offset = "0x59C7940", VA = "0x1859C8B40")]
		get
		{
			return default(BMFDONNFDEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal static BMFDONNFDEH CNCPDBIFMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x59C8DC0", Offset = "0x59C7BC0", VA = "0x1859C8DC0")]
		get
		{
			return default(BMFDONNFDEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static BMFDONNFDEH.DHALGFEDAGI OIFEOEGJLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x59C9810", Offset = "0x59C8610", VA = "0x1859C9810")]
		[CompilerGenerated]
		get
		{
			return default(BMFDONNFDEH.DHALGFEDAGI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x59C96D0", Offset = "0x59C84D0", VA = "0x1859C96D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static HHEHOGJHCLO HJDAKJMFLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x59C9CD0", Offset = "0x59C8AD0", VA = "0x1859C9CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x59C9730", Offset = "0x59C8530", VA = "0x1859C9730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool BBKDEPKBLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x59C95C0", Offset = "0x59C83C0", VA = "0x1859C95C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x59C8C10", Offset = "0x59C7A10", VA = "0x1859C8C10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static bool KGCNNBGDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x59C91D0", Offset = "0x59C7FD0", VA = "0x1859C91D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool PFKIKKOFBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x59C9E90", Offset = "0x59C8C90", VA = "0x1859C9E90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x59C98D0", Offset = "0x59C86D0", VA = "0x1859C98D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static int NCKPIAIICIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x59C9C70", Offset = "0x59C8A70", VA = "0x1859C9C70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x59C8BB0", Offset = "0x59C79B0", VA = "0x1859C8BB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static double KHGEDAHEPNE
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x59C8CE0", Offset = "0x59C7AE0", VA = "0x1859C8CE0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x59C8E20", Offset = "0x59C7C20", VA = "0x1859C8E20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double IEGPCPALBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x59C8E90", Offset = "0x59C7C90", VA = "0x1859C8E90")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static CGCLNFMHFBB JHBDJGDKCCH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x59C9870", Offset = "0x59C8670", VA = "0x1859C9870")]
		[CompilerGenerated]
		get
		{
			return default(CGCLNFMHFBB);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x59C9D30", Offset = "0x59C8B30", VA = "0x1859C9D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static bool KCGAKLINKKN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x59CA320", Offset = "0x59C9120", VA = "0x1859CA320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x59C9620", Offset = "0x59C8420", VA = "0x1859C9620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x59C9940", Offset = "0x59C8740", VA = "0x1859C9940")]
	public static void IPLKOLDOPJM(in BMFDONNFDEH DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x59CA470", Offset = "0x59C9270", VA = "0x1859CA470")]
	public static void NPODIOHJEHK(bool DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x59C9680", Offset = "0x59C8480", VA = "0x1859C9680")]
	private static void FJKJHILJIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x59C8D40", Offset = "0x59C7B40", VA = "0x1859C8D40")]
	public static void CKCKEPDGOPF(in BMFDONNFDEH DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x59CA3F0", Offset = "0x59C91F0", VA = "0x1859CA3F0")]
	public static void NLMMPLKOANB(bool DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x59CA590", Offset = "0x59C9390", VA = "0x1859CA590")]
	private static void PMFGKHNPIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x59CA0D0", Offset = "0x59C8ED0", VA = "0x1859CA0D0")]
	private static void NCDHFHJEPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x59CA4F0", Offset = "0x59C92F0", VA = "0x1859CA4F0")]
	[Conditional("UNITY_EDITOR")]
	public static void OGEIKHLLOGF(BMFDONNFDEH.DHALGFEDAGI LACOAEKOGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x59C97A0", Offset = "0x59C85A0", VA = "0x1859C97A0")]
	public static void HLGEOBCFEEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x59C8F70", Offset = "0x59C7D70", VA = "0x1859C8F70")]
	private static void DOCFILMDMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x59C9170", Offset = "0x59C7F70", VA = "0x1859C9170")]
	internal static int DOEEEKCJIIF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x59C8C70", Offset = "0x59C7A70", VA = "0x1859C8C70")]
	public static void CDAIOCNIJLD(int LCJMNMLOPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x59C99C0", Offset = "0x59C87C0", VA = "0x1859C99C0")]
	public static void JHILGCEFELP(int? IDGOKNAOFGE, int? AOCLGABDDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x59C9270", Offset = "0x59C8070", VA = "0x1859C9270")]
	public static void EJIIGDDGKEM(JENHNLNHNLH CGFIKJKJOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x59C9D90", Offset = "0x59C8B90", VA = "0x1859C9D90")]
	internal static void LGIHJDKCOKI(string IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x59CA050", Offset = "0x59C8E50", VA = "0x1859CA050")]
	public static void MIGAJKCGFIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x59C9BF0", Offset = "0x59C89F0", VA = "0x1859C9BF0")]
	public static string KGBBIANIGLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x59C9EF0", Offset = "0x59C8CF0", VA = "0x1859C9EF0")]
	public static byte[] MAANNNNDFFD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class CAALBJOAPJD : HHEHOGJHCLO
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private sealed class GCHHJOJABHC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public GCHHJOJABHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public BOJMBLPKPCJ.FEEAGEBGPAE MOPKDDBFHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "4")]
	public void CCNJLONFBPI(float IELMACGDCOE, int FAGGJKNHAME, int JMJDIBJBFBP, int AJGMCGEIDKB, string GHLFIFFCLMN, string OBKIAKJHPLD, int OJNCKNNNEFK, int ENPJKHPPOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x59C1900", Offset = "0x59C0700", VA = "0x1859C1900", Slot = "5")]
	public IDisposable NCMKKFGDMKN(float LFDLPHEMJOH, Action<float> JCMJBHPHNGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x59C1950", Offset = "0x59C0750", VA = "0x1859C1950")]
	public CAALBJOAPJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class GAMIKBBBDGF
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly OPPODPOOHDA.PJAPEDNJDLN FKPLJEIMKAK;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly OPPODPOOHDA.PJAPEDNJDLN AKOABJHHJNI;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly OPPODPOOHDA.PJAPEDNJDLN BEMNBDIOOHM;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly OPPODPOOHDA.FCKEOLDPGLL DBALEDBMIEO;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly OPPODPOOHDA.NJJGOALNEGD LBIFFEAKJLN;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly OPPODPOOHDA.JCDLEDHAECN LEEOFPNNKIJ;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly EHCMOFLMHLC MEKIAJGHMEB;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly EFPEMAEHOKL DEEODBKLMME;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x59C4560", Offset = "0x59C3360", VA = "0x1859C4560")]
	public static void OPCJGHHHCDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x59C4330", Offset = "0x59C3130", VA = "0x1859C4330")]
	public static void GICKCNCALPG(string IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x59C4500", Offset = "0x59C3300", VA = "0x1859C4500")]
	public static void OLBPMFKMEEG(string IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x59C43F0", Offset = "0x59C31F0", VA = "0x1859C43F0")]
	public static void IEFBBADHFBO(string IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x59C4390", Offset = "0x59C3190", VA = "0x1859C4390")]
	public static void HIDCPPFEOHB(Exception IHBJIAPIGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void NGKEHCLIMDJ(string CCEKFDNIAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void NHAOIBBCOJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x59C4450", Offset = "0x59C3250", VA = "0x1859C4450")]
	public static string MFIALLEEBPP(object LOPIEGGIDMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x59C4200", Offset = "0x59C3000", VA = "0x1859C4200")]
	public static long DHNMHALDJDH()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HHEHOGJHCLO
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	BOJMBLPKPCJ.FEEAGEBGPAE MOPKDDBFHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCNJLONFBPI(float IELMACGDCOE, int FAGGJKNHAME, int JMJDIBJBFBP, int AJGMCGEIDKB, string GHLFIFFCLMN, string OBKIAKJHPLD, int OJNCKNNNEFK, int ENPJKHPPOOF);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable NCMKKFGDMKN(float LFDLPHEMJOH, Action<float> JCMJBHPHNGA);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class CBALCJKADEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly Dictionary<int, int> JMOPICPGGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int PMHLEGCNJJA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int IKAFLPJEOJD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x770E30", Offset = "0x76FC30", VA = "0x180770E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x59C1D10", Offset = "0x59C0B10", VA = "0x1859C1D10")]
	public CBALCJKADEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x59C1D90", Offset = "0x59C0B90", VA = "0x1859C1D90")]
	public CBALCJKADEL(int BPGKOJPDPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x59C19D0", Offset = "0x59C07D0", VA = "0x1859C19D0")]
	public void FJHMPOJDMKD(int BPGKOJPDPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x59C1C10", Offset = "0x59C0A10", VA = "0x1859C1C10")]
	public void OKEDGHGLMDM(int BPGKOJPDPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x59C1AB0", Offset = "0x59C08B0", VA = "0x1859C1AB0")]
	private int HFMDNAPJLKJ()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class EKNFKFMDNHB
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static JsonConverter CODDEHPHPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x59C27D0", Offset = "0x59C15D0", VA = "0x1859C27D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static JsonConverter CENAGFAGJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x59C2890", Offset = "0x59C1690", VA = "0x1859C2890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static JsonConverter COFNFOECOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x59C2830", Offset = "0x59C1630", VA = "0x1859C2830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static JsonConverter AFMMILLDFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x59C28F0", Offset = "0x59C16F0", VA = "0x1859C28F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class JAEEKIJMILD
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct LLMFDPFCBFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public WeakReference JMPGFAPPHGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int DPDENKEFFIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int KNEKDCGDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public string JBOBPFKLKJA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct DPPHOFHGBMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int EPAPAACLFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int KLNHMILBDPG;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool KOOINOPAEEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x59C25E0", Offset = "0x59C13E0", VA = "0x1859C25E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string FJFFMABNPGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x59C25F0", Offset = "0x59C13F0", VA = "0x1859C25F0")]
			get
			{
				return null;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal const int IEBCFGEODHF = 10000;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal const int LFEAPKCOKOP = 20;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly List<LLMFDPFCBFI> OGBLDKDNCMI;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static readonly List<LLMFDPFCBFI> KFEKDFLOIHA;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static readonly List<LLMFDPFCBFI> JNAMLGLKLNA;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly List<LLMFDPFCBFI> GBPLJOEBBJP;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly List<LLMFDPFCBFI> EAAELHBJLDL;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static string OJIDNBDAHLG;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static bool PGIMCJKJHJK;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static DPPHOFHGBMG DJDIFILCCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x59CBFA0", Offset = "0x59CADA0", VA = "0x1859CBFA0")]
		[CompilerGenerated]
		get
		{
			return default(DPPHOFHGBMG);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x59CC000", Offset = "0x59CAE00", VA = "0x1859CC000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x59CBC90", Offset = "0x59CAA90", VA = "0x1859CBC90")]
	public static void FLOLCMPEDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x59CB9F0", Offset = "0x59CA7F0", VA = "0x1859CB9F0")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("PERF_BUILD")]
	public static void EKGLGHAFJEH(object LOPIEGGIDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x59CBD70", Offset = "0x59CAB70", VA = "0x1859CBD70")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("PERF_BUILD")]
	public static void HGPMKLPGLDB([Optional] string CCEKFDNIAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x59CAFF0", Offset = "0x59C9DF0", VA = "0x1859CAFF0")]
	[Conditional("PERF_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public static void BBGABFOICCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x59CB740", Offset = "0x59CA540", VA = "0x1859CB740")]
	private static void DIOODCILEFP(List<LLMFDPFCBFI> CGOAOLEJHKG, List<LLMFDPFCBFI> KOAELLNOJBK, string DAHEDCFALFK, bool PGLMBKCBMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x59CB2C0", Offset = "0x59CA0C0", VA = "0x1859CB2C0")]
	private static string BCLANBLMHBC(LLMFDPFCBFI BKCHCEAGIMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct BMFDONNFDEH : IEquatable<BMFDONNFDEH>
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Flags]
	public enum DHALGFEDAGI
	{
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		FormatUnityEngineDebugLogCalls = 2,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		ShowPstTimeNow = 4,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		ShowFrame = 8,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		ShowTimeSinceStartup = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		ShowLogType = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		ShowLogFlags = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		All = -1
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly NKMIALNAAEP POLNGKBPPLK;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly BMFDONNFDEH AMNBOJDLCFN;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly BMFDONNFDEH BABILBGGPGN;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly BMFDONNFDEH OGPMHMIHNIN;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly BMFDONNFDEH LJOCPBKJPBG;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly BMFDONNFDEH GODHAMFKLEP;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly BMFDONNFDEH MDLPJIEOLCO;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly BMFDONNFDEH LJLNJBOOKFG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly BMFDONNFDEH DPIAGMHCAEB;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly BMFDONNFDEH BDCKLGJABFB;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly BMFDONNFDEH IMOOHKMBONJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly BMFDONNFDEH INOMIKLADII;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly BMFDONNFDEH OOBBOKDEHLA;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly BMFDONNFDEH NNIAMACHFOF;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly BMFDONNFDEH OFLPCAHKPLK;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly BMFDONNFDEH OGMNMANGGLJ;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly BMFDONNFDEH OLBFEFAGAJI;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static readonly BMFDONNFDEH HDHKIBGGLFI;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static readonly BMFDONNFDEH JFKPGMOPGHB;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static readonly BMFDONNFDEH CLMKLOBMAJC;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly BMFDONNFDEH CMJJIMIDIOK;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly BMFDONNFDEH OLAAFEBOJEE;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static readonly BMFDONNFDEH IPKBLBFKBLJ;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly BMFDONNFDEH PNMEFOEBMGM;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly BMFDONNFDEH JILDEBCIAOJ;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public static readonly BMFDONNFDEH OKLKJAECJCK;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly BMFDONNFDEH CNNHDKGCOCE;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public static readonly BMFDONNFDEH JCANEDCCHBI;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly BMFDONNFDEH IIKNONNPLMB;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly BMFDONNFDEH JIOBIGIICNC;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly BMFDONNFDEH HEFNPADAONC;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly BMFDONNFDEH EKFGFABPKBO;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly BMFDONNFDEH PAGDMAPIBLE;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly BMFDONNFDEH FLBKLEABOGA;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static readonly BMFDONNFDEH MNOEJFIFJCF;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public static readonly BMFDONNFDEH DHJLGIAKGDK;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly BMFDONNFDEH BPGHLNKHBPA;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly BMFDONNFDEH JBLFNGAIDFI;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly BMFDONNFDEH DKNEBFFKMCE;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly BMFDONNFDEH DKBDEJGNECK;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly BMFDONNFDEH IALJDDAFLEN;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public static readonly BMFDONNFDEH LMMFCCAIIME;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly BMFDONNFDEH HHAJLOLDBOA;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly BMFDONNFDEH IENMEHINHED;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly BMFDONNFDEH FMEHIEPHBAO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly BMFDONNFDEH HJIEDDJOBCA;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly BMFDONNFDEH BICKPOKABNB;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static readonly BMFDONNFDEH CDJAMAKOOCN;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly BMFDONNFDEH EPKJEFKIPFJ;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly BMFDONNFDEH ENFJIIFDHKK;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly BMFDONNFDEH MHLLKOMCAMJ;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly BMFDONNFDEH GAOOAMEEDAB;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly BMFDONNFDEH PJHLODNOGIB;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly BMFDONNFDEH GAOIKAIJJGC;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static readonly BMFDONNFDEH NOPLLPEOFPA;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly BMFDONNFDEH CJGLCEFAMDM;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly BMFDONNFDEH IEKFKBDMLFK;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly BMFDONNFDEH MLIFLCFBDLK;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly BMFDONNFDEH OGGEGGLCCKP;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static readonly BMFDONNFDEH LHJJJHDNOJB;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static readonly BMFDONNFDEH OJKMPEBEOFN;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly BMFDONNFDEH CGPEGNAOKKH;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly BMFDONNFDEH NKGJAFFOHDC;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public static readonly BMFDONNFDEH KHNBFJIONBC;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly BMFDONNFDEH BDLKCLFIPFB;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly BMFDONNFDEH FBONCMNMHBN;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public static readonly BMFDONNFDEH NMMOGMOBOOH;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public static readonly BMFDONNFDEH HIKMPNMPBKK;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public static readonly BMFDONNFDEH FECNCAANFPB;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly BMFDONNFDEH MHBCFIJIFKP;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static readonly BMFDONNFDEH ECADDGNPPOO;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public static readonly BMFDONNFDEH ADDHMJNGCHF;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static readonly BMFDONNFDEH HLEMOACDLCO;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly BMFDONNFDEH HNHDLOEMNJP;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public static readonly BMFDONNFDEH MNBJPFJHNNE;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly BMFDONNFDEH CCAAMIBMKLC;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public static readonly BMFDONNFDEH MDAMFJLHJKB;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public static readonly BMFDONNFDEH EIINKBAKEOB;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public static readonly BMFDONNFDEH ILMCJHLODEH;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public static readonly BMFDONNFDEH IOMLPCDEDHM;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public static readonly BMFDONNFDEH LDNLCPIKJGJ;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public static readonly BMFDONNFDEH MHAKHNNJBAN;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public static readonly BMFDONNFDEH DBEDAPLBKPE;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public static readonly BMFDONNFDEH EFIPGFJOIOO;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public static readonly BMFDONNFDEH HCFBPOCLFCG;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public static readonly BMFDONNFDEH NABFHNKLBGG;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public static readonly BMFDONNFDEH FEIHLOJAKPH;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public static readonly BMFDONNFDEH EJAODCGDLDC;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public static readonly BMFDONNFDEH NNLMNGBDBKI;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public static readonly BMFDONNFDEH JLGGJMINNJN;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public static readonly BMFDONNFDEH ONGKNMDMICK;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	internal static readonly BMFDONNFDEH GDFDHIAKAEE;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal static readonly BMFDONNFDEH BGFAABHECHK;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[Obsolete]
	public static readonly BMFDONNFDEH OEEDHIDBDNE;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	internal static readonly BMFDONNFDEH JPDAHNFHBIL;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[Obsolete]
	public static readonly BMFDONNFDEH OAJDNEKFEKM;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly BMFDONNFDEH AKKBLIKNADN;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x59C1530", Offset = "0x59C0330", VA = "0x1859C1530")]
	internal BMFDONNFDEH(BGOPGGFGKOK POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9F4B80", Offset = "0x9F3980", VA = "0x1809F4B80")]
	internal BMFDONNFDEH(NKMIALNAAEP POLNGKBPPLK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x59BF720", Offset = "0x59BE520", VA = "0x1859BF720")]
	public static BMFDONNFDEH LJJFBFNEMCH(BGOPGGFGKOK POLNGKBPPLK)
	{
		return default(BMFDONNFDEH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x59BEDA0", Offset = "0x59BDBA0", VA = "0x1859BEDA0")]
	public static BMFDONNFDEH EJEDPBJLMFO(in BMFDONNFDEH BIKHFKCJEPO, in BMFDONNFDEH BNIMMCIKNIE)
	{
		return default(BMFDONNFDEH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x59BF5C0", Offset = "0x59BE3C0", VA = "0x1859BF5C0")]
	public static BMFDONNFDEH JHAIDCAPEHA(in BMFDONNFDEH BIKHFKCJEPO, in BMFDONNFDEH BNIMMCIKNIE)
	{
		return default(BMFDONNFDEH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x59BF0D0", Offset = "0x59BDED0", VA = "0x1859BF0D0")]
	public static BMFDONNFDEH FFMBIKAFHPE(in BMFDONNFDEH BIKHFKCJEPO, in BMFDONNFDEH BNIMMCIKNIE)
	{
		return default(BMFDONNFDEH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x59BF680", Offset = "0x59BE480", VA = "0x1859BF680")]
	public static BMFDONNFDEH JLIBHKEFBJB(in BMFDONNFDEH BIKHFKCJEPO)
	{
		return default(BMFDONNFDEH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x59BEE60", Offset = "0x59BDC60", VA = "0x1859BEE60")]
	public static bool EKDLGPJCFAN(in BMFDONNFDEH KGHGGFICJIM, in BMFDONNFDEH KEDFPGEDLPI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x59BF800", Offset = "0x59BE600", VA = "0x1859BF800")]
	public static bool OBFGMGBJCFC(in BMFDONNFDEH KGHGGFICJIM, in BMFDONNFDEH KEDFPGEDLPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x59BF030", Offset = "0x59BDE30", VA = "0x1859BF030", Slot = "4")]
	public bool Equals(BMFDONNFDEH KEDFPGEDLPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x59BEF10", Offset = "0x59BDD10", VA = "0x1859BEF10", Slot = "0")]
	public override bool Equals(object KEDFPGEDLPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x59BF460", Offset = "0x59BE260", VA = "0x1859BF460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x59BF490", Offset = "0x59BE290", VA = "0x1859BF490")]
	public bool HCIEHGCLAGN(in BMFDONNFDEH POLNGKBPPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x59BF900", Offset = "0x59BE700", VA = "0x1859BF900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x59BF570", Offset = "0x59BE370", VA = "0x1859BF570")]
	public GALHJHDENFA INPLCIBMKDD()
	{
		return default(GALHJHDENFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x59BF870", Offset = "0x59BE670", VA = "0x1859BF870")]
	internal static string PIKMOJPIGFK(string IACFBMPPCKF, LogType FALBLLMJADO, BMFDONNFDEH PGGAFCKMPPI, DHALGFEDAGI DBAPAGOEMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x59BF3E0", Offset = "0x59BE1E0", VA = "0x1859BF3E0")]
	public static BMFDONNFDEH GGNHNFENGLH(string EJHKMEGCLEP)
	{
		return default(BMFDONNFDEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x59BF750", Offset = "0x59BE550", VA = "0x1859BF750")]
	public string MEDGBBEPIGM(string IACFBMPPCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x59BF190", Offset = "0x59BDF90", VA = "0x1859BF190")]
	public (BMFDONNFDEH, string) FJMHDCGPPOF(LogType? FALBLLMJADO, string DPJGMDFEIDL, DHALGFEDAGI DBAPAGOEMIC)
	{
		return default((BMFDONNFDEH, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x59BEC80", Offset = "0x59BDA80", VA = "0x1859BEC80")]
	private static NKMIALNAAEP EEILILFBJJA(BGOPGGFGKOK POLNGKBPPLK)
	{
		return default(NKMIALNAAEP);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DebuggerTypeProxy(typeof(DDJFHFGGEJO))]
internal struct NKMIALNAAEP
{
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static readonly NKMIALNAAEP NNLMNGBDBKI;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const int JHHCIHEHLIM = 32;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	internal const int GAOCNPNBGEH = 3;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	internal const int EINJGIJDAEB = 12;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	internal unsafe fixed uint MPGLEJDHGML[3];

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	internal unsafe fixed byte GACPBGKAIDC[12];

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private uint CIJAIFGHPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private uint MNAPJNHMPCP;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x59CE710", Offset = "0x59CD510", VA = "0x1859CE710")]
	public NKMIALNAAEP(BGOPGGFGKOK POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x59CE530", Offset = "0x59CD330", VA = "0x1859CE530")]
	public NKMIALNAAEP(ReadOnlySpan<char> AHEGMKIMLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x59CE340", Offset = "0x59CD140", VA = "0x1859CE340")]
	public NDLNNOLBFMA LEIFMBFFFGJ()
	{
		return default(NDLNNOLBFMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x59BF570", Offset = "0x59BE370", VA = "0x1859BF570")]
	public GALHJHDENFA INPLCIBMKDD()
	{
		return default(GALHJHDENFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x59CE4D0", Offset = "0x59CD2D0", VA = "0x1859CE4D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x59CE010", Offset = "0x59CCE10", VA = "0x1859CE010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x59CE180", Offset = "0x59CCF80", VA = "0x1859CE180")]
	public bool HCIEHGCLAGN(in NKMIALNAAEP POLNGKBPPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x59CE370", Offset = "0x59CD170", VA = "0x1859CE370")]
	public void LMMFIPJEJPN(BGOPGGFGKOK JCFDILFMPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3233930", Offset = "0x3232730", VA = "0x183233930")]
	public int LDDEKLALOMA(int CAJAIEDBGDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x59CE3D0", Offset = "0x59CD1D0", VA = "0x1859CE3D0")]
	public void NMIIFALHGAG(int CAJAIEDBGDL, int DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x59CDEE0", Offset = "0x59CCCE0", VA = "0x1859CDEE0", Slot = "0")]
	public override bool Equals(object LOPIEGGIDMF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x59CE420", Offset = "0x59CD220", VA = "0x1859CE420")]
	public static bool OBFGMGBJCFC(in NKMIALNAAEP KGHGGFICJIM, in NKMIALNAAEP KEDFPGEDLPI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x59CDC20", Offset = "0x59CCA20", VA = "0x1859CDC20")]
	public static bool EKDLGPJCFAN(NKMIALNAAEP KGHGGFICJIM, NKMIALNAAEP KEDFPGEDLPI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x59CDBE0", Offset = "0x59CC9E0", VA = "0x1859CDBE0")]
	public static NKMIALNAAEP EJEDPBJLMFO(NKMIALNAAEP KGHGGFICJIM, NKMIALNAAEP KEDFPGEDLPI)
	{
		return default(NKMIALNAAEP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x59CE2A0", Offset = "0x59CD0A0", VA = "0x1859CE2A0")]
	public static NKMIALNAAEP JHAIDCAPEHA(NKMIALNAAEP KGHGGFICJIM, NKMIALNAAEP KEDFPGEDLPI)
	{
		return default(NKMIALNAAEP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x59CDFD0", Offset = "0x59CCDD0", VA = "0x1859CDFD0")]
	public static NKMIALNAAEP FFMBIKAFHPE(NKMIALNAAEP KGHGGFICJIM, NKMIALNAAEP KEDFPGEDLPI)
	{
		return default(NKMIALNAAEP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x59CE2E0", Offset = "0x59CD0E0", VA = "0x1859CE2E0")]
	public static NKMIALNAAEP JLIBHKEFBJB(NKMIALNAAEP BIKHFKCJEPO)
	{
		return default(NKMIALNAAEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x59CE300", Offset = "0x59CD100", VA = "0x1859CE300")]
	private int LCMFAAKIGJN(int CAJAIEDBGDL, int DPJGMDFEIDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x59CE3A0", Offset = "0x59CD1A0", VA = "0x1859CE3A0")]
	private int MNKOJMFPMAD(int CAJAIEDBGDL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class DDJFHFGGEJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly NKMIALNAAEP OEJOAFDIIMH;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string[] DHHKAILJCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x59C1F30", Offset = "0x59C0D30", VA = "0x1859C1F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int[] OLFDBMFHENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x59C2110", Offset = "0x59C0F10", VA = "0x1859C2110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte[] EHDPLMHPLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x59C2080", Offset = "0x59C0E80", VA = "0x1859C2080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public uint[] OCDDHBIMGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x59C1EA0", Offset = "0x59C0CA0", VA = "0x1859C1EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x59C2280", Offset = "0x59C1080", VA = "0x1859C2280")]
	public DDJFHFGGEJO(NKMIALNAAEP OEJOAFDIIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x59C2120", Offset = "0x59C0F20", VA = "0x1859C2120")]
	private int[] OMDOIDEOLGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x59C1F30", Offset = "0x59C0D30", VA = "0x1859C1F30")]
	private string[] MGKHFCOCPHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x59C2080", Offset = "0x59C0E80", VA = "0x1859C2080")]
	private byte[] HMMPBDOACHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x59C1EA0", Offset = "0x59C0CA0", VA = "0x1859C1EA0")]
	private uint[] MDJHHGHFNHK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct NDLNNOLBFMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly NKMIALNAAEP OEJOAFDIIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private byte CAAHKFIOCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private int OBEGEPFDGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private int DJIEOHJNDEK;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int NFPBMNAHIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8E1D20", Offset = "0x8E0B20", VA = "0x1808E1D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x59CDBC0", Offset = "0x59CC9C0", VA = "0x1859CDBC0")]
	public NDLNNOLBFMA(in NKMIALNAAEP OEJOAFDIIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x59CDAD0", Offset = "0x59CC8D0", VA = "0x1859CDAD0")]
	public bool DHFALBNEPMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x59CDB40", Offset = "0x59CC940", VA = "0x1859CDB40")]
	private bool FFJADIPJOGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x59CDB70", Offset = "0x59CC970", VA = "0x1859CDB70")]
	private bool KDLHNCPBGBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal static class FEKMACAOBHI
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private const string NPHPPHMHDCP = "None";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private const string FPNEECIOOBN = "All";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly StringBuilder EDKGIOKKKAJ;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly string[] DMBLFLLCGJN;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly Dictionary<string, int> IIHBCEHHHDD;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x59C3170", Offset = "0x59C1F70", VA = "0x1859C3170")]
	public static NKMIALNAAEP GGNHNFENGLH(string OLGLKPGAOOM)
	{
		return default(NKMIALNAAEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x59C2CB0", Offset = "0x59C1AB0", VA = "0x1859C2CB0")]
	internal static string ENMJHLPNDLG(in NKMIALNAAEP AKFACHDIAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x59C3470", Offset = "0x59C2270", VA = "0x1859C3470")]
	private static Dictionary<string, int> JOCNLIPFLAN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class BLJCFIIDFJB
{
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly StringBuilder EDKGIOKKKAJ;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private const string EKKHELMBHDL = "|>";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private const int JBAONPCMMLN = 6;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int BBKGEINDHMP;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly BMFDONNFDEH KIHFEMGOJLH;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly BMFDONNFDEH DAHGEEHDGHJ;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x59BE380", Offset = "0x59BD180", VA = "0x1859BE380")]
	public static string NAKOICNGHKO(in BMFDONNFDEH DPJGMDFEIDL, string IACFBMPPCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x59BE9D0", Offset = "0x59BD7D0", VA = "0x1859BE9D0")]
	public static string PIKBMKNLIMI(in BMFDONNFDEH DPJGMDFEIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x59BE780", Offset = "0x59BD580", VA = "0x1859BE780")]
	public static BMFDONNFDEH PBJENKFDFFN(string DPJGMDFEIDL)
	{
		return default(BMFDONNFDEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x59BE6C0", Offset = "0x59BD4C0", VA = "0x1859BE6C0")]
	public static string OEHDIMIFGID(in BMFDONNFDEH DPJGMDFEIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x59BE3F0", Offset = "0x59BD1F0", VA = "0x1859BE3F0")]
	public static BMFDONNFDEH NEJIBFDMBDM(string BINNBNPOCNA)
	{
		return default(BMFDONNFDEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x59BDA40", Offset = "0x59BC840", VA = "0x1859BDA40")]
	public static (BMFDONNFDEH, string) IINCPHEHALO(in BMFDONNFDEH PGGAFCKMPPI, LogType? FALBLLMJADO, string DPJGMDFEIDL, BMFDONNFDEH.DHALGFEDAGI DBAPAGOEMIC)
	{
		return default((BMFDONNFDEH, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x59BDCD0", Offset = "0x59BCAD0", VA = "0x1859BDCD0")]
	private static bool IPPMGAJMDMO(string DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x59BD5C0", Offset = "0x59BC3C0", VA = "0x1859BD5C0")]
	private static (BMFDONNFDEH, string) EJCKNDKDIMC(in BMFDONNFDEH PDJDDGLAEKH, LogType FALBLLMJADO, string DPJGMDFEIDL, BMFDONNFDEH.DHALGFEDAGI DBAPAGOEMIC)
	{
		return default((BMFDONNFDEH, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x59BE990", Offset = "0x59BD790", VA = "0x1859BE990")]
	private static NKMIALNAAEP PFPPHKEPOBI(ReadOnlySpan<char> EAFNBMCDOEM)
	{
		return default(NKMIALNAAEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x59BDD70", Offset = "0x59BCB70", VA = "0x1859BDD70")]
	private static BMFDONNFDEH JFGLPOKKAEN(LogType FALBLLMJADO)
	{
		return default(BMFDONNFDEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x59BDE50", Offset = "0x59BCC50", VA = "0x1859BDE50")]
	private static (BMFDONNFDEH, string) LMMEPDGHKCP(in BMFDONNFDEH PDJDDGLAEKH, LogType FALBLLMJADO, string DPJGMDFEIDL, BMFDONNFDEH.DHALGFEDAGI DBAPAGOEMIC)
	{
		return default((BMFDONNFDEH, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x59BE1C0", Offset = "0x59BCFC0", VA = "0x1859BE1C0")]
	private static string NAKOICNGHKO(in NKMIALNAAEP DPJGMDFEIDL, string IACFBMPPCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x59BDC50", Offset = "0x59BCA50", VA = "0x1859BDC50")]
	private static void IOKCOCDJJLO(in NKMIALNAAEP DPJGMDFEIDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class GFOLCCOJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly TimeZoneInfo JHKMJKAAAAC;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x59C5760", Offset = "0x59C4560", VA = "0x1859C5760")]
	public static string PIKMOJPIGFK(string IACFBMPPCKF, LogType FALBLLMJADO, in BMFDONNFDEH PGGAFCKMPPI, BMFDONNFDEH.DHALGFEDAGI DBAPAGOEMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x59C4AE0", Offset = "0x59C38E0", VA = "0x1859C4AE0")]
	private static bool DCICNOKNLJI(in BMFDONNFDEH PGGAFCKMPPI, BMFDONNFDEH.DHALGFEDAGI DBAPAGOEMIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x59C5010", Offset = "0x59C3E10", VA = "0x1859C5010")]
	private static void LJDEBMMDLJJ(StringBuilder EDKGIOKKKAJ, BMFDONNFDEH.DHALGFEDAGI DBAPAGOEMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x59C4CE0", Offset = "0x59C3AE0", VA = "0x1859C4CE0")]
	private static void JDBFHBAIECF(BMFDONNFDEH.DHALGFEDAGI DBAPAGOEMIC, StringBuilder EDKGIOKKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x59C4E20", Offset = "0x59C3C20", VA = "0x1859C4E20")]
	private static void KGMGAPADKHO(BMFDONNFDEH.DHALGFEDAGI DBAPAGOEMIC, StringBuilder EDKGIOKKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x59C5620", Offset = "0x59C4420", VA = "0x1859C5620")]
	private static void ODJLDBJBNHM(LogType FALBLLMJADO, BMFDONNFDEH.DHALGFEDAGI DBAPAGOEMIC, StringBuilder EDKGIOKKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x59C49F0", Offset = "0x59C37F0", VA = "0x1859C49F0")]
	private static void AFMNGEHNAMF(BMFDONNFDEH PGGAFCKMPPI, BMFDONNFDEH.DHALGFEDAGI DBAPAGOEMIC, StringBuilder EDKGIOKKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x59C5730", Offset = "0x59C4530", VA = "0x1859C5730")]
	private static void PEFMCFCMMDL(string IACFBMPPCKF, StringBuilder EDKGIOKKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x59C51D0", Offset = "0x59C3FD0", VA = "0x1859C51D0")]
	private static TimeZoneInfo NJPOJPOHOPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0xD674C0", Offset = "0xD662C0", VA = "0x180D674C0")]
	private static bool IPAKPEEKKCN(BMFDONNFDEH.DHALGFEDAGI KGHGGFICJIM, BMFDONNFDEH.DHALGFEDAGI KEDFPGEDLPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct GALHJHDENFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private NDLNNOLBFMA IOJIEGONCOM;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string NFPBMNAHIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x59C4130", Offset = "0x59C2F30", VA = "0x1859C4130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x59C41B0", Offset = "0x59C2FB0", VA = "0x1859C41B0")]
	internal GALHJHDENFA(in NKMIALNAAEP OEJOAFDIIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x59C4120", Offset = "0x59C2F20", VA = "0x1859C4120")]
	public bool DHFALBNEPMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1337730", Offset = "0x1336530", VA = "0x181337730")]
	public GALHJHDENFA LEIFMBFFFGJ()
	{
		return default(GALHJHDENFA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct GNLEOOBKINN
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Obsolete]
	public ref struct NNADAIFEGDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private ReadOnlySpan<char> AFJFLOCKJNL;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string NFPBMNAHIKK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x7011D0", Offset = "0x6FFFD0", VA = "0x1807011D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x59CEAF0", Offset = "0x59CD8F0", VA = "0x1859CEAF0")]
		public NNADAIFEGDC(string IACFBMPPCKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x59CE8C0", Offset = "0x59CD6C0", VA = "0x1859CE8C0")]
		public bool DHFALBNEPMK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x59CE9D0", Offset = "0x59CD7D0", VA = "0x1859CE9D0")]
		private ReadOnlySpan<char> MIKCJNEALDB(ReadOnlySpan<char> EAFNBMCDOEM)
		{
			return default(ReadOnlySpan<char>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x59CE750", Offset = "0x59CD550", VA = "0x1859CE750")]
		private ReadOnlySpan<char> DDIPCEPEJPF(ReadOnlySpan<char> EAFNBMCDOEM, out ReadOnlySpan<char> AFJFLOCKJNL)
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly string IACFBMPPCKF;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x963B70", Offset = "0x962970", VA = "0x180963B70")]
	public GNLEOOBKINN(string IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x59C5F50", Offset = "0x59C4D50", VA = "0x1859C5F50")]
	public NNADAIFEGDC LEIFMBFFFGJ()
	{
		return default(NNADAIFEGDC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class KANMFJJLEDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly Dictionary<BMFDONNFDEH, int> BENGFDGJIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private BMFDONNFDEH GIDGHALGHIH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public BMFDONNFDEH NJCBLPFCPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xDE4FC0", Offset = "0xDE3DC0", VA = "0x180DE4FC0")]
		get
		{
			return default(BMFDONNFDEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x59CC780", Offset = "0x59CB580", VA = "0x1859CC780")]
	public KANMFJJLEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x59CC690", Offset = "0x59CB490", VA = "0x1859CC690")]
	public KANMFJJLEDD(in BMFDONNFDEH POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x59CC570", Offset = "0x59CB370", VA = "0x1859CC570")]
	public void LENCIGFGKAG(in BMFDONNFDEH POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x59CC430", Offset = "0x59CB230", VA = "0x1859CC430")]
	public void DHFAJICHMDO(in BMFDONNFDEH POLNGKBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x59CC1D0", Offset = "0x59CAFD0", VA = "0x1859CC1D0")]
	private BMFDONNFDEH CFNBEKNCFND()
	{
		return default(BMFDONNFDEH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct AMKKOENBEDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly global::DBHFILIKFAK<PDIIEEBMKOH> KFHADIBBEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly global::DBHFILIKFAK<PDIIEEBMKOH>.BPDBNCNPMGB JLIKCIIEOMD;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x59BD090", Offset = "0x59BBE90", VA = "0x1859BD090")]
	internal AMKKOENBEDF(in BMFDONNFDEH PGGAFCKMPPI, bool JBCHDAAKNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x59BCE10", Offset = "0x59BBC10", VA = "0x1859BCE10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class DBHFILIKFAK<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate T DCLEDNLOKDD();

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void LNGDHIKPALM(in T CPLKBCGCHAN);

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void IJMCIMCCDLF(in T? DKPGNEMPOJO, in T? LNFODOOOBMG);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct BPDBNCNPMGB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly global::DBHFILIKFAK<T> CKLGLAGKHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly bool DIHBIHJIFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly BMFDONNFDEH? EBONIAKIGDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly T? OAADHGOOOLP;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x38D9430", Offset = "0x38D8230", VA = "0x1838D9430")]
		public BPDBNCNPMGB(global::DBHFILIKFAK<T> PHBCKPEIIAK, in BMFDONNFDEH? POLNGKBPPLK, T? CPLKBCGCHAN, bool JBCHDAAKNKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x38D8E40", Offset = "0x38D7C40", VA = "0x1838D8E40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly MCGFPBNIDAB BENGFDGJIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly DCLEDNLOKDD KAAMMAGLKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly LNGDHIKPALM CAOKJKIGGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly IJMCIMCCDLF HFDDLBDPBFB;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x36D6380", Offset = "0x36D5180", VA = "0x1836D6380")]
	public DBHFILIKFAK(MCGFPBNIDAB POLNGKBPPLK, DCLEDNLOKDD OFDBBHNMNMB, LNGDHIKPALM BNFODGGLFJO, IJMCIMCCDLF EKKOFDFAEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB9F0", Offset = "0x3FEA7F0", VA = "0x183FEB9F0")]
	public BPDBNCNPMGB KEGAJBPHJCB(in BMFDONNFDEH? POLNGKBPPLK, in T? CPLKBCGCHAN, bool JBCHDAAKNKO)
	{
		return default(BPDBNCNPMGB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface JENHNLNHNLH
{
	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DELGLDDNCCO(string IACFBMPPCKF);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKNEOMBMOLE(int LCJMNMLOPCJ);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJHAHNAAJMI();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string PCGIECOMKPO();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	byte[] MAOLALFAEDK();
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class FKJKANEMFGF : JENHNLNHNLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly object JDMKIDGJCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly Queue<string> ECMIEEDBGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private int JMJAKMBPLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int CHIFNEDBMNI;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int BJEJGEAMGOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x71D070", Offset = "0x71BE70", VA = "0x18071D070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x59C3A50", Offset = "0x59C2850", VA = "0x1859C3A50", Slot = "4")]
	public void DELGLDDNCCO(string IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x59C39C0", Offset = "0x59C27C0", VA = "0x1859C39C0", Slot = "5")]
	public void AKNEOMBMOLE(int LCJMNMLOPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x59C3BE0", Offset = "0x59C29E0", VA = "0x1859C3BE0")]
	private void JOKIOGDKMEH(int KGEGHGGMEEB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x59C3C80", Offset = "0x59C2A80", VA = "0x1859C3C80", Slot = "6")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x59C3D70", Offset = "0x59C2B70", VA = "0x1859C3D70", Slot = "7")]
	public string PCGIECOMKPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x59C3D20", Offset = "0x59C2B20", VA = "0x1859C3D20", Slot = "8")]
	public byte[] MAOLALFAEDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x59C3F80", Offset = "0x59C2D80", VA = "0x1859C3F80")]
	public FKJKANEMFGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct HHPKELHBDPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly global::DBHFILIKFAK<int> KFHADIBBEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly global::DBHFILIKFAK<int>.BPDBNCNPMGB JLIKCIIEOMD;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x59C8A60", Offset = "0x59C7860", VA = "0x1859C8A60")]
	internal HHPKELHBDPF(in BMFDONNFDEH? MFNHEBBLDAI, int? LCJMNMLOPCJ, bool JBCHDAAKNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x59C87E0", Offset = "0x59C75E0", VA = "0x1859C87E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Flags]
public enum CGCLNFMHFBB
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Error = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Assert = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Warning = 4,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Log = 8,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Exception = 0x10
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class FEFOJIEBKJM
{
	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x59C2BB0", Offset = "0x59C19B0", VA = "0x1859C2BB0")]
	public static bool IDLHAGFIIIL(this CGCLNFMHFBB POLNGKBPPLK, LogType FALBLLMJADO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class BOJMBLPKPCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[ODMMBDBAKBL]
	public interface FEEAGEBGPAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JJFMCMGNNBA(BMFDONNFDEH HKMMMNHINFB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class IKPHAHHHONN : FEEAGEBGPAE
	{
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public static readonly IKPHAHHHONN GEHLGJGIEOF;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		private IKPHAHHHONN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "4")]
		public void JJFMCMGNNBA(BMFDONNFDEH HKMMMNHINFB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class DGCGEOLMEJM
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[ODMMBDBAKBL]
	public interface LNFFAMIFMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IEIOAMEMPKM(FIGOFAGNNMB JJCENFLGJMI, string MGBAFKEIKNI);

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable FGACLPFKAIG(FIGOFAGNNMB JJCENFLGJMI, string AEPLKLLGFMM);
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static LNFFAMIFMDI PDHCOEFNNFH;

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x59C22C0", Offset = "0x59C10C0", VA = "0x1859C22C0")]
	[Conditional("ENABLE_PLATFORM_NATIVE_PROFILER")]
	public static void FFCIFMFCDAA(LNFFAMIFMDI OKLHHFIFADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x59C2400", Offset = "0x59C1200", VA = "0x1859C2400")]
	[Conditional("ENABLE_PLATFORM_NATIVE_PROFILER")]
	public static void GKBBALFHMHN(string MGBAFKEIKNI, FIGOFAGNNMB JJCENFLGJMI = FIGOFAGNNMB.General)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x59C24E0", Offset = "0x59C12E0", VA = "0x1859C24E0")]
	[Conditional("ENABLE_PLATFORM_NATIVE_PROFILER")]
	public static void IBIOCNAPAIO(string AEPLKLLGFMM, ref IDisposable ANDFIEKGHMH, FIGOFAGNNMB JJCENFLGJMI = FIGOFAGNNMB.General)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum FIGOFAGNNMB
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	General,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Frame,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	RecNet,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	BestHTTP,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	JSON,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	BootSequence,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Async,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Fade,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	PhotonRegion,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	PhotonRoomJoin,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	TitleScreen
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class HAKLCMLKMMD : ILogHandler
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private readonly struct IJLPPIDFOHK : IEquatable<IJLPPIDFOHK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public readonly LogType DKGFKPOPBLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly UnityEngine.Object FNFFGILJPDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly string MIMBNBKAENG;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xD6A870", Offset = "0xD69670", VA = "0x180D6A870")]
		public IJLPPIDFOHK(LogType FALBLLMJADO, UnityEngine.Object IEGGGFEMEIG, string IACFBMPPCKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x59CAD40", Offset = "0x59C9B40", VA = "0x1859CAD40", Slot = "4")]
		public bool Equals(IJLPPIDFOHK LOPIEGGIDMF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private readonly struct BBPJEFLODJA : IEquatable<BBPJEFLODJA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly Exception FFBGCDBJGEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public readonly UnityEngine.Object FNFFGILJPDO;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xCDACE0", Offset = "0xCD9AE0", VA = "0x180CDACE0")]
		public BBPJEFLODJA(Exception KODAIHDNBNM, UnityEngine.Object IEGGGFEMEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x59BD300", Offset = "0x59BC100", VA = "0x1859BD300", Slot = "4")]
		public bool Equals(BBPJEFLODJA LOPIEGGIDMF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class PJHJBABKMGG : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x59D29A0", Offset = "0x59D17A0", VA = "0x1859D29A0")]
		public PJHJBABKMGG(string IACFBMPPCKF, Exception KABEOLDCMCF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class DCPFFCCIBDI : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x59C1E20", Offset = "0x59C0C20", VA = "0x1859C1E20")]
		public DCPFFCCIBDI(string IACFBMPPCKF, Exception KABEOLDCMCF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class FPPPNHEFIOC : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x59C40B0", Offset = "0x59C2EB0", VA = "0x1859C40B0")]
		public FPPPNHEFIOC(string IACFBMPPCKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x59C4030", Offset = "0x59C2E30", VA = "0x1859C4030")]
		public FPPPNHEFIOC(string IACFBMPPCKF, Exception KABEOLDCMCF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly object JDMKIDGJCPK;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private const float EMFKPKEJIGE = 6f;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private const int KECAMGFNIIH = 180;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const int CGILPAPNLCG = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly ILogHandler BOBANBNEDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private IDisposable HFPKJNGHPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int EPDMJCMDAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private int EJOEPCJPKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private IJLPPIDFOHK? GHLFIFFCLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int OCAEBJFBBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private BBPJEFLODJA? OBKIAKJHPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int KNIKNCCLKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private bool BBEGNBBGFBF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool HDPFLLBOJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x13AEF90", Offset = "0x13ADD90", VA = "0x1813AEF90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x13AEFB0", Offset = "0x13ADDB0", VA = "0x1813AEFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x59C8750", Offset = "0x59C7550", VA = "0x1859C8750")]
	public HAKLCMLKMMD(ILogHandler BOBANBNEDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x59C83D0", Offset = "0x59C71D0", VA = "0x1859C83D0")]
	public void PKGAAPNFGHE(bool NNMPCEJHIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x59C6820", Offset = "0x59C5620", VA = "0x1859C6820")]
	private void EKJKMOOJCIP(float KNNMPBLOADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x59C72E0", Offset = "0x59C60E0", VA = "0x1859C72E0", Slot = "5")]
	public void LogException(Exception KODAIHDNBNM, UnityEngine.Object IEGGGFEMEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x59C6480", Offset = "0x59C5280", VA = "0x1859C6480")]
	private void CLPNCOEEBJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x59C7880", Offset = "0x59C6680", VA = "0x1859C7880", Slot = "4")]
	public void LogFormat(LogType FALBLLMJADO, UnityEngine.Object IEGGGFEMEIG, string ODADACHNCFJ, params object[] NHMGHNFFDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x59C6B30", Offset = "0x59C5930", VA = "0x1859C6B30")]
	private void IKOIGDEFHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x59C5F80", Offset = "0x59C4D80", VA = "0x1859C5F80")]
	public static Exception AHJNNKCAHMA(Exception KODAIHDNBNM, string IACFBMPPCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x59C66F0", Offset = "0x59C54F0", VA = "0x1859C66F0")]
	private static string DFKJHKCKOJE(Exception KODAIHDNBNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x59C82E0", Offset = "0x59C70E0", VA = "0x1859C82E0")]
	private static bool NKMPOJFAFID(Exception KODAIHDNBNM, StringBuilder EDKGIOKKKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x59C6370", Offset = "0x59C5170", VA = "0x1859C6370")]
	[Conditional("UNITY_EDITOR")]
	private static void AOLMJFPMJKF(LogType LAKBKKJKBPK, object IACFBMPPCKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct PJALLNDLFLG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly Action<T> BNBKCANFBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly T EPJLLOJPHCA;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4810", Offset = "0x3FC3610", VA = "0x183FC4810")]
	public PJALLNDLFLG(Action<T> BNBKCANFBLO, T EPJLLOJPHCA, T ABCKFOPNDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x3FC46D0", Offset = "0x3FC34D0", VA = "0x183FC46D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct KBGHMMPIIPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly global::DBHFILIKFAK<PDIIEEBMKOH> KFHADIBBEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly global::DBHFILIKFAK<PDIIEEBMKOH>.BPDBNCNPMGB JLIKCIIEOMD;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x59CCAD0", Offset = "0x59CB8D0", VA = "0x1859CCAD0")]
	internal KBGHMMPIIPB(in BMFDONNFDEH PGGAFCKMPPI, bool JBCHDAAKNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x59CC850", Offset = "0x59CB650", VA = "0x1859CC850", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class ThreadSafeTimeUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x59D2A20", Offset = "0x59D1820", VA = "0x1859D2A20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x59D2B90", Offset = "0x59D1990", VA = "0x1859D2B90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public ThreadSafeTimeUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[Flags]
public enum BGOPGGFGKOK
{
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Unity = 1,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Error = 2,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Warning = 3,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Debug = 4,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	PUNNetworkManager = 5,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	PhotonRpcs = 6,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	PhotonCustomProperties = 7,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	PhotonOwnership = 8,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	PhotonNetworkInstantiate = 9,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	PhotonCreateAndDestroy = 0xA,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	PhotonNetwork = 0xB,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	SynchronizedFields = 0xC,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	UJect = 0xD,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	RoomLoad = 0xE,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	RecNet = 0xF,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	ObjectModel = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Metrics = 0x11,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	RRCompilationPipeline = 0x12,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	CircuitsV2DebugLogNode = 0x13,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	CircuitsV2Reduce = 0x14,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	CircuitsV2RecRoomIntegration = 0x15,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	CircuitsV2Lifecycle = 0x16,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	CircuitsV2Visualization = 0x17,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	CircuitsV2Heat = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	CircuitsV2Memory = 0x19,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	CircuitsV2CloudData = 0x1A,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	CircuitsV2Environments = 0x1B,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	CircuitsV2EventBus = 0x1C,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	CircuitsV2Graph = 0x1D,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	CircuitsV2Root = 0x1E,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	CircuitsV2State = 0x1F,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	RoomReset = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	UgcWatchdog = 0x21,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	AvatarRendering = 0x22,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	HashCheck = 0x23,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	ConvexHullGeneration = 0x24,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	SpawnableToolInstantiate = 0x25,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	BufferedEventHelper = 0x26,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	BufferedEventHelperSendRecv = 0x27,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	PhotonClient = 0x28,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	RoomManager = 0x29,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	QuestManager = 0x2A,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	RoomOperation = 0x2B,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	BigDataTrackedObject = 0x2C,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	LoadingScreen = 0x2D,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	PersistenceView = 0x2E,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MakerPen = 0x2F,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Autosave = 0x30,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Connectables = 0x31,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	PlayerLoopInjector = 0x32,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Tags = 0x33,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	ToxMod = 0x34,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Roles = 0x35,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	BootSequence = 0x36,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	SplitTesting = 0x37,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	RRUI = 0x38,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	Amplitude = 0x39,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	ArtAssets = 0x3A,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	GiftBox = 0x3B,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	RoomPermissions = 0x3C,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	Patching = 0x3D,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	LogGameObjectAddComponentPatch = 0x3E,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	LogTransformSetPositionPatch = 0x3F,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	LogTransformSetRotationPatch = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	LogTransformSetLocalPositionPatch = 0x41,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	LogTransformSetLocalRotationPatch = 0x42,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	LogTransformSetLocalScalePatch = 0x43,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	LogTransformSetParentPatch = 0x44,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	LogGameObjectDestroyPatch = 0x45,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	LogTaskCancelPatch = 0x46,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	LogCancellationTokenSourceDisposePatch = 0x47,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	ImageCompression = 0x48,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	AutomationTesting = 0x49,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	RRAssetDatabase = 0x4A,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Economy = 0x4B,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	EconomyRRO = 0x4C,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	EconomyUGC = 0x4D,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	EconomyPlayer = 0x4E,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	EconomyCommerce = 0x4F,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Platform = 0x50,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Tools = 0x51,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Experience = 0x52,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	RecRoomStudio = 0x53,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Art = 0x54,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Avatar = 0x55,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	MobileHome = 0x56,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	TrustAndSafety = 0x57,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Maker = 0x58,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Logic = 0x59,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Data = 0x5A,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Lifecycle = 0x5B,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Foundation = 0x5C,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	COUNT = 0x5D,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	All = -2
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class NCKGPBKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static byte[] EALBAFGLJIB;

	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static int HJJBAIGPCIK;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static int DMHGBIHBKDJ;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static BigInteger HJDFPPAMGPN;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NCKGPBKGCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x59CD7F0", Offset = "0x59CC5F0", VA = "0x1859CD7F0")]
	private static string NEFLGCBJNIO(byte[] BFLEMGIJKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x59CD4A0", Offset = "0x59CC2A0", VA = "0x1859CD4A0")]
	public static string BMCDLAKFGCG(byte[] GACPBGKAIDC, bool DFCFJJAKINH)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
