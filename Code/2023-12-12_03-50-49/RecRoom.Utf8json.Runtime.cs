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
internal static class JPILNIALPAN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6579970", Offset = "0x6578170", VA = "0x186579970")]
	public static bool KFDHBKJFEIE(this TypeInfo HJNJPNKDEFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class LALCJJNKMGM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type LCBCAACHAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772320", VA = "0x180773B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] DGBHAIELCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x79CCC0", Offset = "0x79B4C0", VA = "0x18079CCC0")]
	public LALCJJNKMGM(Type LGKNLJEGEBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class EIDLJCBMBGF : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void HBDFBNNDOCH<T>(BPGOOCGBHEB MDONNIFBLDI, T DOLICEBFIPF, BFDHJNAPNBH MBINCLEAPPN);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T BIEDANENIHJ<T>(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH MBINCLEAPPN);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LMLLDOBHGKK
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OGEKILALGOF<T> : LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, T DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HGOJFABDFMC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, T DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum MIGKHLDJDLE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class CFAHDFDNJMA
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2329B50", Offset = "0x2328350", VA = "0x182329B50")]
	public static string CFEPHIDAJNA<T>(this OGEKILALGOF<T> BLLEIDBCPFO, T DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OGEKILALGOF<T> LEHAIOIGGJE<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MKCGDCMFBFL
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x25A18F0", Offset = "0x25A00F0", VA = "0x1825A18F0")]
	public static OGEKILALGOF<T> ODJKCHHPBGL<T>(this BFDHJNAPNBH MBINCLEAPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6584DC0", Offset = "0x65835C0", VA = "0x186584DC0")]
	public static object ODAFFPFJNKP(this BFDHJNAPNBH MBINCLEAPPN, Type HJNJPNKDEFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GKNNAHLLILM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x656D630", Offset = "0x656BE30", VA = "0x18656D630")]
	public GKNNAHLLILM(string OLDFIJBKFKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct MJBBFIMEBFI
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class GCBGFOEIOEE
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] IJPAPFCFHAF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] OGAEGBKCODA;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x656D590", Offset = "0x656BD90", VA = "0x18656D590")]
		public static byte[] JKJDBJBPENM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x656D4F0", Offset = "0x656BCF0", VA = "0x18656D4F0")]
		public static char[] HHOBBCLJFJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> EOCJGEKKCME;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] LPILANHPIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] OCKHPPLPLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int IJJNAEFKMHG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool KLFEPEEGBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6581DE0", Offset = "0x65805E0", VA = "0x186581DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6584C00", Offset = "0x6583400", VA = "0x186584C00")]
	public MJBBFIMEBFI(byte[] OCKHPPLPLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6584C60", Offset = "0x6583460", VA = "0x186584C60")]
	public MJBBFIMEBFI(byte[] OCKHPPLPLMN, int IJJNAEFKMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6582160", Offset = "0x6580960", VA = "0x186582160")]
	private CPFADFMHICJ EEDMAFMIOPP(string MKLOMBGFNAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6583630", Offset = "0x6581E30", VA = "0x186583630")]
	private CPFADFMHICJ IEILPAADDOC(string OLDFIJBKFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x656BB10", Offset = "0x656A310", VA = "0x18656BB10")]
	public void LPKPCHHGDNE(int IJJNAEFKMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
	public byte[] KOPMGPKIAIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CDE7A0", Offset = "0x1CDCFA0", VA = "0x181CDE7A0")]
	public int OCICLAFMABB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x65833C0", Offset = "0x6581BC0", VA = "0x1865833C0")]
	public FMKCIAGCCBK HNLLCGCBCMN()
	{
		return default(FMKCIAGCCBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6582C40", Offset = "0x6581440", VA = "0x186582C40")]
	public void FJDBPFFEDFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6583E70", Offset = "0x6582670", VA = "0x186583E70")]
	public bool OOPOBIBEFPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6583BA0", Offset = "0x65823A0", VA = "0x186583BA0")]
	public bool NBHOKIFBEOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6583720", Offset = "0x6581F20", VA = "0x186583720")]
	public void IELAFBJOPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x65826B0", Offset = "0x6580EB0", VA = "0x1865826B0")]
	public bool EGFOLJBBPEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6582860", Offset = "0x6581060", VA = "0x186582860")]
	public bool FEMNJAGCIPE(int PPKDCOOCBKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6581A30", Offset = "0x6580230", VA = "0x186581A30")]
	public bool APPJGHBAAOC(int PPKDCOOCBKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6583A80", Offset = "0x6582280", VA = "0x186583A80")]
	public bool LMBGPLLKNLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6583320", Offset = "0x6581B20", VA = "0x186583320")]
	public void HABCGEDACIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x65827D0", Offset = "0x6580FD0", VA = "0x1865827D0")]
	public bool EPAHDOCFLEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6582D70", Offset = "0x6581570", VA = "0x186582D70")]
	public bool FKCACNLGNBN(int PPKDCOOCBKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6583250", Offset = "0x6581A50", VA = "0x186583250")]
	public bool GIEIDBGHPIF(int PPKDCOOCBKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6582740", Offset = "0x6580F40", VA = "0x186582740")]
	public bool EHPFHKEMCJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6582BA0", Offset = "0x65813A0", VA = "0x186582BA0")]
	public void FIDMNJNCPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6583B10", Offset = "0x6582310", VA = "0x186583B10")]
	public bool LOMIBCJFFNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6583DD0", Offset = "0x65825D0", VA = "0x186583DD0")]
	public void OKJDJKMDLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6583F90", Offset = "0x6582790", VA = "0x186583F90")]
	private void PBDAKELGCIG([Out] byte[] EOMIEOEKAMJ, [Out] int LPPDPANKOCB, [Out] int DFBIMGKOEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6581CC0", Offset = "0x65804C0", VA = "0x186581CC0")]
	private static int CAKAOCAJBLG(char GIFKCLLLICD, char KIOLHHMPBGL, char DNNFFPMDBKK, char FCAIODKILEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6583920", Offset = "0x6582120", VA = "0x186583920")]
	private static int KIDLJABOODF(char GJPJIELLCID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6583C30", Offset = "0x6582430", VA = "0x186583C30")]
	public ArraySegment<byte> NGGJIHGCLHJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6583840", Offset = "0x6582040", VA = "0x186583840")]
	public string IMNDJAIBFCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6583090", Offset = "0x6581890", VA = "0x186583090")]
	public string FNBFJGJGLEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6581E80", Offset = "0x6580680", VA = "0x186581E80")]
	public ArraySegment<byte> CJBELMEBDCJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6581D70", Offset = "0x6580570", VA = "0x186581D70")]
	public ArraySegment<byte> CCPBGFLKHGK()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6584890", Offset = "0x6583090", VA = "0x186584890")]
	public bool PPFLPCEKOHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x65820A0", Offset = "0x65808A0", VA = "0x1865820A0")]
	private static bool DOOCCCGMEEM(byte DNNFFPMDBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6582E40", Offset = "0x6581640", VA = "0x186582E40")]
	private void FLKKOAJDAFE(FMKCIAGCCBK JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6583100", Offset = "0x6581900", VA = "0x186583100")]
	public void GBNABHBFJDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6584730", Offset = "0x6582F30", VA = "0x186584730")]
	private void PFFAEAECFFA(int ANIDCHMEIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6583D50", Offset = "0x6582550", VA = "0x186583D50")]
	public sbyte NHLKKIANHJO()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6582B20", Offset = "0x6581320", VA = "0x186582B20")]
	public short FFOMADGPKPJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x65837C0", Offset = "0x6581FC0", VA = "0x1865837C0")]
	public int IMKADFBIEIP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6581C00", Offset = "0x6580400", VA = "0x186581C00")]
	public long BNKICLNGKJI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6581E00", Offset = "0x6580600", VA = "0x186581E00")]
	public byte CHIDBIHCHEC()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6582930", Offset = "0x6581130", VA = "0x186582930")]
	public ushort FFJGDLKPKEF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6583A00", Offset = "0x6582200", VA = "0x186583A00")]
	public uint LKFFHANDCMJ()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6583570", Offset = "0x6581D70", VA = "0x186583570")]
	public ulong HNMCLDBFJHI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6581930", Offset = "0x6580130", VA = "0x186581930")]
	public float AICBJIGLGNM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6583150", Offset = "0x6581950", VA = "0x186583150")]
	public double GCAJFBOKDAP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6581B00", Offset = "0x6580300", VA = "0x186581B00")]
	public ArraySegment<byte> BBOMKCGFNOK()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x65829B0", Offset = "0x65811B0", VA = "0x1865829B0")]
	private static int FFKPGAOMKGF(byte[] OCKHPPLPLMN, int IJJNAEFKMHG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CPFADFMHICJ : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference LBOALBGFMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int KPOFKIMKOIK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int KEAGPFCIOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB99450", Offset = "0xB97C50", VA = "0x180B99450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string ONOIILADOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x838E00", Offset = "0x837600", VA = "0x180838E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x656CB30", Offset = "0x656B330", VA = "0x18656CB30")]
	public CPFADFMHICJ(string OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x656CB90", Offset = "0x656B390", VA = "0x18656CB90")]
	public CPFADFMHICJ(string OLDFIJBKFKG, byte[] NCNMGIOLAMI, int IJJNAEFKMHG, int KPOFKIMKOIK, string DFLFAMHOLHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KFGHNLBFHNH
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class LDAKJACLMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] IJPAPFCFHAF;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x657D1A0", Offset = "0x657B9A0", VA = "0x18657D1A0")]
		public static byte[] JKJDBJBPENM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class HNAEGNCKPBN
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void PMDNLAAHJCA(BPGOOCGBHEB MDONNIFBLDI, object DOLICEBFIPF, BFDHJNAPNBH MBINCLEAPPN);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object DMPAEAJOFBD(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH MBINCLEAPPN);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class LLMMKPGGLHF
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class LFCOBEJEOLJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
				public LFCOBEJEOLJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x4DEC4D0", Offset = "0x4DEACD0", VA = "0x184DEC4D0")]
				internal bool APPDFFKNPIP(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x657DF20", Offset = "0x657C720", VA = "0x18657DF20")]
				internal bool INBCNEGECNF(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, BFDHJNAPNBH, byte[]> LBAADIBEPAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, BFDHJNAPNBH> HBPHOJOGLCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly PMDNLAAHJCA MMOFDIANLEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, BFDHJNAPNBH, ArraySegment<byte>> NBKCGAPMJCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, BFDHJNAPNBH, string> DLMHCIIBBDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, BFDHJNAPNBH, object> FNKJCNBFDGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, BFDHJNAPNBH, object> GEAGFHEDFFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, BFDHJNAPNBH, object> KCKKPBABFIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly DMPAEAJOFBD OGGHJJMHDKM;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x657EE60", Offset = "0x657D660", VA = "0x18657EE60")]
			public LLMMKPGGLHF(Type HJNJPNKDEFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2AD6AD0", Offset = "0x2AD52D0", VA = "0x182AD6AD0")]
			private static T PJMNADBBDHP<T>(DynamicMethod MGJJJIFKIKF)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x657EC10", Offset = "0x657D410", VA = "0x18657EC10")]
			private static MethodInfo OBKABMGAEMK(Type HJNJPNKDEFH, string PMDCAPIFBIP, Type[] NDLIAPFGNKM)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, LLMMKPGGLHF> JFCGMABJLGE;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly IKBJOPMDILN<LLMMKPGGLHF> JJGDJDIPMGM;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x656DAA0", Offset = "0x656C2A0", VA = "0x18656DAA0")]
		static HNAEGNCKPBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x656D790", Offset = "0x656BF90", VA = "0x18656D790")]
		private static LLMMKPGGLHF ABAGPILCCJJ(Type HJNJPNKDEFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x656D810", Offset = "0x656C010", VA = "0x18656D810")]
		public static void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, object DOLICEBFIPF, BFDHJNAPNBH MBINCLEAPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x656D990", Offset = "0x656C190", VA = "0x18656D990")]
		public static void JMOOMJHDBEG(Type HJNJPNKDEFH, BPGOOCGBHEB MDONNIFBLDI, object DOLICEBFIPF, BFDHJNAPNBH MBINCLEAPPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static BFDHJNAPNBH OMDOBOCHDLB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] OIOENJCMJED;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] NEAOLJLIEFH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static BFDHJNAPNBH LFMGNCIBAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x657AC90", Offset = "0x6579490", VA = "0x18657AC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool PCAIHPKKNOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x657ABC0", Offset = "0x65793C0", VA = "0x18657ABC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x657AC20", Offset = "0x6579420", VA = "0x18657AC20")]
	public static void OEEEDBEJLMJ(BFDHJNAPNBH MBINCLEAPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2557340", Offset = "0x2555B40", VA = "0x182557340")]
	public static byte[] JMOOMJHDBEG<T>(T BEKFGDCEJDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x25571C0", Offset = "0x25559C0", VA = "0x1825571C0")]
	public static byte[] JMOOMJHDBEG<T>(T DOLICEBFIPF, BFDHJNAPNBH MBINCLEAPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2557530", Offset = "0x2555D30", VA = "0x182557530")]
	public static void JMOOMJHDBEG<T>(BPGOOCGBHEB MDONNIFBLDI, T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2557450", Offset = "0x2555C50", VA = "0x182557450")]
	public static void JMOOMJHDBEG<T>(BPGOOCGBHEB MDONNIFBLDI, T DOLICEBFIPF, BFDHJNAPNBH MBINCLEAPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x25573C0", Offset = "0x2555BC0", VA = "0x1825573C0")]
	public static void JMOOMJHDBEG<T>(Stream HLAKDKDHKBE, T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x25575C0", Offset = "0x2555DC0", VA = "0x1825575C0")]
	public static void JMOOMJHDBEG<T>(Stream HLAKDKDHKBE, T DOLICEBFIPF, BFDHJNAPNBH MBINCLEAPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2556FA0", Offset = "0x25557A0", VA = "0x182556FA0")]
	public static ArraySegment<byte> GPDHMLPJMEE<T>(T BEKFGDCEJDH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2557030", Offset = "0x2555830", VA = "0x182557030")]
	public static ArraySegment<byte> GPDHMLPJMEE<T>(T DOLICEBFIPF, BFDHJNAPNBH MBINCLEAPPN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2556DA0", Offset = "0x25555A0", VA = "0x182556DA0")]
	public static string CFEPHIDAJNA<T>(T DOLICEBFIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2556E20", Offset = "0x2555620", VA = "0x182556E20")]
	public static string CFEPHIDAJNA<T>(T DOLICEBFIPF, BFDHJNAPNBH MBINCLEAPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2556520", Offset = "0x2554D20", VA = "0x182556520")]
	public static T AEDPLFCAHJC<T>(string GILJEAPGEAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x25562A0", Offset = "0x2554AA0", VA = "0x1825562A0")]
	public static T AEDPLFCAHJC<T>(string GILJEAPGEAH, BFDHJNAPNBH MBINCLEAPPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2556AD0", Offset = "0x25552D0", VA = "0x182556AD0")]
	public static T AEDPLFCAHJC<T>(byte[] OCKHPPLPLMN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x25565B0", Offset = "0x2554DB0", VA = "0x1825565B0")]
	public static T AEDPLFCAHJC<T>(byte[] OCKHPPLPLMN, BFDHJNAPNBH MBINCLEAPPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2556780", Offset = "0x2554F80", VA = "0x182556780")]
	public static T AEDPLFCAHJC<T>(byte[] OCKHPPLPLMN, int IJJNAEFKMHG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2556390", Offset = "0x2554B90", VA = "0x182556390")]
	public static T AEDPLFCAHJC<T>(byte[] OCKHPPLPLMN, int IJJNAEFKMHG, BFDHJNAPNBH MBINCLEAPPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2556C20", Offset = "0x2555420", VA = "0x182556C20")]
	public static T AEDPLFCAHJC<T>(MJBBFIMEBFI EINLOJPKPLI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2556A00", Offset = "0x2555200", VA = "0x182556A00")]
	public static T AEDPLFCAHJC<T>(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH MBINCLEAPPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2556CA0", Offset = "0x25554A0", VA = "0x182556CA0")]
	public static T AEDPLFCAHJC<T>(Stream HLAKDKDHKBE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2556640", Offset = "0x2554E40", VA = "0x182556640")]
	public static T AEDPLFCAHJC<T>(Stream HLAKDKDHKBE, BFDHJNAPNBH MBINCLEAPPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x657A920", Offset = "0x6579120", VA = "0x18657A920")]
	public static string CKHLFGBGAIB(byte[] GILJEAPGEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x657AA80", Offset = "0x6579280", VA = "0x18657AA80")]
	public static string CKHLFGBGAIB(byte[] GILJEAPGEAH, int IJJNAEFKMHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x657A790", Offset = "0x6578F90", VA = "0x18657A790")]
	public static string CKHLFGBGAIB(string GILJEAPGEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x65799A0", Offset = "0x65781A0", VA = "0x1865799A0")]
	public static byte[] AKKHJHBLACE(byte[] GILJEAPGEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6579CD0", Offset = "0x65784D0", VA = "0x186579CD0")]
	public static byte[] AKKHJHBLACE(byte[] GILJEAPGEAH, int IJJNAEFKMHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6579B20", Offset = "0x6578320", VA = "0x186579B20")]
	public static byte[] AKKHJHBLACE(string GILJEAPGEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6579E20", Offset = "0x6578620", VA = "0x186579E20")]
	private static void BAFEHIPLJCM(MJBBFIMEBFI EINLOJPKPLI, BPGOOCGBHEB MDONNIFBLDI, int LCPEGFJBFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x657A6F0", Offset = "0x6578EF0", VA = "0x18657A6F0")]
	private static int BJIFEJNKPEA(Stream LLJFBBILFIJ, byte[] IJPAPFCFHAF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum FMKCIAGCCBK : byte
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
public struct BPGOOCGBHEB
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] AOIFHJFAMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] IJPAPFCFHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int IJJNAEFKMHG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EFAAKOPKPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1CDE7A0", Offset = "0x1CDCFA0", VA = "0x181CDE7A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x656BB10", Offset = "0x656A310", VA = "0x18656BB10")]
	public void LPKPCHHGDNE(int IJJNAEFKMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x656B870", Offset = "0x656A070", VA = "0x18656B870")]
	public static byte[] LDIOEHCICKF(string LLJBEMIACPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x656AC30", Offset = "0x6569430", VA = "0x18656AC30")]
	public static byte[] ALNBAKNKMCM(string LLJBEMIACPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x656B9A0", Offset = "0x656A1A0", VA = "0x18656B9A0")]
	public static byte[] LFKOHMHDNCK(string LLJBEMIACPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x656AE80", Offset = "0x6569680", VA = "0x18656AE80")]
	public static byte[] BGAAGJBDGLC(string LLJBEMIACPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x538D0E0", Offset = "0x538B8E0", VA = "0x18538D0E0")]
	public BPGOOCGBHEB(byte[] AHOANDLNAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x656B7C0", Offset = "0x6569FC0", VA = "0x18656B7C0")]
	public ArraySegment<byte> JKJDBJBPENM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x656BB20", Offset = "0x656A320", VA = "0x18656BB20")]
	public byte[] MKHDAFDFNOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x656BFE0", Offset = "0x656A7E0", VA = "0x18656BFE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x656B860", Offset = "0x656A060", VA = "0x18656B860")]
	public void JNDFIMFJJIA(int AFONIEHJLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x656B140", Offset = "0x6569940", VA = "0x18656B140")]
	public void DFLNOCFJPNA(byte MIBGOBNFEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x656B1A0", Offset = "0x65699A0", VA = "0x18656B1A0")]
	public void DFLNOCFJPNA(byte[] MIBGOBNFEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x656ADA0", Offset = "0x65695A0", VA = "0x18656ADA0")]
	public void AOJBEJBFAJJ(byte MIBGOBNFEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x656AE30", Offset = "0x6569630", VA = "0x18656AE30")]
	public void BBJLMHKOPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x656B2A0", Offset = "0x6569AA0", VA = "0x18656B2A0")]
	public void FNMHGMIALCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x656B680", Offset = "0x6569E80", VA = "0x18656B680")]
	public void IACBNPMGDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x656ADE0", Offset = "0x65695E0", VA = "0x18656ADE0")]
	public void BAEOHBHDIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x656B250", Offset = "0x6569A50", VA = "0x18656B250")]
	public void FELOJDLAMOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x656B200", Offset = "0x6569A00", VA = "0x18656B200")]
	public void DGKJDODACKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x656BE50", Offset = "0x656A650", VA = "0x18656BE50")]
	public void OPNBAPDILEB(string LLJBEMIACPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x656B6D0", Offset = "0x6569ED0", VA = "0x18656B6D0")]
	public void INDEDEPIAPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x656B720", Offset = "0x6569F20", VA = "0x18656B720")]
	public void INEHGKPJJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x656BC10", Offset = "0x656A410", VA = "0x18656BC10")]
	public void OFOIPOKPMMA(bool DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x656BF60", Offset = "0x656A760", VA = "0x18656BF60")]
	public void PHIPEAGHLBG(float DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x656BB90", Offset = "0x656A390", VA = "0x18656BB90")]
	public void NHNOOELNIFG(double DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x656BD70", Offset = "0x656A570", VA = "0x18656BD70")]
	public void OGKINOANAPO(byte DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x656BDE0", Offset = "0x656A5E0", VA = "0x18656BDE0")]
	public void OKLGHFLHMFB(ushort DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x656BEF0", Offset = "0x656A6F0", VA = "0x18656BEF0")]
	public void PEJGHPHMMMP(uint DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x656B000", Offset = "0x6569800", VA = "0x18656B000")]
	public void BGKIKABJBBH(ulong DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x656B030", Offset = "0x6569830", VA = "0x18656B030")]
	public void CLELBDFOJFN(sbyte DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x656B0A0", Offset = "0x65698A0", VA = "0x18656B0A0")]
	public void CPMGILBPEOP(short DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x656ABC0", Offset = "0x65693C0", VA = "0x18656ABC0")]
	public void ADJLGHGCEBE(int DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x656B110", Offset = "0x6569910", VA = "0x18656B110")]
	public void DEAHKNPMGLN(long DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x656B2F0", Offset = "0x6569AF0", VA = "0x18656B2F0")]
	public void GGNEAKCGAGG(string DOLICEBFIPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NFEMNLGKKBC : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class JKDGJAPKHFK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x38A4E10", Offset = "0x38A3610", VA = "0x1838A4E10")]
		static JKDGJAPKHFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private NFEMNLGKKBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class LDBNACGHKJH
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> MNHPKPFJNDF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x657DA30", Offset = "0x657C230", VA = "0x18657DA30")]
	static LDBNACGHKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x657D240", Offset = "0x657BA40", VA = "0x18657D240")]
	internal static object LEHAIOIGGJE(Type OPLOPEJIHLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class COPKHLGAFCJ : OGEKILALGOF<Vector2>, LMLLDOBHGKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JPMOGNBDGPH KIBLIJJGAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] ACLOFKFPPKE;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x656C950", Offset = "0x656B150", VA = "0x18656C950")]
	public COPKHLGAFCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x656C760", Offset = "0x656AF60", VA = "0x18656C760", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, Vector2 DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x656C470", Offset = "0x656AC70", VA = "0x18656C470", Slot = "5")]
	public Vector2 AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class LMFIIBAFNCI : OGEKILALGOF<Vector3>, LMLLDOBHGKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly JPMOGNBDGPH KIBLIJJGAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] ACLOFKFPPKE;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6580F50", Offset = "0x657F750", VA = "0x186580F50")]
	public LMFIIBAFNCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6580CB0", Offset = "0x657F4B0", VA = "0x186580CB0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, Vector3 DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6580960", Offset = "0x657F160", VA = "0x186580960", Slot = "5")]
	public Vector3 AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class PLKEOFOPBAD : OGEKILALGOF<Vector4>, LMLLDOBHGKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly JPMOGNBDGPH KIBLIJJGAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] ACLOFKFPPKE;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x65873E0", Offset = "0x6585BE0", VA = "0x1865873E0")]
	public PLKEOFOPBAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x65870A0", Offset = "0x65858A0", VA = "0x1865870A0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, Vector4 DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6586D10", Offset = "0x6585510", VA = "0x186586D10", Slot = "5")]
	public Vector4 AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class LGLKPDKMHMF : OGEKILALGOF<Quaternion>, LMLLDOBHGKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly JPMOGNBDGPH KIBLIJJGAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] ACLOFKFPPKE;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x657E7B0", Offset = "0x657CFB0", VA = "0x18657E7B0")]
	public LGLKPDKMHMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x657E470", Offset = "0x657CC70", VA = "0x18657E470", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, Quaternion DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x657E0E0", Offset = "0x657C8E0", VA = "0x18657E0E0", Slot = "5")]
	public Quaternion AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class MOFAFJDMACD : OGEKILALGOF<Color>, LMLLDOBHGKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly JPMOGNBDGPH KIBLIJJGAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] ACLOFKFPPKE;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x65855F0", Offset = "0x6583DF0", VA = "0x1865855F0")]
	public MOFAFJDMACD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x65852B0", Offset = "0x6583AB0", VA = "0x1865852B0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, Color DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6584F20", Offset = "0x6583720", VA = "0x186584F20", Slot = "5")]
	public Color AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OICKAJGKEIL : OGEKILALGOF<Bounds>, LMLLDOBHGKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly JPMOGNBDGPH KIBLIJJGAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] ACLOFKFPPKE;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6586B30", Offset = "0x6585330", VA = "0x186586B30")]
	public OICKAJGKEIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6586810", Offset = "0x6585010", VA = "0x186586810", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, Bounds DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6586430", Offset = "0x6584C30", VA = "0x186586430", Slot = "5")]
	public Bounds AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class NFHCLFNJOFI : OGEKILALGOF<Rect>, LMLLDOBHGKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly JPMOGNBDGPH KIBLIJJGAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] ACLOFKFPPKE;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6586140", Offset = "0x6584940", VA = "0x186586140")]
	public NFHCLFNJOFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6585DD0", Offset = "0x65845D0", VA = "0x186585DD0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, Rect DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x65859E0", Offset = "0x65841E0", VA = "0x1865859E0", Slot = "5")]
	public Rect AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class JGPOCBIMKIK : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private static class CHAGNBEDDMN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x48FC200", Offset = "0x48FAA00", VA = "0x1848FC200")]
		static CHAGNBEDDMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private JGPOCBIMKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class APNPMPBJKCF : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private static class IEKEHIPEDGP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x368C840", Offset = "0x368B040", VA = "0x18368C840")]
		static IEKEHIPEDGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class HNJGIDNIPPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> MOPJEPCPPCB;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x656DBF0", Offset = "0x656C3F0", VA = "0x18656DBF0")]
		internal static object LEHAIOIGGJE(Type OPLOPEJIHLC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private APNPMPBJKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class MIHPNKGJILO : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class EMDNBCFNECL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3111E60", Offset = "0x3110660", VA = "0x183111E60")]
		static EMDNBCFNECL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly MIHPNKGJILO ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool LNEDBBFKNEM;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static LMLLDOBHGKK[] LIBGLNEFBFA;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static BFDHJNAPNBH[] EAPBDGDKALK;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private MIHPNKGJILO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x65813C0", Offset = "0x657FBC0", VA = "0x1865813C0")]
	public static void FPBPDBBEPKK(params BFDHJNAPNBH[] EAPBDGDKALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x65814A0", Offset = "0x657FCA0", VA = "0x1865814A0")]
	public static void FPBPDBBEPKK(params LMLLDOBHGKK[] LIBGLNEFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6581580", Offset = "0x657FD80", VA = "0x186581580")]
	public static void LKBPPCFKEEH(LMLLDOBHGKK[] LIBGLNEFBFA, BFDHJNAPNBH[] EAPBDGDKALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class NBGMNCDLOOJ : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private static class JDHBGHAHEAP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3886250", Offset = "0x3884A50", VA = "0x183886250")]
		static JDHBGHAHEAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private NBGMNCDLOOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class EADICNKDCCC
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly BFDHJNAPNBH FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly BFDHJNAPNBH MACCDLMGABJ;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly BFDHJNAPNBH ILMFKGCFELM;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly BFDHJNAPNBH ACNFDBELDJP;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly BFDHJNAPNBH GBJEEOIEILH;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly BFDHJNAPNBH FPAHHFIAINA;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly BFDHJNAPNBH PMEBONCCEJB;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly BFDHJNAPNBH GMNHAGLFKLB;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly BFDHJNAPNBH GJEBLLJENGC;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly BFDHJNAPNBH GKBCAJEPKBB;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly BFDHJNAPNBH OELNDKOONJK;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly BFDHJNAPNBH APEOBFONDCD;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class CIMJKHGJFCC
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly BFDHJNAPNBH FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly BFDHJNAPNBH BCDEJOFOGCK;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KIDNBNGIEMO
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly BFDHJNAPNBH FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly BFDHJNAPNBH MACCDLMGABJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly BFDHJNAPNBH ILMFKGCFELM;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly BFDHJNAPNBH ACNFDBELDJP;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly BFDHJNAPNBH GBJEEOIEILH;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly BFDHJNAPNBH FPAHHFIAINA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly BFDHJNAPNBH PMEBONCCEJB;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly BFDHJNAPNBH GMNHAGLFKLB;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly BFDHJNAPNBH GJEBLLJENGC;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly BFDHJNAPNBH GKBCAJEPKBB;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly BFDHJNAPNBH OELNDKOONJK;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly BFDHJNAPNBH APEOBFONDCD;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class LCCPJLHBEBI
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> MOPJEPCPPCB;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x657B4F0", Offset = "0x6579CF0", VA = "0x18657B4F0")]
	internal static object LEHAIOIGGJE(Type OPLOPEJIHLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x657B4B0", Offset = "0x6579CB0", VA = "0x18657B4B0")]
	private static object ABIANMBBOJH(Type NHMLPDNKLHC, Type[] KDOJHPMGEII, params object[] NDLIAPFGNKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class LLBOOCJNMCD : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class HOIAJBECJIC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x35EA5A0", Offset = "0x35E8DA0", VA = "0x1835EA5A0")]
		static HOIAJBECJIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> AGJMGOLBABJ;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool GGNIHJAJOPP;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly BNMGGJGHHOJ LLEFEABBJBK;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x657EAA0", Offset = "0x657D2A0", VA = "0x18657EAA0")]
	static LLBOOCJNMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private LLBOOCJNMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class AGHEJGPFNJB : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class MLOFJHHAKAL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2250", Offset = "0x3CB0A50", VA = "0x183CB2250")]
		static MLOFJHHAKAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> AGJMGOLBABJ;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool GGNIHJAJOPP;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly BNMGGJGHHOJ LLEFEABBJBK;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x656A8D0", Offset = "0x65690D0", VA = "0x18656A8D0")]
	static AGHEJGPFNJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private AGHEJGPFNJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class CEBBMNEKEDE : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class EOIMPAGJMMI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x31222D0", Offset = "0x3120AD0", VA = "0x1831222D0")]
		static EOIMPAGJMMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> AGJMGOLBABJ;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool GGNIHJAJOPP;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly BNMGGJGHHOJ LLEFEABBJBK;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x656C220", Offset = "0x656AA20", VA = "0x18656C220")]
	static CEBBMNEKEDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private CEBBMNEKEDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class EJMEOIOFPHD : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class BDPIPOHIHNK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x45796F0", Offset = "0x4577EF0", VA = "0x1845796F0")]
		static BDPIPOHIHNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> AGJMGOLBABJ;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool GGNIHJAJOPP;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly BNMGGJGHHOJ LLEFEABBJBK;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x656D210", Offset = "0x656BA10", VA = "0x18656D210")]
	static EJMEOIOFPHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private EJMEOIOFPHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class FEODIHHOPMB : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class EHFMBDJMPEO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3100E10", Offset = "0x30FF610", VA = "0x183100E10")]
		static EHFMBDJMPEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> AGJMGOLBABJ;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool GGNIHJAJOPP;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly BNMGGJGHHOJ LLEFEABBJBK;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x656D380", Offset = "0x656BB80", VA = "0x18656D380")]
	static FEODIHHOPMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private FEODIHHOPMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class CDGKFOLFLLC : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class ABBLNMAIFEK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3542290", Offset = "0x3540A90", VA = "0x183542290")]
		static ABBLNMAIFEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> AGJMGOLBABJ;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool GGNIHJAJOPP;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly BNMGGJGHHOJ LLEFEABBJBK;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x656C0B0", Offset = "0x656A8B0", VA = "0x18656C0B0")]
	static CDGKFOLFLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private CDGKFOLFLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class BHKLHAKEMJN : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class CDHDCAIIIMO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x48E1880", Offset = "0x48E0080", VA = "0x1848E1880")]
		static CDHDCAIIIMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> AGJMGOLBABJ;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool GGNIHJAJOPP;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public BHKLHAKEMJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class HKLDJEJINJJ : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private static class KHKPKOOHJHI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x38FC150", Offset = "0x38FA950", VA = "0x1838FC150")]
		static KHKPKOOHJHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> AGJMGOLBABJ;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool GGNIHJAJOPP;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public HKLDJEJINJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal sealed class DCBEJPDACBH : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private static class OENHJDDAGNO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3E07B50", Offset = "0x3E06350", VA = "0x183E07B50")]
		static OENHJDDAGNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> AGJMGOLBABJ;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool GGNIHJAJOPP;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public DCBEJPDACBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class KJODDGDODLD : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private static class NEBAECMMPNI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3D011C0", Offset = "0x3CFF9C0", VA = "0x183D011C0")]
		static NEBAECMMPNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> AGJMGOLBABJ;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool GGNIHJAJOPP;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public KJODDGDODLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class MHIKMGDONCJ : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private static class NEBLHFBMDNK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3D09680", Offset = "0x3D07E80", VA = "0x183D09680")]
		static NEBLHFBMDNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> AGJMGOLBABJ;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool GGNIHJAJOPP;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public MHIKMGDONCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class MBEBCBDPGNE : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private static class DPAKGBKMKBD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4DED7E0", Offset = "0x4DEBFE0", VA = "0x184DED7E0")]
		static DPAKGBKMKBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> AGJMGOLBABJ;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool GGNIHJAJOPP;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public MBEBCBDPGNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class IMHJBECADAG
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct HLIMJBAIPKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CAAEDJDJIPH HBPAJNJKMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder DJEGGODCMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder JAFFFIOCFOI;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class JGMBJOPLPDC
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class ENDDBKCEJEF
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo LFKOHMHDNCK;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo ALNBAKNKMCM;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo BGAAGJBDGLC;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo LDIOEHCICKF;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo INEHGKPJJCO;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo DFLNOCFJPNA;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo IACBNPMGDHM;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo BAEOHBHDIMP;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo FELOJDLAMOG;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x65902D0", Offset = "0x658EAD0", VA = "0x1865902D0")]
			static ENDDBKCEJEF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class BJPGEAMMKMI
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo OOPOBIBEFPC;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo HABCGEDACIF;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo FKCACNLGNBN;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo IFNMCMKPPHA;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo GBNABHBFJDC;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo KOPMGPKIAIK;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo OCICLAFMABB;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x658A730", Offset = "0x6588F30", VA = "0x18658A730")]
			static BJPGEAMMKMI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		internal static class JCOKJMPNPBD
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo LCBCAACHAFM;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo DGBHAIELCKN;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo KCGBIPKCGAI;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo ODJKCHHPBGL;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo IBBACGENNKP;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo KEEBGNJFDMF;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo EKLNNDHEIJC;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo ABAMNBGEJFC;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo NGNLFHMMJLJ;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo AGHEPJOIGKF;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo BADFANGBMMP;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo FMKAIEGBLFJ;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo FLLMICJCEKO;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo NKJHOLEMGMF;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6577F40", Offset = "0x6576740", VA = "0x186577F40")]
		public static MethodInfo JMOOMJHDBEG(Type HJNJPNKDEFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6577D00", Offset = "0x6576500", VA = "0x186577D00")]
		public static MethodInfo AEDPLFCAHJC(Type HJNJPNKDEFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x65781D0", Offset = "0x65769D0", VA = "0x1865781D0")]
		public static MethodInfo LGNBBNFAHIB(Type HJNJPNKDEFH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class MIMLOJNGHLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<CAAEDJDJIPH, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public MIMLOJNGHLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class IKNKKIMPOBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public MIMLOJNGHLP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public IKNKKIMPOBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6599A50", Offset = "0x6598250", VA = "0x186599A50")]
		internal void DKJGJDNDKBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6599B50", Offset = "0x6598350", VA = "0x186599B50")]
		internal bool GGOILPBAJCA(int index, CAAEDJDJIPH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class BHMPEPHEALF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public MIMLOJNGHLP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public BHMPEPHEALF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x658A5D0", Offset = "0x6588DD0", VA = "0x18658A5D0")]
		internal bool LMPPDCMHGPC(int index, CAAEDJDJIPH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class GCPIGPADJMK
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
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public GCPIGPADJMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x30FB2B0", Offset = "0x30F9AB0", VA = "0x1830FB2B0")]
		internal string BMALFDILFGG(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class LLCGMEOJPHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public LLCGMEOJPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x659BB00", Offset = "0x659A300", VA = "0x18659BB00")]
		internal bool LNEMINGAAMI(CAAEDJDJIPH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class DBODIADPCDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public GCPIGPADJMK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public DBODIADPCDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x658C200", Offset = "0x658AA00", VA = "0x18658C200")]
		internal void FEHCAFFFCIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x658C280", Offset = "0x658AA80", VA = "0x18658C280")]
		internal bool PPJIAJDHFEH(int index, CAAEDJDJIPH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class HELDBDDFAPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public GCPIGPADJMK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public HELDBDDFAPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6596040", Offset = "0x6594840", VA = "0x186596040")]
		internal bool MKNLKJJCJCG(int index, CAAEDJDJIPH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class OIAECJDBALN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public OIAECJDBALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x65896F0", Offset = "0x6587EF0", VA = "0x1865896F0")]
		internal Label GJJPCMOCEDL(CAAEDJDJIPH _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class JPEFAADAKGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public HLIMJBAIPKE[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, CAAEDJDJIPH, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public KOACHAEHPBN argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public KOACHAEHPBN argResolver;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JPEFAADAKGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x659A3F0", Offset = "0x6598BF0", VA = "0x18659A3F0")]
		internal HLIMJBAIPKE HLIPAMPEHHP(CAAEDJDJIPH item)
		{
			return default(HLIMJBAIPKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GPNPPGHIAAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public JPEFAADAKGD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public GPNPPGHIAAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6595CF0", Offset = "0x65944F0", VA = "0x186595CF0")]
		internal void JAPNOOJMMOL(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6595FA0", Offset = "0x65947A0", VA = "0x186595FA0")]
		internal void LHBBEFCDEBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class NBBPIGDFGHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CAAEDJDJIPH item;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public NBBPIGDFGHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xAF60E0", Offset = "0xAF48E0", VA = "0x180AF60E0")]
		internal bool KFMGLAMNCND(HLIMJBAIPKE x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class LMIIJOPIIIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CAAEDJDJIPH item;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public LMIIJOPIIIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xAF60E0", Offset = "0xAF48E0", VA = "0x180AF60E0")]
		internal bool CIBAIJDBADH(HLIMJBAIPKE x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex NIBOEKDGODC;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int JBOLBDMHCCB;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> ADFCOPPFDEB;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> NFFOOHBEMGG;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x25115B0", Offset = "0x250FDB0", VA = "0x1825115B0")]
	public static object EBHJCPFKIFF<T>(BNMGGJGHHOJ LLEFEABBJBK, BFDHJNAPNBH HLAPLLMICKO, Func<string, string> AGJMGOLBABJ, bool GGNIHJAJOPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x251C830", Offset = "0x251B030", VA = "0x18251C830")]
	public static object MNGMIDBLIHM<T>(BFDHJNAPNBH HLAPLLMICKO, Func<string, string> AGJMGOLBABJ, bool GGNIHJAJOPP, bool PKOEFCPEDAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6576540", Offset = "0x6574D40", VA = "0x186576540")]
	private static TypeInfo OILGFOCMLHM(BNMGGJGHHOJ LLEFEABBJBK, Type HJNJPNKDEFH, Func<string, string> AGJMGOLBABJ, bool GGNIHJAJOPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6574A10", Offset = "0x6573210", VA = "0x186574A10")]
	public static object NOBCHAAMHIH(Type HJNJPNKDEFH, Func<string, string> AGJMGOLBABJ, bool GGNIHJAJOPP, bool PKOEFCPEDAG, bool JANIIHFFLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6576F60", Offset = "0x6575760", VA = "0x186576F60")]
	private static Dictionary<CAAEDJDJIPH, FieldInfo> PGLKDAGMDJL(TypeBuilder HEBENPPCFEO, FAADNGHOJEG GHEDPMGCDIL, ConstructorInfo JFCABJNBFNH, FieldBuilder OKKEDFJALMF, ILGenerator HKPHEBNFCGB, bool GGNIHJAJOPP, bool OCNEJIMGBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6573C70", Offset = "0x6572470", VA = "0x186573C70")]
	private static Dictionary<CAAEDJDJIPH, FieldInfo> MPELMMGIBDJ(TypeBuilder HEBENPPCFEO, FAADNGHOJEG GHEDPMGCDIL, ILGenerator HKPHEBNFCGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6572630", Offset = "0x6570E30", VA = "0x186572630")]
	private static void HAGDFHKEDID(Type HJNJPNKDEFH, FAADNGHOJEG GHEDPMGCDIL, ILGenerator HKPHEBNFCGB, Action EHEGAIGGBDP, Func<int, CAAEDJDJIPH, bool> GOOKOEIIDMM, bool GGNIHJAJOPP, bool OCNEJIMGBDB, int JICKNGOGNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x65744D0", Offset = "0x6572CD0", VA = "0x1865744D0")]
	private static void NLCGCOMNMKC(TypeInfo HJNJPNKDEFH, CAAEDJDJIPH MKBCINPICGO, ILGenerator HKPHEBNFCGB, int EAHCFBMNNCF, Func<int, CAAEDJDJIPH, bool> GOOKOEIIDMM, KOACHAEHPBN MDONNIFBLDI, KOACHAEHPBN DLGLBKNHNBP, KOACHAEHPBN DOHBMHHAIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x656FE90", Offset = "0x656E690", VA = "0x18656FE90")]
	private static void CEOFGBMJLKB(Type HJNJPNKDEFH, FAADNGHOJEG GHEDPMGCDIL, ILGenerator HKPHEBNFCGB, Func<int, CAAEDJDJIPH, bool> GOOKOEIIDMM, bool JEKJIBADMOJ, int JICKNGOGNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x656FA20", Offset = "0x656E220", VA = "0x18656FA20")]
	private static void AMHNDOABDNM(ILGenerator HKPHEBNFCGB, HLIMJBAIPKE GHEDPMGCDIL, int EAHCFBMNNCF, Func<int, CAAEDJDJIPH, bool> GOOKOEIIDMM, KOACHAEHPBN EINLOJPKPLI, KOACHAEHPBN DOHBMHHAIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x65711C0", Offset = "0x656F9C0", VA = "0x1865711C0")]
	private static LocalBuilder DOLCKDKGIMC(ILGenerator HKPHEBNFCGB, Type HJNJPNKDEFH, FAADNGHOJEG GHEDPMGCDIL, HLIMJBAIPKE[] NFMAFICIMGJ, bool LMIKNKLOCCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6571F50", Offset = "0x6570750", VA = "0x186571F50")]
	private static bool EKGBDBNIHJE(ConstructorInfo GAGDNMLLFDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6574350", Offset = "0x6572B50", VA = "0x186574350")]
	private static bool NKNHOHNBNAG(Type HJNJPNKDEFH, [Out] Type IOMJPIFHDKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate void COGPOJMFCDM<T>(byte[][] OKKEDFJALMF, object[] PCKDNMCCFNI, BPGOOCGBHEB MDONNIFBLDI, T DOLICEBFIPF, BFDHJNAPNBH MBINCLEAPPN);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal delegate T HJJDJPEIABF<T>(object[] PCKDNMCCFNI, MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH MBINCLEAPPN);
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class BGHJFJFGOAN<T> : OGEKILALGOF<T>, LMLLDOBHGKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] OKKEDFJALMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] IJJLBIOILJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] FOKELEPLJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly COGPOJMFCDM<T> GFDFAAHPKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly HJJDJPEIABF<T> KKLCHNLEDAC;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1CAC790", Offset = "0x1CAAF90", VA = "0x181CAC790")]
	public BGHJFJFGOAN(byte[][] OKKEDFJALMF, object[] IJJLBIOILJM, object[] FOKELEPLJCF, COGPOJMFCDM<T> GFDFAAHPKIL, HJJDJPEIABF<T> KKLCHNLEDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x458B190", Offset = "0x4589990", VA = "0x18458B190", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, T DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x458B0A0", Offset = "0x45898A0", VA = "0x18458B0A0", Slot = "5")]
	public T AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class MBBPCAFEHDI : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private static class IFLPNKDHPIE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x36AAAA0", Offset = "0x36A92A0", VA = "0x1836AAAA0")]
		static IFLPNKDHPIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private MBBPCAFEHDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class GHLFCILNDHG : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private static class FJMEEJCKMFA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x346FFB0", Offset = "0x346E7B0", VA = "0x18346FFB0")]
		static FJMEEJCKMFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private GHLFCILNDHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal static class MDABHHGHNCO
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly BFDHJNAPNBH[] IIEGNJDBCAD;
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class GDECFHLDNLO : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class CDMNGGPCBOP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x48E7500", Offset = "0x48E5D00", VA = "0x1848E7500")]
		static CDMNGGPCBOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class FKFKHKFGGKH : BFDHJNAPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		private static class DEFKBMNOOJB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x4DD1080", Offset = "0x4DCF880", VA = "0x184DD1080")]
			static DEFKBMNOOJB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly BFDHJNAPNBH ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly BFDHJNAPNBH[] EAPBDGDKALK;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		private FKFKHKFGGKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
		public OGEKILALGOF<T> LEHAIOIGGJE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly OGEKILALGOF<object> JOAAEPLAINM;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private GDECFHLDNLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class JCLJAJKHLFJ : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private static class CHJEMEAMLHH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x49CCAC0", Offset = "0x49CB2C0", VA = "0x1849CCAC0")]
		static CHJEMEAMLHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class ANIMEHBDDJN : BFDHJNAPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		private static class IJBHAIGJJKO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x36C0A80", Offset = "0x36BF280", VA = "0x1836C0A80")]
			static IJBHAIGJJKO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly BFDHJNAPNBH ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly BFDHJNAPNBH[] EAPBDGDKALK;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		private ANIMEHBDDJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
		public OGEKILALGOF<T> LEHAIOIGGJE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly OGEKILALGOF<object> JOAAEPLAINM;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private JCLJAJKHLFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class MOBEJBIHAGC : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private static class OMNCLHMECFC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3E39210", Offset = "0x3E37A10", VA = "0x183E39210")]
		static OMNCLHMECFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class BABDMLKJGBL : BFDHJNAPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private static class PDBEEHCJOBO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3EECA80", Offset = "0x3EEB280", VA = "0x183EECA80")]
			static PDBEEHCJOBO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly BFDHJNAPNBH ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly BFDHJNAPNBH[] EAPBDGDKALK;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		private BABDMLKJGBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
		public OGEKILALGOF<T> LEHAIOIGGJE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly OGEKILALGOF<object> JOAAEPLAINM;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private MOBEJBIHAGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal sealed class FDONHMBDJHK : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private static class MIAHGBEAGCO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3C920F0", Offset = "0x3C908F0", VA = "0x183C920F0")]
		static MIAHGBEAGCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class NOMGBJMOMFB : BFDHJNAPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		private static class HMHGPKBJFKK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x35C9B90", Offset = "0x35C8390", VA = "0x1835C9B90")]
			static HMHGPKBJFKK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly BFDHJNAPNBH ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly BFDHJNAPNBH[] EAPBDGDKALK;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		private NOMGBJMOMFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
		public OGEKILALGOF<T> LEHAIOIGGJE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly OGEKILALGOF<object> JOAAEPLAINM;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private FDONHMBDJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class EPOFIJFFGCI : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private static class KCPDHCNGGDF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x38E47A0", Offset = "0x38E2FA0", VA = "0x1838E47A0")]
		static KCPDHCNGGDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class BNGDIFICMHA : BFDHJNAPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		private static class BCIILKAFDLF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x45740B0", Offset = "0x45728B0", VA = "0x1845740B0")]
			static BCIILKAFDLF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly BFDHJNAPNBH ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly BFDHJNAPNBH[] EAPBDGDKALK;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		private BNGDIFICMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
		public OGEKILALGOF<T> LEHAIOIGGJE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly OGEKILALGOF<object> JOAAEPLAINM;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private EPOFIJFFGCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class DFONAKGHJFF : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private static class PPJPOPKDAOJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3F1FBC0", Offset = "0x3F1E3C0", VA = "0x183F1FBC0")]
		static PPJPOPKDAOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private sealed class PDOGAKMNFAO : BFDHJNAPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		private static class MBKMNBIKEJP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3C42C00", Offset = "0x3C41400", VA = "0x183C42C00")]
			static MBKMNBIKEJP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly BFDHJNAPNBH ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly BFDHJNAPNBH[] EAPBDGDKALK;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		private PDOGAKMNFAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
		public OGEKILALGOF<T> LEHAIOIGGJE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly OGEKILALGOF<object> JOAAEPLAINM;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private DFONAKGHJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal sealed class MJKKHBCOCKE : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private static class ABBLLONHHNP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3539950", Offset = "0x3538150", VA = "0x183539950")]
		static ABBLLONHHNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private sealed class KHHFJHJNCBK : BFDHJNAPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		private static class EBFIHHPOKPN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x30F18B0", Offset = "0x30F00B0", VA = "0x1830F18B0")]
			static EBFIHHPOKPN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly BFDHJNAPNBH ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly BFDHJNAPNBH[] EAPBDGDKALK;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		private KHHFJHJNCBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
		public OGEKILALGOF<T> LEHAIOIGGJE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly OGEKILALGOF<object> JOAAEPLAINM;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private MJKKHBCOCKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal sealed class MDLPHLGBEIF : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private static class KLCJMOOLKCC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x39056A0", Offset = "0x3903EA0", VA = "0x1839056A0")]
		static KLCJMOOLKCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private sealed class MOGHBDCIFPB : BFDHJNAPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private static class IGKFIMDJGNP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x36B69B0", Offset = "0x36B51B0", VA = "0x1836B69B0")]
			static IGKFIMDJGNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly BFDHJNAPNBH ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly BFDHJNAPNBH[] EAPBDGDKALK;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		private MOGHBDCIFPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
		public OGEKILALGOF<T> LEHAIOIGGJE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly OGEKILALGOF<object> JOAAEPLAINM;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private MDLPHLGBEIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal sealed class LAPJKNIKOJO : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private static class PCNMFEMOBIG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3EE92D0", Offset = "0x3EE7AD0", VA = "0x183EE92D0")]
		static PCNMFEMOBIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private sealed class IAIAFGIPDAM : BFDHJNAPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		private static class NKEBKLJJJLE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3D2B660", Offset = "0x3D29E60", VA = "0x183D2B660")]
			static NKEBKLJJJLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly BFDHJNAPNBH ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly BFDHJNAPNBH[] EAPBDGDKALK;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		private IAIAFGIPDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
		public OGEKILALGOF<T> LEHAIOIGGJE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly OGEKILALGOF<object> JOAAEPLAINM;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private LAPJKNIKOJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal sealed class NACIMHJEBGP : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private static class PGNJHCOEHMD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3EF3720", Offset = "0x3EF1F20", VA = "0x183EF3720")]
		static PGNJHCOEHMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private sealed class KMDIPJOJDII : BFDHJNAPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		private static class PKJLLJJHDJK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x3F0F3E0", Offset = "0x3F0DBE0", VA = "0x183F0F3E0")]
			static PKJLLJJHDJK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly BFDHJNAPNBH ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly BFDHJNAPNBH[] EAPBDGDKALK;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		private KMDIPJOJDII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
		public OGEKILALGOF<T> LEHAIOIGGJE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly OGEKILALGOF<object> JOAAEPLAINM;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private NACIMHJEBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal sealed class AHBPCMPIKBB : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private static class DAPMGDABNDN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4DAC830", Offset = "0x4DAB030", VA = "0x184DAC830")]
		static DAPMGDABNDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private sealed class KGAKFIIKMGH : BFDHJNAPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		private static class EALNJFLGDPC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x30EC520", Offset = "0x30EAD20", VA = "0x1830EC520")]
			static EALNJFLGDPC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly BFDHJNAPNBH ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly BFDHJNAPNBH[] EAPBDGDKALK;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		private KGAKFIIKMGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
		public OGEKILALGOF<T> LEHAIOIGGJE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly OGEKILALGOF<object> JOAAEPLAINM;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private AHBPCMPIKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
internal sealed class CPEAMFLPIHJ : BFDHJNAPNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private static class NLIMIDJECHJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3D399F0", Offset = "0x3D381F0", VA = "0x183D399F0")]
		static NLIMIDJECHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private sealed class ODANJECGKDI : BFDHJNAPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		private static class HLDKJHKIAKO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly OGEKILALGOF<T> BLLEIDBCPFO;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x35C2570", Offset = "0x35C0D70", VA = "0x1835C2570")]
			static HLDKJHKIAKO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly BFDHJNAPNBH ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly BFDHJNAPNBH[] EAPBDGDKALK;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		private ODANJECGKDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
		public OGEKILALGOF<T> LEHAIOIGGJE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly BFDHJNAPNBH ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly OGEKILALGOF<object> JOAAEPLAINM;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	private CPEAMFLPIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	public OGEKILALGOF<T> LEHAIOIGGJE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct GANCJCAKJPF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] KANFBGCPLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int PCGHIJCLEAB;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3514A00", Offset = "0x3513200", VA = "0x183514A00")]
	public GANCJCAKJPF(int MNJPAOOFLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3514760", Offset = "0x3512F60", VA = "0x183514760")]
	public void INCGBOEKEGG(T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3514530", Offset = "0x3512D30", VA = "0x183514530")]
	public T[] DNACNEAACPA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal sealed class MOBOEBDLJPM : BGANGDEDFBI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly MOBOEBDLJPM FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x659C400", Offset = "0x659AC00", VA = "0x18659C400")]
	public MOBOEBDLJPM(int GCOBFCMOLMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class BGANGDEDFBI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int GCOBFCMOLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object JNOEHCJJJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int EAHCFBMNNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] DDOACNBDNHI;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4589170", Offset = "0x4587970", VA = "0x184589170")]
	public BGANGDEDFBI(int GCOBFCMOLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4587F70", Offset = "0x4586770", VA = "0x184587F70")]
	public T[] AKIGIEFDJGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4588930", Offset = "0x4587130", VA = "0x184588930")]
	public void NHPLPNOGLPD(T[] CMKNCDNHDNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class JPMOGNBDGPH : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private class DCLHNACGCHD : IComparable<DCLHNACGCHD>
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class OHHILMHONPK : IEnumerable<DCLHNACGCHD>, IEnumerable, IEnumerator<DCLHNACGCHD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private DCLHNACGCHD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public DCLHNACGCHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private DCLHNACGCHD System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8F6270", Offset = "0x8F4A70", VA = "0x1808F6270")]
			[DebuggerHidden]
			public OHHILMHONPK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x659E660", Offset = "0x659CE60", VA = "0x18659E660", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x659E790", Offset = "0x659CF90", VA = "0x18659E790", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x659E6E0", Offset = "0x659CEE0", VA = "0x18659E6E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<DCLHNACGCHD> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x659E6E0", Offset = "0x659CEE0", VA = "0x18659E6E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class BBFELCIDLJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public BBFELCIDLJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x65896F0", Offset = "0x6587EF0", VA = "0x1865896F0")]
			internal Label FJNMACCFMAF(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x65896F0", Offset = "0x6587EF0", VA = "0x1865896F0")]
			internal Label IFDCOOFBGLI(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly DCLHNACGCHD[] PAEDJLEKMCE;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] HNMGGBAKLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong GKFGCIJBLGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int HMHFMLFLMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string KHLCMHKHBBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private DCLHNACGCHD[] EPLFEKBPJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] DFIEHPGMMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int PPKDCOOCBKP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool AKIBHJGPGLN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x50BD600", Offset = "0x50BBE00", VA = "0x1850BD600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x658DA90", Offset = "0x658C290", VA = "0x18658DA90")]
		public DCLHNACGCHD(ulong EMBEECDJLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x658C780", Offset = "0x658AF80", VA = "0x18658C780")]
		public DCLHNACGCHD INCGBOEKEGG(ulong EMBEECDJLJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x658C720", Offset = "0x658AF20", VA = "0x18658C720")]
		public DCLHNACGCHD INCGBOEKEGG(ulong EMBEECDJLJB, int DOLICEBFIPF, string KHLCMHKHBBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x658C520", Offset = "0x658AD20", VA = "0x18658C520")]
		public DCLHNACGCHD GMAMLKIONFK(byte[] NDMBOLPNCGE, int IJJNAEFKMHG, int CDKNFNFMFBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x658C490", Offset = "0x658AC90", VA = "0x18658C490")]
		internal static int DKCBPDGAJBO(ulong[] CMKNCDNHDNA, int EAHCFBMNNCF, int BONCBNKGOGN, ulong DOLICEBFIPF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x658C460", Offset = "0x658AC60", VA = "0x18658C460", Slot = "4")]
		public int CompareTo(DCLHNACGCHD FPJCFKAMJHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x658C6A0", Offset = "0x658AEA0", VA = "0x18658C6A0")]
		[IteratorStateMachine(typeof(OHHILMHONPK))]
		public IEnumerable<DCLHNACGCHD> IKGBDHJALKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x658C980", Offset = "0x658B180", VA = "0x18658C980")]
		public void KFNJLFCDGFJ(ILGenerator HKPHEBNFCGB, LocalBuilder NDMBOLPNCGE, LocalBuilder CDKNFNFMFBN, LocalBuilder EMBEECDJLJB, Action<KeyValuePair<string, int>> LFNKPCPFHOI, Action FLNODAGHJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x658CD00", Offset = "0x658B500", VA = "0x18658CD00")]
		private static void LPDLIGHLOJK(ILGenerator HKPHEBNFCGB, LocalBuilder NDMBOLPNCGE, LocalBuilder CDKNFNFMFBN, LocalBuilder EMBEECDJLJB, Action<KeyValuePair<string, int>> LFNKPCPFHOI, Action FLNODAGHJID, DCLHNACGCHD[] EPLFEKBPJDF, int PPKDCOOCBKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class BGDKNONODPJ : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<DCLHNACGCHD> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<DCLHNACGCHD> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<DCLHNACGCHD> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private DCLHNACGCHD <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x9FDA30", Offset = "0x9FC230", VA = "0x1809FDA30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x658A430", Offset = "0x6588C30", VA = "0x18658A430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1BCDA90", Offset = "0x1BCC290", VA = "0x181BCDA90")]
		[DebuggerHidden]
		public BGDKNONODPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x658A480", Offset = "0x6588C80", VA = "0x18658A480", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6589E80", Offset = "0x6588680", VA = "0x186589E80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6589E30", Offset = "0x6588630", VA = "0x186589E30")]
		private void JLELDKFKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x658A2E0", Offset = "0x6588AE0", VA = "0x18658A2E0")]
		private void PHMELMLAGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x658A3E0", Offset = "0x6588BE0", VA = "0x18658A3E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x658A330", Offset = "0x6588B30", VA = "0x18658A330", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x658A330", Offset = "0x6588B30", VA = "0x18658A330", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly DCLHNACGCHD PHEKGOFMNOB;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x659AB80", Offset = "0x6599380", VA = "0x18659AB80")]
	public JPMOGNBDGPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x659A680", Offset = "0x6598E80", VA = "0x18659A680")]
	public void INCGBOEKEGG(byte[] OCKHPPLPLMN, int DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x659A540", Offset = "0x6598D40", VA = "0x18659A540")]
	public bool GLDDLCBJGEM(ArraySegment<byte> EMBEECDJLJB, [Out] int DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x659AAF0", Offset = "0x65992F0", VA = "0x18659AAF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x659A810", Offset = "0x6599010", VA = "0x18659A810")]
	private static void MBHGLOKPBIK(IEnumerable<DCLHNACGCHD> EPLFEKBPJDF, StringBuilder OEPBJHNDPGI, int LCPEGFJBFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x659A620", Offset = "0x6598E20", VA = "0x18659A620", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x659A620", Offset = "0x6598E20", VA = "0x18659A620", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x659A790", Offset = "0x6598F90", VA = "0x18659A790")]
	[IteratorStateMachine(typeof(BGDKNONODPJ))]
	private static IEnumerable<KeyValuePair<string, int>> IOOPIEPPGPE(IEnumerable<DCLHNACGCHD> EPLFEKBPJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x659A510", Offset = "0x6598D10", VA = "0x18659A510")]
	public void GIIOGJPHONI(ILGenerator HKPHEBNFCGB, LocalBuilder NDMBOLPNCGE, LocalBuilder CDKNFNFMFBN, LocalBuilder EMBEECDJLJB, Action<KeyValuePair<string, int>> LFNKPCPFHOI, Action FLNODAGHJID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class ICKPHJILGCF
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo DMPDOOIAJPK;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6598AA0", Offset = "0x65972A0", VA = "0x186598AA0")]
	public static ulong EPPOGHGIALH(byte[] OCKHPPLPLMN, int IJJNAEFKMHG, int CDKNFNFMFBN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class IJDFKAHOFIM
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x65997F0", Offset = "0x6597FF0", VA = "0x1865997F0")]
	public static void JNDFIMFJJIA(byte[] OCKHPPLPLMN, int IJJNAEFKMHG, int AFONIEHJLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6599930", Offset = "0x6598130", VA = "0x186599930")]
	public static void KDIPCBFEOKH(byte[] CMKNCDNHDNA, int CIALMHHACCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x65996C0", Offset = "0x6597EC0", VA = "0x1865996C0")]
	public static byte[] HGDBNMDMCNK(byte[] MHGKACIOCHE, int CIALMHHACCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class HPJIHHKBJMG
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6598860", Offset = "0x6597060", VA = "0x186598860")]
	public static bool BBMNINIFJOH(byte[] LLBAAHNJDIH, int BNIOHEPJGHD, int FABLMIDBJBA, byte[] PBNEOFEMLPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal class LECCIKGIKKO<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private struct BFDHKKJCGOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] GKFGCIJBLGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T HMHFMLFLMGB;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x4582C80", Offset = "0x4581480", VA = "0x184582C80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class MJJDMBEJNJM : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public LECCIKGIKKO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private BFDHKKJCGOJ[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private BFDHKKJCGOJ[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x9FDA30", Offset = "0x9FC230", VA = "0x1809FDA30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x34C2430", Offset = "0x34C0C30", VA = "0x1834C2430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
		[DebuggerHidden]
		public MJJDMBEJNJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3C9C8B0", Offset = "0x3C9B0B0", VA = "0x183C9C8B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3C9E220", Offset = "0x3C9CA20", VA = "0x183C9E220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly BFDHKKJCGOJ[][] HDKDFBPJGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong ODMFAIKGLKO;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x39FEB50", Offset = "0x39FD350", VA = "0x1839FEB50")]
	public LECCIKGIKKO(int JHAJBCMGPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x39FEA90", Offset = "0x39FD290", VA = "0x1839FEA90")]
	public LECCIKGIKKO(int JHAJBCMGPDO, float CCGKPPOHNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x39F6B70", Offset = "0x39F5370", VA = "0x1839F6B70")]
	public void INCGBOEKEGG(byte[] EMBEECDJLJB, T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x39FA670", Offset = "0x39F8E70", VA = "0x1839FA670")]
	private bool PBAMMHAHGMD(byte[] EMBEECDJLJB, T DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x39FDD50", Offset = "0x39FC550", VA = "0x1839FDD50")]
	public bool POGGOEPLKIB(ArraySegment<byte> EMBEECDJLJB, [Out] T DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x39F6500", Offset = "0x39F4D00", VA = "0x1839F6500")]
	private static ulong EMBPBAHKBMJ(byte[] GJPJIELLCID, int IJJNAEFKMHG, int PPKDCOOCBKP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x36C1E20", Offset = "0x36C0620", VA = "0x1836C1E20")]
	private static int DHBICFOKODF(int FGDLLOLDPHC, float CCGKPPOHNNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x39F6550", Offset = "0x39F4D50", VA = "0x1839F6550", Slot = "4")]
	[IteratorStateMachine(typeof(LECCIKGIKKO<>.MJJDMBEJNJM))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x33B0CC0", Offset = "0x33AF4C0", VA = "0x1833B0CC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class HKACNEBNAOA : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] AJBDDICNHPA;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] OADLPMPBEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int AGMLLMKIFBH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool JIMEJCPEAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6596320", Offset = "0x6594B20", VA = "0x186596320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6596370", Offset = "0x6594B70", VA = "0x186596370")]
	static HKACNEBNAOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x65965D0", Offset = "0x6594DD0", VA = "0x1865965D0")]
	public HKACNEBNAOA(byte[] DIDMEPIFMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6596220", Offset = "0x6594A20", VA = "0x186596220")]
	public OpCode GMDHPCEPAAN()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct ENMKDEALION
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid HMHFMLFLMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte FKCANOHFNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte AHHGGCBOJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte DIMHPJEDHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte NBEKPDLPGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte BILKCFFMPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte FNGDHKGNEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte CHLCIFCKIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte AIOLOBEIMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte HAGFMPCEFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte BGLMKIDMNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte OEOKLCLLFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte AACKPGDADFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte KAFIMKCOGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte JHFOMJHOBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte OIAINOFJFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte PBGHPINGMDK;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] IHEFFEDKDHM;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] MFEOCOAOJAM;

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6591FE0", Offset = "0x65907E0", VA = "0x186591FE0")]
	public ENMKDEALION(Guid DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6591FF0", Offset = "0x65907F0", VA = "0x186591FF0")]
	public ENMKDEALION(ArraySegment<byte> FFKKEGPFLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6591D30", Offset = "0x6590530", VA = "0x186591D30")]
	private static byte CGCGCHEHFFD(byte[] OCKHPPLPLMN, int EKEEBIFHNHH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6591DD0", Offset = "0x65905D0", VA = "0x186591DD0")]
	private static byte PPNIMCFICKJ(byte KIOLHHMPBGL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6591080", Offset = "0x658F880", VA = "0x186591080")]
	public void AFHOGBCJPKC(byte[] IJPAPFCFHAF, int IJJNAEFKMHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class EEKDADIJCED
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x658FAE0", Offset = "0x658E2E0", VA = "0x18658FAE0")]
	public static bool EGKGIAEGLED(byte DNNFFPMDBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x658FED0", Offset = "0x658E6D0", VA = "0x18658FED0")]
	public static bool KDDFJKOPPLL(byte DNNFFPMDBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x658FFC0", Offset = "0x658E7C0", VA = "0x18658FFC0")]
	public static sbyte NHLKKIANHJO(byte[] OCKHPPLPLMN, int IJJNAEFKMHG, [Out] int HCLNKOJJJIG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x658FB70", Offset = "0x658E370", VA = "0x18658FB70")]
	public static short FFOMADGPKPJ(byte[] OCKHPPLPLMN, int IJJNAEFKMHG, [Out] int HCLNKOJJJIG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x658FDE0", Offset = "0x658E5E0", VA = "0x18658FDE0")]
	public static int IMKADFBIEIP(byte[] OCKHPPLPLMN, int IJJNAEFKMHG, [Out] int HCLNKOJJJIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x658F000", Offset = "0x658D800", VA = "0x18658F000")]
	public static long BNKICLNGKJI(byte[] OCKHPPLPLMN, int IJJNAEFKMHG, [Out] int HCLNKOJJJIG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x658F0A0", Offset = "0x658D8A0", VA = "0x18658F0A0")]
	public static byte CHIDBIHCHEC(byte[] OCKHPPLPLMN, int IJJNAEFKMHG, [Out] int HCLNKOJJJIG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x658FAF0", Offset = "0x658E2F0", VA = "0x18658FAF0")]
	public static ushort FFJGDLKPKEF(byte[] OCKHPPLPLMN, int IJJNAEFKMHG, [Out] int HCLNKOJJJIG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x658FF40", Offset = "0x658E740", VA = "0x18658FF40")]
	public static uint LKFFHANDCMJ(byte[] OCKHPPLPLMN, int IJJNAEFKMHG, [Out] int HCLNKOJJJIG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x658FCD0", Offset = "0x658E4D0", VA = "0x18658FCD0")]
	public static ulong HNMCLDBFJHI(byte[] OCKHPPLPLMN, int IJJNAEFKMHG, [Out] int HCLNKOJJJIG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x658E8F0", Offset = "0x658D0F0", VA = "0x18658E8F0")]
	public static float AICBJIGLGNM(byte[] OCKHPPLPLMN, int IJJNAEFKMHG, [Out] int HCLNKOJJJIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x658FC60", Offset = "0x658E460", VA = "0x18658FC60")]
	public static double GCAJFBOKDAP(byte[] OCKHPPLPLMN, int IJJNAEFKMHG, [Out] int HCLNKOJJJIG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x658E960", Offset = "0x658D160", VA = "0x18658E960")]
	public static int BGKIKABJBBH(byte[] IJPAPFCFHAF, int IJJNAEFKMHG, ulong DOLICEBFIPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x658F120", Offset = "0x658D920", VA = "0x18658F120")]
	public static int DEAHKNPMGLN(byte[] IJPAPFCFHAF, int IJJNAEFKMHG, long DOLICEBFIPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x65900A0", Offset = "0x658E8A0", VA = "0x1865900A0")]
	public static bool PPFLPCEKOHN(byte[] OCKHPPLPLMN, int IJJNAEFKMHG, [Out] int HCLNKOJJJIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class PELOPAFLIII
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class DODLKBCIOAA : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8F6270", Offset = "0x8F4A70", VA = "0x1808F6270")]
		[DebuggerHidden]
		public DODLKBCIOAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x658E7C0", Offset = "0x658CFC0", VA = "0x18658E7C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x658E230", Offset = "0x658CA30", VA = "0x18658E230", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x658E1E0", Offset = "0x658C9E0", VA = "0x18658E1E0")]
		private void JLELDKFKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x658E660", Offset = "0x658CE60", VA = "0x18658E660")]
		private void PHMELMLAGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x658E770", Offset = "0x658CF70", VA = "0x18658E770", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x658E6B0", Offset = "0x658CEB0", VA = "0x18658E6B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x658E6B0", Offset = "0x658CEB0", VA = "0x18658E6B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class BBJAMFLCDMN : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8F6270", Offset = "0x8F4A70", VA = "0x1808F6270")]
		[DebuggerHidden]
		public BBJAMFLCDMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6589D00", Offset = "0x6588500", VA = "0x186589D00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6589770", Offset = "0x6587F70", VA = "0x186589770", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6589720", Offset = "0x6587F20", VA = "0x186589720")]
		private void JLELDKFKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6589BA0", Offset = "0x65883A0", VA = "0x186589BA0")]
		private void PHMELMLAGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6589CB0", Offset = "0x65884B0", VA = "0x186589CB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6589BF0", Offset = "0x65883F0", VA = "0x186589BF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6589BF0", Offset = "0x65883F0", VA = "0x186589BF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x659EAE0", Offset = "0x659D2E0", VA = "0x18659EAE0")]
	public static bool AMFAHLAKIAF(this TypeInfo HJNJPNKDEFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x659E9B0", Offset = "0x659D1B0", VA = "0x18659E9B0")]
	public static bool AIPIOPALEPL(this TypeInfo HJNJPNKDEFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x659EC20", Offset = "0x659D420", VA = "0x18659EC20")]
	public static IEnumerable<PropertyInfo> ENFLENGGNMN(this Type HJNJPNKDEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x659ECA0", Offset = "0x659D4A0", VA = "0x18659ECA0")]
	[IteratorStateMachine(typeof(DODLKBCIOAA))]
	private static IEnumerable<PropertyInfo> KKLEEGHJKBJ(Type HJNJPNKDEFH, HashSet<string> HFIDBJNHGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x659EBA0", Offset = "0x659D3A0", VA = "0x18659EBA0")]
	public static IEnumerable<FieldInfo> BHIIOLLLDOC(this Type HJNJPNKDEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x659ED40", Offset = "0x659D540", VA = "0x18659ED40")]
	[IteratorStateMachine(typeof(BBJAMFLCDMN))]
	private static IEnumerable<FieldInfo> LNILHKGAPEH(Type HJNJPNKDEFH, HashSet<string> HFIDBJNHGCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class OGEJHAALPGP
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding FLFENOBBIOG;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal static class ABNFIAEEBCD
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
	public static string IAAPEDMFAIE(string KADLHIPLPMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6587EF0", Offset = "0x65866F0", VA = "0x186587EF0")]
	public static string PCFAAMKFADF(string KADLHIPLPMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6587D60", Offset = "0x6586560", VA = "0x186587D60")]
	public static string PBHCAADAKFK(string KADLHIPLPMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class IKBJOPMDILN<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class HCIHFIAPIEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type GKFGCIJBLGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue HMHFMLFLMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int EAAOJPOHBBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public HCIHFIAPIEA GAFBCNBLEBB;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x358BAE0", Offset = "0x358A2E0", VA = "0x18358BAE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x358B9D0", Offset = "0x358A1D0", VA = "0x18358B9D0")]
		private int CADPCMFLDGP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public HCIHFIAPIEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class JDMOAMOIFEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JDMOAMOIFEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xB2AA00", Offset = "0xB29200", VA = "0x180B2AA00")]
		internal TValue IHPDFJKNCEO(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private HCIHFIAPIEA[] HDKDFBPJGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int NKCDHJPJBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object BJOBPFHFIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float CCGKPPOHNNG;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x36C3070", Offset = "0x36C1870", VA = "0x1836C3070")]
	public IKBJOPMDILN(int JHAJBCMGPDO = 4, float CCGKPPOHNNG = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x36C1B70", Offset = "0x36C0370", VA = "0x1836C1B70")]
	public bool CNOMDMOJGEA(Type EMBEECDJLJB, TValue DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x36C1B30", Offset = "0x36C0330", VA = "0x1836C1B30")]
	public bool CNOMDMOJGEA(Type EMBEECDJLJB, Func<Type, TValue> KHHJODIAMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x36C2990", Offset = "0x36C1190", VA = "0x1836C2990")]
	private bool PBAMMHAHGMD(Type EMBEECDJLJB, Func<Type, TValue> KHHJODIAMEF, [Out] TValue LEMKAIJNKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x36C1E80", Offset = "0x36C0680", VA = "0x1836C1E80")]
	private bool HCLHOCHBCNF(HCIHFIAPIEA[] HDKDFBPJGMC, Type LFDBIMOPLHD, HCIHFIAPIEA PCOKKLLOBLC, Func<Type, TValue> KHHJODIAMEF, [Out] TValue LEMKAIJNKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x36C2CF0", Offset = "0x36C14F0", VA = "0x1836C2CF0")]
	public bool POGGOEPLKIB(Type EMBEECDJLJB, [Out] TValue DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x36C1A80", Offset = "0x36C0280", VA = "0x1836C1A80")]
	public TValue ABAGPILCCJJ(Type EMBEECDJLJB, Func<Type, TValue> KHHJODIAMEF)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x36C1E20", Offset = "0x36C0620", VA = "0x1836C1E20")]
	private static int DHBICFOKODF(int FGDLLOLDPHC, float CCGKPPOHNNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x36C1E50", Offset = "0x36C0650", VA = "0x1836C1E50")]
	private static void DJMCEPLEIPB(HCIHFIAPIEA DDBCLAHLAOB, HCIHFIAPIEA DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x36C1E50", Offset = "0x36C0650", VA = "0x1836C1E50")]
	private static void DJMCEPLEIPB(HCIHFIAPIEA[] DDBCLAHLAOB, HCIHFIAPIEA[] DOLICEBFIPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class BNMGGJGHHOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder MOBFLCAPHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder ACBDECJNCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object JNOEHCJJJBO;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x658B4C0", Offset = "0x6589CC0", VA = "0x18658B4C0")]
	public TypeBuilder FJLIKIMCDEK(string PMDCAPIFBIP, TypeAttributes CBHMEBIKHAI, Type DEINPDMGBDC, Type[] PHICCAAPFCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x658B5C0", Offset = "0x6589DC0", VA = "0x18658B5C0")]
	public BNMGGJGHHOJ(string GHOIOHDICGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal static class AIDCJJHKOCH
{
	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6589270", Offset = "0x6587A70", VA = "0x186589270")]
	private static MethodInfo JJOEDPHLFOG(LambdaExpression PGIILIAAAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2B26C30", Offset = "0x2B25430", VA = "0x182B26C30")]
	public static MethodInfo DDNIJFPCICG<T>(Expression<Func<T>> PGIILIAAAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2B26C30", Offset = "0x2B25430", VA = "0x182B26C30")]
	public static MethodInfo DDNIJFPCICG<T, TR>(Expression<Func<T, TR>> PGIILIAAAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2B26C30", Offset = "0x2B25430", VA = "0x182B26C30")]
	public static MethodInfo DDNIJFPCICG<T>(Expression<Action<T>> PGIILIAAAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2B26C30", Offset = "0x2B25430", VA = "0x182B26C30")]
	public static MethodInfo DDNIJFPCICG<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> PGIILIAAAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2B26C40", Offset = "0x2B25440", VA = "0x182B26C40")]
	private static MemberInfo IGPJDNLCBGJ<T>(Expression<T> PCNNAKCFNJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2B26D20", Offset = "0x2B25520", VA = "0x182B26D20")]
	public static PropertyInfo OMCBOGIJNLB<T, TR>(Expression<Func<T, TR>> PGIILIAAAMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal struct KOACHAEHPBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int BOCONGADANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool JPABBIMMMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator HKPHEBNFCGB;

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x659B940", Offset = "0x659A140", VA = "0x18659B940")]
	public KOACHAEHPBN(ILGenerator HKPHEBNFCGB, int BOCONGADANC, bool JPABBIMMMHK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x659B8B0", Offset = "0x659A0B0", VA = "0x18659B8B0")]
	public KOACHAEHPBN(ILGenerator HKPHEBNFCGB, int BOCONGADANC, Type HJNJPNKDEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x659B7B0", Offset = "0x6599FB0", VA = "0x18659B7B0")]
	public void PADJFOMEMNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class AGGDGCCKKCK
{
	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6588F00", Offset = "0x6587700", VA = "0x186588F00")]
	public static void OKJFECDKJGK(this ILGenerator HKPHEBNFCGB, int EAHCFBMNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6588EC0", Offset = "0x65876C0", VA = "0x186588EC0")]
	public static void OKJFECDKJGK(this ILGenerator HKPHEBNFCGB, LocalBuilder FNMODDLEADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x65884F0", Offset = "0x6586CF0", VA = "0x1865884F0")]
	public static void FMBPDKDBJHJ(this ILGenerator HKPHEBNFCGB, int EAHCFBMNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x65884B0", Offset = "0x6586CB0", VA = "0x1865884B0")]
	public static void FMBPDKDBJHJ(this ILGenerator HKPHEBNFCGB, LocalBuilder FNMODDLEADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6588CE0", Offset = "0x65874E0", VA = "0x186588CE0")]
	public static void OAPGGOPACDP(this ILGenerator HKPHEBNFCGB, int EAHCFBMNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6588DC0", Offset = "0x65875C0", VA = "0x186588DC0")]
	public static void OAPGGOPACDP(this ILGenerator HKPHEBNFCGB, LocalBuilder FNMODDLEADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6588BB0", Offset = "0x65873B0", VA = "0x186588BB0")]
	public static void IICBHAKNNNH(this ILGenerator HKPHEBNFCGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6588CD0", Offset = "0x65874D0", VA = "0x186588CD0")]
	public static void NPLDKIMKOLM(this ILGenerator HKPHEBNFCGB, bool DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x65886E0", Offset = "0x6586EE0", VA = "0x1865886E0")]
	public static void HGCEBFNHPFO(this ILGenerator HKPHEBNFCGB, int DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6588140", Offset = "0x6586940", VA = "0x186588140")]
	public static void CEMPBALNAFE(this ILGenerator HKPHEBNFCGB, Type HJNJPNKDEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6588410", Offset = "0x6586C10", VA = "0x186588410")]
	public static void FFKJPAFGGJN(this ILGenerator HKPHEBNFCGB, Type HJNJPNKDEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x6588220", Offset = "0x6586A20", VA = "0x186588220")]
	public static void ELDCCEKPOEP(this ILGenerator HKPHEBNFCGB, int EAHCFBMNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x6588C50", Offset = "0x6587450", VA = "0x186588C50")]
	public static void KEPFPGFJEAO(this ILGenerator HKPHEBNFCGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6588060", Offset = "0x6586860", VA = "0x186588060")]
	public static void BCNFJAGNCIH(this ILGenerator HKPHEBNFCGB, int EAHCFBMNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x6588AC0", Offset = "0x65872C0", VA = "0x186588AC0")]
	public static void HPJBIALGCNI(this ILGenerator HKPHEBNFCGB, MethodInfo COFHIDPLIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x6587FD0", Offset = "0x65867D0", VA = "0x186587FD0")]
	public static void ADPEKBKFGNK(this ILGenerator HKPHEBNFCGB, FieldInfo AEEBMCOGGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6588BC0", Offset = "0x65873C0", VA = "0x186588BC0")]
	public static void JLJNCGEPJHP(this ILGenerator HKPHEBNFCGB, ulong DOLICEBFIPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class CAAEDJDJIPH
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class NNEKBONLGFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public NNEKBONLGFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x659E120", Offset = "0x659C920", VA = "0x18659E120")]
		internal bool GPBFDLDPNIG(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo LLAALBMPOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo MINEHICCHLB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string JOBPEPKBADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772320", VA = "0x180773B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string NODOCHAPPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x774F80", Offset = "0x773780", VA = "0x180774F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BNBCKCDKJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x658B9C0", Offset = "0x658A1C0", VA = "0x18658B9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool BPEDGDHHIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x77D7A0", Offset = "0x77BFA0", VA = "0x18077D7A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x77D850", Offset = "0x77C050", VA = "0x18077D850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool LNBAMLHPOPA
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8848A0", Offset = "0x8830A0", VA = "0x1808848A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x884460", Offset = "0x882C60", VA = "0x180884460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type CCNHBOAJCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7790D0", Offset = "0x7778D0", VA = "0x1807790D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x778B30", Offset = "0x777330", VA = "0x180778B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo DFDMHIPDPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x773B40", Offset = "0x772340", VA = "0x180773B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x773B70", Offset = "0x772370", VA = "0x180773B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo PIKPOBLLAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x778B40", Offset = "0x777340", VA = "0x180778B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x77D860", Offset = "0x77C060", VA = "0x18077D860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo OEPFJPJIENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x778B20", Offset = "0x777320", VA = "0x180778B20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x778B00", Offset = "0x777300", VA = "0x180778B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x658BE20", Offset = "0x658A620", VA = "0x18658BE20")]
	protected CAAEDJDJIPH(Type HJNJPNKDEFH, string PMDCAPIFBIP, string NMNLJGNMPAK, bool HLPMNAPEJAA, bool MAHHFIGJGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x658BB50", Offset = "0x658A350", VA = "0x18658BB50")]
	public CAAEDJDJIPH(FieldInfo GHEDPMGCDIL, string PMDCAPIFBIP, bool PKOEFCPEDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x658BC60", Offset = "0x658A460", VA = "0x18658BC60")]
	public CAAEDJDJIPH(PropertyInfo GHEDPMGCDIL, string PMDCAPIFBIP, bool PKOEFCPEDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x658B6D0", Offset = "0x6589ED0", VA = "0x18658B6D0")]
	private static MethodInfo DDKIDLMPFPH(MemberInfo GHEDPMGCDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2326300", Offset = "0x2324B00", VA = "0x182326300")]
	public T MCGIBLCDKPL<T>(bool OGHEPABMMEA) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x658B840", Offset = "0x658A040", VA = "0x18658B840", Slot = "4")]
	public virtual void GFNFKHBCKPL(ILGenerator HKPHEBNFCGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x658B9D0", Offset = "0x658A1D0", VA = "0x18658B9D0", Slot = "5")]
	public virtual void ONJJKHLDPMM(ILGenerator HKPHEBNFCGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class CCCIEABCANO : CAAEDJDJIPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string OIMPADFOOKG;

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x658BFA0", Offset = "0x658A7A0", VA = "0x18658BFA0")]
	public CCCIEABCANO(string PMDCAPIFBIP, string OIMPADFOOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x658BEA0", Offset = "0x658A6A0", VA = "0x18658BEA0", Slot = "4")]
	public override void GFNFKHBCKPL(ILGenerator HKPHEBNFCGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x658BF50", Offset = "0x658A750", VA = "0x18658BF50", Slot = "5")]
	public override void ONJJKHLDPMM(ILGenerator HKPHEBNFCGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class GILGPPIAEBI : CAAEDJDJIPH
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo FOCGBIBHILG;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo PBOMPLMCALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal KOACHAEHPBN LNMCNKONKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal KOACHAEHPBN DLGLBKNHNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal KOACHAEHPBN DOHBMHHAIAM;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6595C30", Offset = "0x6594430", VA = "0x186595C30")]
	public GILGPPIAEBI(string PMDCAPIFBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6595450", Offset = "0x6593C50", VA = "0x186595450", Slot = "4")]
	public override void GFNFKHBCKPL(ILGenerator HKPHEBNFCGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x65956D0", Offset = "0x6593ED0", VA = "0x1865956D0", Slot = "5")]
	public override void ONJJKHLDPMM(ILGenerator HKPHEBNFCGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6595510", Offset = "0x6593D10", VA = "0x186595510")]
	public void OGIMAIBIJGF(ILGenerator HKPHEBNFCGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class FAADNGHOJEG
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type CCNHBOAJCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772320", VA = "0x180773B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GLEKONOJEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F30", Offset = "0x7F5730", VA = "0x1807F6F30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x775870", Offset = "0x774070", VA = "0x180775870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool OHNAFKCNFGP
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x87D370", Offset = "0x87BB70", VA = "0x18087D370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x87C620", Offset = "0x87AE20", VA = "0x18087C620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo GHONNKBOKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x773B60", Offset = "0x772360", VA = "0x180773B60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public CAAEDJDJIPH[] OKMNCEIABLP
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7790D0", Offset = "0x7778D0", VA = "0x1807790D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x778B30", Offset = "0x777330", VA = "0x180778B30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public CAAEDJDJIPH[] LCMNNHBHAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x773B40", Offset = "0x772340", VA = "0x180773B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x773B70", Offset = "0x772370", VA = "0x180773B70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x65939A0", Offset = "0x65921A0", VA = "0x1865939A0")]
	public FAADNGHOJEG(Type HJNJPNKDEFH, Func<string, string> AMKHJDNCGMM, bool PKOEFCPEDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x65938C0", Offset = "0x65920C0", VA = "0x1865938C0")]
	private static bool PMELDHHCAJM(IEnumerator<ConstructorInfo> NDDHBGFCOGK, ConstructorInfo MLAFIKAGNDL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct DFCOJKGIACK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong AFDAJFEDCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int GKFJGAEIAFC;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1CFCF70", Offset = "0x1CFB770", VA = "0x181CFCF70")]
	public DFCOJKGIACK(ulong NHLBKAJIEJJ, int MJCLPPFGCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x658DD20", Offset = "0x658C520", VA = "0x18658DD20")]
	public void HOLCLJDEBDP(DFCOJKGIACK FPJCFKAMJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x658DB50", Offset = "0x658C350", VA = "0x18658DB50")]
	public static DFCOJKGIACK CDDEIOAJDLB(DFCOJKGIACK GIFKCLLLICD, DFCOJKGIACK KIOLHHMPBGL)
	{
		return default(DFCOJKGIACK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x658DBF0", Offset = "0x658C3F0", VA = "0x18658DBF0")]
	public void EJGENDFGLMH(DFCOJKGIACK FPJCFKAMJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x658DC80", Offset = "0x658C480", VA = "0x18658DC80")]
	public static DFCOJKGIACK EJOKMOCFJAD(DFCOJKGIACK GIFKCLLLICD, DFCOJKGIACK KIOLHHMPBGL)
	{
		return default(DFCOJKGIACK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x658DB60", Offset = "0x658C360", VA = "0x18658DB60")]
	public void DNFOAMIOMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x658DBA0", Offset = "0x658C3A0", VA = "0x18658DBA0")]
	public static DFCOJKGIACK DNFOAMIOMCE(DFCOJKGIACK GIFKCLLLICD)
	{
		return default(DFCOJKGIACK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct DNLJPPAKHNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] IJPAPFCFHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int IJJNAEFKMHG;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x1752790", Offset = "0x1750F90", VA = "0x181752790")]
	public DNLJPPAKHNM(byte[] IJPAPFCFHAF, int FLFCGPFDCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x656B140", Offset = "0x6569940", VA = "0x18656B140")]
	public void LFNPHCPFJDO(byte OIHIJMCPAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x658DFE0", Offset = "0x658C7E0", VA = "0x18658DFE0")]
	public void EKBOODNLLID(byte[] OIHIJMCPAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x658DEC0", Offset = "0x658C6C0", VA = "0x18658DEC0")]
	public void BPHKECBEHPM(byte[] OIHIJMCPAMD, int BONCBNKGOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x658DF40", Offset = "0x658C740", VA = "0x18658DF40")]
	public void BPHKECBEHPM(byte[] OIHIJMCPAMD, int IOPBDEDCAOK, int BONCBNKGOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x658E160", Offset = "0x658C960", VA = "0x18658E160")]
	public void OPDOEOBPPPB(byte DNNFFPMDBKK, int PPKDCOOCBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x658E060", Offset = "0x658C860", VA = "0x18658E060")]
	public void ELBJAPGHJNN(string OIHIJMCPAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class HMKHFCOJIID
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum LNPGKOLKNJB
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum APGFPHKFKED
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private enum LFBFGIAKILI
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
	private static byte[] EOLPEJHLLBF;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] KBNBPNFGPLP;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] MMCNFJIPEBF;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] AHBLJILIDJK;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly LFBFGIAKILI JNKBIEEKFNG;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char DLABBGBFEFK;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int FMLDIHPMNDO;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int KODFFACEEDA;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] OFKDLIJDMIJ;

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6597140", Offset = "0x6595940", VA = "0x186597140")]
	private static byte[] FCOIIJNFEHH(int NKCDHJPJBIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6597600", Offset = "0x6595E00", VA = "0x186597600")]
	private static byte[] IBBJOMEGNNC(int NKCDHJPJBIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6598040", Offset = "0x6596840", VA = "0x186598040")]
	public static int OHDFCDFANDG(byte[] IJPAPFCFHAF, int IJJNAEFKMHG, float DOLICEBFIPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6598160", Offset = "0x6596960", VA = "0x186598160")]
	public static int OHDFCDFANDG(byte[] IJPAPFCFHAF, int IJJNAEFKMHG, double DOLICEBFIPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6597F50", Offset = "0x6596750", VA = "0x186597F50")]
	private static bool LNODEFJDAMH(byte[] IJPAPFCFHAF, int BONCBNKGOGN, ulong FMCCDPMHCNG, ulong BAIPECBGEFN, ulong CDKNFNFMFBN, ulong JNLOIDHABNE, ulong OMPOGCKDKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6597C70", Offset = "0x6596470", VA = "0x186597C70")]
	private static void KLCJCLBHIFL(uint LHLDABINMFD, int INJGELEEAAI, [Out] uint CNLAPNEKHIH, [Out] int KJHKEPFAHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6597210", Offset = "0x6595A10", VA = "0x186597210")]
	private static bool HEBPGFIOMIO(DFCOJKGIACK DEFOPNEHFDG, DFCOJKGIACK EHCPCJMKJMH, DFCOJKGIACK JGGJJFIAJNF, byte[] IJPAPFCFHAF, [Out] int BONCBNKGOGN, [Out] int MKDCPAFECOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x65977F0", Offset = "0x6595FF0", VA = "0x1865977F0")]
	private static bool JFBJHFGBHKE(double EDLEGKLLGMC, LNPGKOLKNJB JECPNLKEDGA, byte[] IJPAPFCFHAF, [Out] int BONCBNKGOGN, [Out] int DAHHDGCELLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x65976E0", Offset = "0x6595EE0", VA = "0x1865976E0")]
	private static bool JCDKDHLPCGM(double EDLEGKLLGMC, LNPGKOLKNJB JECPNLKEDGA, byte[] IJPAPFCFHAF, [Out] int BONCBNKGOGN, [Out] int FGHMKKLPLLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6596F70", Offset = "0x6595770", VA = "0x186596F70")]
	private static bool FBAPNIPDHKA(double DOLICEBFIPF, DNLJPPAKHNM AFNLFIJOMEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6596660", Offset = "0x6594E60", VA = "0x186596660")]
	private static bool CIFHCLOLEGG(double DOLICEBFIPF, DNLJPPAKHNM AFNLFIJOMEK, APGFPHKFKED JECPNLKEDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6598280", Offset = "0x6596A80", VA = "0x186598280")]
	private static void PPHGJJLMLBH(byte[] DLMONDAHEKC, int BONCBNKGOGN, int FGHMKKLPLLF, int PCMFIHDLMOG, DNLJPPAKHNM AFNLFIJOMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6596B40", Offset = "0x6595340", VA = "0x186596B40")]
	private static void DADGBBEFFLD(byte[] DLMONDAHEKC, int BONCBNKGOGN, int MJCLPPFGCHF, DNLJPPAKHNM AFNLFIJOMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6597D60", Offset = "0x6596560", VA = "0x186597D60")]
	private static bool LMAOOMIPHGM(double EDLEGKLLGMC, APGFPHKFKED JECPNLKEDGA, int MFLIHCBBAHH, byte[] JBJBCDBKHCM, [Out] bool EEOOHIKPKHM, [Out] int BONCBNKGOGN, [Out] int JCKCLHMKLHE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct CDEINEAOGCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double FCAIODKILEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong IDPKAJPMFIC;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct HKOOMKLAHEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float AFDAJFEDCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint OMBNLHLMCOA;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct KJCLELEJMHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong EJDKLCHCPJA;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x659B5D0", Offset = "0x6599DD0", VA = "0x18659B5D0")]
	public KJCLELEJMHK(double FCAIODKILEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x659B530", Offset = "0x6599D30", VA = "0x18659B530")]
	public KJCLELEJMHK(DFCOJKGIACK FCAIODKILEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x659B090", Offset = "0x6599890", VA = "0x18659B090")]
	public DFCOJKGIACK EHDAGMOFNBJ()
	{
		return default(DFCOJKGIACK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x659AFD0", Offset = "0x65997D0", VA = "0x18659AFD0")]
	public DFCOJKGIACK BBGBLMHNEAD()
	{
		return default(DFCOJKGIACK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
	public ulong EGCCOFMCLDM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x659B460", Offset = "0x6599C60", VA = "0x18659B460")]
	public double OAKLHAFMNKC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x659B270", Offset = "0x6599A70", VA = "0x18659B270")]
	public double GKIJKMABNLN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x659B3F0", Offset = "0x6599BF0", VA = "0x18659B3F0")]
	public int KIPEILGIMPM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x659AFA0", Offset = "0x65997A0", VA = "0x18659AFA0")]
	public ulong AKGCLOIECIG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x659B440", Offset = "0x6599C40", VA = "0x18659B440")]
	public bool LLBAAHFMNMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x659B510", Offset = "0x6599D10", VA = "0x18659B510")]
	public bool PPNEJLPBPFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x659B4E0", Offset = "0x6599CE0", VA = "0x18659B4E0")]
	public bool PMEGCAEBNCP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x659B060", Offset = "0x6599860", VA = "0x18659B060")]
	public bool EDDLFPFBDNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x659B250", Offset = "0x6599A50", VA = "0x18659B250")]
	public int GILAEHGHMDM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x659B100", Offset = "0x6599900", VA = "0x18659B100")]
	public void EPPCNAGIJHE([Out] DFCOJKGIACK CPCMKNDLCGG, [Out] DFCOJKGIACK IECDIBKIMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x659B310", Offset = "0x6599B10", VA = "0x18659B310")]
	public bool HIOHGBNELAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3590", Offset = "0x2AB1D90", VA = "0x182AB3590")]
	public double DOLICEBFIPF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x659B420", Offset = "0x6599C20", VA = "0x18659B420")]
	public static int LCJBOCBLEPM(int FNHLOMPFGOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x659B050", Offset = "0x6599850", VA = "0x18659B050")]
	public static double DJFHEEDCMPF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x659B360", Offset = "0x6599B60", VA = "0x18659B360")]
	public static ulong INHOCEKCIDM(DFCOJKGIACK EACGCGHDNNG)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct INIFPNMOLPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint EKNBAAELAIM;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x201A400", Offset = "0x2018C00", VA = "0x18201A400")]
	public INIFPNMOLPP(float AFDAJFEDCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6599CD0", Offset = "0x65984D0", VA = "0x186599CD0")]
	public DFCOJKGIACK EHDAGMOFNBJ()
	{
		return default(DFCOJKGIACK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x85FEF0", Offset = "0x85E6F0", VA = "0x18085FEF0")]
	public uint NGJEPKOCJPN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6599E90", Offset = "0x6598690", VA = "0x186599E90")]
	public int KIPEILGIMPM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6599CB0", Offset = "0x65984B0", VA = "0x186599CB0")]
	public uint AKGCLOIECIG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6599EB0", Offset = "0x65986B0", VA = "0x186599EB0")]
	public bool LLBAAHFMNMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6599D20", Offset = "0x6598520", VA = "0x186599D20")]
	public void EPPCNAGIJHE([Out] DFCOJKGIACK CPCMKNDLCGG, [Out] DFCOJKGIACK IECDIBKIMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6599E50", Offset = "0x6598650", VA = "0x186599E50")]
	public bool HIOHGBNELAC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct DNEIBHBKOIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong NHLBKAJIEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short EEAKLFINOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short DAHHDGCELLE;

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x658DEB0", Offset = "0x658C6B0", VA = "0x18658DEB0")]
	public DNEIBHBKOIJ(ulong NHLBKAJIEJJ, short EEAKLFINOHO, short DAHHDGCELLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class PKAGDACAPCP
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly DNEIBHBKOIJ[] LGGILDOCJAO;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x659EDE0", Offset = "0x659D5E0", VA = "0x18659EDE0")]
	public static void BGLFCBDDDCP(int OBMGJBNIJOI, int GMIOELMELIF, [Out] DFCOJKGIACK CNLAPNEKHIH, [Out] int DAHHDGCELLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x659EEF0", Offset = "0x659D6F0", VA = "0x18659EEF0")]
	public static void DLLKDCIIOKC(int HONAHMGKCLK, [Out] DFCOJKGIACK CNLAPNEKHIH, [Out] int MPIHFIPGDEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[DefaultMember("Item")]
internal struct FCHAAJCAJPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] OCKHPPLPLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int IOPBDEDCAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int NDMNBGGEKEM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6594EC0", Offset = "0x65936C0", VA = "0x186594EC0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x35F3970", Offset = "0x35F2170", VA = "0x1835F3970")]
	public FCHAAJCAJPL(byte[] OCKHPPLPLMN, int IOPBDEDCAOK, int BONCBNKGOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x204EAF0", Offset = "0x204D2F0", VA = "0x18204EAF0")]
	public int BONCBNKGOGN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6594E60", Offset = "0x6593660", VA = "0x186594E60")]
	public FCHAAJCAJPL OMENFAOHDKG(int FLHELLMECOK, int IDADLFNFKJF)
	{
		return default(FCHAAJCAJPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class MPDGHONMIAJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] LMCPJGHNLKD;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] OBMMKPDLPNO;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int OAGBEHEDLFM;

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x659D0F0", Offset = "0x659B8F0", VA = "0x18659D0F0")]
	private static byte[] EDIKNIHNMNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x659C9C0", Offset = "0x659B1C0", VA = "0x18659C9C0")]
	private static FCHAAJCAJPL DBKDOMHNIAA(FCHAAJCAJPL IJPAPFCFHAF)
	{
		return default(FCHAAJCAJPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x659C740", Offset = "0x659AF40", VA = "0x18659C740")]
	private static FCHAAJCAJPL BPKDAOHAOOG(FCHAAJCAJPL IJPAPFCFHAF)
	{
		return default(FCHAAJCAJPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x659D1D0", Offset = "0x659B9D0", VA = "0x18659D1D0")]
	private static void EDMDELPDCPI(FCHAAJCAJPL IJPAPFCFHAF, int MJCLPPFGCHF, byte[] LGMIPPLAKPN, [Out] int INAFDNOBICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x659DBF0", Offset = "0x659C3F0", VA = "0x18659DBF0")]
	private static void LGGAEEGHHDM(FCHAAJCAJPL IJPAPFCFHAF, int MJCLPPFGCHF, byte[] PANLHFEIMBF, int JGHAHBHADPP, [Out] FCHAAJCAJPL IBMGDMPCBCO, [Out] int ADCKDKLLDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x659D890", Offset = "0x659C090", VA = "0x18659D890")]
	private static ulong ILPDJPEMABC(FCHAAJCAJPL IJPAPFCFHAF, [Out] int PHODCEDMMEH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x659D750", Offset = "0x659BF50", VA = "0x18659D750")]
	private static void IEDPDGDHFKM(FCHAAJCAJPL IJPAPFCFHAF, [Out] DFCOJKGIACK MLABNLLFODC, [Out] int JMIIHNICDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x659D380", Offset = "0x659BB80", VA = "0x18659D380")]
	private static bool HDBLGKJAABF(FCHAAJCAJPL IBMGDMPCBCO, int MJCLPPFGCHF, [Out] double MLABNLLFODC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x659C820", Offset = "0x659B020", VA = "0x18659C820")]
	private static DFCOJKGIACK CPDIIKENADE(int MJCLPPFGCHF)
	{
		return default(DFCOJKGIACK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x659CAA0", Offset = "0x659B2A0", VA = "0x18659CAA0")]
	private static bool DLGECODHKKK(FCHAAJCAJPL IJPAPFCFHAF, int MJCLPPFGCHF, [Out] double MLABNLLFODC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x659D260", Offset = "0x659BA60", VA = "0x18659D260")]
	private static bool HBAOMPKJCDP(FCHAAJCAJPL IBMGDMPCBCO, int MJCLPPFGCHF, [Out] double OKJIINNABMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x659C620", Offset = "0x659AE20", VA = "0x18659C620")]
	public static double? BCNAENNJJOK(FCHAAJCAJPL IJPAPFCFHAF, int MJCLPPFGCHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x659D920", Offset = "0x659C120", VA = "0x18659D920")]
	public static float? LGDJBNEKDIG(FCHAAJCAJPL IJPAPFCFHAF, int MJCLPPFGCHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal struct GIMHNNMAAKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] IJPAPFCFHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int IJJNAEFKMHG;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte HMHFMLFLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x65A88F0", Offset = "0x65A70F0", VA = "0x1865A88F0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1752790", Offset = "0x1750F90", VA = "0x181752790")]
	public GIMHNNMAAKC(byte[] IJPAPFCFHAF, int IJJNAEFKMHG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x65A88E0", Offset = "0x65A70E0", VA = "0x1865A88E0")]
	public static GIMHNNMAAKC CHFHBOJGHBD(GIMHNNMAAKC PIEBBHMNEOG)
	{
		return default(GIMHNNMAAKC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x65A89D0", Offset = "0x65A71D0", VA = "0x1865A89D0")]
	public static GIMHNNMAAKC HGGBPNAHAGN(GIMHNNMAAKC PIEBBHMNEOG, int BONCBNKGOGN)
	{
		return default(GIMHNNMAAKC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x65A88D0", Offset = "0x65A70D0", VA = "0x1865A88D0")]
	public static int AMBCIMDJOHF(GIMHNNMAAKC NMCFAAKFHJI, GIMHNNMAAKC AKHEBCAILGG)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x65A8960", Offset = "0x65A7160", VA = "0x1865A8960")]
	public static bool FMFPLPMCDAE(GIMHNNMAAKC NMCFAAKFHJI, GIMHNNMAAKC AKHEBCAILGG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x65A8950", Offset = "0x65A7150", VA = "0x1865A8950")]
	public static bool EODFGAKKOLK(GIMHNNMAAKC NMCFAAKFHJI, GIMHNNMAAKC AKHEBCAILGG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x65A8970", Offset = "0x65A7170", VA = "0x1865A8970")]
	public static bool FMFPLPMCDAE(GIMHNNMAAKC NMCFAAKFHJI, char AKHEBCAILGG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x65A8920", Offset = "0x65A7120", VA = "0x1865A8920")]
	public static bool EODFGAKKOLK(GIMHNNMAAKC NMCFAAKFHJI, char AKHEBCAILGG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x65A8920", Offset = "0x65A7120", VA = "0x1865A8920")]
	public static bool EODFGAKKOLK(GIMHNNMAAKC NMCFAAKFHJI, byte AKHEBCAILGG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x65A88A0", Offset = "0x65A70A0", VA = "0x1865A88A0")]
	public static bool AKLMBAJAHLO(GIMHNNMAAKC NMCFAAKFHJI, char AKHEBCAILGG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x65A8870", Offset = "0x65A7070", VA = "0x1865A8870")]
	public static bool AGBMGONIEBD(GIMHNNMAAKC NMCFAAKFHJI, char AKHEBCAILGG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x65A8A20", Offset = "0x65A7220", VA = "0x1865A8A20")]
	public static bool IPCHJDEKELF(GIMHNNMAAKC NMCFAAKFHJI, char AKHEBCAILGG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x65A89A0", Offset = "0x65A71A0", VA = "0x1865A89A0")]
	public static bool GALJBCOOLPM(GIMHNNMAAKC NMCFAAKFHJI, char AKHEBCAILGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class ALGGNLCEBIN
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] AGDGPMINABC;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] EOAEGJDGIGG;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] MMCNFJIPEBF;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] AHBLJILIDJK;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] FENMFPHPIJM;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int EIOKGLPCDFA;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] IBBEGPLKLEA;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int NJOIKLOLCCH;

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x65A39C0", Offset = "0x65A21C0", VA = "0x1865A39C0")]
	private static byte[] JKJDBJBPENM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x65A27C0", Offset = "0x65A0FC0", VA = "0x1865A27C0")]
	private static byte[] GJJKLOLOFLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x65A2A90", Offset = "0x65A1290", VA = "0x1865A2A90")]
	public static double JCNBJPLIFOO(byte[] IJPAPFCFHAF, int IJJNAEFKMHG, [Out] int HCLNKOJJJIG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x65A3B10", Offset = "0x65A2310", VA = "0x1865A3B10")]
	public static float PLJIIJILLJG(byte[] IJPAPFCFHAF, int IJJNAEFKMHG, [Out] int HCLNKOJJJIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x65A25B0", Offset = "0x65A0DB0", VA = "0x1865A25B0")]
	private static bool CDOKLCAOJGN(int GJPJIELLCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x65A28A0", Offset = "0x65A10A0", VA = "0x1865A28A0")]
	private static bool INIMCMGABBD(GIMHNNMAAKC KAFGDIBLHGB, GIMHNNMAAKC BEDAKCMDPNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x65A26F0", Offset = "0x65A0EF0", VA = "0x1865A26F0")]
	private static bool CEHIGIFKNKC(GIMHNNMAAKC KAFGDIBLHGB, GIMHNNMAAKC BEDAKCMDPNE, byte[] BBBIFALOEKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x65A3AA0", Offset = "0x65A22A0", VA = "0x1865A3AA0")]
	private static bool KFADBANPCGN(GIMHNNMAAKC LMBEJDKNDAL, byte[] OIHIJMCPAMD, int IJJNAEFKMHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x65A3AF0", Offset = "0x65A22F0", VA = "0x1865A3AF0")]
	private static double MOKGLJOPHKM(bool EEOOHIKPKHM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x65A2B40", Offset = "0x65A1340", VA = "0x1865A2B40")]
	private static double JFCPABAFNHD(GIMHNNMAAKC LLJFBBILFIJ, int BONCBNKGOGN, bool HGADEFIDJOO, [Out] int CFDLINKHAOD)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class NDJBJKNDKEN<T> : OGEKILALGOF<T[]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly BGANGDEDFBI<T> OOPLFIMJOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly MIGKHLDJDLE FKAPAEFFPAN;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3457860", Offset = "0x3456060", VA = "0x183457860")]
	public NDJBJKNDKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
	public NDJBJKNDKEN(MIGKHLDJDLE FKAPAEFFPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF580", Offset = "0x3CFDD80", VA = "0x183CFF580", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, T[] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE170", Offset = "0x3CFC970", VA = "0x183CFE170", Slot = "5")]
	public T[] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class FMPELPFIGDC<T> : OGEKILALGOF<ArraySegment<T>>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly BGANGDEDFBI<T> OOPLFIMJOFP;

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3485940", Offset = "0x3484140", VA = "0x183485940", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, ArraySegment<T> DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3485520", Offset = "0x3483D20", VA = "0x183485520", Slot = "5")]
	public ArraySegment<T> AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class FDHNLAOHIFN<T> : OGEKILALGOF<List<T>>, LMLLDOBHGKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly MIGKHLDJDLE FKAPAEFFPAN;

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3457860", Offset = "0x3456060", VA = "0x183457860")]
	public FDHNLAOHIFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
	public FDHNLAOHIFN(MIGKHLDJDLE FKAPAEFFPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x3455600", Offset = "0x3453E00", VA = "0x183455600", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, List<T> DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x3453280", Offset = "0x3451A80", VA = "0x183453280", Slot = "5")]
	public List<T> AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class OOOGJILBAEF<TElement, TIntermediate, TEnumerator, TCollection> : OGEKILALGOF<TCollection>, LMLLDOBHGKK where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3E4BB10", Offset = "0x3E4A310", VA = "0x183E4BB10", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, TCollection DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3E49E70", Offset = "0x3E48670", VA = "0x183E49E70", Slot = "5")]
	public TCollection AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator NNFGJENAACD(TCollection PCNNAKCFNJC);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate OEONKPJDENI();

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void INCGBOEKEGG(TIntermediate GPLKMEDKCNA, int EAHCFBMNNCF, TElement DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection NJFDFAHEDCH(TIntermediate ABCPANAMHIG);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	protected OOOGJILBAEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class MKDGAJPMDOM<TElement, TIntermediate, TCollection> : OOOGJILBAEF<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F960", Offset = "0x3C9E160", VA = "0x183C9F960", Slot = "6")]
	protected override IEnumerator<TElement> NNFGJENAACD(TCollection PCNNAKCFNJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x30D36F0", Offset = "0x30D1EF0", VA = "0x1830D36F0")]
	protected MKDGAJPMDOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public abstract class JEIDICAEEDD<TElement, TCollection> : MKDGAJPMDOM<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x80FCD0", Offset = "0x80E4D0", VA = "0x18080FCD0", Slot = "9")]
	protected sealed override TCollection NJFDFAHEDCH(TCollection ABCPANAMHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class BFIMDOEBCOA<TElement, TCollection> : JEIDICAEEDD<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x45868B0", Offset = "0x45850B0", VA = "0x1845868B0", Slot = "7")]
	protected override TCollection OEONKPJDENI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x4586850", Offset = "0x4585050", VA = "0x184586850", Slot = "8")]
	protected override void INCGBOEKEGG(TCollection GPLKMEDKCNA, int EAHCFBMNNCF, TElement DOLICEBFIPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class JCACKLGJHEN<T> : OOOGJILBAEF<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3860360", Offset = "0x385EB60", VA = "0x183860360", Slot = "8")]
	protected override void INCGBOEKEGG(LinkedList<T> GPLKMEDKCNA, int EAHCFBMNNCF, T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x80FCD0", Offset = "0x80E4D0", VA = "0x18080FCD0", Slot = "9")]
	protected override LinkedList<T> NJFDFAHEDCH(LinkedList<T> ABCPANAMHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3528270", Offset = "0x3526A70", VA = "0x183528270", Slot = "7")]
	protected override LinkedList<T> OEONKPJDENI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x35280C0", Offset = "0x35268C0", VA = "0x1835280C0", Slot = "6")]
	protected override LinkedList<T>.Enumerator NNFGJENAACD(LinkedList<T> PCNNAKCFNJC)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class BGDNHGPKOPD<T> : OOOGJILBAEF<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3860360", Offset = "0x385EB60", VA = "0x183860360", Slot = "8")]
	protected override void INCGBOEKEGG(Queue<T> GPLKMEDKCNA, int EAHCFBMNNCF, T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3528270", Offset = "0x3526A70", VA = "0x183528270", Slot = "7")]
	protected override Queue<T> OEONKPJDENI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x4589A20", Offset = "0x4588220", VA = "0x184589A20", Slot = "6")]
	protected override Queue<T>.Enumerator NNFGJENAACD(Queue<T> PCNNAKCFNJC)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x80FCD0", Offset = "0x80E4D0", VA = "0x18080FCD0", Slot = "9")]
	protected override Queue<T> NJFDFAHEDCH(Queue<T> ABCPANAMHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class JBGMGFCIBEK<T> : OOOGJILBAEF<T, GANCJCAKJPF<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x385CAB0", Offset = "0x385B2B0", VA = "0x18385CAB0", Slot = "8")]
	protected override void INCGBOEKEGG(GANCJCAKJPF<T> GPLKMEDKCNA, int EAHCFBMNNCF, T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x385CC20", Offset = "0x385B420", VA = "0x18385CC20", Slot = "7")]
	protected override GANCJCAKJPF<T> OEONKPJDENI()
	{
		return default(GANCJCAKJPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x385CBC0", Offset = "0x385B3C0", VA = "0x18385CBC0", Slot = "6")]
	protected override Stack<T>.Enumerator NNFGJENAACD(Stack<T> PCNNAKCFNJC)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x385CAE0", Offset = "0x385B2E0", VA = "0x18385CAE0", Slot = "9")]
	protected override Stack<T> NJFDFAHEDCH(GANCJCAKJPF<T> ABCPANAMHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class CJOBDKKOIBH<T> : OOOGJILBAEF<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3860360", Offset = "0x385EB60", VA = "0x183860360", Slot = "8")]
	protected override void INCGBOEKEGG(HashSet<T> GPLKMEDKCNA, int EAHCFBMNNCF, T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x80FCD0", Offset = "0x80E4D0", VA = "0x18080FCD0", Slot = "9")]
	protected override HashSet<T> NJFDFAHEDCH(HashSet<T> ABCPANAMHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3528270", Offset = "0x3526A70", VA = "0x183528270", Slot = "7")]
	protected override HashSet<T> OEONKPJDENI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4589A20", Offset = "0x4588220", VA = "0x184589A20", Slot = "6")]
	protected override HashSet<T>.Enumerator NNFGJENAACD(HashSet<T> PCNNAKCFNJC)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class NLBDFOKELGP<T> : MKDGAJPMDOM<T, GANCJCAKJPF<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x385CAB0", Offset = "0x385B2B0", VA = "0x18385CAB0", Slot = "8")]
	protected override void INCGBOEKEGG(GANCJCAKJPF<T> GPLKMEDKCNA, int EAHCFBMNNCF, T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x3D33FA0", Offset = "0x3D327A0", VA = "0x183D33FA0", Slot = "9")]
	protected override ReadOnlyCollection<T> NJFDFAHEDCH(GANCJCAKJPF<T> ABCPANAMHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x3D34040", Offset = "0x3D32840", VA = "0x183D34040", Slot = "7")]
	protected override GANCJCAKJPF<T> OEONKPJDENI()
	{
		return default(GANCJCAKJPF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class DLBKPPLOFOG<T> : MKDGAJPMDOM<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3860360", Offset = "0x385EB60", VA = "0x183860360", Slot = "8")]
	protected override void INCGBOEKEGG(List<T> GPLKMEDKCNA, int EAHCFBMNNCF, T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x3528270", Offset = "0x3526A70", VA = "0x183528270", Slot = "7")]
	protected override List<T> OEONKPJDENI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x80FCD0", Offset = "0x80E4D0", VA = "0x18080FCD0", Slot = "9")]
	protected override IList<T> NJFDFAHEDCH(List<T> ABCPANAMHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class CJHMEDIDDIO<T> : MKDGAJPMDOM<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3860360", Offset = "0x385EB60", VA = "0x183860360", Slot = "8")]
	protected override void INCGBOEKEGG(List<T> GPLKMEDKCNA, int EAHCFBMNNCF, T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3528270", Offset = "0x3526A70", VA = "0x183528270", Slot = "7")]
	protected override List<T> OEONKPJDENI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x80FCD0", Offset = "0x80E4D0", VA = "0x18080FCD0", Slot = "9")]
	protected override ICollection<T> NJFDFAHEDCH(List<T> ABCPANAMHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class MEJPNIMLDMN<T> : MKDGAJPMDOM<T, GANCJCAKJPF<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x385CAB0", Offset = "0x385B2B0", VA = "0x18385CAB0", Slot = "8")]
	protected override void INCGBOEKEGG(GANCJCAKJPF<T> GPLKMEDKCNA, int EAHCFBMNNCF, T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x385CC20", Offset = "0x385B420", VA = "0x18385CC20", Slot = "7")]
	protected override GANCJCAKJPF<T> OEONKPJDENI()
	{
		return default(GANCJCAKJPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x3C89F50", Offset = "0x3C88750", VA = "0x183C89F50", Slot = "9")]
	protected override IEnumerable<T> NJFDFAHEDCH(GANCJCAKJPF<T> ABCPANAMHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x30E10B0", Offset = "0x30DF8B0", VA = "0x1830E10B0")]
	public MEJPNIMLDMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class PAIDHKKPJJK<TKey, TElement> : OGEKILALGOF<IGrouping<TKey, TElement>>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3ED5930", Offset = "0x3ED4130", VA = "0x183ED5930", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, IGrouping<TKey, TElement> DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3ED5630", Offset = "0x3ED3E30", VA = "0x183ED5630", Slot = "5")]
	public IGrouping<TKey, TElement> AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class ABEOMPPAADP<TKey, TElement> : OGEKILALGOF<ILookup<TKey, TElement>>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3543EA0", Offset = "0x35426A0", VA = "0x183543EA0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, ILookup<TKey, TElement> DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3543B50", Offset = "0x3542350", VA = "0x183543B50", Slot = "5")]
	public ILookup<TKey, TElement> AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class ADHKPADAMIN<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly TKey EMBEECDJLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly IEnumerable<TElement> HHKFGLJIGDM;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey GKFGCIJBLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x77D5B0", Offset = "0x77BDB0", VA = "0x18077D5B0")]
	public ADHKPADAMIN(TKey EMBEECDJLJB, IEnumerable<TElement> HHKFGLJIGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x3546350", Offset = "0x3544B50", VA = "0x183546350", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x316AA20", Offset = "0x3169220", VA = "0x18316AA20", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[DefaultMember("Item")]
internal class JCHKPDNOAAF<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> DDNEMAEKDJM;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x351C760", Offset = "0x351AF60", VA = "0x18351C760", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	public JCHKPDNOAAF(Dictionary<TKey, IGrouping<TKey, TElement>> DDNEMAEKDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x38603A0", Offset = "0x385EBA0", VA = "0x1838603A0", Slot = "5")]
	public bool Contains(TKey EMBEECDJLJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x38603E0", Offset = "0x385EBE0", VA = "0x1838603E0", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x38603E0", Offset = "0x385EBE0", VA = "0x1838603E0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class GIHIIIDFPHK<T> : OGEKILALGOF<T>, LMLLDOBHGKK where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x351CFE0", Offset = "0x351B7E0", VA = "0x18351CFE0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, T DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x351CD60", Offset = "0x351B560", VA = "0x18351CD60", Slot = "5")]
	public T AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public GIHIIIDFPHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class DDBKIEEANDP : OGEKILALGOF<IEnumerable>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly OGEKILALGOF<IEnumerable> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x65A6620", Offset = "0x65A4E20", VA = "0x1865A6620", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, IEnumerable DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x65A63D0", Offset = "0x65A4BD0", VA = "0x1865A63D0", Slot = "5")]
	public IEnumerable AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public DDBKIEEANDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class AIGPDADCPOA : OGEKILALGOF<ICollection>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly OGEKILALGOF<ICollection> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x65A0D50", Offset = "0x659F550", VA = "0x1865A0D50", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, ICollection DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x65A0B00", Offset = "0x659F300", VA = "0x1865A0B00", Slot = "5")]
	public ICollection AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public AIGPDADCPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class GGHLOMOOLDI : OGEKILALGOF<IList>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly OGEKILALGOF<IList> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x65A84C0", Offset = "0x65A6CC0", VA = "0x1865A84C0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, IList DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x65A8270", Offset = "0x65A6A70", VA = "0x1865A8270", Slot = "5")]
	public IList AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public GGHLOMOOLDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class NILHCEMFNIL<T> : MKDGAJPMDOM<T, GANCJCAKJPF<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x3D275D0", Offset = "0x3D25DD0", VA = "0x183D275D0", Slot = "8")]
	protected override void INCGBOEKEGG(GANCJCAKJPF<T> GPLKMEDKCNA, int EAHCFBMNNCF, T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x385CC20", Offset = "0x385B420", VA = "0x18385CC20", Slot = "7")]
	protected override GANCJCAKJPF<T> OEONKPJDENI()
	{
		return default(GANCJCAKJPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3D27630", Offset = "0x3D25E30", VA = "0x183D27630", Slot = "9")]
	protected override IReadOnlyList<T> NJFDFAHEDCH(GANCJCAKJPF<T> ABCPANAMHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x30E0A50", Offset = "0x30DF250", VA = "0x1830E0A50")]
	public NILHCEMFNIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class LHMPLLIIEJE
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x65B01C0", Offset = "0x65AE9C0", VA = "0x1865B01C0")]
	public static DateTime EBGJAMLBOMI(DateTime LCMGEHGOPCD)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class LBGNKOKACMI : OGEKILALGOF<DateTime>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public static readonly OGEKILALGOF<DateTime> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x65ADB60", Offset = "0x65AC360", VA = "0x1865ADB60", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, DateTime DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x65ACE50", Offset = "0x65AB650", VA = "0x1865ACE50", Slot = "5")]
	public DateTime AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public LBGNKOKACMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class EGNMHCLHJAJ : OGEKILALGOF<DateTimeOffset>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly OGEKILALGOF<DateTimeOffset> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x65A78B0", Offset = "0x65A60B0", VA = "0x1865A78B0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, DateTimeOffset DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x65A6C90", Offset = "0x65A5490", VA = "0x1865A6C90", Slot = "5")]
	public DateTimeOffset AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public EGNMHCLHJAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class LHMLMFEECFD : OGEKILALGOF<TimeSpan>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public static readonly OGEKILALGOF<TimeSpan> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static byte[] GKBPOPEPJMG;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x65AFC80", Offset = "0x65AE480", VA = "0x1865AFC80", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, TimeSpan DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x65AF370", Offset = "0x65ADB70", VA = "0x1865AF370", Slot = "5")]
	public TimeSpan AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public LHMLMFEECFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public abstract class HOFLEFHDNBD<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : OGEKILALGOF<TDictionary>, LMLLDOBHGKK where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x35E2200", Offset = "0x35E0A00", VA = "0x1835E2200", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, TDictionary DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x35E08F0", Offset = "0x35DF0F0", VA = "0x1835E08F0", Slot = "5")]
	public TDictionary AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator NNFGJENAACD(TDictionary PCNNAKCFNJC);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate OEONKPJDENI();

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void INCGBOEKEGG(TIntermediate GPLKMEDKCNA, int EAHCFBMNNCF, TKey EMBEECDJLJB, TValue DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary NJFDFAHEDCH(TIntermediate ABCPANAMHIG);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	protected HOFLEFHDNBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class BAFFKNICBNP<TKey, TValue, TIntermediate, TDictionary> : HOFLEFHDNBD<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x45653C0", Offset = "0x4563BC0", VA = "0x1845653C0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> NNFGJENAACD(TDictionary PCNNAKCFNJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class MMHFLHHLNOC<TKey, TValue, TDictionary> : BAFFKNICBNP<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x80FCD0", Offset = "0x80E4D0", VA = "0x18080FCD0", Slot = "9")]
	protected override TDictionary NJFDFAHEDCH(TDictionary ABCPANAMHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class GLDCNPGCEPO<TKey, TValue> : HOFLEFHDNBD<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x3527FE0", Offset = "0x35267E0", VA = "0x183527FE0", Slot = "8")]
	protected override void INCGBOEKEGG(Dictionary<TKey, TValue> GPLKMEDKCNA, int EAHCFBMNNCF, TKey EMBEECDJLJB, TValue DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x80FCD0", Offset = "0x80E4D0", VA = "0x18080FCD0", Slot = "9")]
	protected override Dictionary<TKey, TValue> NJFDFAHEDCH(Dictionary<TKey, TValue> ABCPANAMHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x3528270", Offset = "0x3526A70", VA = "0x183528270", Slot = "7")]
	protected override Dictionary<TKey, TValue> OEONKPJDENI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x3528190", Offset = "0x3526990", VA = "0x183528190", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator NNFGJENAACD(Dictionary<TKey, TValue> PCNNAKCFNJC)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x30D29E0", Offset = "0x30D11E0", VA = "0x1830D29E0")]
	public GLDCNPGCEPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class CBDDAMGPKID<TKey, TValue, TDictionary> : MMHFLHHLNOC<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x48DB4C0", Offset = "0x48D9CC0", VA = "0x1848DB4C0", Slot = "8")]
	protected override void INCGBOEKEGG(TDictionary GPLKMEDKCNA, int EAHCFBMNNCF, TKey EMBEECDJLJB, TValue DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2F7A800", Offset = "0x2F79000", VA = "0x182F7A800", Slot = "7")]
	protected override TDictionary OEONKPJDENI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class OFIKKBPOABO<TKey, TValue> : BAFFKNICBNP<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x3527FA0", Offset = "0x35267A0", VA = "0x183527FA0", Slot = "8")]
	protected override void INCGBOEKEGG(Dictionary<TKey, TValue> GPLKMEDKCNA, int EAHCFBMNNCF, TKey EMBEECDJLJB, TValue DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x3528270", Offset = "0x3526A70", VA = "0x183528270", Slot = "7")]
	protected override Dictionary<TKey, TValue> OEONKPJDENI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x80FCD0", Offset = "0x80E4D0", VA = "0x18080FCD0", Slot = "9")]
	protected override IDictionary<TKey, TValue> NJFDFAHEDCH(Dictionary<TKey, TValue> ABCPANAMHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class IDPIONOINFE<TKey, TValue> : MMHFLHHLNOC<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3527FA0", Offset = "0x35267A0", VA = "0x183527FA0", Slot = "8")]
	protected override void INCGBOEKEGG(SortedList<TKey, TValue> GPLKMEDKCNA, int EAHCFBMNNCF, TKey EMBEECDJLJB, TValue DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3528270", Offset = "0x3526A70", VA = "0x183528270", Slot = "7")]
	protected override SortedList<TKey, TValue> OEONKPJDENI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class NKNHJMPLAII<TKey, TValue> : HOFLEFHDNBD<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x3527FA0", Offset = "0x35267A0", VA = "0x183527FA0", Slot = "8")]
	protected override void INCGBOEKEGG(SortedDictionary<TKey, TValue> GPLKMEDKCNA, int EAHCFBMNNCF, TKey EMBEECDJLJB, TValue DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x80FCD0", Offset = "0x80E4D0", VA = "0x18080FCD0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> NJFDFAHEDCH(SortedDictionary<TKey, TValue> ABCPANAMHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3528270", Offset = "0x3526A70", VA = "0x183528270", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> OEONKPJDENI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3528200", Offset = "0x3526A00", VA = "0x183528200", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator NNFGJENAACD(SortedDictionary<TKey, TValue> PCNNAKCFNJC)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class ICKIJHHPBML<T> : OGEKILALGOF<T>, LMLLDOBHGKK where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x368AE70", Offset = "0x3689670", VA = "0x18368AE70", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, T DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x368ABD0", Offset = "0x36893D0", VA = "0x18368ABD0", Slot = "5")]
	public T AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public ICKIJHHPBML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class KDMLJOLHNHL : OGEKILALGOF<IDictionary>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public static readonly OGEKILALGOF<IDictionary> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x65AC100", Offset = "0x65AA900", VA = "0x1865AC100", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, IDictionary DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x65ABED0", Offset = "0x65AA6D0", VA = "0x1865ABED0", Slot = "5")]
	public IDictionary AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public KDMLJOLHNHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class AMPLENHDKDO : OGEKILALGOF<object>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private delegate void JMNOGOFFMOG(object APGNNKNJOPE, BPGOOCGBHEB MDONNIFBLDI, object DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private readonly IKBJOPMDILN<KeyValuePair<object, JMNOGOFFMOG>> GLKKGBIEICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private readonly BFDHJNAPNBH[] FOHOCKFHJNA;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x65A48C0", Offset = "0x65A30C0", VA = "0x1865A48C0")]
	public AMPLENHDKDO(params BFDHJNAPNBH[] FOHOCKFHJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x65A3F00", Offset = "0x65A2700", VA = "0x1865A3F00", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, object DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x65A3E70", Offset = "0x65A2670", VA = "0x1865A3E70", Slot = "5")]
	public object AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class AJJJBBCDIPE
{
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x65A1A60", Offset = "0x65A0260", VA = "0x1865A1A60")]
	public static object OKNFEKLNIPM(Type HJNJPNKDEFH, [Out] bool GOBHHFAGFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x65A1170", Offset = "0x659F970", VA = "0x1865A1170")]
	public static object BMNCJOFNCHH(Type HJNJPNKDEFH, [Out] bool GOBHHFAGFJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public class MEFHNIGLNAF<T> : OGEKILALGOF<T>, LMLLDOBHGKK, HGOJFABDFMC<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class FEACMDGIIHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public FEACMDGIIHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x345AEE0", Offset = "0x34596E0", VA = "0x18345AEE0")]
		internal bool CEKGCKHOPOL(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class DOIOOGHPCMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public DOIOOGHPCMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x4DEC4D0", Offset = "0x4DEACD0", VA = "0x184DEC4D0")]
		internal bool ADKBBHKNBDK(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class MPAELIIJJAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public HBDFBNNDOCH<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public MPAELIIJJAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x3CBBE30", Offset = "0x3CBA630", VA = "0x183CBBE30")]
		internal void LBFIOIEIAFB(BPGOOCGBHEB writer, T value, BFDHJNAPNBH _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class ONOELKFKEKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public BIEDANENIHJ<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public ONOELKFKEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x3E3FDD0", Offset = "0x3E3E5D0", VA = "0x183E3FDD0")]
		internal T PBPIMIOANKK(MJBBFIMEBFI reader, BFDHJNAPNBH _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly LECCIKGIKKO<T> HNGAMALHNCH;

	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private static readonly Dictionary<T, string> MGPPNJBGJOD;

	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private static readonly HBDFBNNDOCH<T> MPPGMKBBFHN;

	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private static readonly BIEDANENIHJ<T> DGNFFNLPNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private readonly bool NEFPCKCIFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private readonly HBDFBNNDOCH<T> EMDBJIGNEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private readonly BIEDANENIHJ<T> IGOEINNMDHK;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C56180", Offset = "0x3C54980", VA = "0x183C56180")]
	static MEFHNIGLNAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E0F0", Offset = "0x3C6C8F0", VA = "0x183C6E0F0")]
	public MEFHNIGLNAF(bool NEFPCKCIFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3C53380", Offset = "0x3C51B80", VA = "0x183C53380", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, T DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3C4E970", Offset = "0x3C4D170", VA = "0x183C4E970", Slot = "5")]
	public T AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3C55B10", Offset = "0x3C54310", VA = "0x183C55B10", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, T DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3C517A0", Offset = "0x3C4FFA0", VA = "0x183C517A0", Slot = "7")]
	public T CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class AIAMNMEOJNE<T> : OGEKILALGOF<T[,]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3653D30", Offset = "0x3652530", VA = "0x183653D30", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, T[,] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3653A00", Offset = "0x3652200", VA = "0x183653A00", Slot = "5")]
	public T[,] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public AIAMNMEOJNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class LGMKBMMHNHC<T> : OGEKILALGOF<T[,,]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3A1F320", Offset = "0x3A1DB20", VA = "0x183A1F320", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, T[,,] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3A1EEE0", Offset = "0x3A1D6E0", VA = "0x183A1EEE0", Slot = "5")]
	public T[,,] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public LGMKBMMHNHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class JELLJJIKMNF<T> : OGEKILALGOF<T[,,,]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x388C800", Offset = "0x388B000", VA = "0x18388C800", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, T[,,,] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x388C2B0", Offset = "0x388AAB0", VA = "0x18388C2B0", Slot = "5")]
	public T[,,,] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public JELLJJIKMNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class NEFIIKFHFLG<T> : OGEKILALGOF<T?>, LMLLDOBHGKK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C1F0", Offset = "0x3D0A9F0", VA = "0x183D0C1F0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, T? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x3D0BEC0", Offset = "0x3D0A6C0", VA = "0x183D0BEC0", Slot = "5")]
	public T? AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public NEFIIKFHFLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class GJOFCNOBGNK<T> : OGEKILALGOF<T?>, LMLLDOBHGKK where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly OGEKILALGOF<T> BFAFNGKCCLD;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	public GJOFCNOBGNK(OGEKILALGOF<T> BFAFNGKCCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3522C10", Offset = "0x3521410", VA = "0x183522C10", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, T? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3520E50", Offset = "0x351F650", VA = "0x183520E50", Slot = "5")]
	public T? AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class AKAPKPAIFNN : OGEKILALGOF<sbyte>, LMLLDOBHGKK, HGOJFABDFMC<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly AKAPKPAIFNN FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x65A2460", Offset = "0x65A0C60", VA = "0x1865A2460", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, sbyte DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x65A2350", Offset = "0x65A0B50", VA = "0x1865A2350", Slot = "5")]
	public sbyte AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x65A24C0", Offset = "0x65A0CC0", VA = "0x1865A24C0", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, sbyte DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x65A23A0", Offset = "0x65A0BA0", VA = "0x1865A23A0", Slot = "7")]
	public sbyte CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public AKAPKPAIFNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class IJKAIMMEICH : OGEKILALGOF<sbyte?>, LMLLDOBHGKK, HGOJFABDFMC<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly IJKAIMMEICH FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x65AA440", Offset = "0x65A8C40", VA = "0x1865AA440", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, sbyte? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x65AA270", Offset = "0x65A8A70", VA = "0x1865AA270", Slot = "5")]
	public sbyte? AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x65AA500", Offset = "0x65A8D00", VA = "0x1865AA500", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, sbyte? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x65AA320", Offset = "0x65A8B20", VA = "0x1865AA320", Slot = "7")]
	public sbyte? CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public IJKAIMMEICH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class PKDLHKHLEMM : OGEKILALGOF<sbyte[]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly PKDLHKHLEMM FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x65B2EC0", Offset = "0x65B16C0", VA = "0x1865B2EC0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, sbyte[] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x65B2D30", Offset = "0x65B1530", VA = "0x1865B2D30", Slot = "5")]
	public sbyte[] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public PKDLHKHLEMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class JBPMHPHAAHE : OGEKILALGOF<short>, LMLLDOBHGKK, HGOJFABDFMC<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly JBPMHPHAAHE FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x65AAA90", Offset = "0x65A9290", VA = "0x1865AAA90", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, short DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x65AA980", Offset = "0x65A9180", VA = "0x1865AA980", Slot = "5")]
	public short AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x65AAAF0", Offset = "0x65A92F0", VA = "0x1865AAAF0", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, short DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x65AA9D0", Offset = "0x65A91D0", VA = "0x1865AA9D0", Slot = "7")]
	public short CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public JBPMHPHAAHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class NGEOEOBLBMJ : OGEKILALGOF<short?>, LMLLDOBHGKK, HGOJFABDFMC<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly NGEOEOBLBMJ FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x65B23F0", Offset = "0x65B0BF0", VA = "0x1865B23F0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, short? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x65B2220", Offset = "0x65B0A20", VA = "0x1865B2220", Slot = "5")]
	public short? AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x65B24B0", Offset = "0x65B0CB0", VA = "0x1865B24B0", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, short? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x65B22D0", Offset = "0x65B0AD0", VA = "0x1865B22D0", Slot = "7")]
	public short? CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public NGEOEOBLBMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class HCLHMOCICAB : OGEKILALGOF<short[]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly HCLHMOCICAB FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x65A8DF0", Offset = "0x65A75F0", VA = "0x1865A8DF0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, short[] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x65A8C60", Offset = "0x65A7460", VA = "0x1865A8C60", Slot = "5")]
	public short[] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public HCLHMOCICAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class HGGMICHKAON : OGEKILALGOF<int>, LMLLDOBHGKK, HGOJFABDFMC<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly HGGMICHKAON FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x65A90B0", Offset = "0x65A78B0", VA = "0x1865A90B0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, int DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x65A8FA0", Offset = "0x65A77A0", VA = "0x1865A8FA0", Slot = "5")]
	public int AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x65A9110", Offset = "0x65A7910", VA = "0x1865A9110", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, int DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x65A8FF0", Offset = "0x65A77F0", VA = "0x1865A8FF0", Slot = "7")]
	public int CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public HGGMICHKAON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class NIKFAKJCJJI : OGEKILALGOF<int?>, LMLLDOBHGKK, HGOJFABDFMC<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly NIKFAKJCJJI FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x65B27C0", Offset = "0x65B0FC0", VA = "0x1865B27C0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, int? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x65B25F0", Offset = "0x65B0DF0", VA = "0x1865B25F0", Slot = "5")]
	public int? AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x65B2880", Offset = "0x65B1080", VA = "0x1865B2880", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, int? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x65B26A0", Offset = "0x65B0EA0", VA = "0x1865B26A0", Slot = "7")]
	public int? CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public NIKFAKJCJJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class IMKHBHJJHKA : OGEKILALGOF<int[]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly IMKHBHJJHKA FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x65AA7D0", Offset = "0x65A8FD0", VA = "0x1865AA7D0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, int[] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x65AA640", Offset = "0x65A8E40", VA = "0x1865AA640", Slot = "5")]
	public int[] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public IMKHBHJJHKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class HIKBPFJOJKO : OGEKILALGOF<long>, LMLLDOBHGKK, HGOJFABDFMC<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly HIKBPFJOJKO FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x65A96E0", Offset = "0x65A7EE0", VA = "0x1865A96E0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, long DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x65A95D0", Offset = "0x65A7DD0", VA = "0x1865A95D0", Slot = "5")]
	public long AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x65A9740", Offset = "0x65A7F40", VA = "0x1865A9740", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, long DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x65A9620", Offset = "0x65A7E20", VA = "0x1865A9620", Slot = "7")]
	public long CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public HIKBPFJOJKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class PKPEKELEHNI : OGEKILALGOF<long?>, LMLLDOBHGKK, HGOJFABDFMC<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly PKPEKELEHNI FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x65B3270", Offset = "0x65B1A70", VA = "0x1865B3270", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, long? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x65B3070", Offset = "0x65B1870", VA = "0x1865B3070", Slot = "5")]
	public long? AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x65B3330", Offset = "0x65B1B30", VA = "0x1865B3330", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, long? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x65B3130", Offset = "0x65B1930", VA = "0x1865B3130", Slot = "7")]
	public long? CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public PKPEKELEHNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class KCELDKIFJOF : OGEKILALGOF<long[]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly KCELDKIFJOF FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x65ABD20", Offset = "0x65AA520", VA = "0x1865ABD20", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, long[] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x65ABB90", Offset = "0x65AA390", VA = "0x1865ABB90", Slot = "5")]
	public long[] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public KCELDKIFJOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class BAAHPIHNBCD : OGEKILALGOF<byte>, LMLLDOBHGKK, HGOJFABDFMC<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly BAAHPIHNBCD FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x65A4E80", Offset = "0x65A3680", VA = "0x1865A4E80", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, byte DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x65A4D70", Offset = "0x65A3570", VA = "0x1865A4D70", Slot = "5")]
	public byte AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x65A4EE0", Offset = "0x65A36E0", VA = "0x1865A4EE0", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, byte DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x65A4DC0", Offset = "0x65A35C0", VA = "0x1865A4DC0", Slot = "7")]
	public byte CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public BAAHPIHNBCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class KPEOKOGEACI : OGEKILALGOF<byte?>, LMLLDOBHGKK, HGOJFABDFMC<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly KPEOKOGEACI FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x65ACC50", Offset = "0x65AB450", VA = "0x1865ACC50", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, byte? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x65ACA80", Offset = "0x65AB280", VA = "0x1865ACA80", Slot = "5")]
	public byte? AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x65ACD10", Offset = "0x65AB510", VA = "0x1865ACD10", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, byte? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x65ACB30", Offset = "0x65AB330", VA = "0x1865ACB30", Slot = "7")]
	public byte? CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public KPEOKOGEACI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class CEBJDKADJLH : OGEKILALGOF<ushort>, LMLLDOBHGKK, HGOJFABDFMC<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly CEBJDKADJLH FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x65A5F40", Offset = "0x65A4740", VA = "0x1865A5F40", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, ushort DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x65A5E30", Offset = "0x65A4630", VA = "0x1865A5E30", Slot = "5")]
	public ushort AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x65A5FA0", Offset = "0x65A47A0", VA = "0x1865A5FA0", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, ushort DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x65A5E80", Offset = "0x65A4680", VA = "0x1865A5E80", Slot = "7")]
	public ushort CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public CEBJDKADJLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class JLODJOGMDBC : OGEKILALGOF<ushort?>, LMLLDOBHGKK, HGOJFABDFMC<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly JLODJOGMDBC FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x65AB660", Offset = "0x65A9E60", VA = "0x1865AB660", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, ushort? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x65AB490", Offset = "0x65A9C90", VA = "0x1865AB490", Slot = "5")]
	public ushort? AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x65AB720", Offset = "0x65A9F20", VA = "0x1865AB720", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, ushort? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x65AB540", Offset = "0x65A9D40", VA = "0x1865AB540", Slot = "7")]
	public ushort? CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public JLODJOGMDBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class DOHFLLNBLFK : OGEKILALGOF<ushort[]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly DOHFLLNBLFK FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x65A6AE0", Offset = "0x65A52E0", VA = "0x1865A6AE0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, ushort[] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x65A6950", Offset = "0x65A5150", VA = "0x1865A6950", Slot = "5")]
	public ushort[] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public DOHFLLNBLFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class MNHEBAFBGPK : OGEKILALGOF<uint>, LMLLDOBHGKK, HGOJFABDFMC<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly MNHEBAFBGPK FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x65B20D0", Offset = "0x65B08D0", VA = "0x1865B20D0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, uint DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x65B1FC0", Offset = "0x65B07C0", VA = "0x1865B1FC0", Slot = "5")]
	public uint AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x65B2130", Offset = "0x65B0930", VA = "0x1865B2130", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, uint DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x65B2010", Offset = "0x65B0810", VA = "0x1865B2010", Slot = "7")]
	public uint CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public MNHEBAFBGPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class LHCGNJGMCEC : OGEKILALGOF<uint?>, LMLLDOBHGKK, HGOJFABDFMC<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly LHCGNJGMCEC FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x65AF170", Offset = "0x65AD970", VA = "0x1865AF170", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, uint? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x65AEFA0", Offset = "0x65AD7A0", VA = "0x1865AEFA0", Slot = "5")]
	public uint? AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x65AF230", Offset = "0x65ADA30", VA = "0x1865AF230", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, uint? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x65AF050", Offset = "0x65AD850", VA = "0x1865AF050", Slot = "7")]
	public uint? CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public LHCGNJGMCEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class CHFKDAGBOND : OGEKILALGOF<uint[]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly CHFKDAGBOND FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x65A6220", Offset = "0x65A4A20", VA = "0x1865A6220", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, uint[] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x65A6090", Offset = "0x65A4890", VA = "0x1865A6090", Slot = "5")]
	public uint[] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public CHFKDAGBOND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class MDOLPNEFPBK : OGEKILALGOF<ulong>, LMLLDOBHGKK, HGOJFABDFMC<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly MDOLPNEFPBK FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x65B0980", Offset = "0x65AF180", VA = "0x1865B0980", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, ulong DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x65B0870", Offset = "0x65AF070", VA = "0x1865B0870", Slot = "5")]
	public ulong AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x65B09E0", Offset = "0x65AF1E0", VA = "0x1865B09E0", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, ulong DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x65B08C0", Offset = "0x65AF0C0", VA = "0x1865B08C0", Slot = "7")]
	public ulong CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public MDOLPNEFPBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class LODDNLNNGHF : OGEKILALGOF<ulong?>, LMLLDOBHGKK, HGOJFABDFMC<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly LODDNLNNGHF FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x65B0670", Offset = "0x65AEE70", VA = "0x1865B0670", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, ulong? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x65B0470", Offset = "0x65AEC70", VA = "0x1865B0470", Slot = "5")]
	public ulong? AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x65B0730", Offset = "0x65AEF30", VA = "0x1865B0730", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, ulong? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x65B0530", Offset = "0x65AED30", VA = "0x1865B0530", Slot = "7")]
	public ulong? CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public LODDNLNNGHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class JFCGKCLKNAN : OGEKILALGOF<ulong[]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly JFCGKCLKNAN FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x65AAF90", Offset = "0x65A9790", VA = "0x1865AAF90", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, ulong[] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x65AAE00", Offset = "0x65A9600", VA = "0x1865AAE00", Slot = "5")]
	public ulong[] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public JFCGKCLKNAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class IGLJFKKELHO : OGEKILALGOF<float>, LMLLDOBHGKK, HGOJFABDFMC<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly IGLJFKKELHO FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x65AA120", Offset = "0x65A8920", VA = "0x1865AA120", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, float DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x65AA010", Offset = "0x65A8810", VA = "0x1865AA010", Slot = "5")]
	public float AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x65AA180", Offset = "0x65A8980", VA = "0x1865AA180", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, float DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x65AA060", Offset = "0x65A8860", VA = "0x1865AA060", Slot = "7")]
	public float CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public IGLJFKKELHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class LBPFHFEBHOC : OGEKILALGOF<float?>, LMLLDOBHGKK, HGOJFABDFMC<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly LBPFHFEBHOC FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x65AE560", Offset = "0x65ACD60", VA = "0x1865AE560", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, float? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x65AE390", Offset = "0x65ACB90", VA = "0x1865AE390", Slot = "5")]
	public float? AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x65AE620", Offset = "0x65ACE20", VA = "0x1865AE620", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, float? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x65AE440", Offset = "0x65ACC40", VA = "0x1865AE440", Slot = "7")]
	public float? CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public LBPFHFEBHOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class JGLOPOGFOOB : OGEKILALGOF<float[]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly JGLOPOGFOOB FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x65AB2D0", Offset = "0x65A9AD0", VA = "0x1865AB2D0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, float[] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x65AB140", Offset = "0x65A9940", VA = "0x1865AB140", Slot = "5")]
	public float[] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public JGLOPOGFOOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class IDMMEBBAKKO : OGEKILALGOF<double>, LMLLDOBHGKK, HGOJFABDFMC<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly IDMMEBBAKKO FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x65A9EC0", Offset = "0x65A86C0", VA = "0x1865A9EC0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, double DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x65A9DB0", Offset = "0x65A85B0", VA = "0x1865A9DB0", Slot = "5")]
	public double AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x65A9F20", Offset = "0x65A8720", VA = "0x1865A9F20", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, double DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x65A9E00", Offset = "0x65A8600", VA = "0x1865A9E00", Slot = "7")]
	public double CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public IDMMEBBAKKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class ANEEJCJPFND : OGEKILALGOF<double?>, LMLLDOBHGKK, HGOJFABDFMC<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly ANEEJCJPFND FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x65A4B70", Offset = "0x65A3370", VA = "0x1865A4B70", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, double? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x65A4970", Offset = "0x65A3170", VA = "0x1865A4970", Slot = "5")]
	public double? AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x65A4C30", Offset = "0x65A3430", VA = "0x1865A4C30", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, double? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x65A4A30", Offset = "0x65A3230", VA = "0x1865A4A30", Slot = "7")]
	public double? CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public ANEEJCJPFND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class ABKDEOIAKEG : OGEKILALGOF<double[]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly ABKDEOIAKEG FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x65A0940", Offset = "0x659F140", VA = "0x1865A0940", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, double[] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x65A07B0", Offset = "0x659EFB0", VA = "0x1865A07B0", Slot = "5")]
	public double[] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public ABKDEOIAKEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class LFHMDJFEBDE : OGEKILALGOF<bool>, LMLLDOBHGKK, HGOJFABDFMC<bool>
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly LFHMDJFEBDE FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x65AEE50", Offset = "0x65AD650", VA = "0x1865AEE50", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, bool DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x65AED40", Offset = "0x65AD540", VA = "0x1865AED40", Slot = "5")]
	public bool AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x65AEEB0", Offset = "0x65AD6B0", VA = "0x1865AEEB0", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, bool DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x65AED90", Offset = "0x65AD590", VA = "0x1865AED90", Slot = "7")]
	public bool CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public LFHMDJFEBDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class HHNIEKJEMHL : OGEKILALGOF<bool?>, LMLLDOBHGKK, HGOJFABDFMC<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly HHNIEKJEMHL FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x65A93D0", Offset = "0x65A7BD0", VA = "0x1865A93D0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, bool? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x65A9200", Offset = "0x65A7A00", VA = "0x1865A9200", Slot = "5")]
	public bool? AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x65A9490", Offset = "0x65A7C90", VA = "0x1865A9490", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, bool? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x65A92B0", Offset = "0x65A7AB0", VA = "0x1865A92B0", Slot = "7")]
	public bool? CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public HHNIEKJEMHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class ABHKIIKLLBG : OGEKILALGOF<bool[]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly ABHKIIKLLBG FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x65A05F0", Offset = "0x659EDF0", VA = "0x1865A05F0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, bool[] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x65A0460", Offset = "0x659EC60", VA = "0x1865A0460", Slot = "5")]
	public bool[] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public ABHKIIKLLBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class MGKBNHDBKLB : OGEKILALGOF<object>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly OGEKILALGOF<object> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly Dictionary<Type, int> GPINPLNKMGK;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x65B0F10", Offset = "0x65AF710", VA = "0x1865B0F10", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, object DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x65B0AD0", Offset = "0x65AF2D0", VA = "0x1865B0AD0", Slot = "5")]
	public object AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public MGKBNHDBKLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class LKJMEHIJEJM : OGEKILALGOF<byte[]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly OGEKILALGOF<byte[]> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x65B0330", Offset = "0x65AEB30", VA = "0x1865B0330", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, byte[] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x65B0280", Offset = "0x65AEA80", VA = "0x1865B0280", Slot = "5")]
	public byte[] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public LKJMEHIJEJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class LCILNGHDAEM : OGEKILALGOF<ArraySegment<byte>>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly OGEKILALGOF<ArraySegment<byte>> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x65AE870", Offset = "0x65AD070", VA = "0x1865AE870", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, ArraySegment<byte> DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x65AE760", Offset = "0x65ACF60", VA = "0x1865AE760", Slot = "5")]
	public ArraySegment<byte> AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public LCILNGHDAEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class JMABEHBDOHH : OGEKILALGOF<string>, LMLLDOBHGKK, HGOJFABDFMC<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly OGEKILALGOF<string> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x65AB900", Offset = "0x65AA100", VA = "0x1865AB900", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, string DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x65AB860", Offset = "0x65AA060", VA = "0x1865AB860", Slot = "5")]
	public string AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x65AB960", Offset = "0x65AA160", VA = "0x1865AB960", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, string DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x65AB8B0", Offset = "0x65AA0B0", VA = "0x1865AB8B0", Slot = "7")]
	public string CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public JMABEHBDOHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class HPCMEEFJOBE : OGEKILALGOF<string[]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly HPCMEEFJOBE FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x65A9A00", Offset = "0x65A8200", VA = "0x1865A9A00", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, string[] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x65A9830", Offset = "0x65A8030", VA = "0x1865A9830", Slot = "5")]
	public string[] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public HPCMEEFJOBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class CANHGBPFCCP : OGEKILALGOF<char>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly CANHGBPFCCP FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x65A5820", Offset = "0x65A4020", VA = "0x1865A5820", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, char DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x65A57B0", Offset = "0x65A3FB0", VA = "0x1865A57B0", Slot = "5")]
	public char AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public CANHGBPFCCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class GFHEIGGOEGC : OGEKILALGOF<char?>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly GFHEIGGOEGC FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x65A80F0", Offset = "0x65A68F0", VA = "0x1865A80F0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, char? DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x65A7FD0", Offset = "0x65A67D0", VA = "0x1865A7FD0", Slot = "5")]
	public char? AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public GFHEIGGOEGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class BGENCOJDLFA : OGEKILALGOF<char[]>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly BGENCOJDLFA FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x65A53A0", Offset = "0x65A3BA0", VA = "0x1865A53A0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, char[] DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x65A51E0", Offset = "0x65A39E0", VA = "0x1865A51E0", Slot = "5")]
	public char[] AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public BGENCOJDLFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class KMLFEAHDFMA : OGEKILALGOF<Guid>, LMLLDOBHGKK, HGOJFABDFMC<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly OGEKILALGOF<Guid> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x65AC790", Offset = "0x65AAF90", VA = "0x1865AC790", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, Guid DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x65AC660", Offset = "0x65AAE60", VA = "0x1865AC660", Slot = "5")]
	public Guid AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x65AC8C0", Offset = "0x65AB0C0", VA = "0x1865AC8C0", Slot = "6")]
	public void PGOKKICCLOL(BPGOOCGBHEB MDONNIFBLDI, Guid DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x65AC6F0", Offset = "0x65AAEF0", VA = "0x1865AC6F0", Slot = "7")]
	public Guid CKLMFIBJBLE(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public KMLFEAHDFMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class CBNPHMMCFAI : OGEKILALGOF<decimal>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly OGEKILALGOF<decimal> FCIJPOCPFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private readonly bool EHOGFHDBAJH;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x502CE30", Offset = "0x502B630", VA = "0x18502CE30")]
	public CBNPHMMCFAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x16D2200", Offset = "0x16D0A00", VA = "0x1816D2200")]
	public CBNPHMMCFAI(bool EHOGFHDBAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x65A5C00", Offset = "0x65A4400", VA = "0x1865A5C00", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, decimal DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x65A5960", Offset = "0x65A4160", VA = "0x1865A5960", Slot = "5")]
	public decimal AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class JFAGLHOOHPI : OGEKILALGOF<Uri>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly OGEKILALGOF<Uri> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x65AACA0", Offset = "0x65A94A0", VA = "0x1865AACA0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, Uri DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x65AABE0", Offset = "0x65A93E0", VA = "0x1865AABE0", Slot = "5")]
	public Uri AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public JFAGLHOOHPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class HPOEPGGFMPD : OGEKILALGOF<Version>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly OGEKILALGOF<Version> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x65A9C70", Offset = "0x65A8470", VA = "0x1865A9C70", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, Version DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x65A9BB0", Offset = "0x65A83B0", VA = "0x1865A9BB0", Slot = "5")]
	public Version AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public HPOEPGGFMPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class GHFGFFOKICC<TKey, TValue> : OGEKILALGOF<KeyValuePair<TKey, TValue>>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x351CB70", Offset = "0x351B370", VA = "0x18351CB70", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, KeyValuePair<TKey, TValue> DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x351C840", Offset = "0x351B040", VA = "0x18351C840", Slot = "5")]
	public KeyValuePair<TKey, TValue> AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class BNGPFHBLHBO : OGEKILALGOF<StringBuilder>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly OGEKILALGOF<StringBuilder> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x65A5690", Offset = "0x65A3E90", VA = "0x1865A5690", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, StringBuilder DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x65A55D0", Offset = "0x65A3DD0", VA = "0x1865A55D0", Slot = "5")]
	public StringBuilder AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public BNGPFHBLHBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class LFFPENAHBAB : OGEKILALGOF<BitArray>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly OGEKILALGOF<BitArray> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x65AEBA0", Offset = "0x65AD3A0", VA = "0x1865AEBA0", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, BitArray DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x65AEA20", Offset = "0x65AD220", VA = "0x1865AEA20", Slot = "5")]
	public BitArray AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public LFFPENAHBAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class OOKPKPAPHJF : OGEKILALGOF<Type>, LMLLDOBHGKK
{
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly OOKPKPAPHJF FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly Regex NIBOEKDGODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private bool NJBAKDFLDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private bool BLDPJOLBCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private bool FOCOBPLEDHI;

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x65B2D10", Offset = "0x65B1510", VA = "0x1865B2D10")]
	public OOKPKPAPHJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D36480", Offset = "0x5D34C80", VA = "0x185D36480")]
	public OOKPKPAPHJF(bool NJBAKDFLDLI, bool BLDPJOLBCEF, bool FOCOBPLEDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x65B2B10", Offset = "0x65B1310", VA = "0x1865B2B10", Slot = "4")]
	public void JMOOMJHDBEG(BPGOOCGBHEB MDONNIFBLDI, Type DOLICEBFIPF, BFDHJNAPNBH BIHDDBPLIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x65B29C0", Offset = "0x65B11C0", VA = "0x1865B29C0", Slot = "5")]
	public Type AEDPLFCAHJC(MJBBFIMEBFI EINLOJPKPLI, BFDHJNAPNBH BIHDDBPLIFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal static class BEHKICFGJCM
{
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal static readonly byte[][] HGKLIODMOOE;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal static readonly JPMOGNBDGPH OBGHIKCBOGJ;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x65A4FD0", Offset = "0x65A37D0", VA = "0x1865A4FD0")]
	static BEHKICFGJCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class GJIAKMEODBE
{
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal static readonly byte[][] NNIMDCFBPMG;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal static readonly JPMOGNBDGPH FOHPICPAGME;

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x65A8A50", Offset = "0x65A7250", VA = "0x1865A8A50")]
	static GJIAKMEODBE()
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
