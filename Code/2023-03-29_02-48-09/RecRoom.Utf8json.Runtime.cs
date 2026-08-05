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
internal static class JLGMEHBPCBD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5493370", Offset = "0x5492170", VA = "0x185493370")]
	public static bool POHGACBGPMB(this TypeInfo MAIOHDHBGKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class DFLFALGHMJC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type FGBPDNGGJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F10", Offset = "0x6F6D10", VA = "0x1806F7F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] PONMAEBJEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x740BD0", Offset = "0x73F9D0", VA = "0x180740BD0")]
	public DFLFALGHMJC(Type FBLAAKMMNCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor)]
public class LNICHNBGGJN : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void NMJNPKKKIJM<T>(ref OPNEEIEIDGM AGODLEOBGCG, T NLHFEJHKLAH, BJKEHJMPEHM BJNEMDJELDJ);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T CCCOECCIAGB<T>(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BJNEMDJELDJ);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GDABCMMFOHF
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LGGFBAFGLIF<T> : GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, T NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FCKKKGCGPCO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, T NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum ALMEEBLMHKO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BCILNPKOECH
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2CB5A70", Offset = "0x2CB4870", VA = "0x182CB5A70")]
	public static global::LGGFBAFGLIF<T> ACDNMPFOEKA<T>(this BJKEHJMPEHM BJNEMDJELDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4CF30D0", Offset = "0x4CF1ED0", VA = "0x184CF30D0")]
	public static object JLJONKLPBHK(this BJKEHJMPEHM BJNEMDJELDJ, Type MAIOHDHBGKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CHOAMJGHDHD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4CF8320", Offset = "0x4CF7120", VA = "0x184CF8320")]
	public CHOAMJGHDHD(string GNDOGDAIOKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BBCCONEKLEB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class HOMNLBEJLND
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] IHLLHGOCNMO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] LOEOOLKCAGI;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x54505D0", Offset = "0x544F3D0", VA = "0x1854505D0")]
		public static byte[] IHHMILNEAFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5450540", Offset = "0x544F340", VA = "0x185450540")]
		public static char[] HJAFMMKLCMO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> AAAGLHGBAJN;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] HGCNNMBDEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] NJGGJPEFKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int JBINMJEHBFH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool IMMBOLKJCBG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4CF2250", Offset = "0x4CF1050", VA = "0x184CF2250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4CF30C0", Offset = "0x4CF1EC0", VA = "0x184CF30C0")]
	public BBCCONEKLEB(byte[] NJGGJPEFKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4CF2ED0", Offset = "0x4CF1CD0", VA = "0x184CF2ED0")]
	public BBCCONEKLEB(byte[] NJGGJPEFKKD, int JBINMJEHBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4CF1D40", Offset = "0x4CF0B40", VA = "0x184CF1D40")]
	private FKELLNILGHD LKJNAIPEHII(string LONHIAHINDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4CF1A50", Offset = "0x4CF0850", VA = "0x184CF1A50")]
	private FKELLNILGHD HEBDJOBDFAC(string GNDOGDAIOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4CF0F40", Offset = "0x4CEFD40", VA = "0x184CF0F40")]
	public void BCIECNDIHGP(int JBINMJEHBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E30", Offset = "0x6F6C30", VA = "0x1806F7E30")]
	public byte[] ICCDDPHBBKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x79A680", Offset = "0x799480", VA = "0x18079A680")]
	public int NFMILCLFAEF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4CF1020", Offset = "0x4CEFE20", VA = "0x184CF1020")]
	public AECBNEABNGO CDHDALJNIAK()
	{
		return default(AECBNEABNGO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4CF2600", Offset = "0x4CF1400", VA = "0x184CF2600")]
	public void NFCJAJDIJKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4CF1590", Offset = "0x4CF0390", VA = "0x184CF1590")]
	public bool DPLPKDGEIJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4CF1690", Offset = "0x4CF0490", VA = "0x184CF1690")]
	public bool ECLCKOOIFDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4CF29E0", Offset = "0x4CF17E0", VA = "0x184CF29E0")]
	public void OLKLBAFLPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4CF1860", Offset = "0x4CF0660", VA = "0x184CF1860")]
	public bool GOBBEBEFBEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4CF2D10", Offset = "0x4CF1B10", VA = "0x184CF2D10")]
	public bool PKAEBEALFAI(ref int PHHDFCFDFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4CF2540", Offset = "0x4CF1340", VA = "0x184CF2540")]
	public bool MOAHPCMMPKH(ref int PHHDFCFDFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4CF2C50", Offset = "0x4CF1A50", VA = "0x184CF2C50")]
	public bool OPEDEAKEMFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4CF1CB0", Offset = "0x4CF0AB0", VA = "0x184CF1CB0")]
	public void KOGLJEOIPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4CF17F0", Offset = "0x4CF05F0", VA = "0x184CF17F0")]
	public bool FCIDAIOLFEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4CF1450", Offset = "0x4CF0250", VA = "0x184CF1450")]
	public bool DIAGJICIMOJ(ref int PHHDFCFDFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4CF14D0", Offset = "0x4CF02D0", VA = "0x184CF14D0")]
	public bool DNJKMPNDIIE(ref int PHHDFCFDFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4CF16F0", Offset = "0x4CF04F0", VA = "0x184CF16F0")]
	public bool ECMDKPHMEAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4CF24B0", Offset = "0x4CF12B0", VA = "0x184CF24B0")]
	public void MHOFIIEJLCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4CF1B30", Offset = "0x4CF0930", VA = "0x184CF1B30")]
	public bool JACGBOMABLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4CF0320", Offset = "0x4CEF120", VA = "0x184CF0320")]
	public void AAFCJABDFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4CF05B0", Offset = "0x4CEF3B0", VA = "0x184CF05B0")]
	private void AJEPINKFOHN(out byte[] OADBMEFLHBB, out int HOBNDFHLODP, out int EAJMAKEMKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4CF2870", Offset = "0x4CF1670", VA = "0x184CF2870")]
	private static int OFOBODOAAAM(char FEIPFLDEPBD, char MIECAKFJHNF, char BPJNCMDPHOE, char IJADEPADDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4CF27A0", Offset = "0x4CF15A0", VA = "0x184CF27A0")]
	private static int OBNMINFOOIN(char PAMKNJCGOGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4CF1270", Offset = "0x4CF0070", VA = "0x184CF1270")]
	public ArraySegment<byte> CGAACACOCJG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4CF1750", Offset = "0x4CF0550", VA = "0x184CF1750")]
	public string EDMBJGBFEPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4CF0520", Offset = "0x4CEF320", VA = "0x184CF0520")]
	public string AFANIIIMHPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4CF0D70", Offset = "0x4CEFB70", VA = "0x184CF0D70")]
	public ArraySegment<byte> AMJOLGEFHMO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4CF2D90", Offset = "0x4CF1B90", VA = "0x184CF2D90")]
	public ArraySegment<byte> PKJKEEDAAOM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4CF2270", Offset = "0x4CF1070", VA = "0x184CF2270")]
	public bool MHHDJHLDGED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4CF2920", Offset = "0x4CF1720", VA = "0x184CF2920")]
	private static bool OKJEEAJCKEB(byte BPJNCMDPHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4CF2A70", Offset = "0x4CF1870", VA = "0x184CF2A70")]
	private void OOEKKGELIFM(AECBNEABNGO INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4CF1850", Offset = "0x4CF0650", VA = "0x184CF1850")]
	public void GNFLKDKOPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4CF11A0", Offset = "0x4CEFFA0", VA = "0x184CF11A0")]
	private void CDIJHNLHLCF(int KHOPCFHDFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4CF1C60", Offset = "0x4CF0A60", VA = "0x184CF1C60")]
	public sbyte KCEBDABIPGH()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4CF2740", Offset = "0x4CF1540", VA = "0x184CF2740")]
	public short NLMOCLOCPLG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4CF13F0", Offset = "0x4CF01F0", VA = "0x184CF13F0")]
	public int CNCLKIGLFKM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4CF1370", Offset = "0x4CF0170", VA = "0x184CF1370")]
	public long CIKJPMENBKA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4CF02C0", Offset = "0x4CEF0C0", VA = "0x184CF02C0")]
	public byte AACJMLNIFCG()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4CF2CB0", Offset = "0x4CF1AB0", VA = "0x184CF2CB0")]
	public ushort PAPIAKLGDCO()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4CF0550", Offset = "0x4CEF350", VA = "0x184CF0550")]
	public uint AGHKCFELLDK()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4CF03B0", Offset = "0x4CEF1B0", VA = "0x184CF03B0")]
	public ulong AAMMBECMMIC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4CF0F50", Offset = "0x4CEFD50", VA = "0x184CF0F50")]
	public float BFPGEOPKNMF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4CF1B90", Offset = "0x4CF0990", VA = "0x184CF1B90")]
	public double JAPJHIFJDDB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4CF0430", Offset = "0x4CEF230", VA = "0x184CF0430")]
	public ArraySegment<byte> AEIGNBNEECE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4CF18C0", Offset = "0x4CF06C0", VA = "0x184CF18C0")]
	private static int HBCKKHMJNGB(byte[] NJGGJPEFKKD, int JBINMJEHBFH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FKELLNILGHD : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference AOJACLKFNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int EKHKCCDCCNK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int LKGGENCBPFB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x787620", Offset = "0x786420", VA = "0x180787620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string KGANLPDNDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x70D270", Offset = "0x70C070", VA = "0x18070D270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4D00520", Offset = "0x4CFF320", VA = "0x184D00520")]
	public FKELLNILGHD(string GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4D00590", Offset = "0x4CFF390", VA = "0x184D00590")]
	public FKELLNILGHD(string GNDOGDAIOKH, byte[] IEKDNMHIGLB, int JBINMJEHBFH, int EKHKCCDCCNK, string ILAIJAPHHKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JALKNKIBKNG
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class EDDPGMHFMFC
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private delegate void IGCPFNLNJIM(ref OPNEEIEIDGM AGODLEOBGCG, object NLHFEJHKLAH, BJKEHJMPEHM BJNEMDJELDJ);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private delegate object IADEIMJEOFM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BJNEMDJELDJ);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class JBBNACOMDAE
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class NIDEAPCNBMC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
				public NIDEAPCNBMC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x93B700", Offset = "0x93A500", VA = "0x18093B700")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x5459300", Offset = "0x5458100", VA = "0x185459300")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, BJKEHJMPEHM, byte[]> KFGGBCAMOAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, BJKEHJMPEHM> OFDPAEOKKLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly IGCPFNLNJIM DFCIKNBMFHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, BJKEHJMPEHM, ArraySegment<byte>> CFNBOKAELON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, BJKEHJMPEHM, string> KPBHFMGHPCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, BJKEHJMPEHM, object> GLGOJNIHPLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, BJKEHJMPEHM, object> PPFEEBCEFLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, BJKEHJMPEHM, object> MPGCGOMGDIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly IADEIMJEOFM EKFKEJKIDED;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5451200", Offset = "0x5450000", VA = "0x185451200")]
			public JBBNACOMDAE(Type MAIOHDHBGKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x5399FF0", Offset = "0x5398DF0", VA = "0x185399FF0")]
			private static T AMBECMEDHCP<T>(DynamicMethod DNLKKEKJCHD)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x5450FB0", Offset = "0x544FDB0", VA = "0x185450FB0")]
			private static MethodInfo OAGMDFBDMLB(Type MAIOHDHBGKE, string EOPECGOILOC, Type[] AEGNIJHEGEA)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, JBBNACOMDAE> DMOIHCMGLOF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::GADAHHOBMOO<JBBNACOMDAE> BCHAOILFDNC;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x544C450", Offset = "0x544B250", VA = "0x18544C450")]
		static EDDPGMHFMFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x544C3C0", Offset = "0x544B1C0", VA = "0x18544C3C0")]
		private static JBBNACOMDAE MGMLNFFFDMH(Type MAIOHDHBGKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x544C230", Offset = "0x544B030", VA = "0x18544C230")]
		public static void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, object NLHFEJHKLAH, BJKEHJMPEHM BJNEMDJELDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x544C110", Offset = "0x544AF10", VA = "0x18544C110")]
		public static void APDPBGNCGIO(Type MAIOHDHBGKE, ref OPNEEIEIDGM AGODLEOBGCG, object NLHFEJHKLAH, BJKEHJMPEHM BJNEMDJELDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class IEAKBBAELGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] IHLLHGOCNMO;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5450B20", Offset = "0x544F920", VA = "0x185450B20")]
		public static byte[] IHHMILNEAFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static BJKEHJMPEHM KKGBNCAAADJ;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] IKOEHHEBGAO;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] NHPGIICKNOO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static BJKEHJMPEHM BNGBMMCCDAM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5492650", Offset = "0x5491450", VA = "0x185492650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool CKBGNMHNINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5492770", Offset = "0x5491570", VA = "0x185492770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x54925E0", Offset = "0x54913E0", VA = "0x1854925E0")]
	public static void HIFGHPPGFHD(BJKEHJMPEHM BJNEMDJELDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2D3FAF0", Offset = "0x2D3E8F0", VA = "0x182D3FAF0")]
	public static byte[] APDPBGNCGIO<T>(T BLIKPCIFNNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2D3FC00", Offset = "0x2D3EA00", VA = "0x182D3FC00")]
	public static byte[] APDPBGNCGIO<T>(T NLHFEJHKLAH, BJKEHJMPEHM BJNEMDJELDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2D3FA60", Offset = "0x2D3E860", VA = "0x182D3FA60")]
	public static void APDPBGNCGIO<T>(ref OPNEEIEIDGM AGODLEOBGCG, T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2D3F980", Offset = "0x2D3E780", VA = "0x182D3F980")]
	public static void APDPBGNCGIO<T>(ref OPNEEIEIDGM AGODLEOBGCG, T NLHFEJHKLAH, BJKEHJMPEHM BJNEMDJELDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2D3FB70", Offset = "0x2D3E970", VA = "0x182D3FB70")]
	public static void APDPBGNCGIO<T>(Stream IFCPBBBMBJL, T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2D3F860", Offset = "0x2D3E660", VA = "0x182D3F860")]
	public static void APDPBGNCGIO<T>(Stream IFCPBBBMBJL, T NLHFEJHKLAH, BJKEHJMPEHM BJNEMDJELDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2D3FEE0", Offset = "0x2D3ECE0", VA = "0x182D3FEE0")]
	public static ArraySegment<byte> BBPMGGJCPKI<T>(T BLIKPCIFNNO)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2D3FD60", Offset = "0x2D3EB60", VA = "0x182D3FD60")]
	public static ArraySegment<byte> BBPMGGJCPKI<T>(T NLHFEJHKLAH, BJKEHJMPEHM BJNEMDJELDJ)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2D41500", Offset = "0x2D40300", VA = "0x182D41500")]
	public static string OOIHCFDNJMF<T>(T NLHFEJHKLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2D413A0", Offset = "0x2D401A0", VA = "0x182D413A0")]
	public static string OOIHCFDNJMF<T>(T NLHFEJHKLAH, BJKEHJMPEHM BJNEMDJELDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2D40B30", Offset = "0x2D3F930", VA = "0x182D40B30")]
	public static T DHABJCANOEO<T>(string GEEBMNKHCKE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2D408E0", Offset = "0x2D3F6E0", VA = "0x182D408E0")]
	public static T DHABJCANOEO<T>(string GEEBMNKHCKE, BJKEHJMPEHM BJNEMDJELDJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2D41010", Offset = "0x2D3FE10", VA = "0x182D41010")]
	public static T DHABJCANOEO<T>(byte[] NJGGJPEFKKD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2D40BD0", Offset = "0x2D3F9D0", VA = "0x182D40BD0")]
	public static T DHABJCANOEO<T>(byte[] NJGGJPEFKKD, BJKEHJMPEHM BJNEMDJELDJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2D40D40", Offset = "0x2D3FB40", VA = "0x182D40D40")]
	public static T DHABJCANOEO<T>(byte[] NJGGJPEFKKD, int JBINMJEHBFH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2D409D0", Offset = "0x2D3F7D0", VA = "0x182D409D0")]
	public static T DHABJCANOEO<T>(byte[] NJGGJPEFKKD, int JBINMJEHBFH, BJKEHJMPEHM BJNEMDJELDJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2D41090", Offset = "0x2D3FE90", VA = "0x182D41090")]
	public static T DHABJCANOEO<T>(ref BBCCONEKLEB EDHAMFMKJBA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2D40C70", Offset = "0x2D3FA70", VA = "0x182D40C70")]
	public static T DHABJCANOEO<T>(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BJNEMDJELDJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2D41110", Offset = "0x2D3FF10", VA = "0x182D41110")]
	public static T DHABJCANOEO<T>(Stream IFCPBBBMBJL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2D41270", Offset = "0x2D40070", VA = "0x182D41270")]
	public static T DHABJCANOEO<T>(Stream IFCPBBBMBJL, BJKEHJMPEHM BJNEMDJELDJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5492380", Offset = "0x5491180", VA = "0x185492380")]
	public static string CKMGBPMDNHA(byte[] GEEBMNKHCKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5492530", Offset = "0x5491330", VA = "0x185492530")]
	public static string CKMGBPMDNHA(byte[] GEEBMNKHCKE, int JBINMJEHBFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5492460", Offset = "0x5491260", VA = "0x185492460")]
	public static string CKMGBPMDNHA(string GEEBMNKHCKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x54928A0", Offset = "0x54916A0", VA = "0x1854928A0")]
	public static byte[] OANPJALDGMG(byte[] GEEBMNKHCKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5492980", Offset = "0x5491780", VA = "0x185492980")]
	public static byte[] OANPJALDGMG(byte[] GEEBMNKHCKE, int JBINMJEHBFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x54927D0", Offset = "0x54915D0", VA = "0x1854927D0")]
	public static byte[] OANPJALDGMG(string GEEBMNKHCKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5491DF0", Offset = "0x5490BF0", VA = "0x185491DF0")]
	private static void BKPBIBJEIPM(ref BBCCONEKLEB EDHAMFMKJBA, ref OPNEEIEIDGM AGODLEOBGCG, int ACNLMINHECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x54922E0", Offset = "0x54910E0", VA = "0x1854922E0")]
	private static int CCLOPHMIGPF(Stream LCGINHIJIBJ, ref byte[] IHLLHGOCNMO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum AECBNEABNGO : byte
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
public struct OPNEEIEIDGM
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] BEIKGKMBKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] IHLLHGOCNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int JBINMJEHBFH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BHLDEPBHPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x79A680", Offset = "0x799480", VA = "0x18079A680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4CF0F40", Offset = "0x4CEFD40", VA = "0x184CF0F40")]
	public void BCIECNDIHGP(int JBINMJEHBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x545A1F0", Offset = "0x5458FF0", VA = "0x18545A1F0")]
	public static byte[] CCBMIIPMMOF(string MIJBBGDIDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x545ADB0", Offset = "0x5459BB0", VA = "0x18545ADB0")]
	public static byte[] OCLBNNOOHJG(string MIJBBGDIDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x545A660", Offset = "0x5459460", VA = "0x18545A660")]
	public static byte[] KGIFHLKDLLD(string MIJBBGDIDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x545AAE0", Offset = "0x54598E0", VA = "0x18545AAE0")]
	public static byte[] MLGDLOGFPAP(string MIJBBGDIDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1013210", Offset = "0x1012010", VA = "0x181013210")]
	public OPNEEIEIDGM(byte[] GANGLJNGKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x545A510", Offset = "0x5459310", VA = "0x18545A510")]
	public ArraySegment<byte> IHHMILNEAFM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x545A440", Offset = "0x5459240", VA = "0x18545A440")]
	public byte[] GIPFOKNDBBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x545B320", Offset = "0x545A120", VA = "0x18545B320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x545A880", Offset = "0x5459680", VA = "0x18545A880")]
	public void LDNDDAIJFAA(int KPKCDILAMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4CF6460", Offset = "0x4CF5260", VA = "0x184CF6460")]
	public void NKDPCGFAKOH(byte CAKBPNLGNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x545ACD0", Offset = "0x5459AD0", VA = "0x18545ACD0")]
	public void NKDPCGFAKOH(byte[] CAKBPNLGNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x545A300", Offset = "0x5459100", VA = "0x18545A300")]
	public void DBIAFKOJEDD(byte CAKBPNLGNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x545AC30", Offset = "0x5459A30", VA = "0x18545AC30")]
	public void NAEOKCIJPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x545A610", Offset = "0x5459410", VA = "0x18545A610")]
	public void JNJOIPIDCIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x545AC80", Offset = "0x5459A80", VA = "0x18545AC80")]
	public void NFINMNDDEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x545A5C0", Offset = "0x54593C0", VA = "0x18545A5C0")]
	public void JADJNIHLBCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x545A4C0", Offset = "0x54592C0", VA = "0x18545A4C0")]
	public void GOKBFNJMMBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x545A800", Offset = "0x5459600", VA = "0x18545A800")]
	public void KLCCJIDMBOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x545A7A0", Offset = "0x54595A0", VA = "0x18545A7A0")]
	public void KJKLCHFKAJO(string MIJBBGDIDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x545A340", Offset = "0x5459140", VA = "0x18545A340")]
	public void ECBCMAOIONJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x545A120", Offset = "0x5458F20", VA = "0x18545A120")]
	public void BBMCGNNNGNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x545A890", Offset = "0x5459690", VA = "0x18545A890")]
	public void LPMHNNKCHMD(bool NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x545A390", Offset = "0x5459190", VA = "0x18545A390")]
	public void FBIHHKPNLHO(float NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x545AD30", Offset = "0x5459B30", VA = "0x18545AD30")]
	public void OBKKACGOAED(double NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x545A410", Offset = "0x5459210", VA = "0x18545A410")]
	public void FDBKHABKCMK(byte NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x545AF20", Offset = "0x5459D20", VA = "0x18545AF20")]
	public void PEGOOGLAJBP(ushort NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x545AAB0", Offset = "0x54598B0", VA = "0x18545AAB0")]
	public void MFPEAGIHICO(uint NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x545A0F0", Offset = "0x5458EF0", VA = "0x18545A0F0")]
	public void APFODKPFJMN(ulong NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x545AEF0", Offset = "0x5459CF0", VA = "0x18545AEF0")]
	public void PBPDLBBBBKH(sbyte NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x545A850", Offset = "0x5459650", VA = "0x18545A850")]
	public void KMMNIKJHCPC(short NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x545A2D0", Offset = "0x54590D0", VA = "0x18545A2D0")]
	public void CLCKLKBEJCF(int NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x545AA80", Offset = "0x5459880", VA = "0x18545AA80")]
	public void MEPCNILJKNM(long NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x545AF50", Offset = "0x5459D50", VA = "0x18545AF50")]
	public void PFEIGEEDHEK(string NLHFEJHKLAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NCOLAKAOJPA : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private static class MAAJMHAJFLB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x35D75A0", Offset = "0x35D63A0", VA = "0x1835D75A0")]
		static MAAJMHAJFLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private NCOLAKAOJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class BEDNJJEGIKE
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> BMALMIHFDGA;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4CF3F30", Offset = "0x4CF2D30", VA = "0x184CF3F30")]
	static BEDNJJEGIKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4CF3820", Offset = "0x4CF2620", VA = "0x184CF3820")]
	internal static object PIJGGIGIBIK(Type KFBDCAJNIAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class GPBIJNCLGBL : global::LGGFBAFGLIF<Vector2>, GDABCMMFOHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DMKELGAOJPN PBOKFEHIDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] ICPJLIFBPIJ;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4D03EA0", Offset = "0x4D02CA0", VA = "0x184D03EA0")]
	public GPBIJNCLGBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4D03AA0", Offset = "0x4D028A0", VA = "0x184D03AA0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, Vector2 NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4D03B50", Offset = "0x4D02950", VA = "0x184D03B50", Slot = "5")]
	public Vector2 DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class KNGJJNPEPLO : global::LGGFBAFGLIF<Vector3>, GDABCMMFOHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly DMKELGAOJPN PBOKFEHIDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] ICPJLIFBPIJ;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x549E620", Offset = "0x549D420", VA = "0x18549E620")]
	public KNGJJNPEPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x549E340", Offset = "0x549D140", VA = "0x18549E340", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, Vector3 NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x549E460", Offset = "0x549D260", VA = "0x18549E460", Slot = "5")]
	public Vector3 DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class IOBPOEPMJJG : global::LGGFBAFGLIF<Vector4>, GDABCMMFOHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly DMKELGAOJPN PBOKFEHIDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] ICPJLIFBPIJ;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5491810", Offset = "0x5490610", VA = "0x185491810")]
	public IOBPOEPMJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4CFE7F0", Offset = "0x4CFD5F0", VA = "0x184CFE7F0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, Vector4 NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x54915F0", Offset = "0x54903F0", VA = "0x1854915F0", Slot = "5")]
	public Vector4 DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class EKLPOGINDJE : global::LGGFBAFGLIF<Quaternion>, GDABCMMFOHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly DMKELGAOJPN PBOKFEHIDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] ICPJLIFBPIJ;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4CFED20", Offset = "0x4CFDB20", VA = "0x184CFED20")]
	public EKLPOGINDJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4CFE7F0", Offset = "0x4CFD5F0", VA = "0x184CFE7F0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, Quaternion NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4CFE940", Offset = "0x4CFD740", VA = "0x184CFE940", Slot = "5")]
	public Quaternion DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KAHBMLANHFD : global::LGGFBAFGLIF<Color>, GDABCMMFOHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly DMKELGAOJPN PBOKFEHIDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] ICPJLIFBPIJ;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x54935C0", Offset = "0x54923C0", VA = "0x1854935C0")]
	public KAHBMLANHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4CFE7F0", Offset = "0x4CFD5F0", VA = "0x184CFE7F0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, Color NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x54933A0", Offset = "0x54921A0", VA = "0x1854933A0", Slot = "5")]
	public Color DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class ELIOCNBMBEF : global::LGGFBAFGLIF<Bounds>, GDABCMMFOHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly DMKELGAOJPN PBOKFEHIDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] ICPJLIFBPIJ;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4CFF6B0", Offset = "0x4CFE4B0", VA = "0x184CFF6B0")]
	public ELIOCNBMBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4CFF090", Offset = "0x4CFDE90", VA = "0x184CFF090", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, Bounds NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4CFF230", Offset = "0x4CFE030", VA = "0x184CFF230", Slot = "5")]
	public Bounds DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class IMABJLJNINE : global::LGGFBAFGLIF<Rect>, GDABCMMFOHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly DMKELGAOJPN PBOKFEHIDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] ICPJLIFBPIJ;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5491140", Offset = "0x548FF40", VA = "0x185491140")]
	public IMABJLJNINE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5490D90", Offset = "0x548FB90", VA = "0x185490D90", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, Rect NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5490F00", Offset = "0x548FD00", VA = "0x185490F00", Slot = "5")]
	public Rect DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class BMNOHFPCNHG : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private static class OPCFMBKPPJN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4D953A0", Offset = "0x4D941A0", VA = "0x184D953A0")]
		static OPCFMBKPPJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private BMNOHFPCNHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class EAJNAJJLCIG : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private static class KDDDHEELPOB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BBEB50", Offset = "0x2BBD950", VA = "0x182BBEB50")]
		static KDDDHEELPOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class HFAJAJBOBJD
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> EDBBBDPHGGA;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x544E5D0", Offset = "0x544D3D0", VA = "0x18544E5D0")]
		internal static object PIJGGIGIBIK(Type KFBDCAJNIAB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private EAJNAJJLCIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class PMOPFEFNDNE : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class PEPECOJGPCE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x38A4B00", Offset = "0x38A3900", VA = "0x1838A4B00")]
		static PEPECOJGPCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly PMOPFEFNDNE PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool CDJNDHHFNEH;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static GDABCMMFOHF[] GAHIADJFGOB;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static BJKEHJMPEHM[] LGIKNAKBMHM;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private PMOPFEFNDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x545F250", Offset = "0x545E050", VA = "0x18545F250")]
	public static void CBFNCDGCFPB(params BJKEHJMPEHM[] LGIKNAKBMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x545F330", Offset = "0x545E130", VA = "0x18545F330")]
	public static void CBFNCDGCFPB(params GDABCMMFOHF[] GAHIADJFGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x545F410", Offset = "0x545E210", VA = "0x18545F410")]
	public static void HCECIFJONDL(GDABCMMFOHF[] GAHIADJFGOB, BJKEHJMPEHM[] LGIKNAKBMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class AOJNPOFGKOE : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class FFGKIGOFCKK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x37BD7E0", Offset = "0x37BC5E0", VA = "0x1837BD7E0")]
		static FFGKIGOFCKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private AOJNPOFGKOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class PJLMFFLNGNI
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly BJKEHJMPEHM LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly BJKEHJMPEHM MNKGBOCIHEO;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly BJKEHJMPEHM LPFAJJFIDOH;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly BJKEHJMPEHM BIIGAHDONGH;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly BJKEHJMPEHM OMGKKGECHBH;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly BJKEHJMPEHM INKABLGMHIA;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly BJKEHJMPEHM CLLGHCOCACE;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly BJKEHJMPEHM PCJJPFEPKPN;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly BJKEHJMPEHM NKLFMLDMLKK;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly BJKEHJMPEHM PKDAOFCFKMM;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly BJKEHJMPEHM NNBNBLKMEJB;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly BJKEHJMPEHM CKIKLIJNCOI;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class CINIJNFFIBI
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly BJKEHJMPEHM LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly BJKEHJMPEHM OHAFEBGCKMF;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class DPJODIKFJAN
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly BJKEHJMPEHM LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly BJKEHJMPEHM MNKGBOCIHEO;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly BJKEHJMPEHM LPFAJJFIDOH;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly BJKEHJMPEHM BIIGAHDONGH;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly BJKEHJMPEHM OMGKKGECHBH;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly BJKEHJMPEHM INKABLGMHIA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly BJKEHJMPEHM CLLGHCOCACE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly BJKEHJMPEHM PCJJPFEPKPN;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly BJKEHJMPEHM NKLFMLDMLKK;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly BJKEHJMPEHM PKDAOFCFKMM;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly BJKEHJMPEHM NNBNBLKMEJB;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly BJKEHJMPEHM CKIKLIJNCOI;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class EGMKPADKJMB
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> EDBBBDPHGGA;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4CFC800", Offset = "0x4CFB600", VA = "0x184CFC800")]
	internal static object PIJGGIGIBIK(Type KFBDCAJNIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4CFC7C0", Offset = "0x4CFB5C0", VA = "0x184CFC7C0")]
	private static object EEGHMBDDPBC(Type EKIHJFFAEMN, Type[] JGIGNCKKDKF, params object[] AEGNIJHEGEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class AGIKAJGNEIH : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private static class HEAEGFLCIME<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3A86F60", Offset = "0x3A85D60", VA = "0x183A86F60")]
		static HEAEGFLCIME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> ADDPMBKGECE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool KJAANLGOCJK;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly FJEEGGPOFAJ IEOLCACFECJ;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4CEED70", Offset = "0x4CEDB70", VA = "0x184CEED70")]
	static AGIKAJGNEIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private AGIKAJGNEIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class FPMDBBLNOAM : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private static class LKJGFNAHELK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x318D910", Offset = "0x318C710", VA = "0x18318D910")]
		static LKJGFNAHELK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> ADDPMBKGECE;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool KJAANLGOCJK;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly FJEEGGPOFAJ IEOLCACFECJ;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4D02340", Offset = "0x4D01140", VA = "0x184D02340")]
	static FPMDBBLNOAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private FPMDBBLNOAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class PGPIBAFHGCD : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class AGPDNCCEMBM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2C2F280", Offset = "0x2C2E080", VA = "0x182C2F280")]
		static AGPDNCCEMBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> ADDPMBKGECE;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool KJAANLGOCJK;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly FJEEGGPOFAJ IEOLCACFECJ;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x545D8C0", Offset = "0x545C6C0", VA = "0x18545D8C0")]
	static PGPIBAFHGCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private PGPIBAFHGCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class MPAPFCNMOFN : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class MLMFLCENNIN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x396AAC0", Offset = "0x39698C0", VA = "0x18396AAC0")]
		static MLMFLCENNIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> ADDPMBKGECE;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool KJAANLGOCJK;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly FJEEGGPOFAJ IEOLCACFECJ;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x54589F0", Offset = "0x54577F0", VA = "0x1854589F0")]
	static MPAPFCNMOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private MPAPFCNMOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class CIGFJJGMAGK : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class HPIEKHFBONO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C4E0", Offset = "0x2C7B2E0", VA = "0x182C7C4E0")]
		static HPIEKHFBONO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> ADDPMBKGECE;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool KJAANLGOCJK;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly FJEEGGPOFAJ IEOLCACFECJ;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4CF8390", Offset = "0x4CF7190", VA = "0x184CF8390")]
	static CIGFJJGMAGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private CIGFJJGMAGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class ENHBMFGDGML : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class JKDOBEIGAPG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2F53360", Offset = "0x2F52160", VA = "0x182F53360")]
		static JKDOBEIGAPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> ADDPMBKGECE;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool KJAANLGOCJK;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly FJEEGGPOFAJ IEOLCACFECJ;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4CFFBB0", Offset = "0x4CFE9B0", VA = "0x184CFFBB0")]
	static ENHBMFGDGML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private ENHBMFGDGML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class KJBDPPJINPH : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class NFODEEKGFJO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x39117E0", Offset = "0x39105E0", VA = "0x1839117E0")]
		static NFODEEKGFJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> ADDPMBKGECE;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool KJAANLGOCJK;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KJBDPPJINPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class PNKGJJLIJNH : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class MKMLNGKNDAK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x39629D0", Offset = "0x39617D0", VA = "0x1839629D0")]
		static MKMLNGKNDAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> ADDPMBKGECE;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool KJAANLGOCJK;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public PNKGJJLIJNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class GKAADNGLBON : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class CFCJFMPFDHN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3573560", Offset = "0x3572360", VA = "0x183573560")]
		static CFCJFMPFDHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> ADDPMBKGECE;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool KJAANLGOCJK;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public GKAADNGLBON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class LFBIPMBHAME : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class EKNCMDLGOOC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3515A90", Offset = "0x3514890", VA = "0x183515A90")]
		static EKNCMDLGOOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> ADDPMBKGECE;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool KJAANLGOCJK;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public LFBIPMBHAME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class BKPFNPEGPDP : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class ODMOMFONKAN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3B40740", Offset = "0x3B3F540", VA = "0x183B40740")]
		static ODMOMFONKAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> ADDPMBKGECE;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool KJAANLGOCJK;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public BKPFNPEGPDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class DIDCGBKEHEA : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class PHOFJFDFFDI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3B90", Offset = "0x2AC2990", VA = "0x182AC3B90")]
		static PHOFJFDFFDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> ADDPMBKGECE;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool KJAANLGOCJK;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public DIDCGBKEHEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class KFNJKEIMMGH
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private struct ANKGNGPIEIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public HHFDDCDEAAA IPLPBAAANGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder JGMGJOBOMNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder BBFEIICHNGJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class LANHFJGIKEN
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		internal static class LMFHGFALDJC
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo KGIFHLKDLLD;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo OCLBNNOOHJG;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo MLGDLOGFPAP;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo CCBMIIPMMOF;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo BBMCGNNNGNN;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo NKDPCGFAKOH;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo NFINMNDDEOI;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo JADJNIHLBCP;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo GOKBFNJMMBM;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x5456230", Offset = "0x5455030", VA = "0x185456230")]
			static LMFHGFALDJC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class BOKDHBOGMAK
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo DPLPKDGEIJG;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo KOGLJEOIPBM;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo DIAGJICIMOJ;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo KNIBEMBDCNB;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo GNFLKDKOPPD;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo ICCDDPHBBKA;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo NFMILCLFAEF;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x544ABC0", Offset = "0x54499C0", VA = "0x18544ABC0")]
			static BOKDHBOGMAK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class PFBPFKDLNJE
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo FGBPDNGGJPE;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo PONMAEBJEGE;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo HIDHDAIIGMC;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo ACDNMPFOEKA;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo IJKFKPLGCFI;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo IADCFNLEOMO;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo KMFADGOAPGD;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo KAOAKDPOPNG;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo HINBDOFCOJG;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo NECILHGGMDE;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo GAOLGNIEAHO;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo IJFLLKNBGLG;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo HJAPLFPAMEE;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo GEGFINEPDFN;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5454000", Offset = "0x5452E00", VA = "0x185454000")]
		public static MethodInfo APDPBGNCGIO(Type MAIOHDHBGKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x54542D0", Offset = "0x54530D0", VA = "0x1854542D0")]
		public static MethodInfo DHABJCANOEO(Type MAIOHDHBGKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5454540", Offset = "0x5453340", VA = "0x185454540")]
		public static MethodInfo LAIAMDNHIDC(Type MAIOHDHBGKE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class DJJNIDGECCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<HHFDDCDEAAA, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public DJJNIDGECCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class BJBOMNCADHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public DJJNIDGECCD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public BJBOMNCADHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x544A940", Offset = "0x5449740", VA = "0x18544A940")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x544AA50", Offset = "0x5449850", VA = "0x18544AA50")]
		internal bool <BuildType>b__2(int index, HHFDDCDEAAA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class IHJHJAPKPIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public DJJNIDGECCD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public IHJHJAPKPIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5450E40", Offset = "0x544FC40", VA = "0x185450E40")]
		internal bool <BuildType>b__3(int index, HHFDDCDEAAA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class KFNFNABCADN
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
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public KFNFNABCADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5453FA0", Offset = "0x5452DA0", VA = "0x185453FA0")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class MKJKNOBAMBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public MKJKNOBAMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x54586D0", Offset = "0x54574D0", VA = "0x1854586D0")]
		internal bool <BuildAnonymousFormatter>b__2(HHFDDCDEAAA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class LIAEJBAAEJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public KFNFNABCADN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public LIAEJBAAEJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5455DF0", Offset = "0x5454BF0", VA = "0x185455DF0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5455E70", Offset = "0x5454C70", VA = "0x185455E70")]
		internal bool <BuildAnonymousFormatter>b__6(int index, HHFDDCDEAAA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class KBACCCLGMEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public KFNFNABCADN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public KBACCCLGMEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5453BE0", Offset = "0x54529E0", VA = "0x185453BE0")]
		internal bool <BuildAnonymousFormatter>b__7(int index, HHFDDCDEAAA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class JFKJFDHIBGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public JFKJFDHIBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x800EB0", Offset = "0x7FFCB0", VA = "0x180800EB0")]
		internal Label <BuildSerialize>b__1(HHFDDCDEAAA _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class PAEOENGMBBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public ANKGNGPIEIA[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, HHFDDCDEAAA, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public MHOCPPDBEFJ argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public MHOCPPDBEFJ argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public PAEOENGMBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x545B3E0", Offset = "0x545A1E0", VA = "0x18545B3E0")]
		internal ANKGNGPIEIA <BuildDeserialize>b__0(HHFDDCDEAAA item)
		{
			return default(ANKGNGPIEIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CKENMMDCKMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public PAEOENGMBBI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public CKENMMDCKMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x544BBE0", Offset = "0x544A9E0", VA = "0x18544BBE0")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x544BEB0", Offset = "0x544ACB0", VA = "0x18544BEB0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class BCCOFKBOIFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public HHFDDCDEAAA item;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public BCCOFKBOIFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x147E450", Offset = "0x147D250", VA = "0x18147E450")]
		internal bool <EmitNewObject>b__0(ANKGNGPIEIA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class FDBDGDHAJGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public HHFDDCDEAAA item;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public FDBDGDHAJGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x147E450", Offset = "0x147D250", VA = "0x18147E450")]
		internal bool <EmitNewObject>b__2(ANKGNGPIEIA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex BEDECGICKDJ;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int LIHOJAKKINC;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> GFOIBLMOKHI;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> NDJOGJPCPNK;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3823350", Offset = "0x3822150", VA = "0x183823350")]
	public static object PNGLCJIGBJK<T>(FJEEGGPOFAJ IEOLCACFECJ, BJKEHJMPEHM HOABAAFBFGH, Func<string, string> ADDPMBKGECE, bool KJAANLGOCJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3818990", Offset = "0x3817790", VA = "0x183818990")]
	public static object IAFBBMPPANO<T>(BJKEHJMPEHM HOABAAFBFGH, Func<string, string> ADDPMBKGECE, bool KJAANLGOCJK, bool FLFCHEMEABL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x54980E0", Offset = "0x5496EE0", VA = "0x1854980E0")]
	private static TypeInfo CPAPLCNMNJI(FJEEGGPOFAJ IEOLCACFECJ, Type MAIOHDHBGKE, Func<string, string> ADDPMBKGECE, bool KJAANLGOCJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5494C60", Offset = "0x5493A60", VA = "0x185494C60")]
	public static object AGIKBJIGHBC(Type MAIOHDHBGKE, Func<string, string> ADDPMBKGECE, bool KJAANLGOCJK, bool FLFCHEMEABL, bool MGBNNPDCMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x54991F0", Offset = "0x5497FF0", VA = "0x1854991F0")]
	private static Dictionary<HHFDDCDEAAA, FieldInfo> HKCLLODOAHI(TypeBuilder FJGCBAKEHEK, LBENAAOKFDK DNOEJKEOKKF, ConstructorInfo LDHPLLNPIDE, FieldBuilder AAALNIOECAL, ILGenerator IBIKFHJIHBF, bool KJAANLGOCJK, bool HJCFACBMLNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5498B70", Offset = "0x5497970", VA = "0x185498B70")]
	private static Dictionary<HHFDDCDEAAA, FieldInfo> DCAKFCNKAIG(TypeBuilder FJGCBAKEHEK, LBENAAOKFDK DNOEJKEOKKF, ILGenerator IBIKFHJIHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x549B340", Offset = "0x549A140", VA = "0x18549B340")]
	private static void PDEKOBMEINC(Type MAIOHDHBGKE, LBENAAOKFDK DNOEJKEOKKF, ILGenerator IBIKFHJIHBF, Action HILLKAOAFOJ, Func<int, HHFDDCDEAAA, bool> KAHJKDIONAG, bool KJAANLGOCJK, bool HJCFACBMLNO, int MINEBMJMPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x54967E0", Offset = "0x54955E0", VA = "0x1854967E0")]
	private static void ALHMJAHILBE(TypeInfo MAIOHDHBGKE, HHFDDCDEAAA HJGEBOFGLHO, ILGenerator IBIKFHJIHBF, int CPOAAGLEIPE, Func<int, HHFDDCDEAAA, bool> KAHJKDIONAG, MHOCPPDBEFJ AGODLEOBGCG, MHOCPPDBEFJ HFDNBHAKNHF, MHOCPPDBEFJ HKMLEKJDFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5499D90", Offset = "0x5498B90", VA = "0x185499D90")]
	private static void JHKCHAGCAFE(Type MAIOHDHBGKE, LBENAAOKFDK DNOEJKEOKKF, ILGenerator IBIKFHJIHBF, Func<int, HHFDDCDEAAA, bool> KAHJKDIONAG, bool ADGCLNNGBOA, int MINEBMJMPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x54998D0", Offset = "0x54986D0", VA = "0x1854998D0")]
	private static void IGGMCBLGNPC(ILGenerator IBIKFHJIHBF, ANKGNGPIEIA DNOEJKEOKKF, int CPOAAGLEIPE, Func<int, HHFDDCDEAAA, bool> KAHJKDIONAG, MHOCPPDBEFJ EDHAMFMKJBA, MHOCPPDBEFJ HKMLEKJDFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5496D30", Offset = "0x5495B30", VA = "0x185496D30")]
	private static LocalBuilder AODONMCBAMK(ILGenerator IBIKFHJIHBF, Type MAIOHDHBGKE, LBENAAOKFDK DNOEJKEOKKF, ANKGNGPIEIA[] MPGGKGLOMDG, bool MMLEEDCOBFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x54979E0", Offset = "0x54967E0", VA = "0x1854979E0")]
	private static bool BPPHKFCJFHJ(ConstructorInfo MEENCAGCANC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x549B190", Offset = "0x5499F90", VA = "0x18549B190")]
	private static bool KMNMDNJJOLL(Type MAIOHDHBGKE, out Type AKOIHIJDIFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal delegate void HCNKBNMEGJD<T>(byte[][] AAALNIOECAL, object[] EPCBMJCHJAA, ref OPNEEIEIDGM AGODLEOBGCG, T NLHFEJHKLAH, BJKEHJMPEHM BJNEMDJELDJ);
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate T LBIDFDBACDE<T>(object[] EPCBMJCHJAA, ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BJNEMDJELDJ);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class CJBMGJAJEKH<T> : global::LGGFBAFGLIF<T>, GDABCMMFOHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] AAALNIOECAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] ANLKLAKGIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] GADECHMKDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly global::HCNKBNMEGJD<T> EOMLOOPPNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly global::LBIDFDBACDE<T> MALIJIGPIHG;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2F56EB0", Offset = "0x2F55CB0", VA = "0x182F56EB0")]
	public CJBMGJAJEKH(byte[][] AAALNIOECAL, object[] ANLKLAKGIFL, object[] GADECHMKDJB, global::HCNKBNMEGJD<T> EOMLOOPPNMB, global::LBIDFDBACDE<T> MALIJIGPIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x357E1A0", Offset = "0x357CFA0", VA = "0x18357E1A0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, T NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x357E280", Offset = "0x357D080", VA = "0x18357E280", Slot = "5")]
	public T DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class GBHGNIDPAOM : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class NAAFCLJCGPC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2E9AF50", Offset = "0x2E99D50", VA = "0x182E9AF50")]
		static NAAFCLJCGPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private GBHGNIDPAOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class KDKBEIFGLLB : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private static class IDOCFEJGKKN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4940", Offset = "0x2AB3740", VA = "0x182AB4940")]
		static IDOCFEJGKKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private KDKBEIFGLLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal static class BOMFNKFCLKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly BJKEHJMPEHM[] GBLIAKFIIOB;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal sealed class ALNGLJEGFNF : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private static class PBJKMJPPOGI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3890E40", Offset = "0x388FC40", VA = "0x183890E40")]
		static PBJKMJPPOGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private sealed class MFBLAJGOCFA : BJKEHJMPEHM
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		private static class PFCAKCJOBBG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB210", Offset = "0x2ABA010", VA = "0x182ABB210")]
			static PFCAKCJOBBG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly BJKEHJMPEHM PDNDNIMAPDO;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly BJKEHJMPEHM[] LGIKNAKBMHM;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		private MFBLAJGOCFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
		public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly global::LGGFBAFGLIF<object> JPOKEHPBPFG;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private ALNGLJEGFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class OGKIHEFJCAD : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class FKFNDIFBGFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x37CA3F0", Offset = "0x37C91F0", VA = "0x1837CA3F0")]
		static FKFNDIFBGFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class LKDBMNFOMGG : BJKEHJMPEHM
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class CJFFGBHGAAN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x357E4A0", Offset = "0x357D2A0", VA = "0x18357E4A0")]
			static CJFFGBHGAAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly BJKEHJMPEHM PDNDNIMAPDO;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly BJKEHJMPEHM[] LGIKNAKBMHM;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		private LKDBMNFOMGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
		public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly global::LGGFBAFGLIF<object> JPOKEHPBPFG;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private OGKIHEFJCAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class PMNHMDGMJJG : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class BMMKPLCFCGM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2987FE0", Offset = "0x2986DE0", VA = "0x182987FE0")]
		static BMMKPLCFCGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class CACBDJHHALG : BJKEHJMPEHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class MHBJCEELNBH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x35E8500", Offset = "0x35E7300", VA = "0x1835E8500")]
			static MHBJCEELNBH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly BJKEHJMPEHM PDNDNIMAPDO;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly BJKEHJMPEHM[] LGIKNAKBMHM;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		private CACBDJHHALG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
		public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly global::LGGFBAFGLIF<object> JPOKEHPBPFG;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private PMNHMDGMJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class FAPGMOMNMDO : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class KLIGMINHION<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2730060", Offset = "0x272EE60", VA = "0x182730060")]
		static KLIGMINHION()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class PPJODMEDGOL : BJKEHJMPEHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class FBAJBJAKLNM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x3D948D0", Offset = "0x3D936D0", VA = "0x183D948D0")]
			static FBAJBJAKLNM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly BJKEHJMPEHM PDNDNIMAPDO;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly BJKEHJMPEHM[] LGIKNAKBMHM;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		private PPJODMEDGOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
		public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::LGGFBAFGLIF<object> JPOKEHPBPFG;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private FAPGMOMNMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class MLKBAOLJBJP : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class BGNJFAGEADA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x297DA00", Offset = "0x297C800", VA = "0x18297DA00")]
		static BGNJFAGEADA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class EDMBIIEDMKO : BJKEHJMPEHM
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class CCIOFCCFAKN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x356E470", Offset = "0x356D270", VA = "0x18356E470")]
			static CCIOFCCFAKN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly BJKEHJMPEHM PDNDNIMAPDO;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly BJKEHJMPEHM[] LGIKNAKBMHM;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		private EDMBIIEDMKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
		public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly global::LGGFBAFGLIF<object> JPOKEHPBPFG;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private MLKBAOLJBJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class KOPGLJHDKEF : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class ONCABPGBHNI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E4B0", Offset = "0x4D8D2B0", VA = "0x184D8E4B0")]
		static ONCABPGBHNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class CCGDPOJIFPP : BJKEHJMPEHM
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class BBBHEFJEGAN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x30BBF40", Offset = "0x30BAD40", VA = "0x1830BBF40")]
			static BBBHEFJEGAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly BJKEHJMPEHM PDNDNIMAPDO;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly BJKEHJMPEHM[] LGIKNAKBMHM;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		private CCGDPOJIFPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
		public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly global::LGGFBAFGLIF<object> JPOKEHPBPFG;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private KOPGLJHDKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class NKIKBBIGLJC : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class ODKOFLEGNCA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3B3C6F0", Offset = "0x3B3B4F0", VA = "0x183B3C6F0")]
		static ODKOFLEGNCA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class AKGFMOHPDLD : BJKEHJMPEHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class PBKBHCALPHP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3894470", Offset = "0x3893270", VA = "0x183894470")]
			static PBKBHCALPHP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly BJKEHJMPEHM PDNDNIMAPDO;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly BJKEHJMPEHM[] LGIKNAKBMHM;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		private AKGFMOHPDLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
		public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly global::LGGFBAFGLIF<object> JPOKEHPBPFG;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private NKIKBBIGLJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class BGLHKHBNMNF : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class LCHOLGNIOCI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2456760", Offset = "0x2455560", VA = "0x182456760")]
		static LCHOLGNIOCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class LNPBMFOGFIP : BJKEHJMPEHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class IAEEOLDJBNA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2AA3D30", Offset = "0x2AA2B30", VA = "0x182AA3D30")]
			static IAEEOLDJBNA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly BJKEHJMPEHM PDNDNIMAPDO;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly BJKEHJMPEHM[] LGIKNAKBMHM;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		private LNPBMFOGFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
		public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly global::LGGFBAFGLIF<object> JPOKEHPBPFG;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private BGLHKHBNMNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class MGPEMBEHPDF : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class DHNGBGAHFPH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C770", Offset = "0x2B0B570", VA = "0x182B0C770")]
		static DHNGBGAHFPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class KDFEGCHFCEB : BJKEHJMPEHM
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class CLKAMHNJNBH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x3586170", Offset = "0x3584F70", VA = "0x183586170")]
			static CLKAMHNJNBH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly BJKEHJMPEHM PDNDNIMAPDO;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly BJKEHJMPEHM[] LGIKNAKBMHM;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		private KDFEGCHFCEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
		public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly global::LGGFBAFGLIF<object> JPOKEHPBPFG;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private MGPEMBEHPDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class MOPMIMPIJDK : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class IBAHBICPGKN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7720", Offset = "0x2AA6520", VA = "0x182AA7720")]
		static IBAHBICPGKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class CNGPOLDEBKE : BJKEHJMPEHM
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class LJKKCFLAMFL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3186140", Offset = "0x3184F40", VA = "0x183186140")]
			static LJKKCFLAMFL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly BJKEHJMPEHM PDNDNIMAPDO;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly BJKEHJMPEHM[] LGIKNAKBMHM;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		private CNGPOLDEBKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
		public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::LGGFBAFGLIF<object> JPOKEHPBPFG;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private MOPMIMPIJDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class NLOFIEMAKIN : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class HKFMOMOOLOC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2C66EF0", Offset = "0x2C65CF0", VA = "0x182C66EF0")]
		static HKFMOMOOLOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class PDKJAAFIDOL : BJKEHJMPEHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class CFEKNBEGNBJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x3577CA0", Offset = "0x3576AA0", VA = "0x183577CA0")]
			static CFEKNBEGNBJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly BJKEHJMPEHM PDNDNIMAPDO;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly BJKEHJMPEHM[] LGIKNAKBMHM;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		private PDKJAAFIDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
		public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly global::LGGFBAFGLIF<object> JPOKEHPBPFG;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private NLOFIEMAKIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class NDONPBNIJAL : BJKEHJMPEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class HOAJKBNIBEB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C77950", Offset = "0x2C76750", VA = "0x182C77950")]
		static HOAJKBNIBEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class IDNHKCMGCFA : BJKEHJMPEHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class CBMMMHEHAGM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly global::LGGFBAFGLIF<T> KJBFAKDDCOE;

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x35693B0", Offset = "0x35681B0", VA = "0x1835693B0")]
			static CBMMMHEHAGM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly BJKEHJMPEHM PDNDNIMAPDO;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly BJKEHJMPEHM[] LGIKNAKBMHM;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		private IDNHKCMGCFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
		public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly BJKEHJMPEHM PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly global::LGGFBAFGLIF<object> JPOKEHPBPFG;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private NDONPBNIJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x227DA40", Offset = "0x227C840", VA = "0x18227DA40", Slot = "4")]
	public global::LGGFBAFGLIF<T> PIJGGIGIBIK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct IMIDFIPHJMD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] BHCIGANBCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int LACBNDDFFOB;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x25B4F00", Offset = "0x25B3D00", VA = "0x1825B4F00")]
	public IMIDFIPHJMD(int OOBELNNEIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x25B4B90", Offset = "0x25B3990", VA = "0x1825B4B90")]
	public void AHKNMMEAEHA(T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x25B4A30", Offset = "0x25B3830", VA = "0x1825B4A30")]
	public T[] ADDGACCNMHF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
internal sealed class JGIBIJPKEBO : global::JAPHKMFEBMD<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly JGIBIJPKEBO LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5492F40", Offset = "0x5491D40", VA = "0x185492F40")]
	public JGIBIJPKEBO(int AFJBAOBENJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal class JAPHKMFEBMD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int AFJBAOBENJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object GPLLGHLKLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int CPOAAGLEIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] GONEJJDDKGG;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D790", Offset = "0x3B5C590", VA = "0x183B5D790")]
	public JAPHKMFEBMD(int AFJBAOBENJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D1E0", Offset = "0x3B5BFE0", VA = "0x183B5D1E0")]
	public T[] JHBHNDICFHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3B5CCA0", Offset = "0x3B5BAA0", VA = "0x183B5CCA0")]
	public void IHIFHJOFELG(T[] ECEFKNGMHII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class DMKELGAOJPN : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class EIBHBLGPNGA : IComparable<EIBHBLGPNGA>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class OKCMFNDPGOK : IEnumerable<EIBHBLGPNGA>, IEnumerable, IEnumerator<EIBHBLGPNGA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private EIBHBLGPNGA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public EIBHBLGPNGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private EIBHBLGPNGA System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F0")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x793410", Offset = "0x792210", VA = "0x180793410")]
			[DebuggerHidden]
			public OKCMFNDPGOK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x54599F0", Offset = "0x54587F0", VA = "0x1854599F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x5459B20", Offset = "0x5458920", VA = "0x185459B20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x5459A80", Offset = "0x5458880", VA = "0x185459A80", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<EIBHBLGPNGA> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x5459A80", Offset = "0x5458880", VA = "0x185459A80", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class INNCKCJICMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public INNCKCJICMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x800EB0", Offset = "0x7FFCB0", VA = "0x180800EB0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x800EB0", Offset = "0x7FFCB0", VA = "0x180800EB0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly EIBHBLGPNGA[] COFKAEKNIDF;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] DDOCDLPMACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong EGGKJKOHLOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int DKPIGGFDHBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string BIHFJJDAAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private EIBHBLGPNGA[] BBNKOKMPCPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] IJMODODAPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int PHHDFCFDFMP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool NMHEKPKOOAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x544DD60", Offset = "0x544CB60", VA = "0x18544DD60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x544DE00", Offset = "0x544CC00", VA = "0x18544DE00")]
		public EIBHBLGPNGA(ulong ANFHHLAHMJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x544C810", Offset = "0x544B610", VA = "0x18544C810")]
		public EIBHBLGPNGA AHKNMMEAEHA(ulong ANFHHLAHMJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x544C7C0", Offset = "0x544B5C0", VA = "0x18544C7C0")]
		public EIBHBLGPNGA AHKNMMEAEHA(ulong ANFHHLAHMJD, int NLHFEJHKLAH, string BIHFJJDAAOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x544DBB0", Offset = "0x544C9B0", VA = "0x18544DBB0")]
		public EIBHBLGPNGA KHHOALHICCJ(byte[] BDHLMGMJDKP, ref int JBINMJEHBFH, ref int OJLCAKBKBHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x544CB00", Offset = "0x544B900", VA = "0x18544CB00")]
		internal static int GEEKBOGFEMD(ulong[] ECEFKNGMHII, int CPOAAGLEIPE, int LNKONGJEECL, ulong NLHFEJHKLAH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x544CAD0", Offset = "0x544B8D0", VA = "0x18544CAD0", Slot = "4")]
		public int CompareTo(EIBHBLGPNGA ONICAEEHHFG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x544C750", Offset = "0x544B550", VA = "0x18544C750")]
		[IteratorStateMachine(typeof(OKCMFNDPGOK))]
		public IEnumerable<EIBHBLGPNGA> AFKNANGFJCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x544D980", Offset = "0x544C780", VA = "0x18544D980")]
		public void JMIDLBDGCGG(ILGenerator IBIKFHJIHBF, LocalBuilder BDHLMGMJDKP, LocalBuilder OJLCAKBKBHE, LocalBuilder ANFHHLAHMJD, Action<KeyValuePair<string, int>> BAJMNOEIJMM, Action BIHPEPGOICJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x544CB80", Offset = "0x544B980", VA = "0x18544CB80")]
		private static void IAJJKKMMLJI(ILGenerator IBIKFHJIHBF, LocalBuilder BDHLMGMJDKP, LocalBuilder OJLCAKBKBHE, LocalBuilder ANFHHLAHMJD, Action<KeyValuePair<string, int>> BAJMNOEIJMM, Action BIHPEPGOICJ, EIBHBLGPNGA[] BBNKOKMPCPF, int PHHDFCFDFMP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class FDOBGHPHFMP : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<EIBHBLGPNGA> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<EIBHBLGPNGA> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<EIBHBLGPNGA> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private EIBHBLGPNGA <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x779B20", Offset = "0x778920", VA = "0x180779B20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x544E400", Offset = "0x544D200", VA = "0x18544E400", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x795390", Offset = "0x794190", VA = "0x180795390")]
		[DebuggerHidden]
		public FDOBGHPHFMP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x544E450", Offset = "0x544D250", VA = "0x18544E450", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x544DEC0", Offset = "0x544CCC0", VA = "0x18544DEC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x544E530", Offset = "0x544D330", VA = "0x18544E530")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x544E580", Offset = "0x544D380", VA = "0x18544E580")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x544E3C0", Offset = "0x544D1C0", VA = "0x18544E3C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x544E320", Offset = "0x544D120", VA = "0x18544E320", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x544E320", Offset = "0x544D120", VA = "0x18544E320", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly EIBHBLGPNGA DCJJENKGKJB;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4CFBAA0", Offset = "0x4CFA8A0", VA = "0x184CFBAA0")]
	public DMKELGAOJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB450", Offset = "0x4CFA250", VA = "0x184CFB450")]
	public void AHKNMMEAEHA(byte[] NJGGJPEFKKD, int NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB640", Offset = "0x4CFA440", VA = "0x184CFB640")]
	public bool ILCJFEILDNM(ArraySegment<byte> ANFHHLAHMJD, out int NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4CFBA10", Offset = "0x4CFA810", VA = "0x184CFBA10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB770", Offset = "0x4CFA570", VA = "0x184CFB770")]
	private static void KKEDMEBKFGN(IEnumerable<EIBHBLGPNGA> BBNKOKMPCPF, StringBuilder IJOFAPOCGIJ, int ACNLMINHECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB590", Offset = "0x4CFA390", VA = "0x184CFB590", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB590", Offset = "0x4CFA390", VA = "0x184CFB590", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB700", Offset = "0x4CFA500", VA = "0x184CFB700")]
	[IteratorStateMachine(typeof(FDOBGHPHFMP))]
	private static IEnumerable<KeyValuePair<string, int>> JEDAIENDNEE(IEnumerable<EIBHBLGPNGA> BBNKOKMPCPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB560", Offset = "0x4CFA360", VA = "0x184CFB560")]
	public void EKLJKGFEPOF(ILGenerator IBIKFHJIHBF, LocalBuilder BDHLMGMJDKP, LocalBuilder OJLCAKBKBHE, LocalBuilder ANFHHLAHMJD, Action<KeyValuePair<string, int>> BAJMNOEIJMM, Action BIHPEPGOICJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public static class CPDAAABLBGJ
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo FOGFINCHEMK;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4CF8B40", Offset = "0x4CF7940", VA = "0x184CF8B40")]
	public static ulong EPILCIDFPJP(byte[] NJGGJPEFKKD, ref int JBINMJEHBFH, ref int OJLCAKBKBHE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class LPLBKPGOLBH
{
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x54A0870", Offset = "0x549F670", VA = "0x1854A0870")]
	public static void LDNDDAIJFAA(ref byte[] NJGGJPEFKKD, int JBINMJEHBFH, int KPKCDILAMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x54A0640", Offset = "0x549F440", VA = "0x1854A0640")]
	public static void DKENJHJBLAM(ref byte[] ECEFKNGMHII, int CADJHEOGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x54A0750", Offset = "0x549F550", VA = "0x1854A0750")]
	public static byte[] FGLBIGONMEG(byte[] ALDENJHFODN, int CADJHEOGHIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class LIMJOLOJLFN
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x54A03A0", Offset = "0x549F1A0", VA = "0x1854A03A0")]
	public static bool MIHMMJHONAF(byte[] OKAHENAFIAH, int ELFGAGOCAPG, int IGDMGDMBCJD, byte[] BKNFPKDKOAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class AMFBHPAKJGL<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private struct FFNNBCOIHHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] EGGKJKOHLOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T DKPIGGFDHBP;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x37C2640", Offset = "0x37C1440", VA = "0x1837C2640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class FCFJNKAEFDJ : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public global::AMFBHPAKJGL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private FFNNBCOIHHF[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private FFNNBCOIHHF[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x779B20", Offset = "0x778920", VA = "0x180779B20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37B5270", Offset = "0x37B4070", VA = "0x1837B5270", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2300E10", Offset = "0x22FFC10", VA = "0x182300E10")]
		[DebuggerHidden]
		public FCFJNKAEFDJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3D994F0", Offset = "0x3D982F0", VA = "0x183D994F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3D99850", Offset = "0x3D98650", VA = "0x183D99850", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly FFNNBCOIHHF[][] KPDOIOBNMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong FKIMGGNJEEE;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4B5BF10", Offset = "0x4B5AD10", VA = "0x184B5BF10")]
	public AMFBHPAKJGL(int FPMMBKCOHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4B5BF40", Offset = "0x4B5AD40", VA = "0x184B5BF40")]
	public AMFBHPAKJGL(int FPMMBKCOHLA, float MCNGJFGKING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4B4FE60", Offset = "0x4B4EC60", VA = "0x184B4FE60")]
	public void AHKNMMEAEHA(byte[] ANFHHLAHMJD, T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4B58D80", Offset = "0x4B57B80", VA = "0x184B58D80")]
	private bool CJMDOCDNGFH(byte[] ANFHHLAHMJD, T NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x4B54470", Offset = "0x4B53270", VA = "0x184B54470")]
	public bool AMKBCCEHNAL(ArraySegment<byte> ANFHHLAHMJD, out T NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x4B5BEB0", Offset = "0x4B5ACB0", VA = "0x184B5BEB0")]
	private static ulong MIJEMFAFMFF(byte[] PAMKNJCGOGK, int JBINMJEHBFH, int PHHDFCFDFMP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3570", Offset = "0x2DF2370", VA = "0x182DF3570")]
	private static int FKBLACAHFDL(int BAFLDCDBJBE, float MCNGJFGKING)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4B5BC70", Offset = "0x4B5AA70", VA = "0x184B5BC70", Slot = "4")]
	[IteratorStateMachine(typeof(global::AMFBHPAKJGL<>.FCFJNKAEFDJ))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2AACD40", Offset = "0x2AABB40", VA = "0x182AACD40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal class AIEGBOIJBJO : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] MKLHOCAMONO;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] MGNIPOMNFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int BOECMOEDKMI;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool EHFIHAJCLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x4CEF1E0", Offset = "0x4CEDFE0", VA = "0x184CEF1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF230", Offset = "0x4CEE030", VA = "0x184CEF230")]
	static AIEGBOIJBJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF4B0", Offset = "0x4CEE2B0", VA = "0x184CEF4B0")]
	public AIEGBOIJBJO(byte[] MPMNGGJNGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF0C0", Offset = "0x4CEDEC0", VA = "0x184CEF0C0")]
	public OpCode DJNIGHDMNLJ()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal struct HJNCKOBIFHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid DKPIGGFDHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte AKDCCNMOEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte EOCEOCFOPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte JOKFMJHPGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte FJODOGLFHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte OFBJANCGLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte MHLMILNBGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte FCNKNMFKKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte LGNCDIMDHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte AMBLOFADBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte GELLEINHBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte LLFANPBCGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte ACEGKNLAFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte KKGPPHMHPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte NGJGBPDFIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte DIAICMILHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte AFLECACNLBN;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] NKIHHGGHKLH;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] ACGNHCNFEBA;

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x548DA10", Offset = "0x548C810", VA = "0x18548DA10")]
	public HJNCKOBIFHN(ref Guid NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x548DA20", Offset = "0x548C820", VA = "0x18548DA20")]
	public HJNCKOBIFHN(ref ArraySegment<byte> LHDPLFCMFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x548D880", Offset = "0x548C680", VA = "0x18548D880")]
	private static byte NBILMGBHHII(byte[] NJGGJPEFKKD, int BEENGNCBMFM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x548D770", Offset = "0x548C570", VA = "0x18548D770")]
	private static byte KHNICILKKJK(byte MIECAKFJHNF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x548C420", Offset = "0x548B220", VA = "0x18548C420")]
	public void EMPHHNJGCIE(byte[] IHLLHGOCNMO, int JBINMJEHBFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class MABAEGEBEDG
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x54A0BB0", Offset = "0x549F9B0", VA = "0x1854A0BB0")]
	public static bool ALEGEIIAHKO(byte BPJNCMDPHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x54A1520", Offset = "0x54A0320", VA = "0x1854A1520")]
	public static bool GDCOAECPBJH(byte BPJNCMDPHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x54A1600", Offset = "0x54A0400", VA = "0x1854A1600")]
	public static sbyte KCEBDABIPGH(byte[] NJGGJPEFKKD, int JBINMJEHBFH, out int DEHMHKLPEPG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x54A2510", Offset = "0x54A1310", VA = "0x1854A2510")]
	public static short NLMOCLOCPLG(byte[] NJGGJPEFKKD, int JBINMJEHBFH, out int DEHMHKLPEPG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x54A14B0", Offset = "0x54A02B0", VA = "0x1854A14B0")]
	public static int CNCLKIGLFKM(byte[] NJGGJPEFKKD, int JBINMJEHBFH, out int DEHMHKLPEPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x54A1400", Offset = "0x54A0200", VA = "0x1854A1400")]
	public static long CIKJPMENBKA(byte[] NJGGJPEFKKD, int JBINMJEHBFH, out int DEHMHKLPEPG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x54A09B0", Offset = "0x549F7B0", VA = "0x1854A09B0")]
	public static byte AACJMLNIFCG(byte[] NJGGJPEFKKD, int JBINMJEHBFH, out int DEHMHKLPEPG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x54A2580", Offset = "0x54A1380", VA = "0x1854A2580")]
	public static ushort PAPIAKLGDCO(byte[] NJGGJPEFKKD, int JBINMJEHBFH, out int DEHMHKLPEPG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x54A0B30", Offset = "0x549F930", VA = "0x1854A0B30")]
	public static uint AGHKCFELLDK(byte[] NJGGJPEFKKD, int JBINMJEHBFH, out int DEHMHKLPEPG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x54A0A20", Offset = "0x549F820", VA = "0x1854A0A20")]
	public static ulong AAMMBECMMIC(byte[] NJGGJPEFKKD, int JBINMJEHBFH, out int DEHMHKLPEPG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x54A1390", Offset = "0x54A0190", VA = "0x1854A1390")]
	public static float BFPGEOPKNMF(byte[] NJGGJPEFKKD, int JBINMJEHBFH, out int DEHMHKLPEPG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x54A1590", Offset = "0x54A0390", VA = "0x1854A1590")]
	public static double JAPJHIFJDDB(byte[] NJGGJPEFKKD, int JBINMJEHBFH, out int DEHMHKLPEPG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x54A0BC0", Offset = "0x549F9C0", VA = "0x1854A0BC0")]
	public static int APFODKPFJMN(ref byte[] IHLLHGOCNMO, int JBINMJEHBFH, ulong NLHFEJHKLAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x54A1670", Offset = "0x54A0470", VA = "0x1854A1670")]
	public static int MEPCNILJKNM(ref byte[] IHLLHGOCNMO, int JBINMJEHBFH, long NLHFEJHKLAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x54A22A0", Offset = "0x54A10A0", VA = "0x1854A22A0")]
	public static bool MHHDJHLDGED(byte[] NJGGJPEFKKD, int JBINMJEHBFH, out int DEHMHKLPEPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class OPNBKNPOIGK
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class JJJHBFGJIIK : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x793410", Offset = "0x792210", VA = "0x180793410")]
		[DebuggerHidden]
		public JJJHBFGJIIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5453A50", Offset = "0x5452850", VA = "0x185453A50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x54535F0", Offset = "0x54523F0", VA = "0x1854535F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5453B40", Offset = "0x5452940", VA = "0x185453B40")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5453B90", Offset = "0x5452990", VA = "0x185453B90")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5453A10", Offset = "0x5452810", VA = "0x185453A10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5453960", Offset = "0x5452760", VA = "0x185453960", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5453960", Offset = "0x5452760", VA = "0x185453960", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class MHFOKEPKDIL : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x793410", Offset = "0x792210", VA = "0x180793410")]
		[DebuggerHidden]
		public MHFOKEPKDIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5458350", Offset = "0x5457150", VA = "0x185458350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x5457EF0", Offset = "0x5456CF0", VA = "0x185457EF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x5458440", Offset = "0x5457240", VA = "0x185458440")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5458490", Offset = "0x5457290", VA = "0x185458490")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5458310", Offset = "0x5457110", VA = "0x185458310", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5458260", Offset = "0x5457060", VA = "0x185458260", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5458260", Offset = "0x5457060", VA = "0x185458260", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x545A030", Offset = "0x5458E30", VA = "0x18545A030")]
	public static bool PCNPEHMFJAP(this TypeInfo MAIOHDHBGKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5459E30", Offset = "0x5458C30", VA = "0x185459E30")]
	public static bool FHMOGECEDGM(this TypeInfo MAIOHDHBGKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x5459FC0", Offset = "0x5458DC0", VA = "0x185459FC0")]
	public static IEnumerable<PropertyInfo> HAELFEPCOMN(this Type MAIOHDHBGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x5459DA0", Offset = "0x5458BA0", VA = "0x185459DA0")]
	[IteratorStateMachine(typeof(JJJHBFGJIIK))]
	private static IEnumerable<PropertyInfo> CNAEPADBDHB(Type MAIOHDHBGKE, HashSet<string> BLGDKPNIAKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x5459F50", Offset = "0x5458D50", VA = "0x185459F50")]
	public static IEnumerable<FieldInfo> FLGABONBNJO(this Type MAIOHDHBGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x5459D10", Offset = "0x5458B10", VA = "0x185459D10")]
	[IteratorStateMachine(typeof(MHFOKEPKDIL))]
	private static IEnumerable<FieldInfo> CEKGIEFHMMG(Type MAIOHDHBGKE, HashSet<string> BLGDKPNIAKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal static class BLPKNGJJLBK
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding PBDOCGGAKEC;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class IDHLPKOOLOH
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x73C0B0", Offset = "0x73AEB0", VA = "0x18073C0B0")]
	public static string MPBOKJMHGHP(string EOOBLLJHFPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5490180", Offset = "0x548EF80", VA = "0x185490180")]
	public static string HCOBNAMFLBB(string EOOBLLJHFPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5490290", Offset = "0x548F090", VA = "0x185490290")]
	public static string LFKCNFAJPEN(string EOOBLLJHFPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class GADAHHOBMOO<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class DKMAMDJPNAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type EGGKJKOHLOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue DKPIGGFDHBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int MONDDLOINEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public DKMAMDJPNAL PBBMJFDJIAB;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2B16820", Offset = "0x2B15620", VA = "0x182B16820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2B167E0", Offset = "0x2B155E0", VA = "0x182B167E0")]
		private int OAHKGMMAIIG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public DKMAMDJPNAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class NIACOOGJALE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public NIACOOGJALE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x73BC90", Offset = "0x73AA90", VA = "0x18073BC90")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private DKMAMDJPNAL[] KPDOIOBNMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int MBCLCCPKDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object OKEBNBCDBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float MCNGJFGKING;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3F70", Offset = "0x2DF2D70", VA = "0x182DF3F70")]
	public GADAHHOBMOO(int FPMMBKCOHLA = 4, float MCNGJFGKING = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3420", Offset = "0x2DF2220", VA = "0x182DF3420")]
	public bool COOLJMALOJN(Type ANFHHLAHMJD, TValue NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3530", Offset = "0x2DF2330", VA = "0x182DF3530")]
	public bool COOLJMALOJN(Type ANFHHLAHMJD, Func<Type, TValue> OOLFKENKLBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3000", Offset = "0x2DF1E00", VA = "0x182DF3000")]
	private bool CJMDOCDNGFH(Type ANFHHLAHMJD, Func<Type, TValue> OOLFKENKLBP, out TValue INCJMEGJNKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x2DF35A0", Offset = "0x2DF23A0", VA = "0x182DF35A0")]
	private bool HFNAHLFCNML(DKMAMDJPNAL[] KPDOIOBNMML, Type IFLFGIOBOFL, DKMAMDJPNAL AOEAKGEDFPJ, Func<Type, TValue> OOLFKENKLBP, out TValue INCJMEGJNKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2A90", Offset = "0x2DF1890", VA = "0x182DF2A90")]
	public bool AMKBCCEHNAL(Type ANFHHLAHMJD, out TValue NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3DD0", Offset = "0x2DF2BD0", VA = "0x182DF3DD0")]
	public TValue MGMLNFFFDMH(Type ANFHHLAHMJD, Func<Type, TValue> OOLFKENKLBP)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3570", Offset = "0x2DF2370", VA = "0x182DF3570")]
	private static int FKBLACAHFDL(int BAFLDCDBJBE, float MCNGJFGKING)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3D00", Offset = "0x2DF2B00", VA = "0x182DF3D00")]
	private static void KAICHBLJCEJ(ref DKMAMDJPNAL GCFNAKFCHDD, DKMAMDJPNAL NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3D00", Offset = "0x2DF2B00", VA = "0x182DF3D00")]
	private static void KAICHBLJCEJ(ref DKMAMDJPNAL[] GCFNAKFCHDD, DKMAMDJPNAL[] NLHFEJHKLAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class FJEEGGPOFAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder ELCMHPHJLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder ALNKOOPPCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object GPLLGHLKLEF;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x4D00350", Offset = "0x4CFF150", VA = "0x184D00350")]
	public TypeBuilder OCJMCLAECBH(string EOPECGOILOC, TypeAttributes DNKHNKLDJJB, Type AABHIBJPKOH, Type[] NCPOFHLABJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x4D00420", Offset = "0x4CFF220", VA = "0x184D00420")]
	public FJEEGGPOFAJ(string BBIBBABLAKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal static class NNPFKHKFNFI
{
	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x54597C0", Offset = "0x54585C0", VA = "0x1854597C0")]
	private static MethodInfo GGKIEIDJLKE(LambdaExpression GDEIMFAHMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x315C6B0", Offset = "0x315B4B0", VA = "0x18315C6B0")]
	public static MethodInfo FPMMJIGEKJL<T>(Expression<Func<T>> GDEIMFAHMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x315C6B0", Offset = "0x315B4B0", VA = "0x18315C6B0")]
	public static MethodInfo FPMMJIGEKJL<T, TR>(Expression<Func<T, TR>> GDEIMFAHMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x315C6B0", Offset = "0x315B4B0", VA = "0x18315C6B0")]
	public static MethodInfo FPMMJIGEKJL<T>(Expression<Action<T>> GDEIMFAHMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x315C6B0", Offset = "0x315B4B0", VA = "0x18315C6B0")]
	public static MethodInfo FPMMJIGEKJL<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> GDEIMFAHMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x315C600", Offset = "0x315B400", VA = "0x18315C600")]
	private static MemberInfo DLNHJKDFADJ<T>(Expression<T> HOKEJKCPCMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x315C5A0", Offset = "0x315B3A0", VA = "0x18315C5A0")]
	public static PropertyInfo AMCBCGIMICP<T, TR>(Expression<Func<T, TR>> GDEIMFAHMGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct MHOCPPDBEFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int MHNCIMAMLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool LBPEGMBPMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator IBIKFHJIHBF;

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x5458690", Offset = "0x5457490", VA = "0x185458690")]
	public MHOCPPDBEFJ(ILGenerator IBIKFHJIHBF, int MHNCIMAMLJL, bool LBPEGMBPMIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x5458600", Offset = "0x5457400", VA = "0x185458600")]
	public MHOCPPDBEFJ(ILGenerator IBIKFHJIHBF, int MHNCIMAMLJL, Type MAIOHDHBGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x54584E0", Offset = "0x54572E0", VA = "0x1854584E0")]
	public void NMCJGBBKNFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class PMDCKAPACGM
{
	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x545E040", Offset = "0x545CE40", VA = "0x18545E040")]
	public static void BIHJDMGPGJD(this ILGenerator IBIKFHJIHBF, int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x545E270", Offset = "0x545D070", VA = "0x18545E270")]
	public static void BIHJDMGPGJD(this ILGenerator IBIKFHJIHBF, LocalBuilder DBPPHNBLMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x545E620", Offset = "0x545D420", VA = "0x18545E620")]
	public static void KLENOEBFKLP(this ILGenerator IBIKFHJIHBF, int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x545E5E0", Offset = "0x545D3E0", VA = "0x18545E5E0")]
	public static void KLENOEBFKLP(this ILGenerator IBIKFHJIHBF, LocalBuilder DBPPHNBLMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x545DF50", Offset = "0x545CD50", VA = "0x18545DF50")]
	public static void BEEFBHPEFBL(this ILGenerator IBIKFHJIHBF, int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x545DE40", Offset = "0x545CC40", VA = "0x18545DE40")]
	public static void BEEFBHPEFBL(this ILGenerator IBIKFHJIHBF, LocalBuilder DBPPHNBLMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x545E5D0", Offset = "0x545D3D0", VA = "0x18545E5D0")]
	public static void JPCCJDNAAKF(this ILGenerator IBIKFHJIHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x545F050", Offset = "0x545DE50", VA = "0x18545F050")]
	public static void OFPJIEKGPEP(this ILGenerator IBIKFHJIHBF, bool NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x545E9D0", Offset = "0x545D7D0", VA = "0x18545E9D0")]
	public static void NHJLIBCANEK(this ILGenerator IBIKFHJIHBF, int NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x545E340", Offset = "0x545D140", VA = "0x18545E340")]
	public static void GJEEGLLLECB(this ILGenerator IBIKFHJIHBF, Type MAIOHDHBGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x545E430", Offset = "0x545D230", VA = "0x18545E430")]
	public static void GPGABFDCFPD(this ILGenerator IBIKFHJIHBF, Type MAIOHDHBGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x545EE20", Offset = "0x545DC20", VA = "0x18545EE20")]
	public static void NOHNFGAAKNE(this ILGenerator IBIKFHJIHBF, int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x545E950", Offset = "0x545D750", VA = "0x18545E950")]
	public static void MGILAKDPKMH(this ILGenerator IBIKFHJIHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x545E4E0", Offset = "0x545D2E0", VA = "0x18545E4E0")]
	public static void HLIDEHMODKP(this ILGenerator IBIKFHJIHBF, int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x545E850", Offset = "0x545D650", VA = "0x18545E850")]
	public static void LEENNOEECJG(this ILGenerator IBIKFHJIHBF, MethodInfo BHICEKNAPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x545E2B0", Offset = "0x545D0B0", VA = "0x18545E2B0")]
	public static void EENICNOLIHC(this ILGenerator IBIKFHJIHBF, FieldInfo MALEKMCEHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x545F060", Offset = "0x545DE60", VA = "0x18545F060")]
	public static void OIBBJHGLGBA(this ILGenerator IBIKFHJIHBF, ulong NLHFEJHKLAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class HHFDDCDEAAA
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class LBMMCCDJFBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public LBMMCCDJFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5455CE0", Offset = "0x5454AE0", VA = "0x185455CE0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo GEOALJBCHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo NBCBBLNGLPA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string LMPHGOGJNDD
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F10", Offset = "0x6F6D10", VA = "0x1806F7F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string BLDGOHENNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x701A00", Offset = "0x700800", VA = "0x180701A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ADAIPCAPCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x548C010", Offset = "0x548AE10", VA = "0x18548C010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ADPPHPMMLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7F1340", Offset = "0x7F0140", VA = "0x1807F1340")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x934750", Offset = "0x933550", VA = "0x180934750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JGMFPAEBIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7F1350", Offset = "0x7F0150", VA = "0x1807F1350")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x9AD720", Offset = "0x9AC520", VA = "0x1809AD720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type DKNGEPPLFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x763F00", VA = "0x180765100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo GGPJPKFFKJP
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x763EF0", VA = "0x1807650F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo JKEFKEIENOH
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E70", Offset = "0x6F5C70", VA = "0x1806F6E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7830", Offset = "0x6F6630", VA = "0x1806F7830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo MEOOMHJMLOG
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6FA150", Offset = "0x6F8F50", VA = "0x1806FA150")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3E0", Offset = "0x6F91E0", VA = "0x1806FA3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x548C3A0", Offset = "0x548B1A0", VA = "0x18548C3A0")]
	protected HHFDDCDEAAA(Type MAIOHDHBGKE, string EOPECGOILOC, string FJKILFKOOBJ, bool CLMJPMNPAEG, bool FEPKBOHFNHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x548C0E0", Offset = "0x548AEE0", VA = "0x18548C0E0")]
	public HHFDDCDEAAA(FieldInfo DNOEJKEOKKF, string EOPECGOILOC, bool FLFCHEMEABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x548C1F0", Offset = "0x548AFF0", VA = "0x18548C1F0")]
	public HHFDDCDEAAA(PropertyInfo DNOEJKEOKKF, string EOPECGOILOC, bool FLFCHEMEABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x548BDE0", Offset = "0x548ABE0", VA = "0x18548BDE0")]
	private static MethodInfo ABOFBGGHFOH(MemberInfo DNOEJKEOKKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x2701220", Offset = "0x2700020", VA = "0x182701220")]
	public T GFGHCLCMFJN<T>(bool GJCOPNEJOEL) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x548BF50", Offset = "0x548AD50", VA = "0x18548BF50", Slot = "4")]
	public virtual void DIAHIECHONK(ILGenerator IBIKFHJIHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x548C020", Offset = "0x548AE20", VA = "0x18548C020", Slot = "5")]
	public virtual void LJALKKJNOCG(ILGenerator IBIKFHJIHBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class EPJKJHHGFNG : HHFDDCDEAAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string PIELBOHNACG;

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x4CFFDE0", Offset = "0x4CFEBE0", VA = "0x184CFFDE0")]
	public EPJKJHHGFNG(string EOPECGOILOC, string PIELBOHNACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x4CFFCE0", Offset = "0x4CFEAE0", VA = "0x184CFFCE0", Slot = "4")]
	public override void DIAHIECHONK(ILGenerator IBIKFHJIHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x4CFFDA0", Offset = "0x4CFEBA0", VA = "0x184CFFDA0", Slot = "5")]
	public override void LJALKKJNOCG(ILGenerator IBIKFHJIHBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class GMMJDBDGOAE : HHFDDCDEAAA
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo MHKEMOCOHNP;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo GLKJLPILCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal MHOCPPDBEFJ PDEIMJNNOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal MHOCPPDBEFJ HFDNBHAKNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal MHOCPPDBEFJ HKMLEKJDFNB;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x4D03870", Offset = "0x4D02670", VA = "0x184D03870")]
	public GMMJDBDGOAE(string EOPECGOILOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x4D030F0", Offset = "0x4D01EF0", VA = "0x184D030F0", Slot = "4")]
	public override void DIAHIECHONK(ILGenerator IBIKFHJIHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x4D032E0", Offset = "0x4D020E0", VA = "0x184D032E0", Slot = "5")]
	public override void LJALKKJNOCG(ILGenerator IBIKFHJIHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x4D031C0", Offset = "0x4D01FC0", VA = "0x184D031C0")]
	public void DPFNJINPBEB(ILGenerator IBIKFHJIHBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class LBENAAOKFDK
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type DKNGEPPLFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F10", Offset = "0x6F6D10", VA = "0x1806F7F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NNJBPHGLOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A230", VA = "0x18076B430")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7D2430", Offset = "0x7D1230", VA = "0x1807D2430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool PJNIPCDNDDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x87B090", Offset = "0x879E90", VA = "0x18087B090")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x87B0A0", Offset = "0x879EA0", VA = "0x18087B0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo HBAPILCHBEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x71C2B0", Offset = "0x71B0B0", VA = "0x18071C2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public HHFDDCDEAAA[] JAMAILEPHBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x763F00", VA = "0x180765100")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public HHFDDCDEAAA[] NCOGHNMAGOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x763EF0", VA = "0x1807650F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x549EB10", Offset = "0x549D910", VA = "0x18549EB10")]
	public LBENAAOKFDK(Type MAIOHDHBGKE, Func<string, string> LLENMHHIMBM, bool FLFCHEMEABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x549EA20", Offset = "0x549D820", VA = "0x18549EA20")]
	private static bool MBANFGLDGMH(IEnumerator<ConstructorInfo> OCHCDHLHKAE, ref ConstructorInfo NDKALNJPFIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct GBFKGBEEJMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong JCCNICLOFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int ABJFFBJEJDK;

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x244D3A0", Offset = "0x244C1A0", VA = "0x18244D3A0")]
	public GBFKGBEEJMM(ulong MALBHGPFFGF, int HLFEMIFMCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x4D029A0", Offset = "0x4D017A0", VA = "0x184D029A0")]
	public void PFCKIFLDGKC(ref GBFKGBEEJMM ONICAEEHHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x4D02900", Offset = "0x4D01700", VA = "0x184D02900")]
	public static GBFKGBEEJMM MBOPDFFHIDL(ref GBFKGBEEJMM FEIPFLDEPBD, ref GBFKGBEEJMM MIECAKFJHNF)
	{
		return default(GBFKGBEEJMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x4D02910", Offset = "0x4D01710", VA = "0x184D02910")]
	public void OPBCMDNGBMP(ref GBFKGBEEJMM ONICAEEHHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x4D027D0", Offset = "0x4D015D0", VA = "0x184D027D0")]
	public static GBFKGBEEJMM DHCLIEEHLCO(ref GBFKGBEEJMM FEIPFLDEPBD, ref GBFKGBEEJMM MIECAKFJHNF)
	{
		return default(GBFKGBEEJMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4D028C0", Offset = "0x4D016C0", VA = "0x184D028C0")]
	public void HFAKJJPJLOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x4D02870", Offset = "0x4D01670", VA = "0x184D02870")]
	public static GBFKGBEEJMM HFAKJJPJLOB(ref GBFKGBEEJMM FEIPFLDEPBD)
	{
		return default(GBFKGBEEJMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct BMBGOFAMBDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] IHLLHGOCNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int JBINMJEHBFH;

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0xBA2B50", Offset = "0xBA1950", VA = "0x180BA2B50")]
	public BMBGOFAMBDC(byte[] IHLLHGOCNMO, int CBAKPHLPCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x4CF6460", Offset = "0x4CF5260", VA = "0x184CF6460")]
	public void OEFJBJEPJKB(byte HAGBHFAOFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x4CF60F0", Offset = "0x4CF4EF0", VA = "0x184CF60F0")]
	public void CEOONCKJCHD(byte[] HAGBHFAOFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4CF63C0", Offset = "0x4CF51C0", VA = "0x184CF63C0")]
	public void KDAFBMINMIC(byte[] HAGBHFAOFIH, int LNKONGJEECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x4CF6310", Offset = "0x4CF5110", VA = "0x184CF6310")]
	public void KDAFBMINMIC(byte[] HAGBHFAOFIH, int HJHFBPCCKIM, int LNKONGJEECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4CF6190", Offset = "0x4CF4F90", VA = "0x184CF6190")]
	public void ENMKBNBJAPC(byte BPJNCMDPHOE, int PHHDFCFDFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4CF6210", Offset = "0x4CF5010", VA = "0x184CF6210")]
	public void GNCJICCIFDH(string HAGBHFAOFIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class GPJNOBEOGBI
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private enum KAMBNDFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum AGECIKCEGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum FGHBFJFBGDF
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
	private static byte[] OHKNELNJADN;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] IFAGPBHPIBD;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] NMGHMABCGNO;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] AKEKMNFHNDH;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly FGHBFJFBGDF EFHDDOFJPLF;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char IMJEHIBMCBG;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int FHKDPHCCDOO;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int IFGKCEFNDGK;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] JCJDCKLAEGD;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D059B0", Offset = "0x4D047B0", VA = "0x184D059B0")]
	private static byte[] JOGJOPIIENC(int MBCLCCPKDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x4D06130", Offset = "0x4D04F30", VA = "0x184D06130")]
	private static byte[] NKFBAFJOIBL(int MBCLCCPKDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x4D047A0", Offset = "0x4D035A0", VA = "0x184D047A0")]
	public static int COMCMIEIKGH(ref byte[] IHLLHGOCNMO, int JBINMJEHBFH, float NLHFEJHKLAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x4D048C0", Offset = "0x4D036C0", VA = "0x184D048C0")]
	public static int COMCMIEIKGH(ref byte[] IHLLHGOCNMO, int JBINMJEHBFH, double NLHFEJHKLAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x4D05A90", Offset = "0x4D04890", VA = "0x184D05A90")]
	private static bool JPMAAAGIHCO(byte[] IHLLHGOCNMO, int LNKONGJEECL, ulong KOKEDBACIML, ulong KEEKPOCNMFM, ulong OJLCAKBKBHE, ulong PGDKADFMEPO, ulong LHDEJPBHGJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x4D06010", Offset = "0x4D04E10", VA = "0x184D06010")]
	private static void MNICHCHMLGF(uint ANDNDNEDHDE, int GAMFIAIJCGJ, out uint MADDMJDBPJF, out int JIDHABEFGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x4D05020", Offset = "0x4D03E20", VA = "0x184D05020")]
	private static bool FEIHGIMBOLJ(GBFKGBEEJMM EEGELCJODJM, GBFKGBEEJMM NBNGFNKGOEK, GBFKGBEEJMM EIJJHDEAENI, byte[] IHLLHGOCNMO, out int LNKONGJEECL, out int NFDDBHHKHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x4D05B90", Offset = "0x4D04990", VA = "0x184D05B90")]
	private static bool MCKHHGABDCF(double PALFKPAOLKL, KAMBNDFDFJH FOMLKLNHMAJ, byte[] IHLLHGOCNMO, out int LNKONGJEECL, out int NAMFPKKNABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x4D06210", Offset = "0x4D05010", VA = "0x184D06210")]
	private static bool OOCOKAODANL(double PALFKPAOLKL, KAMBNDFDFJH FOMLKLNHMAJ, byte[] IHLLHGOCNMO, out int LNKONGJEECL, out int CMLPPPFHPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x4D06320", Offset = "0x4D05120", VA = "0x184D06320")]
	private static bool PBGJONIHEIH(double NLHFEJHKLAH, ref BMBGOFAMBDC PEPKFHJPBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x4D049E0", Offset = "0x4D037E0", VA = "0x184D049E0")]
	private static bool DLIBGKLNKBA(double NLHFEJHKLAH, ref BMBGOFAMBDC PEPKFHJPBKF, AGECIKCEGDJ FOMLKLNHMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x4D054E0", Offset = "0x4D042E0", VA = "0x184D054E0")]
	private static void IKICNFDBAEH(byte[] HIECJPLJAPG, int LNKONGJEECL, int CMLPPPFHPDM, int JLDLDIMAPIB, ref BMBGOFAMBDC PEPKFHJPBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x4D04270", Offset = "0x4D03070", VA = "0x184D04270")]
	private static void BLOMAKCHGHE(byte[] HIECJPLJAPG, int LNKONGJEECL, int HLFEMIFMCPL, ref BMBGOFAMBDC PEPKFHJPBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4D040E0", Offset = "0x4D02EE0", VA = "0x184D040E0")]
	private static bool AADDBLADCNM(double PALFKPAOLKL, AGECIKCEGDJ FOMLKLNHMAJ, int DPEPANKMEMH, byte[] BJBEIHNMPFF, out bool NOBHOLEABJE, out int LNKONGJEECL, out int LKPMINMHIIB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal struct OAOOENHJPKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double IJADEPADDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong NFOFGOIGKJD;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct NFFCKPBDPLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float JCCNICLOFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint OKEBJBPHBIE;
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct HCJLOCJFPLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong EIDNCBKONOJ;

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x1168D70", Offset = "0x1167B70", VA = "0x181168D70")]
	public HCJLOCJFPLE(double IJADEPADDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4D072E0", Offset = "0x4D060E0", VA = "0x184D072E0")]
	public HCJLOCJFPLE(GBFKGBEEJMM IJADEPADDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4D070D0", Offset = "0x4D05ED0", VA = "0x184D070D0")]
	public GBFKGBEEJMM LOEDEHKMCOJ()
	{
		return default(GBFKGBEEJMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4D07250", Offset = "0x4D06050", VA = "0x184D07250")]
	public GBFKGBEEJMM POIGCIACGIM()
	{
		return default(GBFKGBEEJMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E30", Offset = "0x6F6C30", VA = "0x1806F7E30")]
	public ulong PCNIODOFFEL()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4D06DC0", Offset = "0x4D05BC0", VA = "0x184D06DC0")]
	public double DIMPFMEACPO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4D07020", Offset = "0x4D05E20", VA = "0x184D07020")]
	public double JCAMDJLMLGF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4D07220", Offset = "0x4D06020", VA = "0x184D07220")]
	public int PIBDOGADCOP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x4D06FA0", Offset = "0x4D05DA0", VA = "0x184D06FA0")]
	public ulong HIKEMPCJNCK()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D070B0", Offset = "0x4D05EB0", VA = "0x184D070B0")]
	public bool LIDBNNKGDID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D07000", Offset = "0x4D05E00", VA = "0x184D07000")]
	public bool HLHEONFDMGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4D06D10", Offset = "0x4D05B10", VA = "0x184D06D10")]
	public bool BCHOKPIIDDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x4D06FD0", Offset = "0x4D05DD0", VA = "0x184D06FD0")]
	public bool HJEEIDHKDFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x4D07150", Offset = "0x4D05F50", VA = "0x184D07150")]
	public int LPIIJJJOPGN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4D06E50", Offset = "0x4D05C50", VA = "0x184D06E50")]
	public void DJONKNJOHJO(out GBFKGBEEJMM CCBKAOAIIPI, out GBFKGBEEJMM DECIJMFFPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x4D06D50", Offset = "0x4D05B50", VA = "0x184D06D50")]
	public bool CHGLBJDIPJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x4D07210", Offset = "0x4D06010", VA = "0x184D07210")]
	public double NLHFEJHKLAH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x4D06DA0", Offset = "0x4D05BA0", VA = "0x184D06DA0")]
	public static int COJLFKILLHN(int JJGGEMMMIDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4D06D40", Offset = "0x4D05B40", VA = "0x184D06D40")]
	public static double BCNIHIPIJLJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x4D07170", Offset = "0x4D05F70", VA = "0x184D07170")]
	public static ulong NKAHGGNFFGB(GBFKGBEEJMM HLHPBLNLFOK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct AGILJEFNHFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint EOEMAFKCLEI;

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x714930", Offset = "0x713730", VA = "0x180714930")]
	public AGILJEFNHFM(float JCCNICLOFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF040", Offset = "0x4CEDE40", VA = "0x184CEF040")]
	public GBFKGBEEJMM LOEDEHKMCOJ()
	{
		return default(GBFKGBEEJMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x73BCB0", Offset = "0x73AAB0", VA = "0x18073BCB0")]
	public uint AFIBOJMFCNL()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF0A0", Offset = "0x4CEDEA0", VA = "0x184CEF0A0")]
	public int PIBDOGADCOP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF010", Offset = "0x4CEDE10", VA = "0x184CEF010")]
	public uint HIKEMPCJNCK()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF030", Offset = "0x4CEDE30", VA = "0x184CEF030")]
	public bool LIDBNNKGDID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x4CEEEE0", Offset = "0x4CEDCE0", VA = "0x184CEEEE0")]
	public void DJONKNJOHJO(out GBFKGBEEJMM CCBKAOAIIPI, out GBFKGBEEJMM DECIJMFFPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4CEEEA0", Offset = "0x4CEDCA0", VA = "0x184CEEEA0")]
	public bool CHGLBJDIPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct GGJLGCHNIHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong MALBHGPFFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short JAPNMNCLCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short NAMFPKKNABO;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x4D02AB0", Offset = "0x4D018B0", VA = "0x184D02AB0")]
	public GGJLGCHNIHG(ulong MALBHGPFFGF, short JAPNMNCLCLL, short NAMFPKKNABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal static class BJDJDAPGBBL
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly GGJLGCHNIHG[] IIOCGNMDCLN;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x4CF48D0", Offset = "0x4CF36D0", VA = "0x184CF48D0")]
	public static void BBLEDHDAGLP(int LOLBGPHNAJP, int DNDJKIPMIGC, out GBFKGBEEJMM MADDMJDBPJF, out int NAMFPKKNABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4CF4A00", Offset = "0x4CF3800", VA = "0x184CF4A00")]
	public static void MBGKHBCHJIK(int MKDPDDBFJHJ, out GBFKGBEEJMM MADDMJDBPJF, out int MEFHLNGLNEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[DefaultMember("Item")]
internal struct GBKKEJLEPGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] NJGGJPEFKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int HJHFBPCCKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int EAANCCHAADB;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x4D02A10", Offset = "0x4D01810", VA = "0x184D02A10")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0xA47E50", Offset = "0xA46C50", VA = "0x180A47E50")]
	public GBKKEJLEPGB(byte[] NJGGJPEFKKD, int HJHFBPCCKIM, int LNKONGJEECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x73BCC0", Offset = "0x73AAC0", VA = "0x18073BCC0")]
	public int LNKONGJEECL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x4D02A50", Offset = "0x4D01850", VA = "0x184D02A50")]
	public GBKKEJLEPGB DECMDLAIPKH(int ILLPDGGOCDH, int GCOJDPEAAEE)
	{
		return default(GBKKEJLEPGB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class FOIAGPCKPHF
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] EMJLLAJLMOC;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] MAEJKCHFKKM;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int DOPIIIGOELM;

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x4D01C70", Offset = "0x4D00A70", VA = "0x184D01C70")]
	private static byte[] NPJOHEOMLBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4D01B90", Offset = "0x4D00990", VA = "0x184D01B90")]
	private static GBKKEJLEPGB NECEONFNOHK(GBKKEJLEPGB IHLLHGOCNMO)
	{
		return default(GBKKEJLEPGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x4D017B0", Offset = "0x4D005B0", VA = "0x184D017B0")]
	private static GBKKEJLEPGB LBNGIDJHNAP(GBKKEJLEPGB IHLLHGOCNMO)
	{
		return default(GBKKEJLEPGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4D01D60", Offset = "0x4D00B60", VA = "0x184D01D60")]
	private static void PMELCALCBDJ(GBKKEJLEPGB IHLLHGOCNMO, int HLFEMIFMCPL, byte[] FDMLGKBEKJA, out int IPGEOAKHNGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4D012E0", Offset = "0x4D000E0", VA = "0x184D012E0")]
	private static void HEEGCNOKBCG(GBKKEJLEPGB IHLLHGOCNMO, int HLFEMIFMCPL, byte[] PPKCEEAFJEL, int LPKDHPCJGAG, out GBKKEJLEPGB DNGOEPGIKGJ, out int BFKAJGEHNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4D01720", Offset = "0x4D00520", VA = "0x184D01720")]
	private static ulong JIGGHOBGOBD(GBKKEJLEPGB IHLLHGOCNMO, out int OKGHGBLIGMI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4D01890", Offset = "0x4D00690", VA = "0x184D01890")]
	private static void LBONIJMLFLO(GBKKEJLEPGB IHLLHGOCNMO, out GBFKGBEEJMM DGEANHLCFIF, out int AHIDCIGPBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4D00E60", Offset = "0x4CFFC60", VA = "0x184D00E60")]
	private static bool FDMMJAABBKB(GBKKEJLEPGB DNGOEPGIKGJ, int HLFEMIFMCPL, out double DGEANHLCFIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4D01A00", Offset = "0x4D00800", VA = "0x184D01A00")]
	private static GBFKGBEEJMM NBIHILFJCJK(int HLFEMIFMCPL)
	{
		return default(GBFKGBEEJMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x4D007B0", Offset = "0x4CFF5B0", VA = "0x184D007B0")]
	private static bool EOLHEIJKLEK(GBKKEJLEPGB IHLLHGOCNMO, int HLFEMIFMCPL, out double DGEANHLCFIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4D00670", Offset = "0x4CFF470", VA = "0x184D00670")]
	private static bool DMKIKOLJPIO(GBKKEJLEPGB DNGOEPGIKGJ, int HLFEMIFMCPL, out double FNPFDOLICPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x4D01600", Offset = "0x4D00400", VA = "0x184D01600")]
	public static double? IGOOIFFDAEN(GBKKEJLEPGB IHLLHGOCNMO, int HLFEMIFMCPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x4D01E10", Offset = "0x4D00C10", VA = "0x184D01E10")]
	public static float? PPBAJHMJADL(GBKKEJLEPGB IHLLHGOCNMO, int HLFEMIFMCPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct DDJLBKEKBME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] IHLLHGOCNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int JBINMJEHBFH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte DKPIGGFDHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x4CFA2E0", Offset = "0x4CF90E0", VA = "0x184CFA2E0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0xBA2B50", Offset = "0xBA1950", VA = "0x180BA2B50")]
	public DDJLBKEKBME(byte[] IHLLHGOCNMO, int JBINMJEHBFH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x4CFA240", Offset = "0x4CF9040", VA = "0x184CFA240")]
	public static DDJLBKEKBME MGDGEENJKJO(DDJLBKEKBME CNBAEMLJEBG)
	{
		return default(DDJLBKEKBME);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x4CFA040", Offset = "0x4CF8E40", VA = "0x184CFA040")]
	public static DDJLBKEKBME DHHECOJPLIP(DDJLBKEKBME CNBAEMLJEBG, int LNKONGJEECL)
	{
		return default(DDJLBKEKBME);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x4CFA2C0", Offset = "0x4CF90C0", VA = "0x184CFA2C0")]
	public static int OHKKABPHOED(DDJLBKEKBME PLAIMEGKAGI, DDJLBKEKBME PENEJEHLCIP)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x4CFA1D0", Offset = "0x4CF8FD0", VA = "0x184CFA1D0")]
	public static bool LHMNPGMNIAC(DDJLBKEKBME PLAIMEGKAGI, DDJLBKEKBME PENEJEHLCIP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x4CFA2A0", Offset = "0x4CF90A0", VA = "0x184CFA2A0")]
	public static bool NGBHPPLJJAJ(DDJLBKEKBME PLAIMEGKAGI, DDJLBKEKBME PENEJEHLCIP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x4CFA180", Offset = "0x4CF8F80", VA = "0x184CFA180")]
	public static bool LHMNPGMNIAC(DDJLBKEKBME PLAIMEGKAGI, char PENEJEHLCIP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x4CFA250", Offset = "0x4CF9050", VA = "0x184CFA250")]
	public static bool NGBHPPLJJAJ(DDJLBKEKBME PLAIMEGKAGI, char PENEJEHLCIP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x4CFA250", Offset = "0x4CF9050", VA = "0x184CFA250")]
	public static bool NGBHPPLJJAJ(DDJLBKEKBME PLAIMEGKAGI, byte PENEJEHLCIP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x4CFA130", Offset = "0x4CF8F30", VA = "0x184CFA130")]
	public static bool LHDDGADAEFD(DDJLBKEKBME PLAIMEGKAGI, char PENEJEHLCIP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x4CFA090", Offset = "0x4CF8E90", VA = "0x184CFA090")]
	public static bool EDHHNNNOIDD(DDJLBKEKBME PLAIMEGKAGI, char PENEJEHLCIP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x4CFA1F0", Offset = "0x4CF8FF0", VA = "0x184CFA1F0")]
	public static bool LKONNMFMAII(DDJLBKEKBME PLAIMEGKAGI, char PENEJEHLCIP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x4CFA0E0", Offset = "0x4CF8EE0", VA = "0x184CFA0E0")]
	public static bool FCAPNKMFLFL(DDJLBKEKBME PLAIMEGKAGI, char PENEJEHLCIP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class PEBJKMDKDIK
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] ACMCGDMPLEL;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] ABHHCKAPKPO;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] NMGHMABCGNO;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] AKEKMNFHNDH;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] FBBICJJIKLO;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int EOKGKIJPJAE;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] AFMNHGFLDDN;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int AOMMKICIHBA;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x545BC20", Offset = "0x545AA20", VA = "0x18545BC20")]
	private static byte[] IHHMILNEAFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x545BB30", Offset = "0x545A930", VA = "0x18545BB30")]
	private static byte[] GNNCHLADBAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x545D1E0", Offset = "0x545BFE0", VA = "0x18545D1E0")]
	public static double OFKNLJPLJFG(byte[] IHLLHGOCNMO, int JBINMJEHBFH, out int DEHMHKLPEPG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x545BD30", Offset = "0x545AB30", VA = "0x18545BD30")]
	public static float LPEEHCMCALF(byte[] IHLLHGOCNMO, int JBINMJEHBFH, out int DEHMHKLPEPG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x545BDF0", Offset = "0x545ABF0", VA = "0x18545BDF0")]
	private static bool MEBEMIIBHHH(int PAMKNJCGOGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x545BA20", Offset = "0x545A820", VA = "0x18545BA20")]
	private static bool GHIPFFDDMEN(ref DDJLBKEKBME PCEDOMDPLLE, DDJLBKEKBME HDNNAAICFFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x545D0D0", Offset = "0x545BED0", VA = "0x18545D0D0")]
	private static bool NIJPMIEFGLD(ref DDJLBKEKBME PCEDOMDPLLE, DDJLBKEKBME HDNNAAICFFH, byte[] GJDNLKPIJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x545B9D0", Offset = "0x545A7D0", VA = "0x18545B9D0")]
	private static bool APJPAOMKAPA(ref DDJLBKEKBME OOCNLJMDIFP, byte[] HAGBHFAOFIH, int JBINMJEHBFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x545BD10", Offset = "0x545AB10", VA = "0x18545BD10")]
	private static double JDPNJDNLLBP(bool NOBHOLEABJE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x545BF70", Offset = "0x545AD70", VA = "0x18545BF70")]
	private static double MNNJJJOMAOP(DDJLBKEKBME LCGINHIJIBJ, int LNKONGJEECL, bool ABJINOGLPLP, out int HBBCAJGIOPI)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class KPHPALPBLKH<T> : global::LGGFBAFGLIF<T[]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly global::JAPHKMFEBMD<T> MHEBKAKCCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly ALMEEBLMHKO COLCBICGMKI;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC980", Offset = "0x2EFB780", VA = "0x182EFC980")]
	public KPHPALPBLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2300E10", Offset = "0x22FFC10", VA = "0x182300E10")]
	public KPHPALPBLKH(ALMEEBLMHKO COLCBICGMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2EFA0F0", Offset = "0x2EF8EF0", VA = "0x182EFA0F0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, T[] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC060", Offset = "0x2EFAE60", VA = "0x182EFC060", Slot = "5")]
	public T[] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class EMBPOMPPCNO<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly global::JAPHKMFEBMD<T> MHEBKAKCCEB;
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class PCAKGEAGKOL<T> : global::LGGFBAFGLIF<List<T>>, GDABCMMFOHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly ALMEEBLMHKO COLCBICGMKI;

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC980", Offset = "0x2EFB780", VA = "0x182EFC980")]
	public PCAKGEAGKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2300E10", Offset = "0x22FFC10", VA = "0x182300E10")]
	public PCAKGEAGKOL(ALMEEBLMHKO COLCBICGMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3896B20", Offset = "0x3895920", VA = "0x183896B20", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, List<T> NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x38981E0", Offset = "0x3896FE0", VA = "0x1838981E0", Slot = "5")]
	public List<T> DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public abstract class KAPNNAHBNOJ<TElement, TIntermediate, TEnumerator, TCollection> : global::LGGFBAFGLIF<TCollection>, GDABCMMFOHF where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2BB81B0", Offset = "0x2BB6FB0", VA = "0x182BB81B0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, TCollection NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9BB0", Offset = "0x2BB89B0", VA = "0x182BB9BB0", Slot = "5")]
	public TCollection DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator BGJCEPCIMCH(TCollection HOKEJKCPCMA);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate FBMANFCLCAO();

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void AHKNMMEAEHA(ref TIntermediate AEBOLACOCGH, int CPOAAGLEIPE, TElement NLHFEJHKLAH);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection EMMGNHCOPMF(ref TIntermediate FBDDMLOPGCI);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
	protected KAPNNAHBNOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class GEDAFGKHFDN<TElement, TIntermediate, TCollection> : global::KAPNNAHBNOJ<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3513480", Offset = "0x3512280", VA = "0x183513480", Slot = "6")]
	protected override IEnumerator<TElement> BGJCEPCIMCH(TCollection HOKEJKCPCMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2780C20", Offset = "0x277FA20", VA = "0x182780C20")]
	protected GEDAFGKHFDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class GOIOADILNPC<TElement, TCollection> : global::GEDAFGKHFDN<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x148EDE0", Offset = "0x148DBE0", VA = "0x18148EDE0", Slot = "9")]
	protected sealed override TCollection EMMGNHCOPMF(ref TCollection FBDDMLOPGCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class MFJADNHCPFJ<TElement, TCollection> : global::GOIOADILNPC<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x35E61B0", Offset = "0x35E4FB0", VA = "0x1835E61B0", Slot = "7")]
	protected override TCollection FBMANFCLCAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x35E60D0", Offset = "0x35E4ED0", VA = "0x1835E60D0", Slot = "8")]
	protected override void AHKNMMEAEHA(ref TCollection AEBOLACOCGH, int CPOAAGLEIPE, TElement NLHFEJHKLAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class OIMIBDFFMEO<T> : global::KAPNNAHBNOJ<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5710", Offset = "0x2FE4510", VA = "0x182FE5710", Slot = "8")]
	protected override void AHKNMMEAEHA(ref LinkedList<T> AEBOLACOCGH, int CPOAAGLEIPE, T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x148EDE0", Offset = "0x148DBE0", VA = "0x18148EDE0", Slot = "9")]
	protected override LinkedList<T> EMMGNHCOPMF(ref LinkedList<T> FBDDMLOPGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4BE0", Offset = "0x2AC39E0", VA = "0x182AC4BE0", Slot = "7")]
	protected override LinkedList<T> FBMANFCLCAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3518A10", Offset = "0x3517810", VA = "0x183518A10", Slot = "6")]
	protected override LinkedList<T>.Enumerator BGJCEPCIMCH(LinkedList<T> HOKEJKCPCMA)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class PAKMAPEOAND<T> : global::KAPNNAHBNOJ<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5710", Offset = "0x2FE4510", VA = "0x182FE5710", Slot = "8")]
	protected override void AHKNMMEAEHA(ref Queue<T> AEBOLACOCGH, int CPOAAGLEIPE, T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4BE0", Offset = "0x2AC39E0", VA = "0x182AC4BE0", Slot = "7")]
	protected override Queue<T> FBMANFCLCAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8C60", Offset = "0x2DF7A60", VA = "0x182DF8C60", Slot = "6")]
	protected override Queue<T>.Enumerator BGJCEPCIMCH(Queue<T> HOKEJKCPCMA)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x148EDE0", Offset = "0x148DBE0", VA = "0x18148EDE0", Slot = "9")]
	protected override Queue<T> EMMGNHCOPMF(ref Queue<T> FBDDMLOPGCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class GBHLJBEHDIK<T> : global::KAPNNAHBNOJ<T, global::IMIDFIPHJMD<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8C30", Offset = "0x2DF7A30", VA = "0x182DF8C30", Slot = "8")]
	protected override void AHKNMMEAEHA(ref global::IMIDFIPHJMD<T> AEBOLACOCGH, int CPOAAGLEIPE, T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8D90", Offset = "0x2DF7B90", VA = "0x182DF8D90", Slot = "7")]
	protected override global::IMIDFIPHJMD<T> FBMANFCLCAO()
	{
		return default(global::IMIDFIPHJMD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8C60", Offset = "0x2DF7A60", VA = "0x182DF8C60", Slot = "6")]
	protected override Stack<T>.Enumerator BGJCEPCIMCH(Stack<T> HOKEJKCPCMA)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8CB0", Offset = "0x2DF7AB0", VA = "0x182DF8CB0", Slot = "9")]
	protected override Stack<T> EMMGNHCOPMF(ref global::IMIDFIPHJMD<T> FBDDMLOPGCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class LFILFPAHFPK<T> : global::KAPNNAHBNOJ<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5710", Offset = "0x2FE4510", VA = "0x182FE5710", Slot = "8")]
	protected override void AHKNMMEAEHA(ref HashSet<T> AEBOLACOCGH, int CPOAAGLEIPE, T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x148EDE0", Offset = "0x148DBE0", VA = "0x18148EDE0", Slot = "9")]
	protected override HashSet<T> EMMGNHCOPMF(ref HashSet<T> FBDDMLOPGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4BE0", Offset = "0x2AC39E0", VA = "0x182AC4BE0", Slot = "7")]
	protected override HashSet<T> FBMANFCLCAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8C60", Offset = "0x2DF7A60", VA = "0x182DF8C60", Slot = "6")]
	protected override HashSet<T>.Enumerator BGJCEPCIMCH(HashSet<T> HOKEJKCPCMA)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class LPIGHBFCCLK<T> : global::GEDAFGKHFDN<T, global::IMIDFIPHJMD<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8C30", Offset = "0x2DF7A30", VA = "0x182DF8C30", Slot = "8")]
	protected override void AHKNMMEAEHA(ref global::IMIDFIPHJMD<T> AEBOLACOCGH, int CPOAAGLEIPE, T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x3213B90", Offset = "0x3212990", VA = "0x183213B90", Slot = "9")]
	protected override ReadOnlyCollection<T> EMMGNHCOPMF(ref global::IMIDFIPHJMD<T> FBDDMLOPGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x3213C20", Offset = "0x3212A20", VA = "0x183213C20", Slot = "7")]
	protected override global::IMIDFIPHJMD<T> FBMANFCLCAO()
	{
		return default(global::IMIDFIPHJMD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class FODLFEBFJHL<T> : global::GEDAFGKHFDN<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5710", Offset = "0x2FE4510", VA = "0x182FE5710", Slot = "8")]
	protected override void AHKNMMEAEHA(ref List<T> AEBOLACOCGH, int CPOAAGLEIPE, T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4BE0", Offset = "0x2AC39E0", VA = "0x182AC4BE0", Slot = "7")]
	protected override List<T> FBMANFCLCAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x148EDE0", Offset = "0x148DBE0", VA = "0x18148EDE0", Slot = "9")]
	protected override IList<T> EMMGNHCOPMF(ref List<T> FBDDMLOPGCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class CCMDNJOGNCH<T> : global::GEDAFGKHFDN<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5710", Offset = "0x2FE4510", VA = "0x182FE5710", Slot = "8")]
	protected override void AHKNMMEAEHA(ref List<T> AEBOLACOCGH, int CPOAAGLEIPE, T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4BE0", Offset = "0x2AC39E0", VA = "0x182AC4BE0", Slot = "7")]
	protected override List<T> FBMANFCLCAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x148EDE0", Offset = "0x148DBE0", VA = "0x18148EDE0", Slot = "9")]
	protected override ICollection<T> EMMGNHCOPMF(ref List<T> FBDDMLOPGCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class LGKFALEDJFL<T> : global::GEDAFGKHFDN<T, global::IMIDFIPHJMD<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8C30", Offset = "0x2DF7A30", VA = "0x182DF8C30", Slot = "8")]
	protected override void AHKNMMEAEHA(ref global::IMIDFIPHJMD<T> AEBOLACOCGH, int CPOAAGLEIPE, T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8D90", Offset = "0x2DF7B90", VA = "0x182DF8D90", Slot = "7")]
	protected override global::IMIDFIPHJMD<T> FBMANFCLCAO()
	{
		return default(global::IMIDFIPHJMD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2FECFB0", Offset = "0x2FEBDB0", VA = "0x182FECFB0", Slot = "9")]
	protected override IEnumerable<T> EMMGNHCOPMF(ref global::IMIDFIPHJMD<T> FBDDMLOPGCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class LNOBIGHOHLM<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class APACDGKOJED<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class JJLKIIIHHFP<T> : global::LGGFBAFGLIF<T>, GDABCMMFOHF where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2F525C0", Offset = "0x2F513C0", VA = "0x182F525C0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, T NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2F52880", Offset = "0x2F51680", VA = "0x182F52880", Slot = "5")]
	public T DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
	public JJLKIIIHHFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class CBKMJBNKIBN : global::LGGFBAFGLIF<IEnumerable>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::LGGFBAFGLIF<IEnumerable> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x4CF6880", Offset = "0x4CF5680", VA = "0x184CF6880", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, IEnumerable NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x4CF6A70", Offset = "0x4CF5870", VA = "0x184CF6A70", Slot = "5")]
	public IEnumerable DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public CBKMJBNKIBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class CJDLCJPGOMH : global::LGGFBAFGLIF<ICollection>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public static readonly global::LGGFBAFGLIF<ICollection> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x4CF8590", Offset = "0x4CF7390", VA = "0x184CF8590", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, ICollection NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x4CF8850", Offset = "0x4CF7650", VA = "0x184CF8850", Slot = "5")]
	public ICollection DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public CJDLCJPGOMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class AIKKCDGPGJI : global::LGGFBAFGLIF<IList>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::LGGFBAFGLIF<IList> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF880", Offset = "0x4CEE680", VA = "0x184CEF880", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, IList NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x4CEFB40", Offset = "0x4CEE940", VA = "0x184CEFB40", Slot = "5")]
	public IList DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public AIKKCDGPGJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class MABIFNEPHBN<T> : global::GEDAFGKHFDN<T, global::IMIDFIPHJMD<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x35D96B0", Offset = "0x35D84B0", VA = "0x1835D96B0", Slot = "8")]
	protected override void AHKNMMEAEHA(ref global::IMIDFIPHJMD<T> AEBOLACOCGH, int CPOAAGLEIPE, T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8D90", Offset = "0x2DF7B90", VA = "0x182DF8D90", Slot = "7")]
	protected override global::IMIDFIPHJMD<T> FBMANFCLCAO()
	{
		return default(global::IMIDFIPHJMD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x35D9710", Offset = "0x35D8510", VA = "0x1835D9710", Slot = "9")]
	protected override IReadOnlyList<T> EMMGNHCOPMF(ref global::IMIDFIPHJMD<T> FBDDMLOPGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x28D0BB0", Offset = "0x28CF9B0", VA = "0x1828D0BB0")]
	public MABIFNEPHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public static class HECBPJMCLFD
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x4D07380", Offset = "0x4D06180", VA = "0x184D07380")]
	public static DateTime PFANGHPCDIK(DateTime JCOKBCKNGGK)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class KEDEPGJFDDN : global::LGGFBAFGLIF<DateTime>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly global::LGGFBAFGLIF<DateTime> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x5493950", Offset = "0x5492750", VA = "0x185493950", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, DateTime NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5493DB0", Offset = "0x5492BB0", VA = "0x185493DB0", Slot = "5")]
	public DateTime DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KEDEPGJFDDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class IAFEHHIINKC : global::LGGFBAFGLIF<DateTimeOffset>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly global::LGGFBAFGLIF<DateTimeOffset> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x548EE70", Offset = "0x548DC70", VA = "0x18548EE70", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, DateTimeOffset NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x548F250", Offset = "0x548E050", VA = "0x18548F250", Slot = "5")]
	public DateTimeOffset DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public IAFEHHIINKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class HGMNJEEIONO : global::LGGFBAFGLIF<TimeSpan>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly global::LGGFBAFGLIF<TimeSpan> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static byte[] MFBJGHINPOG;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x4D07420", Offset = "0x4D06220", VA = "0x184D07420", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, TimeSpan NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x4D076F0", Offset = "0x4D064F0", VA = "0x184D076F0", Slot = "5")]
	public TimeSpan DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public HGMNJEEIONO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public abstract class APOPCHGELBB<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::LGGFBAFGLIF<TDictionary>, GDABCMMFOHF where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x3B80EA0", Offset = "0x3B7FCA0", VA = "0x183B80EA0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, TDictionary NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x3B83480", Offset = "0x3B82280", VA = "0x183B83480", Slot = "5")]
	public TDictionary DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator BGJCEPCIMCH(TDictionary HOKEJKCPCMA);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate FBMANFCLCAO();

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void AHKNMMEAEHA(ref TIntermediate AEBOLACOCGH, int CPOAAGLEIPE, TKey ANFHHLAHMJD, TValue NLHFEJHKLAH);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary EMMGNHCOPMF(ref TIntermediate FBDDMLOPGCI);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
	protected APOPCHGELBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public abstract class EJDPHNHMMNK<TKey, TValue, TIntermediate, TDictionary> : global::APOPCHGELBB<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x3513480", Offset = "0x3512280", VA = "0x183513480", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> BGJCEPCIMCH(TDictionary HOKEJKCPCMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public abstract class GPIIAOKMMBL<TKey, TValue, TDictionary> : global::EJDPHNHMMNK<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x148EDE0", Offset = "0x148DBE0", VA = "0x18148EDE0", Slot = "9")]
	protected override TDictionary EMMGNHCOPMF(ref TDictionary FBDDMLOPGCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class EKNJPOJPEGO<TKey, TValue> : global::APOPCHGELBB<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x35189D0", Offset = "0x35177D0", VA = "0x1835189D0", Slot = "8")]
	protected override void AHKNMMEAEHA(ref Dictionary<TKey, TValue> AEBOLACOCGH, int CPOAAGLEIPE, TKey ANFHHLAHMJD, TValue NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x148EDE0", Offset = "0x148DBE0", VA = "0x18148EDE0", Slot = "9")]
	protected override Dictionary<TKey, TValue> EMMGNHCOPMF(ref Dictionary<TKey, TValue> FBDDMLOPGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4BE0", Offset = "0x2AC39E0", VA = "0x182AC4BE0", Slot = "7")]
	protected override Dictionary<TKey, TValue> FBMANFCLCAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x3518A70", Offset = "0x3517870", VA = "0x183518A70", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator BGJCEPCIMCH(Dictionary<TKey, TValue> HOKEJKCPCMA)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2771140", Offset = "0x276FF40", VA = "0x182771140")]
	public EKNJPOJPEGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public sealed class MKAKOPLIPHD<TKey, TValue, TDictionary> : global::GPIIAOKMMBL<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x395FD20", Offset = "0x395EB20", VA = "0x18395FD20", Slot = "8")]
	protected override void AHKNMMEAEHA(ref TDictionary AEBOLACOCGH, int CPOAAGLEIPE, TKey ANFHHLAHMJD, TValue NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x23062F0", Offset = "0x23050F0", VA = "0x1823062F0", Slot = "7")]
	protected override TDictionary FBMANFCLCAO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public sealed class NONFFKMBBPK<TKey, TValue> : global::EJDPHNHMMNK<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4BA0", Offset = "0x2AC39A0", VA = "0x182AC4BA0", Slot = "8")]
	protected override void AHKNMMEAEHA(ref Dictionary<TKey, TValue> AEBOLACOCGH, int CPOAAGLEIPE, TKey ANFHHLAHMJD, TValue NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4BE0", Offset = "0x2AC39E0", VA = "0x182AC4BE0", Slot = "7")]
	protected override Dictionary<TKey, TValue> FBMANFCLCAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x148EDE0", Offset = "0x148DBE0", VA = "0x18148EDE0", Slot = "9")]
	protected override IDictionary<TKey, TValue> EMMGNHCOPMF(ref Dictionary<TKey, TValue> FBDDMLOPGCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class PICEOFBOCCM<TKey, TValue> : global::GPIIAOKMMBL<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4BA0", Offset = "0x2AC39A0", VA = "0x182AC4BA0", Slot = "8")]
	protected override void AHKNMMEAEHA(ref SortedList<TKey, TValue> AEBOLACOCGH, int CPOAAGLEIPE, TKey ANFHHLAHMJD, TValue NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4BE0", Offset = "0x2AC39E0", VA = "0x182AC4BE0", Slot = "7")]
	protected override SortedList<TKey, TValue> FBMANFCLCAO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class FGFJCEFNGDE<TKey, TValue> : global::APOPCHGELBB<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4BA0", Offset = "0x2AC39A0", VA = "0x182AC4BA0", Slot = "8")]
	protected override void AHKNMMEAEHA(ref SortedDictionary<TKey, TValue> AEBOLACOCGH, int CPOAAGLEIPE, TKey ANFHHLAHMJD, TValue NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x148EDE0", Offset = "0x148DBE0", VA = "0x18148EDE0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> EMMGNHCOPMF(ref SortedDictionary<TKey, TValue> FBDDMLOPGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4BE0", Offset = "0x2AC39E0", VA = "0x182AC4BE0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> FBMANFCLCAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x37C4C70", Offset = "0x37C3A70", VA = "0x1837C4C70", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator BGJCEPCIMCH(SortedDictionary<TKey, TValue> HOKEJKCPCMA)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class DNHGFBPNIGA<T> : global::LGGFBAFGLIF<T>, GDABCMMFOHF where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2B1A540", Offset = "0x2B19340", VA = "0x182B1A540", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, T NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2B1A8F0", Offset = "0x2B196F0", VA = "0x182B1A8F0", Slot = "5")]
	public T DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
	public DNHGFBPNIGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class MDENEGANOEK : global::LGGFBAFGLIF<IDictionary>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly global::LGGFBAFGLIF<IDictionary> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x5457380", Offset = "0x5456180", VA = "0x185457380", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, IDictionary NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x5457830", Offset = "0x5456630", VA = "0x185457830", Slot = "5")]
	public IDictionary DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public MDENEGANOEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class DJHGFPALOHC : global::LGGFBAFGLIF<object>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private delegate void CJMHHEGPCCG(object ADAGNENFKFK, ref OPNEEIEIDGM AGODLEOBGCG, object NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly global::GADAHHOBMOO<KeyValuePair<object, CJMHHEGPCCG>> DODHBPGDFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly BJKEHJMPEHM[] KEDLPIKOJFE;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB0E0", Offset = "0x4CF9EE0", VA = "0x184CFB0E0")]
	public DJHGFPALOHC(params BJKEHJMPEHM[] KEDLPIKOJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x4CFA510", Offset = "0x4CF9310", VA = "0x184CFA510", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, object NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB040", Offset = "0x4CF9E40", VA = "0x184CFB040", Slot = "5")]
	public object DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public static class CGHHENONCGG
{
	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x4CF7A00", Offset = "0x4CF6800", VA = "0x184CF7A00")]
	public static object MMEFDNEFFEA(Type MAIOHDHBGKE, out bool PJKDEOCNNCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x4CF70E0", Offset = "0x4CF5EE0", VA = "0x184CF70E0")]
	public static object INBCHGNGDNL(Type MAIOHDHBGKE, out bool PJKDEOCNNCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public class FAEMCDCAHMB<T> : global::LGGFBAFGLIF<T>, GDABCMMFOHF, global::FCKKKGCGPCO<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class CABCLNDCGOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public CABCLNDCGOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x3902790", Offset = "0x3901590", VA = "0x183902790")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class OONPAIGPONB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public global::NMJNPKKKIJM<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public OONPAIGPONB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x4D928E0", Offset = "0x4D916E0", VA = "0x184D928E0")]
		internal void <.cctor>b__1(ref OPNEEIEIDGM writer, T value, BJKEHJMPEHM _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class NJMLBMECLHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public global::CCCOECCIAGB<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public NJMLBMECLHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x3958E60", Offset = "0x3957C60", VA = "0x183958E60")]
		internal T <.cctor>b__2(ref BBCCONEKLEB reader, BJKEHJMPEHM _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly global::AMFBHPAKJGL<T> CCDMBJACKBH;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static readonly Dictionary<T, string> NLGFOJJPAPI;

	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private static readonly global::NMJNPKKKIJM<T> AOPLDAGHAEB;

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly global::CCCOECCIAGB<T> CFDHLNFCDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly bool PGMHKACKJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly global::NMJNPKKKIJM<T> PGDJLIHHMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::CCCOECCIAGB<T> LLOCGPPMHIB;

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x309C290", Offset = "0x309B090", VA = "0x18309C290")]
	static FAEMCDCAHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x30A1F90", Offset = "0x30A0D90", VA = "0x1830A1F90")]
	public FAEMCDCAHMB(bool PGMHKACKJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x308D1B0", Offset = "0x308BFB0", VA = "0x18308D1B0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, T NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x308FA90", Offset = "0x308E890", VA = "0x18308FA90", Slot = "5")]
	public T DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3092090", Offset = "0x3090E90", VA = "0x183092090", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, T NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3091600", Offset = "0x3090400", VA = "0x183091600", Slot = "7")]
	public T MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class DDHIDKPAPNJ<T> : global::LGGFBAFGLIF<T[,]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x2B04860", Offset = "0x2B03660", VA = "0x182B04860", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, T[,] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x2B04A10", Offset = "0x2B03810", VA = "0x182B04A10", Slot = "5")]
	public T[,] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
	public DDHIDKPAPNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class LDIFKIMOCJI<T> : global::LGGFBAFGLIF<T[,,]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x2FDD2B0", Offset = "0x2FDC0B0", VA = "0x182FDD2B0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, T[,,] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x2FDD4C0", Offset = "0x2FDC2C0", VA = "0x182FDD4C0", Slot = "5")]
	public T[,,] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
	public LDIFKIMOCJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class BLPFCOCHGME<T> : global::LGGFBAFGLIF<T[,,,]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2985430", Offset = "0x2984230", VA = "0x182985430", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, T[,,,] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x29856D0", Offset = "0x29844D0", VA = "0x1829856D0", Slot = "5")]
	public T[,,,] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
	public BLPFCOCHGME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class BBNBIEGFCCF<T> : global::LGGFBAFGLIF<T?>, GDABCMMFOHF where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2969FA0", Offset = "0x2968DA0", VA = "0x182969FA0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, T? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x296A250", Offset = "0x2969050", VA = "0x18296A250", Slot = "5")]
	public T? DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
	public BBNBIEGFCCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class DDJGEKDFPLD<T> : global::LGGFBAFGLIF<T?>, GDABCMMFOHF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private readonly global::LGGFBAFGLIF<T> LGPDHHKFPOF;

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x28D63A0", Offset = "0x28D51A0", VA = "0x1828D63A0")]
	public DDJGEKDFPLD(global::LGGFBAFGLIF<T> LGPDHHKFPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2B06F00", Offset = "0x2B05D00", VA = "0x182B06F00")]
	public DDJGEKDFPLD(Type FBLAAKMMNCH, object[] CHJCFCPHLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2B05A90", Offset = "0x2B04890", VA = "0x182B05A90", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, T? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2B060E0", Offset = "0x2B04EE0", VA = "0x182B060E0", Slot = "5")]
	public T? DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class LHMCLCMBGEK : global::LGGFBAFGLIF<sbyte>, GDABCMMFOHF, global::FCKKKGCGPCO<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly LHMCLCMBGEK LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x54A0220", Offset = "0x549F020", VA = "0x1854A0220", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, sbyte NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x54A0240", Offset = "0x549F040", VA = "0x1854A0240", Slot = "5")]
	public sbyte DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x54A0300", Offset = "0x549F100", VA = "0x1854A0300", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, sbyte NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x54A0250", Offset = "0x549F050", VA = "0x1854A0250", Slot = "7")]
	public sbyte MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public LHMCLCMBGEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class DLLFOKBELDO : global::LGGFBAFGLIF<sbyte?>, GDABCMMFOHF, global::FCKKKGCGPCO<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly DLLFOKBELDO LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB180", Offset = "0x4CF9F80", VA = "0x184CFB180", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, sbyte? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB200", Offset = "0x4CFA000", VA = "0x184CFB200", Slot = "5")]
	public sbyte? DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB370", Offset = "0x4CFA170", VA = "0x184CFB370", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, sbyte? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x4CFB2B0", Offset = "0x4CFA0B0", VA = "0x184CFB2B0", Slot = "7")]
	public sbyte? MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public DLLFOKBELDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class JHMOJHKGEDL : global::LGGFBAFGLIF<sbyte[]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly JHMOJHKGEDL LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5492F90", Offset = "0x5491D90", VA = "0x185492F90", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, sbyte[] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5493050", Offset = "0x5491E50", VA = "0x185493050", Slot = "5")]
	public sbyte[] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public JHMOJHKGEDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class FONGDGIEELB : global::LGGFBAFGLIF<short>, GDABCMMFOHF, global::FCKKKGCGPCO<short>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly FONGDGIEELB LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x4D021A0", Offset = "0x4D00FA0", VA = "0x184D021A0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, short NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4D021C0", Offset = "0x4D00FC0", VA = "0x184D021C0", Slot = "5")]
	public short DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D022A0", Offset = "0x4D010A0", VA = "0x184D022A0", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, short NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D02220", Offset = "0x4D01020", VA = "0x184D02220", Slot = "7")]
	public short MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public FONGDGIEELB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class ECFKAMILABC : global::LGGFBAFGLIF<short?>, GDABCMMFOHF, global::FCKKKGCGPCO<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly ECFKAMILABC LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x4CFBFC0", Offset = "0x4CFADC0", VA = "0x184CFBFC0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, short? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x4CFC040", Offset = "0x4CFAE40", VA = "0x184CFC040", Slot = "5")]
	public short? DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x4CFC1B0", Offset = "0x4CFAFB0", VA = "0x184CFC1B0", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, short? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x4CFC0F0", Offset = "0x4CFAEF0", VA = "0x184CFC0F0", Slot = "7")]
	public short? MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public ECFKAMILABC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class GPPPBLNIDCG : global::LGGFBAFGLIF<short[]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly GPPPBLNIDCG LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x4D066E0", Offset = "0x4D054E0", VA = "0x184D066E0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, short[] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x4D067A0", Offset = "0x4D055A0", VA = "0x184D067A0", Slot = "5")]
	public short[] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public GPPPBLNIDCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class IGNHENFNOLB : global::LGGFBAFGLIF<int>, GDABCMMFOHF, global::FCKKKGCGPCO<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly IGNHENFNOLB LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5490940", Offset = "0x548F740", VA = "0x185490940", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, int NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5490950", Offset = "0x548F750", VA = "0x185490950", Slot = "5")]
	public int DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5490A10", Offset = "0x548F810", VA = "0x185490A10", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, int NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5490960", Offset = "0x548F760", VA = "0x185490960", Slot = "7")]
	public int MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public IGNHENFNOLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class EMCLJAEIKFD : global::LGGFBAFGLIF<int?>, GDABCMMFOHF, global::FCKKKGCGPCO<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly EMCLJAEIKFD LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x4CFF8F0", Offset = "0x4CFE6F0", VA = "0x184CFF8F0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, int? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4CFF960", Offset = "0x4CFE760", VA = "0x184CFF960", Slot = "5")]
	public int? DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x4CFFAD0", Offset = "0x4CFE8D0", VA = "0x184CFFAD0", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, int? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x4CFFA10", Offset = "0x4CFE810", VA = "0x184CFFA10", Slot = "7")]
	public int? MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public EMCLJAEIKFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class FEPDCPDHKOG : global::LGGFBAFGLIF<int[]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly FEPDCPDHKOG LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x4D00000", Offset = "0x4CFEE00", VA = "0x184D00000", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, int[] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4D000C0", Offset = "0x4CFEEC0", VA = "0x184D000C0", Slot = "5")]
	public int[] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public FEPDCPDHKOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class NCHPJIPNLBB : global::LGGFBAFGLIF<long>, GDABCMMFOHF, global::FCKKKGCGPCO<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly NCHPJIPNLBB LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x5458F60", Offset = "0x5457D60", VA = "0x185458F60", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, long NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5458F90", Offset = "0x5457D90", VA = "0x185458F90", Slot = "5")]
	public long DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5459020", Offset = "0x5457E20", VA = "0x185459020", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, long NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x5458FA0", Offset = "0x5457DA0", VA = "0x185458FA0", Slot = "7")]
	public long MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public NCHPJIPNLBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class HAIFNDPELEE : global::LGGFBAFGLIF<long?>, GDABCMMFOHF, global::FCKKKGCGPCO<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly HAIFNDPELEE LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x4D06A30", Offset = "0x4D05830", VA = "0x184D06A30", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, long? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x4D06AB0", Offset = "0x4D058B0", VA = "0x184D06AB0", Slot = "5")]
	public long? DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x4D06C20", Offset = "0x4D05A20", VA = "0x184D06C20", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, long? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x4D06B40", Offset = "0x4D05940", VA = "0x184D06B40", Slot = "7")]
	public long? MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public HAIFNDPELEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class GHLCDPGJDGL : global::LGGFBAFGLIF<long[]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly GHLCDPGJDGL LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x4D02AC0", Offset = "0x4D018C0", VA = "0x184D02AC0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, long[] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x4D02B80", Offset = "0x4D01980", VA = "0x184D02B80", Slot = "5")]
	public long[] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public GHLCDPGJDGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class IMNLCJIIFIF : global::LGGFBAFGLIF<byte>, GDABCMMFOHF, global::FCKKKGCGPCO<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly IMNLCJIIFIF LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x5491470", Offset = "0x5490270", VA = "0x185491470", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, byte NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5491490", Offset = "0x5490290", VA = "0x185491490", Slot = "5")]
	public byte DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5491550", Offset = "0x5490350", VA = "0x185491550", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, byte NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x54914A0", Offset = "0x54902A0", VA = "0x1854914A0", Slot = "7")]
	public byte MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public IMNLCJIIFIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class AMMJKMHBKAI : global::LGGFBAFGLIF<byte?>, GDABCMMFOHF, global::FCKKKGCGPCO<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly AMMJKMHBKAI LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x4CEFF90", Offset = "0x4CEED90", VA = "0x184CEFF90", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, byte? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4CF0010", Offset = "0x4CEEE10", VA = "0x184CF0010", Slot = "5")]
	public byte? DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4CF0180", Offset = "0x4CEEF80", VA = "0x184CF0180", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, byte? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4CF00C0", Offset = "0x4CEEEC0", VA = "0x184CF00C0", Slot = "7")]
	public byte? MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public AMMJKMHBKAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class JJCKOAGPAPI : global::LGGFBAFGLIF<ushort>, GDABCMMFOHF, global::FCKKKGCGPCO<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly JJCKOAGPAPI LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x54931F0", Offset = "0x5491FF0", VA = "0x1854931F0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, ushort NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x5493210", Offset = "0x5492010", VA = "0x185493210", Slot = "5")]
	public ushort DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x54932D0", Offset = "0x54920D0", VA = "0x1854932D0", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, ushort NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x5493220", Offset = "0x5492020", VA = "0x185493220", Slot = "7")]
	public ushort MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public JJCKOAGPAPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class AEGOICHEDIH : global::LGGFBAFGLIF<ushort?>, GDABCMMFOHF, global::FCKKKGCGPCO<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly AEGOICHEDIH LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x4CEE750", Offset = "0x4CED550", VA = "0x184CEE750", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, ushort? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x4CEE7D0", Offset = "0x4CED5D0", VA = "0x184CEE7D0", Slot = "5")]
	public ushort? DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x4CEE940", Offset = "0x4CED740", VA = "0x184CEE940", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, ushort? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x4CEE880", Offset = "0x4CED680", VA = "0x184CEE880", Slot = "7")]
	public ushort? MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public AEGOICHEDIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class AIJAOPDLPDL : global::LGGFBAFGLIF<ushort[]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly AIJAOPDLPDL LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF530", Offset = "0x4CEE330", VA = "0x184CEF530", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, ushort[] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF5F0", Offset = "0x4CEE3F0", VA = "0x184CEF5F0", Slot = "5")]
	public ushort[] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public AIJAOPDLPDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class LHABEGPKIMF : global::LGGFBAFGLIF<uint>, GDABCMMFOHF, global::FCKKKGCGPCO<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly LHABEGPKIMF LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x54A00B0", Offset = "0x549EEB0", VA = "0x1854A00B0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, uint NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x54A00C0", Offset = "0x549EEC0", VA = "0x1854A00C0", Slot = "5")]
	public uint DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x54A0180", Offset = "0x549EF80", VA = "0x1854A0180", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, uint NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x54A00D0", Offset = "0x549EED0", VA = "0x1854A00D0", Slot = "7")]
	public uint MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public LHABEGPKIMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class IPAMAIOOLHI : global::LGGFBAFGLIF<uint?>, GDABCMMFOHF, global::FCKKKGCGPCO<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly IPAMAIOOLHI LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x5491B40", Offset = "0x5490940", VA = "0x185491B40", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, uint? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x5491BB0", Offset = "0x54909B0", VA = "0x185491BB0", Slot = "5")]
	public uint? DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x5491D10", Offset = "0x5490B10", VA = "0x185491D10", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, uint? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5491C20", Offset = "0x5490A20", VA = "0x185491C20", Slot = "7")]
	public uint? MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public IPAMAIOOLHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class BIACHDEOBPH : global::LGGFBAFGLIF<uint[]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly BIACHDEOBPH LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4CF4580", Offset = "0x4CF3380", VA = "0x184CF4580", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, uint[] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4CF4640", Offset = "0x4CF3440", VA = "0x184CF4640", Slot = "5")]
	public uint[] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public BIACHDEOBPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class EGAKLKKJKJF : global::LGGFBAFGLIF<ulong>, GDABCMMFOHF, global::FCKKKGCGPCO<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly EGAKLKKJKJF LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x4CFC290", Offset = "0x4CFB090", VA = "0x184CFC290", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, ulong NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x4CFC2B0", Offset = "0x4CFB0B0", VA = "0x184CFC2B0", Slot = "5")]
	public ulong DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x4CFC340", Offset = "0x4CFB140", VA = "0x184CFC340", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, ulong NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x4CFC2C0", Offset = "0x4CFB0C0", VA = "0x184CFC2C0", Slot = "7")]
	public ulong MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public EGAKLKKJKJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class IHJGCGLONPA : global::LGGFBAFGLIF<ulong?>, GDABCMMFOHF, global::FCKKKGCGPCO<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly IHJGCGLONPA LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5490AB0", Offset = "0x548F8B0", VA = "0x185490AB0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, ulong? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5490B30", Offset = "0x548F930", VA = "0x185490B30", Slot = "5")]
	public ulong? DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5490CA0", Offset = "0x548FAA0", VA = "0x185490CA0", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, ulong? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5490BC0", Offset = "0x548F9C0", VA = "0x185490BC0", Slot = "7")]
	public ulong? MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public IHJGCGLONPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class IFGFCBCHPGB : global::LGGFBAFGLIF<ulong[]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly IFGFCBCHPGB LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x54906E0", Offset = "0x548F4E0", VA = "0x1854906E0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, ulong[] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x54907A0", Offset = "0x548F5A0", VA = "0x1854907A0", Slot = "5")]
	public ulong[] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public IFGFCBCHPGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class MANHCFOPOMB : global::LGGFBAFGLIF<float>, GDABCMMFOHF, global::FCKKKGCGPCO<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly MANHCFOPOMB LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x54571D0", Offset = "0x5455FD0", VA = "0x1854571D0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, float NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x54571E0", Offset = "0x5455FE0", VA = "0x1854571E0", Slot = "5")]
	public float DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5457270", Offset = "0x5456070", VA = "0x185457270", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, float NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x54571F0", Offset = "0x5455FF0", VA = "0x1854571F0", Slot = "7")]
	public float MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public MANHCFOPOMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class PBHAKEGMCJP : global::LGGFBAFGLIF<float?>, GDABCMMFOHF, global::FCKKKGCGPCO<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly PBHAKEGMCJP LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x545B500", Offset = "0x545A300", VA = "0x18545B500", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, float? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x545B580", Offset = "0x545A380", VA = "0x18545B580", Slot = "5")]
	public float? DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x545B6B0", Offset = "0x545A4B0", VA = "0x18545B6B0", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, float? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x545B5F0", Offset = "0x545A3F0", VA = "0x18545B5F0", Slot = "7")]
	public float? MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public PBHAKEGMCJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class BDLHHIGBMCH : global::LGGFBAFGLIF<float[]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly BDLHHIGBMCH LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x4CF34D0", Offset = "0x4CF22D0", VA = "0x184CF34D0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, float[] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x4CF3590", Offset = "0x4CF2390", VA = "0x184CF3590", Slot = "5")]
	public float[] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public BDLHHIGBMCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class OMJHFCEINEG : global::LGGFBAFGLIF<double>, GDABCMMFOHF, global::FCKKKGCGPCO<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly OMJHFCEINEG LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x5459B60", Offset = "0x5458960", VA = "0x185459B60", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, double NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x5459B70", Offset = "0x5458970", VA = "0x185459B70", Slot = "5")]
	public double DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5459C00", Offset = "0x5458A00", VA = "0x185459C00", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, double NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x5459B80", Offset = "0x5458980", VA = "0x185459B80", Slot = "7")]
	public double MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public OMJHFCEINEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class JEGMDOADEOF : global::LGGFBAFGLIF<double?>, GDABCMMFOHF, global::FCKKKGCGPCO<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly JEGMDOADEOF LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5492BB0", Offset = "0x54919B0", VA = "0x185492BB0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, double? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5492C30", Offset = "0x5491A30", VA = "0x185492C30", Slot = "5")]
	public double? DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5492DD0", Offset = "0x5491BD0", VA = "0x185492DD0", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, double? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5492CC0", Offset = "0x5491AC0", VA = "0x185492CC0", Slot = "7")]
	public double? MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public JEGMDOADEOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class IEANPDNNOKO : global::LGGFBAFGLIF<double[]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly IEANPDNNOKO LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x5490480", Offset = "0x548F280", VA = "0x185490480", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, double[] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5490540", Offset = "0x548F340", VA = "0x185490540", Slot = "5")]
	public double[] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public IEANPDNNOKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class EJDGMGKBEGN : global::LGGFBAFGLIF<bool>, GDABCMMFOHF, global::FCKKKGCGPCO<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly EJDGMGKBEGN LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x4CFE6A0", Offset = "0x4CFD4A0", VA = "0x184CFE6A0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, bool NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x4CFE6C0", Offset = "0x4CFD4C0", VA = "0x184CFE6C0", Slot = "5")]
	public bool DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x4CFE750", Offset = "0x4CFD550", VA = "0x184CFE750", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, bool NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x4CFE6D0", Offset = "0x4CFD4D0", VA = "0x184CFE6D0", Slot = "7")]
	public bool MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public EJDGMGKBEGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class BCPOGGLCDLM : global::LGGFBAFGLIF<bool?>, GDABCMMFOHF, global::FCKKKGCGPCO<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly BCPOGGLCDLM LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x4CF3240", Offset = "0x4CF2040", VA = "0x184CF3240", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, bool? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x4CF32C0", Offset = "0x4CF20C0", VA = "0x184CF32C0", Slot = "5")]
	public bool? DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x4CF33F0", Offset = "0x4CF21F0", VA = "0x184CF33F0", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, bool? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x4CF3330", Offset = "0x4CF2130", VA = "0x184CF3330", Slot = "7")]
	public bool? MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public BCPOGGLCDLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class GAJGMBHLPJJ : global::LGGFBAFGLIF<bool[]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly GAJGMBHLPJJ LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x4D02470", Offset = "0x4D01270", VA = "0x184D02470", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, bool[] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x4D02540", Offset = "0x4D01340", VA = "0x184D02540", Slot = "5")]
	public bool[] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public GAJGMBHLPJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class KMANMLLKIAC : global::LGGFBAFGLIF<object>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::LGGFBAFGLIF<object> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly Dictionary<Type, int> PKAFPKMHLGD;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x549D1A0", Offset = "0x549BFA0", VA = "0x18549D1A0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, object NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x549DC20", Offset = "0x549CA20", VA = "0x18549DC20", Slot = "5")]
	public object DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KMANMLLKIAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class MEPPPGPKBEK : global::LGGFBAFGLIF<byte[]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::LGGFBAFGLIF<byte[]> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5457A60", Offset = "0x5456860", VA = "0x185457A60", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, byte[] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x5457AF0", Offset = "0x54568F0", VA = "0x185457AF0", Slot = "5")]
	public byte[] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public MEPPPGPKBEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class GKBCGMOHDMP : global::LGGFBAFGLIF<ArraySegment<byte>>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::LGGFBAFGLIF<ArraySegment<byte>> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x4D02EF0", Offset = "0x4D01CF0", VA = "0x184D02EF0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, ArraySegment<byte> NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x4D02FB0", Offset = "0x4D01DB0", VA = "0x184D02FB0", Slot = "5")]
	public ArraySegment<byte> DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public GKBCGMOHDMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class KGJFFBANBHL : global::LGGFBAFGLIF<string>, GDABCMMFOHF, global::FCKKKGCGPCO<string>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::LGGFBAFGLIF<string> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x549CEA0", Offset = "0x549BCA0", VA = "0x18549CEA0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, string NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x549CEC0", Offset = "0x549BCC0", VA = "0x18549CEC0", Slot = "5")]
	public string DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x549CEA0", Offset = "0x549BCA0", VA = "0x18549CEA0", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, string NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x549CEC0", Offset = "0x549BCC0", VA = "0x18549CEC0", Slot = "7")]
	public string MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KGJFFBANBHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class CDGDILKJPNJ : global::LGGFBAFGLIF<string[]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly CDGDILKJPNJ LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x4CF6D60", Offset = "0x4CF5B60", VA = "0x184CF6D60", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, string[] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x4CF6E20", Offset = "0x4CF5C20", VA = "0x184CF6E20", Slot = "5")]
	public string[] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public CDGDILKJPNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class DEBENJHKDFD : global::LGGFBAFGLIF<char>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly DEBENJHKDFD LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x4CFA320", Offset = "0x4CF9120", VA = "0x184CFA320", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, char NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x4CFA3A0", Offset = "0x4CF91A0", VA = "0x184CFA3A0", Slot = "5")]
	public char DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public DEBENJHKDFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class DCMLIENMMPE : global::LGGFBAFGLIF<char?>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly DCMLIENMMPE LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x4CF9DF0", Offset = "0x4CF8BF0", VA = "0x184CF9DF0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, char? NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4CF9F10", Offset = "0x4CF8D10", VA = "0x184CF9F10", Slot = "5")]
	public char? DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public DCMLIENMMPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class NANNNINFKNF : global::LGGFBAFGLIF<char[]>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly NANNNINFKNF LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x5458B20", Offset = "0x5457920", VA = "0x185458B20", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, char[] NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x5458D60", Offset = "0x5457B60", VA = "0x185458D60", Slot = "5")]
	public char[] DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public NANNNINFKNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class DCENKFCCDOJ : global::LGGFBAFGLIF<Guid>, GDABCMMFOHF, global::FCKKKGCGPCO<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::LGGFBAFGLIF<Guid> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x4CF9BA0", Offset = "0x4CF89A0", VA = "0x184CF9BA0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, Guid NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x4CF9C70", Offset = "0x4CF8A70", VA = "0x184CF9C70", Slot = "5")]
	public Guid DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x4CF9CC0", Offset = "0x4CF8AC0", VA = "0x184CF9CC0", Slot = "6")]
	public void POANABLMHHN(ref OPNEEIEIDGM AGODLEOBGCG, Guid NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x4CF9C70", Offset = "0x4CF8A70", VA = "0x184CF9C70", Slot = "7")]
	public Guid MLNPGDELANM(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public DCENKFCCDOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class EGMCDJAJDHL : global::LGGFBAFGLIF<decimal>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::LGGFBAFGLIF<decimal> LKPPHHDONBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly bool PLFFEIOMAFL;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x42D2330", Offset = "0x42D1130", VA = "0x1842D2330")]
	public EGMCDJAJDHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x926B00", Offset = "0x925900", VA = "0x180926B00")]
	public EGMCDJAJDHL(bool PLFFEIOMAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x4CFC3E0", Offset = "0x4CFB1E0", VA = "0x184CFC3E0", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, decimal NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x4CFC530", Offset = "0x4CFB330", VA = "0x184CFC530", Slot = "5")]
	public decimal DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class GOHGCILGLKN : global::LGGFBAFGLIF<Uri>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly global::LGGFBAFGLIF<Uri> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x4D03910", Offset = "0x4D02710", VA = "0x184D03910", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, Uri NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x4D039C0", Offset = "0x4D027C0", VA = "0x184D039C0", Slot = "5")]
	public Uri DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public GOHGCILGLKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class KLABAIDIFIO : global::LGGFBAFGLIF<Version>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly global::LGGFBAFGLIF<Version> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x549D010", Offset = "0x549BE10", VA = "0x18549D010", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, Version NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x549D0C0", Offset = "0x549BEC0", VA = "0x18549D0C0", Slot = "5")]
	public Version DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KLABAIDIFIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class FOBOCCPMEBD<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class PPDDBCHENLM : global::LGGFBAFGLIF<StringBuilder>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly global::LGGFBAFGLIF<StringBuilder> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x545F860", Offset = "0x545E660", VA = "0x18545F860", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, StringBuilder NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x545F8B0", Offset = "0x545E6B0", VA = "0x18545F8B0", Slot = "5")]
	public StringBuilder DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public PPDDBCHENLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class LOEGOHPGLOD : global::LGGFBAFGLIF<BitArray>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly global::LGGFBAFGLIF<BitArray> LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x54A0430", Offset = "0x549F230", VA = "0x1854A0430", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, BitArray NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x54A04C0", Offset = "0x549F2C0", VA = "0x1854A04C0", Slot = "5")]
	public BitArray DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public LOEGOHPGLOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class AEOLBCMHDBA : global::LGGFBAFGLIF<Type>, GDABCMMFOHF
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly AEOLBCMHDBA LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly Regex BEDECGICKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool BDAHFONEHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private bool HONHOEMHHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private bool MOKAMDKEFBL;

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x4CEED00", Offset = "0x4CEDB00", VA = "0x184CEED00")]
	public AEOLBCMHDBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x4CEED20", Offset = "0x4CEDB20", VA = "0x184CEED20")]
	public AEOLBCMHDBA(bool BDAHFONEHEJ, bool HONHOEMHHAG, bool MOKAMDKEFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x4CEEA20", Offset = "0x4CED820", VA = "0x184CEEA20", Slot = "4")]
	public void APDPBGNCGIO(ref OPNEEIEIDGM AGODLEOBGCG, Type NLHFEJHKLAH, BJKEHJMPEHM BAACJHDNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x4CEEB10", Offset = "0x4CED910", VA = "0x184CEEB10", Slot = "5")]
	public Type DHABJCANOEO(ref BBCCONEKLEB EDHAMFMKJBA, BJKEHJMPEHM BAACJHDNDCL)
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
