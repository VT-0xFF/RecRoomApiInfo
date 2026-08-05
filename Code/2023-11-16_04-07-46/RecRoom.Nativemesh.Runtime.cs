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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HBNJGGMHNLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int CLNFFPPEOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 LHCKIPMDOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion CEPGDHPMOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 JJMPHDEIKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int KKDJAMMHCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int IHLMLKJIBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int HMBEIEABOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float MMMJDOCEFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 ACBAFDPFMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool IPNNDGAMJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public BJLNIDGLICL IJJLNBOGLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 GGBIPKDLEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float MAILJKAMAOA;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MKNGMLEHKNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static DCOALNMPKOI BJKGJKJNOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<HBNJGGMHNLJ> EEEAAMAHOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<IGFIKMFJMMO> ACBMAIOACAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<GIJHGFHNGKI> BHIHIJFKFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<GOFJDACHAIO> LNNPGEONJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<IGFIKMFJMMO> NNBMGCPKIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<DFBDCAFFOGB> LMBBKGOOPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<GOFJDACHAIO>> DEMOLLFIHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<CHNCAHOPNCO> KKPMGPEKBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> EEGKGPPMJCM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GCEFKOJKPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB64770", Offset = "0xB63770", VA = "0x180B64770")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB63C80", Offset = "0xB62C80", VA = "0x180B63C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LMIBGJEGPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB64780", Offset = "0xB63780", VA = "0x180B64780")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB63DE0", Offset = "0xB62DE0", VA = "0x180B63DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E42250", Offset = "0x5E41250", VA = "0x185E42250")]
	public MKNGMLEHKNN(int NPFNDJDPBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E40700", Offset = "0x5E3F700", VA = "0x185E40700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E41E60", Offset = "0x5E40E60", VA = "0x185E41E60")]
	public void NIDAGEDDLKC(JobHandle KHPBICCBDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E42030", Offset = "0x5E41030", VA = "0x185E42030")]
	public void OOBIHEEMCDI(HBNJGGMHNLJ FCLEEDACIMH, CHNCAHOPNCO FAEJDDIBNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E41D20", Offset = "0x5E40D20", VA = "0x185E41D20")]
	public void NCFBNOKLJED(GIJHGFHNGKI FCLEEDACIMH, NativeArray<GOFJDACHAIO> ABGHAJDCGHP, int AIAOEMFDGOE, int CMHFLEIFIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E40A60", Offset = "0x5E3FA60", VA = "0x185E40A60")]
	public JobHandle MEJFHGFHNHP(KPDLEIFKJLD MLCKPINMKPA, DPCCFMGPGIJ DMKFKGJBHIF, float3 FCKCKJHNHGI, quaternion AGMADACPBHG, float GOJGPNNEPHC, bool KIEFNKIJOBB, int FIHBGCDEOCI = 0, int IGKKCPAEKEE = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E40720", Offset = "0x5E3F720", VA = "0x185E40720")]
	public static JobHandle LPCDMCFIPAG(LMDLDIAMBIO LBFDBFKAMIJ, KPDLEIFKJLD MLCKPINMKPA, HBNJGGMHNLJ FCLEEDACIMH, JobHandle KHPBICCBDEG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E41A70", Offset = "0x5E40A70", VA = "0x185E41A70")]
	public static JobHandle MNONLGDPIGI(LCDOPJEMFME LBFDBFKAMIJ, KPDLEIFKJLD MLCKPINMKPA, GIJHGFHNGKI FCLEEDACIMH, NativeArray<GOFJDACHAIO> ABGHAJDCGHP, int AIAOEMFDGOE, int CMHFLEIFIHN, JobHandle KHPBICCBDEG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct BACCNIDAKOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 LHJLBNLNFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 EBJBCGNMBBB;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OFFJKADONPJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<BACCNIDAKOF> JHAIAELMPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> IFIOBBGKBJC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GCEFKOJKPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x775DA0", Offset = "0x774DA0", VA = "0x180775DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LMIBGJEGPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7786E0", Offset = "0x7776E0", VA = "0x1807786E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5E448D0", Offset = "0x5E438D0", VA = "0x185E448D0")]
	public OFFJKADONPJ(int DOHOPADJJJH, int CBCODDJCNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E44790", Offset = "0x5E43790", VA = "0x185E44790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E447F0", Offset = "0x5E437F0", VA = "0x185E447F0")]
	public void NMIAHBPIICO(OFFJKADONPJ HPOMAIIHGIF, int LPGDAEGGCMH, int HOLHNBPNHFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BFMNBFJDEDO
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static OFFJKADONPJ EFEGFALHMOL;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<IGFIKMFJMMO> DCMKOHOJIOE;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static int[] JGLPFFBALEK;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static bool EIFIJEHOGEJ;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static Dictionary<int, OFFJKADONPJ> MLLHNDCFAPM;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, OFFJKADONPJ> NNJMEEIAFCE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool FBOGKBJPBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E37090", Offset = "0x5E36090", VA = "0x185E37090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<IGFIKMFJMMO> HECMKANELAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E37250", Offset = "0x5E36250", VA = "0x185E37250")]
		get
		{
			return default(NativeList<IGFIKMFJMMO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static OFFJKADONPJ AOJELHMPCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E36FF0", Offset = "0x5E35FF0", VA = "0x185E36FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E36260", Offset = "0x5E35260", VA = "0x185E36260")]
	private static void BBDMKLFDOPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E37110", Offset = "0x5E36110", VA = "0x185E37110")]
	public static int KOMFKNNNJMF(bool NLOBODLCLMP, int GMACJGBNCDM, bool BAGFDJDLEMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E37310", Offset = "0x5E36310", VA = "0x185E37310")]
	private static int ODBAFPAIKPO(int GMACJGBNCDM, bool AHFHGOMIIFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E37140", Offset = "0x5E36140", VA = "0x185E37140")]
	private static int LFIPIINBKGA(int GMACJGBNCDM, bool AHFHGOMIIFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E36B90", Offset = "0x5E35B90", VA = "0x185E36B90")]
	public static int EIBOCCNMEFK(int KBODLDDGOHA, int GMACJGBNCDM, int GDAIHFANKBJ, bool AHFHGOMIIFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E36870", Offset = "0x5E35870", VA = "0x185E36870")]
	public static int DIBNILBHKAC(int KBODLDDGOHA, int GMACJGBNCDM, int GDAIHFANKBJ, bool AHFHGOMIIFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E37240", Offset = "0x5E36240", VA = "0x185E37240")]
	public static int NEJFEHEFJIG(int GDAIHFANKBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E37740", Offset = "0x5E36740", VA = "0x185E37740")]
	private static int PCPCOAICDHK(int GMACJGBNCDM, bool AHFHGOMIIFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E360E0", Offset = "0x5E350E0", VA = "0x185E360E0")]
	private static int ADBPOGCCLKA(int GMACJGBNCDM, bool AHFHGOMIIFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E36100", Offset = "0x5E35100", VA = "0x185E36100")]
	public static int AFFCMHCOACM(int KBODLDDGOHA, int GMACJGBNCDM, int GDAIHFANKBJ, bool AHFHGOMIIFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E36C20", Offset = "0x5E35C20", VA = "0x185E36C20")]
	public static int FKIDPDOBMNG(int KBODLDDGOHA, int GMACJGBNCDM, int GDAIHFANKBJ, bool AHFHGOMIIFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E372F0", Offset = "0x5E362F0", VA = "0x185E372F0")]
	public static int NKFGHICPCOP(int GDAIHFANKBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E37150", Offset = "0x5E36150", VA = "0x185E37150")]
	public static OFFJKADONPJ MAPLAFHAPCK(int GMACJGBNCDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E36900", Offset = "0x5E35900", VA = "0x185E36900")]
	private static OFFJKADONPJ DJINAKHMOOF(int GMACJGBNCDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E36170", Offset = "0x5E35170", VA = "0x185E36170")]
	public static OFFJKADONPJ AJLCKPICBNI(int GMACJGBNCDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E36CB0", Offset = "0x5E35CB0", VA = "0x185E36CB0")]
	private static OFFJKADONPJ GCANIEEGKIP(int GMACJGBNCDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E37330", Offset = "0x5E36330", VA = "0x185E37330")]
	public static void OJJIFMENIIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct GIJHGFHNGKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int GOIFGFHNMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 LHCKIPMDOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public quaternion CEPGDHPMOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float JJMPHDEIKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float ONMFLIPFAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int KKDJAMMHCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int IHLMLKJIBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int HMBEIEABOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public bool PPJFPIOGMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool MGLAIDGLJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float MMMJDOCEFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float3 ACBAFDPFMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool JNBDNHAEFBJ;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DFBDCAFFOGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int NIOBFHKJPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int FHHGLLNDKID;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LCDOPJEMFME : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<GIJHGFHNGKI> NFOGAOPGPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<GOFJDACHAIO> KFMOBPBDPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<IGFIKMFJMMO> ELPFEMKJLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<DFBDCAFFOGB> MLPADEAAOKE;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E40440", Offset = "0x5E3F440", VA = "0x185E40440")]
	public LCDOPJEMFME(NativeArray<GOFJDACHAIO> KFMOBPBDPLL, int LHAIIFMNPNK = 1, Allocator OIPBEAGANJF = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E40350", Offset = "0x5E3F350", VA = "0x185E40350", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BurstCompile]
public struct DLINJNKPIIB : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<BACCNIDAKOF> JHLPADMMEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> NHLLCAPLOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<IGFIKMFJMMO> FOLAPNAJKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<GIJHGFHNGKI> NFOGAOPGPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<GOFJDACHAIO> KFMOBPBDPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<IGFIKMFJMMO> ELPFEMKJLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<DFBDCAFFOGB> MLPADEAAOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int LGJECOKDCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int GIFCPCGEFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float3 HJBACPDNCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion HCBOKDAHNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 FDHPKGEHLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EJBCNHFABKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> LIGEHBHCFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> MHPGGDBKLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> IDAMANCPGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> GOMINBGMHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> EKGIGMIJOFB;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D390", Offset = "0x5E3C390", VA = "0x185E3D390")]
	public DLINJNKPIIB(MKNGMLEHKNN LAGIDNDOBAK, KPDLEIFKJLD GBOGCBDPGCD, float3 FNILNLCAHMD, quaternion AMCKCBKBOIJ, float NMOPOCHHLJH, int FIHBGCDEOCI = 0, int IGKKCPAEKEE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D620", Offset = "0x5E3C620", VA = "0x185E3D620")]
	public DLINJNKPIIB(LCDOPJEMFME LAGIDNDOBAK, KPDLEIFKJLD GBOGCBDPGCD, float3 FNILNLCAHMD, quaternion AMCKCBKBOIJ, float3 NMOPOCHHLJH, int FIHBGCDEOCI = 0, int IGKKCPAEKEE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CA10", Offset = "0x5E3BA10", VA = "0x185E3CA10")]
	private float3 GMPGHBJAPCJ(float3 GKLENGMOKBD, Matrix4x4 NDOIHCONMPC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CB40", Offset = "0x5E3BB40", VA = "0x185E3CB40")]
	private float3x3 HNLBHKMPLKI(float3x3 BBDHDIGNFCM, float3x3 KPMINADJFEH)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CD30", Offset = "0x5E3BD30", VA = "0x185E3CD30")]
	private float LEPNMHMBDLP(float EKPAHLHAMGH, float OLAAPGODGBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B410", Offset = "0x5E3A410", VA = "0x185E3B410", Slot = "4")]
	public void Execute(int CPCIEIKHPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CBC0", Offset = "0x5E3BBC0", VA = "0x185E3CBC0")]
	private void KKHLAPKPLJD(int EJKPNGNHBHM, float3 LPGLCEHEHMC, float3 IPOPAPIAACP, float3 IMPPGGNEKEP, float PEBOEKHAPLP, bool AAEOFJCCIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C5B0", Offset = "0x5E3B5B0", VA = "0x185E3C5B0")]
	private void GJHIANGPIJF(GIJHGFHNGKI MDMLFJCANOJ, float3 BOJGOGFFKJG, float3x3 OPKOAAPHEFK, float EKPAHLHAMGH, int LGPGAABHJPK, int KDCIHMDGGEF, int KOEPOHCDPJD, float OPLDDBJOFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CD40", Offset = "0x5E3BD40", VA = "0x185E3CD40")]
	private void LHOIFNEMJBI(int EJKPNGNHBHM, int FNBONPPAFBB, GIJHGFHNGKI MDMLFJCANOJ, float3 BOJGOGFFKJG, float3x3 OPKOAAPHEFK, bool MOPCLBMCFAG, float EKPAHLHAMGH, int MFOJAGMHAKH, int NBBKMJBKAEP, int KOEPOHCDPJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct LMDLDIAMBIO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<HBNJGGMHNLJ> OGOEHOFMGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeList<IGFIKMFJMMO> LNILJCEEKLB;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5E40610", Offset = "0x5E3F610", VA = "0x185E40610")]
	public LMDLDIAMBIO(int LHAIIFMNPNK, Allocator OIPBEAGANJF = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E40570", Offset = "0x5E3F570", VA = "0x185E40570", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct NKJHLMLPLCJ : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private enum DHHLPGMDNIA
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
	private NativeList<float3> HHELMEMIFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float3> MIFMKPIPFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<int> KGCOHACHEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<int> FOEKJBCPJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> OAANAPKEBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<float4> KOPLLDLADJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeArray<float4> HKHEDECHCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<float3> OPBEAAPPGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<IGFIKMFJMMO> FFGEHFKPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private NativeList<HBNJGGMHNLJ> OGOEHOFMGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private NativeList<IGFIKMFJMMO> LNILJCEEKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private int LGJECOKDCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	private int GIFCPCGEFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EJBCNHFABKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> LIGEHBHCFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> MHPGGDBKLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> IDAMANCPGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> GOMINBGMHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> EKGIGMIJOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float3 FDHPKGEHLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private quaternion HCBOKDAHNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float3 HJBACPDNCDM;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5E443B0", Offset = "0x5E433B0", VA = "0x185E443B0")]
	public NKJHLMLPLCJ(MKNGMLEHKNN LAGIDNDOBAK, KPDLEIFKJLD GBOGCBDPGCD, float3 FNILNLCAHMD, quaternion AMCKCBKBOIJ, float NMOPOCHHLJH, int FIHBGCDEOCI = 0, int IGKKCPAEKEE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5E445A0", Offset = "0x5E435A0", VA = "0x185E445A0")]
	public NKJHLMLPLCJ(LMDLDIAMBIO FCLEEDACIMH, KPDLEIFKJLD GBOGCBDPGCD, float3 FNILNLCAHMD, quaternion AMCKCBKBOIJ, float3 NMOPOCHHLJH, int FIHBGCDEOCI = 0, int IGKKCPAEKEE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5E43350", Offset = "0x5E42350", VA = "0x185E43350", Slot = "4")]
	public void Execute(int CPCIEIKHPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5E42FA0", Offset = "0x5E41FA0", VA = "0x185E42FA0")]
	private void BAFOFGJEDFO(float4x4 OKLPBIOMJKA, int CPCIEIKHPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E44300", Offset = "0x5E43300", VA = "0x185E44300")]
	private DHHLPGMDNIA KDKBCCAICDJ(float3 IPOPAPIAACP)
	{
		return default(DHHLPGMDNIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E442B0", Offset = "0x5E432B0", VA = "0x185E442B0")]
	private float4 HJFDBEMKKGC(DHHLPGMDNIA NNBJLFCINHK, int NFJIPMHILEL)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E44370", Offset = "0x5E43370", VA = "0x185E44370")]
	private float2 PLHKLLDAANM(DHHLPGMDNIA NNBJLFCINHK, float3 LPGLCEHEHMC)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CHNCAHOPNCO
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum CLFCGJKCDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static CHNCAHOPNCO FKNBKDPNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float3 PGFEEKJAPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3x3 KDDDCEFLNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 FJPPAJJFFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public CLFCGJKCDEJ AMBPOKEJAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 AHHIGNNJAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 NMEEHBMEDPN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EMFJBOKKGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AC70", Offset = "0x5E39C70", VA = "0x185E3AC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 KFFPPANMFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AB90", Offset = "0x5E39B90", VA = "0x185E3AB90")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3ACF0", Offset = "0x5E39CF0", VA = "0x185E3ACF0")]
	public CHNCAHOPNCO(float3 LPGLCEHEHMC, quaternion LGOFCBEILGM, float3 LHAIIFMNPNK, CLFCGJKCDEJ CFGJPNBLNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A990", Offset = "0x5E39990", VA = "0x185E3A990")]
	public float MLNJPGENDKG(float3 BOJGOGFFKJG, float CIHBFCDLHLE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A360", Offset = "0x5E39360", VA = "0x185E3A360")]
	public bool FGLOMOKIGNB(float3 IPOPAPIAACP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A6E0", Offset = "0x5E396E0", VA = "0x185E3A6E0")]
	public void JLPDNEBKHLK(float3 OLAAELGABAM, float3x3 KAEJILDNMNF, float NDBAOFLIMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A890", Offset = "0x5E39890", VA = "0x185E3A890")]
	private void LIJDCHMCFNF(float3 MIELJCMDEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A450", Offset = "0x5E39450", VA = "0x185E3A450")]
	public void GLICNCINNNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct NBLFDEBNBGG : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<CHNCAHOPNCO> FCLEEDACIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> MAKBJKLBKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeList<int> MNPKDHDKJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> EEGKGPPMJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeList<IGFIKMFJMMO> LNILJCEEKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int HLAJBMJHFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int PJEOCLBDIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private float CIHBFCDLHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float GBGGKHOKEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> AFBECPKLDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> JCKGGIGLHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> IPICKPOAKKP;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5E42F00", Offset = "0x5E41F00", VA = "0x185E42F00")]
	public NBLFDEBNBGG(KPDLEIFKJLD KBKBNNLDMCD, float EFMGECDONDC, int HOLHNBPNHFM, int LGPGAABHJPK, NativeList<CHNCAHOPNCO> FCLEEDACIMH, NativeArray<int> EEGKGPPMJCM, NativeList<IGFIKMFJMMO> LNILJCEEKLB, DPCCFMGPGIJ DMKFKGJBHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5E42700", Offset = "0x5E41700", VA = "0x185E42700", Slot = "4")]
	public void Execute(int PHLGJFLAKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E42E40", Offset = "0x5E41E40", VA = "0x185E42E40")]
	private bool JFLNGNOMJCA(CHNCAHOPNCO HMDDIJJDAIK, CHNCAHOPNCO NDOJJCKFJID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E42460", Offset = "0x5E41460", VA = "0x185E42460")]
	private bool EGHKKJJGAKN(CHNCAHOPNCO JAFPDGGIPFD, int DBCABMCEDMN, int PEJEGLABMMF, int ONHNJHKHHNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DPCCFMGPGIJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<bool> HDAAJOPNCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<int> OHIPDGEHFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<bool> JMPLENBBDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeArray<float> NCCOPEMGNFH;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D960", Offset = "0x5E3C960", VA = "0x185E3D960")]
	public void PEEICNLLDKJ(int DOHOPADJJJH, int CBCODDJCNOL, Allocator OIPBEAGANJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D850", Offset = "0x5E3C850", VA = "0x185E3D850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D870", Offset = "0x5E3C870", VA = "0x185E3D870")]
	public void NIDAGEDDLKC(JobHandle KHPBICCBDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public DPCCFMGPGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct GAGJDCMHDOL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<float3> MAKBJKLBKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float3> IFODGOOCNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeArray<float4> HPEMFHNACAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeArray<float2> LCNENOHOIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<int> MNPKDHDKJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KNEFIPHJCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeArray<int> IFFGANIAGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<bool> AFBECPKLDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeArray<bool> JCKGGIGLHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int FIHBGCDEOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int IGKKCPAEKEE;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DEA0", Offset = "0x5E3CEA0", VA = "0x185E3DEA0")]
	public GAGJDCMHDOL(KPDLEIFKJLD KBKBNNLDMCD, DPCCFMGPGIJ DMKFKGJBHIF, int IGKKCPAEKEE = 0, int FIHBGCDEOCI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DA60", Offset = "0x5E3CA60", VA = "0x185E3DA60", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DE40", Offset = "0x5E3CE40", VA = "0x185E3DE40")]
	private void NIILBENGJDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ACBIGNBDDJC
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B00CF0", Offset = "0x2AFFCF0", VA = "0x182B00CF0")]
	public static bool PCNOBKGDEHJ<T>(NativeArray<T> FHOLKIOOKFG, int LHAIIFMNPNK, Allocator OIPBEAGANJF, NativeArrayOptions DGHDFHCPCLI = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B00D90", Offset = "0x2AFFD90", VA = "0x182B00D90")]
	public static bool PCNOBKGDEHJ<T>(NativeList<T> LOKHPAFMLOJ, int LHAIIFMNPNK, Allocator OIPBEAGANJF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum PCCEMNFLDAL
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
public interface OHPLDJJBEHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int IMCHOFPFGJC(PCCEMNFLDAL KBODLDDGOHA);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int FFALJLPBLOO(PCCEMNFLDAL KBODLDDGOHA);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLJHGNOFKIH(PCCEMNFLDAL KBODLDDGOHA, MKNGMLEHKNN DGJNPDDCCIA, int JHIPOMGDCAK = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KPDLEIFKJLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const int IBIOOKFKAII = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeList<float3> BMLKDMPICIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<float3> GKBJLBBDKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float4> AJEHOJNMIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public NativeArray<float4> AJBGPEIFDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NativeArray<float2> PBOJCBPFKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<int> PAIDODLPABN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool MHPEFMEANPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F8C0", Offset = "0x5E3E8C0", VA = "0x185E3F8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int GCEFKOJKPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FB10", Offset = "0x5E3EB10", VA = "0x185E3FB10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LMIBGJEGPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FA50", Offset = "0x5E3EA50", VA = "0x185E3FA50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool DJDAPCIKPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FA10", Offset = "0x5E3EA10", VA = "0x185E3FA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F900", Offset = "0x5E3E900", VA = "0x185E3F900", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E40180", Offset = "0x5E3F180", VA = "0x185E40180")]
	public void PEEICNLLDKJ(int DOHOPADJJJH, int CBCODDJCNOL, Allocator OIPBEAGANJF, bool DCMMICHCGPH, bool LHDBLMFFDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FA90", Offset = "0x5E3EA90", VA = "0x185E3FA90")]
	public void JAEPGAJEKDI(int DOHOPADJJJH, int CBCODDJCNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F4E0", Offset = "0x5E3E4E0", VA = "0x185E3F4E0", Slot = "6")]
	public bool AEIMGDLDEOC(Mesh KBKBNNLDMCD, bool ICEJKJOKFAL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FB50", Offset = "0x5E3EB50", VA = "0x185E3FB50")]
	public bool LODBJDBOJIA(Mesh KBKBNNLDMCD, KPDLEIFKJLD DFJBPKOLHHH, bool ICEJKJOKFAL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public KPDLEIFKJLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HKACMIPDKCI
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EE30", Offset = "0x5E3DE30", VA = "0x185E3EE30")]
	public static void OJJIFMENIIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ONPEPHNBEHJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<float3> BMLKDMPICIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeArray<float3> GKBJLBBDKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeArray<int> OEDCAJBGOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeArray<float4> NPOODCNLNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<float4> COGIGIFBACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<float4> EAECAGFCMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeList<float3> AOIACJDMMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public NativeList<int> PAIDODLPABN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GCEFKOJKPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5E45530", Offset = "0x5E44530", VA = "0x185E45530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int LMIBGJEGPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E44F70", Offset = "0x5E43F70", VA = "0x185E44F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int DODKLEKJEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E44F30", Offset = "0x5E43F30", VA = "0x185E44F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5E45B60", Offset = "0x5E44B60", VA = "0x185E45B60")]
	public ONPEPHNBEHJ(int DOHOPADJJJH, int CBCODDJCNOL, int BFCLLAOHOOK, Allocator OIPBEAGANJF = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5E45870", Offset = "0x5E44870", VA = "0x185E45870")]
	public ONPEPHNBEHJ(Mesh KBKBNNLDMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5E44E20", Offset = "0x5E43E20", VA = "0x185E44E20", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E45570", Offset = "0x5E44570", VA = "0x185E45570")]
	public void NMIAHBPIICO(ONPEPHNBEHJ KBKBNNLDMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E44990", Offset = "0x5E43990", VA = "0x185E44990")]
	private void AKAGPADDFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5E44FB0", Offset = "0x5E43FB0", VA = "0x185E44FB0")]
	private void KBHNGJMCNLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct IGFIKMFJMMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int IPBCDGAJPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int GCEFKOJKPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int LAANDFKEMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int LMIBGJEGPHH;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x11031B0", Offset = "0x11021B0", VA = "0x1811031B0")]
	public IGFIKMFJMMO(int LGPGAABHJPK, int AIAOEMFDGOE, int HOLHNBPNHFM, int CMHFLEIFIHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DCOALNMPKOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NativeList<IGFIKMFJMMO> OGMCPBALELA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xAF06A0", Offset = "0xAEF6A0", VA = "0x180AF06A0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<IGFIKMFJMMO>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1B3D060", Offset = "0x1B3C060", VA = "0x181B3D060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public ONPEPHNBEHJ MMHDKPJDGAO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x76F1E0", Offset = "0x76E1E0", VA = "0x18076F1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AE50", Offset = "0x5E39E50", VA = "0x185E3AE50")]
	public DCOALNMPKOI(IEnumerable<ONPEPHNBEHJ> NAMALKCJBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5E3ADE0", Offset = "0x5E39DE0", VA = "0x185E3ADE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum BJLNIDGLICL
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class KLAONLMKKFF
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static NativeArray<float2> CJGAGLHJPEO;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static NativeArray<float3> GINEHFAEDCA;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static NativeArray<float4> PGNILOAKHAG;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static NativeArray<int> BEBNDPKIOHO;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F2B0", Offset = "0x5E3E2B0", VA = "0x185E3F2B0")]
	public static void OJJIFMENIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F3D0", Offset = "0x5E3E3D0", VA = "0x185E3F3D0")]
	public static NativeArray<float2> OPBGCEBHDKI(NativeArray<float2> HKMHKJLMCME, int EMAPDBNCFDM, NativeArray<float2> KHMGEKLPLBE, int PHFBIGBEFFH)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F1A0", Offset = "0x5E3E1A0", VA = "0x185E3F1A0")]
	public static NativeArray<float3> IGBENCJPDOG(NativeArray<float3> HKMHKJLMCME, int EMAPDBNCFDM, NativeArray<float3> KHMGEKLPLBE, int PHFBIGBEFFH)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EF80", Offset = "0x5E3DF80", VA = "0x185E3EF80")]
	public static NativeArray<float4> DEFLMIFDIHI(NativeArray<float4> HKMHKJLMCME, int EMAPDBNCFDM, NativeArray<float4> KHMGEKLPLBE, int PHFBIGBEFFH)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F090", Offset = "0x5E3E090", VA = "0x185E3F090")]
	public static NativeArray<int> ICGFMGMPFFA(NativeArray<int> HKMHKJLMCME, int EMAPDBNCFDM, NativeArray<int> KHMGEKLPLBE, int PHFBIGBEFFH)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2556B00", Offset = "0x2555B00", VA = "0x182556B00")]
	private static void OJCBHALIEFB<T>(NativeArray<T> FHOLKIOOKFG, int BIJJBGNHDLG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2556A50", Offset = "0x2555A50", VA = "0x182556A50")]
	private static void MCLPCDHABMD<T>(NativeArray<T> HKMHKJLMCME, int EMAPDBNCFDM, NativeArray<T> KHMGEKLPLBE, int PHFBIGBEFFH, NativeArray<T> NJFIGKOHOME) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GBOJCOLHKPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<OHPLDJJBEHJ> DJBMCFBLDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly MIOAKCNPAIL OCNBNKFEBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int AIAOEMFDGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int CMHFLEIFIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool KHGGPMNKMKE;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh MMHDKPJDGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x76F1C0", Offset = "0x76E1C0", VA = "0x18076F1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x76F190", Offset = "0x76E190", VA = "0x18076F190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MeshRenderer KEENBLFCCON
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x76F220", Offset = "0x76E220", VA = "0x18076F220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int GCEFKOJKPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5E3EB90", Offset = "0x5E3DB90", VA = "0x185E3EB90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x208F180", Offset = "0x208E180", VA = "0x18208F180")]
	public void OJPJDKPAEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3ED10", Offset = "0x5E3DD10", VA = "0x185E3ED10")]
	public GBOJCOLHKPA(string JNMEJDHMADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EC20", Offset = "0x5E3DC20", VA = "0x185E3EC20")]
	public void NIDAGEDDLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E770", Offset = "0x5E3D770", VA = "0x185E3E770")]
	public void HECDNNNLANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E7A0", Offset = "0x5E3D7A0", VA = "0x185E3E7A0")]
	public void IPJOAOOAMPJ(OHPLDJJBEHJ BBFAKKAJMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E920", Offset = "0x5E3D920", VA = "0x185E3E920")]
	private void KAMDCBHBEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E700", Offset = "0x5E3D700", VA = "0x185E3E700")]
	public bool DACILIFDHGB(OHPLDJJBEHJ BBFAKKAJMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DF20", Offset = "0x5E3CF20", VA = "0x185E3DF20")]
	public bool AKPLCCANECI(OHPLDJJBEHJ BBFAKKAJMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EBB0", Offset = "0x5E3DBB0", VA = "0x185E3EBB0", Slot = "4")]
	public virtual void KLADBOKANDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E850", Offset = "0x5E3D850", VA = "0x185E3E850")]
	public void JJKODFABMLK(Transform CCEIIIIMEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DF80", Offset = "0x5E3CF80", VA = "0x185E3DF80")]
	public bool CABBIGNGPAE(Transform CCEIIIIMEAA, [Out] (KPDLEIFKJLD destMesh, Mesh mesh, JobHandle job) FCLEEDACIMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EC60", Offset = "0x5E3DC60", VA = "0x185E3EC60")]
	public void PFNHMEBKIOB([In] (KPDLEIFKJLD destMesh, Mesh mesh, JobHandle job) FCLEEDACIMH)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker IODNECLNDGG;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker OPKMKKOFDLO;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker FEDJMEOFPEM;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private const int HMLLGNOGIHL = 65000;

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
		private Dictionary<Material, List<GBOJCOLHKPA>> BAJDDBNLNGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private List<GBOJCOLHKPA> COANPAPLGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<MeshRenderer> EEKDKLAHMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private List<(GBOJCOLHKPA, (KPDLEIFKJLD, Mesh, JobHandle))> CEBEDHGLJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool KFMCAGIHHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<int, float> MMNILFFEBDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Dictionary<int, Color> MCDCDKBOFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<int, Vector4> NBGMPOMFLDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Dictionary<int, Matrix4x4> FFELDPHAOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private GBOJCOLHKPA DFEJDHJPEAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Material LJAEFCAMLLP;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<MeshRenderer> JKMINGADOJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x76F1D0", Offset = "0x76E1D0", VA = "0x18076F1D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E39320", Offset = "0x5E38320", VA = "0x185E39320")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E38130", Offset = "0x5E37130", VA = "0x185E38130")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E378C0", Offset = "0x5E368C0", VA = "0x185E378C0")]
		public GBOJCOLHKPA AddToBatchedMesh(OHPLDJJBEHJ LMFILMGMAIF, Material DMOCGBANHDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5E39570", Offset = "0x5E38570", VA = "0x185E39570")]
		public void RemoveFromBatchedMesh(OHPLDJJBEHJ KBKBNNLDMCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5E37F90", Offset = "0x5E36F90", VA = "0x185E37F90")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E396F0", Offset = "0x5E386F0", VA = "0x185E396F0")]
		public void SetMaterialProperty(int PKPKCGCHKKM, Color NGFEKFKHCIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5E39B80", Offset = "0x5E38B80", VA = "0x185E39B80")]
		public void SetMaterialProperty(int PKPKCGCHKKM, float APPJEOKOGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5E39DA0", Offset = "0x5E38DA0", VA = "0x185E39DA0")]
		public void SetMaterialProperty(int PKPKCGCHKKM, Vector4 HFDEBOALMMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E39920", Offset = "0x5E38920", VA = "0x185E39920")]
		public void SetMaterialProperty(int PKPKCGCHKKM, Matrix4x4 DAGOOGENCFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5E379A0", Offset = "0x5E369A0", VA = "0x185E379A0")]
		private void CMPJGKOKECJ(Renderer CHHDBJPKECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E38870", Offset = "0x5E37870", VA = "0x185E38870")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E38310", Offset = "0x5E37310", VA = "0x185E38310")]
		private void FKKEBIHGJJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5E39120", Offset = "0x5E38120", VA = "0x185E39120")]
		private GBOJCOLHKPA OKMHNCLLCKJ(OHPLDJJBEHJ KBKBNNLDMCD, Material DMOCGBANHDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E38F50", Offset = "0x5E37F50", VA = "0x185E38F50")]
		private GBOJCOLHKPA NCOHNCPCMKA(Material DMOCGBANHDO, int CGCDHELAMPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5E38AA0", Offset = "0x5E37AA0", VA = "0x185E38AA0")]
		private GBOJCOLHKPA NAEHABBGDJL(Material DMOCGBANHDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5E38880", Offset = "0x5E37880", VA = "0x185E38880")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5E38910", Offset = "0x5E37910", VA = "0x185E38910")]
		public void MarkDirty(OHPLDJJBEHJ KBKBNNLDMCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A0A0", Offset = "0x5E390A0", VA = "0x185E3A0A0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KGFANBEBBPD<KeyType> : GBOJCOLHKPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<KeyType, OHPLDJJBEHJ> NMDGGIAGANE;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x396C1E0", Offset = "0x396B1E0", VA = "0x18396C1E0")]
	public KGFANBEBBPD(string JNMEJDHMADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x396BFB0", Offset = "0x396AFB0", VA = "0x18396BFB0")]
	public void IPJOAOOAMPJ(KeyType BGNGIHJEFLM, OHPLDJJBEHJ BBFAKKAJMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x396C040", Offset = "0x396B040", VA = "0x18396C040")]
	public bool KNLBGCOGPFH(KeyType BGNGIHJEFLM, OHPLDJJBEHJ AHCLBCHHMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x396BE70", Offset = "0x396AE70", VA = "0x18396BE70")]
	public void EBONILBEDKM(KeyType BGNGIHJEFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x396C000", Offset = "0x396B000", VA = "0x18396C000", Slot = "4")]
	public override void KLADBOKANDG()
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
