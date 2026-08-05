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
	[Cpp2IlInjected.Address(RVA = "0x561480", Offset = "0x55FC80", VA = "0x180561480")]
	public PGEFNABIJLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class JBKICNNNEND : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x561480", Offset = "0x55FC80", VA = "0x180561480")]
	public JBKICNNNEND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class IBDNCBPICCH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x561480", Offset = "0x55FC80", VA = "0x180561480")]
	public IBDNCBPICCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class LAHILMNMJEG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x561480", Offset = "0x55FC80", VA = "0x180561480")]
	public LAHILMNMJEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class LPALAFPFBFP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3354E70", Offset = "0x3353670", VA = "0x183354E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x561490", Offset = "0x55FC90", VA = "0x180561490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] ECHILMPMJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3F0", Offset = "0x6AABF0", VA = "0x1806AC3F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1E5C670", Offset = "0x1E5AE70", VA = "0x181E5C670")]
	public static global::GNGMIEPFFIJ<T> LMKHMGBPDFD<T>(this CDLCJJDIPKK NAFMEEIPPLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4D88620", Offset = "0x4D86E20", VA = "0x184D88620")]
	public static object FMMIPFPBFBM(this CDLCJJDIPKK NAFMEEIPPLF, Type DMBEFJIHONB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MAOMCHDIICH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D7A530", Offset = "0x4D78D30", VA = "0x184D7A530")]
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
		[Cpp2IlInjected.Address(RVA = "0x4D7A420", Offset = "0x4D78C20", VA = "0x184D7A420")]
		public static byte[] BINHNLGNBCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4D7A4A0", Offset = "0x4D78CA0", VA = "0x184D7A4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4D85710", Offset = "0x4D83F10", VA = "0x184D85710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4D86410", Offset = "0x4D84C10", VA = "0x184D86410")]
	public OEHFEJKEOBN(byte[] JNPIAJHKCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4D86420", Offset = "0x4D84C20", VA = "0x184D86420")]
	public OEHFEJKEOBN(byte[] JNPIAJHKCKB, int JNMGKKFIPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4D840F0", Offset = "0x4D828F0", VA = "0x184D840F0")]
	private KECNDMPEHCE EPHIBJDCEIJ(string PAIKHKPBKDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4D83D00", Offset = "0x4D82500", VA = "0x184D83D00")]
	private KECNDMPEHCE CLCALCENPGH(string LMJMILCCPPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2BD85F0", Offset = "0x2BD6DF0", VA = "0x182BD85F0")]
	public void CFNIALOHDFI(int JNMGKKFIPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x73EEF0", Offset = "0x73D6F0", VA = "0x18073EEF0")]
	public byte[] KMAEDEGKMFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7961A0", Offset = "0x7949A0", VA = "0x1807961A0")]
	public int HICAHIDNFFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4D86090", Offset = "0x4D84890", VA = "0x184D86090")]
	public OCHPDHMKLKL OPMPEGAOPGD()
	{
		return default(OCHPDHMKLKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4D85790", Offset = "0x4D83F90", VA = "0x184D85790")]
	public void LACAHFFCEPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4D858D0", Offset = "0x4D840D0", VA = "0x184D858D0")]
	public bool LJHFMNIBGAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4D85B50", Offset = "0x4D84350", VA = "0x184D85B50")]
	public bool NDELIOOHIDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4D83FF0", Offset = "0x4D827F0", VA = "0x184D83FF0")]
	public void ENDLPPAFAFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4D86000", Offset = "0x4D84800", VA = "0x184D86000")]
	public bool OGLJCMMNLJP(ref int KLPGLGDELCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4D83B70", Offset = "0x4D82370", VA = "0x184D83B70")]
	public bool BGNMDILOLCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4D83F50", Offset = "0x4D82750", VA = "0x184D83F50")]
	public void EECIMJOJCKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4D848A0", Offset = "0x4D830A0", VA = "0x184D848A0")]
	public bool FKIAHOGJGAP(ref int KLPGLGDELCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4D84590", Offset = "0x4D82D90", VA = "0x184D84590")]
	public bool EPIKFNJJDGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4D85610", Offset = "0x4D83E10", VA = "0x184D85610")]
	public void IKPPLMFIINP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4D83EE0", Offset = "0x4D826E0", VA = "0x184D83EE0")]
	public bool EDMENFHCBIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D84C60", Offset = "0x4D83460", VA = "0x184D84C60")]
	public void HJALKNJGKPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4D84D00", Offset = "0x4D83500", VA = "0x184D84D00")]
	private void HLBLMDJLIMN(out byte[] IKFKPAPAEBN, out int ENAOKCLPKKN, out int JMKEJECELHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4D839D0", Offset = "0x4D821D0", VA = "0x184D839D0")]
	private static int AAEPHBHPMBL(char OOKPIHBNHGF, char FMMAACMCILJ, char MCODHPOGBPN, char HFCLJHDBBCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4D83E10", Offset = "0x4D82610", VA = "0x184D83E10")]
	private static int EDDPLEIKPIE(char FMMKCBAOFKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4D83A80", Offset = "0x4D82280", VA = "0x184D83A80")]
	public ArraySegment<byte> BBHJOIMLKDO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4D85A70", Offset = "0x4D84270", VA = "0x184D85A70")]
	public string MGPMLPEBCIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4D83DE0", Offset = "0x4D825E0", VA = "0x184D83DE0")]
	public string DJOOILOHCKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4D84AB0", Offset = "0x4D832B0", VA = "0x184D84AB0")]
	public ArraySegment<byte> HDOGKPNIOAJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4D85B10", Offset = "0x4D84310", VA = "0x184D85B10")]
	public ArraySegment<byte> MPFPIODOIMN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4D85DA0", Offset = "0x4D845A0", VA = "0x184D85DA0")]
	public bool NMDHLIHHCGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4D85550", Offset = "0x4D83D50", VA = "0x184D85550")]
	private static bool IGGKAKCMBIJ(byte MCODHPOGBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4D846D0", Offset = "0x4D82ED0", VA = "0x184D846D0")]
	private void FDCNHCPPDKB(OCHPDHMKLKL JGMHCJIBOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4D83BE0", Offset = "0x4D823E0", VA = "0x184D83BE0")]
	public void BICMNEAPABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4D84600", Offset = "0x4D82E00", VA = "0x184D84600")]
	private void FCODKPEMDJE(int OGFADADBCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4D83CB0", Offset = "0x4D824B0", VA = "0x184D83CB0")]
	public sbyte CIBCICNHDEP()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4D856B0", Offset = "0x4D83EB0", VA = "0x184D856B0")]
	public short JFNBLPCFJNA()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4D85490", Offset = "0x4D83C90", VA = "0x184D85490")]
	public int IADEKJMJPCB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4D86220", Offset = "0x4D84A20", VA = "0x184D86220")]
	public long PDNJOIHCIMK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4D854F0", Offset = "0x4D83CF0", VA = "0x184D854F0")]
	public byte ICIFIELEFNN()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4D84090", Offset = "0x4D82890", VA = "0x184D84090")]
	public ushort EOHFCNGBOBB()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4D85730", Offset = "0x4D83F30", VA = "0x184D85730")]
	public uint KENAGGIFPAD()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4D859F0", Offset = "0x4D841F0", VA = "0x184D859F0")]
	public ulong LOHPENPIKBJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4D85CE0", Offset = "0x4D844E0", VA = "0x184D85CE0")]
	public float NMACLDDIGFF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4D83BF0", Offset = "0x4D823F0", VA = "0x184D83BF0")]
	public double BNFLDCEMKIP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4D85BC0", Offset = "0x4D843C0", VA = "0x184D85BC0")]
	public ArraySegment<byte> NEOBNKGBJNP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4D84930", Offset = "0x4D83130", VA = "0x184D84930")]
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
		[Cpp2IlInjected.Address(RVA = "0xFA1850", Offset = "0xFA0050", VA = "0x180FA1850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string DNEEMDFEDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5FBE10", Offset = "0x5FA610", VA = "0x1805FBE10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3345FB0", Offset = "0x33447B0", VA = "0x183345FB0")]
	public KECNDMPEHCE(string LMJMILCCPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3345EE0", Offset = "0x33446E0", VA = "0x183345EE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
				public EDLAHFGPCLJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x333D920", Offset = "0x333C120", VA = "0x18333D920")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x333D960", Offset = "0x333C160", VA = "0x18333D960")]
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
			[Cpp2IlInjected.Address(RVA = "0x333DDB0", Offset = "0x333C5B0", VA = "0x18333DDB0")]
			public FKEMHNBEMOP(Type DMBEFJIHONB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x21DF5B0", Offset = "0x21DDDB0", VA = "0x1821DF5B0")]
			private static T IEFDKOEAMEE<T>(DynamicMethod JLKJEEKLBGF)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x333DBC0", Offset = "0x333C3C0", VA = "0x18333DBC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3352D10", Offset = "0x3351510", VA = "0x183352D10")]
		static LAJJEEDFDKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3352A10", Offset = "0x3351210", VA = "0x183352A10")]
		private static FKEMHNBEMOP IFPEMELNPAG(Type DMBEFJIHONB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3352BA0", Offset = "0x33513A0", VA = "0x183352BA0")]
		public static void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, object MFBIHMKFNKA, CDLCJJDIPKK NAFMEEIPPLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3352A90", Offset = "0x3351290", VA = "0x183352A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x3354EA0", Offset = "0x33536A0", VA = "0x183354EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3354270", Offset = "0x3352A70", VA = "0x183354270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3354210", Offset = "0x3352A10", VA = "0x183354210")]
	public static void CGADGJIHMCE(CDLCJJDIPKK NAFMEEIPPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3AC9F00", Offset = "0x3AC8700", VA = "0x183AC9F00")]
	public static string GKBFKAMHNKO<T>(T MFBIHMKFNKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3AC9F80", Offset = "0x3AC8780", VA = "0x183AC9F80")]
	public static string GKBFKAMHNKO<T>(T MFBIHMKFNKA, CDLCJJDIPKK NAFMEEIPPLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x21E51F0", Offset = "0x21E39F0", VA = "0x1821E51F0")]
	public static T GPGJANKJBGF<T>(string DCKKJLGKFJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x21E5120", Offset = "0x21E3920", VA = "0x1821E5120")]
	public static T GPGJANKJBGF<T>(string DCKKJLGKFJJ, CDLCJJDIPKK NAFMEEIPPLF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x21E50A0", Offset = "0x21E38A0", VA = "0x1821E50A0")]
	public static T GPGJANKJBGF<T>(byte[] JNPIAJHKCKB, CDLCJJDIPKK NAFMEEIPPLF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x21E5270", Offset = "0x21E3A70", VA = "0x1821E5270")]
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
		[Cpp2IlInjected.Address(RVA = "0x7961A0", Offset = "0x7949A0", VA = "0x1807961A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2BD85F0", Offset = "0x2BD6DF0", VA = "0x182BD85F0")]
	public void CFNIALOHDFI(int JNMGKKFIPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8FD0", Offset = "0x2BD77D0", VA = "0x182BD8FD0")]
	public static byte[] MEIBHGMOOOA(string CLFMNLIOIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9260", Offset = "0x2BD7A60", VA = "0x182BD9260")]
	public static byte[] OBHPNOBENBP(string CLFMNLIOIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8A70", Offset = "0x2BD7270", VA = "0x182BD8A70")]
	public static byte[] KAMIPDHKGMC(string CLFMNLIOIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2BD93A0", Offset = "0x2BD7BA0", VA = "0x182BD93A0")]
	public static byte[] OELIGPMOFNO(string CLFMNLIOIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xBAEE10", Offset = "0xBAD610", VA = "0x180BAEE10")]
	public AAEIOLMBBFI(byte[] ODPEDFJHOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8440", Offset = "0x2BD6C40", VA = "0x182BD8440")]
	public ArraySegment<byte> BINHNLGNBCP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2BD86A0", Offset = "0x2BD6EA0", VA = "0x182BD86A0")]
	public byte[] ELEKJKAINJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2BD95C0", Offset = "0x2BD7DC0", VA = "0x182BD95C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9390", Offset = "0x2BD7B90", VA = "0x182BD9390")]
	public void OCMKAFFOPBE(int AFOPANCEIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2BD89B0", Offset = "0x2BD71B0", VA = "0x182BD89B0")]
	public void JEBBKEDNIDB(byte[] MCKANBDEMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9580", Offset = "0x2BD7D80", VA = "0x182BD9580")]
	public void OPEMDBOHMHA(byte MCKANBDEMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2BD90B0", Offset = "0x2BD78B0", VA = "0x182BD90B0")]
	public void MJOGEHFPKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8770", Offset = "0x2BD6F70", VA = "0x182BD8770")]
	public void IKIJLOIDJJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8600", Offset = "0x2BD6E00", VA = "0x182BD8600")]
	public void CNPCGDHOGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9190", Offset = "0x2BD7990", VA = "0x182BD9190")]
	public void NIFFEIFNODL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8650", Offset = "0x2BD6E50", VA = "0x182BD8650")]
	public void DDCPAOOPLLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8720", Offset = "0x2BD6F20", VA = "0x182BD8720")]
	public void IBGLIMPLHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8390", Offset = "0x2BD6B90", VA = "0x182BD8390")]
	public void BBGOPDCGGKL(string CLFMNLIOIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2BD83F0", Offset = "0x2BD6BF0", VA = "0x182BD83F0")]
	public void BCJLPHMEFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2BD84F0", Offset = "0x2BD6CF0", VA = "0x182BD84F0")]
	public void CBFGJPAIBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2BD87C0", Offset = "0x2BD6FC0", VA = "0x182BD87C0")]
	public void JCONOFHFIBJ(bool MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9500", Offset = "0x2BD7D00", VA = "0x182BD9500")]
	public void OFHKCFOCLDG(float MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2BD91E0", Offset = "0x2BD79E0", VA = "0x182BD91E0")]
	public void NPFPHCLAJGB(double MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9130", Offset = "0x2BD7930", VA = "0x182BD9130")]
	public void NCDDDCJCECL(byte MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8A40", Offset = "0x2BD7240", VA = "0x182BD8A40")]
	public void JOOHNHNCIJK(ushort MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8A10", Offset = "0x2BD7210", VA = "0x182BD8A10")]
	public void JFGBMEPAIAH(uint MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2BD85C0", Offset = "0x2BD6DC0", VA = "0x182BD85C0")]
	public void CBMIBDNIBLD(ulong MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8BA0", Offset = "0x2BD73A0", VA = "0x182BD8BA0")]
	public void KBLONKMNNOF(sbyte MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8FA0", Offset = "0x2BD77A0", VA = "0x182BD8FA0")]
	public void KHCBDPHNLAI(short MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9160", Offset = "0x2BD7960", VA = "0x182BD9160")]
	public void NDOOAKJIMOB(int MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9100", Offset = "0x2BD7900", VA = "0x182BD9100")]
	public void NBPJKGDINEF(long MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8BD0", Offset = "0x2BD73D0", VA = "0x182BD8BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C33610", Offset = "0x3C31E10", VA = "0x183C33610")]
		static GLIMPLAKAHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private LBLIMMJIFHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDA880", Offset = "0x2BD9080", VA = "0x182BDA880")]
	static ANHFFHCNDFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA320", Offset = "0x2BD8B20", VA = "0x182BDA320")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDF700", Offset = "0x2BDDF00", VA = "0x182BDF700")]
	public EBDBMKCGEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2BDF590", Offset = "0x2BDDD90", VA = "0x182BDF590", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Vector2 MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2BDF3A0", Offset = "0x2BDDBA0", VA = "0x182BDF3A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDFD60", Offset = "0x2BDE560", VA = "0x182BDFD60")]
	public EDGOMKKOGDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2BDFB50", Offset = "0x2BDE350", VA = "0x182BDFB50", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Vector3 MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2BDF910", Offset = "0x2BDE110", VA = "0x182BDF910", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE5CB0", Offset = "0x2BE44B0", VA = "0x182BE5CB0")]
	public FOFKEPCFLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2BDDB10", Offset = "0x2BDC310", VA = "0x182BDDB10", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Vector4 MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5A20", Offset = "0x2BE4220", VA = "0x182BE5A20", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDDD80", Offset = "0x2BDC580", VA = "0x182BDDD80")]
	public CPJJJAJCCGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2BDDB10", Offset = "0x2BDC310", VA = "0x182BDDB10", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Quaternion MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD880", Offset = "0x2BDC080", VA = "0x182BDD880", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3354830", Offset = "0x3353030", VA = "0x183354830")]
	public LIIIMNCJKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x33546E0", Offset = "0x3352EE0", VA = "0x1833546E0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Color MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x33544B0", Offset = "0x3352CB0", VA = "0x1833544B0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BEAC10", Offset = "0x2BE9410", VA = "0x182BEAC10")]
	public HIMBCJMHFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA910", Offset = "0x2BE9110", VA = "0x182BEA910", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Bounds MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA610", Offset = "0x2BE8E10", VA = "0x182BEA610", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3350BB0", Offset = "0x334F3B0", VA = "0x183350BB0")]
	public KNFFNCELKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3350A40", Offset = "0x334F240", VA = "0x183350A40", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Rect MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x33507E0", Offset = "0x334EFE0", VA = "0x1833507E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x36841C0", Offset = "0x36829C0", VA = "0x1836841C0")]
		static OFMOJCBFIBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private HLBHJIGLFHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x34737B0", Offset = "0x3471FB0", VA = "0x1834737B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BEF960", Offset = "0x2BEE160", VA = "0x182BEF960")]
		internal static object HEFFENOJKIB(Type AHIMPPGEGDB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private CMGPPKNAJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x25E5540", Offset = "0x25E3D40", VA = "0x1825E5540")]
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
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private FGDFLGPIDBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2BE48F0", Offset = "0x2BE30F0", VA = "0x182BE48F0")]
	public static void EPCONIMEHBH(params CDLCJJDIPKK[] OGFLOHJOBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2BE49B0", Offset = "0x2BE31B0", VA = "0x182BE49B0")]
	public static void EPCONIMEHBH(params OHDNNHIHLFA[] OIMDJOAKBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2BE4A70", Offset = "0x2BE3270", VA = "0x182BE4A70")]
	public static void JEGPGCEMJPE(OHDNNHIHLFA[] OIMDJOAKBOK, CDLCJJDIPKK[] OGFLOHJOBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3968F10", Offset = "0x3967710", VA = "0x183968F10")]
		static IGDAKOMCCBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private NFEMCLHEBMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BEB840", Offset = "0x2BEA040", VA = "0x182BEB840")]
	internal static object HEFFENOJKIB(Type AHIMPPGEGDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB800", Offset = "0x2BEA000", VA = "0x182BEB800")]
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
		[Cpp2IlInjected.Address(RVA = "0x36287F0", Offset = "0x3626FF0", VA = "0x1836287F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDBFE0", Offset = "0x2BDA7E0", VA = "0x182BDBFE0")]
	static BKBJLDMFGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private BKBJLDMFGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F91600", Offset = "0x1F8FE00", VA = "0x181F91600")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BD9720", Offset = "0x2BD7F20", VA = "0x182BD9720")]
	static ADAGFHMDMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private ADAGFHMDMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D87390", Offset = "0x3D85B90", VA = "0x183D87390")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D86600", Offset = "0x4D84E00", VA = "0x184D86600")]
	static OFADMBMAJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private OFADMBMAJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F863B0", Offset = "0x1F84BB0", VA = "0x181F863B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BD9810", Offset = "0x2BD8010", VA = "0x182BD9810")]
	static AEJCHFPPCDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private AEJCHFPPCDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3671CB0", Offset = "0x36704B0", VA = "0x183671CB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BEB050", Offset = "0x2BE9850", VA = "0x182BEB050")]
	static HLNHHAIHFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private HLNHHAIHFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x346F140", Offset = "0x346D940", VA = "0x18346F140")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDD4E0", Offset = "0x2BDBCE0", VA = "0x182BDD4E0")]
	static COJCBINPGFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private COJCBINPGFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x26DDD90", Offset = "0x26DC590", VA = "0x1826DDD90")]
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
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FD9920", Offset = "0x3FD8120", VA = "0x183FD9920")]
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
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3913250", Offset = "0x3911A50", VA = "0x183913250")]
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
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D5D6B0", Offset = "0x3D5BEB0", VA = "0x183D5D6B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F82530", Offset = "0x1F80D30", VA = "0x181F82530")]
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
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3AACFB0", Offset = "0x3AAB7B0", VA = "0x183AACFB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
	public global::GNGMIEPFFIJ<T> HEFFENOJKIB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x334FAA0", Offset = "0x334E2A0", VA = "0x18334FAA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x333FA20", Offset = "0x333E220", VA = "0x18333FA20")]
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
		[Cpp2IlInjected.Address(RVA = "0x3351330", Offset = "0x334FB30", VA = "0x183351330")]
		public static MethodInfo PBGNCPABBCO(Type DMBEFJIHONB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3350FE0", Offset = "0x334F7E0", VA = "0x183350FE0")]
		public static MethodInfo GPGJANKJBGF(Type DMBEFJIHONB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3351210", Offset = "0x334FA10", VA = "0x183351210")]
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public GCAPCMGLFHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x333F940", Offset = "0x333E140", VA = "0x18333F940")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x333F980", Offset = "0x333E180", VA = "0x18333F980")]
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public BGGHBOAFJMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x333D880", Offset = "0x333C080", VA = "0x18333D880")]
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public FDPOMGKAOOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x333DB60", Offset = "0x333C360", VA = "0x18333DB60")]
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public IMDEJMAEAGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3341BE0", Offset = "0x33403E0", VA = "0x183341BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public AHNGKMAPHIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x333D3B0", Offset = "0x333BBB0", VA = "0x18333D3B0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x333D3C0", Offset = "0x333BBC0", VA = "0x18333D3C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public PPAFLNOOMCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3355360", Offset = "0x3353B60", VA = "0x183355360")]
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public PNELLENKDJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x569CC0", Offset = "0x5684C0", VA = "0x180569CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public IEPCIDHDNBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3340AF0", Offset = "0x333F2F0", VA = "0x183340AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public LLOAGOIMGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3354B20", Offset = "0x3353320", VA = "0x183354B20")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3354DD0", Offset = "0x33535D0", VA = "0x183354DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public CGBHGAEJECF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x153A890", Offset = "0x1539090", VA = "0x18153A890")]
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public HDNBJMJGNMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x153A890", Offset = "0x1539090", VA = "0x18153A890")]
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
	[Cpp2IlInjected.Address(RVA = "0x3ABCEA0", Offset = "0x3ABB6A0", VA = "0x183ABCEA0")]
	public static object FFGHFCGHJBO<T>(MCLELMOPFOG INCBBDEOLFN, CDLCJJDIPKK IHGGGGBNGPH, Func<string, string> LGGIIMDPDDL, bool MNNFBCODFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3AC69D0", Offset = "0x3AC51D0", VA = "0x183AC69D0")]
	public static object NICKPNGGGLO<T>(CDLCJJDIPKK IHGGGGBNGPH, Func<string, string> LGGIIMDPDDL, bool MNNFBCODFJI, bool LCNEOEILONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x334EAF0", Offset = "0x334D2F0", VA = "0x18334EAF0")]
	private static TypeInfo ONJHNNJKCKH(MCLELMOPFOG INCBBDEOLFN, Type DMBEFJIHONB, Func<string, string> LGGIIMDPDDL, bool MNNFBCODFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x334D1B0", Offset = "0x334B9B0", VA = "0x18334D1B0")]
	public static object MJJBPOGABLD(Type DMBEFJIHONB, Func<string, string> LGGIIMDPDDL, bool MNNFBCODFJI, bool LCNEOEILONM, bool KLBIDKBECOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x334B900", Offset = "0x334A100", VA = "0x18334B900")]
	private static Dictionary<GNFHJFKEAIP, FieldInfo> MHPGMAPOKHN(TypeBuilder ELAHAPCPBJF, APDPMECNMFK KEKKEELMMKA, ConstructorInfo EMKPCNJLLFD, FieldBuilder JBNFOPMKCBG, ILGenerator MMABJADPAFA, bool MNNFBCODFJI, bool HNJOBIAMMDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3349C40", Offset = "0x3348440", VA = "0x183349C40")]
	private static Dictionary<GNFHJFKEAIP, FieldInfo> JABDKKACKAC(TypeBuilder ELAHAPCPBJF, APDPMECNMFK KEKKEELMMKA, ILGenerator MMABJADPAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x334A3A0", Offset = "0x3348BA0", VA = "0x18334A3A0")]
	private static void MFCBLLHDOBF(Type DMBEFJIHONB, APDPMECNMFK KEKKEELMMKA, ILGenerator MMABJADPAFA, Action GHHAKODKFFO, Func<int, GNFHJFKEAIP, bool> APMBCLALOAP, bool MNNFBCODFJI, bool HNJOBIAMMDH, int FEBIGEJIHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3348000", Offset = "0x3346800", VA = "0x183348000")]
	private static void CCMBJPHLALJ(TypeInfo DMBEFJIHONB, GNFHJFKEAIP EBNJHOEANPC, ILGenerator MMABJADPAFA, int CFANIPEBCPB, Func<int, GNFHJFKEAIP, bool> APMBCLALOAP, MKFOPICEBFL EEDEJPBOCJL, MKFOPICEBFL LOOLBOIEBPN, MKFOPICEBFL HKPOPGCFJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x334BF50", Offset = "0x334A750", VA = "0x18334BF50")]
	private static void MJAFDPBHGGB(Type DMBEFJIHONB, APDPMECNMFK KEKKEELMMKA, ILGenerator MMABJADPAFA, Func<int, GNFHJFKEAIP, bool> APMBCLALOAP, bool JGJNAJFHALG, int FEBIGEJIHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3348BC0", Offset = "0x33473C0", VA = "0x183348BC0")]
	private static void DJOBJHAPJCJ(ILGenerator MMABJADPAFA, HAHPEHIBKLJ KEKKEELMMKA, int CFANIPEBCPB, Func<int, GNFHJFKEAIP, bool> APMBCLALOAP, MKFOPICEBFL OFLJDNJJLOF, MKFOPICEBFL HKPOPGCFJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3348FD0", Offset = "0x33477D0", VA = "0x183348FD0")]
	private static LocalBuilder HAIJBNHPIIP(ILGenerator MMABJADPAFA, Type DMBEFJIHONB, APDPMECNMFK KEKKEELMMKA, HAHPEHIBKLJ[] OKHFNLCAHJL, bool AFAJEDLLFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x33484F0", Offset = "0x3346CF0", VA = "0x1833484F0")]
	private static bool CHDJDMEBNPM(ConstructorInfo HPBBOIBDMEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x334A200", Offset = "0x3348A00", VA = "0x18334A200")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D8B040", Offset = "0x1D89840", VA = "0x181D8B040")]
		static AJCDFGMFJPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private IJBMMHJEBDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x34690B0", Offset = "0x34678B0", VA = "0x1834690B0")]
		static OMJPEKHADNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly CDLCJJDIPKK GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private CLMNKKMLHBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x391B0C0", Offset = "0x39198C0", VA = "0x18391B0C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3914F60", Offset = "0x3913760", VA = "0x183914F60")]
			static GIEEFHAODCF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		private JEIODKPHKLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private LPEJHAMAEHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3661BD0", Offset = "0x36603D0", VA = "0x183661BD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x366C760", Offset = "0x366AF60", VA = "0x18366C760")]
			static KDBPOKHPEBC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		private OBKGDNDNKEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private INDCIBLKMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C44A40", Offset = "0x3C43240", VA = "0x183C44A40")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C3D7E0", Offset = "0x3C3BFE0", VA = "0x183C3D7E0")]
			static LIEHPJJBOFB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		private HPNCAMICEGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private KOCPLNMDMKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3461AE0", Offset = "0x34602E0", VA = "0x183461AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x345DD30", Offset = "0x345C530", VA = "0x18345DD30")]
			static HCNFPOLOECJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		private FKGNAIBBBDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private CPNNANFDHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x253F310", Offset = "0x253DB10", VA = "0x18253F310")]
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
			[Cpp2IlInjected.Address(RVA = "0x25448E0", Offset = "0x25430E0", VA = "0x1825448E0")]
			static PDFDDLLNAFE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		private JLPCIKOBCNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private EOKJIFNHEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x361AD70", Offset = "0x3619570", VA = "0x18361AD70")]
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
			[Cpp2IlInjected.Address(RVA = "0x36295B0", Offset = "0x3627DB0", VA = "0x1836295B0")]
			static KKDKLPMHFOD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		private HEANNPPLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private BMEBEAMDGNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D772C0", Offset = "0x3D75AC0", VA = "0x183D772C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D89EB0", Offset = "0x3D886B0", VA = "0x183D89EB0")]
			static GDAMDLFOGJL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		private OFGBAFKAFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private OHCGEKFHPMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3569160", Offset = "0x3567960", VA = "0x183569160")]
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
			[Cpp2IlInjected.Address(RVA = "0x356F590", Offset = "0x356DD90", VA = "0x18356F590")]
			static EGDNNJFIMFE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		private FGMIKJGPHME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private HICGJIFEAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3755FD0", Offset = "0x37547D0", VA = "0x183755FD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37593E0", Offset = "0x3757BE0", VA = "0x1837593E0")]
			static IFJLEFENBBL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		private MHCLAMNBLIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private PEOMJOFGAIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x26E3110", Offset = "0x26E1910", VA = "0x1826E3110")]
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
			[Cpp2IlInjected.Address(RVA = "0x33573D0", Offset = "0x3355BD0", VA = "0x1833573D0")]
			static FANJOKFJAAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		private DAFDEBHMKPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private GGDOKIIHGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3966DE0", Offset = "0x39655E0", VA = "0x183966DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x42A4190", Offset = "0x42A2990", VA = "0x1842A4190")]
			static MPDAIMFIEJC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		private EPAACPMFBDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private NMDEKPCHDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E99BE0", Offset = "0x2E983E0", VA = "0x182E99BE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2EA0300", Offset = "0x2E9EB00", VA = "0x182EA0300")]
			static GMJOMKFAIKH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly CDLCJJDIPKK GBAAOFDIJNK;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly CDLCJJDIPKK[] OGFLOHJOBAM;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		private OELBAEMIOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	private JJOOAFEEODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B630", Offset = "0x1E59E30", VA = "0x181E5B630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29602A0", Offset = "0x295EAA0", VA = "0x1829602A0")]
	public KEOFDOOIBKE(int OCFGLOFAKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2960100", Offset = "0x295E900", VA = "0x182960100")]
	public void IONNJMGFDPB(T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x295FF90", Offset = "0x295E790", VA = "0x18295FF90")]
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
	[Cpp2IlInjected.Address(RVA = "0x3347FB0", Offset = "0x33467B0", VA = "0x183347FB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x49C3C40", Offset = "0x49C2440", VA = "0x1849C3C40")]
	public IDHAGBFMGDG(int GOANLIHDLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x49C3340", Offset = "0x49C1B40", VA = "0x1849C3340")]
	public T[] PJHMIFEODLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x49C22C0", Offset = "0x49C0AC0", VA = "0x1849C22C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x6723E0", Offset = "0x670BE0", VA = "0x1806723E0")]
			[DebuggerHidden]
			public GDNAMIJCFCD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x2BE6850", Offset = "0x2BE5050", VA = "0x182BE6850", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2BE6980", Offset = "0x2BE5180", VA = "0x182BE6980", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2BE68E0", Offset = "0x2BE50E0", VA = "0x182BE68E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<LNPEBJFKPBD> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2BE68E0", Offset = "0x2BE50E0", VA = "0x182BE68E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
			public DIGKDJJBLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x569CC0", Offset = "0x5684C0", VA = "0x180569CC0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x569CC0", Offset = "0x5684C0", VA = "0x180569CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x994030", Offset = "0x992830", VA = "0x180994030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2BEECB0", Offset = "0x2BED4B0", VA = "0x182BEECB0")]
		public LNPEBJFKPBD(ulong BJKKIOODGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BEDCB0", Offset = "0x2BEC4B0", VA = "0x182BEDCB0")]
		public LNPEBJFKPBD IONNJMGFDPB(ulong BJKKIOODGOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BEDC60", Offset = "0x2BEC460", VA = "0x182BEDC60")]
		public LNPEBJFKPBD IONNJMGFDPB(ulong BJKKIOODGOA, int MFBIHMKFNKA, string KJCNIJANGOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BEEA80", Offset = "0x2BED280", VA = "0x182BEEA80")]
		public LNPEBJFKPBD POLALCFNEIA(byte[] PAEJAEBLJPP, ref int JNMGKKFIPGA, ref int GCLIOHFGHHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BEDBE0", Offset = "0x2BEC3E0", VA = "0x182BEDBE0")]
		internal static int GMLGEIJHLMD(ulong[] ECGFLNEOIIM, int CFANIPEBCPB, int GFKNIIIDANB, ulong MFBIHMKFNKA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BEDB40", Offset = "0x2BEC340", VA = "0x182BEDB40", Slot = "4")]
		public int CompareTo(LNPEBJFKPBD GKBKHIIEFAH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BEDB70", Offset = "0x2BEC370", VA = "0x182BEDB70")]
		[IteratorStateMachine(typeof(GDNAMIJCFCD))]
		public IEnumerable<LNPEBJFKPBD> GLAEGPMBOLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BEDA10", Offset = "0x2BEC210", VA = "0x182BEDA10")]
		public void AAMFLAJDGLG(ILGenerator MMABJADPAFA, LocalBuilder PAEJAEBLJPP, LocalBuilder GCLIOHFGHHG, LocalBuilder BJKKIOODGOA, Action<KeyValuePair<string, int>> BMKFNKCDPAH, Action FOMBGGNGGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BEDEA0", Offset = "0x2BEC6A0", VA = "0x182BEDEA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x562000", Offset = "0x560800", VA = "0x180562000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BE5830", Offset = "0x2BE4030", VA = "0x182BE5830", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8C23F0", Offset = "0x8C0BF0", VA = "0x1808C23F0")]
		[DebuggerHidden]
		public FLFOJIFHFNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5880", Offset = "0x2BE4080", VA = "0x182BE5880", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2BE53C0", Offset = "0x2BE3BC0", VA = "0x182BE53C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5980", Offset = "0x2BE4180", VA = "0x182BE5980")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2BE59D0", Offset = "0x2BE41D0", VA = "0x182BE59D0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BE57E0", Offset = "0x2BE3FE0", VA = "0x182BE57E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5740", Offset = "0x2BE3F40", VA = "0x182BE5740", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5740", Offset = "0x2BE3F40", VA = "0x182BE5740", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDEEF0", Offset = "0x2BDD6F0", VA = "0x182BDEEF0")]
	public DHBJPFKPEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2BDECE0", Offset = "0x2BDD4E0", VA = "0x182BDECE0")]
	public void IONNJMGFDPB(byte[] JNPIAJHKCKB, int MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2BDEA90", Offset = "0x2BDD290", VA = "0x182BDEA90")]
	public bool DLAEEKDJJEA(ArraySegment<byte> BJKKIOODGOA, out int MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2BDEE00", Offset = "0x2BDD600", VA = "0x182BDEE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE810", Offset = "0x2BDD010", VA = "0x182BDE810")]
	private static void AAICFCFOMOD(IEnumerable<LNPEBJFKPBD> NAIOIGLPEFC, StringBuilder OHIGLHDFMBF, int LOOFANMHKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2BDEBB0", Offset = "0x2BDD3B0", VA = "0x182BDEBB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2BDEBB0", Offset = "0x2BDD3B0", VA = "0x182BDEBB0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2BDEB40", Offset = "0x2BDD340", VA = "0x182BDEB40")]
	[IteratorStateMachine(typeof(FLFOJIFHFNB))]
	private static IEnumerable<KeyValuePair<string, int>> DNCHJCPCJIA(IEnumerable<LNPEBJFKPBD> NAIOIGLPEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2BDECB0", Offset = "0x2BDD4B0", VA = "0x182BDECB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D82940", Offset = "0x4D81140", VA = "0x184D82940")]
	public static ulong OGHGFABPFFK(byte[] JNPIAJHKCKB, ref int JNMGKKFIPGA, ref int GCLIOHFGHHG)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class IGPJJODJGMD
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3340F40", Offset = "0x333F740", VA = "0x183340F40")]
	public static void OCMKAFFOPBE(ref byte[] JNPIAJHKCKB, int JNMGKKFIPGA, int AFOPANCEIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3340E50", Offset = "0x333F650", VA = "0x183340E50")]
	public static void MLMGPJPKAHF(ref byte[] ECGFLNEOIIM, int MPAHBNHIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x3340D60", Offset = "0x333F560", VA = "0x183340D60")]
	public static byte[] ADNCCGDNDOC(byte[] BEGAEBENGJM, int MPAHBNHIEDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class KHMPFADKCGB
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x3347C40", Offset = "0x3346440", VA = "0x183347C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x39FAE30", Offset = "0x39F9630", VA = "0x1839FAE30", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x1280CF0", Offset = "0x127F4F0", VA = "0x181280CF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x39B3F80", Offset = "0x39B2780", VA = "0x1839B3F80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1BA8590", Offset = "0x1BA6D90", VA = "0x181BA8590")]
		[DebuggerHidden]
		public HHFCAMCIICC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3A01170", Offset = "0x39FF970", VA = "0x183A01170", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3A01D50", Offset = "0x3A00550", VA = "0x183A01D50", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F6B070", Offset = "0x2F69870", VA = "0x182F6B070")]
	public LGPELLCOFBG(int FFHMMNBBJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2F6AFB0", Offset = "0x2F697B0", VA = "0x182F6AFB0")]
	public LGPELLCOFBG(int FFHMMNBBJIL, float AHOCKGAHBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3A02B20", Offset = "0x3A01320", VA = "0x183A02B20")]
	public void IONNJMGFDPB(byte[] BJKKIOODGOA, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3A06D50", Offset = "0x3A05550", VA = "0x183A06D50")]
	private bool OIFEDAJLAHN(byte[] BJKKIOODGOA, T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A05140", Offset = "0x3A03940", VA = "0x183A05140")]
	public bool OADACMKKJNG(ArraySegment<byte> BJKKIOODGOA, out T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2F66390", Offset = "0x2F64B90", VA = "0x182F66390")]
	private static ulong HCOHDDHNEHP(byte[] FMMKCBAOFKA, int JNMGKKFIPGA, int KLPGLGDELCK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2F661B0", Offset = "0x2F649B0", VA = "0x182F661B0")]
	private static int GDENMFBNIBC(int JCHCKAOMCHB, float AHOCKGAHBHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2F66270", Offset = "0x2F64A70", VA = "0x182F66270", Slot = "4")]
	[IteratorStateMachine(typeof(global::LGPELLCOFBG<>.HHFCAMCIICC))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1C5DB80", Offset = "0x1C5C380", VA = "0x181C5DB80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BE6530", Offset = "0x2BE4D30", VA = "0x182BE6530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6580", Offset = "0x2BE4D80", VA = "0x182BE6580")]
	static GCJPILNOKID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2BE67D0", Offset = "0x2BE4FD0", VA = "0x182BE67D0")]
	public GCJPILNOKID(byte[] DPHCNLPCHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6420", Offset = "0x2BE4C20", VA = "0x182BE6420")]
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
	[Cpp2IlInjected.Address(RVA = "0x33439F0", Offset = "0x33421F0", VA = "0x1833439F0")]
	public INHEOMODOBG(ref Guid MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3343340", Offset = "0x3341B40", VA = "0x183343340")]
	public INHEOMODOBG(ref ArraySegment<byte> PAHPEFKFKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3341E90", Offset = "0x3340690", VA = "0x183341E90")]
	private static byte GGICJCFAKDH(byte[] JNPIAJHKCKB, int OBODNIOAPNJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3341D80", Offset = "0x3340580", VA = "0x183341D80")]
	private static byte GGHBMMMDEHH(byte FMMAACMCILJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3341F50", Offset = "0x3340750", VA = "0x183341F50")]
	public void LIOKEBNFFOC(byte[] MGGGNBHMHDA, int JNMGKKFIPGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class MHNPGFGGHCA
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4D7BBE0", Offset = "0x4D7A3E0", VA = "0x184D7BBE0")]
	public static bool IKPMKEBMOPM(byte MCODHPOGBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4D7CA30", Offset = "0x4D7B230", VA = "0x184D7CA30")]
	public static bool NDPMOOEAKBN(byte MCODHPOGBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4D7BA20", Offset = "0x4D7A220", VA = "0x184D7BA20")]
	public static sbyte CIBCICNHDEP(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4D7BBF0", Offset = "0x4D7A3F0", VA = "0x184D7BBF0")]
	public static short JFNBLPCFJNA(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4D7BB00", Offset = "0x4D7A300", VA = "0x184D7BB00")]
	public static int IADEKJMJPCB(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x4D7CD60", Offset = "0x4D7B560", VA = "0x184D7CD60")]
	public static long PDNJOIHCIMK(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x4D7BB70", Offset = "0x4D7A370", VA = "0x184D7BB70")]
	public static byte ICIFIELEFNN(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x4D7BA90", Offset = "0x4D7A290", VA = "0x184D7BA90")]
	public static ushort EOHFCNGBOBB(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4D7BC60", Offset = "0x4D7A460", VA = "0x184D7BC60")]
	public static uint KENAGGIFPAD(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4D7BCE0", Offset = "0x4D7A4E0", VA = "0x184D7BCE0")]
	public static ulong LOHPENPIKBJ(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4D7CAA0", Offset = "0x4D7B2A0", VA = "0x184D7CAA0")]
	public static float NMACLDDIGFF(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4D7B1E0", Offset = "0x4D799E0", VA = "0x184D7B1E0")]
	public static double BNFLDCEMKIP(byte[] JNPIAJHKCKB, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4D7B250", Offset = "0x4D79A50", VA = "0x184D7B250")]
	public static int CBMIBDNIBLD(ref byte[] MGGGNBHMHDA, int JNMGKKFIPGA, ulong MFBIHMKFNKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4D7BDF0", Offset = "0x4D7A5F0", VA = "0x184D7BDF0")]
	public static int NBPJKGDINEF(ref byte[] MGGGNBHMHDA, int JNMGKKFIPGA, long MFBIHMKFNKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4D7CB10", Offset = "0x4D7B310", VA = "0x184D7CB10")]
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
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6723E0", Offset = "0x670BE0", VA = "0x1806723E0")]
		[DebuggerHidden]
		public LDJFHFDNDIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2BED850", Offset = "0x2BEC050", VA = "0x182BED850", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2BED3F0", Offset = "0x2BEBBF0", VA = "0x182BED3F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2BED970", Offset = "0x2BEC170", VA = "0x182BED970")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2BED9C0", Offset = "0x2BEC1C0", VA = "0x182BED9C0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2BED800", Offset = "0x2BEC000", VA = "0x182BED800", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x2BED750", Offset = "0x2BEBF50", VA = "0x182BED750", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2BED750", Offset = "0x2BEBF50", VA = "0x182BED750", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6723E0", Offset = "0x670BE0", VA = "0x1806723E0")]
		[DebuggerHidden]
		public MMALFKNKACO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF7A0", Offset = "0x2BEDFA0", VA = "0x182BEF7A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF340", Offset = "0x2BEDB40", VA = "0x182BEF340", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF8C0", Offset = "0x2BEE0C0", VA = "0x182BEF8C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF910", Offset = "0x2BEE110", VA = "0x182BEF910")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF750", Offset = "0x2BEDF50", VA = "0x182BEF750", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF6A0", Offset = "0x2BEDEA0", VA = "0x182BEF6A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2BEF6A0", Offset = "0x2BEDEA0", VA = "0x182BEF6A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB420", Offset = "0x2BE9C20", VA = "0x182BEB420")]
	public static bool OLFKHJCEENL(this TypeInfo DMBEFJIHONB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB2C0", Offset = "0x2BE9AC0", VA = "0x182BEB2C0")]
	public static bool JFEMJFBKEMD(this TypeInfo DMBEFJIHONB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB1D0", Offset = "0x2BE99D0", VA = "0x182BEB1D0")]
	public static IEnumerable<PropertyInfo> FBMPPGLIDIL(this Type DMBEFJIHONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB140", Offset = "0x2BE9940", VA = "0x182BEB140")]
	[IteratorStateMachine(typeof(LDJFHFDNDIL))]
	private static IEnumerable<PropertyInfo> AEAJNEAFMPF(Type DMBEFJIHONB, HashSet<string> FKNLEHPDNPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB3C0", Offset = "0x2BE9BC0", VA = "0x182BEB3C0")]
	public static IEnumerable<FieldInfo> OJCJCFGMBJM(this Type DMBEFJIHONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB230", Offset = "0x2BE9A30", VA = "0x182BEB230")]
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
	[Cpp2IlInjected.Address(RVA = "0x616F60", Offset = "0x615760", VA = "0x180616F60")]
	public static string NMNJIADMLCO(string MGKAPLGAIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3343BD0", Offset = "0x33423D0", VA = "0x183343BD0")]
	public static string PJCDOAKPCMB(string MGKAPLGAIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3343A00", Offset = "0x3342200", VA = "0x183343A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x3768640", Offset = "0x3766E40", VA = "0x183768640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3768600", Offset = "0x3766E00", VA = "0x183768600")]
		private int GJEPFFENNCK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public DBIADGNNEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE80", Offset = "0x7FD680", VA = "0x1807FEE80")]
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
	[Cpp2IlInjected.Address(RVA = "0x37666B0", Offset = "0x3764EB0", VA = "0x1837666B0")]
	public PDHEEJFMMNJ(int FFHMMNBBJIL = 4, float AHOCKGAHBHM = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3765290", Offset = "0x3763A90", VA = "0x183765290")]
	public bool BGBJIKPDFEG(Type BJKKIOODGOA, TValue MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x37654F0", Offset = "0x3763CF0", VA = "0x1837654F0")]
	public bool BGBJIKPDFEG(Type BJKKIOODGOA, Func<Type, TValue> CNHFBNOAGPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x37663B0", Offset = "0x3764BB0", VA = "0x1837663B0")]
	private bool OIFEDAJLAHN(Type BJKKIOODGOA, Func<Type, TValue> CNHFBNOAGPP, out TValue GNMBNJABILL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x3765900", Offset = "0x3764100", VA = "0x183765900")]
	private bool FDAEIEHOEIN(PNIIEDABKBH[] JBINHHOCDJP, Type KMAIODJOMEF, PNIIEDABKBH EIIMGIJKODH, Func<Type, TValue> CNHFBNOAGPP, out TValue GNMBNJABILL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x3765F60", Offset = "0x3764760", VA = "0x183765F60")]
	public bool OADACMKKJNG(Type BJKKIOODGOA, out TValue MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x3765D70", Offset = "0x3764570", VA = "0x183765D70")]
	public TValue IFPEMELNPAG(Type BJKKIOODGOA, Func<Type, TValue> CNHFBNOAGPP)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2F661B0", Offset = "0x2F649B0", VA = "0x182F661B0")]
	private static int GDENMFBNIBC(int JCHCKAOMCHB, float AHOCKGAHBHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x3765530", Offset = "0x3763D30", VA = "0x183765530")]
	private static void CJBBMDCBHJF(ref PNIIEDABKBH EJDFGOAOAHC, PNIIEDABKBH MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x3765530", Offset = "0x3763D30", VA = "0x183765530")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D7A5A0", Offset = "0x4D78DA0", VA = "0x184D7A5A0")]
	public TypeBuilder HACNIHHAKFF(string JIEIIEKPPIJ, TypeAttributes FKMAJHGMLDL, Type HNINKJAJDDL, Type[] KJENPLANIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x4D7A690", Offset = "0x4D78E90", VA = "0x184D7A690")]
	public MCLELMOPFOG(string JMNHLBEMNKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class MGFIICKOHMN
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x4D7AF70", Offset = "0x4D79770", VA = "0x184D7AF70")]
	private static MethodInfo LLFAGCDNHEB(LambdaExpression HHCDJNIHAIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3ACA530", Offset = "0x3AC8D30", VA = "0x183ACA530")]
	public static MethodInfo ELMHBKIAPBJ<T>(Expression<Func<T>> HHCDJNIHAIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3ACA530", Offset = "0x3AC8D30", VA = "0x183ACA530")]
	public static MethodInfo ELMHBKIAPBJ<T, TR>(Expression<Func<T, TR>> HHCDJNIHAIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3ACA530", Offset = "0x3AC8D30", VA = "0x183ACA530")]
	public static MethodInfo ELMHBKIAPBJ<T>(Expression<Action<T>> HHCDJNIHAIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3ACA530", Offset = "0x3AC8D30", VA = "0x183ACA530")]
	public static MethodInfo ELMHBKIAPBJ<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> HHCDJNIHAIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3ACA5A0", Offset = "0x3AC8DA0", VA = "0x183ACA5A0")]
	private static MemberInfo PLHBAILMLAL<T>(Expression<T> PEJIHPGBPAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3ACA540", Offset = "0x3AC8D40", VA = "0x183ACA540")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D7D510", Offset = "0x4D7BD10", VA = "0x184D7D510")]
	public MKFOPICEBFL(ILGenerator MMABJADPAFA, int APEAIJJLBLJ, bool IGFEDCCDFNN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x4D7D550", Offset = "0x4D7BD50", VA = "0x184D7D550")]
	public MKFOPICEBFL(ILGenerator MMABJADPAFA, int APEAIJJLBLJ, Type DMBEFJIHONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x4D7D400", Offset = "0x4D7BC00", VA = "0x184D7D400")]
	public void JEKDNJNIIDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class PKOLGJKBBLG
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x4D89330", Offset = "0x4D87B30", VA = "0x184D89330")]
	public static void LAHJOJFAHMP(this ILGenerator MMABJADPAFA, int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x4D89560", Offset = "0x4D87D60", VA = "0x184D89560")]
	public static void LAHJOJFAHMP(this ILGenerator MMABJADPAFA, LocalBuilder FBJBEOKFNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4D89040", Offset = "0x4D87840", VA = "0x184D89040")]
	public static void INIAIPOIKIB(this ILGenerator MMABJADPAFA, int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4D89270", Offset = "0x4D87A70", VA = "0x184D89270")]
	public static void INIAIPOIKIB(this ILGenerator MMABJADPAFA, LocalBuilder FBJBEOKFNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x4D88CC0", Offset = "0x4D874C0", VA = "0x184D88CC0")]
	public static void HNKFCOKBKFI(this ILGenerator MMABJADPAFA, int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x4D88DB0", Offset = "0x4D875B0", VA = "0x184D88DB0")]
	public static void HNKFCOKBKFI(this ILGenerator MMABJADPAFA, LocalBuilder FBJBEOKFNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x4D889F0", Offset = "0x4D871F0", VA = "0x184D889F0")]
	public static void DMHALCIJHLN(this ILGenerator MMABJADPAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x4D899F0", Offset = "0x4D881F0", VA = "0x184D899F0")]
	public static void POJMIBLHONN(this ILGenerator MMABJADPAFA, bool MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x4D895A0", Offset = "0x4D87DA0", VA = "0x184D895A0")]
	public static void LOEGCJIJFIK(this ILGenerator MMABJADPAFA, int MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4D88F50", Offset = "0x4D87750", VA = "0x184D88F50")]
	public static void INEMGNKFICL(this ILGenerator MMABJADPAFA, Type DMBEFJIHONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x4D88760", Offset = "0x4D86F60", VA = "0x184D88760")]
	public static void CEIBHBPIBGG(this ILGenerator MMABJADPAFA, Type DMBEFJIHONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x4D88A00", Offset = "0x4D87200", VA = "0x184D88A00")]
	public static void EPGNIKGGMAE(this ILGenerator MMABJADPAFA, int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4D892B0", Offset = "0x4D87AB0", VA = "0x184D892B0")]
	public static void KAFBAHFPNEC(this ILGenerator MMABJADPAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4D88900", Offset = "0x4D87100", VA = "0x184D88900")]
	public static void DLPCDNOHOFM(this ILGenerator MMABJADPAFA, int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x4D88800", Offset = "0x4D87000", VA = "0x184D88800")]
	public static void CJJBJLCEAML(this ILGenerator MMABJADPAFA, MethodInfo HHBEHEFOBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x4D88C30", Offset = "0x4D87430", VA = "0x184D88C30")]
	public static void HIJKKJLEOCN(this ILGenerator MMABJADPAFA, FieldInfo PJCOBFPAJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x4D88EC0", Offset = "0x4D876C0", VA = "0x184D88EC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public GNAOOMLLEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7950", Offset = "0x2BE6150", VA = "0x182BE7950")]
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
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x561490", Offset = "0x55FC90", VA = "0x180561490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string KHIDDALIEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5614A0", Offset = "0x55FCA0", VA = "0x1805614A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OEIHGHDIMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7BC0", Offset = "0x2BE63C0", VA = "0x182BE7BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DFKEEJBKEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x561190", Offset = "0x55F990", VA = "0x180561190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5AA0", Offset = "0x6C42A0", VA = "0x1806C5AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool NNDCECIGJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5611A0", Offset = "0x55F9A0", VA = "0x1805611A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x67C090", Offset = "0x67A890", VA = "0x18067C090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type JHCEJAKEANN
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x58A0C0", Offset = "0x5888C0", VA = "0x18058A0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x674F20", Offset = "0x673720", VA = "0x180674F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo CICLAFAELAB
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x589A30", Offset = "0x588230", VA = "0x180589A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6828D0", Offset = "0x6810D0", VA = "0x1806828D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo PHHABFLGOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x562010", Offset = "0x560810", VA = "0x180562010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x562020", Offset = "0x560820", VA = "0x180562020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo OBLIGKNKHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x574D70", Offset = "0x573570", VA = "0x180574D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5FBFC0", Offset = "0x5FA7C0", VA = "0x1805FBFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7EC0", Offset = "0x2BE66C0", VA = "0x182BE7EC0")]
	protected GNFHJFKEAIP(Type DMBEFJIHONB, string JIEIIEKPPIJ, string FAFCFNPKFII, bool BADJMNOODFA, bool CEJCDCMLMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7DB0", Offset = "0x2BE65B0", VA = "0x182BE7DB0")]
	public GNFHJFKEAIP(FieldInfo KEKKEELMMKA, string JIEIIEKPPIJ, bool LCNEOEILONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7F40", Offset = "0x2BE6740", VA = "0x182BE7F40")]
	public GNFHJFKEAIP(PropertyInfo KEKKEELMMKA, string JIEIIEKPPIJ, bool LCNEOEILONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7BD0", Offset = "0x2BE63D0", VA = "0x182BE7BD0")]
	private static MethodInfo LGJCBMMFMCD(MemberInfo KEKKEELMMKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x21E0B90", Offset = "0x21DF390", VA = "0x1821E0B90")]
	public T GDALEMAIMGC<T>(bool HEEECKKHAPF) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7B00", Offset = "0x2BE6300", VA = "0x182BE7B00", Slot = "4")]
	public virtual void BHIFBMGELHB(ILGenerator MMABJADPAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7CF0", Offset = "0x2BE64F0", VA = "0x182BE7CF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D805A0", Offset = "0x4D7EDA0", VA = "0x184D805A0")]
	public NJBAJMIJEEH(string JIEIIEKPPIJ, string IHGGFOPHIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x4D80490", Offset = "0x4D7EC90", VA = "0x184D80490", Slot = "4")]
	public override void BHIFBMGELHB(ILGenerator MMABJADPAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x4D80550", Offset = "0x4D7ED50", VA = "0x184D80550", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D7FC50", Offset = "0x4D7E450", VA = "0x184D7FC50")]
	public MOJGNLCGBBP(string JIEIIEKPPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x4D7F4C0", Offset = "0x4D7DCC0", VA = "0x184D7F4C0", Slot = "4")]
	public override void BHIFBMGELHB(ILGenerator MMABJADPAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x4D7F760", Offset = "0x4D7DF60", VA = "0x184D7F760", Slot = "5")]
	public override void MJAFGMMOJHP(ILGenerator MMABJADPAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x4D7F580", Offset = "0x4D7DD80", VA = "0x184D7F580")]
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
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x561490", Offset = "0x55FC90", VA = "0x180561490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DEFAEABBJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x688F70", Offset = "0x687770", VA = "0x180688F70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x700010", Offset = "0x6FE810", VA = "0x180700010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HEMGEDDJGHB
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x67D6B0", Offset = "0x67BEB0", VA = "0x18067D6B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xC67950", Offset = "0xC66150", VA = "0x180C67950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo NJBFKAAIMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x563DF0", Offset = "0x5625F0", VA = "0x180563DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x58BD70", Offset = "0x58A570", VA = "0x18058BD70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public GNFHJFKEAIP[] GAAIJJJKBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x58A0C0", Offset = "0x5888C0", VA = "0x18058A0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x674F20", Offset = "0x673720", VA = "0x180674F20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public GNFHJFKEAIP[] NNJOMJBANBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x589A30", Offset = "0x588230", VA = "0x180589A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6828D0", Offset = "0x6810D0", VA = "0x1806828D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAD10", Offset = "0x2BD9510", VA = "0x182BDAD10")]
	public APDPMECNMFK(Type DMBEFJIHONB, Func<string, string> GCLFOBOLIJH, bool LCNEOEILONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAC40", Offset = "0x2BD9440", VA = "0x182BDAC40")]
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
	[Cpp2IlInjected.Address(RVA = "0x23C9310", Offset = "0x23C7B10", VA = "0x1823C9310")]
	public ALDICKDJDBM(ulong LFNEHLNJNLJ, int PNFFMMGPAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9CA0", Offset = "0x2BD84A0", VA = "0x182BD9CA0")]
	public void CBBCGLOPLHO(ref ALDICKDJDBM GKBKHIIEFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9E90", Offset = "0x2BD8690", VA = "0x182BD9E90")]
	public static ALDICKDJDBM FBFBDBNIOJC(ref ALDICKDJDBM OOKPIHBNHGF, ref ALDICKDJDBM FMMAACMCILJ)
	{
		return default(ALDICKDJDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9CB0", Offset = "0x2BD84B0", VA = "0x182BD9CB0")]
	public void CMDLGFEIAMN(ref ALDICKDJDBM GKBKHIIEFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9D40", Offset = "0x2BD8540", VA = "0x182BD9D40")]
	public static ALDICKDJDBM COAILKNLIFI(ref ALDICKDJDBM OOKPIHBNHGF, ref ALDICKDJDBM FMMAACMCILJ)
	{
		return default(ALDICKDJDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9E50", Offset = "0x2BD8650", VA = "0x182BD9E50")]
	public void FAKKJGDKOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9DF0", Offset = "0x2BD85F0", VA = "0x182BD9DF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D0D90", Offset = "0x7CF590", VA = "0x1807D0D90")]
	public FFJDMMPCMFJ(byte[] MGGGNBHMHDA, int HKHJMHKLNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2BE47F0", Offset = "0x2BE2FF0", VA = "0x182BE47F0")]
	public void LFJIFAOAHMB(byte ADPHNNDAMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x2BE4850", Offset = "0x2BE3050", VA = "0x182BE4850")]
	public void LNPEPBGGLOJ(byte[] ADPHNNDAMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2BE4650", Offset = "0x2BE2E50", VA = "0x182BE4650")]
	public void DHGIOPIJGKJ(byte[] ADPHNNDAMFI, int GFKNIIIDANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x2BE45A0", Offset = "0x2BE2DA0", VA = "0x182BE45A0")]
	public void DHGIOPIJGKJ(byte[] ADPHNNDAMFI, int ICAAAAPMEKA, int GFKNIIIDANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2BE4520", Offset = "0x2BE2D20", VA = "0x182BE4520")]
	public void AACGHIEGMGH(byte MCODHPOGBPN, int KLPGLGDELCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2BE46F0", Offset = "0x2BE2EF0", VA = "0x182BE46F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D7EC90", Offset = "0x4D7D490", VA = "0x184D7EC90")]
	private static byte[] NMKFGHNJCLA(int DDMFGCPNLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x4D7E890", Offset = "0x4D7D090", VA = "0x184D7E890")]
	private static byte[] FLIFPEOAGLJ(int DDMFGCPNLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x4D7E970", Offset = "0x4D7D170", VA = "0x184D7E970")]
	public static int HIEABJODAFJ(ref byte[] MGGGNBHMHDA, int JNMGKKFIPGA, float MFBIHMKFNKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x4D7EA80", Offset = "0x4D7D280", VA = "0x184D7EA80")]
	public static int HIEABJODAFJ(ref byte[] MGGGNBHMHDA, int JNMGKKFIPGA, double MFBIHMKFNKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x4D7EB90", Offset = "0x4D7D390", VA = "0x184D7EB90")]
	private static bool KGPLOGNDGOP(byte[] MGGGNBHMHDA, int GFKNIIIDANB, ulong EEHBGLLJBFI, ulong GFBKHKKLIKK, ulong GCLIOHFGHHG, ulong JMLDNOKAKGG, ulong AHMOECDPKBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x4D7E440", Offset = "0x4D7CC40", VA = "0x184D7E440")]
	private static void FDFLFEFGFBC(uint FNKNFIMMCAG, int AKOMDALJHJC, out uint PAHGFBBCGBF, out int PNIFBLEKKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x4D7DC10", Offset = "0x4D7C410", VA = "0x184D7DC10")]
	private static bool AILBEBOPPGL(ALDICKDJDBM AALAIENBODB, ALDICKDJDBM ENPBHFNIBIC, ALDICKDJDBM MHGEPCEOLBJ, byte[] MGGGNBHMHDA, out int GFKNIIIDANB, out int PBIAKKNHAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x4D7ED60", Offset = "0x4D7D560", VA = "0x184D7ED60")]
	private static bool OEAPODCDDAP(double ANCLCJIJMKE, DKFCKNFLNFK MLBEKKOCNDC, byte[] MGGGNBHMHDA, out int GFKNIIIDANB, out int PKKJCKBBHKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x4D7E350", Offset = "0x4D7CB50", VA = "0x184D7E350")]
	private static bool EELDCKGMPHI(double ANCLCJIJMKE, DKFCKNFLNFK MLBEKKOCNDC, byte[] MGGGNBHMHDA, out int GFKNIIIDANB, out int OAMJIBLJBOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x4D7E700", Offset = "0x4D7CF00", VA = "0x184D7E700")]
	private static bool FHKEBKNIHPC(double MFBIHMKFNKA, ref FFJDMMPCMFJ LJIFHOHNPJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x4D7D5E0", Offset = "0x4D7BDE0", VA = "0x184D7D5E0")]
	private static bool AABIIDGNHFE(double MFBIHMKFNKA, ref FFJDMMPCMFJ LJIFHOHNPJL, PPGNMMAPKBN MLBEKKOCNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x4D7F100", Offset = "0x4D7D900", VA = "0x184D7F100")]
	private static void PLNMNIHEJOC(byte[] DNEEJMEIOLN, int GFKNIIIDANB, int OAMJIBLJBOA, int IHCFPILDNCC, ref FFJDMMPCMFJ LJIFHOHNPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x4D7E060", Offset = "0x4D7C860", VA = "0x184D7E060")]
	private static void DMBDJAMKNFJ(byte[] DNEEJMEIOLN, int GFKNIIIDANB, int PNFFMMGPAGO, ref FFJDMMPCMFJ LJIFHOHNPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x4D7E560", Offset = "0x4D7CD60", VA = "0x184D7E560")]
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
	[Cpp2IlInjected.Address(RVA = "0x3341BD0", Offset = "0x33403D0", VA = "0x183341BD0")]
	public ILHOFENIMEN(double HFCLJHDBBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3341B30", Offset = "0x3340330", VA = "0x183341B30")]
	public ILHOFENIMEN(ALDICKDJDBM HFCLJHDBBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x3341640", Offset = "0x333FE40", VA = "0x183341640")]
	public ALDICKDJDBM GKHPIOCCJLK()
	{
		return default(ALDICKDJDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x33416C0", Offset = "0x333FEC0", VA = "0x1833416C0")]
	public ALDICKDJDBM HAKFJPJCPDK()
	{
		return default(ALDICKDJDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x73EEF0", Offset = "0x73D6F0", VA = "0x18073EEF0")]
	public ulong FBIBCKCMNGM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x3341A30", Offset = "0x3340230", VA = "0x183341A30")]
	public double OJJOAFFLNPE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x33415C0", Offset = "0x333FDC0", VA = "0x1833415C0")]
	public double FNOCMLCFDON()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x3341570", Offset = "0x333FD70", VA = "0x183341570")]
	public int ENHKCKJFBFP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x3341AA0", Offset = "0x33402A0", VA = "0x183341AA0")]
	public ulong OKKKGNLFKBE()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x33415A0", Offset = "0x333FDA0", VA = "0x1833415A0")]
	public bool FKAOFPDFAGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x33417D0", Offset = "0x333FFD0", VA = "0x1833417D0")]
	public bool KIMOOBJOBAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x3341AD0", Offset = "0x33402D0", VA = "0x183341AD0")]
	public bool PDBKAAGEEGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x3341B00", Offset = "0x3340300", VA = "0x183341B00")]
	public bool PGKJDJDAAJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x3341760", Offset = "0x333FF60", VA = "0x183341760")]
	public int HCFMLKDDMND()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x3341800", Offset = "0x3340000", VA = "0x183341800")]
	public void MFPIIAJNHBA(out ALDICKDJDBM DGPGMLJMAGI, out ALDICKDJDBM NEMMJHIMHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x3341780", Offset = "0x333FF80", VA = "0x183341780")]
	public bool IBGGAAIMMDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x33417F0", Offset = "0x333FFF0", VA = "0x1833417F0")]
	public double MFBIHMKFNKA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x3341550", Offset = "0x333FD50", VA = "0x183341550")]
	public static int EADENDOEOGI(int ABIEHPBGBOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x3341540", Offset = "0x333FD40", VA = "0x183341540")]
	public static double APJLBGDJAHN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x3341990", Offset = "0x3340190", VA = "0x183341990")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CFC0D0", Offset = "0x1CFA8D0", VA = "0x181CFC0D0")]
	public JJNILJLLADG(float JEOJALDAEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x33457F0", Offset = "0x3343FF0", VA = "0x1833457F0")]
	public ALDICKDJDBM GKHPIOCCJLK()
	{
		return default(ALDICKDJDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7961F0", Offset = "0x7949F0", VA = "0x1807961F0")]
	public uint HKLFMPDEHCH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x33457C0", Offset = "0x3343FC0", VA = "0x1833457C0")]
	public int ENHKCKJFBFP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3345A10", Offset = "0x3344210", VA = "0x183345A10")]
	public uint OKKKGNLFKBE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x33457E0", Offset = "0x3343FE0", VA = "0x1833457E0")]
	public bool FKAOFPDFAGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x33458A0", Offset = "0x33440A0", VA = "0x1833458A0")]
	public void MFPIIAJNHBA(out ALDICKDJDBM DGPGMLJMAGI, out ALDICKDJDBM NEMMJHIMHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x3345860", Offset = "0x3344060", VA = "0x183345860")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE5FD0", Offset = "0x2BE47D0", VA = "0x182BE5FD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D80750", Offset = "0x4D7EF50", VA = "0x184D80750")]
	public static void ONIDPBJHEEN(int KBIKFKLJNOM, int DOIDMPDPNAE, out ALDICKDJDBM PAHGFBBCGBF, out int PKKJCKBBHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4D80650", Offset = "0x4D7EE50", VA = "0x184D80650")]
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
		[Cpp2IlInjected.Address(RVA = "0x3345BD0", Offset = "0x33443D0", VA = "0x183345BD0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x8A65C0", Offset = "0x8A4DC0", VA = "0x1808A65C0")]
	public JOANBIBMOJE(byte[] JNPIAJHKCKB, int ICAAAAPMEKA, int GFKNIIIDANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7961B0", Offset = "0x7949B0", VA = "0x1807961B0")]
	public int GFKNIIIDANB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x3345B70", Offset = "0x3344370", VA = "0x183345B70")]
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
	[Cpp2IlInjected.Address(RVA = "0x33469D0", Offset = "0x33451D0", VA = "0x1833469D0")]
	private static byte[] IEOCLNCPMDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x33471D0", Offset = "0x33459D0", VA = "0x1833471D0")]
	private static JOANBIBMOJE KNDFEOBCJNC(JOANBIBMOJE MGGGNBHMHDA)
	{
		return default(JOANBIBMOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x3346020", Offset = "0x3344820", VA = "0x183346020")]
	private static JOANBIBMOJE AJLIDJNEOMK(JOANBIBMOJE MGGGNBHMHDA)
	{
		return default(JOANBIBMOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x33472B0", Offset = "0x3345AB0", VA = "0x1833472B0")]
	private static void OIOKDMOOCKH(JOANBIBMOJE MGGGNBHMHDA, int PNFFMMGPAGO, byte[] GGKDGANPGLB, out int AFKAEGCKGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3346100", Offset = "0x3344900", VA = "0x183346100")]
	private static void BKJNALJGGPA(JOANBIBMOJE MGGGNBHMHDA, int PNFFMMGPAGO, byte[] NNCCKAACBGL, int EOJFEONKNJD, out JOANBIBMOJE DIJBIMDCBKD, out int HMPIEFOAHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x3346420", Offset = "0x3344C20", VA = "0x183346420")]
	private static ulong CKCLPBLCLAO(JOANBIBMOJE MGGGNBHMHDA, out int LLAMEKOBLMN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x3346AB0", Offset = "0x33452B0", VA = "0x183346AB0")]
	private static void IHJGCBGEFCI(JOANBIBMOJE MGGGNBHMHDA, out ALDICKDJDBM AFGNBGMNGPF, out int DKADIJCEAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x3346C50", Offset = "0x3345450", VA = "0x183346C50")]
	private static bool IONEDCHOAEJ(JOANBIBMOJE DIJBIMDCBKD, int PNFFMMGPAGO, out double AFGNBGMNGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x33465E0", Offset = "0x3344DE0", VA = "0x1833465E0")]
	private static ALDICKDJDBM FHOJFABCKIM(int PNFFMMGPAGO)
	{
		return default(ALDICKDJDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x3347360", Offset = "0x3345B60", VA = "0x183347360")]
	private static bool PBILDBNDGGC(JOANBIBMOJE MGGGNBHMHDA, int PNFFMMGPAGO, out double AFGNBGMNGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x33464B0", Offset = "0x3344CB0", VA = "0x1833464B0")]
	private static bool DGOEAKCLJLH(JOANBIBMOJE DIJBIMDCBKD, int PNFFMMGPAGO, out double DNANLCMCBKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x33470A0", Offset = "0x33458A0", VA = "0x1833470A0")]
	public static double? JLKILAEPGHO(JOANBIBMOJE MGGGNBHMHDA, int PNFFMMGPAGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3346740", Offset = "0x3344F40", VA = "0x183346740")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDA2A0", Offset = "0x2BD8AA0", VA = "0x182BDA2A0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D0D90", Offset = "0x7CF590", VA = "0x1807D0D90")]
	public AMODCHBNEGL(byte[] MGGGNBHMHDA, int JNMGKKFIPGA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA1D0", Offset = "0x2BD89D0", VA = "0x182BDA1D0")]
	public static AMODCHBNEGL ILBHEDEODLL(AMODCHBNEGL EBOHMGAPLIG)
	{
		return default(AMODCHBNEGL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA110", Offset = "0x2BD8910", VA = "0x182BDA110")]
	public static AMODCHBNEGL GCJLOHFJPJA(AMODCHBNEGL EBOHMGAPLIG, int GFKNIIIDANB)
	{
		return default(AMODCHBNEGL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA1E0", Offset = "0x2BD89E0", VA = "0x182BDA1E0")]
	public static int KAHEKGMBKFK(AMODCHBNEGL LLKALDKKJFP, AMODCHBNEGL EIFOFLJGEEA)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA280", Offset = "0x2BD8A80", VA = "0x182BDA280")]
	public static bool KMILPCLAINA(AMODCHBNEGL LLKALDKKJFP, AMODCHBNEGL EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA1B0", Offset = "0x2BD89B0", VA = "0x182BDA1B0")]
	public static bool GNFOGENJEMF(AMODCHBNEGL LLKALDKKJFP, AMODCHBNEGL EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA240", Offset = "0x2BD8A40", VA = "0x182BDA240")]
	public static bool KMILPCLAINA(AMODCHBNEGL LLKALDKKJFP, char EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA170", Offset = "0x2BD8970", VA = "0x182BDA170")]
	public static bool GNFOGENJEMF(AMODCHBNEGL LLKALDKKJFP, char EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA170", Offset = "0x2BD8970", VA = "0x182BDA170")]
	public static bool GNFOGENJEMF(AMODCHBNEGL LLKALDKKJFP, byte EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA0D0", Offset = "0x2BD88D0", VA = "0x182BDA0D0")]
	public static bool EMBNFNEJBOF(AMODCHBNEGL LLKALDKKJFP, char EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA200", Offset = "0x2BD8A00", VA = "0x182BDA200")]
	public static bool KHIINDFHHEL(AMODCHBNEGL LLKALDKKJFP, char EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA090", Offset = "0x2BD8890", VA = "0x182BDA090")]
	public static bool AEOGFCIGBEM(AMODCHBNEGL LLKALDKKJFP, char EIFOFLJGEEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA2E0", Offset = "0x2BD8AE0", VA = "0x182BDA2E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE22D0", Offset = "0x2BE0AD0", VA = "0x182BE22D0")]
	private static byte[] BINHNLGNBCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2BE25F0", Offset = "0x2BE0DF0", VA = "0x182BE25F0")]
	private static byte[] EANOIDBLPGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2BE2410", Offset = "0x2BE0C10", VA = "0x182BE2410")]
	public static double DOKEIANEMIN(byte[] MGGGNBHMHDA, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2BE2850", Offset = "0x2BE1050", VA = "0x182BE2850")]
	public static float FHKCFGDPPEM(byte[] MGGGNBHMHDA, int JNMGKKFIPGA, out int HEIMKPJJNGD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2BE26D0", Offset = "0x2BE0ED0", VA = "0x182BE26D0")]
	private static bool EFLBKABHABD(int FMMKCBAOFKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2BE3990", Offset = "0x2BE2190", VA = "0x182BE3990")]
	private static bool JFGEOOIDGEN(ref AMODCHBNEGL KGJFPLGBLBE, AMODCHBNEGL HGCGODPLIAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2BE24D0", Offset = "0x2BE0CD0", VA = "0x182BE24D0")]
	private static bool DPFCDHJHKJD(ref AMODCHBNEGL KGJFPLGBLBE, AMODCHBNEGL HGCGODPLIAK, byte[] DCFFNHJICLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x2BE23B0", Offset = "0x2BE0BB0", VA = "0x182BE23B0")]
	private static bool CFIIBKNLNGG(ref AMODCHBNEGL EGDPKKKNIGB, byte[] ADPHNNDAMFI, int JNMGKKFIPGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xCC5AC0", Offset = "0xCC42C0", VA = "0x180CC5AC0")]
	private static double PNJENNCJMNA(bool HDFNIODPOFK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x2BE2910", Offset = "0x2BE1110", VA = "0x182BE2910")]
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
	[Cpp2IlInjected.Address(RVA = "0x2188F60", Offset = "0x2187760", VA = "0x182188F60")]
	public MCLIIBKBANJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1BA8590", Offset = "0x1BA6D90", VA = "0x181BA8590")]
	public MCLIIBKBANJ(EKPDCFPCPKH JCNNPACPOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3922EF0", Offset = "0x39216F0", VA = "0x183922EF0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, T[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3920F20", Offset = "0x391F720", VA = "0x183920F20", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2188F60", Offset = "0x2187760", VA = "0x182188F60")]
	public EPJFKCMMKGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1BA8590", Offset = "0x1BA6D90", VA = "0x181BA8590")]
	public EPJFKCMMKGC(EKPDCFPCPKH JCNNPACPOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x253BCE0", Offset = "0x253A4E0", VA = "0x18253BCE0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, List<T> MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x253BB10", Offset = "0x253A310", VA = "0x18253BB10", Slot = "5")]
	public List<T> GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class KILCKHOMKHH<TElement, TIntermediate, TEnumerator, TCollection> : global::GNGMIEPFFIJ<TCollection>, OHDNNHIHLFA where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3C37DF0", Offset = "0x3C365F0", VA = "0x183C37DF0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, TCollection MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3C37BE0", Offset = "0x3C363E0", VA = "0x183C37BE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
	protected KILCKHOMKHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class BMKPDJAGLBH<TElement, TIntermediate, TCollection> : global::KILCKHOMKHH<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x36185A0", Offset = "0x3616DA0", VA = "0x1836185A0", Slot = "6")]
	protected override IEnumerator<TElement> LKNEEKOCJED(TCollection PEJIHPGBPAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC120", Offset = "0x1DDA920", VA = "0x181DDC120")]
	protected BMKPDJAGLBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class CNEBJHMHHHC<TElement, TCollection> : global::BMKPDJAGLBH<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x11814F0", Offset = "0x117FCF0", VA = "0x1811814F0", Slot = "9")]
	protected sealed override TCollection GLIJLNLELKF(ref TCollection CMLBIOKDKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class IKNEIHHPIPL<TElement, TCollection> : global::CNEBJHMHHHC<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x1D9D9B0", Offset = "0x1D9C1B0", VA = "0x181D9D9B0", Slot = "7")]
	protected override TCollection JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x1D9D940", Offset = "0x1D9C140", VA = "0x181D9D940", Slot = "8")]
	protected override void IONNJMGFDPB(ref TCollection DPCBADAICKN, int CFANIPEBCPB, TElement MFBIHMKFNKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class PEEJIFBIPDO<T> : global::KILCKHOMKHH<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x295C420", Offset = "0x295AC20", VA = "0x18295C420", Slot = "8")]
	protected override void IONNJMGFDPB(ref LinkedList<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x11814F0", Offset = "0x117FCF0", VA = "0x1811814F0", Slot = "9")]
	protected override LinkedList<T> GLIJLNLELKF(ref LinkedList<T> CMLBIOKDKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x26DD620", Offset = "0x26DBE20", VA = "0x1826DD620", Slot = "7")]
	protected override LinkedList<T> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x37678F0", Offset = "0x37660F0", VA = "0x1837678F0", Slot = "6")]
	protected override LinkedList<T>.Enumerator LKNEEKOCJED(LinkedList<T> PEJIHPGBPAG)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class PCGBNDMEDIM<T> : global::KILCKHOMKHH<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x295C420", Offset = "0x295AC20", VA = "0x18295C420", Slot = "8")]
	protected override void IONNJMGFDPB(ref Queue<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x26DD620", Offset = "0x26DBE20", VA = "0x1826DD620", Slot = "7")]
	protected override Queue<T> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x25F2390", Offset = "0x25F0B90", VA = "0x1825F2390", Slot = "6")]
	protected override Queue<T>.Enumerator LKNEEKOCJED(Queue<T> PEJIHPGBPAG)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x11814F0", Offset = "0x117FCF0", VA = "0x1811814F0", Slot = "9")]
	protected override Queue<T> GLIJLNLELKF(ref Queue<T> CMLBIOKDKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class FGNNEIOKHDA<T> : global::KILCKHOMKHH<T, global::KEOFDOOIBKE<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x25F2310", Offset = "0x25F0B10", VA = "0x1825F2310", Slot = "8")]
	protected override void IONNJMGFDPB(ref global::KEOFDOOIBKE<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x25F2340", Offset = "0x25F0B40", VA = "0x1825F2340", Slot = "7")]
	protected override global::KEOFDOOIBKE<T> JHOEBDGEJAE()
	{
		return default(global::KEOFDOOIBKE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x25F2390", Offset = "0x25F0B90", VA = "0x1825F2390", Slot = "6")]
	protected override Stack<T>.Enumerator LKNEEKOCJED(Stack<T> PEJIHPGBPAG)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x25F2230", Offset = "0x25F0A30", VA = "0x1825F2230", Slot = "9")]
	protected override Stack<T> GLIJLNLELKF(ref global::KEOFDOOIBKE<T> CMLBIOKDKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class HCDFBHFBCNB<T> : global::KILCKHOMKHH<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x295C420", Offset = "0x295AC20", VA = "0x18295C420", Slot = "8")]
	protected override void IONNJMGFDPB(ref HashSet<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x11814F0", Offset = "0x117FCF0", VA = "0x1811814F0", Slot = "9")]
	protected override HashSet<T> GLIJLNLELKF(ref HashSet<T> CMLBIOKDKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x26DD620", Offset = "0x26DBE20", VA = "0x1826DD620", Slot = "7")]
	protected override HashSet<T> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x25F2390", Offset = "0x25F0B90", VA = "0x1825F2390", Slot = "6")]
	protected override HashSet<T>.Enumerator LKNEEKOCJED(HashSet<T> PEJIHPGBPAG)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class OJMBKJJBKGO<T> : global::BMKPDJAGLBH<T, global::KEOFDOOIBKE<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x25F2310", Offset = "0x25F0B10", VA = "0x1825F2310", Slot = "8")]
	protected override void IONNJMGFDPB(ref global::KEOFDOOIBKE<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x36B1290", Offset = "0x36AFA90", VA = "0x1836B1290", Slot = "9")]
	protected override ReadOnlyCollection<T> GLIJLNLELKF(ref global::KEOFDOOIBKE<T> CMLBIOKDKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x36B1320", Offset = "0x36AFB20", VA = "0x1836B1320", Slot = "7")]
	protected override global::KEOFDOOIBKE<T> JHOEBDGEJAE()
	{
		return default(global::KEOFDOOIBKE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class KAKPPGNNKPN<T> : global::BMKPDJAGLBH<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x295C420", Offset = "0x295AC20", VA = "0x18295C420", Slot = "8")]
	protected override void IONNJMGFDPB(ref List<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x26DD620", Offset = "0x26DBE20", VA = "0x1826DD620", Slot = "7")]
	protected override List<T> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x11814F0", Offset = "0x117FCF0", VA = "0x1811814F0", Slot = "9")]
	protected override IList<T> GLIJLNLELKF(ref List<T> CMLBIOKDKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class OKJIBCEOAPN<T> : global::BMKPDJAGLBH<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x295C420", Offset = "0x295AC20", VA = "0x18295C420", Slot = "8")]
	protected override void IONNJMGFDPB(ref List<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x26DD620", Offset = "0x26DBE20", VA = "0x1826DD620", Slot = "7")]
	protected override List<T> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x11814F0", Offset = "0x117FCF0", VA = "0x1811814F0", Slot = "9")]
	protected override ICollection<T> GLIJLNLELKF(ref List<T> CMLBIOKDKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class MAAKABDJFAL<T> : global::BMKPDJAGLBH<T, global::KEOFDOOIBKE<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x25F2310", Offset = "0x25F0B10", VA = "0x1825F2310", Slot = "8")]
	protected override void IONNJMGFDPB(ref global::KEOFDOOIBKE<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x25F2340", Offset = "0x25F0B40", VA = "0x1825F2340", Slot = "7")]
	protected override global::KEOFDOOIBKE<T> JHOEBDGEJAE()
	{
		return default(global::KEOFDOOIBKE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x391F570", Offset = "0x391DD70", VA = "0x18391F570", Slot = "9")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D7A980", Offset = "0x4D79180", VA = "0x184D7A980", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, IEnumerable MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x4D7A790", Offset = "0x4D78F90", VA = "0x184D7A790", Slot = "5")]
	public IEnumerable GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D87A20", Offset = "0x4D86220", VA = "0x184D87A20", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ICollection MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4D87830", Offset = "0x4D86030", VA = "0x184D87830", Slot = "5")]
	public ICollection GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3341240", Offset = "0x333FA40", VA = "0x183341240", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, IList MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x33410C0", Offset = "0x333F8C0", VA = "0x1833410C0", Slot = "5")]
	public IList GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	public IKKCKPKDMHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class GHBHOPBCPOB<T> : global::BMKPDJAGLBH<T, global::KEOFDOOIBKE<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x26D14F0", Offset = "0x26CFCF0", VA = "0x1826D14F0", Slot = "8")]
	protected override void IONNJMGFDPB(ref global::KEOFDOOIBKE<T> DPCBADAICKN, int CFANIPEBCPB, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x25F2340", Offset = "0x25F0B40", VA = "0x1825F2340", Slot = "7")]
	protected override global::KEOFDOOIBKE<T> JHOEBDGEJAE()
	{
		return default(global::KEOFDOOIBKE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x26D14B0", Offset = "0x26CFCB0", VA = "0x1826D14B0", Slot = "9")]
	protected override IReadOnlyList<T> GLIJLNLELKF(ref global::KEOFDOOIBKE<T> CMLBIOKDKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1BACDC0", Offset = "0x1BAB5C0", VA = "0x181BACDC0")]
	public GHBHOPBCPOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class AHPAIIPFOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9C00", Offset = "0x2BD8400", VA = "0x182BD9C00")]
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
	[Cpp2IlInjected.Address(RVA = "0x3353D60", Offset = "0x3352560", VA = "0x183353D60", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, DateTime MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x3352E60", Offset = "0x3351660", VA = "0x183352E60", Slot = "5")]
	public DateTime GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE16B0", Offset = "0x2BDFEB0", VA = "0x182BE16B0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, DateTimeOffset MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0710", Offset = "0x2BDEF10", VA = "0x182BE0710", Slot = "5")]
	public DateTimeOffset GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE8A50", Offset = "0x2BE7250", VA = "0x182BE8A50", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, TimeSpan MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2BE80F0", Offset = "0x2BE68F0", VA = "0x182BE80F0", Slot = "5")]
	public TimeSpan GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	public HAOLMNPKFME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class DOOLDJNJBDG<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::GNGMIEPFFIJ<TDictionary>, OHDNNHIHLFA where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x347DBC0", Offset = "0x347C3C0", VA = "0x18347DBC0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, TDictionary MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x347D220", Offset = "0x347BA20", VA = "0x18347D220", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
	protected DOOLDJNJBDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class KJOPGCOEHKL<TKey, TValue, TIntermediate, TDictionary> : global::DOOLDJNJBDG<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x36185A0", Offset = "0x3616DA0", VA = "0x1836185A0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> LKNEEKOCJED(TDictionary PEJIHPGBPAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class LMEELIDLDMN<TKey, TValue, TDictionary> : global::KJOPGCOEHKL<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x11814F0", Offset = "0x117FCF0", VA = "0x1811814F0", Slot = "9")]
	protected override TDictionary GLIJLNLELKF(ref TDictionary CMLBIOKDKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class HFGPJLOMLPP<TKey, TValue> : global::DOOLDJNJBDG<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3A24DF0", Offset = "0x3A235F0", VA = "0x183A24DF0", Slot = "8")]
	protected override void IONNJMGFDPB(ref Dictionary<TKey, TValue> DPCBADAICKN, int CFANIPEBCPB, TKey BJKKIOODGOA, TValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x11814F0", Offset = "0x117FCF0", VA = "0x1811814F0", Slot = "9")]
	protected override Dictionary<TKey, TValue> GLIJLNLELKF(ref Dictionary<TKey, TValue> CMLBIOKDKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x26DD620", Offset = "0x26DBE20", VA = "0x1826DD620", Slot = "7")]
	protected override Dictionary<TKey, TValue> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3A24E30", Offset = "0x3A23630", VA = "0x183A24E30", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator LKNEEKOCJED(Dictionary<TKey, TValue> PEJIHPGBPAG)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1BB0630", Offset = "0x1BAEE30", VA = "0x181BB0630")]
	public HFGPJLOMLPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class LAJCEBEAOOL<TKey, TValue, TDictionary> : global::LMEELIDLDMN<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3C3D0E0", Offset = "0x3C3B8E0", VA = "0x183C3D0E0", Slot = "8")]
	protected override void IONNJMGFDPB(ref TDictionary DPCBADAICKN, int CFANIPEBCPB, TKey BJKKIOODGOA, TValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x28301B0", Offset = "0x282E9B0", VA = "0x1828301B0", Slot = "7")]
	protected override TDictionary JHOEBDGEJAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class JNIPLLPAGGO<TKey, TValue> : global::KJOPGCOEHKL<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x26DD5E0", Offset = "0x26DBDE0", VA = "0x1826DD5E0", Slot = "8")]
	protected override void IONNJMGFDPB(ref Dictionary<TKey, TValue> DPCBADAICKN, int CFANIPEBCPB, TKey BJKKIOODGOA, TValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x26DD620", Offset = "0x26DBE20", VA = "0x1826DD620", Slot = "7")]
	protected override Dictionary<TKey, TValue> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x11814F0", Offset = "0x117FCF0", VA = "0x1811814F0", Slot = "9")]
	protected override IDictionary<TKey, TValue> GLIJLNLELKF(ref Dictionary<TKey, TValue> CMLBIOKDKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class OCEPHJBMMPP<TKey, TValue> : global::LMEELIDLDMN<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x26DD5E0", Offset = "0x26DBDE0", VA = "0x1826DD5E0", Slot = "8")]
	protected override void IONNJMGFDPB(ref SortedList<TKey, TValue> DPCBADAICKN, int CFANIPEBCPB, TKey BJKKIOODGOA, TValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x26DD620", Offset = "0x26DBE20", VA = "0x1826DD620", Slot = "7")]
	protected override SortedList<TKey, TValue> JHOEBDGEJAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class GMOMOANOKCJ<TKey, TValue> : global::DOOLDJNJBDG<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x26DD5E0", Offset = "0x26DBDE0", VA = "0x1826DD5E0", Slot = "8")]
	protected override void IONNJMGFDPB(ref SortedDictionary<TKey, TValue> DPCBADAICKN, int CFANIPEBCPB, TKey BJKKIOODGOA, TValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x11814F0", Offset = "0x117FCF0", VA = "0x1811814F0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> GLIJLNLELKF(ref SortedDictionary<TKey, TValue> CMLBIOKDKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x26DD620", Offset = "0x26DBE20", VA = "0x1826DD620", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> JHOEBDGEJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x26DD680", Offset = "0x26DBE80", VA = "0x1826DD680", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D88180", Offset = "0x4D86980", VA = "0x184D88180", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, IDictionary MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x4D87E60", Offset = "0x4D86660", VA = "0x184D87E60", Slot = "5")]
	public IDictionary GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDCB60", Offset = "0x2BDB360", VA = "0x182BDCB60")]
	public BOOOLOEMIKO(params CDLCJJDIPKK[] AOAKLDAIACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2BDC310", Offset = "0x2BDAB10", VA = "0x182BDC310", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, object MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2BDC210", Offset = "0x2BDAA10", VA = "0x182BDC210", Slot = "5")]
	public object GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class JJLCGEEBIII
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x3344C30", Offset = "0x3343430", VA = "0x183344C30")]
	public static object PDNJPEANHIJ(Type DMBEFJIHONB, out bool COCCNAIAOED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x3344450", Offset = "0x3342C50", VA = "0x183344450")]
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
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public PKDNHLFKIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x36BD950", Offset = "0x36BC150", VA = "0x1836BD950")]
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
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public CDHIDBCCFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x36AA160", Offset = "0x36A8960", VA = "0x1836AA160")]
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
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public AIDJELAPMCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x36A8B80", Offset = "0x36A7380", VA = "0x1836A8B80")]
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
	[Cpp2IlInjected.Address(RVA = "0x36B78C0", Offset = "0x36B60C0", VA = "0x1836B78C0")]
	static OMEOCPAIEJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x36BCFB0", Offset = "0x36BB7B0", VA = "0x1836BCFB0")]
	public OMEOCPAIEJE(bool FEBDKLNKFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x36B4B70", Offset = "0x36B3370", VA = "0x1836B4B70", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, T MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x36B3810", Offset = "0x36B2010", VA = "0x1836B3810", Slot = "5")]
	public T GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x36B2160", Offset = "0x36B0960", VA = "0x1836B2160", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, T MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x36B1B60", Offset = "0x36B0360", VA = "0x1836B1B60", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x26B0660", Offset = "0x26AEE60", VA = "0x1826B0660", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, T? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x26B0360", Offset = "0x26AEB60", VA = "0x1826B0360", Slot = "5")]
	public T? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F9B960", Offset = "0x1F9A160", VA = "0x181F9B960")]
	public JBAJOOKAHLB(global::GNGMIEPFFIJ<T> FEIDBHKPDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3667A70", Offset = "0x3666270", VA = "0x183667A70", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, T? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3666E80", Offset = "0x3665680", VA = "0x183666E80", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D80410", Offset = "0x4D7EC10", VA = "0x184D80410", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, sbyte MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x4D803C0", Offset = "0x4D7EBC0", VA = "0x184D803C0", Slot = "5")]
	public sbyte GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x4D80380", Offset = "0x4D7EB80", VA = "0x184D80380", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, sbyte MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x4D802E0", Offset = "0x4D7EAE0", VA = "0x184D802E0", Slot = "7")]
	public sbyte CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BD9B20", Offset = "0x2BD8320", VA = "0x182BD9B20", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, sbyte? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9AB0", Offset = "0x2BD82B0", VA = "0x182BD9AB0", Slot = "5")]
	public sbyte? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x2BD99B0", Offset = "0x2BD81B0", VA = "0x182BD99B0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, sbyte? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9900", Offset = "0x2BD8100", VA = "0x182BD9900", Slot = "7")]
	public sbyte? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D87710", Offset = "0x4D85F10", VA = "0x184D87710", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, sbyte[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x4D87570", Offset = "0x4D85D70", VA = "0x184D87570", Slot = "5")]
	public sbyte[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE9160", Offset = "0x2BE7960", VA = "0x182BE9160", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, short MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9150", Offset = "0x2BE7950", VA = "0x182BE9150", Slot = "5")]
	public short GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9090", Offset = "0x2BE7890", VA = "0x182BE9090", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, short MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9020", Offset = "0x2BE7820", VA = "0x182BE9020", Slot = "7")]
	public short CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D7FEF0", Offset = "0x4D7E6F0", VA = "0x184D7FEF0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, short? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x4D7FE40", Offset = "0x4D7E640", VA = "0x184D7FE40", Slot = "5")]
	public short? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x4D7FDC0", Offset = "0x4D7E5C0", VA = "0x184D7FDC0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, short? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x4D7FCF0", Offset = "0x4D7E4F0", VA = "0x184D7FCF0", Slot = "7")]
	public short? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE3F60", Offset = "0x2BE2760", VA = "0x182BE3F60", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, short[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x2BE3E20", Offset = "0x2BE2620", VA = "0x182BE3E20", Slot = "5")]
	public short[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE7280", Offset = "0x2BE5A80", VA = "0x182BE7280", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, int MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7270", Offset = "0x2BE5A70", VA = "0x182BE7270", Slot = "5")]
	public int GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2BE71B0", Offset = "0x2BE59B0", VA = "0x182BE71B0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, int MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7140", Offset = "0x2BE5940", VA = "0x182BE7140", Slot = "7")]
	public int CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE6BE0", Offset = "0x2BE53E0", VA = "0x182BE6BE0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, int? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6B70", Offset = "0x2BE5370", VA = "0x182BE6B70", Slot = "5")]
	public int? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6A70", Offset = "0x2BE5270", VA = "0x182BE6A70", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, int? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2BE69D0", Offset = "0x2BE51D0", VA = "0x182BE69D0", Slot = "7")]
	public int? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D86C30", Offset = "0x4D85430", VA = "0x184D86C30", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, int[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x4D86A90", Offset = "0x4D85290", VA = "0x184D86A90", Slot = "5")]
	public int[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3340CE0", Offset = "0x333F4E0", VA = "0x183340CE0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, long MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x3340CD0", Offset = "0x333F4D0", VA = "0x183340CD0", Slot = "5")]
	public long GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x3340C90", Offset = "0x333F490", VA = "0x183340C90", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, long MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x3340C20", Offset = "0x333F420", VA = "0x183340C20", Slot = "7")]
	public long CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BEB720", Offset = "0x2BE9F20", VA = "0x182BEB720", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, long? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB690", Offset = "0x2BE9E90", VA = "0x182BEB690", Slot = "5")]
	public long? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB590", Offset = "0x2BE9D90", VA = "0x182BEB590", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, long? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB4D0", Offset = "0x2BE9CD0", VA = "0x182BEB4D0", Slot = "7")]
	public long? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D87190", Offset = "0x4D85990", VA = "0x184D87190", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, long[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D86FF0", Offset = "0x4D857F0", VA = "0x184D86FF0", Slot = "5")]
	public long[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3347BC0", Offset = "0x33463C0", VA = "0x183347BC0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, byte MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x3347BB0", Offset = "0x33463B0", VA = "0x183347BB0", Slot = "5")]
	public byte GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x3347B70", Offset = "0x3346370", VA = "0x183347B70", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, byte MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x3347B00", Offset = "0x3346300", VA = "0x183347B00", Slot = "7")]
	public byte CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDCE20", Offset = "0x2BDB620", VA = "0x182BDCE20", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, byte? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2BDCDB0", Offset = "0x2BDB5B0", VA = "0x182BDCDB0", Slot = "5")]
	public byte? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2BDCCB0", Offset = "0x2BDB4B0", VA = "0x182BDCCB0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, byte? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2BDCC00", Offset = "0x2BDB400", VA = "0x182BDCC00", Slot = "7")]
	public byte? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDF300", Offset = "0x2BDDB00", VA = "0x182BDF300", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ushort MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2BDF2F0", Offset = "0x2BDDAF0", VA = "0x182BDF2F0", Slot = "5")]
	public ushort GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2BDF230", Offset = "0x2BDDA30", VA = "0x182BDF230", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, ushort MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2BDF1C0", Offset = "0x2BDD9C0", VA = "0x182BDF1C0", Slot = "7")]
	public ushort CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE7870", Offset = "0x2BE6070", VA = "0x182BE7870", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ushort? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7800", Offset = "0x2BE6000", VA = "0x182BE7800", Slot = "5")]
	public ushort? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7700", Offset = "0x2BE5F00", VA = "0x182BE7700", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, ushort? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7660", Offset = "0x2BE5E60", VA = "0x182BE7660", Slot = "7")]
	public ushort? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE5040", Offset = "0x2BE3840", VA = "0x182BE5040", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ushort[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2BE4F00", Offset = "0x2BE3700", VA = "0x182BE4F00", Slot = "5")]
	public ushort[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDA000", Offset = "0x2BD8800", VA = "0x182BDA000", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, uint MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9FF0", Offset = "0x2BD87F0", VA = "0x182BD9FF0", Slot = "5")]
	public uint GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9F30", Offset = "0x2BD8730", VA = "0x182BD9F30", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, uint MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9EC0", Offset = "0x2BD86C0", VA = "0x182BD9EC0", Slot = "7")]
	public uint CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3347E60", Offset = "0x3346660", VA = "0x183347E60", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, uint? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x3347DF0", Offset = "0x33465F0", VA = "0x183347DF0", Slot = "5")]
	public uint? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x3347D70", Offset = "0x3346570", VA = "0x183347D70", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, uint? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x3347CD0", Offset = "0x33464D0", VA = "0x183347CD0", Slot = "7")]
	public uint? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE0510", Offset = "0x2BDED10", VA = "0x182BE0510", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, uint[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2BE03D0", Offset = "0x2BDEBD0", VA = "0x182BE03D0", Slot = "5")]
	public uint[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3345CD0", Offset = "0x33444D0", VA = "0x183345CD0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ulong MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x3345CC0", Offset = "0x33444C0", VA = "0x183345CC0", Slot = "5")]
	public ulong GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x3345C80", Offset = "0x3344480", VA = "0x183345C80", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, ulong MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x3345C10", Offset = "0x3344410", VA = "0x183345C10", Slot = "7")]
	public ulong CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D86F20", Offset = "0x4D85720", VA = "0x184D86F20", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ulong? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4D86E90", Offset = "0x4D85690", VA = "0x184D86E90", Slot = "5")]
	public ulong? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4D86E10", Offset = "0x4D85610", VA = "0x184D86E10", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, ulong? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4D86D50", Offset = "0x4D85550", VA = "0x184D86D50", Slot = "7")]
	public ulong? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE6E00", Offset = "0x2BE5600", VA = "0x182BE6E00", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ulong[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6CC0", Offset = "0x2BE54C0", VA = "0x182BE6CC0", Slot = "5")]
	public ulong[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE7440", Offset = "0x2BE5C40", VA = "0x182BE7440", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, float MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7430", Offset = "0x2BE5C30", VA = "0x182BE7430", Slot = "5")]
	public float GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7380", Offset = "0x2BE5B80", VA = "0x182BE7380", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, float MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7310", Offset = "0x2BE5B10", VA = "0x182BE7310", Slot = "7")]
	public float CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D7D330", Offset = "0x4D7BB30", VA = "0x184D7D330", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, float? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x4D7D2C0", Offset = "0x4D7BAC0", VA = "0x184D7D2C0", Slot = "5")]
	public float? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x4D7D240", Offset = "0x4D7BA40", VA = "0x184D7D240", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, float? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x4D7D160", Offset = "0x4D7B960", VA = "0x184D7D160", Slot = "7")]
	public float? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDD040", Offset = "0x2BDB840", VA = "0x182BDD040", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, float[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x2BDCF00", Offset = "0x2BDB700", VA = "0x182BDCF00", Slot = "5")]
	public float[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDD470", Offset = "0x2BDBC70", VA = "0x182BDD470", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, double MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD460", Offset = "0x2BDBC60", VA = "0x182BDD460", Slot = "5")]
	public double GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD3B0", Offset = "0x2BDBBB0", VA = "0x182BDD3B0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, double MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD340", Offset = "0x2BDBB40", VA = "0x182BDD340", Slot = "7")]
	public double CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D7ADF0", Offset = "0x4D795F0", VA = "0x184D7ADF0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, double? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4D7AD60", Offset = "0x4D79560", VA = "0x184D7AD60", Slot = "5")]
	public double? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4D7ACE0", Offset = "0x4D794E0", VA = "0x184D7ACE0", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, double? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x4D7ABD0", Offset = "0x4D793D0", VA = "0x184D7ABD0", Slot = "7")]
	public double? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D80160", Offset = "0x4D7E960", VA = "0x184D80160", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, double[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x4D7FFC0", Offset = "0x4D7E7C0", VA = "0x184D7FFC0", Slot = "5")]
	public double[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE75E0", Offset = "0x2BE5DE0", VA = "0x182BE75E0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, bool MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2BE75D0", Offset = "0x2BE5DD0", VA = "0x182BE75D0", Slot = "5")]
	public bool GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7520", Offset = "0x2BE5D20", VA = "0x182BE7520", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, bool MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2BE74B0", Offset = "0x2BE5CB0", VA = "0x182BE74B0", Slot = "7")]
	public bool CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3343E80", Offset = "0x3342680", VA = "0x183343E80", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, bool? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x3343E10", Offset = "0x3342610", VA = "0x183343E10", Slot = "5")]
	public bool? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x3343D90", Offset = "0x3342590", VA = "0x183343D90", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, bool? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x3343CE0", Offset = "0x33424E0", VA = "0x183343CE0", Slot = "7")]
	public bool? CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDE630", Offset = "0x2BDCE30", VA = "0x182BDE630", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, bool[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE4F0", Offset = "0x2BDCCF0", VA = "0x182BDE4F0", Slot = "5")]
	public bool[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE94A0", Offset = "0x2BE7CA0", VA = "0x182BE94A0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, object MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9200", Offset = "0x2BE7A00", VA = "0x182BE9200", Slot = "5")]
	public object GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x33478E0", Offset = "0x33460E0", VA = "0x1833478E0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, byte[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x3347860", Offset = "0x3346060", VA = "0x183347860", Slot = "5")]
	public byte[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BEAEF0", Offset = "0x2BE96F0", VA = "0x182BEAEF0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, ArraySegment<byte> MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2BEAE20", Offset = "0x2BE9620", VA = "0x182BEAE20", Slot = "5")]
	public ArraySegment<byte> GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D89A10", Offset = "0x4D88210", VA = "0x184D89A10", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, string MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x4D89A00", Offset = "0x4D88200", VA = "0x184D89A00", Slot = "5")]
	public string GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x4D89A10", Offset = "0x4D88210", VA = "0x184D89A10", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, string MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x4D89A00", Offset = "0x4D88200", VA = "0x184D89A00", Slot = "7")]
	public string CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D87450", Offset = "0x4D85C50", VA = "0x184D87450", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, string[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x4D872B0", Offset = "0x4D85AB0", VA = "0x184D872B0", Slot = "5")]
	public string[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3340A10", Offset = "0x333F210", VA = "0x183340A10", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, char MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x33409E0", Offset = "0x333F1E0", VA = "0x1833409E0", Slot = "5")]
	public char GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BEA4E0", Offset = "0x2BE8CE0", VA = "0x182BEA4E0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, char? MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA420", Offset = "0x2BE8C20", VA = "0x182BEA420", Slot = "5")]
	public char? GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE6180", Offset = "0x2BE4980", VA = "0x182BE6180", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, char[] MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5FE0", Offset = "0x2BE47E0", VA = "0x182BE5FE0", Slot = "5")]
	public char[] GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDD660", Offset = "0x2BDBE60", VA = "0x182BDD660", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Guid MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD5D0", Offset = "0x2BDBDD0", VA = "0x182BDD5D0", Slot = "5")]
	public Guid GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD630", Offset = "0x2BDBE30", VA = "0x182BDD630", Slot = "6")]
	public void EPGALEHBENA(ref AAEIOLMBBFI EEDEJPBOCJL, Guid MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD5D0", Offset = "0x2BDBDD0", VA = "0x182BDD5D0", Slot = "7")]
	public Guid CNHOELFKOAP(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0xB3AB20", Offset = "0xB39320", VA = "0x180B3AB20")]
	public MIGMFAOKMFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xDB4C00", Offset = "0xDB3400", VA = "0x180DB4C00")]
	public MIGMFAOKMFK(bool MMCADCCFMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x4D7CFC0", Offset = "0x4D7B7C0", VA = "0x184D7CFC0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, decimal MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x4D7CE10", Offset = "0x4D7B610", VA = "0x184D7CE10", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDE3E0", Offset = "0x2BDCBE0", VA = "0x182BDE3E0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Uri MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE360", Offset = "0x2BDCB60", VA = "0x182BDE360", Slot = "5")]
	public Uri GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3345DD0", Offset = "0x33445D0", VA = "0x183345DD0", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Version MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x3345D50", Offset = "0x3344550", VA = "0x183345D50", Slot = "5")]
	public Version GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3347A50", Offset = "0x3346250", VA = "0x183347A50", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, StringBuilder MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x33479D0", Offset = "0x33461D0", VA = "0x1833479D0", Slot = "5")]
	public StringBuilder GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDF060", Offset = "0x2BDD860", VA = "0x182BDF060", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, BitArray MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x2BDEF60", Offset = "0x2BDD760", VA = "0x182BDEF60", Slot = "5")]
	public BitArray GPGJANKJBGF(ref OEHFEJKEOBN OFLJDNJJLOF, CDLCJJDIPKK NLGGOOKKPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE0300", Offset = "0x2BDEB00", VA = "0x182BE0300")]
	public EGDMJBCEJHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x2BE02B0", Offset = "0x2BDEAB0", VA = "0x182BE02B0")]
	public EGDMJBCEJHF(bool HJLAKJFJFAK, bool CMCJONIFPLJ, bool KKLPFBADLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0120", Offset = "0x2BDE920", VA = "0x182BE0120", Slot = "4")]
	public void PBGNCPABBCO(ref AAEIOLMBBFI EEDEJPBOCJL, Type MFBIHMKFNKA, CDLCJJDIPKK NLGGOOKKPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0000", Offset = "0x2BDE800", VA = "0x182BE0000", Slot = "5")]
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
