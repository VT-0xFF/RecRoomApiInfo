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
public struct AGMGGOCBHPM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] IHCIINFIJHO;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] PMPHDDIOGJC;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] FJCGBABLCHC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xE061B0", Offset = "0xE04BB0", VA = "0x180E061B0")]
	public static int OKMKOHKHCMH(DDGHFMOBNGF NDBFPELDACP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6910490", Offset = "0x690EE90", VA = "0x186910490")]
	public static int CDOLONNDAIJ(DDGHFMOBNGF NDBFPELDACP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DOPJJLPGLLL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int AOICECDMPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PFKOFOBBIPL OGFALKIGBBF(int IADKDCBBENH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 JKIOHBGMMME(int IADKDCBBENH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DJBABNHKILH BILINODFLIJ();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MOPCEDKPDLM KOHEIJEAPDP();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GDOCHECPEEF : KEBDIMMNLOB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private DJBABNHKILH OFGHBAGNEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform HLNBNIAENHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<JHNHLALJAJC> CAFGIIIBJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private DGBLOOPPBBK LNJBGPIDJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private MANCDFPEGME EDCAEOJCKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool MHBFELIAFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private DOPJJLPGLLL KNEGOHJKFDD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float EPFNEGPNCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB20", Offset = "0x8BA520", VA = "0x1808BBB20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4930", Offset = "0xAA3330", VA = "0x180AA4930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DKOODEFELBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9B36A0", Offset = "0x9B20A0", VA = "0x1809B36A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9B3750", Offset = "0x9B2150", VA = "0x1809B3750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool IBBFILDGDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1228760", Offset = "0x1227160", VA = "0x181228760")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1228030", Offset = "0x1226A30", VA = "0x181228030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MJEGBBCINFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7C70", Offset = "0x5FB6670", VA = "0x185FB7C70", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7D00", Offset = "0x5FB6700", VA = "0x185FB7D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool JDFNNPDJPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x13D96E0", Offset = "0x13D80E0", VA = "0x1813D96E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6914510", Offset = "0x6912F10", VA = "0x186914510")]
	public GDOCHECPEEF(DOPJJLPGLLL OLNDJGIOKLA, bool LDIFICIDAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69134A0", Offset = "0x6911EA0", VA = "0x1869134A0")]
	private bool BFEIEPINJOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69136D0", Offset = "0x69120D0", VA = "0x1869136D0", Slot = "4")]
	public bool KODKNHDNNHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69132D0", Offset = "0x6911CD0", VA = "0x1869132D0", Slot = "5")]
	public bool AIFEINMMINP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69142E0", Offset = "0x6912CE0", VA = "0x1869142E0", Slot = "6")]
	public void PLMGPBLKDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69136C0", Offset = "0x69120C0", VA = "0x1869136C0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CBLBEFJJCOD
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIAACPANKMJ(CommandBuffer CPFKNKMCNPD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MGAHBALJLII : CBLBEFJJCOD
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int FOBLAHOCEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x92B7E0", Offset = "0x92A1E0", VA = "0x18092B7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier GGHCKMICHFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x424F3D0", Offset = "0x424DDD0", VA = "0x18424F3D0")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69178A0", Offset = "0x69162A0", VA = "0x1869178A0")]
	public MGAHBALJLII(int OBDGAAHPMCD, RenderTargetIdentifier EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6917850", Offset = "0x6916250", VA = "0x186917850", Slot = "4")]
	public void DIAACPANKMJ(CommandBuffer CPFKNKMCNPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct MEMKNGKNPEM : CBLBEFJJCOD
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int FOBLAHOCEHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x92B7E0", Offset = "0x92A1E0", VA = "0x18092B7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] KEHMLOGEKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4B0", Offset = "0x8BDEB0", VA = "0x1808BF4B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xD90010", Offset = "0xD8EA10", VA = "0x180D90010")]
	public MEMKNGKNPEM(int OBDGAAHPMCD, Vector4[] EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6917820", Offset = "0x6916220", VA = "0x186917820", Slot = "4")]
	public void DIAACPANKMJ(CommandBuffer CPFKNKMCNPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct BIHMMCJCPEI : CBLBEFJJCOD
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int FOBLAHOCEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x92B7E0", Offset = "0x92A1E0", VA = "0x18092B7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] GPBAHICMLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4B0", Offset = "0x8BDEB0", VA = "0x1808BF4B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xD90010", Offset = "0xD8EA10", VA = "0x180D90010")]
	public BIHMMCJCPEI(int OBDGAAHPMCD, float[] EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6911370", Offset = "0x690FD70", VA = "0x186911370", Slot = "4")]
	public void DIAACPANKMJ(CommandBuffer CPFKNKMCNPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct OPHEJGNLJMO : CBLBEFJJCOD
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string JGFOABOCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool CEPCMMODIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1B9A390", Offset = "0x1B98D90", VA = "0x181B9A390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3CF9B90", Offset = "0x3CF8590", VA = "0x183CF9B90")]
	public OPHEJGNLJMO(string CCMEKJGADHN, bool OPDIOPBPNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6920090", Offset = "0x691EA90", VA = "0x186920090", Slot = "4")]
	public void DIAACPANKMJ(CommandBuffer CPFKNKMCNPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct MOPCEDKPDLM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 ELBDAPKMNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 KHLKOAEHOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8C0BB0", Offset = "0x8BF5B0", VA = "0x1808C0BB0")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int DNBBKLLMEGA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3B0", Offset = "0x8B8DB0", VA = "0x1808BA3B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OEKLEOKCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x88BD30", Offset = "0x88A730", VA = "0x18088BD30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float KEFELLANGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB80", Offset = "0x8BA580", VA = "0x1808BBB80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6918C20", Offset = "0x6917620", VA = "0x186918C20")]
	public MOPCEDKPDLM(Color COGPPELINPO, int FLCFEMCIANH, int NCLOOEMMHHO, float HINJGEPMFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x92BA80", Offset = "0x92A480", VA = "0x18092BA80")]
	private static float4 IFHNHCEFOPH(Color COGPPELINPO)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6918B90", Offset = "0x6917590", VA = "0x186918B90")]
	private static Hash128 MBLIIJNBJAC(MOPCEDKPDLM OLNDJGIOKLA)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DGBLOOPPBBK : KEBDIMMNLOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string EDLPNCMHFBE;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string GKLDIDGFHGC;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string BIAIOHFMJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private MOPCEDKPDLM FDFPGFEEHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private EENKJJBDKNP OKNIOBAOHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 CINFEOGFDPE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MANCDFPEGME LMAJLICBHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x874170", Offset = "0x872B70", VA = "0x180874170")]
		[CompilerGenerated]
		get
		{
			return default(MANCDFPEGME);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xABEEF0", Offset = "0xABD8F0", VA = "0x180ABEEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DKOODEFELBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x592E260", Offset = "0x592CC60", VA = "0x18592E260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x592E270", Offset = "0x592CC70", VA = "0x18592E270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool IBBFILDGDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1F139E0", Offset = "0x1F123E0", VA = "0x181F139E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68A3D70", Offset = "0x68A2770", VA = "0x1868A3D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JDFNNPDJPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MJEGBBCINFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x59E5D50", Offset = "0x59E4750", VA = "0x1859E5D50", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6911EC0", Offset = "0x69108C0", VA = "0x186911EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int JCLKIAMNLIO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6911D20", Offset = "0x6910720", VA = "0x186911D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6912110", Offset = "0x6910B10", VA = "0x186912110")]
	public DGBLOOPPBBK(MOPCEDKPDLM JPPEKANEHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6911C10", Offset = "0x6910610", VA = "0x186911C10")]
	private bool BFEIEPINJOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6911D70", Offset = "0x6910770", VA = "0x186911D70", Slot = "4")]
	public bool KODKNHDNNHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6911ED0", Offset = "0x69108D0", VA = "0x186911ED0")]
	private static EENKJJBDKNP OIPLDPBBGHA(MOPCEDKPDLM OLNDJGIOKLA)
	{
		return default(EENKJJBDKNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6911A60", Offset = "0x6910460", VA = "0x186911A60", Slot = "5")]
	public bool AIFEINMMINP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6911F10", Offset = "0x6910910", VA = "0x186911F10", Slot = "6")]
	public void PLMGPBLKDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6916EB0", Offset = "0x69158B0", VA = "0x186916EB0", Slot = "0")]
		public override bool Equals(object HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x69170B0", Offset = "0x6915AB0", VA = "0x1869170B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBC0", Offset = "0x8BA5C0", VA = "0x1808BBBC0")]
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
		private LPNHCOBEKEA opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static OCNLAJAJEAI CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6917780", Offset = "0x6916180", VA = "0x186917780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x69177C0", Offset = "0x69161C0", VA = "0x1869177C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6917190", Offset = "0x6915B90", VA = "0x186917190", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6917160", Offset = "0x6915B60", VA = "0x186917160", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EBCGCCILOJN, RenderingData IGPOGEIHIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x69175F0", Offset = "0x6915FF0", VA = "0x1869175F0")]
		public void EPBJHENAKAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xD98FE0", Offset = "0xD979E0", VA = "0x180D98FE0")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class NKOCJEIKMJD<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CIEGPPBKECO FPGCBPDBNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private CIEGPPBKECO FNEFGNDEIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer AOBNIAHKJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture OHLKNBBPEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int KFNIHFNPEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int BFAHPGPGFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string MAHOAGALNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string GBLKMPJKLNJ;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x858B50", Offset = "0x857550", VA = "0x180858B50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int NOJJIOGDPDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xDB93C0", Offset = "0xDB7DC0", VA = "0x180DB93C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int IAGOGLJBNCG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86AB80", Offset = "0x869580", VA = "0x18086AB80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x44E7A40", Offset = "0x44E6440", VA = "0x1844E7A40")]
	public NKOCJEIKMJD(string CCMEKJGADHN, int FIFNLGKCAOG, [Optional] RenderTextureFormat? PHCNDPLEFBH, bool BOENAAAMMFM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x44E63E0", Offset = "0x44E4DE0", VA = "0x1844E63E0")]
	public void AIFEINMMINP(CommandBuffer CPFKNKMCNPD, NativeArray<ValType> EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x44E7100", Offset = "0x44E5B00", VA = "0x1844E7100")]
	public void NGGMPBJDGGI(CommandBuffer CPFKNKMCNPD, ComputeShader LBOPCPNGPAK, int KFPGJHPMPNL, int HENDCMLLGLM = -1, int GGKNHGKAOKJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x44E6E90", Offset = "0x44E5890", VA = "0x1844E6E90")]
	public void NGGMPBJDGGI(Material OKNIOBAOHHE, int HENDCMLLGLM = -1, int GGKNHGKAOKJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x44E6A10", Offset = "0x44E5410", VA = "0x1844E6A10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KCGHNBEODDN
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGGMPBJDGGI(Material JPPEKANEHBC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GDIMOEOCJBB<SrcEntry, DstEntry> : KCGHNBEODDN, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] PFMBLIIBILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected CIEGPPBKECO NCKAEGBOAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected CIEGPPBKECO MFKNMKNBMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> JLJDLJNNOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> BGJMBGDLMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int IIINPPAEKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int MPDDBCDIOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected NKOCJEIKMJD<int> CPFEKDCHLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected NKOCJEIKMJD<SrcEntry> HNDFOBPJEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected NKOCJEIKMJD<DstEntry> MBOBDPBMHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader PHDGGOFCCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int AHJFHEAAKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int EBFJACDADOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int PCGPKBLAICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int MJDOBGLFDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int OPIPEJADDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int HEBHFBCHMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int EHCLAPDGGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int PCNOBCMBJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int OAMAMBHIABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int IMMABIIDIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int BDOLMPBPNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int EEFBLDLGDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string INOAAOFMJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] DEHPCHBCJLP;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int JNJKJLALEKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3CFB530", Offset = "0x3CF9F30", VA = "0x183CFB530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string ENACDDFIMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3CFB250", Offset = "0x3CF9C50", VA = "0x183CFB250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC4C0", Offset = "0x3CFAEC0", VA = "0x183CFC4C0")]
	public GDIMOEOCJBB(string CCMEKJGADHN, int OLOGKDFEELF, int PLJDADCGLGA, RenderTextureFormat PHCNDPLEFBH, ComputeShader IJPOAHNLIDF, int OEOPMCNMMAC = 0, int JGNDHFEMMCD = 0, int IGADHANENCP = 0, int FHADMBGMJLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3CFAB80", Offset = "0x3CF9580", VA = "0x183CFAB80")]
	public int JGDGOEEMKPP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3CFBE90", Offset = "0x3CFA890", VA = "0x183CFBE90")]
	protected void OOGAAALIKDE(int ILOCEPPJPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3CFABF0", Offset = "0x3CF95F0", VA = "0x183CFABF0")]
	public MANCDFPEGME KODKNHDNNHA(SrcEntry EEOBDBMOHPL)
	{
		return default(MANCDFPEGME);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA790", Offset = "0x3CF9190", VA = "0x183CFA790")]
	public bool AIFEINMMINP(MANCDFPEGME AHCMMMOBCPP, SrcEntry EEOBDBMOHPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3CFBEE0", Offset = "0x3CFA8E0", VA = "0x183CFBEE0")]
	public bool PLMGPBLKDNE(MANCDFPEGME AHCMMMOBCPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "6")]
	protected virtual void KGLCHONOILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3CFBC20", Offset = "0x3CFA620", VA = "0x183CFBC20", Slot = "7")]
	public void NCONNDEFELK(CommandBuffer CPFKNKMCNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB8B0", Offset = "0x3CFA2B0", VA = "0x183CFB8B0", Slot = "8")]
	public void NCONNDEFELK(CommandBuffer CPFKNKMCNPD, ComputeShader IJPOAHNLIDF, int OEOPMCNMMAC = -1, int JGNDHFEMMCD = -1, int IGADHANENCP = -1, int FHADMBGMJLD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3CFBC80", Offset = "0x3CFA680", VA = "0x183CFBC80", Slot = "9")]
	public void NGGMPBJDGGI(CommandBuffer CPFKNKMCNPD, ComputeShader IJPOAHNLIDF, int OEOPMCNMMAC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3CFBE20", Offset = "0x3CFA820", VA = "0x183CFBE20", Slot = "4")]
	public void NGGMPBJDGGI(Material OKNIOBAOHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3CFAA80", Offset = "0x3CF9480", VA = "0x183CFAA80", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CIEGPPBKECO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong OEONDNELCCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong EFBIMAFNMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PNJPDLOFOCO
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct GDANPLGHMCA : CIEGPPBKECO, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable OMEKNKALOKC;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong OEONDNELCCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4B0", Offset = "0x8BDEB0", VA = "0x1808BF4B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x60E7C30", Offset = "0x60E6630", VA = "0x1860E7C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong EFBIMAFNMDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x14EB210", Offset = "0x14E9C10", VA = "0x1814EB210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4C41400", Offset = "0x4C3FE00", VA = "0x184C41400")]
		internal GDANPLGHMCA(IDisposable JLJOMBEDEBJ, ulong FLFMIJJHNCK, ulong JGOJLCHCHOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6913250", Offset = "0x6911C50", VA = "0x186913250", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct JOFAKHLEAJC : CIEGPPBKECO, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture BHMKADLMPID;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong OEONDNELCCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4B0", Offset = "0x8BDEB0", VA = "0x1808BF4B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x60E7C30", Offset = "0x60E6630", VA = "0x1860E7C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong EFBIMAFNMDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x14EB210", Offset = "0x14E9C10", VA = "0x1814EB210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6916770", Offset = "0x6915170", VA = "0x186916770")]
		public JOFAKHLEAJC(RenderTexture POMOCFBBJEF, ulong PAFODFFIGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69166D0", Offset = "0x69150D0", VA = "0x1869166D0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong LKMJFAKMIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x69200D0", Offset = "0x691EAD0", VA = "0x1869200D0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6920790", Offset = "0x691F190", VA = "0x186920790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong PGJLLMPGCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69207D0", Offset = "0x691F1D0", VA = "0x1869207D0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6920960", Offset = "0x691F360", VA = "0x186920960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6920110", Offset = "0x691EB10", VA = "0x186920110")]
	public static ComputeBuffer CBNOJCEAKCL(int OHELHAFFKFF, int JHIINICAKJF, ComputeBufferType ADDOHDGDFOD, [Out] CIEGPPBKECO AHCMMMOBCPP, ComputeBufferMode MBMNLIPEPEP = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69202F0", Offset = "0x691ECF0", VA = "0x1869202F0")]
	public static RenderTexture CBNOJCEAKCL(int FGABMENJOIE, int HJMKGIJAPGN, int DNFKHDAPLLB, RenderTextureFormat PHCNDPLEFBH, [Out] CIEGPPBKECO AHCMMMOBCPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7420", Offset = "0x2CF5E20", VA = "0x182CF7420")]
	public static NativeArray<T> KNHCFCKFAJB<T>(NativeArray<T> OMEKNKALOKC, ulong NDKEFFPEPII, [Out] CIEGPPBKECO AHCMMMOBCPP) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7360", Offset = "0x2CF5D60", VA = "0x182CF7360")]
	public static NativeArray<T> CBNOJCEAKCL<T>(int NDKEFFPEPII, Allocator BPMIGAHMDHE, [Out] CIEGPPBKECO AHCMMMOBCPP, NativeArrayOptions FKJNBGBCACC = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6920810", Offset = "0x691F210", VA = "0x186920810")]
	public static void IKAGPDLIFEB(CIEGPPBKECO OMEKNKALOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6920690", Offset = "0x691F090", VA = "0x186920690")]
	public static uint EIGHKOJMEEC(RenderTextureFormat PHCNDPLEFBH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FABFCPIDHJO : GDIMOEOCJBB<DBBLCMPPAEK, DBBLCMPPAEK>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct IEKGDHHOJDP : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> NAJGHDNEJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> MNMDHELKGCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> HLLOGDGJOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> LHMIHCEMIFI;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x69148F0", Offset = "0x69132F0", VA = "0x1869148F0")]
		public IEKGDHHOJDP(NativeArray<int> NOLKOJINCPM, NativeArray<float> MFFBNJBNJDA, NativeArray<float4x4> LILLBANGNFB, NativeArray<float4> NNMAODDOAJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6914730", Offset = "0x6913130", VA = "0x186914730", Slot = "4")]
		public void Execute(int ILOCEPPJPDO, TransformAccess OFGHBAGNEDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct JOKENCGFEJP : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> NAJGHDNEJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> LJOPFKPKMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> JMOAAKMMPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<DBBLCMPPAEK> IIJDCNGHMBF;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69148F0", Offset = "0x69132F0", VA = "0x1869148F0")]
		public JOKENCGFEJP(NativeArray<int> NOLKOJINCPM, NativeArray<float4x4> BCPGGBLNEMC, NativeArray<float4> IHCKIMCPKIK, NativeArray<DBBLCMPPAEK> JEDBDINPIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69167A0", Offset = "0x69151A0", VA = "0x1869167A0", Slot = "4")]
		public void Execute(int ILOCEPPJPDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte JOMLIPFHKAG = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray FAJDNLFDNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> FGBBINAJGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> HBODPAAMBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> KFEOEAHCNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> HOJIBFGHNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> DKCPNAMMABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private CIEGPPBKECO MJOGFCOJEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private CIEGPPBKECO LGMAKIOOPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private CIEGPPBKECO OPFLFDEBPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private CIEGPPBKECO DEDFBKFBNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private CIEGPPBKECO IBBMNAHDFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform GIAHDHNPAHP;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6912EC0", Offset = "0x69118C0", VA = "0x186912EC0")]
	public FABFCPIDHJO(int OLOGKDFEELF, int PLJDADCGLGA, ComputeShader IJPOAHNLIDF, int OEOPMCNMMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6912C00", Offset = "0x6911600", VA = "0x186912C00", Slot = "6")]
	protected override void KGLCHONOILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6912E00", Offset = "0x6911800", VA = "0x186912E00")]
	private void NJELHEPHPOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6912870", Offset = "0x6911270", VA = "0x186912870")]
	public bool APPAJPMIACG(MANCDFPEGME AHCMMMOBCPP, Transform OFGHBAGNEDJ, float DDEBJBMMJHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x69129D0", Offset = "0x69113D0", VA = "0x1869129D0")]
	public void CHCLJOIBABG(MANCDFPEGME AHCMMMOBCPP, float DDEBJBMMJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6912B50", Offset = "0x6911550", VA = "0x186912B50")]
	public void EMMFNFAFEEH(MANCDFPEGME AHCMMMOBCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6912AB0", Offset = "0x69114B0", VA = "0x186912AB0", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PFKOFOBBIPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AEOIJLLIIPA JCOGGPDNFEN();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface GEEIBBDFBJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 ELBDAPKMNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int NKAFOLBGCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int DNEDLMPJAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> IOJOFKPMLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> BEOHJFBPBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> JEOJBPJBAPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> FIKDPIKANJA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> FLFNDILAPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> KGNJJCEIIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int OMPGHFKFICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int GLHAFIBBLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int GNPJACCGLAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool LNDPLAFAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NCONNDEFELK();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BCPPIOIAFNL : GEEIBBDFBJM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private PFKOFOBBIPL GPGPBIMNPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private AEOIJLLIIPA KJFFCELEION;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 ELBDAPKMNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8C0BB0", Offset = "0x8BF5B0", VA = "0x1808C0BB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9911C0", Offset = "0x98FBC0", VA = "0x1809911C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool KDLPIPGNKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x84ECB0", Offset = "0x84D6B0", VA = "0x18084ECB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int NKAFOLBGCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x88BD30", Offset = "0x88A730", VA = "0x18088BD30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x88B180", Offset = "0x889B80", VA = "0x18088B180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int DNEDLMPJAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8566A0", Offset = "0x8550A0", VA = "0x1808566A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8566E0", Offset = "0x8550E0", VA = "0x1808566E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int EJEOHNBJHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xB3C7A0", Offset = "0xB3B1A0", VA = "0x180B3C7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> IOJOFKPMLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6911120", Offset = "0x690FB20", VA = "0x186911120", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> BEOHJFBPBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6911190", Offset = "0x690FB90", VA = "0x186911190", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> JEOJBPJBAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x69110B0", Offset = "0x690FAB0", VA = "0x1869110B0", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> FIKDPIKANJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6910F90", Offset = "0x690F990", VA = "0x186910F90", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> FLFNDILAPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x69112F0", Offset = "0x690FCF0", VA = "0x1869112F0", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> KGNJJCEIIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x69110E0", Offset = "0x690FAE0", VA = "0x1869110E0", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LNDPLAFAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A80", Offset = "0x9B6480", VA = "0x1809B7A80", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA07480", Offset = "0xA05E80", VA = "0x180A07480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int OMPGHFKFICB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6911110", Offset = "0x690FB10", VA = "0x186911110", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int GLHAFIBBLKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6911090", Offset = "0x690FA90", VA = "0x186911090", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int GNPJACCGLAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69111C0", Offset = "0x690FBC0", VA = "0x1869111C0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6911320", Offset = "0x690FD20", VA = "0x186911320")]
	public BCPPIOIAFNL(Hash128 JAJGGBFDMEJ, PFKOFOBBIPL GPGPBIMNPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x69111E0", Offset = "0x690FBE0", VA = "0x1869111E0", Slot = "16")]
	public void NCONNDEFELK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6911000", Offset = "0x690FA00", VA = "0x186911000", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct MANCDFPEGME : IEquatable<MANCDFPEGME>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly MANCDFPEGME OPGDHOBODPJ;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int JCLKIAMNLIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x92B7E0", Offset = "0x92A1E0", VA = "0x18092B7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650")]
	public MANCDFPEGME(int ILOCEPPJPDO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6916D00", Offset = "0x6915700", VA = "0x186916D00", Slot = "4")]
	public bool Equals(MANCDFPEGME HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6916D50", Offset = "0x6915750", VA = "0x186916D50", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6916E20", Offset = "0x6915820", VA = "0x186916E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JHNHLALJAJC : KEBDIMMNLOB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool MHBFELIAFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private GEEIBBDFBJM KFLKJFDIBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<MANCDFPEGME> EHLNLMCAGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<MANCDFPEGME> AEGNDLOHNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<MANCDFPEGME> JHKABIBDPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> AOLEPADDPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int PMNNDMLMMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int FBOAKBIHCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int MGDCDOGJBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int PBNBCMDAGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int PBAOJFPAFON;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int JCLKIAMNLIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6914C40", Offset = "0x6913640", VA = "0x186914C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6914CF0", Offset = "0x69136F0", VA = "0x186914CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool DKOODEFELBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8A0E90", Offset = "0x89F890", VA = "0x1808A0E90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9A34A0", Offset = "0x9A1EA0", VA = "0x1809A34A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool IBBFILDGDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB6E860", Offset = "0xB6D260", VA = "0x180B6E860")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB6E870", Offset = "0xB6D270", VA = "0x180B6E870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool JDFNNPDJPCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool MJEGBBCINFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4A56780", Offset = "0x4A55180", VA = "0x184A56780", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1956480", Offset = "0x1954E80", VA = "0x181956480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float EPFNEGPNCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8BC220", Offset = "0x8BAC20", VA = "0x1808BC220")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1D1E730", Offset = "0x1D1D130", VA = "0x181D1E730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6916560", Offset = "0x6914F60", VA = "0x186916560")]
	public JHNHLALJAJC(GEEIBBDFBJM KJFFCELEION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6915050", Offset = "0x6913A50", VA = "0x186915050")]
	private void FHGFJPLMKPE(GEEIBBDFBJM KJFFCELEION, int PMNNDMLMMHM, int IGOIJKKOHEI, int ILOCEPPJPDO, int DEIFDFLKEMM, DKGCGEHGJBH EEOBDBMOHPL, float DEKLLJGCLOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6914D90", Offset = "0x6913790", VA = "0x186914D90")]
	private void CIGNFJFELKK(GEEIBBDFBJM KJFFCELEION, int LOOILABNNPF, int ILOCEPPJPDO, uint3 LBNGKGIJAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x69149A0", Offset = "0x69133A0", VA = "0x1869149A0")]
	private bool BFEIEPINJOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6915510", Offset = "0x6913F10", VA = "0x186915510", Slot = "4")]
	public bool KODKNHDNNHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6914920", Offset = "0x6913320", VA = "0x186914920", Slot = "5")]
	public bool AIFEINMMINP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6915EF0", Offset = "0x69148F0", VA = "0x186915EF0", Slot = "6")]
	public void PLMGPBLKDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6914D30", Offset = "0x6913730", VA = "0x186914D30")]
	public void CECENGHBCHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6914D30", Offset = "0x6913730", VA = "0x186914D30", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KEBDIMMNLOB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool JDFNNPDJPCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool MJEGBBCINFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KODKNHDNNHA();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AIFEINMMINP();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLMGPBLKDNE();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MJHEAGMIPBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float JPHPPMFLKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, JHNHLALJAJC> JKMOMNICIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, DGBLOOPPBBK> PHLMDPIAIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<KEBDIMMNLOB> MLEOAHJMEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<KEBDIMMNLOB> FENHHHEFNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<KEBDIMMNLOB> HOIHCPGKJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int FPDGAKDIFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int EALOIGFIINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float IPCOIDNFMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool FNBDEMHGDCA;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool DAJEECJEGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xDBFCF0", Offset = "0xDBE6F0", VA = "0x180DBFCF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xDC3970", Offset = "0xDC2370", VA = "0x180DC3970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool GKCKDFCKMGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x69179E0", Offset = "0x69163E0", VA = "0x1869179E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string ENACDDFIMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6917C10", Offset = "0x6916610", VA = "0x186917C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x69179D0", Offset = "0x69163D0", VA = "0x1869179D0")]
	public void EAKHLFEEBHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6917A30", Offset = "0x6916430", VA = "0x186917A30")]
	public void GPMKIBBKBKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6918A00", Offset = "0x6917400", VA = "0x186918A00")]
	public MJHEAGMIPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x69185B0", Offset = "0x6916FB0", VA = "0x1869185B0")]
	public GDOCHECPEEF PMAGAGNLFOG(DOPJJLPGLLL LGHIKPMCACI, bool LDIFICIDAGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6918470", Offset = "0x6916E70", VA = "0x186918470")]
	public DGBLOOPPBBK PMAGAGNLFOG(MOPCEDKPDLM OKNIOBAOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6917A40", Offset = "0x6916440", VA = "0x186917A40")]
	public bool HBNMEFJACBG(Hash128 OBDGAAHPMCD, [Out] JHNHLALJAJC FAHCABHGIKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x69186E0", Offset = "0x69170E0", VA = "0x1869186E0")]
	public JHNHLALJAJC PMAGAGNLFOG(GEEIBBDFBJM KJFFCELEION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6917AB0", Offset = "0x69164B0", VA = "0x186917AB0")]
	private void HOFEJAFBKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6917B80", Offset = "0x6916580", VA = "0x186917B80")]
	private bool KKEJMEEGFMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6917FC0", Offset = "0x69169C0", VA = "0x186917FC0")]
	public void NCONNDEFELK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x69178C0", Offset = "0x69162C0", VA = "0x1869178C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6917AD0", Offset = "0x69164D0", VA = "0x186917AD0")]
	public void KACBEKKMCMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KBJAMFMGGGO : GDIMOEOCJBB<DKMMNBBHLAB, DKMMNBBHLAB>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6916810", Offset = "0x6915210", VA = "0x186916810")]
	public KBJAMFMGGGO(int OLOGKDFEELF, int PLJDADCGLGA, ComputeShader IJPOAHNLIDF, int OEOPMCNMMAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ECCGOILIPHJ : GDIMOEOCJBB<EENKJJBDKNP, EENKJJBDKNP>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x69124A0", Offset = "0x6910EA0", VA = "0x1869124A0")]
	public ECCGOILIPHJ(int OLOGKDFEELF, int PLJDADCGLGA, ComputeShader IJPOAHNLIDF, int OEOPMCNMMAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class GGEELFDABHH : GDIMOEOCJBB<GCMDAOMPBGP, GCMDAOMPBGP>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x69145D0", Offset = "0x6912FD0", VA = "0x1869145D0")]
	public GGEELFDABHH(int OLOGKDFEELF, int PLJDADCGLGA, ComputeShader IJPOAHNLIDF, int OEOPMCNMMAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class OLBOKOOOKIN : GDIMOEOCJBB<IBJPIPGGOFB, OJLEBFIMKOM>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x691FFE0", Offset = "0x691E9E0", VA = "0x18691FFE0")]
	public OLBOKOOOKIN(int OLOGKDFEELF, int PLJDADCGLGA, ComputeShader IJPOAHNLIDF, int OEOPMCNMMAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EPBHIGBPEAK : GDIMOEOCJBB<ALDNPNHJCFK, ALDNPNHJCFK>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x69127C0", Offset = "0x69111C0", VA = "0x1869127C0")]
	public EPBHIGBPEAK(int OLOGKDFEELF, int PLJDADCGLGA, ComputeShader IJPOAHNLIDF, int OEOPMCNMMAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class LPNHCOBEKEA : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private OCNLAJAJEAI JIKCPLNABOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool OPDIOPBPNGJ;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool MAKCDJJPKMH;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6916CC0", Offset = "0x69156C0", VA = "0x186916CC0")]
	public LPNHCOBEKEA(OCNLAJAJEAI JOHGDDOOKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6916B30", Offset = "0x6915530", VA = "0x186916B30", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer CPFKNKMCNPD, RenderingData IGPOGEIHIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x69168C0", Offset = "0x69152C0", VA = "0x1869168C0", Slot = "6")]
	public override void Configure(CommandBuffer CPFKNKMCNPD, RenderTextureDescriptor CGMHIPBIJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6916900", Offset = "0x6915300", VA = "0x186916900", Slot = "9")]
	public override void Execute(ScriptableRenderContext NIDJKNBFFJH, RenderingData IGPOGEIHIPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class CMBDJNKKJJL
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct EHMCFBGMAOG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string CCMEKJGADHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer CPFKNKMCNPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext NIDJKNBFFJH;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x69126B0", Offset = "0x69110B0", VA = "0x1869126B0")]
		public EHMCFBGMAOG(string MBAPDPHFNHD, ScriptableRenderContext BHAEPDLJAKD, [Out] CommandBuffer CEIHAEPFHLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6912600", Offset = "0x6911000", VA = "0x186912600", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6911540", Offset = "0x690FF40", VA = "0x186911540")]
	public static bool GEGEKNHAMCD(RenderingData IGPOGEIHIPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x69113A0", Offset = "0x690FDA0", VA = "0x1869113A0")]
	public static void BLDEIBLKGGG(CommandBuffer CPFKNKMCNPD, ScriptableRenderContext NIDJKNBFFJH, ShadowDrawingSettings PCAMAJPEHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6911690", Offset = "0x6910090", VA = "0x186911690")]
	public static void JHIIEBJIOHN(CommandBuffer CPFKNKMCNPD, ScriptableRenderContext NIDJKNBFFJH, RenderingData IGPOGEIHIPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class OCNLAJAJEAI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class EFBEFHBAJJM
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int PBNKLMLLEAK;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int GCHBKDFDLGN;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static NKOCJEIKMJD<GHBNECMMFBE> KIJNFJFNKMK;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static NKOCJEIKMJD<uint> PPFHABKAEIK;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static CIEGPPBKECO BOEEHAHHLGG;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer AFCIJNAFCNG;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<KCGHNBEODDN> CINHALLJCNJ;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int ALKFEABBMCC;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int GNOMEOBHBFJ;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int GJECIIFGONI;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int IFFKJEFGPGI;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] ENFGOEOMNPC;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] IGNJPNHLAFJ;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static CBLBEFJJCOD[][] DBJOAPFLGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] MOHPJJOHJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int GHMBKHGFHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int LIDAMDAALPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int INOOIGJKMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int LBGJPPAPJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int LKOJDEDGAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int IPLBIFAHOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int EBLDKHMEMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int PIKHEKJPJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int JDMHCMPDGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int NGAGMIDJAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int AAFMOPPLGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int BJFGOINLIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int IFHLMFLPNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int HGOBGHBECLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int DANABOBMGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int JNPBGEMFENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int EIBNHMFBHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int FEDECNJGHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] LIFNIPLAJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private MJHEAGMIPBK BABLGMHFLGF;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool MCOOBJHAGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x691B2F0", Offset = "0x6919CF0", VA = "0x18691B2F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x691DC30", Offset = "0x691C630", VA = "0x18691DC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool FEGKLLFHAAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x691E9D0", Offset = "0x691D3D0", VA = "0x18691E9D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x691DAE0", Offset = "0x691C4E0", VA = "0x18691DAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData MAOHOGCCNAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x691FC90", Offset = "0x691E690", VA = "0x18691FC90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x691B280", Offset = "0x6919C80", VA = "0x18691B280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static FABFCPIDHJO FDNBCJBEHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x691DD10", Offset = "0x691C710", VA = "0x18691DD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x691DBC0", Offset = "0x691C5C0", VA = "0x18691DBC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static KBJAMFMGGGO DECCEKHPEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x691C2E0", Offset = "0x691ACE0", VA = "0x18691C2E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x691B1A0", Offset = "0x6919BA0", VA = "0x18691B1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static ECCGOILIPHJ FGMHGAGGAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x691A870", Offset = "0x6919270", VA = "0x18691A870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x691A720", Offset = "0x6919120", VA = "0x18691A720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static GGEELFDABHH NNDDLJNKIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x691A9D0", Offset = "0x69193D0", VA = "0x18691A9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x691B210", Offset = "0x6919C10", VA = "0x18691B210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static OLBOKOOOKIN ILILIICKKAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x691EA20", Offset = "0x691D420", VA = "0x18691EA20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x691B060", Offset = "0x6919A60", VA = "0x18691B060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static EPBHIGBPEAK CDAOEEBKDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x691EA90", Offset = "0x691D490", VA = "0x18691EA90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x691A7F0", Offset = "0x69191F0", VA = "0x18691A7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material OEGLPHFFABA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x691B0E0", Offset = "0x6919AE0", VA = "0x18691B0E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x691DA60", Offset = "0x691C460", VA = "0x18691DA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material GFBDHPJHKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x691BCA0", Offset = "0x691A6A0", VA = "0x18691BCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x691E200", Offset = "0x691CC00", VA = "0x18691E200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material PPAAPOAEIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x691A6C0", Offset = "0x69190C0", VA = "0x18691A6C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x691DC90", Offset = "0x691C690", VA = "0x18691DC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material CBIPADEPMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x691B340", Offset = "0x6919D40", VA = "0x18691B340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x691DB40", Offset = "0x691C540", VA = "0x18691DB40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool HDMFDDHOMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x691C650", Offset = "0x691B050", VA = "0x18691C650")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x691A790", Offset = "0x6919190", VA = "0x18691A790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool GKCKDFCKMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x691B140", Offset = "0x6919B40", VA = "0x18691B140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string ENACDDFIMMI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x691E280", Offset = "0x691CC80", VA = "0x18691E280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x691FD80", Offset = "0x691E780", VA = "0x18691FD80")]
	internal OCNLAJAJEAI([Optional] MClusterData DIJOCPFOCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6919310", Offset = "0x6917D10", VA = "0x186919310")]
	public void CCPNKNOIBEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x691D9C0", Offset = "0x691C3C0", VA = "0x18691D9C0")]
	public void KDGEEFPFEOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x691EA80", Offset = "0x691D480", VA = "0x18691EA80")]
	public void OPEJLDEAECL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x691D830", Offset = "0x691C230", VA = "0x18691D830")]
	public bool JLIKLKNDOPM(Hash128 JAJGGBFDMEJ, [Out] JHNHLALJAJC KJFFCELEION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x691F810", Offset = "0x691E210", VA = "0x18691F810")]
	public JHNHLALJAJC PMAGAGNLFOG(GEEIBBDFBJM EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x691F8D0", Offset = "0x691E2D0", VA = "0x18691F8D0")]
	public DGBLOOPPBBK PMAGAGNLFOG(MOPCEDKPDLM OKNIOBAOHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x691FAD0", Offset = "0x691E4D0", VA = "0x18691FAD0")]
	public GDOCHECPEEF PMAGAGNLFOG(DOPJJLPGLLL LGHIKPMCACI, bool LDIFICIDAGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x691F7C0", Offset = "0x691E1C0", VA = "0x18691F7C0")]
	public void PLMGPBLKDNE(KEBDIMMNLOB MDCEGLNACHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x691D8D0", Offset = "0x691C2D0", VA = "0x18691D8D0")]
	public static void JNEDKKGINKP(DDGHFMOBNGF NDBFPELDACP, CBLBEFJJCOD[] EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x691B3A0", Offset = "0x6919DA0", VA = "0x18691B3A0")]
	private void IAKCGABBHIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x691EAF0", Offset = "0x691D4F0", VA = "0x18691EAF0")]
	private static void PGDODBPCDBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x691C330", Offset = "0x691AD30", VA = "0x18691C330")]
	public void IHHOJAJLHCM(CommandBuffer CPFKNKMCNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x691D660", Offset = "0x691C060", VA = "0x18691D660")]
	public void INHFLBMDDBJ([Optional] ScriptableRenderContext? NIDJKNBFFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6918D50", Offset = "0x6917750", VA = "0x186918D50")]
	public void BCKIFNCACPH(CommandBuffer CPFKNKMCNPD, ShadowSplitData EIOIPAIADHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6919030", Offset = "0x6917A30", VA = "0x186919030")]
	public void BCKIFNCACPH(CommandBuffer CPFKNKMCNPD, CameraData LDPKJBKCEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x691AB00", Offset = "0x6919500", VA = "0x18691AB00")]
	public void FBELAPOMDKB(CommandBuffer CPFKNKMCNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x691E960", Offset = "0x691D360", VA = "0x18691E960")]
	public void NLJHKDMLINA(CommandBuffer CPFKNKMCNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x691DD60", Offset = "0x691C760", VA = "0x18691DD60")]
	public void NADHECPPHJJ(CommandBuffer CPFKNKMCNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x691BD00", Offset = "0x691A700", VA = "0x18691BD00")]
	public void IGACLCFMFDB(CommandBuffer CPFKNKMCNPD, DDGHFMOBNGF FLAKOGLJHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x691AA20", Offset = "0x6919420", VA = "0x18691AA20")]
	public void EPBJHENAKAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x691C6B0", Offset = "0x691B0B0", VA = "0x18691C6B0")]
	public void IKAGPDLIFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x691A8C0", Offset = "0x69192C0", VA = "0x18691A8C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class CDGJJFGCKMP
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1F01790", Offset = "0x1F00190", VA = "0x181F01790")]
	public static int NNEGKPIOGPB(int KLFNJJLKNGE, int ODBKLKLKLED)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct DBBLCMPPAEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 HKHILDJHDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 AHFGHEFIJIF;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly DBBLCMPPAEK LHFKKHGGGGI;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly DBBLCMPPAEK OPGDHOBODPJ;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6911A30", Offset = "0x6910430", VA = "0x186911A30")]
	public DBBLCMPPAEK(float4x4 EEIJIGFFBBC, float4 MOGNHDNEMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x69118C0", Offset = "0x69102C0", VA = "0x1869118C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct DKGCGEHGJBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 GLNEOPDBMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 GKJCNLBHEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 GMLKGNBBAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 PBEOOPKMFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 NLJODHPENFJ;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct NNPMICPACAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 GLNEOPDBMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 GKJCNLBHEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 GMLKGNBBAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 PBEOOPKMFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 NLJODHPENFJ;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct OJLEBFIMKOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public NNPMICPACAJ HIICOLLJLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public NNPMICPACAJ OLBFIEFMAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public NNPMICPACAJ KGEGKKEIDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public NNPMICPACAJ MCCJIPPLKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public NNPMICPACAJ OPCIFCOGEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public NNPMICPACAJ KHKPEOOPLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public NNPMICPACAJ BFJMEOLCHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public NNPMICPACAJ MPMKNGCHOJG;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct IBJPIPGGOFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public DKGCGEHGJBH HIICOLLJLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public DKGCGEHGJBH OLBFIEFMAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public DKGCGEHGJBH KGEGKKEIDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public DKGCGEHGJBH MCCJIPPLKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public DKGCGEHGJBH OPCIFCOGEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public DKGCGEHGJBH KHKPEOOPLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public DKGCGEHGJBH BFJMEOLCHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public DKGCGEHGJBH MPMKNGCHOJG;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct EENKJJBDKNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 GOBIGGAIFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint FLCFEMCIANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint NCLOOEMMHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float HINJGEPMFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint BBGLJHELALP;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6912550", Offset = "0x6910F50", VA = "0x186912550")]
	public EENKJJBDKNP(MOPCEDKPDLM OKNIOBAOHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct GHBNECMMFBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint OOBMOPALHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint BHNAPGNAIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint DEIFDFLKEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint BBGLJHELALP;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6914680", Offset = "0x6913080", VA = "0x186914680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct GCMDAOMPBGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint IGOIJKKOHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint CJAHBJOHKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint FBOAKBIHCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint BBGLJHELALP;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x69131A0", Offset = "0x6911BA0", VA = "0x1869131A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct DKMMNBBHLAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint NGAGHMJMBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint JBHMMFNLKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint GNLMAMFEPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint EFBLPAKHCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint NCLLHNPAJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint ELAGNDJBKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint DODBDBKKCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint BBGLJHELALP;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6912150", Offset = "0x6910B50", VA = "0x186912150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct ALDNPNHJCFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 IIADGEONFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 HKCHBOKNOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 IAABADKLCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 IMDOMGLKKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 EMNFKCINGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 KHBILGBBFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 IFEHPJEOMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 DNOPNDCCKHG;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6910B80", Offset = "0x690F580", VA = "0x186910B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum DDGHFMOBNGF
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
