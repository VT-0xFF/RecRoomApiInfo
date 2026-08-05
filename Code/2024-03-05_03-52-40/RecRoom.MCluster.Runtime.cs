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
public struct OHAAAJJLCDD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] OFPNAOBOIMC;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] CDFPBEOLNLN;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] CFKDJGBHCMJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xD7D620", Offset = "0xD7C420", VA = "0x180D7D620")]
	public static int NOBFJMKIILI(JHOMLMCJIEL JPKFLBLKANP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x612B5C0", Offset = "0x612A3C0", VA = "0x18612B5C0")]
	public static int BBMDJJGGGBM(JHOMLMCJIEL JPKFLBLKANP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JLNKKJGOOFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int ODPBDBEENJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ABCABMPBMEF FBDHBCJHPGK(int FBJIHPHAKKE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 EMOKKMFIMOK(int FBJIHPHAKKE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BHIFHHDNGPJ BCPCDIECLKI();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EIMODFBDHPI BCBAIMCMFGO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EDKIIFNJLJO : KKIIEIBPKJP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private BHIFHHDNGPJ NBCGMJPEDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform KJPFPABMDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<MEPCBMAFFIJ> JIHCOBPDMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private KPNAODJMOIJ POGFJLAAPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CAAMDEKPJPK DPLOEONHKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HAMHOFOFNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private JLNKKJGOOFJ CFOIHGFIKIJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float BNMOEMFPBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x91AC40", Offset = "0x919A40", VA = "0x18091AC40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB5B8F0", Offset = "0xB5A6F0", VA = "0x180B5B8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FHDJKLBKMGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85D720", Offset = "0x85C520", VA = "0x18085D720")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85D7E0", Offset = "0x85C5E0", VA = "0x18085D7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MBFCMEPKAIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x104D0B0", Offset = "0x104BEB0", VA = "0x18104D0B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x104CAB0", Offset = "0x104B8B0", VA = "0x18104CAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KODEICHACDH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6123B80", Offset = "0x6122980", VA = "0x186123B80", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6124C20", Offset = "0x6123A20", VA = "0x186124C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GINNHHKIOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12072E0", Offset = "0x12060E0", VA = "0x1812072E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6124E00", Offset = "0x6123C00", VA = "0x186124E00")]
	public EDKIIFNJLJO(JLNKKJGOOFJ EFLINIEMOEE, bool GNLKADHKFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6123BA0", Offset = "0x61229A0", VA = "0x186123BA0")]
	private bool ECCAMHLKJJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6123FF0", Offset = "0x6122DF0", VA = "0x186123FF0", Slot = "4")]
	public bool GALNLGNAACN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6124C30", Offset = "0x6123A30", VA = "0x186124C30", Slot = "5")]
	public bool LAGHJNJIPJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6123DC0", Offset = "0x6122BC0", VA = "0x186123DC0", Slot = "6")]
	public void FIJOKOAGLFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6123B90", Offset = "0x6122990", VA = "0x186123B90", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CEJNEOONALM
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAKGFLPLKDI(CommandBuffer BHOCKOPMBEI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GMICBLMCFAG : CEJNEOONALM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int KAFEFKNGGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFA0", Offset = "0x8E9DA0", VA = "0x1808EAFA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier INJEECPNGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3BDE330", Offset = "0x3BDD130", VA = "0x183BDE330")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6126010", Offset = "0x6124E10", VA = "0x186126010")]
	public GMICBLMCFAG(int FJIJLBIGEAH, RenderTargetIdentifier EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6125FC0", Offset = "0x6124DC0", VA = "0x186125FC0", Slot = "4")]
	public void GAKGFLPLKDI(CommandBuffer BHOCKOPMBEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct ENOOJJPIBCB : CEJNEOONALM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int KAFEFKNGGHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFA0", Offset = "0x8E9DA0", VA = "0x1808EAFA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] IFNBPPNGMFC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8E9730", Offset = "0x8E8530", VA = "0x1808E9730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xBF9910", Offset = "0xBF8710", VA = "0x180BF9910")]
	public ENOOJJPIBCB(int FJIJLBIGEAH, Vector4[] EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61259B0", Offset = "0x61247B0", VA = "0x1861259B0", Slot = "4")]
	public void GAKGFLPLKDI(CommandBuffer BHOCKOPMBEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct KMFBDCFBHLD : CEJNEOONALM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int KAFEFKNGGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFA0", Offset = "0x8E9DA0", VA = "0x1808EAFA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] GIDENLDFNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8E9730", Offset = "0x8E8530", VA = "0x1808E9730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xBF9910", Offset = "0xBF8710", VA = "0x180BF9910")]
	public KMFBDCFBHLD(int FJIJLBIGEAH, float[] EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6126320", Offset = "0x6125120", VA = "0x186126320", Slot = "4")]
	public void GAKGFLPLKDI(CommandBuffer BHOCKOPMBEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KECFPKLOGHE : CEJNEOONALM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string PAHJIBDDKIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool DINCJKDOFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1942A80", Offset = "0x1941880", VA = "0x181942A80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x378C4E0", Offset = "0x378B2E0", VA = "0x18378C4E0")]
	public KECFPKLOGHE(string OCCHBLONHPL, bool IBCOHIKFCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61262E0", Offset = "0x61250E0", VA = "0x1861262E0", Slot = "4")]
	public void GAKGFLPLKDI(CommandBuffer BHOCKOPMBEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct EIMODFBDHPI
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 KODDFNIBEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 BBPMKAIDGFD
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x825D70", Offset = "0x824B70", VA = "0x180825D70")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int CBFJBKBCHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x91FAD0", Offset = "0x91E8D0", VA = "0x18091FAD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LIHIBOCLPEF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A10", Offset = "0x7F7810", VA = "0x1807F8A10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float MGEEJEFEJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x97EE90", Offset = "0x97DC90", VA = "0x18097EE90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6124F50", Offset = "0x6123D50", VA = "0x186124F50")]
	public EIMODFBDHPI(Color DNOKCMICDIP, int CJBPDIIPDGA, int CEAMMMGHHMC, float HHGICAOMHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x565E9C0", Offset = "0x565D7C0", VA = "0x18565E9C0")]
	private static float4 JFGAKPLFCAC(Color DNOKCMICDIP)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6124EC0", Offset = "0x6123CC0", VA = "0x186124EC0")]
	private static Hash128 MGBLGICPBLO(EIMODFBDHPI EFLINIEMOEE)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KPNAODJMOIJ : KKIIEIBPKJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string LGFBNFDMMJF;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string HDLGBJMIAJL;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string KNAAKFPGGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private EIMODFBDHPI AFIFINEHDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private CAIFGPJGBFB NLKDDMHEDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 HDINCCIPDEF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public CAAMDEKPJPK MJEGDADCPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7E0AF0", Offset = "0x7DF8F0", VA = "0x1807E0AF0")]
		[CompilerGenerated]
		get
		{
			return default(CAAMDEKPJPK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9208C0", Offset = "0x91F6C0", VA = "0x1809208C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool FHDJKLBKMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x51C7380", Offset = "0x51C6180", VA = "0x1851C7380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x51C7390", Offset = "0x51C6190", VA = "0x1851C7390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MBFCMEPKAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1D3C630", Offset = "0x1D3B430", VA = "0x181D3C630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5540", Offset = "0x5EF4340", VA = "0x185EF5540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GINNHHKIOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7D4310", Offset = "0x7D3110", VA = "0x1807D4310", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool KODEICHACDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x52704E0", Offset = "0x526F2E0", VA = "0x1852704E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5370", Offset = "0x5EF4170", VA = "0x185EF5370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int LNBHMBDGGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x61266C0", Offset = "0x61254C0", VA = "0x1861266C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x61269F0", Offset = "0x61257F0", VA = "0x1861269F0")]
	public KPNAODJMOIJ(EIMODFBDHPI KHCAEEMGJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6126350", Offset = "0x6125150", VA = "0x186126350")]
	private bool ECCAMHLKJJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6126570", Offset = "0x6125370", VA = "0x186126570", Slot = "4")]
	public bool GALNLGNAACN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x61268C0", Offset = "0x61256C0", VA = "0x1861268C0")]
	private static CAIFGPJGBFB LEMHJOOAMBN(EIMODFBDHPI EFLINIEMOEE)
	{
		return default(CAIFGPJGBFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6126710", Offset = "0x6125510", VA = "0x186126710", Slot = "5")]
	public bool LAGHJNJIPJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6126460", Offset = "0x6125260", VA = "0x186126460", Slot = "6")]
	public void FIJOKOAGLFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6127190", Offset = "0x6125F90", VA = "0x186127190", Slot = "0")]
		public override bool Equals(object EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6127390", Offset = "0x6126190", VA = "0x186127390", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8853D0", Offset = "0x8841D0", VA = "0x1808853D0")]
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
		private AMELFPBOPFN opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static PEFCIKMDFJJ CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6127A60", Offset = "0x6126860", VA = "0x186127A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6127AA0", Offset = "0x61268A0", VA = "0x186127AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6127470", Offset = "0x6126270", VA = "0x186127470", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6127440", Offset = "0x6126240", VA = "0x186127440", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FNMHNENOEME, RenderingData KNAJILBBHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x61278D0", Offset = "0x61266D0", VA = "0x1861278D0")]
		public void LOFACEFHJFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xBE9040", Offset = "0xBE7E40", VA = "0x180BE9040")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class EIBCKFJELBE<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DEDEHKJJJNH PJLNBKDPGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private DEDEHKJJJNH MLOPMEPGGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer PBCFODNKJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture KKFEKJNNEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int JJBMDEBHHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int GFPLGGAJGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string NJMONCADGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string HLGGBPPLBMC;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7B8950", Offset = "0x7B7750", VA = "0x1807B8950")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int FDCDHPEIFIP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xC0A230", Offset = "0xC09030", VA = "0x180C0A230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int MGBKBMMJMHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7D74E0", Offset = "0x7D62E0", VA = "0x1807D74E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3298EF0", Offset = "0x3297CF0", VA = "0x183298EF0")]
	public EIBCKFJELBE(string OCCHBLONHPL, int HDMMJHLPMOK, [Optional] RenderTextureFormat? JNKFGFMNPLJ, bool AGIJDLGNKCB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x32976B0", Offset = "0x32964B0", VA = "0x1832976B0")]
	public void LAGHJNJIPJP(CommandBuffer BHOCKOPMBEI, NativeArray<ValType> EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x32984B0", Offset = "0x32972B0", VA = "0x1832984B0")]
	public void OLELHAMEDFE(CommandBuffer BHOCKOPMBEI, ComputeShader BIFLKCGMOGN, int DHENHLJCFFN, int LHAAEHAPBDP = -1, int AMHFEHEKNDP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3298BE0", Offset = "0x32979E0", VA = "0x183298BE0")]
	public void OLELHAMEDFE(Material NLKDDMHEDOF, int LHAAEHAPBDP = -1, int AMHFEHEKNDP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3296EE0", Offset = "0x3295CE0", VA = "0x183296EE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PEBKANHFEEF
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLELHAMEDFE(Material KHCAEEMGJLK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JEBDOMCNABA<SrcEntry, DstEntry> : PEBKANHFEEF, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] EPJJOPNHMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected DEDEHKJJJNH EGIHPPMMGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected DEDEHKJJJNH OKNOMHILMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> DAMLCKBOLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> JEOJMKDDDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int FLOMAFKPCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int EDEOOGAENHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected EIBCKFJELBE<int> GBJJDDOONFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected EIBCKFJELBE<SrcEntry> EBGBJDNDIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected EIBCKFJELBE<DstEntry> FBOKLGIOGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader FIBKMJDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int HNPGHPODKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int MIELFODNFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int DEJEHLMPKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int NDLACACKMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int PMDLDOMIPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int DCGJLGPLHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int PCLNIFDKEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int DGGBCGDGEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int JLBPPFPBDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int MILBPMGHPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int FKNAKBDKHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int ACFDDEDKEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string JDJHMPMGFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] IANIKAEPOKH;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int LACGIBAEEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3A54030", Offset = "0x3A52E30", VA = "0x183A54030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string BIACHEPDLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3A51830", Offset = "0x3A50630", VA = "0x183A51830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3A56C40", Offset = "0x3A55A40", VA = "0x183A56C40")]
	public JEBDOMCNABA(string OCCHBLONHPL, int DFIMKABDJIK, int FAMNMNJIEOM, RenderTextureFormat JNKFGFMNPLJ, ComputeShader LAINNPHPOAE, int APFCMELPKHN = 0, int NJPMGJPEEIG = 0, int GEBMABINDKL = 0, int EMKGMHGGEHH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A554B0", Offset = "0x3A542B0", VA = "0x183A554B0")]
	public int PBJFLPDJCHF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3A52370", Offset = "0x3A51170", VA = "0x183A52370")]
	protected void BOKKHFIMDGF(int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3A532C0", Offset = "0x3A520C0", VA = "0x183A532C0")]
	public CAAMDEKPJPK GALNLGNAACN(SrcEntry EEDANCJJEPL)
	{
		return default(CAAMDEKPJPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3A53500", Offset = "0x3A52300", VA = "0x183A53500")]
	public bool LAGHJNJIPJP(CAAMDEKPJPK PDCBMAPDAEE, SrcEntry EEDANCJJEPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3A52840", Offset = "0x3A51640", VA = "0x183A52840")]
	public bool FIJOKOAGLFM(CAAMDEKPJPK PDCBMAPDAEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "6")]
	protected virtual void GIKPEODBPOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3A54040", Offset = "0x3A52E40", VA = "0x183A54040", Slot = "7")]
	public void NACCHJFGBAB(CommandBuffer BHOCKOPMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3A54CD0", Offset = "0x3A53AD0", VA = "0x183A54CD0", Slot = "8")]
	public void NACCHJFGBAB(CommandBuffer BHOCKOPMBEI, ComputeShader LAINNPHPOAE, int APFCMELPKHN = -1, int NJPMGJPEEIG = -1, int GEBMABINDKL = -1, int EMKGMHGGEHH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3A55340", Offset = "0x3A54140", VA = "0x183A55340", Slot = "9")]
	public void OLELHAMEDFE(CommandBuffer BHOCKOPMBEI, ComputeShader LAINNPHPOAE, int APFCMELPKHN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3A552F0", Offset = "0x3A540F0", VA = "0x183A552F0", Slot = "4")]
	public void OLELHAMEDFE(Material NLKDDMHEDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3A52780", Offset = "0x3A51580", VA = "0x183A52780", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DEDEHKJJJNH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong DLJPEILNDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong MPBHIDDANNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OAGFDPPNNOA
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct HNNJJCMCPAN : DEDEHKJJJNH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable KLLBKOCNIMJ;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong DLJPEILNDPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8E9730", Offset = "0x8E8530", VA = "0x1808E9730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5940510", Offset = "0x593F310", VA = "0x185940510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong MPBHIDDANNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x130E730", Offset = "0x130D530", VA = "0x18130E730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4597890", Offset = "0x4596690", VA = "0x184597890")]
		internal HNNJJCMCPAN(IDisposable IDHBIEOEFDB, ulong INDNNEODMBC, ulong BEIEGHEAEJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x61260E0", Offset = "0x6124EE0", VA = "0x1861260E0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct JHAJNMCJHLC : DEDEHKJJJNH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture JDCOLHLMNOJ;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong DLJPEILNDPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8E9730", Offset = "0x8E8530", VA = "0x1808E9730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5940510", Offset = "0x593F310", VA = "0x185940510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong MPBHIDDANNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x130E730", Offset = "0x130D530", VA = "0x18130E730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x61262B0", Offset = "0x61250B0", VA = "0x1861262B0")]
		public JHAJNMCJHLC(RenderTexture MJKCCMHJFJF, ulong OJGJCEAMFLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6126210", Offset = "0x6125010", VA = "0x186126210", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong CBFEEDMMMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x612A250", Offset = "0x6129050", VA = "0x18612A250")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6129C90", Offset = "0x6128A90", VA = "0x186129C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong IMCPOKICAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6129A00", Offset = "0x6128800", VA = "0x186129A00")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x612A290", Offset = "0x6129090", VA = "0x18612A290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x612A070", Offset = "0x6128E70", VA = "0x18612A070")]
	public static ComputeBuffer KNBFKAAGFFE(int DPKFLHPPNCH, int GCEKMCJFEFC, ComputeBufferType LPFFKBBBCBL, [Out] DEDEHKJJJNH PDCBMAPDAEE, ComputeBufferMode DEFFIHPLIBJ = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6129CD0", Offset = "0x6128AD0", VA = "0x186129CD0")]
	public static RenderTexture KNBFKAAGFFE(int FHODMJAEPGE, int DCPJBMNOHJP, int NBANIMBJCEB, RenderTextureFormat JNKFGFMNPLJ, [Out] DEDEHKJJJNH PDCBMAPDAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x28898B0", Offset = "0x28886B0", VA = "0x1828898B0")]
	public static NativeArray<T> AGHFBHHMJIC<T>(NativeArray<T> KLLBKOCNIMJ, ulong AKCMMEDPGHB, [Out] DEDEHKJJJNH PDCBMAPDAEE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x288A710", Offset = "0x2889510", VA = "0x18288A710")]
	public static NativeArray<T> KNBFKAAGFFE<T>(int AKCMMEDPGHB, Allocator ALDDPOOJFGI, [Out] DEDEHKJJJNH PDCBMAPDAEE, NativeArrayOptions BAELEFOBFMO = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6129A40", Offset = "0x6128840", VA = "0x186129A40")]
	public static void COJAMHJFIEG(DEDEHKJJJNH KLLBKOCNIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6129B90", Offset = "0x6128990", VA = "0x186129B90")]
	public static uint FCNFKABCLGP(RenderTextureFormat JNKFGFMNPLJ)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ENIJIJCLLPC : JEBDOMCNABA<LPMNJGJHJJP, LPMNJGJHJJP>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct LJGIOHPJHNJ : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> EIIAFJAPNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> JMHCACEHELH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> LIABHPGFBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> NFIBNCKKMLF;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6125A50", Offset = "0x6124850", VA = "0x186125A50")]
		public LJGIOHPJHNJ(NativeArray<int> PNOHMDLJOBK, NativeArray<float> JMDGEJCHGKL, NativeArray<float4x4> CBEOGKFBPKF, NativeArray<float4> GCGLMCJCOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6126E30", Offset = "0x6125C30", VA = "0x186126E30", Slot = "4")]
		public void Execute(int OHINPGIGDNE, TransformAccess NBCGMJPEDEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct FEBFLHIPIJB : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> EIIAFJAPNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> LOMEHDCKAJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> IBFKKONPMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<LPMNJGJHJJP> KKLBACKDKAF;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6125A50", Offset = "0x6124850", VA = "0x186125A50")]
		public FEBFLHIPIJB(NativeArray<int> PNOHMDLJOBK, NativeArray<float4x4> FEBJKLMKDCF, NativeArray<float4> DIGIFJOAJDE, NativeArray<LPMNJGJHJJP> LBGOLPFMFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x61259E0", Offset = "0x61247E0", VA = "0x1861259E0", Slot = "4")]
		public void Execute(int OHINPGIGDNE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte AIPPPJJOLPB = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray CIKBDCAOHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> AHCBOPMJMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> DPAIDPMJGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> JJBDACILHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> BHMJEHFCHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> BPPKGIHLAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private DEDEHKJJJNH KICNMBENPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private DEDEHKJJJNH IDLLKKBAPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private DEDEHKJJJNH GPIFDHNOAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private DEDEHKJJJNH AEOCNHIJNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private DEDEHKJJJNH JBKIGLKMBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform HHJEGADMCLA;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x61256D0", Offset = "0x61244D0", VA = "0x1861256D0")]
	public ENIJIJCLLPC(int DFIMKABDJIK, int FAMNMNJIEOM, ComputeShader LAINNPHPOAE, int APFCMELPKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6125120", Offset = "0x6123F20", VA = "0x186125120", Slot = "6")]
	protected override void GIKPEODBPOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6125530", Offset = "0x6124330", VA = "0x186125530")]
	private void PEHMIECGHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x61253D0", Offset = "0x61241D0", VA = "0x1861253D0")]
	public bool OKJMGNAJFFA(CAAMDEKPJPK PDCBMAPDAEE, Transform NBCGMJPEDEM, float GIGEGNAEEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x61255F0", Offset = "0x61243F0", VA = "0x1861255F0")]
	public void PNFBINMMEFI(CAAMDEKPJPK PDCBMAPDAEE, float GIGEGNAEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6125320", Offset = "0x6124120", VA = "0x186125320")]
	public void MPDLALDALGP(CAAMDEKPJPK PDCBMAPDAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6125080", Offset = "0x6123E80", VA = "0x186125080", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ABCABMPBMEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MGPLABDHAAM HOEPGDMFNPH();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface ILEONJPNKME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 KODDFNIBEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int ELCABDHJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int GEHBAEEJLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> AEKKFHEKCOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> ECAMAJBPDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> NALALLDGJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> HCPIAIIJKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> DCIAHDFEGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> NCJNPJHNKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int JMCKCJFGLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int BCKAPJOJCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int PPEIEMOLHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool CGKOILKFKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NACCHJFGBAB();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GDGMBGHIPLK : ILEONJPNKME, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private ABCABMPBMEF LOILFCHKLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private MGPLABDHAAM HCHDFAPIGCD;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 KODDFNIBEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x825D70", Offset = "0x824B70", VA = "0x180825D70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x825DE0", Offset = "0x824BE0", VA = "0x180825DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool IHBBJLAIIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA40", Offset = "0x7BD840", VA = "0x1807BEA40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int ELCABDHJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A10", Offset = "0x7F7810", VA = "0x1807F8A10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7F8010", Offset = "0x7F6E10", VA = "0x1807F8010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int GEHBAEEJLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C24B0", Offset = "0x7C12B0", VA = "0x1807C24B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7C24D0", Offset = "0x7C12D0", VA = "0x1807C24D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int LNIEJCMIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5C0", Offset = "0x9BB3C0", VA = "0x1809BC5C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> AEKKFHEKCOP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6125DC0", Offset = "0x6124BC0", VA = "0x186125DC0", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> ECAMAJBPDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6125D60", Offset = "0x6124B60", VA = "0x186125D60", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> NALALLDGJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6125C00", Offset = "0x6124A00", VA = "0x186125C00", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> HCPIAIIJKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6125CF0", Offset = "0x6124AF0", VA = "0x186125CF0", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> DCIAHDFEGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6125F40", Offset = "0x6124D40", VA = "0x186125F40", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> NCJNPJHNKKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6125CC0", Offset = "0x6124AC0", VA = "0x186125CC0", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CGKOILKFKNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x864240", Offset = "0x863040", VA = "0x180864240", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x91FAF0", Offset = "0x91E8F0", VA = "0x18091FAF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int JMCKCJFGLHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6125D90", Offset = "0x6124B90", VA = "0x186125D90", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int BCKAPJOJCGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6125BE0", Offset = "0x61249E0", VA = "0x186125BE0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int PPEIEMOLHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6125DA0", Offset = "0x6124BA0", VA = "0x186125DA0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6125F70", Offset = "0x6124D70", VA = "0x186125F70")]
	public GDGMBGHIPLK(Hash128 EJDCHNKDADM, ABCABMPBMEF LOILFCHKLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6125E30", Offset = "0x6124C30", VA = "0x186125E30", Slot = "16")]
	public void NACCHJFGBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6125C30", Offset = "0x6124A30", VA = "0x186125C30", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct CAAMDEKPJPK : IEquatable<CAAMDEKPJPK>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly CAAMDEKPJPK LCPFPBICDEC;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int LNBHMBDGGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFA0", Offset = "0x8E9DA0", VA = "0x1808EAFA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8E9D70", VA = "0x1808EAF70")]
	public CAAMDEKPJPK(int OHINPGIGDNE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x61238F0", Offset = "0x61226F0", VA = "0x1861238F0", Slot = "4")]
	public bool Equals(CAAMDEKPJPK EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6123940", Offset = "0x6122740", VA = "0x186123940", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6123A10", Offset = "0x6122810", VA = "0x186123A10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MEPCBMAFFIJ : KKIIEIBPKJP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool HAMHOFOFNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private ILEONJPNKME JGJDHJIAPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<CAAMDEKPJPK> IIBBHAFHOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<CAAMDEKPJPK> MNGNNADOBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<CAAMDEKPJPK> DCKJNDABDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> PIGPPLKDABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int BHKPNGHCBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int LNKPNAAAPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int APMLHPIPKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int GADFPJIJBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int AAHIOJMCEPN;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int LNBHMBDGGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6128E50", Offset = "0x6127C50", VA = "0x186128E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6127E00", Offset = "0x6126C00", VA = "0x186127E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool FHDJKLBKMGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x80B180", Offset = "0x809F80", VA = "0x18080B180")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x855620", Offset = "0x854420", VA = "0x180855620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool MBFCMEPKAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA08F10", Offset = "0xA07D10", VA = "0x180A08F10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA08F90", Offset = "0xA07D90", VA = "0x180A08F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool GINNHHKIOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7D4310", Offset = "0x7D3110", VA = "0x1807D4310", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool KODEICHACDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x172CAB0", Offset = "0x172B8B0", VA = "0x18172CAB0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x172CB10", Offset = "0x172B910", VA = "0x18172CB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float BNMOEMFPBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1ABABA0", Offset = "0x1AB99A0", VA = "0x181ABABA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1ABAB90", Offset = "0x1AB9990", VA = "0x181ABAB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6129730", Offset = "0x6128530", VA = "0x186129730")]
	public MEPCBMAFFIJ(ILEONJPNKME HCHDFAPIGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6129250", Offset = "0x6128050", VA = "0x186129250")]
	private void MJFAGANKAHM(ILEONJPNKME HCHDFAPIGCD, int BHKPNGHCBGD, int AFCPHDAADAI, int OHINPGIGDNE, int NBAJCDHDHOH, MMNLDBHHONC EEDANCJJEPL, float ENGPDBOCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6128F00", Offset = "0x6127D00", VA = "0x186128F00")]
	private void JHOGJNEGGCP(ILEONJPNKME HCHDFAPIGCD, int JMMGCADBNDA, int OHINPGIGDNE, uint3 NCPOBKBAEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6127B60", Offset = "0x6126960", VA = "0x186127B60")]
	private bool ECCAMHLKJJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x61284B0", Offset = "0x61272B0", VA = "0x1861284B0", Slot = "4")]
	public bool GALNLGNAACN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x61291D0", Offset = "0x6127FD0", VA = "0x1861291D0", Slot = "5")]
	public bool LAGHJNJIPJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6127E40", Offset = "0x6126C40", VA = "0x186127E40", Slot = "6")]
	public void FIJOKOAGLFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6127B00", Offset = "0x6126900", VA = "0x186127B00")]
	public void AGAOBPMODDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6127B00", Offset = "0x6126900", VA = "0x186127B00", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KKIIEIBPKJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool GINNHHKIOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool KODEICHACDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GALNLGNAACN();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LAGHJNJIPJP();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FIJOKOAGLFM();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ODFJNJLLMEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float PKJHCFBBPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, MEPCBMAFFIJ> BBMENAIOMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, KPNAODJMOIJ> CMGHIIICJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<KKIIEIBPKJP> NCIAOJBHAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<KKIIEIBPKJP> ENMDGPIGAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<KKIIEIBPKJP> JOIAJPPONFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int CBAKPODBJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int NAHIHMNDCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float MCMGPCDKEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool IHMINNBEBOL;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool GCFABOKFGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xC0FCA0", Offset = "0xC0EAA0", VA = "0x180C0FCA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xC45300", Offset = "0xC44100", VA = "0x180C45300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool GMIJGIJIMHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x612AD00", Offset = "0x6129B00", VA = "0x18612AD00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string BIACHEPDLMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x612A2D0", Offset = "0x61290D0", VA = "0x18612A2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x612ADD0", Offset = "0x6129BD0", VA = "0x18612ADD0")]
	public void KLMJDEJJMPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x612AD50", Offset = "0x6129B50", VA = "0x18612AD50")]
	public void IKKJCOGOLPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x612B430", Offset = "0x612A230", VA = "0x18612B430")]
	public ODFJNJLLMEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x612ABD0", Offset = "0x61299D0", VA = "0x18612ABD0")]
	public EDKIIFNJLJO GGPDGFKFIKF(JLNKKJGOOFJ DIPPNLOGDJL, bool GNLKADHKFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x612A7A0", Offset = "0x61295A0", VA = "0x18612A7A0")]
	public KPNAODJMOIJ GGPDGFKFIKF(EIMODFBDHPI NLKDDMHEDOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x612AD60", Offset = "0x6129B60", VA = "0x18612AD60")]
	public bool KLGJPIMBLAK(Hash128 FJIJLBIGEAH, [Out] MEPCBMAFFIJ BOANEEPKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x612A8E0", Offset = "0x61296E0", VA = "0x18612A8E0")]
	public MEPCBMAFFIJ GGPDGFKFIKF(ILEONJPNKME HCHDFAPIGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x612A780", Offset = "0x6129580", VA = "0x18612A780")]
	private void FIGEGAGBBPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x612ADE0", Offset = "0x6129BE0", VA = "0x18612ADE0")]
	private bool KMINBFPLNHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x612AE70", Offset = "0x6129C70", VA = "0x18612AE70")]
	public void NACCHJFGBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x612A670", Offset = "0x6129470", VA = "0x18612A670", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x612B340", Offset = "0x612A140", VA = "0x18612B340")]
	public void OGPDBPOFINK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NMLNDOHPIPG : JEBDOMCNABA<OOGCDIIJMHO, OOGCDIIJMHO>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6129950", Offset = "0x6128750", VA = "0x186129950")]
	public NMLNDOHPIPG(int DFIMKABDJIK, int FAMNMNJIEOM, ComputeShader LAINNPHPOAE, int APFCMELPKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FMHKJBJDOKJ : JEBDOMCNABA<CAIFGPJGBFB, CAIFGPJGBFB>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6125B30", Offset = "0x6124930", VA = "0x186125B30")]
	public FMHKJBJDOKJ(int DFIMKABDJIK, int FAMNMNJIEOM, ComputeShader LAINNPHPOAE, int APFCMELPKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IBDGLNOHMOC : JEBDOMCNABA<FJJGDPLBJAF, FJJGDPLBJAF>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6126160", Offset = "0x6124F60", VA = "0x186126160")]
	public IBDGLNOHMOC(int DFIMKABDJIK, int FAMNMNJIEOM, ComputeShader LAINNPHPOAE, int APFCMELPKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class CEJFGJDGMHI : JEBDOMCNABA<ALCFAMOGPLE, OPANAAHKHNP>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6123AD0", Offset = "0x61228D0", VA = "0x186123AD0")]
	public CEJFGJDGMHI(int DFIMKABDJIK, int FAMNMNJIEOM, ComputeShader LAINNPHPOAE, int APFCMELPKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class MGBPFGBMAJJ : JEBDOMCNABA<LENGEDGJKLI, LENGEDGJKLI>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x61298A0", Offset = "0x61286A0", VA = "0x1861298A0")]
	public MGBPFGBMAJJ(int DFIMKABDJIK, int FAMNMNJIEOM, ComputeShader LAINNPHPOAE, int APFCMELPKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class AMELFPBOPFN : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private PEFCIKMDFJJ DCHDDNMMGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool IBCOHIKFCFK;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool DFBBBCJDEHG;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x61236F0", Offset = "0x61224F0", VA = "0x1861236F0")]
	public AMELFPBOPFN(PEFCIKMDFJJ PICMFIOMLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6123560", Offset = "0x6122360", VA = "0x186123560", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer BHOCKOPMBEI, RenderingData KNAJILBBHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x61232F0", Offset = "0x61220F0", VA = "0x1861232F0", Slot = "6")]
	public override void Configure(CommandBuffer BHOCKOPMBEI, RenderTextureDescriptor HJIPNJLMGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6123330", Offset = "0x6122130", VA = "0x186123330", Slot = "9")]
	public override void Execute(ScriptableRenderContext KMABAKEMFMI, RenderingData KNAJILBBHIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class AJFJHAAEJIH
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct BDIDOGNCPAF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string OCCHBLONHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer BHOCKOPMBEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext KMABAKEMFMI;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x61237E0", Offset = "0x61225E0", VA = "0x1861237E0")]
		public BDIDOGNCPAF(string KAABGPHHGLD, ScriptableRenderContext BNKEIKIDOHD, [Out] CommandBuffer BODPOACFBGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6123730", Offset = "0x6122530", VA = "0x186123730", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6122F70", Offset = "0x6121D70", VA = "0x186122F70")]
	public static bool NNNJAFPAJHA(RenderingData KNAJILBBHIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6122DD0", Offset = "0x6121BD0", VA = "0x186122DD0")]
	public static void JMJIPHECMGB(CommandBuffer BHOCKOPMBEI, ScriptableRenderContext KMABAKEMFMI, ShadowDrawingSettings IICNKBNFHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x61230C0", Offset = "0x6121EC0", VA = "0x1861230C0")]
	public static void OMJMNAPHCNF(CommandBuffer BHOCKOPMBEI, ScriptableRenderContext KMABAKEMFMI, RenderingData KNAJILBBHIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class PEFCIKMDFJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class AFAJDPNNCPF
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int IDIMAOOLLGC;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int GMPOCGPMKPL;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static EIBCKFJELBE<GPHGNCCFDBA> NKOOMNHJLIP;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static EIBCKFJELBE<uint> IDHMJKNKFJG;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static DEDEHKJJJNH NHAOKHLBHHH;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer PHOOLBFFAPN;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<PEBKANHFEEF> BOJBOGKNIGN;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int MGBIGNMBFCE;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int HIJDAOHKKII;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int NFJGNNAFMML;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int GMADLMLGKFG;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] GAJNFJMAIDA;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] IGIEOJKEHEJ;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static CEJNEOONALM[][] ABNLJOEKMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] EHMFFBFEGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int DNOOHIFEACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int JNADNCKIHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int KKEHAHMEIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int BGJAEGPMPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int NCMKPMGAEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int LKILAPBKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int JIHEPIMLAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int BHDCKAMKMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int AJEMJPKBBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int HNIACAJNDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int PGEHOBIAGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int EGALKEMOMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int LAAHGEIDFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int NBENCDKLDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int AFIFBNJNIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int NBNOINJMNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int NMPGFKAPEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int DPBFBDDPJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] PGFIDECBNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private ODFJNJLLMEB LDGCBKGLBEK;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool CNNBPCHDKBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x612DE20", Offset = "0x612CC20", VA = "0x18612DE20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6130920", Offset = "0x612F720", VA = "0x186130920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool PPAGBDAIKHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x612DB40", Offset = "0x612C940", VA = "0x18612DB40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x612C060", Offset = "0x612AE60", VA = "0x18612C060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData LBOALCIJNPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x612EAF0", Offset = "0x612D8F0", VA = "0x18612EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6132E70", Offset = "0x6131C70", VA = "0x186132E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static ENIJIJCLLPC LBKLOCCALND
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6132EE0", Offset = "0x6131CE0", VA = "0x186132EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x612DAD0", Offset = "0x612C8D0", VA = "0x18612DAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static NMLNDOHPIPG IFPJADABNPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6131A30", Offset = "0x6130830", VA = "0x186131A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x61320C0", Offset = "0x6130EC0", VA = "0x1861320C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static FMHKJBJDOKJ HEFPFEPPHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x612C8E0", Offset = "0x612B6E0", VA = "0x18612C8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6132130", Offset = "0x6130F30", VA = "0x186132130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static IBDGLNOHMOC AOABNMNMMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x612C010", Offset = "0x612AE10", VA = "0x18612C010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x612DBE0", Offset = "0x612C9E0", VA = "0x18612DBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static CEJFGJDGMHI ACNJIFPCOJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x612E490", Offset = "0x612D290", VA = "0x18612E490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x612C0C0", Offset = "0x612AEC0", VA = "0x18612C0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static MGBPFGBMAJJ OEGMDIIPOBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x612C800", Offset = "0x612B600", VA = "0x18612C800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x612C860", Offset = "0x612B660", VA = "0x18612C860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material MIMHGOFBOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x612E3B0", Offset = "0x612D1B0", VA = "0x18612E3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x612E410", Offset = "0x612D210", VA = "0x18612E410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material PPFCADJCAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x612C930", Offset = "0x612B730", VA = "0x18612C930")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x612C990", Offset = "0x612B790", VA = "0x18612C990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material EMDDHDDINKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x612BFB0", Offset = "0x612ADB0", VA = "0x18612BFB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6131A80", Offset = "0x6130880", VA = "0x186131A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material CAMJMHDIOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x612F4A0", Offset = "0x612E2A0", VA = "0x18612F4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6130980", Offset = "0x612F780", VA = "0x186130980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool PJOOELKGAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x612E2F0", Offset = "0x612D0F0", VA = "0x18612E2F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x612E350", Offset = "0x612D150", VA = "0x18612E350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool GMIJGIJIMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x612F440", Offset = "0x612E240", VA = "0x18612F440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string BIACHEPDLMA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x612C140", Offset = "0x612AF40", VA = "0x18612C140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6132FD0", Offset = "0x6131DD0", VA = "0x186132FD0")]
	internal PEFCIKMDFJJ([Optional] MClusterData CHKMIMNMCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x612F500", Offset = "0x612E300", VA = "0x18612F500")]
	public void KCJBJGBIMAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6130E00", Offset = "0x612FC00", VA = "0x186130E00")]
	public void MEEJCPECOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x61321A0", Offset = "0x6130FA0", VA = "0x1861321A0")]
	public void PDELIIKJNAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x612E4F0", Offset = "0x612D2F0", VA = "0x18612E4F0")]
	public bool HJBFFIMMAMH(Hash128 EJDCHNKDADM, [Out] MEPCBMAFFIJ HCHDFAPIGCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x612DE70", Offset = "0x612CC70", VA = "0x18612DE70")]
	public MEPCBMAFFIJ GGPDGFKFIKF(ILEONJPNKME EEDANCJJEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x612E0F0", Offset = "0x612CEF0", VA = "0x18612E0F0")]
	public KPNAODJMOIJ GGPDGFKFIKF(EIMODFBDHPI NLKDDMHEDOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x612DF30", Offset = "0x612CD30", VA = "0x18612DF30")]
	public EDKIIFNJLJO GGPDGFKFIKF(JLNKKJGOOFJ DIPPNLOGDJL, bool GNLKADHKFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x612DB90", Offset = "0x612C990", VA = "0x18612DB90")]
	public void FIJOKOAGLFM(KKIIEIBPKJP BNOKDAFJOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6131940", Offset = "0x6130740", VA = "0x186131940")]
	public static void NGDIOGECLLP(JHOMLMCJIEL JPKFLBLKANP, CEJNEOONALM[] EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x612EB40", Offset = "0x612D940", VA = "0x18612EB40")]
	private void IALFHJNCKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x61321B0", Offset = "0x6130FB0", VA = "0x1861321B0")]
	private static void PEOMDDGMGJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6130A00", Offset = "0x612F800", VA = "0x186130A00")]
	public void LJIMPNENPDE(CommandBuffer BHOCKOPMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x612DC50", Offset = "0x612CA50", VA = "0x18612DC50")]
	public void GAFPKNJOEGF([Optional] ScriptableRenderContext? KMABAKEMFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6131DE0", Offset = "0x6130BE0", VA = "0x186131DE0")]
	public void OAJEOJDMAHJ(CommandBuffer BHOCKOPMBEI, ShadowSplitData EFHAHCAMJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6131B00", Offset = "0x6130900", VA = "0x186131B00")]
	public void OAJEOJDMAHJ(CommandBuffer BHOCKOPMBEI, CameraData CPDPHLKGIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x612E590", Offset = "0x612D390", VA = "0x18612E590")]
	public void HMHBKPMDNNF(CommandBuffer BHOCKOPMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x61308B0", Offset = "0x612F6B0", VA = "0x1861308B0")]
	public void KCMLOFGGGBD(CommandBuffer BHOCKOPMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x61314A0", Offset = "0x61302A0", VA = "0x1861314A0")]
	public void MPKIELMBFPP(CommandBuffer BHOCKOPMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6130EA0", Offset = "0x612FCA0", VA = "0x186130EA0")]
	public void MJNMBPKGHFJ(CommandBuffer BHOCKOPMBEI, JHOMLMCJIEL MGMBDNFEBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6130D20", Offset = "0x612FB20", VA = "0x186130D20")]
	public void LOFACEFHJFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x612CA10", Offset = "0x612B810", VA = "0x18612CA10")]
	public void COJAMHJFIEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x612D9C0", Offset = "0x612C7C0", VA = "0x18612D9C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KDCDMFKIDCB
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1D2A500", Offset = "0x1D29300", VA = "0x181D2A500")]
	public static int BJONMIBFGEC(int GKGOKFIMAIP, int JAGMCHMGLHO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct LPMNJGJHJJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 FPDFNDPDACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 JLKCJHNNMAA;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly LPMNJGJHJJP PKKGCHCGBAA;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly LPMNJGJHJJP LCPFPBICDEC;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6127160", Offset = "0x6125F60", VA = "0x186127160")]
	public LPMNJGJHJJP(float4x4 JIGIHFGMJBC, float4 OGICJBNEIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6126FF0", Offset = "0x6125DF0", VA = "0x186126FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct MMNLDBHHONC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 AJFNKFFNDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 BKELBBDDNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 KFMPINIBKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 FJFOBKGAGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 PEPPBEDAKDD;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct LCPEMGJIICP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 AJFNKFFNDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 BKELBBDDNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 KFMPINIBKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 FJFOBKGAGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 PEPPBEDAKDD;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct OPANAAHKHNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public LCPEMGJIICP LGOGPPMDOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public LCPEMGJIICP DANBJJIJKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public LCPEMGJIICP CEGHMJBPMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public LCPEMGJIICP FKBMFDHELHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public LCPEMGJIICP BGEDIEEDIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public LCPEMGJIICP LGECBPAPJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public LCPEMGJIICP DMHGLHBBPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public LCPEMGJIICP NBBFINJIDAG;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct ALCFAMOGPLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public MMNLDBHHONC LGOGPPMDOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public MMNLDBHHONC DANBJJIJKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public MMNLDBHHONC CEGHMJBPMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public MMNLDBHHONC FKBMFDHELHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public MMNLDBHHONC BGEDIEEDIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public MMNLDBHHONC LGECBPAPJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public MMNLDBHHONC DMHGLHBBPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public MMNLDBHHONC NBBFINJIDAG;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct CAIFGPJGBFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 FIDJPCHABMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint CJBPDIIPDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint CEAMMMGHHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float HHGICAOMHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint BLLMFOGGFLK;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6123AA0", Offset = "0x61228A0", VA = "0x186123AA0")]
	public CAIFGPJGBFB(EIMODFBDHPI NLKDDMHEDOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct GPHGNCCFDBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint BMLAAIJKLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint GABNIBJGJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint NBAJCDHDHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint BLLMFOGGFLK;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6126030", Offset = "0x6124E30", VA = "0x186126030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct FJJGDPLBJAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint AFCPHDAADAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint NLEIGLCHCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint LNKPNAAAPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint BLLMFOGGFLK;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6125A80", Offset = "0x6124880", VA = "0x186125A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct OOGCDIIJMHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint JKHHINIAGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint ACKPHBBHHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint GMOILENIGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint GAFAOEHLEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint DLMIPGEBHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint EMAKIALDIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint FLILEECJNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint BLLMFOGGFLK;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x612BC80", Offset = "0x612AA80", VA = "0x18612BC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct LENGEDGJKLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 ALHDKOLGKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 NHLLOEECHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 LBOHHJAIIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 JGMDGKCDGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 JKNNLEDFDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 KJPNHOAKOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 PNDMNJDKGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 LDAJOBJEMCJ;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6126A30", Offset = "0x6125830", VA = "0x186126A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum JHOMLMCJIEL
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
