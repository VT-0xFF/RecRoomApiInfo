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
public struct AOJEKPEFKEA
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] GHAPJLAOLMO;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] INEKCMBJJIM;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] LEBOLKLEOLD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xBB96B0", Offset = "0xBB7EB0", VA = "0x180BB96B0")]
	public static int NDFJDEMHNGF(FMDGLNDFBOC FIIIJAPNPGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D05F10", Offset = "0x5D04710", VA = "0x185D05F10")]
	public static int GAPGENAMOEM(FMDGLNDFBOC FIIIJAPNPGF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DPBBDDFMAIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int CFJAPJHKODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MEFLACHKCLE IPAPHJDHOEA(int IPDIEBPGLHC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 KKGHDJAMOPL(int IPDIEBPGLHC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DJDIIJGKINF EBJNEOCPDGN();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EBDFOAOLNLD HGHDCPCGHGG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BHPOOINBLLN : HDPEAPHMMIO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private DJDIIJGKINF CPMBJLDHCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform DODFPAAOCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<DCDOACHIFPL> JPEGGAAIELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private MLJBLBJMFFG GHNNIDFBAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private NLABOIOEICF GJPBBCLEFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool BGHFHLCBOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private DPBBDDFMAIJ FLBINPNNKCH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float CMKFDPPFKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x803010", Offset = "0x801810", VA = "0x180803010")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA0BAA0", Offset = "0xA0A2A0", VA = "0x180A0BAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LMBMJEINFCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x802FF0", Offset = "0x8017F0", VA = "0x180802FF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAED7F0", Offset = "0xAEBFF0", VA = "0x180AED7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool CGFJIILJOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7AEF00", Offset = "0x7AD700", VA = "0x1807AEF00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE810", Offset = "0x7AD010", VA = "0x1807AE810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool FEAHJNJLDMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D06730", Offset = "0x5D04F30", VA = "0x185D06730", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5D075A0", Offset = "0x5D05DA0", VA = "0x185D075A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GCCBIPKFFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x102F9E0", Offset = "0x102E1E0", VA = "0x18102F9E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D079B0", Offset = "0x5D061B0", VA = "0x185D079B0")]
	public BHPOOINBLLN(DPBBDDFMAIJ EEILNADBKNP, bool ABLBBINGODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D07380", Offset = "0x5D05B80", VA = "0x185D07380")]
	private bool GOBBBDCFFLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D06740", Offset = "0x5D04F40", VA = "0x185D06740", Slot = "4")]
	public bool BONJGFNEKBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D075B0", Offset = "0x5D05DB0", VA = "0x185D075B0", Slot = "5")]
	public bool IDAKBLNHKFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D07780", Offset = "0x5D05F80", VA = "0x185D07780", Slot = "6")]
	public void PJFBCFIPABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D07370", Offset = "0x5D05B70", VA = "0x185D07370", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GCBLEDFGOAB
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFGGLKDAOFE(CommandBuffer MLIEFBBOMEM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct DICADMALFKB : GCBLEDFGOAB
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int KFOGLCOKPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x98FA80", Offset = "0x98E280", VA = "0x18098FA80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier MFLELPAKFAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x38FFDB0", Offset = "0x38FE5B0", VA = "0x1838FFDB0")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D09D00", Offset = "0x5D08500", VA = "0x185D09D00")]
	public DICADMALFKB(int NENKFFLNHCE, RenderTargetIdentifier AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D09CB0", Offset = "0x5D084B0", VA = "0x185D09CB0", Slot = "4")]
	public void GFGGLKDAOFE(CommandBuffer MLIEFBBOMEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct KKDLPODLKAI : GCBLEDFGOAB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int KFOGLCOKPDN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x98FA80", Offset = "0x98E280", VA = "0x18098FA80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] FEDNFEDGLBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x98F9E0", Offset = "0x98E1E0", VA = "0x18098F9E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xAA8750", Offset = "0xAA6F50", VA = "0x180AA8750")]
	public KKDLPODLKAI(int NENKFFLNHCE, Vector4[] AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D13B70", Offset = "0x5D12370", VA = "0x185D13B70", Slot = "4")]
	public void GFGGLKDAOFE(CommandBuffer MLIEFBBOMEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct AJMCFFBCMNP : GCBLEDFGOAB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int KFOGLCOKPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x98FA80", Offset = "0x98E280", VA = "0x18098FA80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] LELOKMDAEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x98F9E0", Offset = "0x98E1E0", VA = "0x18098F9E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xAA8750", Offset = "0xAA6F50", VA = "0x180AA8750")]
	public AJMCFFBCMNP(int NENKFFLNHCE, float[] AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D055B0", Offset = "0x5D03DB0", VA = "0x185D055B0", Slot = "4")]
	public void GFGGLKDAOFE(CommandBuffer MLIEFBBOMEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct POGNALPBPMC : GCBLEDFGOAB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string MBENGICGPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA60A0", VA = "0x180AA78A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool CFNCBLLJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x17656F0", Offset = "0x1763EF0", VA = "0x1817656F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x352B010", Offset = "0x3529810", VA = "0x18352B010")]
	public POGNALPBPMC(string HNHMJGCODBA, bool PLMDMDMKAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D15A60", Offset = "0x5D14260", VA = "0x185D15A60", Slot = "4")]
	public void GFGGLKDAOFE(CommandBuffer MLIEFBBOMEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct EBDFOAOLNLD
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 DBHEFBINCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 PCLMAMNOFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int OJHFGOMKDDH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80C100", Offset = "0x80A900", VA = "0x18080C100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OODNLFHNBJH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7A3620", Offset = "0x7A1E20", VA = "0x1807A3620")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float LPDNHCHFJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B7DF0", Offset = "0x7B65F0", VA = "0x1807B7DF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A1F0", Offset = "0x5D089F0", VA = "0x185D0A1F0")]
	public EBDFOAOLNLD(Color MOJKBHCPNEF, int LCABJGDLPMK, int JIBGFHDMIBK, float ECEOOALIDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x52F0200", Offset = "0x52EEA00", VA = "0x1852F0200")]
	private static float4 PDKCADOBCKL(Color MOJKBHCPNEF)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A160", Offset = "0x5D08960", VA = "0x185D0A160")]
	private static Hash128 NNHKAJKLGOJ(EBDFOAOLNLD EEILNADBKNP)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MLJBLBJMFFG : HDPEAPHMMIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string PFKGDKJFPOD;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string AEHNDLCAPOF;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string BNJPMGONNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private EBDFOAOLNLD NKNIPMNMHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private AJJKOEIEJBD JGLFCCBLACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 LPHMOHDCHPB;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NLABOIOEICF GHBPCJNHEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x78A1F0", Offset = "0x7889F0", VA = "0x18078A1F0")]
		[CompilerGenerated]
		get
		{
			return default(NLABOIOEICF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x80CFE0", Offset = "0x80B7E0", VA = "0x18080CFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool LMBMJEINFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1904020", Offset = "0x1902820", VA = "0x181904020")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1904190", Offset = "0x1902990", VA = "0x181904190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool CGFJIILJOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1904F00", Offset = "0x1903700", VA = "0x181904F00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1904EF0", Offset = "0x19036F0", VA = "0x181904EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GCCBIPKFFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool FEAHJNJLDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4F4BE80", Offset = "0x4F4A680", VA = "0x184F4BE80", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5B432F0", Offset = "0x5B41AF0", VA = "0x185B432F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int NEMCGPAIDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5D14E70", Offset = "0x5D13670", VA = "0x185D14E70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D15100", Offset = "0x5D13900", VA = "0x185D15100")]
	public MLJBLBJMFFG(EBDFOAOLNLD NCALCHHIFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D14BB0", Offset = "0x5D133B0", VA = "0x185D14BB0")]
	private bool GOBBBDCFFLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D14A60", Offset = "0x5D13260", VA = "0x185D14A60", Slot = "4")]
	public bool BONJGFNEKBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D14EC0", Offset = "0x5D136C0", VA = "0x185D14EC0")]
	private static AJJKOEIEJBD NOJDKFNJDDB(EBDFOAOLNLD EEILNADBKNP)
	{
		return default(AJJKOEIEJBD);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D14CC0", Offset = "0x5D134C0", VA = "0x185D14CC0", Slot = "5")]
	public bool IDAKBLNHKFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D14F00", Offset = "0x5D13700", VA = "0x185D14F00", Slot = "6")]
	public void PJFBCFIPABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5D140F0", Offset = "0x5D128F0", VA = "0x185D140F0", Slot = "0")]
		public override bool Equals(object IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5D142F0", Offset = "0x5D12AF0", VA = "0x185D142F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x848550", Offset = "0x846D50", VA = "0x180848550")]
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
		private DPMNOEDHOPH opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static EIPBDBOOKLA CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5D149C0", Offset = "0x5D131C0", VA = "0x185D149C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5D14A00", Offset = "0x5D13200", VA = "0x185D14A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5D143D0", Offset = "0x5D12BD0", VA = "0x185D143D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5D143A0", Offset = "0x5D12BA0", VA = "0x185D143A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DKCPICJJNNM, RenderingData BJECLCEBAHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5D14830", Offset = "0x5D13030", VA = "0x185D14830")]
		public void PIOJLBHNDBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xAB9760", Offset = "0xAB7F60", VA = "0x180AB9760")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JELDNOPFEEL<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GOMOPPJAKLP FKMGDKFLLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private GOMOPPJAKLP FPBBAPBCKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer IBCIIGJBCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture DMFHHHHOBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int AMOPEKKBDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int HEGIJNHBGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string HCBFLAECALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string KNCANEAOJBE;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x766100", Offset = "0x764900", VA = "0x180766100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int BKGLMOKCJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xADFDB0", Offset = "0xADE5B0", VA = "0x180ADFDB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int CKBJFELMENH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x780BE0", Offset = "0x77F3E0", VA = "0x180780BE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x37EC9A0", Offset = "0x37EB1A0", VA = "0x1837EC9A0")]
	public JELDNOPFEEL(string HNHMJGCODBA, int BHNLOLKMCCP, [Optional] RenderTextureFormat? KDEPONGBNBL, bool BLINDJIPIEO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x37EB760", Offset = "0x37E9F60", VA = "0x1837EB760")]
	public void IDAKBLNHKFP(CommandBuffer MLIEFBBOMEM, NativeArray<ValType> AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x37EC190", Offset = "0x37EA990", VA = "0x1837EC190")]
	public void JCFONBDICON(CommandBuffer MLIEFBBOMEM, ComputeShader EHKBJFIHLGK, int LGFPCDLINHG, int DHGKJLGLGHE = -1, int HLPLGMLNFDN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x37EBC40", Offset = "0x37EA440", VA = "0x1837EBC40")]
	public void JCFONBDICON(Material JGLFCCBLACF, int DHGKJLGLGHE = -1, int HLPLGMLNFDN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x37EB5B0", Offset = "0x37E9DB0", VA = "0x1837EB5B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OGBACAPEDIM
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JCFONBDICON(Material NCALCHHIFBL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BINGGLPOKIL<SrcEntry, DstEntry> : OGBACAPEDIM, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] NHAHJHJJABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected GOMOPPJAKLP LEKHHOADCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected GOMOPPJAKLP DLDICEMLDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> GCMIFLIGBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> LOHMBAIPDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int OGLIEBHNOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int CIPLELBLOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected JELDNOPFEEL<int> CKJGFFPIKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected JELDNOPFEEL<SrcEntry> HKGDJMGIPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected JELDNOPFEEL<DstEntry> HPFBNKIBFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader GOJGPMNAMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int MEFOADALIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int LMMNPMICHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int HFJGFKNMJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int BDJKGEPGPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int EEAIHPENEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int FGMHKJJOFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int KNCFOPBJKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int EMGEIJCJFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int ABAPPAGBDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int PKMGEGLGLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int OJNIDLBBABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int HBACNEKLLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string JIFGKAKMIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] DMDAHDAHPMP;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int KPFJFCCFJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x43F6C50", Offset = "0x43F5450", VA = "0x1843F6C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string BJFDMNNLNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x43F9660", Offset = "0x43F7E60", VA = "0x1843F9660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x43FB380", Offset = "0x43F9B80", VA = "0x1843FB380")]
	public BINGGLPOKIL(string HNHMJGCODBA, int IKCCLGHGHEI, int HLOJEJBCCDL, RenderTextureFormat KDEPONGBNBL, ComputeShader FBGKJBOALPK, int JAOEHOHHMGD = 0, int GMCHKALDBOM = 0, int FFFPGAMGGIO = 0, int MBEIIDGOKEE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x43F6C60", Offset = "0x43F5460", VA = "0x1843F6C60")]
	public int ALHCKLOGPOJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x43F7690", Offset = "0x43F5E90", VA = "0x1843F7690")]
	protected void CAFJDOMBCFB(int LFEFGCGCIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x43F7080", Offset = "0x43F5880", VA = "0x1843F7080")]
	public NLABOIOEICF BONJGFNEKBE(SrcEntry AELCABDCBDD)
	{
		return default(NLABOIOEICF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x43F8150", Offset = "0x43F6950", VA = "0x1843F8150")]
	public bool IDAKBLNHKFP(NLABOIOEICF KPAMIOKBGLD, SrcEntry AELCABDCBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x43FACE0", Offset = "0x43F94E0", VA = "0x1843FACE0")]
	public bool PJFBCFIPABD(NLABOIOEICF KPAMIOKBGLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "6")]
	protected virtual void FIMDHEMODDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x43F9930", Offset = "0x43F8130", VA = "0x1843F9930", Slot = "7")]
	public void JOJIPDIJLIO(CommandBuffer MLIEFBBOMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x43FA5C0", Offset = "0x43F8DC0", VA = "0x1843FA5C0", Slot = "8")]
	public void JOJIPDIJLIO(CommandBuffer MLIEFBBOMEM, ComputeShader FBGKJBOALPK, int JAOEHOHHMGD = -1, int GMCHKALDBOM = -1, int FFFPGAMGGIO = -1, int MBEIIDGOKEE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x43F86E0", Offset = "0x43F6EE0", VA = "0x1843F86E0", Slot = "9")]
	public void JCFONBDICON(CommandBuffer MLIEFBBOMEM, ComputeShader FBGKJBOALPK, int JAOEHOHHMGD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x43F8690", Offset = "0x43F6E90", VA = "0x1843F8690", Slot = "4")]
	public void JCFONBDICON(Material JGLFCCBLACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x43F77A0", Offset = "0x43F5FA0", VA = "0x1843F77A0", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GOMOPPJAKLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong BOFHHDBMDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong GOBJMEIAPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JBEPFNGHJBL
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct DGLOIOJLOPN : GOMOPPJAKLP, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable PCEBNEKDMGA;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong BOFHHDBMDHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x98F9E0", Offset = "0x98E1E0", VA = "0x18098F9E0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x55A10A0", Offset = "0x559F8A0", VA = "0x1855A10A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong GOBJMEIAPPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1153320", Offset = "0x1151B20", VA = "0x181153320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5D09C70", Offset = "0x5D08470", VA = "0x185D09C70")]
		internal DGLOIOJLOPN(IDisposable MDOOPIKLIGM, ulong PHCLPCMNHKE, ulong BPHDANCBOOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5D09BF0", Offset = "0x5D083F0", VA = "0x185D09BF0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct KKHEAIFLEBH : GOMOPPJAKLP, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture EAPHMKPOEJP;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong BOFHHDBMDHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x98F9E0", Offset = "0x98E1E0", VA = "0x18098F9E0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x55A10A0", Offset = "0x559F8A0", VA = "0x1855A10A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong GOBJMEIAPPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1153320", Offset = "0x1151B20", VA = "0x181153320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5D13C40", Offset = "0x5D12440", VA = "0x185D13C40")]
		public KKHEAIFLEBH(RenderTexture IKALEMLLIEF, ulong LMLGBECJBEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5D13BA0", Offset = "0x5D123A0", VA = "0x185D13BA0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong LLBCMHDPPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5D13420", Offset = "0x5D11C20", VA = "0x185D13420")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5D132A0", Offset = "0x5D11AA0", VA = "0x185D132A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong KFLONEOEJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5D133E0", Offset = "0x5D11BE0", VA = "0x185D133E0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5D139E0", Offset = "0x5D121E0", VA = "0x185D139E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5D13460", Offset = "0x5D11C60", VA = "0x185D13460")]
	public static ComputeBuffer KLKFANDJKFE(int EHGKBCBKPCI, int DOPOMDBAFJP, ComputeBufferType GFGNPBCFEMC, [Out] GOMOPPJAKLP KPAMIOKBGLD, ComputeBufferMode FDFIAAFCBPI = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5D13640", Offset = "0x5D11E40", VA = "0x185D13640")]
	public static RenderTexture KLKFANDJKFE(int ICNNOLEOCCJ, int DCJFLHGCAJC, int IGMBNCEJALG, RenderTextureFormat KDEPONGBNBL, [Out] GOMOPPJAKLP KPAMIOKBGLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x23BC2E0", Offset = "0x23BAAE0", VA = "0x1823BC2E0")]
	public static NativeArray<T> DEMONMNBAPA<T>(NativeArray<T> PCEBNEKDMGA, ulong HPFMIMMLOKB, [Out] GOMOPPJAKLP KPAMIOKBGLD) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x23BD140", Offset = "0x23BB940", VA = "0x1823BD140")]
	public static NativeArray<T> KLKFANDJKFE<T>(int HPFMIMMLOKB, Allocator JONICLHJBEP, [Out] GOMOPPJAKLP KPAMIOKBGLD, NativeArrayOptions KFCJCCKINNH = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5D13A20", Offset = "0x5D12220", VA = "0x185D13A20")]
	public static void NAKDAJJPGKJ(GOMOPPJAKLP PCEBNEKDMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D132E0", Offset = "0x5D11AE0", VA = "0x185D132E0")]
	public static uint EJPGONHAOKK(RenderTextureFormat KDEPONGBNBL)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AKLKJKBEEPL : BINGGLPOKIL<IBEEHFJGDNG, IBEEHFJGDNG>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct FBCGJPILOHJ : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> DFNMGLPNLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> FGKINPEGBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> EMHELBLFAEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> BJEPPGNKGPN;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5D11810", Offset = "0x5D10010", VA = "0x185D11810")]
		public FBCGJPILOHJ(NativeArray<int> EAGCICBHLJE, NativeArray<float> NHBNEJICMMD, NativeArray<float4x4> BGCMPBONGHP, NativeArray<float4> IACOJBJFIIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5D11650", Offset = "0x5D0FE50", VA = "0x185D11650", Slot = "4")]
		public void Execute(int LFEFGCGCIAG, TransformAccess CPMBJLDHCID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct PLPLFNCIDMJ : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> DFNMGLPNLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> CDMFIEABBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> PCPEFEBAINP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<IBEEHFJGDNG> MGMFGBNBFPA;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5D11810", Offset = "0x5D10010", VA = "0x185D11810")]
		public PLPLFNCIDMJ(NativeArray<int> EAGCICBHLJE, NativeArray<float4x4> EGJFOLFHPHO, NativeArray<float4> GCOFDHOCPAB, NativeArray<IBEEHFJGDNG> HMIAICAALJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5D159F0", Offset = "0x5D141F0", VA = "0x185D159F0", Slot = "4")]
		public void Execute(int LFEFGCGCIAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte GDIOPDHBAJK = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray OKCLCFLOJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> LKEHJBKPMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> CIIMHFOBFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> FPFOEHELILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> DCLGPFKLJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> IMAIHBDFGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private GOMOPPJAKLP OPOODLMPAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private GOMOPPJAKLP JNKFDKENCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private GOMOPPJAKLP JOOODEMAAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private GOMOPPJAKLP EHGGDGEAHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private GOMOPPJAKLP NNHIDFJIKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform HANCHFEEEBL;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5D05C30", Offset = "0x5D04430", VA = "0x185D05C30")]
	public AKLKJKBEEPL(int IKCCLGHGHEI, int HLOJEJBCCDL, ComputeShader FBGKJBOALPK, int JAOEHOHHMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D05740", Offset = "0x5D03F40", VA = "0x185D05740", Slot = "6")]
	protected override void FIMDHEMODDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D055E0", Offset = "0x5D03DE0", VA = "0x185D055E0")]
	private void CJOAKOEHALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D05AD0", Offset = "0x5D042D0", VA = "0x185D05AD0")]
	public bool OLNALAOFDNC(NLABOIOEICF KPAMIOKBGLD, Transform CPMBJLDHCID, float KBPOBPCOPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5D059F0", Offset = "0x5D041F0", VA = "0x185D059F0")]
	public void MBMMBNMKPDJ(NLABOIOEICF KPAMIOKBGLD, float KBPOBPCOPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5D05940", Offset = "0x5D04140", VA = "0x185D05940")]
	public void FJJGHHHKKFG(NLABOIOEICF KPAMIOKBGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D056A0", Offset = "0x5D03EA0", VA = "0x185D056A0", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MEFLACHKCLE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KKLKCKNAHFG ACJKICPGHOE();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HEIDLPPCNAC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 DBHEFBINCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int KBCHBEHIDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int OJAEFINFDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> PFHBDAPBAPI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> PPHPDGDNNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> AMJKDPNEEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> AJIIJFKCKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> OAIIAHGMOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> HPKJKLLCBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int MGHELEHGLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int BDIOAFNAAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int EPGJAKMBLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool FICHIKIAOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JOJIPDIJLIO();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ONHHHMJIKHG : HEIDLPPCNAC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private MEFLACHKCLE DHNINOOIJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private KKLKCKNAHFG LFKHDLANNJG;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 DBHEFBINCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1A61020", Offset = "0x1A5F820", VA = "0x181A61020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool OONBIDJCIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x76E4A0", Offset = "0x76CCA0", VA = "0x18076E4A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int KBCHBEHIDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7A3620", Offset = "0x7A1E20", VA = "0x1807A3620", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7A2CB0", Offset = "0x7A14B0", VA = "0x1807A2CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int OJAEFINFDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x76A240", Offset = "0x768A40", VA = "0x18076A240", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x76A230", Offset = "0x768A30", VA = "0x18076A230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int HAJCLONKPAH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x86FC60", Offset = "0x86E460", VA = "0x18086FC60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> PFHBDAPBAPI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5D155D0", Offset = "0x5D13DD0", VA = "0x185D155D0", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> PPHPDGDNNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5D15700", Offset = "0x5D13F00", VA = "0x185D15700", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> AMJKDPNEEKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5D15730", Offset = "0x5D13F30", VA = "0x185D15730", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> AJIIJFKCKFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5D15560", Offset = "0x5D13D60", VA = "0x185D15560", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> OAIIAHGMOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5D158A0", Offset = "0x5D140A0", VA = "0x185D158A0", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> HPKJKLLCBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5D15760", Offset = "0x5D13F60", VA = "0x185D15760", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool FICHIKIAOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B7C00", Offset = "0x7B6400", VA = "0x1807B7C00", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B8160", Offset = "0x7B6960", VA = "0x1807B8160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int MGHELEHGLJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5D156D0", Offset = "0x5D13ED0", VA = "0x185D156D0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int BDIOAFNAAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D156E0", Offset = "0x5D13EE0", VA = "0x185D156E0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int EPGJAKMBLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D158D0", Offset = "0x5D140D0", VA = "0x185D158D0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D158F0", Offset = "0x5D140F0", VA = "0x185D158F0")]
	public ONHHHMJIKHG(Hash128 JJPJJOLELKC, MEFLACHKCLE DHNINOOIJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D15790", Offset = "0x5D13F90", VA = "0x185D15790", Slot = "16")]
	public void JOJIPDIJLIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D15640", Offset = "0x5D13E40", VA = "0x185D15640", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct NLABOIOEICF : IEquatable<NLABOIOEICF>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly NLABOIOEICF HEADMFFNPAP;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int NEMCGPAIDHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x98FA80", Offset = "0x98E280", VA = "0x18098FA80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F1550", Offset = "0x7EFD50", VA = "0x1807F1550")]
	public NLABOIOEICF(int LFEFGCGCIAG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5D153D0", Offset = "0x5D13BD0", VA = "0x185D153D0", Slot = "4")]
	public bool Equals(NLABOIOEICF IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5D15300", Offset = "0x5D13B00", VA = "0x185D15300", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5D15420", Offset = "0x5D13C20", VA = "0x185D15420", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DCDOACHIFPL : HDPEAPHMMIO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool BGHFHLCBOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private HEIDLPPCNAC IJAHHOGMGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<NLABOIOEICF> ICALIPBNONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<NLABOIOEICF> BKJOFEPFAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<NLABOIOEICF> AGCOMJFAAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> DFBGEBMBKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int MCKDCMEAPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int NBCEJGCLIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int EDGFDANJDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int CGBGCAHONDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int BNBBEGKBHAC;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int NEMCGPAIDHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5D09360", Offset = "0x5D07B60", VA = "0x185D09360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5D09000", Offset = "0x5D07800", VA = "0x185D09000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool LMBMJEINFCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B39F0", Offset = "0x7B21F0", VA = "0x1807B39F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x89BFC0", Offset = "0x89A7C0", VA = "0x18089BFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool CGFJIILJOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9FA110", Offset = "0x9F8910", VA = "0x1809FA110")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9FA120", Offset = "0x9F8920", VA = "0x1809FA120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool GCCBIPKFFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool FEAHJNJLDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1530D10", Offset = "0x152F510", VA = "0x181530D10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1530D00", Offset = "0x152F500", VA = "0x181530D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float CMKFDPPFKPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x19DCC50", Offset = "0x19DB450", VA = "0x1819DCC50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1FF9DD0", Offset = "0x1FF85D0", VA = "0x181FF9DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D09A80", Offset = "0x5D08280", VA = "0x185D09A80")]
	public DCDOACHIFPL(HEIDLPPCNAC LFKHDLANNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5D08AC0", Offset = "0x5D072C0", VA = "0x185D08AC0")]
	private void CFGJMLNODKE(HEIDLPPCNAC LFKHDLANNJG, int MCKDCMEAPDD, int EGHLPPCKEAB, int LFEFGCGCIAG, int PKGENAHBEIL, JCKHKPOJHHK AELCABDCBDD, float NCPIOEMNLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5D07E50", Offset = "0x5D06650", VA = "0x185D07E50")]
	private void BCCPEIKMADH(HEIDLPPCNAC LFKHDLANNJG, int DNIOLEGAMHE, int LFEFGCGCIAG, uint3 GIJOIGDFJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D09040", Offset = "0x5D07840", VA = "0x185D09040")]
	private bool GOBBBDCFFLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5D08120", Offset = "0x5D06920", VA = "0x185D08120", Slot = "4")]
	public bool BONJGFNEKBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5D092E0", Offset = "0x5D07AE0", VA = "0x185D092E0", Slot = "5")]
	public bool IDAKBLNHKFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5D09410", Offset = "0x5D07C10", VA = "0x185D09410", Slot = "6")]
	public void PJFBCFIPABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D08FA0", Offset = "0x5D077A0", VA = "0x185D08FA0")]
	public void EODBEHJNIBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D08FA0", Offset = "0x5D077A0", VA = "0x185D08FA0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HDPEAPHMMIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool GCCBIPKFFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool FEAHJNJLDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BONJGFNEKBE();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IDAKBLNHKFP();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJFBCFIPABD();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IPGOJLNGKFK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float NDJEDCMMEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, DCDOACHIFPL> GJGNEMOCDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, MLJBLBJMFFG> GEFHAGLEEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<HDPEAPHMMIO> DMGHGEBLEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<HDPEAPHMMIO> CFHAJMBPAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<HDPEAPHMMIO> HDFPNDFCHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int NAODICOKDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int OMAGOOOENAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float JPPNDKIIGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool NDJNGOOGOKH;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool BGKDPFJNEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xAE4A00", Offset = "0xAE3200", VA = "0x180AE4A00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xAF1980", Offset = "0xAF0180", VA = "0x180AF1980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool OEAGBDDNMFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D12210", Offset = "0x5D10A10", VA = "0x185D12210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string BJFDMNNLNIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5D12270", Offset = "0x5D10A70", VA = "0x185D12270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5D12260", Offset = "0x5D10A60", VA = "0x185D12260")]
	public void IPCLHIJPFJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5D120F0", Offset = "0x5D108F0", VA = "0x185D120F0")]
	public void COAHOPCCJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D13110", Offset = "0x5D11910", VA = "0x185D13110")]
	public IPGOJLNGKFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5D12F80", Offset = "0x5D11780", VA = "0x185D12F80")]
	public BHPOOINBLLN NJMEIPIEAKJ(DPBBDDFMAIJ IALEADLNNLH, bool ABLBBINGODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5D12B50", Offset = "0x5D11350", VA = "0x185D12B50")]
	public MLJBLBJMFFG NJMEIPIEAKJ(EBDFOAOLNLD JGLFCCBLACF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5D12610", Offset = "0x5D10E10", VA = "0x185D12610")]
	public bool JKINPGNNGHA(Hash128 NENKFFLNHCE, [Out] DCDOACHIFPL OAJGDGNCODC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5D12C90", Offset = "0x5D11490", VA = "0x185D12C90")]
	public DCDOACHIFPL NJMEIPIEAKJ(HEIDLPPCNAC LFKHDLANNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5D130B0", Offset = "0x5D118B0", VA = "0x185D130B0")]
	private void OOJAHBLFLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5D11FB0", Offset = "0x5D107B0", VA = "0x185D11FB0")]
	private bool ANNKEDCJDJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5D12680", Offset = "0x5D10E80", VA = "0x185D12680")]
	public void JOJIPDIJLIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D12100", Offset = "0x5D10900", VA = "0x185D12100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5D12040", Offset = "0x5D10840", VA = "0x185D12040")]
	public void BJEHGEAGFIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EEAGNFMMFMC : BINGGLPOKIL<CFHCNDBLKOL, CFHCNDBLKOL>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A320", Offset = "0x5D08B20", VA = "0x185D0A320")]
	public EEAGNFMMFMC(int IKCCLGHGHEI, int HLOJEJBCCDL, ComputeShader FBGKJBOALPK, int JAOEHOHHMGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HHFBNMPGDEJ : BINGGLPOKIL<AJJKOEIEJBD, AJJKOEIEJBD>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5D11D60", Offset = "0x5D10560", VA = "0x185D11D60")]
	public HHFBNMPGDEJ(int IKCCLGHGHEI, int HLOJEJBCCDL, ComputeShader FBGKJBOALPK, int JAOEHOHHMGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BHEBOMMCGAO : BINGGLPOKIL<BKGLFJJJGOG, BKGLFJJJGOG>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5D06680", Offset = "0x5D04E80", VA = "0x185D06680")]
	public BHEBOMMCGAO(int IKCCLGHGHEI, int HLOJEJBCCDL, ComputeShader FBGKJBOALPK, int JAOEHOHHMGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class OLPKPPEJPJM : BINGGLPOKIL<IHNPCJOBBIM, PIMFPFLCHEO>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5D154B0", Offset = "0x5D13CB0", VA = "0x185D154B0")]
	public OLPKPPEJPJM(int IKCCLGHGHEI, int HLOJEJBCCDL, ComputeShader FBGKJBOALPK, int JAOEHOHHMGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BCOMGLNKGNC : BINGGLPOKIL<MBMBNLIPOAO, MBMBNLIPOAO>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5D065D0", Offset = "0x5D04DD0", VA = "0x185D065D0")]
	public BCOMGLNKGNC(int IKCCLGHGHEI, int HLOJEJBCCDL, ComputeShader FBGKJBOALPK, int JAOEHOHHMGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class DPMNOEDHOPH : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private EIPBDBOOKLA CPPNEHMMBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool PLMDMDMKAAB;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool DOAOKJGBOCH;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A120", Offset = "0x5D08920", VA = "0x185D0A120")]
	public DPMNOEDHOPH(EIPBDBOOKLA KBFKMMJCINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5D09F90", Offset = "0x5D08790", VA = "0x185D09F90", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer MLIEFBBOMEM, RenderingData BJECLCEBAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5D09D20", Offset = "0x5D08520", VA = "0x185D09D20", Slot = "6")]
	public override void Configure(CommandBuffer MLIEFBBOMEM, RenderTextureDescriptor KHJMFLGOOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5D09D60", Offset = "0x5D08560", VA = "0x185D09D60", Slot = "9")]
	public override void Execute(ScriptableRenderContext FJNGJOFLBMD, RenderingData BJECLCEBAHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class FBDJLIGDNNC
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct MNGFJONCDEM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string HNHMJGCODBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer MLIEFBBOMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext FJNGJOFLBMD;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D151F0", Offset = "0x5D139F0", VA = "0x185D151F0")]
		public MNGFJONCDEM(string GFKOBALFAEK, ScriptableRenderContext NOBKGPDFFNP, [Out] CommandBuffer OLGEIGIHMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5D15140", Offset = "0x5D13940", VA = "0x185D15140", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5D11C10", Offset = "0x5D10410", VA = "0x185D11C10")]
	public static bool PKIAPGKMAIL(RenderingData BJECLCEBAHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5D11A70", Offset = "0x5D10270", VA = "0x185D11A70")]
	public static void KGBMJAMPFCB(CommandBuffer MLIEFBBOMEM, ScriptableRenderContext FJNGJOFLBMD, ShadowDrawingSettings IPDFCEABANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5D11840", Offset = "0x5D10040", VA = "0x185D11840")]
	public static void CNNNOGBCAEK(CommandBuffer MLIEFBBOMEM, ScriptableRenderContext FJNGJOFLBMD, RenderingData BJECLCEBAHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EIPBDBOOKLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class LBLPNLIACNL
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int MCFMKJANHAO;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int JCDANGJCGMD;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static JELDNOPFEEL<PHCAGHFCDKI> CGNNIOKPHOF;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static JELDNOPFEEL<uint> FNADKPNNLDI;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static GOMOPPJAKLP BHONMBAGEIF;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer JFFGBMDBFCN;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<OGBACAPEDIM> MNOLOKLIDDE;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int DLLDABHJJAD;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int BBGDHPLJKJL;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int GPHAPCNBOME;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int DECAEMCNDJA;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] GOEJDHAJEJF;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] NHGFJEHMFEC;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static GCBLEDFGOAB[][] KPCFICDEJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] MKEPCKJBDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int DJPPFIBLHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int LJFMMCJOKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int OACHKAENCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int JOOENPJPKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int HLEJMHLJHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int GCNBPLIEAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int BJLCNHGHMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int BNAKNCFCFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int AEFIEPFIKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int LIDJAHMKOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int IMOHFHAKNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int CNIMGMMHJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int KBGMINOJOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int DCLDHFDBHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int CNALDGIDEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int ICHLJDPKKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int AKKJPJOLPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int NNOPDMNHJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] MBFMHOLEMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private IPGOJLNGKFK NCLMNIENGHP;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool CIPOIBOICBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A4A0", Offset = "0x5D08CA0", VA = "0x185D0A4A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A4F0", Offset = "0x5D08CF0", VA = "0x185D0A4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool JPPKJKIIMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C0F0", Offset = "0x5D0A8F0", VA = "0x185D0C0F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D0B9F0", Offset = "0x5D0A1F0", VA = "0x185D0B9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData IDDGLNBEBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C2B0", Offset = "0x5D0AAB0", VA = "0x185D0C2B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A430", Offset = "0x5D08C30", VA = "0x185D0A430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static AKLKJKBEEPL GLOFAHBGPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E0E0", Offset = "0x5D0C8E0", VA = "0x185D0E0E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D110C0", Offset = "0x5D0F8C0", VA = "0x185D110C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static EEAGNFMMFMC MMDJDCIBIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D0ED20", Offset = "0x5D0D520", VA = "0x185D0ED20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5D111B0", Offset = "0x5D0F9B0", VA = "0x185D111B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static HHFBNMPGDEJ MJCGPJJKOPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5D0B360", Offset = "0x5D09B60", VA = "0x185D0B360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5D0ECB0", Offset = "0x5D0D4B0", VA = "0x185D0ECB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static BHEBOMMCGAO MPENOCCMHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E1B0", Offset = "0x5D0C9B0", VA = "0x185D0E1B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C240", Offset = "0x5D0AA40", VA = "0x185D0C240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static OLPKPPEJPJM GNGFGFCIBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E510", Offset = "0x5D0CD10", VA = "0x185D0E510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5D0B4C0", Offset = "0x5D09CC0", VA = "0x185D0B4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static BCOMGLNKGNC JMHDEFECLLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5D0ED70", Offset = "0x5D0D570", VA = "0x185D0ED70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5D0EC30", Offset = "0x5D0D430", VA = "0x185D0EC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material ALGNMBHJELN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C1E0", Offset = "0x5D0A9E0", VA = "0x185D0C1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E130", Offset = "0x5D0C930", VA = "0x185D0E130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material OKIKBADJKFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5D0B300", Offset = "0x5D09B00", VA = "0x185D0B300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5D11130", Offset = "0x5D0F930", VA = "0x185D11130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material LAGJBAGIAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E2E0", Offset = "0x5D0CAE0", VA = "0x185D0E2E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E200", Offset = "0x5D0CA00", VA = "0x185D0E200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material CMIHPHNPNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FC30", Offset = "0x5D0E430", VA = "0x185D0FC30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5D0B280", Offset = "0x5D09A80", VA = "0x185D0B280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool IPGHFKBAOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A3D0", Offset = "0x5D08BD0", VA = "0x185D0A3D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C3F0", Offset = "0x5D0ABF0", VA = "0x185D0C3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool OEAGBDDNMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E280", Offset = "0x5D0CA80", VA = "0x185D0E280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string BJFDMNNLNIC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E570", Offset = "0x5D0CD70", VA = "0x185D0E570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5D113F0", Offset = "0x5D0FBF0", VA = "0x185D113F0")]
	internal EIPBDBOOKLA([Optional] MClusterData CMFHHLNCNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C770", Offset = "0x5D0AF70", VA = "0x185D0C770")]
	public void GLJEDCMMNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C050", Offset = "0x5D0A850", VA = "0x185D0C050")]
	public void FDEMKCJOLFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B540", Offset = "0x5D09D40", VA = "0x185D0B540")]
	public void EJJDEAJPBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C140", Offset = "0x5D0A940", VA = "0x185D0C140")]
	public bool FFDIEHEGFAK(Hash128 JJPJJOLELKC, [Out] DCDOACHIFPL LFKHDLANNJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5D11000", Offset = "0x5D0F800", VA = "0x185D11000")]
	public DCDOACHIFPL NJMEIPIEAKJ(HEIDLPPCNAC AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5D10C40", Offset = "0x5D0F440", VA = "0x185D10C40")]
	public MLJBLBJMFFG NJMEIPIEAKJ(EBDFOAOLNLD JGLFCCBLACF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5D10E40", Offset = "0x5D0F640", VA = "0x185D10E40")]
	public BHPOOINBLLN NJMEIPIEAKJ(DPBBDDFMAIJ IALEADLNNLH, bool ABLBBINGODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5D11300", Offset = "0x5D0FB00", VA = "0x185D11300")]
	public void PJFBCFIPABD(HDPEAPHMMIO MDEENBAIGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C300", Offset = "0x5D0AB00", VA = "0x185D0C300")]
	public static void GGOLMLAONEK(FMDGLNDFBOC FIIIJAPNPGF, GCBLEDFGOAB[] AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EDD0", Offset = "0x5D0D5D0", VA = "0x185D0EDD0")]
	private void KPCNGDAILAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A550", Offset = "0x5D08D50", VA = "0x185D0A550")]
	private static void BLFFKDGJHAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C450", Offset = "0x5D0AC50", VA = "0x185D0C450")]
	public void GJFOMIPEPPA(CommandBuffer MLIEFBBOMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E340", Offset = "0x5D0CB40", VA = "0x185D0E340")]
	public void IMHEGNOIDLG([Optional] ScriptableRenderContext? FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DB20", Offset = "0x5D0C320", VA = "0x185D0DB20")]
	public void GOGGBECCLNO(CommandBuffer MLIEFBBOMEM, ShadowSplitData NJGPJKJPNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DE00", Offset = "0x5D0C600", VA = "0x185D0DE00")]
	public void GOGGBECCLNO(CommandBuffer MLIEFBBOMEM, CameraData CPCIMICKNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F6D0", Offset = "0x5D0DED0", VA = "0x185D0F6D0")]
	public void LOFOGAHOOJP(CommandBuffer MLIEFBBOMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B210", Offset = "0x5D09A10", VA = "0x185D0B210")]
	public void CDHBCHCLIFI(CommandBuffer MLIEFBBOMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B550", Offset = "0x5D09D50", VA = "0x185D0B550")]
	public void ELNBJGPMHGE(CommandBuffer MLIEFBBOMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BA50", Offset = "0x5D0A250", VA = "0x185D0BA50")]
	public void FCPAKBIINHA(CommandBuffer MLIEFBBOMEM, FMDGLNDFBOC LLGGDMIKNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5D11220", Offset = "0x5D0FA20", VA = "0x185D11220")]
	public void PIOJLBHNDBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5D0FC90", Offset = "0x5D0E490", VA = "0x185D0FC90")]
	public void NAKDAJJPGKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B3B0", Offset = "0x5D09BB0", VA = "0x185D0B3B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class HDGKGPIBBCM
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1BBB7C0", Offset = "0x1BB9FC0", VA = "0x181BBB7C0")]
	public static int LOKPOOAODEM(int DKLECPOCCOI, int JPAEMNBHEEE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct IBEEHFJGDNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 LKIBBHHOJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 BOMJHLMKFPE;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly IBEEHFJGDNG AKKADMLPDBB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly IBEEHFJGDNG HEADMFFNPAP;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5D11F80", Offset = "0x5D10780", VA = "0x185D11F80")]
	public IBEEHFJGDNG(float4x4 MKCOCGEOBGD, float4 JIDPHHHBGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5D11E10", Offset = "0x5D10610", VA = "0x185D11E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct JCKHKPOJHHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 MCLBBPPAHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 LOKKODLNJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 EKKEIADEAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 GCECCDDBGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 GDPPBOJNEMN;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct HLLBFIHDPKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 MCLBBPPAHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 LOKKODLNJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 EKKEIADEAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 GCECCDDBGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 GDPPBOJNEMN;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct PIMFPFLCHEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public HLLBFIHDPKC JCJEOEMEJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public HLLBFIHDPKC FLHGKJOFIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public HLLBFIHDPKC NIAODNALKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public HLLBFIHDPKC PHODCNPKHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public HLLBFIHDPKC NMJDJAMENPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public HLLBFIHDPKC HMJJNEMHLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public HLLBFIHDPKC AHEOLJAAAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public HLLBFIHDPKC JLCAIHIMEFB;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct IHNPCJOBBIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public JCKHKPOJHHK JCJEOEMEJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public JCKHKPOJHHK FLHGKJOFIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public JCKHKPOJHHK NIAODNALKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public JCKHKPOJHHK PHODCNPKHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public JCKHKPOJHHK NMJDJAMENPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public JCKHKPOJHHK HMJJNEMHLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public JCKHKPOJHHK AHEOLJAAAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public JCKHKPOJHHK JLCAIHIMEFB;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct AJJKOEIEJBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 FLDENIGPFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint LCABJGDLPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint JIBGFHDMIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float ECEOOALIDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint GEHAMDENIAG;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5D05580", Offset = "0x5D03D80", VA = "0x185D05580")]
	public AJJKOEIEJBD(EBDFOAOLNLD JGLFCCBLACF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct PHCAGHFCDKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint AJOLOCEMJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint MPONFOAPKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint PKGENAHBEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint GEHAMDENIAG;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5D15940", Offset = "0x5D14140", VA = "0x185D15940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct BKGLFJJJGOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint EGHLPPCKEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint HPGIHNCDILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint NBCEJGCLIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint GEHAMDENIAG;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5D07A70", Offset = "0x5D06270", VA = "0x185D07A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct CFHCNDBLKOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint OLOCLMHAFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint MMLPHIPGKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint IMOGDGLILIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint OPENNILNDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint FOIHEAEMNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint MJLICFGIBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint MOJOGNGJHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint GEHAMDENIAG;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5D07B20", Offset = "0x5D06320", VA = "0x185D07B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct MBMBNLIPOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 GGBLHBKPANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 PHJHCFOPGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 FFGHNDLJEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 ENMOEDECFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 ININABADPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 HIEKHMPHFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 PNGGEAICIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 ICBCFAJJAPG;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5D13CF0", Offset = "0x5D124F0", VA = "0x185D13CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum FMDGLNDFBOC
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
