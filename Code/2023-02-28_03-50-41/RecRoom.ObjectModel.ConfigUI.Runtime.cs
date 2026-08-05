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
internal abstract class OCHJDBJEJLB : global::BGKPIMFGEJG<Enum>, LIDECILMPBF, CFIMMOOLBHA, IBKEEDIAHJL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool OPJAEPIPPLK(Type MAHAMGBPDNB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x63E1F80", Offset = "0x63E0980", VA = "0x1863E1F80")]
	protected OCHJDBJEJLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class BGKPIMFGEJG<T> : CFIMMOOLBHA, IBKEEDIAHJL where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void ABKHBAIMINB(Func<T> OAECIMHKFFD, Action<T> JEFPNAKLJNI, string ANJJEPIBAGI, KNCBBMLNKLK OPPPBNFKNOC, Func<bool> HKLCMBAJDMM);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void OKFKKDGFILP(Func<int> OAECIMHKFFD, Action<int> JEFPNAKLJNI, string ANJJEPIBAGI, KNCBBMLNKLK OPPPBNFKNOC, Func<bool> HKLCMBAJDMM);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class ODIPOLMOBIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public EIIMNNHCANF targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public KNCBBMLNKLK property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public ODIPOLMOBIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2EA9960", Offset = "0x2EA8360", VA = "0x182EA9960")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2EA9A40", Offset = "0x2EA8440", VA = "0x182EA9A40")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C1030", Offset = "0x6BFA30", VA = "0x1806C1030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GBCEKGCBOLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::BGKPIMFGEJG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public HODBFJKCAEL ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public GBCEKGCBOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2A81110", Offset = "0x2A7FB10", VA = "0x182A81110")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, KNCBBMLNKLK property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MFFBBADMDOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public MFFBBADMDOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B13100", Offset = "0x2B11B00", VA = "0x182B13100")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B131C0", Offset = "0x2B11BC0", VA = "0x182B131C0")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x26D8A00", Offset = "0x26D7400", VA = "0x1826D8A00")]
	protected BGKPIMFGEJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x26D8210", Offset = "0x26D6C10", VA = "0x1826D8210", Slot = "5")]
	public virtual void CCOIJOPLENL(EIIMNNHCANF NFMPJBDAMKJ, KNCBBMLNKLK OPPPBNFKNOC, HODBFJKCAEL AIMOGEDNDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x26D86B0", Offset = "0x26D70B0", VA = "0x1826D86B0", Slot = "6")]
	protected virtual ABKHBAIMINB HNOAKBLGBLK(HODBFJKCAEL AIMOGEDNDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x26D87B0", Offset = "0x26D71B0", VA = "0x1826D87B0", Slot = "7")]
	protected virtual OKFKKDGFILP JNJLIHIILNG(HODBFJKCAEL AIMOGEDNDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x26D88D0", Offset = "0x26D72D0", VA = "0x1826D88D0")]
	private static Enum NOPMEFMNJNH(EIIMNNHCANF NFMPJBDAMKJ, KNCBBMLNKLK OPPPBNFKNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x26D8030", Offset = "0x26D6A30", VA = "0x1826D8030")]
	private static void BOEFAFMILGA(EIIMNNHCANF NFMPJBDAMKJ, KNCBBMLNKLK OPPPBNFKNOC, Enum MNIAGKNOHEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class IEJNAELKNAD : AANHIKIDBNL, IBKEEDIAHJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private KNCBBMLNKLK[] MPJMJEKDDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KNCBBMLNKLK[] PPKAPFIHMFB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public KNCBBMLNKLK[] KPDAAGLJNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public KNCBBMLNKLK[] EGLDLAIAMBI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract GFANKPDBBJN[] DKEGPDNCEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract GFANKPDBBJN[] GCBKGJPCPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x63E2460", Offset = "0x63E0E60", VA = "0x1863E2460", Slot = "6")]
	public void HAKOKLHEDIO(BJKMJANDEAI KPGKMEENODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void CCOIJOPLENL(EIIMNNHCANF NFMPJBDAMKJ, HODBFJKCAEL AIMOGEDNDGN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2236840", Offset = "0x2235240", VA = "0x182236840")]
	protected static T JFCJEDHBPFA<T>(EIIMNNHCANF NFMPJBDAMKJ, KNCBBMLNKLK OPPPBNFKNOC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2236770", Offset = "0x2235170", VA = "0x182236770")]
	protected static void CPCCGAJNKDE<T>(EIIMNNHCANF NFMPJBDAMKJ, KNCBBMLNKLK OPPPBNFKNOC, T MNIAGKNOHEJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	protected IEJNAELKNAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class JHGLAIPOMFJ<T> : CFIMMOOLBHA, IBKEEDIAHJL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void FAPMLGMHOPJ(Func<T> OAECIMHKFFD, Action<T> JEFPNAKLJNI, string ANJJEPIBAGI, KNCBBMLNKLK OPPPBNFKNOC, Func<bool> HKLCMBAJDMM);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class OCFHAPLPHDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public EIIMNNHCANF targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public KNCBBMLNKLK property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public OCFHAPLPHDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2EA8ED0", Offset = "0x2EA78D0", VA = "0x182EA8ED0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2EA90B0", Offset = "0x2EA7AB0", VA = "0x182EA90B0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C1030", Offset = "0x6BFA30", VA = "0x1806C1030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x31636B0", Offset = "0x31620B0", VA = "0x1831636B0")]
	protected JHGLAIPOMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3161EC0", Offset = "0x31608C0", VA = "0x183161EC0", Slot = "4")]
	public void CCOIJOPLENL(EIIMNNHCANF NFMPJBDAMKJ, KNCBBMLNKLK OPPPBNFKNOC, HODBFJKCAEL AIMOGEDNDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract FAPMLGMHOPJ HNOAKBLGBLK(HODBFJKCAEL AIMOGEDNDGN);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3163290", Offset = "0x3161C90", VA = "0x183163290")]
	private static T JFCJEDHBPFA(EIIMNNHCANF NFMPJBDAMKJ, KNCBBMLNKLK OPPPBNFKNOC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3162DC0", Offset = "0x31617C0", VA = "0x183162DC0")]
	private static void CPCCGAJNKDE(EIIMNNHCANF NFMPJBDAMKJ, KNCBBMLNKLK OPPPBNFKNOC, T MNIAGKNOHEJ)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[LOEOGANCBGC(EDPDLGMLNHJ.ConfigUI)]
	[DNOPHNKOHLA(typeof(BLHGADGPEJI), new string[] { })]
	internal class ConfigUIService : BLHGADGPEJI, MMKNGEFLOAO, PKBAIAJJFPF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[JIFPDEDMPGC]
		private BJKMJANDEAI KPGKMEENODO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[JIFPDEDMPGC]
		private KEPHDBCLKDO NKHOMDDAAPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[JIFPDEDMPGC]
		private HODBFJKCAEL FKJJJJAENKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private KEAOOALIPPG AKBKCLHJHEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private EIIMNNHCANF NFMPJBDAMKJ;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x63E0BC0", Offset = "0x63DF5C0", VA = "0x1863E0BC0", Slot = "5")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x63E08C0", Offset = "0x63DF2C0", VA = "0x1863E08C0", Slot = "6")]
		public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x63E07A0", Offset = "0x63DF1A0", VA = "0x1863E07A0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63E0C50", Offset = "0x63DF650", VA = "0x1863E0C50", Slot = "4")]
		public void GPLBAACMEFI(EIIMNNHCANF PJOEPHDGNDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x63E11C0", Offset = "0x63DFBC0", VA = "0x1863E11C0")]
		private void PPDFIGKCAMO(EIIMNNHCANF PJOEPHDGNDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x63E0890", Offset = "0x63DF290", VA = "0x1863E0890")]
		private void ECMDINGCPOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63E0520", Offset = "0x63DEF20", VA = "0x1863E0520")]
		private void CCOIJOPLENL(ONMDIIMHEPI CJPBIFOKCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[PJDCBBBJMPI(0)]
internal class KDHNDLLNNJP : OCHJDBJEJLB
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x63E3240", Offset = "0x63E1C40", VA = "0x1863E3240", Slot = "9")]
	public override bool OPJAEPIPPLK(Type MAHAMGBPDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x63E3150", Offset = "0x63E1B50", VA = "0x1863E3150", Slot = "6")]
	protected override ABKHBAIMINB HNOAKBLGBLK(HODBFJKCAEL AIMOGEDNDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x63E1F80", Offset = "0x63E0980", VA = "0x1863E1F80")]
	public KDHNDLLNNJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[PJDCBBBJMPI(0)]
internal class GFGCJPCBHBK : OCHJDBJEJLB
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x63E1ED0", Offset = "0x63E08D0", VA = "0x1863E1ED0", Slot = "9")]
	public override bool OPJAEPIPPLK(Type MAHAMGBPDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x63E1DE0", Offset = "0x63E07E0", VA = "0x1863E1DE0", Slot = "6")]
	protected override ABKHBAIMINB HNOAKBLGBLK(HODBFJKCAEL AIMOGEDNDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x63E1F80", Offset = "0x63E0980", VA = "0x1863E1F80")]
	public GFGCJPCBHBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[IALIOADMEHK(typeof(MEDMHGMHFAO), 1)]
internal class CJOFJCBILEN : global::BGKPIMFGEJG<MEDMHGMHFAO>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x63E03F0", Offset = "0x63DEDF0", VA = "0x1863E03F0", Slot = "7")]
	protected override OKFKKDGFILP JNJLIHIILNG(HODBFJKCAEL AIMOGEDNDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63E04E0", Offset = "0x63DEEE0", VA = "0x1863E04E0")]
	public CJOFJCBILEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JHNNAEPAGPN
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x63E2D90", Offset = "0x63E1790", VA = "0x1863E2D90")]
	public static bool GKJPNDPLLDM(this KNCBBMLNKLK OPPPBNFKNOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BHJJFHNIJNI(2)]
internal class AGCCDJBAFNG : IEJNAELKNAD
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class GBIGKINFMFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EIIMNNHCANF targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AGCCDJBAFNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public GBIGKINFMFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x63E1C20", Offset = "0x63E0620", VA = "0x1863E1C20")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x63E1D50", Offset = "0x63E0750", VA = "0x1863E1D50")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C1030", Offset = "0x6BFA30", VA = "0x1806C1030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override GFANKPDBBJN[] GCBKGJPCPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x63E0310", Offset = "0x63DED10", VA = "0x1863E0310", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override GFANKPDBBJN[] DKEGPDNCEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x63E0230", Offset = "0x63DEC30", VA = "0x1863E0230", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x63DFE70", Offset = "0x63DE870", VA = "0x1863DFE70", Slot = "10")]
	public override void CCOIJOPLENL(EIIMNNHCANF NFMPJBDAMKJ, HODBFJKCAEL AIMOGEDNDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public AGCCDJBAFNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[IALIOADMEHK(typeof(bool))]
internal class PEGKCIDOLKD : global::JHGLAIPOMFJ<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x63E5050", Offset = "0x63E3A50", VA = "0x1863E5050", Slot = "5")]
	protected override FAPMLGMHOPJ HNOAKBLGBLK(HODBFJKCAEL AIMOGEDNDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x63E5140", Offset = "0x63E3B40", VA = "0x1863E5140")]
	public PEGKCIDOLKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[IALIOADMEHK(typeof(FixedString32))]
internal class PJIIEKLJPBL : global::JHGLAIPOMFJ<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class NHIJBEGOHHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public HODBFJKCAEL ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public NHIJBEGOHHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x63E4AF0", Offset = "0x63E34F0", VA = "0x1863E4AF0")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, KNCBBMLNKLK property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PBGBPDCBMME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public PBGBPDCBMME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x63E4F60", Offset = "0x63E3960", VA = "0x1863E4F60")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x63E4FD0", Offset = "0x63E39D0", VA = "0x1863E4FD0")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x63E6010", Offset = "0x63E4A10", VA = "0x1863E6010", Slot = "5")]
	protected override FAPMLGMHOPJ HNOAKBLGBLK(HODBFJKCAEL AIMOGEDNDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x63E60D0", Offset = "0x63E4AD0", VA = "0x1863E60D0")]
	public PJIIEKLJPBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[IALIOADMEHK(typeof(FixedString64))]
internal class OHEPNIDNBIN : global::JHGLAIPOMFJ<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class POFFODDDLEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HODBFJKCAEL ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public POFFODDDLEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x63E6110", Offset = "0x63E4B10", VA = "0x1863E6110")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, KNCBBMLNKLK property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class OKFDGHACEAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public OKFDGHACEAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x63E4E30", Offset = "0x63E3830", VA = "0x1863E4E30")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x63E4EC0", Offset = "0x63E38C0", VA = "0x1863E4EC0")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x63E4D30", Offset = "0x63E3730", VA = "0x1863E4D30", Slot = "5")]
	protected override FAPMLGMHOPJ HNOAKBLGBLK(HODBFJKCAEL AIMOGEDNDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x63E4DF0", Offset = "0x63E37F0", VA = "0x1863E4DF0")]
	public OHEPNIDNBIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[IALIOADMEHK(typeof(float))]
internal class LLJJHLEDMBF : global::JHGLAIPOMFJ<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x63E48C0", Offset = "0x63E32C0", VA = "0x1863E48C0", Slot = "5")]
	protected override FAPMLGMHOPJ HNOAKBLGBLK(HODBFJKCAEL AIMOGEDNDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x63E49B0", Offset = "0x63E33B0", VA = "0x1863E49B0")]
	public LLJJHLEDMBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[IALIOADMEHK(typeof(int))]
internal class EPAGKDBGMAN : global::JHGLAIPOMFJ<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x63E19F0", Offset = "0x63E03F0", VA = "0x1863E19F0", Slot = "5")]
	protected override FAPMLGMHOPJ HNOAKBLGBLK(HODBFJKCAEL AIMOGEDNDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x63E1AE0", Offset = "0x63E04E0", VA = "0x1863E1AE0")]
	public EPAGKDBGMAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[IALIOADMEHK(typeof(uint))]
internal class FBDAPMHPMPO : global::JHGLAIPOMFJ<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IIKHMKGFBHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public HODBFJKCAEL ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public IIKHMKGFBHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x63E2BB0", Offset = "0x63E15B0", VA = "0x1863E2BB0")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, KNCBBMLNKLK property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class NMNPINLPDLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public NMNPINLPDLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x63E4C80", Offset = "0x63E3680", VA = "0x1863E4C80")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x63E4CD0", Offset = "0x63E36D0", VA = "0x1863E4CD0")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x63E1B20", Offset = "0x63E0520", VA = "0x1863E1B20", Slot = "5")]
	protected override FAPMLGMHOPJ HNOAKBLGBLK(HODBFJKCAEL AIMOGEDNDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x63E1BE0", Offset = "0x63E05E0", VA = "0x1863E1BE0")]
	public FBDAPMHPMPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[IALIOADMEHK(typeof(Vector3))]
internal class MIPHJKBAHFM : global::JHGLAIPOMFJ<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PELBJGPGJNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public HODBFJKCAEL ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public PELBJGPGJNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x63E5180", Offset = "0x63E3B80", VA = "0x1863E5180")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, KNCBBMLNKLK property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JMCAJFKBPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public JMCAJFKBPCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x63E2F30", Offset = "0x63E1930", VA = "0x1863E2F30")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x63E2F90", Offset = "0x63E1990", VA = "0x1863E2F90")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63E2FA0", Offset = "0x63E19A0", VA = "0x1863E2FA0")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63E3000", Offset = "0x63E1A00", VA = "0x1863E3000")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x63E3010", Offset = "0x63E1A10", VA = "0x1863E3010")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63E3070", Offset = "0x63E1A70", VA = "0x1863E3070")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x63E49F0", Offset = "0x63E33F0", VA = "0x1863E49F0", Slot = "5")]
	protected override FAPMLGMHOPJ HNOAKBLGBLK(HODBFJKCAEL AIMOGEDNDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x63E4AB0", Offset = "0x63E34B0", VA = "0x1863E4AB0")]
	public MIPHJKBAHFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct ONMDIIMHEPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int CJIAIDAHHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int KHHEGEKEEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int OIHCLELFNKN;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class HGGPNHFEMOG
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x63E1FC0", Offset = "0x63E09C0", VA = "0x1863E1FC0")]
	public static void ODDLAFFJMJD(Type EHBHEHKKLED, Type NFJMDJKNHFB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct HIPNBOCJINN
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x63E2280", Offset = "0x63E0C80", VA = "0x1863E2280")]
	public static NativeList<int> LIPFHJOPMAM(EIIMNNHCANF NFMPJBDAMKJ, KEPHDBCLKDO NKHOMDDAAPA)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x63E20A0", Offset = "0x63E0AA0", VA = "0x1863E20A0")]
	private static bool FMPHFILMCLK(KNCBBMLNKLK OPPPBNFKNOC, EIIMNNHCANF NFMPJBDAMKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class PGGOAILCHNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly KEPHDBCLKDO NKHOMDDAAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly BJKMJANDEAI KPGKMEENODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly HODBFJKCAEL AIMOGEDNDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<ONMDIIMHEPI> MGDAIOGEBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<DHNPEMGDPLJ> HOHDFAJMLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<DHNPEMGDPLJ, List<ONMDIIMHEPI>> BDALECJGHIF;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x63E5EF0", Offset = "0x63E48F0", VA = "0x1863E5EF0")]
	public PGGOAILCHNG(KEPHDBCLKDO NKHOMDDAAPA, BJKMJANDEAI KPGKMEENODO, HODBFJKCAEL AIMOGEDNDGN, Action<ONMDIIMHEPI> MGDAIOGEBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x63E56F0", Offset = "0x63E40F0", VA = "0x1863E56F0")]
	public void NAFLBGBGEIK(NativeList<ONMDIIMHEPI> FDKBJDOBHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x63E55D0", Offset = "0x63E3FD0", VA = "0x1863E55D0")]
	private void MFEODIEJNMF(DHNPEMGDPLJ EAGMPINEKBM, ONMDIIMHEPI CJPBIFOKCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x63E54D0", Offset = "0x63E3ED0", VA = "0x1863E54D0")]
	public void BLFPJALJHOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x63E5A70", Offset = "0x63E4470", VA = "0x1863E5A70")]
	private void NJENMDICMIM(DHNPEMGDPLJ EAGMPINEKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x63E5530", Offset = "0x63E3F30", VA = "0x1863E5530")]
	private void HJJGOJOIGEC(DHNPEMGDPLJ EAGMPINEKBM)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[LOEOGANCBGC(EDPDLGMLNHJ.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class KKANMDIMNIM : IEnumerable<KNCBBMLNKLK>, IEnumerable, IEnumerator<KNCBBMLNKLK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private KNCBBMLNKLK <>2__current;

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
			private KNCBBMLNKLK System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
			[DebuggerHidden]
			public KKANMDIMNIM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x63E47F0", Offset = "0x63E31F0", VA = "0x1863E47F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x63E44B0", Offset = "0x63E2EB0", VA = "0x1863E44B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x63E4870", Offset = "0x63E3270", VA = "0x1863E4870")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x63E47B0", Offset = "0x63E31B0", VA = "0x1863E47B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x63E4700", Offset = "0x63E3100", VA = "0x1863E4700", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KNCBBMLNKLK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x63E4700", Offset = "0x63E3100", VA = "0x1863E4700", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly BJKMJANDEAI KPGKMEENODO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> PDFKMJPMLFJ;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x63E6480", Offset = "0x63E4E80", VA = "0x1863E6480")]
		public PropertiesByType(BJKMJANDEAI KPGKMEENODO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x63E62E0", Offset = "0x63E4CE0", VA = "0x1863E62E0")]
		[IteratorStateMachine(typeof(KKANMDIMNIM))]
		public IEnumerable<KNCBBMLNKLK> FEDGANMEAAE(Type MAHAMGBPDNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x63E62A0", Offset = "0x63E4CA0", VA = "0x1863E62A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x63E6370", Offset = "0x63E4D70", VA = "0x1863E6370")]
		private long GCILKJDKKMD(KNCBBMLNKLK OPPPBNFKNOC)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x63E63F0", Offset = "0x63E4DF0", VA = "0x1863E63F0")]
		private long GCILKJDKKMD(Type MAHAMGBPDNB)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct IHKMLADMILO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray EKIMKHHEMFJ;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x63E2B70", Offset = "0x63E1570", VA = "0x1863E2B70")]
	public IHKMLADMILO(int JOBJIONNEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x63E2A20", Offset = "0x63E1420", VA = "0x1863E2A20")]
	public static IHKMLADMILO PMGIKDKBPAM(int ADCMDGEMNDH, NativeArray<int> PDPOLFACNJC)
	{
		return default(IHKMLADMILO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x63E2940", Offset = "0x63E1340", VA = "0x1863E2940")]
	public bool ELPHOIAOCEH(int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x63E2950", Offset = "0x63E1350", VA = "0x1863E2950")]
	public void NLANNFAIKGA(int GFDMFLGCBKB, bool MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x63E2960", Offset = "0x63E1360", VA = "0x1863E2960")]
	public bool OOMEBKMCHKN(KNCBBMLNKLK[] PDPOLFACNJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x63E2870", Offset = "0x63E1270", VA = "0x1863E2870")]
	public bool BAHJOPLIMGI(KNCBBMLNKLK[] PDPOLFACNJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x63E2930", Offset = "0x63E1330", VA = "0x1863E2930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class KEAOOALIPPG
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly KGOHPJFJCLE LHMILDDMKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly KEPHDBCLKDO NKHOMDDAAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly BJKMJANDEAI KPGKMEENODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<IBKEEDIAHJL> EEEOHOLMEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType PDFKMJPMLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> LDAFCKDMJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> MGJFLIIOBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<IBKEEDIAHJL> LNMBMKJECFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x63E4360", Offset = "0x63E2D60", VA = "0x1863E4360")]
	public KEAOOALIPPG(KEPHDBCLKDO NKHOMDDAAPA, BJKMJANDEAI KPGKMEENODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x63E3F30", Offset = "0x63E2930", VA = "0x1863E3F30")]
	public void JGBMECMGNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x63E4000", Offset = "0x63E2A00", VA = "0x1863E4000")]
	public void LMMFNABKIIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x63E33C0", Offset = "0x63E1DC0", VA = "0x1863E33C0")]
	public NativeList<ONMDIIMHEPI> AMLCODKCBCA(NativeArray<int> PDPOLFACNJC)
	{
		return default(NativeList<ONMDIIMHEPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x63E32F0", Offset = "0x63E1CF0", VA = "0x1863E32F0")]
	private bool ABDEFCHIMIM(IBKEEDIAHJL JBOPPAOFBKD, IHKMLADMILO AAONFPGPBJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x25D14F0", Offset = "0x25CFEF0", VA = "0x1825D14F0")]
	private void JGDBBHJNMPL<TInterface, TAttribute>(Action<TInterface, TAttribute> PJIDDOOMHKI) where TInterface : IBKEEDIAHJL where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x63E38C0", Offset = "0x63E22C0", VA = "0x1863E38C0")]
	private void CNFBMDIBPGG(Type MAHAMGBPDNB, Type NOPMPDNHDJK, Type PLHLKFAJHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x25D1720", Offset = "0x25D0120", VA = "0x1825D1720")]
	private TInterface PAAAOGKMIAJ<TInterface>(Type MAHAMGBPDNB)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x63E3E60", Offset = "0x63E2860", VA = "0x1863E3E60")]
	private void IJNCGPKCOCH(IBKEEDIAHJL JBOPPAOFBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x63E3820", Offset = "0x63E2220", VA = "0x1863E3820")]
	private int CICIBNPAGNG(IBKEEDIAHJL MINNPODDJOP, int OIHCLELFNKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x63E38F0", Offset = "0x63E22F0", VA = "0x1863E38F0")]
	private void EFAPCPBMJEK(CFIMMOOLBHA JBOPPAOFBKD, IALIOADMEHK DGNEPEGOGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x63E3BA0", Offset = "0x63E25A0", VA = "0x1863E3BA0")]
	private void ICAOHOKDFOM(LIDECILMPBF JBOPPAOFBKD, PJDCBBBJMPI DGNEPEGOGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x63E4170", Offset = "0x63E2B70", VA = "0x1863E4170")]
	private void NNOFILDMAHC(AANHIKIDBNL JBOPPAOFBKD, BHJJFHNIJNI DGNEPEGOGIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct DDGAPFPKLCG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly BJKMJANDEAI KPGKMEENODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<IBKEEDIAHJL> EEEOHOLMEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<ONMDIIMHEPI> MKJJOHGAHNA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<ONMDIIMHEPI> JJNFJHAHANG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCC7400", Offset = "0xCC5E00", VA = "0x180CC7400")]
		get
		{
			return default(NativeList<ONMDIIMHEPI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x63E1970", Offset = "0x63E0370", VA = "0x1863E1970")]
	public DDGAPFPKLCG(BJKMJANDEAI KPGKMEENODO, List<IBKEEDIAHJL> EEEOHOLMEHN, NativeArray<ONMDIIMHEPI> FDKBJDOBHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x63E12A0", Offset = "0x63DFCA0", VA = "0x1863E12A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x63E12E0", Offset = "0x63DFCE0", VA = "0x1863E12E0")]
	private NativeList<ONMDIIMHEPI> HPENGBIKPMB(NativeArray<ONMDIIMHEPI> BLOCFCFKCPK)
	{
		return default(NativeList<ONMDIIMHEPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x63E16E0", Offset = "0x63E00E0", VA = "0x1863E16E0")]
	private bool ICIIDABFHGJ(IBKEEDIAHJL JBOPPAOFBKD, IHKMLADMILO NBFKKNHALIF, int KHHEGEKEEDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x63E17B0", Offset = "0x63E01B0", VA = "0x1863E17B0")]
	private void NPPEHFEJGIC(IBKEEDIAHJL JBOPPAOFBKD, IHKMLADMILO EKIMKHHEMFJ, int KHHEGEKEEDG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct JLDLDLLIOFH : IComparer<ONMDIIMHEPI>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x63E2F20", Offset = "0x63E1920", VA = "0x1863E2F20", Slot = "4")]
	public int Compare(ONMDIIMHEPI PKEMCIANHMO, ONMDIIMHEPI DLAMIJMLOOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x63E2ED0", Offset = "0x63E18D0", VA = "0x1863E2ED0")]
	public static void APBPIKENCBB(NativeList<ONMDIIMHEPI> FDKBJDOBHJM)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : NMOBLBLJIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x63E6900", Offset = "0x63E5300", VA = "0x1863E6900", Slot = "6")]
		public sealed override void EPCHFMECFAE(HCFBHIJDBLF JOIALDGLEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x63E6780", Offset = "0x63E5180", VA = "0x1863E6780", Slot = "4")]
		public sealed override void DBHAPDCLOEH()
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
