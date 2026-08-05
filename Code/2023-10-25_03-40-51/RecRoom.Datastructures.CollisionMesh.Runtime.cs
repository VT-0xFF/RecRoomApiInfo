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
public struct DDONGDFHLCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MDCHFANKFEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int BIDOOPJLCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int PHGOKJNOJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int IBFPGEFBIKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int PHOHLEAHLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int EGLPIKHDCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int AFLGELEOCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 INBDJNHAONI;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5C4C9E0", Offset = "0x5C4B7E0", VA = "0x185C4C9E0")]
		public MDCHFANKFEG(int FPKKCLIAKEE, int CNNECDAAIFE, int MLHPDBLHNAP, int FPJPIFOEIAM, int ACNLNMBHFKE, int DKCGNPGCNKH, float3 ABLMGKFECDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct OAFHOBJIELB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int AGIKFLCLFIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int CLIDFFODFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float IAAHKEJOHLO;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE99280", Offset = "0xE98080", VA = "0x180E99280")]
		public OAFHOBJIELB(int ADKJANDCMME, int JHLLJPIPCOH, float GBNHGJEMKMH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct LEGJALMGGID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int CLIDFFODFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int PFPKBACMIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int JAGFOCHOMBE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, MDCHFANKFEG> BDEOICGGCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<OAFHOBJIELB> BDOOHMMBANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> FOEHKEMHMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<LEGJALMGGID> PJDAGMOPECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> IOEFBJKNHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int OGKBKFPDCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int GABBGEPPGIC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5C49910", Offset = "0x5C48710", VA = "0x185C49910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5C49E00", Offset = "0x5C48C00", VA = "0x185C49E00")]
	public bool FJLFBDGKJLM([In] NativeArray<float3> KABIIFBODMG, NativeList<float3> ODIDGIGCLGO, NativeList<int> FEIMIFBBIKL, Allocator MBGJLDPPIJN, CancellationToken BCCDJHNACKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5C49F40", Offset = "0x5C48D40", VA = "0x185C49F40")]
	private void HCKCHEHGBKI([In] NativeArray<float3> KABIIFBODMG, Allocator MBGJLDPPIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5C4A700", Offset = "0x5C49500", VA = "0x185C4A700")]
	private void JIHFIACMLFJ([In] NativeArray<float3> KABIIFBODMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5C4BE80", Offset = "0x5C4AC80", VA = "0x185C4BE80")]
	private void MPBPLAFDEEA([In] NativeArray<float3> KABIIFBODMG, [Out] int CHGKFMDEIDB, [Out] int GDDAICIFGOJ, [Out] int KICFEDDADPP, [Out] int CNJAKLPOINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5C490B0", Offset = "0x5C47EB0", VA = "0x185C490B0")]
	private void AJDKCLCDKEE([In] NativeArray<float3> KABIIFBODMG, Allocator MBGJLDPPIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5C4C410", Offset = "0x5C4B210", VA = "0x185C4C410")]
	private void PJOGIDDNHBH([In] NativeArray<float3> KABIIFBODMG, float3 HPBLMHBHKBO, int PFOOLMOCKBI, MDCHFANKFEG FNCGIBIIFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5C4B740", Offset = "0x5C4A540", VA = "0x185C4B740")]
	private void KKMOCFBJBAA([In] NativeArray<float3> KABIIFBODMG, float3 HPBLMHBHKBO, int APHGAEKFJOJ, int GABBGEPPGIC, MDCHFANKFEG FNCGIBIIFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5C49310", Offset = "0x5C48110", VA = "0x185C49310")]
	private void CAFOPICJOKO([In] NativeArray<float3> KABIIFBODMG, int KIIOHPOLOOA, Allocator MBGJLDPPIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5C4BB10", Offset = "0x5C4A910", VA = "0x185C4BB10")]
	private void KLBLEOGHGKK([In] NativeArray<float3> KABIIFBODMG, Allocator MBGJLDPPIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5C4A230", Offset = "0x5C49030", VA = "0x185C4A230")]
	private void JDDIEMLCECM([In] NativeArray<float3> KABIIFBODMG, NativeList<float3> ODIDGIGCLGO, NativeList<int> FEIMIFBBIKL, Allocator MBGJLDPPIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C49D40", Offset = "0x5C48B40", VA = "0x185C49D40")]
	private float EDMELLANJHE(float3 HPBLMHBHKBO, float3 DAONPPJFFCJ, MDCHFANKFEG FNCGIBIIFEO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5C4A120", Offset = "0x5C48F20", VA = "0x185C4A120")]
	private float3 INBDJNHAONI(float3 FPKKCLIAKEE, float3 CNNECDAAIFE, float3 MLHPDBLHNAP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5C4B710", Offset = "0x5C4A510", VA = "0x185C4B710")]
	private static float JPFNNHFNNDG(float3 APOJANFJHJO, float3 DFBIFCHBAHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5C49DA0", Offset = "0x5C48BA0", VA = "0x185C49DA0")]
	private static float3 FEEIJNNFEDI(float3 APOJANFJHJO, float3 DFBIFCHBAHF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5C492B0", Offset = "0x5C480B0", VA = "0x185C492B0")]
	private bool BMBMHKPIIOG(float3 APOJANFJHJO, float3 DFBIFCHBAHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5C4C340", Offset = "0x5C4B140", VA = "0x185C4C340")]
	private bool NNCMGPJMELE(float3 APOJANFJHJO, float3 DFBIFCHBAHF, float3 BOGFMIDGHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5C49A50", Offset = "0x5C48850", VA = "0x185C49A50")]
	private bool EBKDHMMFOMA(float3 APOJANFJHJO, float3 DFBIFCHBAHF, float3 BOGFMIDGHHG, float3 GBNHGJEMKMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct AMFCHNELFFI : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct JJAKDECGPCI
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
	private NativeList<float3> GEPIDDLIOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> OPIAENPEFPK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JPMFIFJILOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5C47C00", Offset = "0x5C46A00", VA = "0x185C47C00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JFECIOGOHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5C481B0", Offset = "0x5C46FB0", VA = "0x185C481B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NKLAIHGEKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5C48AB0", Offset = "0x5C478B0", VA = "0x185C48AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ICGDJBBPDHD OGFLHBKOGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5C48910", Offset = "0x5C47710", VA = "0x185C48910")]
		get
		{
			return default(ICGDJBBPDHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5C48FC0", Offset = "0x5C47DC0", VA = "0x185C48FC0")]
	public AMFCHNELFFI(int KMIEJOGGBHG, int GPJPFNCPHIK, Allocator MBGJLDPPIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C49080", Offset = "0x5C47E80", VA = "0x185C49080")]
	public AMFCHNELFFI(ICGDJBBPDHD PGBOLPDGBLI, Allocator MBGJLDPPIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C48AF0", Offset = "0x5C478F0", VA = "0x185C48AF0")]
	public AMFCHNELFFI(Mesh GIOOFAEFEGJ, Allocator MBGJLDPPIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C48C60", Offset = "0x5C47A60", VA = "0x185C48C60")]
	public AMFCHNELFFI(AMFCHNELFFI LMCJHCIOIIP, Allocator MBGJLDPPIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C47B70", Offset = "0x5C46970", VA = "0x185C47B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C47C40", Offset = "0x5C46A40", VA = "0x185C47C40")]
	public void EJEJBLJEAIN([In] AMFCHNELFFI PGGBKFCMLMO, float4x4 PENILBCOAKC, Transform JKKGDAMPLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C47FC0", Offset = "0x5C46DC0", VA = "0x185C47FC0")]
	public void GFFBHJKNEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C481F0", Offset = "0x5C46FF0", VA = "0x185C481F0")]
	public void LALPKLONBHG(float HGECKMNELOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C48710", Offset = "0x5C47510", VA = "0x185C48710")]
	public AMFCHNELFFI NFBDLEOPGIC(Allocator MBGJLDPPIJN, CancellationToken BCCDJHNACKO)
	{
		return default(AMFCHNELFFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C48990", Offset = "0x5C47790", VA = "0x185C48990")]
	public Mesh OMKBGDFLLKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5C48110", Offset = "0x5C46F10", VA = "0x185C48110")]
	private unsafe static float3* HMBJMGONKIC(NativeArray<float3> OBEMKDLNKLE)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C48160", Offset = "0x5C46F60", VA = "0x185C48160")]
	private unsafe static int* HMBJMGONKIC(NativeArray<int> OBEMKDLNKLE)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C486E0", Offset = "0x5C474E0", VA = "0x185C486E0")]
	[CompilerGenerated]
	internal static void LFNHCKBFAAB(int FKPEALCCBJD, int EIOCEKJIIOL, JJAKDECGPCI P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct ICGDJBBPDHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int JPMFIFJILOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int JFECIOGOHOK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FIMLMONJDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5C4C930", Offset = "0x5C4B730", VA = "0x185C4C930")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1B89040", Offset = "0x1B87E40", VA = "0x181B89040")]
	public static ICGDJBBPDHD JBOMEKIAFFI(ICGDJBBPDHD APOJANFJHJO, ICGDJBBPDHD DFBIFCHBAHF)
	{
		return default(ICGDJBBPDHD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5C4C8C0", Offset = "0x5C4B6C0", VA = "0x185C4C8C0")]
	public static ICGDJBBPDHD FBKNIKHNAHK(ICGDJBBPDHD POOGPMAGLDE, int JHBLIKOABFH)
	{
		return default(ICGDJBBPDHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5C4C870", Offset = "0x5C4B670", VA = "0x185C4C870", Slot = "0")]
	public override bool Equals(object JCDNIPOCGGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5C4C8E0", Offset = "0x5C4B6E0", VA = "0x185C4C8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5C4C940", Offset = "0x5C4B740", VA = "0x185C4C940", Slot = "3")]
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
