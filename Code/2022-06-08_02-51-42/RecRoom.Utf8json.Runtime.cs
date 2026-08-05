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
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class PGEFNABIJLM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x562220", Offset = "0x561220", VA = "0x180562220")]
	public PGEFNABIJLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class JBKICNNNEND : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x562220", Offset = "0x561220", VA = "0x180562220")]
	public JBKICNNNEND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class IBDNCBPICCH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x562220", Offset = "0x561220", VA = "0x180562220")]
	public IBDNCBPICCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class LAHILMNMJEG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x562220", Offset = "0x561220", VA = "0x180562220")]
	public LAHILMNMJEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class LPALAFPFBFP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2F9BB70", Offset = "0x2F9AB70", VA = "0x182F9BB70")]
	public static bool GCJFBLCNPPE(this TypeInfo DMBEFJIHONB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class HDIKMJPNLLJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type EDEHPENDFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551490", VA = "0x180552490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] ECHILMPMJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x9AD0F0", Offset = "0x9AC0F0", VA = "0x1809AD0F0")]
	public HDIKMJPNLLJ(Type LFGIIJJLDEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class HMEDHBLFAEJ : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void IKEKJJNAKKM<T>(ref AAEIOLMBBFI EEDEJPBOCJL, T MFBIHMKFNKA, CDLCJJDIPKK NAFMEEIPPLF);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T HJCIHHCPLGI<T>(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NAFMEEIPPLF);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OHDNNHIHLFA
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GNGMIEPFFIJ<T> : OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, T MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HBGHNMDNJPN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, T MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum EKPDCFPCPKH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PKOCJOMICPN
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x17331F0", Offset = "0x17321F0", VA = "0x1817331F0")]
	public static global::GNGMIEPFFIJ<T> LMKHMGBPDFD<T>(this CDLCJJDIPKK NAFMEEIPPLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4B41090", Offset = "0x4B40090", VA = "0x184B41090")]
	public static object FMMIPFPBFBM(this CDLCJJDIPKK NAFMEEIPPLF, Type DMBEFJIHONB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MAOMCHDIICH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4B32FA0", Offset = "0x4B31FA0", VA = "0x184B32FA0")]
	public MAOMCHDIICH(string LMJMILCCPPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OEHFEJKEOBN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class KIEGNPFJEMI
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] MGGGNBHMHDA;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] CJCJIJBFAMB;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4B32E90", Offset = "0x4B31E90", VA = "0x184B32E90")]
		public static byte[] BINHNLGNBCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4B32F10", Offset = "0x4B31F10", VA = "0x184B32F10")]
		public static char[] NDKKECAECKO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> JFCDJCKBCKP;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] EJDFLNKPENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] JNPIAJHKCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int JNMGKKFIPGA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool AFPONHMBNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4B3E180", Offset = "0x4B3D180", VA = "0x184B3E180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4B3EE80", Offset = "0x4B3DE80", VA = "0x184B3EE80")]
	public OEHFEJKEOBN(byte[] JNPIAJHKCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4B3EE90", Offset = "0x4B3DE90", VA = "0x184B3EE90")]
	public OEHFEJKEOBN(byte[] JNPIAJHKCKB, int JNMGKKFIPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4B3CB60", Offset = "0x4B3BB60", VA = "0x184B3CB60")]
	private KECNDMPEHCE EPHIBJDCEIJ(string PAIKHKPBKDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4B3C770", Offset = "0x4B3B770", VA = "0x184B3C770")]
	private KECNDMPEHCE CLCALCENPGH(string LMJMILCCPPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x26F7C10", Offset = "0x26F6C10", VA = "0x1826F7C10")]
	public void CFNIALOHDFI(int JNMGKKFIPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x595070", Offset = "0x594070", VA = "0x180595070")]
	public byte[] KMAEDEGKMFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xED5110", Offset = "0xED4110", VA = "0x180ED5110")]
	public int HICAHIDNFFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4B3EB00", Offset = "0x4B3DB00", VA = "0x184B3EB00")]
	public OCHPDHMKLKL OPMPEGAOPGD()
	{
		return default(OCHPDHMKLKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4B3E200", Offset = "0x4B3D200", VA = "0x184B3E200")]
	public void LACAHFFCEPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4B3E340", Offset = "0x4B3D340", VA = "0x184B3E340")]
	public bool LJHFMNIBGAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4B3E5C0", Offset = "0x4B3D5C0", VA = "0x184B3E5C0")]
	public bool NDELIOOHIDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4B3CA60", Offset = "0x4B3BA60", VA = "0x184B3CA60")]
	public void ENDLPPAFAFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4B3EA70", Offset = "0x4B3DA70", VA = "0x184B3EA70")]
	public bool OGLJCMMNLJP(ref int KLPGLGDELCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4B3C5E0", Offset = "0x4B3B5E0", VA = "0x184B3C5E0")]
	public bool BGNMDILOLCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4B3C9C0", Offset = "0x4B3B9C0", VA = "0x184B3C9C0")]
	public void EECIMJOJCKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4B3D310", Offset = "0x4B3C310", VA = "0x184B3D310")]
	public bool FKIAHOGJGAP(ref int KLPGLGDELCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4B3D000", Offset = "0x4B3C000", VA = "0x184B3D000")]
	public bool EPIKFNJJDGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4B3E080", Offset = "0x4B3D080", VA = "0x184B3E080")]
	public void IKPPLMFIINP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4B3C950", Offset = "0x4B3B950", VA = "0x184B3C950")]
	public bool EDMENFHCBIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4B3D6D0", Offset = "0x4B3C6D0", VA = "0x184B3D6D0")]
	public void HJALKNJGKPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4B3D770", Offset = "0x4B3C770", VA = "0x184B3D770")]
	private void HLBLMDJLIMN(out byte[] IKFKPAPAEBN, out int ENAOKCLPKKN, out int JMKEJECELHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4B3C440", Offset = "0x4B3B440", VA = "0x184B3C440")]
	private static int AAEPHBHPMBL(char OOKPIHBNHGF, char FMMAACMCILJ, char MCODHPOGBPN, char HFCLJHDBBCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4B3C880", Offset = "0x4B3B880", VA = "0x184B3C880")]
	private static int EDDPLEIKPIE(char FMMKCBAOFKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4B3C4F0", Offset = "0x4B3B4F0", VA = "0x184B3C4F0")]
	public ArraySegment<byte> BBHJOIMLKDO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4B3E4E0", Offset = "0x4B3D4E0", VA = "0x184B3E4E0")]
	public string MGPMLPEBCIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4B3C850", Offset = "0x4B3B850", VA = "0x184B3C850")]
	public string DJOOILOHCKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4B3D520", Offset = "0x4B3C520", VA = "0x184B3D520")]
	public ArraySegment<byte> HDOGKPNIOAJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4B3E580", Offset = "0x4B3D580", VA = "0x184B3E580")]
	public ArraySegment<byte> MPFPIODOIMN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4B3E810", Offset = "0x4B3D810", VA = "0x184B3E810")]
	public bool NMDHLIHHCGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4B3DFC0", Offset = "0x4B3CFC0", VA = "0x184B3DFC0")]
	private static bool IGGKAKCMBIJ(byte MCODHPOGBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4B3D140", Offset = "0x4B3C140", VA = "0x184B3D140")]
	private void FDCNHCPPDKB(OCHPDHMKLKL JGMHCJIBOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4B3C650", Offset = "0x4B3B650", VA = "0x184B3C650")]
	public void BICMNEAPABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4B3D070", Offset = "0x4B3C070", VA = "0x184B3D070")]
	private void FCODKPEMDJE(int OGFADADBCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4B3C720", Offset = "0x4B3B720", VA = "0x184B3C720")]
	public sbyte CIBCICNHDEP()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4B3E120", Offset = "0x4B3D120", VA = "0x184B3E120")]
	public short JFNBLPCFJNA()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4B3DF00", Offset = "0x4B3CF00", VA = "0x184B3DF00")]
	public int IADEKJMJPCB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4B3EC90", Offset = "0x4B3DC90", VA = "0x184B3EC90")]
	public long PDNJOIHCIMK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4B3DF60", Offset = "0x4B3CF60", VA = "0x184B3DF60")]
	public byte ICIFIELEFNN()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4B3CB00", Offset = "0x4B3BB00", VA = "0x184B3CB00")]
	public ushort EOHFCNGBOBB()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4B3E1A0", Offset = "0x4B3D1A0", VA = "0x184B3E1A0")]
	public uint KENAGGIFPAD()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4B3E460", Offset = "0x4B3D460", VA = "0x184B3E460")]
	public ulong LOHPENPIKBJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4B3E750", Offset = "0x4B3D750", VA = "0x184B3E750")]
	public float NMACLDDIGFF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4B3C660", Offset = "0x4B3B660", VA = "0x184B3C660")]
	public double BNFLDCEMKIP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4B3E630", Offset = "0x4B3D630", VA = "0x184B3E630")]
	public ArraySegment<byte> NEOBNKGBJNP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4B3D3A0", Offset = "0x4B3C3A0", VA = "0x184B3D3A0")]
	private static int HAMMLFBGNFI(byte[] JNPIAJHKCKB, int JNMGKKFIPGA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KECNDMPEHCE : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference HHOECPLHEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int BAFINPKEAHM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int CPLNMGJAFEM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7E5170", Offset = "0x7E4170", VA = "0x1807E5170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string DNEEMDFEDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6D9890", Offset = "0x6D8890", VA = "0x1806D9890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CCB0", Offset = "0x2F8BCB0", VA = "0x182F8CCB0")]
	public KECNDMPEHCE(string LMJMILCCPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CBE0", Offset = "0x2F8BBE0", VA = "0x182F8CBE0")]
	public KECNDMPEHCE(string LMJMILCCPPB, byte[] KGFJBEPIDMF, int JNMGKKFIPGA, int BAFINPKEAHM, string CNGPLNHPIAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LHMCPNKKFAP
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class LAJJEEDFDKE
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void JGJEFOCJKHH(ref AAEIOLMBBFI EEDEJPBOCJL, object MFBIHMKFNKA, CDLCJJDIPKK NAFMEEIPPLF);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object ALGPNKLNJMD(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NAFMEEIPPLF);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class FKEMHNBEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class EDLAHFGPCLJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
				public EDLAHFGPCLJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2F84620", Offset = "0x2F83620", VA = "0x182F84620")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2F84660", Offset = "0x2F83660", VA = "0x182F84660")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, CDLCJJDIPKK, byte[]> AELBAOOBDLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, CDLCJJDIPKK> JAPJMNPKFOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly JGJEFOCJKHH OOOCDEDFPPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, CDLCJJDIPKK, ArraySegment<byte>> CJIGOKCINDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, CDLCJJDIPKK, string> FHMGFHAJBCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, CDLCJJDIPKK, object> GHPPDMFHNLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, CDLCJJDIPKK, object> BHGPLBJLAPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, CDLCJJDIPKK, object> OHCLBFFHKCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly ALGPNKLNJMD LMJBPPCAPKI;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2F84AB0", Offset = "0x2F83AB0", VA = "0x182F84AB0")]
			public FKEMHNBEMOP(Type DMBEFJIHONB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x19F0AF0", Offset = "0x19EFAF0", VA = "0x1819F0AF0")]
			private static T IEFDKOEAMEE<T>(DynamicMethod JLKJEEKLBGF)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2F848C0", Offset = "0x2F838C0", VA = "0x182F848C0")]
			private static MethodInfo IJILHJKPLFN(Type DMBEFJIHONB, string JIEIIEKPPIJ, Type[] MADLOPIJDCJ)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, FKEMHNBEMOP> NJKLBMMEELL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::PDHEEJFMMNJ<FKEMHNBEMOP> KOOMHNOHEJO;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2F99A10", Offset = "0x2F98A10", VA = "0x182F99A10")]
		static LAJJEEDFDKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2F99710", Offset = "0x2F98710", VA = "0x182F99710")]
		private static FKEMHNBEMOP IFPEMELNPAG(Type DMBEFJIHONB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2F998A0", Offset = "0x2F988A0", VA = "0x182F998A0")]
		public static void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, object MFBIHMKFNKA, CDLCJJDIPKK NAFMEEIPPLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2F99790", Offset = "0x2F98790", VA = "0x182F99790")]
		public static void PBGNCPABBCO(Type DMBEFJIHONB, ref AAEIOLMBBFI EEDEJPBOCJL, object MFBIHMKFNKA, CDLCJJDIPKK NAFMEEIPPLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class LPAMMPBOJFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] MGGGNBHMHDA;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2F9BBA0", Offset = "0x2F9ABA0", VA = "0x182F9BBA0")]
		public static byte[] BINHNLGNBCP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static CDLCJJDIPKK KBODBGPANPM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] NOPOBGNBINP;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] NNMNALGFEEB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static CDLCJJDIPKK PELGEDEHKLA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2F9AF70", Offset = "0x2F99F70", VA = "0x182F9AF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2F9AF10", Offset = "0x2F99F10", VA = "0x182F9AF10")]
	public static void CGADGJIHMCE(CDLCJJDIPKK NAFMEEIPPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3620", Offset = "0x1FD2620", VA = "0x181FD3620")]
	public static string GKBFKAMHNKO<T>(T MFBIHMKFNKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FD36A0", Offset = "0x1FD26A0", VA = "0x181FD36A0")]
	public static string GKBFKAMHNKO<T>(T MFBIHMKFNKA, CDLCJJDIPKK NAFMEEIPPLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x19F5C90", Offset = "0x19F4C90", VA = "0x1819F5C90")]
	public static T GPGJANKJBGF<T>(string DCKKJLGKFJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x19F5BC0", Offset = "0x19F4BC0", VA = "0x1819F5BC0")]
	public static T GPGJANKJBGF<T>(string DCKKJLGKFJJ, CDLCJJDIPKK NAFMEEIPPLF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x19F5B40", Offset = "0x19F4B40", VA = "0x1819F5B40")]
	public static T GPGJANKJBGF<T>(byte[] JNPIAJHKCKB, CDLCJJDIPKK NAFMEEIPPLF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x19F5D10", Offset = "0x19F4D10", VA = "0x1819F5D10")]
	public static T GPGJANKJBGF<T>(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, CDLCJJDIPKK NAFMEEIPPLF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum OCHPDHMKLKL : byte
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
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct AAEIOLMBBFI
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] CIGLMBAIDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] MGGGNBHMHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int JNMGKKFIPGA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int IGJPMDFFBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xED5110", Offset = "0xED4110", VA = "0x180ED5110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x26F7C10", Offset = "0x26F6C10", VA = "0x1826F7C10")]
	public void CFNIALOHDFI(int JNMGKKFIPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x26F85F0", Offset = "0x26F75F0", VA = "0x1826F85F0")]
	public static byte[] MEIBHGMOOOA(string CLFMNLIOIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x26F8880", Offset = "0x26F7880", VA = "0x1826F8880")]
	public static byte[] OBHPNOBENBP(string CLFMNLIOIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x26F8090", Offset = "0x26F7090", VA = "0x1826F8090")]
	public static byte[] KAMIPDHKGMC(string CLFMNLIOIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x26F89C0", Offset = "0x26F79C0", VA = "0x1826F89C0")]
	public static byte[] OELIGPMOFNO(string CLFMNLIOIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x26F8C90", Offset = "0x26F7C90", VA = "0x1826F8C90")]
	public AAEIOLMBBFI(byte[] ODPEDFJHOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x26F7A60", Offset = "0x26F6A60", VA = "0x1826F7A60")]
	public ArraySegment<byte> BINHNLGNBCP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x26F7CC0", Offset = "0x26F6CC0", VA = "0x1826F7CC0")]
	public byte[] ELEKJKAINJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x26F8BE0", Offset = "0x26F7BE0", VA = "0x1826F8BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x26F89B0", Offset = "0x26F79B0", VA = "0x1826F89B0")]
	public void OCMKAFFOPBE(int AFOPANCEIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x26F7FD0", Offset = "0x26F6FD0", VA = "0x1826F7FD0")]
	public void JEBBKEDNIDB(byte[] MCKANBDEMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x26F8BA0", Offset = "0x26F7BA0", VA = "0x1826F8BA0")]
	public void OPEMDBOHMHA(byte MCKANBDEMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x26F86D0", Offset = "0x26F76D0", VA = "0x1826F86D0")]
	public void MJOGEHFPKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x26F7D90", Offset = "0x26F6D90", VA = "0x1826F7D90")]
	public void IKIJLOIDJJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x26F7C20", Offset = "0x26F6C20", VA = "0x1826F7C20")]
	public void CNPCGDHOGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26F87B0", Offset = "0x26F77B0", VA = "0x1826F87B0")]
	public void NIFFEIFNODL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x26F7C70", Offset = "0x26F6C70", VA = "0x1826F7C70")]
	public void DDCPAOOPLLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x26F7D40", Offset = "0x26F6D40", VA = "0x1826F7D40")]
	public void IBGLIMPLHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x26F79B0", Offset = "0x26F69B0", VA = "0x1826F79B0")]
	public void BBGOPDCGGKL(string CLFMNLIOIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x26F7A10", Offset = "0x26F6A10", VA = "0x1826F7A10")]
	public void BCJLPHMEFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x26F7B10", Offset = "0x26F6B10", VA = "0x1826F7B10")]
	public void CBFGJPAIBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x26F7DE0", Offset = "0x26F6DE0", VA = "0x1826F7DE0")]
	public void JCONOFHFIBJ(bool MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x26F8B20", Offset = "0x26F7B20", VA = "0x1826F8B20")]
	public void OFHKCFOCLDG(float MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x26F8800", Offset = "0x26F7800", VA = "0x1826F8800")]
	public void NPFPHCLAJGB(double MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x26F8750", Offset = "0x26F7750", VA = "0x1826F8750")]
	public void NCDDDCJCECL(byte MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x26F8060", Offset = "0x26F7060", VA = "0x1826F8060")]
	public void JOOHNHNCIJK(ushort MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x26F8030", Offset = "0x26F7030", VA = "0x1826F8030")]
	public void JFGBMEPAIAH(uint MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x26F7BE0", Offset = "0x26F6BE0", VA = "0x1826F7BE0")]
	public void CBMIBDNIBLD(ulong MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x26F81C0", Offset = "0x26F71C0", VA = "0x1826F81C0")]
	public void KBLONKMNNOF(sbyte MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x26F85C0", Offset = "0x26F75C0", VA = "0x1826F85C0")]
	public void KHCBDPHNLAI(short MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x26F8780", Offset = "0x26F7780", VA = "0x1826F8780")]
	public void NDOOAKJIMOB(int MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x26F8720", Offset = "0x26F7720", VA = "0x1826F8720")]
	public void NBPJKGDINEF(long MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x26F81F0", Offset = "0x26F71F0", VA = "0x1826F81F0")]
	public void KFJGBLCFDBD(string MFBIHMKFNKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LBLIMMJIFHA : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class GLIMPLAKAHP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3936410", Offset = "0x3935410", VA = "0x183936410")]
		static GLIMPLAKAHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private LBLIMMJIFHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class ANHFFHCNDFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> HBNOLBHDFGJ;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x26F9EC0", Offset = "0x26F8EC0", VA = "0x1826F9EC0")]
	static ANHFFHCNDFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x26F9960", Offset = "0x26F8960", VA = "0x1826F9960")]
	internal static object HEFFENOJKIB(Type AHIMPPGEGDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EBDBMKCGEBM : global::GNGMIEPFFIJ<Vector2>, OHDNNHIHLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DHBJPFKPEEN LLECHOFGCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] EMLPOBCHOBN;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x26FED40", Offset = "0x26FDD40", VA = "0x1826FED40")]
	public EBDBMKCGEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x26FEBD0", Offset = "0x26FDBD0", VA = "0x1826FEBD0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Vector2 MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x26FE9E0", Offset = "0x26FD9E0", VA = "0x1826FE9E0", Slot = "5")]
	public Vector2 GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class EDGOMKKOGDK : global::GNGMIEPFFIJ<Vector3>, OHDNNHIHLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly DHBJPFKPEEN LLECHOFGCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] EMLPOBCHOBN;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x26FF3A0", Offset = "0x26FE3A0", VA = "0x1826FF3A0")]
	public EDGOMKKOGDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x26FF190", Offset = "0x26FE190", VA = "0x1826FF190", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Vector3 MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x26FEF50", Offset = "0x26FDF50", VA = "0x1826FEF50", Slot = "5")]
	public Vector3 GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FOFKEPCFLKH : global::GNGMIEPFFIJ<Vector4>, OHDNNHIHLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly DHBJPFKPEEN LLECHOFGCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] EMLPOBCHOBN;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x27052F0", Offset = "0x27042F0", VA = "0x1827052F0")]
	public FOFKEPCFLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x26FD150", Offset = "0x26FC150", VA = "0x1826FD150", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Vector4 MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2705060", Offset = "0x2704060", VA = "0x182705060", Slot = "5")]
	public Vector4 GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class CPJJJAJCCGO : global::GNGMIEPFFIJ<Quaternion>, OHDNNHIHLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly DHBJPFKPEEN LLECHOFGCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] EMLPOBCHOBN;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x26FD3C0", Offset = "0x26FC3C0", VA = "0x1826FD3C0")]
	public CPJJJAJCCGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x26FD150", Offset = "0x26FC150", VA = "0x1826FD150", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Quaternion MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x26FCEC0", Offset = "0x26FBEC0", VA = "0x1826FCEC0", Slot = "5")]
	public Quaternion GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class LIIIMNCJKMB : global::GNGMIEPFFIJ<Color>, OHDNNHIHLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly DHBJPFKPEEN LLECHOFGCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] EMLPOBCHOBN;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2F9B530", Offset = "0x2F9A530", VA = "0x182F9B530")]
	public LIIIMNCJKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2F9B3E0", Offset = "0x2F9A3E0", VA = "0x182F9B3E0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Color MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2F9B1B0", Offset = "0x2F9A1B0", VA = "0x182F9B1B0", Slot = "5")]
	public Color GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class HIMBCJMHFAL : global::GNGMIEPFFIJ<Bounds>, OHDNNHIHLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly DHBJPFKPEEN LLECHOFGCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] EMLPOBCHOBN;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x270A250", Offset = "0x2709250", VA = "0x18270A250")]
	public HIMBCJMHFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2709F50", Offset = "0x2708F50", VA = "0x182709F50", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Bounds MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2709C50", Offset = "0x2708C50", VA = "0x182709C50", Slot = "5")]
	public Bounds GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class KNFFNCELKBA : global::GNGMIEPFFIJ<Rect>, OHDNNHIHLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly DHBJPFKPEEN LLECHOFGCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] EMLPOBCHOBN;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2F978B0", Offset = "0x2F968B0", VA = "0x182F978B0")]
	public KNFFNCELKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2F97740", Offset = "0x2F96740", VA = "0x182F97740", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Rect MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2F974E0", Offset = "0x2F964E0", VA = "0x182F974E0", Slot = "5")]
	public Rect GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class HLBHJIGLFHH : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class OFMOJCBFIBP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x319FDB0", Offset = "0x319EDB0", VA = "0x18319FDB0")]
		static OFMOJCBFIBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private HLBHJIGLFHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class CMGPPKNAJFO : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class PPJHJCKNADI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1D98600", Offset = "0x1D97600", VA = "0x181D98600")]
		static PPJHJCKNADI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class MODOIBPOEAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> BGGJNDPNGFJ;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x270EFB0", Offset = "0x270DFB0", VA = "0x18270EFB0")]
		internal static object HEFFENOJKIB(Type AHIMPPGEGDB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private CMGPPKNAJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class FGDFLGPIDBL : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class BMDFEICBMMF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3026B60", Offset = "0x3025B60", VA = "0x183026B60")]
		static BMDFEICBMMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly FGDFLGPIDBL GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool AHPEDCONNGG;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static OHDNNHIHLFA[] OIMDJOAKBOK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static CDLCJJDIPKK[] OGFLOHJOBAM;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private FGDFLGPIDBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2703F30", Offset = "0x2702F30", VA = "0x182703F30")]
	public static void EPCONIMEHBH(params CDLCJJDIPKK[] OGFLOHJOBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2703FF0", Offset = "0x2702FF0", VA = "0x182703FF0")]
	public static void EPCONIMEHBH(params OHDNNHIHLFA[] OIMDJOAKBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x27040B0", Offset = "0x27030B0", VA = "0x1827040B0")]
	public static void JEGPGCEMJPE(OHDNNHIHLFA[] OIMDJOAKBOK, CDLCJJDIPKK[] OGFLOHJOBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class NFEMCLHEBMB : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class IGDAKOMCCBA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x369A620", Offset = "0x3699620", VA = "0x18369A620")]
		static IGDAKOMCCBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private NFEMCLHEBMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class AACDHHPDFOC
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly CDLCJJDIPKK BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly CDLCJJDIPKK OAMEJEPKMIA;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly CDLCJJDIPKK CHAOFFPJMPH;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly CDLCJJDIPKK NHNKHKBICKD;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly CDLCJJDIPKK BAGEPNPMPNF;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly CDLCJJDIPKK MMBGMBPIJGP;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly CDLCJJDIPKK JDOANDHCDHD;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly CDLCJJDIPKK HEGCBJJNMMO;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly CDLCJJDIPKK EGEBEJFLGEG;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly CDLCJJDIPKK KMLNADEJHLP;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly CDLCJJDIPKK DIEFOELAGGL;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly CDLCJJDIPKK GNOLMMKJADH;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class PJPJLACAHPC
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly CDLCJJDIPKK BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly CDLCJJDIPKK NKNHMGGJPFJ;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class JJMEAMKDGPF
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly CDLCJJDIPKK BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly CDLCJJDIPKK OAMEJEPKMIA;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly CDLCJJDIPKK CHAOFFPJMPH;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly CDLCJJDIPKK NHNKHKBICKD;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly CDLCJJDIPKK BAGEPNPMPNF;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly CDLCJJDIPKK MMBGMBPIJGP;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly CDLCJJDIPKK JDOANDHCDHD;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly CDLCJJDIPKK HEGCBJJNMMO;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly CDLCJJDIPKK EGEBEJFLGEG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly CDLCJJDIPKK KMLNADEJHLP;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly CDLCJJDIPKK DIEFOELAGGL;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly CDLCJJDIPKK GNOLMMKJADH;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class IBEKIOEJLBA
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> BGGJNDPNGFJ;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x270AE80", Offset = "0x2709E80", VA = "0x18270AE80")]
	internal static object HEFFENOJKIB(Type AHIMPPGEGDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x270AE40", Offset = "0x2709E40", VA = "0x18270AE40")]
	private static object HAHCJBGAKJD(Type DPJKFIPFOEJ, Type[] IBMGHKOJKLA, params object[] MADLOPIJDCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class BKBJLDMFGAF : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class JEGBMGKFELO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x33F8580", Offset = "0x33F7580", VA = "0x1833F8580")]
		static JEGBMGKFELO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> LGGIIMDPDDL;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool MNNFBCODFJI;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly MCLELMOPFOG INCBBDEOLFN;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x26FB620", Offset = "0x26FA620", VA = "0x1826FB620")]
	static BKBJLDMFGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private BKBJLDMFGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class ADAGFHMDMKD : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class NELKAPIJHOL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x18EF510", Offset = "0x18EE510", VA = "0x1818EF510")]
		static NELKAPIJHOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> LGGIIMDPDDL;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool MNNFBCODFJI;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly MCLELMOPFOG INCBBDEOLFN;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x26F8D60", Offset = "0x26F7D60", VA = "0x1826F8D60")]
	static ADAGFHMDMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private ADAGFHMDMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class OFADMBMAJDF : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class EJIFEOGLGFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3B926F0", Offset = "0x3B916F0", VA = "0x183B926F0")]
		static EJIFEOGLGFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> LGGIIMDPDDL;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool MNNFBCODFJI;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly MCLELMOPFOG INCBBDEOLFN;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4B3F070", Offset = "0x4B3E070", VA = "0x184B3F070")]
	static OFADMBMAJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private OFADMBMAJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class AEJCHFPPCDJ : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class MONLMGNIMAO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x18E42C0", Offset = "0x18E32C0", VA = "0x1818E42C0")]
		static MONLMGNIMAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> LGGIIMDPDDL;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool MNNFBCODFJI;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly MCLELMOPFOG INCBBDEOLFN;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x26F8E50", Offset = "0x26F7E50", VA = "0x1826F8E50")]
	static AEJCHFPPCDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private AEJCHFPPCDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class HLNHHAIHFHJ : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class ANKNGIBGFKO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x318CF20", Offset = "0x318BF20", VA = "0x18318CF20")]
		static ANKNGIBGFKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> LGGIIMDPDDL;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool MNNFBCODFJI;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly MCLELMOPFOG INCBBDEOLFN;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x270A690", Offset = "0x2709690", VA = "0x18270A690")]
	static HLNHHAIHFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private HLNHHAIHFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class COJCBINPGFJ : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class OPHLPABELBG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1D86A30", Offset = "0x1D85A30", VA = "0x181D86A30")]
		static OPHLPABELBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> LGGIIMDPDDL;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool MNNFBCODFJI;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly MCLELMOPFOG INCBBDEOLFN;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x26FCB20", Offset = "0x26FBB20", VA = "0x1826FCB20")]
	static COJCBINPGFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private COJCBINPGFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class GNEHOLJAJMI : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class GOMOBMFFMBF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A79930", Offset = "0x2A78930", VA = "0x182A79930")]
		static GOMOBMFFMBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> LGGIIMDPDDL;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool MNNFBCODFJI;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public GNEHOLJAJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class EGGCOIJNHDI : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class CADEMFGCPJD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3DBCE40", Offset = "0x3DBBE40", VA = "0x183DBCE40")]
		static CADEMFGCPJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> LGGIIMDPDDL;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool MNNFBCODFJI;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public EGGCOIJNHDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class MGDAGAEAPGK : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class DOLBCFDJHNI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x37005D0", Offset = "0x36FF5D0", VA = "0x1837005D0")]
		static DOLBCFDJHNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> LGGIIMDPDDL;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool MNNFBCODFJI;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public MGDAGAEAPGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class FBBKAKMOAMI : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class LFGBDDBHOPJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x39737B0", Offset = "0x39727B0", VA = "0x1839737B0")]
		static LFGBDDBHOPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> LGGIIMDPDDL;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool MNNFBCODFJI;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public FBBKAKMOAMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class ABEGBNOGELJ : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class KGKNLFEGKPC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x18E0440", Offset = "0x18DF440", VA = "0x1818E0440")]
		static KGKNLFEGKPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> LGGIIMDPDDL;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool MNNFBCODFJI;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public ABEGBNOGELJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class BFJJAEMBFCI : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class LKEAGCOJHCF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x33F9920", Offset = "0x33F8920", VA = "0x1833F9920")]
		static LKEAGCOJHCF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> LGGIIMDPDDL;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool MNNFBCODFJI;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public BFJJAEMBFCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class KMCCMDPBOOM
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct HAHPEHIBKLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public GNFHJFKEAIP JMKDKNBPGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder AKMHALFNJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder FKGHLECLBKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class KOEMFFGPNMI
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class KMKEKGLCDGM
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo KAMIPDHKGMC;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo OBHPNOBENBP;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo OELIGPMOFNO;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo MEIBHGMOOOA;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo CBFGJPAIBNO;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo JEBBKEDNIDB;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo CNPCGDHOGFE;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo NIFFEIFNODL;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo DDCPAOOPLLL;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2F967A0", Offset = "0x2F957A0", VA = "0x182F967A0")]
			static KMKEKGLCDGM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class HOGDNKFMCJL
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo LJHFMNIBGAB;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo EECIMJOJCKF;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo FKIAHOGJGAP;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo LEOBGLKDDEB;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo BICMNEAPABD;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo KMAEDEGKMFF;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo HICAHIDNFFC;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2F86720", Offset = "0x2F85720", VA = "0x182F86720")]
			static HOGDNKFMCJL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class IBAKCGLAHFI
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo EDEHPENDFJC;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo ECHILMPMJAH;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo KGNKEDIGCDJ;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo LMKHMGBPDFD;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo JLGPJHHAJHO;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo FNOHEAMGANE;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo JHAOFNGLHEK;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo LNNABGEAGNL;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo GEEHNKBPGIA;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo AFIJKNMCEPB;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo ICJAKFKIMNP;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo DNABJJCJLNE;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo AOLKMIFHELH;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo GOBLFLBBFEL;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2F98030", Offset = "0x2F97030", VA = "0x182F98030")]
		public static MethodInfo PBGNCPABBCO(Type DMBEFJIHONB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2F97CE0", Offset = "0x2F96CE0", VA = "0x182F97CE0")]
		public static MethodInfo GPGJANKJBGF(Type DMBEFJIHONB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2F97F10", Offset = "0x2F96F10", VA = "0x182F97F10")]
		public static MethodInfo NHCAOOPOAHF(Type DMBEFJIHONB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class CBGKMIHNOBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<GNFHJFKEAIP, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public CBGKMIHNOBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class GCAPCMGLFHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public CBGKMIHNOBC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public GCAPCMGLFHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2F86640", Offset = "0x2F85640", VA = "0x182F86640")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2F86680", Offset = "0x2F85680", VA = "0x182F86680")]
		internal bool <BuildType>b__2(int index, GNFHJFKEAIP member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class BGGHBOAFJMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public CBGKMIHNOBC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public BGGHBOAFJMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2F84580", Offset = "0x2F83580", VA = "0x182F84580")]
		internal bool <BuildType>b__3(int index, GNFHJFKEAIP member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class FDPOMGKAOOB
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

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public FDPOMGKAOOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2F84860", Offset = "0x2F83860", VA = "0x182F84860")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IMDEJMAEAGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public IMDEJMAEAGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2F888E0", Offset = "0x2F878E0", VA = "0x182F888E0")]
		internal bool <BuildAnonymousFormatter>b__2(GNFHJFKEAIP x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class AHNGKMAPHIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public FDPOMGKAOOB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public AHNGKMAPHIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2F840B0", Offset = "0x2F830B0", VA = "0x182F840B0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2F840C0", Offset = "0x2F830C0", VA = "0x182F840C0")]
		internal bool <BuildAnonymousFormatter>b__6(int index, GNFHJFKEAIP member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class PPAFLNOOMCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public FDPOMGKAOOB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public PPAFLNOOMCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C060", Offset = "0x2F9B060", VA = "0x182F9C060")]
		internal bool <BuildAnonymousFormatter>b__7(int index, GNFHJFKEAIP member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class PNELLENKDJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public PNELLENKDJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x16C6D30", Offset = "0x16C5D30", VA = "0x1816C6D30")]
		internal Label <BuildSerialize>b__1(GNFHJFKEAIP _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class IEPCIDHDNBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public HAHPEHIBKLJ[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, GNFHJFKEAIP, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public MKFOPICEBFL argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public MKFOPICEBFL argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public IEPCIDHDNBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2F877F0", Offset = "0x2F867F0", VA = "0x182F877F0")]
		internal HAHPEHIBKLJ <BuildDeserialize>b__0(GNFHJFKEAIP item)
		{
			return default(HAHPEHIBKLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class LLOAGOIMGJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public IEPCIDHDNBB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public LLOAGOIMGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2F9B820", Offset = "0x2F9A820", VA = "0x182F9B820")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2F9BAD0", Offset = "0x2F9AAD0", VA = "0x182F9BAD0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class CGBHGAEJECF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public GNFHJFKEAIP item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public CGBHGAEJECF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xE69630", Offset = "0xE68630", VA = "0x180E69630")]
		internal bool <EmitNewObject>b__0(HAHPEHIBKLJ x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class HDNBJMJGNMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GNFHJFKEAIP item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public HDNBJMJGNMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xE69630", Offset = "0xE68630", VA = "0x180E69630")]
		internal bool <EmitNewObject>b__2(HAHPEHIBKLJ x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex ABJDKDDDLHF;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int MPOHPBGKIPI;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> PFJKMIILDIH;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> CHBDIHGOMBG;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x293C690", Offset = "0x293B690", VA = "0x18293C690")]
	public static object FFGHFCGHJBO<T>(MCLELMOPFOG INCBBDEOLFN, CDLCJJDIPKK IHGGGGBNGPH, Func<string, string> LGGIIMDPDDL, bool MNNFBCODFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1FD00F0", Offset = "0x1FCF0F0", VA = "0x181FD00F0")]
	public static object NICKPNGGGLO<T>(CDLCJJDIPKK IHGGGGBNGPH, Func<string, string> LGGIIMDPDDL, bool MNNFBCODFJI, bool LCNEOEILONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2F957F0", Offset = "0x2F947F0", VA = "0x182F957F0")]
	private static TypeInfo ONJHNNJKCKH(MCLELMOPFOG INCBBDEOLFN, Type DMBEFJIHONB, Func<string, string> LGGIIMDPDDL, bool MNNFBCODFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2F93EB0", Offset = "0x2F92EB0", VA = "0x182F93EB0")]
	public static object MJJBPOGABLD(Type DMBEFJIHONB, Func<string, string> LGGIIMDPDDL, bool MNNFBCODFJI, bool LCNEOEILONM, bool KLBIDKBECOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2F92600", Offset = "0x2F91600", VA = "0x182F92600")]
	private static Dictionary<GNFHJFKEAIP, FieldInfo> MHPGMAPOKHN(TypeBuilder ELAHAPCPBJF, APDPMECNMFK KEKKEELMMKA, ConstructorInfo EMKPCNJLLFD, FieldBuilder JBNFOPMKCBG, ILGenerator MMABJADPAFA, bool MNNFBCODFJI, bool HNJOBIAMMDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2F90940", Offset = "0x2F8F940", VA = "0x182F90940")]
	private static Dictionary<GNFHJFKEAIP, FieldInfo> JABDKKACKAC(TypeBuilder ELAHAPCPBJF, APDPMECNMFK KEKKEELMMKA, ILGenerator MMABJADPAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2F910A0", Offset = "0x2F900A0", VA = "0x182F910A0")]
	private static void MFCBLLHDOBF(Type DMBEFJIHONB, APDPMECNMFK KEKKEELMMKA, ILGenerator MMABJADPAFA, Action GHHAKODKFFO, Func<int, GNFHJFKEAIP, bool> APMBCLALOAP, bool MNNFBCODFJI, bool HNJOBIAMMDH, int FEBIGEJIHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2F8ED00", Offset = "0x2F8DD00", VA = "0x182F8ED00")]
	private static void CCMBJPHLALJ(TypeInfo DMBEFJIHONB, GNFHJFKEAIP EBNJHOEANPC, ILGenerator MMABJADPAFA, int CFANIPEBCPB, Func<int, GNFHJFKEAIP, bool> APMBCLALOAP, MKFOPICEBFL EEDEJPBOCJL, MKFOPICEBFL LOOLBOIEBPN, MKFOPICEBFL HKPOPGCFJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2F92C50", Offset = "0x2F91C50", VA = "0x182F92C50")]
	private static void MJAFDPBHGGB(Type DMBEFJIHONB, APDPMECNMFK KEKKEELMMKA, ILGenerator MMABJADPAFA, Func<int, GNFHJFKEAIP, bool> APMBCLALOAP, bool JGJNAJFHALG, int FEBIGEJIHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2F8F8C0", Offset = "0x2F8E8C0", VA = "0x182F8F8C0")]
	private static void DJOBJHAPJCJ(ILGenerator MMABJADPAFA, HAHPEHIBKLJ KEKKEELMMKA, int CFANIPEBCPB, Func<int, GNFHJFKEAIP, bool> APMBCLALOAP, MKFOPICEBFL OFLJDNJJLOF, MKFOPICEBFL HKPOPGCFJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2F8FCD0", Offset = "0x2F8ECD0", VA = "0x182F8FCD0")]
	private static LocalBuilder HAIJBNHPIIP(ILGenerator MMABJADPAFA, Type DMBEFJIHONB, APDPMECNMFK KEKKEELMMKA, HAHPEHIBKLJ[] OKHFNLCAHJL, bool AFAJEDLLFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2F8F1F0", Offset = "0x2F8E1F0", VA = "0x182F8F1F0")]
	private static bool CHDJDMEBNPM(ConstructorInfo HPBBOIBDMEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2F90F00", Offset = "0x2F8FF00", VA = "0x182F90F00")]
	private static bool JKPIIEIMFMJ(Type DMBEFJIHONB, out Type PIBODHMMONA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void KCDKIFKBAGC<T>(byte[][] JBNFOPMKCBG, object[] FIAPBABDFBB, ref AAEIOLMBBFI EEDEJPBOCJL, T MFBIHMKFNKA, CDLCJJDIPKK NAFMEEIPPLF);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T IBFFIBEEHJF<T>(object[] FIAPBABDFBB, ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NAFMEEIPPLF);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class JMAEEGNPPPL<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class IJBMMHJEBDN : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class AJCDFGMFJPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x16EC440", Offset = "0x16EB440", VA = "0x1816EC440")]
		static AJCDFGMFJPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private IJBMMHJEBDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class CLMNKKMLHBO : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class OMJPEKHADNN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1D809A0", Offset = "0x1D7F9A0", VA = "0x181D809A0")]
		static OMJPEKHADNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private CLMNKKMLHBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class FCNGFOJJLCA
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly CDLCJJDIPKK[] DLHLLBEJFOJ;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class LPEJHAMAEHJ : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class KFHGEIKOAPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3707C00", Offset = "0x3706C00", VA = "0x183707C00")]
		static KFHGEIKOAPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class JEIODKPHKLD : CDLCJJDIPKK
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class GIEEFHAODCF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x37022E0", Offset = "0x37012E0", VA = "0x1837022E0")]
			static GIEEFHAODCF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		private JEIODKPHKLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
		public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::GNGMIEPFFIJ<object> BNCEPCHCGBI;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private LPEJHAMAEHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class INDCIBLKMOM : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class FBJJEDHEMNF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x16F5E40", Offset = "0x16F4E40", VA = "0x1816F5E40")]
		static FBJJEDHEMNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class OBKGDNDNKEL : CDLCJJDIPKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class KDBPOKHPEBC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x330FFF0", Offset = "0x330EFF0", VA = "0x18330FFF0")]
			static KDBPOKHPEBC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		private OBKGDNDNKEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
		public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::GNGMIEPFFIJ<object> BNCEPCHCGBI;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private INDCIBLKMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class KOCPLNMDMKP : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class MDAOKAMHBKO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3943920", Offset = "0x3942920", VA = "0x183943920")]
		static MDAOKAMHBKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class HPNCAMICEGJ : CDLCJJDIPKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class LIEHPJJBOFB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x393C6C0", Offset = "0x393B6C0", VA = "0x18393C6C0")]
			static LIEHPJJBOFB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		private HPNCAMICEGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
		public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::GNGMIEPFFIJ<object> BNCEPCHCGBI;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private KOCPLNMDMKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class CPNNANFDHJB : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class HNJECLCPLIJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x1D79230", Offset = "0x1D78230", VA = "0x181D79230")]
		static HNJECLCPLIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class FKGNAIBBBDI : CDLCJJDIPKK
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class HCNFPOLOECJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x1D75480", Offset = "0x1D74480", VA = "0x181D75480")]
			static HCNFPOLOECJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		private FKGNAIBBBDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
		public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::GNGMIEPFFIJ<object> BNCEPCHCGBI;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private CPNNANFDHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class EOKJIFNHEEM : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class KKOKBHJMMLL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x343B200", Offset = "0x343A200", VA = "0x18343B200")]
		static KKOKBHJMMLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class JLPCIKOBCNC : CDLCJJDIPKK
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class PDFDDLLNAFE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3445810", Offset = "0x3444810", VA = "0x183445810")]
			static PDFDDLLNAFE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		private JLPCIKOBCNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
		public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::GNGMIEPFFIJ<object> BNCEPCHCGBI;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private EOKJIFNHEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class BMEBEAMDGNI : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class BPALBFCNOFF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x30833D0", Offset = "0x30823D0", VA = "0x1830833D0")]
		static BPALBFCNOFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class HEANNPPLAOH : CDLCJJDIPKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class KKDKLPMHFOD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3091010", Offset = "0x3090010", VA = "0x183091010")]
			static KKDKLPMHFOD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		private HEANNPPLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
		public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::GNGMIEPFFIJ<object> BNCEPCHCGBI;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private BMEBEAMDGNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class OHCGEKFHPMO : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class BCMBAKNCDFG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3B86970", Offset = "0x3B85970", VA = "0x183B86970")]
		static BCMBAKNCDFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class OFGBAFKAFKD : CDLCJJDIPKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class GDAMDLFOGJL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3B95210", Offset = "0x3B94210", VA = "0x183B95210")]
			static GDAMDLFOGJL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		private OFGBAFKAFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
		public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::GNGMIEPFFIJ<object> BNCEPCHCGBI;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private OHCGEKFHPMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class HICGJIFEAMG : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class CHHDLEGJKLE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3343710", Offset = "0x3342710", VA = "0x183343710")]
		static CHHDLEGJKLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class FGMIKJGPHME : CDLCJJDIPKK
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class EGDNNJFIMFE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3349B40", Offset = "0x3348B40", VA = "0x183349B40")]
			static EGDNNJFIMFE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		private FGMIKJGPHME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
		public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::GNGMIEPFFIJ<object> BNCEPCHCGBI;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private HICGJIFEAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class PEOMJOFGAIL : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class ENKFOADEPFO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x31FA120", Offset = "0x31F9120", VA = "0x1831FA120")]
		static ENKFOADEPFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class MHCLAMNBLIJ : CDLCJJDIPKK
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class IFJLEFENBBL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x31FE100", Offset = "0x31FD100", VA = "0x1831FE100")]
			static IFJLEFENBBL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		private MHCLAMNBLIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
		public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::GNGMIEPFFIJ<object> BNCEPCHCGBI;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private PEOMJOFGAIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class GGDOKIIHGNB : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class POMDLEEONHA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2301B30", Offset = "0x2300B30", VA = "0x182301B30")]
		static POMDLEEONHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class DAFDEBHMKPI : CDLCJJDIPKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class FANJOKFJAAN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x22EDC40", Offset = "0x22ECC40", VA = "0x1822EDC40")]
			static FANJOKFJAAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		private DAFDEBHMKPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
		public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::GNGMIEPFFIJ<object> BNCEPCHCGBI;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private GGDOKIIHGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class NMDEKPCHDOD : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class CCGGFPHGPKG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3697E70", Offset = "0x3696E70", VA = "0x183697E70")]
		static CCGGFPHGPKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class EPAACPMFBDO : CDLCJJDIPKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class MPDAIMFIEJC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x369D810", Offset = "0x369C810", VA = "0x18369D810")]
			static MPDAIMFIEJC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		private EPAACPMFBDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
		public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::GNGMIEPFFIJ<object> BNCEPCHCGBI;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private NMDEKPCHDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class JJOOAFEEODH : CDLCJJDIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class FABNHAKHMAE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x25E2F30", Offset = "0x25E1F30", VA = "0x1825E2F30")]
		static FABNHAKHMAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class OELBAEMIOKN : CDLCJJDIPKK
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class GMJOMKFAIKH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::GNGMIEPFFIJ<T> ALMLEHDGHCB;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x25E9770", Offset = "0x25E8770", VA = "0x1825E9770")]
			static GMJOMKFAIKH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		private OELBAEMIOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
		public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::GNGMIEPFFIJ<object> BNCEPCHCGBI;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	private JJOOAFEEODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x17321B0", Offset = "0x17311B0", VA = "0x1817321B0", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct KEOFDOOIBKE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] PKOGPCJPCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int NBHCNACMKMB;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2B8EEA0", Offset = "0x2B8DEA0", VA = "0x182B8EEA0")]
	public KEOFDOOIBKE(int OCFGLOFAKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2B8ED00", Offset = "0x2B8DD00", VA = "0x182B8ED00")]
	public void IONNJMGFDPB(T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2B8EB90", Offset = "0x2B8DB90", VA = "0x182B8EB90")]
	public T[] CINJAKHIFFF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class KKIPLKAHKMK : global::IDHAGBFMGDG<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly KKIPLKAHKMK BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2F8ECB0", Offset = "0x2F8DCB0", VA = "0x182F8ECB0")]
	public KKIPLKAHKMK(int GOANLIHDLBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class IDHAGBFMGDG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int GOANLIHDLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object EAEKEHBGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int CFANIPEBCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] ALOGMKNCMBB;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x319B6B0", Offset = "0x319A6B0", VA = "0x18319B6B0")]
	public IDHAGBFMGDG(int GOANLIHDLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x319B230", Offset = "0x319A230", VA = "0x18319B230")]
	public T[] PJHMIFEODLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x319AE70", Offset = "0x3199E70", VA = "0x18319AE70")]
	public void FENBDDDBPJB(T[] ECGFLNEOIIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class DHBJPFKPEEN : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class LNPEBJFKPBD : IComparable<LNPEBJFKPBD>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class GDNAMIJCFCD : IEnumerable<LNPEBJFKPBD>, IEnumerable, IEnumerator<LNPEBJFKPBD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private LNPEBJFKPBD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public LNPEBJFKPBD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private LNPEBJFKPBD System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x5EB910", Offset = "0x5EA910", VA = "0x1805EB910")]
			[DebuggerHidden]
			public GDNAMIJCFCD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x2705E90", Offset = "0x2704E90", VA = "0x182705E90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2705FC0", Offset = "0x2704FC0", VA = "0x182705FC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2705F20", Offset = "0x2704F20", VA = "0x182705F20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<LNPEBJFKPBD> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2705F20", Offset = "0x2704F20", VA = "0x182705F20", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class DIGKDJJBLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
			public DIGKDJJBLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x16C6D30", Offset = "0x16C5D30", VA = "0x1816C6D30")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x16C6D30", Offset = "0x16C5D30", VA = "0x1816C6D30")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly LNPEBJFKPBD[] KBOKKEPFPBE;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] IDDJMPOMEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong LOKNCHMIENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int CIFMBHMEFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string KJCNIJANGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private LNPEBJFKPBD[] NAIOIGLPEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] LILLJAICBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int KLPGLGDELCK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool AEEPNJCKJMD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x270D180", Offset = "0x270C180", VA = "0x18270D180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x270E300", Offset = "0x270D300", VA = "0x18270E300")]
		public LNPEBJFKPBD(ulong BJKKIOODGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x270D300", Offset = "0x270C300", VA = "0x18270D300")]
		public LNPEBJFKPBD IONNJMGFDPB(ulong BJKKIOODGOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x270D2B0", Offset = "0x270C2B0", VA = "0x18270D2B0")]
		public LNPEBJFKPBD IONNJMGFDPB(ulong BJKKIOODGOA, int MFBIHMKFNKA, string KJCNIJANGOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x270E0D0", Offset = "0x270D0D0", VA = "0x18270E0D0")]
		public LNPEBJFKPBD POLALCFNEIA(byte[] PAEJAEBLJPP, ref int JNMGKKFIPGA, ref int GCLIOHFGHHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x270D230", Offset = "0x270C230", VA = "0x18270D230")]
		internal static int GMLGEIJHLMD(ulong[] ECGFLNEOIIM, int CFANIPEBCPB, int GFKNIIIDANB, ulong MFBIHMKFNKA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x270D190", Offset = "0x270C190", VA = "0x18270D190", Slot = "4")]
		public int CompareTo(LNPEBJFKPBD GKBKHIIEFAH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x270D1C0", Offset = "0x270C1C0", VA = "0x18270D1C0")]
		[IteratorStateMachine(typeof(GDNAMIJCFCD))]
		public IEnumerable<LNPEBJFKPBD> GLAEGPMBOLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x270D050", Offset = "0x270C050", VA = "0x18270D050")]
		public void AAMFLAJDGLG(ILGenerator MMABJADPAFA, LocalBuilder PAEJAEBLJPP, LocalBuilder GCLIOHFGHHG, LocalBuilder BJKKIOODGOA, Action<KeyValuePair<string, int>> BMKFNKCDPAH, Action FOMBGGNGGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x270D4F0", Offset = "0x270C4F0", VA = "0x18270D4F0")]
		private static void JFHOAIFBOGD(ILGenerator MMABJADPAFA, LocalBuilder PAEJAEBLJPP, LocalBuilder GCLIOHFGHHG, LocalBuilder BJKKIOODGOA, Action<KeyValuePair<string, int>> BMKFNKCDPAH, Action FOMBGGNGGCG, LNPEBJFKPBD[] NAIOIGLPEFC, int KLPGLGDELCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class FLFOJIFHFNB : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private IEnumerable<LNPEBJFKPBD> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<LNPEBJFKPBD> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<LNPEBJFKPBD> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private LNPEBJFKPBD <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x8AAB20", Offset = "0x8A9B20", VA = "0x1808AAB20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2704E70", Offset = "0x2703E70", VA = "0x182704E70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x200B7C0", Offset = "0x200A7C0", VA = "0x18200B7C0")]
		[DebuggerHidden]
		public FLFOJIFHFNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2704EC0", Offset = "0x2703EC0", VA = "0x182704EC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2704A00", Offset = "0x2703A00", VA = "0x182704A00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2704FC0", Offset = "0x2703FC0", VA = "0x182704FC0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2705010", Offset = "0x2704010", VA = "0x182705010")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2704E20", Offset = "0x2703E20", VA = "0x182704E20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2704D80", Offset = "0x2703D80", VA = "0x182704D80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2704D80", Offset = "0x2703D80", VA = "0x182704D80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly LNPEBJFKPBD FFGCFPCOLFD;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x26FE530", Offset = "0x26FD530", VA = "0x1826FE530")]
	public DHBJPFKPEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x26FE320", Offset = "0x26FD320", VA = "0x1826FE320")]
	public void IONNJMGFDPB(byte[] JNPIAJHKCKB, int MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x26FE0D0", Offset = "0x26FD0D0", VA = "0x1826FE0D0")]
	public bool DLAEEKDJJEA(ArraySegment<byte> BJKKIOODGOA, out int MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x26FE440", Offset = "0x26FD440", VA = "0x1826FE440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x26FDE50", Offset = "0x26FCE50", VA = "0x1826FDE50")]
	private static void AAICFCFOMOD(IEnumerable<LNPEBJFKPBD> NAIOIGLPEFC, StringBuilder OHIGLHDFMBF, int LOOFANMHKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x26FE1F0", Offset = "0x26FD1F0", VA = "0x1826FE1F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x26FE1F0", Offset = "0x26FD1F0", VA = "0x1826FE1F0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x26FE180", Offset = "0x26FD180", VA = "0x1826FE180")]
	[IteratorStateMachine(typeof(FLFOJIFHFNB))]
	private static IEnumerable<KeyValuePair<string, int>> DNCHJCPCJIA(IEnumerable<LNPEBJFKPBD> NAIOIGLPEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x26FE2F0", Offset = "0x26FD2F0", VA = "0x1826FE2F0")]
	public void HIBMPEKPBBN(ILGenerator MMABJADPAFA, LocalBuilder PAEJAEBLJPP, LocalBuilder GCLIOHFGHHG, LocalBuilder BJKKIOODGOA, Action<KeyValuePair<string, int>> BMKFNKCDPAH, Action FOMBGGNGGCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class OCGFOLNHJIP
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo GNJJEFCEPGK;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4B3B3B0", Offset = "0x4B3A3B0", VA = "0x184B3B3B0")]
	public static ulong OGHGFABPFFK(byte[] JNPIAJHKCKB, ref int JNMGKKFIPGA, ref int GCLIOHFGHHG)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class IGPJJODJGMD
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2F87C40", Offset = "0x2F86C40", VA = "0x182F87C40")]
	public static void OCMKAFFOPBE(ref byte[] JNPIAJHKCKB, int JNMGKKFIPGA, int AFOPANCEIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2F87B50", Offset = "0x2F86B50", VA = "0x182F87B50")]
	public static void MLMGPJPKAHF(ref byte[] ECGFLNEOIIM, int MPAHBNHIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2F87A60", Offset = "0x2F86A60", VA = "0x182F87A60")]
	public static byte[] ADNCCGDNDOC(byte[] BEGAEBENGJM, int MPAHBNHIEDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class KHMPFADKCGB
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E940", Offset = "0x2F8D940", VA = "0x182F8E940")]
	public static bool HHFANCOAJID(byte[] PDEFLFJGIBK, int BBCCHJEGENP, int DEPAMPLJICA, byte[] LOHAFFMEIOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class LGPELLCOFBG<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct BAAOPFODPCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] LOKNCHMIENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T CIFMBHMEFPE;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x241ADA0", Offset = "0x2419DA0", VA = "0x18241ADA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class HHFCAMCIICC : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::LGPELLCOFBG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private BAAOPFODPCJ[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private BAAOPFODPCJ[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xB8FF70", Offset = "0xB8EF70", VA = "0x180B8FF70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x2420BC0", Offset = "0x241FBC0", VA = "0x182420BC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x140D1A0", Offset = "0x140C1A0", VA = "0x18140D1A0")]
		[DebuggerHidden]
		public HHFCAMCIICC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2420600", Offset = "0x241F600", VA = "0x182420600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x2420B70", Offset = "0x241FB70", VA = "0x182420B70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly BAAOPFODPCJ[][] JBINHHOCDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong BBNELEHCIHP;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1E54D30", Offset = "0x1E53D30", VA = "0x181E54D30")]
	public LGPELLCOFBG(int FFHMMNBBJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x1E54C70", Offset = "0x1E53C70", VA = "0x181E54C70")]
	public LGPELLCOFBG(int FFHMMNBBJIL, float AHOCKGAHBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3C6BAA0", Offset = "0x3C6AAA0", VA = "0x183C6BAA0")]
	public void IONNJMGFDPB(byte[] BJKKIOODGOA, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3C723E0", Offset = "0x3C713E0", VA = "0x183C723E0")]
	private bool OIFEDAJLAHN(byte[] BJKKIOODGOA, T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F080", Offset = "0x3C6E080", VA = "0x183C6F080")]
	public bool OADACMKKJNG(ArraySegment<byte> BJKKIOODGOA, out T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x1E53A50", Offset = "0x1E52A50", VA = "0x181E53A50")]
	private static ulong HCOHDDHNEHP(byte[] FMMKCBAOFKA, int JNMGKKFIPGA, int KLPGLGDELCK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1E53900", Offset = "0x1E52900", VA = "0x181E53900")]
	private static int GDENMFBNIBC(int JCHCKAOMCHB, float AHOCKGAHBHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x1E53930", Offset = "0x1E52930", VA = "0x181E53930", Slot = "4")]
	[IteratorStateMachine(typeof(global::LGPELLCOFBG<>.HHFCAMCIICC))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x15947F0", Offset = "0x15937F0", VA = "0x1815947F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class GCJPILNOKID : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] ABOAMIAMKHA;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] BCPDDCCGFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int LKLOILNPJJN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool HDIKBMPOKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2705B70", Offset = "0x2704B70", VA = "0x182705B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2705BC0", Offset = "0x2704BC0", VA = "0x182705BC0")]
	static GCJPILNOKID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2705E10", Offset = "0x2704E10", VA = "0x182705E10")]
	public GCJPILNOKID(byte[] DPHCNLPCHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2705A60", Offset = "0x2704A60", VA = "0x182705A60")]
	public OpCode JBFGCPAAOFJ()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct INHEOMODOBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid CIFMBHMEFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte JJEKOPMMAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte KFNONCKHLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte GIMENIOMFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte IFPCAGPDOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte ICODNEGNBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte FKCBOFACAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte BIDNCHALDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte JCHOHEEECMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte CNCLFALLCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte ILNMDJDPCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte OINPIOKFOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte CMPFCFJHAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte AGMDCFLOAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte BMFFBDGNPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte IDNLFFIEGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte HODGEIJJIKL;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] DIGFHAODNAN;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] DIIFAFOJJEB;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2F8A6F0", Offset = "0x2F896F0", VA = "0x182F8A6F0")]
	public INHEOMODOBG(ref Guid MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2F8A040", Offset = "0x2F89040", VA = "0x182F8A040")]
	public INHEOMODOBG(ref ArraySegment<byte> PAHPEFKFKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2F88B90", Offset = "0x2F87B90", VA = "0x182F88B90")]
	private static byte GGICJCFAKDH(byte[] JNPIAJHKCKB, int OBODNIOAPNJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2F88A80", Offset = "0x2F87A80", VA = "0x182F88A80")]
	private static byte GGHBMMMDEHH(byte FMMAACMCILJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2F88C50", Offset = "0x2F87C50", VA = "0x182F88C50")]
	public void LIOKEBNFFOC(byte[] MGGGNBHMHDA, int JNMGKKFIPGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class MHNPGFGGHCA
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4B34650", Offset = "0x4B33650", VA = "0x184B34650")]
	public static bool IKPMKEBMOPM(byte MCODHPOGBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4B354A0", Offset = "0x4B344A0", VA = "0x184B354A0")]
	public static bool NDPMOOEAKBN(byte MCODHPOGBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4B34490", Offset = "0x4B33490", VA = "0x184B34490")]
	public static sbyte CIBCICNHDEP(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4B34660", Offset = "0x4B33660", VA = "0x184B34660")]
	public static short JFNBLPCFJNA(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4B34570", Offset = "0x4B33570", VA = "0x184B34570")]
	public static int IADEKJMJPCB(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x4B357D0", Offset = "0x4B347D0", VA = "0x184B357D0")]
	public static long PDNJOIHCIMK(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x4B345E0", Offset = "0x4B335E0", VA = "0x184B345E0")]
	public static byte ICIFIELEFNN(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x4B34500", Offset = "0x4B33500", VA = "0x184B34500")]
	public static ushort EOHFCNGBOBB(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4B346D0", Offset = "0x4B336D0", VA = "0x184B346D0")]
	public static uint KENAGGIFPAD(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4B34750", Offset = "0x4B33750", VA = "0x184B34750")]
	public static ulong LOHPENPIKBJ(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4B35510", Offset = "0x4B34510", VA = "0x184B35510")]
	public static float NMACLDDIGFF(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4B33C50", Offset = "0x4B32C50", VA = "0x184B33C50")]
	public static double BNFLDCEMKIP(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4B33CC0", Offset = "0x4B32CC0", VA = "0x184B33CC0")]
	public static int CBMIBDNIBLD(ref byte[] MGGGNBHMHDA, int JNMGKKFIPGA, ulong MFBIHMKFNKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4B34860", Offset = "0x4B33860", VA = "0x184B34860")]
	public static int NBPJKGDINEF(ref byte[] MGGGNBHMHDA, int JNMGKKFIPGA, long MFBIHMKFNKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4B35580", Offset = "0x4B34580", VA = "0x184B35580")]
	public static bool NMDHLIHHCGA(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class HMGLNIBOBOE
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class LDJFHFDNDIL : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5EB910", Offset = "0x5EA910", VA = "0x1805EB910")]
		[DebuggerHidden]
		public LDJFHFDNDIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x270CE90", Offset = "0x270BE90", VA = "0x18270CE90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x270CA30", Offset = "0x270BA30", VA = "0x18270CA30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x270CFB0", Offset = "0x270BFB0", VA = "0x18270CFB0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x270D000", Offset = "0x270C000", VA = "0x18270D000")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x270CE40", Offset = "0x270BE40", VA = "0x18270CE40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x270CD90", Offset = "0x270BD90", VA = "0x18270CD90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x270CD90", Offset = "0x270BD90", VA = "0x18270CD90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class MMALFKNKACO : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x5EB910", Offset = "0x5EA910", VA = "0x1805EB910")]
		[DebuggerHidden]
		public MMALFKNKACO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x270EDF0", Offset = "0x270DDF0", VA = "0x18270EDF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x270E990", Offset = "0x270D990", VA = "0x18270E990", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x270EF10", Offset = "0x270DF10", VA = "0x18270EF10")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x270EF60", Offset = "0x270DF60", VA = "0x18270EF60")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x270EDA0", Offset = "0x270DDA0", VA = "0x18270EDA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x270ECF0", Offset = "0x270DCF0", VA = "0x18270ECF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x270ECF0", Offset = "0x270DCF0", VA = "0x18270ECF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x270AA60", Offset = "0x2709A60", VA = "0x18270AA60")]
	public static bool OLFKHJCEENL(this TypeInfo DMBEFJIHONB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x270A900", Offset = "0x2709900", VA = "0x18270A900")]
	public static bool JFEMJFBKEMD(this TypeInfo DMBEFJIHONB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x270A810", Offset = "0x2709810", VA = "0x18270A810")]
	public static IEnumerable<PropertyInfo> FBMPPGLIDIL(this Type DMBEFJIHONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x270A780", Offset = "0x2709780", VA = "0x18270A780")]
	[IteratorStateMachine(typeof(LDJFHFDNDIL))]
	private static IEnumerable<PropertyInfo> AEAJNEAFMPF(Type DMBEFJIHONB, HashSet<string> FKNLEHPDNPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x270AA00", Offset = "0x2709A00", VA = "0x18270AA00")]
	public static IEnumerable<FieldInfo> OJCJCFGMBJM(this Type DMBEFJIHONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x270A870", Offset = "0x2709870", VA = "0x18270A870")]
	[IteratorStateMachine(typeof(MMALFKNKACO))]
	private static IEnumerable<FieldInfo> FNGNIEIKIIK(Type DMBEFJIHONB, HashSet<string> FKNLEHPDNPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class JJGDCPMMMGP
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding ONOIAGKHNFD;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class JBNIPMIFGNB
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x558B60", Offset = "0x557B60", VA = "0x180558B60")]
	public static string NMNJIADMLCO(string MGKAPLGAIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2F8A8D0", Offset = "0x2F898D0", VA = "0x182F8A8D0")]
	public static string PJCDOAKPCMB(string MGKAPLGAIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2F8A700", Offset = "0x2F89700", VA = "0x182F8A700")]
	public static string PENAPIBDNIB(string MGKAPLGAIOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class PDHEEJFMMNJ<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class PNIIEDABKBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type LOKNCHMIENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue CIFMBHMEFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int MHIHFDNIDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public PNIIEDABKBH BODDCIMCOJJ;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x320A8C0", Offset = "0x32098C0", VA = "0x18320A8C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x320A880", Offset = "0x3209880", VA = "0x18320A880")]
		private int GJEPFFENNCK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		public PNIIEDABKBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class DBIADGNNEGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		public DBIADGNNEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5614A0", Offset = "0x5604A0", VA = "0x1805614A0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private PNIIEDABKBH[] JBINHHOCDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int DDMFGCPNLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object DLGMNNDEJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float AHOCKGAHBHM;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x32046A0", Offset = "0x32036A0", VA = "0x1832046A0")]
	public PDHEEJFMMNJ(int FFHMMNBBJIL = 4, float AHOCKGAHBHM = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3203280", Offset = "0x3202280", VA = "0x183203280")]
	public bool BGBJIKPDFEG(Type BJKKIOODGOA, TValue MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x32034E0", Offset = "0x32024E0", VA = "0x1832034E0")]
	public bool BGBJIKPDFEG(Type BJKKIOODGOA, Func<Type, TValue> CNHFBNOAGPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x32043A0", Offset = "0x32033A0", VA = "0x1832043A0")]
	private bool OIFEDAJLAHN(Type BJKKIOODGOA, Func<Type, TValue> CNHFBNOAGPP, out TValue GNMBNJABILL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x32038F0", Offset = "0x32028F0", VA = "0x1832038F0")]
	private bool FDAEIEHOEIN(PNIIEDABKBH[] JBINHHOCDJP, Type KMAIODJOMEF, PNIIEDABKBH EIIMGIJKODH, Func<Type, TValue> CNHFBNOAGPP, out TValue GNMBNJABILL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x3203F50", Offset = "0x3202F50", VA = "0x183203F50")]
	public bool OADACMKKJNG(Type BJKKIOODGOA, out TValue MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x3203D60", Offset = "0x3202D60", VA = "0x183203D60")]
	public TValue IFPEMELNPAG(Type BJKKIOODGOA, Func<Type, TValue> CNHFBNOAGPP)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x1E53900", Offset = "0x1E52900", VA = "0x181E53900")]
	private static int GDENMFBNIBC(int JCHCKAOMCHB, float AHOCKGAHBHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x3203520", Offset = "0x3202520", VA = "0x183203520")]
	private static void CJBBMDCBHJF(ref PNIIEDABKBH EJDFGOAOAHC, PNIIEDABKBH MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x3203520", Offset = "0x3202520", VA = "0x183203520")]
	private static void CJBBMDCBHJF(ref PNIIEDABKBH[] EJDFGOAOAHC, PNIIEDABKBH[] MFBIHMKFNKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class MCLELMOPFOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder CGBDCJNPHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder GDDGLIMFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object EAEKEHBGILA;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x4B33010", Offset = "0x4B32010", VA = "0x184B33010")]
	public TypeBuilder HACNIHHAKFF(string JIEIIEKPPIJ, TypeAttributes FKMAJHGMLDL, Type HNINKJAJDDL, Type[] KJENPLANIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x4B33100", Offset = "0x4B32100", VA = "0x184B33100")]
	public MCLELMOPFOG(string JMNHLBEMNKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class MGFIICKOHMN
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x4B339E0", Offset = "0x4B329E0", VA = "0x184B339E0")]
	private static MethodInfo LLFAGCDNHEB(LambdaExpression HHCDJNIHAIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3C10", Offset = "0x1FD2C10", VA = "0x181FD3C10")]
	public static MethodInfo ELMHBKIAPBJ<T>(Expression<Func<T>> HHCDJNIHAIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3C10", Offset = "0x1FD2C10", VA = "0x181FD3C10")]
	public static MethodInfo ELMHBKIAPBJ<T, TR>(Expression<Func<T, TR>> HHCDJNIHAIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3C10", Offset = "0x1FD2C10", VA = "0x181FD3C10")]
	public static MethodInfo ELMHBKIAPBJ<T>(Expression<Action<T>> HHCDJNIHAIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3C10", Offset = "0x1FD2C10", VA = "0x181FD3C10")]
	public static MethodInfo ELMHBKIAPBJ<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> HHCDJNIHAIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3C80", Offset = "0x1FD2C80", VA = "0x181FD3C80")]
	private static MemberInfo PLHBAILMLAL<T>(Expression<T> PEJIHPGBPAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3C20", Offset = "0x1FD2C20", VA = "0x181FD3C20")]
	public static PropertyInfo MLDFPFLCENA<T, TR>(Expression<Func<T, TR>> HHCDJNIHAIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct MKFOPICEBFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int APEAIJJLBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool IGFEDCCDFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator MMABJADPAFA;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x4B35F80", Offset = "0x4B34F80", VA = "0x184B35F80")]
	public MKFOPICEBFL(ILGenerator MMABJADPAFA, int APEAIJJLBLJ, bool IGFEDCCDFNN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x4B35FC0", Offset = "0x4B34FC0", VA = "0x184B35FC0")]
	public MKFOPICEBFL(ILGenerator MMABJADPAFA, int APEAIJJLBLJ, Type DMBEFJIHONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x4B35E70", Offset = "0x4B34E70", VA = "0x184B35E70")]
	public void JEKDNJNIIDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class PKOLGJKBBLG
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x4B41DA0", Offset = "0x4B40DA0", VA = "0x184B41DA0")]
	public static void LAHJOJFAHMP(this ILGenerator MMABJADPAFA, int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x4B41FD0", Offset = "0x4B40FD0", VA = "0x184B41FD0")]
	public static void LAHJOJFAHMP(this ILGenerator MMABJADPAFA, LocalBuilder FBJBEOKFNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4B41AB0", Offset = "0x4B40AB0", VA = "0x184B41AB0")]
	public static void INIAIPOIKIB(this ILGenerator MMABJADPAFA, int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4B41CE0", Offset = "0x4B40CE0", VA = "0x184B41CE0")]
	public static void INIAIPOIKIB(this ILGenerator MMABJADPAFA, LocalBuilder FBJBEOKFNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x4B41730", Offset = "0x4B40730", VA = "0x184B41730")]
	public static void HNKFCOKBKFI(this ILGenerator MMABJADPAFA, int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x4B41820", Offset = "0x4B40820", VA = "0x184B41820")]
	public static void HNKFCOKBKFI(this ILGenerator MMABJADPAFA, LocalBuilder FBJBEOKFNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x4B41460", Offset = "0x4B40460", VA = "0x184B41460")]
	public static void DMHALCIJHLN(this ILGenerator MMABJADPAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x4B42460", Offset = "0x4B41460", VA = "0x184B42460")]
	public static void POJMIBLHONN(this ILGenerator MMABJADPAFA, bool MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x4B42010", Offset = "0x4B41010", VA = "0x184B42010")]
	public static void LOEGCJIJFIK(this ILGenerator MMABJADPAFA, int MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4B419C0", Offset = "0x4B409C0", VA = "0x184B419C0")]
	public static void INEMGNKFICL(this ILGenerator MMABJADPAFA, Type DMBEFJIHONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x4B411D0", Offset = "0x4B401D0", VA = "0x184B411D0")]
	public static void CEIBHBPIBGG(this ILGenerator MMABJADPAFA, Type DMBEFJIHONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x4B41470", Offset = "0x4B40470", VA = "0x184B41470")]
	public static void EPGNIKGGMAE(this ILGenerator MMABJADPAFA, int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4B41D20", Offset = "0x4B40D20", VA = "0x184B41D20")]
	public static void KAFBAHFPNEC(this ILGenerator MMABJADPAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4B41370", Offset = "0x4B40370", VA = "0x184B41370")]
	public static void DLPCDNOHOFM(this ILGenerator MMABJADPAFA, int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x4B41270", Offset = "0x4B40270", VA = "0x184B41270")]
	public static void CJJBJLCEAML(this ILGenerator MMABJADPAFA, MethodInfo HHBEHEFOBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x4B416A0", Offset = "0x4B406A0", VA = "0x184B416A0")]
	public static void HIJKKJLEOCN(this ILGenerator MMABJADPAFA, FieldInfo PJCOBFPAJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x4B41930", Offset = "0x4B40930", VA = "0x184B41930")]
	public static void IIOHBFFPAPB(this ILGenerator MMABJADPAFA, ulong MFBIHMKFNKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class GNFHJFKEAIP
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class GNAOOMLLEBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public GNAOOMLLEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2706F90", Offset = "0x2705F90", VA = "0x182706F90")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo IBNAOGNINLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo AGPEKMCAOMF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string DEIIFAKABEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551490", VA = "0x180552490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string KHIDDALIEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x595030", Offset = "0x594030", VA = "0x180595030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OEIHGHDIMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2707200", Offset = "0x2706200", VA = "0x182707200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DFKEEJBKEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x557540", Offset = "0x556540", VA = "0x180557540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5573D0", Offset = "0x5563D0", VA = "0x1805573D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool NNDCECIGJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xB45F90", Offset = "0xB44F90", VA = "0x180B45F90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xB45FA0", Offset = "0xB44FA0", VA = "0x180B45FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type JHCEJAKEANN
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x58BFF0", Offset = "0x58AFF0", VA = "0x18058BFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x58C000", Offset = "0x58B000", VA = "0x18058C000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo CICLAFAELAB
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6768A0", Offset = "0x6758A0", VA = "0x1806768A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x561BD0", Offset = "0x560BD0", VA = "0x180561BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo PHHABFLGOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5D8550", Offset = "0x5D7550", VA = "0x1805D8550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5D84D0", Offset = "0x5D74D0", VA = "0x1805D84D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo OBLIGKNKHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x594D00", Offset = "0x593D00", VA = "0x180594D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x594D10", Offset = "0x593D10", VA = "0x180594D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2707500", Offset = "0x2706500", VA = "0x182707500")]
	protected GNFHJFKEAIP(Type DMBEFJIHONB, string JIEIIEKPPIJ, string FAFCFNPKFII, bool BADJMNOODFA, bool CEJCDCMLMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x27073F0", Offset = "0x27063F0", VA = "0x1827073F0")]
	public GNFHJFKEAIP(FieldInfo KEKKEELMMKA, string JIEIIEKPPIJ, bool LCNEOEILONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x2707580", Offset = "0x2706580", VA = "0x182707580")]
	public GNFHJFKEAIP(PropertyInfo KEKKEELMMKA, string JIEIIEKPPIJ, bool LCNEOEILONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x2707210", Offset = "0x2706210", VA = "0x182707210")]
	private static MethodInfo LGJCBMMFMCD(MemberInfo KEKKEELMMKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x19F2130", Offset = "0x19F1130", VA = "0x1819F2130")]
	public T GDALEMAIMGC<T>(bool HEEECKKHAPF) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x2707140", Offset = "0x2706140", VA = "0x182707140", Slot = "4")]
	public virtual void BHIFBMGELHB(ILGenerator MMABJADPAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x2707330", Offset = "0x2706330", VA = "0x182707330", Slot = "5")]
	public virtual void MJAFGMMOJHP(ILGenerator MMABJADPAFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class NJBAJMIJEEH : GNFHJFKEAIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string IHGGFOPHIKL;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x4B39010", Offset = "0x4B38010", VA = "0x184B39010")]
	public NJBAJMIJEEH(string JIEIIEKPPIJ, string IHGGFOPHIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x4B38F00", Offset = "0x4B37F00", VA = "0x184B38F00", Slot = "4")]
	public override void BHIFBMGELHB(ILGenerator MMABJADPAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x4B38FC0", Offset = "0x4B37FC0", VA = "0x184B38FC0", Slot = "5")]
	public override void MJAFGMMOJHP(ILGenerator MMABJADPAFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class MOJGNLCGBBP : GNFHJFKEAIP
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo KPAJOHHMAJL;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo GMACNGLLFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal MKFOPICEBFL KIEFGHCCAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal MKFOPICEBFL LOOLBOIEBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal MKFOPICEBFL HKPOPGCFJAC;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x4B386C0", Offset = "0x4B376C0", VA = "0x184B386C0")]
	public MOJGNLCGBBP(string JIEIIEKPPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x4B37F30", Offset = "0x4B36F30", VA = "0x184B37F30", Slot = "4")]
	public override void BHIFBMGELHB(ILGenerator MMABJADPAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x4B381D0", Offset = "0x4B371D0", VA = "0x184B381D0", Slot = "5")]
	public override void MJAFGMMOJHP(ILGenerator MMABJADPAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x4B37FF0", Offset = "0x4B36FF0", VA = "0x184B37FF0")]
	public void FJGPGJGPCGD(ILGenerator MMABJADPAFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class APDPMECNMFK
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type JHCEJAKEANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551490", VA = "0x180552490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DEFAEABBJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5BD5B0", Offset = "0x5BC5B0", VA = "0x1805BD5B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6F1140", Offset = "0x6F0140", VA = "0x1806F1140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HEMGEDDJGHB
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5BD540", Offset = "0x5BC540", VA = "0x1805BD540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x79CB20", Offset = "0x79BB20", VA = "0x18079CB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo NJBFKAAIMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x584B30", Offset = "0x583B30", VA = "0x180584B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x584EA0", Offset = "0x583EA0", VA = "0x180584EA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public GNFHJFKEAIP[] GAAIJJJKBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x58BFF0", Offset = "0x58AFF0", VA = "0x18058BFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x58C000", Offset = "0x58B000", VA = "0x18058C000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public GNFHJFKEAIP[] NNJOMJBANBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x6768A0", Offset = "0x6758A0", VA = "0x1806768A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x561BD0", Offset = "0x560BD0", VA = "0x180561BD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x26FA350", Offset = "0x26F9350", VA = "0x1826FA350")]
	public APDPMECNMFK(Type DMBEFJIHONB, Func<string, string> GCLFOBOLIJH, bool LCNEOEILONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x26FA280", Offset = "0x26F9280", VA = "0x1826FA280")]
	private static bool CAIEANBOLDO(IEnumerator<ConstructorInfo> KFPMCKEMDAB, ref ConstructorInfo MAJBDAJLMBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct ALDICKDJDBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong JEOJALDAEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int OADAOAPKMCI;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x1A88200", Offset = "0x1A87200", VA = "0x181A88200")]
	public ALDICKDJDBM(ulong LFNEHLNJNLJ, int PNFFMMGPAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x26F92E0", Offset = "0x26F82E0", VA = "0x1826F92E0")]
	public void CBBCGLOPLHO(ref ALDICKDJDBM GKBKHIIEFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x26F94D0", Offset = "0x26F84D0", VA = "0x1826F94D0")]
	public static ALDICKDJDBM FBFBDBNIOJC(ref ALDICKDJDBM OOKPIHBNHGF, ref ALDICKDJDBM FMMAACMCILJ)
	{
		return default(ALDICKDJDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x26F92F0", Offset = "0x26F82F0", VA = "0x1826F92F0")]
	public void CMDLGFEIAMN(ref ALDICKDJDBM GKBKHIIEFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x26F9380", Offset = "0x26F8380", VA = "0x1826F9380")]
	public static ALDICKDJDBM COAILKNLIFI(ref ALDICKDJDBM OOKPIHBNHGF, ref ALDICKDJDBM FMMAACMCILJ)
	{
		return default(ALDICKDJDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x26F9490", Offset = "0x26F8490", VA = "0x1826F9490")]
	public void FAKKJGDKOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x26F9430", Offset = "0x26F8430", VA = "0x1826F9430")]
	public static ALDICKDJDBM FAKKJGDKOAO(ref ALDICKDJDBM OOKPIHBNHGF)
	{
		return default(ALDICKDJDBM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct FFJDMMPCMFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] MGGGNBHMHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int JNMGKKFIPGA;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x9421C0", Offset = "0x9411C0", VA = "0x1809421C0")]
	public FFJDMMPCMFJ(byte[] MGGGNBHMHDA, int HKHJMHKLNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2703E30", Offset = "0x2702E30", VA = "0x182703E30")]
	public void LFJIFAOAHMB(byte ADPHNNDAMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x2703E90", Offset = "0x2702E90", VA = "0x182703E90")]
	public void LNPEPBGGLOJ(byte[] ADPHNNDAMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2703C90", Offset = "0x2702C90", VA = "0x182703C90")]
	public void DHGIOPIJGKJ(byte[] ADPHNNDAMFI, int GFKNIIIDANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x2703BE0", Offset = "0x2702BE0", VA = "0x182703BE0")]
	public void DHGIOPIJGKJ(byte[] ADPHNNDAMFI, int ICAAAAPMEKA, int GFKNIIIDANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2703B60", Offset = "0x2702B60", VA = "0x182703B60")]
	public void AACGHIEGMGH(byte MCODHPOGBPN, int KLPGLGDELCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2703D30", Offset = "0x2702D30", VA = "0x182703D30")]
	public void JBPHKMIFKJK(string ADPHNNDAMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class MLJILGBAHBK
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum DKFCKNFLNFK
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum PPGNMMAPKBN
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum BOCCHNCJMLK
	{
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	[ThreadStatic]
	private static byte[] CCMGHKPBMFP;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] CIIMMLBIHKB;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] DIJBONEMBGH;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] HIAGADHOJIM;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly BOCCHNCJMLK EOEPKLODNEA;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char OOLBNNBKAGF;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int DGDBOMAHJEI;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int CJKJJLJCLMF;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] HKONOKELGDN;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x4B37700", Offset = "0x4B36700", VA = "0x184B37700")]
	private static byte[] NMKFGHNJCLA(int DDMFGCPNLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x4B37300", Offset = "0x4B36300", VA = "0x184B37300")]
	private static byte[] FLIFPEOAGLJ(int DDMFGCPNLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x4B373E0", Offset = "0x4B363E0", VA = "0x184B373E0")]
	public static int HIEABJODAFJ(ref byte[] MGGGNBHMHDA, int JNMGKKFIPGA, float MFBIHMKFNKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x4B374F0", Offset = "0x4B364F0", VA = "0x184B374F0")]
	public static int HIEABJODAFJ(ref byte[] MGGGNBHMHDA, int JNMGKKFIPGA, double MFBIHMKFNKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x4B37600", Offset = "0x4B36600", VA = "0x184B37600")]
	private static bool KGPLOGNDGOP(byte[] MGGGNBHMHDA, int GFKNIIIDANB, ulong EEHBGLLJBFI, ulong GFBKHKKLIKK, ulong GCLIOHFGHHG, ulong JMLDNOKAKGG, ulong AHMOECDPKBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x4B36EB0", Offset = "0x4B35EB0", VA = "0x184B36EB0")]
	private static void FDFLFEFGFBC(uint FNKNFIMMCAG, int AKOMDALJHJC, out uint PAHGFBBCGBF, out int PNIFBLEKKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x4B36680", Offset = "0x4B35680", VA = "0x184B36680")]
	private static bool AILBEBOPPGL(ALDICKDJDBM AALAIENBODB, ALDICKDJDBM ENPBHFNIBIC, ALDICKDJDBM MHGEPCEOLBJ, byte[] MGGGNBHMHDA, out int GFKNIIIDANB, out int PBIAKKNHAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x4B377D0", Offset = "0x4B367D0", VA = "0x184B377D0")]
	private static bool OEAPODCDDAP(double ANCLCJIJMKE, DKFCKNFLNFK MLBEKKOCNDC, byte[] MGGGNBHMHDA, out int GFKNIIIDANB, out int PKKJCKBBHKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x4B36DC0", Offset = "0x4B35DC0", VA = "0x184B36DC0")]
	private static bool EELDCKGMPHI(double ANCLCJIJMKE, DKFCKNFLNFK MLBEKKOCNDC, byte[] MGGGNBHMHDA, out int GFKNIIIDANB, out int OAMJIBLJBOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x4B37170", Offset = "0x4B36170", VA = "0x184B37170")]
	private static bool FHKEBKNIHPC(double MFBIHMKFNKA, ref FFJDMMPCMFJ LJIFHOHNPJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x4B36050", Offset = "0x4B35050", VA = "0x184B36050")]
	private static bool AABIIDGNHFE(double MFBIHMKFNKA, ref FFJDMMPCMFJ LJIFHOHNPJL, PPGNMMAPKBN MLBEKKOCNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x4B37B70", Offset = "0x4B36B70", VA = "0x184B37B70")]
	private static void PLNMNIHEJOC(byte[] DNEEJMEIOLN, int GFKNIIIDANB, int OAMJIBLJBOA, int IHCFPILDNCC, ref FFJDMMPCMFJ LJIFHOHNPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x4B36AD0", Offset = "0x4B35AD0", VA = "0x184B36AD0")]
	private static void DMBDJAMKNFJ(byte[] DNEEJMEIOLN, int GFKNIIIDANB, int PNFFMMGPAGO, ref FFJDMMPCMFJ LJIFHOHNPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x4B36FD0", Offset = "0x4B35FD0", VA = "0x184B36FD0")]
	private static bool FEMDNILLCON(double ANCLCJIJMKE, PPGNMMAPKBN MLBEKKOCNDC, int HNEKKNNMOIO, byte[] ELGLNPDCHGA, out bool HDFNIODPOFK, out int GFKNIIIDANB, out int DICGPBMCFJD)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct HILPFHIBFGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double HFCLJHDBBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong JGHBDIDHFHA;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct GABJLHLIEMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float JEOJALDAEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint CDLEIGAHCIA;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct ILHOFENIMEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong DJHNLGJDNCK;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2F888D0", Offset = "0x2F878D0", VA = "0x182F888D0")]
	public ILHOFENIMEN(double HFCLJHDBBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2F88830", Offset = "0x2F87830", VA = "0x182F88830")]
	public ILHOFENIMEN(ALDICKDJDBM HFCLJHDBBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2F88340", Offset = "0x2F87340", VA = "0x182F88340")]
	public ALDICKDJDBM GKHPIOCCJLK()
	{
		return default(ALDICKDJDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2F883C0", Offset = "0x2F873C0", VA = "0x182F883C0")]
	public ALDICKDJDBM HAKFJPJCPDK()
	{
		return default(ALDICKDJDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x595070", Offset = "0x594070", VA = "0x180595070")]
	public ulong FBIBCKCMNGM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2F88730", Offset = "0x2F87730", VA = "0x182F88730")]
	public double OJJOAFFLNPE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x2F882C0", Offset = "0x2F872C0", VA = "0x182F882C0")]
	public double FNOCMLCFDON()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x2F88270", Offset = "0x2F87270", VA = "0x182F88270")]
	public int ENHKCKJFBFP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x2F887A0", Offset = "0x2F877A0", VA = "0x182F887A0")]
	public ulong OKKKGNLFKBE()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2F882A0", Offset = "0x2F872A0", VA = "0x182F882A0")]
	public bool FKAOFPDFAGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F884D0", Offset = "0x2F874D0", VA = "0x182F884D0")]
	public bool KIMOOBJOBAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x2F887D0", Offset = "0x2F877D0", VA = "0x182F887D0")]
	public bool PDBKAAGEEGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x2F88800", Offset = "0x2F87800", VA = "0x182F88800")]
	public bool PGKJDJDAAJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2F88460", Offset = "0x2F87460", VA = "0x182F88460")]
	public int HCFMLKDDMND()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2F88500", Offset = "0x2F87500", VA = "0x182F88500")]
	public void MFPIIAJNHBA(out ALDICKDJDBM DGPGMLJMAGI, out ALDICKDJDBM NEMMJHIMHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2F88480", Offset = "0x2F87480", VA = "0x182F88480")]
	public bool IBGGAAIMMDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2F884F0", Offset = "0x2F874F0", VA = "0x182F884F0")]
	public double MFBIHMKFNKA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2F88250", Offset = "0x2F87250", VA = "0x182F88250")]
	public static int EADENDOEOGI(int ABIEHPBGBOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x2F88240", Offset = "0x2F87240", VA = "0x182F88240")]
	public static double APJLBGDJAHN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x2F88690", Offset = "0x2F87690", VA = "0x182F88690")]
	public static ulong OGENNNFLEGH(ALDICKDJDBM BAKLLCNEFED)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct JJNILJLLADG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint OLKJDKEMGPP;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x15EE3C0", Offset = "0x15ED3C0", VA = "0x1815EE3C0")]
	public JJNILJLLADG(float JEOJALDAEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2F8C4F0", Offset = "0x2F8B4F0", VA = "0x182F8C4F0")]
	public ALDICKDJDBM GKHPIOCCJLK()
	{
		return default(ALDICKDJDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5BBD80", Offset = "0x5BAD80", VA = "0x1805BBD80")]
	public uint HKLFMPDEHCH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2F8C4C0", Offset = "0x2F8B4C0", VA = "0x182F8C4C0")]
	public int ENHKCKJFBFP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F8C710", Offset = "0x2F8B710", VA = "0x182F8C710")]
	public uint OKKKGNLFKBE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F8C4E0", Offset = "0x2F8B4E0", VA = "0x182F8C4E0")]
	public bool FKAOFPDFAGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F8C5A0", Offset = "0x2F8B5A0", VA = "0x182F8C5A0")]
	public void MFPIIAJNHBA(out ALDICKDJDBM DGPGMLJMAGI, out ALDICKDJDBM NEMMJHIMHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2F8C560", Offset = "0x2F8B560", VA = "0x182F8C560")]
	public bool IBGGAAIMMDM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct GAIKPLDNMGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong LFNEHLNJNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short PLMKLELIONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short PKKJCKBBHKM;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2705610", Offset = "0x2704610", VA = "0x182705610")]
	public GAIKPLDNMGD(ulong LFNEHLNJNLJ, short PLMKLELIONB, short PKKJCKBBHKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class NLMIIKLENJJ
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly GAIKPLDNMGD[] PICMADEMDHM;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4B391C0", Offset = "0x4B381C0", VA = "0x184B391C0")]
	public static void ONIDPBJHEEN(int KBIKFKLJNOM, int DOIDMPDPNAE, out ALDICKDJDBM PAHGFBBCGBF, out int PKKJCKBBHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4B390C0", Offset = "0x4B380C0", VA = "0x184B390C0")]
	public static void IFCPKMIKBKD(int PDLBCPAHEDL, out ALDICKDJDBM PAHGFBBCGBF, out int HPKLNNDOLPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct JOANBIBMOJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] JNPIAJHKCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int ICAAAAPMEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int EJMDDHENLPO;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2F8C8D0", Offset = "0x2F8B8D0", VA = "0x182F8C8D0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x1D629E0", Offset = "0x1D619E0", VA = "0x181D629E0")]
	public JOANBIBMOJE(byte[] JNPIAJHKCKB, int ICAAAAPMEKA, int GFKNIIIDANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xED5100", Offset = "0xED4100", VA = "0x180ED5100")]
	public int GFKNIIIDANB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F8C870", Offset = "0x2F8B870", VA = "0x182F8C870")]
	public JOANBIBMOJE AOBGEAAJKPE(int FBGIJDCGHBO, int GNMIJFDEBBG)
	{
		return default(JOANBIBMOJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class KHBABLLMHGC
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] DNMMGGNLHNE;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] IHNCLKOIDBB;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int DHIMICGHKOE;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D6D0", Offset = "0x2F8C6D0", VA = "0x182F8D6D0")]
	private static byte[] IEOCLNCPMDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2F8DED0", Offset = "0x2F8CED0", VA = "0x182F8DED0")]
	private static JOANBIBMOJE KNDFEOBCJNC(JOANBIBMOJE MGGGNBHMHDA)
	{
		return default(JOANBIBMOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CD20", Offset = "0x2F8BD20", VA = "0x182F8CD20")]
	private static JOANBIBMOJE AJLIDJNEOMK(JOANBIBMOJE MGGGNBHMHDA)
	{
		return default(JOANBIBMOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2F8DFB0", Offset = "0x2F8CFB0", VA = "0x182F8DFB0")]
	private static void OIOKDMOOCKH(JOANBIBMOJE MGGGNBHMHDA, int PNFFMMGPAGO, byte[] GGKDGANPGLB, out int AFKAEGCKGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CE00", Offset = "0x2F8BE00", VA = "0x182F8CE00")]
	private static void BKJNALJGGPA(JOANBIBMOJE MGGGNBHMHDA, int PNFFMMGPAGO, byte[] NNCCKAACBGL, int EOJFEONKNJD, out JOANBIBMOJE DIJBIMDCBKD, out int HMPIEFOAHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D120", Offset = "0x2F8C120", VA = "0x182F8D120")]
	private static ulong CKCLPBLCLAO(JOANBIBMOJE MGGGNBHMHDA, out int LLAMEKOBLMN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D7B0", Offset = "0x2F8C7B0", VA = "0x182F8D7B0")]
	private static void IHJGCBGEFCI(JOANBIBMOJE MGGGNBHMHDA, out ALDICKDJDBM AFGNBGMNGPF, out int DKADIJCEAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D950", Offset = "0x2F8C950", VA = "0x182F8D950")]
	private static bool IONEDCHOAEJ(JOANBIBMOJE DIJBIMDCBKD, int PNFFMMGPAGO, out double AFGNBGMNGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D2E0", Offset = "0x2F8C2E0", VA = "0x182F8D2E0")]
	private static ALDICKDJDBM FHOJFABCKIM(int PNFFMMGPAGO)
	{
		return default(ALDICKDJDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E060", Offset = "0x2F8D060", VA = "0x182F8E060")]
	private static bool PBILDBNDGGC(JOANBIBMOJE MGGGNBHMHDA, int PNFFMMGPAGO, out double AFGNBGMNGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D1B0", Offset = "0x2F8C1B0", VA = "0x182F8D1B0")]
	private static bool DGOEAKCLJLH(JOANBIBMOJE DIJBIMDCBKD, int PNFFMMGPAGO, out double DNANLCMCBKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2F8DDA0", Offset = "0x2F8CDA0", VA = "0x182F8DDA0")]
	public static double? JLKILAEPGHO(JOANBIBMOJE MGGGNBHMHDA, int PNFFMMGPAGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D440", Offset = "0x2F8C440", VA = "0x182F8D440")]
	public static float? FKMJLAAKPAE(JOANBIBMOJE MGGGNBHMHDA, int PNFFMMGPAGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct AMODCHBNEGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] MGGGNBHMHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int JNMGKKFIPGA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte CIFMBHMEFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x26F98E0", Offset = "0x26F88E0", VA = "0x1826F98E0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x9421C0", Offset = "0x9411C0", VA = "0x1809421C0")]
	public AMODCHBNEGL(byte[] MGGGNBHMHDA, int JNMGKKFIPGA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x26F9810", Offset = "0x26F8810", VA = "0x1826F9810")]
	public static AMODCHBNEGL ILBHEDEODLL(AMODCHBNEGL EBOHMGAPLIG)
	{
		return default(AMODCHBNEGL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x26F9750", Offset = "0x26F8750", VA = "0x1826F9750")]
	public static AMODCHBNEGL GCJLOHFJPJA(AMODCHBNEGL EBOHMGAPLIG, int GFKNIIIDANB)
	{
		return default(AMODCHBNEGL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x26F9820", Offset = "0x26F8820", VA = "0x1826F9820")]
	public static int KAHEKGMBKFK(AMODCHBNEGL LLKALDKKJFP, AMODCHBNEGL EIFOFLJGEEA)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x26F98C0", Offset = "0x26F88C0", VA = "0x1826F98C0")]
	public static bool KMILPCLAINA(AMODCHBNEGL LLKALDKKJFP, AMODCHBNEGL EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x26F97F0", Offset = "0x26F87F0", VA = "0x1826F97F0")]
	public static bool GNFOGENJEMF(AMODCHBNEGL LLKALDKKJFP, AMODCHBNEGL EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x26F9880", Offset = "0x26F8880", VA = "0x1826F9880")]
	public static bool KMILPCLAINA(AMODCHBNEGL LLKALDKKJFP, char EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x26F97B0", Offset = "0x26F87B0", VA = "0x1826F97B0")]
	public static bool GNFOGENJEMF(AMODCHBNEGL LLKALDKKJFP, char EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x26F97B0", Offset = "0x26F87B0", VA = "0x1826F97B0")]
	public static bool GNFOGENJEMF(AMODCHBNEGL LLKALDKKJFP, byte EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x26F9710", Offset = "0x26F8710", VA = "0x1826F9710")]
	public static bool EMBNFNEJBOF(AMODCHBNEGL LLKALDKKJFP, char EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x26F9840", Offset = "0x26F8840", VA = "0x1826F9840")]
	public static bool KHIINDFHHEL(AMODCHBNEGL LLKALDKKJFP, char EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x26F96D0", Offset = "0x26F86D0", VA = "0x1826F96D0")]
	public static bool AEOGFCIGBEM(AMODCHBNEGL LLKALDKKJFP, char EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x26F9920", Offset = "0x26F8920", VA = "0x1826F9920")]
	public static bool MOCODFLCAID(AMODCHBNEGL LLKALDKKJFP, char EIFOFLJGEEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class ELPPBCABKDP
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] HMBDNDENCKB;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] OOCONKJJNCB;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] DIJBONEMBGH;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] HIAGADHOJIM;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] KEJBBMHGNJI;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int JANDPHPDBAD;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] FLHFJDAOGII;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int LGOFBNOBINJ;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2701910", Offset = "0x2700910", VA = "0x182701910")]
	private static byte[] BINHNLGNBCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2701C30", Offset = "0x2700C30", VA = "0x182701C30")]
	private static byte[] EANOIDBLPGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2701A50", Offset = "0x2700A50", VA = "0x182701A50")]
	public static double DOKEIANEMIN(byte[] MGGGNBHMHDA, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2701E90", Offset = "0x2700E90", VA = "0x182701E90")]
	public static float FHKCFGDPPEM(byte[] MGGGNBHMHDA, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2701D10", Offset = "0x2700D10", VA = "0x182701D10")]
	private static bool EFLBKABHABD(int FMMKCBAOFKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2702FD0", Offset = "0x2701FD0", VA = "0x182702FD0")]
	private static bool JFGEOOIDGEN(ref AMODCHBNEGL KGJFPLGBLBE, AMODCHBNEGL HGCGODPLIAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2701B10", Offset = "0x2700B10", VA = "0x182701B10")]
	private static bool DPFCDHJHKJD(ref AMODCHBNEGL KGJFPLGBLBE, AMODCHBNEGL HGCGODPLIAK, byte[] DCFFNHJICLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x27019F0", Offset = "0x27009F0", VA = "0x1827019F0")]
	private static bool CFIIBKNLNGG(ref AMODCHBNEGL EGDPKKKNIGB, byte[] ADPHNNDAMFI, int JNMGKKFIPGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x596CC0", Offset = "0x595CC0", VA = "0x180596CC0")]
	private static double PNJENNCJMNA(bool HDFNIODPOFK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x2701F50", Offset = "0x2700F50", VA = "0x182701F50")]
	private static double GJPFHGJPBLK(AMODCHBNEGL CNACCOAIDEF, int GFKNIIIDANB, bool BOBCJKHOGPP, out int PDAIJCGFIBK)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class MCLIIBKBANJ<T> : global::GNGMIEPFFIJ<T[]>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::IDHAGBFMGDG<T> CIPFNCCEDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly EKPDCFPCPKH JCNNPACPOGK;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1A75440", Offset = "0x1A74440", VA = "0x181A75440")]
	public MCLIIBKBANJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x140D1A0", Offset = "0x140C1A0", VA = "0x18140D1A0")]
	public MCLIIBKBANJ(EKPDCFPCPKH JCNNPACPOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x370F7A0", Offset = "0x370E7A0", VA = "0x18370F7A0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, T[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x370D7D0", Offset = "0x370C7D0", VA = "0x18370D7D0", Slot = "5")]
	public T[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class NCKCDCELNOA<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::IDHAGBFMGDG<T> CIPFNCCEDFF;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class EPJFKCMMKGC<T> : global::GNGMIEPFFIJ<List<T>>, OHDNNHIHLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly EKPDCFPCPKH JCNNPACPOGK;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x1A75440", Offset = "0x1A74440", VA = "0x181A75440")]
	public EPJFKCMMKGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x140D1A0", Offset = "0x140C1A0", VA = "0x18140D1A0")]
	public EPJFKCMMKGC(EKPDCFPCPKH JCNNPACPOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3435670", Offset = "0x3434670", VA = "0x183435670", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, List<T> MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3435100", Offset = "0x3434100", VA = "0x183435100", Slot = "5")]
	public List<T> GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class KILCKHOMKHH<TElement, TIntermediate, TEnumerator, TCollection> : global::GNGMIEPFFIJ<TCollection>, OHDNNHIHLFA where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2B939F0", Offset = "0x2B929F0", VA = "0x182B939F0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, TCollection MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2B937E0", Offset = "0x2B927E0", VA = "0x182B937E0", Slot = "5")]
	public TCollection GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator LKNEEKOCJED(TCollection PEJIHPGBPAG);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate JHOEBDGEJAE();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void IONNJMGFDPB(ref TIntermediate DPCBADAICKN, int CFANIPEBCPB, TElement MFBIHMKFNKA);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection GLIJLNLELKF(ref TIntermediate CMLBIOKDKLO);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
	protected KILCKHOMKHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class BMKPDJAGLBH<TElement, TIntermediate, TCollection> : global::KILCKHOMKHH<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3080C30", Offset = "0x307FC30", VA = "0x183080C30", Slot = "6")]
	protected override IEnumerator<TElement> LKNEEKOCJED(TCollection PEJIHPGBPAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1623420", Offset = "0x1622420", VA = "0x181623420")]
	protected BMKPDJAGLBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class CNEBJHMHHHC<TElement, TCollection> : global::BMKPDJAGLBH<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xAFEDB0", Offset = "0xAFDDB0", VA = "0x180AFEDB0", Slot = "9")]
	protected sealed override TCollection GLIJLNLELKF(ref TCollection CMLBIOKDKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class IKNEIHHPIPL<TElement, TCollection> : global::CNEBJHMHHHC<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x1700560", Offset = "0x16FF560", VA = "0x181700560", Slot = "7")]
	protected override TCollection JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x17004F0", Offset = "0x16FF4F0", VA = "0x1817004F0", Slot = "8")]
	protected override void IONNJMGFDPB(ref TCollection DPCBADAICKN, int CFANIPEBCPB, TElement MFBIHMKFNKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class PEEJIFBIPDO<T> : global::KILCKHOMKHH<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B490", Offset = "0x2B8A490", VA = "0x182B8B490", Slot = "8")]
	protected override void IONNJMGFDPB(ref LinkedList<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xAFEDB0", Offset = "0xAFDDB0", VA = "0x180AFEDB0", Slot = "9")]
	protected override LinkedList<T> GLIJLNLELKF(ref LinkedList<T> CMLBIOKDKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2A75370", Offset = "0x2A74370", VA = "0x182A75370", Slot = "7")]
	protected override LinkedList<T> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x32058E0", Offset = "0x32048E0", VA = "0x1832058E0", Slot = "6")]
	protected override LinkedList<T>.Enumerator LKNEEKOCJED(LinkedList<T> PEJIHPGBPAG)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class PCGBNDMEDIM<T> : global::KILCKHOMKHH<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B490", Offset = "0x2B8A490", VA = "0x182B8B490", Slot = "8")]
	protected override void IONNJMGFDPB(ref Queue<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2A75370", Offset = "0x2A74370", VA = "0x182A75370", Slot = "7")]
	protected override Queue<T> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3035960", Offset = "0x3034960", VA = "0x183035960", Slot = "6")]
	protected override Queue<T>.Enumerator LKNEEKOCJED(Queue<T> PEJIHPGBPAG)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0xAFEDB0", Offset = "0xAFDDB0", VA = "0x180AFEDB0", Slot = "9")]
	protected override Queue<T> GLIJLNLELKF(ref Queue<T> CMLBIOKDKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class FGNNEIOKHDA<T> : global::KILCKHOMKHH<T, global::KEOFDOOIBKE<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x22F0B10", Offset = "0x22EFB10", VA = "0x1822F0B10", Slot = "8")]
	protected override void IONNJMGFDPB(ref global::KEOFDOOIBKE<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x22F0B70", Offset = "0x22EFB70", VA = "0x1822F0B70", Slot = "7")]
	protected override global::KEOFDOOIBKE<T> JHOEBDGEJAE()
	{
		return default(global::KEOFDOOIBKE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x3035960", Offset = "0x3034960", VA = "0x183035960", Slot = "6")]
	protected override Stack<T>.Enumerator LKNEEKOCJED(Stack<T> PEJIHPGBPAG)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3035880", Offset = "0x3034880", VA = "0x183035880", Slot = "9")]
	protected override Stack<T> GLIJLNLELKF(ref global::KEOFDOOIBKE<T> CMLBIOKDKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class HCDFBHFBCNB<T> : global::KILCKHOMKHH<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B490", Offset = "0x2B8A490", VA = "0x182B8B490", Slot = "8")]
	protected override void IONNJMGFDPB(ref HashSet<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xAFEDB0", Offset = "0xAFDDB0", VA = "0x180AFEDB0", Slot = "9")]
	protected override HashSet<T> GLIJLNLELKF(ref HashSet<T> CMLBIOKDKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2A75370", Offset = "0x2A74370", VA = "0x182A75370", Slot = "7")]
	protected override HashSet<T> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x3035960", Offset = "0x3034960", VA = "0x183035960", Slot = "6")]
	protected override HashSet<T>.Enumerator LKNEEKOCJED(HashSet<T> PEJIHPGBPAG)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class OJMBKJJBKGO<T> : global::BMKPDJAGLBH<T, global::KEOFDOOIBKE<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x22F0B10", Offset = "0x22EFB10", VA = "0x1822F0B10", Slot = "8")]
	protected override void IONNJMGFDPB(ref global::KEOFDOOIBKE<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3655D90", Offset = "0x3654D90", VA = "0x183655D90", Slot = "9")]
	protected override ReadOnlyCollection<T> GLIJLNLELKF(ref global::KEOFDOOIBKE<T> CMLBIOKDKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3655E20", Offset = "0x3654E20", VA = "0x183655E20", Slot = "7")]
	protected override global::KEOFDOOIBKE<T> JHOEBDGEJAE()
	{
		return default(global::KEOFDOOIBKE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class KAKPPGNNKPN<T> : global::BMKPDJAGLBH<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B490", Offset = "0x2B8A490", VA = "0x182B8B490", Slot = "8")]
	protected override void IONNJMGFDPB(ref List<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2A75370", Offset = "0x2A74370", VA = "0x182A75370", Slot = "7")]
	protected override List<T> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xAFEDB0", Offset = "0xAFDDB0", VA = "0x180AFEDB0", Slot = "9")]
	protected override IList<T> GLIJLNLELKF(ref List<T> CMLBIOKDKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class OKJIBCEOAPN<T> : global::BMKPDJAGLBH<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B490", Offset = "0x2B8A490", VA = "0x182B8B490", Slot = "8")]
	protected override void IONNJMGFDPB(ref List<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2A75370", Offset = "0x2A74370", VA = "0x182A75370", Slot = "7")]
	protected override List<T> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xAFEDB0", Offset = "0xAFDDB0", VA = "0x180AFEDB0", Slot = "9")]
	protected override ICollection<T> GLIJLNLELKF(ref List<T> CMLBIOKDKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class MAAKABDJFAL<T> : global::BMKPDJAGLBH<T, global::KEOFDOOIBKE<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x22F0B10", Offset = "0x22EFB10", VA = "0x1822F0B10", Slot = "8")]
	protected override void IONNJMGFDPB(ref global::KEOFDOOIBKE<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x22F0B70", Offset = "0x22EFB70", VA = "0x1822F0B70", Slot = "7")]
	protected override global::KEOFDOOIBKE<T> JHOEBDGEJAE()
	{
		return default(global::KEOFDOOIBKE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x370BE40", Offset = "0x370AE40", VA = "0x18370BE40", Slot = "9")]
	protected override IEnumerable<T> GLIJLNLELKF(ref global::KEOFDOOIBKE<T> CMLBIOKDKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class HJCFJDDLAAM<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class MELPJPBHMAA<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class GBIBJJCIEAJ<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class MDAIHCLJKGM : global::GNGMIEPFFIJ<IEnumerable>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::GNGMIEPFFIJ<IEnumerable> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x4B333F0", Offset = "0x4B323F0", VA = "0x184B333F0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, IEnumerable MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x4B33200", Offset = "0x4B32200", VA = "0x184B33200", Slot = "5")]
	public IEnumerable GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public MDAIHCLJKGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class PDFMMBJAKNG : global::GNGMIEPFFIJ<ICollection>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::GNGMIEPFFIJ<ICollection> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4B40490", Offset = "0x4B3F490", VA = "0x184B40490", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ICollection MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4B402A0", Offset = "0x4B3F2A0", VA = "0x184B402A0", Slot = "5")]
	public ICollection GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public PDFMMBJAKNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class IKKCKPKDMHC : global::GNGMIEPFFIJ<IList>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::GNGMIEPFFIJ<IList> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2F87F40", Offset = "0x2F86F40", VA = "0x182F87F40", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, IList MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2F87DC0", Offset = "0x2F86DC0", VA = "0x182F87DC0", Slot = "5")]
	public IList GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public IKKCKPKDMHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class GHBHOPBCPOB<T> : global::BMKPDJAGLBH<T, global::KEOFDOOIBKE<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x22F0B40", Offset = "0x22EFB40", VA = "0x1822F0B40", Slot = "8")]
	protected override void IONNJMGFDPB(ref global::KEOFDOOIBKE<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x22F0B70", Offset = "0x22EFB70", VA = "0x1822F0B70", Slot = "7")]
	protected override global::KEOFDOOIBKE<T> JHOEBDGEJAE()
	{
		return default(global::KEOFDOOIBKE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x22F0AD0", Offset = "0x22EFAD0", VA = "0x1822F0AD0", Slot = "9")]
	protected override IReadOnlyList<T> GLIJLNLELKF(ref global::KEOFDOOIBKE<T> CMLBIOKDKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x140EEB0", Offset = "0x140DEB0", VA = "0x18140EEB0")]
	public GHBHOPBCPOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class AHPAIIPFOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x26F9240", Offset = "0x26F8240", VA = "0x1826F9240")]
	public static DateTime PNOFAKJPAPE(DateTime BHKEFGDKIPE)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class LEMMDKCJHFJ : global::GNGMIEPFFIJ<DateTime>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::GNGMIEPFFIJ<DateTime> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x2F9AA60", Offset = "0x2F99A60", VA = "0x182F9AA60", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, DateTime MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2F99B60", Offset = "0x2F98B60", VA = "0x182F99B60", Slot = "5")]
	public DateTime GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public LEMMDKCJHFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class EKNJCEEPMAH : global::GNGMIEPFFIJ<DateTimeOffset>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::GNGMIEPFFIJ<DateTimeOffset> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2700CF0", Offset = "0x26FFCF0", VA = "0x182700CF0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, DateTimeOffset MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x26FFD50", Offset = "0x26FED50", VA = "0x1826FFD50", Slot = "5")]
	public DateTimeOffset GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public EKNJCEEPMAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class HAOLMNPKFME : global::GNGMIEPFFIJ<TimeSpan>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::GNGMIEPFFIJ<TimeSpan> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] KIKLHKEBBDG;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2708090", Offset = "0x2707090", VA = "0x182708090", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, TimeSpan MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2707730", Offset = "0x2706730", VA = "0x182707730", Slot = "5")]
	public TimeSpan GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public HAOLMNPKFME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class DOOLDJNJBDG<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::GNGMIEPFFIJ<TDictionary>, OHDNNHIHLFA where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x35C1C30", Offset = "0x35C0C30", VA = "0x1835C1C30", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, TDictionary MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x35C1290", Offset = "0x35C0290", VA = "0x1835C1290", Slot = "5")]
	public TDictionary GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator LKNEEKOCJED(TDictionary PEJIHPGBPAG);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate JHOEBDGEJAE();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void IONNJMGFDPB(ref TIntermediate DPCBADAICKN, int CFANIPEBCPB, TKey BJKKIOODGOA, TValue MFBIHMKFNKA);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary GLIJLNLELKF(ref TIntermediate CMLBIOKDKLO);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
	protected DOOLDJNJBDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class KJOPGCOEHKL<TKey, TValue, TIntermediate, TDictionary> : global::DOOLDJNJBDG<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3080C30", Offset = "0x307FC30", VA = "0x183080C30", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> LKNEEKOCJED(TDictionary PEJIHPGBPAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class LMEELIDLDMN<TKey, TValue, TDictionary> : global::KJOPGCOEHKL<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xAFEDB0", Offset = "0xAFDDB0", VA = "0x180AFEDB0", Slot = "9")]
	protected override TDictionary GLIJLNLELKF(ref TDictionary CMLBIOKDKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class HFGPJLOMLPP<TKey, TValue> : global::DOOLDJNJBDG<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3770E80", Offset = "0x376FE80", VA = "0x183770E80", Slot = "8")]
	protected override void IONNJMGFDPB(ref Dictionary<TKey, TValue> DPCBADAICKN, int CFANIPEBCPB, TKey BJKKIOODGOA, TValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xAFEDB0", Offset = "0xAFDDB0", VA = "0x180AFEDB0", Slot = "9")]
	protected override Dictionary<TKey, TValue> GLIJLNLELKF(ref Dictionary<TKey, TValue> CMLBIOKDKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2A75370", Offset = "0x2A74370", VA = "0x182A75370", Slot = "7")]
	protected override Dictionary<TKey, TValue> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3770EC0", Offset = "0x376FEC0", VA = "0x183770EC0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator LKNEEKOCJED(Dictionary<TKey, TValue> PEJIHPGBPAG)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x14122F0", Offset = "0x14112F0", VA = "0x1814122F0")]
	public HFGPJLOMLPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class LAJCEBEAOOL<TKey, TValue, TDictionary> : global::LMEELIDLDMN<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x393BFA0", Offset = "0x393AFA0", VA = "0x18393BFA0", Slot = "8")]
	protected override void IONNJMGFDPB(ref TDictionary DPCBADAICKN, int CFANIPEBCPB, TKey BJKKIOODGOA, TValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x393C010", Offset = "0x393B010", VA = "0x18393C010", Slot = "7")]
	protected override TDictionary JHOEBDGEJAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class JNIPLLPAGGO<TKey, TValue> : global::KJOPGCOEHKL<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x2A75330", Offset = "0x2A74330", VA = "0x182A75330", Slot = "8")]
	protected override void IONNJMGFDPB(ref Dictionary<TKey, TValue> DPCBADAICKN, int CFANIPEBCPB, TKey BJKKIOODGOA, TValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2A75370", Offset = "0x2A74370", VA = "0x182A75370", Slot = "7")]
	protected override Dictionary<TKey, TValue> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0xAFEDB0", Offset = "0xAFDDB0", VA = "0x180AFEDB0", Slot = "9")]
	protected override IDictionary<TKey, TValue> GLIJLNLELKF(ref Dictionary<TKey, TValue> CMLBIOKDKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class OCEPHJBMMPP<TKey, TValue> : global::LMEELIDLDMN<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2A75330", Offset = "0x2A74330", VA = "0x182A75330", Slot = "8")]
	protected override void IONNJMGFDPB(ref SortedList<TKey, TValue> DPCBADAICKN, int CFANIPEBCPB, TKey BJKKIOODGOA, TValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2A75370", Offset = "0x2A74370", VA = "0x182A75370", Slot = "7")]
	protected override SortedList<TKey, TValue> JHOEBDGEJAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class GMOMOANOKCJ<TKey, TValue> : global::DOOLDJNJBDG<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2A75330", Offset = "0x2A74330", VA = "0x182A75330", Slot = "8")]
	protected override void IONNJMGFDPB(ref SortedDictionary<TKey, TValue> DPCBADAICKN, int CFANIPEBCPB, TKey BJKKIOODGOA, TValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xAFEDB0", Offset = "0xAFDDB0", VA = "0x180AFEDB0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> GLIJLNLELKF(ref SortedDictionary<TKey, TValue> CMLBIOKDKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2A75370", Offset = "0x2A74370", VA = "0x182A75370", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2A753D0", Offset = "0x2A743D0", VA = "0x182A753D0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator LKNEEKOCJED(SortedDictionary<TKey, TValue> PEJIHPGBPAG)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class KGPENAAENOM<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class PJPJAAOBBBG : global::GNGMIEPFFIJ<IDictionary>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::GNGMIEPFFIJ<IDictionary> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x4B40BF0", Offset = "0x4B3FBF0", VA = "0x184B40BF0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, IDictionary MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x4B408D0", Offset = "0x4B3F8D0", VA = "0x184B408D0", Slot = "5")]
	public IDictionary GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public PJPJAAOBBBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class BOOOLOEMIKO : global::GNGMIEPFFIJ<object>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void MCGBJEJOEHP(object OAOBDGEIKFK, ref AAEIOLMBBFI EEDEJPBOCJL, object MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::PDHEEJFMMNJ<KeyValuePair<object, MCGBJEJOEHP>> OGAKMMDJCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly CDLCJJDIPKK[] AOAKLDAIACH;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x26FC1A0", Offset = "0x26FB1A0", VA = "0x1826FC1A0")]
	public BOOOLOEMIKO(params CDLCJJDIPKK[] AOAKLDAIACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x26FB950", Offset = "0x26FA950", VA = "0x1826FB950", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, object MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x26FB850", Offset = "0x26FA850", VA = "0x1826FB850", Slot = "5")]
	public object GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class JJLCGEEBIII
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2F8B930", Offset = "0x2F8A930", VA = "0x182F8B930")]
	public static object PDNJPEANHIJ(Type DMBEFJIHONB, out bool COCCNAIAOED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2F8B150", Offset = "0x2F8A150", VA = "0x182F8B150")]
	public static object MJEGBCGELMO(Type DMBEFJIHONB, out bool COCCNAIAOED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class OMEOCPAIEJE<T> : global::GNGMIEPFFIJ<T>, OHDNNHIHLFA, global::HBGHNMDNJPN<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class PKDNHLFKIEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		public PKDNHLFKIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x3668C30", Offset = "0x3667C30", VA = "0x183668C30")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class CDHIDBCCFLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::IKEKJJNAKKM<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		public CDHIDBCCFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3653080", Offset = "0x3652080", VA = "0x183653080")]
		internal void <.cctor>b__1(ref AAEIOLMBBFI writer, T value, CDLCJJDIPKK _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class AIDJELAPMCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::HJCIHHCPLGI<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		public AIDJELAPMCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x3651AA0", Offset = "0x3650AA0", VA = "0x183651AA0")]
		internal T <.cctor>b__2(ref OEHFEJKEOBN reader, CDLCJJDIPKK _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::LGPELLCOFBG<T> BNCJJBNLAJE;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> DADLDHGAMGO;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::IKEKJJNAKKM<T> OFLPHGOEDME;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::HJCIHHCPLGI<T> DPNPIKPHJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool FEBDKLNKFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::IKEKJJNAKKM<T> HJOHHOOPMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::HJCIHHCPLGI<T> BBAFIGNBONI;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x365E360", Offset = "0x365D360", VA = "0x18365E360")]
	static OMEOCPAIEJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3668290", Offset = "0x3667290", VA = "0x183668290")]
	public OMEOCPAIEJE(bool FEBDKLNKFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x365B610", Offset = "0x365A610", VA = "0x18365B610", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, T MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3659A00", Offset = "0x3658A00", VA = "0x183659A00", Slot = "5")]
	public T GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3657450", Offset = "0x3656450", VA = "0x183657450", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, T MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3656770", Offset = "0x3655770", VA = "0x183656770", Slot = "7")]
	public T CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class PCMHEODHBJL<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class EEPIANPDJMB<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class FHIJAFHGGOB<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class LCICGKMNMBA<T> : global::GNGMIEPFFIJ<T?>, OHDNNHIHLFA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3D8F4A0", Offset = "0x3D8E4A0", VA = "0x183D8F4A0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, T? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3D8F1A0", Offset = "0x3D8E1A0", VA = "0x183D8F1A0", Slot = "5")]
	public T? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
	public LCICGKMNMBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class JBAJOOKAHLB<T> : global::GNGMIEPFFIJ<T?>, OHDNNHIHLFA where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::GNGMIEPFFIJ<T> FEIDBHKPDAH;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x18F69B0", Offset = "0x18F59B0", VA = "0x1818F69B0")]
	public JBAJOOKAHLB(global::GNGMIEPFFIJ<T> FEIDBHKPDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x33098F0", Offset = "0x33088F0", VA = "0x1833098F0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, T? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3308D00", Offset = "0x3307D00", VA = "0x183308D00", Slot = "5")]
	public T? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class NJALMEIHJLE : global::GNGMIEPFFIJ<sbyte>, OHDNNHIHLFA, global::HBGHNMDNJPN<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly NJALMEIHJLE BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x4B38E80", Offset = "0x4B37E80", VA = "0x184B38E80", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, sbyte MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x4B38E30", Offset = "0x4B37E30", VA = "0x184B38E30", Slot = "5")]
	public sbyte GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x4B38DF0", Offset = "0x4B37DF0", VA = "0x184B38DF0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, sbyte MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x4B38D50", Offset = "0x4B37D50", VA = "0x184B38D50", Slot = "7")]
	public sbyte CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public NJALMEIHJLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class AFPLNCCIGMO : global::GNGMIEPFFIJ<sbyte?>, OHDNNHIHLFA, global::HBGHNMDNJPN<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly AFPLNCCIGMO BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x26F9160", Offset = "0x26F8160", VA = "0x1826F9160", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, sbyte? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x26F90F0", Offset = "0x26F80F0", VA = "0x1826F90F0", Slot = "5")]
	public sbyte? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x26F8FF0", Offset = "0x26F7FF0", VA = "0x1826F8FF0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, sbyte? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x26F8F40", Offset = "0x26F7F40", VA = "0x1826F8F40", Slot = "7")]
	public sbyte? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public AFPLNCCIGMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class PCNHMONEOOI : global::GNGMIEPFFIJ<sbyte[]>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly PCNHMONEOOI BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x4B40180", Offset = "0x4B3F180", VA = "0x184B40180", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, sbyte[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x4B3FFE0", Offset = "0x4B3EFE0", VA = "0x184B3FFE0", Slot = "5")]
	public sbyte[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public PCNHMONEOOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class HBGKADAJPMC : global::GNGMIEPFFIJ<short>, OHDNNHIHLFA, global::HBGHNMDNJPN<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly HBGKADAJPMC BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x27087A0", Offset = "0x27077A0", VA = "0x1827087A0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, short MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2708790", Offset = "0x2707790", VA = "0x182708790", Slot = "5")]
	public short GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x27086D0", Offset = "0x27076D0", VA = "0x1827086D0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, short MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2708660", Offset = "0x2707660", VA = "0x182708660", Slot = "7")]
	public short CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public HBGKADAJPMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class NDHJBDJNADA : global::GNGMIEPFFIJ<short?>, OHDNNHIHLFA, global::HBGHNMDNJPN<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly NDHJBDJNADA BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x4B38960", Offset = "0x4B37960", VA = "0x184B38960", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, short? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x4B388B0", Offset = "0x4B378B0", VA = "0x184B388B0", Slot = "5")]
	public short? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x4B38830", Offset = "0x4B37830", VA = "0x184B38830", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, short? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x4B38760", Offset = "0x4B37760", VA = "0x184B38760", Slot = "7")]
	public short? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public NDHJBDJNADA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class EPOMBCNOPKO : global::GNGMIEPFFIJ<short[]>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly EPOMBCNOPKO BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x27035A0", Offset = "0x27025A0", VA = "0x1827035A0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, short[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x2703460", Offset = "0x2702460", VA = "0x182703460", Slot = "5")]
	public short[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public EPOMBCNOPKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class GGLOMAHMHEP : global::GNGMIEPFFIJ<int>, OHDNNHIHLFA, global::HBGHNMDNJPN<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly GGLOMAHMHEP BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x27068C0", Offset = "0x27058C0", VA = "0x1827068C0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, int MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x27068B0", Offset = "0x27058B0", VA = "0x1827068B0", Slot = "5")]
	public int GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x27067F0", Offset = "0x27057F0", VA = "0x1827067F0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, int MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2706780", Offset = "0x2705780", VA = "0x182706780", Slot = "7")]
	public int CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public GGLOMAHMHEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class GDNBLHNJDOM : global::GNGMIEPFFIJ<int?>, OHDNNHIHLFA, global::HBGHNMDNJPN<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly GDNBLHNJDOM BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2706220", Offset = "0x2705220", VA = "0x182706220", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, int? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x27061B0", Offset = "0x27051B0", VA = "0x1827061B0", Slot = "5")]
	public int? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x27060B0", Offset = "0x27050B0", VA = "0x1827060B0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, int? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2706010", Offset = "0x2705010", VA = "0x182706010", Slot = "7")]
	public int? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public GDNBLHNJDOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class OINCIAHBAFF : global::GNGMIEPFFIJ<int[]>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly OINCIAHBAFF BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x4B3F6A0", Offset = "0x4B3E6A0", VA = "0x184B3F6A0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, int[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x4B3F500", Offset = "0x4B3E500", VA = "0x184B3F500", Slot = "5")]
	public int[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public OINCIAHBAFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class IGMFAEGICIE : global::GNGMIEPFFIJ<long>, OHDNNHIHLFA, global::HBGHNMDNJPN<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly IGMFAEGICIE BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2F879E0", Offset = "0x2F869E0", VA = "0x182F879E0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, long MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F879D0", Offset = "0x2F869D0", VA = "0x182F879D0", Slot = "5")]
	public long GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F87990", Offset = "0x2F86990", VA = "0x182F87990", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, long MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F87920", Offset = "0x2F86920", VA = "0x182F87920", Slot = "7")]
	public long CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public IGMFAEGICIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class HPHEHHOBDKH : global::GNGMIEPFFIJ<long?>, OHDNNHIHLFA, global::HBGHNMDNJPN<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly HPHEHHOBDKH BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x270AD60", Offset = "0x2709D60", VA = "0x18270AD60", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, long? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x270ACD0", Offset = "0x2709CD0", VA = "0x18270ACD0", Slot = "5")]
	public long? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x270ABD0", Offset = "0x2709BD0", VA = "0x18270ABD0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, long? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x270AB10", Offset = "0x2709B10", VA = "0x18270AB10", Slot = "7")]
	public long? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public HPHEHHOBDKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class OMJDMHNLOHA : global::GNGMIEPFFIJ<long[]>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly OMJDMHNLOHA BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4B3FC00", Offset = "0x4B3EC00", VA = "0x184B3FC00", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, long[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x4B3FA60", Offset = "0x4B3EA60", VA = "0x184B3FA60", Slot = "5")]
	public long[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public OMJDMHNLOHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class KHKHDODNMJD : global::GNGMIEPFFIJ<byte>, OHDNNHIHLFA, global::HBGHNMDNJPN<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly KHKHDODNMJD BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E8C0", Offset = "0x2F8D8C0", VA = "0x182F8E8C0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, byte MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E8B0", Offset = "0x2F8D8B0", VA = "0x182F8E8B0", Slot = "5")]
	public byte GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E870", Offset = "0x2F8D870", VA = "0x182F8E870", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, byte MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E800", Offset = "0x2F8D800", VA = "0x182F8E800", Slot = "7")]
	public byte CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public KHKHDODNMJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class CBLLPHOODEE : global::GNGMIEPFFIJ<byte?>, OHDNNHIHLFA, global::HBGHNMDNJPN<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly CBLLPHOODEE BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x26FC460", Offset = "0x26FB460", VA = "0x1826FC460", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, byte? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x26FC3F0", Offset = "0x26FB3F0", VA = "0x1826FC3F0", Slot = "5")]
	public byte? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x26FC2F0", Offset = "0x26FB2F0", VA = "0x1826FC2F0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, byte? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x26FC240", Offset = "0x26FB240", VA = "0x1826FC240", Slot = "7")]
	public byte? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public CBLLPHOODEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class DLCAJHCMDBN : global::GNGMIEPFFIJ<ushort>, OHDNNHIHLFA, global::HBGHNMDNJPN<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly DLCAJHCMDBN BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x26FE940", Offset = "0x26FD940", VA = "0x1826FE940", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ushort MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x26FE930", Offset = "0x26FD930", VA = "0x1826FE930", Slot = "5")]
	public ushort GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x26FE870", Offset = "0x26FD870", VA = "0x1826FE870", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, ushort MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x26FE800", Offset = "0x26FD800", VA = "0x1826FE800", Slot = "7")]
	public ushort CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public DLCAJHCMDBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class GKBIDOMLKOI : global::GNGMIEPFFIJ<ushort?>, OHDNNHIHLFA, global::HBGHNMDNJPN<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly GKBIDOMLKOI BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2706EB0", Offset = "0x2705EB0", VA = "0x182706EB0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ushort? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2706E40", Offset = "0x2705E40", VA = "0x182706E40", Slot = "5")]
	public ushort? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2706D40", Offset = "0x2705D40", VA = "0x182706D40", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, ushort? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2706CA0", Offset = "0x2705CA0", VA = "0x182706CA0", Slot = "7")]
	public ushort? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public GKBIDOMLKOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class FIILFPAHCOE : global::GNGMIEPFFIJ<ushort[]>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly FIILFPAHCOE BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2704680", Offset = "0x2703680", VA = "0x182704680", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ushort[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2704540", Offset = "0x2703540", VA = "0x182704540", Slot = "5")]
	public ushort[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public FIILFPAHCOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class ALGBAHFMECM : global::GNGMIEPFFIJ<uint>, OHDNNHIHLFA, global::HBGHNMDNJPN<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly ALGBAHFMECM BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x26F9640", Offset = "0x26F8640", VA = "0x1826F9640", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, uint MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x26F9630", Offset = "0x26F8630", VA = "0x1826F9630", Slot = "5")]
	public uint GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x26F9570", Offset = "0x26F8570", VA = "0x1826F9570", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, uint MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x26F9500", Offset = "0x26F8500", VA = "0x1826F9500", Slot = "7")]
	public uint CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public ALGBAHFMECM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class KIIFHJNLIHF : global::GNGMIEPFFIJ<uint?>, OHDNNHIHLFA, global::HBGHNMDNJPN<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly KIIFHJNLIHF BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2F8EB60", Offset = "0x2F8DB60", VA = "0x182F8EB60", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, uint? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2F8EAF0", Offset = "0x2F8DAF0", VA = "0x182F8EAF0", Slot = "5")]
	public uint? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x2F8EA70", Offset = "0x2F8DA70", VA = "0x182F8EA70", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, uint? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E9D0", Offset = "0x2F8D9D0", VA = "0x182F8E9D0", Slot = "7")]
	public uint? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public KIIFHJNLIHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class EIBPFEDKDHJ : global::GNGMIEPFFIJ<uint[]>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly EIBPFEDKDHJ BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x26FFB50", Offset = "0x26FEB50", VA = "0x1826FFB50", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, uint[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x26FFA10", Offset = "0x26FEA10", VA = "0x1826FFA10", Slot = "5")]
	public uint[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public EIBPFEDKDHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class JOHAIOKNGGH : global::GNGMIEPFFIJ<ulong>, OHDNNHIHLFA, global::HBGHNMDNJPN<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly JOHAIOKNGGH BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2F8C9D0", Offset = "0x2F8B9D0", VA = "0x182F8C9D0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ulong MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x2F8C9C0", Offset = "0x2F8B9C0", VA = "0x182F8C9C0", Slot = "5")]
	public ulong GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2F8C980", Offset = "0x2F8B980", VA = "0x182F8C980", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, ulong MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x2F8C910", Offset = "0x2F8B910", VA = "0x182F8C910", Slot = "7")]
	public ulong CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public JOHAIOKNGGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class OJANFJGKNDH : global::GNGMIEPFFIJ<ulong?>, OHDNNHIHLFA, global::HBGHNMDNJPN<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly OJANFJGKNDH BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4B3F990", Offset = "0x4B3E990", VA = "0x184B3F990", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ulong? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4B3F900", Offset = "0x4B3E900", VA = "0x184B3F900", Slot = "5")]
	public ulong? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4B3F880", Offset = "0x4B3E880", VA = "0x184B3F880", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, ulong? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4B3F7C0", Offset = "0x4B3E7C0", VA = "0x184B3F7C0", Slot = "7")]
	public ulong? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public OJANFJGKNDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class GDPIJMPMAEE : global::GNGMIEPFFIJ<ulong[]>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly GDPIJMPMAEE BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2706440", Offset = "0x2705440", VA = "0x182706440", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ulong[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2706300", Offset = "0x2705300", VA = "0x182706300", Slot = "5")]
	public ulong[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public GDPIJMPMAEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class GHBOKOHCPKE : global::GNGMIEPFFIJ<float>, OHDNNHIHLFA, global::HBGHNMDNJPN<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly GHBOKOHCPKE BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2706A80", Offset = "0x2705A80", VA = "0x182706A80", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, float MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2706A70", Offset = "0x2705A70", VA = "0x182706A70", Slot = "5")]
	public float GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x27069C0", Offset = "0x27059C0", VA = "0x1827069C0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, float MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2706950", Offset = "0x2705950", VA = "0x182706950", Slot = "7")]
	public float CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public GHBOKOHCPKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class MKDIKHPOFFF : global::GNGMIEPFFIJ<float?>, OHDNNHIHLFA, global::HBGHNMDNJPN<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly MKDIKHPOFFF BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x4B35DA0", Offset = "0x4B34DA0", VA = "0x184B35DA0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, float? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x4B35D30", Offset = "0x4B34D30", VA = "0x184B35D30", Slot = "5")]
	public float? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x4B35CB0", Offset = "0x4B34CB0", VA = "0x184B35CB0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, float? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x4B35BD0", Offset = "0x4B34BD0", VA = "0x184B35BD0", Slot = "7")]
	public float? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public MKDIKHPOFFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class CCCCHCJEFGF : global::GNGMIEPFFIJ<float[]>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly CCCCHCJEFGF BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x26FC680", Offset = "0x26FB680", VA = "0x1826FC680", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, float[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x26FC540", Offset = "0x26FB540", VA = "0x1826FC540", Slot = "5")]
	public float[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public CCCCHCJEFGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class CNMCCHBPBOA : global::GNGMIEPFFIJ<double>, OHDNNHIHLFA, global::HBGHNMDNJPN<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly CNMCCHBPBOA BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x26FCAB0", Offset = "0x26FBAB0", VA = "0x1826FCAB0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, double MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x26FCAA0", Offset = "0x26FBAA0", VA = "0x1826FCAA0", Slot = "5")]
	public double GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x26FC9F0", Offset = "0x26FB9F0", VA = "0x1826FC9F0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, double MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x26FC980", Offset = "0x26FB980", VA = "0x1826FC980", Slot = "7")]
	public double CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public CNMCCHBPBOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class MECKGMOPAOI : global::GNGMIEPFFIJ<double?>, OHDNNHIHLFA, global::HBGHNMDNJPN<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly MECKGMOPAOI BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x4B33860", Offset = "0x4B32860", VA = "0x184B33860", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, double? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4B337D0", Offset = "0x4B327D0", VA = "0x184B337D0", Slot = "5")]
	public double? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4B33750", Offset = "0x4B32750", VA = "0x184B33750", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, double? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x4B33640", Offset = "0x4B32640", VA = "0x184B33640", Slot = "7")]
	public double? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public MECKGMOPAOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class NDLHADNAHEE : global::GNGMIEPFFIJ<double[]>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly NDLHADNAHEE BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x4B38BD0", Offset = "0x4B37BD0", VA = "0x184B38BD0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, double[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x4B38A30", Offset = "0x4B37A30", VA = "0x184B38A30", Slot = "5")]
	public double[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public NDLHADNAHEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class GJGMADCGGGD : global::GNGMIEPFFIJ<bool>, OHDNNHIHLFA, global::HBGHNMDNJPN<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly GJGMADCGGGD BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2706C20", Offset = "0x2705C20", VA = "0x182706C20", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, bool MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2706C10", Offset = "0x2705C10", VA = "0x182706C10", Slot = "5")]
	public bool GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2706B60", Offset = "0x2705B60", VA = "0x182706B60", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, bool MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2706AF0", Offset = "0x2705AF0", VA = "0x182706AF0", Slot = "7")]
	public bool CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public GJGMADCGGGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class JCDGLNBKDLA : global::GNGMIEPFFIJ<bool?>, OHDNNHIHLFA, global::HBGHNMDNJPN<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly JCDGLNBKDLA BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2F8AB80", Offset = "0x2F89B80", VA = "0x182F8AB80", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, bool? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2F8AB10", Offset = "0x2F89B10", VA = "0x182F8AB10", Slot = "5")]
	public bool? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2F8AA90", Offset = "0x2F89A90", VA = "0x182F8AA90", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, bool? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2F8A9E0", Offset = "0x2F899E0", VA = "0x182F8A9E0", Slot = "7")]
	public bool? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public JCDGLNBKDLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class DGEJGHLELHC : global::GNGMIEPFFIJ<bool[]>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly DGEJGHLELHC BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x26FDC70", Offset = "0x26FCC70", VA = "0x1826FDC70", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, bool[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x26FDB30", Offset = "0x26FCB30", VA = "0x1826FDB30", Slot = "5")]
	public bool[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public DGEJGHLELHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class HBOFNEADAPE : global::GNGMIEPFFIJ<object>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::GNGMIEPFFIJ<object> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> CEMHFIJFCNL;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2708AE0", Offset = "0x2707AE0", VA = "0x182708AE0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, object MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2708840", Offset = "0x2707840", VA = "0x182708840", Slot = "5")]
	public object GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public HBOFNEADAPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class KHGCEIEAELA : global::GNGMIEPFFIJ<byte[]>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::GNGMIEPFFIJ<byte[]> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E5E0", Offset = "0x2F8D5E0", VA = "0x182F8E5E0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, byte[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E560", Offset = "0x2F8D560", VA = "0x182F8E560", Slot = "5")]
	public byte[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public KHGCEIEAELA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class HJCCANDEKBK : global::GNGMIEPFFIJ<ArraySegment<byte>>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::GNGMIEPFFIJ<ArraySegment<byte>> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x270A530", Offset = "0x2709530", VA = "0x18270A530", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ArraySegment<byte> MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x270A460", Offset = "0x2709460", VA = "0x18270A460", Slot = "5")]
	public ArraySegment<byte> GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public HJCCANDEKBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class PMLMNNGOIMH : global::GNGMIEPFFIJ<string>, OHDNNHIHLFA, global::HBGHNMDNJPN<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::GNGMIEPFFIJ<string> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x4B42480", Offset = "0x4B41480", VA = "0x184B42480", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, string MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x4B42470", Offset = "0x4B41470", VA = "0x184B42470", Slot = "5")]
	public string GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x4B42480", Offset = "0x4B41480", VA = "0x184B42480", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, string MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x4B42470", Offset = "0x4B41470", VA = "0x184B42470", Slot = "7")]
	public string CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public PMLMNNGOIMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class ONGBGCFBLCB : global::GNGMIEPFFIJ<string[]>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly ONGBGCFBLCB BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x4B3FEC0", Offset = "0x4B3EEC0", VA = "0x184B3FEC0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, string[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x4B3FD20", Offset = "0x4B3ED20", VA = "0x184B3FD20", Slot = "5")]
	public string[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public ONGBGCFBLCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class IDIOHMNDKKO : global::GNGMIEPFFIJ<char>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly IDIOHMNDKKO BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2F87710", Offset = "0x2F86710", VA = "0x182F87710", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, char MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2F876E0", Offset = "0x2F866E0", VA = "0x182F876E0", Slot = "5")]
	public char GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public IDIOHMNDKKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class HIEPOFENKFH : global::GNGMIEPFFIJ<char?>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly HIEPOFENKFH BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2709B20", Offset = "0x2708B20", VA = "0x182709B20", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, char? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2709A60", Offset = "0x2708A60", VA = "0x182709A60", Slot = "5")]
	public char? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public HIEPOFENKFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class GAPFGPPMKLK : global::GNGMIEPFFIJ<char[]>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly GAPFGPPMKLK BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x27057C0", Offset = "0x27047C0", VA = "0x1827057C0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, char[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2705620", Offset = "0x2704620", VA = "0x182705620", Slot = "5")]
	public char[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public GAPFGPPMKLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class CPDHIFNOJDH : global::GNGMIEPFFIJ<Guid>, OHDNNHIHLFA, global::HBGHNMDNJPN<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::GNGMIEPFFIJ<Guid> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x26FCCA0", Offset = "0x26FBCA0", VA = "0x1826FCCA0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Guid MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x26FCC10", Offset = "0x26FBC10", VA = "0x1826FCC10", Slot = "5")]
	public Guid GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x26FCC70", Offset = "0x26FBC70", VA = "0x1826FCC70", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, Guid MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x26FCC10", Offset = "0x26FBC10", VA = "0x1826FCC10", Slot = "7")]
	public Guid CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public CPDHIFNOJDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class MIGMFAOKMFK : global::GNGMIEPFFIJ<decimal>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::GNGMIEPFFIJ<decimal> BNBEJHJGDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool MMCADCCFMBC;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x1A62EC0", Offset = "0x1A61EC0", VA = "0x181A62EC0")]
	public MIGMFAOKMFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xD02590", Offset = "0xD01590", VA = "0x180D02590")]
	public MIGMFAOKMFK(bool MMCADCCFMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x4B35A30", Offset = "0x4B34A30", VA = "0x184B35A30", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, decimal MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x4B35880", Offset = "0x4B34880", VA = "0x184B35880", Slot = "5")]
	public decimal GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class DEHPIDDIGGA : global::GNGMIEPFFIJ<Uri>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::GNGMIEPFFIJ<Uri> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x26FDA20", Offset = "0x26FCA20", VA = "0x1826FDA20", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Uri MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x26FD9A0", Offset = "0x26FC9A0", VA = "0x1826FD9A0", Slot = "5")]
	public Uri GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public DEHPIDDIGGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class JPNAJBGEKPC : global::GNGMIEPFFIJ<Version>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::GNGMIEPFFIJ<Version> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CAD0", Offset = "0x2F8BAD0", VA = "0x182F8CAD0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Version MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CA50", Offset = "0x2F8BA50", VA = "0x182F8CA50", Slot = "5")]
	public Version GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public JPNAJBGEKPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class PHLANMJPHCJ<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class KHGOELFCABA : global::GNGMIEPFFIJ<StringBuilder>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::GNGMIEPFFIJ<StringBuilder> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E750", Offset = "0x2F8D750", VA = "0x182F8E750", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, StringBuilder MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E6D0", Offset = "0x2F8D6D0", VA = "0x182F8E6D0", Slot = "5")]
	public StringBuilder GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public KHGOELFCABA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class DJEHLGBICGI : global::GNGMIEPFFIJ<BitArray>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::GNGMIEPFFIJ<BitArray> BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x26FE6A0", Offset = "0x26FD6A0", VA = "0x1826FE6A0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, BitArray MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x26FE5A0", Offset = "0x26FD5A0", VA = "0x1826FE5A0", Slot = "5")]
	public BitArray GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public DJEHLGBICGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class EGDMJBCEJHF : global::GNGMIEPFFIJ<Type>, OHDNNHIHLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly EGDMJBCEJHF BNBEJHJGDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex ABJDKDDDLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool HJLAKJFJFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool CMCJONIFPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool KKLPFBADLLI;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x26FF940", Offset = "0x26FE940", VA = "0x1826FF940")]
	public EGDMJBCEJHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x26FF8F0", Offset = "0x26FE8F0", VA = "0x1826FF8F0")]
	public EGDMJBCEJHF(bool HJLAKJFJFAK, bool CMCJONIFPLJ, bool KKLPFBADLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x26FF760", Offset = "0x26FE760", VA = "0x1826FF760", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Type MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x26FF640", Offset = "0x26FE640", VA = "0x1826FF640", Slot = "5")]
	public Type GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
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
