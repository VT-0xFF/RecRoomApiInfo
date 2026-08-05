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
public struct GIHPBNNAGLD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] KFBJPNCJCLO;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] LPKCNLJEFDJ;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] JELBBMBKDNN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xDFE9C0", Offset = "0xDFD5C0", VA = "0x180DFE9C0")]
	public static int KDHIEEINPFG(GAEJLKPIMBI IGOCEJPANBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x691A5F0", Offset = "0x69191F0", VA = "0x18691A5F0")]
	public static int FMAMFGBHBMC(GAEJLKPIMBI IGOCEJPANBF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HPHCJGMNCCB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int PLKGBANFJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IIAMLFADMCJ ACALOAMNIHN(int ICDAEIIIEFB);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 KMNOLGNONCC(int ICDAEIIIEFB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CPCCGGOJAEN OPCKKLNIOIB();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DAIPKONBEHK KEOCPDCCEGO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BJPMBHNNBAA : DPFMOKDBGKN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private CPCCGGOJAEN KHIOEALLADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform BNLOOGFHFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<KGDEHKFMNOE> ELNLHNOMHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private CILPFAFLADH DDMFBAOGMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private KHLPKNNJLGA FMHNNJJOPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool MOKKEAKOGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private HPHCJGMNCCB FFDLCFEEDGK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float LKPGLOCLFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8B31A0", Offset = "0x8B1DA0", VA = "0x1808B31A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA93450", Offset = "0xA92050", VA = "0x180A93450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JKFNMBHLJAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4B0", Offset = "0x9A90B0", VA = "0x1809AA4B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA560", Offset = "0x9A9160", VA = "0x1809AA560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool PJIEPINLNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x121D560", Offset = "0x121C160", VA = "0x18121D560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x121CD80", Offset = "0x121B980", VA = "0x18121CD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KLEOOCIKEIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FECB90", Offset = "0x5FEB790", VA = "0x185FECB90", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FECC10", Offset = "0x5FEB810", VA = "0x185FECC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KPJHPNGPJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x13CE6F0", Offset = "0x13CD2F0", VA = "0x1813CE6F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6919340", Offset = "0x6917F40", VA = "0x186919340")]
	public BJPMBHNNBAA(HPHCJGMNCCB KONMDJKGHML, bool PGPFFNMDNHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6919120", Offset = "0x6917D20", VA = "0x186919120")]
	private bool OPONDNCOPBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6918330", Offset = "0x6916F30", VA = "0x186918330", Slot = "4")]
	public bool MPFJKDGCCNN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6918F50", Offset = "0x6917B50", VA = "0x186918F50", Slot = "5")]
	public bool NBJEMGDMOCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6918100", Offset = "0x6916D00", VA = "0x186918100", Slot = "6")]
	public void IFPALOLJLCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69180F0", Offset = "0x6916CF0", VA = "0x1869180F0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EAJMFDGNNLP
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIKCPPOOEDL(CommandBuffer DMCELDOJCFP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EJBIPKEGDKA : EAJMFDGNNLP
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int CCJJLJNMAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x916930", Offset = "0x915530", VA = "0x180916930")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier HMCCANAJOCB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x41DBB30", Offset = "0x41DA730", VA = "0x1841DBB30")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x691A280", Offset = "0x6918E80", VA = "0x18691A280")]
	public EJBIPKEGDKA(int EPKGPGILADI, RenderTargetIdentifier IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x691A230", Offset = "0x6918E30", VA = "0x18691A230", Slot = "4")]
	public void EIKCPPOOEDL(CommandBuffer DMCELDOJCFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct FHBKFKLAAEG : EAJMFDGNNLP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int CCJJLJNMAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x916930", Offset = "0x915530", VA = "0x180916930")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] IJKLBGLIKEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DA0", Offset = "0x8B39A0", VA = "0x1808B4DA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xD86720", Offset = "0xD85320", VA = "0x180D86720")]
	public FHBKFKLAAEG(int EPKGPGILADI, Vector4[] IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x691A350", Offset = "0x6918F50", VA = "0x18691A350", Slot = "4")]
	public void EIKCPPOOEDL(CommandBuffer DMCELDOJCFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct DBNMBDMIMFJ : EAJMFDGNNLP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int CCJJLJNMAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x916930", Offset = "0x915530", VA = "0x180916930")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] DLBCDMGFHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DA0", Offset = "0x8B39A0", VA = "0x1808B4DA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xD86720", Offset = "0xD85320", VA = "0x180D86720")]
	public DBNMBDMIMFJ(int EPKGPGILADI, float[] IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6919DC0", Offset = "0x69189C0", VA = "0x186919DC0", Slot = "4")]
	public void EIKCPPOOEDL(CommandBuffer DMCELDOJCFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct BHGPKLANPCF : EAJMFDGNNLP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool CIGKNHKCONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1B91D70", Offset = "0x1B90970", VA = "0x181B91D70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x401EC50", Offset = "0x401D850", VA = "0x18401EC50")]
	public BHGPKLANPCF(string GFLNGGKHEOH, bool MPKDEMAOPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69180B0", Offset = "0x6916CB0", VA = "0x1869180B0", Slot = "4")]
	public void EIKCPPOOEDL(CommandBuffer DMCELDOJCFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct DAIPKONBEHK
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 EMLOEPPMHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 LKFIIBOKMHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B92D0", Offset = "0x8B7ED0", VA = "0x1808B92D0")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int AKMIFKHNMDB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEF0", Offset = "0x8B9AF0", VA = "0x1808BAEF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int CCGKIBNKLMM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8832B0", Offset = "0x881EB0", VA = "0x1808832B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float BLEEDKIHLAC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8B3200", Offset = "0x8B1E00", VA = "0x1808B3200")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6919C90", Offset = "0x6918890", VA = "0x186919C90")]
	public DAIPKONBEHK(Color BFOBNFFGJIL, int FEECPJHHFKD, int CCJPPHADPEH, float HJCEHAIDOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x92B210", Offset = "0x929E10", VA = "0x18092B210")]
	private static float4 NHGELJMECAE(Color BFOBNFFGJIL)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6919C00", Offset = "0x6918800", VA = "0x186919C00")]
	private static Hash128 ADGBANJNKLM(DAIPKONBEHK KONMDJKGHML)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CILPFAFLADH : DPFMOKDBGKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string DECBNLDBOHF;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string JPDBMIACMFH;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string IDFBHOJADBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private DAIPKONBEHK NIHONMBANBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private LCKCDLCMFAF MBCOMNNFJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 AGEALHLPPJE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public KHLPKNNJLGA AOHNCEBMCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x86ABB0", Offset = "0x8697B0", VA = "0x18086ABB0")]
		[CompilerGenerated]
		get
		{
			return default(KHLPKNNJLGA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAABBF0", Offset = "0xAAA7F0", VA = "0x180AABBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool JKFNMBHLJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5963630", Offset = "0x5962230", VA = "0x185963630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5963640", Offset = "0x5962240", VA = "0x185963640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool PJIEPINLNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1F02650", Offset = "0x1F01250", VA = "0x181F02650")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x66A7720", Offset = "0x66A6320", VA = "0x1866A7720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool KPJHPNGPJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool KLEOOCIKEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B260", Offset = "0x5A19E60", VA = "0x185A1B260", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x66A7740", Offset = "0x66A6340", VA = "0x1866A7740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int HDEPOMLIBHF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x69194A0", Offset = "0x69180A0", VA = "0x1869194A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6919B40", Offset = "0x6918740", VA = "0x186919B40")]
	public CILPFAFLADH(DAIPKONBEHK JPIJFFCOHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6919940", Offset = "0x6918540", VA = "0x186919940")]
	private bool OPONDNCOPBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6919640", Offset = "0x6918240", VA = "0x186919640", Slot = "4")]
	public bool MPFJKDGCCNN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6919600", Offset = "0x6918200", VA = "0x186919600")]
	private static LCKCDLCMFAF JAGJKCBBFEL(DAIPKONBEHK KONMDJKGHML)
	{
		return default(LCKCDLCMFAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6919790", Offset = "0x6918390", VA = "0x186919790", Slot = "5")]
	public bool NBJEMGDMOCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69194F0", Offset = "0x69180F0", VA = "0x1869194F0", Slot = "6")]
	public void IFPALOLJLCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6925D60", Offset = "0x6924960", VA = "0x186925D60", Slot = "0")]
		public override bool Equals(object OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6925F60", Offset = "0x6924B60", VA = "0x186925F60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B3240", Offset = "0x8B1E40", VA = "0x1808B3240")]
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
		private DCOHCNJNHAD opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static JLKGPANAING CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6926630", Offset = "0x6925230", VA = "0x186926630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6926670", Offset = "0x6925270", VA = "0x186926670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6926040", Offset = "0x6924C40", VA = "0x186926040", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6926010", Offset = "0x6924C10", VA = "0x186926010", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer KKNFDPNGCFK, RenderingData FMJPLEFDOHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x69264A0", Offset = "0x69250A0", VA = "0x1869264A0")]
		public void GCOJNGINBFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xD935D0", Offset = "0xD921D0", VA = "0x180D935D0")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FCKJFEMEJLG<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private FCBJCANCHHD NMIDFEFKDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private FCBJCANCHHD EOGMOJNPPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer MJEEBJIEIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture DPPBEMPLGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int NLCGEFNLKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int FNAOKHEDFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string IHBFFNOGOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string HMMBNNGFMLA;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84B560", Offset = "0x84A160", VA = "0x18084B560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int KBBGFKHJNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xDB2A60", Offset = "0xDB1660", VA = "0x180DB2A60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int LABIDEGIOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8615C0", Offset = "0x8601C0", VA = "0x1808615C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3B81300", Offset = "0x3B7FF00", VA = "0x183B81300")]
	public FCKJFEMEJLG(string GFLNGGKHEOH, int CLBDOONKJLE, [Optional] RenderTextureFormat? KKEJAEKDBIN, bool LCADDLJHDBK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3B808E0", Offset = "0x3B7F4E0", VA = "0x183B808E0")]
	public void NBJEMGDMOCC(CommandBuffer DMCELDOJCFP, NativeArray<ValType> IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3B7FF90", Offset = "0x3B7EB90", VA = "0x183B7FF90")]
	public void LBLLALBKEGK(CommandBuffer DMCELDOJCFP, ComputeShader PEEECBNBGNN, int AJBFAFOLMOO, int ADDNODBPJHH = -1, int CHNDKDHHFLD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3B7F730", Offset = "0x3B7E330", VA = "0x183B7F730")]
	public void LBLLALBKEGK(Material MBCOMNNFJFG, int ADDNODBPJHH = -1, int CHNDKDHHFLD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3B7EBF0", Offset = "0x3B7D7F0", VA = "0x183B7EBF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HMDOJIAHALH
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBLLALBKEGK(Material JPIJFFCOHKA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BBDLMOHOLIP<SrcEntry, DstEntry> : HMDOJIAHALH, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] FKOJIMLCJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected FCBJCANCHHD JKJJCEADHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected FCBJCANCHHD PNBBHDODHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> AJLCGOAMKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> NHPDNPGKPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int BKFHNHBFLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int DAHBCNCFPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected FCKJFEMEJLG<int> PPDBNPMGNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected FCKJFEMEJLG<SrcEntry> NGMFFFMGFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected FCKJFEMEJLG<DstEntry> DGOGIPIPGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader AKKMIGIKHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int BIKFMBNOBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int PGPPJBKGMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int OHFEJJLAPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int KHBLNOALHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int GNOAKDFIGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int KIONGCIEOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int CGOKCMGDEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int INBIGJDMDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int NIOOBDKGAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int FJIPJADGFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int LHJKOJAJMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int PEGHDGCFPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string BFNFOLJICBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] EOEADCBCMBK;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HHEOBNINOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4E0F340", Offset = "0x4E0DF40", VA = "0x184E0F340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string CGIFBEFPALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4E131F0", Offset = "0x4E11DF0", VA = "0x184E131F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4E139B0", Offset = "0x4E125B0", VA = "0x184E139B0")]
	public BBDLMOHOLIP(string GFLNGGKHEOH, int BAALDHCMPGB, int LJOIMBFJCFB, RenderTextureFormat KKEJAEKDBIN, ComputeShader AEMIEEPDHPI, int FHJBOKMPOFN = 0, int OIGPJHGNEHJ = 0, int FLMGMOKIHOD = 0, int JNDCJHJODHG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4E0EC80", Offset = "0x4E0D880", VA = "0x184E0EC80")]
	public int AIGBFOGFNOE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4E0F2F0", Offset = "0x4E0DEF0", VA = "0x184E0F2F0")]
	protected void EODMLGKNPBK(int OPDMGNJCACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4E0FEF0", Offset = "0x4E0EAF0", VA = "0x184E0FEF0")]
	public KHLPKNNJLGA MPFJKDGCCNN(SrcEntry IMCLGJBJJKP)
	{
		return default(KHLPKNNJLGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4E10310", Offset = "0x4E0EF10", VA = "0x184E10310")]
	public bool NBJEMGDMOCC(KHLPKNNJLGA POAHFHMMEAF, SrcEntry IMCLGJBJJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4E0F450", Offset = "0x4E0E050", VA = "0x184E0F450")]
	public bool IFPALOLJLCH(KHLPKNNJLGA POAHFHMMEAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "6")]
	protected virtual void MDKGGDKMCII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4E11570", Offset = "0x4E10170", VA = "0x184E11570", Slot = "7")]
	public void OCNMJMJONHN(CommandBuffer DMCELDOJCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4E11200", Offset = "0x4E0FE00", VA = "0x184E11200", Slot = "8")]
	public void OCNMJMJONHN(CommandBuffer DMCELDOJCFP, ComputeShader AEMIEEPDHPI, int FHJBOKMPOFN = -1, int OIGPJHGNEHJ = -1, int FLMGMOKIHOD = -1, int JNDCJHJODHG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4E0F6C0", Offset = "0x4E0E2C0", VA = "0x184E0F6C0", Slot = "9")]
	public void LBLLALBKEGK(CommandBuffer DMCELDOJCFP, ComputeShader AEMIEEPDHPI, int FHJBOKMPOFN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4E0F650", Offset = "0x4E0E250", VA = "0x184E0F650", Slot = "4")]
	public void LBLLALBKEGK(Material MBCOMNNFJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4E0F0F0", Offset = "0x4E0DCF0", VA = "0x184E0F0F0", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FCBJCANCHHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong JOENIKFBOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong OFHOFPEMJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BCCNDKKJHCE
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct CKIEOINIPKB : FCBJCANCHHD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable JAKEDICJBKP;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong JOENIKFBOBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DA0", Offset = "0x8B39A0", VA = "0x1808B4DA0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x60FCA50", Offset = "0x60FB650", VA = "0x1860FCA50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong OFHOFPEMJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x14E0260", Offset = "0x14DEE60", VA = "0x1814E0260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4C79250", Offset = "0x4C77E50", VA = "0x184C79250")]
		internal CKIEOINIPKB(IDisposable AFOLODJNPKJ, ulong LLFOCJKOGHA, ulong LODPHOILLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6919B80", Offset = "0x6918780", VA = "0x186919B80", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct AJCIDFKLFMO : FCBJCANCHHD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture BLEEEMPLKKI;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong JOENIKFBOBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DA0", Offset = "0x8B39A0", VA = "0x1808B4DA0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x60FCA50", Offset = "0x60FB650", VA = "0x1860FCA50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong OFHOFPEMJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x14E0260", Offset = "0x14DEE60", VA = "0x1814E0260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x69172F0", Offset = "0x6915EF0", VA = "0x1869172F0")]
		public AJCIDFKLFMO(RenderTexture BHCOMKIMBKF, ulong FMFBBEHEGGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6917250", Offset = "0x6915E50", VA = "0x186917250", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong FGOAFONBLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6917730", Offset = "0x6916330", VA = "0x186917730")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6917870", Offset = "0x6916470", VA = "0x186917870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong DLNBHICOIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6917F80", Offset = "0x6916B80", VA = "0x186917F80")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6917FC0", Offset = "0x6916BC0", VA = "0x186917FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6917C50", Offset = "0x6916850", VA = "0x186917C50")]
	public static ComputeBuffer GADNMLFOLLL(int HDFABDCMCAG, int AKDKPDLBHND, ComputeBufferType NCNNODEFPOG, [Out] FCBJCANCHHD POAHFHMMEAF, ComputeBufferMode CMLBPDKMHGL = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69178B0", Offset = "0x69164B0", VA = "0x1869178B0")]
	public static RenderTexture GADNMLFOLLL(int GDDDJAHAGIA, int CLIMOHDCDNO, int PPFCFICLEFI, RenderTextureFormat KKEJAEKDBIN, [Out] FCBJCANCHHD POAHFHMMEAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x287FB60", Offset = "0x287E760", VA = "0x18287FB60")]
	public static NativeArray<T> LGBEOHMKBAM<T>(NativeArray<T> JAKEDICJBKP, ulong JKBHNDINMGD, [Out] FCBJCANCHHD POAHFHMMEAF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x287FAA0", Offset = "0x287E6A0", VA = "0x18287FAA0")]
	public static NativeArray<T> GADNMLFOLLL<T>(int JKBHNDINMGD, Allocator BLMBIIGOJPG, [Out] FCBJCANCHHD POAHFHMMEAF, NativeArrayOptions MMOLNDGHCHC = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6917E30", Offset = "0x6916A30", VA = "0x186917E30")]
	public static void IICIADDLCDE(FCBJCANCHHD JAKEDICJBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6917770", Offset = "0x6916370", VA = "0x186917770")]
	public static uint BIMGBMMCKDO(RenderTextureFormat KKEJAEKDBIN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OLFAKHBKIDE : BBDLMOHOLIP<AEGHIDCIBAD, AEGHIDCIBAD>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct GEALBEAOMNC : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> DKELJKCHNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> HKFDLMMOKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> NGGHNIBGIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> HKIOOPHOFDA;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6919470", Offset = "0x6918070", VA = "0x186919470")]
		public GEALBEAOMNC(NativeArray<int> HAIJHMEBKJB, NativeArray<float> MAOPKAKAJJI, NativeArray<float4x4> BANNBDDBHIN, NativeArray<float4> INANDBEAKLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x691A380", Offset = "0x6918F80", VA = "0x18691A380", Slot = "4")]
		public void Execute(int OPDMGNJCACB, TransformAccess KHIOEALLADK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct BOMFJLNJDKP : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> DKELJKCHNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> INMNHLOPBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> CGMJNBIBNHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<AEGHIDCIBAD> EEPPNGHDADP;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6919470", Offset = "0x6918070", VA = "0x186919470")]
		public BOMFJLNJDKP(NativeArray<int> HAIJHMEBKJB, NativeArray<float4x4> FIDIFKAAEDA, NativeArray<float4> KOCEENAJEGG, NativeArray<AEGHIDCIBAD> OPHLCCBBKLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6919400", Offset = "0x6918000", VA = "0x186919400", Slot = "4")]
		public void Execute(int OPDMGNJCACB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte MMNGJLHHCIN = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray HJOGIHONEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> LCFDLCPHLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> DIGKMMLODPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> LLPCGMPACPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> AHHKKJFACGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> KDOMKGIDEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private FCBJCANCHHD LKFKDJLMDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private FCBJCANCHHD DKHIDGOAKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private FCBJCANCHHD HMLILDPIOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private FCBJCANCHHD NEHPGHGHIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private FCBJCANCHHD LHIFJLDKKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform JIDEHKHPKKM;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6927250", Offset = "0x6925E50", VA = "0x186927250")]
	public OLFAKHBKIDE(int BAALDHCMPGB, int LJOIMBFJCFB, ComputeShader AEMIEEPDHPI, int FHJBOKMPOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6926EE0", Offset = "0x6925AE0", VA = "0x186926EE0", Slot = "6")]
	protected override void MDKGGDKMCII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x69270E0", Offset = "0x6925CE0", VA = "0x1869270E0")]
	private void MFMKIKEHCDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6926CA0", Offset = "0x69258A0", VA = "0x186926CA0")]
	public bool LGOKBIBKKKE(KHLPKNNJLGA POAHFHMMEAF, Transform KHIOEALLADK, float NOHGIHHEFNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6926E00", Offset = "0x6925A00", VA = "0x186926E00")]
	public void LHFMNAKAGNF(KHLPKNNJLGA POAHFHMMEAF, float NOHGIHHEFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x69271A0", Offset = "0x6925DA0", VA = "0x1869271A0")]
	public void PAKBGFJGLAC(KHLPKNNJLGA POAHFHMMEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6926C00", Offset = "0x6925800", VA = "0x186926C00", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IIAMLFADMCJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LMMNEJCMKMI IKNIENNEJLD();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface JEIHODNHPMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 EMLOEPPMHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int PJALGAPEPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int CEBNKMJLOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> KJEIHCPEBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> LDJLGOFDCLG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> DDLNKMOLPOO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> POHPLONEBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> LABOCFNDHGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> JDLBALPIGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int KHCICGKPHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int PDHGFKFAPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int CDFJAPFDBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool ICMOOMEPNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OCNMJMJONHN();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JPKGENGJIAP : JEIHODNHPMD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private IIAMLFADMCJ FNPOBGINPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private LMMNEJCMKMI AIKMKIOPGIF;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 EMLOEPPMHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8B92D0", Offset = "0x8B7ED0", VA = "0x1808B92D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x978B90", Offset = "0x977790", VA = "0x180978B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool MBAFCPCJMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8431F0", Offset = "0x841DF0", VA = "0x1808431F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int PJALGAPEPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8832B0", Offset = "0x881EB0", VA = "0x1808832B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x882E60", Offset = "0x881A60", VA = "0x180882E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int CEBNKMJLOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x844560", Offset = "0x843160", VA = "0x180844560", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x844550", Offset = "0x843150", VA = "0x180844550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int OHOKIAFBNFM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xB35150", Offset = "0xB33D50", VA = "0x180B35150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> KJEIHCPEBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6923850", Offset = "0x6922450", VA = "0x186923850", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> LDJLGOFDCLG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6923990", Offset = "0x6922590", VA = "0x186923990", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> DDLNKMOLPOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6923790", Offset = "0x6922390", VA = "0x186923790", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> POHPLONEBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x69238C0", Offset = "0x69224C0", VA = "0x1869238C0", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> LABOCFNDHGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6923960", Offset = "0x6922560", VA = "0x186923960", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> JDLBALPIGHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6923930", Offset = "0x6922530", VA = "0x186923930", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ICMOOMEPNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9B1E90", Offset = "0x9B0A90", VA = "0x1809B1E90", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA07C40", Offset = "0xA06840", VA = "0x180A07C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int KHCICGKPHGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6923AF0", Offset = "0x69226F0", VA = "0x186923AF0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int PDHGFKFAPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6923AD0", Offset = "0x69226D0", VA = "0x186923AD0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int CDFJAPFDBGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6923770", Offset = "0x6922370", VA = "0x186923770", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6923B00", Offset = "0x6922700", VA = "0x186923B00")]
	public JPKGENGJIAP(Hash128 LNMBFIMPMFA, IIAMLFADMCJ FNPOBGINPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x69239C0", Offset = "0x69225C0", VA = "0x1869239C0", Slot = "16")]
	public void OCNMJMJONHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x69237C0", Offset = "0x69223C0", VA = "0x1869237C0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct KHLPKNNJLGA : IEquatable<KHLPKNNJLGA>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly KHLPKNNJLGA GFAAJGGODEO;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int HDEPOMLIBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x916930", Offset = "0x915530", VA = "0x180916930")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xA63EA0", Offset = "0xA62AA0", VA = "0x180A63EA0")]
	public KHLPKNNJLGA(int OPDMGNJCACB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6925910", Offset = "0x6924510", VA = "0x186925910", Slot = "4")]
	public bool Equals(KHLPKNNJLGA OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6925960", Offset = "0x6924560", VA = "0x186925960", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6925A30", Offset = "0x6924630", VA = "0x186925A30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KGDEHKFMNOE : DPFMOKDBGKN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool MOKKEAKOGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private JEIHODNHPMD IGEEGGIFHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<KHLPKNNJLGA> LIPJHHHOJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<KHLPKNNJLGA> JHJKOLOCAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<KHLPKNNJLGA> FFJHFIPJNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> CFEADEHOPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int DEKBEBJEJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int ONAEOHMBPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int IIKOBBNMHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int DHPOOGKKKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int AHDBMOILIFL;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int HDEPOMLIBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6923B50", Offset = "0x6922750", VA = "0x186923B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6925200", Offset = "0x6923E00", VA = "0x186925200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool JKFNMBHLJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x897580", Offset = "0x896180", VA = "0x180897580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x99DDA0", Offset = "0x99C9A0", VA = "0x18099DDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool PJIEPINLNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB6AC20", Offset = "0xB69820", VA = "0x180B6AC20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB6AC30", Offset = "0xB69830", VA = "0x180B6AC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool KPJHPNGPJID
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool KLEOOCIKEIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4A933C0", Offset = "0x4A91FC0", VA = "0x184A933C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1947330", Offset = "0x1945F30", VA = "0x181947330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float LKPGLOCLFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B38B0", Offset = "0x8B24B0", VA = "0x1808B38B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1D13540", Offset = "0x1D12140", VA = "0x181D13540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x69257A0", Offset = "0x69243A0", VA = "0x1869257A0")]
	public KGDEHKFMNOE(JEIHODNHPMD AIKMKIOPGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x69242D0", Offset = "0x6922ED0", VA = "0x1869242D0")]
	private void LGIIFPADPNN(JEIHODNHPMD AIKMKIOPGIF, int DEKBEBJEJFH, int KKMJKJMDGBF, int OPDMGNJCACB, int MGHPMJHNKPL, CBCAGGHLPNP IMCLGJBJJKP, float AKNPDHJOCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x69254E0", Offset = "0x69240E0", VA = "0x1869254E0")]
	private void PLGLPIJMDLM(JEIHODNHPMD AIKMKIOPGIF, int GDONENODLMI, int OPDMGNJCACB, uint3 PFFEHCOMOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6925240", Offset = "0x6923E40", VA = "0x186925240")]
	private bool OPONDNCOPBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x69247A0", Offset = "0x69233A0", VA = "0x1869247A0", Slot = "4")]
	public bool MPFJKDGCCNN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6925180", Offset = "0x6923D80", VA = "0x186925180", Slot = "5")]
	public bool NBJEMGDMOCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6923C60", Offset = "0x6922860", VA = "0x186923C60", Slot = "6")]
	public void IFPALOLJLCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6923C00", Offset = "0x6922800", VA = "0x186923C00")]
	public void DCBKBEIFEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6923C00", Offset = "0x6922800", VA = "0x186923C00", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DPFMOKDBGKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool KPJHPNGPJID
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool KLEOOCIKEIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MPFJKDGCCNN();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NBJEMGDMOCC();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IFPALOLJLCH();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HJLMCBCHEMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float LEKJHGDILDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, KGDEHKFMNOE> OHELDNCGODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, CILPFAFLADH> PABANKDIDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<DPFMOKDBGKN> CMADLLHNMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<DPFMOKDBGKN> LNCJHAECEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<DPFMOKDBGKN> DGOOEDIJOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int FIFLLDCGCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int CJAFFNCMKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float GEICOIINGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool JGNPLGINAPI;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool LCLOHLCIBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xDB8970", Offset = "0xDB7570", VA = "0x180DB8970")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xDCDBD0", Offset = "0xDCC7D0", VA = "0x180DCDBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool FANLCLNLOID
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x691B220", Offset = "0x6919E20", VA = "0x18691B220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string CGIFBEFPALD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x691BEA0", Offset = "0x691AAA0", VA = "0x18691BEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x691B410", Offset = "0x691A010", VA = "0x18691B410")]
	public void EKHPKPHNKDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x691B970", Offset = "0x691A570", VA = "0x18691B970")]
	public void IADHBPPDIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x691C340", Offset = "0x691AF40", VA = "0x18691C340")]
	public HJLMCBCHEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x691B420", Offset = "0x691A020", VA = "0x18691B420")]
	public BJPMBHNNBAA FHCDBNBHAOK(HPHCJGMNCCB HFEGKIPECIL, bool PGPFFNMDNHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x691B830", Offset = "0x691A430", VA = "0x18691B830")]
	public CILPFAFLADH FHCDBNBHAOK(DAIPKONBEHK MBCOMNNFJFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x691B980", Offset = "0x691A580", VA = "0x18691B980")]
	public bool KEEOOMLMLBA(Hash128 EPKGPGILADI, [Out] KGDEHKFMNOE FFGHIICEFOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x691B550", Offset = "0x691A150", VA = "0x18691B550")]
	public KGDEHKFMNOE FHCDBNBHAOK(JEIHODNHPMD AIKMKIOPGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x691B200", Offset = "0x6919E00", VA = "0x18691B200")]
	private void AKOGDNAPMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x691B270", Offset = "0x6919E70", VA = "0x18691B270")]
	private bool DJCKLJPADPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x691B9F0", Offset = "0x691A5F0", VA = "0x18691B9F0")]
	public void OCNMJMJONHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x691B300", Offset = "0x6919F00", VA = "0x18691B300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x691C250", Offset = "0x691AE50", VA = "0x18691C250")]
	public void PADEMNHGKIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GHMOBJMHGEJ : BBDLMOHOLIP<NMOEDLFKLDH, NMOEDLFKLDH>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x691A540", Offset = "0x6919140", VA = "0x18691A540")]
	public GHMOBJMHGEJ(int BAALDHCMPGB, int LJOIMBFJCFB, ComputeShader AEMIEEPDHPI, int FHJBOKMPOFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BGMGBHLOGEL : BBDLMOHOLIP<LCKCDLCMFAF, LCKCDLCMFAF>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6918000", Offset = "0x6916C00", VA = "0x186918000")]
	public BGMGBHLOGEL(int BAALDHCMPGB, int LJOIMBFJCFB, ComputeShader AEMIEEPDHPI, int FHJBOKMPOFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NGOHCBEEHGL : BBDLMOHOLIP<MNGLBCFGHPM, MNGLBCFGHPM>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6926780", Offset = "0x6925380", VA = "0x186926780")]
	public NGOHCBEEHGL(int BAALDHCMPGB, int LJOIMBFJCFB, ComputeShader AEMIEEPDHPI, int FHJBOKMPOFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class ACGENDIIDAN : BBDLMOHOLIP<HFANLEJEGPH, FDLLOKJOLCP>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6917000", Offset = "0x6915C00", VA = "0x186917000")]
	public ACGENDIIDAN(int BAALDHCMPGB, int LJOIMBFJCFB, ComputeShader AEMIEEPDHPI, int FHJBOKMPOFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LMLPIFAAGCM : BBDLMOHOLIP<ANELINJHFFB, ANELINJHFFB>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6925CB0", Offset = "0x69248B0", VA = "0x186925CB0")]
	public LMLPIFAAGCM(int BAALDHCMPGB, int LJOIMBFJCFB, ComputeShader AEMIEEPDHPI, int FHJBOKMPOFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class DCOHCNJNHAD : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private JLKGPANAING EKNDHMNKOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool MPKDEMAOPIG;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool GAGOAECDGKK;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x691A1F0", Offset = "0x6918DF0", VA = "0x18691A1F0")]
	public DCOHCNJNHAD(JLKGPANAING NGFDDBBNADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x691A060", Offset = "0x6918C60", VA = "0x18691A060", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer DMCELDOJCFP, RenderingData FMJPLEFDOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6919DF0", Offset = "0x69189F0", VA = "0x186919DF0", Slot = "6")]
	public override void Configure(CommandBuffer DMCELDOJCFP, RenderTextureDescriptor HNEFLABLBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6919E30", Offset = "0x6918A30", VA = "0x186919E30", Slot = "9")]
	public override void Execute(ScriptableRenderContext FBMKGECLCCA, RenderingData FMJPLEFDOHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class HBAJKFMANFL
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct LLKALOFOFJN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string GFLNGGKHEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer DMCELDOJCFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext FBMKGECLCCA;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6925BA0", Offset = "0x69247A0", VA = "0x186925BA0")]
		public LLKALOFOFJN(string BCHINJMJGIC, ScriptableRenderContext NKGGMKFMBGA, [Out] CommandBuffer FAFBBKAJADL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6925AF0", Offset = "0x69246F0", VA = "0x186925AF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x691B0B0", Offset = "0x6919CB0", VA = "0x18691B0B0")]
	public static bool KBOLLNLAANM(RenderingData FMJPLEFDOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x691ACE0", Offset = "0x69198E0", VA = "0x18691ACE0")]
	public static void IBDEGKBDABB(CommandBuffer DMCELDOJCFP, ScriptableRenderContext FBMKGECLCCA, ShadowDrawingSettings LEEINMKPJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x691AE80", Offset = "0x6919A80", VA = "0x18691AE80")]
	public static void JIBIFNFJAOF(CommandBuffer DMCELDOJCFP, ScriptableRenderContext FBMKGECLCCA, RenderingData FMJPLEFDOHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class JLKGPANAING : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class NOFJPJFPHOL
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int ADIKMEMEONM;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int DHFKEAHPLKA;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static FCKJFEMEJLG<FFJPAIHBDMO> GBBCDKLHMEB;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static FCKJFEMEJLG<uint> POHKHBBNNKM;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static FCBJCANCHHD HGAOJLDJEFF;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer APCBGJMILDP;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<HMDOJIAHALH> BIPIEAIJICK;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int MADLIEGKKHG;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int KCIPHJHEHKH;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int LHJFBPMLMLC;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int JOKEBGBEHPB;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] KLPEIBPNJLJ;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] HMJNPDLKICI;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static EAJMFDGNNLP[][] ENFFAOFJCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] PBNDLJNMDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int DLGLAFFFDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int LFGDMLOLBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int EEIOFONMNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int NOALPMCDMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int CLJIEAJHABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int HIMHBMOHCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int NHKHLDMEFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int OPDKGGMOOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int ICAADIDDCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int MBKLHHDKIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int OPLGKHAKFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int MNAIFDFHOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int DLGEHLICMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int ONALBIFBCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int EPKNJBCGGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int BEHGAEHOLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int NPKCBHDLBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int JPGGOHLLKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] PAPLGGCKAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private HJLMCBCHEMA OFMBGAGNEKC;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool FHEAOJJMDJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x691FF80", Offset = "0x691EB80", VA = "0x18691FF80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x691D640", Offset = "0x691C240", VA = "0x18691D640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool FABNDJECAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6920AA0", Offset = "0x691F6A0", VA = "0x186920AA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6921E10", Offset = "0x6920A10", VA = "0x186921E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData JLODENNJHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x691D5A0", Offset = "0x691C1A0", VA = "0x18691D5A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6920A30", Offset = "0x691F630", VA = "0x186920A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static OLFAKHBKIDE PAECADNCBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6920970", Offset = "0x691F570", VA = "0x186920970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x69209C0", Offset = "0x691F5C0", VA = "0x1869209C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static GHMOBJMHGEJ LPBPGLJINFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x691D5F0", Offset = "0x691C1F0", VA = "0x18691D5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x691FEB0", Offset = "0x691EAB0", VA = "0x18691FEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static BGMGBHLOGEL ODEKMFNAEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x691C630", Offset = "0x691B230", VA = "0x18691C630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x69226C0", Offset = "0x69212C0", VA = "0x1869226C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static NGOHCBEEHGL EEGKCFCFPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6921ED0", Offset = "0x6920AD0", VA = "0x186921ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6921D40", Offset = "0x6920940", VA = "0x186921D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static ACGENDIIDAN ANDKEKDLIGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6921DB0", Offset = "0x69209B0", VA = "0x186921DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x691C5B0", Offset = "0x691B1B0", VA = "0x18691C5B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static LMLPIFAAGCM CPCGIEJNIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x691DD20", Offset = "0x691C920", VA = "0x18691DD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x691D4B0", Offset = "0x691C0B0", VA = "0x18691D4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material HFEOHJACOHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6922660", Offset = "0x6921260", VA = "0x186922660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x691C680", Offset = "0x691B280", VA = "0x18691C680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material PFMAIKNBNDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x691FF20", Offset = "0x691EB20", VA = "0x18691FF20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x691D430", Offset = "0x691C030", VA = "0x18691D430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material ACFGNOJPNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x691F130", Offset = "0x691DD30", VA = "0x18691F130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x691C530", Offset = "0x691B130", VA = "0x18691C530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material MGFOJFBDACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x691C4D0", Offset = "0x691B0D0", VA = "0x18691C4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6921CC0", Offset = "0x69208C0", VA = "0x186921CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool GFPNANFBBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6921E70", Offset = "0x6920A70", VA = "0x186921E70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6922510", Offset = "0x6921110", VA = "0x186922510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool FANLCLNLOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x691C700", Offset = "0x691B300", VA = "0x18691C700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string CGIFBEFPALD
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6922730", Offset = "0x6921330", VA = "0x186922730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6923510", Offset = "0x6922110", VA = "0x186923510")]
	internal JLKGPANAING([Optional] MClusterData KMACPCNPAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x691DD80", Offset = "0x691C980", VA = "0x18691DD80")]
	public void EHHLDMLDHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x69233D0", Offset = "0x6921FD0", VA = "0x1869233D0")]
	public void PIPPGJNDDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x691DC00", Offset = "0x691C800", VA = "0x18691DC00")]
	public void DLNLEEBEHDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x69208D0", Offset = "0x691F4D0", VA = "0x1869208D0")]
	public bool HBKJOIDDHPB(Hash128 LNMBFIMPMFA, [Out] KGDEHKFMNOE AIKMKIOPGIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x691F550", Offset = "0x691E150", VA = "0x18691F550")]
	public KGDEHKFMNOE FHCDBNBHAOK(JEIHODNHPMD IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x691F350", Offset = "0x691DF50", VA = "0x18691F350")]
	public CILPFAFLADH FHCDBNBHAOK(DAIPKONBEHK MBCOMNNFJFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x691F190", Offset = "0x691DD90", VA = "0x18691F190")]
	public BJPMBHNNBAA FHCDBNBHAOK(HPHCJGMNCCB HFEGKIPECIL, bool PGPFFNMDNHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6920AF0", Offset = "0x691F6F0", VA = "0x186920AF0")]
	public void IFPALOLJLCH(DPFMOKDBGKN KGCMPKPCOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6922570", Offset = "0x6921170", VA = "0x186922570")]
	public static void MLFLPBIGFDF(GAEJLKPIMBI IGOCEJPANBF, EAJMFDGNNLP[] IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x691FFD0", Offset = "0x691EBD0", VA = "0x18691FFD0")]
	private void HAEBOBDHJLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x691C760", Offset = "0x691B360", VA = "0x18691C760")]
	private static void CKDNDJCLFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x691F610", Offset = "0x691E210", VA = "0x18691F610")]
	public void GBLOOIOIOMH(CommandBuffer DMCELDOJCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6921AF0", Offset = "0x69206F0", VA = "0x186921AF0")]
	public void JCBJGNKELMP([Optional] ScriptableRenderContext? FBMKGECLCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x69230F0", Offset = "0x6921CF0", VA = "0x1869230F0")]
	public void PAGDNPGKFNI(CommandBuffer DMCELDOJCFP, ShadowSplitData JKJGOPBNOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6922E10", Offset = "0x6921A10", VA = "0x186922E10")]
	public void PAGDNPGKFNI(CommandBuffer DMCELDOJCFP, CameraData HLFFHPKLIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x691D6A0", Offset = "0x691C2A0", VA = "0x18691D6A0")]
	public void DGLOPPDCPGC(CommandBuffer DMCELDOJCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x691D530", Offset = "0x691C130", VA = "0x18691D530")]
	public void COOEEOEBGCF(CommandBuffer DMCELDOJCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x691FA10", Offset = "0x691E610", VA = "0x18691FA10")]
	public void GGODBBLIIDK(CommandBuffer DMCELDOJCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6921F20", Offset = "0x6920B20", VA = "0x186921F20")]
	public void LAOIOFGJCHO(CommandBuffer DMCELDOJCFP, GAEJLKPIMBI OOBCEONMDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x691F930", Offset = "0x691E530", VA = "0x18691F930")]
	public void GCOJNGINBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6920B40", Offset = "0x691F740", VA = "0x186920B40")]
	public void IICIADDLCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x691DC10", Offset = "0x691C810", VA = "0x18691DC10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class CGPJPJIEICC
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1EF03F0", Offset = "0x1EEEFF0", VA = "0x181EF03F0")]
	public static int NMKPBFNNLEK(int EKELKKECGGF, int MMDDLENHGDE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct AEGHIDCIBAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 HGIKKFBABME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 EFDPPBJJCPC;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly AEGHIDCIBAD IBBHPPLEKCH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly AEGHIDCIBAD GFAAJGGODEO;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6917220", Offset = "0x6915E20", VA = "0x186917220")]
	public AEGHIDCIBAD(float4x4 ICPLIEGCILH, float4 BFOIINJODPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x69170B0", Offset = "0x6915CB0", VA = "0x1869170B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct CBCAGGHLPNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 DFPHDEDIHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 KLEPCPADMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 GLLONGLNLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 DCFJIPOHFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 ANJNAJNLPLP;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct DDLJACBBPJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 DFPHDEDIHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 KLEPCPADMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 GLLONGLNLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 DCFJIPOHFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 ANJNAJNLPLP;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct FDLLOKJOLCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public DDLJACBBPJK MPDCAEFBBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public DDLJACBBPJK NFOCGHLIBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public DDLJACBBPJK BFBAHJDAAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public DDLJACBBPJK JPHNEGHLHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public DDLJACBBPJK BIJPEGPIDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public DDLJACBBPJK MHDLOIAANHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public DDLJACBBPJK KNKNEMPNPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public DDLJACBBPJK JGHKBEMILMB;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct HFANLEJEGPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public CBCAGGHLPNP MPDCAEFBBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public CBCAGGHLPNP NFOCGHLIBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public CBCAGGHLPNP BFBAHJDAAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public CBCAGGHLPNP JPHNEGHLHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public CBCAGGHLPNP BIJPEGPIDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public CBCAGGHLPNP MHDLOIAANHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public CBCAGGHLPNP KNKNEMPNPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public CBCAGGHLPNP JGHKBEMILMB;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct LCKCDLCMFAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 CLJELFDEHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint FEECPJHHFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint CCJPPHADPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float HJCEHAIDOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint CMNPLACBCOJ;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6925AC0", Offset = "0x69246C0", VA = "0x186925AC0")]
	public LCKCDLCMFAF(DAIPKONBEHK MBCOMNNFJFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FFJPAIHBDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint FLOBLHPKHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint LAHJJCHGCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint MGHPMJHNKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint CMNPLACBCOJ;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x691A2A0", Offset = "0x6918EA0", VA = "0x18691A2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct MNGLBCFGHPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint KKMJKJMDGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint OHEANDIPEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint ONAEOHMBPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint CMNPLACBCOJ;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x69266D0", Offset = "0x69252D0", VA = "0x1869266D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct NMOEDLFKLDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint BOAHGJOJALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint JMEOBGMBEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint JFOIOCLNBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint CNJGMBOPLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint DJAFCNELAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint JIKLGLLDGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint LHIFGJDIMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint CMNPLACBCOJ;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6926830", Offset = "0x6925430", VA = "0x186926830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct ANELINJHFFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 HILEKMOIJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 NONKFLEJANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 EDMLJJCFOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 IGJOCBIBPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 NMMGCDJIACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 PPFIALHKODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 AHBHEOPFDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 PCPCPBJALLH;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6917320", Offset = "0x6915F20", VA = "0x186917320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum GAEJLKPIMBI
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
