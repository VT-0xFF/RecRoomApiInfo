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
public class KMKKFPPIKMM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x74FCB0", Offset = "0x74E4B0", VA = "0x18074FCB0")]
	public KMKKFPPIKMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class ACKAKJNJPCN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x74FCB0", Offset = "0x74E4B0", VA = "0x18074FCB0")]
	public ACKAKJNJPCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class MPHMBGNALJB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x74FCB0", Offset = "0x74E4B0", VA = "0x18074FCB0")]
	public MPHMBGNALJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class FOAIFPBMDFL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x74FCB0", Offset = "0x74E4B0", VA = "0x18074FCB0")]
	public FOAIFPBMDFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class LBBDKJCEACF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x171D3B0", Offset = "0x171BBB0", VA = "0x18171D3B0")]
	public static bool AAPCJNAOCEM(this TypeInfo BCFKLEGAMEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class NAKNOGOBLMG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type HFNGLDDAIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F8060", Offset = "0x6F6860", VA = "0x1806F8060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] PEDALJFOEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x727730", Offset = "0x725F30", VA = "0x180727730")]
	public NAKNOGOBLMG(Type NLNGAAILPIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class OHPOKOEEHAP : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void BKKGNGKDABO<T>(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T IKNPCAKNFFF<T>(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF EPCNJMCAAGN);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LOIEEHPBJBK
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HAKOMFHEDCC<T> : LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PEHGKAMCACG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum ENFHMOLIHKA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class INOOENGEAAF
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x33A0050", Offset = "0x339E850", VA = "0x1833A0050")]
	public static global::HAKOMFHEDCC<T> NGBFDKMKBBL<T>(this IEIMAIBIIFF EPCNJMCAAGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x171ADE0", Offset = "0x17195E0", VA = "0x18171ADE0")]
	public static object NAIBINIPFDO(this IEIMAIBIIFF EPCNJMCAAGN, Type BCFKLEGAMEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JGBJFILBOLO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x171B330", Offset = "0x1719B30", VA = "0x18171B330")]
	public JGBJFILBOLO(string NJAIIGFCHNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct GOCMFGPNGFE
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class NLBDDPKDIAB
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] NCCOCLJLPFP;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] KLHFOHACFMH;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x18E0100", Offset = "0x18DE900", VA = "0x1818E0100")]
		public static byte[] MNPKOLKGMCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x18E0070", Offset = "0x18DE870", VA = "0x1818E0070")]
		public static char[] FKBMJAKPKEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> KLNOGJCHHCF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] OEEDNOFJGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] CDDAIIMDJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int EGBIMJLECFF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool BCJCCJJNKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1714970", Offset = "0x1713170", VA = "0x181714970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1716A90", Offset = "0x1715290", VA = "0x181716A90")]
	public GOCMFGPNGFE(byte[] CDDAIIMDJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x17168A0", Offset = "0x17150A0", VA = "0x1817168A0")]
	public GOCMFGPNGFE(byte[] CDDAIIMDJCN, int EGBIMJLECFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x17140C0", Offset = "0x17128C0", VA = "0x1817140C0")]
	private AAADFHNEBBG CFJFEAKGPCO(string MHMMCHLDEKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1713FE0", Offset = "0x17127E0", VA = "0x181713FE0")]
	private AAADFHNEBBG BNFOMOHMAPO(string NJAIIGFCHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1714DC0", Offset = "0x17135C0", VA = "0x181714DC0")]
	public void FBIKDBPLAJE(int EGBIMJLECFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7579C0", Offset = "0x7561C0", VA = "0x1807579C0")]
	public byte[] OADEJILKOJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x81AE00", Offset = "0x819600", VA = "0x18081AE00")]
	public int PCEMIJBKLDG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1715400", Offset = "0x1713C00", VA = "0x181715400")]
	public KIFJOJNEDMC KEICCDCFFKB()
	{
		return default(KIFJOJNEDMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1714650", Offset = "0x1712E50", VA = "0x181714650")]
	public void CLDFNNMNHNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x17150E0", Offset = "0x17138E0", VA = "0x1817150E0")]
	public bool HKJCECDMGOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1715910", Offset = "0x1714110", VA = "0x181715910")]
	public bool MPHOMCDOKPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1715880", Offset = "0x1714080", VA = "0x181715880")]
	public void MGHMIJBODKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1714F60", Offset = "0x1713760", VA = "0x181714F60")]
	public bool FMGMGOFOKBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1715380", Offset = "0x1713B80", VA = "0x181715380")]
	public bool JJIKMBONEIA(ref int LGKBEOCJMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x17161F0", Offset = "0x17149F0", VA = "0x1817161F0")]
	public bool OFOKJKBHMEE(ref int LGKBEOCJMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1714D10", Offset = "0x1713510", VA = "0x181714D10")]
	public bool EKKCKHGNDHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1713D40", Offset = "0x1712540", VA = "0x181713D40")]
	public void BDHGMFNHFCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1713C10", Offset = "0x1712410", VA = "0x181713C10")]
	public bool AGBCHMENDGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1713B90", Offset = "0x1712390", VA = "0x181713B90")]
	public bool AALKAAHAKEI(ref int LGKBEOCJMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1714FC0", Offset = "0x17137C0", VA = "0x181714FC0")]
	public bool GEBPKNOIAGL(ref int LGKBEOCJMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1715820", Offset = "0x1714020", VA = "0x181715820")]
	public bool MCBIFLLMAHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1715290", Offset = "0x1713A90", VA = "0x181715290")]
	public void JFFGPHKJMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1715080", Offset = "0x1713880", VA = "0x181715080")]
	public bool HEJFFAGMNHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x17159A0", Offset = "0x17141A0", VA = "0x1817159A0")]
	public void NBKHCDFFMNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1715A30", Offset = "0x1714230", VA = "0x181715A30")]
	private void OBMFECMGHHB(out byte[] CILJOEKBECL, out int ECMBJPPOFHN, out int LAFCKHKJKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1714C60", Offset = "0x1713460", VA = "0x181714C60")]
	private static int EGBJNLHNPDM(char DOGOAAONBOH, char ENHIJCCJFBF, char ODCENIJJKIC, char BOMCMOAJNIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x17162B0", Offset = "0x1714AB0", VA = "0x1817162B0")]
	private static int OHIJCNLGBED(char ODLLFOGPPIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1716400", Offset = "0x1714C00", VA = "0x181716400")]
	public ArraySegment<byte> PELLMPJALID()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x17151E0", Offset = "0x17139E0", VA = "0x1817151E0")]
	public string IDGKGMLDGCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1715970", Offset = "0x1714170", VA = "0x181715970")]
	public string MPJPIAKCGLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1714A30", Offset = "0x1713230", VA = "0x181714A30")]
	public ArraySegment<byte> DNIMPBGAOLH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x17149F0", Offset = "0x17131F0", VA = "0x1817149F0")]
	public ArraySegment<byte> DIDOJCGAJHL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1716500", Offset = "0x1714D00", VA = "0x181716500")]
	public bool PHHFPHGKEHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1713F20", Offset = "0x1712720", VA = "0x181713F20")]
	private static bool BMNDPKPHBOL(byte ODCENIJJKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1714790", Offset = "0x1712F90", VA = "0x181714790")]
	private void CPGCGEFDHJH(KIFJOJNEDMC FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1715280", Offset = "0x1713A80", VA = "0x181715280")]
	public void IDONKGNHIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1713C70", Offset = "0x1712470", VA = "0x181713C70")]
	private void ALPMAHNEAGH(int EMHPFBDHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1714D70", Offset = "0x1713570", VA = "0x181714D70")]
	public sbyte ENIFFBLFONM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1715670", Offset = "0x1713E70", VA = "0x181715670")]
	public short LJPINJKNAOG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1716740", Offset = "0x1714F40", VA = "0x181716740")]
	public int PMGMFGBIFDG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1716380", Offset = "0x1714B80", VA = "0x181716380")]
	public long OKAACLJBNNN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1715320", Offset = "0x1713B20", VA = "0x181715320")]
	public byte JGDKDGKAPBP()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1714C00", Offset = "0x1713400", VA = "0x181714C00")]
	public ushort EACPFKLCNCF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1714990", Offset = "0x1713190", VA = "0x181714990")]
	public uint DDDBNCKOJAF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x17145D0", Offset = "0x1712DD0", VA = "0x1817145D0")]
	public ulong CHHDFFDMPBB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x17156D0", Offset = "0x1713ED0", VA = "0x1817156D0")]
	public float LOHCAAFDECB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1713DD0", Offset = "0x17125D0", VA = "0x181713DD0")]
	public double BGCLNPNNNGI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1715580", Offset = "0x1713D80", VA = "0x181715580")]
	public ArraySegment<byte> LAEIFHDKDGG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1714DD0", Offset = "0x17135D0", VA = "0x181714DD0")]
	private static int FLFEGMMINAA(byte[] CDDAIIMDJCN, int EGBIMJLECFF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AAADFHNEBBG : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference CKDHMPCCHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int GCGFDEDCKFE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int EIBPFOJGGLG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7E96D0", Offset = "0x7E7ED0", VA = "0x1807E96D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string LHDJJLEAMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x76CC90", Offset = "0x76B490", VA = "0x18076CC90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x18813B0", Offset = "0x187FBB0", VA = "0x1818813B0")]
	public AAADFHNEBBG(string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1881420", Offset = "0x187FC20", VA = "0x181881420")]
	public AAADFHNEBBG(string NJAIIGFCHNG, byte[] MNOLNPDECCF, int EGBIMJLECFF, int GCGFDEDCKFE, string IDKDIFOJOBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EMNCNFOPOMA
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class LNGCKHKDIPM
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void LCLIGGEFKKL(ref KNPMIFIKMDA FBNHINKPMEA, object CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object DNBLAKEHKEK(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF EPCNJMCAAGN);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class KJHJNOAGOHM
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class GCEOGANGEMC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
				public GCEOGANGEMC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0xBD30D0", Offset = "0xBD18D0", VA = "0x180BD30D0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x18D4DB0", Offset = "0x18D35B0", VA = "0x1818D4DB0")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, IEIMAIBIIFF, byte[]> LFOKJLAFKAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, IEIMAIBIIFF> MCCBEAFHCKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly LCLIGGEFKKL KOFELLINPJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, IEIMAIBIIFF, ArraySegment<byte>> HFMGDLHKFDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, IEIMAIBIIFF, string> ELIMCHOBDAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, IEIMAIBIIFF, object> HMFOCLJLAGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, IEIMAIBIIFF, object> CAELGPBNHLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, IEIMAIBIIFF, object> IKJKFDIBMOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly DNBLAKEHKEK HGEIBOCJJFP;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x18DA440", Offset = "0x18D8C40", VA = "0x1818DA440")]
			public KJHJNOAGOHM(Type BCFKLEGAMEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x3D31EA0", Offset = "0x3D306A0", VA = "0x183D31EA0")]
			private static T MNHABAMNCFC<T>(DynamicMethod PJFLEMONMDK)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x18DA1F0", Offset = "0x18D89F0", VA = "0x1818DA1F0")]
			private static MethodInfo CPDGOCCCLIG(Type BCFKLEGAMEO, string FOGNBJMCDMG, Type[] OAHJKCAELAJ)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, KJHJNOAGOHM> GAMOADLLPAJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::JMJBDOGCDKP<KJHJNOAGOHM> OPPGCCMLFOA;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x18DEF20", Offset = "0x18DD720", VA = "0x1818DEF20")]
		static LNGCKHKDIPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x18DEBE0", Offset = "0x18DD3E0", VA = "0x1818DEBE0")]
		private static KJHJNOAGOHM FNLIBAGKGPC(Type BCFKLEGAMEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x18DEC70", Offset = "0x18DD470", VA = "0x1818DEC70")]
		public static void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, object CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x18DEE00", Offset = "0x18DD600", VA = "0x1818DEE00")]
		public static void HHDOHEHKDKI(Type BCFKLEGAMEO, ref KNPMIFIKMDA FBNHINKPMEA, object CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class NEAODCLGCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] NCCOCLJLPFP;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x18DF220", Offset = "0x18DDA20", VA = "0x1818DF220")]
		public static byte[] MNPKOLKGMCE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static IEIMAIBIIFF MHAEGNLIOGK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] KADCFLNKGNA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] NJILKDCLILB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static IEIMAIBIIFF FCJCJLEINOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1898B30", Offset = "0x1897330", VA = "0x181898B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool ELDHHCEEDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1899440", Offset = "0x1897C40", VA = "0x181899440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x18994A0", Offset = "0x1897CA0", VA = "0x1818994A0")]
	public static void OCNNNLHNKEP(IEIMAIBIIFF EPCNJMCAAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x37ED810", Offset = "0x37EC010", VA = "0x1837ED810")]
	public static byte[] HHDOHEHKDKI<T>(T ODMJCJPGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x37EDA40", Offset = "0x37EC240", VA = "0x1837EDA40")]
	public static byte[] HHDOHEHKDKI<T>(T CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x37ED890", Offset = "0x37EC090", VA = "0x1837ED890")]
	public static void HHDOHEHKDKI<T>(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x37ED6A0", Offset = "0x37EBEA0", VA = "0x1837ED6A0")]
	public static void HHDOHEHKDKI<T>(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x37ED780", Offset = "0x37EBF80", VA = "0x1837ED780")]
	public static void HHDOHEHKDKI<T>(Stream JMJPBBLODJI, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x37ED920", Offset = "0x37EC120", VA = "0x1837ED920")]
	public static void HHDOHEHKDKI<T>(Stream JMJPBBLODJI, T CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x37ED600", Offset = "0x37EBE00", VA = "0x1837ED600")]
	public static ArraySegment<byte> DDFDFIGGKEK<T>(T ODMJCJPGHNI)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x37ED480", Offset = "0x37EBC80", VA = "0x1837ED480")]
	public static ArraySegment<byte> DDFDFIGGKEK<T>(T CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x37EDBA0", Offset = "0x37EC3A0", VA = "0x1837EDBA0")]
	public static string POJABMFPPIP<T>(T CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x37EDC20", Offset = "0x37EC420", VA = "0x1837EDC20")]
	public static string POJABMFPPIP<T>(T CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x37EC9C0", Offset = "0x37EB1C0", VA = "0x1837EC9C0")]
	public static T ADHMOLAJGDE<T>(string OEAPFLDGOAL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x37ECB00", Offset = "0x37EB300", VA = "0x1837ECB00")]
	public static T ADHMOLAJGDE<T>(string OEAPFLDGOAL, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x37ED230", Offset = "0x37EBA30", VA = "0x1837ED230")]
	public static T ADHMOLAJGDE<T>(byte[] CDDAIIMDJCN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x37ECA60", Offset = "0x37EB260", VA = "0x1837ECA60")]
	public static T ADHMOLAJGDE<T>(byte[] CDDAIIMDJCN, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x37ECE90", Offset = "0x37EB690", VA = "0x1837ECE90")]
	public static T ADHMOLAJGDE<T>(byte[] CDDAIIMDJCN, int EGBIMJLECFF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x37ECBF0", Offset = "0x37EB3F0", VA = "0x1837ECBF0")]
	public static T ADHMOLAJGDE<T>(byte[] CDDAIIMDJCN, int EGBIMJLECFF, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x37ECFA0", Offset = "0x37EB7A0", VA = "0x1837ECFA0")]
	public static T ADHMOLAJGDE<T>(ref GOCMFGPNGFE CLOGDHPGNHC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x37ED3B0", Offset = "0x37EBBB0", VA = "0x1837ED3B0")]
	public static T ADHMOLAJGDE<T>(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x37ED2B0", Offset = "0x37EBAB0", VA = "0x1837ED2B0")]
	public static T ADHMOLAJGDE<T>(Stream JMJPBBLODJI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x37ED100", Offset = "0x37EB900", VA = "0x1837ED100")]
	public static T ADHMOLAJGDE<T>(Stream JMJPBBLODJI, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x18988D0", Offset = "0x18970D0", VA = "0x1818988D0")]
	public static string DJKDIHJGAFH(byte[] OEAPFLDGOAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x18989B0", Offset = "0x18971B0", VA = "0x1818989B0")]
	public static string DJKDIHJGAFH(byte[] OEAPFLDGOAL, int EGBIMJLECFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1898A60", Offset = "0x1897260", VA = "0x181898A60")]
	public static string DJKDIHJGAFH(string OEAPFLDGOAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x18991E0", Offset = "0x18979E0", VA = "0x1818991E0")]
	public static byte[] LFCNBDGNIMB(byte[] OEAPFLDGOAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x18992C0", Offset = "0x1897AC0", VA = "0x1818992C0")]
	public static byte[] LFCNBDGNIMB(byte[] OEAPFLDGOAL, int EGBIMJLECFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1899370", Offset = "0x1897B70", VA = "0x181899370")]
	public static byte[] LFCNBDGNIMB(string OEAPFLDGOAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1898CF0", Offset = "0x18974F0", VA = "0x181898CF0")]
	private static void LDIPLNCKOJB(ref GOCMFGPNGFE CLOGDHPGNHC, ref KNPMIFIKMDA FBNHINKPMEA, int FOCIGJDPHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1898C50", Offset = "0x1897450", VA = "0x181898C50")]
	private static int HCAAIGCHDPI(Stream KAKCHGJCKMF, ref byte[] NCCOCLJLPFP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum KIFJOJNEDMC : byte
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
public struct KNPMIFIKMDA
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] PFEBFHEGALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] NCCOCLJLPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int EGBIMJLECFF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EIHKBFKLBAM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x81AE00", Offset = "0x819600", VA = "0x18081AE00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1714DC0", Offset = "0x17135C0", VA = "0x181714DC0")]
	public void FBIKDBPLAJE(int EGBIMJLECFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x171D1F0", Offset = "0x171B9F0", VA = "0x18171D1F0")]
	public static byte[] PPHIFGDGCBM(string BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x171C8D0", Offset = "0x171B0D0", VA = "0x18171C8D0")]
	public static byte[] IAGKEPPFCHI(string BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x171CA10", Offset = "0x171B210", VA = "0x18171CA10")]
	public static byte[] IMLBEDMMGJI(string BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x171D020", Offset = "0x171B820", VA = "0x18171D020")]
	public static byte[] OFPEGINFOBI(string BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x171D390", Offset = "0x171BB90", VA = "0x18171D390")]
	public KNPMIFIKMDA(byte[] KBMEIMDNMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x171CF40", Offset = "0x171B740", VA = "0x18171CF40")]
	public ArraySegment<byte> MNPKOLKGMCE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x171CB50", Offset = "0x171B350", VA = "0x18171CB50")]
	public byte[] IOAKNHHCNFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x171D2D0", Offset = "0x171BAD0", VA = "0x18171D2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x171CCB0", Offset = "0x171B4B0", VA = "0x18171CCB0")]
	public void LOKAJEFELOL(int ANPLBJOGOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x171BE80", Offset = "0x171A680", VA = "0x18171BE80")]
	public void BOIJDCIIDIP(byte OHDCIAFGHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x171C470", Offset = "0x171AC70", VA = "0x18171C470")]
	public void BOIJDCIIDIP(byte[] OHDCIAFGHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x171CC70", Offset = "0x171B470", VA = "0x18171CC70")]
	public void LKHHGPBMDFL(byte OHDCIAFGHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x171CBD0", Offset = "0x171B3D0", VA = "0x18171CBD0")]
	public void JFOKLJCCOEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x171D1A0", Offset = "0x171B9A0", VA = "0x18171D1A0")]
	public void OONKAKAHOCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x171C5D0", Offset = "0x171ADD0", VA = "0x18171C5D0")]
	public void DDDNHKIFEDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x171CC20", Offset = "0x171B420", VA = "0x18171CC20")]
	public void JGEPHLJPNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x171C7E0", Offset = "0x171AFE0", VA = "0x18171C7E0")]
	public void FMNOHHJBEDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x171C880", Offset = "0x171B080", VA = "0x18171C880")]
	public void HNEDCMBJGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x171CCC0", Offset = "0x171B4C0", VA = "0x18171CCC0")]
	public void MDGFIKDFBAO(string BAOKNJFCNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x171C830", Offset = "0x171B030", VA = "0x18171C830")]
	public void HIBIPLNLJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x171C4D0", Offset = "0x171ACD0", VA = "0x18171C4D0")]
	public void CHCKEOGGMPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x171CD50", Offset = "0x171B550", VA = "0x18171CD50")]
	public void MMEIMNKKAPF(bool CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x171C2E0", Offset = "0x171AAE0", VA = "0x18171C2E0")]
	public void BGBMIBBCKGB(float CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x171C650", Offset = "0x171AE50", VA = "0x18171C650")]
	public void EPJAHEIIJBL(double CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x171CFF0", Offset = "0x171B7F0", VA = "0x18171CFF0")]
	public void NGBBCMPIDFB(byte CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x171C2B0", Offset = "0x171AAB0", VA = "0x18171C2B0")]
	public void BBODIKFPFEH(ushort CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x171D170", Offset = "0x171B970", VA = "0x18171D170")]
	public void OJMOPJNGOGB(uint CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x171C5A0", Offset = "0x171ADA0", VA = "0x18171C5A0")]
	public void CKBJNKDOMLF(ulong CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x171C7B0", Offset = "0x171AFB0", VA = "0x18171C7B0")]
	public void FHDHKKFMPDH(sbyte CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x171C440", Offset = "0x171AC40", VA = "0x18171C440")]
	public void BJPDNOAEILO(short CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x171CD20", Offset = "0x171B520", VA = "0x18171CD20")]
	public void MJMGONKKOCE(int CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x171C620", Offset = "0x171AE20", VA = "0x18171C620")]
	public void DILLBKEAJFJ(long CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x171BEE0", Offset = "0x171A6E0", VA = "0x18171BEE0")]
	public void AFGLOAGBLKD(string CCIMHDCKHOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NMKEAMCCINB : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class CJHFKGFGDGG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3866580", Offset = "0x3864D80", VA = "0x183866580")]
		static CJHFKGFGDGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private NMKEAMCCINB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class LOMCGJOGEAM
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> BKCGEPOPLCN;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x17208C0", Offset = "0x171F0C0", VA = "0x1817208C0")]
	static LOMCGJOGEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x17201B0", Offset = "0x171E9B0", VA = "0x1817201B0")]
	internal static object HOBJBBKLJHM(Type HLNBIKMPIPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class CLLBFNABBJK : global::HAKOMFHEDCC<Vector2>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NHNNFMDDFBM DGKFMKMHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] DLMMLIEICDM;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x188A340", Offset = "0x1888B40", VA = "0x18188A340")]
	public CLLBFNABBJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x188A290", Offset = "0x1888A90", VA = "0x18188A290", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Vector2 CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x188A110", Offset = "0x1888910", VA = "0x18188A110", Slot = "5")]
	public Vector2 ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class GLENIEAMLCC : global::HAKOMFHEDCC<Vector3>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NHNNFMDDFBM DGKFMKMHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] DLMMLIEICDM;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x170EA60", Offset = "0x170D260", VA = "0x18170EA60")]
	public GLENIEAMLCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x170E860", Offset = "0x170D060", VA = "0x18170E860", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Vector3 CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x170E540", Offset = "0x170CD40", VA = "0x18170E540", Slot = "5")]
	public Vector3 ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class EOBNDLCGGJO : global::HAKOMFHEDCC<Vector4>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly NHNNFMDDFBM DGKFMKMHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] DLMMLIEICDM;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x170B1D0", Offset = "0x17099D0", VA = "0x18170B1D0")]
	public EOBNDLCGGJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x170AF60", Offset = "0x1709760", VA = "0x18170AF60", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Vector4 CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x170ABE0", Offset = "0x17093E0", VA = "0x18170ABE0", Slot = "5")]
	public Vector4 ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class GLGPAOGCOJI : global::HAKOMFHEDCC<Quaternion>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly NHNNFMDDFBM DGKFMKMHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] DLMMLIEICDM;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x170F080", Offset = "0x170D880", VA = "0x18170F080")]
	public GLGPAOGCOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x170AF60", Offset = "0x1709760", VA = "0x18170AF60", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Quaternion CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x170ED00", Offset = "0x170D500", VA = "0x18170ED00", Slot = "5")]
	public Quaternion ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class DDAEGDEDPLG : global::HAKOMFHEDCC<Color>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly NHNNFMDDFBM DGKFMKMHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] DLMMLIEICDM;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x188C0E0", Offset = "0x188A8E0", VA = "0x18188C0E0")]
	public DDAEGDEDPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x188BF90", Offset = "0x188A790", VA = "0x18188BF90", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Color CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x188BD70", Offset = "0x188A570", VA = "0x18188BD70", Slot = "5")]
	public Color ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class CHKGNKLOFIE : global::HAKOMFHEDCC<Bounds>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly NHNNFMDDFBM DGKFMKMHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] DLMMLIEICDM;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1889CB0", Offset = "0x18884B0", VA = "0x181889CB0")]
	public CHKGNKLOFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1889B10", Offset = "0x1888310", VA = "0x181889B10", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Bounds CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1889870", Offset = "0x1888070", VA = "0x181889870", Slot = "5")]
	public Bounds ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class DNMIGPLBFDF : global::HAKOMFHEDCC<Rect>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly NHNNFMDDFBM DGKFMKMHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] DLMMLIEICDM;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1898000", Offset = "0x1896800", VA = "0x181898000")]
	public DNMIGPLBFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1897E90", Offset = "0x1896690", VA = "0x181897E90", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Rect CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1897C50", Offset = "0x1896450", VA = "0x181897C50", Slot = "5")]
	public Rect ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class EHLLDBKFMEP : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class BPPMMJMLKIE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x377D6A0", Offset = "0x377BEA0", VA = "0x18377D6A0")]
		static BPPMMJMLKIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private EHLLDBKFMEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class LPIAJLDAINN : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class JBKGKOEOKDP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x32A7480", Offset = "0x32A5C80", VA = "0x1832A7480")]
		static JBKGKOEOKDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class KGBHFJBHLNA
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> FLKCAABPHED;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x18D8000", Offset = "0x18D6800", VA = "0x1818D8000")]
		internal static object HOBJBBKLJHM(Type HLNBIKMPIPM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private LPIAJLDAINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class DNECPKJPCDJ : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class GGPAELBDIFD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4195CE0", Offset = "0x41944E0", VA = "0x184195CE0")]
		static GGPAELBDIFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly DNECPKJPCDJ KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool IDPKOAANMPI;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static LOIEEHPBJBK[] DOBAFBLIPMN;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static IEIMAIBIIFF[] MKAFKJIJMOL;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private DNECPKJPCDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1897800", Offset = "0x1896000", VA = "0x181897800")]
	public static void IIGIGLNPDMN(params IEIMAIBIIFF[] MKAFKJIJMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1897720", Offset = "0x1895F20", VA = "0x181897720")]
	public static void IIGIGLNPDMN(params LOIEEHPBJBK[] DOBAFBLIPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x18978E0", Offset = "0x18960E0", VA = "0x1818978E0")]
	public static void NMLBEOPJPJG(LOIEEHPBJBK[] DOBAFBLIPMN, IEIMAIBIIFF[] MKAFKJIJMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class LMADBBGBKMD : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class LLKNIMAFLIF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3915FD0", Offset = "0x39147D0", VA = "0x183915FD0")]
		static LLKNIMAFLIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private LMADBBGBKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class MEEGDGOHOGB
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly IEIMAIBIIFF PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly IEIMAIBIIFF CPHLMJKMPBE;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly IEIMAIBIIFF BDBNFDGCOMC;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly IEIMAIBIIFF OPCLEFLDHME;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly IEIMAIBIIFF DLFGLICNEAP;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly IEIMAIBIIFF HAEJDAAAPCC;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly IEIMAIBIIFF AOHAIFIHALN;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly IEIMAIBIIFF NLOJNDCMJHA;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly IEIMAIBIIFF FCLJCPMEMGG;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly IEIMAIBIIFF HPHCAHJFBIB;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly IEIMAIBIIFF COLHFPMAILN;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly IEIMAIBIIFF FJNGJHCEFCO;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class GHDJMKMGPLB
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly IEIMAIBIIFF PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly IEIMAIBIIFF EEOMCLNHMEB;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class MJFAHPDHJDF
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly IEIMAIBIIFF PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly IEIMAIBIIFF CPHLMJKMPBE;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IEIMAIBIIFF BDBNFDGCOMC;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly IEIMAIBIIFF OPCLEFLDHME;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IEIMAIBIIFF DLFGLICNEAP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly IEIMAIBIIFF HAEJDAAAPCC;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly IEIMAIBIIFF AOHAIFIHALN;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly IEIMAIBIIFF NLOJNDCMJHA;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly IEIMAIBIIFF FCLJCPMEMGG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly IEIMAIBIIFF HPHCAHJFBIB;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly IEIMAIBIIFF COLHFPMAILN;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly IEIMAIBIIFF FJNGJHCEFCO;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class ANBKKJLDLHP
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> FLKCAABPHED;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1883EE0", Offset = "0x18826E0", VA = "0x181883EE0")]
	internal static object HOBJBBKLJHM(Type HLNBIKMPIPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1885840", Offset = "0x1884040", VA = "0x181885840")]
	private static object MFCJFNDEDID(Type MINDLJIBHOB, Type[] EGAINPPBHGP, params object[] OAHJKCAELAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class MELIOFJNBOM : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class KMIOCNAOMDG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3DCDFF0", Offset = "0x3DCC7F0", VA = "0x183DCDFF0")]
		static KMIOCNAOMDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly OPIGIGGOFGI CBCBKNCBBPP;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1721260", Offset = "0x171FA60", VA = "0x181721260")]
	static MELIOFJNBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private MELIOFJNBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class GMNCCKNKOCM : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class ANFHAHFHHAP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3EDD0B0", Offset = "0x3EDB8B0", VA = "0x183EDD0B0")]
		static ANFHAHFHHAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly OPIGIGGOFGI CBCBKNCBBPP;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x170FA20", Offset = "0x170E220", VA = "0x18170FA20")]
	static GMNCCKNKOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private GMNCCKNKOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class PHFJIEHHHDG : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class NNENLJELKHO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3C03420", Offset = "0x3C01C20", VA = "0x183C03420")]
		static NNENLJELKHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly OPIGIGGOFGI CBCBKNCBBPP;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x18E5E60", Offset = "0x18E4660", VA = "0x1818E5E60")]
	static PHFJIEHHHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private PHFJIEHHHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class ENFHEFGFDAN : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class JNGIJIBLKFE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F3B0", Offset = "0x3E0DBB0", VA = "0x183E0F3B0")]
		static JNGIJIBLKFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly OPIGIGGOFGI CBCBKNCBBPP;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1899690", Offset = "0x1897E90", VA = "0x181899690")]
	static ENFHEFGFDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private ENFHEFGFDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class FIPAONBGKIL : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class OBGMFLCEEMC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x45EDC60", Offset = "0x45EC460", VA = "0x1845EDC60")]
		static OBGMFLCEEMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly OPIGIGGOFGI CBCBKNCBBPP;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x170CF70", Offset = "0x170B770", VA = "0x18170CF70")]
	static FIPAONBGKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private FIPAONBGKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class NHJMDGFLJIF : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class OCCLLONCPCB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x45EF080", Offset = "0x45ED880", VA = "0x1845EF080")]
		static OCCLLONCPCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly OPIGIGGOFGI CBCBKNCBBPP;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x18DF700", Offset = "0x18DDF00", VA = "0x1818DF700")]
	static NHJMDGFLJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private NHJMDGFLJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class MGGHAFIKHNK : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class PHLGOOHCGNO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3B2C5F0", Offset = "0x3B2ADF0", VA = "0x183B2C5F0")]
		static PHLGOOHCGNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public MGGHAFIKHNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class LCMECFEMCPA : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class JIOGCEGNLHM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x433CF00", Offset = "0x433B700", VA = "0x18433CF00")]
		static JIOGCEGNLHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public LCMECFEMCPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class JDOPGDBGGIG : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class HBFHCAAHMGF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3588170", Offset = "0x3586970", VA = "0x183588170")]
		static HBFHCAAHMGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public JDOPGDBGGIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class HMDOFCMAAHP : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class PKOHLPOLOIH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3B3CD50", Offset = "0x3B3B550", VA = "0x183B3CD50")]
		static PKOHLPOLOIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public HMDOFCMAAHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class LEIACDBDJOL : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class ADAOMHCDBGM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x35E0280", Offset = "0x35DEA80", VA = "0x1835E0280")]
		static ADAOMHCDBGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public LEIACDBDJOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class IOHHHOHLJBI : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class KFBJOJKLEHC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x37C4AF0", Offset = "0x37C32F0", VA = "0x1837C4AF0")]
		static KFBJOJKLEHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public IOHHHOHLJBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class DLMEBDHBHHE
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct ABHBFJMNGGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CEMNOAKILIM HAJDHCGKNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder LHPBODDOAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder HHBDMIBEBPP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class KNLDKNFKNOP
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class EPBKGDDPLFL
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo IMLBEDMMGJI;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo IAGKEPPFCHI;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo OFPEGINFOBI;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo PPHIFGDGCBM;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo CHCKEOGGMPO;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo BOIJDCIIDIP;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo DDDNHKIFEDM;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo JGEPHLJPNEP;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo FMNOHHJBEDL;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x18D3560", Offset = "0x18D1D60", VA = "0x1818D3560")]
			static EPBKGDDPLFL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class JMJMNBCCALP
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo HKJCECDMGOH;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo BDHGMFNHFCB;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo AALKAAHAKEI;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo NGPOFMLILJF;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo IDONKGNHIIB;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo OADEJILKOJH;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo PCEMIJBKLDG;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x18D7190", Offset = "0x18D5990", VA = "0x1818D7190")]
			static JMJMNBCCALP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class GOKMDHCBMKD
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo HFNGLDDAIMB;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo PEDALJFOEBG;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo MHMPNINKPCH;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo NGBFDKMKBBL;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo EDJFJJJENDJ;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo AELNADGBMNJ;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo AOJHGKCKOPN;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo DBOPOCBKIGH;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo LLOCNOANHGI;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo GLODDADCGMN;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo BPAFAFOHKMJ;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo PJDAENIKLFB;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo FBDNBKOKCOA;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo PPPNJOGDDLD;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x18DCE60", Offset = "0x18DB660", VA = "0x1818DCE60")]
		public static MethodInfo HHDOHEHKDKI(Type BCFKLEGAMEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x18DCAB0", Offset = "0x18DB2B0", VA = "0x1818DCAB0")]
		public static MethodInfo ADHMOLAJGDE(Type BCFKLEGAMEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x18DCD20", Offset = "0x18DB520", VA = "0x1818DCD20")]
		public static MethodInfo GJNFJDFGLJO(Type BCFKLEGAMEO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class BEFBIMBABAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<CEMNOAKILIM, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public BEFBIMBABAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KMCGIJOBGNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public BEFBIMBABAI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public KMCGIJOBGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x18DC830", Offset = "0x18DB030", VA = "0x1818DC830")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x18DC940", Offset = "0x18DB140", VA = "0x1818DC940")]
		internal bool <BuildType>b__2(int index, CEMNOAKILIM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class KDOFEOJGJPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public BEFBIMBABAI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public KDOFEOJGJPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x18D7E90", Offset = "0x18D6690", VA = "0x1818D7E90")]
		internal bool <BuildType>b__3(int index, CEMNOAKILIM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class BEPGADDCAFK
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

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public BEPGADDCAFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x18D2FD0", Offset = "0x18D17D0", VA = "0x1818D2FD0")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class OGJPJJJKCON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public OGJPJJJKCON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x18E3820", Offset = "0x18E2020", VA = "0x1818E3820")]
		internal bool <BuildAnonymousFormatter>b__2(CEMNOAKILIM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class KIANOPFHPMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public BEPGADDCAFK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public KIANOPFHPMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x18D9F70", Offset = "0x18D8770", VA = "0x1818D9F70")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x18D9FF0", Offset = "0x18D87F0", VA = "0x1818D9FF0")]
		internal bool <BuildAnonymousFormatter>b__6(int index, CEMNOAKILIM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JCNKNOEMLNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public BEPGADDCAFK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public JCNKNOEMLNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x18D6F90", Offset = "0x18D5790", VA = "0x1818D6F90")]
		internal bool <BuildAnonymousFormatter>b__7(int index, CEMNOAKILIM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class CBCPBFKKFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public CBCPBFKKFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x957F20", Offset = "0x956720", VA = "0x180957F20")]
		internal Label <BuildSerialize>b__1(CEMNOAKILIM _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class ACAJKFFALJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public ABHBFJMNGGO[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, CEMNOAKILIM, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public NMANGJFPHIB argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public NMANGJFPHIB argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public ACAJKFFALJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x18D2390", Offset = "0x18D0B90", VA = "0x1818D2390")]
		internal ABHBFJMNGGO <BuildDeserialize>b__0(CEMNOAKILIM item)
		{
			return default(ABHBFJMNGGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class BCPDNMICFFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public ACAJKFFALJA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public BCPDNMICFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x18D2C60", Offset = "0x18D1460", VA = "0x1818D2C60")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x18D2F30", Offset = "0x18D1730", VA = "0x1818D2F30")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class EFBJBDPPHJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CEMNOAKILIM item;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public EFBJBDPPHJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x18D3550", Offset = "0x18D1D50", VA = "0x1818D3550")]
		internal bool <EmitNewObject>b__0(ABHBFJMNGGO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class PBCHAGHNHNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CEMNOAKILIM item;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public PBCHAGHNHNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x18D3550", Offset = "0x18D1D50", VA = "0x1818D3550")]
		internal bool <EmitNewObject>b__2(ABHBFJMNGGO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex DBHNIPOABDN;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int KKDFFLBADDL;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> JGKMLBPKGAG;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> DIBGGLDAALG;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x36ADE90", Offset = "0x36AC690", VA = "0x1836ADE90")]
	public static object KOPMFEKJNEA<T>(OPIGIGGOFGI CBCBKNCBBPP, IEIMAIBIIFF KIPDBODNOFI, Func<string, string> NGJDAAMHCNP, bool GCDCGODCBAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x37D6420", Offset = "0x37D4C20", VA = "0x1837D6420")]
	public static object LLKFJBJBAGB<T>(IEIMAIBIIFF KIPDBODNOFI, Func<string, string> NGJDAAMHCNP, bool GCDCGODCBAP, bool PLLOLPEIJDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1893200", Offset = "0x1891A00", VA = "0x181893200")]
	private static TypeInfo MBPKLBDLJCK(OPIGIGGOFGI CBCBKNCBBPP, Type BCFKLEGAMEO, Func<string, string> NGJDAAMHCNP, bool GCDCGODCBAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x188EEC0", Offset = "0x188D6C0", VA = "0x18188EEC0")]
	public static object DFGGOMEHHEO(Type BCFKLEGAMEO, Func<string, string> NGJDAAMHCNP, bool GCDCGODCBAP, bool PLLOLPEIJDN, bool LJEMAJCBEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1892B20", Offset = "0x1891320", VA = "0x181892B20")]
	private static Dictionary<CEMNOAKILIM, FieldInfo> LOPNBIBMIPB(TypeBuilder GGONGCHGDNC, LJCJCOJOGPC MGMCENKLKLD, ConstructorInfo KLICPGCIOJL, FieldBuilder HKLDAOEALDJ, ILGenerator JLMHENJMMKI, bool GCDCGODCBAP, bool JJPDCLPKHPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x1893C90", Offset = "0x1892490", VA = "0x181893C90")]
	private static Dictionary<CEMNOAKILIM, FieldInfo> OOJFDGNKDEP(TypeBuilder GGONGCHGDNC, LJCJCOJOGPC MGMCENKLKLD, ILGenerator JLMHENJMMKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1890A40", Offset = "0x188F240", VA = "0x181890A40")]
	private static void GLDDFNDOOBK(Type BCFKLEGAMEO, LJCJCOJOGPC MGMCENKLKLD, ILGenerator JLMHENJMMKI, Action HNKFJANLNOJ, Func<int, CEMNOAKILIM, bool> ELGGIDGEPCI, bool GCDCGODCBAP, bool JJPDCLPKHPM, int PDAMHCKDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x188DB10", Offset = "0x188C310", VA = "0x18188DB10")]
	private static void CAKGPFEAIEG(TypeInfo BCFKLEGAMEO, CEMNOAKILIM KMOCGNMHJJK, ILGenerator JLMHENJMMKI, int MMABPPDCBIB, Func<int, CEMNOAKILIM, bool> ELGGIDGEPCI, NMANGJFPHIB FBNHINKPMEA, NMANGJFPHIB HJKFCOLLMEG, NMANGJFPHIB NLHKGBMJBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x188C710", Offset = "0x188AF10", VA = "0x18188C710")]
	private static void AOKMMMMFCLP(Type BCFKLEGAMEO, LJCJCOJOGPC MGMCENKLKLD, ILGenerator JLMHENJMMKI, Func<int, CEMNOAKILIM, bool> ELGGIDGEPCI, bool GNJCCKPELNE, int PDAMHCKDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1891F60", Offset = "0x1890760", VA = "0x181891F60")]
	private static void HCOFLEFBMBO(ILGenerator JLMHENJMMKI, ABHBFJMNGGO MGMCENKLKLD, int MMABPPDCBIB, Func<int, CEMNOAKILIM, bool> ELGGIDGEPCI, NMANGJFPHIB CLOGDHPGNHC, NMANGJFPHIB NLHKGBMJBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x188E060", Offset = "0x188C860", VA = "0x18188E060")]
	private static LocalBuilder CAMMONIPNMJ(ILGenerator JLMHENJMMKI, Type BCFKLEGAMEO, LJCJCOJOGPC MGMCENKLKLD, ABHBFJMNGGO[] FFLKLGKKAGJ, bool HGDPBGGLFKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1892420", Offset = "0x1890C20", VA = "0x181892420")]
	private static bool IDLJMEFDIBC(ConstructorInfo PNGHCGPJBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x188ED10", Offset = "0x188D510", VA = "0x18188ED10")]
	private static bool CAOGIKIGEAH(Type BCFKLEGAMEO, out Type BCBKNCLAOFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void FCELMBPGBFH<T>(byte[][] HKLDAOEALDJ, object[] KOMJLBADEMB, ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T BOELHOAKOJP<T>(object[] KOMJLBADEMB, ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF EPCNJMCAAGN);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class FDHAOCCILDC<T> : global::HAKOMFHEDCC<T>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] HKLDAOEALDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] ILIDBMFFFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] OAJPHMALCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly global::FCELMBPGBFH<T> JAKCIDHCLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly global::BOELHOAKOJP<T> JPBCHOPICMD;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x34B8CE0", Offset = "0x34B74E0", VA = "0x1834B8CE0")]
	public FDHAOCCILDC(byte[][] HKLDAOEALDJ, object[] ILIDBMFFFLJ, object[] OAJPHMALCGO, global::FCELMBPGBFH<T> JAKCIDHCLFK, global::BOELHOAKOJP<T> JPBCHOPICMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x34B8C00", Offset = "0x34B7400", VA = "0x1834B8C00", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x34B8B30", Offset = "0x34B7330", VA = "0x1834B8B30", Slot = "5")]
	public T ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class GNNPGIDOLFE : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class NODCPHGCJGN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3C07410", Offset = "0x3C05C10", VA = "0x183C07410")]
		static NODCPHGCJGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private GNNPGIDOLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class JIEPFMLFIJO : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class LDEHKGOKDAM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x39047F0", Offset = "0x3902FF0", VA = "0x1839047F0")]
		static LDEHKGOKDAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private JIEPFMLFIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class LNOCEGFBMLC
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly IEIMAIBIIFF[] CCFJBJBMGOP;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class KNCFOECNLPL : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class HFFJHFDJCKN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3599390", Offset = "0x3597B90", VA = "0x183599390")]
		static HFFJHFDJCKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class HHNCHLGHEOF : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class CKAEFKDAOGB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x386D650", Offset = "0x386BE50", VA = "0x18386D650")]
			static CKAEFKDAOGB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		private HHNCHLGHEOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private KNCFOECNLPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class FDKJLDCBAIF : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class OECJOALOIEK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x45F79B0", Offset = "0x45F61B0", VA = "0x1845F79B0")]
		static OECJOALOIEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class AFMNHBAHEPI : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class FMIEGANEFHP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x426FEF0", Offset = "0x426E6F0", VA = "0x18426FEF0")]
			static FMIEGANEFHP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		private AFMNHBAHEPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private FDKJLDCBAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class ANFKNMEANDG : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class ENLECKDFGJB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2FCCE90", Offset = "0x2FCB690", VA = "0x182FCCE90")]
		static ENLECKDFGJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class FAEIDJGELGD : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class CIEJJNCBMBO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x4474580", Offset = "0x4472D80", VA = "0x184474580")]
			static CIEJJNCBMBO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		private FAEIDJGELGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private ANFKNMEANDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class OAOAJEMLIJK : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class HBMLHFFHAPH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x358D460", Offset = "0x358BC60", VA = "0x18358D460")]
		static HBMLHFFHAPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class LPBADGAEGFD : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class DEPLCPCAPBC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x3C15C40", Offset = "0x3C14440", VA = "0x183C15C40")]
			static DEPLCPCAPBC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		private LPBADGAEGFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private OAOAJEMLIJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class ONKAJJIHMIA : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class AHAGIIOADFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x35EB8C0", Offset = "0x35EA0C0", VA = "0x1835EB8C0")]
		static AHAGIIOADFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class FNELEBAAHIG : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class AIAINCKJOEE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3ECB4D0", Offset = "0x3EC9CD0", VA = "0x183ECB4D0")]
			static AIAINCKJOEE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		private FNELEBAAHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private ONKAJJIHMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class LBOOAMBADNH : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class PFFHFLGNFPG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3B25190", Offset = "0x3B23990", VA = "0x183B25190")]
		static PFFHFLGNFPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class NFOLDAHGBJN : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class NMCCLFMPDBK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x3BF7FC0", Offset = "0x3BF67C0", VA = "0x183BF7FC0")]
			static NMCCLFMPDBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		private NFOLDAHGBJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private LBOOAMBADNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class FKJAKCEGPBF : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class EIOBCCCIOEN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6A20", Offset = "0x2FC5220", VA = "0x182FC6A20")]
		static EIOBCCCIOEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class BJBHMKBIAHB : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class IGPPIAGMDOB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2B2E5B0", Offset = "0x2B2CDB0", VA = "0x182B2E5B0")]
			static IGPPIAGMDOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		private BJBHMKBIAHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private FKJAKCEGPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class PLKLKPKOONK : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class EFOLJDFDHMA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2FBE3B0", Offset = "0x2FBCBB0", VA = "0x182FBE3B0")]
		static EFOLJDFDHMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class IDJBCCFPABL : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class NBHIGLCHFLL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x32D5FA0", Offset = "0x32D47A0", VA = "0x1832D5FA0")]
			static NBHIGLCHFLL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		private IDJBCCFPABL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private PLKLKPKOONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class GAGGIIHLIPA : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class JPLNDJDJOLP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x37ABA40", Offset = "0x37AA240", VA = "0x1837ABA40")]
		static JPLNDJDJOLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class NJCMNGMOCHO : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class LFKIAFMCAGO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x390B130", Offset = "0x3909930", VA = "0x18390B130")]
			static LFKIAFMCAGO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		private NJCMNGMOCHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private GAGGIIHLIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class ODKLGKKLHFP : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class NMKPLOGNJLF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3BFBD60", Offset = "0x3BFA560", VA = "0x183BFBD60")]
		static NMKPLOGNJLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class LJJKFCBAKPO : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class DEJLDJKNKHA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x424ED90", Offset = "0x424D590", VA = "0x18424ED90")]
			static DEJLDJKNKHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		private LJJKFCBAKPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private ODKLGKKLHFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class COAMHBLJGIO : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class OPNDJJGANEG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4872630", Offset = "0x4870E30", VA = "0x184872630")]
		static OPNDJJGANEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class PAHJLGIGNNN : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class NFNPNFOBPHH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x32DE2C0", Offset = "0x32DCAC0", VA = "0x1832DE2C0")]
			static NFNPNFOBPHH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		private PAHJLGIGNNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private COAMHBLJGIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class DCENOHBMGDL : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class GLHPDCILBHO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x41D27C0", Offset = "0x41D0FC0", VA = "0x1841D27C0")]
		static GLHPDCILBHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class GIMEMPHOHIF : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class AHODEHDCIEM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x3EC8640", Offset = "0x3EC6E40", VA = "0x183EC8640")]
			static AHODEHDCIEM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		private GIMEMPHOHIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	private DCENOHBMGDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EA0", Offset = "0x2E116A0", VA = "0x182E12EA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct DAFGBDPGAFN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] ELPGOHJDPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int ADODPFDEIHD;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x407B350", Offset = "0x4079B50", VA = "0x18407B350")]
	public DAFGBDPGAFN(int DNLGEKMDGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x407B1D0", Offset = "0x40799D0", VA = "0x18407B1D0")]
	public void CEMPCIEDPMO(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x407B2C0", Offset = "0x4079AC0", VA = "0x18407B2C0")]
	public T[] HHOLENPNECD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class HKJHDFDCLFD : global::IOAKBHOGHOE<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly HKJHDFDCLFD PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1719300", Offset = "0x1717B00", VA = "0x181719300")]
	public HKJHDFDCLFD(int ICIICBAPACO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class IOAKBHOGHOE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int ICIICBAPACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object IIHNMJCHHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int MMABPPDCBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] HAIEAFBBEJF;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3BE2A50", Offset = "0x3BE1250", VA = "0x183BE2A50")]
	public IOAKBHOGHOE(int ICIICBAPACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3BE1990", Offset = "0x3BE0190", VA = "0x183BE1990")]
	public T[] BJMFEPDOEII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3BE2600", Offset = "0x3BE0E00", VA = "0x183BE2600")]
	public void DIIMFKBAEGA(T[] KPAFOBEJBIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class NHNNFMDDFBM : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class HJHOGHDMJKG : IComparable<HJHOGHDMJKG>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class NOBBKFGCBJM : IEnumerable<HJHOGHDMJKG>, IEnumerable, IEnumerator<HJHOGHDMJKG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private HJHOGHDMJKG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public HJHOGHDMJKG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private HJHOGHDMJKG System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F4")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F6")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x7F54B0", Offset = "0x7F3CB0", VA = "0x1807F54B0")]
			[DebuggerHidden]
			public NOBBKFGCBJM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x18E03E0", Offset = "0x18DEBE0", VA = "0x1818E03E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x18E0510", Offset = "0x18DED10", VA = "0x1818E0510", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x18E0470", Offset = "0x18DEC70", VA = "0x1818E0470", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<HJHOGHDMJKG> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x18E0470", Offset = "0x18DEC70", VA = "0x1818E0470", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class CGBLMOMJCMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public CGBLMOMJCMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x957F20", Offset = "0x956720", VA = "0x180957F20")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x957F20", Offset = "0x956720", VA = "0x180957F20")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly HJHOGHDMJKG[] OOIICPNDAED;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] AGJNHKAEPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong PIDBPEBBCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int FHONEBOCBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string NDAMAGLBMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private HJHOGHDMJKG[] HABCDDBMHNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] ILEKIACLDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int LGKBEOCJMLG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool PDAKCIFKIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x18D6C70", Offset = "0x18D5470", VA = "0x1818D6C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x18D6D10", Offset = "0x18D5510", VA = "0x1818D6D10")]
		public HJHOGHDMJKG(ulong AGPLDPOAAIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x18D64F0", Offset = "0x18D4CF0", VA = "0x1818D64F0")]
		public HJHOGHDMJKG CEMPCIEDPMO(ulong AGPLDPOAAIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x18D6720", Offset = "0x18D4F20", VA = "0x1818D6720")]
		public HJHOGHDMJKG CEMPCIEDPMO(ulong AGPLDPOAAIC, int CCIMHDCKHOF, string NDAMAGLBMII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x18D69D0", Offset = "0x18D51D0", VA = "0x1818D69D0")]
		public HJHOGHDMJKG EOHPKLECDBA(byte[] OGGODOHJPHN, ref int EGBIMJLECFF, ref int OILHPMFBCIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x18D6B80", Offset = "0x18D5380", VA = "0x1818D6B80")]
		internal static int FKPLEGPKICI(ulong[] KPAFOBEJBIN, int MMABPPDCBIB, int HOPGLJCPGGA, ulong CCIMHDCKHOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x18D6770", Offset = "0x18D4F70", VA = "0x1818D6770", Slot = "4")]
		public int CompareTo(HJHOGHDMJKG IIKMMJKCGDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x18D6C00", Offset = "0x18D5400", VA = "0x1818D6C00")]
		[IteratorStateMachine(typeof(NOBBKFGCBJM))]
		public IEnumerable<HJHOGHDMJKG> LACGBOCNHEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x18D67A0", Offset = "0x18D4FA0", VA = "0x1818D67A0")]
		public void DNCBELJPHCI(ILGenerator JLMHENJMMKI, LocalBuilder OGGODOHJPHN, LocalBuilder OILHPMFBCIA, LocalBuilder AGPLDPOAAIC, Action<KeyValuePair<string, int>> MMJNGDNPFII, Action OJAKMPCENEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x18D56F0", Offset = "0x18D3EF0", VA = "0x1818D56F0")]
		private static void BJAHMEAADAO(ILGenerator JLMHENJMMKI, LocalBuilder OGGODOHJPHN, LocalBuilder OILHPMFBCIA, LocalBuilder AGPLDPOAAIC, Action<KeyValuePair<string, int>> MMJNGDNPFII, Action OJAKMPCENEP, HJHOGHDMJKG[] HABCDDBMHNH, int LGKBEOCJMLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class FGCOBHOKJJC : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<HJHOGHDMJKG> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<HJHOGHDMJKG> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<HJHOGHDMJKG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private HJHOGHDMJKG <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x74A710", Offset = "0x748F10", VA = "0x18074A710", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x18D4970", Offset = "0x18D3170", VA = "0x1818D4970", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7F7420", Offset = "0x7F5C20", VA = "0x1807F7420")]
		[DebuggerHidden]
		public FGCOBHOKJJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x18D49C0", Offset = "0x18D31C0", VA = "0x1818D49C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x18D4500", Offset = "0x18D2D00", VA = "0x1818D4500", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x18D4AA0", Offset = "0x18D32A0", VA = "0x1818D4AA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x18D4AF0", Offset = "0x18D32F0", VA = "0x1818D4AF0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x18D4930", Offset = "0x18D3130", VA = "0x1818D4930", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x18D4890", Offset = "0x18D3090", VA = "0x1818D4890", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x18D4890", Offset = "0x18D3090", VA = "0x1818D4890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly HJHOGHDMJKG ODPHCGBINJN;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x18DFE40", Offset = "0x18DE640", VA = "0x1818DFE40")]
	public NHNNFMDDFBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x18DF830", Offset = "0x18DE030", VA = "0x1818DF830")]
	public void CEMPCIEDPMO(byte[] CDDAIIMDJCN, int CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x18DF9B0", Offset = "0x18DE1B0", VA = "0x1818DF9B0")]
	public bool HFFJFKHBBCI(ArraySegment<byte> AGPLDPOAAIC, out int CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x18DFDB0", Offset = "0x18DE5B0", VA = "0x1818DFDB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x18DFB10", Offset = "0x18DE310", VA = "0x1818DFB10")]
	private static void PPCPNNHHCLP(IEnumerable<HJHOGHDMJKG> HABCDDBMHNH, StringBuilder IDIEBAILNNP, int FOCIGJDPHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x18DF950", Offset = "0x18DE150", VA = "0x1818DF950", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x18DF950", Offset = "0x18DE150", VA = "0x1818DF950", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x18DFA70", Offset = "0x18DE270", VA = "0x1818DFA70")]
	[IteratorStateMachine(typeof(FGCOBHOKJJC))]
	private static IEnumerable<KeyValuePair<string, int>> JFLAPAOFJBJ(IEnumerable<HJHOGHDMJKG> HABCDDBMHNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x18DFAE0", Offset = "0x18DE2E0", VA = "0x1818DFAE0")]
	public void PBDHIKOIDKD(ILGenerator JLMHENJMMKI, LocalBuilder OGGODOHJPHN, LocalBuilder OILHPMFBCIA, LocalBuilder AGPLDPOAAIC, Action<KeyValuePair<string, int>> MMJNGDNPFII, Action OJAKMPCENEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class FGFGOFFDKCM
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo FDJNPCEAPAC;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x170B660", Offset = "0x1709E60", VA = "0x18170B660")]
	public static ulong ALBMBDILJMJ(byte[] CDDAIIMDJCN, ref int EGBIMJLECFF, ref int OILHPMFBCIA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class OABALJGCOHF
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x18E19C0", Offset = "0x18E01C0", VA = "0x1818E19C0")]
	public static void LOKAJEFELOL(ref byte[] CDDAIIMDJCN, int EGBIMJLECFF, int ANPLBJOGOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x18E1790", Offset = "0x18DFF90", VA = "0x1818E1790")]
	public static void GJDNMKDIPIC(ref byte[] KPAFOBEJBIN, int OFPFHBDEIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x18E18A0", Offset = "0x18E00A0", VA = "0x1818E18A0")]
	public static byte[] JICICOOHGGE(byte[] EADBNCPOLHD, int OFPFHBDEIHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class MFMAEELPDLD
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x17217C0", Offset = "0x171FFC0", VA = "0x1817217C0")]
	public static bool FMLLLJFHODI(byte[] DACJMGLKOIC, int BALJHKLKOHC, int DOHCFGPMBJK, byte[] OCJDBNFNKJF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class GALOOIHPGNA<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct GLBLOMDDEOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] PIDBPEBBCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T FHONEBOCBPE;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x41C7AB0", Offset = "0x41C62B0", VA = "0x1841C7AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class EABGNMBDGPM : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public global::GALOOIHPGNA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private GLBLOMDDEOM[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private GLBLOMDDEOM[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x74A710", Offset = "0x748F10", VA = "0x18074A710", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x383F470", Offset = "0x383DC70", VA = "0x18383F470", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2F88790", Offset = "0x2F86F90", VA = "0x182F88790")]
		[DebuggerHidden]
		public EABGNMBDGPM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x383E7F0", Offset = "0x383CFF0", VA = "0x18383E7F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x383EEA0", Offset = "0x383D6A0", VA = "0x18383EEA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly GLBLOMDDEOM[][] DPNCDJHECLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong KBGGJKMDFNL;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x4686290", Offset = "0x4684A90", VA = "0x184686290")]
	public GALOOIHPGNA(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x46861D0", Offset = "0x46849D0", VA = "0x1846861D0")]
	public GALOOIHPGNA(int JAFEKEGLGFD, float KEJIFFLPGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x47DE280", Offset = "0x47DCA80", VA = "0x1847DE280")]
	public void CEMPCIEDPMO(byte[] AGPLDPOAAIC, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x47DF0B0", Offset = "0x47DD8B0", VA = "0x1847DF0B0")]
	private bool NBHKAKNIKMG(byte[] AGPLDPOAAIC, T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x47DE430", Offset = "0x47DCC30", VA = "0x1847DE430")]
	public bool EPBHELLGDLM(ArraySegment<byte> AGPLDPOAAIC, out T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x467F570", Offset = "0x467DD70", VA = "0x18467F570")]
	private static ulong MPDIMNOKGAO(byte[] ODLLFOGPPIE, int EGBIMJLECFF, int LGKBEOCJMLG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C790", Offset = "0x3E0AF90", VA = "0x183E0C790")]
	private static int BKGCHOKJAIB(int AKICHLKOMJD, float KEJIFFLPGLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x467F330", Offset = "0x467DB30", VA = "0x18467F330", Slot = "4")]
	[IteratorStateMachine(typeof(global::GALOOIHPGNA<>.EABGNMBDGPM))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x32D3610", Offset = "0x32D1E10", VA = "0x1832D3610", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class GLPLDCNLFKN : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] KGDPPPOINOH;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] BBFEFLOIDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int EHCNGOCKAMG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool ILOCCBANMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x170F5B0", Offset = "0x170DDB0", VA = "0x18170F5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x170F720", Offset = "0x170DF20", VA = "0x18170F720")]
	static GLPLDCNLFKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x170F9A0", Offset = "0x170E1A0", VA = "0x18170F9A0")]
	public GLPLDCNLFKN(byte[] FNGAFOCJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x170F600", Offset = "0x170DE00", VA = "0x18170F600")]
	public OpCode PNGPIJBCMBK()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct DLMOJCANJBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid FHONEBOCBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte PHHELBDBJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte JPJLBNFANPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte LIAKCGOPKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte BPOJDDJLJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte ANFLJHICADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte KEDEMILHKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte LCBMOLCBHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte FHGLMDKHKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte FPGELKOEBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte AEKMKLMCHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte HKBLLOHCCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte DAICEIBEBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte MCLALMKKCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte DNIHIAIGAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte MNNFGEJAADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte HJEDDMBJMMM;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] GEICOJKPKPC;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] AOPDEPBKGJI;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x1895F40", Offset = "0x1894740", VA = "0x181895F40")]
	public DLMOJCANJBN(ref Guid CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x1895F50", Offset = "0x1894750", VA = "0x181895F50")]
	public DLMOJCANJBN(ref ArraySegment<byte> BOEBJHAFKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x1895DB0", Offset = "0x18945B0", VA = "0x181895DB0")]
	private static byte HKOGJNEAEBJ(byte[] CDDAIIMDJCN, int GGODGFOCGCB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x1894950", Offset = "0x1893150", VA = "0x181894950")]
	private static byte EIINECOGOII(byte ENHIJCCJFBF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x1894A60", Offset = "0x1893260", VA = "0x181894A60")]
	public void EPOIFDELDCH(byte[] NCCOCLJLPFP, int EGBIMJLECFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class ALLDDJCGDNN
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x1883980", Offset = "0x1882180", VA = "0x181883980")]
	public static bool HKOPBKKOPJL(byte ODCENIJJKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1883AE0", Offset = "0x18822E0", VA = "0x181883AE0")]
	public static bool MIGJJBPLHKH(byte ODCENIJJKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x1883910", Offset = "0x1882110", VA = "0x181883910")]
	public static sbyte ENIFFBLFONM(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x1883A00", Offset = "0x1882200", VA = "0x181883A00")]
	public static short LJPINJKNAOG(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x1883E70", Offset = "0x1882670", VA = "0x181883E70")]
	public static int PMGMFGBIFDG(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x1883B50", Offset = "0x1882350", VA = "0x181883B50")]
	public static long OKAACLJBNNN(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x1883990", Offset = "0x1882190", VA = "0x181883990")]
	public static byte JGDKDGKAPBP(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x18838A0", Offset = "0x18820A0", VA = "0x1818838A0")]
	public static ushort EACPFKLCNCF(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x1882BF0", Offset = "0x18813F0", VA = "0x181882BF0")]
	public static uint DDDBNCKOJAF(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x1882310", Offset = "0x1880B10", VA = "0x181882310")]
	public static ulong CHHDFFDMPBB(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1883A70", Offset = "0x1882270", VA = "0x181883A70")]
	public static float LOHCAAFDECB(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x18822A0", Offset = "0x1880AA0", VA = "0x1818822A0")]
	public static double BGCLNPNNNGI(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x1882420", Offset = "0x1880C20", VA = "0x181882420")]
	public static int CKBJNKDOMLF(ref byte[] NCCOCLJLPFP, int EGBIMJLECFF, ulong CCIMHDCKHOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x1882C70", Offset = "0x1881470", VA = "0x181882C70")]
	public static int DILLBKEAJFJ(ref byte[] NCCOCLJLPFP, int EGBIMJLECFF, long CCIMHDCKHOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x1883C00", Offset = "0x1882400", VA = "0x181883C00")]
	public static bool PHHFPHGKEHB(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class FJAHIFDJCMB
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class BBJLLNPEINF : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7F54B0", Offset = "0x7F3CB0", VA = "0x1807F54B0")]
		[DebuggerHidden]
		public BBJLLNPEINF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x18D2AD0", Offset = "0x18D12D0", VA = "0x1818D2AD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x18D2670", Offset = "0x18D0E70", VA = "0x1818D2670", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x18D2BC0", Offset = "0x18D13C0", VA = "0x1818D2BC0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x18D2C10", Offset = "0x18D1410", VA = "0x1818D2C10")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x18D2A90", Offset = "0x18D1290", VA = "0x1818D2A90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x18D29E0", Offset = "0x18D11E0", VA = "0x1818D29E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x18D29E0", Offset = "0x18D11E0", VA = "0x1818D29E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class ODLGIOFKFKA : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7F54B0", Offset = "0x7F3CB0", VA = "0x1807F54B0")]
		[DebuggerHidden]
		public ODLGIOFKFKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x18E2220", Offset = "0x18E0A20", VA = "0x1818E2220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x18E1DC0", Offset = "0x18E05C0", VA = "0x1818E1DC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x18E2310", Offset = "0x18E0B10", VA = "0x1818E2310")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x18E2360", Offset = "0x18E0B60", VA = "0x1818E2360")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x18E21E0", Offset = "0x18E09E0", VA = "0x1818E21E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x18E2130", Offset = "0x18E0930", VA = "0x1818E2130", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x18E2130", Offset = "0x18E0930", VA = "0x1818E2130", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x170D480", Offset = "0x170BC80", VA = "0x18170D480")]
	public static bool NIBNFGICFPI(this TypeInfo BCFKLEGAMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x170D2D0", Offset = "0x170BAD0", VA = "0x18170D2D0")]
	public static bool LHKDPICAABE(this TypeInfo BCFKLEGAMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x170D130", Offset = "0x170B930", VA = "0x18170D130")]
	public static IEnumerable<PropertyInfo> DOLBJGPMHCB(this Type BCFKLEGAMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x170D3F0", Offset = "0x170BBF0", VA = "0x18170D3F0")]
	[IteratorStateMachine(typeof(BBJLLNPEINF))]
	private static IEnumerable<PropertyInfo> MKPECKBBINM(Type BCFKLEGAMEO, HashSet<string> LKOIPNOFAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x170D200", Offset = "0x170BA00", VA = "0x18170D200")]
	public static IEnumerable<FieldInfo> FFCCDHNCLLC(this Type BCFKLEGAMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x170D0A0", Offset = "0x170B8A0", VA = "0x18170D0A0")]
	[IteratorStateMachine(typeof(ODLGIOFKFKA))]
	private static IEnumerable<FieldInfo> BMPHBNCILFM(Type BCFKLEGAMEO, HashSet<string> LKOIPNOFAFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class AIFDPCCCKNB
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding AOAGKAKLGDG;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class DEHNLNAKOFA
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x722C40", Offset = "0x721440", VA = "0x180722C40")]
	public static string OEPHGJDPPML(string OLNLINPGBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x188C410", Offset = "0x188AC10", VA = "0x18188C410")]
	public static string AAFOJFEGMLM(string OLNLINPGBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x188C520", Offset = "0x188AD20", VA = "0x18188C520")]
	public static string LOGHJLKDJGP(string OLNLINPGBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class JMJBDOGCDKP<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class DDFCINLLBAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type PIDBPEBBCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue FHONEBOCBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int OJICPCDJBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public DDFCINLLBAL ABOGINNEAHO;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x4244450", Offset = "0x4242C50", VA = "0x184244450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x42443D0", Offset = "0x4242BD0", VA = "0x1842443D0")]
		private int CAAMIJFBOBJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public DDFCINLLBAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class ILEGLNCBIAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public ILEGLNCBIAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7325A0", Offset = "0x730DA0", VA = "0x1807325A0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private DDFCINLLBAL[] DPNCDJHECLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int FBPAKFCOLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object ACFHOAOMEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float KEJIFFLPGLJ;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x3E0DB80", Offset = "0x3E0C380", VA = "0x183E0DB80")]
	public JMJBDOGCDKP(int JAFEKEGLGFD = 4, float KEJIFFLPGLJ = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x3E0CC30", Offset = "0x3E0B430", VA = "0x183E0CC30")]
	public bool KFCNCOMHECF(Type AGPLDPOAAIC, TValue CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x3E0CBF0", Offset = "0x3E0B3F0", VA = "0x183E0CBF0")]
	public bool KFCNCOMHECF(Type AGPLDPOAAIC, Func<Type, TValue> NANJNKGKLCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x3E0D5B0", Offset = "0x3E0BDB0", VA = "0x183E0D5B0")]
	private bool NBHKAKNIKMG(Type AGPLDPOAAIC, Func<Type, TValue> NANJNKGKLCA, out TValue IMPGIGIMHFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3E0CE50", Offset = "0x3E0B650", VA = "0x183E0CE50")]
	private bool LBOPEFGIGHA(DDFCINLLBAL[] DPNCDJHECLC, Type JGMDBJEPBGM, DDFCINLLBAL GPILHAMMLDE, Func<Type, TValue> NANJNKGKLCA, out TValue IMPGIGIMHFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C910", Offset = "0x3E0B110", VA = "0x183E0C910")]
	public bool EPBHELLGDLM(Type AGPLDPOAAIC, out TValue CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x3E0CB00", Offset = "0x3E0B300", VA = "0x183E0CB00")]
	public TValue FNLIBAGKGPC(Type AGPLDPOAAIC, Func<Type, TValue> NANJNKGKLCA)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C790", Offset = "0x3E0AF90", VA = "0x183E0C790")]
	private static int BKGCHOKJAIB(int AKICHLKOMJD, float KEJIFFLPGLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x3E0DB50", Offset = "0x3E0C350", VA = "0x183E0DB50")]
	private static void OBJBLKLEIFC(ref DDFCINLLBAL HMPMFMHHLJE, DDFCINLLBAL CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x3E0DB50", Offset = "0x3E0C350", VA = "0x183E0DB50")]
	private static void OBJBLKLEIFC(ref DDFCINLLBAL[] HMPMFMHHLJE, DDFCINLLBAL[] CCIMHDCKHOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class OPIGIGGOFGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder LHDNBHCFDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder MEKNNJPHEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object IIHNMJCHHIL;

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x18E56E0", Offset = "0x18E3EE0", VA = "0x1818E56E0")]
	public TypeBuilder EFKOOAJBFML(string FOGNBJMCDMG, TypeAttributes KOBIAOOHOMD, Type OJKLIAPCMPJ, Type[] KJIPHEDAENM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x18E57B0", Offset = "0x18E3FB0", VA = "0x1818E57B0")]
	public OPIGIGGOFGI(string AFPCEBMPCFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class CFJJFDPGKDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x18880C0", Offset = "0x18868C0", VA = "0x1818880C0")]
	private static MethodInfo NIAFLBCEMPF(LambdaExpression LLJKFCHKLGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x355C110", Offset = "0x355A910", VA = "0x18355C110")]
	public static MethodInfo JFPDEICILOD<T>(Expression<Func<T>> LLJKFCHKLGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x355C110", Offset = "0x355A910", VA = "0x18355C110")]
	public static MethodInfo JFPDEICILOD<T, TR>(Expression<Func<T, TR>> LLJKFCHKLGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x355C110", Offset = "0x355A910", VA = "0x18355C110")]
	public static MethodInfo JFPDEICILOD<T>(Expression<Action<T>> LLJKFCHKLGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x355C110", Offset = "0x355A910", VA = "0x18355C110")]
	public static MethodInfo JFPDEICILOD<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> LLJKFCHKLGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x355C060", Offset = "0x355A860", VA = "0x18355C060")]
	private static MemberInfo BFGJIAHLHBF<T>(Expression<T> LENKHFNFMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x355C120", Offset = "0x355A920", VA = "0x18355C120")]
	public static PropertyInfo LENLBPOFOIG<T, TR>(Expression<Func<T, TR>> LLJKFCHKLGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct NMANGJFPHIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int GBIDHHJLPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool JFDAHDMBGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator JLMHENJMMKI;

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x18E0340", Offset = "0x18DEB40", VA = "0x1818E0340")]
	public NMANGJFPHIB(ILGenerator JLMHENJMMKI, int GBIDHHJLPLE, bool JFDAHDMBGKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x18E02B0", Offset = "0x18DEAB0", VA = "0x1818E02B0")]
	public NMANGJFPHIB(ILGenerator JLMHENJMMKI, int GBIDHHJLPLE, Type BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x18E0190", Offset = "0x18DE990", VA = "0x1818E0190")]
	public void BKCKIKOLEEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class OGENDCDLIOP
{
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x18E2E70", Offset = "0x18E1670", VA = "0x1818E2E70")]
	public static void LNNBCCBJNLF(this ILGenerator JLMHENJMMKI, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x18E2E30", Offset = "0x18E1630", VA = "0x1818E2E30")]
	public static void LNNBCCBJNLF(this ILGenerator JLMHENJMMKI, LocalBuilder KGCMFDEFHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x18E2BC0", Offset = "0x18E13C0", VA = "0x1818E2BC0")]
	public static void LMDBNPMIEPI(this ILGenerator JLMHENJMMKI, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x18E2DF0", Offset = "0x18E15F0", VA = "0x1818E2DF0")]
	public static void LMDBNPMIEPI(this ILGenerator JLMHENJMMKI, LocalBuilder KGCMFDEFHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x18E2800", Offset = "0x18E1000", VA = "0x1818E2800")]
	public static void EGPKCNOIOAK(this ILGenerator JLMHENJMMKI, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x18E26F0", Offset = "0x18E0EF0", VA = "0x1818E26F0")]
	public static void EGPKCNOIOAK(this ILGenerator JLMHENJMMKI, LocalBuilder KGCMFDEFHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x18E2660", Offset = "0x18E0E60", VA = "0x1818E2660")]
	public static void AKLJKGDJDKL(this ILGenerator JLMHENJMMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x18E28F0", Offset = "0x18E10F0", VA = "0x1818E28F0")]
	public static void JEMIIHEMIFH(this ILGenerator JLMHENJMMKI, bool CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x18E31A0", Offset = "0x18E19A0", VA = "0x1818E31A0")]
	public static void OAFAPENJCAE(this ILGenerator JLMHENJMMKI, int CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x18E2570", Offset = "0x18E0D70", VA = "0x1818E2570")]
	public static void ADJHPBEDKPC(this ILGenerator JLMHENJMMKI, Type BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x18E3770", Offset = "0x18E1F70", VA = "0x1818E3770")]
	public static void PGCNDHMEMOG(this ILGenerator JLMHENJMMKI, Type BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x18E2900", Offset = "0x18E1100", VA = "0x1818E2900")]
	public static void LAJDDJDALCC(this ILGenerator JLMHENJMMKI, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x18E2670", Offset = "0x18E0E70", VA = "0x1818E2670")]
	public static void DHDKAOKDFNF(this ILGenerator JLMHENJMMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x18E35F0", Offset = "0x18E1DF0", VA = "0x1818E35F0")]
	public static void OIDPGCBNABC(this ILGenerator JLMHENJMMKI, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x18E30A0", Offset = "0x18E18A0", VA = "0x1818E30A0")]
	public static void MOHHCFBPDJA(this ILGenerator JLMHENJMMKI, MethodInfo BDEKHACDIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x18E36E0", Offset = "0x18E1EE0", VA = "0x1818E36E0")]
	public static void OILJIJNPEIF(this ILGenerator JLMHENJMMKI, FieldInfo FHBODNBOFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x18E2B30", Offset = "0x18E1330", VA = "0x1818E2B30")]
	public static void LCBOENJEKMP(this ILGenerator JLMHENJMMKI, ulong CCIMHDCKHOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class CEMNOAKILIM
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class KAKPNDMCGGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public KAKPNDMCGGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x18D7D80", Offset = "0x18D6580", VA = "0x1818D7D80")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo NOFHOKMPPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo MCEDEJFOBHJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string AKFKAJPCNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6F8060", Offset = "0x6F6860", VA = "0x1806F8060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string GBNBDHBJGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6F5010", Offset = "0x6F3810", VA = "0x1806F5010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OGOHDJDFOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1887A80", Offset = "0x1886280", VA = "0x181887A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LEDOELFIBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B80", Offset = "0x6F8380", VA = "0x1806F9B80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6F9710", Offset = "0x6F7F10", VA = "0x1806F9710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool HGKMPNOLHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7D13D0", Offset = "0x7CFBD0", VA = "0x1807D13D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7D1470", Offset = "0x7CFC70", VA = "0x1807D1470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type JIDICLJAOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A60", Offset = "0x6F4260", VA = "0x1806F5A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo FBMDEMBJCAN
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B40", Offset = "0x6F4340", VA = "0x1806F5B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A70", Offset = "0x6F4270", VA = "0x1806F5A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo CBOFHNLIFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x726A30", Offset = "0x725230", VA = "0x180726A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x726A50", Offset = "0x725250", VA = "0x180726A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo DPIEFFAGEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x746CE0", Offset = "0x7454E0", VA = "0x180746CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x74A6B0", Offset = "0x748EB0", VA = "0x18074A6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x1888040", Offset = "0x1886840", VA = "0x181888040")]
	protected CEMNOAKILIM(Type BCFKLEGAMEO, string FOGNBJMCDMG, string OFKKNNHOFPP, bool LJMKDJGBOBE, bool NFINBHEMDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x1887F30", Offset = "0x1886730", VA = "0x181887F30")]
	public CEMNOAKILIM(FieldInfo MGMCENKLKLD, string FOGNBJMCDMG, bool PLLOLPEIJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x1887D80", Offset = "0x1886580", VA = "0x181887D80")]
	public CEMNOAKILIM(PropertyInfo MGMCENKLKLD, string FOGNBJMCDMG, bool PLLOLPEIJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x1887A90", Offset = "0x1886290", VA = "0x181887A90")]
	private static MethodInfo GNHIHEPILPD(MemberInfo MGMCENKLKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x355BF50", Offset = "0x355A750", VA = "0x18355BF50")]
	public T IDCLHHKJIEJ<T>(bool NFBANMIGLAM) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x1887C00", Offset = "0x1886400", VA = "0x181887C00", Slot = "4")]
	public virtual void NBIBPNOIJFM(ILGenerator JLMHENJMMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x1887CC0", Offset = "0x18864C0", VA = "0x181887CC0", Slot = "5")]
	public virtual void OBEHIMGHJMN(ILGenerator JLMHENJMMKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class OGBPIKBNBME : CEMNOAKILIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string ACDKDCCBEEH;

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x18E24B0", Offset = "0x18E0CB0", VA = "0x1818E24B0")]
	public OGBPIKBNBME(string FOGNBJMCDMG, string ACDKDCCBEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x18E23B0", Offset = "0x18E0BB0", VA = "0x1818E23B0", Slot = "4")]
	public override void NBIBPNOIJFM(ILGenerator JLMHENJMMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x18E2470", Offset = "0x18E0C70", VA = "0x1818E2470", Slot = "5")]
	public override void OBEHIMGHJMN(ILGenerator JLMHENJMMKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class LEFHPDNIMHB : CEMNOAKILIM
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo ALBHBCAFMMC;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo JFOMNJOEECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal NMANGJFPHIB DGIOFPKJJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal NMANGJFPHIB HJKFCOLLMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal NMANGJFPHIB NLHKGBMJBBO;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x171DFE0", Offset = "0x171C7E0", VA = "0x18171DFE0")]
	public LEFHPDNIMHB(string FOGNBJMCDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x171D980", Offset = "0x171C180", VA = "0x18171D980", Slot = "4")]
	public override void NBIBPNOIJFM(ILGenerator JLMHENJMMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x171DA50", Offset = "0x171C250", VA = "0x18171DA50", Slot = "5")]
	public override void OBEHIMGHJMN(ILGenerator JLMHENJMMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x171D860", Offset = "0x171C060", VA = "0x18171D860")]
	public void FLFCJDDJNAP(ILGenerator JLMHENJMMKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class LJCJCOJOGPC
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type JIDICLJAOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F8060", Offset = "0x6F6860", VA = "0x1806F8060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool EPKDIGIOIOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6FD700", Offset = "0x6FBF00", VA = "0x1806FD700")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6FDC20", Offset = "0x6FC420", VA = "0x1806FDC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool ILKBPOGLANH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6FDC10", Offset = "0x6FC410", VA = "0x1806FDC10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB20", Offset = "0x6FC320", VA = "0x1806FDB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo NCMDJJLNNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x667140", Offset = "0x665940", VA = "0x180667140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6E3870", Offset = "0x6E2070", VA = "0x1806E3870")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public CEMNOAKILIM[] IGMNLKLADJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A60", Offset = "0x6F4260", VA = "0x1806F5A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public CEMNOAKILIM[] BECKPIFBCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B40", Offset = "0x6F4340", VA = "0x1806F5B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A70", Offset = "0x6F4270", VA = "0x1806F5A70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x171E5C0", Offset = "0x171CDC0", VA = "0x18171E5C0")]
	public LJCJCOJOGPC(Type BCFKLEGAMEO, Func<string, string> JAJHNDJJCAF, bool PLLOLPEIJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x171E4D0", Offset = "0x171CCD0", VA = "0x18171E4D0")]
	private static bool LOJHMHMLDAO(IEnumerator<ConstructorInfo> BNHLHGFLKBK, ref ConstructorInfo MLOFEDGPNAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct FNBMOHMOAFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong BPJEFFCEPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int GHAPGMJOMOM;

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x170D880", Offset = "0x170C080", VA = "0x18170D880")]
	public FNBMOHMOAFJ(ulong JNPNBGAKPBA, int KMMODGACMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x170D740", Offset = "0x170BF40", VA = "0x18170D740")]
	public void EJHJNHLFHBL(ref FNBMOHMOAFJ IIKMMJKCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x170D6A0", Offset = "0x170BEA0", VA = "0x18170D6A0")]
	public static FNBMOHMOAFJ ACPBAPDBJCD(ref FNBMOHMOAFJ DOGOAAONBOH, ref FNBMOHMOAFJ ENHIJCCJFBF)
	{
		return default(FNBMOHMOAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x170D7F0", Offset = "0x170BFF0", VA = "0x18170D7F0")]
	public void LMGOHFAOPGC(ref FNBMOHMOAFJ IIKMMJKCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x170D750", Offset = "0x170BF50", VA = "0x18170D750")]
	public static FNBMOHMOAFJ LJMPCEGFMKN(ref FNBMOHMOAFJ DOGOAAONBOH, ref FNBMOHMOAFJ ENHIJCCJFBF)
	{
		return default(FNBMOHMOAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x170D6B0", Offset = "0x170BEB0", VA = "0x18170D6B0")]
	public void DEEJNFKADIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x170D6F0", Offset = "0x170BEF0", VA = "0x18170D6F0")]
	public static FNBMOHMOAFJ DEEJNFKADIF(ref FNBMOHMOAFJ DOGOAAONBOH)
	{
		return default(FNBMOHMOAFJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct KNEAGJOJBNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] NCCOCLJLPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int EGBIMJLECFF;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x899220", Offset = "0x897A20", VA = "0x180899220")]
	public KNEAGJOJBNI(byte[] NCCOCLJLPFP, int LPADDFNBONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x171BE80", Offset = "0x171A680", VA = "0x18171BE80")]
	public void OKDFPDDOKAL(byte LILNHPOEIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x171BB10", Offset = "0x171A310", VA = "0x18171BB10")]
	public void ALEFCLEKFMP(byte[] LILNHPOEIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x171BBB0", Offset = "0x171A3B0", VA = "0x18171BBB0")]
	public void EPDFDKBCMDJ(byte[] LILNHPOEIJC, int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x171BC50", Offset = "0x171A450", VA = "0x18171BC50")]
	public void EPDFDKBCMDJ(byte[] LILNHPOEIJC, int OMKHMNIPPGH, int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x171BE00", Offset = "0x171A600", VA = "0x18171BE00")]
	public void LBNIBHGNGDE(byte ODCENIJJKIC, int LGKBEOCJMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x171BD00", Offset = "0x171A500", VA = "0x18171BD00")]
	public void HHIONPDEMBM(string LILNHPOEIJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class GNIKPDIHMBC
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum IBLICHDBBLC
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum AABACCGGELH
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum GHPHHGLCACN
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
	private static byte[] ANGGMFKIAIN;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] IPCLFDDCGLA;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] HDAGOMPAPGE;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] AGFHNKDLBGM;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly GHPHHGLCACN MEMLMCLKJIM;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char OJBEDIDDHLI;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int KBFGJODGNJE;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int EAKNKFLJHHD;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] KBCJNBNKHAG;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x1713140", Offset = "0x1711940", VA = "0x181713140")]
	private static byte[] MDMDPAEKHNI(int FBPAKFCOLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x1711C70", Offset = "0x1710470", VA = "0x181711C70")]
	private static byte[] EMJGJOLMMBA(int FBPAKFCOLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x1712280", Offset = "0x1710A80", VA = "0x181712280")]
	public static int KEBHDGIOIOE(ref byte[] NCCOCLJLPFP, int EGBIMJLECFF, float CCIMHDCKHOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x17123A0", Offset = "0x1710BA0", VA = "0x1817123A0")]
	public static int KEBHDGIOIOE(ref byte[] NCCOCLJLPFP, int EGBIMJLECFF, double CCIMHDCKHOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1713800", Offset = "0x1712000", VA = "0x181713800")]
	private static bool PLOKFEIOOBH(byte[] NCCOCLJLPFP, int HOPGLJCPGGA, ulong LHHKKFCHGFO, ulong LLKGEIPKIOD, ulong OILHPMFBCIA, ulong GIJCAAKDGNL, ulong JILIAOKFEHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x1711B50", Offset = "0x1710350", VA = "0x181711B50")]
	private static void DIKGMAHMJHN(uint HEMEFOFCGJG, int LNGMIFEELJP, out uint HHJPAOCLOKI, out int KDPHOEPNOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x1711690", Offset = "0x170FE90", VA = "0x181711690")]
	private static bool BDHFHJNONPD(FNBMOHMOAFJ MGEMJGILCAC, FNBMOHMOAFJ NOMPHPBFLNE, FNBMOHMOAFJ GKHPODHMJGB, byte[] NCCOCLJLPFP, out int HOPGLJCPGGA, out int DKMOINFLGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1712650", Offset = "0x1710E50", VA = "0x181712650")]
	private static bool LDBIEDGHCJC(double DCNCBDGEKMD, IBLICHDBBLC PDFIDNNGANB, byte[] NCCOCLJLPFP, out int HOPGLJCPGGA, out int FJOPLOGBEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1713220", Offset = "0x1711A20", VA = "0x181713220")]
	private static bool NJANODHFCOM(double DCNCBDGEKMD, IBLICHDBBLC PDFIDNNGANB, byte[] NCCOCLJLPFP, out int HOPGLJCPGGA, out int MKLHIKMFECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x17124C0", Offset = "0x1710CC0", VA = "0x1817124C0")]
	private static bool KIBDJNINPIG(double CCIMHDCKHOF, ref KNEAGJOJBNI HLKCIMHFPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x1712AE0", Offset = "0x17112E0", VA = "0x181712AE0")]
	private static bool LMALLFEHBFO(double CCIMHDCKHOF, ref KNEAGJOJBNI HLKCIMHFPMH, AABACCGGELH PDFIDNNGANB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x1713330", Offset = "0x1711B30", VA = "0x181713330")]
	private static void NOEBNOGIHGI(byte[] DEJLILJGEDA, int HOPGLJCPGGA, int MKLHIKMFECN, int AKDJEAOOGBI, ref KNEAGJOJBNI HLKCIMHFPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x1711D50", Offset = "0x1710550", VA = "0x181711D50")]
	private static void JMBLEJCDFML(byte[] DEJLILJGEDA, int HOPGLJCPGGA, int KMMODGACMAP, ref KNEAGJOJBNI HLKCIMHFPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x17114E0", Offset = "0x170FCE0", VA = "0x1817114E0")]
	private static bool ABNNNLJHDPK(double DCNCBDGEKMD, AABACCGGELH PDFIDNNGANB, int FEKCFBJLCBC, byte[] HNKCOCKDCCG, out bool MHFHNKAADOH, out int HOPGLJCPGGA, out int ADMEPHMBKKP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct GFIDFAMMMJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double BOMCMOAJNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong DIEBPANNGPH;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct PCDAPEIBFEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float BPJEFFCEPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint PLPGFHAABJH;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct OLEEFJKDEHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong OLGGJOLBLMK;

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x18E54D0", Offset = "0x18E3CD0", VA = "0x1818E54D0")]
	public OLEEFJKDEHG(double BOMCMOAJNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x18E54E0", Offset = "0x18E3CE0", VA = "0x1818E54E0")]
	public OLEEFJKDEHG(FNBMOHMOAFJ BOMCMOAJNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x18E5080", Offset = "0x18E3880", VA = "0x1818E5080")]
	public FNBMOHMOAFJ CPPKLDNDKHF()
	{
		return default(FNBMOHMOAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x18E53D0", Offset = "0x18E3BD0", VA = "0x1818E53D0")]
	public FNBMOHMOAFJ NDICJMPMDAC()
	{
		return default(FNBMOHMOAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7579C0", Offset = "0x7561C0", VA = "0x1807579C0")]
	public ulong GJFIOMAMIJI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x18E51B0", Offset = "0x18E39B0", VA = "0x1818E51B0")]
	public double IKKFEPIJKJF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x18E52A0", Offset = "0x18E3AA0", VA = "0x1818E52A0")]
	public double LOKELEODEAC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x18E5170", Offset = "0x18E3970", VA = "0x1818E5170")]
	public int GHKHECFLDNB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x18E5460", Offset = "0x18E3C60", VA = "0x1818E5460")]
	public ulong OMMEPPIMAME()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x18E5060", Offset = "0x18E3860", VA = "0x1818E5060")]
	public bool CIKAPPHHJPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x18E5490", Offset = "0x18E3C90", VA = "0x1818E5490")]
	public bool PGLIJHJGBFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x18E5270", Offset = "0x18E3A70", VA = "0x1818E5270")]
	public bool LIBBPKEJION()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x18E5240", Offset = "0x18E3A40", VA = "0x1818E5240")]
	public bool LEJOJAOACBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x18E54B0", Offset = "0x18E3CB0", VA = "0x1818E54B0")]
	public int PILKEAEDACP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x18E4EE0", Offset = "0x18E36E0", VA = "0x1818E4EE0")]
	public void ABFNMNAGIOC(out FNBMOHMOAFJ PIEOJPKCCMH, out FNBMOHMOAFJ IMFDCPCHODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x18E5120", Offset = "0x18E3920", VA = "0x1818E5120")]
	public bool FKBINABOBNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x18E5050", Offset = "0x18E3850", VA = "0x1818E5050")]
	public double CCIMHDCKHOF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x18E5100", Offset = "0x18E3900", VA = "0x1818E5100")]
	public static int ENMADHAMLGB(int CAMLMLHFCOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x18E51A0", Offset = "0x18E39A0", VA = "0x1818E51A0")]
	public static double HOBGNBEPJHD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x18E5330", Offset = "0x18E3B30", VA = "0x1818E5330")]
	public static ulong MEHDKADPGBD(FNBMOHMOAFJ PMAKEAALLEO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct OJDBDENBJPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint LADAOHHMGJF;

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E80", Offset = "0x6E1680", VA = "0x1806E2E80")]
	public OJDBDENBJPC(float BPJEFFCEPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x18E4DF0", Offset = "0x18E35F0", VA = "0x1818E4DF0")]
	public FNBMOHMOAFJ CPPKLDNDKHF()
	{
		return default(FNBMOHMOAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x79B630", Offset = "0x799E30", VA = "0x18079B630")]
	public uint KDIKHKFCPNC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x18E4EA0", Offset = "0x18E36A0", VA = "0x1818E4EA0")]
	public int GHKHECFLDNB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x18E4EC0", Offset = "0x18E36C0", VA = "0x1818E4EC0")]
	public uint OMMEPPIMAME()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x18E4DE0", Offset = "0x18E35E0", VA = "0x1818E4DE0")]
	public bool CIKAPPHHJPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x18E4C80", Offset = "0x18E3480", VA = "0x1818E4C80")]
	public void ABFNMNAGIOC(out FNBMOHMOAFJ PIEOJPKCCMH, out FNBMOHMOAFJ IMFDCPCHODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x18E4E60", Offset = "0x18E3660", VA = "0x1818E4E60")]
	public bool FKBINABOBNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct LHDKDNLHNEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong JNPNBGAKPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short BFJOAAJAHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short FJOPLOGBEDK;

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x171E4C0", Offset = "0x171CCC0", VA = "0x18171E4C0")]
	public LHDKDNLHNEJ(ulong JNPNBGAKPBA, short BFJOAAJAHEG, short FJOPLOGBEDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class NEMNGBEBJLO
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly LHDKDNLHNEJ[] NLLKDIKLMIO;

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1723330", Offset = "0x1721B30", VA = "0x181723330")]
	public static void LGJLJFFMMEA(int AKDJDGJOBBJ, int HGMIEPGAGGP, out FNBMOHMOAFJ HHJPAOCLOKI, out int FJOPLOGBEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x1723240", Offset = "0x1721A40", VA = "0x181723240")]
	public static void BGCEKCLPPML(int FNPLGNEGELG, out FNBMOHMOAFJ HHJPAOCLOKI, out int BGHFFKBHDDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct HEPAACAHFJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] CDDAIIMDJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int OMKHMNIPPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int BHDCFOCMAFI;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x1718EE0", Offset = "0x17176E0", VA = "0x181718EE0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xCD8E80", Offset = "0xCD7680", VA = "0x180CD8E80")]
	public HEPAACAHFJD(byte[] CDDAIIMDJCN, int OMKHMNIPPGH, int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x79B640", Offset = "0x799E40", VA = "0x18079B640")]
	public int HOPGLJCPGGA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1718E80", Offset = "0x1717680", VA = "0x181718E80")]
	public HEPAACAHFJD ICNKJBJJLIG(int PJLFEJFCFBB, int CKCMLJGEIGK)
	{
		return default(HEPAACAHFJD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class CGEEHCEILMH
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] NOMIHPLEAOC;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] FCPGINDDKIP;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int JEPOLPOIKJC;

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x1889030", Offset = "0x1887830", VA = "0x181889030")]
	private static byte[] KILPFLJGOHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x18893C0", Offset = "0x1887BC0", VA = "0x1818893C0")]
	private static HEPAACAHFJD LFGHNEGKNGP(HEPAACAHFJD NCCOCLJLPFP)
	{
		return default(HEPAACAHFJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x1888490", Offset = "0x1886C90", VA = "0x181888490")]
	private static HEPAACAHFJD HMINGPNOAGP(HEPAACAHFJD NCCOCLJLPFP)
	{
		return default(HEPAACAHFJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x1889700", Offset = "0x1887F00", VA = "0x181889700")]
	private static void ONNNDPKAPNJ(HEPAACAHFJD NCCOCLJLPFP, int KMMODGACMAP, byte[] BIJICEEAAAG, out int HDNADPFGKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x1889120", Offset = "0x1887920", VA = "0x181889120")]
	private static void KMEBMNHENOF(HEPAACAHFJD NCCOCLJLPFP, int KMMODGACMAP, byte[] LMLBGGFMJNK, int IKKIEFJBDEG, out HEPAACAHFJD LJLMMLLBADH, out int IDBOIHBGNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x1888930", Offset = "0x1887130", VA = "0x181888930")]
	private static ulong JDJOHAPBAPK(HEPAACAHFJD NCCOCLJLPFP, out int HCPBCIMLDFM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x1889470", Offset = "0x1887C70", VA = "0x181889470")]
	private static void MBDAMKOFLFH(HEPAACAHFJD NCCOCLJLPFP, out FNBMOHMOAFJ BBELMPNHPOK, out int GGHMEHIIDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x1888540", Offset = "0x1886D40", VA = "0x181888540")]
	private static bool ICFPDNFEHBO(HEPAACAHFJD LJLMMLLBADH, int KMMODGACMAP, out double BBELMPNHPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1888E80", Offset = "0x1887680", VA = "0x181888E80")]
	private static FNBMOHMOAFJ KHGMHGMBJDE(int KMMODGACMAP)
	{
		return default(FNBMOHMOAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x18889C0", Offset = "0x18871C0", VA = "0x1818889C0")]
	private static bool JGCFILHBBOB(HEPAACAHFJD NCCOCLJLPFP, int KMMODGACMAP, out double BBELMPNHPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x18895C0", Offset = "0x1887DC0", VA = "0x1818895C0")]
	private static bool MOLPLEHALGA(HEPAACAHFJD LJLMMLLBADH, int KMMODGACMAP, out double LECOIDHKFLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x1888370", Offset = "0x1886B70", VA = "0x181888370")]
	public static double? EOLCFLJCNJH(HEPAACAHFJD NCCOCLJLPFP, int KMMODGACMAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x1888190", Offset = "0x1886990", VA = "0x181888190")]
	public static float? DKDCHANHAJL(HEPAACAHFJD NCCOCLJLPFP, int KMMODGACMAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct IGFMANGPAHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] NCCOCLJLPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int EGBIMJLECFF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte FHONEBOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x171AB00", Offset = "0x1719300", VA = "0x18171AB00")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x899220", Offset = "0x897A20", VA = "0x180899220")]
	public IGFMANGPAHA(byte[] NCCOCLJLPFP, int EGBIMJLECFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x171AC00", Offset = "0x1719400", VA = "0x18171AC00")]
	public static IGFMANGPAHA HICLGKMKDEG(IGFMANGPAHA IPNNIJODOPO)
	{
		return default(IGFMANGPAHA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x171AC10", Offset = "0x1719410", VA = "0x18171AC10")]
	public static IGFMANGPAHA IDPFAKACPID(IGFMANGPAHA IPNNIJODOPO, int HOPGLJCPGGA)
	{
		return default(IGFMANGPAHA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x171AD00", Offset = "0x1719500", VA = "0x18171AD00")]
	public static int MMBIJLAKMHD(IGFMANGPAHA FEBCAKEBBCL, IGFMANGPAHA EEACLMBPLFE)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x171AB40", Offset = "0x1719340", VA = "0x18171AB40")]
	public static bool CGFEPDNGNBJ(IGFMANGPAHA FEBCAKEBBCL, IGFMANGPAHA EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x171AD70", Offset = "0x1719570", VA = "0x18171AD70")]
	public static bool NODBGCCFDAJ(IGFMANGPAHA FEBCAKEBBCL, IGFMANGPAHA EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x171AB60", Offset = "0x1719360", VA = "0x18171AB60")]
	public static bool CGFEPDNGNBJ(IGFMANGPAHA FEBCAKEBBCL, char EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x171AD20", Offset = "0x1719520", VA = "0x18171AD20")]
	public static bool NODBGCCFDAJ(IGFMANGPAHA FEBCAKEBBCL, char EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x171AD20", Offset = "0x1719520", VA = "0x18171AD20")]
	public static bool NODBGCCFDAJ(IGFMANGPAHA FEBCAKEBBCL, byte EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x171ACB0", Offset = "0x17194B0", VA = "0x18171ACB0")]
	public static bool LMNFBOAPBJP(IGFMANGPAHA FEBCAKEBBCL, char EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x171AC60", Offset = "0x1719460", VA = "0x18171AC60")]
	public static bool KPJPCENEJGN(IGFMANGPAHA FEBCAKEBBCL, char EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x171ABB0", Offset = "0x17193B0", VA = "0x18171ABB0")]
	public static bool FCMIAOMFIPH(IGFMANGPAHA FEBCAKEBBCL, char EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x171AD90", Offset = "0x1719590", VA = "0x18171AD90")]
	public static bool NOEDKDHJHOK(IGFMANGPAHA FEBCAKEBBCL, char EEACLMBPLFE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class GNGOOAJJJLG
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] CKDDALOCELN;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] MCFOKLEGFBL;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] HDAGOMPAPGE;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] AGFHNKDLBGM;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] OFIKBDKAPEK;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int BDJEOFMBOPE;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] IMJIDDENMDN;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int ACMBMCHJJAB;

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x1711180", Offset = "0x170F980", VA = "0x181711180")]
	private static byte[] MNPKOLKGMCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x170FE10", Offset = "0x170E610", VA = "0x18170FE10")]
	private static byte[] BEMMOHCPDPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x17110C0", Offset = "0x170F8C0", VA = "0x1817110C0")]
	public static double LNFFMLHHPIK(byte[] NCCOCLJLPFP, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x1711000", Offset = "0x170F800", VA = "0x181711000")]
	public static float JNAHFECIEED(byte[] NCCOCLJLPFP, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x170FC90", Offset = "0x170E490", VA = "0x18170FC90")]
	private static bool BCIJPNLDDGE(int ODLLFOGPPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x170FB70", Offset = "0x170E370", VA = "0x18170FB70")]
	private static bool AJKCFLJHBOM(ref IGFMANGPAHA IMLJHLOOKFM, IGFMANGPAHA BDPJJHLGMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x170FF60", Offset = "0x170E760", VA = "0x18170FF60")]
	private static bool HEGAEJMAGIM(ref IGFMANGPAHA IMLJHLOOKFM, IGFMANGPAHA BDPJJHLGMOK, byte[] CGHJGICOJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x170FF00", Offset = "0x170E700", VA = "0x18170FF00")]
	private static bool EHGAODFAKMK(ref IGFMANGPAHA JLHFEECHHCL, byte[] LILNHPOEIJC, int EGBIMJLECFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x170FB50", Offset = "0x170E350", VA = "0x18170FB50")]
	private static double AFHCDABFIJC(bool MHFHNKAADOH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x1710080", Offset = "0x170E880", VA = "0x181710080")]
	private static double HLDIFBBGJKO(IGFMANGPAHA KAKCHGJCKMF, int HOPGLJCPGGA, bool JCHFDOHMAKD, out int EAGBIGIOEKO)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class HCAMFDLELGA<T> : global::HAKOMFHEDCC<T[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly global::IOAKBHOGHOE<T> BJMHJKDBLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly ENFHMOLIHKA MMPLAMJDCGA;

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3593FA0", Offset = "0x35927A0", VA = "0x183593FA0")]
	public HCAMFDLELGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2F88790", Offset = "0x2F86F90", VA = "0x182F88790")]
	public HCAMFDLELGA(ENFHMOLIHKA MMPLAMJDCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3593850", Offset = "0x3592050", VA = "0x183593850", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x3591F70", Offset = "0x3590770", VA = "0x183591F70", Slot = "5")]
	public T[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class PKAJOMOJPEC<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly global::IOAKBHOGHOE<T> BJMHJKDBLOI;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class PKHHKMBMIGG<T> : global::HAKOMFHEDCC<List<T>>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly ENFHMOLIHKA MMPLAMJDCGA;

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x3593FA0", Offset = "0x35927A0", VA = "0x183593FA0")]
	public PKHHKMBMIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2F88790", Offset = "0x2F86F90", VA = "0x182F88790")]
	public PKHHKMBMIGG(ENFHMOLIHKA MMPLAMJDCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3B34380", Offset = "0x3B32B80", VA = "0x183B34380", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, List<T> CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3B33820", Offset = "0x3B32020", VA = "0x183B33820", Slot = "5")]
	public List<T> ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class FDLEJHFBKJP<TElement, TIntermediate, TEnumerator, TCollection> : global::HAKOMFHEDCC<TCollection>, LOIEEHPBJBK where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x34B9A00", Offset = "0x34B8200", VA = "0x1834B9A00", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, TCollection CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x34B8E90", Offset = "0x34B7690", VA = "0x1834B8E90", Slot = "5")]
	public TCollection ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator GCLCCONAGDL(TCollection LENKHFNFMLN);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate MFNJFAEBAIM();

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void CEMPCIEDPMO(ref TIntermediate JBGBCNGIBOP, int MMABPPDCBIB, TElement CCIMHDCKHOF);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection ECFFKMLILHP(ref TIntermediate INHIJMIJKMN);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
	protected FDLEJHFBKJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class PPHKEKFDBAA<TElement, TIntermediate, TCollection> : global::FDLEJHFBKJP<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3421B90", Offset = "0x3420390", VA = "0x183421B90", Slot = "6")]
	protected override IEnumerator<TElement> GCLCCONAGDL(TCollection LENKHFNFMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x329E290", Offset = "0x329CA90", VA = "0x18329E290")]
	protected PPHKEKFDBAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class OJLCAAKCBIE<TElement, TCollection> : global::PPHKEKFDBAA<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A060", Offset = "0x1E48860", VA = "0x181E4A060", Slot = "9")]
	protected sealed override TCollection ECFFKMLILHP(ref TCollection INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class KCFBGMDJCGN<TElement, TCollection> : global::OJLCAAKCBIE<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x37BC000", Offset = "0x37BA800", VA = "0x1837BC000", Slot = "7")]
	protected override TCollection MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x37BBF90", Offset = "0x37BA790", VA = "0x1837BBF90", Slot = "8")]
	protected override void CEMPCIEDPMO(ref TCollection JBGBCNGIBOP, int MMABPPDCBIB, TElement CCIMHDCKHOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class NFPOKPHKILA<T> : global::FDLEJHFBKJP<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x32DF280", Offset = "0x32DDA80", VA = "0x1832DF280", Slot = "8")]
	protected override void CEMPCIEDPMO(ref LinkedList<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A060", Offset = "0x1E48860", VA = "0x181E4A060", Slot = "9")]
	protected override LinkedList<T> ECFFKMLILHP(ref LinkedList<T> INHIJMIJKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x32DF320", Offset = "0x32DDB20", VA = "0x1832DF320", Slot = "7")]
	protected override LinkedList<T> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x32DF2C0", Offset = "0x32DDAC0", VA = "0x1832DF2C0", Slot = "6")]
	protected override LinkedList<T>.Enumerator GCLCCONAGDL(LinkedList<T> LENKHFNFMLN)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class JJHNCCIKGHL<T> : global::FDLEJHFBKJP<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x32DF280", Offset = "0x32DDA80", VA = "0x1832DF280", Slot = "8")]
	protected override void CEMPCIEDPMO(ref Queue<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x32DF320", Offset = "0x32DDB20", VA = "0x1832DF320", Slot = "7")]
	protected override Queue<T> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3B2A080", Offset = "0x3B28880", VA = "0x183B2A080", Slot = "6")]
	protected override Queue<T>.Enumerator GCLCCONAGDL(Queue<T> LENKHFNFMLN)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A060", Offset = "0x1E48860", VA = "0x181E4A060", Slot = "9")]
	protected override Queue<T> ECFFKMLILHP(ref Queue<T> INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class PHAIIABNPFK<T> : global::FDLEJHFBKJP<T, global::DAFGBDPGAFN<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x3591150", Offset = "0x358F950", VA = "0x183591150", Slot = "8")]
	protected override void CEMPCIEDPMO(ref global::DAFGBDPGAFN<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x35911A0", Offset = "0x358F9A0", VA = "0x1835911A0", Slot = "7")]
	protected override global::DAFGBDPGAFN<T> MFNJFAEBAIM()
	{
		return default(global::DAFGBDPGAFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3B2A080", Offset = "0x3B28880", VA = "0x183B2A080", Slot = "6")]
	protected override Stack<T>.Enumerator GCLCCONAGDL(Stack<T> LENKHFNFMLN)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3B29FA0", Offset = "0x3B287A0", VA = "0x183B29FA0", Slot = "9")]
	protected override Stack<T> ECFFKMLILHP(ref global::DAFGBDPGAFN<T> INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class DOGKCEMFLKM<T> : global::FDLEJHFBKJP<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x32DF280", Offset = "0x32DDA80", VA = "0x1832DF280", Slot = "8")]
	protected override void CEMPCIEDPMO(ref HashSet<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A060", Offset = "0x1E48860", VA = "0x181E4A060", Slot = "9")]
	protected override HashSet<T> ECFFKMLILHP(ref HashSet<T> INHIJMIJKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x32DF320", Offset = "0x32DDB20", VA = "0x1832DF320", Slot = "7")]
	protected override HashSet<T> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x3B2A080", Offset = "0x3B28880", VA = "0x183B2A080", Slot = "6")]
	protected override HashSet<T>.Enumerator GCLCCONAGDL(HashSet<T> LENKHFNFMLN)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class OMBFDBGJLFE<T> : global::PPHKEKFDBAA<T, global::DAFGBDPGAFN<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3591150", Offset = "0x358F950", VA = "0x183591150", Slot = "8")]
	protected override void CEMPCIEDPMO(ref global::DAFGBDPGAFN<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3B89D10", Offset = "0x3B88510", VA = "0x183B89D10", Slot = "9")]
	protected override ReadOnlyCollection<T> ECFFKMLILHP(ref global::DAFGBDPGAFN<T> INHIJMIJKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3B89DA0", Offset = "0x3B885A0", VA = "0x183B89DA0", Slot = "7")]
	protected override global::DAFGBDPGAFN<T> MFNJFAEBAIM()
	{
		return default(global::DAFGBDPGAFN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class HPLMJNILOAH<T> : global::PPHKEKFDBAA<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x32DF280", Offset = "0x32DDA80", VA = "0x1832DF280", Slot = "8")]
	protected override void CEMPCIEDPMO(ref List<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x32DF320", Offset = "0x32DDB20", VA = "0x1832DF320", Slot = "7")]
	protected override List<T> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A060", Offset = "0x1E48860", VA = "0x181E4A060", Slot = "9")]
	protected override IList<T> ECFFKMLILHP(ref List<T> INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class CEHBEGMHIJG<T> : global::PPHKEKFDBAA<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x32DF280", Offset = "0x32DDA80", VA = "0x1832DF280", Slot = "8")]
	protected override void CEMPCIEDPMO(ref List<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x32DF320", Offset = "0x32DDB20", VA = "0x1832DF320", Slot = "7")]
	protected override List<T> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A060", Offset = "0x1E48860", VA = "0x181E4A060", Slot = "9")]
	protected override ICollection<T> ECFFKMLILHP(ref List<T> INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class HBPBMNBDEHE<T> : global::PPHKEKFDBAA<T, global::DAFGBDPGAFN<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x3591150", Offset = "0x358F950", VA = "0x183591150", Slot = "8")]
	protected override void CEMPCIEDPMO(ref global::DAFGBDPGAFN<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x35911A0", Offset = "0x358F9A0", VA = "0x1835911A0", Slot = "7")]
	protected override global::DAFGBDPGAFN<T> MFNJFAEBAIM()
	{
		return default(global::DAFGBDPGAFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3591180", Offset = "0x358F980", VA = "0x183591180", Slot = "9")]
	protected override IEnumerable<T> ECFFKMLILHP(ref global::DAFGBDPGAFN<T> INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class LMLAFMAODMC<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class HBOAODHPJMA<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class PMNDOPKMIFM<T> : global::HAKOMFHEDCC<T>, LOIEEHPBJBK where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x341B120", Offset = "0x3419920", VA = "0x18341B120", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x341AF10", Offset = "0x3419710", VA = "0x18341AF10", Slot = "5")]
	public T ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
	public PMNDOPKMIFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class GBHBNKKAFAG : global::HAKOMFHEDCC<IEnumerable>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::HAKOMFHEDCC<IEnumerable> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x170DC80", Offset = "0x170C480", VA = "0x18170DC80", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, IEnumerable CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x170D9F0", Offset = "0x170C1F0", VA = "0x18170D9F0", Slot = "5")]
	public IEnumerable ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public GBHBNKKAFAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class NDHFDCLFLDD : global::HAKOMFHEDCC<ICollection>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public static readonly global::HAKOMFHEDCC<ICollection> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x1722E60", Offset = "0x1721660", VA = "0x181722E60", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ICollection CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x1722BD0", Offset = "0x17213D0", VA = "0x181722BD0", Slot = "5")]
	public ICollection ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public NDHFDCLFLDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class AGBGPPPCPJK : global::HAKOMFHEDCC<IList>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::HAKOMFHEDCC<IList> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1881CB0", Offset = "0x18804B0", VA = "0x181881CB0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, IList CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x1881B00", Offset = "0x1880300", VA = "0x181881B00", Slot = "5")]
	public IList ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public AGBGPPPCPJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class KKINCLPKBIN<T> : global::PPHKEKFDBAA<T, global::DAFGBDPGAFN<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3DC8D20", Offset = "0x3DC7520", VA = "0x183DC8D20", Slot = "8")]
	protected override void CEMPCIEDPMO(ref global::DAFGBDPGAFN<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x35911A0", Offset = "0x358F9A0", VA = "0x1835911A0", Slot = "7")]
	protected override global::DAFGBDPGAFN<T> MFNJFAEBAIM()
	{
		return default(global::DAFGBDPGAFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3DC8D80", Offset = "0x3DC7580", VA = "0x183DC8D80", Slot = "9")]
	protected override IReadOnlyList<T> ECFFKMLILHP(ref global::DAFGBDPGAFN<T> INHIJMIJKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x32D12A0", Offset = "0x32CFAA0", VA = "0x1832D12A0")]
	public KKINCLPKBIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class PIELEEOOGBM
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x18E5F90", Offset = "0x18E4790", VA = "0x1818E5F90")]
	public static DateTime GBDGFHAEAHJ(DateTime PJIOPOKFBOO)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class HCBBHNHICEF : global::HAKOMFHEDCC<DateTime>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly global::HAKOMFHEDCC<DateTime> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x1717FA0", Offset = "0x17167A0", VA = "0x181717FA0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, DateTime CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x1717040", Offset = "0x1715840", VA = "0x181717040", Slot = "5")]
	public DateTime ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public HCBBHNHICEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class BCIKDCDOFJC : global::HAKOMFHEDCC<DateTimeOffset>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly global::HAKOMFHEDCC<DateTimeOffset> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x18870E0", Offset = "0x18858E0", VA = "0x1818870E0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, DateTimeOffset CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x1886210", Offset = "0x1884A10", VA = "0x181886210", Slot = "5")]
	public DateTimeOffset ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BCIKDCDOFJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class HKKNIBBPEFD : global::HAKOMFHEDCC<TimeSpan>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly global::HAKOMFHEDCC<TimeSpan> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static byte[] DPOGFJHACEA;

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x1719DE0", Offset = "0x17185E0", VA = "0x181719DE0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, TimeSpan CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x1719350", Offset = "0x1717B50", VA = "0x181719350", Slot = "5")]
	public TimeSpan ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public HKKNIBBPEFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class BHALPHLGMCB<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::HAKOMFHEDCC<TDictionary>, LOIEEHPBJBK where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3661990", Offset = "0x3660190", VA = "0x183661990", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, TDictionary CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x365F340", Offset = "0x365DB40", VA = "0x18365F340", Slot = "5")]
	public TDictionary ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator GCLCCONAGDL(TDictionary LENKHFNFMLN);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate MFNJFAEBAIM();

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void CEMPCIEDPMO(ref TIntermediate JBGBCNGIBOP, int MMABPPDCBIB, TKey AGPLDPOAAIC, TValue CCIMHDCKHOF);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary ECFFKMLILHP(ref TIntermediate INHIJMIJKMN);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
	protected BHALPHLGMCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class PGCKIGIONHB<TKey, TValue, TIntermediate, TDictionary> : global::BHALPHLGMCB<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x3421B90", Offset = "0x3420390", VA = "0x183421B90", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> GCLCCONAGDL(TDictionary LENKHFNFMLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class MDOGFDEDGLP<TKey, TValue, TDictionary> : global::PGCKIGIONHB<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A060", Offset = "0x1E48860", VA = "0x181E4A060", Slot = "9")]
	protected override TDictionary ECFFKMLILHP(ref TDictionary INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class KAKFMBCGKJB<TKey, TValue> : global::BHALPHLGMCB<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x37BA340", Offset = "0x37B8B40", VA = "0x1837BA340", Slot = "8")]
	protected override void CEMPCIEDPMO(ref Dictionary<TKey, TValue> JBGBCNGIBOP, int MMABPPDCBIB, TKey AGPLDPOAAIC, TValue CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A060", Offset = "0x1E48860", VA = "0x181E4A060", Slot = "9")]
	protected override Dictionary<TKey, TValue> ECFFKMLILHP(ref Dictionary<TKey, TValue> INHIJMIJKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x32DF320", Offset = "0x32DDB20", VA = "0x1832DF320", Slot = "7")]
	protected override Dictionary<TKey, TValue> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x37BA380", Offset = "0x37B8B80", VA = "0x1837BA380", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator GCLCCONAGDL(Dictionary<TKey, TValue> LENKHFNFMLN)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2031830", Offset = "0x2030030", VA = "0x182031830")]
	public KAKFMBCGKJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class KOPFCJJDLFG<TKey, TValue, TDictionary> : global::MDOGFDEDGLP<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3DD59E0", Offset = "0x3DD41E0", VA = "0x183DD59E0", Slot = "8")]
	protected override void CEMPCIEDPMO(ref TDictionary JBGBCNGIBOP, int MMABPPDCBIB, TKey AGPLDPOAAIC, TValue CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CB10", Offset = "0x2F8B310", VA = "0x182F8CB10", Slot = "7")]
	protected override TDictionary MFNJFAEBAIM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class FGPANOIFBKN<TKey, TValue> : global::PGCKIGIONHB<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x341FA90", Offset = "0x341E290", VA = "0x18341FA90", Slot = "8")]
	protected override void CEMPCIEDPMO(ref Dictionary<TKey, TValue> JBGBCNGIBOP, int MMABPPDCBIB, TKey AGPLDPOAAIC, TValue CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x32DF320", Offset = "0x32DDB20", VA = "0x1832DF320", Slot = "7")]
	protected override Dictionary<TKey, TValue> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A060", Offset = "0x1E48860", VA = "0x181E4A060", Slot = "9")]
	protected override IDictionary<TKey, TValue> ECFFKMLILHP(ref Dictionary<TKey, TValue> INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class DANKCOKBBPJ<TKey, TValue> : global::MDOGFDEDGLP<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x341FA90", Offset = "0x341E290", VA = "0x18341FA90", Slot = "8")]
	protected override void CEMPCIEDPMO(ref SortedList<TKey, TValue> JBGBCNGIBOP, int MMABPPDCBIB, TKey AGPLDPOAAIC, TValue CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x32DF320", Offset = "0x32DDB20", VA = "0x1832DF320", Slot = "7")]
	protected override SortedList<TKey, TValue> MFNJFAEBAIM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class PODHLHLGKJI<TKey, TValue> : global::BHALPHLGMCB<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x341FA90", Offset = "0x341E290", VA = "0x18341FA90", Slot = "8")]
	protected override void CEMPCIEDPMO(ref SortedDictionary<TKey, TValue> JBGBCNGIBOP, int MMABPPDCBIB, TKey AGPLDPOAAIC, TValue CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A060", Offset = "0x1E48860", VA = "0x181E4A060", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> ECFFKMLILHP(ref SortedDictionary<TKey, TValue> INHIJMIJKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x32DF320", Offset = "0x32DDB20", VA = "0x1832DF320", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x341FAD0", Offset = "0x341E2D0", VA = "0x18341FAD0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator GCLCCONAGDL(SortedDictionary<TKey, TValue> LENKHFNFMLN)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class EIJFCDEEFNM<T> : global::HAKOMFHEDCC<T>, LOIEEHPBJBK where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3340", Offset = "0x2FC1B40", VA = "0x182FC3340", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3110", Offset = "0x2FC1910", VA = "0x182FC3110", Slot = "5")]
	public T ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
	public EIJFCDEEFNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class FIHPJLCEDGD : global::HAKOMFHEDCC<IDictionary>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly global::HAKOMFHEDCC<IDictionary> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x170CA60", Offset = "0x170B260", VA = "0x18170CA60", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, IDictionary CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x170C6C0", Offset = "0x170AEC0", VA = "0x18170C6C0", Slot = "5")]
	public IDictionary ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public FIHPJLCEDGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class CNMFNILJJCJ : global::HAKOMFHEDCC<object>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void FMEFDKLNLMO(object DNBMLPPLJGA, ref KNPMIFIKMDA FBNHINKPMEA, object CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly global::JMJBDOGCDKP<KeyValuePair<object, FMEFDKLNLMO>> BOPHPJCPNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly IEIMAIBIIFF[] PABOPDBNPMB;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x188B250", Offset = "0x1889A50", VA = "0x18188B250")]
	public CNMFNILJJCJ(params IEIMAIBIIFF[] PABOPDBNPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x188A870", Offset = "0x1889070", VA = "0x18188A870", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, object CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x188A7D0", Offset = "0x1888FD0", VA = "0x18188A7D0", Slot = "5")]
	public object ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class NPLDGFPJINE
{
	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x18E0E70", Offset = "0x18DF670", VA = "0x1818E0E70")]
	public static object PILFENOKJPM(Type BCFKLEGAMEO, out bool HKKBCMGAONN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x18E0550", Offset = "0x18DED50", VA = "0x1818E0550")]
	public static object LICFHKCBHHA(Type BCFKLEGAMEO, out bool HKKBCMGAONN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class IIABPOLPNAH<T> : global::HAKOMFHEDCC<T>, LOIEEHPBJBK, global::PEHGKAMCACG<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class LPAEILKBILJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public LPAEILKBILJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x375E570", Offset = "0x375CD70", VA = "0x18375E570")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class LIBOGMCNDLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public global::BKKGNGKDABO<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public LIBOGMCNDLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x39111F0", Offset = "0x390F9F0", VA = "0x1839111F0")]
		internal void <.cctor>b__1(ref KNPMIFIKMDA writer, T value, IEIMAIBIIFF _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class CBJFNIOKCKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public global::IKNPCAKNFFF<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public CBJFNIOKCKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x40F38E0", Offset = "0x40F20E0", VA = "0x1840F38E0")]
		internal T <.cctor>b__2(ref GOCMFGPNGFE reader, IEIMAIBIIFF _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly global::GALOOIHPGNA<T> PFDPDENEIOB;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static readonly Dictionary<T, string> BGNOAHGHPPJ;

	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private static readonly global::BKKGNGKDABO<T> GGOFINJAIKF;

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly global::IKNPCAKNFFF<T> NEHGKJBICIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly bool LOJPIBAKOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly global::BKKGNGKDABO<T> GODFCLHOFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::IKNPCAKNFFF<T> BKEJJAMDHCJ;

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x4549E00", Offset = "0x4548600", VA = "0x184549E00")]
	static IIABPOLPNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3BCDD60", Offset = "0x3BCC560", VA = "0x183BCDD60")]
	public IIABPOLPNAH(bool LOJPIBAKOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x453B4C0", Offset = "0x4539CC0", VA = "0x18453B4C0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x4535590", Offset = "0x4533D90", VA = "0x184535590", Slot = "5")]
	public T ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x453FF60", Offset = "0x453E760", VA = "0x18453FF60", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x453E590", Offset = "0x453CD90", VA = "0x18453E590", Slot = "7")]
	public T MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class GHJPJEMJKHK<T> : global::HAKOMFHEDCC<T[,]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x41A0B50", Offset = "0x419F350", VA = "0x1841A0B50", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T[,] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x41A0880", Offset = "0x419F080", VA = "0x1841A0880", Slot = "5")]
	public T[,] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
	public GHJPJEMJKHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class DININCPNFKE<T> : global::HAKOMFHEDCC<T[,,]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x3C198C0", Offset = "0x3C180C0", VA = "0x183C198C0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T[,,] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3C194E0", Offset = "0x3C17CE0", VA = "0x183C194E0", Slot = "5")]
	public T[,,] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
	public DININCPNFKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class CNDLCIFFLFM<T> : global::HAKOMFHEDCC<T[,,,]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x38794C0", Offset = "0x3877CC0", VA = "0x1838794C0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T[,,,] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x3878FC0", Offset = "0x38777C0", VA = "0x183878FC0", Slot = "5")]
	public T[,,,] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
	public CNDLCIFFLFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class CJOCGKLADIC<T> : global::HAKOMFHEDCC<T?>, LOIEEHPBJBK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x386A890", Offset = "0x3869090", VA = "0x18386A890", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x386A740", Offset = "0x3868F40", VA = "0x18386A740", Slot = "5")]
	public T? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
	public CJOCGKLADIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class JAFFPLMOHOF<T> : global::HAKOMFHEDCC<T?>, LOIEEHPBJBK where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private readonly global::HAKOMFHEDCC<T> LNLANNNHDAI;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D630", Offset = "0x2B2BE30", VA = "0x182B2D630")]
	public JAFFPLMOHOF(global::HAKOMFHEDCC<T> LNLANNNHDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x32A0970", Offset = "0x329F170", VA = "0x1832A0970")]
	public JAFFPLMOHOF(Type NLNGAAILPIL, object[] JHKOBFCIOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x329F0A0", Offset = "0x329D8A0", VA = "0x18329F0A0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x329EC70", Offset = "0x329D470", VA = "0x18329EC70", Slot = "5")]
	public T? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class GOPLJFLGDBE : global::HAKOMFHEDCC<sbyte>, LOIEEHPBJBK, global::PEHGKAMCACG<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly GOPLJFLGDBE PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x1716AF0", Offset = "0x17152F0", VA = "0x181716AF0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, sbyte CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x1716AA0", Offset = "0x17152A0", VA = "0x181716AA0", Slot = "5")]
	public sbyte ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x1716BB0", Offset = "0x17153B0", VA = "0x181716BB0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, sbyte CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x1716B30", Offset = "0x1715330", VA = "0x181716B30", Slot = "7")]
	public sbyte MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public GOPLJFLGDBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class NHBLPMGJJKN : global::HAKOMFHEDCC<sbyte?>, LOIEEHPBJBK, global::PEHGKAMCACG<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly NHBLPMGJJKN PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x18DF4E0", Offset = "0x18DDCE0", VA = "0x1818DF4E0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, sbyte? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x18DF470", Offset = "0x18DDC70", VA = "0x1818DF470", Slot = "5")]
	public sbyte? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x18DF620", Offset = "0x18DDE20", VA = "0x1818DF620", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, sbyte? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x18DF560", Offset = "0x18DDD60", VA = "0x1818DF560", Slot = "7")]
	public sbyte? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public NHBLPMGJJKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class OJCKHGEEHCO : global::HAKOMFHEDCC<sbyte[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly OJCKHGEEHCO PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x18E4B60", Offset = "0x18E3360", VA = "0x1818E4B60", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, sbyte[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x18E4A20", Offset = "0x18E3220", VA = "0x1818E4A20", Slot = "5")]
	public sbyte[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public OJCKHGEEHCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class LDOJALMDLJH : global::HAKOMFHEDCC<short>, LOIEEHPBJBK, global::PEHGKAMCACG<short>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly LDOJALMDLJH PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x171D680", Offset = "0x171BE80", VA = "0x18171D680", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, short CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x171D620", Offset = "0x171BE20", VA = "0x18171D620", Slot = "5")]
	public short ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x171D740", Offset = "0x171BF40", VA = "0x18171D740", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, short CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x171D6C0", Offset = "0x171BEC0", VA = "0x18171D6C0", Slot = "7")]
	public short MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public LDOJALMDLJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class HAMNKGHEMMM : global::HAKOMFHEDCC<short?>, LOIEEHPBJBK, global::PEHGKAMCACG<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly HAMNKGHEMMM PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x1716D80", Offset = "0x1715580", VA = "0x181716D80", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, short? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x1716CD0", Offset = "0x17154D0", VA = "0x181716CD0", Slot = "5")]
	public short? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x1716ED0", Offset = "0x17156D0", VA = "0x181716ED0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, short? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x1716E10", Offset = "0x1715610", VA = "0x181716E10", Slot = "7")]
	public short? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public HAMNKGHEMMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class MFDMNFACDHA : global::HAKOMFHEDCC<short[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly MFDMNFACDHA PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x17215C0", Offset = "0x171FDC0", VA = "0x1817215C0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, short[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x1721390", Offset = "0x171FB90", VA = "0x181721390", Slot = "5")]
	public short[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public MFDMNFACDHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class IEBIDIHPAEN : global::HAKOMFHEDCC<int>, LOIEEHPBJBK, global::PEHGKAMCACG<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly IEBIDIHPAEN PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x171A930", Offset = "0x1719130", VA = "0x18171A930", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, int CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x171A8D0", Offset = "0x17190D0", VA = "0x18171A8D0", Slot = "5")]
	public int ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x171A9E0", Offset = "0x17191E0", VA = "0x18171A9E0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, int CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x171A960", Offset = "0x1719160", VA = "0x18171A960", Slot = "7")]
	public int MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public IEBIDIHPAEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class AFGPHHDJOAL : global::HAKOMFHEDCC<int?>, LOIEEHPBJBK, global::PEHGKAMCACG<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly AFGPHHDJOAL PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x18818C0", Offset = "0x18800C0", VA = "0x1818818C0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, int? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x1881850", Offset = "0x1880050", VA = "0x181881850", Slot = "5")]
	public int? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x1881A20", Offset = "0x1880220", VA = "0x181881A20", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, int? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x1881930", Offset = "0x1880130", VA = "0x181881930", Slot = "7")]
	public int? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public AFGPHHDJOAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class BCAFIGPDGID : global::HAKOMFHEDCC<int[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly BCAFIGPDGID PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x18860F0", Offset = "0x18848F0", VA = "0x1818860F0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, int[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x18847B0", VA = "0x181885FB0", Slot = "5")]
	public int[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BCAFIGPDGID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class MNBGGLJBMHB : global::HAKOMFHEDCC<long>, LOIEEHPBJBK, global::PEHGKAMCACG<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly MNBGGLJBMHB PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x17225D0", Offset = "0x1720DD0", VA = "0x1817225D0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, long CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x17225C0", Offset = "0x1720DC0", VA = "0x1817225C0", Slot = "5")]
	public long ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1722680", Offset = "0x1720E80", VA = "0x181722680", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, long CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1722600", Offset = "0x1720E00", VA = "0x181722600", Slot = "7")]
	public long MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public MNBGGLJBMHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class PJOKCCIKJGB : global::HAKOMFHEDCC<long?>, LOIEEHPBJBK, global::PEHGKAMCACG<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly PJOKCCIKJGB PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x18E6590", Offset = "0x18E4D90", VA = "0x1818E6590", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, long? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x18E6500", Offset = "0x18E4D00", VA = "0x1818E6500", Slot = "5")]
	public long? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x18E66F0", Offset = "0x18E4EF0", VA = "0x1818E66F0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, long? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x18E6610", Offset = "0x18E4E10", VA = "0x1818E6610", Slot = "7")]
	public long? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public PJOKCCIKJGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class EILIPMAIMIA : global::HAKOMFHEDCC<long[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly EILIPMAIMIA PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x18987B0", Offset = "0x1896FB0", VA = "0x1818987B0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, long[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x1898670", Offset = "0x1896E70", VA = "0x181898670", Slot = "5")]
	public long[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public EILIPMAIMIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class JNAHGALBCJL : global::HAKOMFHEDCC<byte>, LOIEEHPBJBK, global::PEHGKAMCACG<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly JNAHGALBCJL PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x171B460", Offset = "0x1719C60", VA = "0x18171B460", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, byte CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x171B400", Offset = "0x1719C00", VA = "0x18171B400", Slot = "5")]
	public byte ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x171B520", Offset = "0x1719D20", VA = "0x18171B520", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, byte CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x171B4A0", Offset = "0x1719CA0", VA = "0x18171B4A0", Slot = "7")]
	public byte MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public JNAHGALBCJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class CPBEAPOHNCO : global::HAKOMFHEDCC<byte?>, LOIEEHPBJBK, global::PEHGKAMCACG<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly CPBEAPOHNCO PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x188B750", Offset = "0x1889F50", VA = "0x18188B750", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, byte? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x188B6E0", Offset = "0x1889EE0", VA = "0x18188B6E0", Slot = "5")]
	public byte? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x188B8D0", Offset = "0x188A0D0", VA = "0x18188B8D0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, byte? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x188B7D0", Offset = "0x1889FD0", VA = "0x18188B7D0", Slot = "7")]
	public byte? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public CPBEAPOHNCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class LKFLCLKJMHN : global::HAKOMFHEDCC<ushort>, LOIEEHPBJBK, global::PEHGKAMCACG<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly LKFLCLKJMHN PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x171FC10", Offset = "0x171E410", VA = "0x18171FC10", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ushort CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x171FBB0", Offset = "0x171E3B0", VA = "0x18171FBB0", Slot = "5")]
	public ushort ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x171FCD0", Offset = "0x171E4D0", VA = "0x18171FCD0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, ushort CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x171FC50", Offset = "0x171E450", VA = "0x18171FC50", Slot = "7")]
	public ushort MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public LKFLCLKJMHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class KBNNOCJFOOI : global::HAKOMFHEDCC<ushort?>, LOIEEHPBJBK, global::PEHGKAMCACG<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly KBNNOCJFOOI PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x171B6F0", Offset = "0x1719EF0", VA = "0x18171B6F0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ushort? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x171B640", Offset = "0x1719E40", VA = "0x18171B640", Slot = "5")]
	public ushort? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x171B840", Offset = "0x171A040", VA = "0x18171B840", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, ushort? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x171B780", Offset = "0x1719F80", VA = "0x18171B780", Slot = "7")]
	public ushort? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public KBNNOCJFOOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class PEHGGOFBKFD : global::HAKOMFHEDCC<ushort[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly PEHGGOFBKFD PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x18E5BB0", Offset = "0x18E43B0", VA = "0x1818E5BB0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ushort[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x18E5A70", Offset = "0x18E4270", VA = "0x1818E5A70", Slot = "5")]
	public ushort[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public PEHGGOFBKFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class DPCFGINGCFF : global::HAKOMFHEDCC<uint>, LOIEEHPBJBK, global::PEHGKAMCACG<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly DPCFGINGCFF PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x1898340", Offset = "0x1896B40", VA = "0x181898340", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, uint CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x1898330", Offset = "0x1896B30", VA = "0x181898330", Slot = "5")]
	public uint ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x1898400", Offset = "0x1896C00", VA = "0x181898400", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, uint CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x1898350", Offset = "0x1896B50", VA = "0x181898350", Slot = "7")]
	public uint MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public DPCFGINGCFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class PIFMFBPFEKF : global::HAKOMFHEDCC<uint?>, LOIEEHPBJBK, global::PEHGKAMCACG<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly PIFMFBPFEKF PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x18E60A0", Offset = "0x18E48A0", VA = "0x1818E60A0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, uint? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x18E6030", Offset = "0x18E4830", VA = "0x1818E6030", Slot = "5")]
	public uint? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x18E61D0", Offset = "0x18E49D0", VA = "0x1818E61D0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, uint? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x18E6110", Offset = "0x18E4910", VA = "0x1818E6110", Slot = "7")]
	public uint? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public PIFMFBPFEKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class MKIPEFIKPDM : global::HAKOMFHEDCC<uint[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly MKIPEFIKPDM PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x17223C0", Offset = "0x1720BC0", VA = "0x1817223C0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, uint[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1722190", Offset = "0x1720990", VA = "0x181722190", Slot = "5")]
	public uint[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public MKIPEFIKPDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class HCOPHKFFJAB : global::HAKOMFHEDCC<ulong>, LOIEEHPBJBK, global::PEHGKAMCACG<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly HCOPHKFFJAB PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1718CB0", Offset = "0x17174B0", VA = "0x181718CB0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ulong CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x1718CA0", Offset = "0x17174A0", VA = "0x181718CA0", Slot = "5")]
	public ulong ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x1718D60", Offset = "0x1717560", VA = "0x181718D60", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, ulong CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1718CE0", Offset = "0x17174E0", VA = "0x181718CE0", Slot = "7")]
	public ulong MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public HCOPHKFFJAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class GBIEBECHGJF : global::HAKOMFHEDCC<ulong?>, LOIEEHPBJBK, global::PEHGKAMCACG<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly GBIEBECHGJF PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x170DFE0", Offset = "0x170C7E0", VA = "0x18170DFE0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ulong? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x170DF50", Offset = "0x170C750", VA = "0x18170DF50", Slot = "5")]
	public ulong? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x170E150", Offset = "0x170C950", VA = "0x18170E150", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, ulong? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x170E070", Offset = "0x170C870", VA = "0x18170E070", Slot = "7")]
	public ulong? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public GBIEBECHGJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class MOJNNPCBGDC : global::HAKOMFHEDCC<ulong[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly MOJNNPCBGDC PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x17229D0", Offset = "0x17211D0", VA = "0x1817229D0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ulong[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x17227A0", Offset = "0x1720FA0", VA = "0x1817227A0", Slot = "5")]
	public ulong[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public MOJNNPCBGDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class CCGBLNNOIAC : global::HAKOMFHEDCC<float>, LOIEEHPBJBK, global::PEHGKAMCACG<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly CCGBLNNOIAC PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x1887920", Offset = "0x1886120", VA = "0x181887920", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, float CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x1887910", Offset = "0x1886110", VA = "0x181887910", Slot = "5")]
	public float ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x18879E0", Offset = "0x18861E0", VA = "0x1818879E0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, float CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x1887930", Offset = "0x1886130", VA = "0x181887930", Slot = "7")]
	public float MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public CCGBLNNOIAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class CCBCKEFNOAG : global::HAKOMFHEDCC<float?>, LOIEEHPBJBK, global::PEHGKAMCACG<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly CCBCKEFNOAG PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x18876C0", Offset = "0x1885EC0", VA = "0x1818876C0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, float? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x1887650", Offset = "0x1885E50", VA = "0x181887650", Slot = "5")]
	public float? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1887830", Offset = "0x1886030", VA = "0x181887830", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, float? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1887740", Offset = "0x1885F40", VA = "0x181887740", Slot = "7")]
	public float? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public CCBCKEFNOAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class CKFKFHBGDPO : global::HAKOMFHEDCC<float[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly CKFKFHBGDPO PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x1889FF0", Offset = "0x18887F0", VA = "0x181889FF0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, float[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1889EB0", Offset = "0x18886B0", VA = "0x181889EB0", Slot = "5")]
	public float[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public CKFKFHBGDPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class GFIHEOPJILJ : global::HAKOMFHEDCC<double>, LOIEEHPBJBK, global::PEHGKAMCACG<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly GFIHEOPJILJ PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x170E2D0", Offset = "0x170CAD0", VA = "0x18170E2D0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, double CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x170E2C0", Offset = "0x170CAC0", VA = "0x18170E2C0", Slot = "5")]
	public double ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x170E360", Offset = "0x170CB60", VA = "0x18170E360", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, double CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x170E2E0", Offset = "0x170CAE0", VA = "0x18170E2E0", Slot = "7")]
	public double MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public GFIHEOPJILJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class LFHKEOHCMHC : global::HAKOMFHEDCC<double?>, LOIEEHPBJBK, global::PEHGKAMCACG<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly LFHKEOHCMHC PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x171E1F0", Offset = "0x171C9F0", VA = "0x18171E1F0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, double? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x171E160", Offset = "0x171C960", VA = "0x18171E160", Slot = "5")]
	public double? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x171E350", Offset = "0x171CB50", VA = "0x18171E350", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, double? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x171E270", Offset = "0x171CA70", VA = "0x18171E270", Slot = "7")]
	public double? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public LFHKEOHCMHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class CPBMBHHNHAO : global::HAKOMFHEDCC<double[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly CPBMBHHNHAO PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x188BAF0", Offset = "0x188A2F0", VA = "0x18188BAF0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, double[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x188B9B0", Offset = "0x188A1B0", VA = "0x18188B9B0", Slot = "5")]
	public double[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public CPBMBHHNHAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class AHCGJCBHFGC : global::HAKOMFHEDCC<bool>, LOIEEHPBJBK, global::PEHGKAMCACG<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly AHCGJCBHFGC PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x1881FE0", Offset = "0x18807E0", VA = "0x181881FE0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, bool CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x1881FD0", Offset = "0x18807D0", VA = "0x181881FD0", Slot = "5")]
	public bool ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x1882080", Offset = "0x1880880", VA = "0x181882080", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, bool CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x1882000", Offset = "0x1880800", VA = "0x181882000", Slot = "7")]
	public bool MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public AHCGJCBHFGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class COFHJILLEEB : global::HAKOMFHEDCC<bool?>, LOIEEHPBJBK, global::PEHGKAMCACG<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly COFHJILLEEB PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x188B4C0", Offset = "0x1889CC0", VA = "0x18188B4C0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, bool? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x188B450", Offset = "0x1889C50", VA = "0x18188B450", Slot = "5")]
	public bool? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x188B600", Offset = "0x1889E00", VA = "0x18188B600", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, bool? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x188B540", Offset = "0x1889D40", VA = "0x18188B540", Slot = "7")]
	public bool? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public COFHJILLEEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class MKABKCNOAFJ : global::HAKOMFHEDCC<bool[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly MKABKCNOAFJ PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x1721FB0", Offset = "0x17207B0", VA = "0x181721FB0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, bool[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x1721D80", Offset = "0x1720580", VA = "0x181721D80", Slot = "5")]
	public bool[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public MKABKCNOAFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class OIKCLIJLLOC : global::HAKOMFHEDCC<object>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::HAKOMFHEDCC<object> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly Dictionary<Type, int> LHIIFJHHMNP;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x18E3BB0", Offset = "0x18E23B0", VA = "0x1818E3BB0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, object CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x18E3880", Offset = "0x18E2080", VA = "0x1818E3880", Slot = "5")]
	public object ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public OIKCLIJLLOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class EBPACFDNKHC : global::HAKOMFHEDCC<byte[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::HAKOMFHEDCC<byte[]> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x1898520", Offset = "0x1896D20", VA = "0x181898520", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, byte[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x18984A0", Offset = "0x1896CA0", VA = "0x1818984A0", Slot = "5")]
	public byte[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public EBPACFDNKHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class GLKIAHNNLBP : global::HAKOMFHEDCC<ArraySegment<byte>>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::HAKOMFHEDCC<ArraySegment<byte>> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x170F490", Offset = "0x170DC90", VA = "0x18170F490", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ArraySegment<byte> CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x170F3B0", Offset = "0x170DBB0", VA = "0x18170F3B0", Slot = "5")]
	public ArraySegment<byte> ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public GLKIAHNNLBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class BALNGJCGFPA : global::HAKOMFHEDCC<string>, LOIEEHPBJBK, global::PEHGKAMCACG<string>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::HAKOMFHEDCC<string> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x1885F30", Offset = "0x1884730", VA = "0x181885F30", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, string CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x1885F20", Offset = "0x1884720", VA = "0x181885F20", Slot = "5")]
	public string ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x1885F30", Offset = "0x1884730", VA = "0x181885F30", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, string CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x1885F20", Offset = "0x1884720", VA = "0x181885F20", Slot = "7")]
	public string MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BALNGJCGFPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class CMFJPGAJJKI : global::HAKOMFHEDCC<string[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly CMFJPGAJJKI PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x188A6B0", Offset = "0x1888EB0", VA = "0x18188A6B0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, string[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x188A540", Offset = "0x1888D40", VA = "0x18188A540", Slot = "5")]
	public string[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public CMFJPGAJJKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class AKFLKINCLFL : global::HAKOMFHEDCC<char>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly AKFLKINCLFL PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x18821C0", Offset = "0x18809C0", VA = "0x1818821C0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, char CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x1882190", Offset = "0x1880990", VA = "0x181882190", Slot = "5")]
	public char ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public AKFLKINCLFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class JBIPJIKNAOM : global::HAKOMFHEDCC<char?>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly JBIPJIKNAOM PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x171B100", Offset = "0x1719900", VA = "0x18171B100", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, char? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x171B030", Offset = "0x1719830", VA = "0x18171B030", Slot = "5")]
	public char? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public JBIPJIKNAOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class DMMNAHAEDKO : global::HAKOMFHEDCC<char[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly DMMNAHAEDKO PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x1897540", Offset = "0x1895D40", VA = "0x181897540", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, char[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x18973A0", Offset = "0x1895BA0", VA = "0x1818973A0", Slot = "5")]
	public char[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public DMMNAHAEDKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class PIOKJLHBKAP : global::HAKOMFHEDCC<Guid>, LOIEEHPBJBK, global::PEHGKAMCACG<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::HAKOMFHEDCC<Guid> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x18E6300", Offset = "0x18E4B00", VA = "0x1818E6300", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Guid CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x18E62B0", Offset = "0x18E4AB0", VA = "0x1818E62B0", Slot = "5")]
	public Guid ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x18E63D0", Offset = "0x18E4BD0", VA = "0x1818E63D0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, Guid CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x18E62B0", Offset = "0x18E4AB0", VA = "0x1818E62B0", Slot = "7")]
	public Guid MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public PIOKJLHBKAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class HLGNHPFLPLN : global::HAKOMFHEDCC<decimal>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::HAKOMFHEDCC<decimal> PJLEDACBOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly bool KMPKBAFLHGA;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0xF74920", Offset = "0xF73120", VA = "0x180F74920")]
	public HLGNHPFLPLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0xBBE610", Offset = "0xBBCE10", VA = "0x180BBE610")]
	public HLGNHPFLPLN(bool KMPKBAFLHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x171A610", Offset = "0x1718E10", VA = "0x18171A610", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, decimal CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x171A3E0", Offset = "0x1718BE0", VA = "0x18171A3E0", Slot = "5")]
	public decimal ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class PKDAMLCIJAM : global::HAKOMFHEDCC<Uri>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly global::HAKOMFHEDCC<Uri> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x18E6860", Offset = "0x18E5060", VA = "0x1818E6860", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Uri CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x18E67E0", Offset = "0x18E4FE0", VA = "0x1818E67E0", Slot = "5")]
	public Uri ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public PKDAMLCIJAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class PGAICMBLBCN : global::HAKOMFHEDCC<Version>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly global::HAKOMFHEDCC<Version> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x18E5D50", Offset = "0x18E4550", VA = "0x1818E5D50", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Version CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x18E5CD0", Offset = "0x18E44D0", VA = "0x1818E5CD0", Slot = "5")]
	public Version ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public PGAICMBLBCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class GIOABHNAKEN<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class BOEPLDLDFIG : global::HAKOMFHEDCC<StringBuilder>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly global::HAKOMFHEDCC<StringBuilder> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x18875A0", Offset = "0x1885DA0", VA = "0x1818875A0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, StringBuilder CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x1887520", Offset = "0x1885D20", VA = "0x181887520", Slot = "5")]
	public StringBuilder ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BOEPLDLDFIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class HFBMLEFCPAB : global::HAKOMFHEDCC<BitArray>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly global::HAKOMFHEDCC<BitArray> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x1719120", Offset = "0x1717920", VA = "0x181719120", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, BitArray CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1718F20", Offset = "0x1717720", VA = "0x181718F20", Slot = "5")]
	public BitArray ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public HFBMLEFCPAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class ADEMNALPONN : global::HAKOMFHEDCC<Type>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly ADEMNALPONN PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly Regex DBHNIPOABDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool JBPNJNEJEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private bool DLHLCBKPBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private bool GLKKAIBOEMB;

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x18817E0", Offset = "0x187FFE0", VA = "0x1818817E0")]
	public ADEMNALPONN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x1881800", Offset = "0x1880000", VA = "0x181881800")]
	public ADEMNALPONN(bool JBPNJNEJEJN, bool DLHLCBKPBKO, bool GLKKAIBOEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x1881630", Offset = "0x187FE30", VA = "0x181881630", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Type CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x1881500", Offset = "0x187FD00", VA = "0x181881500", Slot = "5")]
	public Type ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
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
