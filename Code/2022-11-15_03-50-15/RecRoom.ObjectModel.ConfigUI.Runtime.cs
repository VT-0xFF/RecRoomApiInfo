using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.ObjectModel.ConfigUI;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal abstract class PFAJNHMDJKG : global::IHCJFLNAALG<Enum>, NOFMONBGKHN, GECONGAEBAE, DOEJKMGLGNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool CKODADDIGND(Type NFMPIOLJBMO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FE10", Offset = "0x5F2E810", VA = "0x185F2FE10")]
	protected PFAJNHMDJKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class IHCJFLNAALG<T> : GECONGAEBAE, DOEJKMGLGNJ where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void PAEABKONOCI(Func<T> NLFHAFBLCLG, Action<T> CFFEECEPDJE, string KKJOOAJGLJI, FNEDFINGEKN GNIPEANGOCM, Func<bool> KJMJFLNCMHN);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void HKKHIIOGFKL(Func<int> NLFHAFBLCLG, Action<int> CFFEECEPDJE, string KKJOOAJGLJI, FNEDFINGEKN GNIPEANGOCM, Func<bool> KJMJFLNCMHN);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class MPAHMKNHCFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public OIAFHGFMCMO targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public FNEDFINGEKN property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public MPAHMKNHCFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x20568C0", Offset = "0x20552C0", VA = "0x1820568C0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2056A30", Offset = "0x2055430", VA = "0x182056A30")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69FE40", Offset = "0x69E840", VA = "0x18069FE40")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class FIGBFHBBKHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::IHCJFLNAALG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public MKPPAENLPMC ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public FIGBFHBBKHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6490", Offset = "0x1DD4E90", VA = "0x181DD6490")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, FNEDFINGEKN property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class AEONGPKBOEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public AEONGPKBOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2022910", Offset = "0x2021310", VA = "0x182022910")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x20229D0", Offset = "0x20213D0", VA = "0x1820229D0")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1727320", Offset = "0x1725D20", VA = "0x181727320")]
	protected IHCJFLNAALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1726CA0", Offset = "0x17256A0", VA = "0x181726CA0", Slot = "5")]
	public virtual void AGDMHAPJKFD(OIAFHGFMCMO FMOACDCKGEF, FNEDFINGEKN GNIPEANGOCM, MKPPAENLPMC HMABADJNBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1726950", Offset = "0x1725350", VA = "0x181726950", Slot = "6")]
	protected virtual PAEABKONOCI AFHLCCFGDBL(MKPPAENLPMC HMABADJNBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1726EF0", Offset = "0x17258F0", VA = "0x181726EF0", Slot = "7")]
	protected virtual HKKHIIOGFKL BBJAKKMANJP(MKPPAENLPMC HMABADJNBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1727170", Offset = "0x1725B70", VA = "0x181727170")]
	private static Enum OIOAKCHHBOO(OIAFHGFMCMO FMOACDCKGEF, FNEDFINGEKN GNIPEANGOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1726F90", Offset = "0x1725990", VA = "0x181726F90")]
	private static void NBKECHEPMLL(OIAFHGFMCMO FMOACDCKGEF, FNEDFINGEKN GNIPEANGOCM, Enum NKJMIDIDBOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class EJLGEHDDGJE : AGGODHIMNJJ, DOEJKMGLGNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private FNEDFINGEKN[] AEFNDCAGDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private FNEDFINGEKN[] ODBDKMOFPPB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FNEDFINGEKN[] JENGMCJOFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public FNEDFINGEKN[] JPABJHPKLKH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract GMGAEIHDIEM[] GHMADJHNENA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract GMGAEIHDIEM[] FIIMCGHJLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FE50", Offset = "0x5F2E850", VA = "0x185F2FE50", Slot = "6")]
	public void LCHEDBCCHIE(AJHEAAFBPJF NCMLMNDELHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void AGDMHAPJKFD(OIAFHGFMCMO FMOACDCKGEF, MKPPAENLPMC HMABADJNBKF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x10EFC00", Offset = "0x10EE600", VA = "0x1810EFC00")]
	protected static T BHPNHJIMCPM<T>(OIAFHGFMCMO FMOACDCKGEF, FNEDFINGEKN GNIPEANGOCM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x10EFC50", Offset = "0x10EE650", VA = "0x1810EFC50")]
	protected static void PNPIFCAINMP<T>(OIAFHGFMCMO FMOACDCKGEF, FNEDFINGEKN GNIPEANGOCM, T NKJMIDIDBOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	protected EJLGEHDDGJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class GLIPAOFELDN<T> : GECONGAEBAE, DOEJKMGLGNJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void AMMFIGBMIGG(Func<T> NLFHAFBLCLG, Action<T> CFFEECEPDJE, string KKJOOAJGLJI, FNEDFINGEKN GNIPEANGOCM, Func<bool> KJMJFLNCMHN);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class CDBCJLPHLDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public OIAFHGFMCMO targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public FNEDFINGEKN property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public CDBCJLPHLDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x21DC940", Offset = "0x21DB340", VA = "0x1821DC940")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x21DCB40", Offset = "0x21DB540", VA = "0x1821DCB40")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x69FE40", Offset = "0x69E840", VA = "0x18069FE40")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B13E20", Offset = "0x2B12820", VA = "0x182B13E20")]
	protected GLIPAOFELDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B12D90", Offset = "0x2B11790", VA = "0x182B12D90", Slot = "4")]
	public void AGDMHAPJKFD(OIAFHGFMCMO FMOACDCKGEF, FNEDFINGEKN GNIPEANGOCM, MKPPAENLPMC HMABADJNBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract AMMFIGBMIGG AFHLCCFGDBL(MKPPAENLPMC HMABADJNBKF);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2B136D0", Offset = "0x2B120D0", VA = "0x182B136D0")]
	private static T BHPNHJIMCPM(OIAFHGFMCMO FMOACDCKGEF, FNEDFINGEKN GNIPEANGOCM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B13D10", Offset = "0x2B12710", VA = "0x182B13D10")]
	private static void PNPIFCAINMP(OIAFHGFMCMO FMOACDCKGEF, FNEDFINGEKN GNIPEANGOCM, T NKJMIDIDBOE)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[OJEJDFBPPED(FHFOPEOFOPD.ConfigUI)]
	[DNKFJNHNNCA(typeof(BJBNCCBODMM), new string[] { })]
	internal class ConfigUIService : BJBNCCBODMM, CFMOGGHLNDM, BGKGLCNGELH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[MJIDFIFGMKP]
		private AJHEAAFBPJF NCMLMNDELHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[MJIDFIFGMKP]
		private FJPDOHJFMNH OFHOKDOKCDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[MJIDFIFGMKP]
		private MKPPAENLPMC IJIMKJLJENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private DAOCDFBDOPE NMNNIMBMBBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private OIAFHGFMCMO FMOACDCKGEF;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5F2DE00", Offset = "0x5F2C800", VA = "0x185F2DE00", Slot = "5")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5F2E5B0", Offset = "0x5F2CFB0", VA = "0x185F2E5B0", Slot = "6")]
		public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5F2DE90", Offset = "0x5F2C890", VA = "0x185F2DE90", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5F2E040", Offset = "0x5F2CA40", VA = "0x185F2E040", Slot = "4")]
		public void LNHOCKCNDCC(OIAFHGFMCMO DGJDBJGPJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5F2DFB0", Offset = "0x5F2C9B0", VA = "0x185F2DFB0")]
		private void KPLBNKHEFKP(OIAFHGFMCMO DGJDBJGPJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5F2DF80", Offset = "0x5F2C980", VA = "0x185F2DF80")]
		private void GNEILFJKAJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5F2DB80", Offset = "0x5F2C580", VA = "0x185F2DB80")]
		private void AGDMHAPJKFD(BHANEJPFMBM KMFKOFHKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BKGNIHLAKDK(0)]
internal class DPGJKADMPGM : PFAJNHMDJKG
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FD60", Offset = "0x5F2E760", VA = "0x185F2FD60", Slot = "9")]
	public override bool CKODADDIGND(Type NFMPIOLJBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FC70", Offset = "0x5F2E670", VA = "0x185F2FC70", Slot = "6")]
	protected override PAEABKONOCI AFHLCCFGDBL(MKPPAENLPMC HMABADJNBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FE10", Offset = "0x5F2E810", VA = "0x185F2FE10")]
	public DPGJKADMPGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[BKGNIHLAKDK(0)]
internal class ENDFJFMNFOA : PFAJNHMDJKG
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5F30350", Offset = "0x5F2ED50", VA = "0x185F30350", Slot = "9")]
	public override bool CKODADDIGND(Type NFMPIOLJBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5F30260", Offset = "0x5F2EC60", VA = "0x185F30260", Slot = "6")]
	protected override PAEABKONOCI AFHLCCFGDBL(MKPPAENLPMC HMABADJNBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FE10", Offset = "0x5F2E810", VA = "0x185F2FE10")]
	public ENDFJFMNFOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[PGFBPNAABFK(typeof(EJGOAPJGGFC), 1)]
internal class GNPOBFLJNNJ : global::IHCJFLNAALG<EJGOAPJGGFC>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5F30940", Offset = "0x5F2F340", VA = "0x185F30940", Slot = "7")]
	protected override HKKHIIOGFKL BBJAKKMANJP(MKPPAENLPMC HMABADJNBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5F30A30", Offset = "0x5F2F430", VA = "0x185F30A30")]
	public GNPOBFLJNNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FPKMHMCFICD
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5F30620", Offset = "0x5F2F020", VA = "0x185F30620")]
	public static bool DGDMMHNHOGF(this FNEDFINGEKN GNIPEANGOCM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[HEGEILJIMIO(2)]
internal class CHJKDJLNFHB : EJLGEHDDGJE
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class BBNGEMMPJFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public OIAFHGFMCMO targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public CHJKDJLNFHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public BBNGEMMPJFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D210", Offset = "0x5F2BC10", VA = "0x185F2D210")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D340", Offset = "0x5F2BD40", VA = "0x185F2D340")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x69FE40", Offset = "0x69E840", VA = "0x18069FE40")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override GMGAEIHDIEM[] FIIMCGHJLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D9A0", Offset = "0x5F2C3A0", VA = "0x185F2D9A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override GMGAEIHDIEM[] GHMADJHNENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D8C0", Offset = "0x5F2C2C0", VA = "0x185F2D8C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5F2D500", Offset = "0x5F2BF00", VA = "0x185F2D500", Slot = "10")]
	public override void AGDMHAPJKFD(OIAFHGFMCMO FMOACDCKGEF, MKPPAENLPMC HMABADJNBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public CHJKDJLNFHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[PGFBPNAABFK(typeof(bool))]
internal class ABBEONONADM : global::GLIPAOFELDN<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5F2D0E0", Offset = "0x5F2BAE0", VA = "0x185F2D0E0", Slot = "5")]
	protected override AMMFIGBMIGG AFHLCCFGDBL(MKPPAENLPMC HMABADJNBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5F2D1D0", Offset = "0x5F2BBD0", VA = "0x185F2D1D0")]
	public ABBEONONADM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[PGFBPNAABFK(typeof(FixedString32))]
internal class DFIMIIKIMEO : global::GLIPAOFELDN<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class KKBPFDGMELD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public MKPPAENLPMC ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public KKBPFDGMELD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5F322E0", Offset = "0x5F30CE0", VA = "0x185F322E0")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, FNEDFINGEKN property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PFMIGOFKAJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public PFMIGOFKAJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5F33420", Offset = "0x5F31E20", VA = "0x185F33420")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5F33490", Offset = "0x5F31E90", VA = "0x185F33490")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FAC0", Offset = "0x5F2E4C0", VA = "0x185F2FAC0", Slot = "5")]
	protected override AMMFIGBMIGG AFHLCCFGDBL(MKPPAENLPMC HMABADJNBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FB80", Offset = "0x5F2E580", VA = "0x185F2FB80")]
	public DFIMIIKIMEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[PGFBPNAABFK(typeof(FixedString64))]
internal class JLOOHALMKAJ : global::GLIPAOFELDN<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class HHMIMFJAOIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MKPPAENLPMC ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public HHMIMFJAOIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5F30A70", Offset = "0x5F2F470", VA = "0x185F30A70")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, FNEDFINGEKN property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class CAPBLOEAIFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public CAPBLOEAIFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D3D0", Offset = "0x5F2BDD0", VA = "0x185F2D3D0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D460", Offset = "0x5F2BE60", VA = "0x185F2D460")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5F31DD0", Offset = "0x5F307D0", VA = "0x185F31DD0", Slot = "5")]
	protected override AMMFIGBMIGG AFHLCCFGDBL(MKPPAENLPMC HMABADJNBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5F31E90", Offset = "0x5F30890", VA = "0x185F31E90")]
	public JLOOHALMKAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[PGFBPNAABFK(typeof(float))]
internal class KMIEJJEPMND : global::GLIPAOFELDN<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5F32470", Offset = "0x5F30E70", VA = "0x185F32470", Slot = "5")]
	protected override AMMFIGBMIGG AFHLCCFGDBL(MKPPAENLPMC HMABADJNBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5F32560", Offset = "0x5F30F60", VA = "0x185F32560")]
	public KMIEJJEPMND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[PGFBPNAABFK(typeof(int))]
internal class MFHHLNIOFLJ : global::GLIPAOFELDN<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5F32A40", Offset = "0x5F31440", VA = "0x185F32A40", Slot = "5")]
	protected override AMMFIGBMIGG AFHLCCFGDBL(MKPPAENLPMC HMABADJNBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5F32B30", Offset = "0x5F31530", VA = "0x185F32B30")]
	public MFHHLNIOFLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[PGFBPNAABFK(typeof(uint))]
internal class NDHGIFBDIMM : global::GLIPAOFELDN<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GJIMDLLHPMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MKPPAENLPMC ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public GJIMDLLHPMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5F30760", Offset = "0x5F2F160", VA = "0x185F30760")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, FNEDFINGEKN property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DGANCMEMPNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public DGANCMEMPNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5F2FBC0", Offset = "0x5F2E5C0", VA = "0x185F2FBC0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5F2FC10", Offset = "0x5F2E610", VA = "0x185F2FC10")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5F32B70", Offset = "0x5F31570", VA = "0x185F32B70", Slot = "5")]
	protected override AMMFIGBMIGG AFHLCCFGDBL(MKPPAENLPMC HMABADJNBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5F32C30", Offset = "0x5F31630", VA = "0x185F32C30")]
	public NDHGIFBDIMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[PGFBPNAABFK(typeof(Vector3))]
internal class CNKPADFNOEA : global::GLIPAOFELDN<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JIEDLLCGJOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public MKPPAENLPMC ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public JIEDLLCGJOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5F31A80", Offset = "0x5F30480", VA = "0x185F31A80")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, FNEDFINGEKN property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class FCBOLIMDPDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public FCBOLIMDPDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5F30400", Offset = "0x5F2EE00", VA = "0x185F30400")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5F30460", Offset = "0x5F2EE60", VA = "0x185F30460")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5F30470", Offset = "0x5F2EE70", VA = "0x185F30470")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5F304D0", Offset = "0x5F2EED0", VA = "0x185F304D0")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5F304E0", Offset = "0x5F2EEE0", VA = "0x185F304E0")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5F30540", Offset = "0x5F2EF40", VA = "0x185F30540")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5F2DA80", Offset = "0x5F2C480", VA = "0x185F2DA80", Slot = "5")]
	protected override AMMFIGBMIGG AFHLCCFGDBL(MKPPAENLPMC HMABADJNBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5F2DB40", Offset = "0x5F2C540", VA = "0x185F2DB40")]
	public CNKPADFNOEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct BHANEJPFMBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int LAAMOLJCKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int OOLCFNBIIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int NKLKLHAEGOD;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class LPJBBBEBHJO
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5F32960", Offset = "0x5F31360", VA = "0x185F32960")]
	public static void JDODGEKOAGI(Type LCIFNOLJFAD, Type NCACEANBPGF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct LLPLIDPBCJP
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5F32780", Offset = "0x5F31180", VA = "0x185F32780")]
	public static NativeList<int> NNOAPPADKPN(OIAFHGFMCMO FMOACDCKGEF, FJPDOHJFMNH OFHOKDOKCDH)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5F325A0", Offset = "0x5F30FA0", VA = "0x185F325A0")]
	private static bool HOIBCKFCFKM(FNEDFINGEKN GNIPEANGOCM, OIAFHGFMCMO FMOACDCKGEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class IFNEFIIMCOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly FJPDOHJFMNH OFHOKDOKCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly AJHEAAFBPJF NCMLMNDELHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly MKPPAENLPMC HMABADJNBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<BHANEJPFMBM> ICALLCFEJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<GANBGJGAJLD> BPDFOLFCPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<GANBGJGAJLD, List<BHANEJPFMBM>> CEIBFDNFMKF;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5F31620", Offset = "0x5F30020", VA = "0x185F31620")]
	public IFNEFIIMCOD(FJPDOHJFMNH OFHOKDOKCDH, AJHEAAFBPJF NCMLMNDELHI, MKPPAENLPMC HMABADJNBKF, Action<BHANEJPFMBM> ICALLCFEJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5F31180", Offset = "0x5F2FB80", VA = "0x185F31180")]
	public void NHPLFNJCIJN(NativeList<BHANEJPFMBM> ICIOPHFNDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5F31500", Offset = "0x5F2FF00", VA = "0x185F31500")]
	private void PGFJKMGBELH(GANBGJGAJLD HLJJLMFOIKG, BHANEJPFMBM KMFKOFHKOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5F31120", Offset = "0x5F2FB20", VA = "0x185F31120")]
	public void KLBOGEMJJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5F30C00", Offset = "0x5F2F600", VA = "0x185F30C00")]
	private void AKHOHOFLDPA(GANBGJGAJLD HLJJLMFOIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5F31080", Offset = "0x5F2FA80", VA = "0x185F31080")]
	private void CNBGDIMGBBJ(GANBGJGAJLD HLJJLMFOIKG)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[OJEJDFBPPED(FHFOPEOFOPD.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class KDLGMKCDDFO : IEnumerable<FNEDFINGEKN>, IEnumerable, IEnumerator<FNEDFINGEKN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private FNEDFINGEKN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public PropertiesByType <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private Type type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Type <>3__type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private NativeMultiHashMap<long, int>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private FNEDFINGEKN System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x877FD0", Offset = "0x8769D0", VA = "0x180877FD0")]
			[DebuggerHidden]
			public KDLGMKCDDFO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5F32210", Offset = "0x5F30C10", VA = "0x185F32210", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5F31ED0", Offset = "0x5F308D0", VA = "0x185F31ED0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5F32290", Offset = "0x5F30C90", VA = "0x185F32290")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5F321D0", Offset = "0x5F30BD0", VA = "0x185F321D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5F32120", Offset = "0x5F30B20", VA = "0x185F32120", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FNEDFINGEKN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5F32120", Offset = "0x5F30B20", VA = "0x185F32120", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly AJHEAAFBPJF NCMLMNDELHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> CGBANMCEBML;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5F336F0", Offset = "0x5F320F0", VA = "0x185F336F0")]
		public PropertiesByType(AJHEAAFBPJF NCMLMNDELHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5F33550", Offset = "0x5F31F50", VA = "0x185F33550")]
		[IteratorStateMachine(typeof(KDLGMKCDDFO))]
		public IEnumerable<FNEDFINGEKN> HAIMBHFECEB(Type NFMPIOLJBMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5F33510", Offset = "0x5F31F10", VA = "0x185F33510", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5F335E0", Offset = "0x5F31FE0", VA = "0x185F335E0")]
		private long OBGHALEPIAD(FNEDFINGEKN GNIPEANGOCM)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5F33660", Offset = "0x5F32060", VA = "0x185F33660")]
		private long OBGHALEPIAD(Type NFMPIOLJBMO)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct IKLPEIELELM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray LNCKFCGKJCI;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5F31A40", Offset = "0x5F30440", VA = "0x185F31A40")]
	public IKLPEIELELM(int OOJKDAEFAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5F31820", Offset = "0x5F30220", VA = "0x185F31820")]
	public static IKLPEIELELM FLCBJMFNILH(int CDECJIFLFKI, NativeArray<int> CDGNAONMFHE)
	{
		return default(IKLPEIELELM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5F31810", Offset = "0x5F30210", VA = "0x185F31810")]
	public bool EFPDKDNMCDA(int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5F31A30", Offset = "0x5F30430", VA = "0x185F31A30")]
	public void LMCGMFHIJLB(int NENMOOINMCH, bool NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5F31740", Offset = "0x5F30140", VA = "0x185F31740")]
	public bool ANMPHCEGDCC(FNEDFINGEKN[] CDGNAONMFHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5F31970", Offset = "0x5F30370", VA = "0x185F31970")]
	public bool IPJALBMOOGB(FNEDFINGEKN[] CDGNAONMFHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5F31800", Offset = "0x5F30200", VA = "0x185F31800", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class DAOCDFBDOPE
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly LOOGELFKPLM ENHDLHMFJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly FJPDOHJFMNH OFHOKDOKCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly AJHEAAFBPJF NCMLMNDELHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<DOEJKMGLGNJ> EEMCPPEAICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType CGBANMCEBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> LHPMAEKAMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> IIKILDOCBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool HHKBONGDECE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<DOEJKMGLGNJ> CEFNIDIBLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5F2F970", Offset = "0x5F2E370", VA = "0x185F2F970")]
	public DAOCDFBDOPE(FJPDOHJFMNH OFHOKDOKCDH, AJHEAAFBPJF NCMLMNDELHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5F2ED60", Offset = "0x5F2D760", VA = "0x185F2ED60")]
	public void DMDPJFLHNDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5F2F6E0", Offset = "0x5F2E0E0", VA = "0x185F2F6E0")]
	public void KCIOFBEOFCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5F2EF30", Offset = "0x5F2D930", VA = "0x185F2EF30")]
	public NativeList<BHANEJPFMBM> ICDHGELKAAG(NativeArray<int> CDGNAONMFHE)
	{
		return default(NativeList<BHANEJPFMBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5F2F850", Offset = "0x5F2E250", VA = "0x185F2F850")]
	private bool OPPLIEKEAPJ(DOEJKMGLGNJ PLLANJNEEID, IKLPEIELELM OKGDPMHFOBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2162250", Offset = "0x2160C50", VA = "0x182162250")]
	private void NHMLMGKBOPF<TInterface, TAttribute>(Action<TInterface, TAttribute> OLLLLKMDDMI) where TInterface : DOEJKMGLGNJ where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5F2EE30", Offset = "0x5F2D830", VA = "0x185F2EE30")]
	private void FFFOHBEGJMI(Type NFMPIOLJBMO, Type EHNNADNMODB, Type MBFGEGHNBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x21621F0", Offset = "0x2160BF0", VA = "0x1821621F0")]
	private TInterface LKFOHMOEPAH<TInterface>(Type NFMPIOLJBMO)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5F2EE60", Offset = "0x5F2D860", VA = "0x185F2EE60")]
	private void GPKGLBPPNNB(DOEJKMGLGNJ PLLANJNEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5F2F640", Offset = "0x5F2E040", VA = "0x185F2F640")]
	private int JAGCEGDGKOL(DOEJKMGLGNJ LFDNFHAHAKH, int NKLKLHAEGOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5F2F390", Offset = "0x5F2DD90", VA = "0x185F2F390")]
	private void IIJDFHHLOHP(GECONGAEBAE PLLANJNEEID, PGFBPNAABFK CLBGPBICHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5F2E900", Offset = "0x5F2D300", VA = "0x185F2E900")]
	private void ACANKNIJHHK(NOFMONBGKHN PLLANJNEEID, BKGNIHLAKDK CLBGPBICHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5F2EBC0", Offset = "0x5F2D5C0", VA = "0x185F2EBC0")]
	private void APKJMCIAALO(AGGODHIMNJJ PLLANJNEEID, HEGEILJIMIO CLBGPBICHNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct NOFFAAKLLPA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly AJHEAAFBPJF NCMLMNDELHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<DOEJKMGLGNJ> EEMCPPEAICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<BHANEJPFMBM> LOCKNCNKEGJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<BHANEJPFMBM> APCIKGEGHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9C65F0", Offset = "0x9C4FF0", VA = "0x1809C65F0")]
		get
		{
			return default(NativeList<BHANEJPFMBM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5F33340", Offset = "0x5F31D40", VA = "0x185F33340")]
	public NOFFAAKLLPA(AJHEAAFBPJF NCMLMNDELHI, List<DOEJKMGLGNJ> EEMCPPEAICN, NativeArray<BHANEJPFMBM> ICIOPHFNDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5F33070", Offset = "0x5F31A70", VA = "0x185F33070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5F32C70", Offset = "0x5F31670", VA = "0x185F32C70")]
	private NativeList<BHANEJPFMBM> DJPHCAIDKOJ(NativeArray<BHANEJPFMBM> MJDMEBKHENK)
	{
		return default(NativeList<BHANEJPFMBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5F33270", Offset = "0x5F31C70", VA = "0x185F33270")]
	private bool OAKEPNKPFMA(DOEJKMGLGNJ PLLANJNEEID, IKLPEIELELM NDNBGCFAFIJ, int OOLCFNBIIHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5F330B0", Offset = "0x5F31AB0", VA = "0x185F330B0")]
	private void EPPHCCIHALA(DOEJKMGLGNJ PLLANJNEEID, IKLPEIELELM LNCKFCGKJCI, int OOLCFNBIIHE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct OMIHGEONOJH : IComparer<BHANEJPFMBM>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5F333C0", Offset = "0x5F31DC0", VA = "0x185F333C0", Slot = "4")]
	public int Compare(BHANEJPFMBM LDIEPFCHCFG, BHANEJPFMBM KCHCODPDAGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5F333D0", Offset = "0x5F31DD0", VA = "0x185F333D0")]
	public static void LKDJBHFCBAF(NativeList<BHANEJPFMBM> ICIOPHFNDMP)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : ODIDKPKCBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5F33B70", Offset = "0x5F32570", VA = "0x185F33B70", Slot = "6")]
		public sealed override void OAOEINPMJJJ(NBLCNNHCPAE MLFGBBGKHEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5F339F0", Offset = "0x5F323F0", VA = "0x185F339F0", Slot = "4")]
		public sealed override void HGKEFMKAFGI()
		{
		}
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
