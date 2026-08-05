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
public class MFCHKNGGDAN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x521480", Offset = "0x51FC80", VA = "0x180521480")]
	public MFCHKNGGDAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class DFMEDADEJNM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x521480", Offset = "0x51FC80", VA = "0x180521480")]
	public DFMEDADEJNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class JPHAIJKNNLG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x521480", Offset = "0x51FC80", VA = "0x180521480")]
	public JPHAIJKNNLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class LNBENCAGNHH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x521480", Offset = "0x51FC80", VA = "0x180521480")]
	public LNBENCAGNHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class IECNMIMKMCH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5160", Offset = "0x2FE3960", VA = "0x182FE5160")]
	public static bool ADIAPENCOPD(this TypeInfo MIDEMNGPEAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class DOPNKFFBILI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type KAFHAMGGFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x521490", Offset = "0x51FC90", VA = "0x180521490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] AIFAGPKMPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x662790", Offset = "0x660F90", VA = "0x180662790")]
	public DOPNKFFBILI(Type PAMOPPADIAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class OHKKCODOCFN : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void PDHKNHNFMAB<T>(ref FGEHJBFCCPO MNFKPJJAJNI, T DOBKOKNNFGA, INLBFPHKJMK FOFIKLEPNFM);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T MGJLFCCDBAO<T>(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK FOFIKLEPNFM);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GEHOIAKHNGG
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IEMBFIJKPHO<T> : GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, T DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ECBIDLALAJO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, T DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum HIMOMLGKNJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MKCANJCJEIB
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x262D860", Offset = "0x262C060", VA = "0x18262D860")]
	public static global::IEMBFIJKPHO<T> ENBIKLJGOLE<T>(this INLBFPHKJMK FOFIKLEPNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x41F6A50", Offset = "0x41F5250", VA = "0x1841F6A50")]
	public static object LKFMHFIIDOB(this INLBFPHKJMK FOFIKLEPNFM, Type MIDEMNGPEAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FGMOPNAOGEB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x32BBB90", Offset = "0x32BA390", VA = "0x1832BBB90")]
	public FGMOPNAOGEB(string AGOJMOHICBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FJJCAGOJJPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class HAKJMLIOBJH
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] FFBNFFLLBIL;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] BFMBCIJODCM;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x32BF8C0", Offset = "0x32BE0C0", VA = "0x1832BF8C0")]
		public static byte[] MKHAIGEADOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x32BF830", Offset = "0x32BE030", VA = "0x1832BF830")]
		public static char[] CNGPDBCIPFC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> HFLGMLLFPEC;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] HCOGCAADJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] MIIBCOAJABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int POHBEAAADEA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool PMGLGJIAHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x32BDA60", Offset = "0x32BC260", VA = "0x1832BDA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32BEA70", Offset = "0x32BD270", VA = "0x1832BEA70")]
	public FJJCAGOJJPJ(byte[] MIIBCOAJABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x32BE890", Offset = "0x32BD090", VA = "0x1832BE890")]
	public FJJCAGOJJPJ(byte[] MIIBCOAJABM, int POHBEAAADEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x32BDE90", Offset = "0x32BC690", VA = "0x1832BDE90")]
	private PDIKKIAPJHA NEINHHOKDHN(string LLHIHLPFGIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x32BC7B0", Offset = "0x32BAFB0", VA = "0x1832BC7B0")]
	private PDIKKIAPJHA EAMBAPKJKHO(string AGOJMOHICBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32BB020", Offset = "0x32B9820", VA = "0x1832BB020")]
	public void CAPEOGOKOOD(int POHBEAAADEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x755FD0", Offset = "0x7547D0", VA = "0x180755FD0")]
	public byte[] NKMDGBFHENO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C62E0", Offset = "0x7C4AE0", VA = "0x1807C62E0")]
	public int DAILAPNGLFG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x32BE480", Offset = "0x32BCC80", VA = "0x1832BE480")]
	public DPGDPPNGKPH OBOCECNIOND()
	{
		return default(DPGDPPNGKPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x32BC190", Offset = "0x32BA990", VA = "0x1832BC190")]
	public void BDJIGBONDFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x32BD370", Offset = "0x32BBB70", VA = "0x1832BD370")]
	public bool GMOFEOKJCGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x32BD810", Offset = "0x32BC010", VA = "0x1832BD810")]
	public bool IPJPNPGBEBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x32BD950", Offset = "0x32BC150", VA = "0x1832BD950")]
	public void KDAFKCCFBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x32BC2E0", Offset = "0x32BAAE0", VA = "0x1832BC2E0")]
	public bool BOKEDJGGHMK(ref int KALABHLPPAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x32BD9F0", Offset = "0x32BC1F0", VA = "0x1832BD9F0")]
	public bool KILAJFBAGHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x32BDDF0", Offset = "0x32BC5F0", VA = "0x1832BDDF0")]
	public void MMEELNKDAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x32BD700", Offset = "0x32BBF00", VA = "0x1832BD700")]
	public bool HFNJKJBLJGJ(ref int KALABHLPPAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x32BC890", Offset = "0x32BB090", VA = "0x1832BC890")]
	public bool EFHDBPBCMJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x32BE380", Offset = "0x32BCB80", VA = "0x1832BE380")]
	public void NHCBGBOPLMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x32BD1D0", Offset = "0x32BB9D0", VA = "0x1832BD1D0")]
	public bool FIOILIDNBLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x32BE670", Offset = "0x32BCE70", VA = "0x1832BE670")]
	public void PAOJCMONPIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x32BC900", Offset = "0x32BB100", VA = "0x1832BC900")]
	private void EODCKDOPMMA(out byte[] MPJLHLDEKDA, out int EEMKLAMGPFA, out int JKJEGDOMHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x32BC700", Offset = "0x32BAF00", VA = "0x1832BC700")]
	private static int DOOPGEBPMDO(char DIDMABCLHLL, char DOMNMKJGGGI, char BBFAELNBDJP, char ECFJBHHGOJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x32BC3D0", Offset = "0x32BABD0", VA = "0x1832BC3D0")]
	private static int CHOKOEINGED(char DNCFOPMJGLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x32BD610", Offset = "0x32BBE10", VA = "0x1832BD610")]
	public ArraySegment<byte> HDIIONIDPML()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x32BD8B0", Offset = "0x32BC0B0", VA = "0x1832BD8B0")]
	public string KCBGMJGKIAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x32BD880", Offset = "0x32BC080", VA = "0x1832BD880")]
	public string JFNCBFILBAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x32BDB50", Offset = "0x32BC350", VA = "0x1832BDB50")]
	public ArraySegment<byte> MELKIIFIOOA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x32BE770", Offset = "0x32BCF70", VA = "0x1832BE770")]
	public ArraySegment<byte> PLMMJMPHJFC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x32BC4A0", Offset = "0x32BACA0", VA = "0x1832BC4A0")]
	public bool CKNKOGCPDBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x32BD090", Offset = "0x32BB890", VA = "0x1832BD090")]
	private static bool FFJBNKGOAKA(byte BBFAELNBDJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x32BBF60", Offset = "0x32BA760", VA = "0x1832BBF60")]
	private void ALEFNEJODMN(DPGDPPNGKPH OIFAEHGKHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x32BC2D0", Offset = "0x32BAAD0", VA = "0x1832BC2D0")]
	public void BHIBPJIEDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x32BDA80", Offset = "0x32BC280", VA = "0x1832BDA80")]
	private void LKOFKFGHBCP(int JINGHNINMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x32BE330", Offset = "0x32BCB30", VA = "0x1832BE330")]
	public sbyte NGKLOGIAAAA()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x32BC130", Offset = "0x32BA930", VA = "0x1832BC130")]
	public short BBNJPMPANNJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x32BE710", Offset = "0x32BCF10", VA = "0x1832BE710")]
	public int PIDCPHCFBMM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x32BD790", Offset = "0x32BBF90", VA = "0x1832BD790")]
	public long ICJFPEKEFAM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x32BE420", Offset = "0x32BCC20", VA = "0x1832BE420")]
	public byte NKBPKKOGNIJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x32BE610", Offset = "0x32BCE10", VA = "0x1832BE610")]
	public ushort OJPKKEIMHJB()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x32BC370", Offset = "0x32BAB70", VA = "0x1832BC370")]
	public uint CEKHNEEHCBG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x32BD150", Offset = "0x32BB950", VA = "0x1832BD150")]
	public ulong FIJMPFCHNHK()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x32BBE20", Offset = "0x32BA620", VA = "0x1832BBE20")]
	public float AIBPCMDAJJN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x32BD240", Offset = "0x32BBA40", VA = "0x1832BD240")]
	public double FJMACINGFNL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x32BDD00", Offset = "0x32BC500", VA = "0x1832BDD00")]
	public ArraySegment<byte> MKEKELKHGIN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x32BD490", Offset = "0x32BBC90", VA = "0x1832BD490")]
	private static int GNJMLKCNGFL(byte[] MIIBCOAJABM, int POHBEAAADEA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PDIKKIAPJHA : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference DEBDHMOBLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int GDIFNEHIJHH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int AGHFBDGFMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x11E4160", Offset = "0x11E2960", VA = "0x1811E4160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string LBOKLNFKIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5BBE10", Offset = "0x5BA610", VA = "0x1805BBE10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x41FF080", Offset = "0x41FD880", VA = "0x1841FF080")]
	public PDIKKIAPJHA(string AGOJMOHICBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x41FF0F0", Offset = "0x41FD8F0", VA = "0x1841FF0F0")]
	public PDIKKIAPJHA(string AGOJMOHICBG, byte[] IGCAMOGMCLD, int POHBEAAADEA, int GDIFNEHIJHH, string MFONMDPFLBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NKDODOHJFEP
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class LBABPNIEGPP
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void MKDLHDLNEBN(ref FGEHJBFCCPO MNFKPJJAJNI, object DOBKOKNNFGA, INLBFPHKJMK FOFIKLEPNFM);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object FPNGBDLOENG(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK FOFIKLEPNFM);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class KMEIHDAEAMO
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class ELLAIMHLKFI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
				public ELLAIMHLKFI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x41F0810", Offset = "0x41EF010", VA = "0x1841F0810")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x41F0850", Offset = "0x41EF050", VA = "0x1841F0850")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, INLBFPHKJMK, byte[]> LFFPCODDMCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, INLBFPHKJMK> AONFDFBILBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly MKDLHDLNEBN PDNIHGLDBJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, INLBFPHKJMK, ArraySegment<byte>> PHEDCLCDOAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, INLBFPHKJMK, string> GEKADHNKPBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, INLBFPHKJMK, object> EDCIEJDJGJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, INLBFPHKJMK, object> ONOGEPIAPGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, INLBFPHKJMK, object> DLBFOEDLKAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly FPNGBDLOENG MEECEFDNDEM;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x41F1760", Offset = "0x41EFF60", VA = "0x1841F1760")]
			public KMEIHDAEAMO(Type MIDEMNGPEAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1CA44D0", Offset = "0x1CA2CD0", VA = "0x181CA44D0")]
			private static T DCHGBPCLJOM<T>(DynamicMethod IFBJOBONJEM)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x41F1570", Offset = "0x41EFD70", VA = "0x1841F1570")]
			private static MethodInfo DDHCFJLEKIB(Type MIDEMNGPEAG, string CBFODBDAPIM, Type[] PBEGNEIIKLJ)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, KMEIHDAEAMO> HLHBHINPDGB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::PDFHKEIKHOP<KMEIHDAEAMO> AOKILPAMAGH;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x41F3C60", Offset = "0x41F2460", VA = "0x1841F3C60")]
		static LBABPNIEGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x41F3BE0", Offset = "0x41F23E0", VA = "0x1841F3BE0")]
		private static KMEIHDAEAMO OOAAAAACIMH(Type MIDEMNGPEAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x41F3960", Offset = "0x41F2160", VA = "0x1841F3960")]
		public static void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, object DOBKOKNNFGA, INLBFPHKJMK FOFIKLEPNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x41F3AD0", Offset = "0x41F22D0", VA = "0x1841F3AD0")]
		public static void FAKLEMDHHIN(Type MIDEMNGPEAG, ref FGEHJBFCCPO MNFKPJJAJNI, object DOBKOKNNFGA, INLBFPHKJMK FOFIKLEPNFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class PDMAKMCABLO
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] FFBNFFLLBIL;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x41FF1C0", Offset = "0x41FD9C0", VA = "0x1841FF1C0")]
		public static byte[] MKHAIGEADOO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static INLBFPHKJMK NHKGJIFBPNC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] PFPBDBOPKBJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] PGAHOPPCGDN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static INLBFPHKJMK OMLFFKBAMHK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x41F9D20", Offset = "0x41F8520", VA = "0x1841F9D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x41F9CC0", Offset = "0x41F84C0", VA = "0x1841F9CC0")]
	public static void APHNEANCCOD(INLBFPHKJMK FOFIKLEPNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x29266C0", Offset = "0x2924EC0", VA = "0x1829266C0")]
	public static string GJAHOGFGKAE<T>(T DOBKOKNNFGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2926740", Offset = "0x2924F40", VA = "0x182926740")]
	public static string GJAHOGFGKAE<T>(T DOBKOKNNFGA, INLBFPHKJMK FOFIKLEPNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1CA9570", Offset = "0x1CA7D70", VA = "0x181CA9570")]
	public static T FNNNELOCNNN<T>(string BMPADHHJPCJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1CA97C0", Offset = "0x1CA7FC0", VA = "0x181CA97C0")]
	public static T FNNNELOCNNN<T>(string BMPADHHJPCJ, INLBFPHKJMK FOFIKLEPNFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1CA95F0", Offset = "0x1CA7DF0", VA = "0x181CA95F0")]
	public static T FNNNELOCNNN<T>(byte[] MIIBCOAJABM, INLBFPHKJMK FOFIKLEPNFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1CA9670", Offset = "0x1CA7E70", VA = "0x181CA9670")]
	public static T FNNNELOCNNN<T>(byte[] MIIBCOAJABM, int POHBEAAADEA, INLBFPHKJMK FOFIKLEPNFM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum DPGDPPNGKPH : byte
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
public struct FGEHJBFCCPO
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] NDAOPKBFIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] FFBNFFLLBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int POHBEAAADEA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int CEKPOEFDOLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7C62E0", Offset = "0x7C4AE0", VA = "0x1807C62E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x32BB020", Offset = "0x32B9820", VA = "0x1832BB020")]
	public void CAPEOGOKOOD(int POHBEAAADEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x32BB100", Offset = "0x32B9900", VA = "0x1832BB100")]
	public static byte[] DMFCOKFHFGP(string KDAJLIBLBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x32BA8E0", Offset = "0x32B90E0", VA = "0x1832BA8E0")]
	public static byte[] AFEFMHGBMDG(string KDAJLIBLBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x32BAEC0", Offset = "0x32B96C0", VA = "0x1832BAEC0")]
	public static byte[] BJOICDINAMB(string KDAJLIBLBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x32BB820", Offset = "0x32BA020", VA = "0x1832BB820")]
	public static byte[] MNCPNPBMLCA(string KDAJLIBLBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xCC2A50", Offset = "0xCC1250", VA = "0x180CC2A50")]
	public FGEHJBFCCPO(byte[] IKFLOGENOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x32BB730", Offset = "0x32B9F30", VA = "0x1832BB730")]
	public ArraySegment<byte> MKHAIGEADOO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x32BAE40", Offset = "0x32B9640", VA = "0x1832BAE40")]
	public byte[] BBENIEBJDEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x32BBAE0", Offset = "0x32BA2E0", VA = "0x1832BBAE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x32BB6F0", Offset = "0x32B9EF0", VA = "0x1832BB6F0")]
	public void MDKOBEAOKGA(int GGHGLBALCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x32BBA80", Offset = "0x32BA280", VA = "0x1832BBA80")]
	public void PKOILKCFOAH(byte[] JONOMCBOHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x32BB7E0", Offset = "0x32B9FE0", VA = "0x1832BB7E0")]
	public void MMDNIDGHKFD(byte JONOMCBOHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x32BB2E0", Offset = "0x32B9AE0", VA = "0x1832BB2E0")]
	public void FDFHLPOHJHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x32BB6A0", Offset = "0x32B9EA0", VA = "0x1832BB6A0")]
	public void LMEGADBELEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x32BB5D0", Offset = "0x32B9DD0", VA = "0x1832BB5D0")]
	public void JEECANNKEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x32BB980", Offset = "0x32BA180", VA = "0x1832BB980")]
	public void NEHKHIKNGHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x32BB360", Offset = "0x32B9B60", VA = "0x1832BB360")]
	public void GJANHPAIIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x32BB650", Offset = "0x32B9E50", VA = "0x1832BB650")]
	public void KKPHPOPHMEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x32BADE0", Offset = "0x32B95E0", VA = "0x1832BADE0")]
	public void ALGFOKMJLBO(string KDAJLIBLBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x32BB030", Offset = "0x32B9830", VA = "0x1832BB030")]
	public void CCCPIEJDBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x32BB210", Offset = "0x32B9A10", VA = "0x1832BB210")]
	public void FAEIPLDEFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x32BB3E0", Offset = "0x32B9BE0", VA = "0x1832BB3E0")]
	public void INDHJCBDEEM(bool DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x32BB080", Offset = "0x32B9880", VA = "0x1832BB080")]
	public void CMPGFNKPHPM(float DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x32BB9D0", Offset = "0x32BA1D0", VA = "0x1832BB9D0")]
	public void PBFJGDFGOCL(double DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x32BB330", Offset = "0x32B9B30", VA = "0x1832BB330")]
	public void GHAJPMFNGJA(byte DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x32BB620", Offset = "0x32B9E20", VA = "0x1832BB620")]
	public void JLNKHIMAEOE(ushort DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x32BA8B0", Offset = "0x32B90B0", VA = "0x1832BA8B0")]
	public void AFCMBODAMAJ(uint DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x32BB3B0", Offset = "0x32B9BB0", VA = "0x1832BB3B0")]
	public void IFNCNPEAAJH(ulong DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x32BB1E0", Offset = "0x32B99E0", VA = "0x1832BB1E0")]
	public void ENFLJJCNODJ(sbyte DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x32BB700", Offset = "0x32B9F00", VA = "0x1832BB700")]
	public void MDPHADGCDCO(short DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x32BBA50", Offset = "0x32BA250", VA = "0x1832BBA50")]
	public void PHDJMNELPKD(int DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x32BAFF0", Offset = "0x32B97F0", VA = "0x1832BAFF0")]
	public void BPPDDJDMINP(long DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x32BAA10", Offset = "0x32B9210", VA = "0x1832BAA10")]
	public void AIGJBMOEFDI(string DOBKOKNNFGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GIAHIOMLLKP : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class MJGFAANKPOG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2127800", Offset = "0x2126000", VA = "0x182127800")]
		static MJGFAANKPOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private GIAHIOMLLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class AOAFKPGAFFD
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> EJJEEMNAKIF;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x32ABB80", Offset = "0x32AA380", VA = "0x1832ABB80")]
	static AOAFKPGAFFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x32AB620", Offset = "0x32A9E20", VA = "0x1832AB620")]
	internal static object FBNBEGPJOEK(Type PKNCKFNLBFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class IJOBEOIOAMK : global::IEMBFIJKPHO<Vector2>, GEHOIAKHNGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CKJHLECLPKO JLFGBCDCKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] EIGHINJHJAP;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5790", Offset = "0x2FE3F90", VA = "0x182FE5790")]
	public IJOBEOIOAMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5560", Offset = "0x2FE3D60", VA = "0x182FE5560", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, Vector2 DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5610", Offset = "0x2FE3E10", VA = "0x182FE5610", Slot = "5")]
	public Vector2 FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class DIJAMBLGPNP : global::IEMBFIJKPHO<Vector3>, GEHOIAKHNGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CKJHLECLPKO JLFGBCDCKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] EIGHINJHJAP;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x32B3D90", Offset = "0x32B2590", VA = "0x1832B3D90")]
	public DIJAMBLGPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x32B3830", Offset = "0x32B2030", VA = "0x1832B3830", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, Vector3 DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x32B3A40", Offset = "0x32B2240", VA = "0x1832B3A40", Slot = "5")]
	public Vector3 FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class KEDKMLFNFCN : global::IEMBFIJKPHO<Vector4>, GEHOIAKHNGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CKJHLECLPKO JLFGBCDCKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] EIGHINJHJAP;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2FF16B0", Offset = "0x2FEFEB0", VA = "0x182FF16B0")]
	public KEDKMLFNFCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1330", Offset = "0x2FEFB30", VA = "0x182FF1330", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, Vector4 DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1480", Offset = "0x2FEFC80", VA = "0x182FF1480", Slot = "5")]
	public Vector4 FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class KFJMHAKHGHJ : global::IEMBFIJKPHO<Quaternion>, GEHOIAKHNGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CKJHLECLPKO JLFGBCDCKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] EIGHINJHJAP;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1F50", Offset = "0x2FF0750", VA = "0x182FF1F50")]
	public KFJMHAKHGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1330", Offset = "0x2FEFB30", VA = "0x182FF1330", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, Quaternion DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1D20", Offset = "0x2FF0520", VA = "0x182FF1D20", Slot = "5")]
	public Quaternion FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class KOCJBKNLKCD : global::IEMBFIJKPHO<Color>, GEHOIAKHNGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly CKJHLECLPKO JLFGBCDCKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] EIGHINJHJAP;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2FF31C0", Offset = "0x2FF19C0", VA = "0x182FF31C0")]
	public KOCJBKNLKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1330", Offset = "0x2FEFB30", VA = "0x182FF1330", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, Color DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2FF2F90", Offset = "0x2FF1790", VA = "0x182FF2F90", Slot = "5")]
	public Color FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class PEDCHPAHLNA : global::IEMBFIJKPHO<Bounds>, GEHOIAKHNGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly CKJHLECLPKO JLFGBCDCKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] EIGHINJHJAP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x41FF750", Offset = "0x41FDF50", VA = "0x1841FF750")]
	public PEDCHPAHLNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x41FF240", Offset = "0x41FDA40", VA = "0x1841FF240", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, Bounds DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x41FF4B0", Offset = "0x41FDCB0", VA = "0x1841FF4B0", Slot = "5")]
	public Bounds FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class DPNJNGGMIBE : global::IEMBFIJKPHO<Rect>, GEHOIAKHNGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly CKJHLECLPKO JLFGBCDCKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] EIGHINJHJAP;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x32B6D60", Offset = "0x32B5560", VA = "0x1832B6D60")]
	public DPNJNGGMIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x32B6720", Offset = "0x32B4F20", VA = "0x1832B6720", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, Rect DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x32B69B0", Offset = "0x32B51B0", VA = "0x1832B69B0", Slot = "5")]
	public Rect FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class DFEOOJGEDKH : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class LMKKMPAEIFE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3E1ADB0", Offset = "0x3E195B0", VA = "0x183E1ADB0")]
		static LMKKMPAEIFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private DFEOOJGEDKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class IOABJNCGIGP : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class IOEJPKPJMKB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x32073B0", Offset = "0x3205BB0", VA = "0x1832073B0")]
		static IOEJPKPJMKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class NMMANKMDBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> PDCOKLMLGIE;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2FF44D0", Offset = "0x2FF2CD0", VA = "0x182FF44D0")]
		internal static object FBNBEGPJOEK(Type PKNCKFNLBFL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private IOABJNCGIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class DAHLPACKJEF : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class MBOJECGHFHA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3E1F3B0", Offset = "0x3E1DBB0", VA = "0x183E1F3B0")]
		static MBOJECGHFHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly DAHLPACKJEF IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool CNIFGFDPNGB;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static GEHOIAKHNGG[] DOHPFHFFFFC;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static INLBFPHKJMK[] DCAKLJFJIPE;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private DAHLPACKJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x32B2350", Offset = "0x32B0B50", VA = "0x1832B2350")]
	public static void KMPNMMOJHBB(params INLBFPHKJMK[] DCAKLJFJIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x32B2290", Offset = "0x32B0A90", VA = "0x1832B2290")]
	public static void KMPNMMOJHBB(params GEHOIAKHNGG[] DOHPFHFFFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x32B2040", Offset = "0x32B0840", VA = "0x1832B2040")]
	public static void DNIGOHEGADE(GEHOIAKHNGG[] DOHPFHFFFFC, INLBFPHKJMK[] DCAKLJFJIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class PHBNAKACDLK : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class CHOKHONAGCO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3B482F0", Offset = "0x3B46AF0", VA = "0x183B482F0")]
		static CHOKHONAGCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private PHBNAKACDLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LMEELGGLNBO
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly INLBFPHKJMK LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly INLBFPHKJMK ELKIAOEBMCL;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly INLBFPHKJMK DHIMEFNFBDB;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly INLBFPHKJMK GMEBBABINIE;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly INLBFPHKJMK IJENLFADEJE;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly INLBFPHKJMK LPNMJJKLBGG;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly INLBFPHKJMK OGIANEPCGNP;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly INLBFPHKJMK FLDDANIBLCC;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly INLBFPHKJMK DOIAALMNMDM;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly INLBFPHKJMK BFNGCBHICKA;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly INLBFPHKJMK LJFHHKKHGMF;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly INLBFPHKJMK MMIOHIMKOHL;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class HDPAKDDHIBL
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly INLBFPHKJMK LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly INLBFPHKJMK LOENNNHJPAD;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class CKAANGONOBB
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly INLBFPHKJMK LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly INLBFPHKJMK ELKIAOEBMCL;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly INLBFPHKJMK DHIMEFNFBDB;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly INLBFPHKJMK GMEBBABINIE;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly INLBFPHKJMK IJENLFADEJE;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly INLBFPHKJMK LPNMJJKLBGG;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly INLBFPHKJMK OGIANEPCGNP;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly INLBFPHKJMK FLDDANIBLCC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly INLBFPHKJMK DOIAALMNMDM;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly INLBFPHKJMK BFNGCBHICKA;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly INLBFPHKJMK LJFHHKKHGMF;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly INLBFPHKJMK MMIOHIMKOHL;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class APKOBAABDEJ
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> PDCOKLMLGIE;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x32AC0E0", Offset = "0x32AA8E0", VA = "0x1832AC0E0")]
	internal static object FBNBEGPJOEK(Type PKNCKFNLBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x32AD6D0", Offset = "0x32ABED0", VA = "0x1832AD6D0")]
	private static object ILLJJKAOGIG(Type GDGCGAEPFLC, Type[] JMDAKGDBLCA, params object[] PBEGNEIIKLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class HPFJDNHLPPH : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class HJDONBIOJGL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3480440", Offset = "0x347EC40", VA = "0x183480440")]
		static HJDONBIOJGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> IOEMBNILPHG;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool HEINPLNBJJE;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly MFNAHBLCPDB EGHIACMPKJD;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2FE48B0", Offset = "0x2FE30B0", VA = "0x182FE48B0")]
	static HPFJDNHLPPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private HPFJDNHLPPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class AIFEJFHHGKA : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class OGEBCIFJAJK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x24CC330", Offset = "0x24CAB30", VA = "0x1824CC330")]
		static OGEBCIFJAJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> IOEMBNILPHG;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool HEINPLNBJJE;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly MFNAHBLCPDB EGHIACMPKJD;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x32AB530", Offset = "0x32A9D30", VA = "0x1832AB530")]
	static AIFEJFHHGKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private AIFEJFHHGKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class KFFIMLCJMLN : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class HDJACIKNONM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B11520", Offset = "0x2B0FD20", VA = "0x182B11520")]
		static HDJACIKNONM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> IOEMBNILPHG;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool HEINPLNBJJE;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly MFNAHBLCPDB EGHIACMPKJD;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1C30", Offset = "0x2FF0430", VA = "0x182FF1C30")]
	static KFFIMLCJMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private KFFIMLCJMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class AEKJKIFHAIC : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class EABJOCMIBLJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2091280", Offset = "0x208FA80", VA = "0x182091280")]
		static EABJOCMIBLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> IOEMBNILPHG;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool HEINPLNBJJE;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly MFNAHBLCPDB EGHIACMPKJD;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x32A9D60", Offset = "0x32A8560", VA = "0x1832A9D60")]
	static AEKJKIFHAIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private AEKJKIFHAIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class DMOAFINNOJK : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class KBOJAAIMOHD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3A46EE0", Offset = "0x3A456E0", VA = "0x183A46EE0")]
		static KBOJAAIMOHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> IOEMBNILPHG;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool HEINPLNBJJE;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly MFNAHBLCPDB EGHIACMPKJD;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x32B43E0", Offset = "0x32B2BE0", VA = "0x1832B43E0")]
	static DMOAFINNOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private DMOAFINNOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class JCPGFPNDGNO : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class MCBCKCBAGAN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2EB0320", Offset = "0x2EAEB20", VA = "0x182EB0320")]
		static MCBCKCBAGAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> IOEMBNILPHG;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool HEINPLNBJJE;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly MFNAHBLCPDB EGHIACMPKJD;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2FE6710", Offset = "0x2FE4F10", VA = "0x182FE6710")]
	static JCPGFPNDGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private JCPGFPNDGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class HOKKBDIFJNO : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class AEBJOAKICKD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x34793C0", Offset = "0x3477BC0", VA = "0x1834793C0")]
		static AEBJOAKICKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> IOEMBNILPHG;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool HEINPLNBJJE;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public HOKKBDIFJNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class OLFCGDCAJDH : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class OIFOENHGOJN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x332D390", Offset = "0x332BB90", VA = "0x18332D390")]
		static OIFOENHGOJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> IOEMBNILPHG;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool HEINPLNBJJE;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public OLFCGDCAJDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class BDFCKIFNKFN : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class JFONJICKLAI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x24C80D0", Offset = "0x24C68D0", VA = "0x1824C80D0")]
		static JFONJICKLAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> IOEMBNILPHG;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool HEINPLNBJJE;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public BDFCKIFNKFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class NPALHGMPFNA : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class GFKPBGAFMOJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x367E2D0", Offset = "0x367CAD0", VA = "0x18367E2D0")]
		static GFKPBGAFMOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> IOEMBNILPHG;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool HEINPLNBJJE;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public NPALHGMPFNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class MIOALAEIBIL : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class BMNHHIBGNPM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F860", Offset = "0x2B6E060", VA = "0x182B6F860")]
		static BMNHHIBGNPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> IOEMBNILPHG;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool HEINPLNBJJE;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public MIOALAEIBIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class IJNACPAHGCA : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class POOAFGJOCDH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x320AC20", Offset = "0x3209420", VA = "0x18320AC20")]
		static POOAFGJOCDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> IOEMBNILPHG;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool HEINPLNBJJE;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public IJNACPAHGCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class JJNPLGEPPHI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct DALHLEIBCIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public HNCOLKCGNKE EOBIFKOCLCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder GGKHDMHCNOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder GPADEJPNICD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class GCOLLJCBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class AHOJMJECHIP
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo BJOICDINAMB;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo AFEFMHGBMDG;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo MNCPNPBMLCA;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo DMFCOKFHFGP;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo FAEIPLDEFAA;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo PKOILKCFOAH;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo JEECANNKEKL;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo NEHKHIKNGHC;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo GJANHPAIIDP;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2FDE470", Offset = "0x2FDCC70", VA = "0x182FDE470")]
			static AHOJMJECHIP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class LIADJIDCDKF
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo GMOFEOKJCGM;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo MMEELNKDAKO;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo HFNJKJBLJGJ;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo IDPJKDLKPOL;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo BHIBPJIEDAD;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo NKMDGBFHENO;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo DAILAPNGLFG;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2FF3690", Offset = "0x2FF1E90", VA = "0x182FF3690")]
			static LIADJIDCDKF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class BCDJMHDMKAF
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo KAFHAMGGFON;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo AIFAGPKMPDH;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo CEGOLINPAIL;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo ENBIKLJGOLE;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo LPANNEOIIGE;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo GDKNLNIMNHF;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo GOLKPOLIJKK;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo EMPLHHDINMG;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo IKGEAHBHCFB;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo IMEDBGOJPCK;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo CLIPFIOADKE;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo ODJCKHIKPIE;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo JIILMKEGFDA;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo MHNOKKKKHII;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2FDFF30", Offset = "0x2FDE730", VA = "0x182FDFF30")]
		public static MethodInfo FAKLEMDHHIN(Type MIDEMNGPEAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2FE01C0", Offset = "0x2FDE9C0", VA = "0x182FE01C0")]
		public static MethodInfo FNNNELOCNNN(Type MIDEMNGPEAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2FE03F0", Offset = "0x2FDEBF0", VA = "0x182FE03F0")]
		public static MethodInfo NLKBBCKHLKF(Type MIDEMNGPEAG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class KPHENAGNNGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<HNCOLKCGNKE, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public KPHENAGNNGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class DPLCOECHNJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public KPHENAGNNGN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public DPLCOECHNJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2FDFBE0", Offset = "0x2FDE3E0", VA = "0x182FDFBE0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2FDFC20", Offset = "0x2FDE420", VA = "0x182FDFC20")]
		internal bool <BuildType>b__2(int index, HNCOLKCGNKE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class LLNCJPAFNJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public KPHENAGNNGN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public LLNCJPAFNJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4190", Offset = "0x2FF2990", VA = "0x182FF4190")]
		internal bool <BuildType>b__3(int index, HNCOLKCGNKE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class LCBBGGNIPAB
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
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public LCBBGGNIPAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2FF34B0", Offset = "0x2FF1CB0", VA = "0x182FF34B0")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class KAOLIGOKHNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public KAOLIGOKHNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2FF1100", Offset = "0x2FEF900", VA = "0x182FF1100")]
		internal bool <BuildAnonymousFormatter>b__2(HNCOLKCGNKE x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class IAELAKDALBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public LCBBGGNIPAB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public IAELAKDALBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2FE4DD0", Offset = "0x2FE35D0", VA = "0x182FE4DD0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2FE4DE0", Offset = "0x2FE35E0", VA = "0x182FE4DE0")]
		internal bool <BuildAnonymousFormatter>b__6(int index, HNCOLKCGNKE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class LMPPJLAGBNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public LCBBGGNIPAB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public LMPPJLAGBNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4230", Offset = "0x2FF2A30", VA = "0x182FF4230")]
		internal bool <BuildAnonymousFormatter>b__7(int index, HNCOLKCGNKE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class FDBBEFBPHPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public FDBBEFBPHPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x529CC0", Offset = "0x5284C0", VA = "0x180529CC0")]
		internal Label <BuildSerialize>b__1(HNCOLKCGNKE _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class ABOCAFPFIJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public DALHLEIBCIC[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, HNCOLKCGNKE, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public OHJGPELPBFN argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public OHJGPELPBFN argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public ABOCAFPFIJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE340", Offset = "0x2FDCB40", VA = "0x182FDE340")]
		internal DALHLEIBCIC <BuildDeserialize>b__0(HNCOLKCGNKE item)
		{
			return default(DALHLEIBCIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class JGJIMJHPBEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public ABOCAFPFIJM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public JGJIMJHPBEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2FE7A00", Offset = "0x2FE6200", VA = "0x182FE7A00")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2FE7CB0", Offset = "0x2FE64B0", VA = "0x182FE7CB0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class HKNNOLCHMEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public HNCOLKCGNKE item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public HKNNOLCHMEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1975D50", Offset = "0x1974550", VA = "0x181975D50")]
		internal bool <EmitNewObject>b__0(DALHLEIBCIC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class DIKMGFLFEFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public HNCOLKCGNKE item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public DIKMGFLFEFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1975D50", Offset = "0x1974550", VA = "0x181975D50")]
		internal bool <EmitNewObject>b__2(DALHLEIBCIC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex MMOLKMACABB;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int IGAKIKFLHAM;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> DGHOLPGHLJP;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> AJAABOPKIDB;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2D495D0", Offset = "0x2D47DD0", VA = "0x182D495D0")]
	public static object IOHDAEPNDJA<T>(MFNAHBLCPDB EGHIACMPKJD, INLBFPHKJMK LKPCKIGMJFP, Func<string, string> IOEMBNILPHG, bool HEINPLNBJJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2D440C0", Offset = "0x2D428C0", VA = "0x182D440C0")]
	public static object GEMOHGHEEHA<T>(INLBFPHKJMK LKPCKIGMJFP, Func<string, string> IOEMBNILPHG, bool HEINPLNBJJE, bool AKJKFBGHDKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2FEB010", Offset = "0x2FE9810", VA = "0x182FEB010")]
	private static TypeInfo EGKOLLNJCNK(MFNAHBLCPDB EGHIACMPKJD, Type MIDEMNGPEAG, Func<string, string> IOEMBNILPHG, bool HEINPLNBJJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2FE9100", Offset = "0x2FE7900", VA = "0x182FE9100")]
	public static object BJBNFGGLDME(Type MIDEMNGPEAG, Func<string, string> IOEMBNILPHG, bool HEINPLNBJJE, bool AKJKFBGHDKD, bool BCJJFHAKNEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2FEC720", Offset = "0x2FEAF20", VA = "0x182FEC720")]
	private static Dictionary<HNCOLKCGNKE, FieldInfo> FPOJFKMEPNC(TypeBuilder MNKMOKAFJMI, EIBAIMAAHPD JPCNLNKGAEI, ConstructorInfo EJLBOFLHLHD, FieldBuilder CFPJBJMFCBI, ILGenerator LJGKGDLFPEA, bool HEINPLNBJJE, bool DHIKFDGCNEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2FEAA40", Offset = "0x2FE9240", VA = "0x182FEAA40")]
	private static Dictionary<HNCOLKCGNKE, FieldInfo> CCAKIFBGDLP(TypeBuilder MNKMOKAFJMI, EIBAIMAAHPD JPCNLNKGAEI, ILGenerator LJGKGDLFPEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2FED400", Offset = "0x2FEBC00", VA = "0x182FED400")]
	private static void HJBLNJMGHNH(Type MIDEMNGPEAG, EIBAIMAAHPD JPCNLNKGAEI, ILGenerator LJGKGDLFPEA, Action IIKEPKGAJBG, Func<int, HNCOLKCGNKE, bool> ILDCHHDMKMC, bool HEINPLNBJJE, bool DHIKFDGCNEB, int EIPIAHNLGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2FECD70", Offset = "0x2FEB570", VA = "0x182FECD70")]
	private static void HBIKBBEIBPK(TypeInfo MIDEMNGPEAG, HNCOLKCGNKE CNJKMBGEAJM, ILGenerator LJGKGDLFPEA, int MPFAEFMOAIE, Func<int, HNCOLKCGNKE, bool> ILDCHHDMKMC, OHJGPELPBFN MNFKPJJAJNI, OHJGPELPBFN OKPOCBFNCNB, OHJGPELPBFN KGPBILNFODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2FEE960", Offset = "0x2FED160", VA = "0x182FEE960")]
	private static void LKCFGMKMJJF(Type MIDEMNGPEAG, EIBAIMAAHPD JPCNLNKGAEI, ILGenerator LJGKGDLFPEA, Func<int, HNCOLKCGNKE, bool> ILDCHHDMKMC, bool EGCFCFDPKFJ, int EIPIAHNLGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2FEFBC0", Offset = "0x2FEE3C0", VA = "0x182FEFBC0")]
	private static void LLPODGFOMJB(ILGenerator LJGKGDLFPEA, DALHLEIBCIC JPCNLNKGAEI, int MPFAEFMOAIE, Func<int, HNCOLKCGNKE, bool> ILDCHHDMKMC, OHJGPELPBFN HIADHCJGEEA, OHJGPELPBFN KGPBILNFODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2FEBAB0", Offset = "0x2FEA2B0", VA = "0x182FEBAB0")]
	private static LocalBuilder FDAGHABNEHB(ILGenerator LJGKGDLFPEA, Type MIDEMNGPEAG, EIBAIMAAHPD JPCNLNKGAEI, DALHLEIBCIC[] AAGMGPEHPFE, bool MENEEHDBLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2FEFFD0", Offset = "0x2FEE7D0", VA = "0x182FEFFD0")]
	private static bool MHLIDCAGBJN(ConstructorInfo NBOAIEEACMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2FED260", Offset = "0x2FEBA60", VA = "0x182FED260")]
	private static bool HEMKHLGLNCC(Type MIDEMNGPEAG, out Type DECAAKDJGCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void CNENMACOJKF<T>(byte[][] CFPJBJMFCBI, object[] HDIBPOGLDMH, ref FGEHJBFCCPO MNFKPJJAJNI, T DOBKOKNNFGA, INLBFPHKJMK FOFIKLEPNFM);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T EDJACNOKNMG<T>(object[] HDIBPOGLDMH, ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK FOFIKLEPNFM);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class GLHCPBEPELK<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class OBJFFJMGOAA : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class NJNPMBOGHDO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3D8D130", Offset = "0x3D8B930", VA = "0x183D8D130")]
		static NJNPMBOGHDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private OBJFFJMGOAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class JEGDMAEGKCL : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class DNNEOIIEGPP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2EA15C0", Offset = "0x2E9FDC0", VA = "0x182EA15C0")]
		static DNNEOIIEGPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private JEGDMAEGKCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class HNPLHLOCINJ
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly INLBFPHKJMK[] OAAFANENJJM;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class IBGACGCHFGP : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class PFEEDNMJGCP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x348E9A0", Offset = "0x348D1A0", VA = "0x18348E9A0")]
		static PFEEDNMJGCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class LHLCLHDENKJ : INLBFPHKJMK
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class JNLGJFHPCHM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3487CF0", Offset = "0x34864F0", VA = "0x183487CF0")]
			static JNLGJFHPCHM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly INLBFPHKJMK IPNCHOCFJCD;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly INLBFPHKJMK[] DCAKLJFJIPE;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		private LHLCLHDENKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
		public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::IEMBFIJKPHO<object> NDHCEGBDBFO;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private IBGACGCHFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class OPAHBHLAKAH : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class PDBFAPAGFKM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3920F00", Offset = "0x391F700", VA = "0x183920F00")]
		static PDBFAPAGFKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class PAHONLKNABB : INLBFPHKJMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class HBPBGFAEAKJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x390EBA0", Offset = "0x390D3A0", VA = "0x18390EBA0")]
			static HBPBGFAEAKJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly INLBFPHKJMK IPNCHOCFJCD;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly INLBFPHKJMK[] DCAKLJFJIPE;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		private PAHONLKNABB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
		public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::IEMBFIJKPHO<object> NDHCEGBDBFO;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private OPAHBHLAKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class NIBKLIBFEPP : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class HPDIGBKBENL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x367FC20", Offset = "0x367E420", VA = "0x18367FC20")]
		static HPDIGBKBENL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class EGKOLFAELHD : INLBFPHKJMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class FBLAJDDLGEM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x1C02710", Offset = "0x1C00F10", VA = "0x181C02710")]
			static FBLAJDDLGEM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly INLBFPHKJMK IPNCHOCFJCD;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly INLBFPHKJMK[] DCAKLJFJIPE;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		private EGKOLFAELHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
		public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::IEMBFIJKPHO<object> NDHCEGBDBFO;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private NIBKLIBFEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class PMIEEGNHLKB : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class PEAGEIHLIOH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3C78C30", Offset = "0x3C77430", VA = "0x183C78C30")]
		static PEAGEIHLIOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class JBFPAHCEHOP : INLBFPHKJMK
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class POPLHHBIIAD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3C80450", Offset = "0x3C7EC50", VA = "0x183C80450")]
			static POPLHHBIIAD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly INLBFPHKJMK IPNCHOCFJCD;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly INLBFPHKJMK[] DCAKLJFJIPE;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		private JBFPAHCEHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
		public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::IEMBFIJKPHO<object> NDHCEGBDBFO;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private PMIEEGNHLKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class BEDABOPJBBF : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class AAFKOJCOIKN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x36AEF80", Offset = "0x36AD780", VA = "0x1836AEF80")]
		static AAFKOJCOIKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class AEHDHFLFCAH : INLBFPHKJMK
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class NBHEFEHAEAI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x36CA870", Offset = "0x36C9070", VA = "0x1836CA870")]
			static NBHEFEHAEAI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly INLBFPHKJMK IPNCHOCFJCD;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly INLBFPHKJMK[] DCAKLJFJIPE;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		private AEHDHFLFCAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
		public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::IEMBFIJKPHO<object> NDHCEGBDBFO;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private BEDABOPJBBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class HBGKEIGOIFN : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class NGCGLHFDCPG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3B96450", Offset = "0x3B94C50", VA = "0x183B96450")]
		static NGCGLHFDCPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class GGBNFDBEKCL : INLBFPHKJMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class MOBJAFCHNJP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3B92F10", Offset = "0x3B91710", VA = "0x183B92F10")]
			static MOBJAFCHNJP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly INLBFPHKJMK IPNCHOCFJCD;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly INLBFPHKJMK[] DCAKLJFJIPE;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		private GGBNFDBEKCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
		public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::IEMBFIJKPHO<object> NDHCEGBDBFO;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private HBGKEIGOIFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class HKIOAFOFPIL : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class NCDMLCBCOKC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x348ABA0", Offset = "0x34893A0", VA = "0x18348ABA0")]
		static NCDMLCBCOKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class JLBFHKIKIPI : INLBFPHKJMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class ACFFDMNNLKJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3475920", Offset = "0x3474120", VA = "0x183475920")]
			static ACFFDMNNLKJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly INLBFPHKJMK IPNCHOCFJCD;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly INLBFPHKJMK[] DCAKLJFJIPE;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		private JLBFHKIKIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
		public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::IEMBFIJKPHO<object> NDHCEGBDBFO;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private HKIOAFOFPIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class CFDJJACHFOJ : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class ADLEMPKPCDN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x36DD0C0", Offset = "0x36DB8C0", VA = "0x1836DD0C0")]
		static ADLEMPKPCDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class ICIFBIGPHAG : INLBFPHKJMK
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class KCKCBGIKNLO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x36EF210", Offset = "0x36EDA10", VA = "0x1836EF210")]
			static KCKCBGIKNLO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly INLBFPHKJMK IPNCHOCFJCD;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly INLBFPHKJMK[] DCAKLJFJIPE;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		private ICIFBIGPHAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
		public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::IEMBFIJKPHO<object> NDHCEGBDBFO;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private CFDJJACHFOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class BLEMAEJKMMF : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class KKJFMKDGIPK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x36C2D80", Offset = "0x36C1580", VA = "0x1836C2D80")]
		static KKJFMKDGIPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class KGEANNOCPHB : INLBFPHKJMK
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class ECBIIMKLJEM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x36BA070", Offset = "0x36B8870", VA = "0x1836BA070")]
			static ECBIIMKLJEM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly INLBFPHKJMK IPNCHOCFJCD;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly INLBFPHKJMK[] DCAKLJFJIPE;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		private KGEANNOCPHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
		public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::IEMBFIJKPHO<object> NDHCEGBDBFO;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private BLEMAEJKMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class HDICGALILEB : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class NHPKGADDAMP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3B9DEE0", Offset = "0x3B9C6E0", VA = "0x183B9DEE0")]
		static NHPKGADDAMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class DLNCKHHGPGP : INLBFPHKJMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class HOLDKBILJON<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3B91080", Offset = "0x3B8F880", VA = "0x183B91080")]
			static HOLDKBILJON()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly INLBFPHKJMK IPNCHOCFJCD;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly INLBFPHKJMK[] DCAKLJFJIPE;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		private DLNCKHHGPGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
		public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::IEMBFIJKPHO<object> NDHCEGBDBFO;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private HDICGALILEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class DGMMBADNJKN : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class BADIDENJFPJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3A38700", Offset = "0x3A36F00", VA = "0x183A38700")]
		static BADIDENJFPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class CPPNAJOGHIK : INLBFPHKJMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class KMAFBJNKNPO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3A49FD0", Offset = "0x3A487D0", VA = "0x183A49FD0")]
			static KMAFBJNKNPO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly INLBFPHKJMK IPNCHOCFJCD;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly INLBFPHKJMK[] DCAKLJFJIPE;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		private CPPNAJOGHIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
		public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::IEMBFIJKPHO<object> NDHCEGBDBFO;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private DGMMBADNJKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class CCCHENHBCNC : INLBFPHKJMK
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class FBGGHPMGKKB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x35A70C0", Offset = "0x35A58C0", VA = "0x1835A70C0")]
		static FBGGHPMGKKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class MGNAECMHEMI : INLBFPHKJMK
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class NLFNFNAADHI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::IEMBFIJKPHO<T> FMIAEEFKAFG;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x35AE700", Offset = "0x35ACF00", VA = "0x1835AE700")]
			static NLFNFNAADHI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly INLBFPHKJMK IPNCHOCFJCD;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly INLBFPHKJMK[] DCAKLJFJIPE;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		private MGNAECMHEMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
		public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly INLBFPHKJMK IPNCHOCFJCD;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::IEMBFIJKPHO<object> NDHCEGBDBFO;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private CCCHENHBCNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x250DB10", Offset = "0x250C310", VA = "0x18250DB10", Slot = "4")]
	public global::IEMBFIJKPHO<T> FBNBEGPJOEK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct KEMBFHAPNMO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] INMEAJLDAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int NLOJDNDIBNE;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2B17910", Offset = "0x2B16110", VA = "0x182B17910")]
	public KEMBFHAPNMO(int IGOENJJGNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2B177A0", Offset = "0x2B15FA0", VA = "0x182B177A0")]
	public void EFDMEADFFJF(T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2B17880", Offset = "0x2B16080", VA = "0x182B17880")]
	public T[] KMNACKHEIOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class BMMOBMEKJIN : global::FEDMELOEICG<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly BMMOBMEKJIN LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x32AE480", Offset = "0x32ACC80", VA = "0x1832AE480")]
	public BMMOBMEKJIN(int IBJOOOCKPED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class FEDMELOEICG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int IBJOOOCKPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object ADMKABHPCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int MPFAEFMOAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] AALMCGFFBAC;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x32546B0", Offset = "0x3252EB0", VA = "0x1832546B0")]
	public FEDMELOEICG(int IBJOOOCKPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3252670", Offset = "0x3250E70", VA = "0x183252670")]
	public T[] EFJMNNBPJDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3253570", Offset = "0x3251D70", VA = "0x183253570")]
	public void OFABLCPOAEF(T[] GGAIBHJOFBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class CKJHLECLPKO : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class HKEOLEILDOM : IComparable<HKEOLEILDOM>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class KOAOBMEMAML : IEnumerable<HKEOLEILDOM>, IEnumerable, IEnumerator<HKEOLEILDOM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private HKEOLEILDOM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public HKEOLEILDOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private HKEOLEILDOM System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x6323E0", Offset = "0x630BE0", VA = "0x1806323E0")]
			[DebuggerHidden]
			public KOAOBMEMAML(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x32C0FA0", Offset = "0x32BF7A0", VA = "0x1832C0FA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x32C10D0", Offset = "0x32BF8D0", VA = "0x1832C10D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x32C1030", Offset = "0x32BF830", VA = "0x1832C1030", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<HKEOLEILDOM> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x32C1030", Offset = "0x32BF830", VA = "0x1832C1030", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class LHJICLNFKKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
			public LHJICLNFKKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x529CC0", Offset = "0x5284C0", VA = "0x180529CC0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x529CC0", Offset = "0x5284C0", VA = "0x180529CC0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly HKEOLEILDOM[] EKMKGLBPAFD;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] KHDFEKJKJAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong BNGGPGAGIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int MPJDHKAGMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string GOGGKOBDJLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private HKEOLEILDOM[] OGOOAGEHFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] IOCOKICNNAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int KALABHLPPAL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool KEDIJAPNBBL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA1A400", Offset = "0xA18C00", VA = "0x180A1A400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x32C0BE0", Offset = "0x32BF3E0", VA = "0x1832C0BE0")]
		public HKEOLEILDOM(ulong MHAAPGJKGCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x32C0700", Offset = "0x32BEF00", VA = "0x1832C0700")]
		public HKEOLEILDOM EFDMEADFFJF(ulong MHAAPGJKGCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x32C08F0", Offset = "0x32BF0F0", VA = "0x1832C08F0")]
		public HKEOLEILDOM EFDMEADFFJF(ulong MHAAPGJKGCK, int DOBKOKNNFGA, string GOGGKOBDJLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x32C0520", Offset = "0x32BED20", VA = "0x1832C0520")]
		public HKEOLEILDOM APGOOHDFMDM(byte[] FGACJNFPLMD, ref int POHBEAAADEA, ref int GFEICEKNCFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x32C0940", Offset = "0x32BF140", VA = "0x1832C0940")]
		internal static int ENOAHDEFHDK(ulong[] GGAIBHJOFBE, int MPFAEFMOAIE, int HGMFCBLCCGF, ulong DOBKOKNNFGA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x32C06D0", Offset = "0x32BEED0", VA = "0x1832C06D0", Slot = "4")]
		public int CompareTo(HKEOLEILDOM DKNLIFHKLLN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x32C09C0", Offset = "0x32BF1C0", VA = "0x1832C09C0")]
		[IteratorStateMachine(typeof(KOAOBMEMAML))]
		public IEnumerable<HKEOLEILDOM> ILJBOHDEDAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x32C0A30", Offset = "0x32BF230", VA = "0x1832C0A30")]
		public void JBEGJEKNONP(ILGenerator LJGKGDLFPEA, LocalBuilder FGACJNFPLMD, LocalBuilder GFEICEKNCFJ, LocalBuilder MHAAPGJKGCK, Action<KeyValuePair<string, int>> OHOIMHDFLBC, Action LCKKNLJNIDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x32BF940", Offset = "0x32BE140", VA = "0x1832BF940")]
		private static void AFCLAJKKMME(ILGenerator LJGKGDLFPEA, LocalBuilder FGACJNFPLMD, LocalBuilder GFEICEKNCFJ, LocalBuilder MHAAPGJKGCK, Action<KeyValuePair<string, int>> OHOIMHDFLBC, Action LCKKNLJNIDE, HKEOLEILDOM[] OGOOAGEHFNB, int KALABHLPPAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class DDHEFBPAHPK : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<HKEOLEILDOM> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<HKEOLEILDOM> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<HKEOLEILDOM> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private HKEOLEILDOM <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x522000", Offset = "0x520800", VA = "0x180522000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x32B32F0", Offset = "0x32B1AF0", VA = "0x1832B32F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x931C50", Offset = "0x930450", VA = "0x180931C50")]
		[DebuggerHidden]
		public DDHEFBPAHPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x32B3340", Offset = "0x32B1B40", VA = "0x1832B3340", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x32B2E80", Offset = "0x32B1680", VA = "0x1832B2E80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x32B3440", Offset = "0x32B1C40", VA = "0x1832B3440")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x32B3490", Offset = "0x32B1C90", VA = "0x1832B3490")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x32B32A0", Offset = "0x32B1AA0", VA = "0x1832B32A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x32B3200", Offset = "0x32B1A00", VA = "0x1832B3200", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x32B3200", Offset = "0x32B1A00", VA = "0x1832B3200", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly HKEOLEILDOM MHMECKKACOC;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x32B0360", Offset = "0x32AEB60", VA = "0x1832B0360")]
	public CKJHLECLPKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x32AFD60", Offset = "0x32AE560", VA = "0x1832AFD60")]
	public void EFDMEADFFJF(byte[] MIIBCOAJABM, int DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x32AFC80", Offset = "0x32AE480", VA = "0x1832AFC80")]
	public bool AJKCBCBNMPN(ArraySegment<byte> MHAAPGJKGCK, out int DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x32B0270", Offset = "0x32AEA70", VA = "0x1832B0270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x32AFFF0", Offset = "0x32AE7F0", VA = "0x1832AFFF0")]
	private static void MHKIMPOGLLK(IEnumerable<HKEOLEILDOM> OGOOAGEHFNB, StringBuilder PMMLFGOAKLO, int LOBHBEGMMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x32AFE80", Offset = "0x32AE680", VA = "0x1832AFE80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x32AFE80", Offset = "0x32AE680", VA = "0x1832AFE80", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x32AFF80", Offset = "0x32AE780", VA = "0x1832AFF80")]
	[IteratorStateMachine(typeof(DDHEFBPAHPK))]
	private static IEnumerable<KeyValuePair<string, int>> JOALDBMICAJ(IEnumerable<HKEOLEILDOM> OGOOAGEHFNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x32AFD30", Offset = "0x32AE530", VA = "0x1832AFD30")]
	public void CDAFDLBPFIK(ILGenerator LJGKGDLFPEA, LocalBuilder FGACJNFPLMD, LocalBuilder GFEICEKNCFJ, LocalBuilder MHAAPGJKGCK, Action<KeyValuePair<string, int>> OHOIMHDFLBC, Action LCKKNLJNIDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class PDECFEBPPAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo LCGLDBKHBLE;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x41FDFF0", Offset = "0x41FC7F0", VA = "0x1841FDFF0")]
	public static ulong AJNCEDJIODE(byte[] MIIBCOAJABM, ref int POHBEAAADEA, ref int GFEICEKNCFJ)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class LDFJKMGEBMM
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x41F3E40", Offset = "0x41F2640", VA = "0x1841F3E40")]
	public static void MDKOBEAOKGA(ref byte[] MIIBCOAJABM, int POHBEAAADEA, int GGHGLBALCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x41F3D50", Offset = "0x41F2550", VA = "0x1841F3D50")]
	public static void LCALNBJMOOH(ref byte[] GGAIBHJOFBE, int AAJCBPNFCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x41F3F60", Offset = "0x41F2760", VA = "0x1841F3F60")]
	public static byte[] PMFMBOODLBB(byte[] NCDDMLADDEH, int AAJCBPNFCIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class DOPNLIFBKIP
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x32B4980", Offset = "0x32B3180", VA = "0x1832B4980")]
	public static bool LIHCCHCJGIF(byte[] HIGLDNFNKJL, int FMGNHDKIGBL, int FKDPLFJOPIG, byte[] GIOAEOOJACH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class EEKEGGBKIKK<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct PNGJKCILACF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] BNGGPGAGIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T MPJDHKAGMAD;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x27A6350", Offset = "0x27A4B50", VA = "0x1827A6350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class IJNCEODBGOI : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::EEKEGGBKIKK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private PNGJKCILACF[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private PNGJKCILACF[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xFFD380", Offset = "0xFFBB80", VA = "0x180FFD380", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x279FD20", Offset = "0x279E520", VA = "0x18279FD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1AF95D0", Offset = "0x1AF7DD0", VA = "0x181AF95D0")]
		[DebuggerHidden]
		public IJNCEODBGOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x279E870", Offset = "0x279D070", VA = "0x18279E870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x279F550", Offset = "0x279DD50", VA = "0x18279F550", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly PNGJKCILACF[][] PNPIMJDNMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong HLGPKLKLIBH;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3B86880", Offset = "0x3B85080", VA = "0x183B86880")]
	public EEKEGGBKIKK(int PODLECMNECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3B867C0", Offset = "0x3B84FC0", VA = "0x183B867C0")]
	public EEKEGGBKIKK(int PODLECMNECF, float KJNPMIKLHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3B7B000", Offset = "0x3B79800", VA = "0x183B7B000")]
	public void EFDMEADFFJF(byte[] MHAAPGJKGCK, T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3B7CE00", Offset = "0x3B7B600", VA = "0x183B7CE00")]
	private bool GPNIDLOFOOL(byte[] MHAAPGJKGCK, T DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3B84470", Offset = "0x3B82C70", VA = "0x183B84470")]
	public bool NFIDKFMHPHL(ArraySegment<byte> MHAAPGJKGCK, out T DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3B82C40", Offset = "0x3B81440", VA = "0x183B82C40")]
	private static ulong HDBFPLGEJHM(byte[] DNCFOPMJGLJ, int POHBEAAADEA, int KALABHLPPAL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3921150", Offset = "0x391F950", VA = "0x183921150")]
	private static int DMODNFCKJDI(int NMMCGJEENGB, float KJNPMIKLHJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3B82B20", Offset = "0x3B81320", VA = "0x183B82B20", Slot = "4")]
	[IteratorStateMachine(typeof(global::EEKEGGBKIKK<>.IJNCEODBGOI))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1B05680", Offset = "0x1B03E80", VA = "0x181B05680", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class IAAOEHACMEM : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] FNIIANAGCIP;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] GDEGINCMLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int ICEGIJNBFGA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool FJJFMFEGHJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2FE4AB0", Offset = "0x2FE32B0", VA = "0x182FE4AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2FE4B00", Offset = "0x2FE3300", VA = "0x182FE4B00")]
	static IAAOEHACMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2FE4D50", Offset = "0x2FE3550", VA = "0x182FE4D50")]
	public IAAOEHACMEM(byte[] ADKBHJLNABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2FE49A0", Offset = "0x2FE31A0", VA = "0x182FE49A0")]
	public OpCode COJBIPBJHMF()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct DPAPAHGECJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid MPJDHKAGMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte FCEPFMCDMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte OGMHKCBKEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte HCAPCGOOBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte AFCFJFOLIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte BAJDDFNNLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte BMKEOECDIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte IPFOHJCBCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte JGLDBPKJGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte LGNBHCNBOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte JIABNDMMFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte IDPFDJKHMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte EPLFAGGOLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte ONJCJKDJEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte CEACJJMKNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte BANEGGCAKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte EEHJLILBHIJ;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] KJAKDKNJAKN;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] GNEJJMIFIJC;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x32B6680", Offset = "0x32B4E80", VA = "0x1832B6680")]
	public DPAPAHGECJE(ref Guid DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x32B5FD0", Offset = "0x32B47D0", VA = "0x1832B5FD0")]
	public DPAPAHGECJE(ref ArraySegment<byte> KCOBHMFPAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x32B5E60", Offset = "0x32B4660", VA = "0x1832B5E60")]
	private static byte PBOPLPEKGBK(byte[] MIIBCOAJABM, int FDALNONDMGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x32B4A10", Offset = "0x32B3210", VA = "0x1832B4A10")]
	private static byte CFEBJLJBAPC(byte DOMNMKJGGGI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x32B4B20", Offset = "0x32B3320", VA = "0x1832B4B20")]
	public void JMJBNJCBDAN(byte[] FFBNFFLLBIL, int POHBEAAADEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class OAPKCPEKEAA
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x41FC8C0", Offset = "0x41FB0C0", VA = "0x1841FC8C0")]
	public static bool KFJLLINMLEB(byte BBFAELNBDJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x41FBFD0", Offset = "0x41FA7D0", VA = "0x1841FBFD0")]
	public static bool HOLPMHAGBMJ(byte BBFAELNBDJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x41FC8D0", Offset = "0x41FB0D0", VA = "0x1841FC8D0")]
	public static sbyte NGKLOGIAAAA(byte[] MIIBCOAJABM, int POHBEAAADEA, out int FNLBELEPJBG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x41FAED0", Offset = "0x41F96D0", VA = "0x1841FAED0")]
	public static short BBNJPMPANNJ(byte[] MIIBCOAJABM, int POHBEAAADEA, out int FNLBELEPJBG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x41FCA20", Offset = "0x41FB220", VA = "0x1841FCA20")]
	public static int PIDCPHCFBMM(byte[] MIIBCOAJABM, int POHBEAAADEA, out int FNLBELEPJBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x41FC040", Offset = "0x41FA840", VA = "0x1841FC040")]
	public static long ICJFPEKEFAM(byte[] MIIBCOAJABM, int POHBEAAADEA, out int FNLBELEPJBG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x41FC940", Offset = "0x41FB140", VA = "0x1841FC940")]
	public static byte NKBPKKOGNIJ(byte[] MIIBCOAJABM, int POHBEAAADEA, out int FNLBELEPJBG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x41FC9B0", Offset = "0x41FB1B0", VA = "0x1841FC9B0")]
	public static ushort OJPKKEIMHJB(byte[] MIIBCOAJABM, int POHBEAAADEA, out int FNLBELEPJBG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x41FBB80", Offset = "0x41FA380", VA = "0x1841FBB80")]
	public static uint CEKHNEEHCBG(byte[] MIIBCOAJABM, int POHBEAAADEA, out int FNLBELEPJBG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x41FBE50", Offset = "0x41FA650", VA = "0x1841FBE50")]
	public static ulong FIJMPFCHNHK(byte[] MIIBCOAJABM, int POHBEAAADEA, out int FNLBELEPJBG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x41FAE60", Offset = "0x41F9660", VA = "0x1841FAE60")]
	public static float AIBPCMDAJJN(byte[] MIIBCOAJABM, int POHBEAAADEA, out int FNLBELEPJBG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x41FBF60", Offset = "0x41FA760", VA = "0x1841FBF60")]
	public static double FJMACINGFNL(byte[] MIIBCOAJABM, int POHBEAAADEA, out int FNLBELEPJBG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x41FC0F0", Offset = "0x41FA8F0", VA = "0x1841FC0F0")]
	public static int IFNCNPEAAJH(ref byte[] FFBNFFLLBIL, int POHBEAAADEA, ulong DOBKOKNNFGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x41FAF40", Offset = "0x41F9740", VA = "0x1841FAF40")]
	public static int BPPDDJDMINP(ref byte[] FFBNFFLLBIL, int POHBEAAADEA, long DOBKOKNNFGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x41FBC00", Offset = "0x41FA400", VA = "0x1841FBC00")]
	public static bool CKNKOGCPDBD(byte[] MIIBCOAJABM, int POHBEAAADEA, out int FNLBELEPJBG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class OEJJOLBOHHN
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class NDOBNPFODAE : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6323E0", Offset = "0x630BE0", VA = "0x1806323E0")]
		[DebuggerHidden]
		public NDOBNPFODAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x41F9370", Offset = "0x41F7B70", VA = "0x1841F9370", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x41F8F10", Offset = "0x41F7710", VA = "0x1841F8F10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x41F9490", Offset = "0x41F7C90", VA = "0x1841F9490")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x41F94E0", Offset = "0x41F7CE0", VA = "0x1841F94E0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x41F9320", Offset = "0x41F7B20", VA = "0x1841F9320", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x41F9270", Offset = "0x41F7A70", VA = "0x1841F9270", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x41F9270", Offset = "0x41F7A70", VA = "0x1841F9270", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class FABNAOMHIPP : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6323E0", Offset = "0x630BE0", VA = "0x1806323E0")]
		[DebuggerHidden]
		public FABNAOMHIPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x41F0EB0", Offset = "0x41EF6B0", VA = "0x1841F0EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x41F0A50", Offset = "0x41EF250", VA = "0x1841F0A50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x41F0FD0", Offset = "0x41EF7D0", VA = "0x1841F0FD0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x41F1020", Offset = "0x41EF820", VA = "0x1841F1020")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x41F0E60", Offset = "0x41EF660", VA = "0x1841F0E60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x41F0DB0", Offset = "0x41EF5B0", VA = "0x1841F0DB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x41F0DB0", Offset = "0x41EF5B0", VA = "0x1841F0DB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x41FD320", Offset = "0x41FBB20", VA = "0x1841FD320")]
	public static bool ADLGGOHCGHB(this TypeInfo MIDEMNGPEAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x41FD4C0", Offset = "0x41FBCC0", VA = "0x1841FD4C0")]
	public static bool JIMLPMDOANB(this TypeInfo MIDEMNGPEAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x41FD460", Offset = "0x41FBC60", VA = "0x1841FD460")]
	public static IEnumerable<PropertyInfo> GGGHDBFCBMB(this Type MIDEMNGPEAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x41FD5C0", Offset = "0x41FBDC0", VA = "0x1841FD5C0")]
	[IteratorStateMachine(typeof(NDOBNPFODAE))]
	private static IEnumerable<PropertyInfo> KILINLKLKHG(Type MIDEMNGPEAG, HashSet<string> AJIOJEFKCHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x41FD650", Offset = "0x41FBE50", VA = "0x1841FD650")]
	public static IEnumerable<FieldInfo> MAPPDDNKHDJ(this Type MIDEMNGPEAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x41FD3D0", Offset = "0x41FBBD0", VA = "0x1841FD3D0")]
	[IteratorStateMachine(typeof(FABNAOMHIPP))]
	private static IEnumerable<FieldInfo> DCJOKJHMBMI(Type MIDEMNGPEAG, HashSet<string> AJIOJEFKCHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class BAGHMJHGEED
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding KJBODDBNPBA;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class ODMBNBGHFHD
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5D6F60", Offset = "0x5D5760", VA = "0x1805D6F60")]
	public static string CJNFBHFCCKF(string JFFDHNPMLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x41FD210", Offset = "0x41FBA10", VA = "0x1841FD210")]
	public static string NOLMNHHLEDM(string JFFDHNPMLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x41FD040", Offset = "0x41FB840", VA = "0x1841FD040")]
	public static string HAGLAFHNIFF(string JFFDHNPMLKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class PDFHKEIKHOP<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class HAJMMHBJNPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type BNGGPGAGIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue MPJDHKAGMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int LCHCLFHAPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public HAJMMHBJNPJ KFDCAJOFAAB;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x390E6E0", Offset = "0x390CEE0", VA = "0x18390E6E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x390E440", Offset = "0x390CC40", VA = "0x18390E440")]
		private int MKFJBHDFMPL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public HAJMMHBJNPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class HIDKGPHINAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public HIDKGPHINAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x836CC0", Offset = "0x8354C0", VA = "0x180836CC0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private HAJMMHBJNPJ[] PNPIMJDNMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int LGIEDJBGIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object BINPBCABPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float KJNPMIKLHJE;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x39225A0", Offset = "0x3920DA0", VA = "0x1839225A0")]
	public PDFHKEIKHOP(int PODLECMNECF = 4, float KJNPMIKLHJE = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3922030", Offset = "0x3920830", VA = "0x183922030")]
	public bool LOLGLADEDCA(Type MHAAPGJKGCK, TValue DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3921FF0", Offset = "0x39207F0", VA = "0x183921FF0")]
	public bool LOLGLADEDCA(Type MHAAPGJKGCK, Func<Type, TValue> OGIIJLPKINN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x39218E0", Offset = "0x39200E0", VA = "0x1839218E0")]
	private bool GPNIDLOFOOL(Type MHAAPGJKGCK, Func<Type, TValue> OGIIJLPKINN, out TValue CGKJJCHBHGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x3921180", Offset = "0x391F980", VA = "0x183921180")]
	private bool EABEPIPHIKG(HAJMMHBJNPJ[] PNPIMJDNMCD, Type OELBPAAKCFN, HAJMMHBJNPJ MNIFDCHDBGH, Func<Type, TValue> OGIIJLPKINN, out TValue CGKJJCHBHGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x3922180", Offset = "0x3920980", VA = "0x183922180")]
	public bool NFIDKFMHPHL(Type MHAAPGJKGCK, out TValue DOBKOKNNFGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x3922420", Offset = "0x3920C20", VA = "0x183922420")]
	public TValue OOAAAAACIMH(Type MHAAPGJKGCK, Func<Type, TValue> OGIIJLPKINN)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x3921150", Offset = "0x391F950", VA = "0x183921150")]
	private static int DMODNFCKJDI(int NMMCGJEENGB, float KJNPMIKLHJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x3922570", Offset = "0x3920D70", VA = "0x183922570")]
	private static void PGLKMDJPNBO(ref HAJMMHBJNPJ EFAPPGDGECI, HAJMMHBJNPJ DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x3922570", Offset = "0x3920D70", VA = "0x183922570")]
	private static void PGLKMDJPNBO(ref HAJMMHBJNPJ[] EFAPPGDGECI, HAJMMHBJNPJ[] DOBKOKNNFGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class MFNAHBLCPDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder IEHDOCFALFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder JCHJAEPLLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object ADMKABHPCAM;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x41F67B0", Offset = "0x41F4FB0", VA = "0x1841F67B0")]
	public TypeBuilder GPBGGKHJONC(string CBFODBDAPIM, TypeAttributes BBIFCBAMPGL, Type AIECLMDDNDL, Type[] NHPLCBELDFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x41F68A0", Offset = "0x41F50A0", VA = "0x1841F68A0")]
	public MFNAHBLCPDB(string DGCKPPBEMCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class AECPCMDHJAL
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x32A9AF0", Offset = "0x32A82F0", VA = "0x1832A9AF0")]
	private static MethodInfo BGANCHEAIJL(LambdaExpression GGIOBKEOECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2915F90", Offset = "0x2914790", VA = "0x182915F90")]
	public static MethodInfo OCKOHAJBNPP<T>(Expression<Func<T>> GGIOBKEOECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2915F90", Offset = "0x2914790", VA = "0x182915F90")]
	public static MethodInfo OCKOHAJBNPP<T, TR>(Expression<Func<T, TR>> GGIOBKEOECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2915F90", Offset = "0x2914790", VA = "0x182915F90")]
	public static MethodInfo OCKOHAJBNPP<T>(Expression<Action<T>> GGIOBKEOECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2915F90", Offset = "0x2914790", VA = "0x182915F90")]
	public static MethodInfo OCKOHAJBNPP<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> GGIOBKEOECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x2915EF0", Offset = "0x29146F0", VA = "0x182915EF0")]
	private static MemberInfo KKOFHKPCDNC<T>(Expression<T> GGMOHJBJDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x2915E90", Offset = "0x2914690", VA = "0x182915E90")]
	public static PropertyInfo FLDOEHDAAAO<T, TR>(Expression<Func<T, TR>> GGIOBKEOECB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct OHJGPELPBFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int DBEFKGHKNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool CJDDABCLDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator LJGKGDLFPEA;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x41FD9E0", Offset = "0x41FC1E0", VA = "0x1841FD9E0")]
	public OHJGPELPBFN(ILGenerator LJGKGDLFPEA, int DBEFKGHKNPJ, bool CJDDABCLDAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x41FD950", Offset = "0x41FC150", VA = "0x1841FD950")]
	public OHJGPELPBFN(ILGenerator LJGKGDLFPEA, int DBEFKGHKNPJ, Type MIDEMNGPEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x41FD840", Offset = "0x41FC040", VA = "0x1841FD840")]
	public void DEHPGLMHMMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class LJGPADFIKNN
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x41F58A0", Offset = "0x41F40A0", VA = "0x1841F58A0")]
	public static void NNCEHGOHJNI(this ILGenerator LJGKGDLFPEA, int MPFAEFMOAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x41F5860", Offset = "0x41F4060", VA = "0x1841F5860")]
	public static void NNCEHGOHJNI(this ILGenerator LJGKGDLFPEA, LocalBuilder IKJLIINCCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x41F5000", Offset = "0x41F3800", VA = "0x1841F5000")]
	public static void IMFAKCMHPOB(this ILGenerator LJGKGDLFPEA, int MPFAEFMOAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x41F5230", Offset = "0x41F3A30", VA = "0x1841F5230")]
	public static void IMFAKCMHPOB(this ILGenerator LJGKGDLFPEA, LocalBuilder IKJLIINCCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x41F4C50", Offset = "0x41F3450", VA = "0x1841F4C50")]
	public static void FAKHHKGBLAB(this ILGenerator LJGKGDLFPEA, int MPFAEFMOAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x41F4B40", Offset = "0x41F3340", VA = "0x1841F4B40")]
	public static void FAKHHKGBLAB(this ILGenerator LJGKGDLFPEA, LocalBuilder IKJLIINCCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x41F4A30", Offset = "0x41F3230", VA = "0x1841F4A30")]
	public static void CCMCBIDCKBH(this ILGenerator LJGKGDLFPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x41F56C0", Offset = "0x41F3EC0", VA = "0x1841F56C0")]
	public static void JIBAEOPBGPI(this ILGenerator LJGKGDLFPEA, bool DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x41F5270", Offset = "0x41F3A70", VA = "0x1841F5270")]
	public static void JDMPMFAAMKP(this ILGenerator LJGKGDLFPEA, int DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x41F56D0", Offset = "0x41F3ED0", VA = "0x1841F56D0")]
	public static void JKDNGJIDOAH(this ILGenerator LJGKGDLFPEA, Type MIDEMNGPEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x41F57C0", Offset = "0x41F3FC0", VA = "0x1841F57C0")]
	public static void LPKNNCFMDKC(this ILGenerator LJGKGDLFPEA, Type MIDEMNGPEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x41F4DD0", Offset = "0x41F35D0", VA = "0x1841F4DD0")]
	public static void GPKHALEJKEA(this ILGenerator LJGKGDLFPEA, int MPFAEFMOAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x41F48C0", Offset = "0x41F30C0", VA = "0x1841F48C0")]
	public static void AFJLLCFKMIL(this ILGenerator LJGKGDLFPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x41F4940", Offset = "0x41F3140", VA = "0x1841F4940")]
	public static void BGPJFGDFMIO(this ILGenerator LJGKGDLFPEA, int MPFAEFMOAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x41F4A40", Offset = "0x41F3240", VA = "0x1841F4A40")]
	public static void DEFPBBCCPLL(this ILGenerator LJGKGDLFPEA, MethodInfo HKHKIMGOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x41F5AD0", Offset = "0x41F42D0", VA = "0x1841F5AD0")]
	public static void PKMDDFPPPGF(this ILGenerator LJGKGDLFPEA, FieldInfo OFPPOECKKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x41F4D40", Offset = "0x41F3540", VA = "0x1841F4D40")]
	public static void GOFOCDAOBAD(this ILGenerator LJGKGDLFPEA, ulong DOBKOKNNFGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class HNCOLKCGNKE
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class NDMOCOLBGPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public NDMOCOLBGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2FF43D0", Offset = "0x2FF2BD0", VA = "0x182FF43D0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo DGPDOCDNBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo OMDBLLDBHLG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string KMPNNCBDBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x521490", Offset = "0x51FC90", VA = "0x180521490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string EHOFDEOLIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5214A0", Offset = "0x51FCA0", VA = "0x1805214A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DFMGGACODJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2FE41A0", Offset = "0x2FE29A0", VA = "0x182FE41A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BKAFMEEEBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x521190", Offset = "0x51F990", VA = "0x180521190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x67BE40", Offset = "0x67A640", VA = "0x18067BE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool GNHBIIENJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5211A0", Offset = "0x51F9A0", VA = "0x1805211A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7239A0", Offset = "0x7221A0", VA = "0x1807239A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type IAMIFIPCGNC
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x54A0C0", Offset = "0x5488C0", VA = "0x18054A0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x644A90", Offset = "0x643290", VA = "0x180644A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo DOGANJCPNJK
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x549A30", Offset = "0x548230", VA = "0x180549A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x659540", Offset = "0x657D40", VA = "0x180659540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo BEPJBDBHFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x522010", Offset = "0x520810", VA = "0x180522010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x522020", Offset = "0x520820", VA = "0x180522020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo KPJBJHPPBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x534D70", Offset = "0x533570", VA = "0x180534D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5BBFC0", Offset = "0x5BA7C0", VA = "0x1805BBFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2FE42C0", Offset = "0x2FE2AC0", VA = "0x182FE42C0")]
	protected HNCOLKCGNKE(Type MIDEMNGPEAG, string CBFODBDAPIM, string OLPJCGPGCEK, bool HCLMFHKHHAO, bool FDENIBBNPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2FE41B0", Offset = "0x2FE29B0", VA = "0x182FE41B0")]
	public HNCOLKCGNKE(FieldInfo JPCNLNKGAEI, string CBFODBDAPIM, bool AKJKFBGHDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x2FE4340", Offset = "0x2FE2B40", VA = "0x182FE4340")]
	public HNCOLKCGNKE(PropertyInfo JPCNLNKGAEI, string CBFODBDAPIM, bool AKJKFBGHDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x2FE3FC0", Offset = "0x2FE27C0", VA = "0x182FE3FC0")]
	private static MethodInfo DDHJFDIKCJK(MemberInfo JPCNLNKGAEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1C9F4C0", Offset = "0x1C9DCC0", VA = "0x181C9F4C0")]
	public T NGPKFILBKLD<T>(bool PFGKBAJFNNB) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x2FE3F00", Offset = "0x2FE2700", VA = "0x182FE3F00", Slot = "4")]
	public virtual void ACIKNJNCIGA(ILGenerator LJGKGDLFPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x2FE40E0", Offset = "0x2FE28E0", VA = "0x182FE40E0", Slot = "5")]
	public virtual void FOMBCCLLPMI(ILGenerator LJGKGDLFPEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class CHFBCKGNMEN : HNCOLKCGNKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string JGNDOKBACFO;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x32AF820", Offset = "0x32AE020", VA = "0x1832AF820")]
	public CHFBCKGNMEN(string CBFODBDAPIM, string JGNDOKBACFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x32AF710", Offset = "0x32ADF10", VA = "0x1832AF710", Slot = "4")]
	public override void ACIKNJNCIGA(ILGenerator LJGKGDLFPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x32AF7D0", Offset = "0x32ADFD0", VA = "0x1832AF7D0", Slot = "5")]
	public override void FOMBCCLLPMI(ILGenerator LJGKGDLFPEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class NNEDHLCACMP : HNCOLKCGNKE
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo COIMLBMGNGL;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo LFEKILILIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal OHJGPELPBFN MCDNNONGHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal OHJGPELPBFN OKPOCBFNCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal OHJGPELPBFN KGPBILNFODM;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x41FAAA0", Offset = "0x41F92A0", VA = "0x1841FAAA0")]
	public NNEDHLCACMP(string CBFODBDAPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x41FA3E0", Offset = "0x41F8BE0", VA = "0x1841FA3E0", Slot = "4")]
	public override void ACIKNJNCIGA(ILGenerator LJGKGDLFPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x41FA5B0", Offset = "0x41F8DB0", VA = "0x1841FA5B0", Slot = "5")]
	public override void FOMBCCLLPMI(ILGenerator LJGKGDLFPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x41FA4A0", Offset = "0x41F8CA0", VA = "0x1841FA4A0")]
	public void DLPDPOFOCCI(ILGenerator LJGKGDLFPEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class EIBAIMAAHPD
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type IAMIFIPCGNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x521490", Offset = "0x51FC90", VA = "0x180521490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool CNCECLDKJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x64FBA0", Offset = "0x64E3A0", VA = "0x18064FBA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6B63B0", Offset = "0x6B4BB0", VA = "0x1806B63B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IAEMNEOILKM
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC160", Offset = "0x6FA960", VA = "0x1806FC160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDF0", Offset = "0xD0E5F0", VA = "0x180D0FDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo PFBMIOEPGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x523DF0", Offset = "0x5225F0", VA = "0x180523DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x54BD70", Offset = "0x54A570", VA = "0x18054BD70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public HNCOLKCGNKE[] IKOCKPELAHF
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x54A0C0", Offset = "0x5488C0", VA = "0x18054A0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x644A90", Offset = "0x643290", VA = "0x180644A90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public HNCOLKCGNKE[] MIGMGBJHHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x549A30", Offset = "0x548230", VA = "0x180549A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x659540", Offset = "0x657D40", VA = "0x180659540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x32B7280", Offset = "0x32B5A80", VA = "0x1832B7280")]
	public EIBAIMAAHPD(Type MIDEMNGPEAG, Func<string, string> MHDBJANDBBF, bool AKJKFBGHDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x32B71B0", Offset = "0x32B59B0", VA = "0x1832B71B0")]
	private static bool BJFFPEHFFON(IEnumerator<ConstructorInfo> KNPKCBGFPNJ, ref ConstructorInfo ILGKKOAEAAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct EIKFILLNJAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong INCDAAABAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int NAAPPGENNFE;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x20BC200", Offset = "0x20BAA00", VA = "0x1820BC200")]
	public EIKFILLNJAK(ulong BDOKKCJNCCJ, int GGDODGDHNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x32B8530", Offset = "0x32B6D30", VA = "0x1832B8530")]
	public void EBPOIAAICIE(ref EIKFILLNJAK DKNLIFHKLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x32B8500", Offset = "0x32B6D00", VA = "0x1832B8500")]
	public static EIKFILLNJAK CDAMHMJKGBL(ref EIKFILLNJAK DIDMABCLHLL, ref EIKFILLNJAK DOMNMKJGGGI)
	{
		return default(EIKFILLNJAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x32B8540", Offset = "0x32B6D40", VA = "0x1832B8540")]
	public void GIHHFNNLLKH(ref EIKFILLNJAK DKNLIFHKLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x32B8670", Offset = "0x32B6E70", VA = "0x1832B8670")]
	public static EIKFILLNJAK OMKPOOEHDNP(ref EIKFILLNJAK DIDMABCLHLL, ref EIKFILLNJAK DOMNMKJGGGI)
	{
		return default(EIKFILLNJAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x32B8630", Offset = "0x32B6E30", VA = "0x1832B8630")]
	public void IIFAJHPIGDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x32B85D0", Offset = "0x32B6DD0", VA = "0x1832B85D0")]
	public static EIKFILLNJAK IIFAJHPIGDJ(ref EIKFILLNJAK DIDMABCLHLL)
	{
		return default(EIKFILLNJAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct NIHOBMEFAHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] FFBNFFLLBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int POHBEAAADEA;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7E9810", Offset = "0x7E8010", VA = "0x1807E9810")]
	public NIHOBMEFAHJ(byte[] FFBNFFLLBIL, int LILNOJCGNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x41F98F0", Offset = "0x41F80F0", VA = "0x1841F98F0")]
	public void EIHDNGNFLDA(byte MKAGMJEJDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x41F9AD0", Offset = "0x41F82D0", VA = "0x1841F9AD0")]
	public void IGDJAKGAKLJ(byte[] MKAGMJEJDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x41F9C20", Offset = "0x41F8420", VA = "0x1841F9C20")]
	public void NIPFGGALLOD(byte[] MKAGMJEJDJD, int HGMFCBLCCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x41F9B70", Offset = "0x41F8370", VA = "0x1841F9B70")]
	public void NIPFGGALLOD(byte[] MKAGMJEJDJD, int HIIIFMJFPMD, int HGMFCBLCCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x41F9950", Offset = "0x41F8150", VA = "0x1841F9950")]
	public void FEABLFIEPHL(byte BBFAELNBDJP, int KALABHLPPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x41F99D0", Offset = "0x41F81D0", VA = "0x1841F99D0")]
	public void GLGBPEBFGPO(string MKAGMJEJDJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class NAKPKDCGOOF
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum JHDAALAGIAE
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum EHLHOAAEBBP
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum DINIGJOPMDJ
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
	private static byte[] CNDKPGMBLDI;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] KDKBFFMFACN;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] ANOJKPPBOPL;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] DLGOEGFAJHF;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly DINIGJOPMDJ NNJBDKFEDHI;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char DNCMEGOIHLH;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int BDJBIFHDHBC;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int GJJAGIJLPMN;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] BINHPGMGBMH;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x41F6DA0", Offset = "0x41F55A0", VA = "0x1841F6DA0")]
	private static byte[] APIOHPADDBI(int LGIEDJBGIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x41F8660", Offset = "0x41F6E60", VA = "0x1841F8660")]
	private static byte[] JPEMABAOBAL(int LGIEDJBGIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x41F8440", Offset = "0x41F6C40", VA = "0x1841F8440")]
	public static int HDKGMHJIJKB(ref byte[] FFBNFFLLBIL, int POHBEAAADEA, float DOBKOKNNFGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x41F8550", Offset = "0x41F6D50", VA = "0x1841F8550")]
	public static int HDKGMHJIJKB(ref byte[] FFBNFFLLBIL, int POHBEAAADEA, double DOBKOKNNFGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x41F8AE0", Offset = "0x41F72E0", VA = "0x1841F8AE0")]
	private static bool OMNDCLPIKCB(byte[] FFBNFFLLBIL, int HGMFCBLCCGF, ulong MFPMNCMFFOJ, ulong AKHBKLKDOMI, ulong GFEICEKNCFJ, ulong CEAPLDIAMEL, ulong GPDICGBHPDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x41F8740", Offset = "0x41F6F40", VA = "0x1841F8740")]
	private static void MKGBNOMPPHD(uint DHIHOPKNOMB, int PJLGHIFANEI, out uint CJAIOAEGHMH, out int NIMDEHJBBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x41F6F60", Offset = "0x41F5760", VA = "0x1841F6F60")]
	private static bool CBIDJHHKBJD(EIKFILLNJAK GLKLLNGNIDP, EIKFILLNJAK IHDEFGBHAOB, EIKFILLNJAK GIOADLMONFM, byte[] FFBNFFLLBIL, out int HGMFCBLCCGF, out int DDOBACPCDJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x41F8860", Offset = "0x41F7060", VA = "0x1841F8860")]
	private static bool NLGIEPIJDOE(double PNNIPMMOJMD, JHDAALAGIAE MKIJLPJFOKF, byte[] FFBNFFLLBIL, out int HGMFCBLCCGF, out int DICIOFLGFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x41F6E70", Offset = "0x41F5670", VA = "0x1841F6E70")]
	private static bool BBJCADKHEGO(double PNNIPMMOJMD, JHDAALAGIAE MKIJLPJFOKF, byte[] FFBNFFLLBIL, out int HGMFCBLCCGF, out int FANKHJOIFCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x41F82B0", Offset = "0x41F6AB0", VA = "0x1841F82B0")]
	private static bool GBDBJLBJAFP(double DOBKOKNNFGA, ref NIHOBMEFAHJ LMBJDCMKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x41F79A0", Offset = "0x41F61A0", VA = "0x1841F79A0")]
	private static bool DOHLDLPNFLL(double DOBKOKNNFGA, ref NIHOBMEFAHJ LMBJDCMKHOJ, EHLHOAAEBBP MKIJLPJFOKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x41F7FD0", Offset = "0x41F67D0", VA = "0x1841F7FD0")]
	private static void EGMFDJHDOGL(byte[] EIPLMANDLAM, int HGMFCBLCCGF, int FANKHJOIFCL, int KFPNBGKFOGD, ref NIHOBMEFAHJ LMBJDCMKHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x41F7550", Offset = "0x41F5D50", VA = "0x1841F7550")]
	private static void DIIKFJKICJO(byte[] EIPLMANDLAM, int HGMFCBLCCGF, int GGDODGDHNMG, ref NIHOBMEFAHJ LMBJDCMKHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x41F73B0", Offset = "0x41F5BB0", VA = "0x1841F73B0")]
	private static bool CNFHBJCKDAC(double PNNIPMMOJMD, EHLHOAAEBBP MKIJLPJFOKF, int CFBPJHDMKNL, byte[] GPPMBGPNBLL, out bool IDFDMBFIABA, out int HGMFCBLCCGF, out int HCKJMBFLDJI)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct LDNFAPGLPIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double ECFJBHHGOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong NOKJPGNPBBA;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct LDDJEABLPIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float INCDAAABAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint OOHJENHHMEN;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct ACBNMNEKJLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong BNKDOLLEDCO;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x32A9AE0", Offset = "0x32A82E0", VA = "0x1832A9AE0")]
	public ACBNMNEKJLN(double ECFJBHHGOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x32A9A40", Offset = "0x32A8240", VA = "0x1832A9A40")]
	public ACBNMNEKJLN(EIKFILLNJAK ECFJBHHGOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x32A9770", Offset = "0x32A7F70", VA = "0x1832A9770")]
	public EIKFILLNJAK MHJFPIOJGMP()
	{
		return default(EIKFILLNJAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x32A9990", Offset = "0x32A8190", VA = "0x1832A9990")]
	public EIKFILLNJAK PDDAPKFMNHE()
	{
		return default(EIKFILLNJAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x755FD0", Offset = "0x7547D0", VA = "0x180755FD0")]
	public ulong MBHGNFDINKG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x32A94F0", Offset = "0x32A7CF0", VA = "0x1832A94F0")]
	public double CHLDPEHDEMC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x32A9560", Offset = "0x32A7D60", VA = "0x1832A9560")]
	public double CLMLEDNLNCA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x32A9740", Offset = "0x32A7F40", VA = "0x1832A9740")]
	public int KJNLBLLMDON()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x32A9670", Offset = "0x32A7E70", VA = "0x1832A9670")]
	public ulong KGGHJCMPEKP()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x32A9970", Offset = "0x32A8170", VA = "0x1832A9970")]
	public bool OPMFKNPJPDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x32A94D0", Offset = "0x32A7CD0", VA = "0x1832A94D0")]
	public bool BENIPICBHOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x32A9940", Offset = "0x32A8140", VA = "0x1832A9940")]
	public bool OICNKKEBIOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x32A94A0", Offset = "0x32A7CA0", VA = "0x1832A94A0")]
	public bool ANBGCCENADC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x32A9650", Offset = "0x32A7E50", VA = "0x1832A9650")]
	public int JEFCMGHDPIO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x32A97F0", Offset = "0x32A7FF0", VA = "0x1832A97F0")]
	public void NAADAAMALKL(out EIKFILLNJAK IAEKJDKEGHN, out EIKFILLNJAK BDILMEBANEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x32A9600", Offset = "0x32A7E00", VA = "0x1832A9600")]
	public bool JDGMNJJLPPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x32A95E0", Offset = "0x32A7DE0", VA = "0x1832A95E0")]
	public double DOBKOKNNFGA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x32A9A20", Offset = "0x32A8220", VA = "0x1832A9A20")]
	public static int PLKDPAPKLCH(int NPJLHKODEEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x32A95F0", Offset = "0x32A7DF0", VA = "0x1832A95F0")]
	public static double JCDNGPFCEFP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x32A96A0", Offset = "0x32A7EA0", VA = "0x1832A96A0")]
	public static ulong KHNFDCAKLNN(EIKFILLNJAK MLEGHHHEGNL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct GBAIPLNGMLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint CLGPHPPMFEG;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1D1B560", Offset = "0x1D19D60", VA = "0x181D1B560")]
	public GBAIPLNGMLA(float INCDAAABAJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2FDFD40", Offset = "0x2FDE540", VA = "0x182FDFD40")]
	public EIKFILLNJAK MHJFPIOJGMP()
	{
		return default(EIKFILLNJAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7C6330", Offset = "0x7C4B30", VA = "0x1807C6330")]
	public uint KGKEKINJFFG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2FDFD20", Offset = "0x2FDE520", VA = "0x182FDFD20")]
	public int KJNLBLLMDON()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2FDFD00", Offset = "0x2FDE500", VA = "0x182FDFD00")]
	public uint KGGHJCMPEKP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2FDFF20", Offset = "0x2FDE720", VA = "0x182FDFF20")]
	public bool OPMFKNPJPDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2FDFDB0", Offset = "0x2FDE5B0", VA = "0x182FDFDB0")]
	public void NAADAAMALKL(out EIKFILLNJAK IAEKJDKEGHN, out EIKFILLNJAK BDILMEBANEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2FDFCC0", Offset = "0x2FDE4C0", VA = "0x182FDFCC0")]
	public bool JDGMNJJLPPO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct DLJAMCBDLPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong BDOKKCJNCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short JOLINEBKDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short DICIOFLGFBL;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x32B43D0", Offset = "0x32B2BD0", VA = "0x1832B43D0")]
	public DLJAMCBDLPH(ulong BDOKKCJNCCJ, short JOLINEBKDBH, short DICIOFLGFBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class AGKIHNGCNBD
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly DLJAMCBDLPH[] HBJFKHCOPPI;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x32A9E50", Offset = "0x32A8650", VA = "0x1832A9E50")]
	public static void AKBOLOALNBA(int JNNKDEHIMBB, int IIEDGHHPDON, out EIKFILLNJAK CJAIOAEGHMH, out int DICIOFLGFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x32A9F80", Offset = "0x32A8780", VA = "0x1832A9F80")]
	public static void BMGHIGKGDIN(int OGILKEPJHOB, out EIKFILLNJAK CJAIOAEGHMH, out int MPHOHGENGND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct IDKACLKKKCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] MIIBCOAJABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int HIIIFMJFPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int AKPDPMDCMFP;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte EDFJNANCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2FE5120", Offset = "0x2FE3920", VA = "0x182FE5120")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x915E40", Offset = "0x914640", VA = "0x180915E40")]
	public IDKACLKKKCL(byte[] MIIBCOAJABM, int HIIIFMJFPMD, int HGMFCBLCCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C62F0", Offset = "0x7C4AF0", VA = "0x1807C62F0")]
	public int HGMFCBLCCGF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2FE50C0", Offset = "0x2FE38C0", VA = "0x182FE50C0")]
	public IDKACLKKKCL GFLCEHKBJEG(int BKJECCIDFJL, int EBGIHNODEGJ)
	{
		return default(IDKACLKKKCL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class EMPPKECCPAE
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] BMLNMPKMKEO;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] GGOOFCFKGHN;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int PCPNDFDCMOM;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x32B9E00", Offset = "0x32B8600", VA = "0x1832B9E00")]
	private static byte[] LPDOBLILGHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x32B8AC0", Offset = "0x32B72C0", VA = "0x1832B8AC0")]
	private static IDKACLKKKCL CLGBKCFHINK(IDKACLKKKCL FFBNFFLLBIL)
	{
		return default(IDKACLKKKCL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x32B8B70", Offset = "0x32B7370", VA = "0x1832B8B70")]
	private static IDKACLKKKCL FDGDEJAAEAB(IDKACLKKKCL FFBNFFLLBIL)
	{
		return default(IDKACLKKKCL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x32B9430", Offset = "0x32B7C30", VA = "0x1832B9430")]
	private static void KCICIINMKHL(IDKACLKKKCL FFBNFFLLBIL, int GGDODGDHNMG, byte[] PDBGPHJLPJK, out int BLPDOBIBLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x32B9EE0", Offset = "0x32B86E0", VA = "0x1832B9EE0")]
	private static void OKFHPJKONMO(IDKACLKKKCL FFBNFFLLBIL, int GGDODGDHNMG, byte[] CDOKAOPCFOA, int LONEPHBOHMI, out IDKACLKKKCL BLNMPMPMMPO, out int NBHEBJCPJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x32B8D50", Offset = "0x32B7550", VA = "0x1832B8D50")]
	private static ulong IEKIPLOAMLM(IDKACLKKKCL FFBNFFLLBIL, out int IPEEBKCBHPB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x32B98A0", Offset = "0x32B80A0", VA = "0x1832B98A0")]
	private static void KILNIDJFGKG(IDKACLKKKCL FFBNFFLLBIL, out EIKFILLNJAK IAGHMNJKEGN, out int KHFMDGIMJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x32B94F0", Offset = "0x32B7CF0", VA = "0x1832B94F0")]
	private static bool KHPAACOCDNO(IDKACLKKKCL BLNMPMPMMPO, int GGDODGDHNMG, out double IAGHMNJKEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x32B99D0", Offset = "0x32B81D0", VA = "0x1832B99D0")]
	private static EIKFILLNJAK KLDFPNLJNBO(int GGDODGDHNMG)
	{
		return default(EIKFILLNJAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x32B8DE0", Offset = "0x32B75E0", VA = "0x1832B8DE0")]
	private static bool IKMOKHLKOCA(IDKACLKKKCL FFBNFFLLBIL, int GGDODGDHNMG, out double IAGHMNJKEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x32BA190", Offset = "0x32B8990", VA = "0x1832BA190")]
	private static bool PMKJPPIAPOP(IDKACLKKKCL BLNMPMPMMPO, int GGDODGDHNMG, out double AKKMLJFOFEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x32B8C20", Offset = "0x32B7420", VA = "0x1832B8C20")]
	public static double? HPOBCEAGEEE(IDKACLKKKCL FFBNFFLLBIL, int GGDODGDHNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x32B9B70", Offset = "0x32B8370", VA = "0x1832B9B70")]
	public static float? LFHMPIILGCP(IDKACLKKKCL FFBNFFLLBIL, int GGDODGDHNMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct KEFMJJJICPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] FFBNFFLLBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int POHBEAAADEA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte MPJDHKAGMAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2FF1AE0", Offset = "0x2FF02E0", VA = "0x182FF1AE0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7E9810", Offset = "0x7E8010", VA = "0x1807E9810")]
	public KEFMJJJICPP(byte[] FFBNFFLLBIL, int POHBEAAADEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1B20", Offset = "0x2FF0320", VA = "0x182FF1B20")]
	public static KEFMJJJICPP JPODNJBCOND(KEFMJJJICPP IEFNIJLKNAJ)
	{
		return default(KEFMJJJICPP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1A40", Offset = "0x2FF0240", VA = "0x182FF1A40")]
	public static KEFMJJJICPP GFNNOFBKLGG(KEFMJJJICPP IEFNIJLKNAJ, int HGMFCBLCCGF)
	{
		return default(KEFMJJJICPP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1B30", Offset = "0x2FF0330", VA = "0x182FF1B30")]
	public static int LDMDGADKNOP(KEFMJJJICPP NFKMLPDPPMJ, KEFMJJJICPP DLLGEGNNIDF)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1A20", Offset = "0x2FF0220", VA = "0x182FF1A20")]
	public static bool GDGOPNMJGHA(KEFMJJJICPP NFKMLPDPPMJ, KEFMJJJICPP DLLGEGNNIDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1C10", Offset = "0x2FF0410", VA = "0x182FF1C10")]
	public static bool MJANLOJKCEI(KEFMJJJICPP NFKMLPDPPMJ, KEFMJJJICPP DLLGEGNNIDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2FF19E0", Offset = "0x2FF01E0", VA = "0x182FF19E0")]
	public static bool GDGOPNMJGHA(KEFMJJJICPP NFKMLPDPPMJ, char DLLGEGNNIDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1BD0", Offset = "0x2FF03D0", VA = "0x182FF1BD0")]
	public static bool MJANLOJKCEI(KEFMJJJICPP NFKMLPDPPMJ, char DLLGEGNNIDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1BD0", Offset = "0x2FF03D0", VA = "0x182FF1BD0")]
	public static bool MJANLOJKCEI(KEFMJJJICPP NFKMLPDPPMJ, byte DLLGEGNNIDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1AA0", Offset = "0x2FF02A0", VA = "0x182FF1AA0")]
	public static bool GKCMLBNDPHP(KEFMJJJICPP NFKMLPDPPMJ, char DLLGEGNNIDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1B90", Offset = "0x2FF0390", VA = "0x182FF1B90")]
	public static bool MADHPFAOGEL(KEFMJJJICPP NFKMLPDPPMJ, char DLLGEGNNIDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x2FF19A0", Offset = "0x2FF01A0", VA = "0x182FF19A0")]
	public static bool FBBAJBGADLN(KEFMJJJICPP NFKMLPDPPMJ, char DLLGEGNNIDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1B50", Offset = "0x2FF0350", VA = "0x182FF1B50")]
	public static bool LMKMINMODGJ(KEFMJJJICPP NFKMLPDPPMJ, char DLLGEGNNIDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class CMBAFEGBGMN
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] KENCOIPAKCE;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] NLJPBLEJEIH;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] ANOJKPPBOPL;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] DLGOEGFAJHF;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] IKCMPMCMCOE;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int OIFJGJLDKBB;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] BMNOKFKEIFP;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int OLPFOPNFAME;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x32B1A00", Offset = "0x32B0200", VA = "0x1832B1A00")]
	private static byte[] MKHAIGEADOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x32B1BF0", Offset = "0x32B03F0", VA = "0x1832B1BF0")]
	private static byte[] PNAKDCECIMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x32B1AE0", Offset = "0x32B02E0", VA = "0x1832B1AE0")]
	public static double OLPCADMAIGH(byte[] FFBNFFLLBIL, int POHBEAAADEA, out int FNLBELEPJBG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x32B1940", Offset = "0x32B0140", VA = "0x1832B1940")]
	public static float KCDJJEKEKFP(byte[] FFBNFFLLBIL, int POHBEAAADEA, out int FNLBELEPJBG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x32B16B0", Offset = "0x32AFEB0", VA = "0x1832B16B0")]
	private static bool JAAJFOLNDJL(int DNCFOPMJGLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x32B1590", Offset = "0x32AFD90", VA = "0x1832B1590")]
	private static bool FGEFPFBMIFN(ref KEFMJJJICPP ADAPMBEBCHI, KEFMJJJICPP IIOPPGEOJON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x32B1830", Offset = "0x32B0030", VA = "0x1832B1830")]
	private static bool JFEKCPBOBPK(ref KEFMJJJICPP ADAPMBEBCHI, KEFMJJJICPP IIOPPGEOJON, byte[] AKADOENOJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x32B1BA0", Offset = "0x32B03A0", VA = "0x1832B1BA0")]
	private static bool PBCAGIAJIEN(ref KEFMJJJICPP JGEHADFGNCJ, byte[] MKAGMJEJDJD, int POHBEAAADEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xDC69B0", Offset = "0xDC51B0", VA = "0x180DC69B0")]
	private static double AJPJHFEJJHN(bool IDFDMBFIABA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x32B03D0", Offset = "0x32AEBD0", VA = "0x1832B03D0")]
	private static double FFLAOMBAGFE(KEFMJJJICPP MBAADKJMFBL, int HGMFCBLCCGF, bool MJEBBABHLJB, out int BMJCKIBIIDK)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class NHIOPEIFNPA<T> : global::IEMBFIJKPHO<T[]>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::FEDMELOEICG<T> HKBBECNICDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly HIMOMLGKNJJ HDKMLMAHEKH;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1C13570", Offset = "0x1C11D70", VA = "0x181C13570")]
	public NHIOPEIFNPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1AF95D0", Offset = "0x1AF7DD0", VA = "0x181AF95D0")]
	public NHIOPEIFNPA(HIMOMLGKNJJ HDKMLMAHEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x1C10C40", Offset = "0x1C0F440", VA = "0x181C10C40", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, T[] DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x1C11B10", Offset = "0x1C10310", VA = "0x181C11B10", Slot = "5")]
	public T[] FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class OODFFDKFBOM<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::FEDMELOEICG<T> HKBBECNICDF;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class MBPDDNMHFNN<T> : global::IEMBFIJKPHO<List<T>>, GEHOIAKHNGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly HIMOMLGKNJJ HDKMLMAHEKH;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x1C13570", Offset = "0x1C11D70", VA = "0x181C13570")]
	public MBPDDNMHFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1AF95D0", Offset = "0x1AF7DD0", VA = "0x181AF95D0")]
	public MBPDDNMHFNN(HIMOMLGKNJJ HDKMLMAHEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x26A9670", Offset = "0x26A7E70", VA = "0x1826A9670", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, List<T> DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x26A9CD0", Offset = "0x26A84D0", VA = "0x1826A9CD0", Slot = "5")]
	public List<T> FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class PNGDGHGIFAL<TElement, TIntermediate, TEnumerator, TCollection> : global::IEMBFIJKPHO<TCollection>, GEHOIAKHNGG where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3C7CB00", Offset = "0x3C7B300", VA = "0x183C7CB00", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, TCollection DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3C7DFB0", Offset = "0x3C7C7B0", VA = "0x183C7DFB0", Slot = "5")]
	public TCollection FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator NNOBDDEDHIK(TCollection GGMOHJBJDOM);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate OGMFEGPOBPM();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void EFDMEADFFJF(ref TIntermediate CIKPGADKADH, int MPFAEFMOAIE, TElement DOBKOKNNFGA);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection HOCHBDLCMIE(ref TIntermediate JPCBIJIOAFO);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
	protected PNGDGHGIFAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class FBPMEMHCJIC<TElement, TIntermediate, TCollection> : global::PNGDGHGIFAL<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2B1E310", Offset = "0x2B1CB10", VA = "0x182B1E310", Slot = "6")]
	protected override IEnumerator<TElement> NNOBDDEDHIK(TCollection GGMOHJBJDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1AFC610", Offset = "0x1AFAE10", VA = "0x181AFC610")]
	protected FBPMEMHCJIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class KKBOLLLLPGM<TElement, TCollection> : global::FBPMEMHCJIC<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x1383AA0", Offset = "0x13822A0", VA = "0x181383AA0", Slot = "9")]
	protected sealed override TCollection HOCHBDLCMIE(ref TCollection JPCBIJIOAFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class AONGIEKJNKM<TElement, TCollection> : global::KKBOLLLLPGM<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x24BB920", Offset = "0x24BA120", VA = "0x1824BB920", Slot = "7")]
	protected override TCollection OGMFEGPOBPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x24BB8B0", Offset = "0x24BA0B0", VA = "0x1824BB8B0", Slot = "8")]
	protected override void EFDMEADFFJF(ref TCollection CIKPGADKADH, int MPFAEFMOAIE, TElement DOBKOKNNFGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class OFGKHFCJPHH<T> : global::PNGDGHGIFAL<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x26A9190", Offset = "0x26A7990", VA = "0x1826A9190", Slot = "8")]
	protected override void EFDMEADFFJF(ref LinkedList<T> CIKPGADKADH, int MPFAEFMOAIE, T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x1383AA0", Offset = "0x13822A0", VA = "0x181383AA0", Slot = "9")]
	protected override LinkedList<T> HOCHBDLCMIE(ref LinkedList<T> JPCBIJIOAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x26A91D0", Offset = "0x26A79D0", VA = "0x1826A91D0", Slot = "7")]
	protected override LinkedList<T> OGMFEGPOBPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x332A680", Offset = "0x3328E80", VA = "0x18332A680", Slot = "6")]
	protected override LinkedList<T>.Enumerator NNOBDDEDHIK(LinkedList<T> GGMOHJBJDOM)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class KHDHKFJHDIC<T> : global::PNGDGHGIFAL<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x26A9190", Offset = "0x26A7990", VA = "0x1826A9190", Slot = "8")]
	protected override void EFDMEADFFJF(ref Queue<T> CIKPGADKADH, int MPFAEFMOAIE, T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x26A91D0", Offset = "0x26A79D0", VA = "0x1826A91D0", Slot = "7")]
	protected override Queue<T> OGMFEGPOBPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x22CC120", Offset = "0x22CA920", VA = "0x1822CC120", Slot = "6")]
	protected override Queue<T>.Enumerator NNOBDDEDHIK(Queue<T> GGMOHJBJDOM)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x1383AA0", Offset = "0x13822A0", VA = "0x181383AA0", Slot = "9")]
	protected override Queue<T> HOCHBDLCMIE(ref Queue<T> JPCBIJIOAFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class LCCAKHAODNG<T> : global::PNGDGHGIFAL<T, global::KEMBFHAPNMO<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x22CC010", Offset = "0x22CA810", VA = "0x1822CC010", Slot = "8")]
	protected override void EFDMEADFFJF(ref global::KEMBFHAPNMO<T> CIKPGADKADH, int MPFAEFMOAIE, T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x22CC170", Offset = "0x22CA970", VA = "0x1822CC170", Slot = "7")]
	protected override global::KEMBFHAPNMO<T> OGMFEGPOBPM()
	{
		return default(global::KEMBFHAPNMO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x22CC120", Offset = "0x22CA920", VA = "0x1822CC120", Slot = "6")]
	protected override Stack<T>.Enumerator NNOBDDEDHIK(Stack<T> GGMOHJBJDOM)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x22CC040", Offset = "0x22CA840", VA = "0x1822CC040", Slot = "9")]
	protected override Stack<T> HOCHBDLCMIE(ref global::KEMBFHAPNMO<T> JPCBIJIOAFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class MBGLFPCMEKK<T> : global::PNGDGHGIFAL<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x26A9190", Offset = "0x26A7990", VA = "0x1826A9190", Slot = "8")]
	protected override void EFDMEADFFJF(ref HashSet<T> CIKPGADKADH, int MPFAEFMOAIE, T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x1383AA0", Offset = "0x13822A0", VA = "0x181383AA0", Slot = "9")]
	protected override HashSet<T> HOCHBDLCMIE(ref HashSet<T> JPCBIJIOAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x26A91D0", Offset = "0x26A79D0", VA = "0x1826A91D0", Slot = "7")]
	protected override HashSet<T> OGMFEGPOBPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x22CC120", Offset = "0x22CA920", VA = "0x1822CC120", Slot = "6")]
	protected override HashSet<T>.Enumerator NNOBDDEDHIK(HashSet<T> GGMOHJBJDOM)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class MMAOOIMDCCL<T> : global::FBPMEMHCJIC<T, global::KEMBFHAPNMO<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x22CC010", Offset = "0x22CA810", VA = "0x1822CC010", Slot = "8")]
	protected override void EFDMEADFFJF(ref global::KEMBFHAPNMO<T> CIKPGADKADH, int MPFAEFMOAIE, T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F370", Offset = "0x2B7DB70", VA = "0x182B7F370", Slot = "9")]
	protected override ReadOnlyCollection<T> HOCHBDLCMIE(ref global::KEMBFHAPNMO<T> JPCBIJIOAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F400", Offset = "0x2B7DC00", VA = "0x182B7F400", Slot = "7")]
	protected override global::KEMBFHAPNMO<T> OGMFEGPOBPM()
	{
		return default(global::KEMBFHAPNMO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class DHJNECLMBDG<T> : global::FBPMEMHCJIC<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x26A9190", Offset = "0x26A7990", VA = "0x1826A9190", Slot = "8")]
	protected override void EFDMEADFFJF(ref List<T> CIKPGADKADH, int MPFAEFMOAIE, T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x26A91D0", Offset = "0x26A79D0", VA = "0x1826A91D0", Slot = "7")]
	protected override List<T> OGMFEGPOBPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x1383AA0", Offset = "0x13822A0", VA = "0x181383AA0", Slot = "9")]
	protected override IList<T> HOCHBDLCMIE(ref List<T> JPCBIJIOAFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class BNOEFFOBIAA<T> : global::FBPMEMHCJIC<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x26A9190", Offset = "0x26A7990", VA = "0x1826A9190", Slot = "8")]
	protected override void EFDMEADFFJF(ref List<T> CIKPGADKADH, int MPFAEFMOAIE, T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x26A91D0", Offset = "0x26A79D0", VA = "0x1826A91D0", Slot = "7")]
	protected override List<T> OGMFEGPOBPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x1383AA0", Offset = "0x13822A0", VA = "0x181383AA0", Slot = "9")]
	protected override ICollection<T> HOCHBDLCMIE(ref List<T> JPCBIJIOAFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class MPBLFAILMCJ<T> : global::FBPMEMHCJIC<T, global::KEMBFHAPNMO<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x22CC010", Offset = "0x22CA810", VA = "0x1822CC010", Slot = "8")]
	protected override void EFDMEADFFJF(ref global::KEMBFHAPNMO<T> CIKPGADKADH, int MPFAEFMOAIE, T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x22CC170", Offset = "0x22CA970", VA = "0x1822CC170", Slot = "7")]
	protected override global::KEMBFHAPNMO<T> OGMFEGPOBPM()
	{
		return default(global::KEMBFHAPNMO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2B80300", Offset = "0x2B7EB00", VA = "0x182B80300", Slot = "9")]
	protected override IEnumerable<T> HOCHBDLCMIE(ref global::KEMBFHAPNMO<T> JPCBIJIOAFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class PGLANNDJHFB<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class CCBMJDONNGH<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class GPLNGHFAMIJ<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class FKBEBLJBJAP : global::IEMBFIJKPHO<IEnumerable>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::IEMBFIJKPHO<IEnumerable> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x32BEE20", Offset = "0x32BD620", VA = "0x1832BEE20", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, IEnumerable DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x32BF080", Offset = "0x32BD880", VA = "0x1832BF080", Slot = "5")]
	public IEnumerable FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public FKBEBLJBJAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class BCNNBOIAHAD : global::IEMBFIJKPHO<ICollection>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::IEMBFIJKPHO<ICollection> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x32ADB20", Offset = "0x32AC320", VA = "0x1832ADB20", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, ICollection DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x32ADE80", Offset = "0x32AC680", VA = "0x1832ADE80", Slot = "5")]
	public ICollection FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public BCNNBOIAHAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class GHIHLIPHNGM : global::IEMBFIJKPHO<IList>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::IEMBFIJKPHO<IList> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2FE1D40", Offset = "0x2FE0540", VA = "0x182FE1D40", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, IList DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2FE1FE0", Offset = "0x2FE07E0", VA = "0x182FE1FE0", Slot = "5")]
	public IList FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public GHIHLIPHNGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class OKECBBCEHPG<T> : global::FBPMEMHCJIC<T, global::KEMBFHAPNMO<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3335AD0", Offset = "0x33342D0", VA = "0x183335AD0", Slot = "8")]
	protected override void EFDMEADFFJF(ref global::KEMBFHAPNMO<T> CIKPGADKADH, int MPFAEFMOAIE, T DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x22CC170", Offset = "0x22CA970", VA = "0x1822CC170", Slot = "7")]
	protected override global::KEMBFHAPNMO<T> OGMFEGPOBPM()
	{
		return default(global::KEMBFHAPNMO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3335B10", Offset = "0x3334310", VA = "0x183335B10", Slot = "9")]
	protected override IReadOnlyList<T> HOCHBDLCMIE(ref global::KEMBFHAPNMO<T> JPCBIJIOAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1AFE3E0", Offset = "0x1AFCBE0", VA = "0x181AFE3E0")]
	public OKECBBCEHPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class NMNGMDMMAIA
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x41FA340", Offset = "0x41F8B40", VA = "0x1841FA340")]
	public static DateTime CJGAPIECGJA(DateTime HABEMLOKFEL)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class JHENHKMKFLE : global::IEMBFIJKPHO<DateTime>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::IEMBFIJKPHO<DateTime> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x2FE7D50", Offset = "0x2FE6550", VA = "0x182FE7D50", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, DateTime DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2FE81A0", Offset = "0x2FE69A0", VA = "0x182FE81A0", Slot = "5")]
	public DateTime FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public JHENHKMKFLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class HDLJKLDCMLM : global::IEMBFIJKPHO<DateTimeOffset>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::IEMBFIJKPHO<DateTimeOffset> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2FE2930", Offset = "0x2FE1130", VA = "0x182FE2930", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, DateTimeOffset DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2FE2D00", Offset = "0x2FE1500", VA = "0x182FE2D00", Slot = "5")]
	public DateTimeOffset FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public HDLJKLDCMLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class KKAMOJCMNJN : global::IEMBFIJKPHO<TimeSpan>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::IEMBFIJKPHO<TimeSpan> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] AABJNJKGBEM;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2FF2240", Offset = "0x2FF0A40", VA = "0x182FF2240", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, TimeSpan DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2FF2500", Offset = "0x2FF0D00", VA = "0x182FF2500", Slot = "5")]
	public TimeSpan FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public KKAMOJCMNJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class FAAPFEBHNMI<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::IEMBFIJKPHO<TDictionary>, GEHOIAKHNGG where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x324D2D0", Offset = "0x324BAD0", VA = "0x18324D2D0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, TDictionary DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x32506A0", Offset = "0x324EEA0", VA = "0x1832506A0", Slot = "5")]
	public TDictionary FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator NNOBDDEDHIK(TDictionary GGMOHJBJDOM);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate OGMFEGPOBPM();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void EFDMEADFFJF(ref TIntermediate CIKPGADKADH, int MPFAEFMOAIE, TKey MHAAPGJKGCK, TValue DOBKOKNNFGA);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary HOCHBDLCMIE(ref TIntermediate JPCBIJIOAFO);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
	protected FAAPFEBHNMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class KIGIGOPENOP<TKey, TValue, TIntermediate, TDictionary> : global::FAAPFEBHNMI<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2B1E310", Offset = "0x2B1CB10", VA = "0x182B1E310", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> NNOBDDEDHIK(TDictionary GGMOHJBJDOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class AKMCPCBMCJO<TKey, TValue, TDictionary> : global::KIGIGOPENOP<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x1383AA0", Offset = "0x13822A0", VA = "0x181383AA0", Slot = "9")]
	protected override TDictionary HOCHBDLCMIE(ref TDictionary JPCBIJIOAFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class DJBJPEAKOIL<TKey, TValue> : global::FAAPFEBHNMI<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F680", Offset = "0x3A3DE80", VA = "0x183A3F680", Slot = "8")]
	protected override void EFDMEADFFJF(ref Dictionary<TKey, TValue> CIKPGADKADH, int MPFAEFMOAIE, TKey MHAAPGJKGCK, TValue DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x1383AA0", Offset = "0x13822A0", VA = "0x181383AA0", Slot = "9")]
	protected override Dictionary<TKey, TValue> HOCHBDLCMIE(ref Dictionary<TKey, TValue> JPCBIJIOAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x26A91D0", Offset = "0x26A79D0", VA = "0x1826A91D0", Slot = "7")]
	protected override Dictionary<TKey, TValue> OGMFEGPOBPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F6C0", Offset = "0x3A3DEC0", VA = "0x183A3F6C0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator NNOBDDEDHIK(Dictionary<TKey, TValue> GGMOHJBJDOM)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1B07490", Offset = "0x1B05C90", VA = "0x181B07490")]
	public DJBJPEAKOIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class OHMECGLCOOJ<TKey, TValue, TDictionary> : global::AKMCPCBMCJO<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x332AD30", Offset = "0x3329530", VA = "0x18332AD30", Slot = "8")]
	protected override void EFDMEADFFJF(ref TDictionary CIKPGADKADH, int MPFAEFMOAIE, TKey MHAAPGJKGCK, TValue DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x332AE10", Offset = "0x3329610", VA = "0x18332AE10", Slot = "7")]
	protected override TDictionary OGMFEGPOBPM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class PLAKDNKHDBD<TKey, TValue> : global::KIGIGOPENOP<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F640", Offset = "0x3A3DE40", VA = "0x183A3F640", Slot = "8")]
	protected override void EFDMEADFFJF(ref Dictionary<TKey, TValue> CIKPGADKADH, int MPFAEFMOAIE, TKey MHAAPGJKGCK, TValue DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x26A91D0", Offset = "0x26A79D0", VA = "0x1826A91D0", Slot = "7")]
	protected override Dictionary<TKey, TValue> OGMFEGPOBPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x1383AA0", Offset = "0x13822A0", VA = "0x181383AA0", Slot = "9")]
	protected override IDictionary<TKey, TValue> HOCHBDLCMIE(ref Dictionary<TKey, TValue> JPCBIJIOAFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class HCNFCAKIECI<TKey, TValue> : global::AKMCPCBMCJO<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F640", Offset = "0x3A3DE40", VA = "0x183A3F640", Slot = "8")]
	protected override void EFDMEADFFJF(ref SortedList<TKey, TValue> CIKPGADKADH, int MPFAEFMOAIE, TKey MHAAPGJKGCK, TValue DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x26A91D0", Offset = "0x26A79D0", VA = "0x1826A91D0", Slot = "7")]
	protected override SortedList<TKey, TValue> OGMFEGPOBPM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class NBCPCNCHDLP<TKey, TValue> : global::FAAPFEBHNMI<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F640", Offset = "0x3A3DE40", VA = "0x183A3F640", Slot = "8")]
	protected override void EFDMEADFFJF(ref SortedDictionary<TKey, TValue> CIKPGADKADH, int MPFAEFMOAIE, TKey MHAAPGJKGCK, TValue DOBKOKNNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x1383AA0", Offset = "0x13822A0", VA = "0x181383AA0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> HOCHBDLCMIE(ref SortedDictionary<TKey, TValue> JPCBIJIOAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x26A91D0", Offset = "0x26A79D0", VA = "0x1826A91D0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> OGMFEGPOBPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x437ABF0", Offset = "0x43793F0", VA = "0x18437ABF0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator NNOBDDEDHIK(SortedDictionary<TKey, TValue> GGMOHJBJDOM)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class OLKAJOLKKKN<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class DBEDKLLIPOE : global::IEMBFIJKPHO<IDictionary>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::IEMBFIJKPHO<IDictionary> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x32B24D0", Offset = "0x32B0CD0", VA = "0x1832B24D0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, IDictionary DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x32B2960", Offset = "0x32B1160", VA = "0x1832B2960", Slot = "5")]
	public IDictionary FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public DBEDKLLIPOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class JCDGMCFNBOJ : global::IEMBFIJKPHO<object>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void DCMCFDALJOI(object EHLGJMGBGII, ref FGEHJBFCCPO MNFKPJJAJNI, object DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::PDFHKEIKHOP<KeyValuePair<object, DCMCFDALJOI>> PIOAHMPDBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly INLBFPHKJMK[] LFOIIOIJNLJ;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2FE6480", Offset = "0x2FE4C80", VA = "0x182FE6480")]
	public JCDGMCFNBOJ(params INLBFPHKJMK[] LFOIIOIJNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5C20", Offset = "0x2FE4420", VA = "0x182FE5C20", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, object DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2FE63F0", Offset = "0x2FE4BF0", VA = "0x182FE63F0", Slot = "5")]
	public object FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class CAKCOJJPHIF
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x32AECB0", Offset = "0x32AD4B0", VA = "0x1832AECB0")]
	public static object OCAEJKLEMDC(Type MIDEMNGPEAG, out bool CNMHJJCFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x32AE4D0", Offset = "0x32ACCD0", VA = "0x1832AE4D0")]
	public static object CALNEINKFIB(Type MIDEMNGPEAG, out bool CNMHJJCFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class BOFKMINHKCC<T> : global::IEMBFIJKPHO<T>, GEHOIAKHNGG, global::ECBIDLALAJO<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class GLCCFPBGBGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public GLCCFPBGBGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x36BDBC0", Offset = "0x36BC3C0", VA = "0x1836BDBC0")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class ELNKPJCOMKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::PDHKNHNFMAB<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public ELNKPJCOMKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x36BC690", Offset = "0x36BAE90", VA = "0x1836BC690")]
		internal void <.cctor>b__1(ref FGEHJBFCCPO writer, T value, INLBFPHKJMK _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class KANMGMMABDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::MGJLFCCDBAO<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public KANMGMMABDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x36C1430", Offset = "0x36BFC30", VA = "0x1836C1430")]
		internal T <.cctor>b__2(ref FJJCAGOJJPJ reader, INLBFPHKJMK _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::EEKEGGBKIKK<T> JKAFPGBDCHB;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> MCFEGMFAHFG;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::PDHKNHNFMAB<T> BJNMIJNDLEM;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::MGJLFCCDBAO<T> KKFNPMHJAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool KDACFNMCHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::PDHKNHNFMAB<T> PHCKENGMLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::MGJLFCCDBAO<T> FCPFCLLDOHD;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x36B6B30", Offset = "0x36B5330", VA = "0x1836B6B30")]
	static BOFKMINHKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x35A2E60", Offset = "0x35A1660", VA = "0x1835A2E60")]
	public BOFKMINHKCC(bool KDACFNMCHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x36B64D0", Offset = "0x36B4CD0", VA = "0x1836B64D0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, T DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x36B66A0", Offset = "0x36B4EA0", VA = "0x1836B66A0", Slot = "5")]
	public T FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3594C40", Offset = "0x3593440", VA = "0x183594C40", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, T DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x36B69E0", Offset = "0x36B51E0", VA = "0x1836B69E0", Slot = "7")]
	public T PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class GDEAPADLBPJ<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class GMGGBEAGODE<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class OBEHCPKJGIJ<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class CGOMAFHNIDK<T> : global::IEMBFIJKPHO<T?>, GEHOIAKHNGG where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x36EBBF0", Offset = "0x36EA3F0", VA = "0x1836EBBF0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, T? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x36EBE80", Offset = "0x36EA680", VA = "0x1836EBE80", Slot = "5")]
	public T? FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
	public CGOMAFHNIDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class KLGAAFMBJBI<T> : global::IEMBFIJKPHO<T?>, GEHOIAKHNGG where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::IEMBFIJKPHO<T> BJPONPJLOJB;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x21260B0", Offset = "0x21248B0", VA = "0x1821260B0")]
	public KLGAAFMBJBI(global::IEMBFIJKPHO<T> BJPONPJLOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2B1EF30", Offset = "0x2B1D730", VA = "0x182B1EF30", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, T? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F460", Offset = "0x2B1DC60", VA = "0x182B1F460", Slot = "5")]
	public T? FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class GINKFBJHJCI : global::IEMBFIJKPHO<sbyte>, GEHOIAKHNGG, global::ECBIDLALAJO<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly GINKFBJHJCI LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2FE25B0", Offset = "0x2FE0DB0", VA = "0x182FE25B0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, sbyte DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2FE25D0", Offset = "0x2FE0DD0", VA = "0x182FE25D0", Slot = "5")]
	public sbyte FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2FE2570", Offset = "0x2FE0D70", VA = "0x182FE2570", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, sbyte DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2FE25E0", Offset = "0x2FE0DE0", VA = "0x182FE25E0", Slot = "7")]
	public sbyte PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public GINKFBJHJCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class FLOAICHJFJM : global::IEMBFIJKPHO<sbyte?>, GEHOIAKHNGG, global::ECBIDLALAJO<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly FLOAICHJFJM LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x32BF5F0", Offset = "0x32BDDF0", VA = "0x1832BF5F0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, sbyte? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x32BF670", Offset = "0x32BDE70", VA = "0x1832BF670", Slot = "5")]
	public sbyte? FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x32BF4F0", Offset = "0x32BDCF0", VA = "0x1832BF4F0", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, sbyte? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x32BF720", Offset = "0x32BDF20", VA = "0x1832BF720", Slot = "7")]
	public sbyte? PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public FLOAICHJFJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class ELJHNKEONLH : global::IEMBFIJKPHO<sbyte[]>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly ELJHNKEONLH LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x32B8720", Offset = "0x32B6F20", VA = "0x1832B8720", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, sbyte[] DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x32B88C0", Offset = "0x32B70C0", VA = "0x1832B88C0", Slot = "5")]
	public sbyte[] FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public ELJHNKEONLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class KPNLGEKCLNM : global::IEMBFIJKPHO<short>, GEHOIAKHNGG, global::ECBIDLALAJO<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly KPNLGEKCLNM LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x41F3830", Offset = "0x41F2030", VA = "0x1841F3830", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, short DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x41F3850", Offset = "0x41F2050", VA = "0x1841F3850", Slot = "5")]
	public short FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x41F37F0", Offset = "0x41F1FF0", VA = "0x1841F37F0", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, short DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x41F3860", Offset = "0x41F2060", VA = "0x1841F3860", Slot = "7")]
	public short PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public KPNLGEKCLNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class LFDKCLFGAMP : global::IEMBFIJKPHO<short?>, GEHOIAKHNGG, global::ECBIDLALAJO<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly LFDKCLFGAMP LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x41F40D0", Offset = "0x41F28D0", VA = "0x1841F40D0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, short? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x41F4140", Offset = "0x41F2940", VA = "0x1841F4140", Slot = "5")]
	public short? FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x41F4050", Offset = "0x41F2850", VA = "0x1841F4050", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, short? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x41F41B0", Offset = "0x41F29B0", VA = "0x1841F41B0", Slot = "7")]
	public short? PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public LFDKCLFGAMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class DJFLOEPIAOC : global::IEMBFIJKPHO<short[]>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly DJFLOEPIAOC LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x32B4030", Offset = "0x32B2830", VA = "0x1832B4030", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, short[] DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x32B41D0", Offset = "0x32B29D0", VA = "0x1832B41D0", Slot = "5")]
	public short[] FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public DJFLOEPIAOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class FLIHBBFCJAB : global::IEMBFIJKPHO<int>, GEHOIAKHNGG, global::ECBIDLALAJO<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly FLIHBBFCJAB LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x32BF390", Offset = "0x32BDB90", VA = "0x1832BF390", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, int DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x32BF3C0", Offset = "0x32BDBC0", VA = "0x1832BF3C0", Slot = "5")]
	public int FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x32BF2D0", Offset = "0x32BDAD0", VA = "0x1832BF2D0", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, int DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x32BF420", Offset = "0x32BDC20", VA = "0x1832BF420", Slot = "7")]
	public int PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public FLIHBBFCJAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class LKBNAEJBIBP : global::IEMBFIJKPHO<int?>, GEHOIAKHNGG, global::ECBIDLALAJO<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly LKBNAEJBIBP LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x41F5BE0", Offset = "0x41F43E0", VA = "0x1841F5BE0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, int? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x41F5C50", Offset = "0x41F4450", VA = "0x1841F5C50", Slot = "5")]
	public int? FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x41F5B60", Offset = "0x41F4360", VA = "0x1841F5B60", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, int? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x41F5CC0", Offset = "0x41F44C0", VA = "0x1841F5CC0", Slot = "7")]
	public int? PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public LKBNAEJBIBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class FJNONADHPFC : global::IEMBFIJKPHO<int[]>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly FJNONADHPFC LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x32BEA80", Offset = "0x32BD280", VA = "0x1832BEA80", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, int[] DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x32BEC20", Offset = "0x32BD420", VA = "0x1832BEC20", Slot = "5")]
	public int[] FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public FJNONADHPFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class LIANKMNCOJM : global::IEMBFIJKPHO<long>, GEHOIAKHNGG, global::ECBIDLALAJO<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly LIANKMNCOJM LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x41F45C0", Offset = "0x41F2DC0", VA = "0x1841F45C0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, long DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x41F45E0", Offset = "0x41F2DE0", VA = "0x1841F45E0", Slot = "5")]
	public long FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x41F4580", Offset = "0x41F2D80", VA = "0x1841F4580", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, long DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x41F45F0", Offset = "0x41F2DF0", VA = "0x1841F45F0", Slot = "7")]
	public long PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public LIANKMNCOJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class NKHJMOIBCNO : global::IEMBFIJKPHO<long?>, GEHOIAKHNGG, global::ECBIDLALAJO<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly NKHJMOIBCNO LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x41F9FE0", Offset = "0x41F87E0", VA = "0x1841F9FE0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, long? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x41FA050", Offset = "0x41F8850", VA = "0x1841FA050", Slot = "5")]
	public long? FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x41F9F60", Offset = "0x41F8760", VA = "0x1841F9F60", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, long? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x41FA0E0", Offset = "0x41F88E0", VA = "0x1841FA0E0", Slot = "7")]
	public long? PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public NKHJMOIBCNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class ODJDOFJAPID : global::IEMBFIJKPHO<long[]>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly ODJDOFJAPID LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x41FCDE0", Offset = "0x41FB5E0", VA = "0x1841FCDE0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, long[] DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x41FCEA0", Offset = "0x41FB6A0", VA = "0x1841FCEA0", Slot = "5")]
	public long[] FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public ODJDOFJAPID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class KOIKABCPNPE : global::IEMBFIJKPHO<byte>, GEHOIAKHNGG, global::ECBIDLALAJO<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly KOIKABCPNPE LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x41F36C0", Offset = "0x41F1EC0", VA = "0x1841F36C0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, byte DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x41F36E0", Offset = "0x41F1EE0", VA = "0x1841F36E0", Slot = "5")]
	public byte FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x41F3680", Offset = "0x41F1E80", VA = "0x1841F3680", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, byte DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x41F36F0", Offset = "0x41F1EF0", VA = "0x1841F36F0", Slot = "7")]
	public byte PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public KOIKABCPNPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class LFHBFKEAOJD : global::IEMBFIJKPHO<byte?>, GEHOIAKHNGG, global::ECBIDLALAJO<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly LFHBFKEAOJD LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x41F4360", Offset = "0x41F2B60", VA = "0x1841F4360", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, byte? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x41F43D0", Offset = "0x41F2BD0", VA = "0x1841F43D0", Slot = "5")]
	public byte? FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x41F42E0", Offset = "0x41F2AE0", VA = "0x1841F42E0", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, byte? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x41F4440", Offset = "0x41F2C40", VA = "0x1841F4440", Slot = "7")]
	public byte? PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public LFHBFKEAOJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class NALOJMFOBPN : global::IEMBFIJKPHO<ushort>, GEHOIAKHNGG, global::ECBIDLALAJO<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly NALOJMFOBPN LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x41F8DE0", Offset = "0x41F75E0", VA = "0x1841F8DE0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, ushort DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x41F8E00", Offset = "0x41F7600", VA = "0x1841F8E00", Slot = "5")]
	public ushort FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x41F8DA0", Offset = "0x41F75A0", VA = "0x1841F8DA0", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, ushort DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x41F8E10", Offset = "0x41F7610", VA = "0x1841F8E10", Slot = "7")]
	public ushort PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public NALOJMFOBPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class LOOMFFGNBHD : global::IEMBFIJKPHO<ushort?>, GEHOIAKHNGG, global::ECBIDLALAJO<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly LOOMFFGNBHD LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x41F65A0", Offset = "0x41F4DA0", VA = "0x1841F65A0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, ushort? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x41F6610", Offset = "0x41F4E10", VA = "0x1841F6610", Slot = "5")]
	public ushort? FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x41F6520", Offset = "0x41F4D20", VA = "0x1841F6520", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, ushort? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x41F6680", Offset = "0x41F4E80", VA = "0x1841F6680", Slot = "7")]
	public ushort? PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public LOOMFFGNBHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class PNCBELNHMIN : global::IEMBFIJKPHO<ushort[]>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly PNCBELNHMIN LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x41FFFC0", Offset = "0x41FE7C0", VA = "0x1841FFFC0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, ushort[] DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x4200080", Offset = "0x41FE880", VA = "0x184200080", Slot = "5")]
	public ushort[] FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public PNCBELNHMIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class FHNBEGGFBCL : global::IEMBFIJKPHO<uint>, GEHOIAKHNGG, global::ECBIDLALAJO<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly FHNBEGGFBCL LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x32BBCC0", Offset = "0x32BA4C0", VA = "0x1832BBCC0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, uint DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x32BBCF0", Offset = "0x32BA4F0", VA = "0x1832BBCF0", Slot = "5")]
	public uint FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x32BBC00", Offset = "0x32BA400", VA = "0x1832BBC00", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, uint DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x32BBD50", Offset = "0x32BA550", VA = "0x1832BBD50", Slot = "7")]
	public uint PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public FHNBEGGFBCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class FEJACOBGNGM : global::IEMBFIJKPHO<uint?>, GEHOIAKHNGG, global::ECBIDLALAJO<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly FEJACOBGNGM LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x32BA450", Offset = "0x32B8C50", VA = "0x1832BA450", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, uint? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x32BA4D0", Offset = "0x32B8CD0", VA = "0x1832BA4D0", Slot = "5")]
	public uint? FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x32BA350", Offset = "0x32B8B50", VA = "0x1832BA350", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, uint? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x32BA580", Offset = "0x32B8D80", VA = "0x1832BA580", Slot = "7")]
	public uint? PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public FEJACOBGNGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class PIOFMJEGFDN : global::IEMBFIJKPHO<uint[]>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly PIOFMJEGFDN LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x41FF980", Offset = "0x41FE180", VA = "0x1841FF980", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, uint[] DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x41FFA40", Offset = "0x41FE240", VA = "0x1841FFA40", Slot = "5")]
	public uint[] FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public PIOFMJEGFDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class NKNFJJNAIIG : global::IEMBFIJKPHO<ulong>, GEHOIAKHNGG, global::ECBIDLALAJO<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly NKNFJJNAIIG LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x41FA240", Offset = "0x41F8A40", VA = "0x1841FA240", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, ulong DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x41FA260", Offset = "0x41F8A60", VA = "0x1841FA260", Slot = "5")]
	public ulong FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x41FA200", Offset = "0x41F8A00", VA = "0x1841FA200", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, ulong DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x41FA270", Offset = "0x41F8A70", VA = "0x1841FA270", Slot = "7")]
	public ulong PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public NKNFJJNAIIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class JEAPBJMBKFJ : global::IEMBFIJKPHO<ulong?>, GEHOIAKHNGG, global::ECBIDLALAJO<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly JEAPBJMBKFJ LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2FE7780", Offset = "0x2FE5F80", VA = "0x182FE7780", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, ulong? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2FE77F0", Offset = "0x2FE5FF0", VA = "0x182FE77F0", Slot = "5")]
	public ulong? FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x2FE7700", Offset = "0x2FE5F00", VA = "0x182FE7700", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, ulong? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2FE7880", Offset = "0x2FE6080", VA = "0x182FE7880", Slot = "7")]
	public ulong? PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public JEAPBJMBKFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class DOAGMBEPIGK : global::IEMBFIJKPHO<ulong[]>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly DOAGMBEPIGK LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x32B45E0", Offset = "0x32B2DE0", VA = "0x1832B45E0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, ulong[] DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x32B4780", Offset = "0x32B2F80", VA = "0x1832B4780", Slot = "5")]
	public ulong[] FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public DOAGMBEPIGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class DDEKNJCBJII : global::IEMBFIJKPHO<float>, GEHOIAKHNGG, global::ECBIDLALAJO<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly DDEKNJCBJII LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x32B2D90", Offset = "0x32B1590", VA = "0x1832B2D90", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, float DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x32B2DA0", Offset = "0x32B15A0", VA = "0x1832B2DA0", Slot = "5")]
	public float FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x32B2CE0", Offset = "0x32B14E0", VA = "0x1832B2CE0", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, float DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x32B2DB0", Offset = "0x32B15B0", VA = "0x1832B2DB0", Slot = "7")]
	public float PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public DDEKNJCBJII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class PJKMOLBEPCH : global::IEMBFIJKPHO<float?>, GEHOIAKHNGG, global::ECBIDLALAJO<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly PJKMOLBEPCH LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x41FFC60", Offset = "0x41FE460", VA = "0x1841FFC60", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, float? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x41FFCD0", Offset = "0x41FE4D0", VA = "0x1841FFCD0", Slot = "5")]
	public float? FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x41FFBE0", Offset = "0x41FE3E0", VA = "0x1841FFBE0", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, float? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x41FFD40", Offset = "0x41FE540", VA = "0x1841FFD40", Slot = "7")]
	public float? PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public PJKMOLBEPCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class PCKILDLDGHE : global::IEMBFIJKPHO<float[]>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly PCKILDLDGHE LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x41FDD90", Offset = "0x41FC590", VA = "0x1841FDD90", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, float[] DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x41FDE50", Offset = "0x41FC650", VA = "0x1841FDE50", Slot = "5")]
	public float[] FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public PCKILDLDGHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class AOJNHAODJIO : global::IEMBFIJKPHO<double>, GEHOIAKHNGG, global::ECBIDLALAJO<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly AOJNHAODJIO LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x32ABFF0", Offset = "0x32AA7F0", VA = "0x1832ABFF0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, double DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x32AC000", Offset = "0x32AA800", VA = "0x1832AC000", Slot = "5")]
	public double FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x32ABF40", Offset = "0x32AA740", VA = "0x1832ABF40", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, double DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x32AC010", Offset = "0x32AA810", VA = "0x1832AC010", Slot = "7")]
	public double PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public AOJNHAODJIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class OCCKGHAKEKC : global::IEMBFIJKPHO<double?>, GEHOIAKHNGG, global::ECBIDLALAJO<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly OCCKGHAKEKC LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x41FCB70", Offset = "0x41FB370", VA = "0x1841FCB70", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, double? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x41FCBE0", Offset = "0x41FB3E0", VA = "0x1841FCBE0", Slot = "5")]
	public double? FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x41FCAF0", Offset = "0x41FB2F0", VA = "0x1841FCAF0", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, double? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x41FCC70", Offset = "0x41FB470", VA = "0x1841FCC70", Slot = "7")]
	public double? PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public OCCKGHAKEKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class GDLALCJIBDO : global::IEMBFIJKPHO<double[]>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly GDLALCJIBDO LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2FE1960", Offset = "0x2FE0160", VA = "0x182FE1960", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, double[] DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2FE1A20", Offset = "0x2FE0220", VA = "0x182FE1A20", Slot = "5")]
	public double[] FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public GDLALCJIBDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class DEKCOLOHLMA : global::IEMBFIJKPHO<bool>, GEHOIAKHNGG, global::ECBIDLALAJO<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly DEKCOLOHLMA LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x32B3590", Offset = "0x32B1D90", VA = "0x1832B3590", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, bool DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x32B35B0", Offset = "0x32B1DB0", VA = "0x1832B35B0", Slot = "5")]
	public bool FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x32B34E0", Offset = "0x32B1CE0", VA = "0x1832B34E0", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, bool DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x32B35C0", Offset = "0x32B1DC0", VA = "0x1832B35C0", Slot = "7")]
	public bool PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public DEKCOLOHLMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class NPKJDCPIPLG : global::IEMBFIJKPHO<bool?>, GEHOIAKHNGG, global::ECBIDLALAJO<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly NPKJDCPIPLG LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x41FAC70", Offset = "0x41F9470", VA = "0x1841FAC70", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, bool? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x41FACE0", Offset = "0x41F94E0", VA = "0x1841FACE0", Slot = "5")]
	public bool? FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x41FABF0", Offset = "0x41F93F0", VA = "0x1841FABF0", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, bool? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x41FAD50", Offset = "0x41F9550", VA = "0x1841FAD50", Slot = "7")]
	public bool? PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public NPKJDCPIPLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class JLADBIACFJC : global::IEMBFIJKPHO<bool[]>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly JLADBIACFJC LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2FF0D10", Offset = "0x2FEF510", VA = "0x182FF0D10", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, bool[] DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2FF0DE0", Offset = "0x2FEF5E0", VA = "0x182FF0DE0", Slot = "5")]
	public bool[] FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public JLADBIACFJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class JDJKGIPJKBC : global::IEMBFIJKPHO<object>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::IEMBFIJKPHO<object> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> BKPLNMALFAA;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2FE6800", Offset = "0x2FE5000", VA = "0x182FE6800", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, object DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2FE7150", Offset = "0x2FE5950", VA = "0x182FE7150", Slot = "5")]
	public object FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public JDJKGIPJKBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class MOOLLJOMPJP : global::IEMBFIJKPHO<byte[]>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::IEMBFIJKPHO<byte[]> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x41F6C30", Offset = "0x41F5430", VA = "0x1841F6C30", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, byte[] DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x41F6CC0", Offset = "0x41F54C0", VA = "0x1841F6CC0", Slot = "5")]
	public byte[] FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public MOOLLJOMPJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class KDHBGEJKHGB : global::IEMBFIJKPHO<ArraySegment<byte>>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::IEMBFIJKPHO<ArraySegment<byte>> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1160", Offset = "0x2FEF960", VA = "0x182FF1160", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, ArraySegment<byte> DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1200", Offset = "0x2FEFA00", VA = "0x182FF1200", Slot = "5")]
	public ArraySegment<byte> FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public KDHBGEJKHGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class DPGENKLKJMN : global::IEMBFIJKPHO<string>, GEHOIAKHNGG, global::ECBIDLALAJO<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::IEMBFIJKPHO<string> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x32B6690", Offset = "0x32B4E90", VA = "0x1832B6690", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, string DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x32B66B0", Offset = "0x32B4EB0", VA = "0x1832B66B0", Slot = "5")]
	public string FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x32B6690", Offset = "0x32B4E90", VA = "0x1832B6690", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, string DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x32B66B0", Offset = "0x32B4EB0", VA = "0x1832B66B0", Slot = "7")]
	public string PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public DPGENKLKJMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class INJDPJAIJMF : global::IEMBFIJKPHO<string[]>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly INJDPJAIJMF LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5960", Offset = "0x2FE4160", VA = "0x182FE5960", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, string[] DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5A20", Offset = "0x2FE4220", VA = "0x182FE5A20", Slot = "5")]
	public string[] FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public INJDPJAIJMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class DNLINHNDDKC : global::IEMBFIJKPHO<char>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly DNLINHNDDKC LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x32B44D0", Offset = "0x32B2CD0", VA = "0x1832B44D0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, char DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x32B4550", Offset = "0x32B2D50", VA = "0x1832B4550", Slot = "5")]
	public char FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public DNLINHNDDKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class FEJDJDPGDPB : global::IEMBFIJKPHO<char?>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly FEJDJDPGDPB LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x32BA680", Offset = "0x32B8E80", VA = "0x1832BA680", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, char? DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x32BA790", Offset = "0x32B8F90", VA = "0x1832BA790", Slot = "5")]
	public char? FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public FEJDJDPGDPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class LNGEKKNKBJD : global::IEMBFIJKPHO<char[]>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly LNGEKKNKBJD LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x41F61A0", Offset = "0x41F49A0", VA = "0x1841F61A0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, char[] DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x41F6320", Offset = "0x41F4B20", VA = "0x1841F6320", Slot = "5")]
	public char[] FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public LNGEKKNKBJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class NGMIFNKFGPP : global::IEMBFIJKPHO<Guid>, GEHOIAKHNGG, global::ECBIDLALAJO<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::IEMBFIJKPHO<Guid> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x41F9610", Offset = "0x41F7E10", VA = "0x1841F9610", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, Guid DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x41F96F0", Offset = "0x41F7EF0", VA = "0x1841F96F0", Slot = "5")]
	public Guid FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x41F9530", Offset = "0x41F7D30", VA = "0x1841F9530", Slot = "6")]
	public void CKNFEIAKBCF(ref FGEHJBFCCPO MNFKPJJAJNI, Guid DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x41F96F0", Offset = "0x41F7EF0", VA = "0x1841F96F0", Slot = "7")]
	public Guid PCPCNMECNAE(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public NGMIFNKFGPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class GINGKBKKLAM : global::IEMBFIJKPHO<decimal>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::IEMBFIJKPHO<decimal> LAADFIIMHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool BFPPIAPINJC;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xAC8A50", Offset = "0xAC7250", VA = "0x180AC8A50")]
	public GINGKBKKLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xDF1BE0", Offset = "0xDF03E0", VA = "0x180DF1BE0")]
	public GINGKBKKLAM(bool BFPPIAPINJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x2FE2220", Offset = "0x2FE0A20", VA = "0x182FE2220", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, decimal DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2FE2360", Offset = "0x2FE0B60", VA = "0x182FE2360", Slot = "5")]
	public decimal FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class LIGIBIGIIEB : global::IEMBFIJKPHO<Uri>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::IEMBFIJKPHO<Uri> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x41F4730", Offset = "0x41F2F30", VA = "0x1841F4730", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, Uri DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x41F47E0", Offset = "0x41F2FE0", VA = "0x1841F47E0", Slot = "5")]
	public Uri FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public LIGIBIGIIEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class OEKMNHHCHOC : global::IEMBFIJKPHO<Version>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::IEMBFIJKPHO<Version> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x41FD6B0", Offset = "0x41FBEB0", VA = "0x1841FD6B0", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, Version DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x41FD760", Offset = "0x41FBF60", VA = "0x1841FD760", Slot = "5")]
	public Version FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public OEKMNHHCHOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class PIBGLKNFOJP<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class EEHNLOICDMC : global::IEMBFIJKPHO<StringBuilder>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::IEMBFIJKPHO<StringBuilder> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x32B7080", Offset = "0x32B5880", VA = "0x1832B7080", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, StringBuilder DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x32B70D0", Offset = "0x32B58D0", VA = "0x1832B70D0", Slot = "5")]
	public StringBuilder FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public EEHNLOICDMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class JCIFMMAIHBF : global::IEMBFIJKPHO<BitArray>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::IEMBFIJKPHO<BitArray> LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2FE6520", Offset = "0x2FE4D20", VA = "0x182FE6520", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, BitArray DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x2FE65B0", Offset = "0x2FE4DB0", VA = "0x182FE65B0", Slot = "5")]
	public BitArray FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public JCIFMMAIHBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class IENIFCPDHID : global::IEMBFIJKPHO<Type>, GEHOIAKHNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly IENIFCPDHID LAADFIIMHNA;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex MMOLKMACABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool KCHBBCJBKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool EGGHENKFAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool NLCKOPBCFCF;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5490", Offset = "0x2FE3C90", VA = "0x182FE5490")]
	public IENIFCPDHID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5440", Offset = "0x2FE3C40", VA = "0x182FE5440")]
	public IENIFCPDHID(bool KCHBBCJBKBJ, bool EGGHENKFAOK, bool NLCKOPBCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5190", Offset = "0x2FE3990", VA = "0x182FE5190", Slot = "4")]
	public void FAKLEMDHHIN(ref FGEHJBFCCPO MNFKPJJAJNI, Type DOBKOKNNFGA, INLBFPHKJMK MABPNEFLOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5280", Offset = "0x2FE3A80", VA = "0x182FE5280", Slot = "5")]
	public Type FNNNELOCNNN(ref FJJCAGOJJPJ HIADHCJGEEA, INLBFPHKJMK MABPNEFLOMF)
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
