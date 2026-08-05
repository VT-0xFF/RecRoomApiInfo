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
public class PMFHABGLIHH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270")]
	public PMFHABGLIHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class HFBIIGOPFKO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270")]
	public HFBIIGOPFKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class FKDGNFAGKEG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270")]
	public FKDGNFAGKEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class MBBPBMLNAIG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270")]
	public MBBPBMLNAIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class BMAEFPLLOND
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x17154F0", Offset = "0x17146F0", VA = "0x1817154F0")]
	public static bool DHHGEMJKOLF(this TypeInfo BGMCKNGNOJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class NDHJNPGPLJB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type MCLIGNIOAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6EE480", Offset = "0x6ED680", VA = "0x1806EE480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] PABJACJAHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x85BEA0", Offset = "0x85B0A0", VA = "0x18085BEA0")]
	public NDHJNPGPLJB(Type DOBKCIFIACF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class BAKLMNCBJJF : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void LECIONILDOG<T>(ref CAFFCIDMPIE DJBGEDLHCFF, T ADBNEBBHMOP, DBIGINEDNCI JGJNDKCMFJI);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T GNNMCEJNHFM<T>(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI JGJNDKCMFJI);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BJAPNCFOIGD
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MODEKCAJGJD<T> : BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, T ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KONLGLPFDLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, T ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum OBBNCDCMLPA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::MODEKCAJGJD<T> HOBFBFEHINN<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PCLMPAJOGIN
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4290520", Offset = "0x428F720", VA = "0x184290520")]
	public static global::MODEKCAJGJD<T> DPOMFPCFCNG<T>(this DBIGINEDNCI JGJNDKCMFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x22F9340", Offset = "0x22F8540", VA = "0x1822F9340")]
	public static object GFJKKPPELCM(this DBIGINEDNCI JGJNDKCMFJI, Type BGMCKNGNOJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HLPDLADFILF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1726220", Offset = "0x1725420", VA = "0x181726220")]
	public HLPDLADFILF(string HGHEMBBLDIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MMPHHENFHIN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class CBELBCOFAMG
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] MNCACBMIHMI;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] DILONJGCEIC;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x22EEA90", Offset = "0x22EDC90", VA = "0x1822EEA90")]
		public static byte[] GMLKEIJMOOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x22EEB10", Offset = "0x22EDD10", VA = "0x1822EEB10")]
		public static char[] MPLPGAMHGKN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> BILBILLDMIG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] KMHODGHJHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] FAOJAOEJLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int FDGAPOLJFKN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool JCHFAAAHHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x22F3D80", Offset = "0x22F2F80", VA = "0x1822F3D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x22F4590", Offset = "0x22F3790", VA = "0x1822F4590")]
	public MMPHHENFHIN(byte[] FAOJAOEJLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x22F43B0", Offset = "0x22F35B0", VA = "0x1822F43B0")]
	public MMPHHENFHIN(byte[] FAOJAOEJLMO, int FDGAPOLJFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x22F2CD0", Offset = "0x22F1ED0", VA = "0x1822F2CD0")]
	private JELHDDMDANK HDGOOFHHMFP(string KIGCNHOGKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x22F3280", Offset = "0x22F2480", VA = "0x1822F3280")]
	private JELHDDMDANK IBFIACLLKIH(string HGHEMBBLDIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1716380", Offset = "0x1715580", VA = "0x181716380")]
	public void IIMKJGHGDBK(int FDGAPOLJFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x72F660", Offset = "0x72E860", VA = "0x18072F660")]
	public byte[] OGFCBJEHDNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x758560", Offset = "0x757760", VA = "0x180758560")]
	public int APDIEJEEHAL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x22F4020", Offset = "0x22F3220", VA = "0x1822F4020")]
	public OIMBKLKDLCE NNFHOGIMNNA()
	{
		return default(OIMBKLKDLCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x22F3600", Offset = "0x22F2800", VA = "0x1822F3600")]
	public void JCOEJIICDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x22F3E30", Offset = "0x22F3030", VA = "0x1822F3E30")]
	public bool NDJENOAOFCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x22F37C0", Offset = "0x22F29C0", VA = "0x1822F37C0")]
	public bool JLCLGOHIJNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x22F3AA0", Offset = "0x22F2CA0", VA = "0x1822F3AA0")]
	public void LDMDPIHPNMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x22F1D80", Offset = "0x22F0F80", VA = "0x1822F1D80")]
	public bool CBLLAHJAKFF(ref int AEKEPEKODMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x22F3360", Offset = "0x22F2560", VA = "0x1822F3360")]
	public bool IFAMGFFLDCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x22F1B90", Offset = "0x22F0D90", VA = "0x1822F1B90")]
	public void AFDDMHKJGGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x22F3DA0", Offset = "0x22F2FA0", VA = "0x1822F3DA0")]
	public bool MMPODKFDHPC(ref int AEKEPEKODMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x22F3D10", Offset = "0x22F2F10", VA = "0x1822F3D10")]
	public bool LPGHLOMLLOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x22F1970", Offset = "0x22F0B70", VA = "0x1822F1970")]
	public void ADCCMPMGHMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x22F3750", Offset = "0x22F2950", VA = "0x1822F3750")]
	public bool JLAKGBMGIEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x22F2C30", Offset = "0x22F1E30", VA = "0x1822F2C30")]
	public void GKBCDICKMOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x22F2300", Offset = "0x22F1500", VA = "0x1822F2300")]
	private void DPNBCPLHNKJ(out byte[] LGCNBLMPLOE, out int FAGKHFHHMMG, out int MEGPFGBFKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x22F31D0", Offset = "0x22F23D0", VA = "0x1822F31D0")]
	private static int HFDILNLCHIO(char PJIOBOBOEGF, char KLGGEDCBMPK, char FBCEFPPNKHI, char NMCOJHAIJEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x22F3C40", Offset = "0x22F2E40", VA = "0x1822F3C40")]
	private static int LPBNGOCPNHL(char FMHEJMEECNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x22F1C30", Offset = "0x22F0E30", VA = "0x1822F1C30")]
	public ArraySegment<byte> BJPKNBABEEI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x22F3830", Offset = "0x22F2A30", VA = "0x1822F3830")]
	public string JNJEJOPKBOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x22F2A90", Offset = "0x22F1C90", VA = "0x1822F2A90")]
	public string GECODKMLMGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x22F33D0", Offset = "0x22F25D0", VA = "0x1822F33D0")]
	public ArraySegment<byte> IFGMLIFEIPL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x22F3B40", Offset = "0x22F2D40", VA = "0x1822F3B40")]
	public ArraySegment<byte> LJENAPNLEEK()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x22F1E70", Offset = "0x22F1070", VA = "0x1822F1E70")]
	public bool DBDJDAFGHNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x22F39E0", Offset = "0x22F2BE0", VA = "0x1822F39E0")]
	private static bool KPLKNFHHEDC(byte FBCEFPPNKHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x22F20D0", Offset = "0x22F12D0", VA = "0x1822F20D0")]
	private void DJADOPLJBOE(OIMBKLKDLCE HCPCDENCJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x22F3740", Offset = "0x22F2940", VA = "0x1822F3740")]
	public void JHKHOKIKJCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x22F3F50", Offset = "0x22F3150", VA = "0x1822F3F50")]
	private void NEKFNLPAGHF(int APDOFJEJMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x22F3990", Offset = "0x22F2B90", VA = "0x1822F3990")]
	public sbyte KIPIGOEJHFB()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x22F1E10", Offset = "0x22F1010", VA = "0x1822F1E10")]
	public short COEJFNFNOJE()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x22F2AC0", Offset = "0x22F1CC0", VA = "0x1822F2AC0")]
	public int GFHKFKMKNJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x22F2B20", Offset = "0x22F1D20", VA = "0x1822F2B20")]
	public long GJCIOMPPJKH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x22F3170", Offset = "0x22F2370", VA = "0x1822F3170")]
	public byte HFAGJHPCEFL()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x22F1D20", Offset = "0x22F0F20", VA = "0x1822F1D20")]
	public ushort CAGKGABEANP()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x22F22A0", Offset = "0x22F14A0", VA = "0x1822F22A0")]
	public uint DKOOEMJALPB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x22F3580", Offset = "0x22F2780", VA = "0x1822F3580")]
	public ulong ILFOJNFABIN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x22F3B80", Offset = "0x22F2D80", VA = "0x1822F3B80")]
	public float LKABOBJBAOK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x22F38D0", Offset = "0x22F2AD0", VA = "0x1822F38D0")]
	public double KANGEKBKKAK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x22F41B0", Offset = "0x22F33B0", VA = "0x1822F41B0")]
	public ArraySegment<byte> PIOJODNIAHC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x22F1A10", Offset = "0x22F0C10", VA = "0x1822F1A10")]
	private static int AEGMMGJBIOI(byte[] FAOJAOEJLMO, int FDGAPOLJFKN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JELHDDMDANK : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference JMJPAAHHLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int CMJCFDDBKPA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int OHLOJJOAFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1328A70", Offset = "0x1327C70", VA = "0x181328A70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string IKFDLBDEJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0E0", Offset = "0x7DD2E0", VA = "0x1807DE0E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1328B50", Offset = "0x1327D50", VA = "0x181328B50")]
	public JELHDDMDANK(string HGHEMBBLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1328A80", Offset = "0x1327C80", VA = "0x181328A80")]
	public JELHDDMDANK(string HGHEMBBLDIC, byte[] OONPICAIDPI, int FDGAPOLJFKN, int CMJCFDDBKPA, string CGDJLBKHPHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JNPPMKLGNDO
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class BHOBANGLJHH
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void BLDPNFHMHML(ref CAFFCIDMPIE DJBGEDLHCFF, object ADBNEBBHMOP, DBIGINEDNCI JGJNDKCMFJI);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object PBILFMPPMIC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI JGJNDKCMFJI);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class IOLJGKHHHOA
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class KIEHPLOBAEB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
				public KIEHPLOBAEB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x1330DD0", Offset = "0x132FFD0", VA = "0x181330DD0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x1330E10", Offset = "0x1330010", VA = "0x181330E10")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, DBIGINEDNCI, byte[]> JPCFFLLHIOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, DBIGINEDNCI> OOCFCLJOEJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly BLDPNFHMHML KJDLJIKJOBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, DBIGINEDNCI, ArraySegment<byte>> DHCPHDAGCPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, DBIGINEDNCI, string> KBGLPFCMIDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, DBIGINEDNCI, object> LBGOIGJIALM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, DBIGINEDNCI, object> CMLBFFBJGBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, DBIGINEDNCI, object> PADLBEGDHPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly PBILFMPPMIC KGIIBNFHPFA;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1326900", Offset = "0x1325B00", VA = "0x181326900")]
			public IOLJGKHHHOA(Type BGMCKNGNOJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x533D610", Offset = "0x533C810", VA = "0x18533D610")]
			private static T HJOKIKMIMOI<T>(DynamicMethod JPPGJBIOABB)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1326710", Offset = "0x1325910", VA = "0x181326710")]
			private static MethodInfo FNNKEHEFAMB(Type BGMCKNGNOJI, string JFLKGPEABBP, Type[] IFCHMBEAJNO)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, IOLJGKHHHOA> PKNKNDOHBKK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::KGKOENKGELA<IOLJGKHHHOA> DIFHHCHDHAB;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x131A270", Offset = "0x1319470", VA = "0x18131A270")]
		static BHOBANGLJHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1319F70", Offset = "0x1319170", VA = "0x181319F70")]
		private static IOLJGKHHHOA FDAHGLBNFBD(Type BGMCKNGNOJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1319FF0", Offset = "0x13191F0", VA = "0x181319FF0")]
		public static void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, object ADBNEBBHMOP, DBIGINEDNCI JGJNDKCMFJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x131A160", Offset = "0x1319360", VA = "0x18131A160")]
		public static void LIOPAMDCNLD(Type BGMCKNGNOJI, ref CAFFCIDMPIE DJBGEDLHCFF, object ADBNEBBHMOP, DBIGINEDNCI JGJNDKCMFJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class BNKMGEHBJIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] MNCACBMIHMI;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x131A400", Offset = "0x1319600", VA = "0x18131A400")]
		public static byte[] GMLKEIJMOOF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static DBIGINEDNCI OGIDJKAEEJM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] JDKOIKPCELH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] NMAEBBMIIFB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static DBIGINEDNCI MNONPPODPID
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x132B410", Offset = "0x132A610", VA = "0x18132B410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x132B520", Offset = "0x132A720", VA = "0x18132B520")]
	public static void ODBBBNEHGJE(DBIGINEDNCI JGJNDKCMFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x38615A0", Offset = "0x38607A0", VA = "0x1838615A0")]
	public static string PNCHKNPNMIL<T>(T ADBNEBBHMOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3861440", Offset = "0x3860640", VA = "0x183861440")]
	public static string PNCHKNPNMIL<T>(T ADBNEBBHMOP, DBIGINEDNCI JGJNDKCMFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x535B8C0", Offset = "0x535AAC0", VA = "0x18535B8C0")]
	public static T LGPKACCHBHO<T>(string BIDAPELFIGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x535B7F0", Offset = "0x535A9F0", VA = "0x18535B7F0")]
	public static T LGPKACCHBHO<T>(string BIDAPELFIGO, DBIGINEDNCI JGJNDKCMFJI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x535BA90", Offset = "0x535AC90", VA = "0x18535BA90")]
	public static T LGPKACCHBHO<T>(byte[] FAOJAOEJLMO, DBIGINEDNCI JGJNDKCMFJI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x535B940", Offset = "0x535AB40", VA = "0x18535B940")]
	public static T LGPKACCHBHO<T>(byte[] FAOJAOEJLMO, int FDGAPOLJFKN, DBIGINEDNCI JGJNDKCMFJI)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum OIMBKLKDLCE : byte
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
public struct CAFFCIDMPIE
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] OGBICEHHJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] MNCACBMIHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int FDGAPOLJFKN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int BBBHDGKJOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x758560", Offset = "0x757760", VA = "0x180758560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1716380", Offset = "0x1715580", VA = "0x181716380")]
	public void IIMKJGHGDBK(int FDGAPOLJFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1716600", Offset = "0x1715800", VA = "0x181716600")]
	public static byte[] LIGAAPFNAFC(string FFIIDDPMMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x17157C0", Offset = "0x17149C0", VA = "0x1817157C0")]
	public static byte[] CCLIJJCCDKL(string FFIIDDPMMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1716710", Offset = "0x1715910", VA = "0x181716710")]
	public static byte[] MPNDJLEJELA(string FFIIDDPMMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1715FF0", Offset = "0x17151F0", VA = "0x181715FF0")]
	public static byte[] FFLKHPDOFPJ(string FFIIDDPMMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1716B40", Offset = "0x1715D40", VA = "0x181716B40")]
	public CAFFCIDMPIE(byte[] HKOOCLOOOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x17161B0", Offset = "0x17153B0", VA = "0x1817161B0")]
	public ArraySegment<byte> GMLKEIJMOOF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x17158F0", Offset = "0x1714AF0", VA = "0x1817158F0")]
	public byte[] DEPMIDADIIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1716A90", Offset = "0x1715C90", VA = "0x181716A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x17161A0", Offset = "0x17153A0", VA = "0x1817161A0")]
	public void GFBBAIKPDNM(int NGECBDNOKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1715890", Offset = "0x1714A90", VA = "0x181715890")]
	public void COHFMMOOMHF(byte[] DDPAMMFHNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1716680", Offset = "0x1715880", VA = "0x181716680")]
	public void LOGEJDFGOGG(byte DDPAMMFHNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1715770", Offset = "0x1714970", VA = "0x181715770")]
	public void BJKFGAGACML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x17166C0", Offset = "0x17158C0", VA = "0x1817166C0")]
	public void MPECKNOHCDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1715720", Offset = "0x1714920", VA = "0x181715720")]
	public void ADDMDGAPDPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1716580", Offset = "0x1715780", VA = "0x181716580")]
	public void KINCOABBADB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1715A40", Offset = "0x1714C40", VA = "0x181715A40")]
	public void DONDCPPIFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1715350", VA = "0x181716150")]
	public void FNMJEHBKADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1716960", Offset = "0x1715B60", VA = "0x181716960")]
	public void PEJKAGOLCJI(string FFIIDDPMMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1715A90", Offset = "0x1714C90", VA = "0x181715A90")]
	public void DPHJGBMAEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x17169C0", Offset = "0x1715BC0", VA = "0x1817169C0")]
	public void PFJCAAECLAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1716390", Offset = "0x1715590", VA = "0x181716390")]
	public void JKNDEMBMOBL(bool ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1716810", Offset = "0x1715A10", VA = "0x181716810")]
	public void OOAJILKEGFK(float ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1715EB0", Offset = "0x17150B0", VA = "0x181715EB0")]
	public void FEDKEJJLPHE(double ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x17167E0", Offset = "0x17159E0", VA = "0x1817167E0")]
	public void NABBPLBBAKN(byte ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1716320", Offset = "0x1715520", VA = "0x181716320")]
	public void HOJHPGHHCMO(ushort ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x17162F0", Offset = "0x17154F0", VA = "0x1817162F0")]
	public void HLNJFECOOFL(uint ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x17162C0", Offset = "0x17154C0", VA = "0x1817162C0")]
	public void HJALOCMJDPN(ulong ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x17165D0", Offset = "0x17157D0", VA = "0x1817165D0")]
	public void KMMNMPHOPII(sbyte ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1716350", Offset = "0x1715550", VA = "0x181716350")]
	public void ICBCEGBPFGE(short ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1716260", Offset = "0x1715460", VA = "0x181716260")]
	public void HBADHAHDKID(int ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1716290", Offset = "0x1715490", VA = "0x181716290")]
	public void HBOJOJPCILM(long ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1715AE0", Offset = "0x1714CE0", VA = "0x181715AE0")]
	public void EJLCCAGIFII(string ADBNEBBHMOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KOHBCBKNAIE : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class MNPOEADPPHK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1738720", Offset = "0x1737920", VA = "0x181738720")]
		static MNPOEADPPHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private KOHBCBKNAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class HADDAAJELIA
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> GOKAFALOBIH;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1721790", Offset = "0x1720990", VA = "0x181721790")]
	static HADDAAJELIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1721230", Offset = "0x1720430", VA = "0x181721230")]
	internal static object HOBFBFEHINN(Type FOLCGJFJJMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class INILFLKKKOP : global::MODEKCAJGJD<Vector2>, BJAPNCFOIGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NEGOGAKEDDA GPFJBEINGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] GGFCIGPDLLF;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1326540", Offset = "0x1325740", VA = "0x181326540")]
	public INILFLKKKOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1326490", Offset = "0x1325690", VA = "0x181326490", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, Vector2 ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1326310", Offset = "0x1325510", VA = "0x181326310", Slot = "5")]
	public Vector2 LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class OHFLAGIOALO : global::MODEKCAJGJD<Vector3>, BJAPNCFOIGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NEGOGAKEDDA GPFJBEINGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] GGFCIGPDLLF;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x22F6D40", Offset = "0x22F5F40", VA = "0x1822F6D40")]
	public OHFLAGIOALO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x22F6C20", Offset = "0x22F5E20", VA = "0x1822F6C20", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, Vector3 ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x22F68D0", Offset = "0x22F5AD0", VA = "0x1822F68D0", Slot = "5")]
	public Vector3 LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class AHOFIJHDAFN : global::MODEKCAJGJD<Vector4>, BJAPNCFOIGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly NEGOGAKEDDA GPFJBEINGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] GGFCIGPDLLF;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1711640", Offset = "0x1710840", VA = "0x181711640")]
	public AHOFIJHDAFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x17113D0", Offset = "0x17105D0", VA = "0x1817113D0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, Vector4 ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x17111A0", Offset = "0x17103A0", VA = "0x1817111A0", Slot = "5")]
	public Vector4 LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class KFMDICLBBAO : global::MODEKCAJGJD<Quaternion>, BJAPNCFOIGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly NEGOGAKEDDA GPFJBEINGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] GGFCIGPDLLF;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1330A30", Offset = "0x132FC30", VA = "0x181330A30")]
	public KFMDICLBBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x13308E0", Offset = "0x132FAE0", VA = "0x1813308E0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, Quaternion ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x13306B0", Offset = "0x132F8B0", VA = "0x1813306B0", Slot = "5")]
	public Quaternion LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class MEMLDIILJKF : global::MODEKCAJGJD<Color>, BJAPNCFOIGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly NEGOGAKEDDA GPFJBEINGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] GGFCIGPDLLF;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x22F0BC0", Offset = "0x22EFDC0", VA = "0x1822F0BC0")]
	public MEMLDIILJKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x13308E0", Offset = "0x132FAE0", VA = "0x1813308E0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, Color ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x22F0840", Offset = "0x22EFA40", VA = "0x1822F0840", Slot = "5")]
	public Color LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class ICHHKCECBKF : global::MODEKCAJGJD<Bounds>, BJAPNCFOIGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly NEGOGAKEDDA GPFJBEINGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] GGFCIGPDLLF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1726E10", Offset = "0x1726010", VA = "0x181726E10")]
	public ICHHKCECBKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1726B10", Offset = "0x1725D10", VA = "0x181726B10", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, Bounds ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1726870", Offset = "0x1725A70", VA = "0x181726870", Slot = "5")]
	public Bounds LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class EMJFOLJBJJA : global::MODEKCAJGJD<Rect>, BJAPNCFOIGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly NEGOGAKEDDA GPFJBEINGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] GGFCIGPDLLF;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x171C3A0", Offset = "0x171B5A0", VA = "0x18171C3A0")]
	public EMJFOLJBJJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x171C110", Offset = "0x171B310", VA = "0x18171C110", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, Rect ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x171BEB0", Offset = "0x171B0B0", VA = "0x18171BEB0", Slot = "5")]
	public Rect LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class PIGMACBMEJA : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class LEGIGJCMCIP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x45FE390", Offset = "0x45FD590", VA = "0x1845FE390")]
		static LEGIGJCMCIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private PIGMACBMEJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class IFCFJJCKDHE : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class IIFHEMHOMEL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4119B40", Offset = "0x4118D40", VA = "0x184119B40")]
		static IIFHEMHOMEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class CHBNDHJDHGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> JOEGEFLAIMF;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x131A480", Offset = "0x1319680", VA = "0x18131A480")]
		internal static object HOBFBFEHINN(Type FOLCGJFJJMP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private IFCFJJCKDHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class ELFNEKLFGBE : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class NLLIGKIIANL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4E5C120", Offset = "0x4E5B320", VA = "0x184E5C120")]
		static NLLIGKIIANL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly ELFNEKLFGBE HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool CJNGAGMJOJC;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static BJAPNCFOIGD[] NIGLFJFLCDI;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static DBIGINEDNCI[] PIKLAANHPBK;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private ELFNEKLFGBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x171BC70", Offset = "0x171AE70", VA = "0x18171BC70")]
	public static void NKCPCCNOLCN(params DBIGINEDNCI[] PIKLAANHPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x171BD30", Offset = "0x171AF30", VA = "0x18171BD30")]
	public static void NKCPCCNOLCN(params BJAPNCFOIGD[] NIGLFJFLCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x171BA20", Offset = "0x171AC20", VA = "0x18171BA20")]
	public static void NHGJLENIGPP(BJAPNCFOIGD[] NIGLFJFLCDI, DBIGINEDNCI[] PIKLAANHPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class EAIAJBOFPAB : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class GOLLDGHHEDF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x457ED40", Offset = "0x457DF40", VA = "0x18457ED40")]
		static GOLLDGHHEDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private EAIAJBOFPAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HEFLJJEMBCG
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly DBIGINEDNCI HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly DBIGINEDNCI FMGOMEEFOAP;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly DBIGINEDNCI HNLLLNEONIJ;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly DBIGINEDNCI BMCMPGPDCOE;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly DBIGINEDNCI ANPMDHCNBDE;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly DBIGINEDNCI EIIFCKAOGJH;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly DBIGINEDNCI FBPIOECFHKE;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly DBIGINEDNCI JBDJKPELHMM;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly DBIGINEDNCI HLGKCGLJNNG;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly DBIGINEDNCI HJGENJALJBN;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly DBIGINEDNCI GDOAMGHDMNF;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly DBIGINEDNCI IDEIIMFPPJK;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class CAFAFEKHANE
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly DBIGINEDNCI HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly DBIGINEDNCI HKBMCEIHLGB;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NMDBKLNNLDG
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly DBIGINEDNCI HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly DBIGINEDNCI FMGOMEEFOAP;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly DBIGINEDNCI HNLLLNEONIJ;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly DBIGINEDNCI BMCMPGPDCOE;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly DBIGINEDNCI ANPMDHCNBDE;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly DBIGINEDNCI EIIFCKAOGJH;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly DBIGINEDNCI FBPIOECFHKE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly DBIGINEDNCI JBDJKPELHMM;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly DBIGINEDNCI HLGKCGLJNNG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly DBIGINEDNCI HJGENJALJBN;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly DBIGINEDNCI GDOAMGHDMNF;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly DBIGINEDNCI IDEIIMFPPJK;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class DCNEFFECJNE
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> JOEGEFLAIMF;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x17179B0", Offset = "0x1716BB0", VA = "0x1817179B0")]
	internal static object HOBFBFEHINN(Type FOLCGJFJJMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1718FD0", Offset = "0x17181D0", VA = "0x181718FD0")]
	private static object KIBJLLKGMPM(Type AJDHJNGNMKB, Type[] ONMEHPHMKMO, params object[] IFCHMBEAJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class IEKEHPOOGOC : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class NCCKAMFCBCK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x411F160", Offset = "0x411E360", VA = "0x18411F160")]
		static NCCKAMFCBCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> CHPCOJJNJEE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool OJLICHADKNO;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly JCCOMAGIAEB MFOEEOCHFPF;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x131CBF0", Offset = "0x131BDF0", VA = "0x18131CBF0")]
	static IEKEHPOOGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private IEKEHPOOGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class NCCDJOFNHNG : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class DMEHNNAMMGK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xF2BBD0", Offset = "0xF2ADD0", VA = "0x180F2BBD0")]
		static DMEHNNAMMGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> CHPCOJJNJEE;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool OJLICHADKNO;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly JCCOMAGIAEB MFOEEOCHFPF;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x22F4AF0", Offset = "0x22F3CF0", VA = "0x1822F4AF0")]
	static NCCDJOFNHNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private NCCDJOFNHNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class KMLHPJALCIA : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class ACOKKNOOJBN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1204E40", Offset = "0x1204040", VA = "0x181204E40")]
		static ACOKKNOOJBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> CHPCOJJNJEE;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool OJLICHADKNO;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly JCCOMAGIAEB MFOEEOCHFPF;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x13317A0", Offset = "0x13309A0", VA = "0x1813317A0")]
	static KMLHPJALCIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private KMLHPJALCIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class EFBLFBLNHLG : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class PDMMLFKHGLD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x466CDB0", Offset = "0x466BFB0", VA = "0x18466CDB0")]
		static PDMMLFKHGLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> CHPCOJJNJEE;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool OJLICHADKNO;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly JCCOMAGIAEB MFOEEOCHFPF;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x171B4B0", Offset = "0x171A6B0", VA = "0x18171B4B0")]
	static EFBLFBLNHLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private EFBLFBLNHLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class NBOEKNGFHKP : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class MAOFEPGGABG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xF31980", Offset = "0xF30B80", VA = "0x180F31980")]
		static MAOFEPGGABG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> CHPCOJJNJEE;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool OJLICHADKNO;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly JCCOMAGIAEB MFOEEOCHFPF;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x22F4A00", Offset = "0x22F3C00", VA = "0x1822F4A00")]
	static NBOEKNGFHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private NBOEKNGFHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class LLJKFNBNOCB : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class IKCBJIAHBNM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1CB4CE0", Offset = "0x1CB3EE0", VA = "0x181CB4CE0")]
		static IKCBJIAHBNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> CHPCOJJNJEE;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool OJLICHADKNO;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly JCCOMAGIAEB MFOEEOCHFPF;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x22F0050", Offset = "0x22EF250", VA = "0x1822F0050")]
	static LLJKFNBNOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private LLJKFNBNOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class IEJGCHCLDDF : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class GKOMGGNLEBB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x410E830", Offset = "0x410DA30", VA = "0x18410E830")]
		static GKOMGGNLEBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> CHPCOJJNJEE;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool OJLICHADKNO;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public IEJGCHCLDDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class PGIFBJCFADN : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class FBIGMJJCDJG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x45FCAF0", Offset = "0x45FBCF0", VA = "0x1845FCAF0")]
		static FBIGMJJCDJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> CHPCOJJNJEE;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool OJLICHADKNO;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public PGIFBJCFADN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class GNGHBNBCDOB : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class NDJBINGNFGI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x44F6DC0", Offset = "0x44F5FC0", VA = "0x1844F6DC0")]
		static NDJBINGNFGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> CHPCOJJNJEE;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool OJLICHADKNO;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public GNGHBNBCDOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class CMBEFBINHEE : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class LIIKJHAHPEL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4361230", Offset = "0x4360430", VA = "0x184361230")]
		static LIIKJHAHPEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> CHPCOJJNJEE;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool OJLICHADKNO;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public CMBEFBINHEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class KIDFKNEPOKJ : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class FCFMPCIEOJF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x133B150", Offset = "0x133A350", VA = "0x18133B150")]
		static FCFMPCIEOJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> CHPCOJJNJEE;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool OJLICHADKNO;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public KIDFKNEPOKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class FFFKHBNENOG : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class LGPCMCIKGJH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4793E50", Offset = "0x4793050", VA = "0x184793E50")]
		static LGPCMCIKGJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> CHPCOJJNJEE;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool OJLICHADKNO;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public FFFKHBNENOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class IKBCNJPGNON
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct OMIEHEPHOJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public BJBFHCBDJAA NFAODMMKHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder OMNMHDPCKFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder MKHINJCMHMN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class JLHJILAICBK
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class AAOCMDMHOKD
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo MPNDJLEJELA;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo CCLIJJCCDKL;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo FFLKHPDOFPJ;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo LIGAAPFNAFC;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo PFJCAAECLAE;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo COHFMMOOMHF;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo ADDMDGAPDPJ;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo KINCOABBADB;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo DONDCPPIFML;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x13190B0", Offset = "0x13182B0", VA = "0x1813190B0")]
			static AAOCMDMHOKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class COHPBPMJMHI
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo NDJENOAOFCO;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo AFDDMHKJGGJ;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo MMPODKFDHPC;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo DJNNNJJDPBC;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo JHKHOKIKJCP;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo OGFCBJEHDNF;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo APDIEJEEHAL;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x131BC40", Offset = "0x131AE40", VA = "0x18131BC40")]
			static COHPBPMJMHI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class LIIDOAAAKPM
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo MCLIGNIOAOH;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo PABJACJAHIH;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo CDFFEHBCNAD;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo DPOMFPCFCNG;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo KOKAOHGHGPI;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo HCCKFCBMGPC;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo GDMKDAIODEO;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo OBKPKCENFKP;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo GOILMHHMGDL;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo EHJHFKJKPCO;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo NBFMENPKMLO;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo LKKKKGOGILG;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo PJJJHNLOBCM;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo GBIIAEFEFCE;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1329870", Offset = "0x1328A70", VA = "0x181329870")]
		public static MethodInfo LIOPAMDCNLD(Type BGMCKNGNOJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1329640", Offset = "0x1328840", VA = "0x181329640")]
		public static MethodInfo LGPKACCHBHO(Type BGMCKNGNOJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1329B00", Offset = "0x1328D00", VA = "0x181329B00")]
		public static MethodInfo MBBGJKDFNDE(Type BGMCKNGNOJI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class IEPELOODNFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<BJBFHCBDJAA, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public IEPELOODNFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class FHAEOGNKNPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public IEPELOODNFG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public FHAEOGNKNPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x131C7E0", Offset = "0x131B9E0", VA = "0x18131C7E0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x131C820", Offset = "0x131BA20", VA = "0x18131C820")]
		internal bool <BuildType>b__2(int index, BJBFHCBDJAA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class DCIBFAILOLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public IEPELOODNFG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public DCIBFAILOLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x131C740", Offset = "0x131B940", VA = "0x18131C740")]
		internal bool <BuildType>b__3(int index, BJBFHCBDJAA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class IOLMMPCEBED
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
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public IOLMMPCEBED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1328820", Offset = "0x1327A20", VA = "0x181328820")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IEAKLCFLFKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public IEAKLCFLFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x131CAE0", Offset = "0x131BCE0", VA = "0x18131CAE0")]
		internal bool <BuildAnonymousFormatter>b__2(BJBFHCBDJAA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class OAKCLMJJLAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public IOLMMPCEBED CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public OAKCLMJJLAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1333EE0", Offset = "0x13330E0", VA = "0x181333EE0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1333F60", Offset = "0x1333160", VA = "0x181333F60")]
		internal bool <BuildAnonymousFormatter>b__6(int index, BJBFHCBDJAA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GJIOBJJBFKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public IOLMMPCEBED CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public GJIOBJJBFKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x131C8C0", Offset = "0x131BAC0", VA = "0x18131C8C0")]
		internal bool <BuildAnonymousFormatter>b__7(int index, BJBFHCBDJAA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class JBDCCMNHAHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public JBDCCMNHAHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1C80", Offset = "0x7F0E80", VA = "0x1807F1C80")]
		internal Label <BuildSerialize>b__1(BJBFHCBDJAA _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class JKNGAKOKHGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public OMIEHEPHOJG[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, BJBFHCBDJAA, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public MGDDBIHIEIC argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public MGDDBIHIEIC argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public JKNGAKOKHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x13291C0", Offset = "0x13283C0", VA = "0x1813291C0")]
		internal OMIEHEPHOJG <BuildDeserialize>b__0(BJBFHCBDJAA item)
		{
			return default(OMIEHEPHOJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class MHHFCCEEDOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public JKNGAKOKHGG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public MHHFCCEEDOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1333B60", Offset = "0x1332D60", VA = "0x181333B60")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x1333E40", Offset = "0x1333040", VA = "0x181333E40")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class HDKDPFAIKOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public BJBFHCBDJAA item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public HDKDPFAIKOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x131CAC0", Offset = "0x131BCC0", VA = "0x18131CAC0")]
		internal bool <EmitNewObject>b__0(OMIEHEPHOJG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class JCPOJDOJCNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public BJBFHCBDJAA item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public JCPOJDOJCNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x131CAC0", Offset = "0x131BCC0", VA = "0x18131CAC0")]
		internal bool <EmitNewObject>b__2(OMIEHEPHOJG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex IGOPHIHKGOP;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int LIOCNIJFHMO;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> OGJODOLBNBG;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> CIKAGKABMCB;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x44508E0", Offset = "0x444FAE0", VA = "0x1844508E0")]
	public static object IPOFAAHFDLL<T>(JCCOMAGIAEB MFOEEOCHFPF, DBIGINEDNCI OHLMLBCBHJO, Func<string, string> CHPCOJJNJEE, bool OJLICHADKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x445A970", Offset = "0x4459B70", VA = "0x18445A970")]
	public static object NMIMEHNDNNI<T>(DBIGINEDNCI OHLMLBCBHJO, Func<string, string> CHPCOJJNJEE, bool OJLICHADKNO, bool MDOOJPFHHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x13213A0", Offset = "0x13205A0", VA = "0x1813213A0")]
	private static TypeInfo EEEJDPCLPHF(JCCOMAGIAEB MFOEEOCHFPF, Type BGMCKNGNOJI, Func<string, string> CHPCOJJNJEE, bool OJLICHADKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x131D5D0", Offset = "0x131C7D0", VA = "0x18131D5D0")]
	public static object AFGLFHAJKPK(Type BGMCKNGNOJI, Func<string, string> CHPCOJJNJEE, bool OJLICHADKNO, bool MDOOJPFHHGE, bool OHGGBPACJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1322A90", Offset = "0x1321C90", VA = "0x181322A90")]
	private static Dictionary<BJBFHCBDJAA, FieldInfo> GCFPOOHJNJI(TypeBuilder KNHDDCDCADO, DPBDEJIKHIN LFBIOJBBNIJ, ConstructorInfo OJCKDJPHKIP, FieldBuilder NNNPDAELOBB, ILGenerator IMHPIBJCNHE, bool OJLICHADKNO, bool ILOKDJECOMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1323190", Offset = "0x1322390", VA = "0x181323190")]
	private static Dictionary<BJBFHCBDJAA, FieldInfo> KMKDGGJLFEM(TypeBuilder KNHDDCDCADO, DPBDEJIKHIN LFBIOJBBNIJ, ILGenerator IMHPIBJCNHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x131FDF0", Offset = "0x131EFF0", VA = "0x18131FDF0")]
	private static void CIFMNPMFPDK(Type BGMCKNGNOJI, DPBDEJIKHIN LFBIOJBBNIJ, ILGenerator IMHPIBJCNHE, Action GLKGLBIFBMC, Func<int, BJBFHCBDJAA, bool> BNAKPLFLLKE, bool OJLICHADKNO, bool ILOKDJECOMG, int IBLAJADBNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1323760", Offset = "0x1322960", VA = "0x181323760")]
	private static void MDMLFHDEOHM(TypeInfo BGMCKNGNOJI, BJBFHCBDJAA OOKMPDNEMCB, ILGenerator IMHPIBJCNHE, int MJNAIOAAGCG, Func<int, BJBFHCBDJAA, bool> BNAKPLFLLKE, MGDDBIHIEIC DJBGEDLHCFF, MGDDBIHIEIC INPOGHBPANF, MGDDBIHIEIC NPHNMKOLMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1323D10", Offset = "0x1322F10", VA = "0x181323D10")]
	private static void PFJFNKMHCLH(Type BGMCKNGNOJI, DPBDEJIKHIN LFBIOJBBNIJ, ILGenerator IMHPIBJCNHE, Func<int, BJBFHCBDJAA, bool> BNAKPLFLLKE, bool CGPBNFABEGO, int IBLAJADBNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1322670", Offset = "0x1321870", VA = "0x181322670")]
	private static void FNNDCIMGOOG(ILGenerator IMHPIBJCNHE, OMIEHEPHOJG LFBIOJBBNIJ, int MJNAIOAAGCG, Func<int, BJBFHCBDJAA, bool> BNAKPLFLLKE, MGDDBIHIEIC NCACJOJKKJP, MGDDBIHIEIC NPHNMKOLMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x131EF70", Offset = "0x131E170", VA = "0x18131EF70")]
	private static LocalBuilder ALELMJDJJAG(ILGenerator IMHPIBJCNHE, Type BGMCKNGNOJI, DPBDEJIKHIN LFBIOJBBNIJ, OMIEHEPHOJG[] HBKMADHPJKO, bool LJMLAAAIIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1321E40", Offset = "0x1321040", VA = "0x181321E40")]
	private static bool ELFLNKEBJFB(ConstructorInfo FGIKGEHEBCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x131FC50", Offset = "0x131EE50", VA = "0x18131FC50")]
	private static bool CGPGJHLJJCP(Type BGMCKNGNOJI, out Type FLJFOHPBCEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void HCCIIOIIBEB<T>(byte[][] NNNPDAELOBB, object[] ENDPBDJKBPM, ref CAFFCIDMPIE DJBGEDLHCFF, T ADBNEBBHMOP, DBIGINEDNCI JGJNDKCMFJI);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T DNLGHIEDCFE<T>(object[] ENDPBDJKBPM, ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI JGJNDKCMFJI);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class PMGCEAKAGGB<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class FPOLAANMHPI : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class JNPJIDBIKHD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4860A20", Offset = "0x485FC20", VA = "0x184860A20")]
		static JNPJIDBIKHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private FPOLAANMHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class MKDJEADAANP : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class AECFKPGBLIO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1C747F0", Offset = "0x1C739F0", VA = "0x181C747F0")]
		static AECFKPGBLIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private MKDJEADAANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class CMBKKPHACDG
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly DBIGINEDNCI[] CLFHDNMNNJB;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class GMDFKCMPFHL : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class MBFIFPGNCIK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x44F4B00", Offset = "0x44F3D00", VA = "0x1844F4B00")]
		static MBFIFPGNCIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class NMHNJPNBMAG : DBIGINEDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class IGMOFCPDOJO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x44EA5F0", Offset = "0x44E97F0", VA = "0x1844EA5F0")]
			static IGMOFCPDOJO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly DBIGINEDNCI HBKBBJLFPOI;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly DBIGINEDNCI[] PIKLAANHPBK;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		private NMHNJPNBMAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
		public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::MODEKCAJGJD<object> DFKODKPAJGM;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private GMDFKCMPFHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class DCKFGIDHFOF : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class CHNJMMKHNIB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x46C5650", Offset = "0x46C4850", VA = "0x1846C5650")]
		static CHNJMMKHNIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class ANAGEELJODD : DBIGINEDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class HHMEPKPKGLG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x46D1650", Offset = "0x46D0850", VA = "0x1846D1650")]
			static HHMEPKPKGLG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly DBIGINEDNCI HBKBBJLFPOI;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly DBIGINEDNCI[] PIKLAANHPBK;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		private ANAGEELJODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
		public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::MODEKCAJGJD<object> DFKODKPAJGM;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private DCKFGIDHFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class GELPPJOMMOI : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class IPFOPGNIFKK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x45E77D0", Offset = "0x45E69D0", VA = "0x1845E77D0")]
		static IPFOPGNIFKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class IFHIOJCLAMK : DBIGINEDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class PDGOKFDAALL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x45F8470", Offset = "0x45F7670", VA = "0x1845F8470")]
			static PDGOKFDAALL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly DBIGINEDNCI HBKBBJLFPOI;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly DBIGINEDNCI[] PIKLAANHPBK;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		private IFHIOJCLAMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
		public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::MODEKCAJGJD<object> DFKODKPAJGM;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private GELPPJOMMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class BIFLAKAIJLH : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class HKLGEPNAIHJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x423D880", Offset = "0x423CA80", VA = "0x18423D880")]
		static HKLGEPNAIHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class JKOJDBPHCLI : DBIGINEDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class IGEIGMJEKBP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x4240D40", Offset = "0x423FF40", VA = "0x184240D40")]
			static IGEIGMJEKBP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly DBIGINEDNCI HBKBBJLFPOI;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly DBIGINEDNCI[] PIKLAANHPBK;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		private JKOJDBPHCLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
		public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::MODEKCAJGJD<object> DFKODKPAJGM;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private BIFLAKAIJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class MACCJILKFDL : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class KEHHNIFJPPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1CB60B0", Offset = "0x1CB52B0", VA = "0x181CB60B0")]
		static KEHHNIFJPPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class IOHPEHDDGHC : DBIGINEDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class POMPADAKJPI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x1CCD4F0", Offset = "0x1CCC6F0", VA = "0x181CCD4F0")]
			static POMPADAKJPI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly DBIGINEDNCI HBKBBJLFPOI;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly DBIGINEDNCI[] PIKLAANHPBK;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		private IOHPEHDDGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
		public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::MODEKCAJGJD<object> DFKODKPAJGM;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private MACCJILKFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class MBDJENAPJLJ : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class CLFOKOHFKBN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x43E51E0", Offset = "0x43E43E0", VA = "0x1843E51E0")]
		static CLFOKOHFKBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class BNBHMIGOCMD : DBIGINEDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class OHIMFMJPDOB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x43F9620", Offset = "0x43F8820", VA = "0x1843F9620")]
			static OHIMFMJPDOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly DBIGINEDNCI HBKBBJLFPOI;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly DBIGINEDNCI[] PIKLAANHPBK;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		private BNBHMIGOCMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
		public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::MODEKCAJGJD<object> DFKODKPAJGM;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private MBDJENAPJLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class GIGBMBILFOI : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class MBAAAFEHEDA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x44ED070", Offset = "0x44EC270", VA = "0x1844ED070")]
		static MBAAAFEHEDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class FBPEAOEJGCH : DBIGINEDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class BGOJDNMHKFL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x45E2950", Offset = "0x45E1B50", VA = "0x1845E2950")]
			static BGOJDNMHKFL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly DBIGINEDNCI HBKBBJLFPOI;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly DBIGINEDNCI[] PIKLAANHPBK;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		private FBPEAOEJGCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
		public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::MODEKCAJGJD<object> DFKODKPAJGM;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private GIGBMBILFOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class EJNBNPBCHHE : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class KCMAPHGGCGK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4E4F670", Offset = "0x4E4E870", VA = "0x184E4F670")]
		static KCMAPHGGCGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class GGMJHEAMGPK : DBIGINEDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class KCLEOKJKMIP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x4E4A1C0", Offset = "0x4E493C0", VA = "0x184E4A1C0")]
			static KCLEOKJKMIP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly DBIGINEDNCI HBKBBJLFPOI;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly DBIGINEDNCI[] PIKLAANHPBK;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		private GGMJHEAMGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
		public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::MODEKCAJGJD<object> DFKODKPAJGM;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private EJNBNPBCHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class JNIAFBACGDF : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class NBKFDAMCMIF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2199890", Offset = "0x2198A90", VA = "0x182199890")]
		static NBKFDAMCMIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class AHNDEDAFLCB : DBIGINEDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class AEMBCNHMEDC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1F6C700", Offset = "0x1F6B900", VA = "0x181F6C700")]
			static AEMBCNHMEDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly DBIGINEDNCI HBKBBJLFPOI;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly DBIGINEDNCI[] PIKLAANHPBK;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		private AHNDEDAFLCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
		public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::MODEKCAJGJD<object> DFKODKPAJGM;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private JNIAFBACGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class AFHFMJGLDEM : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class KCPAMNGNGIH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x37F2620", Offset = "0x37F1820", VA = "0x1837F2620")]
		static KCPAMNGNGIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class JOOIPLJMLKI : DBIGINEDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class FHMHHKNMCEI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x37EE3E0", Offset = "0x37ED5E0", VA = "0x1837EE3E0")]
			static FHMHHKNMCEI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly DBIGINEDNCI HBKBBJLFPOI;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly DBIGINEDNCI[] PIKLAANHPBK;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		private JOOIPLJMLKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
		public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::MODEKCAJGJD<object> DFKODKPAJGM;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private AFHFMJGLDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class HNDBKAHCONP : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class GGLNCGEKCLO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x39ED2F0", Offset = "0x39EC4F0", VA = "0x1839ED2F0")]
		static GGLNCGEKCLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class NIDNKCGIJPP : DBIGINEDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class AJFAHHONPBG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x39E7EC0", Offset = "0x39E70C0", VA = "0x1839E7EC0")]
			static AJFAHHONPBG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly DBIGINEDNCI HBKBBJLFPOI;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly DBIGINEDNCI[] PIKLAANHPBK;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		private NIDNKCGIJPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
		public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::MODEKCAJGJD<object> DFKODKPAJGM;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private HNDBKAHCONP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class BPAOJGIEALK : DBIGINEDNCI
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class NCMFAAOICPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4215A60", Offset = "0x4214C60", VA = "0x184215A60")]
		static NCMFAAOICPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class PJALGJKBFBN : DBIGINEDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class NJDDGKAJELF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::MODEKCAJGJD<T> CNOAAPHMBNH;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x4218EC0", Offset = "0x42180C0", VA = "0x184218EC0")]
			static NJDDGKAJELF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly DBIGINEDNCI HBKBBJLFPOI;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly DBIGINEDNCI[] PIKLAANHPBK;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		private PJALGJKBFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
		public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly DBIGINEDNCI HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::MODEKCAJGJD<object> DFKODKPAJGM;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	private BPAOJGIEALK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E30", Offset = "0x3CB6030", VA = "0x183CB6E30", Slot = "4")]
	public global::MODEKCAJGJD<T> HOBFBFEHINN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct NMJMNKCAHHL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] GMLFNJEBLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int FFGCGCCOGIH;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x46816D0", Offset = "0x46808D0", VA = "0x1846816D0")]
	public NMJMNKCAHHL(int KKOIHHCAAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4681530", Offset = "0x4680730", VA = "0x184681530")]
	public void KAGEPJABGKM(T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x46812F0", Offset = "0x46804F0", VA = "0x1846812F0")]
	public T[] EIADJMKAIGP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class DIJGCJGCAFC : global::BAOLGHJAHNG<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly DIJGCJGCAFC HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1719730", Offset = "0x1718930", VA = "0x181719730")]
	public DIJGCJGCAFC(int DBLOKDJNEMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class BAOLGHJAHNG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int DBLOKDJNEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object HCHEINKIFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int MJNAIOAAGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] EDDGCKHPLKB;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4629E10", Offset = "0x4629010", VA = "0x184629E10")]
	public BAOLGHJAHNG(int DBLOKDJNEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4628490", Offset = "0x4627690", VA = "0x184628490")]
	public T[] IACJOFBCMKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x46298D0", Offset = "0x4628AD0", VA = "0x1846298D0")]
	public void KJCHGFKOECA(T[] NAJOFPKLJJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class NEGOGAKEDDA : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class AFGEEIOJEAI : IComparable<AFGEEIOJEAI>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class CFNDPJENGNP : IEnumerable<AFGEEIOJEAI>, IEnumerable, IEnumerator<AFGEEIOJEAI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private AFGEEIOJEAI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public AFGEEIOJEAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private AFGEEIOJEAI System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x612CF0", Offset = "0x611EF0", VA = "0x180612CF0")]
			[DebuggerHidden]
			public CFNDPJENGNP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x22EEBA0", Offset = "0x22EDDA0", VA = "0x1822EEBA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x22EECD0", Offset = "0x22EDED0", VA = "0x1822EECD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x22EEC30", Offset = "0x22EDE30", VA = "0x1822EEC30", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AFGEEIOJEAI> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x22EEC30", Offset = "0x22EDE30", VA = "0x1822EEC30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class AJBHOCAEEFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public AJBHOCAEEFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x7F1C80", Offset = "0x7F0E80", VA = "0x1807F1C80")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x7F1C80", Offset = "0x7F0E80", VA = "0x1807F1C80")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly AFGEEIOJEAI[] MCOEKDMJFOD;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] LKLNGBOMNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong MOGKCHDHBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int MDDADGNJOKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string MOINJJKNFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private AFGEEIOJEAI[] HOGOJBCFCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] DINFMLCKAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int AEKEPEKODMN;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool KMEHDKCJBJK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1DBC910", Offset = "0x1DBBB10", VA = "0x181DBC910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x22EE850", Offset = "0x22EDA50", VA = "0x1822EE850")]
		public AFGEEIOJEAI(ulong JCNAPFOCJDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x22EE210", Offset = "0x22ED410", VA = "0x1822EE210")]
		public AFGEEIOJEAI KAGEPJABGKM(ulong JCNAPFOCJDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x22EE1C0", Offset = "0x22ED3C0", VA = "0x1822EE1C0")]
		public AFGEEIOJEAI KAGEPJABGKM(ulong JCNAPFOCJDI, int ADBNEBBHMOP, string MOINJJKNFGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x22EE4F0", Offset = "0x22ED6F0", VA = "0x1822EE4F0")]
		public AFGEEIOJEAI OAAFOMCMKIK(byte[] DNNNMCEHJCM, ref int FDGAPOLJFKN, ref int BMOGEIJBHMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x22EE470", Offset = "0x22ED670", VA = "0x1822EE470")]
		internal static int NFMMCPKMOHI(ulong[] NAJOFPKLJJG, int MJNAIOAAGCG, int IPOIAMFIOLH, ulong ADBNEBBHMOP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x22EE190", Offset = "0x22ED390", VA = "0x1822EE190", Slot = "4")]
		public int CompareTo(AFGEEIOJEAI GHOINNFPLDF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x22EE400", Offset = "0x22ED600", VA = "0x1822EE400")]
		[IteratorStateMachine(typeof(CFNDPJENGNP))]
		public IEnumerable<AFGEEIOJEAI> MFEEHIKONPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x22EE6A0", Offset = "0x22ED8A0", VA = "0x1822EE6A0")]
		public void OIDGKLAILHK(ILGenerator IMHPIBJCNHE, LocalBuilder DNNNMCEHJCM, LocalBuilder BMOGEIJBHMO, LocalBuilder JCNAPFOCJDI, Action<KeyValuePair<string, int>> HMOCBNPHLDC, Action EEHIKCNDNKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x22ED5B0", Offset = "0x22EC7B0", VA = "0x1822ED5B0")]
		private static void AMAPIBINFDE(ILGenerator IMHPIBJCNHE, LocalBuilder DNNNMCEHJCM, LocalBuilder BMOGEIJBHMO, LocalBuilder JCNAPFOCJDI, Action<KeyValuePair<string, int>> HMOCBNPHLDC, Action EEHIKCNDNKF, AFGEEIOJEAI[] HOGOJBCFCGG, int AEKEPEKODMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class MKDNKGHFCPA : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<AFGEEIOJEAI> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<AFGEEIOJEAI> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<AFGEEIOJEAI> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private AFGEEIOJEAI <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x7EA030", Offset = "0x7E9230", VA = "0x1807EA030", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x22F1780", Offset = "0x22F0980", VA = "0x1822F1780", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x880060", Offset = "0x87F260", VA = "0x180880060")]
		[DebuggerHidden]
		public MKDNKGHFCPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x22F17D0", Offset = "0x22F09D0", VA = "0x1822F17D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x22F1310", Offset = "0x22F0510", VA = "0x1822F1310", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x22F18D0", Offset = "0x22F0AD0", VA = "0x1822F18D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x22F1920", Offset = "0x22F0B20", VA = "0x1822F1920")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x22F1730", Offset = "0x22F0930", VA = "0x1822F1730", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x22F1690", Offset = "0x22F0890", VA = "0x1822F1690", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x22F1690", Offset = "0x22F0890", VA = "0x1822F1690", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly AFGEEIOJEAI LPCFHOPAELK;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x22F52C0", Offset = "0x22F44C0", VA = "0x1822F52C0")]
	public NEGOGAKEDDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x22F4DC0", Offset = "0x22F3FC0", VA = "0x1822F4DC0")]
	public void KAGEPJABGKM(byte[] FAOJAOEJLMO, int ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x22F4BE0", Offset = "0x22F3DE0", VA = "0x1822F4BE0")]
	public bool ECPALMOAGFB(ArraySegment<byte> JCNAPFOCJDI, out int ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x22F51D0", Offset = "0x22F43D0", VA = "0x1822F51D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x22F4F50", Offset = "0x22F4150", VA = "0x1822F4F50")]
	private static void PDFGCGLFNNN(IEnumerable<AFGEEIOJEAI> HOGOJBCFCGG, StringBuilder OIGMPFBMKME, int IDPOICMGJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x22F4C90", Offset = "0x22F3E90", VA = "0x1822F4C90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x22F4C90", Offset = "0x22F3E90", VA = "0x1822F4C90", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x22F4EE0", Offset = "0x22F40E0", VA = "0x1822F4EE0")]
	[IteratorStateMachine(typeof(MKDNKGHFCPA))]
	private static IEnumerable<KeyValuePair<string, int>> LJCINBBFIEO(IEnumerable<AFGEEIOJEAI> HOGOJBCFCGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x22F4D90", Offset = "0x22F3F90", VA = "0x1822F4D90")]
	public void JEAKANIAALM(ILGenerator IMHPIBJCNHE, LocalBuilder DNNNMCEHJCM, LocalBuilder BMOGEIJBHMO, LocalBuilder JCNAPFOCJDI, Action<KeyValuePair<string, int>> HMOCBNPHLDC, Action EEHIKCNDNKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class GAGOBLOPCNI
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo EHKOFFMEMLA;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x171D2F0", Offset = "0x171C4F0", VA = "0x18171D2F0")]
	public static ulong IGBKKGCBJPG(byte[] FAOJAOEJLMO, ref int FDGAPOLJFKN, ref int BMOGEIJBHMO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class ADAIHCAICBC
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x17109A0", Offset = "0x170FBA0", VA = "0x1817109A0")]
	public static void GFBBAIKPDNM(ref byte[] FAOJAOEJLMO, int FDGAPOLJFKN, int NGECBDNOKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x1710AC0", Offset = "0x170FCC0", VA = "0x181710AC0")]
	public static void KDLIBICMEDG(ref byte[] NAJOFPKLJJG, int CLDHFBKGCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x1710BB0", Offset = "0x170FDB0", VA = "0x181710BB0")]
	public static byte[] LALBBODGOJN(byte[] JGKODHNKDPL, int CLDHFBKGCMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class FPALEODOLNM
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x171D200", Offset = "0x171C400", VA = "0x18171D200")]
	public static bool KCEJIHLPAFP(byte[] BDIHNJHCBLF, int MCDBIEHMFDO, int HKHKHMPHMFP, byte[] KFJNPCCINED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class KOBABDPFBCC<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct PKNIFHOKBEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] MOGKCHDHBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T MDDADGNJOKH;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x1213CD0", Offset = "0x1212ED0", VA = "0x181213CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class NKPEJPKNPKL : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::KOBABDPFBCC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private PKNIFHOKBEO[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private PKNIFHOKBEO[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xBC6900", Offset = "0xBC5B00", VA = "0x180BC6900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1211E60", Offset = "0x1211060", VA = "0x181211E60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xE94A80", Offset = "0xE93C80", VA = "0x180E94A80")]
		[DebuggerHidden]
		public NKPEJPKNPKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x12103D0", Offset = "0x120F5D0", VA = "0x1812103D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x1211370", Offset = "0x1210570", VA = "0x181211370", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly PKNIFHOKBEO[][] MCOOCKLBOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong GPOHMLMEODI;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x120F450", Offset = "0x120E650", VA = "0x18120F450")]
	public KOBABDPFBCC(int GOCCOAPEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x120F480", Offset = "0x120E680", VA = "0x18120F480")]
	public KOBABDPFBCC(int GOCCOAPEHDE, float FFALLDGOGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x120DFE0", Offset = "0x120D1E0", VA = "0x18120DFE0")]
	public void KAGEPJABGKM(byte[] JCNAPFOCJDI, T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x120E930", Offset = "0x120DB30", VA = "0x18120E930")]
	private bool LFMGBKMNKIH(byte[] JCNAPFOCJDI, T ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x120DC90", Offset = "0x120CE90", VA = "0x18120DC90")]
	public bool HNIJFJOBNMJ(ArraySegment<byte> JCNAPFOCJDI, out T ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x120F3C0", Offset = "0x120E5C0", VA = "0x18120F3C0")]
	private static ulong OBNJEIOMHBL(byte[] FMHEJMEECNK, int FDGAPOLJFKN, int AEKEPEKODMN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x120F390", Offset = "0x120E590", VA = "0x18120F390")]
	private static int NECMJIJIEOA(int GLHMJOPDFNE, float FFALLDGOGJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x120D3D0", Offset = "0x120C5D0", VA = "0x18120D3D0", Slot = "4")]
	[IteratorStateMachine(typeof(global::KOBABDPFBCC<>.NKPEJPKNPKL))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x120F420", Offset = "0x120E620", VA = "0x18120F420", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class KMJFKIFDJAH : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] BIADJNAKIJO;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] HCIIFDLPGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int CECEDHFBFLF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool HCMPEBEGNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x1331370", Offset = "0x1330570", VA = "0x181331370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x13314D0", Offset = "0x13306D0", VA = "0x1813314D0")]
	static KMJFKIFDJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x1331720", Offset = "0x1330920", VA = "0x181331720")]
	public KMJFKIFDJAH(byte[] LLIAGNNNDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x13313C0", Offset = "0x13305C0", VA = "0x1813313C0")]
	public OpCode PFGFIGKIOPD()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct BAMDFIGOHDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid MDDADGNJOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte NPJJALBEOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte IJKBJIHAEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte ELMFDLPKFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte PFOAJKGNAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte JKLDJAGMLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte KGADOFCFBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte FNPBMBKOOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte EOPCKKGKMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte LGGCPJHFCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte KMMDAAHFHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte HLCDIBAPMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte NBAODBPFEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte CKJHFBKONAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte BPCHBEKJNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte DFNFNBLGOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte IOAGHILDGDM;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] OFHPHJPDMGG;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] JKAPEIIHPKM;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x1713B70", Offset = "0x1712D70", VA = "0x181713B70")]
	public BAMDFIGOHDI(ref Guid ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x1713B80", Offset = "0x1712D80", VA = "0x181713B80")]
	public BAMDFIGOHDI(ref ArraySegment<byte> KCBIDFCNMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x17138F0", Offset = "0x1712AF0", VA = "0x1817138F0")]
	private static byte KKDKJCGALIG(byte[] FAOJAOEJLMO, int ALKOFBJEHBF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x17139B0", Offset = "0x1712BB0", VA = "0x1817139B0")]
	private static byte POLFFILFPJP(byte KLGGEDCBMPK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x17125B0", Offset = "0x17117B0", VA = "0x1817125B0")]
	public void EMEEPHFDJML(byte[] MNCACBMIHMI, int FDGAPOLJFKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class PPHIBHNIMNN
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x22FB330", Offset = "0x22FA530", VA = "0x1822FB330")]
	public static bool IHGBBJJGCGI(byte FBCEFPPNKHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x22F9D20", Offset = "0x22F8F20", VA = "0x1822F9D20")]
	public static bool FOJIIOMDHFD(byte FBCEFPPNKHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x22FB4C0", Offset = "0x22FA6C0", VA = "0x1822FB4C0")]
	public static sbyte KIPIGOEJHFB(byte[] FAOJAOEJLMO, int FDGAPOLJFKN, out int INHGDGBPGGI)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x22F99E0", Offset = "0x22F8BE0", VA = "0x1822F99E0")]
	public static short COEJFNFNOJE(byte[] FAOJAOEJLMO, int FDGAPOLJFKN, out int INHGDGBPGGI)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x22F9D90", Offset = "0x22F8F90", VA = "0x1822F9D90")]
	public static int GFHKFKMKNJL(byte[] FAOJAOEJLMO, int FDGAPOLJFKN, out int INHGDGBPGGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x22F9E00", Offset = "0x22F9000", VA = "0x1822F9E00")]
	public static long GJCIOMPPJKH(byte[] FAOJAOEJLMO, int FDGAPOLJFKN, out int INHGDGBPGGI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x22FAAF0", Offset = "0x22F9CF0", VA = "0x1822FAAF0")]
	public static byte HFAGJHPCEFL(byte[] FAOJAOEJLMO, int FDGAPOLJFKN, out int INHGDGBPGGI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x22F9970", Offset = "0x22F8B70", VA = "0x1822F9970")]
	public static ushort CAGKGABEANP(byte[] FAOJAOEJLMO, int FDGAPOLJFKN, out int INHGDGBPGGI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x22F9CA0", Offset = "0x22F8EA0", VA = "0x1822F9CA0")]
	public static uint DKOOEMJALPB(byte[] FAOJAOEJLMO, int FDGAPOLJFKN, out int INHGDGBPGGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x22FB340", Offset = "0x22FA540", VA = "0x1822FB340")]
	public static ulong ILFOJNFABIN(byte[] FAOJAOEJLMO, int FDGAPOLJFKN, out int INHGDGBPGGI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x22FB530", Offset = "0x22FA730", VA = "0x1822FB530")]
	public static float LKABOBJBAOK(byte[] FAOJAOEJLMO, int FDGAPOLJFKN, out int INHGDGBPGGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x22FB450", Offset = "0x22FA650", VA = "0x1822FB450")]
	public static double KANGEKBKKAK(byte[] FAOJAOEJLMO, int FDGAPOLJFKN, out int INHGDGBPGGI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x22FAB60", Offset = "0x22F9D60", VA = "0x1822FAB60")]
	public static int HJALOCMJDPN(ref byte[] MNCACBMIHMI, int FDGAPOLJFKN, ulong ADBNEBBHMOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x22F9EB0", Offset = "0x22F90B0", VA = "0x1822F9EB0")]
	public static int HBOJOJPCILM(ref byte[] MNCACBMIHMI, int FDGAPOLJFKN, long ADBNEBBHMOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x22F9A50", Offset = "0x22F8C50", VA = "0x1822F9A50")]
	public static bool DBDJDAFGHNF(byte[] FAOJAOEJLMO, int FDGAPOLJFKN, out int INHGDGBPGGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class OMHJFMBPHPG
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class EDNCCPCBHEG : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x612CF0", Offset = "0x611EF0", VA = "0x180612CF0")]
		[DebuggerHidden]
		public EDNCCPCBHEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x22EF180", Offset = "0x22EE380", VA = "0x1822EF180", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x22EED20", Offset = "0x22EDF20", VA = "0x1822EED20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x22EF2A0", Offset = "0x22EE4A0", VA = "0x1822EF2A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x22EF2F0", Offset = "0x22EE4F0", VA = "0x1822EF2F0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x22EF130", Offset = "0x22EE330", VA = "0x1822EF130", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x22EF080", Offset = "0x22EE280", VA = "0x1822EF080", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x22EF080", Offset = "0x22EE280", VA = "0x1822EF080", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class HFCOMBKBOFC : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x612CF0", Offset = "0x611EF0", VA = "0x180612CF0")]
		[DebuggerHidden]
		public HFCOMBKBOFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x22EF7A0", Offset = "0x22EE9A0", VA = "0x1822EF7A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x22EF340", Offset = "0x22EE540", VA = "0x1822EF340", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x22EF8C0", Offset = "0x22EEAC0", VA = "0x1822EF8C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x22EF910", Offset = "0x22EEB10", VA = "0x1822EF910")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x22EF750", Offset = "0x22EE950", VA = "0x1822EF750", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x22EF6A0", Offset = "0x22EE8A0", VA = "0x1822EF6A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x22EF6A0", Offset = "0x22EE8A0", VA = "0x1822EF6A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x22F8450", Offset = "0x22F7650", VA = "0x1822F8450")]
	public static bool GPJECOMNHBA(this TypeInfo BGMCKNGNOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x22F8560", Offset = "0x22F7760", VA = "0x1822F8560")]
	public static bool OOEPPDJFGKO(this TypeInfo BGMCKNGNOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x22F8360", Offset = "0x22F7560", VA = "0x1822F8360")]
	public static IEnumerable<PropertyInfo> EIHAEDMHFNP(this Type BGMCKNGNOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x22F83C0", Offset = "0x22F75C0", VA = "0x1822F83C0")]
	[IteratorStateMachine(typeof(EDNCCPCBHEG))]
	private static IEnumerable<PropertyInfo> FIJNGNBAHKO(Type BGMCKNGNOJI, HashSet<string> PGFCPMOIFDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x22F8500", Offset = "0x22F7700", VA = "0x1822F8500")]
	public static IEnumerable<FieldInfo> IJKGJMFJAON(this Type BGMCKNGNOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x22F82D0", Offset = "0x22F74D0", VA = "0x1822F82D0")]
	[IteratorStateMachine(typeof(HFCOMBKBOFC))]
	private static IEnumerable<FieldInfo> BBFAFNDDDDO(Type BGMCKNGNOJI, HashSet<string> PGFCPMOIFDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class KKOKNFGLBGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding ADGOMIGNEBL;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class OFLEODPEIBG
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6D6330", Offset = "0x6D5530", VA = "0x1806D6330")]
	public static string JMBOGHMALKP(string NLJODIPCHDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x22F65F0", Offset = "0x22F57F0", VA = "0x1822F65F0")]
	public static string CLFHMPKODHB(string NLJODIPCHDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x22F6700", Offset = "0x22F5900", VA = "0x1822F6700")]
	public static string OKCNEAIMHII(string NLJODIPCHDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class KGKOENKGELA<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class CHIHKFLLJMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type MOGKCHDHBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue MDDADGNJOKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int LEFDHHDDJMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public CHIHKFLLJMP NPEHAMEJHBD;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1335160", Offset = "0x1334360", VA = "0x181335160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1334F00", Offset = "0x1334100", VA = "0x181334F00")]
		private int NAIIACDHEPJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public CHIHKFLLJMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class POMMHGNFMAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public POMMHGNFMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6FD290", Offset = "0x6FC490", VA = "0x1806FD290")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private CHIHKFLLJMP[] MCOOCKLBOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int DFCIFDODMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object CJEEKEFMNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float FFALLDGOGJC;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x1342490", Offset = "0x1341690", VA = "0x181342490")]
	public KGKOENKGELA(int GOCCOAPEHDE = 4, float FFALLDGOGJC = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x1340F80", Offset = "0x1340180", VA = "0x181340F80")]
	public bool EOLFFDHHMOF(Type JCNAPFOCJDI, TValue ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x1341090", Offset = "0x1340290", VA = "0x181341090")]
	public bool EOLFFDHHMOF(Type JCNAPFOCJDI, Func<Type, TValue> HJBHHGIJMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x1341940", Offset = "0x1340B40", VA = "0x181341940")]
	private bool LFMGBKMNKIH(Type JCNAPFOCJDI, Func<Type, TValue> HJBHHGIJMLD, out TValue FBIBEOEHLCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x1341C40", Offset = "0x1340E40", VA = "0x181341C40")]
	private bool PIAKBKCNLLN(CHIHKFLLJMP[] MCOOCKLBOCC, Type NIIPKOAJFIC, CHIHKFLLJMP EDBFNELIMAO, Func<Type, TValue> HJBHHGIJMLD, out TValue FBIBEOEHLCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x13413A0", Offset = "0x13405A0", VA = "0x1813413A0")]
	public bool HNIJFJOBNMJ(Type JCNAPFOCJDI, out TValue ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x1341220", Offset = "0x1340420", VA = "0x181341220")]
	public TValue FDAHGLBNFBD(Type JCNAPFOCJDI, Func<Type, TValue> HJBHHGIJMLD)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x120F390", Offset = "0x120E590", VA = "0x18120F390")]
	private static int NECMJIJIEOA(int GLHMJOPDFNE, float FFALLDGOGJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x1341370", Offset = "0x1340570", VA = "0x181341370")]
	private static void FPCPFCPGONB(ref CHIHKFLLJMP MOAFHKBBDOA, CHIHKFLLJMP ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x1341370", Offset = "0x1340570", VA = "0x181341370")]
	private static void FPCPFCPGONB(ref CHIHKFLLJMP[] MOAFHKBBDOA, CHIHKFLLJMP[] ADBNEBBHMOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class JCCOMAGIAEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder GOGHLODKIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder GNPJJKHCDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object HCHEINKIFNM;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x1328880", Offset = "0x1327A80", VA = "0x181328880")]
	public TypeBuilder KEILHICCNKP(string JFLKGPEABBP, TypeAttributes AHIJDNMPADN, Type ENAGHEEPLJN, Type[] JNMEENFDNGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x1328970", Offset = "0x1327B70", VA = "0x181328970")]
	public JCCOMAGIAEB(string NHLEGKPGKAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class OFAPJMIGPIH
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x22F6500", Offset = "0x22F5700", VA = "0x1822F6500")]
	private static MethodInfo KAEDGGOFGNP(LambdaExpression HJNHOGNDPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x44602E0", Offset = "0x445F4E0", VA = "0x1844602E0")]
	public static MethodInfo NKOCJEPLCDP<T>(Expression<Func<T>> HJNHOGNDPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x44602E0", Offset = "0x445F4E0", VA = "0x1844602E0")]
	public static MethodInfo NKOCJEPLCDP<T, TR>(Expression<Func<T, TR>> HJNHOGNDPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x44602E0", Offset = "0x445F4E0", VA = "0x1844602E0")]
	public static MethodInfo NKOCJEPLCDP<T>(Expression<Action<T>> HJNHOGNDPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x44602E0", Offset = "0x445F4E0", VA = "0x1844602E0")]
	public static MethodInfo NKOCJEPLCDP<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> HJNHOGNDPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x4460240", Offset = "0x445F440", VA = "0x184460240")]
	private static MemberInfo IEBAFEFDHDA<T>(Expression<T> FKKKHANKMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x44602F0", Offset = "0x445F4F0", VA = "0x1844602F0")]
	public static PropertyInfo OCOGKNKHBLN<T, TR>(Expression<Func<T, TR>> HJNHOGNDPNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct MGDDBIHIEIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int OCLFFJGEIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool HMLCGDIJDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator IMHPIBJCNHE;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x22F11E0", Offset = "0x22F03E0", VA = "0x1822F11E0")]
	public MGDDBIHIEIC(ILGenerator IMHPIBJCNHE, int OCLFFJGEIJK, bool HMLCGDIJDKB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x22F1220", Offset = "0x22F0420", VA = "0x1822F1220")]
	public MGDDBIHIEIC(ILGenerator IMHPIBJCNHE, int OCLFFJGEIJK, Type BGMCKNGNOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x22F11C0", Offset = "0x22F03C0", VA = "0x1822F11C0")]
	public void GAMEILAJOLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class JPCHIECBCNC
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x132D470", Offset = "0x132C670", VA = "0x18132D470")]
	public static void DLLCDCLPDKN(this ILGenerator IMHPIBJCNHE, int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x132D6A0", Offset = "0x132C8A0", VA = "0x18132D6A0")]
	public static void DLLCDCLPDKN(this ILGenerator IMHPIBJCNHE, LocalBuilder KHNFMPPOKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x132D950", Offset = "0x132CB50", VA = "0x18132D950")]
	public static void GJEKNENNMMJ(this ILGenerator IMHPIBJCNHE, int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x132DB80", Offset = "0x132CD80", VA = "0x18132DB80")]
	public static void GJEKNENNMMJ(this ILGenerator IMHPIBJCNHE, LocalBuilder KHNFMPPOKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x132D370", Offset = "0x132C570", VA = "0x18132D370")]
	public static void CMKKCJIJAKG(this ILGenerator IMHPIBJCNHE, int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x132D260", Offset = "0x132C460", VA = "0x18132D260")]
	public static void CMKKCJIJAKG(this ILGenerator IMHPIBJCNHE, LocalBuilder KHNFMPPOKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x132D460", Offset = "0x132C660", VA = "0x18132D460")]
	public static void DLBCKGDLIHI(this ILGenerator IMHPIBJCNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x132E4F0", Offset = "0x132D6F0", VA = "0x18132E4F0")]
	public static void OBPKICKIIOG(this ILGenerator IMHPIBJCNHE, bool ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x132E0A0", Offset = "0x132D2A0", VA = "0x18132E0A0")]
	public static void MOEHDJMFIHD(this ILGenerator IMHPIBJCNHE, int ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x132D860", Offset = "0x132CA60", VA = "0x18132D860")]
	public static void GHGIOACNGAA(this ILGenerator IMHPIBJCNHE, Type BGMCKNGNOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x132DBC0", Offset = "0x132CDC0", VA = "0x18132DBC0")]
	public static void HNIJIBHAFNH(this ILGenerator IMHPIBJCNHE, Type BGMCKNGNOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x132DE70", Offset = "0x132D070", VA = "0x18132DE70")]
	public static void MMJEDAEIIGG(this ILGenerator IMHPIBJCNHE, int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x132DC60", Offset = "0x132CE60", VA = "0x18132DC60")]
	public static void JLIPLGJFCOO(this ILGenerator IMHPIBJCNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x132D6E0", Offset = "0x132C8E0", VA = "0x18132D6E0")]
	public static void FJHGCIDELHM(this ILGenerator IMHPIBJCNHE, int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x132DCE0", Offset = "0x132CEE0", VA = "0x18132DCE0")]
	public static void KFCOOIPEOGC(this ILGenerator IMHPIBJCNHE, MethodInfo MHGDKANKBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x132D7D0", Offset = "0x132C9D0", VA = "0x18132D7D0")]
	public static void GABGJFMDAHE(this ILGenerator IMHPIBJCNHE, FieldInfo MFPIBJPEKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x132DDE0", Offset = "0x132CFE0", VA = "0x18132DDE0")]
	public static void LFMOJKPELNM(this ILGenerator IMHPIBJCNHE, ulong ADBNEBBHMOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class BJBFHCBDJAA
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class HNJKEJBDCFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public HNJKEJBDCFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x17263D0", Offset = "0x17255D0", VA = "0x1817263D0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo PGEAADPCDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo BJGBIKNBNMD;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string JPGOKIEGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6EE480", Offset = "0x6ED680", VA = "0x1806EE480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string JJBGOCPBDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x623BB0", Offset = "0x622DB0", VA = "0x180623BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool BIIPBHMEJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x1714F00", Offset = "0x1714100", VA = "0x181714F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JCHNKGABNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7E92A0", Offset = "0x7E84A0", VA = "0x1807E92A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x94A800", Offset = "0x949A00", VA = "0x18094A800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MPLNALEKAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7E92B0", Offset = "0x7E84B0", VA = "0x1807E92B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x94A820", Offset = "0x949A20", VA = "0x18094A820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type IHACIPDHDBG
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6FD450", Offset = "0x6FC650", VA = "0x1806FD450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo FFDMHIHBOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x734270", Offset = "0x733470", VA = "0x180734270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7D6460", Offset = "0x7D5660", VA = "0x1807D6460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo LFMBGPKDMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6FCDA0", Offset = "0x6FBFA0", VA = "0x1806FCDA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6FD080", Offset = "0x6FC280", VA = "0x1806FD080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo FEMBHLBDAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5FAF50", Offset = "0x5FA150", VA = "0x1805FAF50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5FAF60", Offset = "0x5FA160", VA = "0x1805FAF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x17151B0", Offset = "0x17143B0", VA = "0x1817151B0")]
	protected BJBFHCBDJAA(Type BGMCKNGNOJI, string JFLKGPEABBP, string GNOBKBOKFCF, bool IDEHHPOFNMA, bool JNONMKCMPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1715230", Offset = "0x1714430", VA = "0x181715230")]
	public BJBFHCBDJAA(FieldInfo LFBIOJBBNIJ, string JFLKGPEABBP, bool MDOOJPFHHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1715340", Offset = "0x1714540", VA = "0x181715340")]
	public BJBFHCBDJAA(PropertyInfo LFBIOJBBNIJ, string JFLKGPEABBP, bool MDOOJPFHHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1714FD0", Offset = "0x17141D0", VA = "0x181714FD0")]
	private static MethodInfo HMDLMAJPNBK(MemberInfo LFBIOJBBNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x3845340", Offset = "0x3844540", VA = "0x183845340")]
	public T FGNEHPPKIGC<T>(bool JADFHDGODOD) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x17150F0", Offset = "0x17142F0", VA = "0x1817150F0", Slot = "4")]
	public virtual void KBAECHDMFNA(ILGenerator IMHPIBJCNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x1714F10", Offset = "0x1714110", VA = "0x181714F10", Slot = "5")]
	public virtual void HDLOKDENKJK(ILGenerator IMHPIBJCNHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class NACIPBCGJNL : BJBFHCBDJAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string OIHACPJHIKB;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x22F46B0", Offset = "0x22F38B0", VA = "0x1822F46B0")]
	public NACIPBCGJNL(string JFLKGPEABBP, string OIHACPJHIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x22F45F0", Offset = "0x22F37F0", VA = "0x1822F45F0", Slot = "4")]
	public override void KBAECHDMFNA(ILGenerator IMHPIBJCNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x22F45A0", Offset = "0x22F37A0", VA = "0x1822F45A0", Slot = "5")]
	public override void HDLOKDENKJK(ILGenerator IMHPIBJCNHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class IJCEOPLCJEA : BJBFHCBDJAA
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo KEBIGJDLNDC;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo AHBNNHLGHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal MGDDBIHIEIC JHHPCMDIJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal MGDDBIHIEIC INPOGHBPANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal MGDDBIHIEIC NPHNMKOLMHM;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x131D530", Offset = "0x131C730", VA = "0x18131D530")]
	public IJCEOPLCJEA(string JFLKGPEABBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x131CFD0", Offset = "0x131C1D0", VA = "0x18131CFD0", Slot = "4")]
	public override void KBAECHDMFNA(ILGenerator IMHPIBJCNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x131CF80", Offset = "0x131C180", VA = "0x18131CF80", Slot = "5")]
	public override void HDLOKDENKJK(ILGenerator IMHPIBJCNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x131CE70", Offset = "0x131C070", VA = "0x18131CE70")]
	public void EKOAIAIIDGL(ILGenerator IMHPIBJCNHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class DPBDEJIKHIN
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type IHACIPDHDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6EE480", Offset = "0x6ED680", VA = "0x1806EE480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FGNKFONBCHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D50", Offset = "0x7D0F50", VA = "0x1807D1D50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D30", Offset = "0x7D0F30", VA = "0x1807D1D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HCLCBECNPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7D1920", Offset = "0x7D0B20", VA = "0x1807D1920")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D20", Offset = "0x7D0F20", VA = "0x1807D1D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo ANBCCLFLPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD10", Offset = "0x5FCF10", VA = "0x1805FDD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD20", Offset = "0x5FCF20", VA = "0x1805FDD20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public BJBFHCBDJAA[] ALLGNOBCGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6FD450", Offset = "0x6FC650", VA = "0x1806FD450")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public BJBFHCBDJAA[] BBJOENLFEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x734270", Offset = "0x733470", VA = "0x180734270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7D6460", Offset = "0x7D5660", VA = "0x1807D6460")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1719A20", Offset = "0x1718C20", VA = "0x181719A20")]
	public DPBDEJIKHIN(Type BGMCKNGNOJI, Func<string, string> MELIADOJCDD, bool MDOOJPFHHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x1719950", Offset = "0x1718B50", VA = "0x181719950")]
	private static bool CJOKPFIBPCE(IEnumerator<ConstructorInfo> GKGGHMLOEKJ, ref ConstructorInfo CFGFCCKHOJA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct MAFNAELHBFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong BJKCOFOFGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int MAMHFFLAIIN;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x22F04A0", Offset = "0x22EF6A0", VA = "0x1822F04A0")]
	public MAFNAELHBFO(ulong BDBHIPIIEAC, int CHPIGIECBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x22F0280", Offset = "0x22EF480", VA = "0x1822F0280")]
	public void BBDCHLPNLJL(ref MAFNAELHBFO GHOINNFPLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x22F0290", Offset = "0x22EF490", VA = "0x1822F0290")]
	public static MAFNAELHBFO DPELGNPBKJO(ref MAFNAELHBFO PJIOBOBOEGF, ref MAFNAELHBFO KLGGEDCBMPK)
	{
		return default(MAFNAELHBFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x22F0370", Offset = "0x22EF570", VA = "0x1822F0370")]
	public void NMDPMHOJJGO(ref MAFNAELHBFO GHOINNFPLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x22F02C0", Offset = "0x22EF4C0", VA = "0x1822F02C0")]
	public static MAFNAELHBFO EMKJBGBENEN(ref MAFNAELHBFO PJIOBOBOEGF, ref MAFNAELHBFO KLGGEDCBMPK)
	{
		return default(MAFNAELHBFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x22F0400", Offset = "0x22EF600", VA = "0x1822F0400")]
	public void PPBBFCEDEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x22F0440", Offset = "0x22EF640", VA = "0x1822F0440")]
	public static MAFNAELHBFO PPBBFCEDEBM(ref MAFNAELHBFO PJIOBOBOEGF)
	{
		return default(MAFNAELHBFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct ACAAGHCIAIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] MNCACBMIHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int FDGAPOLJFKN;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0xC4FDD0", Offset = "0xC4EFD0", VA = "0x180C4FDD0")]
	public ACAAGHCIAIK(byte[] MNCACBMIHMI, int BCCJFEBGGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x1710620", Offset = "0x170F820", VA = "0x181710620")]
	public void MDHENBHDPAD(byte NBKPPCECHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x1710580", Offset = "0x170F780", VA = "0x181710580")]
	public void LFMKHAHEEBB(byte[] NBKPPCECHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x17104E0", Offset = "0x170F6E0", VA = "0x1817104E0")]
	public void GMHMMFJGNNF(byte[] NBKPPCECHEN, int IPOIAMFIOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x1710430", Offset = "0x170F630", VA = "0x181710430")]
	public void GMHMMFJGNNF(byte[] NBKPPCECHEN, int FLFAMDBICFJ, int IPOIAMFIOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x17102B0", Offset = "0x170F4B0", VA = "0x1817102B0")]
	public void AFOKHCIKJDB(byte FBCEFPPNKHI, int AEKEPEKODMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x1710330", Offset = "0x170F530", VA = "0x181710330")]
	public void GEFOANCJLGB(string NBKPPCECHEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class HAGDMNLDJPM
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum KIBBLFDAAOG
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum MGMDKBCAOFB
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum LFJBLFJJBDB
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
	private static byte[] GLBIECKIGGB;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] ILCOMBKBMJH;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] IFOKKEFCHBG;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] DKNJBHMGGIF;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly LFJBLFJJBDB BLAKIIIGEAG;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char DPGOMKHOBAC;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int FKKIMLEHICN;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int DCNFLNFNPJA;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] LOBAMNIKHGL;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x1721CD0", Offset = "0x1720ED0", VA = "0x181721CD0")]
	private static byte[] AMGIAAOKKKF(int DFCIFDODMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x1723320", Offset = "0x1722520", VA = "0x181723320")]
	private static byte[] LEFGFMIJJNO(int DFCIFDODMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x17224D0", Offset = "0x17216D0", VA = "0x1817224D0")]
	public static int BHEFBOOFFBA(ref byte[] MNCACBMIHMI, int FDGAPOLJFKN, float ADBNEBBHMOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x17223C0", Offset = "0x17215C0", VA = "0x1817223C0")]
	public static int BHEFBOOFFBA(ref byte[] MNCACBMIHMI, int FDGAPOLJFKN, double ADBNEBBHMOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x1722CE0", Offset = "0x1721EE0", VA = "0x181722CE0")]
	private static bool FNEHIFJHBNM(byte[] MNCACBMIHMI, int IPOIAMFIOLH, ulong HLMBFFKIPDK, ulong KHGPDIAGNJK, ulong BMOGEIJBHMO, ulong EOPJCMFFIBF, ulong FBHALCEGGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x1723870", Offset = "0x1722A70", VA = "0x181723870")]
	private static void OOLFACOGODE(uint FBHMIFBNOEJ, int MIJCIPGEFID, out uint GGHMNAPMPPG, out int LIFAAHJIIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x1722890", Offset = "0x1721A90", VA = "0x181722890")]
	private static bool EKMKAGPPLCB(MAFNAELHBFO HIAENBLADKE, MAFNAELHBFO OBCBDNBHHOM, MAFNAELHBFO IGEBCPAMJAK, byte[] MNCACBMIHMI, out int IPOIAMFIOLH, out int CKOAKHKLBHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x17225E0", Offset = "0x17217E0", VA = "0x1817225E0")]
	private static bool DNFEHIHHKAC(double BGOLGEMKCDC, KIBBLFDAAOG PCDNKMPEHGG, byte[] MNCACBMIHMI, out int IPOIAMFIOLH, out int CKKGPGEFLNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x1722DE0", Offset = "0x1721FE0", VA = "0x181722DE0")]
	private static bool HGCEBPIPOEC(double BGOLGEMKCDC, KIBBLFDAAOG PCDNKMPEHGG, byte[] MNCACBMIHMI, out int IPOIAMFIOLH, out int PLKLBPBEBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x17236E0", Offset = "0x17228E0", VA = "0x1817236E0")]
	private static bool MJDMHBLNOLK(double ADBNEBBHMOP, ref ACAAGHCIAIK DDIMCFHGDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x1721DA0", Offset = "0x1720FA0", VA = "0x181721DA0")]
	private static bool BBMIPEENCIM(double ADBNEBBHMOP, ref ACAAGHCIAIK DDIMCFHGDFB, MGMDKBCAOFB PCDNKMPEHGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x1723400", Offset = "0x1722600", VA = "0x181723400")]
	private static void LHKEOOGHJND(byte[] KINOHMFGALJ, int IPOIAMFIOLH, int PLKLBPBEBJN, int BLDICCOLACF, ref ACAAGHCIAIK DDIMCFHGDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x1722ED0", Offset = "0x17220D0", VA = "0x181722ED0")]
	private static void JMFPBOOJOMG(byte[] KINOHMFGALJ, int IPOIAMFIOLH, int CHPIGIECBOL, ref ACAAGHCIAIK DDIMCFHGDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x1721B50", Offset = "0x1720D50", VA = "0x181721B50")]
	private static bool ALPDAPJECDL(double BGOLGEMKCDC, MGMDKBCAOFB PCDNKMPEHGG, int KILCAJJIDDB, byte[] GAMEFPCEHIF, out bool LGEMMNKHOML, out int IPOIAMFIOLH, out int FPDOMCKPEJE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct NHLIPMMKFKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double NMCOJHAIJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong BJPIGEBNFMG;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct LFEPBMHBBDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float BJKCOFOFGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint EHHNDLJIGHO;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct GOEOEELFODN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong PGIBACGLKIE;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1721220", Offset = "0x1720420", VA = "0x181721220")]
	public GOEOEELFODN(double NMCOJHAIJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x1721180", Offset = "0x1720380", VA = "0x181721180")]
	public GOEOEELFODN(MAFNAELHBFO NMCOJHAIJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x1720D60", Offset = "0x171FF60", VA = "0x181720D60")]
	public MAFNAELHBFO DPLMLADDLGB()
	{
		return default(MAFNAELHBFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x1720C20", Offset = "0x171FE20", VA = "0x181720C20")]
	public MAFNAELHBFO BPPFNPKKDMO()
	{
		return default(MAFNAELHBFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x72F660", Offset = "0x72E860", VA = "0x18072F660")]
	public ulong MAHABMPNAGB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x17210B0", Offset = "0x17202B0", VA = "0x1817210B0")]
	public double KDAKKEGAPEF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x1720BA0", Offset = "0x171FDA0", VA = "0x181720BA0")]
	public double APNHCDGNDHL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x1721060", Offset = "0x1720260", VA = "0x181721060")]
	public int IMCDNNPBBFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x1720DE0", Offset = "0x171FFE0", VA = "0x181720DE0")]
	public ulong EAHFBGJGIHO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1720E40", Offset = "0x1720040", VA = "0x181720E40")]
	public bool ELJEKJNDDBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x1720E60", Offset = "0x1720060", VA = "0x181720E60")]
	public bool FAKLDPIGMFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x1721150", Offset = "0x1720350", VA = "0x181721150")]
	public bool PDJLLFKOJAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x1720E10", Offset = "0x1720010", VA = "0x181720E10")]
	public bool EFNNMEIGGHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x1721130", Offset = "0x1720330", VA = "0x181721130")]
	public int NCIDGNDEIJK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x1720ED0", Offset = "0x17200D0", VA = "0x181720ED0")]
	public void IBCFIFFMCNK(out MAFNAELHBFO CPDHGNBJEJO, out MAFNAELHBFO LMGDFPHHNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x1720E80", Offset = "0x1720080", VA = "0x181720E80")]
	public bool HIMEENFLBLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x1720B90", Offset = "0x171FD90", VA = "0x181720B90")]
	public double ADBNEBBHMOP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x1721090", Offset = "0x1720290", VA = "0x181721090")]
	public static int JNPPCCGDJEN(int JCCNDGIFLDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x1721120", Offset = "0x1720320", VA = "0x181721120")]
	public static double LPPPPGOBKIH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x1720CC0", Offset = "0x171FEC0", VA = "0x181720CC0")]
	public static ulong DNBAMDMHLDO(MAFNAELHBFO ONCLFJEPFIE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct BBMBHBJJDIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint DPBIDOAIAIL;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x730D50", Offset = "0x72FF50", VA = "0x180730D50")]
	public BBMBHBJJDIM(float BJKCOFOFGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x1714230", Offset = "0x1713430", VA = "0x181714230")]
	public MAFNAELHBFO DPLMLADDLGB()
	{
		return default(MAFNAELHBFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6FD360", Offset = "0x6FC560", VA = "0x1806FD360")]
	public uint CBBOMGFCHKK()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1714480", Offset = "0x1713680", VA = "0x181714480")]
	public int IMCDNNPBBFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x17142A0", Offset = "0x17134A0", VA = "0x1817142A0")]
	public uint EAHFBGJGIHO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x17142C0", Offset = "0x17134C0", VA = "0x1817142C0")]
	public bool ELJEKJNDDBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x1714310", Offset = "0x1713510", VA = "0x181714310")]
	public void IBCFIFFMCNK(out MAFNAELHBFO CPDHGNBJEJO, out MAFNAELHBFO LMGDFPHHNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x17142D0", Offset = "0x17134D0", VA = "0x1817142D0")]
	public bool HIMEENFLBLB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct NFKAHIBOABB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong BDBHIPIIEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short PLGEHKEPLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short CKKGPGEFLNH;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x22F5330", Offset = "0x22F4530", VA = "0x1822F5330")]
	public NFKAHIBOABB(ulong BDBHIPIIEAC, short PLGEHKEPLJB, short CKKGPGEFLNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class KBNABACIMEH
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly NFKAHIBOABB[] JPCOEMNDJOH;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x132E600", Offset = "0x132D800", VA = "0x18132E600")]
	public static void HKHLDHAMKKD(int BMPPCMDGPHF, int PIDCLGKJADG, out MAFNAELHBFO GGHMNAPMPPG, out int CKKGPGEFLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x132E500", Offset = "0x132D700", VA = "0x18132E500")]
	public static void ALBFKLMPKPN(int NODAGIKKLJI, out MAFNAELHBFO GGHMNAPMPPG, out int ILDGODPHEBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct KJGFIFCJNEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] FAOJAOEJLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int FLFAMDBICFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int COLADBGLOFO;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1331070", Offset = "0x1330270", VA = "0x181331070")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0xEEA950", Offset = "0xEE9B50", VA = "0x180EEA950")]
	public KJGFIFCJNEG(byte[] FAOJAOEJLMO, int FLFAMDBICFJ, int IPOIAMFIOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xFD59B0", Offset = "0xFD4BB0", VA = "0x180FD59B0")]
	public int IPOIAMFIOLH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1331010", Offset = "0x1330210", VA = "0x181331010")]
	public KJGFIFCJNEG NCKBOHGADNF(int BIJIDMJOAIO, int IOCAJCEENLG)
	{
		return default(KJGFIFCJNEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class LLIFFFJNBPK
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] PGEAMHGMIJH;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] JGLNDJNJJNC;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int MGHPGEBIPKO;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x13329D0", Offset = "0x1331BD0", VA = "0x1813329D0")]
	private static byte[] FFELIHHGFNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x13334F0", Offset = "0x13326F0", VA = "0x1813334F0")]
	private static KJGFIFCJNEG NPCNNLNBDLF(KJGFIFCJNEG MNCACBMIHMI)
	{
		return default(KJGFIFCJNEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x1332B40", Offset = "0x1331D40", VA = "0x181332B40")]
	private static KJGFIFCJNEG JBGGMEJBHOE(KJGFIFCJNEG MNCACBMIHMI)
	{
		return default(KJGFIFCJNEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1333440", Offset = "0x1332640", VA = "0x181333440")]
	private static void MAIBKLMFDCI(KJGFIFCJNEG MNCACBMIHMI, int CHPIGIECBOL, byte[] IGNIHEHJJAB, out int FIJHLAGELJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x13337B0", Offset = "0x13329B0", VA = "0x1813337B0")]
	private static void PBOFMEJBJCB(KJGFIFCJNEG MNCACBMIHMI, int CHPIGIECBOL, byte[] MAPNEOFLHLD, int LMMCAEKDFMM, out KJGFIFCJNEG IEFEIEGLDLE, out int LGIBPDJBOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x1332AB0", Offset = "0x1331CB0", VA = "0x181332AB0")]
	private static ulong IBLCFFAHEJO(KJGFIFCJNEG MNCACBMIHMI, out int GJPBAOEJODN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x1332370", Offset = "0x1331570", VA = "0x181332370")]
	private static void BKOECMKIMBI(KJGFIFCJNEG MNCACBMIHMI, out MAFNAELHBFO LHPJBAGJLHP, out int NMEABEJFFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x1332EC0", Offset = "0x13320C0", VA = "0x181332EC0")]
	private static bool KFBIKJEBGJD(KJGFIFCJNEG IEFEIEGLDLE, int CHPIGIECBOL, out double LHPJBAGJLHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x1332D60", Offset = "0x1331F60", VA = "0x181332D60")]
	private static MAFNAELHBFO JOJIABNNAGC(int CHPIGIECBOL)
	{
		return default(MAFNAELHBFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1332510", Offset = "0x1331710", VA = "0x181332510")]
	private static bool FDOMFHIKEPC(KJGFIFCJNEG MNCACBMIHMI, int CHPIGIECBOL, out double LHPJBAGJLHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1332C20", Offset = "0x1331E20", VA = "0x181332C20")]
	private static bool JCADMKFPMEP(KJGFIFCJNEG IEFEIEGLDLE, int CHPIGIECBOL, out double KGPMEKBCNJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x1333310", Offset = "0x1332510", VA = "0x181333310")]
	public static double? KOHBDPKNIID(KJGFIFCJNEG MNCACBMIHMI, int CHPIGIECBOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x13335D0", Offset = "0x13327D0", VA = "0x1813335D0")]
	public static float? OPJOOINJNHG(KJGFIFCJNEG MNCACBMIHMI, int CHPIGIECBOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct BCPGNMIDBDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] MNCACBMIHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int FDGAPOLJFKN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte MDDADGNJOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x1714D10", Offset = "0x1713F10", VA = "0x181714D10")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0xC4FDD0", Offset = "0xC4EFD0", VA = "0x180C4FDD0")]
	public BCPGNMIDBDG(byte[] MNCACBMIHMI, int FDGAPOLJFKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1714DB0", Offset = "0x1713FB0", VA = "0x181714DB0")]
	public static BCPGNMIDBDG OGPNBBJIOCJ(BCPGNMIDBDG BJFNBIEJBCK)
	{
		return default(BCPGNMIDBDG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x1714B30", Offset = "0x1713D30", VA = "0x181714B30")]
	public static BCPGNMIDBDG ANJIEFFMCOH(BCPGNMIDBDG BJFNBIEJBCK, int IPOIAMFIOLH)
	{
		return default(BCPGNMIDBDG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x1714CB0", Offset = "0x1713EB0", VA = "0x181714CB0")]
	public static int JNDNLPFCIJJ(BCPGNMIDBDG DHAMHGONHGF, BCPGNMIDBDG ODBGDMOKIMO)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x1714D50", Offset = "0x1713F50", VA = "0x181714D50")]
	public static bool OBFGCGKAGJG(BCPGNMIDBDG DHAMHGONHGF, BCPGNMIDBDG ODBGDMOKIMO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x1714C50", Offset = "0x1713E50", VA = "0x181714C50")]
	public static bool IHGNJAHCODI(BCPGNMIDBDG DHAMHGONHGF, BCPGNMIDBDG ODBGDMOKIMO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x1714D70", Offset = "0x1713F70", VA = "0x181714D70")]
	public static bool OBFGCGKAGJG(BCPGNMIDBDG DHAMHGONHGF, char ODBGDMOKIMO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1714C10", Offset = "0x1713E10", VA = "0x181714C10")]
	public static bool IHGNJAHCODI(BCPGNMIDBDG DHAMHGONHGF, char ODBGDMOKIMO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x1714C10", Offset = "0x1713E10", VA = "0x181714C10")]
	public static bool IHGNJAHCODI(BCPGNMIDBDG DHAMHGONHGF, byte ODBGDMOKIMO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1714B90", Offset = "0x1713D90", VA = "0x181714B90")]
	public static bool AOGNOADGINI(BCPGNMIDBDG DHAMHGONHGF, char ODBGDMOKIMO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x1714C70", Offset = "0x1713E70", VA = "0x181714C70")]
	public static bool JCEKCGBGPBH(BCPGNMIDBDG DHAMHGONHGF, char ODBGDMOKIMO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x1714BD0", Offset = "0x1713DD0", VA = "0x181714BD0")]
	public static bool APGFOKNFNCF(BCPGNMIDBDG DHAMHGONHGF, char ODBGDMOKIMO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x1714CD0", Offset = "0x1713ED0", VA = "0x181714CD0")]
	public static bool LMHJAMANDJO(BCPGNMIDBDG DHAMHGONHGF, char ODBGDMOKIMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class JOLHLGABHEH
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] PEGOEFIKFBI;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] IEAHLINMFHI;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] IFOKKEFCHBG;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] DKNJBHMGGIF;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] FNMPNPJGKNA;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int IIPAIDNJPAD;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] DEBCMEOBHGP;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int INNJNKHMEDE;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x132CD10", Offset = "0x132BF10", VA = "0x18132CD10")]
	private static byte[] GMLKEIJMOOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x132CE40", Offset = "0x132C040", VA = "0x18132CE40")]
	private static byte[] NFCHDFBBEIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x132CAD0", Offset = "0x132BCD0", VA = "0x18132CAD0")]
	public static double FMBBEECJCEN(byte[] MNCACBMIHMI, int FDGAPOLJFKN, out int INHGDGBPGGI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x132B6B0", Offset = "0x132A8B0", VA = "0x18132B6B0")]
	public static float CKJIKNPNLGD(byte[] MNCACBMIHMI, int FDGAPOLJFKN, out int INHGDGBPGGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x132CB90", Offset = "0x132BD90", VA = "0x18132CB90")]
	private static bool GLCGPOHCMBH(int FMHEJMEECNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x132CF20", Offset = "0x132C120", VA = "0x18132CF20")]
	private static bool OLALHJDJPBM(ref BCPGNMIDBDG DCBHGCPJBOG, BCPGNMIDBDG FOKHGDFDAEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x132B770", Offset = "0x132A970", VA = "0x18132B770")]
	private static bool CLPCNPOPDHE(ref BCPGNMIDBDG DCBHGCPJBOG, BCPGNMIDBDG FOKHGDFDAEJ, byte[] NMEFNNOOPFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x132CDF0", Offset = "0x132BFF0", VA = "0x18132CDF0")]
	private static bool KNGJEFGCBIG(ref BCPGNMIDBDG MFDFLKAAMDL, byte[] NBKPPCECHEN, int FDGAPOLJFKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xE21500", Offset = "0xE20700", VA = "0x180E21500")]
	private static double KMLCMNMCGAO(bool LGEMMNKHOML)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x132B880", Offset = "0x132AA80", VA = "0x18132B880")]
	private static double EOAKDIMMMNA(BCPGNMIDBDG IMDMMLGELMH, int IPOIAMFIOLH, bool PJHNNCCJBDA, out int OCDADDLFPOM)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class NKDCBONPKMH<T> : global::MODEKCAJGJD<T[]>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::BAOLGHJAHNG<T> CLNLELPEHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly OBBNCDCMLPA AMNBNLKEKMF;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0xE94AB0", Offset = "0xE93CB0", VA = "0x180E94AB0")]
	public NKDCBONPKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xE94A80", Offset = "0xE93C80", VA = "0x180E94A80")]
	public NKDCBONPKMH(OBBNCDCMLPA AMNBNLKEKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2283CB0", Offset = "0x2282EB0", VA = "0x182283CB0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, T[] ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2282350", Offset = "0x2281550", VA = "0x182282350", Slot = "5")]
	public T[] LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class KAGNKIDBIAE<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::BAOLGHJAHNG<T> CLNLELPEHOF;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class LJKNLPHNICM<T> : global::MODEKCAJGJD<List<T>>, BJAPNCFOIGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly OBBNCDCMLPA AMNBNLKEKMF;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0xE94AB0", Offset = "0xE93CB0", VA = "0x180E94AB0")]
	public LJKNLPHNICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xE94A80", Offset = "0xE93C80", VA = "0x180E94A80")]
	public LJKNLPHNICM(OBBNCDCMLPA AMNBNLKEKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xE94420", Offset = "0xE93620", VA = "0x180E94420", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, List<T> ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0xE93790", Offset = "0xE92990", VA = "0x180E93790", Slot = "5")]
	public List<T> LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class FJEJMCEIBBI<TElement, TIntermediate, TEnumerator, TCollection> : global::MODEKCAJGJD<TCollection>, BJAPNCFOIGD where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x4852A00", Offset = "0x4851C00", VA = "0x184852A00", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, TCollection ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x48523F0", Offset = "0x48515F0", VA = "0x1848523F0", Slot = "5")]
	public TCollection LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator OJOLBKEGLKF(TCollection FKKKHANKMEH);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate CNOGLGNGFED();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void KAGEPJABGKM(ref TIntermediate EJINPPBIFPK, int MJNAIOAAGCG, TElement ADBNEBBHMOP);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection EBIMOMABEEF(ref TIntermediate JLBGPIODLKC);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
	protected FJEJMCEIBBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class MABGGADANFA<TElement, TIntermediate, TCollection> : global::FJEJMCEIBBI<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB130", Offset = "0x1CCA330", VA = "0x181CCB130", Slot = "6")]
	protected override IEnumerator<TElement> OJOLBKEGLKF(TCollection FKKKHANKMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x12085B0", Offset = "0x12077B0", VA = "0x1812085B0")]
	protected MABGGADANFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class DNJHJMGNBHB<TElement, TCollection> : global::MABGGADANFA<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xAC96E0", Offset = "0xAC88E0", VA = "0x180AC96E0", Slot = "9")]
	protected sealed override TCollection EBIMOMABEEF(ref TCollection JLBGPIODLKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class BLJEDIHCODD<TElement, TCollection> : global::DNJHJMGNBHB<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0xE8BA50", Offset = "0xE8AC50", VA = "0x180E8BA50", Slot = "7")]
	protected override TCollection CNOGLGNGFED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x42055F0", Offset = "0x42047F0", VA = "0x1842055F0", Slot = "8")]
	protected override void KAGEPJABGKM(ref TCollection EJINPPBIFPK, int MJNAIOAAGCG, TElement ADBNEBBHMOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class MKPEKCHIABE<T> : global::FJEJMCEIBBI<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x16034C0", Offset = "0x16026C0", VA = "0x1816034C0", Slot = "8")]
	protected override void KAGEPJABGKM(ref LinkedList<T> EJINPPBIFPK, int MJNAIOAAGCG, T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xAC96E0", Offset = "0xAC88E0", VA = "0x180AC96E0", Slot = "9")]
	protected override LinkedList<T> EBIMOMABEEF(ref LinkedList<T> JLBGPIODLKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0xE8A7C0", Offset = "0xE899C0", VA = "0x180E8A7C0", Slot = "7")]
	protected override LinkedList<T> CNOGLGNGFED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x1C94B70", Offset = "0x1C93D70", VA = "0x181C94B70", Slot = "6")]
	protected override LinkedList<T>.Enumerator OJOLBKEGLKF(LinkedList<T> FKKKHANKMEH)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class GIMKNCJAJAB<T> : global::FJEJMCEIBBI<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x16034C0", Offset = "0x16026C0", VA = "0x1816034C0", Slot = "8")]
	protected override void KAGEPJABGKM(ref Queue<T> EJINPPBIFPK, int MJNAIOAAGCG, T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0xE8A7C0", Offset = "0xE899C0", VA = "0x180E8A7C0", Slot = "7")]
	protected override Queue<T> CNOGLGNGFED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x21A8C90", Offset = "0x21A7E90", VA = "0x1821A8C90", Slot = "6")]
	protected override Queue<T>.Enumerator OJOLBKEGLKF(Queue<T> FKKKHANKMEH)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0xAC96E0", Offset = "0xAC88E0", VA = "0x180AC96E0", Slot = "9")]
	protected override Queue<T> EBIMOMABEEF(ref Queue<T> JLBGPIODLKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class LDLFDBJEBOL<T> : global::FJEJMCEIBBI<T, global::NMJMNKCAHHL<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x16AA560", Offset = "0x16A9760", VA = "0x1816AA560", Slot = "8")]
	protected override void KAGEPJABGKM(ref global::NMJMNKCAHHL<T> EJINPPBIFPK, int MJNAIOAAGCG, T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x16AA4F0", Offset = "0x16A96F0", VA = "0x1816AA4F0", Slot = "7")]
	protected override global::NMJMNKCAHHL<T> CNOGLGNGFED()
	{
		return default(global::NMJMNKCAHHL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x21A8C90", Offset = "0x21A7E90", VA = "0x1821A8C90", Slot = "6")]
	protected override Stack<T>.Enumerator OJOLBKEGLKF(Stack<T> FKKKHANKMEH)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x21A8BB0", Offset = "0x21A7DB0", VA = "0x1821A8BB0", Slot = "9")]
	protected override Stack<T> EBIMOMABEEF(ref global::NMJMNKCAHHL<T> JLBGPIODLKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class FFCGCNODGEE<T> : global::FJEJMCEIBBI<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x16034C0", Offset = "0x16026C0", VA = "0x1816034C0", Slot = "8")]
	protected override void KAGEPJABGKM(ref HashSet<T> EJINPPBIFPK, int MJNAIOAAGCG, T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xAC96E0", Offset = "0xAC88E0", VA = "0x180AC96E0", Slot = "9")]
	protected override HashSet<T> EBIMOMABEEF(ref HashSet<T> JLBGPIODLKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0xE8A7C0", Offset = "0xE899C0", VA = "0x180E8A7C0", Slot = "7")]
	protected override HashSet<T> CNOGLGNGFED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x21A8C90", Offset = "0x21A7E90", VA = "0x1821A8C90", Slot = "6")]
	protected override HashSet<T>.Enumerator OJOLBKEGLKF(HashSet<T> FKKKHANKMEH)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class CEHFAOPKEEG<T> : global::MABGGADANFA<T, global::NMJMNKCAHHL<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x16AA560", Offset = "0x16A9760", VA = "0x1816AA560", Slot = "8")]
	protected override void KAGEPJABGKM(ref global::NMJMNKCAHHL<T> EJINPPBIFPK, int MJNAIOAAGCG, T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x4209FE0", Offset = "0x42091E0", VA = "0x184209FE0", Slot = "9")]
	protected override ReadOnlyCollection<T> EBIMOMABEEF(ref global::NMJMNKCAHHL<T> JLBGPIODLKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x4209F90", Offset = "0x4209190", VA = "0x184209F90", Slot = "7")]
	protected override global::NMJMNKCAHHL<T> CNOGLGNGFED()
	{
		return default(global::NMJMNKCAHHL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class MPLPGOOCKGB<T> : global::MABGGADANFA<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x16034C0", Offset = "0x16026C0", VA = "0x1816034C0", Slot = "8")]
	protected override void KAGEPJABGKM(ref List<T> EJINPPBIFPK, int MJNAIOAAGCG, T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0xE8A7C0", Offset = "0xE899C0", VA = "0x180E8A7C0", Slot = "7")]
	protected override List<T> CNOGLGNGFED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xAC96E0", Offset = "0xAC88E0", VA = "0x180AC96E0", Slot = "9")]
	protected override IList<T> EBIMOMABEEF(ref List<T> JLBGPIODLKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class BFHJDOEAGHO<T> : global::MABGGADANFA<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x16034C0", Offset = "0x16026C0", VA = "0x1816034C0", Slot = "8")]
	protected override void KAGEPJABGKM(ref List<T> EJINPPBIFPK, int MJNAIOAAGCG, T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0xE8A7C0", Offset = "0xE899C0", VA = "0x180E8A7C0", Slot = "7")]
	protected override List<T> CNOGLGNGFED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xAC96E0", Offset = "0xAC88E0", VA = "0x180AC96E0", Slot = "9")]
	protected override ICollection<T> EBIMOMABEEF(ref List<T> JLBGPIODLKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class IIMGDGINCHN<T> : global::MABGGADANFA<T, global::NMJMNKCAHHL<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x16AA560", Offset = "0x16A9760", VA = "0x1816AA560", Slot = "8")]
	protected override void KAGEPJABGKM(ref global::NMJMNKCAHHL<T> EJINPPBIFPK, int MJNAIOAAGCG, T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x16AA4F0", Offset = "0x16A96F0", VA = "0x1816AA4F0", Slot = "7")]
	protected override global::NMJMNKCAHHL<T> CNOGLGNGFED()
	{
		return default(global::NMJMNKCAHHL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x16AA540", Offset = "0x16A9740", VA = "0x1816AA540", Slot = "9")]
	protected override IEnumerable<T> EBIMOMABEEF(ref global::NMJMNKCAHHL<T> JLBGPIODLKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class PGDDDJLKDKO<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class DCGNLMHAEDF<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class PKOMLJGCEJG<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class LBJHGODPECN : global::MODEKCAJGJD<IEnumerable>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::MODEKCAJGJD<IEnumerable> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1331B80", Offset = "0x1330D80", VA = "0x181331B80", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, IEnumerable ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x1331A00", Offset = "0x1330C00", VA = "0x181331A00", Slot = "5")]
	public IEnumerable LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public LBJHGODPECN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class NJBFJBNGDPE : global::MODEKCAJGJD<ICollection>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::MODEKCAJGJD<ICollection> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x22F5530", Offset = "0x22F4730", VA = "0x1822F5530", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, ICollection ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x22F5340", Offset = "0x22F4540", VA = "0x1822F5340", Slot = "5")]
	public ICollection LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public NJBFJBNGDPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class NKKLMAKAOIN : global::MODEKCAJGJD<IList>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::MODEKCAJGJD<IList> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x22F5B90", Offset = "0x22F4D90", VA = "0x1822F5B90", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, IList ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x22F59A0", Offset = "0x22F4BA0", VA = "0x1822F59A0", Slot = "5")]
	public IList LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public NKKLMAKAOIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class GPBLFMCJILD<T> : global::MABGGADANFA<T, global::NMJMNKCAHHL<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x44E8B80", Offset = "0x44E7D80", VA = "0x1844E8B80", Slot = "8")]
	protected override void KAGEPJABGKM(ref global::NMJMNKCAHHL<T> EJINPPBIFPK, int MJNAIOAAGCG, T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x16AA4F0", Offset = "0x16A96F0", VA = "0x1816AA4F0", Slot = "7")]
	protected override global::NMJMNKCAHHL<T> CNOGLGNGFED()
	{
		return default(global::NMJMNKCAHHL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x44E8B40", Offset = "0x44E7D40", VA = "0x1844E8B40", Slot = "9")]
	protected override IReadOnlyList<T> EBIMOMABEEF(ref global::NMJMNKCAHHL<T> JLBGPIODLKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x394DAA0", Offset = "0x394CCA0", VA = "0x18394DAA0")]
	public GPBLFMCJILD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class HIOALBGMLPG
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1724F00", Offset = "0x1724100", VA = "0x181724F00")]
	public static DateTime EFKGMGDOBOD(DateTime GJMLEOIELEF)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class OMBBOKEBDFB : global::MODEKCAJGJD<DateTime>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::MODEKCAJGJD<DateTime> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x22F7E20", Offset = "0x22F7020", VA = "0x1822F7E20", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, DateTime ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x22F6FE0", Offset = "0x22F61E0", VA = "0x1822F6FE0", Slot = "5")]
	public DateTime LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public OMBBOKEBDFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class GOEGCEEBDIJ : global::MODEKCAJGJD<DateTimeOffset>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::MODEKCAJGJD<DateTimeOffset> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x171FF70", Offset = "0x171F170", VA = "0x18171FF70", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, DateTimeOffset ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x171EFD0", Offset = "0x171E1D0", VA = "0x18171EFD0", Slot = "5")]
	public DateTimeOffset LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public GOEGCEEBDIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class ILHFCDJMHIO : global::MODEKCAJGJD<TimeSpan>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::MODEKCAJGJD<TimeSpan> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] JNOHPIIKLLC;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x1325F20", Offset = "0x1325120", VA = "0x181325F20", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, TimeSpan ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x13255C0", Offset = "0x13247C0", VA = "0x1813255C0", Slot = "5")]
	public TimeSpan LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public ILHFCDJMHIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class EICFICDNICA<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::MODEKCAJGJD<TDictionary>, BJAPNCFOIGD where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x4E43760", Offset = "0x4E42960", VA = "0x184E43760", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, TDictionary ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x4E42DC0", Offset = "0x4E41FC0", VA = "0x184E42DC0", Slot = "5")]
	public TDictionary LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator OJOLBKEGLKF(TDictionary FKKKHANKMEH);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate CNOGLGNGFED();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void KAGEPJABGKM(ref TIntermediate EJINPPBIFPK, int MJNAIOAAGCG, TKey JCNAPFOCJDI, TValue ADBNEBBHMOP);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary EBIMOMABEEF(ref TIntermediate JLBGPIODLKC);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
	protected EICFICDNICA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class FJAIPFBPMPP<TKey, TValue, TIntermediate, TDictionary> : global::EICFICDNICA<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB130", Offset = "0x1CCA330", VA = "0x181CCB130", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> OJOLBKEGLKF(TDictionary FKKKHANKMEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class ACMFLBEFIHD<TKey, TValue, TDictionary> : global::FJAIPFBPMPP<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xAC96E0", Offset = "0xAC88E0", VA = "0x180AC96E0", Slot = "9")]
	protected override TDictionary EBIMOMABEEF(ref TDictionary JLBGPIODLKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class LDHIPFGBBEF<TKey, TValue> : global::EICFICDNICA<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x21A8B20", Offset = "0x21A7D20", VA = "0x1821A8B20", Slot = "8")]
	protected override void KAGEPJABGKM(ref Dictionary<TKey, TValue> EJINPPBIFPK, int MJNAIOAAGCG, TKey JCNAPFOCJDI, TValue ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xAC96E0", Offset = "0xAC88E0", VA = "0x180AC96E0", Slot = "9")]
	protected override Dictionary<TKey, TValue> EBIMOMABEEF(ref Dictionary<TKey, TValue> JLBGPIODLKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0xE8A7C0", Offset = "0xE899C0", VA = "0x180E8A7C0", Slot = "7")]
	protected override Dictionary<TKey, TValue> CNOGLGNGFED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x21A8B60", Offset = "0x21A7D60", VA = "0x1821A8B60", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator OJOLBKEGLKF(Dictionary<TKey, TValue> FKKKHANKMEH)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1208F50", Offset = "0x1208150", VA = "0x181208F50")]
	public LDHIPFGBBEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class GLFLHKFOANF<TKey, TValue, TDictionary> : global::ACMFLBEFIHD<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x44E27F0", Offset = "0x44E19F0", VA = "0x1844E27F0", Slot = "8")]
	protected override void KAGEPJABGKM(ref TDictionary EJINPPBIFPK, int MJNAIOAAGCG, TKey JCNAPFOCJDI, TValue ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x44E27D0", Offset = "0x44E19D0", VA = "0x1844E27D0", Slot = "7")]
	protected override TDictionary CNOGLGNGFED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class FKBMNDBLBCF<TKey, TValue> : global::FJAIPFBPMPP<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0xE8A820", Offset = "0xE89A20", VA = "0x180E8A820", Slot = "8")]
	protected override void KAGEPJABGKM(ref Dictionary<TKey, TValue> EJINPPBIFPK, int MJNAIOAAGCG, TKey JCNAPFOCJDI, TValue ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0xE8A7C0", Offset = "0xE899C0", VA = "0x180E8A7C0", Slot = "7")]
	protected override Dictionary<TKey, TValue> CNOGLGNGFED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0xAC96E0", Offset = "0xAC88E0", VA = "0x180AC96E0", Slot = "9")]
	protected override IDictionary<TKey, TValue> EBIMOMABEEF(ref Dictionary<TKey, TValue> JLBGPIODLKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class LEMKFPIFBKO<TKey, TValue> : global::ACMFLBEFIHD<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0xE8A820", Offset = "0xE89A20", VA = "0x180E8A820", Slot = "8")]
	protected override void KAGEPJABGKM(ref SortedList<TKey, TValue> EJINPPBIFPK, int MJNAIOAAGCG, TKey JCNAPFOCJDI, TValue ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0xE8A7C0", Offset = "0xE899C0", VA = "0x180E8A7C0", Slot = "7")]
	protected override SortedList<TKey, TValue> CNOGLGNGFED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class IAKJEPFECOL<TKey, TValue> : global::EICFICDNICA<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0xE8A820", Offset = "0xE89A20", VA = "0x180E8A820", Slot = "8")]
	protected override void KAGEPJABGKM(ref SortedDictionary<TKey, TValue> EJINPPBIFPK, int MJNAIOAAGCG, TKey JCNAPFOCJDI, TValue ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xAC96E0", Offset = "0xAC88E0", VA = "0x180AC96E0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> EBIMOMABEEF(ref SortedDictionary<TKey, TValue> JLBGPIODLKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0xE8A7C0", Offset = "0xE899C0", VA = "0x180E8A7C0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> CNOGLGNGFED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x41135F0", Offset = "0x41127F0", VA = "0x1841135F0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator OJOLBKEGLKF(SortedDictionary<TKey, TValue> FKKKHANKMEH)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class OILHFMKNGKP<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class BCIGIFLOJGK : global::MODEKCAJGJD<IDictionary>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::MODEKCAJGJD<IDictionary> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x1714640", Offset = "0x1713840", VA = "0x181714640", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, IDictionary ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x17144A0", Offset = "0x17136A0", VA = "0x1817144A0", Slot = "5")]
	public IDictionary LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public BCIGIFLOJGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class OOAEMFAFDAC : global::MODEKCAJGJD<object>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void HPCAKBDENBE(object HLGLIPDOBEF, ref CAFFCIDMPIE DJBGEDLHCFF, object ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::KGKOENKGELA<KeyValuePair<object, HPCAKBDENBE>> FBDLHHKBFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly DBIGINEDNCI[] ACEOPPJNCLB;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x22F8FE0", Offset = "0x22F81E0", VA = "0x1822F8FE0")]
	public OOAEMFAFDAC(params DBIGINEDNCI[] ACEOPPJNCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x22F86F0", Offset = "0x22F78F0", VA = "0x1822F86F0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, object ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x22F8660", Offset = "0x22F7860", VA = "0x1822F8660", Slot = "5")]
	public object LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class HAOBEPJONBE
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x1724370", Offset = "0x1723570", VA = "0x181724370")]
	public static object PKGGJCKGBIB(Type BGMCKNGNOJI, out bool MBANALFAODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x1723B90", Offset = "0x1722D90", VA = "0x181723B90")]
	public static object JKACFELNFDP(Type BGMCKNGNOJI, out bool MBANALFAODC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class JJLGNGJFOMC<T> : global::MODEKCAJGJD<T>, BJAPNCFOIGD, global::KONLGLPFDLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class CBJAEJHNCLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public CBJAEJHNCLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x1F08440", Offset = "0x1F07640", VA = "0x181F08440")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class CJLGPLLNKLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::LECIONILDOG<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public CJLGPLLNKLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x1F0A110", Offset = "0x1F09310", VA = "0x181F0A110")]
		internal void <.cctor>b__1(ref CAFFCIDMPIE writer, T value, DBIGINEDNCI _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class IMOPHPMLOED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::GNNMCEJNHFM<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public IMOPHPMLOED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x1F0BBD0", Offset = "0x1F0ADD0", VA = "0x181F0BBD0")]
		internal T <.cctor>b__2(ref MMPHHENFHIN reader, DBIGINEDNCI _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::KOBABDPFBCC<T> OPCMMGPGJFJ;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> HMLFPNKFOHC;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::LECIONILDOG<T> IEIOGEIPMIK;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::GNNMCEJNHFM<T> AKIHFIJBEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool BGNCLBENJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::LECIONILDOG<T> OOIIOFPLJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::GNNMCEJNHFM<T> IMHMELAALJJ;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x1F19F00", Offset = "0x1F19100", VA = "0x181F19F00")]
	static JJLGNGJFOMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x1F212F0", Offset = "0x1F204F0", VA = "0x181F212F0")]
	public JJLGNGJFOMC(bool BGNCLBENJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x1F14240", Offset = "0x1F13440", VA = "0x181F14240", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, T ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x1F12B20", Offset = "0x1F11D20", VA = "0x181F12B20", Slot = "5")]
	public T LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x1F108F0", Offset = "0x1F0FAF0", VA = "0x181F108F0", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, T ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x1F10EB0", Offset = "0x1F100B0", VA = "0x181F10EB0", Slot = "7")]
	public T KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class MELNPGDALND<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class CMNBNINJBKL<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class LEBELDCOJHI<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class HHNDKKALIKJ<T> : global::MODEKCAJGJD<T?>, BJAPNCFOIGD where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x39F7390", Offset = "0x39F6590", VA = "0x1839F7390", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, T? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x39F6F60", Offset = "0x39F6160", VA = "0x1839F6F60", Slot = "5")]
	public T? LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
	public HHNDKKALIKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class KJELGGKNDBP<T> : global::MODEKCAJGJD<T?>, BJAPNCFOIGD where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::MODEKCAJGJD<T> IMNNNGLBDIE;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x1343700", Offset = "0x1342900", VA = "0x181343700")]
	public KJELGGKNDBP(global::MODEKCAJGJD<T> IMNNNGLBDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x1344F70", Offset = "0x1344170", VA = "0x181344F70", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, T? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x1343F90", Offset = "0x1343190", VA = "0x181343F90", Slot = "5")]
	public T? LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class EEFGEFBCCIN : global::MODEKCAJGJD<sbyte>, BJAPNCFOIGD, global::KONLGLPFDLG<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly EEFGEFBCCIN HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x171B410", Offset = "0x171A610", VA = "0x18171B410", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, sbyte ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x171B400", Offset = "0x171A600", VA = "0x18171B400", Slot = "5")]
	public sbyte LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x171B2D0", Offset = "0x171A4D0", VA = "0x18171B2D0", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, sbyte ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x171B390", Offset = "0x171A590", VA = "0x18171B390", Slot = "7")]
	public sbyte KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public EEFGEFBCCIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class MFLPJOIAOAI : global::MODEKCAJGJD<sbyte?>, BJAPNCFOIGD, global::KONLGLPFDLG<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly MFLPJOIAOAI HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x22F10F0", Offset = "0x22F02F0", VA = "0x1822F10F0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, sbyte? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x22F1040", Offset = "0x22F0240", VA = "0x1822F1040", Slot = "5")]
	public sbyte? LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x22F0EE0", Offset = "0x22F00E0", VA = "0x1822F0EE0", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, sbyte? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x22F0F60", Offset = "0x22F0160", VA = "0x1822F0F60", Slot = "7")]
	public sbyte? KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public MFLPJOIAOAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class OPKKGJIDBHL : global::MODEKCAJGJD<sbyte[]>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly OPKKGJIDBHL HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x22F9220", Offset = "0x22F8420", VA = "0x1822F9220", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, sbyte[] ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x22F9080", Offset = "0x22F8280", VA = "0x1822F9080", Slot = "5")]
	public sbyte[] LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public OPKKGJIDBHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class CJBHIENHBLP : global::MODEKCAJGJD<short>, BJAPNCFOIGD, global::KONLGLPFDLG<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly CJBHIENHBLP HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x1716E40", Offset = "0x1716040", VA = "0x181716E40", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, short ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x1716E30", Offset = "0x1716030", VA = "0x181716E30", Slot = "5")]
	public short LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x1716D00", Offset = "0x1715F00", VA = "0x181716D00", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, short ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x1716DC0", Offset = "0x1715FC0", VA = "0x181716DC0", Slot = "7")]
	public short KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public CJBHIENHBLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class EBFHGLAOEJM : global::MODEKCAJGJD<short?>, BJAPNCFOIGD, global::KONLGLPFDLG<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly EBFHGLAOEJM HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x171AF10", Offset = "0x171A110", VA = "0x18171AF10", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, short? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x171AEA0", Offset = "0x171A0A0", VA = "0x18171AEA0", Slot = "5")]
	public short? LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x171AD00", Offset = "0x1719F00", VA = "0x18171AD00", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, short? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x171AE00", Offset = "0x171A000", VA = "0x18171AE00", Slot = "7")]
	public short? KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public EBFHGLAOEJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class AAHINMGPGLO : global::MODEKCAJGJD<short[]>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly AAHINMGPGLO HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x17100B0", Offset = "0x170F2B0", VA = "0x1817100B0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, short[] ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x170FF70", Offset = "0x170F170", VA = "0x18170FF70", Slot = "5")]
	public short[] LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public AAHINMGPGLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class AFJPCIMNPJC : global::MODEKCAJGJD<int>, BJAPNCFOIGD, global::KONLGLPFDLG<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly AFJPCIMNPJC HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x1710F20", Offset = "0x1710120", VA = "0x181710F20", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, int ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x1710F10", Offset = "0x1710110", VA = "0x181710F10", Slot = "5")]
	public int LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x1710DE0", Offset = "0x170FFE0", VA = "0x181710DE0", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, int ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x1710EA0", Offset = "0x17100A0", VA = "0x181710EA0", Slot = "7")]
	public int KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public AFJPCIMNPJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class LIAILIDBKJK : global::MODEKCAJGJD<int?>, BJAPNCFOIGD, global::KONLGLPFDLG<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly LIAILIDBKJK HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x1331F60", Offset = "0x1331160", VA = "0x181331F60", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, int? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x1331EF0", Offset = "0x13310F0", VA = "0x181331EF0", Slot = "5")]
	public int? LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x1331DD0", Offset = "0x1330FD0", VA = "0x181331DD0", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, int? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x1331E50", Offset = "0x1331050", VA = "0x181331E50", Slot = "7")]
	public int? KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public LIAILIDBKJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class KMIPKJAKFBC : global::MODEKCAJGJD<int[]>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly KMIPKJAKFBC HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x1331250", Offset = "0x1330450", VA = "0x181331250", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, int[] ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x1331110", Offset = "0x1330310", VA = "0x181331110", Slot = "5")]
	public int[] LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public KMIPKJAKFBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class HOIPCODGJJG : global::MODEKCAJGJD<long>, BJAPNCFOIGD, global::KONLGLPFDLG<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly HOIPCODGJJG HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x1726610", Offset = "0x1725810", VA = "0x181726610", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, long ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x1726600", Offset = "0x1725800", VA = "0x181726600", Slot = "5")]
	public long LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x17264D0", Offset = "0x17256D0", VA = "0x1817264D0", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, long ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x1726590", Offset = "0x1725790", VA = "0x181726590", Slot = "7")]
	public long KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public HOIPCODGJJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class PILEHLHPHGE : global::MODEKCAJGJD<long?>, BJAPNCFOIGD, global::KONLGLPFDLG<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly PILEHLHPHGE HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x22F9760", Offset = "0x22F8960", VA = "0x1822F9760", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, long? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x22F96D0", Offset = "0x22F88D0", VA = "0x1822F96D0", Slot = "5")]
	public long? LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x22F9590", Offset = "0x22F8790", VA = "0x1822F9590", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, long? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x22F9610", Offset = "0x22F8810", VA = "0x1822F9610", Slot = "7")]
	public long? KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public PILEHLHPHGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class IDCFCDOOPLO : global::MODEKCAJGJD<long[]>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly IDCFCDOOPLO HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x1727120", Offset = "0x1726320", VA = "0x181727120", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, long[] ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x1726FE0", Offset = "0x17261E0", VA = "0x181726FE0", Slot = "5")]
	public long[] LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public IDCFCDOOPLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class AMBFNOGPLBP : global::MODEKCAJGJD<byte>, BJAPNCFOIGD, global::KONLGLPFDLG<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly AMBFNOGPLBP HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x1712090", Offset = "0x1711290", VA = "0x181712090", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, byte ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x1712080", Offset = "0x1711280", VA = "0x181712080", Slot = "5")]
	public byte LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x1711F50", Offset = "0x1711150", VA = "0x181711F50", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, byte ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x1712010", Offset = "0x1711210", VA = "0x181712010", Slot = "7")]
	public byte KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public AMBFNOGPLBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class ANKCMAMOJPB : global::MODEKCAJGJD<byte?>, BJAPNCFOIGD, global::KONLGLPFDLG<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly ANKCMAMOJPB HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x17124D0", Offset = "0x17116D0", VA = "0x1817124D0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, byte? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x1712460", Offset = "0x1711660", VA = "0x181712460", Slot = "5")]
	public byte? LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x17122B0", Offset = "0x17114B0", VA = "0x1817122B0", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, byte? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x17123B0", Offset = "0x17115B0", VA = "0x1817123B0", Slot = "7")]
	public byte? KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public ANKCMAMOJPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class MBPMAHOKPJG : global::MODEKCAJGJD<ushort>, BJAPNCFOIGD, global::KONLGLPFDLG<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly MBPMAHOKPJG HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x22F07C0", Offset = "0x22EF9C0", VA = "0x1822F07C0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, ushort ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x22F0760", Offset = "0x22EF960", VA = "0x1822F0760", Slot = "5")]
	public ushort LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x22F0680", Offset = "0x22EF880", VA = "0x1822F0680", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, ushort ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x22F06C0", Offset = "0x22EF8C0", VA = "0x1822F06C0", Slot = "7")]
	public ushort KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public MBPMAHOKPJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class DEJOJNCCGMD : global::MODEKCAJGJD<ushort?>, BJAPNCFOIGD, global::KONLGLPFDLG<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly DEJOJNCCGMD HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x17195D0", Offset = "0x17187D0", VA = "0x1817195D0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, ushort? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x1719560", Offset = "0x1718760", VA = "0x181719560", Slot = "5")]
	public ushort? LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x17193C0", Offset = "0x17185C0", VA = "0x1817193C0", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, ushort? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x17194C0", Offset = "0x17186C0", VA = "0x1817194C0", Slot = "7")]
	public ushort? KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public DEJOJNCCGMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class EJNMKBCKKOF : global::MODEKCAJGJD<ushort[]>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly EJNMKBCKKOF HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x171B820", Offset = "0x171AA20", VA = "0x18171B820", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, ushort[] ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x171B6E0", Offset = "0x171A8E0", VA = "0x18171B6E0", Slot = "5")]
	public ushort[] LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public EJNMKBCKKOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class DILOLIBLPCA : global::MODEKCAJGJD<uint>, BJAPNCFOIGD, global::KONLGLPFDLG<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly DILOLIBLPCA HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x17198C0", Offset = "0x1718AC0", VA = "0x1817198C0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, uint ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x17198B0", Offset = "0x1718AB0", VA = "0x1817198B0", Slot = "5")]
	public uint LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x1719780", Offset = "0x1718980", VA = "0x181719780", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, uint ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x1719840", Offset = "0x1718A40", VA = "0x181719840", Slot = "7")]
	public uint KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public DILOLIBLPCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class AIINFNNOCNC : global::MODEKCAJGJD<uint?>, BJAPNCFOIGD, global::KONLGLPFDLG<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly AIINFNNOCNC HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1711B40", Offset = "0x1710D40", VA = "0x181711B40", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, uint? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x1711AD0", Offset = "0x1710CD0", VA = "0x181711AD0", Slot = "5")]
	public uint? LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x1711930", Offset = "0x1710B30", VA = "0x181711930", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, uint? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x1711A30", Offset = "0x1710C30", VA = "0x181711A30", Slot = "7")]
	public uint? KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public AIINFNNOCNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class FKJILFEEMCM : global::MODEKCAJGJD<uint[]>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly FKJILFEEMCM HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x171CCE0", Offset = "0x171BEE0", VA = "0x18171CCE0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, uint[] ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x171CBA0", Offset = "0x171BDA0", VA = "0x18171CBA0", Slot = "5")]
	public uint[] LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public FKJILFEEMCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class PNLAKCAENHK : global::MODEKCAJGJD<ulong>, BJAPNCFOIGD, global::KONLGLPFDLG<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly PNLAKCAENHK HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x22F98F0", Offset = "0x22F8AF0", VA = "0x1822F98F0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, ulong ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x22F98E0", Offset = "0x22F8AE0", VA = "0x1822F98E0", Slot = "5")]
	public ulong LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x22F9830", Offset = "0x22F8A30", VA = "0x1822F9830", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, ulong ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x22F9870", Offset = "0x22F8A70", VA = "0x1822F9870", Slot = "7")]
	public ulong KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public PNLAKCAENHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class ALNGPFNFDHF : global::MODEKCAJGJD<ulong?>, BJAPNCFOIGD, global::KONLGLPFDLG<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly ALNGPFNFDHF HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x1711E70", Offset = "0x1711070", VA = "0x181711E70", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, ulong? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x1711DE0", Offset = "0x1710FE0", VA = "0x181711DE0", Slot = "5")]
	public ulong? LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x1711C20", Offset = "0x1710E20", VA = "0x181711C20", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, ulong? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x1711D20", Offset = "0x1710F20", VA = "0x181711D20", Slot = "7")]
	public ulong? KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public ALNGPFNFDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class GKGHJPMBBGF : global::MODEKCAJGJD<ulong[]>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly GKGHJPMBBGF HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x171EBE0", Offset = "0x171DDE0", VA = "0x18171EBE0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, ulong[] ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x171EAA0", Offset = "0x171DCA0", VA = "0x18171EAA0", Slot = "5")]
	public ulong[] LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public GKGHJPMBBGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class CDHHOCOEHDN : global::MODEKCAJGJD<float>, BJAPNCFOIGD, global::KONLGLPFDLG<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly CDHHOCOEHDN HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x1716C90", Offset = "0x1715E90", VA = "0x181716C90", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, float ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x1716C80", Offset = "0x1715E80", VA = "0x181716C80", Slot = "5")]
	public float LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x1716B60", Offset = "0x1715D60", VA = "0x181716B60", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, float ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x1716C10", Offset = "0x1715E10", VA = "0x181716C10", Slot = "7")]
	public float KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public CDHHOCOEHDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class NALJHPKIPFG : global::MODEKCAJGJD<float?>, BJAPNCFOIGD, global::KONLGLPFDLG<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly NALJHPKIPFG HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x22F4930", Offset = "0x22F3B30", VA = "0x1822F4930", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, float? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x22F48C0", Offset = "0x22F3AC0", VA = "0x1822F48C0", Slot = "5")]
	public float? LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x22F4760", Offset = "0x22F3960", VA = "0x1822F4760", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, float? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x22F47E0", Offset = "0x22F39E0", VA = "0x1822F47E0", Slot = "7")]
	public float? KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public NALJHPKIPFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class NLKMCIDKHHL : global::MODEKCAJGJD<float[]>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly NLKMCIDKHHL HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x22F6030", Offset = "0x22F5230", VA = "0x1822F6030", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, float[] ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x22F5E90", Offset = "0x22F5090", VA = "0x1822F5E90", Slot = "5")]
	public float[] LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public NLKMCIDKHHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class IFBGPINDBIE : global::MODEKCAJGJD<double>, BJAPNCFOIGD, global::KONLGLPFDLG<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly IFBGPINDBIE HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x131CDA0", Offset = "0x131BFA0", VA = "0x18131CDA0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, double ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x131CD90", Offset = "0x131BF90", VA = "0x18131CD90", Slot = "5")]
	public double LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x131CCE0", Offset = "0x131BEE0", VA = "0x18131CCE0", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, double ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x131CD20", Offset = "0x131BF20", VA = "0x18131CD20", Slot = "7")]
	public double KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public IFBGPINDBIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class HJEBOPOBELC : global::MODEKCAJGJD<double?>, BJAPNCFOIGD, global::KONLGLPFDLG<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly HJEBOPOBELC HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x17251F0", Offset = "0x17243F0", VA = "0x1817251F0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, double? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x1725160", Offset = "0x1724360", VA = "0x181725160", Slot = "5")]
	public double? LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x1724FA0", Offset = "0x17241A0", VA = "0x181724FA0", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, double? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x17250A0", Offset = "0x17242A0", VA = "0x1817250A0", Slot = "7")]
	public double? KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public HJEBOPOBELC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class FMPFOJNPAEM : global::MODEKCAJGJD<double[]>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly FMPFOJNPAEM HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x171D020", Offset = "0x171C220", VA = "0x18171D020", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, double[] ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x171CEE0", Offset = "0x171C0E0", VA = "0x18171CEE0", Slot = "5")]
	public double[] LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public FMPFOJNPAEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class FADHMELJJEP : global::MODEKCAJGJD<bool>, BJAPNCFOIGD, global::KONLGLPFDLG<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly FADHMELJJEP HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x171C8F0", Offset = "0x171BAF0", VA = "0x18171C8F0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, bool ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x171C8E0", Offset = "0x171BAE0", VA = "0x18171C8E0", Slot = "5")]
	public bool LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x171C7C0", Offset = "0x171B9C0", VA = "0x18171C7C0", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, bool ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x171C870", Offset = "0x171BA70", VA = "0x18171C870", Slot = "7")]
	public bool KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public FADHMELJJEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class EBMBFMJDFLD : global::MODEKCAJGJD<bool?>, BJAPNCFOIGD, global::KONLGLPFDLG<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly EBMBFMJDFLD HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x171B200", Offset = "0x171A400", VA = "0x18171B200", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, bool? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x171B190", Offset = "0x171A390", VA = "0x18171B190", Slot = "5")]
	public bool? LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x171AFF0", Offset = "0x171A1F0", VA = "0x18171AFF0", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, bool? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x171B0E0", Offset = "0x171A2E0", VA = "0x18171B0E0", Slot = "7")]
	public bool? KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public EBMBFMJDFLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class GGOBOJPMHJE : global::MODEKCAJGJD<bool[]>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly GGOBOJPMHJE HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x171E780", Offset = "0x171D980", VA = "0x18171E780", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, bool[] ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x171E640", Offset = "0x171D840", VA = "0x18171E640", Slot = "5")]
	public bool[] LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public GGOBOJPMHJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class HKOJOBNKBJK : global::MODEKCAJGJD<object>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::MODEKCAJGJD<object> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> LGKEKJDOOJN;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x1725560", Offset = "0x1724760", VA = "0x181725560", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, object ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x17252C0", Offset = "0x17244C0", VA = "0x1817252C0", Slot = "5")]
	public object LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public HKOJOBNKBJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class NKIMLMCOMFG : global::MODEKCAJGJD<byte[]>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::MODEKCAJGJD<byte[]> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x22F58B0", Offset = "0x22F4AB0", VA = "0x1822F58B0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, byte[] ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x22F5830", Offset = "0x22F4A30", VA = "0x1822F5830", Slot = "5")]
	public byte[] LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public NKIMLMCOMFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class IBKEBEGIANP : global::MODEKCAJGJD<ArraySegment<byte>>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::MODEKCAJGJD<ArraySegment<byte>> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1726770", Offset = "0x1725970", VA = "0x181726770", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, ArraySegment<byte> ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x17266A0", Offset = "0x17258A0", VA = "0x1817266A0", Slot = "5")]
	public ArraySegment<byte> LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public IBKEBEGIANP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class MBNMLKFONMF : global::MODEKCAJGJD<string>, BJAPNCFOIGD, global::KONLGLPFDLG<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::MODEKCAJGJD<string> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x22F05F0", Offset = "0x22EF7F0", VA = "0x1822F05F0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, string ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x22F0610", Offset = "0x22EF810", VA = "0x1822F0610", Slot = "5")]
	public string LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x22F05F0", Offset = "0x22EF7F0", VA = "0x1822F05F0", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, string ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x22F0610", Offset = "0x22EF810", VA = "0x1822F0610", Slot = "7")]
	public string KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public MBNMLKFONMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class JLMCFAPMPJM : global::MODEKCAJGJD<string[]>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly JLMCFAPMPJM HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x132B1B0", Offset = "0x132A3B0", VA = "0x18132B1B0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, string[] ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x132B070", Offset = "0x132A270", VA = "0x18132B070", Slot = "5")]
	public string[] LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public JLMCFAPMPJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class KNKJIDCFPOA : global::MODEKCAJGJD<char>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly KNKJIDCFPOA HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x13318C0", Offset = "0x1330AC0", VA = "0x1813318C0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, char ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x1331890", Offset = "0x1330A90", VA = "0x181331890", Slot = "5")]
	public char LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public KNKJIDCFPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class AFNGEJFBDJH : global::MODEKCAJGJD<char?>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly AFNGEJFBDJH HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x1711070", Offset = "0x1710270", VA = "0x181711070", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, char? ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x1710FB0", Offset = "0x17101B0", VA = "0x181710FB0", Slot = "5")]
	public char? LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public AFNGEJFBDJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class DCIDBDGNCNN : global::MODEKCAJGJD<char[]>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly DCIDBDGNCNN HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x17175D0", Offset = "0x17167D0", VA = "0x1817175D0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, char[] ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x1717430", Offset = "0x1716630", VA = "0x181717430", Slot = "5")]
	public char[] LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public DCIDBDGNCNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class JGCGGOCGGEA : global::MODEKCAJGJD<Guid>, BJAPNCFOIGD, global::KONLGLPFDLG<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::MODEKCAJGJD<Guid> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x1328D00", Offset = "0x1327F00", VA = "0x181328D00", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, Guid ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x1328CA0", Offset = "0x1327EA0", VA = "0x181328CA0", Slot = "5")]
	public Guid LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x1328BC0", Offset = "0x1327DC0", VA = "0x181328BC0", Slot = "6")]
	public void ABHPLNNKCPJ(ref CAFFCIDMPIE DJBGEDLHCFF, Guid ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x1328CA0", Offset = "0x1327EA0", VA = "0x181328CA0", Slot = "7")]
	public Guid KDBNEJFPLKC(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public JGCGGOCGGEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class JKNGAMPNDAN : global::MODEKCAJGJD<decimal>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::MODEKCAJGJD<decimal> HPMHEACECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool ELPLJCKBFOL;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xA382B0", Offset = "0xA374B0", VA = "0x180A382B0")]
	public JKNGAMPNDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xA38280", Offset = "0xA37480", VA = "0x180A38280")]
	public JKNGAMPNDAN(bool ELPLJCKBFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x13294A0", Offset = "0x13286A0", VA = "0x1813294A0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, decimal ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x13292F0", Offset = "0x13284F0", VA = "0x1813292F0", Slot = "5")]
	public decimal LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class COPHMPBGLNK : global::MODEKCAJGJD<Uri>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::MODEKCAJGJD<Uri> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1717320", Offset = "0x1716520", VA = "0x181717320", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, Uri ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x17172A0", Offset = "0x17164A0", VA = "0x1817172A0", Slot = "5")]
	public Uri LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public COPHMPBGLNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class JJBMJDNJLBG : global::MODEKCAJGJD<Version>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::MODEKCAJGJD<Version> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x13290B0", Offset = "0x13282B0", VA = "0x1813290B0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, Version ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x1329030", Offset = "0x1328230", VA = "0x181329030", Slot = "5")]
	public Version LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public JJBMJDNJLBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class NAGNFJOHPOD<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class EOMCDPPLHBE : global::MODEKCAJGJD<StringBuilder>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::MODEKCAJGJD<StringBuilder> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x171C710", Offset = "0x171B910", VA = "0x18171C710", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, StringBuilder ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x171C690", Offset = "0x171B890", VA = "0x18171C690", Slot = "5")]
	public StringBuilder LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public EOMCDPPLHBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class JICNJAMBBLB : global::MODEKCAJGJD<BitArray>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::MODEKCAJGJD<BitArray> HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x1328F40", Offset = "0x1328140", VA = "0x181328F40", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, BitArray ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x1328E40", Offset = "0x1328040", VA = "0x181328E40", Slot = "5")]
	public BitArray LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public JICNJAMBBLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class ACNIGPAEBDO : global::MODEKCAJGJD<Type>, BJAPNCFOIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly ACNIGPAEBDO HPMHEACECHL;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex IGOPHIHKGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool FDPBCMHGJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool DLPPAPPJOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool LPLICDEEFJD;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x1710930", Offset = "0x170FB30", VA = "0x181710930")]
	public ACNIGPAEBDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x1710950", Offset = "0x170FB50", VA = "0x181710950")]
	public ACNIGPAEBDO(bool FDPBCMHGJNN, bool DLPPAPPJOAA, bool LPLICDEEFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x17107A0", Offset = "0x170F9A0", VA = "0x1817107A0", Slot = "4")]
	public void LIOPAMDCNLD(ref CAFFCIDMPIE DJBGEDLHCFF, Type ADBNEBBHMOP, DBIGINEDNCI GAPPIBEJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x1710680", Offset = "0x170F880", VA = "0x181710680", Slot = "5")]
	public Type LGPKACCHBHO(ref MMPHHENFHIN NCACJOJKKJP, DBIGINEDNCI GAPPIBEJIDG)
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
