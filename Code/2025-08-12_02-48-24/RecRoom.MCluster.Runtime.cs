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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84D6160", Offset = "0x84D4760", VA = "0x1884D6160", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct GCOKGMKBGKD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] COEMGABKLHG;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] PIPCGPNDMMG;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] GFIGFAPKPFP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x217FD40", Offset = "0x217E340", VA = "0x18217FD40")]
	public static int NALAFBKJEAC(NHAPIDOPIJE CGCOAIEEKKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x84D35E0", Offset = "0x84D1BE0", VA = "0x1884D35E0")]
	public static int ENPJJLEMGPI(NHAPIDOPIJE CGCOAIEEKKE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DNJHNKFPKBM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int GCGHNNMHFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NHFEFALFGMD FIBJHKEMEHO(int EEPEOPEEIMF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 FIHPIGMFPJJ(int EEPEOPEEIMF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HGOECGDMDII DPJMNCKNNHF();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	APGLOIBBEMN NNAJOJAAOLD();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EOBJAEIIOPA : DLDKAFAAEFE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private HGOECGDMDII JAHKFPBBGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform EBCCPGHKLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<FGKAKNMKDGK> ICAJHGONKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private CIPPCHELKAJ HPFBOLBPFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private GJLFNJJFKBD PANLIKOBAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool DBHLNGGNPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private DNJHNKFPKBM LEOCGJJIHLB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float BHPCFKHCDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAE9940", Offset = "0xAE7F40", VA = "0x180AE9940")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD5D940", Offset = "0xD5BF40", VA = "0x180D5D940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IKMNHDGIIAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD946A0", Offset = "0xD92CA0", VA = "0x180D946A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xE83B20", Offset = "0xE82120", VA = "0x180E83B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool HEGFMFLMOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xF0E330", Offset = "0xF0C930", VA = "0x180F0E330")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xF0DFC0", Offset = "0xF0C5C0", VA = "0x180F0DFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MBMNEAKACJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2193CD0", Offset = "0x21922D0", VA = "0x182193CD0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2193980", Offset = "0x2191F80", VA = "0x182193980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool HCDLCNFALOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x229A190", Offset = "0x2298790", VA = "0x18229A190", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84D1770", Offset = "0x84CFD70", VA = "0x1884D1770")]
	public EOBJAEIIOPA(DNJHNKFPKBM AFDLHEFMFJN, bool ANGPAFEFBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x84D04F0", Offset = "0x84CEAF0", VA = "0x1884D04F0")]
	private bool ENBDCNOGIPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84D0B10", Offset = "0x84CF110", VA = "0x1884D0B10", Slot = "4")]
	public bool KMLBEHGKDFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84D0710", Offset = "0x84CED10", VA = "0x1884D0710", Slot = "5")]
	public bool FLHPFKIPOFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84D08E0", Offset = "0x84CEEE0", VA = "0x1884D08E0", Slot = "6")]
	public void HCDNAOEAAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84D04E0", Offset = "0x84CEAE0", VA = "0x1884D04E0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PJLMPLIFONM
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PGGBFFEHFNL(CommandBuffer PCKGIGGFIHN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct JBLLDGPMHGF : PJLMPLIFONM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier AAAGBJBCHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5672980", Offset = "0x5670F80", VA = "0x185672980")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84D43B0", Offset = "0x84D29B0", VA = "0x1884D43B0")]
	public JBLLDGPMHGF(int JIEJOKBHEMF, RenderTargetIdentifier DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84D4360", Offset = "0x84D2960", VA = "0x1884D4360", Slot = "4")]
	public void PGGBFFEHFNL(CommandBuffer PCKGIGGFIHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct NIIOFIAOFGB : PJLMPLIFONM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] IHGJKEGDHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB41580", Offset = "0xB3FB80", VA = "0x180B41580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1953810", Offset = "0x1951E10", VA = "0x181953810")]
	public NIIOFIAOFGB(int JIEJOKBHEMF, Vector4[] DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x84D6EA0", Offset = "0x84D54A0", VA = "0x1884D6EA0", Slot = "4")]
	public void PGGBFFEHFNL(CommandBuffer PCKGIGGFIHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct FINMOCDPDEB : PJLMPLIFONM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int AFPIOPNCMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] JAFDJAJMAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xB41580", Offset = "0xB3FB80", VA = "0x180B41580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1953810", Offset = "0x1951E10", VA = "0x181953810")]
	public FINMOCDPDEB(int JIEJOKBHEMF, float[] DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84D35B0", Offset = "0x84D1BB0", VA = "0x1884D35B0", Slot = "4")]
	public void PGGBFFEHFNL(CommandBuffer PCKGIGGFIHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GHAAACMEIGF : PJLMPLIFONM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool NEHLGHEFIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xEB2940", Offset = "0xEB0F40", VA = "0x180EB2940")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1AB9730", Offset = "0x1AB7D30", VA = "0x181AB9730")]
	public GHAAACMEIGF(string DJFMCHMDHGK, bool ANBCINBEIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84D3CD0", Offset = "0x84D22D0", VA = "0x1884D3CD0", Slot = "4")]
	public void PGGBFFEHFNL(CommandBuffer PCKGIGGFIHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct APGLOIBBEMN
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 HNNOIPHAHBO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 CBBIGFHPPAM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KDKCCBDFCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int ELMMBJCMHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float CDBEBHLADGG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x109BE00", Offset = "0x109A400", VA = "0x18109BE00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84C72E0", Offset = "0x84C58E0", VA = "0x1884C72E0")]
	public APGLOIBBEMN(Color ONDGBPEOGJF, int LMJBCALGIJO, int IIBBPLOLFMF, float IFHBMGPCEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x13218D0", Offset = "0x131FED0", VA = "0x1813218D0")]
	private static float4 FKLPIMMBFAA(Color ONDGBPEOGJF)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84C7250", Offset = "0x84C5850", VA = "0x1884C7250")]
	private static Hash128 FABNCDBPHNM(APGLOIBBEMN AFDLHEFMFJN)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CIPPCHELKAJ : DLDKAFAAEFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string OJHDBHONNFC;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string GJNJLBCCEDE;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string PANDJBHEMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private APGLOIBBEMN KNAPOOEBEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private OFNKHPFGEHH JKDFAJLFBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 PEHDJLJCFFE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public GJLFNJJFKBD KJMJJPOMDKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xABCF40", Offset = "0xABB540", VA = "0x180ABCF40")]
		[CompilerGenerated]
		get
		{
			return default(GJLFNJJFKBD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x15C6170", Offset = "0x15C4770", VA = "0x1815C6170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool IKMNHDGIIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x130D180", Offset = "0x130B780", VA = "0x18130D180")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1A29E60", Offset = "0x1A28460", VA = "0x181A29E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool HEGFMFLMOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x130D1B0", Offset = "0x130B7B0", VA = "0x18130D1B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8433120", Offset = "0x8431720", VA = "0x188433120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HCDLCNFALOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MBMNEAKACJL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x130D1C0", Offset = "0x130B7C0", VA = "0x18130D1C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84C8DF0", Offset = "0x84C73F0", VA = "0x1884C8DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int LBGMECNKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x84C8F50", Offset = "0x84C7550", VA = "0x1884C8F50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84C9090", Offset = "0x84C7690", VA = "0x1884C9090")]
	public CIPPCHELKAJ(APGLOIBBEMN ONMGGJNFMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x84C89E0", Offset = "0x84C6FE0", VA = "0x1884C89E0")]
	private bool ENBDCNOGIPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x84C8E00", Offset = "0x84C7400", VA = "0x1884C8E00", Slot = "4")]
	public bool KMLBEHGKDFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x84C8DB0", Offset = "0x84C73B0", VA = "0x1884C8DB0")]
	private static OFNKHPFGEHH IOOPNCBDAFN(APGLOIBBEMN AFDLHEFMFJN)
	{
		return default(OFNKHPFGEHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x84C8AF0", Offset = "0x84C70F0", VA = "0x1884C8AF0", Slot = "5")]
	public bool FLHPFKIPOFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x84C8CA0", Offset = "0x84C72A0", VA = "0x1884C8CA0", Slot = "6")]
	public void HCDNAOEAAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84D61F0", Offset = "0x84D47F0", VA = "0x1884D61F0", Slot = "0")]
		public override bool Equals(object IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84D63F0", Offset = "0x84D49F0", VA = "0x1884D63F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD461A0", Offset = "0xD447A0", VA = "0x180D461A0")]
		public MClusterData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleRendererFeature(null)]
	public class MClusterRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private OMFOABLCIEK opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static DCNNFCDFCMK CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x84D6C20", Offset = "0x84D5220", VA = "0x1884D6C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x84D6C70", Offset = "0x84D5270", VA = "0x1884D6C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84D64D0", Offset = "0x84D4AD0", VA = "0x1884D64D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84D64A0", Offset = "0x84D4AA0", VA = "0x1884D64A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PHHDHBAFNEH, RenderingData FMGGMKFBAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84D69C0", Offset = "0x84D4FC0", VA = "0x1884D69C0")]
		public void DPMLAIGJMOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x195CEB0", Offset = "0x195B4B0", VA = "0x18195CEB0")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NHMFHDFPMFF<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private HDCLLOBMLBC BMHNPHMHGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private HDCLLOBMLBC DHEIDKGMIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private ComputeBuffer KBNFGKPOMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private RenderTexture LPMGKMFPPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int CNFELGCEMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int FPLFGNJMIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string OKGCJONDEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private string FJOKFBEOANF;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F10", Offset = "0xAA0510", VA = "0x180AA1F10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int GGAECDINHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xAD6F80", Offset = "0xAD5580", VA = "0x180AD6F80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int LLELEPFNHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x59E7540", Offset = "0x59E5B40", VA = "0x1859E7540")]
	public NHMFHDFPMFF(string DJFMCHMDHGK, int POCOHPAOLFN, [Optional] RenderTextureFormat? IENFMLICFPK, bool HEAGEPICICN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x59E6F00", Offset = "0x59E5500", VA = "0x1859E6F00")]
	public void FLHPFKIPOFF(CommandBuffer PCKGIGGFIHN, NativeArray<ValType> DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x59E7230", Offset = "0x59E5830", VA = "0x1859E7230")]
	public void KIPLJGOJDFG(CommandBuffer PCKGIGGFIHN, ComputeShader GLMOBGHBHHP, int MGFPMIOGOGN, int EKEMDBLGHFH = -1, int IECHBBBBGBJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x59E73A0", Offset = "0x59E59A0", VA = "0x1859E73A0")]
	public void KIPLJGOJDFG(Material JKDFAJLFBEL, int EKEMDBLGHFH = -1, int IECHBBBBGBJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x59E6D60", Offset = "0x59E5360", VA = "0x1859E6D60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HDJJOPEAIJO
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIPLJGOJDFG(Material ONMGGJNFMFI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DAFPEKCBNOH<SrcEntry, DstEntry> : HDJJOPEAIJO, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected bool[] GDNFFFPIPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected HDCLLOBMLBC FAIALJHCHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected HDCLLOBMLBC NIDBAEFDJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<int> HKKOOAAACMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected NativeArray<SrcEntry> MEEOFLGAHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int LMNPFAPNEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected int LNBCCLANMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected NHMFHDFPMFF<int> KJCKKNLBLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected NHMFHDFPMFF<SrcEntry> ECGKBKAMACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected NHMFHDFPMFF<DstEntry> LCOHGPDENDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected ComputeShader LHNIEBGOMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int LHCNDMCGFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int KKMELGOHAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int IPDKNPJBLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int LJBIACEGHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int FABGCPJMEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int OMEPKIGPIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int EPPDLFBAMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int GJGKNBNJNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int MNGCKELBDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int LKCMGGPLHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int PIINNGPLFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected int HIDGLPHIKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected string DLEGOMEHOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected float[] MBMIIBJLKLH;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int KEINBJHGLKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4580710", Offset = "0x457ED10", VA = "0x184580710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string BCEFDONFGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x457ED60", Offset = "0x457D360", VA = "0x18457ED60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4582170", Offset = "0x4580770", VA = "0x184582170")]
	public DAFPEKCBNOH(string DJFMCHMDHGK, int MICCKHBPFLG, int LNOKAEEMCOM, RenderTextureFormat IENFMLICFPK, ComputeShader IHMPIMNLCPH, int JGOLOCNMOID = 0, int BMEFINALFLC = 0, int IPCKENEODKD = 0, int CGPKCCPHBLJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4580720", Offset = "0x457ED20", VA = "0x184580720")]
	public int KBJCFEBCFEB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4581310", Offset = "0x457F910", VA = "0x184581310")]
	protected void OOBHJPGPNDI(int LEPAEEGOBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4580950", Offset = "0x457EF50", VA = "0x184580950")]
	public GJLFNJJFKBD KMLBEHGKDFG(SrcEntry DAJAOHIJHHL)
	{
		return default(GJLFNJJFKBD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x457FD10", Offset = "0x457E310", VA = "0x18457FD10")]
	public bool FLHPFKIPOFF(GJLFNJJFKBD IINGFCBPPPE, SrcEntry DAJAOHIJHHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4580610", Offset = "0x457EC10", VA = "0x184580610")]
	public bool HCDNAOEAAEJ(GJLFNJJFKBD IINGFCBPPPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "6")]
	protected virtual void AHFKAAGEEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x457D690", Offset = "0x457BC90", VA = "0x18457D690", Slot = "7")]
	public void CHNAFCJOMPA(CommandBuffer PCKGIGGFIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x457D6E0", Offset = "0x457BCE0", VA = "0x18457D6E0", Slot = "8")]
	public void CHNAFCJOMPA(CommandBuffer PCKGIGGFIHN, ComputeShader IHMPIMNLCPH, int JGOLOCNMOID = -1, int BMEFINALFLC = -1, int IPCKENEODKD = -1, int CGPKCCPHBLJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4580790", Offset = "0x457ED90", VA = "0x184580790", Slot = "9")]
	public void KIPLJGOJDFG(CommandBuffer PCKGIGGFIHN, ComputeShader IHMPIMNLCPH, int JGOLOCNMOID = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4580900", Offset = "0x457EF00", VA = "0x184580900", Slot = "4")]
	public void KIPLJGOJDFG(Material JKDFAJLFBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x457E320", Offset = "0x457C920", VA = "0x18457E320", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HDCLLOBMLBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong NKHKBKMPCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong MJFHIODJFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BHMEBMOJDAI
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct PODCDEPLACA : HDCLLOBMLBC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private IDisposable JLOKLPELFOB;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong NKHKBKMPCJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB41580", Offset = "0xB3FB80", VA = "0x180B41580", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2D0BB00", Offset = "0x2D0A100", VA = "0x182D0BB00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong MJFHIODJFHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x84D7630", Offset = "0x84D5C30", VA = "0x1884D7630")]
		internal PODCDEPLACA(IDisposable IGNLDIGBHPJ, ulong ANKFLICEBPE, ulong NEDNJFIENCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x84D75B0", Offset = "0x84D5BB0", VA = "0x1884D75B0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct CMAKLMKCOIO : HDCLLOBMLBC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private RenderTexture DKNKGNNPDCJ;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong NKHKBKMPCJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xB41580", Offset = "0xB3FB80", VA = "0x180B41580", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2D0BB00", Offset = "0x2D0A100", VA = "0x182D0BB00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong MJFHIODJFHP
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x84C9170", Offset = "0x84C7770", VA = "0x1884C9170")]
		public CMAKLMKCOIO(RenderTexture BHNOPLHICEP, ulong MDPMOJKMLMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x84C90D0", Offset = "0x84C76D0", VA = "0x1884C90D0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong GANCBHLIIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84C7D50", Offset = "0x84C6350", VA = "0x1884C7D50")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x84C7D10", Offset = "0x84C6310", VA = "0x1884C7D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong AADDPLACKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x84C7CD0", Offset = "0x84C62D0", VA = "0x1884C7CD0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x84C7ED0", Offset = "0x84C64D0", VA = "0x1884C7ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84C7B00", Offset = "0x84C6100", VA = "0x1884C7B00")]
	public static ComputeBuffer EEPJBIPIECL(int FEEKNNBMJMM, int NJJHEOMKNBA, ComputeBufferType EHLAHNIAPLD, [Out] HDCLLOBMLBC IINGFCBPPPE, ComputeBufferMode JDJJDFOGKAI = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x84C7760", Offset = "0x84C5D60", VA = "0x1884C7760")]
	public static RenderTexture EEPJBIPIECL(int PDKDGENFDGI, int JCJCKGHEDMK, int MFNAMKGMHBE, RenderTextureFormat IENFMLICFPK, [Out] HDCLLOBMLBC IINGFCBPPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3B20D40", Offset = "0x3B1F340", VA = "0x183B20D40")]
	public static NativeArray<T> KOMHBIMFBOP<T>(NativeArray<T> JLOKLPELFOB, ulong FODNOPLPBPI, [Out] HDCLLOBMLBC IINGFCBPPPE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3B20CA0", Offset = "0x3B1F2A0", VA = "0x183B20CA0")]
	public static NativeArray<T> EEPJBIPIECL<T>(int FODNOPLPBPI, Allocator EKNOCGFFMAE, [Out] HDCLLOBMLBC IINGFCBPPPE, NativeArrayOptions EEPOAHLOJPI = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84C7D90", Offset = "0x84C6390", VA = "0x1884C7D90")]
	public static void LOMEBHIDOPA(HDCLLOBMLBC JLOKLPELFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84C7F10", Offset = "0x84C6510", VA = "0x1884C7F10")]
	public static uint PODGLNAKKLL(RenderTextureFormat IENFMLICFPK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KAGNLPLLPHK : DAFPEKCBNOH<BOAICCOEHKN, BOAICCOEHKN>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct MLLICBJPEPG : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<int> EOIEDADDKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[ReadOnly]
		private NativeArray<float> FJIPOHIMEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4x4> JCBCAJMOKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[WriteOnly]
		private NativeArray<float4> NJJDJHAFGAG;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x84C9210", Offset = "0x84C7810", VA = "0x1884C9210")]
		public MLLICBJPEPG(NativeArray<int> BALLDEMAJMI, NativeArray<float> LFODNCHHEAH, NativeArray<float4x4> MFKIJAKHNIK, NativeArray<float4> PCOOKIHJICG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x84D6CE0", Offset = "0x84D52E0", VA = "0x1884D6CE0", Slot = "4")]
		public void Execute(int LEPAEEGOBDO, TransformAccess JAHKFPBBGHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[BurstCompile]
	public struct CNPJPAMFDOL : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<int> EOIEDADDKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4x4> AGAALIDPFGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[ReadOnly]
		private NativeArray<float4> CJGPCOMAEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[WriteOnly]
		private NativeArray<BOAICCOEHKN> NLKMMOJFPMB;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x84C9210", Offset = "0x84C7810", VA = "0x1884C9210")]
		public CNPJPAMFDOL(NativeArray<int> BALLDEMAJMI, NativeArray<float4x4> FMALEAFEMCJ, NativeArray<float4> DOGDFOJKAHE, NativeArray<BOAICCOEHKN> BDHPLBBJNMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x84C91A0", Offset = "0x84C77A0", VA = "0x1884C91A0", Slot = "4")]
		public void Execute(int LEPAEEGOBDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private const byte DPNAIDIKMHP = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private TransformAccessArray LMBKMLMPCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> ECOGNIJIKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4x4> EMCFNBEAJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> BFFOHDNGKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> NAKFBNKGLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> NMJGBDOKKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private HDCLLOBMLBC HAFNONPEKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private HDCLLOBMLBC BGINDKFLBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private HDCLLOBMLBC OOHONPFAPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private HDCLLOBMLBC HPBCABPBKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private HDCLLOBMLBC NJCFLJNFGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private Transform HHCGNPOKKAM;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x84D4AE0", Offset = "0x84D30E0", VA = "0x1884D4AE0")]
	public KAGNLPLLPHK(int MICCKHBPFLG, int LNOKAEEMCOM, ComputeShader IHMPIMNLCPH, int JGOLOCNMOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x84D4560", Offset = "0x84D2B60", VA = "0x1884D4560", Slot = "6")]
	protected override void AHFKAAGEEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x84D4970", Offset = "0x84D2F70", VA = "0x1884D4970")]
	private void HANPAGGDBGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x84D4770", Offset = "0x84D2D70", VA = "0x1884D4770")]
	public bool AKCDPHPIOOM(GJLFNJJFKBD IINGFCBPPPE, Transform JAHKFPBBGHB, float JHCIGFMLDBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x84D4480", Offset = "0x84D2A80", VA = "0x1884D4480")]
	public void AHAKHKCFPJO(GJLFNJJFKBD IINGFCBPPPE, float JHCIGFMLDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x84D4A30", Offset = "0x84D3030", VA = "0x1884D4A30")]
	public void HIKGNNMAOMB(GJLFNJJFKBD IINGFCBPPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x84D48D0", Offset = "0x84D2ED0", VA = "0x1884D48D0", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NHFEFALFGMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KGBENKDOKKC IMDIPNPDNOK();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HKHNKOMLGCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 HNNOIPHAHBO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int EDNLPJDMDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int MHODMACGMFM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> IIKJNDDFMGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> DHACPNNANII
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> HMGAENCOFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> BPCIDGAMCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> JGKEKMJLLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> AGJIDEPCOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int EJBGMBLJEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int LAEGNJIIFDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int GIJPADPLEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool NMCPPFOMOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CHNAFCJOMPA();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HFPBJPKAAPP : HKHNKOMLGCA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NHFEFALFGMD KEKKCBAMNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private KGBENKDOKKC LJNJDNJBNIE;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 HNNOIPHAHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xEADD60", Offset = "0xEAC360", VA = "0x180EADD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool LLKDPACALCP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA94FC0", Offset = "0xA935C0", VA = "0x180A94FC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int EDNLPJDMDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1093000", Offset = "0x1091600", VA = "0x181093000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int MHODMACGMFM
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int NILFCDKLHLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1696150", Offset = "0x1694750", VA = "0x181696150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> IIKJNDDFMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x84D4180", Offset = "0x84D2780", VA = "0x1884D4180", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> DHACPNNANII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x84D4100", Offset = "0x84D2700", VA = "0x1884D4100", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> HMGAENCOFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x84D41F0", Offset = "0x84D27F0", VA = "0x1884D41F0", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> BPCIDGAMCAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84D3EC0", Offset = "0x84D24C0", VA = "0x1884D3EC0", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> JGKEKMJLLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x84D4150", Offset = "0x84D2750", VA = "0x1884D4150", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> AGJIDEPCOLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x84D4220", Offset = "0x84D2820", VA = "0x1884D4220", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NMCPPFOMOON
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAC3630", Offset = "0xAC1C30", VA = "0x180AC3630", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xAC33B0", Offset = "0xAC19B0", VA = "0x180AC33B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int EJBGMBLJEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x84D4250", Offset = "0x84D2850", VA = "0x1884D4250", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int LAEGNJIIFDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x84D3F30", Offset = "0x84D2530", VA = "0x1884D3F30", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int GIJPADPLEKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x84D4130", Offset = "0x84D2730", VA = "0x1884D4130", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x84D4260", Offset = "0x84D2860", VA = "0x1884D4260")]
	public HFPBJPKAAPP(Hash128 PDDACHIAKKM, NHFEFALFGMD KEKKCBAMNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x84D3F50", Offset = "0x84D2550", VA = "0x1884D3F50", Slot = "16")]
	public void CHNAFCJOMPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x84D4070", Offset = "0x84D2670", VA = "0x1884D4070", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct GJLFNJJFKBD : IEquatable<GJLFNJJFKBD>
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly GJLFNJJFKBD OBPFBJLIFCL;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int LBGMECNKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
	public GJLFNJJFKBD(int LEPAEEGOBDO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x84D3D10", Offset = "0x84D2310", VA = "0x1884D3D10", Slot = "4")]
	public bool Equals(GJLFNJJFKBD IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x84D3D60", Offset = "0x84D2360", VA = "0x1884D3D60", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x84D3E30", Offset = "0x84D2430", VA = "0x1884D3E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FGKAKNMKDGK : DLDKAFAAEFE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private bool DBHLNGGNPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private HKHNKOMLGCA FGNANNDJJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<GJLFNJJFKBD> ENFMPCPFJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<GJLFNJJFKBD> BKFBIFCIODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private List<GJLFNJJFKBD> MNGFOPBKLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Dictionary<int, uint> EBECOKIFFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int GAELDOPGMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int JLMPMKKMHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int IFCHOLOIILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int HNBDAFIGNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int HDCGBBKOPAC;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int LBGMECNKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x84D2C00", Offset = "0x84D1200", VA = "0x1884D2C00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x84D1830", Offset = "0x84CFE30", VA = "0x1884D1830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool IKMNHDGIIAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xB72650", Offset = "0xB70C50", VA = "0x180B72650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool HEGFMFLMOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xB72670", Offset = "0xB70C70", VA = "0x180B72670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xB72660", Offset = "0xB70C60", VA = "0x180B72660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool HCDLCNFALOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool MBMNEAKACJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A79D30", Offset = "0x2A78330", VA = "0x182A79D30", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB72640", Offset = "0xB70C40", VA = "0x180B72640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float BHPCFKHCDOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x106F840", Offset = "0x106DE40", VA = "0x18106F840")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x106F850", Offset = "0x106DE50", VA = "0x18106F850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x84D3440", Offset = "0x84D1A40", VA = "0x1884D3440")]
	public FGKAKNMKDGK(HKHNKOMLGCA LJNJDNJBNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x84D2CB0", Offset = "0x84D12B0", VA = "0x1884D2CB0")]
	private void PBMHELDCOEL(HKHNKOMLGCA LJNJDNJBNIE, int GAELDOPGMHO, int IPIEAGLOIJK, int LEPAEEGOBDO, int EOCCDPEEJLD, LONJJCIJIIE DAJAOHIJHHL, float LMKCJPAHFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x84D3180", Offset = "0x84D1780", VA = "0x1884D3180")]
	private void PPFNDDHHNDP(HKHNKOMLGCA LJNJDNJBNIE, int LHPKLEPLBDP, int LEPAEEGOBDO, uint3 CNNKGMFPNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x84D18D0", Offset = "0x84CFED0", VA = "0x1884D18D0")]
	private bool ENBDCNOGIPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x84D2260", Offset = "0x84D0860", VA = "0x1884D2260", Slot = "4")]
	public bool KMLBEHGKDFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x84D1B70", Offset = "0x84D0170", VA = "0x1884D1B70", Slot = "5")]
	public bool FLHPFKIPOFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x84D1BF0", Offset = "0x84D01F0", VA = "0x1884D1BF0", Slot = "6")]
	public void HCDNAOEAAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x84D1870", Offset = "0x84CFE70", VA = "0x1884D1870")]
	public void HOBFFJNDDLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x84D1870", Offset = "0x84CFE70", VA = "0x1884D1870", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DLDKAFAAEFE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool HCDLCNFALOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool MBMNEAKACJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMLBEHGKDFG();

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FLHPFKIPOFF();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HCDNAOEAAEJ();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KDPKMAMLHAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly float NFGJMDLIDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, FGKAKNMKDGK> PCPANFMGDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Dictionary<Hash128, CIPPCHELKAJ> ACHCJFNFLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<DLDKAFAAEFE> MPOHCDKFDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<DLDKAFAAEFE> FMCKBBBPNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Queue<DLDKAFAAEFE> JLNFBDNNPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int ACDNDLKDDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private int PFPFJNJJAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private float CAMNPLPIBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool MFDADAPALMH;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool KAFKIPNEGBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x19825C0", Offset = "0x1980BC0", VA = "0x1819825C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1992160", Offset = "0x1990760", VA = "0x181992160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool NMKJIOCIAGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x84D59A0", Offset = "0x84D3FA0", VA = "0x1884D59A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string BCEFDONFGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x84D59F0", Offset = "0x84D3FF0", VA = "0x1884D59F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x84D5990", Offset = "0x84D3F90", VA = "0x1884D5990")]
	public void ECMNOIEAKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x25C3410", Offset = "0x25C1A10", VA = "0x1825C3410")]
	public void ECOLFAKFLHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x84D5F20", Offset = "0x84D4520", VA = "0x1884D5F20")]
	public KDPKMAMLHAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x84D4F00", Offset = "0x84D3500", VA = "0x1884D4F00")]
	public EOBJAEIIOPA CBPAAEAGBMC(DNJHNKFPKBM PLKOLLOCKHK, bool ANGPAFEFBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x84D4DC0", Offset = "0x84D33C0", VA = "0x1884D4DC0")]
	public CIPPCHELKAJ CBPAAEAGBMC(APGLOIBBEMN JKDFAJLFBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x84D5DA0", Offset = "0x84D43A0", VA = "0x1884D5DA0")]
	public bool FMOOFHOPIDF(Hash128 JIEJOKBHEMF, [Out] FGKAKNMKDGK MGOHICHGCAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x84D5030", Offset = "0x84D3630", VA = "0x1884D5030")]
	public FGKAKNMKDGK CBPAAEAGBMC(HKHNKOMLGCA LJNJDNJBNIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x84D5E10", Offset = "0x84D4410", VA = "0x1884D5E10")]
	private void HKPPJFKOANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D3DF0", VA = "0x1884D57F0")]
	private bool DDEFCHEIAAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x84D5320", Offset = "0x84D3920", VA = "0x1884D5320")]
	public void CHNAFCJOMPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x84D5880", Offset = "0x84D3E80", VA = "0x1884D5880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x84D5E30", Offset = "0x84D4430", VA = "0x1884D5E30")]
	public void JKHFIKONJMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OMBNJGFMNFA : DAFPEKCBNOH<BEMMPODMBLE, BEMMPODMBLE>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x84D70C0", Offset = "0x84D56C0", VA = "0x1884D70C0")]
	public OMBNJGFMNFA(int MICCKHBPFLG, int LNOKAEEMCOM, ComputeShader IHMPIMNLCPH, int JGOLOCNMOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BPEOLPHIDAF : DAFPEKCBNOH<OFNKHPFGEHH, OFNKHPFGEHH>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x84C81C0", Offset = "0x84C67C0", VA = "0x1884C81C0")]
	public BPEOLPHIDAF(int MICCKHBPFLG, int LNOKAEEMCOM, ComputeShader IHMPIMNLCPH, int JGOLOCNMOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class CEFAPEINKJG : DAFPEKCBNOH<CAIKJOKGPLL, CAIKJOKGPLL>
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x84C88B0", Offset = "0x84C6EB0", VA = "0x1884C88B0")]
	public CEFAPEINKJG(int MICCKHBPFLG, int LNOKAEEMCOM, ComputeShader IHMPIMNLCPH, int JGOLOCNMOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class HHBBNPFCCCC : DAFPEKCBNOH<OOMDKLNLGKD, BCIGANCDECA>
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x84D42B0", Offset = "0x84D28B0", VA = "0x1884D42B0")]
	public HHBBNPFCCCC(int MICCKHBPFLG, int LNOKAEEMCOM, ComputeShader IHMPIMNLCPH, int JGOLOCNMOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class KGLIHALFNJH : DAFPEKCBNOH<AKCIHONODFF, AKCIHONODFF>
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x84D60B0", Offset = "0x84D46B0", VA = "0x1884D60B0")]
	public KGLIHALFNJH(int MICCKHBPFLG, int LNOKAEEMCOM, ComputeShader IHMPIMNLCPH, int JGOLOCNMOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class OMFOABLCIEK : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private DCNNFCDFCMK HIIFDFDOIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool ANBCINBEIHB;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static bool IDNEOPFHDNA;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x84D7570", Offset = "0x84D5B70", VA = "0x1884D7570")]
	public OMFOABLCIEK(DCNNFCDFCMK OKLKOCEPCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x84D73E0", Offset = "0x84D59E0", VA = "0x1884D73E0", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer PCKGIGGFIHN, RenderingData FMGGMKFBAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x84D7170", Offset = "0x84D5770", VA = "0x1884D7170", Slot = "6")]
	public override void Configure(CommandBuffer PCKGIGGFIHN, RenderTextureDescriptor EOBAJPFKLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x84D71B0", Offset = "0x84D57B0", VA = "0x1884D71B0", Slot = "9")]
	public override void Execute(ScriptableRenderContext HHPFOCCGJIF, RenderingData FMGGMKFBAKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class CDMKLLLEAGE
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public readonly struct OKPJFCONPDE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly string DJFMCHMDHGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CommandBuffer PCKGIGGFIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly ScriptableRenderContext HHPFOCCGJIF;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x84D6FB0", Offset = "0x84D55B0", VA = "0x1884D6FB0")]
		public OKPJFCONPDE(string LNBLPLENDBD, ScriptableRenderContext OOGJPCLEJAA, [Out] CommandBuffer GHNIBGNNAOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x84D6F00", Offset = "0x84D5500", VA = "0x1884D6F00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x84C8320", Offset = "0x84C6920", VA = "0x1884C8320")]
	public static bool NBFHEMJFGFB(RenderingData FMGGMKFBAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x84C86E0", Offset = "0x84C6CE0", VA = "0x1884C86E0")]
	public static void PFHEHABEEHK(CommandBuffer PCKGIGGFIHN, ScriptableRenderContext HHPFOCCGJIF, ShadowDrawingSettings FCMBNELMFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x84C8470", Offset = "0x84C6A70", VA = "0x1884C8470")]
	public static void PBGFPFJBLKB(CommandBuffer PCKGIGGFIHN, ScriptableRenderContext HHPFOCCGJIF, RenderingData FMGGMKFBAKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DCNNFCDFCMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class CIEHKICANKP
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int FLMMBHAKIBF;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public static readonly int OGICOKNLFDN;
	}

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static NHMFHDFPMFF<JIMGNJGJCLF> PPMCPKPNCAI;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static NHMFHDFPMFF<uint> BLMLFJGLABO;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static HDCLLOBMLBC PDFCGGCBEEG;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static ComputeBuffer FFDEOELKCNA;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static List<HDJJOPEAIJO> LBHOJPCNDFH;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int CFKHBCEJNFH;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int HDOLAFGPKIF;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int PHIKJOFCJNF;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int OPFCLHPPAMA;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static int[] EEICIPFEFDK;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static Material[] GBECGNILMAF;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static PJLMPLIFONM[][] EHGKDMEDECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Plane[] DFPKEHDIBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int MHFOCNOLMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int GFJPIMMLKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int LHDNOMJFFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int CCPPFIAGEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int OHKCEGFBMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int LMHLBLJHOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int KGOIEMJNFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int FLMFFHGNMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int CLEOFANGIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int IJACCPPDLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int OJENBEMKMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int DFDNGLILOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int JHGPPPFFAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int BAPPDGGIKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int NAKKFOGBOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int LBGEGLEKBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int DJHFBHAAGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int OGJLEEMKMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private float[] OOCCABNINGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private KDPKMAMLHAE BJCLDMKMMIG;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool MENAGCGFOKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x84CA430", Offset = "0x84C8A30", VA = "0x1884CA430")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x84CBCB0", Offset = "0x84CA2B0", VA = "0x1884CBCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool DPBAHOFHHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x84CA320", Offset = "0x84C8920", VA = "0x1884CA320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x84D0110", Offset = "0x84CE710", VA = "0x1884D0110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData AIJFAAIOPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x84CBC60", Offset = "0x84CA260", VA = "0x1884CBC60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x84CFB90", Offset = "0x84CE190", VA = "0x1884CFB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static KAGNLPLLPHK CEAFCEPNPNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x84C9CD0", Offset = "0x84C82D0", VA = "0x1884C9CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x84CFC00", Offset = "0x84CE200", VA = "0x1884CFC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static OMBNJGFMNFA CAHLDJKPBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x84CE880", Offset = "0x84CCE80", VA = "0x1884CE880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x84CBBF0", Offset = "0x84CA1F0", VA = "0x1884CBBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static BPEOLPHIDAF FCPGLLGMGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x84CAD20", Offset = "0x84C9320", VA = "0x1884CAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x84D0170", Offset = "0x84CE770", VA = "0x1884D0170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static CEFAPEINKJG CDIFNPIOAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x84C9BC0", Offset = "0x84C81C0", VA = "0x1884C9BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x84CC4B0", Offset = "0x84CAAB0", VA = "0x1884CC4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static HHBBNPFCCCC JJILIDHOPNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x84CA9F0", Offset = "0x84C8FF0", VA = "0x1884CA9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x84CB540", Offset = "0x84C9B40", VA = "0x1884CB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static KGLIHALFNJH NGMCNDAGPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x84CA990", Offset = "0x84C8F90", VA = "0x1884CA990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x84CBD10", Offset = "0x84CA310", VA = "0x1884CBD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material DNHFDGFJPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x84CA370", Offset = "0x84C8970", VA = "0x1884CA370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x84CC350", Offset = "0x84CA950", VA = "0x1884CC350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material LEJIPMIDGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x84CA3D0", Offset = "0x84C89D0", VA = "0x1884CA3D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x84C9240", Offset = "0x84C7840", VA = "0x1884C9240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material IFIGGJLJEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x84C9C70", Offset = "0x84C8270", VA = "0x1884C9C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x84CC3D0", Offset = "0x84CA9D0", VA = "0x1884CC3D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material OANLBKCKFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x84C9C10", Offset = "0x84C8210", VA = "0x1884C9C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x84CB5C0", Offset = "0x84C9BC0", VA = "0x1884CB5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool DCPKJMOEBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x84C9D90", Offset = "0x84C8390", VA = "0x1884C9D90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84CC450", Offset = "0x84CAA50", VA = "0x1884CC450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool NMKJIOCIAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x84CAA50", Offset = "0x84C9050", VA = "0x1884CAA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string BCEFDONFGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x84CAE60", Offset = "0x84C9460", VA = "0x1884CAE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x84D0280", Offset = "0x84CE880", VA = "0x1884D0280")]
	internal DCNNFCDFCMK([Optional] MClusterData AAMMKMGCNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x84CC520", Offset = "0x84CAB20", VA = "0x1884CC520")]
	public void LJDCNOCKLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x84CAAB0", Offset = "0x84C90B0", VA = "0x1884CAAB0")]
	public void EOIOLBCOPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x84C9DF0", Offset = "0x84C83F0", VA = "0x1884C9DF0")]
	public void BPMCJNDABBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x84CA280", Offset = "0x84C8880", VA = "0x1884CA280")]
	public bool CEGEEBOMCCO(Hash128 PDDACHIAKKM, [Out] FGKAKNMKDGK LJNJDNJBNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x84CA1C0", Offset = "0x84C87C0", VA = "0x1884CA1C0")]
	public FGKAKNMKDGK CBPAAEAGBMC(HKHNKOMLGCA DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x84C9E00", Offset = "0x84C8400", VA = "0x1884C9E00")]
	public CIPPCHELKAJ CBPAAEAGBMC(APGLOIBBEMN JKDFAJLFBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x84CA000", Offset = "0x84C8600", VA = "0x1884CA000")]
	public EOBJAEIIOPA CBPAAEAGBMC(DNJHNKFPKBM PLKOLLOCKHK, bool ANGPAFEFBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x84CBBA0", Offset = "0x84CA1A0", VA = "0x1884CBBA0")]
	public void HCDNAOEAAEJ(DLDKAFAAEFE OBLNGAJKDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x84CAD70", Offset = "0x84C9370", VA = "0x1884CAD70")]
	public static void FEOJIAACAHG(NHAPIDOPIJE CGCOAIEEKKE, PJLMPLIFONM[] DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x84C92C0", Offset = "0x84C78C0", VA = "0x1884C92C0")]
	private void AHAEJPNADKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x84CEEC0", Offset = "0x84CD4C0", VA = "0x1884CEEC0")]
	private static void NMNGJFGFPJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x84CA670", Offset = "0x84C8C70", VA = "0x1884CA670")]
	public void EDLCIBJALEB(CommandBuffer PCKGIGGFIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x84CAB50", Offset = "0x84C9150", VA = "0x1884CAB50")]
	public void EOJJABPIHCB([Optional] ScriptableRenderContext? HHPFOCCGJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x84CC070", Offset = "0x84CA670", VA = "0x1884CC070")]
	public void KEKBBECKAAC(CommandBuffer PCKGIGGFIHN, ShadowSplitData NNCLMBDPEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x84CBD90", Offset = "0x84CA390", VA = "0x1884CBD90")]
	public void KEKBBECKAAC(CommandBuffer PCKGIGGFIHN, CameraData EBJGBLCMHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x84CB640", Offset = "0x84C9C40", VA = "0x1884CB640")]
	public void GLKPCNDEAHL(CommandBuffer PCKGIGGFIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x84C9D20", Offset = "0x84C8320", VA = "0x1884C9D20")]
	public void BOBDNOOPEDH(CommandBuffer PCKGIGGFIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x84CFC70", Offset = "0x84CE270", VA = "0x1884CFC70")]
	public void PEMJANDAMJP(CommandBuffer PCKGIGGFIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x84CE8D0", Offset = "0x84CCED0", VA = "0x1884CE8D0")]
	public void MIKDHDKJDMI(CommandBuffer PCKGIGGFIHN, NHAPIDOPIJE HGDJBDOFHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x84CA480", Offset = "0x84C8A80", VA = "0x1884CA480")]
	public void DPMLAIGJMOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x84CD8D0", Offset = "0x84CBED0", VA = "0x1884CD8D0")]
	public void LOMEBHIDOPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x84CA560", Offset = "0x84C8B60", VA = "0x1884CA560", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GMOIGCPCFHE
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x29E7D00", Offset = "0x29E6300", VA = "0x1829E7D00")]
	public static int IPNLPEDNHMF(int JFOIDEBHAAF, int CMGEFEFPKHM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct BOAICCOEHKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4x4 KLDAOPKNMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float4 LNMEAHBHNBJ;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly BOAICCOEHKN EFCODMHNGJC;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly BOAICCOEHKN OBPFBJLIFCL;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x84C8190", Offset = "0x84C6790", VA = "0x1884C8190")]
	public BOAICCOEHKN(float4x4 DAAAAHNMDDO, float4 MPIIMNHKPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x84C8020", Offset = "0x84C6620", VA = "0x1884C8020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct LONJJCIJIIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 AANGPKCDGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 NNMAALGIDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 KDCHPNLBIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 DFIFCFFFMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 FGPMPJLHADF;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct CPADAAEKIHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public float4 AANGPKCDGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 NNMAALGIDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 KDCHPNLBIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 DFIFCFFFMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public half4 FGPMPJLHADF;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct BCIGANCDECA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public CPADAAEKIHD EEELECAJAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public CPADAAEKIHD IGIIJAHDNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public CPADAAEKIHD AEOPFDCNCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public CPADAAEKIHD IIFCGOFAMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public CPADAAEKIHD KGIAHMOPHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public CPADAAEKIHD CGEOFHDIOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public CPADAAEKIHD MIDJMCJODAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public CPADAAEKIHD CKEAMBCIEFN;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct OOMDKLNLGKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public LONJJCIJIIE EEELECAJAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public LONJJCIJIIE IGIIJAHDNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public LONJJCIJIIE AEOPFDCNCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public LONJJCIJIIE IIFCGOFAMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public LONJJCIJIIE KGIAHMOPHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public LONJJCIJIIE CGEOFHDIOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public LONJJCIJIIE MIDJMCJODAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public LONJJCIJIIE CKEAMBCIEFN;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct OFNKHPFGEHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float4 FLBNNCEFFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint LMJBCALGIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public uint IIBBPLOLFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public float IFHBMGPCEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint ILOMMEHPJEF;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x84D6ED0", Offset = "0x84D54D0", VA = "0x1884D6ED0")]
	public OFNKHPFGEHH(APGLOIBBEMN JKDFAJLFBEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct JIMGNJGJCLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint FPAFDHGBHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint GKOIFMADLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint EOCCDPEEJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint ILOMMEHPJEF;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x84D43D0", Offset = "0x84D29D0", VA = "0x1884D43D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct CAIKJOKGPLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint IPIEAGLOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint MCGGOADDICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint JLMPMKKMHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint ILOMMEHPJEF;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x84C8270", Offset = "0x84C6870", VA = "0x1884C8270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct BEMMPODMBLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint LIJMKKBPIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint JLFINJLKFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint GMEJBDFLPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint JHGACBHOEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint EAMCLJBBHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint LLMAOHGKICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint LOHONKEGDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint ILOMMEHPJEF;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x84C7410", Offset = "0x84C5A10", VA = "0x1884C7410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct AKCIHONODFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 FHDEJEAIPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 KKKBOAHPDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 ACCFBKGADBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 FALBFLPBIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 LJGDMDMLPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 BNMBEGGIHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 IKCCBLGNKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public uint3 HLIEDLGPPKJ;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x84C6E40", Offset = "0x84C5440", VA = "0x1884C6E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum NHAPIDOPIJE
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
