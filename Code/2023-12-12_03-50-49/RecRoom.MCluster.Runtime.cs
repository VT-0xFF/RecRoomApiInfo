using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.MCluster;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct PLDAMKELLML
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] IHGLBBJEECB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] NBMLACJMLOF;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] FBNIAJBOKLL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xD690D0", Offset = "0xD678D0", VA = "0x180D690D0")]
	public static int DPCMOPGIAPC(MMFFDKBCEJN LPAJNKEBPGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BE40", Offset = "0x5E4A640", VA = "0x185E4BE40")]
	public static int NLAHEOPHMDP(MMFFDKBCEJN LPAJNKEBPGN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AHNNLIAHKDO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int FLEFLHEMNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HNDEFOGKKMF DHEMFEIFCPO(int PLAHBEAKHNI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 PFBEDHMPDOA(int PLAHBEAKHNI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BNGKBJDCOCA PDHELGINLPE();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FMMAKLCCMAN HBOLFFCKJFF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PJIPGLJMBKN : OMLEALGIGMH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private BNGKBJDCOCA MIODEBPOBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform EHFFAELLOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<NIOAFBBONNK> OLLMBCFAMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private EFDHCCHPEBC CLGIKNOHAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private LDCBBEKEBDD GHHAHJOPPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool KOKJCKHJLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private AHNNLIAHKDO MNFLEIDLKEK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float HLDPDOLEJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x889BB0", Offset = "0x8883B0", VA = "0x180889BB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6770", Offset = "0xAB4F70", VA = "0x180AB6770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OKPHLOFHPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7E22A0", Offset = "0x7E0AA0", VA = "0x1807E22A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7E22B0", Offset = "0x7E0AB0", VA = "0x1807E22B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BOONAIBENBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BEE70", Offset = "0x7BD670", VA = "0x1807BEE70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA20", Offset = "0x7BD220", VA = "0x1807BEA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GHOHJDFGENL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E4BBA0", Offset = "0x5E4A3A0", VA = "0x185E4BBA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E4AF60", Offset = "0x5E49760", VA = "0x185E4AF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IFKAEMDNMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x11140C0", Offset = "0x11128C0", VA = "0x1811140C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BD80", Offset = "0x5E4A580", VA = "0x185E4BD80")]
	public PJIPGLJMBKN(AHNNLIAHKDO GHEDPMGCDIL, bool DPBKMPKGPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AD40", Offset = "0x5E49540", VA = "0x185E4AD40")]
	private bool GKAFEJBNMPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AF70", Offset = "0x5E49770", VA = "0x185E4AF70", Slot = "4")]
	public bool INCGBOEKEGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BBB0", Offset = "0x5E4A3B0", VA = "0x185E4BBB0", Slot = "5")]
	public bool OMANMGAMPNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AB10", Offset = "0x5E49310", VA = "0x185E4AB10", Slot = "6")]
	public void FMCALLKJEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AB00", Offset = "0x5E49300", VA = "0x185E4AB00", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KMMMHBBJCBG
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIECHFOHLFH(CommandBuffer AJKDCNAPJCL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KHCMOAHJJKN : KMMMHBBJCBG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int ALAIFGAODFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85FEF0", Offset = "0x85E6F0", VA = "0x18085FEF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier FHMJFDFHAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x39C5D00", Offset = "0x39C4500", VA = "0x1839C5D00")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E46C80", Offset = "0x5E45480", VA = "0x185E46C80")]
	public KHCMOAHJJKN(int MBMFHFDDILC, RenderTargetIdentifier FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E46C30", Offset = "0x5E45430", VA = "0x185E46C30", Slot = "4")]
	public void AIECHFOHLFH(CommandBuffer AJKDCNAPJCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PNGFOAHEEFJ : KMMMHBBJCBG
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int ALAIFGAODFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85FEF0", Offset = "0x85E6F0", VA = "0x18085FEF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] NEDCFAMJCKL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x836470", Offset = "0x834C70", VA = "0x180836470")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xB58170", Offset = "0xB56970", VA = "0x180B58170")]
	public PNGFOAHEEFJ(int MBMFHFDDILC, Vector4[] FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C500", Offset = "0x5E4AD00", VA = "0x185E4C500", Slot = "4")]
	public void AIECHFOHLFH(CommandBuffer AJKDCNAPJCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct IGEGOCMICOJ : KMMMHBBJCBG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int ALAIFGAODFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85FEF0", Offset = "0x85E6F0", VA = "0x18085FEF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] JPEDKGONKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x836470", Offset = "0x834C70", VA = "0x180836470")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xB58170", Offset = "0xB56970", VA = "0x180B58170")]
	public IGEGOCMICOJ(int MBMFHFDDILC, float[] FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E45F50", Offset = "0x5E44750", VA = "0x185E45F50", Slot = "4")]
	public void AIECHFOHLFH(CommandBuffer AJKDCNAPJCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HGPDBJAIMHC : KMMMHBBJCBG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string JOBPEPKBADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool GMFECAFJFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1855810", Offset = "0x1854010", VA = "0x181855810")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x38B2DB0", Offset = "0x38B15B0", VA = "0x1838B2DB0")]
	public HGPDBJAIMHC(string PMDCAPIFBIP, bool KAJOKJADDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E770", Offset = "0x5E3CF70", VA = "0x185E3E770", Slot = "4")]
	public void AIECHFOHLFH(CommandBuffer AJKDCNAPJCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct FMMAKLCCMAN
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 EAAOJPOHBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 NMCJHCHDEMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB2AA00", Offset = "0xB29200", VA = "0x180B2AA00")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int CIKGKHFMIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x89AF10", Offset = "0x899710", VA = "0x18089AF10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int FOCIGOKMLAC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B2FA0", Offset = "0x7B17A0", VA = "0x1807B2FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float LGEMJNGFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7C8590", Offset = "0x7C6D90", VA = "0x1807C8590")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E480", Offset = "0x5E3CC80", VA = "0x185E3E480")]
	public FMMAKLCCMAN(Color NGHDCCDAAOH, int LMJIBHAFIAL, int IBDHJFPOKKL, float KJJMPOENGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x540DDB0", Offset = "0x540C5B0", VA = "0x18540DDB0")]
	private static float4 CJEEFFEPGMB(Color NGHDCCDAAOH)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E3F0", Offset = "0x5E3CBF0", VA = "0x185E3E3F0")]
	private static Hash128 DBAHBGMPEAA(FMMAKLCCMAN GHEDPMGCDIL)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EFDHCCHPEBC : OMLEALGIGMH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string BLOHFGNAKPF;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string EMNPANAJJFC;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string COIJGBEDIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private FMMAKLCCMAN LKMHAEAJOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private BEMBNKAOGDP ECIAJACKHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 LPAFMNAHOGF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public LDCBBEKEBDD JOHAMJEBDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x799A80", Offset = "0x798280", VA = "0x180799A80")]
		[CompilerGenerated]
		get
		{
			return default(LDCBBEKEBDD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x893080", Offset = "0x891880", VA = "0x180893080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool OKPHLOFHPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x19FC730", Offset = "0x19FAF30", VA = "0x1819FC730")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x19FB850", Offset = "0x19FA050", VA = "0x1819FB850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool BOONAIBENBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x19FB820", Offset = "0x19FA020", VA = "0x1819FB820")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x19FCD90", Offset = "0x19FB590", VA = "0x1819FCD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IFKAEMDNMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x78D2A0", Offset = "0x78BAA0", VA = "0x18078D2A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool GHOHJDFGENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x504FAE0", Offset = "0x504E2E0", VA = "0x18504FAE0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5C93E70", Offset = "0x5C92670", VA = "0x185C93E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int EGOJHBDPODL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DCB0", Offset = "0x5E3C4B0", VA = "0x185E3DCB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DFA0", Offset = "0x5E3C7A0", VA = "0x185E3DFA0")]
	public EFDHCCHPEBC(FMMAKLCCMAN EGLGDDONFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DA50", Offset = "0x5E3C250", VA = "0x185E3DA50")]
	private bool GKAFEJBNMPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DB60", Offset = "0x5E3C360", VA = "0x185E3DB60", Slot = "4")]
	public bool INCGBOEKEGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D900", Offset = "0x5E3C100", VA = "0x185E3D900")]
	private static BEMBNKAOGDP DAEECIHHCOI(FMMAKLCCMAN GHEDPMGCDIL)
	{
		return default(BEMBNKAOGDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DD00", Offset = "0x5E3C500", VA = "0x185E3DD00", Slot = "5")]
	public bool OMANMGAMPNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D940", Offset = "0x5E3C140", VA = "0x185E3D940", Slot = "6")]
	public void FMCALLKJEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "9")]
	public void Dispose()
	{
	}
}
namespace RecRoom.MCluster
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MClusterData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			[Reload("Shaders/ClusterUpdate.compute", ReloadAttribute.Package.Root)]
			public ComputeShader UpdateShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[Reload("Shaders/ClusterRaster.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ClusterRasterShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[Reload("Shaders/ClusterCoarseCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader CoarseCullShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[Reload("Shaders/ClusterFineCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader FineCullShader;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5E474A0", Offset = "0x5E45CA0", VA = "0x185E474A0", Slot = "0")]
		public override bool Equals(object FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E476A0", Offset = "0x5E45EA0", VA = "0x185E476A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A90", Offset = "0x7F6290", VA = "0x1807F7A90")]
		public MClusterData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleRendererFeature(null)]
	public class MClusterRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private DFHHKOCBEPH opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static IDPNBIHBPID CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5E47D70", Offset = "0x5E46570", VA = "0x185E47D70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5E47DB0", Offset = "0x5E465B0", VA = "0x185E47DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5E47910", Offset = "0x5E46110", VA = "0x185E47910", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5E47750", Offset = "0x5E45F50", VA = "0x185E47750", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NOLODDJEKPD, RenderingData OLILCLCHOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5E47780", Offset = "0x5E45F80", VA = "0x185E47780")]
		public void CLILMPGAIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xB71880", Offset = "0xB70080", VA = "0x180B71880")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IEMAFEIIJID<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DPEDOAICPLL APDNMCFIIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private DPEDOAICPLL PICFNIFJAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer OFJAJLFBICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture POMBCCJFCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int KFLHLLJJFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int PEEHKEOIHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string PBDCKGCNJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string APPAGFNCBPB;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x778D40", Offset = "0x777540", VA = "0x180778D40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int GLCLFAPNBJO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xB94A30", Offset = "0xB93230", VA = "0x180B94A30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int LCNHEGLOEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x790470", Offset = "0x78EC70", VA = "0x180790470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x369B460", Offset = "0x3699C60", VA = "0x18369B460")]
	public IEMAFEIIJID(string PMDCAPIFBIP, int CPMOGGNDIHC, [Optional] RenderTextureFormat? EGKKOGLPHIA, bool DLLKEBOHFHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3699230", Offset = "0x3697A30", VA = "0x183699230")]
	public void OMANMGAMPNF(CommandBuffer AJKDCNAPJCL, NativeArray<ValType> FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3698B90", Offset = "0x3697390", VA = "0x183698B90")]
	public void LBCEHBKAEHJ(CommandBuffer AJKDCNAPJCL, ComputeShader MEEFFJENCAN, int NJECHGNEJDG, int FJOMAGICILH = -1, int PLEKPNMAIGP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3697A30", Offset = "0x3696230", VA = "0x183697A30")]
	public void LBCEHBKAEHJ(Material ECIAJACKHCB, int FJOMAGICILH = -1, int PLEKPNMAIGP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x36970D0", Offset = "0x36958D0", VA = "0x1836970D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MPOOJHNIJCA
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBCEHBKAEHJ(Material EGLGDDONFFE);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LDKGDOINJLL<SrcEntry, DstEntry> : MPOOJHNIJCA, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] JLPCHIOAAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected DPEDOAICPLL HDENMAGDNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected DPEDOAICPLL KKPNKAJDDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> GJENKDMAPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> HMDPHCMADAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int BCNDFPKHNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int LJKCEIHJBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected IEMAFEIIJID<int> DFGFNOCHKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected IEMAFEIIJID<SrcEntry> CLKNCKJDPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected IEMAFEIIJID<DstEntry> EFKFAIKKPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader BMEMFFKHBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int HIMHAJGAPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int FDBPPPMNIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int HKGCCKCHOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int LFPAHIECIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int IIPMELKFJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int IKNBEDOJLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int LBMBCMFHCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int MPAOEHANCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int FJMOKHLPNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int EGGGAINPKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int IJALILDJAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int KEHFDJABGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string JELCCBJEEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] GBKEIAOCANO;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int AADHEBMEGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x39F4930", Offset = "0x39F3130", VA = "0x1839F4930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string EAJGPHCJFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x39F2120", Offset = "0x39F0920", VA = "0x1839F2120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x39F6060", Offset = "0x39F4860", VA = "0x1839F6060")]
	public LDKGDOINJLL(string PMDCAPIFBIP, int OOABMAEDINK, int FNGFPDNOKHC, RenderTextureFormat EGKKOGLPHIA, ComputeShader AAADABPILOL, int HGNPMPMACIH = 0, int MPKHBPHBDME = 0, int GAFCDOLMICG = 0, int DOBPJDMNIHI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x39F1840", Offset = "0x39F0040", VA = "0x1839F1840")]
	public int KCKIBFENDKH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x39F06B0", Offset = "0x39EEEB0", VA = "0x1839F06B0")]
	protected void AFOKCEHOHPI(int EAHCFBMNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x39F1160", Offset = "0x39EF960", VA = "0x1839F1160")]
	public LDCBBEKEBDD INCGBOEKEGG(SrcEntry FCHBDAMJEHN)
	{
		return default(LDCBBEKEBDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x39F2D30", Offset = "0x39F1530", VA = "0x1839F2D30")]
	public bool OMANMGAMPNF(LDCBBEKEBDD JDLDAOKCDAP, SrcEntry FCHBDAMJEHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x39F0B80", Offset = "0x39EF380", VA = "0x1839F0B80")]
	public bool FMCALLKJEMI(LDCBBEKEBDD JDLDAOKCDAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "6")]
	protected virtual void EDKAFCLMDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x39F3CA0", Offset = "0x39F24A0", VA = "0x1839F3CA0", Slot = "7")]
	public void OOOECGGNNDK(CommandBuffer AJKDCNAPJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x39F3990", Offset = "0x39F2190", VA = "0x1839F3990", Slot = "8")]
	public void OOOECGGNNDK(CommandBuffer AJKDCNAPJCL, ComputeShader AAADABPILOL, int HGNPMPMACIH = -1, int MPKHBPHBDME = -1, int GAFCDOLMICG = -1, int DOBPJDMNIHI = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x39F29E0", Offset = "0x39F11E0", VA = "0x1839F29E0", Slot = "9")]
	public void LBCEHBKAEHJ(CommandBuffer AJKDCNAPJCL, ComputeShader AAADABPILOL, int HGNPMPMACIH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x39F2990", Offset = "0x39F1190", VA = "0x1839F2990", Slot = "4")]
	public void LBCEHBKAEHJ(Material ECIAJACKHCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x39F0880", Offset = "0x39EF080", VA = "0x1839F0880", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DPEDOAICPLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong NAJDBKHIGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong KBLLANDAHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JCGJJLJFPMF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct NKJBPADMDPN : DPEDOAICPLL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable HFCEPJBEBJM;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong NAJDBKHIGLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x836470", Offset = "0x834C70", VA = "0x180836470", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x56DAC00", Offset = "0x56D9400", VA = "0x1856DAC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong KBLLANDAHNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1247100", Offset = "0x1245900", VA = "0x181247100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A6C0", Offset = "0x5E48EC0", VA = "0x185E4A6C0")]
		internal NKJBPADMDPN(IDisposable DGBDDHEBOFM, ulong MBKFMIPHBGL, ulong APNKGIOCMEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A640", Offset = "0x5E48E40", VA = "0x185E4A640", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct FOJDBBFAIAF : DPEDOAICPLL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture LMKGMMDKLIM;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong NAJDBKHIGLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x836470", Offset = "0x834C70", VA = "0x180836470", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x56DAC00", Offset = "0x56D9400", VA = "0x1856DAC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong KBLLANDAHNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1247100", Offset = "0x1245900", VA = "0x181247100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E650", Offset = "0x5E3CE50", VA = "0x185E3E650")]
		public FOJDBBFAIAF(RenderTexture BCKBLDBDMHJ, ulong OOMPAJFCOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E5B0", Offset = "0x5E3CDB0", VA = "0x185E3E5B0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong NDOIGMBFLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E46000", Offset = "0x5E44800", VA = "0x185E46000")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5E46140", Offset = "0x5E44940", VA = "0x185E46140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong CCFLMFJIMLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5E45FC0", Offset = "0x5E447C0", VA = "0x185E45FC0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E45F80", Offset = "0x5E44780", VA = "0x185E45F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5E46520", Offset = "0x5E44D20", VA = "0x185E46520")]
	public static ComputeBuffer OEONKPJDENI(int PPKDCOOCBKP, int FONFNJKLIKA, ComputeBufferType HJNJPNKDEFH, [Out] DPEDOAICPLL JDLDAOKCDAP, ComputeBufferMode JECPNLKEDGA = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5E46180", Offset = "0x5E44980", VA = "0x185E46180")]
	public static RenderTexture OEONKPJDENI(int OAAHJLMDBPE, int PHBBHKLLCMB, int LCPEGFJBFOD, RenderTextureFormat EGKKOGLPHIA, [Out] DPEDOAICPLL JDLDAOKCDAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x25391C0", Offset = "0x25379C0", VA = "0x1825391C0")]
	public static NativeArray<T> DKCGAALEBHG<T>(NativeArray<T> HFCEPJBEBJM, ulong BONCBNKGOGN, [Out] DPEDOAICPLL JDLDAOKCDAP) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x253A020", Offset = "0x2538820", VA = "0x18253A020")]
	public static NativeArray<T> OEONKPJDENI<T>(int BONCBNKGOGN, Allocator BIOBDEGNFFO, [Out] DPEDOAICPLL JDLDAOKCDAP, NativeArrayOptions JDIKAIHEILK = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5E46700", Offset = "0x5E44F00", VA = "0x185E46700")]
	public static void PIODDHMICMM(DPEDOAICPLL HFCEPJBEBJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5E46040", Offset = "0x5E44840", VA = "0x185E46040")]
	public static uint JIEKHLHACFL(RenderTextureFormat EGKKOGLPHIA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MJCBJDIPLKJ : LDKGDOINJLL<FKDOMNLFOAI, FKDOMNLFOAI>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct EGDFPNADOEP : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> EGNOAEFOILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> FJMMABEPFED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> OHBFNDJCMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> MHFFDENFICD;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A590", Offset = "0x5D28D90", VA = "0x185D2A590")]
		public EGDFPNADOEP(NativeArray<int> NPNPGOEJBGJ, NativeArray<float> NJPBHNAEBII, NativeArray<float4x4> IFLBICOAKKI, NativeArray<float4> OONDFBONEGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DFE0", Offset = "0x5E3C7E0", VA = "0x185E3DFE0", Slot = "4")]
		public void Execute(int EAHCFBMNNCF, TransformAccess MIODEBPOBDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct GPDLLDLPICO : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> EGNOAEFOILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> IFLJMGEJAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> BPHHCCMNFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<FKDOMNLFOAI> PDIFJGGEOEI;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A590", Offset = "0x5D28D90", VA = "0x185D2A590")]
		public GPDLLDLPICO(NativeArray<int> NPNPGOEJBGJ, NativeArray<float4x4> NGGMPNMJAHL, NativeArray<float4> COBJAGELPAD, NativeArray<FKDOMNLFOAI> FPCLANOGJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E680", Offset = "0x5E3CE80", VA = "0x185E3E680", Slot = "4")]
		public void Execute(int EAHCFBMNNCF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte CKKPKFCJKPH = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray JAMNMONCLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> LCDIDGDMIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> FNPLKDLLOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> ECBEMBDPJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> DKDOPNKIBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> FAHNEJLEPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private DPEDOAICPLL MAMLMMLEAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private DPEDOAICPLL ABPMNDOIHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private DPEDOAICPLL CAGCLELDFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private DPEDOAICPLL BFNDHEIOEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private DPEDOAICPLL AMBBFABEAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform DMBOBDLJIKD;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E48510", Offset = "0x5E46D10", VA = "0x185E48510")]
	public MJCBJDIPLKJ(int OOABMAEDINK, int FNGFPDNOKHC, ComputeShader AAADABPILOL, int HGNPMPMACIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5E480C0", Offset = "0x5E468C0", VA = "0x185E480C0", Slot = "6")]
	protected override void EDKAFCLMDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E48370", Offset = "0x5E46B70", VA = "0x185E48370")]
	private void IKNOPMAHJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E47EC0", Offset = "0x5E466C0", VA = "0x185E47EC0")]
	public bool BDFKKDJAPNH(LDCBBEKEBDD JDLDAOKCDAP, Transform MIODEBPOBDK, float BBDIKBFIHLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E48430", Offset = "0x5E46C30", VA = "0x185E48430")]
	public void MAEAMLALCFM(LDCBBEKEBDD JDLDAOKCDAP, float BBDIKBFIHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5E482C0", Offset = "0x5E46AC0", VA = "0x185E482C0")]
	public void FGIOPIFJHMP(LDCBBEKEBDD JDLDAOKCDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5E48020", Offset = "0x5E46820", VA = "0x185E48020", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HNDEFOGKKMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KHBPKJNGAIG NJFDFAHEDCH();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EJHIKJIOJDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 EAAOJPOHBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int DDIBKKFCILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int JFKDLKFKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> HNCNNHBNINL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> IFMAPHDCCNK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> IDIOGMCPGIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> JNJOAAMNGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> LNKEHHFEGOI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> LPFNONGFDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int AJBBENOBJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int HBLKIEOHEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int MDLKGLKPKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool ICEPFNKKEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OOOECGGNNDK();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LNBABIGPOPC : EJHIKJIOJDA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private HNDEFOGKKMF PNIBEHINDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private KHBPKJNGAIG OPJNLFOIMJC;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 EAAOJPOHBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xB2AA00", Offset = "0xB29200", VA = "0x180B2AA00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1B7B790", Offset = "0x1B79F90", VA = "0x181B7B790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool IHLNEGOBFMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x77D850", Offset = "0x77C050", VA = "0x18077D850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int DDIBKKFCILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7B2FA0", Offset = "0x7B17A0", VA = "0x1807B2FA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7B2690", Offset = "0x7B0E90", VA = "0x1807B2690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int JFKDLKFKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7733B0", Offset = "0x771BB0", VA = "0x1807733B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x773B30", Offset = "0x772330", VA = "0x180773B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int HIFPAIAIBLP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x913090", Offset = "0x911890", VA = "0x180913090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> HNCNNHBNINL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5E47190", Offset = "0x5E45990", VA = "0x185E47190", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> IFMAPHDCCNK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5E47010", Offset = "0x5E45810", VA = "0x185E47010", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> IDIOGMCPGIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E47040", Offset = "0x5E45840", VA = "0x185E47040", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> JNJOAAMNGEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E47100", Offset = "0x5E45900", VA = "0x185E47100", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> LNKEHHFEGOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E47350", Offset = "0x5E45B50", VA = "0x185E47350", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> LPFNONGFDBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E47210", Offset = "0x5E45A10", VA = "0x185E47210", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ICEPFNKKEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D60", Offset = "0x7C7560", VA = "0x1807C8D60", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C8BD0", Offset = "0x7C73D0", VA = "0x1807C8BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int AJBBENOBJFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E47200", Offset = "0x5E45A00", VA = "0x185E47200", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int HBLKIEOHEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5E47170", Offset = "0x5E45970", VA = "0x185E47170", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int MDLKGLKPKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E47380", Offset = "0x5E45B80", VA = "0x185E47380", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E473A0", Offset = "0x5E45BA0", VA = "0x185E473A0")]
	public LNBABIGPOPC(Hash128 NNKNHLJGCKJ, HNDEFOGKKMF PNIBEHINDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E47240", Offset = "0x5E45A40", VA = "0x185E47240", Slot = "16")]
	public void OOOECGGNNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E47070", Offset = "0x5E45870", VA = "0x185E47070", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct LDCBBEKEBDD : IEquatable<LDCBBEKEBDD>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly LDCBBEKEBDD MIOPHGKICKL;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int EGOJHBDPODL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85FEF0", Offset = "0x85E6F0", VA = "0x18085FEF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x85FF00", Offset = "0x85E700", VA = "0x18085FF00")]
	public LDCBBEKEBDD(int EAHCFBMNNCF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E46E60", Offset = "0x5E45660", VA = "0x185E46E60", Slot = "4")]
	public bool Equals(LDCBBEKEBDD FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E46EB0", Offset = "0x5E456B0", VA = "0x185E46EB0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E46F80", Offset = "0x5E45780", VA = "0x185E46F80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NIOAFBBONNK : OMLEALGIGMH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool KOKJCKHJLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private EJHIKJIOJDA BDHBMHJPAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<LDCBBEKEBDD> JMHBCBMCKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<LDCBBEKEBDD> PCDOBPPFALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<LDCBBEKEBDD> MEGABHGCDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> CFPHPEODLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int EPPAOOHNOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int FLEJGBGFGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int ICOFCKANFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int ANANKMHMJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int IOLEEIPAIBB;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int EGOJHBDPODL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A3A0", Offset = "0x5E48BA0", VA = "0x185E4A3A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A360", Offset = "0x5E48B60", VA = "0x185E4A360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool OKPHLOFHPGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C5270", Offset = "0x7C3A70", VA = "0x1807C5270")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x952690", Offset = "0x950E90", VA = "0x180952690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool BOONAIBENBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA98280", Offset = "0xA96A80", VA = "0x180A98280")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA98290", Offset = "0xA96A90", VA = "0x180A98290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool IFKAEMDNMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x78D2A0", Offset = "0x78BAA0", VA = "0x18078D2A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool GHOHJDFGENL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1641EF0", Offset = "0x16406F0", VA = "0x181641EF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1641F00", Offset = "0x1640700", VA = "0x181641F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float HLDPDOLEJJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x19D5EB0", Offset = "0x19D46B0", VA = "0x1819D5EB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x19D6000", Offset = "0x19D4800", VA = "0x1819D6000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A4D0", Offset = "0x5E48CD0", VA = "0x185E4A4D0")]
	public NIOAFBBONNK(EJHIKJIOJDA OPJNLFOIMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E48900", Offset = "0x5E47100", VA = "0x185E48900")]
	private void AMKBOKPIIAE(EJHIKJIOJDA OPJNLFOIMJC, int EPPAOOHNOOD, int NHJEPCAJFDP, int EAHCFBMNNCF, int BNPBDNKNBNE, NHBHAAHJJAG FCHBDAMJEHN, float IPOPLIFMEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E49450", Offset = "0x5E47C50", VA = "0x185E49450")]
	private void GDPABIJDGDN(EJHIKJIOJDA OPJNLFOIMJC, int MCMDFGDDENG, int EAHCFBMNNCF, uint3 GPBFLGFMNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E49720", Offset = "0x5E47F20", VA = "0x185E49720")]
	private bool GKAFEJBNMPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E499C0", Offset = "0x5E481C0", VA = "0x185E499C0", Slot = "4")]
	public bool INCGBOEKEGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A450", Offset = "0x5E48C50", VA = "0x185E4A450", Slot = "5")]
	public bool OMANMGAMPNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E48DE0", Offset = "0x5E475E0", VA = "0x185E48DE0", Slot = "6")]
	public void FMCALLKJEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E488A0", Offset = "0x5E470A0", VA = "0x185E488A0")]
	public void AIKAPMPBAKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E488A0", Offset = "0x5E470A0", VA = "0x185E488A0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OMLEALGIGMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool IFKAEMDNMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool GHOHJDFGENL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INCGBOEKEGG();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OMANMGAMPNF();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMCALLKJEMI();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DJLKIJKCKHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float HMKLFIGNGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, NIOAFBBONNK> OKFNIDFPHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, EFDHCCHPEBC> CDLMANPOBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<OMLEALGIGMH> OBDBLCFFMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<OMLEALGIGMH> PJBGKHIGHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<OMLEALGIGMH> JEKOPFFIDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int FDNBNDAFCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int BADFMLKIHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float KMBKKCKJKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool CKMFFNLODKI;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool DNNBDKODOME
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xB73EC0", Offset = "0xB726C0", VA = "0x180B73EC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xB7E4E0", Offset = "0xB7CCE0", VA = "0x180B7E4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool KHCMBGBHLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5E3C630", Offset = "0x5E3AE30", VA = "0x185E3C630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string EAJGPHCJFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E3CE10", Offset = "0x5E3B610", VA = "0x185E3CE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D720", Offset = "0x5E3BF20", VA = "0x185E3D720")]
	public void PMEHCFCEDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D1B0", Offset = "0x5E3B9B0", VA = "0x185E3D1B0")]
	public void NDNANCMIJCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D770", Offset = "0x5E3BF70", VA = "0x185E3D770")]
	public DJLKIJKCKHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C790", Offset = "0x5E3AF90", VA = "0x185E3C790")]
	public PJIPGLJMBKN FPBPDBBEPKK(AHNNLIAHKDO PIOFGCGEFCD, bool DPBKMPKGPEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CBB0", Offset = "0x5E3B3B0", VA = "0x185E3CBB0")]
	public EFDHCCHPEBC FPBPDBBEPKK(FMMAKLCCMAN ECIAJACKHCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CCF0", Offset = "0x5E3B4F0", VA = "0x185E3CCF0")]
	public bool HFFFBGLLNMC(Hash128 MBMFHFDDILC, [Out] NIOAFBBONNK EJBJMOBMCIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C8C0", Offset = "0x5E3B0C0", VA = "0x185E3C8C0")]
	public NIOAFBBONNK FPBPDBBEPKK(EJHIKJIOJDA OPJNLFOIMJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C610", Offset = "0x5E3AE10", VA = "0x185E3C610")]
	private void CGGKEOBHHEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D690", Offset = "0x5E3BE90", VA = "0x185E3D690")]
	private bool PKECPLEONLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D1C0", Offset = "0x5E3B9C0", VA = "0x185E3D1C0")]
	public void OOOECGGNNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C680", Offset = "0x5E3AE80", VA = "0x185E3C680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CD60", Offset = "0x5E3B560", VA = "0x185E3CD60")]
	public void HGJBKAAJLCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KGAFOOFOGOO : LDKGDOINJLL<JFNGNLNEHMO, JFNGNLNEHMO>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E46B80", Offset = "0x5E45380", VA = "0x185E46B80")]
	public KGAFOOFOGOO(int OOABMAEDINK, int FNGFPDNOKHC, ComputeShader AAADABPILOL, int HGNPMPMACIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CKHJEJGLIDI : LDKGDOINJLL<BEMBNKAOGDP, BEMBNKAOGDP>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C120", Offset = "0x5E3A920", VA = "0x185E3C120")]
	public CKHJEJGLIDI(int OOABMAEDINK, int FNGFPDNOKHC, ComputeShader AAADABPILOL, int HGNPMPMACIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FIKICDOHJGO : LDKGDOINJLL<MCFMBAGPLEH, MCFMBAGPLEH>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E1A0", Offset = "0x5E3C9A0", VA = "0x185E3E1A0")]
	public FIKICDOHJGO(int OOABMAEDINK, int FNGFPDNOKHC, ComputeShader AAADABPILOL, int HGNPMPMACIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class BIGOAOKCIDF : LDKGDOINJLL<INPGDLBMDCF, KGACJHCGHLB>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C070", Offset = "0x5E3A870", VA = "0x185E3C070")]
	public BIGOAOKCIDF(int OOABMAEDINK, int FNGFPDNOKHC, ComputeShader AAADABPILOL, int HGNPMPMACIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NCGNLDIHIMF : LDKGDOINJLL<OKNCGPAMPCA, OKNCGPAMPCA>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E487F0", Offset = "0x5E46FF0", VA = "0x185E487F0")]
	public NCGNLDIHIMF(int OOABMAEDINK, int FNGFPDNOKHC, ComputeShader AAADABPILOL, int HGNPMPMACIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class DFHHKOCBEPH : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IDPNBIHBPID ALFMNGOELNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool KAJOKJADDID;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool DKDFBDGOAPO;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C5D0", Offset = "0x5E3ADD0", VA = "0x185E3C5D0")]
	public DFHHKOCBEPH(IDPNBIHBPID BBAAKEMONHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C440", Offset = "0x5E3AC40", VA = "0x185E3C440", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer AJKDCNAPJCL, RenderingData OLILCLCHOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C1D0", Offset = "0x5E3A9D0", VA = "0x185E3C1D0", Slot = "6")]
	public override void Configure(CommandBuffer AJKDCNAPJCL, RenderTextureDescriptor LNMEAKLKHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C210", Offset = "0x5E3AA10", VA = "0x185E3C210", Slot = "9")]
	public override void Execute(ScriptableRenderContext LFDLOIPEDMO, RenderingData OLILCLCHOJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class HKIOGNJACCC
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct LBKEKKFGIEG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string PMDCAPIFBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer AJKDCNAPJCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext LFDLOIPEDMO;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E46D50", Offset = "0x5E45550", VA = "0x185E46D50")]
		public LBKEKKFGIEG(string JFAIAHBGNAM, ScriptableRenderContext INNMIIBNNNG, [Out] CommandBuffer KCBLDHCOFOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E46CA0", Offset = "0x5E454A0", VA = "0x185E46CA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EB80", Offset = "0x5E3D380", VA = "0x185E3EB80")]
	public static bool PIFGCEKDAGE(RenderingData OLILCLCHOJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E7B0", Offset = "0x5E3CFB0", VA = "0x185E3E7B0")]
	public static void FPOJGJELFPN(CommandBuffer AJKDCNAPJCL, ScriptableRenderContext LFDLOIPEDMO, ShadowDrawingSettings BAINCAEKNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E950", Offset = "0x5E3D150", VA = "0x185E3E950")]
	public static void PBGEACHBHGK(CommandBuffer AJKDCNAPJCL, ScriptableRenderContext LFDLOIPEDMO, RenderingData OLILCLCHOJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class IDPNBIHBPID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class GPMLDHOBFCI
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int CBIGBJKKGLD;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int ABGJOCCAGAD;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static IEMAFEIIJID<MHFFCKHEJPM> HAADNPLELMD;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static IEMAFEIIJID<uint> IPLDPINONGC;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static DPEDOAICPLL JAAFNAHDDCA;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer NCJJDMIHLOO;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<MPOOJHNIJCA> MHOIHBFIDBJ;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int GOKKBFKMOKJ;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int KHJOGMFPAON;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int NNIIJPCJDNJ;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int LIJPBOJHPJA;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] CALALOAHDLP;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] JEOGAKFFJIJ;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static KMMMHBBJCBG[][] GFJKCPEEJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] OGKDLFOHFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int PPHDKFBINEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int PKMCABJNJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int FFFNANKCIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int HAKHLDDKMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int EPOONDDACFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int LKLMLLHKEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int KBAIMFIDEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int HKLMLONLAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int DPMEALINBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int PNOJADMPNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int IIFJKPHMHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int ICDPGJALLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int FJIPNPIEANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int MKNDFKEJDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int APGKCHLHOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int NEOMEPHFMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int MKOFNMIHFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int FNPFHJNABGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] NFBMHPNBDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private DJLKIJKCKHM BMGAJIKNMCI;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool MPFCAFGOGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E40D10", Offset = "0x5E3F510", VA = "0x185E40D10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E43640", Offset = "0x5E41E40", VA = "0x185E43640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool JDPOCNIJECI
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E420F0", Offset = "0x5E408F0", VA = "0x185E420F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E40A90", Offset = "0x5E3F290", VA = "0x185E40A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData GKMCBGMNDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F510", Offset = "0x5E3DD10", VA = "0x185E3F510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E40B70", Offset = "0x5E3F370", VA = "0x185E40B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static MJCBJDIPLKJ PPLHDBODFJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E42030", Offset = "0x5E40830", VA = "0x185E42030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E413C0", Offset = "0x5E3FBC0", VA = "0x185E413C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static KGAFOOFOGOO ECPKIBAIHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F230", Offset = "0x5E3DA30", VA = "0x185E3F230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E40A20", Offset = "0x5E3F220", VA = "0x185E40A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static CKHJEJGLIDI AFEFDABNJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E43510", Offset = "0x5E41D10", VA = "0x185E43510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E412E0", Offset = "0x5E3FAE0", VA = "0x185E412E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static FIKICDOHJGO ALNNFAJBMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E42800", Offset = "0x5E41000", VA = "0x185E42800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E42080", Offset = "0x5E40880", VA = "0x185E42080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static BIGOAOKCIDF MCJDDACDJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E43720", Offset = "0x5E41F20", VA = "0x185E43720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E41DE0", Offset = "0x5E405E0", VA = "0x185E41DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static NCGNLDIHIMF IIGPANCJGPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E43780", Offset = "0x5E41F80", VA = "0x185E43780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E40AF0", Offset = "0x5E3F2F0", VA = "0x185E40AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material JDAMLALPBLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E40CB0", Offset = "0x5E3F4B0", VA = "0x185E40CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E43840", Offset = "0x5E42040", VA = "0x185E43840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material KCMDNEAANND
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E437E0", Offset = "0x5E41FE0", VA = "0x185E437E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5E40BE0", Offset = "0x5E3F3E0", VA = "0x185E40BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material AHIANOOEFGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5E411E0", Offset = "0x5E3F9E0", VA = "0x185E411E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5E43560", Offset = "0x5E41D60", VA = "0x185E43560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material CNFHGDEAEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5E435E0", Offset = "0x5E41DE0", VA = "0x185E435E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5E436A0", Offset = "0x5E41EA0", VA = "0x185E436A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool HIILIOCPIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F280", Offset = "0x5E3DA80", VA = "0x185E3F280")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5E45750", Offset = "0x5E43F50", VA = "0x185E45750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool KHCMBGBHLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F4B0", Offset = "0x5E3DCB0", VA = "0x185E3F4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string EAJGPHCJFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5E42140", Offset = "0x5E40940", VA = "0x185E42140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5E45CF0", Offset = "0x5E444F0", VA = "0x185E45CF0")]
	internal IDPNBIHBPID([Optional] MClusterData EKLOMCKCGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F670", Offset = "0x5E3DE70", VA = "0x185E3F670")]
	public void EBEAKPIECKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5E41240", Offset = "0x5E3FA40", VA = "0x185E41240")]
	public void GAHKBGHKAMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5E41430", Offset = "0x5E3FC30", VA = "0x185E41430")]
	public void IMDNJIEMEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5E41D40", Offset = "0x5E40540", VA = "0x185E41D40")]
	public bool JDPCKJFNKLG(Hash128 NNKNHLJGCKJ, [Out] NIOAFBBONNK OPJNLFOIMJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5E40F20", Offset = "0x5E3F720", VA = "0x185E40F20")]
	public NIOAFBBONNK FPBPDBBEPKK(EJHIKJIOJDA FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5E40FE0", Offset = "0x5E3F7E0", VA = "0x185E40FE0")]
	public EFDHCCHPEBC FPBPDBBEPKK(FMMAKLCCMAN ECIAJACKHCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5E40D60", Offset = "0x5E3F560", VA = "0x185E40D60")]
	public PJIPGLJMBKN FPBPDBBEPKK(AHNNLIAHKDO PIOFGCGEFCD, bool DPBKMPKGPEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5E40C60", Offset = "0x5E3F460", VA = "0x185E40C60")]
	public void FMCALLKJEMI(OMLEALGIGMH FKJMOCBEIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F3C0", Offset = "0x5E3DBC0", VA = "0x185E3F3C0")]
	public static void CPADDHIEBPE(MMFFDKBCEJN LPAJNKEBPGN, KMMMHBBJCBG[] FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5E41440", Offset = "0x5E3FC40", VA = "0x185E41440")]
	private void JDBOGNKLMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5E42850", Offset = "0x5E41050", VA = "0x185E42850")]
	private static void LFOKAOHPCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5E44480", Offset = "0x5E42C80", VA = "0x185E44480")]
	public void PCCJEGKLAPP(CommandBuffer AJKDCNAPJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5E41E60", Offset = "0x5E40660", VA = "0x185E41E60")]
	public void JJPDFGNKJLD([Optional] ScriptableRenderContext? LFDLOIPEDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5E441A0", Offset = "0x5E429A0", VA = "0x185E441A0")]
	public void OLIKPPBIGHB(CommandBuffer AJKDCNAPJCL, ShadowSplitData PGOHJLOJABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5E43EC0", Offset = "0x5E426C0", VA = "0x185E43EC0")]
	public void OLIKPPBIGHB(CommandBuffer AJKDCNAPJCL, CameraData GJOKAIKEBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5E3ECD0", Offset = "0x5E3D4D0", VA = "0x185E3ECD0")]
	public void APLKAHBLBEI(CommandBuffer AJKDCNAPJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5E41350", Offset = "0x5E3FB50", VA = "0x185E41350")]
	public void HPNMMAMDCEB(CommandBuffer AJKDCNAPJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5E457B0", Offset = "0x5E43FB0", VA = "0x185E457B0")]
	public void PLPOABKLKFL(CommandBuffer AJKDCNAPJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5E438C0", Offset = "0x5E420C0", VA = "0x185E438C0")]
	public void OHOKOBHAJBJ(CommandBuffer AJKDCNAPJCL, MMFFDKBCEJN NPDKHJFGCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F2E0", Offset = "0x5E3DAE0", VA = "0x185E3F2E0")]
	public void CLILMPGAIIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5E447A0", Offset = "0x5E42FA0", VA = "0x185E447A0")]
	public void PIODDHMICMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F560", Offset = "0x5E3DD60", VA = "0x185E3F560", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DFIBHHOCOAL
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1C567D0", Offset = "0x1C54FD0", VA = "0x181C567D0")]
	public static int EDEBPGJLJJN(int BOCONGADANC, int EPPJAOCMBBK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct FKDOMNLFOAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 PLHKKOPBHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 FOOIDFOHDMM;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly FKDOMNLFOAI NLIHPGJOFFE;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly FKDOMNLFOAI MIOPHGKICKL;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E3C0", Offset = "0x5E3CBC0", VA = "0x185E3E3C0")]
	public FKDOMNLFOAI(float4x4 FKKBOKNONOP, float4 CFOBCJJFKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E250", Offset = "0x5E3CA50", VA = "0x185E3E250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct NHBHAAHJJAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 FLFCGPFDCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 HMKNLJLLNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 BINPHDLBKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 ENNOCLPGLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 HKLNNEABBGA;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct EKAAIKNBJFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 FLFCGPFDCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 HMKNLJLLNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 BINPHDLBKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 ENNOCLPGLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 HKLNNEABBGA;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct KGACJHCGHLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public EKAAIKNBJFH DNGNEIOJLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public EKAAIKNBJFH DLAGAOKLJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public EKAAIKNBJFH HPNMCANDPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public EKAAIKNBJFH PJCKDNJHIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public EKAAIKNBJFH BLIBCLEIEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public EKAAIKNBJFH BPEPCHEAIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public EKAAIKNBJFH PHFLFGAABBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public EKAAIKNBJFH INDNFAOKGJK;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct INPGDLBMDCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public NHBHAAHJJAG DNGNEIOJLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public NHBHAAHJJAG DLAGAOKLJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public NHBHAAHJJAG HPNMCANDPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public NHBHAAHJJAG PJCKDNJHIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public NHBHAAHJJAG BLIBCLEIEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public NHBHAAHJJAG BPEPCHEAIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public NHBHAAHJJAG PHFLFGAABBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public NHBHAAHJJAG INDNFAOKGJK;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct BEMBNKAOGDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 FPMBEPIOEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint LMJIBHAFIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint IBDHJFPOKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float KJJMPOENGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint NKJBEOGAKNN;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C040", Offset = "0x5E3A840", VA = "0x185E3C040")]
	public BEMBNKAOGDP(FMMAKLCCMAN ECIAJACKHCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct MHFFCKHEJPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint JPJAADNOIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint PIMCNHABOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint BNPBDNKNBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint NKJBEOGAKNN;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5E47E10", Offset = "0x5E46610", VA = "0x185E47E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct MCFMBAGPLEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint NHJEPCAJFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint HIGOILFNCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint FLEJGBGFGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint NKJBEOGAKNN;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5E473F0", Offset = "0x5E45BF0", VA = "0x185E473F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct JFNGNLNEHMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint AAEJBMPGNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint CFCMBAHBKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint AJMCOCJFHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint BKKDPEPFPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint HIAELBBALHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint HICCOHPMJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint AGCEJLFEPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint NKJBEOGAKNN;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5E46850", Offset = "0x5E45050", VA = "0x185E46850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct OKNCGPAMPCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 CEPNCLLCDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 HPDEHPINHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 KJPCKOFPNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 EDMPMDHHAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 AMPAADECLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 JOCOOEMHFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 HEPEFJOIBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 BFJLLNPNHAO;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A700", Offset = "0x5E48F00", VA = "0x185E4A700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum MMFFDKBCEJN
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Opaque,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	DepthOnly,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Transparent,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Shadow
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
