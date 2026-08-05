using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class KKNCLFDMOJL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1A5F880", Offset = "0x1A5E680", VA = "0x181A5F880")]
	public static bool GMAHDHNJBLO(this TypeInfo IGEIBCJNCHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class PFLMJBJPFOD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type HEDCAMCHEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6B2150", Offset = "0x6B0F50", VA = "0x1806B2150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] LKDNMFKNBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x922590", Offset = "0x921390", VA = "0x180922590")]
	public PFLMJBJPFOD(Type APEBNIBGLGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor)]
public class FJJBONICGCG : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KOIGGKEGCNJ<T>(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T KNFFAHGKNBH<T>(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG OHIDBDNDNIA);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CDJJKNODMKB
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KBIOLGDHIDG<T> : CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NKJJGAMHDGI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum FFOJCCDENBP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NBBPOLMOGFI
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4692A70", Offset = "0x4691870", VA = "0x184692A70")]
	public static global::KBIOLGDHIDG<T> DPCKLAFOJEE<T>(this CDAHFIMKBKG OHIDBDNDNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1B804F0", Offset = "0x1B7F2F0", VA = "0x181B804F0")]
	public static object OGFENLKMDAH(this CDAHFIMKBKG OHIDBDNDNIA, Type IGEIBCJNCHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KIACBADABBP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1A5D490", Offset = "0x1A5C290", VA = "0x181A5D490")]
	public KIACBADABBP(string LMLMHJKGDCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct HJNHIBNNFEE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class PGGACBAHHGD
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] FAHBHODOFIG;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] ANOHAAJJMPC;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1B831D0", Offset = "0x1B81FD0", VA = "0x181B831D0")]
		public static byte[] KDIMAKIMIBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1B83140", Offset = "0x1B81F40", VA = "0x181B83140")]
		public static char[] BJFIEAPEJEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> IDOEOMGHOGE;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] OPHLMAKBHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] CCFMJPPGPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int PNKNABOKANH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool NGDCOGJBDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1A530D0", Offset = "0x1A51ED0", VA = "0x181A530D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1A53800", Offset = "0x1A52600", VA = "0x181A53800")]
	public HJNHIBNNFEE(byte[] CCFMJPPGPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1A53610", Offset = "0x1A52410", VA = "0x181A53610")]
	public HJNHIBNNFEE(byte[] CCFMJPPGPDK, int PNKNABOKANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1A51DB0", Offset = "0x1A50BB0", VA = "0x181A51DB0")]
	private KJJEPECLPAG HONJCJJFGOJ(string MPNBEECGANP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1A50990", Offset = "0x1A4F790", VA = "0x181A50990")]
	private KJJEPECLPAG BCACCFGCBPD(string LMLMHJKGDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1A53400", Offset = "0x1A52200", VA = "0x181A53400")]
	public void NCNNCIMJDEL(int PNKNABOKANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x775530", Offset = "0x774330", VA = "0x180775530")]
	public byte[] OCGCLACNCPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x757A20", Offset = "0x756820", VA = "0x180757A20")]
	public int JMGKDDIDBEG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1A519C0", Offset = "0x1A507C0", VA = "0x181A519C0")]
	public FDHIMNDNOFP GBMAFOAPGIH()
	{
		return default(FDHIMNDNOFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1A51310", Offset = "0x1A50110", VA = "0x181A51310")]
	public void EKMBEIPLMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1A511B0", Offset = "0x1A4FFB0", VA = "0x181A511B0")]
	public bool DMPKDDCHJEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1A52640", Offset = "0x1A51440", VA = "0x181A52640")]
	public bool LCOKPENLLIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1A517A0", Offset = "0x1A505A0", VA = "0x181A517A0")]
	public void FNKHLAKKDMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1A51C00", Offset = "0x1A50A00", VA = "0x181A51C00")]
	public bool HJFAPGOKCCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1A50F10", Offset = "0x1A4FD10", VA = "0x181A50F10")]
	public bool CJEGICBADDF(ref int MIOCJKOOLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1A50B40", Offset = "0x1A4F940", VA = "0x181A50B40")]
	public bool BKLHBEIIGMP(ref int MIOCJKOOLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1A51150", Offset = "0x1A4FF50", VA = "0x181A51150")]
	public bool DEHHEGBCOBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1A50900", Offset = "0x1A4F700", VA = "0x181A50900")]
	public void BBBKDHEIDDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1A525B0", Offset = "0x1A513B0", VA = "0x181A525B0")]
	public bool LCDOMMDONOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1A51D30", Offset = "0x1A50B30", VA = "0x181A51D30")]
	public bool HNDCLIHGIJK(ref int MIOCJKOOLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1A51B40", Offset = "0x1A50940", VA = "0x181A51B40")]
	public bool GEKFIMANEIM(ref int MIOCJKOOLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1A522C0", Offset = "0x1A510C0", VA = "0x181A522C0")]
	public bool IANHIDCLPMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1A50870", Offset = "0x1A4F670", VA = "0x181A50870")]
	public void AKNLBGMMIMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1A532E0", Offset = "0x1A520E0", VA = "0x181A532E0")]
	public bool MBOCLFIJAPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1A52880", Offset = "0x1A51680", VA = "0x181A52880")]
	public void LJJBKHIKJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1A52910", Offset = "0x1A51710", VA = "0x181A52910")]
	private void LMDDHBAGLGA(out byte[] DOGEDEBJECM, out int JNCINBDIODL, out int KPGAHJGDDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1A510A0", Offset = "0x1A4FEA0", VA = "0x181A510A0")]
	private static int DDPBPGOBCNC(char NCNGLFNLPAG, char OPGAGDBKIDA, char NKNPGFCGIPO, char LNMAPJNBGLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1A50A70", Offset = "0x1A4F870", VA = "0x181A50A70")]
	private static int BJFBPCBEJGM(char JMDPDGBMGAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1A516A0", Offset = "0x1A504A0", VA = "0x181A516A0")]
	public ArraySegment<byte> FKHIIIOBNCP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1A53240", Offset = "0x1A52040", VA = "0x181A53240")]
	public string MBCPHMOOCCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1A52610", Offset = "0x1A51410", VA = "0x181A52610")]
	public string LCHIDLJBJNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1A50D40", Offset = "0x1A4FB40", VA = "0x181A50D40")]
	public ArraySegment<byte> CDLCGNBEIDI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1A53410", Offset = "0x1A52210", VA = "0x181A53410")]
	public ArraySegment<byte> NPKFAELDBON()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1A51450", Offset = "0x1A50250", VA = "0x181A51450")]
	public bool FDNFEKDOMEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1A53450", Offset = "0x1A52250", VA = "0x181A53450")]
	private static bool OKCMCLONCAG(byte NKNPGFCGIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1A526A0", Offset = "0x1A514A0", VA = "0x181A526A0")]
	private void LGCCJCEAOJF(FDHIMNDNOFP KCCFEDJJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1A51690", Offset = "0x1A50490", VA = "0x181A51690")]
	public void FFCOHGHEJCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1A51C60", Offset = "0x1A50A60", VA = "0x181A51C60")]
	private void HMBBJPBBKEN(int FDHHJEIMKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1A52560", Offset = "0x1A51360", VA = "0x181A52560")]
	public sbyte LAFKMEOBIMG()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1A50C80", Offset = "0x1A4FA80", VA = "0x181A50C80")]
	public short BMBFOFJNBJO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1A512B0", Offset = "0x1A500B0", VA = "0x181A512B0")]
	public int ECLOENBFOKD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1A52460", Offset = "0x1A51260", VA = "0x181A52460")]
	public long KEKOIEHBMDK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1A50CE0", Offset = "0x1A4FAE0", VA = "0x181A50CE0")]
	public byte BMNPLFFBDHN()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1A53340", Offset = "0x1A52140", VA = "0x181A53340")]
	public ushort MMJEBNKOFCI()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1A533A0", Offset = "0x1A521A0", VA = "0x181A533A0")]
	public uint NBPDHMKLDBI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1A50C00", Offset = "0x1A4FA00", VA = "0x181A50C00")]
	public ulong BLIHAKGCIJH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1A530F0", Offset = "0x1A51EF0", VA = "0x181A530F0")]
	public float LPPGONDOCEI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1A52320", Offset = "0x1A51120", VA = "0x181A52320")]
	public double INAHBHNOCMF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1A50F90", Offset = "0x1A4FD90", VA = "0x181A50F90")]
	public ArraySegment<byte> CPLHODALPBC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1A51830", Offset = "0x1A50630", VA = "0x181A51830")]
	private static int FPBJHOPIHCH(byte[] CCFMJPPGPDK, int PNKNABOKANH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KJJEPECLPAG : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference ECMPKIAJCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int JKBADKCAACF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int INEGPIPFIBC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9EF230", Offset = "0x9EE030", VA = "0x1809EF230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string BGBNGLFENPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x836450", Offset = "0x835250", VA = "0x180836450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1A5DA70", Offset = "0x1A5C870", VA = "0x181A5DA70")]
	public KJJEPECLPAG(string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1A5DAE0", Offset = "0x1A5C8E0", VA = "0x181A5DAE0")]
	public KJJEPECLPAG(string LMLMHJKGDCH, byte[] LDANIHEGLCF, int PNKNABOKANH, int JKBADKCAACF, string AHCBGDFHABF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MHFOACICCBC
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class BHIPANHOAAG
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private delegate void LGBPHLEPHIM(ref IPBPHIELIHL GAKCPFEFIJJ, object DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private delegate object AMNHHOAJLJB(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG OHIDBDNDNIA);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class KBKDLHAIKNE
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class HGDIEBMAKKC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
				public HGDIEBMAKKC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xDB4840", Offset = "0xDB3640", VA = "0x180DB4840")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x1B789C0", Offset = "0x1B777C0", VA = "0x181B789C0")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, CDAHFIMKBKG, byte[]> NEJAPGLCMMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, CDAHFIMKBKG> ELEMBPDNCGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly LGBPHLEPHIM MMMPFPDMGLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, CDAHFIMKBKG, ArraySegment<byte>> NGIDIBMLDKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, CDAHFIMKBKG, string> CDIOGEAKMMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, CDAHFIMKBKG, object> GHEFBMJOAPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, CDAHFIMKBKG, object> IJNGKKLIHNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, CDAHFIMKBKG, object> KAJFIBKGNOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly AMNHHOAJLJB EKDJCJLKGEA;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1B7AC80", Offset = "0x1B79A80", VA = "0x181B7AC80")]
			public KBKDLHAIKNE(Type IGEIBCJNCHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x575FC00", Offset = "0x575EA00", VA = "0x18575FC00")]
			private static T DAOCMHMDJDH<T>(DynamicMethod GOHPCNPKGLO)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x1B7AA30", Offset = "0x1B79830", VA = "0x181B7AA30")]
			private static MethodInfo ELAAIPGLNHI(Type IGEIBCJNCHF, string IADPDEAGFAB, Type[] NGACEPLFOCA)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, KBKDLHAIKNE> CIOHJEMPDBF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::KLLFKEKDHGC<KBKDLHAIKNE> MBBKEHPDGBE;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1B72F60", Offset = "0x1B71D60", VA = "0x181B72F60")]
		static BHIPANHOAAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1B72C20", Offset = "0x1B71A20", VA = "0x181B72C20")]
		private static KBKDLHAIKNE FEAMCPOBIKK(Type IGEIBCJNCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1B72DD0", Offset = "0x1B71BD0", VA = "0x181B72DD0")]
		public static void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, object DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1B72CB0", Offset = "0x1B71AB0", VA = "0x181B72CB0")]
		public static void PNKNJNLKBEB(Type IGEIBCJNCHF, ref IPBPHIELIHL GAKCPFEFIJJ, object DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class BMHCPBEKNFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] FAHBHODOFIG;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1B73260", Offset = "0x1B72060", VA = "0x181B73260")]
		public static byte[] KDIMAKIMIBI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static CDAHFIMKBKG JFLCCKMKHGG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] MMILAMMAGCG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] PIJBOOJMJOH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static CDAHFIMKBKG ACCDOGDPLFK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1B7EE60", Offset = "0x1B7DC60", VA = "0x181B7EE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool ANGKCDCBMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1B7F770", Offset = "0x1B7E570", VA = "0x181B7F770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F7D0", Offset = "0x1B7E5D0", VA = "0x181B7F7D0")]
	public static void PFLNFLDGKGH(CDAHFIMKBKG OHIDBDNDNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x36E6A40", Offset = "0x36E5840", VA = "0x1836E6A40")]
	public static byte[] PNKNJNLKBEB<T>(T GKCPJCKCENH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x36E6AC0", Offset = "0x36E58C0", VA = "0x1836E6AC0")]
	public static byte[] PNKNJNLKBEB<T>(T DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x36E6CB0", Offset = "0x36E5AB0", VA = "0x1836E6CB0")]
	public static void PNKNJNLKBEB<T>(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x36E6960", Offset = "0x36E5760", VA = "0x1836E6960")]
	public static void PNKNJNLKBEB<T>(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x36E6C20", Offset = "0x36E5A20", VA = "0x1836E6C20")]
	public static void PNKNJNLKBEB<T>(Stream KJHFBEBKBIB, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x36E6D40", Offset = "0x36E5B40", VA = "0x1836E6D40")]
	public static void PNKNJNLKBEB<T>(Stream KJHFBEBKBIB, T DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x36E6560", Offset = "0x36E5360", VA = "0x1836E6560")]
	public static ArraySegment<byte> KIACAMHNNMN<T>(T GKCPJCKCENH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x36E6600", Offset = "0x36E5400", VA = "0x1836E6600")]
	public static ArraySegment<byte> KIACAMHNNMN<T>(T DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x36E6780", Offset = "0x36E5580", VA = "0x1836E6780")]
	public static string NNIDKDPOPLG<T>(T DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x36E6800", Offset = "0x36E5600", VA = "0x1836E6800")]
	public static string NNIDKDPOPLG<T>(T DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x36E5B90", Offset = "0x36E4990", VA = "0x1836E5B90")]
	public static T CJKIJAOEIBM<T>(string CNJAPFNEOCK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x36E5AA0", Offset = "0x36E48A0", VA = "0x1836E5AA0")]
	public static T CJKIJAOEIBM<T>(string CNJAPFNEOCK, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x36E6260", Offset = "0x36E5060", VA = "0x1836E6260")]
	public static T CJKIJAOEIBM<T>(byte[] CCFMJPPGPDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x36E5D90", Offset = "0x36E4B90", VA = "0x1836E5D90")]
	public static T CJKIJAOEIBM<T>(byte[] CCFMJPPGPDK, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x36E5EB0", Offset = "0x36E4CB0", VA = "0x1836E5EB0")]
	public static T CJKIJAOEIBM<T>(byte[] CCFMJPPGPDK, int PNKNABOKANH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x36E5C30", Offset = "0x36E4A30", VA = "0x1836E5C30")]
	public static T CJKIJAOEIBM<T>(byte[] CCFMJPPGPDK, int PNKNABOKANH, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x36E5E30", Offset = "0x36E4C30", VA = "0x1836E5E30")]
	public static T CJKIJAOEIBM<T>(ref HJNHIBNNFEE NINBMPMOGGB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x36E6490", Offset = "0x36E5290", VA = "0x1836E6490")]
	public static T CJKIJAOEIBM<T>(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x36E6410", Offset = "0x36E5210", VA = "0x1836E6410")]
	public static T CJKIJAOEIBM<T>(Stream KJHFBEBKBIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x36E62E0", Offset = "0x36E50E0", VA = "0x1836E62E0")]
	public static T CJKIJAOEIBM<T>(Stream KJHFBEBKBIB, CDAHFIMKBKG OHIDBDNDNIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F5E0", Offset = "0x1B7E3E0", VA = "0x181B7F5E0")]
	public static string LDLPNAEFLDJ(byte[] CNJAPFNEOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F6C0", Offset = "0x1B7E4C0", VA = "0x181B7F6C0")]
	public static string LDLPNAEFLDJ(byte[] CNJAPFNEOCK, int PNKNABOKANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F510", Offset = "0x1B7E310", VA = "0x181B7F510")]
	public static string LDLPNAEFLDJ(string CNJAPFNEOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1B7ECB0", Offset = "0x1B7DAB0", VA = "0x181B7ECB0")]
	public static byte[] BPGNPAMIIFP(byte[] CNJAPFNEOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1B7EC00", Offset = "0x1B7DA00", VA = "0x181B7EC00")]
	public static byte[] BPGNPAMIIFP(byte[] CNJAPFNEOCK, int PNKNABOKANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1B7ED90", Offset = "0x1B7DB90", VA = "0x181B7ED90")]
	public static byte[] BPGNPAMIIFP(string CNJAPFNEOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1B7EF80", Offset = "0x1B7DD80", VA = "0x181B7EF80")]
	private static void FMIEPBAIAIN(ref HJNHIBNNFEE NINBMPMOGGB, ref IPBPHIELIHL GAKCPFEFIJJ, int HFAPDGCFEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F470", Offset = "0x1B7E270", VA = "0x181B7F470")]
	private static int JNEENMBMEJP(Stream GIEOCCOFGEG, ref byte[] FAHBHODOFIG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum FDHIMNDNOFP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BeginObject,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	EndObject,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BeginArray,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	EndArray,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Number,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	String,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	True,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	False,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Null,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ValueSeparator,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NameSeparator
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct IPBPHIELIHL
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] DLHMHOHLBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] FAHBHODOFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int PNKNABOKANH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int PLCJJHLICHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x757A20", Offset = "0x756820", VA = "0x180757A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1A53400", Offset = "0x1A52200", VA = "0x181A53400")]
	public void NCNNCIMJDEL(int PNKNABOKANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1A581F0", Offset = "0x1A56FF0", VA = "0x181A581F0")]
	public static byte[] ACGFANIMLLF(string AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1A59020", Offset = "0x1A57E20", VA = "0x181A59020")]
	public static byte[] LCEEOJLNJKB(string AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1A58580", Offset = "0x1A57380", VA = "0x181A58580")]
	public static byte[] ECGNOGMJIHL(string AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1A58B30", Offset = "0x1A57930", VA = "0x181A58B30")]
	public static byte[] HCGOJFHGJMA(string AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1A594A0", Offset = "0x1A582A0", VA = "0x181A594A0")]
	public IPBPHIELIHL(byte[] IBGMACJPNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1A58F70", Offset = "0x1A57D70", VA = "0x181A58F70")]
	public ArraySegment<byte> KDIMAKIMIBI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1A58350", Offset = "0x1A57150", VA = "0x181A58350")]
	public byte[] CHBHKKPBAAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1A593E0", Offset = "0x1A581E0", VA = "0x181A593E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1A58270", Offset = "0x1A57070", VA = "0x181A58270")]
	public void AGBJIBCDJKP(int PLINPOKNGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1A57C30", Offset = "0x1A56A30", VA = "0x181A57C30")]
	public void DOLBMMDCGFI(byte GNOIOELLINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1A58520", Offset = "0x1A57320", VA = "0x181A58520")]
	public void DOLBMMDCGFI(byte[] GNOIOELLINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1A59250", Offset = "0x1A58050", VA = "0x181A59250")]
	public void ONJKCDJCNGF(byte GNOIOELLINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1A58300", Offset = "0x1A57100", VA = "0x181A58300")]
	public void CBJNMMHHLMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1A58EF0", Offset = "0x1A57CF0", VA = "0x181A58EF0")]
	public void KAJAJCNAFGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1A58280", Offset = "0x1A57080", VA = "0x181A58280")]
	public void BKHBHOFPCJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1A59390", Offset = "0x1A58190", VA = "0x181A59390")]
	public void PMDNJADPMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1A58EA0", Offset = "0x1A57CA0", VA = "0x181A58EA0")]
	public void JDDGMFKNGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1A592C0", Offset = "0x1A580C0", VA = "0x181A592C0")]
	public void PKOIFAILKPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1A586D0", Offset = "0x1A574D0", VA = "0x181A586D0")]
	public void EONCOBMPLIP(string AOKAOIOMMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1A584D0", Offset = "0x1A572D0", VA = "0x181A584D0")]
	public void CPHLBFGACFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1A59150", Offset = "0x1A57F50", VA = "0x181A59150")]
	public void NKCDOFJGNPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1A58CB0", Offset = "0x1A57AB0", VA = "0x181A58CB0")]
	public void IDPDMDABECK(bool DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1A59310", Offset = "0x1A58110", VA = "0x181A59310")]
	public void PLPBNFMFHPL(float DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1A58650", Offset = "0x1A57450", VA = "0x181A58650")]
	public void ECJPJCHIGNP(double DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1A590F0", Offset = "0x1A57EF0", VA = "0x181A590F0")]
	public void LDMBDFDPJCA(byte DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1A58F40", Offset = "0x1A57D40", VA = "0x181A58F40")]
	public void KCMHLBEPECO(ushort DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1A58C80", Offset = "0x1A57A80", VA = "0x181A58C80")]
	public void HGPPNMAJPGM(uint DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1A582D0", Offset = "0x1A570D0", VA = "0x181A582D0")]
	public void CBADJNLAMOA(ulong DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1A59220", Offset = "0x1A58020", VA = "0x181A59220")]
	public void OEGDIEIEEMF(sbyte DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1A59290", Offset = "0x1A58090", VA = "0x181A59290")]
	public void PKMOFIEFAEP(short DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1A58B00", Offset = "0x1A57900", VA = "0x181A58B00")]
	public void GBNNIMAMIPK(int DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1A59120", Offset = "0x1A57F20", VA = "0x181A59120")]
	public void MOGMCLNCFEO(long DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1A58730", Offset = "0x1A57530", VA = "0x181A58730")]
	public void FDPPJFKIGGP(string DFEOJBAFBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PEGMDEAMIDA : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private static class FEPBANIKLIK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x435AC40", Offset = "0x4359A40", VA = "0x18435AC40")]
		static FEPBANIKLIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private PEGMDEAMIDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class ALKJMEFPFAH
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> AEMIIPGJBJC;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1A33060", Offset = "0x1A31E60", VA = "0x181A33060")]
	static ALKJMEFPFAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1A32950", Offset = "0x1A31750", VA = "0x181A32950")]
	internal static object EIKOHJLJIFP(Type PHLICBNKKOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class CHDKCBDKCLF : global::KBIOLGDHIDG<Vector2>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CMMEILIOKNM KOIAHPEJAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] AFIFGLAOPMH;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1A396E0", Offset = "0x1A384E0", VA = "0x181A396E0")]
	public CHDKCBDKCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1A39630", Offset = "0x1A38430", VA = "0x181A39630", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Vector2 DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1A39430", Offset = "0x1A38230", VA = "0x181A39430", Slot = "5")]
	public Vector2 CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class HDMAGDDGJPA : global::KBIOLGDHIDG<Vector3>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CMMEILIOKNM KOIAHPEJAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] AFIFGLAOPMH;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1A4F950", Offset = "0x1A4E750", VA = "0x181A4F950")]
	public HDMAGDDGJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1A4F6B0", Offset = "0x1A4E4B0", VA = "0x181A4F6B0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Vector3 DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1A4F390", Offset = "0x1A4E190", VA = "0x181A4F390", Slot = "5")]
	public Vector3 CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class NDHMJLADLIA : global::KBIOLGDHIDG<Vector4>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CMMEILIOKNM KOIAHPEJAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] AFIFGLAOPMH;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1B80880", Offset = "0x1B7F680", VA = "0x181B80880")]
	public NDHMJLADLIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1A3F570", Offset = "0x1A3E370", VA = "0x181A3F570", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Vector4 DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1B80660", Offset = "0x1B7F460", VA = "0x181B80660", Slot = "5")]
	public Vector4 CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class MDJFDPFCFAK : global::KBIOLGDHIDG<Quaternion>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CMMEILIOKNM KOIAHPEJAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] AFIFGLAOPMH;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1A64620", Offset = "0x1A63420", VA = "0x181A64620")]
	public MDJFDPFCFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1A642C0", Offset = "0x1A630C0", VA = "0x181A642C0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Quaternion DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1A63F40", Offset = "0x1A62D40", VA = "0x181A63F40", Slot = "5")]
	public Quaternion CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EFJCEBLMOPH : global::KBIOLGDHIDG<Color>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly CMMEILIOKNM KOIAHPEJAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] AFIFGLAOPMH;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1A3F6C0", Offset = "0x1A3E4C0", VA = "0x181A3F6C0")]
	public EFJCEBLMOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1A3F570", Offset = "0x1A3E370", VA = "0x181A3F570", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Color DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1A3F2E0", Offset = "0x1A3E0E0", VA = "0x181A3F2E0", Slot = "5")]
	public Color CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CFJGHHIDFKB : global::KBIOLGDHIDG<Bounds>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly CMMEILIOKNM KOIAHPEJAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] AFIFGLAOPMH;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1A391F0", Offset = "0x1A37FF0", VA = "0x181A391F0")]
	public CFJGHHIDFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1A39050", Offset = "0x1A37E50", VA = "0x181A39050", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Bounds DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1A38D20", Offset = "0x1A37B20", VA = "0x181A38D20", Slot = "5")]
	public Bounds CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class KCHNFICOBGG : global::KBIOLGDHIDG<Rect>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly CMMEILIOKNM KOIAHPEJAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] AFIFGLAOPMH;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1A5CB60", Offset = "0x1A5B960", VA = "0x181A5CB60")]
	public KCHNFICOBGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1A5C7B0", Offset = "0x1A5B5B0", VA = "0x181A5C7B0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Rect DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1A5C400", Offset = "0x1A5B200", VA = "0x181A5C400", Slot = "5")]
	public Rect CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class BLDHJOCFMKI : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private static class KCGNNLCGFOC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB570", Offset = "0x3CCA370", VA = "0x183CCB570")]
		static KCGNNLCGFOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private BLDHJOCFMKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class HCDAEMPJJEB : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private static class DCGMAOPICJH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x404A360", Offset = "0x4049160", VA = "0x18404A360")]
		static DCGMAOPICJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class GDAOEFFGPPA
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> JHIBEHPKCIO;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1B74BB0", Offset = "0x1B739B0", VA = "0x181B74BB0")]
		internal static object EIKOHJLJIFP(Type PHLICBNKKOO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private HCDAEMPJJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class GGNGBILKMFO : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class MFOONCMNNPA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4019DB0", Offset = "0x4018BB0", VA = "0x184019DB0")]
		static MFOONCMNNPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GGNGBILKMFO JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool LBEEBEHJLLO;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static CDJJKNODMKB[] PIENADLFNJC;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static CDAHFIMKBKG[] JLABIGIAGBJ;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private GGNGBILKMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1A4D610", Offset = "0x1A4C410", VA = "0x181A4D610")]
	public static void MNFGPLMIANE(params CDAHFIMKBKG[] JLABIGIAGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1A4D6F0", Offset = "0x1A4C4F0", VA = "0x181A4D6F0")]
	public static void MNFGPLMIANE(params CDJJKNODMKB[] PIENADLFNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1A4D380", Offset = "0x1A4C180", VA = "0x181A4D380")]
	public static void LJMIBIDPLGA(CDJJKNODMKB[] PIENADLFNJC, CDAHFIMKBKG[] JLABIGIAGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class ODLHOIMEGHG : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class PKIPCNEFLKJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4668D60", Offset = "0x4667B60", VA = "0x184668D60")]
		static PKIPCNEFLKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private ODLHOIMEGHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class AGJMJOBEIKL
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly CDAHFIMKBKG DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly CDAHFIMKBKG JHKEGNNFECH;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly CDAHFIMKBKG BCKLHKHKBJP;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly CDAHFIMKBKG IKNHFNAAPBN;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly CDAHFIMKBKG OAHKBKDIJOH;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly CDAHFIMKBKG OKJJEOFCIAP;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly CDAHFIMKBKG CFKANGOLLFE;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly CDAHFIMKBKG DIFHJDAIBNO;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly CDAHFIMKBKG KNLFFEFDIJO;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly CDAHFIMKBKG ALABHLGHDIB;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly CDAHFIMKBKG FLMGCLOLJEH;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly CDAHFIMKBKG DKKJHHJBMHP;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class ECOLPANJCNL
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly CDAHFIMKBKG DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly CDAHFIMKBKG ODBEBMBOKMA;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class NJBFENCIDEJ
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly CDAHFIMKBKG DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly CDAHFIMKBKG JHKEGNNFECH;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly CDAHFIMKBKG BCKLHKHKBJP;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly CDAHFIMKBKG IKNHFNAAPBN;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly CDAHFIMKBKG OAHKBKDIJOH;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly CDAHFIMKBKG OKJJEOFCIAP;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly CDAHFIMKBKG CFKANGOLLFE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly CDAHFIMKBKG DIFHJDAIBNO;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly CDAHFIMKBKG KNLFFEFDIJO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly CDAHFIMKBKG ALABHLGHDIB;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly CDAHFIMKBKG FLMGCLOLJEH;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly CDAHFIMKBKG DKKJHHJBMHP;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class BGLLJGGAMHC
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> JHIBEHPKCIO;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1A33C80", Offset = "0x1A32A80", VA = "0x181A33C80")]
	internal static object EIKOHJLJIFP(Type PHLICBNKKOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1A33C40", Offset = "0x1A32A40", VA = "0x181A33C40")]
	private static object BGPGCJBAIFG(Type ACPIPFHPMJO, Type[] IGMAMEINBIE, params object[] NGACEPLFOCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class CJPKFMLJIEE : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private static class LGJPJLKPHKF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2E747D0", Offset = "0x2E735D0", VA = "0x182E747D0")]
		static LGJPJLKPHKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly PIHKFLFDJIM DICGHOMBDEC;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1A39920", Offset = "0x1A38720", VA = "0x181A39920")]
	static CJPKFMLJIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private CJPKFMLJIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class FJLBDHABGHJ : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private static class CGECFOAGJEP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x47CCC00", Offset = "0x47CBA00", VA = "0x1847CCC00")]
		static CGECFOAGJEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly PIHKFLFDJIM DICGHOMBDEC;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1A4B110", Offset = "0x1A49F10", VA = "0x181A4B110")]
	static FJLBDHABGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private FJLBDHABGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class FBPKBLEIIFO : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class JBLLGFFBHPH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x40F1AB0", Offset = "0x40F08B0", VA = "0x1840F1AB0")]
		static JBLLGFFBHPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly PIHKFLFDJIM DICGHOMBDEC;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1A4AE80", Offset = "0x1A49C80", VA = "0x181A4AE80")]
	static FBPKBLEIIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private FBPKBLEIIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class KNJPNBBDAEK : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class JAMOHAPOAMN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x40EE6D0", Offset = "0x40ED4D0", VA = "0x1840EE6D0")]
		static JAMOHAPOAMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly PIHKFLFDJIM DICGHOMBDEC;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1A5F9A0", Offset = "0x1A5E7A0", VA = "0x181A5F9A0")]
	static KNJPNBBDAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private KNJPNBBDAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class KHJPPMNELLF : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class PJLKGPDHBCG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4663F40", Offset = "0x4662D40", VA = "0x184663F40")]
		static PJLKGPDHBCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly PIHKFLFDJIM DICGHOMBDEC;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1A5D360", Offset = "0x1A5C160", VA = "0x181A5D360")]
	static KHJPPMNELLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private KHJPPMNELLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class MDJOHNFJFHG : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class MGBLGEIMBLN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4022A70", Offset = "0x4021870", VA = "0x184022A70")]
		static MGBLGEIMBLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly PIHKFLFDJIM DICGHOMBDEC;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1B7E9F0", Offset = "0x1B7D7F0", VA = "0x181B7E9F0")]
	static MDJOHNFJFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private MDJOHNFJFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class CECPGEIAPNF : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class NOMKHHGAIGF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4C3D960", Offset = "0x4C3C760", VA = "0x184C3D960")]
		static NOMKHHGAIGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public CECPGEIAPNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class GLODEEBEBII : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class ILFFANBJIBG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3670290", Offset = "0x366F090", VA = "0x183670290")]
		static ILFFANBJIBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public GLODEEBEBII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class BGCLDIGJJHB : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class MKKPAGGPMGN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x38244A0", Offset = "0x38232A0", VA = "0x1838244A0")]
		static MKKPAGGPMGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public BGCLDIGJJHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class HHOMMOMADNJ : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class MOMAENBEGOD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x425EB10", Offset = "0x425D910", VA = "0x18425EB10")]
		static MOMAENBEGOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public HHOMMOMADNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class CMOIFPEHMBK : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class GHNIFJPMEMJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x42913F0", Offset = "0x42901F0", VA = "0x1842913F0")]
		static GHNIFJPMEMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public CMOIFPEHMBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class LEDLFMHEEGL : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class IEGFPBEKHOF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x32D3220", Offset = "0x32D2020", VA = "0x1832D3220")]
		static IEGFPBEKHOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> OIIGLIFPNHJ;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool AGBBGFGAMEG;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public LEDLFMHEEGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class EFJDNHIOLDH
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private struct DGGCCEPMDKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CBFDBJMKKPC JOOFEAOMDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder DOGHAALBHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder PHGJGNCCNKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class GOMOHFMOGEC
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		internal static class KOBIIKJCLEI
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo ECGNOGMJIHL;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo LCEEOJLNJKB;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo HCGOJFHGJMA;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo ACGFANIMLLF;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo NKCDOFJGNPN;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo DOLBMMDCGFI;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo BKHBHOFPCJF;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo PMDNJADPMLN;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo JDDGMFKNGNB;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x1B7CBD0", Offset = "0x1B7B9D0", VA = "0x181B7CBD0")]
			static KOBIIKJCLEI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class MCOANKHDEKO
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo DMPKDDCHJEK;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo BBBKDHEIDDK;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo HNDCLIHGIJK;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo AADBJEAGBMM;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo FFCOHGHEJCL;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo OCGCLACNCPH;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo JMGKDDIDBEG;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x1B7DE00", Offset = "0x1B7CC00", VA = "0x181B7DE00")]
			static MCOANKHDEKO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class FOFAFHMBCFE
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo HEDCAMCHEDF;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo LKDNMFKNBEI;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo GIEBOFOEIAH;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo DPCKLAFOJEE;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo FLBCJNPNFPH;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo HGOMKJGKBLP;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo GPDDHMFHDGG;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo NOCFGHALDIF;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo MPIKNOCDJFH;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo MPAHOFFIHCE;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo JJEFOBAJOJI;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo DBIGAILGJAI;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo DDBGBMCBFAG;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo NNGPBPJAHBB;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x1B77090", Offset = "0x1B75E90", VA = "0x181B77090")]
		public static MethodInfo PNKNJNLKBEB(Type IGEIBCJNCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1B76CE0", Offset = "0x1B75AE0", VA = "0x181B76CE0")]
		public static MethodInfo CJKIJAOEIBM(Type IGEIBCJNCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1B76F50", Offset = "0x1B75D50", VA = "0x181B76F50")]
		public static MethodInfo FBNJCJLNKHJ(Type IGEIBCJNCHF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class FMOPIOLPFPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<CBFDBJMKKPC, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public FMOPIOLPFPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class KFAKIIKLPMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public FMOPIOLPFPK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public KFAKIIKLPMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1B7C980", Offset = "0x1B7B780", VA = "0x181B7C980")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1B7C9C0", Offset = "0x1B7B7C0", VA = "0x181B7C9C0")]
		internal bool <BuildType>b__2(int index, CBFDBJMKKPC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class MHHKLKADNDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public FMOPIOLPFPK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public MHHKLKADNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1B7F9C0", Offset = "0x1B7E7C0", VA = "0x181B7F9C0")]
		internal bool <BuildType>b__3(int index, CBFDBJMKKPC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class PNDBIIMJNNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Func<string, string> nameMutator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public List<object> serializeCustomFormatters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public List<object> deserializeCustomFormatters;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public PNDBIIMJNNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1B83B40", Offset = "0x1B82940", VA = "0x181B83B40")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class JDCKILEFKMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public JDCKILEFKMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1B7A800", Offset = "0x1B79600", VA = "0x181B7A800")]
		internal bool <BuildAnonymousFormatter>b__2(CBFDBJMKKPC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class AMNKGLPIKFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public PNDBIIMJNNA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public AMNKGLPIKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x1B72A70", Offset = "0x1B71870", VA = "0x181B72A70")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x1B72A80", Offset = "0x1B71880", VA = "0x181B72A80")]
		internal bool <BuildAnonymousFormatter>b__6(int index, CBFDBJMKKPC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class CPIFPAPGGEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public PNDBIIMJNNA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public CPIFPAPGGEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x1B732F0", Offset = "0x1B720F0", VA = "0x181B732F0")]
		internal bool <BuildAnonymousFormatter>b__7(int index, CBFDBJMKKPC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class HGIGEBGKJMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public HGIGEBGKJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xB48F20", Offset = "0xB47D20", VA = "0x180B48F20")]
		internal Label <BuildSerialize>b__1(CBFDBJMKKPC _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class EPLOINHIGOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public DGGCCEPMDKG[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, CBFDBJMKKPC, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public PJJOBJKEALJ argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public PJJOBJKEALJ argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public EPLOINHIGOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x1B73F20", Offset = "0x1B72D20", VA = "0x181B73F20")]
		internal DGGCCEPMDKG <BuildDeserialize>b__0(CBFDBJMKKPC item)
		{
			return default(DGGCCEPMDKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class HNEDLNLDLPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public EPLOINHIGOD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public HNEDLNLDLPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1B78D80", Offset = "0x1B77B80", VA = "0x181B78D80")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x1B79030", Offset = "0x1B77E30", VA = "0x181B79030")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JFGNABILADP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CBFDBJMKKPC item;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public JFGNABILADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x1B7A860", Offset = "0x1B79660", VA = "0x181B7A860")]
		internal bool <EmitNewObject>b__0(DGGCCEPMDKG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class JPEGOAALFLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CBFDBJMKKPC item;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public JPEGOAALFLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1B7A860", Offset = "0x1B79660", VA = "0x181B7A860")]
		internal bool <EmitNewObject>b__2(DGGCCEPMDKG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex MFDKAAMIIMA;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int EONJGOCKLGC;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> LHEBNCEKONA;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> GGPHIDOFABB;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3D1FC80", Offset = "0x3D1EA80", VA = "0x183D1FC80")]
	public static object IJPOKECMDKG<T>(PIHKFLFDJIM DICGHOMBDEC, CDAHFIMKBKG IILLNBABLOM, Func<string, string> OIIGLIFPNHJ, bool AGBBGFGAMEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3D152C0", Offset = "0x3D140C0", VA = "0x183D152C0")]
	public static object DPLNNNNKBBM<T>(CDAHFIMKBKG IILLNBABLOM, Func<string, string> OIIGLIFPNHJ, bool AGBBGFGAMEG, bool HJBKCEHLOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1A402E0", Offset = "0x1A3F0E0", VA = "0x181A402E0")]
	private static TypeInfo FLFEKAMFFLD(PIHKFLFDJIM DICGHOMBDEC, Type IGEIBCJNCHF, Func<string, string> OIIGLIFPNHJ, bool AGBBGFGAMEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1A419C0", Offset = "0x1A407C0", VA = "0x181A419C0")]
	public static object GKJCAGGOCLM(Type IGEIBCJNCHF, Func<string, string> OIIGLIFPNHJ, bool AGBBGFGAMEG, bool HJBKCEHLOIL, bool ANDBLJMMEHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1A459B0", Offset = "0x1A447B0", VA = "0x181A459B0")]
	private static Dictionary<CBFDBJMKKPC, FieldInfo> LNMMELHJCEK(TypeBuilder CAPKONDANCB, LIAFLHMCAMO FEPBBMGBAMP, ConstructorInfo JONBJLGFOKN, FieldBuilder OMIOLIFDAGC, ILGenerator GMOLGNOIGAN, bool AGBBGFGAMEG, bool PNBDNLNLJJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1A40D70", Offset = "0x1A3FB70", VA = "0x181A40D70")]
	private static Dictionary<CBFDBJMKKPC, FieldInfo> GILCJJHNGMA(TypeBuilder CAPKONDANCB, LIAFLHMCAMO FEPBBMGBAMP, ILGenerator GMOLGNOIGAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1A47270", Offset = "0x1A46070", VA = "0x181A47270")]
	private static void NGGDNOAHCJD(Type IGEIBCJNCHF, LIAFLHMCAMO FEPBBMGBAMP, ILGenerator GMOLGNOIGAN, Action FAKADEDHFNJ, Func<int, CBFDBJMKKPC, bool> ALNECDIBMGI, bool AGBBGFGAMEG, bool PNBDNLNLJJM, int CIPCKOFIFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1A44F90", Offset = "0x1A43D90", VA = "0x181A44F90")]
	private static void IOPGECPBKMA(TypeInfo IGEIBCJNCHF, CBFDBJMKKPC LBEKFHGAHGE, ILGenerator GMOLGNOIGAN, int NPDGHPHAKDK, Func<int, CBFDBJMKKPC, bool> ALNECDIBMGI, PJJOBJKEALJ GAKCPFEFIJJ, PJJOBJKEALJ KJEDNAOJNLJ, PJJOBJKEALJ NEGCAAGBPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1A43540", Offset = "0x1A42340", VA = "0x181A43540")]
	private static void GNBLKMBBIJF(Type IGEIBCJNCHF, LIAFLHMCAMO FEPBBMGBAMP, ILGenerator GMOLGNOIGAN, Func<int, CBFDBJMKKPC, bool> ALNECDIBMGI, bool CKMKBFKEKIL, int CIPCKOFIFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x1A454E0", Offset = "0x1A442E0", VA = "0x181A454E0")]
	private static void JEAIIHBBHKJ(ILGenerator GMOLGNOIGAN, DGGCCEPMDKG FEPBBMGBAMP, int NPDGHPHAKDK, Func<int, CBFDBJMKKPC, bool> ALNECDIBMGI, PJJOBJKEALJ NINBMPMOGGB, PJJOBJKEALJ NEGCAAGBPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1A46300", Offset = "0x1A45100", VA = "0x181A46300")]
	private static LocalBuilder MACLACDLIJE(ILGenerator GMOLGNOIGAN, Type IGEIBCJNCHF, LIAFLHMCAMO FEPBBMGBAMP, DGGCCEPMDKG[] CGIFNFBKLIF, bool FMKHDCDJHFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x1A3FBE0", Offset = "0x1A3E9E0", VA = "0x181A3FBE0")]
	private static bool EPJFGLIMFCI(ConstructorInfo FHLIEOMAOEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1A3FA30", Offset = "0x1A3E830", VA = "0x181A3FA30")]
	private static bool EDKKCHJBMKH(Type IGEIBCJNCHF, out Type FKBLILCIFMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal delegate void GIDIOLFHIME<T>(byte[][] OMIOLIFDAGC, object[] CHFGFHNKBDM, ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG OHIDBDNDNIA);
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate T PLNPNMGJDNN<T>(object[] CHFGFHNKBDM, ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG OHIDBDNDNIA);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class ACPMJLPHJPI<T> : global::KBIOLGDHIDG<T>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] OMIOLIFDAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] LLBMAHJCIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] MPLALGKPMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly global::GIDIOLFHIME<T> GFCAPLHGOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly global::PLNPNMGJDNN<T> CODKEDJGDDE;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x41381C0", Offset = "0x4136FC0", VA = "0x1841381C0")]
	public ACPMJLPHJPI(byte[][] OMIOLIFDAGC, object[] LLBMAHJCIKM, object[] MPLALGKPMJL, global::GIDIOLFHIME<T> GFCAPLHGOPK, global::PLNPNMGJDNN<T> CODKEDJGDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x457AD20", Offset = "0x4579B20", VA = "0x18457AD20", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x457AC50", Offset = "0x4579A50", VA = "0x18457AC50", Slot = "5")]
	public T CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class KFFBKOPBLEG : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class EKAAGPLAEAD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3D8CB60", Offset = "0x3D8B960", VA = "0x183D8CB60")]
		static EKAAGPLAEAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private KFFBKOPBLEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class KLLNGKPOECJ : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private static class JEJIMJOIPDK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7820", Offset = "0x3DC6620", VA = "0x183DC7820")]
		static JEJIMJOIPDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private KLLNGKPOECJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal static class HBAHMBDALEH
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly CDAHFIMKBKG[] ANDNFDGCKFC;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal sealed class GNEBIFLNHFD : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private static class COPAFAFMCAO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4708880", Offset = "0x4707680", VA = "0x184708880")]
		static COPAFAFMCAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private sealed class LJGNDLMNFDN : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		private static class PFMAFLOAAKP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x465B170", Offset = "0x4659F70", VA = "0x18465B170")]
			static PFMAFLOAAKP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		private LJGNDLMNFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private GNEBIFLNHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class ODBFHJMKEBH : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class OPMKCMACNHI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4B38CC0", Offset = "0x4B37AC0", VA = "0x184B38CC0")]
		static OPMKCMACNHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class MKCIHGFPPBG : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class ALJPBLHIALB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4005420", Offset = "0x4004220", VA = "0x184005420")]
			static ALJPBLHIALB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		private MKCIHGFPPBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private ODBFHJMKEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class PPENPNGBGBD : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class DEOFKMOKBPD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x404EB60", Offset = "0x404D960", VA = "0x18404EB60")]
		static DEOFKMOKBPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class GDOLMALLAHA : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class OLFCIJBBPLI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x39D4410", Offset = "0x39D3210", VA = "0x1839D4410")]
			static OLFCIJBBPLI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		private GDOLMALLAHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private PPENPNGBGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class LDDDILGNKMF : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class FIGKMCBBOFL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x43659C0", Offset = "0x43647C0", VA = "0x1843659C0")]
		static FIGKMCBBOFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class IHOIEDEKMCD : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class CKHCMANDEHJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x46F00C0", Offset = "0x46EEEC0", VA = "0x1846F00C0")]
			static CKHCMANDEHJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		private IHOIEDEKMCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private LDDDILGNKMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class JLHNAEDKOJL : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class MODJBPEPNDF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4258AE0", Offset = "0x42578E0", VA = "0x184258AE0")]
		static MODJBPEPNDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class PLBGDGHKHIA : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class MCDCBGBBJKL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x400B8E0", Offset = "0x400A6E0", VA = "0x18400B8E0")]
			static MCDCBGBBJKL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		private PLBGDGHKHIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private JLHNAEDKOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class BHKGDDMEEAL : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class FJJCMEGDCGP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x436A740", Offset = "0x4369540", VA = "0x18436A740")]
		static FJJCMEGDCGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class JMMKCJHEIEK : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class KMDJJLDGLPK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x4139CA0", Offset = "0x4138AA0", VA = "0x184139CA0")]
			static KMDJJLDGLPK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		private JMMKCJHEIEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private BHKGDDMEEAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class DGHHNPLNPDO : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class NAKGEBHCAAC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3B9EBD0", Offset = "0x3B9D9D0", VA = "0x183B9EBD0")]
		static NAKGEBHCAAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class HJBJEPNMCON : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class OJOAKPANKCI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x39C91B0", Offset = "0x39C7FB0", VA = "0x1839C91B0")]
			static OJOAKPANKCI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		private HJBJEPNMCON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private DGHHNPLNPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class FJDHAHKOENG : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class IFLJHHJHEKI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x32DB510", Offset = "0x32DA310", VA = "0x1832DB510")]
		static IFLJHHJHEKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class PMJDKPDGLEL : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class OOOBNFNGLIC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x39DB6A0", Offset = "0x39DA4A0", VA = "0x1839DB6A0")]
			static OOOBNFNGLIC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		private PMJDKPDGLEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private FJDHAHKOENG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class HCCKNHLJDIN : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class EPLDELMLBLG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2CD64B0", Offset = "0x2CD52B0", VA = "0x182CD64B0")]
		static EPLDELMLBLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class BMALJEEGFBG : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class MFMLLAAOKGK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x4013EA0", Offset = "0x4012CA0", VA = "0x184013EA0")]
			static MFMLLAAOKGK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		private BMALJEEGFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private HCCKNHLJDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class BFBFLAJFEOC : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class FOBCMGHKIFD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3FE4C10", Offset = "0x3FE3A10", VA = "0x183FE4C10")]
		static FOBCMGHKIFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class FCBFKIMJJMA : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class IBHLMNCHNGD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x50562D0", Offset = "0x50550D0", VA = "0x1850562D0")]
			static IBHLMNCHNGD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		private FCBFKIMJJMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private BFBFLAJFEOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class GDJFJAGPDED : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class AIJHJCKGKLN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3FF9AA0", Offset = "0x3FF88A0", VA = "0x183FF9AA0")]
		static AIJHJCKGKLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class OFBABBOEIJP : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class ODCNABPPEGP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x3BC9BA0", Offset = "0x3BC89A0", VA = "0x183BC9BA0")]
			static ODCNABPPEGP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		private OFBABBOEIJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private GDJFJAGPDED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class GOCHKKMAAJM : CDAHFIMKBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class KCHIKLKJJFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3430", Offset = "0x3CD2230", VA = "0x183CD3430")]
		static KCHIKLKJJFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class ELGMOAKMBDE : CDAHFIMKBKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class JJLECOOIHBO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly global::KBIOLGDHIDG<T> FPNABJGJBNN;

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x45965D0", Offset = "0x45953D0", VA = "0x1845965D0")]
			static JJLECOOIHBO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly CDAHFIMKBKG[] JLABIGIAGBJ;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		private ELGMOAKMBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
		public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly CDAHFIMKBKG JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly global::KBIOLGDHIDG<object> EPHGOGDCINO;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	private GOCHKKMAAJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x33C4EB0", Offset = "0x33C3CB0", VA = "0x1833C4EB0", Slot = "4")]
	public global::KBIOLGDHIDG<T> EIKOHJLJIFP<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct GJFGIFNNEBL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] CNDDJJHKADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int FGDMPDNAJLP;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4299AD0", Offset = "0x42988D0", VA = "0x184299AD0")]
	public GJFGIFNNEBL(int KDNFGAPAIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x42999E0", Offset = "0x42987E0", VA = "0x1842999E0")]
	public void HMNAIPBHJIK(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4299950", Offset = "0x4298750", VA = "0x184299950")]
	public T[] CCDPKGMDNKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
internal sealed class LJKNBFDOLJK : global::AJCIIEGBJNM<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly LJKNBFDOLJK DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x1A61CD0", Offset = "0x1A60AD0", VA = "0x181A61CD0")]
	public LJKNBFDOLJK(int DBLELDNIPAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal class AJCIIEGBJNM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int DBLELDNIPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object DHIAMAJOONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int NPDGHPHAKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] OJCECCMMNMI;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3FFFC60", Offset = "0x3FFEA60", VA = "0x183FFFC60")]
	public AJCIIEGBJNM(int DBLELDNIPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3FFF6B0", Offset = "0x3FFE4B0", VA = "0x183FFF6B0")]
	public T[] LLOOOOJPPGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3FFEC30", Offset = "0x3FFDA30", VA = "0x183FFEC30")]
	public void JKLJAMMNEFN(T[] DBOPJMNFJMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class CMMEILIOKNM : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class IHGODOLCLPH : IComparable<IHGODOLCLPH>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class KHKLBGOACFO : IEnumerable<IHGODOLCLPH>, IEnumerable, IEnumerator<IHGODOLCLPH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private IHGODOLCLPH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public IHGODOLCLPH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private IHGODOLCLPH System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F0")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F2")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x973950", Offset = "0x972750", VA = "0x180973950")]
			[DebuggerHidden]
			public KHKLBGOACFO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1B7CA60", Offset = "0x1B7B860", VA = "0x181B7CA60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x1B7CB90", Offset = "0x1B7B990", VA = "0x181B7CB90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x1B7CAF0", Offset = "0x1B7B8F0", VA = "0x181B7CAF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IHGODOLCLPH> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1B7CAF0", Offset = "0x1B7B8F0", VA = "0x181B7CAF0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class GHHIMKFDFIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public GHHIMKFDFIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xB48F20", Offset = "0xB47D20", VA = "0x180B48F20")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xB48F20", Offset = "0xB47D20", VA = "0x180B48F20")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly IHGODOLCLPH[] LPNNJLEHNKA;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] KNDOBIAOGFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong GDJDAALKGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int FBCEGMCNEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string MGOAODFOCMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IHGODOLCLPH[] OAEMGMMPBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] EKAICALIKEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int MIOCJKOOLBL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool FMCJMLDEIBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1B79DF0", Offset = "0x1B78BF0", VA = "0x181B79DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x1B7A580", Offset = "0x1B79380", VA = "0x181B7A580")]
		public IHGODOLCLPH(ulong PIIJMEAKDGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x1B7A020", Offset = "0x1B78E20", VA = "0x181B7A020")]
		public IHGODOLCLPH HMNAIPBHJIK(ulong PIIJMEAKDGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x1B7A2E0", Offset = "0x1B790E0", VA = "0x181B7A2E0")]
		public IHGODOLCLPH HMNAIPBHJIK(ulong PIIJMEAKDGO, int DFEOJBAFBHE, string MGOAODFOCMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1B79E00", Offset = "0x1B78C00", VA = "0x181B79E00")]
		public IHGODOLCLPH GMIKDGHMNKA(byte[] ONINKGDNEEG, ref int PNKNABOKANH, ref int CMJGLNDNCNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x1B7A330", Offset = "0x1B79130", VA = "0x181B7A330")]
		internal static int KCLJJJFFICB(ulong[] DBOPJMNFJMA, int NPDGHPHAKDK, int MFAHIHFAKKH, ulong DFEOJBAFBHE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1B790D0", Offset = "0x1B77ED0", VA = "0x181B790D0", Slot = "4")]
		public int CompareTo(IHGODOLCLPH KICLNADFIEK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1B79FB0", Offset = "0x1B78DB0", VA = "0x181B79FB0")]
		[IteratorStateMachine(typeof(KHKLBGOACFO))]
		public IEnumerable<IHGODOLCLPH> GNFHEEJAEGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x1B7A3B0", Offset = "0x1B791B0", VA = "0x181B7A3B0")]
		public void KDEABOMAKCB(ILGenerator GMOLGNOIGAN, LocalBuilder ONINKGDNEEG, LocalBuilder CMJGLNDNCNL, LocalBuilder PIIJMEAKDGO, Action<KeyValuePair<string, int>> JPJILGHCBKO, Action GEPHKHMEKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x1B79100", Offset = "0x1B77F00", VA = "0x181B79100")]
		private static void DCPLLKKNDDE(ILGenerator GMOLGNOIGAN, LocalBuilder ONINKGDNEEG, LocalBuilder CMJGLNDNCNL, LocalBuilder PIIJMEAKDGO, Action<KeyValuePair<string, int>> JPJILGHCBKO, Action GEPHKHMEKID, IHGODOLCLPH[] OAEMGMMPBNA, int MIOCJKOOLBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class EJDADOFHLCO : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private IEnumerable<IHGODOLCLPH> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<IHGODOLCLPH> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<IHGODOLCLPH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private IHGODOLCLPH <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x9FCE90", Offset = "0x9FBC90", VA = "0x1809FCE90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1B739D0", Offset = "0x1B727D0", VA = "0x181B739D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF30", Offset = "0x9FBD30", VA = "0x1809FCF30")]
		[DebuggerHidden]
		public EJDADOFHLCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1B73A20", Offset = "0x1B72820", VA = "0x181B73A20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1B73490", Offset = "0x1B72290", VA = "0x181B73490", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x1B73B00", Offset = "0x1B72900", VA = "0x181B73B00")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1B73B50", Offset = "0x1B72950", VA = "0x181B73B50")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1B73990", Offset = "0x1B72790", VA = "0x181B73990", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1B738F0", Offset = "0x1B726F0", VA = "0x181B738F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1B738F0", Offset = "0x1B726F0", VA = "0x181B738F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly IHGODOLCLPH JMLKLPJONJN;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x1A3D640", Offset = "0x1A3C440", VA = "0x181A3D640")]
	public CMMEILIOKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x1A3D150", Offset = "0x1A3BF50", VA = "0x181A3D150")]
	public void HMNAIPBHJIK(byte[] CCFMJPPGPDK, int DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1A3CFE0", Offset = "0x1A3BDE0", VA = "0x181A3CFE0")]
	public bool BGHOFGEILHM(ArraySegment<byte> PIIJMEAKDGO, out int DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x1A3D5B0", Offset = "0x1A3C3B0", VA = "0x181A3D5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x1A3D270", Offset = "0x1A3C070", VA = "0x181A3D270")]
	private static void JKCDCNPMDPD(IEnumerable<IHGODOLCLPH> OAEMGMMPBNA, StringBuilder FMGHJPGOLOC, int HFAPDGCFEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x1A3D0A0", Offset = "0x1A3BEA0", VA = "0x181A3D0A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x1A3D0A0", Offset = "0x1A3BEA0", VA = "0x181A3D0A0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1A3D540", Offset = "0x1A3C340", VA = "0x181A3D540")]
	[IteratorStateMachine(typeof(EJDADOFHLCO))]
	private static IEnumerable<KeyValuePair<string, int>> PKOEPJJOFPL(IEnumerable<IHGODOLCLPH> OAEMGMMPBNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x1A3D510", Offset = "0x1A3C310", VA = "0x181A3D510")]
	public void LAKJFDLOJDN(ILGenerator GMOLGNOIGAN, LocalBuilder ONINKGDNEEG, LocalBuilder CMJGLNDNCNL, LocalBuilder PIIJMEAKDGO, Action<KeyValuePair<string, int>> JPJILGHCBKO, Action GEPHKHMEKID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public static class HLJPGHGJHHM
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo FPINLFOFPGF;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x1A53CF0", Offset = "0x1A52AF0", VA = "0x181A53CF0")]
	public static ulong KBKJCHLIDOC(byte[] CCFMJPPGPDK, ref int PNKNABOKANH, ref int CMJGLNDNCNL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class JONHBIDNLNI
{
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x1A5C090", Offset = "0x1A5AE90", VA = "0x181A5C090")]
	public static void AGBJIBCDJKP(ref byte[] CCFMJPPGPDK, int PNKNABOKANH, int PLINPOKNGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x1A5C2F0", Offset = "0x1A5B0F0", VA = "0x181A5C2F0")]
	public static void OKOKMCKMGCK(ref byte[] DBOPJMNFJMA, int AODBOJHBLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x1A5C1D0", Offset = "0x1A5AFD0", VA = "0x181A5C1D0")]
	public static byte[] HHIPDOBHHEA(byte[] PPLEFHADAKM, int AODBOJHBLIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class KMLAGGFFAMP
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x1A5F910", Offset = "0x1A5E710", VA = "0x181A5F910")]
	public static bool NOHLHLNDIHM(byte[] OBEOMBGDJFP, int IPNAKKGEBOA, int FGHAGODBCCI, byte[] CKLCCOABNHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class BMGANMGKAHN<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private struct GJFAGGGEGGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] GDJDAALKGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T FBCEGMCNEND;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4294BC0", Offset = "0x42939C0", VA = "0x184294BC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class NEBBINDBHLP : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public global::BMGANMGKAHN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private GJFAGGGEGGG[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private GJFAGGGEGGG[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x9FCE90", Offset = "0x9FBC90", VA = "0x1809FCE90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x429BBE0", Offset = "0x429A9E0", VA = "0x18429BBE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2E6EE50", Offset = "0x2E6DC50", VA = "0x182E6EE50")]
		[DebuggerHidden]
		public NEBBINDBHLP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x43A13E0", Offset = "0x43A01E0", VA = "0x1843A13E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x43A1600", Offset = "0x43A0400", VA = "0x1843A1600", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly GJFAGGGEGGG[][] MINCIBHBDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong PEJKBIJBOOK;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3BF4900", Offset = "0x3BF3700", VA = "0x183BF4900")]
	public BMGANMGKAHN(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3BF4840", Offset = "0x3BF3640", VA = "0x183BF4840")]
	public BMGANMGKAHN(int CIMAPKKBLKM, float AIAJNIBFPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3BF25A0", Offset = "0x3BF13A0", VA = "0x183BF25A0")]
	public void HMNAIPBHJIK(byte[] PIIJMEAKDGO, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x3BF29E0", Offset = "0x3BF17E0", VA = "0x183BF29E0")]
	private bool OAKJNCACAHH(byte[] PIIJMEAKDGO, T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1190", Offset = "0x3BEFF90", VA = "0x183BF1190")]
	public bool HADOILGNPLN(ArraySegment<byte> PIIJMEAKDGO, out T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0F50", Offset = "0x3BEFD50", VA = "0x183BF0F50")]
	private static ulong CKBNHOHNGGM(byte[] JMDPDGBMGAA, int PNKNABOKANH, int MIOCJKOOLBL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0FB0", Offset = "0x3BEFDB0", VA = "0x183BF0FB0")]
	private static int FHAJNIKHOMP(int DIICGEKFLNM, float AIAJNIBFPHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0FE0", Offset = "0x3BEFDE0", VA = "0x183BF0FE0", Slot = "4")]
	[IteratorStateMachine(typeof(global::BMGANMGKAHN<>.NEBBINDBHLP))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x37CA7D0", Offset = "0x37C95D0", VA = "0x1837CA7D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal class FOLFFOLONFM : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] JGAIELANPLI;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] MMKKHLEKMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int NLLEBPMJKKL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool HAFGDHNCMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1A4B5D0", Offset = "0x1A4A3D0", VA = "0x181A4B5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x1A4B620", Offset = "0x1A4A420", VA = "0x181A4B620")]
	static FOLFFOLONFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x1A4B8A0", Offset = "0x1A4A6A0", VA = "0x181A4B8A0")]
	public FOLFFOLONFM(byte[] FCMKMKJKCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x1A4B4B0", Offset = "0x1A4A2B0", VA = "0x181A4B4B0")]
	public OpCode COOKDKDCEGO()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal struct PNNMAEBOONA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid FBCEGMCNEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte EBDMPKONBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte FPPNMDBBAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte NBONHCOJKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte LOBAGBFJBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte ECHJDNDEOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte BAILJHKEKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte KIPJAIDEFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte HNLNKNMFLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte PHILEKNLDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte AFGGAPPOJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte FCNBNDCBLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte BMPPKAFLFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte GNDFOHEKAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte JEKDLEADDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte HHFILOAEGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte AJHBLINCLCL;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] GKNIOHIKKEH;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] HAPOEMBPMPD;

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x1B865E0", Offset = "0x1B853E0", VA = "0x181B865E0")]
	public PNNMAEBOONA(ref Guid DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x1B85190", Offset = "0x1B83F90", VA = "0x181B85190")]
	public PNNMAEBOONA(ref ArraySegment<byte> DHPOKLJGCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x1B83BA0", Offset = "0x1B829A0", VA = "0x181B83BA0")]
	private static byte ANPDMILEAAN(byte[] CCFMJPPGPDK, int EOOBEEOOCPG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x1B84FB0", Offset = "0x1B83DB0", VA = "0x181B84FB0")]
	private static byte FBHALDBJLMA(byte OPGAGDBKIDA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x1B83C60", Offset = "0x1B82A60", VA = "0x181B83C60")]
	public void AOMBALNDCDK(byte[] FAHBHODOFIG, int PNKNABOKANH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class KKLLMHLNJII
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x1A5EA00", Offset = "0x1A5D800", VA = "0x181A5EA00")]
	public static bool KFBKCOLFCKC(byte NKNPGFCGIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x1A5EA80", Offset = "0x1A5D880", VA = "0x181A5EA80")]
	public static bool LOBLHDAKKHD(byte NKNPGFCGIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x1A5EA10", Offset = "0x1A5D810", VA = "0x181A5EA10")]
	public static sbyte LAFKMEOBIMG(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x1A5DCD0", Offset = "0x1A5CAD0", VA = "0x181A5DCD0")]
	public static short BMBFOFJNBJO(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x1A5E580", Offset = "0x1A5D380", VA = "0x181A5E580")]
	public static int ECLOENBFOKD(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1A5E950", Offset = "0x1A5D750", VA = "0x181A5E950")]
	public static long KEKOIEHBMDK(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x1A5DD40", Offset = "0x1A5CB40", VA = "0x181A5DD40")]
	public static byte BMNPLFFBDHN(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x1A5EB60", Offset = "0x1A5D960", VA = "0x181A5EB60")]
	public static ushort MMJEBNKOFCI(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x1A5F800", Offset = "0x1A5E600", VA = "0x181A5F800")]
	public static uint NBPDHMKLDBI(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x1A5DBC0", Offset = "0x1A5C9C0", VA = "0x181A5DBC0")]
	public static ulong BLIHAKGCIJH(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x1A5EAF0", Offset = "0x1A5D8F0", VA = "0x181A5EAF0")]
	public static float LPPGONDOCEI(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x1A5E860", Offset = "0x1A5D660", VA = "0x181A5E860")]
	public static double INAHBHNOCMF(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x1A5DDB0", Offset = "0x1A5CBB0", VA = "0x181A5DDB0")]
	public static int CBADJNLAMOA(ref byte[] FAHBHODOFIG, int PNKNABOKANH, ulong DFEOJBAFBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x1A5EBD0", Offset = "0x1A5D9D0", VA = "0x181A5EBD0")]
	public static int MOGMCLNCFEO(ref byte[] FAHBHODOFIG, int PNKNABOKANH, long DFEOJBAFBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1A5E5F0", Offset = "0x1A5D3F0", VA = "0x181A5E5F0")]
	public static bool FDNFEKDOMEM(byte[] CCFMJPPGPDK, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class HAEFKEOONCG
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class GBGDAPLFLEB : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x973950", Offset = "0x972750", VA = "0x180973950")]
		[DebuggerHidden]
		public GBGDAPLFLEB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x1B74A20", Offset = "0x1B73820", VA = "0x181B74A20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x1B745C0", Offset = "0x1B733C0", VA = "0x181B745C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1B74B10", Offset = "0x1B73910", VA = "0x181B74B10")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x1B74B60", Offset = "0x1B73960", VA = "0x181B74B60")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1B749E0", Offset = "0x1B737E0", VA = "0x181B749E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1B74930", Offset = "0x1B73730", VA = "0x181B74930", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1B74930", Offset = "0x1B73730", VA = "0x181B74930", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class OEEMAPLNAPG : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x973950", Offset = "0x972750", VA = "0x180973950")]
		[DebuggerHidden]
		public OEEMAPLNAPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1B82180", Offset = "0x1B80F80", VA = "0x181B82180", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1B81D20", Offset = "0x1B80B20", VA = "0x181B81D20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1B82270", Offset = "0x1B81070", VA = "0x181B82270")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1B822C0", Offset = "0x1B810C0", VA = "0x181B822C0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1B82140", Offset = "0x1B80F40", VA = "0x181B82140", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1B82090", Offset = "0x1B80E90", VA = "0x181B82090", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1B82090", Offset = "0x1B80E90", VA = "0x181B82090", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x1A4EDB0", Offset = "0x1A4DBB0", VA = "0x181A4EDB0")]
	public static bool PLDJOPFIMLL(this TypeInfo IGEIBCJNCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x1A4E9D0", Offset = "0x1A4D7D0", VA = "0x181A4E9D0")]
	public static bool DPNNMOPPIEF(this TypeInfo IGEIBCJNCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x1A4EC50", Offset = "0x1A4DA50", VA = "0x181A4EC50")]
	public static IEnumerable<PropertyInfo> NGOHJEPMOND(this Type IGEIBCJNCHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x1A4EBC0", Offset = "0x1A4D9C0", VA = "0x181A4EBC0")]
	[IteratorStateMachine(typeof(GBGDAPLFLEB))]
	private static IEnumerable<PropertyInfo> LEEJKPABABN(Type IGEIBCJNCHF, HashSet<string> ANGADFNDOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x1A4EAF0", Offset = "0x1A4D8F0", VA = "0x181A4EAF0")]
	public static IEnumerable<FieldInfo> JOFGLNPDLDN(this Type IGEIBCJNCHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x1A4ED20", Offset = "0x1A4DB20", VA = "0x181A4ED20")]
	[IteratorStateMachine(typeof(OEEMAPLNAPG))]
	private static IEnumerable<FieldInfo> OANFLKMDLIG(Type IGEIBCJNCHF, HashSet<string> ANGADFNDOON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal static class EFPPKBBLEJO
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding GBCOGIOICMC;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class JGCLDCOFAMM
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x86FF90", Offset = "0x86ED90", VA = "0x18086FF90")]
	public static string BHJJFJECEKN(string EEDIAOMNBHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x1A59C10", Offset = "0x1A58A10", VA = "0x181A59C10")]
	public static string NAJBNLDKMOP(string EEDIAOMNBHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x1A59A20", Offset = "0x1A58820", VA = "0x181A59A20")]
	public static string LKABFLDJDEN(string EEDIAOMNBHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class KLLFKEKDHGC<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class BNHBKLACBEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type GDJDAALKGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue FBCEGMCNEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int EOAMFFNMMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public BNHBKLACBEC DEAMFGIIJDN;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x489D840", Offset = "0x489C640", VA = "0x18489D840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x489D7C0", Offset = "0x489C5C0", VA = "0x18489D7C0")]
		private int BCBDBMHFMFJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public BNHBKLACBEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class OGHBFBMCBEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public OGHBFBMCBEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x77D710", Offset = "0x77C510", VA = "0x18077D710")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private BNHBKLACBEC[] MINCIBHBDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int BDHBBDMMOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object HKIJJDEGPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float AIAJNIBFPHN;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x4137BC0", Offset = "0x41369C0", VA = "0x184137BC0")]
	public KLLFKEKDHGC(int CIMAPKKBLKM = 4, float AIAJNIBFPHN = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x41378B0", Offset = "0x41366B0", VA = "0x1841378B0")]
	public bool PICFJGOPDMI(Type PIIJMEAKDGO, TValue DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4137870", Offset = "0x4136670", VA = "0x184137870")]
	public bool PICFJGOPDMI(Type PIIJMEAKDGO, Func<Type, TValue> MIJKOGKPCJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4137260", Offset = "0x4136060", VA = "0x184137260")]
	private bool OAKJNCACAHH(Type PIIJMEAKDGO, Func<Type, TValue> MIJKOGKPCJC, out TValue OPFPPHNBBOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x4136860", Offset = "0x4135660", VA = "0x184136860")]
	private bool FFONNINPLNB(BNHBKLACBEC[] MINCIBHBDDD, Type LCCAAEMJGBP, BNHBKLACBEC IKLFFKAOEKH, Func<Type, TValue> MIJKOGKPCJC, out TValue OPFPPHNBBOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x4137110", Offset = "0x4135F10", VA = "0x184137110")]
	public bool HADOILGNPLN(Type PIIJMEAKDGO, out TValue DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x41367B0", Offset = "0x41355B0", VA = "0x1841367B0")]
	public TValue FEAMCPOBIKK(Type PIIJMEAKDGO, Func<Type, TValue> MIJKOGKPCJC)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0FB0", Offset = "0x3BEFDB0", VA = "0x183BF0FB0")]
	private static int FHAJNIKHOMP(int DIICGEKFLNM, float AIAJNIBFPHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x4137800", Offset = "0x4136600", VA = "0x184137800")]
	private static void OIBBDLAEFLD(ref BNHBKLACBEC PJOJLPDBEPN, BNHBKLACBEC DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4137800", Offset = "0x4136600", VA = "0x184137800")]
	private static void OIBBDLAEFLD(ref BNHBKLACBEC[] PJOJLPDBEPN, BNHBKLACBEC[] DFEOJBAFBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class PIHKFLFDJIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder IDFCHCAGDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder IOLFHHHGMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object DHIAMAJOONL;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x1B834F0", Offset = "0x1B822F0", VA = "0x181B834F0")]
	public TypeBuilder AFKGNFIGDJP(string IADPDEAGFAB, TypeAttributes JLINONDCKCL, Type ICMEPOIJCJO, Type[] ENDOBJKFNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1B835C0", Offset = "0x1B823C0", VA = "0x181B835C0")]
	public PIHKFLFDJIM(string EHDPGGDPGCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal static class ICFGJHHLKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1A557F0", Offset = "0x1A545F0", VA = "0x181A557F0")]
	private static MethodInfo AALOPPLEGOI(LambdaExpression IIEIBJJHBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x369D110", Offset = "0x369BF10", VA = "0x18369D110")]
	public static MethodInfo PBHKIJBOAFA<T>(Expression<Func<T>> IIEIBJJHBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x369D110", Offset = "0x369BF10", VA = "0x18369D110")]
	public static MethodInfo PBHKIJBOAFA<T, TR>(Expression<Func<T, TR>> IIEIBJJHBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x369D110", Offset = "0x369BF10", VA = "0x18369D110")]
	public static MethodInfo PBHKIJBOAFA<T>(Expression<Action<T>> IIEIBJJHBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x369D110", Offset = "0x369BF10", VA = "0x18369D110")]
	public static MethodInfo PBHKIJBOAFA<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> IIEIBJJHBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x369D060", Offset = "0x369BE60", VA = "0x18369D060")]
	private static MemberInfo HKHFCFFPJAP<T>(Expression<T> JFBGEPNCFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x369D000", Offset = "0x369BE00", VA = "0x18369D000")]
	public static PropertyInfo GGHCLBCGLMI<T, TR>(Expression<Func<T, TR>> IIEIBJJHBCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct PJJOBJKEALJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int MNBBHFLLBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool NOBCFKAKHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator GMOLGNOIGAN;

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1B836E0", Offset = "0x1B824E0", VA = "0x181B836E0")]
	public PJJOBJKEALJ(ILGenerator GMOLGNOIGAN, int MNBBHFLLBID, bool NOBCFKAKHAP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1B83720", Offset = "0x1B82520", VA = "0x181B83720")]
	public PJJOBJKEALJ(ILGenerator GMOLGNOIGAN, int MNBBHFLLBID, Type IGEIBCJNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1B836C0", Offset = "0x1B824C0", VA = "0x181B836C0")]
	public void GCKEIIFFAFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class FAKCNOKBJJA
{
	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1A4A230", Offset = "0x1A49030", VA = "0x181A4A230")]
	public static void FJKBMHKDGEF(this ILGenerator GMOLGNOIGAN, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1A4A1F0", Offset = "0x1A48FF0", VA = "0x181A4A1F0")]
	public static void FJKBMHKDGEF(this ILGenerator GMOLGNOIGAN, LocalBuilder BAAMAKMIJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1A4A850", Offset = "0x1A49650", VA = "0x181A4A850")]
	public static void KOODKKFAIBB(this ILGenerator GMOLGNOIGAN, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1A4AA80", Offset = "0x1A49880", VA = "0x181A4AA80")]
	public static void KOODKKFAIBB(this ILGenerator GMOLGNOIGAN, LocalBuilder BAAMAKMIJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1A4A650", Offset = "0x1A49450", VA = "0x181A4A650")]
	public static void JFKOJKPIGGG(this ILGenerator GMOLGNOIGAN, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1A4A740", Offset = "0x1A49540", VA = "0x181A4A740")]
	public static void JFKOJKPIGGG(this ILGenerator GMOLGNOIGAN, LocalBuilder BAAMAKMIJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1A4AAD0", Offset = "0x1A498D0", VA = "0x181A4AAD0")]
	public static void NENKKDLBGMM(this ILGenerator GMOLGNOIGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1A4AAC0", Offset = "0x1A498C0", VA = "0x181A4AAC0")]
	public static void MGHBOEHIAAI(this ILGenerator GMOLGNOIGAN, bool DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1A49A60", Offset = "0x1A48860", VA = "0x181A49A60")]
	public static void ANOOKKEHDOC(this ILGenerator GMOLGNOIGAN, int DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1A4A560", Offset = "0x1A49360", VA = "0x181A4A560")]
	public static void HFJDFNNPIFG(this ILGenerator GMOLGNOIGAN, Type IGEIBCJNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1A4AAE0", Offset = "0x1A498E0", VA = "0x181A4AAE0")]
	public static void PNBINKDIPJM(this ILGenerator GMOLGNOIGAN, Type IGEIBCJNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1A49F40", Offset = "0x1A48D40", VA = "0x181A49F40")]
	public static void BBIMMGPPGNA(this ILGenerator GMOLGNOIGAN, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1A4A170", Offset = "0x1A48F70", VA = "0x181A4A170")]
	public static void DABCEAPDFNB(this ILGenerator GMOLGNOIGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x1A49970", Offset = "0x1A48770", VA = "0x181A49970")]
	public static void AGELOAGBAKI(this ILGenerator GMOLGNOIGAN, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x1A4A460", Offset = "0x1A49260", VA = "0x181A4A460")]
	public static void GEBKHOPCNNP(this ILGenerator GMOLGNOIGAN, MethodInfo FHLIGJBMGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x1A49EB0", Offset = "0x1A48CB0", VA = "0x181A49EB0")]
	public static void BAEMJBDEPON(this ILGenerator GMOLGNOIGAN, FieldInfo FFKIAKKCLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x1A4AB90", Offset = "0x1A49990", VA = "0x181A4AB90")]
	public static void POJFCOLAENO(this ILGenerator GMOLGNOIGAN, ulong DFEOJBAFBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class CBFDBJMKKPC
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class EMPEGLCIDFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public EMPEGLCIDFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1B73E10", Offset = "0x1B72C10", VA = "0x181B73E10")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo JJCEAAGKDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo MEOHJPOADNM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string ADMEEJPABPA
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6B2150", Offset = "0x6B0F50", VA = "0x1806B2150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string DNHPIJKCCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7337A0", Offset = "0x7325A0", VA = "0x1807337A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CFMHDJECHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1A38100", Offset = "0x1A36F00", VA = "0x181A38100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MMCOECBBLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x733990", Offset = "0x732790", VA = "0x180733990")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7335F0", Offset = "0x7323F0", VA = "0x1807335F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool CIOJGGHGMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x73B080", Offset = "0x739E80", VA = "0x18073B080")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x73B420", Offset = "0x73A220", VA = "0x18073B420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type CMCPPDDMLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x836620", Offset = "0x835420", VA = "0x180836620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo MEAPFJDLCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x738030", Offset = "0x736E30", VA = "0x180738030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo CHMIOKINBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6C07D0", Offset = "0x6BF5D0", VA = "0x1806C07D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x737900", Offset = "0x736700", VA = "0x180737900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo DJFCJHIPIPB
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x73C880", Offset = "0x73B680", VA = "0x18073C880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x73C1F0", Offset = "0x73AFF0", VA = "0x18073C1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x1A386C0", Offset = "0x1A374C0", VA = "0x181A386C0")]
	protected CBFDBJMKKPC(Type IGEIBCJNCHF, string IADPDEAGFAB, string DEEBFFICGIP, bool KHJHMGKFDOE, bool KNEGKJAPIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1A38400", Offset = "0x1A37200", VA = "0x181A38400")]
	public CBFDBJMKKPC(FieldInfo FEPBBMGBAMP, string IADPDEAGFAB, bool HJBKCEHLOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1A38510", Offset = "0x1A37310", VA = "0x181A38510")]
	public CBFDBJMKKPC(PropertyInfo FEPBBMGBAMP, string IADPDEAGFAB, bool HJBKCEHLOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x1A38290", Offset = "0x1A37090", VA = "0x181A38290")]
	private static MethodInfo MIKBOOFGKHL(MemberInfo FEPBBMGBAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x379FB50", Offset = "0x379E950", VA = "0x18379FB50")]
	public T KLEPCOMHCKJ<T>(bool ONMFLAHIEKK) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x1A38110", Offset = "0x1A36F10", VA = "0x181A38110", Slot = "4")]
	public virtual void HKPKHPNPJBA(ILGenerator GMOLGNOIGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x1A381D0", Offset = "0x1A36FD0", VA = "0x181A381D0", Slot = "5")]
	public virtual void LBKMFOAJLFG(ILGenerator GMOLGNOIGAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class GEALPFJJLIO : CBFDBJMKKPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string CBMFMCFOKHC;

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x1A4CEB0", Offset = "0x1A4BCB0", VA = "0x181A4CEB0")]
	public GEALPFJJLIO(string IADPDEAGFAB, string CBMFMCFOKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x1A4CDB0", Offset = "0x1A4BBB0", VA = "0x181A4CDB0", Slot = "4")]
	public override void HKPKHPNPJBA(ILGenerator GMOLGNOIGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x1A4CE70", Offset = "0x1A4BC70", VA = "0x181A4CE70", Slot = "5")]
	public override void LBKMFOAJLFG(ILGenerator GMOLGNOIGAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class JLENBDJFNAL : CBFDBJMKKPC
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo BBEEPEAJIMJ;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo PFIFEKALGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal PJJOBJKEALJ KIBGKEPNOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal PJJOBJKEALJ KJEDNAOJNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal PJJOBJKEALJ NEGCAAGBPBK;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x1A5BA80", Offset = "0x1A5A880", VA = "0x181A5BA80")]
	public JLENBDJFNAL(string IADPDEAGFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x1A5B300", Offset = "0x1A5A100", VA = "0x181A5B300", Slot = "4")]
	public override void HKPKHPNPJBA(ILGenerator GMOLGNOIGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x1A5B3D0", Offset = "0x1A5A1D0", VA = "0x181A5B3D0", Slot = "5")]
	public override void LBKMFOAJLFG(ILGenerator GMOLGNOIGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x1A5B410", Offset = "0x1A5A210", VA = "0x181A5B410")]
	public void MHGIPLELPEO(ILGenerator GMOLGNOIGAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class LIAFLHMCAMO
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type CMCPPDDMLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6B2150", Offset = "0x6B0F50", VA = "0x1806B2150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GHNJFHLPGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x736830", Offset = "0x735630", VA = "0x180736830")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x736B30", Offset = "0x735930", VA = "0x180736B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool AOHPFJIFOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7366F0", Offset = "0x7354F0", VA = "0x1807366F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x736A10", Offset = "0x735810", VA = "0x180736A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo OIFKIKPAPKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x739270", Offset = "0x738070", VA = "0x180739270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public CBFDBJMKKPC[] FBODCMNBCEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x836620", Offset = "0x835420", VA = "0x180836620")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public CBFDBJMKKPC[] PLHBEBJKIPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x738030", Offset = "0x736E30", VA = "0x180738030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x1A60660", Offset = "0x1A5F460", VA = "0x181A60660")]
	public LIAFLHMCAMO(Type IGEIBCJNCHF, Func<string, string> NPPCGIKENOB, bool HJBKCEHLOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x1A60570", Offset = "0x1A5F370", VA = "0x181A60570")]
	private static bool AEDAKOGALHI(IEnumerator<ConstructorInfo> AEGMLMBMHDO, ref ConstructorInfo LPAMELJINII)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct JCGNAICPMFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong ENHNHFJMKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int PBDFKDHMIEL;

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x1A596A0", Offset = "0x1A584A0", VA = "0x181A596A0")]
	public JCGNAICPMFE(ulong OEABHAKKCIB, int PEBIEFMKNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x1A59690", Offset = "0x1A58490", VA = "0x181A59690")]
	public void PHKPNLNPCJD(ref JCGNAICPMFE KICLNADFIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1A595E0", Offset = "0x1A583E0", VA = "0x181A595E0")]
	public static JCGNAICPMFE KNJFJANOBDD(ref JCGNAICPMFE NCNGLFNLPAG, ref JCGNAICPMFE OPGAGDBKIDA)
	{
		return default(JCGNAICPMFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x1A594C0", Offset = "0x1A582C0", VA = "0x181A594C0")]
	public void HAECAAHDANK(ref JCGNAICPMFE KICLNADFIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x1A595F0", Offset = "0x1A583F0", VA = "0x181A595F0")]
	public static JCGNAICPMFE ONJOCOBFODK(ref JCGNAICPMFE NCNGLFNLPAG, ref JCGNAICPMFE OPGAGDBKIDA)
	{
		return default(JCGNAICPMFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x1A59550", Offset = "0x1A58350", VA = "0x181A59550")]
	public void IMEJDEMJNFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x1A59590", Offset = "0x1A58390", VA = "0x181A59590")]
	public static JCGNAICPMFE IMEJDEMJNFI(ref JCGNAICPMFE NCNGLFNLPAG)
	{
		return default(JCGNAICPMFE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct IIPHMCMNDJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] FAHBHODOFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int PNKNABOKANH;

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0xDEFB60", Offset = "0xDEE960", VA = "0x180DEFB60")]
	public IIPHMCMNDJH(byte[] FAHBHODOFIG, int IJBELJOFGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x1A57C30", Offset = "0x1A56A30", VA = "0x181A57C30")]
	public void MLFCKGFJJEL(byte HCJLPANMOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x1A578C0", Offset = "0x1A566C0", VA = "0x181A578C0")]
	public void CHJJFAFCBLE(byte[] HCJLPANMOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x1A57AE0", Offset = "0x1A568E0", VA = "0x181A57AE0")]
	public void HJKJKFMLGJB(byte[] HCJLPANMOCK, int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1A57B80", Offset = "0x1A56980", VA = "0x181A57B80")]
	public void HJKJKFMLGJB(byte[] HCJLPANMOCK, int FHGIIAKFJFF, int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x1A57A60", Offset = "0x1A56860", VA = "0x181A57A60")]
	public void HIJLCCGKAJB(byte NKNPGFCGIPO, int MIOCJKOOLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x1A57960", Offset = "0x1A56760", VA = "0x181A57960")]
	public void DKOHLMMDNFI(string HCJLPANMOCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class CAHJNLPJDFE
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private enum OLFGNONFEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum MMFMKNKLBAE
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum JIOFFAOJGDD
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	[ThreadStatic]
	private static byte[] FOOENGIJFLN;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] DNLHENAGNBC;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] JEPOIPEDKDJ;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] OJCJCPNPPKD;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly JIOFFAOJGDD KAOBEOKFALE;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char ALOLGIDLAMP;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int BDBPCIMNKAK;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int AJGKHFLBGFA;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] EDHCLLKGIHP;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x1A37930", Offset = "0x1A36730", VA = "0x181A37930")]
	private static byte[] PKBGLIKIKNB(int BDHBBDMMOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x1A36940", Offset = "0x1A35740", VA = "0x181A36940")]
	private static byte[] HOLFBHEJFAH(int BDHBBDMMOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x1A37420", Offset = "0x1A36220", VA = "0x181A37420")]
	public static int KPJAFBEEOCO(ref byte[] FAHBHODOFIG, int PNKNABOKANH, float DFEOJBAFBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x1A37540", Offset = "0x1A36340", VA = "0x181A37540")]
	public static int KPJAFBEEOCO(ref byte[] FAHBHODOFIG, int PNKNABOKANH, double DFEOJBAFBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x1A36080", Offset = "0x1A34E80", VA = "0x181A36080")]
	private static bool CIEEAFONCPM(byte[] FAHBHODOFIG, int MFAHIHFAKKH, ulong DGOMCCHJOLL, ulong OFMOPGMGDKL, ulong CMJGLNDNCNL, ulong HMHDLKCBANC, ulong LBDLDNKLKFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x1A37660", Offset = "0x1A36460", VA = "0x181A37660")]
	private static void ONJMJDLJDJA(uint KOCCBGHFMNN, int MCEJIFGFOFH, out uint MGNPKBLNOBI, out int GEBKHFGPNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x1A36420", Offset = "0x1A35220", VA = "0x181A36420")]
	private static bool GBOAKKJGBMB(JCGNAICPMFE MKBCDJFFMOJ, JCGNAICPMFE AOJLCLDDLKO, JCGNAICPMFE FLCJEMLMJJC, byte[] FAHBHODOFIG, out int MFAHIHFAKKH, out int LEKMIGPFNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x1A37080", Offset = "0x1A35E80", VA = "0x181A37080")]
	private static bool JOLIEHHDOGB(double BGLBBPFJJCJ, OLFGNONFEJJ HOEJODOFJHI, byte[] FAHBHODOFIG, out int MFAHIHFAKKH, out int BPMINMKOLFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1A36310", Offset = "0x1A35110", VA = "0x181A36310")]
	private static bool DNPOOCGBGGA(double BGLBBPFJJCJ, OLFGNONFEJJ HOEJODOFJHI, byte[] FAHBHODOFIG, out int MFAHIHFAKKH, out int FHIHCIHKKAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x1A36180", Offset = "0x1A34F80", VA = "0x181A36180")]
	private static bool DMJHOOOCMGI(double DFEOJBAFBHE, ref IIPHMCMNDJH BCIDINGHJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x1A36A20", Offset = "0x1A35820", VA = "0x181A36A20")]
	private static bool IPCDAKIKILM(double DFEOJBAFBHE, ref IIPHMCMNDJH BCIDINGHJNK, MMFMKNKLBAE HOEJODOFJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1A37A10", Offset = "0x1A36810", VA = "0x181A37A10")]
	private static void POLFOHNOKLK(byte[] MEDICKCMHGL, int MFAHIHFAKKH, int FHIHCIHKKAG, int JDINDDMJOML, ref IIPHMCMNDJH BCIDINGHJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1A35D80", Offset = "0x1A34B80", VA = "0x181A35D80")]
	private static void BPDPPDBEJEL(byte[] MEDICKCMHGL, int MFAHIHFAKKH, int PEBIEFMKNOB, ref IIPHMCMNDJH BCIDINGHJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x1A37780", Offset = "0x1A36580", VA = "0x181A37780")]
	private static bool PDDPLJKABFM(double BGLBBPFJJCJ, MMFMKNKLBAE HOEJODOFJHI, int JDEAOOPDDDN, byte[] JBEKHEJIENA, out bool CMIILGJLNCN, out int MFAHIHFAKKH, out int LMABBBKCION)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal struct EFKFPPNADMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double LNMAPJNBGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong AGCGBJBHNHE;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct BFMENMBNFPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float ENHNHFJMKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint KAGGLOMJPGB;
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct PFCOGLMCLNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong EOBCEFOOLAN;

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x1B82F50", Offset = "0x1B81D50", VA = "0x181B82F50")]
	public PFCOGLMCLNJ(double LNMAPJNBGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x1B82F60", Offset = "0x1B81D60", VA = "0x181B82F60")]
	public PFCOGLMCLNJ(JCGNAICPMFE LNMAPJNBGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x1B829D0", Offset = "0x1B817D0", VA = "0x181B829D0")]
	public JCGNAICPMFE CBOFBLKKKKN()
	{
		return default(JCGNAICPMFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x1B82AC0", Offset = "0x1B818C0", VA = "0x181B82AC0")]
	public JCGNAICPMFE EPNILAHAOHB()
	{
		return default(JCGNAICPMFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x775530", Offset = "0x774330", VA = "0x180775530")]
	public ulong KOBJMIOLGNM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x1B82E40", Offset = "0x1B81C40", VA = "0x181B82E40")]
	public double LBJIPDLDAEJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x1B82C20", Offset = "0x1B81A20", VA = "0x181B82C20")]
	public double IFENOBNFNPJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x1B82ED0", Offset = "0x1B81CD0", VA = "0x181B82ED0")]
	public int LNFMGNCFDKB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1B82A80", Offset = "0x1B81880", VA = "0x181B82A80")]
	public ulong DOFFJINBGAO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x1B82A50", Offset = "0x1B81850", VA = "0x181B82A50")]
	public bool DEPHDENCGHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x1B82F00", Offset = "0x1B81D00", VA = "0x181B82F00")]
	public bool NDFKIECFNJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x1B82BF0", Offset = "0x1B819F0", VA = "0x181B82BF0")]
	public bool FHCMJOKPCJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1B82F20", Offset = "0x1B81D20", VA = "0x181B82F20")]
	public bool PPJLFFMPIPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x1B829B0", Offset = "0x1B817B0", VA = "0x181B829B0")]
	public int BNMMHBHKLMG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x1B82CB0", Offset = "0x1B81AB0", VA = "0x181B82CB0")]
	public void JOADOBPMNJI(out JCGNAICPMFE LFPFOPOGLOK, out JCGNAICPMFE LILCFDPBBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x1B82960", Offset = "0x1B81760", VA = "0x181B82960")]
	public bool BEADLCHEJPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x1B82A70", Offset = "0x1B81870", VA = "0x181B82A70")]
	public double DFEOJBAFBHE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x1B82E20", Offset = "0x1B81C20", VA = "0x181B82E20")]
	public static int KGGFFGKDNBI(int AGFBKKLEANA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1B82AB0", Offset = "0x1B818B0", VA = "0x181B82AB0")]
	public static double EIDNGFEEDLM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1B82B50", Offset = "0x1B81950", VA = "0x181B82B50")]
	public static ulong FBNCJBDFPPL(JCGNAICPMFE OMKGAALHLFD)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct BDOJCHBHPKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint EIFGJPNOMJN;

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x8F65C0", Offset = "0x8F53C0", VA = "0x1808F65C0")]
	public BDOJCHBHPKN(float ENHNHFJMKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1A337E0", Offset = "0x1A325E0", VA = "0x181A337E0")]
	public JCGNAICPMFE CBOFBLKKKKN()
	{
		return default(JCGNAICPMFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x91D790", Offset = "0x91C590", VA = "0x18091D790")]
	public uint LDAPFODAHIB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1A339E0", Offset = "0x1A327E0", VA = "0x181A339E0")]
	public int LNFMGNCFDKB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x1A33860", Offset = "0x1A32660", VA = "0x181A33860")]
	public uint DOFFJINBGAO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1A33850", Offset = "0x1A32650", VA = "0x181A33850")]
	public bool DEPHDENCGHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x1A33880", Offset = "0x1A32680", VA = "0x181A33880")]
	public void JOADOBPMNJI(out JCGNAICPMFE LFPFOPOGLOK, out JCGNAICPMFE LILCFDPBBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x1A337A0", Offset = "0x1A325A0", VA = "0x181A337A0")]
	public bool BEADLCHEJPA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct PLNLCPEALKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong OEABHAKKCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short BJHPKBPPJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short BPMINMKOLFA;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x1B83970", Offset = "0x1B82770", VA = "0x181B83970")]
	public PLNLCPEALKJ(ulong OEABHAKKCIB, short BJHPKBPPJNM, short BPMINMKOLFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal static class CKMOKIJCKKB
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly PLNLCPEALKJ[] EKDAEIKLDFH;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x1A39A50", Offset = "0x1A38850", VA = "0x181A39A50")]
	public static void AGFEJFAEEOO(int AKDLHNJKEOI, int OOIPJFIKNEG, out JCGNAICPMFE MGNPKBLNOBI, out int BPMINMKOLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x1A39B90", Offset = "0x1A38990", VA = "0x181A39B90")]
	public static void MBFKPFOIPBM(int DPGJKFFAADN, out JCGNAICPMFE MGNPKBLNOBI, out int NKCDPGLIEGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[DefaultMember("Item")]
internal struct CADCBDKIGIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] CCFMJPPGPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int FHGIIAKFJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int NNDKDNDGKOH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x1A35CE0", Offset = "0x1A34AE0", VA = "0x181A35CE0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0xF5A080", Offset = "0xF58E80", VA = "0x180F5A080")]
	public CADCBDKIGIP(byte[] CCFMJPPGPDK, int FHGIIAKFJFF, int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x91D7A0", Offset = "0x91C5A0", VA = "0x18091D7A0")]
	public int MFAHIHFAKKH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x1A35D20", Offset = "0x1A34B20", VA = "0x181A35D20")]
	public CADCBDKIGIP GLFJGHMCJGK(int LLJOHLBBLLB, int FOPGHCLMOAD)
	{
		return default(CADCBDKIGIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class MCIBGHFPJCD
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] GHCJPLLGJPN;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] GMKCMFEHCED;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int APIJILEJFGO;

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x1A636E0", Offset = "0x1A624E0", VA = "0x181A636E0")]
	private static byte[] MAEPPHIELIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x1A639F0", Offset = "0x1A627F0", VA = "0x181A639F0")]
	private static CADCBDKIGIP OPGGGLIFAPJ(CADCBDKIGIP FAHBHODOFIG)
	{
		return default(CADCBDKIGIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x1A62EA0", Offset = "0x1A61CA0", VA = "0x181A62EA0")]
	private static CADCBDKIGIP BBPGGCIGKPK(CADCBDKIGIP FAHBHODOFIG)
	{
		return default(CADCBDKIGIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1A63070", Offset = "0x1A61E70", VA = "0x181A63070")]
	private static void CCPKKDDAHEG(CADCBDKIGIP FAHBHODOFIG, int PEBIEFMKNOB, byte[] MNDCHFJCCCI, out int DHBIDAHHAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x1A63440", Offset = "0x1A62240", VA = "0x181A63440")]
	private static void LDPLKODGEFP(CADCBDKIGIP FAHBHODOFIG, int PEBIEFMKNOB, byte[] MHNFDLMDGJB, int MPPPBDBHLAH, out CADCBDKIGIP IIFMMGGIPKK, out int HNAAIJKMKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x1A637D0", Offset = "0x1A625D0", VA = "0x181A637D0")]
	private static ulong OCEPFKKPGIA(CADCBDKIGIP FAHBHODOFIG, out int HEFAEGMDCHC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x1A63310", Offset = "0x1A62110", VA = "0x181A63310")]
	private static void JENCBLJLAFA(CADCBDKIGIP FAHBHODOFIG, out JCGNAICPMFE MMPEAFKIOCN, out int LNLFHCGCMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x1A63AA0", Offset = "0x1A628A0", VA = "0x181A63AA0")]
	private static bool PKDPMCGKNEL(CADCBDKIGIP IIFMMGGIPKK, int PEBIEFMKNOB, out double MMPEAFKIOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x1A63860", Offset = "0x1A62660", VA = "0x181A63860")]
	private static JCGNAICPMFE ODMNAKILJCF(int PEBIEFMKNOB)
	{
		return default(JCGNAICPMFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x1A62980", Offset = "0x1A61780", VA = "0x181A62980")]
	private static bool ANOOADAICOE(CADCBDKIGIP FAHBHODOFIG, int PEBIEFMKNOB, out double MMPEAFKIOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x1A62840", Offset = "0x1A61640", VA = "0x181A62840")]
	private static bool ABEKPOBHJFJ(CADCBDKIGIP IIFMMGGIPKK, int PEBIEFMKNOB, out double FNPDEDNGDOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x1A62F50", Offset = "0x1A61D50", VA = "0x181A62F50")]
	public static double? BOAGCMJCDKN(CADCBDKIGIP FAHBHODOFIG, int PEBIEFMKNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1A63130", Offset = "0x1A61F30", VA = "0x181A63130")]
	public static float? HNBMEOIBFAK(CADCBDKIGIP FAHBHODOFIG, int PEBIEFMKNOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct CAPLPJGNJOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] FAHBHODOFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int PNKNABOKANH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1A37FE0", Offset = "0x1A36DE0", VA = "0x181A37FE0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0xDEFB60", Offset = "0xDEE960", VA = "0x180DEFB60")]
	public CAPLPJGNJOG(byte[] FAHBHODOFIG, int PNKNABOKANH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x1A37F80", Offset = "0x1A36D80", VA = "0x181A37F80")]
	public static CAPLPJGNJOG GBONAKDPJMP(CAPLPJGNJOG BLHHJNENDMO)
	{
		return default(CAPLPJGNJOG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x1A38020", Offset = "0x1A36E20", VA = "0x181A38020")]
	public static CAPLPJGNJOG LGHBHOPGAGF(CAPLPJGNJOG BLHHJNENDMO, int MFAHIHFAKKH)
	{
		return default(CAPLPJGNJOG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x1A380E0", Offset = "0x1A36EE0", VA = "0x181A380E0")]
	public static int OOOBHHMAEMO(CAPLPJGNJOG JCHPGJLCOCJ, CAPLPJGNJOG GHMOJHOMMOK)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1A37F10", Offset = "0x1A36D10", VA = "0x181A37F10")]
	public static bool FHCNBCDBOFI(CAPLPJGNJOG JCHPGJLCOCJ, CAPLPJGNJOG GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x1A380C0", Offset = "0x1A36EC0", VA = "0x181A380C0")]
	public static bool LIEIJOJMABA(CAPLPJGNJOG JCHPGJLCOCJ, CAPLPJGNJOG GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x1A37F30", Offset = "0x1A36D30", VA = "0x181A37F30")]
	public static bool FHCNBCDBOFI(CAPLPJGNJOG JCHPGJLCOCJ, char GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x1A38070", Offset = "0x1A36E70", VA = "0x181A38070")]
	public static bool LIEIJOJMABA(CAPLPJGNJOG JCHPGJLCOCJ, char GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x1A38070", Offset = "0x1A36E70", VA = "0x181A38070")]
	public static bool LIEIJOJMABA(CAPLPJGNJOG JCHPGJLCOCJ, byte GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x1A37EC0", Offset = "0x1A36CC0", VA = "0x181A37EC0")]
	public static bool DMAOELLFPEE(CAPLPJGNJOG JCHPGJLCOCJ, char GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x1A37E70", Offset = "0x1A36C70", VA = "0x181A37E70")]
	public static bool BLBLPHALPKB(CAPLPJGNJOG JCHPGJLCOCJ, char GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x1A37E20", Offset = "0x1A36C20", VA = "0x181A37E20")]
	public static bool BKICIBGHAMO(CAPLPJGNJOG JCHPGJLCOCJ, char GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x1A37F90", Offset = "0x1A36D90", VA = "0x181A37F90")]
	public static bool HPOJALLLMGD(CAPLPJGNJOG JCHPGJLCOCJ, char GHMOJHOMMOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class IFCLFJAEJFO
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] GKKKNCBOFGA;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] PGEFNACIKFL;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] JEPOIPEDKDJ;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] OJCJCPNPPKD;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] GGKMCIDGJGP;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int ILOPHOFFGMJ;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] NAMPNJJOILA;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int LNBGKCAKHIF;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1A562D0", Offset = "0x1A550D0", VA = "0x181A562D0")]
	private static byte[] KDIMAKIMIBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x1A55C60", Offset = "0x1A54A60", VA = "0x181A55C60")]
	private static byte[] BPLHEBBMGIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1A56110", Offset = "0x1A54F10", VA = "0x181A56110")]
	public static double HEJJCJMCNIB(byte[] FAHBHODOFIG, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x1A56030", Offset = "0x1A54E30", VA = "0x181A56030")]
	public static float DBIIMGMIGNM(byte[] FAHBHODOFIG, int PNKNABOKANH, out int BJJKBBIHGGJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x1A55E60", Offset = "0x1A54C60", VA = "0x181A55E60")]
	private static bool CKDMBKECMDL(int JMDPDGBMGAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x1A561C0", Offset = "0x1A54FC0", VA = "0x181A561C0")]
	private static bool IGHOAMIKNAD(ref CAPLPJGNJOG JFKHJAJODDL, CAPLPJGNJOG APIEJLBIMAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x1A55D50", Offset = "0x1A54B50", VA = "0x181A55D50")]
	private static bool CICGDIAGDNE(ref CAPLPJGNJOG JFKHJAJODDL, CAPLPJGNJOG APIEJLBIMAO, byte[] GKDHDKEHOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x1A55FE0", Offset = "0x1A54DE0", VA = "0x181A55FE0")]
	private static bool DAJLIDBEAGO(ref CAPLPJGNJOG PBLHANHGPII, byte[] HCJLPANMOCK, int PNKNABOKANH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x1A560F0", Offset = "0x1A54EF0", VA = "0x181A560F0")]
	private static double GJCBEBIMAFH(bool CMIILGJLNCN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x1A563C0", Offset = "0x1A551C0", VA = "0x181A563C0")]
	private static double OIBKFBHJHND(CAPLPJGNJOG GIEOCCOFGEG, int MFAHIHFAKKH, bool FGKKIDLAAKO, out int EPKJKKFBOBG)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class CHAHKCEPFPL<T> : global::KBIOLGDHIDG<T[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly global::AJCIIEGBJNM<T> FGONAFOACAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly FFOJCCDENBP CLPHJBHPIHI;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x41E80D0", Offset = "0x41E6ED0", VA = "0x1841E80D0")]
	public CHAHKCEPFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2E6EE50", Offset = "0x2E6DC50", VA = "0x182E6EE50")]
	public CHAHKCEPFPL(FFOJCCDENBP CLPHJBHPIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x47D61D0", Offset = "0x47D4FD0", VA = "0x1847D61D0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x47D3A70", Offset = "0x47D2870", VA = "0x1847D3A70", Slot = "5")]
	public T[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class KEANDGNMNOA<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly global::AJCIIEGBJNM<T> FGONAFOACAH;
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class PBNPNNODMPI<T> : global::KBIOLGDHIDG<List<T>>, CDJJKNODMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly FFOJCCDENBP CLPHJBHPIHI;

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x41E80D0", Offset = "0x41E6ED0", VA = "0x1841E80D0")]
	public PBNPNNODMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2E6EE50", Offset = "0x2E6DC50", VA = "0x182E6EE50")]
	public PBNPNNODMPI(FFOJCCDENBP CLPHJBHPIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x41E7610", Offset = "0x41E6410", VA = "0x1841E7610", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, List<T> DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x41E6BE0", Offset = "0x41E59E0", VA = "0x1841E6BE0", Slot = "5")]
	public List<T> CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public abstract class JGABEFMIFJJ<TElement, TIntermediate, TEnumerator, TCollection> : global::KBIOLGDHIDG<TCollection>, CDJJKNODMKB where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x3DD3530", Offset = "0x3DD2330", VA = "0x183DD3530", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, TCollection DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3DD24E0", Offset = "0x3DD12E0", VA = "0x183DD24E0", Slot = "5")]
	public TCollection CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator DFFMHNIAILL(TCollection JFBGEPNCFEC);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate HJNGNBALKKN();

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void HMNAIPBHJIK(ref TIntermediate GLNLHJNNDLD, int NPDGHPHAKDK, TElement DFEOJBAFBHE);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection NNHOADFEBDJ(ref TIntermediate BGKOPHJCJAG);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
	protected JGABEFMIFJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class OMDBGHJBFMI<TElement, TIntermediate, TCollection> : global::JGABEFMIFJJ<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x36792E0", Offset = "0x36780E0", VA = "0x1836792E0", Slot = "6")]
	protected override IEnumerator<TElement> DFFMHNIAILL(TCollection JFBGEPNCFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3853740", Offset = "0x3852540", VA = "0x183853740")]
	protected OMDBGHJBFMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class GFOJMJFEHMJ<TElement, TCollection> : global::OMDBGHJBFMI<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x980940", Offset = "0x97F740", VA = "0x180980940", Slot = "9")]
	protected sealed override TCollection NNHOADFEBDJ(ref TCollection BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class EBECEFOGDNN<TElement, TCollection> : global::GFOJMJFEHMJ<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x3D76670", Offset = "0x3D75470", VA = "0x183D76670", Slot = "7")]
	protected override TCollection HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3D76690", Offset = "0x3D75490", VA = "0x183D76690", Slot = "8")]
	protected override void HMNAIPBHJIK(ref TCollection GLNLHJNNDLD, int NPDGHPHAKDK, TElement DFEOJBAFBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class IMPJCBEPEFE<T> : global::JGABEFMIFJJ<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3675AC0", Offset = "0x36748C0", VA = "0x183675AC0", Slot = "8")]
	protected override void HMNAIPBHJIK(ref LinkedList<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x980940", Offset = "0x97F740", VA = "0x180980940", Slot = "9")]
	protected override LinkedList<T> NNHOADFEBDJ(ref LinkedList<T> BGKOPHJCJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3675A60", Offset = "0x3674860", VA = "0x183675A60", Slot = "7")]
	protected override LinkedList<T> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3675A00", Offset = "0x3674800", VA = "0x183675A00", Slot = "6")]
	protected override LinkedList<T>.Enumerator DFFMHNIAILL(LinkedList<T> JFBGEPNCFEC)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class GJIOGPMIPAI<T> : global::JGABEFMIFJJ<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x3675AC0", Offset = "0x36748C0", VA = "0x183675AC0", Slot = "8")]
	protected override void HMNAIPBHJIK(ref Queue<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3675A60", Offset = "0x3674860", VA = "0x183675A60", Slot = "7")]
	protected override Queue<T> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x3C25BF0", Offset = "0x3C249F0", VA = "0x183C25BF0", Slot = "6")]
	protected override Queue<T>.Enumerator DFFMHNIAILL(Queue<T> JFBGEPNCFEC)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x980940", Offset = "0x97F740", VA = "0x180980940", Slot = "9")]
	protected override Queue<T> NNHOADFEBDJ(ref Queue<T> BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class CDNFJPCLBEP<T> : global::JGABEFMIFJJ<T, global::GJFGIFNNEBL<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x3A54690", Offset = "0x3A53490", VA = "0x183A54690", Slot = "8")]
	protected override void HMNAIPBHJIK(ref global::GJFGIFNNEBL<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x3A54650", Offset = "0x3A53450", VA = "0x183A54650", Slot = "7")]
	protected override global::GJFGIFNNEBL<T> HJNGNBALKKN()
	{
		return default(global::GJFGIFNNEBL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3C25BF0", Offset = "0x3C249F0", VA = "0x183C25BF0", Slot = "6")]
	protected override Stack<T>.Enumerator DFFMHNIAILL(Stack<T> JFBGEPNCFEC)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x3C25C40", Offset = "0x3C24A40", VA = "0x183C25C40", Slot = "9")]
	protected override Stack<T> NNHOADFEBDJ(ref global::GJFGIFNNEBL<T> BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class NFDKCPOCEML<T> : global::JGABEFMIFJJ<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x3675AC0", Offset = "0x36748C0", VA = "0x183675AC0", Slot = "8")]
	protected override void HMNAIPBHJIK(ref HashSet<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x980940", Offset = "0x97F740", VA = "0x180980940", Slot = "9")]
	protected override HashSet<T> NNHOADFEBDJ(ref HashSet<T> BGKOPHJCJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3675A60", Offset = "0x3674860", VA = "0x183675A60", Slot = "7")]
	protected override HashSet<T> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3C25BF0", Offset = "0x3C249F0", VA = "0x183C25BF0", Slot = "6")]
	protected override HashSet<T>.Enumerator DFFMHNIAILL(HashSet<T> JFBGEPNCFEC)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class IAFGCDGOCDO<T> : global::OMDBGHJBFMI<T, global::GJFGIFNNEBL<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x3A54690", Offset = "0x3A53490", VA = "0x183A54690", Slot = "8")]
	protected override void HMNAIPBHJIK(ref global::GJFGIFNNEBL<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x5050D40", Offset = "0x504FB40", VA = "0x185050D40", Slot = "9")]
	protected override ReadOnlyCollection<T> NNHOADFEBDJ(ref global::GJFGIFNNEBL<T> BGKOPHJCJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x5050D00", Offset = "0x504FB00", VA = "0x185050D00", Slot = "7")]
	protected override global::GJFGIFNNEBL<T> HJNGNBALKKN()
	{
		return default(global::GJFGIFNNEBL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class MPAAADODCOE<T> : global::OMDBGHJBFMI<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x3675AC0", Offset = "0x36748C0", VA = "0x183675AC0", Slot = "8")]
	protected override void HMNAIPBHJIK(ref List<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3675A60", Offset = "0x3674860", VA = "0x183675A60", Slot = "7")]
	protected override List<T> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x980940", Offset = "0x97F740", VA = "0x180980940", Slot = "9")]
	protected override IList<T> NNHOADFEBDJ(ref List<T> BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class CLBBNJFBMAH<T> : global::OMDBGHJBFMI<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3675AC0", Offset = "0x36748C0", VA = "0x183675AC0", Slot = "8")]
	protected override void HMNAIPBHJIK(ref List<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3675A60", Offset = "0x3674860", VA = "0x183675A60", Slot = "7")]
	protected override List<T> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x980940", Offset = "0x97F740", VA = "0x180980940", Slot = "9")]
	protected override ICollection<T> NNHOADFEBDJ(ref List<T> BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class POJAJBLGMLJ<T> : global::OMDBGHJBFMI<T, global::GJFGIFNNEBL<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x3A54690", Offset = "0x3A53490", VA = "0x183A54690", Slot = "8")]
	protected override void HMNAIPBHJIK(ref global::GJFGIFNNEBL<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x3A54650", Offset = "0x3A53450", VA = "0x183A54650", Slot = "7")]
	protected override global::GJFGIFNNEBL<T> HJNGNBALKKN()
	{
		return default(global::GJFGIFNNEBL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3A546C0", Offset = "0x3A534C0", VA = "0x183A546C0", Slot = "9")]
	protected override IEnumerable<T> NNHOADFEBDJ(ref global::GJFGIFNNEBL<T> BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class OJGJDGBMDOI<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class GFKGEAHJJLP<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class EDGPCALOHNP<T> : global::KBIOLGDHIDG<T>, CDJJKNODMKB where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x3D790C0", Offset = "0x3D77EC0", VA = "0x183D790C0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x3D78EB0", Offset = "0x3D77CB0", VA = "0x183D78EB0", Slot = "5")]
	public T CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
	public EDGPCALOHNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class INOAPNDKPGJ : global::KBIOLGDHIDG<IEnumerable>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::KBIOLGDHIDG<IEnumerable> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x1A57F20", Offset = "0x1A56D20", VA = "0x181A57F20", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, IEnumerable DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x1A57C90", Offset = "0x1A56A90", VA = "0x181A57C90", Slot = "5")]
	public IEnumerable CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public INOAPNDKPGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class OCPOGFLFAKM : global::KBIOLGDHIDG<ICollection>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public static readonly global::KBIOLGDHIDG<ICollection> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x1B817A0", Offset = "0x1B805A0", VA = "0x181B817A0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ICollection DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1B815F0", Offset = "0x1B803F0", VA = "0x181B815F0", Slot = "5")]
	public ICollection CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public OCPOGFLFAKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class LGFDLOFKBOB : global::KBIOLGDHIDG<IList>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::KBIOLGDHIDG<IList> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x1A601A0", Offset = "0x1A5EFA0", VA = "0x181A601A0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, IList DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x1A5FF10", Offset = "0x1A5ED10", VA = "0x181A5FF10", Slot = "5")]
	public IList CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public LGFDLOFKBOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class MEEHIKDOHAM<T> : global::OMDBGHJBFMI<T, global::GJFGIFNNEBL<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x4011600", Offset = "0x4010400", VA = "0x184011600", Slot = "8")]
	protected override void HMNAIPBHJIK(ref global::GJFGIFNNEBL<T> GLNLHJNNDLD, int NPDGHPHAKDK, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3A54650", Offset = "0x3A53450", VA = "0x183A54650", Slot = "7")]
	protected override global::GJFGIFNNEBL<T> HJNGNBALKKN()
	{
		return default(global::GJFGIFNNEBL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x4011630", Offset = "0x4010430", VA = "0x184011630", Slot = "9")]
	protected override IReadOnlyList<T> NNHOADFEBDJ(ref global::GJFGIFNNEBL<T> BGKOPHJCJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6190", Offset = "0x2CD4F90", VA = "0x182CD6190")]
	public MEEHIKDOHAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public static class OEEIIAHBNNL
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x1B81C80", Offset = "0x1B80A80", VA = "0x181B81C80")]
	public static DateTime OFNDHADAMHG(DateTime GGCDGBAICJE)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class DBMPHKMKOKM : global::KBIOLGDHIDG<DateTime>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly global::KBIOLGDHIDG<DateTime> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x1A3E950", Offset = "0x1A3D750", VA = "0x181A3E950", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, DateTime DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x1A3D9F0", Offset = "0x1A3C7F0", VA = "0x181A3D9F0", Slot = "5")]
	public DateTime CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public DBMPHKMKOKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class CLNIMHCGMGL : global::KBIOLGDHIDG<DateTimeOffset>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly global::KBIOLGDHIDG<DateTimeOffset> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x1A3CBA0", Offset = "0x1A3B9A0", VA = "0x181A3CBA0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, DateTimeOffset DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x1A3BC60", Offset = "0x1A3AA60", VA = "0x181A3BC60", Slot = "5")]
	public DateTimeOffset CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public CLNIMHCGMGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class ABNKIELHCGM : global::KBIOLGDHIDG<TimeSpan>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly global::KBIOLGDHIDG<TimeSpan> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static byte[] LGHIJOHOEOH;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x1A31E60", Offset = "0x1A30C60", VA = "0x181A31E60", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, TimeSpan DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x1A31480", Offset = "0x1A30280", VA = "0x181A31480", Slot = "5")]
	public TimeSpan CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public ABNKIELHCGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public abstract class LMBODJBLMOI<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::KBIOLGDHIDG<TDictionary>, CDJJKNODMKB where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x445E4C0", Offset = "0x445D2C0", VA = "0x18445E4C0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, TDictionary DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x445C610", Offset = "0x445B410", VA = "0x18445C610", Slot = "5")]
	public TDictionary CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator DFFMHNIAILL(TDictionary JFBGEPNCFEC);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate HJNGNBALKKN();

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void HMNAIPBHJIK(ref TIntermediate GLNLHJNNDLD, int NPDGHPHAKDK, TKey PIIJMEAKDGO, TValue DFEOJBAFBHE);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary NNHOADFEBDJ(ref TIntermediate BGKOPHJCJAG);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
	protected LMBODJBLMOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public abstract class IONJMAHMDHB<TKey, TValue, TIntermediate, TDictionary> : global::LMBODJBLMOI<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x36792E0", Offset = "0x36780E0", VA = "0x1836792E0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> DFFMHNIAILL(TDictionary JFBGEPNCFEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public abstract class GMLPBAICJGP<TKey, TValue, TDictionary> : global::IONJMAHMDHB<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x980940", Offset = "0x97F740", VA = "0x180980940", Slot = "9")]
	protected override TDictionary NNHOADFEBDJ(ref TDictionary BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class PBNCGBPILEE<TKey, TValue> : global::LMBODJBLMOI<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x41E6460", Offset = "0x41E5260", VA = "0x1841E6460", Slot = "8")]
	protected override void HMNAIPBHJIK(ref Dictionary<TKey, TValue> GLNLHJNNDLD, int NPDGHPHAKDK, TKey PIIJMEAKDGO, TValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x980940", Offset = "0x97F740", VA = "0x180980940", Slot = "9")]
	protected override Dictionary<TKey, TValue> NNHOADFEBDJ(ref Dictionary<TKey, TValue> BGKOPHJCJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x3675A60", Offset = "0x3674860", VA = "0x183675A60", Slot = "7")]
	protected override Dictionary<TKey, TValue> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x41E6410", Offset = "0x41E5210", VA = "0x1841E6410", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator DFFMHNIAILL(Dictionary<TKey, TValue> JFBGEPNCFEC)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x3843C90", Offset = "0x3842A90", VA = "0x183843C90")]
	public PBNCGBPILEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public sealed class JHAABICEMEB<TKey, TValue, TDictionary> : global::GMLPBAICJGP<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x3DD4BB0", Offset = "0x3DD39B0", VA = "0x183DD4BB0", Slot = "8")]
	protected override void HMNAIPBHJIK(ref TDictionary GLNLHJNNDLD, int NPDGHPHAKDK, TKey PIIJMEAKDGO, TValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x305A040", Offset = "0x3058E40", VA = "0x18305A040", Slot = "7")]
	protected override TDictionary HJNGNBALKKN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public sealed class INPGABIGFGD<TKey, TValue> : global::IONJMAHMDHB<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x36766A0", Offset = "0x36754A0", VA = "0x1836766A0", Slot = "8")]
	protected override void HMNAIPBHJIK(ref Dictionary<TKey, TValue> GLNLHJNNDLD, int NPDGHPHAKDK, TKey PIIJMEAKDGO, TValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x3675A60", Offset = "0x3674860", VA = "0x183675A60", Slot = "7")]
	protected override Dictionary<TKey, TValue> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x980940", Offset = "0x97F740", VA = "0x180980940", Slot = "9")]
	protected override IDictionary<TKey, TValue> NNHOADFEBDJ(ref Dictionary<TKey, TValue> BGKOPHJCJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class LPMMELOOABJ<TKey, TValue> : global::GMLPBAICJGP<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x36766A0", Offset = "0x36754A0", VA = "0x1836766A0", Slot = "8")]
	protected override void HMNAIPBHJIK(ref SortedList<TKey, TValue> GLNLHJNNDLD, int NPDGHPHAKDK, TKey PIIJMEAKDGO, TValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x3675A60", Offset = "0x3674860", VA = "0x183675A60", Slot = "7")]
	protected override SortedList<TKey, TValue> HJNGNBALKKN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class MBOELMMPELH<TKey, TValue> : global::LMBODJBLMOI<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x36766A0", Offset = "0x36754A0", VA = "0x1836766A0", Slot = "8")]
	protected override void HMNAIPBHJIK(ref SortedDictionary<TKey, TValue> GLNLHJNNDLD, int NPDGHPHAKDK, TKey PIIJMEAKDGO, TValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x980940", Offset = "0x97F740", VA = "0x180980940", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> NNHOADFEBDJ(ref SortedDictionary<TKey, TValue> BGKOPHJCJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3675A60", Offset = "0x3674860", VA = "0x183675A60", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> HJNGNBALKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x400B1F0", Offset = "0x4009FF0", VA = "0x18400B1F0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator DFFMHNIAILL(SortedDictionary<TKey, TValue> JFBGEPNCFEC)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class GDLPGAOEJHK<T> : global::KBIOLGDHIDG<T>, CDJJKNODMKB where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x45EF0C0", Offset = "0x45EDEC0", VA = "0x1845EF0C0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x45EEE90", Offset = "0x45EDC90", VA = "0x1845EEE90", Slot = "5")]
	public T CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
	public GDLPGAOEJHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class GIACFELFEKJ : global::KBIOLGDHIDG<IDictionary>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly global::KBIOLGDHIDG<IDictionary> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x1A4DC50", Offset = "0x1A4CA50", VA = "0x181A4DC50", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, IDictionary DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x1A4D8B0", Offset = "0x1A4C6B0", VA = "0x181A4D8B0", Slot = "5")]
	public IDictionary CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public GIACFELFEKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class HIPBHLDEGGC : global::KBIOLGDHIDG<object>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private delegate void EMBEIAEDKFJ(object PNPKJCNPONA, ref IPBPHIELIHL GAKCPFEFIJJ, object DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly global::KLLFKEKDHGC<KeyValuePair<object, EMBEIAEDKFJ>> BMNJABIDNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly CDAHFIMKBKG[] LOOLELJHFAD;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x1A507D0", Offset = "0x1A4F5D0", VA = "0x181A507D0")]
	public HIPBHLDEGGC(params CDAHFIMKBKG[] LOOLELJHFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x1A4FD70", Offset = "0x1A4EB70", VA = "0x181A4FD70", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, object DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x1A4FCD0", Offset = "0x1A4EAD0", VA = "0x181A4FCD0", Slot = "5")]
	public object CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public static class JGOFCCDBAPJ
{
	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x1A5A0C0", Offset = "0x1A58EC0", VA = "0x181A5A0C0")]
	public static object FJFIPBKEMNM(Type IGEIBCJNCHF, out bool NMAELJGCAME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1A5A9E0", Offset = "0x1A597E0", VA = "0x181A5A9E0")]
	public static object PJPGPBOBFFD(Type IGEIBCJNCHF, out bool NMAELJGCAME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public class CFEANDEOONP<T> : global::KBIOLGDHIDG<T>, CDJJKNODMKB, global::NKJJGAMHDGI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class GEILLDECEFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public GEILLDECEFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x4287B50", Offset = "0x4286950", VA = "0x184287B50")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class IJCPMMJKGLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public global::KOIGGKEGCNJ<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public IJCPMMJKGLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x3665B70", Offset = "0x3664970", VA = "0x183665B70")]
		internal void <.cctor>b__1(ref IPBPHIELIHL writer, T value, CDAHFIMKBKG _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class HGPPFACCGOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public global::KNFFAHGKNBH<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public HGPPFACCGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x3B11030", Offset = "0x3B0FE30", VA = "0x183B11030")]
		internal T <.cctor>b__2(ref HJNHIBNNFEE reader, CDAHFIMKBKG _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly global::BMGANMGKAHN<T> GCEFIFGMJJM;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static readonly Dictionary<T, string> JICLFNOBGPA;

	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private static readonly global::KOIGGKEGCNJ<T> FDMOLCODLGA;

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly global::KNFFAHGKNBH<T> MPPFKFAJIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly bool IIIKGJKIMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly global::KOIGGKEGCNJ<T> ONJOOEIKDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::KNFFAHGKNBH<T> ECNOMAALFDK;

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E9B0", Offset = "0x3C2D7B0", VA = "0x183C2E9B0")]
	static CFEANDEOONP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3C317A0", Offset = "0x3C305A0", VA = "0x183C317A0")]
	public CFEANDEOONP(bool IIIKGJKIMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x3C291E0", Offset = "0x3C27FE0", VA = "0x183C291E0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C27490", Offset = "0x3C26290", VA = "0x183C27490", Slot = "5")]
	public T CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3C29060", Offset = "0x3C27E60", VA = "0x183C29060", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, T DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3C28AF0", Offset = "0x3C278F0", VA = "0x183C28AF0", Slot = "7")]
	public T CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class FGLLCADMNPP<T> : global::KBIOLGDHIDG<T[,]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x4362DF0", Offset = "0x4361BF0", VA = "0x184362DF0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T[,] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x4362B20", Offset = "0x4361920", VA = "0x184362B20", Slot = "5")]
	public T[,] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
	public FGLLCADMNPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class DIKCHKIELPC<T> : global::KBIOLGDHIDG<T[,,]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1F90", Offset = "0x3AB0D90", VA = "0x183AB1F90", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T[,,] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1BB0", Offset = "0x3AB09B0", VA = "0x183AB1BB0", Slot = "5")]
	public T[,,] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
	public DIKCHKIELPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class KEAIHAGCPEJ<T> : global::KBIOLGDHIDG<T[,,,]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x4325F40", Offset = "0x4324D40", VA = "0x184325F40", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T[,,,] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x4325A40", Offset = "0x4324840", VA = "0x184325A40", Slot = "5")]
	public T[,,,] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
	public KEAIHAGCPEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class HJDLPFHNJPM<T> : global::KBIOLGDHIDG<T?>, CDJJKNODMKB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3B196E0", Offset = "0x3B184E0", VA = "0x183B196E0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x3B19430", Offset = "0x3B18230", VA = "0x183B19430", Slot = "5")]
	public T? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
	public HJDLPFHNJPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class IFFPMBNEBGM<T> : global::KBIOLGDHIDG<T?>, CDJJKNODMKB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private readonly global::KBIOLGDHIDG<T> JDECILKNLKP;

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2E6FB60", Offset = "0x2E6E960", VA = "0x182E6FB60")]
	public IFFPMBNEBGM(global::KBIOLGDHIDG<T> JDECILKNLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x32D6BD0", Offset = "0x32D59D0", VA = "0x1832D6BD0")]
	public IFFPMBNEBGM(Type APEBNIBGLGL, object[] JCAEACPDBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x32D5C10", Offset = "0x32D4A10", VA = "0x1832D5C10", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, T? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x32D5060", Offset = "0x32D3E60", VA = "0x1832D5060", Slot = "5")]
	public T? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class EDNEICAOPLN : global::KBIOLGDHIDG<sbyte>, CDJJKNODMKB, global::NKJJGAMHDGI<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly EDNEICAOPLN DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x1A3F260", Offset = "0x1A3E060", VA = "0x181A3F260", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, sbyte DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x1A3F190", Offset = "0x1A3DF90", VA = "0x181A3F190", Slot = "5")]
	public sbyte CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x1A3F220", Offset = "0x1A3E020", VA = "0x181A3F220", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, sbyte DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x1A3F1A0", Offset = "0x1A3DFA0", VA = "0x181A3F1A0", Slot = "7")]
	public sbyte CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public EDNEICAOPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class NJOOPAOMNCD : global::KBIOLGDHIDG<sbyte?>, CDJJKNODMKB, global::NKJJGAMHDGI<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly NJOOPAOMNCD DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x1B813D0", Offset = "0x1B801D0", VA = "0x181B813D0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, sbyte? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x1B81220", Offset = "0x1B80020", VA = "0x181B81220", Slot = "5")]
	public sbyte? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x1B81350", Offset = "0x1B80150", VA = "0x181B81350", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, sbyte? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x1B81290", Offset = "0x1B80090", VA = "0x181B81290", Slot = "7")]
	public sbyte? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public NJOOPAOMNCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class MHJKMLHCLBG : global::KBIOLGDHIDG<sbyte[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly MHJKMLHCLBG DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x1B7FBA0", Offset = "0x1B7E9A0", VA = "0x181B7FBA0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, sbyte[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x1B7FA60", Offset = "0x1B7E860", VA = "0x181B7FA60", Slot = "5")]
	public sbyte[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public MHJKMLHCLBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class MJMMJGIOKLE : global::KBIOLGDHIDG<short>, CDJJKNODMKB, global::NKJJGAMHDGI<short>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly MJMMJGIOKLE DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x1B7FD90", Offset = "0x1B7EB90", VA = "0x181B7FD90", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, short DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x1B7FCC0", Offset = "0x1B7EAC0", VA = "0x181B7FCC0", Slot = "5")]
	public short CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x1B7FD50", Offset = "0x1B7EB50", VA = "0x181B7FD50", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, short DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x1B7FCD0", Offset = "0x1B7EAD0", VA = "0x181B7FCD0", Slot = "7")]
	public short CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public MJMMJGIOKLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class IENCAAFOJJE : global::KBIOLGDHIDG<short?>, CDJJKNODMKB, global::NKJJGAMHDGI<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly IENCAAFOJJE DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x1A55B70", Offset = "0x1A54970", VA = "0x181A55B70", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, short? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x1A558C0", Offset = "0x1A546C0", VA = "0x181A558C0", Slot = "5")]
	public short? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x1A55A60", Offset = "0x1A54860", VA = "0x181A55A60", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, short? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x1A55970", Offset = "0x1A54770", VA = "0x181A55970", Slot = "7")]
	public short? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public IENCAAFOJJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class IAPODJNOLFK : global::KBIOLGDHIDG<short[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly IAPODJNOLFK DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x1A555F0", Offset = "0x1A543F0", VA = "0x181A555F0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, short[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x1A553C0", Offset = "0x1A541C0", VA = "0x181A553C0", Slot = "5")]
	public short[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public IAPODJNOLFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class AMNCIOLBIKO : global::KBIOLGDHIDG<int>, CDJJKNODMKB, global::NKJJGAMHDGI<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly AMNCIOLBIKO DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x1A33620", Offset = "0x1A32420", VA = "0x181A33620", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, int DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x1A33550", Offset = "0x1A32350", VA = "0x181A33550", Slot = "5")]
	public int CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x1A335E0", Offset = "0x1A323E0", VA = "0x181A335E0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, int DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x1A33560", Offset = "0x1A32360", VA = "0x181A33560", Slot = "7")]
	public int CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public AMNCIOLBIKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class JGCOBBIIIJP : global::KBIOLGDHIDG<int?>, CDJJKNODMKB, global::NKJJGAMHDGI<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly JGCOBBIIIJP DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1A59FD0", Offset = "0x1A58DD0", VA = "0x181A59FD0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, int? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x1A59D20", Offset = "0x1A58B20", VA = "0x181A59D20", Slot = "5")]
	public int? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x1A59EC0", Offset = "0x1A58CC0", VA = "0x181A59EC0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, int? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x1A59DD0", Offset = "0x1A58BD0", VA = "0x181A59DD0", Slot = "7")]
	public int? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public JGCOBBIIIJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class HOMBJPGGDNP : global::KBIOLGDHIDG<int[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly HOMBJPGGDNP DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x1A54F80", Offset = "0x1A53D80", VA = "0x181A54F80", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, int[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x1A54D50", Offset = "0x1A53B50", VA = "0x181A54D50", Slot = "5")]
	public int[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public HOMBJPGGDNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class IAHICOEHPGE : global::KBIOLGDHIDG<long>, CDJJKNODMKB, global::NKJJGAMHDGI<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly IAHICOEHPGE DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x1A55330", Offset = "0x1A54130", VA = "0x181A55330", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, long DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x1A55180", Offset = "0x1A53F80", VA = "0x181A55180", Slot = "5")]
	public long CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x1A55270", Offset = "0x1A54070", VA = "0x181A55270", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, long DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x1A55190", Offset = "0x1A53F90", VA = "0x181A55190", Slot = "7")]
	public long CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public IAHICOEHPGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class LMCJPFKJFOK : global::KBIOLGDHIDG<long?>, CDJJKNODMKB, global::NKJJGAMHDGI<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly LMCJPFKJFOK DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1A622B0", Offset = "0x1A610B0", VA = "0x181A622B0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, long? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1A61FC0", Offset = "0x1A60DC0", VA = "0x181A61FC0", Slot = "5")]
	public long? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x1A621A0", Offset = "0x1A60FA0", VA = "0x181A621A0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, long? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x1A62050", Offset = "0x1A60E50", VA = "0x181A62050", Slot = "7")]
	public long? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public LMCJPFKJFOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class FBMFKHKNAMI : global::KBIOLGDHIDG<long[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly FBMFKHKNAMI DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1A4AD60", Offset = "0x1A49B60", VA = "0x181A4AD60", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, long[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x1A4AC20", Offset = "0x1A49A20", VA = "0x181A4AC20", Slot = "5")]
	public long[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public FBMFKHKNAMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class FKLNOPBIHIK : global::KBIOLGDHIDG<byte>, CDJJKNODMKB, global::NKJJGAMHDGI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly FKLNOPBIHIK DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x1A4B410", Offset = "0x1A4A210", VA = "0x181A4B410", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, byte DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x1A4B240", Offset = "0x1A4A040", VA = "0x181A4B240", Slot = "5")]
	public byte CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x1A4B350", Offset = "0x1A4A150", VA = "0x181A4B350", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, byte DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x1A4B2A0", Offset = "0x1A4A0A0", VA = "0x181A4B2A0", Slot = "7")]
	public byte CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public FKLNOPBIHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class MMJKNOEPHFH : global::KBIOLGDHIDG<byte?>, CDJJKNODMKB, global::NKJJGAMHDGI<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly MMJKNOEPHFH DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x1B80410", Offset = "0x1B7F210", VA = "0x181B80410", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, byte? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x1B80260", Offset = "0x1B7F060", VA = "0x181B80260", Slot = "5")]
	public byte? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x1B80390", Offset = "0x1B7F190", VA = "0x181B80390", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, byte? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x1B802D0", Offset = "0x1B7F0D0", VA = "0x181B802D0", Slot = "7")]
	public byte? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public MMJKNOEPHFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class CCMEODLFNPD : global::KBIOLGDHIDG<ushort>, CDJJKNODMKB, global::NKJJGAMHDGI<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly CCMEODLFNPD DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x1A38A70", Offset = "0x1A37870", VA = "0x181A38A70", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ushort DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x1A389A0", Offset = "0x1A377A0", VA = "0x181A389A0", Slot = "5")]
	public ushort CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x1A38A30", Offset = "0x1A37830", VA = "0x181A38A30", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, ushort DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x1A389B0", Offset = "0x1A377B0", VA = "0x181A389B0", Slot = "7")]
	public ushort CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public CCMEODLFNPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class MLMKAEEIJIN : global::KBIOLGDHIDG<ushort?>, CDJJKNODMKB, global::NKJJGAMHDGI<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly MLMKAEEIJIN DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x1B80180", Offset = "0x1B7EF80", VA = "0x181B80180", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ushort? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x1B7FFD0", Offset = "0x1B7EDD0", VA = "0x181B7FFD0", Slot = "5")]
	public ushort? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x1B80100", Offset = "0x1B7EF00", VA = "0x181B80100", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, ushort? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x1B80040", Offset = "0x1B7EE40", VA = "0x181B80040", Slot = "7")]
	public ushort? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public MLMKAEEIJIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class CBKNLIDJADJ : global::KBIOLGDHIDG<ushort[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly CBKNLIDJADJ DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x1A38880", Offset = "0x1A37680", VA = "0x181A38880", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ushort[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x1A38740", Offset = "0x1A37540", VA = "0x181A38740", Slot = "5")]
	public ushort[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public CBKNLIDJADJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class PADKJPKAKON : global::KBIOLGDHIDG<uint>, CDJJKNODMKB, global::NKJJGAMHDGI<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly PADKJPKAKON DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x1B82890", Offset = "0x1B81690", VA = "0x181B82890", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, uint DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x1B827C0", Offset = "0x1B815C0", VA = "0x181B827C0", Slot = "5")]
	public uint CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x1B82850", Offset = "0x1B81650", VA = "0x181B82850", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, uint DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x1B827D0", Offset = "0x1B815D0", VA = "0x181B827D0", Slot = "7")]
	public uint CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public PADKJPKAKON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class AGPGDKNEPAO : global::KBIOLGDHIDG<uint?>, CDJJKNODMKB, global::NKJJGAMHDGI<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly AGPGDKNEPAO DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x1A32880", Offset = "0x1A31680", VA = "0x181A32880", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, uint? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x1A326D0", Offset = "0x1A314D0", VA = "0x181A326D0", Slot = "5")]
	public uint? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x1A32800", Offset = "0x1A31600", VA = "0x181A32800", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, uint? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x1A32740", Offset = "0x1A31540", VA = "0x181A32740", Slot = "7")]
	public uint? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public AGPGDKNEPAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class CNOGOHIGMCI : global::KBIOLGDHIDG<uint[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly CNOGOHIGMCI DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x1A3D8D0", Offset = "0x1A3C6D0", VA = "0x181A3D8D0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, uint[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x1A3D790", Offset = "0x1A3C590", VA = "0x181A3D790", Slot = "5")]
	public uint[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public CNOGOHIGMCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class DCCKCCPDOHN : global::KBIOLGDHIDG<ulong>, CDJJKNODMKB, global::NKJJGAMHDGI<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly DCCKCCPDOHN DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EEE0", Offset = "0x1A3DCE0", VA = "0x181A3EEE0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ulong DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EE10", Offset = "0x1A3DC10", VA = "0x181A3EE10", Slot = "5")]
	public ulong CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EEA0", Offset = "0x1A3DCA0", VA = "0x181A3EEA0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, ulong DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1A3EE20", Offset = "0x1A3DC20", VA = "0x181A3EE20", Slot = "7")]
	public ulong CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public DCCKCCPDOHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class JDPEFOGPFOJ : global::KBIOLGDHIDG<ulong?>, CDJJKNODMKB, global::NKJJGAMHDGI<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly JDPEFOGPFOJ DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x1A59930", Offset = "0x1A58730", VA = "0x181A59930", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ulong? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1A596B0", Offset = "0x1A584B0", VA = "0x181A596B0", Slot = "5")]
	public ulong? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x1A59820", Offset = "0x1A58620", VA = "0x181A59820", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, ulong? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x1A59740", Offset = "0x1A58540", VA = "0x181A59740", Slot = "7")]
	public ulong? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public JDPEFOGPFOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class EIAANOBEJPD : global::KBIOLGDHIDG<ulong[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly EIAANOBEJPD DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x1A49850", Offset = "0x1A48650", VA = "0x181A49850", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ulong[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x1A49710", Offset = "0x1A48510", VA = "0x181A49710", Slot = "5")]
	public ulong[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public EIAANOBEJPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class OCCBHAOIDLK : global::KBIOLGDHIDG<float>, CDJJKNODMKB, global::NKJJGAMHDGI<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly OCCBHAOIDLK DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x1B81580", Offset = "0x1B80380", VA = "0x181B81580", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, float DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1B814B0", Offset = "0x1B802B0", VA = "0x181B814B0", Slot = "5")]
	public float CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1B81540", Offset = "0x1B80340", VA = "0x181B81540", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, float DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x1B814C0", Offset = "0x1B802C0", VA = "0x181B814C0", Slot = "7")]
	public float CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public OCCBHAOIDLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class GKFFMICIECH : global::KBIOLGDHIDG<float?>, CDJJKNODMKB, global::NKJJGAMHDGI<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly GKFFMICIECH DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x1A4E3C0", Offset = "0x1A4D1C0", VA = "0x181A4E3C0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, float? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x1A4E160", Offset = "0x1A4CF60", VA = "0x181A4E160", Slot = "5")]
	public float? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x1A4E2C0", Offset = "0x1A4D0C0", VA = "0x181A4E2C0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, float? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x1A4E1D0", Offset = "0x1A4CFD0", VA = "0x181A4E1D0", Slot = "7")]
	public float? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public GKFFMICIECH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class OPHFILKIOFK : global::KBIOLGDHIDG<float[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly OPHFILKIOFK DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1B826A0", Offset = "0x1B814A0", VA = "0x181B826A0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, float[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1B82560", Offset = "0x1B81360", VA = "0x181B82560", Slot = "5")]
	public float[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public OPHFILKIOFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class PFKCJCFEEDI : global::KBIOLGDHIDG<double>, CDJJKNODMKB, global::NKJJGAMHDGI<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly PFKCJCFEEDI DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x1B830D0", Offset = "0x1B81ED0", VA = "0x181B830D0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, double DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1B83000", Offset = "0x1B81E00", VA = "0x181B83000", Slot = "5")]
	public double CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x1B83090", Offset = "0x1B81E90", VA = "0x181B83090", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, double DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x1B83010", Offset = "0x1B81E10", VA = "0x181B83010", Slot = "7")]
	public double CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public PFKCJCFEEDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class GGEAEEBMCMA : global::KBIOLGDHIDG<double?>, CDJJKNODMKB, global::NKJJGAMHDGI<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly GGEAEEBMCMA DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x1A4D2A0", Offset = "0x1A4C0A0", VA = "0x181A4D2A0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, double? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x1A4CF70", Offset = "0x1A4BD70", VA = "0x181A4CF70", Slot = "5")]
	public double? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x1A4D190", Offset = "0x1A4BF90", VA = "0x181A4D190", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, double? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x1A4D000", Offset = "0x1A4BE00", VA = "0x181A4D000", Slot = "7")]
	public double? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public GGEAEEBMCMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class KDBBEOBGEAG : global::KBIOLGDHIDG<double[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly KDBBEOBGEAG DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x1A5D0C0", Offset = "0x1A5BEC0", VA = "0x181A5D0C0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, double[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x1A5CE90", Offset = "0x1A5BC90", VA = "0x181A5CE90", Slot = "5")]
	public double[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public KDBBEOBGEAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class CFCEFGJKNFK : global::KBIOLGDHIDG<bool>, CDJJKNODMKB, global::NKJJGAMHDGI<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly CFCEFGJKNFK DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x1A38CA0", Offset = "0x1A37AA0", VA = "0x181A38CA0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, bool DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x1A38BD0", Offset = "0x1A379D0", VA = "0x181A38BD0", Slot = "5")]
	public bool CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x1A38C60", Offset = "0x1A37A60", VA = "0x181A38C60", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, bool DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x1A38BE0", Offset = "0x1A379E0", VA = "0x181A38BE0", Slot = "7")]
	public bool CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public CFCEFGJKNFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class KIECLGEDMMF : global::KBIOLGDHIDG<bool?>, CDJJKNODMKB, global::NKJJGAMHDGI<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly KIECLGEDMMF DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x1A5D730", Offset = "0x1A5C530", VA = "0x181A5D730", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, bool? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x1A5D500", Offset = "0x1A5C300", VA = "0x181A5D500", Slot = "5")]
	public bool? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x1A5D630", Offset = "0x1A5C430", VA = "0x181A5D630", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, bool? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x1A5D570", Offset = "0x1A5C370", VA = "0x181A5D570", Slot = "7")]
	public bool? CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public KIECLGEDMMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class JLKHOJGAILI : global::KBIOLGDHIDG<bool[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly JLKHOJGAILI DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x1A5BEB0", Offset = "0x1A5ACB0", VA = "0x181A5BEB0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, bool[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x1A5BC80", Offset = "0x1A5AA80", VA = "0x181A5BC80", Slot = "5")]
	public bool[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public JLKHOJGAILI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class GBPKEEACNAN : global::KBIOLGDHIDG<object>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::KBIOLGDHIDG<object> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly Dictionary<Type, int> PMDNOMEDOFK;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x1A4BD90", Offset = "0x1A4AB90", VA = "0x181A4BD90", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, object DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x1A4B920", Offset = "0x1A4A720", VA = "0x181A4B920", Slot = "5")]
	public object CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public GBPKEEACNAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class LKNNIAJDCBA : global::KBIOLGDHIDG<byte[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::KBIOLGDHIDG<byte[]> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x1A61DA0", Offset = "0x1A60BA0", VA = "0x181A61DA0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, byte[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x1A61D20", Offset = "0x1A60B20", VA = "0x181A61D20", Slot = "5")]
	public byte[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public LKNNIAJDCBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class LFANCPLPPNF : global::KBIOLGDHIDG<ArraySegment<byte>>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::KBIOLGDHIDG<ArraySegment<byte>> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x1A5FDF0", Offset = "0x1A5EBF0", VA = "0x181A5FDF0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, ArraySegment<byte> DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x1A5FD10", Offset = "0x1A5EB10", VA = "0x181A5FD10", Slot = "5")]
	public ArraySegment<byte> CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public LFANCPLPPNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class OJOAHCLPCOF : global::KBIOLGDHIDG<string>, CDJJKNODMKB, global::NKJJGAMHDGI<string>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::KBIOLGDHIDG<string> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x1B824E0", Offset = "0x1B812E0", VA = "0x181B824E0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, string DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1B824D0", Offset = "0x1B812D0", VA = "0x181B824D0", Slot = "5")]
	public string CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x1B824E0", Offset = "0x1B812E0", VA = "0x181B824E0", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, string DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x1B824D0", Offset = "0x1B812D0", VA = "0x181B824D0", Slot = "7")]
	public string CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public OJOAHCLPCOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class PGJLBADOMPO : global::KBIOLGDHIDG<string[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly PGJLBADOMPO DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x1B833D0", Offset = "0x1B821D0", VA = "0x181B833D0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, string[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x1B83260", Offset = "0x1B82060", VA = "0x181B83260", Slot = "5")]
	public string[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public PGJLBADOMPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class BCBBPNLGOPB : global::KBIOLGDHIDG<char>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly BCBBPNLGOPB DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x1A336C0", Offset = "0x1A324C0", VA = "0x181A336C0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, char DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x1A33690", Offset = "0x1A32490", VA = "0x181A33690", Slot = "5")]
	public char CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public BCBBPNLGOPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class NJLHLLFNLFD : global::KBIOLGDHIDG<char?>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly NJLHLLFNLFD DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x1B810D0", Offset = "0x1B7FED0", VA = "0x181B810D0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, char? DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x1B81000", Offset = "0x1B7FE00", VA = "0x181B81000", Slot = "5")]
	public char? CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public NJLHLLFNLFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class MAAGJDNFKND : global::KBIOLGDHIDG<char[]>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly MAAGJDNFKND DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x1A625A0", Offset = "0x1A613A0", VA = "0x181A625A0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, char[] DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x1A623A0", Offset = "0x1A611A0", VA = "0x181A623A0", Slot = "5")]
	public char[] CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public MAAGJDNFKND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class KJCCOIBPJLO : global::KBIOLGDHIDG<Guid>, CDJJKNODMKB, global::NKJJGAMHDGI<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::KBIOLGDHIDG<Guid> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x1A5D890", Offset = "0x1A5C690", VA = "0x181A5D890", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Guid DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x1A5D810", Offset = "0x1A5C610", VA = "0x181A5D810", Slot = "5")]
	public Guid CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x1A5D860", Offset = "0x1A5C660", VA = "0x181A5D860", Slot = "6")]
	public void JHBMCBFLADI(ref IPBPHIELIHL GAKCPFEFIJJ, Guid DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x1A5D810", Offset = "0x1A5C610", VA = "0x181A5D810", Slot = "7")]
	public Guid CPBCBPHFDIJ(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public KJCCOIBPJLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class PPKCBIFPLLP : global::KBIOLGDHIDG<decimal>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::KBIOLGDHIDG<decimal> DCLACCPOJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly bool GCEJMIBDCMF;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x11A1B20", Offset = "0x11A0920", VA = "0x1811A1B20")]
	public PPKCBIFPLLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0xDA01C0", Offset = "0xD9EFC0", VA = "0x180DA01C0")]
	public PPKCBIFPLLP(bool GCEJMIBDCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x1B86980", Offset = "0x1B85780", VA = "0x181B86980", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, decimal DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x1B86750", Offset = "0x1B85550", VA = "0x181B86750", Slot = "5")]
	public decimal CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class GKLOANBOMOG : global::KBIOLGDHIDG<Uri>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly global::KBIOLGDHIDG<Uri> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x1A4E520", Offset = "0x1A4D320", VA = "0x181A4E520", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Uri DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x1A4E4A0", Offset = "0x1A4D2A0", VA = "0x181A4E4A0", Slot = "5")]
	public Uri CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public GKLOANBOMOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class HKCHCHBKLJH : global::KBIOLGDHIDG<Version>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly global::KBIOLGDHIDG<Version> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x1A53BE0", Offset = "0x1A529E0", VA = "0x181A53BE0", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Version DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x1A53B60", Offset = "0x1A52960", VA = "0x181A53B60", Slot = "5")]
	public Version CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public HKCHCHBKLJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class NKICGLOMIPE<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class LMCCLJPIHFB : global::KBIOLGDHIDG<StringBuilder>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly global::KBIOLGDHIDG<StringBuilder> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x1A61F10", Offset = "0x1A60D10", VA = "0x181A61F10", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, StringBuilder DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x1A61E90", Offset = "0x1A60C90", VA = "0x181A61E90", Slot = "5")]
	public StringBuilder CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public LMCCLJPIHFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class CLMEAFLOCKF : global::KBIOLGDHIDG<BitArray>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly global::KBIOLGDHIDG<BitArray> DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x1A3BB70", Offset = "0x1A3A970", VA = "0x181A3BB70", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, BitArray DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x1A3BA50", Offset = "0x1A3A850", VA = "0x181A3BA50", Slot = "5")]
	public BitArray CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public CLMEAFLOCKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class HKBKJLOILLP : global::KBIOLGDHIDG<Type>, CDJJKNODMKB
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly HKBKJLOILLP DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly Regex MFDKAAMIIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool BOKGFINFPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private bool KGKEOGACIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private bool NPBFACFCDLB;

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x1A53B40", Offset = "0x1A52940", VA = "0x181A53B40")]
	public HKBKJLOILLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1A53AF0", Offset = "0x1A528F0", VA = "0x181A53AF0")]
	public HKBKJLOILLP(bool BOKGFINFPNG, bool KGKEOGACIGB, bool NPBFACFCDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x1A53940", Offset = "0x1A52740", VA = "0x181A53940", Slot = "4")]
	public void PNKNJNLKBEB(ref IPBPHIELIHL GAKCPFEFIJJ, Type DFEOJBAFBHE, CDAHFIMKBKG JHKHKBOLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x1A53810", Offset = "0x1A52610", VA = "0x181A53810", Slot = "5")]
	public Type CJKIJAOEIBM(ref HJNHIBNNFEE NINBMPMOGGB, CDAHFIMKBKG JHKHKBOLLLB)
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
