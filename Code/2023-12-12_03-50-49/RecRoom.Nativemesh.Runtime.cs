using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NJHCHPICLGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int ELLAKBBLMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 OLHHMNAPMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion JGJFMBKDDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 LIFBJPDEOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int BJPJLDLBNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int MKBLHDKPDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int IKJLNGPCDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float HHJEJGAOFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 OFCKNKBHLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool KKHFLCKDENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public CGNJMLIHFAB KBMGFCOEEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 BFAIBABAFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float KGPDIGDFLNC;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class INJAPEPBNEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static MLLFIMANBLE JJFFOHNJIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<NJHCHPICLGK> GKDNNJJLHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<BBCECMFFGAJ> BHFLKHJBOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<PIDKJEKHINI> JAOAFJEFNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<GNGEAGCJBDA> EPKMOBEJOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<BBCECMFFGAJ> BAOALBPPGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<DFFDELPAFHP> FJJOMBBGNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<GNGEAGCJBDA>> DKLOHLEEAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<FNCHJLMBGAH> LPFMPFKBDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> ADOBCNAPNOL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JFKDLKFKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB99B60", Offset = "0xB98360", VA = "0x180B99B60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB99460", Offset = "0xB97C60", VA = "0x180B99460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DDIBKKFCILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB99B70", Offset = "0xB98370", VA = "0x180B99B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB99450", Offset = "0xB97C50", VA = "0x180B99450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D1F0", Offset = "0x5E5B9F0", VA = "0x185E5D1F0")]
	public INJAPEPBNEN(int AILFFHIICJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CAA0", Offset = "0x5E5B2A0", VA = "0x185E5CAA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B6A0", Offset = "0x5E59EA0", VA = "0x185E5B6A0")]
	public void ALEHCMDHAIF(JobHandle JPBBNPJNGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B870", Offset = "0x5E5A070", VA = "0x185E5B870")]
	public void BDDAEBOBHLC(NJHCHPICLGK FCHBDAMJEHN, FNCHJLMBGAH IAPDGDMKMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D0B0", Offset = "0x5E5B8B0", VA = "0x185E5D0B0")]
	public void LHNINLMKNAE(PIDKJEKHINI FCHBDAMJEHN, NativeArray<GNGEAGCJBDA> NIHIAEPPMDL, int EPPAOOHNOOD, int FLEJGBGFGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5BA90", Offset = "0x5E5A290", VA = "0x185E5BA90")]
	public JobHandle CMJBAGABMEI(KHBPKJNGAIG ELMFCBEDBCC, INFBBLBNEPL KCMFEPJNGEB, float3 JFHOJNGKGIA, quaternion IAGDGFAPBBA, float PNALMNKKPBF, bool JFBIPDFGFJB, int EFAKDDNIJDL = 0, int PINIJLNEBNP = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CD70", Offset = "0x5E5B570", VA = "0x185E5CD70")]
	public static JobHandle KPBCOBFMJPN(LFKJJJJNBAF MLKGPGLHHHO, KHBPKJNGAIG ELMFCBEDBCC, NJHCHPICLGK FCHBDAMJEHN, JobHandle JPBBNPJNGBC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CAC0", Offset = "0x5E5B2C0", VA = "0x185E5CAC0")]
	public static JobHandle JAMDFOCIHFD(CEFGKEOOKDP MLKGPGLHHHO, KHBPKJNGAIG ELMFCBEDBCC, PIDKJEKHINI FCHBDAMJEHN, NativeArray<GNGEAGCJBDA> NIHIAEPPMDL, int EPPAOOHNOOD, int FLEJGBGFGKO, JobHandle JPBBNPJNGBC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct PIOFNEPLCIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 KEAGPFCIOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 IFMAPHDCCNK;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MBNBJBMCLEO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<PIOFNEPLCIK> JEAGGMPHKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> NOBLDPLEJOL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JFKDLKFKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x773AF0", Offset = "0x7722F0", VA = "0x180773AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DDIBKKFCILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7733B0", Offset = "0x771BB0", VA = "0x1807733B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5E60870", Offset = "0x5E5F070", VA = "0x185E60870")]
	public MBNBJBMCLEO(int JDADEDOLDOE, int LINJKMOAEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E60810", Offset = "0x5E5F010", VA = "0x185E60810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E60730", Offset = "0x5E5EF30", VA = "0x185E60730")]
	public void AEJOJCOAGAG(MBNBJBMCLEO IOPPFDDIPEF, int DBFNANAEMBA, int DJIOGHHPANO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PJADHHHKFBK
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static MBNBJBMCLEO MBMHIIKKGFE;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<BBCECMFFGAJ> ENCHAAGIJPM;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static int[] HIHJPBHBLKK;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static bool FFAHALGNODK;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static Dictionary<int, MBNBJBMCLEO> KBNCMKHHCKD;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, MBNBJBMCLEO> MKNNFHFFEHH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool COAMMFFAEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E622A0", Offset = "0x5E60AA0", VA = "0x185E622A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<BBCECMFFGAJ> HGBIDKCKDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E62440", Offset = "0x5E60C40", VA = "0x185E62440")]
		get
		{
			return default(NativeList<BBCECMFFGAJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static MBNBJBMCLEO GMCDCNPMKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E60FF0", Offset = "0x5E5F7F0", VA = "0x185E60FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E61510", Offset = "0x5E5FD10", VA = "0x185E61510")]
	private static void EBCDDEMJCOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E61BF0", Offset = "0x5E603F0", VA = "0x185E61BF0")]
	public static int HPEKJDOMKPG(bool DIMBLJCFJOC, int DACJFFPDEEG, bool IJFIKJCJCHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E62320", Offset = "0x5E60B20", VA = "0x185E62320")]
	private static int MIHEMJEOHCI(int DACJFFPDEEG, bool ACDHECHFGBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E62430", Offset = "0x5E60C30", VA = "0x185E62430")]
	private static int OHCFNBLPACC(int DACJFFPDEEG, bool ACDHECHFGBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E61B60", Offset = "0x5E60360", VA = "0x185E61B60")]
	public static int HPANJIKHJLJ(int PLAHBEAKHNI, int DACJFFPDEEG, int CPDHMPHKBGB, bool ACDHECHFGBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E60F60", Offset = "0x5E5F760", VA = "0x185E60F60")]
	public static int BBKNDHNFMCO(int PLAHBEAKHNI, int DACJFFPDEEG, int CPDHMPHKBGB, bool ACDHECHFGBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E62290", Offset = "0x5E60A90", VA = "0x185E62290")]
	public static int KHMIDFCNKAH(int CPDHMPHKBGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E61CB0", Offset = "0x5E604B0", VA = "0x185E61CB0")]
	private static int IAFPDIPAPHI(int DACJFFPDEEG, bool ACDHECHFGBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E61B20", Offset = "0x5E60320", VA = "0x185E61B20")]
	private static int FJBDFNOEKEO(int DACJFFPDEEG, bool ACDHECHFGBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E61090", Offset = "0x5E5F890", VA = "0x185E61090")]
	public static int DHCBBHCCICJ(int PLAHBEAKHNI, int DACJFFPDEEG, int CPDHMPHKBGB, bool ACDHECHFGBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E61C20", Offset = "0x5E60420", VA = "0x185E61C20")]
	public static int IABLMEJFAJE(int PLAHBEAKHNI, int DACJFFPDEEG, int CPDHMPHKBGB, bool ACDHECHFGBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E61B40", Offset = "0x5E60340", VA = "0x185E61B40")]
	public static int HBCANGMIGIK(int CPDHMPHKBGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E624E0", Offset = "0x5E60CE0", VA = "0x185E624E0")]
	public static MBNBJBMCLEO ONMLKMPEEFN(int DACJFFPDEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E62000", Offset = "0x5E60800", VA = "0x185E62000")]
	private static MBNBJBMCLEO KHAOKIOBDGI(int DACJFFPDEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E62340", Offset = "0x5E60B40", VA = "0x185E62340")]
	public static MBNBJBMCLEO NGDLEMABHKM(int DACJFFPDEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E61CC0", Offset = "0x5E604C0", VA = "0x185E61CC0")]
	private static MBNBJBMCLEO JFNHADGHHAF(int DACJFFPDEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E61100", Offset = "0x5E5F900", VA = "0x185E61100")]
	public static void DNDBDDLLOBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PIDKJEKHINI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int ACEBOGJEFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 OLHHMNAPMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public quaternion JGJFMBKDDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float LIFBJPDEOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float KPEPOEAHBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int BJPJLDLBNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int MKBLHDKPDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int IKJLNGPCDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public bool OHEPFPOALDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool LFMIOFMCENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float HHJEJGAOFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float3 OFCKNKBHLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool KLGMFAKFAEM;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DFFDELPAFHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int CJDPEOOAFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int GJEKOLPOEEH;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct CEFGKEOOKDP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<PIDKJEKHINI> GACEGGECAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<GNGEAGCJBDA> JNPOFBAHPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<BBCECMFFGAJ> LMNLBLKNDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<DFFDELPAFHP> PGGMMENDACJ;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E58E60", Offset = "0x5E57660", VA = "0x185E58E60")]
	public CEFGKEOOKDP(NativeArray<GNGEAGCJBDA> JNPOFBAHPBK, int NKCDHJPJBIF = 1, Allocator BIOBDEGNFFO = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E58D70", Offset = "0x5E57570", VA = "0x185E58D70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BurstCompile]
public struct AGNINOBJBEC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<PIOFNEPLCIK> OPMDKBHBNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> KBJAPHHGKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<BBCECMFFGAJ> GGDGGBLGAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<PIDKJEKHINI> GACEGGECAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<GNGEAGCJBDA> JNPOFBAHPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<BBCECMFFGAJ> LMNLBLKNDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<DFFDELPAFHP> PGGMMENDACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int MGLMBEPGDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int LMGNOGLCGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float3 DNHFFDBGMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion DEFBFBBEACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 MONKHEIHDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EKLMEKKCGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PHJDCGAMJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EBLDKMFNIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KIGFMGAFOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> LEGICHOHBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> IAGDMOFIMPJ;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E56040", Offset = "0x5E54840", VA = "0x185E56040")]
	public AGNINOBJBEC(INJAPEPBNEN LJKPNAMAKDB, KHBPKJNGAIG EGEPNBGHEOG, float3 OAHNLOBGGHE, quaternion PJNMOMOCBON, float PLFFKMNINPJ, int EFAKDDNIJDL = 0, int PINIJLNEBNP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E55E10", Offset = "0x5E54610", VA = "0x185E55E10")]
	public AGNINOBJBEC(CEFGKEOOKDP LJKPNAMAKDB, KHBPKJNGAIG EGEPNBGHEOG, float3 OAHNLOBGGHE, quaternion PJNMOMOCBON, float3 PLFFKMNINPJ, int EFAKDDNIJDL = 0, int PINIJLNEBNP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E53E90", Offset = "0x5E52690", VA = "0x185E53E90")]
	private float3 DMAMADFMLPN(float3 MDAHEJAOONM, Matrix4x4 EHIFDEJCFLO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E55D90", Offset = "0x5E54590", VA = "0x185E55D90")]
	private float3x3 MPGDOPEHMGM(float3x3 BAHONJPDMHC, float3x3 DECCPCFEDPJ)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E53FC0", Offset = "0x5E527C0", VA = "0x185E53FC0")]
	private float ENADMLOJDAA(float AMKKNHFCFKO, float KGGAEFCJMFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E53FD0", Offset = "0x5E527D0", VA = "0x185E53FD0", Slot = "4")]
	public void Execute(int KCAGHHGBPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E55170", Offset = "0x5E53970", VA = "0x185E55170")]
	private void GAMFHDGGKHE(int DPFLKHKGLAN, float3 FLFCGPFDCMD, float3 HMKNLJLLNBH, float3 BINPHDLBKBJ, float EHFGJJPBLJP, bool MOEPKICHEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E55930", Offset = "0x5E54130", VA = "0x185E55930")]
	private void LDNPHFAHDDK(PIDKJEKHINI IACLCBKGFGJ, float3 IELODMIJPLB, float3x3 JEACNADEOBC, float AMKKNHFCFKO, int OOAGCLEBDOL, int IMMACPALIBG, int HJGIGKPGGHA, float HMOKKIFMIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E552E0", Offset = "0x5E53AE0", VA = "0x185E552E0")]
	private void GGFOOADJDCE(int DPFLKHKGLAN, int OKILBIHJBCO, PIDKJEKHINI IACLCBKGFGJ, float3 IELODMIJPLB, float3x3 JEACNADEOBC, bool BGDKNEOKIPK, float AMKKNHFCFKO, int AJPCOICNEME, int GONHGPIOGAA, int HJGIGKPGGHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct LFKJJJJNBAF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<NJHCHPICLGK> PNKGEKEAEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeList<BBCECMFFGAJ> BOEOHDDBDKD;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5E60640", Offset = "0x5E5EE40", VA = "0x185E60640")]
	public LFKJJJJNBAF(int NKCDHJPJBIF, Allocator BIOBDEGNFFO = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E605A0", Offset = "0x5E5EDA0", VA = "0x185E605A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct JFEEEENFABC : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private enum BBAPCLGNCIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeList<float3> JFMMNKLLLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float3> BAECJBEEFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<int> HCIJNDCDMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<int> OAAAIAKMNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> GHMFAPGNCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<float4> AOJFBOLOCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeArray<float4> LHIPMEHHHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<float3> KHLKKPCKAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<BBCECMFFGAJ> JMDHBNCGPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private NativeList<NJHCHPICLGK> PNKGEKEAEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private NativeList<BBCECMFFGAJ> BOEOHDDBDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private int MGLMBEPGDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	private int LMGNOGLCGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EKLMEKKCGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PHJDCGAMJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EBLDKMFNIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KIGFMGAFOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> LEGICHOHBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> IAGDMOFIMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float3 MONKHEIHDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private quaternion DEFBFBBEACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float3 DNHFFDBGMEM;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E810", Offset = "0x5E5D010", VA = "0x185E5E810")]
	public JFEEEENFABC(INJAPEPBNEN LJKPNAMAKDB, KHBPKJNGAIG EGEPNBGHEOG, float3 OAHNLOBGGHE, quaternion PJNMOMOCBON, float PLFFKMNINPJ, int EFAKDDNIJDL = 0, int PINIJLNEBNP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EA00", Offset = "0x5E5D200", VA = "0x185E5EA00")]
	public JFEEEENFABC(LFKJJJJNBAF FCHBDAMJEHN, KHBPKJNGAIG EGEPNBGHEOG, float3 OAHNLOBGGHE, quaternion PJNMOMOCBON, float3 PLFFKMNINPJ, int EFAKDDNIJDL = 0, int PINIJLNEBNP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D4B0", Offset = "0x5E5BCB0", VA = "0x185E5D4B0", Slot = "4")]
	public void Execute(int KCAGHHGBPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E410", Offset = "0x5E5CC10", VA = "0x185E5E410")]
	private void GOJKJCJEFPE(float4x4 EGLGDDONFFE, int KCAGHHGBPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D440", Offset = "0x5E5BC40", VA = "0x185E5D440")]
	private BBAPCLGNCIH EFEDBOOGBMI(float3 HMKNLJLLNBH)
	{
		return default(BBAPCLGNCIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E7C0", Offset = "0x5E5CFC0", VA = "0x185E5E7C0")]
	private float4 NFEDMOLFKOM(BBAPCLGNCIH IMMIDAGAJNF, int EAHCFBMNNCF)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D400", Offset = "0x5E5BC00", VA = "0x185E5D400")]
	private float2 DEDLIPMOHGA(BBAPCLGNCIH IMMIDAGAJNF, float3 FLFCGPFDCMD)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FNCHJLMBGAH
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum IMNGKFEOPHM
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static FNCHJLMBGAH NJCGGNOBEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float3 HNCNNHBNINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3x3 HPENPABNLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 PCGHIJCLEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public IMNGKFEOPHM CCNHBOAJCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 AIBEDPFAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 DGKBFBFMHDH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AFICHJEBJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5E5A4B0", Offset = "0x5E58CB0", VA = "0x185E5A4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 EHMJLNEPACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E5AAF0", Offset = "0x5E592F0", VA = "0x185E5AAF0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AE40", Offset = "0x5E59640", VA = "0x185E5AE40")]
	public FNCHJLMBGAH(float3 FLFCGPFDCMD, quaternion JOBDANNFLEE, float3 NKCDHJPJBIF, IMNGKFEOPHM HJNJPNKDEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5ABD0", Offset = "0x5E593D0", VA = "0x185E5ABD0")]
	public float PMGEIJHOBHN(float3 IELODMIJPLB, float MLJFMPIAAFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AA00", Offset = "0x5E59200", VA = "0x185E5AA00")]
	public bool MCNGAANCEIL(float3 HMKNLJLLNBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A850", Offset = "0x5E59050", VA = "0x185E5A850")]
	public void LCOOOPPEDBK(float3 GKABFNCAPFI, float3x3 LAHNGECJNOH, float JKHOLLKGNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A750", Offset = "0x5E58F50", VA = "0x185E5A750")]
	private void IGGBBMNPAEH(float3 JCKCLHMKLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A4C0", Offset = "0x5E58CC0", VA = "0x185E5A4C0")]
	public void GLDDCLDIMAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct KJLHLGDJGDM : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<FNCHJLMBGAH> FCHBDAMJEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> AGAKFKNHFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeList<int> GMFDKLICKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> ADOBCNAPNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeList<BBCECMFFGAJ> BOEOHDDBDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int BHOMLLKACJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int HNLABFMMBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private float MLJFMPIAAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float EOAPDFBHBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> OIDJLIIFBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> BKMOIOIHJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> NHGEKKCODNO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5E60500", Offset = "0x5E5ED00", VA = "0x185E60500")]
	public KJLHLGDJGDM(KHBPKJNGAIG OPJNLFOIMJC, float JBFAJEACHFJ, int DJIOGHHPANO, int OOAGCLEBDOL, NativeList<FNCHJLMBGAH> FCHBDAMJEHN, NativeArray<int> ADOBCNAPNOL, NativeList<BBCECMFFGAJ> BOEOHDDBDKD, INFBBLBNEPL KCMFEPJNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FD00", Offset = "0x5E5E500", VA = "0x185E5FD00", Slot = "4")]
	public void Execute(int BIIBGGEFFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E60440", Offset = "0x5E5EC40", VA = "0x185E60440")]
	private bool OPDJDHGOCMD(FNCHJLMBGAH GIFKCLLLICD, FNCHJLMBGAH KIOLHHMPBGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FA60", Offset = "0x5E5E260", VA = "0x185E5FA60")]
	private bool DFCOONMFKCO(FNCHJLMBGAH FCAIODKILEB, int JFKPPAAEAIC, int LGGCAPOEPEO, int NHFIDFNMCNB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class INFBBLBNEPL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<bool> HOFKBPHECMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<int> PMGECBFOCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<bool> DPJBEEGDJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeArray<float> CPPHDKIIOBF;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B5A0", Offset = "0x5E59DA0", VA = "0x185E5B5A0")]
	public void NKJMIPHNKIJ(int JDADEDOLDOE, int LINJKMOAEOP, Allocator BIOBDEGNFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B580", Offset = "0x5E59D80", VA = "0x185E5B580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B490", Offset = "0x5E59C90", VA = "0x185E5B490")]
	public void ALEHCMDHAIF(JobHandle JPBBNPJNGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public INFBBLBNEPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct DNHIKBJOOFA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<float3> AGAKFKNHFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float3> JOPPEJLCDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeArray<float4> PAAOBDPNLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeArray<float2> JEHKGOGBOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<int> GMFDKLICKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PCIACHNNMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeArray<int> OBOMKIJPBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<bool> OIDJLIIFBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeArray<bool> BKMOIOIHJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int EFAKDDNIJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int PINIJLNEBNP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A430", Offset = "0x5E58C30", VA = "0x185E5A430")]
	public DNHIKBJOOFA(KHBPKJNGAIG OPJNLFOIMJC, INFBBLBNEPL KCMFEPJNGEB, int PINIJLNEBNP = 0, int EFAKDDNIJDL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A050", Offset = "0x5E58850", VA = "0x185E5A050", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E59FF0", Offset = "0x5E587F0", VA = "0x185E59FF0")]
	private void DELMDMEDJPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EHGEDGKONPN
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2387DE0", Offset = "0x23865E0", VA = "0x182387DE0")]
	public static bool OFFJLBEEFCN<T>(NativeArray<T> CMKNCDNHDNA, int NKCDHJPJBIF, Allocator BIOBDEGNFFO, NativeArrayOptions JDIKAIHEILK = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2387E80", Offset = "0x2386680", VA = "0x182387E80")]
	public static bool OFFJLBEEFCN<T>(NativeList<T> GKICFBMALOA, int NKCDHJPJBIF, Allocator BIOBDEGNFFO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum HOJOLHIILFP
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	None
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HPIGNGKGJJE
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OBBKCAHJEDO(HOJOLHIILFP PLAHBEAKHNI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int CHBHCEDFNND(HOJOLHIILFP PLAHBEAKHNI);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKKCPFKFMEL(HOJOLHIILFP PLAHBEAKHNI, INJAPEPBNEN DKEJEJCCNLA, int MHNCAGMILEN = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KHBPKJNGAIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const int IEFDLFIGDLA = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeList<float3> ECNJNPNAICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<float3> PPFPNBMDCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float4> DNODLDJNGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public NativeArray<float4> DCPNAHEFEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NativeArray<float2> NNIHCKGJAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<int> EOLPOOCFIEN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool KODPMDJOGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F010", Offset = "0x5E5D810", VA = "0x185E5F010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JFKDLKFKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FA20", Offset = "0x5E5E220", VA = "0x185E5FA20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DDIBKKFCILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EFD0", Offset = "0x5E5D7D0", VA = "0x185E5EFD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool GOIGHAGCFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F160", Offset = "0x5E5D960", VA = "0x185E5F160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F050", Offset = "0x5E5D850", VA = "0x185E5F050", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F850", Offset = "0x5E5E050", VA = "0x185E5F850")]
	public void NKJMIPHNKIJ(int JDADEDOLDOE, int LINJKMOAEOP, Allocator BIOBDEGNFFO, bool OKBIIACHPPL, bool IPACFLHNBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F7D0", Offset = "0x5E5DFD0", VA = "0x185E5F7D0")]
	public void IPDGCOBHGGP(int JDADEDOLDOE, int LINJKMOAEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EBF0", Offset = "0x5E5D3F0", VA = "0x185E5EBF0", Slot = "6")]
	public bool AKCFCNJJFFB(Mesh OPJNLFOIMJC, bool LBCBOHMDIHF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F1A0", Offset = "0x5E5D9A0", VA = "0x185E5F1A0")]
	public bool GGKGFAMMEBH(Mesh OPJNLFOIMJC, KHBPKJNGAIG LFACEADDMOC, bool LBCBOHMDIHF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public KHBPKJNGAIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class CIAOFFNHCLF
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5E58F90", Offset = "0x5E57790", VA = "0x185E58F90")]
	public static void DNDBDDLLOBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AGGFALKPHPP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<float3> ECNJNPNAICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeArray<float3> PPFPNBMDCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeArray<int> PHDHDHJONHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeArray<float4> GELEGLPGIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<float4> BPIFINKNFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<float4> APDDEFOIDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeList<float3> PHLNICBOJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public NativeList<int> EOLPOOCFIEN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JFKDLKFKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5E534B0", Offset = "0x5E51CB0", VA = "0x185E534B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DDIBKKFCILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E52DA0", Offset = "0x5E515A0", VA = "0x185E52DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int ALFGGAPBEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E52EF0", Offset = "0x5E516F0", VA = "0x185E52EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5E53C70", Offset = "0x5E52470", VA = "0x185E53C70")]
	public AGGFALKPHPP(int JDADEDOLDOE, int LINJKMOAEOP, int ENGALFCCJIG, Allocator BIOBDEGNFFO = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5E53980", Offset = "0x5E52180", VA = "0x185E53980")]
	public AGGFALKPHPP(Mesh OPJNLFOIMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5E52DE0", Offset = "0x5E515E0", VA = "0x185E52DE0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E52AA0", Offset = "0x5E512A0", VA = "0x185E52AA0")]
	public void AEJOJCOAGAG(AGGFALKPHPP OPJNLFOIMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E534F0", Offset = "0x5E51CF0", VA = "0x185E534F0")]
	private void OCGLOOOGNOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5E52F30", Offset = "0x5E51730", VA = "0x185E52F30")]
	private void NMBJHBAMPMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BBCECMFFGAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int DMPHAJJNCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int JFKDLKFKLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int JEOCPKDLKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int DDIBKKFCILI;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1133F30", Offset = "0x1132730", VA = "0x181133F30")]
	public BBCECMFFGAJ(int OOAGCLEBDOL, int EPPAOOHNOOD, int DJIOGHHPANO, int FLEJGBGFGKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MLLFIMANBLE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NativeList<BBCECMFFGAJ> CMOLOILLMDA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB2AA00", Offset = "0xB29200", VA = "0x180B2AA00")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<BBCECMFFGAJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1B7B790", Offset = "0x1B79F90", VA = "0x181B7B790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AGGFALKPHPP JAPLHMMCHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x773B60", Offset = "0x772360", VA = "0x180773B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5E609A0", Offset = "0x5E5F1A0", VA = "0x185E609A0")]
	public MLLFIMANBLE(IEnumerable<AGGFALKPHPP> IOMLGAIJLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5E60930", Offset = "0x5E5F130", VA = "0x185E60930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum CGNJMLIHFAB
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class HPNGKPMMNPC
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static NativeArray<float2> BONONPMCEJJ;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static NativeArray<float3> ICCCINICMOK;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static NativeArray<float4> NAGCHMMJBPF;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static NativeArray<int> JMHKGFNGKDB;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B040", Offset = "0x5E59840", VA = "0x185E5B040")]
	public static void DNDBDDLLOBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B160", Offset = "0x5E59960", VA = "0x185E5B160")]
	public static NativeArray<float2> HJGFLDIKKNI(NativeArray<float2> INIALBHKCKG, int MDKMPKNLGMN, NativeArray<float2> AEKPICLBGKD, int AMCCABOHEPA)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AF30", Offset = "0x5E59730", VA = "0x185E5AF30")]
	public static NativeArray<float3> BELKNMEMBAL(NativeArray<float3> INIALBHKCKG, int MDKMPKNLGMN, NativeArray<float3> AEKPICLBGKD, int AMCCABOHEPA)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B380", Offset = "0x5E59B80", VA = "0x185E5B380")]
	public static NativeArray<float4> PKBNJHGJAGE(NativeArray<float4> INIALBHKCKG, int MDKMPKNLGMN, NativeArray<float4> AEKPICLBGKD, int AMCCABOHEPA)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B270", Offset = "0x5E59A70", VA = "0x185E5B270")]
	public static NativeArray<int> MEIDMHMBFAE(NativeArray<int> INIALBHKCKG, int MDKMPKNLGMN, NativeArray<int> AEKPICLBGKD, int AMCCABOHEPA)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x24F8580", Offset = "0x24F6D80", VA = "0x1824F8580")]
	private static void JJCIAEFELBE<T>(NativeArray<T> CMKNCDNHDNA, int BDHDMBCKINH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x24F84D0", Offset = "0x24F6CD0", VA = "0x1824F84D0")]
	private static void BDLHIHCBELG<T>(NativeArray<T> INIALBHKCKG, int MDKMPKNLGMN, NativeArray<T> AEKPICLBGKD, int AMCCABOHEPA, NativeArray<T> IHENHFMHHCB) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DFJBBPGLGOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<HPIGNGKGJJE> GMCMPCFFBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly PIDAGOEHHBD JHHFAGBIJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int EPPAOOHNOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int FLEJGBGFGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool AJIACDAFOLC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh JAPLHMMCHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7790D0", Offset = "0x7778D0", VA = "0x1807790D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x778B30", Offset = "0x777330", VA = "0x180778B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MeshRenderer PCEPDHCBHDA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x773B70", Offset = "0x772370", VA = "0x180773B70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int JFKDLKFKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5E59EB0", Offset = "0x5E586B0", VA = "0x185E59EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x209DE00", Offset = "0x209C600", VA = "0x18209DE00")]
	public void OMMNEIEIEFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E59ED0", Offset = "0x5E586D0", VA = "0x185E59ED0")]
	public DFJBBPGLGOG(string PMDCAPIFBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5E590E0", Offset = "0x5E578E0", VA = "0x185E590E0")]
	public void ALEHCMDHAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E59A90", Offset = "0x5E58290", VA = "0x185E59A90")]
	public void HLJCMJLLDJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E59970", Offset = "0x5E58170", VA = "0x185E59970")]
	public void FJMLPBBNKKK(HPIGNGKGJJE CADJKPOACDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E59AC0", Offset = "0x5E582C0", VA = "0x185E59AC0")]
	private void INLFHEMOFAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5E59A20", Offset = "0x5E58220", VA = "0x185E59A20")]
	public bool GIHINNGGEOB(HPIGNGKGJJE CADJKPOACDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5E59DE0", Offset = "0x5E585E0", VA = "0x185E59DE0")]
	public bool JOIKPGDKLEA(HPIGNGKGJJE CADJKPOACDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5E59E40", Offset = "0x5E58640", VA = "0x185E59E40", Slot = "4")]
	public virtual void NGCIKKDOFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E598A0", Offset = "0x5E580A0", VA = "0x185E598A0")]
	public void DHEMFEIFCPO(Transform PFDINFPFNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5E59120", Offset = "0x5E57920", VA = "0x185E59120")]
	public bool APLELGDAIMC(Transform PFDINFPFNNH, [Out] (KHBPKJNGAIG destMesh, Mesh mesh, JobHandle job) FCHBDAMJEHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5E59D30", Offset = "0x5E58530", VA = "0x185E59D30")]
	public void JCMEBEOJGGG([In] (KHBPKJNGAIG destMesh, Mesh mesh, JobHandle job) FCHBDAMJEHN)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker LLHPIIMJPPI;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker COCCMEFOKMP;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker JKMBJBPBDOA;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private const int JKFJJCIGHCC = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Dictionary<Material, List<DFJBBPGLGOG>> EBIOJHPAFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private List<DFJBBPGLGOG> EBBKPDNJFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<MeshRenderer> FIHJPENONPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private List<(DFJBBPGLGOG, (KHBPKJNGAIG, Mesh, JobHandle))> LGMIMLBDMKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool CNOBIFKJONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<int, float> NCKGOFIJBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Dictionary<int, Color> GOIOCFPLHLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<int, Vector4> OPECBFEOCNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Dictionary<int, Matrix4x4> JFPLNIGHHKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private DFJBBPGLGOG OMLJGHIKHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Material DGKHMGIEGGN;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<MeshRenderer> DKDCLINOOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x773B40", Offset = "0x772340", VA = "0x180773B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E57D30", Offset = "0x5E56530", VA = "0x185E57D30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E56720", Offset = "0x5E54F20", VA = "0x185E56720")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E562D0", Offset = "0x5E54AD0", VA = "0x185E562D0")]
		public DFJBBPGLGOG AddToBatchedMesh(HPIGNGKGJJE DKFCCEGMOLK, Material ECIAJACKHCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5E57F80", Offset = "0x5E56780", VA = "0x185E57F80")]
		public void RemoveFromBatchedMesh(HPIGNGKGJJE OPJNLFOIMJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5E56580", Offset = "0x5E54D80", VA = "0x185E56580")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E58100", Offset = "0x5E56900", VA = "0x185E58100")]
		public void SetMaterialProperty(int GPPBGDKFIDI, Color NGHDCCDAAOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5E58590", Offset = "0x5E56D90", VA = "0x185E58590")]
		public void SetMaterialProperty(int GPPBGDKFIDI, float DOLICEBFIPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5E587B0", Offset = "0x5E56FB0", VA = "0x185E587B0")]
		public void SetMaterialProperty(int GPPBGDKFIDI, Vector4 JBJBCDBKHCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E58330", Offset = "0x5E56B30", VA = "0x185E58330")]
		public void SetMaterialProperty(int GPPBGDKFIDI, Matrix4x4 FDOFEJKHEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5E57320", Offset = "0x5E55B20", VA = "0x185E57320")]
		private void GABBCDLMJBI(Renderer NOLODDJEKPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E57310", Offset = "0x5E55B10", VA = "0x185E57310")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E56DB0", Offset = "0x5E555B0", VA = "0x185E56DB0")]
		private void FOHIFGCHGKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5E57910", Offset = "0x5E56110", VA = "0x185E57910")]
		private DFJBBPGLGOG HCOMIKLIGPF(HPIGNGKGJJE OPJNLFOIMJC, Material ECIAJACKHCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E563B0", Offset = "0x5E54BB0", VA = "0x185E563B0")]
		private DFJBBPGLGOG CHJGFFGENEG(Material ECIAJACKHCB, int ECBJLGCFEIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5E56900", Offset = "0x5E55100", VA = "0x185E56900")]
		private DFJBBPGLGOG FCMKLNLAHBA(Material ECIAJACKHCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5E57B10", Offset = "0x5E56310", VA = "0x185E57B10")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5E57BA0", Offset = "0x5E563A0", VA = "0x185E57BA0")]
		public void MarkDirty(HPIGNGKGJJE OPJNLFOIMJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5E58AB0", Offset = "0x5E572B0", VA = "0x185E58AB0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FGHGDDDIBLD<KeyType> : DFJBBPGLGOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<KeyType, HPIGNGKGJJE> DMGOHLDDNGC;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3467A60", Offset = "0x3466260", VA = "0x183467A60")]
	public FGHGDDDIBLD(string PMDCAPIFBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3467890", Offset = "0x3466090", VA = "0x183467890")]
	public void FJMLPBBNKKK(KeyType EMBEECDJLJB, HPIGNGKGJJE CADJKPOACDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x34676F0", Offset = "0x3465EF0", VA = "0x1834676F0")]
	public bool AHBCIJCHDFL(KeyType EMBEECDJLJB, HPIGNGKGJJE MPEOJINKFCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3467920", Offset = "0x3466120", VA = "0x183467920")]
	public void PBDLNNMJGFJ(KeyType EMBEECDJLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x34678E0", Offset = "0x34660E0", VA = "0x1834678E0", Slot = "4")]
	public override void NGCIKKDOFFC()
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
