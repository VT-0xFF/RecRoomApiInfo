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
internal abstract class OANAEPLOBFH : global::MFCDKDPDIEE<Enum>, CCEPELHIGPN, CMKCOPJLMDL, NAAMMKHGMGA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool BIEOJPJAHCL(Type MCLMFJEAHEC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD770", Offset = "0x5FCC170", VA = "0x185FCD770")]
	protected OANAEPLOBFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class MFCDKDPDIEE<T> : CMKCOPJLMDL, NAAMMKHGMGA where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void ACOHGKEBGPJ(Func<T> PMNONIKDKHB, Action<T> LGPKJBBIKKA, string NBODBMLPNJA, MIKODHFFJMF LNOIPGJELOP, Func<bool> MAGLBHMIBLP);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void JHMOGGFMHOB(Func<int> PMNONIKDKHB, Action<int> LGPKJBBIKKA, string NBODBMLPNJA, MIKODHFFJMF LNOIPGJELOP, Func<bool> MAGLBHMIBLP);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class LELCHBEFPED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public OKKOFBJCFMA targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MIKODHFFJMF property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public LELCHBEFPED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B1E0", Offset = "0x1E29BE0", VA = "0x181E2B1E0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B310", Offset = "0x1E29D10", VA = "0x181E2B310")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675A30", VA = "0x180677030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class HEHKDECMJFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::MFCDKDPDIEE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public AFIELLPAPGK ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public HEHKDECMJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2E54450", Offset = "0x2E52E50", VA = "0x182E54450")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, MIKODHFFJMF property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class BMIJLNGEMJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public BMIJLNGEMJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3437150", Offset = "0x3435B50", VA = "0x183437150")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x34372A0", Offset = "0x3435CA0", VA = "0x1834372A0")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E97060", Offset = "0x2E95A60", VA = "0x182E97060")]
	protected MFCDKDPDIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2E96740", Offset = "0x2E95140", VA = "0x182E96740", Slot = "5")]
	public virtual void CBBDJJLJMKE(OKKOFBJCFMA DLOBABKCMJG, MIKODHFFJMF LNOIPGJELOP, AFIELLPAPGK CMFNPEENAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2E96BE0", Offset = "0x2E955E0", VA = "0x182E96BE0", Slot = "6")]
	protected virtual ACOHGKEBGPJ COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2E97010", Offset = "0x2E95A10", VA = "0x182E97010", Slot = "7")]
	protected virtual JHMOGGFMHOB NIPIEAKABDG(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2E96CE0", Offset = "0x2E956E0", VA = "0x182E96CE0")]
	private static Enum DEOJADDKGMC(OKKOFBJCFMA DLOBABKCMJG, MIKODHFFJMF LNOIPGJELOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2E96ED0", Offset = "0x2E958D0", VA = "0x182E96ED0")]
	private static void GEACOJCKOGD(OKKOFBJCFMA DLOBABKCMJG, MIKODHFFJMF LNOIPGJELOP, Enum MAKFNMHIJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class BIPICHANJPB : NHBDEHAJKNN, NAAMMKHGMGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private MIKODHFFJMF[] DJGNGMGCMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private MIKODHFFJMF[] GMLOOMEOCDD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MIKODHFFJMF[] LNEOAHNGJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public MIKODHFFJMF[] CMHKGMAHEKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract DMNHKHOLGBO[] FGDEPABAPPA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract DMNHKHOLGBO[] LGLAOJAFLHL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCE50", Offset = "0x5FCB850", VA = "0x185FCCE50", Slot = "6")]
	public void IFEPEMKMGAF(GIHCPFBMAPF GLIDFGCEEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void CBBDJJLJMKE(OKKOFBJCFMA DLOBABKCMJG, AFIELLPAPGK CMFNPEENAMD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x25E4C00", Offset = "0x25E3600", VA = "0x1825E4C00")]
	protected static T BAHJCIEPMGA<T>(OKKOFBJCFMA DLOBABKCMJG, MIKODHFFJMF LNOIPGJELOP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x25E4C50", Offset = "0x25E3650", VA = "0x1825E4C50")]
	protected static void OAFINNBIOFN<T>(OKKOFBJCFMA DLOBABKCMJG, MIKODHFFJMF LNOIPGJELOP, T MAKFNMHIJIF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	protected BIPICHANJPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class EKBFHGEBEAC<T> : CMKCOPJLMDL, NAAMMKHGMGA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void ECOKIFIEGJI(Func<T> PMNONIKDKHB, Action<T> LGPKJBBIKKA, string NBODBMLPNJA, MIKODHFFJMF LNOIPGJELOP, Func<bool> MAGLBHMIBLP);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class MFIJIOLMJOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public OKKOFBJCFMA targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MIKODHFFJMF property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public MFIJIOLMJOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2E97440", Offset = "0x2E95E40", VA = "0x182E97440")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2E97670", Offset = "0x2E96070", VA = "0x182E97670")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675A30", VA = "0x180677030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2915130", Offset = "0x2913B30", VA = "0x182915130")]
	protected EKBFHGEBEAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2913CA0", Offset = "0x29126A0", VA = "0x182913CA0", Slot = "4")]
	public void CBBDJJLJMKE(OKKOFBJCFMA DLOBABKCMJG, MIKODHFFJMF LNOIPGJELOP, AFIELLPAPGK CMFNPEENAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x29139B0", Offset = "0x29123B0", VA = "0x1829139B0")]
	private static T BAHJCIEPMGA(OKKOFBJCFMA DLOBABKCMJG, MIKODHFFJMF LNOIPGJELOP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2914F00", Offset = "0x2913900", VA = "0x182914F00")]
	private static void OAFINNBIOFN(OKKOFBJCFMA DLOBABKCMJG, MIKODHFFJMF LNOIPGJELOP, T MAKFNMHIJIF)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DAINLFLPADL(OHEDAGNNHJA.ConfigUI)]
	[DHKIICMHACJ(typeof(FOGEJHJAIDC), new string[] { })]
	internal class ConfigUIService : FOGEJHJAIDC, GOJCOOFCPOI, GKFAMMKGENJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[CJONPMHNDBN]
		private GIHCPFBMAPF GLIDFGCEEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[CJONPMHNDBN]
		private MAKFOFFGOPC NFJBJDBBCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[CJONPMHNDBN]
		private AFIELLPAPGK JDNFNAIJAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EBCBCIIHONG GCONHEIANAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private OKKOFBJCFMA DLOBABKCMJG;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE4B0", Offset = "0x5FCCEB0", VA = "0x185FCE4B0", Slot = "5")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDA90", Offset = "0x5FCC490", VA = "0x185FCDA90", Slot = "6")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDD90", Offset = "0x5FCC790", VA = "0x185FCDD90", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDEB0", Offset = "0x5FCC8B0", VA = "0x185FCDEB0", Slot = "4")]
		public void MCOMKLEPAHE(OKKOFBJCFMA AALKPMMEGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE420", Offset = "0x5FCCE20", VA = "0x185FCE420")]
		private void MOFPGHNIHIN(OKKOFBJCFMA AALKPMMEGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDE80", Offset = "0x5FCC880", VA = "0x185FCDE80")]
		private void EIPOBJPILMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD810", Offset = "0x5FCC210", VA = "0x185FCD810")]
		private void CBBDJJLJMKE(JBKIANPAIEO OCMDKMBJDKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[AOACKBFDNGA(0)]
internal class CIIHKBGANFP : OANAEPLOBFH
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD5D0", Offset = "0x5FCBFD0", VA = "0x185FCD5D0", Slot = "9")]
	public override bool BIEOJPJAHCL(Type MCLMFJEAHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD680", Offset = "0x5FCC080", VA = "0x185FCD680", Slot = "6")]
	protected override ACOHGKEBGPJ COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD770", Offset = "0x5FCC170", VA = "0x185FCD770")]
	public CIIHKBGANFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[AOACKBFDNGA(0)]
internal class ELAJCNIIKCD : OANAEPLOBFH
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF970", Offset = "0x5FCE370", VA = "0x185FCF970", Slot = "9")]
	public override bool BIEOJPJAHCL(Type MCLMFJEAHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5FCFA20", Offset = "0x5FCE420", VA = "0x185FCFA20", Slot = "6")]
	protected override ACOHGKEBGPJ COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD770", Offset = "0x5FCC170", VA = "0x185FCD770")]
	public ELAJCNIIKCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[EFGFBOHCNLJ(typeof(JNEJGOPIMPI), 1)]
internal class OJKGHLBONBA : global::MFCDKDPDIEE<JNEJGOPIMPI>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1DE0", Offset = "0x5FD07E0", VA = "0x185FD1DE0", Slot = "7")]
	protected override JHMOGGFMHOB NIPIEAKABDG(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1ED0", Offset = "0x5FD08D0", VA = "0x185FD1ED0")]
	public OJKGHLBONBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PDGAMPLGJBG
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2100", Offset = "0x5FD0B00", VA = "0x185FD2100")]
	public static bool EIGAMOEMIFK(this MIKODHFFJMF LNOIPGJELOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[FHEJKFHHHJG(2)]
internal class APHJDNPFNLH : BIPICHANJPB
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class HMLMNKCCGEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public OKKOFBJCFMA targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public APHJDNPFNLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public HMLMNKCCGEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0D60", Offset = "0x5FCF760", VA = "0x185FD0D60")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0E90", Offset = "0x5FCF890", VA = "0x185FD0E90")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675A30", VA = "0x180677030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override DMNHKHOLGBO[] LGLAOJAFLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5FCCD70", Offset = "0x5FCB770", VA = "0x185FCCD70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override DMNHKHOLGBO[] FGDEPABAPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5FCCC90", Offset = "0x5FCB690", VA = "0x185FCCC90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC8D0", Offset = "0x5FCB2D0", VA = "0x185FCC8D0", Slot = "10")]
	public override void CBBDJJLJMKE(OKKOFBJCFMA DLOBABKCMJG, AFIELLPAPGK CMFNPEENAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public APHJDNPFNLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[EFGFBOHCNLJ(typeof(bool))]
internal class JBEPAIIJECE : global::EKBFHGEBEAC<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1740", Offset = "0x5FD0140", VA = "0x185FD1740", Slot = "5")]
	protected override ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1830", Offset = "0x5FD0230", VA = "0x185FD1830")]
	public JBEPAIIJECE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[EFGFBOHCNLJ(typeof(FixedString32))]
internal class PBGJCHEEBHM : global::EKBFHGEBEAC<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BMMGCGGICEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AFIELLPAPGK ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public BMMGCGGICEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD260", Offset = "0x5FCBC60", VA = "0x185FCD260")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, MIKODHFFJMF property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PAHAOGGKNGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public PAHAOGGKNGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1F10", Offset = "0x5FD0910", VA = "0x185FD1F10")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1F80", Offset = "0x5FD0980", VA = "0x185FD1F80")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2000", Offset = "0x5FD0A00", VA = "0x185FD2000", Slot = "5")]
	protected override ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5FD20C0", Offset = "0x5FD0AC0", VA = "0x185FD20C0")]
	public PBGJCHEEBHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[EFGFBOHCNLJ(typeof(FixedString64))]
internal class KDOJCDIEAKB : global::EKBFHGEBEAC<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PKMFCAFJEAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AFIELLPAPGK ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public PKMFCAFJEAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2240", Offset = "0x5FD0C40", VA = "0x185FD2240")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, MIKODHFFJMF property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MGPHKNOJEIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public MGPHKNOJEIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1CB0", Offset = "0x5FD06B0", VA = "0x185FD1CB0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1D40", Offset = "0x5FD0740", VA = "0x185FD1D40")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1870", Offset = "0x5FD0270", VA = "0x185FD1870", Slot = "5")]
	protected override ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1930", Offset = "0x5FD0330", VA = "0x185FD1930")]
	public KDOJCDIEAKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[EFGFBOHCNLJ(typeof(float))]
internal class IANMCGFDCHA : global::EKBFHGEBEAC<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1100", Offset = "0x5FCFB00", VA = "0x185FD1100", Slot = "5")]
	protected override ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FD11F0", Offset = "0x5FCFBF0", VA = "0x185FD11F0")]
	public IANMCGFDCHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[EFGFBOHCNLJ(typeof(int))]
internal class HMNPDCGHDDM : global::EKBFHGEBEAC<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5FD0F20", Offset = "0x5FCF920", VA = "0x185FD0F20", Slot = "5")]
	protected override ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1010", Offset = "0x5FCFA10", VA = "0x185FD1010")]
	public HMNPDCGHDDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[EFGFBOHCNLJ(typeof(uint))]
internal class IIGCEFDHANB : global::EKBFHGEBEAC<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class AAGBHJDPJGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AFIELLPAPGK ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public AAGBHJDPJGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5FCBFA0", Offset = "0x5FCA9A0", VA = "0x185FCBFA0")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, MIKODHFFJMF property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HOKBPOEPHJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public HOKBPOEPHJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1050", Offset = "0x5FCFA50", VA = "0x185FD1050")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5FD10A0", Offset = "0x5FCFAA0", VA = "0x185FD10A0")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1640", Offset = "0x5FD0040", VA = "0x185FD1640", Slot = "5")]
	protected override ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1700", Offset = "0x5FD0100", VA = "0x185FD1700")]
	public IIGCEFDHANB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[EFGFBOHCNLJ(typeof(Vector3))]
internal class CAKOPDFINPP : global::EKBFHGEBEAC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ENNNCMLJFEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AFIELLPAPGK ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public ENNNCMLJFEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5FCFB10", Offset = "0x5FCE510", VA = "0x185FCFB10")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, MIKODHFFJMF property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DJCFAMEKMDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public DJCFAMEKMDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE590", Offset = "0x5FCCF90", VA = "0x185FCE590")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE5F0", Offset = "0x5FCCFF0", VA = "0x185FCE5F0")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE600", Offset = "0x5FCD000", VA = "0x185FCE600")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE660", Offset = "0x5FCD060", VA = "0x185FCE660")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE670", Offset = "0x5FCD070", VA = "0x185FCE670")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE6D0", Offset = "0x5FCD0D0", VA = "0x185FCE6D0")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD3F0", Offset = "0x5FCBDF0", VA = "0x185FCD3F0", Slot = "5")]
	protected override ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD4B0", Offset = "0x5FCBEB0", VA = "0x185FCD4B0")]
	public CAKOPDFINPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct JBKIANPAIEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int EDKCHILEHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int LMHILALBFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int IPGJOMPJEJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class CFDCLFJCEDB
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD4F0", Offset = "0x5FCBEF0", VA = "0x185FCD4F0")]
	public static void OEJJLOEHGOI(Type OLOFGPGIMAL, Type KAGJIFJNHPM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct FJLKJONPFDB
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5FD09A0", Offset = "0x5FCF3A0", VA = "0x185FD09A0")]
	public static NativeList<int> DDABHDNFIKM(OKKOFBJCFMA DLOBABKCMJG, MAKFOFFGOPC NFJBJDBBCED)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5FD0B80", Offset = "0x5FCF580", VA = "0x185FD0B80")]
	private static bool GKDAICIKHNM(MIKODHFFJMF LNOIPGJELOP, OKKOFBJCFMA DLOBABKCMJG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class FBNOCMMJBKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly MAKFOFFGOPC NFJBJDBBCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly GIHCPFBMAPF GLIDFGCEEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly AFIELLPAPGK CMFNPEENAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<JBKIANPAIEO> CDJGHEJLLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<NPKIDEECJBB> FKBDJIBOHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<NPKIDEECJBB, List<JBKIANPAIEO>> DBDCAEDMKDM;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5FD0880", Offset = "0x5FCF280", VA = "0x185FD0880")]
	public FBNOCMMJBKI(MAKFOFFGOPC NFJBJDBBCED, GIHCPFBMAPF GLIDFGCEEAN, AFIELLPAPGK CMFNPEENAMD, Action<JBKIANPAIEO> CDJGHEJLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5FCFE60", Offset = "0x5FCE860", VA = "0x185FCFE60")]
	public void AMGCJPAGHDK(NativeList<JBKIANPAIEO> JJKIHDMAFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5FD0760", Offset = "0x5FCF160", VA = "0x185FD0760")]
	private void PAMKMJPDMCO(NPKIDEECJBB NABGGPANDBL, JBKIANPAIEO OCMDKMBJDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5FD0660", Offset = "0x5FCF060", VA = "0x185FD0660")]
	public void LOIJIOLEKGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5FD01E0", Offset = "0x5FCEBE0", VA = "0x185FD01E0")]
	private void KHPAMOGKKGC(NPKIDEECJBB NABGGPANDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5FD06C0", Offset = "0x5FCF0C0", VA = "0x185FD06C0")]
	private void NACNGGJHKLG(NPKIDEECJBB NABGGPANDBL)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[DAINLFLPADL(OHEDAGNNHJA.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class IEHPHCPFFKM : IEnumerable<MIKODHFFJMF>, IEnumerable, IEnumerator<MIKODHFFJMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private MIKODHFFJMF <>2__current;

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
			private MIKODHFFJMF System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E7E10", VA = "0x1808E9410")]
			[DebuggerHidden]
			public IEHPHCPFFKM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5FD1570", Offset = "0x5FCFF70", VA = "0x185FD1570", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5FD1230", Offset = "0x5FCFC30", VA = "0x185FD1230", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5FD15F0", Offset = "0x5FCFFF0", VA = "0x185FD15F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5FD1530", Offset = "0x5FCFF30", VA = "0x185FD1530", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5FD1480", Offset = "0x5FCFE80", VA = "0x185FD1480", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MIKODHFFJMF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5FD1480", Offset = "0x5FCFE80", VA = "0x185FD1480", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly GIHCPFBMAPF GLIDFGCEEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> NKAAGMHPCLD;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5FD25B0", Offset = "0x5FD0FB0", VA = "0x185FD25B0")]
		public PropertiesByType(GIHCPFBMAPF GLIDFGCEEAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5FD23D0", Offset = "0x5FD0DD0", VA = "0x185FD23D0")]
		[IteratorStateMachine(typeof(IEHPHCPFFKM))]
		public IEnumerable<MIKODHFFJMF> DMPGADBOHPL(Type MCLMFJEAHEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2460", Offset = "0x5FD0E60", VA = "0x185FD2460", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5FD24A0", Offset = "0x5FD0EA0", VA = "0x185FD24A0")]
		private long KBGKIEMJNDD(MIKODHFFJMF LNOIPGJELOP)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2520", Offset = "0x5FD0F20", VA = "0x185FD2520")]
		private long KBGKIEMJNDD(Type MCLMFJEAHEC)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct KHMPCJGDBKN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray JNKMEODPHMH;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1C70", Offset = "0x5FD0670", VA = "0x185FD1C70")]
	public KHMPCJGDBKN(int FPLNDBJJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1B00", Offset = "0x5FD0500", VA = "0x185FD1B00")]
	public static KHMPCJGDBKN IMNLJMMJPEO(int FHGNFGIEADL, NativeArray<int> KECMGAIBBMH)
	{
		return default(KHMPCJGDBKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1C60", Offset = "0x5FD0660", VA = "0x185FD1C60")]
	public bool PLBNCIKFCHN(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1C50", Offset = "0x5FD0650", VA = "0x185FD1C50")]
	public void KMNEKDAGPNL(int EBBLFLFCHFB, bool MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1970", Offset = "0x5FD0370", VA = "0x185FD1970")]
	public bool BJGBMDJKFHG(MIKODHFFJMF[] KECMGAIBBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1A30", Offset = "0x5FD0430", VA = "0x185FD1A30")]
	public bool CMIIBJDADHJ(MIKODHFFJMF[] KECMGAIBBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1AF0", Offset = "0x5FD04F0", VA = "0x185FD1AF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class EBCBCIIHONG
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly FGGEJMNNOEE LAEOPKAJMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MAKFOFFGOPC NFJBJDBBCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly GIHCPFBMAPF GLIDFGCEEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<NAAMMKHGMGA> OGPHEAGNPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType NKAAGMHPCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> DNMMLPKNPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> GIDFNCNBICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<NAAMMKHGMGA> NIMGABAFBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF820", Offset = "0x5FCE220", VA = "0x185FCF820")]
	public EBCBCIIHONG(MAKFOFFGOPC NFJBJDBBCED, GIHCPFBMAPF GLIDFGCEEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE9F0", Offset = "0x5FCD3F0", VA = "0x185FCE9F0")]
	public void BOHBKACNFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE7B0", Offset = "0x5FCD1B0", VA = "0x185FCE7B0")]
	public void AAMEFPKANOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5FCEAC0", Offset = "0x5FCD4C0", VA = "0x185FCEAC0")]
	public NativeList<JBKIANPAIEO> BPFDALFNPKJ(NativeArray<int> KECMGAIBBMH)
	{
		return default(NativeList<JBKIANPAIEO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE920", Offset = "0x5FCD320", VA = "0x185FCE920")]
	private bool BJODMPHMDCI(NAAMMKHGMGA LNDCPLAHPLG, KHMPCJGDBKN AGOFPIMFDFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C320", Offset = "0x1C5AD20", VA = "0x181C5C320")]
	private void FMALOJHJCCF<TInterface, TAttribute>(Action<TInterface, TAttribute> MALFJDJBPEF) where TInterface : NAAMMKHGMGA where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF600", Offset = "0x5FCE000", VA = "0x185FCF600")]
	private void MEKKMLDOFFP(Type MCLMFJEAHEC, Type ABHJFHMNBEO, Type FMAKDFECFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C5C0", Offset = "0x1C5AFC0", VA = "0x181C5C5C0")]
	private TInterface MAGFHAFDLNF<TInterface>(Type MCLMFJEAHEC)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF530", Offset = "0x5FCDF30", VA = "0x185FCF530")]
	private void JNJEDFOGCLJ(NAAMMKHGMGA LNDCPLAHPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF490", Offset = "0x5FCDE90", VA = "0x185FCF490")]
	private int HJBCIHNILME(NAAMMKHGMGA CHMHOLIMEDK, int IPGJOMPJEJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF1E0", Offset = "0x5FCDBE0", VA = "0x185FCF1E0")]
	private void HFDLIJODKOC(CMKCOPJLMDL LNDCPLAHPLG, EFGFBOHCNLJ DOHOPLIFGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5FCEF20", Offset = "0x5FCD920", VA = "0x185FCEF20")]
	private void ECCJPCJLAEL(CCEPELHIGPN LNDCPLAHPLG, AOACKBFDNGA DOHOPLIFGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF630", Offset = "0x5FCE030", VA = "0x185FCF630")]
	private void OMAJFMJGLJP(NHBDEHAJKNN LNDCPLAHPLG, FHEJKFHHHJG DOHOPLIFGCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct AGAKNHIEJCE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly GIHCPFBMAPF GLIDFGCEEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<NAAMMKHGMGA> OGPHEAGNPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<JBKIANPAIEO> NAPPAIKJJLF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<JBKIANPAIEO> DIOIKDADHKC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD6AC50", Offset = "0xD69650", VA = "0x180D6AC50")]
		get
		{
			return default(NativeList<JBKIANPAIEO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC850", Offset = "0x5FCB250", VA = "0x185FCC850")]
	public AGAKNHIEJCE(GIHCPFBMAPF GLIDFGCEEAN, List<NAAMMKHGMGA> OGPHEAGNPJD, NativeArray<JBKIANPAIEO> JJKIHDMAFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC180", Offset = "0x5FCAB80", VA = "0x185FCC180", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC450", Offset = "0x5FCAE50", VA = "0x185FCC450")]
	private NativeList<JBKIANPAIEO> OJLFMNJJNFI(NativeArray<JBKIANPAIEO> ABAPOKPODPC)
	{
		return default(NativeList<JBKIANPAIEO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC380", Offset = "0x5FCAD80", VA = "0x185FCC380")]
	private bool IMPIFBGAENF(NAAMMKHGMGA LNDCPLAHPLG, KHMPCJGDBKN IAECDOIKCOF, int LMHILALBFOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC1C0", Offset = "0x5FCABC0", VA = "0x185FCC1C0")]
	private void ECGONDFGHAC(NAAMMKHGMGA LNDCPLAHPLG, KHMPCJGDBKN JNKMEODPHMH, int LMHILALBFOO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct CJPGFHOICHH : IComparer<JBKIANPAIEO>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD7B0", Offset = "0x5FCC1B0", VA = "0x185FCD7B0", Slot = "4")]
	public int Compare(JBKIANPAIEO IKAMJBDPPHG, JBKIANPAIEO LKLEFAIICIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD7C0", Offset = "0x5FCC1C0", VA = "0x185FCD7C0")]
	public static void MJAFONJILHK(NativeList<JBKIANPAIEO> JJKIHDMAFJL)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : AHAHNEIKLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5FD28B0", Offset = "0x5FD12B0", VA = "0x185FD28B0", Slot = "6")]
		public sealed override void FHBOKNJGNHA(JGIPCDLBHLE ONHFNOPIIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5FD29B0", Offset = "0x5FD13B0", VA = "0x185FD29B0", Slot = "4")]
		public sealed override void GBDHAHIIBFE()
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
