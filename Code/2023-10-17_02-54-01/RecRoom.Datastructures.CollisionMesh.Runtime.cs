using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct PBHOFBJJFLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct DHFOCNEIAMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int GPIHPBHJMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int JGGHFDLDNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int EEJKIAAODPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int ABGLPCLHLMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int OGBNEFJBKDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int DCANNLADMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 PPHPDGDNNDB;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5CA04D0", Offset = "0x5C9ECD0", VA = "0x185CA04D0")]
		public DHFOCNEIAMA(int CCLNHINFOJN, int NMGIFAEEICG, int DENMGMJOGBJ, int AMIKDLGEHNM, int AHCAAFBEEHP, int CHFNJGEJKLP, float3 LOKKODLNJFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct NKOCADACJGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int KOFGPGBECGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int LNFOAOEKCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float DLDAAALJHIB;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE79810", Offset = "0xE78010", VA = "0x180E79810")]
		public NKOCADACJGM(int EJOBIJGJEMN, int FLEKOMGPFFE, float CLPHKIKLHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct JBAKKDBGBBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int LNFOAOEKCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int EPOICFKJIAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int MMAKICFHFMK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, DHFOCNEIAMA> BDEPKKCAFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<NKOCADACJGM> PBLKLBHGKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> KKNGFKMEIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<JBAKKDBGBBI> CHDADDBABOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> KKOAALMMCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int FJALAEBDLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int CHJFMHNCFBA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5CA22B0", Offset = "0x5CA0AB0", VA = "0x185CA22B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4840", Offset = "0x5CA3040", VA = "0x185CA4840")]
	public bool LHADBJMFGMI([In] NativeArray<float3> FMNFFINHFGA, NativeList<float3> LKDGCOACDIP, NativeList<int> GPEAFMNEBLH, Allocator JONICLHJBEP, CancellationToken EHCFBFBFEDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CA3DD0", Offset = "0x5CA25D0", VA = "0x185CA3DD0")]
	private void GLJEDCMMNGN([In] NativeArray<float3> FMNFFINHFGA, Allocator JONICLHJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CA2DC0", Offset = "0x5CA15C0", VA = "0x185CA2DC0")]
	private void GFFEGPPHGAD([In] NativeArray<float3> FMNFFINHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CA1DF0", Offset = "0x5CA05F0", VA = "0x185CA1DF0")]
	private void DOPKDBOOKJD([In] NativeArray<float3> FMNFFINHFGA, [Out] int CEAMDHJNPBE, [Out] int FJKDMGOIGPP, [Out] int OEIDKNCEBAO, [Out] int OJADALABNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5CA1BC0", Offset = "0x5CA03C0", VA = "0x185CA1BC0")]
	private void BALIEGBJEME([In] NativeArray<float3> FMNFFINHFGA, Allocator JONICLHJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4E10", Offset = "0x5CA3610", VA = "0x185CA4E10")]
	private void PNGPCPCKGCB([In] NativeArray<float3> FMNFFINHFGA, float3 ELJFMFLOMJI, int PPODNBKBBNJ, DHFOCNEIAMA DFFNPLOPLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5CA49E0", Offset = "0x5CA31E0", VA = "0x185CA49E0")]
	private void NEGNJEMCACN([In] NativeArray<float3> FMNFFINHFGA, float3 ELJFMFLOMJI, int IAGBFDKLNCP, int CHJFMHNCFBA, DHFOCNEIAMA DFFNPLOPLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5CA2450", Offset = "0x5CA0C50", VA = "0x185CA2450")]
	private void FLHGPFHJDME([In] NativeArray<float3> FMNFFINHFGA, int NGBHBMBNOIO, Allocator JONICLHJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5CA2A50", Offset = "0x5CA1250", VA = "0x185CA2A50")]
	private void GBCPIEOFMGK([In] NativeArray<float3> FMNFFINHFGA, Allocator JONICLHJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5CA3FB0", Offset = "0x5CA27B0", VA = "0x185CA3FB0")]
	private void IEGBLLCGNNN([In] NativeArray<float3> FMNFFINHFGA, NativeList<float3> LKDGCOACDIP, NativeList<int> GPEAFMNEBLH, Allocator JONICLHJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4DB0", Offset = "0x5CA35B0", VA = "0x185CA4DB0")]
	private float NPPADMPHMFM(float3 ELJFMFLOMJI, float3 JDPCPGGKPEI, DHFOCNEIAMA DFFNPLOPLIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5270", Offset = "0x5CA3A70", VA = "0x185CA5270")]
	private float3 PPHPDGDNNDB(float3 CCLNHINFOJN, float3 NMGIFAEEICG, float3 DENMGMJOGBJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5CA1DC0", Offset = "0x5CA05C0", VA = "0x185CA1DC0")]
	private static float BHDOCBEMFFI(float3 EOFAJFKEBLN, float3 DNOEGKBPKDC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5CA23F0", Offset = "0x5CA0BF0", VA = "0x185CA23F0")]
	private static float3 EFJAENCPEAI(float3 EOFAJFKEBLN, float3 DNOEGKBPKDC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4980", Offset = "0x5CA3180", VA = "0x185CA4980")]
	private bool MDFFJCIHMGI(float3 EOFAJFKEBLN, float3 DNOEGKBPKDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4770", Offset = "0x5CA2F70", VA = "0x185CA4770")]
	private bool KOEOFJBDAOL(float3 EOFAJFKEBLN, float3 DNOEGKBPKDC, float3 HCJCBMCLKPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CA4480", Offset = "0x5CA2C80", VA = "0x185CA4480")]
	private bool INLEEFOFOLD(float3 EOFAJFKEBLN, float3 DNOEGKBPKDC, float3 HCJCBMCLKPJ, float3 CLPHKIKLHHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OAJNEJLNFMD : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct OALHKDNOPIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public unsafe int* indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int indexCount;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<float3> BHOLEMLGIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> HAKPFGEOMPI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OJAEFINFDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5CA10D0", Offset = "0x5C9F8D0", VA = "0x185CA10D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KBCHBEHIDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CA1110", Offset = "0x5C9F910", VA = "0x185CA1110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HLNECFAPNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CA1150", Offset = "0x5C9F950", VA = "0x185CA1150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ELPNLDFBJME KBMNFILMICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5CA1380", Offset = "0x5C9FB80", VA = "0x185CA1380")]
		get
		{
			return default(ELPNLDFBJME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CA1600", Offset = "0x5C9FE00", VA = "0x185CA1600")]
	public OAJNEJLNFMD(int MCKDCMEAPDD, int NBCEJGCLIFB, Allocator JONICLHJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CA1B90", Offset = "0x5CA0390", VA = "0x185CA1B90")]
	public OAJNEJLNFMD(ELPNLDFBJME BHBCLLHFCPK, Allocator JONICLHJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CA1A20", Offset = "0x5CA0220", VA = "0x185CA1A20")]
	public OAJNEJLNFMD(Mesh LFKHDLANNJG, Allocator JONICLHJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CA16C0", Offset = "0x5C9FEC0", VA = "0x185CA16C0")]
	public OAJNEJLNFMD(OAJNEJLNFMD AELCABDCBDD, Allocator JONICLHJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CA1040", Offset = "0x5C9F840", VA = "0x185CA1040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CA0B70", Offset = "0x5C9F370", VA = "0x185CA0B70")]
	public void BONJGFNEKBE([In] OAJNEJLNFMD KLIANGHAKAC, float4x4 NNJGENDBEIL, Transform CADMEIGIELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CA0EF0", Offset = "0x5C9F6F0", VA = "0x185CA0EF0")]
	public void DPJAGHIPMBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CA0680", Offset = "0x5C9EE80", VA = "0x185CA0680")]
	public void AFCCKNLLIKD(float LNHOFLIBFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CA1400", Offset = "0x5C9FC00", VA = "0x185CA1400")]
	public OAJNEJLNFMD PJPLLCHPCLA(Allocator JONICLHJBEP, CancellationToken EHCFBFBFEDH)
	{
		return default(OAJNEJLNFMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CA1190", Offset = "0x5C9F990", VA = "0x185CA1190")]
	public Mesh LIOFBBKBMEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CA1300", Offset = "0x5C9FB00", VA = "0x185CA1300")]
	private unsafe static float3* MKJADOHIOFM(NativeArray<float3> INLAJDDNHAO)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CA12B0", Offset = "0x5C9FAB0", VA = "0x185CA12B0")]
	private unsafe static int* MKJADOHIOFM(NativeArray<int> INLAJDDNHAO)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CA1350", Offset = "0x5C9FB50", VA = "0x185CA1350")]
	[CompilerGenerated]
	internal static void OKPLOLBOLBF(int LNEMDKCCBFN, int CLLPJOHKGPK, OALHKDNOPIE P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct ELPNLDFBJME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int OJAEFINFDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int KBCHBEHIDMM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HAJCLONKPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5CA05D0", Offset = "0x5C9EDD0", VA = "0x185CA05D0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1B546F0", Offset = "0x1B52EF0", VA = "0x181B546F0")]
	public static ELPNLDFBJME KMOGMICJDHO(ELPNLDFBJME EOFAJFKEBLN, ELPNLDFBJME DNOEGKBPKDC)
	{
		return default(ELPNLDFBJME);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CA05B0", Offset = "0x5C9EDB0", VA = "0x185CA05B0")]
	public static ELPNLDFBJME IGJOCHNMBBJ(ELPNLDFBJME GOCMAOEPKDG, int IOOIAIKIEIJ)
	{
		return default(ELPNLDFBJME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CA0510", Offset = "0x5C9ED10", VA = "0x185CA0510", Slot = "0")]
	public override bool Equals(object JGBFBGOGLFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CA0560", Offset = "0x5C9ED60", VA = "0x185CA0560", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5CA05E0", Offset = "0x5C9EDE0", VA = "0x185CA05E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace Cpp2IlInjected;

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
