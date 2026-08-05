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
internal abstract class JPGCDFPJMKC : global::KOFOCGHLEIA<Enum>, HILBKABBHMN, JOHBLGBIIOM, NDLKIIAKCAK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool EMNMEHBKKOD(Type HAOFNDAEGFJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x664DFA0", Offset = "0x664D3A0", VA = "0x18664DFA0")]
	protected JPGCDFPJMKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class KOFOCGHLEIA<T> : JOHBLGBIIOM, NDLKIIAKCAK where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void HOLJDBAFOGI(Func<T> EBOMJGDBMBL, Action<T> FBPIKFEBIAF, string GOENAEMJAON, MGJBDIBFMNC MLIELKFMALM, Func<bool> IFIMLEKDOLF);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void JOCAOBFAMFJ(Func<int> EBOMJGDBMBL, Action<int> FBPIKFEBIAF, string GOENAEMJAON, MGJBDIBFMNC MLIELKFMALM, Func<bool> IFIMLEKDOLF);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class EPOBCEPJINO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public LNMIPKFIEGC targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MGJBDIBFMNC property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public EPOBCEPJINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F560", Offset = "0x1F8E960", VA = "0x181F8F560")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F600", Offset = "0x1F8EA00", VA = "0x181F8F600")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E0030", Offset = "0x6DF430", VA = "0x1806E0030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class EIDAEBOEMEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::KOFOCGHLEIA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public MLKJJALMBBL ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public EIDAEBOEMEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1F78360", Offset = "0x1F77760", VA = "0x181F78360")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, MGJBDIBFMNC property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HPNAPPDCGBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public HPNAPPDCGBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2C20DB0", Offset = "0x2C201B0", VA = "0x182C20DB0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2C20F00", Offset = "0x2C20300", VA = "0x182C20F00")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x36A0630", Offset = "0x369FA30", VA = "0x1836A0630")]
	protected KOFOCGHLEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x36A0140", Offset = "0x369F540", VA = "0x1836A0140", Slot = "5")]
	public virtual void GPALOEBDJFA(LNMIPKFIEGC LOLBGJKFFAI, MGJBDIBFMNC MLIELKFMALM, MLKJJALMBBL EHDHAGPCPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x36A0490", Offset = "0x369F890", VA = "0x1836A0490", Slot = "6")]
	protected virtual HOLJDBAFOGI JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x36A05E0", Offset = "0x369F9E0", VA = "0x1836A05E0", Slot = "7")]
	protected virtual JOCAOBFAMFJ MNKEPNPOIND(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x36A0410", Offset = "0x369F810", VA = "0x1836A0410")]
	private static Enum HPANNDOBNGG(LNMIPKFIEGC LOLBGJKFFAI, MGJBDIBFMNC MLIELKFMALM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x369FE00", Offset = "0x369F200", VA = "0x18369FE00")]
	private static void DNEFACEBPKG(LNMIPKFIEGC LOLBGJKFFAI, MGJBDIBFMNC MLIELKFMALM, Enum KPPLMEOMNGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class DLEGGCBALJC : EMLNALIEDAJ, NDLKIIAKCAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private MGJBDIBFMNC[] IONDFGDBCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private MGJBDIBFMNC[] BBCLMPCOBHJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MGJBDIBFMNC[] PDKGIAEAPEK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public MGJBDIBFMNC[] NCCIGJNPEKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract DLPKPOKLLDJ[] IGMDDONIOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract DLPKPOKLLDJ[] HGAABMKJHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x664CCD0", Offset = "0x664C0D0", VA = "0x18664CCD0", Slot = "6")]
	public void MGAGAAKAIAK(FMGCEKBAGOP FPDFBEPIKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void GPALOEBDJFA(LNMIPKFIEGC LOLBGJKFFAI, MLKJJALMBBL EHDHAGPCPPM);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x22FAA90", Offset = "0x22F9E90", VA = "0x1822FAA90")]
	protected static T DOIOCCGGJJA<T>(LNMIPKFIEGC LOLBGJKFFAI, MGJBDIBFMNC MLIELKFMALM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x22FAAE0", Offset = "0x22F9EE0", VA = "0x1822FAAE0")]
	protected static void HIANJBIKEIJ<T>(LNMIPKFIEGC LOLBGJKFFAI, MGJBDIBFMNC MLIELKFMALM, T KPPLMEOMNGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	protected DLEGGCBALJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class DKAFDLMLPGP<T> : JOHBLGBIIOM, NDLKIIAKCAK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void NDMNBCBFPNL(Func<T> EBOMJGDBMBL, Action<T> FBPIKFEBIAF, string GOENAEMJAON, MGJBDIBFMNC MLIELKFMALM, Func<bool> IFIMLEKDOLF);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GBKJIGKFPDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public LNMIPKFIEGC targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MGJBDIBFMNC property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public GBKJIGKFPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x32E1DF0", Offset = "0x32E11F0", VA = "0x1832E1DF0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x32E1FF0", Offset = "0x32E13F0", VA = "0x1832E1FF0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0030", Offset = "0x6DF430", VA = "0x1806E0030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x32A4030", Offset = "0x32A3430", VA = "0x1832A4030")]
	protected DKAFDLMLPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x32A29D0", Offset = "0x32A1DD0", VA = "0x1832A29D0", Slot = "4")]
	public void GPALOEBDJFA(LNMIPKFIEGC LOLBGJKFFAI, MGJBDIBFMNC MLIELKFMALM, MLKJJALMBBL EHDHAGPCPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x32A2550", Offset = "0x32A1950", VA = "0x1832A2550")]
	private static T DOIOCCGGJJA(LNMIPKFIEGC LOLBGJKFFAI, MGJBDIBFMNC MLIELKFMALM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x32A3B00", Offset = "0x32A2F00", VA = "0x1832A3B00")]
	private static void HIANJBIKEIJ(LNMIPKFIEGC LOLBGJKFFAI, MGJBDIBFMNC MLIELKFMALM, T KPPLMEOMNGF)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[OHGELDJCNJM(GGAOONGBEBH.ConfigUI)]
	[IABFONFHPFO(typeof(BHNFMLBIHBO), new string[] { })]
	internal class ConfigUIService : BHNFMLBIHBO, MIBCENMOHFA, PFFHIJLFPMD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[JOODLPJEDOA]
		private FMGCEKBAGOP FPDFBEPIKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[JOODLPJEDOA]
		private GJKJMJJGHKM OEGKKCBOANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[JOODLPJEDOA]
		private MLKJJALMBBL KBNJKJLDDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MEKJIOFHACF PGBOOIEEDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private LNMIPKFIEGC LOLBGJKFFAI;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x664BE50", Offset = "0x664B250", VA = "0x18664BE50", Slot = "5")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x664B8D0", Offset = "0x664ACD0", VA = "0x18664B8D0", Slot = "6")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x664B7E0", Offset = "0x664ABE0", VA = "0x18664B7E0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x664B270", Offset = "0x664A670", VA = "0x18664B270", Slot = "4")]
		public void CDPMDEAJHCF(LNMIPKFIEGC LOHPHEGKDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x664B1E0", Offset = "0x664A5E0", VA = "0x18664B1E0")]
		private void BIJPMOHOKKN(LNMIPKFIEGC LOHPHEGKDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x664B1B0", Offset = "0x664A5B0", VA = "0x18664B1B0")]
		private void AHNKAHDNLBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x664BBD0", Offset = "0x664AFD0", VA = "0x18664BBD0")]
		private void GPALOEBDJFA(FNIIIGONMHI AKCGLLEKOOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[KJIGGDGDKGN(0)]
internal class IGPNOOGJLMJ : JPGCDFPJMKC
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x664DE00", Offset = "0x664D200", VA = "0x18664DE00", Slot = "9")]
	public override bool EMNMEHBKKOD(Type HAOFNDAEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x664DEB0", Offset = "0x664D2B0", VA = "0x18664DEB0", Slot = "6")]
	protected override HOLJDBAFOGI JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x664DFA0", Offset = "0x664D3A0", VA = "0x18664DFA0")]
	public IGPNOOGJLMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[KJIGGDGDKGN(0)]
internal class PAMPAAPPFJA : JPGCDFPJMKC
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6650200", Offset = "0x664F600", VA = "0x186650200", Slot = "9")]
	public override bool EMNMEHBKKOD(Type HAOFNDAEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x66502B0", Offset = "0x664F6B0", VA = "0x1866502B0", Slot = "6")]
	protected override HOLJDBAFOGI JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x664DFA0", Offset = "0x664D3A0", VA = "0x18664DFA0")]
	public PAMPAAPPFJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[OLMNJNPNJOM(typeof(CCHADHIMJDJ), 1)]
internal class AGOJKGAINAG : global::KOFOCGHLEIA<CCHADHIMJDJ>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x664A480", Offset = "0x6649880", VA = "0x18664A480", Slot = "7")]
	protected override JOCAOBFAMFJ MNKEPNPOIND(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x664A570", Offset = "0x6649970", VA = "0x18664A570")]
	public AGOJKGAINAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class OOHAHOKONHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x66500C0", Offset = "0x664F4C0", VA = "0x1866500C0")]
	public static bool JDPDPFAHJKO(this MGJBDIBFMNC MLIELKFMALM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[PFCINNAGELG(2)]
internal class OMIFDODIKGA : DLEGGCBALJC
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class KLBCIBEFPFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public LNMIPKFIEGC targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public OMIFDODIKGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public KLBCIBEFPFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x664E310", Offset = "0x664D710", VA = "0x18664E310")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x664E440", Offset = "0x664D840", VA = "0x18664E440")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E0030", Offset = "0x6DF430", VA = "0x1806E0030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override DLPKPOKLLDJ[] HGAABMKJHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x664FFE0", Offset = "0x664F3E0", VA = "0x18664FFE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override DLPKPOKLLDJ[] IGMDDONIOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x664FF00", Offset = "0x664F300", VA = "0x18664FF00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x664FB40", Offset = "0x664EF40", VA = "0x18664FB40", Slot = "10")]
	public override void GPALOEBDJFA(LNMIPKFIEGC LOLBGJKFFAI, MLKJJALMBBL EHDHAGPCPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public OMIFDODIKGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[OLMNJNPNJOM(typeof(bool))]
internal class DOEKBGHFOGG : global::DKAFDLMLPGP<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x664D0E0", Offset = "0x664C4E0", VA = "0x18664D0E0", Slot = "5")]
	protected override NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x664D1D0", Offset = "0x664C5D0", VA = "0x18664D1D0")]
	public DOEKBGHFOGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[OLMNJNPNJOM(typeof(FixedString32))]
internal class ENPPMGJAKLB : global::DKAFDLMLPGP<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class GDNLAFANMCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public MLKJJALMBBL ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public GDNLAFANMCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x664D660", Offset = "0x664CA60", VA = "0x18664D660")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, MGJBDIBFMNC property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BNGMFMAGEMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public BNGMFMAGEMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x664B0C0", Offset = "0x664A4C0", VA = "0x18664B0C0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x664B130", Offset = "0x664A530", VA = "0x18664B130")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x664D210", Offset = "0x664C610", VA = "0x18664D210", Slot = "5")]
	protected override NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x664D2D0", Offset = "0x664C6D0", VA = "0x18664D2D0")]
	public ENPPMGJAKLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[OLMNJNPNJOM(typeof(FixedString64))]
internal class PGCJJLPFJNF : global::DKAFDLMLPGP<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class MENDGMCPIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MLKJJALMBBL ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public MENDGMCPIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x664F690", Offset = "0x664EA90", VA = "0x18664F690")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, MGJBDIBFMNC property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class DEGMCFNJIDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public DEGMCFNJIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x664BF30", Offset = "0x664B330", VA = "0x18664BF30")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x664BFC0", Offset = "0x664B3C0", VA = "0x18664BFC0")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x66503A0", Offset = "0x664F7A0", VA = "0x1866503A0", Slot = "5")]
	protected override NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6650460", Offset = "0x664F860", VA = "0x186650460")]
	public PGCJJLPFJNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[OLMNJNPNJOM(typeof(float))]
internal class DJNEJMMPHKF : global::DKAFDLMLPGP<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x664CBA0", Offset = "0x664BFA0", VA = "0x18664CBA0", Slot = "5")]
	protected override NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x664CC90", Offset = "0x664C090", VA = "0x18664CC90")]
	public DJNEJMMPHKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[OLMNJNPNJOM(typeof(int))]
internal class JBDONNBNBBP : global::DKAFDLMLPGP<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x664DFE0", Offset = "0x664D3E0", VA = "0x18664DFE0", Slot = "5")]
	protected override NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x664E0D0", Offset = "0x664D4D0", VA = "0x18664E0D0")]
	public JBDONNBNBBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[OLMNJNPNJOM(typeof(uint))]
internal class JIIHEHAOBKK : global::DKAFDLMLPGP<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MNDJDOIPFLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MLKJJALMBBL ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public MNDJDOIPFLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x664F820", Offset = "0x664EC20", VA = "0x18664F820")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, MGJBDIBFMNC property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GIPHFKADMDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public GIPHFKADMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x664D7F0", Offset = "0x664CBF0", VA = "0x18664D7F0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x664D840", Offset = "0x664CC40", VA = "0x18664D840")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x664E210", Offset = "0x664D610", VA = "0x18664E210", Slot = "5")]
	protected override NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x664E2D0", Offset = "0x664D6D0", VA = "0x18664E2D0")]
	public JIIHEHAOBKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[OLMNJNPNJOM(typeof(Vector3))]
internal class JEKDKNDJGOD : global::DKAFDLMLPGP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class FMAEGLOIIKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public MLKJJALMBBL ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public FMAEGLOIIKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x664D310", Offset = "0x664C710", VA = "0x18664D310")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, MGJBDIBFMNC property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HGCLBBOODFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public HGCLBBOODFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x664D8A0", Offset = "0x664CCA0", VA = "0x18664D8A0")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x664D900", Offset = "0x664CD00", VA = "0x18664D900")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x664D910", Offset = "0x664CD10", VA = "0x18664D910")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x664D970", Offset = "0x664CD70", VA = "0x18664D970")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x664D980", Offset = "0x664CD80", VA = "0x18664D980")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x664D9E0", Offset = "0x664CDE0", VA = "0x18664D9E0")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x664E110", Offset = "0x664D510", VA = "0x18664E110", Slot = "5")]
	protected override NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x664E1D0", Offset = "0x664D5D0", VA = "0x18664E1D0")]
	public JEKDKNDJGOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct FNIIIGONMHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int NBEICOPOFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int BDGOJACAFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int APLFJBIBJAH;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class NILAPFEANEB
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x664FA00", Offset = "0x664EE00", VA = "0x18664FA00")]
	public static void LJOMKBABAOH(Type PKDJBEFNELI, Type BCGFOBOHBHD)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct ANILJCFDHPH
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x664A5B0", Offset = "0x66499B0", VA = "0x18664A5B0")]
	public static NativeList<int> ALHMOKJALCP(LNMIPKFIEGC LOLBGJKFFAI, GJKJMJJGHKM OEGKKCBOANH)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x664A790", Offset = "0x6649B90", VA = "0x18664A790")]
	private static bool EIAFNDJMCFC(MGJBDIBFMNC MLIELKFMALM, LNMIPKFIEGC LOLBGJKFFAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class DHAKEAGNKLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly GJKJMJJGHKM OEGKKCBOANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly FMGCEKBAGOP FPDFBEPIKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly MLKJJALMBBL EHDHAGPCPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<FNIIIGONMHI> HFMOPNJDEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<JEOAIDCLOLN> GCDJFLKOMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<JEOAIDCLOLN, List<FNIIIGONMHI>> IAPDHDNPKHI;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x664CA80", Offset = "0x664BE80", VA = "0x18664CA80")]
	public DHAKEAGNKLC(GJKJMJJGHKM OEGKKCBOANH, FMGCEKBAGOP FPDFBEPIKDA, MLKJJALMBBL EHDHAGPCPPM, Action<FNIIIGONMHI> HFMOPNJDEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x664C060", Offset = "0x664B460", VA = "0x18664C060")]
	public void DHGLLMHOMFM(NativeList<FNIIIGONMHI> FHOPHJGKNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x664C3E0", Offset = "0x664B7E0", VA = "0x18664C3E0")]
	private void ECOGCJGAFNI(JEOAIDCLOLN DEGOBDGJJPK, FNIIIGONMHI AKCGLLEKOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x664C5A0", Offset = "0x664B9A0", VA = "0x18664C5A0")]
	public void IHIEPGGMBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x664C600", Offset = "0x664BA00", VA = "0x18664C600")]
	private void JFIBPBCBBMI(JEOAIDCLOLN DEGOBDGJJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x664C500", Offset = "0x664B900", VA = "0x18664C500")]
	private void EKJDAMJJOHO(JEOAIDCLOLN DEGOBDGJJPK)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[OHGELDJCNJM(GGAOONGBEBH.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class ADNFELOBJFC : IEnumerable<MGJBDIBFMNC>, IEnumerable, IEnumerator<MGJBDIBFMNC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private MGJBDIBFMNC <>2__current;

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
			private MGJBDIBFMNC System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8BB110", Offset = "0x8BA510", VA = "0x1808BB110")]
			[DebuggerHidden]
			public ADNFELOBJFC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x664A3B0", Offset = "0x66497B0", VA = "0x18664A3B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x664A070", Offset = "0x6649470", VA = "0x18664A070", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x664A430", Offset = "0x6649830", VA = "0x18664A430")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x664A370", Offset = "0x6649770", VA = "0x18664A370", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x664A2C0", Offset = "0x66496C0", VA = "0x18664A2C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MGJBDIBFMNC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x664A2C0", Offset = "0x66496C0", VA = "0x18664A2C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly FMGCEKBAGOP FPDFBEPIKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> PLDBJIFBDBF;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6650680", Offset = "0x664FA80", VA = "0x186650680")]
		public PropertiesByType(FMGCEKBAGOP FPDFBEPIKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x66505A0", Offset = "0x664F9A0", VA = "0x1866505A0")]
		[IteratorStateMachine(typeof(ADNFELOBJFC))]
		public IEnumerable<MGJBDIBFMNC> NNNIBLFPBIA(Type HAOFNDAEGFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x66504A0", Offset = "0x664F8A0", VA = "0x1866504A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6650520", Offset = "0x664F920", VA = "0x186650520")]
		private long LKLMHAFABKJ(MGJBDIBFMNC MLIELKFMALM)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x66504E0", Offset = "0x664F8E0", VA = "0x1866504E0")]
		private long LKLMHAFABKJ(Type HAOFNDAEGFJ)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct HNLGCHOGJBH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray JKKLAFFOMID;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x664DDC0", Offset = "0x664D1C0", VA = "0x18664DDC0")]
	public HNLGCHOGJBH(int KJAHKKMJHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x664DAC0", Offset = "0x664CEC0", VA = "0x18664DAC0")]
	public static HNLGCHOGJBH AFHCDMHAKGF(int KNECCHHDDJH, NativeArray<int> ICBILMELIDM)
	{
		return default(HNLGCHOGJBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x664DCF0", Offset = "0x664D0F0", VA = "0x18664DCF0")]
	public bool OLMDFONJDCE(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x664DC20", Offset = "0x664D020", VA = "0x18664DC20")]
	public void JPNFGACMGOG(int EGBCAPEEJBF, bool KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x664DD00", Offset = "0x664D100", VA = "0x18664DD00")]
	public bool OOJLNPFKDBC(MGJBDIBFMNC[] ICBILMELIDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x664DC30", Offset = "0x664D030", VA = "0x18664DC30")]
	public bool MILBNLDJCCH(MGJBDIBFMNC[] ICBILMELIDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x664DC10", Offset = "0x664D010", VA = "0x18664DC10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class MEKJIOFHACF
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly JHCDFELAIDH AOHKNGHOEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly GJKJMJJGHKM OEGKKCBOANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly FMGCEKBAGOP FPDFBEPIKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<NDLKIIAKCAK> BAJDEEJGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType PLDBJIFBDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> LIBDNGKBIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> MMPJEFNMBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<NDLKIIAKCAK> CCFJFOFGJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x664F540", Offset = "0x664E940", VA = "0x18664F540")]
	public MEKJIOFHACF(GJKJMJJGHKM OEGKKCBOANH, FMGCEKBAGOP FPDFBEPIKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x664EB90", Offset = "0x664DF90", VA = "0x18664EB90")]
	public void KKNPGIAABIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x664EC60", Offset = "0x664E060", VA = "0x18664EC60")]
	public void LMOIOEPLKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x664EDD0", Offset = "0x664E1D0", VA = "0x18664EDD0")]
	public NativeList<FNIIIGONMHI> OJHEFGNBBED(NativeArray<int> ICBILMELIDM)
	{
		return default(NativeList<FNIIIGONMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x664E640", Offset = "0x664DA40", VA = "0x18664E640")]
	private bool FEHPDJFAIKO(NDLKIIAKCAK HHAFAJJHCFN, HNLGCHOGJBH KKKNFGDMHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x29EA1A0", Offset = "0x29E95A0", VA = "0x1829EA1A0")]
	private void OBFCAFIBJPE<TInterface, TAttribute>(Action<TInterface, TAttribute> NOONJLFPGAF) where TInterface : NDLKIIAKCAK where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x664E8B0", Offset = "0x664DCB0", VA = "0x18664E8B0")]
	private void HKGKCJCDFNA(Type HAOFNDAEGFJ, Type GHKCAALMMPE, Type BCHHMDAKDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x29EA140", Offset = "0x29E9540", VA = "0x1829EA140")]
	private TInterface BENNLNEHDIG<TInterface>(Type HAOFNDAEGFJ)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x664E4D0", Offset = "0x664D8D0", VA = "0x18664E4D0")]
	private void CAIMMHJOGIO(NDLKIIAKCAK HHAFAJJHCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x664E5A0", Offset = "0x664D9A0", VA = "0x18664E5A0")]
	private int DPKCIHMKMGL(NDLKIIAKCAK AJGFDPPCCKJ, int APLFJBIBJAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x664E8E0", Offset = "0x664DCE0", VA = "0x18664E8E0")]
	private void JENLIDABELI(JOHBLGBIIOM HHAFAJJHCFN, OLMNJNPNJOM KEFLANNKGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x664F230", Offset = "0x664E630", VA = "0x18664F230")]
	private void PIBGHPOCGLN(HILBKABBHMN HHAFAJJHCFN, KJIGGDGDKGN KEFLANNKGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x664E710", Offset = "0x664DB10", VA = "0x18664E710")]
	private void GFBMBMFGFHK(EMLNALIEDAJ HHAFAJJHCFN, PFCINNAGELG KEFLANNKGHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct BFILCMKGPLM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly FMGCEKBAGOP FPDFBEPIKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<NDLKIIAKCAK> BAJDEEJGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<FNIIIGONMHI> FGLLNCBDNEM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<FNIIIGONMHI> HFHIGDNKDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCE63C0", Offset = "0xCE57C0", VA = "0x180CE63C0")]
		get
		{
			return default(NativeList<FNIIIGONMHI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x664B040", Offset = "0x664A440", VA = "0x18664B040")]
	public BFILCMKGPLM(FMGCEKBAGOP FPDFBEPIKDA, List<NDLKIIAKCAK> BAJDEEJGNCO, NativeArray<FNIIIGONMHI> FHOPHJGKNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x664AD70", Offset = "0x664A170", VA = "0x18664AD70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x664A970", Offset = "0x6649D70", VA = "0x18664A970")]
	private NativeList<FNIIIGONMHI> DFIEOADLKAB(NativeArray<FNIIIGONMHI> FABEDHAEIHP)
	{
		return default(NativeList<FNIIIGONMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x664ADB0", Offset = "0x664A1B0", VA = "0x18664ADB0")]
	private bool GDJFLELILAO(NDLKIIAKCAK HHAFAJJHCFN, HNLGCHOGJBH DAIMJFJGLAN, int BDGOJACAFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x664AE80", Offset = "0x664A280", VA = "0x18664AE80")]
	private void NMOLDKNKILF(NDLKIIAKCAK HHAFAJJHCFN, HNLGCHOGJBH JKKLAFFOMID, int BDGOJACAFML)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct OAIKKPFCBLF : IComparer<FNIIIGONMHI>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x664FAE0", Offset = "0x664EEE0", VA = "0x18664FAE0", Slot = "4")]
	public int Compare(FNIIIGONMHI BECDKHGLGNB, FNIIIGONMHI ICPOAGANOLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x664FAF0", Offset = "0x664EEF0", VA = "0x18664FAF0")]
	public static void OIEPKIMNLDG(NativeList<FNIIIGONMHI> FHOPHJGKNEE)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : PLIGCBHMDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6650B00", Offset = "0x664FF00", VA = "0x186650B00", Slot = "6")]
		public sealed override void LDHMAOMPMOJ(JNCGCMMLAKP PEPHBHFBJFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6650980", Offset = "0x664FD80", VA = "0x186650980", Slot = "4")]
		public sealed override void DOIEPELEGLE()
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
