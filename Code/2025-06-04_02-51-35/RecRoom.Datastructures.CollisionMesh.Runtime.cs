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
public struct KGDGELIHGFO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct BOOCDJMDBBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int NLKALFHDCBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int LIDDOFGFANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int AOGIHFKABGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int BEANEHCPHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int LCHNEEAEOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int MCKJJHEDDKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 EAOKBEELIFC;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F5BF70", Offset = "0x7F5A770", VA = "0x187F5BF70")]
		public BOOCDJMDBBI(int MHNGFMELCEP, int ANPHCPJJGOJ, int MPMMLNOGKFE, int DJEIAABPBDL, int IOPKMDHLPKC, int JGIKBHNENIC, float3 IILAMILCBNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct LKPCEEFMAMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int IENCJOBLHBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int GOONHBFAEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float HHBFOEHNLMA;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD3A190", Offset = "0xD38990", VA = "0x180D3A190")]
		public LKPCEEFMAMD(int LNKCJPMONLM, int JGAIBBPIAMP, float ABKKFEKEEMG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct AHFIDLJNHNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int GOONHBFAEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int IDMOCNPHLND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int PKJPGKLGKCH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, BOOCDJMDBBI> CIKHIKOHNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<LKPCEEFMAMD> AOIFOPCDBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> MAKKOCNAKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<AHFIDLJNHNN> HCBHBNLOLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> IBCKMAEKENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int MIEAKGBCIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int KLIDKHNFFIB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D1D0", Offset = "0x7F5B9D0", VA = "0x187F5D1D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7F5EBE0", Offset = "0x7F5D3E0", VA = "0x187F5EBE0")]
	public bool MFLACDEIGMO([In] NativeArray<float3> LOKMNLFMMKF, NativeList<float3> AFOMPMKEHIO, NativeList<int> NDLIBHEDOED, Allocator GFNKGIEEHMD, CancellationToken GMEAHOBHMAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DD30", Offset = "0x7F5C530", VA = "0x187F5DD30")]
	private void IEAMPCKAMFG([In] NativeArray<float3> LOKMNLFMMKF, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C180", Offset = "0x7F5A980", VA = "0x187F5C180")]
	private void CFGKMHBDELK([In] NativeArray<float3> LOKMNLFMMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E720", Offset = "0x7F5CF20", VA = "0x187F5E720")]
	private void KABPAPJCMGA([In] NativeArray<float3> LOKMNLFMMKF, [Out] int GCMOINCHLFP, [Out] int CEEHOFNAMLO, [Out] int DMOJCOKDLFI, [Out] int JOEBDNAJPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E3F0", Offset = "0x7F5CBF0", VA = "0x187F5E3F0")]
	private void JDNOOPFOOBM([In] NativeArray<float3> LOKMNLFMMKF, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DF10", Offset = "0x7F5C710", VA = "0x187F5DF10")]
	private void JCOAKIINNOH([In] NativeArray<float3> LOKMNLFMMKF, float3 CLKNAHDABLK, int KFMMHMOIBFP, BOOCDJMDBBI EBOEGILCICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F200", Offset = "0x7F5DA00", VA = "0x187F5F200")]
	private void NCKPNOGDKFI([In] NativeArray<float3> LOKMNLFMMKF, float3 CLKNAHDABLK, int PHBDCBKHICJ, int KLIDKHNFFIB, BOOCDJMDBBI EBOEGILCICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D730", Offset = "0x7F5BF30", VA = "0x187F5D730")]
	private void FPEBNJJFFEB([In] NativeArray<float3> LOKMNLFMMKF, int OBIIJPCPEGL, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F5F0", Offset = "0x7F5DDF0", VA = "0x187F5F5F0")]
	private void NHDEOIKGIIM([In] NativeArray<float3> LOKMNLFMMKF, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F5ED20", Offset = "0x7F5D520", VA = "0x187F5ED20")]
	private void NBKCNFNFBED([In] NativeArray<float3> LOKMNLFMMKF, NativeList<float3> AFOMPMKEHIO, NativeList<int> NDLIBHEDOED, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E5F0", Offset = "0x7F5CDF0", VA = "0x187F5E5F0")]
	private float JFCDNAAJEAP(float3 CLKNAHDABLK, float3 IHEJIIJPAMJ, BOOCDJMDBBI EBOEGILCICL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D310", Offset = "0x7F5BB10", VA = "0x187F5D310")]
	private float3 EAOKBEELIFC(float3 MHNGFMELCEP, float3 ANPHCPJJGOJ, float3 MPMMLNOGKFE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D1A0", Offset = "0x7F5B9A0", VA = "0x187F5D1A0")]
	private static float DGOPHGFCIFJ(float3 HBMOFOICGEH, float3 LDEEDNGKJOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C120", Offset = "0x7F5A920", VA = "0x187F5C120")]
	private static float3 AGKKHNOHEDH(float3 HBMOFOICGEH, float3 LDEEDNGKJOE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F960", Offset = "0x7F5E160", VA = "0x187F5F960")]
	private bool OFAKFBKPHKN(float3 HBMOFOICGEH, float3 LDEEDNGKJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E650", Offset = "0x7F5CE50", VA = "0x187F5E650")]
	private bool JFMIDAPNFLE(float3 HBMOFOICGEH, float3 LDEEDNGKJOE, float3 GJJIDOPGHFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D420", Offset = "0x7F5BC20", VA = "0x187F5D420")]
	private bool EMDMAGFGPOC(float3 HBMOFOICGEH, float3 LDEEDNGKJOE, float3 GJJIDOPGHFC, float3 ABKKFEKEEMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct BLIBPKCDEFE : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BIALMJAMONN
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
	private NativeList<float3> NBGMOBMDDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> AMAJJFAGHKC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KICNGCGAMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7F5AA60", Offset = "0x7F59260", VA = "0x187F5AA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HLNAFGKHLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F5AA20", Offset = "0x7F59220", VA = "0x187F5AA20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AGNMEGAEAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B840", Offset = "0x7F5A040", VA = "0x187F5B840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GOCBHDAGHEF EEEOEIBCLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B470", Offset = "0x7F59C70", VA = "0x187F5B470")]
		get
		{
			return default(GOCBHDAGHEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B9D0", Offset = "0x7F5A1D0", VA = "0x187F5B9D0")]
	public BLIBPKCDEFE(int GDOBIAAONDM, int KIHBHAHLAAI, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B9A0", Offset = "0x7F5A1A0", VA = "0x187F5B9A0")]
	public BLIBPKCDEFE(GOCBHDAGHEF OCIGIMEACAH, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F5BA90", Offset = "0x7F5A290", VA = "0x187F5BA90")]
	public BLIBPKCDEFE(Mesh MLCGFPJFGFN, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7F5BC00", Offset = "0x7F5A400", VA = "0x187F5BC00")]
	public BLIBPKCDEFE(BLIBPKCDEFE IMINNNCPCJF, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F5AAA0", Offset = "0x7F592A0", VA = "0x187F5AAA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7F5ABD0", Offset = "0x7F593D0", VA = "0x187F5ABD0")]
	public void GGGBGBDKNKJ([In] BLIBPKCDEFE BJNLPCOGDLM, float4x4 DJHJNAPODOP, Transform IDAPFNDMOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B6F0", Offset = "0x7F59EF0", VA = "0x187F5B6F0")]
	public void JMEAOMCILCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F5AF50", Offset = "0x7F59750", VA = "0x187F5AF50")]
	public void GIEFMDFLODL(float IOEOMGELKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B4F0", Offset = "0x7F59CF0", VA = "0x187F5B4F0")]
	public BLIBPKCDEFE INFNOEGDDEI(Allocator GFNKGIEEHMD, CancellationToken GMEAHOBHMAD)
	{
		return default(BLIBPKCDEFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B880", Offset = "0x7F5A080", VA = "0x187F5B880")]
	public Mesh PMILKEDBPEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F5AB80", Offset = "0x7F59380", VA = "0x187F5AB80")]
	private unsafe static float3* FNBPLAAEGCJ(NativeArray<float3> LPBOBEPEKNH)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F5AB30", Offset = "0x7F59330", VA = "0x187F5AB30")]
	private unsafe static int* FNBPLAAEGCJ(NativeArray<int> LPBOBEPEKNH)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B440", Offset = "0x7F59C40", VA = "0x187F5B440")]
	[CompilerGenerated]
	internal static void HGPKEPIKBNN(int FKOHPLDLHLM, int MLCHPGBHIBL, BIALMJAMONN P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GOCBHDAGHEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int KICNGCGAMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int HLNAFGKHLJP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GPKHEHOFCAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C070", Offset = "0x7F5A870", VA = "0x187F5C070")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2751980", Offset = "0x2750180", VA = "0x182751980")]
	public static GOCBHDAGHEF LENELBPCALE(GOCBHDAGHEF HBMOFOICGEH, GOCBHDAGHEF LDEEDNGKJOE)
	{
		return default(GOCBHDAGHEF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7F5BFB0", Offset = "0x7F5A7B0", VA = "0x187F5BFB0")]
	public static GOCBHDAGHEF CKOHBIAJDGJ(GOCBHDAGHEF JIKKBEHCEFB, int IHGBDKLNHAA)
	{
		return default(GOCBHDAGHEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F5BFD0", Offset = "0x7F5A7D0", VA = "0x187F5BFD0", Slot = "0")]
	public override bool Equals(object MLODFFCDELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C020", Offset = "0x7F5A820", VA = "0x187F5C020", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C080", Offset = "0x7F5A880", VA = "0x187F5C080", Slot = "3")]
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
