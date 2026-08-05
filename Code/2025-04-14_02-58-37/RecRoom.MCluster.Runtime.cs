using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
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
namespace _LogRegistration.RecRoom_MCluster_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7972FF0", Offset = "0x79719F0", VA = "0x187972FF0", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public LogRegistrationIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct HCPBIIOPNLF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] IKEFHNPJHPA;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] EFDIOENPCGN;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] NMLEOANAOEP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1D76B80", Offset = "0x1D75580", VA = "0x181D76B80")]
	public static int PNKBPNNALJN(KBICMIJMCPA HKKKDLOOHLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x796FBA0", Offset = "0x796E5A0", VA = "0x18796FBA0")]
	public static int ALAFHIBPMOD(KBICMIJMCPA HKKKDLOOHLD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AFKEJKMHAMM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int DPBJHJBCDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KJICOBOBPDB CPOGGCHFJDD(int BJJGMOJDONE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 ADIGJILKDHC(int BJJGMOJDONE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FJCDPKDIACD GFIDGEKBDEF();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FIDPILACLGN PCAENAFPFBK();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KJLIMKEBJFB : GJIBJBIFDMN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private FJCDPKDIACD GBIMAJCBFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform GJABNHDMPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<CANAAPMHPFF> IBBBEKEBCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private BFKKPLGGCGN JMMJDHILFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IFDLBLOLFOD NHDNNNBABDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool MILJOPPDGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private AFKEJKMHAMM BGMELJBNKLD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float HMIHOKAPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB917C0", Offset = "0xB901C0", VA = "0x180B917C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB91C80", Offset = "0xB90680", VA = "0x180B91C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FHHPIADPNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBAD060", Offset = "0xBABA60", VA = "0x180BAD060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC78470", Offset = "0xC76E70", VA = "0x180C78470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool HIEEJBKJNGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xD02E30", Offset = "0xD01830", VA = "0x180D02E30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xD02AD0", Offset = "0xD014D0", VA = "0x180D02AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LNAJNJCEACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1D7CBA0", Offset = "0x1D7B5A0", VA = "0x181D7CBA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1D7BE60", Offset = "0x1D7A860", VA = "0x181D7BE60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FJNPNMPMCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1E68880", Offset = "0x1E67280", VA = "0x181E68880", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7972F30", Offset = "0x7971930", VA = "0x187972F30")]
	public KJLIMKEBJFB(AFKEJKMHAMM NKHEGOPIGCH, bool CJPDIKKAMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7971EF0", Offset = "0x79708F0", VA = "0x187971EF0")]
	private bool CIDGFBHJAKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7972120", Offset = "0x7970B20", VA = "0x187972120", Slot = "4")]
	public bool HEHCILJMFIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7972D60", Offset = "0x7971760", VA = "0x187972D60", Slot = "5")]
	public bool IPDLKHCHONO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7971CD0", Offset = "0x79706D0", VA = "0x187971CD0", Slot = "6")]
	public void CBCJJMKDJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7972110", Offset = "0x7970B10", VA = "0x187972110", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DEPFMFAIADF
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOBKGLGLKBC(CommandBuffer FLBFPNANBKH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct KAPJPCONHKE : DEPFMFAIADF
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int FIGDAIADJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier KEPCJJCBHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4EA07E0", Offset = "0x4E9F1E0", VA = "0x184EA07E0")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x79718A0", Offset = "0x79702A0", VA = "0x1879718A0")]
	public KAPJPCONHKE(int ICHIIHCEGJD, RenderTargetIdentifier DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7971850", Offset = "0x7970250", VA = "0x187971850", Slot = "4")]
	public void KOBKGLGLKBC(CommandBuffer FLBFPNANBKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JGJMDALEFDJ : DEPFMFAIADF
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int FIGDAIADJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] HKNDJGEFAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xD0E7A0", Offset = "0xD0D1A0", VA = "0x180D0E7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1581470", Offset = "0x157FE70", VA = "0x181581470")]
	public JGJMDALEFDJ(int ICHIIHCEGJD, Vector4[] DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7971770", Offset = "0x7970170", VA = "0x187971770", Slot = "4")]
	public void KOBKGLGLKBC(CommandBuffer FLBFPNANBKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KBKDHJMJHBH : DEPFMFAIADF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int FIGDAIADJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] ALBPFGGHPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD0E7A0", Offset = "0xD0D1A0", VA = "0x180D0E7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1581470", Offset = "0x157FE70", VA = "0x181581470")]
	public KBKDHJMJHBH(int ICHIIHCEGJD, float[] DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x79718C0", Offset = "0x79702C0", VA = "0x1879718C0", Slot = "4")]
	public void KOBKGLGLKBC(CommandBuffer FLBFPNANBKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GGOPDAAKNOH : DEPFMFAIADF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string HFKDIDMKBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool MJIOMGCHBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA40", Offset = "0xC9A440", VA = "0x180C9BA40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x16D9FD0", Offset = "0x16D89D0", VA = "0x1816D9FD0")]
	public GGOPDAAKNOH(string EMLAIMJKHOE, bool PLGFLNLCLML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x796FB60", Offset = "0x796E560", VA = "0x18796FB60", Slot = "4")]
	public void KOBKGLGLKBC(CommandBuffer FLBFPNANBKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct FIDPILACLGN
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 CBLCAEOJCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 IJALEKHPIBB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xEC09F0", Offset = "0xEBF3F0", VA = "0x180EC09F0")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int BANOGJGBLLB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xB86090", Offset = "0xB84A90", VA = "0x180B86090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int IJEGDGIGGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xC976B0", Offset = "0xC960B0", VA = "0x180C976B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float MGAGNIIPAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xE86E80", Offset = "0xE85880", VA = "0x180E86E80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x796F980", Offset = "0x796E380", VA = "0x18796F980")]
	public FIDPILACLGN(Color IFFOAMBAJEI, int PHAOADFJMIM, int DIMNPBKLDMO, float PIDKIAJJFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x106ECE0", Offset = "0x106D6E0", VA = "0x18106ECE0")]
	private static float4 BBOJGKGMOIG(Color IFFOAMBAJEI)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x796F8F0", Offset = "0x796E2F0", VA = "0x18796F8F0")]
	private static Hash128 PMFJIMFHMGI(FIDPILACLGN NKHEGOPIGCH)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BFKKPLGGCGN : GJIBJBIFDMN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string KBHAMFLOEBC;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string ILFIFPLODJE;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string AOIJPCNOHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private FIDPILACLGN FKIHMFIIEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private FAFBMCHMADN GMIALIBEKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 NKICHLOHLLA;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public IFDLBLOLFOD KPFOCMPHCAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9D4D60", Offset = "0x9D3760", VA = "0x1809D4D60")]
		[CompilerGenerated]
		get
		{
			return default(IFDLBLOLFOD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1216CB0", Offset = "0x12156B0", VA = "0x181216CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool FHHPIADPNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1063650", Offset = "0x1062050", VA = "0x181063650")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6785740", Offset = "0x6784140", VA = "0x186785740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool HIEEJBKJNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x260A090", Offset = "0x2608A90", VA = "0x18260A090")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x78DADF0", Offset = "0x78D97F0", VA = "0x1878DADF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FJNPNMPMCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LNAJNJCEACL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x68A2BA0", Offset = "0x68A15A0", VA = "0x1868A2BA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x796CB10", Offset = "0x796B510", VA = "0x18796CB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int LIGNGKONFNM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x796CE60", Offset = "0x796B860", VA = "0x18796CE60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x796CF90", Offset = "0x796B990", VA = "0x18796CF90")]
	public BFKKPLGGCGN(FIDPILACLGN HNHMABPJIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x796CA10", Offset = "0x796B410", VA = "0x18796CA10")]
	private bool CIDGFBHJAKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x796CB20", Offset = "0x796B520", VA = "0x18796CB20", Slot = "4")]
	public bool HEHCILJMFIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x796CC70", Offset = "0x796B670", VA = "0x18796CC70")]
	private static FAFBMCHMADN IHELLFDADIK(FIDPILACLGN NKHEGOPIGCH)
	{
		return default(FAFBMCHMADN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x796CCB0", Offset = "0x796B6B0", VA = "0x18796CCB0", Slot = "5")]
	public bool IPDLKHCHONO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x796C910", Offset = "0x796B310", VA = "0x18796C910", Slot = "6")]
	public void CBCJJMKDJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "9")]
	public void Dispose()
	{
	}
}
namespace RecRoom.MCluster
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MClusterData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
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

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7973080", Offset = "0x7971A80", VA = "0x187973080", Slot = "0")]
		public override bool Equals(object OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7973280", Offset = "0x7971C80", VA = "0x187973280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB404F0", Offset = "0xB3EEF0", VA = "0x180B404F0")]
		public MClusterData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleRendererFeature(null)]
	public class MClusterRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly LMPJBEBLCLM log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private NMIFLGFNNND opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static NAKPOPOODAM CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7973A80", Offset = "0x7972480", VA = "0x187973A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7973AD0", Offset = "0x79724D0", VA = "0x187973AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7973360", Offset = "0x7971D60", VA = "0x187973360", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7973330", Offset = "0x7971D30", VA = "0x187973330", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IBNNGOPMLGG, RenderingData OMILIGDPMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7973830", Offset = "0x7972230", VA = "0x187973830")]
		public void OJEOGDEKION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x158A650", Offset = "0x1589050", VA = "0x18158A650")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HDNMCJMNDGH<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private MJFGBCFJDOJ MOKELDJEOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private MJFGBCFJDOJ IHELMPHFDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private ComputeBuffer ABBLMHCGDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private RenderTexture ABHAMNNKFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int JJJOEIDLLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int MKEBDHGODJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string DPHHIOMBMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private string PBFAPHKHCBJ;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9B6FC0", Offset = "0x9B59C0", VA = "0x1809B6FC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int DFOBLCKFOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9EE010", Offset = "0x9ECA10", VA = "0x1809EE010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int FPCNHLBCCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9CB660", Offset = "0x9CA060", VA = "0x1809CB660")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x49448F0", Offset = "0x49432F0", VA = "0x1849448F0")]
	public HDNMCJMNDGH(string EMLAIMJKHOE, int DCGANEPNBGE, [Optional] RenderTextureFormat? GKPIBGBGJLP, bool BCLPKKBPFBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4943420", Offset = "0x4941E20", VA = "0x184943420")]
	public void IPDLKHCHONO(CommandBuffer FLBFPNANBKH, NativeArray<ValType> DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4944120", Offset = "0x4942B20", VA = "0x184944120")]
	public void MNPNBGFPKBC(CommandBuffer FLBFPNANBKH, ComputeShader LAKFAJKBBFF, int BBHKAANBFKH, int JAPMAOLJCFD = -1, int MFGFLPBOPMK = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4943B00", Offset = "0x4942500", VA = "0x184943B00")]
	public void MNPNBGFPKBC(Material GMIALIBEKEC, int JAPMAOLJCFD = -1, int MFGFLPBOPMK = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4942B60", Offset = "0x4941560", VA = "0x184942B60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HAAJOOPBMJL
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNPNBGFPKBC(Material HNHMABPJIEN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JLDCPKMICBP<SrcEntry, DstEntry> : HAAJOOPBMJL, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected bool[] JOAGPFNCJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected MJFGBCFJDOJ NGBGIFINPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected MJFGBCFJDOJ MFDHAFDOPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<int> GKIFOBHDKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected NativeArray<SrcEntry> FBIBLIPLHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int PPGAOACHKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected int JLHPFHDGPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected HDNMCJMNDGH<int> FINODFOLLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected HDNMCJMNDGH<SrcEntry> PKHBBGKLOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected HDNMCJMNDGH<DstEntry> GEGDMMLKFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected ComputeShader HBFCOMOLOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int NAEEDFILNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int JMGBIABKMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int KMCLDDKGFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int OFAAMHEGMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int OMJKNMADCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int PPBNDFFDJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int MKGHFPDFABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int BNNNFJKCEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int HDFPEELJEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int LNNKCAJFPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int EKKCPNHMKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected int FGFGOCIBBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected string KFPHCBHAHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected float[] EJFJAPCBALE;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int AFGHANPJAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4D061F0", Offset = "0x4D04BF0", VA = "0x184D061F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string MCEJHMJPKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4D06FC0", Offset = "0x4D059C0", VA = "0x184D06FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4D08DC0", Offset = "0x4D077C0", VA = "0x184D08DC0")]
	public JLDCPKMICBP(string EMLAIMJKHOE, int HBKKJCCDGDH, int MJKNDGJGCIL, RenderTextureFormat GKPIBGBGJLP, ComputeShader JOKLHGPKHBJ, int IFPOAPDPHIH = 0, int OJJKNOOGLEN = 0, int IGFKEFAKKDH = 0, int GBAJNLFGLDM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4D06410", Offset = "0x4D04E10", VA = "0x184D06410")]
	public int ONMILIKJBEB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4D061A0", Offset = "0x4D04BA0", VA = "0x184D061A0")]
	protected void KNPPCLLJBNA(int DOAKEFBOPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4D05460", Offset = "0x4D03E60", VA = "0x184D05460")]
	public IFDLBLOLFOD HEHCILJMFIP(SrcEntry DFPGGEDGGGN)
	{
		return default(IFDLBLOLFOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4D05620", Offset = "0x4D04020", VA = "0x184D05620")]
	public bool IPDLKHCHONO(IFDLBLOLFOD ENNBIIMEOCP, SrcEntry DFPGGEDGGGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4D02EF0", Offset = "0x4D018F0", VA = "0x184D02EF0")]
	public bool CBCJJMKDJJC(IFDLBLOLFOD ENNBIIMEOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "6")]
	protected virtual void CFGKJNIDMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4D04430", Offset = "0x4D02E30", VA = "0x184D04430", Slot = "7")]
	public void EHFPEGECGGL(CommandBuffer FLBFPNANBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4D04800", Offset = "0x4D03200", VA = "0x184D04800", Slot = "8")]
	public void EHFPEGECGGL(CommandBuffer FLBFPNANBKH, ComputeShader JOKLHGPKHBJ, int IFPOAPDPHIH = -1, int OJJKNOOGLEN = -1, int IGFKEFAKKDH = -1, int GBAJNLFGLDM = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4D06200", Offset = "0x4D04C00", VA = "0x184D06200", Slot = "9")]
	public void MNPNBGFPKBC(CommandBuffer FLBFPNANBKH, ComputeShader JOKLHGPKHBJ, int IFPOAPDPHIH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4D063A0", Offset = "0x4D04DA0", VA = "0x184D063A0", Slot = "4")]
	public void MNPNBGFPKBC(Material GMIALIBEKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4D03470", Offset = "0x4D01E70", VA = "0x184D03470", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MJFGBCFJDOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong JGJAJBMEDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong FHDKIIJMPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OLHJCHCIDDK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct EHKOMEHLCPN : MJFGBCFJDOJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private IDisposable CPNFMFAECNK;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong JGJAJBMEDHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD0E7A0", Offset = "0xD0D1A0", VA = "0x180D0E7A0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7038870", Offset = "0x7037270", VA = "0x187038870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong FHDKIIJMPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xC8BC00", Offset = "0xC8A600", VA = "0x180C8BC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x796F880", Offset = "0x796E280", VA = "0x18796F880")]
		internal EHKOMEHLCPN(IDisposable JCACKCIFFFD, ulong BBFIPBOGKJN, ulong PCMICIICAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x796F800", Offset = "0x796E200", VA = "0x18796F800", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct AOBGGJNMCLC : MJFGBCFJDOJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private RenderTexture CAFFLIBCCFD;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong JGJAJBMEDHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xD0E7A0", Offset = "0xD0D1A0", VA = "0x180D0E7A0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7038870", Offset = "0x7037270", VA = "0x187038870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong FHDKIIJMPJM
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xC8BC00", Offset = "0xC8A600", VA = "0x180C8BC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x796C8E0", Offset = "0x796B2E0", VA = "0x18796C8E0")]
		public AOBGGJNMCLC(RenderTexture IACCMECBPKF, ulong HMDBCKDFPGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x796C840", Offset = "0x796B240", VA = "0x18796C840", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong FLNCJEGECJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x797B480", Offset = "0x7979E80", VA = "0x18797B480")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x797BCF0", Offset = "0x797A6F0", VA = "0x18797BCF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong CLNNONLIEOF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x797B4C0", Offset = "0x7979EC0", VA = "0x18797B4C0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x797B500", Offset = "0x7979F00", VA = "0x18797B500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x797BA10", Offset = "0x797A410", VA = "0x18797BA10")]
	public static ComputeBuffer IDEDHGEBOCJ(int PGJKBFGEJNK, int GAFILHJIHLI, ComputeBufferType OHCGINPDMEI, [Out] MJFGBCFJDOJ ENNBIIMEOCP, ComputeBufferMode NDELDEDNMOL = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x797B680", Offset = "0x797A080", VA = "0x18797B680")]
	public static RenderTexture IDEDHGEBOCJ(int BLEOEDKKBIM, int FGPAPCDJLPO, int GDLPGNMLHKP, RenderTextureFormat GKPIBGBGJLP, [Out] MJFGBCFJDOJ ENNBIIMEOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3821980", Offset = "0x3820380", VA = "0x183821980")]
	public static NativeArray<T> KOMAEMABMMA<T>(NativeArray<T> CPNFMFAECNK, ulong ENHEICOLGJO, [Out] MJFGBCFJDOJ ENNBIIMEOCP) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x38218C0", Offset = "0x38202C0", VA = "0x1838218C0")]
	public static NativeArray<T> IDEDHGEBOCJ<T>(int ENHEICOLGJO, Allocator DDBBFOCJEFL, [Out] MJFGBCFJDOJ ENNBIIMEOCP, NativeArrayOptions LPHHENIAGIG = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x797B540", Offset = "0x7979F40", VA = "0x18797B540")]
	public static void HEJCAAOAKNK(MJFGBCFJDOJ CPNFMFAECNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x797BBE0", Offset = "0x797A5E0", VA = "0x18797BBE0")]
	public static uint IHEMLGPBEOP(RenderTextureFormat GKPIBGBGJLP)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PNBNNNNDFIG : JLDCPKMICBP<DHJBKHMALCD, DHJBKHMALCD>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct ECIHMCGCCPI : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<int> LOFDFLADNEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[ReadOnly]
		private NativeArray<float> EHMHKFCPAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4x4> KKFJEPPMCGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[WriteOnly]
		private NativeArray<float4> OLEHNKHACPL;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x796F610", Offset = "0x796E010", VA = "0x18796F610")]
		public ECIHMCGCCPI(NativeArray<int> MBIGPCJDBED, NativeArray<float> KHGDHPBJHND, NativeArray<float4x4> NLMLMJGHJLN, NativeArray<float4> MFFAJCMKLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x796F450", Offset = "0x796DE50", VA = "0x18796F450", Slot = "4")]
		public void Execute(int DOAKEFBOPIA, TransformAccess GBIMAJCBFCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[BurstCompile]
	public struct OPNKBHPAEGF : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<int> LOFDFLADNEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4x4> FCEDBLLIHIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[ReadOnly]
		private NativeArray<float4> MJAHKNEGJJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[WriteOnly]
		private NativeArray<DHJBKHMALCD> PJKCDPJDKDE;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x796F610", Offset = "0x796E010", VA = "0x18796F610")]
		public OPNKBHPAEGF(NativeArray<int> MBIGPCJDBED, NativeArray<float4x4> CNFCDPOKFME, NativeArray<float4> MGLFCIJAHJD, NativeArray<DHJBKHMALCD> GNMBGILIMLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x797BD30", Offset = "0x797A730", VA = "0x18797BD30", Slot = "4")]
		public void Execute(int DOAKEFBOPIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private const byte EOHHOEGGENA = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private TransformAccessArray ONDLMNEGBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> DKPFANBBMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4x4> LPPLADPGMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> MAJFGAAGAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> KBELAAFMFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> CJAGMHCGADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private MJFGBCFJDOJ HBHFEOJMJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private MJFGBCFJDOJ MLOEBNGNCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private MJFGBCFJDOJ IPFNFILJPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private MJFGBCFJDOJ NELPNJHIPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private MJFGBCFJDOJ KJIEANAOKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private Transform JDANEBFHHLL;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x797C400", Offset = "0x797AE00", VA = "0x18797C400")]
	public PNBNNNNDFIG(int HBKKJCCDGDH, int MJKNDGJGCIL, ComputeShader JOKLHGPKHBJ, int IFPOAPDPHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x797BE80", Offset = "0x797A880", VA = "0x18797BE80", Slot = "6")]
	protected override void CFGKJNIDMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x797C090", Offset = "0x797AA90", VA = "0x18797C090")]
	private void DMIGIIJIEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x797C1F0", Offset = "0x797ABF0", VA = "0x18797C1F0")]
	public bool EIBPPDCBPJH(IFDLBLOLFOD ENNBIIMEOCP, Transform GBIMAJCBFCJ, float OHMGDMONIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x797BDA0", Offset = "0x797A7A0", VA = "0x18797BDA0")]
	public void ANEMLMENJNF(IFDLBLOLFOD ENNBIIMEOCP, float OHMGDMONIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x797C350", Offset = "0x797AD50", VA = "0x18797C350")]
	public void OAKEJGPNAEL(IFDLBLOLFOD ENNBIIMEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x797C150", Offset = "0x797AB50", VA = "0x18797C150", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface KJICOBOBPDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IMPFNPPINEK CALODJBLNBL();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface OHGEELOKPFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 CBLCAEOJCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int EFBCAMNNDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int KPJGFPJBEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> NHAANPHMDOL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> EHKFFBMDPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> KHKDIHGONCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> JAJGJDFPADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> NJKHCPKNHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> LFOOELCIBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int JEBKKANCAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int JAHBCGJNKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int IACDKNJFOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool PEABIHMGFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EHFPEGECGGL();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AILOHIIDJHN : OHGEELOKPFB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private KJICOBOBPDB IIMINHENILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IMPFNPPINEK LKDNKMEFADL;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 CBLCAEOJCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xEC09F0", Offset = "0xEBF3F0", VA = "0x180EC09F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xEC0AB0", Offset = "0xEBF4B0", VA = "0x180EC0AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool HJBOCGEOHEA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9AED70", Offset = "0x9AD770", VA = "0x1809AED70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int EFBCAMNNDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xC976B0", Offset = "0xC960B0", VA = "0x180C976B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xE7FEF0", Offset = "0xE7E8F0", VA = "0x180E7FEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int KPJGFPJBEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9B5540", Offset = "0x9B3F40", VA = "0x1809B5540", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9B5CA0", Offset = "0x9B46A0", VA = "0x1809B5CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int PDFEPCBJGON
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x12F29C0", Offset = "0x12F13C0", VA = "0x1812F29C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> NHAANPHMDOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x796C450", Offset = "0x796AE50", VA = "0x18796C450", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> EHKFFBMDPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x796C7A0", Offset = "0x796B1A0", VA = "0x18796C7A0", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> KHKDIHGONCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x796C760", Offset = "0x796B160", VA = "0x18796C760", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> JAJGJDFPADD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x796C6A0", Offset = "0x796B0A0", VA = "0x18796C6A0", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> NJKHCPKNHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x796C670", Offset = "0x796B070", VA = "0x18796C670", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> LFOOELCIBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x796C710", Offset = "0x796B110", VA = "0x18796C710", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool PEABIHMGFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF20", Offset = "0x9D9920", VA = "0x1809DAF20", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD40", Offset = "0x9D9740", VA = "0x1809DAD40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int JEBKKANCAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x796C790", Offset = "0x796B190", VA = "0x18796C790", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int JAHBCGJNKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x796C740", Offset = "0x796B140", VA = "0x18796C740", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int IACDKNJFOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x796C7D0", Offset = "0x796B1D0", VA = "0x18796C7D0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x796C7F0", Offset = "0x796B1F0", VA = "0x18796C7F0")]
	public AILOHIIDJHN(Hash128 ALFFJDGFOGF, KJICOBOBPDB IIMINHENILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x796C550", Offset = "0x796AF50", VA = "0x18796C550", Slot = "16")]
	public void EHFPEGECGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x796C4C0", Offset = "0x796AEC0", VA = "0x18796C4C0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct IFDLBLOLFOD : IEquatable<IFDLBLOLFOD>
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly IFDLBLOLFOD BOFAFIIEJCI;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int LIGNGKONFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
	public IFDLBLOLFOD(int DOAKEFBOPIA = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x79703D0", Offset = "0x796EDD0", VA = "0x1879703D0", Slot = "4")]
	public bool Equals(IFDLBLOLFOD OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7970300", Offset = "0x796ED00", VA = "0x187970300", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7970420", Offset = "0x796EE20", VA = "0x187970420", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CANAAPMHPFF : GJIBJBIFDMN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private bool MILJOPPDGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private OHGEELOKPFB MPNANNBOIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<IFDLBLOLFOD> PAHMBKLEOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<IFDLBLOLFOD> ACCKCGHLDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private List<IFDLBLOLFOD> JJGPNGIHJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Dictionary<int, uint> OJPGGPMLOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int OMPODOJBIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int MPHEBKPJJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int DKPBIIJADPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int CFANEICPPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int GHLPMGMFHMH;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int LIGNGKONFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x796E680", Offset = "0x796D080", VA = "0x18796E680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x796D920", Offset = "0x796C320", VA = "0x18796D920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool FHHPIADPNEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xBFFB90", Offset = "0xBFE590", VA = "0x180BFFB90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xBFF920", Offset = "0xBFE320", VA = "0x180BFF920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool HIEEJBKJNGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xBFFCE0", Offset = "0xBFE6E0", VA = "0x180BFFCE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC00780", Offset = "0xBFF180", VA = "0x180C00780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool FJNPNMPMCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool LNAJNJCEACL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5735C30", Offset = "0x5734630", VA = "0x185735C30", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x24E8450", Offset = "0x24E6E50", VA = "0x1824E8450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float HMIHOKAPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xE51820", Offset = "0xE50220", VA = "0x180E51820")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xE516F0", Offset = "0xE500F0", VA = "0x180E516F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x796EBF0", Offset = "0x796D5F0", VA = "0x18796EBF0")]
	public CANAAPMHPFF(OHGEELOKPFB LKDNKMEFADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x796E730", Offset = "0x796D130", VA = "0x18796E730")]
	private void NNFCNEMKIGD(OHGEELOKPFB LKDNKMEFADL, int OMPODOJBIJB, int ABNLHNILNFN, int DOAKEFBOPIA, int PGOIBCJEMLJ, PLLJIMBHIKB DFPGGEDGGGN, float AMMGCEGMEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x796E3C0", Offset = "0x796CDC0", VA = "0x18796E3C0")]
	private void JNDCOENOKDD(OHGEELOKPFB LKDNKMEFADL, int GHJILLAPDJG, int DOAKEFBOPIA, uint3 GPLEHPBBDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x796D680", Offset = "0x796C080", VA = "0x18796D680")]
	private bool CIDGFBHJAKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x796D960", Offset = "0x796C360", VA = "0x18796D960", Slot = "4")]
	public bool HEHCILJMFIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x796E340", Offset = "0x796CD40", VA = "0x18796E340", Slot = "5")]
	public bool IPDLKHCHONO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x796D030", Offset = "0x796BA30", VA = "0x18796D030", Slot = "6")]
	public void CBCJJMKDJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x796CFD0", Offset = "0x796B9D0", VA = "0x18796CFD0")]
	public void ABDEBOACHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x796CFD0", Offset = "0x796B9D0", VA = "0x18796CFD0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GJIBJBIFDMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool FJNPNMPMCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool LNAJNJCEACL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEHCILJMFIP();

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IPDLKHCHONO();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CBCJJMKDJJC();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IPNDBFAAPPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly float JPIPINMJPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, CANAAPMHPFF> KFKHICALJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Dictionary<Hash128, BFKKPLGGCGN> DBOOHHCIABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<GJIBJBIFDMN> MGKOKOMFJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<GJIBJBIFDMN> DAPDADOCHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Queue<GJIBJBIFDMN> CLECLMKMIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int PLBAMMGMDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private int AGBMNBPCGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private float EIEPAALNNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool LFPIKPANCLC;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool NDCGKJJJHMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x15AEFC0", Offset = "0x15AD9C0", VA = "0x1815AEFC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x15CE6B0", Offset = "0x15CD0B0", VA = "0x1815CE6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool GLHBPCLIAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x79710A0", Offset = "0x796FAA0", VA = "0x1879710A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string MCEJHMJPKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7971200", Offset = "0x796FC00", VA = "0x187971200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x79711F0", Offset = "0x796FBF0", VA = "0x1879711F0")]
	public void NMDIBHJKKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7971170", Offset = "0x796FB70", VA = "0x187971170")]
	public void KMOJOBBOPBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x79715E0", Offset = "0x796FFE0", VA = "0x1879715E0")]
	public IPNDBFAAPPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x79704B0", Offset = "0x796EEB0", VA = "0x1879704B0")]
	public KJLIMKEBJFB BLLBFFICICF(AFKEJKMHAMM FPJBBOHNMAA, bool CJPDIKKAMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x79708D0", Offset = "0x796F2D0", VA = "0x1879708D0")]
	public BFKKPLGGCGN BLLBFFICICF(FIDPILACLGN GMIALIBEKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7971180", Offset = "0x796FB80", VA = "0x187971180")]
	public bool MJIJKGGILDH(Hash128 ICHIIHCEGJD, [Out] CANAAPMHPFF NIGELLOAGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x79705E0", Offset = "0x796EFE0", VA = "0x1879705E0")]
	public CANAAPMHPFF BLLBFFICICF(OHGEELOKPFB LKDNKMEFADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7970AC0", Offset = "0x796F4C0", VA = "0x187970AC0")]
	private void DEPGEDJLDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x79710F0", Offset = "0x796FAF0", VA = "0x1879710F0")]
	private bool JCBBCPEHLDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7970BF0", Offset = "0x796F5F0", VA = "0x187970BF0")]
	public void EHFPEGECGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7970AE0", Offset = "0x796F4E0", VA = "0x187970AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7970A10", Offset = "0x796F410", VA = "0x187970A10")]
	public void CMKPBKOPCPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ACCPHMPAIGA : JLDCPKMICBP<KDBJBHDCDEK, KDBJBHDCDEK>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x796C3A0", Offset = "0x796ADA0", VA = "0x18796C3A0")]
	public ACCPHMPAIGA(int HBKKJCCDGDH, int MJKNDGJGCIL, ComputeShader JOKLHGPKHBJ, int IFPOAPDPHIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class JGOPKDPKNMO : JLDCPKMICBP<FAFBMCHMADN, FAFBMCHMADN>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x79717A0", Offset = "0x79701A0", VA = "0x1879717A0")]
	public JGOPKDPKNMO(int HBKKJCCDGDH, int MJKNDGJGCIL, ComputeShader JOKLHGPKHBJ, int IFPOAPDPHIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DFGAHOFKIOE : JLDCPKMICBP<DHDHNGOOBHO, DHDHNGOOBHO>
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x796ED60", Offset = "0x796D760", VA = "0x18796ED60")]
	public DFGAHOFKIOE(int HBKKJCCDGDH, int MJKNDGJGCIL, ComputeShader JOKLHGPKHBJ, int IFPOAPDPHIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KIMFCADFHLM : JLDCPKMICBP<OADIFILEGBE, ONJMPNIOLIE>
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7971C20", Offset = "0x7970620", VA = "0x187971C20")]
	public KIMFCADFHLM(int HBKKJCCDGDH, int MJKNDGJGCIL, ComputeShader JOKLHGPKHBJ, int IFPOAPDPHIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GENFJDMMODA : JLDCPKMICBP<DGKJEAECCGF, DGKJEAECCGF>
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x796FAB0", Offset = "0x796E4B0", VA = "0x18796FAB0")]
	public GENFJDMMODA(int HBKKJCCDGDH, int MJKNDGJGCIL, ComputeShader JOKLHGPKHBJ, int IFPOAPDPHIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class NMIFLGFNNND : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private NAKPOPOODAM HNGOIGFDGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool PLGFLNLCLML;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static bool JNBLFONPEFJ;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x797B440", Offset = "0x7979E40", VA = "0x18797B440")]
	public NMIFLGFNNND(NAKPOPOODAM LOLJFJMGHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x797B2B0", Offset = "0x7979CB0", VA = "0x18797B2B0", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer FLBFPNANBKH, RenderingData OMILIGDPMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x797B040", Offset = "0x7979A40", VA = "0x18797B040", Slot = "6")]
	public override void Configure(CommandBuffer FLBFPNANBKH, RenderTextureDescriptor LEHBNMPADLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x797B080", Offset = "0x7979A80", VA = "0x18797B080", Slot = "9")]
	public override void Execute(ScriptableRenderContext OJFCDDMGKNP, RenderingData OMILIGDPMMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class NEGGOJOCLKH
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public readonly struct EEBDNGDAEEJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly string EMLAIMJKHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CommandBuffer FLBFPNANBKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly ScriptableRenderContext OJFCDDMGKNP;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x796F6F0", Offset = "0x796E0F0", VA = "0x18796F6F0")]
		public EEBDNGDAEEJ(string DKBCCMGIMGN, ScriptableRenderContext AKODLLLICJE, [Out] CommandBuffer KOBAJIGGFFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x796F640", Offset = "0x796E040", VA = "0x18796F640", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x797AAC0", Offset = "0x79794C0", VA = "0x18797AAC0")]
	public static bool GPOEKAMLNKL(RenderingData OMILIGDPMMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x797AC10", Offset = "0x7979610", VA = "0x18797AC10")]
	public static void MAGHICMJDEO(CommandBuffer FLBFPNANBKH, ScriptableRenderContext OJFCDDMGKNP, ShadowDrawingSettings DMPGLFJEEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x797ADE0", Offset = "0x79797E0", VA = "0x18797ADE0")]
	public static void OBKCAGDBFMC(CommandBuffer FLBFPNANBKH, ScriptableRenderContext OJFCDDMGKNP, RenderingData OMILIGDPMMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NAKPOPOODAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class NEAHCDGHPHF
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int HMJOFKAMEBJ;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public static readonly int JOKMLGGIKBF;
	}

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static HDNMCJMNDGH<HMAADKIBNNH> HIDALBMBJJE;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static HDNMCJMNDGH<uint> HBOLFGNNKPH;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static MJFGBCFJDOJ LOGJAJFGPMO;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static ComputeBuffer CHFONPOKMHH;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static List<HAAJOOPBMJL> ECKHBPPJEPO;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int LECMHOKIEBA;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int BBEGKCFPKJJ;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int BFHANPOIJGO;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int MBNOPNIFJAG;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static int[] LMPKCPMMLGO;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static Material[] IGKMNNGLHHK;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static DEPFMFAIADF[][] FGDPMAOILPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Plane[] CNLMLAAJFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int DPOBMFJOJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int INPGEEGAGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int DPHHMEECKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int DKJKCEOOGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int EHJFFDILOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int GMDNDEJAIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int GLAFLCMNAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int PMMPHKOHLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int HHEFINAEBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int JKKNBLOKFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int FNBMBLCOBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int JOPHFGHNBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int CBDHPLJDJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int HNINKOGHNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int BJAHADKABEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int ODBLNGCAMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int JDKDCJJFEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int CNBIMMJIENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private float[] IEGOMDCDKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private IPNDBFAAPPC IKGLKCJMCEH;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool NCPNMKJFBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7978BC0", Offset = "0x79775C0", VA = "0x187978BC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7978940", Offset = "0x7977340", VA = "0x187978940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool OHPDBLOCGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7978C10", Offset = "0x7977610", VA = "0x187978C10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7976AE0", Offset = "0x79754E0", VA = "0x187976AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData LPLAAGCJFBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7974160", Offset = "0x7972B60", VA = "0x187974160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7975400", Offset = "0x7973E00", VA = "0x187975400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static PNBNNNNDFIG ANOJNELFLEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7974200", Offset = "0x7972C00", VA = "0x187974200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7979860", Offset = "0x7978260", VA = "0x187979860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static ACCPHMPAIGA MPPHOOJOPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x797A700", Offset = "0x7979100", VA = "0x18797A700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7976BA0", Offset = "0x79755A0", VA = "0x187976BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static JGOPKDPKNMO OHACLKDJKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7975550", Offset = "0x7973F50", VA = "0x187975550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7975470", Offset = "0x7973E70", VA = "0x187975470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static DFGAHOFKIOE DHOGIBIIKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7976C10", Offset = "0x7975610", VA = "0x187976C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7979970", Offset = "0x7978370", VA = "0x187979970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static KIMFCADFHLM OENBDBACNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7976CD0", Offset = "0x79756D0", VA = "0x187976CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x79754E0", Offset = "0x7973EE0", VA = "0x1879754E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static GENFJDMMODA GODDNHJOABF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7978B70", Offset = "0x7977570", VA = "0x187978B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7977960", Offset = "0x7976360", VA = "0x187977960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material COBIGKDAALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x79779D0", Offset = "0x79763D0", VA = "0x1879779D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7973C80", Offset = "0x7972680", VA = "0x187973C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material DDPELLFBCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7975700", Offset = "0x7974100", VA = "0x187975700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7975750", Offset = "0x7974150", VA = "0x187975750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material PFGBCIFLMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7978CD0", Offset = "0x79776D0", VA = "0x187978CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7978C60", Offset = "0x7977660", VA = "0x187978C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material NFNOHAECBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x79756B0", Offset = "0x79740B0", VA = "0x1879756B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7979240", Offset = "0x7977C40", VA = "0x187979240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool DADPCIMGPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x79799E0", Offset = "0x79783E0", VA = "0x1879799E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7973C20", Offset = "0x7972620", VA = "0x187973C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool GLHBPCLIAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7976B40", Offset = "0x7975540", VA = "0x187976B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string MCEJHMJPKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x797A050", Offset = "0x7978A50", VA = "0x18797A050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x797A7E0", Offset = "0x79791E0", VA = "0x18797A7E0")]
	internal NAKPOPOODAM([Optional] MClusterData GPABOLKJBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x79757C0", Offset = "0x79741C0", VA = "0x1879757C0")]
	public void ELAEPFFNBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x79791A0", Offset = "0x7977BA0", VA = "0x1879791A0")]
	public void MEPJBMOAPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7978930", Offset = "0x7977330", VA = "0x187978930")]
	public void IMAIIHCIHAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x79798D0", Offset = "0x79782D0", VA = "0x1879798D0")]
	public bool NBHCMJHANGI(Hash128 ALFFJDGFOGF, [Out] CANAAPMHPFF LKDNKMEFADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7973CF0", Offset = "0x79726F0", VA = "0x187973CF0")]
	public CANAAPMHPFF BLLBFFICICF(OHGEELOKPFB DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7973F70", Offset = "0x7972970", VA = "0x187973F70")]
	public BFKKPLGGCGN BLLBFFICICF(FIDPILACLGN GMIALIBEKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7973DB0", Offset = "0x79727B0", VA = "0x187973DB0")]
	public KJLIMKEBJFB BLLBFFICICF(AFKEJKMHAMM FPJBBOHNMAA, bool CJPDIKKAMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x79741B0", Offset = "0x7972BB0", VA = "0x1879741B0")]
	public void CBCJJMKDJJC(GJIBJBIFDMN GAICPBMAOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7973B40", Offset = "0x7972540", VA = "0x187973B40")]
	public static void AOBGKFIONBH(KBICMIJMCPA HKKKDLOOHLD, DEPFMFAIADF[] DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7974820", Offset = "0x7973220", VA = "0x187974820")]
	private void DACEIFCOHPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7976D20", Offset = "0x7975720", VA = "0x187976D20")]
	private static void FPJFLKPBNJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x79750F0", Offset = "0x7973AF0", VA = "0x1879750F0")]
	public void DBBOFGGFMPL(CommandBuffer FLBFPNANBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x79789A0", Offset = "0x79773A0", VA = "0x1879789A0")]
	public void JLIBICNBJHM([Optional] ScriptableRenderContext? OJFCDDMGKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7979590", Offset = "0x7977F90", VA = "0x187979590")]
	public void MILOACJOEDG(CommandBuffer FLBFPNANBKH, ShadowSplitData PGKHKKOKAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x79792B0", Offset = "0x7977CB0", VA = "0x1879792B0")]
	public void MILOACJOEDG(CommandBuffer FLBFPNANBKH, CameraData EBDPKOPEFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7979A30", Offset = "0x7978430", VA = "0x187979A30")]
	public void OFKAAJLKCAI(CommandBuffer FLBFPNANBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7976C60", Offset = "0x7975660", VA = "0x187976C60")]
	public void FMKMBKGOLOO(CommandBuffer FLBFPNANBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7978D20", Offset = "0x7977720", VA = "0x187978D20")]
	public void LPPHLCOJPPM(CommandBuffer FLBFPNANBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7974250", Offset = "0x7972C50", VA = "0x187974250")]
	public void CJJKFNCGKGC(CommandBuffer FLBFPNANBKH, KBICMIJMCPA EMMOECMMAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7979F70", Offset = "0x7978970", VA = "0x187979F70")]
	public void OJEOGDEKION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7977A20", Offset = "0x7976420", VA = "0x187977A20")]
	public void HEJCAAOAKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x79755A0", Offset = "0x7973FA0", VA = "0x1879755A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JHBLOJOGBNB
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x25F81D0", Offset = "0x25F6BD0", VA = "0x1825F81D0")]
	public static int NKNLNJPDDAB(int LGMJDKKAMNE, int JFDOJFJACPO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct DHJBKHMALCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4x4 PLGMEAFGOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float4 MDCJPBAGLAG;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly DHJBKHMALCD CIMAAKBCEHD;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly DHJBKHMALCD BOFAFIIEJCI;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x796F420", Offset = "0x796DE20", VA = "0x18796F420")]
	public DHJBKHMALCD(float4x4 IGCEJLBJNGI, float4 KECBCMDAKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x796F2C0", Offset = "0x796DCC0", VA = "0x18796F2C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct PLLJIMBHIKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 KKIJMCHODGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 MDIKGGEOGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 FGINBKCNIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 JBPOAMCPMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 GFBIMCGGHKH;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct NPPKADBNPKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public float4 KKIJMCHODGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 MDIKGGEOGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 FGINBKCNIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 JBPOAMCPMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public half4 GFBIMCGGHKH;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct ONJMPNIOLIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public NPPKADBNPKF IJMCJKLAFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public NPPKADBNPKF HHFFCFNLOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public NPPKADBNPKF GBJELDHHCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public NPPKADBNPKF POMOKMPFAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public NPPKADBNPKF KDNIJILJLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public NPPKADBNPKF JOMLAPMBABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public NPPKADBNPKF HONDHIPMAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public NPPKADBNPKF PHEKBNCGKPD;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct OADIFILEGBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public PLLJIMBHIKB IJMCJKLAFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public PLLJIMBHIKB HHFFCFNLOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public PLLJIMBHIKB GBJELDHHCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public PLLJIMBHIKB POMOKMPFAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public PLLJIMBHIKB KDNIJILJLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public PLLJIMBHIKB JOMLAPMBABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public PLLJIMBHIKB HONDHIPMAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public PLLJIMBHIKB PHEKBNCGKPD;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FAFBMCHMADN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float4 DANMIMGGCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint PHAOADFJMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public uint DIMNPBKLDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public float PIDKIAJJFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint GNPIADOJFLM;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x796F8C0", Offset = "0x796E2C0", VA = "0x18796F8C0")]
	public FAFBMCHMADN(FIDPILACLGN GMIALIBEKEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct HMAADKIBNNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint MMEFECNELCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint KMPBGHBMGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint PGOIBCJEMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint GNPIADOJFLM;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7970250", Offset = "0x796EC50", VA = "0x187970250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct DHDHNGOOBHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint ABNLHNILNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint CKPJAPOAAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint MPHEBKPJJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint GNPIADOJFLM;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x796F210", Offset = "0x796DC10", VA = "0x18796F210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct KDBJBHDCDEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint HLLMOPBLAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint NFMKFBCGECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint AOIMGENCDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint DEFKPIOIMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint HGMDJIAMJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint KPKNBJMAJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint CEOLLHJHBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint GNPIADOJFLM;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x79718F0", Offset = "0x79702F0", VA = "0x1879718F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct DGKJEAECCGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 GIHPIGHDPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 NONPOFGBBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 LFCLJAFOJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 BHLJHGEPKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 OHKMPDILHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 CGLENDAMMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 EDKMBMOPEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public uint3 DBAOJGIJNGP;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x796EE10", Offset = "0x796D810", VA = "0x18796EE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum KBICMIJMCPA
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Opaque,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	DepthOnly,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Transparent,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
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
