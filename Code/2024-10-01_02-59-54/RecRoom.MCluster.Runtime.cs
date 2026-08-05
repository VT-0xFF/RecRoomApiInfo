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
public struct PACOIIELBJN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] HDHKNAKFKEA;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] AIFHBLMINMG;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] FJDOBFIENBJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x175DE00", Offset = "0x175D200", VA = "0x18175DE00")]
	public static int IIDCPBMKACI(EJFHILFIBME NHDCAJADCDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E47CB0", Offset = "0x6E470B0", VA = "0x186E47CB0")]
	public static int JAAPBINIHDL(EJFHILFIBME NHDCAJADCDM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DGJCECDPCLD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int CAOCOMLLJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AFFHHGAMIDE BJCDAANMOCA(int KFELJFNOKBH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 MNDNNEMFDAD(int KFELJFNOKBH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FHDOGMIMPJP FIIOGPBNPNI();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KJEIPAMCNBJ BBDAEKKKMMA();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class JFOCFCCEAKN : OFGJNHPIIME, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private FHDOGMIMPJP ADJOLMKPBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform INEGDDEDNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<HHEBONNCDMA> KAOCGIHELCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private APKGHBJCMDG AIKEMHMFICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private BODJOFHKIPI PACOEJIBIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool MENDKKGINHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private DGJCECDPCLD APKLAHAMIGH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float JGHOBPGLLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA884E0", Offset = "0xA878E0", VA = "0x180A884E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDCC6C0", Offset = "0xDCBAC0", VA = "0x180DCC6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GIIIBAIHELG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x91B4E0", Offset = "0x91A8E0", VA = "0x18091B4E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9B9090", Offset = "0x9B8490", VA = "0x1809B9090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NFKCPANOHLA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD58880", Offset = "0xD57C80", VA = "0x180D58880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD58410", Offset = "0xD57810", VA = "0x180D58410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CPCHKPINGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x64A7420", Offset = "0x64A6820", VA = "0x1864A7420", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x64A75E0", Offset = "0x64A69E0", VA = "0x1864A75E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MHLFDCHJNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x188C190", Offset = "0x188B590", VA = "0x18188C190", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E464D0", Offset = "0x6E458D0", VA = "0x186E464D0")]
	public JFOCFCCEAKN(DGJCECDPCLD PGKLFBGNCLC, bool NKCFECIMPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6E45480", Offset = "0x6E44880", VA = "0x186E45480")]
	private bool LBGGMPCFFKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E458C0", Offset = "0x6E44CC0", VA = "0x186E458C0", Slot = "4")]
	public bool PJLPMKJIOFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6E452A0", Offset = "0x6E446A0", VA = "0x186E452A0", Slot = "5")]
	public bool BNOGHBKOPKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E456A0", Offset = "0x6E44AA0", VA = "0x186E456A0", Slot = "6")]
	public void MAHJHHAHNPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E45470", Offset = "0x6E44870", VA = "0x186E45470", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KEFPNNMMLLB
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDCBKHHHNNC(CommandBuffer ALAHKFHHBDO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct NNGFOKLBEEN : KEFPNNMMLLB
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int BMLMCKPLKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x952F60", Offset = "0x952360", VA = "0x180952F60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier EBPDEDEIAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x45BCDE0", Offset = "0x45BC1E0", VA = "0x1845BCDE0")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E47C50", Offset = "0x6E47050", VA = "0x186E47C50")]
	public NNGFOKLBEEN(int IHELCOHOCAM, RenderTargetIdentifier MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E47C00", Offset = "0x6E47000", VA = "0x186E47C00", Slot = "4")]
	public void JDCBKHHHNNC(CommandBuffer ALAHKFHHBDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct BHBOOHHGDCA : KEFPNNMMLLB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int BMLMCKPLKGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x952F60", Offset = "0x952360", VA = "0x180952F60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] KIGCHPJPKDE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x93F120", Offset = "0x93E520", VA = "0x18093F120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x10CA180", Offset = "0x10C9580", VA = "0x1810CA180")]
	public BHBOOHHGDCA(int IHELCOHOCAM, Vector4[] MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A0A0", Offset = "0x6E394A0", VA = "0x186E3A0A0", Slot = "4")]
	public void JDCBKHHHNNC(CommandBuffer ALAHKFHHBDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct PEKAIPILECM : KEFPNNMMLLB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int BMLMCKPLKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x952F60", Offset = "0x952360", VA = "0x180952F60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] ELHJGBCNKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x93F120", Offset = "0x93E520", VA = "0x18093F120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x10CA180", Offset = "0x10C9580", VA = "0x1810CA180")]
	public PEKAIPILECM(int IHELCOHOCAM, float[] MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E48390", Offset = "0x6E47790", VA = "0x186E48390", Slot = "4")]
	public void JDCBKHHHNNC(CommandBuffer ALAHKFHHBDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct OGFOCNOOHKC : KEFPNNMMLLB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string BKJCNMKILGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool KKDBELDOFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x20B9A00", Offset = "0x20B8E00", VA = "0x1820B9A00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3EE9040", Offset = "0x3EE8440", VA = "0x183EE9040")]
	public OGFOCNOOHKC(string ADANIHOIEKJ, bool PNHMPKNFDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E47C70", Offset = "0x6E47070", VA = "0x186E47C70", Slot = "4")]
	public void JDCBKHHHNNC(CommandBuffer ALAHKFHHBDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct KJEIPAMCNBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 CMMHKCHAOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 APJEKOCIHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xACF380", Offset = "0xACE780", VA = "0x180ACF380")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int HBBADODBNIH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x952F70", Offset = "0x952370", VA = "0x180952F70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int MJJAGMJJEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8EA370", VA = "0x1808EAF70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float LBODEOJBJIL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA88500", Offset = "0xA87900", VA = "0x180A88500")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E466A0", Offset = "0x6E45AA0", VA = "0x186E466A0")]
	public KJEIPAMCNBJ(Color DFKHKPKCOFI, int HAEHBACPPHL, int BNBPOPFGKEB, float EGAKGLMICAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xC4E6C0", Offset = "0xC4DAC0", VA = "0x180C4E6C0")]
	private static float4 HBEFOKJBNMN(Color DFKHKPKCOFI)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E46610", Offset = "0x6E45A10", VA = "0x186E46610")]
	private static Hash128 KGMFHOGHPJH(KJEIPAMCNBJ PGKLFBGNCLC)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class APKGHBJCMDG : OFGJNHPIIME, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string ICADIPDDPNC;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string OLLIKPLCIHK;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string NPOKENOKBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private KJEIPAMCNBJ CEGOCNKDDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NAGNLCPLBDG LBOPCEJDNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 EMLBENDNLFA;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public BODJOFHKIPI DFMJFCNCFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8D21D0", Offset = "0x8D15D0", VA = "0x1808D21D0")]
		[CompilerGenerated]
		get
		{
			return default(BODJOFHKIPI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xDE2DC0", Offset = "0xDE21C0", VA = "0x180DE2DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GIIIBAIHELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AF00", Offset = "0x5E1A300", VA = "0x185E1AF00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AF10", Offset = "0x5E1A310", VA = "0x185E1AF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NFKCPANOHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x219DED0", Offset = "0x219D2D0", VA = "0x18219DED0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6DC1050", Offset = "0x6DC0450", VA = "0x186DC1050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MHLFDCHJNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CPCHKPINGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1500", Offset = "0x5ED0900", VA = "0x185ED1500", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6E385D0", Offset = "0x6E379D0", VA = "0x186E385D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int LGPOLAJNCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6E386E0", Offset = "0x6E37AE0", VA = "0x186E386E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E38960", Offset = "0x6E37D60", VA = "0x186E38960")]
	public APKGHBJCMDG(KJEIPAMCNBJ NNMPNJNEAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E384D0", Offset = "0x6E378D0", VA = "0x186E384D0")]
	private bool LBGGMPCFFKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E38730", Offset = "0x6E37B30", VA = "0x186E38730", Slot = "4")]
	public bool PJLPMKJIOFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E38490", Offset = "0x6E37890", VA = "0x186E38490")]
	private static NAGNLCPLBDG GDHKKDOGGIF(KJEIPAMCNBJ PGKLFBGNCLC)
	{
		return default(NAGNLCPLBDG);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E382E0", Offset = "0x6E376E0", VA = "0x186E382E0", Slot = "5")]
	public bool BNOGHBKOPKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E385E0", Offset = "0x6E379E0", VA = "0x186E385E0", Slot = "6")]
	public void MAHJHHAHNPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6E47070", Offset = "0x6E46470", VA = "0x186E47070", Slot = "0")]
		public override bool Equals(object OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6E47270", Offset = "0x6E46670", VA = "0x186E47270", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA79810", Offset = "0xA78C10", VA = "0x180A79810")]
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
		private BDLAIDEBPBC opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static IDELONIIMGE CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6E47930", Offset = "0x6E46D30", VA = "0x186E47930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6E47970", Offset = "0x6E46D70", VA = "0x186E47970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E474E0", Offset = "0x6E468E0", VA = "0x186E474E0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E47320", Offset = "0x6E46720", VA = "0x186E47320", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OEGINKHKPKI, RenderingData PMJMDFLFIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6E47350", Offset = "0x6E46750", VA = "0x186E47350")]
		public void BBKCADHPCMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x10D3490", Offset = "0x10D2890", VA = "0x1810D3490")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class EFLBCOODEFP<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private PMNFGJAHIDH MCCALBFMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private PMNFGJAHIDH GHJCFODPGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer KMJJKAPBMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture OFFPMBACLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int IOAEKDALJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int ADCLAGPFFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string HIIOICPCADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string KBPLNNFHOAL;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D40", Offset = "0x8A9140", VA = "0x1808A9D40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int IDODOOBPJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9E2C80", Offset = "0x9E2080", VA = "0x1809E2C80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int CBIFHLKMBDA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8C8A80", Offset = "0x8C7E80", VA = "0x1808C8A80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3B2DD30", Offset = "0x3B2D130", VA = "0x183B2DD30")]
	public EFLBCOODEFP(string ADANIHOIEKJ, int BLOLFGAGEOD, [Optional] RenderTextureFormat? BJFFNJGHPDD, bool EEBBNLCAOOC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3B2B5A0", Offset = "0x3B2A9A0", VA = "0x183B2B5A0")]
	public void BNOGHBKOPKE(CommandBuffer ALAHKFHHBDO, NativeArray<ValType> MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3B2D420", Offset = "0x3B2C820", VA = "0x183B2D420")]
	public void GBFAHFHMMOL(CommandBuffer ALAHKFHHBDO, ComputeShader ECHANKAINJD, int PNJDDOLENGI, int JFKKODDPCNC = -1, int AHNPBLJLBEC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3B2D010", Offset = "0x3B2C410", VA = "0x183B2D010")]
	public void GBFAHFHMMOL(Material LBOPCEJDNFN, int JFKKODDPCNC = -1, int AHNPBLJLBEC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3B2C020", Offset = "0x3B2B420", VA = "0x183B2C020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DJLCHBHKOFB
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBFAHFHMMOL(Material NNMPNJNEAKE);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JALEADPGNFB<SrcEntry, DstEntry> : DJLCHBHKOFB, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] IBAKCKFDEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected PMNFGJAHIDH IBHIBIABBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected PMNFGJAHIDH AEOEACJIEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> NNOJPLBBNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> JNFGBGBMIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int BFLHDOCEKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int LPBPLNACMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected EFLBCOODEFP<int> CDJMCAMJPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected EFLBCOODEFP<SrcEntry> OALHHALBOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected EFLBCOODEFP<DstEntry> BDOJHFPKNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader CKBPGFNLCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int CJODEPKLIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int IBFJIHINHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int ELPLMNPMCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int OMKCCEHFMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int NFHNDOAMBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int GOOFIJEPJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int KCLBBHHGLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int PPJGGIAMKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int AIGNGEOCNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int LLIELCPMBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int MDBMJIGDIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int EJPKPAHNMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string PHKNBKILOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] JMILKKANIED;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OGMNDHJBABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x43EEC60", Offset = "0x43EE060", VA = "0x1843EEC60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string POHBIMKNANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x43EE240", Offset = "0x43ED640", VA = "0x1843EE240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x43EFB60", Offset = "0x43EEF60", VA = "0x1843EFB60")]
	public JALEADPGNFB(string ADANIHOIEKJ, int HPGCECFLNLP, int EDLGFHADDOP, RenderTextureFormat BJFFNJGHPDD, ComputeShader FNCCEKENDDH, int MGDOKOHHFFG = 0, int OINNDAFJOIE = 0, int DGIJCLNFMLP = 0, int IOCALJAEJKB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x43EDC80", Offset = "0x43ED080", VA = "0x1843EDC80")]
	public int CGOLIONJIJN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x43EDC30", Offset = "0x43ED030", VA = "0x1843EDC30")]
	protected void CDCLGGPHNGJ(int AEAHMAMPNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x43EEFE0", Offset = "0x43EE3E0", VA = "0x1843EEFE0")]
	public BODJOFHKIPI PJLPMKJIOFF(SrcEntry MPMEGOKIEPF)
	{
		return default(BODJOFHKIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x43EDA70", Offset = "0x43ECE70", VA = "0x1843EDA70")]
	public bool BNOGHBKOPKE(BODJOFHKIPI PKDPMCLKPHH, SrcEntry MPMEGOKIEPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x43EEB60", Offset = "0x43EDF60", VA = "0x1843EEB60")]
	public bool MAHJHHAHNPL(BODJOFHKIPI PKDPMCLKPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "6")]
	protected virtual void GJJAAMIFNPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x43ECF80", Offset = "0x43EC380", VA = "0x1843ECF80", Slot = "7")]
	public void BACDIHNIJCD(CommandBuffer ALAHKFHHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x43ECC10", Offset = "0x43EC010", VA = "0x1843ECC10", Slot = "8")]
	public void BACDIHNIJCD(CommandBuffer ALAHKFHHBDO, ComputeShader FNCCEKENDDH, int MGDOKOHHFFG = -1, int OINNDAFJOIE = -1, int DGIJCLNFMLP = -1, int IOCALJAEJKB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x43EE090", Offset = "0x43ED490", VA = "0x1843EE090", Slot = "9")]
	public void GBFAHFHMMOL(CommandBuffer ALAHKFHHBDO, ComputeShader FNCCEKENDDH, int MGDOKOHHFFG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x43EE020", Offset = "0x43ED420", VA = "0x1843EE020", Slot = "4")]
	public void GBFAHFHMMOL(Material LBOPCEJDNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x43EDF10", Offset = "0x43ED310", VA = "0x1843EDF10", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PMNFGJAHIDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong AGLABHKNBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong AEGLHIOAFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JCPFGKNDJOE
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct GCPHCJPOOKH : PMNFGJAHIDH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable EHFHDBPLLGN;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong AGLABHKNBHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x93F120", Offset = "0x93E520", VA = "0x18093F120", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xC76E20", Offset = "0xC76220", VA = "0x180C76E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong AEGLHIOAFCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9AA360", Offset = "0x9A9760", VA = "0x1809AA360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5103120", Offset = "0x5102520", VA = "0x185103120")]
		internal GCPHCJPOOKH(IDisposable GIDKEHOKHMI, ulong IGIKMEPDGPE, ulong MGJEIJFEOCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6E3AE70", Offset = "0x6E3A270", VA = "0x186E3AE70", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct HLHOIDHGPLM : PMNFGJAHIDH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture KFJIEAHMGBG;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong AGLABHKNBHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x93F120", Offset = "0x93E520", VA = "0x18093F120", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xC76E20", Offset = "0xC76220", VA = "0x180C76E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong AEGLHIOAFCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9AA360", Offset = "0x9A9760", VA = "0x1809AA360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D680", Offset = "0x6E3CA80", VA = "0x186E3D680")]
		public HLHOIDHGPLM(RenderTexture KDKJOONKNHD, ulong OHANPIPOMHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D5E0", Offset = "0x6E3C9E0", VA = "0x186E3D5E0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong GGIADHEGIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6E44BC0", Offset = "0x6E43FC0", VA = "0x186E44BC0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E44B40", Offset = "0x6E43F40", VA = "0x186E44B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong IFGJCAOODNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E44B80", Offset = "0x6E43F80", VA = "0x186E44B80")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6E44B00", Offset = "0x6E43F00", VA = "0x186E44B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6E44D40", Offset = "0x6E44140", VA = "0x186E44D40")]
	public static ComputeBuffer LIDOGEGODKP(int MGEMHICLKEP, int CBLKGKGDNEC, ComputeBufferType LGJDMOCCBDP, [Out] PMNFGJAHIDH PKDPMCLKPHH, ComputeBufferMode EEKKEDKPKFI = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6E44F10", Offset = "0x6E44310", VA = "0x186E44F10")]
	public static RenderTexture LIDOGEGODKP(int HDEGPKKBOJG, int ODBPFGKPHPK, int POIIDMGHBLO, RenderTextureFormat BJFFNJGHPDD, [Out] PMNFGJAHIDH PKDPMCLKPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC1C0", Offset = "0x2ECB5C0", VA = "0x182ECC1C0")]
	public static NativeArray<T> DANANKHFGLP<T>(NativeArray<T> EHFHDBPLLGN, ulong IDHDBIDGMFM, [Out] PMNFGJAHIDH PKDPMCLKPHH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2ECD0C0", Offset = "0x2ECC4C0", VA = "0x182ECD0C0")]
	public static NativeArray<T> LIDOGEGODKP<T>(int IDHDBIDGMFM, Allocator MGFIHPDNFPH, [Out] PMNFGJAHIDH PKDPMCLKPHH, NativeArrayOptions AHOANCKGKEN = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E44C00", Offset = "0x6E44000", VA = "0x186E44C00")]
	public static void LBHGGLOEOHI(PMNFGJAHIDH EHFHDBPLLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E449F0", Offset = "0x6E43DF0", VA = "0x186E449F0")]
	public static uint ABNLHBMGBDN(RenderTextureFormat BJFFNJGHPDD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EIJBNAGMODC : JALEADPGNFB<MGCBFIHEAAF, MGCBFIHEAAF>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct HGADELPLEAP : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> LNJNDDLJEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> POFFHCKCBJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> FAELPGGGCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> CABDKNBKODE;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6E3A3A0", Offset = "0x6E397A0", VA = "0x186E3A3A0")]
		public HGADELPLEAP(NativeArray<int> MMBLLBKJGFB, NativeArray<float> LMJBMJAABJH, NativeArray<float4x4> OFPMMDMOEOP, NativeArray<float4> MGOKFLBHDKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6E3B5D0", Offset = "0x6E3A9D0", VA = "0x186E3B5D0", Slot = "4")]
		public void Execute(int AEAHMAMPNLO, TransformAccess ADJOLMKPBJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct DCHENLNKOGD : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> LNJNDDLJEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> CGPEPLOJJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> FNAKEBLFHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<MGCBFIHEAAF> BLODBFACNJB;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E3A3A0", Offset = "0x6E397A0", VA = "0x186E3A3A0")]
		public DCHENLNKOGD(NativeArray<int> MMBLLBKJGFB, NativeArray<float4x4> HNPJCOJFFNG, NativeArray<float4> CHMFAKIMAAB, NativeArray<MGCBFIHEAAF> EDLJDADHMAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6E3A330", Offset = "0x6E39730", VA = "0x186E3A330", Slot = "4")]
		public void Execute(int AEAHMAMPNLO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte CJHLPKGODAG = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray DBLLCNMDFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> PLBIBEPOFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> HCDHCMCKOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> OINEIHOOJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> MIKLKODGDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> LOHAKEOMLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private PMNFGJAHIDH LHOIOBAEBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private PMNFGJAHIDH HHACKLLLIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private PMNFGJAHIDH FHHJKDONNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private PMNFGJAHIDH DALPDFIKKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private PMNFGJAHIDH MLCBIPEEKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform EHDCLNHOOIH;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6E3AAE0", Offset = "0x6E39EE0", VA = "0x186E3AAE0")]
	public EIJBNAGMODC(int HPGCECFLNLP, int EDLGFHADDOP, ComputeShader FNCCEKENDDH, int MGDOKOHHFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A820", Offset = "0x6E39C20", VA = "0x186E3A820", Slot = "6")]
	protected override void GJJAAMIFNPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A760", Offset = "0x6E39B60", VA = "0x186E3A760")]
	private void GFKFHEDEAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A480", Offset = "0x6E39880", VA = "0x186E3A480")]
	public bool DBJPHFNNMKB(BODJOFHKIPI PKDPMCLKPHH, Transform ADJOLMKPBJM, float ELACDCLDGPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A680", Offset = "0x6E39A80", VA = "0x186E3A680")]
	public void FOJILIDJKEH(BODJOFHKIPI PKDPMCLKPHH, float ELACDCLDGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6E3AA30", Offset = "0x6E39E30", VA = "0x186E3AA30")]
	public void LPEHDMGHJMO(BODJOFHKIPI PKDPMCLKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A5E0", Offset = "0x6E399E0", VA = "0x186E3A5E0", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AFFHHGAMIDE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JHEIAOJDPDC ONAFBBOMACN();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface MDOCJIHALMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 CMMHKCHAOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int PKCENLFOFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int CDMPNIIABON
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> KHBHMHPABCH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> FMOFMIPIDFE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> ILAEEJFONGN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> JNBCOHEGBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> JJKLEPEOMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> PPGFIGEGDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int IBOEGPOBJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int HJFILHJLOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int FHHBNOIHBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool KJDFDBGFIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BACDIHNIJCD();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LLHGIOMBMJB : MDOCJIHALMP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private AFFHHGAMIDE BAHLNIEEEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private JHEIAOJDPDC JIPKNCLPFGJ;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 CMMHKCHAOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xACF380", Offset = "0xACE780", VA = "0x180ACF380", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xACF2A0", Offset = "0xACE6A0", VA = "0x180ACF2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool IOOMAKLMMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8B82B0", Offset = "0x8B76B0", VA = "0x1808B82B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int PKCENLFOFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8EA370", VA = "0x1808EAF70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8EA560", Offset = "0x8E9960", VA = "0x1808EA560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int CDMPNIIABON
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC60", Offset = "0x8AE060", VA = "0x1808AEC60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC70", Offset = "0x8AE070", VA = "0x1808AEC70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int FPODNGNJJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xE6E690", Offset = "0xE6DA90", VA = "0x180E6E690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> KHBHMHPABCH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6E46EB0", Offset = "0x6E462B0", VA = "0x186E46EB0", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> FMOFMIPIDFE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6E46F40", Offset = "0x6E46340", VA = "0x186E46F40", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> ILAEEJFONGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E46D50", Offset = "0x6E46150", VA = "0x186E46D50", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> JNBCOHEGBDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E46E10", Offset = "0x6E46210", VA = "0x186E46E10", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> JJKLEPEOMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E46BE0", Offset = "0x6E45FE0", VA = "0x186E46BE0", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> PPGFIGEGDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E46E80", Offset = "0x6E46280", VA = "0x186E46E80", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool KJDFDBGFIGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x927B80", Offset = "0x926F80", VA = "0x180927B80", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9229F0", Offset = "0x921DF0", VA = "0x1809229F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int IBOEGPOBJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6E46D40", Offset = "0x6E46140", VA = "0x186E46D40", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int HJFILHJLOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E46D20", Offset = "0x6E46120", VA = "0x186E46D20", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int FHHBNOIHBCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6E46F20", Offset = "0x6E46320", VA = "0x186E46F20", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6E46F70", Offset = "0x6E46370", VA = "0x186E46F70")]
	public LLHGIOMBMJB(Hash128 EIIBADICFOJ, AFFHHGAMIDE BAHLNIEEEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6E46C10", Offset = "0x6E46010", VA = "0x186E46C10", Slot = "16")]
	public void BACDIHNIJCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E46D80", Offset = "0x6E46180", VA = "0x186E46D80", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct BODJOFHKIPI : IEquatable<BODJOFHKIPI>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly BODJOFHKIPI COCGIBDDIEL;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int LGPOLAJNCMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x952F60", Offset = "0x952360", VA = "0x180952F60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xC76E40", Offset = "0xC76240", VA = "0x180C76E40")]
	public BODJOFHKIPI(int AEAHMAMPNLO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A1A0", Offset = "0x6E395A0", VA = "0x186E3A1A0", Slot = "4")]
	public bool Equals(BODJOFHKIPI OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A0D0", Offset = "0x6E394D0", VA = "0x186E3A0D0", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A1F0", Offset = "0x6E395F0", VA = "0x186E3A1F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HHEBONNCDMA : OFGJNHPIIME, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool MENDKKGINHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private MDOCJIHALMP GDPKBOKMCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<BODJOFHKIPI> BDHGBPKAMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<BODJOFHKIPI> CBAAFJLHMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<BODJOFHKIPI> EMKDAHLOPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> HNOMDJIPLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int FOKPONIAEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int DBMNEEKDOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int NGAMOGGPFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int KKPHJIBEAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int NBKHBPOKEKE;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int LGPOLAJNCMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6E3C930", Offset = "0x6E3BD30", VA = "0x186E3C930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6E3C000", Offset = "0x6E3B400", VA = "0x186E3C000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool GIIIBAIHELG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x918830", Offset = "0x917C30", VA = "0x180918830")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9822A0", Offset = "0x9816A0", VA = "0x1809822A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool NFKCPANOHLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xE81EA0", Offset = "0xE812A0", VA = "0x180E81EA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xE81E90", Offset = "0xE81290", VA = "0x180E81E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool MHLFDCHJNLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool CPCHKPINGGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4EB69B0", Offset = "0x4EB5DB0", VA = "0x184EB69B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1E7F6C0", Offset = "0x1E7EAC0", VA = "0x181E7F6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float JGHOBPGLLNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA4C650", Offset = "0xA4BA50", VA = "0x180A4C650")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA4C610", Offset = "0xA4BA10", VA = "0x180A4C610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D3C0", Offset = "0x6E3C7C0", VA = "0x186E3D3C0")]
	public HHEBONNCDMA(MDOCJIHALMP JIPKNCLPFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E3BB30", Offset = "0x6E3AF30", VA = "0x186E3BB30")]
	private void EPKCBMCNFCB(MDOCJIHALMP JIPKNCLPFGJ, int FOKPONIAEFG, int HIEFBNHAFAN, int AEAHMAMPNLO, int LABKDKLKOGI, HHPBFEIMFMG MPMEGOKIEPF, float AEFEEJFOGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B870", Offset = "0x6E3AC70", VA = "0x186E3B870")]
	private void EMKBBHLNCNK(MDOCJIHALMP JIPKNCLPFGJ, int BHCNIFJLLHP, int AEAHMAMPNLO, uint3 HALMILDNMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C040", Offset = "0x6E3B440", VA = "0x186E3C040")]
	private bool LBGGMPCFFKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C9E0", Offset = "0x6E3BDE0", VA = "0x186E3C9E0", Slot = "4")]
	public bool PJLPMKJIOFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B7F0", Offset = "0x6E3ABF0", VA = "0x186E3B7F0", Slot = "5")]
	public bool BNOGHBKOPKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C2E0", Offset = "0x6E3B6E0", VA = "0x186E3C2E0", Slot = "6")]
	public void MAHJHHAHNPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B790", Offset = "0x6E3AB90", VA = "0x186E3B790")]
	public void ADHNIIDFJKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B790", Offset = "0x6E3AB90", VA = "0x186E3B790", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OFGJNHPIIME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool MHLFDCHJNLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool CPCHKPINGGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PJLPMKJIOFF();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BNOGHBKOPKE();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MAHJHHAHNPL();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BAHJDLIBMEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float AFJIPBMGPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, HHEBONNCDMA> GANLKAMPAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, APKGHBJCMDG> MIGEDILLAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<OFGJNHPIIME> HMPEBOCLHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<OFGJNHPIIME> HDGJOBPJIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<OFGJNHPIIME> JKHHPFGHBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int EANDLPAJPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int DOCKEPFOEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float GHEAACEEPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool PKJIKMIABEO;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool NGPJIOPGCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9BE0", Offset = "0x10F8FE0", VA = "0x1810F9BE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x110F460", Offset = "0x110E860", VA = "0x18110F460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool KDBKDANBHIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6E39070", Offset = "0x6E38470", VA = "0x186E39070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string POHBIMKNANF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6E390C0", Offset = "0x6E384C0", VA = "0x186E390C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6E38FD0", Offset = "0x6E383D0", VA = "0x186E38FD0")]
	public void GEODDJHEIHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E39060", Offset = "0x6E38460", VA = "0x186E39060")]
	public void HACMKBPIMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6E39AD0", Offset = "0x6E38ED0", VA = "0x186E39AD0")]
	public BAHJDLIBMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6E39820", Offset = "0x6E38C20", VA = "0x186E39820")]
	public JFOCFCCEAKN PFLPBBOAAPI(DGJCECDPCLD FECLIDFMLKB, bool NKCFECIMPNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6E39950", Offset = "0x6E38D50", VA = "0x186E39950")]
	public APKGHBJCMDG PFLPBBOAAPI(KJEIPAMCNBJ LBOPCEJDNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6E38E50", Offset = "0x6E38250", VA = "0x186E38E50")]
	public bool BPLNEEGFILK(Hash128 IHELCOHOCAM, [Out] HHEBONNCDMA KALIGALCADB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6E39540", Offset = "0x6E38940", VA = "0x186E39540")]
	public HHEBONNCDMA PFLPBBOAAPI(MDOCJIHALMP JIPKNCLPFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6E39470", Offset = "0x6E38870", VA = "0x186E39470")]
	private void JLKHHLMIHII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6E38FE0", Offset = "0x6E383E0", VA = "0x186E38FE0")]
	private bool GKOJONKPMEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6E389A0", Offset = "0x6E37DA0", VA = "0x186E389A0")]
	public void BACDIHNIJCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6E38EC0", Offset = "0x6E382C0", VA = "0x186E38EC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6E39490", Offset = "0x6E38890", VA = "0x186E39490")]
	public void OCMJLPCCMPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LPJOLFMLKCG : JALEADPGNFB<JAHJMAFAOPI, JAHJMAFAOPI>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6E46FC0", Offset = "0x6E463C0", VA = "0x186E46FC0")]
	public LPJOLFMLKCG(int HPGCECFLNLP, int EDLGFHADDOP, ComputeShader FNCCEKENDDH, int MGDOKOHHFFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CIFENOAFDMG : JALEADPGNFB<NAGNLCPLBDG, NAGNLCPLBDG>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A280", Offset = "0x6E39680", VA = "0x186E3A280")]
	public CIFENOAFDMG(int HPGCECFLNLP, int EDLGFHADDOP, ComputeShader FNCCEKENDDH, int MGDOKOHHFFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class DJHFLKGENDG : JALEADPGNFB<HJCBHBDKABE, HJCBHBDKABE>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A3D0", Offset = "0x6E397D0", VA = "0x186E3A3D0")]
	public DJHFLKGENDG(int HPGCECFLNLP, int EDLGFHADDOP, ComputeShader FNCCEKENDDH, int MGDOKOHHFFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NHEHLOLLAMJ : JALEADPGNFB<NLFJNDKPCCA, AFNEGFKOFAJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6E47B50", Offset = "0x6E46F50", VA = "0x186E47B50")]
	public NHEHLOLLAMJ(int HPGCECFLNLP, int EDLGFHADDOP, ComputeShader FNCCEKENDDH, int MGDOKOHHFFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class HOEMGMCMNEF : JALEADPGNFB<KKIJMDGJAND, KKIJMDGJAND>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D6B0", Offset = "0x6E3CAB0", VA = "0x186E3D6B0")]
	public HOEMGMCMNEF(int HPGCECFLNLP, int EDLGFHADDOP, ComputeShader FNCCEKENDDH, int MGDOKOHHFFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class BDLAIDEBPBC : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IDELONIIMGE PDDMFLOGPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool PNHMPKNFDBD;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool EPBFFFHGAMK;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A060", Offset = "0x6E39460", VA = "0x186E3A060")]
	public BDLAIDEBPBC(IDELONIIMGE KDNAFKFLJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6E39ED0", Offset = "0x6E392D0", VA = "0x186E39ED0", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer ALAHKFHHBDO, RenderingData PMJMDFLFIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6E39C60", Offset = "0x6E39060", VA = "0x186E39C60", Slot = "6")]
	public override void Configure(CommandBuffer ALAHKFHHBDO, RenderTextureDescriptor MMDLFIKCFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6E39CA0", Offset = "0x6E390A0", VA = "0x186E39CA0", Slot = "9")]
	public override void Execute(ScriptableRenderContext JCPOMHNJOIE, RenderingData PMJMDFLFIHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class GOFIPGEALDE
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct GODJKDKIGEE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string ADANIHOIEKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer ALAHKFHHBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext JCPOMHNJOIE;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6E3AFA0", Offset = "0x6E3A3A0", VA = "0x186E3AFA0")]
		public GODJKDKIGEE(string MMFCNFGDDEM, ScriptableRenderContext FHBPDMMCGIG, [Out] CommandBuffer LKEKNFMJJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6E3AEF0", Offset = "0x6E3A2F0", VA = "0x186E3AEF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B0B0", Offset = "0x6E3A4B0", VA = "0x186E3B0B0")]
	public static bool ENBCIPGEFNJ(RenderingData PMJMDFLFIHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B430", Offset = "0x6E3A830", VA = "0x186E3B430")]
	public static void PPMMGEOIPAH(CommandBuffer ALAHKFHHBDO, ScriptableRenderContext JCPOMHNJOIE, ShadowDrawingSettings LDMELPIIKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B200", Offset = "0x6E3A600", VA = "0x186E3B200")]
	public static void NAFFLBOGHAF(CommandBuffer ALAHKFHHBDO, ScriptableRenderContext JCPOMHNJOIE, RenderingData PMJMDFLFIHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class IDELONIIMGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class JMPIFHKCMHE
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int NJBEDEOFOOP;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int NHAKNMBBHJE;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static EFLBCOODEFP<FIDIACPNHPM> DFPCFKBDNPC;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static EFLBCOODEFP<uint> GOABPEBPLOD;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static PMNFGJAHIDH DFGILNKKIMC;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer JHDOGKLMKAK;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<DJLCHBHKOFB> DGJCHOFKJIG;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int FCODCBMBCAJ;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int BJNHGGILPEA;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int LDFCKMHPBEE;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int KFNIKCNEMEM;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] MINPJMADBOB;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] PEJKCODNGPN;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static KEFPNNMMLLB[][] IEPOPGIJELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] HIALDJGPCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int GLDDMEJFPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int KPHIBAPIFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int AOHFBOPIOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int DCOPPHDABFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int OGJAPAAKIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int ABMFHBOIHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int PDHJKKJCJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int DHJNOFIODOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int CPGEBLAOCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int ACECMEFIMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int POLMFDEGIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int PIFIEIDNOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int LMMCADEMHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int EBPAKPMFJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int FFAPLGPMBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int ECJDAKLKFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int HLMCKKCPHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int FNHKAODMKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] DEBHLKNOMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private BAHJDLIBMEE GBMGKHHGBHL;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool PJMANNDLDIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6E43370", Offset = "0x6E42770", VA = "0x186E43370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6E40250", Offset = "0x6E3F650", VA = "0x186E40250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool LHKEEFGGMLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6E40980", Offset = "0x6E3FD80", VA = "0x186E40980")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6E3FB60", Offset = "0x6E3EF60", VA = "0x186E3FB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData BAFNFCIODAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6E40200", Offset = "0x6E3F600", VA = "0x186E40200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6E43600", Offset = "0x6E42A00", VA = "0x186E43600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static EIJBNAGMODC JHCCLNIOMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6E3FA50", Offset = "0x6E3EE50", VA = "0x186E3FA50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E0C0", Offset = "0x6E3D4C0", VA = "0x186E3E0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static LPJOLFMLKCG MKODIFIBJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6E43320", Offset = "0x6E42720", VA = "0x186E43320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6E432B0", Offset = "0x6E426B0", VA = "0x186E432B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static CIFENOAFDMG FEMGGNCKGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F380", Offset = "0x6E3E780", VA = "0x186E3F380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6E43590", Offset = "0x6E42990", VA = "0x186E43590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static DJHFLKGENDG PLPOLANMHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6E3FB10", Offset = "0x6E3EF10", VA = "0x186E3FB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6E41E00", Offset = "0x6E41200", VA = "0x186E41E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static NHEHLOLLAMJ AEGGHNJJFGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E2A0", Offset = "0x6E3D6A0", VA = "0x186E3E2A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6E41CF0", Offset = "0x6E410F0", VA = "0x186E41CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static HOEMGMCMNEF KBBOHKOHDKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F3D0", Offset = "0x6E3E7D0", VA = "0x186E3F3D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E360", Offset = "0x6E3D760", VA = "0x186E3E360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material DBBGKDPNPOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E140", Offset = "0x6E3D540", VA = "0x186E3E140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E2F0", Offset = "0x6E3D6F0", VA = "0x186E3E2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material MJHNJCLMMHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6E3FC20", Offset = "0x6E3F020", VA = "0x186E3FC20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D990", Offset = "0x6E3CD90", VA = "0x186E3D990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material HNPBLDICBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6E3FC70", Offset = "0x6E3F070", VA = "0x186E3FC70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6E3FAA0", Offset = "0x6E3EEA0", VA = "0x186E3FAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material FAKDOODNILG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F330", Offset = "0x6E3E730", VA = "0x186E3F330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6E41E70", Offset = "0x6E41270", VA = "0x186E41E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool JNMOBOECKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6E3FA00", Offset = "0x6E3EE00", VA = "0x186E3FA00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D760", Offset = "0x6E3CB60", VA = "0x186E3D760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool KDBKDANBHIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6E3FBC0", Offset = "0x6E3EFC0", VA = "0x186E3FBC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string POHBIMKNANF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6E402B0", Offset = "0x6E3F6B0", VA = "0x186E402B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6E44440", Offset = "0x6E43840", VA = "0x186E44440")]
	internal IDELONIIMGE([Optional] MClusterData NDENOEGEGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6E409D0", Offset = "0x6E3FDD0", VA = "0x186E409D0")]
	public void JLABJFAHLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6E41D60", Offset = "0x6E41160", VA = "0x186E41D60")]
	public void KFNOBGAKCPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6E3E130", Offset = "0x6E3D530", VA = "0x186E3E130")]
	public void CPGCBDINDHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6E3DA00", Offset = "0x6E3CE00", VA = "0x186E3DA00")]
	public bool BHGEHODHHNJ(Hash128 EIIBADICFOJ, [Out] HHEBONNCDMA JIPKNCLPFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6E43A20", Offset = "0x6E42E20", VA = "0x186E43A20")]
	public HHEBONNCDMA PFLPBBOAAPI(MDOCJIHALMP MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6E43670", Offset = "0x6E42A70", VA = "0x186E43670")]
	public APKGHBJCMDG PFLPBBOAAPI(KJEIPAMCNBJ LBOPCEJDNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6E43860", Offset = "0x6E42C60", VA = "0x186E43860")]
	public JFOCFCCEAKN PFLPBBOAAPI(DGJCECDPCLD FECLIDFMLKB, bool NKCFECIMPNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6E43260", Offset = "0x6E42660", VA = "0x186E43260")]
	public void MAHJHHAHNPL(OFGJNHPIIME OLFOKAIDJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D7C0", Offset = "0x6E3CBC0", VA = "0x186E3D7C0")]
	public static void ANLIKDOFCDM(EJFHILFIBME NHDCAJADCDM, KEFPNNMMLLB[] MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6E43AE0", Offset = "0x6E42EE0", VA = "0x186E43AE0")]
	private void POBHJNMDNNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6E3E6E0", Offset = "0x6E3DAE0", VA = "0x186E3E6E0")]
	private static void ELIODPNCBCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6E3E3D0", Offset = "0x6E3D7D0", VA = "0x186E3E3D0")]
	public void EJDBACDCCBG(CommandBuffer ALAHKFHHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6E433C0", Offset = "0x6E427C0", VA = "0x186E433C0")]
	public void OJCBMNMGKCA([Optional] ScriptableRenderContext? JCPOMHNJOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6E3DDF0", Offset = "0x6E3D1F0", VA = "0x186E3DDF0")]
	public void CDELNGCNCCO(CommandBuffer ALAHKFHHBDO, ShadowSplitData LJFPEIFFLOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6E3DB10", Offset = "0x6E3CF10", VA = "0x186E3DB10")]
	public void CDELNGCNCCO(CommandBuffer ALAHKFHHBDO, CameraData OGEOKEONIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6E3FCC0", Offset = "0x6E3F0C0", VA = "0x186E3FCC0")]
	public void IBPPKBKGGKO(CommandBuffer ALAHKFHHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6E3DAA0", Offset = "0x6E3CEA0", VA = "0x186E3DAA0")]
	public void BOGPHIGFEHE(CommandBuffer ALAHKFHHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E42DE0", Offset = "0x6E421E0", VA = "0x186E42DE0")]
	public void LNHCBDBOPPL(CommandBuffer ALAHKFHHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F420", Offset = "0x6E3E820", VA = "0x186E3F420")]
	public void FFOBPJLFBDK(CommandBuffer ALAHKFHHBDO, EJFHILFIBME LPGPIIMOBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D8B0", Offset = "0x6E3CCB0", VA = "0x186E3D8B0")]
	public void BBKCADHPCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6E41EE0", Offset = "0x6E412E0", VA = "0x186E41EE0")]
	public void LBHGGLOEOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6E3E190", Offset = "0x6E3D590", VA = "0x186E3E190", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DLLFOBAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x218BFC0", Offset = "0x218B3C0", VA = "0x18218BFC0")]
	public static int LDAANGODCGN(int INBIGDGMENB, int KCLKINCFKCL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct MGCBFIHEAAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 KJONKGOBPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 AKDGMPHIINC;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly MGCBFIHEAAF NKIPEODBLKO;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly MGCBFIHEAAF COCGIBDDIEL;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x45CC4C0", Offset = "0x45CB8C0", VA = "0x1845CC4C0")]
	public MGCBFIHEAAF(float4x4 FHAJCJPAGBM, float4 NAJKGEDKLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6E479C0", Offset = "0x6E46DC0", VA = "0x186E479C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct HHPBFEIMFMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 MBJNFCDOKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 JNKEFPKOLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 DELILHLDNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 NKAEBFOMKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 LEDLJDIJPEB;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct PEJHNPFFFLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 MBJNFCDOKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 JNKEFPKOLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 DELILHLDNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 NKAEBFOMKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 LEDLJDIJPEB;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct AFNEGFKOFAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public PEJHNPFFFLD ODFHLBLIAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public PEJHNPFFFLD JEINFCJEBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public PEJHNPFFFLD PIDGGHJOGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public PEJHNPFFFLD HJEHLMBLPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public PEJHNPFFFLD PNGPDLDGIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public PEJHNPFFFLD LHMHNFKLEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public PEJHNPFFFLD PCELFNANMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public PEJHNPFFFLD CJEHPKBGDPI;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct NLFJNDKPCCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public HHPBFEIMFMG ODFHLBLIAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public HHPBFEIMFMG JEINFCJEBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public HHPBFEIMFMG PIDGGHJOGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public HHPBFEIMFMG HJEHLMBLPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public HHPBFEIMFMG PNGPDLDGIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public HHPBFEIMFMG LHMHNFKLEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public HHPBFEIMFMG PCELFNANMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public HHPBFEIMFMG CJEHPKBGDPI;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct NAGNLCPLBDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 ADCBPNFNHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint HAEHBACPPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint BNBPOPFGKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float EGAKGLMICAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint EICAENEGLMA;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6E47B20", Offset = "0x6E46F20", VA = "0x186E47B20")]
	public NAGNLCPLBDG(KJEIPAMCNBJ LBOPCEJDNFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FIDIACPNHPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint INNKCHBBLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint LAEHIADLDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint LABKDKLKOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint EICAENEGLMA;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6E3ADC0", Offset = "0x6E3A1C0", VA = "0x186E3ADC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct HJCBHBDKABE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint HIEFBNHAFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint PJPHLPBODCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint DBMNEEKDOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint EICAENEGLMA;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D530", Offset = "0x6E3C930", VA = "0x186E3D530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct JAHJMAFAOPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint LJDBIHHEHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint BBFOJJAILGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint ECIOGFIENBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint GAHIMANBFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint KDBGLGMCMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint CMJIADMMHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint PHMEEBMOPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint EICAENEGLMA;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6E446A0", Offset = "0x6E43AA0", VA = "0x186E446A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct KKIJMDGJAND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 BIENMANFDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 IECBLNMACIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 DNPAPHHMPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 BLFGEDDGALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 JKKAELPCJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 EKNPCGCLNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 NPNIBGHGLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 IEHLCILJJIK;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6E467D0", Offset = "0x6E45BD0", VA = "0x186E467D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum EJFHILFIBME
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
