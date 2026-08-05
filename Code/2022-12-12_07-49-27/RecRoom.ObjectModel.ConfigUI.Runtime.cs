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
	[Cpp2IlInjected.Address(RVA = "0x1C59500", Offset = "0x1C57B00", VA = "0x181C59500")]
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
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public LELCHBEFPED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2C1AF20", Offset = "0x2C19520", VA = "0x182C1AF20")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2C1B050", Offset = "0x2C19650", VA = "0x182C1B050")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x718150", Offset = "0x716750", VA = "0x180718150")]
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
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public HEHKDECMJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE630", Offset = "0x3AFCC30", VA = "0x183AFE630")]
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
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public BMIJLNGEMJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0B30", Offset = "0x3FAF130", VA = "0x183FB0B30")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0C80", Offset = "0x3FAF280", VA = "0x183FB0C80")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3B41230", Offset = "0x3B3F830", VA = "0x183B41230")]
	protected MFCDKDPDIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B40910", Offset = "0x3B3EF10", VA = "0x183B40910", Slot = "5")]
	public virtual void CBBDJJLJMKE(OKKOFBJCFMA DLOBABKCMJG, MIKODHFFJMF LNOIPGJELOP, AFIELLPAPGK CMFNPEENAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B40DB0", Offset = "0x3B3F3B0", VA = "0x183B40DB0", Slot = "6")]
	protected virtual ACOHGKEBGPJ COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3B411E0", Offset = "0x3B3F7E0", VA = "0x183B411E0", Slot = "7")]
	protected virtual JHMOGGFMHOB NIPIEAKABDG(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3B40EB0", Offset = "0x3B3F4B0", VA = "0x183B40EB0")]
	private static Enum DEOJADDKGMC(OKKOFBJCFMA DLOBABKCMJG, MIKODHFFJMF LNOIPGJELOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B410A0", Offset = "0x3B3F6A0", VA = "0x183B410A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public MIKODHFFJMF[] CMHKGMAHEKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1C58BE0", Offset = "0x1C571E0", VA = "0x181C58BE0", Slot = "6")]
	public void IFEPEMKMGAF(GIHCPFBMAPF GLIDFGCEEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void CBBDJJLJMKE(OKKOFBJCFMA DLOBABKCMJG, AFIELLPAPGK CMFNPEENAMD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x33B3440", Offset = "0x33B1A40", VA = "0x1833B3440")]
	protected static T BAHJCIEPMGA<T>(OKKOFBJCFMA DLOBABKCMJG, MIKODHFFJMF LNOIPGJELOP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x33B3490", Offset = "0x33B1A90", VA = "0x1833B3490")]
	protected static void OAFINNBIOFN<T>(OKKOFBJCFMA DLOBABKCMJG, MIKODHFFJMF LNOIPGJELOP, T MAKFNMHIJIF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public MFIJIOLMJOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3B41610", Offset = "0x3B3FC10", VA = "0x183B41610")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3B41840", Offset = "0x3B3FE40", VA = "0x183B41840")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x718150", Offset = "0x716750", VA = "0x180718150")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x36C7DB0", Offset = "0x36C63B0", VA = "0x1836C7DB0")]
	protected EKBFHGEBEAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x36C6920", Offset = "0x36C4F20", VA = "0x1836C6920", Slot = "4")]
	public void CBBDJJLJMKE(OKKOFBJCFMA DLOBABKCMJG, MIKODHFFJMF LNOIPGJELOP, AFIELLPAPGK CMFNPEENAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x36C6630", Offset = "0x36C4C30", VA = "0x1836C6630")]
	private static T BAHJCIEPMGA(OKKOFBJCFMA DLOBABKCMJG, MIKODHFFJMF LNOIPGJELOP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x36C7B80", Offset = "0x36C6180", VA = "0x1836C7B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C5A240", Offset = "0x1C58840", VA = "0x181C5A240", Slot = "5")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1C59820", Offset = "0x1C57E20", VA = "0x181C59820", Slot = "6")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1C59B20", Offset = "0x1C58120", VA = "0x181C59B20", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1C59C40", Offset = "0x1C58240", VA = "0x181C59C40", Slot = "4")]
		public void MCOMKLEPAHE(OKKOFBJCFMA AALKPMMEGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1C5A1B0", Offset = "0x1C587B0", VA = "0x181C5A1B0")]
		private void MOFPGHNIHIN(OKKOFBJCFMA AALKPMMEGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1C59C10", Offset = "0x1C58210", VA = "0x181C59C10")]
		private void EIPOBJPILMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1C595A0", Offset = "0x1C57BA0", VA = "0x181C595A0")]
		private void CBBDJJLJMKE(JBKIANPAIEO OCMDKMBJDKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1C59360", Offset = "0x1C57960", VA = "0x181C59360", Slot = "9")]
	public override bool BIEOJPJAHCL(Type MCLMFJEAHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1C59410", Offset = "0x1C57A10", VA = "0x181C59410", Slot = "6")]
	protected override ACOHGKEBGPJ COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1C59500", Offset = "0x1C57B00", VA = "0x181C59500")]
	public CIIHKBGANFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[AOACKBFDNGA(0)]
internal class ELAJCNIIKCD : OANAEPLOBFH
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1C5B700", Offset = "0x1C59D00", VA = "0x181C5B700", Slot = "9")]
	public override bool BIEOJPJAHCL(Type MCLMFJEAHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1C5B7B0", Offset = "0x1C59DB0", VA = "0x181C5B7B0", Slot = "6")]
	protected override ACOHGKEBGPJ COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1C59500", Offset = "0x1C57B00", VA = "0x181C59500")]
	public ELAJCNIIKCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[EFGFBOHCNLJ(typeof(JNEJGOPIMPI), 1)]
internal class OJKGHLBONBA : global::MFCDKDPDIEE<JNEJGOPIMPI>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1C5DB70", Offset = "0x1C5C170", VA = "0x181C5DB70", Slot = "7")]
	protected override JHMOGGFMHOB NIPIEAKABDG(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1C5DC60", Offset = "0x1C5C260", VA = "0x181C5DC60")]
	public OJKGHLBONBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PDGAMPLGJBG
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1C5DE90", Offset = "0x1C5C490", VA = "0x181C5DE90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public HMLMNKCCGEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1C5CAF0", Offset = "0x1C5B0F0", VA = "0x181C5CAF0")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1C5CC20", Offset = "0x1C5B220", VA = "0x181C5CC20")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x718150", Offset = "0x716750", VA = "0x180718150")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override DMNHKHOLGBO[] LGLAOJAFLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1C58B00", Offset = "0x1C57100", VA = "0x181C58B00", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override DMNHKHOLGBO[] FGDEPABAPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1C58A20", Offset = "0x1C57020", VA = "0x181C58A20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1C58660", Offset = "0x1C56C60", VA = "0x181C58660", Slot = "10")]
	public override void CBBDJJLJMKE(OKKOFBJCFMA DLOBABKCMJG, AFIELLPAPGK CMFNPEENAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public APHJDNPFNLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[EFGFBOHCNLJ(typeof(bool))]
internal class JBEPAIIJECE : global::EKBFHGEBEAC<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D4D0", Offset = "0x1C5BAD0", VA = "0x181C5D4D0", Slot = "5")]
	protected override ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D5C0", Offset = "0x1C5BBC0", VA = "0x181C5D5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public BMMGCGGICEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1C58FF0", Offset = "0x1C575F0", VA = "0x181C58FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public PAHAOGGKNGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1C5DCA0", Offset = "0x1C5C2A0", VA = "0x181C5DCA0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1C5DD10", Offset = "0x1C5C310", VA = "0x181C5DD10")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1C5DD90", Offset = "0x1C5C390", VA = "0x181C5DD90", Slot = "5")]
	protected override ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1C5DE50", Offset = "0x1C5C450", VA = "0x181C5DE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public PKMFCAFJEAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1C5DFD0", Offset = "0x1C5C5D0", VA = "0x181C5DFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public MGPHKNOJEIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1C5DA40", Offset = "0x1C5C040", VA = "0x181C5DA40")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1C5DAD0", Offset = "0x1C5C0D0", VA = "0x181C5DAD0")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D600", Offset = "0x1C5BC00", VA = "0x181C5D600", Slot = "5")]
	protected override ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D6C0", Offset = "0x1C5BCC0", VA = "0x181C5D6C0")]
	public KDOJCDIEAKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[EFGFBOHCNLJ(typeof(float))]
internal class IANMCGFDCHA : global::EKBFHGEBEAC<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1C5CE90", Offset = "0x1C5B490", VA = "0x181C5CE90", Slot = "5")]
	protected override ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1C5CF80", Offset = "0x1C5B580", VA = "0x181C5CF80")]
	public IANMCGFDCHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[EFGFBOHCNLJ(typeof(int))]
internal class HMNPDCGHDDM : global::EKBFHGEBEAC<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1C5CCB0", Offset = "0x1C5B2B0", VA = "0x181C5CCB0", Slot = "5")]
	protected override ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1C5CDA0", Offset = "0x1C5B3A0", VA = "0x181C5CDA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public AAGBHJDPJGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1C57D30", Offset = "0x1C56330", VA = "0x181C57D30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public HOKBPOEPHJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1C5CDE0", Offset = "0x1C5B3E0", VA = "0x181C5CDE0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1C5CE30", Offset = "0x1C5B430", VA = "0x181C5CE30")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D3D0", Offset = "0x1C5B9D0", VA = "0x181C5D3D0", Slot = "5")]
	protected override ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D490", Offset = "0x1C5BA90", VA = "0x181C5D490")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ENNNCMLJFEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1C5B8A0", Offset = "0x1C59EA0", VA = "0x181C5B8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public DJCFAMEKMDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1C5A320", Offset = "0x1C58920", VA = "0x181C5A320")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1C5A380", Offset = "0x1C58980", VA = "0x181C5A380")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1C5A390", Offset = "0x1C58990", VA = "0x181C5A390")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1C5A3F0", Offset = "0x1C589F0", VA = "0x181C5A3F0")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1C5A400", Offset = "0x1C58A00", VA = "0x181C5A400")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1C5A460", Offset = "0x1C58A60", VA = "0x181C5A460")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1C59180", Offset = "0x1C57780", VA = "0x181C59180", Slot = "5")]
	protected override ECOKIFIEGJI COCHPPPDJKB(AFIELLPAPGK CMFNPEENAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1C59240", Offset = "0x1C57840", VA = "0x181C59240")]
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
	[Cpp2IlInjected.Address(RVA = "0x1C59280", Offset = "0x1C57880", VA = "0x181C59280")]
	public static void OEJJLOEHGOI(Type OLOFGPGIMAL, Type KAGJIFJNHPM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct FJLKJONPFDB
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C730", Offset = "0x1C5AD30", VA = "0x181C5C730")]
	public static NativeList<int> DDABHDNFIKM(OKKOFBJCFMA DLOBABKCMJG, MAKFOFFGOPC NFJBJDBBCED)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C910", Offset = "0x1C5AF10", VA = "0x181C5C910")]
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
	[Cpp2IlInjected.Address(RVA = "0x1C5C610", Offset = "0x1C5AC10", VA = "0x181C5C610")]
	public FBNOCMMJBKI(MAKFOFFGOPC NFJBJDBBCED, GIHCPFBMAPF GLIDFGCEEAN, AFIELLPAPGK CMFNPEENAMD, Action<JBKIANPAIEO> CDJGHEJLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1C5BBF0", Offset = "0x1C5A1F0", VA = "0x181C5BBF0")]
	public void AMGCJPAGHDK(NativeList<JBKIANPAIEO> JJKIHDMAFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C4F0", Offset = "0x1C5AAF0", VA = "0x181C5C4F0")]
	private void PAMKMJPDMCO(NPKIDEECJBB NABGGPANDBL, JBKIANPAIEO OCMDKMBJDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C3F0", Offset = "0x1C5A9F0", VA = "0x181C5C3F0")]
	public void LOIJIOLEKGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1C5BF70", Offset = "0x1C5A570", VA = "0x181C5BF70")]
	private void KHPAMOGKKGC(NPKIDEECJBB NABGGPANDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C450", Offset = "0x1C5AA50", VA = "0x181C5C450")]
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
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
			[DebuggerHidden]
			public IEHPHCPFFKM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x1C5D300", Offset = "0x1C5B900", VA = "0x181C5D300", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x1C5CFC0", Offset = "0x1C5B5C0", VA = "0x181C5CFC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1C5D380", Offset = "0x1C5B980", VA = "0x181C5D380")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1C5D2C0", Offset = "0x1C5B8C0", VA = "0x181C5D2C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1C5D210", Offset = "0x1C5B810", VA = "0x181C5D210", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MIKODHFFJMF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1C5D210", Offset = "0x1C5B810", VA = "0x181C5D210", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C5E340", Offset = "0x1C5C940", VA = "0x181C5E340")]
		public PropertiesByType(GIHCPFBMAPF GLIDFGCEEAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1C5E160", Offset = "0x1C5C760", VA = "0x181C5E160")]
		[IteratorStateMachine(typeof(IEHPHCPFFKM))]
		public IEnumerable<MIKODHFFJMF> DMPGADBOHPL(Type MCLMFJEAHEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1C5E1F0", Offset = "0x1C5C7F0", VA = "0x181C5E1F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1C5E230", Offset = "0x1C5C830", VA = "0x181C5E230")]
		private long KBGKIEMJNDD(MIKODHFFJMF LNOIPGJELOP)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1C5E2B0", Offset = "0x1C5C8B0", VA = "0x181C5E2B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1C5DA00", Offset = "0x1C5C000", VA = "0x181C5DA00")]
	public KHMPCJGDBKN(int FPLNDBJJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D890", Offset = "0x1C5BE90", VA = "0x181C5D890")]
	public static KHMPCJGDBKN IMNLJMMJPEO(int FHGNFGIEADL, NativeArray<int> KECMGAIBBMH)
	{
		return default(KHMPCJGDBKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D9F0", Offset = "0x1C5BFF0", VA = "0x181C5D9F0")]
	public bool PLBNCIKFCHN(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D9E0", Offset = "0x1C5BFE0", VA = "0x181C5D9E0")]
	public void KMNEKDAGPNL(int EBBLFLFCHFB, bool MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D700", Offset = "0x1C5BD00", VA = "0x181C5D700")]
	public bool BJGBMDJKFHG(MIKODHFFJMF[] KECMGAIBBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D7C0", Offset = "0x1C5BDC0", VA = "0x181C5D7C0")]
	public bool CMIIBJDADHJ(MIKODHFFJMF[] KECMGAIBBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D880", Offset = "0x1C5BE80", VA = "0x181C5D880", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1C5B5B0", Offset = "0x1C59BB0", VA = "0x181C5B5B0")]
	public EBCBCIIHONG(MAKFOFFGOPC NFJBJDBBCED, GIHCPFBMAPF GLIDFGCEEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1C5A780", Offset = "0x1C58D80", VA = "0x181C5A780")]
	public void BOHBKACNFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1C5A540", Offset = "0x1C58B40", VA = "0x181C5A540")]
	public void AAMEFPKANOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1C5A850", Offset = "0x1C58E50", VA = "0x181C5A850")]
	public NativeList<JBKIANPAIEO> BPFDALFNPKJ(NativeArray<int> KECMGAIBBMH)
	{
		return default(NativeList<JBKIANPAIEO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1C5A6B0", Offset = "0x1C58CB0", VA = "0x181C5A6B0")]
	private bool BJODMPHMDCI(NAAMMKHGMGA LNDCPLAHPLG, KHMPCJGDBKN AGOFPIMFDFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A4D0D0", Offset = "0x2A4B6D0", VA = "0x182A4D0D0")]
	private void FMALOJHJCCF<TInterface, TAttribute>(Action<TInterface, TAttribute> MALFJDJBPEF) where TInterface : NAAMMKHGMGA where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1C5B390", Offset = "0x1C59990", VA = "0x181C5B390")]
	private void MEKKMLDOFFP(Type MCLMFJEAHEC, Type ABHJFHMNBEO, Type FMAKDFECFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2A4D370", Offset = "0x2A4B970", VA = "0x182A4D370")]
	private TInterface MAGFHAFDLNF<TInterface>(Type MCLMFJEAHEC)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1C5B2C0", Offset = "0x1C598C0", VA = "0x181C5B2C0")]
	private void JNJEDFOGCLJ(NAAMMKHGMGA LNDCPLAHPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1C5B220", Offset = "0x1C59820", VA = "0x181C5B220")]
	private int HJBCIHNILME(NAAMMKHGMGA CHMHOLIMEDK, int IPGJOMPJEJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1C5AF70", Offset = "0x1C59570", VA = "0x181C5AF70")]
	private void HFDLIJODKOC(CMKCOPJLMDL LNDCPLAHPLG, EFGFBOHCNLJ DOHOPLIFGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1C5ACB0", Offset = "0x1C592B0", VA = "0x181C5ACB0")]
	private void ECCJPCJLAEL(CCEPELHIGPN LNDCPLAHPLG, AOACKBFDNGA DOHOPLIFGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1C5B3C0", Offset = "0x1C599C0", VA = "0x181C5B3C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x792CB0", Offset = "0x7912B0", VA = "0x180792CB0")]
		get
		{
			return default(NativeList<JBKIANPAIEO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1C585E0", Offset = "0x1C56BE0", VA = "0x181C585E0")]
	public AGAKNHIEJCE(GIHCPFBMAPF GLIDFGCEEAN, List<NAAMMKHGMGA> OGPHEAGNPJD, NativeArray<JBKIANPAIEO> JJKIHDMAFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1C57F10", Offset = "0x1C56510", VA = "0x181C57F10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1C581E0", Offset = "0x1C567E0", VA = "0x181C581E0")]
	private NativeList<JBKIANPAIEO> OJLFMNJJNFI(NativeArray<JBKIANPAIEO> ABAPOKPODPC)
	{
		return default(NativeList<JBKIANPAIEO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1C58110", Offset = "0x1C56710", VA = "0x181C58110")]
	private bool IMPIFBGAENF(NAAMMKHGMGA LNDCPLAHPLG, KHMPCJGDBKN IAECDOIKCOF, int LMHILALBFOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1C57F50", Offset = "0x1C56550", VA = "0x181C57F50")]
	private void ECGONDFGHAC(NAAMMKHGMGA LNDCPLAHPLG, KHMPCJGDBKN JNKMEODPHMH, int LMHILALBFOO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct CJPGFHOICHH : IComparer<JBKIANPAIEO>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1C59540", Offset = "0x1C57B40", VA = "0x181C59540", Slot = "4")]
	public int Compare(JBKIANPAIEO IKAMJBDPPHG, JBKIANPAIEO LKLEFAIICIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1C59550", Offset = "0x1C57B50", VA = "0x181C59550")]
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
		[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1C5E640", Offset = "0x1C5CC40", VA = "0x181C5E640", Slot = "6")]
		public sealed override void FHBOKNJGNHA(JGIPCDLBHLE ONHFNOPIIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1C5E740", Offset = "0x1C5CD40", VA = "0x181C5E740", Slot = "4")]
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
