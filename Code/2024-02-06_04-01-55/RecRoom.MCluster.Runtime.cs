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
public struct LJCMILGBJJB
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] KFOJBIDJFLM;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] PCJKGJBPEOM;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] GNFHBABMAPH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFCDF0", VA = "0x180BFD9F0")]
	public static int EOBCMKDJBCC(AJCOHKHIGKB EDCBCPMMAFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60C2ED0", Offset = "0x60C22D0", VA = "0x1860C2ED0")]
	public static int PAPKJHGCCEG(AJCOHKHIGKB EDCBCPMMAFP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NJAOPACGICL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int MLFJOONEMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FAKPMLLHIBL FEANCGLIFKK(int DBHMHAHLCPM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 GPIHIJFHLDJ(int DBHMHAHLCPM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NKGPPJOONDJ GKJAAFCLFLD();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LFLIEAICBMH LNOBFHMHKGP();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PFIMOLJJLAM : EAJAMMPALAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NKGPPJOONDJ NPBNAACKOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform IAOBEOLACNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<NAMCLNCFEDC> CMPDKDAODAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private GFMEOAJCIKB GGBJMINMBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private MJEOFIDFDHI BAKENONEHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool ABPNALCAGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NJAOPACGICL JPBKNLMFFIK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float FDMOMKBIFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E60", Offset = "0x8B4260", VA = "0x1808B4E60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAF1E70", Offset = "0xAF1270", VA = "0x180AF1E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PHGKAHNEAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x818FE0", Offset = "0x8183E0", VA = "0x180818FE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x819580", Offset = "0x818980", VA = "0x180819580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool DNNOJEJMMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEDF620", Offset = "0xEDEA20", VA = "0x180EDF620")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xEDEDC0", Offset = "0xEDE1C0", VA = "0x180EDEDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OOIEMCANFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60C6D80", Offset = "0x60C6180", VA = "0x1860C6D80", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60C6140", Offset = "0x60C5540", VA = "0x1860C6140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NPEEKMGJPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x11760E0", Offset = "0x11754E0", VA = "0x1811760E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60C73C0", Offset = "0x60C67C0", VA = "0x1860C73C0")]
	public PFIMOLJJLAM(NJAOPACGICL NDGLIPKKMHI, bool NEDCPFJPPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60C71A0", Offset = "0x60C65A0", VA = "0x1860C71A0")]
	private bool OCAHLBKCDIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60C6150", Offset = "0x60C5550", VA = "0x1860C6150", Slot = "4")]
	public bool AFPNFDHLNMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60C6FD0", Offset = "0x60C63D0", VA = "0x1860C6FD0", Slot = "5")]
	public bool NEPLKJNDANP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60C6DA0", Offset = "0x60C61A0", VA = "0x1860C6DA0", Slot = "6")]
	public void JJHPGEAJNEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60C6D90", Offset = "0x60C6190", VA = "0x1860C6D90", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface INCILODKDGL
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKPIIGNDCCL(CommandBuffer INICGLDLNHE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EMFIHILDPIJ : INCILODKDGL
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int CFEBOJMAFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x88D230", Offset = "0x88C630", VA = "0x18088D230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier LAFCMBANGJG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3B48AF0", Offset = "0x3B47EF0", VA = "0x183B48AF0")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60B9820", Offset = "0x60B8C20", VA = "0x1860B9820")]
	public EMFIHILDPIJ(int FNOGEAGAPLC, RenderTargetIdentifier ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60B97D0", Offset = "0x60B8BD0", VA = "0x1860B97D0", Slot = "4")]
	public void MKPIIGNDCCL(CommandBuffer INICGLDLNHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct CGPDBLLJJLO : INCILODKDGL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int CFEBOJMAFCI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x88D230", Offset = "0x88C630", VA = "0x18088D230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] ALEDMMMCHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x885AD0", Offset = "0x884ED0", VA = "0x180885AD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xB97460", Offset = "0xB96860", VA = "0x180B97460")]
	public CGPDBLLJJLO(int FNOGEAGAPLC, Vector4[] ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60B7360", Offset = "0x60B6760", VA = "0x1860B7360", Slot = "4")]
	public void MKPIIGNDCCL(CommandBuffer INICGLDLNHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct IAIBNIEJLLB : INCILODKDGL
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int CFEBOJMAFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x88D230", Offset = "0x88C630", VA = "0x18088D230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] IADOHMLDEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x885AD0", Offset = "0x884ED0", VA = "0x180885AD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xB97460", Offset = "0xB96860", VA = "0x180B97460")]
	public IAIBNIEJLLB(int FNOGEAGAPLC, float[] ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60C1400", Offset = "0x60C0800", VA = "0x1860C1400", Slot = "4")]
	public void MKPIIGNDCCL(CommandBuffer INICGLDLNHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct BLHGIHLLLOG : INCILODKDGL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string GAOODFEKINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool DPGNIFMCGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x189CAD0", Offset = "0x189BED0", VA = "0x18189CAD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x32A1E60", Offset = "0x32A1260", VA = "0x1832A1E60")]
	public BLHGIHLLLOG(string GFBABMFGHOJ, bool FAEFLPADKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60B7320", Offset = "0x60B6720", VA = "0x1860B7320", Slot = "4")]
	public void MKPIIGNDCCL(CommandBuffer INICGLDLNHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct LFLIEAICBMH
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 FAHMMAPAPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 OPLFJOILKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB51610", Offset = "0xB50A10", VA = "0x180B51610")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KBCLLCDEPOL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8BDD90", Offset = "0x8BD190", VA = "0x1808BDD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int BKIFDGKAFPI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC20", Offset = "0x7DE020", VA = "0x1807DEC20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float CEFDFHBCCLI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7EC900", Offset = "0x7EBD00", VA = "0x1807EC900")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60C2880", Offset = "0x60C1C80", VA = "0x1860C2880")]
	public LFLIEAICBMH(Color MNHFMCFPMMK, int HHCFJIGPHCJ, int MFEIPIKIEAE, float MKGPGHKIIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x56189F0", Offset = "0x5617DF0", VA = "0x1856189F0")]
	private static float4 FNBLMKKFAGN(Color MNHFMCFPMMK)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60C27F0", Offset = "0x60C1BF0", VA = "0x1860C27F0")]
	private static Hash128 OMHNFMLPKGK(LFLIEAICBMH NDGLIPKKMHI)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GFMEOAJCIKB : EAJAMMPALAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string ELBDLJGJBOK;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string PJAKMJHJHFH;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string KEJFOKBENOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private LFLIEAICBMH ONBMLHFECPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ENHDHONEJJM LNKFECCMIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 LCCADHEAMAH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MJEOFIDFDHI GCOBCFMDJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7C6A80", Offset = "0x7C5E80", VA = "0x1807C6A80")]
		[CompilerGenerated]
		get
		{
			return default(MJEOFIDFDHI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8BB320", Offset = "0x8BA720", VA = "0x1808BB320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PHGKAHNEAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x51B2520", Offset = "0x51B1920", VA = "0x1851B2520")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x51B2530", Offset = "0x51B1930", VA = "0x1851B2530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DNNOJEJMMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1CD6720", Offset = "0x1CD5B20", VA = "0x181CD6720")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0320", Offset = "0x5EAF720", VA = "0x185EB0320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool NPEEKMGJPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool OOIEMCANFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x525BFC0", Offset = "0x525B3C0", VA = "0x18525BFC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0190", Offset = "0x5EAF590", VA = "0x185EB0190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int BLAEHDOLMPP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x60C0FB0", Offset = "0x60C03B0", VA = "0x1860C0FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60C1240", Offset = "0x60C0640", VA = "0x1860C1240")]
	public GFMEOAJCIKB(LFLIEAICBMH FFDIMAKEMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x60C1000", Offset = "0x60C0400", VA = "0x1860C1000")]
	private bool OCAHLBKCDIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60C0BA0", Offset = "0x60BFFA0", VA = "0x1860C0BA0", Slot = "4")]
	public bool AFPNFDHLNMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x60C1110", Offset = "0x60C0510", VA = "0x1860C1110")]
	private static ENHDHONEJJM PPHDFNBIEBN(LFLIEAICBMH NDGLIPKKMHI)
	{
		return default(ENHDHONEJJM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x60C0E00", Offset = "0x60C0200", VA = "0x1860C0E00", Slot = "5")]
	public bool NEPLKJNDANP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x60C0CF0", Offset = "0x60C00F0", VA = "0x1860C0CF0", Slot = "6")]
	public void JJHPGEAJNEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60C3750", Offset = "0x60C2B50", VA = "0x1860C3750", Slot = "0")]
		public override bool Equals(object KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x60C3950", Offset = "0x60C2D50", VA = "0x1860C3950", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x858890", Offset = "0x857C90", VA = "0x180858890")]
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
		private DCJOFCJPFAM opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static FJODDFGJDCP CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x60C4020", Offset = "0x60C3420", VA = "0x1860C4020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x60C4060", Offset = "0x60C3460", VA = "0x1860C4060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60C3A30", Offset = "0x60C2E30", VA = "0x1860C3A30", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x60C3A00", Offset = "0x60C2E00", VA = "0x1860C3A00", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PFFFLMMGJDB, RenderingData IMOFDKOFEBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x60C3E90", Offset = "0x60C3290", VA = "0x1860C3E90")]
		public void LAPFFMDHDJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xB7E890", Offset = "0xB7DC90", VA = "0x180B7E890")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JBCIMOBLLDM<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NODGEDJIBLF JJMCACNEMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NODGEDJIBLF DINJHDDKLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer IMELGFHDIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture JCGLFJNGLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int JBGODCDEMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int NJCKFJBGHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string PBLPLLJOCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string OLLEHGHBBCD;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7A47C0", Offset = "0x7A3BC0", VA = "0x1807A47C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int NKEJGCMGFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xBA0860", Offset = "0xB9FC60", VA = "0x180BA0860")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int JCJJMDIPPBH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD470", Offset = "0x7BC870", VA = "0x1807BD470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x39BFAB0", Offset = "0x39BEEB0", VA = "0x1839BFAB0")]
	public JBCIMOBLLDM(string GFBABMFGHOJ, int MEEHFKKEGOL, [Optional] RenderTextureFormat? BBJFPPIECOB, bool PFPOPEMNGLB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x39BD930", Offset = "0x39BCD30", VA = "0x1839BD930")]
	public void NEPLKJNDANP(CommandBuffer INICGLDLNHE, NativeArray<ValType> ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x39BC0F0", Offset = "0x39BB4F0", VA = "0x1839BC0F0")]
	public void EBECJFLCBOB(CommandBuffer INICGLDLNHE, ComputeShader AELOFFJBMPB, int CEBKONEEEAF, int DCGPFFLLJFJ = -1, int MFLICKGOKLP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x39BC540", Offset = "0x39BB940", VA = "0x1839BC540")]
	public void EBECJFLCBOB(Material LNKFECCMIIP, int DCGPFFLLJFJ = -1, int MFLICKGOKLP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x39BBF50", Offset = "0x39BB350", VA = "0x1839BBF50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IHDOMEJJFMM
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBECJFLCBOB(Material FFDIMAKEMJI);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LHFCBOAEFAB<SrcEntry, DstEntry> : IHDOMEJJFMM, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] IBLKGOKBALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected NODGEDJIBLF LIPGHOMPLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected NODGEDJIBLF LHAADNCNHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> PJLBNCCDNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> LFMBCEDBMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int KFOOPKGGMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int PKKIKMAPGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected JBCIMOBLLDM<int> IHPPEOANACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected JBCIMOBLLDM<SrcEntry> LFNJMNEIBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected JBCIMOBLLDM<DstEntry> BHIHDFPBJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader CCKBDGDPJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int MMHHHGPKMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int JDPCJDGJHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int HHAIHCJCBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int EKFBFPJFLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int GAKENBHOIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int FCEDMANKDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int ALLFFLMMIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int EBCFPNKBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int KLIFJAMJFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int CEMGJOIMIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int GEKJPDLLEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int MJGMPFJODCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string LBDEIDPFNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] NBGOLNLIDEB;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int LBMAEDLDEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3B9E230", Offset = "0x3B9D630", VA = "0x183B9E230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string CPOPMCOBCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3B9EAB0", Offset = "0x3B9DEB0", VA = "0x183B9EAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3BA17C0", Offset = "0x3BA0BC0", VA = "0x183BA17C0")]
	public LHFCBOAEFAB(string GFBABMFGHOJ, int GDNMBNNDKGO, int FOPLMPPBHFK, RenderTextureFormat BBJFPPIECOB, ComputeShader NDFGHBDCLPD, int NEBECAGIIEO = 0, int BNOMBEPBNLG = 0, int APCIBJPPCGH = 0, int EADNHLFONJC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0970", Offset = "0x3B9FD70", VA = "0x183BA0970")]
	public int OHBBJBHAMEM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D9E0", Offset = "0x3B9CDE0", VA = "0x183B9D9E0")]
	protected void APGFFJMAKPC(int AHDNEIKOMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D870", Offset = "0x3B9CC70", VA = "0x183B9D870")]
	public MJEOFIDFDHI AFPNFDHLNMK(SrcEntry ALPLHOOHPEL)
	{
		return default(MJEOFIDFDHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA07D0", Offset = "0x3B9FBD0", VA = "0x183BA07D0")]
	public bool NEPLKJNDANP(MJEOFIDFDHI PPOPFLAHPIC, SrcEntry ALPLHOOHPEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3B9DFB0", Offset = "0x3B9D3B0", VA = "0x183B9DFB0")]
	public bool JJHPGEAJNEC(MJEOFIDFDHI PPOPFLAHPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "6")]
	protected virtual void HGHMFGBFBBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F050", Offset = "0x3B9E450", VA = "0x183B9F050", Slot = "7")]
	public void LPMDBPIKLJF(CommandBuffer INICGLDLNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3B9FCE0", Offset = "0x3B9F0E0", VA = "0x183B9FCE0", Slot = "8")]
	public void LPMDBPIKLJF(CommandBuffer INICGLDLNHE, ComputeShader NDFGHBDCLPD, int NEBECAGIIEO = -1, int BNOMBEPBNLG = -1, int APCIBJPPCGH = -1, int EADNHLFONJC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3B9DDF0", Offset = "0x3B9D1F0", VA = "0x183B9DDF0", Slot = "9")]
	public void EBECJFLCBOB(CommandBuffer INICGLDLNHE, ComputeShader NDFGHBDCLPD, int NEBECAGIIEO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3B9DF60", Offset = "0x3B9D360", VA = "0x183B9DF60", Slot = "4")]
	public void EBECJFLCBOB(Material LNKFECCMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3B9DA30", Offset = "0x3B9CE30", VA = "0x183B9DA30", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NODGEDJIBLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong DFJHJACDIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong ECJJJALNNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KBFEHPPBBMC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct APHBBOECMMG : NODGEDJIBLF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable CKFMKEFECJJ;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong DFJHJACDIEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x885AD0", Offset = "0x884ED0", VA = "0x180885AD0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5909550", Offset = "0x5908950", VA = "0x185909550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong ECJJJALNNCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1271A30", Offset = "0x1270E30", VA = "0x181271A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x60B7090", Offset = "0x60B6490", VA = "0x1860B7090")]
		internal APHBBOECMMG(IDisposable GEKMAHACEOH, ulong FDCKBBHGFOB, ulong ICOOCLFIBJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x60B7010", Offset = "0x60B6410", VA = "0x1860B7010", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct HCDPEKLCMBE : NODGEDJIBLF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture EKHIFGPMGLH;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong DFJHJACDIEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x885AD0", Offset = "0x884ED0", VA = "0x180885AD0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5909550", Offset = "0x5908950", VA = "0x185909550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong ECJJJALNNCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1271A30", Offset = "0x1270E30", VA = "0x181271A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x60C13D0", Offset = "0x60C07D0", VA = "0x1860C13D0")]
		public HCDPEKLCMBE(RenderTexture OOHGPGNBBID, ulong ECNLNNFGNDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x60C1330", Offset = "0x60C0730", VA = "0x1860C1330", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong PJOJJLNAOAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x60C1E10", Offset = "0x60C1210", VA = "0x1860C1E10")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x60C1DD0", Offset = "0x60C11D0", VA = "0x1860C1DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong KBOFOGILKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x60C1580", Offset = "0x60C0980", VA = "0x1860C1580")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x60C1C90", Offset = "0x60C1090", VA = "0x1860C1C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x60C1960", Offset = "0x60C0D60", VA = "0x1860C1960")]
	public static ComputeBuffer HDHFILGDDKG(int CBPPKGAPPDD, int KKGIHHAGFBD, ComputeBufferType FICJMFBEBIN, [Out] NODGEDJIBLF PPOPFLAHPIC, ComputeBufferMode JNDDDHJCEHM = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x60C15C0", Offset = "0x60C09C0", VA = "0x1860C15C0")]
	public static RenderTexture HDHFILGDDKG(int GEMHPEEAHOI, int EKMHLMNPMCN, int DGPPGOLOKKH, RenderTextureFormat BBJFPPIECOB, [Out] NODGEDJIBLF PPOPFLAHPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2706480", Offset = "0x2705880", VA = "0x182706480")]
	public static NativeArray<T> HMIOCPLIPKD<T>(NativeArray<T> CKFMKEFECJJ, ulong FLCGLAMBOBC, [Out] NODGEDJIBLF PPOPFLAHPIC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x27063E0", Offset = "0x27057E0", VA = "0x1827063E0")]
	public static NativeArray<T> HDHFILGDDKG<T>(int FLCGLAMBOBC, Allocator OLAJGHFDGHM, [Out] NODGEDJIBLF PPOPFLAHPIC, NativeArrayOptions GGBINCNBHKJ = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x60C1B40", Offset = "0x60C0F40", VA = "0x1860C1B40")]
	public static void HJKKNDHGMPB(NODGEDJIBLF CKFMKEFECJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60C1CD0", Offset = "0x60C10D0", VA = "0x1860C1CD0")]
	public static uint JNLGFIDGMIB(RenderTextureFormat BBJFPPIECOB)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EBNPPLHMGOI : LHFCBOAEFAB<BLBPDKHOAMH, BLBPDKHOAMH>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct LOJKABHPBJH : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> FDGBCAPMECJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> DPLOADMPBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> ALIFGHGOOHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> IAADOAPCIGC;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x60C14A0", Offset = "0x60C08A0", VA = "0x1860C14A0")]
		public LOJKABHPBJH(NativeArray<int> OMIJNHCMLMI, NativeArray<float> IJEMMEOFIJK, NativeArray<float4x4> OCOHIBGBLLA, NativeArray<float4> GNAMEIGJHAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x60C3590", Offset = "0x60C2990", VA = "0x1860C3590", Slot = "4")]
		public void Execute(int AHDNEIKOMIB, TransformAccess NPBNAACKOLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct IOKHEGGEIEE : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> FDGBCAPMECJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> NLCFNDGABJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> HFCPAEJCIGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<BLBPDKHOAMH> EIFPIOBCMEK;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x60C14A0", Offset = "0x60C08A0", VA = "0x1860C14A0")]
		public IOKHEGGEIEE(NativeArray<int> OMIJNHCMLMI, NativeArray<float4x4> JLJNBHANBJC, NativeArray<float4> COKCAGBINNN, NativeArray<BLBPDKHOAMH> LHDFPPNLHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x60C1430", Offset = "0x60C0830", VA = "0x1860C1430", Slot = "4")]
		public void Execute(int AHDNEIKOMIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte CNDDIEPKJOC = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray HDLHHCJJDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> DHEIGIHCJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> ADJIEPLLBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> DHFHJFANEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> NIINPAPINBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> LBAGOANKKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NODGEDJIBLF KBJMKOKDMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NODGEDJIBLF DMCPOICPFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NODGEDJIBLF PPKGPKNNCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NODGEDJIBLF IGBMOJPAEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NODGEDJIBLF BGOFBLDKFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform CAECCMBAHCE;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x60B94F0", Offset = "0x60B88F0", VA = "0x1860B94F0")]
	public EBNPPLHMGOI(int GDNMBNNDKGO, int FOPLMPPBHFK, ComputeShader NDFGHBDCLPD, int NEBECAGIIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x60B8F40", Offset = "0x60B8340", VA = "0x1860B8F40", Slot = "6")]
	protected override void HGHMFGBFBBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x60B91F0", Offset = "0x60B85F0", VA = "0x1860B91F0")]
	private void JJECJLPEIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60B92B0", Offset = "0x60B86B0", VA = "0x1860B92B0")]
	public bool OIHHBJHBKHB(MJEOFIDFDHI PPOPFLAHPIC, Transform NPBNAACKOLN, float PLPFJOPKGIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x60B9410", Offset = "0x60B8810", VA = "0x1860B9410")]
	public void PNONBHONAEG(MJEOFIDFDHI PPOPFLAHPIC, float PLPFJOPKGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x60B9140", Offset = "0x60B8540", VA = "0x1860B9140")]
	public void JIFJPJIJCBI(MJEOFIDFDHI PPOPFLAHPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x60B8EA0", Offset = "0x60B82A0", VA = "0x1860B8EA0", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FAKPMLLHIBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IIBGMLIJNCJ DMBFJJDECOC();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PABKFCAKPOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 FAHMMAPAPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int LHJJKLGJPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int JIPENEKAMNG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> EAICKOBNBAN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> CDMAJCLKHAC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> AINDCOHFIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> NDLFAAOGPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> HPAAONCIEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> IHPNDENADKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int ELOBDIKKNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int DNDHDOBFPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int IEEEIJEBGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool IKLFHFBFHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LPMDBPIKLJF();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CMHJOHAOAPG : PABKFCAKPOD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private FAKPMLLHIBL CDDPFLJBGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IIBGMLIJNCJ FEBNKEJJFPJ;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 FAHMMAPAPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xB51610", Offset = "0xB50A10", VA = "0x180B51610", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1BCBFB0", Offset = "0x1BCB3B0", VA = "0x181BCBFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool KEAPFNAFJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7A5800", Offset = "0x7A4C00", VA = "0x1807A5800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int LHJJKLGJPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC20", Offset = "0x7DE020", VA = "0x1807DEC20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDE50", VA = "0x1807DEA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int JIPENEKAMNG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7A9520", Offset = "0x7A8920", VA = "0x1807A9520", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7A9510", Offset = "0x7A8910", VA = "0x1807A9510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int EJDHMDEAAAL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9395D0", Offset = "0x9389D0", VA = "0x1809395D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> EAICKOBNBAN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x60B7650", Offset = "0x60B6A50", VA = "0x1860B7650", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> CDMAJCLKHAC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x60B73B0", Offset = "0x60B67B0", VA = "0x1860B73B0", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> AINDCOHFIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x60B75F0", Offset = "0x60B69F0", VA = "0x1860B75F0", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> NDLFAAOGPGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x60B7470", Offset = "0x60B6870", VA = "0x1860B7470", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> HPAAONCIEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x60B76C0", Offset = "0x60B6AC0", VA = "0x1860B76C0", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> IHPNDENADKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x60B76F0", Offset = "0x60B6AF0", VA = "0x1860B76F0", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IKLFHFBFHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7EC380", Offset = "0x7EB780", VA = "0x1807EC380", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7EC910", Offset = "0x7EBD10", VA = "0x1807EC910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int ELOBDIKKNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x60B7640", Offset = "0x60B6A40", VA = "0x1860B7640", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int DNDHDOBFPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x60B7620", Offset = "0x60B6A20", VA = "0x1860B7620", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int IEEEIJEBGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x60B7390", Offset = "0x60B6790", VA = "0x1860B7390", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x60B7720", Offset = "0x60B6B20", VA = "0x1860B7720")]
	public CMHJOHAOAPG(Hash128 GMMFGHNCIAK, FAKPMLLHIBL CDDPFLJBGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x60B74E0", Offset = "0x60B68E0", VA = "0x1860B74E0", Slot = "16")]
	public void LPMDBPIKLJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x60B73E0", Offset = "0x60B67E0", VA = "0x1860B73E0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct MJEOFIDFDHI : IEquatable<MJEOFIDFDHI>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly MJEOFIDFDHI FGEMAOBKBLF;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int BLAEHDOLMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x88D230", Offset = "0x88C630", VA = "0x18088D230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x88D240", Offset = "0x88C640", VA = "0x18088D240")]
	public MJEOFIDFDHI(int AHDNEIKOMIB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x60C40C0", Offset = "0x60C34C0", VA = "0x1860C40C0", Slot = "4")]
	public bool Equals(MJEOFIDFDHI KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x60C4110", Offset = "0x60C3510", VA = "0x1860C4110", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x60C41E0", Offset = "0x60C35E0", VA = "0x1860C41E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NAMCLNCFEDC : EAJAMMPALAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool ABPNALCAGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private PABKFCAKPOD HPIGCIFNKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<MJEOFIDFDHI> FPENGJCMECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<MJEOFIDFDHI> EHKGAEEOIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<MJEOFIDFDHI> EMMDFBLDBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> BAOHHPMPMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int LCIPOMAKBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int EDDFJNNBDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int EIHJCEJMNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int DICLMNBJBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int LEGNHFPOHBE;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int BLAEHDOLMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x60C5B90", Offset = "0x60C4F90", VA = "0x1860C5B90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x60C5C40", Offset = "0x60C5040", VA = "0x1860C5C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool PHGKAHNEAEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7EC020", Offset = "0x7EB420", VA = "0x1807EC020")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x992880", Offset = "0x991C80", VA = "0x180992880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool DNNOJEJMMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x992870", Offset = "0x991C70", VA = "0x180992870")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x992890", Offset = "0x991C90", VA = "0x180992890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool NPEEKMGJPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool OOIEMCANFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x16979F0", Offset = "0x1696DF0", VA = "0x1816979F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1697A00", Offset = "0x1696E00", VA = "0x181697A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float FDMOMKBIFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1A1E0F0", Offset = "0x1A1D4F0", VA = "0x181A1E0F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1A1DFA0", Offset = "0x1A1D3A0", VA = "0x181A1DFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x60C5F20", Offset = "0x60C5320", VA = "0x1860C5F20")]
	public NAMCLNCFEDC(PABKFCAKPOD FEBNKEJJFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x60C4CF0", Offset = "0x60C40F0", VA = "0x1860C4CF0")]
	private void GDPJALNLPCJ(PABKFCAKPOD FEBNKEJJFPJ, int LCIPOMAKBKD, int IKMNNIEAGKA, int AHDNEIKOMIB, int HEKGOGEOEAI, DBKHGFAGNMJ ALPLHOOHPEL, float NNCIFKHAONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x60C5840", Offset = "0x60C4C40", VA = "0x1860C5840")]
	private void KKKLGLFBOLN(PABKFCAKPOD FEBNKEJJFPJ, int LCOGAEGKMGC, int AHDNEIKOMIB, uint3 NLJODBFAFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x60C5C80", Offset = "0x60C5080", VA = "0x1860C5C80")]
	private bool OCAHLBKCDIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x60C42F0", Offset = "0x60C36F0", VA = "0x1860C42F0", Slot = "4")]
	public bool AFPNFDHLNMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x60C5B10", Offset = "0x60C4F10", VA = "0x1860C5B10", Slot = "5")]
	public bool NEPLKJNDANP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x60C51D0", Offset = "0x60C45D0", VA = "0x1860C51D0", Slot = "6")]
	public void JJHPGEAJNEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x60C4C90", Offset = "0x60C4090", VA = "0x1860C4C90")]
	public void ODCEHCPPOND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x60C4C90", Offset = "0x60C4090", VA = "0x1860C4C90", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EAJAMMPALAL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool NPEEKMGJPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool OOIEMCANFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AFPNFDHLNMK();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NEPLKJNDANP();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJHPGEAJNEC();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CNKNMHIBIMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float CEKMGFKDOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, NAMCLNCFEDC> AGDGDAAODBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, GFMEOAJCIKB> MJLONGCBGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<EAJAMMPALAL> BNIEGDMBLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<EAJAMMPALAL> GMOLPKAEOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<EAJAMMPALAL> CDIAEKFKNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int BLOGMMFNJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int GGADDNIBIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float KIJEOGFHBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool CEAPAOPLGMD;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool FEGPKIHPIOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xBA4FD0", Offset = "0xBA43D0", VA = "0x180BA4FD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xBC15C0", Offset = "0xBC09C0", VA = "0x180BC15C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool GAKHIFPDGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x60B7A70", Offset = "0x60B6E70", VA = "0x1860B7A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string CPOPMCOBCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x60B7AC0", Offset = "0x60B6EC0", VA = "0x1860B7AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x60B7A50", Offset = "0x60B6E50", VA = "0x1860B7A50")]
	public void GKDFMGAAPIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x60B7A60", Offset = "0x60B6E60", VA = "0x1860B7A60")]
	public void HBOBKFNGOFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x60B88D0", Offset = "0x60B7CD0", VA = "0x1860B88D0")]
	public CNKNMHIBIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x60B8760", Offset = "0x60B7B60", VA = "0x1860B8760")]
	public PFIMOLJJLAM NLKKEGKJEDJ(NJAOPACGICL EANIAGEJDFL, bool NEDCPFJPPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x60B8620", Offset = "0x60B7A20", VA = "0x1860B8620")]
	public GFMEOAJCIKB NLKKEGKJEDJ(LFLIEAICBMH LNKFECCMIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x60B79E0", Offset = "0x60B6DE0", VA = "0x1860B79E0")]
	public bool FIHLADMCPJO(Hash128 FNOGEAGAPLC, [Out] NAMCLNCFEDC IJBIPICECFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x60B8330", Offset = "0x60B7730", VA = "0x1860B8330")]
	public NAMCLNCFEDC NLKKEGKJEDJ(PABKFCAKPOD FEBNKEJJFPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x60B7930", Offset = "0x60B6D30", VA = "0x1860B7930")]
	private void EGHENLEGDFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x60B7950", Offset = "0x60B6D50", VA = "0x1860B7950")]
	private bool FBBCKLFNJHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x60B7E60", Offset = "0x60B7260", VA = "0x1860B7E60")]
	public void LPMDBPIKLJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x60B7770", Offset = "0x60B6B70", VA = "0x1860B7770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x60B7880", Offset = "0x60B6C80", VA = "0x1860B7880")]
	public void EGGINPAKHMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KMJMEANCNGJ : LHFCBOAEFAB<KICGDJMPGLF, KICGDJMPGLF>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x60C2580", Offset = "0x60C1980", VA = "0x1860C2580")]
	public KMJMEANCNGJ(int GDNMBNNDKGO, int FOPLMPPBHFK, ComputeShader NDFGHBDCLPD, int NEBECAGIIEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JGMGJKLBMCK : LHFCBOAEFAB<ENHDHONEJJM, ENHDHONEJJM>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x60C14D0", Offset = "0x60C08D0", VA = "0x1860C14D0")]
	public JGMGJKLBMCK(int GDNMBNNDKGO, int FOPLMPPBHFK, ComputeShader NDFGHBDCLPD, int NEBECAGIIEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NPCOHGAPLCH : LHFCBOAEFAB<AABKHECKIAI, AABKHECKIAI>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x60C6090", Offset = "0x60C5490", VA = "0x1860C6090")]
	public NPCOHGAPLCH(int GDNMBNNDKGO, int FOPLMPPBHFK, ComputeShader NDFGHBDCLPD, int NEBECAGIIEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class GJNPBJIHEIC : LHFCBOAEFAB<HOJLONGHMDB, DDBFADKPDLF>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x60C1280", Offset = "0x60C0680", VA = "0x1860C1280")]
	public GJNPBJIHEIC(int GDNMBNNDKGO, int FOPLMPPBHFK, ComputeShader NDFGHBDCLPD, int NEBECAGIIEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FHPNOCLEDAL : LHFCBOAEFAB<KCEDFGABMAN, KCEDFGABMAN>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x60B9870", Offset = "0x60B8C70", VA = "0x1860B9870")]
	public FHPNOCLEDAL(int GDNMBNNDKGO, int FOPLMPPBHFK, ComputeShader NDFGHBDCLPD, int NEBECAGIIEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class DCJOFCJPFAM : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private FJODDFGJDCP NPPIDMEHNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool FAEFLPADKEG;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool HLNCJJJFIHA;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x60B8E60", Offset = "0x60B8260", VA = "0x1860B8E60")]
	public DCJOFCJPFAM(FJODDFGJDCP HMLEFEJGMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x60B8CD0", Offset = "0x60B80D0", VA = "0x1860B8CD0", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer INICGLDLNHE, RenderingData IMOFDKOFEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x60B8A60", Offset = "0x60B7E60", VA = "0x1860B8A60", Slot = "6")]
	public override void Configure(CommandBuffer INICGLDLNHE, RenderTextureDescriptor JKHPGFPKELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x60B8AA0", Offset = "0x60B7EA0", VA = "0x1860B8AA0", Slot = "9")]
	public override void Execute(ScriptableRenderContext HFPPGLCONIA, RenderingData IMOFDKOFEBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class LGENGILFAAF
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct LFDAJLIKMEO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string GFBABMFGHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer INICGLDLNHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext HFPPGLCONIA;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x60C26E0", Offset = "0x60C1AE0", VA = "0x1860C26E0")]
		public LFDAJLIKMEO(string OODCMNOKHHO, ScriptableRenderContext PLPCJOMEENJ, [Out] CommandBuffer MIDAKOPJLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x60C2630", Offset = "0x60C1A30", VA = "0x1860C2630", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x60C29B0", Offset = "0x60C1DB0", VA = "0x1860C29B0")]
	public static bool BFGCMDMMIGB(RenderingData IMOFDKOFEBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x60C2B00", Offset = "0x60C1F00", VA = "0x1860C2B00")]
	public static void KBJAOKDJEDB(CommandBuffer INICGLDLNHE, ScriptableRenderContext HFPPGLCONIA, ShadowDrawingSettings OBANFEMJALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x60C2CA0", Offset = "0x60C20A0", VA = "0x1860C2CA0")]
	public static void MDCPEKICOJA(CommandBuffer INICGLDLNHE, ScriptableRenderContext HFPPGLCONIA, RenderingData IMOFDKOFEBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class FJODDFGJDCP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class MNABPKOEJOC
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int JIMPBGLPCNA;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int GLCPLELCJEC;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static JBCIMOBLLDM<BHPGIFAKKCM> OJALOFBFELM;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static JBCIMOBLLDM<uint> MKOALBKNDFK;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static NODGEDJIBLF BFAHCDGBEEK;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer HEJEHBNHHHC;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<IHDOMEJJFMM> MLNBAPINJGF;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int GJDOMMKPCJJ;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int HKKDDANGKAL;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int BMPDMLHDDOD;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int IBMLCDJDOMP;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] HBEFNAEABAP;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] EGBIOMGADAI;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static INCILODKDGL[][] IDOKJNJAHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] AAHJENJCGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int NLOHEKLLAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int LLIBOMFMPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int JDMIMIMFPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int HAGNJAMGCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int PAPGJLCCMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int KCHOEMLPLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int GCGHPFLLDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int LBGIBHPDJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int BCJKBNEAHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int KAFBIKODAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int HENGBPANHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int GNAHNOKAMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int DLLGADMODGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int BDJPIONONFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int BMJFCNLNDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int NMKBPFDIAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int LBAJLGFAHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int EHKHNOCCAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] FKEGCNNAGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private CNKNMHIBIMI GIKNJLJEKLH;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool JBOPHGOEFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x60BE690", Offset = "0x60BDA90", VA = "0x1860BE690")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x60BB920", Offset = "0x60BAD20", VA = "0x1860BB920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool KOIGHBKIGJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x60BB0E0", Offset = "0x60BA4E0", VA = "0x1860BB0E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x60BD520", Offset = "0x60BC920", VA = "0x1860BD520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData NCANEPOJAJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x60BD750", Offset = "0x60BCB50", VA = "0x1860BD750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x60BD080", Offset = "0x60BC480", VA = "0x1860BD080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static EBNPPLHMGOI NGGAPMFGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x60BE140", Offset = "0x60BD540", VA = "0x1860BE140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x60BFA90", Offset = "0x60BEE90", VA = "0x1860BFA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static KMJMEANCNGJ CJNJAGCJDBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x60BE020", Offset = "0x60BD420", VA = "0x1860BE020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x60BD140", Offset = "0x60BC540", VA = "0x1860BD140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static JGMGJKLBMCK NAICNDGLHAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x60BA060", Offset = "0x60B9460", VA = "0x1860BA060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x60BE0D0", Offset = "0x60BD4D0", VA = "0x1860BE0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static NPCOHGAPLCH DLKMHAODCJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x60BD0F0", Offset = "0x60BC4F0", VA = "0x1860BD0F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x60BB850", Offset = "0x60BAC50", VA = "0x1860BB850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static GJNPBJIHEIC FMJDNAJEBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x60BA780", Offset = "0x60B9B80", VA = "0x1860BA780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x60B99C0", Offset = "0x60B8DC0", VA = "0x1860B99C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static FHPNOCLEDAL EMMMOJEGGPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x60C0840", Offset = "0x60BFC40", VA = "0x1860C0840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x60BE190", Offset = "0x60BD590", VA = "0x1860BE190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material LGGDIKIOOMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x60BB8C0", Offset = "0x60BACC0", VA = "0x1860BB8C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x60BDFA0", Offset = "0x60BD3A0", VA = "0x1860BDFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material OIJNKGMBIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x60BBA70", Offset = "0x60BAE70", VA = "0x1860BBA70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x60BBFD0", Offset = "0x60BB3D0", VA = "0x1860BBFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material MEEKMJFIHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x60BBAD0", Offset = "0x60BAED0", VA = "0x1860BBAD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x60BB130", Offset = "0x60BA530", VA = "0x1860BB130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material AIIILFNILKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x60BA000", Offset = "0x60B9400", VA = "0x1860BA000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x60C07C0", Offset = "0x60BFBC0", VA = "0x1860C07C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool HFEBNNDLAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x60BA0B0", Offset = "0x60B94B0", VA = "0x1860BA0B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x60BE070", Offset = "0x60BD470", VA = "0x1860BE070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool GAKHIFPDGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x60BD7A0", Offset = "0x60BCBA0", VA = "0x1860BD7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string CPOPMCOBCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x60BD800", Offset = "0x60BCC00", VA = "0x1860BD800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x60C0940", Offset = "0x60BFD40", VA = "0x1860C0940")]
	internal FJODDFGJDCP([Optional] MClusterData FBABBOCFOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x60BE6E0", Offset = "0x60BDAE0", VA = "0x1860BE6E0")]
	public void OBMDJKKOMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x60B9920", Offset = "0x60B8D20", VA = "0x1860B9920")]
	public void APBHMIEBDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x60BC050", Offset = "0x60BB450", VA = "0x1860BC050")]
	public void HFKPHKAIKMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x60BB7B0", Offset = "0x60BABB0", VA = "0x1860BB7B0")]
	public bool EPLHCOJMLJA(Hash128 GMMFGHNCIAK, [Out] NAMCLNCFEDC FEBNKEJJFPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x60BE3D0", Offset = "0x60BD7D0", VA = "0x1860BE3D0")]
	public NAMCLNCFEDC NLKKEGKJEDJ(PABKFCAKPOD ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x60BE490", Offset = "0x60BD890", VA = "0x1860BE490")]
	public GFMEOAJCIKB NLKKEGKJEDJ(LFLIEAICBMH LNKFECCMIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x60BE210", Offset = "0x60BD610", VA = "0x1860BE210")]
	public PFIMOLJJLAM NLKKEGKJEDJ(NJAOPACGICL EANIAGEJDFL, bool NEDCPFJPPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x60BD4D0", Offset = "0x60BC8D0", VA = "0x1860BD4D0")]
	public void JJHPGEAJNEC(EAJAMMPALAL DDIFDMJCCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x60BB980", Offset = "0x60BAD80", VA = "0x1860BB980")]
	public static void FKGNCLCOMKC(AJCOHKHIGKB EDCBCPMMAFP, INCILODKDGL[] ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x60BA7E0", Offset = "0x60B9BE0", VA = "0x1860BA7E0")]
	private void EFPDNIKEPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x60BFB00", Offset = "0x60BEF00", VA = "0x1860BFB00")]
	private static void OHFNALBDPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x60BD1B0", Offset = "0x60BC5B0", VA = "0x1860BD1B0")]
	public void IBMEBNJMFHI(CommandBuffer INICGLDLNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x60BD580", Offset = "0x60BC980", VA = "0x1860BD580")]
	public void KCJADOBCMFE([Optional] ScriptableRenderContext? HFPPGLCONIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x60B9D20", Offset = "0x60B9120", VA = "0x1860B9D20")]
	public void CFFGCMAIBNG(CommandBuffer INICGLDLNHE, ShadowSplitData EPBDEEPBINJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x60B9A40", Offset = "0x60B8E40", VA = "0x1860B9A40")]
	public void CFFGCMAIBNG(CommandBuffer INICGLDLNHE, CameraData IMLMEHPAOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x60BA220", Offset = "0x60B9620", VA = "0x1860BA220")]
	public void EDMKHLKGDME(CommandBuffer INICGLDLNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x60BD010", Offset = "0x60BC410", VA = "0x1860BD010")]
	public void HJMAGAABANF(CommandBuffer INICGLDLNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x60BBB30", Offset = "0x60BAF30", VA = "0x1860BBB30")]
	public void GGPENOGPBCK(CommandBuffer INICGLDLNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x60BB1B0", Offset = "0x60BA5B0", VA = "0x1860BB1B0")]
	public void ELEGOCOMKAC(CommandBuffer INICGLDLNHE, AJCOHKHIGKB FEFCBMEKALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x60BDEC0", Offset = "0x60BD2C0", VA = "0x1860BDEC0")]
	public void LAPFFMDHDJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x60BC060", Offset = "0x60BB460", VA = "0x1860BC060")]
	public void HJKKNDHGMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x60BA110", Offset = "0x60B9510", VA = "0x1860BA110", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LAGJPLFCAHM
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1CC45F0", Offset = "0x1CC39F0", VA = "0x181CC45F0")]
	public static int LLHIBFDFPFH(int FPJGJJLGENP, int IGMFECJMEDC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BLBPDKHOAMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 MNIIAKDHNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 KMOKKCKIAHC;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly BLBPDKHOAMH BPFIBLDNEAB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly BLBPDKHOAMH FGEMAOBKBLF;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x60B72F0", Offset = "0x60B66F0", VA = "0x1860B72F0")]
	public BLBPDKHOAMH(float4x4 FECMCDJIJNH, float4 LPAMEGHEHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x60B7180", Offset = "0x60B6580", VA = "0x1860B7180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct DBKHGFAGNMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 BEBKKMFGLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 PKPPJECMOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 FNLHDMNBHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 LHMLONMFELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 OMOBALEBIMM;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct HMIFHNIIECO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 BEBKKMFGLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 PKPPJECMOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 FNLHDMNBHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 LHMLONMFELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 OMOBALEBIMM;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct DDBFADKPDLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public HMIFHNIIECO OAOFHGJGMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public HMIFHNIIECO OHNDDMFEBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public HMIFHNIIECO OLGLFFKBOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public HMIFHNIIECO LIHMGIPCAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public HMIFHNIIECO CHOBBEGLKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public HMIFHNIIECO LOLHDKNJDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public HMIFHNIIECO CEFCOEPACKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public HMIFHNIIECO OCLNCHFGOCB;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct HOJLONGHMDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public DBKHGFAGNMJ OAOFHGJGMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public DBKHGFAGNMJ OHNDDMFEBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public DBKHGFAGNMJ OLGLFFKBOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public DBKHGFAGNMJ LIHMGIPCAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public DBKHGFAGNMJ CHOBBEGLKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public DBKHGFAGNMJ LOLHDKNJDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public DBKHGFAGNMJ CEFCOEPACKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public DBKHGFAGNMJ OCLNCHFGOCB;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct ENHDHONEJJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 KBCMOCELGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint HHCFJIGPHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint MFEIPIKIEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float MKGPGHKIIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint BDAIENBKGEK;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x60B9840", Offset = "0x60B8C40", VA = "0x1860B9840")]
	public ENHDHONEJJM(LFLIEAICBMH LNKFECCMIIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct BHPGIFAKKCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint OEFLAKAECLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint KFFCMBDPNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint HEKGOGEOEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint BDAIENBKGEK;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x60B70D0", Offset = "0x60B64D0", VA = "0x1860B70D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct AABKHECKIAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint IKMNNIEAGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint LBMHIHIPOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint EDDFJNNBDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint BDAIENBKGEK;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x60B6F60", Offset = "0x60B6360", VA = "0x1860B6F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct KICGDJMPGLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint OMIPEKELJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint CEIOAFBLBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint PELCMELNKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint MGPGDBDFIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint MIKGKFPLLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint AMEJPDPDHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint JMNDBGIFJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint BDAIENBKGEK;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x60C2250", Offset = "0x60C1650", VA = "0x1860C2250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct KCEDFGABMAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 ACHICKKKNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 GJDCDAEEPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 IHNBFBJBJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 LMOFHBPBNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 CLCCOCFJJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 BGDKBDLILDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 NGBEFDJKOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 NCDEPOCFJHL;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x60C1E50", Offset = "0x60C1250", VA = "0x1860C1E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum AJCOHKHIGKB
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
