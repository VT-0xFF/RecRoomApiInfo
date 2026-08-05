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
internal static class GDPBBOKLBHL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x657D7E0", Offset = "0x657C3E0", VA = "0x18657D7E0")]
	public static bool HGAHLMKHCEP(this TypeInfo OMKEAAPIABA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class MNCJICOCGME : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type LFMPJOJHCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] FNMGDKOBOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x79BDE0", Offset = "0x79A9E0", VA = "0x18079BDE0")]
	public MNCJICOCGME(Type ACCIGDHBFGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class EJKALEPAIBC : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void NJBNJFDLMJL<T>(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T EKOKIEPPFIG<T>(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AJMNHAEOIAA);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LKLKMMHABOC
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CBFHJMOMLDG<T> : LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JGMIPKPABCI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum LHNNGKOEDJE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EDEPIEPLMJA
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x23C8A50", Offset = "0x23C7650", VA = "0x1823C8A50")]
	public static string NAFNJJEAGFC<T>(this CBFHJMOMLDG<T> FINDNBBPFAE, T GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBFHJMOMLDG<T> EPFAOKPIMBK<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class AFBKJNBCDBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2B126D0", Offset = "0x2B112D0", VA = "0x182B126D0")]
	public static CBFHJMOMLDG<T> CCFGAHFNHKB<T>(this KJHGDFDBIIA AJMNHAEOIAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x656C3F0", Offset = "0x656AFF0", VA = "0x18656C3F0")]
	public static object PLHOKIHFBGD(this KJHGDFDBIIA AJMNHAEOIAA, Type OMKEAAPIABA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NHLBIPGDMFD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6585AF0", Offset = "0x65846F0", VA = "0x186585AF0")]
	public NHLBIPGDMFD(string EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct EPGBDNIILDN
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class OFAOJJNHFBI
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] NJCBLCELFEN;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] PJEGCCLIDDH;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6588180", Offset = "0x6586D80", VA = "0x186588180")]
		public static byte[] HHMJKHMNGNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6588220", Offset = "0x6586E20", VA = "0x186588220")]
		public static char[] LOLPEMJNENK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> KONIODFFFBD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] CMJOFKNCLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] FEGEJBFJFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int IAKOFEGDGBF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool LAHFEIBMJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6579110", Offset = "0x6577D10", VA = "0x186579110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x657BBB0", Offset = "0x657A7B0", VA = "0x18657BBB0")]
	public EPGBDNIILDN(byte[] FEGEJBFJFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x657BA50", Offset = "0x657A650", VA = "0x18657BA50")]
	public EPGBDNIILDN(byte[] FEGEJBFJFNG, int IAKOFEGDGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6579430", Offset = "0x6578030", VA = "0x186579430")]
	private MAOBNNJNPHF GEJHLOEBKHA(string GLFGEBKCMID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x657B3C0", Offset = "0x6579FC0", VA = "0x18657B3C0")]
	private MAOBNNJNPHF NPHBOLOLOFK(string EOOPGFAEMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6576FF0", Offset = "0x6575BF0", VA = "0x186576FF0")]
	public void NDJDGAJJDOP(int IAKOFEGDGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
	public byte[] JNNKHHJPHKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CDC8B0", Offset = "0x1CDB4B0", VA = "0x181CDC8B0")]
	public int EEDNNLLAKJG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x657A6A0", Offset = "0x65792A0", VA = "0x18657A6A0")]
	public LMNEBLINOHL KKOKHDJKGPL()
	{
		return default(LMNEBLINOHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x657AFD0", Offset = "0x6579BD0", VA = "0x18657AFD0")]
	public void NCNFEAAJFIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x657A8E0", Offset = "0x65794E0", VA = "0x18657A8E0")]
	public bool LBKAJIHHFFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6578780", Offset = "0x6577380", VA = "0x186578780")]
	public bool ACKGEOIHKAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x657B5D0", Offset = "0x657A1D0", VA = "0x18657B5D0")]
	public void OGHOCOLIPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x657AA00", Offset = "0x6579600", VA = "0x18657AA00")]
	public bool LJDKMKIHLAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6579D60", Offset = "0x6578960", VA = "0x186579D60")]
	public bool JMHLOEPODND(int EMHEDPDPEMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x657B7C0", Offset = "0x657A3C0", VA = "0x18657B7C0")]
	public bool PDPHOLPBFHF(int EMHEDPDPEMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6579130", Offset = "0x6577D30", VA = "0x186579130")]
	public bool EMCJLAIGLHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6579980", Offset = "0x6578580", VA = "0x186579980")]
	public void GGFDEBJPFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x657A850", Offset = "0x6579450", VA = "0x18657A850")]
	public bool KOAHJBIKPCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6579E30", Offset = "0x6578A30", VA = "0x186579E30")]
	public bool JOLEEFDLEDJ(int EMHEDPDPEMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6578C60", Offset = "0x6577860", VA = "0x186578C60")]
	public bool BMNEJABCPAB(int EMHEDPDPEMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x657B670", Offset = "0x657A270", VA = "0x18657B670")]
	public bool OOIHCOMHPKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6578810", Offset = "0x6577410", VA = "0x186578810")]
	public void AHDOOLJILGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6579080", Offset = "0x6577C80", VA = "0x186579080")]
	public bool EIOOLLIPDGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x657B890", Offset = "0x657A490", VA = "0x18657B890")]
	public void PHKDOBFOPNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6579F00", Offset = "0x6578B00", VA = "0x186579F00")]
	private void KGMOKCOJMMB([Out] byte[] INFGLCNPHPK, [Out] int PFAFIOFLDEJ, [Out] int HLBACCFLAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6579280", Offset = "0x6577E80", VA = "0x186579280")]
	private static int FFEHFIPEDML(char FLGIINLNNEM, char KNDAEONALIC, char KIHBPBFELGP, char DKFOONILOPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x657AE70", Offset = "0x6579A70", VA = "0x18657AE70")]
	private static int MJGPINIJNHA(char HPIMCNPJDMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x657B4B0", Offset = "0x657A0B0", VA = "0x18657B4B0")]
	public ArraySegment<byte> OFPHMEBBDEB()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6579C80", Offset = "0x6578880", VA = "0x186579C80")]
	public string IGOIJNCEPFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6579C10", Offset = "0x6578810", VA = "0x186579C10")]
	public string IGGGPIIKBDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x657AA90", Offset = "0x6579690", VA = "0x18657AA90")]
	public ArraySegment<byte> MGLBEDNCGJB()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x657B350", Offset = "0x6579F50", VA = "0x18657B350")]
	public ArraySegment<byte> NNAKOEIJDLO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x657B100", Offset = "0x6579D00", VA = "0x18657B100")]
	public bool NKEBNJGIMGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x65791C0", Offset = "0x6577DC0", VA = "0x1865791C0")]
	private static bool FDEMDOKFNCK(byte KIHBPBFELGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6578A10", Offset = "0x6577610", VA = "0x186578A10")]
	private void AIEBHHODBPL(LMNEBLINOHL KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6578FB0", Offset = "0x6577BB0", VA = "0x186578FB0")]
	public void EEPMHNDJOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x65788B0", Offset = "0x65774B0", VA = "0x1865788B0")]
	private void AHEMDBCBAAH(int FIACJKMJIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6578E30", Offset = "0x6577A30", VA = "0x186578E30")]
	public sbyte CHMJCBCDPPL()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6579A20", Offset = "0x6578620", VA = "0x186579A20")]
	public short HCDIJGBANMG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x657AF50", Offset = "0x6579B50", VA = "0x18657AF50")]
	public int MLJMMPOIAEI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x657B700", Offset = "0x657A300", VA = "0x18657B700")]
	public long PDFAPFMJCNA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6579000", Offset = "0x6577C00", VA = "0x186579000")]
	public byte EGMGFOCJNCK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6578D30", Offset = "0x6577930", VA = "0x186578D30")]
	public ushort BMOMAHHBDPF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6578DB0", Offset = "0x65779B0", VA = "0x186578DB0")]
	public uint CFIPKEMCFJB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x657ACB0", Offset = "0x65798B0", VA = "0x18657ACB0")]
	public ulong MIBHGPJPIOM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6579330", Offset = "0x6577F30", VA = "0x186579330")]
	public float FMEHOAGPDNL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6578EB0", Offset = "0x6577AB0", VA = "0x186578EB0")]
	public double DJBBLBLLGLM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x657AD70", Offset = "0x6579970", VA = "0x18657AD70")]
	public ArraySegment<byte> MJBMLEGCHPE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6579AA0", Offset = "0x65786A0", VA = "0x186579AA0")]
	private static int IAPGMFAGNFE(byte[] FEGEJBFJFNG, int IAKOFEGDGBF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MAOBNNJNPHF : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference GJCECJADAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int EJPHGNGKBGB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int NAJLGFDJGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB98650", Offset = "0xB97250", VA = "0x180B98650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string NEFOIHNILOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x837230", Offset = "0x835E30", VA = "0x180837230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6583C50", Offset = "0x6582850", VA = "0x186583C50")]
	public MAOBNNJNPHF(string EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6583CB0", Offset = "0x65828B0", VA = "0x186583CB0")]
	public MAOBNNJNPHF(string EOOPGFAEMIH, byte[] MIFCOMCNCGK, int IAKOFEGDGBF, int EJPHGNGKBGB, string IFEKFKBGPEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FJIAEKMDAMF
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class HMIPFKCLJMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] NJCBLCELFEN;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x657E060", Offset = "0x657CC60", VA = "0x18657E060")]
		public static byte[] HHMJKHMNGNG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class BHPFLFHMPEI
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void PMKJFCONMKL(CJMDLGBHBBN BNGNOICJJGA, object GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object JDBBPAOHBLD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AJMNHAEOIAA);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class NKCPIGEJHCC
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class FEPFCLEFHHK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
				public FEPFCLEFHHK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x3C8D830", Offset = "0x3C8C430", VA = "0x183C8D830")]
				internal bool IENGEDNFHJK(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x657BC10", Offset = "0x657A810", VA = "0x18657BC10")]
				internal bool GPHNOBDBCCL(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, KJHGDFDBIIA, byte[]> OEHFJMLBHNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, KJHGDFDBIIA> NHCECFCCAEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly PMKJFCONMKL FMIGJBHGGKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, KJHGDFDBIIA, ArraySegment<byte>> IPLIPILCAHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, KJHGDFDBIIA, string> HLEIBEGMCNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, KJHGDFDBIIA, object> KIJGJGBFHBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, KJHGDFDBIIA, object> ODBGILGGDFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, KJHGDFDBIIA, object> LMFONKMLNNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly JDBBPAOHBLD DMJGLGEOBCA;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6585DA0", Offset = "0x65849A0", VA = "0x186585DA0")]
			public NKCPIGEJHCC(Type OMKEAAPIABA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2ADD340", Offset = "0x2ADBF40", VA = "0x182ADD340")]
			private static T IBPDCDIGIND<T>(DynamicMethod MNGGLEJNCMN)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6585B50", Offset = "0x6584750", VA = "0x186585B50")]
			private static MethodInfo KJFPPNJFMHL(Type OMKEAAPIABA, string JEICAPDKHKI, Type[] FPHNDOFLJJD)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, NKCPIGEJHCC> BNFPBLCOFNM;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly PDIEOAAENMF<NKCPIGEJHCC> CPHFPJMCPIF;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x656CCF0", Offset = "0x656B8F0", VA = "0x18656CCF0")]
		static BHPFLFHMPEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x656C9E0", Offset = "0x656B5E0", VA = "0x18656C9E0")]
		private static NKCPIGEJHCC OCMJLJAHBBI(Type OMKEAAPIABA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x656CA60", Offset = "0x656B660", VA = "0x18656CA60")]
		public static void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, object GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x656CBE0", Offset = "0x656B7E0", VA = "0x18656CBE0")]
		public static void OIIEHDKDHEB(Type OMKEAAPIABA, CJMDLGBHBBN BNGNOICJJGA, object GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static KJHGDFDBIIA GIGOKALMGAI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] LKOHBLBAJMG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] GCPOMILIPIG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static KJHGDFDBIIA IKHFGOMGNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x657C200", Offset = "0x657AE00", VA = "0x18657C200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool BKIHKFDKCKN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x657CCE0", Offset = "0x657B8E0", VA = "0x18657CCE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x657CC70", Offset = "0x657B870", VA = "0x18657CC70")]
	public static void NEFGODEHICP(KJHGDFDBIIA AJMNHAEOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x24E1080", Offset = "0x24DFC80", VA = "0x1824E1080")]
	public static byte[] OIIEHDKDHEB<T>(T IIFJCGIHMIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x24E0DE0", Offset = "0x24DF9E0", VA = "0x1824E0DE0")]
	public static byte[] OIIEHDKDHEB<T>(T GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x24E0F60", Offset = "0x24DFB60", VA = "0x1824E0F60")]
	public static void OIIEHDKDHEB<T>(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x24E1100", Offset = "0x24DFD00", VA = "0x1824E1100")]
	public static void OIIEHDKDHEB<T>(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x24E0FF0", Offset = "0x24DFBF0", VA = "0x1824E0FF0")]
	public static void OIIEHDKDHEB<T>(Stream BOOOCBOEPIH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x24E0CA0", Offset = "0x24DF8A0", VA = "0x1824E0CA0")]
	public static void OIIEHDKDHEB<T>(Stream BOOOCBOEPIH, T GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x24E11E0", Offset = "0x24DFDE0", VA = "0x1824E11E0")]
	public static ArraySegment<byte> PBOGHPEMMHL<T>(T IIFJCGIHMIN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x24E1270", Offset = "0x24DFE70", VA = "0x1824E1270")]
	public static ArraySegment<byte> PBOGHPEMMHL<T>(T GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x24E0C20", Offset = "0x24DF820", VA = "0x1824E0C20")]
	public static string NAFNJJEAGFC<T>(T GCPEEAODAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x24E0AA0", Offset = "0x24DF6A0", VA = "0x1824E0AA0")]
	public static string NAFNJJEAGFC<T>(T GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x24E01C0", Offset = "0x24DEDC0", VA = "0x1824E01C0")]
	public static T JFKFFNFOIMD<T>(string MFADGLMMHMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24E0250", Offset = "0x24DEE50", VA = "0x1824E0250")]
	public static T JFKFFNFOIMD<T>(string MFADGLMMHMB, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x24E03C0", Offset = "0x24DEFC0", VA = "0x1824E03C0")]
	public static T JFKFFNFOIMD<T>(byte[] FEGEJBFJFNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x24DFFA0", Offset = "0x24DEBA0", VA = "0x1824DFFA0")]
	public static T JFKFFNFOIMD<T>(byte[] FEGEJBFJFNG, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x24E06E0", Offset = "0x24DF2E0", VA = "0x1824E06E0")]
	public static T JFKFFNFOIMD<T>(byte[] FEGEJBFJFNG, int IAKOFEGDGBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x24E0030", Offset = "0x24DEC30", VA = "0x1824E0030")]
	public static T JFKFFNFOIMD<T>(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x24E08B0", Offset = "0x24DF4B0", VA = "0x1824E08B0")]
	public static T JFKFFNFOIMD<T>(EPGBDNIILDN BIBCAMINPDH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24E0510", Offset = "0x24DF110", VA = "0x1824E0510")]
	public static T JFKFFNFOIMD<T>(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x24E05E0", Offset = "0x24DF1E0", VA = "0x1824E05E0")]
	public static T JFKFFNFOIMD<T>(Stream BOOOCBOEPIH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x24E0770", Offset = "0x24DF370", VA = "0x1824E0770")]
	public static T JFKFFNFOIMD<T>(Stream BOOOCBOEPIH, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x657C0A0", Offset = "0x657ACA0", VA = "0x18657C0A0")]
	public static string BGCPOOKOCNC(byte[] MFADGLMMHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x657BF60", Offset = "0x657AB60", VA = "0x18657BF60")]
	public static string BGCPOOKOCNC(byte[] MFADGLMMHMB, int IAKOFEGDGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x657BDD0", Offset = "0x657A9D0", VA = "0x18657BDD0")]
	public static string BGCPOOKOCNC(string MFADGLMMHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x657CE90", Offset = "0x657BA90", VA = "0x18657CE90")]
	public static byte[] OOLLGGJDJOF(byte[] MFADGLMMHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x657CD40", Offset = "0x657B940", VA = "0x18657CD40")]
	public static byte[] OOLLGGJDJOF(byte[] MFADGLMMHMB, int IAKOFEGDGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x657D010", Offset = "0x657BC10", VA = "0x18657D010")]
	public static byte[] OOLLGGJDJOF(string MFADGLMMHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x657C3A0", Offset = "0x657AFA0", VA = "0x18657C3A0")]
	private static void NAELDMNDEDF(EPGBDNIILDN BIBCAMINPDH, CJMDLGBHBBN BNGNOICJJGA, int OLLFIMGHMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x657C300", Offset = "0x657AF00", VA = "0x18657C300")]
	private static int INKAIMPKOAH(Stream MAIMNHFMIBD, byte[] NJCBLCELFEN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum LMNEBLINOHL : byte
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
public struct CJMDLGBHBBN
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] DOMBIOMFOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] NJCBLCELFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int IAKOFEGDGBF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KNIKNGHFLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1CDC8B0", Offset = "0x1CDB4B0", VA = "0x181CDC8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6576FF0", Offset = "0x6575BF0", VA = "0x186576FF0")]
	public void NDJDGAJJDOP(int IAKOFEGDGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6576800", Offset = "0x6575400", VA = "0x186576800")]
	public static byte[] LFENGJFDJJF(string DKLHENCIMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6576200", Offset = "0x6574E00", VA = "0x186576200")]
	public static byte[] HDENEKIAIBM(string DKLHENCIMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6576550", Offset = "0x6575150", VA = "0x186576550")]
	public static byte[] KIABIOMJPDD(string DKLHENCIMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6576AE0", Offset = "0x65756E0", VA = "0x186576AE0")]
	public static byte[] MJKANOPDBLM(string DKLHENCIMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x538EBF0", Offset = "0x538D7F0", VA = "0x18538EBF0")]
	public CJMDLGBHBBN(byte[] DEEDOADFNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6576370", Offset = "0x6574F70", VA = "0x186576370")]
	public ArraySegment<byte> HHMJKHMNGNG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6577160", Offset = "0x6575D60", VA = "0x186577160")]
	public byte[] PILAOFMJBOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6577220", Offset = "0x6575E20", VA = "0x186577220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x65761F0", Offset = "0x6574DF0", VA = "0x1865761F0")]
	public void GFMENOKGFNH(int LKLPIFOHKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6576740", Offset = "0x6575340", VA = "0x186576740")]
	public void LAHHBPDJAMN(byte MEJEJMPMGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x65767A0", Offset = "0x65753A0", VA = "0x1865767A0")]
	public void LAHHBPDJAMN(byte[] MEJEJMPMGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x65760D0", Offset = "0x6574CD0", VA = "0x1865760D0")]
	public void EDGJLBFAAJK(byte MEJEJMPMGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x65771D0", Offset = "0x6575DD0", VA = "0x1865771D0")]
	public void PKMPLJIJOBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6575FB0", Offset = "0x6574BB0", VA = "0x186575FB0")]
	public void BBPADFEHNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x65764D0", Offset = "0x65750D0", VA = "0x1865764D0")]
	public void JHHLHCJHMJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6576410", Offset = "0x6575010", VA = "0x186576410")]
	public void HNJKNADMDPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6575E00", Offset = "0x6574A00", VA = "0x186575E00")]
	public void AJCNIOLKEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6576030", Offset = "0x6574C30", VA = "0x186576030")]
	public void CHNHDACOIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6576A40", Offset = "0x6575640", VA = "0x186576A40")]
	public void MGIAJOPBPCA(string DKLHENCIMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6576080", Offset = "0x6574C80", VA = "0x186576080")]
	public void DFGHKGPPHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x65769A0", Offset = "0x65755A0", VA = "0x1865769A0")]
	public void MEGMFEDPGAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6575E50", Offset = "0x6574A50", VA = "0x186575E50")]
	public void AOIKEBCNFEL(bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x65766C0", Offset = "0x65752C0", VA = "0x1865766C0")]
	public void KNLODJLIHPP(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6577000", Offset = "0x6575C00", VA = "0x186577000")]
	public void ODEMJCGFOEL(double GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x65770F0", Offset = "0x6575CF0", VA = "0x1865770F0")]
	public void PBJOMMIKBGG(byte GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6576180", Offset = "0x6574D80", VA = "0x186576180")]
	public void FGLNJMPHFDH(ushort GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6577080", Offset = "0x6575C80", VA = "0x186577080")]
	public void OIGDGMJLBGA(uint GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6576000", Offset = "0x6574C00", VA = "0x186576000")]
	public void CHGOFFFENEB(ulong GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6576110", Offset = "0x6574D10", VA = "0x186576110")]
	public void ENCIAHGDCDG(sbyte GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6576460", Offset = "0x6575060", VA = "0x186576460")]
	public void IOIHHJJPHMI(short GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6576930", Offset = "0x6575530", VA = "0x186576930")]
	public void LGOIFMLMELM(int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6576520", Offset = "0x6575120", VA = "0x186576520")]
	public void JNMHPCEDPEB(long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6576C60", Offset = "0x6575860", VA = "0x186576C60")]
	public void NCGEKKNDEKI(string GCPEEAODAIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MGOLJPANFFP : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class BACANLBPLOI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x450D300", Offset = "0x450BF00", VA = "0x18450D300")]
		static BACANLBPLOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private MGOLJPANFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class BPAIDLFHBJI
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> IBDCHFJECOF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x656D630", Offset = "0x656C230", VA = "0x18656D630")]
	static BPAIDLFHBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x656CE40", Offset = "0x656BA40", VA = "0x18656CE40")]
	internal static object EPFAOKPIMBK(Type GHKAOLMKPMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class KPNBIOEFFCO : CBFHJMOMLDG<Vector2>, LKLKMMHABOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DBPCFPGMCBB DIHAKIACPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] HGLCENBMOMB;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x65812C0", Offset = "0x657FEC0", VA = "0x1865812C0")]
	public KPNBIOEFFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x65810D0", Offset = "0x657FCD0", VA = "0x1865810D0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Vector2 GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6580DE0", Offset = "0x657F9E0", VA = "0x186580DE0", Slot = "5")]
	public Vector2 JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class DGCLHCGENNA : CBFHJMOMLDG<Vector3>, LKLKMMHABOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly DBPCFPGMCBB DIHAKIACPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] HGLCENBMOMB;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x65778E0", Offset = "0x65764E0", VA = "0x1865778E0")]
	public DGCLHCGENNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6577640", Offset = "0x6576240", VA = "0x186577640", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Vector3 GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x65772F0", Offset = "0x6575EF0", VA = "0x1865772F0", Slot = "5")]
	public Vector3 JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class IHJGHAJLJDP : CBFHJMOMLDG<Vector4>, LKLKMMHABOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly DBPCFPGMCBB DIHAKIACPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] HGLCENBMOMB;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x657E7D0", Offset = "0x657D3D0", VA = "0x18657E7D0")]
	public IHJGHAJLJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x657E490", Offset = "0x657D090", VA = "0x18657E490", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Vector4 GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x657E100", Offset = "0x657CD00", VA = "0x18657E100", Slot = "5")]
	public Vector4 JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DPNBLGBCAPG : CBFHJMOMLDG<Quaternion>, LKLKMMHABOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly DBPCFPGMCBB DIHAKIACPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] HGLCENBMOMB;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x65782A0", Offset = "0x6576EA0", VA = "0x1865782A0")]
	public DPNBLGBCAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6577F60", Offset = "0x6576B60", VA = "0x186577F60", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Quaternion GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6577BD0", Offset = "0x65767D0", VA = "0x186577BD0", Slot = "5")]
	public Quaternion JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class LNALBCEGDBK : CBFHJMOMLDG<Color>, LKLKMMHABOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly DBPCFPGMCBB DIHAKIACPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] HGLCENBMOMB;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6581C70", Offset = "0x6580870", VA = "0x186581C70")]
	public LNALBCEGDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6581930", Offset = "0x6580530", VA = "0x186581930", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Color GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x65815A0", Offset = "0x65801A0", VA = "0x1865815A0", Slot = "5")]
	public Color JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OBOELGAKLBL : CBFHJMOMLDG<Bounds>, LKLKMMHABOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly DBPCFPGMCBB DIHAKIACPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] HGLCENBMOMB;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6587FA0", Offset = "0x6586BA0", VA = "0x186587FA0")]
	public OBOELGAKLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6587C80", Offset = "0x6586880", VA = "0x186587C80", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Bounds GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x65878A0", Offset = "0x65864A0", VA = "0x1865878A0", Slot = "5")]
	public Bounds JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class OHJENJAOBEM : CBFHJMOMLDG<Rect>, LKLKMMHABOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly DBPCFPGMCBB DIHAKIACPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] HGLCENBMOMB;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6588A20", Offset = "0x6587620", VA = "0x186588A20")]
	public OHJENJAOBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x65886B0", Offset = "0x65872B0", VA = "0x1865886B0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Rect GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x65882C0", Offset = "0x6586EC0", VA = "0x1865882C0", Slot = "5")]
	public Rect JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class DMELEJEJFCN : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private static class HNPGBNMGECO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3681AF0", Offset = "0x36806F0", VA = "0x183681AF0")]
		static HNPGBNMGECO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private DMELEJEJFCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class EEMODNBMOGM : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private static class IILJAMFJKGL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x373B770", Offset = "0x373A370", VA = "0x18373B770")]
		static IILJAMFJKGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class KCFBMCIHOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> MIDOBFFINNA;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x657EF30", Offset = "0x657DB30", VA = "0x18657EF30")]
		internal static object EPFAOKPIMBK(Type GHKAOLMKPMN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private EEMODNBMOGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class GHMGIFIJGCL : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class HJHEAFCFHHJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3678AF0", Offset = "0x36776F0", VA = "0x183678AF0")]
		static HJHEAFCFHHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GHMGIFIJGCL IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool ILCLFFECDPI;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static LKLKMMHABOC[] HGPAEMINPMB;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static KJHGDFDBIIA[] GCANGOFMGFL;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private GHMGIFIJGCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x657D8F0", Offset = "0x657C4F0", VA = "0x18657D8F0")]
	public static void CFNGGCOIEBP(params KJHGDFDBIIA[] GCANGOFMGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x657D810", Offset = "0x657C410", VA = "0x18657D810")]
	public static void CFNGGCOIEBP(params LKLKMMHABOC[] HGPAEMINPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x657D9D0", Offset = "0x657C5D0", VA = "0x18657D9D0")]
	public static void MIMPMCANFAL(LKLKMMHABOC[] HGPAEMINPMB, KJHGDFDBIIA[] GCANGOFMGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class KGGHKNOMPPM : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private static class NNNBLFBKENB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E6F0", Offset = "0x3D2D2F0", VA = "0x183D2E6F0")]
		static NNNBLFBKENB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private KGGHKNOMPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FOBOKDJNIIE
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly KJHGDFDBIIA IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly KJHGDFDBIIA FDPADNCGFMM;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly KJHGDFDBIIA KMKHKHFHKEJ;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly KJHGDFDBIIA MPPEOLLBHJG;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly KJHGDFDBIIA KGAFEPCJHHC;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly KJHGDFDBIIA OGICHNBDCPG;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly KJHGDFDBIIA KGIFJMEAMEG;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly KJHGDFDBIIA ICNLDJKAADB;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly KJHGDFDBIIA NFMOJCDCJHH;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly KJHGDFDBIIA EKILCHKIDHE;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly KJHGDFDBIIA NLACLMKHGAD;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly KJHGDFDBIIA IJOOCNOEHPE;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class MOBFHDBKOOA
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly KJHGDFDBIIA IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly KJHGDFDBIIA GCOKKHADKNP;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class AJGMGNFEDHP
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly KJHGDFDBIIA IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly KJHGDFDBIIA FDPADNCGFMM;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly KJHGDFDBIIA KMKHKHFHKEJ;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly KJHGDFDBIIA MPPEOLLBHJG;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly KJHGDFDBIIA KGAFEPCJHHC;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly KJHGDFDBIIA OGICHNBDCPG;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly KJHGDFDBIIA KGIFJMEAMEG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly KJHGDFDBIIA ICNLDJKAADB;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly KJHGDFDBIIA NFMOJCDCJHH;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly KJHGDFDBIIA EKILCHKIDHE;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly KJHGDFDBIIA NLACLMKHGAD;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly KJHGDFDBIIA IJOOCNOEHPE;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class MAIGONIJMCD
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> MIDOBFFINNA;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6581F60", Offset = "0x6580B60", VA = "0x186581F60")]
	internal static object EPFAOKPIMBK(Type GHKAOLMKPMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x65836C0", Offset = "0x65822C0", VA = "0x1865836C0")]
	private static object LNHNEFPKDPO(Type BHKBJNLACCP, Type[] KCPLLHCOHHI, params object[] FPHNDOFLJJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class IHNLLCIOHLO : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class BNPEBLAPCGN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x467C2B0", Offset = "0x467AEB0", VA = "0x18467C2B0")]
		static BNPEBLAPCGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> DFOCBCOAJKF;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool PNMMFCJGPFP;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly IAILMNCOOMI PFDHAEKGJDP;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x657EAC0", Offset = "0x657D6C0", VA = "0x18657EAC0")]
	static IHNLLCIOHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private IHNLLCIOHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class PJJJADPLMJI : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class DMLAJFOCJPH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4E4D600", Offset = "0x4E4C200", VA = "0x184E4D600")]
		static DMLAJFOCJPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> DFOCBCOAJKF;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool PNMMFCJGPFP;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly IAILMNCOOMI PFDHAEKGJDP;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6588E80", Offset = "0x6587A80", VA = "0x186588E80")]
	static PJJJADPLMJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private PJJJADPLMJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class HDNEANKPGAB : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class JBMKGGCBLHM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x38E36E0", Offset = "0x38E22E0", VA = "0x1838E36E0")]
		static JBMKGGCBLHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> DFOCBCOAJKF;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool PNMMFCJGPFP;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly IAILMNCOOMI PFDHAEKGJDP;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x657DEF0", Offset = "0x657CAF0", VA = "0x18657DEF0")]
	static HDNEANKPGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private HDNEANKPGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class GPJPNJHNNCD : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class EEBOGKBKCGK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x315C660", Offset = "0x315B260", VA = "0x18315C660")]
		static EEBOGKBKCGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> DFOCBCOAJKF;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool PNMMFCJGPFP;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly IAILMNCOOMI PFDHAEKGJDP;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x657DD80", Offset = "0x657C980", VA = "0x18657DD80")]
	static GPJPNJHNNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private GPJPNJHNNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class OOEEDPMMNNO : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class CDFCEMIPPKO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4964540", Offset = "0x4963140", VA = "0x184964540")]
		static CDFCEMIPPKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> DFOCBCOAJKF;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool PNMMFCJGPFP;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly IAILMNCOOMI PFDHAEKGJDP;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6588D10", Offset = "0x6587910", VA = "0x186588D10")]
	static OOEEDPMMNNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private OOEEDPMMNNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class EMFDINEFKPJ : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class MPALNGMLAOK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF410", Offset = "0x3CBE010", VA = "0x183CBF410")]
		static MPALNGMLAOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> DFOCBCOAJKF;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool PNMMFCJGPFP;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly IAILMNCOOMI PFDHAEKGJDP;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6578610", Offset = "0x6577210", VA = "0x186578610")]
	static EMFDINEFKPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private EMFDINEFKPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class JEPPIKPNCOI : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class CNFMMFBFCJA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4C76D80", Offset = "0x4C75980", VA = "0x184C76D80")]
		static CNFMMFBFCJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> DFOCBCOAJKF;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool PNMMFCJGPFP;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public JEPPIKPNCOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class POOBPFIFHND : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private static class FJKPEAHJACO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x34E71E0", Offset = "0x34E5DE0", VA = "0x1834E71E0")]
		static FJKPEAHJACO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> DFOCBCOAJKF;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool PNMMFCJGPFP;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public POOBPFIFHND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal sealed class IMMKGBJOEPA : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private static class FFLJMKJBIAC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x34DADF0", Offset = "0x34D99F0", VA = "0x1834DADF0")]
		static FFLJMKJBIAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> DFOCBCOAJKF;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool PNMMFCJGPFP;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public IMMKGBJOEPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class PKLAABONMEP : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private static class MCPGBJCPIDI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3C5D4F0", Offset = "0x3C5C0F0", VA = "0x183C5D4F0")]
		static MCPGBJCPIDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> DFOCBCOAJKF;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool PNMMFCJGPFP;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public PKLAABONMEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class IHPHAEBLIGF : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private static class KOBMAOEDLEK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x39C97A0", Offset = "0x39C83A0", VA = "0x1839C97A0")]
		static KOBMAOEDLEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> DFOCBCOAJKF;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool PNMMFCJGPFP;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public IHPHAEBLIGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class LDJHDKGONCN : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private static class ODMMMNIAFNG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3DEAE80", Offset = "0x3DE9A80", VA = "0x183DEAE80")]
		static ODMMMNIAFNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> DFOCBCOAJKF;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool PNMMFCJGPFP;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public LDJHDKGONCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class CALEBCFGLJB
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct EFAMBBPNEAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public OJPEDGNDNFK PNHMBHMLAMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder NCCOIOHLMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder IDFEDJFIEBA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class MOJMKDCJJCD
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class MFMCGFJLPAA
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo KIABIOMJPDD;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo HDENEKIAIBM;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo MJKANOPDBLM;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo LFENGJFDJJF;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo MEGMFEDPGAH;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo LAHHBPDJAMN;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo JHHLHCJHMJB;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo HNJKNADMDPD;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo AJCNIOLKEBL;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x659DFB0", Offset = "0x659CBB0", VA = "0x18659DFB0")]
			static MFMCGFJLPAA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class DKABHGGHJLA
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo LBKAJIHHFFB;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo GGFDEBJPFLB;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo JOLEEFDLEDJ;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo KAAIDAEKABI;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo EEPMHNDJOEJ;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo JNNKHHJPHKJ;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo EEDNNLLAKJG;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x658FA90", Offset = "0x658E690", VA = "0x18658FA90")]
			static DKABHGGHJLA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		internal static class LCFLMAOJKDE
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo LFMPJOJHCKL;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo FNMGDKOBOPF;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo NCOFOGENFBO;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo CCFGAHFNHKB;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo GIJMMOJLEEL;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo OGLGJONEAFL;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo JJHAFLDDBIJ;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo EDDPLNPJJHH;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo NHBDOGMBDHH;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo NDIHICEDDBL;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo EJOMMFAIPHJ;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo KMMEFEAMECG;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo OGNDMICGPDC;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo FOPNJCAFHIH;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6584270", Offset = "0x6582E70", VA = "0x186584270")]
		public static MethodInfo OIIEHDKDHEB(Type OMKEAAPIABA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6583F00", Offset = "0x6582B00", VA = "0x186583F00")]
		public static MethodInfo JFKFFNFOIMD(Type OMKEAAPIABA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6584140", Offset = "0x6582D40", VA = "0x186584140")]
		public static MethodInfo KPIJHJNCEDD(Type OMKEAAPIABA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class JFPOFFHMHBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<OJPEDGNDNFK, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public JFPOFFHMHBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class CNHGDBECLHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public JFPOFFHMHBB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public CNHGDBECLHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x658F0C0", Offset = "0x658DCC0", VA = "0x18658F0C0")]
		internal void JIFNOMPFOFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x658EF60", Offset = "0x658DB60", VA = "0x18658EF60")]
		internal bool EKGFOLCBALK(int index, OJPEDGNDNFK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class EEAOIIGAPKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public JFPOFFHMHBB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public EEAOIIGAPKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6590820", Offset = "0x658F420", VA = "0x186590820")]
		internal bool LBMAFPNKBBI(int index, OJPEDGNDNFK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class OEKNPOLICIN
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
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public OEKNPOLICIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x34EE520", Offset = "0x34ED120", VA = "0x1834EE520")]
		internal string PBMAFKMHBGP(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class NNNMBHKINJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public NNNMBHKINJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x659F3F0", Offset = "0x659DFF0", VA = "0x18659F3F0")]
		internal bool FMEKDKLMOIH(OJPEDGNDNFK x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class PLEJHOCOAMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public OEKNPOLICIN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public PLEJHOCOAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x65A1660", Offset = "0x65A0260", VA = "0x1865A1660")]
		internal void AFGAMGAFMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x65A16E0", Offset = "0x65A02E0", VA = "0x1865A16E0")]
		internal bool BFHDDLBGLJF(int index, OJPEDGNDNFK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class NEJFLHPBDPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public OEKNPOLICIN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public NEJFLHPBDPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x659EDD0", Offset = "0x659D9D0", VA = "0x18659EDD0")]
		internal bool HJDBBJFKDNE(int index, OJPEDGNDNFK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IMJPMOHNECP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public IMJPMOHNECP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6596700", Offset = "0x6595300", VA = "0x186596700")]
		internal Label FNGIKJOPKKI(OJPEDGNDNFK _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class HJAOLOPPNOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public EFAMBBPNEAA[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, OJPEDGNDNFK, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public HKIEBGPOONH argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public HKIEBGPOONH argResolver;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public HJAOLOPPNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6595AF0", Offset = "0x65946F0", VA = "0x186595AF0")]
		internal EFAMBBPNEAA HEDJKBHLBFF(OJPEDGNDNFK item)
		{
			return default(EFAMBBPNEAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class KGLAOCCMHND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public HJAOLOPPNOF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public KGLAOCCMHND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6597850", Offset = "0x6596450", VA = "0x186597850")]
		internal void NAJOHAMNOGN(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x65977B0", Offset = "0x65963B0", VA = "0x1865977B0")]
		internal void KGMFIKHGIKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class DIDCFFAIKKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public OJPEDGNDNFK item;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public DIDCFFAIKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xAF8A40", Offset = "0xAF7640", VA = "0x180AF8A40")]
		internal bool DJIEDJFJPAG(EFAMBBPNEAA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class LIHDGCNKFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public OJPEDGNDNFK item;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public LIHDGCNKFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xAF8A40", Offset = "0xAF7640", VA = "0x180AF8A40")]
		internal bool FKIINNGJLGL(EFAMBBPNEAA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex OGIOFFDLLIF;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int DDCMDIAOKNA;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> EIAOIFEAGJO;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> ONIBKFCJPKO;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2346A70", Offset = "0x2345670", VA = "0x182346A70")]
	public static object PPDENKGCILJ<T>(IAILMNCOOMI PFDHAEKGJDP, KJHGDFDBIIA FFIALCJHOLO, Func<string, string> DFOCBCOAJKF, bool PNMMFCJGPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x233BD70", Offset = "0x233A970", VA = "0x18233BD70")]
	public static object IDMGFBNPHAD<T>(KJHGDFDBIIA FFIALCJHOLO, Func<string, string> DFOCBCOAJKF, bool PNMMFCJGPFP, bool MNGNKGHAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6570CC0", Offset = "0x656F8C0", VA = "0x186570CC0")]
	private static TypeInfo IBDABPHGKJJ(IAILMNCOOMI PFDHAEKGJDP, Type OMKEAAPIABA, Func<string, string> DFOCBCOAJKF, bool PNMMFCJGPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6573AE0", Offset = "0x65726E0", VA = "0x186573AE0")]
	public static object MKBNDGNFNPF(Type OMKEAAPIABA, Func<string, string> DFOCBCOAJKF, bool PNMMFCJGPFP, bool MNGNKGHAFHO, bool BMOKABFEENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6570590", Offset = "0x656F190", VA = "0x186570590")]
	private static Dictionary<OJPEDGNDNFK, FieldInfo> HPCBODDGPKF(TypeBuilder PCDOLPBEMND, BACBDEMNINE CBHMEKBMEOP, ConstructorInfo OLBMKOEFGHO, FieldBuilder KGLKHBIMCMA, ILGenerator CIJLGEAJFCK, bool PNMMFCJGPFP, bool NEOMNCIBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6573400", Offset = "0x6572000", VA = "0x186573400")]
	private static Dictionary<OJPEDGNDNFK, FieldInfo> LHDIAJDOMCF(TypeBuilder PCDOLPBEMND, BACBDEMNINE CBHMEKBMEOP, ILGenerator CIJLGEAJFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6571DC0", Offset = "0x65709C0", VA = "0x186571DC0")]
	private static void JDOIMIPOGIC(Type OMKEAAPIABA, BACBDEMNINE CBHMEKBMEOP, ILGenerator CIJLGEAJFCK, Action MMODDBCDFPF, Func<int, OJPEDGNDNFK, bool> MKNFBICJMGI, bool PNMMFCJGPFP, bool NEOMNCIBBBO, int LMOAGDHPKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6570050", Offset = "0x656EC50", VA = "0x186570050")]
	private static void CLAAAOCBIML(TypeInfo OMKEAAPIABA, OJPEDGNDNFK JFFCKOILPDB, ILGenerator CIJLGEAJFCK, int DCGGFHOCGGH, Func<int, OJPEDGNDNFK, bool> MKNFBICJMGI, HKIEBGPOONH BNGNOICJJGA, HKIEBGPOONH EPGPLFLGEEK, HKIEBGPOONH CAABJLIPFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x656DF90", Offset = "0x656CB90", VA = "0x18656DF90")]
	private static void BJAHEEGOAHE(Type OMKEAAPIABA, BACBDEMNINE CBHMEKBMEOP, ILGenerator CIJLGEAJFCK, Func<int, OJPEDGNDNFK, bool> MKNFBICJMGI, bool OKMNPACJDCD, int LMOAGDHPKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x656DB20", Offset = "0x656C720", VA = "0x18656DB20")]
	private static void ADGAEKFGPHN(ILGenerator CIJLGEAJFCK, EFAMBBPNEAA CBHMEKBMEOP, int DCGGFHOCGGH, Func<int, OJPEDGNDNFK, bool> MKNFBICJMGI, HKIEBGPOONH BIBCAMINPDH, HKIEBGPOONH CAABJLIPFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x656F2C0", Offset = "0x656DEC0", VA = "0x18656F2C0")]
	private static LocalBuilder CDPBKIPCCKP(ILGenerator CIJLGEAJFCK, Type OMKEAAPIABA, BACBDEMNINE CBHMEKBMEOP, EFAMBBPNEAA[] CNMKILGHHHP, bool KONFBLBDFBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x65716E0", Offset = "0x65702E0", VA = "0x1865716E0")]
	private static bool JCKAOMOLKON(ConstructorInfo GCGOFPDFLHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6575610", Offset = "0x6574210", VA = "0x186575610")]
	private static bool OJKDKDPJLCN(Type OMKEAAPIABA, [Out] Type GCDCEIJBJOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate void IBGMKJMHGMN<T>(byte[][] KGLKHBIMCMA, object[] KDFBDBFIACK, CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal delegate T EHIIFJEGNFE<T>(object[] KDFBDBFIACK, EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AJMNHAEOIAA);
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class CMCJGLHDJDD<T> : CBFHJMOMLDG<T>, LKLKMMHABOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] KGLKHBIMCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] EFHHOLOIIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] LMBCFOAMGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly IBGMKJMHGMN<T> NLFMPMEFGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly EHIIFJEGNFE<T> ODOLNNAPCPK;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1CACF90", Offset = "0x1CABB90", VA = "0x181CACF90")]
	public CMCJGLHDJDD(byte[][] KGLKHBIMCMA, object[] EFHHOLOIIEA, object[] LMBCFOAMGLH, IBGMKJMHGMN<T> NLFMPMEFGLH, EHIIFJEGNFE<T> ODOLNNAPCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4C63820", Offset = "0x4C62420", VA = "0x184C63820", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4C63730", Offset = "0x4C62330", VA = "0x184C63730", Slot = "5")]
	public T JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class GIKLJOIHEDD : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private static class CMDMCPHKKJB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4C6C320", Offset = "0x4C6AF20", VA = "0x184C6C320")]
		static CMDMCPHKKJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private GIKLJOIHEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class LBJKAOPEBBL : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private static class GBHBGIFDMCK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x35A1B70", Offset = "0x35A0770", VA = "0x1835A1B70")]
		static GBHBGIFDMCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private LBJKAOPEBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal static class CGMIPAKLDCO
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly KJHGDFDBIIA[] IKIAOMIKBCK;
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class PMMPCPCALJD : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class GKHJLIBFILL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x35CAA00", Offset = "0x35C9600", VA = "0x1835CAA00")]
		static GKHJLIBFILL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class NNOJJKFIIKP : KJHGDFDBIIA
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		private static class PONGIDDCBBP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3EBA2F0", Offset = "0x3EB8EF0", VA = "0x183EBA2F0")]
			static PONGIDDCBBP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly KJHGDFDBIIA IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly KJHGDFDBIIA[] GCANGOFMGFL;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		private NNOJJKFIIKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
		public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly CBFHJMOMLDG<object> MFDCNCCKBND;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private PMMPCPCALJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class ONJPDOPEIMP : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private static class BOCGGAPMFMI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4684450", Offset = "0x4683050", VA = "0x184684450")]
		static BOCGGAPMFMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class CJPMDNCDHCO : KJHGDFDBIIA
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		private static class EGCBIJNAMMK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3164850", Offset = "0x3163450", VA = "0x183164850")]
			static EGCBIJNAMMK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly KJHGDFDBIIA IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly KJHGDFDBIIA[] GCANGOFMGFL;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		private CJPMDNCDHCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
		public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly CBFHJMOMLDG<object> MFDCNCCKBND;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private ONJPDOPEIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class JDGKNJDEHGG : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private static class JNMDLLLFKPE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3923F50", Offset = "0x3922B50", VA = "0x183923F50")]
		static JNMDLLLFKPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class LLDDILHDOOG : KJHGDFDBIIA
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private static class BAPEKNMPGBI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4515D30", Offset = "0x4514930", VA = "0x184515D30")]
			static BAPEKNMPGBI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly KJHGDFDBIIA IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly KJHGDFDBIIA[] GCANGOFMGFL;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		private LLDDILHDOOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
		public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly CBFHJMOMLDG<object> MFDCNCCKBND;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private JDGKNJDEHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal sealed class LGMKELFOICM : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private static class DFBNPJKKBEE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4E36490", Offset = "0x4E35090", VA = "0x184E36490")]
		static DFBNPJKKBEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class EEIFJAHMFJM : KJHGDFDBIIA
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		private static class CAPFKFCAENH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x487FFD0", Offset = "0x487EBD0", VA = "0x18487FFD0")]
			static CAPFKFCAENH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly KJHGDFDBIIA IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly KJHGDFDBIIA[] GCANGOFMGFL;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		private EEIFJAHMFJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
		public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly CBFHJMOMLDG<object> MFDCNCCKBND;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private LGMKELFOICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class BBICFNHIJEK : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private static class OHPHMPJHFEA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF580", Offset = "0x3DFE180", VA = "0x183DFF580")]
		static OHPHMPJHFEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class AFHHMEJAJMO : KJHGDFDBIIA
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		private static class GMKIDNODFNO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x35D77B0", Offset = "0x35D63B0", VA = "0x1835D77B0")]
			static GMKIDNODFNO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly KJHGDFDBIIA IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly KJHGDFDBIIA[] GCANGOFMGFL;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		private AFHHMEJAJMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
		public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly CBFHJMOMLDG<object> MFDCNCCKBND;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private BBICFNHIJEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class EFBHOGMNCGA : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private static class HCKJOENIKAB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x36235B0", Offset = "0x36221B0", VA = "0x1836235B0")]
		static HCKJOENIKAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private sealed class MEDAKKNFLHL : KJHGDFDBIIA
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		private static class POEFEGCNJIG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3EB7550", Offset = "0x3EB6150", VA = "0x183EB7550")]
			static POEFEGCNJIG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly KJHGDFDBIIA IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly KJHGDFDBIIA[] GCANGOFMGFL;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		private MEDAKKNFLHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
		public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly CBFHJMOMLDG<object> MFDCNCCKBND;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private EFBHOGMNCGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal sealed class MCLOHMAKOFO : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private static class JHAJFEFLPGH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x38EF0B0", Offset = "0x38EDCB0", VA = "0x1838EF0B0")]
		static JHAJFEFLPGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private sealed class ACIDCHDENFL : KJHGDFDBIIA
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		private static class IFDBOOAAHJA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3716890", Offset = "0x3715490", VA = "0x183716890")]
			static IFDBOOAAHJA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly KJHGDFDBIIA IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly KJHGDFDBIIA[] GCANGOFMGFL;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		private ACIDCHDENFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
		public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly CBFHJMOMLDG<object> MFDCNCCKBND;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private MCLOHMAKOFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal sealed class KFCDFIBCMNE : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private static class OHDAIAMKMPK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3DF0FD0", Offset = "0x3DEFBD0", VA = "0x183DF0FD0")]
		static OHDAIAMKMPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private sealed class FEFNJKANGKN : KJHGDFDBIIA
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private static class LAPCPCKMFBD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3A28EB0", Offset = "0x3A27AB0", VA = "0x183A28EB0")]
			static LAPCPCKMFBD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly KJHGDFDBIIA IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly KJHGDFDBIIA[] GCANGOFMGFL;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		private FEFNJKANGKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
		public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly CBFHJMOMLDG<object> MFDCNCCKBND;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private KFCDFIBCMNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal sealed class PAOIJADHLJE : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private static class KBAFMNBBBDH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x39669F0", Offset = "0x39655F0", VA = "0x1839669F0")]
		static KBAFMNBBBDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private sealed class EHJOOHAAPBB : KJHGDFDBIIA
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		private static class NEFKAEMJMAM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3D01FF0", Offset = "0x3D00BF0", VA = "0x183D01FF0")]
			static NEFKAEMJMAM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly KJHGDFDBIIA IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly KJHGDFDBIIA[] GCANGOFMGFL;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		private EHJOOHAAPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
		public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly CBFHJMOMLDG<object> MFDCNCCKBND;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private PAOIJADHLJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal sealed class LBFEMHHIFCI : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private static class FFJINPMHECM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x34D4E50", Offset = "0x34D3A50", VA = "0x1834D4E50")]
		static FFJINPMHECM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private sealed class AFFIPJLFJGK : KJHGDFDBIIA
	{
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		private static class INJKKMEMMAJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x374B440", Offset = "0x374A040", VA = "0x18374B440")]
			static INJKKMEMMAJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly KJHGDFDBIIA IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly KJHGDFDBIIA[] GCANGOFMGFL;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		private AFFIPJLFJGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
		public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly CBFHJMOMLDG<object> MFDCNCCKBND;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private LBFEMHHIFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal sealed class HHNDDNKDBML : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private static class HGHEOGELNKO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3661F60", Offset = "0x3660B60", VA = "0x183661F60")]
		static HGHEOGELNKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private sealed class DMINHKFFEOC : KJHGDFDBIIA
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		private static class EOIMMKOFEKH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x318DA50", Offset = "0x318C650", VA = "0x18318DA50")]
			static EOIMMKOFEKH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly KJHGDFDBIIA IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly KJHGDFDBIIA[] GCANGOFMGFL;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		private DMINHKFFEOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
		public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly CBFHJMOMLDG<object> MFDCNCCKBND;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private HHNDDNKDBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
internal sealed class MCALLBDMIJD : KJHGDFDBIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private static class BGDKMOFFHHH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x459A7D0", Offset = "0x45993D0", VA = "0x18459A7D0")]
		static BGDKMOFFHHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private sealed class OPGGDLJJCGH : KJHGDFDBIIA
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		private static class GGLHJLGDDNE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly CBFHJMOMLDG<T> FINDNBBPFAE;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x35B7DD0", Offset = "0x35B69D0", VA = "0x1835B7DD0")]
			static GGLHJLGDDNE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly KJHGDFDBIIA IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly KJHGDFDBIIA[] GCANGOFMGFL;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		private OPGGDLJJCGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
		public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly KJHGDFDBIIA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly CBFHJMOMLDG<object> MFDCNCCKBND;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private MCALLBDMIJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	public CBFHJMOMLDG<T> EPFAOKPIMBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct FPOLAPAFDEF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] MLCGDMGJBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int JKLDCECNLBC;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x34F8940", Offset = "0x34F7540", VA = "0x1834F8940")]
	public FPOLAPAFDEF(int NHAAFBFJNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x34F8550", Offset = "0x34F7150", VA = "0x1834F8550")]
	public void HFMDKEOMMOI(T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x34F88B0", Offset = "0x34F74B0", VA = "0x1834F88B0")]
	public T[] MAECBACENDF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal sealed class OGDBCFAJNEL : PAMNCHCIGOJ<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly OGDBCFAJNEL IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x659F6C0", Offset = "0x659E2C0", VA = "0x18659F6C0")]
	public OGDBCFAJNEL(int ILFCGMMCBAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class PAMNCHCIGOJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int ILFCGMMCBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object CEAAGAMMOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int DCGGFHOCGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] ACEOFMDOMGD;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3E8FD80", Offset = "0x3E8E980", VA = "0x183E8FD80")]
	public PAMNCHCIGOJ(int ILFCGMMCBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3E8F780", Offset = "0x3E8E380", VA = "0x183E8F780")]
	public T[] PFNNLOPLCEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3E8EA00", Offset = "0x3E8D600", VA = "0x183E8EA00")]
	public void NCILIBKFAIL(T[] DAJPKFPFPMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class DBPCFPGMCBB : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private class GDBFJGMMBPH : IComparable<GDBFJGMMBPH>
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class MBJJKAFPCEP : IEnumerable<GDBFJGMMBPH>, IEnumerable, IEnumerator<GDBFJGMMBPH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private GDBFJGMMBPH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public GDBFJGMMBPH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private GDBFJGMMBPH System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8ECE30", Offset = "0x8EBA30", VA = "0x1808ECE30")]
			[DebuggerHidden]
			public MBJJKAFPCEP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x659D960", Offset = "0x659C560", VA = "0x18659D960", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x659DA90", Offset = "0x659C690", VA = "0x18659DA90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x659D9E0", Offset = "0x659C5E0", VA = "0x18659D9E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GDBFJGMMBPH> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x659D9E0", Offset = "0x659C5E0", VA = "0x18659D9E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class KCIIGJLLFOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public KCIIGJLLFOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x6596700", Offset = "0x6595300", VA = "0x186596700")]
			internal Label JICNOGLKKCO(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x6596700", Offset = "0x6595300", VA = "0x186596700")]
			internal Label PLALEGBPOAH(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly GDBFJGMMBPH[] LDIHPPLNKCN;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] AOMELBMEHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong PLLFMAPAGEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int GMFAJOGMKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string CIOFGNKOFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private GDBFJGMMBPH[] PPPJJGENAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] PBLIEIMGJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int EMHEDPDPEMP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HFKHJMFCHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x50BF110", Offset = "0x50BDD10", VA = "0x1850BF110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x65951F0", Offset = "0x6593DF0", VA = "0x1865951F0")]
		public GDBFJGMMBPH(ulong PPNDANAOAMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x65949B0", Offset = "0x65935B0", VA = "0x1865949B0")]
		public GDBFJGMMBPH HFMDKEOMMOI(ulong PPNDANAOAMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6594950", Offset = "0x6593550", VA = "0x186594950")]
		public GDBFJGMMBPH HFMDKEOMMOI(ulong PPNDANAOAMK, int GCPEEAODAIB, string CIOFGNKOFAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6594F30", Offset = "0x6593B30", VA = "0x186594F30")]
		public GDBFJGMMBPH IIFJINOBLOM(byte[] BPDGEJEAOAF, int IAKOFEGDGBF, int MMANDKLIFNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x65950B0", Offset = "0x6593CB0", VA = "0x1865950B0")]
		internal static int JMABOINPAMF(ulong[] DAJPKFPFPMI, int DCGGFHOCGGH, int NBJKCBMEDIG, ulong GCPEEAODAIB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x65948A0", Offset = "0x65934A0", VA = "0x1865948A0", Slot = "4")]
		public int CompareTo(GDBFJGMMBPH LLMHBOEDHFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x65948D0", Offset = "0x65934D0", VA = "0x1865948D0")]
		[IteratorStateMachine(typeof(MBJJKAFPCEP))]
		public IEnumerable<GDBFJGMMBPH> FJKGAHOCIGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6594BB0", Offset = "0x65937B0", VA = "0x186594BB0")]
		public void IAOAEPOEFCJ(ILGenerator CIJLGEAJFCK, LocalBuilder BPDGEJEAOAF, LocalBuilder MMANDKLIFNJ, LocalBuilder PPNDANAOAMK, Action<KeyValuePair<string, int>> DGELMPACJHJ, Action NIHAMLFOEDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6593BC0", Offset = "0x65927C0", VA = "0x186593BC0")]
		private static void BJMFKCHEOBA(ILGenerator CIJLGEAJFCK, LocalBuilder BPDGEJEAOAF, LocalBuilder MMANDKLIFNJ, LocalBuilder PPNDANAOAMK, Action<KeyValuePair<string, int>> DGELMPACJHJ, Action NIHAMLFOEDA, GDBFJGMMBPH[] PPPJJGENAHM, int EMHEDPDPEMP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class JLCLCEMHOGK : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<GDBFJGMMBPH> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<GDBFJGMMBPH> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<GDBFJGMMBPH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private GDBFJGMMBPH <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x9FCA30", Offset = "0x9FB630", VA = "0x1809FCA30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x65972E0", Offset = "0x6595EE0", VA = "0x1865972E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1BCCF70", Offset = "0x1BCBB70", VA = "0x181BCCF70")]
		[DebuggerHidden]
		public JLCLCEMHOGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6597330", Offset = "0x6595F30", VA = "0x186597330", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6596D80", Offset = "0x6595980", VA = "0x186596D80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6596D30", Offset = "0x6595930", VA = "0x186596D30")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6596CE0", Offset = "0x65958E0", VA = "0x186596CE0")]
		private void HAIPFOFCHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6597290", Offset = "0x6595E90", VA = "0x186597290", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x65971E0", Offset = "0x6595DE0", VA = "0x1865971E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x65971E0", Offset = "0x6595DE0", VA = "0x1865971E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly GDBFJGMMBPH NMHGPHBIAIB;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x658F830", Offset = "0x658E430", VA = "0x18658F830")]
	public DBPCFPGMCBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x658F330", Offset = "0x658DF30", VA = "0x18658F330")]
	public void HFMDKEOMMOI(byte[] FEGEJBFJFNG, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x658F1F0", Offset = "0x658DDF0", VA = "0x18658F1F0")]
	public bool CDAHGONAKGK(ArraySegment<byte> PPNDANAOAMK, [Out] int GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x658F7A0", Offset = "0x658E3A0", VA = "0x18658F7A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x658F4C0", Offset = "0x658E0C0", VA = "0x18658F4C0")]
	private static void OKNPEODPFKJ(IEnumerable<GDBFJGMMBPH> PPPJJGENAHM, StringBuilder OEJAOEGGCBJ, int OLLFIMGHMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x658F2D0", Offset = "0x658DED0", VA = "0x18658F2D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x658F2D0", Offset = "0x658DED0", VA = "0x18658F2D0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x658F440", Offset = "0x658E040", VA = "0x18658F440")]
	[IteratorStateMachine(typeof(JLCLCEMHOGK))]
	private static IEnumerable<KeyValuePair<string, int>> JODHHNHKMDH(IEnumerable<GDBFJGMMBPH> PPPJJGENAHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x658F1C0", Offset = "0x658DDC0", VA = "0x18658F1C0")]
	public void AGLBABKCMNP(ILGenerator CIJLGEAJFCK, LocalBuilder BPDGEJEAOAF, LocalBuilder MMANDKLIFNJ, LocalBuilder PPNDANAOAMK, Action<KeyValuePair<string, int>> DGELMPACJHJ, Action NIHAMLFOEDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class EEDFNECLJOP
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo KMMJCENDHKB;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6590980", Offset = "0x658F580", VA = "0x186590980")]
	public static ulong NKMDABFJLJD(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, int MMANDKLIFNJ)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class EIILKMGJDGG
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6591BF0", Offset = "0x65907F0", VA = "0x186591BF0")]
	public static void GFMENOKGFNH(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, int LKLPIFOHKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6591D30", Offset = "0x6590930", VA = "0x186591D30")]
	public static void JGGONMKDLCC(byte[] DAJPKFPFPMI, int ACOMFCEADLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6591AC0", Offset = "0x65906C0", VA = "0x186591AC0")]
	public static byte[] DFMGGPLLPJK(byte[] PFJBHGAEIJN, int ACOMFCEADLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class MNGBCDHBONE
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x659ED60", Offset = "0x659D960", VA = "0x18659ED60")]
	public static bool JCDHIGJPIOL(byte[] EFADMIFPKBF, int KNODMNKMKNF, int HGFHOEJOCAC, byte[] LBMKFHEHNGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal class MDICILNLKFG<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private struct NGIOFFKGMHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] PLLFMAPAGEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T GMFAJOGMKIF;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3D18110", Offset = "0x3D16D10", VA = "0x183D18110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class DCFCCIBMOJH : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public MDICILNLKFG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private NGIOFFKGMHE[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private NGIOFFKGMHE[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x9FCA30", Offset = "0x9FB630", VA = "0x1809FCA30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x346F530", Offset = "0x346E130", VA = "0x18346F530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public DCFCCIBMOJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x4DE8DE0", Offset = "0x4DE79E0", VA = "0x184DE8DE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4DEAC40", Offset = "0x4DE9840", VA = "0x184DEAC40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly NGIOFFKGMHE[][] KIFMPIJJEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong EJNPLHIOCHP;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3C64EC0", Offset = "0x3C63AC0", VA = "0x183C64EC0")]
	public MDICILNLKFG(int AAAINGBCLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3C64EE0", Offset = "0x3C63AE0", VA = "0x183C64EE0")]
	public MDICILNLKFG(int AAAINGBCLDC, float BBNAKLMGKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3C612A0", Offset = "0x3C5FEA0", VA = "0x183C612A0")]
	public void HFMDKEOMMOI(byte[] PPNDANAOAMK, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3C63350", Offset = "0x3C61F50", VA = "0x183C63350")]
	private bool NDOCBLGBBOJ(byte[] PPNDANAOAMK, T GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3C61CE0", Offset = "0x3C608E0", VA = "0x183C61CE0")]
	public bool IKGDLKABABA(ArraySegment<byte> PPNDANAOAMK, [Out] T GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3C60B30", Offset = "0x3C5F730", VA = "0x183C60B30")]
	private static ulong DNAEGAPNPND(byte[] HPIMCNPJDMN, int IAKOFEGDGBF, int EMHEDPDPEMP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3C61630", Offset = "0x3C60230", VA = "0x183C61630")]
	private static int HGEMHMOACFA(int CFINNPKIAEO, float BBNAKLMGKED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3C60B80", Offset = "0x3C5F780", VA = "0x183C60B80", Slot = "4")]
	[IteratorStateMachine(typeof(MDICILNLKFG<>.DCFCCIBMOJH))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3309830", Offset = "0x3308430", VA = "0x183309830", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class NMMCAEGHKGC : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] KKPDNIJPDDA;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] AEBDDIBPGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int MHEMINDBLIN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DFJPJMHCBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x659F0B0", Offset = "0x659DCB0", VA = "0x18659F0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x659F100", Offset = "0x659DD00", VA = "0x18659F100")]
	static NMMCAEGHKGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x659F360", Offset = "0x659DF60", VA = "0x18659F360")]
	public NMMCAEGHKGC(byte[] MNOJJLEFBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x659EFB0", Offset = "0x659DBB0", VA = "0x18659EFB0")]
	public OpCode GIEAJHHGFMD()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct LKPIFAHCLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid GMFAJOGMKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte GIABJNJHDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte HCFMFIBOLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte JHCNNEBCPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte MEKNCPCIAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte BHKGMIENMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte KIHJEBJDFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte HPKCCPLNJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte GLGCNJGFAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte IEKACONHAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte CPCHBAKNIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte PHCPGLMCOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte PKMKOHFENBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte CJMIFGLBDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte PLAOHLNODFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte BCKFKFOOGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte PNIOGHGPHGP;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] OGFGDOHIGLB;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] ICOJLOMFKFF;

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x659BD10", Offset = "0x659A910", VA = "0x18659BD10")]
	public LKPIFAHCLGH(Guid GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x659BD20", Offset = "0x659A920", VA = "0x18659BD20")]
	public LKPIFAHCLGH(ArraySegment<byte> BOPNEGGLGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x659AED0", Offset = "0x6599AD0", VA = "0x18659AED0")]
	private static byte EJCEEDCGPOP(byte[] FEGEJBFJFNG, int BBHFDDNOAOO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x659ADB0", Offset = "0x65999B0", VA = "0x18659ADB0")]
	private static byte EDHPHENLJKK(byte KNDAEONALIC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x659AF70", Offset = "0x6599B70", VA = "0x18659AF70")]
	public void ENIJDOPIDEK(byte[] NJCBLCELFEN, int IAKOFEGDGBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class BAEOCKHGMGB
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x658B5E0", Offset = "0x658A1E0", VA = "0x18658B5E0")]
	public static bool AGJKKDILJAH(byte KIHBPBFELGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x658B570", Offset = "0x658A170", VA = "0x18658B570")]
	public static bool ACCJCLJAADJ(byte KIHBPBFELGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x658BD90", Offset = "0x658A990", VA = "0x18658BD90")]
	public static sbyte CHMJCBCDPPL(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x658BFD0", Offset = "0x658ABD0", VA = "0x18658BFD0")]
	public static short HCDIJGBANMG(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x658CB90", Offset = "0x658B790", VA = "0x18658CB90")]
	public static int MLJMMPOIAEI(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x658CEB0", Offset = "0x658BAB0", VA = "0x18658CEB0")]
	public static long PDFAPFMJCNA(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x658BEE0", Offset = "0x658AAE0", VA = "0x18658BEE0")]
	public static byte EGMGFOCJNCK(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x658B5F0", Offset = "0x658A1F0", VA = "0x18658B5F0")]
	public static ushort BMOMAHHBDPF(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x658B670", Offset = "0x658A270", VA = "0x18658B670")]
	public static uint CFIPKEMCFJB(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x658CA80", Offset = "0x658B680", VA = "0x18658CA80")]
	public static ulong MIBHGPJPIOM(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x658BF60", Offset = "0x658AB60", VA = "0x18658BF60")]
	public static float FMEHOAGPDNL(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x658BE70", Offset = "0x658AA70", VA = "0x18658BE70")]
	public static double DJBBLBLLGLM(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x658B6F0", Offset = "0x658A2F0", VA = "0x18658B6F0")]
	public static int CHGOFFFENEB(byte[] NJCBLCELFEN, int IAKOFEGDGBF, ulong GCPEEAODAIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x658C0C0", Offset = "0x658ACC0", VA = "0x18658C0C0")]
	public static int JNMHPCEDPEB(byte[] NJCBLCELFEN, int IAKOFEGDGBF, long GCPEEAODAIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x658CC80", Offset = "0x658B880", VA = "0x18658CC80")]
	public static bool NKEBNJGIMGJ(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class JCNDDLEGIJL
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class LKGEOIIPDDA : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8ECE30", Offset = "0x8EBA30", VA = "0x1808ECE30")]
		[DebuggerHidden]
		public LKGEOIIPDDA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x659AC80", Offset = "0x6599880", VA = "0x18659AC80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x659A740", Offset = "0x6599340", VA = "0x18659A740", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x659A6F0", Offset = "0x65992F0", VA = "0x18659A6F0")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x659A6A0", Offset = "0x65992A0", VA = "0x18659A6A0")]
		private void HAIPFOFCHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x659AC30", Offset = "0x6599830", VA = "0x18659AC30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x659AB70", Offset = "0x6599770", VA = "0x18659AB70", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x659AB70", Offset = "0x6599770", VA = "0x18659AB70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class IIFPICGBDJN : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8ECE30", Offset = "0x8EBA30", VA = "0x1808ECE30")]
		[DebuggerHidden]
		public IIFPICGBDJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x65965D0", Offset = "0x65951D0", VA = "0x1865965D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6596090", Offset = "0x6594C90", VA = "0x186596090", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6596040", Offset = "0x6594C40", VA = "0x186596040")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6595FF0", Offset = "0x6594BF0", VA = "0x186595FF0")]
		private void HAIPFOFCHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6596580", Offset = "0x6595180", VA = "0x186596580", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x65964C0", Offset = "0x65950C0", VA = "0x1865964C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x65964C0", Offset = "0x65950C0", VA = "0x1865964C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6596860", Offset = "0x6595460", VA = "0x186596860")]
	public static bool CDJKBPEBIBM(this TypeInfo OMKEAAPIABA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6596730", Offset = "0x6595330", VA = "0x186596730")]
	public static bool AFNPFJEFNIN(this TypeInfo OMKEAAPIABA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x65969C0", Offset = "0x65955C0", VA = "0x1865969C0")]
	public static IEnumerable<PropertyInfo> LALHGAJNKGC(this Type OMKEAAPIABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6596AC0", Offset = "0x65956C0", VA = "0x186596AC0")]
	[IteratorStateMachine(typeof(LKGEOIIPDDA))]
	private static IEnumerable<PropertyInfo> POBLBEPCFPH(Type OMKEAAPIABA, HashSet<string> PLIKKAICJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6596A40", Offset = "0x6595640", VA = "0x186596A40")]
	public static IEnumerable<FieldInfo> PKPMDMFAJMA(this Type OMKEAAPIABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6596920", Offset = "0x6595520", VA = "0x186596920")]
	[IteratorStateMachine(typeof(IIFPICGBDJN))]
	private static IEnumerable<FieldInfo> GBGDPKNGLGK(Type OMKEAAPIABA, HashSet<string> PLIKKAICJHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class OHGBIKGNLGB
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding OFPCBFOGLNL;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal static class KOINMFHPEAP
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
	public static string NLGAIHJMDPE(string HJMPOPKEFMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6597B00", Offset = "0x6596700", VA = "0x186597B00")]
	public static string BPKBEBGADMK(string HJMPOPKEFMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6597BE0", Offset = "0x65967E0", VA = "0x186597BE0")]
	public static string CBIEBNNDLPG(string HJMPOPKEFMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class PDIEOAAENMF<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class HGAEIJPKAFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type PLLFMAPAGEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue GMFAJOGMKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int NBNNJNDDAKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public HGAEIJPKAFB ENPKBKCAFHC;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x365F680", Offset = "0x365E280", VA = "0x18365F680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x365F640", Offset = "0x365E240", VA = "0x18365F640")]
		private int CMJPMBPLDNP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public HGAEIJPKAFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class AKFBFOBLOED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public AKFBFOBLOED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xB2A490", Offset = "0xB29090", VA = "0x180B2A490")]
		internal TValue DJLKPGBADLP(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private HGAEIJPKAFB[] KIFMPIJJEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int JIGGJNDJAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object EDMNHPADOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float BBNAKLMGKED;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3E96560", Offset = "0x3E95160", VA = "0x183E96560")]
	public PDIEOAAENMF(int AAAINGBCLDC = 4, float BBNAKLMGKED = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x3E961D0", Offset = "0x3E94DD0", VA = "0x183E961D0")]
	public bool NHIIPPMFJOI(Type PPNDANAOAMK, TValue GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3E96010", Offset = "0x3E94C10", VA = "0x183E96010")]
	public bool NHIIPPMFJOI(Type PPNDANAOAMK, Func<Type, TValue> PJMJEBGCGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3E95CB0", Offset = "0x3E948B0", VA = "0x183E95CB0")]
	private bool NDOCBLGBBOJ(Type PPNDANAOAMK, Func<Type, TValue> PJMJEBGCGIO, [Out] TValue BCDEMFADCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3E95560", Offset = "0x3E94160", VA = "0x183E95560")]
	private bool KFJOHNFMMDD(HGAEIJPKAFB[] KIFMPIJJEKI, Type BNFDIGODPHF, HGAEIJPKAFB HDKLMAKMEJF, Func<Type, TValue> PJMJEBGCGIO, [Out] TValue BCDEMFADCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3E94F30", Offset = "0x3E93B30", VA = "0x183E94F30")]
	public bool IKGDLKABABA(Type PPNDANAOAMK, [Out] TValue GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3E96300", Offset = "0x3E94F00", VA = "0x183E96300")]
	public TValue OCMJLJAHBBI(Type PPNDANAOAMK, Func<Type, TValue> PJMJEBGCGIO)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3C61630", Offset = "0x3C60230", VA = "0x183C61630")]
	private static int HGEMHMOACFA(int CFINNPKIAEO, float BBNAKLMGKED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3E94F00", Offset = "0x3E93B00", VA = "0x183E94F00")]
	private static void ENNNBICJBMH(HGAEIJPKAFB KDCJKAGAHDO, HGAEIJPKAFB GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3E94F00", Offset = "0x3E93B00", VA = "0x183E94F00")]
	private static void ENNNBICJBMH(HGAEIJPKAFB[] KDCJKAGAHDO, HGAEIJPKAFB[] GCPEEAODAIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class IAILMNCOOMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder HOKNLMMFKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder BDJJFBDMBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object CEAAGAMMOHE;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6595DE0", Offset = "0x65949E0", VA = "0x186595DE0")]
	public TypeBuilder GJJIGEFDAOE(string JEICAPDKHKI, TypeAttributes MKAPNPOMLOJ, Type HHNAEDAPOHF, Type[] BKNMBKEIPOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6595EE0", Offset = "0x6594AE0", VA = "0x186595EE0")]
	public IAILMNCOOMI(string HKCHPMIIBOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal static class PDKECDHDGCG
{
	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x65A1580", Offset = "0x65A0180", VA = "0x1865A1580")]
	private static MethodInfo NEEBJJCINED(LambdaExpression CKFDOHHAKMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2661480", Offset = "0x2660080", VA = "0x182661480")]
	public static MethodInfo DDPJNFMKOID<T>(Expression<Func<T>> CKFDOHHAKMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2661480", Offset = "0x2660080", VA = "0x182661480")]
	public static MethodInfo DDPJNFMKOID<T, TR>(Expression<Func<T, TR>> CKFDOHHAKMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2661480", Offset = "0x2660080", VA = "0x182661480")]
	public static MethodInfo DDPJNFMKOID<T>(Expression<Action<T>> CKFDOHHAKMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2661480", Offset = "0x2660080", VA = "0x182661480")]
	public static MethodInfo DDPJNFMKOID<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> CKFDOHHAKMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x26613A0", Offset = "0x265FFA0", VA = "0x1826613A0")]
	private static MemberInfo DCFBGPJBOFN<T>(Expression<T> NOOIIGLDGHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2661490", Offset = "0x2660090", VA = "0x182661490")]
	public static PropertyInfo KHJKNMIGPBA<T, TR>(Expression<Func<T, TR>> CKFDOHHAKMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal struct HKIEBGPOONH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int JBCJBAEMMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool ODKFNMHPCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator CIJLGEAJFCK;

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6595D10", Offset = "0x6594910", VA = "0x186595D10")]
	public HKIEBGPOONH(ILGenerator CIJLGEAJFCK, int JBCJBAEMMMK, bool ODKFNMHPCBB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6595D50", Offset = "0x6594950", VA = "0x186595D50")]
	public HKIEBGPOONH(ILGenerator CIJLGEAJFCK, int JBCJBAEMMMK, Type OMKEAAPIABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6595C10", Offset = "0x6594810", VA = "0x186595C10")]
	public void DHDMEIMEDIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class BFGEAKCJNGM
{
	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x658D5B0", Offset = "0x658C1B0", VA = "0x18658D5B0")]
	public static void BCNAMIHNHIJ(this ILGenerator CIJLGEAJFCK, int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x658D570", Offset = "0x658C170", VA = "0x18658D570")]
	public static void BCNAMIHNHIJ(this ILGenerator CIJLGEAJFCK, LocalBuilder AOMJFNFAOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x658D340", Offset = "0x658BF40", VA = "0x18658D340")]
	public static void AJONACAEDKJ(this ILGenerator CIJLGEAJFCK, int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x658D530", Offset = "0x658C130", VA = "0x18658D530")]
	public static void AJONACAEDKJ(this ILGenerator CIJLGEAJFCK, LocalBuilder AOMJFNFAOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x658D160", Offset = "0x658BD60", VA = "0x18658D160")]
	public static void AJGCFLFEOLK(this ILGenerator CIJLGEAJFCK, int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x658D240", Offset = "0x658BE40", VA = "0x18658D240")]
	public static void AJGCFLFEOLK(this ILGenerator CIJLGEAJFCK, LocalBuilder AOMJFNFAOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x658DAB0", Offset = "0x658C6B0", VA = "0x18658DAB0")]
	public static void HHJHDKMKFMB(this ILGenerator CIJLGEAJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x658DA00", Offset = "0x658C600", VA = "0x18658DA00")]
	public static void FCKFPMLNDHI(this ILGenerator CIJLGEAJFCK, bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x658DE10", Offset = "0x658CA10", VA = "0x18658DE10")]
	public static void NONGBOOLLNJ(this ILGenerator CIJLGEAJFCK, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x658D7A0", Offset = "0x658C3A0", VA = "0x18658D7A0")]
	public static void BEJAFLFHBHN(this ILGenerator CIJLGEAJFCK, Type OMKEAAPIABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x658DA10", Offset = "0x658C610", VA = "0x18658DA10")]
	public static void GDAGBFBGIME(this ILGenerator CIJLGEAJFCK, Type OMKEAAPIABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x658DAC0", Offset = "0x658C6C0", VA = "0x18658DAC0")]
	public static void KAGAIMHCIAE(this ILGenerator CIJLGEAJFCK, int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x658DD90", Offset = "0x658C990", VA = "0x18658DD90")]
	public static void KLMPGNFOJEP(this ILGenerator CIJLGEAJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x658DCB0", Offset = "0x658C8B0", VA = "0x18658DCB0")]
	public static void KDDFADMEGBH(this ILGenerator CIJLGEAJFCK, int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x658D880", Offset = "0x658C480", VA = "0x18658D880")]
	public static void BELJOFDBAHP(this ILGenerator CIJLGEAJFCK, MethodInfo AEELPNCBMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x658D970", Offset = "0x658C570", VA = "0x18658D970")]
	public static void DJKHPOIDLGB(this ILGenerator CIJLGEAJFCK, FieldInfo ILOIILFNHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x658D0D0", Offset = "0x658BCD0", VA = "0x18658D0D0")]
	public static void ABFOPOOAAOL(this ILGenerator CIJLGEAJFCK, ulong GCPEEAODAIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class OJPEDGNDNFK
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class JPLNBECINJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public JPLNBECINJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6597480", Offset = "0x6596080", VA = "0x186597480")]
		internal bool NLEFEEICDBG(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo KNKPIHNFCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo BNAMFAGPGOF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string ODBDFCEODFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string FDCMHFFJOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7733F0", Offset = "0x771FF0", VA = "0x1807733F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool PGPGFJIADEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x659F920", Offset = "0x659E520", VA = "0x18659F920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool GILKJJLLDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x776670", Offset = "0x775270", VA = "0x180776670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x776720", Offset = "0x775320", VA = "0x180776720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool MKFKDHINNNK
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8838A0", Offset = "0x8824A0", VA = "0x1808838A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x883460", Offset = "0x882060", VA = "0x180883460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type IBCFEMEEMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x773600", Offset = "0x772200", VA = "0x180773600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x773820", Offset = "0x772420", VA = "0x180773820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo GHFHOHODMLM
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x77D0D0", Offset = "0x77BCD0", VA = "0x18077D0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo KGEAAGJELIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x773610", Offset = "0x772210", VA = "0x180773610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x776700", Offset = "0x775300", VA = "0x180776700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo JEDNKNCEDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x773440", Offset = "0x772040", VA = "0x180773440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7733D0", Offset = "0x771FD0", VA = "0x1807733D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x659FC20", Offset = "0x659E820", VA = "0x18659FC20")]
	protected OJPEDGNDNFK(Type OMKEAAPIABA, string JEICAPDKHKI, string CKDECAPDPIB, bool IJNIGDGMCLN, bool CHCNJHHPEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x659FCA0", Offset = "0x659E8A0", VA = "0x18659FCA0")]
	public OJPEDGNDNFK(FieldInfo CBHMEKBMEOP, string JEICAPDKHKI, bool MNGNKGHAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x659FDB0", Offset = "0x659E9B0", VA = "0x18659FDB0")]
	public OJPEDGNDNFK(PropertyInfo CBHMEKBMEOP, string JEICAPDKHKI, bool MNGNKGHAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x659FAB0", Offset = "0x659E6B0", VA = "0x18659FAB0")]
	private static MethodInfo PFKPAFEAEGI(MemberInfo CBHMEKBMEOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2647370", Offset = "0x2645F70", VA = "0x182647370")]
	public T KMLLJHHKNNF<T>(bool AKNKFCIKJLK) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x659F930", Offset = "0x659E530", VA = "0x18659F930", Slot = "4")]
	public virtual void HLMCGMABGFI(ILGenerator CIJLGEAJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x659F7A0", Offset = "0x659E3A0", VA = "0x18659F7A0", Slot = "5")]
	public virtual void CNHNBCDJONK(ILGenerator CIJLGEAJFCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class ADEAJAHEIAP : OJPEDGNDNFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string BDNEHJHLIAG;

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6589B50", Offset = "0x6588750", VA = "0x186589B50")]
	public ADEAJAHEIAP(string JEICAPDKHKI, string BDNEHJHLIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6589AA0", Offset = "0x65886A0", VA = "0x186589AA0", Slot = "4")]
	public override void HLMCGMABGFI(ILGenerator CIJLGEAJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6589A50", Offset = "0x6588650", VA = "0x186589A50", Slot = "5")]
	public override void CNHNBCDJONK(ILGenerator CIJLGEAJFCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class CKEGCLJNLMC : OJPEDGNDNFK
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo FCANLLBLLOG;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo EEEHJMHKAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal HKIEBGPOONH HGJKIMMJPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal HKIEBGPOONH EPGPLFLGEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal HKIEBGPOONH CAABJLIPFNA;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x658EEA0", Offset = "0x658DAA0", VA = "0x18658EEA0")]
	public CKEGCLJNLMC(string JEICAPDKHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x658E710", Offset = "0x658D310", VA = "0x18658E710", Slot = "4")]
	public override void HLMCGMABGFI(ILGenerator CIJLGEAJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x658E6C0", Offset = "0x658D2C0", VA = "0x18658E6C0", Slot = "5")]
	public override void CNHNBCDJONK(ILGenerator CIJLGEAJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x658E7D0", Offset = "0x658D3D0", VA = "0x18658E7D0")]
	public void NPAEENMOEOF(ILGenerator CIJLGEAJFCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class BACBDEMNINE
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type IBCFEMEEMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IOENPAAHCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7F49A0", Offset = "0x7F35A0", VA = "0x1807F49A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x778130", Offset = "0x776D30", VA = "0x180778130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool MHCOFPFHOOF
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x87C370", Offset = "0x87AF70", VA = "0x18087C370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x87B650", Offset = "0x87A250", VA = "0x18087B650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo PMMJFMBFJAH
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x773620", Offset = "0x772220", VA = "0x180773620")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public OJPEDGNDNFK[] PNNLKPBNICD
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x773600", Offset = "0x772200", VA = "0x180773600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x773820", Offset = "0x772420", VA = "0x180773820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public OJPEDGNDNFK[] MMLNILEMCML
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x77D0D0", Offset = "0x77BCD0", VA = "0x18077D0D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x658A0B0", Offset = "0x6588CB0", VA = "0x18658A0B0")]
	public BACBDEMNINE(Type OMKEAAPIABA, Func<string, string> ALBFCCONJIK, bool MNGNKGHAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6589FD0", Offset = "0x6588BD0", VA = "0x186589FD0")]
	private static bool FGINGALNKCB(IEnumerator<ConstructorInfo> HLKFINDNPOB, ConstructorInfo KOGDBGENACK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct DFPOKPBFHML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong PDLHBLLNCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int PFNPJMEIKHD;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1D01840", Offset = "0x1D00440", VA = "0x181D01840")]
	public DFPOKPBFHML(ulong NELHHIOBKGD, int FEBIIPCHBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x658F940", Offset = "0x658E540", VA = "0x18658F940")]
	public void FBOCMFEJDPK(DFPOKPBFHML LLMHBOEDHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x658FA80", Offset = "0x658E680", VA = "0x18658FA80")]
	public static DFPOKPBFHML PDPFELLHGBH(DFPOKPBFHML FLGIINLNNEM, DFPOKPBFHML KNDAEONALIC)
	{
		return default(DFPOKPBFHML);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x658F9F0", Offset = "0x658E5F0", VA = "0x18658F9F0")]
	public void ODACDIGNODO(DFPOKPBFHML LLMHBOEDHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x658F950", Offset = "0x658E550", VA = "0x18658F950")]
	public static DFPOKPBFHML IMHICEPHMGE(DFPOKPBFHML FLGIINLNNEM, DFPOKPBFHML KNDAEONALIC)
	{
		return default(DFPOKPBFHML);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x658F900", Offset = "0x658E500", VA = "0x18658F900")]
	public void DBBAENCEIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x658F8B0", Offset = "0x658E4B0", VA = "0x18658F8B0")]
	public static DFPOKPBFHML DBBAENCEIFH(DFPOKPBFHML FLGIINLNNEM)
	{
		return default(DFPOKPBFHML);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct LPNKJONGPMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] NJCBLCELFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int IAKOFEGDGBF;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x17525C0", Offset = "0x17511C0", VA = "0x1817525C0")]
	public LPNKJONGPMC(byte[] NJCBLCELFEN, int CFCLFCDKKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6576740", Offset = "0x6575340", VA = "0x186576740")]
	public void POINPFHLGOP(byte JMMCCECHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x659D8E0", Offset = "0x659C4E0", VA = "0x18659D8E0")]
	public void POLMGCBCKOH(byte[] JMMCCECHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x659D6C0", Offset = "0x659C2C0", VA = "0x18659D6C0")]
	public void NHBAMLKGABP(byte[] JMMCCECHKKL, int NBJKCBMEDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x659D740", Offset = "0x659C340", VA = "0x18659D740")]
	public void NHBAMLKGABP(byte[] JMMCCECHKKL, int DIOBLODNDCP, int NBJKCBMEDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x659D640", Offset = "0x659C240", VA = "0x18659D640")]
	public void EFJGNNODKEP(byte KIHBPBFELGP, int EMHEDPDPEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x659D7E0", Offset = "0x659C3E0", VA = "0x18659D7E0")]
	public void PBBCBGIFFGM(string JMMCCECHKKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class LABGEPLIGPH
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum CDHLMAJMLCA
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum ODGIJLCJMGI
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private enum GOMDEHLAGLK
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
	private static byte[] GOBEGBFDPEM;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] HGDLBLMLJJO;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] CAEMKHJGGMH;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] ANNGHBFMJJG;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly GOMDEHLAGLK NLJFBFAAFNB;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char FINKPLNPNNC;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int PAOJDGGBGDO;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int ENKMPIEMIDG;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] PBDLDMDHIBO;

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6597E60", Offset = "0x6596A60", VA = "0x186597E60")]
	private static byte[] CEKOPEMLOIP(int JIGGJNDJAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6598890", Offset = "0x6597490", VA = "0x186598890")]
	private static byte[] IAEPAPKACLD(int JIGGJNDJAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6598EF0", Offset = "0x6597AF0", VA = "0x186598EF0")]
	public static int MFJOPFFCBFK(byte[] NJCBLCELFEN, int IAKOFEGDGBF, float GCPEEAODAIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6599010", Offset = "0x6597C10", VA = "0x186599010")]
	public static int MFJOPFFCBFK(byte[] NJCBLCELFEN, int IAKOFEGDGBF, double GCPEEAODAIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6597F30", Offset = "0x6596B30", VA = "0x186597F30")]
	private static bool DGHBICLJFKF(byte[] NJCBLCELFEN, int NBJKCBMEDIG, ulong KLKNLJMDOEK, ulong OJEBGGFGFOL, ulong MMANDKLIFNJ, ulong HFIENIJCLHE, ulong OHMJBJMILMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6597D70", Offset = "0x6596970", VA = "0x186597D70")]
	private static void BJKMFIKMHOP(uint JEIBBCEGCBO, int LMKICJEEBEF, [Out] uint FMJGCKCFHAM, [Out] int OMHLFGFAFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6598020", Offset = "0x6596C20", VA = "0x186598020")]
	private static bool DLMIKCHHFAH(DFPOKPBFHML LLNPNMLBICK, DFPOKPBFHML NGJMGEHADAK, DFPOKPBFHML LMDBNDADMFL, byte[] NJCBLCELFEN, [Out] int NBJKCBMEDIG, [Out] int ABJMDLOAOMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6598410", Offset = "0x6597010", VA = "0x186598410")]
	private static bool FAODDPNDOHM(double NDGLLLKBMIO, CDHLMAJMLCA BBGPDHGEJDH, byte[] NJCBLCELFEN, [Out] int NBJKCBMEDIG, [Out] int AIHLCJJDOID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x6599C10", Offset = "0x6598810", VA = "0x186599C10")]
	private static bool PANHPFBLEKJ(double NDGLLLKBMIO, CDHLMAJMLCA BBGPDHGEJDH, byte[] NJCBLCELFEN, [Out] int NBJKCBMEDIG, [Out] int FENNFAPGOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6599560", Offset = "0x6598160", VA = "0x186599560")]
	private static bool NDIPKKMDGPB(double GCPEEAODAIB, LPNKJONGPMC FHEPBBDALPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6599730", Offset = "0x6598330", VA = "0x186599730")]
	private static bool OAJOLDNEHCM(double GCPEEAODAIB, LPNKJONGPMC FHEPBBDALPE, ODGIJLCJMGI BBGPDHGEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6598970", Offset = "0x6597570", VA = "0x186598970")]
	private static void KFEJCKCMOPB(byte[] MACFHPPABAJ, int NBJKCBMEDIG, int FENNFAPGOBF, int MNNEJFEANOM, LPNKJONGPMC FHEPBBDALPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6599130", Offset = "0x6597D30", VA = "0x186599130")]
	private static void MNHDEBCMAAC(byte[] MACFHPPABAJ, int NBJKCBMEDIG, int FEBIIPCHBAJ, LPNKJONGPMC FHEPBBDALPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6598D00", Offset = "0x6597900", VA = "0x186598D00")]
	private static bool KKENKCNHHEH(double NDGLLLKBMIO, ODGIJLCJMGI BBGPDHGEJDH, int FHFIDFIAGGB, byte[] ELGIBJGKOHI, [Out] bool BJCEOIDCFEF, [Out] int NBJKCBMEDIG, [Out] int BHCNJFDJBME)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct EKEKOBJKBLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double DKFOONILOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong MMNIHKDKLIJ;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct MOJKHDADIKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float PDLHBLLNCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint DPLPDJNCKMG;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct GHJAFIHCHIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong NEDHAICLKKA;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x65958E0", Offset = "0x65944E0", VA = "0x1865958E0")]
	public GHJAFIHCHIK(double DKFOONILOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6595840", Offset = "0x6594440", VA = "0x186595840")]
	public GHJAFIHCHIK(DFPOKPBFHML DKFOONILOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6595440", Offset = "0x6594040", VA = "0x186595440")]
	public DFPOKPBFHML FLPFOFJKMME()
	{
		return default(DFPOKPBFHML);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x65954B0", Offset = "0x65940B0", VA = "0x1865954B0")]
	public DFPOKPBFHML GCLNJFHJPCC()
	{
		return default(DFPOKPBFHML);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910")]
	public ulong HADDMJHGJHI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x65953C0", Offset = "0x6593FC0", VA = "0x1865953C0")]
	public double FLHBBPCFCKB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6595320", Offset = "0x6593F20", VA = "0x186595320")]
	public double DHEKLAIPHGI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6595810", Offset = "0x6594410", VA = "0x186595810")]
	public int PMLNBFFGGGM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6595550", Offset = "0x6594150", VA = "0x186595550")]
	public ulong HMJIOHLLOCI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6595300", Offset = "0x6593F00", VA = "0x186595300")]
	public bool CIIAMPGGNFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x65957F0", Offset = "0x65943F0", VA = "0x1865957F0")]
	public bool NHMAJCFKLJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x65957C0", Offset = "0x65943C0", VA = "0x1865957C0")]
	public bool MOANELEPKLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6595770", Offset = "0x6594370", VA = "0x186595770")]
	public bool KNGIMPCCJGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6595530", Offset = "0x6594130", VA = "0x186595530")]
	public int HDFMGJMNDJA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6595590", Offset = "0x6594190", VA = "0x186595590")]
	public void KFGPFCMKFOM([Out] DFPOKPBFHML JJDBDDGAGIB, [Out] DFPOKPBFHML CNGBHOEDGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x65952B0", Offset = "0x6593EB0", VA = "0x1865952B0")]
	public bool AJAFKHDDMJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA570", Offset = "0x2AB9170", VA = "0x182ABA570")]
	public double GCPEEAODAIB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x65957A0", Offset = "0x65943A0", VA = "0x1865957A0")]
	public static int LHEIKHOLKJI(int HDJFIBIFIHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6595580", Offset = "0x6594180", VA = "0x186595580")]
	public static double JNCFOOGNLAP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x65956E0", Offset = "0x65942E0", VA = "0x1865956E0")]
	public static ulong KKMLJJCMEBE(DFPOKPBFHML GMMHGPLFABN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct FHECNMGBENC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint IAOGHCAKOBK;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x20221D0", Offset = "0x2020DD0", VA = "0x1820221D0")]
	public FHECNMGBENC(float PDLHBLLNCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6592070", Offset = "0x6590C70", VA = "0x186592070")]
	public DFPOKPBFHML FLPFOFJKMME()
	{
		return default(DFPOKPBFHML);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x85B650", Offset = "0x85A250", VA = "0x18085B650")]
	public uint HJKHHDDOFKE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6592210", Offset = "0x6590E10", VA = "0x186592210")]
	public int PMLNBFFGGGM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x65920C0", Offset = "0x6590CC0", VA = "0x1865920C0")]
	public uint HMJIOHLLOCI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6592060", Offset = "0x6590C60", VA = "0x186592060")]
	public bool CIIAMPGGNFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x65920E0", Offset = "0x6590CE0", VA = "0x1865920E0")]
	public void KFGPFCMKFOM([Out] DFPOKPBFHML JJDBDDGAGIB, [Out] DFPOKPBFHML CNGBHOEDGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6592020", Offset = "0x6590C20", VA = "0x186592020")]
	public bool AJAFKHDDMJO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct FMODAECADOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong NELHHIOBKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short JPILGPKGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short AIHLCJJDOID;

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6592230", Offset = "0x6590E30", VA = "0x186592230")]
	public FMODAECADOM(ulong NELHHIOBKGD, short JPILGPKGFOP, short AIHLCJJDOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class OMECALJGBCK
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly FMODAECADOM[] PEHFABGKGKL;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x659FF70", Offset = "0x659EB70", VA = "0x18659FF70")]
	public static void HOMCOPLIFIP(int JGMCOHAGILP, int PKLEDKPAHHO, [Out] DFPOKPBFHML FMJGCKCFHAM, [Out] int AIHLCJJDOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x65A0080", Offset = "0x659EC80", VA = "0x1865A0080")]
	public static void KAHEPMHMDAF(int ADEMFGMMFEJ, [Out] DFPOKPBFHML FMJGCKCFHAM, [Out] int HPAPJMKKLKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[DefaultMember("Item")]
internal struct KCFEJJHJMHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] FEGEJBFJFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int DIOBLODNDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int BJJGLGNKMJK;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6597590", Offset = "0x6596190", VA = "0x186597590")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3711760", Offset = "0x3710360", VA = "0x183711760")]
	public KCFEJJHJMHF(byte[] FEGEJBFJFNG, int DIOBLODNDCP, int NBJKCBMEDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x2057F80", Offset = "0x2056B80", VA = "0x182057F80")]
	public int NBJKCBMEDIG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x65975D0", Offset = "0x65961D0", VA = "0x1865975D0")]
	public KCFEJJHJMHF EJDLPJIKFGF(int JEHKFEAPIEI, int JLMAKMFNDLF)
	{
		return default(KCFEJJHJMHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class GBAGAHAIIDJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] CIGHLPFNHFI;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] BJIPGOGGDIH;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int DPMPENBIDII;

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x65929D0", Offset = "0x65915D0", VA = "0x1865929D0")]
	private static byte[] EMJFFNFEAJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6593A20", Offset = "0x6592620", VA = "0x186593A20")]
	private static KCFEJJHJMHF OFBCPOEGBJC(KCFEJJHJMHF NJCBLCELFEN)
	{
		return default(KCFEJJHJMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6593670", Offset = "0x6592270", VA = "0x186593670")]
	private static KCFEJJHJMHF MACLMJAFFNO(KCFEJJHJMHF NJCBLCELFEN)
	{
		return default(KCFEJJHJMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6593210", Offset = "0x6591E10", VA = "0x186593210")]
	private static void KILBKKPAHIE(KCFEJJHJMHF NJCBLCELFEN, int FEBIIPCHBAJ, byte[] HJMEDKKEHLH, [Out] int GHJKFBBFDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6592C60", Offset = "0x6591860", VA = "0x186592C60")]
	private static void GKBHCCKEHAJ(KCFEJJHJMHF NJCBLCELFEN, int FEBIIPCHBAJ, byte[] PGOHOPMOBKB, int CPCBECKBNOF, [Out] KCFEJJHJMHF PGNPELJCPMM, [Out] int DBECDMJCCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6592AB0", Offset = "0x65916B0", VA = "0x186592AB0")]
	private static ulong FBKNKKBKOND(KCFEJJHJMHF NJCBLCELFEN, [Out] int OMICGPLLKGO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6592890", Offset = "0x6591490", VA = "0x186592890")]
	private static void CHLMEBCKPCI(KCFEJJHJMHF NJCBLCELFEN, [Out] DFPOKPBFHML HNCONAMCFGC, [Out] int NBGAHCAFBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x65932A0", Offset = "0x6591EA0", VA = "0x1865932A0")]
	private static bool KNHAKNJEJMG(KCFEJJHJMHF PGNPELJCPMM, int FEBIIPCHBAJ, [Out] double HNCONAMCFGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6592F50", Offset = "0x6591B50", VA = "0x186592F50")]
	private static DFPOKPBFHML GPEMMKCJLBC(int FEBIIPCHBAJ)
	{
		return default(DFPOKPBFHML);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6592240", Offset = "0x6590E40", VA = "0x186592240")]
	private static bool CGONDNFNNAD(KCFEJJHJMHF NJCBLCELFEN, int FEBIIPCHBAJ, [Out] double HNCONAMCFGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x65930F0", Offset = "0x6591CF0", VA = "0x1865930F0")]
	private static bool JICNHGELDEK(KCFEJJHJMHF PGNPELJCPMM, int FEBIIPCHBAJ, [Out] double FMABIFGOAME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6592B40", Offset = "0x6591740", VA = "0x186592B40")]
	public static double? FLFCGJNGOKM(KCFEJJHJMHF NJCBLCELFEN, int FEBIIPCHBAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6593750", Offset = "0x6592350", VA = "0x186593750")]
	public static float? NHHOOAFNNJJ(KCFEJJHJMHF NJCBLCELFEN, int FEBIIPCHBAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal struct HLKDPNIFLDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] NJCBLCELFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int IAKOFEGDGBF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte GMFAJOGMKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x65AE670", Offset = "0x65AD270", VA = "0x1865AE670")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x17525C0", Offset = "0x17511C0", VA = "0x1817525C0")]
	public HLKDPNIFLDK(byte[] NJCBLCELFEN, int IAKOFEGDGBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x65AE660", Offset = "0x65AD260", VA = "0x1865AE660")]
	public static HLKDPNIFLDK GGEGNDBLNDM(HLKDPNIFLDK HHHLENOMLMP)
	{
		return default(HLKDPNIFLDK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x65AE5E0", Offset = "0x65AD1E0", VA = "0x1865AE5E0")]
	public static HLKDPNIFLDK CNAFECNPDIL(HLKDPNIFLDK HHHLENOMLMP, int NBJKCBMEDIG)
	{
		return default(HLKDPNIFLDK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x65AE780", Offset = "0x65AD380", VA = "0x1865AE780")]
	public static int ODFMOCCMCOB(HLKDPNIFLDK AGIBINPMDEG, HLKDPNIFLDK BBPKFALMKGI)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x65AE740", Offset = "0x65AD340", VA = "0x1865AE740")]
	public static bool JONBIHPGCCI(HLKDPNIFLDK AGIBINPMDEG, HLKDPNIFLDK BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x65AE700", Offset = "0x65AD300", VA = "0x1865AE700")]
	public static bool JBDELPGDOBO(HLKDPNIFLDK AGIBINPMDEG, HLKDPNIFLDK BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x65AE710", Offset = "0x65AD310", VA = "0x1865AE710")]
	public static bool JONBIHPGCCI(HLKDPNIFLDK AGIBINPMDEG, char BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x65AE6D0", Offset = "0x65AD2D0", VA = "0x1865AE6D0")]
	public static bool JBDELPGDOBO(HLKDPNIFLDK AGIBINPMDEG, char BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x65AE6D0", Offset = "0x65AD2D0", VA = "0x1865AE6D0")]
	public static bool JBDELPGDOBO(HLKDPNIFLDK AGIBINPMDEG, byte BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x65AE630", Offset = "0x65AD230", VA = "0x1865AE630")]
	public static bool EIEHBMEICDK(HLKDPNIFLDK AGIBINPMDEG, char BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x65AE750", Offset = "0x65AD350", VA = "0x1865AE750")]
	public static bool MOELJPPBJBB(HLKDPNIFLDK AGIBINPMDEG, char BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x65AE5B0", Offset = "0x65AD1B0", VA = "0x1865AE5B0")]
	public static bool BMEBEOKILAP(HLKDPNIFLDK AGIBINPMDEG, char BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x65AE6A0", Offset = "0x65AD2A0", VA = "0x1865AE6A0")]
	public static bool HEFDKDMMFGC(HLKDPNIFLDK AGIBINPMDEG, char BBPKFALMKGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class OACHPACABCO
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] MPNFNFKJOLC;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] AKPIBFJFHPG;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] CAEMKHJGGMH;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] ANNGHBFMJJG;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] CKFGPMPGKGI;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int LJBJBKFBGBF;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] BHPJOJJLEPE;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int KCFFHCKOENP;

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x65B1A30", Offset = "0x65B0630", VA = "0x1865B1A30")]
	private static byte[] HHMJKHMNGNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x65B1810", Offset = "0x65B0410", VA = "0x1865B1810")]
	private static byte[] ABEKEBIFDCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x65B1B10", Offset = "0x65B0710", VA = "0x1865B1B10")]
	public static double HKGCPAJECEL(byte[] NJCBLCELFEN, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x65B1EF0", Offset = "0x65B0AF0", VA = "0x1865B1EF0")]
	public static float OPGCAFHHDAO(byte[] NJCBLCELFEN, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x65B1DB0", Offset = "0x65B09B0", VA = "0x1865B1DB0")]
	private static bool LECPKFKJFCJ(int HPIMCNPJDMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x65B1BC0", Offset = "0x65B07C0", VA = "0x1865B1BC0")]
	private static bool KEKEGFNHHGI(HLKDPNIFLDK NNIJILBJONM, HLKDPNIFLDK AEFDKINALJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x65B1940", Offset = "0x65B0540", VA = "0x1865B1940")]
	private static bool BFIFFPGKKMC(HLKDPNIFLDK NNIJILBJONM, HLKDPNIFLDK AEFDKINALJN, byte[] EKMOJANHMGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x65B18F0", Offset = "0x65B04F0", VA = "0x1865B18F0")]
	private static bool ACPNAFHFDCK(HLKDPNIFLDK BOPKPGKGOLB, byte[] JMMCCECHKKL, int IAKOFEGDGBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x65B1A10", Offset = "0x65B0610", VA = "0x1865B1A10")]
	private static double CJHFADOHIKA(bool BJCEOIDCFEF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x65B1FA0", Offset = "0x65B0BA0", VA = "0x1865B1FA0")]
	private static double PKMENICJIAB(HLKDPNIFLDK MAIMNHFMIBD, int NBJKCBMEDIG, bool DIFJNNMHEKD, [Out] int BIMMOBPHPFC)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class COODBLILHOK<T> : CBFHJMOMLDG<T[]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly PAMNCHCIGOJ<T> OBOMCGMHGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly LHNNGKOEDJE BAODLGNFAPL;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x314F940", Offset = "0x314E540", VA = "0x18314F940")]
	public COODBLILHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
	public COODBLILHOK(LHNNGKOEDJE BAODLGNFAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x4C84B70", Offset = "0x4C83770", VA = "0x184C84B70", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x4C821A0", Offset = "0x4C80DA0", VA = "0x184C821A0", Slot = "5")]
	public T[] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class PPGMMOAAGFD<T> : CBFHJMOMLDG<ArraySegment<T>>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly PAMNCHCIGOJ<T> OBOMCGMHGLE;

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3EBE070", Offset = "0x3EBCC70", VA = "0x183EBE070", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ArraySegment<T> GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3EBDC50", Offset = "0x3EBC850", VA = "0x183EBDC50", Slot = "5")]
	public ArraySegment<T> JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class JNOPNIANKHA<T> : CBFHJMOMLDG<List<T>>, LKLKMMHABOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly LHNNGKOEDJE BAODLGNFAPL;

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x314F940", Offset = "0x314E540", VA = "0x18314F940")]
	public JNOPNIANKHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
	public JNOPNIANKHA(LHNNGKOEDJE BAODLGNFAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x39281B0", Offset = "0x3926DB0", VA = "0x1839281B0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, List<T> GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x3927780", Offset = "0x3926380", VA = "0x183927780", Slot = "5")]
	public List<T> JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class BBLFAFJAEFA<TElement, TIntermediate, TEnumerator, TCollection> : CBFHJMOMLDG<TCollection>, LKLKMMHABOC where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x4587E40", Offset = "0x4586A40", VA = "0x184587E40", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, TCollection GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x45870F0", Offset = "0x4585CF0", VA = "0x1845870F0", Slot = "5")]
	public TCollection JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator JMCJOFLMHBP(TCollection NOOIIGLDGHB);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate PAKONFKLIMF();

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void HFMDKEOMMOI(TIntermediate GAHOHIBHCJI, int DCGGFHOCGGH, TElement GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection ENMBELGAIGO(TIntermediate KOKBEGHOPJP);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	protected BBLFAFJAEFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class CMJOJEAGDCH<TElement, TIntermediate, TCollection> : BBLFAFJAEFA<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x318CB70", Offset = "0x318B770", VA = "0x18318CB70", Slot = "6")]
	protected override IEnumerator<TElement> JMCJOFLMHBP(TCollection NOOIIGLDGHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x3137AB0", Offset = "0x31366B0", VA = "0x183137AB0")]
	protected CMJOJEAGDCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public abstract class PEEKJOICJLF<TElement, TCollection> : CMJOJEAGDCH<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x80ED50", Offset = "0x80D950", VA = "0x18080ED50", Slot = "9")]
	protected sealed override TCollection ENMBELGAIGO(TCollection KOKBEGHOPJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class DJOHFFJIEPO<TElement, TCollection> : PEEKJOICJLF<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x4E4A6F0", Offset = "0x4E492F0", VA = "0x184E4A6F0", Slot = "7")]
	protected override TCollection PAKONFKLIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x4E4A630", Offset = "0x4E49230", VA = "0x184E4A630", Slot = "8")]
	protected override void HFMDKEOMMOI(TCollection GAHOHIBHCJI, int DCGGFHOCGGH, TElement GCPEEAODAIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class EGKAHEHGJBI<T> : BBLFAFJAEFA<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3167940", Offset = "0x3166540", VA = "0x183167940", Slot = "8")]
	protected override void HFMDKEOMMOI(LinkedList<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x80ED50", Offset = "0x80D950", VA = "0x18080ED50", Slot = "9")]
	protected override LinkedList<T> ENMBELGAIGO(LinkedList<T> KOKBEGHOPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3152F60", Offset = "0x3151B60", VA = "0x183152F60", Slot = "7")]
	protected override LinkedList<T> PAKONFKLIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3167980", Offset = "0x3166580", VA = "0x183167980", Slot = "6")]
	protected override LinkedList<T>.Enumerator JMCJOFLMHBP(LinkedList<T> NOOIIGLDGHB)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class IMLPKNKKNLJ<T> : BBLFAFJAEFA<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3167940", Offset = "0x3166540", VA = "0x183167940", Slot = "8")]
	protected override void HFMDKEOMMOI(Queue<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3152F60", Offset = "0x3151B60", VA = "0x183152F60", Slot = "7")]
	protected override Queue<T> PAKONFKLIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x3746730", Offset = "0x3745330", VA = "0x183746730", Slot = "6")]
	protected override Queue<T>.Enumerator JMCJOFLMHBP(Queue<T> NOOIIGLDGHB)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x80ED50", Offset = "0x80D950", VA = "0x18080ED50", Slot = "9")]
	protected override Queue<T> ENMBELGAIGO(Queue<T> KOKBEGHOPJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class MPMBPMKFDOG<T> : BBLFAFJAEFA<T, FPOLAPAFDEF<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3CC41C0", Offset = "0x3CC2DC0", VA = "0x183CC41C0", Slot = "8")]
	protected override void HFMDKEOMMOI(FPOLAPAFDEF<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4250", Offset = "0x3CC2E50", VA = "0x183CC4250", Slot = "7")]
	protected override FPOLAPAFDEF<T> PAKONFKLIMF()
	{
		return default(FPOLAPAFDEF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3CC41F0", Offset = "0x3CC2DF0", VA = "0x183CC41F0", Slot = "6")]
	protected override Stack<T>.Enumerator JMCJOFLMHBP(Stack<T> NOOIIGLDGHB)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3CC40E0", Offset = "0x3CC2CE0", VA = "0x183CC40E0", Slot = "9")]
	protected override Stack<T> ENMBELGAIGO(FPOLAPAFDEF<T> KOKBEGHOPJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class CNHNPMNINGB<T> : BBLFAFJAEFA<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3167940", Offset = "0x3166540", VA = "0x183167940", Slot = "8")]
	protected override void HFMDKEOMMOI(HashSet<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x80ED50", Offset = "0x80D950", VA = "0x18080ED50", Slot = "9")]
	protected override HashSet<T> ENMBELGAIGO(HashSet<T> KOKBEGHOPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3152F60", Offset = "0x3151B60", VA = "0x183152F60", Slot = "7")]
	protected override HashSet<T> PAKONFKLIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x3746730", Offset = "0x3745330", VA = "0x183746730", Slot = "6")]
	protected override HashSet<T>.Enumerator JMCJOFLMHBP(HashSet<T> NOOIIGLDGHB)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class PPHDAKEJFPG<T> : CMJOJEAGDCH<T, FPOLAPAFDEF<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3CC41C0", Offset = "0x3CC2DC0", VA = "0x183CC41C0", Slot = "8")]
	protected override void HFMDKEOMMOI(FPOLAPAFDEF<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x3EBE4D0", Offset = "0x3EBD0D0", VA = "0x183EBE4D0", Slot = "9")]
	protected override ReadOnlyCollection<T> ENMBELGAIGO(FPOLAPAFDEF<T> KOKBEGHOPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x3EBE570", Offset = "0x3EBD170", VA = "0x183EBE570", Slot = "7")]
	protected override FPOLAPAFDEF<T> PAKONFKLIMF()
	{
		return default(FPOLAPAFDEF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class NIMAFEJMNDM<T> : CMJOJEAGDCH<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3167940", Offset = "0x3166540", VA = "0x183167940", Slot = "8")]
	protected override void HFMDKEOMMOI(List<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x3152F60", Offset = "0x3151B60", VA = "0x183152F60", Slot = "7")]
	protected override List<T> PAKONFKLIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x80ED50", Offset = "0x80D950", VA = "0x18080ED50", Slot = "9")]
	protected override IList<T> ENMBELGAIGO(List<T> KOKBEGHOPJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class NCIIOINPGKJ<T> : CMJOJEAGDCH<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3167940", Offset = "0x3166540", VA = "0x183167940", Slot = "8")]
	protected override void HFMDKEOMMOI(List<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3152F60", Offset = "0x3151B60", VA = "0x183152F60", Slot = "7")]
	protected override List<T> PAKONFKLIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x80ED50", Offset = "0x80D950", VA = "0x18080ED50", Slot = "9")]
	protected override ICollection<T> ENMBELGAIGO(List<T> KOKBEGHOPJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class CELLFHIHHPL<T> : CMJOJEAGDCH<T, FPOLAPAFDEF<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x3CC41C0", Offset = "0x3CC2DC0", VA = "0x183CC41C0", Slot = "8")]
	protected override void HFMDKEOMMOI(FPOLAPAFDEF<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4250", Offset = "0x3CC2E50", VA = "0x183CC4250", Slot = "7")]
	protected override FPOLAPAFDEF<T> PAKONFKLIMF()
	{
		return default(FPOLAPAFDEF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x4967F60", Offset = "0x4966B60", VA = "0x184967F60", Slot = "9")]
	protected override IEnumerable<T> ENMBELGAIGO(FPOLAPAFDEF<T> KOKBEGHOPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x3145470", Offset = "0x3144070", VA = "0x183145470")]
	public CELLFHIHHPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class ABMHIILCNOP<TKey, TElement> : CBFHJMOMLDG<IGrouping<TKey, TElement>>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3547900", Offset = "0x3546500", VA = "0x183547900", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, IGrouping<TKey, TElement> GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3547600", Offset = "0x3546200", VA = "0x183547600", Slot = "5")]
	public IGrouping<TKey, TElement> JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class MOBFNPJHPCB<TKey, TElement> : CBFHJMOMLDG<ILookup<TKey, TElement>>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD0B0", Offset = "0x3CBBCB0", VA = "0x183CBD0B0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ILookup<TKey, TElement> GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCD60", Offset = "0x3CBB960", VA = "0x183CBCD60", Slot = "5")]
	public ILookup<TKey, TElement> JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class JFPLAEPADBK<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly TKey PPNDANAOAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly IEnumerable<TElement> PECFDDJHOLI;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey PLLFMAPAGEE
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x775A60", Offset = "0x774660", VA = "0x180775A60")]
	public JFPLAEPADBK(TKey PPNDANAOAMK, IEnumerable<TElement> PECFDDJHOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x38ED4C0", Offset = "0x38EC0C0", VA = "0x1838ED4C0", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x31D2DE0", Offset = "0x31D19E0", VA = "0x1831D2DE0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[DefaultMember("Item")]
internal class OLGDKLHFPPD<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> EMKKDGCAFPG;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x34C5BF0", Offset = "0x34C47F0", VA = "0x1834C5BF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	public OLGDKLHFPPD(Dictionary<TKey, IGrouping<TKey, TElement>> EMKKDGCAFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x38EC5A0", Offset = "0x38EB1A0", VA = "0x1838EC5A0", Slot = "5")]
	public bool Contains(TKey PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3E038E0", Offset = "0x3E024E0", VA = "0x183E038E0", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3E038E0", Offset = "0x3E024E0", VA = "0x183E038E0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class MNKMIFFGFFH<T> : CBFHJMOMLDG<T>, LKLKMMHABOC where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC1D0", Offset = "0x3CBADD0", VA = "0x183CBC1D0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3CBBF50", Offset = "0x3CBAB50", VA = "0x183CBBF50", Slot = "5")]
	public T JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public MNKMIFFGFFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class AJPHOICHJGN : CBFHJMOMLDG<IEnumerable>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly CBFHJMOMLDG<IEnumerable> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x65A3D70", Offset = "0x65A2970", VA = "0x1865A3D70", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, IEnumerable GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x65A3B20", Offset = "0x65A2720", VA = "0x1865A3B20", Slot = "5")]
	public IEnumerable JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public AJPHOICHJGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class PONDNJJDDBF : CBFHJMOMLDG<ICollection>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly CBFHJMOMLDG<ICollection> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x65B4B70", Offset = "0x65B3770", VA = "0x1865B4B70", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ICollection GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x65B4920", Offset = "0x65B3520", VA = "0x1865B4920", Slot = "5")]
	public ICollection JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public PONDNJJDDBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class HOJOCJGCBAA : CBFHJMOMLDG<IList>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly CBFHJMOMLDG<IList> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x65AEDD0", Offset = "0x65AD9D0", VA = "0x1865AEDD0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, IList GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x65AEB80", Offset = "0x65AD780", VA = "0x1865AEB80", Slot = "5")]
	public IList JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public HOJOCJGCBAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class ONKPPABFBBF<T> : CMJOJEAGDCH<T, FPOLAPAFDEF<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x3E06320", Offset = "0x3E04F20", VA = "0x183E06320", Slot = "8")]
	protected override void HFMDKEOMMOI(FPOLAPAFDEF<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4250", Offset = "0x3CC2E50", VA = "0x183CC4250", Slot = "7")]
	protected override FPOLAPAFDEF<T> PAKONFKLIMF()
	{
		return default(FPOLAPAFDEF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3E062D0", Offset = "0x3E04ED0", VA = "0x183E062D0", Slot = "9")]
	protected override IReadOnlyList<T> ENMBELGAIGO(FPOLAPAFDEF<T> KOKBEGHOPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3144E10", Offset = "0x3143A10", VA = "0x183144E10")]
	public ONKPPABFBBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class DADCIDJGLJE
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x65A7630", Offset = "0x65A6230", VA = "0x1865A7630")]
	public static DateTime IOFDIDOHEJF(DateTime NPCNHIGLAOD)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class EIOBJCMGLHL : CBFHJMOMLDG<DateTime>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public static readonly CBFHJMOMLDG<DateTime> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x65AA9B0", Offset = "0x65A95B0", VA = "0x1865AA9B0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, DateTime GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x65A9CA0", Offset = "0x65A88A0", VA = "0x1865A9CA0", Slot = "5")]
	public DateTime JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public EIOBJCMGLHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class AJNHODGGNHD : CBFHJMOMLDG<DateTimeOffset>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly CBFHJMOMLDG<DateTimeOffset> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x65A3400", Offset = "0x65A2000", VA = "0x1865A3400", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, DateTimeOffset GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x65A27E0", Offset = "0x65A13E0", VA = "0x1865A27E0", Slot = "5")]
	public DateTimeOffset JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public AJNHODGGNHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class DIBMFPOOFHK : CBFHJMOMLDG<TimeSpan>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public static readonly CBFHJMOMLDG<TimeSpan> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static byte[] EHDGBLJPILK;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x65A8000", Offset = "0x65A6C00", VA = "0x1865A8000", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, TimeSpan GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x65A76F0", Offset = "0x65A62F0", VA = "0x1865A76F0", Slot = "5")]
	public TimeSpan JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public DIBMFPOOFHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public abstract class LEDFIBGKFDE<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : CBFHJMOMLDG<TDictionary>, LKLKMMHABOC where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3A38520", Offset = "0x3A37120", VA = "0x183A38520", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, TDictionary GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x3A343C0", Offset = "0x3A32FC0", VA = "0x183A343C0", Slot = "5")]
	public TDictionary JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator JMCJOFLMHBP(TDictionary NOOIIGLDGHB);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate PAKONFKLIMF();

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void HFMDKEOMMOI(TIntermediate GAHOHIBHCJI, int DCGGFHOCGGH, TKey PPNDANAOAMK, TValue GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary ENMBELGAIGO(TIntermediate KOKBEGHOPJP);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	protected LEDFIBGKFDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class ENDGOCHKPDG<TKey, TValue, TIntermediate, TDictionary> : LEDFIBGKFDE<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x318CB70", Offset = "0x318B770", VA = "0x18318CB70", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> JMCJOFLMHBP(TDictionary NOOIIGLDGHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class JHNJJEPEAEE<TKey, TValue, TDictionary> : ENDGOCHKPDG<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x80ED50", Offset = "0x80D950", VA = "0x18080ED50", Slot = "9")]
	protected override TDictionary ENMBELGAIGO(TDictionary KOKBEGHOPJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class FBPMGAJAMAL<TKey, TValue> : LEDFIBGKFDE<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x34C6B90", Offset = "0x34C5790", VA = "0x1834C6B90", Slot = "8")]
	protected override void HFMDKEOMMOI(Dictionary<TKey, TValue> GAHOHIBHCJI, int DCGGFHOCGGH, TKey PPNDANAOAMK, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x80ED50", Offset = "0x80D950", VA = "0x18080ED50", Slot = "9")]
	protected override Dictionary<TKey, TValue> ENMBELGAIGO(Dictionary<TKey, TValue> KOKBEGHOPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x3152F60", Offset = "0x3151B60", VA = "0x183152F60", Slot = "7")]
	protected override Dictionary<TKey, TValue> PAKONFKLIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x34C6D20", Offset = "0x34C5920", VA = "0x1834C6D20", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator JMCJOFLMHBP(Dictionary<TKey, TValue> NOOIIGLDGHB)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3136DA0", Offset = "0x31359A0", VA = "0x183136DA0")]
	public FBPMGAJAMAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class IPBEMECJDFI<TKey, TValue, TDictionary> : JHNJJEPEAEE<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x3751DC0", Offset = "0x37509C0", VA = "0x183751DC0", Slot = "8")]
	protected override void HFMDKEOMMOI(TDictionary GAHOHIBHCJI, int DCGGFHOCGGH, TKey PPNDANAOAMK, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C740", Offset = "0x2F7B340", VA = "0x182F7C740", Slot = "7")]
	protected override TDictionary PAKONFKLIMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class EMINBKMBAFO<TKey, TValue> : ENDGOCHKPDG<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x318C290", Offset = "0x318AE90", VA = "0x18318C290", Slot = "8")]
	protected override void HFMDKEOMMOI(Dictionary<TKey, TValue> GAHOHIBHCJI, int DCGGFHOCGGH, TKey PPNDANAOAMK, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x3152F60", Offset = "0x3151B60", VA = "0x183152F60", Slot = "7")]
	protected override Dictionary<TKey, TValue> PAKONFKLIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x80ED50", Offset = "0x80D950", VA = "0x18080ED50", Slot = "9")]
	protected override IDictionary<TKey, TValue> ENMBELGAIGO(Dictionary<TKey, TValue> KOKBEGHOPJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class FJIFNBCKBJL<TKey, TValue> : JHNJJEPEAEE<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x318C290", Offset = "0x318AE90", VA = "0x18318C290", Slot = "8")]
	protected override void HFMDKEOMMOI(SortedList<TKey, TValue> GAHOHIBHCJI, int DCGGFHOCGGH, TKey PPNDANAOAMK, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3152F60", Offset = "0x3151B60", VA = "0x183152F60", Slot = "7")]
	protected override SortedList<TKey, TValue> PAKONFKLIMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class ODBMBLPGHIK<TKey, TValue> : LEDFIBGKFDE<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x318C290", Offset = "0x318AE90", VA = "0x18318C290", Slot = "8")]
	protected override void HFMDKEOMMOI(SortedDictionary<TKey, TValue> GAHOHIBHCJI, int DCGGFHOCGGH, TKey PPNDANAOAMK, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x80ED50", Offset = "0x80D950", VA = "0x18080ED50", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> ENMBELGAIGO(SortedDictionary<TKey, TValue> KOKBEGHOPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3152F60", Offset = "0x3151B60", VA = "0x183152F60", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> PAKONFKLIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x34C6D90", Offset = "0x34C5990", VA = "0x1834C6D90", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator JMCJOFLMHBP(SortedDictionary<TKey, TValue> NOOIIGLDGHB)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class AAODPGEBANJ<T> : CBFHJMOMLDG<T>, LKLKMMHABOC where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3545BF0", Offset = "0x35447F0", VA = "0x183545BF0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3545950", Offset = "0x3544550", VA = "0x183545950", Slot = "5")]
	public T JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public AAODPGEBANJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class FLLCLAAEOFG : CBFHJMOMLDG<IDictionary>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public static readonly CBFHJMOMLDG<IDictionary> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x65AC980", Offset = "0x65AB580", VA = "0x1865AC980", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, IDictionary GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x65AC750", Offset = "0x65AB350", VA = "0x1865AC750", Slot = "5")]
	public IDictionary JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public FLLCLAAEOFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class EMNJMKEJEAP : CBFHJMOMLDG<object>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private delegate void AFDJDLJFOAF(object PMGMLICKJLL, CJMDLGBHBBN BNGNOICJJGA, object GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private readonly PDIEOAAENMF<KeyValuePair<object, AFDJDLJFOAF>> GNMCHNDEKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private readonly KJHGDFDBIIA[] CGKJJLMOOKO;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x65AC000", Offset = "0x65AAC00", VA = "0x1865AC000")]
	public EMNJMKEJEAP(params KJHGDFDBIIA[] CGKJJLMOOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x65AB640", Offset = "0x65AA240", VA = "0x1865AB640", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, object GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x65AB5B0", Offset = "0x65AA1B0", VA = "0x1865AB5B0", Slot = "5")]
	public object JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class AOPJAGJBLKM
{
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x65A4CD0", Offset = "0x65A38D0", VA = "0x1865A4CD0")]
	public static object DHDAKGLHDJE(Type OMKEAAPIABA, [Out] bool OCJAEOCALDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x65A43E0", Offset = "0x65A2FE0", VA = "0x1865A43E0")]
	public static object APJDDIMMMLH(Type OMKEAAPIABA, [Out] bool OCJAEOCALDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public class DDBMAJAJPAP<T> : CBFHJMOMLDG<T>, LKLKMMHABOC, JGMIPKPABCI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class KDBJOCDNLKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public KDBJOCDNLKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x3972A90", Offset = "0x3971690", VA = "0x183972A90")]
		internal bool FJFNLJGLJJB(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class MFBKGBIOKHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public MFBKGBIOKHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C8D830", Offset = "0x3C8C430", VA = "0x183C8D830")]
		internal bool BDHMMKCFBPH(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class IFPDGIMJEPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public NJBNJFDLMJL<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public IFPDGIMJEPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x3718720", Offset = "0x3717320", VA = "0x183718720")]
		internal void LMPPGDLNMID(CJMDLGBHBBN writer, T value, KJHGDFDBIIA _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class FFDMEKIJOHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public EKOKIEPPFIG<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public FFDMEKIJOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x34D2D70", Offset = "0x34D1970", VA = "0x1834D2D70")]
		internal T LFFNJMCNANO(EPGBDNIILDN reader, KJHGDFDBIIA _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly MDICILNLKFG<T> HDIJHDKPFEF;

	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private static readonly Dictionary<T, string> FAPLJPGDHGB;

	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private static readonly NJBNJFDLMJL<T> AAJCMOAMDAK;

	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private static readonly EKOKIEPPFIG<T> LMLILDCAHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private readonly bool CLLBKBBFJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private readonly NJBNJFDLMJL<T> FCDJAIMKIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private readonly EKOKIEPPFIG<T> LCGNMOJNIOB;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x4DFC100", Offset = "0x4DFAD00", VA = "0x184DFC100")]
	static DDBMAJAJPAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x4E040F0", Offset = "0x4E02CF0", VA = "0x184E040F0")]
	public DDBMAJAJPAP(bool CLLBKBBFJMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x4DF3330", Offset = "0x4DF1F30", VA = "0x184DF3330", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x4DEF410", Offset = "0x4DEE010", VA = "0x184DEF410", Slot = "5")]
	public T JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x4DF2600", Offset = "0x4DF1200", VA = "0x184DF2600", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x4DEE2B0", Offset = "0x4DECEB0", VA = "0x184DEE2B0", Slot = "7")]
	public T DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class GDIHFPIMLCG<T> : CBFHJMOMLDG<T[,]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x35B15A0", Offset = "0x35B01A0", VA = "0x1835B15A0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T[,] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x35B1270", Offset = "0x35AFE70", VA = "0x1835B1270", Slot = "5")]
	public T[,] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public GDIHFPIMLCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class MLEPFBLAPEI<T> : CBFHJMOMLDG<T[,,]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3CB5480", Offset = "0x3CB4080", VA = "0x183CB5480", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T[,,] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3CB5040", Offset = "0x3CB3C40", VA = "0x183CB5040", Slot = "5")]
	public T[,,] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public MLEPFBLAPEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class EMIKMCILDED<T> : CBFHJMOMLDG<T[,,,]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x318BEB0", Offset = "0x318AAB0", VA = "0x18318BEB0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T[,,,] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x318B960", Offset = "0x318A560", VA = "0x18318B960", Slot = "5")]
	public T[,,,] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public EMIKMCILDED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class MKCMLDBEMFJ<T> : CBFHJMOMLDG<T?>, LKLKMMHABOC where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4500", Offset = "0x3CB3100", VA = "0x183CB4500", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4180", Offset = "0x3CB2D80", VA = "0x183CB4180", Slot = "5")]
	public T? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public MKCMLDBEMFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class LLHMBLJNIPC<T> : CBFHJMOMLDG<T?>, LKLKMMHABOC where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly CBFHJMOMLDG<T> GKJEFGDNFBG;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	public LLHMBLJNIPC(CBFHJMOMLDG<T> GKJEFGDNFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3A52FD0", Offset = "0x3A51BD0", VA = "0x183A52FD0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A52380", Offset = "0x3A50F80", VA = "0x183A52380", Slot = "5")]
	public T? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class IKCGDBIKNKP : CBFHJMOMLDG<sbyte>, LKLKMMHABOC, JGMIPKPABCI<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly IKCGDBIKNKP IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x65AFC30", Offset = "0x65AE830", VA = "0x1865AFC30", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, sbyte GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x65AFB70", Offset = "0x65AE770", VA = "0x1865AFB70", Slot = "5")]
	public sbyte JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x65AFBC0", Offset = "0x65AE7C0", VA = "0x1865AFBC0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, sbyte GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x65AFAB0", Offset = "0x65AE6B0", VA = "0x1865AFAB0", Slot = "7")]
	public sbyte DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public IKCGDBIKNKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class ABDEAOIKFBG : CBFHJMOMLDG<sbyte?>, LKLKMMHABOC, JGMIPKPABCI<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly ABDEAOIKFBG IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x65A2210", Offset = "0x65A0E10", VA = "0x1865A2210", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, sbyte? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x65A20A0", Offset = "0x65A0CA0", VA = "0x1865A20A0", Slot = "5")]
	public sbyte? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x65A2150", Offset = "0x65A0D50", VA = "0x1865A2150", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, sbyte? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x65A1F80", Offset = "0x65A0B80", VA = "0x1865A1F80", Slot = "7")]
	public sbyte? DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public ABDEAOIKFBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class AMDDHJACHDF : CBFHJMOMLDG<sbyte[]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly AMDDHJACHDF IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x65A4230", Offset = "0x65A2E30", VA = "0x1865A4230", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, sbyte[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x65A40A0", Offset = "0x65A2CA0", VA = "0x1865A40A0", Slot = "5")]
	public sbyte[] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public AMDDHJACHDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class HECFCPGPLCD : CBFHJMOMLDG<short>, LKLKMMHABOC, JGMIPKPABCI<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly HECFCPGPLCD IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x65AE2C0", Offset = "0x65ACEC0", VA = "0x1865AE2C0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, short GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x65AE200", Offset = "0x65ACE00", VA = "0x1865AE200", Slot = "5")]
	public short JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x65AE250", Offset = "0x65ACE50", VA = "0x1865AE250", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, short GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x65AE140", Offset = "0x65ACD40", VA = "0x1865AE140", Slot = "7")]
	public short DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public HECFCPGPLCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class GJMCFOHHODD : CBFHJMOMLDG<short?>, LKLKMMHABOC, JGMIPKPABCI<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly GJMCFOHHODD IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x65AD540", Offset = "0x65AC140", VA = "0x1865AD540", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, short? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x65AD3D0", Offset = "0x65ABFD0", VA = "0x1865AD3D0", Slot = "5")]
	public short? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x65AD480", Offset = "0x65AC080", VA = "0x1865AD480", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, short? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x65AD2B0", Offset = "0x65ABEB0", VA = "0x1865AD2B0", Slot = "7")]
	public short? DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public GJMCFOHHODD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class HOLNKAIFMGA : CBFHJMOMLDG<short[]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly HOLNKAIFMGA IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x65AF310", Offset = "0x65ADF10", VA = "0x1865AF310", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, short[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x65AF180", Offset = "0x65ADD80", VA = "0x1865AF180", Slot = "5")]
	public short[] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public HOLNKAIFMGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class PNGGGGHCGNK : CBFHJMOMLDG<int>, LKLKMMHABOC, JGMIPKPABCI<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly PNGGGGHCGNK IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x65B4270", Offset = "0x65B2E70", VA = "0x1865B4270", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, int GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x65B41B0", Offset = "0x65B2DB0", VA = "0x1865B41B0", Slot = "5")]
	public int JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x65B4200", Offset = "0x65B2E00", VA = "0x1865B4200", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, int GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x65B40F0", Offset = "0x65B2CF0", VA = "0x1865B40F0", Slot = "7")]
	public int DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public PNGGGGHCGNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class GECOFENNKHE : CBFHJMOMLDG<int?>, LKLKMMHABOC, JGMIPKPABCI<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly GECOFENNKHE IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x65AD170", Offset = "0x65ABD70", VA = "0x1865AD170", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, int? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x65AD000", Offset = "0x65ABC00", VA = "0x1865AD000", Slot = "5")]
	public int? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x65AD0B0", Offset = "0x65ABCB0", VA = "0x1865AD0B0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, int? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x65ACEE0", Offset = "0x65ABAE0", VA = "0x1865ACEE0", Slot = "7")]
	public int? DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public GECOFENNKHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class HCIMGILPOOC : CBFHJMOMLDG<int[]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly HCIMGILPOOC IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x65ADD30", Offset = "0x65AC930", VA = "0x1865ADD30", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, int[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x65ADBA0", Offset = "0x65AC7A0", VA = "0x1865ADBA0", Slot = "5")]
	public int[] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public HCIMGILPOOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class OHFCJLAJHDG : CBFHJMOMLDG<long>, LKLKMMHABOC, JGMIPKPABCI<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly OHFCJLAJHDG IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x65B3620", Offset = "0x65B2220", VA = "0x1865B3620", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, long GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x65B3560", Offset = "0x65B2160", VA = "0x1865B3560", Slot = "5")]
	public long JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x65B35B0", Offset = "0x65B21B0", VA = "0x1865B35B0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, long GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x65B34A0", Offset = "0x65B20A0", VA = "0x1865B34A0", Slot = "7")]
	public long DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public OHFCJLAJHDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class CECAEGMPKCF : CBFHJMOMLDG<long?>, LKLKMMHABOC, JGMIPKPABCI<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly CECAEGMPKCF IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x65A7180", Offset = "0x65A5D80", VA = "0x1865A7180", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, long? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x65A7000", Offset = "0x65A5C00", VA = "0x1865A7000", Slot = "5")]
	public long? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x65A70C0", Offset = "0x65A5CC0", VA = "0x1865A70C0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, long? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x65A6EC0", Offset = "0x65A5AC0", VA = "0x1865A6EC0", Slot = "7")]
	public long? DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public CECAEGMPKCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class MPJBIMOJIPH : CBFHJMOMLDG<long[]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly MPJBIMOJIPH IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x65B0FC0", Offset = "0x65AFBC0", VA = "0x1865B0FC0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, long[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x65B0E30", Offset = "0x65AFA30", VA = "0x1865B0E30", Slot = "5")]
	public long[] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public MPJBIMOJIPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class FEDPHBMGACN : CBFHJMOMLDG<byte>, LKLKMMHABOC, JGMIPKPABCI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly FEDPHBMGACN IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x65AC670", Offset = "0x65AB270", VA = "0x1865AC670", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, byte GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x65AC5B0", Offset = "0x65AB1B0", VA = "0x1865AC5B0", Slot = "5")]
	public byte JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x65AC600", Offset = "0x65AB200", VA = "0x1865AC600", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, byte GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x65AC4F0", Offset = "0x65AB0F0", VA = "0x1865AC4F0", Slot = "7")]
	public byte DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public FEDPHBMGACN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class POLBPPNEDIK : CBFHJMOMLDG<byte?>, LKLKMMHABOC, JGMIPKPABCI<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly POLBPPNEDIK IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x65B47E0", Offset = "0x65B33E0", VA = "0x1865B47E0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, byte? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x65B4670", Offset = "0x65B3270", VA = "0x1865B4670", Slot = "5")]
	public byte? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x65B4720", Offset = "0x65B3320", VA = "0x1865B4720", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, byte? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x65B4550", Offset = "0x65B3150", VA = "0x1865B4550", Slot = "7")]
	public byte? DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public POLBPPNEDIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class EDLLDNCGHID : CBFHJMOMLDG<ushort>, LKLKMMHABOC, JGMIPKPABCI<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly EDLLDNCGHID IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x65A9660", Offset = "0x65A8260", VA = "0x1865A9660", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ushort GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x65A95A0", Offset = "0x65A81A0", VA = "0x1865A95A0", Slot = "5")]
	public ushort JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x65A95F0", Offset = "0x65A81F0", VA = "0x1865A95F0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, ushort GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x65A94E0", Offset = "0x65A80E0", VA = "0x1865A94E0", Slot = "7")]
	public ushort DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public EDLLDNCGHID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class ELONPHDGMJB : CBFHJMOMLDG<ushort?>, LKLKMMHABOC, JGMIPKPABCI<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly ELONPHDGMJB IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x65AB470", Offset = "0x65AA070", VA = "0x1865AB470", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ushort? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x65AB300", Offset = "0x65A9F00", VA = "0x1865AB300", Slot = "5")]
	public ushort? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x65AB3B0", Offset = "0x65A9FB0", VA = "0x1865AB3B0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, ushort? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x65AB1E0", Offset = "0x65A9DE0", VA = "0x1865AB1E0", Slot = "7")]
	public ushort? DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public ELONPHDGMJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class AEACEIKHGJE : CBFHJMOMLDG<ushort[]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly AEACEIKHGJE IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x65A24E0", Offset = "0x65A10E0", VA = "0x1865A24E0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ushort[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x65A2350", Offset = "0x65A0F50", VA = "0x1865A2350", Slot = "5")]
	public ushort[] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public AEACEIKHGJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class HCJGDCIDLHA : CBFHJMOMLDG<uint>, LKLKMMHABOC, JGMIPKPABCI<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly HCJGDCIDLHA IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x65AE060", Offset = "0x65ACC60", VA = "0x1865AE060", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, uint GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x65ADFA0", Offset = "0x65ACBA0", VA = "0x1865ADFA0", Slot = "5")]
	public uint JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x65ADFF0", Offset = "0x65ACBF0", VA = "0x1865ADFF0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, uint GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x65ADEE0", Offset = "0x65ACAE0", VA = "0x1865ADEE0", Slot = "7")]
	public uint DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public HCJGDCIDLHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class OGIHKMIFGIJ : CBFHJMOMLDG<uint?>, LKLKMMHABOC, JGMIPKPABCI<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly OGIHKMIFGIJ IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x65B3360", Offset = "0x65B1F60", VA = "0x1865B3360", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, uint? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x65B31F0", Offset = "0x65B1DF0", VA = "0x1865B31F0", Slot = "5")]
	public uint? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x65B32A0", Offset = "0x65B1EA0", VA = "0x1865B32A0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, uint? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x65B30D0", Offset = "0x65B1CD0", VA = "0x1865B30D0", Slot = "7")]
	public uint? DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public OGIHKMIFGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class KPBHNEPDHIG : CBFHJMOMLDG<uint[]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly KPBHNEPDHIG IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x65B0270", Offset = "0x65AEE70", VA = "0x1865B0270", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, uint[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x65B00E0", Offset = "0x65AECE0", VA = "0x1865B00E0", Slot = "5")]
	public uint[] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public KPBHNEPDHIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class DIBPJHNFEFC : CBFHJMOMLDG<ulong>, LKLKMMHABOC, JGMIPKPABCI<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly DIBPJHNFEFC IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x65A86C0", Offset = "0x65A72C0", VA = "0x1865A86C0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ulong GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x65A8600", Offset = "0x65A7200", VA = "0x1865A8600", Slot = "5")]
	public ulong JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x65A8650", Offset = "0x65A7250", VA = "0x1865A8650", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, ulong GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x65A8540", Offset = "0x65A7140", VA = "0x1865A8540", Slot = "7")]
	public ulong DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public DIBPJHNFEFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class ECGIFGAJCNH : CBFHJMOMLDG<ulong?>, LKLKMMHABOC, JGMIPKPABCI<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly ECGIFGAJCNH IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x65A93A0", Offset = "0x65A7FA0", VA = "0x1865A93A0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ulong? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x65A9220", Offset = "0x65A7E20", VA = "0x1865A9220", Slot = "5")]
	public ulong? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x65A92E0", Offset = "0x65A7EE0", VA = "0x1865A92E0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, ulong? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x65A90E0", Offset = "0x65A7CE0", VA = "0x1865A90E0", Slot = "7")]
	public ulong? DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public ECGIFGAJCNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class GNCIFHFCDBJ : CBFHJMOMLDG<ulong[]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly GNCIFHFCDBJ IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x65AD9F0", Offset = "0x65AC5F0", VA = "0x1865AD9F0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ulong[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x65AD860", Offset = "0x65AC460", VA = "0x1865AD860", Slot = "5")]
	public ulong[] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public GNCIFHFCDBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class CACJBHGGNOH : CBFHJMOMLDG<float>, LKLKMMHABOC, JGMIPKPABCI<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly CACJBHGGNOH IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x65A6DE0", Offset = "0x65A59E0", VA = "0x1865A6DE0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, float GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x65A6D20", Offset = "0x65A5920", VA = "0x1865A6D20", Slot = "5")]
	public float JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x65A6D70", Offset = "0x65A5970", VA = "0x1865A6D70", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, float GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x65A6C60", Offset = "0x65A5860", VA = "0x1865A6C60", Slot = "7")]
	public float DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public CACJBHGGNOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class KIIHMGJCNLJ : CBFHJMOMLDG<float?>, LKLKMMHABOC, JGMIPKPABCI<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly KIIHMGJCNLJ IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x65AFFA0", Offset = "0x65AEBA0", VA = "0x1865AFFA0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, float? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x65AFE30", Offset = "0x65AEA30", VA = "0x1865AFE30", Slot = "5")]
	public float? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x65AFEE0", Offset = "0x65AEAE0", VA = "0x1865AFEE0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, float? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x65AFD10", Offset = "0x65AE910", VA = "0x1865AFD10", Slot = "7")]
	public float? DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public KIIHMGJCNLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class EFLHEHBGDFB : CBFHJMOMLDG<float[]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly EFLHEHBGDFB IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x65A9AE0", Offset = "0x65A86E0", VA = "0x1865A9AE0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, float[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x65A9950", Offset = "0x65A8550", VA = "0x1865A9950", Slot = "5")]
	public float[] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public EFLHEHBGDFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class PGJCNBHBOKC : CBFHJMOMLDG<double>, LKLKMMHABOC, JGMIPKPABCI<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly PGJCNBHBOKC IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x65B4010", Offset = "0x65B2C10", VA = "0x1865B4010", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, double GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x65B3F50", Offset = "0x65B2B50", VA = "0x1865B3F50", Slot = "5")]
	public double JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x65B3FA0", Offset = "0x65B2BA0", VA = "0x1865B3FA0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, double GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x65B3E90", Offset = "0x65B2A90", VA = "0x1865B3E90", Slot = "7")]
	public double DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public PGJCNBHBOKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class ECFEFFKBAHP : CBFHJMOMLDG<double?>, LKLKMMHABOC, JGMIPKPABCI<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly ECFEFFKBAHP IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x65A8FA0", Offset = "0x65A7BA0", VA = "0x1865A8FA0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, double? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x65A8E20", Offset = "0x65A7A20", VA = "0x1865A8E20", Slot = "5")]
	public double? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x65A8EE0", Offset = "0x65A7AE0", VA = "0x1865A8EE0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, double? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x65A8CE0", Offset = "0x65A78E0", VA = "0x1865A8CE0", Slot = "7")]
	public double? DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public ECFEFFKBAHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class DPLMDEKLGGC : CBFHJMOMLDG<double[]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly DPLMDEKLGGC IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x65A8B20", Offset = "0x65A7720", VA = "0x1865A8B20", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, double[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x65A8990", Offset = "0x65A7590", VA = "0x1865A8990", Slot = "5")]
	public double[] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public DPLMDEKLGGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class FBCMOPEFFIG : CBFHJMOMLDG<bool>, LKLKMMHABOC, JGMIPKPABCI<bool>
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly FBCMOPEFFIG IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x65AC230", Offset = "0x65AAE30", VA = "0x1865AC230", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, bool GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x65AC170", Offset = "0x65AAD70", VA = "0x1865AC170", Slot = "5")]
	public bool JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x65AC1C0", Offset = "0x65AADC0", VA = "0x1865AC1C0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, bool GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x65AC0B0", Offset = "0x65AACB0", VA = "0x1865AC0B0", Slot = "7")]
	public bool DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public FBCMOPEFFIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class IBOICPFHKKL : CBFHJMOMLDG<bool?>, LKLKMMHABOC, JGMIPKPABCI<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly IBOICPFHKKL IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x65AF750", Offset = "0x65AE350", VA = "0x1865AF750", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, bool? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x65AF5E0", Offset = "0x65AE1E0", VA = "0x1865AF5E0", Slot = "5")]
	public bool? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x65AF690", Offset = "0x65AE290", VA = "0x1865AF690", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, bool? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x65AF4C0", Offset = "0x65AE0C0", VA = "0x1865AF4C0", Slot = "7")]
	public bool? DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public IBOICPFHKKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class LIBIJHLPLJM : CBFHJMOMLDG<bool[]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly LIBIJHLPLJM IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x65B09D0", Offset = "0x65AF5D0", VA = "0x1865B09D0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, bool[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x65B0840", Offset = "0x65AF440", VA = "0x1865B0840", Slot = "5")]
	public bool[] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public LIBIJHLPLJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class BLALEGBJNCA : CBFHJMOMLDG<object>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly CBFHJMOMLDG<object> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly Dictionary<Type, int> GICINNIMFPI;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x65A5A00", Offset = "0x65A4600", VA = "0x1865A5A00", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, object GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x65A55C0", Offset = "0x65A41C0", VA = "0x1865A55C0", Slot = "5")]
	public object JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public BLALEGBJNCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class DJIGHBCOJHA : CBFHJMOMLDG<byte[]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly CBFHJMOMLDG<byte[]> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x65A8850", Offset = "0x65A7450", VA = "0x1865A8850", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, byte[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x65A87A0", Offset = "0x65A73A0", VA = "0x1865A87A0", Slot = "5")]
	public byte[] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public DJIGHBCOJHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class OKNKKDADIGA : CBFHJMOMLDG<ArraySegment<byte>>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly CBFHJMOMLDG<ArraySegment<byte>> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x65B3810", Offset = "0x65B2410", VA = "0x1865B3810", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ArraySegment<byte> GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x65B3700", Offset = "0x65B2300", VA = "0x1865B3700", Slot = "5")]
	public ArraySegment<byte> JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public OKNKKDADIGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class GNAJHOOJLBI : CBFHJMOMLDG<string>, LKLKMMHABOC, JGMIPKPABCI<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly CBFHJMOMLDG<string> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x65AD780", Offset = "0x65AC380", VA = "0x1865AD780", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, string GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x65AD6D0", Offset = "0x65AC2D0", VA = "0x1865AD6D0", Slot = "5")]
	public string JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x65AD720", Offset = "0x65AC320", VA = "0x1865AD720", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, string GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x65AD680", Offset = "0x65AC280", VA = "0x1865AD680", Slot = "7")]
	public string DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public GNAJHOOJLBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class NAAINKNGCPI : CBFHJMOMLDG<string[]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly NAAINKNGCPI IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x65B1340", Offset = "0x65AFF40", VA = "0x1865B1340", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, string[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x65B1170", Offset = "0x65AFD70", VA = "0x1865B1170", Slot = "5")]
	public string[] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public NAAINKNGCPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class BOCACAGLMMN : CBFHJMOMLDG<char>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly BOCACAGLMMN IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x65A6B20", Offset = "0x65A5720", VA = "0x1865A6B20", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, char GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x65A6AB0", Offset = "0x65A56B0", VA = "0x1865A6AB0", Slot = "5")]
	public char JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public BOCACAGLMMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class MAHDHHDJLEG : CBFHJMOMLDG<char?>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly MAHDHHDJLEG IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x65B0CB0", Offset = "0x65AF8B0", VA = "0x1865B0CB0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, char? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x65B0B90", Offset = "0x65AF790", VA = "0x1865B0B90", Slot = "5")]
	public char? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public MAHDHHDJLEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class HOGHBMIDCFF : CBFHJMOMLDG<char[]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly HOGHBMIDCFF IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x65AE950", Offset = "0x65AD550", VA = "0x1865AE950", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, char[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x65AE790", Offset = "0x65AD390", VA = "0x1865AE790", Slot = "5")]
	public char[] JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public HOGHBMIDCFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class LFDIHDHACCF : CBFHJMOMLDG<Guid>, LKLKMMHABOC, JGMIPKPABCI<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly CBFHJMOMLDG<Guid> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x65B0690", Offset = "0x65AF290", VA = "0x1865B0690", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Guid GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x65B04C0", Offset = "0x65AF0C0", VA = "0x1865B04C0", Slot = "5")]
	public Guid JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x65B0550", Offset = "0x65AF150", VA = "0x1865B0550", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, Guid GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x65B0420", Offset = "0x65AF020", VA = "0x1865B0420", Slot = "7")]
	public Guid DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public LFDIHDHACCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class PEPAJLBCLKM : CBFHJMOMLDG<decimal>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly CBFHJMOMLDG<decimal> IJJIHHKLCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private readonly bool EGDLCNLFPJD;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x502E940", Offset = "0x502D540", VA = "0x18502E940")]
	public PEPAJLBCLKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x16DA440", Offset = "0x16D9040", VA = "0x1816DA440")]
	public PEPAJLBCLKM(bool EGDLCNLFPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x65B3C60", Offset = "0x65B2860", VA = "0x1865B3C60", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, decimal GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x65B39C0", Offset = "0x65B25C0", VA = "0x1865B39C0", Slot = "5")]
	public decimal JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class IDBCHONELKP : CBFHJMOMLDG<Uri>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly CBFHJMOMLDG<Uri> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x65AF950", Offset = "0x65AE550", VA = "0x1865AF950", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Uri GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x65AF890", Offset = "0x65AE490", VA = "0x1865AF890", Slot = "5")]
	public Uri JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public IDBCHONELKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class PNGLOELNNKL : CBFHJMOMLDG<Version>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly CBFHJMOMLDG<Version> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x65B4410", Offset = "0x65B3010", VA = "0x1865B4410", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Version GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x65B4350", Offset = "0x65B2F50", VA = "0x1865B4350", Slot = "5")]
	public Version JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public PNGLOELNNKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class IBAJLEFAJCG<TKey, TValue> : CBFHJMOMLDG<KeyValuePair<TKey, TValue>>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x370A820", Offset = "0x3709420", VA = "0x18370A820", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, KeyValuePair<TKey, TValue> GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x370A4F0", Offset = "0x37090F0", VA = "0x18370A4F0", Slot = "5")]
	public KeyValuePair<TKey, TValue> JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class FBNPPIKMFGN : CBFHJMOMLDG<StringBuilder>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly CBFHJMOMLDG<StringBuilder> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x65AC3D0", Offset = "0x65AAFD0", VA = "0x1865AC3D0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, StringBuilder GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x65AC310", Offset = "0x65AAF10", VA = "0x1865AC310", Slot = "5")]
	public StringBuilder JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public FBNPPIKMFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class NNAGEBFPBHN : CBFHJMOMLDG<BitArray>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly CBFHJMOMLDG<BitArray> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x65B1670", Offset = "0x65B0270", VA = "0x1865B1670", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, BitArray GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x65B14F0", Offset = "0x65B00F0", VA = "0x1865B14F0", Slot = "5")]
	public BitArray JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public NNAGEBFPBHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class COAMDEKGOAP : CBFHJMOMLDG<Type>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly COAMDEKGOAP IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly Regex OGIOFFDLLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private bool OLAJIGPMGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private bool IBBKHHMMELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private bool LIKEDFKHOML;

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x65A7610", Offset = "0x65A6210", VA = "0x1865A7610")]
	public COAMDEKGOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D37F90", Offset = "0x5D36B90", VA = "0x185D37F90")]
	public COAMDEKGOAP(bool OLAJIGPMGIC, bool IBBKHHMMELD, bool LIKEDFKHOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x65A7410", Offset = "0x65A6010", VA = "0x1865A7410", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Type GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x65A72C0", Offset = "0x65A5EC0", VA = "0x1865A72C0", Slot = "5")]
	public Type JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal static class HGPIHNHJBHE
{
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal static readonly byte[][] BNGIBILBFNA;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal static readonly DBPCFPGMCBB KDCIKLOMKHK;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x65AE3A0", Offset = "0x65ACFA0", VA = "0x1865AE3A0")]
	static HGPIHNHJBHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class EFCAACEKOHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal static readonly byte[][] CBELHKJJNBO;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal static readonly DBPCFPGMCBB AJLIFHOHPJO;

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x65A9740", Offset = "0x65A8340", VA = "0x1865A9740")]
	static EFCAACEKOHJ()
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
