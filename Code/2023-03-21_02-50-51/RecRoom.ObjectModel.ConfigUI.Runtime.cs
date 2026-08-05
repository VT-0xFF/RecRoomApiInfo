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
internal abstract class KOBLLCKBEFL : global::PIGAIIKGKJJ<Enum>, EGCOCBFACDM, PNOPJLJOLIO, AIDALJNAAAL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool BBIJMBKEPGH(Type EHPFPOFFCEJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6521920", Offset = "0x6520120", VA = "0x186521920")]
	protected KOBLLCKBEFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class PIGAIIKGKJJ<T> : PNOPJLJOLIO, AIDALJNAAAL where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void OKOCCIIIIGO(Func<T> EIKMMDPAEAP, Action<T> IIAHLGNADOM, string LOIAMCEJAFO, CBKEAKDLCBB NPCKPCNEDPB, Func<bool> JBHEEHEBNGL);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void KNBKFEBOGKP(Func<int> EIKMMDPAEAP, Action<int> IIAHLGNADOM, string LOIAMCEJAFO, CBKEAKDLCBB NPCKPCNEDPB, Func<bool> JBHEEHEBNGL);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class GBGAOKLGJOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public HPJLDICLHHD targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public CBKEAKDLCBB property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public GBGAOKLGJOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x378B7A0", Offset = "0x3789FA0", VA = "0x18378B7A0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x378B8D0", Offset = "0x378A0D0", VA = "0x18378B8D0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6D5030", Offset = "0x6D3830", VA = "0x1806D5030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class JGEFHLGLGJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::PIGAIIKGKJJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public HLBKBJANPOI ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public JGEFHLGLGJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x259C570", Offset = "0x259AD70", VA = "0x18259C570")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, CBKEAKDLCBB property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MJOABEPADHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public MJOABEPADHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2FB06F0", Offset = "0x2FAEEF0", VA = "0x182FB06F0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2FB0840", Offset = "0x2FAF040", VA = "0x182FB0840")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3706140", Offset = "0x3704940", VA = "0x183706140")]
	protected PIGAIIKGKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3705910", Offset = "0x3704110", VA = "0x183705910", Slot = "5")]
	public virtual void EPPIECAHNIC(HPJLDICLHHD EPBNEGLCBCF, CBKEAKDLCBB NPCKPCNEDPB, HLBKBJANPOI MELCLAMGGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3705F90", Offset = "0x3704790", VA = "0x183705F90", Slot = "6")]
	protected virtual OKOCCIIIIGO NNMLLJGOMIK(HLBKBJANPOI MELCLAMGGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x37057C0", Offset = "0x3703FC0", VA = "0x1837057C0", Slot = "7")]
	protected virtual KNBKFEBOGKP AIFGCAPJKMF(HLBKBJANPOI MELCLAMGGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3705810", Offset = "0x3704010", VA = "0x183705810")]
	private static Enum EFFJMAFDFKB(HPJLDICLHHD EPBNEGLCBCF, CBKEAKDLCBB NPCKPCNEDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3705DB0", Offset = "0x37045B0", VA = "0x183705DB0")]
	private static void MCMEADJOLFK(HPJLDICLHHD EPBNEGLCBCF, CBKEAKDLCBB NPCKPCNEDPB, Enum NPHADDCNBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class CANFJCHBJAL : ICFCJDKFJMD, AIDALJNAAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CBKEAKDLCBB[] LABGKGEFBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private CBKEAKDLCBB[] JLPFADFCGKB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CBKEAKDLCBB[] BJLAHKDBOBF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public CBKEAKDLCBB[] NJGBPFELGDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract DMLMOBPCOID[] KAKKBPEAEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract DMLMOBPCOID[] NHOLIMGLAAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6521B40", Offset = "0x6520340", VA = "0x186521B40", Slot = "6")]
	public void AOGHGHFDMOA(IOIEJFCEOCP GKEOGLHPNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void EPPIECAHNIC(HPJLDICLHHD EPBNEGLCBCF, HLBKBJANPOI MELCLAMGGJA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1F32130", Offset = "0x1F30930", VA = "0x181F32130")]
	protected static T EADBNBEHDFK<T>(HPJLDICLHHD EPBNEGLCBCF, CBKEAKDLCBB NPCKPCNEDPB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F32180", Offset = "0x1F30980", VA = "0x181F32180")]
	protected static void IFNEIMFKBLE<T>(HPJLDICLHHD EPBNEGLCBCF, CBKEAKDLCBB NPCKPCNEDPB, T NPHADDCNBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	protected CANFJCHBJAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class PMMPIFAAANN<T> : PNOPJLJOLIO, AIDALJNAAAL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void MNINOBBBJNE(Func<T> EIKMMDPAEAP, Action<T> IIAHLGNADOM, string LOIAMCEJAFO, CBKEAKDLCBB NPCKPCNEDPB, Func<bool> JBHEEHEBNGL);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class HPPKKGAKCJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public HPJLDICLHHD targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CBKEAKDLCBB property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public HPPKKGAKCJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x324F420", Offset = "0x324DC20", VA = "0x18324F420")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x324F6D0", Offset = "0x324DED0", VA = "0x18324F6D0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6D5030", Offset = "0x6D3830", VA = "0x1806D5030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3718220", Offset = "0x3716A20", VA = "0x183718220")]
	protected PMMPIFAAANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3717060", Offset = "0x3715860", VA = "0x183717060", Slot = "4")]
	public void EPPIECAHNIC(HPJLDICLHHD EPBNEGLCBCF, CBKEAKDLCBB NPCKPCNEDPB, HLBKBJANPOI MELCLAMGGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract MNINOBBBJNE NNMLLJGOMIK(HLBKBJANPOI MELCLAMGGJA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3716740", Offset = "0x3714F40", VA = "0x183716740")]
	private static T EADBNBEHDFK(HPJLDICLHHD EPBNEGLCBCF, CBKEAKDLCBB NPCKPCNEDPB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3717BD0", Offset = "0x37163D0", VA = "0x183717BD0")]
	private static void IFNEIMFKBLE(HPJLDICLHHD EPBNEGLCBCF, CBKEAKDLCBB NPCKPCNEDPB, T NPHADDCNBHE)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[IECCMKJMAAC(LAEALBOAPLI.ConfigUI)]
	[FIKNCOOOHID(typeof(BPPILHDNJKJ), new string[] { })]
	internal class ConfigUIService : BPPILHDNJKJ, HNOABDNADGF, INBMAMBAHGE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[EOIIILOBJAK]
		private IOIEJFCEOCP GKEOGLHPNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[EOIIILOBJAK]
		private DAKEIBCIDGC GOCPBKLGPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[EOIIILOBJAK]
		private HLBKBJANPOI ELHDHEPPIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private NPIPPONHEAH PCIANCPIMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private HPJLDICLHHD EPBNEGLCBCF;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6522460", Offset = "0x6520C60", VA = "0x186522460", Slot = "5")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6522160", Offset = "0x6520960", VA = "0x186522160", Slot = "6")]
		public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6522A60", Offset = "0x6521260", VA = "0x186522A60", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x65224F0", Offset = "0x6520CF0", VA = "0x1865224F0", Slot = "4")]
		public void DLONACCPGND(HPJLDICLHHD IPFBBKHNCME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6522DD0", Offset = "0x65215D0", VA = "0x186522DD0")]
		private void GAAMOBFCJAN(HPJLDICLHHD IPFBBKHNCME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6522E60", Offset = "0x6521660", VA = "0x186522E60")]
		private void PCOEKEIOCOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6522B50", Offset = "0x6521350", VA = "0x186522B50")]
		private void EPPIECAHNIC(BIIJIPGOGIE HKFGBAOBKDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[JMFIMDAACND(0)]
internal class ALPODNIFOMK : KOBLLCKBEFL
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6521780", Offset = "0x651FF80", VA = "0x186521780", Slot = "9")]
	public override bool BBIJMBKEPGH(Type EHPFPOFFCEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6521830", Offset = "0x6520030", VA = "0x186521830", Slot = "6")]
	protected override OKOCCIIIIGO NNMLLJGOMIK(HLBKBJANPOI MELCLAMGGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6521920", Offset = "0x6520120", VA = "0x186521920")]
	public ALPODNIFOMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[JMFIMDAACND(0)]
internal class NPBPMPKGFOI : KOBLLCKBEFL
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x65262D0", Offset = "0x6524AD0", VA = "0x1865262D0", Slot = "9")]
	public override bool BBIJMBKEPGH(Type EHPFPOFFCEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6526380", Offset = "0x6524B80", VA = "0x186526380", Slot = "6")]
	protected override OKOCCIIIIGO NNMLLJGOMIK(HLBKBJANPOI MELCLAMGGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6521920", Offset = "0x6520120", VA = "0x186521920")]
	public NPBPMPKGFOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AJBKINHDFEM(typeof(IPLMEANFGMP), 1)]
internal class BNGKIHGACLC : global::PIGAIIKGKJJ<IPLMEANFGMP>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6521A10", Offset = "0x6520210", VA = "0x186521A10", Slot = "7")]
	protected override KNBKFEBOGKP AIFGCAPJKMF(HLBKBJANPOI MELCLAMGGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6521B00", Offset = "0x6520300", VA = "0x186521B00")]
	public BNGKIHGACLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PABLDMGIBAO
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6527730", Offset = "0x6525F30", VA = "0x186527730")]
	public static bool FFNAJBGLKIJ(this CBKEAKDLCBB NPCKPCNEDPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[LDILMBADAHK(2)]
internal class KFJIKIGMFIH : CANFJCHBJAL
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class GHGJPHBAFKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public HPJLDICLHHD targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public KFJIKIGMFIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public GHGJPHBAFKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6523860", Offset = "0x6522060", VA = "0x186523860")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6523990", Offset = "0x6522190", VA = "0x186523990")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6D5030", Offset = "0x6D3830", VA = "0x1806D5030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override DMLMOBPCOID[] NHOLIMGLAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6525460", Offset = "0x6523C60", VA = "0x186525460", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override DMLMOBPCOID[] KAKKBPEAEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6524FC0", Offset = "0x65237C0", VA = "0x186524FC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x65250A0", Offset = "0x65238A0", VA = "0x1865250A0", Slot = "10")]
	public override void EPPIECAHNIC(HPJLDICLHHD EPBNEGLCBCF, HLBKBJANPOI MELCLAMGGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public KFJIKIGMFIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[AJBKINHDFEM(typeof(bool))]
internal class MPHLEHMOBFM : global::PMMPIFAAANN<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x65260A0", Offset = "0x65248A0", VA = "0x1865260A0", Slot = "5")]
	protected override MNINOBBBJNE NNMLLJGOMIK(HLBKBJANPOI MELCLAMGGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6526190", Offset = "0x6524990", VA = "0x186526190")]
	public MPHLEHMOBFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[AJBKINHDFEM(typeof(FixedString32))]
internal class OIDLMJDJKDN : global::PMMPIFAAANN<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class MDCHNIDKPJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public HLBKBJANPOI ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public MDCHNIDKPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6525F10", Offset = "0x6524710", VA = "0x186525F10")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, CBKEAKDLCBB property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FLCABBKFNGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public FLCABBKFNGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6523420", Offset = "0x6521C20", VA = "0x186523420")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6523490", Offset = "0x6521C90", VA = "0x186523490")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6527630", Offset = "0x6525E30", VA = "0x186527630", Slot = "5")]
	protected override MNINOBBBJNE NNMLLJGOMIK(HLBKBJANPOI MELCLAMGGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x65276F0", Offset = "0x6525EF0", VA = "0x1865276F0")]
	public OIDLMJDJKDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AJBKINHDFEM(typeof(FixedString64))]
internal class NBGKDNBLFAL : global::PMMPIFAAANN<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class JEIHPBBPKGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HLBKBJANPOI ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public JEIHPBBPKGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6524D30", Offset = "0x6523530", VA = "0x186524D30")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, CBKEAKDLCBB property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class EIEOKDNILOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public EIEOKDNILOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6522EE0", Offset = "0x65216E0", VA = "0x186522EE0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6522F70", Offset = "0x6521770", VA = "0x186522F70")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x65261D0", Offset = "0x65249D0", VA = "0x1865261D0", Slot = "5")]
	protected override MNINOBBBJNE NNMLLJGOMIK(HLBKBJANPOI MELCLAMGGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6526290", Offset = "0x6524A90", VA = "0x186526290")]
	public NBGKDNBLFAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[AJBKINHDFEM(typeof(float))]
internal class HBJEMNGAABE : global::PMMPIFAAANN<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6523A20", Offset = "0x6522220", VA = "0x186523A20", Slot = "5")]
	protected override MNINOBBBJNE NNMLLJGOMIK(HLBKBJANPOI MELCLAMGGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6523B10", Offset = "0x6522310", VA = "0x186523B10")]
	public HBJEMNGAABE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[AJBKINHDFEM(typeof(int))]
internal class CGKIPNOJGAF : global::PMMPIFAAANN<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6521F50", Offset = "0x6520750", VA = "0x186521F50", Slot = "5")]
	protected override MNINOBBBJNE NNMLLJGOMIK(HLBKBJANPOI MELCLAMGGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6522040", Offset = "0x6520840", VA = "0x186522040")]
	public CGKIPNOJGAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[AJBKINHDFEM(typeof(uint))]
internal class JFGLEBCNLNL : global::PMMPIFAAANN<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IOCHMBBMNCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public HLBKBJANPOI ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public IOCHMBBMNCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6524B50", Offset = "0x6523350", VA = "0x186524B50")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, CBKEAKDLCBB property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class BKCNPMNODJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public BKCNPMNODJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6521960", Offset = "0x6520160", VA = "0x186521960")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x65219B0", Offset = "0x65201B0", VA = "0x1865219B0")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6524EC0", Offset = "0x65236C0", VA = "0x186524EC0", Slot = "5")]
	protected override MNINOBBBJNE NNMLLJGOMIK(HLBKBJANPOI MELCLAMGGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6524F80", Offset = "0x6523780", VA = "0x186524F80")]
	public JFGLEBCNLNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AJBKINHDFEM(typeof(Vector3))]
internal class IDIDIOJILPG : global::PMMPIFAAANN<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GBMHANMEDKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public HLBKBJANPOI ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public GBMHANMEDKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6523510", Offset = "0x6521D10", VA = "0x186523510")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, CBKEAKDLCBB property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LGIEBPIFNPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public LGIEBPIFNPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6525CF0", Offset = "0x65244F0", VA = "0x186525CF0")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6525D50", Offset = "0x6524550", VA = "0x186525D50")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6525D60", Offset = "0x6524560", VA = "0x186525D60")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6525DC0", Offset = "0x65245C0", VA = "0x186525DC0")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6525DD0", Offset = "0x65245D0", VA = "0x186525DD0")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6525E30", Offset = "0x6524630", VA = "0x186525E30")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6524690", Offset = "0x6522E90", VA = "0x186524690", Slot = "5")]
	protected override MNINOBBBJNE NNMLLJGOMIK(HLBKBJANPOI MELCLAMGGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6524750", Offset = "0x6522F50", VA = "0x186524750")]
	public IDIDIOJILPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct BIIJIPGOGIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int BPEJEIPMOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int OJCGEOAHKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int PPMAMPIHEGB;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class CMNODBEKJGL
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6522080", Offset = "0x6520880", VA = "0x186522080")]
	public static void LNBLAHKNBPL(Type BAGHGKLKIJL, Type HDPJNMOOPLF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct IMBHHANEJFB
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6524790", Offset = "0x6522F90", VA = "0x186524790")]
	public static NativeList<int> JNPGOMAPINF(HPJLDICLHHD EPBNEGLCBCF, DAKEIBCIDGC GOCPBKLGPNG)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6524970", Offset = "0x6523170", VA = "0x186524970")]
	private static bool KNCOEAFBJKC(CBKEAKDLCBB NPCKPCNEDPB, HPJLDICLHHD EPBNEGLCBCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class HOPMDFHNHPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly DAKEIBCIDGC GOCPBKLGPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly IOIEJFCEOCP GKEOGLHPNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly HLBKBJANPOI MELCLAMGGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<BIIJIPGOGIE> BEBOAMKPGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<BDHEIHALJHA> EDDHBEEDLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<BDHEIHALJHA, List<BIIJIPGOGIE>> COJPEBLPMEI;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6524570", Offset = "0x6522D70", VA = "0x186524570")]
	public HOPMDFHNHPF(DAKEIBCIDGC GOCPBKLGPNG, IOIEJFCEOCP GKEOGLHPNDK, HLBKBJANPOI MELCLAMGGJA, Action<BIIJIPGOGIE> BEBOAMKPGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6523B50", Offset = "0x6522350", VA = "0x186523B50")]
	public void BHBCEMBPGNJ(NativeList<BIIJIPGOGIE> LJBELOFEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x65243B0", Offset = "0x6522BB0", VA = "0x1865243B0")]
	private void NOEPFLEMICI(BDHEIHALJHA DAMNENENKAO, BIIJIPGOGIE HKFGBAOBKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6523ED0", Offset = "0x65226D0", VA = "0x186523ED0")]
	public void HCHFAOOBOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6523F30", Offset = "0x6522730", VA = "0x186523F30")]
	private void NLAKFHHCLGG(BDHEIHALJHA DAMNENENKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x65244D0", Offset = "0x6522CD0", VA = "0x1865244D0")]
	private void OJLHDANEFFL(BDHEIHALJHA DAMNENENKAO)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[IECCMKJMAAC(LAEALBOAPLI.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class FCJJGIKHMHM : IEnumerable<CBKEAKDLCBB>, IEnumerable, IEnumerator<CBKEAKDLCBB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private CBKEAKDLCBB <>2__current;

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
			private CBKEAKDLCBB System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8B0110", Offset = "0x8AE910", VA = "0x1808B0110")]
			[DebuggerHidden]
			public FCJJGIKHMHM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6523350", Offset = "0x6521B50", VA = "0x186523350", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6523010", Offset = "0x6521810", VA = "0x186523010", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x65233D0", Offset = "0x6521BD0", VA = "0x1865233D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6523310", Offset = "0x6521B10", VA = "0x186523310", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6523260", Offset = "0x6521A60", VA = "0x186523260", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<CBKEAKDLCBB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6523260", Offset = "0x6521A60", VA = "0x186523260", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly IOIEJFCEOCP GKEOGLHPNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> OLGMGOFPJLJ;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6527A50", Offset = "0x6526250", VA = "0x186527A50")]
		public PropertiesByType(IOIEJFCEOCP GKEOGLHPNDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6527970", Offset = "0x6526170", VA = "0x186527970")]
		[IteratorStateMachine(typeof(FCJJGIKHMHM))]
		public IEnumerable<CBKEAKDLCBB> NNNJEFJINJH(Type EHPFPOFFCEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6527930", Offset = "0x6526130", VA = "0x186527930", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6527870", Offset = "0x6526070", VA = "0x186527870")]
		private long BCABMOPDLHH(CBKEAKDLCBB NPCKPCNEDPB)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x65278F0", Offset = "0x65260F0", VA = "0x1865278F0")]
		private long BCABMOPDLHH(Type EHPFPOFFCEJ)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct AHBKIIMIOCD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray HFMGFNGKPBB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6521740", Offset = "0x651FF40", VA = "0x186521740")]
	public AHBKIIMIOCD(int FCKFNIPNJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6521450", Offset = "0x651FC50", VA = "0x186521450")]
	public static AHBKIIMIOCD DJMDFEMNJFN(int EBGHKBFPDCN, NativeArray<int> AIDEINAMABM)
	{
		return default(AHBKIIMIOCD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6521730", Offset = "0x651FF30", VA = "0x186521730")]
	public bool LNCJBLPDGGH(int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6521440", Offset = "0x651FC40", VA = "0x186521440")]
	public void BJPKOCBPDKP(int LHHBOCAHDEE, bool NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x65215B0", Offset = "0x651FDB0", VA = "0x1865215B0")]
	public bool HIPNFCIIFJJ(CBKEAKDLCBB[] AIDEINAMABM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6521670", Offset = "0x651FE70", VA = "0x186521670")]
	public bool LEINDLOOEMD(CBKEAKDLCBB[] AIDEINAMABM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x65215A0", Offset = "0x651FDA0", VA = "0x1865215A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class NPIPPONHEAH
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly DELGGOALDMF MGFJDFPNJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly DAKEIBCIDGC GOCPBKLGPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IOIEJFCEOCP GKEOGLHPNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<AIDALJNAAAL> KJPDNFOGEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType OLGMGOFPJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> IDDGGABMLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> OGCAALNFAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool KFGNFGMLOIE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<AIDALJNAAAL> OABAPENLCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x65274E0", Offset = "0x6525CE0", VA = "0x1865274E0")]
	public NPIPPONHEAH(DAKEIBCIDGC GOCPBKLGPNG, IOIEJFCEOCP GKEOGLHPNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6526920", Offset = "0x6525120", VA = "0x186526920")]
	public void IPHJFMDKADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6526470", Offset = "0x6524C70", VA = "0x186526470")]
	public void AKOAAMELPKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6527030", Offset = "0x6525830", VA = "0x186527030")]
	public NativeList<BIIJIPGOGIE> NILACLEAKEC(NativeArray<int> AIDEINAMABM)
	{
		return default(NativeList<BIIJIPGOGIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x65266B0", Offset = "0x6524EB0", VA = "0x1865266B0")]
	private bool CNKKLMCGIFK(AIDALJNAAAL LDAGAPBIMHH, AHBKIIMIOCD KAINBOOGIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x35EDE50", Offset = "0x35EC650", VA = "0x1835EDE50")]
	private void IENHHAEDCHF<TInterface, TAttribute>(Action<TInterface, TAttribute> CLLJAFACIBM) where TInterface : AIDALJNAAAL where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6526CA0", Offset = "0x65254A0", VA = "0x186526CA0")]
	private void LFDPFIBKBIN(Type EHPFPOFFCEJ, Type NLNDAMJGLEN, Type LNEBCMJPOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x35EE0F0", Offset = "0x35EC8F0", VA = "0x1835EE0F0")]
	private TInterface NFCBPGJFJHO<TInterface>(Type EHPFPOFFCEJ)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x65265E0", Offset = "0x6524DE0", VA = "0x1865265E0")]
	private void CIJCONJOBIG(AIDALJNAAAL LDAGAPBIMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6526CD0", Offset = "0x65254D0", VA = "0x186526CD0")]
	private int LPMNLJEHOED(AIDALJNAAAL FOBIHCDPIBJ, int PPMAMPIHEGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x65269F0", Offset = "0x65251F0", VA = "0x1865269F0")]
	private void JFNMHHNCGDG(PNOPJLJOLIO LDAGAPBIMHH, AJBKINHDFEM BIFADJFJBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6526D70", Offset = "0x6525570", VA = "0x186526D70")]
	private void MMPMFCBDPPE(EGCOCBFACDM LDAGAPBIMHH, JMFIMDAACND BIFADJFJBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6526780", Offset = "0x6524F80", VA = "0x186526780")]
	private void DFFOILGKBBE(ICFCJDKFJMD LDAGAPBIMHH, LDILMBADAHK BIFADJFJBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct KJOFIMMKHHD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IOIEJFCEOCP GKEOGLHPNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<AIDALJNAAAL> KJPDNFOGEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<BIIJIPGOGIE> ICAMOBBOFGD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<BIIJIPGOGIE> GGNLCICHMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCDB3C0", Offset = "0xCD9BC0", VA = "0x180CDB3C0")]
		get
		{
			return default(NativeList<BIIJIPGOGIE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6525C10", Offset = "0x6524410", VA = "0x186525C10")]
	public KJOFIMMKHHD(IOIEJFCEOCP GKEOGLHPNDK, List<AIDALJNAAAL> KJPDNFOGEEF, NativeArray<BIIJIPGOGIE> LJBELOFEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x65257D0", Offset = "0x6523FD0", VA = "0x1865257D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6525810", Offset = "0x6524010", VA = "0x186525810")]
	private NativeList<BIIJIPGOGIE> IELLPLOJECH(NativeArray<BIIJIPGOGIE> LEMEKBDMAFK)
	{
		return default(NativeList<BIIJIPGOGIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6525540", Offset = "0x6523D40", VA = "0x186525540")]
	private bool ABAMAPFPGAF(AIDALJNAAAL LDAGAPBIMHH, AHBKIIMIOCD OLINPNKGBMC, int OJCGEOAHKBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6525610", Offset = "0x6523E10", VA = "0x186525610")]
	private void DJIFNPAHPCP(AIDALJNAAAL LDAGAPBIMHH, AHBKIIMIOCD HFMGFNGKPBB, int OJCGEOAHKBL)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct LFJGDCKCBHN : IComparer<BIIJIPGOGIE>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6525C90", Offset = "0x6524490", VA = "0x186525C90", Slot = "4")]
	public int Compare(BIIJIPGOGIE HDPOKDCLGGE, BIIJIPGOGIE JBKIIGINOKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6525CA0", Offset = "0x65244A0", VA = "0x186525CA0")]
	public static void EEHNICGMFPD(NativeList<BIIJIPGOGIE> LJBELOFEEEN)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : PMFBNHDKHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6527D50", Offset = "0x6526550", VA = "0x186527D50", Slot = "6")]
		public sealed override void ICNICBCAKMK(DPEPEONFLCL MKOFIMIHGLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6527E50", Offset = "0x6526650", VA = "0x186527E50", Slot = "4")]
		public sealed override void JBLIKMGAHBK()
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
