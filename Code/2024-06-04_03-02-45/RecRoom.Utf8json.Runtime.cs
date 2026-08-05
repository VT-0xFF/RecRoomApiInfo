using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class JHMJJADIFFG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x71DDDF0", Offset = "0x71DC5F0", VA = "0x1871DDDF0")]
	public static bool IOBFEDICHBM(this TypeInfo HKAKMPIMEOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class DNIKFLFINKE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type LDFGMOPKEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] DBFAGJCMLNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
	public DNIKFLFINKE(Type ENEFHPJMDHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class GPFJNIPBMDH : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void GFHCGNOKPMK<T>(DPHIKHGFLNL COHNONCDMOG, T IPHHABIKCHD, JOEIFIPPNIH MNDKJGJCMCI);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T PPFPIEPONCN<T>(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH MNDKJGJCMCI);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BNDBHHCFNCL
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BMLPDKFJOPL<T> : BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, T IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KMDHLAFMGKK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, T IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum OPDEKPMDPDF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class AACLADPADIO
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3145460", Offset = "0x3143C60", VA = "0x183145460")]
	public static string HBCGDAJODPP<T>(this BMLPDKFJOPL<T> GCFCPGAMOOK, T IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMLPDKFJOPL<T> MJCKBNPEBNE<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class KEKMLOCNEJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2B24200", Offset = "0x2B22A00", VA = "0x182B24200")]
	public static BMLPDKFJOPL<T> NEHALOPGLIL<T>(this JOEIFIPPNIH MNDKJGJCMCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x71E1C70", Offset = "0x71E0470", VA = "0x1871E1C70")]
	public static object LGGKOPFNDOL(this JOEIFIPPNIH MNDKJGJCMCI, Type HKAKMPIMEOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PKKOELEKODC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x71EBAE0", Offset = "0x71EA2E0", VA = "0x1871EBAE0")]
	public PKKOELEKODC(string CLBGCJICGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct JHNPEGAMHPK
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class KCMKHEDFIOB
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] PAJEBKJPIBK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] BLNCJLBDMHM;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x71E1BD0", Offset = "0x71E03D0", VA = "0x1871E1BD0")]
		public static byte[] KBCPNGJGFNM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x71E1B30", Offset = "0x71E0330", VA = "0x1871E1B30")]
		public static char[] AFHADKJHIAJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> FLIJFBOKHII;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] FEHHLOEJIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] GHFEJDPMJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int MFLLOPOPNNG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool OFACJIGBPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x71E0DB0", Offset = "0x71DF5B0", VA = "0x1871E0DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x71E1230", Offset = "0x71DFA30", VA = "0x1871E1230")]
	public JHNPEGAMHPK(byte[] GHFEJDPMJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x71E10E0", Offset = "0x71DF8E0", VA = "0x1871E10E0")]
	public JHNPEGAMHPK(byte[] GHFEJDPMJDG, int MFLLOPOPNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x71DEEA0", Offset = "0x71DD6A0", VA = "0x1871DEEA0")]
	private GHDGFMPCGGL FCHKJCCHAIF(string DKMMFHMIHHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x71E0BA0", Offset = "0x71DF3A0", VA = "0x1871E0BA0")]
	private GHDGFMPCGGL OKHNMMGAFOK(string CLBGCJICGJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x71D9E10", Offset = "0x71D8610", VA = "0x1871D9E10")]
	public void PDHJGFHJFAB(int MFLLOPOPNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
	public byte[] HHOCPGGOCLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1F5C7A0", Offset = "0x1F5AFA0", VA = "0x181F5C7A0")]
	public int PDHCKDFAKAI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x71E00C0", Offset = "0x71DE8C0", VA = "0x1871E00C0")]
	public ENNEPPHLCPB LJKBMMKCAJK()
	{
		return default(ENNEPPHLCPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x71DFF90", Offset = "0x71DE790", VA = "0x1871DFF90")]
	public void LIIHGFCDPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x71E03C0", Offset = "0x71DEBC0", VA = "0x1871E03C0")]
	public bool LPCJDACFBOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x71DFF00", Offset = "0x71DE700", VA = "0x1871DFF00")]
	public bool KKPEPNEOMOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x71DE670", Offset = "0x71DCE70", VA = "0x1871DE670")]
	public void EMEBHALHBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x71DFDC0", Offset = "0x71DE5C0", VA = "0x1871DFDC0")]
	public bool KDDEPIFHJOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x71E0780", Offset = "0x71DEF80", VA = "0x1871E0780")]
	public bool NBFKDCLKPPI(int POAAACAIHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x71DDE20", Offset = "0x71DC620", VA = "0x1871DDE20")]
	public bool AOJKJODFAHP(int POAAACAIHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x71DFB60", Offset = "0x71DE360", VA = "0x1871DFB60")]
	public bool IGBHDBKAOEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x71E0D10", Offset = "0x71DF510", VA = "0x1871E0D10")]
	public void ONHHCCACMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x71DE500", Offset = "0x71DCD00", VA = "0x1871DE500")]
	public bool DHPFEAFCEGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x71DE430", Offset = "0x71DCC30", VA = "0x1871DE430")]
	public bool CDACEGMOEJP(int POAAACAIHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x71DE140", Offset = "0x71DC940", VA = "0x1871DE140")]
	public bool BNLEAJBDJNM(int POAAACAIHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x71E0330", Offset = "0x71DEB30", VA = "0x1871E0330")]
	public bool LOGDELEBIEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x71DF400", Offset = "0x71DDC00", VA = "0x1871DF400")]
	public void FGLLKPLMBKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x71DF950", Offset = "0x71DE150", VA = "0x1871DF950")]
	public bool HKDECPGEDFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x71DF7B0", Offset = "0x71DDFB0", VA = "0x1871DF7B0")]
	public void GLJFMOBBIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x71DE710", Offset = "0x71DCF10", VA = "0x1871DE710")]
	private void EPBEBIIHFMF([Out] byte[] KLKECDGAKLI, [Out] int FMDPJEIIAJG, [Out] int HNLLAHNFPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x71DFE50", Offset = "0x71DE650", VA = "0x1871DFE50")]
	private static int KIKFEBFPOJJ(char NKCCEIKLOPK, char ICPBHPBDLLK, char FFEGACHBGBH, char NENJINMAAOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x71DE590", Offset = "0x71DCD90", VA = "0x1871DE590")]
	private static int EBLEFPAEOMI(char PNGIKMLKECD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x71E0850", Offset = "0x71DF050", VA = "0x1871E0850")]
	public ArraySegment<byte> NFNEEFFFIHM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x71DF6D0", Offset = "0x71DDED0", VA = "0x1871DF6D0")]
	public string GLBIBGNGABI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x71DFD50", Offset = "0x71DE550", VA = "0x1871DFD50")]
	public string JEJFEIFHALN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x71DE210", Offset = "0x71DCA10", VA = "0x1871DE210")]
	public ArraySegment<byte> CAHKKHJCHDM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x71E09F0", Offset = "0x71DF1F0", VA = "0x1871E09F0")]
	public ArraySegment<byte> NNAHDMHHPEG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x71DDEF0", Offset = "0x71DC6F0", VA = "0x1871DDEF0")]
	public bool BKNEHDEHFKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x71DF4A0", Offset = "0x71DDCA0", VA = "0x1871DF4A0")]
	private static bool FHOJBKJFDCL(byte FFEGACHBGBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x71E04E0", Offset = "0x71DECE0", VA = "0x1871E04E0")]
	private void MLJMEEBGFCJ(ENNEPPHLCPB OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x71E0730", Offset = "0x71DEF30", VA = "0x1871E0730")]
	public void MPNKDLKBJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x71DFBF0", Offset = "0x71DE3F0", VA = "0x1871DFBF0")]
	private void JAHDAGNCGGD(int EBLLCAPJMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x71E0E50", Offset = "0x71DF650", VA = "0x1871E0E50")]
	public sbyte PMPBEHANPBP()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x71DF9E0", Offset = "0x71DE1E0", VA = "0x1871DF9E0")]
	public short HNDDCOLPIHM()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x71E0B20", Offset = "0x71DF320", VA = "0x1871E0B20")]
	public int OHFGKMKMHAI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x71E0270", Offset = "0x71DEA70", VA = "0x1871E0270")]
	public long LMEBMEHCHCP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x71E0970", Offset = "0x71DF170", VA = "0x1871E0970")]
	public byte NJOAOFMNBJI()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x71E0C90", Offset = "0x71DF490", VA = "0x1871E0C90")]
	public ushort OMFEPHGCODH()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x71E0DD0", Offset = "0x71DF5D0", VA = "0x1871E0DD0")]
	public uint PKMJGCJOBBA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x71E0A60", Offset = "0x71DF260", VA = "0x1871E0A60")]
	public ulong ODGMDJHPLAE()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x71DFA60", Offset = "0x71DE260", VA = "0x1871DFA60")]
	public float IFCCKMGFFCC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x71DF850", Offset = "0x71DE050", VA = "0x1871DF850")]
	public double HFDDEIPMOIG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x71E0ED0", Offset = "0x71DF6D0", VA = "0x1871E0ED0")]
	public ArraySegment<byte> POIHDEPEPIA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x71DF560", Offset = "0x71DDD60", VA = "0x1871DF560")]
	private static int GGPFBENOAAB(byte[] GHFEJDPMJDG, int MFLLOPOPNNG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GHDGFMPCGGL : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference HCPGHIKJBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int CABCMGBCFCB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int FHAALGCKALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xD85A70", Offset = "0xD84270", VA = "0x180D85A70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string PJPDKIHNEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x991AB0", Offset = "0x9902B0", VA = "0x180991AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x71DC2F0", Offset = "0x71DAAF0", VA = "0x1871DC2F0")]
	public GHDGFMPCGGL(string CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x71DC350", Offset = "0x71DAB50", VA = "0x1871DC350")]
	public GHDGFMPCGGL(string CLBGCJICGJG, byte[] AEKHMFMLBDK, int MFLLOPOPNNG, int CABCMGBCFCB, string LIJNGMHDBIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class PMIKNNDIGJA
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class GEMLIBEBFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] PAJEBKJPIBK;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x71DC250", Offset = "0x71DAA50", VA = "0x1871DC250")]
		public static byte[] KBCPNGJGFNM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class LPNCNKGAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void CEKECKPKOFP(DPHIKHGFLNL COHNONCDMOG, object IPHHABIKCHD, JOEIFIPPNIH MNDKJGJCMCI);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object OGJKCMGBLAM(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH MNDKJGJCMCI);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class GCIGGBHGHGG
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class GEMJJODDADN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
				public GEMJJODDADN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x56F5AD0", Offset = "0x56F42D0", VA = "0x1856F5AD0")]
				internal bool NEAFNCBOFNB(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x71DC090", Offset = "0x71DA890", VA = "0x1871DC090")]
				internal bool MDFFJBFEMCE(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, JOEIFIPPNIH, byte[]> HPBMDKHDPNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, JOEIFIPPNIH> CNDLBIKABPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly CEKECKPKOFP LCEFGOFLNNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, JOEIFIPPNIH, ArraySegment<byte>> GJHPGKPAMFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, JOEIFIPPNIH, string> NCJGACCOMCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, JOEIFIPPNIH, object> BKBNHBHMIHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, JOEIFIPPNIH, object> BFDDJOFJCPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, JOEIFIPPNIH, object> GILIEACMNOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly OGJKCMGBLAM BJPHPLPFGNJ;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x71DA540", Offset = "0x71D8D40", VA = "0x1871DA540")]
			public GCIGGBHGHGG(Type HKAKMPIMEOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x3125390", Offset = "0x3123B90", VA = "0x183125390")]
			private static T MGKANKPKJJN<T>(DynamicMethod EGHDEBHAJAH)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x71DA2F0", Offset = "0x71D8AF0", VA = "0x1871DA2F0")]
			private static MethodInfo DHJPNPLODIJ(Type HKAKMPIMEOA, string GCDLMFGKKMH, Type[] AOKLANFDLBI)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, GCIGGBHGHGG> BDHFJFINHAP;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly LFMNOCKENDF<GCIGGBHGHGG> HNHHPFOCHEN;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x71E2F50", Offset = "0x71E1750", VA = "0x1871E2F50")]
		static LPNCNKGAJDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x71E2C50", Offset = "0x71E1450", VA = "0x1871E2C50")]
		private static GCIGGBHGHGG CDLJBHELEOK(Type HKAKMPIMEOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x71E2CD0", Offset = "0x71E14D0", VA = "0x1871E2CD0")]
		public static void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, object IPHHABIKCHD, JOEIFIPPNIH MNDKJGJCMCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x71E2E50", Offset = "0x71E1650", VA = "0x1871E2E50")]
		public static void HNAIEAEAFJH(Type HKAKMPIMEOA, DPHIKHGFLNL COHNONCDMOG, object IPHHABIKCHD, JOEIFIPPNIH MNDKJGJCMCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static JOEIFIPPNIH MOOHPPHHHEC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] MLLEKBHNNAA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] FPPBEOAFGFB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static JOEIFIPPNIH OBPGILFMCAA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x71EBB40", Offset = "0x71EA340", VA = "0x1871EBB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool ICIDCBOPNAK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x71ECDF0", Offset = "0x71EB5F0", VA = "0x1871ECDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x71EC910", Offset = "0x71EB110", VA = "0x1871EC910")]
	public static void GGFMNPHLMMM(JOEIFIPPNIH MNDKJGJCMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2C68240", Offset = "0x2C66A40", VA = "0x182C68240")]
	public static byte[] HNAIEAEAFJH<T>(T GHDJADLHPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2C680B0", Offset = "0x2C668B0", VA = "0x182C680B0")]
	public static byte[] HNAIEAEAFJH<T>(T IPHHABIKCHD, JOEIFIPPNIH MNDKJGJCMCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2C68430", Offset = "0x2C66C30", VA = "0x182C68430")]
	public static void HNAIEAEAFJH<T>(DPHIKHGFLNL COHNONCDMOG, T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2C68600", Offset = "0x2C66E00", VA = "0x182C68600")]
	public static void HNAIEAEAFJH<T>(DPHIKHGFLNL COHNONCDMOG, T IPHHABIKCHD, JOEIFIPPNIH MNDKJGJCMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2C684D0", Offset = "0x2C66CD0", VA = "0x182C684D0")]
	public static void HNAIEAEAFJH<T>(Stream JMDMENEIBHM, T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2C682E0", Offset = "0x2C66AE0", VA = "0x182C682E0")]
	public static void HNAIEAEAFJH<T>(Stream JMDMENEIBHM, T IPHHABIKCHD, JOEIFIPPNIH MNDKJGJCMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2C68880", Offset = "0x2C67080", VA = "0x182C68880")]
	public static ArraySegment<byte> MHANMODIPCH<T>(T GHDJADLHPAA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2C68920", Offset = "0x2C67120", VA = "0x182C68920")]
	public static ArraySegment<byte> MHANMODIPCH<T>(T IPHHABIKCHD, JOEIFIPPNIH MNDKJGJCMCI)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2C67E90", Offset = "0x2C66690", VA = "0x182C67E90")]
	public static string HBCGDAJODPP<T>(T IPHHABIKCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2C67F20", Offset = "0x2C66720", VA = "0x182C67F20")]
	public static string HBCGDAJODPP<T>(T IPHHABIKCHD, JOEIFIPPNIH MNDKJGJCMCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2C69950", Offset = "0x2C68150", VA = "0x182C69950")]
	public static T PKPMANIAHDL<T>(string LAJIOACGHEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2C699E0", Offset = "0x2C681E0", VA = "0x182C699E0")]
	public static T PKPMANIAHDL<T>(string LAJIOACGHEE, JOEIFIPPNIH MNDKJGJCMCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2C69470", Offset = "0x2C67C70", VA = "0x182C69470")]
	public static T PKPMANIAHDL<T>(byte[] GHFEJDPMJDG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2C69510", Offset = "0x2C67D10", VA = "0x182C69510")]
	public static T PKPMANIAHDL<T>(byte[] GHFEJDPMJDG, JOEIFIPPNIH MNDKJGJCMCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2C69AC0", Offset = "0x2C682C0", VA = "0x182C69AC0")]
	public static T PKPMANIAHDL<T>(byte[] GHFEJDPMJDG, int MFLLOPOPNNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2C692D0", Offset = "0x2C67AD0", VA = "0x182C692D0")]
	public static T PKPMANIAHDL<T>(byte[] GHFEJDPMJDG, int MFLLOPOPNNG, JOEIFIPPNIH MNDKJGJCMCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2C698C0", Offset = "0x2C680C0", VA = "0x182C698C0")]
	public static T PKPMANIAHDL<T>(JHNPEGAMHPK PJOJHFLPHKO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2C695C0", Offset = "0x2C67DC0", VA = "0x182C695C0")]
	public static T PKPMANIAHDL<T>(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH MNDKJGJCMCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2C69BF0", Offset = "0x2C683F0", VA = "0x182C69BF0")]
	public static T PKPMANIAHDL<T>(Stream JMDMENEIBHM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2C69C80", Offset = "0x2C68480", VA = "0x182C69C80")]
	public static T PKPMANIAHDL<T>(Stream JMDMENEIBHM, JOEIFIPPNIH MNDKJGJCMCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x71EBD70", Offset = "0x71EA570", VA = "0x1871EBD70")]
	public static string DIDNCGJKIJB(byte[] LAJIOACGHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x71EBC30", Offset = "0x71EA430", VA = "0x1871EBC30")]
	public static string DIDNCGJKIJB(byte[] LAJIOACGHEE, int MFLLOPOPNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x71EBED0", Offset = "0x71EA6D0", VA = "0x1871EBED0")]
	public static string DIDNCGJKIJB(string LAJIOACGHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x71EC980", Offset = "0x71EB180", VA = "0x1871EC980")]
	public static byte[] HCAJPLHJEIK(byte[] LAJIOACGHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x71ECCA0", Offset = "0x71EB4A0", VA = "0x1871ECCA0")]
	public static byte[] HCAJPLHJEIK(byte[] LAJIOACGHEE, int MFLLOPOPNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x71ECAF0", Offset = "0x71EB2F0", VA = "0x1871ECAF0")]
	public static byte[] HCAJPLHJEIK(string LAJIOACGHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x71EC060", Offset = "0x71EA860", VA = "0x1871EC060")]
	private static void DNHEPOFAGPI(JHNPEGAMHPK PJOJHFLPHKO, DPHIKHGFLNL COHNONCDMOG, int ONJLNAPAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x71ECE40", Offset = "0x71EB640", VA = "0x1871ECE40")]
	private static int OCGNFCCKFMO(Stream FDJIPPJKNDH, byte[] PAJEBKJPIBK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum ENNEPPHLCPB : byte
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
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DPHIKHGFLNL
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] LDHBNMHCBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] PAJEBKJPIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int MFLLOPOPNNG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DKBOCECCAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1F5C7A0", Offset = "0x1F5AFA0", VA = "0x181F5C7A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x71D9E10", Offset = "0x71D8610", VA = "0x1871D9E10")]
	public void PDHJGFHJFAB(int MFLLOPOPNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x71D8D10", Offset = "0x71D7510", VA = "0x1871D8D10")]
	public static byte[] APMPOJHMOKL(string FBCHOEIGMMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x71D8BA0", Offset = "0x71D73A0", VA = "0x1871D8BA0")]
	public static byte[] AILFMKELJID(string FBCHOEIGMMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x71D9960", Offset = "0x71D8160", VA = "0x1871D9960")]
	public static byte[] MHEDOJJHCFI(string FBCHOEIGMMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x71D8EC0", Offset = "0x71D76C0", VA = "0x1871D8EC0")]
	public static byte[] DMJLKJBMDJO(string FBCHOEIGMMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D18D60", Offset = "0x5D17560", VA = "0x185D18D60")]
	public DPHIKHGFLNL(byte[] HCHLHEEPONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x71D93E0", Offset = "0x71D7BE0", VA = "0x1871D93E0")]
	public ArraySegment<byte> KBCPNGJGFNM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x71D9810", Offset = "0x71D8010", VA = "0x1871D9810")]
	public byte[] KOLBKDOEPMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x71D9F80", Offset = "0x71D8780", VA = "0x1871D9F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x71D98D0", Offset = "0x71D80D0", VA = "0x1871D98D0")]
	public void LJMMNFLBIKI(int DNAFGALNGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x71D9E80", Offset = "0x71D8680", VA = "0x1871D9E80")]
	public void POFONLGFOAC(byte IIMIKNCPIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x71D9E20", Offset = "0x71D8620", VA = "0x1871D9E20")]
	public void POFONLGFOAC(byte[] IIMIKNCPIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x71D8B60", Offset = "0x71D7360", VA = "0x1871D8B60")]
	public void AAIFNLEAEIK(byte IIMIKNCPIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x71D9B70", Offset = "0x71D8370", VA = "0x1871D9B70")]
	public void NDEOFHLDEMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x71D9DC0", Offset = "0x71D85C0", VA = "0x1871D9DC0")]
	public void PAIJDMDDGAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x71D9D20", Offset = "0x71D8520", VA = "0x1871D9D20")]
	public void OEOHBAOPCGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x71D8E40", Offset = "0x71D7640", VA = "0x1871D8E40")]
	public void BNEPCHOMJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x71D9880", Offset = "0x71D8080", VA = "0x1871D9880")]
	public void LJIMCAFAKJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x71D9390", Offset = "0x71D7B90", VA = "0x1871D9390")]
	public void IEOBHONMOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x71D9AD0", Offset = "0x71D82D0", VA = "0x1871D9AD0")]
	public void MNKLKMOKDLK(string FBCHOEIGMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x71D9D70", Offset = "0x71D8570", VA = "0x1871D9D70")]
	public void OPEDEKMHJAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x71D9EE0", Offset = "0x71D86E0", VA = "0x1871D9EE0")]
	public void POGLGEACPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x71D91C0", Offset = "0x71D79C0", VA = "0x1871D91C0")]
	public void GHIFOMFJNAD(bool IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x71D98E0", Offset = "0x71D80E0", VA = "0x1871D98E0")]
	public void MAIHNFKFAJK(float IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x71D9CA0", Offset = "0x71D84A0", VA = "0x1871D9CA0")]
	public void NHOELFCHNGE(double IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x71D9040", Offset = "0x71D7840", VA = "0x1871D9040")]
	public void EAIMCDGIOFG(byte IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x71D9320", Offset = "0x71D7B20", VA = "0x1871D9320")]
	public void GOAKODOCBIJ(ushort IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x71D9C30", Offset = "0x71D8430", VA = "0x1871D9C30")]
	public void NGFFCOJPMBK(uint IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x71D9190", Offset = "0x71D7990", VA = "0x1871D9190")]
	public void FMBGIECIKLK(ulong IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x71D9120", Offset = "0x71D7920", VA = "0x1871D9120")]
	public void EMAOBNOPEHL(sbyte IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x71D90B0", Offset = "0x71D78B0", VA = "0x1871D90B0")]
	public void EGLONODBHFE(short IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x71D9BC0", Offset = "0x71D83C0", VA = "0x1871D9BC0")]
	public void NDFBKCADJAF(int IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x71D8E90", Offset = "0x71D7690", VA = "0x1871D8E90")]
	public void CPOHOCALKKC(long IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x71D9480", Offset = "0x71D7C80", VA = "0x1871D9480")]
	public void KJOIHLDONOC(string IPHHABIKCHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class JFANNNLDCKE : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class JEBMNLCIFAA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3F75CB0", Offset = "0x3F744B0", VA = "0x183F75CB0")]
		static JEBMNLCIFAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private JFANNNLDCKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class DLKJJBBFCBF : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private static class FIFCCAPBIND<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE710", Offset = "0x3AECF10", VA = "0x183AEE710")]
		static FIFCCAPBIND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class DMNLNLCLBHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly Dictionary<Type, object> NDDJHEJAPKJ;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x71D6AC0", Offset = "0x71D52C0", VA = "0x1871D6AC0")]
		internal static object MJCKBNPEBNE(Type AFCJJMLHKMJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private DLKJJBBFCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class NIECOOEDMMJ : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private static class PNLJNDAMOJM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4679250", Offset = "0x4677A50", VA = "0x184679250")]
		static PNLJNDAMOJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly NIECOOEDMMJ DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static bool BJGHNNOPPAO;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static BNDBHHCFNCL[] OKHAGJHNMFE;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static JOEIFIPPNIH[] NNPAPBBNIOG;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private NIECOOEDMMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x71E3560", Offset = "0x71E1D60", VA = "0x1871E3560")]
	public static void MPPLGFJBDHC(params JOEIFIPPNIH[] NNPAPBBNIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x71E3480", Offset = "0x71E1C80", VA = "0x1871E3480")]
	public static void MPPLGFJBDHC(params BNDBHHCFNCL[] OKHAGJHNMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x71E3210", Offset = "0x71E1A10", VA = "0x1871E3210")]
	public static void KOMNPFHOONG(BNDBHHCFNCL[] OKHAGJHNMFE, JOEIFIPPNIH[] NNPAPBBNIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CMLKFFJEPCN : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private static class LHIAGMJKLMK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x414B430", Offset = "0x4149C30", VA = "0x18414B430")]
		static LHIAGMJKLMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private CMLKFFJEPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class KBLNPFBFLEK
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly JOEIFIPPNIH BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly JOEIFIPPNIH DPOPBKHAOBI;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly JOEIFIPPNIH MJEKJCKPDKF;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly JOEIFIPPNIH LGONAALFKPG;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly JOEIFIPPNIH CFGHPJGFMBD;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly JOEIFIPPNIH DCCIHAJNBGD;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly JOEIFIPPNIH NIEFNOBDMIB;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly JOEIFIPPNIH OPJNJCOHDEA;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly JOEIFIPPNIH BEGJCHNPNKE;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly JOEIFIPPNIH AMGOGKMIHGC;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly JOEIFIPPNIH ABMIHGJENOG;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly JOEIFIPPNIH LEKGBOOJMAK;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class DJNKKEOEHJE
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly JOEIFIPPNIH BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly JOEIFIPPNIH IEEGHAMKBKL;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class POPMBGEOAKA
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly JOEIFIPPNIH BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly JOEIFIPPNIH DPOPBKHAOBI;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly JOEIFIPPNIH MJEKJCKPDKF;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly JOEIFIPPNIH LGONAALFKPG;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly JOEIFIPPNIH CFGHPJGFMBD;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly JOEIFIPPNIH DCCIHAJNBGD;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly JOEIFIPPNIH NIEFNOBDMIB;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly JOEIFIPPNIH OPJNJCOHDEA;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly JOEIFIPPNIH BEGJCHNPNKE;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly JOEIFIPPNIH AMGOGKMIHGC;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly JOEIFIPPNIH ABMIHGJENOG;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly JOEIFIPPNIH LEKGBOOJMAK;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class DANBOLLPEOF
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly Dictionary<Type, Type> NDDJHEJAPKJ;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x71D4CA0", Offset = "0x71D34A0", VA = "0x1871D4CA0")]
	internal static object MJCKBNPEBNE(Type AFCJJMLHKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x71D4C60", Offset = "0x71D3460", VA = "0x1871D4C60")]
	private static object MDANFNCMAMP(Type HHIOEPFOGLG, Type[] AMKPNJDFFJK, params object[] AOKLANFDLBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class KBHMOJLCHHN : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class MKOFPMPMJGL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x437E630", Offset = "0x437CE30", VA = "0x18437E630")]
		static MKOFPMPMJGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Func<string, string> FIDBEHEADIG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly bool CGEBFOCCGJG;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly BBGLJLNEMOD OIEKCIBBLHN;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x71E14D0", Offset = "0x71DFCD0", VA = "0x1871E14D0")]
	static KBHMOJLCHHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private KBHMOJLCHHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class JOBNHDKCPNC : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class KNDHCEHIPMF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x40B5320", Offset = "0x40B3B20", VA = "0x1840B5320")]
		static KNDHCEHIPMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Func<string, string> FIDBEHEADIG;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly bool CGEBFOCCGJG;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly BBGLJLNEMOD OIEKCIBBLHN;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x71E1290", Offset = "0x71DFA90", VA = "0x1871E1290")]
	static JOBNHDKCPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private JOBNHDKCPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class BCIMECBFKKM : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class DMBNNMGIPOF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x57B2D50", Offset = "0x57B1550", VA = "0x1857B2D50")]
		static DMBNNMGIPOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Func<string, string> FIDBEHEADIG;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly bool CGEBFOCCGJG;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly BBGLJLNEMOD OIEKCIBBLHN;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x71D2ED0", Offset = "0x71D16D0", VA = "0x1871D2ED0")]
	static BCIMECBFKKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private BCIMECBFKKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class JCDNFLABNIM : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class MLMDCAJMHLM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x43AE520", Offset = "0x43ACD20", VA = "0x1843AE520")]
		static MLMDCAJMHLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly Func<string, string> FIDBEHEADIG;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly bool CGEBFOCCGJG;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly BBGLJLNEMOD OIEKCIBBLHN;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x71DD970", Offset = "0x71DC170", VA = "0x1871DD970")]
	static JCDNFLABNIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private JCDNFLABNIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class KPMNJANKHHK : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private static class EILOLNIAPOC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x375A6C0", Offset = "0x3758EC0", VA = "0x18375A6C0")]
		static EILOLNIAPOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly Func<string, string> FIDBEHEADIG;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly bool CGEBFOCCGJG;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly BBGLJLNEMOD OIEKCIBBLHN;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x71E2B00", Offset = "0x71E1300", VA = "0x1871E2B00")]
	static KPMNJANKHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private KPMNJANKHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class JDBEIFGFBFA : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class MMIDCDPMFFB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x43B4C50", Offset = "0x43B3450", VA = "0x1843B4C50")]
		static MMIDCDPMFFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Func<string, string> FIDBEHEADIG;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly bool CGEBFOCCGJG;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly BBGLJLNEMOD OIEKCIBBLHN;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x71DDAC0", Offset = "0x71DC2C0", VA = "0x1871DDAC0")]
	static JDBEIFGFBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private JDBEIFGFBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class PAADIDFBCED : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class GBPOALKPGEN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1FD0", Offset = "0x3BC07D0", VA = "0x183BC1FD0")]
		static GBPOALKPGEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static readonly Func<string, string> FIDBEHEADIG;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly bool CGEBFOCCGJG;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public PAADIDFBCED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class JPDBBLAJHML : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class CAKHIEOHKEE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4DD3710", Offset = "0x4DD1F10", VA = "0x184DD3710")]
		static CAKHIEOHKEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly Func<string, string> FIDBEHEADIG;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly bool CGEBFOCCGJG;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public JPDBBLAJHML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class GIHPKGEEEON : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class DJNPAAFOEBI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x576CFF0", Offset = "0x576B7F0", VA = "0x18576CFF0")]
		static DJNPAAFOEBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly Func<string, string> FIDBEHEADIG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly bool CGEBFOCCGJG;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public GIHPKGEEEON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class ELCLFAGEDDF : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class GELAGGABOOM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3BD13A0", Offset = "0x3BCFBA0", VA = "0x183BD13A0")]
		static GELAGGABOOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> FIDBEHEADIG;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool CGEBFOCCGJG;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public ELCLFAGEDDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class HANIGNJECIJ : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class BOJDAKLGEAL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4D48500", Offset = "0x4D46D00", VA = "0x184D48500")]
		static BOJDAKLGEAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly Func<string, string> FIDBEHEADIG;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly bool CGEBFOCCGJG;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public HANIGNJECIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class KCIGNIKGEDG : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class CLFEEHEHOKA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x50774B0", Offset = "0x5075CB0", VA = "0x1850774B0")]
		static CLFEEHEHOKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Func<string, string> FIDBEHEADIG;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly bool CGEBFOCCGJG;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public KCIGNIKGEDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal static class OBJKJDFNKJK
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct GLBLNACDKEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public FPPGIHMBACN ONIOPGHFANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LocalBuilder PINPHNBBIEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LocalBuilder JIOFLGKIEPP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal static class CKLGJOIJAIM
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class HJMOOPACLEK
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public static readonly MethodInfo MHEDOJJHCFI;

			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly MethodInfo AILFMKELJID;

			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public static readonly MethodInfo DMJLKJBMDJO;

			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public static readonly MethodInfo APMPOJHMOKL;

			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public static readonly MethodInfo POGLGEACPDK;

			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public static readonly MethodInfo POFONLGFOAC;

			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public static readonly MethodInfo OEOHBAOPCGM;

			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public static readonly MethodInfo BNEPCHOMJEC;

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly MethodInfo LJIMCAFAKJF;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x71DCB80", Offset = "0x71DB380", VA = "0x1871DCB80")]
			static HJMOOPACLEK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		internal static class KJNDGNEBAFD
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public static readonly MethodInfo LPCJDACFBOA;

			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly MethodInfo ONHHCCACMGJ;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly MethodInfo CDACEGMOEJP;

			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly MethodInfo GEMOJGHAJNP;

			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public static readonly MethodInfo MPNKDLKBJFJ;

			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public static readonly MethodInfo HHOCPGGOCLL;

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly MethodInfo PDHCKDFAKAI;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x71E1F60", Offset = "0x71E0760", VA = "0x1871E1F60")]
			static KJNDGNEBAFD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class HFHICMIEECE
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			internal static readonly MethodInfo LDFGMOPKEAN;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			internal static readonly MethodInfo DBFAGJCMLNG;
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly ConstructorInfo MCLLBPNDHEK;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly MethodInfo NEHALOPGLIL;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly ConstructorInfo JIPMPINPHLK;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly MethodInfo HJJJHPAONGD;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly MethodInfo CHDNFFBAIGL;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly MethodInfo ILANNHABEFD;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly MethodInfo DNEGINKLINH;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly MethodInfo ADDDJNEOHPD;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly MethodInfo CMLJBLDOCLA;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly MethodInfo KEGAOIBBKGJ;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly MethodInfo IPMABHMAKMM;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly MethodInfo MNHLBBKPBHO;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x71D3020", Offset = "0x71D1820", VA = "0x1871D3020")]
		public static MethodInfo HNAIEAEAFJH(Type HKAKMPIMEOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x71D33F0", Offset = "0x71D1BF0", VA = "0x1871D33F0")]
		public static MethodInfo PKPMANIAHDL(Type HKAKMPIMEOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x71D32B0", Offset = "0x71D1AB0", VA = "0x1871D32B0")]
		public static MethodInfo KJCHJJHNENI(Type HKAKMPIMEOA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class BGCBAEPHIIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Dictionary<FPPGIHMBACN, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public BGCBAEPHIIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class ALHIFBGAKAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public BGCBAEPHIIC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public ALHIFBGAKAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x71D2D20", Offset = "0x71D1520", VA = "0x1871D2D20")]
		internal void PAFLPGDHPCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x71D2C80", Offset = "0x71D1480", VA = "0x1871D2C80")]
		internal bool IJNMPMPINNK(int index, FPPGIHMBACN member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class ACHIEFDFIBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public BGCBAEPHIIC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public ACHIEFDFIBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x71D2BE0", Offset = "0x71D13E0", VA = "0x1871D2BE0")]
		internal bool HGCCPHJCJGJ(int index, FPPGIHMBACN member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class HKKMDEHHBLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Func<string, string> nameMutator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public List<object> serializeCustomFormatters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<object> deserializeCustomFormatters;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HKKMDEHHBLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3B9CB30", Offset = "0x3B9B330", VA = "0x183B9CB30")]
		internal string HOGIIKMDIIC(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class DGNFGHGCHFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public DGNFGHGCHFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x71D6920", Offset = "0x71D5120", VA = "0x1871D6920")]
		internal bool MLKIPLJLJFA(FPPGIHMBACN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class KGAPGOEDPDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public HKKMDEHHBLC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KGAPGOEDPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x71E1F50", Offset = "0x71E0750", VA = "0x1871E1F50")]
		internal void LLJMCDNJLIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x71E1DD0", Offset = "0x71E05D0", VA = "0x1871E1DD0")]
		internal bool ADEDEFFECJA(int index, FPPGIHMBACN member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class MMNGFPGMMMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public HKKMDEHHBLC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public MMNGFPGMMMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x71E3090", Offset = "0x71E1890", VA = "0x1871E3090")]
		internal bool LPDEFFICHED(int index, FPPGIHMBACN member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class HFPHPJNPLEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HFPHPJNPLEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x71DCB50", Offset = "0x71DB350", VA = "0x1871DCB50")]
		internal Label DIMBALLDJJH(FPPGIHMBACN _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class HEEHIJBIALB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public GLBLNACDKEL[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Func<int, FPPGIHMBACN, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public GKANNOLGIPO argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public GKANNOLGIPO argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HEEHIJBIALB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x71DC690", Offset = "0x71DAE90", VA = "0x1871DC690")]
		internal GLBLNACDKEL LCECJPCJEEK(FPPGIHMBACN item)
		{
			return default(GLBLNACDKEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class DPFMKGDFJDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public HEEHIJBIALB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public DPFMKGDFJDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x71D8840", Offset = "0x71D7040", VA = "0x1871D8840")]
		internal void DGJIFJLHMIA(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x71D8AD0", Offset = "0x71D72D0", VA = "0x1871D8AD0")]
		internal void MLMIOCGLNGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class NPJCDEHFIBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public FPPGIHMBACN item;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public NPJCDEHFIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xCEAA20", Offset = "0xCE9220", VA = "0x180CEAA20")]
		internal bool BHMGNMMHCDO(GLBLNACDKEL x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class DMBAOEBFIOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public FPPGIHMBACN item;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public DMBAOEBFIOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xCEAA20", Offset = "0xCE9220", VA = "0x180CEAA20")]
		internal bool HBOFKJLHOHL(GLBLNACDKEL x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly Regex BEJNLPLCNKJ;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int DLFKIDNAPHH;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static HashSet<Type> PDBLGDOCDGK;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static HashSet<Type> MCGPDOPMLNP;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C24910", Offset = "0x2C23110", VA = "0x182C24910")]
	public static object INKJPJEENNN<T>(BBGLJLNEMOD OIEKCIBBLHN, JOEIFIPPNIH HIONGPHGKGO, Func<string, string> FIDBEHEADIG, bool CGEBFOCCGJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2C06740", Offset = "0x2C04F40", VA = "0x182C06740")]
	public static object GJGCEIFIAHN<T>(JOEIFIPPNIH HIONGPHGKGO, Func<string, string> FIDBEHEADIG, bool CGEBFOCCGJG, bool ECNNCIHLCJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x71E3740", Offset = "0x71E1F40", VA = "0x1871E3740")]
	private static TypeInfo DHDHFDCGAFN(BBGLJLNEMOD OIEKCIBBLHN, Type HKAKMPIMEOA, Func<string, string> FIDBEHEADIG, bool CGEBFOCCGJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x71E64E0", Offset = "0x71E4CE0", VA = "0x1871E64E0")]
	public static object HGKNDOCHNHL(Type HKAKMPIMEOA, Func<string, string> FIDBEHEADIG, bool CGEBFOCCGJG, bool ECNNCIHLCJE, bool NIDLJLGHKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x71E4160", Offset = "0x71E2960", VA = "0x1871E4160")]
	private static Dictionary<FPPGIHMBACN, FieldInfo> DIPKKICBPFM(TypeBuilder BDDEMMFPEGG, PIGDMAINOBM HIAJCEJJCOE, ConstructorInfo KLGJKLPJJAN, FieldBuilder DMCKABMNGMA, ILGenerator NBFEIBNEKBC, bool CGEBFOCCGJG, bool LJOCIHHFHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x71E4850", Offset = "0x71E3050", VA = "0x1871E4850")]
	private static Dictionary<FPPGIHMBACN, FieldInfo> DKLFDOKLMCD(TypeBuilder BDDEMMFPEGG, PIGDMAINOBM HIAJCEJJCOE, ILGenerator NBFEIBNEKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x71E4F00", Offset = "0x71E3700", VA = "0x1871E4F00")]
	private static void FILCKBKENBK(Type HKAKMPIMEOA, PIGDMAINOBM HIAJCEJJCOE, ILGenerator NBFEIBNEKBC, Action EAHALOPFPIM, Func<int, FPPGIHMBACN, bool> CCDFADGEFEK, bool CGEBFOCCGJG, bool LJOCIHHFHDC, int CJLJOHMIJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x71E8F00", Offset = "0x71E7700", VA = "0x1871E8F00")]
	private static void LPOLEOMFHGA(TypeInfo HKAKMPIMEOA, FPPGIHMBACN GMNIAJIHHDF, ILGenerator NBFEIBNEKBC, int JBDLDJOINOF, Func<int, FPPGIHMBACN, bool> CCDFADGEFEK, GKANNOLGIPO COHNONCDMOG, GKANNOLGIPO GDAHKDDCIHM, GKANNOLGIPO IAALHPOGJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x71E9AF0", Offset = "0x71E82F0", VA = "0x1871E9AF0")]
	private static void OECJKOMNCGI(Type HKAKMPIMEOA, PIGDMAINOBM HIAJCEJJCOE, ILGenerator NBFEIBNEKBC, Func<int, FPPGIHMBACN, bool> CCDFADGEFEK, bool HOOJJJAPANL, int CJLJOHMIJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x71EAF30", Offset = "0x71E9730", VA = "0x1871EAF30")]
	private static void POECCJJEAMD(ILGenerator NBFEIBNEKBC, GLBLNACDKEL HIAJCEJJCOE, int JBDLDJOINOF, Func<int, FPPGIHMBACN, bool> CCDFADGEFEK, GKANNOLGIPO PJOJHFLPHKO, GKANNOLGIPO IAALHPOGJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x71E8030", Offset = "0x71E6830", VA = "0x1871E8030")]
	private static LocalBuilder HKDNCIHOLDH(ILGenerator NBFEIBNEKBC, Type HKAKMPIMEOA, PIGDMAINOBM HIAJCEJJCOE, GLBLNACDKEL[] BGFHLPECAHN, bool LONFHAHMLKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x71E9430", Offset = "0x71E7C30", VA = "0x1871E9430")]
	private static bool NELFDKPLMHG(ConstructorInfo GHOAPOOKACE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x71E8D80", Offset = "0x71E7580", VA = "0x1871E8D80")]
	private static bool JJNILANFLPK(Type HKAKMPIMEOA, [Out] Type OMCGGOKGBLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal delegate void BCIAPJAPAMD<T>(byte[][] DMCKABMNGMA, object[] FOHAOGBLBEC, DPHIKHGFLNL COHNONCDMOG, T IPHHABIKCHD, JOEIFIPPNIH MNDKJGJCMCI);
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal delegate T LFELOOEIGID<T>(object[] FOHAOGBLBEC, JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH MNDKJGJCMCI);
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class CGPGBEJBLPL<T> : BMLPDKFJOPL<T>, BNDBHHCFNCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly byte[][] DMCKABMNGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly object[] BNPAOPFNNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly object[] MNEELFDCFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly BCIAPJAPAMD<T> HBJJJFBIMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly LFELOOEIGID<T> DPFFPLHELHO;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1F039B0", Offset = "0x1F021B0", VA = "0x181F039B0")]
	public CGPGBEJBLPL(byte[][] DMCKABMNGMA, object[] BNPAOPFNNEP, object[] MNEELFDCFGF, BCIAPJAPAMD<T> HBJJJFBIMFP, LFELOOEIGID<T> DPFFPLHELHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4F85A30", Offset = "0x4F84230", VA = "0x184F85A30", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, T IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4F85B30", Offset = "0x4F84330", VA = "0x184F85B30", Slot = "5")]
	public T PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class HCBAJJAONDM : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private static class JCFDHIOMIGP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3F6DBA0", Offset = "0x3F6C3A0", VA = "0x183F6DBA0")]
		static JCFDHIOMIGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private HCBAJJAONDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class IMAGFNCEOFF : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private static class FOCNECNFPCM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3B13890", Offset = "0x3B12090", VA = "0x183B13890")]
		static FOCNECNFPCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private IMAGFNCEOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal static class PNPFMGOFHAO
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	internal static readonly JOEIFIPPNIH[] LNMFNJKCKKC;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal sealed class JELGCHDCAAI : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private static class CGKGELBJOPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4F83630", Offset = "0x4F81E30", VA = "0x184F83630")]
		static CGKGELBJOPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private sealed class EIKMDPHILOB : JOEIFIPPNIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private static class MLCKLELDNOF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x43833A0", Offset = "0x4381BA0", VA = "0x1843833A0")]
			static MLCKLELDNOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private static readonly JOEIFIPPNIH[] NNPAPBBNIOG;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private EIKMDPHILOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
		public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly BMLPDKFJOPL<object> CCDEHFDMCOI;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private JELGCHDCAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class BCICJBPECOP : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class MJGLAOOACGG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4371BC0", Offset = "0x43703C0", VA = "0x184371BC0")]
		static MJGLAOOACGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private sealed class HFJKOPHCFAC : JOEIFIPPNIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		private static class OKKHOPHFFDG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x4585BD0", Offset = "0x45843D0", VA = "0x184585BD0")]
			static OKKHOPHFFDG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly JOEIFIPPNIH[] NNPAPBBNIOG;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private HFJKOPHCFAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
		public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly BMLPDKFJOPL<object> CCDEHFDMCOI;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private BCICJBPECOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class ACALCPOFEDJ : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class DIJGNHPDHKP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x575F7A0", Offset = "0x575DFA0", VA = "0x18575F7A0")]
		static DIJGNHPDHKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class LDAKGHLCLNN : JOEIFIPPNIH
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		private static class PNIFJMFLNCF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4672680", Offset = "0x4670E80", VA = "0x184672680")]
			static PNIFJMFLNCF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly JOEIFIPPNIH[] NNPAPBBNIOG;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private LDAKGHLCLNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
		public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly BMLPDKFJOPL<object> CCDEHFDMCOI;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private ACALCPOFEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class HNGFCDHMEHF : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private static class HBPEOMJOJPE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3C77E10", Offset = "0x3C76610", VA = "0x183C77E10")]
		static HBPEOMJOJPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private sealed class MFAJGLCLCNP : JOEIFIPPNIH
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private static class OKCHFHPEDMG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x45829C0", Offset = "0x45811C0", VA = "0x1845829C0")]
			static OKCHFHPEDMG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly JOEIFIPPNIH[] NNPAPBBNIOG;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private MFAJGLCLCNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
		public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly BMLPDKFJOPL<object> CCDEHFDMCOI;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private HNGFCDHMEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class KFJIJBAOHEH : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private static class EGDGPCDDOOH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x374BD10", Offset = "0x374A510", VA = "0x18374BD10")]
		static EGDGPCDDOOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private sealed class JJKPNNDJKBP : JOEIFIPPNIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		private static class LOAHHOFCMGB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x4169530", Offset = "0x4167D30", VA = "0x184169530")]
			static LOAHHOFCMGB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly JOEIFIPPNIH[] NNPAPBBNIOG;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private JJKPNNDJKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
		public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly BMLPDKFJOPL<object> CCDEHFDMCOI;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private KFJIJBAOHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal sealed class HOKFCMDDGOF : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private static class PNLOFAGDPPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x4681B90", Offset = "0x4680390", VA = "0x184681B90")]
		static PNLOFAGDPPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class GGONOFABNPB : JOEIFIPPNIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		private static class GMPGCJDGNCE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3C1EDC0", Offset = "0x3C1D5C0", VA = "0x183C1EDC0")]
			static GMPGCJDGNCE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly JOEIFIPPNIH[] NNPAPBBNIOG;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private GGONOFABNPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
		public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly BMLPDKFJOPL<object> CCDEHFDMCOI;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private HOKFCMDDGOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class MCKEHOGLHAJ : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private static class DAOOMPOFPOJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x56DC7D0", Offset = "0x56DAFD0", VA = "0x1856DC7D0")]
		static DAOOMPOFPOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class ACDPGNBIOMD : JOEIFIPPNIH
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		private static class JDCOHLFHEPK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3F728F0", Offset = "0x3F710F0", VA = "0x183F728F0")]
			static JDCOHLFHEPK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly JOEIFIPPNIH[] NNPAPBBNIOG;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private ACDPGNBIOMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
		public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly BMLPDKFJOPL<object> CCDEHFDMCOI;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private MCKEHOGLHAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class AAHFDPHAPEP : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private static class NKLALAEJFFJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x445CE70", Offset = "0x445B670", VA = "0x18445CE70")]
		static NKLALAEJFFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class AKFADJBGJHK : JOEIFIPPNIH
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		private static class KHICDLAENGM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x4097B60", Offset = "0x4096360", VA = "0x184097B60")]
			static KHICDLAENGM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly JOEIFIPPNIH[] NNPAPBBNIOG;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private AKFADJBGJHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
		public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly BMLPDKFJOPL<object> CCDEHFDMCOI;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private AAHFDPHAPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class LDELPBDIMLG : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private static class EMEFGJLDKOL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3761390", Offset = "0x375FB90", VA = "0x183761390")]
		static EMEFGJLDKOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private sealed class CHMFLPIHDBE : JOEIFIPPNIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		private static class MCFMJFIOMIO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x433EFB0", Offset = "0x433D7B0", VA = "0x18433EFB0")]
			static MCFMJFIOMIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly JOEIFIPPNIH[] NNPAPBBNIOG;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private CHMFLPIHDBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
		public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly BMLPDKFJOPL<object> CCDEHFDMCOI;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private LDELPBDIMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal sealed class MCEDLGPEGDC : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private static class BNHGNMBPKHG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4D3FD10", Offset = "0x4D3E510", VA = "0x184D3FD10")]
		static BNHGNMBPKHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private sealed class FLEKGCJADJC : JOEIFIPPNIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		private static class GNDBAHKBHGL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3C21B20", Offset = "0x3C20320", VA = "0x183C21B20")]
			static GNDBAHKBHGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly JOEIFIPPNIH[] NNPAPBBNIOG;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private FLEKGCJADJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
		public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly BMLPDKFJOPL<object> CCDEHFDMCOI;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private MCEDLGPEGDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal sealed class BEENHBDJGCH : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private static class CFGNKIKMOBG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4F77C70", Offset = "0x4F76470", VA = "0x184F77C70")]
		static CFGNKIKMOBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private sealed class BOGDAACOLEH : JOEIFIPPNIH
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private static class BOBCFEDMHBC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x4D44270", Offset = "0x4D42A70", VA = "0x184D44270")]
			static BOBCFEDMHBC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly JOEIFIPPNIH[] NNPAPBBNIOG;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private BOGDAACOLEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
		public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly BMLPDKFJOPL<object> CCDEHFDMCOI;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private BEENHBDJGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal sealed class NOLNNBKBMMF : JOEIFIPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private static class OBAEOCAEIEH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4539950", Offset = "0x4538150", VA = "0x184539950")]
		static OBAEOCAEIEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private sealed class PJPGFJDLBIP : JOEIFIPPNIH
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private static class MPJPCLPIKPD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly BMLPDKFJOPL<T> GCFCPGAMOOK;

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x43C5390", Offset = "0x43C3B90", VA = "0x1843C5390")]
			static MPJPCLPIKPD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly JOEIFIPPNIH[] NNPAPBBNIOG;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private PJPGFJDLBIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
		public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly JOEIFIPPNIH DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly BMLPDKFJOPL<object> CCDEHFDMCOI;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	private NOLNNBKBMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	public BMLPDKFJOPL<T> MJCKBNPEBNE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct HMEKIKLAOML<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public T[] GMLFJLMDIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public int JAFNMFMLFDO;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3CB39F0", Offset = "0x3CB21F0", VA = "0x183CB39F0")]
	public HMEKIKLAOML(int LONGIHLPAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3CB35B0", Offset = "0x3CB1DB0", VA = "0x183CB35B0")]
	public void CNLMKNIMMKA(T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3CB3960", Offset = "0x3CB2160", VA = "0x183CB3960")]
	public T[] HOEFGKOEDJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class OFPDPKAPCLI : HKDEIMGAKPB<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly OFPDPKAPCLI BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x72002B0", Offset = "0x71FEAB0", VA = "0x1872002B0")]
	public OFPDPKAPCLI(int KHHLKFOJJJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal class HKDEIMGAKPB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly int KHHLKFOJJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly object IOAPKNACHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int JBDLDJOINOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private T[][] CFPOKPFOAGO;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3CAF5D0", Offset = "0x3CADDD0", VA = "0x183CAF5D0")]
	public HKDEIMGAKPB(int KHHLKFOJJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3CAEFD0", Offset = "0x3CAD7D0", VA = "0x183CAEFD0")]
	public T[] FLDPCIOFABA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3CAF210", Offset = "0x3CADA10", VA = "0x183CAF210")]
	public void KIOKOBOCCCO(T[] JAOFFCELONG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class FGNFHJHBHAN : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class LFOJIKJJGOK : IComparable<LFOJIKJJGOK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class CHDPIIPEBMP : IEnumerable<LFOJIKJJGOK>, IEnumerable, IEnumerator<LFOJIKJJGOK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private LFOJIKJJGOK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public LFOJIKJJGOK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private LFOJIKJJGOK System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x898540", Offset = "0x896D40", VA = "0x180898540")]
			[DebuggerHidden]
			public CHDPIIPEBMP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x71F24D0", Offset = "0x71F0CD0", VA = "0x1871F24D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x71F2600", Offset = "0x71F0E00", VA = "0x1871F2600", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x71F2550", Offset = "0x71F0D50", VA = "0x1871F2550", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<LFOJIKJJGOK> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x71F2550", Offset = "0x71F0D50", VA = "0x1871F2550", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class JOFIFGABDNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public JOFIFGABDNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x71DCB50", Offset = "0x71DB350", VA = "0x1871DCB50")]
			internal Label BEOKDKIMPKL(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x71DCB50", Offset = "0x71DB350", VA = "0x1871DCB50")]
			internal Label NFAGGNACCLP(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static readonly LFOJIKJJGOK[] OKHBNLPCNGB;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly ulong[] CNFLKMJHNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ulong PJOIFALPHGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int JDDKPJKLOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string JGCPEIBKOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private LFOJIKJJGOK[] KAOAHJPDKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private ulong[] GFJHFILJIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int POAAACAIHKJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool JBAJEMKHCHO
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5A2EDB0", Offset = "0x5A2D5B0", VA = "0x185A2EDB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x71FD220", Offset = "0x71FBA20", VA = "0x1871FD220")]
		public LFOJIKJJGOK(ulong JOEHGGMHBAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x71FBCD0", Offset = "0x71FA4D0", VA = "0x1871FBCD0")]
		public LFOJIKJJGOK CNLMKNIMMKA(ulong JOEHGGMHBAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x71FBED0", Offset = "0x71FA6D0", VA = "0x1871FBED0")]
		public LFOJIKJJGOK CNLMKNIMMKA(ulong JOEHGGMHBAA, int IPHHABIKCHD, string JGCPEIBKOJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x71FD000", Offset = "0x71FB800", VA = "0x1871FD000")]
		public LFOJIKJJGOK LHKFENMFCAM(byte[] IGEIIMLGHIC, int MFLLOPOPNNG, int MENHFNLCAJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x71FBC40", Offset = "0x71FA440", VA = "0x1871FBC40")]
		internal static int BEGNAHBFAHC(ulong[] JAOFFCELONG, int JBDLDJOINOF, int IDGMEKAEIMD, ulong IPHHABIKCHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x71FBF30", Offset = "0x71FA730", VA = "0x1871FBF30", Slot = "4")]
		public int CompareTo(LFOJIKJJGOK OGFCKBADKBE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x71FCF80", Offset = "0x71FB780", VA = "0x1871FCF80")]
		[IteratorStateMachine(typeof(CHDPIIPEBMP))]
		public IEnumerable<LFOJIKJJGOK> GMEPAIHJGKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x71FBF60", Offset = "0x71FA760", VA = "0x1871FBF60")]
		public void FKMJHFNEANM(ILGenerator NBFEIBNEKBC, LocalBuilder IGEIIMLGHIC, LocalBuilder MENHFNLCAJA, LocalBuilder JOEHGGMHBAA, Action<KeyValuePair<string, int>> ODLAHDLEEPA, Action LPHJKFCKIOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x71FC2D0", Offset = "0x71FAAD0", VA = "0x1871FC2D0")]
		private static void FLOELNNLPGP(ILGenerator NBFEIBNEKBC, LocalBuilder IGEIIMLGHIC, LocalBuilder MENHFNLCAJA, LocalBuilder JOEHGGMHBAA, Action<KeyValuePair<string, int>> ODLAHDLEEPA, Action LPHJKFCKIOF, LFOJIKJJGOK[] KAOAHJPDKBO, int POAAACAIHKJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class MANJKHOHDEO : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private IEnumerable<LFOJIKJJGOK> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public IEnumerable<LFOJIKJJGOK> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IEnumerator<LFOJIKJJGOK> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private LFOJIKJJGOK <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xBF3DE0", Offset = "0xBF25E0", VA = "0x180BF3DE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x71FD9B0", Offset = "0x71FC1B0", VA = "0x1871FD9B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E10BB0", Offset = "0x1E0F3B0", VA = "0x181E10BB0")]
		[DebuggerHidden]
		public MANJKHOHDEO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x71FDA00", Offset = "0x71FC200", VA = "0x1871FDA00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x71FD400", Offset = "0x71FBC00", VA = "0x1871FD400", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x71FD860", Offset = "0x71FC060", VA = "0x1871FD860")]
		private void OLLLOCKLGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x71FD3B0", Offset = "0x71FBBB0", VA = "0x1871FD3B0")]
		private void LBICBBCOFMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x71FD960", Offset = "0x71FC160", VA = "0x1871FD960", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x71FD8B0", Offset = "0x71FC0B0", VA = "0x1871FD8B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x71FD8B0", Offset = "0x71FC0B0", VA = "0x1871FD8B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly LFOJIKJJGOK AHKBBGKKCNK;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x71F4C10", Offset = "0x71F3410", VA = "0x1871F4C10")]
	public FGNFHJHBHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x71F4880", Offset = "0x71F3080", VA = "0x1871F4880")]
	public void CNLMKNIMMKA(byte[] GHFEJDPMJDG, int IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x71F4990", Offset = "0x71F3190", VA = "0x1871F4990")]
	public bool FKPCOINCHOI(ArraySegment<byte> JOEHGGMHBAA, [Out] int IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x71F4B80", Offset = "0x71F3380", VA = "0x1871F4B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x71F45A0", Offset = "0x71F2DA0", VA = "0x1871F45A0")]
	private static void BPNEBGAFKEL(IEnumerable<LFOJIKJJGOK> KAOAHJPDKBO, StringBuilder JOMGKNMBICL, int ONJLNAPAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x71F4A70", Offset = "0x71F3270", VA = "0x1871F4A70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x71F4A70", Offset = "0x71F3270", VA = "0x1871F4A70", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x71F4AD0", Offset = "0x71F32D0", VA = "0x1871F4AD0")]
	[IteratorStateMachine(typeof(MANJKHOHDEO))]
	private static IEnumerable<KeyValuePair<string, int>> HAGFFJFEKOO(IEnumerable<LFOJIKJJGOK> KAOAHJPDKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x71F4B50", Offset = "0x71F3350", VA = "0x1871F4B50")]
	public void HFKLNLEBALF(ILGenerator NBFEIBNEKBC, LocalBuilder IGEIIMLGHIC, LocalBuilder MENHFNLCAJA, LocalBuilder JOEHGGMHBAA, Action<KeyValuePair<string, int>> ODLAHDLEEPA, Action LPHJKFCKIOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class ANAAMDEOCMG
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static readonly MethodInfo ALJMLDGDEFM;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x71EE680", Offset = "0x71ECE80", VA = "0x1871EE680")]
	public static ulong FFJPFLPIMKI(byte[] GHFEJDPMJDG, int MFLLOPOPNNG, int MENHFNLCAJA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class GCKAGCAOJLC
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x71F5850", Offset = "0x71F4050", VA = "0x1871F5850")]
	public static void LJMMNFLBIKI(byte[] GHFEJDPMJDG, int MFLLOPOPNNG, int DNAFGALNGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x71F5730", Offset = "0x71F3F30", VA = "0x1871F5730")]
	public static void DPOBBMCEOLI(byte[] JAOFFCELONG, int BHDGLHEOELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x71F5600", Offset = "0x71F3E00", VA = "0x1871F5600")]
	public static byte[] BGLBPLGOCIA(byte[] AMBKIFNGGDN, int BHDGLHEOELO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class PMALGNNOBHL
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x72046B0", Offset = "0x7202EB0", VA = "0x1872046B0")]
	public static bool IHJMDBLAKJJ(byte[] LADANHFNGOM, int FKMDDGMPGOE, int MAEELALOBEN, byte[] MOIMCNHKONL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class FEHMCBCHEPP<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private struct HMHHAJCPLPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public byte[] PJOIFALPHGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public T JDDKPJKLOJP;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8160", Offset = "0x3CB6960", VA = "0x183CB8160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class AAKDNMOACHE : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public FEHMCBCHEPP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private HMHHAJCPLPK[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private HMHHAJCPLPK[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xBF3DE0", Offset = "0xBF25E0", VA = "0x180BF3DE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x3B2F390", Offset = "0x3B2DB90", VA = "0x183B2F390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public AAKDNMOACHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3B780A0", Offset = "0x3B768A0", VA = "0x183B780A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3B78D50", Offset = "0x3B77550", VA = "0x183B78D50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly HMHHAJCPLPK[][] IAHFDNLBHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly ulong NCOJANBOPJB;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3ADE550", Offset = "0x3ADCD50", VA = "0x183ADE550")]
	public FEHMCBCHEPP(int MELGOCPNHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3ADE590", Offset = "0x3ADCD90", VA = "0x183ADE590")]
	public FEHMCBCHEPP(int MELGOCPNHFM, float MBCPIPFNOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3AD29F0", Offset = "0x3AD11F0", VA = "0x183AD29F0")]
	public void CNLMKNIMMKA(byte[] JOEHGGMHBAA, T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3AD39F0", Offset = "0x3AD21F0", VA = "0x183AD39F0")]
	private bool FLJINKNJLPN(byte[] JOEHGGMHBAA, T IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3ADD990", Offset = "0x3ADC190", VA = "0x183ADD990")]
	public bool GFIHGBPIMCF(ArraySegment<byte> JOEHGGMHBAA, [Out] T IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3620", Offset = "0x3AD1E20", VA = "0x183AD3620")]
	private static ulong EOCAMPMGKGH(byte[] PNGIKMLKECD, int MFLLOPOPNNG, int POAAACAIHKJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3ADE520", Offset = "0x3ADCD20", VA = "0x183ADE520")]
	private static int LEONCLCAAGP(int OOIADAJDNFJ, float MBCPIPFNOBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3ADE2A0", Offset = "0x3ADCAA0", VA = "0x183ADE2A0", Slot = "4")]
	[IteratorStateMachine(typeof(FEHMCBCHEPP<>.AAKDNMOACHE))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x39F0D20", Offset = "0x39EF520", VA = "0x1839F0D20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class BJPCEMKGNJN : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly OpCode[] GCINOMOFFPL;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly OpCode[] PPCCBNBBDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int NLNLLNEANMH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool EDDLNECKGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x71F0520", Offset = "0x71EED20", VA = "0x1871F0520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x71F0570", Offset = "0x71EED70", VA = "0x1871F0570")]
	static BJPCEMKGNJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x71F07C0", Offset = "0x71EEFC0", VA = "0x1871F07C0")]
	public BJPCEMKGNJN(byte[] OLNJIIOLIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x71F0430", Offset = "0x71EEC30", VA = "0x1871F0430")]
	public OpCode DHGPJKNNBEG()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal struct KNEBOMCDJME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public readonly Guid JDDKPJKLOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public readonly byte PCCNCAOAFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public readonly byte PLAEDNJMNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public readonly byte DFLPFKHFFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public readonly byte LIONGKBNAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public readonly byte PGGJKNHIFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public readonly byte HFFLDIIIGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public readonly byte OLMBBENIEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public readonly byte MFMGHKCCMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public readonly byte GFFPOFCCLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public readonly byte EEMKELCIOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public readonly byte BIHCFDOMNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly byte KMIJDIGIFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte NGCOLOLCGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte MLAAKDFJBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte CAHBFNFIPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte FGGBIDCAJFJ;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static byte[] PHOLJJGFMPB;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static byte[] JIMEHHANIIB;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x71FA7C0", Offset = "0x71F8FC0", VA = "0x1871FA7C0")]
	public KNEBOMCDJME(Guid IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x71F9070", Offset = "0x71F7870", VA = "0x1871F9070")]
	public KNEBOMCDJME(ArraySegment<byte> OFLCHBKPDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x71F8EF0", Offset = "0x71F76F0", VA = "0x1871F8EF0")]
	private static byte NOAGNHGOMOH(byte[] GHFEJDPMJDG, int MHMIPDEALNM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x71F8DD0", Offset = "0x71F75D0", VA = "0x1871F8DD0")]
	private static byte NIDKCJPPAOI(byte ICPBHPBDLLK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x71F81C0", Offset = "0x71F69C0", VA = "0x1871F81C0")]
	public void IINHDBGECBD(byte[] PAJEBKJPIBK, int MFLLOPOPNNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class BPJLDALPPGI
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x71F1600", Offset = "0x71EFE00", VA = "0x1871F1600")]
	public static bool DFAGKLGDOPL(byte FFEGACHBGBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x71F2080", Offset = "0x71F0880", VA = "0x1871F2080")]
	public static bool NKFAGOLGIGJ(byte FFEGACHBGBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x71F23F0", Offset = "0x71F0BF0", VA = "0x1871F23F0")]
	public static sbyte PMPBEHANPBP(byte[] GHFEJDPMJDG, int MFLLOPOPNNG, [Out] int JGNMKACEPEK)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x71F1D90", Offset = "0x71F0590", VA = "0x1871F1D90")]
	public static short HNDDCOLPIHM(byte[] GHFEJDPMJDG, int MFLLOPOPNNG, [Out] int JGNMKACEPEK)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x71F2200", Offset = "0x71F0A00", VA = "0x1871F2200")]
	public static int OHFGKMKMHAI(byte[] GHFEJDPMJDG, int MFLLOPOPNNG, [Out] int JGNMKACEPEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x71F1F60", Offset = "0x71F0760", VA = "0x1871F1F60")]
	public static long LMEBMEHCHCP(byte[] GHFEJDPMJDG, int MFLLOPOPNNG, [Out] int JGNMKACEPEK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x71F2000", Offset = "0x71F0800", VA = "0x1871F2000")]
	public static byte NJOAOFMNBJI(byte[] GHFEJDPMJDG, int MFLLOPOPNNG, [Out] int JGNMKACEPEK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x71F22F0", Offset = "0x71F0AF0", VA = "0x1871F22F0")]
	public static ushort OMFEPHGCODH(byte[] GHFEJDPMJDG, int MFLLOPOPNNG, [Out] int JGNMKACEPEK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x71F2370", Offset = "0x71F0B70", VA = "0x1871F2370")]
	public static uint PKMJGCJOBBA(byte[] GHFEJDPMJDG, int MFLLOPOPNNG, [Out] int JGNMKACEPEK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x71F20F0", Offset = "0x71F08F0", VA = "0x1871F20F0")]
	public static ulong ODGMDJHPLAE(byte[] GHFEJDPMJDG, int MFLLOPOPNNG, [Out] int JGNMKACEPEK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x71F1E80", Offset = "0x71F0680", VA = "0x1871F1E80")]
	public static float IFCCKMGFFCC(byte[] GHFEJDPMJDG, int MFLLOPOPNNG, [Out] int JGNMKACEPEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x71F1CB0", Offset = "0x71F04B0", VA = "0x1871F1CB0")]
	public static double HFDDEIPMOIG(byte[] GHFEJDPMJDG, int MFLLOPOPNNG, [Out] int JGNMKACEPEK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x71F1610", Offset = "0x71EFE10", VA = "0x1871F1610")]
	public static int FMBGIECIKLK(byte[] PAJEBKJPIBK, int MFLLOPOPNNG, ulong IPHHABIKCHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x71F0C40", Offset = "0x71EF440", VA = "0x1871F0C40")]
	public static int CPOHOCALKKC(byte[] PAJEBKJPIBK, int MFLLOPOPNNG, long IPHHABIKCHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x71F0A10", Offset = "0x71EF210", VA = "0x1871F0A10")]
	public static bool BKNEHDEHFKA(byte[] GHFEJDPMJDG, int MFLLOPOPNNG, [Out] int JGNMKACEPEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal static class HJFMHJKGNHH
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class BIMGOKHOFIB : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x898540", Offset = "0x896D40", VA = "0x180898540")]
		[DebuggerHidden]
		public BIMGOKHOFIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x71F0300", Offset = "0x71EEB00", VA = "0x1871F0300", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x71EFD70", Offset = "0x71EE570", VA = "0x1871EFD70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x71F01A0", Offset = "0x71EE9A0", VA = "0x1871F01A0")]
		private void OLLLOCKLGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x71EFD20", Offset = "0x71EE520", VA = "0x1871EFD20")]
		private void LBICBBCOFMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x71F02B0", Offset = "0x71EEAB0", VA = "0x1871F02B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x71F01F0", Offset = "0x71EE9F0", VA = "0x1871F01F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x71F01F0", Offset = "0x71EE9F0", VA = "0x1871F01F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class BALHODELMDC : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x898540", Offset = "0x896D40", VA = "0x180898540")]
		[DebuggerHidden]
		public BALHODELMDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x71EF870", Offset = "0x71EE070", VA = "0x1871EF870", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x71EF2E0", Offset = "0x71EDAE0", VA = "0x1871EF2E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x71EF710", Offset = "0x71EDF10", VA = "0x1871EF710")]
		private void OLLLOCKLGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x71EF290", Offset = "0x71EDA90", VA = "0x1871EF290")]
		private void LBICBBCOFMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x71EF820", Offset = "0x71EE020", VA = "0x1871EF820", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x71EF760", Offset = "0x71EDF60", VA = "0x1871EF760", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x71EF760", Offset = "0x71EDF60", VA = "0x1871EF760", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x71F6250", Offset = "0x71F4A50", VA = "0x1871F6250")]
	public static bool IKCPMHLLHMH(this TypeInfo HKAKMPIMEOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x71F6120", Offset = "0x71F4920", VA = "0x1871F6120")]
	public static bool GEAKJLKHEPF(this TypeInfo HKAKMPIMEOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x71F60A0", Offset = "0x71F48A0", VA = "0x1871F60A0")]
	public static IEnumerable<PropertyInfo> FNHLAGJBIOJ(this Type HKAKMPIMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x71F6000", Offset = "0x71F4800", VA = "0x1871F6000")]
	[IteratorStateMachine(typeof(BIMGOKHOFIB))]
	private static IEnumerable<PropertyInfo> FCHAAKKIMBI(Type HKAKMPIMEOA, HashSet<string> NAIGLBHHFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x71F5EE0", Offset = "0x71F46E0", VA = "0x1871F5EE0")]
	public static IEnumerable<FieldInfo> DIOOPMOKJHM(this Type HKAKMPIMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x71F5F60", Offset = "0x71F4760", VA = "0x1871F5F60")]
	[IteratorStateMachine(typeof(BALHODELMDC))]
	private static IEnumerable<FieldInfo> ELNNLMHNCBO(Type HKAKMPIMEOA, HashSet<string> NAIGLBHHFKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class HKFDOEGADFH
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public static readonly Encoding JCAKCABOHMN;
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal static class OHNODLLJKOJ
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
	public static string IOKNMEPAGHH(string OECMLGFFGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7200490", Offset = "0x71FEC90", VA = "0x187200490")]
	public static string NLFLBNCHOFD(string OECMLGFFGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7200300", Offset = "0x71FEB00", VA = "0x187200300")]
	public static string IIMEGBIBJHH(string OECMLGFFGAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class LFMNOCKENDF<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class OINCBGJCGKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type PJOIFALPHGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public TValue JDDKPJKLOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int JMBLFNLMJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public OINCBGJCGKM AOCMNLBJEJA;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x4580970", Offset = "0x457F170", VA = "0x184580970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x4580860", Offset = "0x457F060", VA = "0x184580860")]
		private int HJCFDKBBGAL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public OINCBGJCGKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class CECHPJPNGPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public CECHPJPNGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAE0", Offset = "0x8B92E0", VA = "0x1808BAAE0")]
		internal TValue IJGICAMOGCP(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private OINCBGJCGKM[] IAHFDNLBHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private int GGKCGCGFHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly object OEFENIDPABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly float MBCPIPFNOBH;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x4146E00", Offset = "0x4145600", VA = "0x184146E00")]
	public LFMNOCKENDF(int MELGOCPNHFM = 4, float MBCPIPFNOBH = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x4145860", Offset = "0x4144060", VA = "0x184145860")]
	public bool BOGMKCJDBDF(Type JOEHGGMHBAA, TValue IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x4145800", Offset = "0x4144000", VA = "0x184145800")]
	public bool BOGMKCJDBDF(Type JOEHGGMHBAA, Func<Type, TValue> CLABPHMMLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x4145F30", Offset = "0x4144730", VA = "0x184145F30")]
	private bool FLJINKNJLPN(Type JOEHGGMHBAA, Func<Type, TValue> CLABPHMMLHG, [Out] TValue HFDFGEBBCJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x4146550", Offset = "0x4144D50", VA = "0x184146550")]
	private bool HJJBIKHFLHP(OINCBGJCGKM[] IAHFDNLBHMP, Type NPPELEFLDGI, OINCBGJCGKM OAJMOMNACML, Func<Type, TValue> CLABPHMMLHG, [Out] TValue HFDFGEBBCJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x41462E0", Offset = "0x4144AE0", VA = "0x1841462E0")]
	public bool GFIHGBPIMCF(Type JOEHGGMHBAA, [Out] TValue IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x4145AA0", Offset = "0x41442A0", VA = "0x184145AA0")]
	public TValue CDLJBHELEOK(Type JOEHGGMHBAA, Func<Type, TValue> CLABPHMMLHG)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3ADE520", Offset = "0x3ADCD20", VA = "0x183ADE520")]
	private static int LEONCLCAAGP(int OOIADAJDNFJ, float MBCPIPFNOBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x4146DD0", Offset = "0x41455D0", VA = "0x184146DD0")]
	private static void OAAPGDNGIHK(OINCBGJCGKM LBANIEJNOIP, OINCBGJCGKM IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x4146DD0", Offset = "0x41455D0", VA = "0x184146DD0")]
	private static void OAAPGDNGIHK(OINCBGJCGKM[] LBANIEJNOIP, OINCBGJCGKM[] IPHHABIKCHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class BBGLJLNEMOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly AssemblyBuilder MBJCEGLCGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly ModuleBuilder DEHBEELCFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly object IOAPKNACHMG;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x71EF9A0", Offset = "0x71EE1A0", VA = "0x1871EF9A0")]
	public TypeBuilder PJANBKBBGFO(string GCDLMFGKKMH, TypeAttributes PLKPPIKCAAC, Type GGJNHHDMGON, Type[] GBADIAIMLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x71EFAA0", Offset = "0x71EE2A0", VA = "0x1871EFAA0")]
	public BBGLJLNEMOD(string JAAMICAPAAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class LMKDKPBLNJJ
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x71FD2D0", Offset = "0x71FBAD0", VA = "0x1871FD2D0")]
	private static MethodInfo LHBBPLDMOAJ(LambdaExpression NBJIFIJEEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2B594F0", Offset = "0x2B57CF0", VA = "0x182B594F0")]
	public static MethodInfo JLHMICLNFJK<T>(Expression<Func<T>> NBJIFIJEEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2B594F0", Offset = "0x2B57CF0", VA = "0x182B594F0")]
	public static MethodInfo JLHMICLNFJK<T, TR>(Expression<Func<T, TR>> NBJIFIJEEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2B594F0", Offset = "0x2B57CF0", VA = "0x182B594F0")]
	public static MethodInfo JLHMICLNFJK<T>(Expression<Action<T>> NBJIFIJEEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x2B594F0", Offset = "0x2B57CF0", VA = "0x182B594F0")]
	public static MethodInfo JLHMICLNFJK<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> NBJIFIJEEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2B59410", Offset = "0x2B57C10", VA = "0x182B59410")]
	private static MemberInfo HOLOFCMKNCF<T>(Expression<T> CMAEAOPOFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2B59360", Offset = "0x2B57B60", VA = "0x182B59360")]
	public static PropertyInfo GOMDFODGDOB<T, TR>(Expression<Func<T, TR>> NBJIFIJEEGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct GKANNOLGIPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly int JIAIKHGLBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly bool LKLFMHJBANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly ILGenerator NBFEIBNEKBC;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x71F5CE0", Offset = "0x71F44E0", VA = "0x1871F5CE0")]
	public GKANNOLGIPO(ILGenerator NBFEIBNEKBC, int JIAIKHGLBJE, bool LKLFMHJBANG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x71F5C50", Offset = "0x71F4450", VA = "0x1871F5C50")]
	public GKANNOLGIPO(ILGenerator NBFEIBNEKBC, int JIAIKHGLBJE, Type HKAKMPIMEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x71F5B50", Offset = "0x71F4350", VA = "0x1871F5B50")]
	public void NCEGLGOCPGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class KEGOIHDLBMG
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x71F7590", Offset = "0x71F5D90", VA = "0x1871F7590")]
	public static void DMEMBKGLDEE(this ILGenerator NBFEIBNEKBC, int JBDLDJOINOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x71F7770", Offset = "0x71F5F70", VA = "0x1871F7770")]
	public static void DMEMBKGLDEE(this ILGenerator NBFEIBNEKBC, LocalBuilder IIHAIEFILOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x71F7190", Offset = "0x71F5990", VA = "0x1871F7190")]
	public static void CLAJPFFCKKL(this ILGenerator NBFEIBNEKBC, int JBDLDJOINOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x71F7370", Offset = "0x71F5B70", VA = "0x1871F7370")]
	public static void CLAJPFFCKKL(this ILGenerator NBFEIBNEKBC, LocalBuilder IIHAIEFILOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x71F73B0", Offset = "0x71F5BB0", VA = "0x1871F73B0")]
	public static void DBNJOGKOEMF(this ILGenerator NBFEIBNEKBC, int JBDLDJOINOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x71F7490", Offset = "0x71F5C90", VA = "0x1871F7490")]
	public static void DBNJOGKOEMF(this ILGenerator NBFEIBNEKBC, LocalBuilder IIHAIEFILOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x71F78A0", Offset = "0x71F60A0", VA = "0x1871F78A0")]
	public static void FGIEICLLCOA(this ILGenerator NBFEIBNEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x71F78B0", Offset = "0x71F60B0", VA = "0x1871F78B0")]
	public static void FKIDGIAFOGN(this ILGenerator NBFEIBNEKBC, bool IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x71F7B80", Offset = "0x71F6380", VA = "0x1871F7B80")]
	public static void OCNJNKDFPFK(this ILGenerator NBFEIBNEKBC, int IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x71F7950", Offset = "0x71F6150", VA = "0x1871F7950")]
	public static void IPINDLHCDAI(this ILGenerator NBFEIBNEKBC, Type HKAKMPIMEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x71F70F0", Offset = "0x71F58F0", VA = "0x1871F70F0")]
	public static void CBOIHFDDPHO(this ILGenerator NBFEIBNEKBC, Type HKAKMPIMEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x71F6F10", Offset = "0x71F5710", VA = "0x1871F6F10")]
	public static void BOPPBGCNCNA(this ILGenerator NBFEIBNEKBC, int JBDLDJOINOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x71F7F40", Offset = "0x71F6740", VA = "0x1871F7F40")]
	public static void ONGHMPLDKOF(this ILGenerator NBFEIBNEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x71F7AB0", Offset = "0x71F62B0", VA = "0x1871F7AB0")]
	public static void MJGDIBKLBOD(this ILGenerator NBFEIBNEKBC, int JBDLDJOINOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x71F77B0", Offset = "0x71F5FB0", VA = "0x1871F77B0")]
	public static void FFFMPAHCANG(this ILGenerator NBFEIBNEKBC, MethodInfo FKCDLACMADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x71F7A20", Offset = "0x71F6220", VA = "0x1871F7A20")]
	public static void KNBOALGKOEO(this ILGenerator NBFEIBNEKBC, FieldInfo DBDJILAIPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x71F78C0", Offset = "0x71F60C0", VA = "0x1871F78C0")]
	public static void HIBPEJFHKJE(this ILGenerator NBFEIBNEKBC, ulong IPHHABIKCHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal class FPPGIHMBACN
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class NNOAEMMAKBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public NNOAEMMAKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x71FFF90", Offset = "0x71FE790", VA = "0x1871FFF90")]
		internal bool MBALFJFIHOC(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private MethodInfo EBNIDDGOFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private MethodInfo PLDEKIKIAAM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string PGLGAEOCIFD
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x844F20", Offset = "0x843720", VA = "0x180844F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AEHBHFIGANN
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x71F4FC0", Offset = "0x71F37C0", VA = "0x1871F4FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool EMMELEGHLJA
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8472B0", Offset = "0x845AB0", VA = "0x1808472B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8473B0", Offset = "0x845BB0", VA = "0x1808473B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool BINHDPGKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA5F420", Offset = "0xA5DC20", VA = "0x180A5F420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA5EE30", Offset = "0xA5D630", VA = "0x180A5EE30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type LBCGEBEPPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x84A250", Offset = "0x848A50", VA = "0x18084A250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo HHKPNLHNABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x84A240", Offset = "0x848A40", VA = "0x18084A240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo EMKEBGKKBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8474A0", Offset = "0x845CA0", VA = "0x1808474A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x847500", Offset = "0x845D00", VA = "0x180847500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo KPKBPOKNLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8472C0", Offset = "0x845AC0", VA = "0x1808472C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8473A0", Offset = "0x845BA0", VA = "0x1808473A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x71F52B0", Offset = "0x71F3AB0", VA = "0x1871F52B0")]
	protected FPPGIHMBACN(Type HKAKMPIMEOA, string GCDLMFGKKMH, string CJCBPBLNCGI, bool BGMEEHDLPIE, bool KBPMLDBLANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x71F54F0", Offset = "0x71F3CF0", VA = "0x1871F54F0")]
	public FPPGIHMBACN(FieldInfo HIAJCEJJCOE, string GCDLMFGKKMH, bool ECNNCIHLCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x71F5330", Offset = "0x71F3B30", VA = "0x1871F5330")]
	public FPPGIHMBACN(PropertyInfo HIAJCEJJCOE, string GCDLMFGKKMH, bool ECNNCIHLCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x71F5140", Offset = "0x71F3940", VA = "0x1871F5140")]
	private static MethodInfo NHFHDHCKJDN(MemberInfo HIAJCEJJCOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2A81460", Offset = "0x2A7FC60", VA = "0x182A81460")]
	public T DKIJNHKPLBL<T>(bool GOKKPFGMKKL) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x71F4E50", Offset = "0x71F3650", VA = "0x1871F4E50", Slot = "4")]
	public virtual void JJPJHOACOKA(ILGenerator NBFEIBNEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x71F4FD0", Offset = "0x71F37D0", VA = "0x1871F4FD0", Slot = "5")]
	public virtual void MNAMPOCBGIO(ILGenerator NBFEIBNEKBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class HPEFGPIPMHI : FPPGIHMBACN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly string BHLPHAGBJFC;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x71F6A90", Offset = "0x71F5290", VA = "0x1871F6A90")]
	public HPEFGPIPMHI(string GCDLMFGKKMH, string BHLPHAGBJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x71F6990", Offset = "0x71F5190", VA = "0x1871F6990", Slot = "4")]
	public override void JJPJHOACOKA(ILGenerator NBFEIBNEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x71F6A40", Offset = "0x71F5240", VA = "0x1871F6A40", Slot = "5")]
	public override void MNAMPOCBGIO(ILGenerator NBFEIBNEKBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class OIDEINGMEMG : FPPGIHMBACN
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly MethodInfo GEKBPLELAJN;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly MethodInfo LIAADAFLHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	internal GKANNOLGIPO FPCDDDBHINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	internal GKANNOLGIPO GDAHKDDCIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	internal GKANNOLGIPO IAALHPOGJNK;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x7200D40", Offset = "0x71FF540", VA = "0x187200D40")]
	public OIDEINGMEMG(string GCDLMFGKKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7200570", Offset = "0x71FED70", VA = "0x187200570", Slot = "4")]
	public override void JJPJHOACOKA(ILGenerator NBFEIBNEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x72007E0", Offset = "0x71FEFE0", VA = "0x1872007E0", Slot = "5")]
	public override void MNAMPOCBGIO(ILGenerator NBFEIBNEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x7200630", Offset = "0x71FEE30", VA = "0x187200630")]
	public void LOGAIHHIDEF(ILGenerator NBFEIBNEKBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class PIGDMAINOBM
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type LBCGEBEPPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool LKHBLAOOLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F40", Offset = "0x8E1740", VA = "0x1808E2F40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x84DAC0", Offset = "0x84C2C0", VA = "0x18084DAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool PEJIDNMKNEB
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x94B070", Offset = "0x949870", VA = "0x18094B070")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5C830", VA = "0x180A5E030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo HBKCALBBBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x844F30", Offset = "0x843730", VA = "0x180844F30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public FPPGIHMBACN[] HGGMDCCGDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x84A250", Offset = "0x848A50", VA = "0x18084A250")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public FPPGIHMBACN[] EMFOJADJIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x84A240", Offset = "0x848A40", VA = "0x18084A240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x7203080", Offset = "0x7201880", VA = "0x187203080")]
	public PIGDMAINOBM(Type HKAKMPIMEOA, Func<string, string> GNLFODAJEMA, bool ECNNCIHLCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x7202FA0", Offset = "0x72017A0", VA = "0x187202FA0")]
	private static bool KMKLFNDJIIM(IEnumerator<ConstructorInfo> GCBDJBLMFLO, ConstructorInfo FOIENMOOFPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct JBGMMLHHLBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public ulong DEEJLELNIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public int JLOICJBFAKG;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1F26840", Offset = "0x1F25040", VA = "0x181F26840")]
	public JBGMMLHHLBG(ulong OJCPNHDJGEO, int EMAFMGKGMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x71F6B70", Offset = "0x71F5370", VA = "0x1871F6B70")]
	public void DLBGHNIOCOK(JBGMMLHHLBG OGFCKBADKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x71F6D40", Offset = "0x71F5540", VA = "0x1871F6D40")]
	public static JBGMMLHHLBG JEKKFEIOBLC(JBGMMLHHLBG NKCCEIKLOPK, JBGMMLHHLBG ICPBHPBDLLK)
	{
		return default(JBGMMLHHLBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x71F6C10", Offset = "0x71F5410", VA = "0x1871F6C10")]
	public void EELMJNACAGF(JBGMMLHHLBG OGFCKBADKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x71F6CA0", Offset = "0x71F54A0", VA = "0x1871F6CA0")]
	public static JBGMMLHHLBG FCONBFHAGGE(JBGMMLHHLBG NKCCEIKLOPK, JBGMMLHHLBG ICPBHPBDLLK)
	{
		return default(JBGMMLHHLBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x71F6BD0", Offset = "0x71F53D0", VA = "0x1871F6BD0")]
	public void EBIEOEECMLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x71F6B80", Offset = "0x71F5380", VA = "0x1871F6B80")]
	public static JBGMMLHHLBG EBIEOEECMLD(JBGMMLHHLBG NKCCEIKLOPK)
	{
		return default(JBGMMLHHLBG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct HNGFKPOHNFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public byte[] PAJEBKJPIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public int MFLLOPOPNNG;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x1A56D70", Offset = "0x1A55570", VA = "0x181A56D70")]
	public HNGFKPOHNFG(byte[] PAJEBKJPIBK, int GBKEBGLIOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x71D9E80", Offset = "0x71D8680", VA = "0x1871D9E80")]
	public void KHIBFPLOKLK(byte KKDAHIDPNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x71F6720", Offset = "0x71F4F20", VA = "0x1871F6720")]
	public void FLABJNEBKDH(byte[] KKDAHIDPNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x71F6500", Offset = "0x71F4D00", VA = "0x1871F6500")]
	public void DMPKGEEBDDH(byte[] KKDAHIDPNBA, int IDGMEKAEIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x71F6580", Offset = "0x71F4D80", VA = "0x1871F6580")]
	public void DMPKGEEBDDH(byte[] KKDAHIDPNBA, int CKMEAPHLBGJ, int IDGMEKAEIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x71F67A0", Offset = "0x71F4FA0", VA = "0x1871F67A0")]
	public void JOGKGFMGHAL(byte FFEGACHBGBH, int POAAACAIHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x71F6620", Offset = "0x71F4E20", VA = "0x1871F6620")]
	public void EAKEJDJNPMP(string KKDAHIDPNBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class PCIMCEPLLDG
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private enum BHPGPOBMNND
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private enum OKFFJDKPGJE
	{
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private enum MMHMOBJEHJM
	{
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[ThreadStatic]
	private static byte[] DDIALOMFMEK;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[ThreadStatic]
	private static byte[] JMGCCLLKGMB;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly byte[] EFNFDMJJBPG;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly byte[] JECHCFKKDDL;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly MMHMOBJEHJM MMDHCLPOCNC;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly char KICLEFHHMMP;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly int FNOEIBDMLDL;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly int FLANGEODHIG;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly uint[] MBEHAPDPHNO;

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x72013E0", Offset = "0x71FFBE0", VA = "0x1872013E0")]
	private static byte[] BIEPGAEJKNK(int GGKCGCGFHKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7202810", Offset = "0x7201010", VA = "0x187202810")]
	private static byte[] NDJIHFJCHEH(int GGKCGCGFHKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7201880", Offset = "0x7200080", VA = "0x187201880")]
	public static int GEHENODKDEL(byte[] PAJEBKJPIBK, int MFLLOPOPNNG, float IPHHABIKCHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x72019A0", Offset = "0x72001A0", VA = "0x1872019A0")]
	public static int GEHENODKDEL(byte[] PAJEBKJPIBK, int MFLLOPOPNNG, double IPHHABIKCHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x72014B0", Offset = "0x71FFCB0", VA = "0x1872014B0")]
	private static bool DAMHDBCHLOM(byte[] PAJEBKJPIBK, int IDGMEKAEIMD, ulong IJGOHIHELJH, ulong LHCBDMLKBCA, ulong MENHFNLCAJA, ulong BEMLFKBHEEB, ulong EDLMNNDMGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7201790", Offset = "0x71FFF90", VA = "0x187201790")]
	private static void FCIBHCGIKKA(uint COHDBBMCFKL, int KEPFHIDCBAE, [Out] uint NEPPLEPFOKB, [Out] int HOHGHJNGAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7201AC0", Offset = "0x72002C0", VA = "0x187201AC0")]
	private static bool HJPALNPMGKH(JBGMMLHHLBG MKMHCFHNKNN, JBGMMLHHLBG NCACLCNGFPK, JBGMMLHHLBG ADENNMECPNF, byte[] PAJEBKJPIBK, [Out] int IDGMEKAEIMD, [Out] int FANBCJKJKKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x72028F0", Offset = "0x72010F0", VA = "0x1872028F0")]
	private static bool PHJHJIFNOIM(double BLNBBLFAAGC, BHPGPOBMNND MCJDOPPFHLD, byte[] PAJEBKJPIBK, [Out] int IDGMEKAEIMD, [Out] int JFNJHMDFBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7200E00", Offset = "0x71FF600", VA = "0x187200E00")]
	private static bool BDLIPAPBPPE(double BLNBBLFAAGC, BHPGPOBMNND MCJDOPPFHLD, byte[] PAJEBKJPIBK, [Out] int IDGMEKAEIMD, [Out] int DFGMJMICPLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7202650", Offset = "0x7200E50", VA = "0x187202650")]
	private static bool MPHHAAONLOO(double IPHHABIKCHD, HNGFKPOHNFG OLGPLGOACOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7200F10", Offset = "0x71FF710", VA = "0x187200F10")]
	private static bool BHPAEKNKGHM(double IPHHABIKCHD, HNGFKPOHNFG OLGPLGOACOF, OKFFJDKPGJE MCJDOPPFHLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7201EA0", Offset = "0x72006A0", VA = "0x187201EA0")]
	private static void IFNEELBOMMI(byte[] MBHJEBDIECH, int IDGMEKAEIMD, int DFGMJMICPLE, int HILFNMHFJJL, HNGFKPOHNFG OLGPLGOACOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7202230", Offset = "0x7200A30", VA = "0x187202230")]
	private static void MAGJKGBPPAF(byte[] MBHJEBDIECH, int IDGMEKAEIMD, int EMAFMGKGMAH, HNGFKPOHNFG OLGPLGOACOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x72015A0", Offset = "0x71FFDA0", VA = "0x1872015A0")]
	private static bool ENNNPCKIHOA(double BLNBBLFAAGC, OKFFJDKPGJE MCJDOPPFHLD, int HILOFFHEDMI, byte[] BEBBIKFGHKD, [Out] bool BLMFFAMAGIJ, [Out] int IDGMEKAEIMD, [Out] int BGLKCAHKMON)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal struct AHHJGOFHKPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public double NENJINMAAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public ulong KJOEMPJDBKC;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct NFAHAIDPJBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public float DEEJLELNIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public uint FFPHGIOJJID;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal struct MOMBBPDDBKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private ulong GABHMBFFFHN;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x71FFF80", Offset = "0x71FE780", VA = "0x1871FFF80")]
	public MOMBBPDDBKE(double NENJINMAAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x71FFEE0", Offset = "0x71FE6E0", VA = "0x1871FFEE0")]
	public MOMBBPDDBKE(JBGMMLHHLBG NENJINMAAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x71FFA20", Offset = "0x71FE220", VA = "0x1871FFA20")]
	public JBGMMLHHLBG CFBCLFNGNLG()
	{
		return default(JBGMMLHHLBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x71FF950", Offset = "0x71FE150", VA = "0x1871FF950")]
	public JBGMMLHHLBG AGBFGCACNPN()
	{
		return default(JBGMMLHHLBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
	public ulong GIPJDKDDPHF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x71FFCF0", Offset = "0x71FE4F0", VA = "0x1871FFCF0")]
	public double ICHLHIMHGKP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x71FFE20", Offset = "0x71FE620", VA = "0x1871FFE20")]
	public double OPDGOEIAOAB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x71FFDF0", Offset = "0x71FE5F0", VA = "0x1871FFDF0")]
	public int OODJBIHCCJE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x71FFDC0", Offset = "0x71FE5C0", VA = "0x1871FFDC0")]
	public ulong LOJHAPOGMEB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x71FFDA0", Offset = "0x71FE5A0", VA = "0x1871FFDA0")]
	public bool KFKHLPINLIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x71FFCC0", Offset = "0x71FE4C0", VA = "0x1871FFCC0")]
	public bool EDKIFLGKCAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x71FF9F0", Offset = "0x71FE1F0", VA = "0x1871FF9F0")]
	public bool BIKAONPNGFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x71FFD70", Offset = "0x71FE570", VA = "0x1871FFD70")]
	public bool IHLBBBHEOIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x71FF9D0", Offset = "0x71FE1D0", VA = "0x1871FF9D0")]
	public int AMKOIMKJPHM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x71FFAE0", Offset = "0x71FE2E0", VA = "0x1871FFAE0")]
	public void DDGLHFBKMEO([Out] JBGMMLHHLBG BALKJGBPIGE, [Out] JBGMMLHHLBG JJIMBLCPJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x71FFA90", Offset = "0x71FE290", VA = "0x1871FFA90")]
	public bool CGEPNBFFOEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x30EF2D0", Offset = "0x30EDAD0", VA = "0x1830EF2D0")]
	public double IPHHABIKCHD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x71FFEC0", Offset = "0x71FE6C0", VA = "0x1871FFEC0")]
	public static int PAPFBOJMJJH(int KNLOPIKAPPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x71FFCE0", Offset = "0x71FE4E0", VA = "0x1871FFCE0")]
	public static double EEMKDIDNFIG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x71FFC30", Offset = "0x71FE430", VA = "0x1871FFC30")]
	public static ulong DEIMBBJOCDH(JBGMMLHHLBG NNKKEIMPHDB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct CICHGAAFEEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private uint AJJCGBHKKFI;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x20E8C40", Offset = "0x20E7440", VA = "0x1820E8C40")]
	public CICHGAAFEEM(float DEEJLELNIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x71F2810", Offset = "0x71F1010", VA = "0x1871F2810")]
	public JBGMMLHHLBG CFBCLFNGNLG()
	{
		return default(JBGMMLHHLBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8FC6D0", Offset = "0x8FAED0", VA = "0x1808FC6D0")]
	public uint CBNEIPIMHMO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x71F2A00", Offset = "0x71F1200", VA = "0x1871F2A00")]
	public int OODJBIHCCJE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x71F29E0", Offset = "0x71F11E0", VA = "0x1871F29E0")]
	public uint LOJHAPOGMEB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x71F29D0", Offset = "0x71F11D0", VA = "0x1871F29D0")]
	public bool KFKHLPINLIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x71F28A0", Offset = "0x71F10A0", VA = "0x1871F28A0")]
	public void DDGLHFBKMEO([Out] JBGMMLHHLBG BALKJGBPIGE, [Out] JBGMMLHHLBG JJIMBLCPJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x71F2860", Offset = "0x71F1060", VA = "0x1871F2860")]
	public bool CGEPNBFFOEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct EOODFJPOHEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly ulong OJCPNHDJGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly short NCDBMAPGBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly short JFNJHMDFBJN;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x71F43B0", Offset = "0x71F2BB0", VA = "0x1871F43B0")]
	public EOODFJPOHEA(ulong OJCPNHDJGEO, short NCDBMAPGBFC, short JFNJHMDFBJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class KNIBJPGJAMA
{
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly EOODFJPOHEA[] NLBPAFLMPNP;

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x71FA8A0", Offset = "0x71F90A0", VA = "0x1871FA8A0")]
	public static void KFMGMLLABGP(int FJKIAJLGJCN, int FCABBDFIHCO, [Out] JBGMMLHHLBG NEPPLEPFOKB, [Out] int JFNJHMDFBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x71FA7D0", Offset = "0x71F8FD0", VA = "0x1871FA7D0")]
	public static void DNHKDBNHMDA(int PMHEBMFKACM, [Out] JBGMMLHHLBG NEPPLEPFOKB, [Out] int OINFGJJIBJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[DefaultMember("Item")]
internal struct KJABJHOEHFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly byte[] GHFEJDPMJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly int CKMEAPHLBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly int CMBGKCNKPNM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x71F8120", Offset = "0x71F6920", VA = "0x1871F8120")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x43F3C00", Offset = "0x43F2400", VA = "0x1843F3C00")]
	public KJABJHOEHFE(byte[] GHFEJDPMJDG, int CKMEAPHLBGJ, int IDGMEKAEIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2126800", Offset = "0x2125000", VA = "0x182126800")]
	public int IDGMEKAEIMD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x71F8160", Offset = "0x71F6960", VA = "0x1871F8160")]
	public KJABJHOEHFE ECDABAPODAF(int KGKGNFIBJEB, int MBIIHBIIKOG)
	{
		return default(KJABJHOEHFE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class MLODIHICBHI
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[ThreadStatic]
	private static byte[] IANGCJDCNNL;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static readonly double[] PHLNPACIAIP;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly int FDCHACGHKKF;

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x71FEEF0", Offset = "0x71FD6F0", VA = "0x1871FEEF0")]
	private static byte[] HLGIOBCFDMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x71FE080", Offset = "0x71FC880", VA = "0x1871FE080")]
	private static KJABJHOEHFE ALAPAJEHFBI(KJABJHOEHFE PAJEBKJPIBK)
	{
		return default(KJABJHOEHFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x71FEFD0", Offset = "0x71FD7D0", VA = "0x1871FEFD0")]
	private static KJABJHOEHFE LNAMJEEJJHP(KJABJHOEHFE PAJEBKJPIBK)
	{
		return default(KJABJHOEHFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x71FE810", Offset = "0x71FD010", VA = "0x1871FE810")]
	private static void EPFCGIBDNPD(KJABJHOEHFE PAJEBKJPIBK, int EMAFMGKGMAH, byte[] GDADMMFAEOO, [Out] int EPMAKDLCDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x71FE520", Offset = "0x71FCD20", VA = "0x1871FE520")]
	private static void DDPLHNNNGHD(KJABJHOEHFE PAJEBKJPIBK, int EMAFMGKGMAH, byte[] KCFIAIJCDDA, int PAONBEGINOO, [Out] KJABJHOEHFE OKAPELIIFLG, [Out] int GLPMCHBPJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x71FDFF0", Offset = "0x71FC7F0", VA = "0x1871FDFF0")]
	private static ulong ACHBHLOOALO(KJABJHOEHFE PAJEBKJPIBK, [Out] int GEKKBBMKFOA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x71FF490", Offset = "0x71FDC90", VA = "0x1871FF490")]
	private static void OCDGOFNHBMI(KJABJHOEHFE PAJEBKJPIBK, [Out] JBGMMLHHLBG KKBKNCNBBJP, [Out] int AJMMIDJJNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x71FE160", Offset = "0x71FC960", VA = "0x1871FE160")]
	private static bool BDILJPLOFHA(KJABJHOEHFE OKAPELIIFLG, int EMAFMGKGMAH, [Out] double KKBKNCNBBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x71FF1D0", Offset = "0x71FD9D0", VA = "0x1871FF1D0")]
	private static JBGMMLHHLBG MIEFAJBICCE(int EMAFMGKGMAH)
	{
		return default(JBGMMLHHLBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x71FE8A0", Offset = "0x71FD0A0", VA = "0x1871FE8A0")]
	private static bool FKLAOIKOEKN(KJABJHOEHFE PAJEBKJPIBK, int EMAFMGKGMAH, [Out] double KKBKNCNBBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x71FF370", Offset = "0x71FDB70", VA = "0x1871FF370")]
	private static bool NANBHMGLDNM(KJABJHOEHFE OKAPELIIFLG, int EMAFMGKGMAH, [Out] double GAHEFHFCNKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x71FF0B0", Offset = "0x71FD8B0", VA = "0x1871FF0B0")]
	public static double? MFMKAIKIKGP(KJABJHOEHFE PAJEBKJPIBK, int EMAFMGKGMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x71FF5D0", Offset = "0x71FDDD0", VA = "0x1871FF5D0")]
	public static float? PJPJOPGNBDB(KJABJHOEHFE PAJEBKJPIBK, int EMAFMGKGMAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct EPPLIOJBKAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private byte[] PAJEBKJPIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private int MFLLOPOPNNG;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte JDDKPJKLOJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x71F4520", Offset = "0x71F2D20", VA = "0x1871F4520")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1A56D70", Offset = "0x1A55570", VA = "0x181A56D70")]
	public EPPLIOJBKAB(byte[] PAJEBKJPIBK, int MFLLOPOPNNG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x71F43C0", Offset = "0x71F2BC0", VA = "0x1871F43C0")]
	public static EPPLIOJBKAB DCCLPMBNLAG(EPPLIOJBKAB EGJINJKGIAK)
	{
		return default(EPPLIOJBKAB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x71F4550", Offset = "0x71F2D50", VA = "0x1871F4550")]
	public static EPPLIOJBKAB OBCMMDOIGAL(EPPLIOJBKAB EGJINJKGIAK, int IDGMEKAEIMD)
	{
		return default(EPPLIOJBKAB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x71F44E0", Offset = "0x71F2CE0", VA = "0x1871F44E0")]
	public static int KCENMCPGDOF(EPPLIOJBKAB JOMKMIJJPCA, EPPLIOJBKAB DFLDBCDDIFI)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x71F44A0", Offset = "0x71F2CA0", VA = "0x1871F44A0")]
	public static bool JAJJILMADFD(EPPLIOJBKAB JOMKMIJJPCA, EPPLIOJBKAB DFLDBCDDIFI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x71F4460", Offset = "0x71F2C60", VA = "0x1871F4460")]
	public static bool GLAAFHEDDBF(EPPLIOJBKAB JOMKMIJJPCA, EPPLIOJBKAB DFLDBCDDIFI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x71F44B0", Offset = "0x71F2CB0", VA = "0x1871F44B0")]
	public static bool JAJJILMADFD(EPPLIOJBKAB JOMKMIJJPCA, char DFLDBCDDIFI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x71F4430", Offset = "0x71F2C30", VA = "0x1871F4430")]
	public static bool GLAAFHEDDBF(EPPLIOJBKAB JOMKMIJJPCA, char DFLDBCDDIFI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x71F4430", Offset = "0x71F2C30", VA = "0x1871F4430")]
	public static bool GLAAFHEDDBF(EPPLIOJBKAB JOMKMIJJPCA, byte DFLDBCDDIFI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x71F43D0", Offset = "0x71F2BD0", VA = "0x1871F43D0")]
	public static bool FKHADHKNAND(EPPLIOJBKAB JOMKMIJJPCA, char DFLDBCDDIFI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x71F4470", Offset = "0x71F2C70", VA = "0x1871F4470")]
	public static bool IOFADJBKGJF(EPPLIOJBKAB JOMKMIJJPCA, char DFLDBCDDIFI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x71F44F0", Offset = "0x71F2CF0", VA = "0x1871F44F0")]
	public static bool LDMNHCNAOGM(EPPLIOJBKAB JOMKMIJJPCA, char DFLDBCDDIFI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x71F4400", Offset = "0x71F2C00", VA = "0x1871F4400")]
	public static bool FMDMBFEPNOJ(EPPLIOJBKAB JOMKMIJJPCA, char DFLDBCDDIFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class ELIIHGNEBAP
{
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[ThreadStatic]
	private static byte[] BCABHILPBAJ;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[ThreadStatic]
	private static byte[] NIDMAMAJKNC;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly byte[] EFNFDMJJBPG;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly byte[] JECHCFKKDDL;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly byte[] MJGAHMIIFJB;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly int FPIPMDFHDPE;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ushort[] FEILBEPFGNP;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly int LPPDCDHMLGP;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x71F2CF0", Offset = "0x71F14F0", VA = "0x1871F2CF0")]
	private static byte[] KBCPNGJGFNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x71F2AF0", Offset = "0x71F12F0", VA = "0x1871F2AF0")]
	private static byte[] CPAAGPHDGAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x71F2BD0", Offset = "0x71F13D0", VA = "0x1871F2BD0")]
	public static double DNFCHCNBNGC(byte[] PAJEBKJPIBK, int MFLLOPOPNNG, [Out] int JGNMKACEPEK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x71F2DD0", Offset = "0x71F15D0", VA = "0x1871F2DD0")]
	public static float KIFHHHLFMLN(byte[] PAJEBKJPIBK, int MFLLOPOPNNG, [Out] int JGNMKACEPEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x71F3E10", Offset = "0x71F2610", VA = "0x1871F3E10")]
	private static bool OHAJPCNDHKE(int PNGIKMLKECD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x71F3F40", Offset = "0x71F2740", VA = "0x1871F3F40")]
	private static bool PAFAFKHDOPG(EPPLIOJBKAB MJKLMDKBKCG, EPPLIOJBKAB KLHAFEOKDLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x71F2A20", Offset = "0x71F1220", VA = "0x1871F2A20")]
	private static bool CJPNLLCPGBI(EPPLIOJBKAB MJKLMDKBKCG, EPPLIOJBKAB KLHAFEOKDLO, byte[] CLFLPNMNAFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x71F2CA0", Offset = "0x71F14A0", VA = "0x1871F2CA0")]
	private static bool HMPGAPMHKEG(EPPLIOJBKAB PFGBEHHHGBG, byte[] KKDAHIDPNBA, int MFLLOPOPNNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x71F2C80", Offset = "0x71F1480", VA = "0x1871F2C80")]
	private static double GMLMDFEJPGD(bool BLMFFAMAGIJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x71F2E80", Offset = "0x71F1680", VA = "0x1871F2E80")]
	private static double MJFOLHLAAJI(EPPLIOJBKAB FDJIPPJKNDH, int IDGMEKAEIMD, bool PFNHINMJHBA, [Out] int CLLDDMHKPNB)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class GJPOMDLHEJO<T> : BMLPDKFJOPL<T[]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly HKDEIMGAKPB<T> EHIIKIJCPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly OPDEKPMDPDF GHKOEFPNDBL;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF390", Offset = "0x3ACDB90", VA = "0x183ACF390")]
	public GJPOMDLHEJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
	public GJPOMDLHEJO(OPDEKPMDPDF GHKOEFPNDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x3BE0700", Offset = "0x3BDEF00", VA = "0x183BE0700", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, T[] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x3BE0950", Offset = "0x3BDF150", VA = "0x183BE0950", Slot = "5")]
	public T[] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public class BABKGEEFNFG<T> : BMLPDKFJOPL<ArraySegment<T>>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly HKDEIMGAKPB<T> EHIIKIJCPCF;

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4D11EA0", Offset = "0x4D106A0", VA = "0x184D11EA0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, ArraySegment<T> IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4D121C0", Offset = "0x4D109C0", VA = "0x184D121C0", Slot = "5")]
	public ArraySegment<T> PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class LICKGJKDEPP<T> : BMLPDKFJOPL<List<T>>, BNDBHHCFNCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly OPDEKPMDPDF GHKOEFPNDBL;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF390", Offset = "0x3ACDB90", VA = "0x183ACF390")]
	public LICKGJKDEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
	public LICKGJKDEPP(OPDEKPMDPDF GHKOEFPNDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x414CDF0", Offset = "0x414B5F0", VA = "0x18414CDF0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, List<T> IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x414DE10", Offset = "0x414C610", VA = "0x18414DE10", Slot = "5")]
	public List<T> PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class MBPANIJBAFD<TElement, TIntermediate, TEnumerator, TCollection> : BMLPDKFJOPL<TCollection>, BNDBHHCFNCL where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x433A3B0", Offset = "0x4338BB0", VA = "0x18433A3B0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, TCollection IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x433A8E0", Offset = "0x43390E0", VA = "0x18433A8E0", Slot = "5")]
	public TCollection PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator JCGINLDPHLI(TCollection CMAEAOPOFPD);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate DLNFHNOLCMJ();

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void CNLMKNIMMKA(TIntermediate NAJDJIPOFCB, int JBDLDJOINOF, TElement IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection DGMMFKFGKCB(TIntermediate GENIKKOGDJM);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	protected MBPANIJBAFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class EKAPHEEKADK<TElement, TIntermediate, TCollection> : MBPANIJBAFD<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x375D470", Offset = "0x375BC70", VA = "0x18375D470", Slot = "6")]
	protected override IEnumerator<TElement> JCGINLDPHLI(TCollection CMAEAOPOFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3719940", Offset = "0x3718140", VA = "0x183719940")]
	protected EKAPHEEKADK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public abstract class MFHFDKKMCIB<TElement, TCollection> : EKAPHEEKADK<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x9CD630", Offset = "0x9CBE30", VA = "0x1809CD630", Slot = "9")]
	protected sealed override TCollection DGMMFKFGKCB(TCollection GENIKKOGDJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class HGCNIGFDGBA<TElement, TCollection> : MFHFDKKMCIB<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3CA71B0", Offset = "0x3CA59B0", VA = "0x183CA71B0", Slot = "7")]
	protected override TCollection DLNFHNOLCMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3CA7150", Offset = "0x3CA5950", VA = "0x183CA7150", Slot = "8")]
	protected override void CNLMKNIMMKA(TCollection NAJDJIPOFCB, int JBDLDJOINOF, TElement IPHHABIKCHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class ENGCJJBHBLN<T> : MBPANIJBAFD<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x376CC40", Offset = "0x376B440", VA = "0x18376CC40", Slot = "8")]
	protected override void CNLMKNIMMKA(LinkedList<T> NAJDJIPOFCB, int JBDLDJOINOF, T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x9CD630", Offset = "0x9CBE30", VA = "0x1809CD630", Slot = "9")]
	protected override LinkedList<T> DGMMFKFGKCB(LinkedList<T> GENIKKOGDJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x376CCA0", Offset = "0x376B4A0", VA = "0x18376CCA0", Slot = "7")]
	protected override LinkedList<T> DLNFHNOLCMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x376CD20", Offset = "0x376B520", VA = "0x18376CD20", Slot = "6")]
	protected override LinkedList<T>.Enumerator JCGINLDPHLI(LinkedList<T> CMAEAOPOFPD)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class ACADDLBIPMK<T> : MBPANIJBAFD<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x376CC40", Offset = "0x376B440", VA = "0x18376CC40", Slot = "8")]
	protected override void CNLMKNIMMKA(Queue<T> NAJDJIPOFCB, int JBDLDJOINOF, T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x376CCA0", Offset = "0x376B4A0", VA = "0x18376CCA0", Slot = "7")]
	protected override Queue<T> DLNFHNOLCMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3B8F410", Offset = "0x3B8DC10", VA = "0x183B8F410", Slot = "6")]
	protected override Queue<T>.Enumerator JCGINLDPHLI(Queue<T> CMAEAOPOFPD)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x9CD630", Offset = "0x9CBE30", VA = "0x1809CD630", Slot = "9")]
	protected override Queue<T> DGMMFKFGKCB(Queue<T> GENIKKOGDJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class GHNABKBEEHL<T> : MBPANIJBAFD<T, HMEKIKLAOML<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x373F150", Offset = "0x373D950", VA = "0x18373F150", Slot = "8")]
	protected override void CNLMKNIMMKA(HMEKIKLAOML<T> NAJDJIPOFCB, int JBDLDJOINOF, T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3BDD700", Offset = "0x3BDBF00", VA = "0x183BDD700", Slot = "7")]
	protected override HMEKIKLAOML<T> DLNFHNOLCMJ()
	{
		return default(HMEKIKLAOML<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3BDD740", Offset = "0x3BDBF40", VA = "0x183BDD740", Slot = "6")]
	protected override Stack<T>.Enumerator JCGINLDPHLI(Stack<T> CMAEAOPOFPD)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3BDD5F0", Offset = "0x3BDBDF0", VA = "0x183BDD5F0", Slot = "9")]
	protected override Stack<T> DGMMFKFGKCB(HMEKIKLAOML<T> GENIKKOGDJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class GIBHAKCNDPM<T> : MBPANIJBAFD<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x376CC40", Offset = "0x376B440", VA = "0x18376CC40", Slot = "8")]
	protected override void CNLMKNIMMKA(HashSet<T> NAJDJIPOFCB, int JBDLDJOINOF, T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x9CD630", Offset = "0x9CBE30", VA = "0x1809CD630", Slot = "9")]
	protected override HashSet<T> DGMMFKFGKCB(HashSet<T> GENIKKOGDJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x376CCA0", Offset = "0x376B4A0", VA = "0x18376CCA0", Slot = "7")]
	protected override HashSet<T> DLNFHNOLCMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3B8F410", Offset = "0x3B8DC10", VA = "0x183B8F410", Slot = "6")]
	protected override HashSet<T>.Enumerator JCGINLDPHLI(HashSet<T> CMAEAOPOFPD)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class EBHJCJHNHDH<T> : EKAPHEEKADK<T, HMEKIKLAOML<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x373F150", Offset = "0x373D950", VA = "0x18373F150", Slot = "8")]
	protected override void CNLMKNIMMKA(HMEKIKLAOML<T> NAJDJIPOFCB, int JBDLDJOINOF, T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x373F180", Offset = "0x373D980", VA = "0x18373F180", Slot = "9")]
	protected override ReadOnlyCollection<T> DGMMFKFGKCB(HMEKIKLAOML<T> GENIKKOGDJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x373F230", Offset = "0x373DA30", VA = "0x18373F230", Slot = "7")]
	protected override HMEKIKLAOML<T> DLNFHNOLCMJ()
	{
		return default(HMEKIKLAOML<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class JIFLELPGLMN<T> : EKAPHEEKADK<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x376CC40", Offset = "0x376B440", VA = "0x18376CC40", Slot = "8")]
	protected override void CNLMKNIMMKA(List<T> NAJDJIPOFCB, int JBDLDJOINOF, T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x376CCA0", Offset = "0x376B4A0", VA = "0x18376CCA0", Slot = "7")]
	protected override List<T> DLNFHNOLCMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x9CD630", Offset = "0x9CBE30", VA = "0x1809CD630", Slot = "9")]
	protected override IList<T> DGMMFKFGKCB(List<T> GENIKKOGDJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class KANPJJCMMFN<T> : EKAPHEEKADK<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x376CC40", Offset = "0x376B440", VA = "0x18376CC40", Slot = "8")]
	protected override void CNLMKNIMMKA(List<T> NAJDJIPOFCB, int JBDLDJOINOF, T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x376CCA0", Offset = "0x376B4A0", VA = "0x18376CCA0", Slot = "7")]
	protected override List<T> DLNFHNOLCMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x9CD630", Offset = "0x9CBE30", VA = "0x1809CD630", Slot = "9")]
	protected override ICollection<T> DGMMFKFGKCB(List<T> GENIKKOGDJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class CAHODENFKKB<T> : EKAPHEEKADK<T, HMEKIKLAOML<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x373F150", Offset = "0x373D950", VA = "0x18373F150", Slot = "8")]
	protected override void CNLMKNIMMKA(HMEKIKLAOML<T> NAJDJIPOFCB, int JBDLDJOINOF, T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3BDD700", Offset = "0x3BDBF00", VA = "0x183BDD700", Slot = "7")]
	protected override HMEKIKLAOML<T> DLNFHNOLCMJ()
	{
		return default(HMEKIKLAOML<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x4DD1530", Offset = "0x4DCFD30", VA = "0x184DD1530", Slot = "9")]
	protected override IEnumerable<T> DGMMFKFGKCB(HMEKIKLAOML<T> GENIKKOGDJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x3732C70", Offset = "0x3731470", VA = "0x183732C70")]
	public CAHODENFKKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class EPEDKHMHFLG<TKey, TElement> : BMLPDKFJOPL<IGrouping<TKey, TElement>>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3772BB0", Offset = "0x37713B0", VA = "0x183772BB0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, IGrouping<TKey, TElement> IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3772E50", Offset = "0x3771650", VA = "0x183772E50", Slot = "5")]
	public IGrouping<TKey, TElement> PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class AGPAOEFKCNP<TKey, TElement> : BMLPDKFJOPL<ILookup<TKey, TElement>>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3B9CD40", Offset = "0x3B9B540", VA = "0x183B9CD40", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, ILookup<TKey, TElement> IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3B9CED0", Offset = "0x3B9B6D0", VA = "0x183B9CED0", Slot = "5")]
	public ILookup<TKey, TElement> PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class CKFHJCMANHL<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly TKey JOEHGGMHBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly IEnumerable<TElement> KOMHLEPKPKC;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey PJOIFALPHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x84B520", Offset = "0x849D20", VA = "0x18084B520")]
	public CKFHJCMANHL(TKey JOEHGGMHBAA, IEnumerable<TElement> KOMHLEPKPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x4F8DA90", Offset = "0x4F8C290", VA = "0x184F8DA90", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x37BEA60", Offset = "0x37BD260", VA = "0x1837BEA60", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[DefaultMember("Item")]
internal class BNOCBGEIKAG<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> GAOGCKKDPPD;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x3AD1760", Offset = "0x3ACFF60", VA = "0x183AD1760", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public BNOCBGEIKAG(Dictionary<TKey, IGrouping<TKey, TElement>> GAOGCKKDPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x24EAA80", Offset = "0x24E9280", VA = "0x1824EAA80", Slot = "5")]
	public bool Contains(TKey JOEHGGMHBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x4D43D60", Offset = "0x4D42560", VA = "0x184D43D60", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4D43D60", Offset = "0x4D42560", VA = "0x184D43D60", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class IPGOPLCJEPH<T> : BMLPDKFJOPL<T>, BNDBHHCFNCL where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x3DC18E0", Offset = "0x3DC00E0", VA = "0x183DC18E0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, T IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1C10", Offset = "0x3DC0410", VA = "0x183DC1C10", Slot = "5")]
	public T PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public IPGOPLCJEPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class PFHLBEAJBCN : BMLPDKFJOPL<IEnumerable>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly BMLPDKFJOPL<IEnumerable> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7214FF0", Offset = "0x72137F0", VA = "0x187214FF0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, IEnumerable IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x72152A0", Offset = "0x7213AA0", VA = "0x1872152A0", Slot = "5")]
	public IEnumerable PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public PFHLBEAJBCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class MAICCKNFLOJ : BMLPDKFJOPL<ICollection>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public static readonly BMLPDKFJOPL<ICollection> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x7212110", Offset = "0x7210910", VA = "0x187212110", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, ICollection IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x72124B0", Offset = "0x7210CB0", VA = "0x1872124B0", Slot = "5")]
	public ICollection PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public MAICCKNFLOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class OKAGLJNNAKH : BMLPDKFJOPL<IList>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public static readonly BMLPDKFJOPL<IList> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x72142C0", Offset = "0x7212AC0", VA = "0x1872142C0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, IList IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x72145F0", Offset = "0x7212DF0", VA = "0x1872145F0", Slot = "5")]
	public IList PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public OKAGLJNNAKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class MEFPDGIHKNI<T> : EKAPHEEKADK<T, HMEKIKLAOML<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x435C5C0", Offset = "0x435ADC0", VA = "0x18435C5C0", Slot = "8")]
	protected override void CNLMKNIMMKA(HMEKIKLAOML<T> NAJDJIPOFCB, int JBDLDJOINOF, T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3BDD700", Offset = "0x3BDBF00", VA = "0x183BDD700", Slot = "7")]
	protected override HMEKIKLAOML<T> DLNFHNOLCMJ()
	{
		return default(HMEKIKLAOML<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x435C620", Offset = "0x435AE20", VA = "0x18435C620", Slot = "9")]
	protected override IReadOnlyList<T> DGMMFKFGKCB(HMEKIKLAOML<T> GENIKKOGDJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x3732510", Offset = "0x3730D10", VA = "0x183732510")]
	public MEFPDGIHKNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class HOHAGGHBHAM
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x720A3B0", Offset = "0x7208BB0", VA = "0x18720A3B0")]
	public static DateTime LNKMPDKOFIM(DateTime CPDEMIEGHAJ)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class IGNNEJJGBMD : BMLPDKFJOPL<DateTime>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public static readonly BMLPDKFJOPL<DateTime> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x720A830", Offset = "0x7209030", VA = "0x18720A830", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, DateTime IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x720AFE0", Offset = "0x72097E0", VA = "0x18720AFE0", Slot = "5")]
	public DateTime PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public IGNNEJJGBMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class KLNANOFCJAA : BMLPDKFJOPL<DateTimeOffset>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public static readonly BMLPDKFJOPL<DateTimeOffset> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x72107D0", Offset = "0x720EFD0", VA = "0x1872107D0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, DateTimeOffset IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7210E70", Offset = "0x720F670", VA = "0x187210E70", Slot = "5")]
	public DateTimeOffset PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public KLNANOFCJAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class BOKMNODEBGJ : BMLPDKFJOPL<TimeSpan>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly BMLPDKFJOPL<TimeSpan> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static byte[] LKACABAGLLP;

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7205BB0", Offset = "0x72043B0", VA = "0x187205BB0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, TimeSpan IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7205F90", Offset = "0x7204790", VA = "0x187205F90", Slot = "5")]
	public TimeSpan PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public BOKMNODEBGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public abstract class JGAHKENHOGL<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : BMLPDKFJOPL<TDictionary>, BNDBHHCFNCL where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3F8F710", Offset = "0x3F8DF10", VA = "0x183F8F710", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, TDictionary IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3F936A0", Offset = "0x3F91EA0", VA = "0x183F936A0", Slot = "5")]
	public TDictionary PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator JCGINLDPHLI(TDictionary CMAEAOPOFPD);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate DLNFHNOLCMJ();

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void CNLMKNIMMKA(TIntermediate NAJDJIPOFCB, int JBDLDJOINOF, TKey JOEHGGMHBAA, TValue IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary DGMMFKFGKCB(TIntermediate GENIKKOGDJM);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	protected JGAHKENHOGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public abstract class ELEPEEKLBDE<TKey, TValue, TIntermediate, TDictionary> : JGAHKENHOGL<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x375D470", Offset = "0x375BC70", VA = "0x18375D470", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> JCGINLDPHLI(TDictionary CMAEAOPOFPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public abstract class FCONOIHCMAJ<TKey, TValue, TDictionary> : ELEPEEKLBDE<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x9CD630", Offset = "0x9CBE30", VA = "0x1809CD630", Slot = "9")]
	protected override TDictionary DGMMFKFGKCB(TDictionary GENIKKOGDJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class LJBCDLPNLIA<TKey, TValue> : JGAHKENHOGL<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x41529B0", Offset = "0x41511B0", VA = "0x1841529B0", Slot = "8")]
	protected override void CNLMKNIMMKA(Dictionary<TKey, TValue> NAJDJIPOFCB, int JBDLDJOINOF, TKey JOEHGGMHBAA, TValue IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x9CD630", Offset = "0x9CBE30", VA = "0x1809CD630", Slot = "9")]
	protected override Dictionary<TKey, TValue> DGMMFKFGKCB(Dictionary<TKey, TValue> GENIKKOGDJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x376CCA0", Offset = "0x376B4A0", VA = "0x18376CCA0", Slot = "7")]
	protected override Dictionary<TKey, TValue> DLNFHNOLCMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x4152B10", Offset = "0x4151310", VA = "0x184152B10", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator JCGINLDPHLI(Dictionary<TKey, TValue> CMAEAOPOFPD)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3718AA0", Offset = "0x37172A0", VA = "0x183718AA0")]
	public LJBCDLPNLIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class MGJLHKJAJEL<TKey, TValue, TDictionary> : FCONOIHCMAJ<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x4367BB0", Offset = "0x43663B0", VA = "0x184367BB0", Slot = "8")]
	protected override void CNLMKNIMMKA(TDictionary NAJDJIPOFCB, int JBDLDJOINOF, TKey JOEHGGMHBAA, TValue IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x34B6400", Offset = "0x34B4C00", VA = "0x1834B6400", Slot = "7")]
	protected override TDictionary DLNFHNOLCMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class AFKBCBPPBBG<TKey, TValue> : ELEPEEKLBDE<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3B98AD0", Offset = "0x3B972D0", VA = "0x183B98AD0", Slot = "8")]
	protected override void CNLMKNIMMKA(Dictionary<TKey, TValue> NAJDJIPOFCB, int JBDLDJOINOF, TKey JOEHGGMHBAA, TValue IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x376CCA0", Offset = "0x376B4A0", VA = "0x18376CCA0", Slot = "7")]
	protected override Dictionary<TKey, TValue> DLNFHNOLCMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x9CD630", Offset = "0x9CBE30", VA = "0x1809CD630", Slot = "9")]
	protected override IDictionary<TKey, TValue> DGMMFKFGKCB(Dictionary<TKey, TValue> GENIKKOGDJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class BLLINFFEEFC<TKey, TValue> : FCONOIHCMAJ<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x3B98AD0", Offset = "0x3B972D0", VA = "0x183B98AD0", Slot = "8")]
	protected override void CNLMKNIMMKA(SortedList<TKey, TValue> NAJDJIPOFCB, int JBDLDJOINOF, TKey JOEHGGMHBAA, TValue IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x376CCA0", Offset = "0x376B4A0", VA = "0x18376CCA0", Slot = "7")]
	protected override SortedList<TKey, TValue> DLNFHNOLCMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class GPOPEKLDDCH<TKey, TValue> : JGAHKENHOGL<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x3B98AD0", Offset = "0x3B972D0", VA = "0x183B98AD0", Slot = "8")]
	protected override void CNLMKNIMMKA(SortedDictionary<TKey, TValue> NAJDJIPOFCB, int JBDLDJOINOF, TKey JOEHGGMHBAA, TValue IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x9CD630", Offset = "0x9CBE30", VA = "0x1809CD630", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> DGMMFKFGKCB(SortedDictionary<TKey, TValue> GENIKKOGDJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x376CCA0", Offset = "0x376B4A0", VA = "0x18376CCA0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> DLNFHNOLCMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C6A0", Offset = "0x3C2AEA0", VA = "0x183C2C6A0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator JCGINLDPHLI(SortedDictionary<TKey, TValue> CMAEAOPOFPD)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class BFCKALAEPLG<T> : BMLPDKFJOPL<T>, BNDBHHCFNCL where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x4D25160", Offset = "0x4D23960", VA = "0x184D25160", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, T IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x4D25640", Offset = "0x4D23E40", VA = "0x184D25640", Slot = "5")]
	public T PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public BFCKALAEPLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class CPGKEKNJFKD : BMLPDKFJOPL<IDictionary>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly BMLPDKFJOPL<IDictionary> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7207000", Offset = "0x7205800", VA = "0x187207000", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, IDictionary IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x72074E0", Offset = "0x7205CE0", VA = "0x1872074E0", Slot = "5")]
	public IDictionary PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public CPGKEKNJFKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class KCNFDLFNDAC : BMLPDKFJOPL<object>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private delegate void HLPHNGEBPKA(object OILIKHCLJBF, DPHIKHGFLNL COHNONCDMOG, object IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly LFMNOCKENDF<KeyValuePair<object, HLPHNGEBPKA>> MOHCMANEAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private readonly JOEIFIPPNIH[] OIIAGJPJALD;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x720FC30", Offset = "0x720E430", VA = "0x18720FC30")]
	public KCNFDLFNDAC(params JOEIFIPPNIH[] OIIAGJPJALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x720F1D0", Offset = "0x720D9D0", VA = "0x18720F1D0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, object IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x720FBA0", Offset = "0x720E3A0", VA = "0x18720FBA0", Slot = "5")]
	public object PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class JJGPEENGKJD
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x720D820", Offset = "0x720C020", VA = "0x18720D820")]
	public static object JCFFHNHAJLC(Type HKAKMPIMEOA, [Out] bool CPGKLNEMAMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x720E0B0", Offset = "0x720C8B0", VA = "0x18720E0B0")]
	public static object LCLNBFDNOED(Type HKAKMPIMEOA, [Out] bool CPGKLNEMAMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class GMNDLALDKDC<T> : BMLPDKFJOPL<T>, BNDBHHCFNCL, KMDHLAFMGKK<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class AKOJCEOGPCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public AKOJCEOGPCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3C4C4B0", Offset = "0x3C4ACB0", VA = "0x183C4C4B0")]
		internal bool BJCGIICJKLK(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private sealed class DHAKEJIOHJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public DHAKEJIOHJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x56F5AD0", Offset = "0x56F42D0", VA = "0x1856F5AD0")]
		internal bool JEGCOMMCKPM(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class DODJMIBIMLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public GFHCGNOKPMK<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public DODJMIBIMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x57B6280", Offset = "0x57B4A80", VA = "0x1857B6280")]
		internal void FEDNLDNJLNM(DPHIKHGFLNL writer, T value, JOEIFIPPNIH _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class LLGGNBNMDPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public PPFPIEPONCN<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public LLGGNBNMDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x4162130", Offset = "0x4160930", VA = "0x184162130")]
		internal T HAEGFNEEEOJ(JHNPEGAMHPK reader, JOEIFIPPNIH _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private static readonly FEHMCBCHEPP<T> NGDFKCALKBO;

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static readonly Dictionary<T, string> BFPHLGLNOEG;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly GFHCGNOKPMK<T> GCMLLCELHIA;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly PPFPIEPONCN<T> HJLENKFHGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private readonly bool BHHHPNKEAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private readonly GFHCGNOKPMK<T> BJOLPGEIHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private readonly PPFPIEPONCN<T> EOOGJJDDEJP;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1C60", Offset = "0x3BF0460", VA = "0x183BF1C60")]
	static GMNDLALDKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x3BF41F0", Offset = "0x3BF29F0", VA = "0x183BF41F0")]
	public GMNDLALDKDC(bool BHHHPNKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3BEB020", Offset = "0x3BE9820", VA = "0x183BEB020", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, T IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3BEBAE0", Offset = "0x3BEA2E0", VA = "0x183BEBAE0", Slot = "5")]
	public T PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3BEA530", Offset = "0x3BE8D30", VA = "0x183BEA530", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, T IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x3BEA650", Offset = "0x3BE8E50", VA = "0x183BEA650", Slot = "7")]
	public T GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class ANBJGGPDPKG<T> : BMLPDKFJOPL<T[,]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3C54590", Offset = "0x3C52D90", VA = "0x183C54590", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, T[,] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3C54810", Offset = "0x3C53010", VA = "0x183C54810", Slot = "5")]
	public T[,] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public ANBJGGPDPKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class ICCAMLDIBAM<T> : BMLPDKFJOPL<T[,,]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D63830", Offset = "0x3D62030", VA = "0x183D63830", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, T[,,] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x3D63B60", Offset = "0x3D62360", VA = "0x183D63B60", Slot = "5")]
	public T[,,] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public ICCAMLDIBAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public sealed class DOIDBBBPFOD<T> : BMLPDKFJOPL<T[,,,]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x57B6890", Offset = "0x57B5090", VA = "0x1857B6890", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, T[,,,] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x57B6C70", Offset = "0x57B5470", VA = "0x1857B6C70", Slot = "5")]
	public T[,,,] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public DOIDBBBPFOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public sealed class JPLEPBHDLNK<T> : BMLPDKFJOPL<T?>, BNDBHHCFNCL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x3FB6690", Offset = "0x3FB4E90", VA = "0x183FB6690", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, T? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x3FB6BD0", Offset = "0x3FB53D0", VA = "0x183FB6BD0", Slot = "5")]
	public T? PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public JPLEPBHDLNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public sealed class FPOAKBPIJND<T> : BMLPDKFJOPL<T?>, BNDBHHCFNCL where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly BMLPDKFJOPL<T> HNLLPGKCPOB;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public FPOAKBPIJND(BMLPDKFJOPL<T> HNLLPGKCPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3B20630", Offset = "0x3B1EE30", VA = "0x183B20630", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, T? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3B20C20", Offset = "0x3B1F420", VA = "0x183B20C20", Slot = "5")]
	public T? PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public sealed class JPIONEBONCB : BMLPDKFJOPL<sbyte>, BNDBHHCFNCL, KMDHLAFMGKK<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public static readonly JPIONEBONCB BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x720F0B0", Offset = "0x720D8B0", VA = "0x18720F0B0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, sbyte IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x720F110", Offset = "0x720D910", VA = "0x18720F110", Slot = "5")]
	public sbyte PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x720EF80", Offset = "0x720D780", VA = "0x18720EF80", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, sbyte IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x720EFF0", Offset = "0x720D7F0", VA = "0x18720EFF0", Slot = "7")]
	public sbyte GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public JPIONEBONCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class CMDMKBFIJCO : BMLPDKFJOPL<sbyte?>, BNDBHHCFNCL, KMDHLAFMGKK<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public static readonly CMDMKBFIJCO BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7206E20", Offset = "0x7205620", VA = "0x187206E20", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, sbyte? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7206EE0", Offset = "0x72056E0", VA = "0x187206EE0", Slot = "5")]
	public sbyte? PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7206C40", Offset = "0x7205440", VA = "0x187206C40", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, sbyte? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7206D00", Offset = "0x7205500", VA = "0x187206D00", Slot = "7")]
	public sbyte? GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public CMDMKBFIJCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class DPNCJBOGIKB : BMLPDKFJOPL<sbyte[]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public static readonly DPNCJBOGIKB BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7207AE0", Offset = "0x72062E0", VA = "0x187207AE0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, sbyte[] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x7207C10", Offset = "0x7206410", VA = "0x187207C10", Slot = "5")]
	public sbyte[] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public DPNCJBOGIKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class LNPADBOKFLI : BMLPDKFJOPL<short>, BNDBHHCFNCL, KMDHLAFMGKK<short>
{
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public static readonly LNPADBOKFLI BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7211FF0", Offset = "0x72107F0", VA = "0x187211FF0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, short IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7212050", Offset = "0x7210850", VA = "0x187212050", Slot = "5")]
	public short PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7211EC0", Offset = "0x72106C0", VA = "0x187211EC0", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, short IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7211F30", Offset = "0x7210730", VA = "0x187211F30", Slot = "7")]
	public short GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public LNPADBOKFLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class EABEBCNPNKF : BMLPDKFJOPL<short?>, BNDBHHCFNCL, KMDHLAFMGKK<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public static readonly EABEBCNPNKF BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7207FF0", Offset = "0x72067F0", VA = "0x187207FF0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, short? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x72080B0", Offset = "0x72068B0", VA = "0x1872080B0", Slot = "5")]
	public short? PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x7207E10", Offset = "0x7206610", VA = "0x187207E10", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, short? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x7207ED0", Offset = "0x72066D0", VA = "0x187207ED0", Slot = "7")]
	public short? GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public EABEBCNPNKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class ACAEKBPDKBM : BMLPDKFJOPL<short[]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public static readonly ACAEKBPDKBM BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x7204E70", Offset = "0x7203670", VA = "0x187204E70", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, short[] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x7204FA0", Offset = "0x72037A0", VA = "0x187204FA0", Slot = "5")]
	public short[] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public ACAEKBPDKBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class JOHOHIDBJPG : BMLPDKFJOPL<int>, BNDBHHCFNCL, KMDHLAFMGKK<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public static readonly JOHOHIDBJPG BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x720EE60", Offset = "0x720D660", VA = "0x18720EE60", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, int IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x720EEC0", Offset = "0x720D6C0", VA = "0x18720EEC0", Slot = "5")]
	public int PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x720ED30", Offset = "0x720D530", VA = "0x18720ED30", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, int IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x720EDA0", Offset = "0x720D5A0", VA = "0x18720EDA0", Slot = "7")]
	public int GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public JOHOHIDBJPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class PPMJMBIENCF : BMLPDKFJOPL<int?>, BNDBHHCFNCL, KMDHLAFMGKK<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public static readonly PPMJMBIENCF BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x72159C0", Offset = "0x72141C0", VA = "0x1872159C0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, int? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x7215A80", Offset = "0x7214280", VA = "0x187215A80", Slot = "5")]
	public int? PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x72157E0", Offset = "0x7213FE0", VA = "0x1872157E0", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, int? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x72158A0", Offset = "0x72140A0", VA = "0x1872158A0", Slot = "7")]
	public int? GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public PPMJMBIENCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class IJKGIOOHLKL : BMLPDKFJOPL<int[]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public static readonly IJKGIOOHLKL BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x720C6B0", Offset = "0x720AEB0", VA = "0x18720C6B0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, int[] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x720C7E0", Offset = "0x720AFE0", VA = "0x18720C7E0", Slot = "5")]
	public int[] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public IJKGIOOHLKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class FANPGPBAGLC : BMLPDKFJOPL<long>, BNDBHHCFNCL, KMDHLAFMGKK<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly FANPGPBAGLC BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x7208B00", Offset = "0x7207300", VA = "0x187208B00", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, long IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x7208B60", Offset = "0x7207360", VA = "0x187208B60", Slot = "5")]
	public long PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x72089D0", Offset = "0x72071D0", VA = "0x1872089D0", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, long IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7208A40", Offset = "0x7207240", VA = "0x187208A40", Slot = "7")]
	public long GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public FANPGPBAGLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class HLNBKEJMIHH : BMLPDKFJOPL<long?>, BNDBHHCFNCL, KMDHLAFMGKK<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly HLNBKEJMIHH BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7209E80", Offset = "0x7208680", VA = "0x187209E80", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, long? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7209F40", Offset = "0x7208740", VA = "0x187209F40", Slot = "5")]
	public long? PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x7209C80", Offset = "0x7208480", VA = "0x187209C80", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, long? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7209D40", Offset = "0x7208540", VA = "0x187209D40", Slot = "7")]
	public long? GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public HLNBKEJMIHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class JIAMGKKGCHO : BMLPDKFJOPL<long[]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly JIAMGKKGCHO BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x720D4F0", Offset = "0x720BCF0", VA = "0x18720D4F0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, long[] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x720D620", Offset = "0x720BE20", VA = "0x18720D620", Slot = "5")]
	public long[] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public JIAMGKKGCHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class PDOGBBJHMHE : BMLPDKFJOPL<byte>, BNDBHHCFNCL, KMDHLAFMGKK<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly PDOGBBJHMHE BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x7214ED0", Offset = "0x72136D0", VA = "0x187214ED0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, byte IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7214F30", Offset = "0x7213730", VA = "0x187214F30", Slot = "5")]
	public byte PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7214DA0", Offset = "0x72135A0", VA = "0x187214DA0", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, byte IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x7214E10", Offset = "0x7213610", VA = "0x187214E10", Slot = "7")]
	public byte GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public PDOGBBJHMHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class IJHHEFOMLPF : BMLPDKFJOPL<byte?>, BNDBHHCFNCL, KMDHLAFMGKK<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly IJHHEFOMLPF BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x720C4D0", Offset = "0x720ACD0", VA = "0x18720C4D0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, byte? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x720C590", Offset = "0x720AD90", VA = "0x18720C590", Slot = "5")]
	public byte? PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x720C2F0", Offset = "0x720AAF0", VA = "0x18720C2F0", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, byte? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x720C3B0", Offset = "0x720ABB0", VA = "0x18720C3B0", Slot = "7")]
	public byte? GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public IJHHEFOMLPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class IOCLCJAGPLC : BMLPDKFJOPL<ushort>, BNDBHHCFNCL, KMDHLAFMGKK<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly IOCLCJAGPLC BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x720D090", Offset = "0x720B890", VA = "0x18720D090", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, ushort IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x720D0F0", Offset = "0x720B8F0", VA = "0x18720D0F0", Slot = "5")]
	public ushort PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x720CF60", Offset = "0x720B760", VA = "0x18720CF60", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, ushort IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x720CFD0", Offset = "0x720B7D0", VA = "0x18720CFD0", Slot = "7")]
	public ushort GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public IOCLCJAGPLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class IANOHGPAFCC : BMLPDKFJOPL<ushort?>, BNDBHHCFNCL, KMDHLAFMGKK<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly IANOHGPAFCC BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x720A650", Offset = "0x7208E50", VA = "0x18720A650", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, ushort? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x720A710", Offset = "0x7208F10", VA = "0x18720A710", Slot = "5")]
	public ushort? PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x720A470", Offset = "0x7208C70", VA = "0x18720A470", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, ushort? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x720A530", Offset = "0x7208D30", VA = "0x18720A530", Slot = "7")]
	public ushort? GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public IANOHGPAFCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class IJPMHOKGHCM : BMLPDKFJOPL<ushort[]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly IJPMHOKGHCM BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x720C9E0", Offset = "0x720B1E0", VA = "0x18720C9E0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, ushort[] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x720CB10", Offset = "0x720B310", VA = "0x18720CB10", Slot = "5")]
	public ushort[] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public IJPMHOKGHCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class IJFAHFAKJPJ : BMLPDKFJOPL<uint>, BNDBHHCFNCL, KMDHLAFMGKK<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly IJFAHFAKJPJ BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x720C1D0", Offset = "0x720A9D0", VA = "0x18720C1D0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, uint IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x720C230", Offset = "0x720AA30", VA = "0x18720C230", Slot = "5")]
	public uint PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x720C0A0", Offset = "0x720A8A0", VA = "0x18720C0A0", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, uint IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x720C110", Offset = "0x720A910", VA = "0x18720C110", Slot = "7")]
	public uint GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public IJFAHFAKJPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class KELGILIPBHA : BMLPDKFJOPL<uint?>, BNDBHHCFNCL, KMDHLAFMGKK<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly KELGILIPBHA BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x720FEC0", Offset = "0x720E6C0", VA = "0x18720FEC0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, uint? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x720FF80", Offset = "0x720E780", VA = "0x18720FF80", Slot = "5")]
	public uint? PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x720FCE0", Offset = "0x720E4E0", VA = "0x18720FCE0", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, uint? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x720FDA0", Offset = "0x720E5A0", VA = "0x18720FDA0", Slot = "7")]
	public uint? GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public KELGILIPBHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class EEIMFOBKJFN : BMLPDKFJOPL<uint[]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly EEIMFOBKJFN BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x7208450", Offset = "0x7206C50", VA = "0x187208450", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, uint[] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x7208580", Offset = "0x7206D80", VA = "0x187208580", Slot = "5")]
	public uint[] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public EEIMFOBKJFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class EOBLEENIBEO : BMLPDKFJOPL<ulong>, BNDBHHCFNCL, KMDHLAFMGKK<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly EOBLEENIBEO BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x72088B0", Offset = "0x72070B0", VA = "0x1872088B0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, ulong IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x7208910", Offset = "0x7207110", VA = "0x187208910", Slot = "5")]
	public ulong PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x7208780", Offset = "0x7206F80", VA = "0x187208780", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, ulong IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x72087F0", Offset = "0x7206FF0", VA = "0x1872087F0", Slot = "7")]
	public ulong GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public EOBLEENIBEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class KJCEGKMHOHI : BMLPDKFJOPL<ulong?>, BNDBHHCFNCL, KMDHLAFMGKK<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly KJCEGKMHOHI BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x72102A0", Offset = "0x720EAA0", VA = "0x1872102A0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, ulong? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x7210360", Offset = "0x720EB60", VA = "0x187210360", Slot = "5")]
	public ulong? PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x72100A0", Offset = "0x720E8A0", VA = "0x1872100A0", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, ulong? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x7210160", Offset = "0x720E960", VA = "0x187210160", Slot = "7")]
	public ulong? GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public KJCEGKMHOHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class BGKLDLCPIDO : BMLPDKFJOPL<ulong[]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly BGKLDLCPIDO BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x7205880", Offset = "0x7204080", VA = "0x187205880", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, ulong[] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x72059B0", Offset = "0x72041B0", VA = "0x1872059B0", Slot = "5")]
	public ulong[] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public BGKLDLCPIDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class IKDBPGKEDIK : BMLPDKFJOPL<float>, BNDBHHCFNCL, KMDHLAFMGKK<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly IKDBPGKEDIK BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x720CE40", Offset = "0x720B640", VA = "0x18720CE40", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, float IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x720CEA0", Offset = "0x720B6A0", VA = "0x18720CEA0", Slot = "5")]
	public float PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x720CD10", Offset = "0x720B510", VA = "0x18720CD10", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, float IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x720CD80", Offset = "0x720B580", VA = "0x18720CD80", Slot = "7")]
	public float GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public IKDBPGKEDIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class LKMNENPAMCL : BMLPDKFJOPL<float?>, BNDBHHCFNCL, KMDHLAFMGKK<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly LKMNENPAMCL BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7211CE0", Offset = "0x72104E0", VA = "0x187211CE0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, float? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7211DA0", Offset = "0x72105A0", VA = "0x187211DA0", Slot = "5")]
	public float? PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7211B00", Offset = "0x7210300", VA = "0x187211B00", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, float? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7211BC0", Offset = "0x72103C0", VA = "0x187211BC0", Slot = "7")]
	public float? GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public LKMNENPAMCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class KJMKAJOEKEI : BMLPDKFJOPL<float[]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly KJMKAJOEKEI BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7210490", Offset = "0x720EC90", VA = "0x187210490", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, float[] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x72105D0", Offset = "0x720EDD0", VA = "0x1872105D0", Slot = "5")]
	public float[] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public KJMKAJOEKEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class PGNCKGOOJLF : BMLPDKFJOPL<double>, BNDBHHCFNCL, KMDHLAFMGKK<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly PGNCKGOOJLF BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x72156C0", Offset = "0x7213EC0", VA = "0x1872156C0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, double IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7215720", Offset = "0x7213F20", VA = "0x187215720", Slot = "5")]
	public double PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7215590", Offset = "0x7213D90", VA = "0x187215590", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, double IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7215600", Offset = "0x7213E00", VA = "0x187215600", Slot = "7")]
	public double GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public PGNCKGOOJLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class JLEFAFCPPOA : BMLPDKFJOPL<double?>, BNDBHHCFNCL, KMDHLAFMGKK<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly JLEFAFCPPOA BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x720EB40", Offset = "0x720D340", VA = "0x18720EB40", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, double? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x720EC00", Offset = "0x720D400", VA = "0x18720EC00", Slot = "5")]
	public double? PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x720E940", Offset = "0x720D140", VA = "0x18720E940", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, double? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x720EA00", Offset = "0x720D200", VA = "0x18720EA00", Slot = "7")]
	public double? GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public JLEFAFCPPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class JALPKLDMEHL : BMLPDKFJOPL<double[]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly JALPKLDMEHL BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x720D1B0", Offset = "0x720B9B0", VA = "0x18720D1B0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, double[] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x720D2F0", Offset = "0x720BAF0", VA = "0x18720D2F0", Slot = "5")]
	public double[] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public JALPKLDMEHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class CAJCIKAFIIH : BMLPDKFJOPL<bool>, BNDBHHCFNCL, KMDHLAFMGKK<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly CAJCIKAFIIH BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7206B20", Offset = "0x7205320", VA = "0x187206B20", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, bool IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7206B80", Offset = "0x7205380", VA = "0x187206B80", Slot = "5")]
	public bool PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x72069F0", Offset = "0x72051F0", VA = "0x1872069F0", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, bool IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7206A60", Offset = "0x7205260", VA = "0x187206A60", Slot = "7")]
	public bool GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public CAJCIKAFIIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class FOOHEHACONI : BMLPDKFJOPL<bool?>, BNDBHHCFNCL, KMDHLAFMGKK<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly FOOHEHACONI BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x72093E0", Offset = "0x7207BE0", VA = "0x1872093E0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, bool? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x72094A0", Offset = "0x7207CA0", VA = "0x1872094A0", Slot = "5")]
	public bool? PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x7209200", Offset = "0x7207A00", VA = "0x187209200", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, bool? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x72092C0", Offset = "0x7207AC0", VA = "0x1872092C0", Slot = "7")]
	public bool? GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public FOOHEHACONI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class IIOPPGBEANJ : BMLPDKFJOPL<bool[]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly IIOPPGBEANJ BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x720BD60", Offset = "0x720A560", VA = "0x18720BD60", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, bool[] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x720BEA0", Offset = "0x720A6A0", VA = "0x18720BEA0", Slot = "5")]
	public bool[] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public IIOPPGBEANJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class OFEFFHLDGEE : BMLPDKFJOPL<object>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly BMLPDKFJOPL<object> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly Dictionary<Type, int> BEGGHNGEAJB;

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7212D60", Offset = "0x7211560", VA = "0x187212D60", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, object IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7213A50", Offset = "0x7212250", VA = "0x187213A50", Slot = "5")]
	public object PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public OFEFFHLDGEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class MNKEIFAMIBD : BMLPDKFJOPL<byte[]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly BMLPDKFJOPL<byte[]> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x72127A0", Offset = "0x7210FA0", VA = "0x1872127A0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, byte[] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x7212860", Offset = "0x7211060", VA = "0x187212860", Slot = "5")]
	public byte[] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public MNKEIFAMIBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class OMHNNDAGJFE : BMLPDKFJOPL<ArraySegment<byte>>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly BMLPDKFJOPL<ArraySegment<byte>> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x7214AF0", Offset = "0x72132F0", VA = "0x187214AF0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, ArraySegment<byte> IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x7214C20", Offset = "0x7213420", VA = "0x187214C20", Slot = "5")]
	public ArraySegment<byte> PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public OMHNNDAGJFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class AIOPJEBFJED : BMLPDKFJOPL<string>, BNDBHHCFNCL, KMDHLAFMGKK<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly BMLPDKFJOPL<string> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x7205760", Offset = "0x7203F60", VA = "0x187205760", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, string IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x72057C0", Offset = "0x7203FC0", VA = "0x1872057C0", Slot = "5")]
	public string PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x72056B0", Offset = "0x7203EB0", VA = "0x1872056B0", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, string IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x7205710", Offset = "0x7203F10", VA = "0x187205710", Slot = "7")]
	public string GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public AIOPJEBFJED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class AGNDNIJPKDN : BMLPDKFJOPL<string[]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly AGNDNIJPKDN BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x7205340", Offset = "0x7203B40", VA = "0x187205340", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, string[] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x7205470", Offset = "0x7203C70", VA = "0x187205470", Slot = "5")]
	public string[] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public AGNDNIJPKDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class AFGFDBLJAIG : BMLPDKFJOPL<char>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly AFGFDBLJAIG BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x72051A0", Offset = "0x72039A0", VA = "0x1872051A0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, char IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x7205260", Offset = "0x7203A60", VA = "0x187205260", Slot = "5")]
	public char PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public AFGFDBLJAIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class EDEOAAACCCA : BMLPDKFJOPL<char?>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly EDEOAAACCCA BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x72081D0", Offset = "0x72069D0", VA = "0x1872081D0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, char? IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x72082D0", Offset = "0x7206AD0", VA = "0x1872082D0", Slot = "5")]
	public char? PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public EDEOAAACCCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class NDAMMFILCGD : BMLPDKFJOPL<char[]>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly NDAMMFILCGD BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x7212980", Offset = "0x7211180", VA = "0x187212980", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, char[] IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x7212B30", Offset = "0x7211330", VA = "0x187212B30", Slot = "5")]
	public char[] PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public NDAMMFILCGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class FHLDDKIJIBN : BMLPDKFJOPL<Guid>, BNDBHHCFNCL, KMDHLAFMGKK<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly BMLPDKFJOPL<Guid> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x7208FD0", Offset = "0x72077D0", VA = "0x187208FD0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, Guid IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x7209100", Offset = "0x7207900", VA = "0x187209100", Slot = "5")]
	public Guid PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x7208DF0", Offset = "0x72075F0", VA = "0x187208DF0", Slot = "6")]
	public void BOCCCKFIBOF(DPHIKHGFLNL COHNONCDMOG, Guid IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x7208F30", Offset = "0x7207730", VA = "0x187208F30", Slot = "7")]
	public Guid GJMBLEPJFFL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public FHLDDKIJIBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class HBMFMFDHJMM : BMLPDKFJOPL<decimal>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly BMLPDKFJOPL<decimal> BMGLDIIFJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly bool CGOAFLJGDBM;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x599EF50", Offset = "0x599D750", VA = "0x18599EF50")]
	public HBMFMFDHJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x1A099A0", Offset = "0x1A081A0", VA = "0x181A099A0")]
	public HBMFMFDHJMM(bool CGOAFLJGDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x72097D0", Offset = "0x7207FD0", VA = "0x1872097D0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, decimal IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x7209980", Offset = "0x7208180", VA = "0x187209980", Slot = "5")]
	public decimal PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class OLKFLALPGPL : BMLPDKFJOPL<Uri>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly BMLPDKFJOPL<Uri> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x72148E0", Offset = "0x72130E0", VA = "0x1872148E0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, Uri IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x72149C0", Offset = "0x72131C0", VA = "0x1872149C0", Slot = "5")]
	public Uri PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public OLKFLALPGPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class HMMHBKAKPNM : BMLPDKFJOPL<Version>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly BMLPDKFJOPL<Version> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x720A1C0", Offset = "0x72089C0", VA = "0x18720A1C0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, Version IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x720A280", Offset = "0x7208A80", VA = "0x18720A280", Slot = "5")]
	public Version PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public HMMHBKAKPNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class DNPCNFJOONO<TKey, TValue> : BMLPDKFJOPL<KeyValuePair<TKey, TValue>>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x57B5CA0", Offset = "0x57B44A0", VA = "0x1857B5CA0", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, KeyValuePair<TKey, TValue> IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x57B5EB0", Offset = "0x57B46B0", VA = "0x1857B5EB0", Slot = "5")]
	public KeyValuePair<TKey, TValue> PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class FGGEAMGIPNJ : BMLPDKFJOPL<StringBuilder>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly BMLPDKFJOPL<StringBuilder> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x7208C20", Offset = "0x7207420", VA = "0x187208C20", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, StringBuilder IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x7208CC0", Offset = "0x72074C0", VA = "0x187208CC0", Slot = "5")]
	public StringBuilder PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public FGGEAMGIPNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class ABCAGNADGOC : BMLPDKFJOPL<BitArray>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly BMLPDKFJOPL<BitArray> BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x7204B60", Offset = "0x7203360", VA = "0x187204B60", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, BitArray IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x7204C80", Offset = "0x7203480", VA = "0x187204C80", Slot = "5")]
	public BitArray PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public ABCAGNADGOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class DNDENGLHIDP : BMLPDKFJOPL<Type>, BNDBHHCFNCL
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly DNDENGLHIDP BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly Regex BEJNLPLCNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private bool EPJFHJIGDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private bool GGIMPHHKCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool JKGIHPJBFLL;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x7207AC0", Offset = "0x72062C0", VA = "0x187207AC0")]
	public DNDENGLHIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x673FB70", Offset = "0x673E370", VA = "0x18673FB70")]
	public DNDENGLHIDP(bool EPJFHJIGDKC, bool GGIMPHHKCLB, bool JKGIHPJBFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x7207780", Offset = "0x7205F80", VA = "0x187207780", Slot = "4")]
	public void HNAIEAEAFJH(DPHIKHGFLNL COHNONCDMOG, Type IPHHABIKCHD, JOEIFIPPNIH GDGENEHPBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x7207890", Offset = "0x7206090", VA = "0x187207890", Slot = "5")]
	public Type PKPMANIAHDL(JHNPEGAMHPK PJOJHFLPHKO, JOEIFIPPNIH GDGENEHPBON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal static class AAMHLCDNKIF
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal static readonly byte[][] ALJKJCOFBGE;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal static readonly FGNFHJHBHAN GGNFCDCCFKJ;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x7204950", Offset = "0x7203150", VA = "0x187204950")]
	static AAMHLCDNKIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal static class GOODNNPHDCL
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal static readonly byte[][] KLOPCGFIJLH;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal static readonly FGNFHJHBHAN PFAGGEIODBM;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x72095C0", Offset = "0x7207DC0", VA = "0x1872095C0")]
	static GOODNNPHDCL()
	{
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
