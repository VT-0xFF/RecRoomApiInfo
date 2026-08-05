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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class CFEGMLPKMFB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63DEFD0", Offset = "0x63DD7D0", VA = "0x1863DEFD0")]
	public static bool PACFIKCEMAE(this TypeInfo GFGNPBCFEMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class KPPKKKEFCKN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type GBOPONJMGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x764B00", VA = "0x180766300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] HIDJHNEJPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x78D440", Offset = "0x78BC40", VA = "0x18078D440")]
	public KPPKKKEFCKN(Type BEMCHLPIMAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class GFFGOFBKALN : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KIKABMJOFAO<T>(LDODEOAPOMB MCLDKNNIMFL, T FKKGMPDEPMA, CBBFEPDHKGO IMGHMGOANOH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T KCHAJGNMLDG<T>(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO IMGHMGOANOH);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JFICJNJNNFJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GGKCAJABCKP<T> : JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, T FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JLCOFNPFLDJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, T FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum HNCOLKIOEOE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JBLKEMDLHKI
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x23BE3D0", Offset = "0x23BCBD0", VA = "0x1823BE3D0")]
	public static string KJJPHAMJCAM<T>(this GGKCAJABCKP<T> HOGAFGKFADG, T FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGKCAJABCKP<T> MBCGOIMPMDC<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PBNJOIPFAIA
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x24E68C0", Offset = "0x24E50C0", VA = "0x1824E68C0")]
	public static GGKCAJABCKP<T> NMMHLAAIGJJ<T>(this CBBFEPDHKGO IMGHMGOANOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63F8470", Offset = "0x63F6C70", VA = "0x1863F8470")]
	public static object IBMIIGHPPCI(this CBBFEPDHKGO IMGHMGOANOH, Type GFGNPBCFEMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OPBHBLEMHCH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63F7A50", Offset = "0x63F6250", VA = "0x1863F7A50")]
	public OPBHBLEMHCH(string BKGEBGGPBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct ABJCIMHBCLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class HJMDBJBPEEF
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] NEJFCHMJPKN;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] BLJCCPGEEFB;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x63E27E0", Offset = "0x63E0FE0", VA = "0x1863E27E0")]
		public static byte[] GCCJCJJLILN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x63E2880", Offset = "0x63E1080", VA = "0x1863E2880")]
		public static char[] JCOCNNMCFLH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> MJAIPMHIFNK;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] ELGBBAJEEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] MHCEKABKGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int GDMKPCJDDGD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool HHJBFJAKHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x63DC270", Offset = "0x63DAA70", VA = "0x1863DC270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x63DEAB0", Offset = "0x63DD2B0", VA = "0x1863DEAB0")]
	public ABJCIMHBCLJ(byte[] MHCEKABKGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x63DEB10", Offset = "0x63DD310", VA = "0x1863DEB10")]
	public ABJCIMHBCLJ(byte[] MHCEKABKGED, int GDMKPCJDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x63DD340", Offset = "0x63DBB40", VA = "0x1863DD340")]
	private FADLMPDBGMJ IBLIJHBCJOD(string LHEMNDHOIFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x63DBB50", Offset = "0x63DA350", VA = "0x1863DBB50")]
	private FADLMPDBGMJ BELFEDEOAJH(string BKGEBGGPBLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63DE540", Offset = "0x63DCD40", VA = "0x1863DE540")]
	public void MIEDPHHGMIC(int GDMKPCJDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA60A0", VA = "0x180AA78A0")]
	public byte[] DLPGPODINBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1C420C0", Offset = "0x1C408C0", VA = "0x181C420C0")]
	public int IEOKOLABFPE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63DC290", Offset = "0x63DAA90", VA = "0x1863DC290")]
	public NPMHDAOHAJB EBBDBHNEJMA()
	{
		return default(NPMHDAOHAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x63DCF60", Offset = "0x63DB760", VA = "0x1863DCF60")]
	public void HFEDGEOFOCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x63DDB70", Offset = "0x63DC370", VA = "0x1863DDB70")]
	public bool JAOCMHDDIIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x63DBCD0", Offset = "0x63DA4D0", VA = "0x1863DBCD0")]
	public bool BLCPPJOJJLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x63DE350", Offset = "0x63DCB50", VA = "0x1863DE350")]
	public void KOKKPNMANDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x63DDA40", Offset = "0x63DC240", VA = "0x1863DDA40")]
	public bool IPNGCCEADPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x63DE470", Offset = "0x63DCC70", VA = "0x1863DE470")]
	public bool MEIIADJCBLJ(int EHGKBCBKPCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x63DE650", Offset = "0x63DCE50", VA = "0x1863DE650")]
	public bool PBEPFCGNDNE(int EHGKBCBKPCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x63DE720", Offset = "0x63DCF20", VA = "0x1863DE720")]
	public bool PFLBAFFMOKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x63DDAD0", Offset = "0x63DC2D0", VA = "0x1863DDAD0")]
	public void JAKEJJNDLKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x63DBF90", Offset = "0x63DA790", VA = "0x1863DBF90")]
	public bool DHGBOGDCGON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63DCE90", Offset = "0x63DB690", VA = "0x1863DCE90")]
	public bool GKHJDLOFCDB(int EHGKBCBKPCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x63DBE40", Offset = "0x63DA640", VA = "0x1863DBE40")]
	public bool CDLMLLDLOLI(int EHGKBCBKPCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x63DE550", Offset = "0x63DCD50", VA = "0x1863DE550")]
	public bool NANJLDNADCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x63DE040", Offset = "0x63DC840", VA = "0x1863DE040")]
	public void KDAPKMLFOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x63DBC40", Offset = "0x63DA440", VA = "0x1863DBC40")]
	public bool BIDCKHOFNIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x63DDC90", Offset = "0x63DC490", VA = "0x1863DDC90")]
	public void JCAIMLPDPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x63DC440", Offset = "0x63DAC40", VA = "0x1863DC440")]
	private void FCENGEFFLGP([Out] byte[] AGMKAGMJICL, [Out] int MOJAHCODPPL, [Out] int JAPDLFGOLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x63DD990", Offset = "0x63DC190", VA = "0x1863DD990")]
	private static int IKANEJMHLGB(char EOFAJFKEBLN, char DNOEGKBPKDC, char HCJCBMCLKPJ, char CLPHKIKLHHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x63DBA70", Offset = "0x63DA270", VA = "0x1863DBA70")]
	private static int AOIGPMMBIEB(char IILAPOMEGLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x63DE7B0", Offset = "0x63DCFB0", VA = "0x1863DE7B0")]
	public ArraySegment<byte> PHAHFNLGNEF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x63DBD60", Offset = "0x63DA560", VA = "0x1863DBD60")]
	public string CCBPEKHMLCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x63DE5E0", Offset = "0x63DCDE0", VA = "0x1863DE5E0")]
	public string OAIIJPJICKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x63DB850", Offset = "0x63DA050", VA = "0x1863DB850")]
	public ArraySegment<byte> ALGEHKDGBPD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x63DE2E0", Offset = "0x63DCAE0", VA = "0x1863DE2E0")]
	public ArraySegment<byte> KOGADHANAEL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x63DC020", Offset = "0x63DA820", VA = "0x1863DC020")]
	public bool DKNLMKHOKDE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x63DDD30", Offset = "0x63DC530", VA = "0x1863DDD30")]
	private static bool JGNILMKNOPP(byte HCJCBMCLKPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x63DDDF0", Offset = "0x63DC5F0", VA = "0x1863DDDF0")]
	private void JIHJBCCHDNM(NPMHDAOHAJB KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x63DCCE0", Offset = "0x63DB4E0", VA = "0x1863DCCE0")]
	public void FLKGEIPLOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x63DCD30", Offset = "0x63DB530", VA = "0x1863DCD30")]
	private void GDAGGNOLKIO(int PMOOAOAOMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x63DCC60", Offset = "0x63DB460", VA = "0x1863DCC60")]
	public sbyte FDGGGFMCDJJ()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x63DBF10", Offset = "0x63DA710", VA = "0x1863DBF10")]
	public short DBBPIDEGPDH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x63DB7D0", Offset = "0x63D9FD0", VA = "0x1863DB7D0")]
	public int AHCDLHFGEFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x63DE8D0", Offset = "0x63DD0D0", VA = "0x1863DE8D0")]
	public long PPOKMLDGNLH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x63DD2C0", Offset = "0x63DBAC0", VA = "0x1863DD2C0")]
	public byte IADJMNDEDNB()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x63DCBE0", Offset = "0x63DB3E0", VA = "0x1863DCBE0")]
	public ushort FCGFAEFHBGD()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x63DE3F0", Offset = "0x63DCBF0", VA = "0x1863DE3F0")]
	public uint LAIHDOHFKLD()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63DD200", Offset = "0x63DBA00", VA = "0x1863DD200")]
	public ulong HPDIPCLNJJI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x63DE1E0", Offset = "0x63DC9E0", VA = "0x1863DE1E0")]
	public float KMPLLPGCIEH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x63DE0E0", Offset = "0x63DC8E0", VA = "0x1863DE0E0")]
	public double KHIPCDDHPIN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x63DD890", Offset = "0x63DC090", VA = "0x1863DD890")]
	public ArraySegment<byte> IFIIADDGDPH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x63DD090", Offset = "0x63DB890", VA = "0x1863DD090")]
	private static int HGIKEIDJJJO(byte[] MHCEKABKGED, int GDMKPCJDDGD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FADLMPDBGMJ : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference MMCBMMIDNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int AFAAHPNHKKB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int DICPGLIBNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAE1320", Offset = "0xADFB20", VA = "0x180AE1320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string HMFFIFHDMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8A3700", Offset = "0x8A1F00", VA = "0x1808A3700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x63E1DD0", Offset = "0x63E05D0", VA = "0x1863E1DD0")]
	public FADLMPDBGMJ(string BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x63E1CE0", Offset = "0x63E04E0", VA = "0x1863E1CE0")]
	public FADLMPDBGMJ(string BKGEBGGPBLH, byte[] KJMFAPDHBNL, int GDMKPCJDDGD, int AFAAHPNHKKB, string GGGIKDDHMFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MKPJLJBLEHF
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class KBOEBKIDEBN
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] NEJFCHMJPKN;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63F0AA0", Offset = "0x63EF2A0", VA = "0x1863F0AA0")]
		public static byte[] GCCJCJJLILN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class NLBDKILNOFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void PANOPDLKEKF(LDODEOAPOMB MCLDKNNIMFL, object FKKGMPDEPMA, CBBFEPDHKGO IMGHMGOANOH);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object DKFIMCBFGGL(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO IMGHMGOANOH);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class IKOOBHFNHGE
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class HEIFNFFAOLM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
				public HEIFNFFAOLM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x4898C70", Offset = "0x4897470", VA = "0x184898C70")]
				internal bool PBAPGBFDIBE(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x63E2520", Offset = "0x63E0D20", VA = "0x1863E2520")]
				internal bool ANJMMBBDDBE(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, CBBFEPDHKGO, byte[]> FNEILBJKCPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, CBBFEPDHKGO> CBDMLLGELFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly PANOPDLKEKF PLEELIBEOPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, CBBFEPDHKGO, ArraySegment<byte>> AEONNFMCDKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, CBBFEPDHKGO, string> GOFEBFIMMNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, CBBFEPDHKGO, object> BEBOEOPEEMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, CBBFEPDHKGO, object> BBJAONEPING;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, CBBFEPDHKGO, object> AHLJBBIMLBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly DKFIMCBFGGL GPKEGLPEGLH;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x63E5540", Offset = "0x63E3D40", VA = "0x1863E5540")]
			public IKOOBHFNHGE(Type GFGNPBCFEMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x296BE40", Offset = "0x296A640", VA = "0x18296BE40")]
			private static T EBKMHOCPJGE<T>(DynamicMethod NCCPHOEGLGO)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x63E52F0", Offset = "0x63E3AF0", VA = "0x1863E52F0")]
			private static MethodInfo ICMFGHPKMIO(Type GFGNPBCFEMC, string HNHMJGCODBA, Type[] PKBINOLOKJP)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, IKOOBHFNHGE> JGBOMHDFFPN;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly IBKOFOPCOOH<IKOOBHFNHGE> NFKGMMFHCHC;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63F5B90", Offset = "0x63F4390", VA = "0x1863F5B90")]
		static NLBDKILNOFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x63F5B10", Offset = "0x63F4310", VA = "0x1863F5B10")]
		private static IKOOBHFNHGE FJJADKGFDGM(Type GFGNPBCFEMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63F5880", Offset = "0x63F4080", VA = "0x1863F5880")]
		public static void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, object FKKGMPDEPMA, CBBFEPDHKGO IMGHMGOANOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x63F5A00", Offset = "0x63F4200", VA = "0x1863F5A00")]
		public static void BBOAPHOFBBK(Type GFGNPBCFEMC, LDODEOAPOMB MCLDKNNIMFL, object FKKGMPDEPMA, CBBFEPDHKGO IMGHMGOANOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static CBBFEPDHKGO NHPCFGLDJHI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] DFGFFGGCNPD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] EFHFICFDOPP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static CBBFEPDHKGO HHEDGLHNDCP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x63F4320", Offset = "0x63F2B20", VA = "0x1863F4320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool PODDKBEPHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x63F3DF0", Offset = "0x63F25F0", VA = "0x1863F3DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x63F3D80", Offset = "0x63F2580", VA = "0x1863F3D80")]
	public static void DKEJDJNLMPF(CBBFEPDHKGO IMGHMGOANOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2450400", Offset = "0x244EC00", VA = "0x182450400")]
	public static byte[] BBOAPHOFBBK<T>(T CBBCDNDPNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x244FF40", Offset = "0x244E740", VA = "0x18244FF40")]
	public static byte[] BBOAPHOFBBK<T>(T FKKGMPDEPMA, CBBFEPDHKGO IMGHMGOANOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2450370", Offset = "0x244EB70", VA = "0x182450370")]
	public static void BBOAPHOFBBK<T>(LDODEOAPOMB MCLDKNNIMFL, T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2450200", Offset = "0x244EA00", VA = "0x182450200")]
	public static void BBOAPHOFBBK<T>(LDODEOAPOMB MCLDKNNIMFL, T FKKGMPDEPMA, CBBFEPDHKGO IMGHMGOANOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x24502E0", Offset = "0x244EAE0", VA = "0x1824502E0")]
	public static void BBOAPHOFBBK<T>(Stream NFDLBBEFMPJ, T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x24500C0", Offset = "0x244E8C0", VA = "0x1824500C0")]
	public static void BBOAPHOFBBK<T>(Stream NFDLBBEFMPJ, T FKKGMPDEPMA, CBBFEPDHKGO IMGHMGOANOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2450480", Offset = "0x244EC80", VA = "0x182450480")]
	public static ArraySegment<byte> HOMGHNAMIAP<T>(T CBBCDNDPNHF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2450510", Offset = "0x244ED10", VA = "0x182450510")]
	public static ArraySegment<byte> HOMGHNAMIAP<T>(T FKKGMPDEPMA, CBBFEPDHKGO IMGHMGOANOH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x24506A0", Offset = "0x244EEA0", VA = "0x1824506A0")]
	public static string KJJPHAMJCAM<T>(T FKKGMPDEPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2450720", Offset = "0x244EF20", VA = "0x182450720")]
	public static string KJJPHAMJCAM<T>(T FKKGMPDEPMA, CBBFEPDHKGO IMGHMGOANOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2451BF0", Offset = "0x24503F0", VA = "0x182451BF0")]
	public static T PFKIHJFLILM<T>(string JAOEPKAEICN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24518E0", Offset = "0x24500E0", VA = "0x1824518E0")]
	public static T PFKIHJFLILM<T>(string JAOEPKAEICN, CBBFEPDHKGO IMGHMGOANOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x24521A0", Offset = "0x24509A0", VA = "0x1824521A0")]
	public static T PFKIHJFLILM<T>(byte[] MHCEKABKGED)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2451B60", Offset = "0x2450360", VA = "0x182451B60")]
	public static T PFKIHJFLILM<T>(byte[] MHCEKABKGED, CBBFEPDHKGO IMGHMGOANOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2452110", Offset = "0x2450910", VA = "0x182452110")]
	public static T PFKIHJFLILM<T>(byte[] MHCEKABKGED, int GDMKPCJDDGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x24519D0", Offset = "0x24501D0", VA = "0x1824519D0")]
	public static T PFKIHJFLILM<T>(byte[] MHCEKABKGED, int GDMKPCJDDGD, CBBFEPDHKGO IMGHMGOANOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2451D00", Offset = "0x2450500", VA = "0x182451D00")]
	public static T PFKIHJFLILM<T>(ABJCIMHBCLJ OGNANCFBCDL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2451D80", Offset = "0x2450580", VA = "0x182451D80")]
	public static T PFKIHJFLILM<T>(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO IMGHMGOANOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2451E50", Offset = "0x2450650", VA = "0x182451E50")]
	public static T PFKIHJFLILM<T>(Stream NFDLBBEFMPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2452220", Offset = "0x2450A20", VA = "0x182452220")]
	public static T PFKIHJFLILM<T>(Stream NFDLBBEFMPJ, CBBFEPDHKGO IMGHMGOANOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x63F4080", Offset = "0x63F2880", VA = "0x1863F4080")]
	public static string HEIDHLAMFAM(byte[] JAOEPKAEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x63F41E0", Offset = "0x63F29E0", VA = "0x1863F41E0")]
	public static string HEIDHLAMFAM(byte[] JAOEPKAEICN, int GDMKPCJDDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x63F3EF0", Offset = "0x63F26F0", VA = "0x1863F3EF0")]
	public static string HEIDHLAMFAM(string JAOEPKAEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x63F4570", Offset = "0x63F2D70", VA = "0x1863F4570")]
	public static byte[] OGFACHBFPAK(byte[] JAOEPKAEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x63F4420", Offset = "0x63F2C20", VA = "0x1863F4420")]
	public static byte[] OGFACHBFPAK(byte[] JAOEPKAEICN, int GDMKPCJDDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x63F46F0", Offset = "0x63F2EF0", VA = "0x1863F46F0")]
	public static byte[] OGFACHBFPAK(string JAOEPKAEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x63F34B0", Offset = "0x63F1CB0", VA = "0x1863F34B0")]
	private static void ALGFMBODLAM(ABJCIMHBCLJ OGNANCFBCDL, LDODEOAPOMB MCLDKNNIMFL, int IGMBNCEJALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x63F3E50", Offset = "0x63F2650", VA = "0x1863F3E50")]
	private static int GJAPFAOBLOI(Stream EIGOIPKAPOI, byte[] NEJFCHMJPKN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum NPMHDAOHAJB : byte
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
public struct LDODEOAPOMB
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] MKHBKKIGBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] NEJFCHMJPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int GDMKPCJDDGD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DJBIKKBPLON
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1C420C0", Offset = "0x1C408C0", VA = "0x181C420C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x63DE540", Offset = "0x63DCD40", VA = "0x1863DE540")]
	public void MIEDPHHGMIC(int GDMKPCJDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x63F2750", Offset = "0x63F0F50", VA = "0x1863F2750")]
	public static byte[] FKBMCMCKDIF(string IACPFKBCIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x63F2140", Offset = "0x63F0940", VA = "0x1863F2140")]
	public static byte[] EIMKPNLKIEG(string IACPFKBCIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x63F2B20", Offset = "0x63F1320", VA = "0x1863F2B20")]
	public static byte[] KLIDPMBHGNK(string IACPFKBCIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x63F2530", Offset = "0x63F0D30", VA = "0x1863F2530")]
	public static byte[] FFDHKLGEGDL(string IACPFKBCIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x526F590", Offset = "0x526DD90", VA = "0x18526F590")]
	public LDODEOAPOMB(byte[] EJPBNHBNMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x63F2880", Offset = "0x63F1080", VA = "0x1863F2880")]
	public ArraySegment<byte> GCCJCJJLILN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x63F2C90", Offset = "0x63F1490", VA = "0x1863F2C90")]
	public byte[] NAKAEGKDAOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x63F3300", Offset = "0x63F1B00", VA = "0x1863F3300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x63F31D0", Offset = "0x63F19D0", VA = "0x1863F31D0")]
	public void PIGGKMPBDKN(int LEJMPFIPEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x63F3170", Offset = "0x63F1970", VA = "0x1863F3170")]
	public void PEAHPLKIGBB(byte HBJKHODEMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x63F3110", Offset = "0x63F1910", VA = "0x1863F3110")]
	public void PEAHPLKIGBB(byte[] HBJKHODEMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x63F2480", Offset = "0x63F0C80", VA = "0x1863F2480")]
	public void FENLKALBCEF(byte HBJKHODEMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x63F2000", Offset = "0x63F0800", VA = "0x1863F2000")]
	public void BNGHEJDFJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x63F2920", Offset = "0x63F1120", VA = "0x1863F2920")]
	public void GIGPGDKCOIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x63F3090", Offset = "0x63F1890", VA = "0x1863F3090")]
	public void OMKGPDCCACF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x63F2050", Offset = "0x63F0850", VA = "0x1863F2050")]
	public void CGHABINFAGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x63F2700", Offset = "0x63F0F00", VA = "0x1863F2700")]
	public void FINNJMPFBGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x63F2970", Offset = "0x63F1170", VA = "0x1863F2970")]
	public void HBGGGPBEFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x63F1EF0", Offset = "0x63F06F0", VA = "0x1863F1EF0")]
	public void BDHELMAMHEL(string IACPFKBCIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x63F26B0", Offset = "0x63F0EB0", VA = "0x1863F26B0")]
	public void FIELPPPPBBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x63F31E0", Offset = "0x63F19E0", VA = "0x1863F31E0")]
	public void PKFBPCNNALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x63F2320", Offset = "0x63F0B20", VA = "0x1863F2320")]
	public void FBKIHNBGABP(bool FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x63F29C0", Offset = "0x63F11C0", VA = "0x1863F29C0")]
	public void HDPNAJKMCJM(float FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x63F3280", Offset = "0x63F1A80", VA = "0x1863F3280")]
	public void PMFGCMPOFCD(double FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x63F24C0", Offset = "0x63F0CC0", VA = "0x1863F24C0")]
	public void FFCJHJDPDEM(byte FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x63F22B0", Offset = "0x63F0AB0", VA = "0x1863F22B0")]
	public void ELLPGEFHEAF(ushort FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x63F1F90", Offset = "0x63F0790", VA = "0x1863F1F90")]
	public void BLCHDHABKBB(uint FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x63F2110", Offset = "0x63F0910", VA = "0x1863F2110")]
	public void EIAMHLINFNE(ulong FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x63F2A40", Offset = "0x63F1240", VA = "0x1863F2A40")]
	public void HJOLFNBPDNC(sbyte FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x63F20A0", Offset = "0x63F08A0", VA = "0x1863F20A0")]
	public void DMMLOFKGNBG(short FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x63F2AB0", Offset = "0x63F12B0", VA = "0x1863F2AB0")]
	public void HLAAKDBCCHI(int FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x63F30E0", Offset = "0x63F18E0", VA = "0x1863F30E0")]
	public void PDIKPKBJOHA(long FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x63F2D00", Offset = "0x63F1500", VA = "0x1863F2D00")]
	public void NECIKPEDNKH(string FKKGMPDEPMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OEEBOMCDKBJ : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class OMOOOHKGCMC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3CF2C60", Offset = "0x3CF1460", VA = "0x183CF2C60")]
		static OMOOOHKGCMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private OEEBOMCDKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class HPCOEIKHIGA
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> JBEKAPMJBKK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x63E4E00", Offset = "0x63E3600", VA = "0x1863E4E00")]
	static HPCOEIKHIGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x63E4610", Offset = "0x63E2E10", VA = "0x1863E4610")]
	internal static object MBCGOIMPMDC(Type INGJCJMKCCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class JPEGBHANLGE : GGKCAJABCKP<Vector2>, JFICJNJNNFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EHECHPMAAOM OCACKGFGJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] OOMNJMPHCML;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x63F0750", Offset = "0x63EEF50", VA = "0x1863F0750")]
	public JPEGBHANLGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x63F0270", Offset = "0x63EEA70", VA = "0x1863F0270", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, Vector2 FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x63F0460", Offset = "0x63EEC60", VA = "0x1863F0460", Slot = "5")]
	public Vector2 PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class KJPCNECMBMH : GGKCAJABCKP<Vector3>, JFICJNJNNFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly EHECHPMAAOM OCACKGFGJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] OOMNJMPHCML;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x63F12A0", Offset = "0x63EFAA0", VA = "0x1863F12A0")]
	public KJPCNECMBMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x63F0CB0", Offset = "0x63EF4B0", VA = "0x1863F0CB0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, Vector3 FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x63F0F50", Offset = "0x63EF750", VA = "0x1863F0F50", Slot = "5")]
	public Vector3 PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class PAENGOJLBOO : GGKCAJABCKP<Vector4>, JFICJNJNNFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly EHECHPMAAOM OCACKGFGJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] OOMNJMPHCML;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x63F8180", Offset = "0x63F6980", VA = "0x1863F8180")]
	public PAENGOJLBOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x63F7AB0", Offset = "0x63F62B0", VA = "0x1863F7AB0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, Vector4 FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x63F7DF0", Offset = "0x63F65F0", VA = "0x1863F7DF0", Slot = "5")]
	public Vector4 PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JIDFOMKNLNH : GGKCAJABCKP<Quaternion>, JFICJNJNNFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly EHECHPMAAOM OCACKGFGJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] OOMNJMPHCML;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x63E7BA0", Offset = "0x63E63A0", VA = "0x1863E7BA0")]
	public JIDFOMKNLNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x63E74D0", Offset = "0x63E5CD0", VA = "0x1863E74D0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, Quaternion FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x63E7810", Offset = "0x63E6010", VA = "0x1863E7810", Slot = "5")]
	public Quaternion PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class NDPLCNEMDED : GGKCAJABCKP<Color>, JFICJNJNNFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly EHECHPMAAOM OCACKGFGJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] OOMNJMPHCML;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x63F5590", Offset = "0x63F3D90", VA = "0x1863F5590")]
	public NDPLCNEMDED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x63F4EC0", Offset = "0x63F36C0", VA = "0x1863F4EC0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, Color FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x63F5200", Offset = "0x63F3A00", VA = "0x1863F5200", Slot = "5")]
	public Color PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class LDCGGBFEGFI : GGKCAJABCKP<Bounds>, JFICJNJNNFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly EHECHPMAAOM OCACKGFGJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] OOMNJMPHCML;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x63F1D10", Offset = "0x63F0510", VA = "0x1863F1D10")]
	public LDCGGBFEGFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x63F1610", Offset = "0x63EFE10", VA = "0x1863F1610", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, Bounds FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x63F1930", Offset = "0x63F0130", VA = "0x1863F1930", Slot = "5")]
	public Bounds PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class CNIIGEKDEKF : GGKCAJABCKP<Rect>, JFICJNJNNFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly EHECHPMAAOM OCACKGFGJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] OOMNJMPHCML;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x63DF760", Offset = "0x63DDF60", VA = "0x1863DF760")]
	public CNIIGEKDEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x63DF000", Offset = "0x63DD800", VA = "0x1863DF000", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, Rect FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x63DF370", Offset = "0x63DDB70", VA = "0x1863DF370", Slot = "5")]
	public Rect PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class GPCLNBDILCL : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private static class GMAOEMNLOPO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x34F1650", Offset = "0x34EFE50", VA = "0x1834F1650")]
		static GMAOEMNLOPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private GPCLNBDILCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class DDAHPPPGMFN : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private static class OJCNOHNIMMB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3CE6690", Offset = "0x3CE4E90", VA = "0x183CE6690")]
		static OJCNOHNIMMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class DAGIOPDIBGA
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> EGCAKIMHKCG;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x63DFA50", Offset = "0x63DE250", VA = "0x1863DFA50")]
		internal static object MBCGOIMPMDC(Type INGJCJMKCCN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private DDAHPPPGMFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class GALEGMKHKPM : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class ACLICMMPKBK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3494A60", Offset = "0x3493260", VA = "0x183494A60")]
		static ACLICMMPKBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GALEGMKHKPM FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool GJKMGENLCIA;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static JFICJNJNNFJ[] PGPEEGKEBCC;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static CBBFEPDHKGO[] IODHDOBPINL;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private GALEGMKHKPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x63E1F10", Offset = "0x63E0710", VA = "0x1863E1F10")]
	public static void NJMEIPIEAKJ(params CBBFEPDHKGO[] IODHDOBPINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x63E1E30", Offset = "0x63E0630", VA = "0x1863E1E30")]
	public static void NJMEIPIEAKJ(params JFICJNJNNFJ[] PGPEEGKEBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x63E1FF0", Offset = "0x63E07F0", VA = "0x1863E1FF0")]
	public static void PMCBPCEOAPA(JFICJNJNNFJ[] PGPEEGKEBCC, CBBFEPDHKGO[] IODHDOBPINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class BJANCPENOMA : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private static class EHFPDGDIDHA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x306FDB0", Offset = "0x306E5B0", VA = "0x18306FDB0")]
		static EHFPDGDIDHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private BJANCPENOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class ILABJIBIMHC
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly CBBFEPDHKGO MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly CBBFEPDHKGO AMFCMBCHBEG;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly CBBFEPDHKGO HALFGOIMDDE;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly CBBFEPDHKGO HGGLNGAIFPH;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly CBBFEPDHKGO JKEPOFBDGDO;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly CBBFEPDHKGO LOIJIHFEEOK;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly CBBFEPDHKGO EKKHPOOAOJK;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly CBBFEPDHKGO LDNDHIAENLF;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly CBBFEPDHKGO NDNAAOFEONJ;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly CBBFEPDHKGO KFDJOGOLBLD;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly CBBFEPDHKGO IHDAOFNLAFM;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly CBBFEPDHKGO HLBBIIFLPGG;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class MFDFPJHMHJG
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly CBBFEPDHKGO MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly CBBFEPDHKGO GHMJNJKOGID;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class MLHEEHEGPGB
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly CBBFEPDHKGO MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly CBBFEPDHKGO AMFCMBCHBEG;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly CBBFEPDHKGO HALFGOIMDDE;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly CBBFEPDHKGO HGGLNGAIFPH;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly CBBFEPDHKGO JKEPOFBDGDO;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly CBBFEPDHKGO LOIJIHFEEOK;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly CBBFEPDHKGO EKKHPOOAOJK;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly CBBFEPDHKGO LDNDHIAENLF;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly CBBFEPDHKGO NDNAAOFEONJ;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly CBBFEPDHKGO KFDJOGOLBLD;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly CBBFEPDHKGO IHDAOFNLAFM;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly CBBFEPDHKGO HLBBIIFLPGG;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class HLMOGPGHCCG
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> EGCAKIMHKCG;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x63E2920", Offset = "0x63E1120", VA = "0x1863E2920")]
	internal static object MBCGOIMPMDC(Type INGJCJMKCCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x63E4080", Offset = "0x63E2880", VA = "0x1863E4080")]
	private static object MFMKEGDHCGC(Type IGBOJGPLDOM, Type[] PHBPKGMIGDC, params object[] PKBINOLOKJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class KBFPDGJKHHK : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class JCHIAJHDJBD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x37E6220", Offset = "0x37E4A20", VA = "0x1837E6220")]
		static JCHIAJHDJBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> KFPAEIFGGFI;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool HOGEPHIBCMO;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly OINNHIINLDE OAIDBNCFJND;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x63F0930", Offset = "0x63EF130", VA = "0x1863F0930")]
	static KBFPDGJKHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private KBFPDGJKHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class CEMLBPEGDHJ : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class NKINDMDDDDB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3BF02C0", Offset = "0x3BEEAC0", VA = "0x183BF02C0")]
		static NKINDMDDDDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> KFPAEIFGGFI;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool HOGEPHIBCMO;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly OINNHIINLDE OAIDBNCFJND;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x63DEE60", Offset = "0x63DD660", VA = "0x1863DEE60")]
	static CEMLBPEGDHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private CEMLBPEGDHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class KDGICOOGNAF : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class AANLABCFNIN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x34819F0", Offset = "0x34801F0", VA = "0x1834819F0")]
		static AANLABCFNIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> KFPAEIFGGFI;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool HOGEPHIBCMO;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly OINNHIINLDE OAIDBNCFJND;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x63F0B40", Offset = "0x63EF340", VA = "0x1863F0B40")]
	static KDGICOOGNAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private KDGICOOGNAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class BBADMGHJOAI : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class JMBACCDCODL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x381F080", Offset = "0x381D880", VA = "0x18381F080")]
		static JMBACCDCODL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> KFPAEIFGGFI;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool HOGEPHIBCMO;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly OINNHIINLDE OAIDBNCFJND;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x63DEC70", Offset = "0x63DD470", VA = "0x1863DEC70")]
	static BBADMGHJOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private BBADMGHJOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class EBLDLEOBCHB : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class CLPAPFKKHJF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4B73FD0", Offset = "0x4B727D0", VA = "0x184B73FD0")]
		static CLPAPFKKHJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> KFPAEIFGGFI;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool HOGEPHIBCMO;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly OINNHIINLDE OAIDBNCFJND;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x63E1900", Offset = "0x63E0100", VA = "0x1863E1900")]
	static EBLDLEOBCHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private EBLDLEOBCHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class EIFJMMHBNCE : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class MGGMHBOICIC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4C40", Offset = "0x3AF3440", VA = "0x183AF4C40")]
		static MGGMHBOICIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> KFPAEIFGGFI;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool HOGEPHIBCMO;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly OINNHIINLDE OAIDBNCFJND;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x63E1B70", Offset = "0x63E0370", VA = "0x1863E1B70")]
	static EIFJMMHBNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private EIFJMMHBNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class EDDJODGNNKM : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class FHOHPLKHONM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3418080", Offset = "0x3416880", VA = "0x183418080")]
		static FHOHPLKHONM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> KFPAEIFGGFI;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool HOGEPHIBCMO;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public EDDJODGNNKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class GIDPACGKMKC : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private static class NHOLHHLMDKP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3BCA780", Offset = "0x3BC8F80", VA = "0x183BCA780")]
		static NHOLHHLMDKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> KFPAEIFGGFI;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool HOGEPHIBCMO;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public GIDPACGKMKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal sealed class HJBCHAFILPN : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private static class LOPHDOFPDJO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x392F470", Offset = "0x392DC70", VA = "0x18392F470")]
		static LOPHDOFPDJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> KFPAEIFGGFI;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool HOGEPHIBCMO;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public HJBCHAFILPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class KNLNIIBECNP : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private static class AIMBGDLFNGF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x35174E0", Offset = "0x3515CE0", VA = "0x1835174E0")]
		static AIMBGDLFNGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> KFPAEIFGGFI;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool HOGEPHIBCMO;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public KNLNIIBECNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class OOLIKDJBIAA : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private static class AJLFLCJMMAO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3529B20", Offset = "0x3528320", VA = "0x183529B20")]
		static AJLFLCJMMAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> KFPAEIFGGFI;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool HOGEPHIBCMO;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public OOLIKDJBIAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class JMEDIFIBOBB : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private static class OHLKIACOCBB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3CDA020", Offset = "0x3CD8820", VA = "0x183CDA020")]
		static OHLKIACOCBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> KFPAEIFGGFI;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool HOGEPHIBCMO;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JMEDIFIBOBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class JKMGAINDNPK
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct NFMFCAHBPBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public EGFBIFECPIM OKKKELKJJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder GPNPIELCGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder BGNCDACPGKD;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class NMNFHANLKGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class ELMIPAKGAKF
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo KLIDPMBHGNK;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo EIMKPNLKIEG;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo FFDHKLGEGDL;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo FKBMCMCKDIF;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo PKFBPCNNALL;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo PEAHPLKIGBB;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo OMKGPDCCACF;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo CGHABINFAGM;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo FINNJMPFBGD;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x63FD7C0", Offset = "0x63FBFC0", VA = "0x1863FD7C0")]
			static ELMIPAKGAKF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class ABMBOGJLCAH
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo JAOCMHDDIIN;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo JAKEJJNDLKF;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo GKHJDLOFCDB;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo EFHHKBBFPPL;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo FLKGEIPLOKJ;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo DLPGPODINBN;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo IEOKOLABFPE;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x63F8F60", Offset = "0x63F7760", VA = "0x1863F8F60")]
			static ABMBOGJLCAH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		internal static class KAPFLBIKEEN
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo GBOPONJMGGD;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo HIDJHNEJPBC;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo ICPHMKDKGNP;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo NMMHLAAIGJJ;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo LPNKMJOMKIN;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo JCLOCHDODEB;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo MCCALMPNPCE;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo LOBCMJHLGDG;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo CGDGODLGKOB;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo BGAKLCCOJAB;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo LKEMHBBKENC;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo GEPIOKDPGBB;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo OEAKBFBPIAF;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo JGJDMCEEJNN;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x63F5CE0", Offset = "0x63F44E0", VA = "0x1863F5CE0")]
		public static MethodInfo BBOAPHOFBBK(Type GFGNPBCFEMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x63F60A0", Offset = "0x63F48A0", VA = "0x1863F60A0")]
		public static MethodInfo PFKIHJFLILM(Type GFGNPBCFEMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x63F5F70", Offset = "0x63F4770", VA = "0x1863F5F70")]
		public static MethodInfo ECELPGJEOHM(Type GFGNPBCFEMC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class MELBLHMIFFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<EGFBIFECPIM, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public MELBLHMIFFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class CHOPLBLHBMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public MELBLHMIFFE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public CHOPLBLHBMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x63FB7F0", Offset = "0x63F9FF0", VA = "0x1863FB7F0")]
		internal void CPPHGDHLPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x63FB8F0", Offset = "0x63FA0F0", VA = "0x1863FB8F0")]
		internal bool DBHPBFAOAGB(int index, EGFBIFECPIM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class NBPEDLHBLKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public MELBLHMIFFE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public NBPEDLHBLKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x640CC90", Offset = "0x640B490", VA = "0x18640CC90")]
		internal bool MDGMFGHKBOP(int index, EGFBIFECPIM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class IMFHKIGGFLP
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

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public IMFHKIGGFLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x37E7110", Offset = "0x37E5910", VA = "0x1837E7110")]
		internal string JANMFNICOIN(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class CJDFCENNJEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public CJDFCENNJEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x63FBA50", Offset = "0x63FA250", VA = "0x1863FBA50")]
		internal bool GOOHGAEOFAC(EGFBIFECPIM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class MDIMJFLIPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public IMFHKIGGFLP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public MDIMJFLIPCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x640BC10", Offset = "0x640A410", VA = "0x18640BC10")]
		internal void NMLIECCEABG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x640BA30", Offset = "0x640A230", VA = "0x18640BA30")]
		internal bool HECCIGIKODM(int index, EGFBIFECPIM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class JCBBFGKJJAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public IMFHKIGGFLP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public JCBBFGKJJAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6406510", Offset = "0x6404D10", VA = "0x186406510")]
		internal bool EAIHIAGMPGP(int index, EGFBIFECPIM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class ILHNCKKFJMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ILHNCKKFJMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x63FB7C0", Offset = "0x63F9FC0", VA = "0x1863FB7C0")]
		internal Label JFDHHHMKNKB(EGFBIFECPIM _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class FLELNBPDFBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public NFMFCAHBPBA[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, EGFBIFECPIM, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public DMNKIOPNPOK argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public DMNKIOPNPOK argResolver;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public FLELNBPDFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x64001E0", Offset = "0x63FE9E0", VA = "0x1864001E0")]
		internal NFMFCAHBPBA ICEEAHDLLOD(EGFBIFECPIM item)
		{
			return default(NFMFCAHBPBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class DGCAAMCGPJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public FLELNBPDFBH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public DGCAAMCGPJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x63FBD40", Offset = "0x63FA540", VA = "0x1863FBD40")]
		internal void CGOAFONGALO(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x63FBFF0", Offset = "0x63FA7F0", VA = "0x1863FBFF0")]
		internal void MDDDHNJKNGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class BAAPBNJIJEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public EGFBIFECPIM item;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public BAAPBNJIJEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA75720", Offset = "0xA73F20", VA = "0x180A75720")]
		internal bool HLNJMAOCPBL(NFMFCAHBPBA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class BJPFLDDNLNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public EGFBIFECPIM item;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public BJPFLDDNLNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA75720", Offset = "0xA73F20", VA = "0x180A75720")]
		internal bool JIFBKEBDJNN(NFMFCAHBPBA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex FLAMKODICCL;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int EAGPBNJOCMM;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> DGAHDIPDOAP;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> KGNIHCKHDOJ;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x23DB0A0", Offset = "0x23D98A0", VA = "0x1823DB0A0")]
	public static object MLLANLGIBDD<T>(OINNHIINLDE OAIDBNCFJND, CBBFEPDHKGO JMGIKHBJNED, Func<string, string> KFPAEIFGGFI, bool HOGEPHIBCMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x23CD460", Offset = "0x23CBC60", VA = "0x1823CD460")]
	public static object KGOEBFKLMBF<T>(CBBFEPDHKGO JMGIKHBJNED, Func<string, string> KFPAEIFGGFI, bool HOGEPHIBCMO, bool IJMGONIPKOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x63E7E90", Offset = "0x63E6690", VA = "0x1863E7E90")]
	private static TypeInfo COAONAEELAD(OINNHIINLDE OAIDBNCFJND, Type GFGNPBCFEMC, Func<string, string> KFPAEIFGGFI, bool HOGEPHIBCMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x63ED8F0", Offset = "0x63EC0F0", VA = "0x1863ED8F0")]
	public static object NBGOHAFECIO(Type GFGNPBCFEMC, Func<string, string> KFPAEIFGGFI, bool HOGEPHIBCMO, bool IJMGONIPKOD, bool PDEPKCIECDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x63EB050", Offset = "0x63E9850", VA = "0x1863EB050")]
	private static Dictionary<EGFBIFECPIM, FieldInfo> EHJJDFDELHH(TypeBuilder DPAAAKJKGIM, CCKKGJGCMBK EEILNADBKNP, ConstructorInfo CMFAEPDMBCH, FieldBuilder PEPNHHJGJNA, ILGenerator GKPFODINCOM, bool HOGEPHIBCMO, bool PPMDAOLPEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x63E88B0", Offset = "0x63E70B0", VA = "0x1863E88B0")]
	private static Dictionary<EGFBIFECPIM, FieldInfo> DDJEEKMFFLJ(TypeBuilder DPAAAKJKGIM, CCKKGJGCMBK EEILNADBKNP, ILGenerator GKPFODINCOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x63EBD70", Offset = "0x63EA570", VA = "0x1863EBD70")]
	private static void GIFKNBCMDAO(Type GFGNPBCFEMC, CCKKGJGCMBK EEILNADBKNP, ILGenerator GKPFODINCOM, Action LIGCBBPFABD, Func<int, EGFBIFECPIM, bool> NOEMDIICIOH, bool HOGEPHIBCMO, bool PPMDAOLPEGB, int IHJGPAMKLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x63ED3B0", Offset = "0x63EBBB0", VA = "0x1863ED3B0")]
	private static void IPPJLCDPGNK(TypeInfo GFGNPBCFEMC, EGFBIFECPIM AFPGEGBCOGN, ILGenerator GKPFODINCOM, int LFEFGCGCIAG, Func<int, EGFBIFECPIM, bool> NOEMDIICIOH, DMNKIOPNPOK MCLDKNNIMFL, DMNKIOPNPOK MJKNGMHPDCK, DMNKIOPNPOK IHDLLIHHNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x63E9D20", Offset = "0x63E8520", VA = "0x1863E9D20")]
	private static void EHCAIBHDOBC(Type GFGNPBCFEMC, CCKKGJGCMBK EEILNADBKNP, ILGenerator GKPFODINCOM, Func<int, EGFBIFECPIM, bool> NOEMDIICIOH, bool HIJNEKHGJNL, int IHJGPAMKLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x63EB780", Offset = "0x63E9F80", VA = "0x1863EB780")]
	private static void FAOCNEHDJEB(ILGenerator GKPFODINCOM, NFMFCAHBPBA EEILNADBKNP, int LFEFGCGCIAG, Func<int, EGFBIFECPIM, bool> NOEMDIICIOH, DMNKIOPNPOK OGNANCFBCDL, DMNKIOPNPOK IHDLLIHHNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x63E8F90", Offset = "0x63E7790", VA = "0x1863E8F90")]
	private static LocalBuilder EFOIPJOBICP(ILGenerator GKPFODINCOM, Type GFGNPBCFEMC, CCKKGJGCMBK EEILNADBKNP, NFMFCAHBPBA[] ADIJDLEKDKM, bool FFPOCFDIEEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x63EF420", Offset = "0x63EDC20", VA = "0x1863EF420")]
	private static bool PJBEHLLCMLH(ConstructorInfo OGAIBHBCPFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x63EBBF0", Offset = "0x63EA3F0", VA = "0x1863EBBF0")]
	private static bool GDKDALLIAKH(Type GFGNPBCFEMC, [Out] Type LEJJLHNHFMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate void DOKJNKNJAHM<T>(byte[][] PEPNHHJGJNA, object[] BCCBNHIAGAB, LDODEOAPOMB MCLDKNNIMFL, T FKKGMPDEPMA, CBBFEPDHKGO IMGHMGOANOH);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal delegate T CKDFBGGBNLD<T>(object[] BCCBNHIAGAB, ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO IMGHMGOANOH);
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class OLKJHLHKOEB<T> : GGKCAJABCKP<T>, JFICJNJNNFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] PEPNHHJGJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] PFKFOGEPLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] KMNLINLMBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly DOKJNKNJAHM<T> FMKJAGDENDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly CKDFBGGBNLD<T> BCKFDECCCGA;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1C126D0", Offset = "0x1C10ED0", VA = "0x181C126D0")]
	public OLKJHLHKOEB(byte[][] PEPNHHJGJNA, object[] PFKFOGEPLHC, object[] KMNLINLMBMD, DOKJNKNJAHM<T> FMKJAGDENDM, CKDFBGGBNLD<T> BCKFDECCCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3CECCA0", Offset = "0x3CEB4A0", VA = "0x183CECCA0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, T FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3CECD90", Offset = "0x3CEB590", VA = "0x183CECD90", Slot = "5")]
	public T PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class DDCNEKOCAGG : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private static class PMELNAPBAOP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD850", Offset = "0x3DBC050", VA = "0x183DBD850")]
		static PMELNAPBAOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private DDCNEKOCAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class IMLPBCLCMEE : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private static class CGHJCDJEPEK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4AC21B0", Offset = "0x4AC09B0", VA = "0x184AC21B0")]
		static CGHJCDJEPEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private IMLPBCLCMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal static class AAMJLEEKPOH
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly CBBFEPDHKGO[] NPCBJHBBOGB;
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class GIDFOCEJDFO : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class LBAJIBAPKDO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3908C10", Offset = "0x3907410", VA = "0x183908C10")]
		static LBAJIBAPKDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class BAPGGJMMICM : CBBFEPDHKGO
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		private static class HGIHHIGAPPH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x357F340", Offset = "0x357DB40", VA = "0x18357F340")]
			static HGIHHIGAPPH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly CBBFEPDHKGO FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly CBBFEPDHKGO[] IODHDOBPINL;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		private BAPGGJMMICM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
		public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly GGKCAJABCKP<object> GGLCADCNKGP;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private GIDFOCEJDFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class MNNHODFFLLA : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private static class IDIDCEODPDJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x36285D0", Offset = "0x3626DD0", VA = "0x1836285D0")]
		static IDIDCEODPDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class GMNMFAADBFP : CBBFEPDHKGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		private static class MJGNLCLIELA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3B1D370", Offset = "0x3B1BB70", VA = "0x183B1D370")]
			static MJGNLCLIELA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly CBBFEPDHKGO FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly CBBFEPDHKGO[] IODHDOBPINL;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		private GMNMFAADBFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
		public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly GGKCAJABCKP<object> GGLCADCNKGP;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private MNNHODFFLLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class OOPPNAOKJBI : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private static class HLNOMFBAOHG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x359B8F0", Offset = "0x359A0F0", VA = "0x18359B8F0")]
		static HLNOMFBAOHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class LEOJBCLDMKA : CBBFEPDHKGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private static class BALMPGOKGBC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x43E20D0", Offset = "0x43E08D0", VA = "0x1843E20D0")]
			static BALMPGOKGBC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly CBBFEPDHKGO FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly CBBFEPDHKGO[] IODHDOBPINL;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		private LEOJBCLDMKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
		public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly GGKCAJABCKP<object> GGLCADCNKGP;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private OOPPNAOKJBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal sealed class DMODJCNGANF : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private static class HGJCEEOOKAN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3584330", Offset = "0x3582B30", VA = "0x183584330")]
		static HGJCEEOOKAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class MDEMKOFONFP : CBBFEPDHKGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		private static class MIIJMMOPDNP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3B15E40", Offset = "0x3B14640", VA = "0x183B15E40")]
			static MIIJMMOPDNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly CBBFEPDHKGO FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly CBBFEPDHKGO[] IODHDOBPINL;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		private MDEMKOFONFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
		public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly GGKCAJABCKP<object> GGLCADCNKGP;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private DMODJCNGANF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class DIEJDMPEHDK : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private static class PIKGMOHCAOK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3DB4CC0", Offset = "0x3DB34C0", VA = "0x183DB4CC0")]
		static PIKGMOHCAOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class PFIEIOKKOBI : CBBFEPDHKGO
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		private static class KKNEMGJMJIF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x387E800", Offset = "0x387D000", VA = "0x18387E800")]
			static KKNEMGJMJIF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly CBBFEPDHKGO FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly CBBFEPDHKGO[] IODHDOBPINL;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		private PFIEIOKKOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
		public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly GGKCAJABCKP<object> GGLCADCNKGP;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private DIEJDMPEHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class MGPEAFOJHML : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private static class HCHIIOFDKEF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x356A260", Offset = "0x3568A60", VA = "0x18356A260")]
		static HCHIIOFDKEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private sealed class MEKJEBIGLKF : CBBFEPDHKGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		private static class ILPJIOLIPOM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x36526B0", Offset = "0x3650EB0", VA = "0x1836526B0")]
			static ILPJIOLIPOM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly CBBFEPDHKGO FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly CBBFEPDHKGO[] IODHDOBPINL;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		private MEKJEBIGLKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
		public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly GGKCAJABCKP<object> GGLCADCNKGP;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private MGPEAFOJHML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal sealed class PICAFIGFAIJ : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private static class DPDHFDCDLME<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4D25DF0", Offset = "0x4D245F0", VA = "0x184D25DF0")]
		static DPDHFDCDLME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private sealed class DHIIDMELPDK : CBBFEPDHKGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		private static class MIMGMLPBPJP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3B18F20", Offset = "0x3B17720", VA = "0x183B18F20")]
			static MIMGMLPBPJP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly CBBFEPDHKGO FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly CBBFEPDHKGO[] IODHDOBPINL;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		private DHIIDMELPDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
		public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly GGKCAJABCKP<object> GGLCADCNKGP;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private PICAFIGFAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal sealed class ILIDECODBMN : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private static class BNCECIJMEID<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x47C6090", Offset = "0x47C4890", VA = "0x1847C6090")]
		static BNCECIJMEID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private sealed class NCAGEDNIFBA : CBBFEPDHKGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private static class IJECCDCIHHM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3643F80", Offset = "0x3642780", VA = "0x183643F80")]
			static IJECCDCIHHM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly CBBFEPDHKGO FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly CBBFEPDHKGO[] IODHDOBPINL;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		private NCAGEDNIFBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
		public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly GGKCAJABCKP<object> GGLCADCNKGP;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private ILIDECODBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal sealed class NDFOJEEJCMB : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private static class NFPJPGLEIEA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3BB22B0", Offset = "0x3BB0AB0", VA = "0x183BB22B0")]
		static NFPJPGLEIEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private sealed class BMFFFPPPOHN : CBBFEPDHKGO
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		private static class CLMALLMNENF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x4B70B50", Offset = "0x4B6F350", VA = "0x184B70B50")]
			static CLMALLMNENF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly CBBFEPDHKGO FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly CBBFEPDHKGO[] IODHDOBPINL;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		private BMFFFPPPOHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
		public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly GGKCAJABCKP<object> GGLCADCNKGP;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private NDFOJEEJCMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal sealed class FDHBMOBMLNK : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private static class AGFPOLFNNPK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x34B7FA0", Offset = "0x34B67A0", VA = "0x1834B7FA0")]
		static AGFPOLFNNPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private sealed class JKHNJEBKMJM : CBBFEPDHKGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		private static class IFGPIFENHIN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x36360E0", Offset = "0x36348E0", VA = "0x1836360E0")]
			static IFGPIFENHIN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly CBBFEPDHKGO FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly CBBFEPDHKGO[] IODHDOBPINL;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		private JKHNJEBKMJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
		public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly GGKCAJABCKP<object> GGLCADCNKGP;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private FDHBMOBMLNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal sealed class AMDINJAHEJD : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private static class CFFEHDDBCEK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4AB4EE0", Offset = "0x4AB36E0", VA = "0x184AB4EE0")]
		static CFFEHDDBCEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private sealed class EGIKKPMKLAB : CBBFEPDHKGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		private static class MENDIGGAIOA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x3AEDEE0", Offset = "0x3AEC6E0", VA = "0x183AEDEE0")]
			static MENDIGGAIOA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly CBBFEPDHKGO FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly CBBFEPDHKGO[] IODHDOBPINL;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		private EGIKKPMKLAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
		public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly GGKCAJABCKP<object> GGLCADCNKGP;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private AMDINJAHEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
internal sealed class JBKELHECGJB : CBBFEPDHKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private static class NCOGLEDKBEE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3BA62F0", Offset = "0x3BA4AF0", VA = "0x183BA62F0")]
		static NCOGLEDKBEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private sealed class HODIBMAEPJH : CBBFEPDHKGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		private static class KFCBAJKKEJK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly GGKCAJABCKP<T> HOGAFGKFADG;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x386D550", Offset = "0x386BD50", VA = "0x18386D550")]
			static KFCBAJKKEJK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly CBBFEPDHKGO FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly CBBFEPDHKGO[] IODHDOBPINL;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		private HODIBMAEPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
		public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly CBBFEPDHKGO FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly GGKCAJABCKP<object> GGLCADCNKGP;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	private JBKELHECGJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2183310", Offset = "0x2181B10", VA = "0x182183310", Slot = "4")]
	public GGKCAJABCKP<T> MBCGOIMPMDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct HPNJNCJIHEE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] DANMLCEGPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int JFBFKJBMEGJ;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x35A3C20", Offset = "0x35A2420", VA = "0x1835A3C20")]
	public HPNJNCJIHEE(int EBOBLDPHGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x35A3830", Offset = "0x35A2030", VA = "0x1835A3830")]
	public void BONJGFNEKBE(T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x35A3B90", Offset = "0x35A2390", VA = "0x1835A3B90")]
	public T[] HCPNEMMLMOB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal sealed class LGGEOJMJBJE : OENIMBCKGDG<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly LGGEOJMJBJE MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x640B370", Offset = "0x6409B70", VA = "0x18640B370")]
	public LGGEOJMJBJE(int GIBEJDOPLFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class OENIMBCKGDG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int GIBEJDOPLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object AABEFGHDLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int LFEFGCGCIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] KLKAFNGIPAD;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3CD35D0", Offset = "0x3CD1DD0", VA = "0x183CD35D0")]
	public OENIMBCKGDG(int GIBEJDOPLFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2D90", Offset = "0x3CD1590", VA = "0x183CD2D90")]
	public T[] LDHLCGCAJHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2190", Offset = "0x3CD0990", VA = "0x183CD2190")]
	public void CFNIONIOIGL(T[] INLAJDDNHAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class EHECHPMAAOM : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private class JHCLLJBOBIN : IComparable<JHCLLJBOBIN>
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class MBFAHOIGHAJ : IEnumerable<JHCLLJBOBIN>, IEnumerable, IEnumerator<JHCLLJBOBIN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private JHCLLJBOBIN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public JHCLLJBOBIN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private JHCLLJBOBIN System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x86AE20", Offset = "0x869620", VA = "0x18086AE20")]
			[DebuggerHidden]
			public MBFAHOIGHAJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x640B3C0", Offset = "0x6409BC0", VA = "0x18640B3C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x640B4F0", Offset = "0x6409CF0", VA = "0x18640B4F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x640B440", Offset = "0x6409C40", VA = "0x18640B440", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JHCLLJBOBIN> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x640B440", Offset = "0x6409C40", VA = "0x18640B440", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class CFLJKFGEIDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public CFLJKFGEIDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x63FB7C0", Offset = "0x63F9FC0", VA = "0x1863FB7C0")]
			internal Label PGOJFLCLIKJ(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x63FB7C0", Offset = "0x63F9FC0", VA = "0x1863FB7C0")]
			internal Label NFADAFNDDLN(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly JHCLLJBOBIN[] AOBBPLILHMO;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] BEDPGINPOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong LKLFDONKJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int PENMJFOMGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string JJMJNJHGJGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private JHCLLJBOBIN[] ILGEJBMGLKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] JGGCJCEOKDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int EHGKBCBKPCI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool MCAHFEBFIFO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x4FB99A0", Offset = "0x4FB81A0", VA = "0x184FB99A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6407DB0", Offset = "0x64065B0", VA = "0x186407DB0")]
		public JHCLLJBOBIN(ulong OHPCNPKOLBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x64067E0", Offset = "0x6404FE0", VA = "0x1864067E0")]
		public JHCLLJBOBIN BONJGFNEKBE(ulong OHPCNPKOLBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6406780", Offset = "0x6404F80", VA = "0x186406780")]
		public JHCLLJBOBIN BONJGFNEKBE(ulong OHPCNPKOLBJ, int FKKGMPDEPMA, string JJMJNJHGJGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6407B80", Offset = "0x6406380", VA = "0x186407B80")]
		public JHCLLJBOBIN OGNFIGOLLEB(byte[] EJOBIJGJEMN, int GDMKPCJDDGD, int IFCJPGANIGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6406E10", Offset = "0x6405610", VA = "0x186406E10")]
		internal static int HJFNNHFINKN(ulong[] INLAJDDNHAO, int LFEFGCGCIAG, int HPFMIMMLOKB, ulong FKKGMPDEPMA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x64069E0", Offset = "0x64051E0", VA = "0x1864069E0", Slot = "4")]
		public int CompareTo(JHCLLJBOBIN IFHFGCDLDEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6406A10", Offset = "0x6405210", VA = "0x186406A10")]
		[IteratorStateMachine(typeof(MBFAHOIGHAJ))]
		public IEnumerable<JHCLLJBOBIN> DLPEDNLLPMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6406A90", Offset = "0x6405290", VA = "0x186406A90")]
		public void DPJCFHIIDMJ(ILGenerator GKPFODINCOM, LocalBuilder EJOBIJGJEMN, LocalBuilder IFCJPGANIGL, LocalBuilder OHPCNPKOLBJ, Action<KeyValuePair<string, int>> GOEMLPAPBNM, Action LCPNNOOAHLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6406EA0", Offset = "0x64056A0", VA = "0x186406EA0")]
		private static void OACMAJBBEOP(ILGenerator GKPFODINCOM, LocalBuilder EJOBIJGJEMN, LocalBuilder IFCJPGANIGL, LocalBuilder OHPCNPKOLBJ, Action<KeyValuePair<string, int>> GOEMLPAPBNM, Action LCPNNOOAHLN, JHCLLJBOBIN[] ILGEJBMGLKC, int EHGKBCBKPCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class MOIHLHKOJMF : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<JHCLLJBOBIN> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<JHCLLJBOBIN> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<JHCLLJBOBIN> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private JHCLLJBOBIN <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x955E20", Offset = "0x954620", VA = "0x180955E20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x640C760", Offset = "0x640AF60", VA = "0x18640C760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1B32A80", Offset = "0x1B31280", VA = "0x181B32A80")]
		[DebuggerHidden]
		public MOIHLHKOJMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x640C7B0", Offset = "0x640AFB0", VA = "0x18640C7B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x640C160", Offset = "0x640A960", VA = "0x18640C160", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x640C610", Offset = "0x640AE10", VA = "0x18640C610")]
		private void NINDIEOCHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x640C5C0", Offset = "0x640ADC0", VA = "0x18640C5C0")]
		private void NIGDNOCCEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x640C710", Offset = "0x640AF10", VA = "0x18640C710", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x640C660", Offset = "0x640AE60", VA = "0x18640C660", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x640C660", Offset = "0x640AE60", VA = "0x18640C660", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly JHCLLJBOBIN DIPDOFGLHFF;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x63FD740", Offset = "0x63FBF40", VA = "0x1863FD740")]
	public EHECHPMAAOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x63FD0D0", Offset = "0x63FB8D0", VA = "0x1863FD0D0")]
	public void BONJGFNEKBE(byte[] MHCEKABKGED, int FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x63FD4C0", Offset = "0x63FBCC0", VA = "0x1863FD4C0")]
	public bool DBJBLNCINEB(ArraySegment<byte> OHPCNPKOLBJ, [Out] int FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x63FD6B0", Offset = "0x63FBEB0", VA = "0x1863FD6B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x63FD1E0", Offset = "0x63FB9E0", VA = "0x1863FD1E0")]
	private static void CHLLNIPOMGM(IEnumerable<JHCLLJBOBIN> ILGEJBMGLKC, StringBuilder DPALHCMCODE, int IGMBNCEJALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x63FD620", Offset = "0x63FBE20", VA = "0x1863FD620", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x63FD620", Offset = "0x63FBE20", VA = "0x1863FD620", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x63FD5A0", Offset = "0x63FBDA0", VA = "0x1863FD5A0")]
	[IteratorStateMachine(typeof(MOIHLHKOJMF))]
	private static IEnumerable<KeyValuePair<string, int>> EFEAGACOABI(IEnumerable<JHCLLJBOBIN> ILGEJBMGLKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x63FD680", Offset = "0x63FBE80", VA = "0x1863FD680")]
	public void POMIPCOOCBH(ILGenerator GKPFODINCOM, LocalBuilder EJOBIJGJEMN, LocalBuilder IFCJPGANIGL, LocalBuilder OHPCNPKOLBJ, Action<KeyValuePair<string, int>> GOEMLPAPBNM, Action LCPNNOOAHLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class IJNPBCGJPFO
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo KKBJOBGFJPA;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6405570", Offset = "0x6403D70", VA = "0x186405570")]
	public static ulong EEKNLDDBCGE(byte[] MHCEKABKGED, int GDMKPCJDDGD, int IFCJPGANIGL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class NAMLKIHHCAP
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x640CB50", Offset = "0x640B350", VA = "0x18640CB50")]
	public static void PIGGKMPBDKN(byte[] MHCEKABKGED, int GDMKPCJDDGD, int LEJMPFIPEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x640CA30", Offset = "0x640B230", VA = "0x18640CA30")]
	public static void OHENKLDGMKF(byte[] INLAJDDNHAO, int HOIGBFLHEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x640C900", Offset = "0x640B100", VA = "0x18640C900")]
	public static byte[] NIOBIGJGOGA(byte[] INOEECCONEM, int HOIGBFLHEHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class FDFGGPEJMKE
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x63FFF50", Offset = "0x63FE750", VA = "0x1863FFF50")]
	public static bool JDJBPEMKOJF(byte[] LPDMAPLLNDG, int ENGNEGGAFMM, int ECHPLMJEBJC, byte[] HADJIGLOINE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal class OCLFDNMABDH<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private struct BKPOCAOOOOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] LKLFDONKJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T PENMJFOMGMH;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x441B330", Offset = "0x4419B30", VA = "0x18441B330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class NJEFJBPFBBC : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public OCLFDNMABDH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private BKPOCAOOOOO[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private BKPOCAOOOOO[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x955E20", Offset = "0x954620", VA = "0x180955E20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x337F010", Offset = "0x337D810", VA = "0x18337F010", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public NJEFJBPFBBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3BCE930", Offset = "0x3BCD130", VA = "0x183BCE930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0460", Offset = "0x3BCEC60", VA = "0x183BD0460", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly BKPOCAOOOOO[][] OGBIGDNPBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong DNNNMIIPHCH;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3CC70E0", Offset = "0x3CC58E0", VA = "0x183CC70E0")]
	public OCLFDNMABDH(int AFOFPPEGLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7020", Offset = "0x3CC5820", VA = "0x183CC7020")]
	public OCLFDNMABDH(int AFOFPPEGLDI, float JJFKHJCOBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3CB5A40", Offset = "0x3CB4240", VA = "0x183CB5A40")]
	public void BONJGFNEKBE(byte[] OHPCNPKOLBJ, T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8D20", Offset = "0x3CB7520", VA = "0x183CB8D20")]
	private bool ILJEPCMGLDJ(byte[] OHPCNPKOLBJ, T FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3CC5F00", Offset = "0x3CC4700", VA = "0x183CC5F00")]
	public bool OCMBKDFPCIC(ArraySegment<byte> OHPCNPKOLBJ, [Out] T FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0D90", Offset = "0x3CBF590", VA = "0x183CC0D90")]
	private static ulong NKNJAIKAFLC(byte[] IILAPOMEGLM, int GDMKPCJDDGD, int EHGKBCBKPCI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x361F5B0", Offset = "0x361DDB0", VA = "0x18361F5B0")]
	private static int BNFEEENHKGE(int EOKBDDJODAL, float JJFKHJCOBEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6EF0", Offset = "0x3CB56F0", VA = "0x183CB6EF0", Slot = "4")]
	[IteratorStateMachine(typeof(OCLFDNMABDH<>.NJEFJBPFBBC))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3223290", Offset = "0x3221A90", VA = "0x183223290", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class IBGPJMEOFHK : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] GEBGJFJHAPN;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] PMFFNPHFIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int GGJEJDBGNGD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool JCFGEDJHLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6405130", Offset = "0x6403930", VA = "0x186405130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6405280", Offset = "0x6403A80", VA = "0x186405280")]
	static IBGPJMEOFHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x64054E0", Offset = "0x6403CE0", VA = "0x1864054E0")]
	public IBGPJMEOFHK(byte[] HLHBIIPAIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6405180", Offset = "0x6403980", VA = "0x186405180")]
	public OpCode NAHFEHEAPFD()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct OKMFCJFDGLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid PENMJFOMGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte JMNFNPKEFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte CCBKAJDPOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte FEAODNLDDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte OHCMFALPCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte JGOLNEHGFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte MOLBOPLIAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte PNBDKBKHIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte GIDPJFIPLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte FHHGJAJJENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte LLPEGNBGGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte DLEDEDNIJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte DIJLFHDCOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte FFKNGMAJHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte POGHNBMDCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte DPCAPDOGHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte GOKFIAOEHFF;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] GIBMKIBLMAB;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] HEODNEGEKPP;

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6410120", Offset = "0x640E920", VA = "0x186410120")]
	public OKMFCJFDGLK(Guid FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x640E9D0", Offset = "0x640D1D0", VA = "0x18640E9D0")]
	public OKMFCJFDGLK(ArraySegment<byte> CLBGGMOFCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x640DA70", Offset = "0x640C270", VA = "0x18640DA70")]
	private static byte EGFEFALHHON(byte[] MHCEKABKGED, int MIIGBCHKHAP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x640E7C0", Offset = "0x640CFC0", VA = "0x18640E7C0")]
	private static byte PILMHGNNFNL(byte DNOEGKBPKDC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x640DB10", Offset = "0x640C310", VA = "0x18640DB10")]
	public void ILHFNKGBFAM(byte[] NEJFCHMJPKN, int GDMKPCJDDGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class ENAGCGGMPBG
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x63FF4E0", Offset = "0x63FDCE0", VA = "0x1863FF4E0")]
	public static bool MHGJNKOCIKK(byte HCJCBMCLKPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x63FE750", Offset = "0x63FCF50", VA = "0x1863FE750")]
	public static bool DEMNIAKKMIN(byte HCJCBMCLKPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x63FF110", Offset = "0x63FD910", VA = "0x1863FF110")]
	public static sbyte FDGGGFMCDJJ(byte[] MHCEKABKGED, int GDMKPCJDDGD, [Out] int JINBOHBFEPP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x63FE660", Offset = "0x63FCE60", VA = "0x1863FE660")]
	public static short DBBPIDEGPDH(byte[] MHCEKABKGED, int GDMKPCJDDGD, [Out] int JINBOHBFEPP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x63FE570", Offset = "0x63FCD70", VA = "0x1863FE570")]
	public static int AHCDLHFGEFC(byte[] MHCEKABKGED, int GDMKPCJDDGD, [Out] int JINBOHBFEPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x63FFEB0", Offset = "0x63FE6B0", VA = "0x1863FFEB0")]
	public static long PPOKMLDGNLH(byte[] MHCEKABKGED, int GDMKPCJDDGD, [Out] int JINBOHBFEPP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x63FF300", Offset = "0x63FDB00", VA = "0x1863FF300")]
	public static byte IADJMNDEDNB(byte[] MHCEKABKGED, int GDMKPCJDDGD, [Out] int JINBOHBFEPP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x63FF090", Offset = "0x63FD890", VA = "0x1863FF090")]
	public static ushort FCGFAEFHBGD(byte[] MHCEKABKGED, int GDMKPCJDDGD, [Out] int JINBOHBFEPP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x63FF460", Offset = "0x63FDC60", VA = "0x1863FF460")]
	public static uint LAIHDOHFKLD(byte[] MHCEKABKGED, int GDMKPCJDDGD, [Out] int JINBOHBFEPP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x63FF1F0", Offset = "0x63FD9F0", VA = "0x1863FF1F0")]
	public static ulong HPDIPCLNJJI(byte[] MHCEKABKGED, int GDMKPCJDDGD, [Out] int JINBOHBFEPP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x63FF3F0", Offset = "0x63FDBF0", VA = "0x1863FF3F0")]
	public static float KMPLLPGCIEH(byte[] MHCEKABKGED, int GDMKPCJDDGD, [Out] int JINBOHBFEPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x63FF380", Offset = "0x63FDB80", VA = "0x1863FF380")]
	public static double KHIPCDDHPIN(byte[] MHCEKABKGED, int GDMKPCJDDGD, [Out] int JINBOHBFEPP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x63FE9F0", Offset = "0x63FD1F0", VA = "0x1863FE9F0")]
	public static int EIAMHLINFNE(byte[] NEJFCHMJPKN, int GDMKPCJDDGD, ulong FKKGMPDEPMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x63FF4F0", Offset = "0x63FDCF0", VA = "0x1863FF4F0")]
	public static int PDIKPKBJOHA(byte[] NEJFCHMJPKN, int GDMKPCJDDGD, long FKKGMPDEPMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x63FE7C0", Offset = "0x63FCFC0", VA = "0x1863FE7C0")]
	public static bool DKNLMKHOKDE(byte[] MHCEKABKGED, int GDMKPCJDDGD, [Out] int JINBOHBFEPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class HNJNDGEEPFE
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class PEGGIDBIMJE : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x86AE20", Offset = "0x869620", VA = "0x18086AE20")]
		[DebuggerHidden]
		public PEGGIDBIMJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x64109A0", Offset = "0x640F1A0", VA = "0x1864109A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x64103C0", Offset = "0x640EBC0", VA = "0x1864103C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6410840", Offset = "0x640F040", VA = "0x186410840")]
		private void NINDIEOCHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x64107F0", Offset = "0x640EFF0", VA = "0x1864107F0")]
		private void NIGDNOCCEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6410950", Offset = "0x640F150", VA = "0x186410950", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6410890", Offset = "0x640F090", VA = "0x186410890", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6410890", Offset = "0x640F090", VA = "0x186410890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class GIGDONCMJPI : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x86AE20", Offset = "0x869620", VA = "0x18086AE20")]
		[DebuggerHidden]
		public GIGDONCMJPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6400A60", Offset = "0x63FF260", VA = "0x186400A60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6400480", Offset = "0x63FEC80", VA = "0x186400480", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6400900", Offset = "0x63FF100", VA = "0x186400900")]
		private void NINDIEOCHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x64008B0", Offset = "0x63FF0B0", VA = "0x1864008B0")]
		private void NIGDNOCCEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6400A10", Offset = "0x63FF210", VA = "0x186400A10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6400950", Offset = "0x63FF150", VA = "0x186400950", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6400950", Offset = "0x63FF150", VA = "0x186400950", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6402B20", Offset = "0x6401320", VA = "0x186402B20")]
	public static bool HCNEDDNFIFC(this TypeInfo GFGNPBCFEMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6402950", Offset = "0x6401150", VA = "0x186402950")]
	public static bool BKMFNJBAMGI(this TypeInfo GFGNPBCFEMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x64028D0", Offset = "0x64010D0", VA = "0x1864028D0")]
	public static IEnumerable<PropertyInfo> BIFLAMMOJPM(this Type GFGNPBCFEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6402BE0", Offset = "0x64013E0", VA = "0x186402BE0")]
	[IteratorStateMachine(typeof(PEGGIDBIMJE))]
	private static IEnumerable<PropertyInfo> JMCNPBNFFKM(Type GFGNPBCFEMC, HashSet<string> FCONKJCDOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6402C80", Offset = "0x6401480", VA = "0x186402C80")]
	public static IEnumerable<FieldInfo> OCPHCGNDPDF(this Type GFGNPBCFEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6402A80", Offset = "0x6401280", VA = "0x186402A80")]
	[IteratorStateMachine(typeof(GIGDONCMJPI))]
	private static IEnumerable<FieldInfo> HALOKKKOPGD(Type GFGNPBCFEMC, HashSet<string> FCONKJCDOFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class JCNMMNJMIAH
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding DKDFGCIEMJC;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal static class LFPDIEPEPBC
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
	public static string LJANODAMGPC(string AKBBFEAHONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x640B060", Offset = "0x6409860", VA = "0x18640B060")]
	public static string FKOBLFNHIEK(string AKBBFEAHONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x640B140", Offset = "0x6409940", VA = "0x18640B140")]
	public static string KHDIADDOJCM(string AKBBFEAHONO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class IBKOFOPCOOH<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class LHJKELFPLEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type LKLFDONKJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue PENMJFOMGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int DBHEFBINCGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public LHJKELFPLEO FELPMHHOECD;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3920B40", Offset = "0x391F340", VA = "0x183920B40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3920AC0", Offset = "0x391F2C0", VA = "0x183920AC0")]
		private int HLNPNOBJJGG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public LHJKELFPLEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class CMMINAFKELE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public CMMINAFKELE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40")]
		internal TValue DEGJFKMBDDP(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private LHJKELFPLEO[] OGBIGDNPBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int ALCHALOFNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object GNPGOELNMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float JJFKHJCOBEI;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3620B30", Offset = "0x361F330", VA = "0x183620B30")]
	public IBKOFOPCOOH(int AFOFPPEGLDI = 4, float JJFKHJCOBEI = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x361F760", Offset = "0x361DF60", VA = "0x18361F760")]
	public bool EMGPHAFADIE(Type OHPCNPKOLBJ, TValue FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x361F890", Offset = "0x361E090", VA = "0x18361F890")]
	public bool EMGPHAFADIE(Type OHPCNPKOLBJ, Func<Type, TValue> DALDDHLDGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x361FDB0", Offset = "0x361E5B0", VA = "0x18361FDB0")]
	private bool ILJEPCMGLDJ(Type OHPCNPKOLBJ, Func<Type, TValue> DALDDHLDGPJ, [Out] TValue IGABFEFHFBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x36204D0", Offset = "0x361ECD0", VA = "0x1836204D0")]
	private bool NHHNGDKCDJE(LHJKELFPLEO[] OGBIGDNPBNF, Type BCFJPHFKLAH, LHJKELFPLEO IAGHGEIPFKJ, Func<Type, TValue> DALDDHLDGPJ, [Out] TValue IGABFEFHFBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x36209F0", Offset = "0x361F1F0", VA = "0x1836209F0")]
	public bool OCMBKDFPCIC(Type OHPCNPKOLBJ, [Out] TValue FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x361F970", Offset = "0x361E170", VA = "0x18361F970")]
	public TValue FJJADKGFDGM(Type OHPCNPKOLBJ, Func<Type, TValue> DALDDHLDGPJ)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x361F5B0", Offset = "0x361DDB0", VA = "0x18361F5B0")]
	private static int BNFEEENHKGE(int EOKBDDJODAL, float JJFKHJCOBEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x361FA20", Offset = "0x361E220", VA = "0x18361FA20")]
	private static void GIGCLNPEIKI(LHJKELFPLEO MBLEFBMPDNN, LHJKELFPLEO FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x361FA20", Offset = "0x361E220", VA = "0x18361FA20")]
	private static void GIGCLNPEIKI(LHJKELFPLEO[] MBLEFBMPDNN, LHJKELFPLEO[] FKKGMPDEPMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class OINNHIINLDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder BEHNBCBFEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder JNFNLGKEPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object AABEFGHDLKI;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x640D860", Offset = "0x640C060", VA = "0x18640D860")]
	public TypeBuilder AEMBDLKMAOH(string HNHMJGCODBA, TypeAttributes HLPAPECFJFI, Type OBIIIBPBMLD, Type[] BGDJOIGPKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x640D960", Offset = "0x640C160", VA = "0x18640D960")]
	public OINNHIINLDE(string CFIFFIACCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal static class OHFDHGBMOIE
{
	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x640D780", Offset = "0x640BF80", VA = "0x18640D780")]
	private static MethodInfo IANKABIPCAE(LambdaExpression FEAHJHDBKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x24D95D0", Offset = "0x24D7DD0", VA = "0x1824D95D0")]
	public static MethodInfo PNCEMLGCBNN<T>(Expression<Func<T>> FEAHJHDBKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x24D95D0", Offset = "0x24D7DD0", VA = "0x1824D95D0")]
	public static MethodInfo PNCEMLGCBNN<T, TR>(Expression<Func<T, TR>> FEAHJHDBKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x24D95D0", Offset = "0x24D7DD0", VA = "0x1824D95D0")]
	public static MethodInfo PNCEMLGCBNN<T>(Expression<Action<T>> FEAHJHDBKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x24D95D0", Offset = "0x24D7DD0", VA = "0x1824D95D0")]
	public static MethodInfo PNCEMLGCBNN<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> FEAHJHDBKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x24D9450", Offset = "0x24D7C50", VA = "0x1824D9450")]
	private static MemberInfo HLBHGMDNBEI<T>(Expression<T> KLIANGHAKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x24D9530", Offset = "0x24D7D30", VA = "0x1824D9530")]
	public static PropertyInfo PIJAODNCBEK<T, TR>(Expression<Func<T, TR>> FEAHJHDBKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal struct DMNKIOPNPOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int DKLECPOCCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool NDDKEOONJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator GKPFODINCOM;

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x63FC570", Offset = "0x63FAD70", VA = "0x1863FC570")]
	public DMNKIOPNPOK(ILGenerator GKPFODINCOM, int DKLECPOCCOI, bool NDDKEOONJOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x63FC4E0", Offset = "0x63FACE0", VA = "0x1863FC4E0")]
	public DMNKIOPNPOK(ILGenerator GKPFODINCOM, int DKLECPOCCOI, Type GFGNPBCFEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x63FC3E0", Offset = "0x63FABE0", VA = "0x1863FC3E0")]
	public void FJLKEONIFED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class HPGHIGOEENJ
{
	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6404010", Offset = "0x6402810", VA = "0x186404010")]
	public static void ACEFHKJLNDN(this ILGenerator GKPFODINCOM, int LFEFGCGCIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6404200", Offset = "0x6402A00", VA = "0x186404200")]
	public static void ACEFHKJLNDN(this ILGenerator GKPFODINCOM, LocalBuilder ADEFMBLFOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6404890", Offset = "0x6403090", VA = "0x186404890")]
	public static void EBMEPEJJCGP(this ILGenerator GKPFODINCOM, int LFEFGCGCIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6404A80", Offset = "0x6403280", VA = "0x186404A80")]
	public static void EBMEPEJJCGP(this ILGenerator GKPFODINCOM, LocalBuilder ADEFMBLFOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6404340", Offset = "0x6402B40", VA = "0x186404340")]
	public static void CBELPECJPHA(this ILGenerator GKPFODINCOM, int LFEFGCGCIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6404240", Offset = "0x6402A40", VA = "0x186404240")]
	public static void CBELPECJPHA(this ILGenerator GKPFODINCOM, LocalBuilder ADEFMBLFOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6404C70", Offset = "0x6403470", VA = "0x186404C70")]
	public static void JNMDAHBEEOB(this ILGenerator GKPFODINCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6404C80", Offset = "0x6403480", VA = "0x186404C80")]
	public static void KCLEDKGJECG(this ILGenerator GKPFODINCOM, bool FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x64044B0", Offset = "0x6402CB0", VA = "0x1864044B0")]
	public static void CLPMPEFNEOF(this ILGenerator GKPFODINCOM, int FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6405050", Offset = "0x6403850", VA = "0x186405050")]
	public static void PEFOPEBOEIP(this ILGenerator GKPFODINCOM, Type GFGNPBCFEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6404AC0", Offset = "0x64032C0", VA = "0x186404AC0")]
	public static void EKHIEPKIEEM(this ILGenerator GKPFODINCOM, Type GFGNPBCFEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x6404D70", Offset = "0x6403570", VA = "0x186404D70")]
	public static void NLKELJEHNFD(this ILGenerator GKPFODINCOM, int LFEFGCGCIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x6404B60", Offset = "0x6403360", VA = "0x186404B60")]
	public static void GJAAHPGKKJH(this ILGenerator GKPFODINCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6404C90", Offset = "0x6403490", VA = "0x186404C90")]
	public static void LBMCBGHCPBI(this ILGenerator GKPFODINCOM, int LFEFGCGCIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x6404F60", Offset = "0x6403760", VA = "0x186404F60")]
	public static void OKFHDHJGLAG(this ILGenerator GKPFODINCOM, MethodInfo FNPBALCELLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x6404BE0", Offset = "0x64033E0", VA = "0x186404BE0")]
	public static void IDGPIDLPNNO(this ILGenerator GKPFODINCOM, FieldInfo PJKPGAKKEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6404420", Offset = "0x6402C20", VA = "0x186404420")]
	public static void CLBNFFFCCBL(this ILGenerator GKPFODINCOM, ulong FKKGMPDEPMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class EGFBIFECPIM
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class OPADACANNLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public OPADACANNLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x64102B0", Offset = "0x640EAB0", VA = "0x1864102B0")]
		internal bool BCAFAEBEJBK(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo KOMNNNPGJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo MFLECBLBPHH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string MBENGICGPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x764B00", VA = "0x180766300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string BCBBGGKLOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x766130", Offset = "0x764930", VA = "0x180766130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DHDBPBJBIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x63FC8B0", Offset = "0x63FB0B0", VA = "0x1863FC8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool NFCFEMFKDOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x76E480", Offset = "0x76CC80", VA = "0x18076E480")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x76E4A0", Offset = "0x76CCA0", VA = "0x18076E4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool MCCKMEHLPAH
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7E6F50", Offset = "0x7E5750", VA = "0x1807E6F50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6AB0", Offset = "0x7E52B0", VA = "0x1807E6AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type DAKFPFPAGLI
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x766120", Offset = "0x764920", VA = "0x180766120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo HGPHKAMIHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x76BD00", Offset = "0x76A500", VA = "0x18076BD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo FIGKMCLKOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x76E4B0", Offset = "0x76CCB0", VA = "0x18076E4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo LHIHGJCOLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x766140", Offset = "0x764940", VA = "0x180766140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x766310", Offset = "0x764B10", VA = "0x180766310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x63FCBB0", Offset = "0x63FB3B0", VA = "0x1863FCBB0")]
	protected EGFBIFECPIM(Type GFGNPBCFEMC, string HNHMJGCODBA, string AOBKLNCCBPN, bool DPAFBMDGDGK, bool JKOBMLAJGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x63FCDF0", Offset = "0x63FB5F0", VA = "0x1863FCDF0")]
	public EGFBIFECPIM(FieldInfo EEILNADBKNP, string HNHMJGCODBA, bool IJMGONIPKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x63FCC30", Offset = "0x63FB430", VA = "0x1863FCC30")]
	public EGFBIFECPIM(PropertyInfo EEILNADBKNP, string HNHMJGCODBA, bool IJMGONIPKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x63FCA40", Offset = "0x63FB240", VA = "0x1863FCA40")]
	private static MethodInfo OJHBHKNDKMK(MemberInfo EEILNADBKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2240730", Offset = "0x223EF30", VA = "0x182240730")]
	public T EKEKCJAMLBE<T>(bool DBFADFEMDLO) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x63FC8C0", Offset = "0x63FB0C0", VA = "0x1863FC8C0", Slot = "4")]
	public virtual void JAOCBNEGBGE(ILGenerator GKPFODINCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x63FC730", Offset = "0x63FAF30", VA = "0x1863FC730", Slot = "5")]
	public virtual void DGACIOBKHEL(ILGenerator GKPFODINCOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class HKGIDIGKBDD : EGFBIFECPIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string LNLGEMKIBMC;

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x64027F0", Offset = "0x6400FF0", VA = "0x1864027F0")]
	public HKGIDIGKBDD(string HNHMJGCODBA, string LNLGEMKIBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6402740", Offset = "0x6400F40", VA = "0x186402740", Slot = "4")]
	public override void JAOCBNEGBGE(ILGenerator GKPFODINCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x64026F0", Offset = "0x6400EF0", VA = "0x1864026F0", Slot = "5")]
	public override void DGACIOBKHEL(ILGenerator GKPFODINCOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class KLFPEBEANPA : EGFBIFECPIM
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo CNIBDJNHIJF;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo BADJPIKIBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal DMNKIOPNPOK FCIAMLAAANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal DMNKIOPNPOK MJKNGMHPDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal DMNKIOPNPOK IHDLLIHHNOK;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x640ADD0", Offset = "0x64095D0", VA = "0x18640ADD0")]
	public KLFPEBEANPA(string HNHMJGCODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x640A800", Offset = "0x6409000", VA = "0x18640A800", Slot = "4")]
	public override void JAOCBNEGBGE(ILGenerator GKPFODINCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x640A5F0", Offset = "0x6408DF0", VA = "0x18640A5F0", Slot = "5")]
	public override void DGACIOBKHEL(ILGenerator GKPFODINCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x640A640", Offset = "0x6408E40", VA = "0x18640A640")]
	public void FFFCCFDGGAO(ILGenerator GKPFODINCOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class CCKKGJGCMBK
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type DAKFPFPAGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x764B00", VA = "0x180766300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool CMNDJHBMBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7D07D0", Offset = "0x7CEFD0", VA = "0x1807D07D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x770F70", Offset = "0x76F770", VA = "0x180770F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool BOKGJIHEMMH
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7E60C0", Offset = "0x7E48C0", VA = "0x1807E60C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7E55A0", Offset = "0x7E3DA0", VA = "0x1807E55A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo CANOKLKFOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7662F0", Offset = "0x764AF0", VA = "0x1807662F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EGFBIFECPIM[] CAJNILMCICG
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x766120", Offset = "0x764920", VA = "0x180766120")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public EGFBIFECPIM[] HGAOMGMGGMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x76BD00", Offset = "0x76A500", VA = "0x18076BD00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x63FA300", Offset = "0x63F8B00", VA = "0x1863FA300")]
	public CCKKGJGCMBK(Type GFGNPBCFEMC, Func<string, string> PKBBLECKLNI, bool IJMGONIPKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x63FA220", Offset = "0x63F8A20", VA = "0x1863FA220")]
	private static bool JJKFLKEBPFN(IEnumerator<ConstructorInfo> JFNIIGAIKNK, ConstructorInfo EOCENPCGBJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct BIOJOAOKOKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong FLEKOMGPFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int KHOFKDAGHHN;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1C60D40", Offset = "0x1C5F540", VA = "0x181C60D40")]
	public BIOJOAOKOKF(ulong MLKJDBJPMGM, int NKMAKDPHLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x63F9FA0", Offset = "0x63F87A0", VA = "0x1863F9FA0")]
	public void LNLGKPBFGJA(BIOJOAOKOKF IFHFGCDLDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x63F9F90", Offset = "0x63F8790", VA = "0x1863F9F90")]
	public static BIOJOAOKOKF IPDJFMEFLJP(BIOJOAOKOKF EOFAJFKEBLN, BIOJOAOKOKF DNOEGKBPKDC)
	{
		return default(BIOJOAOKOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x63F9E70", Offset = "0x63F8670", VA = "0x1863F9E70")]
	public void DBNHJKGBIBJ(BIOJOAOKOKF IFHFGCDLDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x63F9FB0", Offset = "0x63F87B0", VA = "0x1863F9FB0")]
	public static BIOJOAOKOKF PIBMABKNDDB(BIOJOAOKOKF EOFAJFKEBLN, BIOJOAOKOKF DNOEGKBPKDC)
	{
		return default(BIOJOAOKOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x63F9F00", Offset = "0x63F8700", VA = "0x1863F9F00")]
	public void GGCNENDAGKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x63F9F40", Offset = "0x63F8740", VA = "0x1863F9F40")]
	public static BIOJOAOKOKF GGCNENDAGKA(BIOJOAOKOKF EOFAJFKEBLN)
	{
		return default(BIOJOAOKOKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct MCACKEJPNNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] NEJFCHMJPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int GDMKPCJDDGD;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x166AF70", Offset = "0x1669770", VA = "0x18166AF70")]
	public MCACKEJPNNG(byte[] NEJFCHMJPKN, int MCLBBPPAHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x63F3170", Offset = "0x63F1970", VA = "0x1863F3170")]
	public void GDJBIHHKLBO(byte OLGPFNCCCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x640B7E0", Offset = "0x6409FE0", VA = "0x18640B7E0")]
	public void PBDLOIHAPGK(byte[] OLGPFNCCCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x640B760", Offset = "0x6409F60", VA = "0x18640B760")]
	public void HOFLJAILGDN(byte[] OLGPFNCCCJM, int HPFMIMMLOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x640B6C0", Offset = "0x6409EC0", VA = "0x18640B6C0")]
	public void HOFLJAILGDN(byte[] OLGPFNCCCJM, int OKLBOBFEAFH, int HPFMIMMLOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x640B640", Offset = "0x6409E40", VA = "0x18640B640")]
	public void FDPMPKAADEN(byte HCJCBMCLKPJ, int EHGKBCBKPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x640B540", Offset = "0x6409D40", VA = "0x18640B540")]
	public void CNNNFGCPGCM(string OLGPFNCCCJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class JIBICAGOMFM
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum LMAEJGOJIDK
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum CHABAHOLLGD
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private enum JBCOKPGMLAP
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
	private static byte[] JLIDBMDMLII;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] GJLBGJMEEPD;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] JLEODBEGPEL;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] NMACBCLFBMF;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly JBCOKPGMLAP IDGIJMAGJLI;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char HDEHJMMKLCI;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int FGFKBKCMEHG;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int AFFEOAPHJCJ;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] DHLAPCAMKND;

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6409D50", Offset = "0x6408550", VA = "0x186409D50")]
	private static byte[] PJDNJGDFFNC(int ALCHALOFNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6409490", Offset = "0x6407C90", VA = "0x186409490")]
	private static byte[] LFGNGDJEHAH(int ALCHALOFNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6408DD0", Offset = "0x64075D0", VA = "0x186408DD0")]
	public static int JLIANBEKFOI(byte[] NEJFCHMJPKN, int GDMKPCJDDGD, float FKKGMPDEPMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6408EF0", Offset = "0x64076F0", VA = "0x186408EF0")]
	public static int JLIANBEKFOI(byte[] NEJFCHMJPKN, int GDMKPCJDDGD, double FKKGMPDEPMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6408BF0", Offset = "0x64073F0", VA = "0x186408BF0")]
	private static bool FOPAPDIHBHJ(byte[] NEJFCHMJPKN, int HPFMIMMLOKB, ulong GFDGIDAGJHG, ulong CJGDLMICLGC, ulong IFCJPGANIGL, ulong HCBCFIGGMFN, ulong HPPPHOHHNMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6408CE0", Offset = "0x64074E0", VA = "0x186408CE0")]
	private static void HBPAOHMMABH(uint LOOMDKEDCMA, int KFEGFIHCFDF, [Out] uint DGNEBDIGEAC, [Out] int MBFJHOOJADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6407E70", Offset = "0x6406670", VA = "0x186407E70")]
	private static bool BKIOGJFDGED(BIOJOAOKOKF DHDOHGNCPOE, BIOJOAOKOKF OANPIMIBBEM, BIOJOAOKOKF FKBDCMACABI, byte[] NEJFCHMJPKN, [Out] int HPFMIMMLOKB, [Out] int BMGLJJCDLGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6409010", Offset = "0x6407810", VA = "0x186409010")]
	private static bool JOGEGKHCPHD(double EJBGEGKBPNL, LMAEJGOJIDK FDFIAAFCBPI, byte[] NEJFCHMJPKN, [Out] int HPFMIMMLOKB, [Out] int EOBKACBCLAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x6409760", Offset = "0x6407F60", VA = "0x186409760")]
	private static bool OLGCLMEJPGJ(double EJBGEGKBPNL, LMAEJGOJIDK FDFIAAFCBPI, byte[] NEJFCHMJPKN, [Out] int HPFMIMMLOKB, [Out] int FGEAHCCFKIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6408A20", Offset = "0x6407220", VA = "0x186408A20")]
	private static bool FLBBKDHMCEH(double FKKGMPDEPMA, MCACKEJPNNG FGKBIANKNBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6409870", Offset = "0x6408070", VA = "0x186409870")]
	private static bool PAJONKPOOGF(double FKKGMPDEPMA, MCACKEJPNNG FGKBIANKNBH, CHABAHOLLGD FDFIAAFCBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6408690", Offset = "0x6406E90", VA = "0x186408690")]
	private static void FHDKLHPGHAD(byte[] FDHJFBFIOBP, int HPFMIMMLOKB, int FGEAHCCFKIO, int MCAOCGIDLCI, MCACKEJPNNG FGKBIANKNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6408260", Offset = "0x6406A60", VA = "0x186408260")]
	private static void CKKOIMOJOPB(byte[] FDHJFBFIOBP, int HPFMIMMLOKB, int NKMAKDPHLEA, MCACKEJPNNG FGKBIANKNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6409570", Offset = "0x6407D70", VA = "0x186409570")]
	private static bool OIGDAPIPNCG(double EJBGEGKBPNL, CHABAHOLLGD FDFIAAFCBPI, int JEGGFFOEDGN, byte[] FPINIDNLHMD, [Out] bool IMEBJOPNDML, [Out] int HPFMIMMLOKB, [Out] int ELJFMFLOMJI)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct CCAFEOPFHCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double CLPHKIKLHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong LOGJDCIBMAG;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct KGPIOCFKPIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float FLEKOMGPFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint BCBNJNBJJMF;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct NDPIJFMKFHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong MIFBPAHHLND;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x640D770", Offset = "0x640BF70", VA = "0x18640D770")]
	public NDPIJFMKFHD(double CLPHKIKLHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x640D6D0", Offset = "0x640BED0", VA = "0x18640D6D0")]
	public NDPIJFMKFHD(BIOJOAOKOKF CLPHKIKLHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x640D500", Offset = "0x640BD00", VA = "0x18640D500")]
	public BIOJOAOKOKF KDLAPKFHPGC()
	{
		return default(BIOJOAOKOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x640D650", Offset = "0x640BE50", VA = "0x18640D650")]
	public BIOJOAOKOKF PKJJPPFEGPH()
	{
		return default(BIOJOAOKOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA60A0", VA = "0x180AA78A0")]
	public ulong JFDFKMJOIAP()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x640D5C0", Offset = "0x640BDC0", VA = "0x18640D5C0")]
	public double MDNOMHMKKOM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x640D3D0", Offset = "0x640BBD0", VA = "0x18640D3D0")]
	public double IKMBFOFACKF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x640D1C0", Offset = "0x640B9C0", VA = "0x18640D1C0")]
	public int EAMNGCGJBCD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x640D140", Offset = "0x640B940", VA = "0x18640D140")]
	public ulong ANIFGJDEAPN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x640D380", Offset = "0x640BB80", VA = "0x18640D380")]
	public bool HFNLECFFFLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x640D340", Offset = "0x640BB40", VA = "0x18640D340")]
	public bool EMBOJDIKPMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x640D3A0", Offset = "0x640BBA0", VA = "0x18640D3A0")]
	public bool IDDMCFKIFKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x640D570", Offset = "0x640BD70", VA = "0x18640D570")]
	public bool KEGEINCCJDE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x640D360", Offset = "0x640BB60", VA = "0x18640D360")]
	public int FBJFLNNNDDD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x640D1F0", Offset = "0x640B9F0", VA = "0x18640D1F0")]
	public void EBCACMOLOCJ([Out] BIOJOAOKOKF GBGPLKCNNAO, [Out] BIOJOAOKOKF IPAAKFGGMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x640D170", Offset = "0x640B970", VA = "0x18640D170")]
	public bool DFMKCLIKPDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2946A60", Offset = "0x2945260", VA = "0x182946A60")]
	public double FKKGMPDEPMA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x640D5A0", Offset = "0x640BDA0", VA = "0x18640D5A0")]
	public static int LEFJMPFIOMH(int BJCDBDOLBBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x640D640", Offset = "0x640BE40", VA = "0x18640D640")]
	public static double NKHJIEJNNJE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x640D470", Offset = "0x640BC70", VA = "0x18640D470")]
	public static ulong KBPLKAGANAC(BIOJOAOKOKF EIBCCEONKFB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct CJFJJAMFBAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint COEEKJCBMNL;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x1F0A4C0", Offset = "0x1F08CC0", VA = "0x181F0A4C0")]
	public CJFJJAMFBAF(float FLEKOMGPFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x63FBC70", Offset = "0x63FA470", VA = "0x1863FBC70")]
	public BIOJOAOKOKF KDLAPKFHPGC()
	{
		return default(BIOJOAOKOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x98FA80", Offset = "0x98E280", VA = "0x18098FA80")]
	public uint IIILEJHIPHC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x63FBB10", Offset = "0x63FA310", VA = "0x1863FBB10")]
	public int EAMNGCGJBCD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x63FBAB0", Offset = "0x63FA2B0", VA = "0x1863FBAB0")]
	public uint ANIFGJDEAPN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x63FBC60", Offset = "0x63FA460", VA = "0x1863FBC60")]
	public bool HFNLECFFFLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x63FBB30", Offset = "0x63FA330", VA = "0x1863FBB30")]
	public void EBCACMOLOCJ([Out] BIOJOAOKOKF GBGPLKCNNAO, [Out] BIOJOAOKOKF IPAAKFGGMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x63FBAD0", Offset = "0x63FA2D0", VA = "0x1863FBAD0")]
	public bool DFMKCLIKPDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct HDNNCHOAEEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong MLKJDBJPMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short KPIFDGBHOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short EOBKACBCLAJ;

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x64026E0", Offset = "0x6400EE0", VA = "0x1864026E0")]
	public HDNNCHOAEEA(ulong MLKJDBJPMGM, short KPIFDGBHOOF, short EOBKACBCLAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class HOHJDFCDPOF
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly HDNNCHOAEEA[] NPGEMLKNGNJ;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6402ED0", Offset = "0x64016D0", VA = "0x186402ED0")]
	public static void AEFMFEKFKCK(int IMEMAMFKACF, int JKBBFCNPHMM, [Out] BIOJOAOKOKF DGNEBDIGEAC, [Out] int EOBKACBCLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6402FE0", Offset = "0x64017E0", VA = "0x186402FE0")]
	public static void ENNCNEAEDHJ(int OJEEANKDEPJ, [Out] BIOJOAOKOKF DGNEBDIGEAC, [Out] int HJFLLEGFJPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[DefaultMember("Item")]
internal struct FKJCFIKFJJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] MHCEKABKGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int OKLBOBFEAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int NOFNHILLCNP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x64001A0", Offset = "0x63FE9A0", VA = "0x1864001A0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3071930", Offset = "0x3070130", VA = "0x183071930")]
	public FKJCFIKFJJP(byte[] MHCEKABKGED, int OKLBOBFEAFH, int HPFMIMMLOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1F44430", Offset = "0x1F42C30", VA = "0x181F44430")]
	public int HPFMIMMLOKB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6400140", Offset = "0x63FE940", VA = "0x186400140")]
	public FKJCFIKFJJP FJNEFHIFNCM(int LCPBKJHNPEO, int CAPCAEOFDEO)
	{
		return default(FKJCFIKFJJP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class GKHHEBFCIMI
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] MDJCOFLFDAL;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] AKMJFKDOOON;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int DCNAELBDGGM;

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6402000", Offset = "0x6400800", VA = "0x186402000")]
	private static byte[] JMFHNBFOMBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6401550", Offset = "0x63FFD50", VA = "0x186401550")]
	private static FKJCFIKFJJP HEAEHICFOMH(FKJCFIKFJJP NEJFCHMJPKN)
	{
		return default(FKJCFIKFJJP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6400B90", Offset = "0x63FF390", VA = "0x186400B90")]
	private static FKJCFIKFJJP AHCOHELMDLB(FKJCFIKFJJP NEJFCHMJPKN)
	{
		return default(FKJCFIKFJJP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x64023C0", Offset = "0x6400BC0", VA = "0x1864023C0")]
	private static void NMPPKOBBIJJ(FKJCFIKFJJP NEJFCHMJPKN, int NKMAKDPHLEA, byte[] GMEFIMFGFHA, [Out] int NBMFLIMEHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x64016C0", Offset = "0x63FFEC0", VA = "0x1864016C0")]
	private static void JJFALLFGOAN(FKJCFIKFJJP NEJFCHMJPKN, int NKMAKDPHLEA, byte[] BDHGGPDJLOB, int PBKNKKNOPPA, [Out] FKJCFIKFJJP PJBHDKCBHAA, [Out] int HJNBFMJBLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6401630", Offset = "0x63FFE30", VA = "0x186401630")]
	private static ulong IBCNBJKJNMF(FKJCFIKFJJP NEJFCHMJPKN, [Out] int OPCEIAEFCBN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x64020E0", Offset = "0x64008E0", VA = "0x1864020E0")]
	private static void MNJMFFDOMGK(FKJCFIKFJJP NEJFCHMJPKN, [Out] BIOJOAOKOKF KMHAEDONIKI, [Out] int FAOLCFIJOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6400D90", Offset = "0x63FF590", VA = "0x186400D90")]
	private static bool ENEIGGOOIHA(FKJCFIKFJJP PJBHDKCBHAA, int NKMAKDPHLEA, [Out] double KMHAEDONIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6402220", Offset = "0x6400A20", VA = "0x186402220")]
	private static BIOJOAOKOKF NGHOLOBJGEA(int NKMAKDPHLEA)
	{
		return default(BIOJOAOKOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x64019B0", Offset = "0x64001B0", VA = "0x1864019B0")]
	private static bool JMDPCLBDIOH(FKJCFIKFJJP NEJFCHMJPKN, int NKMAKDPHLEA, [Out] double KMHAEDONIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6401160", Offset = "0x63FF960", VA = "0x186401160")]
	private static bool FDFHOOAGILF(FKJCFIKFJJP PJBHDKCBHAA, int NKMAKDPHLEA, [Out] double JBEHGMJDIMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6400C70", Offset = "0x63FF470", VA = "0x186400C70")]
	public static double? BELINBFCHEP(FKJCFIKFJJP NEJFCHMJPKN, int NKMAKDPHLEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6401280", Offset = "0x63FFA80", VA = "0x186401280")]
	public static float? FNHBDCACIAG(FKJCFIKFJJP NEJFCHMJPKN, int NKMAKDPHLEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal struct NHKOPOOHJAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] NEJFCHMJPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int GDMKPCJDDGD;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte PENMJFOMGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6422510", Offset = "0x6420D10", VA = "0x186422510")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x166AF70", Offset = "0x1669770", VA = "0x18166AF70")]
	public NHKOPOOHJAF(byte[] NEJFCHMJPKN, int GDMKPCJDDGD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x64224D0", Offset = "0x6420CD0", VA = "0x1864224D0")]
	public static NHKOPOOHJAF CABDFMEPFKG(NHKOPOOHJAF AFFJMIFONEM)
	{
		return default(NHKOPOOHJAF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6422580", Offset = "0x6420D80", VA = "0x186422580")]
	public static NHKOPOOHJAF KMOGMICJDHO(NHKOPOOHJAF AFFJMIFONEM, int HPFMIMMLOKB)
	{
		return default(NHKOPOOHJAF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6422570", Offset = "0x6420D70", VA = "0x186422570")]
	public static int JEOOEADEPIC(NHKOPOOHJAF LOKIPHPAIAD, NHKOPOOHJAF CGHEAIJKHIK)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6422490", Offset = "0x6420C90", VA = "0x186422490")]
	public static bool BIBGNMIHGGC(NHKOPOOHJAF LOKIPHPAIAD, NHKOPOOHJAF CGHEAIJKHIK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6422600", Offset = "0x6420E00", VA = "0x186422600")]
	public static bool LBEMCIDNPGP(NHKOPOOHJAF LOKIPHPAIAD, NHKOPOOHJAF CGHEAIJKHIK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x64224A0", Offset = "0x6420CA0", VA = "0x1864224A0")]
	public static bool BIBGNMIHGGC(NHKOPOOHJAF LOKIPHPAIAD, char CGHEAIJKHIK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x64225D0", Offset = "0x6420DD0", VA = "0x1864225D0")]
	public static bool LBEMCIDNPGP(NHKOPOOHJAF LOKIPHPAIAD, char CGHEAIJKHIK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x64225D0", Offset = "0x6420DD0", VA = "0x1864225D0")]
	public static bool LBEMCIDNPGP(NHKOPOOHJAF LOKIPHPAIAD, byte CGHEAIJKHIK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x64224E0", Offset = "0x6420CE0", VA = "0x1864224E0")]
	public static bool COILKNIHEED(NHKOPOOHJAF LOKIPHPAIAD, char CGHEAIJKHIK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6422540", Offset = "0x6420D40", VA = "0x186422540")]
	public static bool GABEJBHGMJA(NHKOPOOHJAF LOKIPHPAIAD, char CGHEAIJKHIK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6422610", Offset = "0x6420E10", VA = "0x186422610")]
	public static bool OPGOKDKHFLI(NHKOPOOHJAF LOKIPHPAIAD, char CGHEAIJKHIK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6422460", Offset = "0x6420C60", VA = "0x186422460")]
	public static bool AHMBDGCKJNM(NHKOPOOHJAF LOKIPHPAIAD, char CGHEAIJKHIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class DLKFPJIIIDN
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] FHNHIFKBNKK;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] KLAHLCGEFEB;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] JLEODBEGPEL;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] NMACBCLFBMF;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] MIIIMMCKCOJ;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int NOOGGLOBEHH;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] DOPJBOEAKEO;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int IHDNFKNEKGG;

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6414090", Offset = "0x6412890", VA = "0x186414090")]
	private static byte[] GCCJCJJLILN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x64154F0", Offset = "0x6413CF0", VA = "0x1864154F0")]
	private static byte[] OMCIGPEJCME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6413FE0", Offset = "0x64127E0", VA = "0x186413FE0")]
	public static double AFPDGEDBLLC(byte[] NEJFCHMJPKN, int GDMKPCJDDGD, [Out] int JINBOHBFEPP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x64145C0", Offset = "0x6412DC0", VA = "0x1864145C0")]
	public static float KBJPODPBDPG(byte[] NEJFCHMJPKN, int GDMKPCJDDGD, [Out] int JINBOHBFEPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x64143B0", Offset = "0x6412BB0", VA = "0x1864143B0")]
	private static bool HGOPHBAMDHB(int IILAPOMEGLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6414170", Offset = "0x6412970", VA = "0x186414170")]
	private static bool HBOLKBMGJHL(NHKOPOOHJAF HJHABDMAAIM, NHKOPOOHJAF NHGOLACKIAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x64144F0", Offset = "0x6412CF0", VA = "0x1864144F0")]
	private static bool IEEGFMGPANC(NHKOPOOHJAF HJHABDMAAIM, NHKOPOOHJAF NHGOLACKIAD, byte[] IAPDDOCABPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x6414360", Offset = "0x6412B60", VA = "0x186414360")]
	private static bool HFHAOFJAKPA(NHKOPOOHJAF EHKFKPEFMCF, byte[] OLGPFNCCCJM, int GDMKPCJDDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x64155D0", Offset = "0x6413DD0", VA = "0x1864155D0")]
	private static double PNLCNJDACEF(bool IMEBJOPNDML)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6414670", Offset = "0x6412E70", VA = "0x186414670")]
	private static double NPOFHDHJEDG(NHKOPOOHJAF EIGOIPKAPOI, int HPFMIMMLOKB, bool NGJAOLINKKE, [Out] int JCNKIACICCP)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class EDIEJGJAFGK<T> : GGKCAJABCKP<T[]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly OENIMBCKGDG<T> IKHPJPKIOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly HNCOLKIOEOE HDKNPOMLHAC;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x305D780", Offset = "0x305BF80", VA = "0x18305D780")]
	public EDIEJGJAFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
	public EDIEJGJAFGK(HNCOLKIOEOE HDKNPOMLHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x305ACA0", Offset = "0x30594A0", VA = "0x18305ACA0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, T[] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x305B7C0", Offset = "0x3059FC0", VA = "0x18305B7C0", Slot = "5")]
	public T[] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class LPKMHIGOGBN<T> : GGKCAJABCKP<ArraySegment<T>>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly OENIMBCKGDG<T> IKHPJPKIOEH;

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3935780", Offset = "0x3933F80", VA = "0x183935780", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, ArraySegment<T> FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3935AA0", Offset = "0x39342A0", VA = "0x183935AA0", Slot = "5")]
	public ArraySegment<T> PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class IGJAIPMEJFN<T> : GGKCAJABCKP<List<T>>, JFICJNJNNFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly HNCOLKIOEOE HDKNPOMLHAC;

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x305D780", Offset = "0x305BF80", VA = "0x18305D780")]
	public IGJAIPMEJFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
	public IGJAIPMEJFN(HNCOLKIOEOE HDKNPOMLHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x363B2B0", Offset = "0x3639AB0", VA = "0x18363B2B0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, List<T> FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x363D120", Offset = "0x363B920", VA = "0x18363D120", Slot = "5")]
	public List<T> PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class FGILABOCNGB<TElement, TIntermediate, TEnumerator, TCollection> : GGKCAJABCKP<TCollection>, JFICJNJNNFJ where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x340FA30", Offset = "0x340E230", VA = "0x18340FA30", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, TCollection FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3411920", Offset = "0x3410120", VA = "0x183411920", Slot = "5")]
	public TCollection PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator EMDMEEDECED(TCollection KLIANGHAKAC);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate KLKFANDJKFE();

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void BONJGFNEKBE(TIntermediate ANFFPMOOHGF, int LFEFGCGCIAG, TElement FKKGMPDEPMA);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection ACJKICPGHOE(TIntermediate LNJPFJNGKKD);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	protected FGILABOCNGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class GFNIGLADPPD<TElement, TIntermediate, TCollection> : FGILABOCNGB<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x34DB0B0", Offset = "0x34D98B0", VA = "0x1834DB0B0", Slot = "6")]
	protected override IEnumerator<TElement> EMDMEEDECED(TCollection KLIANGHAKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x3018460", Offset = "0x3016C60", VA = "0x183018460")]
	protected GFNIGLADPPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public abstract class EMEOGHAGPBO<TElement, TCollection> : GFNIGLADPPD<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0xC7D1D0", Offset = "0xC7B9D0", VA = "0x180C7D1D0", Slot = "9")]
	protected sealed override TCollection ACJKICPGHOE(TCollection LNJPFJNGKKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class IBOFOJDLOAO<TElement, TCollection> : EMEOGHAGPBO<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x36223E0", Offset = "0x3620BE0", VA = "0x1836223E0", Slot = "7")]
	protected override TCollection KLKFANDJKFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3622320", Offset = "0x3620B20", VA = "0x183622320", Slot = "8")]
	protected override void BONJGFNEKBE(TCollection ANFFPMOOHGF, int LFEFGCGCIAG, TElement FKKGMPDEPMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class DOIMONHCIPB<T> : FGILABOCNGB<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3057290", Offset = "0x3055A90", VA = "0x183057290", Slot = "8")]
	protected override void BONJGFNEKBE(LinkedList<T> ANFFPMOOHGF, int LFEFGCGCIAG, T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0xC7D1D0", Offset = "0xC7B9D0", VA = "0x180C7D1D0", Slot = "9")]
	protected override LinkedList<T> ACJKICPGHOE(LinkedList<T> LNJPFJNGKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3057330", Offset = "0x3055B30", VA = "0x183057330", Slot = "7")]
	protected override LinkedList<T> KLKFANDJKFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3072A80", Offset = "0x3071280", VA = "0x183072A80", Slot = "6")]
	protected override LinkedList<T>.Enumerator EMDMEEDECED(LinkedList<T> KLIANGHAKAC)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class LDKCHOOOJNN<T> : FGILABOCNGB<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3057290", Offset = "0x3055A90", VA = "0x183057290", Slot = "8")]
	protected override void BONJGFNEKBE(Queue<T> ANFFPMOOHGF, int LFEFGCGCIAG, T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3057330", Offset = "0x3055B30", VA = "0x183057330", Slot = "7")]
	protected override Queue<T> KLKFANDJKFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x30572D0", Offset = "0x3055AD0", VA = "0x1830572D0", Slot = "6")]
	protected override Queue<T>.Enumerator EMDMEEDECED(Queue<T> KLIANGHAKAC)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0xC7D1D0", Offset = "0xC7B9D0", VA = "0x180C7D1D0", Slot = "9")]
	protected override Queue<T> ACJKICPGHOE(Queue<T> LNJPFJNGKKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class CJFILBJHIOD<T> : FGILABOCNGB<T, HPNJNCJIHEE<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x358CAF0", Offset = "0x358B2F0", VA = "0x18358CAF0", Slot = "8")]
	protected override void BONJGFNEKBE(HPNJNCJIHEE<T> ANFFPMOOHGF, int LFEFGCGCIAG, T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x358CB20", Offset = "0x358B320", VA = "0x18358CB20", Slot = "7")]
	protected override HPNJNCJIHEE<T> KLKFANDJKFE()
	{
		return default(HPNJNCJIHEE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x4B58FD0", Offset = "0x4B577D0", VA = "0x184B58FD0", Slot = "6")]
	protected override Stack<T>.Enumerator EMDMEEDECED(Stack<T> KLIANGHAKAC)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x4B58EF0", Offset = "0x4B576F0", VA = "0x184B58EF0", Slot = "9")]
	protected override Stack<T> ACJKICPGHOE(HPNJNCJIHEE<T> LNJPFJNGKKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class ECKAJPKDBBO<T> : FGILABOCNGB<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3057290", Offset = "0x3055A90", VA = "0x183057290", Slot = "8")]
	protected override void BONJGFNEKBE(HashSet<T> ANFFPMOOHGF, int LFEFGCGCIAG, T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xC7D1D0", Offset = "0xC7B9D0", VA = "0x180C7D1D0", Slot = "9")]
	protected override HashSet<T> ACJKICPGHOE(HashSet<T> LNJPFJNGKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3057330", Offset = "0x3055B30", VA = "0x183057330", Slot = "7")]
	protected override HashSet<T> KLKFANDJKFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x30572D0", Offset = "0x3055AD0", VA = "0x1830572D0", Slot = "6")]
	protected override HashSet<T>.Enumerator EMDMEEDECED(HashSet<T> KLIANGHAKAC)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class DGCPECBEGAD<T> : GFNIGLADPPD<T, HPNJNCJIHEE<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x358CAF0", Offset = "0x358B2F0", VA = "0x18358CAF0", Slot = "8")]
	protected override void BONJGFNEKBE(HPNJNCJIHEE<T> ANFFPMOOHGF, int LFEFGCGCIAG, T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x4D174E0", Offset = "0x4D15CE0", VA = "0x184D174E0", Slot = "9")]
	protected override ReadOnlyCollection<T> ACJKICPGHOE(HPNJNCJIHEE<T> LNJPFJNGKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x4D17580", Offset = "0x4D15D80", VA = "0x184D17580", Slot = "7")]
	protected override HPNJNCJIHEE<T> KLKFANDJKFE()
	{
		return default(HPNJNCJIHEE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class CPGNMIFEFAH<T> : GFNIGLADPPD<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3057290", Offset = "0x3055A90", VA = "0x183057290", Slot = "8")]
	protected override void BONJGFNEKBE(List<T> ANFFPMOOHGF, int LFEFGCGCIAG, T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x3057330", Offset = "0x3055B30", VA = "0x183057330", Slot = "7")]
	protected override List<T> KLKFANDJKFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0xC7D1D0", Offset = "0xC7B9D0", VA = "0x180C7D1D0", Slot = "9")]
	protected override IList<T> ACJKICPGHOE(List<T> LNJPFJNGKKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class OACBILLIKAK<T> : GFNIGLADPPD<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3057290", Offset = "0x3055A90", VA = "0x183057290", Slot = "8")]
	protected override void BONJGFNEKBE(List<T> ANFFPMOOHGF, int LFEFGCGCIAG, T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3057330", Offset = "0x3055B30", VA = "0x183057330", Slot = "7")]
	protected override List<T> KLKFANDJKFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0xC7D1D0", Offset = "0xC7B9D0", VA = "0x180C7D1D0", Slot = "9")]
	protected override ICollection<T> ACJKICPGHOE(List<T> LNJPFJNGKKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class DCDCPKCJJCF<T> : GFNIGLADPPD<T, HPNJNCJIHEE<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x358CAF0", Offset = "0x358B2F0", VA = "0x18358CAF0", Slot = "8")]
	protected override void BONJGFNEKBE(HPNJNCJIHEE<T> ANFFPMOOHGF, int LFEFGCGCIAG, T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x358CB20", Offset = "0x358B320", VA = "0x18358CB20", Slot = "7")]
	protected override HPNJNCJIHEE<T> KLKFANDJKFE()
	{
		return default(HPNJNCJIHEE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x4CE3890", Offset = "0x4CE2090", VA = "0x184CE3890", Slot = "9")]
	protected override IEnumerable<T> ACJKICPGHOE(HPNJNCJIHEE<T> LNJPFJNGKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x3022820", Offset = "0x3021020", VA = "0x183022820")]
	public DCDCPKCJJCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class IGDCOKEAAHE<TKey, TElement> : GGKCAJABCKP<IGrouping<TKey, TElement>>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3639A20", Offset = "0x3638220", VA = "0x183639A20", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, IGrouping<TKey, TElement> FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3639CA0", Offset = "0x36384A0", VA = "0x183639CA0", Slot = "5")]
	public IGrouping<TKey, TElement> PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class ELMDIIPBHNK<TKey, TElement> : GGKCAJABCKP<ILookup<TKey, TElement>>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3094D00", Offset = "0x3093500", VA = "0x183094D00", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, ILookup<TKey, TElement> FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3094EA0", Offset = "0x30936A0", VA = "0x183094EA0", Slot = "5")]
	public ILookup<TKey, TElement> PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class GKAAKAPLNAC<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly TKey OHPCNPKOLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly IEnumerable<TElement> EGHGICGKMKC;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey LKLFDONKJGP
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7619F0", Offset = "0x7601F0", VA = "0x1807619F0")]
	public GKAAKAPLNAC(TKey OHPCNPKOLBJ, IEnumerable<TElement> EGHGICGKMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x34E8300", Offset = "0x34E6B00", VA = "0x1834E8300", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x30EF790", Offset = "0x30EDF90", VA = "0x1830EF790", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[DefaultMember("Item")]
internal class EGHPPKPHLKC<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> PJEFDKIONOM;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x3069F70", Offset = "0x3068770", VA = "0x183069F70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	public EGHPPKPHLKC(Dictionary<TKey, IGrouping<TKey, TElement>> PJEFDKIONOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3069E70", Offset = "0x3068670", VA = "0x183069E70", Slot = "5")]
	public bool Contains(TKey OHPCNPKOLBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3069EB0", Offset = "0x30686B0", VA = "0x183069EB0", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3069EB0", Offset = "0x30686B0", VA = "0x183069EB0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class AADPGODFODI<T> : GGKCAJABCKP<T>, JFICJNJNNFJ where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x3476150", Offset = "0x3474950", VA = "0x183476150", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, T FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3476480", Offset = "0x3474C80", VA = "0x183476480", Slot = "5")]
	public T PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public AADPGODFODI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class HPOOAILJMOB : GGKCAJABCKP<IEnumerable>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly GGKCAJABCKP<IEnumerable> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x641C110", Offset = "0x641A910", VA = "0x18641C110", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, IEnumerable FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x641C3C0", Offset = "0x641ABC0", VA = "0x18641C3C0", Slot = "5")]
	public IEnumerable PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public HPOOAILJMOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class JKNAPPCOAGN : GGKCAJABCKP<ICollection>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly GGKCAJABCKP<ICollection> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x641D890", Offset = "0x641C090", VA = "0x18641D890", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, ICollection FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x641DC30", Offset = "0x641C430", VA = "0x18641DC30", Slot = "5")]
	public ICollection PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JKNAPPCOAGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class CDLEMBGMGNP : GGKCAJABCKP<IList>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly GGKCAJABCKP<IList> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6411F30", Offset = "0x6410730", VA = "0x186411F30", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, IList FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6412260", Offset = "0x6410A60", VA = "0x186412260", Slot = "5")]
	public IList PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public CDLEMBGMGNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class HGOGAMBPBGF<T> : GFNIGLADPPD<T, HPNJNCJIHEE<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x358CAC0", Offset = "0x358B2C0", VA = "0x18358CAC0", Slot = "8")]
	protected override void BONJGFNEKBE(HPNJNCJIHEE<T> ANFFPMOOHGF, int LFEFGCGCIAG, T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x358CB20", Offset = "0x358B320", VA = "0x18358CB20", Slot = "7")]
	protected override HPNJNCJIHEE<T> KLKFANDJKFE()
	{
		return default(HPNJNCJIHEE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x358CA40", Offset = "0x358B240", VA = "0x18358CA40", Slot = "9")]
	protected override IReadOnlyList<T> ACJKICPGHOE(HPNJNCJIHEE<T> LNJPFJNGKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x30269E0", Offset = "0x30251E0", VA = "0x1830269E0")]
	public HGOGAMBPBGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class FEPDBILMCIE
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6417220", Offset = "0x6415A20", VA = "0x186417220")]
	public static DateTime GDFEKIKLMIB(DateTime BOFDOJBCPOK)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class GGEPEFCCPIO : GGKCAJABCKP<DateTime>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public static readonly GGKCAJABCKP<DateTime> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6418870", Offset = "0x6417070", VA = "0x186418870", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, DateTime FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6419020", Offset = "0x6417820", VA = "0x186419020", Slot = "5")]
	public DateTime PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public GGEPEFCCPIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class KDGPHEFNMDP : GGKCAJABCKP<DateTimeOffset>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly GGKCAJABCKP<DateTimeOffset> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x641ED50", Offset = "0x641D550", VA = "0x18641ED50", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, DateTimeOffset FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x641F3F0", Offset = "0x641DBF0", VA = "0x18641F3F0", Slot = "5")]
	public DateTimeOffset PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public KDGPHEFNMDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class JMAKJLDFCCO : GGKCAJABCKP<TimeSpan>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public static readonly GGKCAJABCKP<TimeSpan> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static byte[] NABDIBHAPAD;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x641DF00", Offset = "0x641C700", VA = "0x18641DF00", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, TimeSpan FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x641E2E0", Offset = "0x641CAE0", VA = "0x18641E2E0", Slot = "5")]
	public TimeSpan PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JMAKJLDFCCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public abstract class GKIFGPPLBOO<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : GGKCAJABCKP<TDictionary>, JFICJNJNNFJ where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x34E9CC0", Offset = "0x34E84C0", VA = "0x1834E9CC0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, TDictionary FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x34EAFC0", Offset = "0x34E97C0", VA = "0x1834EAFC0", Slot = "5")]
	public TDictionary PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator EMDMEEDECED(TDictionary KLIANGHAKAC);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate KLKFANDJKFE();

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void BONJGFNEKBE(TIntermediate ANFFPMOOHGF, int LFEFGCGCIAG, TKey OHPCNPKOLBJ, TValue FKKGMPDEPMA);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary ACJKICPGHOE(TIntermediate LNJPFJNGKKD);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	protected GKIFGPPLBOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class MKEPGOGALNO<TKey, TValue, TIntermediate, TDictionary> : GKIFGPPLBOO<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x3B26BF0", Offset = "0x3B253F0", VA = "0x183B26BF0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> EMDMEEDECED(TDictionary KLIANGHAKAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class JKNKGKCDBDB<TKey, TValue, TDictionary> : MKEPGOGALNO<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0xC7D1D0", Offset = "0xC7B9D0", VA = "0x180C7D1D0", Slot = "9")]
	protected override TDictionary ACJKICPGHOE(TDictionary LNJPFJNGKKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class EJBOJKFBMPB<TKey, TValue> : GKIFGPPLBOO<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x30729F0", Offset = "0x30711F0", VA = "0x1830729F0", Slot = "8")]
	protected override void BONJGFNEKBE(Dictionary<TKey, TValue> ANFFPMOOHGF, int LFEFGCGCIAG, TKey OHPCNPKOLBJ, TValue FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0xC7D1D0", Offset = "0xC7B9D0", VA = "0x180C7D1D0", Slot = "9")]
	protected override Dictionary<TKey, TValue> ACJKICPGHOE(Dictionary<TKey, TValue> LNJPFJNGKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x3057330", Offset = "0x3055B30", VA = "0x183057330", Slot = "7")]
	protected override Dictionary<TKey, TValue> KLKFANDJKFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x3072B50", Offset = "0x3071350", VA = "0x183072B50", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator EMDMEEDECED(Dictionary<TKey, TValue> KLIANGHAKAC)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3017AD0", Offset = "0x30162D0", VA = "0x183017AD0")]
	public EJBOJKFBMPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class PJBLBBCPKLI<TKey, TValue, TDictionary> : JKNKGKCDBDB<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8C80", Offset = "0x3DB7480", VA = "0x183DB8C80", Slot = "8")]
	protected override void BONJGFNEKBE(TDictionary ANFFPMOOHGF, int LFEFGCGCIAG, TKey OHPCNPKOLBJ, TValue FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2E96740", Offset = "0x2E94F40", VA = "0x182E96740", Slot = "7")]
	protected override TDictionary KLKFANDJKFE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class LICMANJLFBB<TKey, TValue> : MKEPGOGALNO<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x30729B0", Offset = "0x30711B0", VA = "0x1830729B0", Slot = "8")]
	protected override void BONJGFNEKBE(Dictionary<TKey, TValue> ANFFPMOOHGF, int LFEFGCGCIAG, TKey OHPCNPKOLBJ, TValue FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x3057330", Offset = "0x3055B30", VA = "0x183057330", Slot = "7")]
	protected override Dictionary<TKey, TValue> KLKFANDJKFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0xC7D1D0", Offset = "0xC7B9D0", VA = "0x180C7D1D0", Slot = "9")]
	protected override IDictionary<TKey, TValue> ACJKICPGHOE(Dictionary<TKey, TValue> LNJPFJNGKKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class AJPLAJNGCHH<TKey, TValue> : JKNKGKCDBDB<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x30729B0", Offset = "0x30711B0", VA = "0x1830729B0", Slot = "8")]
	protected override void BONJGFNEKBE(SortedList<TKey, TValue> ANFFPMOOHGF, int LFEFGCGCIAG, TKey OHPCNPKOLBJ, TValue FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3057330", Offset = "0x3055B30", VA = "0x183057330", Slot = "7")]
	protected override SortedList<TKey, TValue> KLKFANDJKFE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class HPECLHECAPE<TKey, TValue> : GKIFGPPLBOO<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x30729B0", Offset = "0x30711B0", VA = "0x1830729B0", Slot = "8")]
	protected override void BONJGFNEKBE(SortedDictionary<TKey, TValue> ANFFPMOOHGF, int LFEFGCGCIAG, TKey OHPCNPKOLBJ, TValue FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0xC7D1D0", Offset = "0xC7B9D0", VA = "0x180C7D1D0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> ACJKICPGHOE(SortedDictionary<TKey, TValue> LNJPFJNGKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3057330", Offset = "0x3055B30", VA = "0x183057330", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> KLKFANDJKFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3072B50", Offset = "0x3071350", VA = "0x183072B50", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator EMDMEEDECED(SortedDictionary<TKey, TValue> KLIANGHAKAC)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class LICHFFJIBNM<T> : GGKCAJABCKP<T>, JFICJNJNNFJ where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3922780", Offset = "0x3920F80", VA = "0x183922780", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, T FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3922C60", Offset = "0x3921460", VA = "0x183922C60", Slot = "5")]
	public T PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public LICHFFJIBNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class CEDFIEFGEIG : GGKCAJABCKP<IDictionary>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public static readonly GGKCAJABCKP<IDictionary> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6412530", Offset = "0x6410D30", VA = "0x186412530", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, IDictionary FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6412A10", Offset = "0x6411210", VA = "0x186412A10", Slot = "5")]
	public IDictionary PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public CEDFIEFGEIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class NBHMDHDBKPK : GGKCAJABCKP<object>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private delegate void FKDDJKLEKBA(object IPAIGEEHAFP, LDODEOAPOMB MCLDKNNIMFL, object FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private readonly IBKOFOPCOOH<KeyValuePair<object, FKDDJKLEKBA>> NHBLKHDNJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private readonly CBBFEPDHKGO[] AJAHEPJNBOC;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x64223B0", Offset = "0x6420BB0", VA = "0x1864223B0")]
	public NBHMDHDBKPK(params CBBFEPDHKGO[] AJAHEPJNBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6421960", Offset = "0x6420160", VA = "0x186421960", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, object FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6422320", Offset = "0x6420B20", VA = "0x186422320", Slot = "5")]
	public object PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class FHDAEHKIJHC
{
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x6417BD0", Offset = "0x64163D0", VA = "0x186417BD0")]
	public static object FCMAPBJJHHE(Type GFGNPBCFEMC, [Out] bool NAFPLEKNEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x64172E0", Offset = "0x6415AE0", VA = "0x1864172E0")]
	public static object ALECNIPBAKL(Type GFGNPBCFEMC, [Out] bool NAFPLEKNEHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public class CHMCLMCGFFA<T> : GGKCAJABCKP<T>, JFICJNJNNFJ, JLCOFNPFLDJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class ODFBCKIEAGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ODFBCKIEAGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB5B0", Offset = "0x3CC9DB0", VA = "0x183CCB5B0")]
		internal bool LBBHCAMPKNL(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class BPLPKEHAEMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public BPLPKEHAEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x4898C70", Offset = "0x4897470", VA = "0x184898C70")]
		internal bool BGBNPGHMJKK(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class FDNLFCLFFMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public KIKABMJOFAO<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public FDNLFCLFFMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x340D6D0", Offset = "0x340BED0", VA = "0x18340D6D0")]
		internal void HAFCCMEEAHL(LDODEOAPOMB writer, T value, CBBFEPDHKGO _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class LCPAPAAJBAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public KCHAJGNMLDG<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public LCPAPAAJBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x3915E10", Offset = "0x3914610", VA = "0x183915E10")]
		internal T NBAHGJEMGKD(ABJCIMHBCLJ reader, CBBFEPDHKGO _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly OCLFDNMABDH<T> GKDBHPPDGMC;

	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private static readonly Dictionary<T, string> AFAJLEGFPNK;

	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private static readonly KIKABMJOFAO<T> AJGGLJKMNMA;

	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private static readonly KCHAJGNMLDG<T> DLGAOCDPCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private readonly bool FBAJGNLNOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private readonly KIKABMJOFAO<T> CKHFAPLIKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private readonly KCHAJGNMLDG<T> DILKMELADAC;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x4AD53A0", Offset = "0x4AD3BA0", VA = "0x184AD53A0")]
	static CHMCLMCGFFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x4ADAF80", Offset = "0x4AD9780", VA = "0x184ADAF80")]
	public CHMCLMCGFFA(bool FBAJGNLNOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x4AD2FD0", Offset = "0x4AD17D0", VA = "0x184AD2FD0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, T FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x4AD4160", Offset = "0x4AD2960", VA = "0x184AD4160", Slot = "5")]
	public T PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x4AD3890", Offset = "0x4AD2090", VA = "0x184AD3890", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, T FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x4AD3E20", Offset = "0x4AD2620", VA = "0x184AD3E20", Slot = "7")]
	public T IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class EELEHKPCJFF<T> : GGKCAJABCKP<T[,]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3064150", Offset = "0x3062950", VA = "0x183064150", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, T[,] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x30643C0", Offset = "0x3062BC0", VA = "0x1830643C0", Slot = "5")]
	public T[,] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public EELEHKPCJFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class MBJOGGKMKEO<T> : GGKCAJABCKP<T[,,]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3AE0C20", Offset = "0x3ADF420", VA = "0x183AE0C20", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, T[,,] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3AE0F40", Offset = "0x3ADF740", VA = "0x183AE0F40", Slot = "5")]
	public T[,,] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public MBJOGGKMKEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class NLPGKLOFGDM<T> : GGKCAJABCKP<T[,,,]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1880", Offset = "0x3BF0080", VA = "0x183BF1880", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, T[,,,] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1C60", Offset = "0x3BF0460", VA = "0x183BF1C60", Slot = "5")]
	public T[,,,] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public NLPGKLOFGDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class LBPGDBMKGJK<T> : GGKCAJABCKP<T?>, JFICJNJNNFJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x3912DB0", Offset = "0x39115B0", VA = "0x183912DB0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, T? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x3912F30", Offset = "0x3911730", VA = "0x183912F30", Slot = "5")]
	public T? PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public LBPGDBMKGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class HKPCFLACNCG<T> : GGKCAJABCKP<T?>, JFICJNJNNFJ where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly GGKCAJABCKP<T> FCHNJMEIGLD;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	public HKPCFLACNCG(GGKCAJABCKP<T> FCHNJMEIGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3593FF0", Offset = "0x35927F0", VA = "0x183593FF0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, T? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3595230", Offset = "0x3593A30", VA = "0x183595230", Slot = "5")]
	public T? PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class FJEKKOGEMJJ : GGKCAJABCKP<sbyte>, JFICJNJNNFJ, JLCOFNPFLDJ<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly FJEKKOGEMJJ MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x64184C0", Offset = "0x6416CC0", VA = "0x1864184C0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, sbyte FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6418650", Offset = "0x6416E50", VA = "0x186418650", Slot = "5")]
	public sbyte PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6418520", Offset = "0x6416D20", VA = "0x186418520", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, sbyte FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6418590", Offset = "0x6416D90", VA = "0x186418590", Slot = "7")]
	public sbyte IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public FJEKKOGEMJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class PDBELAKDIAN : GGKCAJABCKP<sbyte?>, JFICJNJNNFJ, JLCOFNPFLDJ<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly PDBELAKDIAN MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6423DF0", Offset = "0x64225F0", VA = "0x186423DF0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, sbyte? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6424090", Offset = "0x6422890", VA = "0x186424090", Slot = "5")]
	public sbyte? PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6423EB0", Offset = "0x64226B0", VA = "0x186423EB0", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, sbyte? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6423F70", Offset = "0x6422770", VA = "0x186423F70", Slot = "7")]
	public sbyte? IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public PDBELAKDIAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class KEAAKNLIDCJ : GGKCAJABCKP<sbyte[]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly KEAAKNLIDCJ MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x6420090", Offset = "0x641E890", VA = "0x186420090", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, sbyte[] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x64201C0", Offset = "0x641E9C0", VA = "0x1864201C0", Slot = "5")]
	public sbyte[] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public KEAAKNLIDCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class DNFEBELELAL : GGKCAJABCKP<short>, JFICJNJNNFJ, JLCOFNPFLDJ<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly DNFEBELELAL MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x64158A0", Offset = "0x64140A0", VA = "0x1864158A0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, short FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6415A30", Offset = "0x6414230", VA = "0x186415A30", Slot = "5")]
	public short PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x6415900", Offset = "0x6414100", VA = "0x186415900", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, short FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x6415970", Offset = "0x6414170", VA = "0x186415970", Slot = "7")]
	public short IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public DNFEBELELAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class NPBNMLMGJLI : GGKCAJABCKP<short?>, JFICJNJNNFJ, JLCOFNPFLDJ<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly NPBNMLMGJLI MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6422F70", Offset = "0x6421770", VA = "0x186422F70", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, short? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x6423210", Offset = "0x6421A10", VA = "0x186423210", Slot = "5")]
	public short? PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x6423030", Offset = "0x6421830", VA = "0x186423030", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, short? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x64230F0", Offset = "0x64218F0", VA = "0x1864230F0", Slot = "7")]
	public short? IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public NPBNMLMGJLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class OMLCPLBLMGB : GGKCAJABCKP<short[]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly OMLCPLBLMGB MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x64238A0", Offset = "0x64220A0", VA = "0x1864238A0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, short[] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x64239D0", Offset = "0x64221D0", VA = "0x1864239D0", Slot = "5")]
	public short[] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public OMLCPLBLMGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class NKMFGBEDEID : GGKCAJABCKP<int>, JFICJNJNNFJ, JLCOFNPFLDJ<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly NKMFGBEDEID MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x6422990", Offset = "0x6421190", VA = "0x186422990", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, int FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x6422B20", Offset = "0x6421320", VA = "0x186422B20", Slot = "5")]
	public int PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x64229F0", Offset = "0x64211F0", VA = "0x1864229F0", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, int FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x6422A60", Offset = "0x6421260", VA = "0x186422A60", Slot = "7")]
	public int IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public NKMFGBEDEID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class EBHBAABPJMO : GGKCAJABCKP<int?>, JFICJNJNNFJ, JLCOFNPFLDJ<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly EBHBAABPJMO MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6415F00", Offset = "0x6414700", VA = "0x186415F00", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, int? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x64161A0", Offset = "0x64149A0", VA = "0x1864161A0", Slot = "5")]
	public int? PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x6415FC0", Offset = "0x64147C0", VA = "0x186415FC0", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, int? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x6416080", Offset = "0x6414880", VA = "0x186416080", Slot = "7")]
	public int? IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public EBHBAABPJMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class ANFAFICMLCL : GGKCAJABCKP<int[]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly ANFAFICMLCL MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x6411820", Offset = "0x6410020", VA = "0x186411820", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, int[] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x6411950", Offset = "0x6410150", VA = "0x186411950", Slot = "5")]
	public int[] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public ANFAFICMLCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class CONIJDCEOKB : GGKCAJABCKP<long>, JFICJNJNNFJ, JLCOFNPFLDJ<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly CONIJDCEOKB MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6413500", Offset = "0x6411D00", VA = "0x186413500", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, long FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x6413690", Offset = "0x6411E90", VA = "0x186413690", Slot = "5")]
	public long PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x6413560", Offset = "0x6411D60", VA = "0x186413560", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, long FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x64135D0", Offset = "0x6411DD0", VA = "0x1864135D0", Slot = "7")]
	public long IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public CONIJDCEOKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class IIIOPGEBPKH : GGKCAJABCKP<long?>, JFICJNJNNFJ, JLCOFNPFLDJ<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly IIIOPGEBPKH MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x641C870", Offset = "0x641B070", VA = "0x18641C870", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, long? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x641CB30", Offset = "0x641B330", VA = "0x18641CB30", Slot = "5")]
	public long? PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x641C930", Offset = "0x641B130", VA = "0x18641C930", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, long? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x641C9F0", Offset = "0x641B1F0", VA = "0x18641C9F0", Slot = "7")]
	public long? IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public IIIOPGEBPKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class CENOMNBNKNE : GGKCAJABCKP<long[]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly CENOMNBNKNE MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x6412CC0", Offset = "0x64114C0", VA = "0x186412CC0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, long[] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6412DF0", Offset = "0x64115F0", VA = "0x186412DF0", Slot = "5")]
	public long[] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public CENOMNBNKNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class CKJJNPPBAFN : GGKCAJABCKP<byte>, JFICJNJNNFJ, JLCOFNPFLDJ<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly CKJJNPPBAFN MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6413000", Offset = "0x6411800", VA = "0x186413000", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, byte FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6413190", Offset = "0x6411990", VA = "0x186413190", Slot = "5")]
	public byte PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6413060", Offset = "0x6411860", VA = "0x186413060", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, byte FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x64130D0", Offset = "0x64118D0", VA = "0x1864130D0", Slot = "7")]
	public byte IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public CKJJNPPBAFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class HOFPHBBKFCC : GGKCAJABCKP<byte?>, JFICJNJNNFJ, JLCOFNPFLDJ<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly HOFPHBBKFCC MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x641BD40", Offset = "0x641A540", VA = "0x18641BD40", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, byte? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x641BFE0", Offset = "0x641A7E0", VA = "0x18641BFE0", Slot = "5")]
	public byte? PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x641BE00", Offset = "0x641A600", VA = "0x18641BE00", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, byte? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x641BEC0", Offset = "0x641A6C0", VA = "0x18641BEC0", Slot = "7")]
	public byte? IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public HOFPHBBKFCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class EIENLIGFIKE : GGKCAJABCKP<ushort>, JFICJNJNNFJ, JLCOFNPFLDJ<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly EIENLIGFIKE MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x64164C0", Offset = "0x6414CC0", VA = "0x1864164C0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, ushort FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x6416650", Offset = "0x6414E50", VA = "0x186416650", Slot = "5")]
	public ushort PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x6416520", Offset = "0x6414D20", VA = "0x186416520", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, ushort FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x6416590", Offset = "0x6414D90", VA = "0x186416590", Slot = "7")]
	public ushort IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public EIENLIGFIKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class JFOKFOIEKFI : GGKCAJABCKP<ushort?>, JFICJNJNNFJ, JLCOFNPFLDJ<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly JFOKFOIEKFI MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x641D4C0", Offset = "0x641BCC0", VA = "0x18641D4C0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, ushort? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x641D760", Offset = "0x641BF60", VA = "0x18641D760", Slot = "5")]
	public ushort? PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x641D580", Offset = "0x641BD80", VA = "0x18641D580", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, ushort? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x641D640", Offset = "0x641BE40", VA = "0x18641D640", Slot = "7")]
	public ushort? IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JFOKFOIEKFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class OAGNDGOGIIC : GGKCAJABCKP<ushort[]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly OAGNDGOGIIC MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6423340", Offset = "0x6421B40", VA = "0x186423340", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, ushort[] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x6423470", Offset = "0x6421C70", VA = "0x186423470", Slot = "5")]
	public ushort[] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public OAGNDGOGIIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class DLDLFNFANPM : GGKCAJABCKP<uint>, JFICJNJNNFJ, JLCOFNPFLDJ<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly DLDLFNFANPM MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6413D80", Offset = "0x6412580", VA = "0x186413D80", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, uint FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6413F10", Offset = "0x6412710", VA = "0x186413F10", Slot = "5")]
	public uint PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6413DE0", Offset = "0x64125E0", VA = "0x186413DE0", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, uint FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6413E50", Offset = "0x6412650", VA = "0x186413E50", Slot = "7")]
	public uint IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public DLDLFNFANPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class MEPLMOKCNID : GGKCAJABCKP<uint?>, JFICJNJNNFJ, JLCOFNPFLDJ<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly MEPLMOKCNID MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6421250", Offset = "0x641FA50", VA = "0x186421250", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, uint? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x64214F0", Offset = "0x641FCF0", VA = "0x1864214F0", Slot = "5")]
	public uint? PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6421310", Offset = "0x641FB10", VA = "0x186421310", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, uint? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x64213D0", Offset = "0x641FBD0", VA = "0x1864213D0", Slot = "7")]
	public uint? IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public MEPLMOKCNID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class FDFJCLMHNAB : GGKCAJABCKP<uint[]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly FDFJCLMHNAB MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6416B10", Offset = "0x6415310", VA = "0x186416B10", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, uint[] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6416C40", Offset = "0x6415440", VA = "0x186416C40", Slot = "5")]
	public uint[] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public FDFJCLMHNAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class KHEGEOFKELL : GGKCAJABCKP<ulong>, JFICJNJNNFJ, JLCOFNPFLDJ<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly KHEGEOFKELL MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x64203D0", Offset = "0x641EBD0", VA = "0x1864203D0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, ulong FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6420560", Offset = "0x641ED60", VA = "0x186420560", Slot = "5")]
	public ulong PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6420430", Offset = "0x641EC30", VA = "0x186420430", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, ulong FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x64204A0", Offset = "0x641ECA0", VA = "0x1864204A0", Slot = "7")]
	public ulong IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public KHEGEOFKELL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class LMIHKMOJODD : GGKCAJABCKP<ulong?>, JFICJNJNNFJ, JLCOFNPFLDJ<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly LMIHKMOJODD MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6420E50", Offset = "0x641F650", VA = "0x186420E50", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, ulong? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6421110", Offset = "0x641F910", VA = "0x186421110", Slot = "5")]
	public ulong? PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6420F10", Offset = "0x641F710", VA = "0x186420F10", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, ulong? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x6420FD0", Offset = "0x641F7D0", VA = "0x186420FD0", Slot = "7")]
	public ulong? IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public LMIHKMOJODD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class MPLFGFBPDKL : GGKCAJABCKP<ulong[]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly MPLFGFBPDKL MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6421620", Offset = "0x641FE20", VA = "0x186421620", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, ulong[] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6421750", Offset = "0x641FF50", VA = "0x186421750", Slot = "5")]
	public ulong[] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public MPLFGFBPDKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class DEHIGMNCGCG : GGKCAJABCKP<float>, JFICJNJNNFJ, JLCOFNPFLDJ<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly DEHIGMNCGCG MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6413970", Offset = "0x6412170", VA = "0x186413970", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, float FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6413B00", Offset = "0x6412300", VA = "0x186413B00", Slot = "5")]
	public float PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x64139D0", Offset = "0x64121D0", VA = "0x1864139D0", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, float FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x6413A40", Offset = "0x6412240", VA = "0x186413A40", Slot = "7")]
	public float IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public DEHIGMNCGCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class BEGAJDFDPMM : GGKCAJABCKP<float?>, JFICJNJNNFJ, JLCOFNPFLDJ<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly BEGAJDFDPMM MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6411B60", Offset = "0x6410360", VA = "0x186411B60", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, float? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6411E00", Offset = "0x6410600", VA = "0x186411E00", Slot = "5")]
	public float? PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6411C20", Offset = "0x6410420", VA = "0x186411C20", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, float? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x6411CE0", Offset = "0x64104E0", VA = "0x186411CE0", Slot = "7")]
	public float? IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public BEGAJDFDPMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class LFBANMEEKAG : GGKCAJABCKP<float[]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly LFBANMEEKAG MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6420630", Offset = "0x641EE30", VA = "0x186420630", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, float[] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6420770", Offset = "0x641EF70", VA = "0x186420770", Slot = "5")]
	public float[] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public LFBANMEEKAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class AGKEGICJJPB : GGKCAJABCKP<double>, JFICJNJNNFJ, JLCOFNPFLDJ<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly AGKEGICJJPB MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x64115C0", Offset = "0x640FDC0", VA = "0x1864115C0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, double FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6411750", Offset = "0x640FF50", VA = "0x186411750", Slot = "5")]
	public double PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6411620", Offset = "0x640FE20", VA = "0x186411620", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, double FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6411690", Offset = "0x640FE90", VA = "0x186411690", Slot = "7")]
	public double IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public AGKEGICJJPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class DPFCDJNNMHH : GGKCAJABCKP<double?>, JFICJNJNNFJ, JLCOFNPFLDJ<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly DPFCDJNNMHH MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6415B00", Offset = "0x6414300", VA = "0x186415B00", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, double? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6415DC0", Offset = "0x64145C0", VA = "0x186415DC0", Slot = "5")]
	public double? PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6415BC0", Offset = "0x64143C0", VA = "0x186415BC0", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, double? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6415C80", Offset = "0x6414480", VA = "0x186415C80", Slot = "7")]
	public double? IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public DPFCDJNNMHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class NKJMDDMEHGL : GGKCAJABCKP<double[]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly NKJMDDMEHGL MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6422640", Offset = "0x6420E40", VA = "0x186422640", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, double[] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6422780", Offset = "0x6420F80", VA = "0x186422780", Slot = "5")]
	public double[] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public NKJMDDMEHGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class AFKKANFCCCA : GGKCAJABCKP<bool>, JFICJNJNNFJ, JLCOFNPFLDJ<bool>
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly AFKKANFCCCA MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6411360", Offset = "0x640FB60", VA = "0x186411360", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, bool FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x64114F0", Offset = "0x640FCF0", VA = "0x1864114F0", Slot = "5")]
	public bool PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x64113C0", Offset = "0x640FBC0", VA = "0x1864113C0", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, bool FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6411430", Offset = "0x640FC30", VA = "0x186411430", Slot = "7")]
	public bool IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public AFKKANFCCCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class FDLAABMPKLP : GGKCAJABCKP<bool?>, JFICJNJNNFJ, JLCOFNPFLDJ<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly FDLAABMPKLP MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6416E50", Offset = "0x6415650", VA = "0x186416E50", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, bool? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x64170F0", Offset = "0x64158F0", VA = "0x1864170F0", Slot = "5")]
	public bool? PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6416F10", Offset = "0x6415710", VA = "0x186416F10", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, bool? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6416FD0", Offset = "0x64157D0", VA = "0x186416FD0", Slot = "7")]
	public bool? IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public FDLAABMPKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class JBHFACNHOLD : GGKCAJABCKP<bool[]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly JBHFACNHOLD MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x641D170", Offset = "0x641B970", VA = "0x18641D170", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, bool[] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x641D2B0", Offset = "0x641BAB0", VA = "0x18641D2B0", Slot = "5")]
	public bool[] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JBHFACNHOLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class GLGOAHMEFIB : GGKCAJABCKP<object>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly GGKCAJABCKP<object> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly Dictionary<Type, int> AJENNIGOPDG;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6419DB0", Offset = "0x64185B0", VA = "0x186419DB0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, object FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x641AA50", Offset = "0x6419250", VA = "0x18641AA50", Slot = "5")]
	public object PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public GLGOAHMEFIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class ECNLCOBHCNI : GGKCAJABCKP<byte[]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly GGKCAJABCKP<byte[]> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x64162D0", Offset = "0x6414AD0", VA = "0x1864162D0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, byte[] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6416390", Offset = "0x6414B90", VA = "0x186416390", Slot = "5")]
	public byte[] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public ECNLCOBHCNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class HFFFOAGKBBP : GGKCAJABCKP<ArraySegment<byte>>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly GGKCAJABCKP<ArraySegment<byte>> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x6419E60", VA = "0x18641B660", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, ArraySegment<byte> FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x641B790", Offset = "0x6419F90", VA = "0x18641B790", Slot = "5")]
	public ArraySegment<byte> PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public HFFFOAGKBBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class IBLNFLPEPHB : GGKCAJABCKP<string>, JFICJNJNNFJ, JLCOFNPFLDJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly GGKCAJABCKP<string> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x641C690", Offset = "0x641AE90", VA = "0x18641C690", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, string FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x641C7A0", Offset = "0x641AFA0", VA = "0x18641C7A0", Slot = "5")]
	public string PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x641C6F0", Offset = "0x641AEF0", VA = "0x18641C6F0", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, string FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x641C750", Offset = "0x641AF50", VA = "0x18641C750", Slot = "7")]
	public string IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public IBLNFLPEPHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class NNLHKNLFDBL : GGKCAJABCKP<string[]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly NNLHKNLFDBL MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6422BF0", Offset = "0x64213F0", VA = "0x186422BF0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, string[] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6422D20", Offset = "0x6421520", VA = "0x186422D20", Slot = "5")]
	public string[] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public NNLHKNLFDBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class DJNFLDOAMAC : GGKCAJABCKP<char>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly DJNFLDOAMAC MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6413BD0", Offset = "0x64123D0", VA = "0x186413BD0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, char FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6413C90", Offset = "0x6412490", VA = "0x186413C90", Slot = "5")]
	public char PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public DJNFLDOAMAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class CLLOGJNEANL : GGKCAJABCKP<char?>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly CLLOGJNEANL MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6413260", Offset = "0x6411A60", VA = "0x186413260", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, char? FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x6413360", Offset = "0x6411B60", VA = "0x186413360", Slot = "5")]
	public char? PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public CLLOGJNEANL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class ENCKEOPEOKF : GGKCAJABCKP<char[]>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly ENCKEOPEOKF MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x6416720", Offset = "0x6414F20", VA = "0x186416720", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, char[] FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x64168D0", Offset = "0x64150D0", VA = "0x1864168D0", Slot = "5")]
	public char[] PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public ENCKEOPEOKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class HMLLKNCFJOK : GGKCAJABCKP<Guid>, JFICJNJNNFJ, JLCOFNPFLDJ<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly GGKCAJABCKP<Guid> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x641B920", Offset = "0x641A120", VA = "0x18641B920", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, Guid FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x641BC30", Offset = "0x641A430", VA = "0x18641BC30", Slot = "5")]
	public Guid PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x641BA50", Offset = "0x641A250", VA = "0x18641BA50", Slot = "6")]
	public void CNAOINLJDLC(LDODEOAPOMB MCLDKNNIMFL, Guid FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x641BB90", Offset = "0x641A390", VA = "0x18641BB90", Slot = "7")]
	public Guid IOAGJLKGKFA(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public HMLLKNCFJOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class LJHBKJGGHJE : GGKCAJABCKP<decimal>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly GGKCAJABCKP<decimal> MHFKJLABGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private readonly bool BBGIFIIMMBE;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x4F291D0", Offset = "0x4F279D0", VA = "0x184F291D0")]
	public LJHBKJGGHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x15E5340", Offset = "0x15E3B40", VA = "0x1815E5340")]
	public LJHBKJGGHJE(bool BBGIFIIMMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x6420980", Offset = "0x641F180", VA = "0x186420980", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, decimal FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6420B30", Offset = "0x641F330", VA = "0x186420B30", Slot = "5")]
	public decimal PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class OENEFBAAFBE : GGKCAJABCKP<Uri>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly GGKCAJABCKP<Uri> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x6423680", Offset = "0x6421E80", VA = "0x186423680", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, Uri FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x6423760", Offset = "0x6421F60", VA = "0x186423760", Slot = "5")]
	public Uri PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public OENEFBAAFBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class PFKPPJGHMHN : GGKCAJABCKP<Version>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly GGKCAJABCKP<Version> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x64241C0", Offset = "0x64229C0", VA = "0x1864241C0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, Version FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x6424280", Offset = "0x6422A80", VA = "0x186424280", Slot = "5")]
	public Version PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public PFKPPJGHMHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class HDFPLFHCCHA<TKey, TValue> : GGKCAJABCKP<KeyValuePair<TKey, TValue>>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x356B6E0", Offset = "0x3569EE0", VA = "0x18356B6E0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, KeyValuePair<TKey, TValue> FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x356B8D0", Offset = "0x356A0D0", VA = "0x18356B8D0", Slot = "5")]
	public KeyValuePair<TKey, TValue> PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class IPMMIDDPBJE : GGKCAJABCKP<StringBuilder>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly GGKCAJABCKP<StringBuilder> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x641CF90", Offset = "0x641B790", VA = "0x18641CF90", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, StringBuilder FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x641D030", Offset = "0x641B830", VA = "0x18641D030", Slot = "5")]
	public StringBuilder PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public IPMMIDDPBJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class IKHMOHBLDJJ : GGKCAJABCKP<BitArray>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly GGKCAJABCKP<BitArray> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x641CC70", Offset = "0x641B470", VA = "0x18641CC70", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, BitArray FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x641CD90", Offset = "0x641B590", VA = "0x18641CD90", Slot = "5")]
	public BitArray PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public IKHMOHBLDJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class HADEFBKOFLE : GGKCAJABCKP<Type>, JFICJNJNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly HADEFBKOFLE MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly Regex FLAMKODICCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private bool LGNMHEOBCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private bool ILPENKKJCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private bool EBOIFHOPBEI;

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x641B640", Offset = "0x6419E40", VA = "0x18641B640")]
	public HADEFBKOFLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x6419DF0", VA = "0x18641B5F0")]
	public HADEFBKOFLE(bool LGNMHEOBCJN, bool ILPENKKJCCE, bool EBOIFHOPBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x641B2A0", Offset = "0x6419AA0", VA = "0x18641B2A0", Slot = "4")]
	public void BBOAPHOFBBK(LDODEOAPOMB MCLDKNNIMFL, Type FKKGMPDEPMA, CBBFEPDHKGO LJJPKDDLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x641B3B0", Offset = "0x6419BB0", VA = "0x18641B3B0", Slot = "5")]
	public Type PFKIHJFLILM(ABJCIMHBCLJ OGNANCFBCDL, CBBFEPDHKGO LJJPKDDLCKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal static class PBKFIAENAGD
{
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal static readonly byte[][] DDOJJPBMIOB;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal static readonly EHECHPMAAOM KJOBKLBMGBN;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6423BE0", Offset = "0x64223E0", VA = "0x186423BE0")]
	static PBKFIAENAGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class DAJEPPIKLDO
{
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal static readonly byte[][] CCLEGHJBPPM;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal static readonly EHECHPMAAOM GNCMEMHCNBD;

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6413760", Offset = "0x6411F60", VA = "0x186413760")]
	static DAJEPPIKLDO()
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
