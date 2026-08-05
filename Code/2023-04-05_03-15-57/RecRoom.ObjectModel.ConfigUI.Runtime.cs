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
	[Cpp2IlInjected.Address(RVA = "0x65C8880", Offset = "0x65C7880", VA = "0x1865C8880")]
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
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public EPOBCEPJINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2029520", Offset = "0x2028520", VA = "0x182029520")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x20295C0", Offset = "0x20285C0", VA = "0x1820295C0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6DF030", Offset = "0x6DE030", VA = "0x1806DF030")]
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
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public EIDAEBOEMEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x20124A0", Offset = "0x20114A0", VA = "0x1820124A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public HPNAPPDCGBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x38E9AC0", Offset = "0x38E8AC0", VA = "0x1838E9AC0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x38E9C10", Offset = "0x38E8C10", VA = "0x1838E9C10")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2B65BB0", Offset = "0x2B64BB0", VA = "0x182B65BB0")]
	protected KOFOCGHLEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2B656C0", Offset = "0x2B646C0", VA = "0x182B656C0", Slot = "5")]
	public virtual void GPALOEBDJFA(LNMIPKFIEGC LOLBGJKFFAI, MGJBDIBFMNC MLIELKFMALM, MLKJJALMBBL EHDHAGPCPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B65A10", Offset = "0x2B64A10", VA = "0x182B65A10", Slot = "6")]
	protected virtual HOLJDBAFOGI JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B65B60", Offset = "0x2B64B60", VA = "0x182B65B60", Slot = "7")]
	protected virtual JOCAOBFAMFJ MNKEPNPOIND(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B65990", Offset = "0x2B64990", VA = "0x182B65990")]
	private static Enum HPANNDOBNGG(LNMIPKFIEGC LOLBGJKFFAI, MGJBDIBFMNC MLIELKFMALM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B65380", Offset = "0x2B64380", VA = "0x182B65380")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public MGJBDIBFMNC[] NCCIGJNPEKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x65C75B0", Offset = "0x65C65B0", VA = "0x1865C75B0", Slot = "6")]
	public void MGAGAAKAIAK(FMGCEKBAGOP FPDFBEPIKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void GPALOEBDJFA(LNMIPKFIEGC LOLBGJKFFAI, MLKJJALMBBL EHDHAGPCPPM);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x213AB00", Offset = "0x2139B00", VA = "0x18213AB00")]
	protected static T DOIOCCGGJJA<T>(LNMIPKFIEGC LOLBGJKFFAI, MGJBDIBFMNC MLIELKFMALM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x213AB50", Offset = "0x2139B50", VA = "0x18213AB50")]
	protected static void HIANJBIKEIJ<T>(LNMIPKFIEGC LOLBGJKFFAI, MGJBDIBFMNC MLIELKFMALM, T KPPLMEOMNGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public GBKJIGKFPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28E7930", Offset = "0x28E6930", VA = "0x1828E7930")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x28E7B30", Offset = "0x28E6B30", VA = "0x1828E7B30")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6DF030", Offset = "0x6DE030", VA = "0x1806DF030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x36931F0", Offset = "0x36921F0", VA = "0x1836931F0")]
	protected DKAFDLMLPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3691B90", Offset = "0x3690B90", VA = "0x183691B90", Slot = "4")]
	public void GPALOEBDJFA(LNMIPKFIEGC LOLBGJKFFAI, MGJBDIBFMNC MLIELKFMALM, MLKJJALMBBL EHDHAGPCPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3691710", Offset = "0x3690710", VA = "0x183691710")]
	private static T DOIOCCGGJJA(LNMIPKFIEGC LOLBGJKFFAI, MGJBDIBFMNC MLIELKFMALM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3692CC0", Offset = "0x3691CC0", VA = "0x183692CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x65C6730", Offset = "0x65C5730", VA = "0x1865C6730", Slot = "5")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x65C61B0", Offset = "0x65C51B0", VA = "0x1865C61B0", Slot = "6")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x65C60C0", Offset = "0x65C50C0", VA = "0x1865C60C0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x65C5B50", Offset = "0x65C4B50", VA = "0x1865C5B50", Slot = "4")]
		public void CDPMDEAJHCF(LNMIPKFIEGC LOHPHEGKDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x65C5AC0", Offset = "0x65C4AC0", VA = "0x1865C5AC0")]
		private void BIJPMOHOKKN(LNMIPKFIEGC LOHPHEGKDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x65C5A90", Offset = "0x65C4A90", VA = "0x1865C5A90")]
		private void AHNKAHDNLBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x65C64B0", Offset = "0x65C54B0", VA = "0x1865C64B0")]
		private void GPALOEBDJFA(FNIIIGONMHI AKCGLLEKOOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x65C86E0", Offset = "0x65C76E0", VA = "0x1865C86E0", Slot = "9")]
	public override bool EMNMEHBKKOD(Type HAOFNDAEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x65C8790", Offset = "0x65C7790", VA = "0x1865C8790", Slot = "6")]
	protected override HOLJDBAFOGI JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x65C8880", Offset = "0x65C7880", VA = "0x1865C8880")]
	public IGPNOOGJLMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[KJIGGDGDKGN(0)]
internal class PAMPAAPPFJA : JPGCDFPJMKC
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x65CAAE0", Offset = "0x65C9AE0", VA = "0x1865CAAE0", Slot = "9")]
	public override bool EMNMEHBKKOD(Type HAOFNDAEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x65CAB90", Offset = "0x65C9B90", VA = "0x1865CAB90", Slot = "6")]
	protected override HOLJDBAFOGI JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x65C8880", Offset = "0x65C7880", VA = "0x1865C8880")]
	public PAMPAAPPFJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[OLMNJNPNJOM(typeof(CCHADHIMJDJ), 1)]
internal class AGOJKGAINAG : global::KOFOCGHLEIA<CCHADHIMJDJ>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x65C4D60", Offset = "0x65C3D60", VA = "0x1865C4D60", Slot = "7")]
	protected override JOCAOBFAMFJ MNKEPNPOIND(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x65C4E50", Offset = "0x65C3E50", VA = "0x1865C4E50")]
	public AGOJKGAINAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class OOHAHOKONHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x65CA9A0", Offset = "0x65C99A0", VA = "0x1865CA9A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public KLBCIBEFPFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x65C8BF0", Offset = "0x65C7BF0", VA = "0x1865C8BF0")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x65C8D20", Offset = "0x65C7D20", VA = "0x1865C8D20")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6DF030", Offset = "0x6DE030", VA = "0x1806DF030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override DLPKPOKLLDJ[] HGAABMKJHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x65CA8C0", Offset = "0x65C98C0", VA = "0x1865CA8C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override DLPKPOKLLDJ[] IGMDDONIOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x65CA7E0", Offset = "0x65C97E0", VA = "0x1865CA7E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x65CA420", Offset = "0x65C9420", VA = "0x1865CA420", Slot = "10")]
	public override void GPALOEBDJFA(LNMIPKFIEGC LOLBGJKFFAI, MLKJJALMBBL EHDHAGPCPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public OMIFDODIKGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[OLMNJNPNJOM(typeof(bool))]
internal class DOEKBGHFOGG : global::DKAFDLMLPGP<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x65C79C0", Offset = "0x65C69C0", VA = "0x1865C79C0", Slot = "5")]
	protected override NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x65C7AB0", Offset = "0x65C6AB0", VA = "0x1865C7AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public GDNLAFANMCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x65C7F40", Offset = "0x65C6F40", VA = "0x1865C7F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public BNGMFMAGEMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x65C59A0", Offset = "0x65C49A0", VA = "0x1865C59A0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x65C5A10", Offset = "0x65C4A10", VA = "0x1865C5A10")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x65C7AF0", Offset = "0x65C6AF0", VA = "0x1865C7AF0", Slot = "5")]
	protected override NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x65C7BB0", Offset = "0x65C6BB0", VA = "0x1865C7BB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public MENDGMCPIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x65C9F70", Offset = "0x65C8F70", VA = "0x1865C9F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public DEGMCFNJIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x65C6810", Offset = "0x65C5810", VA = "0x1865C6810")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x65C68A0", Offset = "0x65C58A0", VA = "0x1865C68A0")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x65CAC80", Offset = "0x65C9C80", VA = "0x1865CAC80", Slot = "5")]
	protected override NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x65CAD40", Offset = "0x65C9D40", VA = "0x1865CAD40")]
	public PGCJJLPFJNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[OLMNJNPNJOM(typeof(float))]
internal class DJNEJMMPHKF : global::DKAFDLMLPGP<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x65C7480", Offset = "0x65C6480", VA = "0x1865C7480", Slot = "5")]
	protected override NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x65C7570", Offset = "0x65C6570", VA = "0x1865C7570")]
	public DJNEJMMPHKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[OLMNJNPNJOM(typeof(int))]
internal class JBDONNBNBBP : global::DKAFDLMLPGP<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x65C88C0", Offset = "0x65C78C0", VA = "0x1865C88C0", Slot = "5")]
	protected override NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x65C89B0", Offset = "0x65C79B0", VA = "0x1865C89B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public MNDJDOIPFLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x65CA100", Offset = "0x65C9100", VA = "0x1865CA100")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public GIPHFKADMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x65C80D0", Offset = "0x65C70D0", VA = "0x1865C80D0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x65C8120", Offset = "0x65C7120", VA = "0x1865C8120")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x65C8AF0", Offset = "0x65C7AF0", VA = "0x1865C8AF0", Slot = "5")]
	protected override NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x65C8BB0", Offset = "0x65C7BB0", VA = "0x1865C8BB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public FMAEGLOIIKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x65C7BF0", Offset = "0x65C6BF0", VA = "0x1865C7BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public HGCLBBOODFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x65C8180", Offset = "0x65C7180", VA = "0x1865C8180")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x65C81E0", Offset = "0x65C71E0", VA = "0x1865C81E0")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x65C81F0", Offset = "0x65C71F0", VA = "0x1865C81F0")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x65C8250", Offset = "0x65C7250", VA = "0x1865C8250")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x65C8260", Offset = "0x65C7260", VA = "0x1865C8260")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x65C82C0", Offset = "0x65C72C0", VA = "0x1865C82C0")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x65C89F0", Offset = "0x65C79F0", VA = "0x1865C89F0", Slot = "5")]
	protected override NDMNBCBFPNL JIDENEJAHHM(MLKJJALMBBL EHDHAGPCPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x65C8AB0", Offset = "0x65C7AB0", VA = "0x1865C8AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x65CA2E0", Offset = "0x65C92E0", VA = "0x1865CA2E0")]
	public static void LJOMKBABAOH(Type PKDJBEFNELI, Type BCGFOBOHBHD)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct ANILJCFDHPH
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x65C4E90", Offset = "0x65C3E90", VA = "0x1865C4E90")]
	public static NativeList<int> ALHMOKJALCP(LNMIPKFIEGC LOLBGJKFFAI, GJKJMJJGHKM OEGKKCBOANH)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x65C5070", Offset = "0x65C4070", VA = "0x1865C5070")]
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
	[Cpp2IlInjected.Address(RVA = "0x65C7360", Offset = "0x65C6360", VA = "0x1865C7360")]
	public DHAKEAGNKLC(GJKJMJJGHKM OEGKKCBOANH, FMGCEKBAGOP FPDFBEPIKDA, MLKJJALMBBL EHDHAGPCPPM, Action<FNIIIGONMHI> HFMOPNJDEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x65C6940", Offset = "0x65C5940", VA = "0x1865C6940")]
	public void DHGLLMHOMFM(NativeList<FNIIIGONMHI> FHOPHJGKNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x65C6CC0", Offset = "0x65C5CC0", VA = "0x1865C6CC0")]
	private void ECOGCJGAFNI(JEOAIDCLOLN DEGOBDGJJPK, FNIIIGONMHI AKCGLLEKOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x65C6E80", Offset = "0x65C5E80", VA = "0x1865C6E80")]
	public void IHIEPGGMBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x65C6EE0", Offset = "0x65C5EE0", VA = "0x1865C6EE0")]
	private void JFIBPBCBBMI(JEOAIDCLOLN DEGOBDGJJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x65C6DE0", Offset = "0x65C5DE0", VA = "0x1865C6DE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8BA110", Offset = "0x8B9110", VA = "0x1808BA110")]
			[DebuggerHidden]
			public ADNFELOBJFC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x65C4C90", Offset = "0x65C3C90", VA = "0x1865C4C90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x65C4950", Offset = "0x65C3950", VA = "0x1865C4950", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x65C4D10", Offset = "0x65C3D10", VA = "0x1865C4D10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x65C4C50", Offset = "0x65C3C50", VA = "0x1865C4C50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x65C4BA0", Offset = "0x65C3BA0", VA = "0x1865C4BA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MGJBDIBFMNC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x65C4BA0", Offset = "0x65C3BA0", VA = "0x1865C4BA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x65CAF60", Offset = "0x65C9F60", VA = "0x1865CAF60")]
		public PropertiesByType(FMGCEKBAGOP FPDFBEPIKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x65CAE80", Offset = "0x65C9E80", VA = "0x1865CAE80")]
		[IteratorStateMachine(typeof(ADNFELOBJFC))]
		public IEnumerable<MGJBDIBFMNC> NNNIBLFPBIA(Type HAOFNDAEGFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x65CAD80", Offset = "0x65C9D80", VA = "0x1865CAD80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x65CAE00", Offset = "0x65C9E00", VA = "0x1865CAE00")]
		private long LKLMHAFABKJ(MGJBDIBFMNC MLIELKFMALM)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x65CADC0", Offset = "0x65C9DC0", VA = "0x1865CADC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x65C86A0", Offset = "0x65C76A0", VA = "0x1865C86A0")]
	public HNLGCHOGJBH(int KJAHKKMJHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x65C83A0", Offset = "0x65C73A0", VA = "0x1865C83A0")]
	public static HNLGCHOGJBH AFHCDMHAKGF(int KNECCHHDDJH, NativeArray<int> ICBILMELIDM)
	{
		return default(HNLGCHOGJBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x65C85D0", Offset = "0x65C75D0", VA = "0x1865C85D0")]
	public bool OLMDFONJDCE(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x65C8500", Offset = "0x65C7500", VA = "0x1865C8500")]
	public void JPNFGACMGOG(int EGBCAPEEJBF, bool KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x65C85E0", Offset = "0x65C75E0", VA = "0x1865C85E0")]
	public bool OOJLNPFKDBC(MGJBDIBFMNC[] ICBILMELIDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x65C8510", Offset = "0x65C7510", VA = "0x1865C8510")]
	public bool MILBNLDJCCH(MGJBDIBFMNC[] ICBILMELIDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x65C84F0", Offset = "0x65C74F0", VA = "0x1865C84F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x65C9E20", Offset = "0x65C8E20", VA = "0x1865C9E20")]
	public MEKJIOFHACF(GJKJMJJGHKM OEGKKCBOANH, FMGCEKBAGOP FPDFBEPIKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x65C9470", Offset = "0x65C8470", VA = "0x1865C9470")]
	public void KKNPGIAABIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x65C9540", Offset = "0x65C8540", VA = "0x1865C9540")]
	public void LMOIOEPLKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x65C96B0", Offset = "0x65C86B0", VA = "0x1865C96B0")]
	public NativeList<FNIIIGONMHI> OJHEFGNBBED(NativeArray<int> ICBILMELIDM)
	{
		return default(NativeList<FNIIIGONMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x65C8F20", Offset = "0x65C7F20", VA = "0x1865C8F20")]
	private bool FEHPDJFAIKO(NDLKIIAKCAK HHAFAJJHCFN, HNLGCHOGJBH KKKNFGDMHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2236B30", Offset = "0x2235B30", VA = "0x182236B30")]
	private void OBFCAFIBJPE<TInterface, TAttribute>(Action<TInterface, TAttribute> NOONJLFPGAF) where TInterface : NDLKIIAKCAK where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x65C9190", Offset = "0x65C8190", VA = "0x1865C9190")]
	private void HKGKCJCDFNA(Type HAOFNDAEGFJ, Type GHKCAALMMPE, Type BCHHMDAKDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2236AD0", Offset = "0x2235AD0", VA = "0x182236AD0")]
	private TInterface BENNLNEHDIG<TInterface>(Type HAOFNDAEGFJ)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x65C8DB0", Offset = "0x65C7DB0", VA = "0x1865C8DB0")]
	private void CAIMMHJOGIO(NDLKIIAKCAK HHAFAJJHCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x65C8E80", Offset = "0x65C7E80", VA = "0x1865C8E80")]
	private int DPKCIHMKMGL(NDLKIIAKCAK AJGFDPPCCKJ, int APLFJBIBJAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x65C91C0", Offset = "0x65C81C0", VA = "0x1865C91C0")]
	private void JENLIDABELI(JOHBLGBIIOM HHAFAJJHCFN, OLMNJNPNJOM KEFLANNKGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x65C9B10", Offset = "0x65C8B10", VA = "0x1865C9B10")]
	private void PIBGHPOCGLN(HILBKABBHMN HHAFAJJHCFN, KJIGGDGDKGN KEFLANNKGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x65C8FF0", Offset = "0x65C7FF0", VA = "0x1865C8FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCE53C0", Offset = "0xCE43C0", VA = "0x180CE53C0")]
		get
		{
			return default(NativeList<FNIIIGONMHI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x65C5920", Offset = "0x65C4920", VA = "0x1865C5920")]
	public BFILCMKGPLM(FMGCEKBAGOP FPDFBEPIKDA, List<NDLKIIAKCAK> BAJDEEJGNCO, NativeArray<FNIIIGONMHI> FHOPHJGKNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x65C5650", Offset = "0x65C4650", VA = "0x1865C5650", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x65C5250", Offset = "0x65C4250", VA = "0x1865C5250")]
	private NativeList<FNIIIGONMHI> DFIEOADLKAB(NativeArray<FNIIIGONMHI> FABEDHAEIHP)
	{
		return default(NativeList<FNIIIGONMHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x65C5690", Offset = "0x65C4690", VA = "0x1865C5690")]
	private bool GDJFLELILAO(NDLKIIAKCAK HHAFAJJHCFN, HNLGCHOGJBH DAIMJFJGLAN, int BDGOJACAFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x65C5760", Offset = "0x65C4760", VA = "0x1865C5760")]
	private void NMOLDKNKILF(NDLKIIAKCAK HHAFAJJHCFN, HNLGCHOGJBH JKKLAFFOMID, int BDGOJACAFML)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct OAIKKPFCBLF : IComparer<FNIIIGONMHI>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x65CA3C0", Offset = "0x65C93C0", VA = "0x1865CA3C0", Slot = "4")]
	public int Compare(FNIIIGONMHI BECDKHGLGNB, FNIIIGONMHI ICPOAGANOLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x65CA3D0", Offset = "0x65C93D0", VA = "0x1865CA3D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x65CB3E0", Offset = "0x65CA3E0", VA = "0x1865CB3E0", Slot = "6")]
		public sealed override void LDHMAOMPMOJ(JNCGCMMLAKP PEPHBHFBJFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x65CB260", Offset = "0x65CA260", VA = "0x1865CB260", Slot = "4")]
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
