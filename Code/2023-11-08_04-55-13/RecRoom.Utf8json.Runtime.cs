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
internal static class DHNBPMJFDOA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6543F20", Offset = "0x6542D20", VA = "0x186543F20")]
	public static bool HPFEKLHENFL(this TypeInfo AOPDMLJGEMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class HOHEMCHKFJH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type GIIPLIJOBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x770F00", Offset = "0x76FD00", VA = "0x180770F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] GBEGIHNAFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x799B60", Offset = "0x798960", VA = "0x180799B60")]
	public HOHEMCHKFJH(Type BNEJPNLPDCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class MACAKIJCEJC : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KHFHGIIPKKK<T>(NDKEFDAFPOB NEGHIHACAHG, T PHPDIJICBJO, CHFBNEPGHDG MLODBIMCFDB);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T GNGBFNIEGKB<T>(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG MLODBIMCFDB);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DNFLPCIHMPE
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LACGAEMAOIL<T> : DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, T PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DOLLIKCIPDC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, T PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum FMEMJCBJONP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OAPPOCFLNKB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x261B980", Offset = "0x261A780", VA = "0x18261B980")]
	public static string IMMIHLJNIAO<T>(this LACGAEMAOIL<T> EJKDLKDNAKK, T PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LACGAEMAOIL<T> CLPOCFNFGOM<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OPOOJLLKDJG
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x263C8A0", Offset = "0x263B6A0", VA = "0x18263C8A0")]
	public static LACGAEMAOIL<T> JLONOMKCDAD<T>(this CHFBNEPGHDG MLODBIMCFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x655A8A0", Offset = "0x65596A0", VA = "0x18655A8A0")]
	public static object PMLCKAICAKG(this CHFBNEPGHDG MLODBIMCFDB, Type AOPDMLJGEMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PEKLHOILAHB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x655AA00", Offset = "0x6559800", VA = "0x18655AA00")]
	public PEKLHOILAHB(string KHIFMDJDLEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct PHKIJIILNBG
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class PNKGDBDLBKN
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] BNFLLCFHIAN;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] EJNOELDELAM;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x655E060", Offset = "0x655CE60", VA = "0x18655E060")]
		public static byte[] DEKINPEKOGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x655E100", Offset = "0x655CF00", VA = "0x18655E100")]
		public static char[] LBNJGBJKAJG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> ICDAJGDCKHM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] KLJPHAEGPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] EHLPPEEOBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int PLIILJHILHI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool EIBDONBNKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x655AFF0", Offset = "0x6559DF0", VA = "0x18655AFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x655DE90", Offset = "0x655CC90", VA = "0x18655DE90")]
	public PHKIJIILNBG(byte[] EHLPPEEOBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x655DD30", Offset = "0x655CB30", VA = "0x18655DD30")]
	public PHKIJIILNBG(byte[] EHLPPEEOBND, int PLIILJHILHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x655B900", Offset = "0x655A700", VA = "0x18655B900")]
	private ANCHADNFDLN HNGFJBMLCPO(string BPMKGPGNAHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x655B3A0", Offset = "0x655A1A0", VA = "0x18655B3A0")]
	private ANCHADNFDLN GPBMHALPOEJ(string KHIFMDJDLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6558760", Offset = "0x6557560", VA = "0x186558760")]
	public void CIEACDCIGDM(int PLIILJHILHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
	public byte[] AFENPJLLBAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB4E0", Offset = "0x1CCA2E0", VA = "0x181CCB4E0")]
	public int BKPIGJDJJCH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x655CF90", Offset = "0x655BD90", VA = "0x18655CF90")]
	public NILLADDIHIH KPLFCBMPKJD()
	{
		return default(NILLADDIHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x655D660", Offset = "0x655C460", VA = "0x18655D660")]
	public void OBFBAJGDLIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x655AE10", Offset = "0x6559C10", VA = "0x18655AE10")]
	public bool CJFIMAFOGCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x655AB80", Offset = "0x6559980", VA = "0x18655AB80")]
	public bool BKFIBGLAMAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x655AA60", Offset = "0x6559860", VA = "0x18655AA60")]
	public void BFOBOLLEJNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x655C450", Offset = "0x655B250", VA = "0x18655C450")]
	public bool KIJMLCFMLIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x655AC10", Offset = "0x6559A10", VA = "0x18655AC10")]
	public bool BPNDAGEKCGL(int PDNIMDHODLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x655C170", Offset = "0x655AF70", VA = "0x18655C170")]
	public bool IPMIHIJHLPP(int PDNIMDHODLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x655B7B0", Offset = "0x655A5B0", VA = "0x18655B7B0")]
	public bool HHOCCLIFAAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x655ACE0", Offset = "0x6559AE0", VA = "0x18655ACE0")]
	public void CBKNEGJKECJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x655DB10", Offset = "0x655C910", VA = "0x18655DB10")]
	public bool PJPAMBEGIMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x655D1B0", Offset = "0x655BFB0", VA = "0x18655D1B0")]
	public bool LHFALIHHJBK(int PDNIMDHODLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x655C0A0", Offset = "0x655AEA0", VA = "0x18655C0A0")]
	public bool IKHFMPPKJEO(int PDNIMDHODLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x655AD80", Offset = "0x6559B80", VA = "0x18655AD80")]
	public bool CEGPFEGMOAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x655DA70", Offset = "0x655C870", VA = "0x18655DA70")]
	public void PJLDJAIDMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x655D470", Offset = "0x655C270", VA = "0x18655D470")]
	public bool NHDFANLJGCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x655D380", Offset = "0x655C180", VA = "0x18655D380")]
	public void MFJBCOGCMLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x655C4E0", Offset = "0x655B2E0", VA = "0x18655C4E0")]
	private void KJJEGFPJPEC([Out] byte[] GABAJNMMHBK, [Out] int CPFNPAKOCBG, [Out] int PAOKOEDFBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x655C3A0", Offset = "0x655B1A0", VA = "0x18655C3A0")]
	private static int KCMAMFOHILL(char ALNGIEPPLJJ, char DCODMCLNKEM, char HOEIFLHBAKH, char JINDDDAPFKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x655D580", Offset = "0x655C380", VA = "0x18655D580")]
	private static int NJEKELBJOLA(char GPMOHKANAAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x655CE70", Offset = "0x655BC70", VA = "0x18655CE70")]
	public ArraySegment<byte> KOPEJIFLGEO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x655D790", Offset = "0x655C590", VA = "0x18655D790")]
	public string ODLHCCPHEPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x655DBA0", Offset = "0x655C9A0", VA = "0x18655DBA0")]
	public string PONDLLKKOPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x655B490", Offset = "0x655A290", VA = "0x18655B490")]
	public ArraySegment<byte> HAKCJHJCOCH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x655D140", Offset = "0x655BF40", VA = "0x18655D140")]
	public ArraySegment<byte> LDCGPGABFEE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x655BE50", Offset = "0x655AC50", VA = "0x18655BE50")]
	public bool HPANLKDJACL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x655B260", Offset = "0x655A060", VA = "0x18655B260")]
	private static bool FFKJOLAIBHE(byte HOEIFLHBAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x655B010", Offset = "0x6559E10", VA = "0x18655B010")]
	private void EHCIKIEBJPJ(NILLADDIHIH HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x655D420", Offset = "0x655C220", VA = "0x18655D420")]
	public void MHGMAGEIEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x655C240", Offset = "0x655B040", VA = "0x18655C240")]
	private void IPPACNFDDAP(int CCAIFFFBDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x655CC80", Offset = "0x655BA80", VA = "0x18655CC80")]
	public sbyte KKLHHKKPIGM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x655D280", Offset = "0x655C080", VA = "0x18655D280")]
	public short MCDMEKGFJOK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x655AB00", Offset = "0x6559900", VA = "0x18655AB00")]
	public int BKCFCNDMABG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x655AF30", Offset = "0x6559D30", VA = "0x18655AF30")]
	public long CPJEBBIFPNJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x655D500", Offset = "0x655C300", VA = "0x18655D500")]
	public byte NJBMOJAGGAJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x655B320", Offset = "0x655A120", VA = "0x18655B320")]
	public ushort FIINLPBHLIF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x655D300", Offset = "0x655C100", VA = "0x18655D300")]
	public uint MEBPEEKLENG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x655B840", Offset = "0x655A640", VA = "0x18655B840")]
	public ulong HJCNNKAGPAG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x655D870", Offset = "0x655C670", VA = "0x18655D870")]
	public float OPFECFHDBFA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x655D970", Offset = "0x655C770", VA = "0x18655D970")]
	public double PAPBJGDENOI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x655B6B0", Offset = "0x655A4B0", VA = "0x18655B6B0")]
	public ArraySegment<byte> HHAMGIHAGIG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x655CD00", Offset = "0x655BB00", VA = "0x18655CD00")]
	private static int KOOKLNKDFII(byte[] EHLPPEEOBND, int PLIILJHILHI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ANCHADNFDLN : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference NBMMHGCDBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int OLFMIPKCOEL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int DBDMPPMEDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB622C0", Offset = "0xB610C0", VA = "0x180B622C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string DLJODAAGNOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F7500", Offset = "0x7F6300", VA = "0x1807F7500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6541750", Offset = "0x6540550", VA = "0x186541750")]
	public ANCHADNFDLN(string KHIFMDJDLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6541660", Offset = "0x6540460", VA = "0x186541660")]
	public ANCHADNFDLN(string KHIFMDJDLEG, byte[] FNHOCOHICBF, int PLIILJHILHI, int OLFMIPKCOEL, string HFJHJEFNHKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class EOHGLDDKGJG
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class HALJPCNFFHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] BNFLLCFHIAN;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x65498C0", Offset = "0x65486C0", VA = "0x1865498C0")]
		public static byte[] DEKINPEKOGH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class GOFGFJKHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void EJHMAEINKMF(NDKEFDAFPOB NEGHIHACAHG, object PHPDIJICBJO, CHFBNEPGHDG MLODBIMCFDB);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object AOCPCKKNFAB(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG MLODBIMCFDB);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class FLJFLDIBAMN
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class ADLDIJLGKGK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
				public ADLDIJLGKGK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x3E2FEF0", Offset = "0x3E2ECF0", VA = "0x183E2FEF0")]
				internal bool JJCLELGIFBG(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x65414A0", Offset = "0x65402A0", VA = "0x1865414A0")]
				internal bool JFHKEDOKNLE(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, CHFBNEPGHDG, byte[]> OPBFLNLPFBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, CHFBNEPGHDG> DNEFLEFMEMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly EJHMAEINKMF LCHMCNEHHFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, CHFBNEPGHDG, ArraySegment<byte>> BDBJHFOLEJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, CHFBNEPGHDG, string> CBMDKJIOGKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, CHFBNEPGHDG, object> IHEJKDBACFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, CHFBNEPGHDG, object> HFKILDALDIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, CHFBNEPGHDG, object> JPJEJHCBFIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly AOCPCKKNFAB BOJGJCKAKJJ;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6546A10", Offset = "0x6545810", VA = "0x186546A10")]
			public FLJFLDIBAMN(Type AOPDMLJGEMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5D70", Offset = "0x2AC4B70", VA = "0x182AC5D70")]
			private static T NPBEEMPCJOD<T>(DynamicMethod PCMPKLPBKOL)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x65467C0", Offset = "0x65455C0", VA = "0x1865467C0")]
			private static MethodInfo CBLFDACLNOJ(Type AOPDMLJGEMB, string NDLLBBKGIJD, Type[] IGMPFJGNMCJ)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, FLJFLDIBAMN> NGHPHFBAKDA;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly BDAINEHBEIF<FLJFLDIBAMN> NFFPJEADEHD;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6549770", Offset = "0x6548570", VA = "0x186549770")]
		static GOFGFJKHAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6549460", Offset = "0x6548260", VA = "0x186549460")]
		private static FLJFLDIBAMN FBOBACIJIMN(Type AOPDMLJGEMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x65494E0", Offset = "0x65482E0", VA = "0x1865494E0")]
		public static void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, object PHPDIJICBJO, CHFBNEPGHDG MLODBIMCFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6549660", Offset = "0x6548460", VA = "0x186549660")]
		public static void OJBJHHLKILJ(Type AOPDMLJGEMB, NDKEFDAFPOB NEGHIHACAHG, object PHPDIJICBJO, CHFBNEPGHDG MLODBIMCFDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static CHFBNEPGHDG MNPAEIJBIDI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] OLBNDDKOPIM;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] MJHICKCODNF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static CHFBNEPGHDG MJHICGBFLHE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6544A90", Offset = "0x6543890", VA = "0x186544A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool LNODLGKLEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x65449C0", Offset = "0x65437C0", VA = "0x1865449C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6544A20", Offset = "0x6543820", VA = "0x186544A20")]
	public static void FKCKBBPIOKE(CHFBNEPGHDG MLODBIMCFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x23B2FC0", Offset = "0x23B1DC0", VA = "0x1823B2FC0")]
	public static byte[] OJBJHHLKILJ<T>(T KANAGAAAGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x23B31B0", Offset = "0x23B1FB0", VA = "0x1823B31B0")]
	public static byte[] OJBJHHLKILJ<T>(T PHPDIJICBJO, CHFBNEPGHDG MLODBIMCFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x23B3330", Offset = "0x23B2130", VA = "0x1823B3330")]
	public static void OJBJHHLKILJ<T>(NDKEFDAFPOB NEGHIHACAHG, T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x23B3040", Offset = "0x23B1E40", VA = "0x1823B3040")]
	public static void OJBJHHLKILJ<T>(NDKEFDAFPOB NEGHIHACAHG, T PHPDIJICBJO, CHFBNEPGHDG MLODBIMCFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x23B3120", Offset = "0x23B1F20", VA = "0x1823B3120")]
	public static void OJBJHHLKILJ<T>(Stream PCDNEJJECMC, T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x23B33C0", Offset = "0x23B21C0", VA = "0x1823B33C0")]
	public static void OJBJHHLKILJ<T>(Stream PCDNEJJECMC, T PHPDIJICBJO, CHFBNEPGHDG MLODBIMCFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x23B16E0", Offset = "0x23B04E0", VA = "0x1823B16E0")]
	public static ArraySegment<byte> HKEHGAPOCCN<T>(T KANAGAAAGHJ)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x23B1770", Offset = "0x23B0570", VA = "0x1823B1770")]
	public static ArraySegment<byte> HKEHGAPOCCN<T>(T PHPDIJICBJO, CHFBNEPGHDG MLODBIMCFDB)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x23B1A80", Offset = "0x23B0880", VA = "0x1823B1A80")]
	public static string IMMIHLJNIAO<T>(T PHPDIJICBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x23B1900", Offset = "0x23B0700", VA = "0x1823B1900")]
	public static string IMMIHLJNIAO<T>(T PHPDIJICBJO, CHFBNEPGHDG MLODBIMCFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x23B24C0", Offset = "0x23B12C0", VA = "0x1823B24C0")]
	public static T LKNPCKIALBL<T>(string IDKBCMAGCGP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x23B2770", Offset = "0x23B1570", VA = "0x1823B2770")]
	public static T LKNPCKIALBL<T>(string IDKBCMAGCGP, CHFBNEPGHDG MLODBIMCFDB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x23B2860", Offset = "0x23B1660", VA = "0x1823B2860")]
	public static T LKNPCKIALBL<T>(byte[] EHLPPEEOBND)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x23B26E0", Offset = "0x23B14E0", VA = "0x1823B26E0")]
	public static T LKNPCKIALBL<T>(byte[] EHLPPEEOBND, CHFBNEPGHDG MLODBIMCFDB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x23B2EB0", Offset = "0x23B1CB0", VA = "0x1823B2EB0")]
	public static T LKNPCKIALBL<T>(byte[] EHLPPEEOBND, int PLIILJHILHI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x23B2550", Offset = "0x23B1350", VA = "0x1823B2550")]
	public static T LKNPCKIALBL<T>(byte[] EHLPPEEOBND, int PLIILJHILHI, CHFBNEPGHDG MLODBIMCFDB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x23B2B00", Offset = "0x23B1900", VA = "0x1823B2B00")]
	public static T LKNPCKIALBL<T>(PHKIJIILNBG EIFCDBMOGEN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x23B28E0", Offset = "0x23B16E0", VA = "0x1823B28E0")]
	public static T LKNPCKIALBL<T>(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG MLODBIMCFDB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x23B2F40", Offset = "0x23B1D40", VA = "0x1823B2F40")]
	public static T LKNPCKIALBL<T>(Stream PCDNEJJECMC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x23B2CF0", Offset = "0x23B1AF0", VA = "0x1823B2CF0")]
	public static T LKNPCKIALBL<T>(Stream PCDNEJJECMC, CHFBNEPGHDG MLODBIMCFDB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6545BB0", Offset = "0x65449B0", VA = "0x186545BB0")]
	public static string MAKHIIBLLAH(byte[] IDKBCMAGCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6545A70", Offset = "0x6544870", VA = "0x186545A70")]
	public static string MAKHIIBLLAH(byte[] IDKBCMAGCGP, int PLIILJHILHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x65458E0", Offset = "0x65446E0", VA = "0x1865458E0")]
	public static string MAKHIIBLLAH(string IDKBCMAGCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6544E90", Offset = "0x6543C90", VA = "0x186544E90")]
	public static byte[] LICFEMHOEBK(byte[] IDKBCMAGCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6544D40", Offset = "0x6543B40", VA = "0x186544D40")]
	public static byte[] LICFEMHOEBK(byte[] IDKBCMAGCGP, int PLIILJHILHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6544B90", Offset = "0x6543990", VA = "0x186544B90")]
	public static byte[] LICFEMHOEBK(string IDKBCMAGCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6545010", Offset = "0x6543E10", VA = "0x186545010")]
	private static void LJLFHNBIEPA(PHKIJIILNBG EIFCDBMOGEN, NDKEFDAFPOB NEGHIHACAHG, int ECMKHLIFNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6544920", Offset = "0x6543720", VA = "0x186544920")]
	private static int BFOOKHPGNHN(Stream JHAPDKALKLI, byte[] BNFLLCFHIAN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum NILLADDIHIH : byte
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
public struct NDKEFDAFPOB
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] MDMAAKOBEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] BNFLLCFHIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int PLIILJHILHI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CHMLJHAOOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1CCB4E0", Offset = "0x1CCA2E0", VA = "0x181CCB4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6558760", Offset = "0x6557560", VA = "0x186558760")]
	public void CIEACDCIGDM(int PLIILJHILHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6558EE0", Offset = "0x6557CE0", VA = "0x186558EE0")]
	public static byte[] IHOGFJNJIFN(string DLDPMNCLOEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6558890", Offset = "0x6557690", VA = "0x186558890")]
	public static byte[] EBMELJMMPHH(string DLDPMNCLOEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x65595D0", Offset = "0x65583D0", VA = "0x1865595D0")]
	public static byte[] MIGPJJGLCHK(string DLDPMNCLOEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x65591E0", Offset = "0x6557FE0", VA = "0x1865591E0")]
	public static byte[] KELMKGFAOLH(string DLDPMNCLOEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x536F840", Offset = "0x536E640", VA = "0x18536F840")]
	public NDKEFDAFPOB(byte[] IPAMLGDBAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6558770", Offset = "0x6557570", VA = "0x186558770")]
	public ArraySegment<byte> DEKINPEKOGH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6558680", Offset = "0x6557480", VA = "0x186558680")]
	public byte[] CBCPPAEDCOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6559900", Offset = "0x6558700", VA = "0x186559900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6558670", Offset = "0x6557470", VA = "0x186558670")]
	public void ANOFFBMEAGC(int BOOEABHFOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x65584E0", Offset = "0x65572E0", VA = "0x1865584E0")]
	public void AGMFMKJAGIA(byte KHEGNOEJMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6558540", Offset = "0x6557340", VA = "0x186558540")]
	public void AGMFMKJAGIA(byte[] KHEGNOEJMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6558B10", Offset = "0x6557910", VA = "0x186558B10")]
	public void HKMIIIGOBKB(byte KHEGNOEJMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6558810", Offset = "0x6557610", VA = "0x186558810")]
	public void DNBHHONBAEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6559580", Offset = "0x6558380", VA = "0x186559580")]
	public void MFJMJBOCPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6558AC0", Offset = "0x65578C0", VA = "0x186558AC0")]
	public void GJNALEGBFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x65593D0", Offset = "0x65581D0", VA = "0x1865593D0")]
	public void LNHMEKGDJBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6558A00", Offset = "0x6557800", VA = "0x186558A00")]
	public void EPKDCANDBKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x65597C0", Offset = "0x65585C0", VA = "0x1865597C0")]
	public void NPLJJPJFBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x65590D0", Offset = "0x6557ED0", VA = "0x1865590D0")]
	public void IPDOCKJJELD(string DLDPMNCLOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6559080", Offset = "0x6557E80", VA = "0x186559080")]
	public void IKLFCOIPBKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x65585D0", Offset = "0x65573D0", VA = "0x1865585D0")]
	public void AMMJNBDCMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6559420", Offset = "0x6558220", VA = "0x186559420")]
	public void LOPECLGHGKK(bool PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6559740", Offset = "0x6558540", VA = "0x186559740")]
	public void NAFFOKKPLOO(float PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6559880", Offset = "0x6558680", VA = "0x186559880")]
	public void ONOAAEKFNLB(double PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6559010", Offset = "0x6557E10", VA = "0x186559010")]
	public void IIOFCNPOMEJ(byte PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6558A50", Offset = "0x6557850", VA = "0x186558A50")]
	public void GJFJCNPCDGJ(ushort PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6559810", Offset = "0x6558610", VA = "0x186559810")]
	public void OINHNACDJFP(uint PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x65585A0", Offset = "0x65573A0", VA = "0x1865585A0")]
	public void AIAGGIGKJBJ(ulong PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6559170", Offset = "0x6557F70", VA = "0x186559170")]
	public void JJMFLIBHLMO(sbyte PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x65586F0", Offset = "0x65574F0", VA = "0x1865586F0")]
	public void CGBJALEKBKB(short PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6559360", Offset = "0x6558160", VA = "0x186559360")]
	public void KFBDNICJAFD(int PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6558860", Offset = "0x6557660", VA = "0x186558860")]
	public void EBFBDCOCMEE(long PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6558B50", Offset = "0x6557950", VA = "0x186558B50")]
	public void HLINNIAFCAG(string PHPDIJICBJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IPMOPJALDFA : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class JCEECKNFLEA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x39204C0", Offset = "0x391F2C0", VA = "0x1839204C0")]
		static JCEECKNFLEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private IPMOPJALDFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class OFJBBHKIPNN
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> LMAJCMPPHLI;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x655A3B0", Offset = "0x65591B0", VA = "0x18655A3B0")]
	static OFJBBHKIPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6559BC0", Offset = "0x65589C0", VA = "0x186559BC0")]
	internal static object CLPOCFNFGOM(Type KMHHCKOIFKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class FDCEFDFPLNO : LACGAEMAOIL<Vector2>, DNFLPCIHMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly MFBBLNNOMIJ IFKHCGDBEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] LIPBBBBAHMF;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x65464E0", Offset = "0x65452E0", VA = "0x1865464E0")]
	public FDCEFDFPLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x65462F0", Offset = "0x65450F0", VA = "0x1865462F0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, Vector2 PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6546000", Offset = "0x6544E00", VA = "0x186546000", Slot = "5")]
	public Vector2 LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class DOMHKAJEPAA : LACGAEMAOIL<Vector3>, DNFLPCIHMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MFBBLNNOMIJ IFKHCGDBEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] LIPBBBBAHMF;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6544540", Offset = "0x6543340", VA = "0x186544540")]
	public DOMHKAJEPAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x65442A0", Offset = "0x65430A0", VA = "0x1865442A0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, Vector3 PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6543F50", Offset = "0x6542D50", VA = "0x186543F50", Slot = "5")]
	public Vector3 LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class IIKINAAGEEK : LACGAEMAOIL<Vector4>, DNFLPCIHMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly MFBBLNNOMIJ IFKHCGDBEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] LIPBBBBAHMF;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x654C770", Offset = "0x654B570", VA = "0x18654C770")]
	public IIKINAAGEEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x654C430", Offset = "0x654B230", VA = "0x18654C430", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, Vector4 PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x654C0A0", Offset = "0x654AEA0", VA = "0x18654C0A0", Slot = "5")]
	public Vector4 LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class INNOBDBACNL : LACGAEMAOIL<Quaternion>, DNFLPCIHMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly MFBBLNNOMIJ IFKHCGDBEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] LIPBBBBAHMF;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x654D130", Offset = "0x654BF30", VA = "0x18654D130")]
	public INNOBDBACNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x654CDF0", Offset = "0x654BBF0", VA = "0x18654CDF0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, Quaternion PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x654CA60", Offset = "0x654B860", VA = "0x18654CA60", Slot = "5")]
	public Quaternion LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class GKHMJBBGKBF : LACGAEMAOIL<Color>, DNFLPCIHMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly MFBBLNNOMIJ IFKHCGDBEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] LIPBBBBAHMF;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6548CE0", Offset = "0x6547AE0", VA = "0x186548CE0")]
	public GKHMJBBGKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x65489A0", Offset = "0x65477A0", VA = "0x1865489A0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, Color PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6548610", Offset = "0x6547410", VA = "0x186548610", Slot = "5")]
	public Color LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class HFLBAMAKAIC : LACGAEMAOIL<Bounds>, DNFLPCIHMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly MFBBLNNOMIJ IFKHCGDBEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] LIPBBBBAHMF;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x654BD50", Offset = "0x654AB50", VA = "0x18654BD50")]
	public HFLBAMAKAIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x654BA30", Offset = "0x654A830", VA = "0x18654BA30", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, Bounds PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x654B650", Offset = "0x654A450", VA = "0x18654B650", Slot = "5")]
	public Bounds LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class JGACKJLJNBB : LACGAEMAOIL<Rect>, DNFLPCIHMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly MFBBLNNOMIJ IFKHCGDBEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] LIPBBBBAHMF;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x654DC00", Offset = "0x654CA00", VA = "0x18654DC00")]
	public JGACKJLJNBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x654D890", Offset = "0x654C690", VA = "0x18654D890", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, Rect PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x654D4A0", Offset = "0x654C2A0", VA = "0x18654D4A0", Slot = "5")]
	public Rect LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class DFMGAJKIHKM : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private static class BNCLBEDNLLF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x45FF950", Offset = "0x45FE750", VA = "0x1845FF950")]
		static BNCLBEDNLLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private DFMGAJKIHKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class NJFGBNOJGOO : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private static class HGOEKHIPGIN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3646F60", Offset = "0x3645D60", VA = "0x183646F60")]
		static HGOEKHIPGIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class KABDOKHMPGD
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> PHCCAAHHNNC;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x654DEF0", Offset = "0x654CCF0", VA = "0x18654DEF0")]
		internal static object CLPOCFNFGOM(Type KMHHCKOIFKM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private NJFGBNOJGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class CLOFNFIBJKM : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class PGCELKODDPK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3EECB70", Offset = "0x3EEB970", VA = "0x183EECB70")]
		static PGCELKODDPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly CLOFNFIBJKM ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool PJNBHOHKKHL;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static DNFLPCIHMPE[] IAEIPKPGMMB;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static CHFBNEPGHDG[] GPDDCPMDPOA;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private CLOFNFIBJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6541D20", Offset = "0x6540B20", VA = "0x186541D20")]
	public static void EEHFKNGNNHO(params CHFBNEPGHDG[] GPDDCPMDPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6541C40", Offset = "0x6540A40", VA = "0x186541C40")]
	public static void EEHFKNGNNHO(params DNFLPCIHMPE[] IAEIPKPGMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6541E00", Offset = "0x6540C00", VA = "0x186541E00")]
	public static void EPHGJNBKGJF(DNFLPCIHMPE[] IAEIPKPGMMB, CHFBNEPGHDG[] GPDDCPMDPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class FBDDMMNONIL : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private static class HIHJJEGFOAG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x364C9D0", Offset = "0x364B7D0", VA = "0x18364C9D0")]
		static HIHJJEGFOAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private FBDDMMNONIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class GKJHCCNIAHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly CHFBNEPGHDG PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly CHFBNEPGHDG MLKALCLOKEP;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly CHFBNEPGHDG PLCAMDMCCIP;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly CHFBNEPGHDG IPEEGLBDNAH;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly CHFBNEPGHDG HGENBDJJNIP;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly CHFBNEPGHDG IKKGCOACCOC;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly CHFBNEPGHDG OEOFFFMHBPM;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly CHFBNEPGHDG ILDGGACGMGH;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly CHFBNEPGHDG PBOLKKFMPKK;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly CHFBNEPGHDG CDFKLGGFBEG;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly CHFBNEPGHDG AAJDLABDIHN;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly CHFBNEPGHDG FLHLOBGKIFL;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class FACHFIGOKLF
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly CHFBNEPGHDG PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly CHFBNEPGHDG HINHAIKMCMK;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class BEJMOPMHGIP
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly CHFBNEPGHDG PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly CHFBNEPGHDG MLKALCLOKEP;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly CHFBNEPGHDG PLCAMDMCCIP;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly CHFBNEPGHDG IPEEGLBDNAH;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly CHFBNEPGHDG HGENBDJJNIP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly CHFBNEPGHDG IKKGCOACCOC;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly CHFBNEPGHDG OEOFFFMHBPM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly CHFBNEPGHDG ILDGGACGMGH;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly CHFBNEPGHDG PBOLKKFMPKK;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly CHFBNEPGHDG CDFKLGGFBEG;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly CHFBNEPGHDG AAJDLABDIHN;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly CHFBNEPGHDG FLHLOBGKIFL;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class HDKFEFDDMHB
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> PHCCAAHHNNC;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6549960", Offset = "0x6548760", VA = "0x186549960")]
	internal static object CLPOCFNFGOM(Type KMHHCKOIFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x654B0C0", Offset = "0x6549EC0", VA = "0x18654B0C0")]
	private static object JCKJLJMJMPP(Type OFCBDHLIIHM, Type[] AGACIIEOLDD, params object[] IGMPFJGNMCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class PLCMEOFHAGH : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class GHGFKKPECGE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x35C8D20", Offset = "0x35C7B20", VA = "0x1835C8D20")]
		static GHGFKKPECGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> ABHHOFFFCGN;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool LGEBEMKKODL;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly JDNLDGDDKJC HBDNCACINJE;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x655DEF0", Offset = "0x655CCF0", VA = "0x18655DEF0")]
	static PLCMEOFHAGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private PLCMEOFHAGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class IACHCPBNFOD : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class GNEIEOEBNPP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x35F4A80", Offset = "0x35F3880", VA = "0x1835F4A80")]
		static GNEIEOEBNPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> ABHHOFFFCGN;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool LGEBEMKKODL;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly JDNLDGDDKJC HBDNCACINJE;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x654BF30", Offset = "0x654AD30", VA = "0x18654BF30")]
	static IACHCPBNFOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private IACHCPBNFOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class KCDDAFHOBHE : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class GNBLHMNMIOH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x35F0020", Offset = "0x35EEE20", VA = "0x1835F0020")]
		static GNBLHMNMIOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> ABHHOFFFCGN;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool LGEBEMKKODL;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly JDNLDGDDKJC HBDNCACINJE;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x654FD20", Offset = "0x654EB20", VA = "0x18654FD20")]
	static KCDDAFHOBHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private KCDDAFHOBHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class KKOOGIOGACO : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class LDJAGPKHDFE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3AA6560", Offset = "0x3AA5360", VA = "0x183AA6560")]
		static LDJAGPKHDFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> ABHHOFFFCGN;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool LGEBEMKKODL;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly JDNLDGDDKJC HBDNCACINJE;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6550090", Offset = "0x654EE90", VA = "0x186550090")]
	static KKOOGIOGACO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private KKOOGIOGACO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class EBIOBCLIMIC : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class BPADKBPEICD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x46E7DB0", Offset = "0x46E6BB0", VA = "0x1846E7DB0")]
		static BPADKBPEICD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> ABHHOFFFCGN;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool LGEBEMKKODL;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly JDNLDGDDKJC HBDNCACINJE;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x65447B0", Offset = "0x65435B0", VA = "0x1865447B0")]
	static EBIOBCLIMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private EBIOBCLIMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class OCNDHJMAAOB : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class POHFEJAOGCJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3F0BB50", Offset = "0x3F0A950", VA = "0x183F0BB50")]
		static POHFEJAOGCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> ABHHOFFFCGN;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool LGEBEMKKODL;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly JDNLDGDDKJC HBDNCACINJE;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6559A50", Offset = "0x6558850", VA = "0x186559A50")]
	static OCNDHJMAAOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private OCNDHJMAAOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class FHKCMFKOIIH : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class GEBPDMHKPOG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x35A9E10", Offset = "0x35A8C10", VA = "0x1835A9E10")]
		static GEBPDMHKPOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> ABHHOFFFCGN;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool LGEBEMKKODL;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public FHKCMFKOIIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class KIDGILKKAIA : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private static class JMCPMGBKMNB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x39C03B0", Offset = "0x39BF1B0", VA = "0x1839C03B0")]
		static JMCPMGBKMNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> ABHHOFFFCGN;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool LGEBEMKKODL;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public KIDGILKKAIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal sealed class PPKPHHIEMPL : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private static class KCEMCCGDKKA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3A1F260", Offset = "0x3A1E060", VA = "0x183A1F260")]
		static KCEMCCGDKKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> ABHHOFFFCGN;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool LGEBEMKKODL;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public PPKPHHIEMPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class CNCBNBABNBE : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private static class PLDJPFPKNFJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3F02E10", Offset = "0x3F01C10", VA = "0x183F02E10")]
		static PLDJPFPKNFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> ABHHOFFFCGN;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool LGEBEMKKODL;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public CNCBNBABNBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class GGHLBODCELH : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private static class HGAGJACANKB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x363E990", Offset = "0x363D790", VA = "0x18363E990")]
		static HGAGJACANKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> ABHHOFFFCGN;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool LGEBEMKKODL;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public GGHLBODCELH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class KHEGGHIBIBO : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private static class EHFKEDDACNP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x30EDA70", Offset = "0x30EC870", VA = "0x1830EDA70")]
		static EHFKEDDACNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> ABHHOFFFCGN;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool LGEBEMKKODL;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public KHEGGHIBIBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class MKGPPAOIFOJ
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct OPEPEJFLMNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public LNAAMFGGNLJ DAHOGNMMMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder MIOPIJLOBJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder IOAOJJKPIKD;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class CPKNAPMFNAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class DAEBEKHONJO
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo MIGPJJGLCHK;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo EBMELJMMPHH;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo KELMKGFAOLH;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo IHOGFJNJIFN;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo AMMJNBDCMFB;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo AGMFMKJAGIA;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo GJNALEGBFFP;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo LNHMEKGDJBK;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo EPKDCANDBKC;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x6562F20", Offset = "0x6561D20", VA = "0x186562F20")]
			static DAEBEKHONJO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class IFPLAOIGGDE
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo CJFIMAFOGCM;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo CBKNEGJKECJ;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo LHFALIHHJBK;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo LEBPAGJKGMG;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo MHGMAGEIEEM;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo AFENPJLLBAB;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo BKPIGJDJJCH;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x656AE30", Offset = "0x6569C30", VA = "0x18656AE30")]
			static IFPLAOIGGDE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		internal static class DDDEPOBIPBH
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo GIIPLIJOBHJ;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo GBEGIHNAFID;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo OPFEKCKOPAC;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo JLONOMKCDAD;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo CPOPKGGBLFP;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo FCCFFJOBDIJ;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo KFCDIANAGOK;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo OONGPOJOINI;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo EEINLGBHNDL;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo IEGJAMFPNKI;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo GHKEMDGFEOK;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo HDJEKAIJKON;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo FDCLPGLNPAJ;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo PHBLCKLIPHJ;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6542620", Offset = "0x6541420", VA = "0x186542620")]
		public static MethodInfo OJBJHHLKILJ(Type AOPDMLJGEMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x65423E0", Offset = "0x65411E0", VA = "0x1865423E0")]
		public static MethodInfo LKNPCKIALBL(Type AOPDMLJGEMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x65422B0", Offset = "0x65410B0", VA = "0x1865422B0")]
		public static MethodInfo GKNEKAMHPJG(Type AOPDMLJGEMB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class HMJJGKAIEII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<LNAAMFGGNLJ, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public HMJJGKAIEII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class BNFDOPBHEGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public HMJJGKAIEII CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public BNFDOPBHEGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6560C00", Offset = "0x655FA00", VA = "0x186560C00")]
		internal void BPLBMEFMKLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6560D00", Offset = "0x655FB00", VA = "0x186560D00")]
		internal bool KKAPKKKIFDN(int index, LNAAMFGGNLJ member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class FHMJPHDGPLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public HMJJGKAIEII CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public FHMJPHDGPLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6568A20", Offset = "0x6567820", VA = "0x186568A20")]
		internal bool CMHMCCKBEGA(int index, LNAAMFGGNLJ member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class DPFOEJBPBME
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
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public DPFOEJBPBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x37ADBF0", Offset = "0x37AC9F0", VA = "0x1837ADBF0")]
		internal string JCAGDPGMPLF(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class CCLDAJCMJPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public CCLDAJCMJPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6562C60", Offset = "0x6561A60", VA = "0x186562C60")]
		internal bool AOCKEEOKKJK(LNAAMFGGNLJ x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class CJNCCGCELBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public DPFOEJBPBME CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public CJNCCGCELBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6562CC0", Offset = "0x6561AC0", VA = "0x186562CC0")]
		internal void HEPNGAGHEAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6562D40", Offset = "0x6561B40", VA = "0x186562D40")]
		internal bool LOHFNCMPELK(int index, LNAAMFGGNLJ member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class EKIAEOCHGOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public DPFOEJBPBME CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public EKIAEOCHGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6565F80", Offset = "0x6564D80", VA = "0x186565F80")]
		internal bool DPEOKLEMFKA(int index, LNAAMFGGNLJ member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class KKGLDDFMDFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public KKGLDDFMDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x656E610", Offset = "0x656D410", VA = "0x18656E610")]
		internal Label PKNPGHLBDKG(LNAAMFGGNLJ _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class LLOBLLIMFAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public OPEPEJFLMNM[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, LNAAMFGGNLJ, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public HDLIABDAJPD argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public HDLIABDAJPD argResolver;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public LLOBLLIMFAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6570280", Offset = "0x656F080", VA = "0x186570280")]
		internal OPEPEJFLMNM EBBDEECCBPP(LNAAMFGGNLJ item)
		{
			return default(OPEPEJFLMNM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class IDJFGOECOBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public LLOBLLIMFAF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public IDJFGOECOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x656A910", Offset = "0x6569710", VA = "0x18656A910")]
		internal void AEFODOPJKOP(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x656ABC0", Offset = "0x65699C0", VA = "0x18656ABC0")]
		internal void MKFPAFPPOKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class IPHELCBOLBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public LNAAMFGGNLJ item;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public IPHELCBOLBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xAD1EC0", Offset = "0xAD0CC0", VA = "0x180AD1EC0")]
		internal bool BOGHEEEDEON(OPEPEJFLMNM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class FMLMJKJDJGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public LNAAMFGGNLJ item;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public FMLMJKJDJGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xAD1EC0", Offset = "0xAD0CC0", VA = "0x180AD1EC0")]
		internal bool KLEGPBPCLIH(OPEPEJFLMNM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex MOAGEJOAJDK;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int PGCDDKHEFLN;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> GDDOPJBDJIA;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> MKMOGMNEHCH;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2583930", Offset = "0x2582730", VA = "0x182583930")]
	public static object HNOPGFDPCMC<T>(JDNLDGDDKJC HBDNCACINJE, CHFBNEPGHDG NCNECEHAHMM, Func<string, string> ABHHOFFFCGN, bool LGEBEMKKODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x25920D0", Offset = "0x2590ED0", VA = "0x1825920D0")]
	public static object KJLIDKKNGAK<T>(CHFBNEPGHDG NCNECEHAHMM, Func<string, string> ABHHOFFFCGN, bool LGEBEMKKODL, bool HJLCNEDLJEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6557450", Offset = "0x6556250", VA = "0x186557450")]
	private static TypeInfo PBEFGLACOFE(JDNLDGDDKJC HBDNCACINJE, Type AOPDMLJGEMB, Func<string, string> ABHHOFFFCGN, bool LGEBEMKKODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x65545F0", Offset = "0x65533F0", VA = "0x1865545F0")]
	public static object OHNPCGAEEFF(Type AOPDMLJGEMB, Func<string, string> ABHHOFFFCGN, bool LGEBEMKKODL, bool HJLCNEDLJEK, bool PIHMJAIMJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6550BB0", Offset = "0x654F9B0", VA = "0x186550BB0")]
	private static Dictionary<LNAAMFGGNLJ, FieldInfo> EGPEMCIFOHN(TypeBuilder DANCLGJPKLL, MKPOCHJGKPM LGEPELKHPCL, ConstructorInfo LGJFHHINKLP, FieldBuilder JCMEEDEKFMC, ILGenerator GOJOCPEIIHH, bool LGEBEMKKODL, bool OKONFIOPCDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6551460", Offset = "0x6550260", VA = "0x186551460")]
	private static Dictionary<LNAAMFGGNLJ, FieldInfo> ENNMFEEACGC(TypeBuilder DANCLGJPKLL, MKPOCHJGKPM LGEPELKHPCL, ILGenerator GOJOCPEIIHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x65528D0", Offset = "0x65516D0", VA = "0x1865528D0")]
	private static void LDAKEGLBLAE(Type AOPDMLJGEMB, MKPOCHJGKPM LGEPELKHPCL, ILGenerator GOJOCPEIIHH, Action NBPMCKKOJDF, Func<int, LNAAMFGGNLJ, bool> IIIHJIHBKKB, bool LGEBEMKKODL, bool OKONFIOPCDK, int LEGINLCBBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6550670", Offset = "0x654F470", VA = "0x186550670")]
	private static void EBPJECODIFP(TypeInfo AOPDMLJGEMB, LNAAMFGGNLJ KINPJKOKLLC, ILGenerator GOJOCPEIIHH, int NGIPPLLBEKC, Func<int, LNAAMFGGNLJ, bool> IIIHJIHBKKB, HDLIABDAJPD NEGHIHACAHG, HDLIABDAJPD LPNCELLKDEB, HDLIABDAJPD HIAAFHFNDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6556120", Offset = "0x6554F20", VA = "0x186556120")]
	private static void OIAJKMOCIFM(Type AOPDMLJGEMB, MKPOCHJGKPM LGEPELKHPCL, ILGenerator GOJOCPEIIHH, Func<int, LNAAMFGGNLJ, bool> IIIHJIHBKKB, bool FBEIGIPKDMI, int LEGINLCBBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6550200", Offset = "0x654F000", VA = "0x186550200")]
	private static void CGCKLFOLNME(ILGenerator GOJOCPEIIHH, OPEPEJFLMNM LGEPELKHPCL, int NGIPPLLBEKC, Func<int, LNAAMFGGNLJ, bool> IIIHJIHBKKB, HDLIABDAJPD EIFCDBMOGEN, HDLIABDAJPD HIAAFHFNDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6551B40", Offset = "0x6550940", VA = "0x186551B40")]
	private static LocalBuilder GHAFBIPOHCJ(ILGenerator GOJOCPEIIHH, Type AOPDMLJGEMB, MKPOCHJGKPM LGEPELKHPCL, OPEPEJFLMNM[] CIOCEGLLGPM, bool HGAJNIFECDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6553F10", Offset = "0x6552D10", VA = "0x186553F10")]
	private static bool NOMNLEDGDCC(ConstructorInfo AIOKKAOHGME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x65512E0", Offset = "0x65500E0", VA = "0x1865512E0")]
	private static bool EKIMCGAHCNB(Type AOPDMLJGEMB, [Out] Type GBJJNKHBNFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate void INPHEDDBNJP<T>(byte[][] JCMEEDEKFMC, object[] PMHNFKINFIJ, NDKEFDAFPOB NEGHIHACAHG, T PHPDIJICBJO, CHFBNEPGHDG MLODBIMCFDB);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal delegate T ILDMNKALCBJ<T>(object[] PMHNFKINFIJ, PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG MLODBIMCFDB);
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class IIIAAFBCKAE<T> : LACGAEMAOIL<T>, DNFLPCIHMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] JCMEEDEKFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] DOMHONAPPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] OFKBAPIBNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly INPHEDDBNJP<T> ODKEOEFEHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ILDMNKALCBJ<T> IDMAGANIPFL;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1CADEC0", Offset = "0x1CACCC0", VA = "0x181CADEC0")]
	public IIIAAFBCKAE(byte[][] JCMEEDEKFMC, object[] DOMHONAPPKO, object[] OFKBAPIBNFC, INPHEDDBNJP<T> ODKEOEFEHCN, ILDMNKALCBJ<T> IDMAGANIPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x375A0A0", Offset = "0x3758EA0", VA = "0x18375A0A0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, T PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3759FB0", Offset = "0x3758DB0", VA = "0x183759FB0", Slot = "5")]
	public T LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class BKOCFOINKPN : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private static class GDCKOGJJNND<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x35753B0", Offset = "0x35741B0", VA = "0x1835753B0")]
		static GDCKOGJJNND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private BKOCFOINKPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class ELLPIPPMIBP : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private static class AOCHDKPLLFP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x37B9790", Offset = "0x37B8590", VA = "0x1837B9790")]
		static AOCHDKPLLFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private ELLPIPPMIBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal static class BNKDMMLLIHM
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly CHFBNEPGHDG[] AKGHLCPHNHH;
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class EBLFIJPDLIO : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class IAJAHIFAIBA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x371C910", Offset = "0x371B710", VA = "0x18371C910")]
		static IAJAHIFAIBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class OBCIDOHNBOC : CHFBNEPGHDG
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		private static class ONMGMOBHFLN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3E1EFD0", Offset = "0x3E1DDD0", VA = "0x183E1EFD0")]
			static ONMGMOBHFLN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly CHFBNEPGHDG ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly CHFBNEPGHDG[] GPDDCPMDPOA;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		private OBCIDOHNBOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
		public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly LACGAEMAOIL<object> MEHKPNHKELF;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private EBLFIJPDLIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class CCFIGABGKIJ : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private static class JBEPJAPKAOL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3915E90", Offset = "0x3914C90", VA = "0x183915E90")]
		static JBEPJAPKAOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class DMCAJNEMNBL : CHFBNEPGHDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		private static class IOIALKFGACP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x376DF10", Offset = "0x376CD10", VA = "0x18376DF10")]
			static IOIALKFGACP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly CHFBNEPGHDG ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly CHFBNEPGHDG[] GPDDCPMDPOA;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		private DMCAJNEMNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
		public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly LACGAEMAOIL<object> MEHKPNHKELF;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private CCFIGABGKIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class JJDFAJMOEIJ : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private static class IFMFMIKJKFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3748A20", Offset = "0x3747820", VA = "0x183748A20")]
		static IFMFMIKJKFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class AAMJCDFJPEM : CHFBNEPGHDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private static class DGNLFIKGKAG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4D80B90", Offset = "0x4D7F990", VA = "0x184D80B90")]
			static DGNLFIKGKAG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly CHFBNEPGHDG ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly CHFBNEPGHDG[] GPDDCPMDPOA;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		private AAMJCDFJPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
		public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly LACGAEMAOIL<object> MEHKPNHKELF;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private JJDFAJMOEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal sealed class NMKJCOLCBCJ : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private static class IOAFAGIBBIE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x37692C0", Offset = "0x37680C0", VA = "0x1837692C0")]
		static IOAFAGIBBIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class GEAMIMNEAIA : CHFBNEPGHDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		private static class LKMODIEAEPB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3AC42A0", Offset = "0x3AC30A0", VA = "0x183AC42A0")]
			static LKMODIEAEPB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly CHFBNEPGHDG ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly CHFBNEPGHDG[] GPDDCPMDPOA;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		private GEAMIMNEAIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
		public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly LACGAEMAOIL<object> MEHKPNHKELF;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private NMKJCOLCBCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class FJIGGKLAMHG : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private static class GKBEEMPDNHG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x35DFFA0", Offset = "0x35DEDA0", VA = "0x1835DFFA0")]
		static GKBEEMPDNHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class GOKNBALJDBN : CHFBNEPGHDG
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		private static class DCMEMJDLNHJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x4D78450", Offset = "0x4D77250", VA = "0x184D78450")]
			static DCMEMJDLNHJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly CHFBNEPGHDG ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly CHFBNEPGHDG[] GPDDCPMDPOA;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		private GOKNBALJDBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
		public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly LACGAEMAOIL<object> MEHKPNHKELF;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private FJIGGKLAMHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class DIPBEMLMGKB : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private static class GECHFEKCJIM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x35B30B0", Offset = "0x35B1EB0", VA = "0x1835B30B0")]
		static GECHFEKCJIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private sealed class GJPAAPEDHED : CHFBNEPGHDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		private static class DBGHPALDNIF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x4D70410", Offset = "0x4D6F210", VA = "0x184D70410")]
			static DBGHPALDNIF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly CHFBNEPGHDG ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly CHFBNEPGHDG[] GPDDCPMDPOA;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		private GJPAAPEDHED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
		public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly LACGAEMAOIL<object> MEHKPNHKELF;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private DIPBEMLMGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal sealed class DILNANJDGEJ : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private static class NCDHNFMPJLN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3D03140", Offset = "0x3D01F40", VA = "0x183D03140")]
		static NCDHNFMPJLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private sealed class EHMNGAKIFPB : CHFBNEPGHDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		private static class GPGCPBKCGNM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x35FA220", Offset = "0x35F9020", VA = "0x1835FA220")]
			static GPGCPBKCGNM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly CHFBNEPGHDG ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly CHFBNEPGHDG[] GPDDCPMDPOA;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		private EHMNGAKIFPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
		public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly LACGAEMAOIL<object> MEHKPNHKELF;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private DILNANJDGEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal sealed class ODONLHJCKBF : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private static class IBMKIMIAMBD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x372AB20", Offset = "0x3729920", VA = "0x18372AB20")]
		static IBMKIMIAMBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private sealed class BHPGKAKFMFG : CHFBNEPGHDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private static class LDJGKHDPBKO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3AAA890", Offset = "0x3AA9690", VA = "0x183AAA890")]
			static LDJGKHDPBKO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly CHFBNEPGHDG ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly CHFBNEPGHDG[] GPDDCPMDPOA;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		private BHPGKAKFMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
		public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly LACGAEMAOIL<object> MEHKPNHKELF;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private ODONLHJCKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal sealed class DMDHFDGPODE : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private static class AHJCGBAGCCK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x37A62D0", Offset = "0x37A50D0", VA = "0x1837A62D0")]
		static AHJCGBAGCCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private sealed class DOANDJGDFMI : CHFBNEPGHDG
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		private static class EGLEKDHCHOC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x30E2AA0", Offset = "0x30E18A0", VA = "0x1830E2AA0")]
			static EGLEKDHCHOC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly CHFBNEPGHDG ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly CHFBNEPGHDG[] GPDDCPMDPOA;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		private DOANDJGDFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
		public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly LACGAEMAOIL<object> MEHKPNHKELF;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private DMDHFDGPODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal sealed class MMAKALLGDDL : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private static class NNDOMFCCCIJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3D27D20", Offset = "0x3D26B20", VA = "0x183D27D20")]
		static NNDOMFCCCIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private sealed class JBJICBAENHM : CHFBNEPGHDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		private static class BCNOKAKABDH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x455C860", Offset = "0x455B660", VA = "0x18455C860")]
			static BCNOKAKABDH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly CHFBNEPGHDG ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly CHFBNEPGHDG[] GPDDCPMDPOA;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		private JBJICBAENHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
		public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly LACGAEMAOIL<object> MEHKPNHKELF;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private MMAKALLGDDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal sealed class LJDLNDAFGCL : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private static class GJCKIIGCEGK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x35D7B30", Offset = "0x35D6930", VA = "0x1835D7B30")]
		static GJCKIIGCEGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private sealed class OBHHCDPLBBO : CHFBNEPGHDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		private static class DKACEPNEJHG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x4D8B2A0", Offset = "0x4D8A0A0", VA = "0x184D8B2A0")]
			static DKACEPNEJHG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly CHFBNEPGHDG ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly CHFBNEPGHDG[] GPDDCPMDPOA;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		private OBHHCDPLBBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
		public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly LACGAEMAOIL<object> MEHKPNHKELF;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private LJDLNDAFGCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
internal sealed class OHHNEFLAHAH : CHFBNEPGHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private static class MEOMEPOCNOM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3C9C470", Offset = "0x3C9B270", VA = "0x183C9C470")]
		static MEOMEPOCNOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private sealed class IFNNIOAGCCB : CHFBNEPGHDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		private static class FGKFHCNHNAN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly LACGAEMAOIL<T> EJKDLKDNAKK;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3446D60", Offset = "0x3445B60", VA = "0x183446D60")]
			static FGKFHCNHNAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly CHFBNEPGHDG ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly CHFBNEPGHDG[] GPDDCPMDPOA;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		private IFNNIOAGCCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
		public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly CHFBNEPGHDG ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly LACGAEMAOIL<object> MEHKPNHKELF;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	private OHHNEFLAHAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	public LACGAEMAOIL<T> CLPOCFNFGOM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct INCHBDGODKM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] GGMHBDHGLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int BMGCJGPBFOP;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3761B60", Offset = "0x3760960", VA = "0x183761B60")]
	public INCHBDGODKM(int BLINFEPNMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3761720", Offset = "0x3760520", VA = "0x183761720")]
	public void JHPNFEHLKNP(T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3761690", Offset = "0x3760490", VA = "0x183761690")]
	public T[] BPKKGGCOBEA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal sealed class PMACPFAPELJ : PKLDONPLNNE<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly PMACPFAPELJ PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6576AA0", Offset = "0x65758A0", VA = "0x186576AA0")]
	public PMACPFAPELJ(int NAEDBFCGCLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class PKLDONPLNNE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int NAEDBFCGCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object CLPCGINGDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int NGIPPLLBEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] BLKEOPNEJJC;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3EFF2B0", Offset = "0x3EFE0B0", VA = "0x183EFF2B0")]
	public PKLDONPLNNE(int NAEDBFCGCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3EFDE70", Offset = "0x3EFCC70", VA = "0x183EFDE70")]
	public T[] CKFBANEFOML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3EFE0B0", Offset = "0x3EFCEB0", VA = "0x183EFE0B0")]
	public void LCKEOCJBOMM(T[] LPMIAHOCPLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class MFBBLNNOMIJ : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private class AHOBPHBOCMB : IComparable<AHOBPHBOCMB>
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class FNDJPBMJMDG : IEnumerable<AHOBPHBOCMB>, IEnumerable, IEnumerator<AHOBPHBOCMB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private AHOBPHBOCMB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public AHOBPHBOCMB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private AHOBPHBOCMB System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8C4CB0", Offset = "0x8C3AB0", VA = "0x1808C4CB0")]
			[DebuggerHidden]
			public FNDJPBMJMDG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x6568D00", Offset = "0x6567B00", VA = "0x186568D00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6568E30", Offset = "0x6567C30", VA = "0x186568E30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x6568D80", Offset = "0x6567B80", VA = "0x186568D80", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AHOBPHBOCMB> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x6568D80", Offset = "0x6567B80", VA = "0x186568D80", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class MMNNBPAKDAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
			public MMNNBPAKDAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x656E610", Offset = "0x656D410", VA = "0x18656E610")]
			internal Label AFEJNNDOJCJ(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x656E610", Offset = "0x656D410", VA = "0x18656E610")]
			internal Label KBMCMCLGJKI(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly AHOBPHBOCMB[] JNFMCINCDHK;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] GMLIGBFEODO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong OLNAGICFANI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int DHGNDNJJJIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string FJLJKHLHCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private AHOBPHBOCMB[] KMCOMDMABFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] NJEDDJMBKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int PDNIMDHODLH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IOEJMOOHEPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x509FD60", Offset = "0x509EB60", VA = "0x18509FD60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x65601A0", Offset = "0x655EFA0", VA = "0x1865601A0")]
		public AHOBPHBOCMB(ulong GAMCILOFBAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x655EE90", Offset = "0x655DC90", VA = "0x18655EE90")]
		public AHOBPHBOCMB JHPNFEHLKNP(ulong GAMCILOFBAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x655EE30", Offset = "0x655DC30", VA = "0x18655EE30")]
		public AHOBPHBOCMB JHPNFEHLKNP(ulong GAMCILOFBAF, int PHPDIJICBJO, string FJLJKHLHCJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x655EB70", Offset = "0x655D970", VA = "0x18655EB70")]
		public AHOBPHBOCMB BDLBHDEODOE(byte[] JAHBPEHPOCF, int PLIILJHILHI, int NBLCNBBIBLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x655ED20", Offset = "0x655DB20", VA = "0x18655ED20")]
		internal static int DOPFADIJDPO(ulong[] LPMIAHOCPLL, int NGIPPLLBEKC, int ELGJIDFGJJH, ulong PHPDIJICBJO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x655ECF0", Offset = "0x655DAF0", VA = "0x18655ECF0", Slot = "4")]
		public int CompareTo(AHOBPHBOCMB LCIDHBCOPEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x655EDB0", Offset = "0x655DBB0", VA = "0x18655EDB0")]
		[IteratorStateMachine(typeof(FNDJPBMJMDG))]
		public IEnumerable<AHOBPHBOCMB> FICEFJGFNOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x655F090", Offset = "0x655DE90", VA = "0x18655F090")]
		public void KABBBHBIHPM(ILGenerator GOJOCPEIIHH, LocalBuilder JAHBPEHPOCF, LocalBuilder NBLCNBBIBLB, LocalBuilder GAMCILOFBAF, Action<KeyValuePair<string, int>> IMPBLLPPPDL, Action KDJNGEHJBCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x655F410", Offset = "0x655E210", VA = "0x18655F410")]
		private static void NEEABOMMIOA(ILGenerator GOJOCPEIIHH, LocalBuilder JAHBPEHPOCF, LocalBuilder NBLCNBBIBLB, LocalBuilder GAMCILOFBAF, Action<KeyValuePair<string, int>> IMPBLLPPPDL, Action KDJNGEHJBCG, AHOBPHBOCMB[] KMCOMDMABFF, int PDNIMDHODLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class GBBFEFEJJDK : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<AHOBPHBOCMB> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<AHOBPHBOCMB> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<AHOBPHBOCMB> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private AHOBPHBOCMB <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x9C95C0", Offset = "0x9C83C0", VA = "0x1809C95C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6569520", Offset = "0x6568320", VA = "0x186569520", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1BBA460", Offset = "0x1BB9260", VA = "0x181BBA460")]
		[DebuggerHidden]
		public GBBFEFEJJDK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6569570", Offset = "0x6568370", VA = "0x186569570", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6568FC0", Offset = "0x6567DC0", VA = "0x186568FC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6568F70", Offset = "0x6567D70", VA = "0x186568F70")]
		private void FKICEAEIDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6568F20", Offset = "0x6567D20", VA = "0x186568F20")]
		private void CEJKOOJCMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x65694D0", Offset = "0x65682D0", VA = "0x1865694D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6569420", Offset = "0x6568220", VA = "0x186569420", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6569420", Offset = "0x6568220", VA = "0x186569420", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly AHOBPHBOCMB NANDDCHCAEB;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6571620", Offset = "0x6570420", VA = "0x186571620")]
	public MFBBLNNOMIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x65712F0", Offset = "0x65700F0", VA = "0x1865712F0")]
	public void JHPNFEHLKNP(byte[] EHLPPEEOBND, int PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6571480", Offset = "0x6570280", VA = "0x186571480")]
	public bool MLKIAPIGKOA(ArraySegment<byte> GAMCILOFBAF, [Out] int PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6571590", Offset = "0x6570390", VA = "0x186571590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6571010", Offset = "0x656FE10", VA = "0x186571010")]
	private static void IACJBJGGPAI(IEnumerable<AHOBPHBOCMB> KMCOMDMABFF, StringBuilder FEAOBCJBFAE, int ECMKHLIFNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6570FB0", Offset = "0x656FDB0", VA = "0x186570FB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6570FB0", Offset = "0x656FDB0", VA = "0x186570FB0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6571400", Offset = "0x6570200", VA = "0x186571400")]
	[IteratorStateMachine(typeof(GBBFEFEJJDK))]
	private static IEnumerable<KeyValuePair<string, int>> LFGNPOEOOPE(IEnumerable<AHOBPHBOCMB> KMCOMDMABFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6571560", Offset = "0x6570360", VA = "0x186571560")]
	public void PJMNMBAFOKP(ILGenerator GOJOCPEIIHH, LocalBuilder JAHBPEHPOCF, LocalBuilder NBLCNBBIBLB, LocalBuilder GAMCILOFBAF, Action<KeyValuePair<string, int>> IMPBLLPPPDL, Action KDJNGEHJBCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class OGAHBKEBAKD
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo ELJEPFJIALJ;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6575A70", Offset = "0x6574870", VA = "0x186575A70")]
	public static ulong NKCLEPGGGOH(byte[] EHLPPEEOBND, int PLIILJHILHI, int NBLCNBBIBLB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class OCJMEKBMOEK
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6575560", Offset = "0x6574360", VA = "0x186575560")]
	public static void ANOFFBMEAGC(byte[] EHLPPEEOBND, int PLIILJHILHI, int BOOEABHFOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x65756A0", Offset = "0x65744A0", VA = "0x1865756A0")]
	public static void GPOKCKOPLFO(byte[] LPMIAHOCPLL, int JHFHHOIEMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x65757C0", Offset = "0x65745C0", VA = "0x1865757C0")]
	public static byte[] PHADLNBJAON(byte[] JPKEGLEDKEC, int JHFHHOIEMCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class ACHHEGFDFNP
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x655EB00", Offset = "0x655D900", VA = "0x18655EB00")]
	public static bool PMFKIKELGCM(byte[] CCLGIGADPFL, int JMGLLGIOHIJ, int AFFDDMLICAD, byte[] BIHDIJLAEKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal class IDHNMEFONPN<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private struct JOKIIGFJOMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] OLNAGICFANI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T DHGNDNJJJIH;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x39D2340", Offset = "0x39D1140", VA = "0x1839D2340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class GKMNOFPHBOL : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public IDHNMEFONPN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private JOKIIGFJOMH[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private JOKIIGFJOMH[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x9C95C0", Offset = "0x9C83C0", VA = "0x1809C95C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x34C7930", Offset = "0x34C6730", VA = "0x1834C7930", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
		[DebuggerHidden]
		public GKMNOFPHBOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x35E8670", Offset = "0x35E7470", VA = "0x1835E8670", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x35E9920", Offset = "0x35E8720", VA = "0x1835E9920", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly JOKIIGFJOMH[][] EOHEMNNLNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong KJIPHDMFHKF;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3745280", Offset = "0x3744080", VA = "0x183745280")]
	public IDHNMEFONPN(int FNJNELBIPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x37452A0", Offset = "0x37440A0", VA = "0x1837452A0")]
	public IDHNMEFONPN(int FNJNELBIPIL, float LLOCHLCPNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x373ED40", Offset = "0x373DB40", VA = "0x18373ED40")]
	public void JHPNFEHLKNP(byte[] GAMCILOFBAF, T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3738A30", Offset = "0x3737830", VA = "0x183738A30")]
	private bool AHPIAKFMIKP(byte[] GAMCILOFBAF, T PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3743180", Offset = "0x3741F80", VA = "0x183743180")]
	public bool OLBECDHEMJL(ArraySegment<byte> GAMCILOFBAF, [Out] T PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x373DCD0", Offset = "0x373CAD0", VA = "0x18373DCD0")]
	private static ulong HIAPJAAOGIF(byte[] GPMOHKANAAB, int PLIILJHILHI, int PDNIMDHODLH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x373DA60", Offset = "0x373C860", VA = "0x18373DA60")]
	private static int AMGNHDLKOJM(int KGBEAJAIJPH, float LLOCHLCPNDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x373DA90", Offset = "0x373C890", VA = "0x18373DA90", Slot = "4")]
	[IteratorStateMachine(typeof(IDHNMEFONPN<>.GKMNOFPHBOL))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x33B6860", Offset = "0x33B5660", VA = "0x1833B6860", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class MCLMFCIMOMN : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] CEGKGBFKFIE;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] PCKEADILEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int GKJOIODNCLM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool JBNLBALLJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6570C70", Offset = "0x656FA70", VA = "0x186570C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6570CC0", Offset = "0x656FAC0", VA = "0x186570CC0")]
	static MCLMFCIMOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6570F20", Offset = "0x656FD20", VA = "0x186570F20")]
	public MCLMFCIMOMN(byte[] IAKLJINIKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6570B70", Offset = "0x656F970", VA = "0x186570B70")]
	public OpCode ALAFKIEMCHH()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct JFOLPBNANGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid DHGNDNJJJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte CDCFIFOEMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte KBMOALHKJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte PFHECAIGLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte ABPHKGKOGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte GOGLKGMOJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte NGMKIMAFGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte LNPCPAGPLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte NFBGFIHLDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte CJLPCGOACEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte PIFAJKBAIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte FFGAADDACHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte OJDJKAFOGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte KMJBJMBMMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte IBFHAHMFCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte KJECPIPBIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte DHBHHDOEPAC;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] HHJJGLAKDJA;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] OKMLJCCOLJA;

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x656CD30", Offset = "0x656BB30", VA = "0x18656CD30")]
	public JFOLPBNANGE(Guid PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x656CD40", Offset = "0x656BB40", VA = "0x18656CD40")]
	public JFOLPBNANGE(ArraySegment<byte> OCLJKAABMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x656CBA0", Offset = "0x656B9A0", VA = "0x18656CBA0")]
	private static byte LMHDGHINGID(byte[] EHLPPEEOBND, int IJJNFCCAJOB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x656BDD0", Offset = "0x656ABD0", VA = "0x18656BDD0")]
	private static byte EEFPIJFGFIB(byte DCODMCLNKEM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x656BEF0", Offset = "0x656ACF0", VA = "0x18656BEF0")]
	public void FDCGHODCMHC(byte[] BNFLLCFHIAN, int PLIILJHILHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class KOIPCDFBPGN
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x656FBF0", Offset = "0x656E9F0", VA = "0x18656FBF0")]
	public static bool IBDFIKIGBKO(byte HOEIFLHBAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x656FE50", Offset = "0x656EC50", VA = "0x18656FE50")]
	public static bool MPPLLAKODPA(byte HOEIFLHBAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x656FC00", Offset = "0x656EA00", VA = "0x18656FC00")]
	public static sbyte KKLHHKKPIGM(byte[] EHLPPEEOBND, int PLIILJHILHI, [Out] int EHNNNJMEOOA)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x656FCE0", Offset = "0x656EAE0", VA = "0x18656FCE0")]
	public static short MCDMEKGFJOK(byte[] EHLPPEEOBND, int PLIILJHILHI, [Out] int EHNNNJMEOOA)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x656ECE0", Offset = "0x656DAE0", VA = "0x18656ECE0")]
	public static int BKCFCNDMABG(byte[] EHLPPEEOBND, int PLIILJHILHI, [Out] int EHNNNJMEOOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x656EDD0", Offset = "0x656DBD0", VA = "0x18656EDD0")]
	public static long CPJEBBIFPNJ(byte[] EHLPPEEOBND, int PLIILJHILHI, [Out] int EHNNNJMEOOA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x656FEC0", Offset = "0x656ECC0", VA = "0x18656FEC0")]
	public static byte NJBMOJAGGAJ(byte[] EHLPPEEOBND, int PLIILJHILHI, [Out] int EHNNNJMEOOA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x656F830", Offset = "0x656E630", VA = "0x18656F830")]
	public static ushort FIINLPBHLIF(byte[] EHLPPEEOBND, int PLIILJHILHI, [Out] int EHNNNJMEOOA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x656FDD0", Offset = "0x656EBD0", VA = "0x18656FDD0")]
	public static uint MEBPEEKLENG(byte[] EHLPPEEOBND, int PLIILJHILHI, [Out] int EHNNNJMEOOA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x656F8B0", Offset = "0x656E6B0", VA = "0x18656F8B0")]
	public static ulong HJCNNKAGPAG(byte[] EHLPPEEOBND, int PLIILJHILHI, [Out] int EHNNNJMEOOA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x656FF40", Offset = "0x656ED40", VA = "0x18656FF40")]
	public static float OPFECFHDBFA(byte[] EHLPPEEOBND, int PLIILJHILHI, [Out] int EHNNNJMEOOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x656FFB0", Offset = "0x656EDB0", VA = "0x18656FFB0")]
	public static double PAPBJGDENOI(byte[] EHLPPEEOBND, int PLIILJHILHI, [Out] int EHNNNJMEOOA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x656E640", Offset = "0x656D440", VA = "0x18656E640")]
	public static int AIAGGIGKJBJ(byte[] BNFLLCFHIAN, int PLIILJHILHI, ulong PHPDIJICBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x656EE70", Offset = "0x656DC70", VA = "0x18656EE70")]
	public static int EBFBDCOCMEE(byte[] BNFLLCFHIAN, int PLIILJHILHI, long PHPDIJICBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x656F9C0", Offset = "0x656E7C0", VA = "0x18656F9C0")]
	public static bool HPANLKDJACL(byte[] EHLPPEEOBND, int PLIILJHILHI, [Out] int EHNNNJMEOOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class ANGMIEJGFII
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class NOMJHHPCCFP : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8C4CB0", Offset = "0x8C3AB0", VA = "0x1808C4CB0")]
		[DebuggerHidden]
		public NOMJHHPCCFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6574980", Offset = "0x6573780", VA = "0x186574980", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6574440", Offset = "0x6573240", VA = "0x186574440", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x65743F0", Offset = "0x65731F0", VA = "0x1865743F0")]
		private void FKICEAEIDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x65743A0", Offset = "0x65731A0", VA = "0x1865743A0")]
		private void CEJKOOJCMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6574930", Offset = "0x6573730", VA = "0x186574930", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6574870", Offset = "0x6573670", VA = "0x186574870", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6574870", Offset = "0x6573670", VA = "0x186574870", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class OBEBGDCAOMN : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4CB0", Offset = "0x8C3AB0", VA = "0x1808C4CB0")]
		[DebuggerHidden]
		public OBEBGDCAOMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6575260", Offset = "0x6574060", VA = "0x186575260", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6574D20", Offset = "0x6573B20", VA = "0x186574D20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6574CD0", Offset = "0x6573AD0", VA = "0x186574CD0")]
		private void FKICEAEIDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6574C80", Offset = "0x6573A80", VA = "0x186574C80")]
		private void CEJKOOJCMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6575210", Offset = "0x6574010", VA = "0x186575210", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6575150", Offset = "0x6573F50", VA = "0x186575150", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6575150", Offset = "0x6573F50", VA = "0x186575150", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6560550", Offset = "0x655F350", VA = "0x186560550")]
	public static bool INGKMFIDFBD(this TypeInfo AOPDMLJGEMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x65602E0", Offset = "0x655F0E0", VA = "0x1865602E0")]
	public static bool CJBCGPKOLGG(this TypeInfo AOPDMLJGEMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6560610", Offset = "0x655F410", VA = "0x186560610")]
	public static IEnumerable<PropertyInfo> OBANCKECDPG(this Type AOPDMLJGEMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6560410", Offset = "0x655F210", VA = "0x186560410")]
	[IteratorStateMachine(typeof(NOMJHHPCCFP))]
	private static IEnumerable<PropertyInfo> DGGPKIGOOIA(Type AOPDMLJGEMB, HashSet<string> FKCAMCCEHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6560260", Offset = "0x655F060", VA = "0x186560260")]
	public static IEnumerable<FieldInfo> AJMLIAHECMJ(this Type AOPDMLJGEMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x65604B0", Offset = "0x655F2B0", VA = "0x1865604B0")]
	[IteratorStateMachine(typeof(OBEBGDCAOMN))]
	private static IEnumerable<FieldInfo> HOMMGBDOJOI(Type AOPDMLJGEMB, HashSet<string> FKCAMCCEHHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class EFPOPBOCCGA
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding AOAGCLLODBL;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal static class HCBNEHNPFBK
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
	public static string DHJALIOILEM(string CCCJFICLKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6569C30", Offset = "0x6568A30", VA = "0x186569C30")]
	public static string GNFCIJGFCOK(string CCCJFICLKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6569D10", Offset = "0x6568B10", VA = "0x186569D10")]
	public static string OGCHCAKIMCC(string CCCJFICLKCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class BDAINEHBEIF<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class MODFBOIGBHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type OLNAGICFANI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue DHGNDNJJJIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int BPMMCGBJILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public MODFBOIGBHK PFPABELFGLC;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7840", Offset = "0x3CC6640", VA = "0x183CC7840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7730", Offset = "0x3CC6530", VA = "0x183CC7730")]
		private int BMGCAELLGLF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public MODFBOIGBHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class GJHJAHLHPKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public GJHJAHLHPKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xAFA210", Offset = "0xAF9010", VA = "0x180AFA210")]
		internal TValue GNLJLDHMNLM(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private MODFBOIGBHK[] EOHEMNNLNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int ICPPKLAMHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object JBENKBJCCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float LLOCHLCPNDI;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x455E5F0", Offset = "0x455D3F0", VA = "0x18455E5F0")]
	public BDAINEHBEIF(int FNJNELBIPIL = 4, float LLOCHLCPNDI = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x455E140", Offset = "0x455CF40", VA = "0x18455E140")]
	public bool MFJPCMAFKDM(Type GAMCILOFBAF, TValue PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x455DFD0", Offset = "0x455CDD0", VA = "0x18455DFD0")]
	public bool MFJPCMAFKDM(Type GAMCILOFBAF, Func<Type, TValue> OEDNOKADBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x455D740", Offset = "0x455C540", VA = "0x18455D740")]
	private bool AHPIAKFMIKP(Type GAMCILOFBAF, Func<Type, TValue> OEDNOKADBAA, [Out] TValue NNPCMONONDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x455CF90", Offset = "0x455BD90", VA = "0x18455CF90")]
	private bool ACEHILNAIMJ(MODFBOIGBHK[] EOHEMNNLNNE, Type DADDPBJBENK, MODFBOIGBHK FHFHOKACDPK, Func<Type, TValue> OEDNOKADBAA, [Out] TValue NNPCMONONDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x455E270", Offset = "0x455D070", VA = "0x18455E270")]
	public bool OLBECDHEMJL(Type GAMCILOFBAF, [Out] TValue PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x455DE00", Offset = "0x455CC00", VA = "0x18455DE00")]
	public TValue FBOBACIJIMN(Type GAMCILOFBAF, Func<Type, TValue> OEDNOKADBAA)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x373DA60", Offset = "0x373C860", VA = "0x18373DA60")]
	private static int AMGNHDLKOJM(int KGBEAJAIJPH, float LLOCHLCPNDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x455DF50", Offset = "0x455CD50", VA = "0x18455DF50")]
	private static void IPDDMNNGGAD(MODFBOIGBHK FJLECDLOIGK, MODFBOIGBHK PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x455DF50", Offset = "0x455CD50", VA = "0x18455DF50")]
	private static void IPDDMNNGGAD(MODFBOIGBHK[] FJLECDLOIGK, MODFBOIGBHK[] PHPDIJICBJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class JDNLDGDDKJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder FGGLIDHCJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder LCFCMBKACNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object CLPCGINGDBH;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x656BBC0", Offset = "0x656A9C0", VA = "0x18656BBC0")]
	public TypeBuilder CJFFGKPLAEO(string NDLLBBKGIJD, TypeAttributes KPBPKMMGILE, Type BMNEKBHDGLJ, Type[] FLGDFDFBPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x656BCC0", Offset = "0x656AAC0", VA = "0x18656BCC0")]
	public JDNLDGDDKJC(string AEAGDJGPEEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal static class LGLKJNBAHEK
{
	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6570020", Offset = "0x656EE20", VA = "0x186570020")]
	private static MethodInfo BNOIPKIAICH(LambdaExpression IFDGANBILAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x255F3D0", Offset = "0x255E1D0", VA = "0x18255F3D0")]
	public static MethodInfo EGEHGIBDNIL<T>(Expression<Func<T>> IFDGANBILAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x255F3D0", Offset = "0x255E1D0", VA = "0x18255F3D0")]
	public static MethodInfo EGEHGIBDNIL<T, TR>(Expression<Func<T, TR>> IFDGANBILAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x255F3D0", Offset = "0x255E1D0", VA = "0x18255F3D0")]
	public static MethodInfo EGEHGIBDNIL<T>(Expression<Action<T>> IFDGANBILAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x255F3D0", Offset = "0x255E1D0", VA = "0x18255F3D0")]
	public static MethodInfo EGEHGIBDNIL<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> IFDGANBILAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x255F3E0", Offset = "0x255E1E0", VA = "0x18255F3E0")]
	private static MemberInfo GKKILPIJJBN<T>(Expression<T> KFIJLJLHGLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x255F4C0", Offset = "0x255E2C0", VA = "0x18255F4C0")]
	public static PropertyInfo NNNONGGPGAL<T, TR>(Expression<Func<T, TR>> IFDGANBILAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal struct HDLIABDAJPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int POGGKDPIPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool LIEOKPHIFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator GOJOCPEIIHH;

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x656A030", Offset = "0x6568E30", VA = "0x18656A030")]
	public HDLIABDAJPD(ILGenerator GOJOCPEIIHH, int POGGKDPIPDP, bool LIEOKPHIFBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6569FA0", Offset = "0x6568DA0", VA = "0x186569FA0")]
	public HDLIABDAJPD(ILGenerator GOJOCPEIIHH, int POGGKDPIPDP, Type AOPDMLJGEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6569EA0", Offset = "0x6568CA0", VA = "0x186569EA0")]
	public void CNLEFLGHMNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class EHLNDGJJBEO
{
	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6564D80", Offset = "0x6563B80", VA = "0x186564D80")]
	public static void EFACMEBHLAE(this ILGenerator GOJOCPEIIHH, int NGIPPLLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6564F70", Offset = "0x6563D70", VA = "0x186564F70")]
	public static void EFACMEBHLAE(this ILGenerator GOJOCPEIIHH, LocalBuilder OKPGCNEHGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6565B70", Offset = "0x6564970", VA = "0x186565B70")]
	public static void PGJILDNHKAF(this ILGenerator GOJOCPEIIHH, int NGIPPLLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6565D60", Offset = "0x6564B60", VA = "0x186565D60")]
	public static void PGJILDNHKAF(this ILGenerator GOJOCPEIIHH, LocalBuilder OKPGCNEHGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6564FB0", Offset = "0x6563DB0", VA = "0x186564FB0")]
	public static void ELOMBKDMGDK(this ILGenerator GOJOCPEIIHH, int NGIPPLLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6565090", Offset = "0x6563E90", VA = "0x186565090")]
	public static void ELOMBKDMGDK(this ILGenerator GOJOCPEIIHH, LocalBuilder OKPGCNEHGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6565410", Offset = "0x6564210", VA = "0x186565410")]
	public static void JEKFKNADFNM(this ILGenerator GOJOCPEIIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6565DA0", Offset = "0x6564BA0", VA = "0x186565DA0")]
	public static void POOJNPCFOKD(this ILGenerator GOJOCPEIIHH, bool PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6565790", Offset = "0x6564590", VA = "0x186565790")]
	public static void OLMMCGHOFIJ(this ILGenerator GOJOCPEIIHH, int PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x65656B0", Offset = "0x65644B0", VA = "0x1865656B0")]
	public static void NPMDJPJKKNH(this ILGenerator GOJOCPEIIHH, Type AOPDMLJGEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6565420", Offset = "0x6564220", VA = "0x186565420")]
	public static void KFMNNJDDOFI(this ILGenerator GOJOCPEIIHH, Type AOPDMLJGEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x6565220", Offset = "0x6564020", VA = "0x186565220")]
	public static void JBJICCHKBBM(this ILGenerator GOJOCPEIIHH, int NGIPPLLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x65654C0", Offset = "0x65642C0", VA = "0x1865654C0")]
	public static void KGKLCNMLDPG(this ILGenerator GOJOCPEIIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x65655D0", Offset = "0x65643D0", VA = "0x1865655D0")]
	public static void MHEKNCMBFMK(this ILGenerator GOJOCPEIIHH, int NGIPPLLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x6564C90", Offset = "0x6563A90", VA = "0x186564C90")]
	public static void DMOPGAPDOIH(this ILGenerator GOJOCPEIIHH, MethodInfo DGJFLEHENFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x6565540", Offset = "0x6564340", VA = "0x186565540")]
	public static void LJHHNDCONFO(this ILGenerator GOJOCPEIIHH, FieldInfo HOJHNGOFHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6565190", Offset = "0x6563F90", VA = "0x186565190")]
	public static void IOAICIMAAAE(this ILGenerator GOJOCPEIIHH, ulong PHPDIJICBJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class LNAAMFGGNLJ
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class BFPJLPCPOIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public BFPJLPCPOIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6560690", Offset = "0x655F490", VA = "0x186560690")]
		internal bool NMKPMMEMGJJ(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo BDELFPJOGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo POENNLALFNK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string NKCKPGIEOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x770F00", Offset = "0x76FD00", VA = "0x180770F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string BHFPJDEFCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x770C70", Offset = "0x76FA70", VA = "0x180770C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool KIANJCCEKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x65703A0", Offset = "0x656F1A0", VA = "0x1865703A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PDCKKKBEADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7729A0", Offset = "0x7717A0", VA = "0x1807729A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7729B0", Offset = "0x7717B0", VA = "0x1807729B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool NADBLMEIKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x84E320", Offset = "0x84D120", VA = "0x18084E320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x84DD10", Offset = "0x84CB10", VA = "0x18084DD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type OIIFFAPKJEG
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x772C10", Offset = "0x771A10", VA = "0x180772C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x779B70", Offset = "0x778970", VA = "0x180779B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo DDAIHBHGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x772C00", Offset = "0x771A00", VA = "0x180772C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x777020", Offset = "0x775E20", VA = "0x180777020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo CFOJDNHFBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7729F0", Offset = "0x7717F0", VA = "0x1807729F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7729C0", Offset = "0x7717C0", VA = "0x1807729C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo DNEBJKPAGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x779D70", Offset = "0x778B70", VA = "0x180779D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x772BF0", Offset = "0x7719F0", VA = "0x180772BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6570AF0", Offset = "0x656F8F0", VA = "0x186570AF0")]
	protected LNAAMFGGNLJ(Type AOPDMLJGEMB, string NDLLBBKGIJD, string BNHFMLLLIJA, bool DPHDPELJABD, bool JDEKOMGAJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6570820", Offset = "0x656F620", VA = "0x186570820")]
	public LNAAMFGGNLJ(FieldInfo LGEPELKHPCL, string NDLLBBKGIJD, bool HJLCNEDLJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6570930", Offset = "0x656F730", VA = "0x186570930")]
	public LNAAMFGGNLJ(PropertyInfo LGEPELKHPCL, string NDLLBBKGIJD, bool HJLCNEDLJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x65706B0", Offset = "0x656F4B0", VA = "0x1865706B0")]
	private static MethodInfo OLNLLDPPMML(MemberInfo LGEPELKHPCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2568390", Offset = "0x2567190", VA = "0x182568390")]
	public T NMONLJLNCFE<T>(bool KHPDOAEBCAG) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x65703B0", Offset = "0x656F1B0", VA = "0x1865703B0", Slot = "4")]
	public virtual void GDBPGDFNBAP(ILGenerator GOJOCPEIIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6570530", Offset = "0x656F330", VA = "0x186570530", Slot = "5")]
	public virtual void MHFPECBHAGC(ILGenerator GOJOCPEIIHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class PKJNOFJFFCC : LNAAMFGGNLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string JAALACBAAAH;

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6576920", Offset = "0x6575720", VA = "0x186576920")]
	public PKJNOFJFFCC(string NDLLBBKGIJD, string JAALACBAAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6576820", Offset = "0x6575620", VA = "0x186576820", Slot = "4")]
	public override void GDBPGDFNBAP(ILGenerator GOJOCPEIIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x65768D0", Offset = "0x65756D0", VA = "0x1865768D0", Slot = "5")]
	public override void MHFPECBHAGC(ILGenerator GOJOCPEIIHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class HGFGLENJBHF : LNAAMFGGNLJ
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo LONGIDHDLKC;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo LJPKPIJJPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal HDLIABDAJPD BKDEEFOCOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal HDLIABDAJPD LPNCELLKDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal HDLIABDAJPD HIAAFHFNDJG;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x656A850", Offset = "0x6569650", VA = "0x18656A850")]
	public HGFGLENJBHF(string NDLLBBKGIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x656A070", Offset = "0x6568E70", VA = "0x18656A070", Slot = "4")]
	public override void GDBPGDFNBAP(ILGenerator GOJOCPEIIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x656A130", Offset = "0x6568F30", VA = "0x18656A130", Slot = "5")]
	public override void MHFPECBHAGC(ILGenerator GOJOCPEIIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x656A180", Offset = "0x6568F80", VA = "0x18656A180")]
	public void NPGFAHHLMMD(ILGenerator GOJOCPEIIHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class MKPOCHJGKPM
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type OIIFFAPKJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x770F00", Offset = "0x76FD00", VA = "0x180770F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KEFEAKOGBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x81EC90", Offset = "0x81DA90", VA = "0x18081EC90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7717F0", Offset = "0x7705F0", VA = "0x1807717F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool GLIICKNBMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x846DF0", Offset = "0x845BF0", VA = "0x180846DF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x846140", Offset = "0x844F40", VA = "0x180846140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo CMBOLOGGPBM
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x775E10", Offset = "0x774C10", VA = "0x180775E10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x770C80", Offset = "0x76FA80", VA = "0x180770C80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public LNAAMFGGNLJ[] AFEGCJADBIO
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x772C10", Offset = "0x771A10", VA = "0x180772C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x779B70", Offset = "0x778970", VA = "0x180779B70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public LNAAMFGGNLJ[] KPLLKBHDNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x772C00", Offset = "0x771A00", VA = "0x180772C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x777020", Offset = "0x775E20", VA = "0x180777020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6571780", Offset = "0x6570580", VA = "0x186571780")]
	public MKPOCHJGKPM(Type AOPDMLJGEMB, Func<string, string> KFDCFMCJKKH, bool HJLCNEDLJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x65716A0", Offset = "0x65704A0", VA = "0x1865716A0")]
	private static bool FOPEDNHEDPE(IEnumerator<ConstructorInfo> HBHOHMCFDCA, ConstructorInfo EKGBLDGJMHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct EEONGALFDOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong LNHIOGEAOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int HCEKMCLPHGI;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1CD6030", Offset = "0x1CD4E30", VA = "0x181CD6030")]
	public EEONGALFDOE(ulong BNMBFKJAAJH, int LAHEEPOKKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6564BE0", Offset = "0x65639E0", VA = "0x186564BE0")]
	public void NDEDJCBCEDF(EEONGALFDOE LCIDHBCOPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6564BF0", Offset = "0x65639F0", VA = "0x186564BF0")]
	public static EEONGALFDOE NJMDNNDFGJO(EEONGALFDOE ALNGIEPPLJJ, EEONGALFDOE DCODMCLNKEM)
	{
		return default(EEONGALFDOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6564A20", Offset = "0x6563820", VA = "0x186564A20")]
	public void BMDHGNOEAFB(EEONGALFDOE LCIDHBCOPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6564B40", Offset = "0x6563940", VA = "0x186564B40")]
	public static EEONGALFDOE MCJOLPJJIFO(EEONGALFDOE ALNGIEPPLJJ, EEONGALFDOE DCODMCLNKEM)
	{
		return default(EEONGALFDOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6564B00", Offset = "0x6563900", VA = "0x186564B00")]
	public void JCDOMFALIIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6564AB0", Offset = "0x65638B0", VA = "0x186564AB0")]
	public static EEONGALFDOE JCDOMFALIIC(EEONGALFDOE ALNGIEPPLJJ)
	{
		return default(EEONGALFDOE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct NIDJEOMIOKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] BNFLLCFHIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int PLIILJHILHI;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x170FDF0", Offset = "0x170EBF0", VA = "0x18170FDF0")]
	public NIDJEOMIOKO(byte[] BNFLLCFHIAN, int LMGPBOPOFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x65584E0", Offset = "0x65572E0", VA = "0x1865584E0")]
	public void PJHOJNEDCMP(byte MPLLGADEBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6574120", Offset = "0x6572F20", VA = "0x186574120")]
	public void FFDEEBBPJJD(byte[] MPLLGADEBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6573F00", Offset = "0x6572D00", VA = "0x186573F00")]
	public void DHHFDDBHMKM(byte[] MPLLGADEBOG, int ELGJIDFGJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6573F80", Offset = "0x6572D80", VA = "0x186573F80")]
	public void DHHFDDBHMKM(byte[] MPLLGADEBOG, int EIJIJLGPLFO, int ELGJIDFGJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x65741A0", Offset = "0x6572FA0", VA = "0x1865741A0")]
	public void MCPHGMBJFFE(byte HOEIFLHBAKH, int PDNIMDHODLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6574020", Offset = "0x6572E20", VA = "0x186574020")]
	public void FAAGICMIBMD(string MPLLGADEBOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class FBJJHFBCJNI
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum EKFHBIFLHAF
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum OCBJCGEICCM
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private enum GKCHMNKNMEF
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
	private static byte[] FEDLDOEFCFB;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] ELEIIGGGLBM;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] OOFPICFOLNB;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] APMCONJLHOL;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly GKCHMNKNMEF MMBKANCBJCN;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char CHNLDPIDJKN;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int IDGENNEBJAN;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int BODDFIAICCH;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] LMBGDNNMHBG;

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x65673F0", Offset = "0x65661F0", VA = "0x1865673F0")]
	private static byte[] FMOKACMJPOM(int ICPPKLAMHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6568010", Offset = "0x6566E10", VA = "0x186568010")]
	private static byte[] ICIKNLJNELE(int ICPPKLAMHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6567AC0", Offset = "0x65668C0", VA = "0x186567AC0")]
	public static int HJAEDBNGHDF(byte[] BNFLLCFHIAN, int PLIILJHILHI, float PHPDIJICBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x65679A0", Offset = "0x65667A0", VA = "0x1865679A0")]
	public static int HJAEDBNGHDF(byte[] BNFLLCFHIAN, int PLIILJHILHI, double PHPDIJICBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x65678B0", Offset = "0x65666B0", VA = "0x1865678B0")]
	private static bool GMMCHBFHBJH(byte[] BNFLLCFHIAN, int ELGJIDFGJJH, ulong MCKOJAIPLBD, ulong KNALMEDHDJE, ulong NBLCNBBIBLB, ulong IJNCAKLFHJO, ulong LHOEMJICDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x65685D0", Offset = "0x65673D0", VA = "0x1865685D0")]
	private static void MFLPPHADLMF(uint JGOCNJGMCOP, int JHFNAGHFAGG, [Out] uint AGCJOKFDAII, [Out] int HNFPNKKLNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x65674C0", Offset = "0x65662C0", VA = "0x1865674C0")]
	private static bool FNIAAAAAIDI(EEONGALFDOE KBJAOMAMKDL, EEONGALFDOE KHMJGMFIADM, EEONGALFDOE ENNFLBNNLGD, byte[] BNFLLCFHIAN, [Out] int ELGJIDFGJJH, [Out] int BCFCBMGOKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6566F70", Offset = "0x6565D70", VA = "0x186566F70")]
	private static bool ELGGCGFDFKC(double IKEAKMDIHGH, EKFHBIFLHAF JCEEBKDBNOM, byte[] BNFLLCFHIAN, [Out] int ELGJIDFGJJH, [Out] int PLEODFAPJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x65686C0", Offset = "0x65674C0", VA = "0x1865686C0")]
	private static bool ONHENJGDPNM(double IKEAKMDIHGH, EKFHBIFLHAF JCEEBKDBNOM, byte[] BNFLLCFHIAN, [Out] int ELGJIDFGJJH, [Out] int OBLHMPAMCKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6566820", Offset = "0x6565620", VA = "0x186566820")]
	private static bool AJJOCDFDBFH(double PHPDIJICBJO, NIDJEOMIOKO MJILIJAJNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x65680F0", Offset = "0x6566EF0", VA = "0x1865680F0")]
	private static bool JGEOMCNHACF(double PHPDIJICBJO, NIDJEOMIOKO MJILIJAJNDF, OCBJCGEICCM JCEEBKDBNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x65669F0", Offset = "0x65657F0", VA = "0x1865669F0")]
	private static void BJCKBIEADDL(byte[] IGPHCLFIJKM, int ELGJIDFGJJH, int OBLHMPAMCKE, int GAEKAEBOBFF, NIDJEOMIOKO MJILIJAJNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6567BE0", Offset = "0x65669E0", VA = "0x186567BE0")]
	private static void HNKCMDOMKNJ(byte[] IGPHCLFIJKM, int ELGJIDFGJJH, int LAHEEPOKKBI, NIDJEOMIOKO MJILIJAJNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6566D80", Offset = "0x6565B80", VA = "0x186566D80")]
	private static bool BMJGAMDODLE(double IKEAKMDIHGH, OCBJCGEICCM JCEEBKDBNOM, int DBLEOHFPECH, byte[] FOPKDJBJFKF, [Out] bool GPNBHPDFLLF, [Out] int ELGJIDFGJJH, [Out] int MFPMPHOGKHO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct CLFCEAONAFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double JINDDDAPFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong PIAJJHJINOK;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct LOEHDCFJOEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float LNHIOGEAOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint MGAIOMDCLIM;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct FBDILFCHCOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong PCEFDOIHFFE;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6566770", Offset = "0x6565570", VA = "0x186566770")]
	public FBDILFCHCOB(double JINDDDAPFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6566780", Offset = "0x6565580", VA = "0x186566780")]
	public FBDILFCHCOB(EEONGALFDOE JINDDDAPFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6566220", Offset = "0x6565020", VA = "0x186566220")]
	public EEONGALFDOE CFFHDPAOKIM()
	{
		return default(EEONGALFDOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6566380", Offset = "0x6565180", VA = "0x186566380")]
	public EEONGALFDOE FCFKBCFIFEF()
	{
		return default(EEONGALFDOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
	public ulong MPDDBADJFPN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6566480", Offset = "0x6565280", VA = "0x186566480")]
	public double MHGEFIPHJEG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x65662B0", Offset = "0x65650B0", VA = "0x1865662B0")]
	public double DMKMFFNHGKL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6566350", Offset = "0x6565150", VA = "0x186566350")]
	public int ELIHPFGBJGG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6566400", Offset = "0x6565200", VA = "0x186566400")]
	public ulong GOPHKDCBAKG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6566430", Offset = "0x6565230", VA = "0x186566430")]
	public bool LHGDCNHPDOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6566290", Offset = "0x6565090", VA = "0x186566290")]
	public bool CHMJOLPPDAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6566730", Offset = "0x6565530", VA = "0x186566730")]
	public bool PEPFHEAFCOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6566450", Offset = "0x6565250", VA = "0x186566450")]
	public bool LIFAAPHKKJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6566200", Offset = "0x6565000", VA = "0x186566200")]
	public int BOPHOANALKG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6566500", Offset = "0x6565300", VA = "0x186566500")]
	public void NBDACOAFKOJ([Out] EEONGALFDOE KMGMLPHMHLE, [Out] EEONGALFDOE PCOJPMOEHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6566650", Offset = "0x6565450", VA = "0x186566650")]
	public bool OHCJCBOCDOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DE10", Offset = "0x2A9CC10", VA = "0x182A9DE10")]
	public double PHPDIJICBJO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x65661E0", Offset = "0x6564FE0", VA = "0x1865661E0")]
	public static int BNCNGEDCENJ(int HDDJMINMJCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6566760", Offset = "0x6565560", VA = "0x186566760")]
	public static double PGAACFNFMEJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x65666A0", Offset = "0x65654A0", VA = "0x1865666A0")]
	public static ulong OOLJHBOGADH(EEONGALFDOE HBFCNOANHCA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct BHCHPFLCAMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint LIMABKPAION;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x20059B0", Offset = "0x20047B0", VA = "0x1820059B0")]
	public BHCHPFLCAMP(float LNHIOGEAOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x65607A0", Offset = "0x655F5A0", VA = "0x1865607A0")]
	public EEONGALFDOE CFFHDPAOKIM()
	{
		return default(EEONGALFDOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x832500", Offset = "0x831300", VA = "0x180832500")]
	public uint BGMOKJKLJGH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x65607F0", Offset = "0x655F5F0", VA = "0x1865607F0")]
	public int ELIHPFGBJGG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6560810", Offset = "0x655F610", VA = "0x186560810")]
	public uint GOPHKDCBAKG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6560830", Offset = "0x655F630", VA = "0x186560830")]
	public bool LHGDCNHPDOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6560840", Offset = "0x655F640", VA = "0x186560840")]
	public void NBDACOAFKOJ([Out] EEONGALFDOE KMGMLPHMHLE, [Out] EEONGALFDOE PCOJPMOEHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6560970", Offset = "0x655F770", VA = "0x186560970")]
	public bool OHCJCBOCDOP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct PFMLDONBFHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong BNMBFKJAAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short CLHHNOCGNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short PLEODFAPJGO;

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6576810", Offset = "0x6575610", VA = "0x186576810")]
	public PFMLDONBFHK(ulong BNMBFKJAAJH, short CLHHNOCGNEK, short PLEODFAPJGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class NAIIKGFELOH
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly PFMLDONBFHK[] LOGIFAFGJIE;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6572DC0", Offset = "0x6571BC0", VA = "0x186572DC0")]
	public static void MKOPJAKEMGH(int HFAMHPKAIKJ, int OJOJDEMHNJM, [Out] EEONGALFDOE AGCJOKFDAII, [Out] int PLEODFAPJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6572ED0", Offset = "0x6571CD0", VA = "0x186572ED0")]
	public static void OFAEAAIGKEJ(int DPLAIKIBKKL, [Out] EEONGALFDOE AGCJOKFDAII, [Out] int IFAGDKLKEME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[DefaultMember("Item")]
internal struct GAOGGGOKPCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] EHLPPEEOBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int EIJIJLGPLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int AOLJJAADKOA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6568EE0", Offset = "0x6567CE0", VA = "0x186568EE0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x37AF160", Offset = "0x37ADF60", VA = "0x1837AF160")]
	public GAOGGGOKPCM(byte[] EHLPPEEOBND, int EIJIJLGPLFO, int ELGJIDFGJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x2045B80", Offset = "0x2044980", VA = "0x182045B80")]
	public int ELGJIDFGJJH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6568E80", Offset = "0x6567C80", VA = "0x186568E80")]
	public GAOGGGOKPCM GGDBDKEBNFF(int AILENDLDNKM, int GGPAEIENLAM)
	{
		return default(GAOGGGOKPCM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class BOMCFIDKPEP
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] JGNPFCAPBKP;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] LOAAKEPKIMG;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int HKOKMNKONNG;

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6562140", Offset = "0x6560F40", VA = "0x186562140")]
	private static byte[] IBBEHJBKBPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x65625F0", Offset = "0x65613F0", VA = "0x1865625F0")]
	private static GAOGGGOKPCM ODDIDLKOJLO(GAOGGGOKPCM BNFLLCFHIAN)
	{
		return default(GAOGGGOKPCM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x65618F0", Offset = "0x65606F0", VA = "0x1865618F0")]
	private static GAOGGGOKPCM CCBMNLNHBCI(GAOGGGOKPCM BNFLLCFHIAN)
	{
		return default(GAOGGGOKPCM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6561F90", Offset = "0x6560D90", VA = "0x186561F90")]
	private static void HCPCAPPEAOA(GAOGGGOKPCM BNFLLCFHIAN, int LAHEEPOKKBI, byte[] FCDLCMIFHMA, [Out] int OGOLGCDDOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x65619D0", Offset = "0x65607D0", VA = "0x1865619D0")]
	private static void EPKKPFLEDIJ(GAOGGGOKPCM BNFLLCFHIAN, int LAHEEPOKKBI, byte[] BCEGHLJKLDN, int HDADCHGAHPJ, [Out] GAOGGGOKPCM COFAOCKDCPL, [Out] int ALEFCHFNHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6562990", Offset = "0x6561790", VA = "0x186562990")]
	private static ulong PKPGBABFHKN(GAOGGGOKPCM BNFLLCFHIAN, [Out] int BMKKDOHDAFD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x65617B0", Offset = "0x65605B0", VA = "0x1865617B0")]
	private static void BFOPDKDCIFC(GAOGGGOKPCM BNFLLCFHIAN, [Out] EEONGALFDOE OKONIBAEEBP, [Out] int MHIHMPMIPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6562220", Offset = "0x6561020", VA = "0x186562220")]
	private static bool JAENKMHHKMK(GAOGGGOKPCM COFAOCKDCPL, int LAHEEPOKKBI, [Out] double OKONIBAEEBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x65627F0", Offset = "0x65615F0", VA = "0x1865627F0")]
	private static EEONGALFDOE PHFHENIPGGI(int LAHEEPOKKBI)
	{
		return default(EEONGALFDOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6561160", Offset = "0x655FF60", VA = "0x186561160")]
	private static bool BFFJIHBLIHG(GAOGGGOKPCM BNFLLCFHIAN, int LAHEEPOKKBI, [Out] double OKONIBAEEBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6562020", Offset = "0x6560E20", VA = "0x186562020")]
	private static bool HOLMBNJLCJK(GAOGGGOKPCM COFAOCKDCPL, int LAHEEPOKKBI, [Out] double EDCKCJKJNLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x65626D0", Offset = "0x65614D0", VA = "0x1865626D0")]
	public static double? OEEJDLHIPJL(GAOGGGOKPCM BNFLLCFHIAN, int LAHEEPOKKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6561CC0", Offset = "0x6560AC0", VA = "0x186561CC0")]
	public static float? GILGDOINPMI(GAOGGGOKPCM BNFLLCFHIAN, int LAHEEPOKKBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal struct DKIJOCGDJHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] BNFLLCFHIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int PLIILJHILHI;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte DHGNDNJJJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x657BD00", Offset = "0x657AB00", VA = "0x18657BD00")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x170FDF0", Offset = "0x170EBF0", VA = "0x18170FDF0")]
	public DKIJOCGDJHD(byte[] BNFLLCFHIAN, int PLIILJHILHI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x657BD30", Offset = "0x657AB30", VA = "0x18657BD30")]
	public static DKIJOCGDJHD MDHJOHAJBPF(DKIJOCGDJHD HLCOOGAGOEK)
	{
		return default(DKIJOCGDJHD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x657BC00", Offset = "0x657AA00", VA = "0x18657BC00")]
	public static DKIJOCGDJHD EHKMKKDONHB(DKIJOCGDJHD HLCOOGAGOEK, int ELGJIDFGJJH)
	{
		return default(DKIJOCGDJHD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x657BC90", Offset = "0x657AA90", VA = "0x18657BC90")]
	public static int HKDKKKLFCAD(DKIJOCGDJHD KADNMONNONH, DKIJOCGDJHD DCAFNABOJJA)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x657BC80", Offset = "0x657AA80", VA = "0x18657BC80")]
	public static bool HIHGGPGGFPN(DKIJOCGDJHD KADNMONNONH, DKIJOCGDJHD DCAFNABOJJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x657BB90", Offset = "0x657A990", VA = "0x18657BB90")]
	public static bool CAOAIKCPFJO(DKIJOCGDJHD KADNMONNONH, DKIJOCGDJHD DCAFNABOJJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x657BC50", Offset = "0x657AA50", VA = "0x18657BC50")]
	public static bool HIHGGPGGFPN(DKIJOCGDJHD KADNMONNONH, char DCAFNABOJJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x657BBA0", Offset = "0x657A9A0", VA = "0x18657BBA0")]
	public static bool CAOAIKCPFJO(DKIJOCGDJHD KADNMONNONH, char DCAFNABOJJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x657BBA0", Offset = "0x657A9A0", VA = "0x18657BBA0")]
	public static bool CAOAIKCPFJO(DKIJOCGDJHD KADNMONNONH, byte DCAFNABOJJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x657BCD0", Offset = "0x657AAD0", VA = "0x18657BCD0")]
	public static bool JAHJBCOHCDG(DKIJOCGDJHD KADNMONNONH, char DCAFNABOJJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x657BB60", Offset = "0x657A960", VA = "0x18657BB60")]
	public static bool BMCKBOAJFPP(DKIJOCGDJHD KADNMONNONH, char DCAFNABOJJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x657BBD0", Offset = "0x657A9D0", VA = "0x18657BBD0")]
	public static bool CBDLGDGDEEJ(DKIJOCGDJHD KADNMONNONH, char DCAFNABOJJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x657BCA0", Offset = "0x657AAA0", VA = "0x18657BCA0")]
	public static bool IKFGDFJHAFI(DKIJOCGDJHD KADNMONNONH, char DCAFNABOJJA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class DHHGGOKIOPH
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] KJAFDDMKDCD;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] DFKKAJANGKK;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] OOFPICFOLNB;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] APMCONJLHOL;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] DHBILLFMHDI;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int HDNBCFLHKNE;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] GJMLEFNMKFG;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int KMJKFHBFMAI;

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x657A2A0", Offset = "0x65790A0", VA = "0x18657A2A0")]
	private static byte[] DEKINPEKOGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x657B4A0", Offset = "0x657A2A0", VA = "0x18657B4A0")]
	private static byte[] IOCFFCDHONF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x657A450", Offset = "0x6579250", VA = "0x18657A450")]
	public static double GEFMFHBHFDP(byte[] BNFLLCFHIAN, int PLIILJHILHI, [Out] int EHNNNJMEOOA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x657A380", Offset = "0x6579180", VA = "0x18657A380")]
	public static float DGICELMFDLK(byte[] BNFLLCFHIAN, int PLIILJHILHI, [Out] int EHNNNJMEOOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x657B580", Offset = "0x657A380", VA = "0x18657B580")]
	private static bool OBEAIMBIABD(int GPMOHKANAAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x657B6C0", Offset = "0x657A4C0", VA = "0x18657B6C0")]
	private static bool OJPEBJKGFCM(DKIJOCGDJHD ADDAAFAAFCJ, DKIJOCGDJHD GNLJFNAGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x657A500", Offset = "0x6579300", VA = "0x18657A500")]
	private static bool HCCJFHCOMMM(DKIJOCGDJHD ADDAAFAAFCJ, DKIJOCGDJHD GNLJFNAGDPD, byte[] MFJBILAAHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x657B450", Offset = "0x657A250", VA = "0x18657B450")]
	private static bool HODOPEODFKP(DKIJOCGDJHD CNCJANJLMON, byte[] MPLLGADEBOG, int PLIILJHILHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x657A430", Offset = "0x6579230", VA = "0x18657A430")]
	private static double ENGDJPMANIB(bool GPNBHPDFLLF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x657A5D0", Offset = "0x65793D0", VA = "0x18657A5D0")]
	private static double HCNNAHGKHOM(DKIJOCGDJHD JHAPDKALKLI, int ELGJIDFGJJH, bool ECNIHGJEJIH, [Out] int OCPFFMBEOLH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class LKFGACMDFPP<T> : LACGAEMAOIL<T[]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly PKLDONPLNNE<T> MOHPMKKPDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly FMEMJCBJONP IFPJBFDLBFM;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3652BC0", Offset = "0x36519C0", VA = "0x183652BC0")]
	public LKFGACMDFPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
	public LKFGACMDFPP(FMEMJCBJONP IFPJBFDLBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3ABEE60", Offset = "0x3ABDC60", VA = "0x183ABEE60", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, T[] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE2F0", Offset = "0x3ABD0F0", VA = "0x183ABE2F0", Slot = "5")]
	public T[] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class HECDCMMCGIO<T> : LACGAEMAOIL<ArraySegment<T>>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly PKLDONPLNNE<T> MOHPMKKPDBN;

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3634360", Offset = "0x3633160", VA = "0x183634360", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, ArraySegment<T> PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3633F40", Offset = "0x3632D40", VA = "0x183633F40", Slot = "5")]
	public ArraySegment<T> LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class HINDEAPBOCL<T> : LACGAEMAOIL<List<T>>, DNFLPCIHMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly FMEMJCBJONP IFPJBFDLBFM;

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3652BC0", Offset = "0x36519C0", VA = "0x183652BC0")]
	public HINDEAPBOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
	public HINDEAPBOCL(FMEMJCBJONP IFPJBFDLBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x3650C10", Offset = "0x364FA10", VA = "0x183650C10", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, List<T> PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x364F9F0", Offset = "0x364E7F0", VA = "0x18364F9F0", Slot = "5")]
	public List<T> LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class PIJDLIDOOGN<TElement, TIntermediate, TEnumerator, TCollection> : LACGAEMAOIL<TCollection>, DNFLPCIHMPE where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6D20", Offset = "0x3EF5B20", VA = "0x183EF6D20", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, TCollection PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5B20", Offset = "0x3EF4920", VA = "0x183EF5B20", Slot = "5")]
	public TCollection LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator EBJFOGEAMGP(TCollection KFIJLJLHGLL);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate CBILMLOBPDD();

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void JHPNFEHLKNP(TIntermediate BOOJGGDCEKE, int NGIPPLLBEKC, TElement PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection OOBGEKLFCIL(TIntermediate HLGOOBKKNFM);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	protected PIJDLIDOOGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class CIIFLIHKNAD<TElement, TIntermediate, TCollection> : PIJDLIDOOGN<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3F06BE0", Offset = "0x3F059E0", VA = "0x183F06BE0", Slot = "6")]
	protected override IEnumerator<TElement> EBJFOGEAMGP(TCollection KFIJLJLHGLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x30B4680", Offset = "0x30B3480", VA = "0x1830B4680")]
	protected CIIFLIHKNAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public abstract class OAGPCNCPJDC<TElement, TCollection> : CIIFLIHKNAD<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0xCD25D0", Offset = "0xCD13D0", VA = "0x180CD25D0", Slot = "9")]
	protected sealed override TCollection OOBGEKLFCIL(TCollection HLGOOBKKNFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class BGEPCEOBEHA<TElement, TCollection> : OAGPCNCPJDC<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x4568450", Offset = "0x4567250", VA = "0x184568450", Slot = "7")]
	protected override TCollection CBILMLOBPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x4568480", Offset = "0x4567280", VA = "0x184568480", Slot = "8")]
	protected override void JHPNFEHLKNP(TCollection BOOJGGDCEKE, int NGIPPLLBEKC, TElement PHPDIJICBJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class GLHKFEJLKLM<T> : PIJDLIDOOGN<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x35EAC20", Offset = "0x35E9A20", VA = "0x1835EAC20", Slot = "8")]
	protected override void JHPNFEHLKNP(LinkedList<T> BOOJGGDCEKE, int NGIPPLLBEKC, T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0xCD25D0", Offset = "0xCD13D0", VA = "0x180CD25D0", Slot = "9")]
	protected override LinkedList<T> OOBGEKLFCIL(LinkedList<T> HLGOOBKKNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x35EAB40", Offset = "0x35E9940", VA = "0x1835EAB40", Slot = "7")]
	protected override LinkedList<T> CBILMLOBPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x35EABB0", Offset = "0x35E99B0", VA = "0x1835EABB0", Slot = "6")]
	protected override LinkedList<T>.Enumerator EBJFOGEAMGP(LinkedList<T> KFIJLJLHGLL)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class BNIKBPCBLMM<T> : PIJDLIDOOGN<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x35EAC20", Offset = "0x35E9A20", VA = "0x1835EAC20", Slot = "8")]
	protected override void JHPNFEHLKNP(Queue<T> BOOJGGDCEKE, int NGIPPLLBEKC, T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x35EAB40", Offset = "0x35E9940", VA = "0x1835EAB40", Slot = "7")]
	protected override Queue<T> CBILMLOBPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x4562890", Offset = "0x4561690", VA = "0x184562890", Slot = "6")]
	protected override Queue<T>.Enumerator EBJFOGEAMGP(Queue<T> KFIJLJLHGLL)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0xCD25D0", Offset = "0xCD13D0", VA = "0x180CD25D0", Slot = "9")]
	protected override Queue<T> OOBGEKLFCIL(Queue<T> HLGOOBKKNFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class ELOOAHAILBK<T> : PIJDLIDOOGN<T, INCHBDGODKM<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x30FBFD0", Offset = "0x30FADD0", VA = "0x1830FBFD0", Slot = "8")]
	protected override void JHPNFEHLKNP(INCHBDGODKM<T> BOOJGGDCEKE, int NGIPPLLBEKC, T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x30FBF30", Offset = "0x30FAD30", VA = "0x1830FBF30", Slot = "7")]
	protected override INCHBDGODKM<T> CBILMLOBPDD()
	{
		return default(INCHBDGODKM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x30FBF70", Offset = "0x30FAD70", VA = "0x1830FBF70", Slot = "6")]
	protected override Stack<T>.Enumerator EBJFOGEAMGP(Stack<T> KFIJLJLHGLL)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x30FC000", Offset = "0x30FAE00", VA = "0x1830FC000", Slot = "9")]
	protected override Stack<T> OOBGEKLFCIL(INCHBDGODKM<T> HLGOOBKKNFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class BEBCBMGKAAO<T> : PIJDLIDOOGN<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x35EAC20", Offset = "0x35E9A20", VA = "0x1835EAC20", Slot = "8")]
	protected override void JHPNFEHLKNP(HashSet<T> BOOJGGDCEKE, int NGIPPLLBEKC, T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xCD25D0", Offset = "0xCD13D0", VA = "0x180CD25D0", Slot = "9")]
	protected override HashSet<T> OOBGEKLFCIL(HashSet<T> HLGOOBKKNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x35EAB40", Offset = "0x35E9940", VA = "0x1835EAB40", Slot = "7")]
	protected override HashSet<T> CBILMLOBPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4562890", Offset = "0x4561690", VA = "0x184562890", Slot = "6")]
	protected override HashSet<T>.Enumerator EBJFOGEAMGP(HashSet<T> KFIJLJLHGLL)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class AMGEKNICEFD<T> : CIIFLIHKNAD<T, INCHBDGODKM<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x30FBFD0", Offset = "0x30FADD0", VA = "0x1830FBFD0", Slot = "8")]
	protected override void JHPNFEHLKNP(INCHBDGODKM<T> BOOJGGDCEKE, int NGIPPLLBEKC, T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x37B7A00", Offset = "0x37B6800", VA = "0x1837B7A00", Slot = "9")]
	protected override ReadOnlyCollection<T> OOBGEKLFCIL(INCHBDGODKM<T> HLGOOBKKNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x37B79C0", Offset = "0x37B67C0", VA = "0x1837B79C0", Slot = "7")]
	protected override INCHBDGODKM<T> CBILMLOBPDD()
	{
		return default(INCHBDGODKM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class LDPHEHCCANM<T> : CIIFLIHKNAD<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x35EAC20", Offset = "0x35E9A20", VA = "0x1835EAC20", Slot = "8")]
	protected override void JHPNFEHLKNP(List<T> BOOJGGDCEKE, int NGIPPLLBEKC, T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x35EAB40", Offset = "0x35E9940", VA = "0x1835EAB40", Slot = "7")]
	protected override List<T> CBILMLOBPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0xCD25D0", Offset = "0xCD13D0", VA = "0x180CD25D0", Slot = "9")]
	protected override IList<T> OOBGEKLFCIL(List<T> HLGOOBKKNFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class CKMEPAHIKPC<T> : CIIFLIHKNAD<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x35EAC20", Offset = "0x35E9A20", VA = "0x1835EAC20", Slot = "8")]
	protected override void JHPNFEHLKNP(List<T> BOOJGGDCEKE, int NGIPPLLBEKC, T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x35EAB40", Offset = "0x35E9940", VA = "0x1835EAB40", Slot = "7")]
	protected override List<T> CBILMLOBPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0xCD25D0", Offset = "0xCD13D0", VA = "0x180CD25D0", Slot = "9")]
	protected override ICollection<T> OOBGEKLFCIL(List<T> HLGOOBKKNFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class NAEHANAABGM<T> : CIIFLIHKNAD<T, INCHBDGODKM<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x30FBFD0", Offset = "0x30FADD0", VA = "0x1830FBFD0", Slot = "8")]
	protected override void JHPNFEHLKNP(INCHBDGODKM<T> BOOJGGDCEKE, int NGIPPLLBEKC, T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x30FBF30", Offset = "0x30FAD30", VA = "0x1830FBF30", Slot = "7")]
	protected override INCHBDGODKM<T> CBILMLOBPDD()
	{
		return default(INCHBDGODKM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF910", Offset = "0x3CFE710", VA = "0x183CFF910", Slot = "9")]
	protected override IEnumerable<T> OOBGEKLFCIL(INCHBDGODKM<T> HLGOOBKKNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x30C2040", Offset = "0x30C0E40", VA = "0x1830C2040")]
	public NAEHANAABGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class HGGGNBAGGJH<TKey, TElement> : LACGAEMAOIL<IGrouping<TKey, TElement>>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3642910", Offset = "0x3641710", VA = "0x183642910", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, IGrouping<TKey, TElement> PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3642610", Offset = "0x3641410", VA = "0x183642610", Slot = "5")]
	public IGrouping<TKey, TElement> LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class NOFLKPAPBEN<TKey, TElement> : LACGAEMAOIL<ILookup<TKey, TElement>>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3D30EE0", Offset = "0x3D2FCE0", VA = "0x183D30EE0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, ILookup<TKey, TElement> PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3D30B90", Offset = "0x3D2F990", VA = "0x183D30B90", Slot = "5")]
	public ILookup<TKey, TElement> LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class FBIHPJMDOKM<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly TKey GAMCILOFBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly IEnumerable<TElement> JGKKOAMEPPD;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey OLNAGICFANI
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x77D1D0", Offset = "0x77BFD0", VA = "0x18077D1D0")]
	public FBIHPJMDOKM(TKey GAMCILOFBAF, IEnumerable<TElement> JGKKOAMEPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x342C7D0", Offset = "0x342B5D0", VA = "0x18342C7D0", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3143270", Offset = "0x3142070", VA = "0x183143270", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[DefaultMember("Item")]
internal class OMECBJNKEBK<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> OIJEOBEGNPD;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x346C1B0", Offset = "0x346AFB0", VA = "0x18346C1B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76FDF0", VA = "0x180770FF0")]
	public OMECBJNKEBK(Dictionary<TKey, IGrouping<TKey, TElement>> OIJEOBEGNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3E19820", Offset = "0x3E18620", VA = "0x183E19820", Slot = "5")]
	public bool Contains(TKey GAMCILOFBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3E19860", Offset = "0x3E18660", VA = "0x183E19860", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3E19860", Offset = "0x3E18660", VA = "0x183E19860", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class BIEBCDEBHCO<T> : LACGAEMAOIL<T>, DNFLPCIHMPE where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x45EBE60", Offset = "0x45EAC60", VA = "0x1845EBE60", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, T PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x45EBBE0", Offset = "0x45EA9E0", VA = "0x1845EBBE0", Slot = "5")]
	public T LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public BIEBCDEBHCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class NLICPDNLAIN : LACGAEMAOIL<IEnumerable>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly LACGAEMAOIL<IEnumerable> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x65868D0", Offset = "0x65856D0", VA = "0x1865868D0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, IEnumerable PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6586680", Offset = "0x6585480", VA = "0x186586680", Slot = "5")]
	public IEnumerable LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public NLICPDNLAIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class KANBCJIJNOM : LACGAEMAOIL<ICollection>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly LACGAEMAOIL<ICollection> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x6581E50", Offset = "0x6580C50", VA = "0x186581E50", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, ICollection PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6581C00", Offset = "0x6580A00", VA = "0x186581C00", Slot = "5")]
	public ICollection LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public KANBCJIJNOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class ALNNJLKLLBD : LACGAEMAOIL<IList>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly LACGAEMAOIL<IList> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6577C90", Offset = "0x6576A90", VA = "0x186577C90", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, IList PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6577A40", Offset = "0x6576840", VA = "0x186577A40", Slot = "5")]
	public IList LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public ALNNJLKLLBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class LPBPMKBIMEA<T> : CIIFLIHKNAD<T, INCHBDGODKM<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF6F0", Offset = "0x3ACE4F0", VA = "0x183ACF6F0", Slot = "8")]
	protected override void JHPNFEHLKNP(INCHBDGODKM<T> BOOJGGDCEKE, int NGIPPLLBEKC, T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x30FBF30", Offset = "0x30FAD30", VA = "0x1830FBF30", Slot = "7")]
	protected override INCHBDGODKM<T> CBILMLOBPDD()
	{
		return default(INCHBDGODKM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF720", Offset = "0x3ACE520", VA = "0x183ACF720", Slot = "9")]
	protected override IReadOnlyList<T> OOBGEKLFCIL(INCHBDGODKM<T> HLGOOBKKNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x30C19E0", Offset = "0x30C07E0", VA = "0x1830C19E0")]
	public LPBPMKBIMEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class OBMMGIHNIDB
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6588400", Offset = "0x6587200", VA = "0x186588400")]
	public static DateTime CDLDPMGNNKH(DateTime AEHIOJELKHL)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class EDDOCPDKIBK : LACGAEMAOIL<DateTime>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public static readonly LACGAEMAOIL<DateTime> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x657CD90", Offset = "0x657BB90", VA = "0x18657CD90", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, DateTime PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x657C080", Offset = "0x657AE80", VA = "0x18657C080", Slot = "5")]
	public DateTime LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public EDDOCPDKIBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class NNMALBAOOCD : LACGAEMAOIL<DateTimeOffset>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly LACGAEMAOIL<DateTimeOffset> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6587A80", Offset = "0x6586880", VA = "0x186587A80", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, DateTimeOffset PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6586E60", Offset = "0x6585C60", VA = "0x186586E60", Slot = "5")]
	public DateTimeOffset LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public NNMALBAOOCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class NLDNEINMMGD : LACGAEMAOIL<TimeSpan>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public static readonly LACGAEMAOIL<TimeSpan> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static byte[] AMFPINEGIGK;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x6586140", Offset = "0x6584F40", VA = "0x186586140", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, TimeSpan PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x6585830", Offset = "0x6584630", VA = "0x186585830", Slot = "5")]
	public TimeSpan LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public NLDNEINMMGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public abstract class HDBCLJLPNLP<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : LACGAEMAOIL<TDictionary>, DNFLPCIHMPE where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x362D7A0", Offset = "0x362C5A0", VA = "0x18362D7A0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, TDictionary PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x362C930", Offset = "0x362B730", VA = "0x18362C930", Slot = "5")]
	public TDictionary LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator EBJFOGEAMGP(TDictionary KFIJLJLHGLL);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate CBILMLOBPDD();

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void JHPNFEHLKNP(TIntermediate BOOJGGDCEKE, int NGIPPLLBEKC, TKey GAMCILOFBAF, TValue PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary OOBGEKLFCIL(TIntermediate HLGOOBKKNFM);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	protected HDBCLJLPNLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class PMDGOLPGHOO<TKey, TValue, TIntermediate, TDictionary> : HDBCLJLPNLP<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x3F06BE0", Offset = "0x3F059E0", VA = "0x183F06BE0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> EBJFOGEAMGP(TDictionary KFIJLJLHGLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class AKGNAHDOBKB<TKey, TValue, TDictionary> : PMDGOLPGHOO<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0xCD25D0", Offset = "0xCD13D0", VA = "0x180CD25D0", Slot = "9")]
	protected override TDictionary OOBGEKLFCIL(TDictionary HLGOOBKKNFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class DDAGJBGMGIF<TKey, TValue> : HDBCLJLPNLP<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x4D7A000", Offset = "0x4D78E00", VA = "0x184D7A000", Slot = "8")]
	protected override void JHPNFEHLKNP(Dictionary<TKey, TValue> BOOJGGDCEKE, int NGIPPLLBEKC, TKey GAMCILOFBAF, TValue PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0xCD25D0", Offset = "0xCD13D0", VA = "0x180CD25D0", Slot = "9")]
	protected override Dictionary<TKey, TValue> OOBGEKLFCIL(Dictionary<TKey, TValue> HLGOOBKKNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x35EAB40", Offset = "0x35E9940", VA = "0x1835EAB40", Slot = "7")]
	protected override Dictionary<TKey, TValue> CBILMLOBPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x362C2A0", Offset = "0x362B0A0", VA = "0x18362C2A0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator EBJFOGEAMGP(Dictionary<TKey, TValue> KFIJLJLHGLL)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x30B3970", Offset = "0x30B2770", VA = "0x1830B3970")]
	public DDAGJBGMGIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class KMNHHLBLFDD<TKey, TValue, TDictionary> : AKGNAHDOBKB<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x3A42100", Offset = "0x3A40F00", VA = "0x183A42100", Slot = "8")]
	protected override void JHPNFEHLKNP(TDictionary BOOJGGDCEKE, int NGIPPLLBEKC, TKey GAMCILOFBAF, TValue PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2F64880", Offset = "0x2F63680", VA = "0x182F64880", Slot = "7")]
	protected override TDictionary CBILMLOBPDD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class NDCKKNBKLJO<TKey, TValue> : PMDGOLPGHOO<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x362C310", Offset = "0x362B110", VA = "0x18362C310", Slot = "8")]
	protected override void JHPNFEHLKNP(Dictionary<TKey, TValue> BOOJGGDCEKE, int NGIPPLLBEKC, TKey GAMCILOFBAF, TValue PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x35EAB40", Offset = "0x35E9940", VA = "0x1835EAB40", Slot = "7")]
	protected override Dictionary<TKey, TValue> CBILMLOBPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0xCD25D0", Offset = "0xCD13D0", VA = "0x180CD25D0", Slot = "9")]
	protected override IDictionary<TKey, TValue> OOBGEKLFCIL(Dictionary<TKey, TValue> HLGOOBKKNFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class KDBPOBOMOGH<TKey, TValue> : AKGNAHDOBKB<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x362C310", Offset = "0x362B110", VA = "0x18362C310", Slot = "8")]
	protected override void JHPNFEHLKNP(SortedList<TKey, TValue> BOOJGGDCEKE, int NGIPPLLBEKC, TKey GAMCILOFBAF, TValue PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x35EAB40", Offset = "0x35E9940", VA = "0x1835EAB40", Slot = "7")]
	protected override SortedList<TKey, TValue> CBILMLOBPDD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class HCJPGIALKJB<TKey, TValue> : HDBCLJLPNLP<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x362C310", Offset = "0x362B110", VA = "0x18362C310", Slot = "8")]
	protected override void JHPNFEHLKNP(SortedDictionary<TKey, TValue> BOOJGGDCEKE, int NGIPPLLBEKC, TKey GAMCILOFBAF, TValue PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0xCD25D0", Offset = "0xCD13D0", VA = "0x180CD25D0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> OOBGEKLFCIL(SortedDictionary<TKey, TValue> HLGOOBKKNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x35EAB40", Offset = "0x35E9940", VA = "0x1835EAB40", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> CBILMLOBPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x362C2A0", Offset = "0x362B0A0", VA = "0x18362C2A0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator EBJFOGEAMGP(SortedDictionary<TKey, TValue> KFIJLJLHGLL)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class MNJBMHCPMOA<T> : LACGAEMAOIL<T>, DNFLPCIHMPE where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6FE0", Offset = "0x3CC5DE0", VA = "0x183CC6FE0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, T PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6D40", Offset = "0x3CC5B40", VA = "0x183CC6D40", Slot = "5")]
	public T LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public MNJBMHCPMOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class EJEDDBLACBN : LACGAEMAOIL<IDictionary>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public static readonly LACGAEMAOIL<IDictionary> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x657DBF0", Offset = "0x657C9F0", VA = "0x18657DBF0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, IDictionary PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x657D9C0", Offset = "0x657C7C0", VA = "0x18657D9C0", Slot = "5")]
	public IDictionary LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public EJEDDBLACBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class MIIBCBDMLKK : LACGAEMAOIL<object>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private delegate void DBGGENKADEP(object MLAKLFOMOOP, NDKEFDAFPOB NEGHIHACAHG, object PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private readonly BDAINEHBEIF<KeyValuePair<object, DBGGENKADEP>> PLPIDMPBDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private readonly CHFBNEPGHDG[] DEAJAGEGCCD;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x6584330", Offset = "0x6583130", VA = "0x186584330")]
	public MIIBCBDMLKK(params CHFBNEPGHDG[] DEAJAGEGCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6583970", Offset = "0x6582770", VA = "0x186583970", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, object PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x65838E0", Offset = "0x65826E0", VA = "0x1865838E0", Slot = "5")]
	public object LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class FFKJEPAMHLM
{
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x657E330", Offset = "0x657D130", VA = "0x18657E330")]
	public static object FIJJPCODLJI(Type AOPDMLJGEMB, [Out] bool LIMMJOKOLCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x657EC20", Offset = "0x657DA20", VA = "0x18657EC20")]
	public static object HNEDGFJCKOE(Type AOPDMLJGEMB, [Out] bool LIMMJOKOLCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public class AAPDLFLNIEC<T> : LACGAEMAOIL<T>, DNFLPCIHMPE, DOLLIKCIPDC<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class LBIDBFPDCHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public LBIDBFPDCHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x3AA2280", Offset = "0x3AA1080", VA = "0x183AA2280")]
		internal bool APBGDAIEMCM(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class OPPDFIELBCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public OPPDFIELBCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x3E2FEF0", Offset = "0x3E2ECF0", VA = "0x183E2FEF0")]
		internal bool ENECOEKKKIB(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class COCHJCLPJMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public KHFHGIIPKKK<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public COCHJCLPJMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x49C0E50", Offset = "0x49BFC50", VA = "0x1849C0E50")]
		internal void HFEHHFNHOON(NDKEFDAFPOB writer, T value, CHFBNEPGHDG _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class HFPOOMHMJMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public GNGBFNIEGKB<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public HFPOOMHMJMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x363C520", Offset = "0x363B320", VA = "0x18363C520")]
		internal T LIEPGPKKNOG(PHKIJIILNBG reader, CHFBNEPGHDG _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly IDHNMEFONPN<T> BPNILKCCAKD;

	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private static readonly Dictionary<T, string> NAOEMGCBJJO;

	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private static readonly KHFHGIIPKKK<T> OOGAFMPKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private static readonly GNGBFNIEGKB<T> BOLJGLAIAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private readonly bool FONKGMHGFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private readonly KHFHGIIPKKK<T> POFKFCKPLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private readonly GNGBFNIEGKB<T> DNONFJMOBCO;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3547880", Offset = "0x3546680", VA = "0x183547880")]
	static AAPDLFLNIEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3548AD0", Offset = "0x35478D0", VA = "0x183548AD0")]
	public AAPDLFLNIEC(bool FONKGMHGFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x353BDA0", Offset = "0x353ABA0", VA = "0x18353BDA0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, T PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3539550", Offset = "0x3538350", VA = "0x183539550", Slot = "5")]
	public T LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3538130", Offset = "0x3536F30", VA = "0x183538130", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, T PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x35377E0", Offset = "0x35365E0", VA = "0x1835377E0", Slot = "7")]
	public T EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class MGOKCDCIEKO<T> : LACGAEMAOIL<T[,]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3CA4F50", Offset = "0x3CA3D50", VA = "0x183CA4F50", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, T[,] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3CA4C20", Offset = "0x3CA3A20", VA = "0x183CA4C20", Slot = "5")]
	public T[,] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public MGOKCDCIEKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class KFKDJLAONPF<T> : LACGAEMAOIL<T[,,]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3A37240", Offset = "0x3A36040", VA = "0x183A37240", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, T[,,] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3A36E00", Offset = "0x3A35C00", VA = "0x183A36E00", Slot = "5")]
	public T[,,] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public KFKDJLAONPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class DAGFLKGJGHN<T> : LACGAEMAOIL<T[,,,]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x4D68AD0", Offset = "0x4D678D0", VA = "0x184D68AD0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, T[,,,] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x4D68580", Offset = "0x4D67380", VA = "0x184D68580", Slot = "5")]
	public T[,,,] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public DAGFLKGJGHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class ECPAIAHJOPB<T> : LACGAEMAOIL<T?>, DNFLPCIHMPE where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x30D0C60", Offset = "0x30CFA60", VA = "0x1830D0C60", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, T? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x30D08E0", Offset = "0x30CF6E0", VA = "0x1830D08E0", Slot = "5")]
	public T? LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public ECPAIAHJOPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class EJKMHPDBDBH<T> : LACGAEMAOIL<T?>, DNFLPCIHMPE where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly LACGAEMAOIL<T> PHKIEMGBLNJ;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76FDF0", VA = "0x180770FF0")]
	public EJKMHPDBDBH(LACGAEMAOIL<T> PHKIEMGBLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x30F92A0", Offset = "0x30F80A0", VA = "0x1830F92A0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, T? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x30F7B30", Offset = "0x30F6930", VA = "0x1830F7B30", Slot = "5")]
	public T? LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class GKHCBHKALBB : LACGAEMAOIL<sbyte>, DNFLPCIHMPE, DOLLIKCIPDC<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly GKHCBHKALBB PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x65800E0", Offset = "0x657EEE0", VA = "0x1865800E0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, sbyte PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6580090", Offset = "0x657EE90", VA = "0x186580090", Slot = "5")]
	public sbyte LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6580020", Offset = "0x657EE20", VA = "0x186580020", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, sbyte PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x657FF60", Offset = "0x657ED60", VA = "0x18657FF60", Slot = "7")]
	public sbyte EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public GKHCBHKALBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class IIOFBJOGNOM : LACGAEMAOIL<sbyte?>, DNFLPCIHMPE, DOLLIKCIPDC<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly IIOFBJOGNOM PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6580FA0", Offset = "0x657FDA0", VA = "0x186580FA0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, sbyte? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6580EF0", Offset = "0x657FCF0", VA = "0x186580EF0", Slot = "5")]
	public sbyte? LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6580E30", Offset = "0x657FC30", VA = "0x186580E30", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, sbyte? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6580D10", Offset = "0x657FB10", VA = "0x186580D10", Slot = "7")]
	public sbyte? EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public IIOFBJOGNOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class DOAMFKFHEIC : LACGAEMAOIL<sbyte[]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly DOAMFKFHEIC PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x657BED0", Offset = "0x657ACD0", VA = "0x18657BED0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, sbyte[] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x657BD40", Offset = "0x657AB40", VA = "0x18657BD40", Slot = "5")]
	public sbyte[] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public DOAMFKFHEIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class GFMNENFPMDO : LACGAEMAOIL<short>, DNFLPCIHMPE, DOLLIKCIPDC<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly GFMNENFPMDO PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x657FE80", Offset = "0x657EC80", VA = "0x18657FE80", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, short PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x657FE30", Offset = "0x657EC30", VA = "0x18657FE30", Slot = "5")]
	public short LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x657FDC0", Offset = "0x657EBC0", VA = "0x18657FDC0", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, short PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x657FD00", Offset = "0x657EB00", VA = "0x18657FD00", Slot = "7")]
	public short EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public GFMNENFPMDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class HKNNHIOGIIJ : LACGAEMAOIL<short?>, DNFLPCIHMPE, DOLLIKCIPDC<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly HKNNHIOGIIJ PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6580970", Offset = "0x657F770", VA = "0x186580970", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, short? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x65808C0", Offset = "0x657F6C0", VA = "0x1865808C0", Slot = "5")]
	public short? LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x6580800", Offset = "0x657F600", VA = "0x186580800", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, short? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x65806E0", Offset = "0x657F4E0", VA = "0x1865806E0", Slot = "7")]
	public short? EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public HKNNHIOGIIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class LMDOHKKOBAM : LACGAEMAOIL<short[]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly LMDOHKKOBAM PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6582CE0", Offset = "0x6581AE0", VA = "0x186582CE0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, short[] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6582B50", Offset = "0x6581950", VA = "0x186582B50", Slot = "5")]
	public short[] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public LMDOHKKOBAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class DFMFIKMAMCL : LACGAEMAOIL<int>, DNFLPCIHMPE, DOLLIKCIPDC<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly DFMFIKMAMCL PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x657A1C0", Offset = "0x6578FC0", VA = "0x18657A1C0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, int PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x657A170", Offset = "0x6578F70", VA = "0x18657A170", Slot = "5")]
	public int LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x657A100", Offset = "0x6578F00", VA = "0x18657A100", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, int PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x657A040", Offset = "0x6578E40", VA = "0x18657A040", Slot = "7")]
	public int EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public DFMFIKMAMCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class JGEKLCGNKCI : LACGAEMAOIL<int?>, DNFLPCIHMPE, DOLLIKCIPDC<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly JGEKLCGNKCI PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6581AC0", Offset = "0x65808C0", VA = "0x186581AC0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, int? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6581A10", Offset = "0x6580810", VA = "0x186581A10", Slot = "5")]
	public int? LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x6581950", Offset = "0x6580750", VA = "0x186581950", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, int? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x6581830", Offset = "0x6580630", VA = "0x186581830", Slot = "7")]
	public int? EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public JGEKLCGNKCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class PBJINOOPNAE : LACGAEMAOIL<int[]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly PBJINOOPNAE PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x65894B0", Offset = "0x65882B0", VA = "0x1865894B0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, int[] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x6589320", Offset = "0x6588120", VA = "0x186589320", Slot = "5")]
	public int[] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public PBJINOOPNAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class IDHHHDNLIGE : LACGAEMAOIL<long>, DNFLPCIHMPE, DOLLIKCIPDC<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly IDHHHDNLIGE PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6580C30", Offset = "0x657FA30", VA = "0x186580C30", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, long PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x6580BE0", Offset = "0x657F9E0", VA = "0x186580BE0", Slot = "5")]
	public long LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x6580B70", Offset = "0x657F970", VA = "0x186580B70", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, long PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x6580AB0", Offset = "0x657F8B0", VA = "0x186580AB0", Slot = "7")]
	public long EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public IDHHHDNLIGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class EFMOEJLCADM : LACGAEMAOIL<long?>, DNFLPCIHMPE, DOLLIKCIPDC<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly EFMOEJLCADM PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x657D880", Offset = "0x657C680", VA = "0x18657D880", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, long? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x657D7C0", Offset = "0x657C5C0", VA = "0x18657D7C0", Slot = "5")]
	public long? LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x657D700", Offset = "0x657C500", VA = "0x18657D700", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, long? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x657D5C0", Offset = "0x657C3C0", VA = "0x18657D5C0", Slot = "7")]
	public long? EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public EFMOEJLCADM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class LCEGFGEOJLM : LACGAEMAOIL<long[]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly LCEGFGEOJLM PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x6582400", Offset = "0x6581200", VA = "0x186582400", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, long[] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6582270", Offset = "0x6581070", VA = "0x186582270", Slot = "5")]
	public long[] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public LCEGFGEOJLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class NOIBGEHMAKD : LACGAEMAOIL<byte>, DNFLPCIHMPE, DOLLIKCIPDC<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly NOIBGEHMAKD PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6588320", Offset = "0x6587120", VA = "0x186588320", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, byte PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x65882D0", Offset = "0x65870D0", VA = "0x1865882D0", Slot = "5")]
	public byte LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6588260", Offset = "0x6587060", VA = "0x186588260", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, byte PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x65881A0", Offset = "0x6586FA0", VA = "0x1865881A0", Slot = "7")]
	public byte EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public NOIBGEHMAKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class MECNOPJICHJ : LACGAEMAOIL<byte?>, DNFLPCIHMPE, DOLLIKCIPDC<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly MECNOPJICHJ PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x6583380", Offset = "0x6582180", VA = "0x186583380", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, byte? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x65832D0", Offset = "0x65820D0", VA = "0x1865832D0", Slot = "5")]
	public byte? LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x6583210", Offset = "0x6582010", VA = "0x186583210", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, byte? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x65830F0", Offset = "0x6581EF0", VA = "0x1865830F0", Slot = "7")]
	public byte? EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public MECNOPJICHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class LIDFAPADIEJ : LACGAEMAOIL<ushort>, DNFLPCIHMPE, DOLLIKCIPDC<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly LIDFAPADIEJ PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6582A70", Offset = "0x6581870", VA = "0x186582A70", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, ushort PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x6582A20", Offset = "0x6581820", VA = "0x186582A20", Slot = "5")]
	public ushort LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x65829B0", Offset = "0x65817B0", VA = "0x1865829B0", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, ushort PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x65828F0", Offset = "0x65816F0", VA = "0x1865828F0", Slot = "7")]
	public ushort EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public LIDFAPADIEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class NGHHFMFJNED : LACGAEMAOIL<ushort?>, DNFLPCIHMPE, DOLLIKCIPDC<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly NGHHFMFJNED PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6584F90", Offset = "0x6583D90", VA = "0x186584F90", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, ushort? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x6584EE0", Offset = "0x6583CE0", VA = "0x186584EE0", Slot = "5")]
	public ushort? LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6584E20", Offset = "0x6583C20", VA = "0x186584E20", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, ushort? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x6584D00", Offset = "0x6583B00", VA = "0x186584D00", Slot = "7")]
	public ushort? EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public NGHHFMFJNED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class NKFGKPHDDDM : LACGAEMAOIL<ushort[]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly NKFGKPHDDDM PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6585680", Offset = "0x6584480", VA = "0x186585680", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, ushort[] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x65854F0", Offset = "0x65842F0", VA = "0x1865854F0", Slot = "5")]
	public ushort[] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public NKFGKPHDDDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class NNEFILGKAHM : LACGAEMAOIL<uint>, DNFLPCIHMPE, DOLLIKCIPDC<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly NNEFILGKAHM PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6586D80", Offset = "0x6585B80", VA = "0x186586D80", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, uint PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6586D30", Offset = "0x6585B30", VA = "0x186586D30", Slot = "5")]
	public uint LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6586CC0", Offset = "0x6585AC0", VA = "0x186586CC0", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, uint PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6586C00", Offset = "0x6585A00", VA = "0x186586C00", Slot = "7")]
	public uint EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public NNEFILGKAHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class OFLDOBKADDK : LACGAEMAOIL<uint?>, DNFLPCIHMPE, DOLLIKCIPDC<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly OFLDOBKADDK PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6588750", Offset = "0x6587550", VA = "0x186588750", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, uint? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x65886A0", Offset = "0x65874A0", VA = "0x1865886A0", Slot = "5")]
	public uint? LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x65885E0", Offset = "0x65873E0", VA = "0x1865885E0", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, uint? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x65884C0", Offset = "0x65872C0", VA = "0x1865884C0", Slot = "7")]
	public uint? EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public OFLDOBKADDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class LDBFJENNLPP : LACGAEMAOIL<uint[]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly LDBFJENNLPP PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6582740", Offset = "0x6581540", VA = "0x186582740", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, uint[] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x65825B0", Offset = "0x65813B0", VA = "0x1865825B0", Slot = "5")]
	public uint[] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public LDBFJENNLPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class LMKDBMJFCBP : LACGAEMAOIL<ulong>, DNFLPCIHMPE, DOLLIKCIPDC<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly LMKDBMJFCBP PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6583010", Offset = "0x6581E10", VA = "0x186583010", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, ulong PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6582FC0", Offset = "0x6581DC0", VA = "0x186582FC0", Slot = "5")]
	public ulong LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6582F50", Offset = "0x6581D50", VA = "0x186582F50", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, ulong PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x6582E90", Offset = "0x6581C90", VA = "0x186582E90", Slot = "7")]
	public ulong EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public LMKDBMJFCBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class IOJLBPDFOGN : LACGAEMAOIL<ulong?>, DNFLPCIHMPE, DOLLIKCIPDC<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly IOJLBPDFOGN PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x65813A0", Offset = "0x65801A0", VA = "0x1865813A0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, ulong? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x65812E0", Offset = "0x65800E0", VA = "0x1865812E0", Slot = "5")]
	public ulong? LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6581220", Offset = "0x6580020", VA = "0x186581220", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, ulong? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x65810E0", Offset = "0x657FEE0", VA = "0x1865810E0", Slot = "7")]
	public ulong? EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public IOJLBPDFOGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class NAJLLCDAGAM : LACGAEMAOIL<ulong[]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly NAJLLCDAGAM PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6584570", Offset = "0x6583370", VA = "0x186584570", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, ulong[] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x65843E0", Offset = "0x65831E0", VA = "0x1865843E0", Slot = "5")]
	public ulong[] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public NAJLLCDAGAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class CKGAKDMHLGC : LACGAEMAOIL<float>, DNFLPCIHMPE, DOLLIKCIPDC<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly CKGAKDMHLGC PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6579E10", Offset = "0x6578C10", VA = "0x186579E10", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, float PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6579DC0", Offset = "0x6578BC0", VA = "0x186579DC0", Slot = "5")]
	public float LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x6579D50", Offset = "0x6578B50", VA = "0x186579D50", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, float PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x6579C90", Offset = "0x6578A90", VA = "0x186579C90", Slot = "7")]
	public float EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public CKGAKDMHLGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class PHCKCPJHPGM : LACGAEMAOIL<float?>, DNFLPCIHMPE, DOLLIKCIPDC<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly PHCKCPJHPGM PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6589F00", Offset = "0x6588D00", VA = "0x186589F00", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, float? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6589E50", Offset = "0x6588C50", VA = "0x186589E50", Slot = "5")]
	public float? LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6589D90", Offset = "0x6588B90", VA = "0x186589D90", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, float? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x6589C70", Offset = "0x6588A70", VA = "0x186589C70", Slot = "7")]
	public float? EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public PHCKCPJHPGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class IONPFJCJOFC : LACGAEMAOIL<float[]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly IONPFJCJOFC PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6581670", Offset = "0x6580470", VA = "0x186581670", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, float[] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x65814E0", Offset = "0x65802E0", VA = "0x1865814E0", Slot = "5")]
	public float[] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public IONPFJCJOFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class CJAKOANCCLA : LACGAEMAOIL<double>, DNFLPCIHMPE, DOLLIKCIPDC<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly CJAKOANCCLA PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6579A00", Offset = "0x6578800", VA = "0x186579A00", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, double PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x65799B0", Offset = "0x65787B0", VA = "0x1865799B0", Slot = "5")]
	public double LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6579940", Offset = "0x6578740", VA = "0x186579940", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, double PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6579880", Offset = "0x6578680", VA = "0x186579880", Slot = "7")]
	public double EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public CJAKOANCCLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class OFOEJFIJFEF : LACGAEMAOIL<double?>, DNFLPCIHMPE, DOLLIKCIPDC<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly OFOEJFIJFEF PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6588B50", Offset = "0x6587950", VA = "0x186588B50", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, double? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6588A90", Offset = "0x6587890", VA = "0x186588A90", Slot = "5")]
	public double? LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x65889D0", Offset = "0x65877D0", VA = "0x1865889D0", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, double? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6588890", Offset = "0x6587690", VA = "0x186588890", Slot = "7")]
	public double? EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public OFOEJFIJFEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class AKEAEPMFNEO : LACGAEMAOIL<double[]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly AKEAEPMFNEO PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6577880", Offset = "0x6576680", VA = "0x186577880", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, double[] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x65776F0", Offset = "0x65764F0", VA = "0x1865776F0", Slot = "5")]
	public double[] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public AKEAEPMFNEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class NEEFKLDCGAI : LACGAEMAOIL<bool>, DNFLPCIHMPE, DOLLIKCIPDC<bool>
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly NEEFKLDCGAI PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x65848A0", Offset = "0x65836A0", VA = "0x1865848A0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, bool PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6584850", Offset = "0x6583650", VA = "0x186584850", Slot = "5")]
	public bool LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x65847E0", Offset = "0x65835E0", VA = "0x1865847E0", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, bool PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6584720", Offset = "0x6583520", VA = "0x186584720", Slot = "7")]
	public bool EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public NEEFKLDCGAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class OONLOBBLAON : LACGAEMAOIL<bool?>, DNFLPCIHMPE, DOLLIKCIPDC<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly OONLOBBLAON PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6588F20", Offset = "0x6587D20", VA = "0x186588F20", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, bool? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6588E70", Offset = "0x6587C70", VA = "0x186588E70", Slot = "5")]
	public bool? LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6588DB0", Offset = "0x6587BB0", VA = "0x186588DB0", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, bool? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6588C90", Offset = "0x6587A90", VA = "0x186588C90", Slot = "7")]
	public bool? EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public OONLOBBLAON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class ANKLDCKAIME : LACGAEMAOIL<bool[]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly ANKLDCKAIME PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x65796C0", Offset = "0x65784C0", VA = "0x1865796C0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, bool[] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6579530", Offset = "0x6578330", VA = "0x186579530", Slot = "5")]
	public bool[] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public ANKLDCKAIME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class AMHIJKEABGD : LACGAEMAOIL<object>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly LACGAEMAOIL<object> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly Dictionary<Type, int> ANGOOFHNFPA;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6578480", Offset = "0x6577280", VA = "0x186578480", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, object PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6578040", Offset = "0x6576E40", VA = "0x186578040", Slot = "5")]
	public object LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public AMHIJKEABGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class AAHCMFHHAGF : LACGAEMAOIL<byte[]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly LACGAEMAOIL<byte[]> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x65770E0", Offset = "0x6575EE0", VA = "0x1865770E0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, byte[] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6577030", Offset = "0x6575E30", VA = "0x186577030", Slot = "5")]
	public byte[] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public AAHCMFHHAGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class PBHBPIKKOJL : LACGAEMAOIL<ArraySegment<byte>>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly LACGAEMAOIL<ArraySegment<byte>> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6589170", Offset = "0x6587F70", VA = "0x186589170", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, ArraySegment<byte> PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6589060", Offset = "0x6587E60", VA = "0x186589060", Slot = "5")]
	public ArraySegment<byte> LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public PBHBPIKKOJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class EJFKADFCNJM : LACGAEMAOIL<string>, DNFLPCIHMPE, DOLLIKCIPDC<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly LACGAEMAOIL<string> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x657E250", Offset = "0x657D050", VA = "0x18657E250", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, string PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x657E200", Offset = "0x657D000", VA = "0x18657E200", Slot = "5")]
	public string LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x657E1A0", Offset = "0x657CFA0", VA = "0x18657E1A0", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, string PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x657E150", Offset = "0x657CF50", VA = "0x18657E150", Slot = "7")]
	public string EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public EJFKADFCNJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class NFHHABPJIOJ : LACGAEMAOIL<string[]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly NFHHABPJIOJ PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6584B50", Offset = "0x6583950", VA = "0x186584B50", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, string[] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6584980", Offset = "0x6583780", VA = "0x186584980", Slot = "5")]
	public string[] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public NFHHABPJIOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class CKABCLBGAFF : LACGAEMAOIL<char>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly CKABCLBGAFF PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6579B50", Offset = "0x6578950", VA = "0x186579B50", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, char PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6579AE0", Offset = "0x65788E0", VA = "0x186579AE0", Slot = "5")]
	public char LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public CKABCLBGAFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class PCMJEFLIFOC : LACGAEMAOIL<char?>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly PCMJEFLIFOC PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6589780", Offset = "0x6588580", VA = "0x186589780", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, char? PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x6589660", Offset = "0x6588460", VA = "0x186589660", Slot = "5")]
	public char? LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public PCMJEFLIFOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class FPJFAGJAGNK : LACGAEMAOIL<char[]>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly FPJFAGJAGNK PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x657FAD0", Offset = "0x657E8D0", VA = "0x18657FAD0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, char[] PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x657F910", Offset = "0x657E710", VA = "0x18657F910", Slot = "5")]
	public char[] LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public FPJFAGJAGNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class MFPEDEOBFFM : LACGAEMAOIL<Guid>, DNFLPCIHMPE, DOLLIKCIPDC<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly LACGAEMAOIL<Guid> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6583730", Offset = "0x6582530", VA = "0x186583730", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, Guid PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x65836A0", Offset = "0x65824A0", VA = "0x1865836A0", Slot = "5")]
	public Guid LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x6583560", Offset = "0x6582360", VA = "0x186583560", Slot = "6")]
	public void FPODFOLKNAO(NDKEFDAFPOB NEGHIHACAHG, Guid PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x65834C0", Offset = "0x65822C0", VA = "0x1865834C0", Slot = "7")]
	public Guid EFMJOAFBKOK(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public MFPEDEOBFFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class AGNAPPMHMKE : LACGAEMAOIL<decimal>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly LACGAEMAOIL<decimal> PJHGNDJLIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private readonly bool NPHPFDKPMBC;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x500F590", Offset = "0x500E390", VA = "0x18500F590")]
	public AGNAPPMHMKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x16901E0", Offset = "0x168EFE0", VA = "0x1816901E0")]
	public AGNAPPMHMKE(bool NPHPFDKPMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x65774C0", Offset = "0x65762C0", VA = "0x1865774C0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, decimal PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6577220", Offset = "0x6576020", VA = "0x186577220", Slot = "5")]
	public decimal LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class FJKPEBIEPPL : LACGAEMAOIL<Uri>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly LACGAEMAOIL<Uri> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x657F5D0", Offset = "0x657E3D0", VA = "0x18657F5D0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, Uri PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x657F510", Offset = "0x657E310", VA = "0x18657F510", Slot = "5")]
	public Uri LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public FJKPEBIEPPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class HCEMBAKGPOH : LACGAEMAOIL<Version>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly LACGAEMAOIL<Version> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x6580280", Offset = "0x657F080", VA = "0x186580280", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, Version PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x65801C0", Offset = "0x657EFC0", VA = "0x1865801C0", Slot = "5")]
	public Version LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public HCEMBAKGPOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class DFGOKLFDKLG<TKey, TValue> : LACGAEMAOIL<KeyValuePair<TKey, TValue>>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x4D7B230", Offset = "0x4D7A030", VA = "0x184D7B230", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, KeyValuePair<TKey, TValue> PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x4D7AF00", Offset = "0x4D79D00", VA = "0x184D7AF00", Slot = "5")]
	public KeyValuePair<TKey, TValue> LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class FOPGEEFEPHI : LACGAEMAOIL<StringBuilder>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly LACGAEMAOIL<StringBuilder> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x657F7F0", Offset = "0x657E5F0", VA = "0x18657F7F0", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, StringBuilder PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x657F730", Offset = "0x657E530", VA = "0x18657F730", Slot = "5")]
	public StringBuilder LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public FOPGEEFEPHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class HDFDAJOBNGE : LACGAEMAOIL<BitArray>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly LACGAEMAOIL<BitArray> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x6580540", Offset = "0x657F340", VA = "0x186580540", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, BitArray PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x65803C0", Offset = "0x657F1C0", VA = "0x1865803C0", Slot = "5")]
	public BitArray LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public HDFDAJOBNGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class PDFHFMGLLFI : LACGAEMAOIL<Type>, DNFLPCIHMPE
{
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly PDFHFMGLLFI PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly Regex MOAGEJOAJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private bool NFKBNHBLBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private bool DFGKMLKIOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private bool GBBOGNIOONO;

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x6589C50", Offset = "0x6588A50", VA = "0x186589C50")]
	public PDFHFMGLLFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D12C90", Offset = "0x5D11A90", VA = "0x185D12C90")]
	public PDFHFMGLLFI(bool NFKBNHBLBOP, bool DFGKMLKIOLL, bool GBBOGNIOONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x6589A50", Offset = "0x6588850", VA = "0x186589A50", Slot = "4")]
	public void OJBJHHLKILJ(NDKEFDAFPOB NEGHIHACAHG, Type PHPDIJICBJO, CHFBNEPGHDG JGDBIIPBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x6589900", Offset = "0x6588700", VA = "0x186589900", Slot = "5")]
	public Type LKNPCKIALBL(PHKIJIILNBG EIFCDBMOGEN, CHFBNEPGHDG JGDBIIPBBCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal static class NJLKJMBGKOG
{
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal static readonly byte[][] LNBGFNIDNNG;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal static readonly MFBBLNNOMIJ HGFMMNHFJJJ;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x65852E0", Offset = "0x65840E0", VA = "0x1865852E0")]
	static NJLKJMBGKOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class NJBHMLFHHBI
{
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal static readonly byte[][] KBDOLPJIGKE;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal static readonly MFBBLNNOMIJ LHABGJFLBGL;

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x65850D0", Offset = "0x6583ED0", VA = "0x1865850D0")]
	static NJBHMLFHHBI()
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
