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
public struct FGFDGDNOMBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct LKMMCBPDODM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int OOGBKFGCHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int OKMFKHICFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int GFMANAMIJDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int FLLIKJDJLIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int NOEOJDBPGAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int LNBDKBJCANG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 JAEJEACOKAH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5B70", Offset = "0x5FB4F70", VA = "0x185FB5B70")]
		public LKMMCBPDODM(int GOMJIBCAEDH, int EMFMFEFBEEN, int AKPNODKCBHJ, int BCDAIPPOPFM, int LAICDANHNOK, int IKHKJFCEMBL, float3 EMLKPCFFBLJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct CIMIKCJNBNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int DMMMFKHLJGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int KKGPGIELLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float JFDKLOKFIFP;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x240B5E0", Offset = "0x240A9E0", VA = "0x18240B5E0")]
		public CIMIKCJNBNF(int PMLBPCJAADD, int KBBAFLEKIJE, float PFEJCBNJLGA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct ACEEANDKDOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int KKGPGIELLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int HOECDJINJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int KKPOKCCHIDI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeHashMap<int, LKMMCBPDODM> DKDGBFKJEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<CIMIKCJNBNF> NIOLDEDLGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeHashMap<int, int> OAHHHJLMJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<ACEEANDKDOF> PKHEDMNGKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeHashMap<int, int> HHDDDFBHBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int OGHOBBCIAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int LKLDPGOGEPA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3540", Offset = "0x5FB2940", VA = "0x185FB3540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5320", Offset = "0x5FB4720", VA = "0x185FB5320")]
	public bool JDNBEOFICGN(in NativeArray<float3> BFJJDHEGHJP, ref NativeList<float3> APFJLLLOLHK, ref NativeList<int> LBCJAENOALC, Allocator NHNCCHNPCJI, CancellationToken BJBDGBAHFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5980", Offset = "0x5FB4D80", VA = "0x185FB5980")]
	private void PAICICMJOCE(in NativeArray<float3> BFJJDHEGHJP, Allocator NHNCCHNPCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FB39C0", Offset = "0x5FB2DC0", VA = "0x185FB39C0")]
	private void FFLNCLAFEEO(in NativeArray<float3> BFJJDHEGHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FB26D0", Offset = "0x5FB1AD0", VA = "0x185FB26D0")]
	private void BCJPGFFEGOJ(in NativeArray<float3> BFJJDHEGHJP, out int KKANNANOKPB, out int HCDPDEPMLKB, out int BCGPPHGJCMM, out int HMODAFPDGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2FD0", Offset = "0x5FB23D0", VA = "0x185FB2FD0")]
	private void BDOIBFIPIGI(in NativeArray<float3> BFJJDHEGHJP, Allocator NHNCCHNPCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2A80", Offset = "0x5FB1E80", VA = "0x185FB2A80")]
	private void BDBLFAILCJK(in NativeArray<float3> BFJJDHEGHJP, float3 EKDILHNEMKK, int ICJPKFCDEOA, LKMMCBPDODM OGBDOKPJGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4F30", Offset = "0x5FB4330", VA = "0x185FB4F30")]
	private void IELNDJBJBCH(in NativeArray<float3> BFJJDHEGHJP, float3 EKDILHNEMKK, int AAOIMKLPBDF, int LKLDPGOGEPA, LKMMCBPDODM OGBDOKPJGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5400", Offset = "0x5FB4800", VA = "0x185FB5400")]
	private void KFFMHKCFKEJ(in NativeArray<float3> BFJJDHEGHJP, int FDNDKNIKMPN, Allocator NHNCCHNPCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB31C0", Offset = "0x5FB25C0", VA = "0x185FB31C0")]
	private void CLDCGHAOINA(in NativeArray<float3> BFJJDHEGHJP, Allocator NHNCCHNPCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4B40", Offset = "0x5FB3F40", VA = "0x185FB4B40")]
	private void HNKDMBJICCI(in NativeArray<float3> BFJJDHEGHJP, ref NativeList<float3> APFJLLLOLHK, ref NativeList<int> LBCJAENOALC, Allocator NHNCCHNPCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2650", Offset = "0x5FB1A50", VA = "0x185FB2650")]
	private float AGPKKGNFLMI(float3 EKDILHNEMKK, float3 CGIHNPLOILA, LKMMCBPDODM OGBDOKPJGLJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0D30", Offset = "0x5FB0130", VA = "0x185FB0D30")]
	private float3 JAEJEACOKAH(float3 GOMJIBCAEDH, float3 EMFMFEFBEEN, float3 AKPNODKCBHJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5A19700", Offset = "0x5A18B00", VA = "0x185A19700")]
	private static float KBDPHHDDBHN(float3 ANJGLCCJFPO, float3 ABBMKKCGFBG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5AF0", Offset = "0x5FB4EF0", VA = "0x185FB5AF0")]
	private static float3 PCMKNEOIGFG(float3 ANJGLCCJFPO, float3 ABBMKKCGFBG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4AC0", Offset = "0x5FB3EC0", VA = "0x185FB4AC0")]
	private bool GPGOFJGOFHE(float3 ANJGLCCJFPO, float3 ABBMKKCGFBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0C20", Offset = "0x5FB0020", VA = "0x185FB0C20")]
	private bool FLEHJDGDHIE(float3 ANJGLCCJFPO, float3 ABBMKKCGFBG, float3 CMLILENOEPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3680", Offset = "0x5FB2A80", VA = "0x185FB3680")]
	private bool EPGHMPKIAIM(float3 ANJGLCCJFPO, float3 ABBMKKCGFBG, float3 CMLILENOEPA, float3 PFEJCBNJLGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct ENAGIPNEEHO : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct APMIHEINDKI
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
	private NativeList<float3> PKEGJOBFLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> FMMLBKLPING;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FJMFPAFGAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5FB0FF0", Offset = "0x5FB03F0", VA = "0x185FB0FF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ENCLBHDFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2090", Offset = "0x5FB1490", VA = "0x185FB2090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EIEEJMIIAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1030", Offset = "0x5FB0430", VA = "0x185FB1030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CHMDBGGOKFH MLOLBDBNNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5FB19F0", Offset = "0x5FB0DF0", VA = "0x185FB19F0")]
		get
		{
			return default(CHMDBGGOKFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2340", Offset = "0x5FB1740", VA = "0x185FB2340")]
	public ENAGIPNEEHO(int NBLPLJKHIBJ, int JBBLOONAOFG, Allocator NHNCCHNPCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2310", Offset = "0x5FB1710", VA = "0x185FB2310")]
	public ENAGIPNEEHO(CHMDBGGOKFH BOAPDJDLPID, Allocator NHNCCHNPCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2170", Offset = "0x5FB1570", VA = "0x185FB2170")]
	public ENAGIPNEEHO(Mesh DKKFAMCHLJC, Allocator NHNCCHNPCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB23F0", Offset = "0x5FB17F0", VA = "0x185FB23F0")]
	public ENAGIPNEEHO(ENAGIPNEEHO HANEMGLFJMM, Allocator NHNCCHNPCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB1070", Offset = "0x5FB0470", VA = "0x185FB1070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FB1100", Offset = "0x5FB0500", VA = "0x185FB1100")]
	public void EIPAABBBFMM(in ENAGIPNEEHO EKGMIOGLPIC, float4x4 OABODAFCNNG, Transform CKOEJNAMAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5FB1EB0", Offset = "0x5FB12B0", VA = "0x185FB1EB0")]
	public void LGJBPFABBBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FB1510", Offset = "0x5FB0910", VA = "0x185FB1510")]
	public void GKGOGHFDCIB(float PAKNAMCBNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FB1AA0", Offset = "0x5FB0EA0", VA = "0x185FB1AA0")]
	public ENAGIPNEEHO JCMJMAHLNBD(Allocator NHNCCHNPCJI, CancellationToken BJBDGBAHFDE)
	{
		return default(ENAGIPNEEHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5FB1D90", Offset = "0x5FB1190", VA = "0x185FB1D90")]
	public Mesh JPBNDJDLEII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2120", Offset = "0x5FB1520", VA = "0x185FB2120")]
	private unsafe static float3* PBKLOPMEANF(NativeArray<float3> CCKHAOABLMF)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5FB20D0", Offset = "0x5FB14D0", VA = "0x185FB20D0")]
	private unsafe static int* PBKLOPMEANF(NativeArray<int> CCKHAOABLMF)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5FB1A70", Offset = "0x5FB0E70", VA = "0x185FB1A70")]
	[CompilerGenerated]
	internal static void HLKJMADLLBP(int AMLDFMAFANJ, int GCCEJKMLJKN, ref APMIHEINDKI P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct CHMDBGGOKFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int FJMFPAFGAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int ENCLBHDFDFO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PBPHNHBNIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FB0EC0", Offset = "0x5FB02C0", VA = "0x185FB0EC0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x549FEF0", Offset = "0x549F2F0", VA = "0x18549FEF0")]
	public static CHMDBGGOKFH NEHMMEEOCFG(CHMDBGGOKFH ANJGLCCJFPO, CHMDBGGOKFH ABBMKKCGFBG)
	{
		return default(CHMDBGGOKFH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0EA0", Offset = "0x5FB02A0", VA = "0x185FB0EA0")]
	public static CHMDBGGOKFH COIOCMDEOOB(CHMDBGGOKFH PHKMPFENAIO, int PIJNGNJGCHN)
	{
		return default(CHMDBGGOKFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0ED0", Offset = "0x5FB02D0", VA = "0x185FB0ED0", Slot = "0")]
	public override bool Equals(object ONJBPEFAPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0F10", Offset = "0x5FB0310", VA = "0x185FB0F10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0F50", Offset = "0x5FB0350", VA = "0x185FB0F50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AOFFFKCEJMG
{
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
