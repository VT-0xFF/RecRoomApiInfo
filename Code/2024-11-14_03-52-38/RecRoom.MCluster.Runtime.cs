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
public struct OKLGFGGJGFA
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] EHEIOEBHBNA;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] IBMFALJGIMB;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] KJCBHFPAEJE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x17111F0", Offset = "0x17105F0", VA = "0x1817111F0")]
	public static int HPCCDECPJII(PDIOLNLFKIH BOJMNCJMGLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1E90", Offset = "0x6DB1290", VA = "0x186DB1E90")]
	public static int LCCHFNKPGGN(PDIOLNLFKIH BOJMNCJMGLC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NDMKCKGBGIP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int NJPENKPNBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DPEFIAEDLKD IALCFMNNFKI(int BGHMMFOMOHD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 OHPIFIEEJCB(int BGHMMFOMOHD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EHHOFGGGKNH ILGEEDFNAGD();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PHOIODCGCJJ PNDLDOGCOKL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GJNDKOFHCJC : GPEKDJHKMLB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private EHHOFGGGKNH JGDFNKEDOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform LOKHKIAGCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<DHHFIFCDOAL> PKKBCDENCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private KMGBDAFEEMH BOKAPJNKGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private GJFBHOEOJMK IFOGGOEMFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HJPOGLGLBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NDMKCKGBGIP OCKFCMMGEGC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float IDPEIFKOIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA9B870", Offset = "0xA9AC70", VA = "0x180A9B870")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x10439F0", Offset = "0x1042DF0", VA = "0x1810439F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KIFHHOAHNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x92AA90", Offset = "0x929E90", VA = "0x18092AA90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9C9570", Offset = "0x9C8970", VA = "0x1809C9570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool AOEGMOPOGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD6EF50", Offset = "0xD6E350", VA = "0x180D6EF50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD6F0B0", Offset = "0xD6E4B0", VA = "0x180D6F0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PFAKIKACPFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x63F95F0", Offset = "0x63F89F0", VA = "0x1863F95F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x63F95D0", Offset = "0x63F89D0", VA = "0x1863F95D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BADJNMJHJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1841C30", Offset = "0x1841030", VA = "0x181841C30", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6DADE70", Offset = "0x6DAD270", VA = "0x186DADE70")]
	public GJNDKOFHCJC(NDMKCKGBGIP EALDCBFDHKI, bool MEJHLOBHJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6DADC50", Offset = "0x6DAD050", VA = "0x186DADC50")]
	private bool JPLFLMBDFEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6DAD030", Offset = "0x6DAC430", VA = "0x186DAD030", Slot = "4")]
	public bool FNBCENOGBNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6DACE50", Offset = "0x6DAC250", VA = "0x186DACE50", Slot = "5")]
	public bool DPCLJOJLMCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6DACC20", Offset = "0x6DAC020", VA = "0x186DACC20", Slot = "6")]
	public void BIJNEFLCHFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6DAD020", Offset = "0x6DAC420", VA = "0x186DAD020", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KLAJKANIFFH
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPDAHNNCBAN(CommandBuffer HILAPBJMMLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KGLCKGMBKBF : KLAJKANIFFH
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int GPNGJJINABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x974190", Offset = "0x973590", VA = "0x180974190")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier LFMFNBAGMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x45BE070", Offset = "0x45BD470", VA = "0x1845BE070")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFBB0", Offset = "0x6DAEFB0", VA = "0x186DAFBB0")]
	public KGLCKGMBKBF(int HDCHKIOFILD, RenderTargetIdentifier EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFB60", Offset = "0x6DAEF60", VA = "0x186DAFB60", Slot = "4")]
	public void EPDAHNNCBAN(CommandBuffer HILAPBJMMLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct OPNDEEEKPFL : KLAJKANIFFH
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int GPNGJJINABA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x974190", Offset = "0x973590", VA = "0x180974190")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] BPPOOLJMMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x948250", Offset = "0x947650", VA = "0x180948250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x10D9F40", Offset = "0x10D9340", VA = "0x1810D9F40")]
	public OPNDEEEKPFL(int HDCHKIOFILD, Vector4[] EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2550", Offset = "0x6DB1950", VA = "0x186DB2550", Slot = "4")]
	public void EPDAHNNCBAN(CommandBuffer HILAPBJMMLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct LBNEMBIGDGC : KLAJKANIFFH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int GPNGJJINABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x974190", Offset = "0x973590", VA = "0x180974190")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] LECLDAJJOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x948250", Offset = "0x947650", VA = "0x180948250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x10D9F40", Offset = "0x10D9340", VA = "0x1810D9F40")]
	public LBNEMBIGDGC(int HDCHKIOFILD, float[] EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0420", Offset = "0x6DAF820", VA = "0x186DB0420", Slot = "4")]
	public void EPDAHNNCBAN(CommandBuffer HILAPBJMMLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct NPENMKHPBGM : KLAJKANIFFH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string MKBLEONOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool MLOJNNLOHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2122FD0", Offset = "0x21223D0", VA = "0x182122FD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3F18840", Offset = "0x3F17C40", VA = "0x183F18840")]
	public NPENMKHPBGM(string ACDGEPBIBHJ, bool FCINDJJJBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6DB13D0", Offset = "0x6DB07D0", VA = "0x186DB13D0", Slot = "4")]
	public void EPDAHNNCBAN(CommandBuffer HILAPBJMMLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PHOIODCGCJJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 HGDNNNGCFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 FLNCHCAGEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAE8210", Offset = "0xAE7610", VA = "0x180AE8210")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int HAHEKGEFHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9741A0", Offset = "0x9735A0", VA = "0x1809741A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LCJEEGIGHGD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7A0", Offset = "0x8DABA0", VA = "0x1808DB7A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float IIHBOGFPFDA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA9B890", Offset = "0xA9AC90", VA = "0x180A9B890")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6DB26C0", Offset = "0x6DB1AC0", VA = "0x186DB26C0")]
	public PHOIODCGCJJ(Color FKCCOIADMAE, int CLLDAMEIGJL, int NBFPJBGNDFK, float JMMMLKJPEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xC5D560", Offset = "0xC5C960", VA = "0x180C5D560")]
	private static float4 OEDOJEHILBP(Color FKCCOIADMAE)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2630", Offset = "0x6DB1A30", VA = "0x186DB2630")]
	private static Hash128 IGAJKAIPOEI(PHOIODCGCJJ EALDCBFDHKI)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KMGBDAFEEMH : GPEKDJHKMLB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string HLKPPGEDPCL;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string BBLOIHNBGKF;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string CALMHHJAIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private PHOIODCGCJJ MFBIGNDMOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NJKFJEAIICG JAEJMKKLMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 NINAIMMDCPK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public GJFBHOEOJMK FFIBOANNOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8C2BE0", Offset = "0x8C1FE0", VA = "0x1808C2BE0")]
		[CompilerGenerated]
		get
		{
			return default(GJFBHOEOJMK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xE015A0", Offset = "0xE009A0", VA = "0x180E015A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KIFHHOAHNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5D6B630", Offset = "0x5D6AA30", VA = "0x185D6B630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D6B640", Offset = "0x5D6AA40", VA = "0x185D6B640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool AOEGMOPOGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x21E5410", Offset = "0x21E4810", VA = "0x1821E5410")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6D2E970", Offset = "0x6D2DD70", VA = "0x186D2E970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BADJNMJHJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PFAKIKACPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5E22890", Offset = "0x5E21C90", VA = "0x185E22890", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0230", Offset = "0x6DAF630", VA = "0x186DB0230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int DIJEOHGLGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6DB01E0", Offset = "0x6DAF5E0", VA = "0x186DB01E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0330", Offset = "0x6DAF730", VA = "0x186DB0330")]
	public KMGBDAFEEMH(PHOIODCGCJJ FCEPELPKMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0090", Offset = "0x6DAF490", VA = "0x186DB0090")]
	private bool JPLFLMBDFEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFF40", Offset = "0x6DAF340", VA = "0x186DAFF40", Slot = "4")]
	public bool FNBCENOGBNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6DB01A0", Offset = "0x6DAF5A0", VA = "0x186DB01A0")]
	private static NJKFJEAIICG KILNGMLEJNH(PHOIODCGCJJ EALDCBFDHKI)
	{
		return default(NJKFJEAIICG);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFD90", Offset = "0x6DAF190", VA = "0x186DAFD90", Slot = "5")]
	public bool DPCLJOJLMCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFC80", Offset = "0x6DAF080", VA = "0x186DAFC80", Slot = "6")]
	public void BIJNEFLCHFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6DB04D0", Offset = "0x6DAF8D0", VA = "0x186DB04D0", Slot = "0")]
		public override bool Equals(object OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6DB06D0", Offset = "0x6DAFAD0", VA = "0x186DB06D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA887D0", Offset = "0xA87BD0", VA = "0x180A887D0")]
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
		private DOBACKFJEJM opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static EGNJJMFPCMM CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6DB0DC0", Offset = "0x6DB01C0", VA = "0x186DB0DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6DB0E00", Offset = "0x6DB0200", VA = "0x186DB0E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6DB07B0", Offset = "0x6DAFBB0", VA = "0x186DB07B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0780", Offset = "0x6DAFB80", VA = "0x186DB0780", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CJAGOGFODOI, RenderingData FNJDAPBBICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0C20", Offset = "0x6DB0020", VA = "0x186DB0C20")]
		public void KHPJJEPBLNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x10EC460", Offset = "0x10EB860", VA = "0x1810EC460")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ENPKCAIJANN<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DHDFMEHDMBJ FHGCHPFHANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private DHDFMEHDMBJ FFBNDJFMMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer FIGEDBNCLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture JCFFIHJELJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int GEHEMCEPFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int NKAFKOCCBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string PIHIIMEPNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string LNDJLOMPPOC;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8A1360", Offset = "0x8A0760", VA = "0x1808A1360")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int BMKJDGDAHIB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9F4980", Offset = "0x9F3D80", VA = "0x1809F4980")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int LMAHKJOCPOO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9620", Offset = "0x8B8A20", VA = "0x1808B9620")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3BB3720", Offset = "0x3BB2B20", VA = "0x183BB3720")]
	public ENPKCAIJANN(string ACDGEPBIBHJ, int BENFJHJDIJJ, [Optional] RenderTextureFormat? BEMIADMLHDO, bool KNJPKMCJMAC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3BAFBA0", Offset = "0x3BAEFA0", VA = "0x183BAFBA0")]
	public void DPCLJOJLMCI(CommandBuffer HILAPBJMMLJ, NativeArray<ValType> EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3BB1D20", Offset = "0x3BB1120", VA = "0x183BB1D20")]
	public void MEHMLMCOANH(CommandBuffer HILAPBJMMLJ, ComputeShader PHHKBAFCEMH, int FKGMOEKMNOF, int ANHNCHGMNAJ = -1, int BLJIPLNFPFM = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3BB1350", Offset = "0x3BB0750", VA = "0x183BB1350")]
	public void MEHMLMCOANH(Material JAEJMKKLMIE, int ANHNCHGMNAJ = -1, int BLJIPLNFPFM = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3BB0980", Offset = "0x3BAFD80", VA = "0x183BB0980", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EGLAONKBOHD
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEHMLMCOANH(Material FCEPELPKMED);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KJICPJOCNAH<SrcEntry, DstEntry> : EGLAONKBOHD, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] AGIKOGDKIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected DHDFMEHDMBJ HPFODJMNMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected DHDFMEHDMBJ PJEJDOOBIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> JEMJNKOIPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> GGKGBLEAPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int BNMCOCLCCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int OKEDHHPCMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected ENPKCAIJANN<int> BHEOFOEPBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected ENPKCAIJANN<SrcEntry> KKEANEHAEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected ENPKCAIJANN<DstEntry> NAJJKCGOMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader EBCFOBNGPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int LAELIKOEMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int ANOFDOODAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int DDPHHMJODGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int GCEPFDLKIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int MBHFOKKHJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int APPLNBKGPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int EPHFOBJIOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int FGGGCGLEBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int BJKDNLKGMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int FMCFPAIMCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int AJPAFPEDIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int OENFNGKDPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string IOEFJOINOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] JCOELOCIMBO;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int BAJAMKMOMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4528B50", Offset = "0x4527F50", VA = "0x184528B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string GKDMMGCFKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4526360", Offset = "0x4525760", VA = "0x184526360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4529EE0", Offset = "0x45292E0", VA = "0x184529EE0")]
	public KJICPJOCNAH(string ACDGEPBIBHJ, int IIKBHDMNEGE, int BCDOPIAAPDG, RenderTextureFormat BEMIADMLHDO, ComputeShader JAPHKDOHBMF, int HKLJMIFLIDO = 0, int PCFBBKAJDJE = 0, int ELGAKAFGIKM = 0, int FBJCLLHCLJH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x45262F0", Offset = "0x45256F0", VA = "0x1845262F0")]
	public int HHFIJJOMIKL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x45257F0", Offset = "0x4524BF0", VA = "0x1845257F0")]
	protected void EDBMCHBEOOE(int OBFJPFHENMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4525840", Offset = "0x4524C40", VA = "0x184525840")]
	public GJFBHOEOJMK FNBCENOGBNB(SrcEntry EIFGKHNPLEK)
	{
		return default(GJFBHOEOJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4524850", Offset = "0x4523C50", VA = "0x184524850")]
	public bool DPCLJOJLMCI(GJFBHOEOJMK DOBBMOLDHPN, SrcEntry EIFGKHNPLEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x45244F0", Offset = "0x45238F0", VA = "0x1845244F0")]
	public bool BIJNEFLCHFA(GJFBHOEOJMK DOBBMOLDHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "6")]
	protected virtual void DAKPINCAHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4527650", Offset = "0x4526A50", VA = "0x184527650", Slot = "7")]
	public void MKMAAKCFANM(CommandBuffer HILAPBJMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4527A20", Offset = "0x4526E20", VA = "0x184527A20", Slot = "8")]
	public void MKMAAKCFANM(CommandBuffer HILAPBJMMLJ, ComputeShader JAPHKDOHBMF, int HKLJMIFLIDO = -1, int PCFBBKAJDJE = -1, int ELGAKAFGIKM = -1, int FBJCLLHCLJH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4527440", Offset = "0x4526840", VA = "0x184527440", Slot = "9")]
	public void MEHMLMCOANH(CommandBuffer HILAPBJMMLJ, ComputeShader JAPHKDOHBMF, int HKLJMIFLIDO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x45275E0", Offset = "0x45269E0", VA = "0x1845275E0", Slot = "4")]
	public void MEHMLMCOANH(Material JAEJMKKLMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x45251F0", Offset = "0x45245F0", VA = "0x1845251F0", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DHDFMEHDMBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong LEKEOLCNAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong NCMCMDABLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BCHCBFDCHJH
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct PLBPNBJNAHL : DHDFMEHDMBJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable NPHDACFOFLD;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong LEKEOLCNAMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x948250", Offset = "0x947650", VA = "0x180948250", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xC8A0E0", Offset = "0xC894E0", VA = "0x180C8A0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong NCMCMDABLBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9B90D0", Offset = "0x9B84D0", VA = "0x1809B90D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x508D820", Offset = "0x508CC20", VA = "0x18508D820")]
		internal PLBPNBJNAHL(IDisposable HAJBFDJCLOM, ulong ANJEJIDAOJI, ulong KGFCJMPMHHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6DB27F0", Offset = "0x6DB1BF0", VA = "0x186DB27F0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct DOHBBMOJCON : DHDFMEHDMBJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture EDLKOOKPCOD;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong LEKEOLCNAMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x948250", Offset = "0x947650", VA = "0x180948250", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xC8A0E0", Offset = "0xC894E0", VA = "0x180C8A0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong NCMCMDABLBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9B90D0", Offset = "0x9B84D0", VA = "0x1809B90D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6DA5560", Offset = "0x6DA4960", VA = "0x186DA5560")]
		public DOHBBMOJCON(RenderTexture LGMOHAIKHNA, ulong KGCMKNCMHOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6DA54C0", Offset = "0x6DA48C0", VA = "0x186DA54C0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong IKFPPCMIGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2BE0", Offset = "0x6DA1FE0", VA = "0x186DA2BE0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2910", Offset = "0x6DA1D10", VA = "0x186DA2910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong OBOLGJNKADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2C20", Offset = "0x6DA2020", VA = "0x186DA2C20")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2950", Offset = "0x6DA1D50", VA = "0x186DA2950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA2740", Offset = "0x6DA1B40", VA = "0x186DA2740")]
	public static ComputeBuffer ANJEPJLHJHG(int GMOPHNCDIJO, int EOIAAFMOOCO, ComputeBufferType EKNPHEPNHJD, [Out] DHDFMEHDMBJ DOBBMOLDHPN, ComputeBufferMode CFINOJHBLLF = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA23A0", Offset = "0x6DA17A0", VA = "0x186DA23A0")]
	public static RenderTexture ANJEPJLHJHG(int NDMBEPDJGMF, int ALKBDMCODNI, int MDHHIGJJBOH, RenderTextureFormat BEMIADMLHDO, [Out] DHDFMEHDMBJ DOBBMOLDHPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2C45750", Offset = "0x2C44B50", VA = "0x182C45750")]
	public static NativeArray<T> EPMMGALHODH<T>(NativeArray<T> NPHDACFOFLD, ulong LGPCCHEOHGO, [Out] DHDFMEHDMBJ DOBBMOLDHPN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2C45690", Offset = "0x2C44A90", VA = "0x182C45690")]
	public static NativeArray<T> ANJEPJLHJHG<T>(int LGPCCHEOHGO, Allocator DBCOPEDFGJL, [Out] DHDFMEHDMBJ DOBBMOLDHPN, NativeArrayOptions POLCFNEEHMO = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6DA2990", Offset = "0x6DA1D90", VA = "0x186DA2990")]
	public static void GGKFCAFBJMN(DHDFMEHDMBJ NPHDACFOFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6DA2AD0", Offset = "0x6DA1ED0", VA = "0x186DA2AD0")]
	public static uint HGMHNKNFCPK(RenderTextureFormat BEMIADMLHDO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GNKIEHIGJHI : KJICPJOCNAH<ODIPMBLFPNH, ODIPMBLFPNH>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct CFGGIIKDLLC : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> MDNHAKJDLFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> JKCDHEIGGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> MOHHOCAONJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> OCNGMEKHGFP;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2CD0", Offset = "0x6DA20D0", VA = "0x186DA2CD0")]
		public CFGGIIKDLLC(NativeArray<int> OEKBBACMJKE, NativeArray<float> CGODMHLKMMD, NativeArray<float4x4> OCCKIHFCDNA, NativeArray<float4> JFAKGDFLLLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2D00", Offset = "0x6DA2100", VA = "0x186DA2D00", Slot = "4")]
		public void Execute(int OBFJPFHENMC, TransformAccess JGDFNKEDOMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct CBIIOKNENCM : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> MDNHAKJDLFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> LJBEOGAMFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> LAAFOELOOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<ODIPMBLFPNH> BKIJJIPOKEB;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2CD0", Offset = "0x6DA20D0", VA = "0x186DA2CD0")]
		public CBIIOKNENCM(NativeArray<int> OEKBBACMJKE, NativeArray<float4x4> IMGPOAHPFJO, NativeArray<float4> ILCFHHGEBGM, NativeArray<ODIPMBLFPNH> AMPDFCKEJKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2C60", Offset = "0x6DA2060", VA = "0x186DA2C60", Slot = "4")]
		public void Execute(int OBFJPFHENMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte IOOPLBHAEHE = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray DJIANAPKPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> DEFADBFOKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> GFBHBJDLCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> EKLBCICIFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> PMNADEDJLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> AOGFCMELAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private DHDFMEHDMBJ PJEDFJEFIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private DHDFMEHDMBJ MHHGHHNGJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private DHDFMEHDMBJ FBOHBNGGFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private DHDFMEHDMBJ HKLGAFPEIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private DHDFMEHDMBJ AIBLKIKIADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform IIFPAKMMPHF;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE590", Offset = "0x6DAD990", VA = "0x186DAE590")]
	public GNKIEHIGJHI(int IIKBHDMNEGE, int BCDOPIAAPDG, ComputeShader JAPHKDOHBMF, int HKLJMIFLIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6DADF30", Offset = "0x6DAD330", VA = "0x186DADF30", Slot = "6")]
	protected override void DAKPINCAHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE420", Offset = "0x6DAD820", VA = "0x186DAE420")]
	private void OPKBHOFKAPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE2C0", Offset = "0x6DAD6C0", VA = "0x186DAE2C0")]
	public bool JOBAHHFGAFP(GJFBHOEOJMK DOBBMOLDHPN, Transform JGDFNKEDOMO, float PCMOILEJDKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE1E0", Offset = "0x6DAD5E0", VA = "0x186DAE1E0")]
	public void FLNDMHDCOLA(GJFBHOEOJMK DOBBMOLDHPN, float PCMOILEJDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE4E0", Offset = "0x6DAD8E0", VA = "0x186DAE4E0")]
	public void PGAGBGLFPEA(GJFBHOEOJMK DOBBMOLDHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE140", Offset = "0x6DAD540", VA = "0x186DAE140", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DPEFIAEDLKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KMIFCNHLIKA KFLFGPBPNBL();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface OCKIBPJBEBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 HGDNNNGCFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int BAINBALNHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int CGHKBDLAPID
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> NOBECIHIBBE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> GIMIAIDDGOD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> CMIHMCEKIPP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> EJDCLFFEDIK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> MDIFKLKOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> IDIAOOGAHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int ICNMFEKGFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int FDIBFNEIANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int DNGPKGHCJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool DOEKALKDELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MKMAAKCFANM();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OCNMPFIFBEJ : OCKIBPJBEBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private DPEFIAEDLKD IBNMMOMGMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private KMIFCNHLIKA OHLMFEKEKFF;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 HGDNNNGCFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAE8210", Offset = "0xAE7610", VA = "0x180AE8210", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAE8120", Offset = "0xAE7520", VA = "0x180AE8120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool JIHGELOHJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8A1FA0", Offset = "0x8A13A0", VA = "0x1808A1FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int BAINBALNHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7A0", Offset = "0x8DABA0", VA = "0x1808DB7A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8DADA0", Offset = "0x8DA1A0", VA = "0x1808DADA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int CGHKBDLAPID
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8A6040", Offset = "0x8A5440", VA = "0x1808A6040", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8A6050", Offset = "0x8A5450", VA = "0x1808A6050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int PCFEOOJACHK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xE917E0", Offset = "0xE90BE0", VA = "0x180E917E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> NOBECIHIBBE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1710", Offset = "0x6DB0B10", VA = "0x186DB1710", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> GIMIAIDDGOD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1580", Offset = "0x6DB0980", VA = "0x186DB1580", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> CMIHMCEKIPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1780", Offset = "0x6DB0B80", VA = "0x186DB1780", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> EJDCLFFEDIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6DB14F0", Offset = "0x6DB08F0", VA = "0x186DB14F0", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> MDIFKLKOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6DB16E0", Offset = "0x6DB0AE0", VA = "0x186DB16E0", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> IDIAOOGAHAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6DB14C0", Offset = "0x6DB08C0", VA = "0x186DB14C0", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DOEKALKDELP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x953920", Offset = "0x952D20", VA = "0x180953920", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x94E700", Offset = "0x94DB00", VA = "0x18094E700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int ICNMFEKGFMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6DB15B0", Offset = "0x6DB09B0", VA = "0x186DB15B0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int FDIBFNEIANE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1560", Offset = "0x6DB0960", VA = "0x186DB1560", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int DNGPKGHCJIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1410", Offset = "0x6DB0810", VA = "0x186DB1410", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6DB17B0", Offset = "0x6DB0BB0", VA = "0x186DB17B0")]
	public OCNMPFIFBEJ(Hash128 KOJHIJJELLP, DPEFIAEDLKD IBNMMOMGMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6DB15C0", Offset = "0x6DB09C0", VA = "0x186DB15C0", Slot = "16")]
	public void MKMAAKCFANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1430", Offset = "0x6DB0830", VA = "0x186DB1430", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct GJFBHOEOJMK : IEquatable<GJFBHOEOJMK>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly GJFBHOEOJMK EPPAKPACCLK;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int DIJEOHGLGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x974190", Offset = "0x973590", VA = "0x180974190")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xC8A120", Offset = "0xC89520", VA = "0x180C8A120")]
	public GJFBHOEOJMK(int OBFJPFHENMC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6DACB40", Offset = "0x6DABF40", VA = "0x186DACB40", Slot = "4")]
	public bool Equals(GJFBHOEOJMK OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6DACA70", Offset = "0x6DABE70", VA = "0x186DACA70", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6DACB90", Offset = "0x6DABF90", VA = "0x186DACB90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DHHFIFCDOAL : GPEKDJHKMLB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool HJPOGLGLBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private OCKIBPJBEBF OMAOEGCGLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<GJFBHOEOJMK> PAFKLDKCJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<GJFBHOEOJMK> NABMEKBDBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<GJFBHOEOJMK> NDODDDHGNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> CBAHOFDDPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int JJMBBDFCOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int HPGKMCIBAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int DHCILLHDAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int NKFLKHIDNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int LCOMNKAFFBD;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int DIJEOHGLGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6DA47A0", Offset = "0x6DA3BA0", VA = "0x186DA47A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3530", Offset = "0x6DA2930", VA = "0x186DA3530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool KIFHHOAHNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x931420", Offset = "0x930820", VA = "0x180931420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x992330", Offset = "0x991730", VA = "0x180992330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool AOEGMOPOGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xEA3F30", Offset = "0xEA3330", VA = "0x180EA3F30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xEA3F40", Offset = "0xEA3340", VA = "0x180EA3F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool BADJNMJHJOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool PFAKIKACPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4E7ABE0", Offset = "0x4E79FE0", VA = "0x184E7ABE0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1E2ADF0", Offset = "0x1E2A1F0", VA = "0x181E2ADF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float IDPEIFKOIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA6FBD0", Offset = "0xA6EFD0", VA = "0x180A6FBD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA6FBA0", Offset = "0xA6EFA0", VA = "0x180A6FBA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4B10", Offset = "0x6DA3F10", VA = "0x186DA4B10")]
	public DHHFIFCDOAL(OCKIBPJBEBF OHLMFEKEKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4030", Offset = "0x6DA3430", VA = "0x186DA4030")]
	private void IAEIFBMLHEP(OCKIBPJBEBF OHLMFEKEKFF, int JJMBBDFCOFB, int DLDHLFKOALO, int OBFJPFHENMC, int JGEGGBLOELP, AOIFBBPGOOL EIFGKHNPLEK, float DPLNDIKFABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4850", Offset = "0x6DA3C50", VA = "0x186DA4850")]
	private void MGOOMJKNBLM(OCKIBPJBEBF OHLMFEKEKFF, int MPDFAOAPMBP, int OBFJPFHENMC, uint3 DKEADFJKFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4500", Offset = "0x6DA3900", VA = "0x186DA4500")]
	private bool JPLFLMBDFEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6DA3650", Offset = "0x6DA2A50", VA = "0x186DA3650", Slot = "4")]
	public bool FNBCENOGBNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6DA3570", Offset = "0x6DA2970", VA = "0x186DA3570", Slot = "5")]
	public bool DPCLJOJLMCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6DA2EC0", Offset = "0x6DA22C0", VA = "0x186DA2EC0", Slot = "6")]
	public void BIJNEFLCHFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6DA35F0", Offset = "0x6DA29F0", VA = "0x186DA35F0")]
	public void EOKFOKNBODF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6DA35F0", Offset = "0x6DA29F0", VA = "0x186DA35F0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GPEKDJHKMLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool BADJNMJHJOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool PFAKIKACPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FNBCENOGBNB();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DPCLJOJLMCI();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BIJNEFLCHFA();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JLPHNDGKKNO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float IPPGIFEBGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, DHHFIFCDOAL> GPIPMHFOCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, KMGBDAFEEMH> KMOCJLCDECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<GPEKDJHKMLB> KDHBKPIMOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<GPEKDJHKMLB> EHPEPIMNPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<GPEKDJHKMLB> EFNHFHLCBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int CFJOGIHKGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int MBJAFNFEICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float LBCPNFHOOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool DECJOAKIJKL;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool MOIJKMNLEGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1112280", Offset = "0x1111680", VA = "0x181112280")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x11344A0", Offset = "0x11338A0", VA = "0x1811344A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool NJHBOAGDODN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEEF0", Offset = "0x6DAE2F0", VA = "0x186DAEEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string GKDMMGCFKGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEF70", Offset = "0x6DAE370", VA = "0x186DAEF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEF40", Offset = "0x6DAE340", VA = "0x186DAEF40")]
	public void EONINDKJBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEDD0", Offset = "0x6DAE1D0", VA = "0x186DAEDD0")]
	public void COLNPDIAEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF9D0", Offset = "0x6DAEDD0", VA = "0x186DAF9D0")]
	public JLPHNDGKKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB60", Offset = "0x6DADF60", VA = "0x186DAEB60")]
	public GJNDKOFHCJC CIGOIKFLIDO(NDMKCKGBGIP NAEMIMNOMOI, bool MEJHLOBHJCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEC90", Offset = "0x6DAE090", VA = "0x186DAEC90")]
	public KMGBDAFEEMH CIGOIKFLIDO(PHOIODCGCJJ JAEJMKKLMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF310", Offset = "0x6DAE710", VA = "0x186DAF310")]
	public bool ILDLCLOGNPG(Hash128 HDCHKIOFILD, [Out] DHHFIFCDOAL EDMBAOELCAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE870", Offset = "0x6DADC70", VA = "0x186DAE870")]
	public DHHFIFCDOAL CIGOIKFLIDO(OCKIBPJBEBF OHLMFEKEKFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEF50", Offset = "0x6DAE350", VA = "0x186DAEF50")]
	private void GPHEDGILEOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF900", Offset = "0x6DAED00", VA = "0x186DAF900")]
	private bool MOEDLHIGNBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF430", Offset = "0x6DAE830", VA = "0x186DAF430")]
	public void MKMAAKCFANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEDE0", Offset = "0x6DAE1E0", VA = "0x186DAEDE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF380", Offset = "0x6DAE780", VA = "0x186DAF380")]
	public void KKHABALCONI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KLBHKBJPBBO : KJICPJOCNAH<NJJKDNJBMBN, NJJKDNJBMBN>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFBD0", Offset = "0x6DAEFD0", VA = "0x186DAFBD0")]
	public KLBHKBJPBBO(int IIKBHDMNEGE, int BCDOPIAAPDG, ComputeShader JAPHKDOHBMF, int HKLJMIFLIDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NLEIHGDCEDJ : KJICPJOCNAH<NJKFJEAIICG, NJKFJEAIICG>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1320", Offset = "0x6DB0720", VA = "0x186DB1320")]
	public NLEIHGDCEDJ(int IIKBHDMNEGE, int BCDOPIAAPDG, ComputeShader JAPHKDOHBMF, int HKLJMIFLIDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FAKHOHLCFBC : KJICPJOCNAH<MJKFHLLABNO, MJKFHLLABNO>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6DAC800", Offset = "0x6DABC00", VA = "0x186DAC800")]
	public FAKHOHLCFBC(int IIKBHDMNEGE, int BCDOPIAAPDG, ComputeShader JAPHKDOHBMF, int HKLJMIFLIDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class MPLCFCDEPIM : KJICPJOCNAH<CKEHCAEDNBC, CBADONOAOJM>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0F10", Offset = "0x6DB0310", VA = "0x186DB0F10")]
	public MPLCFCDEPIM(int IIKBHDMNEGE, int BCDOPIAAPDG, ComputeShader JAPHKDOHBMF, int HKLJMIFLIDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KPJEICHCDEE : KJICPJOCNAH<DICIKOAJENN, DICIKOAJENN>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0370", Offset = "0x6DAF770", VA = "0x186DB0370")]
	public KPJEICHCDEE(int IIKBHDMNEGE, int BCDOPIAAPDG, ComputeShader JAPHKDOHBMF, int HKLJMIFLIDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class DOBACKFJEJM : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private EGNJJMFPCMM HJMICNAMMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool FCINDJJJBNF;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool EKBHPCGDOOO;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6DA5480", Offset = "0x6DA4880", VA = "0x186DA5480")]
	public DOBACKFJEJM(EGNJJMFPCMM OGMNKGPOGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6DA52F0", Offset = "0x6DA46F0", VA = "0x186DA52F0", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer HILAPBJMMLJ, RenderingData FNJDAPBBICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6DA5080", Offset = "0x6DA4480", VA = "0x186DA5080", Slot = "6")]
	public override void Configure(CommandBuffer HILAPBJMMLJ, RenderTextureDescriptor PGIEDNCCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6DA50C0", Offset = "0x6DA44C0", VA = "0x186DA50C0", Slot = "9")]
	public override void Execute(ScriptableRenderContext EPLPPJHJIIM, RenderingData FNJDAPBBICC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class OHKAIPHMKAO
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct GHFKKBLOHGC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string ACDGEPBIBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer HILAPBJMMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext EPLPPJHJIIM;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6DAC960", Offset = "0x6DABD60", VA = "0x186DAC960")]
		public GHFKKBLOHGC(string AFPGDPAIPPK, ScriptableRenderContext APDMONBOMLO, [Out] CommandBuffer AEIJPOCPCOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6DAC8B0", Offset = "0x6DABCB0", VA = "0x186DAC8B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1D40", Offset = "0x6DB1140", VA = "0x186DB1D40")]
	public static bool PKCLGPKMHLM(RenderingData FNJDAPBBICC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1BA0", Offset = "0x6DB0FA0", VA = "0x186DB1BA0")]
	public static void LNAMEEPJPHI(CommandBuffer HILAPBJMMLJ, ScriptableRenderContext EPLPPJHJIIM, ShadowDrawingSettings EDLDEBINPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1970", Offset = "0x6DB0D70", VA = "0x186DB1970")]
	public static void GGDOKELOLOK(CommandBuffer HILAPBJMMLJ, ScriptableRenderContext EPLPPJHJIIM, RenderingData FNJDAPBBICC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EGNJJMFPCMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class LHKGEIHOCPG
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int GKJIJJGKPHH;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int KLOPPMABMJE;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static ENPKCAIJANN<PFHEFKAEOAK> CFAADLHFBJB;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static ENPKCAIJANN<uint> BOJBAMCMJPB;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static DHDFMEHDMBJ FLPGCNNFLJG;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer ELBCBIADDAH;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<EGLAONKBOHD> GNHLLANFGKN;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int GCNOODHKIJK;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int FBOEMFNONLB;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int FPOLFACCJKN;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int HDKNFMLFLKC;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] OMIABLKPABD;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] JGKOMFLCBCA;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static KLAJKANIFFH[][] KPCAMECIMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] BBEGNPDCELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int IDHIACDKEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int BGELBMIHGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int NAEDNGBAFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int ABKKMOIBHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int OGMBFPJEACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int PBCACCGDPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int ACMFACKHIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int FOBGOLCJPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int HMDGPEKBAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int LGNFHBGGNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int ODKCIMDAENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int PIHKHHHDDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int HIPNJDALEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int JIIDKPNNNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int GPNDNKEJIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int LEIIGJEKMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int OJOHNJLCPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int DFMDBBDAJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] DJNDBMCMBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private JLPHNDGKKNO FEOKNBGCLBH;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool LNNGIFMHNDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6DAB750", Offset = "0x6DAAB50", VA = "0x186DAB750")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6DA8EA0", Offset = "0x6DA82A0", VA = "0x186DA8EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool AAFLIGIDBFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6DAB7A0", Offset = "0x6DAABA0", VA = "0x186DAB7A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6DA5FC0", Offset = "0x6DA53C0", VA = "0x186DA5FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData EELMKJIGLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6DAB7F0", Offset = "0x6DAABF0", VA = "0x186DAB7F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6DA6B40", Offset = "0x6DA5F40", VA = "0x186DA6B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static GNKIEHIGJHI MBIDHOBAABK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9DA0", Offset = "0x6DA91A0", VA = "0x186DA9DA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6DAA010", Offset = "0x6DA9410", VA = "0x186DAA010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static KLBHKBJPBBO BIMKCPPFDOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7640", Offset = "0x6DA6A40", VA = "0x186DA7640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6DA77C0", Offset = "0x6DA6BC0", VA = "0x186DA77C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static NLEIHGDCEDJ OGBLICIDAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9D50", Offset = "0x6DA9150", VA = "0x186DA9D50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6DA5590", Offset = "0x6DA4990", VA = "0x186DA5590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static FAKHOHLCFBC MMFAHNJGNJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6DA76F0", Offset = "0x6DA6AF0", VA = "0x186DA76F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6DA6AD0", Offset = "0x6DA5ED0", VA = "0x186DA6AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static MPLCFCDEPIM LCJDNKNFBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6DA5F60", Offset = "0x6DA5360", VA = "0x186DA5F60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7740", Offset = "0x6DA6B40", VA = "0x186DA7740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static KPJEICHCDEE ODGLAOCONEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6DA5780", Offset = "0x6DA4B80", VA = "0x186DA5780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6DA5600", Offset = "0x6DA4A00", VA = "0x186DA5600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material KIJMDFFFJEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6DA8D50", Offset = "0x6DA8150", VA = "0x186DA8D50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6DA5680", Offset = "0x6DA4A80", VA = "0x186DA5680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material KCBOBEIPLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6DA95C0", Offset = "0x6DA89C0", VA = "0x186DA95C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6DA5700", Offset = "0x6DA4B00", VA = "0x186DA5700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material JIOGAGKOPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6DA65E0", Offset = "0x6DA59E0", VA = "0x186DA65E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9F90", Offset = "0x6DA9390", VA = "0x186DA9F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material CEBOGIGEJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9F30", Offset = "0x6DA9330", VA = "0x186DA9F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6DA75C0", Offset = "0x6DA69C0", VA = "0x186DA75C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool EOKDAFEFJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6DA8850", Offset = "0x6DA7C50", VA = "0x186DA8850")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9620", Offset = "0x6DA8A20", VA = "0x186DA9620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool NJHBOAGDODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7690", Offset = "0x6DA6A90", VA = "0x186DA7690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string GKDMMGCFKGC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6DA8F00", Offset = "0x6DA8300", VA = "0x186DA8F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6DAC5A0", Offset = "0x6DAB9A0", VA = "0x186DAC5A0")]
	internal EGNJJMFPCMM([Optional] MClusterData NCBHIIOMJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6DAA3A0", Offset = "0x6DA97A0", VA = "0x186DAA3A0")]
	public void NOCOEJHJFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9E90", Offset = "0x6DA9290", VA = "0x186DA9E90")]
	public void LDNOEFDCJLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA6AC0", Offset = "0x6DA5EC0", VA = "0x186DA6AC0")]
	public void CJCAAHNNIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9DF0", Offset = "0x6DA91F0", VA = "0x186DA9DF0")]
	public bool LBKKABMOEHL(Hash128 KOJHIJJELLP, [Out] DHHFIFCDOAL OHLMFEKEKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6DA6800", Offset = "0x6DA5C00", VA = "0x186DA6800")]
	public DHHFIFCDOAL CIGOIKFLIDO(OCKIBPJBEBF EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6DA68C0", Offset = "0x6DA5CC0", VA = "0x186DA68C0")]
	public KMGBDAFEEMH CIGOIKFLIDO(PHOIODCGCJJ JAEJMKKLMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6DA6640", Offset = "0x6DA5A40", VA = "0x186DA6640")]
	public GJNDKOFHCJC CIGOIKFLIDO(NDMKCKGBGIP NAEMIMNOMOI, bool MEJHLOBHJCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6DA5F10", Offset = "0x6DA5310", VA = "0x186DA5F10")]
	public void BIJNEFLCHFA(GPEKDJHKMLB MMGNDBIPIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8DB0", Offset = "0x6DA81B0", VA = "0x186DA8DB0")]
	public static void HPHFJHNBFMJ(PDIOLNLFKIH BOJMNCJMGLC, KLAJKANIFFH[] EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6DA6BB0", Offset = "0x6DA5FB0", VA = "0x186DA6BB0")]
	private void DMHADDCAPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6DAB840", Offset = "0x6DAAC40", VA = "0x186DAB840")]
	private static void PALHNOMELGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6DAA080", Offset = "0x6DA9480", VA = "0x186DAA080")]
	public void NDEBPJLEANE(CommandBuffer HILAPBJMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6DA5D40", Offset = "0x6DA5140", VA = "0x186DA5D40")]
	public void BGIGNHLHJIE([Optional] ScriptableRenderContext? EPLPPJHJIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6DA6300", Offset = "0x6DA5700", VA = "0x186DA6300")]
	public void BOMDDDPMIIN(CommandBuffer HILAPBJMMLJ, ShadowSplitData EEFFJBECCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6DA6020", Offset = "0x6DA5420", VA = "0x186DA6020")]
	public void BOMDDDPMIIN(CommandBuffer HILAPBJMMLJ, CameraData JHPIJPECNNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6DA57E0", Offset = "0x6DA4BE0", VA = "0x186DA57E0")]
	public void ANIHJFOEEGL(CommandBuffer HILAPBJMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6DA87E0", Offset = "0x6DA7BE0", VA = "0x186DA87E0")]
	public void GODMAKNCFGK(CommandBuffer HILAPBJMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA88B0", Offset = "0x6DA7CB0", VA = "0x186DA88B0")]
	public void HGGACPENCOM(CommandBuffer HILAPBJMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9680", Offset = "0x6DA8A80", VA = "0x186DA9680")]
	public void JKKDFEKCONG(CommandBuffer HILAPBJMMLJ, PDIOLNLFKIH OHHFPIMDCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9C70", Offset = "0x6DA9070", VA = "0x186DA9C70")]
	public void KHPJJEPBLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6DA7830", Offset = "0x6DA6C30", VA = "0x186DA7830")]
	public void GGKFCAFBJMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6DA74B0", Offset = "0x6DA68B0", VA = "0x186DA74B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class PHLMKILCEJH
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x21D34A0", Offset = "0x21D28A0", VA = "0x1821D34A0")]
	public static int DBHOPKLNJDB(int CLDPBDGHEDO, int NGHIFAEAMKJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct ODIPMBLFPNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 ELNDMIDLDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 DPPFLPLKABG;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly ODIPMBLFPNH KJENGACCGJP;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly ODIPMBLFPNH EPPAKPACCLK;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x45C22E0", Offset = "0x45C16E0", VA = "0x1845C22E0")]
	public ODIPMBLFPNH(float4x4 EKJFINLPFIK, float4 BGIOEFGAEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1800", Offset = "0x6DB0C00", VA = "0x186DB1800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct AOIFBBPGOOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 OGKCMCMHLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 HAGCLANLPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 DDAAOLNLDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 FNKBINDAHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 ONJJMBGFOOJ;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct KADFGJDPFNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 OGKCMCMHLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 HAGCLANLPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 DDAAOLNLDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 FNKBINDAHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 ONJJMBGFOOJ;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct CBADONOAOJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public KADFGJDPFNK OGLOIALGGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public KADFGJDPFNK IOINNBPPGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public KADFGJDPFNK CINAICHIBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public KADFGJDPFNK BLJCMPCCHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public KADFGJDPFNK GMMMJHOOHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public KADFGJDPFNK GCJKDNPIKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public KADFGJDPFNK GGLCPPGGPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public KADFGJDPFNK MKMEGCEMJHD;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct CKEHCAEDNBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public AOIFBBPGOOL OGLOIALGGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public AOIFBBPGOOL IOINNBPPGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public AOIFBBPGOOL CINAICHIBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public AOIFBBPGOOL BLJCMPCCHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public AOIFBBPGOOL GMMMJHOOHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public AOIFBBPGOOL GCJKDNPIKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public AOIFBBPGOOL GGLCPPGGPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public AOIFBBPGOOL MKMEGCEMJHD;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct NJKFJEAIICG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 IDKEBOPMKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint CLLDAMEIGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint NBFPJBGNDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float JMMMLKJPEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint BBBPBFDGLIH;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6DB12F0", Offset = "0x6DB06F0", VA = "0x186DB12F0")]
	public NJKFJEAIICG(PHOIODCGCJJ JAEJMKKLMIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct PFHEFKAEOAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint GABEPBBNBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint KKKKPMCDDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint JGEGGBLOELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint BBBPBFDGLIH;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2580", Offset = "0x6DB1980", VA = "0x186DB2580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct MJKFHLLABNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint DLDHLFKOALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint HHBOMPIPEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint HPGKMCIBAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint BBBPBFDGLIH;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0E60", Offset = "0x6DB0260", VA = "0x186DB0E60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct NJJKDNJBMBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint OHMEIOBLAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint LPLGBFHKGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint NEEFGNDAGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint IEAOCBDFFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint MNNDADDOHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint GGPHDIANEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint MHMINAGJBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint BBBPBFDGLIH;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0FC0", Offset = "0x6DB03C0", VA = "0x186DB0FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct DICIKOAJENN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 IAEOOOFIDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 DFKNHAKKIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 BPJEDEAAPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 DAENCBOKKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 GAPMDLLHNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 HOLIPHCGBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 DECNJIFJFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 AGIMACNJKFG;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4C80", Offset = "0x6DA4080", VA = "0x186DA4C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum PDIOLNLFKIH
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
