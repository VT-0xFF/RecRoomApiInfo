using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core.Creation.Shapes;
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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OKMEEMIDHHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int ALIKHDJGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 MBIHOEEHOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion KOJJLJBMNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 BOKKLPDLJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int PGHAADBAFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int DEHFKEFKIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int NGOBEGJDHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float MHJLDMGGADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 FCFBNGCIDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool AFOBECHCCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IBGMNCLCKND IMHMDMLJOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 GDPOOPDIAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float ENEDCGJOLGL;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IGNFHCBPGKH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static BJCLAOICFFI INMKEOABOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<OKMEEMIDHHI> KDAKCHOPNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<OICGCFPGCCD> IKIECMJBCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<ENLJMKNMNJC> GIDFAJDKEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<JKGAAGKIBDH> ABBMBHMOPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<OICGCFPGCCD> JMJPPJCBJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<ONCHPBPOKOP> HHKLDNBAIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<JKGAAGKIBDH>> DDGFEBIIJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<HJBMICDLEEM> GHBBILOOOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> EFLEGBCCDHH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MFDEBNGOCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC6BA10", Offset = "0xC6A610", VA = "0x180C6BA10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC6B1C0", Offset = "0xC69DC0", VA = "0x180C6B1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NNHLAMNFCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC6BA20", Offset = "0xC6A620", VA = "0x180C6BA20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC6AC70", Offset = "0xC69870", VA = "0x180C6AC70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x618B4C0", Offset = "0x618A0C0", VA = "0x18618B4C0")]
	public IGNFHCBPGKH(int MFIPFPNLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6189CB0", Offset = "0x61888B0", VA = "0x186189CB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x618B2F0", Offset = "0x6189EF0", VA = "0x18618B2F0")]
	public void PCCPCKIFLJO(JobHandle JAJDCBMGAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x618A0C0", Offset = "0x6188CC0", VA = "0x18618A0C0")]
	public void ICKINJMHIPJ(OKMEEMIDHHI KOMCCCIEHEA, HJBMICDLEEM DIOKAIIBOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6189F80", Offset = "0x6188B80", VA = "0x186189F80")]
	public void ENMGNMHDBPL(ENLJMKNMNJC KOMCCCIEHEA, NativeArray<JKGAAGKIBDH> BHGLAMIEMBN, int NFCHPGGEIFI, int KKHAJNPICKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x618A2E0", Offset = "0x6188EE0", VA = "0x18618A2E0")]
	public JobHandle KNEGGDOMEHE(KGMILHEBHMD FCCGOCLFKOC, BAAKBJMPNGG BOCPECLDIAH, float3 HPPNCHKEMDK, quaternion OBCJHPPLPCB, float KKNIAIMMPEG, bool IDCMFGEHJPD, int NKJPFPBCJAE = 0, int GEDMGEGDOAE = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6189970", Offset = "0x6188570", VA = "0x186189970")]
	public static JobHandle BIOAGBNCGDA(NPKNJJJLLBF OHDIPKAENGH, KGMILHEBHMD FCCGOCLFKOC, OKMEEMIDHHI KOMCCCIEHEA, JobHandle JAJDCBMGAHG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6189CD0", Offset = "0x61888D0", VA = "0x186189CD0")]
	public static JobHandle EACADOENLHO(KKIBILPCHNJ OHDIPKAENGH, KGMILHEBHMD FCCGOCLFKOC, ENLJMKNMNJC KOMCCCIEHEA, NativeArray<JKGAAGKIBDH> BHGLAMIEMBN, int NFCHPGGEIFI, int KKHAJNPICKG, JobHandle JAJDCBMGAHG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NKMNJJABDMF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct EGLCIFAOMJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half DGCNENMMPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort JKJMILHCCLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte BIGCNKCKOFJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int NFCHPGGEIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int KKHAJNPICKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> LONJONBONDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> JBPCJGMBMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> LFBCKMHJANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> JDMCKBGMLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<EGLCIFAOMJH> LKBFJJNEFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> MANBBDKNJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> BCDMFKFOCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 PIBIBOOIANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 NLMBONLNPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 FKMACOCMJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 JGOBFAIMGFP;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long CMLBFFMLIMN;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long ONPMOJEOOOJ;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float HNFOJELMIOF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool KEOLDNPAMOH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MCOGMBNPCLG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6190D00", Offset = "0x618F900", VA = "0x186190D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x61925A0", Offset = "0x61911A0", VA = "0x1861925A0")]
	public void PCCPCKIFLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6191230", Offset = "0x618FE30", VA = "0x186191230")]
	public static NKMNJJABDMF JOBBHNKGDPO(Allocator AIHLFFHGGIO, KGMILHEBHMD ILBOIIIFLHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6190E60", Offset = "0x618FA60", VA = "0x186190E60")]
	public static NKMNJJABDMF JOBBHNKGDPO(Allocator AIHLFFHGGIO, NativeArray<float3> DECMBOBGAMP, NativeArray<float3> CJEDPHCFFJB, NativeArray<float2> LJBCNNMEPKK, NativeArray<float4> HCJNANIGKHD, bool IAGEPHEHKIF, NativeArray<float4> MCCMOMILKFJ, NativeArray<int> GIJJBEHFOLN, int NFCHPGGEIFI, int PDIGMEBGEDK, int KKHAJNPICKG, int AECBBNOMKOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6191F90", Offset = "0x6190B90", VA = "0x186191F90")]
	public KGMILHEBHMD MCGEIKAHIPI(Allocator AIHLFFHGGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6190D40", Offset = "0x618F940", VA = "0x186190D40")]
	public void JCHCFCCIDGB(Mesh PLPNPKIPEIA, bool PFBLPNINLNM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x61924B0", Offset = "0x61910B0", VA = "0x1861924B0")]
	public long OBIOPNPNFGC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6190790", Offset = "0x618F390", VA = "0x186190790")]
	private void FEFGOMAJBOH(int MFDAKGOOJAL, int AIBNJIIJOPG, Allocator AIHLFFHGGIO, bool PCJOOICMKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6190C70", Offset = "0x618F870", VA = "0x186190C70")]
	private float3 HELGICAOJHN(int BJACKNADDBO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6191BE0", Offset = "0x61907E0", VA = "0x186191BE0")]
	private void KFPGINMFIPH(int BJACKNADDBO, float3 KKBIBDFBAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6190E20", Offset = "0x618FA20", VA = "0x186190E20")]
	private float3 JGGOAHGBKNH(int BJACKNADDBO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6191D90", Offset = "0x6190990", VA = "0x186191D90")]
	private void LDOIMAHLHDO(int BJACKNADDBO, float3 KKBIBDFBAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6191DE0", Offset = "0x61909E0", VA = "0x186191DE0")]
	private float4 LKFFIAJDPAH(int BJACKNADDBO)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6190920", Offset = "0x618F520", VA = "0x186190920")]
	private void FLKIICOHPEE(int BJACKNADDBO, float4 KKBIBDFBAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6192540", Offset = "0x6191140", VA = "0x186192540")]
	private float2 OCAACMHALCH(int BJACKNADDBO)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6190B60", Offset = "0x618F760", VA = "0x186190B60")]
	private void GONAFFBEOIL(int BJACKNADDBO, float2 KKBIBDFBAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6191950", Offset = "0x6190550", VA = "0x186191950")]
	private void KBGLKGLPHGK(NativeArray<float3> DECMBOBGAMP, int AECBBNOMKOJ, int AIBNJIIJOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61908A0", Offset = "0x618F4A0", VA = "0x1861908A0")]
	private void FEPPFCPOGNO(NativeArray<float3> CJEDPHCFFJB, int AECBBNOMKOJ, int AIBNJIIJOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61902C0", Offset = "0x618EEC0", VA = "0x1861902C0")]
	private void BIHECOJOPJK(NativeArray<float2> LJBCNNMEPKK, int AECBBNOMKOJ, int AIBNJIIJOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6190540", Offset = "0x618F140", VA = "0x186190540")]
	private void BNDHLICJPLI(NativeArray<float4> KNNGNHNBCEE, int AECBBNOMKOJ, int AIBNJIIJOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6191470", Offset = "0x6190070", VA = "0x186191470")]
	private void KAJAKMFAOLC(Allocator AIHLFFHGGIO, NativeArray<float4> HCJNANIGKHD, int AECBBNOMKOJ, int AIBNJIIJOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6191E50", Offset = "0x6190A50", VA = "0x186191E50")]
	private static void LLJNLJNHJAD(NativeArray<float4> OMKEBOHHBBP, NativeArray<EGLCIFAOMJH> FKCJGBMKIAO, NativeArray<byte> ENLJOAACNDH, int NFCHPGGEIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61906B0", Offset = "0x618F2B0", VA = "0x1861906B0")]
	private void EHFBGLIPJOL(Allocator AIHLFFHGGIO, NativeArray<int> GIJJBEHFOLN, int AECBBNOMKOJ, int AIBNJIIJOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61926A0", Offset = "0x61912A0", VA = "0x1861926A0")]
	private static NativeArray<byte> PEIOFPCNHCE(Allocator AIHLFFHGGIO, NativeArray<int> GIJJBEHFOLN, int IKLJKNCPAMK)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6190610", Offset = "0x618F210", VA = "0x186190610")]
	private static void DIJNJKEGKAP(NativeArray<int> HAGGGPJDEGJ, NativeArray<byte> ENLBGMHOELJ, int KKHAJNPICKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6192970", Offset = "0x6191570", VA = "0x186192970")]
	private static float3 PKNNNFPHOPN(ushort GFHNINEMDGL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61909A0", Offset = "0x618F5A0", VA = "0x1861909A0")]
	private static ushort GCMBOAGMMEO(float3 KKBIBDFBAOI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public NKMNJJABDMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct HIFMLCMPLKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float2 BOBKHJLAPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float2 PCKLNGGEIMO;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DCDBLIMFHGA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public NativeArray<HIFMLCMPLKH> ICKLJFPFNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<int> JJLGPHMKEAO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MFDEBNGOCEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B1560", Offset = "0x7B0160", VA = "0x1807B1560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NNHLAMNFCAA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CC0", Offset = "0x7B58C0", VA = "0x1807B6CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6186520", Offset = "0x6185120", VA = "0x186186520")]
	public DCDBLIMFHGA(int MFDAKGOOJAL, int AIBNJIIJOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x61863E0", Offset = "0x6184FE0", VA = "0x1861863E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6186440", Offset = "0x6185040", VA = "0x186186440")]
	public void LMHEHFAMFJF(DCDBLIMFHGA JHFIGNMJNAN, int HDINHGFKMAE, int FAFMJOHFKBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BEIBPGCGKBE
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static DCDBLIMFHGA PMLODPLNKDF;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static NativeList<OICGCFPGCCD> CPILJHOBNLL;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static int[] CNCICLNEBBE;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static bool ABDCICNEAPH;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Dictionary<int, DCDBLIMFHGA> OJJJLAGOEGA;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Dictionary<int, DCDBLIMFHGA> IJGCKGMDFOL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool LBJDPJCAJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x617F780", Offset = "0x617E380", VA = "0x18617F780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<OICGCFPGCCD> HDBDLCKDLNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6180D50", Offset = "0x617F950", VA = "0x186180D50")]
		get
		{
			return default(NativeList<OICGCFPGCCD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static DCDBLIMFHGA FPFKBBMAKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6180B30", Offset = "0x617F730", VA = "0x186180B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6180410", Offset = "0x617F010", VA = "0x186180410")]
	private static void IDEAFEMNMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6180A20", Offset = "0x617F620", VA = "0x186180A20")]
	public static int INEPIBLGBIM(bool MPEBBAHFDAL, int HEOLFIBLGJC, bool FCFDEOKIMKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x617F800", Offset = "0x617E400", VA = "0x18617F800")]
	private static int BKIMHMGLODL(int HEOLFIBLGJC, bool KIBBHMCIBLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x617FAB0", Offset = "0x617E6B0", VA = "0x18617FAB0")]
	private static int CIFFLCPENOB(int HEOLFIBLGJC, bool KIBBHMCIBLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6180A80", Offset = "0x617F680", VA = "0x186180A80")]
	public static int KOJFCIBJNGA(int BFGFFBDCNOA, int HEOLFIBLGJC, int BHHMEGDIMEH, bool KIBBHMCIBLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6180380", Offset = "0x617EF80", VA = "0x186180380")]
	public static int GFMNGODMCBJ(int BFGFFBDCNOA, int HEOLFIBLGJC, int BHHMEGDIMEH, bool KIBBHMCIBLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x617FF60", Offset = "0x617EB60", VA = "0x18617FF60")]
	public static int FEFKHKEBALF(int BHHMEGDIMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6180A50", Offset = "0x617F650", VA = "0x186180A50")]
	private static int KBJJAJHPICD(int HEOLFIBLGJC, bool KIBBHMCIBLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6180A60", Offset = "0x617F660", VA = "0x186180A60")]
	private static int KLBCDPKDPLG(int HEOLFIBLGJC, bool KIBBHMCIBLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x617FBB0", Offset = "0x617E7B0", VA = "0x18617FBB0")]
	public static int DLCJBDDLLMC(int BFGFFBDCNOA, int HEOLFIBLGJC, int BHHMEGDIMEH, bool KIBBHMCIBLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6180BD0", Offset = "0x617F7D0", VA = "0x186180BD0")]
	public static int NBACOAJIKJK(int BFGFFBDCNOA, int HEOLFIBLGJC, int BHHMEGDIMEH, bool KIBBHMCIBLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6180B10", Offset = "0x617F710", VA = "0x186180B10")]
	public static int LLMGMLMOBCD(int BHHMEGDIMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6180C60", Offset = "0x617F860", VA = "0x186180C60")]
	public static DCDBLIMFHGA NFPLFPJPOOD(int HEOLFIBLGJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x617F820", Offset = "0x617E420", VA = "0x18617F820")]
	private static DCDBLIMFHGA BPFEGKCJHGF(int HEOLFIBLGJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x617FAC0", Offset = "0x617E6C0", VA = "0x18617FAC0")]
	public static DCDBLIMFHGA DDGFBGLPJDF(int HEOLFIBLGJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x617FC20", Offset = "0x617E820", VA = "0x18617FC20")]
	private static DCDBLIMFHGA EPIHKNFJBLA(int HEOLFIBLGJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x617FF70", Offset = "0x617EB70", VA = "0x18617FF70")]
	public static void FPPJCPGAMEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct ENLJMKNMNJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int BCCMFHGFFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3 MBIHOEEHOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public quaternion KOJJLJBMNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float BOKKLPDLJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float IGFIHPFLOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int PGHAADBAFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int DEHFKEFKIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int NGOBEGJDHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool EBPILDNHBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool OKIBEFJAEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float MHJLDMGGADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 FCFBNGCIDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool POGLKKGOEKN;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ONCHPBPOKOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int FNFEJCHGGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int OKEAFAAKPMA;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct KKIBILPCHNJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeList<ENLJMKNMNJC> PHNMNKNHFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<JKGAAGKIBDH> DHLFPMLNIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeArray<OICGCFPGCCD> APPMEMAOGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeArray<ONCHPBPOKOP> KDAFEDKDHCE;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x618CFF0", Offset = "0x618BBF0", VA = "0x18618CFF0")]
	public KKIBILPCHNJ(NativeArray<JKGAAGKIBDH> DHLFPMLNIHN, int JKNAAACFMKJ = 1, Allocator AIHLFFHGGIO = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x618CF00", Offset = "0x618BB00", VA = "0x18618CF00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct OEFHHPAEHOL : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeArray<HIFMLCMPLKH> LDFNMKDPBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<int> NIICBIPNGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<OICGCFPGCCD> AJFDKPLMLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeList<ENLJMKNMNJC> PHNMNKNHFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<JKGAAGKIBDH> DHLFPMLNIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<OICGCFPGCCD> APPMEMAOGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	public NativeArray<ONCHPBPOKOP> KDAFEDKDHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private int BDAMEBGLONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private int GDKNADKLHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private float3 FAEFFKADIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private quaternion CHKICBCCBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private float3 DACAOIAPDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OIBBPKMBCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> KJKBFPGOONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PADMLIKPAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HGKLBAMOCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> OJMLADCHBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> HKHDENNFIEK;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6194BD0", Offset = "0x61937D0", VA = "0x186194BD0")]
	public OEFHHPAEHOL(IGNFHCBPGKH NGHGPPIGENC, KGMILHEBHMD DDLFJLABNJM, float3 BOBMNMOEEMK, quaternion KJMMJENJFOF, float AJCDNAMEOGC, int NKJPFPBCJAE = 0, int GEDMGEGDOAE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6194E60", Offset = "0x6193A60", VA = "0x186194E60")]
	public OEFHHPAEHOL(KKIBILPCHNJ NGHGPPIGENC, KGMILHEBHMD DDLFJLABNJM, float3 BOBMNMOEEMK, quaternion KJMMJENJFOF, float3 AJCDNAMEOGC, int NKJPFPBCJAE = 0, int GEDMGEGDOAE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6192C50", Offset = "0x6191850", VA = "0x186192C50")]
	private float3 AANPFIBAIFI(float3 EHNHCKABNHO, Matrix4x4 BLKGPMCDBBA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6194B50", Offset = "0x6193750", VA = "0x186194B50")]
	private float3x3 OCGDNMNBMMA(float3x3 MHJBDEOPOAE, float3x3 KEGBDJMBOPH)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6194B40", Offset = "0x6193740", VA = "0x186194B40")]
	private float MIAODLNJGPC(float LFFGFMIPECK, float IJOOOKHGEAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61931E0", Offset = "0x6191DE0", VA = "0x1861931E0", Slot = "4")]
	public void Execute(int NOBCGKJBAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6194380", Offset = "0x6192F80", VA = "0x186194380")]
	private void HJKIHIECJAI(int GFJAMPGFCLL, float3 GMKEEAOHFFK, float3 JJMOIFJMOBF, float3 IPIBPFLONCL, float HAPMMMMDGHH, bool EFNAIOFBOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6192D80", Offset = "0x6191980", VA = "0x186192D80")]
	private void BPFOEKLNMBO(ENLJMKNMNJC PGILLAOLFFN, float3 IMBPOLOMLBB, float3x3 NLOMNLFGFKB, float LFFGFMIPECK, int ADANBEHKCNG, int MNLNCFKPCCB, int FMJNPCFOKBE, float OIHOENPAIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61944F0", Offset = "0x61930F0", VA = "0x1861944F0")]
	private void JFEJHLHKJEM(int GFJAMPGFCLL, int EOMCBBGJNGD, ENLJMKNMNJC PGILLAOLFFN, float3 IMBPOLOMLBB, float3x3 NLOMNLFGFKB, bool KILONBHPBNL, float LFFGFMIPECK, int NIELDNEFONC, int MDOLGHOGLCJ, int FMJNPCFOKBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct NPKNJJJLLBF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeList<OKMEEMIDHHI> JNCKPHCGLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NativeList<OICGCFPGCCD> KGAJEMIMLCM;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6192B60", Offset = "0x6191760", VA = "0x186192B60")]
	public NPKNJJJLLBF(int JKNAAACFMKJ, Allocator AIHLFFHGGIO = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6192AC0", Offset = "0x61916C0", VA = "0x186192AC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct EOJBBFCAKKD : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private enum OPFPDAGAHGD
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private NativeList<float3> PAMJKKFPCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private NativeArray<float3> GGILGEENJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	[ReadOnly]
	private NativeList<int> PILMCMNJOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeArray<int> FENFEFHGFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeArray<float4> JCFEIGJIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private NativeArray<float4> AMGOAIIIOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private NativeArray<float4> EGKFIHIIBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> KCJFNLHPINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private NativeList<OICGCFPGCCD> NLPIKGBKLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private NativeList<OKMEEMIDHHI> JNCKPHCGLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<OICGCFPGCCD> KGAJEMIMLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private int BDAMEBGLONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private int GDKNADKLHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OIBBPKMBCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> KJKBFPGOONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PADMLIKPAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HGKLBAMOCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> OJMLADCHBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> HKHDENNFIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private float3 DACAOIAPDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private quaternion CHKICBCCBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private float3 FAEFFKADIIJ;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6188530", Offset = "0x6187130", VA = "0x186188530")]
	public EOJBBFCAKKD(IGNFHCBPGKH NGHGPPIGENC, KGMILHEBHMD DDLFJLABNJM, float3 BOBMNMOEEMK, quaternion KJMMJENJFOF, float AJCDNAMEOGC, int NKJPFPBCJAE = 0, int GEDMGEGDOAE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6188720", Offset = "0x6187320", VA = "0x186188720")]
	public EOJBBFCAKKD(NPKNJJJLLBF KOMCCCIEHEA, KGMILHEBHMD DDLFJLABNJM, float3 BOBMNMOEEMK, quaternion KJMMJENJFOF, float3 AJCDNAMEOGC, int NKJPFPBCJAE = 0, int GEDMGEGDOAE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6187120", Offset = "0x6185D20", VA = "0x186187120", Slot = "4")]
	public void Execute(int NOBCGKJBAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6188080", Offset = "0x6186C80", VA = "0x186188080")]
	private void JNKIEABLNDK(float4x4 LEENMBMBCHM, int NOBCGKJBAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6188480", Offset = "0x6187080", VA = "0x186188480")]
	private OPFPDAGAHGD MNGACNGLJND(float3 JJMOIFJMOBF)
	{
		return default(OPFPDAGAHGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6188430", Offset = "0x6187030", VA = "0x186188430")]
	private float4 LLJFKFMDAGC(OPFPDAGAHGD EEICHFIGMLH, int PMIDLPOCCEE)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x61884F0", Offset = "0x61870F0", VA = "0x1861884F0")]
	private float2 PODKJLAJANJ(OPFPDAGAHGD EEICHFIGMLH, float3 GMKEEAOHFFK)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HJBMICDLEEM
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum FBOHDCGDBDO
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static HJBMICDLEEM ONLHDLNPPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float3 KMIPHHDCLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3x3 BKMOBCFEIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 EDIMMLFINLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public FBOHDCGDBDO LLGILHFCKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 CDDPKMABPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 NBAHFIIPIEC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CBDMCJHEAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6189700", Offset = "0x6188300", VA = "0x186189700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 IKCNJIGBKHE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6188EF0", Offset = "0x6187AF0", VA = "0x186188EF0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6189880", Offset = "0x6188480", VA = "0x186189880")]
	public HJBMICDLEEM(float3 GMKEEAOHFFK, quaternion MJCNDCDLGEO, float3 JKNAAACFMKJ, FBOHDCGDBDO CJEAJMFMNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6189270", Offset = "0x6187E70", VA = "0x186189270")]
	public float DKPADCMBEOD(float3 IMBPOLOMLBB, float GNALCNMIHIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6188FD0", Offset = "0x6187BD0", VA = "0x186188FD0")]
	public bool BPNKDBNDJOG(float3 JJMOIFJMOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61890C0", Offset = "0x6187CC0", VA = "0x1861890C0")]
	public void CADDLFNJECN(float3 DKEMABLELKB, float3x3 NACOHDMFGGA, float EAKFEDKAJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6189710", Offset = "0x6188310", VA = "0x186189710")]
	private void IHCAAPCPCOJ(float3 HBOOGDGOIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6189470", Offset = "0x6188070", VA = "0x186189470")]
	public void GENNPAJBLJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct EEKPGEGPHMH : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private NativeList<HJBMICDLEEM> KOMCCCIEHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private NativeList<float3> LONJONBONDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private NativeList<int> BCDMFKFOCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> EFLEGBCCDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeList<OICGCFPGCCD> KGAJEMIMLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int EIAJFKOAABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int CNOPFPEBIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[ReadOnly]
	private float GNALCNMIHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[ReadOnly]
	private float GMBLIALADJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> LGENGJMPBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> ICNJAAOAHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> EKHJDLIGDOP;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6187080", Offset = "0x6185C80", VA = "0x186187080")]
	public EEKPGEGPHMH(KGMILHEBHMD PLPNPKIPEIA, float FIBFMLDENNC, int FAFMJOHFKBE, int ADANBEHKCNG, NativeList<HJBMICDLEEM> KOMCCCIEHEA, NativeArray<int> EFLEGBCCDHH, NativeList<OICGCFPGCCD> KGAJEMIMLCM, BAAKBJMPNGG BOCPECLDIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x61865E0", Offset = "0x61851E0", VA = "0x1861865E0", Slot = "4")]
	public void Execute(int ALCDIMKEADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6186D20", Offset = "0x6185920", VA = "0x186186D20")]
	private bool OEAGJMDOIOC(HJBMICDLEEM PKCAMDKHNLN, HJBMICDLEEM ECIMPLOCMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6186DE0", Offset = "0x61859E0", VA = "0x186186DE0")]
	private bool OIOOJGNEJDA(HJBMICDLEEM MDPDLOKKCJD, int FDADFCDDFOD, int CLBHBEJACIE, int FLCJHFDOIFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BAAKBJMPNGG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public NativeArray<bool> DNMEJEBCJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeArray<int> DJJCDDNLGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<bool> MKAEOIBCKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float> BIAKFLMNEEG;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x617F440", Offset = "0x617E040", VA = "0x18617F440")]
	public void FEFGOMAJBOH(int MFDAKGOOJAL, int AIBNJIIJOPG, Allocator AIHLFFHGGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x617F420", Offset = "0x617E020", VA = "0x18617F420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x617F540", Offset = "0x617E140", VA = "0x18617F540")]
	public void PCCPCKIFLJO(JobHandle JAJDCBMGAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public BAAKBJMPNGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[BurstCompile]
public struct JFAAOJLLJFP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NativeList<float3> LONJONBONDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private NativeArray<float3> JBPCJGMBMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private NativeArray<float4> LKBFJJNEFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NativeArray<float2> JDMCKBGMLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private NativeList<int> BCDMFKFOCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LFBCKMHJANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private NativeArray<int> GFDOHBKPKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[ReadOnly]
	private NativeArray<bool> LGENGJMPBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[ReadOnly]
	private NativeArray<bool> ICNJAAOAHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[ReadOnly]
	private int NKJPFPBCJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private int GEDMGEGDOAE;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x618BB10", Offset = "0x618A710", VA = "0x18618BB10")]
	public JFAAOJLLJFP(KGMILHEBHMD PLPNPKIPEIA, BAAKBJMPNGG BOCPECLDIAH, int GEDMGEGDOAE = 0, int NKJPFPBCJAE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x618B730", Offset = "0x618A330", VA = "0x18618B730", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x618B6D0", Offset = "0x618A2D0", VA = "0x18618B6D0")]
	private void DOCLHKKADBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class PLKNIBMAAKA
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2959670", Offset = "0x2958270", VA = "0x182959670")]
	public static bool EALODPLANOD<T>(NativeArray<T> GBCEGNLFFAN, int JKNAAACFMKJ, Allocator AIHLFFHGGIO, NativeArrayOptions JAIAHAGCBLM = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x29597B0", Offset = "0x29583B0", VA = "0x1829597B0")]
	public static bool EALODPLANOD<T>(NativeList<T> GPOHBJENHCE, int JKNAAACFMKJ, Allocator AIHLFFHGGIO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum KFDHMOGJMKH
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Force0,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Force1,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Force2
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BALMBPFCHAP
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CALHMJGFNGI(KFDHMOGJMKH BFGFFBDCNOA);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int LPMHKBEOILL(KFDHMOGJMKH BFGFFBDCNOA);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds FOGIJOIHHON();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IHNKOFHEKGB(KFDHMOGJMKH BFGFFBDCNOA, IGNFHCBPGKH BKHBJBAPFGN, int LADCOOJLAFA = -1);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KGMILHEBHMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public const int JMCBJGFMKAA = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<float3> GBBFCOFOOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<float3> GGIOKFFICEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float4> NAGIHIENLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float4> DMLALOOEHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeArray<float2> CLLAABHAJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<int> BOBJAGLHMOO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool PGNAFHIBNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x618CB70", Offset = "0x618B770", VA = "0x18618CB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MFDEBNGOCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x618C880", Offset = "0x618B480", VA = "0x18618C880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int NNHLAMNFCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x618CBB0", Offset = "0x618B7B0", VA = "0x18618CBB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MCOGMBNPCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x618C8C0", Offset = "0x618B4C0", VA = "0x18618C8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x618BF70", Offset = "0x618AB70", VA = "0x18618BF70", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x618C080", Offset = "0x618AC80", VA = "0x18618C080")]
	public void FEFGOMAJBOH(int MFDAKGOOJAL, int AIBNJIIJOPG, Allocator AIHLFFHGGIO, bool BHKIGLOGNIO, bool PCJOOICMKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x618CC50", Offset = "0x618B850", VA = "0x18618CC50")]
	public void NHEHIMMEOAA(int MFDAKGOOJAL, int AIBNJIIJOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x618BB90", Offset = "0x618A790", VA = "0x18618BB90", Slot = "6")]
	public bool BJCNDFJNHMG(Mesh PLPNPKIPEIA, bool PFBLPNINLNM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x618C250", Offset = "0x618AE50", VA = "0x18618C250")]
	public bool FKMNLPOPGCN(Mesh PLPNPKIPEIA, KGMILHEBHMD DDBDMCLGEEE, bool PFBLPNINLNM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x618C900", Offset = "0x618B500", VA = "0x18618C900")]
	public void LMHEHFAMFJF(KGMILHEBHMD PLPNPKIPEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x618CDC0", Offset = "0x618B9C0", VA = "0x18618CDC0")]
	public KGMILHEBHMD PLJCLLNOGIK(Allocator AIHLFFHGGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x618CCD0", Offset = "0x618B8D0", VA = "0x18618CCD0")]
	public long OBIOPNPNFGC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x618CBF0", Offset = "0x618B7F0", VA = "0x18618CBF0")]
	public void MPKIJAAEOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public KGMILHEBHMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class BDLEPFHACBF
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x617F630", Offset = "0x617E230", VA = "0x18617F630")]
	public static void FPPJCPGAMEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MFIMDBNLNJC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeList<float3> GBBFCOFOOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> GGIOKFFICEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<int> OJMNGNPCGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeArray<float4> KGPJDNNDLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeArray<float4> OIAEMBJJJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<float4> EHLLABDMCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<float3> NICJPANODPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<int> BOBJAGLHMOO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int MFDEBNGOCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x618D7B0", Offset = "0x618C3B0", VA = "0x18618D7B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NNHLAMNFCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x618DB30", Offset = "0x618C730", VA = "0x18618DB30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int CLBAGFDMPJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x618DAF0", Offset = "0x618C6F0", VA = "0x18618DAF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x618E000", Offset = "0x618CC00", VA = "0x18618E000")]
	public MFIMDBNLNJC(int MFDAKGOOJAL, int AIBNJIIJOPG, int IOOKBDAEKDN, Allocator AIHLFFHGGIO = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x618E220", Offset = "0x618CE20", VA = "0x18618E220")]
	public MFIMDBNLNJC(Mesh PLPNPKIPEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x618D120", Offset = "0x618BD20", VA = "0x18618D120", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x618D7F0", Offset = "0x618C3F0", VA = "0x18618D7F0")]
	public void LMHEHFAMFJF(MFIMDBNLNJC PLPNPKIPEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x618DB70", Offset = "0x618C770", VA = "0x18618DB70")]
	private void PGAOPPDBLFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x618D230", Offset = "0x618BE30", VA = "0x18618D230")]
	private void HEJMFPBEFGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct OICGCFPGCCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int DHKIDBFLGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int MFDEBNGOCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public int KCIEJLCGDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int NNHLAMNFCAA;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x123EF70", Offset = "0x123DB70", VA = "0x18123EF70")]
	public OICGCFPGCCD(int ADANBEHKCNG, int NFCHPGGEIFI, int FAFMJOHFKBE, int KKHAJNPICKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BJCLAOICFFI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<OICGCFPGCCD> LGBFCHDLHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x84DD40", Offset = "0x84C940", VA = "0x18084DD40")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<OICGCFPGCCD>);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x84DD30", Offset = "0x84C930", VA = "0x18084DD30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public MFIMDBNLNJC NNHGEGDJDED
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B40", Offset = "0x7B1740", VA = "0x1807B2B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6180FD0", Offset = "0x617FBD0", VA = "0x186180FD0")]
	public BJCLAOICFFI(IEnumerable<MFIMDBNLNJC> BKLBOKFCHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6180F60", Offset = "0x617FB60", VA = "0x186180F60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum IBGMNCLCKND
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class FEJJJAHJDPN
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static NativeArray<float2> LODLMGOADOL;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static NativeArray<float3> NJCBAEJIOKO;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static NativeArray<float4> JMGEBEHOJMO;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static NativeArray<int> ACPCNLBKJDJ;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6188A20", Offset = "0x6187620", VA = "0x186188A20")]
	public static void FPPJCPGAMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6188B40", Offset = "0x6187740", VA = "0x186188B40")]
	public static NativeArray<float2> GAMIFNBMLBF(NativeArray<float2> GANEBBFHCNL, int LKDDNLMOOCB, NativeArray<float2> GJNDMODPAIM, int DEIIGNBOLHN)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6188D60", Offset = "0x6187960", VA = "0x186188D60")]
	public static NativeArray<float3> MKMEPGGJILB(NativeArray<float3> GANEBBFHCNL, int LKDDNLMOOCB, NativeArray<float3> GJNDMODPAIM, int DEIIGNBOLHN)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6188C50", Offset = "0x6187850", VA = "0x186188C50")]
	public static NativeArray<float4> JKDKCJNFMGH(NativeArray<float4> GANEBBFHCNL, int LKDDNLMOOCB, NativeArray<float4> GJNDMODPAIM, int DEIIGNBOLHN)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6188910", Offset = "0x6187510", VA = "0x186188910")]
	public static NativeArray<int> BJGEJBAHKPM(NativeArray<int> GANEBBFHCNL, int LKDDNLMOOCB, NativeArray<int> GJNDMODPAIM, int DEIIGNBOLHN)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x27C17E0", Offset = "0x27C03E0", VA = "0x1827C17E0")]
	private static void PEFPJOMNPNE<T>(NativeArray<T> GBCEGNLFFAN, int BGDDEAPOKCC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x27C1730", Offset = "0x27C0330", VA = "0x1827C1730")]
	private static void BBOLOLEJCEA<T>(NativeArray<T> GANEBBFHCNL, int LKDDNLMOOCB, NativeArray<T> GJNDMODPAIM, int DEIIGNBOLHN, NativeArray<T> GDGLHLPOCAL) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BOJKIKCEFDN
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal enum CMGJLOANMCN
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Uninitialised,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		ExcludedNoLodNoMesh,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		ExcludedNoLodMeshData,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		ExcludedNoLodMeshDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		NoMesh,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		MeshLod0,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		MeshLod0WantsLod0Refresh,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		MeshLod0WantsRefresh,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		MeshLod0AllLodsInJob,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		MeshAllLods,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		MeshAllLodsWantsLod0Refresh,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		MeshAllLodsWantsRefresh
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class HFCKEMLICPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public NKMNJJABDMF PLPNPKIPEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int OBEAEBHONEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int NIPJJDALFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public float EDAIDLKGGNG;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6188EB0", Offset = "0x6187AB0", VA = "0x186188EB0")]
		public HFCKEMLICPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6188E70", Offset = "0x6187A70", VA = "0x186188E70")]
		public void PCCPCKIFLJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly string DNGEJDJPFJE;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly string PMHGBKLOLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly List<BALMBPFCHAP> KDKGIOJPFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly PMKDBMIPKGM IKNKGJBJGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int NFCHPGGEIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int KKHAJNPICKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private bool BPMLFKMNMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	internal bool FCPLJOLEBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	internal bool MMABEABMIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	internal CMGJLOANMCN KAADEKGDAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal float3 DFDMKBCCNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal float3 LFFKEDGMDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	internal float EHDIMFMMJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	internal int BFJPBJCILNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	internal int ADDJJOLCONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private int PLMIAAPJEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private float JLFHPFNOMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private float GEANMBAHJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int BJHNFJJGOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private long CLGAFKIFHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private long IPBKKHPCKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private long IAAELADCKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private int HINKPILPBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private KGMILHEBHMD MNLJDBCOGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private int AJBCAEGEEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private List<HFCKEMLICPP> COGEIPHBIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	internal float DLBLIBLECND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool DFDCIHPLLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private NIPMFFEMOPF BGPDCPOBFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private JobHandle OLAJABNNHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	internal NativeArray<long> FBMIPKJKIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool MBFKMGKDIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private JobHandle JNHHIMBOLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private KGMILHEBHMD KDEHMBBOAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Transform DHOPKKAAKEN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh NNHGEGDJDED
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B10", Offset = "0x7B1710", VA = "0x1807B2B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer LPLFABELNHF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5350", Offset = "0x7B3F50", VA = "0x1807B5350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int DOONCEPBDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7B0", Offset = "0xA4B3B0", VA = "0x180A4C7B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int MEFGGFKCDCH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7E7150", Offset = "0x7E5D50", VA = "0x1807E7150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int MFDEBNGOCEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6184330", Offset = "0x6182F30", VA = "0x186184330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<BALMBPFCHAP> LBPMOIPECJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6182520", Offset = "0x6181120", VA = "0x186182520")]
	public void FEBMAEMIJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6184AF0", Offset = "0x61836F0", VA = "0x186184AF0")]
	public void MMFALDLGJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6182A90", Offset = "0x6181690", VA = "0x186182A90")]
	public void FMFCCAEKEBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x61861E0", Offset = "0x6184DE0", VA = "0x1861861E0")]
	public BOJKIKCEFDN(string MPGNMPAPHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6185830", Offset = "0x6184430", VA = "0x186185830")]
	public void PCCPCKIFLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6185310", Offset = "0x6183F10", VA = "0x186185310")]
	public void OIPJHBLIHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6181C10", Offset = "0x6180810", VA = "0x186181C10")]
	public void DMJMJBHMGAO(BALMBPFCHAP GEFEMHNPNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6181590", Offset = "0x6180190", VA = "0x186181590")]
	private void AHMJAPIHKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x61829E0", Offset = "0x61815E0", VA = "0x1861829E0")]
	public bool FMBPJKBHLKE(BALMBPFCHAP GEFEMHNPNJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6182980", Offset = "0x6181580", VA = "0x186182980")]
	public bool FLAHJEGFLKH(BALMBPFCHAP GEFEMHNPNJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6181A30", Offset = "0x6180630", VA = "0x186181A30", Slot = "4")]
	public virtual void BNJCEEIKCHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6182B70", Offset = "0x6181770", VA = "0x186182B70")]
	public void GHKHCOCJAML(Transform KPJEKNECPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6181CF0", Offset = "0x61808F0", VA = "0x186181CF0")]
	public bool DNHMCLKDLCB(Transform KPJEKNECPLO, [Out] bool JBECPJGBKNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6182BE0", Offset = "0x61817E0", VA = "0x186182BE0")]
	public bool HEIOBIMLOEJ(bool PGPGIKKHINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6185280", Offset = "0x6183E80", VA = "0x186185280")]
	public void OIMBBLFECBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x61845E0", Offset = "0x61831E0", VA = "0x1861845E0")]
	public bool KPINMNIHGMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6183AD0", Offset = "0x61826D0", VA = "0x186183AD0")]
	public bool HHGIIDFOPEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6183A90", Offset = "0x6182690", VA = "0x186183A90")]
	public bool HFOFJGIEPGC(Transform NBNNMCCMOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6181B60", Offset = "0x6180760", VA = "0x186181B60")]
	public void CLLDINAPAIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6184350", Offset = "0x6182F50", VA = "0x186184350")]
	public bool JCOCIHPGACB(bool PGPGIKKHINF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6184C30", Offset = "0x6183830", VA = "0x186184C30")]
	public void NOHNIAIBNMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6184690", Offset = "0x6183290", VA = "0x186184690")]
	public void MAEMHBADFAM(KGMILHEBHMD PLPNPKIPEIA, int KKBBPGGGMDJ, float MPBJBAAHKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6184BD0", Offset = "0x61837D0", VA = "0x186184BD0")]
	public void NFMKHEJEJPI(NKMNJJABDMF KDPLEPAAMNN, int KKBBPGGGMDJ, float MPBJBAAHKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6184CB0", Offset = "0x61838B0", VA = "0x186184CB0")]
	public long OBIOPNPNFGC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7B1650", Offset = "0x7B0250", VA = "0x1807B1650")]
	public long DFMCEMMHHLM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6182680", Offset = "0x6181280", VA = "0x186182680")]
	public void FIEAHDECJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0xA810A0", Offset = "0xA7FCA0", VA = "0x180A810A0")]
	internal void DGNBHPNAICK(CMGJLOANMCN HOBPJFNGFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6182530", Offset = "0x6181130", VA = "0x186182530")]
	private void FFLKFGMHFGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6184CC0", Offset = "0x61838C0", VA = "0x186184CC0")]
	private float OEEBLOMJHAK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6185360", Offset = "0x6183F60", VA = "0x186185360")]
	public void PCBAACHIDON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6184C00", Offset = "0x6183800", VA = "0x186184C00")]
	private void NNCOHKDDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6184400", Offset = "0x6183000", VA = "0x186184400")]
	private void JHCDFGDBJDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x61846C0", Offset = "0x61832C0", VA = "0x1861846C0")]
	private void MCGMGDAKIHG(KGMILHEBHMD LNJCODEHFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6181800", Offset = "0x6180400", VA = "0x186181800")]
	private void BLANEDEHLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6185900", Offset = "0x6184500", VA = "0x186185900")]
	private void PLJOPEMBKOE(KGMILHEBHMD PLPNPKIPEIA, NKMNJJABDMF KDPLEPAAMNN, int KKBBPGGGMDJ, float MPBJBAAHKMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal struct NIPMFFEMOPF : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct KNJJOMADNKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int HJDMGMLABBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public int MPDPCEHMOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int CIOMOKHGEKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int HPGGCLLJBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int COFCAJKODBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int PAGNBHCADLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int OBEAEBHONEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int NIPJJDALFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float EDAIDLKGGNG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private struct CKDIMMBNCEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public NativeArray<float3> GBBFCOFOOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public NativeArray<float3> GGIOKFFICEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public NativeArray<float4> NAGIHIENLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public NativeArray<float4> DMLALOOEHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public NativeArray<float2> CLLAABHAJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public NativeArray<int> BOBJAGLHMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public bool IAGEPHEHKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int MFDEBNGOCEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int NNHLAMNFCAA;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6199550", Offset = "0x6198150", VA = "0x186199550")]
		public void FEFGOMAJBOH(int MFDAKGOOJAL, int AIBNJIIJOPG, Allocator AIHLFFHGGIO, bool PCJOOICMKLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6199300", Offset = "0x6197F00", VA = "0x186199300")]
		public static CKDIMMBNCEA FDNMHPIKPMH(KGMILHEBHMD PHEFBNNJAMO)
		{
			return default(CKDIMMBNCEA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x61996A0", Offset = "0x61982A0", VA = "0x1861996A0")]
		public void PCCPCKIFLJO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<KNJJOMADNKM> JJEAFAHNKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private CKDIMMBNCEA HNLJJANJGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private CKDIMMBNCEA LNJCODEHFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private float3 LPNHPHNFIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private float3 GHIDNPDHEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* DAKNMKLKPMD;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x618FF70", Offset = "0x618EB70", VA = "0x18618FF70")]
	public NIPMFFEMOPF([In] List<BOJKIKCEFDN.HFCKEMLICPP> HGLJCAHKLHG, [In] KGMILHEBHMD DPPADKCNACG, [In] BOJKIKCEFDN JGHAIDIEEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x618E510", Offset = "0x618D110", VA = "0x18618E510", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x618FCB0", Offset = "0x618E8B0", VA = "0x18618FCB0")]
	public void OBIJDGHNOIM(List<BOJKIKCEFDN.HFCKEMLICPP> KICIPNKOIGL, [In] BOJKIKCEFDN JGHAIDIEEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x618FBC0", Offset = "0x618E7C0", VA = "0x18618FBC0")]
	private bool MHCGJKJHKMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x618FBE0", Offset = "0x618E7E0", VA = "0x18618FBE0")]
	private NKMNJJABDMF NNNJGGJEHEJ(int PKPGFEBNDMK, Allocator AIHLFFHGGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x618E520", Offset = "0x618D120", VA = "0x18618E520")]
	private void FEDDBLJDLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x618F7E0", Offset = "0x618E3E0", VA = "0x18618F7E0")]
	private KNJJOMADNKM GLMMEFPABBI([In] KNJJOMADNKM LJCPCFFMICE, int BJFBDPDOALD, [In] NativeArray<int> BCDMFKFOCMN, [In] NativeArray<bool> ICNJAAOAHLG, NativeArray<int> OGMKKKIKKCP)
	{
		return default(KNJJOMADNKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x618FB00", Offset = "0x618E700", VA = "0x18618FB00")]
	private static int MCIEJMOHEJJ(NativeArray<int> BCDMFKFOCMN, int NBINDFDADOO, int HMNMELEPBJL, int NOCCKEMNHNM)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly ProfilerMarker PNIAIIBHHKN;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly ProfilerMarker KHALOKEEKCM;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private static readonly ProfilerMarker NNEBEBGMEKI;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		internal const int JCEINOLAMCJ = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private Dictionary<Material, List<BOJKIKCEFDN>> HHJACAOLICP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		internal List<BOJKIKCEFDN> IPIBPOGLAMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private List<MeshRenderer> PPBEKMJLEGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private bool FBCJNMCNCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private int MCMECPCLMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private Dictionary<int, float> EFLKHGHHIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private Dictionary<int, Color> JMJOILLGHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private Dictionary<int, Vector4> JFHEHEGFDNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private Dictionary<int, Matrix4x4> CCILLKKJOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private BOJKIKCEFDN EHJJJAOHIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Material EIFIFCMCNMD;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> DDNGMFFFLKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int NNCNAEHMGAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x61992B0", Offset = "0x6197EB0", VA = "0x1861992B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x61968B0", Offset = "0x61954B0", VA = "0x1861968B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6195360", Offset = "0x6193F60", VA = "0x186195360")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6195180", Offset = "0x6193D80", VA = "0x186195180")]
		public BOJKIKCEFDN AddToBatchedMesh(BALMBPFCHAP PHEGGKIBLHN, Material PKJODJFPANA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6198550", Offset = "0x6197150", VA = "0x186198550")]
		public void RemoveFromBatchedMesh(BALMBPFCHAP PLPNPKIPEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6195230", Offset = "0x6193E30", VA = "0x186195230")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6198690", Offset = "0x6197290", VA = "0x186198690")]
		public void SetMaterialProperty(int ANECPNCIKED, Color IFKECNAKMLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6198B20", Offset = "0x6197720", VA = "0x186198B20")]
		public void SetMaterialProperty(int ANECPNCIKED, float BLKAHBIJBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6198D40", Offset = "0x6197940", VA = "0x186198D40")]
		public void SetMaterialProperty(int ANECPNCIKED, Vector4 JFFPAOCPNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x61988C0", Offset = "0x61974C0", VA = "0x1861988C0")]
		public void SetMaterialProperty(int ANECPNCIKED, Matrix4x4 PDFBODIEKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x61958B0", Offset = "0x61944B0", VA = "0x1861958B0")]
		private void OANFDOHLNEG(Renderer AFGILNBALBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6195520", Offset = "0x6194120", VA = "0x186195520")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6195220", Offset = "0x6193E20", VA = "0x186195220")]
		private void BMDKLELGKOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6195EA0", Offset = "0x6194AA0", VA = "0x186195EA0")]
		private void ODHPONFJPLF(bool NPEKJIHGBEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x61962A0", Offset = "0x6194EA0", VA = "0x1861962A0")]
		private BOJKIKCEFDN OIEAMEGJEPM(BALMBPFCHAP PLPNPKIPEIA, Material PKJODJFPANA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6195530", Offset = "0x6194130", VA = "0x186195530")]
		private BOJKIKCEFDN GKEHCPFCOIK(Material PKJODJFPANA, int JLPGLNIFJKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x61964B0", Offset = "0x61950B0", VA = "0x1861964B0")]
		private BOJKIKCEFDN OPDJGLPKGOA(Material PKJODJFPANA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1737CD0", Offset = "0x17368D0", VA = "0x181737CD0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6195750", Offset = "0x6194350", VA = "0x186195750")]
		public void MarkDirty(BALMBPFCHAP PLPNPKIPEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6197D70", Offset = "0x6196970", VA = "0x186197D70")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6195730", Offset = "0x6194330", VA = "0x186195730")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6196BA0", Offset = "0x61957A0", VA = "0x186196BA0")]
		public void RebatchOptimally()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6199040", Offset = "0x6197C40", VA = "0x186199040")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JMOIDIGDBFG
{
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static bool NICFIHFPAJL;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static Vector3 IKPCKGFHECP;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static int JAEMPBFCOCN;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int PDMAGFBCKKA;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int HDJDCJAJPBC;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int GAGJOCIMHLK;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static List<BatchedMeshRenderer> BJHINPILNKE;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool CFBNCNOBLAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6199760", Offset = "0x6198360", VA = "0x186199760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x619A530", Offset = "0x6199130", VA = "0x18619A530")]
	public static void IKHOBAFCBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x619A9F0", Offset = "0x61995F0", VA = "0x18619A9F0")]
	public static void PBGODCOBKHG(BatchedMeshRenderer AIAMCHHJCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x619A6C0", Offset = "0x61992C0", VA = "0x18619A6C0")]
	public static void KKGIPPPBDJG(BatchedMeshRenderer AIAMCHHJCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6199910", Offset = "0x6198510", VA = "0x186199910")]
	public static void HHGIIDFOPEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x619A760", Offset = "0x6199360", VA = "0x18619A760")]
	public static void LKAOPGCEBHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6199820", Offset = "0x6198420", VA = "0x186199820")]
	public static int DOMIMMGJDFF()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NCFGBPJMKJM<KeyType> : BOJKIKCEFDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<KeyType, BALMBPFCHAP> JLBGMFOBOBE;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3A60", Offset = "0x3EE2660", VA = "0x183EE3A60")]
	public NCFGBPJMKJM(string MPGNMPAPHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3770", Offset = "0x3EE2370", VA = "0x183EE3770")]
	public void DMJMJBHMGAO(KeyType CGGNJKGENIH, BALMBPFCHAP GEFEMHNPNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3EE38A0", Offset = "0x3EE24A0", VA = "0x183EE38A0")]
	public bool EJGBKFFICKP(KeyType CGGNJKGENIH, BALMBPFCHAP CLBAFDKOFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3680", Offset = "0x3EE2280", VA = "0x183EE3680")]
	public void AFKOBOAMDPC(KeyType CGGNJKGENIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3730", Offset = "0x3EE2330", VA = "0x183EE3730", Slot = "4")]
	public override void BNJCEEIKCHJ()
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
