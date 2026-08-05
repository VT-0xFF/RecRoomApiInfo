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
	[Cpp2IlInjected.Address(RVA = "0x657D870", Offset = "0x657C470", VA = "0x18657D870")]
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
	[Cpp2IlInjected.Address(RVA = "0x23C8AE0", Offset = "0x23C76E0", VA = "0x1823C8AE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B12760", Offset = "0x2B11360", VA = "0x182B12760")]
	public static CBFHJMOMLDG<T> CCFGAHFNHKB<T>(this KJHGDFDBIIA AJMNHAEOIAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x656C480", Offset = "0x656B080", VA = "0x18656C480")]
	public static object PLHOKIHFBGD(this KJHGDFDBIIA AJMNHAEOIAA, Type OMKEAAPIABA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NHLBIPGDMFD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6585B80", Offset = "0x6584780", VA = "0x186585B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6588210", Offset = "0x6586E10", VA = "0x186588210")]
		public static byte[] HHMJKHMNGNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x65882B0", Offset = "0x6586EB0", VA = "0x1865882B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x65791A0", Offset = "0x6577DA0", VA = "0x1865791A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x657BC40", Offset = "0x657A840", VA = "0x18657BC40")]
	public EPGBDNIILDN(byte[] FEGEJBFJFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x657BAE0", Offset = "0x657A6E0", VA = "0x18657BAE0")]
	public EPGBDNIILDN(byte[] FEGEJBFJFNG, int IAKOFEGDGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x65794C0", Offset = "0x65780C0", VA = "0x1865794C0")]
	private MAOBNNJNPHF GEJHLOEBKHA(string GLFGEBKCMID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x657B450", Offset = "0x657A050", VA = "0x18657B450")]
	private MAOBNNJNPHF NPHBOLOLOFK(string EOOPGFAEMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6577080", Offset = "0x6575C80", VA = "0x186577080")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CDC940", Offset = "0x1CDB540", VA = "0x181CDC940")]
	public int EEDNNLLAKJG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x657A730", Offset = "0x6579330", VA = "0x18657A730")]
	public LMNEBLINOHL KKOKHDJKGPL()
	{
		return default(LMNEBLINOHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x657B060", Offset = "0x6579C60", VA = "0x18657B060")]
	public void NCNFEAAJFIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x657A970", Offset = "0x6579570", VA = "0x18657A970")]
	public bool LBKAJIHHFFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6578810", Offset = "0x6577410", VA = "0x186578810")]
	public bool ACKGEOIHKAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x657B660", Offset = "0x657A260", VA = "0x18657B660")]
	public void OGHOCOLIPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x657AA90", Offset = "0x6579690", VA = "0x18657AA90")]
	public bool LJDKMKIHLAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6579DF0", Offset = "0x65789F0", VA = "0x186579DF0")]
	public bool JMHLOEPODND(int EMHEDPDPEMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x657B850", Offset = "0x657A450", VA = "0x18657B850")]
	public bool PDPHOLPBFHF(int EMHEDPDPEMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x65791C0", Offset = "0x6577DC0", VA = "0x1865791C0")]
	public bool EMCJLAIGLHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6579A10", Offset = "0x6578610", VA = "0x186579A10")]
	public void GGFDEBJPFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x657A8E0", Offset = "0x65794E0", VA = "0x18657A8E0")]
	public bool KOAHJBIKPCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6579EC0", Offset = "0x6578AC0", VA = "0x186579EC0")]
	public bool JOLEEFDLEDJ(int EMHEDPDPEMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6578CF0", Offset = "0x65778F0", VA = "0x186578CF0")]
	public bool BMNEJABCPAB(int EMHEDPDPEMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x657B700", Offset = "0x657A300", VA = "0x18657B700")]
	public bool OOIHCOMHPKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x65788A0", Offset = "0x65774A0", VA = "0x1865788A0")]
	public void AHDOOLJILGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6579110", Offset = "0x6577D10", VA = "0x186579110")]
	public bool EIOOLLIPDGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x657B920", Offset = "0x657A520", VA = "0x18657B920")]
	public void PHKDOBFOPNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6579F90", Offset = "0x6578B90", VA = "0x186579F90")]
	private void KGMOKCOJMMB([Out] byte[] INFGLCNPHPK, [Out] int PFAFIOFLDEJ, [Out] int HLBACCFLAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6579310", Offset = "0x6577F10", VA = "0x186579310")]
	private static int FFEHFIPEDML(char FLGIINLNNEM, char KNDAEONALIC, char KIHBPBFELGP, char DKFOONILOPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x657AF00", Offset = "0x6579B00", VA = "0x18657AF00")]
	private static int MJGPINIJNHA(char HPIMCNPJDMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x657B540", Offset = "0x657A140", VA = "0x18657B540")]
	public ArraySegment<byte> OFPHMEBBDEB()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6579D10", Offset = "0x6578910", VA = "0x186579D10")]
	public string IGOIJNCEPFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6579CA0", Offset = "0x65788A0", VA = "0x186579CA0")]
	public string IGGGPIIKBDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x657AB20", Offset = "0x6579720", VA = "0x18657AB20")]
	public ArraySegment<byte> MGLBEDNCGJB()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x657B3E0", Offset = "0x6579FE0", VA = "0x18657B3E0")]
	public ArraySegment<byte> NNAKOEIJDLO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x657B190", Offset = "0x6579D90", VA = "0x18657B190")]
	public bool NKEBNJGIMGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6579250", Offset = "0x6577E50", VA = "0x186579250")]
	private static bool FDEMDOKFNCK(byte KIHBPBFELGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6578AA0", Offset = "0x65776A0", VA = "0x186578AA0")]
	private void AIEBHHODBPL(LMNEBLINOHL KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6579040", Offset = "0x6577C40", VA = "0x186579040")]
	public void EEPMHNDJOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6578940", Offset = "0x6577540", VA = "0x186578940")]
	private void AHEMDBCBAAH(int FIACJKMJIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6578EC0", Offset = "0x6577AC0", VA = "0x186578EC0")]
	public sbyte CHMJCBCDPPL()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6579AB0", Offset = "0x65786B0", VA = "0x186579AB0")]
	public short HCDIJGBANMG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x657AFE0", Offset = "0x6579BE0", VA = "0x18657AFE0")]
	public int MLJMMPOIAEI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x657B790", Offset = "0x657A390", VA = "0x18657B790")]
	public long PDFAPFMJCNA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6579090", Offset = "0x6577C90", VA = "0x186579090")]
	public byte EGMGFOCJNCK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6578DC0", Offset = "0x65779C0", VA = "0x186578DC0")]
	public ushort BMOMAHHBDPF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6578E40", Offset = "0x6577A40", VA = "0x186578E40")]
	public uint CFIPKEMCFJB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x657AD40", Offset = "0x6579940", VA = "0x18657AD40")]
	public ulong MIBHGPJPIOM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x65793C0", Offset = "0x6577FC0", VA = "0x1865793C0")]
	public float FMEHOAGPDNL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6578F40", Offset = "0x6577B40", VA = "0x186578F40")]
	public double DJBBLBLLGLM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x657AE00", Offset = "0x6579A00", VA = "0x18657AE00")]
	public ArraySegment<byte> MJBMLEGCHPE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6579B30", Offset = "0x6578730", VA = "0x186579B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x6583CE0", Offset = "0x65828E0", VA = "0x186583CE0")]
	public MAOBNNJNPHF(string EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6583D40", Offset = "0x6582940", VA = "0x186583D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x657E0F0", Offset = "0x657CCF0", VA = "0x18657E0F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3C8D8C0", Offset = "0x3C8C4C0", VA = "0x183C8D8C0")]
				internal bool IENGEDNFHJK(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x657BCA0", Offset = "0x657A8A0", VA = "0x18657BCA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6585E30", Offset = "0x6584A30", VA = "0x186585E30")]
			public NKCPIGEJHCC(Type OMKEAAPIABA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2ADD3D0", Offset = "0x2ADBFD0", VA = "0x182ADD3D0")]
			private static T IBPDCDIGIND<T>(DynamicMethod MNGGLEJNCMN)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6585BE0", Offset = "0x65847E0", VA = "0x186585BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x656CD80", Offset = "0x656B980", VA = "0x18656CD80")]
		static BHPFLFHMPEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x656CA70", Offset = "0x656B670", VA = "0x18656CA70")]
		private static NKCPIGEJHCC OCMJLJAHBBI(Type OMKEAAPIABA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x656CAF0", Offset = "0x656B6F0", VA = "0x18656CAF0")]
		public static void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, object GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x656CC70", Offset = "0x656B870", VA = "0x18656CC70")]
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
		[Cpp2IlInjected.Address(RVA = "0x657C290", Offset = "0x657AE90", VA = "0x18657C290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool BKIHKFDKCKN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x657CD70", Offset = "0x657B970", VA = "0x18657CD70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x657CD00", Offset = "0x657B900", VA = "0x18657CD00")]
	public static void NEFGODEHICP(KJHGDFDBIIA AJMNHAEOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x24E1110", Offset = "0x24DFD10", VA = "0x1824E1110")]
	public static byte[] OIIEHDKDHEB<T>(T IIFJCGIHMIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x24E0E70", Offset = "0x24DFA70", VA = "0x1824E0E70")]
	public static byte[] OIIEHDKDHEB<T>(T GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x24E0FF0", Offset = "0x24DFBF0", VA = "0x1824E0FF0")]
	public static void OIIEHDKDHEB<T>(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x24E1190", Offset = "0x24DFD90", VA = "0x1824E1190")]
	public static void OIIEHDKDHEB<T>(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x24E1080", Offset = "0x24DFC80", VA = "0x1824E1080")]
	public static void OIIEHDKDHEB<T>(Stream BOOOCBOEPIH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x24E0D30", Offset = "0x24DF930", VA = "0x1824E0D30")]
	public static void OIIEHDKDHEB<T>(Stream BOOOCBOEPIH, T GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x24E1270", Offset = "0x24DFE70", VA = "0x1824E1270")]
	public static ArraySegment<byte> PBOGHPEMMHL<T>(T IIFJCGIHMIN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x24E1300", Offset = "0x24DFF00", VA = "0x1824E1300")]
	public static ArraySegment<byte> PBOGHPEMMHL<T>(T GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x24E0CB0", Offset = "0x24DF8B0", VA = "0x1824E0CB0")]
	public static string NAFNJJEAGFC<T>(T GCPEEAODAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x24E0B30", Offset = "0x24DF730", VA = "0x1824E0B30")]
	public static string NAFNJJEAGFC<T>(T GCPEEAODAIB, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x24E0250", Offset = "0x24DEE50", VA = "0x1824E0250")]
	public static T JFKFFNFOIMD<T>(string MFADGLMMHMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24E02E0", Offset = "0x24DEEE0", VA = "0x1824E02E0")]
	public static T JFKFFNFOIMD<T>(string MFADGLMMHMB, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x24E0450", Offset = "0x24DF050", VA = "0x1824E0450")]
	public static T JFKFFNFOIMD<T>(byte[] FEGEJBFJFNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x24E0030", Offset = "0x24DEC30", VA = "0x1824E0030")]
	public static T JFKFFNFOIMD<T>(byte[] FEGEJBFJFNG, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x24E0770", Offset = "0x24DF370", VA = "0x1824E0770")]
	public static T JFKFFNFOIMD<T>(byte[] FEGEJBFJFNG, int IAKOFEGDGBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x24E00C0", Offset = "0x24DECC0", VA = "0x1824E00C0")]
	public static T JFKFFNFOIMD<T>(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x24E0940", Offset = "0x24DF540", VA = "0x1824E0940")]
	public static T JFKFFNFOIMD<T>(EPGBDNIILDN BIBCAMINPDH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24E05A0", Offset = "0x24DF1A0", VA = "0x1824E05A0")]
	public static T JFKFFNFOIMD<T>(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x24E0670", Offset = "0x24DF270", VA = "0x1824E0670")]
	public static T JFKFFNFOIMD<T>(Stream BOOOCBOEPIH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x24E0800", Offset = "0x24DF400", VA = "0x1824E0800")]
	public static T JFKFFNFOIMD<T>(Stream BOOOCBOEPIH, KJHGDFDBIIA AJMNHAEOIAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x657C130", Offset = "0x657AD30", VA = "0x18657C130")]
	public static string BGCPOOKOCNC(byte[] MFADGLMMHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x657BFF0", Offset = "0x657ABF0", VA = "0x18657BFF0")]
	public static string BGCPOOKOCNC(byte[] MFADGLMMHMB, int IAKOFEGDGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x657BE60", Offset = "0x657AA60", VA = "0x18657BE60")]
	public static string BGCPOOKOCNC(string MFADGLMMHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x657CF20", Offset = "0x657BB20", VA = "0x18657CF20")]
	public static byte[] OOLLGGJDJOF(byte[] MFADGLMMHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x657CDD0", Offset = "0x657B9D0", VA = "0x18657CDD0")]
	public static byte[] OOLLGGJDJOF(byte[] MFADGLMMHMB, int IAKOFEGDGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x657D0A0", Offset = "0x657BCA0", VA = "0x18657D0A0")]
	public static byte[] OOLLGGJDJOF(string MFADGLMMHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x657C430", Offset = "0x657B030", VA = "0x18657C430")]
	private static void NAELDMNDEDF(EPGBDNIILDN BIBCAMINPDH, CJMDLGBHBBN BNGNOICJJGA, int OLLFIMGHMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x657C390", Offset = "0x657AF90", VA = "0x18657C390")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CDC940", Offset = "0x1CDB540", VA = "0x181CDC940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6577080", Offset = "0x6575C80", VA = "0x186577080")]
	public void NDJDGAJJDOP(int IAKOFEGDGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6576890", Offset = "0x6575490", VA = "0x186576890")]
	public static byte[] LFENGJFDJJF(string DKLHENCIMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6576290", Offset = "0x6574E90", VA = "0x186576290")]
	public static byte[] HDENEKIAIBM(string DKLHENCIMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x65765E0", Offset = "0x65751E0", VA = "0x1865765E0")]
	public static byte[] KIABIOMJPDD(string DKLHENCIMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6576B70", Offset = "0x6575770", VA = "0x186576B70")]
	public static byte[] MJKANOPDBLM(string DKLHENCIMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x538EC80", Offset = "0x538D880", VA = "0x18538EC80")]
	public CJMDLGBHBBN(byte[] DEEDOADFNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6576400", Offset = "0x6575000", VA = "0x186576400")]
	public ArraySegment<byte> HHMJKHMNGNG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x65771F0", Offset = "0x6575DF0", VA = "0x1865771F0")]
	public byte[] PILAOFMJBOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x65772B0", Offset = "0x6575EB0", VA = "0x1865772B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6576280", Offset = "0x6574E80", VA = "0x186576280")]
	public void GFMENOKGFNH(int LKLPIFOHKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x65767D0", Offset = "0x65753D0", VA = "0x1865767D0")]
	public void LAHHBPDJAMN(byte MEJEJMPMGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6576830", Offset = "0x6575430", VA = "0x186576830")]
	public void LAHHBPDJAMN(byte[] MEJEJMPMGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6576160", Offset = "0x6574D60", VA = "0x186576160")]
	public void EDGJLBFAAJK(byte MEJEJMPMGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6577260", Offset = "0x6575E60", VA = "0x186577260")]
	public void PKMPLJIJOBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6576040", Offset = "0x6574C40", VA = "0x186576040")]
	public void BBPADFEHNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6576560", Offset = "0x6575160", VA = "0x186576560")]
	public void JHHLHCJHMJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x65764A0", Offset = "0x65750A0", VA = "0x1865764A0")]
	public void HNJKNADMDPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6575E90", Offset = "0x6574A90", VA = "0x186575E90")]
	public void AJCNIOLKEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x65760C0", Offset = "0x6574CC0", VA = "0x1865760C0")]
	public void CHNHDACOIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6576AD0", Offset = "0x65756D0", VA = "0x186576AD0")]
	public void MGIAJOPBPCA(string DKLHENCIMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6576110", Offset = "0x6574D10", VA = "0x186576110")]
	public void DFGHKGPPHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6576A30", Offset = "0x6575630", VA = "0x186576A30")]
	public void MEGMFEDPGAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6575EE0", Offset = "0x6574AE0", VA = "0x186575EE0")]
	public void AOIKEBCNFEL(bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6576750", Offset = "0x6575350", VA = "0x186576750")]
	public void KNLODJLIHPP(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6577090", Offset = "0x6575C90", VA = "0x186577090")]
	public void ODEMJCGFOEL(double GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6577180", Offset = "0x6575D80", VA = "0x186577180")]
	public void PBJOMMIKBGG(byte GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6576210", Offset = "0x6574E10", VA = "0x186576210")]
	public void FGLNJMPHFDH(ushort GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6577110", Offset = "0x6575D10", VA = "0x186577110")]
	public void OIGDGMJLBGA(uint GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6576090", Offset = "0x6574C90", VA = "0x186576090")]
	public void CHGOFFFENEB(ulong GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x65761A0", Offset = "0x6574DA0", VA = "0x1865761A0")]
	public void ENCIAHGDCDG(sbyte GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x65764F0", Offset = "0x65750F0", VA = "0x1865764F0")]
	public void IOIHHJJPHMI(short GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x65769C0", Offset = "0x65755C0", VA = "0x1865769C0")]
	public void LGOIFMLMELM(int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x65765B0", Offset = "0x65751B0", VA = "0x1865765B0")]
	public void JNMHPCEDPEB(long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6576CF0", Offset = "0x65758F0", VA = "0x186576CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x450D390", Offset = "0x450BF90", VA = "0x18450D390")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x656D6C0", Offset = "0x656C2C0", VA = "0x18656D6C0")]
	static BPAIDLFHBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x656CED0", Offset = "0x656BAD0", VA = "0x18656CED0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6581350", Offset = "0x657FF50", VA = "0x186581350")]
	public KPNBIOEFFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6581160", Offset = "0x657FD60", VA = "0x186581160", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Vector2 GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6580E70", Offset = "0x657FA70", VA = "0x186580E70", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6577970", Offset = "0x6576570", VA = "0x186577970")]
	public DGCLHCGENNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x65776D0", Offset = "0x65762D0", VA = "0x1865776D0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Vector3 GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6577380", Offset = "0x6575F80", VA = "0x186577380", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x657E860", Offset = "0x657D460", VA = "0x18657E860")]
	public IHJGHAJLJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x657E520", Offset = "0x657D120", VA = "0x18657E520", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Vector4 GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x657E190", Offset = "0x657CD90", VA = "0x18657E190", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6578330", Offset = "0x6576F30", VA = "0x186578330")]
	public DPNBLGBCAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6577FF0", Offset = "0x6576BF0", VA = "0x186577FF0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Quaternion GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6577C60", Offset = "0x6576860", VA = "0x186577C60", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6581D00", Offset = "0x6580900", VA = "0x186581D00")]
	public LNALBCEGDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x65819C0", Offset = "0x65805C0", VA = "0x1865819C0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Color GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6581630", Offset = "0x6580230", VA = "0x186581630", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6588030", Offset = "0x6586C30", VA = "0x186588030")]
	public OBOELGAKLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6587D10", Offset = "0x6586910", VA = "0x186587D10", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Bounds GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6587930", Offset = "0x6586530", VA = "0x186587930", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6588AB0", Offset = "0x65876B0", VA = "0x186588AB0")]
	public OHJENJAOBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6588740", Offset = "0x6587340", VA = "0x186588740", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Rect GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6588350", Offset = "0x6586F50", VA = "0x186588350", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3681B80", Offset = "0x3680780", VA = "0x183681B80")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x373B800", Offset = "0x373A400", VA = "0x18373B800")]
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
		[Cpp2IlInjected.Address(RVA = "0x657EFC0", Offset = "0x657DBC0", VA = "0x18657EFC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3678B80", Offset = "0x3677780", VA = "0x183678B80")]
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
	[Cpp2IlInjected.Address(RVA = "0x657D980", Offset = "0x657C580", VA = "0x18657D980")]
	public static void CFNGGCOIEBP(params KJHGDFDBIIA[] GCANGOFMGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x657D8A0", Offset = "0x657C4A0", VA = "0x18657D8A0")]
	public static void CFNGGCOIEBP(params LKLKMMHABOC[] HGPAEMINPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x657DA60", Offset = "0x657C660", VA = "0x18657DA60")]
	public static void MIMPMCANFAL(LKLKMMHABOC[] HGPAEMINPMB, KJHGDFDBIIA[] GCANGOFMGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D2E780", Offset = "0x3D2D380", VA = "0x183D2E780")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6581FF0", Offset = "0x6580BF0", VA = "0x186581FF0")]
	internal static object EPFAOKPIMBK(Type GHKAOLMKPMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6583750", Offset = "0x6582350", VA = "0x186583750")]
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
		[Cpp2IlInjected.Address(RVA = "0x467C340", Offset = "0x467AF40", VA = "0x18467C340")]
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
	[Cpp2IlInjected.Address(RVA = "0x657EB50", Offset = "0x657D750", VA = "0x18657EB50")]
	static IHNLLCIOHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private IHNLLCIOHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E4D690", Offset = "0x4E4C290", VA = "0x184E4D690")]
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
	[Cpp2IlInjected.Address(RVA = "0x6588F10", Offset = "0x6587B10", VA = "0x186588F10")]
	static PJJJADPLMJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private PJJJADPLMJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x38E3770", Offset = "0x38E2370", VA = "0x1838E3770")]
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
	[Cpp2IlInjected.Address(RVA = "0x657DF80", Offset = "0x657CB80", VA = "0x18657DF80")]
	static HDNEANKPGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private HDNEANKPGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x315C6F0", Offset = "0x315B2F0", VA = "0x18315C6F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x657DE10", Offset = "0x657CA10", VA = "0x18657DE10")]
	static GPJPNJHNNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private GPJPNJHNNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x49645D0", Offset = "0x49631D0", VA = "0x1849645D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6588DA0", Offset = "0x65879A0", VA = "0x186588DA0")]
	static OOEEDPMMNNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private OOEEDPMMNNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CBF4A0", Offset = "0x3CBE0A0", VA = "0x183CBF4A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x65786A0", Offset = "0x65772A0", VA = "0x1865786A0")]
	static EMFDINEFKPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	private EMFDINEFKPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C76E10", Offset = "0x4C75A10", VA = "0x184C76E10")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x34E7270", Offset = "0x34E5E70", VA = "0x1834E7270")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x34DAE80", Offset = "0x34D9A80", VA = "0x1834DAE80")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C5D580", Offset = "0x3C5C180", VA = "0x183C5D580")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x39C9830", Offset = "0x39C8430", VA = "0x1839C9830")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DEAF10", Offset = "0x3DE9B10", VA = "0x183DEAF10")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x659E040", Offset = "0x659CC40", VA = "0x18659E040")]
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
			[Cpp2IlInjected.Address(RVA = "0x658FB20", Offset = "0x658E720", VA = "0x18658FB20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6584300", Offset = "0x6582F00", VA = "0x186584300")]
		public static MethodInfo OIIEHDKDHEB(Type OMKEAAPIABA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6583F90", Offset = "0x6582B90", VA = "0x186583F90")]
		public static MethodInfo JFKFFNFOIMD(Type OMKEAAPIABA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x65841D0", Offset = "0x6582DD0", VA = "0x1865841D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658F150", Offset = "0x658DD50", VA = "0x18658F150")]
		internal void JIFNOMPFOFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x658EFF0", Offset = "0x658DBF0", VA = "0x18658EFF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x65908B0", Offset = "0x658F4B0", VA = "0x1865908B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x34EE5B0", Offset = "0x34ED1B0", VA = "0x1834EE5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x659F480", Offset = "0x659E080", VA = "0x18659F480")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A16F0", Offset = "0x65A02F0", VA = "0x1865A16F0")]
		internal void AFGAMGAFMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x65A1770", Offset = "0x65A0370", VA = "0x1865A1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x659EE60", Offset = "0x659DA60", VA = "0x18659EE60")]
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
		[Cpp2IlInjected.Address(RVA = "0x6596790", Offset = "0x6595390", VA = "0x186596790")]
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
		[Cpp2IlInjected.Address(RVA = "0x6595B80", Offset = "0x6594780", VA = "0x186595B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x65978E0", Offset = "0x65964E0", VA = "0x1865978E0")]
		internal void NAJOHAMNOGN(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6597840", Offset = "0x6596440", VA = "0x186597840")]
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
	[Cpp2IlInjected.Address(RVA = "0x2346B00", Offset = "0x2345700", VA = "0x182346B00")]
	public static object PPDENKGCILJ<T>(IAILMNCOOMI PFDHAEKGJDP, KJHGDFDBIIA FFIALCJHOLO, Func<string, string> DFOCBCOAJKF, bool PNMMFCJGPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x233BE00", Offset = "0x233AA00", VA = "0x18233BE00")]
	public static object IDMGFBNPHAD<T>(KJHGDFDBIIA FFIALCJHOLO, Func<string, string> DFOCBCOAJKF, bool PNMMFCJGPFP, bool MNGNKGHAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6570D50", Offset = "0x656F950", VA = "0x186570D50")]
	private static TypeInfo IBDABPHGKJJ(IAILMNCOOMI PFDHAEKGJDP, Type OMKEAAPIABA, Func<string, string> DFOCBCOAJKF, bool PNMMFCJGPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6573B70", Offset = "0x6572770", VA = "0x186573B70")]
	public static object MKBNDGNFNPF(Type OMKEAAPIABA, Func<string, string> DFOCBCOAJKF, bool PNMMFCJGPFP, bool MNGNKGHAFHO, bool BMOKABFEENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6570620", Offset = "0x656F220", VA = "0x186570620")]
	private static Dictionary<OJPEDGNDNFK, FieldInfo> HPCBODDGPKF(TypeBuilder PCDOLPBEMND, BACBDEMNINE CBHMEKBMEOP, ConstructorInfo OLBMKOEFGHO, FieldBuilder KGLKHBIMCMA, ILGenerator CIJLGEAJFCK, bool PNMMFCJGPFP, bool NEOMNCIBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6573490", Offset = "0x6572090", VA = "0x186573490")]
	private static Dictionary<OJPEDGNDNFK, FieldInfo> LHDIAJDOMCF(TypeBuilder PCDOLPBEMND, BACBDEMNINE CBHMEKBMEOP, ILGenerator CIJLGEAJFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6571E50", Offset = "0x6570A50", VA = "0x186571E50")]
	private static void JDOIMIPOGIC(Type OMKEAAPIABA, BACBDEMNINE CBHMEKBMEOP, ILGenerator CIJLGEAJFCK, Action MMODDBCDFPF, Func<int, OJPEDGNDNFK, bool> MKNFBICJMGI, bool PNMMFCJGPFP, bool NEOMNCIBBBO, int LMOAGDHPKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x65700E0", Offset = "0x656ECE0", VA = "0x1865700E0")]
	private static void CLAAAOCBIML(TypeInfo OMKEAAPIABA, OJPEDGNDNFK JFFCKOILPDB, ILGenerator CIJLGEAJFCK, int DCGGFHOCGGH, Func<int, OJPEDGNDNFK, bool> MKNFBICJMGI, HKIEBGPOONH BNGNOICJJGA, HKIEBGPOONH EPGPLFLGEEK, HKIEBGPOONH CAABJLIPFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x656E020", Offset = "0x656CC20", VA = "0x18656E020")]
	private static void BJAHEEGOAHE(Type OMKEAAPIABA, BACBDEMNINE CBHMEKBMEOP, ILGenerator CIJLGEAJFCK, Func<int, OJPEDGNDNFK, bool> MKNFBICJMGI, bool OKMNPACJDCD, int LMOAGDHPKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x656DBB0", Offset = "0x656C7B0", VA = "0x18656DBB0")]
	private static void ADGAEKFGPHN(ILGenerator CIJLGEAJFCK, EFAMBBPNEAA CBHMEKBMEOP, int DCGGFHOCGGH, Func<int, OJPEDGNDNFK, bool> MKNFBICJMGI, HKIEBGPOONH BIBCAMINPDH, HKIEBGPOONH CAABJLIPFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x656F350", Offset = "0x656DF50", VA = "0x18656F350")]
	private static LocalBuilder CDPBKIPCCKP(ILGenerator CIJLGEAJFCK, Type OMKEAAPIABA, BACBDEMNINE CBHMEKBMEOP, EFAMBBPNEAA[] CNMKILGHHHP, bool KONFBLBDFBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6571770", Offset = "0x6570370", VA = "0x186571770")]
	private static bool JCKAOMOLKON(ConstructorInfo GCGOFPDFLHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x65756A0", Offset = "0x65742A0", VA = "0x1865756A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CAD020", Offset = "0x1CABC20", VA = "0x181CAD020")]
	public CMCJGLHDJDD(byte[][] KGLKHBIMCMA, object[] EFHHOLOIIEA, object[] LMBCFOAMGLH, IBGMKJMHGMN<T> NLFMPMEFGLH, EHIIFJEGNFE<T> ODOLNNAPCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4C638B0", Offset = "0x4C624B0", VA = "0x184C638B0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4C637C0", Offset = "0x4C623C0", VA = "0x184C637C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C6C3B0", Offset = "0x4C6AFB0", VA = "0x184C6C3B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x35A1C00", Offset = "0x35A0800", VA = "0x1835A1C00")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x35CAA90", Offset = "0x35C9690", VA = "0x1835CAA90")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EBA380", Offset = "0x3EB8F80", VA = "0x183EBA380")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x46844E0", Offset = "0x46830E0", VA = "0x1846844E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x31648E0", Offset = "0x31634E0", VA = "0x1831648E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3923FE0", Offset = "0x3922BE0", VA = "0x183923FE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4515DC0", Offset = "0x45149C0", VA = "0x184515DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E36520", Offset = "0x4E35120", VA = "0x184E36520")]
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
			[Cpp2IlInjected.Address(RVA = "0x4880060", Offset = "0x487EC60", VA = "0x184880060")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DFF610", Offset = "0x3DFE210", VA = "0x183DFF610")]
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
			[Cpp2IlInjected.Address(RVA = "0x35D7840", Offset = "0x35D6440", VA = "0x1835D7840")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3623640", Offset = "0x3622240", VA = "0x183623640")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EB75E0", Offset = "0x3EB61E0", VA = "0x183EB75E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x38EF140", Offset = "0x38EDD40", VA = "0x1838EF140")]
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
			[Cpp2IlInjected.Address(RVA = "0x3716920", Offset = "0x3715520", VA = "0x183716920")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DF1060", Offset = "0x3DEFC60", VA = "0x183DF1060")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A28F40", Offset = "0x3A27B40", VA = "0x183A28F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3966A80", Offset = "0x3965680", VA = "0x183966A80")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D02080", Offset = "0x3D00C80", VA = "0x183D02080")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x34D4EE0", Offset = "0x34D3AE0", VA = "0x1834D4EE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x374B4D0", Offset = "0x374A0D0", VA = "0x18374B4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3661FF0", Offset = "0x3660BF0", VA = "0x183661FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x318DAE0", Offset = "0x318C6E0", VA = "0x18318DAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x459A860", Offset = "0x4599460", VA = "0x18459A860")]
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
			[Cpp2IlInjected.Address(RVA = "0x35B7E60", Offset = "0x35B6A60", VA = "0x1835B7E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x34F89D0", Offset = "0x34F75D0", VA = "0x1834F89D0")]
	public FPOLAPAFDEF(int NHAAFBFJNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x34F85E0", Offset = "0x34F71E0", VA = "0x1834F85E0")]
	public void HFMDKEOMMOI(T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x34F8940", Offset = "0x34F7540", VA = "0x1834F8940")]
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
	[Cpp2IlInjected.Address(RVA = "0x659F750", Offset = "0x659E350", VA = "0x18659F750")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E8FE10", Offset = "0x3E8EA10", VA = "0x183E8FE10")]
	public PAMNCHCIGOJ(int ILFCGMMCBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3E8F810", Offset = "0x3E8E410", VA = "0x183E8F810")]
	public T[] PFNNLOPLCEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3E8EA90", Offset = "0x3E8D690", VA = "0x183E8EA90")]
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
			[Cpp2IlInjected.Address(RVA = "0x659D9F0", Offset = "0x659C5F0", VA = "0x18659D9F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x659DB20", Offset = "0x659C720", VA = "0x18659DB20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x659DA70", Offset = "0x659C670", VA = "0x18659DA70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GDBFJGMMBPH> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x659DA70", Offset = "0x659C670", VA = "0x18659DA70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6596790", Offset = "0x6595390", VA = "0x186596790")]
			internal Label JICNOGLKKCO(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x6596790", Offset = "0x6595390", VA = "0x186596790")]
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
			[Cpp2IlInjected.Address(RVA = "0x50BF1A0", Offset = "0x50BDDA0", VA = "0x1850BF1A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6595280", Offset = "0x6593E80", VA = "0x186595280")]
		public GDBFJGMMBPH(ulong PPNDANAOAMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6594A40", Offset = "0x6593640", VA = "0x186594A40")]
		public GDBFJGMMBPH HFMDKEOMMOI(ulong PPNDANAOAMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x65949E0", Offset = "0x65935E0", VA = "0x1865949E0")]
		public GDBFJGMMBPH HFMDKEOMMOI(ulong PPNDANAOAMK, int GCPEEAODAIB, string CIOFGNKOFAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6594FC0", Offset = "0x6593BC0", VA = "0x186594FC0")]
		public GDBFJGMMBPH IIFJINOBLOM(byte[] BPDGEJEAOAF, int IAKOFEGDGBF, int MMANDKLIFNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6595140", Offset = "0x6593D40", VA = "0x186595140")]
		internal static int JMABOINPAMF(ulong[] DAJPKFPFPMI, int DCGGFHOCGGH, int NBJKCBMEDIG, ulong GCPEEAODAIB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6594930", Offset = "0x6593530", VA = "0x186594930", Slot = "4")]
		public int CompareTo(GDBFJGMMBPH LLMHBOEDHFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6594960", Offset = "0x6593560", VA = "0x186594960")]
		[IteratorStateMachine(typeof(MBJJKAFPCEP))]
		public IEnumerable<GDBFJGMMBPH> FJKGAHOCIGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6594C40", Offset = "0x6593840", VA = "0x186594C40")]
		public void IAOAEPOEFCJ(ILGenerator CIJLGEAJFCK, LocalBuilder BPDGEJEAOAF, LocalBuilder MMANDKLIFNJ, LocalBuilder PPNDANAOAMK, Action<KeyValuePair<string, int>> DGELMPACJHJ, Action NIHAMLFOEDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6593C50", Offset = "0x6592850", VA = "0x186593C50")]
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
			[Cpp2IlInjected.Address(RVA = "0x6597370", Offset = "0x6595F70", VA = "0x186597370", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1BCD000", Offset = "0x1BCBC00", VA = "0x181BCD000")]
		[DebuggerHidden]
		public JLCLCEMHOGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x65973C0", Offset = "0x6595FC0", VA = "0x1865973C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6596E10", Offset = "0x6595A10", VA = "0x186596E10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6596DC0", Offset = "0x65959C0", VA = "0x186596DC0")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6596D70", Offset = "0x6595970", VA = "0x186596D70")]
		private void HAIPFOFCHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6597320", Offset = "0x6595F20", VA = "0x186597320", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6597270", Offset = "0x6595E70", VA = "0x186597270", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6597270", Offset = "0x6595E70", VA = "0x186597270", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x658F8C0", Offset = "0x658E4C0", VA = "0x18658F8C0")]
	public DBPCFPGMCBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x658F3C0", Offset = "0x658DFC0", VA = "0x18658F3C0")]
	public void HFMDKEOMMOI(byte[] FEGEJBFJFNG, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x658F280", Offset = "0x658DE80", VA = "0x18658F280")]
	public bool CDAHGONAKGK(ArraySegment<byte> PPNDANAOAMK, [Out] int GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x658F830", Offset = "0x658E430", VA = "0x18658F830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x658F550", Offset = "0x658E150", VA = "0x18658F550")]
	private static void OKNPEODPFKJ(IEnumerable<GDBFJGMMBPH> PPPJJGENAHM, StringBuilder OEJAOEGGCBJ, int OLLFIMGHMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x658F360", Offset = "0x658DF60", VA = "0x18658F360", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x658F360", Offset = "0x658DF60", VA = "0x18658F360", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x658F4D0", Offset = "0x658E0D0", VA = "0x18658F4D0")]
	[IteratorStateMachine(typeof(JLCLCEMHOGK))]
	private static IEnumerable<KeyValuePair<string, int>> JODHHNHKMDH(IEnumerable<GDBFJGMMBPH> PPPJJGENAHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x658F250", Offset = "0x658DE50", VA = "0x18658F250")]
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
	[Cpp2IlInjected.Address(RVA = "0x6590A10", Offset = "0x658F610", VA = "0x186590A10")]
	public static ulong NKMDABFJLJD(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, int MMANDKLIFNJ)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class EIILKMGJDGG
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6591C80", Offset = "0x6590880", VA = "0x186591C80")]
	public static void GFMENOKGFNH(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, int LKLPIFOHKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6591DC0", Offset = "0x65909C0", VA = "0x186591DC0")]
	public static void JGGONMKDLCC(byte[] DAJPKFPFPMI, int ACOMFCEADLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6591B50", Offset = "0x6590750", VA = "0x186591B50")]
	public static byte[] DFMGGPLLPJK(byte[] PFJBHGAEIJN, int ACOMFCEADLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class MNGBCDHBONE
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x659EDF0", Offset = "0x659D9F0", VA = "0x18659EDF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D181A0", Offset = "0x3D16DA0", VA = "0x183D181A0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x346F5C0", Offset = "0x346E1C0", VA = "0x18346F5C0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DE8E70", Offset = "0x4DE7A70", VA = "0x184DE8E70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4DEACD0", Offset = "0x4DE98D0", VA = "0x184DEACD0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C64F50", Offset = "0x3C63B50", VA = "0x183C64F50")]
	public MDICILNLKFG(int AAAINGBCLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3C64F70", Offset = "0x3C63B70", VA = "0x183C64F70")]
	public MDICILNLKFG(int AAAINGBCLDC, float BBNAKLMGKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3C61330", Offset = "0x3C5FF30", VA = "0x183C61330")]
	public void HFMDKEOMMOI(byte[] PPNDANAOAMK, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3C633E0", Offset = "0x3C61FE0", VA = "0x183C633E0")]
	private bool NDOCBLGBBOJ(byte[] PPNDANAOAMK, T GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3C61D70", Offset = "0x3C60970", VA = "0x183C61D70")]
	public bool IKGDLKABABA(ArraySegment<byte> PPNDANAOAMK, [Out] T GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3C60BC0", Offset = "0x3C5F7C0", VA = "0x183C60BC0")]
	private static ulong DNAEGAPNPND(byte[] HPIMCNPJDMN, int IAKOFEGDGBF, int EMHEDPDPEMP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3C616C0", Offset = "0x3C602C0", VA = "0x183C616C0")]
	private static int HGEMHMOACFA(int CFINNPKIAEO, float BBNAKLMGKED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3C60C10", Offset = "0x3C5F810", VA = "0x183C60C10", Slot = "4")]
	[IteratorStateMachine(typeof(MDICILNLKFG<>.DCFCCIBMOJH))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x33098C0", Offset = "0x33084C0", VA = "0x1833098C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x659F140", Offset = "0x659DD40", VA = "0x18659F140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x659F190", Offset = "0x659DD90", VA = "0x18659F190")]
	static NMMCAEGHKGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x659F3F0", Offset = "0x659DFF0", VA = "0x18659F3F0")]
	public NMMCAEGHKGC(byte[] MNOJJLEFBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x659F040", Offset = "0x659DC40", VA = "0x18659F040")]
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
	[Cpp2IlInjected.Address(RVA = "0x659BDA0", Offset = "0x659A9A0", VA = "0x18659BDA0")]
	public LKPIFAHCLGH(Guid GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x659BDB0", Offset = "0x659A9B0", VA = "0x18659BDB0")]
	public LKPIFAHCLGH(ArraySegment<byte> BOPNEGGLGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x659AF60", Offset = "0x6599B60", VA = "0x18659AF60")]
	private static byte EJCEEDCGPOP(byte[] FEGEJBFJFNG, int BBHFDDNOAOO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x659AE40", Offset = "0x6599A40", VA = "0x18659AE40")]
	private static byte EDHPHENLJKK(byte KNDAEONALIC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x659B000", Offset = "0x6599C00", VA = "0x18659B000")]
	public void ENIJDOPIDEK(byte[] NJCBLCELFEN, int IAKOFEGDGBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class BAEOCKHGMGB
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x658B670", Offset = "0x658A270", VA = "0x18658B670")]
	public static bool AGJKKDILJAH(byte KIHBPBFELGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x658B600", Offset = "0x658A200", VA = "0x18658B600")]
	public static bool ACCJCLJAADJ(byte KIHBPBFELGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x658BE20", Offset = "0x658AA20", VA = "0x18658BE20")]
	public static sbyte CHMJCBCDPPL(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x658C060", Offset = "0x658AC60", VA = "0x18658C060")]
	public static short HCDIJGBANMG(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x658CC20", Offset = "0x658B820", VA = "0x18658CC20")]
	public static int MLJMMPOIAEI(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x658CF40", Offset = "0x658BB40", VA = "0x18658CF40")]
	public static long PDFAPFMJCNA(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x658BF70", Offset = "0x658AB70", VA = "0x18658BF70")]
	public static byte EGMGFOCJNCK(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x658B680", Offset = "0x658A280", VA = "0x18658B680")]
	public static ushort BMOMAHHBDPF(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x658B700", Offset = "0x658A300", VA = "0x18658B700")]
	public static uint CFIPKEMCFJB(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x658CB10", Offset = "0x658B710", VA = "0x18658CB10")]
	public static ulong MIBHGPJPIOM(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x658BFF0", Offset = "0x658ABF0", VA = "0x18658BFF0")]
	public static float FMEHOAGPDNL(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x658BF00", Offset = "0x658AB00", VA = "0x18658BF00")]
	public static double DJBBLBLLGLM(byte[] FEGEJBFJFNG, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x658B780", Offset = "0x658A380", VA = "0x18658B780")]
	public static int CHGOFFFENEB(byte[] NJCBLCELFEN, int IAKOFEGDGBF, ulong GCPEEAODAIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x658C150", Offset = "0x658AD50", VA = "0x18658C150")]
	public static int JNMHPCEDPEB(byte[] NJCBLCELFEN, int IAKOFEGDGBF, long GCPEEAODAIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x658CD10", Offset = "0x658B910", VA = "0x18658CD10")]
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
		[Cpp2IlInjected.Address(RVA = "0x659AD10", Offset = "0x6599910", VA = "0x18659AD10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x659A7D0", Offset = "0x65993D0", VA = "0x18659A7D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x659A780", Offset = "0x6599380", VA = "0x18659A780")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x659A730", Offset = "0x6599330", VA = "0x18659A730")]
		private void HAIPFOFCHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x659ACC0", Offset = "0x65998C0", VA = "0x18659ACC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x659AC00", Offset = "0x6599800", VA = "0x18659AC00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x659AC00", Offset = "0x6599800", VA = "0x18659AC00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6596660", Offset = "0x6595260", VA = "0x186596660", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6596120", Offset = "0x6594D20", VA = "0x186596120", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x65960D0", Offset = "0x6594CD0", VA = "0x1865960D0")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6596080", Offset = "0x6594C80", VA = "0x186596080")]
		private void HAIPFOFCHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6596610", Offset = "0x6595210", VA = "0x186596610", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6596550", Offset = "0x6595150", VA = "0x186596550", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6596550", Offset = "0x6595150", VA = "0x186596550", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x65968F0", Offset = "0x65954F0", VA = "0x1865968F0")]
	public static bool CDJKBPEBIBM(this TypeInfo OMKEAAPIABA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x65967C0", Offset = "0x65953C0", VA = "0x1865967C0")]
	public static bool AFNPFJEFNIN(this TypeInfo OMKEAAPIABA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6596A50", Offset = "0x6595650", VA = "0x186596A50")]
	public static IEnumerable<PropertyInfo> LALHGAJNKGC(this Type OMKEAAPIABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6596B50", Offset = "0x6595750", VA = "0x186596B50")]
	[IteratorStateMachine(typeof(LKGEOIIPDDA))]
	private static IEnumerable<PropertyInfo> POBLBEPCFPH(Type OMKEAAPIABA, HashSet<string> PLIKKAICJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6596AD0", Offset = "0x65956D0", VA = "0x186596AD0")]
	public static IEnumerable<FieldInfo> PKPMDMFAJMA(this Type OMKEAAPIABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x65969B0", Offset = "0x65955B0", VA = "0x1865969B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6597B90", Offset = "0x6596790", VA = "0x186597B90")]
	public static string BPKBEBGADMK(string HJMPOPKEFMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6597C70", Offset = "0x6596870", VA = "0x186597C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x365F710", Offset = "0x365E310", VA = "0x18365F710", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x365F6D0", Offset = "0x365E2D0", VA = "0x18365F6D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E965F0", Offset = "0x3E951F0", VA = "0x183E965F0")]
	public PDIEOAAENMF(int AAAINGBCLDC = 4, float BBNAKLMGKED = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x3E96260", Offset = "0x3E94E60", VA = "0x183E96260")]
	public bool NHIIPPMFJOI(Type PPNDANAOAMK, TValue GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3E960A0", Offset = "0x3E94CA0", VA = "0x183E960A0")]
	public bool NHIIPPMFJOI(Type PPNDANAOAMK, Func<Type, TValue> PJMJEBGCGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3E95D40", Offset = "0x3E94940", VA = "0x183E95D40")]
	private bool NDOCBLGBBOJ(Type PPNDANAOAMK, Func<Type, TValue> PJMJEBGCGIO, [Out] TValue BCDEMFADCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3E955F0", Offset = "0x3E941F0", VA = "0x183E955F0")]
	private bool KFJOHNFMMDD(HGAEIJPKAFB[] KIFMPIJJEKI, Type BNFDIGODPHF, HGAEIJPKAFB HDKLMAKMEJF, Func<Type, TValue> PJMJEBGCGIO, [Out] TValue BCDEMFADCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3E94FC0", Offset = "0x3E93BC0", VA = "0x183E94FC0")]
	public bool IKGDLKABABA(Type PPNDANAOAMK, [Out] TValue GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3E96390", Offset = "0x3E94F90", VA = "0x183E96390")]
	public TValue OCMJLJAHBBI(Type PPNDANAOAMK, Func<Type, TValue> PJMJEBGCGIO)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3C616C0", Offset = "0x3C602C0", VA = "0x183C616C0")]
	private static int HGEMHMOACFA(int CFINNPKIAEO, float BBNAKLMGKED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3E94F90", Offset = "0x3E93B90", VA = "0x183E94F90")]
	private static void ENNNBICJBMH(HGAEIJPKAFB KDCJKAGAHDO, HGAEIJPKAFB GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3E94F90", Offset = "0x3E93B90", VA = "0x183E94F90")]
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
	[Cpp2IlInjected.Address(RVA = "0x6595E70", Offset = "0x6594A70", VA = "0x186595E70")]
	public TypeBuilder GJJIGEFDAOE(string JEICAPDKHKI, TypeAttributes MKAPNPOMLOJ, Type HHNAEDAPOHF, Type[] BKNMBKEIPOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6595F70", Offset = "0x6594B70", VA = "0x186595F70")]
	public IAILMNCOOMI(string HKCHPMIIBOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal static class PDKECDHDGCG
{
	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x65A1610", Offset = "0x65A0210", VA = "0x1865A1610")]
	private static MethodInfo NEEBJJCINED(LambdaExpression CKFDOHHAKMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2661510", Offset = "0x2660110", VA = "0x182661510")]
	public static MethodInfo DDPJNFMKOID<T>(Expression<Func<T>> CKFDOHHAKMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2661510", Offset = "0x2660110", VA = "0x182661510")]
	public static MethodInfo DDPJNFMKOID<T, TR>(Expression<Func<T, TR>> CKFDOHHAKMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2661510", Offset = "0x2660110", VA = "0x182661510")]
	public static MethodInfo DDPJNFMKOID<T>(Expression<Action<T>> CKFDOHHAKMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2661510", Offset = "0x2660110", VA = "0x182661510")]
	public static MethodInfo DDPJNFMKOID<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> CKFDOHHAKMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2661430", Offset = "0x2660030", VA = "0x182661430")]
	private static MemberInfo DCFBGPJBOFN<T>(Expression<T> NOOIIGLDGHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2661520", Offset = "0x2660120", VA = "0x182661520")]
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
	[Cpp2IlInjected.Address(RVA = "0x6595DA0", Offset = "0x65949A0", VA = "0x186595DA0")]
	public HKIEBGPOONH(ILGenerator CIJLGEAJFCK, int JBCJBAEMMMK, bool ODKFNMHPCBB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6595DE0", Offset = "0x65949E0", VA = "0x186595DE0")]
	public HKIEBGPOONH(ILGenerator CIJLGEAJFCK, int JBCJBAEMMMK, Type OMKEAAPIABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6595CA0", Offset = "0x65948A0", VA = "0x186595CA0")]
	public void DHDMEIMEDIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class BFGEAKCJNGM
{
	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x658D640", Offset = "0x658C240", VA = "0x18658D640")]
	public static void BCNAMIHNHIJ(this ILGenerator CIJLGEAJFCK, int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x658D600", Offset = "0x658C200", VA = "0x18658D600")]
	public static void BCNAMIHNHIJ(this ILGenerator CIJLGEAJFCK, LocalBuilder AOMJFNFAOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x658D3D0", Offset = "0x658BFD0", VA = "0x18658D3D0")]
	public static void AJONACAEDKJ(this ILGenerator CIJLGEAJFCK, int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x658D5C0", Offset = "0x658C1C0", VA = "0x18658D5C0")]
	public static void AJONACAEDKJ(this ILGenerator CIJLGEAJFCK, LocalBuilder AOMJFNFAOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x658D1F0", Offset = "0x658BDF0", VA = "0x18658D1F0")]
	public static void AJGCFLFEOLK(this ILGenerator CIJLGEAJFCK, int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x658D2D0", Offset = "0x658BED0", VA = "0x18658D2D0")]
	public static void AJGCFLFEOLK(this ILGenerator CIJLGEAJFCK, LocalBuilder AOMJFNFAOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x658DB40", Offset = "0x658C740", VA = "0x18658DB40")]
	public static void HHJHDKMKFMB(this ILGenerator CIJLGEAJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x658DA90", Offset = "0x658C690", VA = "0x18658DA90")]
	public static void FCKFPMLNDHI(this ILGenerator CIJLGEAJFCK, bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x658DEA0", Offset = "0x658CAA0", VA = "0x18658DEA0")]
	public static void NONGBOOLLNJ(this ILGenerator CIJLGEAJFCK, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x658D830", Offset = "0x658C430", VA = "0x18658D830")]
	public static void BEJAFLFHBHN(this ILGenerator CIJLGEAJFCK, Type OMKEAAPIABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x658DAA0", Offset = "0x658C6A0", VA = "0x18658DAA0")]
	public static void GDAGBFBGIME(this ILGenerator CIJLGEAJFCK, Type OMKEAAPIABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x658DB50", Offset = "0x658C750", VA = "0x18658DB50")]
	public static void KAGAIMHCIAE(this ILGenerator CIJLGEAJFCK, int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x658DE20", Offset = "0x658CA20", VA = "0x18658DE20")]
	public static void KLMPGNFOJEP(this ILGenerator CIJLGEAJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x658DD40", Offset = "0x658C940", VA = "0x18658DD40")]
	public static void KDDFADMEGBH(this ILGenerator CIJLGEAJFCK, int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x658D910", Offset = "0x658C510", VA = "0x18658D910")]
	public static void BELJOFDBAHP(this ILGenerator CIJLGEAJFCK, MethodInfo AEELPNCBMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x658DA00", Offset = "0x658C600", VA = "0x18658DA00")]
	public static void DJKHPOIDLGB(this ILGenerator CIJLGEAJFCK, FieldInfo ILOIILFNHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x658D160", Offset = "0x658BD60", VA = "0x18658D160")]
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
		[Cpp2IlInjected.Address(RVA = "0x6597510", Offset = "0x6596110", VA = "0x186597510")]
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
		[Cpp2IlInjected.Address(RVA = "0x659F9B0", Offset = "0x659E5B0", VA = "0x18659F9B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x659FCB0", Offset = "0x659E8B0", VA = "0x18659FCB0")]
	protected OJPEDGNDNFK(Type OMKEAAPIABA, string JEICAPDKHKI, string CKDECAPDPIB, bool IJNIGDGMCLN, bool CHCNJHHPEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x659FD30", Offset = "0x659E930", VA = "0x18659FD30")]
	public OJPEDGNDNFK(FieldInfo CBHMEKBMEOP, string JEICAPDKHKI, bool MNGNKGHAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x659FE40", Offset = "0x659EA40", VA = "0x18659FE40")]
	public OJPEDGNDNFK(PropertyInfo CBHMEKBMEOP, string JEICAPDKHKI, bool MNGNKGHAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x659FB40", Offset = "0x659E740", VA = "0x18659FB40")]
	private static MethodInfo PFKPAFEAEGI(MemberInfo CBHMEKBMEOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2647400", Offset = "0x2646000", VA = "0x182647400")]
	public T KMLLJHHKNNF<T>(bool AKNKFCIKJLK) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x659F9C0", Offset = "0x659E5C0", VA = "0x18659F9C0", Slot = "4")]
	public virtual void HLMCGMABGFI(ILGenerator CIJLGEAJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x659F830", Offset = "0x659E430", VA = "0x18659F830", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6589BE0", Offset = "0x65887E0", VA = "0x186589BE0")]
	public ADEAJAHEIAP(string JEICAPDKHKI, string BDNEHJHLIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6589B30", Offset = "0x6588730", VA = "0x186589B30", Slot = "4")]
	public override void HLMCGMABGFI(ILGenerator CIJLGEAJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6589AE0", Offset = "0x65886E0", VA = "0x186589AE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x658EF30", Offset = "0x658DB30", VA = "0x18658EF30")]
	public CKEGCLJNLMC(string JEICAPDKHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x658E7A0", Offset = "0x658D3A0", VA = "0x18658E7A0", Slot = "4")]
	public override void HLMCGMABGFI(ILGenerator CIJLGEAJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x658E750", Offset = "0x658D350", VA = "0x18658E750", Slot = "5")]
	public override void CNHNBCDJONK(ILGenerator CIJLGEAJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x658E860", Offset = "0x658D460", VA = "0x18658E860")]
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
	[Cpp2IlInjected.Address(RVA = "0x658A140", Offset = "0x6588D40", VA = "0x18658A140")]
	public BACBDEMNINE(Type OMKEAAPIABA, Func<string, string> ALBFCCONJIK, bool MNGNKGHAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x658A060", Offset = "0x6588C60", VA = "0x18658A060")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D018D0", Offset = "0x1D004D0", VA = "0x181D018D0")]
	public DFPOKPBFHML(ulong NELHHIOBKGD, int FEBIIPCHBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x658F9D0", Offset = "0x658E5D0", VA = "0x18658F9D0")]
	public void FBOCMFEJDPK(DFPOKPBFHML LLMHBOEDHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x658FB10", Offset = "0x658E710", VA = "0x18658FB10")]
	public static DFPOKPBFHML PDPFELLHGBH(DFPOKPBFHML FLGIINLNNEM, DFPOKPBFHML KNDAEONALIC)
	{
		return default(DFPOKPBFHML);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x658FA80", Offset = "0x658E680", VA = "0x18658FA80")]
	public void ODACDIGNODO(DFPOKPBFHML LLMHBOEDHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x658F9E0", Offset = "0x658E5E0", VA = "0x18658F9E0")]
	public static DFPOKPBFHML IMHICEPHMGE(DFPOKPBFHML FLGIINLNNEM, DFPOKPBFHML KNDAEONALIC)
	{
		return default(DFPOKPBFHML);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x658F990", Offset = "0x658E590", VA = "0x18658F990")]
	public void DBBAENCEIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x658F940", Offset = "0x658E540", VA = "0x18658F940")]
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
	[Cpp2IlInjected.Address(RVA = "0x65767D0", Offset = "0x65753D0", VA = "0x1865767D0")]
	public void POINPFHLGOP(byte JMMCCECHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x659D970", Offset = "0x659C570", VA = "0x18659D970")]
	public void POLMGCBCKOH(byte[] JMMCCECHKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x659D750", Offset = "0x659C350", VA = "0x18659D750")]
	public void NHBAMLKGABP(byte[] JMMCCECHKKL, int NBJKCBMEDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x659D7D0", Offset = "0x659C3D0", VA = "0x18659D7D0")]
	public void NHBAMLKGABP(byte[] JMMCCECHKKL, int DIOBLODNDCP, int NBJKCBMEDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x659D6D0", Offset = "0x659C2D0", VA = "0x18659D6D0")]
	public void EFJGNNODKEP(byte KIHBPBFELGP, int EMHEDPDPEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x659D870", Offset = "0x659C470", VA = "0x18659D870")]
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
	[Cpp2IlInjected.Address(RVA = "0x6597EF0", Offset = "0x6596AF0", VA = "0x186597EF0")]
	private static byte[] CEKOPEMLOIP(int JIGGJNDJAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6598920", Offset = "0x6597520", VA = "0x186598920")]
	private static byte[] IAEPAPKACLD(int JIGGJNDJAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6598F80", Offset = "0x6597B80", VA = "0x186598F80")]
	public static int MFJOPFFCBFK(byte[] NJCBLCELFEN, int IAKOFEGDGBF, float GCPEEAODAIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x65990A0", Offset = "0x6597CA0", VA = "0x1865990A0")]
	public static int MFJOPFFCBFK(byte[] NJCBLCELFEN, int IAKOFEGDGBF, double GCPEEAODAIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6597FC0", Offset = "0x6596BC0", VA = "0x186597FC0")]
	private static bool DGHBICLJFKF(byte[] NJCBLCELFEN, int NBJKCBMEDIG, ulong KLKNLJMDOEK, ulong OJEBGGFGFOL, ulong MMANDKLIFNJ, ulong HFIENIJCLHE, ulong OHMJBJMILMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6597E00", Offset = "0x6596A00", VA = "0x186597E00")]
	private static void BJKMFIKMHOP(uint JEIBBCEGCBO, int LMKICJEEBEF, [Out] uint FMJGCKCFHAM, [Out] int OMHLFGFAFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x65980B0", Offset = "0x6596CB0", VA = "0x1865980B0")]
	private static bool DLMIKCHHFAH(DFPOKPBFHML LLNPNMLBICK, DFPOKPBFHML NGJMGEHADAK, DFPOKPBFHML LMDBNDADMFL, byte[] NJCBLCELFEN, [Out] int NBJKCBMEDIG, [Out] int ABJMDLOAOMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x65984A0", Offset = "0x65970A0", VA = "0x1865984A0")]
	private static bool FAODDPNDOHM(double NDGLLLKBMIO, CDHLMAJMLCA BBGPDHGEJDH, byte[] NJCBLCELFEN, [Out] int NBJKCBMEDIG, [Out] int AIHLCJJDOID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x6599CA0", Offset = "0x65988A0", VA = "0x186599CA0")]
	private static bool PANHPFBLEKJ(double NDGLLLKBMIO, CDHLMAJMLCA BBGPDHGEJDH, byte[] NJCBLCELFEN, [Out] int NBJKCBMEDIG, [Out] int FENNFAPGOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x65995F0", Offset = "0x65981F0", VA = "0x1865995F0")]
	private static bool NDIPKKMDGPB(double GCPEEAODAIB, LPNKJONGPMC FHEPBBDALPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x65997C0", Offset = "0x65983C0", VA = "0x1865997C0")]
	private static bool OAJOLDNEHCM(double GCPEEAODAIB, LPNKJONGPMC FHEPBBDALPE, ODGIJLCJMGI BBGPDHGEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6598A00", Offset = "0x6597600", VA = "0x186598A00")]
	private static void KFEJCKCMOPB(byte[] MACFHPPABAJ, int NBJKCBMEDIG, int FENNFAPGOBF, int MNNEJFEANOM, LPNKJONGPMC FHEPBBDALPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x65991C0", Offset = "0x6597DC0", VA = "0x1865991C0")]
	private static void MNHDEBCMAAC(byte[] MACFHPPABAJ, int NBJKCBMEDIG, int FEBIIPCHBAJ, LPNKJONGPMC FHEPBBDALPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6598D90", Offset = "0x6597990", VA = "0x186598D90")]
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
	[Cpp2IlInjected.Address(RVA = "0x6595970", Offset = "0x6594570", VA = "0x186595970")]
	public GHJAFIHCHIK(double DKFOONILOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x65958D0", Offset = "0x65944D0", VA = "0x1865958D0")]
	public GHJAFIHCHIK(DFPOKPBFHML DKFOONILOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x65954D0", Offset = "0x65940D0", VA = "0x1865954D0")]
	public DFPOKPBFHML FLPFOFJKMME()
	{
		return default(DFPOKPBFHML);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6595540", Offset = "0x6594140", VA = "0x186595540")]
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
	[Cpp2IlInjected.Address(RVA = "0x6595450", Offset = "0x6594050", VA = "0x186595450")]
	public double FLHBBPCFCKB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x65953B0", Offset = "0x6593FB0", VA = "0x1865953B0")]
	public double DHEKLAIPHGI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x65958A0", Offset = "0x65944A0", VA = "0x1865958A0")]
	public int PMLNBFFGGGM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x65955E0", Offset = "0x65941E0", VA = "0x1865955E0")]
	public ulong HMJIOHLLOCI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6595390", Offset = "0x6593F90", VA = "0x186595390")]
	public bool CIIAMPGGNFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6595880", Offset = "0x6594480", VA = "0x186595880")]
	public bool NHMAJCFKLJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6595850", Offset = "0x6594450", VA = "0x186595850")]
	public bool MOANELEPKLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6595800", Offset = "0x6594400", VA = "0x186595800")]
	public bool KNGIMPCCJGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x65955C0", Offset = "0x65941C0", VA = "0x1865955C0")]
	public int HDFMGJMNDJA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6595620", Offset = "0x6594220", VA = "0x186595620")]
	public void KFGPFCMKFOM([Out] DFPOKPBFHML JJDBDDGAGIB, [Out] DFPOKPBFHML CNGBHOEDGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6595340", Offset = "0x6593F40", VA = "0x186595340")]
	public bool AJAFKHDDMJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA600", Offset = "0x2AB9200", VA = "0x182ABA600")]
	public double GCPEEAODAIB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6595830", Offset = "0x6594430", VA = "0x186595830")]
	public static int LHEIKHOLKJI(int HDJFIBIFIHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6595610", Offset = "0x6594210", VA = "0x186595610")]
	public static double JNCFOOGNLAP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6595770", Offset = "0x6594370", VA = "0x186595770")]
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
	[Cpp2IlInjected.Address(RVA = "0x2022260", Offset = "0x2020E60", VA = "0x182022260")]
	public FHECNMGBENC(float PDLHBLLNCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6592100", Offset = "0x6590D00", VA = "0x186592100")]
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
	[Cpp2IlInjected.Address(RVA = "0x65922A0", Offset = "0x6590EA0", VA = "0x1865922A0")]
	public int PMLNBFFGGGM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6592150", Offset = "0x6590D50", VA = "0x186592150")]
	public uint HMJIOHLLOCI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x65920F0", Offset = "0x6590CF0", VA = "0x1865920F0")]
	public bool CIIAMPGGNFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6592170", Offset = "0x6590D70", VA = "0x186592170")]
	public void KFGPFCMKFOM([Out] DFPOKPBFHML JJDBDDGAGIB, [Out] DFPOKPBFHML CNGBHOEDGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x65920B0", Offset = "0x6590CB0", VA = "0x1865920B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x65922C0", Offset = "0x6590EC0", VA = "0x1865922C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A0000", Offset = "0x659EC00", VA = "0x1865A0000")]
	public static void HOMCOPLIFIP(int JGMCOHAGILP, int PKLEDKPAHHO, [Out] DFPOKPBFHML FMJGCKCFHAM, [Out] int AIHLCJJDOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x65A0110", Offset = "0x659ED10", VA = "0x1865A0110")]
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
		[Cpp2IlInjected.Address(RVA = "0x6597620", Offset = "0x6596220", VA = "0x186597620")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x37117F0", Offset = "0x37103F0", VA = "0x1837117F0")]
	public KCFEJJHJMHF(byte[] FEGEJBFJFNG, int DIOBLODNDCP, int NBJKCBMEDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x2058010", Offset = "0x2056C10", VA = "0x182058010")]
	public int NBJKCBMEDIG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6597660", Offset = "0x6596260", VA = "0x186597660")]
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
	[Cpp2IlInjected.Address(RVA = "0x6592A60", Offset = "0x6591660", VA = "0x186592A60")]
	private static byte[] EMJFFNFEAJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6593AB0", Offset = "0x65926B0", VA = "0x186593AB0")]
	private static KCFEJJHJMHF OFBCPOEGBJC(KCFEJJHJMHF NJCBLCELFEN)
	{
		return default(KCFEJJHJMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6593700", Offset = "0x6592300", VA = "0x186593700")]
	private static KCFEJJHJMHF MACLMJAFFNO(KCFEJJHJMHF NJCBLCELFEN)
	{
		return default(KCFEJJHJMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x65932A0", Offset = "0x6591EA0", VA = "0x1865932A0")]
	private static void KILBKKPAHIE(KCFEJJHJMHF NJCBLCELFEN, int FEBIIPCHBAJ, byte[] HJMEDKKEHLH, [Out] int GHJKFBBFDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6592CF0", Offset = "0x65918F0", VA = "0x186592CF0")]
	private static void GKBHCCKEHAJ(KCFEJJHJMHF NJCBLCELFEN, int FEBIIPCHBAJ, byte[] PGOHOPMOBKB, int CPCBECKBNOF, [Out] KCFEJJHJMHF PGNPELJCPMM, [Out] int DBECDMJCCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6592B40", Offset = "0x6591740", VA = "0x186592B40")]
	private static ulong FBKNKKBKOND(KCFEJJHJMHF NJCBLCELFEN, [Out] int OMICGPLLKGO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6592920", Offset = "0x6591520", VA = "0x186592920")]
	private static void CHLMEBCKPCI(KCFEJJHJMHF NJCBLCELFEN, [Out] DFPOKPBFHML HNCONAMCFGC, [Out] int NBGAHCAFBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6593330", Offset = "0x6591F30", VA = "0x186593330")]
	private static bool KNHAKNJEJMG(KCFEJJHJMHF PGNPELJCPMM, int FEBIIPCHBAJ, [Out] double HNCONAMCFGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6592FE0", Offset = "0x6591BE0", VA = "0x186592FE0")]
	private static DFPOKPBFHML GPEMMKCJLBC(int FEBIIPCHBAJ)
	{
		return default(DFPOKPBFHML);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x65922D0", Offset = "0x6590ED0", VA = "0x1865922D0")]
	private static bool CGONDNFNNAD(KCFEJJHJMHF NJCBLCELFEN, int FEBIIPCHBAJ, [Out] double HNCONAMCFGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6593180", Offset = "0x6591D80", VA = "0x186593180")]
	private static bool JICNHGELDEK(KCFEJJHJMHF PGNPELJCPMM, int FEBIIPCHBAJ, [Out] double FMABIFGOAME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6592BD0", Offset = "0x65917D0", VA = "0x186592BD0")]
	public static double? FLFCGJNGOKM(KCFEJJHJMHF NJCBLCELFEN, int FEBIIPCHBAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x65937E0", Offset = "0x65923E0", VA = "0x1865937E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x65AE700", Offset = "0x65AD300", VA = "0x1865AE700")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AE6F0", Offset = "0x65AD2F0", VA = "0x1865AE6F0")]
	public static HLKDPNIFLDK GGEGNDBLNDM(HLKDPNIFLDK HHHLENOMLMP)
	{
		return default(HLKDPNIFLDK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x65AE670", Offset = "0x65AD270", VA = "0x1865AE670")]
	public static HLKDPNIFLDK CNAFECNPDIL(HLKDPNIFLDK HHHLENOMLMP, int NBJKCBMEDIG)
	{
		return default(HLKDPNIFLDK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x65AE810", Offset = "0x65AD410", VA = "0x1865AE810")]
	public static int ODFMOCCMCOB(HLKDPNIFLDK AGIBINPMDEG, HLKDPNIFLDK BBPKFALMKGI)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x65AE7D0", Offset = "0x65AD3D0", VA = "0x1865AE7D0")]
	public static bool JONBIHPGCCI(HLKDPNIFLDK AGIBINPMDEG, HLKDPNIFLDK BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x65AE790", Offset = "0x65AD390", VA = "0x1865AE790")]
	public static bool JBDELPGDOBO(HLKDPNIFLDK AGIBINPMDEG, HLKDPNIFLDK BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x65AE7A0", Offset = "0x65AD3A0", VA = "0x1865AE7A0")]
	public static bool JONBIHPGCCI(HLKDPNIFLDK AGIBINPMDEG, char BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x65AE760", Offset = "0x65AD360", VA = "0x1865AE760")]
	public static bool JBDELPGDOBO(HLKDPNIFLDK AGIBINPMDEG, char BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x65AE760", Offset = "0x65AD360", VA = "0x1865AE760")]
	public static bool JBDELPGDOBO(HLKDPNIFLDK AGIBINPMDEG, byte BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x65AE6C0", Offset = "0x65AD2C0", VA = "0x1865AE6C0")]
	public static bool EIEHBMEICDK(HLKDPNIFLDK AGIBINPMDEG, char BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x65AE7E0", Offset = "0x65AD3E0", VA = "0x1865AE7E0")]
	public static bool MOELJPPBJBB(HLKDPNIFLDK AGIBINPMDEG, char BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x65AE640", Offset = "0x65AD240", VA = "0x1865AE640")]
	public static bool BMEBEOKILAP(HLKDPNIFLDK AGIBINPMDEG, char BBPKFALMKGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x65AE730", Offset = "0x65AD330", VA = "0x1865AE730")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B1AC0", Offset = "0x65B06C0", VA = "0x1865B1AC0")]
	private static byte[] HHMJKHMNGNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x65B18A0", Offset = "0x65B04A0", VA = "0x1865B18A0")]
	private static byte[] ABEKEBIFDCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x65B1BA0", Offset = "0x65B07A0", VA = "0x1865B1BA0")]
	public static double HKGCPAJECEL(byte[] NJCBLCELFEN, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x65B1F80", Offset = "0x65B0B80", VA = "0x1865B1F80")]
	public static float OPGCAFHHDAO(byte[] NJCBLCELFEN, int IAKOFEGDGBF, [Out] int OABCFGHHGOK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x65B1E40", Offset = "0x65B0A40", VA = "0x1865B1E40")]
	private static bool LECPKFKJFCJ(int HPIMCNPJDMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x65B1C50", Offset = "0x65B0850", VA = "0x1865B1C50")]
	private static bool KEKEGFNHHGI(HLKDPNIFLDK NNIJILBJONM, HLKDPNIFLDK AEFDKINALJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x65B19D0", Offset = "0x65B05D0", VA = "0x1865B19D0")]
	private static bool BFIFFPGKKMC(HLKDPNIFLDK NNIJILBJONM, HLKDPNIFLDK AEFDKINALJN, byte[] EKMOJANHMGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x65B1980", Offset = "0x65B0580", VA = "0x1865B1980")]
	private static bool ACPNAFHFDCK(HLKDPNIFLDK BOPKPGKGOLB, byte[] JMMCCECHKKL, int IAKOFEGDGBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x65B1AA0", Offset = "0x65B06A0", VA = "0x1865B1AA0")]
	private static double CJHFADOHIKA(bool BJCEOIDCFEF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x65B2030", Offset = "0x65B0C30", VA = "0x1865B2030")]
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
	[Cpp2IlInjected.Address(RVA = "0x314F9D0", Offset = "0x314E5D0", VA = "0x18314F9D0")]
	public COODBLILHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
	public COODBLILHOK(LHNNGKOEDJE BAODLGNFAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x4C84C00", Offset = "0x4C83800", VA = "0x184C84C00", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x4C82230", Offset = "0x4C80E30", VA = "0x184C82230", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3EBE100", Offset = "0x3EBCD00", VA = "0x183EBE100", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ArraySegment<T> GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3EBDCE0", Offset = "0x3EBC8E0", VA = "0x183EBDCE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x314F9D0", Offset = "0x314E5D0", VA = "0x18314F9D0")]
	public JNOPNIANKHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
	public JNOPNIANKHA(LHNNGKOEDJE BAODLGNFAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x3928240", Offset = "0x3926E40", VA = "0x183928240", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, List<T> GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x3927810", Offset = "0x3926410", VA = "0x183927810", Slot = "5")]
	public List<T> JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class BBLFAFJAEFA<TElement, TIntermediate, TEnumerator, TCollection> : CBFHJMOMLDG<TCollection>, LKLKMMHABOC where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x4587ED0", Offset = "0x4586AD0", VA = "0x184587ED0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, TCollection GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x4587180", Offset = "0x4585D80", VA = "0x184587180", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x318CC00", Offset = "0x318B800", VA = "0x18318CC00", Slot = "6")]
	protected override IEnumerator<TElement> JMCJOFLMHBP(TCollection NOOIIGLDGHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x3137B40", Offset = "0x3136740", VA = "0x183137B40")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E4A780", Offset = "0x4E49380", VA = "0x184E4A780", Slot = "7")]
	protected override TCollection PAKONFKLIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x4E4A6C0", Offset = "0x4E492C0", VA = "0x184E4A6C0", Slot = "8")]
	protected override void HFMDKEOMMOI(TCollection GAHOHIBHCJI, int DCGGFHOCGGH, TElement GCPEEAODAIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class EGKAHEHGJBI<T> : BBLFAFJAEFA<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x31679D0", Offset = "0x31665D0", VA = "0x1831679D0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3152FF0", Offset = "0x3151BF0", VA = "0x183152FF0", Slot = "7")]
	protected override LinkedList<T> PAKONFKLIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3167A10", Offset = "0x3166610", VA = "0x183167A10", Slot = "6")]
	protected override LinkedList<T>.Enumerator JMCJOFLMHBP(LinkedList<T> NOOIIGLDGHB)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class IMLPKNKKNLJ<T> : BBLFAFJAEFA<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x31679D0", Offset = "0x31665D0", VA = "0x1831679D0", Slot = "8")]
	protected override void HFMDKEOMMOI(Queue<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3152FF0", Offset = "0x3151BF0", VA = "0x183152FF0", Slot = "7")]
	protected override Queue<T> PAKONFKLIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x37467C0", Offset = "0x37453C0", VA = "0x1837467C0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x3CC4250", Offset = "0x3CC2E50", VA = "0x183CC4250", Slot = "8")]
	protected override void HFMDKEOMMOI(FPOLAPAFDEF<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3CC42E0", Offset = "0x3CC2EE0", VA = "0x183CC42E0", Slot = "7")]
	protected override FPOLAPAFDEF<T> PAKONFKLIMF()
	{
		return default(FPOLAPAFDEF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4280", Offset = "0x3CC2E80", VA = "0x183CC4280", Slot = "6")]
	protected override Stack<T>.Enumerator JMCJOFLMHBP(Stack<T> NOOIIGLDGHB)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4170", Offset = "0x3CC2D70", VA = "0x183CC4170", Slot = "9")]
	protected override Stack<T> ENMBELGAIGO(FPOLAPAFDEF<T> KOKBEGHOPJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class CNHNPMNINGB<T> : BBLFAFJAEFA<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x31679D0", Offset = "0x31665D0", VA = "0x1831679D0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3152FF0", Offset = "0x3151BF0", VA = "0x183152FF0", Slot = "7")]
	protected override HashSet<T> PAKONFKLIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x37467C0", Offset = "0x37453C0", VA = "0x1837467C0", Slot = "6")]
	protected override HashSet<T>.Enumerator JMCJOFLMHBP(HashSet<T> NOOIIGLDGHB)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class PPHDAKEJFPG<T> : CMJOJEAGDCH<T, FPOLAPAFDEF<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4250", Offset = "0x3CC2E50", VA = "0x183CC4250", Slot = "8")]
	protected override void HFMDKEOMMOI(FPOLAPAFDEF<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x3EBE560", Offset = "0x3EBD160", VA = "0x183EBE560", Slot = "9")]
	protected override ReadOnlyCollection<T> ENMBELGAIGO(FPOLAPAFDEF<T> KOKBEGHOPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x3EBE600", Offset = "0x3EBD200", VA = "0x183EBE600", Slot = "7")]
	protected override FPOLAPAFDEF<T> PAKONFKLIMF()
	{
		return default(FPOLAPAFDEF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class NIMAFEJMNDM<T> : CMJOJEAGDCH<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x31679D0", Offset = "0x31665D0", VA = "0x1831679D0", Slot = "8")]
	protected override void HFMDKEOMMOI(List<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x3152FF0", Offset = "0x3151BF0", VA = "0x183152FF0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x31679D0", Offset = "0x31665D0", VA = "0x1831679D0", Slot = "8")]
	protected override void HFMDKEOMMOI(List<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3152FF0", Offset = "0x3151BF0", VA = "0x183152FF0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x3CC4250", Offset = "0x3CC2E50", VA = "0x183CC4250", Slot = "8")]
	protected override void HFMDKEOMMOI(FPOLAPAFDEF<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x3CC42E0", Offset = "0x3CC2EE0", VA = "0x183CC42E0", Slot = "7")]
	protected override FPOLAPAFDEF<T> PAKONFKLIMF()
	{
		return default(FPOLAPAFDEF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x4967FF0", Offset = "0x4966BF0", VA = "0x184967FF0", Slot = "9")]
	protected override IEnumerable<T> ENMBELGAIGO(FPOLAPAFDEF<T> KOKBEGHOPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x3145500", Offset = "0x3144100", VA = "0x183145500")]
	public CELLFHIHHPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class ABMHIILCNOP<TKey, TElement> : CBFHJMOMLDG<IGrouping<TKey, TElement>>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3547990", Offset = "0x3546590", VA = "0x183547990", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, IGrouping<TKey, TElement> GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3547690", Offset = "0x3546290", VA = "0x183547690", Slot = "5")]
	public IGrouping<TKey, TElement> JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class MOBFNPJHPCB<TKey, TElement> : CBFHJMOMLDG<ILookup<TKey, TElement>>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD140", Offset = "0x3CBBD40", VA = "0x183CBD140", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ILookup<TKey, TElement> GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCDF0", Offset = "0x3CBB9F0", VA = "0x183CBCDF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x38ED550", Offset = "0x38EC150", VA = "0x1838ED550", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x31D2E70", Offset = "0x31D1A70", VA = "0x1831D2E70", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x34C5C80", Offset = "0x34C4880", VA = "0x1834C5C80", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x38EC630", Offset = "0x38EB230", VA = "0x1838EC630", Slot = "5")]
	public bool Contains(TKey PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3E03970", Offset = "0x3E02570", VA = "0x183E03970", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3E03970", Offset = "0x3E02570", VA = "0x183E03970", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class MNKMIFFGFFH<T> : CBFHJMOMLDG<T>, LKLKMMHABOC where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC260", Offset = "0x3CBAE60", VA = "0x183CBC260", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3CBBFE0", Offset = "0x3CBABE0", VA = "0x183CBBFE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A3E00", Offset = "0x65A2A00", VA = "0x1865A3E00", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, IEnumerable GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x65A3BB0", Offset = "0x65A27B0", VA = "0x1865A3BB0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B4C00", Offset = "0x65B3800", VA = "0x1865B4C00", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ICollection GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x65B49B0", Offset = "0x65B35B0", VA = "0x1865B49B0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AEE60", Offset = "0x65ADA60", VA = "0x1865AEE60", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, IList GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x65AEC10", Offset = "0x65AD810", VA = "0x1865AEC10", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E063B0", Offset = "0x3E04FB0", VA = "0x183E063B0", Slot = "8")]
	protected override void HFMDKEOMMOI(FPOLAPAFDEF<T> GAHOHIBHCJI, int DCGGFHOCGGH, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3CC42E0", Offset = "0x3CC2EE0", VA = "0x183CC42E0", Slot = "7")]
	protected override FPOLAPAFDEF<T> PAKONFKLIMF()
	{
		return default(FPOLAPAFDEF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3E06360", Offset = "0x3E04F60", VA = "0x183E06360", Slot = "9")]
	protected override IReadOnlyList<T> ENMBELGAIGO(FPOLAPAFDEF<T> KOKBEGHOPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3144EA0", Offset = "0x3143AA0", VA = "0x183144EA0")]
	public ONKPPABFBBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class DADCIDJGLJE
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x65A76C0", Offset = "0x65A62C0", VA = "0x1865A76C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AAA40", Offset = "0x65A9640", VA = "0x1865AAA40", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, DateTime GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x65A9D30", Offset = "0x65A8930", VA = "0x1865A9D30", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A3490", Offset = "0x65A2090", VA = "0x1865A3490", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, DateTimeOffset GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x65A2870", Offset = "0x65A1470", VA = "0x1865A2870", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A8090", Offset = "0x65A6C90", VA = "0x1865A8090", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, TimeSpan GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x65A7780", Offset = "0x65A6380", VA = "0x1865A7780", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A385B0", Offset = "0x3A371B0", VA = "0x183A385B0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, TDictionary GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x3A34450", Offset = "0x3A33050", VA = "0x183A34450", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x318CC00", Offset = "0x318B800", VA = "0x18318CC00", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x34C6C20", Offset = "0x34C5820", VA = "0x1834C6C20", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3152FF0", Offset = "0x3151BF0", VA = "0x183152FF0", Slot = "7")]
	protected override Dictionary<TKey, TValue> PAKONFKLIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x34C6DB0", Offset = "0x34C59B0", VA = "0x1834C6DB0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator JMCJOFLMHBP(Dictionary<TKey, TValue> NOOIIGLDGHB)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3136E30", Offset = "0x3135A30", VA = "0x183136E30")]
	public FBPMGAJAMAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class IPBEMECJDFI<TKey, TValue, TDictionary> : JHNJJEPEAEE<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x3751E50", Offset = "0x3750A50", VA = "0x183751E50", Slot = "8")]
	protected override void HFMDKEOMMOI(TDictionary GAHOHIBHCJI, int DCGGFHOCGGH, TKey PPNDANAOAMK, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C7D0", Offset = "0x2F7B3D0", VA = "0x182F7C7D0", Slot = "7")]
	protected override TDictionary PAKONFKLIMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class EMINBKMBAFO<TKey, TValue> : ENDGOCHKPDG<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x318C320", Offset = "0x318AF20", VA = "0x18318C320", Slot = "8")]
	protected override void HFMDKEOMMOI(Dictionary<TKey, TValue> GAHOHIBHCJI, int DCGGFHOCGGH, TKey PPNDANAOAMK, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x3152FF0", Offset = "0x3151BF0", VA = "0x183152FF0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x318C320", Offset = "0x318AF20", VA = "0x18318C320", Slot = "8")]
	protected override void HFMDKEOMMOI(SortedList<TKey, TValue> GAHOHIBHCJI, int DCGGFHOCGGH, TKey PPNDANAOAMK, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3152FF0", Offset = "0x3151BF0", VA = "0x183152FF0", Slot = "7")]
	protected override SortedList<TKey, TValue> PAKONFKLIMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class ODBMBLPGHIK<TKey, TValue> : LEDFIBGKFDE<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x318C320", Offset = "0x318AF20", VA = "0x18318C320", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3152FF0", Offset = "0x3151BF0", VA = "0x183152FF0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> PAKONFKLIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x34C6E20", Offset = "0x34C5A20", VA = "0x1834C6E20", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator JMCJOFLMHBP(SortedDictionary<TKey, TValue> NOOIIGLDGHB)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class AAODPGEBANJ<T> : CBFHJMOMLDG<T>, LKLKMMHABOC where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3545C80", Offset = "0x3544880", VA = "0x183545C80", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x35459E0", Offset = "0x35445E0", VA = "0x1835459E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65ACA10", Offset = "0x65AB610", VA = "0x1865ACA10", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, IDictionary GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x65AC7E0", Offset = "0x65AB3E0", VA = "0x1865AC7E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AC090", Offset = "0x65AAC90", VA = "0x1865AC090")]
	public EMNJMKEJEAP(params KJHGDFDBIIA[] CGKJJLMOOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x65AB6D0", Offset = "0x65AA2D0", VA = "0x1865AB6D0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, object GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x65AB640", Offset = "0x65AA240", VA = "0x1865AB640", Slot = "5")]
	public object JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class AOPJAGJBLKM
{
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x65A4D60", Offset = "0x65A3960", VA = "0x1865A4D60")]
	public static object DHDAKGLHDJE(Type OMKEAAPIABA, [Out] bool OCJAEOCALDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x65A4470", Offset = "0x65A3070", VA = "0x1865A4470")]
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
		[Cpp2IlInjected.Address(RVA = "0x3972B20", Offset = "0x3971720", VA = "0x183972B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C8D8C0", Offset = "0x3C8C4C0", VA = "0x183C8D8C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x37187B0", Offset = "0x37173B0", VA = "0x1837187B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x34D2E00", Offset = "0x34D1A00", VA = "0x1834D2E00")]
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
	[Cpp2IlInjected.Address(RVA = "0x4DFC190", Offset = "0x4DFAD90", VA = "0x184DFC190")]
	static DDBMAJAJPAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x4E04180", Offset = "0x4E02D80", VA = "0x184E04180")]
	public DDBMAJAJPAP(bool CLLBKBBFJMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x4DF33C0", Offset = "0x4DF1FC0", VA = "0x184DF33C0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x4DEF4A0", Offset = "0x4DEE0A0", VA = "0x184DEF4A0", Slot = "5")]
	public T JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x4DF2690", Offset = "0x4DF1290", VA = "0x184DF2690", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, T GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x4DEE340", Offset = "0x4DECF40", VA = "0x184DEE340", Slot = "7")]
	public T DLBCEPAMKAF(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class GDIHFPIMLCG<T> : CBFHJMOMLDG<T[,]>, LKLKMMHABOC
{
	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x35B1630", Offset = "0x35B0230", VA = "0x1835B1630", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T[,] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x35B1300", Offset = "0x35AFF00", VA = "0x1835B1300", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3CB5510", Offset = "0x3CB4110", VA = "0x183CB5510", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T[,,] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3CB50D0", Offset = "0x3CB3CD0", VA = "0x183CB50D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x318BF40", Offset = "0x318AB40", VA = "0x18318BF40", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T[,,,] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x318B9F0", Offset = "0x318A5F0", VA = "0x18318B9F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3CB4590", Offset = "0x3CB3190", VA = "0x183CB4590", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4210", Offset = "0x3CB2E10", VA = "0x183CB4210", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A53060", Offset = "0x3A51C60", VA = "0x183A53060", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, T? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A52410", Offset = "0x3A51010", VA = "0x183A52410", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AFCC0", Offset = "0x65AE8C0", VA = "0x1865AFCC0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, sbyte GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x65AFC00", Offset = "0x65AE800", VA = "0x1865AFC00", Slot = "5")]
	public sbyte JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x65AFC50", Offset = "0x65AE850", VA = "0x1865AFC50", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, sbyte GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x65AFB40", Offset = "0x65AE740", VA = "0x1865AFB40", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A22A0", Offset = "0x65A0EA0", VA = "0x1865A22A0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, sbyte? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x65A2130", Offset = "0x65A0D30", VA = "0x1865A2130", Slot = "5")]
	public sbyte? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x65A21E0", Offset = "0x65A0DE0", VA = "0x1865A21E0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, sbyte? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x65A2010", Offset = "0x65A0C10", VA = "0x1865A2010", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A42C0", Offset = "0x65A2EC0", VA = "0x1865A42C0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, sbyte[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x65A4130", Offset = "0x65A2D30", VA = "0x1865A4130", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AE350", Offset = "0x65ACF50", VA = "0x1865AE350", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, short GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x65AE290", Offset = "0x65ACE90", VA = "0x1865AE290", Slot = "5")]
	public short JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x65AE2E0", Offset = "0x65ACEE0", VA = "0x1865AE2E0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, short GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x65AE1D0", Offset = "0x65ACDD0", VA = "0x1865AE1D0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AD5D0", Offset = "0x65AC1D0", VA = "0x1865AD5D0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, short? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x65AD460", Offset = "0x65AC060", VA = "0x1865AD460", Slot = "5")]
	public short? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x65AD510", Offset = "0x65AC110", VA = "0x1865AD510", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, short? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x65AD340", Offset = "0x65ABF40", VA = "0x1865AD340", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AF3A0", Offset = "0x65ADFA0", VA = "0x1865AF3A0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, short[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x65AF210", Offset = "0x65ADE10", VA = "0x1865AF210", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B4300", Offset = "0x65B2F00", VA = "0x1865B4300", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, int GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x65B4240", Offset = "0x65B2E40", VA = "0x1865B4240", Slot = "5")]
	public int JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x65B4290", Offset = "0x65B2E90", VA = "0x1865B4290", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, int GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x65B4180", Offset = "0x65B2D80", VA = "0x1865B4180", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AD200", Offset = "0x65ABE00", VA = "0x1865AD200", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, int? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x65AD090", Offset = "0x65ABC90", VA = "0x1865AD090", Slot = "5")]
	public int? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x65AD140", Offset = "0x65ABD40", VA = "0x1865AD140", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, int? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x65ACF70", Offset = "0x65ABB70", VA = "0x1865ACF70", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65ADDC0", Offset = "0x65AC9C0", VA = "0x1865ADDC0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, int[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x65ADC30", Offset = "0x65AC830", VA = "0x1865ADC30", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B36B0", Offset = "0x65B22B0", VA = "0x1865B36B0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, long GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x65B35F0", Offset = "0x65B21F0", VA = "0x1865B35F0", Slot = "5")]
	public long JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x65B3640", Offset = "0x65B2240", VA = "0x1865B3640", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, long GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x65B3530", Offset = "0x65B2130", VA = "0x1865B3530", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A7210", Offset = "0x65A5E10", VA = "0x1865A7210", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, long? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x65A7090", Offset = "0x65A5C90", VA = "0x1865A7090", Slot = "5")]
	public long? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x65A7150", Offset = "0x65A5D50", VA = "0x1865A7150", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, long? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x65A6F50", Offset = "0x65A5B50", VA = "0x1865A6F50", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B1050", Offset = "0x65AFC50", VA = "0x1865B1050", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, long[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x65B0EC0", Offset = "0x65AFAC0", VA = "0x1865B0EC0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AC700", Offset = "0x65AB300", VA = "0x1865AC700", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, byte GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x65AC640", Offset = "0x65AB240", VA = "0x1865AC640", Slot = "5")]
	public byte JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x65AC690", Offset = "0x65AB290", VA = "0x1865AC690", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, byte GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x65AC580", Offset = "0x65AB180", VA = "0x1865AC580", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B4870", Offset = "0x65B3470", VA = "0x1865B4870", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, byte? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x65B4700", Offset = "0x65B3300", VA = "0x1865B4700", Slot = "5")]
	public byte? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x65B47B0", Offset = "0x65B33B0", VA = "0x1865B47B0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, byte? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x65B45E0", Offset = "0x65B31E0", VA = "0x1865B45E0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A96F0", Offset = "0x65A82F0", VA = "0x1865A96F0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ushort GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x65A9630", Offset = "0x65A8230", VA = "0x1865A9630", Slot = "5")]
	public ushort JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x65A9680", Offset = "0x65A8280", VA = "0x1865A9680", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, ushort GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x65A9570", Offset = "0x65A8170", VA = "0x1865A9570", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AB500", Offset = "0x65AA100", VA = "0x1865AB500", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ushort? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x65AB390", Offset = "0x65A9F90", VA = "0x1865AB390", Slot = "5")]
	public ushort? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x65AB440", Offset = "0x65AA040", VA = "0x1865AB440", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, ushort? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x65AB270", Offset = "0x65A9E70", VA = "0x1865AB270", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A2570", Offset = "0x65A1170", VA = "0x1865A2570", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ushort[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x65A23E0", Offset = "0x65A0FE0", VA = "0x1865A23E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AE0F0", Offset = "0x65ACCF0", VA = "0x1865AE0F0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, uint GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x65AE030", Offset = "0x65ACC30", VA = "0x1865AE030", Slot = "5")]
	public uint JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x65AE080", Offset = "0x65ACC80", VA = "0x1865AE080", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, uint GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x65ADF70", Offset = "0x65ACB70", VA = "0x1865ADF70", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B33F0", Offset = "0x65B1FF0", VA = "0x1865B33F0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, uint? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x65B3280", Offset = "0x65B1E80", VA = "0x1865B3280", Slot = "5")]
	public uint? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x65B3330", Offset = "0x65B1F30", VA = "0x1865B3330", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, uint? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x65B3160", Offset = "0x65B1D60", VA = "0x1865B3160", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B0300", Offset = "0x65AEF00", VA = "0x1865B0300", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, uint[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x65B0170", Offset = "0x65AED70", VA = "0x1865B0170", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A8750", Offset = "0x65A7350", VA = "0x1865A8750", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ulong GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x65A8690", Offset = "0x65A7290", VA = "0x1865A8690", Slot = "5")]
	public ulong JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x65A86E0", Offset = "0x65A72E0", VA = "0x1865A86E0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, ulong GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x65A85D0", Offset = "0x65A71D0", VA = "0x1865A85D0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A9430", Offset = "0x65A8030", VA = "0x1865A9430", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ulong? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x65A92B0", Offset = "0x65A7EB0", VA = "0x1865A92B0", Slot = "5")]
	public ulong? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x65A9370", Offset = "0x65A7F70", VA = "0x1865A9370", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, ulong? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x65A9170", Offset = "0x65A7D70", VA = "0x1865A9170", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65ADA80", Offset = "0x65AC680", VA = "0x1865ADA80", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ulong[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x65AD8F0", Offset = "0x65AC4F0", VA = "0x1865AD8F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A6E70", Offset = "0x65A5A70", VA = "0x1865A6E70", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, float GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x65A6DB0", Offset = "0x65A59B0", VA = "0x1865A6DB0", Slot = "5")]
	public float JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x65A6E00", Offset = "0x65A5A00", VA = "0x1865A6E00", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, float GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x65A6CF0", Offset = "0x65A58F0", VA = "0x1865A6CF0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B0030", Offset = "0x65AEC30", VA = "0x1865B0030", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, float? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x65AFEC0", Offset = "0x65AEAC0", VA = "0x1865AFEC0", Slot = "5")]
	public float? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x65AFF70", Offset = "0x65AEB70", VA = "0x1865AFF70", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, float? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x65AFDA0", Offset = "0x65AE9A0", VA = "0x1865AFDA0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A9B70", Offset = "0x65A8770", VA = "0x1865A9B70", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, float[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x65A99E0", Offset = "0x65A85E0", VA = "0x1865A99E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B40A0", Offset = "0x65B2CA0", VA = "0x1865B40A0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, double GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x65B3FE0", Offset = "0x65B2BE0", VA = "0x1865B3FE0", Slot = "5")]
	public double JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x65B4030", Offset = "0x65B2C30", VA = "0x1865B4030", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, double GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x65B3F20", Offset = "0x65B2B20", VA = "0x1865B3F20", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A9030", Offset = "0x65A7C30", VA = "0x1865A9030", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, double? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x65A8EB0", Offset = "0x65A7AB0", VA = "0x1865A8EB0", Slot = "5")]
	public double? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x65A8F70", Offset = "0x65A7B70", VA = "0x1865A8F70", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, double? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x65A8D70", Offset = "0x65A7970", VA = "0x1865A8D70", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A8BB0", Offset = "0x65A77B0", VA = "0x1865A8BB0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, double[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x65A8A20", Offset = "0x65A7620", VA = "0x1865A8A20", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AC2C0", Offset = "0x65AAEC0", VA = "0x1865AC2C0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, bool GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x65AC200", Offset = "0x65AAE00", VA = "0x1865AC200", Slot = "5")]
	public bool JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x65AC250", Offset = "0x65AAE50", VA = "0x1865AC250", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, bool GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x65AC140", Offset = "0x65AAD40", VA = "0x1865AC140", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AF7E0", Offset = "0x65AE3E0", VA = "0x1865AF7E0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, bool? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x65AF670", Offset = "0x65AE270", VA = "0x1865AF670", Slot = "5")]
	public bool? JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x65AF720", Offset = "0x65AE320", VA = "0x1865AF720", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, bool? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x65AF550", Offset = "0x65AE150", VA = "0x1865AF550", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B0A60", Offset = "0x65AF660", VA = "0x1865B0A60", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, bool[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x65B08D0", Offset = "0x65AF4D0", VA = "0x1865B08D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A5A90", Offset = "0x65A4690", VA = "0x1865A5A90", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, object GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x65A5650", Offset = "0x65A4250", VA = "0x1865A5650", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A88E0", Offset = "0x65A74E0", VA = "0x1865A88E0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, byte[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x65A8830", Offset = "0x65A7430", VA = "0x1865A8830", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B38A0", Offset = "0x65B24A0", VA = "0x1865B38A0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, ArraySegment<byte> GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x65B3790", Offset = "0x65B2390", VA = "0x1865B3790", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AD810", Offset = "0x65AC410", VA = "0x1865AD810", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, string GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x65AD760", Offset = "0x65AC360", VA = "0x1865AD760", Slot = "5")]
	public string JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x65AD7B0", Offset = "0x65AC3B0", VA = "0x1865AD7B0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, string GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x65AD710", Offset = "0x65AC310", VA = "0x1865AD710", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B13D0", Offset = "0x65AFFD0", VA = "0x1865B13D0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, string[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x65B1200", Offset = "0x65AFE00", VA = "0x1865B1200", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A6BB0", Offset = "0x65A57B0", VA = "0x1865A6BB0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, char GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x65A6B40", Offset = "0x65A5740", VA = "0x1865A6B40", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B0D40", Offset = "0x65AF940", VA = "0x1865B0D40", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, char? GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x65B0C20", Offset = "0x65AF820", VA = "0x1865B0C20", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AE9E0", Offset = "0x65AD5E0", VA = "0x1865AE9E0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, char[] GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x65AE820", Offset = "0x65AD420", VA = "0x1865AE820", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B0720", Offset = "0x65AF320", VA = "0x1865B0720", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Guid GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x65B0550", Offset = "0x65AF150", VA = "0x1865B0550", Slot = "5")]
	public Guid JFKFFNFOIMD(EPGBDNIILDN BIBCAMINPDH, KJHGDFDBIIA AKNIKANEBIH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x65B05E0", Offset = "0x65AF1E0", VA = "0x1865B05E0", Slot = "6")]
	public void KPPEENGEIJJ(CJMDLGBHBBN BNGNOICJJGA, Guid GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x65B04B0", Offset = "0x65AF0B0", VA = "0x1865B04B0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x502E9D0", Offset = "0x502D5D0", VA = "0x18502E9D0")]
	public PEPAJLBCLKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x16DA440", Offset = "0x16D9040", VA = "0x1816DA440")]
	public PEPAJLBCLKM(bool EGDLCNLFPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x65B3CF0", Offset = "0x65B28F0", VA = "0x1865B3CF0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, decimal GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x65B3A50", Offset = "0x65B2650", VA = "0x1865B3A50", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AF9E0", Offset = "0x65AE5E0", VA = "0x1865AF9E0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Uri GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x65AF920", Offset = "0x65AE520", VA = "0x1865AF920", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B44A0", Offset = "0x65B30A0", VA = "0x1865B44A0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Version GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x65B43E0", Offset = "0x65B2FE0", VA = "0x1865B43E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x370A8B0", Offset = "0x37094B0", VA = "0x18370A8B0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, KeyValuePair<TKey, TValue> GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x370A580", Offset = "0x3709180", VA = "0x18370A580", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AC460", Offset = "0x65AB060", VA = "0x1865AC460", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, StringBuilder GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x65AC3A0", Offset = "0x65AAFA0", VA = "0x1865AC3A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B1700", Offset = "0x65B0300", VA = "0x1865B1700", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, BitArray GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x65B1580", Offset = "0x65B0180", VA = "0x1865B1580", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A76A0", Offset = "0x65A62A0", VA = "0x1865A76A0")]
	public COAMDEKGOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D38020", Offset = "0x5D36C20", VA = "0x185D38020")]
	public COAMDEKGOAP(bool OLAJIGPMGIC, bool IBBKHHMMELD, bool LIKEDFKHOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x65A74A0", Offset = "0x65A60A0", VA = "0x1865A74A0", Slot = "4")]
	public void OIIEHDKDHEB(CJMDLGBHBBN BNGNOICJJGA, Type GCPEEAODAIB, KJHGDFDBIIA AKNIKANEBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x65A7350", Offset = "0x65A5F50", VA = "0x1865A7350", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AE430", Offset = "0x65AD030", VA = "0x1865AE430")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A97D0", Offset = "0x65A83D0", VA = "0x1865A97D0")]
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
