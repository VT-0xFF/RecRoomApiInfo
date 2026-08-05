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
public struct JJMNNKJBGGE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] PILFOCFLFJG;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] BKKEPCIOJMD;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] LDOKNDMLNFJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1BC4DA0", Offset = "0x1BC3FA0", VA = "0x181BC4DA0")]
	public static int HPADBKFFNJA(PKLKEEBNENF DDNEALBALGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7283220", Offset = "0x7282420", VA = "0x187283220")]
	public static int GLOOICAKJJM(PKLKEEBNENF DDNEALBALGE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NNKGPLGHIAD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int FLGADCPGBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PMEBFNMKDHJ JGCBGEFFILJ(int MPDJGCJPOLI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 LJMEKHKIHKF(int MPDJGCJPOLI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HLDKLCEAPAJ DDCPBFLJHAC();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CDDHKLNEGHH PBHDFHCEPDM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EJJJIEFOEML : OLNCKOLEDMM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private HLDKLCEAPAJ MCPAEAAAAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform GDCEJMOHHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<FOCGMGPLIIP> MECBHFAKFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private NPMIACKEOHH PACFFEEDLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private MKFDMAOEJIN DNJMCONBLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool OEHKEOECHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NNKGPLGHIAD KPKPOKMAHHG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float AABEKAEAPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA2840", Offset = "0xAA1A40", VA = "0x180AA2840")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAA2830", Offset = "0xAA1A30", VA = "0x180AA2830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GABCAMENEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xABD7A0", Offset = "0xABC9A0", VA = "0x180ABD7A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB35480", Offset = "0xB34680", VA = "0x180B35480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MOHEIEPCONN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBEA670", Offset = "0xBE9870", VA = "0x180BEA670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xBE8C60", Offset = "0xBE7E60", VA = "0x180BE8C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CCBACAJLKLA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1BCB860", Offset = "0x1BCAA60", VA = "0x181BCB860", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1BCAEF0", Offset = "0x1BCA0F0", VA = "0x181BCAEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MIEFHILLION
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1CD6B30", Offset = "0x1CD5D30", VA = "0x181CD6B30", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7280E20", Offset = "0x7280020", VA = "0x187280E20")]
	public EJJJIEFOEML(NNKGPLGHIAD AFIJJNIIMIC, bool MBDLFHCAFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7280C00", Offset = "0x727FE00", VA = "0x187280C00")]
	private bool NEDAFEGACKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x727FBE0", Offset = "0x727EDE0", VA = "0x18727FBE0", Slot = "4")]
	public bool CKLHJOINNOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7280A30", Offset = "0x727FC30", VA = "0x187280A30", Slot = "5")]
	public bool MEIPIBBEBLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7280800", Offset = "0x727FA00", VA = "0x187280800", Slot = "6")]
	public void GMODDBABBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72807F0", Offset = "0x727F9F0", VA = "0x1872807F0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AGAIKDAACCA
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HAGGDHEMFBD(CommandBuffer GGLELMAOCGA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MNLPFFFMJBE : AGAIKDAACCA
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int JFJOAOHHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier ICPFOAOAAIN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x49ADB00", Offset = "0x49ACD00", VA = "0x1849ADB00")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7285770", Offset = "0x7284970", VA = "0x187285770")]
	public MNLPFFFMJBE(int BEHEHKFONGA, RenderTargetIdentifier LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7285720", Offset = "0x7284920", VA = "0x187285720", Slot = "4")]
	public void HAGGDHEMFBD(CommandBuffer GGLELMAOCGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct HLAEBGMBBJM : AGAIKDAACCA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int JFJOAOHHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] NELOHBMNKLK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xC14800", Offset = "0xC13A00", VA = "0x180C14800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x140D3B0", Offset = "0x140C5B0", VA = "0x18140D3B0")]
	public HLAEBGMBBJM(int BEHEHKFONGA, Vector4[] LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7282DC0", Offset = "0x7281FC0", VA = "0x187282DC0", Slot = "4")]
	public void HAGGDHEMFBD(CommandBuffer GGLELMAOCGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct KBBPOMAJIGN : AGAIKDAACCA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int JFJOAOHHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] OILMFPFBCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xC14800", Offset = "0xC13A00", VA = "0x180C14800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x140D3B0", Offset = "0x140C5B0", VA = "0x18140D3B0")]
	public KBBPOMAJIGN(int BEHEHKFONGA, float[] LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x72838E0", Offset = "0x7282AE0", VA = "0x1872838E0", Slot = "4")]
	public void HAGGDHEMFBD(CommandBuffer GGLELMAOCGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct AIBIFIDAMOA : AGAIKDAACCA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string PCMLNMEPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool MEJCLCCDGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xBC28C0", Offset = "0xBC1AC0", VA = "0x180BC28C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1532D30", Offset = "0x1531F30", VA = "0x181532D30")]
	public AIBIFIDAMOA(string LMOANCJLHKC, bool MPKIENECBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7276A80", Offset = "0x7275C80", VA = "0x187276A80", Slot = "4")]
	public void HAGGDHEMFBD(CommandBuffer GGLELMAOCGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct CDDHKLNEGHH
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 OHILCNOMBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 DNHBPKFNCCF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB00AB0", Offset = "0xAFFCB0", VA = "0x180B00AB0")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int DHGHFNOOMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA960C0", Offset = "0xA952C0", VA = "0x180A960C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GFDKPCENIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9335E0", Offset = "0x9327E0", VA = "0x1809335E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float CMEDIBKHNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xD67E50", Offset = "0xD67050", VA = "0x180D67E50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x72780D0", Offset = "0x72772D0", VA = "0x1872780D0")]
	public CDDHKLNEGHH(Color HCHFCFNLIAI, int EDIEJIFBNPJ, int KBFEGFMJPHI, float MNPIOFBGBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xF7FC90", Offset = "0xF7EE90", VA = "0x180F7FC90")]
	private static float4 AOGJGMLPDOL(Color HCHFCFNLIAI)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7278040", Offset = "0x7277240", VA = "0x187278040")]
	private static Hash128 CHJPHEHMOKK(CDDHKLNEGHH AFIJJNIIMIC)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NPMIACKEOHH : OLNCKOLEDMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string IHHDEPAIJLD;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string HDDPNBFBOOP;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string NNKOPFNOFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CDDHKLNEGHH CJMHAGDNEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private IHEPCKPDFHP HGJFBFIMOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 HOCCJKFBNKJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MKFDMAOEJIN HAPGMOOOCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x91AA20", Offset = "0x919C20", VA = "0x18091AA20")]
		[CompilerGenerated]
		get
		{
			return default(MKFDMAOEJIN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1102FF0", Offset = "0x11021F0", VA = "0x181102FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GABCAMENEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x61DE940", Offset = "0x61DDB40", VA = "0x1861DE940")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x61DE950", Offset = "0x61DDB50", VA = "0x1861DE950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MOHEIEPCONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x24840D0", Offset = "0x24832D0", VA = "0x1824840D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x71FC6C0", Offset = "0x71FB8C0", VA = "0x1871FC6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MIEFHILLION
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CCBACAJLKLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6295F30", Offset = "0x6295130", VA = "0x186295F30", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7285BE0", Offset = "0x7284DE0", VA = "0x187285BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int JDABKJNJMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7285BF0", Offset = "0x7284DF0", VA = "0x187285BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7286140", Offset = "0x7285340", VA = "0x187286140")]
	public NPMIACKEOHH(CDDHKLNEGHH DEDEIPNPHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7285F40", Offset = "0x7285140", VA = "0x187285F40")]
	private bool NEDAFEGACKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7285A90", Offset = "0x7284C90", VA = "0x187285A90", Slot = "4")]
	public bool CKLHJOINNOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7285D50", Offset = "0x7284F50", VA = "0x187285D50")]
	private static IHEPCKPDFHP JDDBBLECCLP(CDDHKLNEGHH AFIJJNIIMIC)
	{
		return default(IHEPCKPDFHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7285D90", Offset = "0x7284F90", VA = "0x187285D90", Slot = "5")]
	public bool MEIPIBBEBLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7285C40", Offset = "0x7284E40", VA = "0x187285C40", Slot = "6")]
	public void GMODDBABBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7283EE0", Offset = "0x72830E0", VA = "0x187283EE0", Slot = "0")]
		public override bool Equals(object JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x72840E0", Offset = "0x72832E0", VA = "0x1872840E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA59310", Offset = "0xA58510", VA = "0x180A59310")]
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
		private MLPOKBJNNJC opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static DAMFDLDAKFH CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x72847D0", Offset = "0x72839D0", VA = "0x1872847D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7284810", Offset = "0x7283A10", VA = "0x187284810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7284360", Offset = "0x7283560", VA = "0x187284360", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7284190", Offset = "0x7283390", VA = "0x187284190", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DELKJLDIJIB, RenderingData FENNMANFJMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x72841C0", Offset = "0x72833C0", VA = "0x1872841C0")]
		public void BMOAJMMFAHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1420D00", Offset = "0x141FF00", VA = "0x181420D00")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LOJAJKLLOHJ<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private LHEGGJJKLIM FDINKJHCEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private LHEGGJJKLIM AOGFGOFJHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer CILCNHPFGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture GDODIMLFMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int KMPDIHDINCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int NHLMGOHGEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string POACBEDPCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string GKPPDHFCJPM;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8FD6F0", Offset = "0x8FC8F0", VA = "0x1808FD6F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int PLEMMDMHBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xB88360", Offset = "0xB87560", VA = "0x180B88360")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int FOPBJDPMDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x911450", Offset = "0x910650", VA = "0x180911450")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4A0C8D0", Offset = "0x4A0BAD0", VA = "0x184A0C8D0")]
	public LOJAJKLLOHJ(string LMOANCJLHKC, int LMPJNMEFFEM, [Optional] RenderTextureFormat? HNCNCHKHLCP, bool FBBFOIKMEPF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4A092D0", Offset = "0x4A084D0", VA = "0x184A092D0")]
	public void MEIPIBBEBLB(CommandBuffer GGLELMAOCGA, NativeArray<ValType> LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A9E0", Offset = "0x4A09BE0", VA = "0x184A0A9E0")]
	public void NJHAKBGIMHB(CommandBuffer GGLELMAOCGA, ComputeShader ODNKKAGIEEP, int LHINDIOKHDD, int JDBHPICKONE = -1, int EMOOGDICDNP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4A09D30", Offset = "0x4A08F30", VA = "0x184A09D30")]
	public void NJHAKBGIMHB(Material HGJFBFIMOOD, int JDBHPICKONE = -1, int EMOOGDICDNP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4A08B70", Offset = "0x4A07D70", VA = "0x184A08B70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AODBIOAALCP
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJHAKBGIMHB(Material DEDEIPNPHBN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OBMPNDACJNH<SrcEntry, DstEntry> : AODBIOAALCP, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] NNHLEFAGNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected LHEGGJJKLIM AMJCNEPEBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected LHEGGJJKLIM BENBGAAECKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> NBGCFKAMPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> ONFABHKAMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int HEHFIANGAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int INBLFINICJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected LOJAJKLLOHJ<int> NFDGJNPFGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected LOJAJKLLOHJ<SrcEntry> MCBFFBLANBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected LOJAJKLLOHJ<DstEntry> NBCDHKHMKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader GFIGGFDKMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int JBAMHDFMBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int EAOKBKCCOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int FJGCPBHICDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int CHOPGGLCPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int GDBBPONMFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int IIGDGFNHGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int FONGACGEFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int ONJCGGEPFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int OEBDMDEKJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int LNKBAEOOFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int JMKKNGOPGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int IGGCIOPGDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string OIIBOGEFACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] FOFINFEJGEK;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int KCBJAHDNLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4D87740", Offset = "0x4D86940", VA = "0x184D87740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string HFBKLCDNBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4D85E60", Offset = "0x4D85060", VA = "0x184D85E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4D888F0", Offset = "0x4D87AF0", VA = "0x184D888F0")]
	public OBMPNDACJNH(string LMOANCJLHKC, int AICPOKMPBMH, int JMGEJBIPMNO, RenderTextureFormat HNCNCHKHLCP, ComputeShader NPNPOBHEONE, int ONELMLJIDAF = 0, int IOKPEFHFLEF = 0, int NKJNNAJACKM = 0, int NMGMMBABDIG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4D85DF0", Offset = "0x4D84FF0", VA = "0x184D85DF0")]
	public int CIBFPBIFLDC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4D86C70", Offset = "0x4D85E70", VA = "0x184D86C70")]
	protected void DJPCDDPMMBC(int CPLNODNGKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4D866D0", Offset = "0x4D858D0", VA = "0x184D866D0")]
	public MKFDMAOEJIN CKLHJOINNOK(SrcEntry LFDKFEEPNFP)
	{
		return default(MKFDMAOEJIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4D87140", Offset = "0x4D86340", VA = "0x184D87140")]
	public bool MEIPIBBEBLB(MKFDMAOEJIN AINDMPLBNFF, SrcEntry LFDKFEEPNFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4D87040", Offset = "0x4D86240", VA = "0x184D87040")]
	public bool GMODDBABBFK(MKFDMAOEJIN AINDMPLBNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "6")]
	protected virtual void LIPIGKMNJHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4D87CD0", Offset = "0x4D86ED0", VA = "0x184D87CD0", Slot = "7")]
	public void PONGAKNNKPJ(CommandBuffer GGLELMAOCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4D87D30", Offset = "0x4D86F30", VA = "0x184D87D30", Slot = "8")]
	public void PONGAKNNKPJ(CommandBuffer GGLELMAOCGA, ComputeShader NPNPOBHEONE, int ONELMLJIDAF = -1, int IOKPEFHFLEF = -1, int NKJNNAJACKM = -1, int NMGMMBABDIG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4D877C0", Offset = "0x4D869C0", VA = "0x184D877C0", Slot = "9")]
	public void NJHAKBGIMHB(CommandBuffer GGLELMAOCGA, ComputeShader NPNPOBHEONE, int ONELMLJIDAF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4D87750", Offset = "0x4D86950", VA = "0x184D87750", Slot = "4")]
	public void NJHAKBGIMHB(Material HGJFBFIMOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4D86EC0", Offset = "0x4D860C0", VA = "0x184D86EC0", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LHEGGJJKLIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong OINKKNJLAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong IAELMCMLGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MJMLGCMNHCL
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct GLALHGENJIK : LHEGGJJKLIM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable DAFFFIIHPKE;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong OINKKNJLAHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xC14800", Offset = "0xC13A00", VA = "0x180C14800", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xF9C7B0", Offset = "0xF9B9B0", VA = "0x180F9C7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong IAELMCMLGML
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xBAAAB0", Offset = "0xBA9CB0", VA = "0x180BAAAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7282D10", Offset = "0x7281F10", VA = "0x187282D10")]
		internal GLALHGENJIK(IDisposable GOLAFHGFCPM, ulong DMCLKPNIAAD, ulong KBHNAHNDGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7282C90", Offset = "0x7281E90", VA = "0x187282C90", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct AKOFDENBIJP : LHEGGJJKLIM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture DOOKDNAFKKA;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong OINKKNJLAHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xC14800", Offset = "0xC13A00", VA = "0x180C14800", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xF9C7B0", Offset = "0xF9B9B0", VA = "0x180F9C7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong IAELMCMLGML
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xBAAAB0", Offset = "0xBA9CB0", VA = "0x180BAAAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7276D50", Offset = "0x7275F50", VA = "0x187276D50")]
		public AKOFDENBIJP(RenderTexture AANEOIBPLCD, ulong JFBIILOHNAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7276CB0", Offset = "0x7275EB0", VA = "0x187276CB0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong BIBBBMMECPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x72850F0", Offset = "0x72842F0", VA = "0x1872850F0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72848B0", Offset = "0x7283AB0", VA = "0x1872848B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong JEJNCOBMLOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7284870", Offset = "0x7283A70", VA = "0x187284870")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72850B0", Offset = "0x72842B0", VA = "0x1872850B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7284B40", Offset = "0x7283D40", VA = "0x187284B40")]
	public static ComputeBuffer LHPCDDMHIBB(int EOKNBJLIKEG, int KCIKHIHHHBI, ComputeBufferType MDOOANEGCAH, [Out] LHEGGJJKLIM AINDMPLBNFF, ComputeBufferMode EKEGOHBHLFB = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7284D10", Offset = "0x7283F10", VA = "0x187284D10")]
	public static RenderTexture LHPCDDMHIBB(int MBOBOHBNOJL, int MPOEILOGHHP, int OBAJPCFEALP, RenderTextureFormat HNCNCHKHLCP, [Out] LHEGGJJKLIM AINDMPLBNFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3379F40", Offset = "0x3379140", VA = "0x183379F40")]
	public static NativeArray<T> NAADEMAPAHL<T>(NativeArray<T> DAFFFIIHPKE, ulong BJJBELCKPHA, [Out] LHEGGJJKLIM AINDMPLBNFF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3379E80", Offset = "0x3379080", VA = "0x183379E80")]
	public static NativeArray<T> LHPCDDMHIBB<T>(int BJJBELCKPHA, Allocator NNHCNMKJHLF, [Out] LHEGGJJKLIM AINDMPLBNFF, NativeArrayOptions GPDCLNOGPJC = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7284A00", Offset = "0x7283C00", VA = "0x187284A00")]
	public static void LEGDOGAINAB(LHEGGJJKLIM DAFFFIIHPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x72848F0", Offset = "0x7283AF0", VA = "0x1872848F0")]
	public static uint KGADKMENOEK(RenderTextureFormat HNCNCHKHLCP)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ACMDCFNOEGK : OBMPNDACJNH<NGKIJIECGAI, NGKIJIECGAI>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct AILDLENOLKD : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> ILLBBCGIMJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> PKLFHOMDJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> LDMBJHKHOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> KEIOMHIMJCN;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7276C80", Offset = "0x7275E80", VA = "0x187276C80")]
		public AILDLENOLKD(NativeArray<int> CMCKGEEJLDG, NativeArray<float> MJEFLBDGKPH, NativeArray<float4x4> JNOPDBFNHJA, NativeArray<float4> BKGKCHNEHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7276AC0", Offset = "0x7275CC0", VA = "0x187276AC0", Slot = "4")]
		public void Execute(int CPLNODNGKGB, TransformAccess MCPAEAAAAAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct GLLFJLGODGG : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> ILLBBCGIMJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> ELOPELLELFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> DINDHPDNGEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<NGKIJIECGAI> IHBNDJLPLPM;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7276C80", Offset = "0x7275E80", VA = "0x187276C80")]
		public GLLFJLGODGG(NativeArray<int> CMCKGEEJLDG, NativeArray<float4x4> NDHHBLKJBEJ, NativeArray<float4> AINGONBJELK, NativeArray<NGKIJIECGAI> GGHDHEDBJLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7282D50", Offset = "0x7281F50", VA = "0x187282D50", Slot = "4")]
		public void Execute(int CPLNODNGKGB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte JFPCJEHHEOB = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray OPNNJGOIFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> ONBLPKJCIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> BBDGJJCIGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> CANKNMBLLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> FAJLGGMKCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> CKKEPDPJEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private LHEGGJJKLIM BIOPJJLNDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private LHEGGJJKLIM EGAAFADIDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private LHEGGJJKLIM GDFBCCMLCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private LHEGGJJKLIM DFMKHHFJOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private LHEGGJJKLIM KBHDCFKFBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform GLGIJDKAKDP;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x72767A0", Offset = "0x72759A0", VA = "0x1872767A0")]
	public ACMDCFNOEGK(int AICPOKMPBMH, int JMGEJBIPMNO, ComputeShader NPNPOBHEONE, int ONELMLJIDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7276340", Offset = "0x7275540", VA = "0x187276340", Slot = "6")]
	protected override void LIPIGKMNJHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x72766E0", Offset = "0x72758E0", VA = "0x1872766E0")]
	private void OOKCNMMIFJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x72761E0", Offset = "0x72753E0", VA = "0x1872761E0")]
	public bool HMOFJHAACOK(MKFDMAOEJIN AINDMPLBNFF, Transform MCPAEAAAAAM, float MAMDJKGFGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7276550", Offset = "0x7275750", VA = "0x187276550")]
	public void NCDNAADBDJL(MKFDMAOEJIN AINDMPLBNFF, float MAMDJKGFGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7276630", Offset = "0x7275830", VA = "0x187276630")]
	public void NHPOCOBNMJN(MKFDMAOEJIN AINDMPLBNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7276140", Offset = "0x7275340", VA = "0x187276140", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PMEBFNMKDHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFAKCFONIOG DDGALHILICL();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LGKFHFPJEFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 OHILCNOMBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int FBEPFNIBOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int JGGAFOOFKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> FJKLEJNIMLK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> HEEFGJFKPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> PONOLGNIEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> CMHBGKCBONF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> CGJLFNCMMAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> CDGBHMPHPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int CIOHICEHPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int PFILAPHLPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int JEEMMCAIDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool JONHANOHAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PONGAKNNKPJ();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OOGKHCEKEBK : LGKFHFPJEFH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private PMEBFNMKDHJ LAAPGDHGMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private BFAKCFONIOG NNPLONBDKAB;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 OHILCNOMBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xB00AB0", Offset = "0xAFFCB0", VA = "0x180B00AB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xB00AC0", Offset = "0xAFFCC0", VA = "0x180B00AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool ANPECAMCGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8FB090", Offset = "0x8FA290", VA = "0x1808FB090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int FBEPFNIBOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9335E0", Offset = "0x9327E0", VA = "0x1809335E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x932BE0", Offset = "0x931DE0", VA = "0x180932BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int JGGAFOOFKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8F5470", Offset = "0x8F4670", VA = "0x1808F5470", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8F5480", Offset = "0x8F4680", VA = "0x1808F5480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int JDFOOJIHNLE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x119C4D0", Offset = "0x119B6D0", VA = "0x18119C4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> FJKLEJNIMLK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7286230", Offset = "0x7285430", VA = "0x187286230", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> HEEFGJFKPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7286360", Offset = "0x7285560", VA = "0x187286360", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> PONOLGNIEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7286420", Offset = "0x7285620", VA = "0x187286420", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> CMHBGKCBONF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7286390", Offset = "0x7285590", VA = "0x187286390", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> CGJLFNCMMAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7286330", Offset = "0x7285530", VA = "0x187286330", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> CDGBHMPHPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7286450", Offset = "0x7285650", VA = "0x187286450", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JONHANOHAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x920F50", Offset = "0x920150", VA = "0x180920F50", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x920CD0", Offset = "0x91FED0", VA = "0x180920CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int CIOHICEHPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x72864A0", Offset = "0x72856A0", VA = "0x1872864A0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int PFILAPHLPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7286480", Offset = "0x7285680", VA = "0x187286480", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int JEEMMCAIDEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7286400", Offset = "0x7285600", VA = "0x187286400", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x72865C0", Offset = "0x72857C0", VA = "0x1872865C0")]
	public OOGKHCEKEBK(Hash128 IBBAMBJMMGK, PMEBFNMKDHJ LAAPGDHGMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x72864B0", Offset = "0x72856B0", VA = "0x1872864B0", Slot = "16")]
	public void PONGAKNNKPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x72862A0", Offset = "0x72854A0", VA = "0x1872862A0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct MKFDMAOEJIN : IEquatable<MKFDMAOEJIN>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly MKFDMAOEJIN EPGHELDKPDG;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int JDABKJNJMBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790")]
	public MKFDMAOEJIN(int CPLNODNGKGB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7285130", Offset = "0x7284330", VA = "0x187285130", Slot = "4")]
	public bool Equals(MKFDMAOEJIN JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7285180", Offset = "0x7284380", VA = "0x187285180", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7285250", Offset = "0x7284450", VA = "0x187285250", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FOCGMGPLIIP : OLNCKOLEDMM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool OEHKEOECHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private LGKFHFPJEFH MFHBBMIBOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<MKFDMAOEJIN> CBBLHDGNDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<MKFDMAOEJIN> IMDGNAPDEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<MKFDMAOEJIN> NJCIPECJENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> DCMABPIMGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int HHOBCJPHCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int GPNDHDAGKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int GJOOFPIGHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int LEIEIGJNCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int JAJBPNOCLNM;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int JDABKJNJMBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x72820A0", Offset = "0x72812A0", VA = "0x1872820A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x72827C0", Offset = "0x72819C0", VA = "0x1872827C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool GABCAMENEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xB24780", Offset = "0xB23980", VA = "0x180B24780")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xB24BA0", Offset = "0xB23DA0", VA = "0x180B24BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool MOHEIEPCONN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB24E20", Offset = "0xB24020", VA = "0x180B24E20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB24E10", Offset = "0xB24010", VA = "0x180B24E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool MIEFHILLION
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool CCBACAJLKLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5283400", Offset = "0x5282600", VA = "0x185283400", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x22DE1F0", Offset = "0x22DD3F0", VA = "0x1822DE1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float AABEKAEAPPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD4D5D0", Offset = "0xD4C7D0", VA = "0x180D4D5D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xD4D4A0", Offset = "0xD4C6A0", VA = "0x180D4D4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7282B20", Offset = "0x7281D20", VA = "0x187282B20")]
	public FOCGMGPLIIP(LGKFHFPJEFH NNPLONBDKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7280EE0", Offset = "0x72800E0", VA = "0x187280EE0")]
	private void CHHOIPKMNNK(LGKFHFPJEFH NNPLONBDKAB, int HHOBCJPHCLK, int IFKAHIJNNKL, int CPLNODNGKGB, int IMDKDPBPBMJ, BDOENEOBHKG LFDKFEEPNFP, float FFINHIAIBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7281DE0", Offset = "0x7280FE0", VA = "0x187281DE0")]
	private void EDFBEBELOAD(LGKFHFPJEFH NNPLONBDKAB, int ALOJHKDPMDD, int CPLNODNGKGB, uint3 FENFMEOGHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7282880", Offset = "0x7281A80", VA = "0x187282880")]
	private bool NEDAFEGACKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x72813A0", Offset = "0x72805A0", VA = "0x1872813A0", Slot = "4")]
	public bool CKLHJOINNOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7282800", Offset = "0x7281A00", VA = "0x187282800", Slot = "5")]
	public bool MEIPIBBEBLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7282150", Offset = "0x7281350", VA = "0x187282150", Slot = "6")]
	public void GMODDBABBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7281D80", Offset = "0x7280F80", VA = "0x187281D80")]
	public void JAOIMFDKOIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7281D80", Offset = "0x7280F80", VA = "0x187281D80", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OLNCKOLEDMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool MIEFHILLION
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool CCBACAJLKLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKLHJOINNOK();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MEIPIBBEBLB();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMODDBABBFK();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ALEICLKADEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float KHPPDLKKHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, FOCGMGPLIIP> LNEPJLHJGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, NPMIACKEOHH> IOIDKHLBNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<OLNCKOLEDMM> CINJIPGDIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<OLNCKOLEDMM> JOLLJDPOPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<OLNCKOLEDMM> NPDILGBPADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int MOMHAGNNNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int FJEHHGGCOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float INCIJHOBBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool OKGDNEFGAHG;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool GGEMNJDFEDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x14238C0", Offset = "0x1422AC0", VA = "0x1814238C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x14421B0", Offset = "0x14413B0", VA = "0x1814421B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool HBPCCECPBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7277300", Offset = "0x7276500", VA = "0x187277300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string HFBKLCDNBIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7276E30", Offset = "0x7276030", VA = "0x187276E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7277350", Offset = "0x7276550", VA = "0x187277350")]
	public void IGGHHOILKJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7277920", Offset = "0x7276B20", VA = "0x187277920")]
	public void KIEDCPDJDHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7277EB0", Offset = "0x72770B0", VA = "0x187277EB0")]
	public ALEICLKADEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7277780", Offset = "0x7276980", VA = "0x187277780")]
	public EJJJIEFOEML JMFBCAGPLCG(NNKGPLGHIAD IEFGENALBBO, bool MBDLFHCAFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7277360", Offset = "0x7276560", VA = "0x187277360")]
	public NPMIACKEOHH JMFBCAGPLCG(CDDHKLNEGHH HGJFBFIMOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x72778B0", Offset = "0x7276AB0", VA = "0x1872778B0")]
	public bool KCCFNFOGMHD(Hash128 BEHEHKFONGA, [Out] FOCGMGPLIIP AFEJHCJJGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x72774A0", Offset = "0x72766A0", VA = "0x1872774A0")]
	public FOCGMGPLIIP JMFBCAGPLCG(LGKFHFPJEFH NNPLONBDKAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x72771D0", Offset = "0x72763D0", VA = "0x1872771D0")]
	private void DOFDOCOGABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7277930", Offset = "0x7276B30", VA = "0x187277930")]
	private bool KOFLEJNNBKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x72779C0", Offset = "0x7276BC0", VA = "0x1872779C0")]
	public void PONGAKNNKPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x72771F0", Offset = "0x72763F0", VA = "0x1872771F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7276D80", Offset = "0x7275F80", VA = "0x187276D80")]
	public void BOFJLDDGHJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ECJBOMCPJMH : OBMPNDACJNH<EBNLMLNIHAC, EBNLMLNIHAC>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x727FB30", Offset = "0x727ED30", VA = "0x18727FB30")]
	public ECJBOMCPJMH(int AICPOKMPBMH, int JMGEJBIPMNO, ComputeShader NPNPOBHEONE, int ONELMLJIDAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NPEILDDJCNJ : OBMPNDACJNH<IHEPCKPDFHP, IHEPCKPDFHP>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x72859E0", Offset = "0x7284BE0", VA = "0x1872859E0")]
	public NPEILDDJCNJ(int AICPOKMPBMH, int JMGEJBIPMNO, ComputeShader NPNPOBHEONE, int ONELMLJIDAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class DBCJGMEIOGB : OBMPNDACJNH<OGBECKANFJP, OGBECKANFJP>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x727F6D0", Offset = "0x727E8D0", VA = "0x18727F6D0")]
	public DBCJGMEIOGB(int AICPOKMPBMH, int JMGEJBIPMNO, ComputeShader NPNPOBHEONE, int ONELMLJIDAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NAOOOAAIHAA : OBMPNDACJNH<BOGJMFCBNOE, OCKBCEBHNGM>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7285790", Offset = "0x7284990", VA = "0x187285790")]
	public NAOOOAAIHAA(int AICPOKMPBMH, int JMGEJBIPMNO, ComputeShader NPNPOBHEONE, int ONELMLJIDAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CPLLNBINCHC : OBMPNDACJNH<JGPMIGKJHLB, JGPMIGKJHLB>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x72783C0", Offset = "0x72775C0", VA = "0x1872783C0")]
	public CPLLNBINCHC(int AICPOKMPBMH, int JMGEJBIPMNO, ComputeShader NPNPOBHEONE, int ONELMLJIDAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class MLPOKBJNNJC : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private DAMFDLDAKFH MHDIDMKJLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool MPKIENECBCP;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool BIMCBDPMCIJ;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x72856E0", Offset = "0x72848E0", VA = "0x1872856E0")]
	public MLPOKBJNNJC(DAMFDLDAKFH BCAFBDBHMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7285550", Offset = "0x7284750", VA = "0x187285550", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer GGLELMAOCGA, RenderingData FENNMANFJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x72852E0", Offset = "0x72844E0", VA = "0x1872852E0", Slot = "6")]
	public override void Configure(CommandBuffer GGLELMAOCGA, RenderTextureDescriptor GOBFHPGEIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7285320", Offset = "0x7284520", VA = "0x187285320", Slot = "9")]
	public override void Execute(ScriptableRenderContext GCGNIOHLIKK, RenderingData FENNMANFJMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class KDHNMCAHCCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct CHAJAHHCANH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string LMOANCJLHKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer GGLELMAOCGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext GCGNIOHLIKK;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x72782B0", Offset = "0x72774B0", VA = "0x1872782B0")]
		public CHAJAHHCANH(string OCGNBMNGHDM, ScriptableRenderContext GLMBKDEKEMH, [Out] CommandBuffer HEKEAHANAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7278200", Offset = "0x7277400", VA = "0x187278200", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7283910", Offset = "0x7282B10", VA = "0x187283910")]
	public static bool ENDFBBDOGEG(RenderingData FENNMANFJMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7283C90", Offset = "0x7282E90", VA = "0x187283C90")]
	public static void PONMDLOKAOJ(CommandBuffer GGLELMAOCGA, ScriptableRenderContext GCGNIOHLIKK, ShadowDrawingSettings MAHNKJFCIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7283A60", Offset = "0x7282C60", VA = "0x187283A60")]
	public static void GKCLKDHKAPM(CommandBuffer GGLELMAOCGA, ScriptableRenderContext GCGNIOHLIKK, RenderingData FENNMANFJMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DAMFDLDAKFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class DOOAMEPEBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int JBFNEFPHJLP;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int IKNLAFIPFMD;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static LOJAJKLLOHJ<KEAHEIAKAJN> GCCDMEPCHHM;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static LOJAJKLLOHJ<uint> FLPBLNIAIFI;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static LHEGGJJKLIM DMBJHKAHAIK;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer BDKGDMOOCLP;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<AODBIOAALCP> AJGBDMBNIOD;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int NNGGFCDLBEL;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int HBMBHIDHAJB;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int GOONEEHFGNL;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int EELLOMMFIHL;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] OPPKMDIEPOH;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] IFNLPFEPGBL;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static AGAIKDAACCA[][] LAADMLEPJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] CNKIEDJOFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int KIOFGIELNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int DFGEPIHCLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int JKKECJJIJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int NBKFAAMHFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int ODOKIHNKAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int AAAJFJHPMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int NIMFDNKKGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int GLCKALBEHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int JOKEHAIIDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int HDANKLDFCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int AAKJMFNKBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int KJNGNGPEDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int EGOHHIAKGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int KBNFPGFIKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int BIGCKIINGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int EJPPBOOLJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int LGCALNPDAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int MCGGIEFPECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] KAPPDIHHLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private ALEICLKADEF MPKLAMJNFGG;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool FCLLELCHFIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x727CFC0", Offset = "0x727C1C0", VA = "0x18727CFC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x727D500", Offset = "0x727C700", VA = "0x18727D500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool CKEKDDKBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7278CC0", Offset = "0x7277EC0", VA = "0x187278CC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7278D10", Offset = "0x7277F10", VA = "0x187278D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData ELDOIBMHPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7278AA0", Offset = "0x7277CA0", VA = "0x187278AA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x727EDC0", Offset = "0x727DFC0", VA = "0x18727EDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static ACMDCFNOEGK BLFIICKOOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x727ED70", Offset = "0x727DF70", VA = "0x18727ED70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x727D010", Offset = "0x727C210", VA = "0x18727D010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static ECJBOMCPJMH IBMFAGDKIHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x727F2B0", Offset = "0x727E4B0", VA = "0x18727F2B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x727A9C0", Offset = "0x7279BC0", VA = "0x18727A9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static NPEILDDJCNJ CJBLLKMMIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x727AA90", Offset = "0x7279C90", VA = "0x18727AA90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x727F300", Offset = "0x727E500", VA = "0x18727F300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static DBCJGMEIOGB LJOJGOPHBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x727ECA0", Offset = "0x727DEA0", VA = "0x18727ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7278A30", Offset = "0x7277C30", VA = "0x187278A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static NAOOOAAIHAA JPBBGIGDDHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x727F370", Offset = "0x727E570", VA = "0x18727F370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x727A820", Offset = "0x7279A20", VA = "0x18727A820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static CPLLNBINCHC KLKMBBBEFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7278F40", Offset = "0x7278140", VA = "0x187278F40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x727C560", Offset = "0x727B760", VA = "0x18727C560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material GJKCPILAOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x727E610", Offset = "0x727D810", VA = "0x18727E610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x727F150", Offset = "0x727E350", VA = "0x18727F150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material IKMFCNMKJNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x727A100", Offset = "0x7279300", VA = "0x18727A100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x727ECF0", Offset = "0x727DEF0", VA = "0x18727ECF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material CJLPOAAFNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x727C660", Offset = "0x727B860", VA = "0x18727C660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x727F230", Offset = "0x727E430", VA = "0x18727F230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material NPOKALDALNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x72789D0", Offset = "0x7277BD0", VA = "0x1872789D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x727C5E0", Offset = "0x727B7E0", VA = "0x18727C5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool KPFFCMGLPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x727F1D0", Offset = "0x727E3D0", VA = "0x18727F1D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x727D560", Offset = "0x727C760", VA = "0x18727D560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool HBPCCECPBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x727AA30", Offset = "0x7279C30", VA = "0x18727AA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string HFBKLCDNBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x727A160", Offset = "0x7279360", VA = "0x18727A160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x727F470", Offset = "0x727E670", VA = "0x18727F470")]
	internal DAMFDLDAKFH([Optional] MClusterData OLJBFIMGCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x727AAE0", Offset = "0x7279CE0", VA = "0x18727AAE0")]
	public void GGPOBANFNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x727C4C0", Offset = "0x727B6C0", VA = "0x18727C4C0")]
	public void GPDGPAFNGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x727A8A0", Offset = "0x7279AA0", VA = "0x18727A8A0")]
	public void DIDLLNEFDGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x727E570", Offset = "0x727D770", VA = "0x18727E570")]
	public bool MLFEOGMCHBN(Hash128 IBBAMBJMMGK, [Out] FOCGMGPLIIP NNPLONBDKAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x727D440", Offset = "0x727C640", VA = "0x18727D440")]
	public FOCGMGPLIIP JMFBCAGPLCG(LGKFHFPJEFH LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x727D080", Offset = "0x727C280", VA = "0x18727D080")]
	public NPMIACKEOHH JMFBCAGPLCG(CDDHKLNEGHH HGJFBFIMOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x727D280", Offset = "0x727C480", VA = "0x18727D280")]
	public EJJJIEFOEML JMFBCAGPLCG(NNKGPLGHIAD IEFGENALBBO, bool MBDLFHCAFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x727C470", Offset = "0x727B670", VA = "0x18727C470")]
	public void GMODDBABBFK(OLNCKOLEDMM CFNJPDBBFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7278E50", Offset = "0x7278050", VA = "0x187278E50")]
	public static void CAGEHKBCEDI(PKLKEEBNENF DDNEALBALGE, AGAIKDAACCA[] LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x727C6C0", Offset = "0x727B8C0", VA = "0x18727C6C0")]
	private void IEBLOEFOKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7279440", Offset = "0x7278640", VA = "0x187279440")]
	private static void CJCOIDBAGJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x727EE30", Offset = "0x727E030", VA = "0x18727EE30")]
	public void OHNPJFFDFIF(CommandBuffer GGLELMAOCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7278AF0", Offset = "0x7277CF0", VA = "0x187278AF0")]
	public void BKAALODDIPF([Optional] ScriptableRenderContext? GCGNIOHLIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x727E9C0", Offset = "0x727DBC0", VA = "0x18727E9C0")]
	public void NHOKHKFEOHF(CommandBuffer GGLELMAOCGA, ShadowSplitData KHPBKINHEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x727E6E0", Offset = "0x727D8E0", VA = "0x18727E6E0")]
	public void NHOKHKFEOHF(CommandBuffer GGLELMAOCGA, CameraData OMNAAFKHJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7278470", Offset = "0x7277670", VA = "0x187278470")]
	public void AAPENNGGKII(CommandBuffer GGLELMAOCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x727E670", Offset = "0x727D870", VA = "0x18727E670")]
	public void NFHEHEMFFOC(CommandBuffer GGLELMAOCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7278FA0", Offset = "0x72781A0", VA = "0x187278FA0")]
	public void CIOPMGPDOKG(CommandBuffer GGLELMAOCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x727BE90", Offset = "0x727B090", VA = "0x18727BE90")]
	public void GLEKOMCNMGN(CommandBuffer GGLELMAOCGA, PKLKEEBNENF JBLEHHBBAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7278D70", Offset = "0x7277F70", VA = "0x187278D70")]
	public void BMOAJMMFAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x727D5C0", Offset = "0x727C7C0", VA = "0x18727D5C0")]
	public void LEGDOGAINAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x727A8B0", Offset = "0x7279AB0", VA = "0x18727A8B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KDFNIBKNLBO
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2472160", Offset = "0x2471360", VA = "0x182472160")]
	public static int OEIOBNOKDPE(int KPGFBDAMCDA, int APCKCOEPEFD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NGKIJIECGAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 ELMDFPCLFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 DAEBFKCLAKI;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly NGKIJIECGAI GPILCIEPFHC;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly NGKIJIECGAI EPGHELDKPDG;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x72859B0", Offset = "0x7284BB0", VA = "0x1872859B0")]
	public NGKIJIECGAI(float4x4 CEKGKJIMEJN, float4 BCHOPCMKGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7285840", Offset = "0x7284A40", VA = "0x187285840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct BDOENEOBHKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 FCKJMOMOHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 LAOLFCMCDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 HBNFPIEAGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 LNEAMGFEOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 CHMBIHNAHIA;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct KBECGLPPHID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 FCKJMOMOHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 LAOLFCMCDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 HBNFPIEAGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 LNEAMGFEOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 CHMBIHNAHIA;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct OCKBCEBHNGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public KBECGLPPHID MCGOEOFGBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public KBECGLPPHID KJMDGBOHCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public KBECGLPPHID GOGDLJKKCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public KBECGLPPHID DLHBEILPJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public KBECGLPPHID PEHPIJBAGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public KBECGLPPHID LJOFKNCJKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public KBECGLPPHID KLFAFMEPKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public KBECGLPPHID HLBMHLJBCOI;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct BOGJMFCBNOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public BDOENEOBHKG MCGOEOFGBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public BDOENEOBHKG KJMDGBOHCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public BDOENEOBHKG GOGDLJKKCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public BDOENEOBHKG DLHBEILPJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public BDOENEOBHKG PEHPIJBAGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public BDOENEOBHKG LJOFKNCJKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public BDOENEOBHKG KLFAFMEPKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public BDOENEOBHKG HLBMHLJBCOI;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct IHEPCKPDFHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 HAHDIMOMHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint EDIEJIFBNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint KBFEGFMJPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float MNPIOFBGBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint MMGENHAEGJJ;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7282DF0", Offset = "0x7281FF0", VA = "0x187282DF0")]
	public IHEPCKPDFHP(CDDHKLNEGHH HGJFBFIMOOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct KEAHEIAKAJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint JKHOONCHEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint FJLBCLEJKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint IMDKDPBPBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint MMGENHAEGJJ;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7283E30", Offset = "0x7283030", VA = "0x187283E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct OGBECKANFJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint IFKAHIJNNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint BODIFIOHOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint GPNDHDAGKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint MMGENHAEGJJ;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7286180", Offset = "0x7285380", VA = "0x187286180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct EBNLMLNIHAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint LMAPNAOMGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint FHDAEODLKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint NIBLCLDDBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint ODKFBAOMAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint CCGANMMHOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint CCCEONCEJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint FEIHKKMGFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint MMGENHAEGJJ;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x727F800", Offset = "0x727EA00", VA = "0x18727F800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct JGPMIGKJHLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 IGPPJCBCCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 LFCLHKAPMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 MNBFAFLCLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 PMIKFBDGBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 AINFECJOPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 HLOHAMLDOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 NOLIEDEGLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 PJEHMDMDDLK;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7282E20", Offset = "0x7282020", VA = "0x187282E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum PKLKEEBNENF
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
